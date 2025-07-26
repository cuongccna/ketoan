Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmE
    Dim tbl As String = String.Empty
    Dim fld As String = String.Empty

    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Dim iIndex As Integer = 0
        Dim Objects() As Object
        Cbo.Items.Clear()
        Cbo.Items.ItemsBase.Clear()
        iIndex = 0
        Objects = New Object() {"Cân đối tài sản", _
                                   "Kết quả kinh doanh - Phần I", _
                                   "Kết quả kinh doanh - Phần II", _
                                   "Kết quả kinh doanh - Phần III", _
                                   "Lưu chuyển tiền tệ", _
                                   "Chi tiết doanh thu - chi phí"}
        For Each objItem As Object In Objects
            Cbo.Items.Add(objItem.ToString, 0)
            iIndex += 1
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmE_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            FormInit()
            If Cbo.Items.Count > 0 Then Cbo.SelectedIndex = 0
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
    Private Sub Cbo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Cbo.SelectedIndexChanged
        Select Case Cbo.SelectedIndex
            Case 0 : tbl = "CDTS"
                fld = "DienGiaiE"
            Case 1 : tbl = "KQKD"
                fld = "TenE"
            Case 2 : tbl = "Thue"
                fld = "DienGiaiE"
            Case 3 : tbl = "VAT"
                fld = "DienGiaiE"
            Case 4 : tbl = "LCTT"
                fld = "TenE"
            Case 5 : tbl = "KQKDCT"
                fld = "TenE"
        End Select
        Int_RecsetToListbox(String.Format("SELECT MaSo As F2,CASE WHEN Left({0},1)='.' THEN {1} ELSE {0} END As F1 FROM {2} GROUP BY MaSo", _
                                fld, _
                                Strings.Left(fld, fld.Length - 1), _
                                tbl), Lst)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Lst_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Lst.SelectedIndexChanged
        txt.Text = Lst.Text
        txt.Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmE_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then Me.Close()
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
        If KeyAscii = 13 And Lst.SelectedIndex >= 0 And Strings.Len(txt.Text) > 0 Then
            ExecSQLNonQuery(String.Format("UPDATE {0} SET {1} = N'{2}' WHERE MaSo={3}", _
                                tbl, _
                                fld, _
                                txt.Text, _
                                ConvertToStrSafe(Lst.SelectedIndex)))
            On Error Resume Next
            ExecSQLNonQuery(String.Format("UPDATE {0} IN '{1}UPDATE.MDB' SET {2} =N'{3}' WHERE MaSo={4}", _
                                tbl, _
                                pCurDir, _
                                fld, _
                                txt.Text, _
                                ConvertToStrSafe(Lst.SelectedIndex)))
            On Error GoTo 0
            'VB6.SetItemString(Lst, Lst.SelectedIndex, txt.Text)
            Dim currentCate As ValueDescriptionPair = CType(Lst.SelectedItem, ValueDescriptionPair)
            Dim newItemCate As New ValueDescriptionPair(currentCate.Value, txt.Text)
            Lst.Items(Lst.SelectedIndex) = newItemCate
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
End Class
