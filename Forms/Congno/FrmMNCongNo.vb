Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmMNCongNo

    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmd1_8.Click, _Cmd1_9.Click, _Cmd1_10.Click, _Cmd1_11.Click, _Cmd1_0.Click, _Cmd1_1.Click, _Cmd1_2.Click, _Cmd1_3.Click, _Cmd1_6.Click, _Cmd1_5.Click, _Cmd1_7.Click, _Cmd1_12.Click, _Cmd1_13.Click
        Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
        Select Case Index
            Case 0
                frmPhanLoaiVT.pl1 = "2"
                frmPhanLoaiVT.ShowDialog()
                frmPhanLoaiVT.pl1 = "0"
                Exit Select
            Case 1
                FrmKhachHang.ShowDialog()
                Exit Select
            Case 2
                FrmCantrucongno.ShowDialog()
                Exit Select
            Case 3
                FrmNguyente.ShowDialog()
                Exit Select
            Case 5
                If KtraMKAdmin() Then
                    FrmLS.ShowDialog()
                End If
                Exit Select
            Case 6
                If KtraMKAdmin() Then frmMain.DatTKCN()
                Exit Select
            Case 7
                Me.Close()
                Exit Select
            Case 8
                If ChoDieuChinhDauKy() Then
                    If pCongNoHD = 0 Then
                        FKHDauKy.ShowDialog()
                    Else
                        FKHDauKy2.ShowDialog()
                    End If
                End If
                Exit Select
            Case 9
                If pRpt = CheckState.Checked And User_Right = 1 Then
                    ErrMsg(er_KoSD)
                    Exit Sub
                End If
                FrmSoCongNo.ShowDialog()
            Case 10, 11, 12, 13
                FrmChungtu.loai1.Tag = "1"
                If Index = 10 Then
                    FrmChungtu.loaino.Tag = "0"
                ElseIf Index = 11 Then
                    FrmChungtu.loaino.Tag = "1"
                ElseIf Index = 12 Then
                    FrmChungtu.loaino.Tag = "3"
                ElseIf Index = 13 Then
                    FrmChungtu.loaino.Tag = "2"
                End If
                FrmChungtu.initOption = 0
                FrmChungtu.ShowDialog()
                FrmChungtu.loai1.Tag = "0"
                FrmChungtu.loaino.Tag = "0"
                Exit Select
        End Select

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
    Private Sub FrmMNCongNo_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Or ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNCongNo_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        If ConvertToDblSafe(frmMain._LbCty_8.Text) = 0 Then
            Cmd1(0).Enabled = True
            Cmd1(6).Enabled = True
        End If
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNCongNo_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
