Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmMNNhanVien
    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmd1_2.Click, _Cmd1_3.Click, _Cmd1_5.Click, _Cmd1_6.Click, _Cmd1_0.Click, _Cmd1_7.Click, _Cmd1_8.Click, _Cmd1_9.Click, _Cmd1_15.Click
        Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
        Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0
                FrmChungtu.khoi_tao()
                FrmChungtu.loadluoi = 1
                FrmChungtu.Nut.Tag = "1"
                FrmChungtu.initOption = 0
                FrmChungtu.ShowDialog()
                FrmChungtu.loadluoi = 0
            Case 2
                FrmChamcong.ShowDialog()
            Case 3
                FrmPhucap.ShowDialog()
            Case 5
                FrmChucdanh.ShowDialog()
            Case 6
                FrmChamconggio.ShowDialog()
            Case 7
                frmPhanLoaiNV.Tag = "4"
                frmPhanLoaiNV.ShowDialog()
            Case 8
                FrmChucvu.ShowDialog()
            Case 9
                FrmQuanLyNhanVien.ShowDialog()
            Case 15
                Me.Close()
        End Select

        HienThongBao("", 1)
        MemoryHelper.ReleaseMemory()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CmdTNCN_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CmdTNCN_0.Click, _CmdTNCN_1.Click, _CmdTNCN_2.Click
        Dim Index As Integer = Array.IndexOf(CmdTNCN, eventSender)
        Select Case Index
            Case 0 : frmGiamtru.ShowDialog()
            Case 1 : FrmLuongKCN.ShowDialog()
            Case 2 : FrmTNCN.ShowDialog()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNNhanVien_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Or ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Then Me.Close()
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNNhanVien_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        UpdatePhuCapTable()
        UpdatePhPhanLoaiTable()
        If ConvertToDblSafe(frmMain._LbCty_8.Text) = 0 Then
            Cmd1(7).Enabled = True
        End If
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNNhanVien_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
