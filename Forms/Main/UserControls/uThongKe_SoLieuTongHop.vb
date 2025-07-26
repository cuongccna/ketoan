Imports UNET.DataAdapter
Imports UNET.Utilities
Imports UNET.Utility

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections

Public Class uThongKe_SoLieuTongHop

    Private Sub LietkeCandoi_ThongKe(ByRef saukc As Boolean, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cap As Integer, ByRef ct As Integer)
        Try
            Dim st As String = String.Empty
            Dim sqlc As New StringBuilder
            Dim sqln As New StringBuilder
            Dim i As Integer
            Dim captk As Integer
            pThangDauKy = 1
            SoDuTKCN2(ThangTruoc(tdau))
            SoDuTKCN2(tcuoi)

            For i = CThangDB2(tdau) To CThangDB2(tcuoi)
                If sqln.Length = 0 Then
                    sqln.Append(String.Format("HethongTk.No_{0}", i))
                Else
                    sqln.Append(String.Format(" + HethongTk.No_{0}", i))
                End If

                If sqlc.Length = 0 Then
                    sqlc.Append(String.Format("HethongTk.Co_{0}", i))
                Else
                    sqlc.Append(String.Format(" + HethongTk.Co_{0}", i))
                End If
            Next
            st = ConvertToStrSafe(CThangDB2(tcuoi))
            Dim sql As String = String.Format("SELECT DISTINCT HeThongTK.Cap,HeThongTK.SoHieu,  HeThongTK.Ten, HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_{0} As DkNo, HeThongTK.DuCo_{1} As DkCo, {2} As PsNo, {3} As PsCo, KC_N, KC_C, {4} As CkNo, {5} As CkCo FROM HeThongTK WHERE ((HeThongTK.MaTC = 0 Or HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) And (HeThongTK.Loai > 0)  AND Cap<={6}{7} order by hethongtk.loai,hethongtk.sohieu", _
                                                      CThangDB2(ThangTruoc(tdau)), _
                                                      ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                                                      sqln, _
                                                      sqlc, _
                                                      (IIf(saukc, String.Format("HeThongTK.DuNo_{0}", st), "HethongTk.DuNo")), _
                                                      (IIf(saukc, String.Format("HeThongTK.DuCo_{0}", st), "HethongTk.DuCo")), _
                                                      ConvertToStrSafe(cap), _
                                                      (IIf(ct = 0, String.Format(" AND (DuNo_{0}<>0 OR DuCo_{0}<>0 OR ({1})<>0 OR ({2})<>0)", _
                                                                       st, _
                                                                       sqln, _
                                                                       sqlc), String.Empty)))
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT HeThongTK.Cap,HeThongTK.SoHieu,  HeThongTK.Ten, HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_{0} As DkNo, HeThongTK.DuCo_{1} As DkCo, {2} As PsNo, {3} As PsCo, KC_N, KC_C, {4} As CkNo, {5} As CkCo FROM HeThongTK WHERE ((HeThongTK.MaTC = 0 Or HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) And (HeThongTK.Loai > 0)  AND Cap<={6}{7} order by hethongtk.loai,hethongtk.sohieu", _
                                                      CThangDB2(ThangTruoc(tdau)), _
                                                      ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                                                      sqln, _
                                                      sqlc, _
                                                      (IIf(saukc, String.Format("HeThongTK.DuNo_{0}", st), "HethongTk.DuNo")), _
                                                      (IIf(saukc, String.Format("HeThongTK.DuCo_{0}", st), "HethongTk.DuCo")), _
                                                      ConvertToStrSafe(cap), _
                                                      (IIf(ct = 0, String.Format(" AND (DuNo_{0}<>0 OR DuCo_{0}<>0 OR ({1})<>0 OR ({2})<>0)", _
                                                                       st, _
                                                                       sqln, _
                                                                       sqlc), String.Empty))))
            ListView_SoLieuTongHop.Items.Clear()
            ListView_SoLieuTongHop.Columns.Clear()
            ListView_SoLieuTongHop.Groups.Clear()
            If rs.Rows.Count > 0 Then
                ' phan chia nhom
                ' 1. nhom tien 
                ListView_SoLieuTongHop.Groups.Add(New ListViewGroup("TIEN", "Tiền mặt / tiền gửi"))
                ' 2, Doanh thu / chi phí
                ListView_SoLieuTongHop.Groups.Add(New ListViewGroup("DT_CP", "Doanh thu / chi phí"))
                ' 3, Phải thu phải trả
                ListView_SoLieuTongHop.Groups.Add(New ListViewGroup("PTU_PTA", "Phải thu / phải trả"))
                ' 4, Tồn kho
                ListView_SoLieuTongHop.Groups.Add(New ListViewGroup("TK", "Tồn kho"))

                ' tien mat tk : 111
                Dim tk_tienmat As Double = 0
                ' tien gui tk : 112
                Dim tk_tiengui As Double = 0
                ' tong tien = tien mat + tien gui
                Dim tong_tien As Double = 0
                ' doanh thu tk : loai 5,7
                Dim doanh_thu As Double = 0
                ' chi phi tk loai 6,8
                Dim chi_phi As Double = 0
                ' loi nhuan truoc thue = doanh thu - chi phi
                'Dim loi_nhuan_truoc_thue As Double = 0
                ' lai rong tam tinh = doanh thu - chi phi
                'Dim lai_rong_tam_tinh As Double = 0
                ' phai thu 
                Dim phai_thu As Double = 0
                ' phai tra
                Dim phai_tra As Double = 0
                ' hang ton kho
                Dim hang_ton_kho As Double = 0
                ' tai khoan loai 5, 7 (doanh thu)
                Dim tk_5 As Double = 0 ' doanh thu
                Dim tk_7 As Double = 0 ' thu nhap khac

                Dim l As New ArraySegment(Of ListViewItem)
                Dim mylistView As New ListViewItem()
                ' Set the initial sorting type for the ListView.
                Me.ListView_SoLieuTongHop.Sorting = SortOrder.None
                ' Disable automatic sorting to enable manual sorting.
                Me.ListView_SoLieuTongHop.View = View.Details
                ' Add columns and set their text.
                Me.ListView_SoLieuTongHop.Columns.Add(New ColumnHeader)
                Me.ListView_SoLieuTongHop.Columns(0).Text = "Diễn giải"
                Me.ListView_SoLieuTongHop.Columns(0).Width = 130
                Me.ListView_SoLieuTongHop.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.None)
                Me.ListView_SoLieuTongHop.Columns.Add(New ColumnHeader)
                Me.ListView_SoLieuTongHop.Columns(1).Text = "Tiền"
                Me.ListView_SoLieuTongHop.Columns(1).Width = 100
                Me.ListView_SoLieuTongHop.Columns(1).TextAlign = HorizontalAlignment.Right
                Me.ListView_SoLieuTongHop.Columns(1).AutoResize(ColumnHeaderAutoResizeStyle.None)

                Dim rsIndex As Integer = 0
                While rsIndex < rs.Rows.Count
                    Dim rsItem As DataRow = rs.Rows(rsIndex)
                    captk = CInt(rsItem("cap"))
                    'If Not rsItem("SoHieu").ToString().StartsWith("L") Then
                    If rsItem("SoHieu").ToString() = ("111") Then
                        If ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString()) > ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString()) Then
                            tk_tienmat = ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString())
                        Else
                            tk_tienmat = ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString())
                        End If
                    ElseIf rsItem("SoHieu").ToString() = ("112") Then
                        If ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString()) > ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString()) Then
                            tk_tiengui = ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString())
                        Else
                            tk_tiengui = ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString())
                        End If

                    ElseIf rsItem("SoHieu").ToString().StartsWith("L") And rsItem("SoHieu").ToString().EndsWith("5") Then
                        If ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString()) > ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString()) Then
                            tk_5 = ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString())
                        Else
                            tk_5 = ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString())
                        End If
                    ElseIf rsItem("SoHieu").ToString().StartsWith("L") And rsItem("SoHieu").ToString().EndsWith("7") Then
                        If ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString()) > ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString()) Then
                            tk_7 = ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString())
                        Else
                            tk_7 = ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString())
                        End If
                    ElseIf (rsItem("SoHieu").ToString().StartsWith("L") And rsItem("SoHieu").ToString().EndsWith("8")) Or (rsItem("SoHieu").ToString().StartsWith("L") And rsItem("SoHieu").ToString().EndsWith("6")) Then
                        If ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString()) > ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString()) Then
                            chi_phi = ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString())
                        Else
                            chi_phi = ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString())
                        End If
                    ElseIf (rsItem("SoHieu").ToString() = ("131") Or rsItem("SoHieu").ToString() = ("138") Or rsItem("SoHieu").ToString() = ("136") Or rsItem("SoHieu").ToString() = ("139")) And rsItem("cap") = 1 Then
                        If ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString()) > ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString()) Then
                            phai_thu = phai_thu + ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString())
                        Else
                            phai_thu = phai_thu + ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString())
                        End If

                    ElseIf rsItem("SoHieu").ToString().StartsWith("L") And rsItem("SoHieu").ToString().EndsWith("3") Then
                        If ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString()) > ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString()) Then
                            phai_tra = ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString())
                        Else
                            phai_tra = ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString())
                        End If

                    ElseIf (rsItem("SoHieu").ToString() = ("151") Or rsItem("SoHieu").ToString() = ("152") Or rsItem("SoHieu").ToString() = ("153") Or rsItem("SoHieu").ToString() = ("154") Or rsItem("SoHieu").ToString() = ("155") Or rsItem("SoHieu").ToString() = ("156") Or rsItem("SoHieu").ToString() = ("157") Or rsItem("SoHieu").ToString() = ("158")) And rsItem("cap") = 1 Then
                        If ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString()) > ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString()) Then
                            hang_ton_kho = hang_ton_kho + ConvertToDblSafe(rs.Rows(rsIndex)("CkNo").ToString())
                        Else
                            hang_ton_kho = hang_ton_kho + ConvertToDblSafe(rs.Rows(rsIndex)("CkCo").ToString())
                        End If

                    End If

                    'End If
                    rsIndex = rsIndex + 1
                End While
                doanh_thu = tk_5 + tk_7
                ' them du lieu vao list view
                'tien mat
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"Tiền mặt", Format(tk_tienmat, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("TIEN")
                ' tien gui
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"Tiền gửi", Format(tk_tiengui, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("TIEN")
                ' tong tien
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"Tổng tiền", Format(tk_tiengui + tk_tienmat, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("TIEN")
                ' doanh thu
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"Doanh thu", Format(tk_5 + tk_7, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("DT_CP")
                ' chi phi
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"Chi phí", Format(chi_phi, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("DT_CP")
                ' loi nhuan truoc thue
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"Lợi nhuận trước thuế", Format(doanh_thu - chi_phi, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("DT_CP")
                ' lai rong tam tinh
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"Lãi ròng tạm tính", Format(doanh_thu - chi_phi, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("DT_CP")
                ' phai thu
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"Phải thu", Format(phai_thu, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("PTU_PTA")
                ' phai tra
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"Phải trả", Format(phai_tra, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("PTU_PTA")
                ' hang ton kho
                Me.ListView_SoLieuTongHop.Items.Add(New ListViewItem(New String() {"hàng tồn kho", Format(hang_ton_kho, Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = ListView_SoLieuTongHop.Groups("TK")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub


    Private Sub LinkLabel_lammoi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_lammoi.LinkClicked
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.LietkeCandoi_ThongKe(True, 1, 12, 6, 0)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub uThongKe_SoLieuTongHop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.LietkeCandoi_ThongKe(True, 1, 12, 6, 0)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
