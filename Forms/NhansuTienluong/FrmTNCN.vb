Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmTNCN
    Dim thang As Integer
    Dim Nhanvien As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmTNCN_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        ' Init form 
        Call FormInit()

        ColumnSetUp(GrdVT, 0, 2270, 0)
        ColumnSetUp(GrdVT, 1, 1430, 4)
        ColumnSetUp(GrdVT, 2, 1670, 4)
        ColumnSetUp(GrdVT, 3, 1190, 4)
        ColumnSetUp(GrdVT, 4, 1310, 4)
        ColumnSetUp(GrdVT, 5, 1310, 4)
        ColumnSetUp(GrdVT, 6, 1310, 4)
        ColumnSetUp(GrdVT, 7, 1310, 4)
        ColumnSetUp(GrdVT, 8, 1550, 4)
        ColumnSetUp(GrdVT, 9, 1270, 4)
        ColumnSetUp(GrdVT, 10, 1, 0)
        ColumnSetUp(GrdVT, 11, 1, 0)

        AddMonthToCbo(CboThang)
        If CboThang.Items.Count > 0 Then
            CboThang.SelectedIndex = 0
        End If
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Hienthi()
        Dim i As Integer = 0
        Dim Mientru As String = String.Format("SELECT bl.manv,bl.tongthunhap,bl.bhxh,bl.bhyt,bl.bhtn,bl.sothang,bl.thuephainop,cn.lkcn,tt.tuthien,tt.nhandao,tt.khuyenhoc,tt.nop FROM (bangluong bl left join tuthien tt on (bl.manv=tt.manv and bl.thang=tt.thang)) left join Luongkcn cn on bl.manv=cn.manv and bl.thang=cn.thang WHERE bl.thang={0}", thang)
        Dim tam As String = String.Format("SELECT nv.maso,nv.ten,nv.mst,nv.cmnd,bl.manv,bl.tongthunhap,bl.bhxh,bl.bhyt,bl.bhtn,bl.sothang,bl.thuephainop,bl.lkcn,bl.tuthien,bl.nhandao,bl.khuyenhoc,bl.nop,pl.sohieu, count(gc.ten ) as nphuthuoc FROM (quanlynhanvien nv inner join phanloaiquanlynhanvien pl on nv.maphanloai=pl.maso left join GiaCanh gc on nv.MaSo=gc.manv) inner join ({0}) AS bl on nv.maso=bl.manv WHERE loaihd=1 or loaihd=2 group by nv.maso,nv.ten,nv.mst,nv.cmnd,bl.manv,bl.tongthunhap,bl.bhxh,bl.bhyt,bl.bhtn,bl.sothang,bl.thuephainop,bl.lkcn,bl.tuthien,bl.nhandao,bl.khuyenhoc,bl.nop,pl.sohieu", Mientru)
        Dim rs As DataTable = ExecSQLReturnDT(tam)

        Label(14).Text = ""
        Label(15).Text = ""
        ClearGrid(GrdVT, GrdVT.Rows)

        Dim rsIndex As Integer = 0
        While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL   
            GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}", _
                              rsItem("ten"), _
                              Chr(9), _
                              rsItem("MST"), _
                              rsItem("CMND"), _
                              Format(ConvertToDblSafe(rsItem("tongthunhap")), Mask_0), _
                              Format(4000000, Mask_0), _
                              Format(ConvertToDblSafe(rsItem("nphuthuoc")) * 1600000, Mask_0), _
                              Format(ConvertToDblSafe(rsItem("tuthien")) + ConvertToDblSafe(rsItem("khuyenhoc")) + ConvertToDblSafe(rsItem("nhandao")), Mask_0), _
                              Format(ConvertToDblSafe(rsItem("BHXH")) + rsItem("BHYT") + ConvertToDblSafe(rsItem("BHTN")), Mask_0), _
                              Format(ConvertToDblSafe(rsItem("lkcn")), Mask_0), _
                              Format(ConvertToDblSafe(rsItem("thuephainop")), Mask_0), _
                              rsItem("MaSo"), _
                              rsItem("SoHieu")), i)
            i += 1
            ''rs.MoveNext()
            Xoadongtrongcuoi(GrdVT)
        End While
        Tinhtong()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ThangTinh"></param>
    ''' <remarks></remarks>
    Public Sub Tinhthue(ByRef ThangTinh As Integer)
        Dim phuthuoc As Integer
        Dim rs1 As DataTable
        Dim sothang As Integer
        Dim thunhap, thuepn, tuthien, lkcn As Double
        Cursor = Cursors.WaitCursor
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT manv,maso,tongthunhap,bhxh,bhyt,bhtn FROM bangluong WHERE thang={0}", ThangTinh))
        If rs.Rows.Count = 0 Then
            MessageBox.Show(String.Format("Thông tin tính thuế tháng {0} chưa có!{1}Vui lòng chấm công trước khi tính thuế.", _
                                    IIf(ThangTinh < 10, String.Format("0{0}", ThangTinh), ConvertToStrSafe(ThangTinh)), _
                                    Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Dim MaChucvu, MaPhanLoai, LoaiLuong As Integer
            Dim Sohieunhanvien As String = String.Empty
            Dim tncn, giacanh As Double
            Dim rsIndex As Integer = 0
            Dim goitrich As String = String.Empty
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                sothang = 0
                rs1 = ExecSQLReturnDT(String.Format("SELECT tuthang,denthang FROM giacanh WHERE manv={0}", rsItem("MaNV")))
                Dim rs1Index As Integer = 0
                While rs1Index < rs1.Rows.Count
                    Dim rs1Item As DataRow = rs1.Rows(rs1Index)
                    rs1Index += 1 ' C15 Rs LOOP CONTROL
                    If ConvertToDblSafe(Strings.Left(rs1Item("tuthang"), 2)) <= ThangTinh And ThangTinh <= ConvertToDblSafe(Strings.Left(rs1Item("denthang"), 2)) Then sothang += 1
                    'rs1.MoveNext()
                End While

                thunhap = ConvertToDblSafe(GetSelectValue(String.Format("SELECT (tongthunhap-bhxh-bhyt-bhtn) as f1, tncn as f2, giacanh as f3 FROM bangluong WHERE thang={0} and manv={1}", _
                                                               ThangTinh, _
                                                               rsItem("MaNV")), tncn, giacanh))
                tuthien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT (tuthien+nhandao+khuyenhoc) as f1 FROM tuthien WHERE thang={0} and manv={1}", _
                                                               ThangTinh, _
                                                               rsItem("MaNV"))))
                lkcn = ConvertToDblSafe(GetSelectValue(String.Format("SELECT lkcn as f1 FROM luongkcn WHERE thang={0} and manv={1}", _
                                                            ThangTinh, _
                                                            rsItem("MaNV"))))
                thuepn = thuephainopthang(ConvertToDblSafe((thunhap)), tncn, giacanh, CByte(ConvertToStrSafe(sothang)), ConvertToDblSafe((tuthien + lkcn)))
                phuthuoc = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(manv) as f1 FROM giacanh WHERE manv={0}", rsItem("MaNV"))))

                If thuepn > 0 And FrmChamcong.Visible Then
                    If goitrich Is Nothing Then goitrich = MessageBox.Show(String.Format("Tháng {0} có phát sinh thuế thu nhập cá nhân!{1}Bạn có muốn trích thuế thu nhập cá nhân không?", _
                                                           IIf(ThangTinh < 10, String.Format("0{0}", ThangTinh), ConvertToStrSafe(ThangTinh)), _
                                                           Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If ConvertToIntSafe(goitrich) = vbOK And goitrich <> "" Then
                        Sohieunhanvien = ConvertToStrSafe(GetSelectValue(String.Format("SELECT sohieu as f1, maphanloai as f2, machucvu as f3, loailuong as f4 FROM quanlynhanvien WHERE maso={0}", rsItem("MaNV")), _
                                                          MaPhanLoai, _
                                                          MaChucvu, _
                                                          LoaiLuong))
                        Dim RecordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE phucap set trukhac2={0} WHERE sohieunhanvien='{1}' and thang={2}", _
                                                                                    thuepn, _
                                                                                    Sohieunhanvien, _
                                                                                    ConvertToStrSafe(ThangTinh)))
                        If RecordsAffectedCount <= 0 Then
                            ExecSQLNonQuery("INSERT INTO Phucap (MaSo, MaPhanLoai, Machucvu, Sohieunhanvien, Thang, Chucvu, Trachnhiem, Luudong, Loai, Khac1, Ghichu1, Khac2, Ghichu2,Khac3, Ghichu3, Khac4,Ghichu4,Khac5, Ghichu5,tamung,trukhac,trukhac1,trukhac2) " & " VALUES (" & Lng_MaxValue("MaSo", "Phucap") + 1 & "," & ConvertToStrSafe(MaPhanLoai) & "," & ConvertToStrSafe(MaChucvu) & ",'" & Sohieunhanvien & "'," & ConvertToStrSafe(ThangTinh) & ",0,0,0," & ConvertToStrSafe(LoaiLuong) & ",0,'Côm',0,'...',0,'...',0,'...',0,'...',0,0,0," & ConvertToStrSafe(thuepn) & ")")
                        End If
                        ExecSQLNonQuery(String.Format("UPDATE thongsoluong set thue={0} WHERE sohieunhanvien='{1}' and thang={2}", _
                                            thuepn, _
                                            Sohieunhanvien, _
                                            ConvertToStrSafe(ThangTinh)))
                    Else
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If
                ExecSQLNonQuery(String.Format("UPDATE bangluong set phuthuoc={0},thuephainop={1},sothang={2} WHERE maso={3}", _
                                    phuthuoc, _
                                    ConvertToStrSafe(thuepn), _
                                    ConvertToStrSafe(sothang), _
                                    rsItem("MaSo")))
            End While

            If goitrich IsNot Nothing Then
                If goitrich = vbOK Then Trichthue(ConvertToDblSafe((ThangTinh)))
            Else
                Hienthi()
            End If
        End If
        Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        thang = CboThang.SelectedValue
        Hienthi()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        ExecSQLNonQuery(String.Format("UPDATE Bangluong  set tinhgiam={0} WHERE manv={1} and thang={2}", _
                            CStr(ConvertToDblSafe(txt.Text)), _
                            ConvertToStrSafe(Nhanvien), _
                            ConvertToStrSafe(thang)))
        GrdVT.Col = 8
        GrdVT.CtlText = IIf(ConvertToDblSafe(txt.Text) <> 0, txt.Text, String.Empty)
        Tinhtong()
        For i As Integer = 0 To 8
            LbTxt(i).Text = ""
        Next
        txt.Text = ""
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Tinhtong()
        Dim tongthue, tonggiam As Double
        Dim dong As Integer = GrdVT.Row
        Dim cot As Integer = GrdVT.Col
        Dim i As Integer = 0
        GrdVT.Row = 0
        GrdVT.Col = ConvertToDblSafe(GrdVT.Cols - 1)
        While i < GrdVT.Rows And ConvertToDblSafe(GrdVT.CtlText) > 0
            GrdVT.Row = i
            GrdVT.Col = ConvertToDblSafe(GrdVT.Cols - 4)
            tonggiam += ConvertToDblSafe(GrdVT.CtlText)
            GrdVT.Col = ConvertToDblSafe(GrdVT.Cols - 3)
            tongthue += ConvertToDblSafe(GrdVT.CtlText)
            GrdVT.Col = ConvertToDblSafe(GrdVT.Cols - 2)
            i += 1
            GrdVT.Row = i
        End While
        Label(14).Text = Format(tonggiam, Mask_0)
        Label(15).Text = Format(tongthue, Mask_0)
        GrdVT.Row = dong
        GrdVT.Col = cot
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_0.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0 : Tinhthue(ConvertToDblSafe((thang)))
            Case 1 : Trichthue(ConvertToDblSafe((thang)))
            Case 2 : Me.Close()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ThangTrich"></param>
    ''' <remarks></remarks>
    Sub Trichthue(ByRef ThangTrich As Integer)
        Dim ct As New ClsChungtu
        Dim Ngay As Date
        Dim rs As DataTable
        Try
            Ngay = NgayCuoiThang(ConvertToDblSafe((pNamTC)), ConvertToDblSafe((ThangTrich)))
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) as f1 FROM chungtu WHERE sohieu='TNCN{0}'", (IIf(ThangTrich < 10, String.Format("0{0}", ThangTrich), ConvertToStrSafe(ThangTrich)))))) > 0 Then
                If MessageBox.Show(String.Format("Tháng {0} đã trích thuế thu nhập cá nhân! Bạn muốn trích lại không?", (IIf(ThangTrich < 10, String.Format("0{0}", ThangTrich), ConvertToStrSafe(ThangTrich)))), _
                       My.Application.Info.ProductName, _
                       MessageBoxButtons.YesNo, _
                       MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE sohieu='TNCN{0}'", (IIf(ThangTrich < 10, String.Format("0{0}", ThangTrich), ConvertToStrSafe(ThangTrich)))))
                Else
                    Exit Sub
                End If
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(bl.thuephainop)as thue,pl.sohieu FROM bangluong bl inner join phanloaiquanlynhanvien pl on bl.loainv=pl.maso WHERE bl.thang={0} group by pl.sohieu", ThangTrich))
            If rs.Rows.Count = 0 Then
                MessageBox.Show(String.Format("Thông tin trích thuế tháng {0} chưa có!{1}Vui lòng tính thuế trước khi trích thuế", _
                                        (IIf(ThangTrich < 10, String.Format("0{0}", ThangTrich), ConvertToStrSafe(ThangTrich))), _
                                        Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
            End If
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                If rsItem("Thue") > 0 Then
                    ct.InitChungtu(0, _
                        0, _
                        String.Format("TNCN{0}", (IIf(ThangTrich < 10, String.Format("0{0}", ThangTrich), ConvertToStrSafe(ThangTrich)))), _
                        ConvertToDblSafe((ThangTrich)), _
                        Ngay, _
                        Ngay, _
                        0, _
                        0, _
                        String.Format("Thuế thu nhập cá nhân tháng {0} năm {1}", (IIf(ThangTrich < 10, "0" & ThangTrich, ConvertToStrSafe(ThangTrich))), ConvertToStrSafe(pNamTC)), _
                        ConvertToDblSafe(Timten("maso", rsItem("SoHieu"), "sohieu", "hethongtk")), _
                        SoHieu2MaSo(taikhoanconnhat("3335"), "hethongtk"), _
                        ConvertToDblSafe(rsItem("Thue")), _
                        0, _
                        0, _
                        0, _
                        "", _
                        1, DateTime.Today)
                    If rsIndex = 1 Then
                        ct.MaCT = Lng_MaxValue("mact", "chungtu") + 1
                    Else
                        ct.MaCT = Lng_MaxValue("mact", "chungtu")
                    End If
                    ct.GhiChungtu()
                End If
            End While
            MessageBox.Show(Ngonngu("Quá trình trích lương thành công!", "Salary deduction seccessful"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch
            MessageBox.Show(Ngonngu("Lỗi trích thuế!", "Error salary deduction!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
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
    Private Sub FrmTNCN_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case KeyCode
                Case Keys.V
                    Command(2).Focus()
                    Command_ClickEvent(Command(2), New EventArgs())
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
    Private Sub GrdVT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdVT.Click
        SetGridIndex(GrdVT, GrdVT.Row)
        With GrdVT
            .Col = 0
            If .CtlText.length > 0 Then
                For i As Integer = 0 To 7
                    .Col = ConvertToDblSafe(i)
                    LbTxt(i).Text = .CtlText
                Next
                .Col = 8
                txt.Text = .CtlText
                .Col = 9
                LbTxt(8).Text = .CtlText
                txt.Focus()
                .Col = 10
                Nhanvien = ConvertToDblSafe((.CtlText))
            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdVT.KeyUp
        Chondongxanh(GrdVT, eventArgs.KeyCode)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txt.Enter
        txt.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txt.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        KeyProcess(txt, KeyAscii, True)
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
    Private Sub txt_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txt.Leave
        txt.Text = IIf(ConvertToDblSafe(txt.Text) <> 0, Format(txt.Text, Mask_0), "0")
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(0).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmTNCN_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
