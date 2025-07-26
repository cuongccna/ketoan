Imports System
Imports System.Data
Imports System.Media
Imports UNET.Utility
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Friend Class clsTaiSan
#Region "Thuộc tính"
    Public maso As Integer ' Mã số
    Public ten As String = String.Empty ' Tên tài sản
    Public sohieu As String = String.Empty ' Số hiệu
    Public NangLuc As String = String.Empty ' Công suất, diện tích thiết kế
    Public GhiChu As String = String.Empty ' Ghi chú
    Public MaNuoc As Integer ' Mã nước sản xuất
    Public NamSX As Integer ' Năm sản xuất
    Public NamSD As Integer ' Năm sử dụng
    Public MaTaiKhoan As Integer ' Mã tài khoản tài sản
    Public maloai As Integer ' Mã phân loại tài sản
    Public MaNhom As Integer ' Mã phân nhóm tài sản
    Public ThangTang As Integer ' Tháng tăng (0 nếu tăng từ các năm trước)
    Public ThangGiam As Integer ' Tháng giảm (13 nếu chưa giảm trong năm)
    Private _ThongSo As clsThongSo = Nothing
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ThongSo() As clsThongSo
        Get
            If _ThongSo Is Nothing Then
                _ThongSo = New clsThongSo()
            End If
            Return _ThongSo
        End Get
        Set(ByVal Value As clsThongSo)
            _ThongSo = Value
        End Set
    End Property ' Thông số thay đổi theo tháng
    Public NamKH As Integer
    Public shct As String = String.Empty
    Public NCT As Date
#End Region
    ''' <summary>
    ''' Kiểm tra tính hợp lệ của dữ liệu
    ''' </summary>
    ''' <returns>Trả về : 0 nếu đúng, -1 nếu có lỗi</returns>
    ''' <remarks></remarks>
    Public Function HopLe() As Integer
        Dim thong_bao, sql, so_hieu As String
        If sohieu.Length = 0 Or sohieu = "(...)" Then
            thong_bao = "Thiếu số hiệu tài sản"
        Else
            If ten.Length = 0 Or ten = "(...)" Then
                thong_bao = "Thiếu tên tài sản"
            Else
                ' Các đối tượng quan hệ
                If MaNuoc = 0 Then
                    thong_bao = "Thiếu hoặc chưa đăng ký tên nước sản xuất"
                Else
                    If MaTaiKhoan = 0 Then
                        thong_bao = "Thiếu hoặc chưa đăng ký tài khoản tài sản"
                    Else
                        'If maloai = 0 Then
                        '    thong_bao = "Thiếu hoặc chưa đăng ký phân loại tài sản"
                        'Else
                        ' Kiểm tra Số hiệu
                        sql = String.Format("SELECT SoHieu AS F1 FROM LoaiTaiSan WHERE MaSo = {0}", (IIf(MaNhom > 0, MaNhom, IIf(maloai > 0, maloai, MaTaiKhoan))))
                        so_hieu = ConvertToStrSafe(GetSelectValue(sql))
                        If Not (Strings.Left(sohieu, so_hieu.Length) = so_hieu) Then
                            thong_bao = String.Format("Số hiệu tài sản không đúng quy định (Vd: {0}..)", so_hieu)
                        Else
                            If ThangGiam = 0 Then ThangGiam = 13
                            Return ThongSo.HopLe()
                        End If
                        'End If
                    End If
                End If
            End If
        End If
        SystemSounds.Beep.Play()
        MessageBox.Show(thong_bao, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return -1
    End Function
    ''' <summary>
    ''' Ghi đối tượng tài sản hiện tại vào cơ sở dữ liệu.
    '''  - Ghi tài sản vào bảng TaiSan
    '''  - Tạo các bản ghi chứa giá trị hàng tháng (từ tháng 0 cho đến hết năm)
    ''' </summary>
    ''' <param name="kh1"></param>
    ''' <returns>Trả về : 0 nếu thành công, -1 nếu có lỗi</returns>
    ''' <remarks>Chú ý : Mã số của đối tượng tài sản hiện tại sẽ được đặt khác 0 sau thủ tục này.</remarks>
    Public Function ThemMoi(ByRef kh1 As Integer) As Integer
        Dim result As Integer = 0
        Dim ts1 As clsThongSo
        If shct.Length = 0 Then shct = "..."
        ' Ghi tài sản
        Dim sql As String = String.Format("INSERT INTO TaiSan (MaSo, Ten, SoHieu, NangLuc, GhiChu, MaNuoc, NamSX, NamSD, MaTaiKhoan, MaLoai, MaNhom, ThangTang, ThangGiam,NamKH, SHCT, NCT) VALUES ({0}, N'{1}', N'{2}', N'{3}', N'{4}',{5},{6},{7},{8},{9},{10},{11},{12},{13}, N'{14}', N'{15}')", _
                                Lng_MaxValue("MaSo", "TaiSan") + 1, _
                                ten, _
                                sohieu, _
                                NangLuc, _
                                GhiChu, _
                                ConvertToStrSafe(MaNuoc), _
                                ConvertToStrSafe(NamSX), _
                                ConvertToStrSafe(NamSD), _
                                ConvertToStrSafe(MaTaiKhoan), _
                                ConvertToStrSafe(maloai), _
                                ConvertToStrSafe(MaNhom), _
                                ConvertToStrSafe(ThangTang), _
                                ConvertToStrSafe(ThangGiam), _
                                ConvertToStrSafe(NamKH), _
                                shct, _
                                Format(NCT, Mask_DB))
        ' Ghi các thông số cho các tháng trong năm
        If ExecSQLNonQuery(sql) = 0 Then
            maso = Lng_MaxValue("MaSo", "TaiSan")
            ThongSo.MaTS = maso
            For chi_so As Integer = 0 To 12
                If chi_so >= CThangDB2(ThangTang) And chi_so <= CThangDB2(ThangGiam) Then
                    ThongSo.thang = chi_so
                    If kh1 = 1 And chi_so = CThangDB2(ThangTang) Then
                        ts1 = New clsThongSo()
                        ThongSo.DanXuat(ts1)
                        ThongSo.KH_NS = 0
                        ThongSo.KH_TBS = 0
                        ThongSo.KH_TD = 0
                        ThongSo.KH_CNK = 0
                        result = ThongSo.ThemMoi()
                        ts1.DanXuat(ThongSo)
                        ts1 = Nothing
                    Else
                        result = ThongSo.ThemMoi()
                    End If
                    If result = -1 Then Return result
                End If
            Next
        Else
            result = -1
        End If
        Return result
    End Function
    ''' <summary>
    ''' Gán các thuộc tính của đối tượng tài sản hiện tại theo giá trị lưu trong cơ sở dữ liệu
    ''' </summary>
    ''' <param name="ma_so">Mã tài sản cần lấy thông tin</param>
    ''' <param name="thang_cd">Thời gian (để xác định các thông số)</param>
    ''' <remarks>Sử dụng : Thủ tục ChiDinh trong clsThongSo
    ''' Chú ý : Không kiểm tra tham số khi thực hiện
    ''' </remarks>
    Public Sub ChiDinh(ByRef ma_so As Integer, ByRef thang_cd As Integer)
        Dim sql As String = String.Format("SELECT * FROM TaiSan WHERE MaSo = {0}", ma_so)
        Dim rs_taisan As DataTable = ExecSQLReturnDT(sql)
        ' Chi tiết
        If rs_taisan.Rows.Count > 0 Then
            Dim rsTSItem As DataRow = rs_taisan.Rows(0)

            If rsTSItem("maso") IsNot Nothing Then
                maso = ConvertToDblSafe(rsTSItem("maso"))
            End If

            If rsTSItem("ten") IsNot Nothing Then
                ten = ConvertToStrSafe(rsTSItem("ten"))
            End If

            If rsTSItem("sohieu") IsNot Nothing Then
                sohieu = ConvertToStrSafe(rsTSItem("sohieu"))
            End If

            If rsTSItem("NangLuc") IsNot Nothing Then
                NangLuc = ConvertToStrSafe(rsTSItem("NangLuc"))
            End If

            If rsTSItem("GhiChu") IsNot Nothing Then
                GhiChu = ConvertToStrSafe(rsTSItem("GhiChu"))
            End If

            If rsTSItem("NamSX") IsNot Nothing Then
                NamSX = ConvertToDblSafe(rsTSItem("NamSX"))
            End If

            If rsTSItem("NamSD") IsNot Nothing Then
                NamSD = ConvertToDblSafe(rsTSItem("NamSD"))
            End If
            ' Các đối tượng quan hệ


            If rsTSItem("MaNuoc") IsNot Nothing Then
                MaNuoc = ConvertToDblSafe(rsTSItem("MaNuoc"))
            End If

            If rsTSItem("MaTaiKhoan") IsNot Nothing Then
                MaTaiKhoan = ConvertToDblSafe(rsTSItem("MaTaiKhoan"))
            End If

            If rsTSItem("maloai") IsNot Nothing Then
                maloai = ConvertToDblSafe(rsTSItem("maloai"))
            End If

            If rsTSItem("MaNhom") IsNot Nothing Then
                MaNhom = ConvertToDblSafe(rsTSItem("MaNhom"))
            End If

            If rsTSItem("ThangTang") IsNot Nothing Then
                ThangTang = ConvertToDblSafe(rsTSItem("ThangTang"))
            End If

            If rsTSItem("ThangGiam") IsNot Nothing Then
                ThangGiam = ConvertToDblSafe(rsTSItem("ThangGiam"))
            End If

            If rsTSItem("NamKH") IsNot Nothing Then
                NamKH = ConvertToDblSafe(rsTSItem("NamKH"))
            End If

            If rsTSItem("shct") IsNot Nothing Then
                shct = ConvertToStrSafe(rsTSItem("shct"))
            End If

            If rsTSItem("NCT") IsNot Nothing Then
                NCT = ConvertToDateSafe(rsTSItem("NCT"))
            End If
            ' Thông số của tháng được chỉ định
            If thang_cd > 0 Then ThongSo.ChiDinh(ma_so, thang_cd)
        Else
            KhoiTao()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <remarks></remarks>
    Public Sub ChiDinhSH(ByRef sh As String)
        ChiDinh(ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM TaiSan WHERE SoHieu=N'{0}'", sh))), 0)
    End Sub
    ''' <summary>
    ''' KhoiTao
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub KhoiTao()
        maso = 0
        ten = "(...)"
        sohieu = "(...)"
        NangLuc = "(...)"
        GhiChu = "(...)"
        MaNuoc = 0
        NamSX = 0
        NamSD = 0
        MaTaiKhoan = 0
        maloai = 0
        MaNhom = 0
        ThangTang = 0
        NamKH = 0
        ThangGiam = 13
        shct = "..."
        ThongSo.KhoiTao()
    End Sub
    ''' <summary>
    ''' Sửa đổi nội dung của đối tượng tài sản hiện thời
    ''' - Các thông số cố định
    ''' - Các thay đổi luỹ tiến về lượng khấu hao và các đối tượng quan hệ
    ''' - Các thay đổi về giá trị tài sản (được cập nhật đồng thời với chứng từ tăng hoặc chứng từ đầu kỳ tương ứng)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>
    ''' Chú ý : Đối với tài sản đã bị giảm trong năm thì các thay đổi về lượng khấu hao và
    ''' giá trị là không được phép vì sẽ dẫn đến mâu thuẫn với chứng từ giảm đã ghi.
    ''' </remarks>
    Public Function SuaDoi() As Integer
        Dim result As Integer = 0
        If shct.Length = 0 Then shct = "..."
        ' Thay đổi các thông số cố định
        Dim sql As String = String.Format("UPDATE TAISAN SET Ten =N'{0}', SoHieu =N'{1}', NangLuc =N'{2}', GhiChu =N'{3}', MaNuoc = {4}, NamSX = {5}, NamSD = {6},NamKH={7}, MaTaiKhoan = {8}, MaLoai = {9}, MaNhom = {10}, SHCT =N'{11}', NCT=N'{12}' WHERE MaSo = {13}", _
                                ten, _
                                sohieu, _
                                NangLuc, _
                                GhiChu, _
                                ConvertToStrSafe(MaNuoc), _
                                ConvertToStrSafe(NamSX), _
                                ConvertToStrSafe(NamSD), _
                                ConvertToStrSafe(NamKH), _
                                ConvertToStrSafe(MaTaiKhoan), _
                                ConvertToStrSafe(maloai), _
                                ConvertToStrSafe(MaNhom), _
                                shct, _
                                Format(NCT, Mask_DB), _
                                ConvertToStrSafe(maso))
        If ExecSQLNonQuery(sql) <> 0 Then
            Return -1
        End If
        'WSpace.BeginTransaction() ' C15()
        ' Nếu tài sản đã bị ghi chứng từ giảm thì phải xoá chứng từ này đi mới có thể sửa đổi giá trị
        If Not (ThangGiam = 13) Then
            result = -2
            GoTo KhongDC
        End If
        ' Thay đổi nguyên giá, lượng hao mòn, khấu hao và các đối tượng quan hệ
        Dim tong_ng, tong_hm As Double
        Dim tsts As clsThongSo
        If ThangTang > 0 And ThongSo.thang = CThangDB2(ThangTang) Then
            tsts = New clsThongSo()
            tsts.ChiDinh(maso, ThangTang)
            If (tsts.NG_NS + tsts.NG_TBS + tsts.NG_CNK + tsts.NG_TD <> ThongSo.NG_NS + ThongSo.NG_TBS + ThongSo.NG_CNK + ThongSo.NG_TD) Or (tsts.CL_NS + tsts.CL_TBS + tsts.CL_CNK + tsts.CL_TD <> ThongSo.CL_NS + ThongSo.CL_TBS + ThongSo.CL_CNK + ThongSo.CL_TD) Then
                tong_ng = (ThongSo.NG_NS + ThongSo.NG_TBS + ThongSo.NG_CNK + ThongSo.NG_TD)
                tong_hm = tong_ng - (ThongSo.CL_NS + ThongSo.CL_TBS + ThongSo.CL_CNK + ThongSo.CL_TD)
                If SetChungtuTang(tong_ng, tong_hm) <> 0 Then GoTo KhongDC
            End If
            tsts = Nothing
        End If
        If ThongSo.thang = 1 Or ThongSo.thang = ThangTang Then
            result = ConvertToDblSafe(ThongSo.SuaDoiQuanHe(True))
        Else
            result = ConvertToDblSafe(ThongSo.SuaDoiQuanHe(False))
        End If
        ' Thay đổi nguyên giá, giá trị còn lại lưu trong chứng từ tăng tài sản đầu kỳ và trong các tháng
        ' trước tháng đầu kỳ (Chú ý : các dòng mã dưới đây chỉ được thực hiện ở tháng đầu kỳ)
        If (ThongSo.thang = 1 Or ThongSo.thang = CThangDB2(ThangTang)) And (Not KhongDC(maso)) Then
            sql = String.Format("SELECT MaSo AS F1 FROM CTTaiSan WHERE MaTS = {0} AND Thang = {1} AND MaLoai = {2}", _
                      maso, _
                      ConvertToStrSafe(ThongSo.thang), _
                      ConvertToStrSafe(NV_DGLAI))
            If IsDBNull(GetSelectValue(sql)) Then
                result = -3
                GoTo KhongDC
            Else
                result = ThongSo.SuaDoiGiaTri()
                If result = -1 Then GoTo KhongDC
                sql = String.Format("UPDATE CTTaiSan SET [NG_NS] = {0}, [NG_TBS] = {1}, [NG_CNK] = {2}, [NG_TD] = {3}, [CL_NS] = {4}, [CL_TBS] = {5}, [CL_CNK] = {6}, [CL_TD] = {7} WHERE MaTS = {8} AND MaLoai = {9}", _
                          CStr(ThongSo.NG_NS), _
                          CStr(ThongSo.NG_TBS), _
                          CStr(ThongSo.NG_CNK), _
                          CStr(ThongSo.NG_TD), _
                          CStr(ThongSo.CL_NS), _
                          CStr(ThongSo.CL_TBS), _
                          CStr(ThongSo.CL_CNK), _
                          CStr(ThongSo.CL_TD), _
                          ConvertToStrSafe(maso), _
                          ConvertToStrSafe(IIf(ThangTang = 0, DK_LOAI, NV_TANG)))
                If ExecSQLNonQuery(sql) <> 0 Then
                    result = -1
                    GoTo KhongDC
                End If
            End If
        End If
        Return result
KhongDC:
        Return result
    End Function
    ''' <summary>
    ''' Tổng nguyên giá
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TongNguyenGia() As Double
        Get
            Return ThongSo.NG_NS + ThongSo.NG_TBS + ThongSo.NG_CNK + ThongSo.NG_TD
        End Get
    End Property
    ''' <summary>
    ''' Tổng giá trị còn lại
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TongGiaTri() As Double
        Get
            Return ThongSo.CL_NS + ThongSo.CL_TBS + ThongSo.CL_CNK + ThongSo.CL_TD
        End Get
    End Property
    ''' <summary>
    ''' Điều chỉnh lại chứng từ tăng
    ''' </summary>
    ''' <param name="tong_ng"></param>
    ''' <param name="tong_hm"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SetChungtuTang(ByRef tong_ng As Double, ByRef tong_hm As Double) As Integer
        Dim result As Integer = 0
        Dim ctu As New ClsChungtu
        Dim sopsco, sopsno, tongpsco As Double
        Dim sopsts As Integer
        Dim sopsnots, sohmcu As Double
        result = -1
        Dim rs_ps As DataTable = ExecSQLReturnDT(String.Format("SELECT ChungTu.MaSo, ChungTu.SoPS, ChungTu.MaTKNo, ChungTu.MaTKCo, HeThongTK.TK_ID AS IDNo, HeThongTK_1.TK_ID AS IDCo FROM ((CTTaiSan INNER JOIN ChungTu ON CTTaiSan.MaCTKT = ChungTu.MaCT) LEFT JOIN HeThongTK ON ChungTu.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKCo = HeThongTK_1.MaSo WHERE (CTTaiSan.MaTS = {0}) AND (CTTaiSan.MaLoai = {1})", _
                                                     maso, _
                                                     ConvertToStrSafe(NV_TANG)))
        If rs_ps.Rows.Count > 0 Then


            Dim rsPsItem0 As DataRow = rs_ps.Rows(0)
            If ConvertToDblSafe(rsPsItem0("MaTkNo")) = 0 Or ConvertToDblSafe(rsPsItem0("MaTkCo")) = 0 Then
                For Each rsPsItem As DataRow In rs_ps.Rows
                    If ConvertToDblSafe(rsPsItem("MaTkNo")) > 0 Then
                        If ConvertToDblSafe(rsPsItem("IDNO")) = TSCD_ID Then
                            ctu.InitChungtu(ConvertToDblSafe(rsPsItem("maso")), _
                                0, _
                                String.Empty, _
                                0, _
                                DateTime.Today, _
                                DateTime.Today, _
                                0, _
                                0, _
                                String.Empty, _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                String.Empty, _
                                0, _
                                DateTime.Today)
                            ctu.XoaChungtu()
                            ctu.sops = tong_ng
                            ctu.GhiChungtu()
                        Else
                            sopsno += ConvertToDblSafe(rsPsItem("sops"))
                        End If
                    Else
                        If ConvertToDblSafe(rsPsItem("IDCO")) = KHTSCD_ID Then
                            ctu.InitChungtu(ConvertToDblSafe(rsPsItem("maso")), _
                                0, _
                                "", _
                                0, _
                                DateTime.Today, _
                                DateTime.Today, _
                                0, _
                                0, _
                                "", _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                "", _
                                0, DateTime.Today)
                            ctu.XoaChungtu()
                            If tong_hm > 0 Then
                                ctu.sops = tong_hm
                                ctu.GhiChungtu()
                            End If
                        Else
                            sopsco += ConvertToDblSafe(rsPsItem("sops"))
                        End If
                    End If
                Next
                tongpsco = tong_ng - tong_hm + sopsno
                Dim isFirst As Boolean = True
                For Each rsPsItem As DataRow In rs_ps.Rows
                    If isFirst Then
                        isFirst = False
                        Continue For
                    End If
                    If ConvertToDblSafe(rsPsItem("MaTkCo")) > 0 And ConvertToDblSafe(rsPsItem("IDCO")) <> KHTSCD_ID Then
                        ctu.InitChungtu(ConvertToDblSafe(rsPsItem("maso")), _
                            0, _
                            "", _
                            0, _
                            DateTime.Today, _
                            DateTime.Today, _
                            0, _
                            0, _
                            "", _
                            0, _
                            0, _
                            0, _
                            0, _
                            0, _
                            0, _
                            "", _
                            0, DateTime.Today)
                        ctu.XoaChungtu()
                        ctu.sops = RoundMoney(ConvertToDblSafe(rsPsItem("sops")) * tongpsco / sopsco)
                        ctu.GhiChungtu()
                    End If
                Next
            Else
                For Each rsPsItem As DataRow In rs_ps.Rows
                    If ConvertToDblSafe(rsPsItem("IDNO")) = TSCD_ID Then
                        sopsts += 1
                        If rsPsItem("sops") IsNot Nothing Then
                            sopsnots += ConvertToDblSafe(rsPsItem("sops"))
                        End If

                    Else
                        If rsPsItem("sops") IsNot Nothing Then
                            sopsno += ConvertToDblSafe(rsPsItem("sops"))
                        End If

                    End If
                    If ConvertToDblSafe(rsPsItem("IDCO")) <> KHTSCD_ID Then
                        If rsPsItem("sops") IsNot Nothing Then
                            sopsco += ConvertToDblSafe(rsPsItem("sops"))
                        End If

                    Else
                        If rsPsItem("sops") IsNot Nothing Then
                            sohmcu = ConvertToDblSafe(rsPsItem("sops"))
                        End If

                    End If
                Next
                Dim isFirst As Boolean = True
                If sopsts > 1 Then
                    For Each rsPsItem As DataRow In rs_ps.Rows
                        If isFirst Then
                            isFirst = False
                            Continue For
                        End If
                        If ConvertToDblSafe(rsPsItem("IDNO")) = TSCD_ID Then
                            ctu.InitChungtu(ConvertToDblSafe(rsPsItem("maso")), _
                                0, _
                                "", _
                                0, _
                                DateTime.Today, _
                                DateTime.Today, _
                                0, _
                                0, _
                                "", _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                "", _
                                0, DateTime.Today)
                            ctu.XoaChungtu()
                            If rsPsItem("sops") IsNot Nothing Then
                                ctu.sops = RoundMoney(ConvertToDblSafe(rsPsItem("sops")) * tong_ng / sopsnots)
                            End If

                            ctu.GhiChungtu()
                        End If
                    Next
                Else
                    For Each rsPsItem As DataRow In rs_ps.Rows
                        If isFirst Then
                            isFirst = False
                            Continue For
                        End If
                        If ConvertToDblSafe(rsPsItem("IDNO")) = TSCD_ID Then
                            ctu.InitChungtu(ConvertToDblSafe(rsPsItem("maso")), _
                                0, _
                                "", _
                                0, _
                                DateTime.Today, _
                                DateTime.Today, _
                                0, _
                                0, _
                                "", _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                "", _
                                0, DateTime.Today)
                            ctu.XoaChungtu()
                            If rsPsItem("sops") IsNot Nothing Then
                                ctu.sops = RoundMoney(ConvertToDblSafe(rsPsItem("sops")) * tong_ng / sopsnots)
                            End If

                            ctu.GhiChungtu()
                        End If
                    Next
                End If
            End If
        End If
        result = 0
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New()
        ThangGiam = 13
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Protected Overrides Sub Finalize()
        ThongSo = Nothing
    End Sub
End Class
