Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmMNVatTu
    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmd1_7.Click, _Cmd1_8.Click, _Cmd1_9.Click, _Cmd1_11.Click, _Cmd1_12.Click, _Cmd1_13.Click, _Cmd1_14.Click, _Cmd1_15.Click, _Cmd1_19.Click, _Cmd1_0.Click, _Cmd1_1.Click, _Cmd1_2.Click, _Cmd1_3.Click, _Cmd1_4.Click, _Cmd1_5.Click, _Cmd1_6.Click, _Cmd1_10.Click, _Cmd1_17.Click, _Cmd1_18.Click, _Cmd1_16.Click, _Cmd1_20.Click, _Cmd1_21.Click, _Cmd1_22.Click
        Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
        Dim loai As Integer
        Select Case Index
            Case 0, 3, 4, 20, 21
                loai = IIf(Index = 0 Or Index = 21, 1, IIf(Index = 3, 8, 2))
                If Index = 0 Or Index = 21 Then
                    FrmChungtu.initOption = 1
                ElseIf Index = 3 Then
                    'Bán hàng
                    FrmChungtu.initOption = 8
                Else
                    'Xuất hàng
                    FrmChungtu.initOption = 2
                End If
                FrmChungtu.initOption = loai
                FrmChungtu.ShowDialog()
            Case 1, 18
                If Index = 1 Then
                    CPGV.Tag = "0"
                Else
                    CPGV.Tag = "1"
                End If
                CPGV.ShowDialog()
            Case 2
                If pRpt = CheckState.Checked And User_Right = 1 Then
                    ErrMsg(er_KoSD)
                    Exit Sub
                End If
                FrmSovattuhanghoa.ShowDialog()
            Case 5
                If STDetail Then
                    FrmLuuChuyen.ShowDialog()
                Else
                    frmMain.NoRight(1)
                End If
            Case 6
                If Not STDetail Then
                    frmMain.NoRight(1)
                    GoTo kt
                End If
                KiemTraVatTu()
                HienThongBao("Xong ...", 1)
                Exit Sub
            Case 7
                FrmNguon.ShowDialog()
            Case 8
                If STDetail Then
                    FrmKho.Tag = "1"
                    FrmKho.ShowDialog()
                Else
                    frmMain.NoRight(1)
                End If
            Case 9
                frmPhanLoaiVT.pl1 = "1"
                frmPhanLoaiVT.ShowDialog()
                frmPhanLoaiVT.pl1 = "0"
            Case 10
                If ChoDieuChinhDauKy() Then
                    FVTDauKy.ShowDialog()
                End If
            Case 11
                If STDetail Then
                    FrmVattu.ShowDialog()
                Else
                    frmMain.NoRight(1)
                End If
            Case 12
                If STDetail Then
                    FrmDuphong.ShowDialog()
                Else
                    frmMain.NoRight(1)
                End If
            Case 13 : If KtraMKAdmin() Then
                    frmMain.DatTKVT()
                Else
                    frmMain.DatTKVT()
                End If
            Case 14 : If KtraMKAdmin() Then
                    frmMain.DatTKDTTP()
                Else
                    frmMain.DatTKDTTP()
                End If
            Case 15 : FrmHD.ShowDialog()
            Case 16 : Me.Close() : Exit Sub
            Case 17 : Lapbangke()
            Case 19 : FrmHDnoidia.ShowDialog()
            Case 22
                FrmChungtu.initOption = 0
                'Chi phí nhập hàng
                FrmChungtu.loai1.Tag = "0"
                FrmChungtu.ShowDialog()
        End Select
kt:
        HienThongBao("", 1)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNVatTu_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Or ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNVatTu_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub FrmMNVatTu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFont(Me)
    End Sub
End Class
