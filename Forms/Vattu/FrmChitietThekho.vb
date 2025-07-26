Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmChitietThekho
    Dim mkho1 As Integer
    Dim tcuoi1, tdau1, nn1 As Integer
    Dim thongbao1, Lietke As Boolean
    Dim doiung1 As String = String.Empty
    Public mvt1 As Integer
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        ClearGrid(Grd, Grd.Rows)
        LietKethekho(mkho1, mvt1, tdau1, tcuoi1, thongbao1, doiung1, nn1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChitietThekho_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Then Me.Hide()
    End Sub

    Private Sub Khoi_tao()
        ColumnSetUp(Grd, 0, 350, 2)
        ColumnSetUp(Grd, 1, 1180, 0)
        ColumnSetUp(Grd, 2, 830, 4)
        ColumnSetUp(Grd, 3, 2630, 0)
        ColumnSetUp(Grd, 4, 710, 2)
        ColumnSetUp(Grd, 5, 1190, 4)
        ColumnSetUp(Grd, 6, 830, 4)
        ColumnSetUp(Grd, 7, 1550, 4)
        ColumnSetUp(Grd, 8, 830, 4)
        ColumnSetUp(Grd, 9, 1550, 4)
        ColumnSetUp(Grd, 10, 830, 4)
        ColumnSetUp(Grd, 11, 1520, 4)
        Grd.Cols = 12
    End Sub
    Dim co As Integer = 0
    Private Sub FrmChitietThekho_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()
            If co = 0 Then
                Khoi_tao()
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
    ''' <param name="mkho"></param>
    ''' <param name="mvt"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="doiung"></param>
    ''' <param name="nn"></param>
    ''' <remarks></remarks>
    Public Sub LietKethekho(ByRef mkho As Integer, ByRef mvt As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef thongbao As Boolean, Optional ByRef doiung As String = "", Optional ByRef nn As Integer = 0)

        Dim dkt, dkt2 As Double
        Dim rs As DataTable
        Dim sql, st, dv As String
        Dim sqll As New StringBuilder
        Dim i, DVT2 As Integer
        Dim ps As Double
        mkho1 = mkho : mvt1 = mvt : tdau1 = tdau : tcuoi1 = tcuoi : thongbao1 = thongbao : nn1 = nn : doiung1 = doiung
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqll.Length = 0 Then
                sqll.Append(String.Format("Luong_Nhap_{0} + Luong_Xuat_{0} + Tien_Nhap_{0} + Tien_Xuat_{0}", i))
            Else
                sqll.Append(String.Format(" + Luong_Nhap_{0} + Luong_Xuat_{0} + Tien_Nhap_{0} + Tien_Xuat_{0}", i))
            End If
        Next
        st = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
        Dim dkl As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(Luong_{0}) As F1, SUM(Tien_{0}) As F2,{1} As F3, SUM({2}) As F4 FROM TonKho WHERE MaVattu = {3}{4}", _
                                                                st, _
                                                                (IIf(pGiaUSD > 0, String.Format("Sum(USDTien_{0})", st), "0")), _
                                                                sqll, _
                                                                ConvertToStrSafe(mvt), _
                                                                (IIf(mkho > 0, String.Format(" AND  MaSoKho = {0}", mkho), String.Empty))), dkt, dkt2, ps))
        If Not (dkl = 0 And dkt = 0 And dkt2 = 0 And ps = 0) Then
            If ps <> 0 Then
                sql = String.Format("SELECT DISTINCT ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{0} as DienGiai, ChungTu.MaLoai, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, HeThongTK.SoHieu as SohieuTK, HeThongTK_1.SoHieu as SohieuTK1, ChungTu.GhiChu, ChungTu.MaKho, ChungTu.MaNguon,{1} AS PSUSD1, DonVi, TyLeQD, ChungTu.NgayGS, ChungTu.MaCT FROM (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo) LEFT JOIN DVTVattu ON ChungTu.DVT=DVTVattu.MaSo  WHERE (SoPS2No<>0 OR SoPS2Co<>0 OR SoPS<>0) AND (HethongTK.TK_ID={2} OR HethongTK_1.TK_ID={3}) AND ((ChungTu.MaLoai =13 OR ChungTu.MaLoai =1 OR ChungTu.MaLoai =2 OR ChungTu.MaLoai =4) AND {4} And (chungtu.MaVattu = {5}){6}) {7} ORDER BY ChungTu.NgayGS, ChungTu.MaCT", _
                          (IIf(pnn > 0, "E", String.Empty)), _
                          (IIf(pGiaUSD > 0, "ChungTu.PSUSD", "0")), _
                          TKVT_ID, _
                          ConvertToStrSafe(TKVT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          ConvertToStrSafe(mvt), _
                          (IIf(mkho > 0, String.Format(" And (((chungtu.MaLoai=13 or chungtu.MaLoai<4) And chungtu.MaKho = {0}) OR (chungtu.MaLoai=4 And (chungtu.MaKho = {1} OR chungtu.MaNguon = {1})))", _
                                             mkho, _
                                             ConvertToStrSafe(mkho)), String.Empty)), _
                          (IIf(doiung.Length > 0, _
                               String.Format("AND (HethongTK.SoHieu LIKE '{0}%' OR HethongTK_1.SoHieu LIKE '{0}%')", doiung), _
                               String.Empty)))
                rs = ExecSQLReturnDT(sql)
                Dim luong As Integer
                Dim ss, sr As Double
                Dim shct As String = String.Empty
                Dim nnn As Integer
                If rs.Rows.Count > 0 Then
                    If Grd.Rows < rs.Rows.Count Then
                        Grd.Rows = rs.Rows.Count
                    End If
                    i = 1
                    ClearGrid(Grd, Grd.Rows)
                    Khoi_tao()
                    For ii = 0 To rs.Rows.Count - 1
                        Grd.AddItem(String.Format("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}", Chr(9), " "))
                    Next
                    For Each rsItem As DataRow In rs.Rows
                        With Grd
                            Me.Text = String.Format(Ngonngu("Các phiếu nhập, xuất trong kỳ", "The import and export bills in the period") + ": {0}/{1} - {2}/{1} " + Ngonngu("của vật tư có số hiệu", "of material code") + ": {3}", _
                                          tdau, _
                                          frmMain._LbCty_7.Text, _
                                          ConvertToStrSafe(tcuoi), _
                                          Timten("sohieu", ConvertToStrSafe(mvt), "maso", "vattu"))
                            Dim maLoai, maNguon, maKho As Integer
                            If rsItem("maloai") IsNot Nothing Then
                                maLoai = ConvertToDblSafe(rsItem("maloai"))
                            End If
                            If rsItem("MaKho") IsNot Nothing Then
                                maKho = ConvertToDblSafe(rsItem("MaKho"))
                            End If
                            If rsItem("MaNguon") IsNot Nothing Then
                                maNguon = ConvertToDblSafe(rsItem("MaNguon"))
                            End If

                            If maLoai = 1 Or maLoai = 13 Or (maLoai = 4 And (maKho < 0 Or (maNguon = mkho And maKho > 0))) Then
                                .Row = (i - 1)
                                .Col = 0 : .CtlText = i
                                .Col = 1 : .CtlText = ConvertToStrSafe(rsItem("SoHieu"))
                                .Col = 2 : .CtlText = Format(CDate(ConvertToStrSafe(rsItem("NgayCT"))), Mask_D)
                                .Col = 3 : .CtlText = ConvertToStrSafe(rsItem("DienGiai"))
                                .Col = 4
                                If ConvertToDblSafe(rsItem("MaTKTCCo")) <> 0 Then
                                    .CtlText = ConvertToStrSafe(rsItem("sohieutk1"))
                                Else
                                    .CtlText = ConvertToStrSafe(rsItem("GhiChu"))
                                End If
                                If rsItem("sops") IsNot Nothing Then
                                    sr = ConvertToDblSafe(rsItem("sops"))
                                End If
                                If rsItem("SoPS2No") IsNot Nothing Then
                                    ss = ConvertToDblSafe(rsItem("SoPS2No"))
                                End If


                                If ss <> 0 Then
                                    .Col = 5 : .CtlText = Format(sr / ss, Mask_0)
                                    .Col = 6 : .CtlText = Format(ss, Mask_0)
                                    .Col = 7 : .CtlText = Format(sr, Mask_0)
                                End If
                                .Col = 10 : .CtlText = Format(dkl + ss, Mask_0) : dkl += ss
                                .Col = 11 : .CtlText = Format(dkt + sr, Mask_0) : dkt += sr
                            Else
                                If maLoai = 2 Or (maLoai = 4 And (maKho < 0 Or (maNguon = mkho And maKho > 0))) Then
                                    .Row = (i - 1)
                                    .Col = 0 : .CtlText = ConvertToStrSafe(i)
                                    shct = ConvertToStrSafe(rsItem("SoHieu"))
                                    nnn = IIf(shct.ToUpper().EndsWith("XT") Or shct.ToUpper().EndsWith("GV"), shct.Length - 2, shct.Length)
                                    .Col = 1 : .CtlText = Strings.Left(shct, nnn)
                                    .Col = 2 : .CtlText = ConvertToDateSafe(rsItem("NgayCT"))
                                    .Col = 3 : .CtlText = ConvertToStrSafe(rsItem("DienGiai"))
                                    .Col = 4
                                    If ConvertToDblSafe(rsItem("MaTKTCNo")) <> 0 Then
                                        If ConvertToStrSafe(rsItem("sohieutk")) <> "" Then .CtlText = ConvertToStrSafe(rsItem("sohieutk"))
                                    End If
                                    If rsItem("sops") IsNot Nothing Then
                                        sr = ConvertToDblSafe(rsItem("sops"))
                                    End If
                                    If rsItem("SoPS2Co") IsNot Nothing Then
                                        ss = ConvertToDblSafe(rsItem("SoPS2Co"))
                                    End If
                                    If ss <> 0 Then
                                        .Col = 5 : .CtlText = Format(sr / ss, Mask_0)
                                        .Col = 8 : .CtlText = Format(ss, Mask_0)
                                        .Col = 9 : .CtlText = Format(sr, Mask_0)
                                    End If
                                    .Col = 10 : .CtlText = Format(dkl - ss, Mask_0) : dkl -= ss
                                    .Col = 11 : .CtlText = Format(dkt - sr, Mask_0) : dkt -= sr
                                End If
                            End If
                            i += 1
                        End With
                    Next
                End If
                If Grd.Rows < 34 Then Grd.Rows = 34
                On Error GoTo Loi
                co = 1
                Me.ShowDialog()
                Exit Sub
            End If
        End If
        If Lietke Then
            Lietke = False
            GoTo Loi
        Else
            Lietke = True
        End If
        MessageBox.Show(Ngonngu("Vật tư không có phát sinh !", "Material does not arise !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        If Grd.Rows < 34 Then Grd.Rows = 34
Loi:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.DoubleClick
        FrmOptSuaTonkho.ShowDialog()
    End Sub
    'Private Sub Grd_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs  As KeyEventArgs) Handles GrdNT.KeyUp 
    '    If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(Grd, Grd.Row)
    'End Sub

    Private Sub FrmChitietThekho_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
