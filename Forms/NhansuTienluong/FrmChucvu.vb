Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmChucvu
    Dim ThemMoi As Integer ' =1 neu them moi, -1 neu sua cu
    Private _onv As ClsChucvu = Nothing
    Property onv() As ClsChucvu
        Get
            If _onv Is Nothing Then
                _onv = New ClsChucvu()
            End If
            Return _onv
        End Get
        Set(ByVal Value As ClsChucvu)
            _onv = Value
        End Set
    End Property ' vat tu duoc tham chieu
    Dim doiloai As Integer ' =1 neu co thay doi loai vat tu dang sua doi
    Dim MaDaTim As Integer
    Dim TenBang As String = String.Empty
    '======================================================================================
    ' Liet ke cac vat tu trong loai vat tu duoc chon
    '======================================================================================
    Private Sub ChkLoai_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _ChkLoai_4.CheckStateChanged, _ChkLoai_3.CheckStateChanged, _ChkLoai_2.CheckStateChanged, _ChkLoai_1.CheckStateChanged
        Dim Index As Integer = Array.IndexOf(ChkLoai, eventSender)
        Frame2(Index).Visible = ChkLoai(Index).CheckState
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim LstVt_NewIndex As Integer = -1
        Dim vt As New ClsChucvu
        Dim i As Integer
        If (User_Right = 2) And (Index < 3) Then
            HienThongBao("Không có quyền truy cập!", 1)
            GoTo XongVT
        End If
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0
                txtVT(0).Text = SoHieuVTMoi(0, 5)
                txtVT(1).Text = "..."
                For i = 2 To 21
                    txtVT(i).Text = "0"
                Next
                txtVT(0).Focus()
                ThemMoi = 1
                Khoaquyen()
            Case 1
                Select Case ThemMoi
                    Case 1
                        If Not KiemTraSoLieu() Then GoTo XongVT
                        If onv.GhiNV(TenBang) = 0 Then
                            'van.nguyen
                            'LstVt_NewIndex = LstVt.Items.Add(onv.sohieu & " - " & onv.ten)
                            'VB6.SetItemData(LstVt, LstVt_NewIndex, onv.MaSo)
                            Dim temp As String = String.Format("{0} - {1}", onv.sohieu, onv.ten)
                            Dim newItemCate As New ValueDescriptionPair(onv.MaSo, temp)

                            LstVt_NewIndex = LstVt.Items.Add(newItemCate)
                            If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = LstVt_NewIndex

                        Else
                            ErrMsg(er_SoHieu)
                            vt.InitNVSoHieu(TenBang, txtVT(0).Text)
                        End If
                        ThemMoi = 0
                    Case 0
                        If LstVt.SelectedIndex < 0 Or Not KiemTraSoLieu() Then GoTo XongVT
                        If onv.SuaNV(TenBang) = 0 Then
                            If doiloai = 1 Then
                                Hienthiluoi()
                                doiloai = 0
                            Else
                                ' VB6.SetItemString(LstVt, LstVt.SelectedIndex, String.Format("{0} - {1}", onv.sohieu, onv.ten))
                                Dim temp As String = String.Format("{0} - {1}", onv.sohieu, onv.ten)
                                Dim newItemCate As New ValueDescriptionPair(onv.MaSo, temp)

                                LstVt.Items(LstVt.SelectedIndex) = newItemCate
                            End If
                        Else
                            vt.InitNVSoHieu(TenBang, txtVT(0).Text)
                            ErrMsg(er_SoHieu)
                        End If
                        ThemMoi = 0
                End Select
                LstVt.Focus()
            Case 2
                i = LstVt.SelectedIndex
                If i < 0 Then GoTo XongVT
                If onv.XoaNV(TenBang) = 0 Then
                    LstVt.Items.RemoveAt(ConvertToDblSafe(i))
                    If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = i - 1
                Else
                    ErrMsg(er_CoPS1)
                End If
                LstVt.Focus()
            Case 3
                Me.Close() : Exit Sub
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
        If ConvertToDblSafe(Me.Tag) < 1 Then
            Me.Tag = "1"
        End If
        If ThemMoi = 0 And ConvertToDblSafe(Me.Tag) = 1 Then
            LstVt.Focus()
        End If
    End Sub
    '======================================================================================
    ' Xu ly cac phim nong
    '======================================================================================
    Private Sub FrmChucvu_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
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
                    ' Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(3), New EventArgs())
    End Sub
    '======================================================================================
    ' Khoi tao form
    '======================================================================================
    Private Sub FrmChucvu_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        'set icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        ' Init form 
        Call FormInit()

        ThemMoi = 0
        doiloai = 0
        Me.Text = Ngonngu("Danh sách chức vụ trong công ty", "List of position")
        TenBang = "Chucvu"
        Hienthiluoi()
        Text = SetFormTitle(Text)
        SetFont(Me)
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChucvu_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        onv = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    '======================================================================================
    ' Khoi tao vat tu duoc chon
    '======================================================================================
    Private Sub LstVt_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.SelectedIndexChanged
        Dim currentCate As ValueDescriptionPair
        Dim index As Integer = 0
        If LstVt.Items.Count > 0 Then
            index = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
            currentCate = CType(LstVt.Items(index), ValueDescriptionPair)
            onv.InitNVMaSo(TenBang, currentCate.Value)
            ShowChitiet(onv)
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc hien thong tin chi tiet
    ''' </summary>
    ''' <param name="otk"></param>
    ''' <remarks></remarks>
    Private Sub ShowChitiet(ByRef otk As ClsChucvu)
        txtVT(0).Text = onv.sohieu
        txtVT(1).Text = onv.ten
        For i As Integer = 1 To 4
            ChkLoai(i).CheckState = CheckState.Unchecked
            Frame2(i).Visible = False
        Next
        If onv.HSB_I <> 0 Or onv.HSB_II <> 0 Or onv.HSB_III <> 0 Or onv.HSB_IV <> 0 Or onv.HSB_V <> 0 Then
            ChkLoai(1).CheckState = CheckState.Checked
            Frame2(1).Visible = True
        End If
        If onv.MLB_I <> 0 Or onv.MLB_II <> 0 Or onv.MLB_III <> 0 Or onv.MLB_IV <> 0 Or onv.MLB_V <> 0 Then
            ChkLoai(2).CheckState = CheckState.Checked
            Frame2(2).Visible = True
        End If
        If onv.TVB_I <> 0 Or onv.TVB_II <> 0 Or onv.TVB_III <> 0 Or onv.TVB_IV <> 0 Or onv.TVB_V <> 0 Then
            ChkLoai(3).CheckState = CheckState.Checked
            Frame2(3).Visible = True
        End If
        If onv.LNB_I <> 0 Or onv.LNB_II <> 0 Or onv.LNB_III <> 0 Or onv.LNB_IV <> 0 Or onv.LNB_V <> 0 Then
            ChkLoai(4).CheckState = CheckState.Checked
            Frame2(4).Visible = True
        End If
        txtVT(2).Text = Format(onv.HSB_I, Mask_2)
        txtVT(3).Text = Format(onv.HSB_II, Mask_2)
        txtVT(4).Text = Format(onv.HSB_III, Mask_2)
        txtVT(5).Text = Format(onv.HSB_IV, Mask_2)
        txtVT(6).Text = Format(onv.HSB_V, Mask_2)
        txtVT(2 + 5).Text = Format(onv.MLB_I, Mask_0)
        txtVT(3 + 5).Text = Format(onv.MLB_II, Mask_0)
        txtVT(4 + 5).Text = Format(onv.MLB_III, Mask_0)
        txtVT(5 + 5).Text = Format(onv.MLB_IV, Mask_0)
        txtVT(6 + 5).Text = Format(onv.MLB_V, Mask_0)
        txtVT(2 + 10).Text = Format(onv.TVB_I, Mask_0)
        txtVT(3 + 10).Text = Format(onv.TVB_II, Mask_0)
        txtVT(4 + 10).Text = Format(onv.TVB_III, Mask_0)
        txtVT(5 + 10).Text = Format(onv.TVB_IV, Mask_0)
        txtVT(6 + 10).Text = Format(onv.TVB_V, Mask_0)
        txtVT(2 + 15).Text = Format(onv.LNB_I, Mask_0)
        txtVT(3 + 15).Text = Format(onv.LNB_II, Mask_0)
        txtVT(4 + 15).Text = Format(onv.LNB_III, Mask_0)
        txtVT(5 + 15).Text = Format(onv.LNB_IV, Mask_0)
        txtVT(6 + 15).Text = Format(onv.LNB_V, Mask_0)
        '    If ChkLoai(1).Value Then
        '        txtVT(2).Text = Format(onv.HSB_I, Mask_2)
        '        txtVT(3).Text = Format(onv.HSB_II, Mask_2)
        '        txtVT(4).Text = Format(onv.HSB_III, Mask_2)
        '        txtVT(5).Text = Format(onv.HSB_IV, Mask_2)
        '        txtVT(6).Text = Format(onv.HSB_V, Mask_2)
        '    Else
        '        txtVT(2).Text = Format(onv.MLB_I, Mask_0)
        '        txtVT(3).Text = Format(onv.MLB_II, Mask_0)
        '        txtVT(4).Text = Format(onv.MLB_III, Mask_0)
        '        txtVT(5).Text = Format(onv.MLB_IV, Mask_0)
        '        txtVT(6).Text = Format(onv.MLB_V, Mask_0)
        '    End If
    End Sub
    '======================================================================================
    ' Thu tuc chon vat tu
    ' sh: so hieu vat tu can chon
    ' Tra ve so hieu vat tu duoc chon
    '======================================================================================
    Public Function ChonChucvu(ByRef sh As String) As Integer
        Dim result As Integer = 0
        Dim mpl As Integer
        Dim shtk As String = String.Empty
        Dim pos, j, i, Length As Integer
        If sh.Length > 0 And sh <> "..." Then
            shtk = String.Format("SELECT DISTINCT TOP 1 maso AS F1, SoHieu FROM Chucvu WHERE SoHieu LIKE '{0}%' ORDER BY SoHieu", sh)
            mpl = ConvertToDblSafe(GetSelectValue(shtk))
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
            result = onv.MaSo - 1
        Else
            result = 0
        End If
        Int_RecsetToCbo("SELECT DISTINCT Ten As F1,maso as f2 FROM chucvu ORDER BY maso", FrmQuanLyNhanVien.CboChucvu)
        Return result
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
            .sohieu = txtVT(0).Text
            .ten = txtVT(1).Text
            If ChkLoai(1).CheckState Then
                .HSB_I = ConvertToDblSafe(txtVT(2).Text)
                .HSB_II = ConvertToDblSafe(txtVT(3).Text)
                .HSB_III = ConvertToDblSafe(txtVT(4).Text)
                .HSB_IV = ConvertToDblSafe(txtVT(5).Text)
                .HSB_V = ConvertToDblSafe(txtVT(6).Text)
            Else
                .HSB_I = 0
                .HSB_II = 0
                .HSB_III = 0
                .HSB_IV = 0
                .HSB_V = 0
            End If
            If ChkLoai(2).CheckState Then
                .MLB_I = ConvertToDblSafe(txtVT(2 + 5).Text)
                .MLB_II = ConvertToDblSafe(txtVT(3 + 5).Text)
                .MLB_III = ConvertToDblSafe(txtVT(4 + 5).Text)
                .MLB_IV = ConvertToDblSafe(txtVT(5 + 5).Text)
                .MLB_V = ConvertToDblSafe(txtVT(6 + 5).Text)
            Else
                .MLB_I = 0
                .MLB_II = 0
                .MLB_III = 0
                .MLB_IV = 0
                .MLB_V = 0
            End If
            If ChkLoai(3).CheckState Then
                .TVB_I = ConvertToDblSafe(txtVT(2 + 10).Text)
                .TVB_II = ConvertToDblSafe(txtVT(3 + 10).Text)
                .TVB_III = ConvertToDblSafe(txtVT(4 + 10).Text)
                .TVB_IV = ConvertToDblSafe(txtVT(5 + 10).Text)
                .TVB_V = ConvertToDblSafe(txtVT(6 + 10).Text)
            Else
                .TVB_I = 0
                .TVB_II = 0
                .TVB_III = 0
                .TVB_IV = 0
                .TVB_V = 0
            End If
            If ChkLoai(4).CheckState Then
                .LNB_I = ConvertToDblSafe(txtVT(2 + 15).Text)
                .LNB_II = ConvertToDblSafe(txtVT(3 + 15).Text)
                .LNB_III = ConvertToDblSafe(txtVT(4 + 15).Text)
                .LNB_IV = ConvertToDblSafe(txtVT(5 + 15).Text)
                .LNB_V = ConvertToDblSafe(txtVT(6 + 15).Text)
            Else
                .LNB_I = 0
                .LNB_II = 0
                .LNB_III = 0
                .LNB_IV = 0
                .LNB_V = 0
            End If
            If .sohieu = "" Or .ten = "" Or .sohieu = "..." Or .ten = "..." Then
                MessageBox.Show(Ngonngu("Thiếu số hiệu hoặc tên", "Lack of number or name"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : Return result
            End If
        End With
        Return True
    End Function
    Private Sub SSCmdF_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles SSCmdF.Click
        If Strings.Len(txtF.Text) = 0 Then
            txtF.Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM {0} WHERE MaSo>{1}", TenBang, ConvertToStrSafe(MaDaTim))
        If SSOpt(0).Checked Then sql = String.Format("{0} AND SoHieu LIKE N'{1}%'", sql, txtF.Text)
        If SSOpt(1).Checked Then sql = String.Format("{0} AND Ten LIKE N'{1}%'", sql, txtF.Text)
        sql = ConvertToStrSafe(GetSelectValue(sql))
        If sql <> "0" Then
            ChonChucvu(sql)
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
    Private Sub txtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_17.Enter, _txtVT_18.Enter, _txtVT_19.Enter, _txtVT_20.Enter, _txtVT_21.Enter, _txtVT_12.Enter, _txtVT_13.Enter, _txtVT_14.Enter, _txtVT_15.Enter, _txtVT_16.Enter, _txtVT_11.Enter, _txtVT_10.Enter, _txtVT_9.Enter, _txtVT_8.Enter, _txtVT_7.Enter, _txtVT_2.Enter, _txtVT_3.Enter, _txtVT_4.Enter, _txtVT_5.Enter, _txtVT_6.Enter, _txtVT_1.Enter, _txtVT_0.Enter
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        txtVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtVT_17.KeyPress, _txtVT_18.KeyPress, _txtVT_19.KeyPress, _txtVT_20.KeyPress, _txtVT_21.KeyPress, _txtVT_12.KeyPress, _txtVT_13.KeyPress, _txtVT_14.KeyPress, _txtVT_15.KeyPress, _txtVT_16.KeyPress, _txtVT_11.KeyPress, _txtVT_10.KeyPress, _txtVT_9.KeyPress, _txtVT_8.KeyPress, _txtVT_7.KeyPress, _txtVT_2.KeyPress, _txtVT_3.KeyPress, _txtVT_4.KeyPress, _txtVT_5.KeyPress, _txtVT_6.KeyPress, _txtVT_1.KeyPress, _txtVT_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
            Case 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21
                If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 46 And KeyAscii <> 8 Then
                    MessageBox.Show(Ngonngu("Bạn chỉ được nhập số !", "Enter only number !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    KeyAscii = 0
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
    Private Sub txtVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_17.Leave, _txtVT_18.Leave, _txtVT_19.Leave, _txtVT_20.Leave, _txtVT_21.Leave, _txtVT_12.Leave, _txtVT_13.Leave, _txtVT_14.Leave, _txtVT_15.Leave, _txtVT_16.Leave, _txtVT_11.Leave, _txtVT_10.Leave, _txtVT_9.Leave, _txtVT_8.Leave, _txtVT_7.Leave, _txtVT_2.Leave, _txtVT_3.Leave, _txtVT_4.Leave, _txtVT_5.Leave, _txtVT_6.Leave, _txtVT_1.Leave, _txtVT_0.Leave
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        If Index <> 0 And Index <> 1 Then
            If Strings.Len(txtVT(Index).Text) = 0 Then
                If Index >= 2 And Index <= 6 Then txtVT(Index).Text = Format(0, Mask_2)
                If Index >= 7 And Index <= 21 Then txtVT(Index).Text = Format(0, Mask_0)
            Else
                If Index >= 2 And Index <= 6 Then txtVT(Index).Text = Format(txtVT(Index).Text, Mask_2)
                If Index >= 7 And Index <= 21 Then txtVT(Index).Text = Format(txtVT(Index).Text, Mask_0)
            End If
        End If
        If Index = 0 Then
            txtVT(Index).Text = txtVT(Index).Text.ToUpper()
            If ThemMoi = 1 And ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM {0} WHERE sohieu=N'{1}'", TenBang, txtVT(Index).Text))) <> 0 Then
                ErrMsg(er_SoHieu)
                txtVT(Index).Focus()
                Exit Sub
            End If
        End If
        Dim ten As String = String.Empty
        If Index = 1 Then
            ten = txtVT(Index).Text
            ten = ten.Trim().ToLower()
            If ten.Length > 0 Then
                ten = String.Format("{0}{1}", Strings.Left(ten, 1).ToUpper(), Strings.Right(ten, ten.Length - 1))
            Else
                ten = String.Format("{0}{1}", Strings.Left(ten, 1).ToUpper(), Strings.Right(ten, 0))
            End If

            For i As Integer = 1 To ten.Length - 1
                If Strings.Mid(ten, i, 1) = " " And Strings.Mid(ten, i + 1, 1) = " " Then
                    ten = String.Format("{0}{1}", Strings.Left(ten, i), Strings.Right(ten, ten.Length - i - 1)) : i -= 1
                End If
                If Strings.Mid(ten, i, 1) = " " And Strings.Mid(ten, i + 1, 1) <> " " Then Mid(ten, i + 1, 1) = Strings.Mid(ten, i + 1, 1).ToUpper()
            Next
            txtVT(Index).Text = ten
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Hienthiluoi()
        If ThemMoi <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            Int_RecsetToListbox(String.Format("SELECT MaSo As F2, SoHieu + ' - ' + ten As F1 FROM {0} ORDER BY SoHieu", TenBang), LstVt)
            ThemMoi = 0
            doiloai = 0
            Me.Cursor = Cursors.Default
        Else
            doiloai = 1
        End If
    End Sub

    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
End Class
