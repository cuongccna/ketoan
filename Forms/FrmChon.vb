Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class FrmChon
    Dim Filename As String = String.Empty
    Dim thang As Integer
    Dim thang1 As Integer
    Dim act As Integer
    Private Sub Chk_MouseUp(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles Chk.MouseUp
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim X As Single = (eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        Dim i As Integer
        GrdChungtu.Col = 4
        GrdChungtu.Row = 0
        If Chk.CheckState Then
            Chk.Text = "Huỷ tất cả"
            While GrdChungtu.CtlText <> ""
                GrdChungtu.CtlText = "X"
                i += 1
                If GrdChungtu.Row = GrdChungtu.Rows - 1 Then Exit Sub
                GrdChungtu.Row = i
            End While
        Else
            Chk.Text = "Chọn tất cả"
            While GrdChungtu.CtlText <> ""
                GrdChungtu.CtlText = "-"
                i += 1
                If GrdChungtu.Row = GrdChungtu.Rows - 1 Then Exit Sub
                GrdChungtu.Row = i
            End While
        End If
    End Sub
    '======================================================================================
    ' Liệt kê, Chọn chứng từ
    '======================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        act = Index
        Me.Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChon_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.T
                    If Command(1).Visible Then
                        Command(1).Focus()
                        'Command_ClickEvent(Command(1), New EventArgs())
                    End If
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(0), New EventArgs())
    End Sub
    ''' <summary>
    ''' Khởi tạo cửa sổ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>   
    Private Sub FrmChon_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ColumnSetUp(GrdChungtu, 0, 1550, 0)
            ColumnSetUp(GrdChungtu, 1, 3830, 0)
            ColumnSetUp(GrdChungtu, 2, 590, 2)
            ColumnSetUp(GrdChungtu, 3, 710, 2)
            ColumnSetUp(GrdChungtu, 4, 900, 2)
            ColumnSetUp(GrdChungtu, 5, 1, 2)
            LietKeChungtu(FrmSogiathanh.CboThang(1).SelectedValue)
            Text = SetFormTitle(Text)
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    '======================================================================================
    ' Nhớ mã số CT được chọn
    '======================================================================================
    Private Sub GrdChungtu_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdChungtu.Click
        With GrdChungtu
            If .CtlText.length = 0 Or (.Col <> 3 And .Col <> 4) Then Exit Sub
            If .CtlText = "X" Then
                .CtlText = "-"
                Chk.CheckState = CheckState.Unchecked
                Chk.Text = "Chọn tất cả"
            Else
                If KtraChon(.Col) Then .CtlText = "X" Else MessageBox.Show(String.Format("Không chọn quá {0} chứng từ!", Max1000), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdChungtu.KeyPress
        GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())
        If eventArgs.KeyChar = Chr(Keys.Enter) Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub
    '======================================================================================
    ' Liệt kê chứng từ
    '======================================================================================
    Private Sub LietKeChungtu(ByRef thang As Integer)
        Dim dem As Integer
        Dim rs_chungtu As DataTable
        Dim sql As String = String.Empty
        Dim sh As String = String.Empty
        Try
            If Not TruongDaCo("Dinhmuc", "DaIn") Then
                ExecSQLNonQuery("alter table Dinhmuc add DaIn nvarchar(1) null")
                ExecSQLNonQuery("UPDATE Dinhmuc set DaIn='-'")
                'DBKetoan("DinhMuc").Fields("PL").DefaultValue = ""
            End If
            ''OpenDB(pDataPath)
        Catch
        End Try
        Me.Cursor = Cursors.WaitCursor
        sql = String.Format("SELECT DISTINCT Vattu.SoHieu, Vattu.TenVattu,DinhMuc.Thang,DinhMuc.MaTP,DinhMuc.DaIn FROM (DinhMuc INNER JOIN Vattu ON DinhMuc.MaTP=Vattu.MaSo) INNER JOIN Vattu AS VT ON DinhMuc.MaNVL=VT.MaSo WHERE DinhMuc.Thang<={0} GROUP BY Vattu.SoHieu, Vattu.TenVattu,DinhMuc.Thang,DinhMuc.MaTP,DinhMuc.DaIn ORDER BY Vattu.SoHieu desc,DinhMuc.Thang desc", thang)
        ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
        rs_chungtu = ExecSQLReturnDT(sql)
        For Each rschungtuItem As DataRow In rs_chungtu.Rows
            If sh <> ConvertToStrSafe(rschungtuItem("SoHieu")) Then
                sh = ConvertToStrSafe(rschungtuItem("SoHieu"))
                dem += 1
                GrdChungtu.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}-{1}{5}", _
                                       rschungtuItem("SoHieu"), _
                                       Chr(9), _
                                       rschungtuItem("TenVattu"), _
                                       rschungtuItem("thang"), _
                                       (IIf(IsDBNull(rschungtuItem("DaIn")), "-", ConvertToStrSafe(rschungtuItem("DaIn")))), _
                                       rschungtuItem("MaTP")), 0)
            End If
        Next
        'GrdChungtu.Rows = iif(dem > ConvertToDblSafe(GrdChungtu.Tag), Math.Min(MaxGridRow, dem), ConvertToDblSafe(GrdChungtu.Tag))
        LbSoCT.Text = ConvertToStrSafe(dem)
        GrdChungtu.Col = 0
        ''rs_chungtu.Close()
        rs_chungtu = Nothing
kt:
        'db = Nothing
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fn"></param>
    ''' <param name="thangchon"></param>
    ''' <param name="tp"></param>
    ''' <param name="tp1"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChonCTSoA(ByRef fn As String, ByRef thangchon As Integer, ByRef tp() As Integer, ByRef tp1() As Integer) As Integer
        Dim result As Integer = 0
        Dim c, d As Integer
        Dim MaTP As Integer
        Filename = fn
        act = 0
        ' LietKeChungtu(thangchon)
        Dim dem As Integer
        Dim rs_chungtu As DataTable
        Dim sql As String = String.Empty
        Dim sh As String = String.Empty
        Try
            If Not TruongDaCo("Dinhmuc", "DaIn") Then
                ExecSQLNonQuery("alter table Dinhmuc add DaIn nvarchar(1) null")
                ExecSQLNonQuery("UPDATE Dinhmuc set DaIn='-'")
                'DBKetoan("DinhMuc").Fields("PL").DefaultValue = ""
            End If
            ''OpenDB(pDataPath)
        Catch
        End Try
        Me.Cursor = Cursors.WaitCursor
        sql = String.Format("SELECT DISTINCT Vattu.SoHieu, Vattu.TenVattu,DinhMuc.Thang,DinhMuc.MaTP,DinhMuc.DaIn FROM (DinhMuc INNER JOIN Vattu ON DinhMuc.MaTP=Vattu.MaSo) INNER JOIN Vattu AS VT ON DinhMuc.MaNVL=VT.MaSo WHERE DinhMuc.Thang<={0} GROUP BY Vattu.SoHieu, Vattu.TenVattu,DinhMuc.Thang,DinhMuc.MaTP,DinhMuc.DaIn ORDER BY Vattu.SoHieu desc,DinhMuc.Thang desc", thangchon)
        ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
        rs_chungtu = ExecSQLReturnDT(sql)
        For Each rschungtuItem As DataRow In rs_chungtu.Rows
            If sh <> ConvertToStrSafe(rschungtuItem("SoHieu")) Then
                sh = ConvertToStrSafe(rschungtuItem("SoHieu"))
                dem += 1
                GrdChungtu.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}-{1}{5}", _
                                       rschungtuItem("SoHieu"), _
                                       Chr(9), _
                                       rschungtuItem("TenVattu"), _
                                       rschungtuItem("thang"), _
                                       (IIf(IsDBNull(rschungtuItem("DaIn")), "-", ConvertToStrSafe(rschungtuItem("DaIn")))), _
                                       rschungtuItem("MaTP")), 0)
            End If
        Next

        'GrdChungtu.Rows = iif(dem > ConvertToDblSafe(GrdChungtu.Tag), Math.Min(MaxGridRow, dem), ConvertToDblSafe(GrdChungtu.Tag))
        LbSoCT.Text = ConvertToStrSafe(dem)
        GrdChungtu.Col = 0
        ''rs_chungtu.Close()
        rs_chungtu = Nothing
kt:
        'db = Nothing
        Me.Cursor = Cursors.Default
        Me.ShowDialog()
        Me.Refresh()
        If act = 0 Then Return result
        With GrdChungtu
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 5
                MaTP = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 4
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                If .Items(.Row).SubItems(.Col).Text = "X" Then
                    If c < Max1000 Then
                        c += 1
                        tp(c) = MaTP
                    End If
                Else
                    If d < Max1000 Then
                        d += 1
                        tp1(d) = MaTP
                    End If
                End If
                .Col = 3
                ExecSQLNonQuery(String.Format("UPDATE DinhMuc set DaIn=N'{0}' WHERE matp={1}", _
                                    .CtlText, _
                                    ConvertToStrSafe(MaTP)))
            Next
        End With
        result = c
        ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
        Me.Close()
        Return result
    End Function
    Private Function KtraChon(ByRef cot As Integer) As Boolean
        Dim result As Boolean = False
        Dim c As Integer
        With GrdChungtu
            .Col = cot
            For i As Integer = 0 To .Rows - 1
                If .CtlText.length = 0 Then Exit For
                If .CtlText = "X" Then
                    c += 1
                End If
            Next
            result = (c < Max1000)
        End With
        Return result
    End Function
    Private Sub GrdChungtu_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdChungtu.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(GrdChungtu, GrdChungtu.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChon_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
