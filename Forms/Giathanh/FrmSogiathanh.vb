Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel


Partial Friend Class FrmSogiathanh
    Dim baocao, nn As Integer
    Dim Ngay(2) As Date
    Dim xlapp As Excel.Application
    Dim xlsheet As Excel.Worksheet

    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboThang_0.SelectedIndexChanged, _CboThang_1.SelectedIndexChanged
        Dim CboSohieu_NewIndex2 As Integer = -1
        Dim CboSohieu_NewIndex As Integer = -1
        Dim recset As DataTable
        Try
            If CboThang(1).Items.Count > 0 Then
                If baocao = 1 And CboThang(1).Items.Count > 0 Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
            End If
            recset = ExecSQLReturnDT(String.Format("SELECT sohieu As f1, mact as f2 FROM thanhpham WHERE {0} GROUP BY sohieu, mact", WThang("thang", CboThang(0).SelectedValue, CboThang(1).SelectedValue)))
            CboSohieu.Items.Clear()
            CboSohieu.Items.ItemsBase.Clear()
            If recset.Rows.Count > 0 Then
                CboSohieu.Items.Add("Toàn bộ", 0)
                For Each recsetItem As DataRow In recset.Rows
                    If Not IsDBNull(recsetItem("f1")) Then
                        CboSohieu.Items.Add(ConvertToStrSafe(recsetItem("f1")), ConvertToStrSafe(recsetItem("F2")))
                    End If
                Next
                If CboSohieu.Items.Count > 0 Then
                    CboSohieu.SelectedIndex = 0
                End If

            End If
        Catch
            CboSohieu.Items.Clear()
            CboSohieu.Items.ItemsBase.Clear()
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdtk_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdtk_9.Click
        Dim Index As Integer = Array.IndexOf(cmdtk, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtShTk(Index).Text = FrmTaikhoan.ChonTk(txtShTk(Index).Text)
        txtShTk(Index).Focus()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim taikhoan As New ClsTaikhoan
        Dim doiung As New ClsTaikhoan
        Dim rs_tk As DataTable
        Dim tdau, tcuoi As Integer
        Dim i As Integer
        Dim tp(Max1000) As Integer, tp1(Max1000) As Integer
        Dim dong As Integer
        Select Case Index
            Case 0, 1
                Me.Cursor = Cursors.WaitCursor
                GauGe.Value = 0
                If CboThang(1).Items.Count > 0 Then
                    If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue

                Select Case baocao
                    Case 0 : THDoanhThuGiaVon(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), IIf(ChkDu(9).CheckState = CheckState.Checked, CboKho(1).SelectedIndex, 0), IIf(ChkDu(12).CheckState = CheckState.Checked, txtShTk(9).Text, String.Empty), ChkDu(13).CheckState)
                    Case 1 : If CboSohieu.Items.Count > 0 Then XemDD(tdau, CboSohieu.SelectedValue) Else MessageBox.Show(Ngonngu("Chưa có phát sinh thành phẩm trong kỳ ", "No product in the period incurred"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : GoTo LoiBC
                    Case 2 : InChiPhi3(tdau, tcuoi, pNN)
                    Case 10
                        If pDTTP <> 0 Then
                            InChiPhi4(tdau, tcuoi, nn, CboSohieu.Text)
                        Else
                            If Not InChiPhi(tdau, tcuoi, True, nn) Then GoTo LoiBC
                        End If
                    Case 11
                        If pDTTP <> 0 Then
                            If CboSohieu.Items.Count = 0 Then
                                MessageBox.Show(Ngonngu("Chưa có phát sinh thành phẩm trong kỳ ", "No product in the period incurred"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : GoTo LoiBC
                            End If
                            InKetQua3(tdau, tcuoi, 0, nn, CboSohieu.SelectedValue)
                        Else
                            If Not InKetQua(tdau, tcuoi, 0, True, nn) Then GoTo LoiBC
                        End If
                    Case 50
                        If CboSohieu.Items.Count = 0 Then
                            MessageBox.Show(Ngonngu("Chưa có phát sinh thành phẩm trong kỳ ", "No product in the period incurred"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : GoTo LoiBC
                        End If
                        InChiPhi2(tdau, tcuoi, nn, CboSohieu.SelectedValue)
                    Case 51
                        If pDTTP <> 0 Then
                            InBKGiaThanh2(tdau, tcuoi)
                        Else
                            InBKGiaThanh(tcuoi)
                        End If
                        GoTo LoiBC
                    Case 54
                        With FrmThanhPham
                            .Grd.Col = 1
                            If .Visible Then
                                If ConvertToDblSafe((.Command(7).Tag)) = 1 Then
                                    dong = .Grd.Row
                                    .Grd.Row = 0
                                    i = 1
                                    While .Grd.CtlText <> ""
                                        tp(i) = ConvertToDblSafe(Timten("maso", .Grd.CtlText, "sohieu", "vattu"))
                                        .Grd.Row = i : i += 1
                                    End While
                                    .Grd.Row = dong
                                End If
                                If Not BKDinhMuc(CDate(.MedNgay.Text).Month, tp, tp1, .Grd.CtlText, ConvertToDblSafe(.Command(7).Tag)) Then GoTo LoiBC
                            Else
                                If Not BKDinhMuc(tcuoi, tp, tp1) Then GoTo LoiBC
                            End If
                        End With
                    Case 59
                        ChiPhiCT(ConvertToDblSafe(txtCT(0).Tag), tdau, tcuoi)
                    Case 33
                        InPSVuViec(CboVV(0).SelectedIndex, tdau, tcuoi, CboVV(0).Text)
                End Select
                rptFrom.ReportDestination = Index
a:
                If Not RptOK(rptFrom.ReportFilename, nn) Then
                    MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "Change report form!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo LoiBC
                End If
                rptFrom.ReportWindowTitle = OptBC(baocao).Text
                rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
                SetRptInfo()
                InBaoCaoRPT()
                GoTo LoiBC
            Case 2
                Me.Close()
        End Select
        GoTo LoiBC
        ErrMsg(er_KoXem)
        GoTo LoiBC
Bad:
        MessageBox.Show(String.Format("Error {0}: {1}", Information.Err().Number, Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
LoiBC:
        HienThongBao(Me.Text, 1)
        GauGe.Value = GauGe.Maximum
        taikhoan = Nothing
        doiung = Nothing
        rs_tk = Nothing
        Me.Cursor = Cursors.Default
        If _CboThang_1.Items.Count > 0 Then
            chiso1 = _CboThang_1.SelectedIndex
        End If
        If _CboThang_0.Items.Count > 0 Then
            chiso0 = _CboThang_0.SelectedIndex
        End If
    End Sub

    Private chiso1 As Integer = -1
    Private chiso0 As Integer = -1
    Public Sub FrmSogiathanh_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))
            InitDateVars(MedNgay(0), Ngay(0))
            InitDateVars(MedNgay(1), Ngay(1))
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(1))
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(0))
            Int_RecsetToCbo("SELECT DoituongCT.MaSo As F2,(CASE WHEN DoituongCT.MaKhachHang>0 THEN KhachHang.Ten+' - '+DoituongCT.Sohieu+' - ' ELSE '' END + DienGiai + CASE WHEN DoituongCT.MaKhachHang>0 THEN ' - '+ CONVERT(NVARCHAR,NgayKy,103) ELSE '' END) As F1 FROM DoituongCT LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo ORDER BY  KhachHang.Ten,DoituongCT.SoHieu,DienGiai", CboVV(0))
            OptBC_CheckedChanged(OptBC(10), New EventArgs())
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
    Private Sub FrmSogiathanh_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(0).Focus()
                Case Keys.I
                    Command(1).Focus()
                Case Keys.V
                    Command(2).Focus()
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
    Private Sub FrmSogiathanh_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        'xlapp = Nothing
        xlsheet = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean
    Private Sub OptBC_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptBC_2.CheckedChanged, _OptBC_1.CheckedChanged, _OptBC_0.CheckedChanged, _OptBC_10.CheckedChanged, _OptBC_11.CheckedChanged, _OptBC_33.CheckedChanged, _OptBC_50.CheckedChanged, _OptBC_51.CheckedChanged, _OptBC_59.CheckedChanged, _OptBC_54.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptBC, eventSender)
            baocao = Index
            If baocao = 0 Then
                Frame(2).Visible = True
                OptTG(1).Enabled = True
                ChkDu(13).Visible = (pChietKhau > 0 And OptBC(0).Checked)
                CboThang(1).Enabled = True
                Label(1).Enabled = True
            ElseIf baocao = 1 And CboThang(1).Items.Count > 0 And CboThang(0).Items.Count > 0 Then
                If CboThang(1).Items.Count > 0 Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                CboThang(1).Enabled = False
                Label(1).Enabled = False
            Else
                Frame(2).Visible = False
                OptTG(1).Enabled = False
                OptTG(0).Checked = True
                CboThang(1).Enabled = True
                Label(1).Enabled = True
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdCT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdCT_0.Click
        Dim Index As Integer = Array.IndexOf(cmdCT, eventSender)
        txtCT(Index).Text = FrmTP.ChonTP(txtCT(Index).Text)
        txtCT_Leave(txtCT(Index), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptTG_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptTG_1.CheckedChanged, _OptTG_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptTG, eventSender)
            Frame(1 - Index).Visible = False
            Frame(Index).Visible = True
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtCT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtCT_0.Enter
        Dim Index As Integer = Array.IndexOf(txtCT, eventSender)
        txtCT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtCT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtCT_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtCT, eventSender)
        If KeyAscii = 13 Then
            txtCT(Index).Text = FrmTP.ChonTP(txtCT(Index).Text)
            txtCT(Index).Focus()
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
    Private Sub txtCT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtCT_0.Leave
        Dim Index As Integer = Array.IndexOf(txtCT, eventSender)
        Dim m As Integer
        txtCT(Index).Text = txtCT(Index).Text.ToUpper()
        LbCT(Index).Text = ConvertToStrSafe(GetSelectValue("SELECT TenVattu AS F1,MaSo AS F2 FROM TP154 WHERE SoHieu='" & txtCT(Index).Text & "'", m))
        txtCT(Index).Tag = ConvertToStrSafe(m)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InBKGiaThanh2(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim sonvl, i, sotp As Integer
        Dim sh1 As New StringBuilder
        Dim tp As New Cls154
        Dim L, T As Double
        xlapp = New Excel.Application()
        Dim st As String = String.Empty
        Dim sql As String = String.Format("SELECT DISTINCT MaVattu FROM ChungTu WHERE {0} AND MaVattu>0 AND MaTP>0 GROUP BY MaVattu", WThang("ThangCT", tdau, tcuoi))
        Dim rs As DataTable = ExecSQLReturnDT(sql)

        If Not (rs.Rows.Count = 0) Then
            GauGe.Maximum = 5

            Dim excelFilename As String = "GiaThanh.xls"
            Dim excelOutputPath As String = Path.Combine(pCurDir + "\TEMP\", excelFilename)
            Dim excelTemplateFilePath As String = Path.Combine(pCurDir + "\RePorts\", excelFilename)
            Dim curSheet As Excel.Worksheet

            Try
                Recycle(excelOutputPath)
            Catch ex As Exception
            End Try

            Try
                File.Copy(excelTemplateFilePath, excelOutputPath)
                ' OpenBook(excelTemplateFilePath)
                'xlsheet = Excel_Global.Worksheets(1)
                xlapp.Workbooks.Open(excelOutputPath)
                xlsheet = xlapp.Worksheets(1)

                xlsheet.Cells(1, 1) = pTenCty
                xlsheet.Cells(2, 1) = pTenCn
                xlsheet.Cells(3, 1) = CboKho(0).Text
                xlsheet.Cells(5, 1) = ThoiGianTheoThang(tdau, tcuoi)
                i = 0
                For Each rsItem As DataRow In rs.Rows
                    i += 1
                    xlsheet.Cells(7, 4 + 2 * i) = ConvertToStrSafe(rsItem("MaVattu"))
                    xlsheet.Cells(8, 4 + 2 * i) = "Lượng"
                    xlsheet.Cells(8, 5 + 2 * i) = "Tiền"
                    xlsheet.Range(String.Format("{0}7", XLSCol(4 + 2 * i)), String.Format("{0}7", XLSCol(5 + 2 * i))).MergeCells = True
                Next
                sonvl = i
                xlsheet.Cells(7, 6 + 2 * sonvl) = "Tổng NVL"
                xlsheet.Cells(7, 7 + 2 * sonvl) = "Nhân công"
                xlsheet.Cells(7, 8 + 2 * sonvl) = "KH TSCĐ"
                xlsheet.Cells(7, 9 + 2 * sonvl) = "CP SX khác"
                xlsheet.Cells(7, 10 + 2 * sonvl) = "Tổng CP"
                xlsheet.Cells(7, 11 + 2 * sonvl) = "Đơn giá"
                For i = 0 To 5
                    xlsheet.Range(String.Format("{0}7", XLSCol(6 + i + 2 * sonvl)), String.Format("{0}8", XLSCol(6 + i + 2 * sonvl))).MergeCells = True
                Next
                GauGe.Value = 2
                sql = String.Format("SELECT DISTINCT MaTP FROM ChungTu WHERE {0} GROUP BY MaTP", WThang("ThangCT", tdau, tcuoi))
                i = 0
                rs = ExecSQLReturnDT(sql)
                For Each rsItem As DataRow In rs.Rows
                    i += 1
                    xlsheet.Cells(8 + i, 2) = ConvertToStrSafe(rsItem("MaTP"))
                    xlsheet.Cells(8 + i, 5) = 1
                Next
                sotp = i
                xlsheet.Cells(sotp + 9, 2) = "Tổng cộng"
                GauGe.Value = 3
                For i = 1 To sonvl
                    For j As Integer = 1 To sotp
                        Dim sqlSum As String = String.Format("SELECT ISNULL(Sum(SoPS2Co), 0) AS F1, ISNULL(Sum(SoPS), 0) AS F2 FROM ChungTu  WHERE {0} AND MaTP={1} AND MaVattu={2}", _
                                                                WThang("ThangCT", tdau, tcuoi), _
                                                                xlsheet.Cells(8 + j, 2)._Default, _
                                                                xlsheet.Cells(7, 4 + 2 * i)._Default)

                        L = ConvertToDblSafe(GetSelectValue(sqlSum, T))
                        xlsheet.Cells(8 + j, 4 + 2 * i) = Format(L, Mask_2)
                        xlsheet.Cells(8 + j, 5 + 2 * i) = Format(T, Mask_0)
                    Next
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(5 + 2 * i), ConvertToStrSafe(sotp + 9))).Formula = String.Format("=SUM({0}9:{0}{1})", _
                                                                                                XLSCol(5 + 2 * i), _
                                                                                                (sotp + 8))
                    xlsheet.Cells(7, 4 + 2 * i) = ConvertToStrSafe(GetSelectValue(String.Format("SELECT SoHieu AS F1 FROM Vattu WHERE MaSo={0}", xlsheet.Cells(7, 4 + 2 * i)._Default)))
                Next
                For i = 1 To 5
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(5 + 2 * sonvl + i), sotp + 9)).Formula = String.Format("=SUM({0}9:{0}{1})", _
                                                                                                        XLSCol(5 + 2 * sonvl + i), _
                                                                                                        ConvertToStrSafe(sotp + 8)) 'Excel Fomular
                Next
                GauGe.Value = 4
                For i = 1 To sotp
                    sh1 = New StringBuilder("")
                    For j As Integer = 1 To sonvl
                        If sh1.Length = 0 Then
                            sh1.Append(String.Format("{0}{1}", XLSCol(5 + 2 * j), ConvertToStrSafe(i + 8)))
                        Else
                            sh1.Append(String.Format(" + {0}{1}", XLSCol(5 + 2 * j), ConvertToStrSafe(i + 8)))
                        End If
                    Next
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(6 + 2 * sonvl), ConvertToStrSafe(i + 8))).Formula = String.Format("={0}", sh1) 'Excel Fomular
                    tp.InitTPMaSo(ConvertToDblSafe(xlsheet.Cells(8 + i, 2).Value))
                    xlsheet.Cells(8 + i, 7 + 2 * sonvl) = Format(tp.SoCPNC(tdau, tcuoi), Mask_0)
                    T = tp.SoCPKH(tdau, tcuoi)
                    xlsheet.Cells(8 + i, 8 + 2 * sonvl) = Format(T, Mask_0)
                    xlsheet.Cells(8 + i, 9 + 2 * sonvl) = Format(tp.SoCPSXC(tdau, tcuoi) - T, Mask_0)

                    xlsheet.Range(String.Format("{0}{1}", XLSCol(10 + 2 * sonvl), ConvertToStrSafe(i + 8))).Formula = String.Format("={0}{1}+{2}{1}+{3}{1}+{4}{1}", XLSCol(6 + 2 * sonvl), ConvertToStrSafe(i + 8), XLSCol(7 + 2 * sonvl), XLSCol(8 + 2 * sonvl), XLSCol(9 + 2 * sonvl)) 'Excel Fomular
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(11 + 2 * sonvl), ConvertToStrSafe(i + 8))).Formula = String.Format("={0}{1}/E{1}", XLSCol(10 + 2 * sonvl), ConvertToStrSafe(i + 8)) 'Excel Fomular

                    sh1 = New StringBuilder("")
                    xlsheet.Cells(8 + i, 1) = ConvertToStrSafe(i)
                    xlsheet.Cells(8 + i, 2) = tp.TenVattu
                    xlsheet.Cells(8 + i, 3) = tp.SoHieu
                    xlsheet.Cells(8 + i, 4) = tp.DonVi
                Next
                xlsheet.Range("A4", String.Format("{0}4", XLSCol(2 * sonvl + 11))).MergeCells = True
                xlsheet.Range("A5", String.Format("{0}5", XLSCol(2 * sonvl + 11))).MergeCells = True
                With xlsheet.Range("A7", String.Format("{0}{1}", XLSCol(2 * sonvl + 11), ConvertToStrSafe(sotp + 9)))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                    Dim tempRefParam As Object = .Borders.Color
                    tempRefParam = Color.FromArgb(0, 0, 0)
                    Dim tempRefParam2 As Object = .RowHeight
                    tempRefParam2 = 18
                    .Font.Size = 6
                    Dim tempRefParam3 As Object = .VerticalAlignment
                    tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
                End With

            Catch ex As Exception
            Finally
                xlapp.Workbooks(1).Save()
                xlapp.Workbooks.Close()
                ' curSheet.SaveAs(excelOutputPath)
                'CloseBook(excelTemplateFilePath)
                xlsheet = Nothing
                xlapp = Nothing
                curSheet = Nothing
                GauGe.Value = 3
                'CallExcel(excelOutputPath)
                CallExcel("\TEMP\GiaThanh.xls")

            End Try
        Else
            MessageBox.Show("Không có dữ liệu để xem !", "Thông báo", Nothing, MessageBoxIcon.Information)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Private Sub InBKGiaThanh(ByRef thang As Integer)
        Dim sonvl, i, sotp As Integer
        Dim sh1 As String = String.Empty
        Dim L, T, dgia As Double
        Dim st As String = String.Empty
        Dim sql As String = String.Format("SELECT DISTINCT MaNVL FROM ThanhPham INNER JOIN DinhMuc ON ThanhPham.MaTP=DinhMuc.MaTP WHERE ThanhPham.Thang={0} AND MaNVL>0 GROUP BY MaNVL", thang)
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If Not (rs.Rows.Count = 0) Then
            GauGe.Maximum = 5

            Dim excelFilename As String = "GiaThanh.xls"
            Dim excelOutputPath As String = Path.Combine(pCurDir, excelFilename)
            Dim excelTemplateFilePath As String = Path.Combine(pCurDir, String.Format("RePorts\{0}", excelFilename))
            Dim curSheet As New Excel.Worksheet
            Try
                Recycle(excelOutputPath)
            Catch ex As Exception

            End Try

            Try
                File.Copy(excelTemplateFilePath, excelOutputPath)
                OpenBook(excelTemplateFilePath)
                xlsheet = Excel_Global.Worksheets(1)

                xlsheet.Cells(1, 1) = pTenCty
                xlsheet.Cells(2, 1) = pTenCn
                xlsheet.Cells(3, 1) = CboKho(0).Text
                xlsheet.Cells(5, 1) = ThoiGianTheoThang(thang, thang)
                i = 0
                For Each rsItem As DataRow In rs.Rows
                    i += 1
                    xlsheet.Cells(7, 4 + 2 * i) = ConvertToStrSafe(rsItem("maNVL"))
                    xlsheet.Cells(8, 4 + 2 * i) = "Lượng"
                    xlsheet.Cells(8, 5 + 2 * i) = "Tiền"
                    xlsheet.Range(String.Format("{0}7", XLSCol(4 + 2 * i)), String.Format("{0}7", XLSCol(5 + 2 * i))).MergeCells = True
                Next
                sonvl = i
                xlsheet.Cells(7, 6 + 2 * sonvl) = "Tổng NVL"
                xlsheet.Cells(7, 7 + 2 * sonvl) = "Nhân công"
                xlsheet.Cells(7, 8 + 2 * sonvl) = "KH TSCĐ"
                xlsheet.Cells(7, 9 + 2 * sonvl) = "CP SX khác"
                xlsheet.Cells(7, 10 + 2 * sonvl) = "Tổng CP"
                xlsheet.Cells(7, 11 + 2 * sonvl) = "Đơn giá"
                For i = 0 To 5
                    xlsheet.Range(String.Format("{0}7", XLSCol(6 + i + 2 * sonvl)), String.Format("{0}8", XLSCol(6 + i + 2 * sonvl))).MergeCells = True
                Next
                GauGe.Value = 2
                sql = String.Format("SELECT DISTINCT MaTP,Sum(SoLuong) AS Luong FROM ThanhPham WHERE Thang={0} GROUP BY MaTP", thang)
                i = 0
                rs = ExecSQLReturnDT(sql)
                For Each rsItem As DataRow In rs.Rows
                    i += 1
                    xlsheet.Cells(8 + i, 2) = ConvertToStrSafe(rsItem("MaTP"))
                    xlsheet.Cells(8 + i, 5) = Format(rsItem("luong"), Mask_2)
                Next
                sotp = i
                xlsheet.Cells(sotp + 9, 2) = "Tổng cộng"
                GauGe.Value = 3
                For i = 1 To sonvl
                    dgia = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SoPS/SoPS2Co AS F1 FROM ChungTu WHERE MaLoai=2 AND ThangCT={0} AND CT_ID>610000000 AND MaVattu={1}", _
                                                               thang, _
                                                               xlsheet.Cells(7, 4 + 2 * i))))
                    For j As Integer = 1 To sotp
                        L = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(ThanhPham.SoLuong*DinhMuc.SoLuong) AS F1 FROM ThanhPham INNER JOIN DinhMuc ON ThanhPham.MaTP=DinhMuc.MaTP WHERE ThanhPham.Thang={0} AND ThanhPham.MaTP={1} AND MaNVL={2}", _
                                                                thang, _
                                                                xlsheet.Cells(8 + j, 2), _
                                                                xlsheet.Cells(7, 4 + 2 * i))))
                        xlsheet.Cells(8 + j, 4 + 2 * i) = Format(L, Mask_2)
                        T = RoundMoney(L * dgia)
                        xlsheet.Cells(8 + j, 5 + 2 * i) = Format(T, Mask_0)
                    Next
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(5 + 2 * i), (sotp + 9))).Formula = String.Format("=SUM({0}9:{0}{1})", XLSCol(5 + 2 * i), ConvertToStrSafe(sotp + 8)) 'Excel Fomular
                    xlsheet.Cells(7, 4 + 2 * i) = ConvertToStrSafe(GetSelectValue(String.Format("SELECT SoHieu AS F1 FROM Vattu WHERE MaSo={0}", (xlsheet.Cells(7, 4 + 2 * i)))))
                Next
                For i = 1 To 5
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(5 + 2 * sonvl + i), ConvertToStrSafe(sotp + 9))).Formula = String.Format("=SUM({0}9:{0}{1})", XLSCol(5 + 2 * sonvl + i), ConvertToStrSafe(sotp + 8)) 'Excel Fomular
                Next
                GauGe.Value = 4
                For i = 1 To sotp
                    sh1 = ""
                    For j As Integer = 1 To sonvl
                        sh1 = String.Format("{0} + {1}{2}", sh1, XLSCol(5 + 2 * j), ConvertToStrSafe(i + 8))
                    Next
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(6 + 2 * sonvl), ConvertToStrSafe(i + 8))).Formula = String.Format("={0}", sh1) 'Excel Fomular
                    xlsheet.Cells(8 + i, 7 + 2 * sonvl) = Format((GetSelectValue(String.Format("SELECT SUM(CPNC) AS F1 FROM ThanhPham WHERE Thang={0} AND MaTP={1}", thang, xlsheet.Cells(8 + i, 2)))), Mask_0)
                    xlsheet.Cells(8 + i, 8 + 2 * sonvl) = Format((GetSelectValue(String.Format("SELECT SUM(CPKH) AS F1 FROM ThanhPham WHERE Thang={0} AND MaTP={1}", thang, xlsheet.Cells(8 + i, 2)))), Mask_0)
                    xlsheet.Cells(8 + i, 9 + 2 * sonvl) = Format((GetSelectValue(String.Format("SELECT SUM(CPSXC) AS F1 FROM ThanhPham WHERE Thang={0} AND MaTP={1}", thang, xlsheet.Cells(8 + i, 2)))), Mask_0)
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(10 + 2 * sonvl), ConvertToStrSafe(i + 8))).Formula = String.Format("={0}{1}+{2}{1}+{3}{1}+{4}{1}", XLSCol(6 + 2 * sonvl), ConvertToStrSafe(i + 8), XLSCol(7 + 2 * sonvl), XLSCol(8 + 2 * sonvl), XLSCol(9 + 2 * sonvl)) 'Excel Fomular
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(11 + 2 * sonvl), ConvertToStrSafe(i + 8))).Formula = String.Format("={0}{1}/E{1}", XLSCol(10 + 2 * sonvl), ConvertToStrSafe(i + 8)) 'Excel Fomular
                    sh1 = ""
                    xlsheet.Cells(8 + i, 1) = ConvertToStrSafe(i)
                    xlsheet.Cells(8 + i, 2) = TenVT(sh1, ConvertToDblSafe((xlsheet.Cells(8 + i, 2))), st)
                    xlsheet.Cells(8 + i, 3) = sh1
                    xlsheet.Cells(8 + i, 4) = st
                Next
                With xlsheet.Range("A7", XLSCol(2 * sonvl + 11) & ConvertToStrSafe(sotp + 9))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                    Dim tempRefParam As Object = .Borders.Color
                    tempRefParam = Color.FromArgb(0, 0, 0)
                    Dim tempRefParam2 As Object = .RowHeight
                    tempRefParam2 = 18
                    .Font.Size = 6
                    Dim tempRefParam3 As Object = .VerticalAlignment
                    tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
                End With

                curSheet.SaveAs(excelOutputPath)

            Catch ex As Exception

            Finally
                CloseBook(excelTemplateFilePath)

                GauGe.Value = 3
                CallExcel(excelOutputPath)

                curSheet = Nothing
            End Try
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="tp"></param>
    ''' <param name="tp1"></param>
    ''' <param name="SoHieu"></param>
    ''' <param name="Ftp"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function BKDinhMuc(ByRef thang As Integer, ByRef tp() As Integer, ByRef tp1() As Integer, Optional ByRef SoHieu As String = "", Optional ByRef Ftp As Integer = 0) As Boolean
        Dim thangdm, SoTPchon As Integer
        Dim str As String = String.Empty
        Dim i As Integer
        Dim QNhatky As String = String.Format("SELECT matp,max(thang) as thang1 FROM dinhmuc WHERE thang<={0} group by matp", thang)
        Dim str11 As String = String.Format("UPDATE DinhMuc SET ThangHL=CASE WHEN Thang={0} THEN Thang ELSE 0 END", thang)
        ExecSQLNonQuery(str11)
        Dim rs As DataTable = ExecSQLReturnDT("SELECT MaTP FROM DinhMuc WHERE ThangHL=0 GROUP BY MaTP")
        For Each rsItem As DataRow In rs.Rows
            Dim str1 As String = String.Format("SELECT  TOP 1 Thang AS F1 FROM DinhMuc WHERE MaNVL>0 AND MaTP={0} AND {1} ORDER BY {2} DESC", _
                                                          rsItem("MaTP"), _
                                                          WThang("Thang", thang, thang), _
                                                          SetMonthOrder("Thang"))
            thangdm = ConvertToDblSafe(GetSelectValue(str1))
            Dim str2 As String = String.Format("UPDATE DinhMuc SET ThangHL={0} WHERE Thang={1} AND MaTP={2}", _
                                thang, _
                                ConvertToStrSafe(thangdm), _
                                rsItem("MaTP"))
            ExecSQLNonQuery(str2)
        Next
        If SoHieu.Length <> 0 And tp(1) = 0 Then
            thang = ConvertToDblSafe(GetSelectValue(String.Format("SELECT max(thang) as f1 FROM dinhmuc inner join vattu on dinhmuc.matp=vattu.maso WHERE vattu.sohieu=N'{0}' and thang<={1}", SoHieu, ConvertToStrSafe(thang))))
            str = String.Format("SELECT Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, VT.SoHieu AS SNVL, VT.TenVattu AS TNVL, VT.DonVi AS DNVL, DinhMuc.SoLuong AS LuongNVL FROM (DinhMuc INNER JOIN Vattu ON DinhMuc.MaTP=Vattu.MaSo) INNER JOIN Vattu AS VT ON DinhMuc.MaNVL=VT.MaSo  WHERE Vattu.sohieu=N'{0}' and thang={1}", SoHieu, ConvertToStrSafe(thang))
        Else
            If SoHieu.Length = 0 And tp(1) = 0 Then SoTPchon = FrmChon.ChonCTSoA(pDataPath, thang, tp, tp1)
            i = 1
            If tp(i) <> 0 Then
                'SetSQL("QNhatky", String.Format("SELECT matp,max(thang) as thang1 FROM dinhmuc WHERE thang<={0} group by matp", thang))
                ' QNhatky = String.Format("SELECT matp,max(thang) as thang1 FROM dinhmuc WHERE thang<={0} group by matp", thang)
                str = String.Format("SELECT Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, VT.SoHieu AS SNVL, VT.TenVattu AS TNVL, VT.DonVi AS DNVL, DinhMuc.SoLuong AS LuongNVL FROM ((DinhMuc INNER JOIN ({1}) as QNhatky ON DinhMuc.thang=QNhatky.thang1 and DinhMuc.matp=QNhatky.matp) INNER JOIN Vattu ON DinhMuc.MaTP=Vattu.MaSo) INNER JOIN Vattu AS VT ON DinhMuc.MaNVL=VT.MaSo  WHERE DinhMuc.MaTP={0}", tp(i), QNhatky)
                i += 1
            End If
            While tp(i) <> 0
                str = String.Format("{0} or DinhMuc.MaTP={1}", str, ConvertToStrSafe(tp(i)))
                i += 1
            End While
            If i > 1 And tp1(i - 1) = 0 And Ftp = 0 Then
                i = 1
                If tp1(i) <> 0 Then
                    str = String.Format("SELECT dinhmuc.maso FROM ((DinhMuc INNER JOIN QNhatky ON DinhMuc.thang=QNhatky.thang1 and DinhMuc.matp=QNhatky.matp) INNER JOIN Vattu ON DinhMuc.MaTP=Vattu.MaSo) INNER JOIN Vattu AS VT ON DinhMuc.MaNVL=VT.MaSo  WHERE DinhMuc.MaTP={0}", tp1(i))
                    i += 1
                    While tp1(i) <> 0
                        str = String.Format("{0} or DinhMuc.MaTP={1}", str, ConvertToStrSafe(tp1(i)))
                        i += 1
                    End While
                    str = String.Format("SELECT Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, VT.SoHieu AS SNVL, VT.TenVattu AS TNVL, VT.DonVi AS DNVL, DinhMuc.SoLuong AS LuongNVL FROM ((DinhMuc INNER JOIN QNhatky ON DinhMuc.thang=QNhatky.thang1 and DinhMuc.matp=QNhatky.matp) INNER JOIN Vattu ON DinhMuc.MaTP=Vattu.MaSo) INNER JOIN Vattu AS VT ON DinhMuc.MaNVL=VT.MaSo  WHERE dinhmuc.maso not in({0}) ", str)
                Else
                    str = String.Format("SELECT Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, VT.SoHieu AS SNVL, VT.TenVattu AS TNVL, VT.DonVi AS DNVL, DinhMuc.SoLuong AS LuongNVL" & " FROM ((DinhMuc INNER JOIN ({0}) as QNhatky ON DinhMuc.thang=QNhatky.thang1 and DinhMuc.matp=QNhatky.matp) INNER JOIN Vattu ON DinhMuc.MaTP=Vattu.MaSo) INNER JOIN Vattu AS VT ON DinhMuc.MaNVL=VT.MaSo ", QNhatky)
                End If
            End If
        End If
        If str = "" Then
            Return False
        End If
        rptFrom.InitForm("DM.RPT", str, "QLuyKe")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(thang, thang)))
        rptFrom.SetFormulas("Diachi", String.Format("'Địa chỉ: {0}'", frmMain._LbCty_2.Text))

        RptSetDate(NgayCuoiThang(pNamTC, thang))
        Return True
    End Function
    Private Sub ChiPhiCT(ByRef mct As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim s621 As Double = SoCPPB(tdau, tcuoi, "CPNVLPB", mct)
        Dim s622 As Double = SoCPPB(tdau, tcuoi, "CPNCPB", mct)
        Dim s623 As Double = SoCPPB(tdau, tcuoi, "CPMPB", mct)
        Dim s627 As Double = SoCPPB(tdau, tcuoi, "CPSXC_", mct)
        Dim sql As String = String.Format("SELECT ChungTu.SoHieu AS SHCT,NgayCT,DienGiai{0},Sum(SoPS) AS SOPS,LEFT(CASE WHEN (TK.TK_ID={1}) THEN TK.SoHieu ELSE HethongTK.SoHieu END,3) AS SHTK, CASE WHEN (TK.TK_ID={1}) THEN HethongTK.SoHieu ELSE TK.SoHieu END AS SHCo FROM ({2}) INNER JOIN TP154 ON ChungTu.MaTP=TP154.MaSo  WHERE (HethongTK.SoHieu LIKE '62%' OR HethongTK.SoHieu LIKE '64%' OR TK.SoHieu LIKE '51%') AND {3}{4} GROUP BY NgayCT,ChungTu.SoHieu,NgayCT,DienGiai{0},LEFT(CASE WHEN (TK.TK_ID={1}) THEN TK.SoHieu ELSE HethongTK.SoHieu END,3), CASE WHEN(TK.TK_ID={1}) THEN HethongTK.SoHieu ELSE TK.SoHieu END UNION SELECT ChungTu.SoHieu AS SHCT,NgayCT,DienGiai{0},Sum(SoPS) AS SOPS,LEFT(HethongTK.SoHieu,3) AS SHTK,'...' AS SHCo FROM ({5}) INNER JOIN TP154 ON ChungTu.MaTP=TP154.MaSo  WHERE MaTKCo=0 AND (HethongTK.SoHieu LIKE '62%' OR HethongTK.SoHieu LIKE '64%') AND {3}{4} GROUP BY NgayCT, ChungTu.SoHieu ,DienGiai{0},LEFT(HethongTK.SoHieu,3) UNION SELECT ChungTu.SoHieu AS SHCT,NgayCT,DienGiai{0},Sum(CASE WHEN LEFT(HethongTK.SoHieu,3)<>'154' THEN -SoPS ELSE SoPS END) AS SOPS,LEFT(TK.SoHieu,3) AS SHTK,HethongTK.SoHieu AS SHCo FROM ({2}) INNER JOIN TP154 ON ChungTu.MaTP=TP154.MaSo  WHERE HethongTK.Loai=6 AND (TK.SoHieu LIKE '62%' OR TK.SoHieu LIKE '64%') AND {3}{4} GROUP BY ChungTu.SoHieu,NgayCT,DienGiai{0},LEFT(TK.SoHieu,3),HethongTK.SoHieu ORDER BY NgayCT", _
                                (IIf(pNN > 0, "E", String.Empty)), _
                                ConvertToStrSafe(TKDT_ID), _
                                ChungTu2TKNC(10), _
                                WThang("ThangCT", tdau, tcuoi), _
                                (IIf(mct > 0, " AND MaTP=" & mct, String.Empty)), _
                                ChungTu2TKNC(-1))
        If s621 <> 0 Then sql = String.Format("{0} UNION SELECT 'xxx' AS SHCT, '{1}' AS NgayCT,'{2}',{3},'621','...' FROM License", sql, Format(NgayCuoiThang(pNamTC, tcuoi), Mask_DB), ("Phân bổ chi phí nguyên vật liệu"), CStr(s621))
        If s622 <> 0 Then sql = String.Format("{0} UNION SELECT 'xxx' AS SHCT, '{1}' AS NgayCT,'{2}',{3},'622','...' FROM License", sql, Format(NgayCuoiThang(pNamTC, tcuoi), Mask_DB), ("Phân bổ chi phí nhân công"), CStr(s622))
        If s623 <> 0 Then sql = String.Format("{0} UNION SELECT 'xxx' AS SHCT, '{1}' AS NgayCT,'{2}',{3},'623','...' FROM License", sql, Format(NgayCuoiThang(pNamTC, tcuoi), Mask_DB), ("Phân bổ chi phí máy thi công"), CStr(s623))
        If s627 <> 0 Then sql = String.Format("{0} UNION SELECT 'xxx' AS SHCT, '{1}' AS NgayCT,'{2}',{3},'627','...' FROM License", sql, Format(NgayCuoiThang(pNamTC, tcuoi), Mask_DB), ("Phân bổ chi phí sản xuất chung"), CStr(s627))

        rptFrom.InitForm("CTCT.RPT", sql, "QChitiet")
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        If txtCT(0).Text.Length > 0 Then
            rptFrom.SetFormulas("TK", String.Format("'{0} - {1}'", txtCT(0).Text, LbCT(0).Text))
        Else
            rptFrom.SetFormulas("TK", "''")
        End If
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="VV"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="dg"></param>
    ''' <remarks></remarks>
    Private Sub InPSVuViec(ByRef VV As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef dg As String)

        Dim sql As String, rs As DataTable

        sql = "DELETE FROM BaoCaoCP"
        ExecSQLNonQuery(sql)

        sql = "INSERT INTO BaoCaoCP(MaSo, SoHieu, Cap, MaCha) SELECT MaSo, SoHieu, Cap, TKCha0 FROM HethongTK WHERE Cap<2 AND Loai>0 ORDER BY case when LEFT(SoHieu,1) = 'L' then Right(SoHieu,1) else SoHieu end"
        ExecSQLNonQuery(sql)

        For i = 1 To 8
            ExecSQLNonQuery("UPDATE BaoCaoCP set kq" + CStr(i) + "=0 where kq" + CStr(i) + " is null")
        Next

        sql = "SELECT DISTINCT min(BaoCaoCP.MaSo) AS MS, BaoCaoCP.SoHieu, Sum(ChungTu.SoPS) AS PS" _
            & " FROM (" + ChungTu2TKNC(-2) + ") INNER JOIN BaoCaoCP ON HeThongTK.SoHieu LIKE BaocaoCP.SoHieu" _
            & " WHERE " + WThang("ThangCT", tdau, tcuoi) + " AND MaDT = " + CStr(VV) + " GROUP BY BaoCaoCP.SoHieu"
        rs = New DataTable
        rs = ExecSQLReturnDT(sql)
        For Each rsitem As DataRow In rs.Rows
            ExecSQLNonQuery("UPDATE BaoCaoCP SET Kq1 = " + CStr(rsitem("ps")) + " WHERE MaSo = " + CStr(rsitem("ms")))
        Next

        sql = "SELECT DISTINCT min(BaoCaoCP.MaSo) AS MS, BaoCaoCP.SoHieu, Sum(ChungTu.SoPS) AS PS" _
            & " FROM (" + ChungTu2TKNC(2) + ") INNER JOIN BaoCaoCP ON HeThongTK.SoHieu LIKE BaocaoCP.SoHieu" _
            & " WHERE " + WThang("ThangCT", tdau, tcuoi) + " AND MaDT = " + CStr(VV) + " GROUP BY BaoCaoCP.SoHieu"
        rs = New DataTable
        rs = ExecSQLReturnDT(sql)
        For Each rsitem As DataRow In rs.Rows
            ExecSQLNonQuery("UPDATE BaoCaoCP SET Kq2 = " + CStr(rsitem("ps")) + " WHERE MaSo = " + CStr(rsitem("ms")))
        Next

        sql = "DELETE FROM BaoCaoCP WHERE Kq1 = 0 AND Kq2 = 0 AND Cap > 0"
        ExecSQLNonQuery(sql)

        sql = "SELECT DISTINCT BaoCaoCP.SoHieu, BaocaoCP.Cap, HethongTK.Ten" + IIf(pNN > 0, "E", "") + ", Kq1, Kq2" _
            & " FROM BaoCaoCP INNER JOIN HethongTK ON BaoCaoCP.MaSo = HethongTK.MaSo"

        rptFrom.InitForm("PSVV.RPT", sql, "QTongHopCT")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("TaiKhoan", String.Format("'{0}'", dg))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_9.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_9.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If KeyAscii = 13 Then cmdtk_ClickEvent(cmdtk(Index), New EventArgs())
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    '==============================================================================================================
    ' Kiểm tra số hiệu tài khoản đã nhập
    '==============================================================================================================
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_9.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).Text = txtShTk(Index).Text.ToUpper()
        Dim mtk As Integer = 0
        LbTenTk(Index).Text = tentk(txtShTk(Index).Text, mtk)
        txtShTk(Index).Tag = ConvertToStrSafe(mtk)
        HienThongBao(Me.Text, 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="MaCT"></param>
    ''' <remarks></remarks>
    Sub XemDD(ByRef thang As Integer, Optional ByRef MaCT As Integer = 0)

        Dim rs As DataTable, sl As Double, nC As Double, nvl As Double, sxc As Double
        Dim sl1 As Double, nc1 As Double, nvl1 As Double, sxc1 As Double
        Dim MaSo As Long, Ngay As Date, sxcn As Double, sxcn1 As Double

        rs = New DataTable
        rs = ExecSQLReturnDT("select vt.maso,vt.sohieu,vt.tenvattu,tk.masokho from (vattu vt inner join dinhmuc dm on vt.maso=dm.matp)inner join tonkho tk on vt.maso=tk.mavattu where 1 = 1 " + IIf(OptKho(0).Checked = True, " and tk.masokho=" + CStr(CboKho(0).SelectedValue), "") + " group by vt.maso,vt.sohieu,vt.tenvattu,tk.masokho order by vt.maso")
        If rs.Rows.Count = 0 Then Exit Sub
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        If CboSohieu.SelectedIndex < 0 Then Exit Sub
        If MaCT = 0 And CboSohieu.SelectedIndex >= 0 Then
            CboSohieu.SelectedIndex += 1
            MaCT = CboSohieu.SelectedValue
        End If
        Ngay = Timten("ngay", CStr(MaCT), "mact", "thanhpham")
        For Each rsitem As DataRow In rs.Rows
            Dim abc As String
            abc = rsitem("TenVattu")
            sl = GetSelectValue("select last(SoLuong) as f1,last(CPNC) as f2,last(CPSXC) as f3,last(CPSXCN) as f4,last(CPNVL) as f5 from thanhphamdd where mact<" + CStr(MaCT) + " and matp=" + CStr(rsitem("MaSo")) + " and makhonvl=" + CStr(rsitem("MaSoKho")) + " and ngay=(select max(ngay) from thanhphamdd where mact<" + CStr(MaCT) + " and matp=" + CStr(rsitem("MaSo")) + " and ngay<='" + Format(Ngay, Mask_DB) + "' and makhonvl=" + CStr(rsitem("MaSoKho")) + ") group by ngay", nC, sxc, sxcn, nvl)
            If sl <> 0 Or nC <> 0 Or sxc <> 0 Or nvl <> 0 Then ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4) VALUES (" + CStr(Lng_MaxValue("maso", "baocaocp2") + 1) + ",'" + rsitem("SoHieu") + "','" + rsitem("TenVattu") + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc) + ")")
            sl1 = GetSelectValue("select sum(SoLuong) as f1,sum(CPNC) as f2,sum(CPSXC) as f3,sum(CPSXCN) as f4,sum(CPNVL) as f5 from thanhphamdd where mact=" + CStr(MaCT) + " and matp=" + CStr(rsitem("MaSo")) + " and makhonvl=" + CStr(rsitem("MaSoKho")) + " and ngay='" + Format(Ngay, Mask_DB) + "'", nc1, sxc1, sxcn1, nvl1)
            If sl1 <> 0 Then
                ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4,Kq5) VALUES (" + CStr(Lng_MaxValue("maso", "baocaocp2") + 1) + ",'" + rsitem("SoHieu") + ".','" + rsitem("TenVattu") + "'," + CStr(sl1) + "," + CStr(nvl1) + "," + CStr(nc1) + "," + CStr(sxc1 + sxcn1) + ",1)")
            Else
                MaSo = GetSelectValue("select maso as f1 from thanhphamdd where mact=" + CStr(MaCT) + " and matp=" + CStr(rsitem("MaSo")) + " and makhonvl=" + CStr(rsitem("MaSoKho")) + " and ngay='" + Format(Ngay, Mask_DB) + "'")
                If sl <> 0 And MaSo = 0 Then ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4,Kq5) VALUES (" + CStr(Lng_MaxValue("maso", "baocaocp2") + 1) + ",'" + rsitem("SoHieu") + ".','" + rsitem("TenVattu") + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc + sxcn) + ",1)")
            End If
        Next
        rptFrom.InitForm("GTCTDD.RPT", "SELECT * FROM BaoCaoCP2", "QNhatky")
        SetRptInfo()
        RptSetDate(NgayCuoiThang(pNamTC, thang))
        rptFrom.SetFormulas("Thang", thang)
        rptFrom.SetFormulas("ThangCuoi", thang)
    End Sub
End Class
