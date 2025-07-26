Imports System.ComponentModel
Imports System.Text
Imports System.Security.Cryptography
Imports System.Management
Imports System.Data
Imports System.Data.SqlClient
Imports FoxLearn.License

Public Class clsActaxlicense

    Public Shared licensed As Boolean = False
    Public Shared ProductID As String = String.Empty

    Public Shared Sub startACTaxLicense()
        Try
            ProductID = ComputerInfo.GetComputerId()
            Dim km As KeyManager = New KeyManager(ProductID)
            Dim lic As LicenseInfo = New LicenseInfo()
            Dim value As Integer = km.LoadSuretyFile(String.Format("{0}\Key.lic", Application.StartupPath), lic)
            Dim productKey As String = lic.ProductKey

            If km.ValidKey(productKey) Then
                Dim kv As KeyValuesClass = New KeyValuesClass()

                If km.DisassembleKey(productKey, kv) Then
                    If kv.Type = LicenseType.TRIAL Then
                        If (kv.Expiration - DateTime.Now.Date).Days <= 0 Then
                            licensed = False
                        Else
                            licensed = True
                        End If
                    Else
                        licensed = True
                    End If
                    
                Else
                    licensed = False
                End If
            Else
                licensed = False
            End If
        Catch ex As Exception
            licensed = False
        End Try
    End Sub
End Class
