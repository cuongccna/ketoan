Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmSochitiet

    Dim Ngay(1) As Date
    Dim tdau, tcuoi As Integer
    Dim tondk As Double
    Private Sub CmdTK_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CmdTK_0.Click, _CmdTK_1.Click
        Dim Index As Integer = Array.IndexOf(CmdTK, eventSender)
        Select Case Index
            Case 0
                Me.Cursor = Cursors.WaitCursor
                txtShTk(0).Text = FrmTaikhoan.ChonTk(txtShTk(0).Text)
                txtShTk_Leave(txtShTk(0), New EventArgs())
                Me.Cursor = Cursors.Default
            Case 1
                Me.Cursor = Cursors.WaitCursor
                txtShTk(1).Text = FrmTaikhoan.ChonTk(txtShTk(1).Text)
                txtShTk_Leave(txtShTk(1), New EventArgs())
                Me.Cursor = Cursors.Default
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim ten As String = String.Empty
        Dim taikhoan As New ClsTaikhoan
        Dim doiung As New ClsTaikhoan
        Dim ton, dk As Double
        Dim SoHieu As String = String.Empty
        Select Case Index
            Case 0
                If CboThang(1).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                If Ngay(1) < Ngay(0) Then
                    MedNgay(1).Text = MedNgay(0).Text : MedNgay_Leave(MedNgay(1), New EventArgs())
                End If
                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue

                If ConvertToStrSafe(txtShTk(0).Tag) = "" Then GoTo Loi
                taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(0).Tag))
                If Chk.CheckState Then
                    doiung.InitTaikhoanMaSo(IIf(ConvertToStrSafe(txtShTk(1).Tag) = "", 0, ConvertToDblSafe(txtShTk(1).Tag)))
                Else
                    doiung.InitTaikhoanMaSo(0)
                End If
                LietKeSoChitiet(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), True, doiung.sohieu, 0, 0)
            Case 1
                Me.Close() : Exit Sub
            Case 2
                SoHieu = txtShTk(0).Text
                If Strings.Left(SoHieu, 2) = "15" Or Strings.Left(SoHieu, 3) = "131" Or Strings.Left(SoHieu, 3) = "331" Or Strings.Left(SoHieu, 3) = "211" Or Strings.Left(SoHieu, 3) = "214" Or Strings.Left(SoHieu, 3) = "142" Or Strings.Left(SoHieu, 3) = "242" Then
                    MessageBox.Show(Ngonngu("Không được sửa đầu kỳ của tài khoản : ", "Not edit the beginning of the account") & SoHieu, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End If
                dk = ConvertToDblSafe((GetSelectValue("SELECT count(*) as f1 FROM hethongtk WHERE left(sohieu," & SoHieu.Length & ")='" & SoHieu & "'")))
                If dk > 1 Then
                    MessageBox.Show(Ngonngu("Tài khoản có chi tiết không được sửa !", "Detailed account has not been fixed"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                ton = ConvertToDblSafe(Format(ConvertToDblSafe(txtdauky(0).Text) - ConvertToDblSafe(txtdauky(1).Text), Mask_2))
                If ton <> tondk And tdau = 1 And OptTG(0).Checked Then
                    ExecSQLNonQuery("UPDATE hethongtk set " & (IIf(ton > 0, "duco_0=0,duno_0=" & Math.Abs(ton), "duno_0=0,duco_0=" & Math.Abs(ton))) & " WHERE sohieu='" & SoHieu & "'")
                    KiemTraTaiKhoan()
                    Command_ClickEvent(Command(0), New EventArgs())
                End If
        End Select
        Exit Sub
Loi:
        txtShTk(0).Focus()
        Me.Text = "Sổ chi tiết"
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSochitiet_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.G
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V
                    Command(1).Focus()
                    '  Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.L
                    Command(0).Focus()
                    '  Command_ClickEvent(Command(0), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub


    Private Sub Khoi_Tao()
        ColumnSetUp(Grd, 0, 350, 2)
        ColumnSetUp(Grd, 1, 1190, 0)
        ColumnSetUp(Grd, 2, 830, 1)
        ColumnSetUp(Grd, 3, 3110, 0)
        ColumnSetUp(Grd, 4, 710, 2)
        ColumnSetUp(Grd, 5, 1430, 4)
        ColumnSetUp(Grd, 6, 1430, 4)
        ColumnSetUp(Grd, 7, 1520, 4)
        Grd.Cols = 8
        For chi_so As Integer = 0 To 1
            AddMonthToCbo(CboThang(chi_so))
            InitDateVars(MedNgay(chi_so), Ngay(chi_so))
        Next
    End Sub
    Private co As Integer = 0
    Private Sub FrmSochitiet_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()
            If co = 0 Then
                Khoi_Tao()
            End If
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
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Sub Hienthi(ByRef frm As FrmSochiphi)
        Khoi_Tao()
        With frm
            If .OptBC(0).Checked Then
                txtShTk(0).Text = .txtShTk(0).Text : txtShTk_Leave(txtShTk(0), New EventArgs())
                If .ChkDu(0).Checked Then
                    Chk.CheckState = CheckState.Checked
                    txtShTk(1).Text = .txtShTk(5).Text
                    txtShTk_Leave(txtShTk(1), New EventArgs())
                Else
                    Chk.CheckState = CheckState.Unchecked
                    txtShTk(1).Text = ""
                    txtShTk_Leave(txtShTk(1), New EventArgs())
                End If
                If .OptTG(0).Checked Then
                    OptTG(0).Checked = True
                    CboThang(0).Text = .CboThang(0).Text
                    CboThang(1).Text = .CboThang(1).Text
                Else
                    OptTG(1).Checked = True
                    MedNgay(0).Text = .MedNgay(1).Text
                    MedNgay_Leave(MedNgay(0), New EventArgs())
                    MedNgay(1).Text = .MedNgay(2).Text
                    MedNgay_Leave(MedNgay(1), New EventArgs())
                End If
            End If
        End With
        If txtShTk(0).Text <> "" Then Command_ClickEvent(Command(0), New EventArgs())
        co = 1
        Me.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Sub Hienthi(ByRef frm As FrmMNBaocao)
        Khoi_Tao()
        With frm
            If .OptSo(5).Checked Then
                txtShTk(0).Text = .txtShTk(0).Text
                txtShTk_Leave(txtShTk(0), New EventArgs())
                If .ChkDu(0).Checked Then
                    Chk.CheckState = CheckState.Checked
                    txtShTk(1).Text = .txtShTk(1).Text
                    txtShTk_Leave(txtShTk(1), New EventArgs())
                Else
                    Chk.CheckState = CheckState.Unchecked
                    txtShTk(1).Text = ""
                    txtShTk_Leave(txtShTk(1), New EventArgs())
                End If
                If .OptTG(0).Checked Then
                    OptTG(0).Checked = True
                    CboThang(0).Text = .CboThang(0).Text
                    CboThang(1).Text = .CboThang(1).Text

                Else
                    OptTG(1).Checked = True
                    MedNgay(0).Text = .MedNgay(0).Text
                    MedNgay_Leave(MedNgay(0), New EventArgs())
                    MedNgay(1).Text = .MedNgay(1).Text
                    MedNgay_Leave(MedNgay(1), New EventArgs())
                End If
            End If
        End With
        If txtShTk(0).Text <> "" Then Command_ClickEvent(Command(0), New EventArgs())
        co = 1
        Me.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Sub Hienthi(ByRef frm As FrmCandoi)
        Khoi_Tao()
        With frm
            For chi_so As Integer = 0 To 1
                AddMonthToCbo(CboThang(chi_so))
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next
            OptTG(0).Checked = True
            CboThang(0).Text = .CboThang(0).Text
            CboThang(1).Text = .CboThang(1).Text
            txtShTk(0).Text = .Grd.CtlText.Trim()
            txtShTk_Leave(txtShTk(0), New EventArgs())
        End With
        If txtShTk(0).Text <> "" Then Command_ClickEvent(Command(0), New EventArgs())
        co = 1
        Me.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.DoubleClick
        If MessageBox.Show(Ngonngu("Sửa chứng từ?", "Edit voucher?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Grd.Col = 1 : FrmChungtu.Suatonkho(Grd.CtlText)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grd.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(Grd, Grd.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Enter, _MedNgay_1.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Leave, _MedNgay_1.Leave
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        If Information.IsDate(MedNgay(Index).Text) Then
            Ngay(Index) = ConvertToDateSafe(MedNgay(Index).Text)
        Else
            MedNgay(Index).Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="doiung"></param>
    ''' <param name="VV"></param>
    ''' <param name="loai"></param>
    ''' <param name="nn"></param>
    ''' <param name="mdt1"></param>
    ''' <param name="mdt2"></param>
    ''' <param name="mdt3"></param>
    ''' <remarks></remarks>
    Public Sub LietKeSoChitiet(ByRef taikhoan As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef thongbao As Boolean, ByRef doiung As String, ByRef VV As Integer, Optional ByRef loai As Integer = 0, Optional ByRef nn As Integer = 0, Optional ByRef mdt1 As Integer = 0, Optional ByRef mdt2 As Integer = 0, Optional ByRef mdt3 As Integer = 0)
        Dim dkc, dkn, dknt As Double
        Dim ps As Boolean
        Dim sqlw As String = String.Empty
        Dim sql As String
        Dim i, j, k As Integer
        Dim chuyennganhang As Integer = 0
        Dim ton As Double
        Dim rs As DataTable
        If tcuoi > 0 Then
            ps = taikhoan.TkCoPS(tdau, tcuoi)
            taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
            sqlw = WThang("ThangCT", tdau, tcuoi)
        Else
            ps = taikhoan.TkCoPSN(ndau, ncuoi)
            sqlw = WNgay("NgayGS", ndau, ncuoi)
            taikhoan.SoDuNgay(ndau.AddDays(-1), dkn, dkc, dknt)
        End If
        If dkn = 0 And dkc = 0 And (Not ps) Then
            GoTo KhongIn
        Else
            ton = dkn - dkc
            tondk = ton
            If ton > 0 Then
                txtdauky(0).Text = Format(ton, Mask_0)
                txtdauky(1).Text = Format(0, Mask_0)
            Else
                txtdauky(1).Text = Format(Math.Abs(ton), Mask_0)
                txtdauky(0).Text = Format(0, Mask_0)
            End If
        End If
        ' In bao cao
        If ps Then
            sql = String.Format("((HethongTK_2.SoHieu LIKE '{0}%'{1}) Or (HethongTK_3.SoHieu LIKE '{0}%'{2}))", _
                      taikhoan.sohieu, _
                      (IIf(doiung.Length > 0, String.Format(" And HethongTK_3.SoHieu LIKE '{0}%'", doiung), String.Empty)), _
                      (IIf(doiung.Length > 0, String.Format(" And HethongTK_2.SoHieu LIKE '{0}%'", doiung), String.Empty)))
            'rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu as sohieutk, HeThongTK_1.SoHieu as sohieutk1, ChungTu.MaTKNo, ChungTu.MaTKCo, HethongTK_2.SoHieu As SHNo, HethongTK_3.SoHieu As SHCo,ThangCT,NgayGS FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ({1} And ({2})){3}{4}{5}{6} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayGS,chungtu.sohieu,chungtu.sops desc", _
            '                         (IIf(pnn > 0, "E", String.Empty)), _
            '                         sqlw, _
            '                         sql, _
            '                         (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
            '                         (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
            '                         (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
            '                         (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty))))

            rs = ExecSQLReturnDT(String.Format("SELECT  ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{0}, Sum(ChungTu.SoPS) AS SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu as sohieutk, HeThongTK_1.SoHieu as sohieutk1, ChungTu.MaTKNo, ChungTu.MaTKCo, HethongTK_2.SoHieu As SHNo, HethongTK_3.SoHieu As SHCo,ThangCT,NgayGS FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ({1} And ({2})){3}{4}{5}{6} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) GROUP BY ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai,ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu,ChungTu.MaTKNo, HeThongTK.SoHieu,HeThongTK_1.SoHieu,ChungTu.MaTKNo, ChungTu.MaTKCo,ThangCT,NgayGS,HethongTK_3.SoHieu,HethongTK_2.SoHieu ORDER BY ChungTu.NgayGS,chungtu.sohieu,sops desc", _
                        (IIf(pNN > 0, "E", String.Empty)), _
                        sqlw, _
                        sql, _
                        (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
                        (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
                        (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
                        (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty))))
            ClearGrid(Grd, Grd.Rows)
        Else
            GoTo KhongIn
        End If
        Dim SoPSTK As Double
        Dim stt As Integer = 0
        If rs.Rows.Count > 0 Then
            GauGe.Maximum = rs.Rows.Count
            i = 1
            GauGe.Value = 1
            For k = 0 To rs.Rows.Count - 1
                Dim rsItem As DataRow = rs.Rows(k)
                'For Each rsItem As DataRow In rs.Rows
                If ChkKH.CheckState = CheckState.Checked Then
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(khachhang.maso) as f1 FROM hoadon inner join khachhang on khachhang.maso=hoadon.makhachhang WHERE hoadon.sohd like N'{0}' and khachhang.sohieu like N'{1}'", _
                                                           rsItem(1), _
                                                           TxtSohieu.Text))) <= 0 _
                        AndAlso ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(khachhang.maso) as f1 FROM chungtulq inner join khachhang on khachhang.maso=chungtulq.makh WHERE chungtulq.soctgoc like N'{0}' and khachhang.sohieu like N'{1}'", _
                                                                rsItem(1), _
                                                                TxtSohieu.Text))) <= 0 _
                    Then
                        Continue For
                    End If
                End If
                With Grd
                    stt += 1
                    .AddItem(String.Format("{1}{0}{2}{0}{2}{0}{2}{0}{2}{0}{2}{0}{2}{0}{2}{0}{2}", Chr(9), i, 0))
                    .Row = (i - 1)
                    Dim str = ConvertToStrSafe(i)
                    Dim str1 = ""
                    For j = 1 To 3
                        .Col = ConvertToDblSafe(j)
                        If j = 2 Then
                            .Items(.Row).SubItems(.Col).Text = Format(CDate(rsItem(j)), Mask_D)
                        Else
                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(rsItem(j))
                        End If
                    Next
                    .Col = j
                    If ConvertToDblSafe(rsItem("MaTkNo")) > 0 And ConvertToDblSafe(rsItem("MaTkCo")) > 0 Then
                        If chuyennganhang = 0 And ConvertToDblSafe(rsItem("MaTkNo")) > 0 And rsItem("sohieutk1") Like taikhoan.sohieu & "*" Then
                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(rsItem("sohieutk"))
                            str = str + Chr(9) + ConvertToStrSafe(rsItem("sohieutk"))
                            SoPSTK = ConvertToStrSafe(rsItem("sops"))
                            ton -= SoPSTK
                            .Col = 6
                            .Items(.Row).SubItems(.Col).Text = Format(SoPSTK, Mask_0)
                        Else
                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(rsItem("sohieutk1"))
                            str = str + Chr(9) + ConvertToStrSafe(rsItem("sohieutk1"))
                            SoPSTK = ConvertToStrSafe(rsItem("sops"))
                            ton += SoPSTK
                            .Col = 5
                            .Items(.Row).SubItems(.Col).Text = Format(SoPSTK, Mask_0)
                        End If
                        .Col = 7
                        .Items(.Row).SubItems(.Col).Text = Format(ton, Mask_0)
                    Else
                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(rsItem("GhiChu"))
                    End If
                End With
                GauGe.Value = i
                i += 1
                If rsItem("sohieutk").ToString Like taikhoan.sohieu & "*" And rsItem("sohieutk1").ToString Like taikhoan.sohieu & "*" And chuyennganhang = 0 Then
                    chuyennganhang = 1
                    k -= 1
                    GauGe.Maximum += 1
                Else
                    chuyennganhang = 0
                End If
            Next
            lb_soct.Text = stt
            Label(10).Text = Format(ton, Mask_0)
        End If
        Me.Text = String.Format("Sổ chi tiết trong kỳ {0}", (IIf(OptTG(0).Checked, _
                                                                 String.Format("{0} - {1}", CboThang(0).Text, CboThang(1).Text), _
                                                                 String.Format("{0} - {1}", MedNgay(0).Text, MedNgay(1).Text))))
        Exit Sub
KhongIn:
        If thongbao Then MessageBox.Show(Ngonngu("Không có số đầu kỳ hoặc phát sinh !", "There are no beginning or arising !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtdauky_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtdauky_1.KeyPress, _txtdauky_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If Not (KeyAscii >= 48 And KeyAscii <= 57) And KeyAscii <> 8 Then
            MessageBox.Show(Ngonngu("Chỉ được nhập số !", "Numbers only"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            KeyAscii = 0
        Else
            If tdau <> 1 And OptTG(0).Checked Then
                KeyAscii = 0
                MessageBox.Show(Ngonngu("Tồn đầu kỳ chỉ được sửa khi tháng đầu = 1", "There is only the beginning when the first correct = 1"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_1.KeyPress, _txtShTk_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If KeyAscii = 13 Then
            Select Case Index
                Case 0
                    txtShTk(0).Text = FrmTaikhoan.ChonTk(txtShTk(0).Text)
                Case 1
                    txtShTk(1).Text = FrmTaikhoan.ChonTk(txtShTk(1).Text)
            End Select
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
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_1.Leave, _txtShTk_0.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).Tag = Timten("maso", txtShTk(Index).Text, "sohieu", "hethongtk")
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtSohieu_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtSohieu.Enter
        TxtSohieu.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtSohieu_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles TxtSohieu.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Me.Cursor = Cursors.WaitCursor
        If KeyAscii = 13 Then
            TxtSohieu.Text = FrmKhachHang.ChonKhachHang(TxtSohieu.Text)
        End If
        Me.Cursor = Cursors.Default
        TxtSohieu.Focus()
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSochitiet_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
