Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmKC
    Dim ThemMoi As Integer
    Private _oTaikhoan As ClsTaikhoan = Nothing
    Property oTaikhoan() As ClsTaikhoan
        Get
            If _oTaikhoan Is Nothing Then
                _oTaikhoan = New ClsTaikhoan()
            End If
            Return _oTaikhoan
        End Get
        Set(ByVal Value As ClsTaikhoan)
            _oTaikhoan = Value
        End Set
    End Property
    '====================================================================================================
    ' Thêm, Ghi, Xóa nguyên tệ
    '====================================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                ThemMoi = 1
                txtNhap(0).Text = "0"
                For i As Integer = 1 To 3
                    txtNhap(i).Text = "..."
                Next
                txtNhap(0).Focus()
                Khoaquyen()
            Case 1
                For i As Integer = 2 To 3
                    If ConvertToDblSafe((txtNhap(i).Tag)) = 0 Then
                        txtNhap(i).Focus()
                        Exit Sub
                    End If
                Next
                Select Case ThemMoi
                    Case 0
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                        If ExecSQLNonQuery("UPDATE CTKetChuyen SET STT=" & txtNhap(0).Text & ",DienGiai=N'" & txtNhap(1).Text & "',TK1=N'" & txtNhap(2).Text & "',TK2=N'" & txtNhap(3).Text & "' WHERE STT=" & GrdNT.CtlText) <> 0 Then Exit Sub
                        For i As Integer = 0 To 3
                            GrdNT.Col = ConvertToDblSafe(i)
                            GrdNT.CtlText = txtNhap(i).Text
                        Next
                    Case 1
                        If ExecSQLNonQuery("INSERT INTO CTKetChuyen (MaSo,STT,DienGiai,TK1,TK2) VALUES (" & Lng_MaxValue("MaSo", "CTKetChuyen") + 1 & ", N'" & txtNhap(0).Text & "',N'" & txtNhap(1).Text & "',N'" & txtNhap(2).Text & "',N'" & txtNhap(3).Text & "')") <> 0 Then Exit Sub
                        GrdNT.AddItem(txtNhap(0).Text & Chr(9).ToString() & txtNhap(1).Text & Chr(9).ToString() & txtNhap(2).Text & Chr(9).ToString() & txtNhap(3).Text & Chr(9).ToString() & ConvertToStrSafe(Lng_MaxValue("MaSo", "CTKetChuyen")), InsertGridRow(GrdNT, 0, txtNhap(0).Text))
                        ThemMoi = 0
                        GrdNT.Row = ConvertToDblSafe(GrdNT.Rows - 1)
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then GrdNT.RemoveItem(GrdNT.Row)
                        GrdNT.Row = 0
                        KiemTra()
                End Select
            Case 2
                GrdNT.Col = 0
                If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                If ExecSQLNonQuery("DELETE FROM CTKetChuyen WHERE STT=" & GrdNT.CtlText) <> 0 Then Exit Sub
                GrdNT.RemoveItem(GrdNT.Row)
                If GrdNT.Rows < ConvertToDblSafe(GrdNT.Tag) Then GrdNT.Rows = ConvertToDblSafe(GrdNT.Tag)
            Case 3
                Me.Close()
            Case 4
                GrdNT.Col = 0
                If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                'Load FrmMauKC
                With FrmMauKC
                    GrdNT.Col = 4
                    .Tag = ConvertToStrSafe(ConvertToDblSafe(GrdNT.CtlText))
                    GrdNT.Col = 1
                    .TK(2).Text = GrdNT.CtlText
                    GrdNT.Col = 2
                    oTaikhoan.InitTaikhoanSohieu(GrdNT.CtlText)
                    .TK(0).Text = oTaikhoan.sohieu & " - " & oTaikhoan.ten
                    .TK(0).Tag = ConvertToStrSafe(oTaikhoan.maso)
                    GrdNT.Col = 3
                    oTaikhoan.InitTaikhoanSohieu(GrdNT.CtlText)
                    .TK(1).Text = oTaikhoan.sohieu & " - " & oTaikhoan.ten
                    .TK(1).Tag = ConvertToStrSafe(oTaikhoan.maso)
                    .ShowDialog()
                End With
        End Select
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
    Private Sub FrmKC_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    'Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    '====================================================================================================
    ' Khởi tạo cửa sổ
    '====================================================================================================
    Private Sub FrmKC_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdNT, 0, 465, 2)
            ColumnSetUp(GrdNT, 1, 5020, 0)
            ColumnSetUp(GrdNT, 2, 1300, 0)
            ColumnSetUp(GrdNT, 3, 1265, 0)
            ColumnSetUp(GrdNT, 4, 1, 0)
            Text = SetFormTitle(Text)
            LietKeNgte()
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
    Private Sub GrdNT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNT.Click
        'SendKeys.SendWait("{Home}")
        SetGridIndex(GrdNT, GrdNT.Row)
        With GrdNT
            .Col = 0
            If .CtlText.length = 0 Then Exit Sub
            For i As Integer = 0 To 3
                .Col = ConvertToDblSafe(i)
                txtNhap(i).Text = .CtlText
            Next
            ThemMoi = 0
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdNT.KeyPress
        SendKeys.SendWait("{Home}")
        SetGridIndex(GrdNT, GrdNT.Row)
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdNT.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdNT, GrdNT.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_3.Enter, _txtNhap_2.Enter, _txtNhap_1.Enter, _txtNhap_0.Enter
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        txtNhap(Index).SelectAll()
    End Sub
    '====================================================================================================
    ' Hiển thị danh sách nguyên tệ
    '====================================================================================================
    Private Sub LietKeNgte()
        Dim rs_ngte As DataTable = ExecSQLReturnDT("SELECT * FROM CTKetChuyen ORDER BY STT DESC")
        Dim rs_ngteIndex As Integer = 0
        Do While rs_ngteIndex < rs_ngte.Rows.Count
            Dim rs_ngteItem As DataRow = rs_ngte.Rows(rs_ngteIndex)
            rs_ngteIndex += 1 ' C15 Rs LOOP CONTROL
            GrdNT.AddItem(String.Format("{0}{1}{2}{3}{2}{4}{2}{5}", _
                              (String.Format("{0}{1}{2}", (IIf(ConvertToStrSafe(rs_ngteItem("stt")) < 10, "0", String.Empty)), ConvertToStrSafe(rs_ngteItem("stt")), Chr(9))), _
                              ConvertToStrSafe(rs_ngteItem("DienGiai")), _
                              Chr(9), _
                              ConvertToStrSafe(rs_ngteItem("Tk1")), _
                              ConvertToStrSafe(rs_ngteItem("Tk2")), _
                              rs_ngteItem("MaSo")), 0)
            'rs_ngte.MoveNext()
        Loop
        GrdNT.Rows = IIf(rs_ngte.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_ngte.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        GrdNT.Col = 0
        ''rs_ngte.Close()
        rs_ngte = Nothing
        KiemTra()
        GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtNhap_3.KeyPress, _txtNhap_2.KeyPress, _txtNhap_1.KeyPress, _txtNhap_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        Select Case Index
            Case 0 : KeyProcess(txtNhap(Index), KeyAscii)
            Case 2, 3
                If KeyAscii = ConvertToDblSafe(Keys.Return) Then
                    Me.Cursor = Cursors.WaitCursor
                    txtNhap(Index).Text = FrmTaikhoan.ChonTk(txtNhap(Index).Text)
                    Me.Cursor = Cursors.Default
                    txtNhap_Leave(txtNhap(Index), New EventArgs())
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
    Private Sub txtNhap_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_3.Leave, _txtNhap_2.Leave, _txtNhap_1.Leave, _txtNhap_0.Leave
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        Select Case Index
            Case 0
                txtNhap(0).Text = Format(txtNhap(0).Text, Mask_0)
                If Strings.Len(txtNhap(0).Text) < 2 Then txtNhap(0).Text = "0" & txtNhap(0).Text
            Case 1
                If Strings.Len(txtNhap(Index).Text) = 0 Then txtNhap(Index).Text = "..."
            Case 2, 3
                If Strings.Len(txtNhap(Index).Text) = 0 Then
                    txtNhap(Index).Text = "..."
                Else
                    oTaikhoan.InitTaikhoanSohieu(txtNhap(Index).Text)
                    If oTaikhoan.maso > 0 Then
                        txtNhap(Index).Tag = ConvertToStrSafe(IIf(oTaikhoan.MaTC = 0 Or oTaikhoan.MaTC = oTaikhoan.maso, ConvertToDblSafe(oTaikhoan.sohieu), 0))
                    Else
                        txtNhap(Index).Tag = "0"
                    End If
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub KiemTra()
        Command(0).Enabled = ConvertToDblSafe(GetSelectValue("SELECT Count(MaSo) AS F1 FROM CTKetChuyen")) < MaxKC
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmKC_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
