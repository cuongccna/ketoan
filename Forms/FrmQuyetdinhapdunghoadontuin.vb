Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmQuyetdinhapdunghoadontuin
    Dim Ngay(2) As Date
    Dim MaSo As Integer
    Dim denghi, sodkkd, so, tendonvi, giamdoc, quanly As String
    Dim thongsoht, tenht, cungcap As String
    Dim mauhd, LoaiHD, sudung As String
    Dim tentn, Trachnhiem As String

    Private Sub Cbo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo.SelectedIndexChanged
        Hienthi()
    End Sub
    Sub Hienthi()
        Dim rs As DataTable
        If Not (Cbo.SelectedIndex < 0) Then
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM quyetdinh1 WHERE maso={0}", Cbo.SelectedValue))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                MaSo = rsItem("MaSo")
                txt(1).Text = rsItem("tendonvi")
                txt(2).Text = rsItem("sodkkd")
                txt(3).Text = rsItem("giamdoc")
                txt(4).Text = rsItem("denghi")
                txt(5).Text = rsItem("quanly")
                txt(6).Text = rsItem("cungcap")
                MedNgay(0).Text = rsItem("Ngay")
                MedNgay(1).Text = rsItem("Ngayad")
                MedNgay(2).Text = rsItem("Ngayhl")
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM quyetdinh2 WHERE maqd={0}", MaSo))
            ClearGrid(GrdVT(0), GrdVT(0).Rows - 1)
            If GrdVT(0).Rows < 3 Then GrdVT(0).Rows = 3
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL

                GrdVT(0).AddItem(String.Format("{0}{1}{2}{1}{3}", _
                                     rsItem("ten"), _
                                     Chr(9), _
                                     rsItem("ThongSo"), _
                                     rsItem("MaSo")), 0)
                GrdVT(0).Row = ConvertToDblSafe(GrdVT(0).Rows - 1) : GrdVT(0).Col = 0
                If GrdVT(0).Rows > 3 And GrdVT(0).CtlText = "" Then GrdVT(0).RemoveItem(GrdVT(0).Row)
                ''rs.MoveNext()
            End While
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM quyetdinh3 WHERE maqd={0}", MaSo))
            ClearGrid(GrdVT(1), GrdVT(1).Rows - 1)
            If GrdVT(1).Rows < 3 Then GrdVT(1).Rows = 3
            rsIndex = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                GrdVT(1).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}", _
                                     rsItem("loai"), _
                                     Chr(9), _
                                     rsItem("MauSo"), _
                                     rsItem("mucdich"), _
                                     rsItem("MaSo")), 0)
                GrdVT(1).Row = ConvertToDblSafe(GrdVT(1).Rows - 1) : GrdVT(1).Col = 0
                If GrdVT(1).Rows > 3 And GrdVT(1).CtlText = "" Then GrdVT(1).RemoveItem(GrdVT(1).Row)
                ''rs.MoveNext()
            End While
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM quyetdinh4 WHERE maqd={0}", MaSo))
            ClearGrid(GrdVT(2), GrdVT(2).Rows - 1)
            If GrdVT(2).Rows < 3 Then GrdVT(2).Rows = 3
            rsIndex = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                GrdVT(2).AddItem(String.Format("{0}{1}{2}{1}{3}", _
                                     rsItem("ten"), _
                                     Chr(9), _
                                     rsItem("Trachnhiem"), _
                                     rsItem("MaSo")), 0)
                GrdVT(2).Row = ConvertToDblSafe(GrdVT(2).Rows - 1) : GrdVT(2).Col = 0
                If GrdVT(2).Rows > 3 And GrdVT(2).CtlText = "" Then GrdVT(2).RemoveItem(GrdVT(2).Row)
                ''rs.MoveNext()
            End While
            Exit Sub
        End If
        Xoatext()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdct_2.Click, _cmdct_1.Click, _cmdct_0.Click
        Dim Index As Integer = Array.IndexOf(cmdct, eventSender)
        If MaSo = 0 Then MaSo = ConvertToDblSafe(Timten("maso", Cbo.Text, "so", "quyetdinh1"))
        If MaSo = 0 Then
            Command_ClickEvent(Command(1), New EventArgs()) : MaSo = ConvertToDblSafe(Timten("maso", Cbo.Text, "so", "quyetdinh1"))
        End If
        Select Case Index
            Case 0
                tenht = txtTon(0).Text
                thongsoht = txtTon(1).Text
                ExecSQLNonQuery(String.Format("INSERT into quyetdinh2(MaSo,maqd,ten,thongso)values({0},{1},N'{2}',N'{3}')", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "quyetdinh2") + 1), _
                                    ConvertToStrSafe(MaSo), _
                                    tenht, _
                                    thongsoht))
                GrdVT(0).AddItem(String.Format("{0}{1}{2}", _
                                     tenht, _
                                     Chr(9), _
                                     thongsoht), 0)
                GrdVT(0).Row = ConvertToDblSafe(GrdVT(0).Rows - 1) : GrdVT(0).Col = 0
                If GrdVT(0).Rows > 3 And GrdVT(0).CtlText = "" Then GrdVT(0).RemoveItem(GrdVT(0).Row)
                txtTon(0).Text = ""
                txtTon(1).Text = ""
            Case 1
                LoaiHD = txtTon(2).Text
                mauhd = txtTon(3).Text
                sudung = txtTon(4).Text
                ExecSQLNonQuery(String.Format("INSERT into quyetdinh3(MaSo,maqd,loai,mauso,mucdich)values({0},{1},N'{2}',N'{3}',N'{4}')", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "quyetdinh3") + 1), _
                                    ConvertToStrSafe(MaSo), _
                                    LoaiHD, _
                                    mauhd, _
                                    sudung))
                GrdVT(1).AddItem(String.Format("{0}{1}{2}{1}{3}", _
                                     LoaiHD, _
                                     Chr(9), _
                                     mauhd, _
                                     sudung), 0)
                GrdVT(1).Row = ConvertToDblSafe(GrdVT(1).Rows - 1) : GrdVT(1).Col = 0
                If GrdVT(1).Rows > 3 And GrdVT(1).CtlText = "" Then GrdVT(1).RemoveItem(GrdVT(1).Row)
                txtTon(2).Text = ""
                txtTon(3).Text = ""
                txtTon(4).Text = ""
            Case 2
                tentn = txtTon(5).Text
                Trachnhiem = txtTon(6).Text
                ExecSQLNonQuery(String.Format("INSERT into quyetdinh4(MaSo,maqd,ten,trachnhiem)values({0},{1},N'{2}',N'{3}')", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "quyetdinh4") + 1), _
                                    ConvertToStrSafe(MaSo), _
                                    tentn, _
                                    Trachnhiem))
                GrdVT(2).AddItem(String.Format("{0}{1}{2}", _
                                     tentn, _
                                     Chr(9), _
                                     Trachnhiem), 0)
                GrdVT(2).Row = ConvertToDblSafe(GrdVT(2).Rows - 1) : GrdVT(2).Col = 0
                If GrdVT(2).Rows > 3 And GrdVT(2).CtlText = "" Then GrdVT(2).RemoveItem(GrdVT(2).Row)
                txtTon(5).Text = ""
                txtTon(6).Text = ""
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_2.Click, _Command_3.Click, _Command_4.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim chuoib = String.Empty, chuoia = String.Empty, chuoic As String = String.Empty
        Select Case Index
            Case 0
                MaSo = 0
                Xoatext()
                txt(1).Text = pTenCty
                Cbo.Focus()
            Case 1
                If Not KiemTraSoLieu() Then
                    MessageBox.Show(Ngonngu("Vui lòng nhập đầy đủ thông tin trước khi ghi", "Please enter information full before save"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
                End If
                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso)as f1 FROM quyetdinh1 WHERE so='{0}'", so))) = 0 Then
                    ExecSQLNonQuery(String.Format("INSERT into quyetdinh1(MaSo ,So ,Ngay ,Tendonvi ,SoDKKD ,Ngayad ,Ngayhl ,Giamdoc ,Denghi ,Quanly ,Cungcap)values({0},N'{1}','{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}')", _
                                        ConvertToStrSafe(Lng_MaxValue("maso", "quyetdinh1") + 1), _
                                        so, _
                                        Format(Ngay(0), Mask_DB), _
                                        tendonvi, _
                                        sodkkd, _
                                        Format(Ngay(1), Mask_DB), _
                                        Format(Ngay(2), Mask_DB), _
                                        giamdoc, _
                                        denghi, _
                                        quanly, _
                                        cungcap))
                    Int_RecsetToCbo("SELECT DISTINCT maso As F2, so As F1 FROM quyetdinh1 ORDER BY so", Cbo)
                    If Cbo.Items.Count > 0 Then Cbo.SelectedIndex = Cbo.Items.Count - 1
                Else
                    If MessageBox.Show(String.Format("Bạn có chắc là sửa thông tin quyết định số {0} - {1} này không?", so, Timten("ngay", so, "so", "quyetdinh1")), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then Exit Sub
                    ExecSQLNonQuery(String.Format("UPDATE quyetdinh1 set Ngay='N{0}' ,Tendonvi='N{1}' ,SoDKKD='N{2}',Ngayad='{3}',Ngayhl=N'{4}',Giamdoc=N'{5}',Denghi=N'{6}',Quanly=N'{7}',Cungcap=N'{8}' WHERE so=N'{9}'", _
                                        Format(Ngay(0), Mask_DB), _
                                        tendonvi, _
                                        sodkkd, _
                                        Format(Ngay(1), Mask_DB), _
                                        Format(Ngay(2), Mask_DB), _
                                        giamdoc, _
                                        denghi, _
                                        quanly, _
                                        cungcap, _
                                        so))
                End If
                Xoabien()
            Case 2
                ExecSQLNonQuery(String.Format("DELETE  FROM  quyetdinh1 WHERE maso={0}", MaSo))
                ExecSQLNonQuery(String.Format("DELETE  FROM  quyetdinh2 WHERE maqd={0}", MaSo))
                ExecSQLNonQuery(String.Format("DELETE  FROM  quyetdinh3 WHERE maqd={0}", MaSo))
                ExecSQLNonQuery(String.Format("DELETE  FROM  quyetdinh4 WHERE maqd={0}", MaSo))
                Cbo.Items.RemoveAt(ConvertToDblSafe(Cbo.SelectedIndex))
                If Cbo.Items.Count > 0 Then Cbo.SelectedIndex = 0 Else Xoatext()
            Case 3
                Me.Close()
            Case 4
                rptFrom.InitForm("quyetdinhapdunghoadontuin.rpt", "SELECT * FROM Quyetdinh1", "Quyetdinh1")
                SetRptInfo()
                With GrdVT(0)
                    .Row = 0 : .Col = 0
                    While .CtlText.Length > 0
                        If chuoia <> Nothing Then
                            chuoia = IIf(chuoia.Length = 0, String.Format("{0}{1}", chuoia, .CtlText), String.Format("{0}, {1}", chuoia, .CtlText))
                        Else
                            chuoia = .CtlText
                        End If

                        .Col = 1
                        If chuoib <> Nothing Then
                            chuoib = IIf(chuoib.Length = 0, String.Format("{0}{1}", chuoib, .CtlText), String.Format("{0}, {1}", chuoib, .CtlText))
                        Else
                            chuoib = .CtlText
                        End If

                        .Col = 0
                        .Row = (.Row + 1)
                    End While
                End With
                If chuoia.Length > 0 Then rptFrom.SetFormulas("HTTB", String.Format("'Hệ thống thiết bị: {0}'", chuoia))
                If chuoib.Length > 0 Then rptFrom.SetFormulas("TS", String.Format("'Thông số kỹ thuật: {0}'", chuoib))
                chuoia = "" : chuoib = ""
                With GrdVT(2)
                    .Row = 0 : .Col = 0
                    While .CtlText.Length > 0
                        chuoia = .CtlText
                        .Col = 1
                        chuoib = .CtlText
                        .Col = 0
                        .Row = (.Row + 1)
                        rptFrom.SetFormulas("BoPhan" & CStr(.Row), String.Format("'- {0}: {1}'", _
                                                                       chuoia, _
                                                                       chuoib))
                    End While
                End With
                chuoia = "" : chuoib = "" : chuoic = ""
                With GrdVT(1)
                    .Row = 0 : .Col = 0
                    While .CtlText.Length > 0
                        chuoia = .CtlText
                        .Col = 1
                        chuoib = .CtlText
                        .Col = 2
                        chuoic = .CtlText
                        .Col = 0
                        .Row = (.Row + 1)
                        rptFrom.SetFormulas("Loai" & CStr(.Row), String.Format("'{0}'", chuoia))
                        rptFrom.SetFormulas("MauSo" & CStr(.Row), String.Format("'Mẫu số: {0}'", chuoib))
                        rptFrom.SetFormulas("SuDung" & CStr(.Row), String.Format("'Mục đích: {0}'", chuoic))
                    End While
                End With
                rptFrom.SetFormulas("So", String.Format("'{0}'", Cbo.Text))
                rptFrom.ReportTitle = Me.Text
                InBaoCaoRPT()
        End Select
    End Sub
    Sub Xoatext()
        Cbo.Text = ""
        txt(1).Text = ""
        txt(2).Text = ""
        txt(3).Text = ""
        txt(4).Text = ""
        txt(5).Text = ""
        txt(6).Text = ""
        ClearGrid(GrdVT(0), GrdVT(0).Rows - 1)
        GrdVT(0).Rows = 3
        ClearGrid(GrdVT(1), GrdVT(1).Rows - 1)
        GrdVT(1).Rows = 3
        ClearGrid(GrdVT(2), GrdVT(2).Rows - 1)
        GrdVT(2).Rows = 3
    End Sub
    Function KiemTraSoLieu() As Boolean
        Dim result As Boolean = False
        Try
            Ngay(0) = ConvertToDateSafe(MedNgay(0).Text)
            so = Cbo.Text
            tendonvi = txt(1).Text
            Ngay(1) = ConvertToDateSafe(MedNgay(1).Text)
            Ngay(2) = ConvertToDateSafe(MedNgay(2).Text)
            sodkkd = txt(2).Text
            giamdoc = txt(3).Text
            denghi = txt(4).Text
            quanly = txt(5).Text
            cungcap = txt(6).Text
            result = True
        Catch
        End Try
        Return result
    End Function
    Sub Xoabien()
        so = ""
        tendonvi = ""
        sodkkd = ""
        giamdoc = ""
        denghi = ""
        quanly = ""
        cungcap = ""
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmQuyetdinhapdunghoadontuin_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmQuyetdinhapdunghoadontuin_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        ColumnSetUp(GrdVT(0), 0, 5750, 0)
        ColumnSetUp(GrdVT(0), 1, 8695, 0)
        ColumnSetUp(GrdVT(0), 2, 1, 0)
        ColumnSetUp(GrdVT(1), 0, 2870, 0)
        ColumnSetUp(GrdVT(1), 1, 2870, 0)
        ColumnSetUp(GrdVT(1), 2, 8695, 0)
        ColumnSetUp(GrdVT(1), 3, 1, 0)
        ColumnSetUp(GrdVT(2), 0, 5750, 0)
        ColumnSetUp(GrdVT(2), 1, 8695, 0)
        ColumnSetUp(GrdVT(2), 2, 1, 0)
        InitDateVars(MedNgay(0), Ngay(0))
        InitDateVars(MedNgay(1), Ngay(1))
        InitDateVars(MedNgay(2), Ngay(2))
        Int_RecsetToCbo("SELECT DISTINCT maso As F2, so As F1 FROM quyetdinh1 ORDER BY so", Cbo)
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _GrdVT_2.DoubleClick, _GrdVT_1.DoubleClick, _GrdVT_0.DoubleClick
        Dim Index As Integer = Array.IndexOf(GrdVT, eventSender)
        With GrdVT(Index)
            Select Case Index
                Case 0
                    .Col = 0
                    txtTon(0).Text = .CtlText
                    .Col = 1
                    txtTon(1).Text = .CtlText
                    .Col = 2
                    ExecSQLNonQuery(String.Format("DELETE  FROM quyetdinh2 WHERE maso={0}", .CtlText))
                    .RemoveItem(.Row)
                    If .Rows < 3 Then .Rows = 3
                Case 1
                    .Col = 0
                    txtTon(2).Text = .CtlText
                    .Col = 1
                    txtTon(3).Text = .CtlText
                    .Col = 2
                    txtTon(4).Text = .CtlText
                    .Col = 3
                    ExecSQLNonQuery(String.Format("DELETE  FROM quyetdinh3 WHERE maso={0}", .CtlText))
                    .RemoveItem(.Row)
                    If .Rows < 3 Then .Rows = 3
                Case 2
                    .Col = 0
                    txtTon(5).Text = .CtlText
                    .Col = 1
                    txtTon(6).Text = .CtlText
                    .Col = 2
                    ExecSQLNonQuery(String.Format("DELETE  FROM quyetdinh4 WHERE maso={0}", .CtlText))
                    .RemoveItem(.Row)
                    If .Rows < 3 Then .Rows = 3
            End Select
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Leave, _MedNgay_1.Leave, _MedNgay_2.Leave
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        If Index = 0 Then
            Ngay(0) = ConvertToDateSafe(MedNgay(0).Text)
            MedNgay(1).Text = FormatDate(Ngay(0).AddDays(5))
            MedNgay(2).Text = FormatDate(Ngay(0).AddDays(5))
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_6.Enter, _txt_5.Enter, _txt_4.Enter, _txt_1.Enter, _txt_3.Enter, _txt_2.Enter
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        txt(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_5.Enter, _txtTon_6.Enter, _txtTon_4.Enter, _txtTon_2.Enter, _txtTon_3.Enter, _txtTon_1.Enter, _txtTon_0.Enter
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        txtTon(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_5.KeyPress, _txtTon_6.KeyPress, _txtTon_4.KeyPress, _txtTon_2.KeyPress, _txtTon_3.KeyPress, _txtTon_1.KeyPress, _txtTon_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        If Index = 3 And KeyAscii = ConvertToDblSafe(Keys.Return) Then
            txtTon(Index).Text = frmSLHoaDon.Chonmauso(txtTon(3).Text)
            txtTon(Index - 1).Text = ConvertToStrSafe(GetSelectValue(String.Format("SELECT ten as f1 FROM loaihoadon WHERE sohieu='{0}'", txtTon(Index).Text)))
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
    Private Sub FrmQuyetdinhapdunghoadontuin_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
