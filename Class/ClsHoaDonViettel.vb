Imports UNET.Utilities
Imports UNET.Utility
Imports UNET.DataAdapter

Public Class ClsHoaDonViettel
    ''' <summary>
    ''' thộc tính của hóa đơn điên tử viettel
    ''' </summary>
    ''' <remarks></remarks>
    Private _maSo As Integer
    Public Property MaSo() As Integer
        Get
            Return _maSo
        End Get
        Set(ByVal value As Integer)
            _maSo = value
        End Set
    End Property

    Private _maCT As Integer
    Public Property MaCT() As Integer
        Get
            Return _maCT
        End Get
        Set(ByVal value As Integer)
            _maCT = value
        End Set
    End Property
    Private _ngayLap As DateTime
    Public Property NgayLap() As DateTime
        Get
            Return _ngayLap
        End Get
        Set(ByVal value As DateTime)
            _ngayLap = value
        End Set
    End Property
    Private _soHoaDonViettel As String
    Public Property SoHoaDonViettel() As String
        Get
            Return _soHoaDonViettel
        End Get
        Set(ByVal value As String)
            _soHoaDonViettel = value
        End Set
    End Property

    ' phuong thuc
    ' them moi
    Public Function ThemMoiHoaDonViettel() As Boolean
        Try
            ExecSQLNonQuery(String.Format("INSERT INTO HoaDonDienTuViettel (MaCT,NgayLap,SoHoaDonViettel) VALUES ({0},'{1}',N'{2}')", _
                            Me._maCT, _
                            Format(CDate(Me._ngayLap), Mask_DB), _
                            Me._soHoaDonViettel))
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return False
    End Function
    ' cap nhat so hieu chung tu
    Public Function CapNhatSoHieuChungTu(ByVal machungtu As Integer, ByVal sohieuchungtu As String, ByVal sohieuchungtu_moi As String) As Boolean
        Try
            If (machungtu = -1) Or (sohieuchungtu = String.Empty) Or (sohieuchungtu_moi = String.Empty) Then
                Return False
            End If
            ' -------cap nhat bang hoa don

            Dim rs_ct As DataTable = ExecSQLReturnDT(String.Format("SELECT [MaSo],[Loai],[MaKhachHang],[KyHieu],[SoHD],[NgayPH],[MatHang],[SoLuong],[ThanhTien],[TyLe],[HD],[KCT],[GiaTT],[HTTT],[MauSo],[HDBL],[NK],[TS],[DC],[TyGia],[NLTS],[DN],[den],[tim],[hong],[xanh],[xanhnoidia],[sohopdong],[ngayhopdong],[diadiemgiaohang],[diadiemnhanhang],[sovandon],[socontainer],[tenvanchuyen],[dain],[KyHieuMau]  FROM [HoaDon]  WHERE [SoHD] = N'{0}'", sohieuchungtu))
            If rs_ct.Rows.Count > 0 Then
                Dim shd As Integer
                For i As Integer = 0 To rs_ct.Rows.Count - 1
                    shd = ConvertToIntSafe(rs_ct.Rows(i)("MaSo").ToString)
                    If shd >= 0 Then
                        ExecSQLNonQuery(String.Format(" UPDATE HoaDon SET SoHD = N'{0}' WHERE MaSo = {1}", sohieuchungtu_moi, shd))
                    End If
                Next
            End If
            rs_ct.Dispose()
            ' ------- cap nhat bang chungtuLQ
            ' chung tu goc
            rs_ct = ExecSQLReturnDT(String.Format("SELECT MaSo,MaCT,ThangCT,SoHieu FROM ChungTu  WHERE SoHieu = N'{0}'", sohieuchungtu))
            If rs_ct.Rows.Count > 0 Then
                Dim masoct As Integer
                For i As Integer = 0 To rs_ct.Rows.Count - 1
                    masoct = ConvertToIntSafe(rs_ct.Rows(i)("MaSo").ToString)
                    If masoct >= 0 Then
                        ExecSQLNonQuery(String.Format(" UPDATE ChungTu SET SoHieu = N'{0}' WHERE MaSo = {1}", sohieuchungtu_moi, masoct))
                    End If
                Next
            End If
            rs_ct.Dispose()

            ' chung tu gia von
            rs_ct = ExecSQLReturnDT(String.Format("SELECT MaSo,MaCT,ThangCT,SoHieu FROM ChungTu  WHERE SoHieu = N'{0}'", sohieuchungtu & "GV"))
            If rs_ct.Rows.Count > 0 Then
                Dim masoct As Integer
                For i As Integer = 0 To rs_ct.Rows.Count - 1
                    masoct = ConvertToIntSafe(rs_ct.Rows(i)("MaSo").ToString)
                    If masoct >= 0 Then
                        ExecSQLNonQuery(String.Format(" UPDATE ChungTu SET SoHieu = N'{0}' WHERE MaSo = {1}", sohieuchungtu_moi & "GV", masoct))
                    End If
                Next
            End If
            rs_ct.Dispose()
            ' -------cap nhat bang chung tu

            rs_ct.Dispose()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return False
    End Function

End Class
