Public Class ClsUser
    Private Shared _MaSo As Integer = -1
    Private Shared _TenNSD As String = String.Empty
    Private Shared _Psw As Integer = -1
    Private Shared _UserRight As Integer = -1
    Private Shared _VT As Integer = -1

    Public Shared Property MaSo() As Integer
        Get
            Return _MaSo
        End Get
        Set(ByVal value As Integer)
            If _MaSo = value Then
                Return
            End If
            _MaSo = value
        End Set
    End Property

    Public Shared Property TenNSD() As String
        Get
            Return _TenNSD
        End Get
        Set(ByVal value As String)
            If _TenNSD = value Then
                Return
            End If
            _TenNSD = value
        End Set
    End Property

    Public Shared Property Psw() As Integer
        Get
            Return _Psw
        End Get
        Set(ByVal value As Integer)
            If _Psw = value Then
                Return
            End If
            _Psw = value
        End Set
    End Property
    Public Shared Property UserRight() As Integer
        Get
            Return _UserRight
        End Get
        Set(ByVal value As Integer)
            If _UserRight = value Then
                Return
            End If
            _UserRight = value
        End Set
    End Property
    Public Shared Property VT() As Integer
        Get
            Return _VT
        End Get
        Set(ByVal value As Integer)
            If _VT = value Then
                Return
            End If
            _VT = value
        End Set
    End Property
End Class
