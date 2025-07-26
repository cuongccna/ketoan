Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmThongbaophathanhhoadon
    Dim tiepnhan, so, DaiDien As String
    Dim Ngay As Date
    Dim mathongtin, machitiet As Integer
    Dim tuso, mau, ten, KyHieu, denso As String
    Dim soluong As Double
    Dim ngaysd, ngayin As Date
    Dim MST, tenin, soin As String
    'Private Sub Cbo_SelectionChangeCommitted(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Cbo.SelectionChangeCommitted
    '    Hienthi()
    'End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmThongbaophathanhhoadon_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub FrmThongbaophathanhhoadon_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ColumnSetUp(GrdVT, 0, 2030, 2)
            ColumnSetUp(GrdVT, 1, 1310, 2)
            ColumnSetUp(GrdVT, 2, 950, 2)
            ColumnSetUp(GrdVT, 3, 1550, 4)
            ColumnSetUp(GrdVT, 4, 1550, 4)
            ColumnSetUp(GrdVT, 5, 830, 4)
            ColumnSetUp(GrdVT, 6, 1070, 2)
            ColumnSetUp(GrdVT, 7, 1670, 2)
            ColumnSetUp(GrdVT, 8, 950, 2)
            ColumnSetUp(GrdVT, 9, 1550, 2)
            ColumnSetUp(GrdVT, 10, 920, 2)
            ColumnSetUp(GrdVT, 11, 1, 2)
            InitDateVars(MedNgay(0), Ngay)
            InitDateVars(MedNgay(1), ngaysd)
            InitDateVars(MedNgay(2), ngayin)
            Int_RecsetToCbo("SELECT DISTINCT maso As F2, so As F1 FROM Thongtinphathanh ORDER BY so", Cbo)
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
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        Try
            mathongtin = ConvertToDblSafe(Timten("maso", Cbo.Text, "so", "thongtinphathanh"))
            If mathongtin = 0 Then
                Command_ClickEvent(Command(1), New EventArgs())
                mathongtin = ConvertToDblSafe(Timten("maso", Cbo.Text, "so", "thongtinphathanh"))
            End If
            ten = txtTon(0).Text
            mau = txtTon(1).Text
            KyHieu = txtTon(2).Text
            tuso = txtTon(3).Text
            denso = txtTon(4).Text
            soluong = ConvertToDblSafe(txtTon(5).Text)
            ngaysd = ConvertToDateSafe(MedNgay(1).Text)
            tenin = txtTon(6).Text
            MST = txtTon(7).Text
            soin = txtTon(8).Text
            ngayin = ConvertToDateSafe(MedNgay(2).Text)
            GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}", _
                              ten, _
                              Chr(9), _
                              mau, _
                              KyHieu, _
                              tuso, _
                              denso, _
                              Format(soluong, Mask_0), _
                              FormatDate(ngaysd), _
                              tenin, _
                              MST, _
                              soin, _
                              FormatDate(ngayin), _
                              ConvertToStrSafe(Lng_MaxValue("maso", "chitietphathanh") + 1)), 0)
            ExecSQLNonQuery(String.Format("INSERT into chitietphathanh(maso,mathongtin,ten,mau,kyhieu,tuso,denso,soluong,ngaysudung,tenin,mst,soin,ngayin)values({0},{1},N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',{7},'{8}',N'{9}',N'{10}',N'{11}',N'{12}')", _
                                Lng_MaxValue("maso", "chitietphathanh") + 1, _
                                ConvertToStrSafe(mathongtin), _
                                ten, _
                                mau, _
                                KyHieu, _
                                tuso, _
                                denso, _
                                ConvertToStrSafe(soluong), _
                                Format(ngaysd, Mask_DB), _
                                tenin, _
                                MST, _
                                soin, _
                                Format(ngayin, Mask_DB)))
            GrdVT.Row = ConvertToDblSafe(GrdVT.Rows - 1) : GrdVT.Col = 0
            If GrdVT.Rows > 11 And GrdVT.CtlText = "" Then GrdVT.RemoveItem(GrdVT.Row)
            txtTon(0).Text = ""
            txtTon(1).Text = ""
            txtTon(2).Text = ""
            txtTon(3).Text = ""
            txtTon(4).Text = ""
            txtTon(5).Text = "0"
            txtTon(6).Text = ""
            txtTon(7).Text = ""
            txtTon(8).Text = ""
        Catch
            MessageBox.Show(Ngonngu("Vui lòng nhập đầy đủ thông tin trước khi ghi", "Please enter information full before save"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_2.Click, _Command_3.Click, _Command_4.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                Xoahienthi()
                Cbo.Focus()
            Case 1
                If Not KiemTraSoLieu() Then
                    MessageBox.Show(Ngonngu("Vui lòng nhập đầy đủ thông tin trước khi ghi", "Please enter information full before save"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
                End If
                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) as f1 FROM thongtinphathanh WHERE so='{0}'", so))) = 0 Then
                    ExecSQLNonQuery(String.Format("INSERT into thongtinphathanh(MaSo,So,Ngay,Tiepnhan,Daidien) values({0},N'{1}','{2}',N'{3}',N'{4}')", Lng_MaxValue("maso", "thongtinphathanh") + 1, so, Format(CDate(Ngay), Mask_DB), tiepnhan, DaiDien))
                Else
                    If MessageBox.Show(String.Format("Bạn có chắc là sửa thông tin {0} - {1} này không?", so, Timten("ngay", so, "so", "thongtinphathanh")), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then Exit Sub
                    ExecSQLNonQuery(String.Format("UPDATE thongtinphathanh set ngay='{0}',tiepnhan=N'{1}',daidien=N'{2}' WHERE so=N'{3}'", Format(CDate(Ngay), Mask_DB), tiepnhan, DaiDien, so))
                End If
            Case 2
                If MessageBox.Show(String.Format("Bạn có chắc là xoá thông tin {0} - {1} này không?", so, Timten("ngay", so, "so", "thongtinphathanh")), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then Exit Sub
                ExecSQLNonQuery(String.Format("DELETE FROM chitietphathanh WHERE mathongtin={0}", mathongtin))
                ExecSQLNonQuery(String.Format("DELETE FROM thongtinphathanh WHERE maso={0}", mathongtin))
                If Cbo.Items.Count > 0 Then Cbo.Items.RemoveAt(ConvertToDblSafe(Cbo.SelectedIndex))
                If Cbo.Items.Count > 0 Then Cbo.SelectedIndex = 0
            Case 3
                Me.Close()
            Case 4
                'rptFrom.InitForm("ThongbaophathanhR.rpt", _
                '    New String() {"SELECT * FROM chitietphathanh", "SELECT * FROM thongtinphathanh"}, _
                '    New String() {"chitietphathanh", "thongtinphathanh"})

                SetRptInfo()
                rptFrom.SetFormulas("diachi", String.Format("'{0}'", frmMain._LbCty_2.Text))
                rptFrom.SetFormulas("dienthoai", String.Format("'{0}'", frmMain._LbCty_3.Text))
                rptFrom.SetFormulas("So", String.Format("'{0}'", Cbo.Text))
                rptFrom.ReportTitle = Me.Text
                InBaoCaoRPT()
        End Select
    End Sub
    Function KiemTraSoLieu() As Boolean
        Dim result As Boolean = False
        Try
            so = Cbo.Text
            Ngay = ConvertToDateSafe(MedNgay(0).Text)
            tiepnhan = txt(1).Text
            DaiDien = txt(2).Text
            result = True
        Catch
        End Try
        Return result
    End Function
    Sub Xoahienthi()
        Cbo.Text = ""
        txt(1).Text = ""
        txt(2).Text = ""
        txtTon(0).Text = ""
        txtTon(1).Text = ""
        txtTon(2).Text = ""
        txtTon(3).Text = ""
        txtTon(4).Text = ""
        txtTon(5).Text = "0"
        txtTon(6).Text = ""
        txtTon(7).Text = ""
        txtTon(8).Text = ""
        ClearGrid(GrdVT, GrdVT.Rows - 1)
        GrdVT.Rows = 11
    End Sub
    Sub Hienthi()
        Dim rs As DataTable
        Try
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM thongtinphathanh WHERE so='{0}'", Cbo.Text))
            Dim rsItem As DataRow = rs.Rows(0)
            txt(1).Text = rsItem("tiepnhan")
            txt(2).Text = rsItem("DaiDien")
            mathongtin = rsItem("MaSo")
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM chitietphathanh WHERE mathongtin={0}", mathongtin))
            ClearGrid(GrdVT, GrdVT.Rows - 1)
            GrdVT.Rows = 11
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                rsItem = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                machitiet = rsItem("MaSo")
                ten = rsItem("ten")
                mau = rsItem("mau")
                KyHieu = rsItem("KyHieu")
                tuso = rsItem("tuso")
                denso = rsItem("denso")
                soluong = rsItem("soluong")
                ngaysd = rsItem("ngaysudung")
                tenin = rsItem("tenin")
                MST = rsItem("MST")
                soin = rsItem("soin")
                ngayin = rsItem("ngayin")
                GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}", _
                                  ten, _
                                  Chr(9), _
                                  mau, _
                                  KyHieu, _
                                  tuso, _
                                  denso, _
                                  ConvertToStrSafe(soluong), _
                                  FormatDate(ngaysd), _
                                  tenin, _
                                  MST, _
                                  soin, _
                                  FormatDate(ngayin), _
                                  ConvertToStrSafe(machitiet)), 0)
                GrdVT.Row = ConvertToDblSafe(GrdVT.Rows - 1)
                GrdVT.Col = 0
                'If GrdVT.Rows > 11 And GrdVT.CtlText = "" Then GrdVT.RemoveItem(GrdVT.Row)
                ''rs.MoveNext()
            End While
        Catch
            Xoahienthi()
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdVT.DoubleClick
        With GrdVT
            .Col = 0
            txtTon(0).Text = .CtlText
            .Col = 1
            txtTon(1).Text = .CtlText
            .Col = 2
            txtTon(2).Text = .CtlText
            .Col = 3
            txtTon(3).Text = .CtlText
            .Col = 4
            txtTon(4).Text = .CtlText
            .Col = 5
            txtTon(5).Text = .CtlText
            .Col = 6
            MedNgay(1).Text = .CtlText
            .Col = 7
            txtTon(6).Text = .CtlText
            .Col = 8
            txtTon(7).Text = .CtlText
            .Col = 9
            txtTon(8).Text = .CtlText
            .Col = 10
            MedNgay(2).Text = .CtlText
            .Col = 11
            ExecSQLNonQuery(String.Format("DELETE FROM chitietphathanh WHERE maso ={0}", .CtlText))
            GrdVT.RemoveItem(.Row)
            If GrdVT.Rows < 11 Then GrdVT.Rows = 11
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_1.Enter, _MedNgay_2.Enter, _MedNgay_0.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_2.Enter, _txt_1.Enter
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        txt(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_0.KeyPress, _txtTon_1.KeyPress, _txtTon_2.KeyPress, _txtTon_3.KeyPress, _txtTon_4.KeyPress, _txtTon_5.KeyPress, _txtTon_6.KeyPress, _txtTon_7.KeyPress, _txtTon_8.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Dim ten As String = String.Empty
        If KeyAscii = ConvertToDblSafe(Keys.Return) And Index = 2 Then
            txtTon(2).Text = frmSLHoaDon.Chonkyhieu(txtTon(2).Text)
            txtTon(1).Text = ConvertToStrSafe(GetSelectValue(String.Format("SELECT loaihoadon.sohieu as f1, loaihoadon.ten as f2 FROM loaihoadon inner join slhoadon on loaihoadon.maso=slhoadon.loaihd WHERE slhoadon.kyhieu='{0}'", txtTon(2).Text), ten))
            txtTon(0).Text = ten
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
    Private Sub txtTon_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_0.Leave, _txtTon_1.Leave, _txtTon_2.Leave, _txtTon_3.Leave, _txtTon_4.Leave, _txtTon_5.Leave, _txtTon_6.Leave, _txtTon_7.Leave, _txtTon_8.Leave
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        If Index = 3 Or Index = 4 Then
            If ConvertToDblSafe(txtTon(4).Text) > ConvertToDblSafe(txtTon(3).Text) Then
                txtTon(5).Text = Format(ConvertToDblSafe(txtTon(4).Text) - ConvertToDblSafe(txtTon(3).Text), Mask_0)
            Else
                txtTon(5).Text = "0"
            End If
        ElseIf Index = 5 Then
            txtTon(Index).Text = Format(ConvertToDblSafe(txtTon(Index).Text), Mask_0)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_0.Enter, _txtTon_1.Enter, _txtTon_2.Enter, _txtTon_3.Enter, _txtTon_4.Enter, _txtTon_5.Enter, _txtTon_6.Enter, _txtTon_7.Enter, _txtTon_8.Enter
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        txtTon(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmThongbaophathanhhoadon_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub Cbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo.SelectedIndexChanged
        Hienthi()
    End Sub
End Class
