Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Friend Class ClsQuanLyNhanVien
    Public MaSo As Integer
    Public MaPhanLoai As Integer
    Public MaChucvu As Integer
    Public SoHieu As String = String.Empty
    Public ten As String = String.Empty
    Public Phai As String = String.Empty
    Public DiaChiHoKhau As String = String.Empty
    Public DiaChiCuTru As String = String.Empty
    Public PhuongXahk As Integer
    Public QuanHuyenhk As Integer
    Public TinhTPhk As Integer
    Public QuocGia As Integer
    Public PhuongXact As Integer
    Public QuanHuyenct As Integer
    Public TinhTPct As Integer
    Public NgaySinh As Date
    Public CMND As String = String.Empty
    Public Ngaycap As Date
    Public NoiCap As Integer
    Public Tel1 As String = String.Empty
    Public Baohiem As Double
    Public BacLuong As Double
    Public Nghiviec As CheckState
    Public Ngaynghi As Date
    Public Thaisan As CheckState
    Public tungay As Date
    Public denngay As Date
    Public LoaiHD As Integer
    Public LoaiLuong As Integer
    Public Giamld As CheckState
    Public tuthang As Integer
    Public denthang As Integer
    Public Tang As CheckState
    Public ThangTang As Integer
    Public SoBHXH As String = String.Empty
    Public SoBHYT As String = String.Empty
    Public The As CheckState
    Public Tu As Integer
    Public Den As Integer
    Public Tangbh As CheckState
    Public ThangTangbh As Integer
    Public MST As String = String.Empty

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New()
        init()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub init()
        MaPhanLoai = 0
        MaChucvu = 0
        SoHieu = "..."
        ten = "..."
        DiaChiHoKhau = "..."
        DiaChiCuTru = "..."
        PhuongXact = 0
        QuanHuyenct = 0
        TinhTPct = 0
        QuocGia = 0
        PhuongXahk = 0
        QuanHuyenhk = 0
        TinhTPhk = 0
        CMND = "0"
        NoiCap = 0
        Tel1 = "..."
        Baohiem = 0
        BacLuong = 0
        Nghiviec = CheckState.Unchecked
        Thaisan = CheckState.Unchecked
        LoaiLuong = 0
        LoaiHD = 0
        Giamld = CheckState.Unchecked
        tuthang = 0
        denthang = 0
        Tang = CheckState.Unchecked
        ThangTang = 0
        SoBHXH = ""
        SoBHYT = ""
        The = CheckState.Unchecked
        Tu = 0
        Den = 0
        Tangbh = CheckState.Unchecked
        ThangTangbh = 0
        MST = ""
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhiNV() As Integer
        Dim result As Integer = 0
        Dim sohd As Integer
        Dim chucvu As String = Timten("ten", ConvertToStrSafe(MaChucvu), "maso", "Chucvu")
        If chucvu = "Giám Đốc" Then
            sohd = 1
        Else
            If chucvu = "Phó Giám Đốc" Or chucvu = "P. Giám Đốc" Or chucvu = "P.Giám Đốc" Then
                sohd = 2
            Else
                If chucvu = "Kế Toán Trưởng" Then
                    sohd = 3
                Else
                    sohd = Lng_MaxValue("sohd", "quanlynhanvien") + 1
                End If
            End If
        End If

        Dim tam As String = String.Format("INSERT INTO QuanLyNhanVien (mst,sohd,TuThang,DenThang,Giamld,LoaiHD,LoaiLuong,MaSo, MaPhanLoai,MaChucVu, SoHieu, Ten, Phai, NgaySinh, CMND,ngaycap,noicap, Tel1, baohiem, DiaChiHK, PhuongXaHK, quanhuyenhk, tinhtphk, quoctich, DiaChiCT, PhuongXaCT, quanhuyenCT, tinhtpCT,BacLuong,nghiviec{0},thaisan{1},tang{2},The{3},TangBH{4})  VALUES (N'{5}',{6},{7},{8},{9},{10},{11},{12},{13},{14}, N'{15}', N'{16}', N'{17}', N'{18}', N'{19}', N'{20}',{21}, N'{22}', N'{23}', N'{24}',{25},{26},{27},{28}, N'{29}',{30},{31},{32},{33},{34}{35},{36}{37},{38}{39},{40}{41},{42}{43})", _
                                                (IIf(Nghiviec = CheckState.Checked, ",ngaynghi", String.Empty)), _
                                                (IIf(Thaisan = CheckState.Checked, ",tungay,denngay", String.Empty)), _
                                                (IIf(Tang = CheckState.Checked, ",thangtang", String.Empty)), _
                                                (IIf(The = CheckState.Checked, ",Tu,Den", String.Empty)), _
                                                (IIf(Tangbh = CheckState.Checked, ",ThangTangBH", String.Empty)), _
                                                MST, _
                                                ConvertToStrSafe(sohd), _
                                                ConvertToStrSafe(tuthang), _
                                                ConvertToStrSafe(denthang), _
                                                IIf(Giamld = CheckState.Checked, "1", "0"), _
                                                ConvertToStrSafe(LoaiHD), _
                                                ConvertToStrSafe(LoaiLuong), _
                                                ConvertToStrSafe(Lng_MaxValue("MaSo", "QuanLyNhanVien") + 1), _
                                                ConvertToStrSafe(MaPhanLoai), _
                                                ConvertToStrSafe(MaChucvu), _
                                                SoHieu, _
                                                ten, _
                                                Phai, _
                                                Format(NgaySinh, Mask_DB), _
                                                CMND, _
                                                Format(Ngaycap, Mask_DB), _
                                                ConvertToStrSafe(NoiCap), _
                                                Tel1, _
                                                ConvertToStrSafe(Baohiem), _
                                                DiaChiHoKhau, _
                                                ConvertToStrSafe(PhuongXahk), _
                                                ConvertToStrSafe(QuanHuyenhk), _
                                                ConvertToStrSafe(TinhTPhk), _
                                                ConvertToStrSafe(QuocGia), _
                                                DiaChiCuTru, _
                                                ConvertToStrSafe(PhuongXact), _
                                                ConvertToStrSafe(QuanHuyenct), _
                                                ConvertToStrSafe(TinhTPct), _
                                                ConvertToStrSafe(BacLuong), _
                                                IIf(Nghiviec = CheckState.Checked, "1", "0"), _
                                                (IIf(Nghiviec = CheckState.Checked, String.Format(", N'{0}'", Format(Ngaynghi, Mask_DB)), String.Empty)), _
                                                IIf(Thaisan = CheckState.Checked, "1", "0"), _
                                                (IIf(Thaisan = CheckState.Checked, String.Format(", N'{0}', N'{1}'", Format(CDate(tungay), Mask_DB), Format(CDate(denngay), Mask_DB)), String.Empty)), _
                                                IIf(Tang = CheckState.Checked, "1", "0"), _
                                                (IIf(Tang = CheckState.Checked, String.Format(",{0}", ThangTang), String.Empty)), _
                                                IIf(The = CheckState.Checked, "1", "0"), _
                                                (IIf(The = CheckState.Checked, String.Format(",{0},{1}", Tu, ConvertToStrSafe(Den)), String.Empty)), _
                                                IIf(Tangbh = CheckState.Checked, "1", "0"), _
                                                (IIf(Tangbh = CheckState.Checked, String.Format(",{0}", ThangTangbh), String.Empty)))

        Dim kq As Integer = ExecSQLNonQuery(tam)
        kq += ExecSQLNonQuery(String.Format("INSERT INTO chucdanh (MaSo, Nhanvien, Chucvu, Bacluong, Loailuong, Ngayapdung, thang, nam)  VALUES ({0}, N'{1}',{2},{3},{4}, N'{5}',{6},{7})", _
                                  Lng_MaxValue("MaSo", "chucdanh") + 1, _
                                  SoHieu, _
                                  ConvertToStrSafe(MaChucvu), _
                                  ConvertToStrSafe(BacLuong), _
                                  ConvertToStrSafe(LoaiLuong), _
                                  Format(DateSerial(pNamTC, IIf(Tang = CheckState.Checked, ThangTang, 1), 1), Mask_DB), _
                                  (IIf(Tang = CheckState.Checked, ConvertToStrSafe(ThangTang), "0")), _
                                  ConvertToStrSafe(pNamTC)))
        'Dim sql As String = String.Format("insert into acc.net.dbo.quanlynhanvien (sohieu,ten) values({0},{1})", _
        '                                                  SoHieu, ten)
        If kq = 0 Then MaSo = Lng_MaxValue("MaSo", "QuanLyNhanVien")

        Return kq
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaNV() As Integer
        Dim result As Integer = 0
        Dim pl As Integer
        Dim shpl As String = String.Empty
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT COUNT(*) AS f1 FROM chucdanh WHERE nhanvien=N'{0}'", SoHieu))) = 0 Then
            ExecSQLNonQuery(String.Format("INSERT INTO chucdanh (MaSo, Nhanvien, Chucvu, Bacluong, Loailuong, Ngayapdung, thang, nam)  VALUES ({0}, N'{1}',{2},{3},{4}, N'{5}',{6},{7})", _
                                Lng_MaxValue("MaSo", "chucdanh") + 1, _
                                SoHieu, _
                                ConvertToStrSafe(MaChucvu), _
                                ConvertToStrSafe(BacLuong), _
                                ConvertToStrSafe(LoaiLuong), _
                                Format(DateSerial(pNamTC, IIf(Tang = CheckState.Checked, ThangTang, 1), 1), Mask_DB), _
                                (IIf(Tang = CheckState.Checked, ConvertToStrSafe(ThangTang), "0")), _
                                ConvertToStrSafe(pNamTC)))
        End If
        Dim sh As String = ConvertToStrSafe(GetSelectValue(String.Format("SELECT sohieu AS f1,maphanloai AS f2 FROM quanlynhanvien WHERE maso={0}", MaSo), pl))
        If sh <> SoHieu And ConvertToBoolSafe(GetSelectValue(String.Format("SELECT nv.maso AS f1,plnv.sohieu AS f2 FROM quanlynhanvien nv inner join phanloaiquanlynhanvien plnv on nv.maphanloai=plnv.maso WHERE nv.sohieu=N'{0}'", SoHieu), shpl)) Then
            MessageBox.Show(String.Format("Số hiệu này đã có ở phân loại {0}.{1}Vui lòng thay đổi số hiệu khác!", shpl, Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return 1
        Else
            Dim tam As String
            tam = String.Format("UPDATE QuanLyNhanVien SET mst=N'{0}',Tu={1},Den={2},The={3},thangtangBH={4},TangBH={5},thangtang={6},tang={7},tuthang={8},denthang={9},giamld={10}{11},thaisan={12}{13},Nghiviec={14},Bacluong={15},phai=N'{16}',MaPhanLoai={17},Machucvu={18},SoHieu=N'{19}',Ten=N'{20}',DiaChihk=N'{21}',DiaChict=N'{22}',Phuongxahk={23},quanhuyenhk={24},tinhtphk={25},quoctich={26},Phuongxact={27},quanhuyenct={28},tinhtpct={29},NgaySinh=N'{30}',CMND=N'{31}',Ngaycap=N'{32}',Noicap={33},Tel1=N'{34}',baohiem=N'{35}',loaihd={36},loailuong={37} WHERE MaSo={38}", _
                                         MST, _
                                         ConvertToStrSafe(Tu), _
                                         ConvertToStrSafe(Den), _
                                        IIf(The = CheckState.Checked, "1", "0"), _
                                         ConvertToStrSafe(ThangTangbh), _
                                         IIf(Tangbh = CheckState.Checked, "1", "0"), _
                                         ConvertToStrSafe(ThangTang), _
                                         IIf(Tang = CheckState.Checked, "1", "0"), _
                                         ConvertToStrSafe(tuthang), _
                                         ConvertToStrSafe(denthang), _
                                         IIf(Giamld = CheckState.Checked, "1", "0"), _
                                         (IIf(Thaisan = CheckState.Checked, String.Format(",tungay='{0}',denngay='{1}'", Format(CDate(tungay), Mask_DB), Format(CDate(denngay), Mask_DB)), String.Empty)), _
                                         IIf(Thaisan = CheckState.Checked, "1", "0"), _
                                         (IIf(Nghiviec = CheckState.Checked, String.Format(",Ngaynghi='{0}'", Format(Ngaynghi, Mask_DB)), String.Empty)), _
                                         IIf(Nghiviec = CheckState.Checked, "1", "0"), _
                                         ConvertToStrSafe(BacLuong), _
                                         Phai, _
                                         ConvertToStrSafe(MaPhanLoai), _
                                         ConvertToStrSafe(MaChucvu), _
                                         SoHieu, _
                                         ten, _
                                         DiaChiHoKhau, _
                                         DiaChiCuTru, _
                                         ConvertToStrSafe(PhuongXahk), _
                                         ConvertToStrSafe(QuanHuyenhk), _
                                         ConvertToStrSafe(TinhTPhk), _
                                         ConvertToStrSafe(QuocGia), _
                                         ConvertToStrSafe(PhuongXact), _
                                         ConvertToStrSafe(QuanHuyenct), _
                                         ConvertToStrSafe(TinhTPct), _
                                         Format(NgaySinh, Mask_DB), _
                                         CMND, _
                                         Format(Ngaycap, Mask_DB), _
                                         ConvertToStrSafe(NoiCap), _
                                         Tel1, _
                                         ConvertToStrSafe(Baohiem), _
                                         ConvertToStrSafe(LoaiHD), _
                                         ConvertToStrSafe(LoaiLuong), _
                                         ConvertToStrSafe(MaSo))
            result = ExecSQLNonQuery(tam)
            result += ExecSQLNonQuery(String.Format("UPDATE Phucap SET sohieunhanvien=N'{0}'WHERE sohieunhanvien=N'{1}' AND maphanloai={2}", _
                                          SoHieu, _
                                          sh, _
                                          ConvertToStrSafe(pl)))
            result += ExecSQLNonQuery(String.Format("UPDATE Chucdanh SET nhanvien=N'{0}'WHERE nhanvien=N'{1}'", _
                                          SoHieu, _
                                          sh))
            If Tang = CheckState.Checked Then
                Return result + ExecSQLNonQuery(String.Format("UPDATE Chucdanh SET ngayapdung='{0}',thang={1} WHERE nhanvien=N'{2}' AND thang<=all(SELECT thang FROM chucdanh WHERE nhanvien=N'{2}')", _
                                                    Format(DateSerial(pNamTC, ThangTang, 1), Mask_DB), _
                                                    ConvertToStrSafe(ThangTang), _
                                                    SoHieu))
            Else
                Return result + ExecSQLNonQuery(String.Format("UPDATE Chucdanh SET ngayapdung='{0}',thang=0 WHERE nhanvien=N'{1}' AND thang<=all(SELECT thang FROM chucdanh WHERE nhanvien=N'{1}')", _
                                                    Format(DateSerial(pNamTC, 1, 1), Mask_DB), _
                                                    SoHieu))
            End If
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaNV() As Integer
        Dim result As Integer = 0
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 Maso AS F1 FROM chamcong WHERE manhanvien=N'{0}'", SoHieu))) = 0 Or (Nghiviec = CheckState.Checked And ConvertToDblSafe((Ngaynghi.Year)) < ConvertToDblSafe(frmMain._LbCty_7.Text)) Then
            result = ExecSQLNonQuery(String.Format("DELETE  FROM QuanLyNhanVien WHERE MaSo={0}", MaSo))
            result += ExecSQLNonQuery(String.Format("DELETE  FROM phucap WHERE maphanloai={0} AND sohieunhanvien=N'{1}'", _
                                          MaPhanLoai, _
                                          SoHieu))
            result += ExecSQLNonQuery(String.Format("DELETE  FROM chucdanh WHERE nhanvien=N'{0}'", SoHieu))
        Else
            Return -1
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <remarks></remarks>
    Public Sub InitNVMaSo(ByRef ms As Integer)
        Dim rs As DataTable
        init()
        If ms > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM QuanLyNhanVien WHERE MaSo={0}", ms))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                Try

                    If rsItem("MaSo") IsNot Nothing Then
                        MaSo = rsItem("MaSo")
                    End If

                    If rsItem("MaPhanLoai") IsNot Nothing Then
                        MaPhanLoai = rsItem("MaPhanLoai")
                    End If

                    If rsItem("MaChucvu") IsNot Nothing Then
                        MaChucvu = rsItem("MaChucvu")
                    End If

                    If rsItem("SoHieu") IsNot Nothing Then
                        SoHieu = rsItem("SoHieu")
                    End If

                    If rsItem("ten") IsNot Nothing Then
                        ten = rsItem("ten")
                    End If

                    If rsItem("Phai") IsNot Nothing Then
                        Phai = rsItem("Phai")
                    End If

                    If rsItem("DiaChihk") IsNot Nothing Then
                        DiaChiHoKhau = rsItem("DiaChihk")
                    End If

                    If rsItem("PhuongXahk") IsNot Nothing Then
                        PhuongXahk = rsItem("PhuongXahk")
                    End If

                    If rsItem("QuanHuyenhk") IsNot Nothing Then
                        QuanHuyenhk = rsItem("QuanHuyenhk")
                    End If

                    If rsItem("TinhTPhk") IsNot Nothing Then
                        TinhTPhk = rsItem("TinhTPhk")
                    End If

                    If rsItem("Quoctich") IsNot Nothing Then
                        QuocGia = rsItem("Quoctich")
                    End If

                    If rsItem("DiaChict") IsNot Nothing Then
                        DiaChiCuTru = rsItem("DiaChict")
                    End If

                    If rsItem("PhuongXact") IsNot Nothing Then
                        PhuongXact = rsItem("PhuongXact")
                    End If

                    If rsItem("QuanHuyenct") IsNot Nothing Then
                        QuanHuyenct = rsItem("QuanHuyenct")
                    End If

                    If rsItem("TinhTPct") IsNot Nothing Then
                        TinhTPct = rsItem("TinhTPct")
                    End If

                    If rsItem("NgaySinh") IsNot Nothing Then
                        NgaySinh = rsItem("NgaySinh")
                    End If

                    If rsItem("CMND") IsNot Nothing Then
                        CMND = rsItem("CMND")
                    End If

                    If rsItem("Ngaycap") IsNot Nothing Then
                        Ngaycap = rsItem("Ngaycap")
                    End If

                    If rsItem("NoiCap") IsNot Nothing Then
                        NoiCap = rsItem("NoiCap")
                    End If

                    If rsItem("Tel1") IsNot Nothing Then
                        Tel1 = rsItem("Tel1")
                    End If

                    If rsItem("Baohiem") IsNot Nothing Then
                        Baohiem = rsItem("Baohiem")
                    End If

                    If rsItem("LoaiHD") IsNot Nothing Then
                        LoaiHD = rsItem("LoaiHD")
                    End If

                    If rsItem("LoaiLuong") IsNot Nothing Then
                        LoaiLuong = rsItem("LoaiLuong")
                    End If

                    If rsItem("BacLuong") IsNot Nothing Then
                        BacLuong = rsItem("BacLuong")
                    End If

                    Nghiviec = CheckState.Unchecked
                    If rsItem("Nghiviec") IsNot Nothing Then
                        Nghiviec = rsItem("Nghiviec")
                    End If

                    If rsItem("Ngaynghi").ToString() <> "" Then
                        Ngaynghi = rsItem("Ngaynghi")
                    End If

                    Thaisan = CheckState.Unchecked
                    If rsItem("Thaisan") IsNot Nothing Then
                        Thaisan = rsItem("Thaisan")
                    End If

                    If rsItem("tungay").ToString() <> "" Then
                        tungay = rsItem("tungay")
                    End If

                    If rsItem("denngay").ToString() <> "" Then
                        denngay = rsItem("denngay")
                    End If

                    Giamld = CheckState.Unchecked
                    If rsItem("Giamld") IsNot Nothing Then
                        Giamld = rsItem("Giamld")
                    End If

                    If rsItem("tuthang") IsNot Nothing Then
                        tuthang = rsItem("tuthang")
                    End If

                    If rsItem("denthang") IsNot Nothing Then
                        denthang = rsItem("denthang")
                    End If

                    Tang = CheckState.Unchecked
                    If rsItem("Tang") IsNot Nothing Then
                        Tang = rsItem("Tang")
                    End If

                    If rsItem("ThangTang") IsNot Nothing Then
                        ThangTang = rsItem("ThangTang")
                    End If

                    If rsItem("SoBHXH") IsNot Nothing Then
                        SoBHXH = rsItem("SoBHXH")
                    End If

                    If rsItem("SoBHYT") IsNot Nothing Then
                        SoBHYT = rsItem("SoBHYT")
                    End If

                    The = CheckState.Unchecked
                    If rsItem("The") IsNot Nothing Then
                        The = rsItem("The")
                    End If

                    If rsItem("Tu") IsNot Nothing Then
                        Tu = rsItem("Tu")
                    End If

                    If rsItem("Den") IsNot Nothing Then
                        Den = rsItem("Den")
                    End If

                    Tangbh = CheckState.Unchecked
                    If rsItem("Tangbh") IsNot Nothing Then
                        Tangbh = rsItem("Tangbh")
                    End If

                    If rsItem("ThangTangbh") IsNot Nothing Then
                        ThangTangbh = rsItem("ThangTangbh")
                    End If

                    MST = "..."
                    If rsItem("MST") IsNot Nothing Then
                        MST = rsItem("MST")
                    End If

                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitNVSoHieu(ByRef sh As String) As Integer
        Dim ms As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM QuanLyNhanVien WHERE SoHieu=N'{0}'", sh)))
        If ms > 0 Then InitNVMaSo(ms)
        Return ms
    End Function
End Class
