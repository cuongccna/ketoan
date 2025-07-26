Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FThuChi

    Dim s(5) As String
    Private _kh As clsKhachHang = Nothing
    Private Ngay As Date
    Private f1, loaiin As Integer
    Private inhd, xanh, tim, Den, hong, xanhnoidia As Boolean
    Property kh() As clsKhachHang
        Get
            If _kh Is Nothing Then
                _kh = New clsKhachHang()
            End If
            Return _kh
        End Get
        Set(ByVal Value As clsKhachHang)
            _kh = Value
        End Set
    End Property
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        If Strings.Len(txtshkh.Text) <> 0 And txtshkh.Text <> "..." Then kh.InitKhachHangSohieu(txtshkh.Text)
        If kh.MaSo <> 0 Then
            T(0).Text = kh.Ten : T(1).Text = kh.DiaChi
        End If
        For i As Integer = 0 To 5
            s(i) = T(i).Text
        Next
        Den = ChkNT(0).CheckState = CheckState.Checked
        tim = ChkNT(1).CheckState = CheckState.Checked
        hong = ChkNT(2).CheckState = CheckState.Checked
        xanh = ChkNT(3).CheckState = CheckState.Checked
        xanhnoidia = ChkNT(4).CheckState = CheckState.Checked
        Me.Close()
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        OptHD(0).Visible = False
        OptHD(1).Visible = False
        OptHD(2).Visible = False
        'T(2).Font = VB6.FontChangeSize(T(2).Font, 8)
        T(2).Width = 2415
        If ConvertToDblSafe(Me.Tag) > 0 Then
            f1 = ConvertToDblSafe(Me.Tag)
            Select Case f1
                Case 1
                    Label1(0).Text = Ngonngu("Tên người nhận tiền:", "Collector: ")
                    Label1(1).Text = Ngonngu("Địa chỉ người nhận tiền:", "Address:")
                Case 2
                    If pNN = 1 Then
                        Me.Text = "Spending Credentials"
                    Else
                        Me.Text = "Giấy Uỷ nhiệm chi"
                    End If
                    Label1(0).Text = Ngonngu("Tên đơn vị nhận tiền:", "Unit collection")
                    Label1(1).Text = Ngonngu("Số tài khoản:", "Acount No.:")
                    Label1(2).Text = Ngonngu("Tại Ngân hàng:", "At Bank:")
                    T(2).Width = 7215
                    T(0).MaxLength = 50
                    T(2).MaxLength = 50
                Case 3
                    Me.Text = Ngonngu("Hoá đơn bán hàng", "Invoice of Sale")
                    Label1(0).Text = Ngonngu("Tên người mua hàng:", "Customer:")
                    Label1(1).Text = Ngonngu("Địa chỉ:", "Addesss:")
                    Label1(2).Text = Ngonngu("Hạn thanh toán:", "Times ofPayment:")
                    Label1(3).Text = Ngonngu("Số phiếu đặt hàng:", "Vote ordered No.:")
                    T(2).Visible = False
                    T(3).Visible = True
                    txtshkh.Visible = False
                    cmdkh.Visible = False
                    lbkh.Visible = False
                    MedNgay.Visible = True
                    OptHD(0).Visible = True
                    OptHD(1).Visible = True
                    OptHD(2).Visible = True
                    '                Label1(1).Visible = False
                    '                Label1(2).Visible = False
                    '                Label1(3).Visible = False
                    '                T(1).Visible = False
                    '                T(3).Visible = False
                    '                MedNgay.Visible = False
                    '                opthd(1).Visible = False
                Case 10
                    Me.Text = Ngonngu("Thông tin báo cáo", "Information reports")
                    Label1(0).Text = Ngonngu("Người lập biểu:", "Writer")
                    Label1(1).Text = Ngonngu("Kế toán trưởng:", "Chief accountant")
                    Label1(2).Text = Ngonngu("Giám đốc:", "Director")
                    T(2).Width = 7215
                    Label1(3).Visible = False
                    txtshkh.Visible = False
                    cmdkh.Visible = False
                    lbkh.Visible = False
                    MedNgay.Visible = False
            End Select
            Me.Tag = "0"
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FThuChi_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()
            ' mac dinh la hoa don dat in
            OptHD(0).Checked = True

            For i As Integer = 0 To 4
                s(i) = "..."
            Next
            Ngay = CDate("01/01/1900")
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
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean

    Private Sub OptHD_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptHD_0.CheckedChanged, _OptHD_1.CheckedChanged, _OptHD_2.CheckedChanged
        Dim Index As Integer = Array.IndexOf(OptHD, eventSender)
        loaiin = Index + 1
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub T_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _T_4.Enter, _T_3.Enter, _T_2.Enter, _T_1.Enter, _T_0.Enter, _T_5.Enter
        Dim Index As Integer = Array.IndexOf(T, eventSender)
        T(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub T_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _T_4.Leave, _T_3.Leave, _T_2.Leave, _T_1.Leave, _T_0.Leave, _T_5.Leave
        Dim Index As Integer = Array.IndexOf(T, eventSender)
        If Strings.Len(T(Index).Text) = 0 Then T(Index).Text = "..."
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="s1"></param>
    ''' <param name="s2"></param>
    ''' <param name="s3"></param>
    ''' <param name="makh"></param>
    ''' <param name="d"></param>
    ''' <param name="s4"></param>
    ''' <param name="s5"></param>
    ''' <param name="S6"></param>
    ''' <param name="S7"></param>
    ''' <param name="S8"></param>
    ''' <param name="s9"></param>
    ''' <param name="s10"></param>
    ''' <param name="S11"></param>
    ''' <param name="MaCT"></param>
    ''' <param name="vao"></param>
    ''' <param name="thang"></param>
    ''' <param name="thuchi"></param>
    ''' <param name="SodongHD"></param>
    ''' <remarks></remarks>
    Public Shared hinhthuc As String = ""
    Public Sub GetPhieu(ByRef s1 As String, ByRef s2 As String, ByRef s3 As String, ByRef makh As Integer, Optional ByRef d As Date = #12/30/1899#, Optional ByRef s4 As String = "", Optional ByRef s5 As Boolean = False, Optional ByRef S6 As Boolean = False, Optional ByRef S7 As Boolean = False, Optional ByRef S8 As Boolean = False, Optional ByRef s9 As Boolean = False, Optional ByRef s10 As Boolean = False, Optional ByRef S11 As Integer = 1, Optional ByRef MaCT As Integer = 0, Optional ByRef vao As Double = 0, Optional ByRef thang As Integer = 0, Optional ByRef thuchi As String = "", Optional ByRef SodongHD As Integer = 1)
        kh.InitKhachHangMaSo(makh)
        '    T(0).Text = s1
        T(1).Text = s2
        T(2).Text = s3
        T(3).Text = s4
        If S11 > 0 Then OptHD(S11 - 1).Checked = True
        Dim MaTC As String = String.Empty
        Dim stt As Integer
        Dim thang1 As String = (IIf(thang < 10, "0", String.Empty)) & ConvertToStrSafe(thang)
        If MaCT = 0 Then
            MaTC = ConvertToStrSafe(GetSelectValue("SELECT max(mathuchi) as f1 FROM chungtu WHERE mathuchi like 'P" & (IIf(vao > 0, "T", "C")) & thang1 & "%'"))
            If MaTC.Length = 7 Then
                stt = ConvertToDblSafe(Strings.Right(MaTC, 3)) + 1
                MaTC = Strings.Left(MaTC, 4) & (IIf(stt < 10, "00", (IIf(stt < 100, "0", String.Empty)))) & ConvertToStrSafe(stt)
            Else
                MaTC = "P" & (IIf(vao > 0, "T", "C")) & thang1 & "001"
            End If
            T(4).Text = MaTC
        Else
            T(4).Text = ConvertToStrSafe(GetSelectValue("SELECT mathuchi as f1 FROM chungtu WHERE mact=" & MaCT))
        End If
        txtshkh.Text = kh.SoHieu
        lbkh.Text = kh.Ten
        Ngay = d
        If d.Year > 1900 Then MedNgay.Text = Format(d, Mask_D)
        inhd = s10
        Me.ShowDialog()
        s1 = s(0)
        s2 = s(1)
        s3 = s(2)
        s4 = s(3)
        thuchi = s(4)
        s5 = Den
        S6 = tim
        S7 = hong
        S8 = xanh
        s9 = xanhnoidia
        S11 = loaiin
        'hinhthuc = txt_hinhthucthanhtoan.Text
        makh = kh.MaSo
        d = Ngay
        SodongHD = ConvertToDblSafe(s(5))
        kh = Nothing
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FThuChi_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.G
                    Command.Focus()
                    'Command_ClickEvent(Command, New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command, New EventArgs())
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
        Dim xxx As String = String.Empty
        Dim i As Integer
        kh.InitKhachHangSohieu(txtshkh.Text)
        lbkh.Text = kh.Ten
        '    If Len(T(0).Text) = 0 Or T(0).Text = "..." Then T(0).Text = kh.ten
        T(0).Text = kh.Ten
        Select Case f1
            Case 0, 1
                '            If (Len(T(1).Text) = 0 Or T(1).Text = "...") And kh.DiaChi <> "..." Then T(1).Text = kh.DiaChi
                T(1).Text = kh.DiaChi
            Case 2
                xxx = LaySH(kh.taikhoan, 1, "-").Trim()
                '            If (Len(T(1).Text) = 0 Or T(1).Text = "...") And IsNumeric(Left(xxx, 2)) Then T(1).Text = xxx
                T(1).Text = xxx
                i = kh.taikhoan.Length - xxx.Length
                If i > 0 Then
                    xxx = Strings.Right(kh.taikhoan, i - 1)
                    '                If (Len(T(2).Text) = 0 Or T(2).Text = "...") And Len(xxx) > 0 Then T(2).Text = xxx
                    T(2).Text = xxx
                End If
        End Select
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
        If MedNgay.Text <> "__/__/__" Then
            If Information.IsDate(MedNgay.Text) Then
                Ngay = ConvertToDateSafe(MedNgay.Text)
            Else
                MedNgay.Focus()
            End If
        Else
            Ngay = CDate("01/01/1900")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FThuChi_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub Command_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command.Click
        If Strings.Len(txtshkh.Text) <> 0 And txtshkh.Text <> "..." Then kh.InitKhachHangSohieu(txtshkh.Text)
        If kh.MaSo <> 0 Then
            If T(0).Text = "..." Or T(0).Text = "" Then T(0).Text = kh.Ten
            If T(1).Text = "..." Or T(1).Text = "" Then T(1).Text = kh.DiaChi
        End If
        For i As Integer = 0 To 5
            s(i) = T(i).Text
        Next
        Den = ChkNT(0).CheckState = CheckState.Checked
        tim = ChkNT(1).CheckState = CheckState.Checked
        hong = ChkNT(2).CheckState = CheckState.Checked
        xanh = ChkNT(3).CheckState = CheckState.Checked
        xanhnoidia = ChkNT(4).CheckState = CheckState.Checked
        hinhthuc = txt_hinhthucthanhtoan.Text
        If OptHD(0).Checked Then
            loaiin = 1
        ElseIf OptHD(1).Checked Then
            loaiin = 2
        ElseIf OptHD(2).Checked Then
            loaiin = 3
        End If
        Me.Close()
    End Sub

    Private Sub txt_hinhthucthanhtoan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_hinhthucthanhtoan.LostFocus
        hinhthuc = txt_hinhthucthanhtoan.Text
    End Sub
End Class
