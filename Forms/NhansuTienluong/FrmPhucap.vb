Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmPhucap
    Private isInitializingComponent As Boolean
    Private _onv As ClsPhucap = Nothing
    Dim currentSelectIndex As Integer = -2
    Dim currentThangSelectIndex As Integer = -2

    Property onv() As ClsPhucap
        Get
            If _onv Is Nothing Then
                _onv = New ClsPhucap()
            End If
            Return _onv
        End Get
        Set(ByVal Value As ClsPhucap)
            _onv = Value
        End Set
    End Property ' vat tu duoc tham chieu

    Dim MaDaTim As Integer
    Dim MCV As String = String.Empty
    Dim Hienthi As Integer

    ''' <summary>
    ''' Liet ke cac vat tu trong loai vat tu duoc chon
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboLoai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLoai.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Dim dk As String = String.Empty
        'van.nguyen
        'Dim index As Integer = 0
        Try
            'dk = Format(CDate("01/" & CboThang.SelectedIndex + 1 & "/" & frmMain._LbCty_7.Text), Mask_D)
            'index = iif(CboThang.SelectedIndex = -1, 0, CboThang.SelectedIndex)
            dk = FormatDate(DateSerial(frmMain._LbCty_7.Text, CboThang.SelectedValue, 1))
            dk = Strings.Mid(dk, 4, 2)
        Catch
            dk = ConvertToStrSafe(DateTime.Now.Month)
        Finally
            'van.nguyen
            'Int_RecsetToListbox("SELECT MaSo As F2, sohieu + ' - ' + Ten As F1 FROM quanlynhanvien WHERE MaPhanLoai=" & CboLoai.SelectedIndex & (iif(ConvertToDblSafe(Me.Tag) = 2, " and sohieu='" & TuongNhanvien & "'", String.Empty)) & " and (nghiviec<>1 or (nghiviec=1 and mid(ngaynghi,4,2)>='" & dk & "')) and (tang<>1 or (tang=1 and thangtang<=" & dk & ")) ORDER BY sohieu", LstVt)
            Int_RecsetToListbox(String.Format("SELECT MaSo As F2, sohieu + ' - ' + Ten As F1 FROM quanlynhanvien WHERE MaPhanLoai={0}{1} and (nghiviec<>1 or (nghiviec=1 and Substring(CONVERT(CHAR(19), ngaynghi, 20),4,2)>='{2}')) and (tang<>1 or (tang=1 and thangtang<={2})) ORDER BY sohieu", _
                                    CboLoai.SelectedValue, _
                                    (IIf(ConvertToDblSafe(Me.Tag) = 2, String.Format(" and sohieu='{0}'", cuongNhanvien), String.Empty)), _
                                    dk), LstVt)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        If currentThangSelectIndex <> CboThang.SelectedIndex Then
            currentThangSelectIndex = CboThang.SelectedIndex
            Dim mpl As String = ConvertToStrSafe(CboLoai.SelectedValue)
            Dim mspc As Integer = ConvertToDblSafe(timtenmax("thang", SHNVList(), "sohieunhanvien", "phucap"))

            onv.InitNVSoHieuNhanvien(mpl, SHNVList(), CboThang.SelectedValue)

            ShowChitiet(onv)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkGiamtru_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkGiamtru.CheckStateChanged
        'txtVT(4).ReadOnly = Not ChkGiamtru.CheckState
        'txtVT(14).ReadOnly = Not ChkGiamtru.CheckState
        'txtVT(15).ReadOnly = Not ChkGiamtru.CheckState
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Chloai_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Chloai.CheckStateChanged
        'For i As Integer = 6 To 13
        '    txtVT(i).ReadOnly = Not Chloai.CheckState
        'Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_3.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim vt As New ClsPhucap
        Dim i As Integer
        Dim str As String = String.Empty
        Dim rs As DataTable
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
            Case 1
                If Not KiemTraSoLieu() Then GoTo XongVT
                str = "SELECT * FROM phucap WHERE thang=" & onv.thang & " and sohieunhanvien='" & onv.Sohieunhanvien & "'"
                rs = ExecSQLReturnDT(str)
                If rs.Rows.Count = 0 Then
                    If onv.GhiNV() <> 0 Then ErrMsg(er_SoHieu) Else LstVt_SelectedIndexChanged(LstVt, New EventArgs())
                Else
                    If onv.SuaNV() <> 0 Then ErrMsg(er_SoHieu) Else LstVt_SelectedIndexChanged(LstVt, New EventArgs())
                End If
                LstVt.Focus()
            Case 2
                i = LstVt.SelectedIndex
                If i < 0 Then GoTo XongVT
                If onv.XoaNV() <> 0 Then ErrMsg(er_CoPS1) Else LstVt_SelectedIndexChanged(LstVt, New EventArgs())
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
        Hienthi = 0
        If ConvertToDblSafe(Me.Tag) < 0 Then
            SetListIndex(CboLoai, -ConvertToDblSafe(Me.Tag))
            Me.Tag = "0"
        End If
        If ConvertToDblSafe(Me.Tag) = 1 Then LstVt.Focus()
        'CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
        If Hienthi Then
            Me.Hide()
            MessageBox.Show(Ngonngu("Vui lòng nhập chức vụ cho nhân viên ! ", "Please enter position!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' Xu ly cac phim nong
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmPhucap_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case KeyCode
                Case Keys.V
                    Command(3).Focus()
                    Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(3), New EventArgs())
    End Sub
    ''' <summary>
    ''' Khoi tao form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmPhucap_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        'set icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        ' Init form 
        Call FormInit()

        Text = SetFormTitle(Text)
        Int_RecsetToCbo(String.Format("SELECT DISTINCT MaSo As F2,sohieu + ' - ' +Ten As F1, SoHieu FROM PhanLoaiquanlynhanvien WHERE maso not in (select captren from phanloaiquanlynhanvien) ORDER BY MaSo ,SoHieu"), CboLoai)
        If CboLoai.Items.Count > 0 Then
            CboLoai.SelectedIndex = 0
        End If

        AddMonthToCbo(CboThang)
        If CboThang.Items.Count > 0 Then
            CboThang.SelectedIndex = Today.Month - 1
        End If

        If cuongThang > 0 And CboThang.Items.Count > 0 Then CboThang.SelectedIndex = cuongThang
        For i As Integer = 6 To (12 + 1)
            txtVT(i).ReadOnly = True
        Next
        txtVT(0).ReadOnly = True
        txtVT(4).ReadOnly = True
        txtVT(14).ReadOnly = True
        txtVT(15).ReadOnly = True
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmPhucap_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        onv = Nothing
        cuongNhanvien = ""
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' Khoi tao vat tu duoc chon
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.SelectedIndexChanged
        'If currentSelectIndex <> LstVt.SelectedIndex Then
        currentSelectIndex = LstVt.SelectedIndex

        Dim rs As DataTable
        Dim SohieuNV As String = SHNVList()
        Dim mpl As String = ConvertToStrSafe(CboLoai.SelectedValue)
        Dim mspc As Integer = ConvertToDblSafe(timtenmax("thang", SohieuNV, "sohieunhanvien", "phucap"))
        If mspc >= ConvertToDblSafe(CboThang.SelectedValue) Then
            rs = ExecSQLReturnDT(String.Format("SELECT t1.machucvu,t1.maso FROM quanlynhanvien t1 inner join phucap t2 on t1.sohieu=t2.sohieunhanvien and t1.maphanloai=t2.maphanloai WHERE t1.maphanloai={0} and thang={1} and sohieu='{2}'", _
                                     mpl, _
                                     IIf(CboThang.SelectedValue.ToString() = "", -1, CboThang.SelectedValue), _
                                     SohieuNV))
        Else
            rs = ExecSQLReturnDT(String.Format("SELECT machucvu,maso FROM quanlynhanvien WHERE maphanloai={0} and sohieu='{1}'", _
                                     mpl, _
                                     SohieuNV))
        End If
        
        Dim dk1 As Boolean
        Dim dk2 As Boolean
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            Dim maCV As Integer = Nothing
            If rsItem("MaChucvu") IsNot Nothing Then
                maCV = ConvertToDblSafe(rsItem("MaChucvu"), 0)
            End If
            If maCV > 0 Then
                txtVT(0).Text = Timten("ten", maCV, "maso", "chucvu")
                dk1 = ConvertToDblSafe(Timten("HSB1", maCV, "maso", "Chucvu")) <> 0
                dk2 = ConvertToDblSafe(Timten("MLB1", maCV, "maso", "Chucvu")) <> 0
                If dk1 AndAlso Not dk2 Then Optloai(1).Checked = True
                If Not dk1 AndAlso dk2 Then Optloai(2).Checked = True
                Optloai(1).Enabled = dk1
            Else
                Hienthi = 1
            End If
        End If
        onv.InitNVSoHieuNhanvien(mpl, SohieuNV, IIf(CboThang.SelectedValue.ToString() = "", -1, CboThang.SelectedValue.ToString()))

        ShowChitiet(onv)
        'End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function SHNVList() As String
        Dim iIndex As Integer = LstVt.Text.IndexOf(" ")
        If iIndex > -1 Then
            Return LstVt.Text.Substring(0, iIndex)
        Else
            Return LstVt.Text
        End If

        ' Stupid code
        'Dim i As Integer = 1
        'While Strings.Mid(LstVt.Text, i, 1) <> " " And LstVt.Text <> ""
        '    i += 1
        'End While
        'i -= 1
        'Return Strings.Left(LstVt.Text, i)
    End Function
    ''' <summary>
    ''' Thu tuc hien thong tin chi tiet
    ''' </summary>
    ''' <param name="otk"></param>
    ''' <remarks></remarks>
    Private Sub ShowChitiet(ByRef otk As ClsPhucap)
        Dim rs As New DataTable
        Dim str As String = String.Empty
        With otk
            txtVT(14).Text = Format(IIf(.Tamung <> 0, .Tamung, 0), Mask_2)
            txtVT(4).Text = Format(IIf(.Trukhac <> 0, .Trukhac, 0), Mask_2)
            txtVT(15).Text = Format(IIf(.Trukhac1 <> 0, .Trukhac1, 0), Mask_2)
            txtVT(16).Text = Format(IIf(.Trukhac2 <> 0, .Trukhac2, 0), Mask_2)
            txtVT(1).Text = Format(IIf(.chucvu <> 0, .chucvu, 0), Mask_2)
            txtVT(2).Text = Format(IIf(.Trachnhiem <> 0, .Trachnhiem, 0), Mask_2)
            txtVT(3).Text = Format(IIf(.Luudong <> 0, .Luudong, 0), Mask_2)
            txtVT(5).Text = Format(IIf(.Khac1 <> 0, .Khac1, 0), Mask_2)
            txtVT(6).Text = IIf(.Ghichu2 <> "", .Ghichu2, "...")
            txtVT(7).Text = Format(IIf(.Khac2 <> 0, .Khac2, 0), Mask_2)
            txtVT(8).Text = IIf(.Ghichu3 <> "", .Ghichu3, "...")
            txtVT(9).Text = Format(IIf(.Khac3 <> 0, .Khac3, 0), Mask_2)
            txtVT(10).Text = IIf(.Ghichu4 <> "", .Ghichu4, "...")
            txtVT(11).Text = Format(IIf(.Khac4 <> 0, .Khac4, 0), Mask_2)
            txtVT(12).Text = IIf(.Ghichu5 <> "", .Ghichu5, "...")
            txtVT(13).Text = Format(IIf(.Khac5 <> 0, .Khac5, 0), Mask_2)
            Chloai.CheckState = CheckState.Unchecked
            For i As Integer = 6 To 12 Step 2
                If txtVT(i).Text <> "..." Or ConvertToDblSafe(txtVT(i + 1).Text) <> 0 Then
                    Chloai.CheckState = CheckState.Checked
                    Exit For
                End If
            Next
            ChkGiamtru.CheckState = IIf(ConvertToDblSafe(txtVT(14).Text) <> 0 OrElse ConvertToDblSafe(txtVT(4).Text) <> 0 Or ConvertToDblSafe(txtVT(15).Text) <> 0 Or ConvertToDblSafe(txtVT(16).Text) <> 0, CheckState.Checked, CheckState.Unchecked)
            If .loai = 1 Then Optloai(1).Checked = True Else If .loai = 2 Then Optloai(2).Checked = True
        End With
    End Sub
    ''' <summary>
    ''' Thu tuc chon vat tu
    ''' </summary>
    ''' <param name="sh">So hieu vat tu can chon</param>
    ''' <returns>Tra ve so hieu vat tu duoc chon</returns>
    ''' <remarks></remarks>
    Public Function ChonNV(ByRef sh As String) As String
        Dim mpl As Integer
        Dim shtk As String = String.Empty
        Dim pos, j, i, Length As Integer
        If sh.Length > 0 Then
            shtk = String.Format("SELECT DISTINCT TOP 1 MaPhanLoai AS F1, maso FROM quanlynhanvien WHERE sohieu LIKE '{0}%' ORDER BY maso", sh)
            mpl = ConvertToDblSafe(GetSelectValue(shtk))
            If mpl > 0 And CboLoai.SelectedIndex >= 0 Then
                If CboLoai.SelectedIndex <> mpl Then SetListIndex(CboLoai, mpl)
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
        If onv.maso > 0 Then
            Return ConvertToStrSafe(onv.maso)
        Else
            Return ""
        End If
    End Function
    ''' <summary>
    ''' Thu tuc kiem tra va dua so lieu vao object
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraSoLieu() As Boolean
        Dim result As Boolean = False
        With onv
            .MaPhanLoai = CboLoai.SelectedValue
            If txtVT(0).Text = String.Empty Or txtVT(0).Text = "..." Then
                txtVT(0).Focus()
                Return False
            End If
            If Strings.Len(txtVT(0).Text) <> 0 Then .MaChucvu = ConvertToDblSafe(Timten("maso", txtVT(0).Text, "ten", "chucvu"))

            .thang = CboThang.SelectedValue
            .Sohieunhanvien = SHNVList()
            If .Sohieunhanvien = String.Empty Then
                Return False
            End If
            .loai = IIf(Optloai(1).Checked, 1, 2)
            .chucvu = ConvertToDblSafe(txtVT(1).Text)
            .Trachnhiem = ConvertToDblSafe(txtVT(2).Text)
            .Luudong = ConvertToDblSafe(txtVT(3).Text)
            .Ghichu1 = "..."
            .Khac1 = ConvertToDblSafe(txtVT(5).Text)
            If ChkGiamtru.CheckState Then
                .Tamung = ConvertToDblSafe(txtVT(14).Text)
                .Trukhac = ConvertToDblSafe(txtVT(4).Text)
                .Trukhac1 = ConvertToDblSafe(txtVT(15).Text)
                .Trukhac2 = ConvertToDblSafe(txtVT(16).Text)
            Else
                .Tamung = 0
                .Trukhac = 0
                .Trukhac1 = 0
            End If
            If Chloai.CheckState = CheckState.Checked Then
                .Ghichu2 = txtVT(6).Text
                .Khac2 = ConvertToDblSafe(txtVT(7).Text)
                .Ghichu3 = txtVT(8).Text
                .Khac3 = ConvertToDblSafe(txtVT(9).Text)
                .Ghichu4 = txtVT(10).Text
                .Khac4 = ConvertToDblSafe(txtVT(11).Text)
                .Ghichu5 = txtVT(12).Text
                .Khac5 = ConvertToDblSafe(txtVT(13).Text)
            Else
                .Ghichu2 = "..."
                .Khac2 = 0
                .Ghichu3 = "..."
                .Khac3 = 0
                .Ghichu4 = "..."
                .Khac4 = 0
                .Ghichu5 = "..."
                .Khac5 = 0
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
    Private Sub Optloai_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Optloai_1.CheckedChanged, _Optloai_2.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            If Optloai(1).Checked Then
                Frame1.Text = " Hệ Số Phụ cấp "
            Else
                Frame1.Text = " Định mức phụ cấp "
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
        Dim sql As String = String.Format("SELECT DISTINCT Top 1 sohieu AS F1 FROM quanlynhanvien WHERE MaSo>{0}", MaDaTim)
        If SSOpt(0).Checked Then sql = String.Format("{0} AND sohieu LIKE '{1}%'", sql, txtF.Text)
        If SSOpt(1).Checked Then sql = String.Format("{0} AND ten LIKE '%{1}%'", sql, txtF.Text)
        sql = ConvertToStrSafe(GetSelectValue(sql))
        If sql <> "0" Then
            onv.InitNVSoHieuNhanvien1(sql)
            ChonNV(sql)
            MaDaTim = onv.maso
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
    Private Sub txtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_4.Enter, _txtVT_14.Enter, _txtVT_15.Enter, _txtVT_16.Enter, _txtVT_13.Enter, _txtVT_12.Enter, _txtVT_11.Enter, _txtVT_10.Enter, _txtVT_3.Enter, _txtVT_2.Enter, _txtVT_1.Enter, _txtVT_9.Enter, _txtVT_8.Enter, _txtVT_7.Enter, _txtVT_6.Enter, _txtVT_5.Enter, _txtVT_0.Enter
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        txtVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtVT_4.KeyPress, _txtVT_14.KeyPress, _txtVT_15.KeyPress, _txtVT_16.KeyPress, _txtVT_13.KeyPress, _txtVT_12.KeyPress, _txtVT_11.KeyPress, _txtVT_10.KeyPress, _txtVT_3.KeyPress, _txtVT_2.KeyPress, _txtVT_1.KeyPress, _txtVT_9.KeyPress, _txtVT_8.KeyPress, _txtVT_7.KeyPress, _txtVT_6.KeyPress, _txtVT_5.KeyPress, _txtVT_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        If Index = 0 Then
            If KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
        End If
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
    Private Sub txtVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_4.Leave, _txtVT_14.Leave, _txtVT_15.Leave, _txtVT_16.Leave, _txtVT_13.Leave, _txtVT_12.Leave, _txtVT_11.Leave, _txtVT_10.Leave, _txtVT_3.Leave, _txtVT_2.Leave, _txtVT_1.Leave, _txtVT_9.Leave, _txtVT_8.Leave, _txtVT_7.Leave, _txtVT_6.Leave, _txtVT_5.Leave, _txtVT_0.Leave
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        If Index = 15 Or Index = 16 Or Index = 4 Or Index = 14 Or Index = 1 Or Index = 2 Or Index = 3 Or Index = 5 Or Index = 7 Or Index = 9 Or Index = 11 Or Index = 13 Then
            txtVT(Index).Text = Format(txtVT(Index).Text, Mask_2)
            If Strings.Len(txtVT(Index).Text) = 0 Then txtVT(Index).Text = Format(0, Mask_2)
        Else
            If Strings.Len(txtVT(Index).Text) = 0 Then txtVT(Index).Text = "..."
        End If
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} %  10 AS F1 FROM License", CboThang.SelectedIndex))) > 0 Then
                Command(1).Enabled = False
                Command(2).Enabled = False
            End If
        End If
    End Sub

    Private Sub ChkGiamtru_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGiamtru.CheckedChanged
        If ChkGiamtru.Checked = True Then
            txtVT(14).ReadOnly = False
            txtVT(15).ReadOnly = False
            txtVT(4).ReadOnly = False
            txtVT(14).Text = 0
            txtVT(15).Text = 0
            txtVT(4).Text = 0
        Else
            txtVT(14).ReadOnly = True
            txtVT(15).ReadOnly = True
            txtVT(4).ReadOnly = True
        End If
    End Sub

    Private Sub Chloai_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chloai.CheckedChanged
        If Chloai.Checked = True Then
            For i As Integer = 6 To 13
                txtVT(i).Text = "..."
                txtVT(i).ReadOnly = False
            Next
        Else
            For j As Integer = 6 To 13
                'txtVT(i).ReadOnly = Not Chloai.CheckState
                txtVT(j).ReadOnly = True
            Next
        End If
    End Sub
End Class
