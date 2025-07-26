Imports System
Imports System.Data
Imports System.Media
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class frmDCPTung
    Private Const GRID_ROWS As Integer = 11
    Private Const GRID_COLS As Integer = 5
    Private Structure tpDCPTung
        Dim MaSo As Integer
        Dim MaTS As Integer
        Dim ten As String
        Dim DonVi As String
        Dim soluong As Double
        Dim GiaThanh As Double
        Public Shared Function CreateInstance() As tpDCPTung
            Dim result As New tpDCPTung
            result.ten = String.Empty
            result.DonVi = String.Empty
            Return result
        End Function
    End Structure
    Dim DCPTung As tpDCPTung = tpDCPTung.CreateInstance()
    ' Key Down
    Public flag As Boolean = False
    Private Sub frmDCPTung_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    Application.DoEvents()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                    flag = True
                Case Keys.G
                    Command(1).Focus()
                    Application.DoEvents()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                    flag = True
                Case Keys.X
                    Command(2).Focus()
                    Application.DoEvents()
                    '  Command_ClickEvent(Command(2), New EventArgs())
                    flag = True
                Case Keys.V
                    Command(3).Focus()
                    Application.DoEvents()
                    ' Command_ClickEvent(Command(3), New EventArgs())
                    flag = True
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then
            Me.Close()
            Me.Finalize()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmDCPTung_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Lưới Grid
            InitGrid(Grid, GRID_ROWS, GRID_COLS)
            ColumnSetUp(Grid, 0, 1, 0)
            ColumnSetUp(Grid, 1, 2390, 0)
            ColumnSetUp(Grid, 2, 830, 2)
            ColumnSetUp(Grid, 3, 830, 4)
            ColumnSetUp(Grid, 4, 1400, 4)
            'van.nguyen 30-11-2011
            ' Lấy danh sách đối tượng
            Dim sql As String = String.Format("SELECT * FROM DCPTung WHERE MaTS = {0} ORDER BY Ten", pMaTaiSan)
            Dim rs_dcptung As DataTable = ExecSQLReturnDT(sql)
            For Each rs_dcptungItem As DataRow In rs_dcptung.Rows
                Grid.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}", _
                                 rs_dcptungItem("MaSo"), _
                                 Chr(9), _
                                 ConvertToStrSafe(rs_dcptungItem("ten")), _
                                 ConvertToStrSafe(rs_dcptungItem("DonVi")), _
                                 Format(rs_dcptungItem("soluong"), Mask_2), _
                                 "", Format(rs_dcptungItem("GiaThanh"), Mask_0)), 0)
                'rs_dcptung.MoveNext()
            Next
            SetGridIndex(Grid, 0) ', GRID_ROWS, GRID_COLS
            ''rs_dcptung.Close()
            rs_dcptung = Nothing
            DCPTung.MaTS = pMaTaiSan
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    '======================================================================================
    ' GRID
    '======================================================================================
    ' Click
    Private Sub Grid_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grid.Click
        SendKeys.SendWait("{Home}")
        SetGridIndex(Grid, Grid.Row) ', GRID_ROWS, GRID_COLS
    End Sub
    ' Double Click
    Private Sub Grid_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grid.DoubleClick
        Grid.Col = 0
        If Strings.Len(Grid.CtlText) > 0 Then
            'DCPTung.MaSo = ConvertToDblSafe(Grid)
            Grid.Col = 1 : Text_Renamed(0).Text = Grid.CtlText
            Grid.Col = 2 : Text_Renamed(1).Text = Grid.CtlText
            Grid.Col = 3 : Text_Renamed(2).Text = Grid.CtlText
            Grid.Col = 4 : Text_Renamed(3).Text = Grid.CtlText
            Text_Renamed(0).Focus()
        Else
            DCPTung.MaSo = 0
        End If
    End Sub
    ' Got Focus
    Private Sub Grid_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grid.Enter
        KhoiTao(False)
    End Sub
    ' Key Down
    Private Sub Grid_KeyDownEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grid.KeyDown
        Select Case eventArgs.KeyCode
            Case ConvertToDblSafe(Keys.Home), ConvertToDblSafe(Keys.End), ConvertToDblSafe(Keys.Right), ConvertToDblSafe(Keys.Left)
            Case ConvertToDblSafe(Keys.Up) : SetGridIndex(Grid, Grid.Row - 1) ', GRID_ROWS, GRID_COLS
            Case ConvertToDblSafe(Keys.Down) : SetGridIndex(Grid, Grid.Row + 1) ', GRID_ROWS, GRID_COLS
            Case ConvertToDblSafe(Keys.PageUp) : SetGridIndex(Grid, Grid.Row - GRID_ROWS) ', GRID_ROWS, GRID_COLS
            Case ConvertToDblSafe(Keys.PageDown) : SetGridIndex(Grid, Grid.Row + GRID_ROWS) ', GRID_ROWS, GRID_COLS
            Case ConvertToDblSafe(Keys.Return) : Grid_DblClick(Grid, New EventArgs())
            Case ConvertToDblSafe(Keys.Delete) : Command_ClickEvent(Command(2), New EventArgs())
            Case Else : Exit Sub
        End Select
        'eventArgs.KeyCode  = 0
    End Sub
    '======================================================================================
    ' command
    '======================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Me.Cursor = Cursors.WaitCursor
        If flag = False Then
            Select Case Index
                Case 0 ' Míi
                    KhoiTao(True)
                Case 1 ' Ghi
                    If HopLe() = 0 Then
                        If DCPTung.MaSo = 0 Then
                            If ThemMoi() = 0 Then KhoiTao(True)
                        Else
                            If SuaDoi() = 0 Then KhoiTao(False)
                        End If
                    End If
                Case 2 ' Xoá
                    Grid.Col = 0 : If Strings.Len(Grid.CtlText) = 0 Then Exit Sub
                    If System.Windows.Forms.DialogResult.Yes = MessageBox.Show("Xoá đối tượng hiện tại", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                        If Xoa() = 0 Then KhoiTao(False)
                    End If
                Case 3 ' Trở về
                    SendKeys.Send("{Escape}")
            End Select
        Else
            flag = False
        End If

        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grid_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles Grid.MouseDown
        'If eventArgs.Button = 2 Then
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , Grid, Grid.Col)
        End If
    End Sub
    '======================================================================================
    ' TEXT
    '======================================================================================
    ' Got Focus
    Private Sub Text_Renamed_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_0.Enter, _Text_1.Enter, _Text_2.Enter, _Text_3.Enter
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Text_Renamed(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Text_Renamed_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _Text_0.KeyPress, _Text_1.KeyPress, _Text_2.KeyPress, _Text_3.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        If Index > 1 Then KeyProcess(Text_Renamed(Index), KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ' Lost Focus
    Private Sub Text_Renamed_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_0.Leave, _Text_1.Leave, _Text_2.Leave, _Text_3.Leave
        Dim Err_DataTypeConvertion As Boolean = False
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        If Strings.Len(Text_Renamed(Index).Text) = 0 Then
            If Index < 2 Then
                Text_Renamed(Index).Text = "(...)"
            Else
                Text_Renamed(Index).Text = "0"
            End If
        End If
        Try
            Err_DataTypeConvertion = True
            Select Case Index
                Case 0
                    DCPTung.ten = Text_Renamed(0).Text
                Case 1
                    DCPTung.DonVi = Text_Renamed(1).Text
                Case 2
                    DCPTung.soluong = ConvertToDblSafe(Text_Renamed(2).Text)
                Case 3
                    DCPTung.GiaThanh = ConvertToDblSafe(Text_Renamed(3).Text)
            End Select
            Err_DataTypeConvertion = False
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
    ' SUB HopLe
    '======================================================================================
    Private Function HopLe() As Integer
        Dim thong_bao As String = String.Empty
        If DCPTung.ten.Length = 0 Then Text_Renamed_Leave(Text_Renamed(0), New EventArgs())
        If DCPTung.DonVi.Length = 0 Then Text_Renamed_Leave(Text_Renamed(1), New EventArgs())
        If DCPTung.soluong = 0 Then Text_Renamed_Leave(Text_Renamed(2), New EventArgs())
        If DCPTung.GiaThanh = 0 Then Text_Renamed_Leave(Text_Renamed(3), New EventArgs())
        If DCPTung.MaTS = 0 Then
            thong_bao = "Tài sản chưa được đăng ký" : Else
            If DCPTung.ten.Length = 0 Or DCPTung.ten = "(...)" Then
                thong_bao = "Thiếu tên của dụng cụ hoặc phụ tùng kèm theo tài sản" : Else
                If DCPTung.DonVi.Length = 0 Then
                    thong_bao = "Chưa có đơn vị tính của dụng cụ hoặc phụ tùng kèm theo tài sản" : Else
                    If DCPTung.soluong = 0 Then
                        thong_bao = "Thiếu số lượng của dụng cụ hoặc phụ tùng kèm theo tài sản" : Else
                        If DCPTung.GiaThanh = 0 Then
                            thong_bao = "Thiếu giá thành của dụng cụ hoặc phụ tùng kèm theo tài sản" : Else
                            Return 0
                        End If
                    End If
                End If
            End If
        End If
        SystemSounds.Beep.Play()
        MessageBox.Show(thong_bao, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return -1
    End Function
    '======================================================================================
    ' FUNCTION ThemMoi
    '======================================================================================
    Private Function ThemMoi() As Integer
        If ExecSQLNonQuery(String.Format("INSERT INTO DCPTung (MaSo, MaTS, Ten, DonVi, SoLuong, GiaThanh) VALUES ({0},{1}, N'{2}', N'{3}',{4},{5})", _
                               Lng_MaxValue("MaSo", "DCPTung") + 1, _
                               ConvertToStrSafe(DCPTung.MaTS), _
                               DCPTung.ten, _
                               DCPTung.DonVi, _
                               CStr(DCPTung.soluong), _
                               CStr(DCPTung.GiaThanh))) = 0 Then
            DCPTung.MaSo = Lng_MaxValue("MaSo", "DCPTung")
            Grid.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}", _
                             DCPTung.MaSo, _
                             Chr(9), _
                             DCPTung.ten, _
                             DCPTung.DonVi, _
                             Format(DCPTung.soluong, Mask_2), _
                             "", Format(DCPTung.GiaThanh, Mask_0)), NewRowIndex(Grid, 0))
            SetGridIndex(Grid, 0) ', GRID_ROWS, GRID_COLS
            Return 0
        Else
            DCPTung.MaSo = 0
            Return -1
        End If
    End Function
    '======================================================================================
    ' FUNCTION SuaDoi
    '======================================================================================
    Private Function SuaDoi() As Integer
        If ExecSQLNonQuery(String.Format("UPDATE DCPTung SET Ten =N'{0}', DonVi =N'{1}', SoLuong = {2}, GiaThanh = {3} WHERE MaSo = {4}", _
                               DCPTung.ten, _
                               DCPTung.DonVi, _
                               CStr(DCPTung.soluong), _
                               CStr(DCPTung.GiaThanh), _
                               ConvertToStrSafe(DCPTung.MaSo))) = 0 Then
            Grid.Col = 1 : Grid.CtlText = Text_Renamed(0).Text
            Grid.Col = 2 : Grid.CtlText = Text_Renamed(1).Text
            Grid.Col = 3 : Grid.CtlText = Format(Text_Renamed(2).Text, Mask_2)
            Grid.Col = 4 : Grid.CtlText = Format(Text_Renamed(3).Text, Mask_0)
            Return 0
        Else
            Return -1
        End If
    End Function
    '======================================================================================
    ' FUNCTION Xoa
    '======================================================================================
    Private Function Xoa() As Integer
        If ExecSQLNonQuery("DELETE  FROM DCPTung WHERE MaSo = " & Grid.CtlText) = 0 Then
            Grid.RemoveItem(Grid.Row)
            SetGridIndex(Grid, Grid.Row - 1) ', GRID_ROWS, GRID_COLS

            Grid.Refresh()
            Return 0
        Else
            Return -1
        End If
    End Function
    '======================================================================================
    ' SUB KhoiTao
    '======================================================================================
    Private Sub KhoiTao(ByRef tiep_tuc As Boolean)
        DCPTung.MaSo = 0
        DCPTung.ten = ""
        DCPTung.DonVi = ""
        DCPTung.soluong = 0
        DCPTung.GiaThanh = 0
        Text_Renamed(0).Text = ""
        Text_Renamed(1).Text = ""
        Text_Renamed(2).Text = ""
        Text_Renamed(3).Text = ""
        If tiep_tuc Then Text_Renamed(0).Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmDCPTung_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
