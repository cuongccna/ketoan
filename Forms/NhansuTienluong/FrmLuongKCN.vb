Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter



Partial Friend Class FrmLuongKCN
    Dim thang As Integer = 0
    Dim Nhanvien As Integer = 0

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmLuongKCN_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        ColumnSetUp(GrdVT, 0, 2270, 0)
        ColumnSetUp(GrdVT, 1, 1430, 1)
        ColumnSetUp(GrdVT, 2, 1670, 1)
        ColumnSetUp(GrdVT, 3, 1190, 1)
        ColumnSetUp(GrdVT, 4, 1170, 1)
        ColumnSetUp(GrdVT, 5, 1, ContentAlignment.MiddleRight)
        AddMonthToCbo(CboThang)
        If CboThang.Items.Count > 0 Then
            CboThang.SelectedIndex = Today.Month - 1
        End If
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Hienthi()
        Dim i As Integer = 0
        Dim Mientru As String = String.Format("SELECT bl.manv as manv,bl.tongthunhap,cn.lkcn FROM bangluong bl left join luongkcn cn on bl.thang=cn.thang and bl.manv=cn.manv WHERE bl.thang={0}", thang)
        Dim str As String = String.Format("SELECT nv.maso,nv.ten,nv.mst,nv.cmnd,mt.manv,mt.tongthunhap,isnull(mt.lkcn,0) as lkcn FROM quanlynhanvien nv inner join ({0}) AS  mt on nv.maso=mt.manv WHERE loaihd=1 or loaihd=2", Mientru)
        Dim rs As DataTable = ExecSQLReturnDT(str)

        ClearGrid(GrdVT, GrdVT.Rows)

        Dim rsIndex As Integer = 0
        While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            Dim currentName As String = ConvertToStrSafe(rsItem("ten"))
            If Not String.IsNullOrEmpty(currentName) Then
                GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}", _
                                              rsItem("ten"), _
                                              Chr(9), _
                                              rsItem("MST"), _
                                              rsItem("CMND"), _
                                              Format(rsItem("tongthunhap"), Mask_0), _
                                              Format(rsItem("lkcn"), Mask_0), _
                                              rsItem("MaNV")), i)
                i += 1
            End If
        End While
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        thang = CboThang.SelectedValue
        Hienthi()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        Dim strcstr As String = txt.Text
        'van.nguyen
        strcstr = IIf(txt.Text = "", 0, txt.Text)
        'Dim strsql As String = String.Format("UPDATE LuongKCN  SET lkcn={0} WHERE manv={1} AND thang={2}", _
        '                                                            cstr(ConvertToDblSafe(strcstr)), _
        '                                                            Nhanvien, _
        '                                                            thang)
        Dim strsql As String = String.Format("UPDATE LuongKCN  SET lkcn={0} WHERE manv={1} AND thang={2}", _
                                                            ConvertToDblSafe(strcstr), _
                                                            Nhanvien, _
                                                            thang)
        Dim RecordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(strsql)
        If RecordsAffectedCount > 0 Then
            If GrdVT.Rows = 0 Then
                GrdVT.AddItem(String.Format("{0}{0}{0}{0}{1}", _
                                  Chr(9), _
                                  Format(ConvertToDblSafe(txt.Text), Mask_0)), 0)
            Else
                GrdVT.Row = 0
                GrdVT.Col = 4
                GrdVT.CtlText = Format(ConvertToDblSafe(txt.Text), Mask_0)
            End If
            'GrdVT.Refresh()
        Else
            Dim strsql1 As String = String.Format("INSERT INTO LuongKCN (MaSo,Manv,Thang,lkcn) VALUES ({0},{1},{2},{3})", _
                                   Lng_MaxValue("MaSo", "LuongKCN") + 1, _
                                   Nhanvien, _
                                   thang, _
                                   CStr(ConvertToDblSafe(strcstr)))
            If ExecSQLNonQuery(strsql1) = 0 Then

                If GrdVT.Rows = 0 Then
                    GrdVT.AddItem(String.Format("{0}{0}{0}{0}{1}", _
                                      Chr(9), _
                                      Format(ConvertToDblSafe(strcstr), Mask_0)), 0)
                Else
                    GrdVT.Row = 0
                    GrdVT.Col = 4
                    GrdVT.CtlText = Format(ConvertToDblSafe(strcstr), Mask_0)
                End If
            End If
        End If
        For i As Integer = 0 To 3
            LbTxt(i).Text = ""
        Next
        txt.Text = ""
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 2 : Me.Close()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmLuongKCN_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case KeyCode
                Case Keys.V
                    Command(2).Focus()
                    Command_ClickEvent(Command(2), New EventArgs())
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
    Private Sub GrdVT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdVT.Click
        SetGridIndex(GrdVT, GrdVT.Row)
        With GrdVT
            .Col = 0
            If .CtlText.length > 0 Then
                For i As Integer = 0 To 3
                    .Col = ConvertToDblSafe(i)
                    LbTxt(i).Text = .CtlText
                Next
                .Col = 4
                txt.Text = .CtlText
                txt.Focus()
                .Col = 5
                Nhanvien = ConvertToDblSafe((.CtlText))
            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdVT.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(GrdVT, GrdVT.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txt.Enter
        txt.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txt.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        KeyProcess(txt, KeyAscii, True)
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
    Private Sub txt_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txt.Leave
        txt.Text = IIf(ConvertToDblSafe(txt.Text) <> 0, Format(txt.Text, Mask_0), "0")
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmLuongKCN_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
