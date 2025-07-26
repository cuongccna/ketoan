Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmBacthuemonbai
    Private Sub FrmBacthuemonbai_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = ConvertToDblSafe(Keys.Escape) Then Me.Close()
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
    Private Sub FrmBacthuemonbai_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ColumnSetUp(GrdThue, 0, 950, 1)
            ColumnSetUp(GrdThue, 1, 2150, 1)
            ColumnSetUp(GrdThue, 2, 2120, 1)
            ColumnSetUp(GrdThue, 3, 1, 1)
            Hienthi()
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
    Private Sub GrdThue_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdThue.DoubleClick
        With GrdThue
            .Col = 0
            TxtThue(0).Text = .CtlText
            .Col = 1
            TxtThue(1).Text = .CtlText
            .Col = 2
            TxtThue(2).Text = .CtlText
            .Col = 3
            ExecSQLNonQuery(String.Format("DELETE  FROM BacThue WHERE maso={0}", .CtlText))
            .RemoveItem(GrdThue.Row)
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtThue_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TxtThue_2.Enter, _TxtThue_1.Enter, _TxtThue_0.Enter
        Dim Index As Integer = Array.IndexOf(TxtThue, eventSender)
        TxtThue(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtThue_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _TxtThue_2.KeyPress, _TxtThue_1.KeyPress, _TxtThue_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(TxtThue, eventSender)
        Dim sql As String = String.Empty
        If KeyAscii = ConvertToDblSafe(Keys.Return) Then
            sql = String.Format("INSERT into BacThue(maso,bac,von,thue) values({0},{1},{2},{3})", _
                      Lng_MaxValue("Maso", "BacThue") + 1, _
                      TxtThue(0).Text, _
                      ConvertToStrSafe(ConvertToDblSafe(TxtThue(1).Text)), _
                      ConvertToStrSafe(ConvertToDblSafe(TxtThue(2).Text)))
            ExecSQLNonQuery(sql)
            Hienthi()
        Else
            KeyProcess(TxtThue(Index), KeyAscii, True)
        End If
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
    Private Sub TxtThue_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TxtThue_2.Leave, _TxtThue_1.Leave, _TxtThue_0.Leave
        Dim Index As Integer = Array.IndexOf(TxtThue, eventSender)
        TxtThue(Index).Text = Format(TxtThue(Index).Text, Mask_0)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Hienthi()
        ClearGrid(GrdThue, GrdThue.Rows)
        Dim rs As DataTable = ExecSQLReturnDT("SELECT * FROM BacThue order by bac desc")
        For Each rsItem As DataRow In rs.Rows
            GrdThue.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}", _
                                rsItem("Bac"), _
                                Chr(9), _
                                Format(ConvertToDblSafe(rsItem("von")), Mask_0), _
                                Format(ConvertToDblSafe(rsItem("Thue")), Mask_0), _
                                rsItem("MaSo")), 0)
            If rs.Rows.Count < GrdThue.Rows Then GrdThue.RemoveItem(GrdThue.Rows - 1)
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmBacthuemonbai_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
