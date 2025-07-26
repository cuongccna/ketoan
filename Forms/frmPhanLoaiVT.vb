Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class frmPhanLoaiVT
    Dim tbl, tbl1 As String
    Public pl1 As Integer
    Private Structure tpPhanLoai
        Dim MaSo As Integer
        Dim TenPhanLoai As String
        Dim SoHieu As String
        Dim VAT As Integer
        Dim plcha As Integer
        Dim plcon As Integer
        Dim cap As Integer
        Dim MaTK As Integer
        Public Shared Function CreateInstance() As tpPhanLoai
            Dim result As New tpPhanLoai
            result.TenPhanLoai = String.Empty
            result.SoHieu = String.Empty
            Return result
        End Function
    End Structure
    Dim PhanLoai As tpPhanLoai = tpPhanLoai.CreateInstance()
    Dim tmpSoHieu As String = String.Empty ' Lưu các thông tin của cấp trên (để thêm mới)
    Dim tmpMaSo As Integer
    Dim tmpCap As Integer
    Dim sql As String = String.Empty

    Private Sub frmPhanLoaiVT_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode AS Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Insert Then
            If Outline.Nodes.Count > 0 Then
                Outline.SelectedNode = Outline.Nodes(Outline.SelectedNode.Index)
            End If
            tmpMaSo = 0
            tmpCap = 0
            tmpSoHieu = ""
            Command(0).Focus()
            'Application.DoEvents()
            Command_ClickEvent(Command(0), New EventArgs())
        End If
        'If (Shift And 4) > 0 Then
        '    Select Case eventArgs.KeyCode
        '        Case Keys.T : Command(0).Focus() : Application.DoEvents() : Command_ClickEvent(Command(0), New EventArgs())
        '        Case Keys.G : Command(1).Focus() : Application.DoEvents() : Command_ClickEvent(Command(1), New EventArgs())
        '        Case Keys.X : Command(2).Focus() : Application.DoEvents() : Command_ClickEvent(Command(2), New EventArgs())
        '        Case Keys.V : Command(3).Focus() : Application.DoEvents() : Command_ClickEvent(Command(3), New EventArgs())
        '        Case Keys.I : Command(4).Focus() : Application.DoEvents() : Command_ClickEvent(Command(4), New EventArgs())
        '    End Select
        'End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmPhanLoaiVT_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Select Case pl1
                Case 1
                    Me.Text = Ngonngu("Phân loại vật tư và tài khoản xuất kho tính gia vốn", "Classification")
                    tbl = "PhanLoaiVattu"
                    tbl1 = "Vattu"
                    Text_Renamed(2).Visible = True
                    _Label_6.Visible = True
                Case 2
                    Me.Text = Ngonngu("Phân loại khách hàng", "Classification")
                    tbl = "PhanLoaiKhachHang"
                    tbl1 = "KhachHang"
                Case 3
                    Me.Text = Ngonngu("Phân loại Công trình, sản phẩm", "Classification")
                    tbl = "PhanLoai154"
                    tbl1 = "TP154"
                Case 4
                    Me.Text = Ngonngu("Phân loại Nhân viên bán hàng", "Classification")
                    tbl = "PhanLoaiNhanVien"
                    tbl1 = "NhanVien"
            End Select
            LayDanhSachPhanLoai()
            Khoaquyen()
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmPhanLoaiVT_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        Try
            Select Case pl1
                Case 1 : FrmVattu.Close()
                Case 2 : FrmKhachHang.Close()
                Case 3 : FrmTP.Close()
                Case 4 : FrmNhanVien.Close()
            End Select
        Catch exc As System.Exception
            'Resume in On-Error-Resume-Next Block
            MessageBox.Show(exc.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, _Command_0.Click, _Command_1.Click, _Command_2.Click, _Command_3.Click, _Command_5.Click

        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim mpl As Integer
        Select Case Index
            Case 0 ' Moi
                If Outline.SelectedNode Is Nothing Then KhoiTao(False) Else KhoiTao(True)
                'If Outline.SelectedNode Is Nothing Then ButtonEdit1.Focus()
                'Khoaquyen()
            Case 1 ' Ghi
                If HopLe() = 0 Then
                    If PhanLoai.MaSo = 0 Then
                        If ThemMoi() = 0 Then KhoiTao(True)
                    Else
                        If SuaDoi() = 0 Then
                            CapNhatSoHieu(PhanLoai.cap, PhanLoai.MaSo, PhanLoai.SoHieu)
                            LayDanhSachPhanLoai()
                            KhoiTao(False)
                        End If
                    End If
                End If
            Case 2 ' Xoá
                If Outline.SelectedNode.Nodes.Count > 0 Then
                    SystemSounds.Beep.Play()
                    MessageBox.Show(Ngonngu("Vẫn còn các phân loại cấp dưới", "Even lower level classifition"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If System.Windows.Forms.DialogResult.No = MessageBox.Show(Ngonngu("Xoá phân loại hiện tại", "Delete current classifition"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then Exit Sub
                If Xoa() = 0 Then
                    KhoiTao(False)
                    tmpMaSo = 0
                    tmpSoHieu = ""
                    tmpCap = 0
                End If
            Case 3 ' Trở về
                Me.Close()
            Case 4
                Dim currentCate As Category = CType(Outline.SelectedNode.Tag, Category)
                mpl = currentCate.ID
                frmReport.ReportDestination = 1
                Select Case pl1
                    Case 1 : DanhDiemVT(mpl)
                    Case 2 : DanhDiemCN(mpl)
                End Select
                InBaoCaoRPT()
            Case 5
                If Outline.Nodes.Count > 0 Then
                    If Outline.SelectedNode.Parent IsNot Nothing Then
                        Outline.SelectedNode = Outline.SelectedNode.Parent
                    End If

                End If
                tmpMaSo = 0
                tmpCap = 0
                tmpSoHieu = ""
                Command(0).Focus()
                'Application.DoEvents()
                Command_ClickEvent(Command(0), New EventArgs())
        End Select
    End Sub

    Private Sub Text_Renamed_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_2.Enter, _Text_0.Enter, _Text_1.Enter
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Text_Renamed(Index).SelectAll()
    End Sub

    Private Sub Text_Renamed_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _Text_2.KeyPress, _Text_0.KeyPress, _Text_1.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Select Case Index
            Case 1
                If KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
            Case 2
                If KeyAscii = 13 Then
                    FrmTaikhoan.initOption = Text_Renamed(2).Text
                    Text_Renamed(2).Text = FrmTaikhoan.ChonTk(Text_Renamed(2).Text)
                    Text_Renamed(2).Focus()
                End If
        End Select
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Text_Renamed_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_2.Leave, _Text_0.Leave, _Text_1.Leave
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        If Strings.Len(Text_Renamed(Index).Text) = 0 Then Text_Renamed(Index).Text = "(...)"
        Select Case Index
            Case 0 : PhanLoai.TenPhanLoai = Text_Renamed(0).Text
            Case 1 : PhanLoai.SoHieu = Text_Renamed(1).Text 'String.Format("{0}{1}", ButtonEdit1.Properties.Buttons(0).Caption.Trim, ButtonEdit1.Text.Trim) 'Text_Renamed(1).Text
            Case 2
                If pl1 = 1 Then
                    PhanLoai.MaTK = SoHieu2MaSo(Trim(Text_Renamed(2).Text), "HethongTK")
                End If
        End Select
    End Sub

    Private Function HopLe() As Integer
        Dim thong_bao As String = String.Empty
        Dim TK As New ClsTaikhoan
        Dim shieu_ctren As String = String.Empty
        With PhanLoai
            If .TenPhanLoai.Length = 0 Then Text_Renamed_Leave(Text_Renamed(0), New EventArgs())
            If .SoHieu.Length = 0 Then Text_Renamed_Leave(Text_Renamed(1), New EventArgs())

            If (.TenPhanLoai = "(...)") OrElse (String.IsNullOrEmpty(.TenPhanLoai)) Then
                Text_Renamed(0).Focus()
                thong_bao = Ngonngu("Thiếu tên phân loại", "Lack of classification")
                GoTo Err_InValidate
            End If

            If String.IsNullOrEmpty(Text_Renamed(1).Text.Trim) Then
                'Text_Renamed(1).Focus()
                If Text_Renamed(1).Text <> "" Then

                Else
                    Text_Renamed(1).Focus()
                    thong_bao = Ngonngu("Thiếu số hiệu phân loại", "Lack of classification")
                    GoTo Err_InValidate
                End If

            End If

            .SoHieu = String.Format("{0}", Text_Renamed(1).Text.Trim) 'String.Format("{0}{1}", Text_Renamed(1).Text.Trim, Text_Renamed(1).Text.Trim)

            If pl1 = 1 And PhanLoai.MaTK = 0 Then
                Text_Renamed(2).Focus()
                thong_bao = Ngonngu("Thiếu số hiệu tài khoản", "Lack of account")
                GoTo Err_InValidate
            End If
            If pl1 = 1 Then
                TK.InitTaikhoanMaSo(PhanLoai.MaTK)
                If TK.tk_id <> TKVT_ID Then
                    thong_bao = Ngonngu("Chọn tài khoản theo dõi chi tiết vật tư", "Choose materials account")
                    GoTo Err_InValidate
                End If
                If TK.tkcon > 0 Then
                    thong_bao = Ngonngu("Chọn tài khoản chi tiết", "Lack of details account")
                    GoTo Err_InValidate
                End If
            End If
            ' Nếu là thêm mới thì nhận các thuộc tính của phân loại cấp trên
            If .MaSo = 0 Then
                If Text_Renamed(1).Text = "" Then
                    ' Cap 0
                    .cap = 1
                    .plcha = 0
                Else
                    .cap = tmpCap + 1
                    .plcha = tmpMaSo
                End If

                ' Kiểm tra cấp và số hiệu
                If .cap > 3 Then
                    thong_bao = Ngonngu("Số cấp vượt quá quy định", "Number level exceeding the prescribed")
                    GoTo Err_InValidate
                End If
                If (Not (Strings.Left(.SoHieu, tmpSoHieu.Length) = tmpSoHieu)) AndAlso (.cap > 1) Then
                    thong_bao = Ngonngu("Số hiệu không đúng quy định", "False serial number")
                    GoTo Err_InValidate
                End If
            Else
                If .plcha > 0 Then
                    ' Kiem tra Số hiệu
                    sql = String.Format("SELECT SoHieu AS F1 FROM {0} WHERE MaSo = {1}", tbl, ConvertToStrSafe(.plcha))
                    shieu_ctren = ConvertToStrSafe(GetSelectValue(sql))
                    If shieu_ctren <> "0" Then
                        If Not (Strings.Left(.SoHieu, shieu_ctren.Length) = shieu_ctren) Then
                            thong_bao = Ngonngu("Số hiệu không đúng quy định", "False serial number")
                            GoTo Err_InValidate
                        End If
                    End If
                End If
            End If
        End With
        Return 0
Err_InValidate:
        SystemSounds.Beep.Play()
        MessageBox.Show(thong_bao, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return -1
    End Function

    Private Sub ChiDinh(ByRef ma_pl As Integer)
        sql = String.Format("SELECT * FROM {0} WHERE MaSo = {1}", tbl, ma_pl)
        Using rs_phanloai As DataTable = ExecSQLReturnDT(sql)
            If rs_phanloai.Rows.Count > 0 Then
                Dim rs_phanloaiItem As DataRow = rs_phanloai.Rows(0)
                With PhanLoai
                    If rs_phanloaiItem("MaSo") IsNot Nothing Then
                        .MaSo = rs_phanloaiItem("MaSo")
                    End If
                    If rs_phanloaiItem("TenPhanLoai") IsNot Nothing Then
                        .TenPhanLoai = rs_phanloaiItem("TenPhanLoai")
                    End If
                    If rs_phanloaiItem("SoHieu") IsNot Nothing Then
                        .SoHieu = rs_phanloaiItem("SoHieu")
                    End If


                    If rs_phanloaiItem("plcha") IsNot Nothing Then
                        .plcha = rs_phanloaiItem("plcha")
                    End If

                    If rs_phanloaiItem("plcon") IsNot Nothing Then
                        .plcon = rs_phanloaiItem("plcon")
                    End If

                    If rs_phanloaiItem("cap") IsNot Nothing Then
                        .cap = rs_phanloaiItem("cap")
                    End If
                    Try
                        If rs_phanloaiItem("MaTK") IsNot Nothing Then
                            .MaTK = IIf(pl1 = 1, rs_phanloaiItem("MaTK"), 0)
                        End If

                    Catch ex As Exception

                    End Try
                End With
            End If
        End Using
    End Sub

    Private Function ThemMoi() As Integer
        Dim result As Integer = 0
        Me.Cursor = Cursors.WaitCursor
        If ExecSQLNonQuery(String.Format("INSERT INTO {0} (MaSo,TenPhanLoai, SoHieu, PLCha,PLCon, Cap{1}) VALUES({2},N'{3}',N'{4}',{5},{6},{7}{8})", _
                               tbl, _
                               (IIf(pl1 = 1, ",MaTK", String.Empty)), _
                               ConvertToStrSafe(Lng_MaxValue("MaSo", tbl) + 1), _
                               PhanLoai.TenPhanLoai, _
                               PhanLoai.SoHieu, _
                               (PhanLoai.plcha), _
                               (PhanLoai.plcon), _
                               (PhanLoai.cap), _
                               (IIf(pl1 = 1, String.Format(",{0}", PhanLoai.MaTK), String.Empty)))) = 0 Then
            PhanLoai.MaSo = Lng_MaxValue("MaSo", tbl)
            ExecSQLNonQuery(String.Format("UPDATE {0} SET MaPhanLoai={1} WHERE MaPhanLoai={2}", tbl1, ConvertToStrSafe(PhanLoai.MaSo), ConvertToStrSafe(PhanLoai.plcha)))
            ExecSQLNonQuery(String.Format("UPDATE {0} SET PLCon=1 WHERE MaSo={1}", tbl, ConvertToStrSafe(PhanLoai.plcha)))

            Dim i As Integer = 0
            If Outline.Nodes.Count > 0 Then
                i = Outline.SelectedNode.Index
            End If

            Dim currentCate As Category
            If Outline.SelectedNode IsNot Nothing Then currentCate = CType(Outline.SelectedNode.Tag, Category)
            Dim newCate As New Category(PhanLoai.MaSo, PhanLoai.plcha, String.Format("{0} {1} {2}", PhanLoai.SoHieu, PhanLoai.TenPhanLoai, Timten("sohieu", CStr(PhanLoai.MaTK), "maso", "hethongtk")))

            Dim newNode As New TreeNode
            With newNode
                .Text = newCate.NodeText
                .Tag = newCate
            End With

            If PhanLoai.plcha <> 0 Then
                Outline.SelectedNode.Nodes.Add(newNode)
                If Outline.Nodes.Count > 0 Then
                    Outline.SelectedNode = newNode
                End If
                Outline.SelectedNode.Parent.Expand()
            Else
                Outline.Nodes.Add(newNode)
                If Outline.Nodes.Count > 0 Then
                    Outline.SelectedNode = newNode
                End If

            End If

            Outline.Refresh()
            Outline.Focus()
            ' Expand cấp trên
            result = 0
        Else
            PhanLoai.MaSo = 0
            result = -1
        End If
        If pl1 = 1 Then
            Dim ct As New Cls154
            ct.InitTPMaSo(0)
            ct.SoHieu = PhanLoai.SoHieu
            ct.TenVattu = PhanLoai.TenPhanLoai
            ct.MaPhanLoai1 = Lng_MaxValue("MaSo", tbl)
            ct.MaPhanLoai = GetSelectValue("select maso as f1 from phanloai154 where sohieu='NH'")
            If ct.MaPhanLoai = 0 Then
                ExecSQLNonQuery("insert into phanloai154(maso,sohieu,tenphanloai,plcon,plcha,cap) values(" + CStr(Lng_MaxValue("maso", "phanloai154") + 1) + ",'NH','Nhoùm',0,0,1)")
                ct.MaPhanLoai = Lng_MaxValue("maso", "phanloai154")
            End If
            ct.GhiTP()
        End If
        Me.Cursor = Cursors.Default
        Return result
    End Function

    Private Function SuaDoi() As Integer
        Dim result As Integer = 0
        Me.Cursor = Cursors.WaitCursor
        sql = String.Format("UPDATE {0} SET TenPhanLoai =N'{1}', SoHieu =N'{2}'{3} WHERE MaSo = {4}", _
                  tbl, _
                  PhanLoai.TenPhanLoai, _
                  PhanLoai.SoHieu, _
                  (IIf(pl1 = 1, ",MaTK=" & PhanLoai.MaTK, String.Empty)), _
                  ConvertToStrSafe(PhanLoai.MaSo))
        If ExecSQLNonQuery(sql) = 0 Then
            Dim currentCate As Category = CType(Outline.SelectedNode.Tag, Category)
            currentCate.NodeText = String.Format("{0} {1}", PhanLoai.SoHieu, PhanLoai.TenPhanLoai)
            Outline.SelectedNode.Tag = currentCate
            Outline.SelectedNode.Text = currentCate.NodeText
            result = 0
        Else
            result = -1
        End If
        If pl1 = 1 Then
            Dim ct As New Cls154
            ct.InitTPMaSo(GetSelectValue("select maso as f1 from tp154 where maphanloai1=" + CStr(PhanLoai.MaSo)))
            ct.SoHieu = PhanLoai.SoHieu
            ct.TenVattu = PhanLoai.TenPhanLoai
            ct.SuaTP()
        End If
        Me.Cursor = Cursors.Default
        Return result
    End Function

    Private Function Xoa() As Integer
        Dim result As Integer = 0
        Dim mc As Integer
        Me.Cursor = Cursors.WaitCursor
        Dim currentCate As Category = CType(Outline.SelectedNode.Tag, Category)
        Dim tam As String = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM {0} WHERE MaPhanLoai = {1}", _
                                               tbl1, _
                                               currentCate.ID)

        If ConvertToDblSafe(GetSelectValue(tam)) > 0 Then
            MessageBox.Show(Ngonngu("Phân loại đã phát sinh, không xoá!", "Classifition has arisen, not deleted"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            result = -1
        Else
            If pl1 = 1 Then
                currentCate = CType(Outline.SelectedNode.Tag, Category)
                ExecSQLNonQuery("delete from tp154 where maphanloai1=" + CStr(currentCate.ID))
            End If
            mc = ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT PLCha AS F1 FROM {0} WHERE MaSo={1}", _
                                                     tbl, _
                                                     currentCate.ID)))
            sql = String.Format("DELETE  FROM {0} WHERE MaSo = {1}", _
                      tbl, _
                      currentCate.ID)

            If ExecSQLNonQuery(sql) = 0 Then
                ExecSQLNonQuery(String.Format("UPDATE {0} SET MaPhanLoai = {1} WHERE MaPhanLoai = {2}", _
                                    tbl1, _
                                    ConvertToStrSafe(mc), _
                                    currentCate.ID))
                If GetSelectValue(String.Format("select count(maso) as f1 from {0} where plcha={1}", tbl, mc)) = 0 Then
                    ExecSQLNonQuery(String.Format("UPDATE {0} SET plcon = 0 WHERE maso = {1}", tbl, mc))
                End If

                Dim prevNodeR As TreeNode = Outline.SelectedNode.PrevNode
                Outline.SelectedNode.Remove()
                Outline.Refresh()
                Outline.SelectedNode = prevNodeR
                Outline.Focus()
                result = 0
            Else
                result = -1
            End If
        End If
        Me.Cursor = Cursors.Default
        Return result
    End Function

    Private Sub CapNhatSoHieu(ByRef cap_ct As Integer, ByRef maso_ct As Integer, ByRef sohieu_moi As String)
        Me.Cursor = Cursors.WaitCursor
        Dim do_dai As Integer = tmpSoHieu.Length
        If cap_ct = 1 Then
            ExecSQLNonQuery(String.Format("UPDATE {0} SET SoHieu =N'{1}' + RIGHT(SoHieu,Len(SoHieu) - {2}) WHERE PLCha = {3}", _
                                tbl, _
                                sohieu_moi, _
                                ConvertToStrSafe(do_dai), _
                                ConvertToStrSafe(maso_ct)))
        End If
        tmpSoHieu = sohieu_moi
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub LayDanhSachPhanLoai()
        Me.Cursor = Cursors.WaitCursor

        If pl1 = 1 Then
            sql = "SELECT PhanLoaiVattu.Maso AS FirstOfMaSo, PhanLoaiVattu.TenPhanLoai AS FirstOfTen, PhanLoaiVattu.PLCha AS ParentID, HethongTK.SoHieu AS SHTK, PhanLoaiVattu.* FROM PhanLoaiVattu INNER JOIN HethongTK ON PhanLoaiVattu.MaTK=HethongTK.MaSo WHERE PhanLoaiVattu.Cap > 0 AND LEFT(HethongTK.SoHieu ,1)<> '#' ORDER BY PhanLoaiVattu.SoHieu"
        Else
            sql = String.Format("SELECT MaSo AS FirstOfMaSo, TenPhanLoai AS FirstOfTen, PLCha AS ParentID, SoHieu FROM {0} WHERE Cap > 0 AND LEFT(SoHieu,1)<> '#'  ORDER BY SoHieu", tbl)
        End If
        Dim tvHlp As New TreeviewHelper(sql)
#If DEBUG Then
        MessageBox.Show(String.Format("Debug SQL:{0}{1}", _
                                      Environment.NewLine, _
                                      sql), String.Format("{0} Debug info", Me.Name), MessageBoxButtons.OK, MessageBoxIcon.Information)
#End If

        tvHlp.popularTreeview(Outline, 0, pl1)

        Outline.ExpandAll()
        If Outline.Nodes.Count > 0 Then
            Outline.SelectedNode = Outline.Nodes(0)
        End If
        Outline.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub KhoiTao(ByRef tiep_tuc As Boolean)
        PhanLoai.MaSo = 0
        PhanLoai.TenPhanLoai = ""
        PhanLoai.SoHieu = ""
        PhanLoai.plcha = 0
        PhanLoai.plcon = 0
        PhanLoai.cap = 0
        Text_Renamed(0).Text = ""
        Dim currentCate As Category
        If Outline.SelectedNode IsNot Nothing Then currentCate = CType(Outline.SelectedNode.Tag, Category)
        If tiep_tuc Then
            If pl1 = 1 And Outline.SelectedNode.Index >= 0 Then
                Text_Renamed(2).Text = ConvertToStrSafe(GetSelectValue(String.Format("SELECT HethongTK.SoHieu AS F1, MaTK AS F2 FROM PhanLoaiVattu INNER JOIN HethongTK ON PhanLoaiVattu.MaTK=HethongTK.MaSo WHERE PhanLoaiVattu.MaSo={0}", currentCate.ID), PhanLoai.MaTK))
            End If
            Text_Renamed(1).Focus()
            Text_Renamed(1).SelectAll()
        Else
            Text_Renamed(1).Text = String.Empty
            Text_Renamed(1).SelectAll()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Outline_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Outline.AfterSelect
        ' Lưu dữ liệu cho yêu cầu thêm mới hay xoá
        Try
            Dim currentCate As Category = CType(Outline.SelectedNode.Tag, Category)
            With currentCate
                Dim firstSpaceIndex As Integer = .NodeText.Trim.IndexOf(" ")
                Dim a As Integer = .NodeText.Trim.LastIndexOf(" ")
                Dim s As String = .NodeText.Substring(a, .NodeText.Length - a)
                If firstSpaceIndex > -1 Then
                    _Text_1.Text = Strings.Left(.NodeText, firstSpaceIndex).Trim
                    _Text_2.Text = s
                    PhanLoai.MaTK = SoHieu2MaSo(Trim(s), "hethongtk")                    
                    's = Strings.Right(.NodeText, .NodeText.Length - Len(_Text_1.Text)).Trim
                    _Text_0.Text = SoHieu2TenPhanLoai(_Text_1.Text, tbl)
                End If
            End With
            tmpMaSo = currentCate.ID
            tmpCap = Outline.SelectedNode.Level
            tmpSoHieu = _Text_1.Text

            'Text_Renamed(1).Text = ""
            'Text_Renamed(1).Text = tmpSoHieu
            'Text_Renamed(1).Visible = True
            'ButtonEdit1.Properties.Buttons(0).Enabled = True
            'ButtonEdit1.Properties.Buttons(1).Visible = (Outline.SelectedNode.Level >= 0)
            PhanLoai.MaSo = tmpMaSo
        Catch
            _Text_0.Text = "(...)"
            _Text_1.Text = "(...)"
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Outline_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Outline.DoubleClick
        Dim currentCate As Category = CType(Outline.SelectedNode.Tag, Category)
        ChiDinh(currentCate.ID)
        ' so hieu tai phan loai
        _Text_1.Text = PhanLoai.SoHieu
        ' ten phan loai
        _Text_0.Text = PhanLoai.TenPhanLoai
        ' so hieu tai khoan
        _Text_2.Text = GetSelectValue(String.Format("Select top 1 SoHieu as F1 From HeThongTK where maso = {0} ", PhanLoai.MaTK))
        '''''''''''''''
        _Text_0.SelectAll()
        _Text_0.Focus()
    End Sub

    'Private Sub ButtonEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
    '    If e.Button.Index = 1 Then
    '        If Outline.SelectedNode.Level = 0 Then
    '            ButtonEdit1.Properties.Buttons(0).Caption = String.Empty
    '            ButtonEdit1.Properties.Buttons(1).Visible = False
    '        Else
    '            Outline.SelectedNode = Outline.SelectedNode.Parent
    '            ButtonEdit1.Properties.Buttons(1).Visible = True
    '        End If
    '        ButtonEdit1.Properties.Buttons(0).Visible = (ButtonEdit1.Properties.Buttons(0).Caption <> String.Empty)
    '    Else
    '        ' Chi dinh Phan loai hien tai
    '        Dim currentCate As Category = CType(Outline.SelectedNode.Tag, Category)
    '        Dim sohieuPlCha As String
    '        ChiDinh(currentCate.ID)


    '        If Outline.SelectedNode.Level > 0 Then
    '            currentCate = CType(Outline.SelectedNode.Parent.Tag, Category)
    '            'Lay phan loai cha
    '            sohieuPlCha = Strings.Left(currentCate.NodeText, currentCate.NodeText.IndexOf(" ")).Trim
    '            ButtonEdit1.Text = ButtonEdit1.Properties.Buttons(0).Caption.Substring(sohieuPlCha.Length)
    '            ButtonEdit1.Properties.Buttons(0).Caption = sohieuPlCha
    '            ButtonEdit1.Properties.Buttons(0).Enabled = False
    '        Else
    '            ButtonEdit1.Text = ButtonEdit1.Properties.Buttons(0).Caption
    '            ButtonEdit1.Properties.Buttons(0).Caption = ""
    '            ButtonEdit1.Properties.Buttons(0).Visible = False
    '        End If

    '        ButtonEdit1.SelectAll()
    '    End If
    'End Sub

    Private Sub _Text_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Text_2.TextChanged

    End Sub
End Class
