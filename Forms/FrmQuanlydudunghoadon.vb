Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmQuanlydudunghoadon
    Dim DaiDien, nguoi, so, nguoi1, phuongphap As String
    Dim loai, gio As Integer
    Dim Ngay, ngay1 As Date
    Dim tuso, mau, ten, KyHieu, denso As String
    Dim soluong As Double
    Dim mathongtin, lien, machitiet As Integer
    Dim GhiChu As String = String.Empty

    Private Sub Cbo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo.SelectedIndexChanged
        Hienthi()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        Try
            mathongtin = ConvertToDblSafe(Timten("maso", Cbo.Text, "so", "thongtinhuy"))
            If mathongtin = 0 Then
                Command_ClickEvent(Command(1), New EventArgs())
                mathongtin = ConvertToDblSafe(Timten("maso", Cbo.Text, "so", "thongtinhuy"))
            End If
            ten = txtTon(0).Text
            mau = txtTon(1).Text
            KyHieu = txtTon(2).Text
            tuso = txtTon(3).Text
            denso = txtTon(4).Text
            soluong = ConvertToDblSafe(txtTon(5).Text)
            GhiChu = txtTon(7).Text
            If Opt(0).Checked Then
                lien = 0
                GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                                  ten, _
                                  Chr(9), _
                                  mau, _
                                  KyHieu, _
                                  tuso, _
                                  denso, _
                                  ConvertToStrSafe(soluong), _
                                  GhiChu, _
                                  ConvertToStrSafe(Lng_MaxValue("maso", "chitiethuy") + 1)), 0)
            Else
                lien = ConvertToDblSafe(txtTon(6).Text)
                GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                                  ten, _
                                  Chr(9), _
                                  mau, _
                                  KyHieu, _
                                  tuso, _
                                  denso, _
                                  ConvertToStrSafe(soluong), _
                                  ConvertToStrSafe(lien), _
                                  GhiChu, _
                                  ConvertToStrSafe(Lng_MaxValue("maso", "chitiethuy") + 1)), 0)
            End If
            ExecSQLNonQuery(String.Format("INSERT INTO chitiethuy(maso,mathongtin,ten,mau,kyhieu,tuso,denso,soluong,lien,ghichu)values({0},{1},N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',{7},{8},N'{9}')", _
                                Lng_MaxValue("maso", "chitiethuy") + 1, _
                                ConvertToStrSafe(mathongtin), _
                                ten, _
                                mau, _
                                KyHieu, _
                                tuso, _
                                denso, _
                                ConvertToStrSafe(soluong), _
                                ConvertToStrSafe(lien), _
                                GhiChu))
            GrdVT.Row = ConvertToDblSafe(GrdVT.Rows - 1) : GrdVT.Col = 0
            If GrdVT.Rows > 11 And GrdVT.CtlText = "" Then GrdVT.RemoveItem(GrdVT.Row)
            txtTon(0).Text = ""
            txtTon(1).Text = ""
            txtTon(2).Text = ""
            txtTon(3).Text = "0"
            txtTon(4).Text = "0"
            txtTon(5).Text = "0"
            txtTon(6).Text = "0"
            txtTon(7).Text = ""
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
                    MessageBox.Show(Ngonngu("Vui lòng nhập đầy đủ thông tin trước khi ghi", "Please enter information full before save"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) as f1 FROM thongtinhuy WHERE so='{0}'", so))) = 0 Then
                    ExecSQLNonQuery(String.Format("INSERT into thongtinhuy (MaSo,loaihuy,So,Ngay,Thongbaophathien,Nhanthongbao,Daidien,Gio,ngay1,Phuongphaplydo) values({0},{1},N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',{7},N'{8}',N'{9}')", _
                                        Lng_MaxValue("maso", "thongtinhuy") + 1, _
                                        ConvertToStrSafe(loai), _
                                        so, _
                                        Format(CDate(Ngay), Mask_DB), _
                                        nguoi, _
                                        nguoi1, _
                                        DaiDien, _
                                        ConvertToStrSafe(gio), _
                                        Format(ngay1, Mask_DB), _
                                        phuongphap))
                Else
                    If MessageBox.Show(String.Format("Bạn có chắc là sửa thông tin {0} - {1} này không?", so, Timten("ngay", so, "so", "thongtinhuy")), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then Exit Sub
                    ExecSQLNonQuery(String.Format("UPDATE thongtinhuy set ngay='{0}',thongbaophathien='{1}',nhanthongbao='{2}',daidien='{3}',gio={4},ngay1='{5}',phuongphaplydo='{6}' WHERE so='{7}'", _
                                        Format(CDate(Ngay), Mask_DB), _
                                        nguoi, _
                                        nguoi1, _
                                        DaiDien, _
                                        ConvertToStrSafe(gio), _
                                        Format(ngay1, Mask_DB), _
                                        phuongphap, _
                                        so))
                End If
            Case 2
                If MessageBox.Show(String.Format("Bạn có chắc là xoá thông tin {0} - {1} này không?", so, Timten("ngay", so, "so", "thongtinhuy")), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then Exit Sub
                ExecSQLNonQuery(String.Format("DELETE  FROM chitiethuy WHERE mathongtin={0}", mathongtin))
                ExecSQLNonQuery(String.Format("DELETE  FROM thongtinhuy WHERE maso={0}", mathongtin))
                If Opt(0).Checked Then Opt_CheckedChanged(Opt(0), New EventArgs()) Else Opt_CheckedChanged(Opt(1), New EventArgs())
            Case 3
                Me.Close()
            Case 4
                If Opt(0).Checked Then
                    rptFrom.InitForm("huyhoadon.rpt", _
                        "SELECT Thongtinhuy.Nhanthongbao, Thongtinhuy.Thongbaophathien, Thongtinhuy.Phuongphaplydo, Thongtinhuy.Gio, Thongtinhuy.ngay1, Chitiethuy.ten, Chitiethuy.mau, Chitiethuy.Kyhieu, Chitiethuy.Tuso, Chitiethuy.Denso, Chitiethuy.Soluong, Thongtinhuy.Ngay, Thongtinhuy.Daidien, Thongtinhuy.So FROM   Chitiethuy Chitiethuy LEFT OUTER JOIN Thongtinhuy Thongtinhuy ON Chitiethuy.Mathongtin=Thongtinhuy.MaSo", _
                        "Thongtinhuy")

                    SetRptInfo()
                    rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
                    rptFrom.SetFormulas("So", String.Format("'{0}'", Cbo.Text))

                    rptFrom.ReportTitle = Me.Text
                    InBaoCaoRPT()
                Else
                    rptFrom.InitForm("matchayhong.rpt", _
                        " SELECT Thongtinhuy.Thongbaophathien, Thongtinhuy.Gio, Thongtinhuy.ngay1, Chitiethuy.ten, Chitiethuy.mau, Chitiethuy.Kyhieu, Chitiethuy.Tuso, Chitiethuy.Denso, Chitiethuy.Soluong, Thongtinhuy.Ngay, Thongtinhuy.Daidien, Thongtinhuy.So, Chitiethuy.Lien, Chitiethuy.ghichu, Thongtinhuy.Nhanthongbao FROM  Chitiethuy Chitiethuy LEFT OUTER JOIN Thongtinhuy Thongtinhuy ON Chitiethuy.Mathongtin=Thongtinhuy.MaSo", _
                        "Thongtinhuy")

                    SetRptInfo()
                    rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
                    rptFrom.SetFormulas("So", String.Format("'{0}'", Cbo.Text))
                    rptFrom.ReportTitle = Me.Text
                    InBaoCaoRPT()
                End If
        End Select
    End Sub
    Function KiemTraSoLieu() As Boolean
        Dim result As Boolean = False
        Try
            so = Cbo.Text
            nguoi = txt(1).Text
            nguoi1 = txt(2).Text
            DaiDien = txt(3).Text
            phuongphap = txt(5).Text
            loai = IIf(Opt(0).Checked, 0, 1)
            gio = IIf(ConvertToDblSafe(txt(4).Text) <> 0, ConvertToDblSafe(Format(ConvertToDblSafe(txt(4).Text), Mask_0)), 0)
            Ngay = ConvertToDateSafe(MedNgay(0).Text)
            ngay1 = ConvertToDateSafe(MedNgay(1).Text)
            result = True
        Catch
        End Try
        Return result
    End Function
    Sub Xoahienthi()
        Cbo.Text = ""
        txt(1).Text = ""
        txt(2).Text = ""
        txt(3).Text = ""
        txt(5).Text = ""
        txt(4).Text = "0"
        txtTon(0).Text = ""
        txtTon(1).Text = ""
        txtTon(2).Text = ""
        txtTon(3).Text = "0"
        txtTon(4).Text = "0"
        txtTon(5).Text = "0"
        txtTon(6).Text = "0"
        txtTon(7).Text = ""
        ClearGrid(GrdVT, GrdVT.Rows - 1)
        GrdVT.Rows = 11
    End Sub
    Sub Hienthi()
        Dim rs As DataTable
        Try
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM thongtinhuy WHERE so='{0}'", Cbo.Text))
            Dim rsItem As DataRow = rs.Rows(0)
            txt(1).Text = rsItem("thongbaophathien")
            txt(2).Text = rsItem("nhanthongbao")
            txt(3).Text = rsItem("DaiDien")
            txt(5).Text = rsItem("phuongphaplydo")
            txt(4).Text = rsItem("gio")
            MedNgay(0).Text = rsItem("Ngay")
            MedNgay(1).Text = rsItem("ngay1")
            mathongtin = rsItem("MaSo")
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM chitiethuy WHERE mathongtin={0}", mathongtin))
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
                lien = rsItem("lien")
                GhiChu = rsItem("GhiChu")
                If Opt(0).Checked Then
                    GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                                      ten, _
                                      Chr(9), _
                                      mau, _
                                      KyHieu, _
                                      tuso, _
                                      denso, _
                                      ConvertToStrSafe(soluong), _
                                      GhiChu, _
                                      ConvertToStrSafe(machitiet)), 0)
                Else
                    GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                                      ten, _
                                      Chr(9), _
                                      mau, _
                                      KyHieu, _
                                      tuso, _
                                      denso, _
                                      ConvertToStrSafe(soluong), _
                                      ConvertToStrSafe(lien), _
                                      GhiChu, _
                                      ConvertToStrSafe(machitiet)), 0)
                End If
                GrdVT.Row = ConvertToDblSafe(GrdVT.Rows - 1)
                GrdVT.Col = 0
                ' If GrdVT.Rows > 11 And GrdVT.CtlText = "" Then GrdVT.RemoveItem(GrdVT.Row)
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
    Private Sub FrmQuanlydudunghoadon_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub FrmQuanlydudunghoadon_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

            ColumnSetUp(GrdVT, 0, 2870, 2)
            ColumnSetUp(GrdVT, 1, 1790, 2)
            ColumnSetUp(GrdVT, 2, 1790, 2)
            ColumnSetUp(GrdVT, 3, 1790, 4)
            ColumnSetUp(GrdVT, 4, 1790, 4)
            ColumnSetUp(GrdVT, 5, 1430, 4)
            ColumnSetUp(GrdVT, 6, 1430, 2)
            ColumnSetUp(GrdVT, 7, 1520, 2)
            Opt_CheckedChanged(Opt(0), New EventArgs())
            InitDateVars(MedNgay(0), Ngay)
            InitDateVars(MedNgay(1), ngay1)
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
            If Opt(0).Checked Then
                txtTon(7).Text = .CtlText
                .Col = 7
            Else
                txtTon(6).Text = .CtlText
                .Col = 7
                txtTon(7).Text = .CtlText
                .Col = 8
            End If
            ExecSQLNonQuery(String.Format("DELETE  FROM chitiethuy WHERE maso ={0}", .CtlText))
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
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Enter, _MedNgay_1.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean
    Private Sub Opt_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Opt_1.CheckedChanged, _Opt_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(Opt, eventSender)
            Xoahienthi()
            If Index = 1 Then
                Label(17).Text = Ngonngu("Hoá đơn mất cháy hỏng", "Loss, fire, failure Invoice")
                Me.Text = Ngonngu("Hoá đơn mất cháy hỏng", "Loss, fire, failure Invoice")
                GrdVT.Cols = 9
                ColumnSetUp(GrdVT, 6, 1430, 1)
                ColumnSetUp(GrdVT, 7, 1520, 0)
                ColumnSetUp(GrdVT, 8, 1, 0)
                txtTon(6).Enabled = True
                ' Label(7).Left = 1308
                'Label(7).Width = 1575
                'txtTon(7).Left = 1308
                'txtTon(7).Width = 1550
                Label(15).Text = Ngonngu("Đối tượng phát hiện", "Object detection")
                Label(16).Text = Ngonngu("Lý do mất cháy hỏng", "Loss, fire, failure Reasons")
                Label(8).Visible = False
                txt(5).Visible = False
                'Frame1(0).Height = 1000
                'Frame1(1).Top = 3360
                'Command(0).Top = 7800
                'Command(1).Top = 7800
                'Command(2).Top = 7800
                'Command(3).Top = 7800
                'Command(4).Top = 7800
                'Me.Height = 1024
            Else
                Label(17).Text = Ngonngu("Hoá đơn huỷ", "Canceled Invoice")
                Me.Text = Ngonngu("Hoá đơn huỷ", "Canceled Invoice")
                GrdVT.Cols = 8
                ColumnSetUp(GrdVT, 6, 2950, 0)
                ColumnSetUp(GrdVT, 7, 1, 0)
                txtTon(6).Enabled = False
                Label(7).Left = Label(6).Left
                Label(7).Width += Label(6).Width
                txtTon(7).Left = txtTon(6).Left
                txtTon(7).Width += txtTon(6).Width
                Label(15).Text = Ngonngu("Đối tượng thông báo", "Subjects reported")
                Label(16).Text = Ngonngu("Đối tượng nhận thông báo", "Inform the recipient")
                Label(8).Visible = True
                txt(5).Visible = True
                ' Frame1(0).Height = 1000
                ' Frame1(1).Top = 3720
                ' Command(0).Top = 8160
                'Command(1).Top = 8160
                'Command(2).Top = 8160
                'Command(3).Top = 8160
                'Command(4).Top = 8160
                'Me.Height = 1024
            End If
            Int_RecsetToCbo(String.Format("SELECT DISTINCT maso As F2, so As F1 FROM Thongtinhuy WHERE loaihuy={0} ORDER BY so", (IIf(Opt(0).Checked, 0, 1))), Cbo)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_5.Enter, _txt_4.Enter, _txt_3.Enter, _txt_2.Enter, _txt_1.Enter
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        txt(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_5.Leave, _txt_4.Leave, _txt_3.Leave, _txt_2.Leave, _txt_1.Leave
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        If Index = 4 Then
            If ConvertToDblSafe(txt(Index).Text) > 23 Then
                txt(Index).Text = ConvertToStrSafe(23)
            ElseIf ConvertToDblSafe(txt(Index).Text) < 0 Then
                txt(Index).Text = "0"
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_7.Enter, _txtTon_0.Enter, _txtTon_1.Enter, _txtTon_2.Enter, _txtTon_3.Enter, _txtTon_4.Enter, _txtTon_5.Enter, _txtTon_6.Enter
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        txtTon(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_7.KeyPress, _txtTon_0.KeyPress, _txtTon_1.KeyPress, _txtTon_2.KeyPress, _txtTon_3.KeyPress, _txtTon_4.KeyPress, _txtTon_5.KeyPress, _txtTon_6.KeyPress
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
    Private Sub txtTon_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_7.Leave, _txtTon_0.Leave, _txtTon_1.Leave, _txtTon_2.Leave, _txtTon_3.Leave, _txtTon_4.Leave, _txtTon_5.Leave, _txtTon_6.Leave
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        If Index = 3 Or Index = 4 Then
            If ConvertToDblSafe(txtTon(4).Text) > ConvertToDblSafe(txtTon(3).Text) Then
                txtTon(5).Text = Format(ConvertToDblSafe(txtTon(4).Text) - ConvertToDblSafe(txtTon(3).Text), Mask_0)
            Else
                txtTon(5).Text = "0"
            End If
        ElseIf Index = 5 Or Index = 6 Then
            txtTon(Index).Text = Format(ConvertToDblSafe(txtTon(Index).Text), Mask_0)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmQuanlydudunghoadon_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
