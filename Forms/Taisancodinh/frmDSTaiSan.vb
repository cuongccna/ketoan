Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class frmDSTaiSan

    Private Const GRID_ROWS As Integer = 25
    Private Const GRID_COLS As Integer = 8
    Dim KhoiTao As Boolean
    Dim TSChon As String = String.Empty
    Dim SoLieu(11) As Boolean
    Dim formInitDone As Boolean = False
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    ' KEYDOWN
    Private Sub frmDSTaiSan_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.C And pNghiepVu = NV_KHONG, Keys.C And Not (pNghiepVu = NV_KHONG) : Command(0).Focus() : Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V : Command(1).Focus() : Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X : Command(2).Focus() : Command_ClickEvent(Command(2), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then
            Me.Close()
            Me.Finalize()
        End If
    End Sub
    ' LOAD
    Private Sub frmDSTaiSan_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ' Nếu nhập đầu kỳ thì cho phép xoá tài sản
            InitGrid(Grid, GRID_ROWS, GRID_COLS)
            ColumnSetUp(Grid, 0, 1, 0)
            ColumnSetUp(Grid, 1, 1310, 2)
            ColumnSetUp(Grid, 2, 2405, 0)
            ColumnSetUp(Grid, 3, 1055, 2)
            ColumnSetUp(Grid, 4, 1310, 4)
            ColumnSetUp(Grid, 5, 1310, 4)
            ColumnSetUp(Grid, 6, 590, 2)
            ColumnSetUp(Grid, 7, 1280, 4)
            ' Lấy danh sách phân loại
            KhoiTao = True
            Int_RecsetToCbo(String.Format("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiTaiSan WHERE CapTren = 0"), Combo(0))
            If _Combo_0.Items.Count Or _Combo_0.Items.ItemsBase.Count > 0 Then
                formInitDone = True
                Combo_SelectedIndexChanged(_Combo_0, New EventArgs())
            End If
            KhoiTao = False
            ' Đặt tháng ngầm định (dẫn đến Events_Click tương ứng - Lấy danh sách tài sản)
            AddMonthToCbo(Combo(3))
            Select Case pNghiepVu
                Case NV_KHONG : Me.Text = Ngonngu(" Danh sách tài sản theo phân loại và thời gian", "PropertyAttributes listing by category and time")
                Case NV_GIAM, NV_DGLAI : Me.Text = Ngonngu(" Chỉ định tài sản bị tác động", " Specified assets are affected")
            End Select
            pGhichungtu = 0
            Text = String.Format("{0} - {1}", Text, ConvertToStrSafe(pNamTC))
            For chi_so As Integer = 1 To 12
                SoLieu(chi_so - 1) = False
            Next
            formInitDone = True
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub
    '======================================================================================
    ' COMBO
    '======================================================================================
    Private Sub Combo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Combo_2.SelectedIndexChanged, _Combo_1.SelectedIndexChanged, _Combo_0.SelectedIndexChanged, _Combo_3.SelectedIndexChanged
        If formInitDone Then
            Dim Index As Integer = Array.IndexOf(Combo, eventSender)
            Select Case Index
                Case 0 ' Tài khoản
                    If Combo(1).Items.Count = 0 Then
                        Combo(2).Items.Clear()
                        Combo(2).Items.ItemsBase.Clear()
                        ClearGrid(Grid, GRID_ROWS)
                    End If

                    Int_RecsetToCbo("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiTaiSan " & "WHERE CapTren = " & Combo(0).SelectedValue & " ORDER BY SoHieu", Combo(1))
                    If Combo(1).Items.Count > 0 Then
                        Combo(1).SelectedIndex = 0
                        Int_RecsetToCbo(String.Format("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiTaiSan WHERE CapTren = {0} ORDER BY sohieu", Combo(1).SelectedValue), Combo(2))
                    Else
                        Combo(2).Items.Clear()
                        Combo(2).Items.ItemsBase.Clear()
                        ClearGrid(Grid, GRID_ROWS)
                    End If
                Case 1 ' Phân loại
                    If KhoiTao Or Combo(0).Items.Count = 0 Then
                        Exit Sub
                    Else
                        Int_RecsetToCbo(String.Format("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiTaiSan WHERE CapTren = {0} ORDER BY sohieu", Combo(1).SelectedValue), Combo(2))
                        If (Combo(2).Items.Count > 0) Then
                            LayDanhSachTaiSan()
                        Else
                            Combo(2).Items.Clear()
                            Combo(2).Items.ItemsBase.Clear()
                            ClearGrid(Grid, GRID_ROWS)
                        End If
                    End If
                    Command(2).Visible = (Combo(3).SelectedValue = pThangDauKy)
                Case 2, 3 ' Phân nhóm / Tháng
                    If KhoiTao Or Combo(1).Items.Count = 0 Then
                        Exit Sub
                    Else
                        LayDanhSachTaiSan()
                    End If
                    Command(2).Visible = (Combo(3).SelectedValue = pThangDauKy)
            End Select
        End If
    End Sub
    '======================================================================================
    ' GRID
    '======================================================================================
    ' CLICK
    Private Sub Grid_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grid.Click
        ' SendKeys.SendWait("{Home}")
        SetGridIndex(Grid, Grid.Row)
        If pNghiepVu = NV_KHONG And ConvertToDblSafe(Me.Tag) = 1 Then
            Grid.Col = 1
            TSChon = Grid.CtlText
        End If
    End Sub
    ' DOUBLECLICK
    Private Sub Grid_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grid.DoubleClick
        Command_ClickEvent(Command(0), New EventArgs())
    End Sub
    ' KEYDOWN
    Private Sub Grid_KeyDownEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grid.KeyDown
        Select Case eventArgs.KeyCode
            Case ConvertToDblSafe(Keys.Home), ConvertToDblSafe(Keys.End), ConvertToDblSafe(Keys.Right), ConvertToDblSafe(Keys.Left)
            Case ConvertToDblSafe(Keys.Up) : SetGridIndex(Grid, Grid.Row - 1)
            Case ConvertToDblSafe(Keys.Down) : SetGridIndex(Grid, Grid.Row + 1)
            Case ConvertToDblSafe(Keys.PageUp) : SetGridIndex(Grid, Grid.Row - GRID_ROWS)
            Case ConvertToDblSafe(Keys.PageDown) : SetGridIndex(Grid, Grid.Row + GRID_ROWS)
            Case ConvertToDblSafe(Keys.Return) : Command_ClickEvent(Command(0), New EventArgs())
            Case Else : Exit Sub
        End Select
        'eventArgs.KeyCode = 0
    End Sub
    '======================================================================================
    ' command
    '     1. Sửa đổi nội dung tài sản
    '     2. Giảm tài sản
    '     3. Đánh giá lại
    '======================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click, _Command_2.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0 ' Sửa đổi ........................................................................................................................................................
                If pNghiepVu = NV_KHONG And ConvertToDblSafe(Me.Tag) = 1 Then
                    Grid.Col = 1
                    TSChon = Grid.CtlText
                    Me.Close()
                    Exit Sub
                End If
                Grid.Col = 0
                If Strings.Len(Grid.CtlText) > 0 Then
                    ' Tài sản đã giảm trong năm sẽ không thể được đánh giá lại hay giảm lần thứ 2
                    If Not (pNghiepVu = NV_KHONG) And TaiSanGiamTrongNam(ConvertToDblSafe(Grid.CtlText)) Then
                        SystemSounds.Beep.Play()
                        myUMessager.mError("Tài sản đã bị giảm trong năm. Phải xoá chứng từ giảm đi nếu muốn tiếp tục", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo XongDSTS
                    End If
                    ' Chuẩn bị các biến trao đổi dữ liệu với frmChungTu
                    pThangTacDong = Combo(3).SelectedValue
                    pMaTaiSan = ConvertToDblSafe(Grid.CtlText) ' Mã số tài sản hiện thời
                    pMaChungTu = 0 ' Cho phép ghi chứng từ mới
                    Select Case pNghiepVu ' Loại nghiệp vụ được xác định theo chức
                        Case NV_KHONG ' năng trên menu đã gọi ra frmDSTaiSan
                            frmTaiSan.ShowDialog()
                        Case NV_DGLAI
                            frmTangGiam.ShowDialog()
                            If pGhichungtu = 1 Then
                                SetListIndex(FrmChungtu.CboThang, pThangTacDong)
                                Me.Close()
                                Exit Sub
                            End If
                        Case NV_GIAM
                            GiamTaiSan(pMaTaiSan, pThangTacDong)
                            ' Ghi chứng từ
                            pGhichungtu = 1
                            SetListIndex(FrmChungtu.CboThang, pThangTacDong)
                            Me.Close()
                            Exit Sub
                    End Select
                    pMaTaiSan = 0
                    pMaChungTu = 0
                Else
                    SystemSounds.Beep.Play()
                End If
                Command_ClickEvent(Combo(3), New EventArgs())
                Application.DoEvents()
            Case 1 ' Trở về ...........................................................................................................................................................
                TSChon = ""
                Me.Close()
                Me.Finalize()
            Case 2 ' Xoá ................................................................................................................................................................
                Grid.Col = 0
                If Strings.Len(Grid.CtlText) > 0 Then
                    If System.Windows.Forms.DialogResult.Yes = myUMessager.mQuestion("Xoá tài sản hiện tại ?", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                        XoaTaiSan(ConvertToDblSafe(Grid.CtlText))
                        Grid.RemoveItem(Grid.Row)
                        SetGridIndex(Grid, 0)
                        SoDuTKTS()
                    End If
                End If
        End Select
XongDSTS:
        Me.Cursor = Cursors.Default
    End Sub
    '======================================================================================
    ' SUB LayDanhSachTaiSan
    '======================================================================================
    Private Sub LayDanhSachTaiSan()

        Dim mnhom As Integer
        If Combo(2).Items.Count > 0 Then
            mnhom = Combo(2).SelectedValue
        Else
            mnhom = 0
        End If
        Me.Cursor = Cursors.WaitCursor
        ClearGrid(Grid, GRID_ROWS)
        Dim i As Integer = Combo(3).SelectedValue
        For chi_so As Integer = 1 To CThangDB2(i)
            If Not SoLieu(chi_so - 1) Then
                CapNhatGiaTriTaiSan(chi_so, FrmSotaisan.GauGe)
                SoLieu(chi_so - 1) = True
            End If
        Next
        Dim sql As String = "SELECT TaiSan.MaSo, TaiSan.SoHieu, TaiSan.Ten, NCT, (ThongSo.NG_NS + ThongSo.NG_TBS + ThongSo.NG_CNK + ThongSo.NG_TD) AS NguyenGia, (ThongSo.CL_NS + ThongSo.CL_TBS + ThongSo.CL_CNK + ThongSo.CL_TD) AS ConLai, (ThongSo.KH_NS + ThongSo.KH_TBS + ThongSo.KH_CNK + ThongSo.KH_TD) AS KhauHao, NamKH" & " FROM TaiSan LEFT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS" & " WHERE (TaiSan.MaLoai = " & Combo(1).SelectedValue & ") AND ((TaiSan.MaNhom = " & ConvertToStrSafe(mnhom) & ") OR (TaiSan.MaNhom=0)) " & " AND " & WThang("ThangTang", 0, i) & " AND " & WThang("ThangGiam", i, 0) & " AND ThongSo.Thang= " & ConvertToStrSafe(CThangDB2(i)) & " ORDER BY TaiSan.SoHieu DESC"
        Dim rs_danhsach As DataTable = ExecSQLReturnDT(sql)
        On Error GoTo Err_NoCurrentRecord
        'rs_danhsach.MoveFirst()
        On Error GoTo 0
        Dim strTemp As String
        For Each rs_danhsachItem As DataRow In rs_danhsach.Rows
            Grid.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                             ConvertToStrSafe(rs_danhsachItem("MaSo")), _
                             Strings.Chr(9), _
                             rs_danhsachItem("SoHieu"), _
                             rs_danhsachItem("ten"), _
                             Format(CDate(rs_danhsachItem("NCT")), "dd/MM/yyyy"), _
                             Format(rs_danhsachItem("NguyenGia"), Mask_0), _
                             Format(rs_danhsachItem("Conlai"), Mask_0), _
                             rs_danhsachItem("NamKH"), _
                             0, Format(rs_danhsachItem("KhauHao"), Mask_0)), 0)
        Next
Err_NoCurrentRecord:
        SetGridIndex(Grid, 0)
        ''rs_danhsach.Close()
        rs_danhsach = Nothing
        Me.Cursor = Cursors.Arrow
    End Sub
    '======================================================================================
    ' FUNCTION TaiSanGiamTrongNam
    '======================================================================================
    Private Function TaiSanGiamTrongNam(ByRef ma_ts As Integer) As Boolean
        Dim sql As String = "SELECT ThangGiam AS F1 FROM TaiSan WHERE MaSo = " & ma_ts
        If ConvertToDblSafe(GetSelectValue(sql)) = 13 Then Return False Else Return True
    End Function
    Public Function ChonTaiSan(ByRef sh As String, ByRef tdau As Integer, ByRef tcuoi As Integer) As String
        Dim rs As DataTable = ExecSQLReturnDT("SELECT LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan_1.MaSo AS MaLoai, LoaiTaiSan_2.MaSo AS MaNhom, TaiSan.SoHieu, TaiSan.ThangTang, TaiSan.ThangGiam" & " FROM ((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.MaTaiKhoan) LEFT JOIN LoaiTaiSan AS LoaiTaiSan_1 ON TaiSan.MaLoai = LoaiTaiSan_1.MaSo) LEFT JOIN LoaiTaiSan AS LoaiTaiSan_2 ON TaiSan.MaNhom = LoaiTaiSan_2.MaSo" & " WHERE TaiSan.SoHieu LIKE '" & sh & "%' AND " & WThang("ThangTang", 0, tcuoi) & " AND " & WThang("ThangGiam", tdau, 0) & " ORDER BY TaiSan.SoHieu")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            SetListIndex(Combo(3), IIf(rsItem("ThangGiam") < tcuoi, rsItem("ThangGiam"), tcuoi))
            SetListIndex(Combo(0), rsItem("MaTK"))
            SetListIndex(Combo(1), rsItem("maloai"))
            If Not IsDBNull(rsItem("MaNhom")) Then SetListIndex(Combo(2), rsItem("MaNhom"))
            With Grid
                .Col = 1
                .Row = 0
                Do While (.CtlText.IndexOf(sh, StringComparison.CurrentCultureIgnoreCase) + 1) = 0
                    .Row = ConvertToDblSafe(.Row + 1)
                Loop
            End With
        End If
        ''rs.Close()
        rs = Nothing
        pNghiepVu = NV_KHONG
        Me.Tag = "1"
        Grid_ClickEvent(Grid, New EventArgs())
        Me.ShowDialog()
        Return TSChon
    End Function
    Private Sub Grid_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grid.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(Grid, Grid.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grid_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles Grid.MouseDown
        If eventArgs.Button = MouseButtons.Right Then 'eventArgs.Button = 2
            SearchObj(1, , Grid, Grid.Col)
        End If
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue("SELECT Lock" & Combo(3).SelectedValue & " % 10 AS F1 FROM License")) > 0 Then
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
    Private Sub frmDSTaiSan_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

End Class
