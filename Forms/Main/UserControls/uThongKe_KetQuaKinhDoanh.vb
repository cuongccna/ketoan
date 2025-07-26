Imports UNET.DataAdapter
Imports UNET.Utilities
Imports UNET.Utility

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections
Imports System.Threading

Public Class uThongKe_KetQuaKinhDoanh

    Dim tientrinh As Thread

    '' <summary>
    '' BANG DOI CHIEU CONG NO KHACH HANG
    '' </summary>
    '' <param name="tdau"></param>
    '' <param name="tcuoi"></param>
    '' <param name="mpl"></param>
    '' <remarks></remarks>
    Public Sub BangCDCno()
        Try

            Dim tdau As Integer = 1
            Dim tcuoi As Integer = 12
            Dim mpl As Integer = 0

            Me.LinkLabel_lammoi.Visible = False
            Me.Label_ThongBaoDuLieu.Text = "Đang tải dữ liệu ..."

            Dim st As String = String.Empty
            Dim sqlc2 As New StringBuilder
            Dim sqln2 As New StringBuilder
            Dim sqlc As New StringBuilder
            Dim sqln As New StringBuilder
            Dim sqlcx2 As New StringBuilder
            Dim sqlnx2 As New StringBuilder
            Dim sqlcx As New StringBuilder
            Dim sqlnx As New StringBuilder
            For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
                If sqln.Length = 0 Then
                    sqln.Append(String.Format("SoDuKhachHang.No_{0}", i))
                Else
                    sqln.Append(String.Format(" + SoDuKhachHang.No_{0}", i))
                End If
                If sqlc.Length = 0 Then
                    sqlc.Append(String.Format("SoDuKhachHang.Co_{0}", i))
                Else
                    sqlc.Append(String.Format(" + SoDuKhachHang.Co_{0}", i))
                End If

                If sqln2.Length = 0 Then
                    sqln2.Append(String.Format("SoDuKhachHang.No_{0}_NT", i))
                Else
                    sqln2.Append(String.Format(" + SoDuKhachHang.No_{0}_NT", i))
                End If
                If sqlc2.Length = 0 Then
                    sqlc2.Append(String.Format("SoDuKhachHang.Co_{0}_NT", i))
                Else
                    sqlc2.Append(String.Format(" + SoDuKhachHang.Co_{0}_NT", i))
                End If
            Next
            For i As Integer = 1 To CThangDB2(tcuoi)
                If sqlnx.Length = 0 Then
                    sqlnx.Append(String.Format("SoDuKhachHang.No_{0}", i))
                Else
                    sqlnx.Append(String.Format(" + SoDuKhachHang.No_{0}", i))
                End If
                If sqlcx.Length = 0 Then
                    sqlcx.Append(String.Format("SoDuKhachHang.Co_{0}", i))
                Else
                    sqlcx.Append(String.Format(" + SoDuKhachHang.Co_{0}", i))
                End If

                If sqlnx2.Length = 0 Then
                    sqlnx2.Append(String.Format("SoDuKhachHang.No_{0}_NT", i))
                Else
                    sqlnx2.Append(String.Format(" + SoDuKhachHang.No_{0}_NT", i))
                End If
                If sqlcx2.Length = 0 Then
                    sqlcx2.Append(String.Format("SoDuKhachHang.Co_{0}_NT", i))
                Else
                    sqlcx2.Append(String.Format(" + SoDuKhachHang.Co_{0}_NT", i))
                End If
            Next
            st = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
            'Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai,KyHieu, SoDuKhachHang.DuNo_{0} AS DkNo, SoDuKhachHang.DuCo_{0} AS DkCo, SoDuKhachHang.DuNT_{0} AS DkNT, ({1}) AS PsNo, ({2}) AS PsNo2, ({3}) AS PsCo, ({4}) AS PsCo2, ({5}) AS PsNoX, ({6}) AS PsNoX2, ({7}) AS PsCoX, ({8}) AS PsCoX2, SoDuKhachHang.DuNo_{9} AS CkNo, SoDuKhachHang.DuCo_{9} AS CkCo, SoDuKhachHang.DuNT_{9} AS CkNT,PhanLoaiKhachHang.PLCha,HethongTK.SoHieu AS SHTK,HethongTK.Ten AS TenTK FROM (((KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang) LEFT JOIN NguyenTe ON KhachHang.MaNT=NguyenTe.MaSo) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo  WHERE (SoDuKhachHang.DuNo_{0}<>0 OR SoDuKhachHang.DuCo_{0}<>0 OR ({5}) <>0 OR ({7}) <>0){10} AND LEFT(KhachHang.SoHieu,1)<>'#' ORDER BY PhanLoaiKhachHang.Sohieu,KhachHang.SoHieu", st, sqln, sqln2, sqlc, sqlc2, sqlnx, sqlnx2, sqlcx, sqlcx2, ConvertToStrSafe(CThangDB2(tcuoi)), (IIf(mpl > 0, " AND MaPhanLoai=" & mpl, String.Empty)))
            Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai,KyHieu, SoDuKhachHang.DuNo_{0} AS DkNo, SoDuKhachHang.DuCo_{0} AS DkCo, SoDuKhachHang.DuNT_{0} AS DkNT, ({1}) AS PsNo, ({2}) AS PsNo2, ({3}) AS PsCo, ({4}) AS PsCo2, ({5}) AS PsNoX, ({6}) AS PsNoX2, ({7}) AS PsCoX, ({8}) AS PsCoX2, SoDuKhachHang.DuNo_{9} AS CkNo, SoDuKhachHang.DuCo_{9} AS CkCo, SoDuKhachHang.DuNT_{9} AS CkNT,PhanLoaiKhachHang.PLCha,HethongTK.SoHieu AS SHTK,HethongTK.Ten AS TenTK FROM (((KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang) LEFT JOIN NguyenTe ON KhachHang.MaNT=NguyenTe.MaSo) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo  WHERE (SoDuKhachHang.DuNo_{0}<>0 OR SoDuKhachHang.DuCo_{0}<>0 OR ({5}) <>0 OR ({7}) <>0){10} AND LEFT(KhachHang.SoHieu,1)<>'#' ", st, sqln, sqln2, sqlc, sqlc2, sqlnx, sqlnx2, sqlcx, sqlcx2, ConvertToStrSafe(CThangDB2(tcuoi)), (IIf(mpl > 0, " AND MaPhanLoai=" & mpl, String.Empty)))
            Dim QSoCai As String = String.Format("SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo", QChitiet)
            Dim QTongHopCT As String = String.Format("SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM ({0}) AS QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo", QSoCai)

            'thuc hien hien thi du lieu len man hinh
            Dim rs As DataTable
            rs = ExecSQLReturnDT(QTongHopCT)
            ' .....
            ListView_KetQuaKinhDoanh.Items.Clear()
            Me.ListView_KetQuaKinhDoanh.Columns.Clear()
            Me.ListView_KetQuaKinhDoanh.Groups.Clear()
            If rs.Rows.Count > 0 Then

                Me.Label_ThongBaoDuLieu.Visible = False
                Me.ListView_KetQuaKinhDoanh.Visible = True

                Dim l As New ArraySegment(Of ListViewItem)
                Dim mylistView As New ListViewItem()
                ' Set the initial sorting type for the ListView.
                Me.ListView_KetQuaKinhDoanh.Sorting = SortOrder.None
                ' Disable automatic sorting to enable manual sorting.
                Me.ListView_KetQuaKinhDoanh.View = View.Details
                ' Add columns and set their text.
                Me.ListView_KetQuaKinhDoanh.Columns.Add(New ColumnHeader)
                Me.ListView_KetQuaKinhDoanh.Columns(0).Text = Ngonngu("Khách hàng", "Descript")
                Me.ListView_KetQuaKinhDoanh.Columns(0).Width = 190
                Me.ListView_KetQuaKinhDoanh.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.None)
                Me.ListView_KetQuaKinhDoanh.Columns.Add(New ColumnHeader)
                Me.ListView_KetQuaKinhDoanh.Columns(1).Text = "Dư nợ"
                Me.ListView_KetQuaKinhDoanh.Columns(1).Width = 85
                Me.ListView_KetQuaKinhDoanh.Columns(1).TextAlign = HorizontalAlignment.Right
                Me.ListView_KetQuaKinhDoanh.Columns(1).AutoResize(ColumnHeaderAutoResizeStyle.None)
                Me.ListView_KetQuaKinhDoanh.Columns.Add(New ColumnHeader)
                Me.ListView_KetQuaKinhDoanh.Columns(2).Text = "Dư có"
                Me.ListView_KetQuaKinhDoanh.Columns(2).Width = 85
                Me.ListView_KetQuaKinhDoanh.Columns(2).TextAlign = HorizontalAlignment.Right
                Me.ListView_KetQuaKinhDoanh.Columns(2).AutoResize(ColumnHeaderAutoResizeStyle.None)

                Dim rsIndexLV As Integer = 0
                While rsIndexLV < rs.Rows.Count
                    Dim rsItem As DataRow = rs.Rows(rsIndexLV)
                    'them group de gom nhom tren listview
                    ' tham so 1 : key
                    ' tham so 2 : headertext
                    ThemGroup(rsItem("SHPL").ToString(), rsItem("TenPhanLoai").ToString())
                    ' het them group                    
                    Me.ListView_KetQuaKinhDoanh.Items.Add( _
                        New ListViewItem(New String() {rsItem("Ten").ToString(), Format(rsItem("CkNo"), Mask_0), Format(rsItem("CkCo"), Mask_0)}, _
                                         -1, _
                                         Color.Black, _
                                         Color.Empty, _
                                         New Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))).Group = Me.ListView_KetQuaKinhDoanh.Groups(rsItem("SHPL").ToString())
                    rsIndexLV = rsIndexLV + 1
                    Thread.Sleep(50)
                End While
                Me.LinkLabel_lammoi.Visible = True
            Else
                Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
                Me.Label_ThongBaoDuLieu.Visible = True
                Me.LinkLabel_lammoi.Visible = True
                Me.ListView_KetQuaKinhDoanh.Visible = False
            End If
        Catch ex As Exception
            Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
            Me.Label_ThongBaoDuLieu.Visible = True
            Me.LinkLabel_lammoi.Visible = True
            Me.ListView_KetQuaKinhDoanh.Visible = False
            Throw New Exception(ex.Message)
        End Try

    End Sub

    ' Them goup moi
    Private Sub ThemGroup(ByVal key As String, ByVal headerText As String)
        Try
            Dim ton_tai As Boolean = False
            For i As Integer = 0 To Me.ListView_KetQuaKinhDoanh.Groups.Count - 1
                If Me.ListView_KetQuaKinhDoanh.Groups(i).Name = key Then
                    ' ton tai group nay
                    ton_tai = True
                End If
            Next
            ' neu khong ton tai group nay thi them moi
            If Not ton_tai Then
                Me.ListView_KetQuaKinhDoanh.Groups.Add( _
                                        New ListViewGroup(key, headerText))
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Thủ tục in lãi lỗ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InKqkd_thongke(ByVal tdau As Integer, ByVal tcuoi As Integer, ByVal nn As Integer, Optional ByVal xem As Integer = 1)
        ExecSQLNonQuery("UPDATE KQKD SET KyNay=0, KyTruoc=0")
        'Kỳ này
        Dim sql As String = String.Format("SELECT DISTINCT KQKD.Ma, Sum(CASE WHEN {0} THEN ChungTu.SoPS ELSE 0 END) AS Kqua2  FROM ({1}) INNER JOIN KQKD ON HethongTK.SoHieu LIKE KQKD.SHTKNo+'%' AND TK.SoHieu LIKE KQKD.SHTKCo+'%'  WHERE {2} AND KQKD.SHTKNo<>'0' AND KQKD.SHTKCo<>'0' GROUP BY KQKD.Ma", WThang("ThangCT", tdau, 0), ChungTu2TKNC(0), WThang("ThangCT", 0, tcuoi))
        sql = String.Format("{0} UNION SELECT DISTINCT KQKD.Ma, Sum(CASE WHEN {1} THEN ChungTu.SoPS ELSE 0 END) AS Kqua2 FROM ({2}) INNER JOIN KQKD ON HethongTK.SoHieu LIKE KQKD.SHTKCo+'%' WHERE (MaLoai<>3 AND MaLoai<>1) AND {3} AND (CONVERT(bigint,KQKD.SHTKNo) = 0) AND KQKD.SHTKCo<>'0' GROUP BY KQKD.Ma", sql, WThang("ThangCT", tdau, 0), ChungTu2TKNC(1), WThang("ThangCT", 0, tcuoi))
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            ExecSQLNonQuery(String.Format("UPDATE KQKD SET KyNay = {0} WHERE Ma={1}", CStr(IIf(IsDBNull(rsItem("kqua2")), 0, rsItem("kqua2"))), rsItem("ma")))
            ''rs.MoveNext()
        Loop

        'Kỳ trước
        Dim kytruoc As New StringBuilder
        ExecSQLNonQuery("UPDATE KQKD SET KyTruoc=0")
        If tdau = 1 Then
            kytruoc = New StringBuilder(String.Format("TK.PSCLK{0}", (pNamTC - 1)))
        Else
            kytruoc = New StringBuilder("0")
            For i As Integer = 1 To tdau - 1
                kytruoc.Append(" + co_" & i)
            Next
        End If
        sql = String.Format("SELECT DISTINCT KQKD.Ma, Sum({0}) AS Kqua1  FROM KQKD INNER JOIN HethongTk TK ON TK.SoHieu = KQKD.SHTKCo  WHERE KQKD.SHTKNo<>'0' AND KQKD.SHTKCo<>'0' AND KQKD.SHTKCo<>'911' AND KQKD.SHTKCo<>'511' GROUP BY KQKD.Ma", kytruoc)
        sql = String.Format("{0} UNION SELECT DISTINCT KQKD.Ma, Sum({1}) AS Kqua1  FROM KQKD INNER JOIN HethongTk TK ON TK.SoHieu = KQKD.SHTKNo  WHERE KQKD.SHTKNo<>'0' AND KQKD.SHTKCo<>'0' AND KQKD.SHTKNo<>'911' AND KQKD.SHTKNo<>'511' GROUP BY KQKD.Ma", sql, kytruoc)
        sql = String.Format("{0} UNION SELECT DISTINCT KQKD.Ma, Sum({1}) AS Kqua1  FROM HethongTk TK INNER JOIN KQKD ON TK.SoHieu LIKE KQKD.SHTKCo+'%' WHERE TK.cap=1 AND KQKD.SHTKNo = '0' AND KQKD.SHTKCo<>'0' GROUP BY KQKD.Ma", sql, kytruoc)
        rs = ExecSQLReturnDT(sql)
        rsIndex = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            ExecSQLNonQuery(String.Format("UPDATE KQKD SET KyTruoc={0} WHERE Ma={1}", CStr(IIf(IsDBNull(rsItem("kqua1")), 0, rsItem("kqua1"))), rsItem("ma")))
            ''rs.MoveNext()
        Loop
        ' Cộng dồn vào nhóm
        rs = ExecSQLReturnDT("SELECT KyTruoc,KyNay,MaSoCha FROM KQKD WHERE SHTKNo<>'0' OR SHTKCo<>'0' ORDER BY case when Masocha>0 then MaSoCha else -MaSoCha end")
        rsIndex = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            If rsItem("masocha") > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE KQKD SET KyTruoc=KyTruoc+{0},KyNay=KyNay+{1} WHERE MaSo={2}", CStr(rsItem("kytruoc")), CStr(rsItem("KyNay")), rsItem("masocha")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE KQKD SET KyTruoc=KyTruoc-{0},KyNay=KyNay-{1} WHERE MaSo={2}", CStr(rsItem("kytruoc")), CStr(rsItem("KyNay")), -rsItem("masocha")))
            End If
            ''rs.MoveNext()
        Loop
        rs = ExecSQLReturnDT("SELECT KyTruoc,KyNay,MaSoCha FROM KQKD WHERE SHTKNo='0' AND SHTKCo='0' AND (TongHop=1) ORDER BY case when Masocha>0 then MaSoCha else -MaSoCha end")
        rsIndex = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            If rsItem("masocha") > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE KQKD SET KyTruoc=KyTruoc+{0},KyNay=KyNay+{1} WHERE MaSo={2}", CStr(rsItem("KyTruoc")), CStr(rsItem("KyNay")), rsItem("masocha")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE KQKD SET KyTruoc=KyTruoc-{0},KyNay=KyNay-{1} WHERE MaSo={2}", CStr(rsItem("KyTruoc")), CStr(rsItem("KyNay")), -rsItem("masocha")))
            End If
            rs = ExecSQLReturnDT("SELECT KyTruoc,KyNay,MaSoCha FROM KQKD WHERE SHTKNo='0' AND SHTKCo='0' AND (TongHop=1) ORDER BY case when Masocha>0 then MaSoCha else -MaSoCha end")
        Loop
        ''rs.Close()
        Dim QKqkd As String = String.Format("SELECT MaSo, min(Ten{0}) AS FirstOfTen, min(TongHop) AS FirstOfTongHop, Sum(KyTruoc) AS SumOfKyTruoc, Sum(KyNay) AS SumOfKyNay,min(Cap) AS C FROM KQKD GROUP BY MaSo", (IIf(pNN > 0, "E", String.Empty)))

        'thuc hien hien thi du lieu len man hinh
        rs = ExecSQLReturnDT(QKqkd)
        ' .....
        ListView_KetQuaKinhDoanh.Items.Clear()
        Me.ListView_KetQuaKinhDoanh.Columns.Clear()
        If rs.Rows.Count > 0 Then
            Dim l As New ArraySegment(Of ListViewItem)
            Dim mylistView As New ListViewItem()
            ' Set the initial sorting type for the ListView.
            Me.ListView_KetQuaKinhDoanh.Sorting = SortOrder.None
            ' Disable automatic sorting to enable manual sorting.
            Me.ListView_KetQuaKinhDoanh.View = View.Details
            ' Add columns and set their text.
            Me.ListView_KetQuaKinhDoanh.Columns.Add(New ColumnHeader)
            Me.ListView_KetQuaKinhDoanh.Columns(0).Text = Ngonngu("Diễn giải", "Descript")
            Me.ListView_KetQuaKinhDoanh.Columns(0).Width = 140
            Me.ListView_KetQuaKinhDoanh.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.None)
            Me.ListView_KetQuaKinhDoanh.Columns.Add(New ColumnHeader)
            Me.ListView_KetQuaKinhDoanh.Columns(1).Text = "MS"
            Me.ListView_KetQuaKinhDoanh.Columns(1).Width = 30
            Me.ListView_KetQuaKinhDoanh.Columns(1).TextAlign = HorizontalAlignment.Center
            Me.ListView_KetQuaKinhDoanh.Columns(1).AutoResize(ColumnHeaderAutoResizeStyle.None)
            Me.ListView_KetQuaKinhDoanh.Columns.Add(New ColumnHeader)
            Me.ListView_KetQuaKinhDoanh.Columns(2).Text = "Tiền"
            Me.ListView_KetQuaKinhDoanh.Columns(2).Width = 85
            Me.ListView_KetQuaKinhDoanh.Columns(2).TextAlign = HorizontalAlignment.Right
            Me.ListView_KetQuaKinhDoanh.Columns(2).AutoResize(ColumnHeaderAutoResizeStyle.None)

            Dim rsIndexLV As Integer = 0
            While rsIndexLV < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndexLV)
                Dim tonghop = CInt(rsItem("FirstOfTongHop"))
                If tonghop = 1 Then
                    Me.ListView_KetQuaKinhDoanh.Items.Add(New ListViewItem(New String() {rsItem("FirstOfTen").ToString(), rsItem("MaSo"), Format(rsItem("SumOfKyNay"), Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte))))
                Else
                    Me.ListView_KetQuaKinhDoanh.Items.Add(New ListViewItem(New String() {rsItem("FirstOfTen").ToString(), rsItem("MaSo"), Format(rsItem("SumOfKyNay"), Mask_0)}, -1, Color.Black, Color.Empty, New Font("Microsoft Sans Serif", 6.0F, FontStyle.Italic, GraphicsUnit.Point, CType(0, System.Byte))))
                End If
                rsIndexLV = rsIndexLV + 1
            End While
        End If

    End Sub
    Private Sub LinkLabel_lammoi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_lammoi.LinkClicked
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.Label_ThongBaoDuLieu.Visible = True
            Me.ListView_KetQuaKinhDoanh.Visible = False

            tientrinh = New Thread(AddressOf BangCDCno)
            tientrinh.Start()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.LinkLabel_lammoi.Visible = True
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub uThongKe_KetQuaKinhDoanh_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            tientrinh.Abort()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub uThongKe_KetQuaKinhDoanh_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.DoubleBuffered = True

            Me.Label_ThongBaoDuLieu.Visible = True
            Me.ListView_KetQuaKinhDoanh.Visible = False

            Control.CheckForIllegalCrossThreadCalls = False
            tientrinh = New Thread(AddressOf BangCDCno)
            tientrinh.Start()            
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.LinkLabel_lammoi.Visible = True
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
