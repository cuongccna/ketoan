Public Class uChiPhiTongHop
    'chi phi tong hop
    Private Sub functionChiPhiTongHop(ByVal Index As Integer)
        Try
            Cursor = Cursors.WaitCursor
            Select Case Index
                Case 0, 1
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtu.Nut.Tag = IIf(Index = 0, "1", "2")
                        If Index = 0 Then
                            FrmDsCT.tracu = True
                        Else
                            FrmChungtu.CmdDanhSach(0).Visible = False
                            FrmChungtu.CmdDanhSach(1).Visible = True
                        End If
                        'FrmChungtu.initOption = 0
                        FrmChungtu.ShowDialog()
                        If Index = 0 Then
                            FrmDsCT.tracu = False
                        Else
                            FrmChungtu.CmdDanhSach(0).Visible = True
                            FrmChungtu.CmdDanhSach(1).Visible = False
                        End If
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                    Exit Select
                Case 2, 5, 6, 7
                    If ChoNhapTiep() And LicenseACTax() Then
                        If Index = 2 Then
                            'Chi phi hoạt động kinh doanh
                            FrmChungtu.loai1.Tag = 2
                        ElseIf Index = 5 Then
                            'Thuế, phí và lệ phí
                            FrmChungtu.loai1.Tag = 3
                        ElseIf Index = 6 Then
                            'Ngân hàng
                            FrmChungtu.loai1.Tag = 4
                        Else
                            'Chi phí khác
                            FrmChungtu.loai1.Tag = 5
                        End If

                        FrmChungtu.initOption = 0
                        FrmChungtu.ShowDialog()
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                    Exit Select
                Case 3
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSochiphi.ShowDialog()
                    Exit Select
                Case 4

                Case 8
                    If ChoNhapTiep() And LicenseACTax() Then
                        FrmChungtutonghop.initOption = 0
                        FrmChungtutonghop.ShowDialog()
                    Else
                        myUMessager.mError(Ngonngu("Liên hệ:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "Để được hỗ trợ sử dụng, chân thành cảm ơn!", "Contact:" & vbNewLine & "ĐT: 0987 939 605." & vbNewLine & "Email: cuong.vhcc@gmail.com - cskh.phanmemketoan@gmail.com" & vbNewLine & "For support use, thanks!"), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    
                    Exit Select
                Case 12
                    TinhLaiGiaNgoaiTePublic()
                    Exit Select
            End Select
            HienThongBao("...", 1)
            MemoryHelper.ReleaseMemory()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub myListview_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView_Chiphitonghop.MouseDown
        Me.Cursor = Cursors.WaitCursor
        Try
            If (e.Button = MouseButtons.Left) AndAlso (e.Clicks = 1) Then
                Dim htInfo As ListViewHitTestInfo = ListView_Chiphitonghop.HitTest(e.X, e.Y)
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
                    Case "tag_NhapChiPhiTongHop"
                        functionChiPhiTongHop(2)
                    Case "tag_TimPhieuThuChi"
                        functionChiPhiTongHop(1)
                    Case "tag_TinhGiaXuatNgoaiTe"
                        functionChiPhiTongHop(12)
                    Case "tag_NhapChungTuTongHop"
                        functionChiPhiTongHop(8)
                    Case "tag_SoChiPhi"
                        functionChiPhiTongHop(3)
                End Select
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
