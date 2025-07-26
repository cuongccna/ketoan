Imports System
Imports System.Data
Imports System.Media
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class frmDSCCDC

    Private Const GRID_ROWS As Integer = 25
    Private Const GRID_COLS As Integer = 8
    Dim KhoiTao As Boolean
    Dim TSChon As String = String.Empty
    Dim SoLieu(11) As Boolean
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Combo_SelectedIndexChanged(Combo(3), New EventArgs())
        Khoaquyen()
    End Sub

    ' KEYDOWN
    Private Sub frmDSCCDC_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.C And pNghiepVu = NV_KHONG, Keys.C And Not (pNghiepVu = NV_KHONG)
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    'Command_ClickEvent(Command(2), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then
            Me.Close()
            Me.Finalize()
        End If
    End Sub
    ' LOAD
    Private Sub frmDSCCDC_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ' Nếu nhập đầu kỳ thì cho phép xoá tài sản
            ' Khởi tạo lưới Grid
            InitGrid(Grid, GRID_ROWS, GRID_COLS)
            ColumnSetUp(Grid, 0, 1, 0)
            ColumnSetUp(Grid, 1, 1310, 2)
            ColumnSetUp(Grid, 2, 2405, 2)
            ColumnSetUp(Grid, 3, 1055, 2)
            ColumnSetUp(Grid, 4, 1310, 4)
            ColumnSetUp(Grid, 5, 1310, 4)
            ColumnSetUp(Grid, 6, 590, 2)
            ColumnSetUp(Grid, 7, 1280, 4)

            ' Lấy danh sách phân loại
            KhoiTao = True
            Int_RecsetToCbo(String.Format("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiCongcudungcu WHERE CapTren = 0"), Combo(0))
            KhoiTao = False
            ' Đặt tháng ngầm định (dẫn đến Events_Click tương ứng - Lấy danh sách tài sản)
            AddMonthToCbo(Combo(3))
            Select Case pNghiepVu
                Case NV_KHONG
                Case NV_GIAM, NV_DGLAI
                    Me.Text = Ngonngu(" Chỉ định Công cụ dụng cụ bị tác động", " Choose Tool affected")
            End Select
            pGhichungtu = 0
            For chi_so As Integer = 1 To 12
                SoLieu(chi_so - 1) = False
            Next
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
    Private Sub Combo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Combo_1.SelectedIndexChanged, _Combo_0.SelectedIndexChanged, _Combo_3.SelectedIndexChanged
        Dim Index As Integer = Array.IndexOf(Combo, eventSender)
        Select Case Index
            Case 0 ' Tài khoản
                Int_RecsetToCbo(String.Format("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiCongcudungcu WHERE CapTren = {0} ORDER BY SoHieu", Combo(0).SelectedValue), Combo(1))
                If Combo(1).Items.Count > 0 Then
                    _Combo_1.SelectedIndex = 0
                End If
                If Combo(1).Items.Count = 0 Then
                    ClearGrid(Grid, GRID_ROWS)
                End If
            Case 1 ' Phân loại
                If Not KhoiTao Then LayDanhSachCongcudungcu()
            Case 2, 3 ' Phân nhóm / Tháng
                If KhoiTao Or Combo(1).Items.Count = 0 Then
                    Exit Sub
                Else
                    LayDanhSachCongcudungcu()
                End If
        End Select
        If Strings.Right(Text, ConvertToStrSafe(pNamTC).Length) <> ConvertToStrSafe(pNamTC) Then
            Text = SetFormTitle(Text)
        End If
    End Sub
    '======================================================================================
    ' GRID
    '======================================================================================
    ' CLICK
    Private Sub Grid_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grid.Click
        'SendKeys.SendWait("{Home}")
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
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Me.Cursor = Cursors.WaitCursor
        Dim cot As Integer
        Dim rs, rs1 As DataTable
        Dim tkps As New ClsTaikhoan
        Select Case Index
            Case 0 ' Sửa đổi ........................................................................................................................................................
                cot = Grid.Col
                Grid.Col = 1
                If pNghiepVu = 0 And (Grid.CtlText = "" Or Grid.CtlText = "..." Or Grid.CtlText = "(...)") Then
                    MessageBox.Show(String.Format("Chi phí phát sinh trong năm.{0}Không được sửa ở đây!", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning) : GoTo XongDSTS
                End If
                Grid.Col = cot
                If pNghiepVu = NV_KHONG And ConvertToDblSafe(Me.Tag) = 1 Then
                    Grid.Col = 1
                    TSChon = Grid.CtlText
                    Me.Close()
                    Exit Sub
                End If
                Grid.Col = 0
                If Strings.Len(Grid.CtlText) > 0 Then
                    ' Tài sản đã giảm trong năm sẽ không thể được đánh giá lại hay giảm lần thứ 2
                    If Not (pNghiepVu = NV_KHONG) And CongcudungcuGiamTrongNam(ConvertToDblSafe(Grid.CtlText)) Then
                        SystemSounds.Beep.Play()
                        MessageBox.Show(Ngonngu("Công cụ dụng cụ đã bị giảm trong năm. Phải xoá chứng từ giảm đi nếu muốn tiếp tục", "Tool has been reduced in year. Delete reduce voucher if you want to continue"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo XongDSTS
                    End If
                    ' Chuẩn bị các biến trao đổi dữ liệu với frmChungTu
                    pThangTacDong = Combo(3).SelectedValue
                    pMaCongcudungcu = ConvertToDblSafe(Grid.CtlText) ' Mã số tài sản hiện thời
                    pMaChungTu = 0 ' Cho phép ghi chứng từ mới
                    Select Case pNghiepVu ' Loại nghiệp vụ được xác định theo chức
                        Case NV_KHONG ' năng trên menu đã gọi ra frmDSCongcudungcu
                            Grid.Col = 0
                            If ConvertToDblSafe(Timten("namsd", Grid.CtlText, "maso", "congcudungcu")) = 1 Then FrmCongcudungcu.Tag = "1"
                            FrmCongcudungcu.ShowDialog()
                        Case NV_DGLAI
                            frmTangGiam.ShowDialog()
                            If pGhichungtu = 1 Then
                                SetListIndex(FrmChungtu.CboThang, pThangTacDong)
                                Me.Close()
                                Exit Sub
                            End If
                        Case NV_GIAM
                            GiamCongcudungcu(pMaCongcudungcu, pThangTacDong)
                            pGhichungtu = 1
                            SetListIndex(FrmChungtu.CboThang, pThangTacDong)
                            Me.Close()
                            Exit Sub
                    End Select
                    pMaCongcudungcu = 0
                    pMaChungTu = 0
                Else
                    SystemSounds.Beep.Play()
                End If
                Combo_SelectedIndexChanged(Combo(3), New EventArgs())
                Application.DoEvents()
            Case 1 ' Trở về ...........................................................................................................................................................
                TSChon = ""
                SendKeys.Send("{Escape}")
            Case 2 ' Xoá ................................................................................................................................................................
                Grid.Col = 0
                If Strings.Len(Grid.CtlText) > 0 Then
                    If System.Windows.Forms.DialogResult.Yes = MessageBox.Show(Ngonngu("Xoá công cụ dụng cụ hiện tại ?", "Delete current tool?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                        rs = ExecSQLReturnDT(String.Format("SELECT * FROM congcudungcu WHERE maso={0}", ConvertToDblSafe(Grid.CtlText)))
                        If rs.Rows.Count > 0 Then
                            Dim rsItem As DataRow = rs.Rows(0)
                            If ConvertToDblSafe(rsItem("NamSD")) = 1 Then
                                rs1 = ExecSQLReturnDT(String.Format("SELECT cl_ns+cl_tbs+cl_cnk+cl_td FROM thongso1 WHERE mats={0} and thang=0", rsItem("MaSo")))
                                If rs1.Rows.Count > 0 Then
                                    Dim rs1Item As DataRow = rs1.Rows(0)
                                    For i As Integer = 0 To 12
                                        If ConvertToDblSafe(rsItem("ThangTang")) = 0 Then
                                            If Timten("sohieu", rsItem("MaTaiKhoan"), "maso", "loaicongcudungcu").EndsWith("1") Then
                                                ExecSQLNonQuery(String.Format("UPDATE hethongtk set duno_{0}=duno_{1}-{2} WHERE sohieu='1421' or sohieu='142'", _
                                                                    i, _
                                                                    i, _
                                                                    rs1Item(0)))
                                            Else
                                                ExecSQLNonQuery(String.Format("UPDATE hethongtk set duno_{0}=duno_{1}-{2} WHERE sohieu='242'", _
                                                                    i, _
                                                                    i, _
                                                                    rs1Item(0)))
                                            End If
                                        Else
                                            If Timten("sohieu", rsItem("MaTaiKhoan"), "maso", "loaicongcudungcu").EndsWith("1") Then
                                                ExecSQLNonQuery(String.Format("UPDATE hethongtk set duno_{0}=duno_{1}-{2} WHERE sohieu='1531' or  sohieu='153'", _
                                                                    i, _
                                                                    i, _
                                                                    rs1Item(0)))
                                                ExecSQLNonQuery(String.Format("UPDATE tonkho set tien_{0}=tien_{1}-{2}, luong_{1}=luong_{1}-{3} WHERE mavattu={4} and mataikhoan={5}", _
                                                                    i, _
                                                                    i, _
                                                                    rs1Item(0), _
                                                                    rsItem("NamSX"), _
                                                                    IIf(Timten("maso", rsItem("ten"), "tenvattu", "vattu"), "-1", Timten("maso", rsItem("ten"), "tenvattu", "vattu")), _
                                                                    IIf(Timten("maso", "1531", "sohieu", "hethongtk") = String.Empty, "-1", Timten("maso", "1531", "sohieu", "hethongtk"))))
                                            Else
                                                ExecSQLNonQuery(String.Format("UPDATE hethongtk set duno_{0}=duno_{1}-{2} WHERE sohieu='1532' or sohieu='153'", _
                                                                    i, _
                                                                    i, _
                                                                    rs1Item(0)))
                                                ExecSQLNonQuery(String.Format("UPDATE tonkho set tien_{0}=tien_{1}-{2}, luong_{1}=luong_{1}-{3} WHERE mavattu={4} and mataikhoan={5}", _
                                                                    i, _
                                                                    i, _
                                                                    rs1Item(0), _
                                                                    rsItem("NamSX"), _
                                                                    IIf(Timten("maso", rsItem("ten"), "tenvattu", "vattu") = String.Empty, "-1", Timten("maso", rsItem("ten"), "tenvattu", "vattu")), _
                                                                    IIf(Timten("maso", "1532", "sohieu", "hethongtk") = String.Empty, "-1", Timten("maso", "1532", "sohieu", "hethongtk"))))
                                            End If
                                        End If
                                    Next
                                End If
                            End If
                        End If
                        Grid.Col = 0
                        If XoaCongcudungcu(ConvertToDblSafe(Grid.CtlText)) = 0 Then
                            Grid.RemoveItem(Grid.Row)
                            SetGridIndex(Grid, 0)
                        End If
                        SoDuTKTSCCDC()
                    End If
                End If
        End Select
XongDSTS:
        Me.Cursor = Cursors.Default
    End Sub
    '======================================================================================
    ' SUB LayDanhSachCongcudungcu
    '======================================================================================
    Private Sub LayDanhSachCongcudungcu()
        Dim sql As String = String.Empty
        Dim rs_danhsach As DataTable
        Me.Cursor = Cursors.WaitCursor
        ClearGrid(Grid, GRID_ROWS)
        Dim i As Integer = Combo(3).SelectedValue
        For chi_so As Integer = 1 To CThangDB2(i)
            If Not SoLieu(chi_so - 1) Then
                CapNhatGiaTriCongcudungcu(chi_so, FrmSocongcu.GauGe)
                SoLieu(chi_so - 1) = True
            End If
        Next
        If cuongdauky = 3 Or (cuongdauky = 7 And pNghiepVu = NV_GIAM) Then
            sql = String.Format("SELECT Congcudungcu.MaSo, Congcudungcu.SoHieu, Congcudungcu.Ten, NCT, (ThongSo1.NG_NS + ThongSo1.NG_TBS + ThongSo1.NG_CNK + ThongSo1.NG_TD) AS NguyenGia, (ThongSo1.CL_NS + ThongSo1.CL_TBS + ThongSo1.CL_CNK + ThongSo1.CL_TD) AS ConLai, (ThongSo1.KH_NS + ThongSo1.KH_TBS + ThongSo1.KH_CNK + ThongSo1.KH_TD) AS KhauHao, NamKH FROM Congcudungcu LEFT JOIN ThongSo1 ON Congcudungcu.MaSo = ThongSo1.MaTS WHERE Congcudungcu.MaLoai = {0} AND ((congcudungcu.namsd=1 and congcudungcu.thangtang=0) or thangtang=0 or Congcudungcu.SoHieu='' or Congcudungcu.SoHieu='...') and {1} AND ThongSo1.Thang= {2} ORDER BY NCT", _
                      Combo(1).SelectedValue, _
                      WThang("ThangGiam", i, 0), _
                      ConvertToStrSafe(CThangDB2(i)))
            Me.Text = Ngonngu(" Danh sách chi phí trả trước theo phân loại và thời gian", " List of Prepaid Expanses by Category and Time")
        ElseIf cuongdauky = 4 Or (cuongdauky = 6 And pNghiepVu = NV_GIAM) Then
            sql = String.Format("SELECT Congcudungcu.MaSo, Congcudungcu.SoHieu, Congcudungcu.Ten, NCT, (ThongSo1.NG_NS + ThongSo1.NG_TBS + ThongSo1.NG_CNK + ThongSo1.NG_TD) AS NguyenGia, (ThongSo1.CL_NS + ThongSo1.CL_TBS + ThongSo1.CL_CNK + ThongSo1.CL_TD) AS ConLai, (ThongSo1.KH_NS + ThongSo1.KH_TBS + ThongSo1.KH_CNK + ThongSo1.KH_TD) AS KhauHao, NamKH FROM Congcudungcu LEFT JOIN ThongSo1 ON Congcudungcu.MaSo = ThongSo1.MaTS WHERE Congcudungcu.MaLoai = {0} AND thangtang<>0 AND Congcudungcu.SoHieu<>'' and Congcudungcu.SoHieu<>'...' and {1} AND {2} AND ThongSo1.Thang= {3} ORDER BY NCT", _
                      Combo(1).SelectedValue, _
                      WThang("ThangTang", 0, i), _
                      WThang("ThangGiam", i, 0), _
                      ConvertToStrSafe(CThangDB2(i)))
            Me.Text = Ngonngu(" Danh sách công cụ dụng cụ theo phân loại và thời gian", " List of Tools by Category and Time")
        ElseIf pNghiepVu = NV_DGLAI Then
            sql = "SELECT Congcudungcu.MaSo, Congcudungcu.SoHieu, Congcudungcu.Ten, NCT, (ThongSo1.NG_NS + ThongSo1.NG_TBS + ThongSo1.NG_CNK + ThongSo1.NG_TD) AS NguyenGia, (ThongSo1.CL_NS + ThongSo1.CL_TBS + ThongSo1.CL_CNK + ThongSo1.CL_TD) AS ConLai, (ThongSo1.KH_NS + ThongSo1.KH_TBS + ThongSo1.KH_CNK + ThongSo1.KH_TD) AS KhauHao, NamKH" _
                & " FROM Congcudungcu LEFT JOIN ThongSo1 ON Congcudungcu.MaSo = ThongSo1.MaTS" _
                & " WHERE Congcudungcu.MaLoai = " + CStr(Combo(1).SelectedValue) _
                + " and Congcudungcu.SoHieu<>'...' and " + WThang("ThangTang", 0, i) + " AND " + WThang("ThangGiam", i, 0) + " AND ThongSo1.Thang= " + CStr(CThangDB(i)) _
                + " ORDER BY NCT"
            Me.Text = Ngonngu(" Danh sách công cụ dụng cụ theo phân loại và thời gian", " List of Tools by Category and Time")
        End If
        rs_danhsach = ExecSQLReturnDT(sql)
        Try
            For Each rsDanhsachItem As DataRow In rs_danhsach.Rows
                Grid.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                                 rsDanhsachItem("MaSo"), _
                                 Chr(9), _
                                 rsDanhsachItem("SoHieu"), _
                                 rsDanhsachItem("ten"), _
                                 Format(ConvertToDateSafe(rsDanhsachItem("NCT")), Mask_D), _
                                 Format(ConvertToDblSafe(rsDanhsachItem("NguyenGia")), Mask_0), _
                                 Format(ConvertToDblSafe(rsDanhsachItem("Conlai")), Mask_0), _
                                 rsDanhsachItem("NamKH"), _
                                 Format(ConvertToDblSafe(rsDanhsachItem("KhauHao")), Mask_0), _
                                 Format(ConvertToStrSafe(rsDanhsachItem("KhauHao")), Mask_0), 0))
            Next
        Catch ex As Exception
        End Try
Err_NoCurrentRecord:
        SetGridIndex(Grid, 0)
        Me.Cursor = Cursors.Arrow
    End Sub
    '======================================================================================
    ' FUNCTION CongcudungcuGiamTrongNam
    '======================================================================================
    Private Function CongcudungcuGiamTrongNam(ByRef ma_ts As Integer) As Boolean
        Dim sql As String = String.Format("SELECT ThangGiam AS F1 FROM Congcudungcu WHERE MaSo = {0}", ma_ts)
        If ConvertToDblSafe(GetSelectValue(sql)) = 13 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub Grid_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grid.KeyUp
        If eventArgs.KeyCode = 37 _
        Or eventArgs.KeyCode = 38 _
        Or eventArgs.KeyCode = 39 _
        Or eventArgs.KeyCode = 40 Then
            SetGridIndex(Grid, Grid.Row)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grid_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles Grid.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , Grid, Grid.Col)
        End If
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", Combo(3).SelectedValue))) > 0 Then
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
    Private Sub frmDSCCDC_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
