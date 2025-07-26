Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class FDsNhap

    Dim MaSo As Integer
    Dim soluong As Double
    Dim ThanhTien As Double
    Dim ThanhTien2 As Double
    Dim ThangVT As Integer
    Dim KhoVT As Integer
    '====================================================================================================
    ' Chọn phiếu nhập
    '====================================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                With GrdCT
                    .Col = 6
                    If .CtlText.length = 0 Then Exit Sub
                    MaSo = ConvertToDblSafe(.CtlText)
                    .Col = 5
                    ThanhTien = ConvertToDblSafe(.CtlText)
                    .Col = 6
                    ThanhTien2 = ConvertToDblSafe(.CtlText)
                    .Col = 3
                    soluong = ConvertToDblSafe(.CtlText)
                    Me.Close()
                End With
            Case 1
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If ConvertToDblSafe(Me.Tag) > 0 Then
            Me.Cursor = Cursors.WaitCursor
            LietKePhieuNhap(ConvertToDblSafe(Me.Tag))
            Me.Tag = -ConvertToDblSafe((Me.Tag))
            Me.Cursor = Cursors.Default
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FDsNhap_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.C
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V
                    Command(1).Focus()
                    '  Command_ClickEvent(Command(1), New EventArgs())
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
    Private Sub FDsNhap_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdCT, 0, 1300, 2)
            ColumnSetUp(GrdCT, 1, 820, 2)
            ColumnSetUp(GrdCT, 2, 3220, 0)
            ColumnSetUp(GrdCT, 3, 1300, 1)
            ColumnSetUp(GrdCT, 4, 1300, 1)
            ColumnSetUp(GrdCT, 5, 1300, 1)
            ColumnSetUp(GrdCT, 6, 1, 0)
            ColumnSetUp(GrdCT, 7, 1, 1)
            MaSo = 0
            soluong = 0
            ThanhTien = 0
            Text = SetFormTitle(Text)
            If pGiaUSD > 0 Then
                Label(7).Visible = True
                Me.Width += 1300
                Me.StartPosition = FormStartPosition.CenterScreen
            End If
            Me.Text = Ngonngu("Danh sách phiếu nhập vật tư chưa tính giá xuất", "List of material import Vouchers does not include price of export")
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
        'SendKeys.SendWait("{Home}")
        SetGridIndex(GrdCT, GrdCT.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdCT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdCT.DoubleClick
        Command_ClickEvent(Command(0), New EventArgs())
    End Sub
    '======================================================================================
    ' Liệt kê phiếu nhập
    '======================================================================================
    Private Sub LietKePhieuNhap(ByRef mvt As Integer)
        Dim dgia As Double
        Dim QNhatKy As String = String.Format("SELECT MaCT,Sum(SoPS) AS SPS,MaVattu{0} FROM {1} WHERE MaLoai = 1 AND MaKho ={2} AND (ThangCT <= {3}) AND (MaVattu = {4}) AND SoPS2No=0 AND TK_ID={5} GROUP BY MaCT,MaVattu", _
                                  (IIf(pGiaUSD > 0, ",Sum(PSUSD) AS SPS2", String.Empty)), _
                                  ChungTu2TKNC(-1), _
                                  ConvertToStrSafe(KhoVT), _
                                  ConvertToStrSafe(ThangVT), _
                                  ConvertToStrSafe(mvt), _
                                  ConvertToStrSafe(TKVT_ID))
        Dim sql As String = String.Format("SELECT 2000000000+MaSo AS MS,'DK' AS SoHieu,'01/01/1990' AS NgayCT,'Số tồn kho đầu kỳ' AS DienGiai,Luong_0 AS SoPS2No,SoXuat,Tien_0 AS SoPS{0} FROM VTDauNam WHERE (MaSoKho ={1}) AND (MaVattu = {2}) AND (Luong_0>SoXuat) UNION SELECT MaSo, SoHieu, NgayCT, DienGiai, CASE WHEN (MaTKNo>0) THEN SoPS2No ELSE SoPS2Co END, SoXuat, SoPS+ IsNull(SPS,0){3} FROM Chungtu LEFT JOIN ({4}) AS QNhatKy ON ChungTu.MaCT=QNhatKy.MaCT AND ChungTu.MaVattu=QNhatKy.MaVattu WHERE ((MaLoai = 1 AND MaKho ={1}) OR (MaLoai = 4 AND MaNguon = {5})) AND (ThangCT <= {6}) AND (ChungTu.MaVattu = {2}) AND (CASE WHEN(MaTKNo>0) THEN SoPS2No ELSE SoPS2Co END)>SoXuat {7}", _
                                IIf(pGiaUSD > 0, ",USDTien_0 AS SoPS2", String.Empty), _
                                KhoVT, _
                                ConvertToStrSafe(mvt), _
                                (IIf(pGiaUSD > 0, ",PSUSD+ IsNull(SPS2, 0)", String.Empty)), _
                                QNhatKy, _
                                ConvertToStrSafe(KhoVT), _
                                ConvertToStrSafe(ThangVT), _
                                IIf(OutCost < 3, " ORDER BY NgayCT DESC, SoHieu DESC", " ORDER BY NgayCT, SoHieu"))
        Dim rs_phieu As DataTable = ExecSQLReturnDT(sql)
        Dim rs_phieuIndex As Integer = 0
        Do While rs_phieuIndex < rs_phieu.Rows.Count
            Dim rs_phieuItem As DataRow = rs_phieu.Rows(rs_phieuIndex)
            rs_phieuIndex += 1 ' C15 Rs LOOP CONTROL
            dgia = IIf(ConvertToStrSafe(rs_phieuItem("SoPS2No")) <> 0, (IIf(0.5 + Mask_N * ConvertToStrSafe(rs_phieuItem("sops")) / ConvertToDblSafe(rs_phieuItem("SoPS2No")) > 0, Math.Floor(0.5 + Mask_N * ConvertToDblSafe(rs_phieuItem("sops")) / rs_phieuItem("SoPS2No")), Math.Ceiling(0.5 + Mask_N * ConvertToStrSafe(rs_phieuItem("sops")) / rs_phieuItem("SoPS2No")))) / Mask_N, 0)
            If pGiaUSD > 0 Then
                sql = String.Format("{0}{1}", Chr(9), Format(rs_phieuItem("SPS2"), Mask_2))
            Else
                sql = String.Empty
            End If

            GrdCT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{8}", _
                              ConvertToStrSafe(rs_phieuItem("SoHieu")), _
                              Chr(9), _
                              (IIf(ConvertToStrSafe(rs_phieuItem("ms")) < 2000000000, Format(CDate(rs_phieuItem("NgayCT")), Mask_D), String.Empty)), _
                              ConvertToStrSafe(rs_phieuItem("DienGiai")), _
                              Format(ConvertToStrSafe(rs_phieuItem("SoPS2No")) - rs_phieuItem("SoXuat"), Mask_2), _
                              Format(dgia, Mask_2), _
                              Format((ConvertToDblSafe(rs_phieuItem("SoPS2No")) - ConvertToDblSafe(rs_phieuItem("SoXuat"))) * ConvertToStrSafe(rs_phieuItem("sops")) / rs_phieuItem("SoPS2No"), Mask_0), _
                              ConvertToStrSafe(rs_phieuItem("ms")), _
                              sql), 0)
            'rs_phieu.MoveNext()
        Loop
        GrdCT.Rows = IIf(rs_phieu.Rows.Count > ConvertToDblSafe(GrdCT.Tag), rs_phieu.Rows.Count, ConvertToDblSafe(GrdCT.Tag))
        GrdCT.Row = 0
        GrdCT.Col = 0
        ''rs_phieu.Close()
        rs_phieu = Nothing
        GrdCT_ClickEvent(GrdCT, New EventArgs())
    End Sub
    '======================================================================================
    ' Hàm trả về phiếu nhập được chọn
    '======================================================================================
    Public Function XuatDichDanh(ByRef thang As Integer, ByRef DienGiai As String, ByRef mkho As Integer, ByRef luong As Double, ByRef tien As Double, Optional ByRef tien2 As Double = 0) As Integer
        ThangVT = thang
        KhoVT = mkho
        luong = 0
        tien = 0
        LbVattu.Text = DienGiai
        ShowDialog()
        luong = soluong
        tien = ThanhTien
        tien2 = ThanhTien2
        Return MaSo
    End Function
    Private Sub GrdCT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdCT.KeyPress
        SendKeys.SendWait("{Home}")
        SetGridIndex(GrdCT, GrdCT.Row)
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdCT_DblClick(GrdCT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdCT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdCT.MouseDown
        ' If eventArgs.Button = 2097152 Then 
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdCT, GrdCT.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FDsNhap_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
