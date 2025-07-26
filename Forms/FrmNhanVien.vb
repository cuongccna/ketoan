Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmNhanVien

    Dim ThemMoi As Integer ' =1 neu them moi, -1 neu sua cu
    Private _onv As ClsNhanVien = Nothing
    Property onv() As ClsNhanVien
        Get
            If _onv Is Nothing Then
                _onv = New ClsNhanVien()
            End If
            Return _onv
        End Get
        Set(ByVal Value As ClsNhanVien)
            _onv = Value
        End Set
    End Property ' vat tu duoc tham chieu
    Dim doiloai As Integer ' =1 neu co thay doi loai vat tu dang sua doi
    Dim MaDaTim As Integer
    Dim Ngay As Date
    '======================================================================================
    ' Liet ke cac vat tu trong loai vat tu duoc chon
    '======================================================================================
    Private Sub CboLoai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLoai.SelectedIndexChanged
        If ThemMoi <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            Dim listCount As Integer = Int_RecsetToListbox("SELECT MaSo As F2, SoHieu + ' - ' + Ten As F1 FROM NhanVien WHERE MaPhanLoai=" & CboLoai.SelectedValue & " ORDER BY SoHieu", LstVt)
            If listCount = 0 Then
                ResetChitiet()
            End If
            ThemMoi = 0
            doiloai = 0
            Me.Cursor = Cursors.Default
        Else
            doiloai = 1
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click, _Command_2.Click, _Command_3.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim LstVt_NewIndex As Integer = -1
        Dim vt As New ClsNhanVien
        Dim i As Integer
        If (User_Right = 2) And (Index < 3) Then
            HienThongBao("Không có quyền truy cập!", 1)
            GoTo XongVT
        End If
        Me.Cursor = Cursors.WaitCursor
        If Index < 3 Then
            If CboLoai.SelectedIndex < 0 Then
                ErrMsg(er_PhanLoai)
                GoTo XongVT
            End If
        End If
        Select Case Index
            Case 0
                txtVT(0).Text = SoHieuVTMoi(CboLoai.SelectedValue, 3)
                For i = 1 To 8
                    txtVT(i).Text = "..."
                Next
                txtVT(0).Focus()
                ThemMoi = 1
                Khoaquyen()
            Case 1
                Select Case ThemMoi
                    Case 1
                        If Not KiemTraSoLieu() Then GoTo XongVT
                        If onv.GhiNV() = 0 Then
                            LstVt_NewIndex = LstVt.Items.Add(onv.SoHieu & " - " & onv.Ten)
                            VB6.SetItemData(LstVt, LstVt_NewIndex, onv.MaSo)
                            If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = LstVt_NewIndex
                        Else
                            ErrMsg(er_SoHieu)
                            vt.InitNVSoHieu(txtVT(0).Text)
                            If vt.MaPhanLoai = CboLoai.SelectedValue Then
                                SetListIndex(LstVt, vt.MaSo)
                            End If
                        End If
                        ThemMoi = 0
                    Case 0
                        If LstVt.SelectedIndex < 0 Or Not KiemTraSoLieu() Then GoTo XongVT
                        If onv.SuaNV() = 0 Then
                            If doiloai = 1 Then
                                CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                                doiloai = 0
                            Else
                                'VB6.SetItemString(LstVt, LstVt.SelectedIndex, String.Format("{0} - {1}", onv.SoHieu, onv.Ten))
                                Dim currentCate As ValueDescriptionPair = CType(LstVt.SelectedItem, ValueDescriptionPair)
                                Dim newItemCate As New ValueDescriptionPair(currentCate.Value, String.Format("{0} - {1}", onv.SoHieu, onv.Ten))
                                LstVt.Items(LstVt.SelectedIndex) = newItemCate
                            End If
                        Else
                            vt.InitNVSoHieu(txtVT(0).Text)
                            ErrMsg(er_SoHieu)
                            If vt.MaPhanLoai = CboLoai.SelectedValue Then SetListIndex(LstVt, vt.MaSo)
                        End If
                        ThemMoi = 0
                End Select
                LstVt.Focus()
            Case 2
                i = LstVt.SelectedIndex
                If i < 0 Then GoTo XongVT
                If onv.XoaNV() = 0 Then
                    LstVt.Items.RemoveAt(ConvertToDblSafe(i))
                    If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = i - 1
                Else
                    ErrMsg(er_CoPS1)
                End If
                LstVt.Focus()
            Case 3
                Hide()
        End Select
XongVT:
        vt = Nothing
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If ConvertToDblSafe(Me.Tag) < 0 Then
            SetListIndex(CboLoai, -ConvertToDblSafe(Me.Tag))
            Me.Tag = "0"
        End If
        If ThemMoi = 0 And ConvertToDblSafe(Me.Tag) = 1 Then LstVt.Focus()
        Khoaquyen()
    End Sub
    '======================================================================================
    ' Xu ly cac phim nong
    '======================================================================================
    Private Sub FrmNhanVien_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.T
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Hide()
    End Sub
    '======================================================================================
    ' Khoi tao form
    '======================================================================================
    Private Sub FrmNhanVien_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ThemMoi = 0
            doiloai = 0
            Text = SetFormTitle(Text)
            Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + TenPhanLoai As F1, SoHieu FROM PhanLoaiNhanVien WHERE PLCon=0 ORDER BY SoHieu", CboLoai)
            InitDateVars(MedNgay, Ngay)
            Me.Text = Ngonngu("Danh sách Nhân viên bán hàng", "Saler list")
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
    Private Sub FrmNhanVien_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        onv = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    '======================================================================================
    ' Khoi tao vat tu duoc chon
    '======================================================================================
    Private Sub LstVt_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.SelectedIndexChanged
        Try
            Dim currentCate As ValueDescriptionPair
            Dim index As Integer = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
            currentCate = CType(LstVt.Items(index), ValueDescriptionPair)
            onv.InitNVMaSo(currentCate.Value)
            ShowChitiet(onv)
        Catch

        End Try
    End Sub
    '======================================================================================
    ' Thu tuc reset thong tin chi tiet
    '======================================================================================
    Private Sub ResetChitiet()
        txtVT(0).Text = "..."
        txtVT(1).Text = "..."
        txtVT(2).Text = "..."
        txtVT(3).Text = "..."
        txtVT(4).Text = "..."
        txtVT(5).Text = "..."
        txtVT(6).Text = "..."
        txtVT(7).Text = "..."
        txtVT(8).Text = "..."
        Ngay = DateTime.Today
        MedNgay.Text = Format(Ngay, Mask_D)
    End Sub
    '======================================================================================
    ' Thu tuc hien thong tin chi tiet
    '======================================================================================
    Private Sub ShowChitiet(ByRef otk As ClsNhanVien)
        txtVT(0).Text = onv.SoHieu
        txtVT(1).Text = onv.Ten
        txtVT(2).Text = onv.DiaChi
        txtVT(3).Text = onv.CMND
        txtVT(4).Text = onv.Tel1
        txtVT(5).Text = onv.Tel2
        txtVT(6).Text = onv.email
        txtVT(7).Text = onv.taikhoan
        txtVT(8).Text = onv.GhiChu
        Ngay = onv.NgaySinh
        MedNgay.Text = Format(Ngay, Mask_D)
    End Sub
    '======================================================================================
    ' Thu tuc chon vat tu
    ' sh: so hieu vat tu can chon
    ' Tra ve so hieu vat tu duoc chon
    '======================================================================================
    Public Function ChonNV(ByRef sh As String) As String
        Dim mpl As Integer
        Dim shtk As String = String.Empty
        Dim pos, j, i, Length As Integer
        If sh.Length > 0 Then
            shtk = "SELECT DISTINCT TOP 1 MaPhanLoai AS F1 FROM NhanVien, SoHieu WHERE SoHieu LIKE '" & sh & "%' ORDER BY SoHieu"
            mpl = ConvertToDblSafe(GetSelectValue(shtk))
            If mpl > 0 And CboLoai.SelectedIndex >= 0 Then
                If CboLoai.SelectedValue <> mpl Then SetListIndex(CboLoai, mpl)
            End If
            i = 0
            j = LstVt.Items.Count - 1
            pos = 0
            Length = sh.Length
            Do While i <= j - 1
                pos = IIf(0.5 + (i + j) / 2 > 0, Math.Floor(0.5 + (i + j) / 2), Math.Ceiling(0.5 + (i + j) / 2))
                shtk = Strings.Left(VB6.GetItemString(LstVt, pos), Length)
                If sh = shtk Then
                    i = pos - 1
                    Do While (sh = Strings.Left(VB6.GetItemString(LstVt, i), Length)) And (i > 0)
                        i -= 1
                    Loop
                    pos = i + 1
                    Exit Do
                End If
                If sh > shtk Then
                    i = pos
                Else
                    If j = 1 Then
                        pos = 0
                        Exit Do
                    Else
                        If j = pos Then Exit Do
                        j = pos
                    End If
                End If
            Loop
            If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = pos
        End If
        Me.Tag = "1"
        Try
            Me.ShowDialog()
        Catch
        End Try
        If onv.MaSo > 0 Then
            Return onv.SoHieu
        Else
            Return ""
        End If
    End Function
    Private Sub LstVt_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.DoubleClick
        If ConvertToDblSafe(Me.Tag) = 1 Then Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles LstVt.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then LstVt_DoubleClick(LstVt, New EventArgs())
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    '======================================================================================
    ' Thu tuc kiem tra va dua so lieu vao object
    '======================================================================================
    Private Function KiemTraSoLieu() As Boolean
        Dim result As Boolean = False
        With onv
            If ThemMoi = 1 Then .MaSo = 0
            .MaPhanLoai = CboLoai.SelectedValue
            .SoHieu = txtVT(0).Text
            .Ten = txtVT(1).Text
            .DiaChi = txtVT(2).Text
            .NgaySinh = Ngay
            .CMND = txtVT(3).Text
            .Tel1 = txtVT(4).Text
            .Tel2 = txtVT(5).Text
            .email = txtVT(6).Text
            .taikhoan = txtVT(7).Text
            .GhiChu = txtVT(8).Text
            If .CMND <> "..." And ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM NhanVien WHERE CMND='" & .CMND & "' AND MaSo<>" & ConvertToStrSafe(.MaSo))) > 0 Then
                If MessageBox.Show(Ngonngu("Số CMND đã có, cho phép nhập?", "ID card already exists, continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then Return result
            End If
        End With
        Return True
    End Function
    Private Sub LstVt_MouseDown(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles LstVt.MouseDown
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim X As Single = (eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        Dim sh As String = String.Empty
        Dim m As Integer
        If eventArgs.Button = MouseButtons.Right And LstVt.SelectedIndex >= 0 And ThemMoi = 0 Then 'If Button = 2 And LstVt.SelectedIndex >= 0 And ThemMoi = 0 Then
            sh = FrmGetStr.GetString(Ngonngu("Chuyển ", "Transfer ") & (onv.SoHieu & " - " & onv.Ten) & Ngonngu(" sang phân loại có số hiệu:", " to classification number"), My.Application.Info.ProductName)
            If sh.Length > 0 Then
                m = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM PhanLoaiNhanVien WHERE PLCon=0 AND SoHieu='" & sh & "'"))
                If m > 0 And m <> onv.MaPhanLoai Then
                    ExecSQLNonQuery("UPDATE NhanVien SET MaPhanLoai=" & m & " WHERE MaSo = " & ConvertToStrSafe(onv.MaSo))
                    CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                End If
            End If
        End If
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
            MedNgay.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub SSCmdF_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles SSCmdF.Click
        If Strings.Len(txtF.Text) = 0 Then
            txtF.Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = "SELECT DISTINCT Top 1 SoHieu AS F1 FROM NhanVien WHERE MaSo>" & MaDaTim
        If SSOpt(0).Checked Then sql = sql & " AND SoHieu LIKE '" & txtF.Text & "%'"
        If SSOpt(1).Checked Then sql = sql & " AND Ten like '%" & txtF.Text & "%'"
        If SSOpt(2).Checked Then sql = sql & " AND CMND LIKE '" & txtF.Text & "%'"
        sql = ConvertToStrSafe(GetSelectValue(sql))
        If sql <> "0" Then
            ChonNV(sql)
            MaDaTim = onv.MaSo
        Else
            MaDaTim = 0
        End If
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtF_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtF.Enter
        txtF.SelectAll()
        MaDaTim = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_0.Enter, _txtVT_1.Enter, _txtVT_3.Enter, _txtVT_2.Enter, _txtVT_4.Enter, _txtVT_5.Enter, _txtVT_6.Enter, _txtVT_7.Enter, _txtVT_8.Enter
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        txtVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtVT_0.KeyPress, _txtVT_1.KeyPress, _txtVT_3.KeyPress, _txtVT_2.KeyPress, _txtVT_4.KeyPress, _txtVT_5.KeyPress, _txtVT_6.KeyPress, _txtVT_7.KeyPress, _txtVT_8.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        Select Case Index
            Case 0 : If KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
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
    Private Sub txtVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_0.Leave, _txtVT_1.Leave, _txtVT_3.Leave, _txtVT_2.Leave, _txtVT_4.Leave, _txtVT_5.Leave, _txtVT_6.Leave, _txtVT_7.Leave, _txtVT_8.Leave
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        If Strings.Len(txtVT(Index).Text) = 0 Then txtVT(Index).Text = "..."
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
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
End Class
