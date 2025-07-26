Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class Frm154Dauky
    Private _tp As ClsVattu = Nothing
    Property tp() As ClsVattu
        Get
            If _tp Is Nothing Then
                _tp = New ClsVattu()
            End If
            Return _tp
        End Get
        Set(ByVal Value As ClsVattu)
            _tp = Value
        End Set
    End Property
    Dim mkho As Integer
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_2.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0 : Me.Close()
            Case 2
                tp.InitVattuSohieu(txtTon(0).Text)
                With GrdVT
                    .Col = 0
                    If .CtlText.length = 0 Then Exit Sub
                    If .CtlText = tp.sohieu Then
                        .RemoveItem(.Row)
                        ExecSQLNonQuery(String.Format("UPDATE thanhphamdd set soluong=0,cpnvl=0,cpnc=0,cpsxc=0,phantram=0 WHERE thang=0 and matp={0} and makhonvl={1}", _
                                            tp.MaSo, _
                                            ConvertToStrSafe(mkho)))
                        Suadauky()
                        tongtien()
                        For i As Integer = 2 To 8
                            txtTon(i).Text = "0"
                        Next
                        txtTon(0).Focus()
                        Exit Sub
                    End If
                    For i As Integer = 0 To .Rows - 1
                        .Row = i
                        If .CtlText.length = 0 Then Exit For
                        If .CtlText = tp.sohieu Then
                            .RemoveItem(ConvertToDblSafe(i))
                            ExecSQLNonQuery(String.Format("UPDATE thanhphamdd set soluong=0,cpnvl=0,cpnc=0,cpsxc=0,phantram=0 WHERE thang=0 and matp={0} and makhonvl={1}", _
                                                tp.MaSo, _
                                                ConvertToStrSafe(mkho)))
                            Suadauky()
                            tongtien()
                            For j As Integer = 2 To 8
                                txtTon(j).Text = "0"
                            Next
                            txtTon(0).Focus()
                            Exit Sub
                        End If
                    Next
                End With
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Frm154Dauky_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ColumnSetUp(GrdVT, 0, 940, 2)
            ColumnSetUp(GrdVT, 1, 2990, 0)
            ColumnSetUp(GrdVT, 2, 1070, 4)
            ColumnSetUp(GrdVT, 3, 1430, 4)
            ColumnSetUp(GrdVT, 4, 1430, 4)
            ColumnSetUp(GrdVT, 5, 1430, 4)
            ColumnSetUp(GrdVT, 6, 1670, 4)
            ColumnSetUp(GrdVT, 7, 1275, 4)
            ColumnSetUp(GrdVT, 8, 1275, 4)
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho)
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
    Private Sub Frm154Dauky_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(2).Focus()
                    'Command_ClickEvent(Command(2), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboKho_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboKho.SelectedIndexChanged
        If CboKho.Items.Count > 0 Then
            mkho = CboKho.SelectedValue
        End If

        If CboKho.SelectedIndex >= 0 Then LietKeTonKho(mkho)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <remarks></remarks>
    Private Sub LietKeTonKho(ByRef mkho As Integer)
        Me.Cursor = Cursors.WaitCursor
        ClearGrid(GrdVT, ConvertToDblSafe(GrdVT.Tag))
        Dim rs_ton As DataTable = ExecSQLReturnDT(String.Format("SELECT t2.sohieu,t2.tenvattu,t1.soluong,t1.cpnvl,t1.cpnc,t1.cpsxc,t1.phantram FROM vattu t2 inner join thanhphamdd t1 on t1.matp=t2.maso WHERE (t1.soluong > 0 or t1.cpnvl >0 or t1.cpnc > 0 or t1.cpsxc > 0) and t1.thang = 0 and makhonvl={0} ORDER BY t2.sohieu desc", mkho))
        Dim rs_tonIndex As Integer = 0
        Dim cpnvl As Double = 0
        Dim cpsxc As Double = 0
        Dim cpnc As Double = 0
        Dim tt As Double = 0
        Do While rs_tonIndex < rs_ton.Rows.Count
            Dim rs_tonItem As DataRow = rs_ton.Rows(rs_tonIndex)
            rs_tonIndex += 1 ' C15 Rs LOOP CONTROL
            Dim s1 As String = Format(rs_tonItem("CPNVL") + rs_tonItem("cpnc") + rs_tonItem("cpsxc"), Mask_2)
            GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                              ConvertToStrSafe(rs_tonItem("SoHieu")), _
                              Chr(9), _
                              ConvertToStrSafe(rs_tonItem("TenVattu")), _
                              Format(rs_tonItem("soluong"), Mask_2), _
                              Format(rs_tonItem("CPNVL"), Mask_2), _
                              Format(rs_tonItem("cpnc"), Mask_2), _
                              Format(rs_tonItem("cpsxc"), Mask_2), _
                              Format(rs_tonItem("CPNVL") + rs_tonItem("cpnc") + rs_tonItem("cpsxc"), Mask_2), _
                              Format(rs_tonItem("CPNVL") + rs_tonItem("cpnc") + rs_tonItem("cpsxc") / (IIf(ConvertToDblSafe(rs_tonItem("soluong")) > 0, rs_tonItem("soluong"), 1)), Mask_2), _
                              rs_tonItem("phantram")))
            'rs_ton.MoveNext()
            If rs_tonItem("CPNVL") IsNot Nothing Then
                cpnvl += rs_tonItem("CPNVL")
            End If

            If rs_tonItem("cpsxc") IsNot Nothing Then
                cpsxc += rs_tonItem("cpsxc")
            End If

            If rs_tonItem("cpnc") IsNot Nothing Then
                cpnc += rs_tonItem("cpnc")
            End If

            tt += s1
        Loop
        GrdVT.Rows = IIf(rs_ton.Rows.Count > ConvertToDblSafe(GrdVT.Tag), rs_ton.Rows.Count, ConvertToDblSafe(GrdVT.Tag))
        LbTien(0).Text = Format(tt, Mask_0)
        LbTien(1).Text = Format(cpnvl, Mask_0)
        LbTien(2).Text = Format(cpnc, Mask_0)
        LbTien(3).Text = Format(cpsxc, Mask_0)
        ' tongtien()
        ''rs_ton.Close()
        rs_ton = Nothing
        GrdVT.Row = 0
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub tongtien()
        Dim tong1542, tong1543 As Double
        Dim tong1541 As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(cpnvl) as f1,sum(cpnc)as f2,sum(cpsxc)as f3 FROM thanhphamdd WHERE thang=0 and makhonvl={0}", mkho), _
                                                      tong1542, _
                                                      tong1543))
        LbTien(0).Text = Format(tong1541 + tong1542 + tong1543, Mask_2)
        LbTien(1).Text = Format(tong1541, Mask_2)
        LbTien(2).Text = Format(tong1542, Mask_2)
        LbTien(3).Text = Format(tong1543, Mask_2)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        tp.InitVattuSohieu(txtTon(0).Text)
        If CboKho.SelectedIndex < 0 Then
            ErrMsg(er_KhoHang)
            Exit Sub
        End If
        If tp.MaSo = 0 Then
            ErrMsg(er_SHVattu)
            txtTon(0).Focus()
            Exit Sub
        End If
        Dim luong As Double = ConvertToDblSafe(txtTon(2).Text)
        Dim nvl As Double = ConvertToDblSafe(txtTon(3).Text)
        Dim nC As Double = ConvertToDblSafe(txtTon(4).Text)
        Dim sxc As Double = ConvertToDblSafe(txtTon(5).Text)
        Dim phantram As Double = ConvertToDblSafe(txtTon(8).Text)
        If luong < 0 Then
            myUMessager.mError(Ngonngu("Hãy nhập số lượng của thành phẩm !", "Enter quangtity of finished !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(2).Focus()
            Exit Sub
        End If
        If nvl < 0 Then
            myUMessager.mError(Ngonngu("Hãy nhập chi phí nguyên vật liệu của thành phẩm !", "Enter material cost of finished !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(3).Focus()
            Exit Sub
        End If
        If nC < 0 Then
            myUMessager.mError(Ngonngu("Hãy nhập chi phí nhân công của thành phẩm !", "Enter labor cost of finished !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(4).Focus()
            Exit Sub
        End If
        If sxc < 0 Then
            myUMessager.mError(Ngonngu("Hãy nhập chi phí sản xuất chung của thành phẩm !", "Enter certified production cost of finished !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(5).Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.Default
        With GrdVT
            For i As Integer = 0 To .Rows - 1
                .Col = 0
                .Row = i
                If .CtlText.length = 0 Then Exit For
                If .CtlText = tp.sohieu Then
                    GrdVT.RemoveItem(ConvertToDblSafe(i))
                    GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                                      tp.sohieu, _
                                      Chr(9), _
                                      tp.TenVattu, _
                                      Format(luong, Mask_2), _
                                      Format(nvl, Mask_2), _
                                      Format(nC, Mask_2), _
                                      Format(sxc, Mask_2), _
                                      Format(nvl + nC + sxc, Mask_2), _
                                      Format((nvl + nC + sxc) / (IIf(luong > 0, luong, 1)), Mask_2), _
                                      Format(phantram, Mask_0)), i)
                    ExecSQLNonQuery(String.Format("UPDATE thanhphamdd set soluong={0},cpnvl={1},cpnc={2},cpsxc={3},phantram={6} WHERE thang=0 and matp={4} and makhonvl={5}", luong, ConvertToStrSafe(nvl), ConvertToStrSafe(nC), ConvertToStrSafe(sxc), ConvertToStrSafe(tp.MaSo), ConvertToStrSafe(mkho), ConvertToStrSafe(phantram)))
                    Suadauky()
                    tongtien()
                    txtTon(0).Focus()
                    GoTo XongDK
                End If
            Next
            If ConvertToBoolSafe(GetSelectValue(String.Format("SELECT maso1 as f1 FROM thanhphamdd WHERE thang=0 and makhonvl={0} and matp={1}", _
                                                    mkho, _
                                                    ConvertToStrSafe(tp.MaSo)))) Then
                ExecSQLNonQuery(String.Format("UPDATE thanhphamdd set soluong={0},cpnvl={1},cpnc={2},cpsxc={3},phantram={6} WHERE thang=0 and matp={4} and makhonvl={5}", _
                                     luong, _
                                     ConvertToStrSafe(nvl), _
                                     ConvertToStrSafe(nC), _
                                     ConvertToStrSafe(sxc), _
                                     ConvertToStrSafe(tp.MaSo), _
                                     ConvertToStrSafe(mkho), _
                                     ConvertToStrSafe(phantram)))
                Suadauky()
            Else
                Dim sql As String = String.Format("INSERT INTO thanhphamdd(ngay,maso1,makhonvl,matp,thang,soluong,cpnvl,cpnc,cpsxc,matkcp,matknc,matksx,phantram) VALUES (N'{0}',{1},{2},{3},0,{4},{5},{6},{7},{8},{8},{8},{9})", _
                                    FormatDate(DateSerial(pNamTC, 1, 1)), _
                                    ConvertToStrSafe(Lng_MaxValue("MaSo1", "thanhphamdd") + 1), _
                                    ConvertToStrSafe(mkho), _
                                    ConvertToStrSafe(tp.MaSo), _
                                    CStr(luong), _
                                    CStr(nvl), _
                                    CStr(nC), _
                                    CStr(sxc), _
                                    Timten("maso", "1541", "sohieu", "hethongtk"), _
                                    CStr(phantram))
                'ExecSQLNonQuery("SET IDENTITY_INSERT THANHPHAMDD ON")
                ExecSQLNonQuery(sql)
                Dim rs As DataTable
                rs = New DataTable
                rs = ExecSQLReturnDT("select top 1 * from thanhphamdd")
                If rs.Rows.Count > 0 Then
                    For i As Integer = 0 To rs.Columns.Count - 1
                        ExecSQLNonQuery("update thanhphamdd set " + CStr(rs.Columns(i).ColumnName) + "=0 where " + CStr(rs.Columns(i).ColumnName) + " is null")
                    Next
                End If
                Themdauky(nvl, nC, sxc)
                End If
            .AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                             tp.sohieu, _
                             Chr(9), _
                             tp.TenVattu, _
                             Format(luong, Mask_2), _
                             Format(nvl, Mask_2), _
                             Format(nC, Mask_2), _
                             Format(sxc, Mask_2), _
                             Format(nvl + nC + sxc, Mask_2), _
                             Format((nvl + nC + sxc) / (IIf(luong > 0, luong, 1)), Mask_2), _
                             Format(phantram, Mask_0)))
                .Row = (.Rows - 1)
                .Col = 0
                If .CtlText.Length = 0 Then .RemoveItem(.Row)
                .Row = 0
                txtTon(0).Focus()
        End With
        tongtien()
XongDK:
        Me.Cursor = Cursors.Default
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
            If .CtlText.length = 0 Then Exit Sub
            For i As Integer = 0 To 8
                .Col = ConvertToDblSafe(i)
                txtTon(i).Text = .CtlText
            Next
            txtTon(0).Focus()
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean
    Private Sub txtTon_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_7.TextChanged, _txtTon_6.TextChanged, _txtTon_5.TextChanged, _txtTon_4.TextChanged, _txtTon_3.TextChanged, _txtTon_2.TextChanged, _txtTon_1.TextChanged, _txtTon_0.TextChanged
        If isInitializingComponent Then
            Exit Sub
        End If
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        If Index = 6 Then txtTon(7).Text = Format(dongia(ConvertToDblSafe(txtTon(2).Text), ConvertToDblSafe(txtTon(6).Text)), Mask_0)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_7.Enter, _txtTon_6.Enter, _txtTon_5.Enter, _txtTon_4.Enter, _txtTon_3.Enter, _txtTon_2.Enter, _txtTon_1.Enter, _txtTon_0.Enter
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        txtTon(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_7.KeyPress, _txtTon_6.KeyPress, _txtTon_5.KeyPress, _txtTon_4.KeyPress, _txtTon_3.KeyPress, _txtTon_2.KeyPress, _txtTon_1.KeyPress, _txtTon_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Dim strSohieu As String = ""
        Select Case Index
            Case 0
                If KeyAscii = 13 Then
                    strSohieu = FrmVattu.ChonVattu(txtTon(0).Text)
                    tp.InitVattuSohieu(strSohieu)
                    txtTon(0).Text = strSohieu
                    txtTon(1).Text = tp.TenVattu
                    txtTon(2).Focus()
                End If
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
    Private Sub txtTon_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_7.Leave, _txtTon_6.Leave, _txtTon_5.Leave, _txtTon_4.Leave, _txtTon_3.Leave, _txtTon_2.Leave, _txtTon_1.Leave, _txtTon_0.Leave
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        'txtTon(Index).Text = Format(txtTon(Index).Text, Mask_2)
        Select Case Index
            Case 3, 4, 5
                txtTon(6).Text = Format(ConvertToDblSafe(txtTon(3).Text) + ConvertToDblSafe(txtTon(4).Text) + ConvertToDblSafe(txtTon(5).Text), Mask_2)
            Case 2
                txtTon(7).Text = Format(dongia(ConvertToDblSafe(txtTon(2).Text), ConvertToDblSafe(txtTon(6).Text)), Mask_2)
            Case Else
                txtTon(Index).Text = txtTon(Index).Text
        End Select
    End Sub
    Function dongia(ByRef luong As Double, ByRef tien As Double) As Double
        Return tien / (IIf(luong > 0, luong, 1))
    End Function
    Sub Suadauky()
        '    Dim Tnvl As Double, Tnc As Double, Tsxc As Double, j As Integer
        '    Dim Tnvl1 As Double, Tnc1 As Double, Tsxc1 As Double
        '    Dim Lech1 As Double, Lech2 As Double, Lech3 As Double
        '
        '    Tnvl = GetSelectValue("SELECT sum(cpnvl) as f1,sum(cpnc) as f2,sum(cpsxc) as f3 FROM thanhphamdd WHERE thang=0", Tnc, Tsxc)
        '    Tnvl1 = GetSelectValue("SELECT sum(duno_0-duco_0) as f1 FROM hethongtk WHERE sohieu='1541'")
        '    Tnc1 = GetSelectValue("SELECT sum(duno_0-duco_0) as f1 FROM hethongtk WHERE sohieu='1542'")
        '    Tsxc1 = GetSelectValue("SELECT sum(duno_0-duco_0) as f1 FROM hethongtk WHERE sohieu='1543'")
        '    Lech1 = Tnvl - Tnvl1
        '    Lech2 = Tnc - Tnc1
        '    Lech3 = Tsxc - Tsxc1
        '    For j = 0 To 12
        '        Tnvl1 = Lech1 + GetSelectValue("SELECT sum(duno_" + ConvertToStrSafe(j) + "-duco_" + ConvertToStrSafe(j) + ") as f1 FROM hethongtk WHERE sohieu='1541'")
        '        Tnc1 = Lech2 + GetSelectValue("SELECT sum(duno_" + ConvertToStrSafe(j) + "-duco_" + ConvertToStrSafe(j) + ") as f1 FROM hethongtk WHERE sohieu='1542'")
        '        Tsxc1 = Lech3 + GetSelectValue("SELECT sum(duno_" + ConvertToStrSafe(j) + "-duco_" + ConvertToStrSafe(j) + ") as f1 FROM hethongtk WHERE sohieu='1543'")
        '
        '        ExecSQLNonQuery  ("UPDATE hethongtk set " + iif(Tnvl1 >= 0, "duno_" + ConvertToStrSafe(j) + "=" + ConvertToStrSafe(Tnvl1), "duco_" + ConvertToStrSafe(j) + "=" + ConvertToStrSafe(Abs(Tnvl1))) + " WHERE sohieu='1541'")
        '        ExecSQLNonQuery  ("UPDATE hethongtk set " + iif(Tnc1 >= 0, "duno_" + ConvertToStrSafe(j) + "=" + ConvertToStrSafe(Tnc1), "duco_" + ConvertToStrSafe(j) + "=" + ConvertToStrSafe(Abs(Tnc1))) + " WHERE sohieu='1542'")
        '        ExecSQLNonQuery  ("UPDATE hethongtk set " + iif(Tsxc1 >= 0, "duno_" + ConvertToStrSafe(j) + "=" + ConvertToStrSafe(Tsxc1), "duco_" + ConvertToStrSafe(j) + "=" + ConvertToStrSafe(Abs(Tsxc1))) + " WHERE sohieu='1543'")
        '    Next
        Dim Tnvl As Double = ConvertToDblSafe(GetSelectValue("SELECT sum(cpnvl+cpnc+cpsxc) as f1 FROM thanhphamdd WHERE thang=0"))
        Dim Tnvl1 As Double = ConvertToDblSafe(GetSelectValue("SELECT sum(duno_0-duco_0) as f1 FROM hethongtk WHERE sohieu='1541'"))
        Dim Lech1 As Double = Tnvl - Tnvl1
        For j As Integer = 0 To 12
            Tnvl1 = Lech1 + ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(duno_{0}-duco_{1}) as f1 FROM hethongtk WHERE sohieu='1541'", j, ConvertToStrSafe(j))))
            ExecSQLNonQuery((String.Format("UPDATE hethongtk set {0} WHERE sohieu='1541'", (IIf(Tnvl1 >= 0, String.Format("duno_{0}={1}", _
                                                                                                         j, _
                                                                                                         ConvertToStrSafe(Tnvl1)), String.Format("duco_{0}={1}", _
                                                                                                                                       j, _
                                                                                                                                       ConvertToStrSafe(Math.Abs(Tnvl1))))))))
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nvl"></param>
    ''' <param name="nC"></param>
    ''' <param name="sxc"></param>
    ''' <remarks></remarks>
    Sub Themdauky(ByRef nvl As Double, ByRef nC As Double, ByRef sxc As Double)
        Dim Tnvl As Double
        For j As Integer = 0 To 12
            Tnvl = nvl + nC + sxc + ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(duno_{0}-duco_{1}) as f1 FROM hethongtk WHERE sohieu='1541'", _
                                                                        j, _
                                                                        ConvertToStrSafe(j))))
            ExecSQLNonQuery(String.Format("UPDATE hethongtk set {0} WHERE sohieu='1541'", (IIf(Tnvl >= 0, String.Format("duno_{0}={1}", _
                                                                                                        j, _
                                                                                                        ConvertToStrSafe(Tnvl)), String.Format("duco_{0}={1}", _
                                                                                                                                     j, _
                                                                                                                                     ConvertToStrSafe(Math.Abs(Tnvl)))))))
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Frm154Dauky_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
