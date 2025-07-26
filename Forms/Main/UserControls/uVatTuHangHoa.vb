Public Class uVatTuHangHoa

    ' quan ly vat tu hang hoa menu
    Private Sub functionVatTuHangHoa(ByVal Index As Integer)
        Try
            Dim loai As Integer
            Select Case Index
                Case 0, 3, 4, 20, 21
                    If LicenseACTax() And ChoNhapTiep() Then
                        loai = IIf(Index = 0 Or Index = 21, 1, IIf(Index = 3, 8, 2))
                        If Index = 0 Or Index = 21 Then
                            FrmChungtu.initOption = 1
                        ElseIf Index = 3 Then
                            'Bán hàng
                            FrmChungtu.initOption = 8
                        Else
                            'Xuất hàng
                            FrmChungtu.initOption = 2
                        End If
                        FrmChungtu.initOption = loai
                        FrmChungtu.ShowDialog()
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                Case 1, 18
                    If Index = 1 Then
                        CPGV.Tag = "0"
                    Else
                        CPGV.Tag = "1"
                    End If
                    CPGV.ShowDialog()
                Case 2
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSovattuhanghoa.ShowDialog()
                Case 5
                    If STDetail Then
                        FrmLuuChuyen.ShowDialog()
                    Else
                        NoRightPublic(1)
                    End If
                Case 6
                    If Not STDetail Then
                        NoRightPublic(1)
                        GoTo kt
                    End If
                    KiemTraVatTu()
                    HienThongBao("Xong ...", 1)
                    Exit Sub
                Case 7
                    FrmNguon.ShowDialog()
                Case 8
                    If STDetail Then
                        FrmKho.Tag = "1"
                        FrmKho.ShowDialog()
                    Else
                        NoRightPublic(1)
                    End If
                Case 9
                    frmPhanLoaiVT.pl1 = "1"
                    frmPhanLoaiVT.ShowDialog()
                    frmPhanLoaiVT.pl1 = "0"
                Case 10
                    If ChoDieuChinhDauKy() Then
                        FVTDauKy.ShowDialog()
                    End If
                Case 11
                    If STDetail Then
                        FrmVattu.ShowDialog()
                    Else
                        NoRightPublic(1)
                    End If
                Case 12
                    If STDetail Then
                        FrmDuphong.ShowDialog()
                    Else
                        NoRightPublic(1)
                    End If
                Case 13 : If KtraMKAdmin() Then
                        DatTKVTPublic()
                    Else
                        DatTKVTPublic()
                    End If
                Case 14 : If KtraMKAdmin() Then
                        DatTKDTTPPublic()
                    Else
                        DatTKDTTPPublic()
                    End If
                Case 15 : FrmHD.ShowDialog()                
                Case 17 : Lapbangke()
                Case 19 : FrmHDnoidia.ShowDialog()
                Case 22
                    If LicenseACTax() And ChoNhapTiep() Then
                        FrmChungtu.initOption = 0
                        'Chi phí nhập hàng
                        FrmChungtu.loai1.Tag = "0"
                        FrmChungtu.ShowDialog()
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
            End Select
kt:
            HienThongBao("...", 1)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub ListView_VatTuHangHoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView_VatTuHangHoa.Click
        Try

        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Private Sub listView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ListView_VatTuHangHoa.Click
    '    Dim mousePos As Point = ListView_VatTuHangHoa.PointToClient(Control.MousePosition)
    '    Dim hitTest As ListViewHitTestInfo = ListView_VatTuHangHoa.HitTest(mousePos)
    '    Dim columnIndex As Integer = hitTest.Item.SubItems.IndexOf(hitTest.SubItem)
    'End Sub

    Private Sub myListview_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView_VatTuHangHoa.MouseDown
        Me.Cursor = Cursors.WaitCursor
        Try
            If (e.Button = MouseButtons.Left) AndAlso (e.Clicks = 1) Then
                Dim htInfo As ListViewHitTestInfo = ListView_VatTuHangHoa.HitTest(e.X, e.Y)
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
                    Case "tag_VatTuDauKy"
                        functionVatTuHangHoa(10)
                    Case "tag_MuaHangTrongNuoc"
                        functionVatTuHangHoa(0)
                    Case "tag_NhapNoiDia"
                        functionVatTuHangHoa(18)
                    Case "tag_NhapKhau"
                        functionVatTuHangHoa(1)
                    Case "tag_BanHang"
                        functionVatTuHangHoa(3)
                    Case "tag_PhieuXuat"
                        functionVatTuHangHoa(4)
                    Case "tag_LuuChuyenNoiBo"
                        functionVatTuHangHoa(5)
                    Case "tag_LapBangKeBanLe"
                        functionVatTuHangHoa(17)
                    Case "tag_BaoCaoChiTiet"
                        functionVatTuHangHoa(2)
                    Case "tag_DanhSachVatTu"
                        functionVatTuHangHoa(11)
                    Case "tag_PhanLoaiVatTu"
                        functionVatTuHangHoa(9)
                    Case "tag_KenhPhanPhoi"
                        functionVatTuHangHoa(7)
                    Case "tag_DanhSachKho"
                        functionVatTuHangHoa(8)
                    Case "tag_ChiTietTKVT"
                        functionVatTuHangHoa(13)
                    Case "tag_DuPhongGiamGia"
                        functionVatTuHangHoa(12)
                    Case "tag_ChiTietTKDT"
                        functionVatTuHangHoa(14)
                    Case "tag_HopDongNhapKhau"
                        functionVatTuHangHoa(15)
                    Case "tag_HoaDonNoiDia"
                        functionVatTuHangHoa(19)
                End Select
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Private Sub ListView_VatTuHangHoa_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView_VatTuHangHoa.ItemActivate
        Try

        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
