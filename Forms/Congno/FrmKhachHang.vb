Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmKhachHang
    Dim ThemMoi As Integer ' =1 neu them moi, -1 neu sua cu
    Private _okh As clsKhachHang = Nothing
    Dim doiloai As Integer ' =1 neu co thay doi loai vat tu dang sua doi
    Dim MaDaTim As String
    Dim xT As Integer
    Dim xSH As String = String.Empty
    Dim cboLoadIndex As Integer = -2
    Dim lstSelectedIndex As Integer = -2

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property okh() As clsKhachHang
        Get
            If _okh Is Nothing Then
                _okh = New clsKhachHang()
            End If
            Return _okh
        End Get
        Set(ByVal Value As clsKhachHang)
            _okh = Value
        End Set
    End Property ' vat tu duoc tham chieu

    ''' <summary>
    ''' Liet ke cac vat tu trong loai vat tu duoc chon
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboLoai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLoai.SelectedIndexChanged
        If cboLoadIndex <> CboLoai.SelectedIndex Then
            cboLoadIndex = CboLoai.SelectedIndex
            lstSelectedIndex = -2

            If ThemMoi <> -1 Then
                Me.Cursor = Cursors.WaitCursor
                Int_RecsetToListbox(String.Format("SELECT MaSo As F2, SoHieu + Char(9) + Ten As F1 FROM KhachHang WHERE MaPhanLoai={0} ORDER BY SoHieu", CboLoai.SelectedValue), LstVt)
                If (LstVt.Items.Count > 0) Then
                    LstVt.SelectedIndex = 0
                End If

                ThemMoi = 0
                doiloai = 0
                Me.Cursor = Cursors.Default
            Else
                doiloai = 1
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click, _Command_4.Click, _Command_5.Click, _Command_6.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim LstVt_NewIndex As Integer = -1
        Dim vt As New clsKhachHang
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
                txtVT(0).Text = SoHieuVTMoi(CboLoai.SelectedValue, 2)
                For i = 1 To 9
                    txtVT(i).Text = "..."
                Next
                If CboNT.Items.Count > 0 Then
                    CboNT.SelectedIndex = 0
                End If

                txtVT(0).Focus()
                ThemMoi = 1
                Khoaquyen()
            Case 1
                Select Case ThemMoi
                    Case 1
                        If Not KiemTraSoLieu() Then GoTo XongVT
                        If okh.KiemTraSoHieuKhachHang(txtVT(0).Text) = True Then
                            MessageBox.Show(Ngonngu("Mã khách hàng đã tồn tại, bạn nhập mã khách hàng khác!", "Customer NO ready exits in system, please chose Customer NO orther!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtVT(0).Focus()
                            txtVT(0).SelectAll()
                            GoTo XongVT
                        End If
                        If okh.GhiKhachHang() = 0 Then
                            Dim sohieutim As String = okh.SoHieu
                            If CboLoai.Items.Count > 0 Then
                                CboLoai.SelectedIndex = CboLoai.Items.Count - 1

                                'cu ngay 17-1-19
                                If LstVt.Items.Count > 0 Then
                                    ChonKhachHang(sohieutim, okh.MaPhanLoai)
                                End If
                            End If

                            'If LstVt.Items.Count > 0 Then
                            '    If CboLoai.Items.Count > 0 Then
                            '        CboLoai.SelectedIndex = CboLoai.Items.Count - 1
                            '        SetListIndex(CboLoai, okh.MaPhanLoai)
                            '    End If
                            'End If
                        Else
                            ErrMsg(er_SoHieu)
                            vt.InitKhachHangSohieu(txtVT(0).Text)
                            If vt.MaPhanLoai = CboLoai.SelectedIndex Then
                                SetListIndex(LstVt, vt.MaSo)
                            End If
                        End If
                        ThemMoi = 0
                        LstVt.Refresh()
                    Case 0
                        If LstVt.SelectedIndex < 0 Or Not KiemTraSoLieu() Then GoTo XongVT
                        If okh.SuaKH() = 0 Then
                            If doiloai = 1 Then
                                CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                                doiloai = 0
                            Else
                                Dim newItemCate As New ValueDescriptionPair(_okh.MaSo, String.Format("{0}{1}{2}", okh.SoHieu, Chr(9), okh.Ten))
                                LstVt.Items(LstVt.SelectedIndex) = newItemCate
                            End If
                        Else
                            vt.InitKhachHangSohieu(txtVT(0).Text)
                            ErrMsg(er_SoHieu)
                            If vt.MaPhanLoai = CboLoai.SelectedIndex Then SetListIndex(LstVt, vt.MaSo)
                        End If
                        ThemMoi = 0
                End Select
                LstVt.Focus()
            Case 2
                i = LstVt.SelectedIndex
                If i < 0 Then GoTo XongVT
                If okh.XoaKH() = 0 Then
                    LstVt.Items.RemoveAt(ConvertToDblSafe(i))
                    If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = i - 1
                Else
                    ErrMsg(er_CoPS1)
                End If
                LstVt.Focus()
            Case 3
                Hide()
            Case 4
                If Strings.Len(txtVT(0).Text) Then kh = txtVT(0).Text
                FrmGiaVTKH.ShowDialog()
            Case 5
                NhapKhachhangVao()
            Case 6
                XuatKhachhangRa(CboLoai.SelectedValue)
        End Select
XongVT:
        vt = Nothing
        Me.Cursor = Cursors.Default
        LstVt.Refresh()
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Text = SetFormTitle(Text)
        If ConvertToDblSafe(Me.Tag) < 0 Then
            SetListIndex(CboLoai, -ConvertToDblSafe(Me.Tag))
            Me.Tag = "0"
        End If
        If ThemMoi = 0 And ConvertToDblSafe(Me.Tag) = 1 Then LstVt.Focus()
        If xT = 1 Then
            If xSH <> "" Then SetListIndex(CboLoai, LayMaPhanLoai(xSH, "KhachHang"))
            Command_ClickEvent(Command(0), New EventArgs())
            txtVT(0).Text = xSH
        End If
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' Xu ly cac phim nong
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmKhachHang_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.B
                    Command(4).Focus()
                Case Keys.V
                    Command(3).Focus()
                Case Keys.T
                    Command(0).Focus()
                Case Keys.X
                    Command(2).Focus()
                Case Keys.G
                    Command(1).Focus()
                Case Keys.N
                    Command(5).Focus()
                Case Keys.E
                    Command(6).Focus()
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Hide()
    End Sub
    ''' <summary>
    ''' Khoi tao form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmKhachHang_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ThemMoi = 0
            ' If CboLoai.Items.Count <= 0 Then
            If FrmChungtu.tk = 0 And doiloai = 0 Then
                Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + TenPhanLoai As F1, SoHieu FROM PhanLoaiKhachHang WHERE PLCon=0 AND LEFT(SoHieu,1)<>'#' ORDER BY SoHieu", CboLoai)
                If CboLoai.Items.Count > 0 Then CboLoai.SelectedIndex = 0
            ElseIf doiloai = 1 Then
                doiloai = 0
            End If
            Int_RecsetToCbo(String.Format("SELECT MaSo As F2,KyHieu As F1 FROM NguyenTe WHERE KyHieu<>'{0}' ORDER BY KyHieu", pTienStr), CboNT)
            CboNT.Items.Insert(0, pTienStr)
            CboNT.Items(0).ValueKey = 0
            If CboNT.Items.Count > 0 Then
                CboNT.SelectedIndex = 0
            End If
            ' End If
            If pNN = 1 And Not Me.Text Like "Customer List*" Then SetFont(Me)
            If pNN = 1 Then Me.Text = "Customer List"
            Command(4).Enabled = GetSelectValue("select giatheokhach as f1 from license") > 0
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
    Private Sub FrmKhachHang_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        okh = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' Khoi tao vat tu duoc chon
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.SelectedIndexChanged
        If LstVt.SelectedIndex <> lstSelectedIndex Then
            lstSelectedIndex = LstVt.SelectedIndex
            Try
                Dim index As Integer = 0
                Dim currentCate As ValueDescriptionPair
                index = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
                currentCate = CType(LstVt.Items(index), ValueDescriptionPair)
                okh.InitKhachHangMaSo(currentCate.Value)
                ShowChitiet(okh)
                ThemMoi = 0
            Catch ex As Exception
                'For i As Integer = 0 To 9
                '    If i <> 5 And i <> 10 Then txtVT(i).Text = "..."
                'Next
                'txtVT(17).Text = ""
                'CboLoai.SelectedIndex = 0
                'CboBacluong.SelectedIndex = 0
                txtVT(0).Focus()
            End Try
            ' Dim currentCate As ValueDescriptionPair = CType(LstVt.SelectedItem, ValueDescriptionPair)

            'okh.InitKhachHangMaSo(currentCate.Value)
            'ShowChitiet(okh)
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc hien thong tin chi tiet
    ''' </summary>
    ''' <param name="otk"></param>
    ''' <remarks></remarks>
    Private Sub ShowChitiet(ByRef otk As clsKhachHang)
        Dim c, n, nt As Double
        txtVT(0).Text = okh.SoHieu
        txtVT(1).Text = okh.Ten
        txtVT(2).Text = okh.DiaChi
        txtVT(3).Text = okh.mst
        txtVT(4).Text = okh.Tel
        txtVT(5).Text = okh.Fax
        txtVT(6).Text = okh.email
        txtVT(7).Text = okh.DaiDien
        txtVT(8).Text = okh.taikhoan
        txtVT(9).Text = okh.GhiChu
        txtVT(10).Text = Format(okh.DuMax, Mask_0)
        SetListIndex(CboNT, okh.MaNT)
        okh.SoDuKH(ThangCuoiNamTC(), n, c, nt)
        If n - c >= 0 Then
            n -= c
            c = 0
        Else
            c -= n
            n = 0
        End If
        LbTon(0).Text = Format(n, Mask_0)
        LbTon(1).Text = Format(c, Mask_0)
        LbTon(2).Text = Format(nt, Mask_2)
    End Sub
    ''' <summary>
    ''' Thu tuc chon vat tu
    ''' </summary>
    ''' <param name="sh">So hieu vat tu can chon</param>
    ''' <param name="loai"></param>
    ''' <param name="dauky"></param>
    ''' <returns>Tra ve so hieu vat tu duoc chon</returns>
    ''' <remarks></remarks>
    Public Function ChonKhachHang(ByRef sh As String, Optional ByRef loai As Integer = 0, Optional ByRef dauky As Integer = 0) As String
        Dim mpl As Integer, lantim As Integer = 0, id_le As Integer = 0
        Dim shtk As String = String.Empty
        Dim pos, j, i, Length As Integer
        If CboLoai.Items.ItemsBase.Count = 0 Then Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + TenPhanLoai As F1, SoHieu FROM PhanLoaiKhachHang WHERE PLCon=0 AND LEFT(SoHieu,1)<>'#' ORDER BY SoHieu", CboLoai)
        If sh.Length > 0 Then
            shtk = String.Format("SELECT DISTINCT TOP 1 MaPhanLoai AS F1, SoHieu FROM KhachHang WHERE SoHieu LIKE '{0}%' ORDER BY SoHieu", sh)
            mpl = ConvertToDblSafe(GetSelectValue(shtk))
            If mpl > 0 Then
                If CboLoai.SelectedValue <> mpl Then SetListIndex(CboLoai, mpl)
            End If
timlai:
            i = 0
            j = LstVt.Items.Count - 1
            pos = 0
            Length = sh.Length
            Do While i <= j
                pos = (i + j) / 2
                shtk = VB6.GetItemString(LstVt, pos)
                If shtk.Length > Length Then shtk = shtk.Substring(0, Length)
                If sh.ToUpper() = shtk.ToUpper() Then
                    i = pos - 1
                    If i > 0 Then
                        Do While (sh.ToUpper() = LstVt.Items(i).ToString.Substring(0, Length).ToUpper()) And (i > 0)
                            i -= 1
                        Loop
                    End If
                    pos = i + 1
                    GoTo Timduoc
                End If
                If UNItokdau(sh.ToUpper()) > UNItokdau(shtk.ToUpper()) Then
                    If i = pos Then
                        If id_le = 0 Then
                            id_le = 1
                            i = pos + 1
                        Else
                            id_le = 0
                            GoTo Boqua
                        End If
                    Else
                        i = pos
                    End If
                Else
                    If j = pos Then
                        If id_le = 0 Then
                            id_le = 1
                            j = pos - 1
                        Else
                            id_le = 0
                            GoTo Boqua
                        End If
                    Else
                        j = pos
                    End If
                End If
            Loop
Boqua:
            If lantim < CboLoai.Items.ItemsBase.Count Then
                CboLoai.SelectedIndex = lantim
                lantim = lantim + 1
                GoTo timlai
            End If
Timduoc:
            If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = pos
        End If
        Me.Tag = "1"
        Try
            If dauky > 0 Then
                Dim iIndex As Integer = CboLoai.FindString(loai)
                If iIndex > -1 And CboLoai.Items.Count > 0 Then
                    CboLoai.SelectedIndex = iIndex
                End If
            End If
            doiloai = 1
            Me.ShowDialog()
        Catch exc As System.Exception
            'Resume in On-Error-Resume-Next Block
        End Try
        If okh.MaSo > 0 Then
            Return okh.SoHieu
        Else
            Return ""
        End If
        Close()
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
        With okh
            If ThemMoi = 1 Then .MaSo = 0
            If CboLoai.Items.Count > 0 Then
                .MaPhanLoai = CboLoai.SelectedValue
            End If
            .SoHieu = txtVT(0).Text
            .Ten = txtVT(1).Text
            .DiaChi = txtVT(2).Text
            .mst = txtVT(3).Text
            .Tel = txtVT(4).Text
            .Fax = txtVT(5).Text
            .email = txtVT(6).Text
            .DaiDien = txtVT(7).Text
            .taikhoan = txtVT(8).Text
            .GhiChu = txtVT(9).Text
            .DuMax = ConvertToDblSafe(txtVT(10).Text)
            .MaNT = CboNT.SelectedValue
            If .mst <> "..." And ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM KhachHang WHERE MST=N'{0}' AND MaSo<>{1}", .mst, ConvertToStrSafe(.MaSo)))) > 0 Then
                If MessageBox.Show(Ngonngu("Mã số thuế đã có, cho phép nhập?", "Existing code, continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then Return result
            End If
        End With
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_MouseDown(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles LstVt.MouseDown
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        ' Dim Shift As Integer '= Control.ModifierKeys \ &H10000
        ' Dim X As Single '= (eventArgs.X)
        ' Dim Y As Single ' = VB6.PixelsToTwipsY(eventArgs.Y)
        Dim sh As String '= String.Empty 'eventArgs.Button = MouseButtons.Right
        Dim m As Integer
        ' If Button = 2097152 And LstVt.SelectedIndex >= 0 And ThemMoi = 0 Then
        If eventArgs.Button = MouseButtons.Right And LstVt.SelectedIndex >= 0 And ThemMoi = 0 Then
            sh = FrmGetStr.GetString(String.Format("Chuyển {0} - {1} sang phân loại có số hiệu:", _
                                         okh.SoHieu, _
                                         okh.Ten), My.Application.Info.ProductName)
            If sh.Length > 0 Then
                m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM PhanLoaiKhachHang WHERE PLCon=0 AND SoHieu=N'{0}'", sh)))
                If m > 0 And m <> okh.MaPhanLoai Then
                    ExecSQLNonQuery(String.Format("UPDATE KhachHang SET MaPhanLoai={0} WHERE MaSo = {1}", _
                                        m, _
                                        ConvertToStrSafe(okh.MaSo)))
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
    Private Sub SSCmdF_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles SSCmdF.Click
        If Strings.Len(txtF.Text) = 0 Then
            txtF.Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM KhachHang WHERE sohieu>'{0}' and maphanloai={1}", MaDaTim, CboLoai.SelectedValue)
        If SSOpt(0).Checked Then sql = String.Format("{0} AND SoHieu LIKE '%{1}%'", sql, txtF.Text)
        If SSOpt(1).Checked Then sql = String.Format("{0} AND Ten like  N'%{1}%'", sql, txtF.Text)
        If SSOpt(2).Checked Then sql = String.Format("{0} AND MST LIKE '{1}%'", sql, txtF.Text)
        sql = String.Format("{0} order by sohieu", sql)
        sql = ConvertToStrSafe(GetSelectValue(sql))
        If sql <> "0" Then
            ChonKhachHang(sql)
            MaDaTim = okh.SoHieu
        Else
            sql = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM KhachHang WHERE sohieu>'{0}'", MaDaTim)
            If SSOpt(0).Checked Then sql = String.Format("{0} AND SoHieu LIKE '{1}%'", sql, txtF.Text)
            If SSOpt(1).Checked Then sql = String.Format("{0} AND Ten like  N'%{1}%'", sql, txtF.Text)
            If SSOpt(2).Checked Then sql = String.Format("{0} AND MST LIKE '{1}%'", sql, txtF.Text)
            sql = String.Format("{0} order by sohieu", sql)
            sql = ConvertToStrSafe(GetSelectValue(sql))
            If sql <> "0" Then
                ChonKhachHang(sql)
                MaDaTim = okh.SoHieu
            Else
                sql = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM KhachHang WHERE 1=1", MaDaTim, CboLoai.SelectedValue)
                If SSOpt(0).Checked Then sql = String.Format("{0} AND SoHieu LIKE '{1}%'", sql, txtF.Text)
                If SSOpt(1).Checked Then sql = String.Format("{0} AND Ten like  N'%{1}%'", sql, txtF.Text)
                If SSOpt(2).Checked Then sql = String.Format("{0} AND MST LIKE '{1}%'", sql, txtF.Text)
                sql = String.Format("{0} order by sohieu", sql)
                sql = ConvertToStrSafe(GetSelectValue(sql))
                If sql <> "0" Then
                    ChonKhachHang(sql)
                    MaDaTim = okh.SoHieu
                Else
                    MaDaTim = ""
                End If
            End If
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
        MaDaTim = "A"
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_0.Enter, _txtVT_1.Enter, _txtVT_10.Enter, _txtVT_3.Enter, _txtVT_2.Enter, _txtVT_4.Enter, _txtVT_5.Enter, _txtVT_6.Enter, _txtVT_7.Enter, _txtVT_8.Enter, _txtVT_9.Enter
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        txtVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtVT_0.KeyPress, _txtVT_1.KeyPress, _txtVT_10.KeyPress, _txtVT_3.KeyPress, _txtVT_2.KeyPress, _txtVT_4.KeyPress, _txtVT_5.KeyPress, _txtVT_6.KeyPress, _txtVT_7.KeyPress, _txtVT_8.KeyPress, _txtVT_9.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        Select Case Index
            Case 0
                If ContainsSpecialChars(txtVT(0).Text) Then
                    myUMessager.mError(Ngonngu("Mã khách hàng không nhập ký tự đặc biệt, dẫn đến dữ liệu có thể sẽ bị sai.", "Customer code does not enter special characters."), Ngonngu("Mã khách hàng", "Customer code"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Case 0 : If KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
            Case 10, 11, 12 : KeyProcess(txtVT(Index), KeyAscii)
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
    Private Sub txtVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_0.Leave, _txtVT_1.Leave, _txtVT_10.Leave, _txtVT_3.Leave, _txtVT_2.Leave, _txtVT_4.Leave, _txtVT_5.Leave, _txtVT_6.Leave, _txtVT_7.Leave, _txtVT_8.Leave, _txtVT_9.Leave
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        Select Case Index
            Case 0
                txtVT(0).Text = txtVT(0).Text.ToUpper()
                If ContainsSpecialChars(txtVT(0).Text) Then
                    myUMessager.mError(Ngonngu("Mã khách hàng không nhập ký tự đặc biệt, dẫn đến dữ liệu có thể sẽ bị sai.", "Customer code does not enter special characters."), Ngonngu("Mã khách hàng", "Customer code"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                If Strings.Len(txtVT(Index).Text) = 0 Then txtVT(Index).Text = "..."
            Case 10, 11, 12
                txtVT(Index).Text = Format(txtVT(Index).Text, Mask_2)
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ThemKhachHang(ByRef sh As String) As String
        If xT = 1 Then
            Return String.Empty
            Exit Function
        End If

        Me.Tag = "1"
        xT = 1
        xSH = sh
        Me.ShowDialog()
        xT = 0
        xSH = ""
        Return okh.SoHieu
    End Function
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
