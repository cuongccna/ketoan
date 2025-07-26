Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmMNGiaThanh
    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmd1_7.Click, _Cmd1_8.Click, _Cmd1_2.Click, _Cmd1_14.Click, _Cmd1_16.Click, _Cmd1_0.Click, _Cmd1_1.Click, _Cmd1_15.Click
        Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0
                Frm154Dauky.ShowDialog()
            Case 1
                If pRpt = CheckState.Checked And User_Right = 1 Then
                    ErrMsg(er_KoSD)
                Else
                    FrmSogiathanh.ShowDialog()
                End If
            Case 2
                FrmVattu.TK = "155"
                If FrmVattu.ChucNang = 0 Then FrmVattu.Command_ClickEvent(FrmVattu.Command(4), New EventArgs())
                FrmVattu.ShowDialog()
            Case 7
                frmPhanLoaiVT.pl1 = "3"
                frmPhanLoaiVT.ShowDialog()
                frmPhanLoaiVT.pl1 = "0"
            Case 8
                FrmTP.ShowDialog()
            Case 14
                If STDetail Then
                    FrmThanhPham.ShowDialog()
                Else
                    frmMain.NoRight(1)
                End If
            Case 15
                Me.Close()
            Case 16
                frmMain.Tinhgiaxuatkho()
        End Select
        Me.Cursor = Cursors.Default
        HienThongBao("", 1)
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNGiaThanh_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Or ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNGiaThanh_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub FrmMNGiaThanh_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
