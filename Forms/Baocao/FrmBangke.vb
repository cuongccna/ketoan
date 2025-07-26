Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmBangke
    Dim ton As Double
    Dim sole As String = String.Empty
    Public loai As Integer

    Dim QChitiet As String
    Dim QNhatky As String
    Dim MienTru As String
    Dim QCdt As String
    Dim QDuPhong As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitForm()
        Dim iIndex As Integer = 0
        Dim Objects() As Object

        iIndex = 0
        Objects = New Object() {Ngonngu("Tài khoản", "Accounts"), Ngonngu("Khách hàng", "Customers"), Ngonngu("Vật tư", "Goods")}
        For Each objItem As Object In Objects
            Cbooption.Items.Add(objItem.ToString, iIndex + 1)
            iIndex += 1
        Next

        iIndex = 0
        Objects = New Object() {"5", "10", "15", "20", "25"}
        For Each objItem As Object In Objects
            CboLai.Items.Add(objItem.ToString, objItem.ToString)
            iIndex += 1
        Next

        iIndex = 0
        Objects = New Object() {"0", "1", "2", "3", "4", "5"}
        For Each objItem As Object In Objects
            CboSole.Items.Add(objItem.ToString, objItem.ToString)
            iIndex += 1
        Next

        InitVAT(CboTL)
    End Sub

    Private Sub Khoi_tao()
        ColumnSetUp(Grd, 0, 350, 2)
        ColumnSetUp(Grd, 1, 950, 2)
        ColumnSetUp(Grd, 2, 830, 2)
        ColumnSetUp(Grd, 3, 1070, 0)
        ColumnSetUp(Grd, 4, 3710, 0)
        ColumnSetUp(Grd, 5, 1425, 2)
        ColumnSetUp(Grd, 6, 1910, 4)
        ColumnSetUp(Grd, 7, 830, 4)
        ColumnSetUp(Grd, 8, 830, 4)
        ColumnSetUp(Grd, 9, 1180, 4)
        ColumnSetUp(Grd, 10, 470, 4)
        ColumnSetUp(Grd, 11, 1070, 4)
        ColumnSetUp(Grd, 12, 1, 1)
        ColumnSetUp(Grd, 13, 1, 1)
        ColumnSetUp(Grd, 14, 1180, 4)
        ColumnSetUp(Grd, 15, 1180, 4)
        Grd.Cols = 16
    End Sub
    Dim co As Integer = 0
    Private Sub FrmBangke_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            InitForm()
            If co = 0 Then Khoi_tao()
            For chi_so As Integer = 0 To 1
                AddMonthToCbo(CboThang(chi_so))
            Next
            With FrmMNBaocao
                For chi_so As Integer = 0 To 1
                    CboThang(chi_so).SelectedIndex = .CboThang(chi_so).SelectedIndex
                Next
                If CboTL.Items.Count > 0 Then CboTL.SelectedIndex = .CboTL.SelectedIndex
            End With
            If CboSole.Items.Count > 0 Then CboSole.SelectedIndex = 0
            If CboLai.Items.Count > 0 Then CboLai.SelectedIndex = 0
            ClearGrid(Grd, Grd.Rows)
            If Cbooption.Items.Count > 0 Then
                Cbooption.SelectedIndex = 0
            End If

            Command_ClickEvent(Command(0), New EventArgs())
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
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_0.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim tdau, tcuoi As Integer
        Dim taikhoan As New ClsTaikhoan
        Select Case Index
            Case 0
                If CboSole.SelectedIndex > 0 Then
                    sole = "#,###."
                    For i As Integer = 1 To ConvertToDblSafe(CboSole.SelectedValue)
                        sole = String.Format("{0}0", sole)
                    Next i
                Else
                    sole = "#,###"
                End If
                If CboThang(0).Items.Count > 0 And CboThang(1).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue
                taikhoan.InitTaikhoanMaSo(0)
                If FrmMNBaocao.OptVAT(2).Checked Then
                    InVATDauRa(tdau, tcuoi, CboTL.SelectedValue, taikhoan)
                Else
                    InVATDauVao(tdau, tcuoi, CboTL.SelectedValue, 1, taikhoan)
                End If
            Case 2
                If CboThang(0).Items.Count > 0 And CboThang(1).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue
                taikhoan.InitTaikhoanMaSo(0)
                SetRptInfo()
                If FrmMNBaocao.OptVAT(2).Checked Then
                    InVATDauRa1(tdau, tcuoi, CboTL.SelectedValue, taikhoan)
                Else
                    InVATDauVao1(tdau, tcuoi, CboTL.SelectedValue, 1, taikhoan)
                End If
            Case 1
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmBangke_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.L
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    'Command_ClickEvent(Command(2), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="TK"></param>
    ''' <remarks></remarks>
    Private Sub InVATDauRa(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef TK As ClsTaikhoan)

        Dim kh As String = "", sh As String = ""
        Dim i As Integer
        'Dim tmp As Double
        loai = 2
        GauGe.Maximum = 1
        Dim QNhatky As String = ""
        Select Case TL
            Case -3
                QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE {2} HoaDon.Loai=1 AND HDBL=1 AND {3} AND KCT=0 AND (HoaDon.DC=0 OR HD=1)", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, _
                                           String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), _
                                           String.Empty)), _
                                      WThang("ThangCT", tdau, tcuoi)))
            Case -2
                QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS ELSE AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE {2} HoaDon.Loai=1 AND {3} AND KCT=1 AND (HoaDon.DC=0 OR HD=1)", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, _
                                           String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), _
                                           String.Empty)), _
                                      WThang("ThangCT", tdau, tcuoi)))
            Case -1
                QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE {2} HoaDon.Loai=1 AND {3} AND (HoaDon.DC=0 OR HD=1) ", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, _
                                           String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), _
                                           String.Empty)), _
                                      WThang("ThangCT", tdau, tcuoi)))
            Case 30
                QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE {2} HoaDon.Loai=1 AND (TyLe=5 OR TyLe=10) AND {3} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, _
                                           String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), _
                                           String.Empty)), _
                                      WThang("ThangCT", tdau, tcuoi)))
            Case Else
                QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE {2} HoaDon.Loai=1 AND TyLe={3} AND {4} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, _
                                           String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), _
                                           String.Empty)), _
                                      ConvertToStrSafe(TL), _
                                      WThang("ThangCT", tdau, tcuoi)))
        End Select
        Dim sqld As String = String.Format("ton.luong_{0}", tcuoi - 1)
        Dim sqld1 As String = String.Format("ton.tien_{0}", tcuoi - 1)
        Dim sqlc As String = String.Format("ton.luong_nhap_{0}", tcuoi)
        Dim sqlc1 As String = String.Format("ton.tien_nhap_{0}", tcuoi)
        MienTru = (String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=1 GROUP BY MaCT", _
                              ChungTu2TKHD(0), _
                              WThang("ThangCT", tdau, tcuoi)))
        QCdt = (String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND MaLoai=8 GROUP BY MaCT HAVING Count(MaVattu)>=1", WThang("ThangCT", tdau, tcuoi)))
        QDuPhong = (String.Format("SELECT ChungTu.MaCT,TenVattu AS MH,SoPS2Co AS SL,SoPS AS TT,vattu.donvi as dvt, CASE WHEN {0}=0 THEN {1} ELSE {0}+{1} END as luongnhap, CASE WHEN {0}=0 THEN {2} ELSE {3}+{2} END as tiennhap,vattu.sohieu as shvt,chungtu.maso as maso1,hethongtk.sohieu as sohieutk FROM ((((ChungTu INNER JOIN (" + MienTru + ") AS MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN (" + QCdt + ") AS  QCdt ON ChungTu.MaCT=QCdt.MaCT)inner join tonkho ton on vattu.maso=ton.mavattu WHERE TK_ID={4}", _
                               sqld, _
                               sqlc, _
                               sqlc1, _
                               sqld1, _
                               ConvertToStrSafe(TKDT_ID)))
        Dim rs As New DataTable
        If Cbooption.Items.Count > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT distinct QNhatKy.*,QDuPhong.* FROM ( (" & QNhatky & ")as QNhatKy LEFT JOIN (" + QDuPhong + ") AS  QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT) inner join (Chungtu inner join Hethongtk on Chungtu.matkco=Hethongtk.maso) on QNhatKy.SOHD=Chungtu.sohieu WHERE {0}{1} (left(Hethongtk.sohieu,3)<>'333' or (left(Hethongtk.sohieu,3)='333' and chungtu.matkno=0)) ORDER BY NgayPH,SoHD,maso1", _
                                                              (IIf(ChkTen.CheckState = CheckState.Checked, String.Format("QDuPhong.MH like '%{0}%' And ", TxtTen.Text), String.Empty)), _
                                                              (IIf(Chk.CheckState = CheckState.Checked, (IIf(Cbooption.SelectedValue = 1, String.Format("Hethongtk.sohieu like '{0}%' AND ", TxtSohieu.Text), (IIf(Cbooption.SelectedValue = 3, String.Format("shvt like '{0}%' AND ", TxtSohieu.Text), String.Empty)))), String.Empty))))
        End If

        ClearGrid(Grd, Grd.Rows)
        Dim dk3, tongthue, tongtien, dk4 As Double
        Dim k, dong As Integer
        Dim Thue As Double
        Dim dk1, tien, sl, dk2 As Double
        If rs.Rows.Count > 0 Then
            'rs.MoveLast()
            GauGe.Maximum = rs.Rows.Count
            i = 1
            ''rs.MoveFirst()
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                Grd.AddItem(String.Format("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}", Chr(9), " "))
                With Grd
                    If kh <> rsItem(0) Or sh <> rsItem(1) Then
                        Grd.AddItem(String.Format("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}", Chr(9), " "))
                        kh = rsItem(0)
                        sh = rsItem(1)
                        .Row = (i - 1)
                        .Col = 0
                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(i)
                        For j As Integer = 1 To 3
                            .Col = ConvertToDblSafe(j)
                            If j = 3 Then
                                If Not IsDBNull(rsItem(j - 1)) Then .Items(.Row).SubItems(.Col).Text = Format(CDate(rsItem(j - 1)), Mask_D)
                            Else
                                If Not IsDBNull(rsItem(j - 1)) Then .Items(.Row).SubItems(.Col).Text = rsItem(j - 1)
                            End If

                        Next
                        For j As Integer = 4 To 5
                            .Col = ConvertToDblSafe(j)
                            If Not IsDBNull(rsItem(2 + j)) Then .Items(.Row).SubItems(.Col).Text = rsItem(2 + j)
                        Next
                        .Col = 6
                        If Not IsDBNull(rsItem(3)) Then .Items(.Row).SubItems(.Col).Text = rsItem(3)
                        .Col = 9
                        If Not IsDBNull(rsItem(5)) Then
                            dk3 = rsItem(5) : .Items(.Row).SubItems(.Col).Text = Format(dk3, Mask_0) : tongtien += dk3
                        End If
                        .Col = 8
                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(-dk3)
                        k = .Row
                        .Col = 10
                        If Not IsDBNull(rsItem(11)) Then
                            dk4 = rsItem(11) : .Items(.Row).SubItems(.Col).Text = String.Format("{0}%", ConvertToStrSafe(dk4))
                        End If
                        .Col = 11
                        Thue = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sops as f1 FROM chungtu WHERE sohieu=N'{0}' and matkco={1}", _
                                                                   sh, _
                                                                   Timten("maso", "333111", "sohieu", "hethongtk"))))
                        If Thue <> 0D Then
                            .Items(.Row).SubItems(.Col).Text = Format(Thue, Mask_0) : tongthue += Thue
                        End If
                        .Col = 14
                        .Items(.Row).SubItems(.Col).Text = Format(dk3 + Thue, Mask_0)
                        .Col = 15
                        .Items(.Row).SubItems(.Col).Text = Format(dk3 * dk4 / 100 - Thue, Mask_0)
                        dk4 = 0 : dk3 = 0 : Thue = 0
                        i += 1
                        GauGe.Maximum += 1
                    End If
                    .Row = (i - 1)
                    .Col = 0
                    .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(i)
                    .Col = 1
                    If Not IsDBNull(rsItem("sohieutk")) Then
                        .Items(.Row).SubItems(.Col).Text = rsItem("sohieutk")
                    Else
                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(GetSelectValue(String.Format("SELECT t2.sohieu as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE (left(t2.sohieu,3)<>'333' or (left(t2.sohieu,3)='333' and t1.matkno=0)) and t1.sohieu=N'{0}'", sh)))
                    End If
                    .Col = 3
                    If Not IsDBNull(rsItem("shvt")) Then .Items(.Row).SubItems(.Col).Text = rsItem("shvt")
                    .Col = 4
                    If Not IsDBNull(rsItem(17)) Then
                        .Items(.Row).SubItems(.Col).Text = Hoadautu(rsItem(17))
                    Else
                        .Items(.Row).SubItems(.Col).Text = Hoadautu(rsItem(3))
                    End If
                    .Col = 5
                    If Not IsDBNull(rsItem("dvt")) Then .Items(.Row).SubItems(.Col).Text = rsItem("dvt")
                    .Col = 6
                    If Not IsDBNull(rsItem(18)) Then sl = rsItem(18)
                    .Items(.Row).SubItems(.Col).Text = Format(sl, sole)
                    .Col = 8
                    If Not IsDBNull(rsItem("luongnhap")) Then .Items(.Row).SubItems(.Col).Text = Format(CDbl(CDbl(rsItem("tiennhap")) / CDbl(rsItem("luongnhap"))), Mask_0)
                    .Col = 9
                    If Not IsDBNull(rsItem(19)) Then
                        tien = rsItem(19)
                    Else
                        tien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT t1.sops as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE t2.sohieu<>'333111' and t1.sohieu=N'{0}'", sh)))
                    End If
                    .Items(.Row).SubItems(.Col).Text = Format(tien, Mask_0)
                        dong = .Row
                        .Row = ConvertToDblSafe(k) : .Col = 8
                    .Items(.Row).SubItems(.Col).Text = Format(tien + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text), Mask_0)
                        .Row = dong
                        .Col = 7
                    If sl <> 0 Then .Items(.Row).SubItems(.Col).Text = Format(tien / sl, Mask_0)
                        sl = 0 : tien = 0
                    .Col = 7 : dk1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 8 : dk2 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 11
                    If dk1 < dk2 Or dk1 > dk2 * (CboLai.SelectedValue / 100 + 1) Then .Items(.Row).SubItems(.Col).Text = "?"
                        .Col = 12
                    If Not IsDBNull(rsItem("MaSo1")) Then .Items(.Row).SubItems(.Col).Text = rsItem("MaSo1")
                        .Col = 13
                    If Not IsDBNull(rsItem(1)) Then .Items(.Row).SubItems(.Col).Text = rsItem(1)
                End With
                GauGe.Value = i
                i += 1
            End While
        End If
        Label(25).Text = Format(tongtien, Mask_0)
        Label(26).Text = Format(tongthue, Mask_0)
        Label(8).Text = "Giá bán"
        Me.Text = String.Format(Ngonngu("Bảng kê hoá đơn đầu ra {0} - {1}", "Output lists invoices {0} - {1}"), CboThang(0).Text, CboThang(1).Text)
        Exit Sub
        MessageBox.Show(Ngonngu("Không có số phát sinh !", "Not arise !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="TK"></param>
    ''' <remarks></remarks>
    Private Sub InVATDauRa1(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef TK As ClsTaikhoan)
        Dim kh, sh As String
        Dim i As Integer
        loai = 2
        GauGe.Maximum = 1

        Dim QNhatky As String = String.Empty
        Select Case TL
            Case -3
                QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu, CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT as [QnhatKy.MaCT],KCT FROM {1} WHERE HoaDon.Loai=1 AND HDBL=1 AND {2} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      WThang("ThangCT", tdau, tcuoi))
            Case -2
                QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT as [QnhatKy.MaCT],KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND KCT=1 AND (HoaDon.DC=0 OR HD=1) ", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      WThang("ThangCT", tdau, tcuoi))
            Case -1
                QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT as [QnhatKy.MaCT],KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND (HoaDon.DC=0 OR HD=1) ", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      WThang("ThangCT", tdau, tcuoi))
            Case 30
                QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT as [QnhatKy.MaCT],KCT FROM {1} WHERE HoaDon.Loai=1 AND (TyLe=5 OR TyLe=10) AND {2} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      WThang("ThangCT", tdau, tcuoi))
            Case Else
                QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu, CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT as [QnhatKy.MaCT],KCT FROM {1} WHERE HoaDon.Loai=1 AND TyLe={2} AND {3} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                      GTGTPN_ID, _
                                      ChungTu2TKHD(2), _
                                      ConvertToStrSafe(TL), _
                                      WThang("ThangCT", tdau, tcuoi))
        End Select

        Dim sqld As String = String.Format("ton.luong_{0}", tcuoi - 1)
        Dim sqld1 As String = String.Format("ton.tien_{0}", tcuoi - 1)
        Dim sqlc As String = String.Format("ton.luong_nhap_{0}", tcuoi)
        Dim sqlc1 As String = String.Format("ton.tien_nhap_{0}", tcuoi)
        MienTru = String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=1 GROUP BY MaCT", _
                             ChungTu2TKHD(0), _
                             WThang("ThangCT", tdau, tcuoi))
        QCdt = String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND MaLoai=8 GROUP BY MaCT HAVING Count(MaVattu)>=1", WThang("ThangCT", tdau, tcuoi))
        QDuPhong = String.Format("SELECT ChungTu.MaCT,TenVattu AS MH,SoPS2Co AS SL,SoPS AS TT,vattu.donvi as dvt, CASE WHEN {0}=0 THEN {1} ELSE {0} END as luongnhap, CASE WHEN {0}=0 THEN {2} ELSE {3} END as tiennhap,vattu.sohieu as shvt,chungtu.maso FROM ((((ChungTu INNER JOIN  (" + MienTru + ") AS MienTru  ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN  (" + QCdt + ") AS  QCdt  ON ChungTu.MaCT=QCdt.MaCT)inner join tonkho ton on vattu.maso=ton.mavattu WHERE TK_ID={4}", _
                               sqld, _
                               sqlc, _
                               sqlc1, _
                               sqld1, _
                               ConvertToStrSafe(TKDT_ID))
        rptFrom = rptFrom.copyReportObject(rptFrom)
        With rptFrom
            .InitForm("BANGKER61.RPT", _
                String.Format("SELECT QNhatKy.*,QDuPhong.* FROM ({0}) as QNhatKy LEFT JOIN ({1}) AS  QDuPhong ON QNhatKy.[QNhatKy.MaCT]=QDuPhong.MaCT ORDER BY NgayPH,SoHD,maso", QNhatky, QDuPhong), _
                "QChitiet")
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))

            .ReportWindowTitle = String.Format("Bảng kê hoá đơn đầu ra {0} - {1}", CboThang(0).Text, CboThang(1).Text)
            .ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
            .SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
            .SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
            .SetFormulas("TLKT", TL)
            Dim reportMessage As String = .DoReport()
            If String.IsNullOrEmpty(reportMessage) Then

            End If
        End With
        If Not RptOK(rptFrom.ReportFilename, 0) Then
            MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "Change report form!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            On Error GoTo KhongInBC
            'frmMain.rpt.Action = 1
        End If
KhongInBC:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="HD"></param>
    ''' <param name="TK"></param>
    ''' <remarks></remarks>
    Private Sub InVATDauVao(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef HD As Integer, ByRef TK As ClsTaikhoan)
        Khoi_tao()
        Dim Tk2 As New ClsTaikhoan
        Dim i As Integer
        Dim sh = String.Empty
        Dim kh As String = String.Empty
        Dim sqld As String = String.Empty
        loai = 1
        Dim Fx As Integer = IIf(Strings.Left(frmMain._LbCty_8.Text, 2) = "35" Or Strings.Left(frmMain._LbCty_3.Text, 2) = "64", 35, 0)
        Tk2.InitTaikhoanSohieu("33312")
        If Tk2.tk_id = GTGTKT_ID Then
            sqld = String.Format("DELETE HoaDon  FROM ((HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE (HethongTK.SoHieu LIKE '{0}%') AND (TK.SoHieu LIKE '33312%'  OR  ChungTu.GhiChu like '%33312%') AND HoaDon.Loai=-1", pVATV)
            ExecSQLNonQuery(sqld)
        End If
        Select Case TL
            Case -3
                If Fx = 0 Then
                    If Cbooption.Items.Count > 0 Then
                        QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE {1} Loai=-1 AND HD={2} AND {3} AND HDBL=1 AND (HoaDon.DC=0 OR HD=1) ", _
                                                                 ChungTu2TKHD(10), _
                                                                 (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), String.Empty)), _
                                                                 ConvertToStrSafe(HD), _
                                                                 WThang("ThangCT", tdau, tcuoi)))
                    End If

                Else
                    If Cbooption.Items.Count > 0 Then
                        QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE {1} Loai=-1 AND {2} AND HDBL=1 AND KCT=1 AND (HoaDon.DC=0 OR HD=1) ", _
                                                                 ChungTu2TKHD(10), _
                                                                 (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), String.Empty)), _
                                                                 WThang("ThangCT", tdau, tcuoi)))
                    End If

                End If
            Case -2
                If Cbooption.Items.Count > 0 Then
                    QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE {1} Loai=-1 AND HD={2} AND {3} AND KCT=1 AND (HoaDon.DC=0 OR HD=1) ", _
                                                          ChungTu2TKHD(10), _
                                                          (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), String.Empty)), _
                                                          ConvertToStrSafe(HD), _
                                                          WThang("ThangCT", tdau, tcuoi)))
                End If

            Case -1
                If Fx = 0 Then
                    If Cbooption.Items.Count > 0 Then
                        QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE {1} Loai=-1 AND HD={2} AND {3} AND (HoaDon.DC=0 OR HD=1) ", _
                                                                  ChungTu2TKHD(10), _
                                                                  (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), String.Empty)), _
                                                                  ConvertToStrSafe(HD), _
                                                                  WThang("ThangCT", tdau, tcuoi)))
                    End If

                Else
                    If Cbooption.Items.Count > 0 Then
                        QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE {1} Loai=-1 AND HD={2} AND {3} AND (HDBL=0 OR KCT=0) AND (HoaDon.DC=0 OR HD=1) ", _
                                                                 ChungTu2TKHD(10), _
                                                                 (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), String.Empty)), _
                                                                 ConvertToStrSafe(HD), _
                                                                 WThang("ThangCT", tdau, tcuoi)))
                    End If

                End If
            Case 30
                If Cbooption.Items.Count > 0 Then
                    QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE {1} Loai=-1 AND (TyLe=5 OR TyLe=10) AND HD={2} AND {3} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                                         ChungTu2TKHD(10), _
                                                         (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), String.Empty)), _
                                                         ConvertToStrSafe(HD), _
                                                         WThang("ThangCT", tdau, tcuoi)))
                End If

            Case Else
                If Cbooption.Items.Count > 0 Then
                    QNhatky = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE {1} Loai=-1 AND TyLe={2} AND HD={3} AND {4} AND KCT=0 AND HDBL=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                                          ChungTu2TKHD(10), _
                                                          (IIf(Chk.CheckState = CheckState.Checked And Cbooption.SelectedValue = 2, String.Format("khachhang.sohieu=N'{0}' AND ", TxtSohieu.Text), String.Empty)), _
                                                          ConvertToStrSafe(TL), _
                                                          ConvertToStrSafe(HD), _
                                                          WThang("ThangCT", tdau, tcuoi)))
                End If

        End Select
        sqld = String.Format("ton.luong_{0}", tcuoi - 1)
        Dim sqld1 As String = String.Format("ton.tien_{0}", tcuoi - 1)
        Dim sqlc As String = String.Format("ton.luong_nhap_{0}", tcuoi)
        Dim sqlc1 As String = String.Format("ton.tien_nhap_{0}", tcuoi)
        MienTru = (String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=-1 GROUP BY MaCT", _
                              ChungTu2TKHD(0), _
                              WThang("ThangCT", tdau, tcuoi)))
        QCdt = (String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND (MaLoai=1 or MaLoai=13 or MaLoai=9) GROUP BY MaCT HAVING Count(MaVattu)>=1", WThang("ThangCT", tdau, tcuoi)))
        QDuPhong = (String.Format("SELECT ChungTu.MaCT,TenVattu as MH,SoPS2No AS SL,SoPS AS TT,vattu.donvi as dvt,({0}+{1}) as luongnhap,({2}+{3}) as tiennhap,vattu.sohieu as shvt,chungtu.maso as maso1,hethongtk.sohieu as sohieutk FROM ((((ChungTu INNER JOIN (" + MienTru + ") AS MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN (" + QCdt + ") AS  QCdt ON ChungTu.MaCT=QCdt.MaCT)inner join tonkho ton on vattu.maso=ton.mavattu WHERE (TK_ID={4} OR HethongTK.Loai=6)", _
                               sqld, _
                               sqlc, _
                               sqld1, _
                               sqlc1, _
                               ConvertToStrSafe(TKVT_ID)))
        Dim rs As New DataTable
        If Cbooption.Items.Count > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT distinct QNhatKy.*,QDuPhong.* FROM ((" + QNhatky + ") as QNhatKy LEFT JOIN (" + QDuPhong + ") AS  QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT) inner join (chungtu inner join hethongtk on chungtu.matkno=hethongtk.maso) on chungtu.maso=QNhatKy.maso WHERE {0}{1} 1=1 ORDER BY NgayPH,SoHD,maso1", _
                                                              (IIf(ChkTen.CheckState = CheckState.Checked, String.Format("QDuPhong.MH like '%{0}%' And ", TxtTen.Text), String.Empty)), _
                                                              (IIf(Chk.CheckState = CheckState.Checked, (IIf(Cbooption.SelectedValue = 1, String.Format("Hethongtk.sohieu like '{0}%' AND ", TxtSohieu.Text), (IIf(Cbooption.SelectedValue = 3, String.Format("shvt like '{0}%' AND ", TxtSohieu.Text), String.Empty)))), String.Empty))))
        End If

        ClearGrid(Grd, Grd.Rows)
        Dim dk3, tongthue, tongtien, dk4 As Double
        Dim k, dong As Integer
        Dim Thue As Double
        Dim dk1, tien, sl, dk2 As Double
        If rs.Rows.Count > 0 Then
            'rs.MoveLast()
            GauGe.Maximum = rs.Rows.Count
            Grd.Rows = rs.Rows.Count
            i = 1
            ''rs.MoveFirst()
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                Grd.AddItem(String.Format("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}", Chr(9), " "))
                With Grd
                    If kh <> rsItem(0) Or sh <> rsItem(1) Then
                        Grd.AddItem(String.Format("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}", Chr(9), " "))
                        kh = rsItem(0)
                        sh = rsItem(1)
                        .Row = (i - 1)
                        .Col = 0
                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(i)
                        For j As Integer = 1 To 3
                            .Col = ConvertToDblSafe(j)
                            If j = 3 Then
                                If Not IsDBNull(rsItem(j - 1)) Then .Items(.Row).SubItems(.Col).Text = Format(CDate(rsItem(j - 1)), Mask_DB)
                            Else
                                If Not IsDBNull(rsItem(j - 1)) Then .Items(.Row).SubItems(.Col).Text = rsItem(j - 1)
                            End If

                        Next
                        For j As Integer = 4 To 5
                            .Col = ConvertToDblSafe(j)
                            If Not IsDBNull(rsItem(2 + j)) Then .Items(.Row).SubItems(.Col).Text = rsItem(2 + j)
                        Next
                        .Col = 6
                        If Not IsDBNull(rsItem(3)) Then .Items(.Row).SubItems(.Col).Text = rsItem(3)
                        .Col = 9
                        If Not IsDBNull(rsItem(5)) <> 0 Then
                            dk3 = rsItem(5) : .Items(.Row).SubItems(.Col).Text = Format(dk3, Mask_0) : tongtien += dk3
                        End If
                        .Col = 8
                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(-dk3)
                        k = .Row
                        .Col = 10
                        If Not IsDBNull(rsItem(11)) <> 0 Then
                            dk4 = rsItem(11) : .Items(.Row).SubItems(.Col).Text = String.Format("{0}%", ConvertToStrSafe(dk4))
                        End If
                        .Col = 11
                        Thue = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sops as f1 FROM chungtu WHERE sohieu=N'{0}' and matkno={1}", _
                                                                   sh, _
                                                                   Timten("maso", "133111", "sohieu", "hethongtk"))))
                        If Thue <> 0 Then
                            .Items(.Row).SubItems(.Col).Text = Format(Thue, Mask_0) : tongthue += Thue
                        End If
                        .Col = 14
                        .Items(.Row).SubItems(.Col).Text = Format(dk3 + Thue, Mask_0)
                        .Col = 15
                        .Items(.Row).SubItems(.Col).Text = Format(dk3 * dk4 / 100 - Thue, Mask_0)
                        dk4 = 0 : dk3 = 0 : Thue = 0
                        i += 1
                        Grd.Rows = ConvertToDblSafe(Grd.Rows + 1)
                        GauGe.Maximum += 1
                    End If
                    .Row = (i - 1)
                    .Col = 0
                    .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(i)
                    .Col = 1
                    If Not IsDBNull(rsItem("sohieutk")) Then
                        .Items(.Row).SubItems(.Col).Text = rsItem("sohieutk")
                    Else
                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(GetSelectValue(String.Format("SELECT t2.sohieu as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE not t2.sohieu like '13311%' and t1.sohieu=N'{0}'", sh)))
                        If .Items(.Row).SubItems(.Col).Text = "0" Then .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(GetSelectValue(String.Format("SELECT t2.sohieu as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE t1.sohieu=N'{0}'", sh)))
                    End If
                    .Col = 3
                    If Not IsDBNull(rsItem("shvt")) Then .Items(.Row).SubItems(.Col).Text = rsItem("shvt")
                    .Col = 4
                    If Not IsDBNull(rsItem(18)) Then
                        .Items(.Row).SubItems(.Col).Text = Hoadautu(rsItem(18).ToString)
                    Else
                        .Items(.Row).SubItems(.Col).Text = Hoadautu(rsItem(3).ToString)
                    End If
                    .Col = 5
                    If Not IsDBNull(rsItem("dvt")) Then .Items(.Row).SubItems(.Col).Text = rsItem("dvt")
                    .Col = 6
                    If Not IsDBNull(rsItem(19)) Then sl = rsItem(19)
                    .Items(.Row).SubItems(.Col).Text = Format(sl, sole)
                    .Col = 8
                    If Not IsDBNull(rsItem("luongnhap")) Then .Items(.Row).SubItems(.Col).Text = Format(rsItem("tiennhap") / rsItem("luongnhap"), Mask_0)
                    .Col = 9
                    If Not IsDBNull(rsItem(20)) Then
                        tien = rsItem(20)
                    Else
                        tien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT t1.sops as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE not t2.sohieu like '13311%' and t1.sohieu=N'{0}'", sh)))
                    End If
                    If tien = 0 Then tien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT t1.sops as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE t1.sohieu=N'{0}'", sh)))
                    .Items(.Row).SubItems(.Col).Text = Format(tien, Mask_0)
                    dong = .Row
                    .Row = ConvertToDblSafe(k) : .Col = 8
                    .Items(.Row).SubItems(.Col).Text = Format(tien + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text), Mask_0)
                    .Row = dong
                    .Col = 7
                    If sl <> 0 Then .Items(.Row).SubItems(.Col).Text = Format(tien / sl, Mask_0)
                    sl = 0 : tien = 0
                    .Col = 7 : dk1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 8 : dk2 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 11
                    If dk1 < dk2 * (1 - CboLai.SelectedIndex / 100) Or dk1 > dk2 * (1 + CboLai.SelectedIndex / 100) Then .Items(.Row).SubItems(.Col).Text = "?"
                    .Col = 12
                    If Not IsDBNull(rsItem("MaSo1")) Then .Items(.Row).SubItems(.Col).Text = rsItem("MaSo1")
                    .Col = 13
                    If Not IsDBNull(rsItem(1)) Then .Items(.Row).SubItems(.Col).Text = rsItem(1)
                End With
                GauGe.Value = i
                i += 1
                ''rs.MoveNext()
            End While
        End If
        Label(25).Text = Format(tongtien, Mask_0)
        Label(26).Text = Format(tongthue, Mask_0)
        Label(8).Text = "Giá mua"
        If Grd.Rows < 30 Then Grd.Rows = 30
        Me.Text = String.Format(Ngonngu("Bảng kê hoá đơn đầu vào {0} - {1}", "Input lists invoice"), CboThang(0).Text, CboThang(1).Text)
        Exit Sub
        MessageBox.Show(Ngonngu("Không có số phát sinh !", "Not arise !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        If Grd.Rows < 30 Then Grd.Rows = 30
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="HD"></param>
    ''' <param name="TK"></param>
    ''' <remarks></remarks>
    Private Sub InVATDauVao1(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef HD As Integer, ByRef TK As ClsTaikhoan)
        Dim Tk2 As New ClsTaikhoan
        Dim i As Integer
        Dim sh, kh, sqld As String
        loai = 1
        Dim Fx As Integer = IIf(Strings.Left(frmMain._LbCty_8.Text, 2) = "35" Or Strings.Left(frmMain._LbCty_3.Text, 2) = "64", 35, 0)
        Tk2.InitTaikhoanSohieu("33312")
        If Tk2.tk_id = GTGTKT_ID Then
            sqld = String.Format("DELETE HoaDon  FROM ((HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE (HethongTK.SoHieu LIKE '{0}%') AND (TK.SoHieu LIKE '33312%'  OR ChungTu.GhiChu like '%33312%') AND HoaDon.Loai=-1", pVATV)
            ExecSQLNonQuery(sqld)
        End If
        Select Case TL
            Case -3
                If Fx = 0 Then
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND HDBL=1 AND (HoaDon.DC=0 OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(HD), _
                                       WThang("ThangCT", tdau, tcuoi))
                Else
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND {1} AND HDBL=1 AND KCT=1 AND (HoaDon.DC=0 OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       WThang("ThangCT", tdau, tcuoi))
                End If
            Case -2
                QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND KCT=1 AND (HoaDon.DC=0 OR HD=1) ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(HD), _
                                   WThang("ThangCT", tdau, tcuoi))
            Case -1
                If Fx = 0 Then
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND (HoaDon.DC=0 OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(HD), _
                                       WThang("ThangCT", tdau, tcuoi))
                Else
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND (HDBL=0 OR KCT=0) AND (HoaDon.DC=0 OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(HD), _
                                       WThang("ThangCT", tdau, tcuoi))
                End If
            Case 30
                QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND (TyLe=5 OR TyLe=10) AND HD={1} AND {2} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(HD), _
                                   WThang("ThangCT", tdau, tcuoi))
            Case Else
                QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND TyLe={1} AND HD={2} AND {3} AND KCT=0 AND HDBL=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(TL), _
                                   ConvertToStrSafe(HD), _
                                   WThang("ThangCT", tdau, tcuoi))
        End Select

        sqld = String.Format("ton.luong_{0}", tcuoi - 1)
        Dim sqld1 As String = String.Format("ton.tien_{0}", tcuoi - 1)
        Dim sqlc As String = String.Format("ton.luong_nhap_{0}", tcuoi)
        Dim sqlc1 As String = String.Format("ton.tien_nhap_{0}", tcuoi)

        MienTru = String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=-1 GROUP BY MaCT", _
              ChungTu2TKHD(0), _
              WThang("ThangCT", tdau, tcuoi))

        QCdt = String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND (MaLoai=1 or MaLoai=13 or MaLoai=9) GROUP BY MaCT HAVING Count(MaVattu)>=1", WThang("ThangCT", tdau, tcuoi))
        QDuPhong = String.Format("SELECT ChungTu.MaCT,TenVattu,SoPS2No AS SL,SoPS AS TT,vattu.donvi as dvt,CASE WHEN {0}=0 THEN {1} ELSE {0} END as luongnhap,CASE WHEN {0}=0 THEN {2} ELSE {3} END as tiennhap,vattu.sohieu as shvt,chungtu.maso as maso1 FROM ((((ChungTu INNER JOIN  (" + MienTru + ") AS MienTru  ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN  (" + QCdt + ") AS  QCdt  ON ChungTu.MaCT=QCdt.MaCT)inner join tonkho ton on (vattu.maso=ton.mavattu and hethongtk.maso=ton.mataikhoan) WHERE (TK_ID={4} OR HethongTK.Loai=6)", sqld, sqlc, sqlc1, sqld1, ConvertToStrSafe(TKVT_ID))
        Dim QChitiet As String = String.Format("SELECT QNhatKy.*,QDuPhong.* FROM (" + QNhatky + ") AS QNhatKy LEFT JOIN ({0}) AS QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT ORDER BY NgayPH,SoHD,maso1", QDuPhong)
        rptFrom = rptFrom.copyReportObject(rptFrom)
        With rptFrom
            .InitForm("BANGKEV61.RPT", QChitiet, "QChitiet")
            .SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))

            .ReportWindowTitle = String.Format("Bảng kê hoá đơn đầu vào {0} - {1}", CboThang(0).Text, CboThang(1).Text)
            .ReportWindowState = System.Windows.Forms.FormWindowState.Maximized

            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))

            .SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
            .SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
            .SetFormulas("TLKT", String.Format("{0}", TL))

            Dim reportMessage As String = .DoReport()
            If String.IsNullOrEmpty(reportMessage) Then

            End If
        End With
        If Not RptOK(rptFrom.ReportFilename, 0) Then
            MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "Change report form!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            On Error GoTo KhongInBC
            'frmMain.rpt.Action = 1
            Tk2 = Nothing
        End If
KhongInBC:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.DoubleClick
        Grd.Col = 2
        If Grd.CtlText <> " " Then
            If MessageBox.Show(Ngonngu("Sửa chứng từ?", "Edit voucher ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                FrmChungtu.Suatonkho(Grd.CtlText) : ClearGrid(Grd, Grd.Rows) : Command_ClickEvent(Command(0), New EventArgs())
            End If
        Else
            If FrmOptSuaTonkho.thuchien() = 1 Then
                ClearGrid(Grd, Grd.Rows) : Command_ClickEvent(Command(0), New EventArgs())
            End If
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
        If eventArgs.KeyCode = 187 Then KeyProcess(txt, eventArgs.KeyCode, True)
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
            If Cbooption.SelectedValue = 1 Then
                TxtSohieu.Text = FrmTaikhoan.ChonTk(TxtSohieu.Text)
                TxtSohieu.Tag = ConvertToStrSafe(SoHieu2MaSo(TxtSohieu.Text, "HeThongTK"))
            ElseIf Cbooption.SelectedValue = 2 Then
                TxtSohieu.Text = FrmKhachHang.ChonKhachHang(TxtSohieu.Text)
                TxtSohieu.Tag = ConvertToStrSafe(SoHieu2MaSo(TxtSohieu.Text, "KhachHang"))
            Else
                TxtSohieu.Text = FrmVattu.ChonVattu(TxtSohieu.Text)
                TxtSohieu.Tag = ConvertToStrSafe(SoHieu2MaSo(TxtSohieu.Text, "Vattu"))
            End If
        End If
        Me.Cursor = Cursors.Default
        TxtSohieu.Focus()
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
    Private Sub TxtSohieu_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtSohieu.Leave
        LbTen.Text = tentk(TxtSohieu.Text, 0)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmBangke_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
