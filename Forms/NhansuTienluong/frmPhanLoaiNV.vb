Imports System
Imports System.Data
Imports System.Media
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class frmPhanLoaiNV
    Private Structure tpPhanLoaiNV
        Dim MaSo As Integer
        Dim ten As String
        Dim SoHieu As String
        Dim CapTren As Integer
        Dim cap As Integer
        Dim matk As Integer
        Public Shared Function CreateInstance() As tpPhanLoaiNV
            Dim result As New tpPhanLoaiNV
            result.ten = String.Empty
            result.SoHieu = String.Empty
            Return result
        End Function
    End Structure
    Dim PhanLoai As tpPhanLoaiNV = tpPhanLoaiNV.CreateInstance()
    Dim pPhanLoai As Integer
    Dim TenBang As String = String.Empty
    Dim tmpSoHieu As String = String.Empty ' Lưu các thông tin của cấp trên (để thêm mới)
    Dim tmpMaSo As Integer
    Dim tmpCap As Integer
    Dim tmpmatk As Integer
    Dim sql As String = String.Empty

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmPhanLoai_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        'set icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        Dim psType As Integer = ConvertToDblSafe(Me.Tag, 1)
#If DEBUG Then
        'psType = 2
#End If
        Select Case psType
            Case 1
                Me.Text = Ngonngu("Phân loại tài sản", "Asset Classification")
                TenBang = "LoaiTaiSan"
            Case 2
                Me.Text = Ngonngu("Phân loại chứng từ", "Classification of Vouchers")
                TenBang = "LoaiChungTu"
            Case 3
                Me.Text = Ngonngu("Phân loại công cụ, dụng cụ", "Classification Tools")
                TenBang = "LoaiCongcudungcu"
            Case 4
                Me.Text = Ngonngu("Phân loại nhân viên", "Classification Employees")
                TenBang = "Phanloaiquanlynhanvien"
        End Select
        Text = SetFormTitle(Text)
        Me.Refresh()
        pPhanLoai = ConvertToDblSafe(Me.Tag)
        Me.Tag = "0"
        LayDanhSachPhanLoai()
        Khoaquyen()
        SetFont(Me)
    End Sub
    '======================================================================================
    ' FORM
    '======================================================================================
    ' Key Down
    Private Sub frmPhanLoai_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Insert Then
            'Outline.ListIndex = ConvertToDblSafe(-1)
            If Outline.Nodes.Count > 0 Then
                Outline.SelectedNode = Outline.Nodes(Outline.SelectedNode.Index)
            End If

            tmpMaSo = 0
            tmpCap = 0
            tmpmatk = 0
            tmpSoHieu = ""
            Command(0).Focus()
            Application.DoEvents()
            Command_ClickEvent(Command(0), New EventArgs())
        End If
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T : Command(0).Focus() : Application.DoEvents() ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.G : Command(1).Focus() : Application.DoEvents() ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X : Command(2).Focus() : Application.DoEvents() ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V : Command(3).Focus() : Application.DoEvents() ' Command_ClickEvent(Command(3), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    '======================================================================================
    ' command
    '======================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_3.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim vi_tri As Integer
        Select Case Index
            Case 0 ' Mới

                If TenBang = "LoaiCongcudungcu" Or TenBang = "LoaiTaiSan" Then MessageBox.Show(Ngonngu("Không được thêm phân loại !", "Can not add plassification !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                KhoiTao(True)
                Khoaquyen()
            Case 1 ' Ghi
                If HopLe() = 0 Then
                    If PhanLoai.MaSo = 0 Then
                        If ThemMoi() = 0 Then

                        End If
                        'KhoiTao(True)
                    Else
                        If SuaDoi() = 0 Then
                            If pPhanLoai = 1 Then
                                CapNhatSoHieu(PhanLoai.cap, PhanLoai.MaSo, PhanLoai.SoHieu)
                            End If
                            If Outline.Nodes.Count > 0 Then
                                vi_tri = Outline.SelectedNode.Index
                            End If

                            LayDanhSachPhanLoai()
                            'Outline.SelectedNode = Outline.Nodes(vi_tri)
                            'Outline.Focus()
                            KhoiTao(False)
                        End If
                    End If
                End If
            Case 2 ' Xoá
                'If Outline.ListIndex < 0 Then Exit Sub
                If Outline.SelectedNode.Level <= 0 Then
                    SystemSounds.Beep.Play()
                    MessageBox.Show(Ngonngu("Không được phép xoá phân loại cấp trên cùng", "Can not delete classifition level 1"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Outline.Focus()
                Else
                    If System.Windows.Forms.DialogResult.No = MessageBox.Show(Ngonngu("Xoá phân loại hiện tại", "Delete current classifition"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then Exit Sub
                    If Outline.SelectedNode.Nodes.Count > 0 Then
                        SystemSounds.Beep.Play()
                        MessageBox.Show(Ngonngu("Vẫn còn các phân loại cấp dưới", "Still lower level classifition"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    If Xoa() = 0 Then KhoiTao(False)
                End If
            Case 3 ' Trở về
                SendKeys.Send("{Escape}")
        End Select
    End Sub
    '======================================================================================
    ' TEXT
    '======================================================================================
    ' Got Focus
    Private Sub Text_Renamed_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_0.Enter, _Text_1.Enter
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Text_Renamed(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Text_Renamed_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _Text_0.KeyPress, _Text_1.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        If Index = 1 Then
            If KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
        End If

        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ' Lost Focus
    Private Sub Text_Renamed_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_0.Leave, _Text_1.Leave
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        If Strings.Len(Text_Renamed(Index).Text) = 0 Then Text_Renamed(Index).Text = "(...)"
        Select Case Index
            Case 0 : PhanLoai.ten = Text_Renamed(0).Text
            Case 1 : PhanLoai.SoHieu = Text_Renamed(1).Text
        End Select
    End Sub
    '======================================================================================
    ' FUNCTION HopLe
    '======================================================================================
    Private Function HopLe() As Integer
        Dim thong_bao, shieu_ctren As String
        With PhanLoai
            If .ten.Length = 0 Then Text_Renamed_Leave(Text_Renamed(0), New EventArgs())
            If .SoHieu.Length = 0 Then Text_Renamed_Leave(Text_Renamed(1), New EventArgs())
            If .ten = "(...)" Then
                thong_bao = "Thiếu tên phân loại" : GoTo Err_InValidate
            End If
            If .SoHieu = "(...)" Then
                thong_bao = "Thiếu số hiệu phân loại" : GoTo Err_InValidate
            End If
            ' Nếu là thêm mới thì nhận các thuộc tính của phân loại cấp trên
            .matk = Text_Renamed(2).Text
            If .MaSo = 0 Then
                .cap = tmpCap + 1
                .CapTren = tmpMaSo
                ' Kiểm tra cấp và số hiệu
                If (pPhanLoai = 1 And .cap > 3) Or (pPhanLoai = 2 And .cap > 2) Then
                    thong_bao = "Số cấp vượt quá quy định" : GoTo Err_InValidate
                End If
                If Not (Strings.Left(.SoHieu, tmpSoHieu.Length) = tmpSoHieu) Then
                    thong_bao = "Số hiệu không đúng quy định" : GoTo Err_InValidate
                End If
            Else
                ' Kiểm tra Số hiệu
                sql = String.Format("SELECT SoHieu AS F1 FROM {0} WHERE MaSo = {1}", TenBang, ConvertToStrSafe(.CapTren))
                shieu_ctren = ConvertToStrSafe(GetSelectValue(sql))
                If shieu_ctren <> "0" Then
                    If Not (Strings.Left(.SoHieu, shieu_ctren.Length) = shieu_ctren) Then
                        thong_bao = "Số hiệu không đúng quy định" : GoTo Err_InValidate
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
    '======================================================================================
    ' SUB ChiDinh
    '======================================================================================
    Private Sub ChiDinh(ByRef ma_pl As Integer)
        sql = String.Format("SELECT * FROM {0} WHERE MaSo = {1}", TenBang, ConvertToStrSafe(ma_pl))
        Dim rs_phanloai As DataTable = ExecSQLReturnDT(sql)
        If rs_phanloai.Rows.Count > 0 Then
            Dim rs_phanloaiItem As DataRow = rs_phanloai.Rows(0)
            If rs_phanloaiItem("MaSo") IsNot Nothing And Not IsDBNull(rs_phanloaiItem("MaSo")) Then
                PhanLoai.MaSo = rs_phanloaiItem("MaSo")
            End If
            PhanLoai.ten = rs_phanloaiItem("ten")
            PhanLoai.SoHieu = rs_phanloaiItem("SoHieu")
            If rs_phanloaiItem("CapTren") IsNot Nothing And Not IsDBNull(rs_phanloaiItem("CapTren")) Then
                PhanLoai.CapTren = rs_phanloaiItem("CapTren")
            End If
            If rs_phanloaiItem("cap") IsNot Nothing And Not IsDBNull(rs_phanloaiItem("cap")) Then
                PhanLoai.cap = rs_phanloaiItem("cap")
            End If
            If rs_phanloaiItem("matk") IsNot Nothing And Not IsDBNull(rs_phanloaiItem("matk")) Then
                PhanLoai.matk = rs_phanloaiItem("matk")
            End If
        End If
    End Sub
    '======================================================================================
    ' FUNCTION ThemMoi
    '======================================================================================
    Private Function ThemMoi() As Integer
        Dim result As Integer = 0
        'Dim vi_tri As Integer
        Me.Cursor = Cursors.WaitCursor
        If ExecSQLNonQuery(String.Format("INSERT INTO {0} (MaSo,Ten, SoHieu, CapTren, Cap" + If(pPhanLoai = 4, ", MaTK", "") + ") VALUES({1},N'{2}',N'{3}',{4},{5}" + If(pPhanLoai = 4, ",'{6}'", "") + ")", TenBang, ConvertToStrSafe(Lng_MaxValue("MaSo", TenBang) + 1), PhanLoai.ten, PhanLoai.SoHieu, ConvertToStrSafe(PhanLoai.CapTren), ConvertToStrSafe(PhanLoai.cap), ConvertToStrSafe(PhanLoai.matk))) = 0 Then
            PhanLoai.MaSo = Lng_MaxValue("MaSo", TenBang)
            If PhanLoai.cap = 3 Then
                ExecSQLNonQuery(String.Format("UPDATE TaiSan SET MaNhom={0} WHERE MaNhom=0 AND MaLoai={1}", PhanLoai.MaSo, ConvertToStrSafe(PhanLoai.CapTren)))
            End If

            Dim i As Integer = Nothing
            If Outline.Nodes.Count > 0 Then
                i = Outline.SelectedNode.Index
            End If
            Dim currentCate As Category = CType(Outline.SelectedNode.Tag, Category)
            Dim newCate As New Category(PhanLoai.MaSo, PhanLoai.CapTren, String.Format("{0}   {1}" + If(pPhanLoai = 4, "   {2}", ""), PhanLoai.SoHieu, PhanLoai.ten, PhanLoai.matk))
            Dim newNode As New TreeNode
            With newNode
                .Text = newCate.NodeText
                .Tag = newCate
            End With

            Outline.SelectedNode.Nodes.Add(newNode)
            Outline.SelectedNode = newNode
            Outline.SelectedNode.Parent.Expand()
            Outline.Refresh()
            Outline.Focus()
            ' Expand cấp trên
            result = 0
        Else
            PhanLoai.MaSo = 0
            result = -1
        End If
        Me.Cursor = Cursors.Default
        Return result
    End Function
    '======================================================================================
    ' FUNCTION SuaDoi
    '======================================================================================
    Private Function SuaDoi() As Integer
        Dim result As Integer = 0
        Me.Cursor = Cursors.WaitCursor
        sql = String.Format("UPDATE {0} SET Ten = N'{1}', SoHieu = N'{2}'" + If(pPhanLoai = 4, ", MaTK='{4}'", "") + " WHERE MaSo = {3}", _
                  TenBang, _
                  PhanLoai.ten, _
                  PhanLoai.SoHieu, _
                  ConvertToStrSafe(PhanLoai.MaSo), _
                  PhanLoai.matk)
        If ExecSQLNonQuery(sql) = 0 Then
            Dim currentCate As Category = CType(Outline.SelectedNode.Tag, Category)
            currentCate.NodeText = String.Format("{0}   {1}" + If(pPhanLoai = 4, "   {2}", ""), PhanLoai.SoHieu, PhanLoai.ten, PhanLoai.matk)
            Outline.SelectedNode.Tag = currentCate
            Outline.SelectedNode.Text = currentCate.NodeText

            result = 0
        Else
            result = -1
        End If
        Me.Cursor = Cursors.Default
        Return result
    End Function
    '======================================================================================
    ' FUNCTION Xoa
    '======================================================================================
    Private Function Xoa() As Integer
        Dim result As Integer = 0
        Me.Cursor = Cursors.WaitCursor
        Dim currentCate As Category = CType(Outline.SelectedNode.Tag, Category)

        If pPhanLoai = 1 And ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM TaiSan WHERE MaNhom = {0}", currentCate.ID))) > 0 Then
            MessageBox.Show(Ngonngu("Phân loại đã phát sinh, không xoá!", "Classifition has arisen, can not delete!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            result = -1
        ElseIf pPhanLoai = 4 And ConvertToIntSafe(GetSelectValue("select count(maso) as f1 from quanlynhanvien where maphanloai=" + CStr(currentCate.ID))) > 0 Then
            MessageBox.Show(Ngonngu("Phân loại đã phát sinh, không xoá!", "Classifition has arisen, can not delete!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            result = -1
        Else
            sql = String.Format("DELETE FROM {0} WHERE MaSo = {1}", TenBang, ConvertToStrSafe(currentCate.ID))
            If ExecSQLNonQuery(sql) = 0 Then
                If pPhanLoai = 1 Then ExecSQLNonQuery(String.Format("UPDATE TaiSan SET MaNhom = 0 WHERE MaNhom = {0}", currentCate.ID))
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
    '======================================================================================
    ' SUB CapNhatSoHieu
    '======================================================================================
    Private Sub CapNhatSoHieu(ByRef cap_ct As Integer, ByRef maso_ct As Integer, ByRef sohieu_moi As String)
        Me.Cursor = Cursors.WaitCursor
        Dim do_dai As Integer = tmpSoHieu.Length
        If cap_ct = 2 Then
            ExecSQLNonQuery(String.Format("UPDATE LoaiTaiSan SET SoHieu = N'{0}' + Right(SoHieu,Len(SoHieu) - {1}) WHERE CapTren = {2}", _
                                sohieu_moi, _
                                ConvertToStrSafe(do_dai), _
                                ConvertToStrSafe(maso_ct)))
            ExecSQLNonQuery(String.Format("UPDATE TaiSan SET SoHieu = N'{0}' + Right(SoHieu,Len(SoHieu) - {1}) WHERE MaLoai = {2}", _
                                sohieu_moi, _
                                ConvertToStrSafe(do_dai), _
                                ConvertToStrSafe(maso_ct)))
        Else
            ExecSQLNonQuery(String.Format("UPDATE TaiSan SET SoHieu = N'{0}' + Right(SoHieu,Len(SoHieu) - {1}) WHERE MaNhom = {2}", _
                                sohieu_moi, _
                                ConvertToStrSafe(do_dai), _
                                ConvertToStrSafe(maso_ct)))
        End If
        tmpSoHieu = sohieu_moi
        Me.Cursor = Cursors.Arrow
    End Sub
    '======================================================================================
    ' SUB LayDanhSachPhanLoai
    '======================================================================================
    Private Sub LayDanhSachPhanLoai()
        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = String.Format("SELECT MaSo AS FirstOfMaSo, Ten AS FirstOfTen,captren AS ParentID, SoHieu" + If(pPhanLoai = 4, ", MaTK as SHTK", "") + " FROM {0} WHERE Cap >= 0 ORDER BY SoHieu", TenBang)
        Dim tvHlp As New TreeviewHelper(sql)
#If DEBUG Then
        'MessageBox.Show(String.Format("Debug SQL:{0}{1}", _
        '                              Environment.NewLine, _
        '                              sql), String.Format("{0} Debug info", Me.Name), MessageBoxButtons.OK, MessageBoxIcon.Information)
#End If
        tvHlp.popularTreeview(Outline, 0, 1)
        Outline.ExpandAll()
        If Outline.Nodes.Count > 0 Then
            Outline.SelectedNode = Outline.Nodes(0)
        End If
        Outline.Focus()
        Me.Cursor = Cursors.Default
    End Sub
    '======================================================================================
    ' SUB KhoiTao
    '======================================================================================
    Private Sub KhoiTao(ByRef tiep_tuc As Boolean)
        PhanLoai.MaSo = 0
        PhanLoai.ten = ""
        PhanLoai.SoHieu = ""
        PhanLoai.CapTren = 0
        PhanLoai.cap = 0
        PhanLoai.matk = 0
        Text_Renamed(0).Text = ""
        If tiep_tuc Then
            Text_Renamed(1).Focus()
            Text_Renamed(1).Text = tmpSoHieu
            SendKeys.Send("{END}")
        Else
            Text_Renamed(1).Text = ""
        End If
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmPhanLoai_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
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
                If .NodeText <> Nothing Then
                    Dim firstSpaceIndex As Integer = .NodeText.Trim.IndexOf(" ")
                    Dim ktc As Integer = .NodeText.Trim.LastIndexOf(" ")
                    If firstSpaceIndex > -1 Then
                        _Text_1.Text = Strings.Left(.NodeText, firstSpaceIndex).Trim
                        _Text_0.Text = .NodeText.Substring(firstSpaceIndex + 1, ktc - firstSpaceIndex - 1)
                        _Text_2.Text = .NodeText.Substring(ktc + 1, .NodeText.Length - ktc - 1)
                    End If
                End If
            End With
            tmpMaSo = currentCate.ID
            tmpCap = Outline.SelectedNode.Level
            PhanLoai.MaSo = tmpMaSo
        Catch
            _Text_0.Text = "(...)"
            _Text_1.Text = "(...)"
            _Text_2.Text = "0"
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
        _Text_0.SelectAll()
        _Text_0.Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Outline_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Outline.Enter
        KhoiTao(False)
    End Sub

    Private Sub _Text_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _Text_1.KeyPress, _Text_2.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(e.KeyChar)
        Dim Index As Integer = Array.IndexOf(Text_Renamed, sender)
        Select Case Index
            Case 1, 2
                If KeyAscii = 13 Then
                    FrmTaikhoan.initOption = Trim(Text_Renamed(Index).Text)
                    Text_Renamed(Index).Text = FrmTaikhoan.ChonTk(Trim(Text_Renamed(Index).Text))
                    Text_Renamed(Index).Focus()
                End If
        End Select
    End Sub

    Private Sub _Text_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _Text_1.Leave, _Text_2.Leave
        Dim Index As Integer = Array.IndexOf(Text_Renamed, sender), tentk As String = String.Empty
        If Strings.Len(Text_Renamed(Index).Text) = 0 Then Text_Renamed(Index).Text = "(...)"
        Select Case Index
            Case 1, 2
                Text_Renamed(Index).Tag = GetSelectValue("select maso as f1, ten as f2 from hethongtk where sohieu like '" + CStr(Text_Renamed(Index).Text) + "'", tentk)
                If Index = 1 Then Text_Renamed(0).Text = tentk
        End Select
    End Sub
End Class
