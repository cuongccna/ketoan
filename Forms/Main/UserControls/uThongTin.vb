Imports FoxLearn.License
Imports FoxLearn.Encrypt
Imports FoxLearn.Algorithm

Public Class uThongTin
    ' thong tin license

    Private Sub uThongTin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            lblProductID.Text = clsActaxlicense.ProductID 'ComputerInfo.GetComputerId()
            Dim km As KeyManager = New KeyManager(lblProductID.Text)
            Dim lic As LicenseInfo = New LicenseInfo()
            Dim value As Integer = km.LoadSuretyFile(String.Format("{0}\Key.lic", Application.StartupPath), lic)
            Dim productKey As String = lic.ProductKey

            If km.ValidKey(productKey) Then
                Dim kv As KeyValuesClass = New KeyValuesClass()

                If km.DisassembleKey(productKey, kv) Then
                    lblProductName.Text = "ACTax 2.0"
                    lblProductKey.Text = productKey

                    If kv.Type = LicenseType.TRIAL Then
                        lblLicenseType.Text = String.Format("{0} ngày", (kv.Expiration - DateTime.Now.Date).Days)
                    Else
                        lblLicenseType.Text = "Đầy đủ"
                    End If
                    labLicense.Text = "LICENSED"
                    labLicense.ForeColor = Color.Green
                Else
                    labLicense.Text = "NOT LICENSE"
                    labLicense.ForeColor = Color.Red
                End If
            Else
                labLicense.Text = "NOT LICENSE"
                labLicense.ForeColor = Color.Red
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel_DangKy_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_DangKy.LinkClicked
        Try
            'Me.Cursor = Cursors.WaitCursor
            If (frmRegistration.ShowDialog() = DialogResult.OK) Then
                If (frmRegistration.kv.Header <> 0 And frmRegistration.kv.Footer <> 0 And frmRegistration.keyactive <> String.Empty) Then
                    If frmRegistration.kv.Type = LicenseType.TRIAL Then
                        lblLicenseType.Text = String.Format("{0} ngày", (frmRegistration.kv.Expiration - DateTime.Now.Date).Days)
                    Else
                        lblLicenseType.Text = "Đầy đủ"
                    End If
                    lblProductKey.Text = frmRegistration.keyactive

                    labLicense.Text = "LICENSED"
                    labLicense.ForeColor = Color.Green
                    clsActaxlicense.licensed = True
                Else
                    lblLicenseType.Text = "..."
                    lblProductKey.Text = "..."
                    labLicense.Text = "NOT LICENSE"
                    labLicense.ForeColor = Color.Red
                    clsActaxlicense.licensed = False
                End If
            End If            
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel_copy_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_copy.LinkClicked
        If lblProductID.Text <> String.Empty Then
            Clipboard.SetText(lblProductID.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub LinkLabel_copy1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_copy1.LinkClicked
        If lblProductKey.Text <> String.Empty Then
            Clipboard.SetText(lblProductKey.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub LinkLabel_thongTinGiayPhep_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_thongTinGiayPhep.LinkClicked
        Try
            frmThongTinLicense.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class
