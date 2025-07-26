Public Class uThaoTacNhanh
    Private Sub myListview_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView_ThaoTacNhanh.MouseDown
        Me.Cursor = Cursors.WaitCursor
        Try
            If (e.Button = MouseButtons.Left) AndAlso (e.Clicks = 1) Then
                Dim htInfo As ListViewHitTestInfo = ListView_ThaoTacNhanh.HitTest(e.X, e.Y)
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
                    'nhap dau ky\
                    Case "tag_vattudauky"
                        If ChoDieuChinhDauKy() Then
                            FVTDauKy.ShowDialog()
                        End If
                    Case "tag_congnodauky"
                        If ChoDieuChinhDauKy() Then
                            If pCongNoHD = 0 Then
                                FKHDauKy.ShowDialog()
                            Else
                                FKHDauKy2.ShowDialog()
                            End If
                        End If
                    Case "tag_taisandauky"
                        If ChoDieuChinhDauKy() Then
                            pNghiepVu = NV_TANG
                            frmTaiSan.Tag = "1"
                            frmTaiSan.lc = 1
                            frmTaiSan.ShowDialog()
                            frmTaiSan.lc = 0
                        End If
                    Case "tag_congcudauky"
                        If ChoDieuChinhDauKy() Then
                            pNghiepVu = NV_TANG
                            cuongdauky = 2
                            FrmCongcudungcu.Tag = "1"
                            FrmCongcudungcu.ShowDialog()
                            cuongdauky = 0
                        End If
                        'nhap chung tu
                    Case "tag_ttn_nhapvattu"
                        If (ChoNhapTiep() And LicenseACTax()) Then
                            FrmChungtu.initOption = 1
                            FrmChungtu.ShowDialog()
                        Else
                            myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case "tag_ttn_banhang"
                        If ChoNhapTiep() And LicenseACTax() Then
                            FrmChungtu.initOption = 8
                            FrmChungtu.ShowDialog()
                        Else
                            myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case "tag_ttn_xuatvattu"
                        If ChoNhapTiep() And LicenseACTax() Then
                            FrmChungtu.initOption = 2
                            FrmChungtu.ShowDialog()
                        Else
                            myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        'Case "tag_ttn_xuatvattu"
                        '    If ChoNhapTiep() And LicenseACTax() Then
                        '        FrmChungtu.initOption = 2
                        '        FrmChungtu.ShowDialog()
                        '    Else
                        '        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    End If
                    Case "tag_ttn_thuno"
                        If LicenseACTax() Then
                            FrmChungtu.loai1.Tag = "1"
                            FrmChungtu.loaino.Tag = "0"
                            FrmChungtu.initOption = 0
                            FrmChungtu.ShowDialog()
                            FrmChungtu.loai1.Tag = "0"
                            FrmChungtu.loaino.Tag = "0"
                        Else
                            myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        
                    Case "tag_ttn_trano"
                        If LicenseACTax() Then
                            FrmChungtu.loai1.Tag = "1"
                            FrmChungtu.loaino.Tag = "1"
                            FrmChungtu.initOption = 0
                            FrmChungtu.ShowDialog()
                            FrmChungtu.loai1.Tag = "0"
                            FrmChungtu.loaino.Tag = "0"
                        Else
                            myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        
                    Case "tag_ttn_nhapchiphitonghop"
                        If LicenseACTax() Then
                            FrmChungtu.loai1.Tag = 0 ' Cũ là 2 edit ngay 23-3-19
                            FrmChungtu.initOption = 0
                            FrmChungtu.ShowDialog()
                        Else
                            myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        ' bao cao chi tiet
                    Case "tag_ttn_vattuhanghoa"
                        If pRpt = CheckState.Checked And User_Right = 1 Then
                            ErrMsg(er_KoSD)
                        Else
                            FrmSovattuhanghoa.ShowDialog()
                        End If
                    Case "tag_ttn_congno"
                        If pRpt = CheckState.Checked And User_Right = 1 Then
                            ErrMsg(er_KoSD)
                        Else
                            FrmSoCongNo.ShowDialog()
                        End If

                    Case "tag_ttn_giathanh"
                        If pRpt = CheckState.Checked And User_Right = 1 Then
                            ErrMsg(er_KoSD)
                        Else
                            FrmSogiathanh.ShowDialog()
                        End If
                    Case "tag_ttn_taisancodinh"
                        If pRpt = CheckState.Checked And User_Right = 1 Then
                            ErrMsg(er_KoSD)
                        Else
                            FrmSotaisan.ShowDialog()
                        End If

                    Case "tag_ttn_congcudungcu"
                        If pRpt = CheckState.Checked And User_Right = 1 Then
                            ErrMsg(er_KoSD)
                        Else
                            FrmSocongcu.ShowDialog()
                        End If

                    Case "tag_ttn_chiphitonghop"
                        If pRpt = CheckState.Checked And User_Right = 1 Then
                            ErrMsg(er_KoSD)
                        Else
                            FrmSochiphi.ShowDialog()
                        End If
                        'bao cao tong hop
                    Case "tag_ttn_baocaotonghop"
                        If pRpt = 1 And User_Right = 1 Then
                            ErrMsg(er_KoSD)
                        Else
                            FrmMNBaocao.ShowDialog()
                        End If

                End Select
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
