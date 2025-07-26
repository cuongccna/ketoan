Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmTP
    Dim currentCate As Integer = -3
    Dim ThemMoi As Integer ' =1 neu them moi, -1 neu sua cu
    Private _tp As Cls154 = Nothing
    Dim cboLoaiIndex As Integer = -2
    Dim LstIndex As Integer = -2
    Dim cboThangIndex As Integer = -2
    Dim formInitDone As Boolean = False

    Property tp() As Cls154
        Get
            If _tp Is Nothing Then
                _tp = New Cls154()
            End If
            Return _tp
        End Get
        Set(ByVal Value As Cls154)
            _tp = Value
        End Set
    End Property ' vat tu duoc tham chieu
    Dim doiloai As Integer ' =1 neu co thay doi loai vat tu dang sua doi
    Dim MaDaTim As Integer
    Private _TK As ClsTaikhoan = Nothing
    Property TK() As ClsTaikhoan
        Get
            If _TK Is Nothing Then
                _TK = New ClsTaikhoan()
            End If
            Return _TK
        End Get
        Set(ByVal Value As ClsTaikhoan)
            _TK = Value
        End Set
    End Property
    ''' <summary>
    ''' Liet ke cac vat tu trong loai vat tu duoc chon
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboLoai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLoai.SelectedIndexChanged
        If ThemMoi <> -1 Then
            If cboLoaiIndex <> CboLoai.SelectedIndex Then
                cboLoaiIndex = CboLoai.SelectedIndex
                Me.Cursor = Cursors.WaitCursor
                Int_RecsetToListbox(String.Format("SELECT MaSo As F2, SoHieu + Char(9) + TenVattu As F1 FROM TP154 WHERE MaPhanLoai={0} ORDER BY SoHieu", CboLoai.SelectedValue), LstVt)
                ThemMoi = 0
                doiloai = 0
                LstIndex = -2
                If LstVt.SelectedIndex < 0 Then tp.InitTPMaSo(0)
                Me.Cursor = Cursors.Default
            End If
        Else
            doiloai = 1
            cboLoaiIndex = -2
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        Cursor = Cursors.WaitCursor

        cboThangIndex = CboThang.SelectedIndex
        Dim tcuoi As Integer
        If CboThang.SelectedIndex < 0 Then Exit Sub
        Dim thang As Integer = CboThang.SelectedValue
        Dim dk As Double = tp.GiaThanhCK(IIf(thang > 0, ThangTruoc(thang), 0))
        If thang > 0 Then
            tcuoi = thang
        Else
            thang = pThangDauKy
            tcuoi = IIf(pThangDauKy > 1, pThangDauKy - 1, 12)
        End If
        TxtVT(4).Text = Format(dk, Mask_0)
        Dim nvl As Double = tp.SoCPNVL(thang, tcuoi) + tp.SoCPNVLPB(thang, tcuoi)
        LbCP(0).Text = Format(nvl, Mask_0)
        Dim nC As Double = tp.SoCPNC(thang, tcuoi) + tp.SoCPNCPB(thang, tcuoi)
        LbCP(1).Text = Format(nC, Mask_0)
        Dim m As Double = tp.SoCPM(thang, tcuoi) + tp.SoCPMPB(thang, tcuoi)
        LbCP(2).Text = Format(m, Mask_0)
        Dim kh As Double = tp.SoCPKH(thang, tcuoi)
        LbCP(3).Text = Format(kh, Mask_0)
        Dim cp2 As Double = tp.SoCPSXC(thang, tcuoi) + tp.SoCPSXCTT(thang, tcuoi)
        LbCP(4).Text = Format(cp2, Mask_0)
        LbCP(5).Text = Format(dk + nvl + nC + m + cp2, Mask_0)

        Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdtk_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdtk_0.Click
        Dim Index As Integer = Array.IndexOf(cmdtk, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtShTk(Index).Text = FrmTaikhoan.ChonTk(txtShTk(Index).Text)
        txtShTk(Index).Focus()
        Me.Cursor = Cursors.Default
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
        Dim vt As New Cls154
        Dim i As Integer
        If (User_Right = 2) And (Index < 3) Then
            HienThongBao("Không có quyền truy cập!", 1)
            Exit Sub
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
                TxtVT(0).Text = SoHieuVTMoi(CboLoai.SelectedValue, 1)
                TxtVT(1).Text = ""
                TxtVT(0).Focus()
                ThemMoi = 1
                Khoaquyen()
            Case 1
                Select Case ThemMoi
                    Case 1
                        If Not KiemTraSoLieu() Then GoTo XongVT
                        If tp.GhiTP() = 0 Then
                            tp.GhiDK(ConvertToDblSafe(TxtVT(4).Text))

                            'van.nguyen 27-Nov-2011
                            Dim temp As String = String.Format("{0}{1}{2}", tp.SoHieu, Chr(9), tp.TenVattu)
                            Dim newItemCate As New ValueDescriptionPair(tp.MaSo, temp)

                            LstVt_NewIndex = LstVt.Items.Add(newItemCate)
                            If LstVt.Items.Count > 0 Then
                                LstVt.SelectedIndex = LstVt_NewIndex
                            End If
                        Else
                            ErrMsg(er_SoHieu)
                            vt.InitTPSohieu(TxtVT(0).Text)
                            If vt.MaPhanLoai = CboLoai.SelectedValue Then
                                SetListIndex(LstVt, vt.MaSo)
                            End If
                        End If
                        ThemMoi = 0
                    Case 0
                        If LstVt.SelectedIndex < 0 Or Not KiemTraSoLieu() Then GoTo XongVT
                        If tp.SuaTP() = 0 Then
                            tp.GhiDK(ConvertToDblSafe(TxtVT(4).Text))
                            If doiloai = 1 Then
                                CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                                doiloai = 0
                            Else
                                'VB6.SetItemString(LstVt, LstVt.SelectedIndex, String.Format("{0}{1}{2}", tp.SoHieu, Chr(9), tp.TenVattu))
                                Dim currentCate As ValueDescriptionPair = CType(LstVt.SelectedItem, ValueDescriptionPair)
                                Dim newItemCate As New ValueDescriptionPair(currentCate.Value, String.Format("{0}{1}{2}", tp.SoHieu, Chr(9), tp.TenVattu))
                                If LstVt.Items.Count > 0 Then
                                    LstVt.Items(LstVt.SelectedIndex) = newItemCate
                                End If

                            End If
                        Else
                            vt.InitTPSohieu(TxtVT(0).Text)
                            ErrMsg(er_SoHieu)
                            If vt.MaPhanLoai = CboLoai.SelectedValue Then SetListIndex(LstVt, vt.MaSo)
                        End If
                        ThemMoi = 0
                End Select
                LstVt.Focus()
            Case 2
                i = LstVt.SelectedIndex
                If i < 0 Then GoTo XongVT
                If tp.XoaTP() = 0 Then
                    LstVt.Items.RemoveAt(ConvertToDblSafe(i))
                    If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = i - 1
                Else
                    ErrMsg(er_CoPS)
                End If
                LstVt.Focus()
            Case 3
                Hide()
        End Select
XongVT:
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
    ''' <summary>
    ''' Xu ly cac phim nong
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmTP_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.T
                    Command(0).Focus()
                    '  Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmTP_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ThemMoi = 0
            doiloai = 0


            Int_RecsetToCbo("SELECT DISTINCT MaSo As F2, SoHieu + ' - '  + TenPhanLoai As F1, SoHieu FROM PhanLoai154 WHERE PLCon=0 ORDER BY SoHieu", CboLoai)

            If CboLoai.Items.Count > 0 Then
                CboLoai.SelectedIndex = 0
            End If

            AddMonthToCbo(CboThang)
            If CboThang.Items.Count > 0 Then
                cboThangIndex = Today.Month - 1
                CboThang.SelectedIndex = cboThangIndex
                CboThang.Items.Insert(0, "TB")
                CboThang.SelectedIndex = 0
            End If

            TK.InitTaikhoanSohieu(txtShTk(0).Text)
            formInitDone = True
            If (pNN = 1 And Not Me.Text Like "List of projects and products*") Or (pNN = 1 And Not Me.Text Like "Hệ thống danh điểm công trình, sản phẩm*") Then SetFont(Me)
            Text = SetFormTitle(Ngonngu("Hệ thống danh điểm công trình, sản phẩm", "List of projects and products"))

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
    Private Sub FrmTP_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        tp = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' Khoi tao vat tu duoc chon
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.SelectedIndexChanged
        Cursor = Cursors.WaitCursor
        Try
            If LstIndex <> LstVt.SelectedIndex Then
                LstIndex = LstVt.SelectedIndex
                cboThangIndex = -2
                Dim currentCate As ValueDescriptionPair
                Dim index As Integer = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
                currentCate = CType(LstVt.Items(index), ValueDescriptionPair)
                tp.InitTPMaSo(currentCate.Value)
                ShowChitiet(tp)
            End If
            CboThang_SelectedIndexChanged(CboThang, New EventArgs)
        Catch ex As Exception
            Cursor = Cursors.Default
            Throw New Exception(ex.Message)
        End Try
        
        Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' Thu tuc hien thong tin chi tiet
    ''' </summary>
    ''' <param name="tp"></param>
    ''' <remarks></remarks>
    Private Sub ShowChitiet(ByRef tp As Cls154)
        TxtVT(0).Text = tp.SoHieu
        TxtVT(1).Text = tp.TenVattu
        TxtVT(2).Text = tp.DonVi
        TxtVT(3).Text = tp.GhiChu
        TK.InitTaikhoanMaSo(tp.MaTK)
        txtShTk(0).Text = TK.sohieu
        LbTenTk(0).Text = TK.ten
    End Sub
    ''' <summary>
    ''' Thu tuc chon vat tu
    ''' </summary>
    ''' <param name="sh">so hieu vat tu can chon</param>
    ''' <returns>Tra ve so hieu vat tu duoc chon</returns>
    ''' <remarks></remarks>
    Public Function ChonTP(ByRef sh As String) As String
        Dim mpl As Integer
        Dim shtk As String = String.Empty
        Dim pos, j, i, Length As Integer
        If sh.Length > 0 Then
            shtk = String.Format("SELECT DISTINCT TOP 1 MaPhanLoai AS F1, SoHieu FROM TP154 WHERE SoHieu LIKE '{0}%' ORDER BY SoHieu", sh)
            mpl = ConvertToDblSafe(GetSelectValue(shtk))
            If mpl > 0 Then
                If CboLoai.SelectedValue <> "" Then
                    If CboLoai.SelectedValue <> mpl Then SetListIndex(CboLoai, mpl)
                End If

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
        If tp.MaSo > 0 Then
            Return tp.SoHieu
        Else
            Return ""
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
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
    ''' <summary>
    ''' Thu tuc kiem tra va dua so lieu vao object
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraSoLieu() As Boolean
        Dim result As Boolean = False
        If Strings.Len(TxtVT(0).Text) = 0 Then
            ErrMsg(er_SoHieu)
            TxtVT(0).Focus()
            Return result
        End If
        If Strings.Len(TxtVT(1).Text) = 0 Then
            ErrMsg(er_Ten)
            TxtVT(1).Focus()
            Return result
        End If
        If Strings.Len(TxtVT(2).Text) = 0 Then
            MessageBox.Show(Ngonngu("Thiếu đơn vị tính!", "Missing unit"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtVT(2).Focus()
            Return result
        End If
        If TK.maso = 0 Or TK.tkcon > 0 Or (Not TK.sohieu Like String.Format("{0}*", ShTkSPDo)) Then
            txtShTk(0).Focus()
            Return result
        End If
        With tp
            If ThemMoi = 1 Then .MaSo = 0
            'van.nguyen 27-Nov-2011
            If CboLoai.Items.Count > 0 Then .MaPhanLoai = CboLoai.SelectedValue
            .SoHieu = TxtVT(0).Text
            .TenVattu = TxtVT(1).Text
            .DonVi = TxtVT(2).Text
            .GhiChu = IIf(Strings.Len(TxtVT(3).Text) > 0, TxtVT(3).Text, "...")
            .MaTK = TK.maso
        End With
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub SSCmdF_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles SSCmdF.Click
        Try
            If Strings.Len(txtF.Text) = 0 Then
                txtF.Focus()
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim sql As String = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM TP154 WHERE MaSo>{0}", MaDaTim)
            If SSOpt(0).Checked Then sql = String.Format("{0} AND SoHieu LIKE '{1}%'", sql, txtF.Text)
            If SSOpt(1).Checked Then sql = String.Format("{0} AND TenVattu like  N'%{1}%'", sql, txtF.Text)
            sql = ConvertToStrSafe(GetSelectValue(sql))
            If sql <> "0" Then
                ChonTP(sql)
                MaDaTim = tp.MaSo
            Else
                MaDaTim = 0
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Throw New Exception("Lỗi tìm kiếm " + ex.Message)
        End Try
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
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_0.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If KeyAscii = 13 Then cmdtk_ClickEvent(cmdtk(Index), New EventArgs())
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
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_0.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).Text = txtShTk(Index).Text.ToUpper()
        TK.InitTaikhoanSohieu(txtShTk(Index).Text)
        LbTenTk(Index).Text = TK.ten
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TxtVT_0.Enter, _TxtVT_1.Enter, _TxtVT_2.Enter, _TxtVT_3.Enter, _TxtVT_4.Enter
        Dim Index As Integer = Array.IndexOf(TxtVT, eventSender)
        TxtVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _TxtVT_0.KeyPress, _TxtVT_1.KeyPress, _TxtVT_2.KeyPress, _TxtVT_3.KeyPress, _TxtVT_4.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(TxtVT, eventSender)
        Select Case Index
            Case 0 : If KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
            Case 4 : KeyProcess(TxtVT(Index), KeyAscii)
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
    Private Sub TxtVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TxtVT_0.Leave, _TxtVT_1.Leave, _TxtVT_2.Leave, _TxtVT_3.Leave, _TxtVT_4.Leave
        Dim Index As Integer = Array.IndexOf(TxtVT, eventSender)
        Select Case Index
            Case 0
                TxtVT(Index).Text = TxtVT(Index).Text.ToUpper()
            Case 1, 2, 3
                If Strings.Len(TxtVT(Index).Text) = 0 Then TxtVT(Index).Text = "..."
            Case 4
                TxtVT(Index).Text = Format(TxtVT(Index).Text, Mask_0)
        End Select
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
