Imports System
Imports System.IO
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmDB

    Dim fndb As String = String.Empty
    'Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click , _Command_1.Click , _Command_0.Click , _Command_2.Click 
    '	Dim Index As Integer = Array.IndexOf(Command, eventSender)
    '	Dim fn As String = String.Empty
    '	SELECT Case Index
    '		Case 0
    '               LoadDBList(txtMST(0).Text, ConvertToDblSafe(txtMST(1).Text))
    '		Case 1
    '               If LstDB(0).SelectedIndex >= 0 Then LstDB_DoubleClick(LstDB(0), New EventArgs())
    '           Case 2
    '               Me.Close()
    '           Case 3
    '               If LstDB(0).SelectedIndex >= 0 Then
    '                   If FrmThongbao.Thongbaomoi("Bạn đã chắc chắn muốn lấy lại tệp backup ngày " & VB6.GetItemString(LstDB(0), LstDB(0).SelectedIndex) & " làm tệp dữ liệu mặc định ?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, My.Application.Info.ProductName) = System.Windows.Forms.DialogResult.Yes Then
    '                       fn = pCurDir & "DATA\ERROR" & DateTime.Today.ToString("ddMMyyyy") & ".SAS"
    '                       fndb = Interaction.GetSetting(IniPath, "Environment", "Path", pCurDir & "DATA\UnescoXi.mdf")
    '                       On Error Resume Next
    '                       Artinsoft.VB6.DB.TransactionManager.DeEnlist(DBKetoan.connection)
    '                       DBKetoan.Close()
    '                       Recycle(fn)
    '                       File.Copy(fndb, fn)
    '                       Recycle(fndb)
    '                       On Error GoTo 0
    '                       GianTepNen(VB6.GetItemString(LstDB(1), LstDB(1).SelectedIndex), fndb)
    '                       Me.Close()
    '                   End If
    '               End If
    '       End SELECT
    '   End Sub
    '   Private Sub FrmDB_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
    '       'Dim KeyCode As Integer = eventArgs.KeyCode
    '       Dim Shift As Integer = eventArgs.KeyData \ &H10000
    '       If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    '   End Sub
    '''    
    Public Function ChonTepLuu(ByRef MST As String, ByRef Nam As Integer) As String
        Dim result As String = String.Empty
        'txtMST(0).Text = MST
        'txtMST(1).Text = ConvertToStrSafe(Nam)
        'LoadDBList(MST, Nam)
        'Me.Cursor = Cursors.Default
        'Me.ShowDialog()
        'result = fndb
        'Me.Close()
        Return result
    End Function
    '   Private Sub LstDB_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _LstDB_1.SelectedIndexChanged, _LstDB_0.SelectedIndexChanged
    '       Dim Index As Integer = Array.IndexOf(LstDB, eventSender)
    '       LstDB(1 - Index).SelectedIndex = LstDB(Index.SelectedIndex)
    '   End Sub
    '   Private Sub LoadDBList(ByRef MST As String, ByRef Nam As Integer)
    '       Dim m1 As Integer
    '       Dim fn As String = String.Empty
    '       LstDB(0).Items.Clear()
    '       LstDB(1).Items.Clear()
    '       For m As Integer = CThangDB2(DateTime.Today.Month) To 1 Step -1
    '           m1 = CThangFR(m)
    '           For d As Integer = SoNgayTrongThang(pNamTC, m) To 1 Step -1
    '               fn = pCurDir & "DATA\K" & (iif(m1 < 10, "0", String.Empty)) & ConvertToStrSafe(m1) & (iif(d < 10, "0", String.Empty)) & ConvertToStrSafe(d) & Strings.Right(ConvertToStrSafe(Nam), 2) & "_" & MST & ".SAS"
    '               If FileSystem.Dir(fn, FileAttribute.Normal).Length > 0 Then
    '                   LstDB(0).Items.Add((iif(d < 10, "0", String.Empty)) & ConvertToStrSafe(d) & "/" & (iif(m1 < 10, "0", String.Empty)) & ConvertToStrSafe(m1) & "/" & ConvertToStrSafe(Nam))
    '                   LstDB(1).Items.Add(fn)
    '               End If
    '           Next
    '       Next
    '   End Sub
    'Private Sub LstDB_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _LstDB_1.DoubleClick, _LstDB_0.DoubleClick
    '	Dim Index As Integer = Array.IndexOf(LstDB, eventSender)
    '	Dim fn As String = VB6.GetItemString(LstDB(1), Index)
    '	fndb = Strings.Left(fn, fn.Length - 3) & "MDB"
    '	If FileSystem.Dir(fn, FileAttribute.Normal).Length > 0 Then
    '		Me.Hide()
    '		GianTepNen(fn, fndb)
    '	Else
    '		fndb = ""
    '	End If
    'End Sub
    'Private Sub txtMST_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtMST_1.Enter, _txtMST_0.Enter
    '	Dim Index As Integer = Array.IndexOf(txtMST, eventSender)
    '	txtMST(Index).SelectAll()
    'End Sub
    'Private Sub FrmDB_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
    '	MemoryHelper.ReleaseMemory()
    'End Sub
End Class
