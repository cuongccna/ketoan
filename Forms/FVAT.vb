Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FVAT
    Dim Ngay, Ngayhd As Date
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
    Private Sub ChkV_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _ChkV_6.CheckStateChanged, _ChkV_7.CheckStateChanged, _ChkV_4.CheckStateChanged, _ChkV_3.CheckStateChanged, _ChkV_2.CheckStateChanged, _ChkV_0.CheckStateChanged, _ChkV_1.CheckStateChanged, _ChkV_5.CheckStateChanged, _ChkV_8.CheckStateChanged
        Dim Index As Integer = Array.IndexOf(ChkV, eventSender)
        Select Case Index
            Case 6, 7
                Label1(8).Visible = ChkV(6).CheckState = CheckState.Checked Or ChkV(7).CheckState = CheckState.Checked
                T(4).Visible = ChkV(6).CheckState = CheckState.Checked Or ChkV(7).CheckState = CheckState.Checked
            Case 4
                T(11).Enabled = ChkV(4).CheckState = CheckState.Checked
            Case 8
                Me.llink_chitiet.Visible = ChkV(4).CheckState = CheckState.Checked
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Command.Click
        'Dim i As Integer
        If KHDetail And ckh.MaSo = 0 And Strings.Left(T(0).Text, 1) = "#" Then
            ckh.Ten = T(7).Text
            ckh.DiaChi = T(8).Text
            ckh.mst = T(9).Text
            ckh.SoHieu = "#" & DateTime.Today.Year - 2000 & ConvertToStrSafe(DateTime.Today.Month) & ConvertToStrSafe(DateAndTime.Day(DateTime.Today)) & ConvertToStrSafe(DateAndTime.Hour(DateTime.Now)) & ConvertToStrSafe(DateTime.Now.Minute) & ConvertToStrSafe(DateTime.Now.Second)
            ckh.MaPhanLoai = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM PhanLoaiKhachHang WHERE LEFT(SoHieu,1)='#'"))
            If ckh.GhiKhachHang() <> 0 Then GoTo Er
        End If
        If KHDetail And ckh.MaSo = 0 Then
Er:
            T(0).Focus()
            Exit Sub
        End If
        With stuHoadon
            .MaKhachHang = ckh.MaSo
            .KyHieu = IIf(Strings.Len(T(1).Text) > 0, T(1).Text, "...")
            .sohd = IIf(Strings.Len(T(2).Text) > 0, T(2).Text, "...")
            .NgayPH = Ngay
            .MatHang = IIf(Strings.Len(T(3).Text) > 0, T(3).Text, "...")
            .soluong = ConvertToDblSafe(T(4).Text)
            .ThanhTien = ConvertToDblSafe(T(5).Text)
            .TyLe = ConvertToDblSafe(T(6).Text)
            .HD = ChkV(0).CheckState
            .KCT = ChkV(1).CheckState
            .HDBL = ChkV(2).CheckState
            .NLTS = ChkV(6).CheckState
            .dn = ChkV(7).CheckState
            .NK = ChkV(3).CheckState
            .ts = ChkV(4).CheckState
            .DC = ChkV(5).CheckState
            .TenKH = T(7).Text
            .DiaChiKH = T(8).Text
            .MSTKH = T(9).Text
            .HTTT = IIf(Strings.Len(T(11).Text) > 0, T(11).Text, "...")
            .MauSo = T(12).Text
            .KyHieuMau = T(21).Text
            .tygia = ConvertToDblSafe(T(13).Text)
            .sohopdong = T(14).Text
            .Ngayhopdong = Ngayhd
            .diadiemgiaohang = T(16).Text
            .diadiemnhanhang = T(17).Text
            .sovandon = T(18).Text
            .socontainer = T(19).Text
            .tenvanchuyen = T(20).Text
            .SoLo = T(22).Text
            .HanDung = T(23).Text
        End With
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FVAT_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.G
                    Command.Focus()
                    ' Command_ClickEvent(Command, New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FVAT_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            If Not KHDetail Then
                T(0).Enabled = False
                For i As Integer = 7 To 9
                    T(i).ReadOnly = False
                    T(i).TabStop = True
                Next
            End If
            If Strings.Left(FrmChungtu.txtchungtu(0).Text, 3) = "133" Or Strings.Left(FrmChungtutonghop.txtchungtu(0).Text, 3) = "133" Then
                Label1(12).Enabled = False
                Label1(17).Enabled = False
                Label1(18).Enabled = False
                Label1(19).Enabled = False
                Label1(21).Enabled = False
                Label1(22).Enabled = False
                Label1(23).Enabled = False
                T(14).Enabled = False
                T(16).Enabled = False
                T(17).Enabled = False
                T(18).Enabled = False
                T(19).Enabled = False
                T(20).Enabled = False
                MedNgayhd.Enabled = False
            End If
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
    Private Sub FVAT_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        ckh = Nothing
        MemoryHelper.ReleaseMemory()
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

    Private Sub MedNgay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MedNgay.GotFocus
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
            MedNgay.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgayhd_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgayhd.Enter
        MedNgayhd.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgayhd_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgayhd.Leave
        If Information.IsDate(MedNgayhd.Text) Then
            Ngayhd = ConvertToDateSafe(MedNgayhd.Text)
        Else
            MedNgayhd.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub T_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _T_20.Enter, _T_14.Enter, _T_19.Enter, _T_18.Enter, _T_17.Enter, _T_16.Enter, _T_11.Enter, _T_12.Enter, _T_4.Enter, _T_9.Enter, _T_8.Enter, _T_7.Enter, _T_6.Enter, _T_5.Enter, _T_3.Enter, _T_2.Enter, _T_1.Enter, _T_0.Enter, _T_13.Enter, _T_10.Enter, _T_15.Enter, _T_23.Enter, _T_22.Enter, _T_23.Enter, _T_23.Enter
        Dim Index As Integer = Array.IndexOf(T, eventSender)
        T(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub T_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _T_20.KeyPress, _T_14.KeyPress, _T_19.KeyPress, _T_18.KeyPress, _T_17.KeyPress, _T_16.KeyPress, _T_11.KeyPress, _T_12.KeyPress, _T_4.KeyPress, _T_9.KeyPress, _T_8.KeyPress, _T_7.KeyPress, _T_6.KeyPress, _T_5.KeyPress, _T_3.KeyPress, _T_2.KeyPress, _T_1.KeyPress, _T_0.KeyPress, _T_13.KeyPress, _T_10.KeyPress, _T_15.KeyPress, _T_23.KeyPress, _T_22.KeyPress, _T_23.KeyPress, _T_23.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(T, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 13 And KHDetail Then
                    T(0).Text = FrmKhachHang.ChonKhachHang(T(0).Text)
                    T(0).Focus()
                End If
            Case 4, 5, 6, 13
                KeyProcess(T(Index), KeyAscii)
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
    Private Sub T_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _T_14.Leave, _T_19.Leave, _T_18.Leave, _T_17.Leave, _T_16.Leave, _T_11.Leave, _T_12.Leave, _T_4.Leave, _T_9.Leave, _T_8.Leave, _T_7.Leave, _T_6.Leave, _T_5.Leave, _T_3.Leave, _T_2.Leave, _T_1.Leave, _T_0.Leave, _T_13.Leave, _T_10.Leave, _T_15.Leave, _T_20.Leave, _T_22.Leave, _T_23.Leave
        Try
            Dim Index As Integer = Array.IndexOf(T, eventSender)
            If Index = 0 Or Index = 1 Or Index = 12 Then T(Index).Text = T(Index).Text.ToUpper()
            Select Case Index
                Case 0
                    If KHDetail And Strings.Left(T(0).Text, 1) = "#" Then
                        For i As Integer = 7 To 9
                            T(i).ReadOnly = False
                            T(i).TabStop = True
                            T(i).Enabled = True
                        Next
                        ckh.InitKhachHangMaSo(0)
                        T(7).Focus()
                    Else
                        If KHDetail Then
                            ckh.InitKhachHangSohieu(T(0).Text)
                            T(7).Text = ckh.Ten
                            T(8).Text = ckh.DiaChi
                            T(9).Text = ckh.mst
                            If Strings.Len(T(1).Text) = 0 And ckh.MaSo > 0 Then T(1).Text = ConvertToStrSafe(GetSelectValue("SELECT Top 1 KyHieu AS F1 FROM HoaDon WHERE MaKhachHang=" & ckh.MaSo & " ORDER BY MaSo DESC"))
                        End If
                    End If
                Case 4
                    T(Index).Text = Format(T(Index).Text, Mask_2)
                Case 5, 6, 13
                    T(Index).Text = Format(T(Index).Text, Mask_0)
                Case 7, 8, 9, 11, 22, 23
                    If Strings.Len(T(Index).Text) = 0 Then T(Index).Text = "..."
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ttdb"></param>
    ''' <remarks></remarks>
    Public Sub GetPhieu(ByRef ttdb As Boolean)
        ckh.InitKhachHangMaSo(stuHoadon.MaKhachHang)
        T(0).Text = ckh.SoHieu
        T(7).Text = ckh.Ten
        T(8).Text = ckh.DiaChi
        T(9).Text = ckh.mst
        T(1).Text = stuHoadon.KyHieu
        T(21).Text = stuHoadon.KyHieuMau
        T(22).Text = stuHoadon.SoLo
        T(23).Text = stuHoadon.HanDung
        T(2).Text = stuHoadon.sohd
        If stuHoadon.ThanhTien <> 0 Then T(5).Text = Format(stuHoadon.ThanhTien, Mask_0)
        T(3).Text = stuHoadon.MatHang
        T(4).Text = Format(stuHoadon.soluong, Mask_2)
        T(6).Text = ConvertToStrSafe(Math.Abs(stuHoadon.TyLe))
        T(11).Text = stuHoadon.HTTT
        T(12).Text = stuHoadon.MauSo
        T(13).Text = Format(stuHoadon.tygia, Mask_0)
        Ngay = stuHoadon.NgayPH
        MedNgay.Text = Format(Ngay, Mask_D)
        ChkV(0).CheckState = stuHoadon.HD
        ChkV(2).CheckState = stuHoadon.HDBL
        ChkV(6).CheckState = stuHoadon.NLTS
        ChkV(7).CheckState = stuHoadon.dn
        ChkV(1).CheckState = stuHoadon.KCT
        ChkV(1).Enabled = (stuHoadon.TyLe = 0)
        ChkV(3).Visible = (stuHoadon.loai = -1)
        ChkV(4).Visible = (stuHoadon.loai = -1)
        ChkV(3).CheckState = stuHoadon.NK
        ChkV(4).CheckState = stuHoadon.ts
        ChkV(5).CheckState = stuHoadon.DC
        T(14).Text = stuHoadon.sohopdong
        Ngayhd = stuHoadon.Ngayhopdong
        MedNgayhd.Text = Format(Ngayhd, Mask_D)
        T(16).Text = stuHoadon.diadiemgiaohang
        T(17).Text = stuHoadon.diadiemnhanhang
        T(18).Text = stuHoadon.sovandon
        T(19).Text = stuHoadon.socontainer
        T(20).Text = stuHoadon.tenvanchuyen
        If ttdb Then
            If stuHoadon.ThanhTien <> 0 Then
                T(10).Text = Format(stuHoadon.ThanhTien, Mask_0)
                T(5).Text = Format(ConvertToStrSafe(Me.Tag), Mask_0)
            End If
        Else
            If stuHoadon.ThanhTien <> 0 Then T(5).Text = Format(stuHoadon.ThanhTien, Mask_0)
        End If
        Label1(16).Visible = ttdb
        T(10).Visible = ttdb
        ChkV(0).Enabled = Not ttdb
        ChkV(2).Enabled = Not ttdb
        If CPGV.Visible = True And CPGV.Tag = 0 Then
            ChkV(3).CheckState = CheckState.Checked
            If Strings.Left(FrmChungtu.txtchungtu(0).Text, 4) = "3332" Then
                Text = Text + " tiêu thụ đặc biệt"
                If CPGV.thuedacbiet <> 0 Then T(5).Text = Format(CPGV.thuedacbiet, Mask_0)
            Else
                Text = Text + " giá trị gia tăng"
                If CPGV.tien <> 0 Then T(5).Text = Format(CPGV.tien, Mask_0)
            End If
        ElseIf CPGV.Visible = True And CPGV.Tag = 1 Then
            Text = Text + " giá trị gia tăng"
            If CPGV.tien <> 0 Then T(5).Text = Format(CPGV.tien, Mask_0)
        Else
            Text = Text + " giá trị gia tăng"
        End If
        Me.ShowDialog()
    End Sub

    Private Sub MedNgay_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MedNgay.MaskInputRejected

    End Sub
End Class
