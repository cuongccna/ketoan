Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Globalization
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmLS
    Dim ThemMoi As Integer
    Dim Ngay As Date
    Private _taikhoan As ClsTaikhoan = Nothing

    Dim f1 As Integer
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
    Private _ckh As clsKhachHang = Nothing
    Property ckh() As clsKhachHang
        Get
            If _ckh Is Nothing Then
                _ckh = New clsKhachHang()
            End If
            Return _ckh
        End Get
        Set(ByVal Value As clsKhachHang)
            _ckh = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboNT_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboNT.SelectedIndexChanged
        If taikhoan.maso = 0 Or CboNT.SelectedIndex < 0 Then Exit Sub
        Dim mnt As Integer = Nothing
        If CboNT.Items.Count > 0 Then
            mnt = CboNT.SelectedIndex
        End If

        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM HethongTK WHERE SoHieu='" & taikhoan.sohieu & "' AND " & (IIf(mnt > 0, "MaNT=" & mnt, "MaNT<=0")))))
        LietKeNgte()
    End Sub
    ''' <summary>
    ''' Thêm, Ghi, Xóa nguyên tệ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                txtNhap.Text = "0"
                MedNgay.Focus()
                ThemMoi = 1
                Khoaquyen()
            Case 1
                If taikhoan.maso = 0 Or taikhoan.tkcon > 0 Then
                    txtShTk.Focus()
                    Exit Sub
                End If
                If (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) And ckh.MaSo = 0 Then
                    txtshkh.Focus()
                    Exit Sub
                End If
                Select Case ThemMoi
                    Case 0
                        GrdNT.Col = 2
                        'Dim dbNumericTemp As Double
                        If Not IsNumeric(GrdNT.CtlText) Then Exit Sub
                        If ExecSQLNonQuery(String.Format("UPDATE LaiSuat SET Ngay='{0}',LS={1} WHERE MaKH={2} AND MaSo={3}", _
                                               Format(CDate(Ngay), Mask_DB), _
                                               CStr(ConvertToDblSafe(txtNhap.Text)), _
                                               ConvertToStrSafe(ckh.MaSo), _
                                               GrdNT.CtlText)) <> 0 Then Exit Sub
                        GrdNT.Col = 0
                        GrdNT.CtlText = MedNgay.Text
                        GrdNT.Col = 1
                        GrdNT.CtlText = txtNhap.Text
                    Case 1
                        If ExecSQLNonQuery(String.Format("INSERT INTO LaiSuat (Maso, MaTK,Ngay,LS,MaKH) VALUES ({0},{1},'{2}',{3},{4})", _
                                               Lng_MaxValue("MaSo", "LaiSuat") + 1, _
                                               taikhoan.maso, _
                                               Format(CDate(Ngay), Mask_DB), _
                                               CStr(ConvertToDblSafe(txtNhap.Text)), _
                                               ConvertToStrSafe(ckh.MaSo))) <> 0 Then Exit Sub
                        GrdNT.AddItem(String.Format("{0}{1}{2}{1}{3}", _
                                          MedNgay.Text, _
                                          Chr(9), _
                                          txtNhap.Text, _
                                          ConvertToStrSafe(Lng_MaxValue("MaSo", "LaiSuat"))), InsertGridRow(GrdNT, 0, MedNgay.Text))
                        ThemMoi = 0
                        GrdNT.Row = ConvertToDblSafe(GrdNT.Rows - 1)
                        GrdNT.Col = 0

                        If GrdNT.CtlText = "" Then GrdNT.RemoveItem(GrdNT.Row)
                        GrdNT.Row = 0

                        KeTaiKhoan()
                End Select
                KeTaiKhoan()
            Case 2
                GrdNT.Col = 2
                Dim dbNumericTemp2 As Double
                If Not Double.TryParse(GrdNT.CtlText, NumberStyles.Number, CultureInfo.CurrentCulture.NumberFormat, dbNumericTemp2) Then Exit Sub
                If ExecSQLNonQuery(String.Format("DELETE FROM LaiSuat WHERE MaSo={0}", GrdNT.CtlText)) <> 0 Then Exit Sub
                GrdNT.RemoveItem(GrdNT.Row)
                If GrdNT.Rows < ConvertToDblSafe(GrdNT.Tag) Then GrdNT.Rows = ConvertToDblSafe(GrdNT.Tag)
                KeTaiKhoan()
            Case 3
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' Xử lý phím nóng
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmLS_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If Shift = 4 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' Khởi tạo cửa sổ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmLS_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdNT, 0, 830, 2)
            ColumnSetUp(GrdNT, 1, 1390, 2)
            ColumnSetUp(GrdNT, 2, 1, 2)
            InitDateVars(MedNgay, Ngay)
            Text = SetFormTitle(Text)
            KeTaiKhoan()
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
    Private Sub FrmLS_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        taikhoan = Nothing
        ckh = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNT.Click
        'Dim i As Integer
        ' SendKeys.SendWait("{Home}")
        SetGridIndex(GrdNT, GrdNT.Row)
        With GrdNT
            .Col = 2
            If Not IsNumeric(.CtlText) Then Exit Sub
            .Col = 0
            MedNgay.Text = .CtlText
            Ngay = CDate(.CtlText)
            .Col = 1
            txtNhap.Text = .CtlText
            ThemMoi = 0
            MedNgay.Focus()
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdNT.KeyPress
        'SendKeys.SendWait("{Home}")
        SetGridIndex(GrdNT, GrdNT.Row)
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Lst_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Lst.SelectedIndexChanged
        'If f1 = 1 Or Lst.SelectedIndex < 0 Or (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) Then Exit Sub
        'f1 = 1
        'Dim currentCate As ValueDescriptionPair = CType(Lst.SelectedItem, ValueDescriptionPair)

        'taikhoan.InitTaikhoanMaSo(currentCate.Value)
        'txtShTk.Text = taikhoan.sohieu
        'txtShTk_Leave(txtShTk, New EventArgs())
        'f1 = 0
        'txtShTk.Focus()
        Dim str As String = String.Format("select SoHieu,Ngay,ls from LaiSuat ls inner join HeThongTK httk on ls.MaTK=httk.MaSo where ls.maso={0}", Lst.SelectedIndex + 1)
        Dim rs As DataTable = ExecSQLReturnDT(str)
        Dim rsrow As DataRow = rs.Rows(0)
        txtShTk.Text = rsrow("sohieu")
        ClearGrid(GrdNT, ConvertToDblSafe(GrdNT.Tag))
        With GrdNT
            Dim SQL As String = String.Format("{0}{1}{2}", _
                     Format(CDate(rsrow("ngay").ToString()), "dd/MM/yy"), _
                     Chr(9), _
                     rsrow("LS"))
            .AddItem(SQL)
        End With
        txtNhap.Text = rsrow("LS")
        MedNgay.Text = rsrow("NGAY")
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtNhap.Enter
        txtNhap.SelectAll()
    End Sub
    ''' <summary>
    ''' Hiển thị danh sách nguyên tệ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeNgte()
        ClearGrid(GrdNT, ConvertToDblSafe(GrdNT.Tag))
        Dim rs_ngte As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM LaiSuat WHERE MaTK={0} AND MaKH={1} ORDER BY Ngay DESC", _
                                                       taikhoan.maso, _
                                                       ConvertToStrSafe(ckh.MaSo)))
        Dim rs_ngteIndex As Integer = 0
        Do While rs_ngteIndex < rs_ngte.Rows.Count
            Dim rs_ngteItem As DataRow = rs_ngte.Rows(rs_ngteIndex)
            rs_ngteIndex += 1 ' C15 Rs LOOP CONTROL
            GrdNT.AddItem(String.Format("{0}{1}{2}{1}{3}", _
                              Format(rs_ngteItem("Ngay"), Mask_D), _
                              Chr(9), _
                              Format(rs_ngteItem("ls"), Mask_2), _
                              rs_ngteItem("MaSo")), 0)
            'rs_ngte.MoveNext()
        Loop
        GrdNT.Rows = IIf(rs_ngte.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_ngte.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        GrdNT.Col = 0
        ''rs_ngte.Close()
        rs_ngte = Nothing
        GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtNhap.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        KeyProcess(txtNhap, KeyAscii)
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
    Private Sub txtNhap_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtNhap.Leave
        txtNhap.Text = Format(txtNhap.Text, Mask_2)
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
        Else
            MessageBox.Show(Ngonngu("Nhập sai ngày !", "Data false !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MedNgay.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtShTk.Enter
        txtShTk.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtShTk.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then CmdTK_ClickEvent(CmdTK, New EventArgs())
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
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtShTk.Leave
        taikhoan.InitTaikhoanSohieu(txtShTk.Text)
        LbTenTk.Text = taikhoan.ten
        Int_RecsetToCbo(String.Format("SELECT HethongTK.MaNT As F2,NguyenTe.KyHieu As F1 FROM HethongTK INNER JOIN NguyenTe ON HethongTK.MaNT = NguyenTe.MaSo WHERE HethongTK.SoHieu = '{0}' ORDER BY NguyenTe.KyHieu", taikhoan.sohieu), CboNT)
        If CboNT.Items.Count > 0 Then
            CboNT.Enabled = True
            CboNT.Items.Add("VND", 0)
        Else
            CboNT.Enabled = False
        End If
        txtshkh.Enabled = (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID)
        cmdkh.Enabled = (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID)
        If Not (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) Then ckh.InitKhachHangMaSo(0)
        KeTaiKhoan()
        LietKeNgte()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CmdTK_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CmdTK.Click
        Me.Cursor = Cursors.WaitCursor
        txtShTk.Text = FrmTaikhoan.ChonTk(txtShTk.Text)
        Me.Cursor = Cursors.Default
        txtShTk.Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub KeTaiKhoan()
        Dim Lst_NewIndex2 As Integer = -1
        Dim rs As DataTable
        Dim ls As Double
        Dim sh As String = String.Empty
        Lst.Items.Clear()
        If taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID Then
            rs = ExecSQLReturnDT("SELECT HethongTK.MaSo,KhachHang.MaSo AS MaKH,KhachHang.SoHieu,KhachHang.Ten FROM (HethongTK INNER JOIN LaiSuat ON HethongTK.MaSo=LaiSuat.MaTK) INNER JOIN KhachHang ON LaiSuat.MaKH=KhachHang.MaSo GROUP BY HethongTK.MaSo,KhachHang.MaSo,KhachHang.SoHieu,KhachHang.Ten ORDER BY KhachHang.SoHieu")
            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                ls = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 LS AS F1 FROM LaiSuat WHERE MaTK={0} AND MaKH={1} ORDER BY Ngay DESC", _
                                                         rsItem("MaSo"), _
                                                         rsItem("makh"))))
                Lst.Items.Add(String.Format("{0} - {1} - LS: {2}", _
                                  rsItem("SoHieu"), _
                                  rsItem("ten"), _
                                  Format(ls, Mask_2)))
                ''rs.MoveNext()
            Loop
        Else
            rs = ExecSQLReturnDT("SELECT HethongTK.MaSo,SoHieu,Ten,KyHieu FROM (HethongTK LEFT JOIN NguyenTe ON HethongTK.MaNT=NguyenTe.MaSo) INNER JOIN LaiSuat ON HethongTK.MaSo=LaiSuat.MaTK GROUP BY HethongTK.MaSo,SoHieu,Ten,KyHieu ORDER BY SoHieu, KyHieu")
            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                ls = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 LS AS F1 FROM LaiSuat WHERE MaTK={0} ORDER BY Ngay DESC", rsItem("MaSo"))))
                sh = IIf(IsDBNull(rsItem("KyHieu")), "VND", rsItem("KyHieu"))
                Lst_NewIndex2 = Lst.Items.Add(String.Format("{0} - {1} - LS: {2}", _
                                                  rsItem("SoHieu"), _
                                                  sh, _
                                                  Format(ls, Mask_2)))
                VB6.SetItemData(Lst, Lst_NewIndex2, rsItem("MaSo"))
                ''rs.MoveNext()
            Loop
        End If
        ''rs.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtshkh.Enter
        txtshkh.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtshkh.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then cmdkh_ClickEvent(cmdkh, New EventArgs())
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
    Private Sub txtshkh_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtshkh.Leave
        ckh.InitKhachHangSohieu(txtshkh.Text)
        lbkh.Text = ckh.Ten
        LietKeNgte()
        HienThongBao(Me.Text, 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdkh_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdkh.Click
        Me.Cursor = Cursors.WaitCursor
        txtshkh.Text = FrmKhachHang.ChonKhachHang(txtshkh.Text)
        Me.Cursor = Cursors.Default
        txtshkh.Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
End Class
