Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient


Public Class Utility
    ''' <summary>
    ''' Code type
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum CodeTypes
        Numeric = 0
        Alpha = 1
        Mix = 3
    End Enum
    Public Const DefaultCharacterSet As String = "2345689ABCDEFGHJKMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz"
    Public Const NumberCharacterSet As String = "012345689"
    Public Const AlphaCharacterSet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
#Region "Constructors"
#End Region
#Region "Methods"
    ''' <summary>
    ''' Generate a random code maxlength = 512
    ''' </summary>
    ''' <param name="codeLength">The length of code (by default = 5)</param>
    ''' <returns></returns>        
    Public Shared Function CodeGenerate(Optional ByVal codeLength As Integer = 5, Optional ByVal CodeType As CodeTypes = CodeTypes.Mix) As String
        Dim rndCode As Random = New Random(512)
        Dim codeBaseSt As String = String.Empty
        Dim stbOutput As StringBuilder = New StringBuilder()
        'Fix code length
        If (codeLength < 1) Then
            codeLength = 5
        ElseIf (codeLength > 512) Then
            codeLength = 512
        End If
        'Get code base string
        Select Case CodeType
            Case CodeTypes.Alpha
                codeBaseSt = AlphaCharacterSet
                Exit Select
            Case CodeTypes.Numeric
                codeBaseSt = NumberCharacterSet
                Exit Select
            Case Else
                codeBaseSt = DefaultCharacterSet
        End Select
        'Generate code            
        Dim codeBaseStLen As Integer = codeBaseSt.Length
        For i As Integer = 1 To codeLength
            stbOutput.Append(codeBaseSt.Substring(rndCode.Next(codeBaseStLen), 1))
        Next i
        Return stbOutput.ToString()
    End Function
    ''' <summary>
    ''' Convert number to a string with leading zeros
    ''' </summary>
    ''' <param name="InputNumber"></param>
    ''' <param name="ZeroLength"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Leadingzero(ByVal InputNumber As Integer, Optional ByVal ZeroLength As Integer = 2) As String
        Return InputNumber.ToString.PadLeft(ZeroLength, "0"c)
    End Function
    ''' <summary>
    '''  Convert string to date for server CultureInfo("en-GB", True)
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertToDateSafe(ByVal Input As Object, Optional ByVal DefaultValue As Date = #1/1/1900#) As Date
        'Dim vnFormat AS New CultureInfo("en-GB", True)
        'Reverse month AND day to conform to a different format.
        Dim returnValue As Date
        If (IsDBNull(Input) OrElse String.IsNullOrEmpty(Input)) Then
            returnValue = DefaultValue
        Else
            Try
                Dim vnFormat As New CultureInfo("en-GB", True)
                'Reverse month AND day to conform to a different format.
                returnValue = DateTime.Parse(Input, vnFormat, System.Globalization.DateTimeStyles.NoCurrentDateDefault)
            Catch
                returnValue = DefaultValue
            End Try
        End If
        If returnValue.Year < 1900 Then
            returnValue = DefaultValue
        End If
        Return returnValue
    End Function
    ''' <summary>
    ''' Convert string to Integer Safe
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertToIDSafe(ByVal Input As Object) As Integer
        If (Input Is Nothing) OrElse (IsDBNull(Input)) Then
            Return -1
        End If
        Try
            Return CInt(Input)
        Catch
            Return -1
        End Try
    End Function
    ''' <summary>
    ''' Convert string to Integer Safe
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <param name="DefaultValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertToIntSafe(ByVal Input As Object, Optional ByVal DefaultValue As Integer = 0) As Integer
        If (Input Is Nothing) OrElse (IsDBNull(Input)) Then
            Return DefaultValue
        End If
        Try
            Return CInt(Input)
        Catch
            Return DefaultValue
        End Try
    End Function
    ''' <summary>
    ''' Convert string to Single Safe
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <param name="DefaultValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertToStrSafe(ByVal Input As Object, Optional ByVal DefaultValue As String = "") As String
        If (Input Is Nothing) OrElse (IsDBNull(Input)) Then
            Return DefaultValue
        End If
        Return Input.ToString
    End Function

    ''' <summary>
    ''' Convert string to Double Safe
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <param name="DefaultValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertToDblSafe(ByVal Input As Object, Optional ByVal DefaultValue As Double = 0) As Double
        If (Input Is Nothing) OrElse (IsDBNull(Input)) Then
            Return DefaultValue
        End If
        Try
            Double.TryParse(Input, DefaultValue)
            Return DefaultValue
        Catch
            Return DefaultValue
        End Try
    End Function
    ''' <summary>
    ''' Convert string to Double Safe
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <param name="DefaultValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertToBytSafe(ByVal Input As Object, Optional ByVal DefaultValue As Double = 0) As Double
        If (Input Is Nothing) OrElse (IsDBNull(Input)) Then
            Return DefaultValue
        End If
        Try
            Return CByte(Input)
        Catch
            Return DefaultValue
        End Try
    End Function
    ''' <summary>
    ''' Convert string to Boolean Safe
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <param name="DefaultValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertToBoolSafe(ByVal Input As Object, Optional ByVal DefaultValue As Boolean = False) As Boolean
        If (Input Is Nothing) OrElse (IsDBNull(Input)) Then
            Return DefaultValue
        End If
        Try
            Return CBool(Input)
        Catch
            Return DefaultValue
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Inputdt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function FormatCurency(ByVal Inputdt As Object, Optional ByVal showCurrency As Boolean = True) As String
        If showCurrency Then
            Return String.Format("{0:$##,##0.00}", ConvertToDblSafe(Inputdt))
        Else
            Return String.Format("{0:##,##0.00}", ConvertToDblSafe(Inputdt))
        End If
    End Function
    ''' <summary>
    ''' Convert date1 - date 2 follow format Arithmetic
    ''' </summary>
    ''' <param name="Date1"></param>
    ''' <param name="Date2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function FormatDateArithmetic(ByVal Date1 As Date, ByVal Date2 As Date) As String
        Dim temp As Double = DateDiff(DateInterval.Hour, Date1, Date2)
        Dim Suff As String = String.Empty
        Dim Found As Boolean = False
        If temp <= 1 Then
            temp = DateDiff(DateInterval.Minute, Date1, Date2)
            If (temp <= 1) Then
                Suff = "Just Now"
                Return Suff
            Else
                Suff = " Minutes Ago"
                Return String.Format("{0:#,###} {1}", temp, Suff)
            End If
        End If
        If temp < 24 Then
            Suff = " Hours Ago"
            Found = True
        End If
        If (temp >= 8760) AndAlso (Not Found) Then
            temp = temp / 8760
            Suff = " Years Ago"
            Found = True
        End If
        If (temp >= 720) AndAlso (Not Found) Then
            temp = temp / 720
            Suff = " Months Ago"
            Found = True
        End If
        If (temp >= 168) AndAlso (Not Found) Then
            temp = temp / 168
            Suff = " Weeks Ago"
            Found = True
        End If
        If (temp >= 24) AndAlso (Not Found) Then
            temp = temp / 24
            Suff = " Days Ago"
            Found = True
        End If
        Return String.Format("{0:#,###} {1}", temp, Suff)
    End Function
    ''' <summary>
    ''' Shorten a string with an ellipsis
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Ellipsis(ByVal Input As String, ByVal Length As Integer) As String
        Const Cst_EllipsisSt As String = ".."
        Const Cst_EllipsisLen As Integer = 2
        If (Length > Cst_EllipsisLen) Then
            If (Length < Input.Length) Then
                Length -= Cst_EllipsisLen 'Return string length without EllipsisSt
                Return String.Format("{0}{1}", Left(Input, Length), Cst_EllipsisSt)
            Else
                Return Input
            End If
        End If
        Return Cst_EllipsisSt
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub showDebugInfo(ByVal Title As String, ByVal DevMsg As String, ByVal ex As Exception)
#If DEBUG Then
        MessageBox.Show(String.Format("{1}Error Description:{0}{2}", _
                                                       Environment.NewLine, _
                                                       IIf(Not String.IsNullOrEmpty(DevMsg), String.Format("{0}{1}", DevMsg, vbNewLine), DevMsg), _
                                                       ex), _
            Title, _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation)
#End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objValue"></param>
    ''' <param name="objFormat"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Format(ByVal objValue As Object, ByVal objFormat As String) As String
        Return Format(ConvertToDblSafe(objValue), objFormat)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objValue"></param>
    ''' <param name="objFormat"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Format(ByVal objValue As String, ByVal objFormat As String) As String
        Return Format(ConvertToDblSafe(objValue), objFormat)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objValue"></param>
    ''' <param name="objFormat"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Format(ByVal objValue As Double, ByVal objFormat As String) As String
        Return objValue.ToString(objFormat)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objValue"></param>
    ''' <param name="objFormat"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Format(ByVal objValue As Date, ByVal objFormat As String) As String
        Return FormatDate(objValue, objFormat)
    End Function
#End Region
End Class
