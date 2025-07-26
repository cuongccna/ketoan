Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Module modHoadon
    Dim DC As CheckState
    Dim dn As CheckState
    Dim HD As CheckState
    Dim HDBL As CheckState
    Dim KCT As CheckState
    Dim NK As CheckState
    Dim NLTS As CheckState
    Dim ts As CheckState
    Public stuHoadon As tpHoaDon = tpHoaDon.CreateInstance()
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure tpHoaDon
        Dim MaSo As Integer
        Dim loai As Integer
        Dim MaKhachHang As Integer
        Dim KyHieu As String
        Dim sohd As String
        Dim NgayPH As Date
        Dim MatHang As String
        Dim soluong As Double
        Dim ThanhTien As Double
        Dim TyLe As Integer
        Dim HD As Integer
        Dim KCT As Integer
        Dim HDBL As Integer
        Dim NLTS As Integer
        Dim dn As Integer
        Dim NK As Integer
        Dim DC As Integer
        Dim ts As Integer
        Dim TenKH As String
        Dim DiaChiKH As String
        Dim MSTKH As String
        Dim HTTT As String
        Dim MauSo As String
        Dim KyHieuMau As String
        Dim tygia As Double
        Dim sohopdong As String
        Dim Ngayhopdong As Date
        Dim diadiemgiaohang As String
        Dim diadiemnhanhang As String
        Dim sovandon As String
        Dim socontainer As String
        Dim tenvanchuyen As String
        Dim Den As Integer
        Dim tim As Integer
        Dim hong As Integer
        Dim xanh As Integer
        Dim xanhnoidia As Integer
        Dim SoLo As String
        Dim HanDung As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function CreateInstance() As tpHoaDon
            Dim result As New tpHoaDon
            With result
                .KyHieu = String.Empty
                .sohd = String.Empty
                .MatHang = String.Empty
                .TenKH = String.Empty
                .DiaChiKH = String.Empty
                .MSTKH = String.Empty
                .HTTT = String.Empty
                .MauSo = String.Empty
                .KyHieuMau = String.Empty
                .sohopdong = String.Empty
                .diadiemgiaohang = String.Empty
                .diadiemnhanhang = String.Empty
                .sovandon = String.Empty
                .socontainer = String.Empty
                .tenvanchuyen = String.Empty
                .HD = 1
                .SoLo = String.Empty
                .HanDung = String.Empty
            End With
            Return result
        End Function
    End Structure
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="p"></param>
    ''' <remarks></remarks>
    Public Sub GhiHoaDon(ByRef p As Integer)
        Dim sql As String = String.Empty
        Try
            With stuHoadon
                If Not KHDetail Then
                    sql = String.Format("INSERT INTO KhachHang (MaSo,MaPhanLoai,SoHieu,Ten,DiaChi,MST) VALUES ({0},{1}, N'{2}', N'{3}', N'{4}', N'{5}')", _
                              .MaSo, _
                              (Lng_MaxValue("MaSo", "PhanLoaiKhachHang")), _
                              (.MaSo), _
                              .TenKH, _
                              .DiaChiKH, _
                              .MSTKH)
                    ExecSQLNonQuery(sql)
                End If
                sql = String.Format("INSERT INTO HoaDon{0} (MaSo,Loai,MaKhachHang,KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,TyLe,HD,KCT,HDBL,NLTS,DN,NK,TS, DC,HTTT,MauSo,KyHieuMau, TyGia,sohopdong, ngayhopdong, diadiemgiaohang, diadiemnhanhang, sovandon, socontainer, tenvanchuyen,den,tim,hong,xanh,xanhnoidia,SoLo,HanDung) VALUES ({1},{2},{3}, N'{4}', N'{5}', N'{6}', N'{7}',{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}, N'{19}', N'{20}',N'{34}',{21}, N'{22}', N'{23}', N'{24}', N'{25}', N'{26}', N'{27}', N'{28}',{29},{30},{31},{32},{33}, N'{35}',N'{36}')", _
                          (IIf(p > 0, "P", String.Empty)), _
                          (.MaSo), _
                          (.loai), _
                          (IIf(KHDetail, .MaKhachHang, .MaSo)), _
                          .KyHieu, _
                          .sohd, _
                          Format(CDate(.NgayPH), Mask_DB), _
                          .MatHang, _
                          CStr(.soluong), _
                          CStr(.ThanhTien), _
                          (.TyLe), _
                          (.HD), _
                          (.KCT), _
                          (.HDBL), _
                          (.NLTS), _
                          (.dn), _
                          (.NK), _
                          (.ts), _
                          (.DC), _
                          .HTTT, _
                          .MauSo, _
                          CStr(.tygia), _
                          .sohopdong, _
                          Format(CDate(IIf(.Ngayhopdong.Year > 1, .Ngayhopdong, Now())), Mask_DB), _
                          .diadiemgiaohang, _
                          .diadiemnhanhang, _
                          .sovandon, _
                          .socontainer, _
                          .tenvanchuyen, _
                          .Den, _
                          .tim, _
                          .hong, _
                          .xanh, _
                          .xanhnoidia, _
                          .KyHieuMau, _
                          .SoLo, _
                          .HanDung)
                ExecSQLNonQuery(sql)
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="h1"></param>
    ''' <param name="h2"></param>
    ''' <remarks></remarks>
    Public Sub CopyHD(ByRef h1 As tpHoaDon, ByRef h2 As tpHoaDon)
        Try
            With h2
                .MaSo = h1.MaSo
                .loai = h1.loai
                .NgayPH = h1.NgayPH
                .MaKhachHang = h1.MaKhachHang
                .KyHieu = h1.KyHieu
                .sohd = h1.sohd
                .MatHang = h1.MatHang
                .soluong = h1.soluong
                .ThanhTien = h1.ThanhTien
                .TyLe = h1.TyLe
                .HD = h1.HD
                .KCT = h1.KCT
                .HDBL = h1.HDBL
                .NLTS = h1.NLTS
                .dn = h1.dn
                .NK = h1.NK
                .ts = h1.ts
                .DC = h1.DC
                .TenKH = h1.TenKH
                .DiaChiKH = h1.DiaChiKH
                .MSTKH = h1.MSTKH
                .HTTT = h1.HTTT
                .MauSo = h1.MauSo
                .KyHieuMau = h1.KyHieuMau
                .tygia = h1.tygia
                .sohopdong = h1.sohopdong
                .Ngayhopdong = h1.Ngayhopdong
                .diadiemgiaohang = h1.diadiemgiaohang
                .diadiemnhanhang = h1.diadiemnhanhang
                .sovandon = h1.sovandon
                .socontainer = h1.socontainer
                .tenvanchuyen = h1.tenvanchuyen
                .Den = h1.Den
                .tim = h1.tim
                .hong = h1.hong
                .xanh = h1.xanh
                .xanhnoidia = h1.xanhnoidia
                .SoLo = h1.SoLo
                .HanDung = h1.HanDung
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub

    Public Sub LayHoaDon(ByRef HD() As tpHoaDon, ByRef mc As Integer)
        Try
            If mc < 0 Then

                Exit Sub
            End If
            CopyHD(HD(mc), stuHoadon)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub

    Public Sub BotHoaDon(ByRef HD() As tpHoaDon, ByRef mc As Integer, ByRef sohd As Integer)
        Try
            If mc < 0 Then
                Exit Sub
            End If
            For i As Integer = mc To sohd - 1
                CopyHD(HD(i), HD(i + 1))
            Next
            sohd -= 1
            If sohd >= 0 Then
                ReDim Preserve HD(sohd)
            Else
                Erase HD
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub XoaHD()
        Try
            With stuHoadon
                .MaSo = 0
                .loai = 0
                .MaKhachHang = 0
                .KyHieu = "..."
                .sohd = "..."
                .MatHang = "..."
                .soluong = 0
                .ThanhTien = 0
                .TyLe = 0
                .HD = 1
                .KCT = 0
                .HDBL = 0
                .NLTS = 0
                .dn = 0
                .NK = 0
                .ts = 0
                .DC = 0
                .TenKH = "..."
                .DiaChiKH = "..."
                .MSTKH = "..."
                .HTTT = "..."
                .MauSo = "..."
                .KyHieuMau = "..."
                .tygia = 0
                .sohopdong = "..."
                .diadiemgiaohang = "..."
                .diadiemnhanhang = "..."
                .sovandon = "..."
                .socontainer = "..."
                .tenvanchuyen = "..."
                .Den = 0
                .tim = 0
                .hong = 0
                .xanh = 0
                .xanhnoidia = 0
                .SoLo = "..."
                .HanDung = "..."
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shtk"></param>
    ''' <param name="dn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PhaiNopVAT(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef shtk As String, ByRef dn As Double) As Double
        Dim result As Double = 0
        Try
            Dim sh1 As String = String.Empty
            If shtk.Length > 6 Then
                sh1 = pVATV & Strings.Right(shtk, shtk.Length - 3)
            Else
                sh1 = pVATV
            End If
            Dim pn As Double = SoPSTK(shtk, tdau, tcuoi, 1)
            pn -= (SoPSTK(sh1, tdau, tcuoi, -1) - PSDu("6", sh1, tdau, tcuoi))
            result = pn
            dn = PSDu(shtk, "111", tdau, tcuoi) + PSDu(shtk, "112", tdau, tcuoi)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="h1"></param>
    ''' <param name="SoHieu"></param>
    ''' <remarks></remarks>
    Public Sub intHDMaso(ByRef h1 As tpHoaDon, ByRef SoHieu As String)
        Try
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM hoadon WHERE sohd=N'{0}'", SoHieu))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                With h1
                    .MaSo = rsItem("MaSo")
                    .loai = rsItem("loai")
                    .NgayPH = rsItem("NgayPH")
                    .MaKhachHang = rsItem("MaKhachHang")
                    .KyHieu = rsItem("KyHieu")
                    .sohd = rsItem("sohd")
                    .MatHang = rsItem("MatHang")
                    .soluong = rsItem("soluong")
                    .ThanhTien = rsItem("ThanhTien")
                    .TyLe = rsItem("TyLe")
                    .HD = rsItem("HD")
                    .KCT = rsItem("KCT")
                    .HDBL = rsItem("HDBL")
                    .NLTS = rsItem("NLTS")
                    .dn = rsItem("dn")
                    .NK = rsItem("NK")
                    .ts = rsItem("ts")
                    .DC = rsItem("DC")
                    .TenKH = Timten("ten", ConvertToStrSafe(.MaKhachHang), "maso", "khachhang")
                    .DiaChiKH = "..."
                    .MSTKH = "..."
                    .HTTT = rsItem("HTTT")
                    .MauSo = rsItem("MauSo")
                    .KyHieuMau = rsItem("KyHieuMau")
                    .tygia = rsItem("tygia")
                    .sohopdong = rsItem("sohopdong")
                    .Ngayhopdong = rsItem("Ngayhopdong")
                    .diadiemgiaohang = rsItem("diadiemgiaohang")
                    .diadiemnhanhang = rsItem("diadiemnhanhang")
                    .sovandon = rsItem("sovandon")
                    .socontainer = rsItem("socontainer")
                    .tenvanchuyen = rsItem("tenvanchuyen")
                    .Den = rsItem("Den")
                    .tim = rsItem("tim")
                    .hong = rsItem("hong")
                    .xanh = rsItem("xanh")
                    .xanhnoidia = rsItem("xanhnoidia")
                    .SoLo = rsItem("SoLo")
                    .HanDung = rsItem("HanDung")
                End With
            Else
                With h1
                    .MaSo = 0
                    .loai = 0
                    .MaKhachHang = 0
                    .KyHieu = "..."
                    .sohd = "..."
                    .MatHang = "..."
                    .soluong = 0
                    .ThanhTien = 0
                    .TyLe = 0
                    .HD = 1
                    .KCT = 0
                    .HDBL = 0
                    .NLTS = 0
                    .dn = 0
                    .NK = 0
                    .ts = 0
                    .DC = 0
                    .TenKH = "..."
                    .DiaChiKH = "..."
                    .MSTKH = "..."
                    .HTTT = "..."
                    .MauSo = "..."
                    .KyHieuMau = "..."
                    .tygia = 0
                    .sohopdong = "..."
                    .diadiemgiaohang = "..."
                    .diadiemnhanhang = "..."
                    .sovandon = "..."
                    .socontainer = "..."
                    .tenvanchuyen = "..."
                    .Den = 0
                    .tim = 0
                    .hong = 0
                    .xanh = 0
                    .xanhnoidia = 0
                    .SoLo = "..."
                    .HanDung = "..."
                End With
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
End Module
