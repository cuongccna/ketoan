Imports FoxLearn.License

Public Class frmRegistration

    Public kv As KeyValuesClass = New KeyValuesClass()
    Public keyactive As String = String.Empty
    Const ProductCode As Integer = 1
    Private Sub frmCaiDat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            txtProductID.Text = clsActaxlicense.ProductID 'ComputerInfo.GetComputerId()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnOK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim km As KeyManager = New KeyManager(txtProductID.Text)
        Dim productKey As String = txtProductKey.Text

        If km.ValidKey(productKey) Then
            If km.DisassembleKey(productKey, kv) Then
                Dim lic As LicenseInfo = New LicenseInfo()
                lic.ProductKey = productKey
                keyactive = productKey
                lic.FullName = "ACTax 2.0"

                If kv.Type = LicenseType.TRIAL Then
                    lic.Day = kv.Expiration.Day
                    lic.Month = kv.Expiration.Month
                    lic.Year = kv.Expiration.Year
                End If

                km.SaveSuretyFile(String.Format("{0}\Key.lic", Application.StartupPath), lic)
                MessageBox.Show("Đăng ký sử dụng thành công.", "đăng ký sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Else
            MessageBox.Show("Mã kích hoạt không đúng!", "đăng ký sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmRegistration_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub
End Class