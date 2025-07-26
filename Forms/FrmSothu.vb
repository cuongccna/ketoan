Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmSothu
    Dim Ngay(1) As Date
    Private Sub CmdTK_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CmdTK_4.Click
        Dim Index As Integer = Array.IndexOf(CmdTK, eventSender)
        Select Case Index
            Case 0
                Me.Cursor = Cursors.WaitCursor
                txtShTk(0).Text = FrmKhachHang.ChonKhachHang(txtShTk(0).Text)
                Me.Cursor = Cursors.Default
                txtShTk(0).Focus()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim ten As String = String.Empty
        Dim taikhoan As New ClsTaikhoan
        Dim doiung As New ClsTaikhoan
        Select Case Index
            Case 0
                ClearGrid(Grd, Grd.Rows)
                If Ngay(1) < Ngay(0) Then
                    MedNgay(1).Text = MedNgay(0).Text : MedNgay_Leave(MedNgay(1), New EventArgs())
                End If
                taikhoan.InitTaikhoanSohieu("1111")
                LietKeSoChitiet(taikhoan, Ngay(0), Ngay(1), True, doiung.sohieu, 0, 0)
            Case 1
                Me.Close()
            Case 2
                Inphieuthu(txtShTk(1).Text)
            Case 3
                With Grd
                    For i As Integer = 0 To .Rows - 1
                        .Row = i : .Col = 1
                        If .CtlText = "" Then
                            Exit For
                        Else
                            Inphieuthu(.CtlText, 1)
                        End If
                    Next
                End With
        End Select
        Exit Sub
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If Grd.Rows < 30 Then Grd.Rows = 30
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSothu_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.L
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.I
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.T
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSothu_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(Grd, 0, 350, 2)
            ColumnSetUp(Grd, 1, 1190, 0)
            ColumnSetUp(Grd, 2, 830, 1)
            ColumnSetUp(Grd, 3, 3110, 0)
            ColumnSetUp(Grd, 4, 1520, 1)
            Grd.Cols = 5
            For chi_so As Integer = 0 To 1
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next
            SetFont(Me)
            Command_ClickEvent(Command(0), New EventArgs())

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
    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.DoubleClick
        Grd.Col = 1
        Inphieuthu(Grd.CtlText)
    End Sub
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
    ''' <param name="taikhoan"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="doiung"></param>
    ''' <param name="VV"></param>
    ''' <param name="loai"></param>
    ''' <param name="nn"></param>
    ''' <param name="mdt1"></param>
    ''' <param name="mdt2"></param>
    ''' <param name="mdt3"></param>
    ''' <remarks></remarks>
    Public Sub LietKeSoChitiet(ByRef taikhoan As ClsTaikhoan, ByRef ndau As Date, ByRef ncuoi As Date, ByRef thongbao As Boolean, ByRef doiung As String, ByRef VV As Integer, Optional ByRef loai As Integer = 0, Optional ByRef nn As Integer = 0, Optional ByRef mdt1 As Integer = 0, Optional ByRef mdt2 As Integer = 0, Optional ByRef mdt3 As Integer = 0)
        Dim dkc, dkn, dknt As Double
        Dim rs As DataTable
        Dim sql As String
        Dim i As Integer
        Dim ps As Boolean = taikhoan.TkCoPSN(ndau, ncuoi)
        Dim sqlw As String = WNgay("NgayGS", ndau, ncuoi)
        taikhoan.SoDuNgay(ndau.AddDays(-1), dkn, dkc, dknt)
        If Not (dkn = 0 And dkc = 0 And (Not ps)) Then
            ' In bao cao
            If ps Then
                sql = String.Format("((HethongTK_2.SoHieu LIKE '{0}%'{1}) Or (HethongTK_3.SoHieu LIKE '{0}%'{2}))", _
                          taikhoan.sohieu, _
                          (IIf(doiung.Length > 0, String.Format(" And HethongTK_3.SoHieu LIKE '{0}%'", doiung), String.Empty)), _
                          (IIf(doiung.Length > 0, String.Format(" And HethongTK_2.SoHieu LIKE '{0}%'", doiung), String.Empty)))
                rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT ChungTu.mathuchi as GhiChu,ChungTu.Ngaygs, N'{0}' as DienGiai, sum(ChungTu.SoPS) as sops FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ((HethongTK.SoHieu LIKE '{1}%'{2}) Or (HethongTK_1.SoHieu LIKE '{1}%'{3})) And {4}{5}{6}{7}{8} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) group by ChungTu.mathuchi,ChungTu.Ngaygs having left(chungtu.mathuchi,2)=N'{9}' ORDER BY chungtu.ngaygs", _
                                         (IIf(cuongthuchi = 1, "Phiếu thu", "Phiếu chi")), _
                                         taikhoan.sohieu, _
                                         (IIf(doiung.Length = 0, "", String.Format(" And HethongTK_3.SoHieu LIKE '{0}%'", doiung))), _
                                         (IIf(doiung.Length = 0, "", String.Format(" And HethongTK_2.SoHieu LIKE '{0}%'", doiung))), _
                                         sqlw, _
                                         (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
                                         (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
                                         (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
                                         (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty)), _
                                         (IIf(cuongthuchi = 1, "PT", "PC"))))
                i = 1
                GauGe.Value = 1
                Grd.Rows = rs.Rows.Count
                For Each rsItem As DataRow In rs.Rows
                    With Grd
                        .Row = (i - 1)
                        .Col = 0
                        .CtlText = ConvertToStrSafe(i)
                        For j As Integer = 1 To 4
                            .Col = j
                            If j = 4 Then
                                .CtlText = Format(rsItem(j - 1), Mask_0)
                            Else
                                .CtlText = rsItem(j - 1)
                            End If
                        Next
                    End With
                    GauGe.Value = i
                    i += 1
                Next
                Me.Text = String.Format(Ngonngu("Sổ thu chi trong kỳ ", "Book revenues and expenditures in the period") + "{0} - {1}", MedNgay(0).Text, MedNgay(1).Text)
                Exit Sub
            End If
        End If
        If thongbao Then MessageBox.Show(Ngonngu("Không có số đầu kỳ hoặc phát sinh !", "There are no beginning or arising !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_1.KeyPress, _txtShTk_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 13 Then
                    Me.Cursor = Cursors.WaitCursor
                    txtShTk(0).Text = FrmKhachHang.ChonKhachHang(txtShTk(0).Text)
                    Me.Cursor = Cursors.Default
                    txtShTk(1).Focus()
                End If
            Case 1
                If KeyAscii = 13 Then
                    Command(2).Focus()
                    Command_ClickEvent(Command(2), New EventArgs())
                End If
        End Select
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="inphieu">Nếu sophieu=0 thi in 1 phiếu, nếu sophieu=1 thi in nhiều phiếu</param>
    ''' <remarks></remarks>
    Private Sub Inphieuthu(ByRef sh As String, Optional ByRef inphieu As Integer = 0)
        Dim sotien As String = String.Empty
        Dim ttien As Double
        Dim rs As DataTable
        Dim stt As Integer
        Dim psno, TkCo, tkno, psco As String
        sh = sh.ToUpper()
        Dim nnt As String = txtShTk(0).Text
        Dim tentc As String = ConvertToStrSafe(GetSelectValue(String.Format("SELECT ten AS F1 FROM khachhang WHERE sohieu=N'{0}'", nnt)))
        Dim diachitc As String = String.Format("Nhân viên - {0}", frmMain._LbCty_0.Text)
        Dim reportFilename As String
        If tentc = "" Then
            MessageBox.Show(Ngonngu("Vui lòng nhập số hiệu người nộp tiền !", "Please enter the number or the payer"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Else
            SetRptInfo()
            If cuongthuchi = 1 Then
                TkCo = "TKco"
                psco = "PSco"
                tkno = "TKno"
                psno = "PSno"
                reportFilename = "PHIEUTHU1.RPT"
            Else
                TkCo = "TKno"
                psco = "PSno"
                tkno = "TKco"
                psno = "PSco"
                reportFilename = "PHIEUCHI1.RPT"
            End If

            rptFrom.InitForm(reportFilename, "SELECT * FROM BaoCaoCP2", "BaoCaoCP2")

            With Grd
                For i As Integer = 0 To .Rows - 1
                    .Row = i : .Col = 1
                    If .CtlText = sh Then
                        .Col = 4
                        ttien = ConvertToDblSafe(.CtlText)
                        Exit For
                    End If
                Next
            End With
            rs = ExecSQLReturnDT(String.Format("SELECT t1.mathuchi,sum(t1.sops) as sops,{0}.sohieu FROM hethongtk {0} right join chungtu t1 on t1.ma{0}={0}.maso group by t1.mathuchi,{0}.sohieu having t1.mathuchi=N'{1}' order by {0}.sohieu", tkno, sh))
            stt = 0
            Dim mathuchi1 = String.Empty, mathuchi2 As String = String.Empty
            Dim tongtien As Double
            If rs.Rows.Count > 0 Then
                mathuchi1 = IIf(IsDBNull(rs.Rows(0)("SoHieu")), "", rs.Rows(0)("SoHieu"))
            End If
            For Each rsItem As DataRow In rs.Rows
                mathuchi2 = IIf(IsDBNull(rsItem("SoHieu")), "", rsItem("SoHieu"))
                If mathuchi1 <> mathuchi2 And mathuchi2 <> "" Then
                    rptFrom.SetFormulas(tkno & CStr(stt), String.Format("'{0}'", mathuchi1))
                    rptFrom.SetFormulas(psno & CStr(stt), tongtien)
                    mathuchi1 = mathuchi2
                    tongtien = ConvertToDblSafe(rsItem("sops"))
                    stt += 1
                Else
                    If mathuchi1 = mathuchi2 And mathuchi2 <> "" Then tongtien += ConvertToDblSafe(rsItem("sops"))
                End If
            Next
            If rs.Rows.Count <> 0 Then
                rptFrom.SetFormulas(tkno & CStr(stt), String.Format("'{0}'", mathuchi1))
                rptFrom.SetFormulas(psno & CStr(stt), tongtien)
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT t1.mathuchi,sum(t1.sops) as sops,{0}.sohieu FROM hethongtk {0} right join chungtu t1 on t1.ma{0}={0}.maso group by t1.mathuchi,{0}.sohieu having t1.mathuchi=N'{1}' order by {0}.sohieu", _
                                     TkCo, _
                                     sh))
            stt = 1 : tongtien = 0
            If rs.Rows.Count > 0 Then
                mathuchi1 = IIf(IsDBNull(rs.Rows(0)("SoHieu")), "", ConvertToStrSafe(rs.Rows(0)("SoHieu")))
            End If
            For Each rsItem As DataRow In rs.Rows
                mathuchi2 = IIf(IsDBNull(rsItem("SoHieu")), "", ConvertToStrSafe(rsItem("SoHieu")))
                If mathuchi1 <> mathuchi2 And mathuchi2 <> "" Then
                    rptFrom.SetFormulas(TkCo & CStr(stt), String.Format("'{0}'", mathuchi1))
                    rptFrom.SetFormulas(psco & CStr(stt), tongtien)
                    mathuchi1 = mathuchi2
                    tongtien = rsItem("sops")
                    stt += 1
                Else
                    If mathuchi1 = mathuchi2 And mathuchi2 <> "" Then tongtien += ConvertToDblSafe(rsItem("sops"))
                End If
            Next
            If rs.Rows.Count <> 0 Then
                rptFrom.SetFormulas(TkCo & CStr(stt), String.Format("'{0}'", mathuchi1))
                rptFrom.SetFormulas(psco & CStr(stt), tongtien)
            End If
            sotien = String.Format("{0} đồng chẵn", ToVNText(Math.Abs(ttien)))
            rptFrom.SetFormulas("X", String.Format("'{0}'", Format(ttien, Mask_0)))
            rptFrom.SetFormulas("SoHieu", String.Format("'{0}'", sh))
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", diachitc))
            rptFrom.SetFormulas("DiaChiDN", String.Format("'{0}'", frmMain._LbCty_2.Text))
            rptFrom.SetFormulas("TelDN", String.Format("'{0}'", frmMain._LbCty_3.Text))
            Grd.Col = 2
            rptFrom.SetFormulas("Ngay", String.Format(Ngonngu("Ngày :{0}", "Date:{0}"), Format(Grd.CtlText, Mask_DB)))
            rptFrom.SetFormulas("BangChu", String.Format("'{0}'", sotien))
            rptFrom.SetFormulas("TenNV", String.Format("'{0}'", tentc))
            rptFrom.SetFormulas("LyDo", String.Format("'{0}{1}'", (IIf(cuongthuchi = 1, "Doanh Thu ", "Nhập Hàng ")), Format(Grd.CtlText, Mask_DB)))
            rptFrom.ReportWindowTitle = rptFrom.ReportFilename
            rptFrom.ReportDestination = inphieu
            InBaoCaoRPT()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSothu_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
