Imports System
Imports System.Text
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmPBCP

    Dim thang(11) As Integer
    Private isInitializingComponent As Boolean
    Private Sub ChkKC_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _ChkKC_7.CheckedChanged, _ChkKC_6.CheckedChanged, _ChkKC_5.CheckedChanged, _ChkKC_4.CheckedChanged, _ChkKC_3.CheckedChanged, _ChkKC_2.CheckedChanged, _ChkKC_0.CheckedChanged, _ChkKC_1.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(ChkKC, eventSender)
            Select Case Index
                Case 1
                    Opt(0).Enabled = False
                    If Opt(0).CheckState Then Opt(1).CheckState = CheckState.Checked
                    Opt(1).Enabled = True
                    Opt(2).Enabled = True
                    Opt(3).Enabled = True
                    Opt(4).Enabled = False
                Case 0, 2
                    Opt(0).Enabled = True
                    If Not Opt(0).CheckState Then Opt(0).CheckState = CheckState.Checked
                    Opt(1).Enabled = True
                    Opt(2).Enabled = True
                    Opt(3).Enabled = True
                    Opt(4).Enabled = True
                Case 4
                    Opt(0).Enabled = False
                    If Opt(0).CheckState Then Opt(1).CheckState = CheckState.Checked
                    Opt(1).Enabled = True
                    Opt(2).Enabled = False
                    If Opt(2).CheckState Then Opt(2).CheckState = CheckState.Unchecked
                    Opt(3).Enabled = True
                    Opt(4).Enabled = False
                Case 5
                    Opt(0).Enabled = False
                    If Opt(0).CheckState Then Opt(2).CheckState = CheckState.Checked
                    Opt(1).Enabled = False
                    If Opt(1).CheckState Then Opt(1).CheckState = CheckState.Unchecked
                    Opt(2).Enabled = True
                    Opt(3).Enabled = True
                    Opt(4).Enabled = False
                Case 6
                    Opt(0).Enabled = False
                    If Opt(0).CheckState Then Opt(1).CheckState = CheckState.Checked
                    Opt(1).Enabled = True
                    Opt(2).Enabled = True
                    Opt(3).Enabled = False
                    If Opt(3).CheckState Then Opt(3).CheckState = CheckState.Unchecked
                    Opt(4).Enabled = False
            End Select
        End If
    End Sub
    '====================================================================================================
    ' Thêm, Ghi, Xóa nguyên tệ
    '====================================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_1.Click, _Command_2.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim tc As Integer
        Dim sql As New StringBuilder
        If Cbo(1).Items.Count > 0 And Cbo(0).Items.Count > 0 Then If Cbo(1).SelectedIndex < Cbo(0).SelectedIndex Then Cbo(1).SelectedIndex = Cbo(0).SelectedIndex
        Dim tdau As Integer = Cbo(0).SelectedValue
        Dim tcuoi As Integer = Cbo(1).SelectedValue
        Select Case Index
            Case 0
                Command_ClickEvent(Command(3), New EventArgs)
                tc = 0
                For i As Integer = 0 To 4
                    If Opt(i).CheckState = CheckState.Checked Then tc += ConvertToDblSafe((Opt(i).Tag))
                Next
                Me.Cursor = Cursors.WaitCursor
                If ChkKC(0).Checked Then
                    PhanBoCP(tdau, tcuoi, "641", ("Chi phí bán hàng"), 4, ConvertToDblSafe(T.Text))
                    PhanBoCP64(tdau, tcuoi, tc, "641")
                End If
                If ChkKC(1).Checked Then
                    PhanBoCP(tdau, tcuoi, "627", ("Chi phí sản xuất chung"), tc, ConvertToDblSafe(T.Text))
                    If pDTTP <> 0 Then PhanBoCP2(tdau, tcuoi, tc)
                End If
                If ChkKC(2).Checked Then
                    PhanBoCP(tdau, tcuoi, "642", ("Chi phí quản lý doanh nghiệp"), 4, ConvertToDblSafe(T.Text))
                    PhanBoCP64(tdau, tcuoi, tc, "642")
                End If
                If ChkKC(3).Checked Then PhanBoCP(tdau, tcuoi, "142", ("Chi phí trả trước"), 4, ConvertToDblSafe(T.Text))
                If ChkKC(4).Checked Then
                    PhanBoCP(tdau, tcuoi, "622", ("Chi phí nhân công trực tiếp"), 4, ConvertToDblSafe(T.Text))
                    If pDTTP <> 0 Then PhanBoCP3(tdau, tcuoi, tc, "622")
                End If
                If ChkKC(5).Checked Then
                    PhanBoCP(tdau, tcuoi, "621", ("Chi phí nguyên vật liệu trực tiếp"), 4, ConvertToDblSafe(T.Text))
                    If pDTTP <> 0 Then PhanBoCP3(tdau, tcuoi, tc, "621")
                End If
                If ChkKC(6).Checked Then
                    PhanBoCP(tdau, tcuoi, "623", ("Chi phí máy thi công"), 4, ConvertToDblSafe(T.Text))
                    If pDTTP <> 0 Then PhanBoCP3(tdau, tcuoi, tc, "623")
                End If
                If ChkKC(7).Checked Then
                    PhanBoCP(tdau, tcuoi, "635", ("Chi phí tài chính"), 4, ConvertToDblSafe(T.Text))
                    PhanBoCP64(tdau, tcuoi, tc, "635")
                End If
                SetDBMonth()
            Case 1
                Me.Close() : Exit Sub
            Case 2
                If pDTTP = 0 Then GoTo kt
                If Cbo(0).SelectedIndex <> Cbo(1).SelectedIndex Then
                    FrmPBCT.Text = "Chi tiết tập hợp chi phí từ tháng " & Cbo(0).Text & " đến tháng " & Cbo(1).Text
                Else
                    FrmPBCT.Text = "Chi tiết tập hợp chi phí tháng " & Cbo(0).Text
                End If
                FrmPBCT.Tag = ConvertToStrSafe(100 * (tdau) + tcuoi)
                FrmPBCT.ShowDialog()
                If ConvertToDblSafe(Me.Tag) = 1 Then SetDBMonth()
            Case 3
                If pDTTP = 0 Then GoTo kt
                Me.Cursor = Cursors.WaitCursor
                sql = New StringBuilder("")
                For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
                    If ChkKC(0).Checked Then sql.Append(", CPBH" & i & "=0")
                    If ChkKC(1).Checked Then sql.Append(", CPSXC_" & i & "=0")
                    If ChkKC(2).Checked Then sql.Append(", CPQL" & i & "=0")
                    If ChkKC(3).Checked Then GoTo kt
                    If ChkKC(4).Checked Then sql.Append(", CPNCPB" & i & "=0")
                    If ChkKC(5).Checked Then sql.Append(", CPNVLPB" & i & "=0")
                    If ChkKC(6).Checked Then sql.Append(", CPMPB" & i & "=0")
                Next
                ExecSQLNonQuery("UPDATE TP154 SET DonVi=DonVi" & sql.ToString())
                sql = New StringBuilder("")
                If ChkKC(0).Checked Then sql.Append(", CPBH=0")
                If ChkKC(1).Checked Then sql.Append(", CPQL=0")
                If ChkKC(2).Checked Then sql.Append(", CPTC=0")
                ExecSQLNonQuery("UPDATE ThanhPham SET Thang=Thang" & sql.ToString() & " WHERE " & WThang("Thang", tdau, tcuoi))
        End Select
kt:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    '====================================================================================================
    ' Xử lý phím nóng
    '====================================================================================================
    Private Sub FrmPBCP_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.K
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    '====================================================================================================
    ' Khởi tạo cửa sổ
    '====================================================================================================
    Private Sub FrmPBCP_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            AddMonthToCbo(Cbo(0))
            AddMonthToCbo(Cbo(1))
            ChkKC_CheckedChanged(ChkKC(2), New EventArgs())
            Command(2).Enabled = (pDTTP <> 0)
            Command(3).Enabled = (pDTTP <> 0)
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
    Private Sub FrmPBCP_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        Dim tdau, tcuoi As Integer
        Me.Cursor = Cursors.WaitCursor
        For i As Integer = 1 To 12
            If thang(i - 1) = 1 Then
                tdau = CThangFR(i)
                Exit For
            End If
        Next
        For i As Integer = 12 To 1 Step -1
            If thang(i - 1) = 1 Then
                tcuoi = CThangFR(i)
                Exit For
            End If
        Next
        If tdau > 0 And tcuoi > 0 And pDTTP <> 0 Then TinhLaiGiaThanhPham(tdau, tcuoi)
        HienThongBao("", 1)
        Me.Cursor = Cursors.Default
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Opt_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Opt_4.CheckStateChanged, _Opt_3.CheckStateChanged, _Opt_2.CheckStateChanged, _Opt_1.CheckStateChanged, _Opt_0.CheckStateChanged
        Dim Index As Integer = Array.IndexOf(Opt, eventSender)
        Select Case Index
            Case 0
                If Opt(0).CheckState = CheckState.Checked Then
                    For i As Integer = 1 To 4
                        Opt(i).CheckState = CheckState.Unchecked
                    Next
                End If
            Case 1, 2, 3
                If Opt(Index).CheckState = CheckState.Checked Then
                    Opt(0).CheckState = CheckState.Unchecked
                    Opt(4).CheckState = CheckState.Unchecked
                End If
            Case 4
                If Opt(4).CheckState = CheckState.Checked Then
                    For i As Integer = 0 To 3
                        Opt(i).CheckState = CheckState.Unchecked
                    Next
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub T_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles T.Enter
        T.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub T_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles T.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        KeyProcess(T, KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetDBMonth()
        For i As Integer = Cbo(0).SelectedIndex + 1 To Cbo(1).SelectedIndex + 1
            thang(i - 1) = 1
        Next
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(3).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
End Class
