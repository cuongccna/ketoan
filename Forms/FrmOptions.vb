Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Globalization
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports ComboBoxEx

Partial Friend Class FrmOptions

    Dim ttVT As Integer
    Dim MST As String = String.Empty
    Dim suatencn As CheckState
    Dim kb As Integer
    Dim cao, rong, cao1, rong1 As Integer

    Private Sub Check_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Check_39.CheckStateChanged, _Check_28.CheckStateChanged, _Check_55.CheckStateChanged, _Check_26.CheckStateChanged, _Check_25.CheckStateChanged, _Check_17.CheckStateChanged, _Check_16.CheckStateChanged, _Check_15.CheckStateChanged, _Check_13.CheckStateChanged, _Check_12.CheckStateChanged, _Check_10.CheckStateChanged, _Check_9.CheckStateChanged, _Check_8.CheckStateChanged, _Check_7.CheckStateChanged, _Check_6.CheckStateChanged, _Check_5.CheckStateChanged, _Check_4.CheckStateChanged, _Check_3.CheckStateChanged, _Check_2.CheckStateChanged, _Check_1.CheckStateChanged, _Check_18.CheckStateChanged, _Check_19.CheckStateChanged, _Check_20.CheckStateChanged, _Check_21.CheckStateChanged, _Check_22.CheckStateChanged, _Check_23.CheckStateChanged, _Check_24.CheckStateChanged, _Check_29.CheckStateChanged, _Check_30.CheckStateChanged, _Check_31.CheckStateChanged, _Check_32.CheckStateChanged, _Check_33.CheckStateChanged, _Check_34.CheckStateChanged, _Check_11.CheckStateChanged, _Check_35.CheckStateChanged, _Check_36.CheckStateChanged, _Check_37.CheckStateChanged, _Check_38.CheckStateChanged, _Check_0.CheckStateChanged, _Check_14.CheckStateChanged, _Check_40.CheckStateChanged
        Dim Index As Integer = Array.IndexOf(Check, eventSender)
        Select Case Index
            Case 17
                If Check(Index).CheckState = CheckState.Unchecked Then Text_Renamed(8).Text = "..."
            Case 18
                If Check(18).CheckState = CheckState.Unchecked Then
                    Check(33).Enabled = False
                    Check(33).CheckState = CheckState.Unchecked
                Else
                    Check(33).Enabled = True
                End If
            Case 25, 26, 27, 28
                PhanChucNang(Combo(3).SelectedIndex + 1, Check(25).CheckState, Check(26).CheckState, Check(27).CheckState, Check(28).CheckState)
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkMonbai_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkMonbai.CheckStateChanged
        Frame(4).Visible = ChkMonbai.CheckState = CheckState.Checked
        'If ConvertToDblSafe(Text_Renamed(7).Text) <> 0 Then
        '    Me.Width = 675
        '    Me.Height = 380
        '    Frame(1).Visible = False
        'Else
        '    Me.Width = rong
        '    Me.Height = cao
        '    Frame(1).Visible = True
        'End If
        If ChkMonbai.CheckState = CheckState.Checked And Me.Height < 510 Then
            cao1 = Me.Height : Me.Height = 510
        Else
            If cao1 > 0 Then Me.Height = cao1
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cn_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cn_1.Enter, _cn_2.Enter, _cn_3.Enter, _cn_4.Enter, _cn_5.Enter, _cn_6.Enter, _cn_8.Enter, _cn_7.Enter, _cn_10.Enter, _cn_9.Enter
        Dim Index As Integer = Array.IndexOf(cn, eventSender)
        cn(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Combo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Combo_3.SelectedIndexChanged, _Combo_1.SelectedIndexChanged, _Combo_0.SelectedIndexChanged, _Combo_2.SelectedIndexChanged
        Dim Index As Integer = Array.IndexOf(Combo, eventSender)
        If Index = 3 Then PhanChucNang(Combo(Index).SelectedIndex + 1, Check(25).CheckState, Check(26).CheckState, Check(27).CheckState, Check(28).CheckState)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ThueMB()
        Dim von As Double = ConvertToDblSafe(GetSelectValue("SELECT von as f1 FROM License"))
        If von = 0 Then von = ConvertToDblSafe(GetSelectValue("SELECT duco_12 as f1 FROM hethongtk WHERE sohieu like '411'"))
        Text_Renamed(26).Text = Format(von, Mask_0)
        Dim rsvon As DataTable = ExecSQLReturnDT("SELECT * FROM BacThue order by bac")
        Dim Bac As Integer = 1
        For Each rsvonItem As DataRow In rsvon.Rows
            Text_Renamed(27).Text = ConvertToStrSafe(Bac)
            If von >= ConvertToDblSafe(rsvonItem("von")) Then
                Exit For
            End If
            Bac += 1
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmOptions_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.G
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If (Shift And 4) > 0 And (Shift And 2) > 0 And eventArgs.KeyCode = Keys.N Then
            kb = 1
            HienNoiBo()
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub


    Private Sub Initthang(ByRef cbo As ComboBoxExt, ByVal chisodau As Integer, ByVal chisocuoi As Integer, Optional ByVal vitri As Integer = 0)
        cbo.Items.Clear()
        cbo.Items.ItemsBase.Clear()

        For i As Integer = chisodau To chisocuoi
            cbo.Items.Add(New ComboBoxItem(i, i))
        Next

        If cbo.Items.Count > 0 Then cbo.SelectedIndex = vitri
    End Sub

    Private Sub FrmOptions_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Dim vis As Boolean
            Initthang(Combo(1), 1, 12)
            'CreateBacThue()
            UpdateLiscenseTable()
            ' Lấy lại các giá trị mặc định
            Int_RecsetToCbo("SELECT MaSo As F2,SoHieu + ' - ' + DienGiai As F1 FROM CTGhiSo ORDER BY SoHieu", CTGS)
            'SetFont(Me)
            Combo(3).Font = Me.Font
            MST = frmMain._LbCty_8.Text
            ' Dim dbNumericTemp As Double
            If IsNumeric(MST) Then
                vis = (ConvertToIntSafe(MST) = 0)
            Else
                vis = False
            End If
            Frame(1).Enabled = vis
            Combo(3).Enabled = vis
            Check(25).Enabled = vis
            Check(26).Enabled = vis
            Check(28).Enabled = vis
            OptBH(0).Enabled = False
            OptBH(1).Enabled = False
            '    OptBH(2).Enabled = True
            Int_RecsetToCbo("SELECT MaSo As F2, KyHieu As F1 FROM NguyenTe ORDER BY KyHieu", Combo(2))
            Combo(2).Items.Insert(0, "VND", 0)

            SetListIndex(Combo(2), pTien)
            Combo(2).Items.Insert(0, "VND", pTien)
            Int_RecsetToCbo("SELECT MaSo As F2, KyHieu As F1 FROM NguyenTe ORDER BY KyHieu", Combo(2))
            Combo(2).Items.Insert(0, "VND", 0)
            SetListIndex(Combo(2), pTien)
            ThueMB()
            LoadInfo()
            cao = Me.Height
            rong = Me.Width
            'If ConvertToDblSafe(Text_Renamed(7).Text) <> 0 Then
            '    '675, 380
            '    Me.Width = 675 '709
            '    Me.Height = 380 ' 330
            '    Frame(1).Visible = False
            'Else
            '    '1035, 759
            '    Me.Width = 1035 'rong
            '    Me.Height = 700 'cao
            '    Frame(1).Visible = True
            'End If
            'SetFont(Me)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub nnt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles nnt.Enter
        nnt.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean
    Private Sub OptVT_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptVT_3.CheckedChanged, _OptVT_2.CheckedChanged, _OptVT_1.CheckedChanged, _OptVT_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptVT, eventSender)
            ttVT = Index
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_1.Click, _Command_0.Click, _Command_3.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(Command, eventSender)
            Dim k, F0, i, f1, F2 As Integer
            Dim tygia As Double
            Dim T, Fx As Integer
            Dim pctpath As String = String.Empty
            Dim Tr As String = String.Empty
            Select Case Index
                Case 0, 1
                    If Index = 0 Then
                        Dim STR As String = "UPDATE License set banhang=" & (IIf(OptBH(0).Checked, 1, 0)) + (IIf(OptBH(1).Checked, 10, 0)) + (IIf(OptBH(2).Checked, 100, 0)) + IIf(Check(41).Checked, 1000, 0) + IIf(Check(42).Checked, 10000, 0) + IIf(Check(43).Checked, 100000, 0) & ",giatheokhach=" & ConvertToIntSafe(Check(40).CheckState) & ",von=" & CStr(ConvertToIntSafe(Text_Renamed(26).Text)) & ",cn1='" & cn(1).Text & "',cn2='" & cn(2).Text & "',cn3='" & cn(3).Text & "',cn4='" & cn(4).Text & "',cn5='" & cn(5).Text & "',cn6='" & cn(6).Text & "',cn7='" & cn(7).Text & "',cn8='" & cn(8).Text & "',cn9='" & cn(9).Text & "',cn10='" & cn(10).Text & "',kbs=" & ConvertToIntSafe(ChkKBS.CheckState) & ",nnt='" & nnt.Text & "',khongxuatam=" & ConvertToIntSafe(Check(39).CheckState)
                        ExecSQLNonQuery(STR)
                        For i = 0 To Text_Renamed.Length - 1
                            Text_Renamed_Leave(Text_Renamed(i), New EventArgs())
                        Next
                        'Dim dbNumericTemp As Double
                        If IsNumeric(Strings.Left(My.Application.Info.Copyright, 10)) And Strings.Len(My.Application.Info.Copyright) >= 10 Then
                            If Strings.Left(Text_Renamed(7).Text, 10) <> Strings.Left(My.Application.Info.Copyright, 10) Then GoTo kt
                        End If
                        If Combo(3).SelectedIndex < 0 And Combo(3).Items.Count > 0 Then Combo(3).SelectedIndex = Combo(3).Items.Count - 1
                        If (Combo(3).SelectedIndex < 2 Or Combo(3).SelectedIndex > 4) And pVersion = 0 Then
                            ErrMsg(er_Version)
                            GoTo kt
                        End If
                        If Check(35).CheckState = CheckState.Checked Then
                            i = ConvertToIntSafe(Text_Renamed(25).Text)
                            If i < 1 Or i > 3 Then Text_Renamed(25).Text = ""
                        End If
                        T = IIf(Combo(2).SelectedIndex >= 0, Combo(2).SelectedValue, pTien)
                        If ConvertToIntSafe(Strings.Left(Text_Renamed(Index).Text, 2)) <> 0 Then Check(55).CheckState = CheckState.Unchecked

                        'If pTenCty = Text_Renamed(0).Text And MST = Text_Renamed(7).Text Then
                        '    GoTo a
                        'Else
                        '    myUMessager.mWarning(String.Format("Vui lòng liên hệ với đơn vị phân phối để nhận được {0}Tên Công Ty và Mã Số Thuế", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        '    Exit Sub
                        'End If

                        'tam thoi du lai de duoc ghi thong tin database
                        'FrmGetStr.GetMK(Text_Renamed(7).Text)
                        If True Then
a:
                            If ttVT <> OutCost And ConvertToDblSafe(GetSelectValue("SELECT TOP 1 MaCT AS F1 FROM ChungTu WHERE MaLoai=2 OR MaLoai=4")) > 0 And ttVT <> 0 Then
                                If MessageBox.Show(Ngonngu("Đã có chứng từ xuất kho, thay đổi phương pháp tính giá xuất ?", "Voucher already exists, change the method for calculating the export price"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then GoTo kt
                            End If
                            If Combo(2).SelectedIndex >= 0 Then pTien = Combo(2).SelectedValue
                            pMaVach = Check(9).CheckState + (IIf(Check(19).CheckState = CheckState.Checked, 10, 0)) + (IIf(Check(20).CheckState = CheckState.Checked, 100, 0)) + (IIf(Check(21).CheckState = CheckState.Checked, 1000, 0)) + (IIf(DEMO = 0, 10000, 0))
                            pSoKT = (IIf(Check(10).CheckState = CheckState.Checked, 1, 0)) + (IIf(Check(11).CheckState = CheckState.Checked, 10, 0)) + (IIf(Check(12).CheckState = CheckState.Checked, 100, 0)) + (IIf(Check(14).CheckState = CheckState.Checked, 10000, 0))
                            pctpath = IIf(FileSystem.Dir(Text_Renamed(8).Text, FileAttribute.Normal).Length > 0, Text_Renamed(8).Text, "...")
                            If Check(18).CheckState = CheckState.Unchecked Then
                                tygia = 0
                            Else
                                tygia = IIf(Check(18).CheckState = CheckState.Checked, ConvertToIntSafe(Text_Renamed(21).Text), TyGiaNT(0))
                                If tygia = 0 Then tygia = 1
                                If pTygia = CheckState.Unchecked Then
                                    ThemTruong("ChungTu", "TyGia", DbType.Double)
                                    ExecSQLNonQuery("UPDATE ChungTu SET TyGia=" & CStr(tygia) & " WHERE TyGia=0 OR TyGia=1")
                                End If
                            End If
                            If Check(33).CheckState = CheckState.Checked And pGiaUSD = 0 Then
                                If ThemTruong("TonKho", "USDTien_0", DbType.Double) Then
                                    If tygia > 0 Then ExecSQLNonQuery("UPDATE TonKho SET USDTien_0=Round(" & Mask_N & "*Tien_0/" & CStr(tygia) & ")/" & ConvertToStrSafe(Mask_N))
                                End If
                                If ThemTruong("VTDauNam", "USDTien_0", DbType.Double) Then
                                    If tygia > 0 Then ExecSQLNonQuery("UPDATE VTDauNam SET USDTien_0=Round(" & Mask_N & "*Tien_0/" & CStr(tygia) & ")/" & ConvertToStrSafe(Mask_N))
                                End If
                                If ThemTruong("ChungTu", "PSUSD", DbType.Double) Then
                                    ExecSQLNonQuery("UPDATE ChungTu SET PSUSD=Round(" & Mask_N & "*SoPS/TyGia)/" & ConvertToStrSafe(Mask_N) & " WHERE TyGia<>0")
                                End If
                                For i = 1 To 12
                                    ThemTruong("TonKho", "USDTien_Nhap_" & i, DbType.Double)
                                    ThemTruong("TonKho", "USDTien_Xuat_" & i, DbType.Double)
                                    ThemTruong("TonKho", "USDTien_" & i, DbType.Double)
                                Next
                            End If
                            k = ConvertToIntSafe(Text_Renamed(25).Text)
                            For i = pSoVV + 1 To k
                                CopyTable2("DoiTuongCT", "DoiTuongCT" & i)
                                ThemTruong("CPGVHD", "MaDT" & i, DbType.Int64)
                            Next
                            If pNhapKhau = 0 And Check(36).CheckState = CheckState.Checked And (Not BangDaCo("CPGVHD")) Then CopyTable(pCurDir & "UPDATE.MDB", "CPGVHD")
                            Fx = ConvertToIntSafe((ConvertToIntSafe((Text_Renamed(24).Text)) Mod 100) + (IIf(Check(23).CheckState = CheckState.Checked, 100, 0)) + (IIf(Check(24).CheckState = CheckState.Checked, 1000, 0)) + (Combo(3).SelectedIndex + 1) * 100000000 + (IIf(Check(25).CheckState = CheckState.Checked, 10000000, 0)) + (IIf(Check(26).CheckState = CheckState.Checked, 1000000, 0)) + (IIf(Check(27).CheckState = CheckState.Checked, 100000, 0)) + (IIf(Check(28).CheckState = CheckState.Checked, 10000, 0)) + (IIf(Check(29).CheckState = CheckState.Checked, 1000000000, 0)))
                            F0 = (IIf(Check(30).CheckState = CheckState.Checked, 10, 0)) + (IIf(Check(31).CheckState = CheckState.Checked, 100, 0)) + (IIf(Check(32).CheckState = CheckState.Checked, 1000, 0)) + (IIf(Check(33).CheckState = CheckState.Checked, 10000, 0))
                            f1 = (IIf(Check(34).CheckState = CheckState.Checked, 10, 0)) + (IIf(ChkVT(3).CheckState = CheckState.Checked, 100, 0)) + (IIf(Check(55).CheckState = CheckState.Checked, 1000, 0)) + (IIf(Check(35).CheckState = CheckState.Checked And k > 0 And k <= 3, 10000 * k, 0))
                            F2 = (IIf(Check(36).CheckState = CheckState.Checked, 10, 0)) + (IIf(ChkVT(4).CheckState = CheckState.Checked, 100, 0)) + (IIf(Check(37).CheckState = CheckState.Checked, 1000, 0)) + (IIf(Check(38).CheckState = CheckState.Checked, 10000, 0))
                            Dim STR_ As String = String.Format("UPDATE License SET TenCty =N'{0}', TenCn =N'{1}', DiaChi =N'{2}', Tel =N'{3}', Fax =N'{4}', Quan=N'{5}', ThanhPho=N'{6}',TaiKhoanVN =N'{7}', TaiKhoanNT =N'{8}', TenCty_ID = {9},TenCn_ID = {10}, NamTC = {11},TKVattu=N'{12}-{13}',STDetail = {14}, FADetail = {15}, HDV = {16},Thang = {17} , Tag =N'{18}',OutCost={19},MKUP={20},MaSoThue =N'{21}',MST_ID = {22},App1Path=N'{23}',TyGia={24},FixedoutCost={25},GiaHT={26},RptOrder={27},NgayDauThang={28},MV={29},SoKT={30},EMail=N'{31}',SMTP=N'{32}',EMailDB=N'{33}',CTGS_GV={34},LoaiTien={35},Flag1={36},Lock0=Lock0 % 10 + {37},Lock1=Lock1 % 10 + {38},Lock2=Lock2 % 10 + {39}", _
                                                   Text_Renamed(0).Text, _
                                                   Text_Renamed(1).Text, _
                                                   Text_Renamed(2).Text, _
                                                   Text_Renamed(3).Text, _
                                                   Text_Renamed(4).Text, _
                                                   Text_Renamed(19).Text, _
                                                   Text_Renamed(20).Text, _
                                                   Text_Renamed(5).Text, _
                                                   Text_Renamed(6).Text, _
                                                   ConvertToStrSafe(Int_StrToCode(Text_Renamed(0).Text)), _
                                                   ConvertToStrSafe(Int_StrToCode(Text_Renamed(1).Text)), _
                                                   Combo(0).Text, _
                                                   Text_Renamed(22).Text, _
                                                   Text_Renamed(23).Text, _
                                                   ConvertToIntSafe((IIf(Check(0).CheckState = CheckState.Checked And Check(13).CheckState = CheckState.Checked, 1000, 0)) + (IIf(Check(0).CheckState = CheckState.Checked And Check(5).CheckState = CheckState.Checked, 100, 0)) + (IIf(Check(0).CheckState = CheckState.Checked And Check(4).CheckState = CheckState.Checked, 10, 0)) + Check(0).CheckState), _
                                                   ConvertToIntSafe(Check(1).CheckState), _
                                                   ConvertToIntSafe(Check(2).CheckState), _
                                                   IIf(Combo(1).Text = "", 1, Combo(1).Text), _
                                                   (IIf(DEMO = 0, "S", "DEMO")), _
                                                   ConvertToStrSafe(ttVT), _
                                                   ConvertToStrSafe(pRev), _
                                                   Text_Renamed(7).Text, _
                                                   ConvertToStrSafe(Int_StrToCode(Text_Renamed(7).Text)), _
                                                   pctpath, _
                                                   CStr(tygia), _
                                                   ConvertToIntSafe(ChkVT(0).CheckState), _
                                                   ConvertToIntSafe(ChkVT(1).CheckState), _
                                                   ConvertToIntSafe((IIf(Check(22).CheckState = CheckState.Checked, 1000, 0)) + (IIf(Check(16).CheckState = CheckState.Checked, 100, 0)) + (IIf(Check(15).CheckState = CheckState.Checked, 10, 0)) + 1 - Check(3).CheckState), _
                                                   (IIf(ConvertToIntSafe(Text_Renamed(14).Text) > 1, Text_Renamed(14).Text, "0")), _
                                                   ConvertToStrSafe(pMaVach), _
                                                   ConvertToStrSafe(pSoKT), _
                                                   Text_Renamed(15).Text, _
                                                   Text_Renamed(16).Text, _
                                                   Text_Renamed(17).Text, _
                                                   ConvertToStrSafe(CTGS.SelectedIndex), _
                                                   ConvertToStrSafe(pTien), _
                                                   ConvertToStrSafe(Fx), _
                                                   ConvertToStrSafe(F0), _
                                                   ConvertToStrSafe(f1), _
                                                   ConvertToStrSafe(F2))
                            If ExecSQLNonQuery(STR_) <> 0 Then
                                GoTo kt
                            End If

                            Interaction.SaveSetting(IniPath, "Environment", "DInvoice", Text_Renamed(11).Text)
                            Interaction.SaveSetting(IniPath, "Environment", "CInvoice", Text_Renamed(12).Text)
                            Interaction.SaveSetting(IniPath, "Environment", "UNC", Text_Renamed(18).Text)
                            Interaction.SaveSetting(IniPath, "Environment", "HD", Text_Renamed(28).Text)
                            Interaction.SaveSetting(IniPath, "Environment", "NDecimal", Text_Renamed(13).Text)
                            Interaction.SaveSetting(IniPath, "Invoice", "VAT1", ConvertToStrSafe(Check(6).CheckState))
                            Interaction.SaveSetting(IniPath, "Invoice", "ListDetail", ConvertToStrSafe(Check(7).CheckState))
                            Interaction.SaveSetting(IniPath, "Invoice", "VATCheck", ConvertToStrSafe(Check(8).CheckState))
                            Interaction.SaveSetting(IniPath, "Stock", "DailySummary", ConvertToStrSafe(ChkVT(2).CheckState))

                            If Not pSongNgu And Check(14).CheckState = CheckState.Checked Then ThemSongNgu()
                            If pCongNoHD = 0 And Check(31).CheckState = CheckState.Checked Then ExecSQLNonQuery("INSERT INTO CNDauNam (MaSo,MaTaiKhoan,MaKhachHang,DuNo_0,DuCo_0,DuNT_0,SoXuat,HanTT) SELECT MaSo,MaTaiKhoan,MaKhachHang,DuNo_0,DuCo_0,DuNT_0,0 AS SoXuat,0 AS HanTT FROM SoDuKhachHang WHERE DuNo_0<>0 OR DuCo_0<>0 OR DuNT_0<>0")
                            pSTOP = 0
                        End If
                    End If
                    Me.Close()
                Case 2
                    FrmBacthuemonbai.ShowDialog()
                    ThueMB()
                Case 3
                    Kiemtrangay0()
                    Kiemtrangay()
                    Exit Sub
            End Select
kt:
            HienThongBao("", 1)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Text_Renamed_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_28.Enter, _Text_27.Enter, _Text_26.Enter, _Text_9.Enter, _Text_17.Enter, _Text_11.Enter, _Text_18.Enter, _Text_12.Enter, _Text_23.Enter, _Text_0.Enter, _Text_1.Enter, _Text_2.Enter, _Text_3.Enter, _Text_4.Enter, _Text_5.Enter, _Text_6.Enter, _Text_7.Enter, _Text_14.Enter, _Text_16.Enter, _Text_15.Enter, _Text_19.Enter, _Text_20.Enter, _Text_8.Enter, _Text_13.Enter, _Text_21.Enter, _Text_22.Enter, _Text_25.Enter, _Text_24.Enter, _Text_10.Enter
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Text_Renamed(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Text_Renamed_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _Text_28.KeyPress, _Text_27.KeyPress, _Text_26.KeyPress, _Text_9.KeyPress, _Text_17.KeyPress, _Text_11.KeyPress, _Text_18.KeyPress, _Text_12.KeyPress, _Text_23.KeyPress, _Text_0.KeyPress, _Text_1.KeyPress, _Text_2.KeyPress, _Text_3.KeyPress, _Text_4.KeyPress, _Text_5.KeyPress, _Text_6.KeyPress, _Text_7.KeyPress, _Text_14.KeyPress, _Text_16.KeyPress, _Text_15.KeyPress, _Text_19.KeyPress, _Text_20.KeyPress, _Text_8.KeyPress, _Text_13.KeyPress, _Text_21.KeyPress, _Text_22.KeyPress, _Text_25.KeyPress, _Text_24.KeyPress, _Text_10.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Select Case Index
            Case 7, 11 To 14, 18, 21, 24, 25
                KeyProcess(Text_Renamed(Index), KeyAscii, True)
            Case 22
                If DEMO = 1 Then KeyAscii = 0
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
    Private Sub Text_Renamed_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_28.Leave, _Text_27.Leave, _Text_26.Leave, _Text_9.Leave, _Text_17.Leave, _Text_11.Leave, _Text_18.Leave, _Text_12.Leave, _Text_23.Leave, _Text_0.Leave, _Text_1.Leave, _Text_2.Leave, _Text_3.Leave, _Text_4.Leave, _Text_5.Leave, _Text_6.Leave, _Text_7.Leave, _Text_14.Leave, _Text_16.Leave, _Text_15.Leave, _Text_19.Leave, _Text_20.Leave, _Text_8.Leave, _Text_13.Leave, _Text_21.Leave, _Text_22.Leave, _Text_25.Leave, _Text_24.Leave, _Text_10.Leave
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Select Case Index
            Case 1 To 6, 8, 9, 10, 15 To 17, 19, 20, 22, 23
                If Strings.Len(Text_Renamed(Index).Text) = 0 Then Text_Renamed(Index).Text = "..."
            Case 7
                Text_Renamed(Index).Text = SetNumericStr(Text_Renamed(Index).Text)
                If Strings.Len(Text_Renamed(Index).Text) = 0 Then Text_Renamed(Index).Text = "00"
                HienNoiBo()
            Case 8
                If FileSystem.Dir(Text_Renamed(8).Text, FileAttribute.Normal).Length = 0 Then Text_Renamed(8).Text = "..."
            Case 21
                If ConvertToIntSafe(Text_Renamed(21).Text) = 0 Then Check(8).CheckState = CheckState.Unchecked
            Case 24
                If ConvertToDblSafe((Text_Renamed(24).Tag)) > 0 And ConvertToIntSafe(Text_Renamed(24).Text) > ConvertToDblSafe((Text_Renamed(24).Tag)) Then Text_Renamed(24).Text = ConvertToStrSafe(Text_Renamed(24).Tag)
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadInfo()
        Dim rs As DataTable = ExecSQLReturnDT("SELECT TOP 1 * FROM License")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            Try
                cn(1).Text = ConvertToStrSafe(rsItem("cn1"))
                cn(2).Text = ConvertToStrSafe(rsItem("cn2"))
                cn(3).Text = ConvertToStrSafe(rsItem("cn3"))
                cn(4).Text = ConvertToStrSafe(rsItem("cn4"))
                cn(5).Text = ConvertToStrSafe(rsItem("cn5"))
                cn(6).Text = ConvertToStrSafe(rsItem("cn6"))
                cn(7).Text = ConvertToStrSafe(rsItem("cn7"))
                cn(8).Text = ConvertToStrSafe(rsItem("cn8"))
                cn(9).Text = ConvertToStrSafe(rsItem("cn9"))
                cn(10).Text = ConvertToStrSafe(rsItem("cn10"))
                ChkKBS.CheckState = ConvertToIntSafe(rsItem("kbs"))
                nnt.Text = ConvertToStrSafe(rsItem("nnt"))
                If pVersion = 3 Then
                    Combo(3).Items.Add("Hành chính sự nghiệp")
                    Combo(3).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                End If
                If Combo(3).Items.Count > 0 Then Combo(3).SelectedIndex = (ConvertToIntSafe(rsItem("Flag1")) Mod 1000000000) \ 100000000 - 1
                ttVT = ConvertToStrSafe(rsItem("OutCost"))
                OptVT(ttVT).Checked = True
                ChkVT(0).CheckState = ConvertToIntSafe(rsItem("FixedOutCost"))
                ChkVT(1).CheckState = ConvertToIntSafe(rsItem("GiaHT"))
                ChkVT(4).CheckState = pBarCode
                Check(0).CheckState = IIf(ConvertToIntSafe(rsItem("STDetail")) <> 0, 1, 0)
                Check(1).CheckState = ConvertToIntSafe(rsItem("FADetail"))
                Check(2).CheckState = ConvertToIntSafe(rsItem("HDV"))
                Check(3).CheckState = 1 - (ConvertToIntSafe(rsItem("RptOrder")) Mod 10)
                Check(4).CheckState = (ConvertToIntSafe(rsItem("STDetail")) Mod 100) \ 10
                Check(5).CheckState = (ConvertToIntSafe(rsItem("STDetail")) Mod 1000) \ 100
                Check(13).CheckState = (ConvertToIntSafe(rsItem("STDetail")) Mod 10000) \ 1000
                Check(6).CheckState = ConvertToIntSafe(Interaction.GetSetting(IniPath, "Invoice", "VAT1", "0"))
                Check(7).CheckState = ConvertToIntSafe(Interaction.GetSetting(IniPath, "Invoice", "ListDetail", "0"))
                Check(8).CheckState = ConvertToIntSafe(Interaction.GetSetting(IniPath, "Invoice", "VATCheck", "0"))
                Check(9).CheckState = pMaVach
                suatencn = IIf(ConvertToIntSafe((rsItem("mv"))) Mod 100 >= 10, 1, 0)
                Check(19).CheckState = suatencn
                Check(20).CheckState = IIf(ConvertToIntSafe((rsItem("mv"))) Mod 1000 >= 100, 1, 0)
                Check(21).CheckState = pTyGiaBQ
                Check(23).CheckState = pBaoGia
                Check(24).CheckState = pNVBH
                Check(30).CheckState = (ConvertToIntSafe((rsItem("Lock0"))) Mod 100) \ 10
                Check(31).CheckState = (ConvertToIntSafe((rsItem("Lock0"))) Mod 1000) \ 100
                Check(32).CheckState = (ConvertToIntSafe((rsItem("Lock0"))) Mod 10000) \ 1000
                Check(33).CheckState = (ConvertToIntSafe((rsItem("Lock0"))) Mod 100000) \ 10000
                Check(34).CheckState = (ConvertToIntSafe((rsItem("Lock1"))) Mod 100) \ 10
                Check(35).CheckState = IIf(pSoVV > 0, 1, 0)
                Check(36).CheckState = IIf(pNhapKhau > 0, 1, 0)
                Check(37).CheckState = IIf(pNhapDoiTuong > 0, 1, 0)
                Check(38).CheckState = IIf(pTrungSoHieuKhacThang > 0, 1, 0)
                Check(39).CheckState = ConvertToStrSafe(rsItem("Khongxuatam"))
                Check(40).CheckState = ConvertToStrSafe(rsItem("giatheokhach"))
                Text_Renamed(25).Text = ConvertToStrSafe(pSoVV)
                ChkVT(3).CheckState = pKiemKeNgay
                Text_Renamed(24).Text = ConvertToStrSafe(ConvertToIntSafe((rsItem("Flag1"))) Mod 100)
                Check(25).CheckState = (ConvertToIntSafe((rsItem("Flag1"))) Mod 100000000) \ 10000000
                Check(26).CheckState = (ConvertToIntSafe((rsItem("Flag1"))) Mod 10000000) \ 1000000
                Check(27).CheckState = (ConvertToIntSafe((rsItem("Flag1"))) Mod 1000000) \ 100000
                Check(28).CheckState = (ConvertToIntSafe((rsItem("Flag1"))) Mod 100000) \ 10000
                'OptBH(0).Checked = (ConvertToIntSafe((rsItem("Banhang"))) Mod 10 = 1)
                'OptBH(1).Checked = ((ConvertToIntSafe((rsItem("Banhang"))) Mod 100) \ 10 = 1)
                'OptBH(2).Checked = ((ConvertToIntSafe((rsItem("Banhang"))) Mod 1000) \ 100 = 1)
                Check(41).CheckState = IIf(ConvertToIntSafe(rsItem("Banhang")) Mod 10000 >= 1000, 1, 0)
                Check(42).CheckState = IIf(ConvertToIntSafe(rsItem("Banhang")) Mod 100000 >= 10000, 1, 0)
                Check(43).CheckState = IIf(ConvertToIntSafe(rsItem("Banhang")) Mod 1000000 >= 100000, 1, 0)
                Check(29).CheckState = IIf(pThuChiNhapXuat, 1, 0) 'van cuong edit 1/4/18 : frmMain.Command(4).Visible
                Check(10).CheckState = IIf(pSoKT Mod 10 >= 1, 1, 0)
                Check(11).CheckState = IIf(pSoKT Mod 100 >= 10, 1, 0)
                Check(12).CheckState = IIf(pSoKT Mod 1000 >= 100, 1, 0)
                Check(14).CheckState = IIf(pSoKT Mod 100000 >= 10000, 1, 0)
                Check(15).CheckState = IIf(ConvertToIntSafe(rsItem("RptOrder")) Mod 100 >= 10, 1, 0)
                Check(22).CheckState = IIf(ConvertToIntSafe(rsItem("RptOrder")) Mod 10000 >= 1000, 1, 0)
                Check(16).CheckState = IIf(ConvertToIntSafe(rsItem("RptOrder")) Mod 1000 >= 100, 1, 0)
                Check(17).CheckState = IIf(ConvertToStrSafe(rsItem("App1Path")) <> "...", 1, 0)
                Check(18).CheckState = IIf(ConvertToStrSafe(rsItem("tygia")) > 0, 1, 0)
                Text_Renamed(8).Text = ConvertToStrSafe(rsItem("App1Path"))
                Text_Renamed(0).Text = pTenCty
                Text_Renamed(1).Text = pTenCn
                Text_Renamed(2).Text = ConvertToStrSafe(rsItem("DiaChi"))
                Text_Renamed(3).Text = ConvertToStrSafe(rsItem("Tel"))
                Text_Renamed(4).Text = ConvertToStrSafe(rsItem("Fax"))
                Text_Renamed(5).Text = ConvertToStrSafe(rsItem("TaiKhoanVN"))
                Text_Renamed(6).Text = ConvertToStrSafe(rsItem("TaiKhoanNT"))
                MST = ConvertToStrSafe(rsItem("MaSoThue"))
                Text_Renamed(7).Text = MST
                SetListIndex(CTGS, ConvertToStrSafe(rsItem("CTGS_GV")))
                Text_Renamed(11).Text = Interaction.GetSetting(IniPath, "Environment", "DInvoice", "2")
                Text_Renamed(12).Text = Interaction.GetSetting(IniPath, "Environment", "CInvoice", "2")
                Text_Renamed(18).Text = Interaction.GetSetting(IniPath, "Environment", "UNC", "2")
                Text_Renamed(28).Text = Interaction.GetSetting(IniPath, "Environment", "HD", "2")
                Text_Renamed(13).Text = Interaction.GetSetting(IniPath, "Environment", "NDecimal", "2")
                Text_Renamed(14).Text = IIf(ConvertToStrSafe(rsItem("NgayDauThang")) = 0, "1", ConvertToStrSafe(rsItem("NgayDauThang")))
                Text_Renamed(15).Text = ConvertToStrSafe(rsItem("email"))
                Text_Renamed(16).Text = ConvertToStrSafe(rsItem("smtp"))
                Text_Renamed(17).Text = ConvertToStrSafe(rsItem("EMailDB"))
                Text_Renamed(19).Text = ConvertToStrSafe(rsItem("Quan"))
                Text_Renamed(20).Text = ConvertToStrSafe(rsItem("ThanhPho"))
                Text_Renamed(21).Text = Format(ConvertToStrSafe(rsItem("tygia")), Mask_2)
                Text_Renamed(22).Text = LaySH(ConvertToStrSafe(rsItem("TKVattu")), 1, "-")
                Text_Renamed(23).Text = LaySH(ConvertToStrSafe(rsItem("TKVattu")), 1, "-")
                If pNoiBo > 0 Then
                    kb = 1
                    Check(55).CheckState = CheckState.Checked
                    HienNoiBo()
                End If
            Catch
            End Try
        End If
        SetListIndex(Combo(0), pNamTC)
        SetListIndex(Combo(1), pThangDauKy)
        For i As Integer = pNamTC - 1 To pNamTC + 1
            Combo(0).Items.Add(ConvertToStrSafe(i))
        Next
        If Combo(0).Items.Count > 0 Then Combo(0).SelectedIndex = 1
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="lh"></param>
    ''' <param name="TM"></param>
    ''' <param name="xd"></param>
    ''' <param name="cdt"></param>
    ''' <param name="sx"></param>
    ''' <remarks></remarks>
    Private Sub PhanChucNang(ByRef lh As Integer, ByRef TM As Integer, ByRef xd As Integer, ByRef cdt As Integer, ByRef sx As Integer)
        For i As Integer = 0 To 36
            Check(i).Visible = True
        Next
        Check(13).Visible = sx > 0
        Check(24).Visible = TM > 0
        Check(31).Visible = TM > 0
        Check(23).Visible = TM > 0
        Check(33).Visible = TM > 0
        Check(34).Visible = TM > 0
        Check(14).Visible = (lh > 1 And lh < 3 Or lh = 5)
        Check(15).Visible = lh <> 4
        Check(19).Visible = lh <> 4
        Check(20).Visible = lh <> 4
        Check(29).Visible = lh < 3 Or lh = 5
        Check(32).Visible = lh < 3 Or lh = 5
        If Not Check(32).Visible Then Check(32).CheckState = CheckState.Unchecked
        Check(30).Visible = lh < 3 Or lh = 5
        Check(19).Visible = IIf(lh < 3 Or lh = 5, True, Check(19).CheckState)
        If pVersion = 3 Then
            Check(4).Visible = False
            CTGS.Visible = False
            Check(5).Visible = False
            Check(13).Visible = False
            Check(14).Visible = False
            Check(22).Visible = False
            Check(31).Visible = False
            Check(21).Visible = False
            Check(36).Visible = False
            Check(26).Visible = False
            Check(27).Visible = False
            Check(28).Visible = False
            OptBH(0).Visible = False
            OptBH(1).Visible = False
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub HienNoiBo()
        If (ConvertToIntSafe(Strings.Left(Text_Renamed(7).Text, 2)) = 0) And kb > 0 Then
            Check(55).Visible = True
        Else
            Check(55).Visible = False
            Check(55).CheckState = CheckState.Unchecked
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmOptions_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub ChkMonbai_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMonbai.CheckedChanged

    End Sub
End Class
