Imports System.Security.Cryptography
Module ModLicence

    Private Mykey As String = "U1G#@FFA34AF%^&$#$#%^#@@##!*&@"



    Public Function ModEncrypteMD5(ByVal inputStr As String) As String
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

    Public Function ModEnTripDESC(ByVal toEncrypt As String, ByVal Key As String, ByVal useHashing As Boolean)
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

    Public Function ModDeTripDESC(ByVal toDecypt As String, ByVal Key As String, ByVal useHashing As Boolean)
        Try
            Dim i As Integer = toDecypt.Length
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

    Public Sub GetFolderName()
        Dim FIfo As New System.IO.FileInfo([Assembly].GetEntryAssembly().Location.ToString)
    End Sub
    Public Sub LoadFRegisty_licence()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub TestConnect()
        Try
            LoadFRegisty_licence()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SaveToPublicIM()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub TestLicense()

    End Sub

    Public Function ExecuteSQLCommandDT_modlicence(ByVal SQLCommand As SqlCommand) As DataTable
        Return ExecuteSQLCommandDT_modlicence(SQLCommand, ConfigurationManager.ConnectionStrings("CSoft.My.MySettings.Database2005ConnectionString").ConnectionString)
    End Function

    Public Function ExecuteSQLCommand_modlicence(ByVal SQLCommand As SqlCommand) As Integer
        Return ExecuteSQLCommand_modlicence(SQLCommand, ConfigurationManager.ConnectionStrings("CSoft.My.MySettings.Database2005ConnectionString").ConnectionString)
    End Function


    Public Function ExecuteSQLCommand_modlicence(ByVal SQLCommand As SqlCommand, ByVal ConnectionStringName As String) As Integer
        Dim rowEffect As Integer = 0
        Using SQLConnection As New SqlConnection()
            SQLConnection.ConnectionString = ConnectionStringName
            SQLCommand.Connection = SQLConnection
            SQLConnection.Open()
            Try
                rowEffect = SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Không thể kết nối tới máy chủ dữ liệu!" & vbLf & ex.Message)
            End Try
            SQLConnection.Close()
        End Using
        Return rowEffect
    End Function

    Public Function ExecuteSQLCommandDT_modlicence(ByVal SQLCommand As SqlCommand, ByVal ConnectionStringName As String) As System.Data.DataTable
        Dim SQLDataTable As New DataTable
        Try
            Dim SQLConnection As New SqlConnection
            SQLConnection.ConnectionString = ConnectionStringName
            SQLCommand.Connection = SQLConnection
            SQLConnection.Open()
            Dim SQLDataAdapter As New SqlDataAdapter(SQLCommand)
            SQLDataAdapter.Fill(SQLDataTable)
            SQLConnection.Close()
        Catch ex As Exception
            Throw New Exception("Không thể kết nối tới máy chủ dữ liệu!" & vbLf & ex.Message)
        End Try
        Return SQLDataTable
    End Function

End Module
