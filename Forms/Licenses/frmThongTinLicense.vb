Public Class frmThongTinLicense
    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub frmLicenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' nhap chung tu
            lnvt1.Visible = clsActaxlicense.licensed
            lnvt2.Visible = Not clsActaxlicense.licensed

            lxvt1.Visible = clsActaxlicense.licensed
            lxvt2.Visible = Not clsActaxlicense.licensed

            lbh1.Visible = clsActaxlicense.licensed
            lbh2.Visible = Not clsActaxlicense.licensed

            ltn1.Visible = clsActaxlicense.licensed
            ltn2.Visible = Not clsActaxlicense.licensed

            ltran1.Visible = clsActaxlicense.licensed
            ltran2.Visible = Not clsActaxlicense.licensed

            lcpth1.Visible = clsActaxlicense.licensed
            lcpth2.Visible = Not clsActaxlicense.licensed

            ' bao cao chi tiet
            lbcccdc1.Visible = clsActaxlicense.licensed
            lbcccdc2.Visible = Not clsActaxlicense.licensed

            lbccn1.Visible = clsActaxlicense.licensed
            lbccn2.Visible = Not clsActaxlicense.licensed

            lbccpth1.Visible = clsActaxlicense.licensed
            lbccpth2.Visible = Not clsActaxlicense.licensed

            lbcgt1.Visible = clsActaxlicense.licensed
            lbcgt2.Visible = Not clsActaxlicense.licensed

            lbctscd1.Visible = clsActaxlicense.licensed
            lbctscd2.Visible = Not clsActaxlicense.licensed

            lbcvthh1.Visible = clsActaxlicense.licensed
            lbcvth2.Visible = Not clsActaxlicense.licensed

            ' bao cao tong hop
            lbcth1.Visible = clsActaxlicense.licensed
            lbcth2.Visible = Not clsActaxlicense.licensed


        Catch ex As Exception

        End Try
    End Sub
End Class