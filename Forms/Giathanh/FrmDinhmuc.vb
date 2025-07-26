Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmDinhmuc
    Sub Lietke(Optional ByRef XemIn As Integer = 0, Optional ByVal frm As FrmThanhPham = Nothing)
        Dim thangdm, sothanhpham As Integer
        Dim str As String
        Dim SoHieu As String = ""
        Dim i, thang As Integer
        Dim tp(Max1000) As Integer
        Dim dong, cot As Integer
        If frm IsNot Nothing Then
            With frm
                dong = .Grd.Row : cot = .Grd.Col
                .Grd.Row = 0 : .Grd.Col = 1
                i = 1
                While .Grd.Row < .Grd.Rows '.Grd.Items(.Grd.Row).SubItems(.Grd.Col).Text <> ""
                    tp(i) = ConvertToDblSafe(Timten("maso", .Grd.Items(.Grd.Row).SubItems(.Grd.Col).Text, "sohieu", "vattu"))
                    .Grd.Row = i : i += 1
                End While
                .Grd.Row = dong : .Grd.Col = cot
                thang = ConvertToDateSafe(.MedNgay.Text).Month
            End With
        End If
        ExecSQLNonQuery(String.Format("UPDATE DinhMuc SET ThangHL = CASE WHEN (Thang={0}) THEN Thang ELSE 0 END", thang))
        Dim rs As DataTable = ExecSQLReturnDT("SELECT MaTP FROM DinhMuc WHERE ThangHL=0 GROUP BY MaTP")
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1
            thangdm = ConvertToDblSafe(GetSelectValue(String.Format("SELECT  TOP 1 Thang AS F1 FROM DinhMuc WHERE MaNVL>0 AND MaTP={0} AND {1} ORDER BY {2} DESC", _
                                                          rsItem("MaTP"), _
                                                          WThang("Thang", thang, thang), _
                                                          SetMonthOrder("Thang"))))
            ExecSQLNonQuery(String.Format("UPDATE DinhMuc SET ThangHL={0} WHERE Thang={1} AND MaTP={2}", thang, ConvertToStrSafe(thangdm), rsItem("MaTP")))
        Loop
        i = 1
        If tp(i) <> 0 Then
            Dim QNhatky As String = String.Format("SELECT matp,max(thang) as thang1 FROM dinhmuc WHERE thang<={0} group by matp", thang)
            If XemIn > 0 Then
                Cursor = Cursors.WaitCursor
                SetRptInfo()
                str = String.Format("SELECT Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, VT.SoHieu AS SNVL, VT.TenVattu AS TNVL, VT.DonVi AS DNVL, DinhMuc.SoLuong AS LuongNVL FROM ((DinhMuc INNER JOIN (" + QNhatky + ") AS QNhatky ON DinhMuc.thang=QNhatky.thang1 and DinhMuc.matp=QNhatky.matp) INNER JOIN Vattu ON DinhMuc.MaTP=Vattu.MaSo) INNER JOIN Vattu AS VT ON DinhMuc.MaNVL=VT.MaSo  WHERE DinhMuc.MaTP={0}", tp(i))
                i += 1
                While tp(i) <> 0
                    str = String.Format("{0} or DinhMuc.MaTP={1}", str, ConvertToStrSafe(tp(i)))
                    i += 1
                End While
                rptFrom.InitForm("DM.RPT", str, "QLuyKe")

                rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(thang, thang)))
                rptFrom.SetFormulas("DiaChi", String.Format("{0}'", frmMain._LbCty_2.Text))
                RptSetDate(NgayCuoiThang(pNamTC, thang))
                InBaoCaoRPT()
                Cursor = Cursors.Default
            Else
                str = String.Format("SELECT Dinhmuc.maso,Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi,Dinhmuc.thang, VT.SoHieu AS SNVL, VT.TenVattu AS TNVL, VT.DonVi AS DNVL, DinhMuc.SoLuong AS LuongNVL FROM ((DinhMuc INNER JOIN (" + QNhatky + ") AS QNhatky ON DinhMuc.thang=QNhatky.thang1 and DinhMuc.matp=QNhatky.matp) INNER JOIN Vattu ON DinhMuc.MaTP=Vattu.MaSo) INNER JOIN Vattu AS VT ON DinhMuc.MaNVL=VT.MaSo  WHERE DinhMuc.MaTP={0}", tp(i))
                i += 1
                While tp(i) <> 0
                    str = String.Format("{0} or DinhMuc.MaTP={1}", str, ConvertToStrSafe(tp(i)))
                    i += 1
                End While
                LbSoCT.Text = "0"
                str = String.Format("{0} order by vattu.sohieu", str)
                rs = ExecSQLReturnDT(str)
                With GrdChungtu
                    '.Row = 0
                    rsIndex = 0
                    While rsIndex < rs.Rows.Count
                        Dim rsItem As DataRow = rs.Rows(rsIndex)
                        rsIndex += 1
                        If SoHieu <> rsItem("SoHieu") Then
                            SoHieu = rsItem("SoHieu")
                            .AddItem(rsItem("SoHieu") + Chr(9) + rsItem("TenVattu") + Chr(9) + rsItem("DonVi") + Chr(9) + CStr(rsItem("thang")))
                            rsIndex -= 1
                            sothanhpham += 1
                        Else
                            .AddItem(rsItem("Snvl") + Chr(9) + rsItem("Tnvl") + Chr(9) + rsItem("Dnvl") + Chr(9) + Chr(9) + CStr(rsItem("LuongNVL")) + Chr(9) + CStr(rsItem("MaSo")))
                        End If
                    End While
                End With
                LbSoCT.Text = Format(sothanhpham, Mask_0)
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub FrmDinhmuc_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ColumnSetUp(GrdChungtu, 0, 1190, 0)
            ColumnSetUp(GrdChungtu, 1, 3830, 0)
            ColumnSetUp(GrdChungtu, 2, 950, 2)
            ColumnSetUp(GrdChungtu, 3, 590, 2)
            ColumnSetUp(GrdChungtu, 4, 1020, 2)
            ColumnSetUp(GrdChungtu, 5, 1, 2)
            Text = SetFormTitle(Text)
            Lietke(0, FrmThanhPham)
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
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0 : Me.Close()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmDinhmuc_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.X
                    If Command(1).Visible Then
                        Command(1).Focus()
                        'Command_ClickEvent(Command(1), New EventArgs())
                    End If
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(0), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdChungtu.DoubleClick
        FrmOptSuaTonkho.thuchien()
        Lietke()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdChungtu.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(GrdChungtu, GrdChungtu.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Xem_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Xem.Click
        Lietke(1, FrmThanhPham)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmDinhmuc_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
