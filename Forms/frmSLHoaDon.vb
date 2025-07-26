Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class frmSLHoaDon
    Dim bThemMoi As Boolean
    Dim somat, sotra, thangtra, thangmat As Integer
    Dim SohieuHD As String = String.Empty
    Dim Chon As Integer
    Private Sub Chk_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Chk.CheckStateChanged
        If Chk.CheckState Then
            '        Label1(7).Visible = True
            '        Text(6).Visible = True
            Text_Renamed(6).Text = ConvertToStrSafe(thangmat)
            '        Text(4).Visible = True
            Text_Renamed(4).Text = ConvertToStrSafe(somat)
        Else
            Label1(7).Visible = False
            Text_Renamed(6).Visible = False
            Text_Renamed(6).Text = "0"
            Text_Renamed(4).Visible = False
            Text_Renamed(4).Text = "0"
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkMat_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkMat.CheckStateChanged
        If ChkMat.CheckState Then
            '        Label1(5).Visible = True
            '        Text(5).Visible = True
            Text_Renamed(5).Text = ConvertToStrSafe(thangtra)
            '        Text(7).Visible = True
            Text_Renamed(7).Text = ConvertToStrSafe(sotra)
        Else
            Label1(5).Visible = False
            Text_Renamed(5).Visible = False
            Text_Renamed(5).Text = "0"
            Text_Renamed(7).Visible = False
            Text_Renamed(7).Text = "0"
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CmdDanhSach_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CmdDanhSach_0.Click
        FrmLoaiHoaDon.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_2.Click, _Command_3.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim KyHieu As String = String.Empty
        Dim SoHDDau As Integer
        Try
            Dim tmp As Integer
            Select Case Index
                Case 0
                    If bThemMoi Then
                        If Text_Renamed(0).Text <> String.Empty And Text_Renamed(1).Text <> String.Empty Then
                            tmp = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(*) as F1 FROM SLHoaDon WHERE KyHieu='{0}' AND SoHDDau={1}", Text_Renamed(0).Text, Text_Renamed(1).Text)))
                            If tmp = 0 And KiemTraDuLieu() Then
                                ExecSQLNonQuery(String.Format("INSERT INTO SLHoaDon (KyHieu,SoHDDau,Soluong,ThangNhap,LoaiHD,sotra,thangtra,somat,thangmat) VALUES (N'{0}',{1},{2},{3},{4},{5},{6})", _
                                                    Text_Renamed(0).Text, _
                                                    Text_Renamed(1).Text, _
                                                    Text_Renamed(2).Text, _
                                                    Text_Renamed(3).Text, _
                                                    ConvertToStrSafe(cboLoai.SelectedValue), _
                                                    (IIf(Chk.CheckState = CheckState.Checked, _
                                                         String.Format("{0},{1}", ConvertToStrSafe(ConvertToDblSafe(Text_Renamed(4).Text)), ConvertToStrSafe(ConvertToDblSafe(Text_Renamed(6).Text))), _
                                                         "0,0")), _
                                                    (IIf(ChkMat.CheckState = CheckState.Checked, String.Format("{0},{1}", _
                                                                                                     ConvertToStrSafe(ConvertToDblSafe(Text_Renamed(5).Text)), _
                                                                                                     ConvertToStrSafe(ConvertToDblSafe(Text_Renamed(7).Text))), "0,0"))))
                                ListHD.Items.Add(String.Format("{0}{1}{2}", Text_Renamed(0).Text, Chr(9), Text_Renamed(1).Text))
                                If ListHD.Items.Count > 0 Then ListHD.SelectedIndex = ListHD.Items.Count - 1
                            Else
                                ListHD_SelectedIndexChanged(ListHD, New EventArgs())
                            End If
                            If ListHD.Items.Count > 0 Then ListHD.SelectedIndex = 0
                            bThemMoi = False Or (ListHD.Items.Count = 0)
                            Command(2).Enabled = Not bThemMoi
                            Command(1).Enabled = ListHD.Items.Count > 0
                        Else
                            Text_Renamed(0).Focus()
                            UNET.myUMessager.mError(Ngonngu("Ký hiệu hoặc số hóa đơn không được trống.", "The invoice or invoice number must not be blank."), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        
                    Else
                        LayThongTinList(KyHieu, SoHDDau)
                        If MessageBox.Show(String.Format("Bạn có chắc là sửa thông tin {0} - {1} này không?", KyHieu, ConvertToStrSafe(SoHDDau)), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                            If KiemTraDuLieu() Then
                                ExecSQLNonQuery(String.Format("UPDATE SLHoaDon SET somat={0},thangmat={1},sotra={2},thangtra={3},KyHieu=N'{4}',SoHDDau={5},SoLuong={6},ThangNhap={7},LoaiHD={8} WHERE KyHieu='{9}' and SoHDDau={10}", (IIf(ChkMat.CheckState = CheckState.Checked, ConvertToDblSafe(Text_Renamed(5).Text), 0)), ConvertToStrSafe(IIf(ChkMat.CheckState = CheckState.Checked, ConvertToDblSafe(Text_Renamed(7).Text), 0)), ConvertToStrSafe(IIf(Chk.CheckState = CheckState.Checked, ConvertToDblSafe(Text_Renamed(4).Text), 0)), ConvertToStrSafe(IIf(Chk.CheckState = CheckState.Checked, ConvertToDblSafe(Text_Renamed(6).Text), 0)), Text_Renamed(0).Text, Text_Renamed(1).Text, Text_Renamed(2).Text, Text_Renamed(3).Text, ConvertToStrSafe(cboLoai.SelectedValue), KyHieu, ConvertToStrSafe(SoHDDau)))
                                ListShow()
                                If ListHD.Items.Count > 0 Then ListHD.SelectedIndex = 0
                            Else
                                ListHD_SelectedIndexChanged(ListHD, New EventArgs())
                            End If
                        End If
                    End If
                    '        RFocus Text(0)
                    Khoaquyen()
                Case 1
                    LayThongTinList(KyHieu, SoHDDau)
                    Dim res As MsgBoxResult = MessageBox.Show(String.Format("Bạn có chắc là xoá thông tin {0} - {1} này không?", KyHieu, ConvertToStrSafe(SoHDDau)), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If res = System.Windows.Forms.DialogResult.Yes Then
                        DeleteRecord("SLHoaDon", KyHieu, SoHDDau)
                        ListHD.Items.RemoveAt(ConvertToDblSafe(ListHD.SelectedIndex))
                        If ListHD.Items.Count > 0 Then ListHD.SelectedIndex = 0
                        bThemMoi = bThemMoi Or (ListHD.Items.Count = 0)
                        Command(2).Enabled = Not bThemMoi
                        Command(1).Enabled = (ListHD.Items.Count > 0)
                        ListHD_SelectedIndexChanged(ListHD, New EventArgs())
                    End If
                Case 2
                    Text_Renamed(0).Text = ""
                    Text_Renamed(1).Text = "0"
                    Text_Renamed(2).Text = "0"
                    Text_Renamed(3).Text = "1"
                    Text_Renamed(4).Text = "0"
                    Text_Renamed(0).Focus()
                    If cboLoai.Items.Count > 0 Then cboLoai.SelectedIndex = 0
                    bThemMoi = True
                    Command(2).Enabled = Not bThemMoi
                Case 3
                    Me.Hide()
                Case Else
            End Select
        Catch
        End Try
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        'Int_RecsetToCbo("SELECT distinct SoHieu + '  ' + Ten AS F1, MaSo as F2, SoHieu FROM LoaiHoaDon order by SoHieu", cboLoai)
        'ListShow()
        'If ListHD.Items.Count > 0 Then
        '    ListHD.SelectedIndex = 0
        'End If
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmSLHoaDon_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.X
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.G
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.T
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmSLHoaDon_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        ' Init form 
        Call FormInit()
        Int_RecsetToCbo("SELECT distinct SoHieu + '  ' + Ten AS F1, MaSo as F2, SoHieu FROM LoaiHoaDon order by SoHieu", cboLoai)

        If cboLoai.Items.Count > 0 Then
            cboLoai.SelectedIndex = 0
        End If
        ListShow()
        If ListHD.Items.Count > 0 Then
            ListHD.SelectedIndex = 0
        End If
        Command(1).Enabled = ListHD.Items.Count > 0
        bThemMoi = False Or (ListHD.Items.Count = 0)
        Command(2).Enabled = Not bThemMoi
        Dim dt As New DataTable
        'dt = IF0005.tao_doi()
        'lue_loai_hd.Properties.DataSource = dt
        'lue_loai_hd.Properties.DisplayMember = "Mã"
        'lue_loai_hd.Properties.ValueMember = "Mã"
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ListShow()
        Dim rs As DataTable = ExecSQLReturnDT("SELECT KyHieu,SoHDDau,SoLuong,ThangNhap FROM SlHoaDon ORDER BY ThangNhap ASC")
        Do While ListHD.Items.Count > 0
            ListHD.Items.RemoveAt(0)
        Loop
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            ListHD.Items.Add(String.Format("{0}{1}{2}", rsItem("KyHieu"), Chr(9), rsItem("SoHDDau")))
            ''rs.MoveNext()
        Loop
        ''rs.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmSLHoaDon_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        UpdateSLHoaDon()
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ListHD_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ListHD.SelectedIndexChanged
        Dim KyHieu As String = String.Empty
        Dim SoHDDau As Integer
        LayThongTinList(KyHieu, SoHDDau)
        ShowChitiet(KyHieu, SoHDDau)
        bThemMoi = False Or (ListHD.Items.Count = 0)
        Command(2).Enabled = Not bThemMoi

        'For Each item As ComboBoxEx.ComboBoxItem In cboLoai.Items.ItemsBase
        '    If item.ValueKey = ListHD.Text Then
        '        cboLoai.SelectedItem = item
        '        Exit For
        '    End If
        'Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="KyHieu"></param>
    ''' <param name="SoHDDau"></param>
    ''' <remarks></remarks>
    Private Sub ShowChitiet(ByRef KyHieu As String, ByRef SoHDDau As Integer)
        Dim ThangNhap, LoaiHD As Integer
        Dim soluong As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Soluong as F1,ThangNhap as F2,LoaiHD as F3,sotra as f4,thangtra as f5,somat as f6,thangmat as f7 FROM SLHoaDon WHERE KyHieu='{0}' AND SoHDDau={1}", KyHieu, ConvertToStrSafe(SoHDDau)), ThangNhap, LoaiHD, sotra, thangtra, somat, thangmat))
        ' ThangNhap = ConvertToDblSafe(GetSelectValue(String.Format("SELECT ThangNhap as F1,LoaiHD as F2,sotra as f4,thangtra as f5,somat as f6,thangmat as f7 FROM SLHoaDon WHERE KyHieu='{0}' AND SoHDDau={1}", KyHieu, ConvertToStrSafe(SoHDDau)), ThangNhap, LoaiHD, sotra, thangtra, somat, thangmat))
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT ThangNhap as F1,LoaiHD as F2,sotra as f4,thangtra as f5,somat as f6,thangmat as f7 FROM SLHoaDon WHERE KyHieu='{0}' AND SoHDDau={1}", KyHieu, ConvertToStrSafe(SoHDDau)))
        If rs.Rows.Count > 0 Then
            ThangNhap = ConvertToIntSafe(rs.Rows(0)("F1"))
            LoaiHD = ConvertToIntSafe(rs.Rows(0)("F2"))
            sotra = ConvertToIntSafe(rs.Rows(0)("F4"))
            thangtra = ConvertToIntSafe(rs.Rows(0)("F5"))
            somat = ConvertToIntSafe(rs.Rows(0)("F6"))
            thangmat = ConvertToIntSafe(rs.Rows(0)("F7"))
        End If
        Text_Renamed(0).Text = KyHieu
        Text_Renamed(1).Text = ConvertToStrSafe(SoHDDau)
        Text_Renamed(2).Text = ConvertToStrSafe(soluong)
        Text_Renamed(3).Text = ConvertToStrSafe(ThangNhap)
        If sotra <> 0 Then
            Chk.CheckState = CheckState.Checked
            Text_Renamed(4).Text = ConvertToStrSafe(sotra)
            Text_Renamed(6).Text = ConvertToStrSafe(thangtra)
        Else
            Chk.CheckState = CheckState.Unchecked
        End If
        If somat <> 0 Then
            ChkMat.CheckState = CheckState.Checked
            Text_Renamed(5).Text = ConvertToStrSafe(somat)
            Text_Renamed(7).Text = ConvertToStrSafe(thangmat)
        Else
            ChkMat.CheckState = CheckState.Unchecked
        End If
        ' If cboLoai.Items.Count > 0 Then cboLoai.SelectedIndex = LoaiHD - 1
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Table"></param>
    ''' <param name="KyHieu"></param>
    ''' <param name="SoHDDau"></param>
    ''' <remarks></remarks>
    Private Sub DeleteRecord(ByRef Table As String, ByRef KyHieu As String, ByRef SoHDDau As Integer)
        ExecSQLNonQuery(String.Format("DELETE FROM {0} WHERE KyHieu='{1}' AND SoHDDau={2}", Table, KyHieu, ConvertToStrSafe(SoHDDau)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="KyHieu"></param>
    ''' <param name="SoHDDau"></param>
    ''' <remarks></remarks>
    Private Sub LayThongTinList(ByRef KyHieu As String, ByRef SoHDDau As Integer)
        For i As Integer = 1 To Strings.Len(ListHD.Text)
            If Strings.Mid(ListHD.Text, i, 1) = Chr(9).ToString() Then
                KyHieu = Strings.Left(ListHD.Text, i - 1)
                SoHDDau = ConvertToDblSafe(Strings.Right(ListHD.Text, Strings.Len(ListHD.Text) - i))
                Exit For
            End If
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraDuLieu() As Boolean
        Dim result As Boolean = False
        result = True
        If ConvertToDblSafe(Text_Renamed(1).Text) <= 0 Then result = False
        If ConvertToDblSafe(Text_Renamed(2).Text) <= 0 Then result = False
        If ConvertToDblSafe(Text_Renamed(3).Text) < 0 Or ConvertToDblSafe(Text_Renamed(3).Text) > 12 Then result = False
        If Not result Then
            MessageBox.Show(Ngonngu("Thông tin nhập vào không chính xác", "Incorrect information"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return result
    End Function
    Private Sub ListHD_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles ListHD.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = ConvertToDblSafe(Keys.Return) And Chon = 1 Then Me.Hide()
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
    Private Sub Text_Renamed_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_7.Enter, _Text_6.Enter, _Text_4.Enter, _Text_5.Enter, _Text_3.Enter, _Text_2.Enter, _Text_1.Enter, _Text_0.Enter
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Text_Renamed(Index).SelectAll()
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(1).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Chonkyhieu(ByRef sh As String) As String
        Dim result As String = String.Empty
        Chon = 1
        Me.ShowDialog()
        result = Text_Renamed(0).Text
        Chon = 0
        Return result
    End Function
    Public Function Chonmauso(ByRef sh As String) As String
        Dim result As String = String.Empty
        Chon = 1
        Me.ShowDialog()
        result = ConvertToStrSafe(GetSelectValue(String.Format("SELECT loaihoadon.sohieu as f1 FROM loaihoadon inner join slhoadon on loaihoadon.maso=slhoadon.loaihd WHERE slhoadon.kyhieu='{0}'", Text_Renamed(0).Text)))
        Chon = 0
        Return result
    End Function

    Private Sub cboLoai_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLoai.SelectedIndexChanged
        Dim rs As DataTable = ExecSQLReturnDT("SELECT KyHieu,SoHDDau,SoLuong,ThangNhap FROM SlHoaDon where loaihd = " & cboLoai.SelectedValue & " ORDER BY ThangNhap ASC")
        Do While ListHD.Items.Count > 0
            ListHD.Items.RemoveAt(0)
        Loop
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            ListHD.Items.Add(String.Format("{0}{1}{2}", rsItem("KyHieu"), Chr(9), rsItem("SoHDDau")))
            ''rs.MoveNext()
        Loop
    End Sub
    Public Sub ky_hieu_hd()
        Dim chuoi As String = ""
        If rb_tu.Checked = True Then
            chuoi = "T"
        End If
        If rb_dat.Checked = True Then
            chuoi = "P"
        End If
        If rb_dien.Checked = True Then
            chuoi = "E"
        End If
        'If CInt(sp_nam.Text) < 10 Then
        '    _Text_0.Text = lue_loai_hd.EditValue & "/0" & sp_nam.Text & chuoi
        'Else
        '    _Text_0.Text = lue_loai_hd.EditValue & "/" & sp_nam.Text & chuoi
        'End If
    End Sub

    'Private Sub lue_loai_hd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lue_loai_hd.EditValueChanged
    '    ky_hieu_hd()
    'End Sub

    Private Sub rb_tu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_tu.CheckedChanged
        ky_hieu_hd()
    End Sub

    Private Sub rb_dat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_dat.CheckedChanged
        ky_hieu_hd()
    End Sub

    Private Sub rb_dien_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_dien.CheckedChanged
        ky_hieu_hd()
    End Sub
End Class
