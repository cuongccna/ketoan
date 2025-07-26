Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmBCVT
    Dim baocao As Integer
    Dim Ngay(1) As Date

    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim tdau, tcuoi As Integer
        Me.Cursor = Cursors.Default
        Select Case Index
            Case 0, 1
                If CboThang(0).Items.Count > 0 Then tdau = CboThang(0).SelectedValue
                If CboThang(1).Items.Count > 0 Then tcuoi = CboThang(1).SelectedValue
                'coi theo ngay
                Select Case baocao
                   
                    Case 0
                        If _OptTG_0.Checked = True Then
                            BangKeLuuChuyen(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), CboKho(0).SelectedValue, CboKho(1).SelectedValue)
                        Else
                            Dim t1 As String = _MedNgay_0.Text.Split("/")(1)
                            Dim t2 As String = _MedNgay_1.Text.Split("/")(1)
                            BangKeLuuChuyen(t1, t2, _MedNgay_0.Text, _MedNgay_1.Text, CboKho(0).SelectedValue, CboKho(1).SelectedValue)
                        End If
                    Case 1
                        If _OptTG_0.Checked = True Then
                            BangKeNhapKho(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), IIf(Chk(0).CheckState = CheckState.Checked, CboKho(2).SelectedValue, 0), IIf(Chk(1).CheckState = CheckState.Checked, CboLoai.SelectedValue, 0))
                        Else
                            Dim t1 As String = _MedNgay_0.Text.Split("/")(1)
                            Dim t2 As String = _MedNgay_1.Text.Split("/")(1)
                            BangKeNhapKho(t1, t2, _MedNgay_0.Text, _MedNgay_1.Text, CboKho(0).SelectedValue, CboKho(1).SelectedValue)
                        End If
                End Select

                If Not RptOK(rptFrom.ReportFilename, 0) Then
                    MessageBox.Show("Mẫu báo cáo đã bị thay đổi!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo kt
                End If
                On Error GoTo Bad1
                SetRptInfo()
                rptFrom = rptFrom.copyReportObject(rptFrom)
                With rptFrom
                    .ReportDestination = Index
                    .ReportWindowTitle = OptBC(baocao).Text
                    .ReportWindowState = System.Windows.Forms.FormWindowState.Maximized

                    Dim reportMessage As String = .DoReport()
                    If String.IsNullOrEmpty(reportMessage) Then

                    End If
                End With
                GoTo kt
            Case 2
                Me.Close() : Exit Sub
        End Select
Bad1:
        MessageBox.Show(String.Format("Error {0}: {1}", Information.Err().Number, Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
kt:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmBCVT_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
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
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmBCVT_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            'CboCopy(CboKho(0), CboKho(1))
            'CboCopy(CboKho(0), CboKho(2))
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(0))
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(1))
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(2))
            Int_RecsetToCbo("SELECT PhanLoaiVattu.MaSo As F2, (PhanLoaiVattu.SoHieu + ' - '+ PhanLoaiVattu.TenPhanLoai) As F1 FROM PhanLoaiVattu ORDER BY PhanLoaiVattu.SoHieu", CboLoai)
            For chi_so As Integer = 0 To 1
                AddMonthToCbo(CboThang(chi_so))
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next
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
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean
    Private Sub OptBC_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptBC_1.CheckedChanged, _OptBC_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptBC, eventSender)
            baocao = Index
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="K1"></param>
    ''' <param name="k2"></param>
    ''' <remarks></remarks>
    Private Sub BangKeLuuChuyen(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef K1 As Integer, ByRef k2 As Integer)
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT ct.MaCT as mact, ct.SoHieu as sohieu, ct.NgayCT as ngayct, ct.NgayGS as ngaygs, min(vt.tenvattu) as DienGiai, Sum(ct.SoPS) AS SoTien FROM ChungTu ct inner join vattu vt on ct.mavattu=vt.maso WHERE ct.MaLoai=4 AND ct.MaKho={0} AND ct.MaNguon={1} AND {2} GROUP BY ct.MaCT, ct.SoHieu, ct.NgayCT, ct.NgayGS, ct.DienGiai ORDER BY ct.NgayCT, ct.MaCT", _
                                K1, _
                                ConvertToStrSafe(k2), _
                                wsql)
        With rptFrom
            .InitForm("BKLCNB.RPT", sql, "QTheKho")
            .SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi)))))
            .SetFormulas("DienGiai", String.Format("'Từ kho: {0} đến kho: {1}'", tenkho(K1), tenkho(k2)))
        End With
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="mk"></param>
    ''' <param name="ml"></param>
    ''' <remarks></remarks>
    Private Sub BangKeNhapKho(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mk As Integer, ByRef ml As Integer)
        Dim wsql As String = String.Format("{0} AND {1}", (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))), (IIf(mk > 0, String.Format("((MaLoai=1 AND MaKho={0}) OR (MaLoai=4 AND MaNguon={1}))", mk, ConvertToStrSafe(mk)), "(MaLoai=1 OR MaLoai=4)")))
        Dim cap As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Cap AS F1 FROM PhanLoaiVattu WHERE MaSo={0}", ml)))
        'Dim sql As String = String.Format("SELECT MaCT, ChungTu.SoHieu, NgayCT, NgayGS, DienGiai, Sum(SoPS) AS SoTien, (HethongTK.Sohieu) AS TKDU, (KhachHang.Sohieu) AS SHKH, (KhachHang.Ten) AS TenKH  FROM ((({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo) LEFT JOIN KhachHang ON ChungTu.MaKHC=KhachHang.MaSo  WHERE {1}{2} GROUP BY MaCT, ChungTu.SoHieu, NgayCT, NgayGS, DienGiai ORDER BY NgayCT, MaCT", _
        '                        ChungTu2TKNC(1), _
        '                        wsql, _
        '                        (iif(ml > 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%' AND (PhanLoaiVattu.Cap>{1} OR PhanLoaiVattu.MaSo={2})", MaSo2SoHieu(ml, "PhanLoaiVattu"), ConvertToStrSafe(cap), ConvertToStrSafe(ml)), String.Empty)))
        Dim sql As String = String.Format("SELECT MaCT, ChungTu.SoHieu, NgayCT, NgayGS, DienGiai, Sum(SoPS) AS SoTien, HethongTK.Sohieu AS TKDU, KhachHang.Sohieu AS SHKH, KhachHang.Ten AS TenKH  FROM ((({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo) LEFT JOIN KhachHang ON ChungTu.MaKHC=KhachHang.MaSo  WHERE {1}{2} GROUP BY MaCT,KhachHang.Ten, ChungTu.SoHieu,KhachHang.SoHieu, NgayCT, NgayGS, DienGiai,HethongTK.SoHieu ORDER BY NgayCT, MaCT", _
                                      ChungTu2TKNC(1), _
                                      wsql, _
                                      (IIf(ml > 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%' AND (PhanLoaiVattu.Cap>{1} OR PhanLoaiVattu.MaSo={2})", MaSo2SoHieu(ml, "PhanLoaiVattu"), ConvertToStrSafe(cap), ConvertToStrSafe(ml)), String.Empty)))
        With rptFrom
            .InitForm("BKNK.RPT", sql, "QTheKho")
            .SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi)))))
            If mk > 0 Then .SetFormulas("DienGiai", String.Format(Ngonngu("'Kho: {0}'", "'Stock: {0}'"), tenkho(mk)))
            If ml > 0 Then .SetFormulas("DienGiai2", String.Format(Ngonngu("'Loại hàng hoá: {0}'", "'Classification or goods: {0}'"), TenPLVT("0", ml)))
        End With
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmBCVT_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
