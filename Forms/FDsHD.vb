Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Partial Friend Class FDsHD

    Dim MaTK As Integer
    Dim f1 As Integer
    Dim tongtien As Double
    Dim tienx As Double
    Dim Lsql As String = String.Empty
    ''' <summary>
    ''' Chọn phiếu nhập
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click, _Command_2.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim tien, sono As Double
        Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0
                With GrdCT
                    .Col = 8
                    If .CtlText = "" Then Exit Sub
                    .Col = 7
                    tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    If tien = 0 Then
                        .Col = 5
                        sono = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 7
                        tien = Math.Min(sono, tongtien - tienx)
                        .Items(.Row).SubItems(.Col).Text = Format(tien, Mask_0)
                        tienx += tien
                    Else
                        tienx -= tien
                        .Items(.Row).SubItems(.Col).Text = ""
                    End If
                End With
            Case 1
                Hide()
            Case 2
                If Lsql.Length > 0 Then
                    rptFrom.InitForm("DSHDCTT.RPT", Lsql, "MienTru")

                    rptFrom.SetFormulas("KH", String.Format("'{0}'", LbVattu.Text))
                    rptFrom.SetFormulas("N", String.Format("'{0}'", FrmChungtu.MedNgay(0).Text))
                    InBaoCaoRPT()
                End If
        End Select
        Cursor = Cursors.Default
    End Sub


    Private Sub FormInit()
        If ConvertToDblSafe(Me.Tag) > 0 Then
            Me.Cursor = Cursors.WaitCursor
            If f1 = 0 Then
                LietKePhieuNhap(ConvertToDblSafe(Me.Tag))
            Else
                LietKePhieuNhap2(ConvertToDblSafe(Me.Tag))
            End If
            Me.Tag = -ConvertToDblSafe((Me.Tag))
            Me.Cursor = Cursors.Default
            HienThongBao(Text, 1)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FDsHD_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If Shift = 4 Then
            Select Case eventArgs.KeyCode
                Case Keys.C
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then
            Try
                Hide()
            Catch
            End Try
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FDsHD_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            'Call FormInit()
            Dim s As Integer = Me.Tag
            ColumnSetUp(GrdCT, 0, 965, 2)
            ColumnSetUp(GrdCT, 1, 1220, 2)
            ColumnSetUp(GrdCT, 2, 2630, 0)
            ColumnSetUp(GrdCT, 3, 1310, 4)
            ColumnSetUp(GrdCT, 4, 1310, 4)
            ColumnSetUp(GrdCT, 5, 1310, 4)
            ColumnSetUp(GrdCT, 6, 590, 2)
            ColumnSetUp(GrdCT, 7, 1270, 4)
            ColumnSetUp(GrdCT, 8, 1, 0)
            Text = SetFormTitle(Text)
            KtraCongNo()
            Call FormInit()
            ' LietKePhieuNhap2(s)
            Me.Text = Ngonngu("Danh sách hoá đơn chưa thanh toán", "List of unpaid Invoice")
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
    Private Sub GrdCT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdCT.Click
        Command_ClickEvent(Command(0), New EventArgs())
    End Sub
    ''' <summary>
    ''' Liệt kê phiếu nhập
    ''' </summary>
    ''' <param name="mkh"></param>
    ''' <remarks></remarks>
    Private Sub LietKePhieuNhap(ByRef mkh As Integer)
        'Dim dgia As Double
        Lsql = String.Format("SELECT 2000000000+MaSo AS MS,'DK' AS SoHieu,'01/01/1990' AS NgayCT, N'{0}' AS DienGiai,SoXuat,DuNo_0 AS SoPS,HanTT FROM CNDauNam WHERE (MaTaiKhoan ={1}) AND (MaKhachHang = {2}) AND (DuNo_0>SoXuat) UNION SELECT MaCT, SoHieu, NgayCT, DienGiai, Sum(SoXuat), Sum(SoPS),HanTT FROM Chungtu WHERE MaTKNo ={1} AND (ChungTu.MaKH = {2}) GROUP BY MaCT,SoHieu,NgayCT,DienGiai,HanTT HAVING Sum(SoPS)>Sum(SoXuat) ORDER BY NgayCT DESC, SoHieu DESC", _
                   "Dư đầu kỳ", _
                   MaTK, _
                   ConvertToStrSafe(Math.Abs(mkh)))
        Dim rs_phieu As DataTable = ExecSQLReturnDT(Lsql)
        For Each rsItem As DataRow In rs_phieu.Rows
            Dim bien As String = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                   rsItem("SoHieu"), _
                   Chr(9), _
                   IIf(ConvertToDblSafe(rsItem("ms")) < 2000000000, Format(CDate(rsItem("NgayCT")), Mask_D), String.Empty), _
                   rsItem("DienGiai"), _
                   Format(rsItem("SoPS"), Mask_0), _
                   Format(rsItem("SoXuat"), Mask_0), _
                   Format(ConvertToDblSafe(rsItem("SoPS")) - ConvertToDblSafe(rsItem("SoXuat")), Mask_0), _
                   rsItem("HanTT"), _
                   String.Empty, _
                   rsItem("MS"), 0)
            GrdCT.AddItem(bien)
        Next
        GrdCT.Rows = IIf(rs_phieu.Rows.Count > ConvertToDblSafe(GrdCT.Tag), _
                         rs_phieu.Rows.Count, _
                         ConvertToDblSafe(GrdCT.Tag))
        GrdCT.Row = 0
        GrdCT.Col = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkh"></param>
    ''' <remarks></remarks>
    Private Sub LietKePhieuNhap2(ByRef mkh As Integer)
        'Dim dgia As Double
        Lsql = String.Format("SELECT 2000000000+MaSo AS MS,'DK' AS SoHieu,'01/01/1990' AS NgayCT, N'{0}' AS DienGiai,SoXuat,DuCo_0 AS SoPS,HanTT FROM CNDauNam WHERE (MaTaiKhoan ={1}) AND (MaKhachHang = {2}) AND (DuCo_0>SoXuat) UNION SELECT MaCT, SoHieu, NgayCT, DienGiai, Sum(SoXuat), Sum(SoPS),HanTT FROM Chungtu WHERE MaTKCo ={1} AND (ChungTu.MaKHC = {2}) GROUP BY MaCT,SoHieu,NgayCT,DienGiai,HanTT HAVING Sum(SoPS)>Sum(SoXuat) ORDER BY NgayCT DESC, SoHieu DESC", _
                   ("Dư đầu kỳ"), _
                   MaTK, _
                   ConvertToStrSafe(Math.Abs(mkh)))
        Dim rs_phieu As DataTable = ExecSQLReturnDT(Lsql)
        For Each rsItem As DataRow In rs_phieu.Rows
            GrdCT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{1}{8}", _
                              rsItem("SoHieu"), _
                              Chr(9), _
                              IIf(ConvertToDblSafe(rsItem("ms")) < 2000000000, Format(ConvertToDateSafe(rsItem("NgayCT")), Mask_D), String.Empty), _
                              rsItem("DienGiai"), _
                              Format(rsItem("SoPS"), Mask_0), _
                              Format(rsItem("SoXuat"), Mask_0), _
                              Format(ConvertToDblSafe(rsItem("SoPS")) - ConvertToDblSafe(rsItem("SoXuat")), Mask_0), _
                              rsItem("HanTT"), _
                              rsItem("MS"), 0))
        Next
        GrdCT.Rows = IIf(rs_phieu.Rows.Count > ConvertToDblSafe(GrdCT.Tag), _
                         rs_phieu.Rows.Count, _
                         ConvertToDblSafe(GrdCT.Tag))
        GrdCT.Row = 0
        GrdCT.Col = 0
    End Sub
    ''' <summary>
    ''' Hàm trả về phiếu nhập được chọn
    ''' </summary>
    ''' <param name="mtk"></param>
    ''' <param name="DienGiai"></param>
    ''' <param name="ps"></param>
    ''' <param name="f"></param>
    ''' <param name="mct"></param>
    ''' <param name="tien"></param>
    ''' <param name="sott"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ThanhToanDichDanh(ByRef mtk As Integer, ByRef DienGiai As String, ByRef ps As Double, ByRef f As Integer, ByRef mct() As Integer, ByRef tien() As Double, ByRef sott As Integer) As Integer
        Dim result As Integer = 0
        Dim mct1 As Integer
        Dim tien1 As Double
        f1 = f
        MaTK = mtk
        tongtien = ps
        LbVattu.Text = DienGiai
        ShowDialog()
        sott = 0
        tienx = 0
        With GrdCT
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 8
                mct1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                If mct1 = 0 Then Exit For
                .Col = 7
                tien1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                If tien1 > 0 Then
                    sott += 1
                    ReDim Preserve mct(sott)
                    ReDim Preserve tien(sott)
                    mct(sott) = mct1
                    .Col = 5
                    tien(sott) = tien1
                End If
            Next
        End With
        result = sott
        Me.Close()
        Return result
    End Function
    '   ''' <summary>
    '   ''' 
    '   ''' </summary>
    '   ''' <param name="eventSender"></param>
    '   ''' <param name="eventArgs"></param>
    '   ''' <remarks></remarks>
    'Private Sub GrdCT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs  As KeyPressEventArgs) Handles GrdCT.KeyPress 
    '	If eventArgs.KeyAscii = 13 Or eventArgs.KeyAscii = 32 Then GrdCT_ClickEvent(GrdCT, New EventArgs())
    'End Sub
    '   ''' <summary>
    '   ''' 
    '   ''' </summary>
    '   ''' <param name="eventSender"></param>
    '   ''' <param name="eventArgs"></param>
    '   ''' <remarks></remarks>
    'Private Sub GrdCT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdCT.MouseDown 
    '	If eventArgs.Button = 2 Then
    '		SearchObj(1,  , GrdCT, GrdCT.Col)
    '	End If
    '   End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FDsHD_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
