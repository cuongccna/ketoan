Imports System
Imports System.Data
Imports System.Text
Imports UNET.Utility
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Public Class ClsTaikhoan
    ' -------- Thong tin ---------------------------------------------------------------------------------------------------------
    Public maso As Integer ' Mã số
    Public sohieu As String = String.Empty ' Số hiệu tài khoản
    Public ten As String = String.Empty ' Tên tài khoản
    Public TenE As String = String.Empty ' Tên tài khoản
    Public NoDauKy As Double ' Số dư nợ đầu kỳ
    Public CoDauKy As Double ' Số dư có đầu kỳ
    Public NTDauKy As Double ' Số dư nguyên tệ đầu kỳ
    ' -------- Phan loai ---------------------------------------------------------------------------------------------------------
    Public cap As Integer ' Cấp tài khoản
    Public kieu As Integer ' Kiểu tài khoản (1: có, -1: nợ).
    Public loai As Integer ' Loại tài khoản (0..9).
    Public MaTC As Integer ' Mã tài khoản tài chính
    ' -------- Cac doi tuong quan he --------------------------------------------------------------------------------------
    Public tkcon As Integer ' 1 : Có tài khoản con cấp dưới, 0 : là tài khoản chi tiết
    Public TkCha0 As Integer ' Mã tài khoản cấp trên
    Public TkCha1 As Integer ' Mã tài khoản cấp trên
    Public TkCha2 As Integer ' Mã tài khoản cấp trên
    Public TkCha3 As Integer ' Mã tài khoản cấp trên
    Public TkCha4 As Integer ' Mã tài khoản cấp trên
    Public TkCha5 As Integer ' Mã tài khoản cấp trên
    Public MaNT As Integer ' Mã nguyên tệ
    Public SoDuMax As Double ' Số dư tối đa cho phép ( =0 nếu bỏ qua )
    Public SoDuMin As Double ' Số dư tối thiểu cho phép ( =0 nếu bỏ qua )
    Public tk_id As Integer ' Mã nhận dạng tài khoản
    Public tk_id2 As Integer ' Mã nhận dạng tài khoản
    Public GhiChu As String = String.Empty

    Public TenDA As String = String.Empty
    Public NhomDA As String = String.Empty
    Public DiaDiem As String = String.Empty
    Public DuToan As Double

    Public Von1 As Double
    Public Von2 As Double
    Public Von3 As Double

    Public NgayKC As Date
    Public NgayHT As Date

    Public PSNLK As Double
    Public PSCLK As Double

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New()
        TenE = "..."
    End Sub
    ''' <summary>
    ''' Thu tuc dang ky tai khoan khong la tai khoan tai chinh
    ''' </summary>
    ''' <returns>Tra ve ma so tai khoan duoc dang ky</returns>
    ''' <remarks></remarks>
    Public Function ThemTk() As Integer
        Dim result As Integer = 0
        Dim sql As String = String.Empty

        If MaNT = 0 Then
            sql = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM HethongTK WHERE SoHieu=N'{0}' AND MaNT<=0", sohieu)
            If ConvertToDblSafe(GetSelectValue(sql)) > 0 Then
                Return -1
            End If
        End If
        If TenE.Length = 0 Then TenE = "..."
        'WSpace.BeginTransaction() ' C15()
        If ExecSQLNonQuery(String.Format("INSERT INTO HeThongTK (MaSo, SoHieu,Ten{0},Cap,Kieu ,Loai,TKCon,MaNT, TK_ID, TK_ID2, SoDuMax,SoDuMin, TkCha0, TkCha1, TkCha2, TkCha3, TkCha4, TkCha5, MaTC, GhiChu, TenDA, NhomDA, DiaDiem, DuToan, Von1, Von2, Von3, NgayKC, NgayHT, PSNLK, PSCLK) VALUES ({1}, N'{2}',N'{3}'{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},N'{21}',N'{22}',N'{23}',N'{24}',{25},{26},{27},{28},N'{29}',N'{30}',{31},{32})", _
                               (IIf(pSongNgu, ",TenE", String.Empty)), _
                               Lng_MaxValue("MaSo", "HethongTK") + 1, _
                               sohieu, _
                               ten, _
                               (IIf(pSongNgu, String.Format(", N'{0}'", TenE), String.Empty)), _
                               ConvertToStrSafe(cap), _
                               ConvertToStrSafe(kieu), _
                               ConvertToStrSafe(loai), _
                               ConvertToStrSafe(tkcon), _
                               ConvertToStrSafe(MaNT), _
                               ConvertToStrSafe(tk_id), _
                               ConvertToStrSafe(tk_id2), _
                               CStr(SoDuMax), _
                               CStr(SoDuMin), _
                               ConvertToStrSafe(TkCha0), _
                               ConvertToStrSafe(TkCha1), _
                               ConvertToStrSafe(TkCha2), _
                               ConvertToStrSafe(TkCha3), _
                               ConvertToStrSafe(TkCha4), _
                               ConvertToStrSafe(TkCha5), _
                               ConvertToStrSafe(MaTC), _
                               GhiChu, _
                               TenDA, _
                               NhomDA, _
                               DiaDiem, _
                               ConvertToStrSafe(DuToan), _
                               ConvertToStrSafe(Von1), _
                               ConvertToStrSafe(Von2), _
                               ConvertToStrSafe(Von3), _
                               Format(NgayKC, Mask_DB), _
                               Format(NgayHT, Mask_DB), _
                               ConvertToStrSafe(PSNLK), _
                               ConvertToStrSafe(PSCLK))) <> 0 Then
            result = -1
            Return result
        End If
        ' Lay ma so tai khoan moi mo
        maso = Lng_MaxValue("MaSo", "HethongTK")
        If MaNT > 0 Then
            ExecSQLNonQuery(String.Format("UPDATE HethongTK SET MaNT=-1 WHERE SoHieu=N'{0}' AND MaNT=0", sohieu))
        End If
        ' Neu tai khoan cha chua co tai khoan con thi cap nhat truong TkCon va chuyen so du
        ChuyenSoDu()
        ' Nhap so dau ky
        If NoDauKy <> 0 Or CoDauKy <> 0 Or NTDauKy <> 0 Then
            TinhSoDu(0, 0, -1, 0)
        End If
        Dim rs As DataTable
        rs = New DataTable
        rs = ExecSQLReturnDT("select Top 1 * from hethongtk")
        For i As Integer = 0 To rs.Columns.Count - 1
            ExecSQLNonQuery("update hethongtk set " + CStr(rs.Columns(i).ColumnName) + "=0 where " + CStr(rs.Columns(i).ColumnName) + " is null")
        Next
        'ExecSQLNonQuery("update hethongtk set matc = maso")
        Return result
    End Function
    ''' <summary>
    ''' Thu tuc cap nhat lai cac thay doi cua tai khoan
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <returns>Tra ve true neu co cap nhat lai cac so hieu tai khoan con</returns>
    ''' <remarks></remarks>
    Public Function CapNhatTk(Optional ByRef thang As Integer = 0) As Integer
        Dim result As Integer = 0
        Dim sql As String = String.Empty
        Dim taikhoan As New ClsTaikhoan
        ' Lấy thông tin tài khoản cũ
        'If maso = 10000 Then
        '    Dim a = 0
        'End If
        taikhoan.InitTaikhoanMaSo(maso)
        'If (taikhoan.sohieu Like "242*") Then
        '    Dim str = String.Empty
        'End If
        If MaNT = 0 And sohieu <> taikhoan.sohieu Then
            sql = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM HethongTK WHERE SoHieu=N'{0}' AND MaNT=0", sohieu)
            If ConvertToDblSafe(GetSelectValue(sql)) > 0 Then
                Return -1
            End If
        End If
        If TenE.Length = 0 Then TenE = "..."
        'WSpace.BeginTransaction() ' C15()
        ' Cap nhat thong tin tai khoan moi
        sql = String.Format("UPDATE HethongTk SET SoHieu=N'{0}',Ten=N'{1}',Kieu={2}, GhiChu = N'{3}',TenDA=N'{4}',NhomDA=N'{5}',DiaDiem=N'{6}',DuToan={7},Von1={8},Von2={9},Von3={10},NgayKC=N'{11}',NgayHT=N'{12}'{13} WHERE SoHieu = N'{14}'", _
                  sohieu, _
                  ten, _
                  ConvertToStrSafe(kieu), _
                  GhiChu, _
                  TenDA, _
                  NhomDA, _
                  DiaDiem, _
                  ConvertToStrSafe(DuToan), _
                  ConvertToStrSafe(Von1), _
                  ConvertToStrSafe(Von2), _
                  ConvertToStrSafe(Von3), _
                  Format(NgayKC, Mask_DB), _
                  Format(NgayHT, Mask_DB), _
                  (IIf(pSongNgu, String.Format(",TenE=N'{0}'", TenE), String.Empty)), _
                  taikhoan.sohieu)
        If ExecSQLNonQuery(sql) <> 0 Then
            'WSpace.Rollback()
            result = -1
        Else
            sql = String.Format("UPDATE HethongTk SET MaNT={0},SoDuMax={1},SoDuMin={2},TK_ID={3} WHERE MaSo={4}", _
                      MaNT, _
                      CStr(SoDuMax), _
                      CStr(SoDuMin), _
                      ConvertToStrSafe(tk_id), _
                      ConvertToStrSafe(maso))
            ExecSQLNonQuery(sql)
            ' Neu co thay doi so hieu thi thay doi so hieu cac tai khoan con
            If sohieu <> taikhoan.sohieu And taikhoan.tkcon <> 0 Then
                ExecSQLNonQuery(String.Format("UPDATE HethongTK SET SoHieu=N'{0}' + RIGHT(HethongTK.SoHieu, Len(HethongTK.SoHieu) - {1}) WHERE SoHieu LIKE '{2}%'", _
                                    sohieu, _
                                    ConvertToStrSafe(taikhoan.sohieu.Length), _
                                    taikhoan.sohieu))
            End If
            result = 0
            If taikhoan.PSNLK <> PSNLK Or taikhoan.PSCLK <> PSCLK Or taikhoan.NoDauKy <> NoDauKy Or taikhoan.CoDauKy <> CoDauKy Or taikhoan.NTDauKy <> NTDauKy Then
                TinhSoDu(thang, 0, -1, 0) 'taikhoan.TinhSoDu(thang, 0, -1, 0)
                'cap nhat ngày 2-10-2019
            End If
        End If
        Return result
    End Function
    ''' <summary>
    ''' Thu tuc xoa tai khoan khong phai la tai khoan tai chinh
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaTk() As Integer
        Dim chuyenps As Boolean
        Dim sql As String = String.Empty
        If (MaTC = 0 Or MaTC = maso) And pXuLyTKTC = 0 Then
            Return -1
        End If
        If tkcon > 0 Then
            MessageBox.Show(Ngonngu("Hãy xoá hết chi tiết của tài khoản !", "Delete all details account !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return -2
        End If
        If TkCoPS(0, 0) Then
            sql = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM HethongTK WHERE MaNT <=0 AND TKCha0 = {0}", TkCha0)
            If ConvertToDblSafe(GetSelectValue(sql)) > 1 Then
                Return -3
            Else
                chuyenps = True
            End If
        Else
            sql = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM TP154 WHERE MaTK = {0}", maso)
            If (sohieu Like String.Format("{0}*", ShTkSPDo)) And pDTTP <> 0 And ConvertToDblSafe(GetSelectValue(sql)) > 0 Then
                sql = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM HethongTK WHERE TKCha0 = {0}", TkCha0)
                If ConvertToDblSafe(GetSelectValue(sql)) > 1 Then
                    Return -3
                Else
                    chuyenps = True
                End If
            Else
                chuyenps = False
            End If
        End If
        If MaNT < 0 Then
            Return -4
        End If
        If tk_id = TKVT_ID Then
            sql = "DELETE  FROM TonKho WHERE Luong_0=0 AND Tien_0=0 "
            For i As Integer = 1 To 12
                sql = String.Format("{0} AND Luong_Nhap_{1}=0 AND Tien_Nhap_{1}=0 ", sql, ConvertToStrSafe(i))
            Next
            ExecSQLNonQuery(sql)
        End If
        If tk_id = TKCNKH_ID Or tk_id = TKCNPT_ID Then
            sql = "DELETE  FROM SoDuKhachHang WHERE DuNo_0=0 AND DuCo_0=0 AND DuNT_0=0 "
            For i As Integer = 1 To 12
                sql = String.Format("{0} AND No_{1}=0 AND Co_{1}=0", sql, ConvertToStrSafe(i))
            Next
            ExecSQLNonQuery(sql)
        End If

        NoDauKy = 0
        CoDauKy = 0
        NTDauKy = 0
        TinhSoDu(0, 0, -1, 0)
        ' Xoa tai khoan
        If ExecSQLNonQuery(String.Format("DELETE FROM HethongTk WHERE MaSo={0}", maso)) <> 0 Then
            Return -5
        End If
        If MaNT > 0 Then
            sql = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM HethongTK WHERE SoHieu=N'{0}' AND MaNT>0", sohieu)
            If ConvertToDblSafe(GetSelectValue(sql)) = 0 Then
                ExecSQLNonQuery(String.Format("UPDATE HethongTk SET MaNT = 0 WHERE SoHieu=N'{0}' AND MaNT=-1", sohieu))
            End If
        End If
        If MaNT = 0 Then
            ' Neu tai khoan cha khong con chi tiet thi cap nhat lai
            sql = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM HethongTK WHERE TkCha0 = {0}", TkCha0)
            If ConvertToDblSafe(GetSelectValue(sql)) = 0 Then
                Dim TKConCount As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT ISNULL(( SELECT COUNT(chHTTK.MaSo) FROM dbo.HeThongTK chHTTK WHERE(LEFT(chHTTK.SoHieu, LEN(msHTTK.SoHieu))= msHTTK.SoHieu)AND(chHTTK.MaSo <> msHTTK.MaSo)AND(chHTTK.Cap > msHTTK.Cap)AND(LEFT(chHTTK.SoHieu, 1)<> '#')AND(chHTTK.Cap > 0)AND chHTTK.MaNT <= 0 AND chHTTK.Loai = msHTTK.Loai), 0) AS F1 FROM dbo.HeThongTK msHTTK WHERE MaSo = {0}", maso)))
                ExecSQLNonQuery(String.Format("UPDATE HethongTk SET TkCon = {0},MaTC=CASE WHEN MaTC ={1} THEN MaSo ELSE MaTC END WHERE MaSo={2}", _
                                    TKConCount, _
                                    maso, _
                                    ConvertToStrSafe(TkCha0)))
                If chuyenps Then
                    ' Thay doi ma tai khoan trong chung tu
                    ExecSQLNonQuery(String.Format("UPDATE ThongSo SET MaDTSD = {0} WHERE MaDTSD = {1}", TkCha0, maso))
                    ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaTkNo={0} WHERE MaTkNo={1}", TkCha0, maso))
                    ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaTkCo={0} WHERE MaTkCo={1}", TkCha0, maso))
                    ExecSQLNonQuery(String.Format("UPDATE ChungTuP SET MaTkNo={0} WHERE MaTkNo={1}", TkCha0, maso))
                    ExecSQLNonQuery(String.Format("UPDATE ChungTuP SET MaTkCo={0} WHERE MaTkCo={1}", TkCha0, maso))
                    ExecSQLNonQuery(String.Format("UPDATE TonKho SET MaTaiKhoan={0} WHERE MaTaiKhoan={1}", TkCha0, maso))
                    ExecSQLNonQuery(String.Format("UPDATE KiemKe SET MaTaiKhoan={0} WHERE MaTaiKhoan={1}", TkCha0, maso))
                    ExecSQLNonQuery(String.Format("UPDATE TP154 SET MaTK={0} WHERE MaTK={1}", TkCha0, maso))
                    If TruongDaCo("ThanhPham", "MaTKCP") Then
                        ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET MaTKCP={0} WHERE MaTKCP={1}", TkCha0, maso))
                        ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET MaTKNC={0} WHERE MaTKNC={1}", TkCha0, maso))
                        ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET MaTKSX={0} WHERE MaTKSX={1}", TkCha0, maso))
                        ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET MaTKKH={0} WHERE MaTKKH={1}", TkCha0, maso))
                    End If
                End If
            End If
        End If
        Return 0
    End Function
    ''' <summary>
    ''' Ham kiem tra tài khoản đã có số phát sinh
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TkCoPS(ByRef tdau As Integer, ByRef tcuoi As Integer) As Boolean
        Dim sqlw As String = String.Empty
        If tcuoi > 0 Then sqlw = String.Format(" AND {0}", WThang("ThangCT", tdau, tcuoi))
        Dim sql1 As String = String.Format("SELECT DISTINCT Count(ChungTu.MaSo) AS F1 FROM {0} WHERE chungtu.sops > 0 AND HethongTK.SoHieu LIKE '{1}%'{2}", _
                                 ChungTu2TKNC(-1), _
                                 sohieu, _
                                 sqlw)
        Dim sql2 As String = String.Format("SELECT DISTINCT Count(ChungTu.MaSo) AS F1 FROM {0} WHERE chungtu.sops > 0 AND HethongTK.SoHieu LIKE '{1}%'{2}", _
                                 ChungTu2TKNC(1), _
                                 sohieu, _
                                 sqlw)
        Return (ConvertToDblSafe(GetSelectValue(sql1)) > 0 Or ConvertToDblSafe(GetSelectValue(sql2)) > 0)
    End Function
    '======================================================================================
    Public Function TkCoPSN(ByRef ndau As Date, ByRef ncuoi As Date) As Boolean
        Dim sql1 As String = String.Format("SELECT DISTINCT Count(ChungTu.MaSo) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '{1}%' AND {2}", _
                                 ChungTu2TKNC(-1), _
                                 sohieu, _
                                 WNgay("NgayGS", ndau, ncuoi))
        Dim sql2 As String = String.Format("SELECT DISTINCT Count(ChungTu.MaSo) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '{1}%' AND {2}", _
                                 ChungTu2TKNC(1), _
                                 sohieu, _
                                 WNgay("NgayGS", ndau, ncuoi))
        Return ConvertToDblSafe(GetSelectValue(sql1)) > 0 Or ConvertToDblSafe(GetSelectValue(sql2)) > 0
    End Function
    ''' <summary>
    ''' Ham kiem tra so phat sinh co hop le (canh cao neu khong hop le)
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="sops">So phat sinh</param>
    ''' <param name="loaips">Loai phat sinh</param>
    ''' <remarks></remarks>
    Public Sub KtraPhatsinh(ByRef thang As Integer, ByRef sops As Double, ByRef loaips As Integer)
        Dim ckc, ckn, cknt, SoDuMoi As Double
        If SoDuMax = 0 AndAlso SoDuMin = 0 Then Exit Sub
        SoDuTK(thang, ckn, ckc, cknt)
        If loaips < 0 Then
            SoDuMoi = IIf(kieu < 0, ckn - ckc + sops, ckc - ckn - sops)
        Else
            SoDuMoi = IIf(kieu < 0, ckn - ckc - sops, ckc - ckn + sops)
        End If
        If SoDuMoi > SoDuMax AndAlso SoDuMax > 0 Then
            MessageBox.Show(Ngonngu("Đã vượt quá số dư cho phép !", "Excess allow balances"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If SoDuMoi < SoDuMin And SoDuMin > 0 Then
                MessageBox.Show(Ngonngu("Đã xuống dưới số dư tối thiểu !", "Below minimum balance !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Init()
        maso = 0
        sohieu = ""
        ten = ""
        TenE = "..."
        cap = 0
        kieu = 0
        loai = 0
        tkcon = 0
        TkCha0 = 0
        TkCha1 = 0
        TkCha2 = 0
        TkCha3 = 0
        TkCha4 = 0
        TkCha5 = 0
        NoDauKy = 0
        CoDauKy = 0
        SoDuMax = 0
        SoDuMin = 0
        MaNT = 0
        MaTC = 0
        tk_id = 0
        tk_id2 = 0
        GhiChu = "..."
        TenDA = "..."
        NhomDA = "..."
        DiaDiem = "..."
        DuToan = 0
        Von1 = 0
        Von2 = 0
        Von3 = 0
        NgayKC = Now
        NgayHT = Now
        PSNLK = 0
        PSCLK = 0
    End Sub
    ''' <summary>
    ''' Thu tuc khoi tao object tra ve 0 neu object rong
    ''' </summary>
    ''' <param name="mtk">Ma so tai khoan can tham chieu</param>
    ''' <remarks></remarks>
    Public Sub InitTaikhoanMaSo(ByRef mtk As Integer)
        Dim rs_taikhoan As DataTable
        Init()
        If mtk > 0 Then
            rs_taikhoan = ExecSQLReturnDT(String.Format("SELECT * FROM HethongTK WHERE MaSo={0}", mtk))
            If rs_taikhoan.Rows.Count > 0 Then
                Dim rs_taikhoanItem As DataRow = rs_taikhoan.Rows(0)
                maso = mtk

                If rs_taikhoanItem("sohieu").ToString <> "" Then
                    sohieu = rs_taikhoanItem("sohieu")
                End If

                If rs_taikhoanItem("ten").ToString <> "" Then
                    ten = rs_taikhoanItem("ten")
                End If
                If pSongNgu Then

                    If rs_taikhoanItem("TenE").ToString <> "" Then
                        TenE = rs_taikhoanItem("TenE")
                    End If
                End If

                If rs_taikhoanItem("cap").ToString <> "" Then
                    cap = rs_taikhoanItem("cap")
                End If

                If rs_taikhoanItem("kieu").ToString <> "" Then
                    kieu = rs_taikhoanItem("kieu")
                End If

                If rs_taikhoanItem("loai").ToString <> "" Then
                    loai = rs_taikhoanItem("loai")
                End If

                If rs_taikhoanItem("DuNo_0").ToString <> "" Then
                    NoDauKy = rs_taikhoanItem("DuNo_0")
                End If

                If rs_taikhoanItem("DuCo_0").ToString <> "" Then
                    CoDauKy = rs_taikhoanItem("DuCo_0")
                End If

                If rs_taikhoanItem("DuNT_0").ToString <> "" Then
                    NTDauKy = rs_taikhoanItem("DuNT_0")
                End If

                If rs_taikhoanItem("SoDuMax").ToString <> "" Then
                    SoDuMax = rs_taikhoanItem("SoDuMax")
                End If

                If rs_taikhoanItem("SoDuMin").ToString <> "" Then
                    SoDuMin = rs_taikhoanItem("SoDuMin")
                End If

                If rs_taikhoanItem("MaNT").ToString <> "" Then
                    MaNT = rs_taikhoanItem("MaNT")
                End If

                If rs_taikhoanItem("tkcon").ToString <> "" Then
                    tkcon = rs_taikhoanItem("tkcon")
                End If
                If rs_taikhoanItem("GhiChu").ToString <> "" Then
                    GhiChu = rs_taikhoanItem("GhiChu")
                End If

                If rs_taikhoanItem("TkCha0").ToString <> "" Then
                    TkCha0 = rs_taikhoanItem("TkCha0")
                End If

                If rs_taikhoanItem("TkCha1").ToString <> "" Then
                    TkCha1 = rs_taikhoanItem("TkCha1")
                End If

                If rs_taikhoanItem("TkCha2").ToString <> "" Then
                    TkCha2 = rs_taikhoanItem("TkCha2")
                End If

                If rs_taikhoanItem("TkCha3").ToString <> "" Then
                    TkCha3 = rs_taikhoanItem("TkCha3")
                End If

                If rs_taikhoanItem("TkCha4") IsNot Nothing Then
                    TkCha4 = rs_taikhoanItem("TkCha4")
                End If

                If rs_taikhoanItem("TkCha5") IsNot Nothing Then
                    TkCha5 = rs_taikhoanItem("TkCha5")
                End If

                If rs_taikhoanItem("MaTC") IsNot Nothing Then
                    MaTC = rs_taikhoanItem("MaTC")
                End If

                If rs_taikhoanItem("tk_id") IsNot Nothing Then
                    tk_id = rs_taikhoanItem("tk_id")
                End If

                If rs_taikhoanItem("tk_id2") IsNot Nothing Then
                    tk_id2 = rs_taikhoanItem("tk_id2")
                End If
                If rs_taikhoanItem("GhiChu") IsNot Nothing Then
                    GhiChu = rs_taikhoanItem("GhiChu")
                End If
                If rs_taikhoanItem("TenDA") IsNot Nothing Then
                    TenDA = rs_taikhoanItem("TenDA")
                End If
                If rs_taikhoanItem("TenDA") IsNot Nothing Then
                    TenDA = rs_taikhoanItem("TenDA")
                End If

                If rs_taikhoanItem("NhomDA") IsNot Nothing Then
                    NhomDA = rs_taikhoanItem("NhomDA")
                End If

                If rs_taikhoanItem("DiaDiem") IsNot Nothing Then
                    DiaDiem = rs_taikhoanItem("DiaDiem")
                End If
                If rs_taikhoanItem("TenDA") IsNot Nothing Then
                    TenDA = rs_taikhoanItem("TenDA")
                End If

                If rs_taikhoanItem("DuToan") IsNot Nothing Then
                    DuToan = rs_taikhoanItem("DuToan")
                End If

                If rs_taikhoanItem("Von1") IsNot Nothing Then
                    Von1 = rs_taikhoanItem("Von1")
                End If

                If rs_taikhoanItem("Von2") IsNot Nothing Then
                    Von1 = rs_taikhoanItem("Von2")
                End If

                If rs_taikhoanItem("Von3") IsNot Nothing Then
                    Von3 = rs_taikhoanItem("Von3")
                End If

                If rs_taikhoanItem("NgayKC") IsNot Nothing Then
                    NgayKC = ConvertToDateSafe(rs_taikhoanItem("NgayKC"))
                End If

                If rs_taikhoanItem("NgayHT") IsNot Nothing Then
                    NgayHT = ConvertToDateSafe(rs_taikhoanItem("NgayHT"))
                End If

                If rs_taikhoanItem("PSNLK") IsNot Nothing Then
                    PSNLK = rs_taikhoanItem("PSNLK")
                End If

                If rs_taikhoanItem("PSCLK") IsNot Nothing Then
                    PSCLK = rs_taikhoanItem("PSCLK")
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc khoi tao object
    ''' </summary>
    ''' <param name="sohieu">So hieu tai khoan can tham chieu</param>
    ''' <param name="shct">Ten tai khoan neu tim thay</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitTaikhoanSohieu(ByRef sohieu As String, Optional ByRef shct As String = "") As String
        Dim sql As String = String.Format("SELECT DISTINCT MaSo AS F1, MaNT FROM HethongTK WHERE {0} ORDER BY MaNT DESC", (IIf(shct.Length > 0, String.Format(" LEFT(SoHieu,Len(N'{0}'))=N'{0}' AND RIGHT(Sohieu,{1})=N'{2}'", _
                                                                                                                                                    sohieu, _
                                                                                                                                                    ConvertToStrSafe(shct.Length), _
                                                                                                                                                    shct), String.Format("SoHieu=N'{0}'", sohieu))))
        InitTaikhoanMaSo(ConvertToDblSafe(GetSelectValue(sql)))
        Return ten
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="doi_tuong"></param>
    ''' <remarks></remarks>
    Public Sub DanXuat(ByRef doi_tuong As ClsTaikhoan)
        With doi_tuong
            .maso = maso
            .sohieu = sohieu
            .ten = ten
            .TenE = TenE
            .NoDauKy = NoDauKy
            .CoDauKy = CoDauKy
            .NTDauKy = NTDauKy
            ' Phan loai
            .cap = cap
            .kieu = kieu
            .loai = loai
            .MaTC = MaTC
            ' Cac doi tuong quan he
            .tkcon = tkcon
            .TkCha0 = TkCha0
            .TkCha1 = TkCha1
            .TkCha2 = TkCha2
            .TkCha3 = TkCha3
            .TkCha4 = TkCha4
            .TkCha5 = TkCha5
            .MaNT = MaNT
            .SoDuMax = SoDuMax
            .SoDuMin = SoDuMin
            .tk_id = tk_id
            .tk_id2 = tk_id2
            .GhiChu = GhiChu
            .TenDA = TenDA
            .NhomDA = NhomDA
            .DiaDiem = DiaDiem
            .DuToan = DuToan
            .Von1 = Von1
            .Von2 = Von2
            .Von3 = Von3
            .NgayKC = NgayKC
            .NgayHT = NgayHT
            .PSNLK = PSNLK
            .PSCLK = PSCLK
        End With
    End Sub
    ''' <summary>
    ''' Thu tuc chuyen so du tu tai khoan cha xuong tai khoan con moi mo
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ChuyenSoDu()
        Dim st, th As String
        ' Chuyen so du xuong tai khoan con
        Dim rs_taikhoan As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM HethongTK WHERE MaSo={0}", TkCha0))
        Dim rs_taikhoanItem As DataRow = rs_taikhoan.Rows(0)
        If ConvertToDblSafe(rs_taikhoanItem("tkcon")) > 0 Then
            If ConvertToDblSafe(rs_taikhoanItem("MaTC")) = 0 Then ExecSQLNonQuery(String.Format("UPDATE HethongTK SET MaTC=MaSo WHERE Maso={0}", maso))
        Else
            ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TKCon=1,MaNT=0 WHERE Maso={0}", ConvertToStrSafe(TkCha0)))
            st = String.Format("UPDATE HethongTk SET DuNo_0={0},DuCo_0={1},DuNT_0={2}", _
                     CStr(rs_taikhoanItem("DuNo_0")), _
                     CStr(rs_taikhoanItem("DuCo_0")), _
                     CStr(rs_taikhoanItem("DuNT_0")))
            For i As Integer = 1 To 12
                th = ConvertToStrSafe(i)
                st = String.Format("{0},No_{1}={2},Co_{1}={3},No_{1}_NT={4},Co_{1}_NT={5}, DuNo_{1} = {6}, DuCo_{1} = {7}, DuNT_{1} = {8}", _
                         st, _
                         th, _
                         CStr(rs_taikhoanItem(String.Format("No_{0}", th))), _
                         CStr(rs_taikhoanItem(String.Format("Co_{0}", th))), _
                         CStr(rs_taikhoanItem(String.Format("No_{0}_NT", th))), _
                         CStr(rs_taikhoanItem(String.Format("Co_{0}_NT", th))), _
                         CStr(rs_taikhoanItem(String.Format("DuNo_{0}", th))), _
                         CStr(rs_taikhoanItem(String.Format("DuCo_{0}", th))), _
                         CStr(rs_taikhoanItem(String.Format("DuNT_{0}", th))))
            Next
            st = String.Format("{0} WHERE MaSo={1}", st, ConvertToStrSafe(maso))
            ExecSQLNonQuery(st)
            ' Thay doi ma tai khoan trong chung tu
            ExecSQLNonQuery(String.Format("UPDATE ThongSo SET MaDTSD = {0} WHERE MaDTSD = {1}", maso, TkCha0))
            ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaTkNo={0} WHERE MaTkNo={1}", maso, TkCha0))
            ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaTkCo={0} WHERE MaTkCo={1}", maso, TkCha0))
            ExecSQLNonQuery(String.Format("UPDATE ChungTuP SET MaTkNo={0} WHERE MaTkNo={1}", maso, TkCha0))
            ExecSQLNonQuery(String.Format("UPDATE ChungTuP SET MaTkCo={0} WHERE MaTkCo={1}", maso, TkCha0))
            ExecSQLNonQuery(String.Format("UPDATE TonKho SET MaTaiKhoan={0} WHERE MaTaiKhoan={1}", maso, TkCha0))
            ExecSQLNonQuery(String.Format("UPDATE KiemKe SET MaTaiKhoan={0} WHERE MaTaiKhoan={1}", maso, TkCha0))
            ExecSQLNonQuery(String.Format("UPDATE TP154 SET MaTK={0} WHERE MaTK={1}", maso, TkCha0))
            If TruongDaCo("ThanhPham", "MaTKCP") Then
                ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET MaTKCP={0} WHERE MaTKCP={1}", maso, TkCha0))
                ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET MaTKNC={0} WHERE MaTKNC={1}", maso, TkCha0))
                ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET MaTKSX={0} WHERE MaTKSX={1}", maso, TkCha0))
                ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET MaTKKH={0} WHERE MaTKKH={1}", maso, TkCha0))
            End If
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc tra ve so phat sinh cua tai khoan
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="psn"></param>
    ''' <param name="psc"></param>
    ''' <remarks></remarks>
    Public Sub SoPhatSinh(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef psn As Double, ByRef psc As Double)
        Dim th As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            th = ConvertToStrSafe(i)
            sqln.Append(String.Format(" + No_{0}", th))
            sqlc.Append(String.Format(" + Co_{0}", th))
        Next
        Dim sql As String = String.Format("SELECT DISTINCT SUM({0}) AS F1,SUM({1}) AS F2 FROM HethongTK WHERE {2}", _
                                sqln, _
                                sqlc, _
                                (IIf(tkcon > 0 Or MaNT <> 0, String.Format("(SoHieu LIKE '{0}%' AND TKCon = 0)", sohieu), String.Format("MaSo = {0}", maso))))
        psn = ConvertToDblSafe(GetSelectValue(sql, psc))
    End Sub
    ''' <summary>
    ''' Thủ tục tính lại số dư của tài khoản cấp dưới cùng
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="sops"></param>
    ''' <param name="loaips"></param>
    ''' <param name="sopsnt"></param>
    ''' <remarks></remarks>
    Public Sub TinhSoDu(ByRef thang As Integer, ByRef sops As Double, ByRef loaips As Integer, ByRef sopsnt As Double)
        Dim j, i, k As Integer
        Dim sqlnt, st As String
        Dim sql As New StringBuilder
        Dim dunocu(12) As Double, ducocu(12) As Double, duno(12) As Double, duco(12) As Double
        Dim rs_tk As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM HethongTK WHERE MaSo={0}", maso))
        If rs_tk.Rows.Count > 0 Then
            Dim rs_tkItem As DataRow = rs_tk.Rows(0)
            ' Ghi phát sinh
            If thang > 0 Then
                st = ConvertToStrSafe(CThangDB2(thang))
                If loaips < 0 Then
                    sql = New StringBuilder(String.Format("UPDATE HethongTK SET No_{0} = No_{0} + {1}", st, CStr(sops)))
                Else
                    sql = New StringBuilder(String.Format("UPDATE HethongTK SET Co_{0} = Co_{0} + {1}", st, CStr(sops)))
                End If
                j = CThangDB2(ThangTruoc(thang))
            Else
                sql = New StringBuilder(String.Format("UPDATE HethongTK SET DuNo_0 = DuNo_0 + {0}, DuCo_0 = DuCo_0 + {1}", _
                                                      CStr(NoDauKy - ConvertToDblSafe(rs_tkItem("DuNo_0"))), _
                                                      CStr(CoDauKy - ConvertToDblSafe(rs_tkItem("DuCo_0")))))
                j = 0
            End If
            ' Ghi số dư cũ
            For i = j To 12
                dunocu(i) = ConvertToDblSafe(rs_tkItem(String.Format("DuNo_{0}", i)))
                ducocu(i) = ConvertToDblSafe(rs_tkItem(String.Format("DuCo_{0}", i)))
            Next
            j += 1
            ' Xác định số dư mới
            If thang > 0 Then
                i = CThangDB2(thang)
                duno(i) = dunocu(i - 1) - ducocu(i - 1) + rs_tkItem(String.Format("No_{0}", i)) - rs_tkItem(String.Format("Co_{0}", i)) + (IIf(loaips < 0, sops, -sops))
                If duno(i) < 0 Then
                    duco(i) = -duno(i)
                    duno(i) = 0
                Else
                    duco(i) = 0
                End If
                k = i + 1
            Else
                duno(0) = NoDauKy
                duco(0) = CoDauKy
                k = 1
            End If
            For i = k To 12
                duno(i) = duno(i - 1) - duco(i - 1) + ConvertToDblSafe(rs_tkItem(String.Format("No_{0}", i))) - ConvertToDblSafe(rs_tkItem(String.Format("Co_{0}", i)))
                If duno(i) < 0 Then
                    duco(i) = -duno(i)
                    duno(i) = 0
                Else
                    duco(i) = 0
                End If
            Next
            ' Ghi số dư mới
            For i = j To 12
                st = ConvertToStrSafe(i)
                sql.Append(String.Format(", DuNo_{0} = DuNo_{0} + {1}, DuCo_{0} = DuCo_{0} + {2}", _
                               st, _
                               CStr(duno(i) - dunocu(i)), _
                               CStr(duco(i) - ducocu(i))))
            Next
            If MaNT > 0 Then
                If thang > 0 Then
                    st = CStr(sopsnt)
                    If loaips < 0 Then
                        sqlnt = String.Format("UPDATE HethongTK SET No_{0}_NT = No_{1}_NT + {2}", _
                                    CThangDB2(thang), _
                                    ConvertToStrSafe(CThangDB2(thang)), _
                                    st)
                    Else
                        sqlnt = String.Format("UPDATE HethongTK SET Co_{0}_NT = Co_{1}_NT + {2}", _
                                    CThangDB2(thang), _
                                    ConvertToStrSafe(CThangDB2(thang)), _
                                    st)
                    End If
                Else
                    sqlnt = String.Format("UPDATE HethongTK SET DuNT_0 =  {0}", CStr(NTDauKy))
                End If
                ExecSQLNonQuery(String.Format("{0} WHERE MaSo = {1}", sqlnt, ConvertToStrSafe(maso)))
                sqlnt = "UPDATE HethongTK SET "
                For i = IIf(thang > 0, CThangDB2(thang), 1) To 12
                    ExecSQLNonQuery(String.Format("{0}DuNT_{1}=ABS(DuNT_{2}+ CASE WHEN DuNo_{2}-DuCo_{2}>=0 THEN No_{1}_NT-Co_{1}_NT ELSE Co_{1}_NT - No_{1}_NT END) WHERE MaNT<>0", sqlnt, ConvertToStrSafe(i), ConvertToStrSafe(i - 1)))
                Next
            End If
            ''rs_tk.Close()
            Dim strexec As String = String.Format("{0} WHERE MaSo = {1} OR MaSo = {2} OR MaSo = {3} OR MaSo = {4} OR MaSo = {5} OR MaSo = {6} OR MaSo = {7}", _
                                sql, _
                                (maso), _
                                (TkCha0), _
                                (TkCha1), _
                                (TkCha2), _
                                (TkCha3), _
                                (TkCha4), _
                                (TkCha5))
            ExecSQLNonQuery(strexec)
            If tk_id2 <> TKLT_ID And cap > 0 Then
                sql = New StringBuilder("UPDATE HethongTK SET DuNo_1= CASE WHEN (DuNo_1>=DuCo_1) THEN DuNo_1-DuCo_1 ELSE 0 END, DuCo_1=CASE WHEN (DuNo_1<DuCo_1) THEN DuCo_1-DuNo_1 ELSE 0 END")
                Dim str = sql.ToString()
                For i = 2 To 12
                    sql.Append(String.Format(",DuNo_{0}= CASE WHEN (DuNo_{1}>=DuCo_{1}) THEN DuNo_{1}-DuCo_{1} ELSE 0 END, DuCo_{1}=CASE WHEN (DuNo_{1}<DuCo_{1}) THEN DuCo_{1}-DuNo_{1} ELSE 0 END", _
                                   i, _
                                   ConvertToStrSafe(i)))
                Next
                ExecSQLNonQuery(String.Format("{0} WHERE MaSo = {1} OR MaSo = {2} OR MaSo = {3} OR MaSo = {4} OR MaSo = {5} OR MaSo = {6} OR MaSo = {7}", _
                                    sql, _
                                    (maso), _
                                    (TkCha0), _
                                    (TkCha1), _
                                    (TkCha2), _
                                    (TkCha3), _
                                    (TkCha4), _
                                    (TkCha5)))
            End If
        End If
    End Sub
    ''' <summary>
    ''' Hàm trả về số tài khoản chi tiết của một tài khoản
    ''' </summary>
    ''' <param name="MaTkCon"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DanhsachTkCon(ByRef MaTkCon() As Integer) As Integer
        Dim result As Integer = 0
        Dim rs_tk As DataTable = ExecSQLReturnDT(String.Format("SELECT MaSo FROM HethongTK WHERE SoHieu LIKE '{0}%' AND TkCon=0 ORDER BY SoHieu DESC", sohieu))
        ' rs_tk.MoveLast()
        If rs_tk.Rows.Count > 0 Then
            result = rs_tk.Rows.Count
            ReDim MaTkCon(result - 1)
            Dim i As Integer = 0
            Dim rs_tkIndex As Integer = rs_tk.Rows.Count - 1
            Do While rs_tkIndex > 0
                Dim rs_tkItem As DataRow = rs_tk.Rows(rs_tkIndex)
                rs_tkIndex -= 1 ' C15 Rs LOOP CONTROL
                i += 1
                MaTkCon(i) = rs_tkItem("maso")
                'rs_tk.MovePrevious()
            Loop
        End If

        ''rs_tk.Close()
        Return result
    End Function
    ''' <summary>
    ''' Thủ tục ghi lại số dư đầu năm của các tài khoản tài chính lá khi tháng đầu kỳ > 1
    ''' </summary>
    ''' <param name="duno"></param>
    ''' <param name="duco"></param>
    ''' <remarks></remarks>
    Public Sub GhiDauNam(ByRef duno As Double, ByRef duco As Double)
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET DuNo_0 = {0}, DuCo_0 = {1} WHERE MaSo = {2} OR MaSo = {3} OR MaSo = {4} OR MaSo = {5} OR MaSo = {6} OR MaSo = {7} OR MaSo = {8}", _
                            CStr(duno), _
                            CStr(duco), _
                            (maso), _
                            (TkCha0), _
                            (TkCha1), _
                            (TkCha2), _
                            (TkCha3), _
                            (TkCha4), _
                            (TkCha5)))
    End Sub
    ''' <summary>
    ''' Ham tra ve so dau, cuoi ky cua tai khoan
    ''' </summary>
    ''' <param name="thang">Thang tinh so du, neu truoc thang dau ky chi tra ve so du tai khoan</param>
    ''' <param name="ckn"></param>
    ''' <param name="ckc"></param>
    ''' <param name="cknt"></param>
    ''' <param name="vnd"></param>
    ''' <remarks></remarks>
    Public Sub SoDuTK(ByRef thang As Integer, ByRef ckn As Double, ByRef ckc As Double, ByRef cknt As Double, Optional ByRef vnd As Integer = 0)
        ckn = 0
        ckc = 0
        cknt = 0
        Dim th As String = ConvertToStrSafe(CThangDB(thang))
        ' Tinh tong so du dau nam cua cac tai khoan chi tiet
        Dim rs_taikhoan As DataTable = ExecSQLReturnDT(String.Format("SELECT DuNo_{0} AS Dn, DuCo_{0} AS Dc, DuNT_{0} AS Dnt FROM HethongTk WHERE {1}", _
                                                           th, _
                                                           (IIf(tkcon > 0 Or (MaNT <= 0 And vnd = 0), String.Format("(SoHieu LIKE '{0}%' AND TKCon = 0)", sohieu), String.Format("MaSo = {0}", maso)))))
        Dim rs_taikhoanIndex As Integer = 0
        Do While rs_taikhoanIndex < rs_taikhoan.Rows.Count
            Dim rs_taikhoanItem As DataRow = rs_taikhoan.Rows(rs_taikhoanIndex)
            rs_taikhoanIndex += 1 ' C15 Rs LOOP CONTROL
            If rs_taikhoanItem("Dn") IsNot Nothing Then
                ckn += rs_taikhoanItem("Dn")
            End If
            If rs_taikhoanItem("DC") IsNot Nothing Then
                ckc += rs_taikhoanItem("DC")
            End If
            If rs_taikhoanItem("dnt") IsNot Nothing Then
                cknt += rs_taikhoanItem("dnt")
            End If


            'rs_taikhoan.MoveNext()
        Loop
        ''rs_taikhoan.Close()
    End Sub
    ''' <summary>
    ''' Thu tuc tra ve so phat sinh cua tai khoan
    ''' </summary>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="psn"></param>
    ''' <param name="ntno"></param>
    ''' <param name="psc"></param>
    ''' <param name="ntco"></param>
    ''' <remarks></remarks>
    Public Sub SoPhatSinhN(ByRef ndau As Date, ByRef ncuoi As Date, ByRef psn As Double, ByRef ntno As Double, ByRef psc As Double, ByRef ntco As Double)
        Dim sql As String = String.Format("SELECT DISTINCT Sum(SoPS) AS F1, Sum(SoPS2No) AS F2 FROM {0}WHERE HethongTK.SoHieu LIKE '{1}%' AND {2}", _
                                ChungTu2TKNC(-1), _
                                sohieu, _
                                WNgay("NgayGS", ndau, ncuoi))
        psn = ConvertToDblSafe(GetSelectValue(sql, ntno))
        sql = String.Format("SELECT DISTINCT Sum(SoPS) AS F1, Sum(SoPS2Co) AS F2 FROM {0}WHERE HethongTK.SoHieu LIKE '{1}%' AND {2}", _
                  ChungTu2TKNC(1), _
                  sohieu, _
                  WNgay("NgayGS", ndau, ncuoi))
        psc = ConvertToDblSafe(GetSelectValue(sql, ntco))
    End Sub

    Public Sub SoDuNgay(ByRef ngay As Date, ByRef duno As Double, ByRef duco As Double, ByRef dunt As Double)
        Dim ntno, ckn, ckc, ntco As Double
        SoDuTK(0, duno, duco, dunt)
        SoPhatSinhN(#1/1/1980#, ngay, ckn, ntno, ckc, ntco)
        duno = duno - duco + ckn - ckc
        If duno > 0 Then
            duco = 0
            dunt = dunt + ntno - ntco
        Else
            If duno < 0 Then
                duco = -duno
                duno = 0
                dunt = dunt - ntno + ntco
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ct"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SHChiTiet(Optional ByRef ct As Integer = 0) As String
        Dim ltc As Integer
        If MaTC > 0 Then
            ltc = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Len(SoHieu) AS F1 FROM HethongTK WHERE MaSo={0}", (IIf(ct = 0, MaTC, TkCha0)))))
            Return Strings.Right(sohieu, sohieu.Length - ltc)
        Else
            Return ""
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mnt"></param>
    ''' <remarks></remarks>
    Public Sub LayMaNT(ByRef mnt As Integer)
        Dim id As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM HethongTK WHERE SoHieu=N'{0}' AND MaNT={1}", _
                                                                sohieu, _
                                                                ConvertToStrSafe(mnt))))
        If id <> 0 Then InitTaikhoanMaSo(id)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MaxCap() As Integer
        Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT Max(Cap) AS F1 FROM HethongTK WHERE SoHieu LIKE '{0}%'", sohieu)))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChuyenChiTietSangDoiTuong() As Boolean
        Dim result As Boolean = False
        Dim sql As String = String.Empty
        If tkcon = 0 Or MaxCap() <> cap + 1 Or loai > 4 Or tk_id <> 0 Or MaTC = 0 Then Return result
        If MessageBox.Show(Ngonngu("Chuyển các tài khoản chi tiết thành đối tượng công nợ ?", "Transfer the account details debt subject ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.No Then Return result
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Max(MaNT) AS F1 FROM HethongTK WHERE SoHieu LIKE '{0}%'", sohieu))) > 0 Then Return result
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 MaSo AS F1 FROM KhachHang WHERE SoHieu LIKE '{0}%'", sohieu))) > 0 Then Return result
        ExecSQLNonQuery(String.Format("INSERT INTO PhanLoaiKhachHang (MaSo,SoHieu,TenPhanLoai,Cap) VALUES ({0}, N'{1}', N'{2}',1)", _
                            Lng_MaxValue("MaSo", "PhanLoaiKhachHang") + 1, _
                            sohieu, _
                            ten))
        ExecSQLNonQuery(String.Format("INSERT INTO KhachHang (MaSo,MaPhanLoai,SoHieu,Ten,GhiChu,MaNT) SELECT {0},{1} AS MPL, SoHieu, Ten, GhiChu,MaNT FROM HethongTK WHERE SoHieu LIKE '{2}%' AND Cap={3}", _
                            Lng_MaxValue("MaSo", "KhachHang") + 1, _
                            ConvertToStrSafe(SoHieu2MaSo(sohieu, "PhanLoaiKhachHang")), _
                            sohieu, _
                            ConvertToStrSafe(cap + 1)))
        ExecSQLNonQuery(String.Format("INSERT INTO SoDuKhachHang (MaSo,MaTaiKhoan, MaKhachHang, DuNo_0, DuCo_0, DuNT_0) SELECT {0},TKCha0, KhachHang.MaSo, DuNo_0, DuCo_0, DuNT_0 FROM HethongTK INNER JOIN KhachHang ON HethongTK.SoHieu=KhachHang.SoHieu WHERE HethongTK.SoHieu LIKE '{1}%' AND Cap={2} AND (DuNo_0<>0 OR DuCo_0<>0 OR DuNT_0<>0)", _
                            Lng_MaxValue("MaSo", "SoDuKhachHang") + 1, _
                            sohieu, _
                            ConvertToStrSafe(cap + 1)))
        ExecSQLNonQuery(String.Format("UPDATE ({0}) INNER JOIN KhachHang ON HethongTK.SoHieu=KhachHang.SoHieu SET MaKH=KhachHang.MaSo, MaTKNo={1} WHERE HethongTK.SoHieu LIKE '{2}%'", _
                            ChungTu2TKNC(-1), _
                            ConvertToStrSafe(maso), _
                            sohieu))
        ExecSQLNonQuery(String.Format("UPDATE ({0}) INNER JOIN KhachHang ON HethongTK.SoHieu=KhachHang.SoHieu SET MaKHC=KhachHang.MaSo, MaTKCo={1} WHERE HethongTK.SoHieu LIKE '{2}%'", _
                            ChungTu2TKNC(1), _
                            ConvertToStrSafe(maso), _
                            sohieu))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TKCon=0, TK_ID={0} WHERE MaSo={1}", _
                            (IIf(loai < 3, ConvertToStrSafe(TKCNKH_ID), ConvertToStrSafe(TKCNPT_ID))), _
                            ConvertToStrSafe(maso)))
        ExecSQLNonQuery(String.Format("DELETE  FROM HethongTK WHERE SoHieu LIKE '{0}%' AND Cap>{1}", _
                            sohieu, _
                            ConvertToStrSafe(cap)))
        KiemTraTaiKhoan()
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shct"></param>
    ''' <param name="tenct"></param>
    ''' <param name="tenct2"></param>
    ''' <param name="tkid"></param>
    ''' <param name="tkid2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ThemTKCon(ByRef shct As String, ByRef tenct As String, ByRef tenct2 As String, ByRef tkid As Integer, ByRef tkid2 As Integer) As Integer
        Dim result As Integer = 0
        Dim TK As ClsTaikhoan
        If tk_id <> TSCD_ID Or (Not FADetail) Then
            TK = New ClsTaikhoan()
            DanXuat(TK)
            TK.sohieu = String.Format("{0}{1}", sohieu, shct)
            TK.ten = tenct
            TK.TenE = tenct2
            TK.TkCha5 = TkCha4
            TK.TkCha4 = TkCha3
            TK.TkCha3 = TkCha2
            TK.TkCha2 = TkCha1
            TK.TkCha1 = TkCha0
            TK.TkCha0 = maso
            TK.tkcon = 0
            TK.maso = 0
            If tkid <> 0 Then TK.tk_id = tkid
            If tkid2 <> 0 Then TK.tk_id2 = tkid2
            TK.cap = cap + 1
            TK.NoDauKy = 0
            TK.CoDauKy = 0
            TK.NTDauKy = 0
            TK.ThemTk()
            result = TK.maso
            TK = Nothing
        Else
            result = maso
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tkc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhepCanh(ByRef tkc As ClsTaikhoan) As Integer
        Dim result As Integer = 0
        Dim X As String = String.Empty
        Dim sql As New StringBuilder
        Dim i As Integer
        Dim tkcha(max_level - 1) As Integer
        result = -1
        If MaTC = 0 Or tk_id = TKCNKH_ID Or tk_id = TKCNPT_ID Or tk_id = TSCD_ID Or tk_id = TKVT_ID Or (TkCoPS(0, 0) And tkcon = 0 And tkc.tkcon > 0) Then Return result
        tkcha(0) = TkCha0
        tkcha(1) = TkCha1
        tkcha(2) = TkCha2
        tkcha(3) = TkCha3
        tkcha(4) = TkCha4
        tkcha(5) = TkCha5
        ' Dieu chinh ma so cha
        For i = tkc.cap To max_level
            sql = New StringBuilder(String.Format("TKCha{0}={1}", i - tkc.cap, ConvertToStrSafe(maso)))
            For j As Integer = i - tkc.cap + 1 To max_level - 1
                sql.AppendFormat(",TKCha{0}={1}", _
                               j, _
                               ConvertToStrSafe(tkcha(j - (i - tkc.cap + 1))))
            Next
            Dim RecordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE HethongTK SET {0},Cap={1} WHERE Cap={2} AND SoHieu LIKE '{3}%'", _
                                                                        sql, _
                                                                        ConvertToStrSafe(cap + 1 + i - tkc.cap), _
                                                                        ConvertToStrSafe(i), _
                                                                        tkc.sohieu))
            If RecordsAffectedCount = 0 Then Exit For
        Next
        ' Dieu chinh so hieu
        If tkcon > 0 Then
            sql = New StringBuilder(tkc.SHChiTiet(1))
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM HethongTK WHERE TKCha0={0} AND RIGHT(SoHieu,{1})=N'{2}'", _
                                                   maso, _
                                                   ConvertToStrSafe(sql.ToString().Length), _
                                                   sql))) > 0 Then X = "X"
        End If
        i = MaSo2SoHieu(tkc.TkCha0, "HethongTK").Length
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET Loai={0},Kieu={1},MaTC={2},SoHieu=N'{3}{4}'+RIGHT(SoHieu,Len(SoHieu)-{5}) WHERE SoHieu LIKE '{6}%'", _
                            loai, _
                            ConvertToStrSafe(kieu), _
                            ConvertToStrSafe(MaTC), _
                            sohieu, _
                            (IIf(X.Length > 0, X, String.Empty)), _
                            ConvertToStrSafe(i), _
                            tkc.sohieu))
        KiemTraTaiKhoan()
        Return 0
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ncuoi"></param>
    ''' <param name="loaips"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PSTuKhoiCong(ByRef ncuoi As Date, ByRef loaips As Integer) As Double
        Dim ps As Double = IIf(loaips < 0, PSNLK, PSCLK)
        If loaips < 0 Then
            ps += ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT Sum(SoPS) AS F1 FROM ChungTu INNER JOIN HethongTK ON ChungTu.MaTkNo = HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' AND ChungTu.NgayGS <=N'{1}'", _
                                                      sohieu, _
                                                      Format(ncuoi, Mask_DB))))
        Else
            ps += ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT Sum(SoPS) AS F1 FROM ChungTu INNER JOIN HethongTK ON ChungTu.MaTkCo = HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' AND ChungTu.NgayGS <=N'{1}'", _
                                                      sohieu, _
                                                      Format(ncuoi, Mask_DB))))
        End If
        Return ps
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Nam"></param>
    ''' <param name="loaips"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PSLKNam(ByRef Nam As Integer, ByRef loaips As Integer) As Double
        Dim result As Double = 0
        If TruongDaCo("HethongTK", String.Format("PSNLK{0}", Nam)) Then
            result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT {0} AS F1 FROM HethongTK WHERE MaSo={1}", _
                                                         (IIf(loaips < 0, String.Format("PSNLK{0}", Nam), String.Format("PSCLK{0}", Nam))), _
                                                         ConvertToStrSafe(maso))))
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shx"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ShCapDuoi(ByRef shx As String) As String
        Dim shc As New StringBuilder
        shc.Append(sohieu)
        For i As Integer = sohieu.Length + 1 To shx.Length
            shc.Append(Strings.Mid(shx, i, 1))
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM HethongTK WHERE SoHieu=N'{0}'", shc))) > 0 Then
                Return shc.ToString()
            End If
        Next
        Return String.Empty
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sohieu"></param>
    ''' <param name="shct"></param>
    ''' <param name="cap"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitTaikhoanSohieuCT(ByRef sohieu As String, Optional ByRef shct As String = "", Optional ByRef cap As Integer = 0) As String
        Dim sql As String = String.Format("SELECT DISTINCT MaSo AS F1, MaNT FROM HethongTK WHERE SoHieu LIKE '{0}%' {1}{2} ORDER BY MaNT DESC", _
                                sohieu, _
                                (IIf(shct <> "", String.Format(" AND RIGHT(Sohieu,{0})=N'{1}'", shct.Length, shct), String.Empty)), _
                                (IIf(cap > 0, String.Format(" AND Cap={0}", cap), String.Empty)))
        InitTaikhoanMaSo(ConvertToDblSafe(GetSelectValue(sql)))
        Return ten
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="tkpb"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CPDaPhanBo(ByRef ndau As Date, ByRef ncuoi As Date, ByRef tkpb As String) As Double
        Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '{1}%' AND TK.SoHieu LIKE '{2}%' AND {3}", ChungTu2TKNC(0), tkpb, sohieu, WNgay("NgayGS", ndau, ncuoi))))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChoNhap() As Boolean
        Dim result As Boolean = False
        If User_Right = 0 Then
            Return True
        Else
            result = False
            If Not TruongDaCo("HethongTK", String.Format("U{0}", UserID)) Then Return result
            Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT U{0} AS F1 FROM HethongTK WHERE MaSo={1}", _
                                                       UserID, _
                                                       ConvertToStrSafe(maso)))) > 0
        End If
        Return result
    End Function
    Public Function LayTaiKhoanTheoSoHieu(ByVal sohieu As String) As ClsTaikhoan
        Dim tk As New ClsTaikhoan()
        Dim sql As String = "select * from HETHONGTK where SoHieu = '" & sohieu & "'"
        Dim table As DataTable = ExecSQLReturnDT(sql)

        If table.Rows.Count > 0 Then
            tk.maso = table.Rows(0)("MaSo")
            tk.ten = table.Rows(0)("Ten")
            tk.sohieu = table.Rows(0)("SoHieu")
            tk.cap = table.Rows(0)("Cap")
            tk.kieu = table.Rows(0)("Kieu")
            tk.loai = table.Rows(0)("Loai")
            tk.MaNT = table.Rows(0)("MaNT")
            ' tk.DuNo = table.Rows(0)("DuNo")
            ' tk.DuCo = table.Rows(0)("DuCo")
            '  tk.No = table.Rows(0)("No")
            'tk.NoNT = table.Rows(0)("NoNT")
            'tk.CoNT = table.Rows(0)("CoNT")
            tk.SoDuMax = table.Rows(0)("SoDuMax")
            tk.SoDuMin = table.Rows(0)("SoDuMin")
            tk.TkCha0 = table.Rows(0)("TKCha0")
            tk.MaTC = table.Rows(0)("MaTC")
            tk.GhiChu = table.Rows(0)("GhiChu").ToString()

        End If
        Return tk
    End Function
End Class
