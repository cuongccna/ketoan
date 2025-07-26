Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmMNTongHop
    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmd1_8.Click, _Cmd1_0.Click, _Cmd1_1.Click, _Cmd1_2.Click, _Cmd1_3.Click, _Cmd1_12.Click, _Cmd1_4.Click, _Cmd1_5.Click, _Cmd1_6.Click, _Cmd1_7.Click
        Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
        Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0, 1
                FrmChungtu.Nut.Tag = IIf(Index = 0, "1", "2")
                If Index = 0 Then
                    FrmDsCT.tracu = True
                Else
                    FrmChungtu.CmdDanhSach(0).Visible = False
                    FrmChungtu.CmdDanhSach(1).Visible = True
                End If
                'FrmChungtu.initOption = 0
                FrmChungtu.ShowDialog()
                If Index = 0 Then
                    FrmDsCT.tracu = False
                Else
                    FrmChungtu.CmdDanhSach(0).Visible = True
                    FrmChungtu.CmdDanhSach(1).Visible = False
                End If
                Exit Select
            Case 2, 5, 6, 7
                If Index = 2 Then
                    'Chi phi hoạt động kinh doanh
                    FrmChungtu.loai1.Tag = 2
                ElseIf Index = 5 Then
                    'Thuế, phí và lệ phí
                    FrmChungtu.loai1.Tag = 3
                ElseIf Index = 6 Then
                    'Ngân hàng
                    FrmChungtu.loai1.Tag = 4
                Else
                    'Chi phí khác
                    FrmChungtu.loai1.Tag = 5
                End If

                FrmChungtu.initOption = 0
                FrmChungtu.ShowDialog()
                Exit Select
            Case 3
                If pRpt = CheckState.Checked And User_Right = 1 Then
                    ErrMsg(er_KoSD)
                    Exit Sub
                End If
                FrmSochiphi.ShowDialog()
                Exit Select
            Case 4
                Me.Close()
            Case 8
                FrmChungtutonghop.initOption = 0
                FrmChungtutonghop.ShowDialog()
                Exit Select
            Case 12
                frmMain.TinhLaiGiaNgoaiTe()
                Exit Select
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
    Private Sub FrmMNTongHop_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Or ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNTongHop_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Frame3.Visible = (User_Right = 0) And (ConvertToDblSafe(GetSelectValue("SELECT Flag1 as f1 FROM license")) Mod 1000000) > 100000
#If DEBUG Then
        Frame3.Visible = True
#End If
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNTongHop_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

End Class
