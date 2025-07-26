Imports System
Imports System.Data
Imports UNET.Utility
Imports UNET.DataAdapter

Friend Class ClsChucvu
    Public MaSo As Integer
    Public sohieu As String = String.Empty
    Public ten As String = String.Empty
    Public HSB_I As Double
    Public HSB_II As Double
    Public HSB_III As Double
    Public HSB_IV As Double
    Public HSB_V As Double
    Public MLB_I As Double
    Public MLB_II As Double
    Public MLB_III As Double
    Public MLB_IV As Double
    Public MLB_V As Double
    Public TVB_I As Double
    Public TVB_II As Double
    Public TVB_III As Double
    Public TVB_IV As Double
    Public TVB_V As Double
    Public LNB_I As Double
    Public LNB_II As Double
    Public LNB_III As Double
    Public LNB_IV As Double
    Public LNB_V As Double
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
    Sub init()
        sohieu = "..."
        ten = "..."
        HSB_I = 0
        HSB_II = 0
        HSB_III = 0
        HSB_IV = 0
        HSB_V = 0
        MLB_I = 0
        MLB_II = 0
        MLB_III = 0
        MLB_IV = 0
        MLB_V = 0
        TVB_I = 0
        TVB_II = 0
        TVB_III = 0
        TVB_IV = 0
        TVB_V = 0
        LNB_I = 0
        LNB_II = 0
        LNB_III = 0
        LNB_IV = 0
        LNB_V = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="TenBang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhiNV(ByVal TenBang As String) As Integer
        Dim kq As Integer = ExecSQLNonQuery(String.Format("INSERT INTO {0} (MaSo,sohieu,ten,hsb1,hsb2,hsb3,hsb4,hsb5,mlb1,mlb2,mlb3,mlb4,mlb5,tvb1,tvb2,tvb3,tvb4,tvb5,lnb1,lnb2,lnb3,lnb4,lnb5) VALUES ({1},N'{2}',N'{3}',{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23})", _
                                                TenBang, _
                                                Lng_MaxValue("MaSo", TenBang) + 1, _
                                                sohieu, _
                                                ten, _
                                                ConvertToStrSafe(HSB_I), _
                                                ConvertToStrSafe(HSB_II), _
                                                ConvertToStrSafe(HSB_III), _
                                                ConvertToStrSafe(HSB_IV), _
                                                ConvertToStrSafe(HSB_V), _
                                                ConvertToStrSafe(MLB_I), _
                                                ConvertToStrSafe(MLB_II), _
                                                ConvertToStrSafe(MLB_III), _
                                                ConvertToStrSafe(MLB_IV), _
                                                ConvertToStrSafe(MLB_V), _
                                                ConvertToStrSafe(TVB_I), _
                                                ConvertToStrSafe(TVB_II), _
                                                ConvertToStrSafe(TVB_III), _
                                                ConvertToStrSafe(TVB_IV), _
                                                ConvertToStrSafe(TVB_V), _
                                                ConvertToStrSafe(LNB_I), _
                                                ConvertToStrSafe(LNB_II), _
                                                ConvertToStrSafe(LNB_III), _
                                                ConvertToStrSafe(LNB_IV), _
                                                ConvertToStrSafe(LNB_V)))
        If kq = 0 Then MaSo = Lng_MaxValue("MaSo", TenBang)
        Return kq
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="TenBang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaNV(ByVal TenBang As String) As Integer
        Return ExecSQLNonQuery(String.Format("UPDATE {0} SET SoHieu=N'{1}',ten=N'{2}',hsb1={3},hsb2={4},hsb3={5},hsb4={6},hsb5={7},mlb1={8},mlb2={9},mlb3={10},mlb4={11},mlb5={12},tvb1={13},tvb2={14},tvb3={15},tvb4={16},tvb5={17},lnb1={18},lnb2={19},lnb3={20},lnb4={21},lnb5={22} WHERE MaSo={23}", _
                                   TenBang, _
                                   sohieu, _
                                   ten, _
                                   ConvertToStrSafe(HSB_I), _
                                   ConvertToStrSafe(HSB_II), _
                                   ConvertToStrSafe(HSB_III), _
                                   ConvertToStrSafe(HSB_IV), _
                                   ConvertToStrSafe(HSB_V), _
                                   ConvertToStrSafe(MLB_I), _
                                   ConvertToStrSafe(MLB_II), _
                                   ConvertToStrSafe(MLB_III), _
                                   ConvertToStrSafe(MLB_IV), _
                                   ConvertToStrSafe(MLB_V), _
                                   ConvertToStrSafe(TVB_I), _
                                   ConvertToStrSafe(TVB_II), _
                                   ConvertToStrSafe(TVB_III), _
                                   ConvertToStrSafe(TVB_IV), _
                                   ConvertToStrSafe(TVB_V), _
                                   ConvertToStrSafe(LNB_I), _
                                   ConvertToStrSafe(LNB_II), _
                                   ConvertToStrSafe(LNB_III), _
                                   ConvertToStrSafe(LNB_IV), _
                                   ConvertToStrSafe(LNB_V), _
                                   ConvertToStrSafe(MaSo)))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="TenBang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaNV(ByVal TenBang As String) As Integer
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 maso AS F1 FROM QuanlyNhanvien WHERE machucvu={0}", MaSo))) = 0 Then
            Return ExecSQLNonQuery(String.Format("DELETE  FROM {0} WHERE MaSo={1}", TenBang, ConvertToStrSafe(MaSo)))
        Else
            Return -1
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="TenBang"></param>
    ''' <param name="ms"></param>
    ''' <remarks></remarks>
    Public Sub InitNVMaSo(ByVal TenBang As String, ByVal ms As Integer)
        Dim rs As DataTable
        init()
        If ms > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM {0} WHERE MaSo={1}", TenBang, ConvertToStrSafe(ms)))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                Try
                    MaSo = rsItem("MaSo")
                    sohieu = rsItem("sohieu")
                    ten = rsItem("ten")
                    HSB_I = rsItem("HSB1")
                    HSB_II = rsItem("HSB2")
                    HSB_III = rsItem("HSB3")
                    HSB_IV = rsItem("HSB4")
                    HSB_V = rsItem("HSB5")
                    MLB_I = rsItem("MLB1")
                    MLB_II = rsItem("MLB2")
                    MLB_III = rsItem("MLB3")
                    MLB_IV = rsItem("MLB4")
                    MLB_V = rsItem("MLB5")
                    TVB_I = rsItem("TVB1")
                    TVB_II = rsItem("TVB2")
                    TVB_III = rsItem("TVB3")
                    TVB_IV = rsItem("TVB4")
                    TVB_V = rsItem("TVB5")
                    LNB_I = rsItem("LNB1")
                    LNB_II = rsItem("LNB2")
                    LNB_III = rsItem("LNB3")
                    LNB_IV = rsItem("LNB4")
                    LNB_V = rsItem("LNB5")
                Catch ex As Exception
                End Try
                rs = Nothing
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="TenBang"></param>
    ''' <param name="sh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitNVSoHieu(ByVal TenBang As String, ByVal sh As String) As Integer
        Dim ms As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM {0} WHERE SoHieu=N'{1}'", TenBang, sh)))
        If ms > 0 Then InitNVMaSo(TenBang, ms)
        Return ms
    End Function
End Class
