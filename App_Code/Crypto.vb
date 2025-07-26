Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Crypto
    Public Shared cryptoKey As String = "#$#@($&@#&$#)(JSDLKFJ$)FDLGSDS:DF!~@!~(#*&~@($#& @$#!$)#!*$)(!@#$KLDFNSQA&#)!#~#*~)##)!@"

    Public Shared Sub FileDecrypt(ByVal sourceFile As String, ByVal destinationFile As String, ByVal keyText As String)
        Dim stream As New FileStream(sourceFile, FileMode.Open, FileAccess.Read)
        Dim stream2 As New FileStream(destinationFile, FileMode.Create, FileAccess.Write)
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Crypto.GetHash(keyText))
        Dim rgbIV As Byte() = New Byte() {50, &HC7, 10, &H9F, &H84, &H37, &HEC, &HBD, &H33, &HF3, &HF4, &H5B, &H11, &H88, &H27, 230}
        Dim managed As New RijndaelManaged
        Dim transform As ICryptoTransform = Nothing
        transform = managed.CreateDecryptor(bytes, rgbIV)
        Dim stream3 As New CryptoStream(stream2, transform, CryptoStreamMode.Write)
        Dim buffer As Byte() = New Byte(&H1001 - 1) {}
        Dim count As Integer = 0
        Do While True
            count = stream.Read(buffer, 0, &H1000)
            If (count = 0) Then
                Exit Do
            End If
            stream3.Write(buffer, 0, count)
        Loop
        stream3.Close()
        stream.Close()
        stream2.Close()
    End Sub

    Public Shared Sub FileEncrypt(ByVal sourceFile As String, ByVal destinationFile As String, ByVal keyText As String)
        Dim stream As New FileStream(sourceFile, FileMode.Open, FileAccess.Read)
        Dim stream2 As New FileStream(destinationFile, FileMode.Create, FileAccess.Write)
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Crypto.GetHash(keyText))
        Dim rgbIV As Byte() = New Byte() {50, &HC7, 10, &H9F, &H84, &H37, &HEC, &HBD, &H33, &HF3, &HF4, &H5B, &H11, &H88, &H27, 230}
        Dim managed As New RijndaelManaged
        Dim transform As ICryptoTransform = Nothing
        transform = managed.CreateEncryptor(bytes, rgbIV)
        Dim stream3 As New CryptoStream(stream2, transform, CryptoStreamMode.Write)
        Dim buffer As Byte() = New Byte(&H1001 - 1) {}
        Dim count As Integer = 0
        Do While True
            count = stream.Read(buffer, 0, &H1000)
            If (count = 0) Then
                Exit Do
            End If
            stream3.Write(buffer, 0, count)
        Loop
        stream3.Close()
        stream.Close()
        stream2.Close()
    End Sub

    Public Shared Function GetHash(ByVal plainText As String) As String
        Dim bytes As Byte() = Nothing
        Dim provider As MD5CryptoServiceProvider = Nothing
        Try
            bytes = Encoding.UTF8.GetBytes(plainText)
            provider = New MD5CryptoServiceProvider
            Return BitConverter.ToString(provider.ComputeHash(bytes)).Replace("-", String.Empty)
        Catch
            Return String.Empty
        End Try
    End Function

    Public Shared Function StringDecrypt(ByVal encrypted As String, ByVal keyText As String) As String
        Try
            Dim buffer As Byte() = Convert.FromBase64String(encrypted)
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(Crypto.GetHash(keyText))
            Dim rgbIV As Byte() = New Byte() {&H17, &H77, 10, &H36, &H84, &H16, &HF1, &H71, 12, &H83, &HF2, 200, &H5E, &H41, &H4A, &H55}
            Dim buffer4 As Byte() = New Byte(buffer.Length - 1) {}
            Dim managed As New RijndaelManaged
            Dim stream As New MemoryStream(buffer)
            Dim transform As ICryptoTransform = Nothing
            transform = managed.CreateDecryptor(bytes, rgbIV)
            Dim stream2 As New CryptoStream(stream, transform, CryptoStreamMode.Read)
            stream2.Read(buffer4, 0, buffer4.Length)
            stream.Close()
            stream2.Close()
            Return Encoding.UTF8.GetString(buffer4).Replace(Convert.ToChar(0).ToString, String.Empty)
        Catch
            Return String.Empty
        End Try
    End Function

    Public Shared Function StringEncrypt(ByVal plainText As String, ByVal keyText As String) As String
        Dim str As String = String.Empty
        Try
            plainText.Replace(Convert.ToChar(0).ToString, String.Empty)
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(plainText)
            Dim rgbKey As Byte() = Encoding.UTF8.GetBytes(Crypto.GetHash(keyText))
            Dim rgbIV As Byte() = New Byte() {&H17, &H77, 10, &H36, &H84, &H16, &HF1, &H71, 12, &H83, &HF2, 200, &H5E, &H41, &H4A, &H55}
            Dim managed As New RijndaelManaged
            Dim stream As New MemoryStream
            Dim transform As ICryptoTransform = Nothing
            transform = managed.CreateEncryptor(rgbKey, rgbIV)
            Dim stream2 As New CryptoStream(stream, transform, CryptoStreamMode.Write)
            stream2.Write(bytes, 0, bytes.Length)
            stream2.FlushFinalBlock()
            str = Convert.ToBase64String(stream.ToArray)
            stream.Close()
            stream2.Close()
        Catch
            str = String.Empty
        End Try
        Return str
    End Function

End Class

