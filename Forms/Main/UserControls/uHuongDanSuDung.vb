Public Class uHuongDanSuDung

    Private Sub ListViewHuongDan_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewHuongDan.MouseDown
        Me.Cursor = Cursors.WaitCursor
        Try
            If (e.Button = MouseButtons.Left) AndAlso (e.Clicks = 1) Then
                Dim htInfo As ListViewHitTestInfo = ListViewHuongDan.HitTest(e.X, e.Y)
                If IsNothing(htInfo) Then
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                If IsNothing(htInfo.Item) Then
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                If IsNothing(htInfo.Item.Tag) Then
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                ''' bat dau thuc hien
                Select Case htInfo.Item.Tag.ToString()
                    Case "tag_gioithieutongquan" 'tong quan
                        Try
                            Process.Start("https://youtu.be/KzNpOC0h-ic")
                        Catch __unusedException1__ As Exception
                        End Try
                        Exit Select
                    Case "tag_daukycongno" ' dau ky
                        Try
                            Process.Start("https://youtu.be/QvnOLSFcGTM")
                        Catch __unusedException1__ As Exception
                        End Try
                        Exit Select
                    Case "tag_daukyhanghoavattu"
                        Try
                            Process.Start("https://youtu.be/r_to9JVWse0")
                        Catch __unusedException1__ As Exception
                        End Try
                        Exit Select
                    Case "tag_daukykhongchitiet"
                        Try
                            Process.Start("https://youtu.be/M20SYYiSGEI")
                        Catch __unusedException1__ As Exception
                        End Try
                        Exit Select
                    Case "tag_tracuuchungtu" ' nhap chung tu
                        Try
                            Process.Start("https://youtu.be/Dr2EyGBvfwI")
                        Catch __unusedException1__ As Exception
                        End Try
                        Exit Select                    
                    Case "tag_nhapmuahang"
                        Try
                            Process.Start("https://youtu.be/G1baUxDhp6E")
                        Catch __unusedException1__ As Exception
                        End Try
                        Exit Select
                    Case "tag_nhaphoadonbanhang"
                        Try
                            Process.Start("https://youtu.be/kXsHQ5sH3rs")
                        Catch __unusedException1__ As Exception
                        End Try
                        Exit Select
                    
                End Select
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
