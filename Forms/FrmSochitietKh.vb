Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmSochitietKh
    Private _taikhoan As ClsTaikhoan = Nothing
    Private tdau, tcuoi As Integer
    Private masokh As String = String.Empty
    Property taikhoan() As ClsTaikhoan
        Get
            If _taikhoan Is Nothing Then
                _taikhoan = New ClsTaikhoan()
            End If
            Return _taikhoan
        End Get
        Set(ByVal Value As ClsTaikhoan)
            _taikhoan = Value
        End Set
    End Property
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        ClearGrid(Grd, Grd.Rows)
        If Grd.Rows < 33 Then Grd.Rows = 33
        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(GetSelectValue("SELECT MaTaiKhoan AS F1 FROM SoDuKhachHang WHERE MaKhachHang=" & masokh)))
        SoChitietCN(taikhoan, ConvertToDblSafe(masokh), tdau, tcuoi)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau1"></param>
    ''' <param name="tcuoi1"></param>
    ''' <param name="MSKH"></param>
    ''' <remarks></remarks>
    Public Sub Hienthi(ByRef tdau1 As Integer, ByRef tcuoi1 As Integer, ByRef MSKH As String)
        tdau = tdau1
        tcuoi = tcuoi1
        masokh = MSKH
        Me.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSochitietKh_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Then Me.Hide()
    End Sub


    Private Sub Khoi_tao()
        ColumnSetUp(Grd, 0, 350, 2)
        ColumnSetUp(Grd, 1, 1190, 0)
        ColumnSetUp(Grd, 2, 830, 4)
        ColumnSetUp(Grd, 3, 3110, 0)
        ColumnSetUp(Grd, 4, 710, 2)
        ColumnSetUp(Grd, 5, 1430, 4)
        ColumnSetUp(Grd, 6, 1430, 4)
        ColumnSetUp(Grd, 7, 1430, 4)
        ColumnSetUp(Grd, 8, 1520, 4)
        Grd.Cols = 9
    End Sub
    Private Sub FrmSochitietKh_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(Grd, 0, 350, 2)
            ColumnSetUp(Grd, 1, 1190, 0)
            ColumnSetUp(Grd, 2, 830, 4)
            ColumnSetUp(Grd, 3, 3110, 0)
            ColumnSetUp(Grd, 4, 710, 2)
            ColumnSetUp(Grd, 5, 1430, 4)
            ColumnSetUp(Grd, 6, 1430, 4)
            ColumnSetUp(Grd, 7, 1430, 4)
            ColumnSetUp(Grd, 8, 1520, 4)
            Grd.Cols = 9
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="mcn"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub SoChitietCN(ByRef taikhoan As ClsTaikhoan, ByRef mcn As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim dknt, dkn, dkc As Double
        Dim sqlw As String = String.Empty
        Dim cn As New clsKhachHang
        Dim i As Integer
        Dim psco, psno, sodu As Double
        cn.InitKhachHangMaSo(mcn)
        If tcuoi > 0 Then
            cn.SoDuKH(ThangTruoc(tdau), dkn, dkc, dknt, IIf(taikhoan.tkcon = 0, taikhoan.maso, 0), IIf(taikhoan.tkcon > 0, taikhoan.sohieu, String.Empty))
            sqlw = WThang("ThangCT", tdau, tcuoi)
        End If
        Dim sql As String = "((HethongTK_2.SoHieu LIKE '" & taikhoan.sohieu & "%') Or (HethongTK_3.SoHieu LIKE '" & taikhoan.sohieu & "%')) AND (MaKH=" & ConvertToStrSafe(mcn) & " OR MaKHC=" & ConvertToStrSafe(mcn) & ")"
        Dim rs As DataTable
        If cn.MaNT = 0 Then
            Dim QChitiet As String = String.Format("SELECT DISTINCT ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai, sum(ChungTu.SoPS) as sops, ChungTu.GhiChu, HeThongTK.SoHieu as sohieutk, HeThongTK_1.SoHieu as sohieutk1, ChungTu.MaTKNo, ChungTu.MaTKCo, HethongTK_2.SoHieu As SHNo, HethongTK_3.SoHieu As SHCo,chungtu.makh,chungtu.makhc" & " FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo" & " WHERE (SoPS<>0 OR SoPS2No<>0 OR SoPS2Co<>0) AND (" & sqlw & " And (" & sql & ")) AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) group by ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai, ChungTu.GhiChu, HeThongTK.SoHieu, HeThongTK_1.SoHieu, ChungTu.MaTKNo, ChungTu.MaTKCo, HethongTK_2.SoHieu, HethongTK_3.SoHieu,chungtu.makh,chungtu.makhc ORDER BY ChungTu.ngayct")
            i = GetRowNumber(QChitiet)
            If i = 0 Then GoTo KhongIn
            rs = ExecSQLReturnDT(QChitiet)
            ClearGrid(Grd, Grd.Rows)
            Khoi_tao()
            For i = 0 To rs.Rows.Count - 1
                Grd.AddItem(String.Format("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}", Chr(9), " "))
            Next
            If rs.Rows.Count > 0 Then
                Grd.Rows = rs.Rows.Count
                i = 1
                For Each rsItem As DataRow In rs.Rows
                    psno = 0
                    psco = 0
                    With Grd
                        .Row = (i - 1)
                        .Col = 0
                        .CtlText = ConvertToStrSafe(i)
                        .Col = 1
                        .CtlText = ConvertToStrSafe(rsItem("SoHieu"))
                        .Col = 2
                        .CtlText = Format(CDate(rsItem("NgayCT")), Mask_DB)
                        .Col = 3
                        .CtlText = ConvertToStrSafe(rsItem("DienGiai"))
                        .Col = 4
                        If ConvertToDblSafe(rsItem("MaTkNo")) <> 0 And ConvertToDblSafe(rsItem("MaTkCo")) <> 0 Then
                            If rsItem("shco").ToString Like taikhoan.sohieu & "*" Then
                                If rsItem("sohieutk") <> "" Then
                                    .CtlText = ConvertToStrSafe(rsItem("sohieutk"))
                                End If
                            Else
                                If ConvertToStrSafe(rsItem("sohieutk1")) <> "" Then
                                    .CtlText = ConvertToStrSafe(rsItem("sohieutk1"))
                                End If
                            End If
                        Else
                            If ConvertToStrSafe(rsItem("GhiChu")) <> "" Then
                                .CtlText = ConvertToStrSafe(rsItem("GhiChu"))
                            End If
                        End If
                        .Col = 5
                        If ConvertToDblSafe(rsItem("MaTkCo")) > 0 Then
                            If ConvertToDblSafe(rsItem("shno")) <> ConvertToDblSafe(rsItem("shco")) Then
                                If rsItem("shno").ToString Like taikhoan.sohieu & "*" Then
                                    psno = ConvertToDblSafe(rsItem("sops"))
                                    If psno <> 0 Then .CtlText = Format(psno, Mask_0)
                                End If
                            Else
                                If ConvertToDblSafe(rsItem("makh")) = cn.MaSo Then
                                    psno = ConvertToDblSafe(rsItem("sops"))
                                    If psno <> 0 Then .CtlText = Format(psno, Mask_0)
                                End If
                            End If
                        Else
                            If rsItem("shno").ToString Like taikhoan.sohieu & "*" Then
                                psno = ConvertToDblSafe(rsItem("sops"))
                                If psno <> 0 Then .CtlText = Format(psno, Mask_0)
                            End If
                        End If
                        .Col = 6
                        If ConvertToDblSafe(rsItem("MaTkNo")) > 0 Then
                            If ConvertToDblSafe(rsItem("shno")) <> ConvertToDblSafe(rsItem("shco")) Then
                                If rsItem("shco").ToString Like (taikhoan.sohieu & "*") Then
                                    psco = ConvertToDblSafe(rsItem("sops"))
                                    If psco <> 0 Then .CtlText = Format(psco, Mask_0)
                                End If
                            Else
                                If ConvertToDblSafe(rsItem("MaKHC")) = cn.MaSo Then
                                    psco = ConvertToDblSafe(rsItem("sops"))
                                    If psco <> 0 Then .CtlText = Format(psco, Mask_0)
                                End If
                            End If
                        Else
                            If rsItem("shco").ToString Like taikhoan.sohieu & "*" Then
                                psco = ConvertToDblSafe(rsItem("sops"))
                                If psco <> 0 Then .CtlText = Format(psco, Mask_0)
                            End If
                        End If
                        'col=7 và col=8
                        If ConvertToDblSafe(rsItem("MaTkNo")) > 0 And ConvertToDblSafe(rsItem("MaTkCo")) > 0 Then
                            If i = 1 Then
                                sodu = dkn + psno - psco
                            Else
                                sodu = sodu + psno - psco
                            End If
                        Else
                            If i = 1 Then
                                If ConvertToDblSafe(rsItem("MaTkNo")) > 0 Then
                                    sodu = dkn + psno
                                Else
                                    sodu = dkn - psco
                                End If
                            Else
                                If ConvertToDblSafe(rsItem("MaTkNo")) > 0 Then
                                    sodu += psno
                                Else
                                    sodu -= psco
                                End If
                            End If
                        End If
                        If sodu > 0 Then
                            .Col = 7 : If sodu <> 0 Then .CtlText = Format(sodu, Mask_0)
                        Else
                            .Col = 8 : If sodu <> 0 Then .CtlText = Format(Math.Abs(sodu), Mask_0)
                        End If
                    End With
                    i += 1
                Next
            End If
        End If
        Me.Text = String.Format(Ngonngu("Sổ chi tiết công nợ của khách hàng có số hiệu:", "Debt ledger of customer code:") + " {0}", cn.SoHieu)
        If Grd.Rows < 33 Then Grd.Rows = 33
        Exit Sub
KhongIn:
        Me.Close()
        MessageBox.Show(Ngonngu("Không phát sinh", "Not arising"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.DoubleClick
        If MessageBox.Show(Ngonngu("Sửa chứng từ?", "Edit voucher?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Grd.Col = 1 : FrmChungtu.Suatonkho(Grd.CtlText)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grd.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(Grd, Grd.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSochitietKh_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
