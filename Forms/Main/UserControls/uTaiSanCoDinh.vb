Public Class uTaiSanCoDinh
    'tai san co dinh
    Private Sub functionTaiSanCoDinh(ByVal Index As Integer)
        Try
            Cursor = Cursors.WaitCursor
            Select Case Index
                Case 0, 3, 5, 6
                    If ChoNhapTiep() And LicenseACTax() Then
                        'FrmChungtu.OptLoai(IIf(Index = 0, 9, (IIf(Index = 3, 10, (IIf(Index = 5, 11, 12)))))).Checked = True
                        FrmChungtu.initOption = IIf(Index = 0, 9, (IIf(Index = 3, 10, (IIf(Index = 5, 11, 12)))))
                        If FrmChungtu.initOption <> 0 Then
                            If Index = 6 Then FrmChungtu.ct_MaKhoHang = 1
                            FrmChungtu.ShowDialog()
                            If Index = 6 Then FrmChungtu.ct_MaKhoHang = 0
                        End If
                        'FrmChungtu.initOption = 4
                        'FrmChungtu.Close()
                        'Me.ShowDialog()
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                Case 1
                    FrmKho.Tag = "4"
                    FrmKho.ShowDialog()
                Case 2
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSotaisan.ShowDialog()
                Case 4
                    If KtraMKAdmin() Then DatTKTS()
                Case 7
                    frmPhanLoai.Tag = "1"
                    frmPhanLoai.ShowDialog()
                Case 8
                    If FADetail Then
                        pNghiepVu = NV_KHONG
                        frmDSTaiSan.ShowDialog()
                    Else
                        NoRightPublic(2)
                    End If
                Case 9
                    If ChoDieuChinhDauKy() Then
                        pNghiepVu = NV_TANG
                        frmTaiSan.Tag = "1"
                        frmTaiSan.lc = 1
                        frmTaiSan.ShowDialog()
                        frmTaiSan.lc = 0
                    End If
                Case 10
                    FrmKho.Tag = "2"
                    FrmKho.ShowDialog()
                Case 11
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtu.khoi_tao()
                        FrmChungtu.Nut.Tag = "1"
                        FrmDsCT.tscc = 1
                        FrmChungtu.flag = -1
                        FrmChungtu.loadluoi = 1
                        FrmChungtu.ShowDialog()
                        FrmChungtu.loadluoi = 0
                        FrmDsCT.tscc = 0
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                Case 12
                    FrmKho.Tag = "3"
                    FrmKho.ShowDialog()
                Case 13
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtu.khoi_tao()
                        FrmChungtu.initOption = 0
                        'Chi phí nhập hàng
                        FrmChungtu.loai1.Tag = "0"
                        FrmChungtu.loadluoi = 1
                        FrmChungtu.ShowDialog()
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                Case 14
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtu.initOption = 8
                        'Chứng từ giảm
                        FrmChungtu.loai1.Tag = 6
                        FrmChungtu.ShowDialog()
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                Case 15

            End Select

            HienThongBao("...", 1)
            MemoryHelper.ReleaseMemory()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub myListview_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView_taisancodinh.MouseDown
        Me.Cursor = Cursors.WaitCursor
        Try
            If (e.Button = MouseButtons.Left) AndAlso (e.Clicks = 1) Then
                Dim htInfo As ListViewHitTestInfo = ListView_taisancodinh.HitTest(e.X, e.Y)
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
                    Case "tag_TaiSanDauKy"
                        functionTaiSanCoDinh(9)
                    Case "tag_NhapTangTaiSan"
                        functionTaiSanCoDinh(0)
                    Case "tag_GiamTaiSan"
                        functionTaiSanCoDinh(3)
                    Case "tag_DanhGiaLaiTaiSan"
                        functionTaiSanCoDinh(5)
                    Case "tag_KhauHao"
                        functionTaiSanCoDinh(6)
                    Case "tag_TraCuuCTTaiSan"
                        functionTaiSanCoDinh(11)
                    Case "tag_SoTaiSan"
                        functionTaiSanCoDinh(2)
                    Case "tag_PhanLoaiTaiSan"
                        functionTaiSanCoDinh(7)
                    Case "tag_SuaGiatriTaiSan"
                        functionTaiSanCoDinh(8)
                    Case "tag_NuocSanXuat"
                        functionTaiSanCoDinh(10)
                    Case "tag_TinhTrangSuDung"
                        functionTaiSanCoDinh(12)
                    Case "tag_DoiTuongQuanLy"
                        functionTaiSanCoDinh(1)
                    Case "tag_TaiKhoanChiPhi"
                        functionTaiSanCoDinh(4)
                End Select
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
