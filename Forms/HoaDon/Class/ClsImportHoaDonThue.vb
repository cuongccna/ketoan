Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter
Imports System.Collections.Generic

Public Class ClsImportHoaDonThue
    ' Thông tin chung
    '''Phien ban'''
    Public _PBan As String
    Public _THDon As String
    Public _KHMSHDon As String
    Public _KHHDon As String
    Public _SHDon As String
    Public _MHSo As String
    Public _NLap As String
    Public _SBKe As String
    Public _NBKe As String
    Public _DVTTe As String
    Public _TGia As String
    Public _HTTToan As String
    Public _MSTTCGP As String
    Public _MSTDVNUNLHDon As String
    Public _TDVNUNLHDon As String
    Public _DCDVNUNLHDon As String

    Public Sub New()
        MyBase.New()
        init()
    End Sub
    Sub init()
        _PBan = String.Empty
        _THDon = String.Empty
        _KHMSHDon = String.Empty
        _KHHDon = String.Empty
        _SHDon = String.Empty
        _MHSo = String.Empty
        _NLap = String.Empty
        _SBKe = String.Empty
        _NBKe = String.Empty
        _DVTTe = String.Empty
        _TGia = String.Empty
        _HTTToan = String.Empty
        _MSTTCGP = String.Empty
        _MSTDVNUNLHDon = String.Empty
        _TDVNUNLHDon = String.Empty
        _DCDVNUNLHDon = String.Empty
    End Sub

    'noi dung hoa don
    Public Class ClsNDHDon

        ' nguoi ban
        Public Class ClsNBan
            Public _Ten As String
            Public _MST As String
            Public _DChi As String
            Public _SDThoai As String
            Public _DCTDTu As String
            Public _STKNHang As String
            Public _TNHang As String
            Public _Fax As String
            Public _Website As String
            Public _TTKhac As String

            Public Sub New()
                MyBase.New()
                init()
            End Sub

            Sub init()
                _Ten = String.Empty
                _MST = String.Empty
                _DChi = String.Empty
                _SDThoai = String.Empty
                _DCTDTu = String.Empty
                _STKNHang = String.Empty
                _TNHang = String.Empty
                _Fax = String.Empty
                _Website = String.Empty
                _TTKhac = String.Empty
            End Sub

        End Class

        'nguoi mua
        Public Class ClsNMua
            Public _Ten As String
            Public _MST As String
            Public _DChi As String

            Public _MKHang As String

            Public _SDThoai As String
            Public _HVTNMHang As String
            Public _STKNHang As String
            Public _TNHang As String
            Public _TTKhac As String


            Public Sub New()
                MyBase.New()
                init()
            End Sub

            Sub init()
                _Ten = String.Empty
                _MST = String.Empty
                _DChi = String.Empty
                _MKHang = String.Empty
                _SDThoai = String.Empty
                _HVTNMHang = String.Empty
                _STKNHang = String.Empty
                _TNHang = String.Empty
                _TTKhac = String.Empty
            End Sub
        End Class

        'danh sach dich vu hang hoa

        Public Class ClsDSHHDVu
            
            Public _DSHHDVu As New List(Of ClsHHDVu)

            Public Class ClsHHDVu

                Public _TChat As String
                Public _STT As Integer
                Public _MHHDVu As String
                Public _THHDVu As String
                Public _DVTinh As String
                Public _SLuong As Double
                Public _DGia As Double
                Public _TLCKhau As Double
                Public _STCKhau As Double
                Public _ThTien As Double
                Public _TSuat As String

                Public Class ClsTTKhac

                    Public _DSTTin As New List(Of ClsTTin)

                    Public Class ClsTTin
                        Public _TTruong As String
                        Public _KDLieu As String
                        Public _DLieu As Double

                        Public Sub New()
                            MyBase.New()
                            init()
                        End Sub
                        Sub init()
                            _TTruong = String.Empty
                            _KDLieu = String.Empty
                            _DLieu = 0
                        End Sub
                    End Class

                    Public Sub New()
                        MyBase.New()
                        init()
                    End Sub

                    Sub init()
                        _DSTTin.Clear()
                    End Sub
                End Class

                Public Sub New()
                    MyBase.New()
                    init()
                End Sub
                Public _DSTTKhac As New List(Of ClsTTKhac)
                Sub init()
                    _TChat = String.Empty
                    _STT = 0
                    _MHHDVu = String.Empty
                    _THHDVu = String.Empty
                    _DVTinh = String.Empty
                    _SLuong = 0
                    _DGia = 0
                    _TLCKhau = 0
                    _STCKhau = 0
                    _ThTien = 0
                    _TSuat = String.Empty
                    _DSTTKhac.Clear()
                End Sub

            End Class


            Public Sub New()
                MyBase.New()
                init()
            End Sub

            Sub init()
                If _DSHHDVu.Count > 0 Then
                    _DSHHDVu.Clear()
                End If
            End Sub
        End Class

        ' thong tin thanh toan

        Public Class ClsTToan
            Public _TGTKCThue As Double
            Public _TGTKhac As Double
            Public Class ClsTHTTLTSuat

                Public _DSLTSuat As New List(Of ClsLTSuat)
                Public Class ClsLTSuat

                    Public _TSuat As String
                    Public _ThTien As Double
                    Public _TThue As Double

                    Public Sub New()
                        MyBase.New()
                        init()
                    End Sub
                    Sub init()
                        _TSuat = String.Empty
                        _ThTien = 0
                        _TThue = 0
                    End Sub
                End Class

                Public Sub New()
                    MyBase.New()
                    init()
                End Sub
                Sub init()
                    _DSLTSuat.Clear()
                End Sub
            End Class

            Public _THTTLTSuat As New ClsTHTTLTSuat

            
            Public _TgTCThue As Double
            Public _TgTThue As Double
            Public _TTCKTMai As Double
            Public _TgTTTBSo As Double
            Public _TgTTTBChu As String

            Public Class ClsTTKhac

                Public _DSTTin As New List(Of ClsTTin)

                Public Class ClsTTin
                    Public _TTruong As String
                    Public _KDLieu As String
                    Public _DLieu As Double

                    Public Sub New()
                        MyBase.New()
                        init()
                    End Sub
                    Sub init()
                        _TTruong = String.Empty
                        _KDLieu = String.Empty
                        _DLieu = 0
                    End Sub
                End Class

                Public Sub New()
                    MyBase.New()
                    init()
                End Sub

                Sub init()
                    _DSTTin.Clear()
                End Sub
            End Class

            Public _TTKhac As New ClsTTKhac

            Public Sub New()
                MyBase.New()
                init()
            End Sub

            Sub init()
                _TGTKCThue = 0
                _TGTKhac = 0
                _TgTCThue = 0
                _TgTThue = 0
                _TTCKTMai = 0
                _TgTTTBSo = 0
                _TgTTTBChu = String.Empty

                _TTKhac._DSTTin.Clear()
                _THTTLTSuat._DSLTSuat.Clear()
            End Sub
        End Class
    End Class

End Class
