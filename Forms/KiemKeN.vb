Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class KiemKeN
    Private _taikhoan As ClsTaikhoan = Nothing
    Property taikhoan() As ClsTaikhoan
        Get
            If _taikhoan Is Nothing Then
                _taikhoan = New ClsTaikhoan()
            End If
            Return _taikhoan
        End Get
        Set(ByVal Value As ClsTaikhoan)
            _taikhoan = Value
        End Set
    End Property
    Private _vattu As ClsVattu = Nothing
    Property vattu() As ClsVattu
        Get
            If _vattu Is Nothing Then
                _vattu = New ClsVattu()
            End If
            Return _vattu
        End Get
        Set(ByVal Value As ClsVattu)
            _vattu = Value
        End Set
    End Property
    Dim phatsinh As Boolean
    Dim Ngay As Date
    Dim tygia As Double
    Private Sub CboKho_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboKho.SelectedIndexChanged
        If CboKho.SelectedIndex >= 0 Then LietKeKK()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        Dim dgia As Double
        Dim dvt, ms As Integer
        If CboKho.SelectedIndex < 0 Then
            ErrMsg(er_KhoHang)
            Exit Sub
        End If
        If taikhoan.maso = 0 Or taikhoan.tkcon > 0 Then
            ErrMsg(er_SHTaiKhoan1)
            txtTon(0).Focus()
            Exit Sub
        End If
        If vattu.MaSo = 0 Then
            ErrMsg(er_SHVattu)
            txtTon(1).Focus()
            Exit Sub
        End If
        Dim luong As Double = ConvertToDblSafe(txtTon(4).Text)
        Dim tien As Double = ConvertToDblSafe(txtTon(6).Text)
        Dim tien2 As Double = ConvertToDblSafe(txtTon(7).Text)
        dgia = IIf(luong <> 0, (IIf(0.5 + tien / luong > 0, Math.Floor(0.5 + tien / luong), Math.Ceiling(0.5 + tien / luong))), 0)
        If (tien <> 0) And (luong = 0) Then
            myUMessager.mError(Ngonngu("Hãy nhập số lượng tồn kho !", "Enter quantity of tock !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(4).Focus()
            Exit Sub
        End If
        If vattu.Dvt2 > 0 Then
            dvt = CboDV.SelectedIndex
        Else
            dvt = 0
        End If
        Me.Cursor = Cursors.Default
        With GrdVT
            If OutCost = 0 Then
                For i As Integer = 0 To .Rows - 1
                    .Col = 7
                    .Row = i
                    If .CtlText.length = 0 Then Exit For
                    If ConvertToDblSafe(.CtlText) = taikhoan.maso Then
                        .Col = 8
                        If ConvertToDblSafe(.CtlText) = vattu.MaSo Then
                            .Col = 11
                            ExecSQLNonQuery("DELETE FROM KiemKeN WHERE MaSo=" & ConvertToDblSafe(.CtlText))
                            GrdVT.RemoveItem(ConvertToDblSafe(i))
                            ms = GhiKiemKe(CboKho.SelectedIndex, taikhoan.maso, vattu.MaSo, luong, tien, tien2)
                            If ms > 0 Then
                                GrdVT.AddItem(taikhoan.sohieu & Chr(9).ToString() & vattu.sohieu & Chr(9).ToString() & vattu.TenVattu & Chr(9).ToString() & (IIf(dvt = 0, vattu.DonVi, CboDV.Text)) & Chr(9).ToString() & Format(luong, Mask_2) & Chr(9).ToString() & Format(dgia, Mask_0) & Chr(9).ToString() & Format(tien, Mask_0) & Chr(9).ToString() & ConvertToStrSafe(taikhoan.maso) & Chr(9).ToString() & ConvertToStrSafe(vattu.MaSo) & Chr(9).ToString() & ConvertToStrSafe(dvt) & Chr(9).ToString() & Format(tien2, Mask_2) & Chr(9).ToString() & ConvertToStrSafe(ms), i)
                                If dvt > 0 Then luong = QuyDoiTheoDVT1(vattu.MaSo, dvt, luong)
                                'phatsinh = True
                            End If
                            tongtien()
                            txtTon(0).Focus()
                            GoTo XongDK
                        End If
                    End If
                Next
            End If
            ms = GhiKiemKe(CboKho.SelectedIndex, taikhoan.maso, vattu.MaSo, luong, tien, tien2)
            If ms > 0 Then
                .AddItem(taikhoan.sohieu & Chr(9).ToString() & vattu.sohieu & Chr(9).ToString() & vattu.TenVattu & Chr(9).ToString() & (IIf(dvt = 0, vattu.DonVi, CboDV.Text)) & Chr(9).ToString() & Format(luong, Mask_2) & Chr(9).ToString() & Format(dgia, Mask_2) & Chr(9).ToString() & Format(tien, Mask_0) & Chr(9).ToString() & ConvertToStrSafe(taikhoan.maso) & Chr(9).ToString() & ConvertToStrSafe(vattu.MaSo) & Chr(9).ToString() & ConvertToStrSafe(dvt) & Chr(9).ToString() & Format(tien2, Mask_2) & Chr(9).ToString() & ConvertToStrSafe(ms), NewRowIndex(GrdVT, 0))
                If dvt > 0 Then luong = QuyDoiTheoDVT1(vattu.MaSo, dvt, luong)
                If .Row > 0 Then
                    .Row = (.Row - 1)                
                End If
                .Col = 0
                If .CtlText.Length = 0 Then .RemoveItem(.Row)
                .Row = 0
            End If
                txtTon(0).Focus()
        End With
        tongtien()
XongDK:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click, _Command_2.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0 : If CboKho.SelectedIndex >= 0 Then XuLyChenhLech(Ngay, CboKho.SelectedValue)
            Case 1 : Me.Close()
            Case 2
                ExecSQLNonQuery("DELETE FROM KiemKeN WHERE Ngay='" & Format(CDate(Ngay), Mask_DB) & "'")
                LietKeTonKho(CboKho.SelectedIndex, Ngay, 1)
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub KiemKeN_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Or eventArgs.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub KiemKeN_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ColumnSetUp(GrdVT, 0, 940, 2)
            ColumnSetUp(GrdVT, 1, 1300, 2)
            ColumnSetUp(GrdVT, 2, 2380, 0)
            ColumnSetUp(GrdVT, 3, 700, 2)
            ColumnSetUp(GrdVT, 4, 1370, 4)
            ColumnSetUp(GrdVT, 5, 1370, 4)
            ColumnSetUp(GrdVT, 6, 1370, 4)
            ColumnSetUp(GrdVT, 7, 1, 0)
            ColumnSetUp(GrdVT, 8, 1, 0)
            ColumnSetUp(GrdVT, 9, 1, 0)
            ColumnSetUp(GrdVT, 10, 1260, 4)
            ColumnSetUp(GrdVT, 11, 1, 0)
            InitDateVars(MedNgay, Ngay)
            Text = SetFormTitle(Text)

            If pGiaUSD > 0 Then
                tygia = TyGiaDK()
                Label(11).Text = Label(11).Text & "  " & Format(tygia, Mask_0)
                Me.Width = 750
                Label(10).Visible = True
                Label(11).Visible = True
                GrdVT.Width = 730
                cmdct.Location = New Point(721, cmdct.Location.Y)
                txtTon(7).Visible = True
                Me.StartPosition = FormStartPosition.CenterScreen
            Else
                Me.Width = 667
                Label(10).Visible = False
                Label(11).Visible = False
                GrdVT.Width = 641
                cmdct.Location = New Point(632, cmdct.Location.Y)
                txtTon(7).Visible = False
                Me.StartPosition = FormStartPosition.CenterScreen
            End If
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho)
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
    Private Sub KiemKeN_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        taikhoan = Nothing
        vattu = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdVT.DoubleClick
        With GrdVT
            .Col = 0
            If .CtlText.length = 0 Then Exit Sub
            For i As Integer = 0 To 1
                .Col = ConvertToDblSafe(i)
                txtTon(i).Text = .CtlText
            Next
            txtTon_Leave(txtTon(0), New EventArgs())
            txtTon_Leave(txtTon(1), New EventArgs())
            .Col = 9
            If vattu.Dvt2 > 0 Then SetListIndex(CboDV, ConvertToDblSafe(.CtlText))
            For i As Integer = 2 To 6
                .Col = ConvertToDblSafe(i)
                txtTon(i).Text = .CtlText
            Next
            If pGiaUSD > 0 Then
                .Col = 10
                txtTon(7).Text = .CtlText
            End If
            .Col = 11
            ExecSQLNonQuery("DELETE FROM KiemKeN WHERE MaSo=" & ConvertToDblSafe(.CtlText))
            .RemoveItem(.Row)
            If .Rows < ConvertToDblSafe(.Tag) Then .Rows = ConvertToDblSafe(.Tag)
            txtTon(0).Focus()
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdVT.KeyPress
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdVT_DblClick(GrdVT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdVT.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdVT, GrdVT.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_7.Enter, _txtTon_6.Enter, _txtTon_5.Enter, _txtTon_4.Enter, _txtTon_3.Enter, _txtTon_2.Enter, _txtTon_1.Enter, _txtTon_0.Enter
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        txtTon(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_7.KeyPress, _txtTon_6.KeyPress, _txtTon_5.KeyPress, _txtTon_4.KeyPress, _txtTon_3.KeyPress, _txtTon_2.KeyPress, _txtTon_1.KeyPress, _txtTon_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 13 Then
                    txtTon(0).Text = FrmTaikhoan.ChonTk(txtTon(0).Text)
                End If
            Case 1
                If KeyAscii = 13 Then
                    txtTon(1).Text = FrmVattu.ChonVattu(txtTon(1).Text)
                End If
            Case 2, 3
                KeyAscii = 0
            Case 4, 5, 6
                If Index = 6 And KeyAscii = 13 Then
                    cmdct_Click(cmdct, New EventArgs())
                Else
                    KeyProcess(txtTon(Index), KeyAscii, True)
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
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_7.Leave, _txtTon_6.Leave, _txtTon_5.Leave, _txtTon_4.Leave, _txtTon_3.Leave, _txtTon_2.Leave, _txtTon_1.Leave, _txtTon_0.Leave
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Dim luong As Double
        Select Case Index
            Case 0
                If Strings.Len(txtTon(0).Text) > 0 Then
                    taikhoan.InitTaikhoanSohieu(txtTon(0).Text)
                Else
                    taikhoan.InitTaikhoanMaSo(0)
                End If
            Case 1
                If Strings.Len(txtTon(1).Text) > 0 Then
                    vattu.InitVattuSohieu(txtTon(1).Text)
                Else
                    vattu.InitVattuMaSo(0)
                End If
                txtTon(2).Text = vattu.TenVattu
                txtTon(3).Text = vattu.DonVi
                If vattu.GiaHT > 0 Then txtTon(5).Text = Format(vattu.GiaHT, Mask_2)
                If vattu.Dvt2 > 0 Then
                    Int_RecsetToCbo("SELECT MaSo AS F2, DonVi AS F1 FROM DVTVattu WHERE MaVattu=" & vattu.MaSo & " ORDER BY DonVi", CboDV)
                    CboDV.Items.Insert(0, vattu.DonVi)
                    If CboDV.Items.Count > 0 Then CboDV.SelectedIndex = 0
                    CboDV.Visible = True
                    CboDV.Focus()
                Else
                    CboDV.Visible = False
                End If
            Case 4
                txtTon(6).Text = Format(RoundMoney(ConvertToDblSafe(txtTon(4).Text) * ConvertToDblSafe(txtTon(5).Text)), Mask_0)
            Case 5
                txtTon(5).Text = Format(txtTon(5).Text, Mask_2)
                txtTon(6).Text = Format(RoundMoney(ConvertToDblSafe(txtTon(4).Text) * ConvertToDblSafe(txtTon(5).Text)), Mask_0)
            Case 6
                luong = ConvertToDblSafe(txtTon(4).Text)
                If luong <> 0 Then
                    txtTon(5).Text = Format(ConvertToDblSafe(txtTon(6).Text) / luong, Mask_2)
                Else
                    txtTon(5).Text = "0"
                End If
            Case 7
                txtTon(7).Text = Format(txtTon(7).Text, Mask_2)
        End Select
    End Sub
    '======================================================================================
    ' Thủ tục liệt kê tồn kho
    '======================================================================================
    Private Sub LietKeTonKho(ByRef mkho As Integer, ByRef Ngay As Date, ByRef lk As Integer)
        Dim dgia, luong, T, t2 As Double
        Me.Cursor = Cursors.WaitCursor
        ClearGrid(GrdVT, ConvertToDblSafe(GrdVT.Tag))
        Dim rs_ton As DataTable = ExecSQLReturnDT(String.Format("SELECT HethongTK.MaSo,HethongTK.SoHieu AS SHTK,MaVattu,Vattu.SoHieu,Vattu.TenVattu,Vattu.DonVi  FROM (TonKho INNER JOIN Vattu ON TonKho.MaVattu = Vattu.MaSo) INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo WHERE MaSoKho = {0} ORDER BY HethongTK.SoHieu DESC, Vattu.SoHieu DESC", mkho))
        For Each rstonItem As DataRow In rs_ton.Rows
            luong = SoTonKhoN(Ngay, _
                        mkho, _
                        ConvertToDblSafe(rstonItem("MaSo")), _
                        ConvertToDblSafe(rstonItem("MaVattu")), _
                        T, _
                        t2)
            If luong <> 0 Or T <> 0 Or t2 <> 0 Then
                dgia = IIf(luong <> 0, (IIf(0.5 + T / luong > 0, Math.Floor(0.5 + T / luong), Math.Ceiling(0.5 + T / luong))), 0)
                GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{1}{10}", _
                                  rstonItem("shtk"), _
                                  Chr(9), _
                                  rstonItem("SoHieu"), _
                                  rstonItem("TenVattu"), _
                                  rstonItem("DonVi"), _
                                  Format(luong, Mask_2), _
                                  Format(dgia, Mask_2), _
                                  Format(T, Mask_0), _
                                  rstonItem("MaSo"), _
                                  rstonItem("MaVattu"), _
                                  Format(t2, Mask_2)), 0)
                If lk = 1 Then
                    GhiKiemKe(mkho, _
                        ConvertToDblSafe(rstonItem("MaSo")), _
                        ConvertToDblSafe(rstonItem("MaVattu")), _
                        luong, _
                        T, _
                        t2)
                End If
            End If
        Next
        GrdVT.Rows = IIf(rs_ton.Rows.Count > ConvertToDblSafe(GrdVT.Tag), rs_ton.Rows.Count, ConvertToDblSafe(GrdVT.Tag))
        GrdVT.Row = 0
        tongtien()
        Me.Cursor = Cursors.Default
    End Sub
    '======================================================================================
    ' Thủ tục ghi số tồn kho đầu kỳ
    '======================================================================================
    Private Function GhiKiemKe(ByRef mkho As Integer, ByRef mtk As Integer, ByRef mvt As Integer, ByRef luong As Double, ByRef tien As Double, ByRef tien2 As Double) As Integer
        Dim result As Integer = 0
        Try
            Dim recordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery("INSERT INTO KiemKeN (MaSo,Ngay,MaSoKho,MaTaiKhoan,MaVattu,SoLuong,ThanhTien,ThanhTien2) VALUES (" & Lng_MaxValue("MaSo", "KiemKeN") + 1 & ",'" & Format(CDate(Ngay), Mask_DB) & "'," & ConvertToStrSafe(mkho) & "," & ConvertToStrSafe(mtk) & "," & ConvertToStrSafe(mvt) & "," & (luong) & "," & (tien) & "," & (tien2) & ")")
            If recordsAffectedCount > 0 Then result = Lng_MaxValue("MaSo", "KiemKeN")
        Catch ex As Exception
            myUMessager.mError(ex.Message, Ngonngu("Ghi kiểm kê", "Save values"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
        Return result
    End Function
    Private Sub tongtien()
        Dim t2 As Double
        Dim T As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT ISNULL(Sum(ThanhTien),0) As F1, ISNULL(Sum(ThanhTienUSD),0) As F2 FROM KiemKeN WHERE MaSoKho = {0} AND Ngay=N'{1}'", _
                                                              CboKho.SelectedIndex, _
                                                              Format(CDate(Ngay), Mask_DB)), t2))
        LbTien(0).Text = Format(T, Mask_0)
        If pGiaUSD > 0 Then LbTien(1).Text = Format(t2, Mask_2)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="n"></param>
    ''' <param name="mkho"></param>
    ''' <remarks></remarks>
    Private Sub XuLyChenhLech(ByRef n As Date, ByRef mkho As Integer)
        Dim tien, luong, tien2 As Double
        Dim i As Integer
        Dim tempLoadForm As FrmChungtu = FrmChungtu
        FrmChungtu.initOption = 2
        SetListIndex(FrmChungtu.CboNguon(1), mkho)
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaTaiKhoan, MaVattu, HethongTK.SoHieu AS SHTK, Vattu.SoHieu AS SHVT, SoLuong, ThanhTien AS Tien, ThanhTien2 AS Tien2 FROM  (KiemKeN INNER JOIN HethongTK ON KiemKeN.MaTaiKhoan=HethongTK.MaSo) INNER JOIN Vattu ON KiemKeN.MaVattu=Vattu.MaSo WHERE MaSoKho={0} AND Ngay=N'{1}' ORDER BY HethongTK.SoHieu DESC, Vattu.SoHieu DESC", _
                                                  mkho, _
                                                  Format(n, Mask_DB)))
        For Each rsItem As DataRow In rs.Rows
            luong = SoTonKhoN(n, mkho, rsItem("MaTaiKhoan"), rsItem("MaVattu"), tien, tien2)
            If luong <> ConvertToDblSafe(rsItem("soluong")) _
            Or tien <> ConvertToDblSafe(rsItem("tien")) _
            Or tien2 <> ConvertToDblSafe(rsItem("tien2")) Then
                FrmChungtu.txtchungtu(0).Text = ConvertToStrSafe(rsItem("shtk"))
                FrmChungtu.txtchungtu(2).Text = ConvertToStrSafe(rsItem("shvt"))
                FrmChungtu.txtchungtu(3).Text = Format(luong - ConvertToDblSafe(rsItem("soluong")), Mask_2)
                FrmChungtu.txtchungtu(5).Text = ""
                FrmChungtu.txtchungtu(6).Text = Format(tien - ConvertToDblSafe(rsItem("tien")), Mask_2)
                FrmChungtu.txtchungtu(11).Text = Format(tien2 - ConvertToDblSafe(rsItem("tien2")), Mask_2)
                FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())
                i += 1
            End If
        Next
        If i > 0 Then
            pFunction = 10
            FrmChungtu.ShowDialog()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgay.Enter
        MedNgay.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgay.Leave
        If Information.IsDate(MedNgay.Text) Then
            Ngay = ConvertToDateSafe(MedNgay.Text)
            LietKeKK()
        Else
            MedNgay.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeKK()
        Dim dgia As Double
        Me.Cursor = Cursors.WaitCursor
        ClearGrid(GrdVT, ConvertToDblSafe(GrdVT.Tag))
        Dim rs_ton As DataTable = ExecSQLReturnDT(String.Format("SELECT KiemKeN.MaSo, HethongTK.MaSo AS MTK,HethongTK.SoHieu AS SHTK,MaVattu,Vattu.SoHieu,Vattu.TenVattu,Vattu.DonVi,SoLuong,ThanhTien,ThanhTien2  FROM (KiemKeN INNER JOIN Vattu ON KiemKeN.MaVattu = Vattu.MaSo) INNER JOIN HethongTK ON KiemKeN.MaTaiKhoan=HethongTK.MaSo WHERE MaSoKho = {0} AND Ngay=N'{1}' ORDER BY HethongTK.SoHieu DESC, Vattu.SoHieu DESC", _
                                                      CboKho.SelectedIndex, _
                                                      Format(CDate(Ngay), Mask_DB)))
        For Each rstonItem As DataRow In rs_ton.Rows
            dgia = IIf(ConvertToDblSafe(rstonItem("SoLuong")) <> 0, ConvertToDblSafe(rstonItem("ThanhTien")) / ConvertToDblSafe(rstonItem("SoLuong")), 0)
            GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{1}{10}{1}{11}", _
                              rstonItem("shtk"), _
                              Chr(9), _
                              rstonItem("SoHieu"), _
                              rstonItem("TenVattu"), _
                              rstonItem("DonVi"), _
                              Format(rstonItem("SoLuong"), Mask_2), _
                              Format(dgia, Mask_2), _
                              Format(rstonItem("ThanhTien"), Mask_0), _
                              rstonItem("mtk"), _
                              rstonItem("MaVattu"), _
                              Format(rstonItem("ThanhTien2"), Mask_2), _
                              rstonItem("MaSo")), 0)
        Next
        GrdVT.Rows = IIf(rs_ton.Rows.Count > ConvertToDblSafe(GrdVT.Tag), _
                         rs_ton.Rows.Count, _
                         ConvertToDblSafe(GrdVT.Tag))
        GrdVT.Row = 0
        tongtien()
        Me.Cursor = Cursors.Default
    End Sub


End Class
