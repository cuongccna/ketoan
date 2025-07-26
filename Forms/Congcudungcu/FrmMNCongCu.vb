Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmMNCongCu
    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmd1_10.Click, _Cmd1_8.Click, _Cmd1_7.Click, _Cmd1_4.Click, _Cmd1_5.Click, _Cmd1_0.Click, _Cmd1_2.Click, _Cmd1_3.Click, _Cmd1_6.Click, _Cmd1_9.Click, _Cmd1_1.Click, _Cmd1_11.Click, _Cmd1_12.Click, _Cmd1_13.Click, _Cmd1_15.Click, _Cmd1_14.Click, _Cmd1_16.Click
        Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
        Select Case Index
            Case 0, 6, 11, 13
                FrmChungtu.khoi_tao()
                FrmChungtu.initOption = IIf(Index = 0, 13, IIf(Index = 6, 14, 15))
                If Index = 11 Then
                    cuongdauky = 6
                ElseIf Index = 13 Then
                    cuongdauky = 7
                End If
                If FrmChungtu.initOption <> 0 Then
                    If Index = 6 Then FrmChungtu.ct_MaKhoHang = 1
                    FrmChungtu.loadluoi = 1
                    FrmChungtu.ShowDialog()
                    FrmChungtu.loadluoi = 0
                    If Index = 6 Then FrmChungtu.ct_MaKhoHang = 0
                End If
            Case 1, 9
                If ChoDieuChinhDauKy() Then
                    pNghiepVu = NV_TANG
                    cuongdauky = IIf(Index = 1, 1, 2)
                    FrmCongcudungcu.Tag = "1"
                    FrmCongcudungcu.ShowDialog()
                    cuongdauky = 0
                End If
            Case 2
                If pRpt = CheckState.Checked And User_Right = 1 Then
                    ErrMsg(er_KoSD)
                    Exit Sub
                End If
                FrmSocongcu.ShowDialog()
            Case 3, 14
                FrmChungtu.khoi_tao()
                FrmChungtu.initOption = 0
                If Index = 14 Then
                    'Chứng từ chi phí trả trước
                    FrmChungtu.loai1.Tag = 7
                End If
                FrmChungtu.loadluoi = 1
                FrmChungtu.ShowDialog()
            Case 4
                FrmKho.Tag = "4"
                FrmKho.ShowDialog()
            Case 5
                If KtraMKAdmin() Then DatTKTS()
            Case 7
                frmPhanLoai.Tag = "3"
                frmPhanLoai.ShowDialog()
            Case 8, 10
                If FADetail Then
                    pNghiepVu = NV_KHONG
                    cuongdauky = IIf(Index = 8, 4, 3)
                    frmDSCCDC.ShowDialog()
                    cuongdauky = 0
                Else
                    frmMain.NoRight(2)
                End If
            Case 12
                FrmChungtu.initOption = 8
                'Chứng từ giảm
                FrmChungtu.loai1.Tag = 6
                FrmChungtu.ShowDialog()
            Case 15
                Me.Close() : Exit Sub
            Case 16
                FrmChungtu.khoi_tao()
                FrmChungtu.loadluoi = 1
                FrmChungtu.Nut.Tag = "1"
                FrmDsCT.tscc = 2
                FrmChungtu.loadluoi = 1
                FrmChungtu.ShowDialog()
                FrmChungtu.loadluoi = 0
                FrmDsCT.tscc = 0
                FrmChungtu.loadluoi = 0
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
    Private Sub FrmMNCongCu_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Or ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Then Me.Close() : Me.Finalize()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNCongCu_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        If ConvertToDblSafe(frmMain._LbCty_8.Text) = 0 Then
            Cmd1(4).Enabled = True
            Cmd1(5).Enabled = True
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
    Private Sub FrmMNCongCu_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
