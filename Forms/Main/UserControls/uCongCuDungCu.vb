Public Class uCongCuDungCu
    ' cong cu dung cu
    Private Sub functionCongCuDungCu(ByVal Index As Integer)
        Try
            Select Case Index
                Case 0, 6, 11, 13
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtu.khoi_tao()
                        FrmChungtu.initOption = IIf(Index = 0, 13, IIf(Index = 6, 14, 15))
                        If Index = 11 Then
                            cuongdauky = 6
                        ElseIf Index = 13 Then
                            cuongdauky = 7
                        End If
                        If FrmChungtu.initOption <> 0 Then
                            If Index = 6 Then FrmChungtu.ct_MaKhoHang = 1
                            FrmChungtu.loadluoi = 1
                            FrmChungtu.ShowDialog()
                            FrmChungtu.loadluoi = 0
                            If Index = 6 Then FrmChungtu.ct_MaKhoHang = 0
                        End If
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                Case 1, 9
                    If ChoDieuChinhDauKy() Then
                        pNghiepVu = NV_TANG
                        cuongdauky = 1 'IIf(Index = 1, 1, 2)
                        FrmCongcudungcu.Tag = "1"
                        FrmCongcudungcu.ShowDialog()
                        cuongdauky = 0
                    End If
                Case 2
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSocongcu.ShowDialog()
                Case 3, 14
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtu.khoi_tao()
                        FrmChungtu.initOption = 0
                        If Index = 14 Then
                            'Chứng từ chi phí trả trước
                            FrmChungtu.loai1.Tag = 7
                        End If
                        FrmChungtu.loadluoi = 1
                        FrmChungtu.ShowDialog()
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                Case 4
                    FrmKho.Tag = "4"
                    FrmKho.ShowDialog()
                Case 5
                    If KtraMKAdmin() Then DatTKTS()
                Case 7
                    frmPhanLoai.Tag = "3"
                    frmPhanLoai.ShowDialog()
                Case 8, 10
                    If FADetail Then
                        pNghiepVu = NV_KHONG
                        cuongdauky = IIf(Index = 8, 4, 3)
                        frmDSCCDC.ShowDialog()
                        cuongdauky = 0
                    Else
                        NoRightPublic(2)
                    End If
                Case 12
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtu.initOption = 8
                        'Chứng từ giảm
                        FrmChungtu.loai1.Tag = 6
                        FrmChungtu.ShowDialog()
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                Case 15

                Case 16
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtu.khoi_tao()
                        FrmChungtu.loadluoi = 1
                        FrmChungtu.Nut.Tag = "1"
                        FrmDsCT.tscc = 2
                        FrmChungtu.loadluoi = 1
                        FrmChungtu.ShowDialog()
                        FrmChungtu.loadluoi = 0
                        FrmDsCT.tscc = 0
                        FrmChungtu.loadluoi = 0
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
            End Select

            HienThongBao("...", 1)
            Me.Cursor = Cursors.Default
            MemoryHelper.ReleaseMemory()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub myListview_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView_CongCuDungCu.MouseDown
        Me.Cursor = Cursors.WaitCursor
        Try
            If (e.Button = MouseButtons.Left) AndAlso (e.Clicks = 1) Then
                Dim htInfo As ListViewHitTestInfo = ListView_CongCuDungCu.HitTest(e.X, e.Y)
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
                    Case "tag_CongCuDauKy"
                        functionCongCuDungCu(9)
                    Case "tag_NhapTangCongCu"
                        functionCongCuDungCu(0)
                    Case "tag_ChiPhiTraTruocDauKy"
                        functionCongCuDungCu(1)
                    Case "tag_ChiPhiTraTruoc"
                        functionCongCuDungCu(3)
                    Case "tag_PhanBo"
                        functionCongCuDungCu(6)
                    Case "tag_TraCuuCTCCDC"
                        functionCongCuDungCu(16)
                    Case "tag_SoCCDC"
                        functionCongCuDungCu(2)
                    Case "tag_PhanLoaiCCDC"
                        functionCongCuDungCu(7)
                    Case "tag_SuaGiaTriCCDC"
                        functionCongCuDungCu(8)
                    Case "tag_SuaGiaTriCP"
                        functionCongCuDungCu(10)
                    Case "tag_DoiTuongQuanLyCCDC"
                        functionCongCuDungCu(4)
                    Case "tag_TKChiPhiPB"
                        functionCongCuDungCu(5)
                End Select
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
