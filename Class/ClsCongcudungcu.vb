Imports System
Imports System.Data
Imports System.Media
Imports UNET.Utility
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Friend Class ClsCongcudungcu
    ''' <summary>
    ''' Thuộc tính
    ''' </summary>
    ''' <remarks></remarks>
    Public MaSo As Integer ' Mã số
    Public ten As String = String.Empty ' Tên công cụ dụng cụ
    Public SoHieu As String = String.Empty ' Số hiệu
    Public MaTaiKhoan As Integer ' Mã tài khoản công cụ dụng cụ
    Public maloai As Integer ' Mã phân loại công cụ dụng cụ
    Public ThangTang As Integer ' Tháng tăng (0 nếu tăng từ các năm trước)
    Public ThangNhap As Integer ' Tháng nhập (0 nếu nhập từ các năm trước)
    Public ThangGiam As Integer ' Tháng giảm (13 nếu chưa giảm trong năm)
    Private _ThongSo As clsThongSo = Nothing
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
    Public NamSD As Integer
    Public NamSX As Integer

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

    ''' <summary>
    '''Kiểm tra tính hợp lệ của dữ liệu
    '''Trả về : 0 nếu đúng, -1 nếu có lỗi
    ''' </summary>
    ''' <remarks></remarks>
    Public Function HopLe(ByVal pNhapdauky As Boolean) As Integer
        Dim thong_bao As String
        If ThangNhap > ThangTang And Not pNhapdauky And cuongdauky <> 5 Then
            thong_bao = "Tháng xuất >= tháng nhập" : Else
            If (SoHieu.Length = 0 Or SoHieu = "(...)") And cuongdauky <> 5 Then
                thong_bao = "Thiếu số hiệu công cụ dụng cụ" : Else
                If cuongccdcsoluong = 0 And cuongdauky = 2 Then
                    thong_bao = "Thiếu số lượng công cụ dụng cụ" : Else
                    If ten.Length = 0 Or ten = "(...)" And cuongdauky <> 5 Then
                        thong_bao = "Thiếu tên công cụ dụng cụ" : Else
                        ' Các đối tượng quan hệ
                        If MaTaiKhoan = 0 Then
                            thong_bao = "Thiếu hoặc chưa đăng ký tài khoản công cụ dụng cụ" : Else
                            If maloai = 0 And Not pNhapdauky Then
                                thong_bao = "Thiếu hoặc chưa đăng ký phân loại công cụ dụng cụ" : Else
                                ' KiĨm tra Số hiệu
                                If ThangGiam = 0 Then ThangGiam = 13
                                Return ThongSo.HopLe()
                            End If
                        End If
                    End If
                End If
            End If
        End If
        SystemSounds.Beep.Play()
        MessageBox.Show(thong_bao, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return -1
    End Function
    ''' <summary>
    ''' Ghi đối tượng công cụ dụng cụ hiện tại vào cơ sở dữ liệu.
    '''     - Ghi công cụ dụng cụ vào bảng Congcudungcu
    '''     - Tạo các bản ghi chứa giá trị hàng tháng (từ tháng 0 cho đến hết năm)
    '''Trả về : 0 nếu thành công, -1 nếu có lỗi
    '''Chú ý : Mã số của đối tượng công cụ dụng cụ hiện tại sẽ được đặt khác 0 sau thủ tục này.
    ''' </summary>
    ''' <remarks></remarks>
    Public Function ThemMoi(Optional ByRef pNhapdauky As Boolean = False) As Integer
        Dim result As Integer = 0
        Dim ts1 As clsThongSo
        If shct.Length = 0 Then shct = "..."
        ' Ghi công cụ dụng cụ
        Dim sql As String = String.Format("INSERT INTO Congcudungcu (MaSo, Sohieu, Ten, MaTaiKhoan, MaLoai, ThangTang, ThangGiam,NamKH,SHCT, NCT,namsd,namsx) VALUES ({0}, N'{1}', N'{2}',{3},{4},{5},{6},{7}, N'{8}', N'{9}',{10},{11})", _
                                Lng_MaxValue("MaSo", "Congcudungcu") + 1, _
                                SoHieu, _
                                ten, _
                                ConvertToStrSafe(MaTaiKhoan), _
                                ConvertToStrSafe(maloai), _
                                ConvertToStrSafe(ThangTang), _
                                ConvertToStrSafe(ThangGiam), _
                                ConvertToStrSafe(NamKH), _
                                shct, _
                                Format(NCT, Mask_DB), _
                                ConvertToStrSafe(NamSD), _
                                ConvertToStrSafe(NamSX))
        ' Ghi các thông số cho các tháng trong năm
        If ExecSQLNonQuery(sql) = 0 Then
            MaSo = Lng_MaxValue("MaSo", "Congcudungcu")
            ThongSo.MaTS = MaSo
            For chi_so As Integer = 0 To 12
                If chi_so >= CThangDB2(ThangNhap) And chi_so <= CThangDB2(ThangGiam) Then
                    ThongSo.thang = chi_so
                    If chi_so >= CThangDB2(ThangNhap) Then 'kh1 = 1
                        If chi_so < CThangDB2(ThangTang) Then
                            ts1 = New clsThongSo()
                            ThongSo.DanXuat(ts1)
                            ThongSo.KH_NS = 0
                            ThongSo.KH_TBS = 0
                            ThongSo.KH_TD = 0
                            ThongSo.KH_CNK = 0
                            result = ThongSo.ThemMoi1()
                            ts1.DanXuat(ThongSo)
                            ts1 = Nothing
                        Else
                            result = ThongSo.ThemMoi1()
                        End If
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
    ''' Gán các thuộc tính của đối tượng công cụ dụng cụ hiện tại theo giá trị lưu trong cơ sở dữ liệu
    '''   Tham số : Mã công cụ dụng cụ cần lấy thông tin, thời gian (để xác định các thông số)
    '''   Sử dụng : Thủ tục ChiDinh trong clsThongSo
    '''   Chú ý : Không kiểm tra tham số khi thực hiện
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ChiDinh(ByRef ma_so As Integer, ByRef thang_cd As Integer)
        Dim sql As String = String.Format("SELECT * FROM Congcudungcu WHERE MaSo = {0}", ma_so)
        Dim rs_Congcudungcu As DataTable = ExecSQLReturnDT(sql)
        ' Chi tiết
        If rs_Congcudungcu.Rows.Count > 0 Then
            Dim rs_CongcudungcuItem As DataRow = rs_Congcudungcu.Rows(0)
            If rs_CongcudungcuItem("MaSo") IsNot Nothing Then
                MaSo = ConvertToDblSafe(rs_CongcudungcuItem("MaSo"))
            End If
            If rs_CongcudungcuItem("SoHieu") IsNot Nothing Then
                SoHieu = ConvertToStrSafe(rs_CongcudungcuItem("SoHieu"))
            End If
            If rs_CongcudungcuItem("ten") IsNot Nothing Then
                ten = rs_CongcudungcuItem("ten")
            End If

            If SoHieu <> "(...)" And SoHieu <> "..." And SoHieu <> "" Then
                lenma += 1
                ReDim Preserve cuongccdcma(lenma)
                If rs_CongcudungcuItem("SoHieu") IsNot Nothing Then
                    cuongccdcma(lenma - 1) = ConvertToStrSafe(rs_CongcudungcuItem("SoHieu"))
                End If

                If rs_CongcudungcuItem("NamSX") > 0 Then
                    cuongccdcsoluong = rs_CongcudungcuItem("NamSX")
                Else
                    cuongccdcsoluong = ConvertToDblSafe(GetSelectValue(String.Format("SELECT chungtu.sops2co AS f1 FROM chungtu,congcudungcu WHERE congcudungcu.maso={0} AND congcudungcu.shct=LEFT(chungtu.sohieu,len(congcudungcu.shct)) AND congcudungcu.thangtang=chungtu.thangct AND chungtu.maloai=2 AND chungtu.mavattu={1} ORDER BY chungtu.maso", _
                                                                           MaSo, _
                                                                           Timten("maso", cuongccdcma(lenma - 1), "sohieu", "vattu"))))
                End If
                ThangNhap = ConvertToDblSafe(GetSelectValue(String.Format("SELECT chungtu.thangct AS f1,chungtu.sohieu AS f2 FROM chungtu,congcudungcu WHERE congcudungcu.shct=chungtu.sohieu AND chungtu.maloai=13 AND chungtu.mavattu={0}AND Congcudungcu.MaSo = {1}", _
                                                                Timten("maso", cuongccdcma(lenma - 1), "sohieu", "vattu"), _
                                                                ConvertToStrSafe(MaSo))))
            End If
            ' Các đối tượng quan hệ
            If rs_CongcudungcuItem("MaTaiKhoan") IsNot Nothing Then
                MaTaiKhoan = ConvertToDblSafe(rs_CongcudungcuItem("MaTaiKhoan"))
            End If
            If rs_CongcudungcuItem("maloai") IsNot Nothing Then
                maloai = ConvertToDblSafe(rs_CongcudungcuItem("maloai"))
            End If
            If rs_CongcudungcuItem("ThangTang") IsNot Nothing Then
                ThangTang = ConvertToDblSafe(rs_CongcudungcuItem("ThangTang"))
            End If
            If rs_CongcudungcuItem("ThangGiam") IsNot Nothing Then
                ThangGiam = ConvertToDblSafe(rs_CongcudungcuItem("ThangGiam"))
            End If
            If rs_CongcudungcuItem("NamKH") IsNot Nothing Then
                NamKH = ConvertToDblSafe(rs_CongcudungcuItem("NamKH"))
            End If
            If rs_CongcudungcuItem("shct") IsNot Nothing Then
                shct = ConvertToStrSafe(rs_CongcudungcuItem("shct"))
            End If
            If rs_CongcudungcuItem("NCT") IsNot Nothing Then
                NCT = ConvertToStrSafe(rs_CongcudungcuItem("NCT"))
            End If

            ' Thông số của tháng được chỉ định
            If thang_cd > 0 Then ThongSo.ChiDinh1(ma_so, thang_cd)
        Else
            Init()
        End If
        ''rs_Congcudungcu.Close()
    End Sub
    ''' <summary>
    ''' KhoiTao
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Init()
        MaSo = 0
        ten = "(...)"
        SoHieu = "(...)"
        MaTaiKhoan = 0
        maloai = 0
        ThangTang = 0
        ThangNhap = 0
        NamKH = 0
        ThangGiam = 13
        shct = "..."
        ThongSo.KhoiTao()
    End Sub
    ''' <summary>
    ''' Sửa đổi nội dung của đối tượng công cụ dụng cụ hiện thời
    '''   - Các thông số cố định
    '''   - Các thay đổi luỹ tiến về lượng khấu hao và các đối tượng quan hệ
    '''   - Các thay đổi về giá trị công cụ dụng cụ (được cập nhật đồng thời với chứng từ tăng
    '''      hoặc chứng từ đầu kỳ tương ứng)
    '''Chú ý : Đối với công cụ dụng cụ đã bị giảm trong năm thì các thay đổi về lượng khấu hao và
    '''giá trị là không được phép vì sẽ dẫn đến mâu thuẫn với chứng từ giảm đã ghi.
    ''' </summary>
    ''' <remarks></remarks>
    Public Function SuaDoi(ByRef pNhapdauky As Boolean) As Integer
        Dim result As Integer = 0
        Dim sql1, sql, sql2 As String
        Dim ct1 As New ClsChungtu
        Dim ct2 As New ClsChungtu
        If shct.Length = 0 Then shct = "..."
        ' Thay đổi các thông số cố định
        Dim MaSo1 As Integer
        If Not pNhapdauky Then
            sql = String.Format("UPDATE Congcudungcu SET sohieu=N'{0}',Ten =N'{1}',NamKH={2}, MaTaiKhoan = {3}, MaLoai = {4}, NCT=N'{5}' WHERE MaSo = {6}", _
                      cuongccdcma(lenma - 1), _
                      ten, _
                      ConvertToStrSafe(NamKH), _
                      ConvertToStrSafe(MaTaiKhoan), _
                      ConvertToStrSafe(maloai), _
                      Format(NCT, Mask_DB), _
                      ConvertToStrSafe(MaSo))
            MaSo1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT chungtu.ct_id AS f1 FROM chungtu,congcudungcu WHERE congcudungcu.maso={0} AND congcudungcu.shct=LEFT(chungtu.sohieu,len(chungtu.sohieu)-2) AND congcudungcu.thangtang=chungtu.thangct AND chungtu.maloai=2 AND chungtu.mavattu={1} ORDER BY chungtu.maso", _
                                                        MaSo, _
                                                        Timten("maso", cuongccdcma(lenma - 1), "sohieu", "vattu"))))
            sql1 = String.Format("UPDATE Chungtu SET sops2no={0} WHERE maso={1}", _
                       cuongccdcsoluong, _
                       ConvertToStrSafe(MaSo1 - 900000000))
            sql2 = String.Format("UPDATE Chungtu SET sops2co={0} WHERE ct_id={1}", _
                       cuongccdcsoluong, _
                       ConvertToStrSafe(MaSo1))
            If ExecSQLNonQuery(sql) <> 0 Then
                If MaSo1 <> 0 Then
                    If ExecSQLNonQuery(sql1) <> 0 Or ExecSQLNonQuery(sql2) <> 0 Then : Return -1
                    End If
                Else
                    MessageBox.Show(String.Format("Không xác định được chứng từ!{0}Vui lòng xóa những công cụ liên quan đến chứng từ này và nhập lại!", Environment.NewLine), _
                        My.Application.Info.ProductName, _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Exclamation)
                End If
                TinhTonKho(ct2.MaKho, ct2.TkCo.maso, ConvertToDblSafe(Timten("maso", SoHieu, "sohieu", "vattu")), Month(ct2.NgayCT), 1, ConvertToStrSafe(cuongccdcsoluong), ThongSo.NG_TBS, ct2.PSUSD, 1)
            End If
        Else
            sql = String.Format("UPDATE Congcudungcu SET NamKH={0}, NamSX={1}, MaTaiKhoan = {2}, MaLoai = {3}, NCT=N'{4}' WHERE MaSo = {5}", _
                      NamKH, _
                      ConvertToStrSafe(cuongccdcsoluong), _
                      ConvertToStrSafe(MaTaiKhoan), _
                      ConvertToStrSafe(maloai), _
                      Format(NCT, Mask_DB), _
                      ConvertToStrSafe(MaSo))
            If ExecSQLNonQuery(sql) <> 0 Then
                Return -1
            End If
        End If

        ' Nếu công cụ dụng cụ đã bị ghi chứng từ giảm thì phải xoá chứng từ này đi mới có thể sửa đổi giá trị
        If Not (ThangGiam = 13) Then
            result = -2
            GoTo KhongDC
        End If
        ' Thay đổi nguyên giá, lượng hao mòn, khấu hao và các đối tượng quan hệ
        Dim tong_ng, tong_hm As Double
        Dim tsts As clsThongSo
        If ThangTang > 0 And ThongSo.thang = CThangDB2(ThangTang) Then
            tsts = New clsThongSo()
            tsts.ChiDinh1(MaSo, ThangTang)
            If (tsts.NG_NS + tsts.NG_TBS + tsts.NG_CNK + tsts.NG_TD <> ThongSo.NG_NS + ThongSo.NG_TBS + ThongSo.NG_CNK + ThongSo.NG_TD) Or (tsts.CL_NS + tsts.CL_TBS + tsts.CL_CNK + tsts.CL_TD <> ThongSo.CL_NS + ThongSo.CL_TBS + ThongSo.CL_CNK + ThongSo.CL_TD) Then
                tong_ng = (ThongSo.NG_NS + ThongSo.NG_TBS + ThongSo.NG_CNK + ThongSo.NG_TD)
                tong_hm = tong_ng - (ThongSo.CL_NS + ThongSo.CL_TBS + ThongSo.CL_CNK + ThongSo.CL_TD)
                If Not pNhapdauky Then
                    If SetChungtuTang(tong_ng, tong_hm) <> 0 Then GoTo KhongDC
                End If
            End If
            tsts = Nothing
        End If

        result = ThongSo.SuaDoiQuanHe1()
        ' Thay đổi nguyên giá, giá trị còn lại lưu trong chứng từ tăng công cụ dụng cụ đầu kỳ và trong các tháng
        ' trước tháng đầu kỳ (Chú ý : các dòng mã dưới đây chỉ được thực hiện ở tháng đầu kỳ)
        '      If ThongSo.Thang = pThangDauKy Then
        If (ThongSo.thang = 1 Or ThongSo.thang = CThangDB2(ThangTang)) And (Not KhongDCCCDC(MaSo)) Then
            sql = String.Format("SELECT MaSo AS F1 FROM CTCongcudungcu WHERE MaTS = {0} AND Thang = {1} AND MaLoai = {2}", _
                      MaSo, _
                      ConvertToStrSafe(ThongSo.thang), _
                      ConvertToStrSafe(NV_DGLAI))
            If IsDBNull(GetSelectValue(sql)) Then
                result = -3
                GoTo KhongDC
            Else
                result = ThongSo.SuaDoiGiaTri1()
                If result = -1 Then GoTo KhongDC
                sql = String.Format("UPDATE CTCongcudungcu SET NG_NS = {0}, NG_TBS = {1}, NG_CNK = {2}, NG_TD = {3}, CL_NS = {4}, CL_TBS = {5}, CL_CNK = {6}, CL_TD = {7} WHERE MaTS = {8} AND MaLoai = {9}", _
                          CStr(ThongSo.NG_NS), _
                          CStr(ThongSo.NG_TBS), _
                          CStr(ThongSo.NG_CNK), _
                          CStr(ThongSo.NG_TD), _
                          CStr(ThongSo.CL_NS), _
                          CStr(ThongSo.CL_TBS), _
                          CStr(ThongSo.CL_CNK), _
                          CStr(ThongSo.CL_TD), _
                          ConvertToStrSafe(MaSo), _
                          ConvertToStrSafe(IIf(pNhapdauky, DK_LOAI, NV_TANG)))
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
    ''' CLASS
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadOnly Property TongNguyenGia() As Double
        Get
            Return ThongSo.NG_NS + ThongSo.NG_TBS + ThongSo.NG_CNK + ThongSo.NG_TD
        End Get
    End Property
    ''' <summary>
    ''' Tổng giá trị còn lại
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadOnly Property TongGiaTri() As Double
        Get
            Return ThongSo.CL_NS + ThongSo.CL_TBS + ThongSo.CL_CNK + ThongSo.CL_TD
        End Get
    End Property
    ''' <summary>
    ''' Điều chỉnh lại chứng từ tăng
    ''' </summary>
    ''' <remarks></remarks>
    Private Function SetChungtuTang(ByRef tong_ng As Double, ByRef tong_hm As Double) As Integer
        Dim result As Integer = 0
        Dim ctu As New ClsChungtu
        Dim sopsco, sopsno, tongpsco As Double
        Dim sopsts As Integer
        Dim sopsnots, sohmcu As Double
        result = -1
        Dim MaSo1 As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT chungtu.ct_id AS f1 FROM chungtu,congcudungcu WHERE congcudungcu.maso={0} AND congcudungcu.shct=LEFT(chungtu.sohieu,len(chungtu.sohieu)-2) AND congcudungcu.thangtang=chungtu.thangct AND chungtu.maloai=2 AND chungtu.mavattu={1} ORDER BY chungtu.maso", _
                                                                   MaSo, _
                                                                   Timten("maso", cuongccdcma(lenma - 1), "sohieu", "vattu"))))
        Dim rs_ps As DataTable = ExecSQLReturnDT(String.Format("SELECT ChungTu.MaSo, ChungTu.SoPS, ChungTu.MaTKNo, ChungTu.MaTKCo, HeThongTK.TK_ID AS IDNo, HeThongTK_1.TK_ID AS IDCo FROM ((CTCongcudungcu INNER JOIN ChungTu ON CTCongcudungcu.MaCTKT = ChungTu.MaCT) LEFT JOIN HeThongTK ON ChungTu.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKCo = HeThongTK_1.MaSo WHERE chungtu.maso={0} AND (chungtu.mavattu={1})AND(CTCongcudungcu.MaTS = {2}) AND (CTCongcudungcu.MaLoai = {3})", _
                                                     ConvertToStrSafe(MaSo1 - 900000000), _
                                                     Timten("maso", cuongccdcma(lenma - 1), "sohieu", "vattu"), _
                                                     MaSo, _
                                                     ConvertToStrSafe(NV_TANG)))
        Dim sopsxt As Double
        Dim ctucuoi As DataTable
        Dim rs_psItem0 As DataRow = rs_ps.Rows(0)
        If ConvertToDblSafe(rs_psItem0("MaTkNo")) = 0 Or ConvertToDblSafe(rs_psItem0("MaTkCo")) = 0 Then
            Dim rs_psIndex As Integer = 0
            Do While rs_psIndex < rs_ps.Rows.Count
                Dim rs_psItem As DataRow = rs_ps.Rows(rs_psIndex)
                rs_psIndex += 1 ' C15 Rs LOOP CONTROL
                If ConvertToDblSafe(rs_psItem("MaTkNo")) > 0 Then
                    If ConvertToDblSafe(rs_psItem("IDNO")) = 1000 Then 'TSCD_ID
                        ctu.InitChungtu(ConvertToDblSafe(rs_psItem("MaSo")), _
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
                            0, _
                            DateTime.Today)
                        ctu.XoaChungtu()
                        ctu.sops = tong_ng
                        ctu.GhiChungtu()
                    Else
                        sopsno += ConvertToDblSafe(rs_psItem("sops"))
                    End If
                Else
                    If ConvertToDblSafe(rs_psItem("IDCO")) = 0 Then 'KHTSCD_ID
                        ctu.InitChungtu(ConvertToDblSafe(rs_psItem("MaSo")), _
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
                        sopsco += rs_psItem("sops")
                    End If
                End If
                'rs_ps.MoveNext()
            Loop
            tongpsco = tong_ng - tong_hm + sopsno
            'rs_ps.MovePrevious()
            rs_psIndex = rs_ps.Rows.Count - 1
            Do While rs_psIndex > 0
                Dim rs_psItem As DataRow = rs_ps.Rows(rs_psIndex)
                rs_psIndex -= 1 ' C15 Rs LOOP CONTROL
                If ConvertToDblSafe(rs_psItem("MaTkCo")) > 0 And ConvertToStrSafe(rs_psItem("IDCO")) <> 0 Then 'KHTSCD_ID
                    If rs_psItem("MaSo") IsNot Nothing Then
                        ctu.InitChungtu(rs_psItem("MaSo"), 0, "", 0, DateTime.Today, DateTime.Today, 0, 0, "", 0, 0, 0, 0, 0, 0, "", 0, DateTime.Today)
                    End If

                    ctu.XoaChungtu()
                    If rs_psItem("sops") IsNot Nothing Then
                        ctu.sops = RoundMoney(ConvertToDblSafe(rs_psItem("sops")) * tongpsco / sopsco)
                    End If

                    ctu.GhiChungtu()
                End If
                'rs_ps.MovePrevious()
            Loop
        Else
            Dim rs_psIndex As Integer = 0
            Do While rs_psIndex < rs_ps.Rows.Count
                Dim rs_psItem As DataRow = rs_ps.Rows(rs_psIndex)
                rs_psIndex += 1 ' C15 Rs LOOP CONTROL
                If ConvertToStrSafe(rs_psItem("IDNO")) = 1000 Or ConvertToStrSafe(rs_psItem("IDCO")) = 1000 Then 'TSCD_ID
                    sopsts += 1
                    If rs_psItem("sops") IsNot Nothing Then
                        sopsnots += rs_psItem("sops")
                    End If

                Else
                    If rs_psItem("sops") IsNot Nothing Then
                        sopsno += rs_psItem("sops")
                    End If

                End If
                If ConvertToStrSafe(rs_psItem("IDCO")) <> 0 Then 'KHTSCD_ID
                    If rs_psItem("sops") IsNot Nothing Then
                        sopsco += rs_psItem("sops")
                    End If

                Else
                    If rs_psItem("sops") IsNot Nothing Then
                        sohmcu = rs_psItem("sops")
                    End If

                End If
                'rs_ps.MoveNext()
            Loop
            'rs_ps.MovePrevious()
            If sopsts > 1 Then
                rs_psIndex = rs_ps.Rows.Count - 1
                Do While rs_psIndex > 0
                    Dim rs_psItem As DataRow = rs_ps.Rows(rs_psIndex)
                    rs_psIndex -= 1 ' C15 Rs LOOP CONTROL
                    If ConvertToStrSafe(rs_psItem("IDNO")) = 1000 Then 'TSCD_ID
                        If rs_psItem("MaSo") IsNot Nothing Then
                            ctu.InitChungtu(rs_psItem("MaSo"), 0, "", 0, DateTime.Today, DateTime.Today, 0, 0, "", 0, 0, 0, 0, 0, 0, "", 0, DateTime.Today)
                        End If
                        ctu.InitChungtu(rs_psItem("MaSo"), 0, "", 0, DateTime.Today, DateTime.Today, 0, 0, "", 0, 0, 0, 0, 0, 0, "", 0, DateTime.Today)
                        ctu.XoaChungtu()
                        If rs_psItem("sops") IsNot Nothing Then
                            ctu.sops = RoundMoney(ConvertToStrSafe(rs_psItem("sops")) * tong_ng / sopsnots)
                        End If

                        ctu.GhiChungtu()
                    End If
                    'rs_ps.MovePrevious()
                Loop
            Else
                rs_psIndex = rs_ps.Rows.Count - 1
                Do While rs_psIndex > 0
                    Dim rs_psItem As DataRow = rs_ps.Rows(rs_psIndex)
                    rs_psIndex -= 1 ' C15 Rs LOOP CONTROL
                    If ConvertToStrSafe(rs_psItem("IDNO")) = 1000 Then 'TSCD_ID
                        '***************************** Sua thong tin chung tu ********************************
                        If rs_psItem("MaSo") IsNot Nothing Then
                            ctu.InitChungtu(rs_psItem("MaSo"), 0, "", 0, DateTime.Today, DateTime.Today, 0, 0, "", 0, 0, 0, 0, 0, 0, "", 0, DateTime.Today)
                        End If

                        ctu.XoaChungtu()
                        If rs_psItem("sops") IsNot Nothing Then
                            ctu.sops = RoundMoney(ConvertToStrSafe(rs_psItem("sops")) * tong_ng / sopsnots)
                        End If

                        sopsxt = ctu.sops
                        ctu.GhiChungtu()
                        '*************************** Sua  thong tin chung tu xuat thang moi **************************
                        ctu.InitChungtu(ConvertToDblSafe((rs_psItem("MaSo")) + 1), _
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
                            0, _
                            DateTime.Today)
                        ctu.XoaChungtu()
                        ctu.sops = sopsxt
                        ctucuoi = ExecSQLReturnDT("SELECT * FROM chungtu")
                        rs_psIndex = rs_ps.Rows.Count
                        ctu.CT_ID = ConvertToDblSafe(ctucuoi.Rows(0)(0) + 900000000)
                    End If
                    ctu.GhiChungtu()
                Loop
            End If
        End If
        result = 0
        Return result
    End Function
End Class
