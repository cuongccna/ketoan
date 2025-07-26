Imports System
Imports System.Data
Imports System.Media
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class frmTangGiam
    Dim NG_NS As Double
    Dim NG_TBS As Double
    Dim NG_CNK As Double
    Dim NG_TD As Double
    Dim NS As Double
    Dim TBS As Double
    Dim CNK As Double
    Dim TD As Double
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    '======================================================================================
    ' FORM
    '======================================================================================
    ' KeyDown
    Private Sub frmTangGiam_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.G : Command(0).Focus() : Application.DoEvents() 'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V : Command(1).Focus() : Application.DoEvents() 'Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ' Load
    Private Sub frmTangGiam_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            'pTiepTucHoatDong = False
            ' Tính giá trị còn lại của tài sản theo tháng tác động (chưa trích khấu hao)
            TinhGiaTriTaiSan(pMaTaiSan, pThangTacDong, KH_KHONG)
            ' Hiển thị các thông tin
            With GiaTri
                ' Nguyên giá
                NG_NS = .NG_NS
                NG_TBS = .NG_TBS
                NG_TD = .NG_TD
                NG_CNK = .NG_CNK
                Label(9).Text = Format(.NG_NS, Mask_0)
                Label(10).Text = Format(.NG_TBS, Mask_0)
                Label(11).Text = Format(.NG_CNK, Mask_0)
                Label(42).Text = Format(.NG_TD, Mask_0)
                Label(8).Text = Format(.NG_NS + .NG_TBS + .NG_CNK + .NG_TD, Mask_0)
                ' Giá trị còn lại
                Label(32).Text = Format(.CL_NS, Mask_0)
                Label(31).Text = Format(.CL_TBS, Mask_0)
                Label(30).Text = Format(.CL_CNK, Mask_0)
                Label(24).Text = Format(.CL_TD, Mask_0)
                Label(33).Text = Format(.CL_NS + .CL_TBS + .CL_CNK + .CL_TD, Mask_0)
                ' Tổng hao mòn
                Label(12).Text = Format((.NG_NS + .NG_TBS + .NG_CNK + .NG_TD) - (.CL_NS + .CL_TBS + .CL_CNK + .CL_TD), Mask_0)
                Label(13).Text = Format(.NG_NS - .CL_NS, Mask_0)
                Label(14).Text = Format(.NG_TBS - .CL_TBS, Mask_0)
                Label(43).Text = Format(.NG_TD - .CL_TD, Mask_0)
                Label(15).Text = Format(.NG_CNK - .CL_CNK, Mask_0)
            End With
            NS = 0
            TBS = 0
            TD = 0
            CNK = 0
            XoaGiaTri() ' Biến chung GiaTri được khởi tạo lại để nhận thông tin
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '======================================================================================
    ' command
    '     - Nhận lượng tăng giảm giá trị
    '     - Thành lập các dòng phát sinh thể hiện nghiệp vụ
    '     - Ghi chứng từ tăng giảm
    '     - Cập nhật lại lượng khấu hao mới
    '======================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim sql As String = String.Empty
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0 ' Ghi
                If HopLe() = -1 Then GoTo XongTG
                ' Thành lập các dòng phát sinh thể hiện hoạt động tăng giảm
                sql = "SELECT MaTaiKhoan AS F1 FROM TaiSan WHERE MaSo = " & pMaTaiSan
                ThanhLapPhatSinh(NV_DGLAI, ConvertToDblSafe((GetSelectValue(sql))))
                ' Ghi chứng từ mới
                pGhichungtu = 1
                Me.Close()
                Exit Sub
            Case 1 ' Trở về
                SendKeys.Send("{Escape}")
        End Select
XongTG:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmTangGiam_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        If pGhichungtu = 0 Then XoaGiaTri()
        MemoryHelper.ReleaseMemory()
    End Sub
    '======================================================================================
    ' TEXT
    '======================================================================================
    ' GotFocus
    Private Sub Text_Renamed_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_0.Enter, _Text_1.Enter, _Text_2.Enter, _Text_3.Enter, _Text_4.Enter, _Text_5.Enter, _Text_6.Enter, _Text_7.Enter
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Text_Renamed(Index).SelectAll()
    End Sub
    ' KeyPress
    Private Sub Text_Renamed_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _Text_0.KeyPress, _Text_1.KeyPress, _Text_2.KeyPress, _Text_3.KeyPress, _Text_4.KeyPress, _Text_5.KeyPress, _Text_6.KeyPress, _Text_7.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        KeyProcess(Text_Renamed(Index), KeyAscii, True)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ' LostFocus
    Private Sub Text_Renamed_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_0.Leave, _Text_1.Leave, _Text_2.Leave, _Text_3.Leave, _Text_4.Leave, _Text_5.Leave, _Text_6.Leave, _Text_7.Leave
        Dim Err_DataTypeConvertion As Boolean = False
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Text_Renamed(Index).Text = Format(Text_Renamed(Index).Text, Mask_0)
        Try
            Err_DataTypeConvertion = True
            Select Case Index
                Case 0 : GiaTri.NG_NS = ConvertToDblSafe(Text_Renamed(0).Text)
                Case 1 : GiaTri.NG_TBS = ConvertToDblSafe(Text_Renamed(1).Text)
                Case 2 : GiaTri.NG_CNK = ConvertToDblSafe(Text_Renamed(2).Text)
                Case 3 : GiaTri.NG_TD = ConvertToDblSafe(Text_Renamed(3).Text)
                Case 4 : NS = ConvertToDblSafe(Text_Renamed(4).Text)
                Case 5 : TBS = ConvertToDblSafe(Text_Renamed(5).Text)
                Case 6 : CNK = ConvertToDblSafe(Text_Renamed(6).Text)
                Case 7 : TD = ConvertToDblSafe(Text_Renamed(7).Text)
            End Select
            Err_DataTypeConvertion = False
            With GiaTri
                GiaTri.CL_NS = GiaTri.NG_NS - NS
                GiaTri.CL_TBS = GiaTri.NG_TBS - TBS
                GiaTri.CL_CNK = GiaTri.NG_CNK - CNK
                GiaTri.CL_TD = GiaTri.NG_TD - TD
                ' Tổng biến động nguyên giá và khấu hao
                Label(16).Text = Format(.NG_NS + .NG_TBS + .NG_CNK + .NG_TD, Mask_0)
                Label(17).Text = Format(NS + TBS + CNK + TD, Mask_0)
                ' Lượng biến động tác động lên giá trị còn lại
                Label(40).Text = Format(.CL_NS, Mask_0)
                Label(39).Text = Format(.CL_TBS, Mask_0)
                Label(38).Text = Format(.CL_CNK, Mask_0)
                Label(35).Text = Format(.CL_TD, Mask_0)
                Label(41).Text = Format(.CL_NS + .CL_TBS + .CL_CNK + .CL_TD, Mask_0)
            End With
        Catch excep As System.Exception
            If Not Err_DataTypeConvertion Then
                Throw excep
            End If
            If Err_DataTypeConvertion Then
                Text_Renamed(Index).Focus()
            End If
        End Try
    End Sub
    '======================================================================================
    ' FUNCTION HopLe
    '======================================================================================
    Private Function HopLe() As Integer
        Dim result As Integer = 0
        Dim thong_bao As String = String.Empty
        With GiaTri
            If (.NG_NS = 0 And .NG_TBS = 0 And .NG_CNK = 0 And .NG_TD = 0) And (NS = 0 And TBS = 0 And CNK = 0 And TD = 0) Then
                thong_bao = "Không có biến động gì về giá trị tài sản" : GoTo Err_InValidate
            End If
            If (NG_NS = 0 And .NG_NS = 0 And NS <> 0) Or (NG_TBS = 0 And .NG_TBS = 0 And TBS <> 0) Or (NG_CNK = 0 And .NG_CNK = 0 And CNK <> 0) Or (NG_TD = 0 And .NG_TD = 0 And TD <> 0) Then
                thong_bao = "Lượng hao mòn chỉ có nếu tài sản có thành phần nguyên giá tương ứng" : GoTo Err_InValidate
            End If
            result = 0
        End With
        Return result
Err_InValidate:
        SystemSounds.Beep.Play()
        MessageBox.Show(thong_bao, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return -1
    End Function
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
    End Sub
End Class
