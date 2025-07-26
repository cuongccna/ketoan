Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Globalization
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmTaikhoan
    Public initOption As String = -1
    Dim nodefind As Boolean
    Dim sohieutim As String
    ''' <summary>
    '''  0 trong che do xem
    '''  1 neu them moi 
    ''' -1 neu sua tai khoan
    ''' </summary>
    ''' <remarks></remarks>
    Dim ThemMoi As Integer
    Private _TkNhap As ClsTaikhoan = Nothing
    ''' <summary>
    ''' Tai khoan tham chieu
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property TkNhap() As ClsTaikhoan
        Get
            If _TkNhap Is Nothing Then
                _TkNhap = New ClsTaikhoan()
            End If
            Return _TkNhap
        End Get
        Set(ByVal Value As ClsTaikhoan)
            _TkNhap = Value
        End Set
    End Property
    Dim enable As Boolean
    Dim Ngay(1) As Date
    ''' <summary>
    ''' Hiển thị danh sách tài khoản trong loại
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CboLoai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLoai.SelectedIndexChanged
        ListTk()
    End Sub

    Private Sub CboNT_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboNT.SelectedIndexChanged
        If CboNT.Items.Count > 0 Then
            If CboNT.SelectedIndex = 0 Then
                txtDuNT(2).Text = "0"
                txtDuNT(2).Enabled = False
            Else
                txtDuNT(2).Enabled = True
            End If
        End If

    End Sub

    Private Sub CmdNT_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CmdNT.Click
        Dim taikhoan As New ClsTaikhoan
        Dim capnhatphatsinh As Boolean
        If Not ChoDieuChinhDauKy() Then Exit Sub
        If (Strings.Left(TkNhap.sohieu, 3)) = "154" And pDTTP <> 0 Then
            MessageBox.Show(Ngonngu("Theo dõi chi tiết qua danh điểm thành phẩm!", "Subscribe to the list details or finished products!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If ThemMoi = 0 And TkNhap.tkcon > 0 Then
            MessageBox.Show(Ngonngu("Tài khoản có chi tiết không nhập số liệu trực tiếp!", "Account have details, do not enter data!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If (Strings.Left(TkNhap.sohieu, 4) = "1421" Or Strings.Left(TkNhap.sohieu, 3) = "242") And pDTTP <> 0 Then
            MessageBox.Show(String.Format(Ngonngu("Không nhập trực tiếp số dư vào tài khoản chi phí trả trước.{0}Hãy vào phân hệ công cụ dụng cụ - chi phí trả trước !", "Not enter directly balance into account the upfront corsts. {0}Go to the tools module - prepaid expenses"), Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If TkNhap.tk_id = TKVT_ID And STDetail Then
            MessageBox.Show(Ngonngu("Không nhập trực tiếp số dư vào tài khoản vật tư, hàng hóa. Hãy vào phân hệ vật tư - hàng hóa !", "Not enter directly banlance goods account. Go to module material and goods !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If (TkNhap.tk_id = TSCD_ID Or TkNhap.tk_id = KHTSCD_ID) And FADetail Then
            MessageBox.Show(Ngonngu("Không nhập trực tiếp số dư vào tài khoản tài sản cố định. Hãy vào phân hệ tài sản cố định !", "Not enter directly balance fixed assets account. Go to the fixed assets module !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If (TkNhap.tk_id = TKCNKH_ID Or TkNhap.tk_id = TKCNPT_ID) And KHDetail Then
            MessageBox.Show(Ngonngu("Không nhập trực tiếp số dư vào tài khoản công nợ. Hãy vào phân hệ công nợ !", "Not enter directly balance debt account. Go to debt module !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim st As String = txt(1).Text
        Dim no As Double = ConvertToDblSafe(txtDuNT(0).Text)
        Dim co As Double = ConvertToDblSafe(txtDuNT(1).Text)
        Dim nt As Double = ConvertToDblSafe(txtDuNT(2).Text)
        On Error GoTo 0
        If no <> 0 And co <> 0 Then
            txtDuNT(0).Focus()
            Exit Sub
        End If
        Dim mnt As Integer = CboNT.SelectedValue
        With GrdNT(0)
            .Col = 4

            For i As Integer = 0 To .Rows - 1
                .Row = i
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = mnt Or (mnt <= 0 And ConvertToDblSafe(.CtlText) <= 0) Then
                    .Items.RemoveAt(.Row)
                    .AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}", _
                                 CboNT.Text, _
                                 Chr(9), _
                                 Format(no, IIf(TkNhap.sohieu Like "007*", Mask_2, Mask_0)), _
                                 Format(co, IIf(TkNhap.sohieu Like "007*", Mask_2, Mask_0)), _
                                 Format(nt, Mask_2), _
                                 ConvertToStrSafe(mnt)), i)
                    If ThemMoi = 0 Then
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(MaTKNguyenTe(TkNhap.sohieu, mnt)))
                        taikhoan.NoDauKy = no
                        taikhoan.CoDauKy = co
                        taikhoan.NTDauKy = nt
                        taikhoan.CapNhatTk()
                        trvHTTK_AfterSelect(trvHTTK, Nothing)
                        txt(1).Text = st
                    End If
                    CboNT.Focus()
                    Exit Sub
                End If
            Next
            'Or TkNhap.tkcon > 0
            If (ThemMoi = 0) And (TkNhap.MaTC = 0 Or TkNhap.MaTC = TkNhap.maso Or TkNhap.tkcon > 0) Then Exit Sub
            .AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}", _
                         CboNT.Text, _
                         Chr(9), _
                         Format(no, Mask_0), _
                         Format(co, Mask_0), _
                         Format(nt, Mask_2), _
                         ConvertToStrSafe(mnt)), 0)
            If .Row > 0 Then .Row = (.Row - 1)
            .Col = 4
            If .CtlText.length = 0 Then .RemoveItem(.Row)
            .Row = 0
            If ThemMoi = 0 Then
                TkNhap.DanXuat(taikhoan)
                taikhoan.maso = 0
                taikhoan.MaNT = CboNT.SelectedValue
                taikhoan.NoDauKy = no
                taikhoan.CoDauKy = co
                taikhoan.NTDauKy = nt
                taikhoan.ThemTk()
                txt(1).Text = st
                trvHTTK_AfterSelect(trvHTTK, Nothing)
            End If
            CboNT.Focus()
        End With
    End Sub
    ''' <summary>
    ''' Thêm, Ghi, Xóa tài khoản
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_5.Click, _Command_4.Click, _Command_2.Click, _Command_3.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim Length, i As Integer
        Dim taikhoan As New ClsTaikhoan
        Dim rs_tk As DataTable
        Dim tail As String = String.Empty
        If (User_Right = 2) And (Index < 3) Then
            HienThongBao("Không có quyền truy cập!", 1)
            Exit Sub
        End If
        'If Index < 3 Then
        '    If (Not KtraMKAdmin()) Then Exit Sub
        'End If
        Me.Cursor = Cursors.WaitCursor
        Dim TK As ClsTaikhoan
        Select Case Index
            Case 0
                If Strings.Left(txt(0).Text, 3) = "153" Or Strings.Left(txt(0).Text, 3) = "154" Or Strings.Left(txt(0).Text, 3) = "155" Or Strings.Left(txt(0).Text, 4) = "1561" Or Strings.Left(txt(0).Text, 2) = "21" Or Strings.Left(txt(0).Text, 3) = "334" Or Strings.Left(txt(0).Text, 4) = "1421" Or Strings.Left(txt(0).Text, 4) = "1422" Or Strings.Left(txt(0).Text, 3) = "242" Then
                    If MessageBox.Show(String.Format("Khi thêm chi tiết cho tài khoản này chương trình có thể chạy sai !{0}Bạn có chắc chắn muốn thêm không ?", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then GoTo XongTK
                End If
                If TkNhap.MaTC = 0 Then
                    ChkBtc.CheckState = CheckState.Checked
                Else
                    ChkBtc.CheckState = CheckState.Unchecked
                End If
                ThemMoi = 1
                txt(0).Text = ""
                txt(1).Text = ""
                txt(2).Text = "..."
                txt(3).Text = "..."
                ClearGrid(GrdNT(0), 10)
                ClearGrid(GrdNT(1), 10)
                If CboNT.Items.Count > 0 Then
                    CboNT.SelectedIndex = 0
                End If
                GrdNT(0).AddItem(String.Format("{0}{1}0{1}0{1}0{1}0", _
                                     pTienStr, _
                                     Chr(9)), 0)
                If TkNhap.tkcon > 0 Then
                    rs_tk = ExecSQLReturnDT(String.Format("SELECT Top 1 HeThongTK.SoHieu FROM HethongTK WHERE TkCha0={0} AND MaNT<=0 ORDER BY LEN(SoHieu) DESC, SoHieu DESC", TkNhap.maso))
                    If rs_tk.Rows.Count > 0 Then
                        Dim rstkItem As DataRow = rs_tk.Rows(0)
                        Dim Sohieu As String = ConvertToStrSafe(rstkItem("SoHieu"))
                        Length = Sohieu.Length
                        Try
                            tail = ConvertToStrSafe(ConvertToDblSafe(Strings.Right(Sohieu, Length - TkNhap.sohieu.Length)) + 1)
                        Catch
                        End Try
                    Else
                        Length = TkNhap.sohieu.Length + 2
                    End If
                    ''rs_tk.Close()
                    rs_tk = Nothing
                    Do While (String.Format("{0}{1}", TkNhap.sohieu, tail)).Length < Length
                        tail = String.Format("0{0}", tail)
                    Loop
                    txt(0).Text = String.Format("{0}{1}", TkNhap.sohieu, tail)
                Else
                    txt(0).Text = String.Format("{0}1", TkNhap.sohieu)
                End If
                txt(0).Focus()
                Khoaquyen()
            Case 1
                If KiemTraDuLieu() Then
                    Select Case ThemMoi
                        Case 0
                            If TkNhap.CapNhatTk() = 0 Then
                                trvHTTK.SelectedNode.Text = String.Format("{0} {1}", TkNhap.sohieu, TkNhap.ten)
                            Else
                                ErrMsg(er_SoHieu)
                                txt(0).Focus()
                                GoTo XongTK
                            End If
                        Case 1
                            ' Them tai khoan tren man hinh
                            TkNhap.PSNLK = 0
                            TkNhap.PSCLK = 0
                            TkNhap.cap = trvHTTK.SelectedNode.Level + 2
                            If TkNhap.ThemTk() = -1 Then
                                ErrMsg(er_SoHieu)
                                txt(0).Focus()
                                GoTo XongTK
                            End If
                            TkNhap.DanXuat(taikhoan)
                            taikhoan.maso = 0
                            With GrdNT(0)
                                For i = 0 To .Rows - 1
                                    .Row = i
                                    .Col = 4
                                    If .CtlText.length = 0 Then Exit For
                                    taikhoan.MaNT = ConvertToDblSafe((.CtlText))
                                    If taikhoan.MaNT <> 0 Then
                                        .Col = 1
                                        taikhoan.NoDauKy = ConvertToDblSafe(.CtlText)
                                        .Col = 2
                                        taikhoan.CoDauKy = ConvertToDblSafe(.CtlText)
                                        .Col = 3
                                        taikhoan.NTDauKy = ConvertToDblSafe(.CtlText)
                                        taikhoan.ThemTk()
                                    End If
                                Next
                            End With
                            If trvHTTK.Nodes.Count > 0 Then
                                i = trvHTTK.SelectedNode.Index
                            End If

                            Dim currentCate As Category = CType(trvHTTK.SelectedNode.Tag, Category)
                            Dim newCate As New Category(TkNhap.maso, currentCate.ID, String.Format("{0} {1}", TkNhap.sohieu, TkNhap.ten))
                            Dim newNode As New TreeNode
                            With newNode
                                .Text = newCate.NodeText
                                .Tag = newCate
                            End With

                            trvHTTK.SelectedNode.Nodes.Add(newNode)
                            trvHTTK.SelectedNode = newNode
                            trvHTTK.Nodes(i).Expand()
                            trvHTTK.Refresh()

                            ThemMoi = 0
                    End Select
                    trvHTTK.Focus()
                End If
            Case 2 ' Xoa
                Select Case ThemMoi
                    Case 0
                        Dim curentCate As Category = CType(trvHTTK.SelectedNode.Tag, Category)
                        TkNhap.InitTaikhoanMaSo(curentCate.ID)
                        i = TkNhap.XoaTk()
                        If TkNhap.MaNT = 0 Then
                            Select Case i
                                Case -2
                                    MessageBox.Show(Ngonngu("Hãy xoá hết chi tiết của tài khoản !", "Delete all details of account !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    Exit Select
                                Case -3
                                    ErrMsg(er_CoPS)
                                    Exit Select
                                Case -4
                                    MessageBox.Show(Ngonngu("Tài khoản có chi tiết nguyên tệ, hãy xoá các chi tiết nguyên tệ !", "Account are detailed in the original currency, please delete the original currency details !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    Exit Select
                                Case -5
                                Case 0
                                    Dim prevNodeR As TreeNode = trvHTTK.SelectedNode.PrevNode
                                    trvHTTK.SelectedNode.Remove()
                                    If Not prevNodeR Is Nothing Then
                                        If prevNodeR.Nodes.Count > 0 Then
                                            trvHTTK.SelectedNode = prevNodeR
                                            'trvHTTK_AfterSelect(trvHTTK, Nothing)
                                        End If
                                    End If

                                    trvHTTK.Refresh()
                                    Exit Select
                            End Select
                        Else
                            TK = New ClsTaikhoan()
                            rs_tk = ExecSQLReturnDT(String.Format("SELECT MaSo FROM HethongTK WHERE SoHieu =N'{0}' ORDER BY MaNT DESC", TkNhap.sohieu))
                            For Each rstkItem As DataRow In rs_tk.Rows
                                TK.InitTaikhoanMaSo(ConvertToDblSafe(rstkItem("MaSo")))
                                TK.XoaTk()
                            Next
                            rs_tk = Nothing
                            Dim prevNodeR As TreeNode = trvHTTK.SelectedNode.PrevNode
                            trvHTTK.SelectedNode.Remove()
                            If prevNodeR IsNot Nothing Then
                                If prevNodeR.Nodes.Count > 0 Then
                                    trvHTTK.SelectedNode = prevNodeR
                                    'trvHTTK_AfterSelect(trvHTTK, Nothing)
                                End If
                            End If
                            trvHTTK.Refresh()
                        End If
                    Case Else
                        ThemMoi = 0
                        trvHTTK_AfterSelect(trvHTTK, Nothing)
                End Select
                trvHTTK.Focus()
            Case 3
                Hide()
            Case 4
                Frame(1).Visible = Not Frame(1).Visible
                If Frame(1).Visible Then txt(6).Focus()
            Case 5
                Dim lantim As Integer
                lantim = 0
timlai:
                If lantim = 1 And CboLoai.SelectedIndex < CboLoai.Items.Count - 1 Then
                    If CboLoai.Items.Count > 0 Then
                        CboLoai.SelectedIndex = CboLoai.SelectedIndex + 1
                    End If

                ElseIf lantim = 1 Then
                    If CboLoai.Items.Count > 0 Then CboLoai.SelectedIndex = 1
                    TkNhap.InitTaikhoanSohieu("111")
                ElseIf lantim = 1 And TkNhap.sohieu = "111" Then
                    lantim = 2
                ElseIf CboLoai.SelectedIndex = 0 Then
                    If CboLoai.Items.Count > 0 Then
                        CboLoai.SelectedIndex = 1
                    End If
                End If

                If Strings.Len(txtF.Text) = 0 Then
                    txtF.Focus()
                    Exit Sub
                End If
                Dim vt As Integer = -1, dodai As Integer
                If _SSOpt_0.Checked = True Then ' tim theo so hieu
                    For i = 0 To trvHTTK.Nodes.Count - 1
                        If trvHTTK.Nodes(i).Nodes.Count > 0 Then
                            For ii = 0 To trvHTTK.Nodes(i).Nodes.Count - 1
                                Dim s As String = trvHTTK.Nodes(i).Nodes(ii).Text.Split(" ")(0)
                                If txtF.Text.Length > s.Length Then
                                    dodai = s.Length
                                Else
                                    dodai = txtF.Text.Length
                                End If
                                If txtF.Text.Substring(0, dodai) = s.Substring(0, dodai) And s.Substring(0, 3) > TkNhap.sohieu.Substring(0, 3) Then
                                    trvHTTK.SelectedNode = trvHTTK.Nodes(i).Nodes(ii)
                                    vt = 1
                                    Exit For
                                End If
                            Next
                        Else
                            Dim s As String = trvHTTK.Nodes(i).Text.Split(" ")(0)
                            If txtF.Text.Length > s.Length Then
                                dodai = s.Length
                            Else
                                dodai = txtF.Text.Length
                            End If
                            If txtF.Text.Substring(0, dodai) = s.Substring(0, dodai) And s.Substring(0, 3) > TkNhap.sohieu.Substring(0, 3) Then
                                trvHTTK.SelectedNode = trvHTTK.Nodes(i)
                                vt = 1
                            End If
                        End If
                    Next
                    If vt = -1 And lantim = 2 Then
                        MessageBox.Show("Không tìm thấy số hiệu tài khoản như bạn nhập." + vbLf + "Bạn vui lòng kiểm tra lại số hiệu đã nhập có chính xác không ?")
                    ElseIf lantim = 0 Then
                        lantim = 1
                        GoTo timlai
                    End If
                Else ' tim theo ten
                    Try
                        For i = 0 To trvHTTK.Nodes.Count - 1
                            If trvHTTK.Nodes(i).Nodes.Count > 0 Then
                                For ii = 0 To trvHTTK.Nodes(i).Nodes.Count - 1
                                    'Dim sql As String = "SELECT DISTINCT Top 1 SoHieu AS F1 FROM HethongTK WHERE MaSo>0 AND Ten LIKE  N'%" & txtF.Text & "%'"
                                    'sql = ConvertToStrSafe(GetSelectValue(sql))
                                    'If sql <> "0" Then
                                    'Dim s As String = trvHTTK.Nodes(i).Nodes(ii).Text.Split(" ")(0)
                                    Dim s As String = trvHTTK.Nodes(i).Nodes(ii).Text
                                    If InStr(s.ToUpper, txtF.Text.ToUpper) > 0 And trvHTTK.Nodes(i).Nodes(ii).Text.Split(" ")(0).Substring(0, 3) > TkNhap.sohieu.Substring(0, 3) Then
                                        trvHTTK.SelectedNode = trvHTTK.Nodes(i).Nodes(ii)
                                        vt = 1
                                        Return
                                    End If
                                    'End If
                                Next
                            Else

                                'Dim sql As String = "SELECT DISTINCT Top 1 SoHieu AS F1 FROM HethongTK WHERE MaSo>0 AND Ten LIKE  N'%" & txtF.Text & "%'"
                                'sql = ConvertToStrSafe(GetSelectValue(sql))
                                'If sql <> "0" Then
                                'Dim s As String = trvHTTK.Nodes(i).Text.Split(" ")(0)
                                Dim s As String = trvHTTK.Nodes(i).Text
                                If InStr(s.ToUpper, txtF.Text.ToUpper) > 0 And trvHTTK.Nodes(i).Text.Split(" ")(0).Substring(0, 3) > TkNhap.sohieu.Substring(0, 3) Then
                                    trvHTTK.SelectedNode = trvHTTK.Nodes(i)
                                    vt = 1
                                    Return
                                End If
                                'End If
                            End If
                        Next
                        If vt = -1 And lantim = 2 Then
                            MessageBox.Show("Không tìm thấy tên tài khoản như bạn nhập." + vbLf + "Bạn vui lòng kiểm tra lại tên tài khoản đã nhập có chính xác không ?")
                        ElseIf lantim = 0 Then
                            lantim = 1
                            GoTo timlai
                        End If
                    Catch ex As Exception
                        lantim = 2
                        MessageBox.Show("Lỗi tìm kiếm theo tên " & ex.Message)
                    End Try
                End If
        End Select
XongTK:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateHethongTK()
        ExecSQLNonQuery("UPDATE HeThongTK SET HeThongTK.MaTC = HeThongTK.MaSo")
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If ThemMoi = 0 And ConvertToDblSafe(Me.Tag) = 0 Then trvHTTK.Focus()
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' Xử lý phím nóng
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmTaikhoan_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        Dim i As Integer
        If (Shift And 4) > 0 Then
            i = -1
            Select Case eventArgs.KeyCode
                Case Keys.V : i = 3
                Case Keys.T : i = 0
                Case Keys.G : i = 1
                Case Keys.X : i = 2
            End Select
            If i >= 0 Then
                If Command(i).Enabled Then
                    Command(i).Focus()
                    Application.DoEvents()
                    'Command_ClickEvent(Command(i), New EventArgs())
                End If
            End If
        End If
        If eventArgs.KeyCode = Keys.Add Then
            If trvHTTK.SelectedNode.Nodes.Count > 0 Then trvHTTK.SelectedNode.Expand()
            'KeyCode = 0
        End If
        If eventArgs.KeyCode = Keys.Subtract Then
            If trvHTTK.SelectedNode.Nodes.Count > 0 Then trvHTTK.SelectedNode.Collapse()
            'KeyCode = 0
        End If
        If eventArgs.KeyCode = Keys.Escape Then Hide()
    End Sub
    ''' <summary>
    ''' Khởi tạo cửa sổ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmTaikhoan_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdNT(0), 0, 700, 2)
            ColumnSetUp(GrdNT(0), 1, 1180, 4)
            ColumnSetUp(GrdNT(0), 2, 1180, 4)
            ColumnSetUp(GrdNT(0), 3, 1050, 4)
            ColumnSetUp(GrdNT(0), 4, 1, 0)
            ColumnSetUp(GrdNT(1), 0, 700, 2)
            ColumnSetUp(GrdNT(1), 1, 1180, 4)
            ColumnSetUp(GrdNT(1), 2, 1180, 4)
            ColumnSetUp(GrdNT(1), 3, 1050, 4)
            For chi_so As Integer = 0 To 1
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next

            ' Liet ke danh sach loai tai khoan
            If enable = False Then Int_RecsetToCbo(String.Format("SELECT Loai As F2,Ten{0} As F1 FROM HethongTk WHERE Cap=0 AND Len(SoHieu)>1 ORDER BY SoHieu", (IIf(pSongNgu And pVersion <> 3, "+' - '+TenE", String.Empty))), CboLoai)
            Int_RecsetToCbo(String.Format("SELECT MaSo As F2,KyHieu As F1 FROM NguyenTe WHERE KyHieu<>'{0}' ORDER BY KyHieu", pTienStr), CboNT)
            CboNT.Items.Insert(0, pTienStr, 0)

            ThemMoi = 0
            CmdNT.Enabled = (User_Right <> 2)
            Text = SetFormTitle(Text)
            Label(8).Visible = pSongNgu
            txt(3).Visible = pSongNgu
            Line1(5).Visible = pSongNgu

            SetFont(Me)
        Catch ex As Exception
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub
    ''' <summary>
    ''' Hiển thị danh sách tài khoản thuộc một loại
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ListTk()
        Me.Cursor = Cursors.WaitCursor
        Dim tvHlp As New TreeviewHelper(String.Format("SELECT DISTINCT msHTTK.MaSo AS FirstOfMaSo, msHTTK.SoHieu, msHTTK.Cap AS FirstOfCap, msHTTK.Ten{0} AS FirstOfTen, msHTTK.MaNT, ISNULL((SELECT TOP 1 chHTTK.MaSo FROM dbo.HeThongTK chHTTK WHERE(LEFT(msHTTK.SoHieu, LEN(chHTTK.SoHieu)) = chHTTK.SoHieu) AND(chHTTK.MaSo <> msHTTK.MaSo) AND((chHTTK.Cap + 1) = msHTTK.Cap) AND(LEFT(chHTTK.SoHieu, 1) <> '#') AND(chHTTK.Cap > 0) AND chHTTK.MaNT <= 0 AND chHTTK.Loai = {1} ), 0) AS ParentID, LEN(msHTTK.SoHieu) FROM HeThongTK msHTTK WHERE LEFT(msHTTK.SoHieu, 1) <> '#' AND msHTTK.Cap > 0 AND msHTTK.MaNT <= 0 AND msHTTK.Loai = {1} ORDER BY msHTTK.SoHieu, msHTTK.MaNT", _
                                            (IIf(pNN = 1, "E", String.Empty)), _
                                            CboLoai.SelectedValue))

        tvHlp.popularTreeview(trvHTTK)

        If trvHTTK.Nodes.Count > 0 Then
            trvHTTK.SelectedNode = trvHTTK.Nodes(0)
            Command(0).Enabled = True
            Command(1).Enabled = True
            Command(2).Enabled = True
        Else
            Command(0).Enabled = False
            Command(1).Enabled = False
            Command(2).Enabled = False
            ThemMoi = 0
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FrmTaikhoan_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        TkNhap = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub GrdNT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _GrdNT_0.DoubleClick, _GrdNT_1.DoubleClick
        Dim Index As Integer = Array.IndexOf(GrdNT, eventSender)
        Dim taikhoan As ClsTaikhoan
        If Index = 0 Then
            With GrdNT(0)
                .Col = 4
                If .CtlText.Length = 0 Then Exit Sub
                If ConvertToDblSafe(.CtlText) <= 0 Then Exit Sub
                If ThemMoi = 0 Then
                    taikhoan = New ClsTaikhoan()
                    taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(MaTKNguyenTe(TkNhap.sohieu, ConvertToDblSafe((.CtlText)))))
                    If taikhoan.TkCoPS(0, 0) Then
                        ErrMsg(er_CoPS)
                        Exit Sub
                    Else
                        taikhoan.XoaTk()
                        trvHTTK_AfterSelect(trvHTTK, Nothing)
                    End If
                Else
                    .RemoveItem(.Row)
                    If .Rows < 10 Then .Rows = 10
                End If
            End With
        End If
    End Sub

    ''' <summary>
    ''' Hiển thị thông tin về tài khoản được chọn
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub trvHTTK_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvHTTK.AfterSelect
        Me.Cursor = Cursors.WaitCursor
        Dim rs_tk As DataTable
        Dim sh, sql As String
        Dim currentTK As Category = DirectCast(trvHTTK.SelectedNode.Tag, Category)

        txtDuNT(0).Text = "0"
        txtDuNT(1).Text = "0"
        txtDuNT(2).Text = "0"
        ' Khoi tao tham chieu
        With TkNhap
            .InitTaikhoanMaSo(currentTK.ID)
            Frame(1).Visible = False
            Command(4).Visible = (Strings.Left(TkNhap.sohieu, 4) = "2412" And (TkNhap.cap >= 3) And frmMain.Chk(2).CheckState <> CheckState.Unchecked)
            ChkDT.Visible = False
            If .tk_id = TKVT_ID Then
                ChkDT.CheckState = IIf(STDetail, 1, 0)
                ChkDT.Visible = True
            End If
            If .tk_id = TSCD_ID Or .tk_id = KHTSCD_ID Then
                ChkDT.CheckState = IIf(FADetail, 1, 0)
                ChkDT.Visible = True
            End If
            txt(0).Text = .sohieu
            txt(1).Text = .ten
            txt(2).Text = .GhiChu
            If pSongNgu Then txt(3).Text = .TenE
            Select Case .kieu
                Case -1
                    OptNo.Checked = True
                Case 1
                    OptCo.Checked = True
            End Select
            ChkBtc.CheckState = IIf(.MaTC = 0 Or .MaTC = .maso, 1, 0)
            txtDu(0).Text = Format(.SoDuMin, Mask_0)
            txtDu(1).Text = Format(.SoDuMax, Mask_0)
            txtDuNT(0).Text = "0"
            txtDuNT(1).Text = "0"
            txtDuNT(2).Text = "0"
            ClearGrid(GrdNT(0), 10)
            ClearGrid(GrdNT(1), 10)
            sql = String.Format("SELECT DISTINCT HethongTK.MaNT,NguyenTe.KyHieu, HethongTK.DuNo_0 AS DKNo, HethongTK.DuCo_0 AS DKCo, HethongTK.DuNT_0 AS DKNT, HethongTK.DuNo_12 AS CKNo, HethongTK.DuCo_12 AS CKCo, HethongTK.DuNT_12 AS CKNT FROM HethongTK LEFT JOIN NguyenTe ON HethongTK.MaNT=NguyenTe.MaSo WHERE HethongTK.SoHieu=N'{0}' ", TkNhap.sohieu)
            If TkNhap.tkcon > 0 Then
                sql = String.Format("{0} UNION SELECT DISTINCT HethongTK.MaNT, NguyenTe.KyHieu, 0 AS DKNo, 0 AS DKCo, Sum(HethongTK.DuNT_0) AS DKNT, 0 AS CKNo, 0 AS CKCo, Sum(HethongTK.DuNT_12) AS CKNT FROM HethongTK LEFT JOIN NguyenTe ON HethongTK.MaNT=NguyenTe.MaSo WHERE HethongTK.SoHieu LIKE '{1}%' AND TKCon=0 AND MaNT>0 GROUP BY HethongTK.MaNT, NguyenTe.KyHieu ", _
                          sql, _
                          TkNhap.sohieu)
            End If
            Dim MienTru As String = sql
            rs_tk = ExecSQLReturnDT(String.Format("SELECT * FROM ({0}) AS MienTru ORDER BY KyHieu DESC", MienTru))
            For Each rsItem As DataRow In rs_tk.Rows
                sh = IIf(ConvertToDblSafe(rsItem("MaNT")) <= 0, pTienStr, ConvertToStrSafe(rsItem("KyHieu")))
                GrdNT(0).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}", _
                                     sh, _
                                     Chr(9), _
                                     Format(ConvertToDblSafe(rsItem("dkno")), IIf(Strings.Left(.sohieu, 3) <> "007", Mask_0, Mask_2)), _
                                     Format(ConvertToDblSafe(rsItem("dkco")), IIf(Strings.Left(.sohieu, 3) <> "007", Mask_0, Mask_2)), _
                                     Format(ConvertToDblSafe(rsItem("dknt")), Mask_2), _
                                     rsItem("MaNT")), 0)
                GrdNT(1).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}", _
                                     sh, _
                                     Chr(9), _
                                     Format(ConvertToDblSafe(rsItem("ckno")), IIf(Strings.Left(.sohieu, 3) <> "007", Mask_0, Mask_2)), _
                                     Format(ConvertToDblSafe(rsItem("ckco")), IIf(Strings.Left(.sohieu, 3) <> "007", Mask_0, Mask_2)), _
                                     Format(ConvertToDblSafe(rsItem("cknt")), Mask_2)), 0)
            Next
            If CboNT.Items.Count > 0 Then
                CboNT.SelectedIndex = 0
            End If

            'GrdNT(0).Rows = iif(rs_tk.Rows.Count > ConvertTodblSafe((GrdNT(0).Tag)), rs_tk.Rows.Count, ConvertToDblSafe(GrdNT(0).Tag))
            'GrdNT(1).Rows = iif(rs_tk.Rows.Count > ConvertTodblSafe((GrdNT(1).Tag)), rs_tk.Rows.Count, ConvertToDblSafe(GrdNT(1).Tag))
            GrdNT(0).Refresh()
            GrdNT(1).Refresh()
            rs_tk = Nothing
        End With
        ThemMoi = 0
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub trvHTTK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles trvHTTK.KeyDown
        If e.KeyCode = Keys.Return Then trvHTTK_DoubleClick(sender, New EventArgs())
        If (e.Shift And 2) > 0 And e.KeyCode = Keys.M And trvHTTK.SelectedNode.Index >= 0 Then ChuyenTK()
        If (e.Shift And 2) > 0 And e.KeyCode = Keys.D And trvHTTK.SelectedNode.Index >= 0 Then
            If FrmPassword.GetPswX() = "UCDIT" Then
                pXuLyTKTC = 1
                Command_ClickEvent(Command(2), New EventArgs())
                pXuLyTKTC = 0
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub trvHTTK_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles trvHTTK.DoubleClick
        If ThemMoi = 0 And ConvertToDblSafe(Me.Tag) = 0 Then Hide()
    End Sub

    Private Sub trvHTTK_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trvHTTK.MouseDown
        If e.Button = MouseButtons.Right And TkNhap.maso > 0 And User_Right = 0 Then
            If pPQTK = 0 Then ChuyenTK() Else FU1.QuyenTaiKhoan(TkNhap.maso)
        End If
    End Sub

    Private Sub ChuyenTK()
        'If OtlTk.ListIndex < 0 Then Exit Sub
        If TkNhap.MaTC = 0 Or TkNhap.MaTC = TkNhap.maso Then Exit Sub
        If Not KtraMKAdmin() Then Exit Sub
        Dim sh As String = FrmGetStr.GetString(String.Format("Chuyển {0} thành chi tiết của tài khoản:", (String.Format("{0} - {1}", TkNhap.sohieu, TkNhap.ten))), My.Application.Info.ProductName)
        If sh.Length = 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim tkx As New ClsTaikhoan
        tkx.InitTaikhoanSohieu(sh)
        If tkx.GhepCanh(TkNhap) = 0 Then CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
        tkx = Nothing
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub SSCmdF_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        If Strings.Len(txtF.Text) = 0 Then
            txtF.Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = String.Format("SELECT DISTINCT SoHieu AS F1 FROM HethongTK WHERE {0}", (IIf(SSOpt(0).Checked, "SoHieu LIKE '" & txtF.Text & "'", " Ten like '%" & txtF.Text & "%' OR TenE like '%" & txtF.Text & "%'")))
        sql = ConvertToStrSafe(GetSelectValue(sql))
        If sql <> "0" Then ChonTk(sql)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_6.Enter, _txt_4.Enter, _txt_5.Enter, _txt_3.Enter, _txt_0.Enter, _txt_1.Enter, _txt_2.Enter
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        txt(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txt_6.KeyPress, _txt_4.KeyPress, _txt_5.KeyPress, _txt_3.KeyPress, _txt_0.KeyPress, _txt_1.KeyPress, _txt_2.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        If Index = 0 Then
            If KeyAscii = 32 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
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
    Private Sub txt_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_6.Leave, _txt_4.Leave, _txt_5.Leave, _txt_3.Leave, _txt_0.Leave, _txt_1.Leave, _txt_2.Leave
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        Select Case Index
            Case 0
                txt(0).Text = txt(0).Text.ToUpper()
            Case 2
                If Strings.Len(txt(Index).Text) = 0 Then txt(Index).Text = "..."
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtDu_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtDu_2.Enter, _txtDu_3.Enter, _txtDu_4.Enter, _txtDu_5.Enter, _txtDu_6.Enter, _txtDu_0.Enter, _txtDu_1.Enter
        Dim Index As Integer = Array.IndexOf(txtDu, eventSender)
        txtDu(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtDu_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtDu_2.KeyPress, _txtDu_3.KeyPress, _txtDu_4.KeyPress, _txtDu_5.KeyPress, _txtDu_6.KeyPress, _txtDu_0.KeyPress, _txtDu_1.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtDu, eventSender)
        KeyProcess(txtDu(Index), KeyAscii)
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
    Private Sub txtDu_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtDu_2.Leave, _txtDu_3.Leave, _txtDu_4.Leave, _txtDu_5.Leave, _txtDu_6.Leave, _txtDu_0.Leave, _txtDu_1.Leave
        Dim Index As Integer = Array.IndexOf(txtDu, eventSender)
        txtDu(Index).Text = Format(txtDu(Index).Text, Mask_0)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtDuNT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtDuNT_0.Enter, _txtDuNT_1.Enter, _txtDuNT_2.Enter
        Dim Index As Integer = Array.IndexOf(txtDuNT, eventSender)
        txtDuNT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtDuNT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtDuNT_0.KeyPress, _txtDu_1.KeyPress, _txtDuNT_2.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtDuNT, eventSender)
        If TkNhap.loai < pTKTrunggian Then
            If KeyAscii = 13 Then
                CmdNT_Click(CmdNT, New EventArgs())
            Else
                KeyProcess(txtDuNT(Index), KeyAscii, True)
            End If
        Else
            KeyAscii = 0
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
    Private Sub txtDuNT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtDuNT_0.Leave, _txtDuNT_1.Leave, _txtDuNT_2.Leave
        Dim Index As Integer = Array.IndexOf(txtDuNT, eventSender)
        Dim tgia, sdu As Double
        If Index < 2 Then
            sdu = ConvertToDblSafe(txtDuNT(Index).Text)
            If sdu > 0 Then
                txtDuNT(Index).Text = Format(sdu, Mask_0)
                tgia = TyGiaNT(CboNT.SelectedValue)
                txtDuNT(2).Text = Format(DoiRaNT(sdu, tgia), Mask_2)
                txtDuNT(1 - Index).Text = "0"
            End If
        Else
            txtDuNT(Index).Text = Format(ConvertToDblSafe(txtDuNT(Index).Text), Mask_2)
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc kiem tra cac thong tin nhap vao
    ''' </summary>
    ''' <remarks></remarks>
    Public Function KiemTraDuLieu() As Boolean
        Dim result As Boolean = False
        Dim sql As String = String.Empty
        Dim tkcha As New ClsTaikhoan
        ' Kiem tra du lieu nhap
        If Strings.Len(txt(0).Text) = 0 Then
            ErrMsg(er_SoHieu)
            txt(0).Focus()
            Return result
        ElseIf Strings.Left(txt(0).Text, 3) = "153" Or Strings.Left(txt(0).Text, 3) = "154" Or Strings.Left(txt(0).Text, 3) = "155" Or Strings.Left(txt(0).Text, 4) = "1561" Or Strings.Left(txt(0).Text, 2) = "21" Or Strings.Left(txt(0).Text, 3) = "334" Or Strings.Left(txt(0).Text, 4) = "1421" Or Strings.Left(txt(0).Text, 4) = "1422" Or Strings.Left(txt(0).Text, 3) = "242" Then
            If MessageBox.Show(String.Format("Khi thêm chi tiết cho tài khoản này chương trình có thể chạy sai !{0}Bạn có chắc chắn muốn ghi không ?", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then Return result
        End If
        If Strings.Len(txt(1).Text) = 0 Then
            ErrMsg(er_Ten)
            txt(1).Focus()
            Return result
        End If
        ' Kiem tra so hieu co hop le
        Dim shmoi As String = txt(0).Text
        Select Case ThemMoi
            Case 0
                If shmoi <> TkNhap.sohieu Then
                    If TkNhap.cap > 1 Then
                        tkcha.InitTaikhoanMaSo(TkNhap.TkCha0)
                        If Strings.Left(shmoi, tkcha.sohieu.Length) <> tkcha.sohieu Then
                            ErrMsg(er_SoHieu)
                            txt(0).Focus()
                            Return result
                        End If
                    End If
                End If
            Case 1
                If shmoi.Length > 3 Then
                    TkNhap.TkCha5 = TkNhap.TkCha4
                    TkNhap.TkCha4 = TkNhap.TkCha3
                    TkNhap.TkCha3 = TkNhap.TkCha2
                    TkNhap.TkCha2 = TkNhap.TkCha1
                    TkNhap.TkCha1 = TkNhap.TkCha0
                    TkNhap.TkCha0 = TkNhap.maso
                    TkNhap.tkcon = 0
                    TkNhap.cap = trvHTTK.SelectedNode.Level + 1
                    If TkNhap.cap > max_level Then
                        MessageBox.Show(String.Format("Không mở tài khoản quá {0} cấp !", max_level), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txt(0).Focus()
                        Return result
                    End If
                    If TkNhap.MaNT = -1 Then
                        MessageBox.Show(Ngonngu("Tài khoản đã đăng ký thanh toán theo nguyên tệ, không mở chi tiết !", "Account registered in the original currency or payment, do not open details !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return result
                    End If
                    If TkNhap.tkcon > 0 Then
                        sql = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM HethongTK WHERE TkCha0 = {0}", TkNhap.maso)
                        If shmoi.Length <> Strings.Len(ConvertToStrSafe(GetSelectValue(sql))) Then
                            MessageBox.Show(Ngonngu("Số hiệu tài khoản cùng cấp phải cùng độ dài !", "Number of accounts at the same level to the same length !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txt(0).Focus()
                            Return result
                        End If
                    End If
                    If Strings.Left(shmoi, TkNhap.sohieu.Length) <> TkNhap.sohieu Then
                        ErrMsg(er_SoHieu)
                        txt(0).Focus()
                        Return result
                    End If
                Else
                    If Strings.Left(shmoi, 1) <> ConvertToStrSafe(TkNhap.loai) Then
                        ErrMsg(er_SoHieu)
                        txt(0).Focus()
                        Return result
                    End If
                    TkNhap.TkCha5 = 0
                    TkNhap.TkCha4 = 0
                    TkNhap.TkCha3 = 0
                    TkNhap.TkCha2 = 0
                    TkNhap.TkCha1 = 0
                    TkNhap.TkCha0 = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM HethongTK WHERE Cap=0 AND Loai=" & TkNhap.loai))
                    TkNhap.tkcon = 0
                    TkNhap.cap = 1
                End If
        End Select
        ' Doc thong tin vao structure
        With TkNhap
            .sohieu = txt(0).Text
            .ten = txt(1).Text
            .GhiChu = txt(2).Text
            .TenDA = IIf(txt(3).Text <> "", txt(3).Text, "...")
            .NhomDA = IIf(txt(4).Text <> "", txt(4).Text, "...")
            .DiaDiem = IIf(txt(5).Text <> "", txt(5).Text, "...")
            .DuToan = ConvertToDblSafe(txtDu(2).Text)
            .Von1 = ConvertToDblSafe(txtDu(3).Text)
            .Von2 = ConvertToDblSafe(txtDu(4).Text)
            .Von3 = ConvertToDblSafe(txtDu(5).Text)
            .NgayKC = ConvertToDateSafe(Ngay(0).Date, Now)
            .NgayHT = ConvertToDateSafe(Ngay(1).Date, Now)
            If (frmMain.Chk(2).CheckState And (Strings.Left(TkNhap.sohieu, 4) = "2412" Or .loai = 6 Or .loai = 8)) Then .PSNLK = ConvertToDblSafe(txtDu(6).Text)
            If pSongNgu Then .TenE = txt(3).Text
            .kieu = IIf(OptNo.Checked, -1, 1)
            .loai = CboLoai.SelectedValue
            For i As Integer = 0 To GrdNT(0).Rows - 1
                GrdNT(0).Row = i
                GrdNT(0).Col = 4
                If ConvertToDblSafe(GrdNT(0).CtlText) = 0 Then Exit For
            Next
            GrdNT(0).Col = 1
            .NoDauKy = RoundMoney(ConvertToDblSafe(GrdNT(0).CtlText))
            GrdNT(0).Col = 2
            .CoDauKy = RoundMoney(ConvertToDblSafe(GrdNT(0).CtlText))
            GrdNT(0).Col = 3
            .NTDauKy = ConvertToDblSafe(GrdNT(0).CtlText)
            .SoDuMin = RoundMoney(ConvertToDblSafe(txtDu(0).Text))
            .SoDuMax = RoundMoney(ConvertToDblSafe(txtDu(1).Text))
        End With
        Return True
    End Function

    'Thu tuc dua ra man hinh cua so chon tài khoản

    'Public Function ChonTk(ByRef sh As String) As String
    '    Me.ShowDialog()
    'End Function
    Public Function ChonTk(ByRef sh As String) As String
        nodefind = False
        Dim pos, i, j, Length As Integer
        Dim shtk As String = String.Empty
        Dim loai As Integer
        Dim item(max_level - 1) As Integer
        sohieutim = sh
        Me.Tag = "0"
        Int_RecsetToCbo(String.Format("SELECT Loai As F2,Ten{0} As F1 FROM HethongTk WHERE Cap=0 AND Len(SoHieu)>1 ORDER BY SoHieu", (IIf(pSongNgu And pVersion <> 3, "+' - '+TenE", String.Empty))), CboLoai)
        If CboLoai.Items.Count > 0 Then
            CboLoai.SelectedIndex = 1
        End If
        ListTk()
        If sh.Length > 0 Then
            If IsNumeric(sh.Substring(0, 1)) Then
                loai = ConvertToDblSafe((sh.Substring(0, 1)))
                If CboLoai.SelectedIndex <> loai Then SetListIndex(CboLoai, loai) : ListTk()
                i = 0
                j = trvHTTK.Nodes.Count - 1
                pos = 0
                Length = sh.Length
                Dim nodes As TreeNodeCollection
                nodes = trvHTTK.Nodes
                TimNode(nodes, sh)
            End If
        End If
        Try
            enable = True
            Me.ShowDialog()
        Catch
        End Try
        If TkNhap.sohieu.Length = 0 Then TkNhap.InitTaikhoanMaSo(TkNhap.maso)
        initOption = -1
        Return TkNhap.sohieu
    End Function

    Public Sub TimNode(ByVal nodes As TreeNodeCollection, ByVal str As String)
        For i As Integer = 0 To nodes.Count - 1
            If nodes(i).Text.Split(" ")(0).ToUpper = str.ToUpper Then
                trvHTTK.SelectedNode = nodes(i)
                trvHTTK.Select()
                nodefind = True
                Exit Sub
            Else
                nodefind = False
                nodes(i).Collapse()
            End If
            nodes(i).Expand()
            TimNode(nodes(i).Nodes, str)
            If (nodefind) Then
                Exit Sub
            End If
            nodes(i).Collapse()
        Next
    End Sub

    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Enter, _MedNgay_1.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Leave, _MedNgay_1.Leave
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        If Information.IsDate(MedNgay(Index).Text) Then
            Ngay(Index) = ConvertToDateSafe(MedNgay(Index).Text)
        Else
            MessageBox.Show(Ngonngu("Nhập sai ngày !", "Dates error !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MedNgay(Index).Focus()
        End If
    End Sub
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
    Private Sub _SSOpt_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SSOpt_1.CheckedChanged
        txtF.SelectAll()
        txtF.Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub _SSOpt_0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SSOpt_0.CheckedChanged
        txtF.SelectAll()
        txtF.Focus()
    End Sub

End Class
