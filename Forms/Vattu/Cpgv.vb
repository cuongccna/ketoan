Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class CPGV
    Private _propertyName As UInteger
    Public tien, thuedacbiet As Double
    Private _vt As ClsVattu = Nothing
    Private doi As Integer
    Private formInitDone As Boolean = False
    Dim RongSL As Integer, RongTT As Integer
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property vt() As ClsVattu
        Get
            If _vt Is Nothing Then
                _vt = New ClsVattu()
            End If
            Return _vt
        End Get
        Set(ByVal Value As ClsVattu)
            _vt = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CPGV_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            AddMonthToCbo(Cbo(0))
            'van.nguyen 4-Dec-2011
            txtShTk(0).Text = taikhoanconnhat("156")
            txtShTk(1).Text = taikhoanconnhat("33332")
            txtShTk(2).Text = taikhoanconnhat("1422")
            txtShTk(3).Text = taikhoanconnhat("3332")
            txtShTk(4).Text = taikhoanconnhat("133121")
            txtShTk(5).Text = taikhoanconnhat("333121")
            TxtThueSuat.Text = Tag * 10
            Me._Command_3.Visible = True
            If ConvertToDblSafe(Me.Tag) > 0 Then
                txtShTk(4).Text = taikhoanconnhat("133111")
                NhapNoiDiaSettings()

                doi = 0
                UpdateDoiTuongCTTable()
                ColumnSetUp(Grd, 0, 1190, 2)
                ColumnSetUp(Grd, 1, 2510, 0)
                ColumnSetUp(Grd, 2, 710, 2)
                ColumnSetUp(Grd, 3, 230, 0)
                ColumnSetUp(Grd, 4, 830, 4)
                ColumnSetUp(Grd, 5, 0, 1)
                ColumnSetUp(Grd, 6, 0, 1)
                ColumnSetUp(Grd, 7, 1910, 4)
                ColumnSetUp(Grd, 8, 0, 1)
                ColumnSetUp(Grd, 9, 0, 1)
                ColumnSetUp(Grd, 10, 0, 1)
                ColumnSetUp(Grd, 11, 0, 1)
                ColumnSetUp(Grd, 12, 1400, 4)
                ColumnSetUp(Grd, 13, 0, 1)
                ColumnSetUp(Grd, 14, 0, 0)
                ColumnSetUp(Grd, 15, 0, 0)
                If txtShTk(2).Text <> "" Then
                    Dim s As String = String.Format("SELECT sohieu AS F1, MaSo as F2 FROM DoituongCT WHERE MaSo>1 and thang={0}{1} ORDER BY sohieu", _
                                                Cbo(0).SelectedValue, _
                                                IIf(txtShTk(2).Text Like "1422*", " and DoituongCT.DienGiai not like '...%'", " and DoituongCT.DienGiai like '...%'"))
                    Int_RecsetToCbo(String.Format("SELECT sohieu AS F1, MaSo as F2 FROM DoituongCT WHERE MaSo>1 and thang={0}{1} ORDER BY sohieu", _
                                                                Cbo(0).SelectedValue, _
                                                                IIf(txtShTk(2).Text Like "1422*", " and DoituongCT.DienGiai not like '...%'", " and DoituongCT.DienGiai like '...%'")), Cbo(1))
                End If
            Else

                doi = 0
                UpdateDoiTuongCTTable()
                ColumnSetUp(Grd, 0, 1190, 2)
                ColumnSetUp(Grd, 1, 2510, 0)
                ColumnSetUp(Grd, 2, 710, 2)
                ColumnSetUp(Grd, 3, 230, 0)
                ColumnSetUp(Grd, 4, 830, 4)
                ColumnSetUp(Grd, 5, 950, 4)
                ColumnSetUp(Grd, 6, 1550, 4)
                ColumnSetUp(Grd, 7, 1910, 4)
                ColumnSetUp(Grd, 8, 350, 4)
                ColumnSetUp(Grd, 9, 1310, 4)
                ColumnSetUp(Grd, 10, 350, 4)
                ColumnSetUp(Grd, 11, 1310, 4)
                ColumnSetUp(Grd, 12, 1400, 4)
                ColumnSetUp(Grd, 13, 1, 1)
                ColumnSetUp(Grd, 14, 1, 0)
                ColumnSetUp(Grd, 15, 1, 0)
            End If

            For i As Integer = 0 To 5
                txtShTk_Leave(txtShTk(i), New EventArgs())
            Next
            txtTon(14).Text = Format(TyGiaNT(1), Mask_2)
            formInitDone = True
            Dim str As String = String.Format("SELECT sohieu AS F1, MaSo as F2 FROM DoituongCT WHERE MaSo>1 and thang={0}{1} ORDER BY sohieu", _
                                              Cbo(0).SelectedValue, _
                                              IIf(txtShTk(2).Text Like "1422*", " and DoituongCT.DienGiai not like '...%'", " and DoituongCT.DienGiai like '...%'"))
            Int_RecsetToCbo(str, Cbo(1))
            Me.Show()
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
    ''' <remarks></remarks>
    Private Sub NhapNoiDiaSettings()
        If doi = 0 Then
            Me.Text = Ngonngu("Giá vốn hàng nhập kho", "Cost of goods in stock")
            Label(0).Text = Ngonngu("Số hoá đơn", "Invoice number")
            txtShTk(2).Text = taikhoanconnhat("1423")

            Label(7).Visible = False
            Label(8).Visible = False
            Label(9).Visible = False
            txtTon(11).Visible = False
            txtTon(12).Visible = False
            Label(25).Visible = False
            Label(26).Visible = False
            Label(27).Visible = False

            txtTon(4).Visible = False
            txtTon(6).Visible = False
            txtTon(8).Visible = False
            txtTon(9).Visible = False

            txtTon(14).Visible = False
            Label(6).Visible = False
            Label(11).Visible = False
            Label(12).Visible = False
            Label(19).Visible = False
            Label(29).Visible = False

            txtShTk(1).Visible = False
            CmdTK(1).Visible = False
            LbTenTk(1).Visible = False
            Label(16).Visible = False
            txtShTk(3).Visible = False
            CmdTK(3).Visible = False
            LbTenTk(3).Visible = False
            txtShTk(5).Visible = False
            CmdTK(5).Visible = False
            LbTenTk(5).Visible = False

            Label(5).Left = 376
            Label(13).Left = 504

            txtTon(7).Left = 769
            txtTon(10).Left = 504

            Me.Width = 631
            'Me.Height = 444

            Grd.Width = 609
            Me._Command_3.Visible = False
            Me.CenterToParent()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Cbo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cbo_0.SelectedIndexChanged, _Cbo_1.SelectedIndexChanged
        If formInitDone Then
            Dim Index As Integer = Array.IndexOf(Cbo, eventSender)
            Select Case Index
                Case 0
                    Int_RecsetToCbo(String.Format("SELECT sohieu AS F1, MaSo as F2 FROM DoituongCT WHERE MaSo>1 and thang={0}{1} ORDER BY sohieu", _
                                        Cbo(0).SelectedValue, _
                                        IIf(txtShTk(2).Text Like "1422*", " and DoituongCT.DienGiai not like '...%'", " and DoituongCT.DienGiai like '...%'")), Cbo(1))
                    If Cbo(1).Items.ItemsBase.Count = 0 Then ClearGrid(Grd, ConvertToDblSafe(Grd.Tag))
                Case 1
                    LietKeChiPhiHD(Cbo(1).SelectedValue)
            End Select
        End If
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdCT_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCT.Click
        Dim cpx(1) As Double
        Dim pn As String = String.Empty
        Dim mdt(2) As Integer
        If Cbo(1).SelectedIndex < 0 Then
            Cbo(1).Focus()
            Exit Sub
        End If
        If vt.MaSo = 0 Then
            txtTon(0).Focus()
            Exit Sub
        End If
        Dim luong As Double = ConvertToDblSafe(txtTon(5).Text)
        If luong = 0 Then
            txtTon(0).Focus()
            Exit Sub
        End If
        cpx(0) = ConvertToDblSafe(txtTon(10).Text)
        cpx(1) = ConvertToDblSafe(txtTon(12).Text)
        Dim tt2 As Double = ConvertToDblSafe(txtTon(6).Text)
        Dim tt As Double = ConvertToDblSafe(txtTon(7).Text)
        Dim tnk As Double = ConvertToDblSafe(txtTon(9).Text)
        Dim tg As Double = ConvertToDblSafe(txtTon(14).Text)
        pn = IIf(txtTon(3).Text <> "", txtTon(3).Text, "...")

        ExecSQLNonQuery(String.Format("INSERT INTO CPGVHD (MaSo,MaDT, MaVattu, CP1, CP2, CP3, CP4, TT2, TNK, TyGia1, TT,  SL, PN, MaDT1, MaDT2, MaDT3) VALUES ({0},{1},{2},{3},{4},0,0,{5},{6},{7},{8},{9}, N'{10}',{11},{12},{13})", _
                            Lng_MaxValue("MaSo", "CPGVHD") + 1, _
                            ConvertToStrSafe(Cbo(1).SelectedValue), _
                            ConvertToStrSafe(vt.MaSo), _
                            CStr(cpx(0)), _
                            CStr(cpx(1)), _
                            CStr(tt2), _
                            CStr(tnk), _
                            CStr(tg), _
                            CStr(tt), _
                            CStr(luong), _
                            pn, _
                            ConvertToStrSafe(mdt(0)), _
                            ConvertToStrSafe(mdt(1)), _
                            ConvertToStrSafe(mdt(2))))
        Grd.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}{1}0{1}0{1}{13}{1}{14}", _
                        vt.sohieu, _
                        Chr(9), _
                        vt.TenVattu, _
                        vt.DonVi, _
                        pn, _
                        Format(luong, Mask_2), _
                        Format(tt2 / luong, "##0.####"), _
                        Format(tt2, "##0.###"), _
                        Format(tt, Mask_0), _
                        txtTon(8).Text, _
                        Format(tnk, Mask_0), _
                        txtTon(11).Text, _
                        txtTon(12).Text, _
                        ConvertToStrSafe(vt.MaSo), _
                        ConvertToStrSafe(Lng_MaxValue("MaSo", "CPGVHD"))), 0)
        vt.InitVattuMaSo(0)
        For i As Integer = 0 To 12
            txtTon(i).Text = ""
        Next
        TinhTien()
        txtTon(0).Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CmdHD_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CmdHD.Click
        If Strings.Left(txtShTk(2).Text, 4) = "1422" Then
            FrmHD.ShowDialog()
        Else
            FrmHDnoidia.ShowDialog()
        End If
        Cbo_SelectedIndexChanged(Cbo(0), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CmdTK_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CmdTK_0.Click, _CmdTK_1.Click, _CmdTK_2.Click, _CmdTK_3.Click, _CmdTK_4.Click, _CmdTK_5.Click
        Dim Index As Integer = Array.IndexOf(CmdTK, eventSender)
        txtShTk(Index).Text = FrmTaikhoan.ChonTk(txtShTk(Index).Text)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click, _Command_2.Click, _Command_4.Click, _Command_3.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim i, k As Integer
        Dim tnk, sl, tt, cpk As Double
        Dim mtk As Integer
        Dim sh As String = String.Empty
        Dim mkh As Integer
        Dim gt, tienNT As Double
        Dim rs, rs1 As DataTable
        Dim tdb As Double
        Dim TK As ClsTaikhoan
        Select Case Index
            Case 0
                Me.Close()
            Case 1, 2
                ChiPhiHD(Index - 1)
            Case 3
                With Grd
                    For i = 0 To .Rows - 1
                        .Row = i
                        .Col = 0
                        If .Items(.Row).SubItems(.Col).Text = "" Then Exit For
                        .Col = 12
                        .Items(.Row).SubItems(.Col).Text = ""
                    Next
                End With
                PhanBo()
            Case 4
                TK = New ClsTaikhoan()
                TK.InitTaikhoanSohieu(_txtShTk_0.Text)
                If TK.maso = 0 Then
                    TK.InitTaikhoanSohieu("156")
                    If TK.maso > 0 Then
                        TK.ThemTKCon("1", "Hàng hoá", "Goods", 1000, 0)
                        ExecSQLNonQuery("UPDATE HethongTK SET MaTC=MaSo WHERE Cap=2 AND SoHieu LIKE '156%'")
                        ExecSQLNonQuery("UPDATE HethongTK SET tkcon=1 WHERE Cap=1 AND SoHieu LIKE '156%'")
                    End If
                End If
                If Cbo(1).SelectedIndex < 0 Then Exit Sub
                If GetTK_ID(txtShTk(0).Text, 0, , i) <> TKVT_ID Then
                    txtShTk(0).Focus()
                    Exit Sub
                End If
                For i = 0 To 5
                    mtk = 0
                    GetTK_ID(txtShTk(i).Text, mtk, , k)
                    If mtk = 0 Or k <> 0 Then
                        txtShTk(i).Focus()
                        Exit Sub
                    End If
                Next
                k = 0
                ' Dim tempLoadForm As FrmChungtu = FrmChungtu
                With FrmChungtu
                    .khoi_tao()
                    .loadluoi = 1
                    .initOption = 1
                    Dim setloaict As Boolean = .SetLoaiEnable
                    .SetLoaiEnable = True
                    .OptLoai(1).Checked = True
                    .SetLoaiEnable = setloaict
                    rs = ExecSQLReturnDT(String.Format("SELECT * FROM doituongct WHERE sohieu=N'{0}'", Cbo(1).Text))
                    Dim rsItem As DataRow
                    If rs.Rows.Count = 0 Then GoTo 1
                    rsItem = rs.Rows(0)
                    rs1 = ExecSQLReturnDT(String.Format("SELECT * FROM khachhang WHERE maso={0}", rsItem("MaKhachHang")))
                    .txt(0).Text = rsItem("SoHieu")
                    If .CboThang.Items.Count > 0 Then
                        .CboThang.SelectedIndex = Cbo(0).SelectedIndex
                    End If
                    .MedNgay(0).Text = rsItem("Ngayky")
                    .MedNgay_Leave(FrmChungtu.MedNgay(0), New EventArgs())
                    .MedNgay_Enter(FrmChungtu.MedNgay(1), New EventArgs())
                    If .CboNguon(2).Items.Count > 0 Then
                        .CboNguon(2).SelectedIndex = 0
                    End If
                    While .CboNguon(2).SelectedValue <> Cbo(1).SelectedValue And .CboNguon(2).SelectedIndex < .CboNguon(2).Items.Count - 1
                        If .CboNguon(2).Items.Count > 0 Then
                            .CboNguon(2).SelectedIndex += 1
                        End If
                    End While
                End With

                Dim rs1Item As DataRow = rs1.Rows(0)
                With Grd
                    tien = 0
                    thuedacbiet = 0
                    For i = 0 To .Rows - 1
                        .Row = i
                        .Col = 4
                        sl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 6
                        tienNT += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 7
                        tien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        tt = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        gt = tt
                        thuedacbiet += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 9
                        tien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        tnk += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        tt += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        thuedacbiet += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 11
                        tien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        tdb += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        tt += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 12
                        cpk += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        tt += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        gt += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 0
                        FrmChungtu.txtchungtu(0).Text = txtShTk(0).Text
                        FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(0), New EventArgs)
                        FrmChungtu.txtchungtu(2).Text = .Items(.Row).SubItems(.Col).Text
                        FrmChungtu.vattu.InitVattuSohieu(.Items(.Row).SubItems(.Col).Text())
                        FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(2), New EventArgs)
                        FrmChungtu.txtchungtu(3).Text = Format(sl, Mask_2)
                        FrmChungtu.txtchungtu(5).Text = Format(IIf(ConvertToDblSafe(Me.Tag) = 0, tt, gt), Mask_0)
                        If sl <> 0 Then FrmChungtu.txtchungtu(4).Text = Format((IIf(ConvertToDblSafe(Me.Tag) = 0, tt, gt)) / sl, Mask_2)
                        FrmChungtu.txtchungtu(6).Text = ""
                        FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())
                        k += 1
                    Next
                End With
                If k > 0 Then
                    pFunction = 10
                    pCT_ID = 1000000000 + Cbo(1).SelectedValue
                    SetListIndex(FrmChungtu.CboVV(2), Cbo(1).SelectedValue)
                    FrmChungtu.MaSoCT = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaCT AS F1 FROM ChungTu WHERE CT_ID={0}", pCT_ID)))
                    If FrmChungtu.MaSoCT > 0 Then
                        mkh = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Max(MaKHC) AS F1 FROM ChungTu WHERE MaCT={0}", FrmChungtu.MaSoCT)))
                        If mkh > 0 Then sh = MaSo2SoHieu(mkh, "KhachHang")
                    End If
                    If pTygia > 0 Then FrmChungtu.txtchungtu(7).Text = txtTon(14).Text
                    If tdb <> 0 Then
                        FrmChungtu.txtchungtu(0).Text = txtShTk(3).Text
                        FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(0), New EventArgs())
                        FrmChungtu.txtchungtu(5).Text = ""
                        FrmChungtu.txtchungtu(6).Text = Format(tdb, Mask_0)
                        With stuHoadon
                            .MaKhachHang = rs1Item("MaSo")
                            .KyHieu = "TK"
                            .HTTT = "1"
                            .HD = 0
                        End With
                        FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())
                    End If
                    If tnk <> 0 Then
                        FrmChungtu.txtchungtu(0).Text = txtShTk(1).Text
                        FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(0), New EventArgs())
                        FrmChungtu.txtchungtu(5).Text = ""
                        FrmChungtu.txtchungtu(6).Text = Format(tnk, Mask_0)
                        FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())
                    End If
                    If cpk <> 0 Then
                        FrmChungtu.txtchungtu(0).Text = txtShTk(2).Text
                        FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(0), New EventArgs())
                        FrmChungtu.txtchungtu(5).Text = ""
                        FrmChungtu.txtchungtu(6).Text = Format(cpk, Mask_0)
                        FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())
                    End If
                    If ConvertToDblSafe(Me.Tag) = 0 Then
                        FrmChungtu.txtchungtu(5).Text = ""
                        FrmChungtu.txtchungtu(6).Text = ""
                        FrmChungtu.txtchungtu(0).Text = taikhoanconnhat("3311")
                        FrmChungtu.hdcount = -1
                        FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(0), New EventArgs())
                        If mkh > 0 Then
                            FrmChungtu.txtchungtu(2).Text = sh
                            FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(0), New EventArgs())
                        End If
                        FrmChungtu.txtchungtu(6).Text = Format(FrmChungtu.SoPSConLai(), Mask_0)
                        FrmChungtu.txtchungtu(2).Text = rs1Item("SoHieu")
                        FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(2), New EventArgs())
                        If rs1Item("MaNT") <> 0 Then
                            FrmChungtu.txtchungtu(3).Text = ConvertToStrSafe(tienNT)
                            FrmChungtu.txtchungtu(4).Text = txtTon(14).Text
                            FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())
                            With Grd
                                For i = 0 To .Rows - 1
                                    .Row = i
                                    .Col = 0
                                    If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                                    .Col = 4
                                    sl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    .Col = 7
                                    tt = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    gt = tt
                                    .Col = 9
                                    tt += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    .Col = 11
                                    tt += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    .Col = 12
                                    tt += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    gt += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    .Col = 0
                                    FrmChungtu.txtchungtu(0).Text = txtShTk(0).Text
                                    FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(0), New EventArgs())
                                    FrmChungtu.txtchungtu(2).Text = .Items(.Row).SubItems(.Col).Text
                                    FrmChungtu.VTEnable = True
                                    FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(2), New EventArgs())
                                    FrmChungtu.VTEnable = False
                                    FrmChungtu.txtchungtu(3).Text = Format(sl, Mask_2)
                                    FrmChungtu.txtchungtu(5).Text = Format(IIf(ConvertToDblSafe(Me.Tag) = 0, tt, gt), Mask_0)
                                    If sl <> 0 Then FrmChungtu.txtchungtu(4).Text = Format((IIf(ConvertToDblSafe(Me.Tag) = 0, tt, gt)) / sl, Mask_2)
                                    FrmChungtu.txtchungtu(6).Text = ""
                                    FrmChungtu.GrdChungtu.Items.Remove(0)
                                    FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())
                                Next
                            End With
                        End If
                    End If
                    'Thuế giá trị gia tăng
                    FrmChungtu.txtchungtu(0).Text = txtShTk(4).Text
                    FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(0), New EventArgs())
                    FrmChungtu.txtchungtu(2).Text = TxtThueSuat.Text
                    FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(2), New EventArgs())
                    FrmChungtu.txtchungtu(5).Text = ConvertToDblSafe(TxtThueSuat.Text) * tien / 100
                    FrmChungtu.hdcount = 0
                    With stuHoadon
                        .MaKhachHang = rs1Item("MaSo")
                        .KyHieu = "TK"
                        .HTTT = "1"
                    End With
                    FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())

                    'Thuế giá trị gia tăng suất khẩu
                    If ConvertToDblSafe(Me.Tag) = 0 Then
                        FrmChungtu.txtchungtu(0).Text = txtShTk(5).Text
                        FrmChungtu._txtchungtu_LostFocus(FrmChungtu.txtchungtu(0), New EventArgs())
                        FrmChungtu.CmdChitiet_Click(FrmChungtu.CmdChitiet, New EventArgs())
                    End If
                End If
                If k > 0 Then
                    FrmChungtu.ShowDialog()
                    FrmChungtu.loadluoi = 0
1:
                End If
        End Select
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CPGV_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If Shift = 4 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.X
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.I
                    Command(2).Focus()
                    'Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.P
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.L
                    Command(4).Focus()
                    ' Command_ClickEvent(Command(4), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mhd"></param>
    ''' <remarks></remarks>
    Private Sub LietKeChiPhiHD(ByRef mhd As Integer)
        Dim tlthue, dg2, cpx, tlthuedb As Double
        ClearGrid(Grd, ConvertToDblSafe(Grd.Tag))
        Dim sql As String = String.Format("SELECT CPGVHD.*, Vattu.SoHieu AS SHVT, TenVattu, DonVi, ThueNK FROM CPGVHD INNER JOIN Vattu ON CPGVHD.MaVattu=Vattu.MaSo WHERE MaDT={0} ORDER BY Vattu.SoHieu DESC", mhd)
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            txtTon(14).Text = Format(rsItem("tygia1"), Mask_2)
            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem2 As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                If rsItem2("tt2") IsNot Nothing And rsItem2("sl") IsNot Nothing Then
                    dg2 = rsItem2("tt2") / rsItem2("sl")
                End If
                If rsItem2("CP1") IsNot Nothing Then
                    cpx += rsItem2("CP1")
                End If

                If rsItem2("tt") <> 0 Then
                    tlthue = (IIf(0.5 + 1000 * rsItem2("tnk") / rsItem2("tt") > 0, Math.Floor(0.5 + 1000 * rsItem2("tnk") / rsItem2("tt")), Math.Ceiling(0.5 + 1000 * rsItem2("tnk") / rsItem2("tt")))) / 10
                    tlthuedb = (IIf(0.5 + 1000 * rsItem2("cp2") / (rsItem2("tt") + rsItem2("tnk")) > 0, Math.Floor(0.5 + 1000 * rsItem2("cp2") / (rsItem2("tt") + rsItem2("tnk"))), Math.Ceiling(0.5 + 1000 * rsItem2("cp2") / (rsItem2("tt") + rsItem2("tnk"))))) / 10
                Else
                    tlthue = 0
                    tlthuedb = 0
                End If

                Grd.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}{1}{13}{1}{14}{1}{15}{1}{16}", _
                                rsItem2("shvt"), _
                                Chr(9), _
                                rsItem2("TenVattu"), _
                                rsItem2("DonVi"), _
                                rsItem2("pn"), _
                                Format(rsItem2("sl"), Mask_2), _
                                Format(dg2, "##0.####"), _
                                Format(rsItem2("tt2"), "##0.###"), _
                                Format(rsItem2("tt"), Mask_0), _
                                ConvertToStrSafe(tlthue), _
                                Format(rsItem2("tnk"), Mask_0), _
                                ConvertToStrSafe(tlthuedb), _
                                Format(rsItem2("cp2"), Mask_0), _
                                Format(rsItem2("cp1"), Mask_0), _
                                Format(rsItem2("cp4"), Mask_0), _
                                rsItem2("MaVattu"), _
                                rsItem2("MaSo")), 0)
            Loop
            Grd.Rows = IIf(rs.Rows.Count >= ConvertToDblSafe(Grd.Tag), rs.Rows.Count, ConvertToDblSafe(Grd.Tag))
        End If
        CP.Text = Format(cpx, Mask_0)

        rs = Nothing
        TinhTien()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CPGV_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        vt = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.Click

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles Grd.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , Grd, Grd.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_5.Leave, _txtShTk_4.Leave, _txtShTk_3.Leave, _txtShTk_2.Leave, _txtShTk_1.Leave, _txtShTk_0.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        Dim mtk As Integer
        If Index > -1 Then
            LbTenTk(Index).Text = tentk(txtShTk(Index).Text, mtk)
        End If

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_12.Enter, _txtTon_11.Enter, _txtTon_9.Enter, _txtTon_8.Enter, _txtTon_7.Enter, _txtTon_6.Enter, _txtTon_5.Enter, _txtTon_4.Enter, _txtTon_3.Enter, _txtTon_14.Enter, _txtTon_10.Enter, _txtTon_2.Enter, _txtTon_1.Enter, _txtTon_0.Enter
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        txtTon(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_12.KeyPress, _txtTon_11.KeyPress, _txtTon_9.KeyPress, _txtTon_8.KeyPress, _txtTon_7.KeyPress, _txtTon_6.KeyPress, _txtTon_5.KeyPress, _txtTon_4.KeyPress, _txtTon_3.KeyPress, _txtTon_14.KeyPress, _txtTon_10.KeyPress, _txtTon_2.KeyPress, _txtTon_1.KeyPress, _txtTon_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 13 Then txtTon(0).Text = FrmVattu.ChonVattu(txtTon(0).Text)
                txtTon(0).Focus()
                Exit Select
            Case 7, 8, 9, 10, 11, 12
                If KeyAscii = 53013 Then
                    cmdCT_Click(cmdCT, New EventArgs())
                Else
                    KeyProcess(txtTon(Index), KeyAscii)
                End If
                Exit Select
        End Select
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
    Private Sub txtTon_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_12.Leave, _txtTon_11.Leave, _txtTon_9.Leave, _txtTon_8.Leave, _txtTon_7.Leave, _txtTon_6.Leave, _txtTon_5.Leave, _txtTon_4.Leave, _txtTon_3.Leave, _txtTon_14.Leave, _txtTon_10.Leave, _txtTon_2.Leave, _txtTon_1.Leave, _txtTon_0.Leave
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Dim dg, sl, tt As Double
        Select Case Index
            Case 0
                vt.InitVattuSohieu(txtTon(0).Text)
                txtTon(1).Text = vt.TenVattu
                txtTon(2).Text = vt.DonVi
                Exit Select
            Case 4, 5
                txtTon(Index).Text = Format(txtTon(Index).Text, IIf(Index = 4, "##0.####", Mask_2))
                sl = ConvertToDblSafe(txtTon(4).Text)
                dg = ConvertToDblSafe(txtTon(5).Text)
                tt = sl * dg
                txtTon(6).Text = Format(tt, "##0.###")
                tt = IIf(0.5 + ConvertToDblSafe(txtTon(14).Text) * tt > 0, Math.Floor(0.5 + ConvertToDblSafe(txtTon(14).Text) * tt), Math.Ceiling(0.5 + ConvertToDblSafe(txtTon(14).Text) * tt))
                txtTon(7).Text = Format(tt, Mask_0)
                If Index = 8 Then
                    txtTon(9).Text = Format(IIf(0.5 + tt * ConvertToDblSafe(txtTon(8).Text) / 100 > 0, Math.Floor(0.5 + tt * ConvertToDblSafe(txtTon(8).Text) / 100), Math.Ceiling(0.5 + tt * ConvertToDblSafe(txtTon(8).Text) / 100)), Mask_0)
                Else
                    tt += ConvertToDblSafe(txtTon(9).Text)
                    txtTon(12).Text = Format(IIf(0.5 + tt * ConvertToDblSafe(txtTon(11).Text) / 100 > 0, Math.Floor(0.5 + tt * ConvertToDblSafe(txtTon(11).Text) / 100), Math.Ceiling(0.5 + tt * ConvertToDblSafe(txtTon(11).Text) / 100)), Mask_0)
                End If
                Exit Select
            Case 6
                tt = ConvertToDblSafe(txtTon(6).Text)
                sl = ConvertToDblSafe(txtTon(4).Text)
                If sl <> 0 Then txtTon(5).Text = Format(tt / sl, Mask_2)
                tt = IIf(0.5 + ConvertToDblSafe(txtTon(14).Text) * tt > 0, Math.Floor(0.5 + ConvertToDblSafe(txtTon(14).Text) * tt), Math.Ceiling(0.5 + ConvertToDblSafe(txtTon(14).Text) * tt))
                txtTon(7).Text = Format(tt, Mask_0)
                If Index = 8 Then
                    txtTon(9).Text = Format(IIf(0.5 + tt * ConvertToDblSafe(txtTon(8).Text) / 100 > 0, Math.Floor(0.5 + tt * ConvertToDblSafe(txtTon(8).Text) / 100), Math.Ceiling(0.5 + tt * ConvertToDblSafe(txtTon(8).Text) / 100)), Mask_0)
                Else
                    tt += ConvertToDblSafe(txtTon(9).Text)
                    txtTon(12).Text = Format(IIf(0.5 + tt * ConvertToDblSafe(txtTon(11).Text) / 100 > 0, Math.Floor(0.5 + tt * ConvertToDblSafe(txtTon(11).Text) / 100), Math.Ceiling(0.5 + tt * ConvertToDblSafe(txtTon(11).Text) / 100)), Mask_0)
                End If
                Exit Select
            Case 7, 8, 11
                txtTon(Index).Text = Format(txtTon(Index).Text, Mask_0)
                tt = ConvertToDblSafe(txtTon(7).Text)

                If Index = 8 Then
                    txtTon(9).Text = Format(IIf(0.5 + tt * ConvertToDblSafe(txtTon(8).Text) / 100 > 0, Math.Floor(0.5 + tt * ConvertToDblSafe(txtTon(8).Text) / 100), Math.Ceiling(0.5 + tt * ConvertToDblSafe(txtTon(8).Text) / 100)), Mask_0)
                Else
                    tt += ConvertToDblSafe(txtTon(9).Text)
                    txtTon(12).Text = Format(IIf(0.5 + tt * ConvertToDblSafe(txtTon(11).Text) / 100 > 0, Math.Floor(0.5 + tt * ConvertToDblSafe(txtTon(11).Text) / 100), Math.Ceiling(0.5 + tt * ConvertToDblSafe(txtTon(11).Text) / 100)), Mask_0)
                End If
                Exit Select
            Case 9
                txtTon(Index).Text = Format(txtTon(Index).Text, Mask_0)
                Exit Select
            Case 14
                txtTon(Index).Text = Format(txtTon(Index).Text, Mask_2)
                TinhTien()
                Exit Select
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TinhTien()
        Dim tnk, cpx, tt, sl As Double
        Dim sodong As Integer
        Dim cpa(1) As Double
        Dim db, NK, tdb As Double
        Dim tygia As Double = ConvertToDblSafe(txtTon(14).Text)
        If tygia = 0 Then tygia = 1
        With Grd
            For i As Integer = 0 To .Rows - 1
                .Col = 0
                .Row = i
                If .Items(.Row).SubItems(.Col).Text = "" Then Exit For
                .Col = 5
                sl += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                sodong += 1
                .Col = 6
                tt = IIf(0.5 + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) * tygia > 0, Math.Floor(0.5 + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) * tygia), Math.Ceiling(0.5 + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) * tygia))
                .Col = 9
                tnk = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                NK += tnk
                .Col = 11
                db = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                tdb += db
                .Col = 12
                cpa(0) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                cpx += cpa(0)
                .Col = 15
                ExecSQLNonQuery(String.Format("UPDATE CPGVHD SET CP1={0},CP2={1},CP3=0,CP4=0,TNK={2},TyGia1={3} WHERE MaSo={4}", _
                                    CStr(cpa(0)), _
                                    CStr(db), _
                                    CStr(tnk), _
                                    CStr(tygia), _
                                    ConvertToStrSafe(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)))) '",TT=" + cstr(tt) +
            Next
        End With
        Dim chiphi As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops) as f1 FROM chungtu WHERE matkno={0} and mavattu={1}", _
                                                                   Timten("maso", txtShTk(2).Text, "sohieu", "hethongtk"), _
                                                                   ConvertToStrSafe(ConvertToDblSafe(Timten("maso", Cbo(1).Text, "sohieu", "doituongct"))))))
        CP.Text = Format(chiphi, Mask_0)
        LbThue.Text = Format(NK, Mask_0)
        LbThuedb.Text = Format(tdb, Mask_0)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="des"></param>
    ''' <remarks></remarks>
    Private Sub ChiPhiHD(ByRef des As Integer)
        If Cbo(1).SelectedIndex < 0 Then Exit Sub
        Dim sql As String = String.Format("SELECT CPGVHD.MaVattu, Vattu.SoHieu AS SHVT, Vattu.TenVattu, DonVi, ThueNK, SL, TT, TyGia1, PN, CP1, CP2, CP3, CP4, TT2, TNK  FROM CPGVHD INNER JOIN Vattu ON CPGVHD.MaVattu=Vattu.MaSo  WHERE CPGVHD.MaDT={0} ORDER BY Vattu.SoHieu", Cbo(1).SelectedValue)
        rptFrom.InitForm("CPGVHD.RPT", sql, "QLuyKe")

        rptFrom.ReportDestination = des
        rptFrom.SetFormulas("DienGiai", String.Format("'{0}'", Cbo(1).Text))
        rptFrom.SetFormulas("TyGia", ConvertToDblSafe(txtTon(14).Text))

        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_5.Enter, _txtShTk_4.Enter, _txtShTk_3.Enter, _txtShTk_2.Enter, _txtShTk_1.Enter, _txtShTk_0.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_5.KeyPress, _txtShTk_4.KeyPress, _txtShTk_3.KeyPress, _txtShTk_2.KeyPress, _txtShTk_1.KeyPress, _txtShTk_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If KeyAscii = 13 Then CmdTK_ClickEvent(CmdTK(Index), New EventArgs())
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PhanBo()
        Dim tt2, sl, tt As Double
        Dim sodong As Integer
        Dim cp1 As Double = ConvertToDblSafe(CP.Text)
        With Grd
            For i As Integer = 0 To .Rows - 1
                .Col = 0
                .Row = i
                .Col = IIf(OptPB(0).Checked, 4, 7)
                sl += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                sodong += 1
            Next
            If sl > 0 And sodong > 0 Then
                tt2 = 0
                For i As Integer = 0 To sodong - 2
                    .Row = i
                    .Col = IIf(OptPB(0).Checked, 4, 7)
                    tt = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    tt = IIf(0.5 + cp1 * tt / sl > 0, Math.Floor(0.5 + cp1 * tt / sl), Math.Ceiling(0.5 + cp1 * tt / sl))
                    tt2 += tt
                    .Col = 12
                    .Items(.Row).SubItems(.Col).Text = Format(tt, Mask_0)
                    .Col = 15
                    ExecSQLNonQuery(String.Format("UPDATE CPGVHD SET CP1={0} WHERE MaSo={1}", _
                                        CStr(tt), _
                                        ConvertToStrSafe(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text))))
                Next
                .Row = ConvertToDblSafe(sodong - 1)
                tt = cp1 - tt2
                .Col = 12
                .Items(.Row).SubItems(.Col).Text = Format(tt, Mask_0)
                .Col = 15
                ExecSQLNonQuery(String.Format("UPDATE CPGVHD SET CP1={0} WHERE MaSo={1}", _
                                    CStr(tt), _
                                    ConvertToStrSafe(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text))))
            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(4).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", Cbo(0).SelectedValue))) > 0 Then
                Command(4).Enabled = False
            End If
        End If
    End Sub

    Private Sub Grd_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grd.DoubleClick
        With Grd
            .Col = 0
            If .Items(.Row).SubItems(.Col).Text = "" Then Exit Sub
            For i As Integer = 0 To 12
                .Col = ConvertToDblSafe(i)
                If i = 4 Then
                    txtTon(5).Text = .Items(.Row).SubItems(.Col).Text
                ElseIf i = 5 Then
                    txtTon(4).Text = .Items(.Row).SubItems(.Col).Text
                ElseIf i = 10 Then
                    txtTon(11).Text = .Items(.Row).SubItems(.Col).Text
                ElseIf i = 11 Then
                    txtTon(12).Text = .Items(.Row).SubItems(.Col).Text
                ElseIf i = 12 Then
                    txtTon(10).Text = .Items(.Row).SubItems(.Col).Text
                Else
                    txtTon(i).Text = .Items(.Row).SubItems(.Col).Text
                End If
            Next
            txtTon_Leave(txtTon(0), New EventArgs())
            .Col = 15
            ExecSQLNonQuery(String.Format("DELETE  FROM CPGVHD WHERE MaSo={0}", .Items(.Row).SubItems(.Col).Text))
            .RemoveItem(.Row)
            If .Rows < ConvertToDblSafe(.Tag) Then .Rows = ConvertToDblSafe(.Tag)
            txtTon(0).Focus()
        End With
    End Sub

    Private Sub _OptNhapKhau__Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _OptNhapKhau_.Click
        Me.Tag = 0
        Me.Text = Ngonngu("Chi phí giá vốn hàng nhập khẩu", "")
        Label(0).Text = Ngonngu("Số tờ khai", "")
        txtShTk(2).Text = taikhoanconnhat("1422")
        Cbo_SelectedIndexChanged(Cbo, New EventArgs)
        txtTon(8).Visible = True
        txtTon(9).Visible = True

        txtTon(4).Visible = True
        txtTon(6).Visible = True
        txtTon(11).Visible = True
        txtTon(12).Visible = True
        txtTon(14).Visible = True

        Label(6).Visible = True
        Label(7).Visible = True
        Label(8).Visible = True
        Label(9).Visible = True
        Label(11).Visible = True
        Label(12).Visible = True
        Label(25).Visible = True
        Label(26).Visible = True
        Label(27).Visible = True
        Label(29).Visible = True

        Label(19).Visible = True
        txtShTk(1).Visible = True
        CmdTK(1).Visible = True
        LbTenTk(1).Visible = True
        Label(16).Visible = True
        txtShTk(3).Visible = True
        CmdTK(3).Visible = True
        LbTenTk(3).Visible = True
        LbTenTk(5).Visible = True
        txtShTk(5).Visible = True
        CmdTK(5).Visible = True

        If RongSL > 0 Then Label(4).Width = RongSL
        If RongTT > 0 Then Label(5).Width = RongTT

        ColumnSetUp(Grd, 4, 820, 1)
        ColumnSetUp(Grd, 5, 940, 1)
        ColumnSetUp(Grd, 6, 1550, 1)
        ColumnSetUp(Grd, 7, 1900, 1)
        ColumnSetUp(Grd, 8, 340, 1)
        ColumnSetUp(Grd, 9, 1300, 1)
        ColumnSetUp(Grd, 10, 340, 1)
        ColumnSetUp(Grd, 11, 1300, 1)
        Cbo_SelectedIndexChanged(Cbo(0), New EventArgs)
        'For i = 1 To pSoVV
        '    LbTT(i - 1).Visible = True
        '    CboVV(i - 1).Visible = True
        '    Int_RecsetToCbo("SELECT MaSo As F2,DienGiai As F1 FROM DoituongCT" + CStr(i) + " ORDER BY DoituongCT" + CStr(i) + ".DienGiai", CboVV(i - 1))
        'Next
    End Sub

    Private Sub _OptNoiDia__Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _OptNoiDia_.Click
        Me.Tag = 1
        Me.Text = Ngonngu("Giá vốn hàng nhập kho", "")
        Label(0).Text = Ngonngu("Số hóa đơn", "")
        txtShTk(2).Text = taikhoanconnhat("1423")
        Cbo_SelectedIndexChanged(Cbo, New EventArgs)
        txtTon(8).Visible = False
        txtTon(9).Visible = False

        txtTon(4).Visible = False
        txtTon(6).Visible = False
        txtTon(11).Visible = False
        txtTon(12).Visible = False
        txtTon(14).Visible = False

        Label(6).Visible = False
        Label(7).Visible = False
        Label(8).Visible = False
        Label(9).Visible = False
        Label(11).Visible = False
        Label(12).Visible = False
        Label(25).Visible = False
        Label(26).Visible = False
        Label(27).Visible = False
        Label(29).Visible = False

        Label(19).Visible = False
        txtShTk(1).Visible = False
        CmdTK(1).Visible = False
        LbTenTk(1).Visible = False
        Label(16).Visible = False
        txtShTk(3).Visible = False
        CmdTK(3).Visible = False
        LbTenTk(3).Visible = False
        LbTenTk(5).Visible = False
        txtShTk(5).Visible = False
        CmdTK(5).Visible = False

        If RongSL = 0 Then RongSL = Label(4).Width
        Label(4).Width = RongSL + Label(7).Width + Label(8).Width
        txtTon(5).Width = Label(4).Width
        If RongTT = 0 Then RongTT = Label(5).Width
        Label(5).Width = RongTT + Label(9).Width + Label(27).Width
        txtTon(7).Width = Label(5).Width

        ColumnSetUp(Grd, 4, 820 + 940 + 1550, 1)
        ColumnSetUp(Grd, 5, 1, 1)
        ColumnSetUp(Grd, 6, 1, 1)
        ColumnSetUp(Grd, 7, 1900 + 340 + 1300 + 340 + 1300 + 40, 1)
        ColumnSetUp(Grd, 8, 1, 1)
        ColumnSetUp(Grd, 9, 1, 1)
        ColumnSetUp(Grd, 10, 1, 1)
        ColumnSetUp(Grd, 11, 1, 1)
        Cbo_SelectedIndexChanged(Cbo(0), New EventArgs)
    End Sub

    Private Sub _OptNhapKhau__CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _OptNhapKhau_.CheckedChanged

    End Sub
End Class
