Imports UNET.Utility
Imports UNET.DataAdapter

Public Class uCongNo
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DatTKCN()
        Dim TK As New ClsTaikhoan
        FrmGetStr.Tag = "2"
        Dim shtk As String = FrmGetStr.GetString("Số hiệu TK", "Đặt/Bỏ TK theo dõi chi tiết")
        If Not (shtk.Length = 0) Then
            TK.InitTaikhoanSohieu(shtk)
            If Not (TK.maso = 0) Then
                If TK.tk_id = TKVT_ID Or TK.tk_id = TSCD_ID Or TK.tk_id = KHTSCD_ID Or TK.tk_id = TKThue_ID Or TK.tk_id = TKDT_ID Then
                    Exit Sub
                End If
                If TK.TkCoPS(0, 0) Then
                    Me.Cursor = Cursors.WaitCursor
                    If TK.ChuyenChiTietSangDoiTuong() Then
                        myUMessager.mWarning(Ngonngu("Các chi tiết tài khoản đã được mã hoá thành đối tượng công nợ!", "The account details have been encode into the object of liabilities!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        myUMessager.mWarning(Ngonngu("Tài khoản không chuyển đổi được!", "Account can not convert!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    Me.Cursor = Cursors.Default
                Else
                    If TK.tk_id = TKCNKH_ID Or TK.tk_id = TKCNPT_ID Then ExecSQLNonQuery(String.Format("DELETE from SoDuKhachHang  where SoDuKhachHang.MaSo in (select SoDuKhachHang.MaSo from SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{0}%')", TK.sohieu))
                    If TK.loai < 3 Then
                        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '{1}%'", _
                                            (IIf(TK.tk_id = TKCNKH_ID, "0", ConvertToStrSafe(TKCNKH_ID))), _
                                            TK.sohieu))
                    End If
                    If TK.loai > 2 Then
                        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '{1}%'", _
                                            (IIf(TK.tk_id = TKCNPT_ID, "0", ConvertToStrSafe(TKCNPT_ID))), _
                                            TK.sohieu))
                    End If
                End If
            End If
        End If
        MemoryHelper.ReleaseMemory()
    End Sub

    'cong no
    Private Sub functionCongNo(ByVal Index As Integer)
        Try

            Select Case Index
                Case 0
                    frmPhanLoaiVT.pl1 = "2"
                    frmPhanLoaiVT.ShowDialog()
                    frmPhanLoaiVT.pl1 = "0"
                    Exit Select
                Case 1
                    FrmKhachHang.ShowDialog()
                    Exit Select
                Case 2
                    FrmCantrucongno.ShowDialog()
                    Exit Select
                Case 3
                    FrmNguyente.ShowDialog()
                    Exit Select
                Case 5
                    If KtraMKAdmin() Then
                        FrmLS.ShowDialog()
                    End If
                    Exit Select
                Case 6
                    If KtraMKAdmin() Then DatTKCN()
                    Exit Select
                Case 7
                    Exit Select
                Case 8
                    If ChoDieuChinhDauKy() Then
                        If pCongNoHD = 0 Then
                            FKHDauKy.ShowDialog()
                        Else
                            FKHDauKy2.ShowDialog()
                        End If
                    End If
                    Exit Select
                Case 9
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSoCongNo.ShowDialog()
                Case 10, 11, 12, 13
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtu.loai1.Tag = "1"
                        If Index = 10 Then
                            FrmChungtu.loaino.Tag = "0"
                        ElseIf Index = 11 Then
                            FrmChungtu.loaino.Tag = "1"
                        ElseIf Index = 12 Then
                            FrmChungtu.loaino.Tag = "3"
                        ElseIf Index = 13 Then
                            FrmChungtu.loaino.Tag = "2"
                        End If
                        FrmChungtu.initOption = 0
                        FrmChungtu.ShowDialog()
                        FrmChungtu.loai1.Tag = "0"
                        FrmChungtu.loaino.Tag = "0"
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                    Exit Select
            End Select

            HienThongBao("", 1)
            Me.Cursor = Cursors.Default
            MemoryHelper.ReleaseMemory()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub myListview_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView_CongNo.MouseDown
        Me.Cursor = Cursors.WaitCursor
        Try
            If (e.Button = MouseButtons.Left) AndAlso (e.Clicks = 1) Then
                Dim htInfo As ListViewHitTestInfo = ListView_CongNo.HitTest(e.X, e.Y)
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
                    Case "tag_CongNoDauKy"
                        functionCongNo(8)
                    Case "tag_ThuNo"
                        functionCongNo(10)
                    Case "tag_TraNo"
                        functionCongNo(11)
                    Case "tag_BaoCaoCongNo"
                        functionCongNo(9)
                    Case "tag_PhanLoaiKhachHang"
                        functionCongNo(0)
                    Case "tag_DSKH"
                        functionCongNo(1)
                    Case "tag_TKCongNo"
                        functionCongNo(6)
                    Case "tag_LaiSuatCN"
                        functionCongNo(5)
                    Case "tag_NgoaiTeVaTyGia"
                        functionCongNo(3)
                End Select
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
