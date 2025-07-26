Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmGiaVTKH

    Dim ThemMoi As Integer ' =1 neu them moi, -1 neu sua cu
    Private _tp As CLsGiaVTKH = Nothing
    Property tp() As CLsGiaVTKH
        Get
            If _tp Is Nothing Then
                _tp = New CLsGiaVTKH()
            End If
            Return _tp
        End Get
        Set(ByVal Value As CLsGiaVTKH)
            _tp = Value
        End Set
    End Property ' vat tu duoc tham chieu
    Dim doiloai As Integer ' =1 neu co thay doi loai vat tu dang sua doi
    Dim MaDaTim As Integer
    Private _TK As ClsTaikhoan = Nothing
    Dim cboLoadiIndex As Integer = -2

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
    ''' Khoi tao form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmGiaVTKH_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ThemMoi = 0
            doiloai = 0
            Text = SetFormTitle(Text)
            Int_RecsetToCbo("SELECT DISTINCT MaSo As F2, SoHieu + ' - '  + TenPhanLoai As F1, SoHieu FROM PhanLoaivattu WHERE PLCon=0 ORDER BY SoHieu", CboLoai)

            If CboLoai.Items.Count > 0 Then
                CboLoai.SelectedIndex = 0
            End If
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' Liet ke cac vat tu trong loai vat tu duoc chon
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CboLoai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLoai.SelectedIndexChanged
        If cboLoadiIndex <> CboLoai.SelectedIndex Then
            cboLoadiIndex = CboLoai.SelectedIndex
            If ThemMoi <> -1 Then
                Me.Cursor = Cursors.WaitCursor
                Int_RecsetToListbox(String.Format("SELECT MaSo As F2, SoHieu + Char(9) + TenVattu As F1 FROM VATTU WHERE MaPhanLoai={0} ORDER BY SoHieu", CboLoai.SelectedValue), LstVt)
                ThemMoi = 0
                doiloai = 0
                If LstVt.SelectedIndex < 0 Then
                    tp.InitTPMaSo(0)
                    ShowChitiet(tp)
                End If
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
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click, _Command_2.Click, _Command_3.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim vt As New Cls154
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
        Dim rs As DataTable
        Dim sql As String = String.Empty
        Select Case Index
            Case 0
                TxtVT(0).Text = SoHieuVTMoi(CboLoai.SelectedValue, 1)
                TxtVT(2).Text = ""
                TxtVT(3).Text = ""
                ThemMoi = 1
            Case 1
                Select Case ThemMoi
                    Case 1
                        If tp.GhiTP(ConvertToDblSafe(TxtVT(4).Text), TxtVT(2).Text) <> 0 Then
                            MessageBox.Show(Ngonngu("Lỗi khi thêm!", "Error add"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                        ThemMoi = 0
                    Case 0
                        sql = String.Format("SELECT * FROM giavtkh WHERE sohieukh=N'{0}' and sohieuvt=N'{1}' ", _
                                  kh, _
                                  TxtVT(2).Text)
                        rs = ExecSQLReturnDT(sql)
                        If rs.Rows.Count > 0 Then
                            If tp.SuaTP(ConvertToDblSafe(TxtVT(4).Text), TxtVT(2).Text) <> 0 Then
                                MessageBox.Show(Ngonngu("Lỗi khi sửa!", "Error edit!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        Else
                            If tp.GhiTP(ConvertToDblSafe(TxtVT(4).Text), TxtVT(2).Text) <> 0 Then
                                MessageBox.Show(Ngonngu("Lỗi khi thêm!", "Error ad!d"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                        ThemMoi = 0
                End Select
            Case 2
                If tp.XoaTP(TxtVT(2).Text) = 0 Then
                    TxtVT(4).Text = "0"
                Else
                    MessageBox.Show(Ngonngu("Lỗi khi xoá!", "Error delete!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'ErrMsg er_CoPS
                End If
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
        If ConvertToStrSafe(Me.Tag) = "" Then Me.Tag = "0"
        If ConvertToDblSafe(Me.Tag) < 0 Then
            SetListIndex(CboLoai, -ConvertToDblSafe(Me.Tag))
            Me.Tag = "0"
        End If
        If ThemMoi = 0 And ConvertToDblSafe(Me.Tag) = 1 Then LstVt.Focus()
        If LstVt.Items.Count > 0 Then LstVt_SelectedIndexChanged(LstVt, New EventArgs())
    End Sub
    ''' <summary>
    ''' Xu ly cac phim nong
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmGiaVTKH_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(3).Focus()
                    'Command_ClickEvent(Command(3), New EventArgs())
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
        If eventArgs.KeyCode = Keys.Escape Then Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmGiaVTKH_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        tp = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' Khoi tao vat tu duoc chon
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LstVt_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.SelectedIndexChanged
        tp.InitTPMaSo(LstVt.SelectedIndex)
        Dim index As Integer = 0
        Dim currentCate As ValueDescriptionPair
        index = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
        currentCate = CType(LstVt.Items(index), ValueDescriptionPair)
        tp.InitTPMaSo(currentCate.Value)
        ShowChitiet(tp)
    End Sub
    ''' <summary>
    ''' Thu tuc hien thong tin chi tiet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ShowChitiet(ByRef tp As CLsGiaVTKH)
        TxtVT(0).Text = kh
        '************************************************************
        Dim sql As String = String.Format("SELECT ten FROM khachhang WHERE sohieu=N'{0}'", kh)
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            TxtVT(1).Text = ConvertToStrSafe(rsItem(0))
        End If
        '*************************************************************
        TxtVT(2).Text = tp.SoHieuVT
        TxtVT(3).Text = tp.TenVattu
        '*************************************************************
        If tp.SoHieuVT <> "'...'" Then
            sql = String.Format("SELECT giaban FROM giavtkh WHERE sohieukh=N'{0}' and sohieuvt=N'{1}'", _
                      kh, _
                      tp.SoHieuVT)
            rs = ExecSQLReturnDT(sql)
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                TxtVT(4).Text = Format(rsItem(0), Mask_2)
            Else
                TxtVT(4).Text = "0"
            End If
        Else
            TxtVT(4).Text = "0"
        End If
        TxtVT(5).Text = ConvertToStrSafe(tp.DVT1)
        TxtVT(6).Text = tp.DVT2
        TxtVT(7).Text = tp.TL
    End Sub
    ''' <summary>
    ''' Thu tuc chon vat tu
    ''' </summary>
    ''' <param name="sh">So hieu vat tu can chon</param>
    ''' <returns>Tra ve so hieu vat tu duoc chon</returns>
    ''' <remarks></remarks>
    Public Function ChonTP(ByRef sh As String) As String
        Dim mpl As Integer
        Dim shtk As String = String.Empty
        Dim pos, j, i, Length As Integer
        If sh.Length > 0 Then
            shtk = String.Format("SELECT DISTINCT TOP 1 MaPhanLoai AS F1, SoHieu FROM VATTU WHERE SoHieu LIKE '{0}%' ORDER BY SoHieu", sh)
            mpl = ConvertToDblSafe(GetSelectValue(shtk))
            If mpl > 0 Then
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
        If tp.MaSo > 0 Then
            Return tp.SoHieuVT
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
    Private Sub TxtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TxtVT_7.Enter, _TxtVT_6.Enter, _TxtVT_5.Enter, _TxtVT_4.Enter, _TxtVT_2.Enter, _TxtVT_3.Enter, _TxtVT_1.Enter, _TxtVT_0.Enter
        Dim Index As Integer = Array.IndexOf(TxtVT, eventSender)
        TxtVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _TxtVT_7.KeyPress, _TxtVT_6.KeyPress, _TxtVT_5.KeyPress, _TxtVT_4.KeyPress, _TxtVT_2.KeyPress, _TxtVT_3.KeyPress, _TxtVT_1.KeyPress, _TxtVT_0.KeyPress
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
    Private Sub TxtVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TxtVT_7.Leave, _TxtVT_6.Leave, _TxtVT_5.Leave, _TxtVT_4.Leave, _TxtVT_2.Leave, _TxtVT_3.Leave, _TxtVT_1.Leave, _TxtVT_0.Leave
        Dim Index As Integer = Array.IndexOf(TxtVT, eventSender)
        Select Case Index
            Case 0
                TxtVT(Index).Text = TxtVT(Index).Text.ToUpper()
            Case 1, 2, 3
                If Strings.Len(TxtVT(Index).Text) = 0 Then TxtVT(Index).Text = "..."
            Case 4
                TxtVT(Index).Text = Format(TxtVT(Index).Text, Mask_2)
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SSCmdF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSCmdF1.Click
        'txtF.Focus()
        Try
            If Strings.Len(txtF.Text) = 0 Then
                txtF.Focus()
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim sql As String = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM Vattu WHERE MaSo>{0}", MaDaTim)
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
End Class
