Imports UNET.DataAdapter
Imports UNET.Utilities
Imports UNET.Utility

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections
Imports System.Threading

Public Class uThongKe_SoDuTaiKhoan

    Dim tientrinh As Thread

    Private Function space(ByVal cap As Integer) As String
        Dim sp = ""
        For j As Integer = 1 To cap
            sp = sp & "    "
        Next
        Return sp
    End Function

    Private Sub LietkeCandoi_ThongKe_1()
        Try
            Me.LinkLabel_lammoi.Visible = False
            Me.Label_ThongBaoDuLieu.Text = "Đang tải dữ liệu ..."

            Dim saukc As Boolean = True
            Dim tdau As Integer = 1
            Dim tcuoi As Integer = 12
            Dim cap As Integer = 6
            Dim ct As Integer = 0

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
            Dim rs As DataTable = ExecSQLReturnDT(sql)
            'String.Format("SELECT DISTINCT HeThongTK.Cap,HeThongTK.SoHieu,  HeThongTK.Ten, HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_{0} As DkNo, HeThongTK.DuCo_{1} As DkCo, {2} As PsNo, {3} As PsCo, KC_N, KC_C, {4} As CkNo, {5} As CkCo FROM HeThongTK WHERE ((HeThongTK.MaTC = 0 Or HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) And (HeThongTK.Loai > 0)  AND Cap<={6}{7} order by hethongtk.loai,hethongtk.sohieu", _
            '                                          CThangDB2(ThangTruoc(tdau)), _
            '                                          ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
            '                                          sqln, _
            '                                          sqlc, _
            '                                          (IIf(saukc, String.Format("HeThongTK.DuNo_{0}", st), "HethongTk.DuNo")), _
            '                                          (IIf(saukc, String.Format("HeThongTK.DuCo_{0}", st), "HethongTk.DuCo")), _
            '                                          ConvertToStrSafe(cap), _
            '                                          (IIf(ct = 0, String.Format(" AND (DuNo_{0}<>0 OR DuCo_{0}<>0 OR ({1})<>0 OR ({2})<>0)", _
            '                                                           st, _
            '                                                           sqln, _
            '                                                           sqlc), String.Empty)))
            ListView_SoDuTaiKhoan.Items.Clear()
            Me.ListView_SoDuTaiKhoan.Columns.Clear()
            If rs.Rows.Count > 0 Then

                Me.Label_ThongBaoDuLieu.Visible = False
                Me.ListView_SoDuTaiKhoan.Visible = True

                Dim l As New ArraySegment(Of ListViewItem)
                Dim mylistView As New ListViewItem()
                ' Set the initial sorting type for the ListView.
                Me.ListView_SoDuTaiKhoan.Sorting = SortOrder.None
                ' Disable automatic sorting to enable manual sorting.
                Me.ListView_SoDuTaiKhoan.View = View.Details
                ' Add columns and set their text.
                Me.ListView_SoDuTaiKhoan.Columns.Add(New ColumnHeader)
                Me.ListView_SoDuTaiKhoan.Columns(0).Text = "Số tài khoản"
                Me.ListView_SoDuTaiKhoan.Columns(0).Width = 140
                Me.ListView_SoDuTaiKhoan.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.None)
                Me.ListView_SoDuTaiKhoan.Columns.Add(New ColumnHeader)
                Me.ListView_SoDuTaiKhoan.Columns(1).Text = "Dư nợ"
                Me.ListView_SoDuTaiKhoan.Columns(1).Width = 100
                Me.ListView_SoDuTaiKhoan.Columns(1).TextAlign = HorizontalAlignment.Right
                Me.ListView_SoDuTaiKhoan.Columns(1).AutoResize(ColumnHeaderAutoResizeStyle.None)
                Me.ListView_SoDuTaiKhoan.Columns.Add(New ColumnHeader)
                Me.ListView_SoDuTaiKhoan.Columns(2).Text = "Dư có"
                Me.ListView_SoDuTaiKhoan.Columns(2).Width = 100
                Me.ListView_SoDuTaiKhoan.Columns(2).TextAlign = HorizontalAlignment.Right
                Me.ListView_SoDuTaiKhoan.Columns(2).AutoResize(ColumnHeaderAutoResizeStyle.None)


                Dim rsIndex As Integer = 0
                While rsIndex < rs.Rows.Count
                    Dim rsItem As DataRow = rs.Rows(rsIndex)
                    captk = CInt(rsItem("cap"))
                    If Not rsItem("SoHieu").ToString().StartsWith("L") Then
                        If rsItem("SoHieu").ToString().StartsWith("1") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Blue, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Blue, Color.Empty, Nothing))
                            End If
                        ElseIf rsItem("SoHieu").ToString().StartsWith("2") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Green, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Green, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("3") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Red, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Red, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("4") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkViolet, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkViolet, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("5") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkRed, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkRed, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("6") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkSeaGreen, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkSeaGreen, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("7") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Cornsilk, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Cornsilk, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("8") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Bisque, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Bisque, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("9") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Aqua, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Aqua, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("10") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkTurquoise, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkTurquoise, Color.Empty, Nothing))
                            End If

                        End If

                    End If
                    rsIndex = rsIndex + 1
                End While
                Me.LinkLabel_lammoi.Visible = True
            Else
                Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
                Me.Label_ThongBaoDuLieu.Visible = True
                Me.LinkLabel_lammoi.Visible = True
                Me.ListView_SoDuTaiKhoan.Visible = False
            End If
        Catch ex As Exception
            Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
            Me.Label_ThongBaoDuLieu.Visible = True
            Me.LinkLabel_lammoi.Visible = True
            Me.ListView_SoDuTaiKhoan.Visible = False
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Function kiemTraTonTaiProc(ByVal name As String) As Boolean
        Try
            Return ExecSQLReturnDT(String.Format("SELECT name FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('{0}')", name)).Rows.Count > 0
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Function taoProc(ByVal name) As Boolean
        Try

            Dim sql = My.Resources.sql.create_SoDuTKCN2_0
            If name = "sp_SoDuTKCN2" Then
                sql = My.Resources.sql.create_SoDuTKCN2
            ElseIf name = "sp_SoDuTKCN2_0" Then
                sql = My.Resources.sql.create_SoDuTKCN2_0
            Else
                sql = My.Resources.sql.create_SoDuTKCN2_12
            End If
            Return ExecSQLNonQuery(sql)
        Catch ex As Exception
            Return True
        End Try
    End Function


    Private Sub LietkeCandoi_ThongKe()
        Try
            Me.LinkLabel_lammoi.Visible = False
            Me.Label_ThongBaoDuLieu.Text = "Đang tải dữ liệu ..."

            Dim captk As Integer = -1
            'kiem tra proc ton tai hay khong
            If Not kiemTraTonTaiProc("dbo.sp_SoDuTKCN2_0") Then
                taoProc("sp_SoDuTKCN2_0")
            End If
            If Not kiemTraTonTaiProc("dbo.sp_SoDuTKCN2_12") Then
                taoProc("sp_SoDuTKCN2_12")
            End If
            If Not kiemTraTonTaiProc("dbo.sp_SoDuTKCN2") Then
                taoProc("sp_SoDuTKCN2")
            End If

            Dim rs As DataTable = ExecSQLReturnDTByStoreProcedure("sp_SoDuTKCN2")

            ListView_SoDuTaiKhoan.Items.Clear()
            Me.ListView_SoDuTaiKhoan.Columns.Clear()
            If rs.Rows.Count > 0 Then

                Me.Label_ThongBaoDuLieu.Visible = False
                Me.ListView_SoDuTaiKhoan.Visible = True

                Dim l As New ArraySegment(Of ListViewItem)
                Dim mylistView As New ListViewItem()
                ' Set the initial sorting type for the ListView.
                Me.ListView_SoDuTaiKhoan.Sorting = SortOrder.None
                ' Disable automatic sorting to enable manual sorting.
                Me.ListView_SoDuTaiKhoan.View = View.Details
                ' Add columns and set their text.
                Me.ListView_SoDuTaiKhoan.Columns.Add(New ColumnHeader)
                Me.ListView_SoDuTaiKhoan.Columns(0).Text = "Số tài khoản"
                Me.ListView_SoDuTaiKhoan.Columns(0).Width = 200
                Me.ListView_SoDuTaiKhoan.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.None)
                Me.ListView_SoDuTaiKhoan.Columns.Add(New ColumnHeader)
                Me.ListView_SoDuTaiKhoan.Columns(1).Text = "Dư nợ"
                Me.ListView_SoDuTaiKhoan.Columns(1).Width = 100
                Me.ListView_SoDuTaiKhoan.Columns(1).TextAlign = HorizontalAlignment.Right
                Me.ListView_SoDuTaiKhoan.Columns(1).AutoResize(ColumnHeaderAutoResizeStyle.None)
                Me.ListView_SoDuTaiKhoan.Columns.Add(New ColumnHeader)
                Me.ListView_SoDuTaiKhoan.Columns(2).Text = "Dư có"
                Me.ListView_SoDuTaiKhoan.Columns(2).Width = 100
                Me.ListView_SoDuTaiKhoan.Columns(2).TextAlign = HorizontalAlignment.Right
                Me.ListView_SoDuTaiKhoan.Columns(2).AutoResize(ColumnHeaderAutoResizeStyle.None)


                Dim rsIndex As Integer = 0
                While rsIndex < rs.Rows.Count
                    Dim rsItem As DataRow = rs.Rows(rsIndex)
                    captk = CInt(rsItem("cap"))
                    If Not rsItem("SoHieu").ToString().StartsWith("L") Then
                        If rsItem("SoHieu").ToString().StartsWith("1") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Blue, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Blue, Color.Empty, Nothing))
                            End If
                        ElseIf rsItem("SoHieu").ToString().StartsWith("2") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Green, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Green, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("3") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Red, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Red, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("4") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkViolet, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkViolet, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("5") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkRed, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkRed, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("6") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkSeaGreen, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkSeaGreen, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("7") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Cornsilk, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Cornsilk, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("8") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Bisque, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Bisque, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("9") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Aqua, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.Aqua, Color.Empty, Nothing))
                            End If

                        ElseIf rsItem("SoHieu").ToString().StartsWith("10") Then
                            If captk = 1 Then
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkTurquoise, Color.Empty, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CType(0, System.Byte))))
                            Else
                                Me.ListView_SoDuTaiKhoan.Items.Add(New ListViewItem(New String() {space(captk) & rsItem("SoHieu").ToString(), Format(rs.Rows(rsIndex)("CkNo"), Mask_0), Format(rs.Rows(rsIndex)("CkCo"), Mask_0)}, -1, Color.DarkTurquoise, Color.Empty, Nothing))
                            End If

                        End If

                    End If
                    rsIndex = rsIndex + 1
                End While
                Me.LinkLabel_lammoi.Visible = True
            Else
                Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
                Me.Label_ThongBaoDuLieu.Visible = True
                Me.LinkLabel_lammoi.Visible = True
                Me.ListView_SoDuTaiKhoan.Visible = False
            End If
        Catch ex As Exception
            Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
            Me.Label_ThongBaoDuLieu.Visible = True
            Me.LinkLabel_lammoi.Visible = True
            Me.ListView_SoDuTaiKhoan.Visible = False
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub uThongKe_SoDuTaiKhoan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            'Me.DoubleBuffered = True

            'Me.Label_ThongBaoDuLieu.Visible = True
            'Me.ListView_SoDuTaiKhoan.Visible = False

            'Control.CheckForIllegalCrossThreadCalls = False
            'tientrinh = New Thread(AddressOf LietkeCandoi_ThongKe_1)
            'tientrinh.Start()

            
            Me.LietkeCandoi_ThongKe_1()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Label_ThongBaoDuLieu.Text = "Lỗi tải dữ liệu !"
            Me.Label_ThongBaoDuLieu.ForeColor = Color.Red
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel_lammoi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_lammoi.LinkClicked
        Me.Cursor = Cursors.WaitCursor
        Try

            'Me.Label_ThongBaoDuLieu.Visible = True
            'Me.ListView_SoDuTaiKhoan.Visible = False

            'Control.CheckForIllegalCrossThreadCalls = False
            'tientrinh = New Thread(AddressOf LietkeCandoi_ThongKe_1)
            'tientrinh.Start()

            Me.LietkeCandoi_ThongKe_1()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
