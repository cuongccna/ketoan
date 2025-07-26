Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmDuphong
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Dim iIndex As Integer = 0
        Dim Objects() As Object

        iIndex = 0
        Objects = New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
        For Each objItem As Object In Objects
            _Cbo_0.Items.Add(objItem.ToString, 0)
            _Cbo_1.Items.Add(objItem.ToString, 0)
            iIndex += 1
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmDuphong_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            FormInit()
            ColumnSetUp(GrdGia, 0, 1300, 2)
            ColumnSetUp(GrdGia, 1, 2260, 0)
            ColumnSetUp(GrdGia, 2, 820, 2)
            ColumnSetUp(GrdGia, 3, 1180, 4)
            ColumnSetUp(GrdGia, 4, 1180, 4)
            ColumnSetUp(GrdGia, 5, 1180, 4)
            ColumnSetUp(GrdGia, 6, 1260, 4)
            ColumnSetUp(GrdGia, 7, 1, 0)
            AddMonthToCbo(CboThang)
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", Cbo(0))
            Int_RecsetToCbo("SELECT MaSo As F2, SoHieu + ' - ' + TenPhanLoai As F1 FROM PhanLoaiVattu ORDER BY SoHieu", Cbo(1))
            Text = String.Format("{0} - {1}", Text, ConvertToStrSafe(pNamTC))
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
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0, 1
                If Cbo(0).Items.Count = 0 Or Cbo(1).Items.Count = 0 Then
                    ErrMsg(er_VTKoTon)
                    Exit Sub
                End If
                InDuPhong(CboThang.SelectedValue, IIf(Chk(0).CheckState = CheckState.Checked, Cbo(0).SelectedValue, 0), IIf(Chk(1).CheckState = CheckState.Checked, Cbo(1).SelectedValue, 0), Index)
            Case 2
                Me.Close()
            Case 3
                If Cbo(0).Items.Count = 0 Or Cbo(1).Items.Count = 0 Then Exit Sub
                ListGia(CboThang.SelectedValue, IIf(Chk(0).CheckState = CheckState.Checked, Cbo(0).SelectedValue, 0), IIf(Chk(1).CheckState = CheckState.Checked, Cbo(1).SelectedValue, 0))
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdghi_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdghi.Click
        Dim giacu, soluong As Double
        Dim sh As String = String.Empty
        Dim gia As Double = ConvertToDblSafe(txtGia.Text)
        With GrdGia
            .Col = 0
            sh = .CtlText
            If sh.Length = 0 Then Exit Sub
            .Col = 5
            .CtlText = Format(gia, Mask_2)
            .Col = 4
            giacu = ConvertToDblSafe(.CtlText)
            .Col = 3
            soluong = ConvertToDblSafe(.CtlText)
            .Col = 6
            .CtlText = Format(soluong * (gia - giacu), Mask_0)
            ExecSQLNonQuery(String.Format("UPDATE Vattu SET GiaDuPhong = {0} WHERE SoHieu =N'{1}'", CStr(gia), sh))
            .Col = 0
            .Row = (.Row + 1)
        End With
        GrdGia_ClickEvent(GrdGia, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmDuphong_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.I
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub GrdGia_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdGia.Click
        'SendKeys.SendWait("{Home}")
        SetGridIndex(GrdGia, GrdGia.Row)
        With GrdGia
            .Col = 0
            If .CtlText.length > 0 Then
                For i As Integer = 0 To 4
                    .Col = ConvertToDblSafe(i)
                    LbDuphong(i).Text = .CtlText
                Next
                .Col = 4
                txtGia.Text = .CtlText
                txtGia.Focus()
            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdGia_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdGia.KeyPress
        'SendKeys.SendWait("{Home}")
        SetGridIndex(GrdGia, GrdGia.Row)
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdGia_ClickEvent(GrdGia, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdGia_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdGia.MouseDown
        If eventArgs.Button = MouseButtons.Right Then 'eventArgs.Button = 2
            SearchObj(1, , GrdGia, GrdGia.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtGia_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtGia.Enter
        txtGia.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtGia_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtGia.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        KeyProcess(txtGia, KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' Thu tuc liet ke vat tu va gia du phong
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ListGia(ByRef thang As Integer, ByRef mkho As Integer, ByRef maloai As Integer)
        Dim chenhlech, luong, tien, dongia, tien2 As Double
        Me.Cursor = Cursors.WaitCursor
        ClearGrid(GrdGia, ConvertToDblSafe(GrdGia.Tag))
        Dim rs_vattu As DataTable = ExecSQLReturnDT(String.Format("SELECT distinct Vattu.MaSo, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Vattu.GiaDuPhong  FROM (Vattu INNER JOIN TonKho ON Vattu.MaSo=TonKho.MaVattu) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo  WHERE Luong_{0}<>0 {1}{2} ", _
                                                        thang, _
                                                        (IIf(mkho > 0, " AND MaSoKho = " & mkho, String.Empty)), _
                                                        (IIf(maloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(maloai, "PhanLoaiVattu")), String.Empty))))
        Dim i As Integer = 0
        For Each rsVattuItem As DataRow In rs_vattu.Rows
            luong = SoTonKho(thang, mkho, 0, rsVattuItem("MaSo"), tien, tien2)
            If luong <> 0 Then
                i += 1
                If ConvertToDblSafe(rsVattuItem("GiaDuPhong")) > 0 Then
                    dongia = ConvertToDblSafe(rsVattuItem("GiaDuPhong"))
                Else
                    dongia = (IIf(0.5 + Mask_N * tien / luong > 0, Math.Floor(0.5 + Mask_N * tien / luong), Math.Ceiling(0.5 + Mask_N * tien / luong))) / Mask_N
                    ExecSQLNonQuery(String.Format("UPDATE Vattu SET GiaDuPhong = {0} WHERE MaSo = {1}", _
                                        CStr(dongia), _
                                        rsVattuItem("MaSo")))
                End If
                chenhlech = IIf(ConvertToDblSafe(rsVattuItem("GiaDuPhong")) > 0, luong * (dongia - tien / luong), 0)
                GrdGia.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                                   rsVattuItem("SoHieu"), _
                                   Chr(9), _
                                   rsVattuItem("TenVattu"), _
                                   rsVattuItem("DonVi"), _
                                   Format(luong, Mask_2), _
                                   Format(tien / luong, Mask_2), _
                                   Format(dongia, Mask_2), _
                                   Format(chenhlech, Mask_0), _
                                   rsVattuItem("MaSo")), 0)
            End If
        Next
        GrdGia.Rows = IIf(i > ConvertToDblSafe(GrdGia.Tag), ConvertToDblSafe(i), ConvertToDblSafe(GrdGia.Tag))
        Me.Cursor = Cursors.Default
        GrdGia.Row = 0
    End Sub
    ''' <summary>
    ''' Thu tuc in du phong giam gia hang ton kho
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InDuPhong(ByRef thang As Integer, ByRef mkho As Integer, ByRef mloai As Integer, ByRef dest As Integer)
        Dim tien, luong, tien2 As Double
        Me.Cursor = Cursors.WaitCursor
        ExecSQLNonQuery("DELETE FROM BaoCaoCP")

        'Dim RecordsAffectedCount As Integer = ExecSQLNonQueryRF(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu) SELECT DISTINCT Vattu.MaSo,Vattu.MaSo  FROM (Vattu INNER JOIN TonKho ON Vattu.MaSo=TonKho.MaVattu) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo  WHERE Luong_{0}<>0 {1}{2} GROUP BY Vattu.MaSo", _
        '                      thang, _
        '                      (IIf(mkho > 0, String.Format(" AND MaSoKho = {0}", mkho), String.Empty)), _
        '                      (IIf(mloai <> 0, String.Format("PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty))))
        Dim RecordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,BC_ID) SELECT DISTINCT Vattu.MaSo,Vattu.MaSo,Vattu.MaSo  FROM (Vattu INNER JOIN TonKho ON Vattu.MaSo=TonKho.MaVattu) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo  WHERE Luong_{0}<>0 {1}{2} GROUP BY Vattu.MaSo", _
                              thang, _
                              (IIf(mkho > 0, String.Format(" AND MaSoKho = {0}", mkho), String.Empty)), _
                              (IIf(mloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty))))
        If RecordsAffectedCount = 0 Then
            Me.Cursor = Cursors.Default
            ErrMsg(er_VTKoTon)
            Exit Sub
        End If
        Dim rs_luyke As DataTable = ExecSQLReturnDT("SELECT * FROM BaoCaoCP")
        For Each rsLuykeItem As DataRow In rs_luyke.Rows
            'luong = SoTonKho(thang, _
            '            0, _
            '            0, _
            '            ConvertToDblSafe(rsLuykeItem("MaSo")), _
            '            tien, _
            '            tien2)
            luong = SoTonKho_2(thang, _
            0, _
            0, _
            ConvertToDblSafe(rsLuykeItem("MaSo")), _
            tien, _
            tien2)
            tien = SoTonKho_1(thang, _
                        0, _
                        0, _
                        ConvertToDblSafe(rsLuykeItem("MaSo")), _
                        tien, _
                        tien2)
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP SET Kq1 = {0}, Kq2 = {1} WHERE MaSo = {2}", _
                                CStr(luong), _
                                CStr(tien), _
                                rsLuykeItem("MaSo")))
        Next
        'rptFrom.InitForm("DUPHONG.RPT", _
        '    "SELECT DISTINCT PhanLoaiVattu.SoHieu, PhanLoaiVattu.TenPhanLoai, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Vattu.GiaDuPhong, BaoCaoCP.Kq1, BaoCaoCP.Kq2" & " FROM PhanLoaiVattu INNER JOIN (Vattu INNER JOIN BaoCaoCP ON Vattu.MaSo = BaoCaoCP.BC_ID) ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai ORDER BY PhanLoaiVattu.SoHieu,Vattu.SoHieu", _
        '    "QDuPhong")
        rptFrom.InitForm("DUPHONG.RPT", _
    "SELECT DISTINCT HeThongTK.MaSo as [HeThongTK.MaSo], HeThongTK.SoHieu as [HeThongTK.SoHieu],HeThongTK.Ten as [Ten],PhanLoaiVattu.MaSo AS [PhanLoaiVattu.MaSo], PhanLoaiVattu.SoHieu AS [PhanLoaiVattu.SoHieu], PhanLoaiVattu.TenPhanLoai, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Vattu.GiaDuPhong, BaoCaoCP.Kq1 as [Kq1], BaoCaoCP.Kq2 as [Kq2] FROM PhanLoaiVattu INNER JOIN (Vattu INNER JOIN BaoCaoCP ON Vattu.MaSo = BaoCaoCP.BC_ID) ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai inner join HeThongTK on HeThongTK.MaSo=PhanLoaiVattu.MaTK ORDER BY PhanLoaiVattu.SoHieu,Vattu.SoHieu", _
    "QDuPhong")
        SetRptInfo()
        rptFrom.SetFormulas("Thang", thang)
        If mkho > 0 Then
            rptFrom.SetFormulas("TenKho", String.Format(Ngonngu("'Kho: {0}'", "'Stock: {0}'"), Cbo(0).Text))
        Else
            rptFrom.SetFormulas("TenKho", String.Format("'{0}'", "Tổng hợp các kho"))
        End If

        RptSetDate(NgayCuoiThang(pNamTC, thang))
        rptFrom.ReportDestination = dest
        InBaoCaoRPT()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmDuphong_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
