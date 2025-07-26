Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmPBCT
    Private _tp As Cls154 = Nothing
    Property tp() As Cls154
        Get
            If _tp Is Nothing Then
                _tp = New Cls154()
            End If
            Return _tp
        End Get
        Set(ByVal Value As Cls154)
            _tp = Value
        End Set
    End Property
    Dim tdau, tcuoi As Integer
    Dim tcpax, tcp3x, tcp1x, tcp3, tcp1, tcpa, tcpb, tcp2, tcp4, tcp2x, tcp4x, tcpbx As Double
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        If tp.MaSo = 0 Then Exit Sub
        Dim pba As Double = ConvertToDblSafe(txtTon(4).Text)
        Dim pbb As Double = ConvertToDblSafe(txtTon(5).Text)
        Dim pb1 As Double = ConvertToDblSafe(txtTon(6).Text)
        Dim pb2 As Double = ConvertToDblSafe(txtTon(7).Text)
        Dim pb3 As Double = ConvertToDblSafe(txtTon(8).Text)
        Dim pb4 As Double = ConvertToDblSafe(txtTon(9).Text)
        If pba > tcpa - tcpax Then
            txtTon(4).Focus()
            Exit Sub
        End If
        If pbb > tcpb - tcpbx Then
            txtTon(5).Focus()
            Exit Sub
        End If
        If pb1 > tcp1 - tcp1x Then
            txtTon(6).Focus()
            Exit Sub
        End If
        If pb2 > tcp2 - tcp2x Then
            txtTon(7).Focus()
            Exit Sub
        End If
        If pb3 > tcp3 - tcp3x Then
            txtTon(8).Focus()
            Exit Sub
        End If
        If pb4 > tcp4 - tcp4x Then
            txtTon(9).Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        With GrdVT
            .AddItem(tp.SoHieu & Chr(9).ToString() & tp.TenVattu & Chr(9).ToString() & tp.DonVi & Chr(9).ToString() & txtTon(3).Text & Chr(9).ToString() & Format(pba, Mask_0) & Chr(9).ToString() & Format(pbb, Mask_0) & Chr(9).ToString() & Format(pb1, Mask_0) & Chr(9).ToString() & Format(pb2, Mask_0) & Chr(9).ToString() & Format(pb3, Mask_0) & Chr(9).ToString() & Format(pb4, Mask_0) & Chr(9).ToString() & txtTon(10).Text, IIf(ConvertToDblSafe(cmdct.Tag) < 0, 0, ConvertToStrSafe(cmdct.Tag)))
            tp.GhiCPPB(tdau, tcuoi, 0, pb1 - tp.SoCPSXCTT(tdau, tcuoi))
            tp.GhiCPPB2(tdau, tcuoi, pb2 - tp.SoCPBH(tdau, tcuoi), pb3, pb4)
            tp.GhiCPPB3(tdau, tcuoi, pba - tp.SoCPNC(tdau, tcuoi), pbb - tp.SoCPM(tdau, tcuoi))
            .Row = (.Row - 1)
            .Col = 0
            If .CtlText.length = 0 Then .RemoveItem(.Row)
            .Row = 0
        End With
        cmdct.Tag = "-1"
        tongtien()
        FrmPBCP.Tag = "1"
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                InBaoCao()
            Case 1
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If ConvertToDblSafe(Me.Tag) > 0 Then
            Me.Cursor = Cursors.WaitCursor
            tdau = ConvertToDblSafe(Me.Tag) \ 100
            tcuoi = ConvertToDblSafe(Me.Tag) Mod 100
            Me.Tag = "0"
            LietKeCP()
            Me.Cursor = Cursors.Default
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmPBCT_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Or eventArgs.KeyCode = Keys.Escape Then Hide()

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmPBCT_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 

            ColumnSetUp(GrdVT, 0, 830, 1)
            ColumnSetUp(GrdVT, 1, 1930, 1)
            ColumnSetUp(GrdVT, 2, 730, 2)
            ColumnSetUp(GrdVT, 3, 1090, 4)
            ColumnSetUp(GrdVT, 4, 1090, 4)
            ColumnSetUp(GrdVT, 5, 850, 4)
            ColumnSetUp(GrdVT, 6, 1090, 4)
            ColumnSetUp(GrdVT, 7, 1090, 4)
            ColumnSetUp(GrdVT, 8, 1090, 4)
            ColumnSetUp(GrdVT, 9, 1090, 4)
            ColumnSetUp(GrdVT, 10, 250, 2)
            GrdVT.Items.Clear()
            Call FormInit()
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
    Private Sub FrmPBCT_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        tp = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdVT.Click
        Dim i As Integer
        With GrdVT
            If .Col = 10 Then
                .CtlText = IIf(.CtlText = "X", "-", "X")
                i = IIf(.CtlText = "X", 0, 1)
                .Col = 0
                ExecSQLNonQuery("UPDATE TP154 SET KPB=" & i & " WHERE SoHieu='" & .CtlText & "'")
            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdVT.DoubleClick
        With GrdVT
            .Col = 0
            If .CtlText.length = 0 Then Exit Sub
            For i As Integer = 0 To 10
                .Col = ConvertToDblSafe(i)
                txtTon(i).Text = .CtlText
            Next
            cmdct.Tag = ConvertToStrSafe(.Row)
            .RemoveItem(.Row)
            tongtien()
            tp.InitTPSohieu(txtTon(0).Text)
            txtTon(3).Focus()
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdVT.KeyPress
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdVT_DblClick(GrdVT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdVT.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdVT, GrdVT.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_10.Enter, _txtTon_9.Enter, _txtTon_8.Enter, _txtTon_7.Enter, _txtTon_6.Enter, _txtTon_5.Enter, _txtTon_4.Enter, _txtTon_3.Enter, _txtTon_2.Enter, _txtTon_1.Enter, _txtTon_0.Enter
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        txtTon(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_10.KeyPress, _txtTon_9.KeyPress, _txtTon_8.KeyPress, _txtTon_7.KeyPress, _txtTon_6.KeyPress, _txtTon_5.KeyPress, _txtTon_4.KeyPress, _txtTon_3.KeyPress, _txtTon_2.KeyPress, _txtTon_1.KeyPress, _txtTon_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 13 Then
                    txtTon(0).Text = FrmTP.ChonTP(txtTon(0).Text)
                End If
            Case 1, 2, 3
                KeyAscii = 0
            Case 4, 5, 6, 7
                If KeyAscii = 13 Then
                    cmdct_Click(cmdct, New EventArgs())
                Else
                    KeyProcess(txtTon(Index), KeyAscii, True)
                End If
        End Select
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_10.Leave, _txtTon_9.Leave, _txtTon_8.Leave, _txtTon_7.Leave, _txtTon_6.Leave, _txtTon_5.Leave, _txtTon_4.Leave, _txtTon_3.Leave, _txtTon_2.Leave, _txtTon_1.Leave, _txtTon_0.Leave
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Select Case Index
            Case 0
                If Strings.Len(txtTon(0).Text) > 0 Then
                    tp.InitTPSohieu(txtTon(0).Text)
                Else
                    tp.InitTPMaSo(0)
                End If
            Case 6, 7
                txtTon(Index).Text = Format(txtTon(Index).Text, Mask_0)
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub tongtien()
        tcpax = 0
        tcpbx = 0
        tcp1x = 0
        tcp2x = 0
        tcp3x = 0
        tcp4x = 0
        With GrdVT
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 0
                If .CtlText.length = 0 Then Exit For
                .Col = 4
                tcpax += ConvertToDblSafe(.CtlText)
                .Col = 5
                tcpbx += ConvertToDblSafe(.CtlText)
                .Col = 6
                tcp1x += ConvertToDblSafe(.CtlText)
                .Col = 7
                tcp2x += ConvertToDblSafe(.CtlText)
                .Col = 8
                tcp3x += ConvertToDblSafe(.CtlText)
                .Col = 9
                tcp4x += ConvertToDblSafe(.CtlText)
            Next
        End With
        LbTien(8).Text = Format(tcpax, Mask_0)
        LbTien(9).Text = Format(tcpbx, Mask_0)
        LbTien(10).Text = Format(tcp1x, Mask_0)
        LbTien(11).Text = Format(tcp2x, Mask_0)
        LbTien(12).Text = Format(tcp3x, Mask_0)
        LbTien(13).Text = Format(tcp4x, Mask_0)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeCP()
        Dim cp2 As New StringBuilder
        Dim tcpc As Double
        Dim s623 As New StringBuilder
        Dim s622 As New StringBuilder
        Dim s621 As New StringBuilder
        Dim cp5 As New StringBuilder
        Dim cp4 As New StringBuilder
        Dim cp3 As New StringBuilder
        Dim rs As DataTable = ExecSQLReturnDT("SELECT MaSo FROM TP154")
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            tp.InitTPMaSo(ConvertToDblSafe(rsItem("MaSo")))
            tp.GhiCPTT(tdau, tcuoi)
            tp.XDDauKy(tdau)
            ''rs.MoveNext()
        Loop
        ''rs.Close()
        tcp1 = PSTKCP("627", tdau, tcuoi)
        tcp2 = PSTKCP("641", tdau, tcuoi)
        tcp3 = PSTKCP("642", tdau, tcuoi)
        tcp4 = PSTKCP("635", tdau, tcuoi)
        Dim c621 As Double = PSTKCP("621", tdau, tcuoi)
        tcpa = PSTKCP("622", tdau, tcuoi)
        tcpb = PSTKCP("623", tdau, tcuoi)
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            cp2.Append("+CPBH" & i & "+CPBHTT" & ConvertToStrSafe(i))
            cp3.Append("+CPQL" & i & "+CPQLTT" & ConvertToStrSafe(i))
            cp4.Append("+CPTC" & i & "+CPTCTT" & ConvertToStrSafe(i))
            cp5.Append("+CPSXC_" & i & "+CPSXCTT" & ConvertToStrSafe(i))
            s621.Append("+CPNVLPB" & i)
            s622.Append("+CPNCPB" & i)
            s623.Append("+CPMPB" & i)
        Next
        tcpax = 0
        tcpbx = 0
        tcp1x = 0
        tcp2x = 0
        tcp3x = 0
        tcp4x = 0
        rs = ExecSQLReturnDT("SELECT DISTINCT SoHieu, TenVattu,DonVi, CPNVL+" & s621.ToString() & " AS NVL, CPNC+" & s622.ToString() & " AS NC, CPM+" & s623.ToString() & " AS M, (" & cp5.ToString() & ") AS CPSXC, (" & cp2.ToString() & ") AS CPBH, (" & cp3.ToString() & ") AS CPQL, (" & cp4.ToString() & ") AS CPTC, KPB" & " FROM TP154  WHERE DK1<>0 OR CPNVL+" & s621.ToString() & "<>0 OR CPNC+" & s622.ToString() & "<>0 OR CPM+" & s623.ToString() & "<>0 OR (" & cp2.ToString() & ")<>0 OR (" & cp3.ToString() & ")<>0 OR (" & cp4.ToString() & ")<>0 OR (" & cp5.ToString() & ")<>0 OR DT<>0 ORDER BY SoHieu")
        rsIndex = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            tcp1x += rsItem("cpsxc")
            tcp2x += rsItem("cpbh")
            tcp3x += rsItem("cpql")
            tcp4x += rsItem("cptc")
            tcpax += rsItem("nvl")
            tcpbx += rsItem("nC")
            tcpc += rsItem("m")

            GrdVT.AddItem(String.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}", _
                            grdColSeperete, _
                            rsItem("SoHieu"), _
                            rsItem("TenVattu"), _
                            rsItem("DonVi"), _
                            Format(rsItem("nvl"), Mask_0), _
                            Format(rsItem("nC"), Mask_0), _
                            Format(rsItem("m"), Mask_0), _
                            Format(rsItem("cpsxc"), Mask_0), _
                            Format(rsItem("cpbh"), Mask_0), _
                            Format(rsItem("cpql"), Mask_0), _
                            Format(rsItem("cptc"), Mask_0), _
                            IIf(rsItem("KPB") = 0, "X", "-")))


            'GrdVT.AddItem(rsItem("SoHieu") + Chr(9).ToString() + rsItem("TenVattu") + Chr(9).ToString() + rsItem("DonVi") + Chr(9).ToString() + Format(rsItem("nvl"), Mask_0) + Chr(9).ToString() + Format(rsItem("nC"), Mask_0) + Chr(9).ToString() + Format(rsItem("m"), Mask_0) + Chr(9).ToString() + Format(rsItem("cpsxc"), Mask_0) + Chr(9).ToString() + Format(rsItem("cpbh"), Mask_0) + Chr(9).ToString() + Format(rsItem("cpql"), Mask_0) + Chr(9).ToString() + Format(rsItem("cptc"), Mask_0) + Chr(9).ToString() + (IIf(rsItem("KPB") = 0, "X", "-")), 0)

            ''rs.MoveNext()
        Loop
        ''rs.Close()
        'GrdVT.Rows = IIf(rs.Rows.Count >= ConvertToDblSafe((GrdVT.Tag)), ConvertToDblSafe(rs.Rows.Count), ConvertToDblSafe(GrdVT.Tag))
        rs = Nothing
        LbTien(0).Text = Format(c621, Mask_0)
        LbTien(1).Text = Format(tcpa, Mask_0)
        LbTien(2).Text = Format(tcpb, Mask_0)
        LbTien(3).Text = Format(tcp1, Mask_0)
        LbTien(4).Text = Format(tcp2, Mask_0)
        LbTien(5).Text = Format(tcp3, Mask_0)
        LbTien(6).Text = Format(tcp4, Mask_0)
        LbTien(7).Text = Format(tcpax, Mask_0)
        LbTien(8).Text = Format(tcpbx, Mask_0)
        LbTien(9).Text = Format(tcpc, Mask_0)
        LbTien(10).Text = Format(tcp1x, Mask_0)
        LbTien(11).Text = Format(tcp2x, Mask_0)
        LbTien(12).Text = Format(tcp3x, Mask_0)
        LbTien(13).Text = Format(tcp4x, Mask_0)
        tcp1x = tcp1
        tcp2x = tcp2
        tp.InitTPMaSo(0)
        txtTon(0).Text = ""
        txtTon(1).Text = ""
        txtTon(2).Text = ""
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InBaoCao()
        Dim ten, sh, dv As String
        Dim so As Array = Array.CreateInstance(GetType(Double), New Integer() {8}, New Integer() {3})
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
        With GrdVT
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 0
                If .CtlText.length = 0 Then Exit For
                sh = .CtlText
                .Col = 1
                ten = .CtlText
                .Col = 2
                dv = .CtlText
                For j As Integer = 3 To 9
                    .Col = ConvertToDblSafe(j)
                    so.SetValue(ConvertToDblSafe(.CtlText), j)
                Next
                ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu, Ten, Kq1, Kq2, Kq3, Kq5, Kq6, Kq7, Kq8) VALUES ({0},N'{1}',N'{2}',{3},{4},{5},{6},{7},{8},{9})", _
                                    i, _
                                    sh, _
                                    ten, _
                                    CStr(so.GetValue(3)), _
                                    CStr(so.GetValue(4)), _
                                    CStr(so.GetValue(5)), _
                                    CStr(so.GetValue(6)), _
                                    CStr(so.GetValue(7)), _
                                    CStr(so.GetValue(8)), _
                                    CStr(so.GetValue(9))))
            Next
        End With
        SetRptInfo()
        For i As Integer = 0 To 6
            rptFrom.SetFormulas("CP" & CStr(i + 1), ConvertToDblSafe(LbTien(i).Text))
        Next
        rptFrom.InitForm("CHIPHI4.RPT", "SELECT * FROM BaoCaoCP", "BaoCaoCP")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", Me.Text))
        InBaoCaoRPT()
    End Sub
End Class
