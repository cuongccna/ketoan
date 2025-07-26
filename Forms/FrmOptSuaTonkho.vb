Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmOptSuaTonkho

    Dim sh, ma, ma1 As String
    Dim MaSo As Double
    Dim OK As Integer

    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        MaSo = 0
        Me.Hide()
        Dim loai As Integer
        If Index = 0 Then
            OK = 1
            If FrmChitietTonkho.Visible Then
                FrmChitietTonkho.Grd.Col = 1
                sh = FrmChitietTonkho.Grd.CtlText
                ma1 = ConvertToStrSafe(FrmChitietTonkho.mvt1)
            ElseIf FrmChitietThekho.Visible Then
                FrmChitietThekho.Grd.Col = 1
                sh = FrmChitietThekho.Grd.CtlText
                ma1 = ConvertToStrSafe(FrmChitietThekho.mvt1)
            ElseIf FrmBangke.Visible Then
                FrmBangke.Grd.Col = 13
                sh = FrmBangke.Grd.CtlText
                FrmBangke.Grd.Col = 12
                MaSo = ConvertToDblSafe(FrmBangke.Grd.CtlText)
            End If
            If Opt(0).Checked Then
                FrmChungtu.Suatonkho(sh)
            ElseIf FrmDinhmuc.Visible Then
                FrmDinhmuc.GrdChungtu.Col = 5
                If Opt(1).Checked Then
                    ma = Timten("maso", txtVT.Text, "sohieu", "vattu")
                    ExecSQLNonQuery("UPDATE dinhmuc set manvl=" & ma & " WHERE maso=" & FrmDinhmuc.GrdChungtu.CtlText, False)
                Else
                    ExecSQLNonQuery("UPDATE dinhmuc set soluong=" & ConvertToDblSafe(txtVT.Text) & " WHERE maso=" & FrmDinhmuc.GrdChungtu.CtlText, False)
                End If
            Else
                loai = ConvertToDblSafe(Timten("maloai", sh, "sohieu", "chungtu"))
                If loai = 9 Or loai = 13 Then
                    MessageBox.Show(Ngonngu("Không được sửa công cụ và tài sản ở đây!", "Not edit tools and fixed assets here!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                End If
                If Opt(1).Checked Then
                    ma = Timten("maso", txtVT.Text, "sohieu", "vattu")
                    If ma = "" Then
                        MessageBox.Show(Ngonngu("Vui lòng nhập chính xác mã vật tư cần chuyển đến", "Please correct code goods to move"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                    End If
                    If Not FrmBangke.Visible Then MaSo = ConvertToDblSafe(GetSelectValue("SELECT maso as f1 FROM chungtu WHERE sohieu='" & sh & "' and mavattu=" & ma1))
                    ExecSQLNonQuery("UPDATE chungtu set mavattu=" & ConvertToStrSafe(ma) & " WHERE maso=" & ConvertToStrSafe(MaSo))
                    ExecSQLNonQuery("UPDATE chungtu set mavattu=" & ConvertToStrSafe(ma) & " WHERE ct_id=" & ConvertToStrSafe(500000000 + MaSo))
                    KiemTraVatTu()
                Else
                    ma = Timten("maso", txtVT.Text, "sohieu", "hethongtk")
                    If ma = "" Then
                        MessageBox.Show(Ngonngu("Vui lòng nhập chính xác mã tài khoản cần chuyển đến", "Please correct code acount to move"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                    End If
                    FrmBangke.Grd.Col = 1
                    ma1 = ConvertToDblSafe(FrmBangke.Grd.CtlText)
                    MaSo = ConvertToDblSafe(GetSelectValue("SELECT maso as f1 FROM hethongtk WHERE sohieu='" & ma1 & "'"))
                    If FrmBangke.loai = 2 Then
                        ExecSQLNonQuery("UPDATE chungtu set matkco=" & ConvertToStrSafe(ma) & " WHERE sohieu='" & sh & "' and matkco=" & ConvertToStrSafe(MaSo))
                        If ma1 = "5112" And txtVT.Text = "5111" Then
                            ma = Timten("maso", "1561", "sohieu", "hethongtk")
                            If ma = "" Then ma = Timten("maso", "156", "sohieu", "hethongtk")
                            MaSo = ConvertToDblSafe(Timten("maso", "1551", "sohieu", "hethongtk"))
                            If MaSo = 0 Then MaSo = ConvertToDblSafe(Timten("maso", "155", "sohieu", "hethongtk"))
                            ExecSQLNonQuery("UPDATE chungtu set matkco=" & ConvertToStrSafe(ma) & " WHERE sohieu='" & sh & "GV' and matkco=" & ConvertToStrSafe(MaSo))
                        Else
                            If ma1 = "5111" And txtVT.Text = "5112" Then
                                ma = Timten("maso", "1551", "sohieu", "hethongtk")
                                If ma = "" Then ma = Timten("maso", "155", "sohieu", "hethongtk")
                                MaSo = ConvertToDblSafe(Timten("maso", "1561", "sohieu", "hethongtk"))
                                If MaSo = 0 Then MaSo = ConvertToDblSafe(Timten("maso", "156", "sohieu", "hethongtk"))
                                ExecSQLNonQuery("UPDATE chungtu set matkco=" & ConvertToStrSafe(ma) & " WHERE sohieu='" & sh & "GV' and matkco=" & ConvertToStrSafe(MaSo))
                            End If
                        End If
                    Else
                        ExecSQLNonQuery("UPDATE chungtu set matkno=" & ConvertToStrSafe(ma) & " WHERE sohieu='" & sh & "' and matkno=" & ConvertToStrSafe(MaSo))
                    End If
                End If
            End If
        End If
    End Sub

    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If FrmDinhmuc.Visible Then
            Opt(0).Visible = False
            Opt(2).Visible = True
            Opt(2).Text = "Đổi số lượng"
            If Opt(0).Checked Then Opt(1).Checked = True
        ElseIf Not FrmBangke.Visible Then
            Opt(2).Visible = False
            If Opt(2).Checked Then Opt(1).Checked = True
        Else
            Opt(2).Visible = True
            Opt(2).Text = "Đổi số tài khoản"
        End If
        Khoaquyen()
    End Sub

    Private Sub FrmOptSuaTonkho_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub


    Private Sub FrmOptSuaTonkho_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private isInitializingComponent As Boolean
    Private Sub Opt_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Opt_2.CheckedChanged, _Opt_1.CheckedChanged, _Opt_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(Opt, eventSender)
            txtVT.Visible = Opt(1).Checked Or Opt(2).Checked
            Label.Visible = Opt(1).Checked Or Opt(2).Checked
            If Index = 1 Or Index = 2 Then txtVT.Focus()
            If Opt(1).Checked Then
                Label.Text = "Mã vật tư"
            ElseIf FrmDinhmuc.Visible Then
                Label.Text = "Số lượng"
            Else
                Label.Text = "Mã tài khoản"
            End If
        End If
    End Sub

    Private Sub txtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtVT.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii <> 27 And Opt(2).Checked And FrmDinhmuc.Visible Then
            KeyProcess5(txtVT, KeyAscii, True)
        ElseIf KeyAscii = 13 Then
            If Opt(1).Checked Then
                txtVT.Text = FrmVattu.ChonVattu(txtVT.Text)
            Else
                txtVT.Text = FrmTaikhoan.ChonTk(txtVT.Text)
            End If
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    Public Function thuchien() As Integer
        OK = 0
        Me.ShowDialog()
        Return OK
    End Function

    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    Private Sub FrmOptSuaTonkho_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
