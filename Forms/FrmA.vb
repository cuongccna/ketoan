Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmA
    Dim Filename As String = String.Empty
    Dim thang As Integer
    Dim thang1 As Integer
    Dim act As Integer
    Dim dakhoitao As Integer = 0
    Private Sub Chk_MouseUp(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles Chk.MouseUp
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim X As Single = (eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        Dim i As Integer
        GrdChungtu.Col = 5
        GrdChungtu.Row = 0
        If Chk.CheckState Then
            Chk.Text = Ngonngu("Huỷ tất cả", "Cancel all")
            While i < ConvertToIntSafe(LbSoCT.Text) And i < GrdChungtu.Rows
                GrdChungtu.Items(GrdChungtu.Row).SubItems(GrdChungtu.Col).Text = "X"
                i += 1
                GrdChungtu.Row = i
            End While
        Else
            Chk.Text = Ngonngu("Chọn tất cả", "Choose all")
            While i < ConvertToIntSafe(LbSoCT.Text) And i < GrdChungtu.Rows
                GrdChungtu.Items(GrdChungtu.Row).SubItems(GrdChungtu.Col).Text = "-"
                i += 1
                GrdChungtu.Row = i
            End While
        End If
    End Sub
    '======================================================================================
    ' Liệt kê, Chọn chứng từ
    '======================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        act = Index
        Me.Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmA_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(0).Focus()
                    '  Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.S
                    If Command(1).Visible Then
                        Command(1).Focus()
                        '  Command_ClickEvent(Command(1), New EventArgs())
                    End If
                Case Keys.T
                    If Command(2).Visible Then
                        Command(2).Focus()
                        ' Command_ClickEvent(Command(2), New EventArgs())
                    End If
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(0), New EventArgs())
    End Sub
    ''' <summary>
    ''' Khởi tạo cửa sổ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>   
    Private Sub FrmA_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            KhoiTao()
            Text = SetFormTitle(Text)
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Sub KhoiTao()
        If Not dakhoitao Then
            dakhoitao = 1 - dakhoitao
            ColumnSetUp(GrdChungtu, 0, 1350, 0)
            ColumnSetUp(GrdChungtu, 1, 950, 2)
            ColumnSetUp(GrdChungtu, 2, 950, 2)
            ColumnSetUp(GrdChungtu, 3, 3850, 0)
            ColumnSetUp(GrdChungtu, 4, 1300, ContentAlignment.MiddleRight)
            ColumnSetUp(GrdChungtu, 5, 900, 2)
            ColumnSetUp(GrdChungtu, 6, 1, 2)
        End If
    End Sub
    '======================================================================================
    ' Nhớ mã số CT được chọn
    '======================================================================================
    Private Sub GrdChungtu_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdChungtu.Click
        With GrdChungtu
            .Col = 5
            If .CtlText.length = 0 Then Exit Sub
            If .CtlText = "X" Then
                .CtlText = "-"
                Chk.CheckState = CheckState.Unchecked
                Chk.Text = "Chọn tất cả"
            Else
                If KtraChon() Then .CtlText = "X" Else MessageBox.Show(String.Format("Không chọn quá {0} chứng từ!", Max1000), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdChungtu.KeyPress
        GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())
        If eventArgs.KeyChar = Chr(Keys.Enter) Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub
    '======================================================================================
    ' Liệt kê chứng từ
    '======================================================================================
    Private Sub LietKeChungtu(ByRef thang As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef thang1 As Integer = 0, Optional ByRef MaTK As String = "", Optional ByRef sohieusang As String = "")
        Dim mloai As Integer
        Dim uid, mct, mct1 As Integer
        Dim rs_chungtu As DataTable
        Dim st As String = String.Empty
        Dim ovr As Integer
        Dim sql As String = String.Empty
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim MienTru As String = String.Format("SELECT MaCT,Sum(CASE WHEN MaTKNo > 0 THEN SoPS ELSE 0 END) AS TPS FROM ChungTu WHERE {0} GROUP BY MaCT", IIf(thang > 0, _
                                                                                                                                                                WThang("ThangCT", thang, IIf(thang1 = 0, thang, thang1)), _
                                                                                                                                                                WNgay("NgayCT", ndau, ncuoi)))
            If sohieusang.Length <> 0 Then
                sql = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai{0} AS DG,TPS,[User_ID],ChungTu.MaLoai,Max(CASE WHEN IsNull(HoaDon.MaSo, 1) = 1 THEN '-' ELSE 'X' END) AS Chon FROM (((ChungTu inner join hethongtk t1 on t1.maso=chungtu.{1})inner join hethongtk t2 on t2.maso=chungtu.{2}) INNER JOIN (" & MienTru & ") as MienTru ON ChungTu.MaCT=MienTru.MaCT) LEFT JOIN HoaDon ON ChungTu.MaSo = HoaDon.MaSo  WHERE left(t1.sohieu,len({3}))=N'{3}' and left(t1.sohieu,len({4}))<>'{4}' GROUP BY ChungTu.MaCT,[User_ID],ChungTu.MaLoai,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0},TPS,MaLoai  ORDER BY NgayGS DESC, ChungTu.SoHieu DESC", _
                          IIf(pNN = 1, "E", String.Empty), _
                          IIf(Strings.Left(MaTK, 3) = "131", "matkno", "matkco"), _
                          IIf(Strings.Left(MaTK, 3) = "131", "matkco", "matkno"), _
                          MaTK, _
                          sohieusang)
            Else
                If MaTK.Length <> 0 Then
                    sql = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai{0} AS DG,TPS,[User_ID],ChungTu.MaLoai,Max(CASE WHEN IsNull(HoaDon.MaSo, 1) = 1 THEN '-' ELSE 'X' END) AS Chon FROM (((ChungTu inner join hethongtk t1 on t1.maso=chungtu.{1})inner join hethongtk t2 on t2.maso=chungtu.{2}) INNER JOIN (" & MienTru & ") as MienTru ON ChungTu.MaCT=MienTru.MaCT) LEFT JOIN HoaDon ON ChungTu.MaSo = HoaDon.MaSo  WHERE left(t1.sohieu,len({3}))=N'{3}' or left(t2.sohieu,len({3}))=N'{3}' GROUP BY ChungTu.MaCT,[User_ID],ChungTu.MaLoai,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0},TPS,MaLoai  ORDER BY NgayGS DESC, ChungTu.SoHieu DESC", _
                              IIf(pNN = 1, "E", String.Empty), _
                              IIf(Strings.Left(MaTK, 3) = "131", "matkno", "matkco"), _
                              IIf(Strings.Left(MaTK, 3) = "131", "matkco", "matkno"), _
                              MaTK)
                Else
                    sql = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai{0} AS DG,TPS,[User_ID],ChungTu.MaLoai,Max(CASE WHEN IsNull(HoaDon.MaSo, 1) = 1 THEN '-' ELSE 'X' END) AS Chon FROM (ChungTu INNER JOIN (" & MienTru & ") as MienTru ON ChungTu.MaCT=MienTru.MaCT) LEFT JOIN HoaDon ON ChungTu.MaSo = HoaDon.MaSo  GROUP BY ChungTu.MaCT,[User_ID],ChungTu.MaLoai,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0},TPS,MaLoai  ORDER BY NgayGS DESC, ChungTu.SoHieu DESC", IIf(pNN = 1, "E", String.Empty))
                End If
            End If
            ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))           
            rs_chungtu = ExecSQLReturnDT(sql)
            For Each rsChungtuItem As DataRow In rs_chungtu.Rows
                If mct <> ConvertToDblSafe(rsChungtuItem("MaCT")) Then
                    mct = ConvertToDblSafe(rsChungtuItem("MaCT"))
                    uid = ConvertToDblSafe(rsChungtuItem("User_ID"))
                Else
                    If uid <> ConvertToDblSafe(rsChungtuItem("User_ID")) _
                    Or mloai <> ConvertToDblSafe(rsChungtuItem("maloai")) Then
                        mct1 = Lng_MaxValue("MaCT", "ChungTu") + 1
                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaCT={0} WHERE MaCT={1} AND User_ID={2}", _
                                            mct1, _
                                            mct, _
                                            rsChungtuItem("User_ID")))
                        mct = mct1
                        uid = ConvertToDblSafe(rsChungtuItem("User_ID"))
                        mloai = ConvertToDblSafe(rsChungtuItem("maloai"))
                    End If
                End If
                If GrdChungtu.Rows < MaxGridRow Then
                    Dim Sohieu As String = ConvertToStrSafe(rsChungtuItem("SoHieu"))
                    If ConvertToDblSafe(rsChungtuItem("maloai")) = 2 And Sohieu.EndsWith("GV") And Sohieu.Length > 2 Then
                        st = IIf(ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 HoaDon.MaSo AS F1 FROM HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo WHERE ChungTu.MaLoai=8 AND ChungTu.SoHieu=N'{0}' AND ChungTu.NgayCT='{1}'", _
                                                                     Strings.Left(Sohieu, Sohieu.Length - 2), _
                                                                     Format(CDate(rsChungtuItem("NgayCT")), Mask_DB)))) > 0, "X", "0")
                    Else
                        st = rsChungtuItem("Chon")
                    End If
                    If thang1 <> 0 Then st = "-"
                    GrdChungtu.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}", _
                                           Sohieu, _
                                           Chr(9), _
                                           Format(ConvertToDateSafe(rsChungtuItem("NgayCT")), Mask_D), _
                                           Format(ConvertToDateSafe(rsChungtuItem("NgayGS")), Mask_D), _
                                           rsChungtuItem("dg"), _
                                           Format(ConvertToDblSafe(rsChungtuItem("tps")), Mask_0), _
                                           st, _
                                           mct), 0)
                Else
                    ovr = 1
                End If
            Next
            'GrdChungtu.Rows = iif(rs_chungtu.Rows.Count > ConvertToDblSafe(GrdChungtu.Tag), _
            'iif(rs_chungtu.Rows.Count > MaxGridRow, MaxGridRow, rs_chungtu.Rows.Count), _
            'ConvertToDblSafe(GrdChungtu.Tag))
            LbSoCT.Text = ConvertToStrSafe(rs_chungtu.Rows.Count)
            GrdChungtu.Col = 0
            rs_chungtu = Nothing
            If ovr > 0 Then ErrMsg(er_NhieuCT)
        Catch
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="thang1"></param>
    ''' <param name="MaTK"></param>
    ''' <param name="sohieusang"></param>
    ''' <remarks></remarks>
    Private Sub LietKeChungtuchuyen(ByVal chuyen1111 As String, ByRef thang As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef thang1 As Integer = 0, Optional ByRef MaTK As String = "", Optional ByRef sohieusang As String = "")
        Dim mloai As Integer
        Dim uid, mct, mct1 As Integer
        Dim rs_chungtu As DataTable
        Dim st As String = String.Empty
        Dim ovr As Integer
        Dim sql As String = String.Empty
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim MienTru As String = String.Format("SELECT MaCT,Sum(CASE WHEN MaTKNo > 0 THEN SoPS ELSE 0 END) AS TPS FROM ChungTu WHERE {0} GROUP BY MaCT", IIf(thang > 0, _
                                                                                                                                                            WThang("ThangCT", thang, IIf(thang1 = 0, thang, thang1)), _
                                                                                                                                                            WNgay("NgayCT", ndau, ncuoi)))
            ExecSQLNonQuery(MienTru)
            If ConvertToDblSafe(MaTK) <> 0 Then
                sql = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai{0} AS DG,TPS,[User_ID],ChungTu.MaLoai,Max(CASE WHEN IsNull(HoaDon.MaSo, 1) = 1 THEN '-' ELSE 'X' END) AS Chon FROM (" & chuyen1111 & ") as ChungTu LEFT JOIN HoaDon ON ChungTu.MaSo = HoaDon.MaSo  WHERE Chungtu.mact not in(SELECT DISTINCT ChungTu.MaCT FROM (((" & chuyen1111 & ") as ChungTu inner join hethongtk t2 on chungtu.matkco=t2.maso)inner join hethongtk t1 on chungtu.matkno=t1.maso)LEFT JOIN HoaDon ON ChungTu.MaSo = HoaDon.MaSo  WHERE left(t1.sohieu,len({1}))={1} OR left(t2.sohieu,len({1}))={1} GROUP BY ChungTu.MaCT) GROUP BY ChungTu.MaCT,[User_ID],ChungTu.MaLoai,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0},TPS,MaLoai  ORDER BY NgayGS DESC, ChungTu.SoHieu DESC", _
                          IIf(pNN = 1, "E", String.Empty), _
                          sohieusang)
            End If
            ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
            KhoiTao()
            rs_chungtu = ExecSQLReturnDT(sql)
            For Each rsChungtuItem As DataRow In rs_chungtu.Rows
                If mct <> ConvertToDblSafe(rsChungtuItem("MaCT")) Then
                    If rsChungtuItem("MaCT") IsNot Nothing Then
                        mct = ConvertToDblSafe(rsChungtuItem("MaCT"))
                    End If
                    If rsChungtuItem("User_ID") IsNot Nothing Then
                        uid = ConvertToDblSafe(rsChungtuItem("User_ID"))
                    End If
                Else
                    If uid <> ConvertToDblSafe(rsChungtuItem("User_ID")) _
                    Or mloai <> ConvertToDblSafe(rsChungtuItem("maloai")) Then
                        mct1 = Lng_MaxValue("MaCT", "ChungTu") + 1
                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaCT={0} WHERE MaCT={1} AND User_ID={2}", _
                                            mct1, _
                                            ConvertToStrSafe(mct), _
                                            ConvertToDblSafe(rsChungtuItem("User_ID"))))
                        mct = mct1
                        If rsChungtuItem("User_ID") IsNot Nothing Then
                            uid = ConvertToDblSafe(rsChungtuItem("User_ID"))
                        End If
                        If rsChungtuItem("maloai") IsNot Nothing Then
                            mloai = ConvertToDblSafe(rsChungtuItem("maloai"))
                        End If
                    End If
                End If
                If GrdChungtu.Rows < MaxGridRow Then
                    Dim SoHieu As String = rsChungtuItem("SoHieu")
                    If ConvertToDblSafe(rsChungtuItem("maloai")) = 2 _
                    And SoHieu.EndsWith("GV") _
                    And SoHieu.Length > 2 Then
                        st = IIf(ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 HoaDon.MaSo AS F1 FROM HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo WHERE ChungTu.MaLoai=8 AND ChungTu.SoHieu=N'{0}' AND ChungTu.NgayCT='{1}'", _
                                                                     Strings.Left(SoHieu, SoHieu.Length - 2), _
                                                                     Format(ConvertToDateSafe(CDate(rsChungtuItem("NgayCT"))), Mask_DB)))) > 0, "X", "0")
                    Else
                        st = ConvertToStrSafe(rsChungtuItem("Chon"))
                    End If
                    If thang1 <> 0 Then
                        st = "-"
                    End If
                    GrdChungtu.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}", _
                                           SoHieu, _
                                           Chr(9), _
                                           Format(ConvertToDateSafe(rsChungtuItem("NgayCT")), Mask_D), _
                                           Format(ConvertToDateSafe(rsChungtuItem("NgayGS")), Mask_D), _
                                           rsChungtuItem("dg"), _
                                           Format(ConvertToDblSafe(rsChungtuItem("tps")), Mask_0), _
                                           st, _
                                           mct), 0)
                Else
                    ovr = 1
                End If
            Next
            'GrdChungtu.Rows = iif(rs_chungtu.Rows.Count > ConvertToDblSafe(GrdChungtu.Tag), iif(rs_chungtu.Rows.Count > MaxGridRow, MaxGridRow, rs_chungtu.Rows.Count), ConvertToDblSafe(GrdChungtu.Tag))
            LbSoCT.Text = ConvertToStrSafe(rs_chungtu.Rows.Count)
            GrdChungtu.Col = 0
            If ovr > 0 Then ErrMsg(er_NhieuCT)
        Catch
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fn"></param>
    ''' <param name="thangchon"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="mct"></param>
    ''' <param name="thangchon1"></param>
    ''' <param name="MaTK"></param>
    ''' <param name="sohieusang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChonCTSoA(ByRef fn As String, ByRef thangchon As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mct() As Integer, Optional ByRef thangchon1 As Integer = 0, Optional ByRef MaTK As String = "", Optional ByRef sohieusang As String = "") As Integer
        Dim result As Integer = 0
        Dim c As Integer
        If thangchon1 <> 0 Then
            Command(1).Visible = False
            Command(2).Visible = True
            Chk.Visible = True
        Else
            Command(1).Visible = True
            Command(2).Visible = False
            Chk.Visible = False
        End If
        Filename = fn
        act = 0
        thang = thangchon
        thang1 = thangchon1
        If thangchon > 0 Then
            LbThang.Text = String.Format("Tháng {0}/{1}", _
                               thangchon, _
                               ConvertToStrSafe(IIf(thang >= pThangDauKy, pNamTC, pNamTC - 1)))
            If thang1 <> 0 Then LbThang.Text = String.Format("{0} đến {1}/{2}", _
                                                   LbThang.Text, _
                                                   ConvertToStrSafe(thangchon1), _
                                                   ConvertToStrSafe(IIf(thang1 >= pThangDauKy, pNamTC, pNamTC - 1)))
        Else
            LbThang.Text = String.Format("Từ {0} đến {1}", _
                               Format(ndau, Mask_D), _
                               Format(ncuoi, Mask_D))
        End If
        KhoiTao()
        LietKeChungtu(thangchon, _
            ndau, _
            ncuoi, _
            thangchon1, _
            MaTK, _
            sohieusang)
        Me.ShowDialog()
        Me.Refresh()
        If act = 0 Then Return result
        With GrdChungtu
            .Col = 5
            For i As Integer = 0 To .Rows - 1
                .Row = i
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                If .Items(.Row).SubItems(.Col).Text = "X" Then
                    If c < Max1000 Then
                        .Col = 6
                        mct(c) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        c += 1
                        .Col = 5
                    End If
                End If
            Next
        End With
        result = c
        ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
        Me.Close()
        Return result
    End Function
    Public Function ChonCTSoB(ByVal chuyen1111 As String, ByRef sohieusang As String, ByRef thangchon As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mct() As Integer, Optional ByRef thangchon1 As Integer = 0, Optional ByRef MaTK As String = "") As Integer
        Dim result As Integer = 0
        Dim c As Integer = 0
        If Strings.Left(sohieusang, MaTK.Length) = MaTK Or Strings.Left(MaTK, sohieusang.Length) = sohieusang Then Return result
        If thangchon1 <> 0 Then
            Command(1).Visible = False
            Command(2).Visible = True
            Chk.Visible = True
        Else
            Command(1).Visible = True
            Command(2).Visible = False
            Chk.Visible = False
        End If
        act = 0
        thang = thangchon
        thang1 = thangchon1
        If thangchon > 0 Then
            LbThang.Text = String.Format("Tháng {0}/{1}", _
                               thangchon, _
                               ConvertToStrSafe(IIf(thang >= pThangDauKy, pNamTC, pNamTC - 1)))
            If thang1 <> 0 Then LbThang.Text = String.Format("{0} đến {1}/{2}", _
                                                   LbThang.Text, _
                                                   ConvertToStrSafe(thangchon1), _
                                                   ConvertToStrSafe(IIf(thang1 >= pThangDauKy, pNamTC, pNamTC - 1)))
        Else
            LbThang.Text = String.Format("Từ {0} đến {1}", _
                               Format(ndau, Mask_D), _
                               Format(ncuoi, Mask_D))
        End If
        LietKeChungtuchuyen(chuyen1111, thangchon, _
            ndau, _
            ncuoi, _
            thangchon1, _
            MaTK, _
            sohieusang)
        Me.ShowDialog()
        Me.Refresh()
        If act = 0 Then Return result
        With GrdChungtu
            .Col = 5
            For i As Integer = 0 To .Rows - 1
                .Row = i
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                If .Items(.Row).SubItems(.Col).Text = "X" Then
                    If c < Max1000 Then
                        .Col = 6
                        mct(c) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        c += 1
                        .Col = 5
                    End If
                End If
            Next
        End With
        result = c
        ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
        Me.Close()
        Return result
    End Function
    Private Function KtraChon() As Boolean
        Dim result As Boolean = False
        Dim c As Integer
        With GrdChungtu
            .Col = 5
            For i As Integer = 0 To .Rows - 1
                If .CtlText.length = 0 Then Exit For
                If .CtlText = "X" Then
                    c += 1
                End If
            Next
            result = (c < Max1000)
        End With
        Return result
    End Function
    Private Sub FrmA_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub Chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk.CheckedChanged

    End Sub
End Class
