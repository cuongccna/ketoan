Imports System
Imports UNET.DataAdapter
Imports UNET.Utility
Imports System.Windows.Forms


Partial Friend Class FrmMNTaiSan
    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmd1_7.Click, _Cmd1_8.Click, _Cmd1_1.Click, _Cmd1_4.Click, _Cmd1_10.Click, _Cmd1_12.Click, _Cmd1_0.Click, _Cmd1_2.Click, _Cmd1_3.Click, _Cmd1_5.Click, _Cmd1_6.Click, _Cmd1_9.Click, _Cmd1_11.Click, _Cmd1_13.Click, _Cmd1_14.Click, _Cmd1_15.Click
        Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
        Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0, 3, 5, 6
                'FrmChungtu.OptLoai(IIf(Index = 0, 9, (IIf(Index = 3, 10, (IIf(Index = 5, 11, 12)))))).Checked = True
                FrmChungtu.initOption = IIf(Index = 0, 9, (IIf(Index = 3, 10, (IIf(Index = 5, 11, 12)))))
                If FrmChungtu.initOption <> 0 Then
                    If Index = 6 Then FrmChungtu.ct_MaKhoHang = 1
                    FrmChungtu.ShowDialog()
                    If Index = 6 Then FrmChungtu.ct_MaKhoHang = 0
                End If
                'FrmChungtu.initOption = 4
                'FrmChungtu.Close()
                'Me.ShowDialog()
            Case 1
                FrmKho.Tag = "4"
                FrmKho.ShowDialog()
            Case 2
                If pRpt = CheckState.Checked And User_Right = 1 Then
                    ErrMsg(er_KoSD)
                    Exit Sub
                End If
                FrmSotaisan.ShowDialog()
            Case 4
                If KtraMKAdmin() Then DatTKTS()
            Case 7
                frmPhanLoai.Tag = "1"
                frmPhanLoai.ShowDialog()
            Case 8
                If FADetail Then
                    pNghiepVu = NV_KHONG
                    frmDSTaiSan.ShowDialog()
                Else
                    frmMain.NoRight(2)
                End If
            Case 9
                If ChoDieuChinhDauKy() Then
                    pNghiepVu = NV_TANG
                    frmTaiSan.Tag = "1"
                    frmTaiSan.lc = 1
                    frmTaiSan.ShowDialog()
                    frmTaiSan.lc = 0
                End If
            Case 10
                FrmKho.Tag = "2"
                FrmKho.ShowDialog()
            Case 11
                FrmChungtu.khoi_tao()
                FrmChungtu.Nut.Tag = "1"
                FrmDsCT.tscc = 1
                FrmChungtu.flag = -1
                FrmChungtu.loadluoi = 1
                FrmChungtu.ShowDialog()
                FrmChungtu.loadluoi = 0
                FrmDsCT.tscc = 0
            Case 12
                FrmKho.Tag = "3"
                FrmKho.ShowDialog()
            Case 13
                FrmChungtu.khoi_tao()
                FrmChungtu.initOption = 0
                'Chi phí nhập hàng
                FrmChungtu.loai1.Tag = "0"
                FrmChungtu.loadluoi = 1
                FrmChungtu.ShowDialog()
            Case 14
                FrmChungtu.initOption = 8
                'Chứng từ giảm
                FrmChungtu.loai1.Tag = 6
                FrmChungtu.ShowDialog()
            Case 15
                Me.Close() : Exit Sub
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
    Private Sub FrmMNTaiSan_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Or ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNTaiSan_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        If ConvertToDblSafe(frmMain._LbCty_8.Text) = 0 Then
            Cmd1(1).Enabled = True
            Cmd1(4).Enabled = True
            Cmd1(7).Enabled = True
            Cmd1(12).Enabled = True
        End If
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNTaiSan_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Cmd1_13.Click

    End Sub
End Class
