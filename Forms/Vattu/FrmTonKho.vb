Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmTonkho

    Dim mkho As Integer
    Dim tdau, tcuoi As Integer
    'Private Sub CboThang_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboThang_1.Leave, _CboThang_0.Leave
    '    Command_ClickEvent(Command(0), New EventArgs())
    'End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim mloai As Integer
        Dim ten As String = String.Empty
        Select Case Index
            Case 0
                ClearGrid(Grd, Grd.Rows)
                If CboThang(0).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue
                mkho = CboKho.SelectedValue
                mloai = IIf(ChkDu.CheckState = CheckState.Checked, CboLoai.SelectedValue, 0)
                ten = IIf(ChkTen.CheckState = CheckState.Checked, TxtTen.Text, String.Empty)
                InLuyKe(mkho, mloai, tdau, tcuoi, ten)
            Case 1
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Command_ClickEvent(Command(0), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmTonkho_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(1).Focus()
                    '  Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.L
                    Command(0).Focus()
                    '  Command_ClickEvent(Command(0), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub

    Private Sub Khoi_tao()
        ColumnSetUp(Grd, 0, 350, 2)
        ColumnSetUp(Grd, 1, 950, 0)
        ColumnSetUp(Grd, 2, 3100, 0)
        ColumnSetUp(Grd, 3, 590, 2)
        ColumnSetUp(Grd, 4, 950, 4)
        ColumnSetUp(Grd, 5, 1190, 4)
        ColumnSetUp(Grd, 6, 950, 4)
        ColumnSetUp(Grd, 7, 1190, 4)
        ColumnSetUp(Grd, 8, 950, 4)
        ColumnSetUp(Grd, 9, 1190, 4)
        ColumnSetUp(Grd, 10, 950, 4)
        ColumnSetUp(Grd, 11, 950, 4)
        ColumnSetUp(Grd, 12, 1270, 4)
        'Grd.Rows = 25
        'Grd.Cols = 13
        Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho)
        If FLAG = 0 Then
            For chi_so As Integer = 0 To 1
                AddMonthToCbo(CboThang(chi_so))
            Next
        End If
        Int_RecsetToCbo("SELECT PhanLoaiVattu.MaSo As F2, (PhanLoaiVattu.SoHieu + ' - '+ PhanLoaiVattu.TenPhanLoai) As F1" & " FROM PhanLoaiVattu ORDER BY PhanLoaiVattu.SoHieu", CboLoai)
    End Sub
    Dim co As Integer = 0
    Dim FLAG As Integer = 0
    Private Sub FrmTonkho_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()
            If co = 0 Then Khoi_tao()
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
    ''' <param name="abc"></param>
    ''' <remarks></remarks>
    Public Sub Hienthiluoi(ByRef abc As FrmSovattuhanghoabh)
        Khoi_tao()
        With abc
            If .ChkDu(3).Checked Then
                ChkDu.CheckState = CheckState.Checked
                CboLoai.Text = .CboLoai(0).Text
            Else
                ChkDu.CheckState = CheckState.Unchecked
            End If
            CboThang(0).Text = .CboThang(0).Text
            CboThang(1).Text = .CboThang(1).Text
            CboKho.Text = .CboKho(0).Text
        End With
        co = 1
        Me.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="abc"></param>
    ''' <remarks></remarks>
    Public Sub Hienthiluoi(ByRef abc As FrmSovattuhanghoa)
        Khoi_tao()
        With abc
            If .ChkDu(3).Checked Then
                ChkDu.CheckState = CheckState.Checked
                CboLoai.Text = .CboLoai(0).Text
            Else
                ChkDu.CheckState = CheckState.Unchecked
            End If
            CboThang(0).Text = .CboThang(0).Text
            CboThang(1).Text = .CboThang(1).Text
            CboKho.Text = .CboKho(0).Text
        End With
        co = 1
        Me.ShowDialog()
    End Sub

    Private Sub InLuyKe(ByRef mkho As Integer, ByRef mloai As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef ten As String = "")

        Dim sql, st As String
        Dim sqltx2 As New StringBuilder
        Dim sqltn2 As New StringBuilder
        Dim sqltx As New StringBuilder
        Dim sqltn As New StringBuilder
        Dim sqllx As New StringBuilder
        Dim sqlln As New StringBuilder
        Dim i As Integer
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            st = ConvertToStrSafe(i)
            sqlln.Append(" + TonKho.Luong_Nhap_" & st)
            sqllx.Append(" + TonKho.Luong_Xuat_" & st)
            sqltn.Append(" + TonKho.Tien_Nhap_" & st)
            sqltx.Append(" + TonKho.Tien_Xuat_" & st)
            sqltn2.Append(" + TonKho.USDTien_Nhap_" & st)
            sqltx2.Append(" + TonKho.USDTien_Xuat_" & st)
        Next
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        XDTyLeQD(0)
        If mkho > 0 Then
            'sql = "SELECT DISTINCT (HeThongTK.SoHieu) AS SHTK, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(TonKho.Luong_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkLuong," & " Sum(TonKho.Tien_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkTien, Sum(" & sqlln.ToString() & ") AS LuongNhap, Sum(" & sqltn.ToString() & ") AS TienNhap," & " Sum(" & sqllx.ToString() & ") AS LuongXuat, Sum(" & sqltx.ToString() & ") AS TienXuat, Sum(TonKho.Luong_" & st & ") AS CkLuong, (HeThongTK.Ten)  AS TenTK, Sum(TonKho.Tien_" & st & ") AS CkTien" & (iif(pGiaUSD > 0, ", Sum(TonKho.USDTien_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkUSD, Sum(" & sqltn2.ToString() & ") AS TienNhapUSD, Sum(" & sqltx2.ToString() & ") AS TienXuatUSD, Sum(TonKho.USDTien_" & st & ") AS CkUSD", String.Empty)) & " FROM HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan" & " GROUP BY Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, HethongTK.SoHieu" & (iif(mkho > 0, ", TonKho.MaSoKho", String.Empty)) & (iif(mloai > 0, ", PhanLoaiVattu.SoHieu", String.Empty)) & " Having (Sum(TonKho.Luong_" & st & ")<>0 OR Sum(TonKho.Tien_" & st & ")<>0 OR SUM(" & sqlln.ToString() & ")<>0 OR SUM(" & sqltn.ToString() & ")<>0 OR SUM(" & sqllx.ToString() & ")<>0 OR SUM(" & sqltx.ToString() & ")<>0" & (iif(pGiaUSD > 0, " OR Sum(TonKho.USDTien_" & st & ")<>0 OR SUM(" & sqltn2.ToString() & ")<>0 OR SUM(" & sqltx2.ToString() & ")<>0)", ")")) & (iif(mkho <> 0, " AND TonKho.MaSoKho = " & mkho, String.Empty)) & (iif(mloai <> 0, " AND PhanLoaiVattu.SoHieu LIKE '" & MaSo2SoHieu(mloai, "PhanLoaiVattu") & "%'", String.Empty)) & (iif(ten <> "", " and vattu.tenvattu like'%" & ten.ToUpper() & "%'", String.Empty)) & " ORDER BY Vattu.SoHieu"
            sql = "SELECT DISTINCT  HeThongTK.SoHieu AS SHTK, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(TonKho.Luong_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkLuong," & " Sum(TonKho.Tien_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkTien, Sum(" & sqlln.ToString() & ") AS LuongNhap, Sum(" & sqltn.ToString() & ") AS TienNhap," & " Sum(" & sqllx.ToString() & ") AS LuongXuat, Sum(" & sqltx.ToString() & ") AS TienXuat, Sum(TonKho.Luong_" & st & ") AS CkLuong, HeThongTK.Ten  AS TenTK, Sum(TonKho.Tien_" & st & ") AS CkTien" & (IIf(pGiaUSD > 0, ", Sum(TonKho.USDTien_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkUSD, Sum(" & sqltn2.ToString() & ") AS TienNhapUSD, Sum(" & sqltx2.ToString() & ") AS TienXuatUSD, Sum(TonKho.USDTien_" & st & ") AS CkUSD", String.Empty)) & " FROM HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan" & " GROUP BY Vattu.SoHieu,HeThongTK.Ten, Vattu.TenVattu, Vattu.DonVi, HethongTK.SoHieu" & (IIf(mkho > 0, ", TonKho.MaSoKho", String.Empty)) & (IIf(mloai > 0, ", PhanLoaiVattu.SoHieu", String.Empty)) & " Having (Sum(TonKho.Luong_" & st & ")<>0 OR Sum(TonKho.Tien_" & st & ")<>0 OR SUM(" & sqlln.ToString() & ")<>0 OR SUM(" & sqltn.ToString() & ")<>0 OR SUM(" & sqllx.ToString() & ")<>0 OR SUM(" & sqltx.ToString() & ")<>0" & (IIf(pGiaUSD > 0, " OR Sum(TonKho.USDTien_" & st & ")<>0 OR SUM(" & sqltn2.ToString() & ")<>0 OR SUM(" & sqltx2.ToString() & ")<>0)", ")")) & (IIf(mkho <> 0, " AND TonKho.MaSoKho = " & mkho, String.Empty)) & (IIf(mloai <> 0, " AND PhanLoaiVattu.SoHieu LIKE '" & MaSo2SoHieu(mloai, "PhanLoaiVattu") & "%'", String.Empty)) & (IIf(ten <> "", " and vattu.tenvattu like'" & ten.ToUpper() & "%'", String.Empty)) & " ORDER BY Vattu.SoHieu"
        Else
            MessageBox.Show(Ngonngu("Công ty này không có kho hàng", "Missing storage"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Grd.Rows < 31 Then Grd.Rows = 31
            Exit Sub
        End If
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        ClearGrid(Grd, Grd.Rows)
        If rs.Rows.Count > 0 Then
            GauGe.Maximum = rs.Rows.Count
            'Grd.Rows = rs.Rows.Count
            i = 1
            GauGe.Value = 1
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                sql = String.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}{0}{13}", _
                                          Chr(9), _
                                          ConvertToStrSafe(i), _
                                          rsItem(1), _
                                          rsItem(2), _
                                          rsItem(3), _
                                          IIf(ConvertToDblSafe(rsItem(4)) = 0, 0, Format(rsItem(4), Mask_0)), _
                                          IIf(ConvertToDblSafe(rsItem(5)) = 0, 0, Format(rsItem(5), Mask_0)), _
                                          IIf(ConvertToDblSafe(rsItem(6)) = 0, 0, Format(rsItem(6), Mask_0)), _
                                          IIf(ConvertToDblSafe(rsItem(7)) = 0, 0, Format(rsItem(7), Mask_0)), _
                                          IIf(ConvertToDblSafe(rsItem(8)) = 0, 0, Format(rsItem(8), Mask_0)), _
                                          IIf(ConvertToDblSafe(rsItem(9)) = 0, 0, Format(rsItem(9), Mask_0)), _
                                          IIf(ConvertToDblSafe(rsItem(10)) = 0, 0, Format(rsItem(10), Mask_0)), _
                                          IIf(ConvertToDblSafe(rsItem(10)) = 0, 0, Format(ConvertToDblSafe(rsItem(12)) / CDbl(rsItem(10)), Mask_0)), _
                                          IIf(CDbl(rsItem(12)) = 0, 0, Format(rsItem(12), Mask_0)))
                Grd.AddItem(sql)
                GauGe.Value = i
                i += 1
            End While
        End If
        Text = "Bảng kê tồn kho trong kỳ " & CboThang(0).Text & " - " & CboThang(1).Text
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.DoubleClick
        FrmOptTonkho.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grd.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(Grd, Grd.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Dim Index As Integer = Array.IndexOf(mnct, eventSender)
        Grd.Col = 1
        Dim dong As Integer = Grd.Row
        Dim soluong, sotien As Double
        Dim SoHieu, sql As String
        Dim co1, co2 As Boolean
        If Grd.CtlText <> "" Then
            Select Case Index
                Case 0, 1
                    FrmChitietTonkho.LietKeTonKho(mkho, ConvertToDblSafe(Timten("maso", Grd.CtlText, "sohieu", "vattu")), tdau, tcuoi, True, Index)
                Case 2
                    FrmChitietThekho.LietKethekho(mkho, ConvertToDblSafe(Timten("maso", Grd.CtlText, "sohieu", "vattu")), tdau, tcuoi, True)
                Case 3
                    If tdau <> 1 Then
                        MessageBox.Show(Ngonngu("Chỉ được sửa đầu kỳ khi tháng đầu = 1 ", "Expenditures are beginning the first = 1"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                    End If
                    SoHieu = Grd.CtlText
                    Grd.Col = 4
                    sql = FrmGetStr.GetString(Ngonngu("Số lượng : ", "Quantity"), Ngonngu("Tồn đầu kỳ của vật tư có số hiệu: ", "Left amount of material are numbered: ") & SoHieu & Ngonngu(" ( Nếu để trống thì không sửa )", " (if left blank will not fix)"), Grd.CtlText)
                    If sql.Length = 0 Then co1 = True Else soluong = ConvertToDblSafe(sql) : co1 = False
                    Grd.Col = 5
                    Grd.Row = dong
                    sql = FrmGetStr.GetString(Ngonngu("Số Tiền : ", "Amount"), Ngonngu("Tồn đầu kỳ của vật tư có số hiệu: ", "Left amount of material are numbered: ") & SoHieu & Ngonngu(" ( Nếu để trống thì không sửa )", " (if left blank will not fix)"), Grd.CtlText)
                    If sql.Length = 0 Then co2 = True Else sotien = ConvertToDblSafe(sql) : co2 = False
                    sql = "UPDATE tonkho set "
                    If Not co1 Then sql = sql & "luong_0=" & ConvertToStrSafe(soluong) & ","
                    If Not co2 Then sql = sql & "tien_0=" & ConvertToStrSafe(sotien) & ","
                    sql = Strings.Left(sql, sql.Length - 1) & " WHERE mavattu=" & Timten("maso", SoHieu, "sohieu", "vattu")
                    If Not co1 Or Not co2 Then
                        ExecSQLNonQuery(sql) : KiemTraVatTu() : Command_ClickEvent(Command(0), New EventArgs())
                    End If
            End Select
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtTen_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles TxtTen.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then Command_ClickEvent(Command(0), New EventArgs())
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
    Private Sub FrmTonkho_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
