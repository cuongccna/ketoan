Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class FVTDauKy

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
    Dim f1 As Integer
    Dim tbl As String = String.Empty
    Dim tygia As Double
    'van.nguyen 30-Nov-2011
    Dim currentCboKhoSelect As Integer = -2
    Dim currentCboLoaiSelect As Integer = -2
    Private Sub Cbo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Cbo.SelectedIndexChanged
        If f1 > 0 And CboKho.SelectedIndex >= 0 Then
            LietKeTonKho(CboKho.SelectedValue, IIf(f1 = 0, 0, Cbo.SelectedValue), 0)
        End If


    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboKho_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboKho.SelectedIndexChanged
        'If f1 >= 0 And CboKho.SelectedIndex >= 0 Then
        '    LietKeTonKho(CboKho.SelectedValue, iif(f1 = 0, 0, Cbo.SelectedValue), 0)
        'End If
        If f1 >= 0 And CboKho.SelectedIndex >= 0 Then
            'If currentCboKhoSelect <> CboKho.SelectedIndex Then

            currentCboKhoSelect = CboKho.SelectedIndex
            LietKeTonKho(CboKho.SelectedValue, IIf(f1 = 0, 0, Cbo.SelectedValue), 0)
            'End If
        End If



    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Cboloai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Cboloai.SelectedIndexChanged
        'txtTon(0).Text = taikhoanconnhat(MaSo2SoHieu(Cboloai.SelectedIndex, "hethongtk"))
        'txtTon(0).Focus()


        'If currentCboLoaiSelect <> Cboloai.SelectedIndex Then
        currentCboLoaiSelect = Cboloai.SelectedIndex
        txtTon(0).Text = taikhoanconnhat(MaSo2SoHieu(Cboloai.SelectedValue, "hethongtk"))
        txtTon(0).Focus()
        'End If

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        Dim dgia As Double
        Dim dvt As Integer
        If CboKho.SelectedIndex < 0 Then
            ErrMsg(er_KhoHang)
            Exit Sub
        End If
        If taikhoan.maso = 0 Or taikhoan.tkcon > 0 Or taikhoan.tk_id <> TKVT_ID Then
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
        dgia = IIf(luong <> 0, (IIf(0.5 + Mask_N * tien / luong > 0, Math.Floor(0.5 + Mask_N * tien / luong), Math.Ceiling(0.5 + Mask_N * tien / luong))) / Mask_N, 0)
        If (tien <> 0) And (luong = 0) Then
            MessageBox.Show(Ngonngu("Hãy nhập số lượng tồn kho !", "Enter quantity of stock!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(4).Focus()
            Exit Sub
        End If
        If vattu.Dvt2 > 0 Then
            dvt = CboDV.SelectedValue
        Else
            dvt = 0
        End If
        Me.Cursor = Cursors.Default
        With GrdVT
            If OutCost = 0 Or f1 > 0 Then
                For i As Integer = 0 To .Rows - 1
                    .Col = 7
                    .Row = i
                    If Strings.Len(.CtlText) = 0 Then Exit For
                    If ConvertToDblSafe(.CtlText) = taikhoan.maso Then
                        .Col = 8
                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = vattu.MaSo Then
                            GrdVT.RemoveItem(ConvertToDblSafe(i))
                            GrdVT.AddItem(taikhoan.sohieu & Chr(9).ToString() & vattu.sohieu & Chr(9).ToString() & vattu.TenVattu & Chr(9).ToString() & (IIf(dvt = 0, vattu.DonVi, CboDV.Text)) & Chr(9).ToString() & Format(luong, Mask_2) & Chr(9).ToString() & Format(dgia, Mask_2) & Chr(9).ToString() & Format(tien, Mask_0) & Chr(9).ToString() & ConvertToStrSafe(taikhoan.maso) & Chr(9).ToString() & ConvertToStrSafe(vattu.MaSo) & Chr(9).ToString() & ConvertToStrSafe(dvt) & (IIf(pGiaUSD > 0, Chr(9).ToString() & Format(tien2, Mask_2), String.Empty)), i)
                            If dvt > 0 Then luong = QuyDoiTheoDVT1(vattu.MaSo, dvt, luong)
                            GhiDauKy(CboKho.SelectedValue, taikhoan.maso, vattu.MaSo, luong, tien, tien2)
                            phatsinh = True
                            tongtien()
                            txtTon(0).Focus()
                            GoTo XongDK
                        End If
                    End If
                Next
            Else
                ExecSQLNonQuery("INSERT INTO VTDauNam (MaSo,MaSoKho,MaTaiKhoan,MaVattu,Luong_0,Tien_0) VALUES (" & Lng_MaxValue("MaSo", "VTDauNam") + 1 & "," & ConvertToStrSafe(CboKho.SelectedValue) & "," & ConvertToStrSafe(taikhoan.maso) & "," & ConvertToStrSafe(vattu.MaSo) & "," & CStr(luong) & "," & CStr(tien) & ")")
            End If
            phatsinh = True
            .AddItem(taikhoan.sohieu & Chr(9).ToString() & vattu.sohieu & Chr(9).ToString() & vattu.TenVattu & Chr(9).ToString() & (IIf(dvt = 0, vattu.DonVi, CboDV.Text)) & Chr(9).ToString() & Format(luong, Mask_2) & Chr(9).ToString() & Format(dgia, Mask_2) & Chr(9).ToString() & Format(tien, Mask_0) & Chr(9).ToString() & ConvertToStrSafe(taikhoan.maso) & Chr(9).ToString() & ConvertToStrSafe(vattu.MaSo) & Chr(9).ToString() & ConvertToStrSafe(dvt) & (IIf(pGiaUSD > 0, Chr(9).ToString() & Format(tien2, Mask_2), String.Empty)), NewRowIndex(GrdVT, 0))
            If dvt > 0 Then luong = QuyDoiTheoDVT1(vattu.MaSo, dvt, luong)
            GhiDauKy(CboKho.SelectedValue, taikhoan.maso, vattu.MaSo, luong, tien, tien2)
            If .Row > 0 Then
                .Row = (.Row - 1)
            End If
            .Col = 0
            If Strings.Len(.CtlText) = 0 Then .RemoveItem(.Row)
            .Row = 0
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
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_1.Click, _Command_0.Click, _Command_3.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim thang As Integer = Cbo.SelectedValue
        Select Case Index
            Case 0 : If CboKho.SelectedIndex >= 0 Then XuLyChenhLech(thang, CboKho.SelectedValue)
            Case 1 : Me.Close()
            Case 2
                If f1 >= 0 Then
                    ExecSQLNonQuery("UPDATE KiemKe SET Luong_" & thang & "=0,Tien_" & ConvertToStrSafe(thang) & "=0")
                    LietKeTonKho(CboKho.SelectedValue, IIf(f1 = 0, 0, thang), 1)
                End If
            Case 3
                With GrdVT
                    If OutCost = 0 Or f1 > 0 Then
                        .Col = 7
                        If ConvertToDblSafe(.CtlText) = taikhoan.maso Then
                            .Col = 8
                            If ConvertToDblSafe(.CtlText) = vattu.MaSo Then
                                .RemoveItem(.Row)
                                'van.nguyen 19-Nov-2011
                                .Refresh()
                                GhiDauKy(CboKho.SelectedValue, taikhoan.maso, vattu.MaSo, 0, 0, 0)
                                txtTon(4).Text = "0" : txtTon(5).Text = "0" : txtTon(6).Text = "0"
                                tongtien()
                                txtTon(0).Focus()
                                Exit Sub
                            End If
                        End If
                        For i As Integer = 0 To .Rows - 1
                            .Col = 7
                            .Row = i
                            If .CtlText.length = 0 Then Exit For
                            If ConvertToDblSafe(.CtlText) = taikhoan.maso Then
                                .Col = 8
                                If ConvertToDblSafe(.CtlText) = vattu.MaSo Then
                                    .RemoveItem(ConvertToDblSafe(i))
                                    'van.nguyen 19-Nov-2011
                                    .Refresh()
                                    GhiDauKy(CboKho.SelectedValue, taikhoan.maso, vattu.MaSo, 0, 0, 0)
                                    txtTon(4).Text = "0" : txtTon(5).Text = "0" : txtTon(6).Text = "0"
                                    tongtien()
                                    txtTon(0).Focus()
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                End With
        End Select
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        f1 = ConvertToDblSafe(Me.Tag)
        If f1 > 0 Then
            Me.Text = IIf(pNN = 0, "Kiểm kê cuối kỳ", "Inventory")
            Label(9).Visible = True
            Cbo.Visible = True
            Command(0).Visible = True
            Command(2).Visible = True
            txtTon(7).Enabled = False
            tbl = "KiemKe"
        Else
            tbl = "TonKho"
            CboKho_SelectedIndexChanged(CboKho, New EventArgs())
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FVTDauKy_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub FVTDauKy_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdVT, 0, 950, 2)
            ColumnSetUp(GrdVT, 1, 1310, 2)
            ColumnSetUp(GrdVT, 2, 2390, 0)
            ColumnSetUp(GrdVT, 3, 710, 2)
            ColumnSetUp(GrdVT, 4, 1310, 4)
            ColumnSetUp(GrdVT, 5, 1310, 4)
            ColumnSetUp(GrdVT, 6, 1280, 4)
            ColumnSetUp(GrdVT, 7, 1, 0)
            ColumnSetUp(GrdVT, 8, 1, 0)
            ColumnSetUp(GrdVT, 9, 1, 0)
            ColumnSetUp(GrdVT, 10, 1, 0)
            AddMonthToCbo(Cbo)
            Int_RecsetToCbo("SELECT DISTINCT PhanLoaiVattu.MaTK As F2, PhanLoaiVattu.SoHieu + ' - '  + PhanLoaiVattu.TenPhanLoai As F1, PhanLoaiVattu.SoHieu FROM PhanLoaiVattu WHERE PLCon=0 ORDER BY PhanLoaiVattu.SoHieu", Cboloai)
            If Cboloai.Items.Count > 0 Then
                Cboloai.SelectedIndex = 0
            End If
            Text = String.Format("{0} - {1}", Text, ConvertToStrSafe(pNamTC))
            f1 = -1
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho)
            If CboKho.Items.Count > 0 Then
                CboKho.SelectedIndex = 0
            End If
            f1 = 0
            phatsinh = False
            If pGiaUSD > 0 Then
                tygia = TyGiaDK()
                Label(11).Text = String.Format("{0}  {1}", Label(11).Text, Format(tygia, Mask_0))
                Me.Width += 1300
                Label(10).Visible = True
                Label(11).Visible = True
                GrdVT.Width += 1300
                cmdct.Left += 1300
                txtTon(7).Visible = True
                Me.StartPosition = FormStartPosition.CenterScreen
            End If
            CboKho_SelectedIndexChanged(eventSender, eventArgs)
            Cboloai_SelectedIndexChanged(eventSender, eventArgs)
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
    Private Sub FVTDauKy_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        If phatsinh Then
            Me.Cursor = Cursors.WaitCursor
            SoDuTKVT()
            Me.Cursor = Cursors.Default
        End If
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
        Dim ms As Integer
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
            If OutCost <> 0 Then
                ms = ConvertToDblSafe(GetSelectValue("SELECT TOP 1 MaSo AS F1 FROM VTDauNam WHERE MaSoKho=" & CboKho.SelectedValue & " AND MaTaiKhoan=" & ConvertToStrSafe(taikhoan.maso) & " AND MaVattu=" & ConvertToStrSafe(vattu.MaSo) & " AND Luong_0=" & CStr(ConvertToDblSafe(txtTon(4).Text)) & " AND Tien_0=" & CStr(ConvertToDblSafe(txtTon(6).Text))))
                If ms > 0 Then ExecSQLNonQuery("DELETE FROM VTDauNam WHERE MaSo=" & ms)
                GhiDauKy(CboKho.SelectedValue, taikhoan.maso, vattu.MaSo, 0, 0, 0)
                .RemoveItem(.Row)
                If .Rows < ConvertToDblSafe(.Tag) Then .Rows = ConvertToDblSafe(.Tag)
            End If
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
    Private Sub GrdVT_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdVT.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(GrdVT, GrdVT.Row)
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
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
            Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
            Select Case Index
                Case 0
                    If KeyAscii = 13 Then
                        txtTon(0).Text = FrmTaikhoan.ChonTk(txtTon(0).Text)
                    End If
                Case 1
                    If KeyAscii = 13 Then
                        txtTon(1).Text = FrmVattu.ChonVattu(txtTon(1).Text, 0, Cboloai.SelectedValue, 0, 1)
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
                txtTon(4).Text = Format(txtTon(4).Text, Mask_2)
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
    ''' <summary>
    ''' Thủ tục liệt kê tồn kho
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeTonKho(ByRef mkho As Integer, ByRef thang As Integer, ByRef lk As Integer)
        Dim dgia, t2 As Double
        Dim tb As String = String.Empty
        Me.Cursor = Cursors.WaitCursor
        tb = IIf(lk = 1, "TonKho", (IIf(f1 = 0, (IIf(OutCost <> 0, "VTDauNam", "TonKho")), "KiemKe")))
        ClearGrid(GrdVT, ConvertToDblSafe(GrdVT.Tag))
        Dim rs_ton As DataTable = ExecSQLReturnDT(String.Format("SELECT HethongTK.MaSo,HethongTK.SoHieu AS SHTK,MaVattu,Vattu.SoHieu,Vattu.TenVattu,Vattu.DonVi, Luong_{0} AS Luong, Tien_{1} AS Tien FROM ({2} INNER JOIN Vattu ON {2}.MaVattu = Vattu.MaSo) INNER JOIN HethongTK ON {2}.MaTaiKhoan=HethongTK.MaSo WHERE MaSoKho = {3} AND (Luong_{1}<> 0 OR Tien_{1}<>0) ORDER BY HethongTK.SoHieu DESC, Vattu.SoHieu DESC", _
                                                      CThangDB2(thang), _
                                                      ConvertToStrSafe(CThangDB2(thang)), _
                                                      tb, _
                                                      mkho))
        For Each rstonItem As DataRow In rs_ton.Rows
            Dim str As String = String.Format("SELECT Tien_{0} AS F1 FROM TonKho WHERE MaTaiKhoan={1} AND MaSoKho={2} AND MaVattu={3}", _
                                                                         CThangDB2(thang), _
                                                                         rstonItem("MaSo"), _
                                                                         mkho, _
                                                                         rstonItem("MaVattu"))
            dgia = IIf(ConvertToDblSafe(rstonItem("luong")) <> 0, _
                       (IIf(0.5 + ConvertToDblSafe(rstonItem("tien")) / ConvertToDblSafe(rstonItem("luong")) > 0, Math.Floor(0.5 + ConvertToDblSafe(rstonItem("tien")) / ConvertToDblSafe(rstonItem("luong"))), Math.Ceiling(0.5 + ConvertToDblSafe(rstonItem("tien")) / ConvertToDblSafe(rstonItem("luong"))))), _
                       0)
            If pGiaUSD > 0 Then t2 = ConvertToDblSafe(GetSelectValue(str))
            str = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{1}{10}", _
                              rstonItem("shtk"), _
                              Chr(9), _
                              rstonItem("SoHieu"), _
                              rstonItem("TenVattu"), _
                              rstonItem("DonVi"), _
                              Format(ConvertToDblSafe(rstonItem("luong")), Mask_2), _
                              Format(dgia, Mask_2), _
                              Format(ConvertToDblSafe(rstonItem("tien")), Mask_0), _
                              rstonItem("MaSo"), _
                              rstonItem("MaVattu"), _
                              Format(t2, Mask_2))
            GrdVT.AddItem(str, 0)
            If lk = 1 Then
                GhiDauKy(mkho, _
                    ConvertToDblSafe(rstonItem("MaSo")), _
                    ConvertToDblSafe(rstonItem("MaVattu")), _
                    ConvertToDblSafe(rstonItem("luong")), _
                    ConvertToDblSafe(rstonItem("tien")), _
                    t2)
            End If
        Next
        GrdVT.Rows = IIf(rs_ton.Rows.Count > ConvertToDblSafe(GrdVT.Tag), _
                         rs_ton.Rows.Count, _
                         ConvertToDblSafe(GrdVT.Tag))
        GrdVT.Row = 0
        tongtien()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' Thủ tục ghi số tồn kho đầu kỳ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GhiDauKy(ByRef mkho As Integer, ByRef mtk As Integer, ByRef mvt As Integer, ByRef luong As Double, ByRef tien As Double, ByRef tien2 As Double)
        Dim st2 = String.Empty, st1 = String.Empty, st3 As String = String.Empty
        Dim sql4 As New StringBuilder
        Dim sql3 As New StringBuilder
        Dim sql2 As New StringBuilder
        Dim sql As New StringBuilder
        If OutCost <> 0 And f1 = 0 Then
            tien = ConvertToDblSafe(GetSelectValue("SELECT Sum(Tien_0) AS F1, Sum(Luong_0) AS F2" & (IIf(pGiaUSD > 0, ", Sum(USDTien_0) AS F3", String.Empty)) & " FROM VTDauNam WHERE MaSoKho=" & ConvertToStrSafe(mkho) & " AND MaTaiKhoan=" & ConvertToStrSafe(mtk) & " AND MaVattu=" & ConvertToStrSafe(mvt), luong, tien2))
        End If
        Dim thang As Integer = IIf(f1 = 0, 0, Cbo.SelectedValue)
        Dim rs_ton As DataTable = ExecSQLReturnDT(String.Format("SELECT Luong_{0} AS Luong, Tien_{1} AS Tien{2} FROM {3} INNER JOIN Vattu ON {3}.MaVattu = Vattu.MaSo WHERE MaSoKho={4} AND MaTaiKhoan={5} AND MaVattu={6}", _
                                                      CThangDB2(thang), _
                                                      CThangDB2(thang), _
                                                      IIf(pGiaUSD > 0 And f1 = 0, String.Format(",USDTien_{0} AS Tien2", CThangDB2(thang)), String.Empty), _
                                                      tbl, _
                                                      mkho, _
                                                      mtk, _
                                                      mvt))
        'WSpace.BeginTransaction() ' C15()
        If rs_ton.Rows.Count = 0 Then
            st1 = CStr(luong)
            st2 = CStr(tien)
            st3 = CStr(tien2)
            For i As Integer = CThangDB2(thang) To 12
                sql.Append(String.Format(", Luong_{0}, Tien_{1}", i, ConvertToStrSafe(i)))
                sql2.Append(String.Format(",{0},{1}", st1, st2))
                sql3.Append(String.Format(", USDTien_{0}", i))
                sql4.Append(String.Format(",{0}", st3))
            Next
            ExecSQLNonQuery(String.Format("INSERT INTO {0} (MaSo,MaSoKho,MaTaiKhoan,MaVattu{1}{2}) VALUES ({3},{4},{5},{6}{7}{8})", _
                                tbl, _
                                sql, _
                                IIf(pGiaUSD > 0 And f1 = 0, sql3.ToString(), String.Empty), _
                                Lng_MaxValue("MaSo", tbl) + 1, _
                                mkho, _
                                mtk, _
                                mvt, _
                                sql2, _
                                IIf(pGiaUSD > 0 And f1 = 0, sql4.ToString(), String.Empty)))
        Else
            Dim rstonItem As DataRow = rs_ton.Rows(0)
            st1 = CStr(luong - ConvertToDblSafe(rstonItem("luong")))
            st2 = CStr(tien - ConvertToDblSafe(rstonItem("tien")))
            If pGiaUSD > 0 And f1 = 0 Then
                st3 = CStr(tien2 - ConvertToDblSafe(rstonItem("tien2")))
            End If
            sql = New StringBuilder(String.Format("Luong_{0}  = {1}, Tien_{2}  = {3}", _
                                        CThangDB2(thang), _
                                        luong, _
                                        ConvertToStrSafe(CThangDB2(thang)), _
                                        tien))
            If pGiaUSD > 0 And f1 = 0 Then
                sql.AppendFormat(", USDTien_{0}={1}", CThangDB2(thang), CStr(tien2))
            End If
            For i As Integer = CThangDB2(thang) + 1 To 12
                sql2 = New StringBuilder(ConvertToStrSafe(i))
                sql.AppendFormat(", Luong_{0} = Luong_{0} + ({1}), Tien_{0} = Tien_{0} + {2}", _
                               sql2, _
                               st1, _
                               st2)
                If pGiaUSD > 0 And f1 = 0 Then
                    sql.AppendFormat(", USDTien_{0}=USDTien_{0} + {1}", sql2, st3)
                End If
            Next
            ExecSQLNonQuery(String.Format("UPDATE {0} SET {1} WHERE MaSoKho={2} AND MaTaiKhoan={3} AND MaVattu={4}", _
                                tbl, _
                                sql, _
                                ConvertToStrSafe(mkho), _
                                ConvertToStrSafe(mtk), _
                                ConvertToStrSafe(mvt)))
        End If
        'WSpace.CommitTransaction()' C15()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub tongtien()
        Dim tb As String = IIf(f1 = 0, (IIf(OutCost <> 0, "VTDauNam", "TonKho")), "KiemKe")
        Dim thang As Integer = IIf(f1 = 0, 0, Cbo.SelectedValue)
        Dim T As Double = ConvertToDblSafe(GetSelectValue("SELECT Sum(Tien_" & CThangDB2(thang) & ") As F1 FROM " & tb & " WHERE MaSoKho = " & ConvertToStrSafe(CboKho.SelectedValue)))
        LbTien(0).Text = Format(T, Mask_0)
        If pGiaUSD > 0 Then
            T = ConvertToDblSafe(GetSelectValue("SELECT Sum(USDTien_" & CThangDB2(thang) & ") As F1 FROM TonKho WHERE MaSoKho = " & ConvertToStrSafe(CboKho.SelectedValue)))
            LbTien(1).Text = Format(T, Mask_2)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="mkho"></param>
    ''' <remarks></remarks>
    Private Sub XuLyChenhLech(ByRef thang As Integer, ByRef mkho As Integer)
        Dim luong, tien As Double
        Dim i As Integer
        Dim tempLoadForm As FrmChungtu = FrmChungtu
        FrmChungtu.initOption = 2
        SetListIndex(FrmChungtu.CboNguon(1), mkho)
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaTaiKhoan, MaVattu, HethongTK.SoHieu AS SHTK, Vattu.SoHieu AS SHVT, Luong_{0} AS Luong, Tien_{1} AS Tien FROM  (TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo) INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo WHERE MaSoKho={2} ORDER BY HethongTK.SoHieu DESC, Vattu.SoHieu DESC", CThangDB2(thang), ConvertToStrSafe(CThangDB2(thang)), mkho))
        For Each rsItem As DataRow In rs.Rows
            luong = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Luong_{0} AS F1, Tien_{1} AS F2 FROM KiemKe WHERE MaSoKho={2} AND MaTaiKhoan={3} AND MaVattu={4}", _
                                                        CThangDB2(thang), _
                                                        ConvertToStrSafe(CThangDB2(thang)), _
                                                        ConvertToStrSafe(mkho), _
                                                        rsItem("MaTaiKhoan"), _
                                                        rsItem("MaVattu")), tien))
            If luong <> ConvertToDblSafe(rsItem("luong")) Or tien <> ConvertToDblSafe(rsItem("tien")) Then
                FrmChungtu.txtchungtu(0).Text = ConvertToStrSafe(rsItem("shtk"))
                FrmChungtu.txtchungtu(2).Text = ConvertToStrSafe(rsItem("shvt"))
                FrmChungtu.txtchungtu(3).Text = Format(ConvertToDblSafe(rsItem("luong")) - luong, Mask_2)
                FrmChungtu.txtchungtu(5).Text = ""
                FrmChungtu.txtchungtu(6).Text = Format(ConvertToDblSafe(rsItem("tien")) - tien, Mask_2)
                FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())
                i += 1
            End If
        Next
        If i > 0 Then
            pFunction = 10
            FrmChungtu.ShowDialog()
        End If
    End Sub
End Class
