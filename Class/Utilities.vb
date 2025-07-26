
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Utilities


    Private sql As String
    Private dt1 As New DataTable
    Public Const MyKey As String = "#NgovancuongCCNA#"
    Private ran As New Random
    Private My_Encoding As New System.Text.UnicodeEncoding


    Private ngaydangky As String = ""
    Private MST As String = ""
    Private TenKH As String = ""
    Private Keydangky As String = ""

    Public Shared Function Encrypt(ByRef pPassPhrase As String, ByVal pTextToEncrypt As String) As String
        If pPassPhrase.Length > 16 Then
            pPassPhrase = pPassPhrase.Substring(0, 16)
        End If
        If pTextToEncrypt.Trim.Length = 0 Then
            Return String.Empty
        End If
        Return String.Empty
    End Function

    
    Public Function GetImage_FromOpenDialog(ByVal w As Integer, ByVal h As Integer) As Bitmap
        Dim b1, b2 As Bitmap
        Dim ofd1 As New OpenFileDialog
        Dim g1 As Graphics
        b2 = Nothing
        Try
            ofd1.Filter = "JPEG (*.JPG)|*.JPG;JPEG|PNG (*.PNG)|*.PNG|Gif (*.Gif)|*.GIF|All type (*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF"
            If ofd1.ShowDialog = Windows.Forms.DialogResult.OK Then
                b2 = New Bitmap(w, h)
                b1 = New Bitmap(ofd1.FileName)
                g1 = Graphics.FromImage(b2)
                g1.DrawImage(b1, 0, 0, w, h)
                g1.Dispose()
            End If
            ofd1.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return b2
    End Function

    Public Shared Function ConverBitmapToByteArray(ByVal logo As Bitmap) As Byte()
        Try
            Dim MStr As New MemoryStream()
            Dim FileByteArray() As Byte
            logo.Save(MStr, Imaging.ImageFormat.Png)
            FileByteArray = MStr.ToArray
            Return FileByteArray
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Shared Function ConverBitmapToByteArray(ByVal logo As Image) As Byte()
        Try
            Dim MStr As New MemoryStream()
            Dim FileByteArray() As Byte
            If logo Is Nothing Then
                Return Nothing
            End If
            logo.Save(MStr, logo.RawFormat)
            FileByteArray = MStr.ToArray
            Return FileByteArray
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function EncrypteMD5(ByVal inputStr As String) As String
        Try
            Dim En As New System.Text.UTF32Encoding
            Dim byteA() As Byte = En.GetBytes(inputStr)
            Dim byteResult() As Byte
            Dim md5 As New MD5CryptoServiceProvider
            byteResult = md5.ComputeHash(byteA)
            Return Convert.ToBase64String(byteResult)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    Public Shared Function EnTripDESC(ByVal toEncrypt As String, ByVal Key As String, ByVal useHashing As Boolean)
        Try
            Dim resultArray() As Byte
            Dim keyArray() As Byte
            Dim toEncyptArray() As Byte = UTF8Encoding.UTF8.GetBytes(toEncrypt)

            If useHashing Then
                Dim hashmd5 As New MD5CryptoServiceProvider
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key))
            Else
                keyArray = UTF8Encoding.UTF8.GetBytes(Key)
            End If

            Dim tdes As New TripleDESCryptoServiceProvider
            tdes.Key = keyArray
            tdes.Mode = CipherMode.ECB
            tdes.Padding = PaddingMode.PKCS7

            Dim cTransform As ICryptoTransform = tdes.CreateEncryptor
            resultArray = cTransform.TransformFinalBlock(toEncyptArray, 0, toEncyptArray.Length)

            Return Convert.ToBase64String(resultArray, 0, resultArray.Length)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function

    Public Shared Function DeTripDESC(ByVal toDecypt As String, ByVal Key As String, ByVal useHashing As Boolean)
        Try
            Dim resultArray() As Byte
            Dim keyArray() As Byte
            Dim toEncyptArray() As Byte = Convert.FromBase64String(toDecypt)

            If useHashing Then
                Dim hashmd5 As New MD5CryptoServiceProvider
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key))
            Else
                keyArray = UTF8Encoding.UTF8.GetBytes(Key)
            End If

            Dim tdes As New TripleDESCryptoServiceProvider
            tdes.Key = keyArray
            tdes.Mode = CipherMode.ECB
            tdes.Padding = PaddingMode.PKCS7

            Dim cTransform As ICryptoTransform = tdes.CreateDecryptor
            resultArray = cTransform.TransformFinalBlock(toEncyptArray, 0, toEncyptArray.Length)

            Return UTF8Encoding.UTF8.GetString(resultArray)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function ConvertToUnSign(ByVal InputText As String) As String
        Try
            Dim regex = New Regex("\p{IsCombiningDiacriticalMarks}+")
            Dim strformD As String = InputText.Normalize(NormalizationForm.FormD)
            Return regex.Replace(strformD, String.Empty).Replace("đ", "d").Replace("Đ", "D")
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    Public Function CreateEAccount(ByVal InputStr As String) As String
        Try
            Dim result As String = ""
            Dim Ar(), tam As String
            tam = ""
            result = ConvertToUnSign(InputStr)
            result = Trim(result)
            Ar = Split(result)
            For Each x1 As String In Ar
                x1 = Trim(x1)
            Next
            For i As Integer = 0 To Ar.Count - 2
                tam = tam + Left(Ar(i), 1).ToUpper
            Next
            result = Ar(Ar.Count - 1) + tam

            Return result
        Catch ex As Exception
            MessageBox.Show("TestRoles/" & ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function CreateRandomChar(ByVal minChar As Integer, ByVal maxChar As Integer) As Char
        Try
            Dim resultChar As Char
            resultChar = Char.ConvertFromUtf32(ran.Next(minChar, maxChar))
            Return resultChar
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try


    End Function

   
    Public Function CreateRandomChar(ByVal ArChar() As Char) As Char
        Try
            Dim max As Integer = ArChar.Count
            Dim resultChar As Char
            resultChar = ArChar((ran.Next(0, max)))
            Return resultChar
        Catch ex As Exception
            MessageBox.Show("CreateRandomChar/" & ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function CreateRandomString(ByVal minChar As Integer, ByVal maxChar As Integer, ByVal len As Integer) As String
        Try
            Dim result As String = ""
            For i As Integer = 0 To len - 1
                result = result + CreateRandomChar(minChar, maxChar)
            Next
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    Public Function CreateRandomString(ByVal ArChar() As Char, ByVal len As Integer) As String
        Try
            Dim result As String = ""
            For i As Integer = 0 To len - 1
                result = result + CreateRandomChar(ArChar)
            Next
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

  
  
    Public Function CreatePassword_Byte(ByVal str_key As String) As Byte()
        Try
            Return My_Encoding.GetBytes(str_key)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function ConvertNumToString(ByVal so As Long)
        Dim kitu(100) As String
        Dim str As String
        Dim a(100), i, n, solan As Integer
        Dim chu0, chu1, chu2, chu3, chu4, chu5, chu6, chu7, chu8, _
        chu9, chu10, muoi, linh, lam, ti, trieu, ngan, tram, vnd, ketqua As String
        Try
            ''Doi so ra mang so int
            str = CStr(so)
            n = str.Length

            chu0 = "không "
            chu1 = "một "
            chu2 = "hai "
            chu3 = "ba "
            chu4 = "bốn "
            chu5 = "năm "
            chu6 = "sáu "
            chu7 = "bảy "
            chu8 = "tám "
            chu9 = "chín "
            chu10 = "mười "
            muoi = "mươi "
            linh = "linh "
            lam = "lăm "
            ti = "tỉ "
            trieu = "triệu "
            ngan = "ngàn "
            tram = "trăm "
            vnd = "đồng ./."
            ketqua = ""


            For i = 1 To n
                kitu(i) = Left(str, 1)
                str = Right(str, n - i)
                a(i + 3) = CInt(kitu(i)) 'Tinh tien len them 3 
            Next
            'Xoa 4  ki tu dau:
            a(0) = 111 : a(1) = 111 : a(2) = 111 : a(3) = 111
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            n = n + 3                         'Tinh tien len them 3 
            For i = 4 To n
                If a(i) = 0 Then
                    If (n + 1 - i) Mod 3 = 0 Then
                        If a(i + 1) <> 0 Or a(i + 2) <> 0 Then
                            ketqua = ketqua + chu0
                        End If
                    Else
                        If ((n + 2 - i) Mod 3 = 0) Then
                            If (a(i + 1) <> 0) Then
                                ketqua = ketqua + linh
                            End If

                        End If
                    End If
                End If

                If a(i) = 1 Then
                    If (n - i - 1) Mod 3 = 0 Then
                        ketqua = ketqua + chu10
                    Else
                        ketqua = ketqua + chu1
                    End If
                End If


                If (a(i) = 2) Then ketqua = ketqua + chu2
                If (a(i) = 3) Then ketqua = ketqua + chu3
                If (a(i) = 4) Then ketqua = ketqua + chu4

                If (a(i) = 5) Then
                    If ((n - i) Mod 3 = 0 And a(i - 1) <> 0 And a(i - 1) <> 111) Then
                        ketqua = ketqua + lam
                    Else
                        ketqua = ketqua + chu5
                    End If

                End If

                If (a(i) = 6) Then ketqua = ketqua + chu6
                If (a(i) = 7) Then ketqua = ketqua + chu7
                If (a(i) = 8) Then ketqua = ketqua + chu8
                If (a(i) = 9) Then ketqua = ketqua + chu9
                '''''''''Xet ty - trieu - ngan''''''''Neu nhu so dang o vi tri lon hon 3 (hay so dang xet dang o vi tri ngan tro len)
                If n - i >= 3 And (n - i) Mod 3 = 0 Then
                    solan = (n - i) \ 3
                    If solan Mod 3 = 0 Then
                        If a(i - 1) <> 0 Or a(i - 2) <> 0 Then
                            ketqua = ketqua + ti
                        End If
                    End If
                    If solan Mod 3 = 2 Then
                        If a(i - 1) <> 0 Or a(i - 2) <> 0 Then
                            ketqua = ketqua + trieu
                        End If
                    End If
                    If solan Mod 3 = 1 Then
                        If a(i - 1) <> 0 Or a(i - 2) <> 0 Then
                            ketqua = ketqua + ngan
                        End If
                    End If
                End If

                If ((n + 1 - i) Mod 3 = 0 And (a(i + 1) <> 0 Or a(i + 2) <> 0 Or a(i) <> 0)) Then
                    ketqua = ketqua + tram
                ElseIf (n - i - 1) Mod 3 = 0 Then
                    If (a(i) <> 0 And a(i) <> 1) Then
                        ketqua = ketqua + muoi
                    End If
                End If
            Next

            ketqua = ketqua + vnd
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ketqua = Nothing
        End Try

        Return ketqua
    End Function

    Public Function SplitStr(ByVal strIN As String, ByVal splitchar As String, ByVal mode As Integer) As String
        Dim result, array() As String
        Try

            array = strIN.Split(splitchar)
            If mode = 0 Then
                result = array(0)
            Else
                result = array(array.Count - 1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = Nothing
        End Try


        Return result
    End Function

    Public Function ConvertBytesToImage(ByVal bytes As Byte()) As Image
        Try
            Dim MS = New MemoryStream(bytes)
            Return Image.FromStream(MS)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function NextString(ByVal str As String)
        Dim n, n1, n2, so As New Long
        Dim tam2 As String = ""
        Dim tam1 As String = ""
        Dim result As String = ""
        Dim re As New Regex("\d+")
        Dim matches As MatchCollection = re.Matches(str)

        Try
            n = str.Length
            For Each ma1 As Match In matches
                tam2 = ma1.Groups(0).ToString                
            Next
            If IsNumeric(tam2) Then
                so = Long.Parse(tam2) + 1
            Else
                so = 0
            End If

            tam2 = so.ToString
            n2 = tam2.Length
            n1 = n - n2
            If n1 > 0 Then
                tam1 = Left(str, n1)
            Else
                tam1 = ""
            End If
            result = tam1 & tam2
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = Nothing
        End Try


        Return result
    End Function

    Public Function CreateImageFormColor(ByVal brush As SolidBrush, ByVal size As Size) As Image
        Dim result As Image = Nothing
        Dim b1 As Bitmap = New Bitmap(size.Width, size.Height, Imaging.PixelFormat.Format32bppRgb)
        Dim g1 As Graphics = Graphics.FromImage(b1)
        Dim r1 As New Rectangle(0, 0, size.Width, size.Height)

        Try
            g1.FillRectangle(brush, r1)

            result = b1
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = Nothing
        End Try
        Return result
    End Function

    Public Function GetDateTimeInMonth(ByVal m As Integer, ByVal y As Integer) As DateTime()
        Dim result() As DateTime
        Dim numsday = DateTime.DaysInMonth(y, m)
        Try
            ReDim result(numsday - 1)
            For i As Integer = 1 To numsday
                result(i - 1) = New DateTime(y, m, i)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = Nothing
        End Try
        Return result
    End Function

    Public Function SendEmail(ByVal M_Username As String, ByVal M_password As String, ByVal M_From As String, _
                              ByVal M_ToAdress As String, ByVal M_Subject As String, ByVal M_Body As String) As Boolean
        Dim result As Boolean = True
        Try
            Dim SmtpServer As New SmtpClient
            Dim mail As New MailMessage
            SmtpServer.Credentials = Nothing
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            mail = New MailMessage
            mail.From = New MailAddress(M_From)
            mail.To.Add(M_ToAdress)
            mail.Subject = M_Subject
            mail.Body = M_Body
            SmtpServer.Send(mail)
        Catch ex As Exception
            result = False
        End Try

        Return result
    End Function

    Public Function TestInternet() As Boolean
        Dim req As System.Net.HttpWebRequest
        Dim res As System.Net.HttpWebResponse
        TestInternet = False
        Try
            req = CType(System.Net.HttpWebRequest.Create("http://www.google.com"), System.Net.HttpWebRequest)
            res = CType(req.GetResponse(), System.Net.HttpWebResponse)
            req.Abort()
            If res.StatusCode = System.Net.HttpStatusCode.OK Then
                TestInternet = True
            End If
        Catch ex As Exception
            TestInternet = False
        End Try

    End Function
End Class
