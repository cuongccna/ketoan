Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmCandoi
    Dim ton As Double
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim tdau, tcuoi As Integer

        Select Case Index
            Case 0
                If CboThang(0).Items.Count > 0 And CboThang(1).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue
                LietkeCandoi(True, tdau, tcuoi, _CboThang_2.SelectedIndex + 1, False)
            Case 1
                Me.Close()
        End Select
    End Sub

    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        'Dim iIndex As Integer = 0
        'Dim Objects() As Object
        'iIndex = 0

        'Objects = New Object() {"1", "2", "3", "4", "5", "6"}
        '_CboThang_2.Items.Clear()
        '_CboThang_2.Items.ItemsBase.Clear()
        'For Each objItem As Object In Objects
        '    _CboThang_2.Items.Add(objItem.ToString, 0)
        '    iIndex += 1
        'Next
        ClearGrid(Grd, Grd.Rows)
        Command_ClickEvent(Command(0), New EventArgs())
    End Sub
    Private Sub Khoi_tao()
        ColumnSetUp(Grd, 0, 350, 2)
        ColumnSetUp(Grd, 1, 950, 0)
        ColumnSetUp(Grd, 2, 3350, 0)
        ColumnSetUp(Grd, 3, 1670, 4)
        ColumnSetUp(Grd, 4, 1670, 4)
        ColumnSetUp(Grd, 5, 1670, 4)
        ColumnSetUp(Grd, 6, 1670, 4)
        ColumnSetUp(Grd, 7, 1670, 4)
        ColumnSetUp(Grd, 8, 1640, 4)
        Grd.Cols = 9
    End Sub
    Dim co As Integer = 0
    Private Sub FrmCandoi_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            If pNN = 1 And Not Me.Text Like "Balance in the preriod*" Then SetFont(Me)
            Me.Text = String.Format(Ngonngu("Bảng cân đối trong kỳ {0} - {1}", "Balance in the preriod {0} - {1}"), CboThang(0).Text, CboThang(1).Text)
            If co = 0 Then Khoi_tao()
            Call FormInit()
            If FLAG = 0 Then
                For chi_so As Integer = 0 To 1
                    AddMonthToCbo(CboThang(chi_so))
                    If CboThang(2).Items.Count > 0 Then CboThang(2).SelectedIndex = CboThang(2).Items.Count - 1
                Next
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Dim FLAG As Integer = 0
    Public Sub Candoiluoi(ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef cap As Integer = 5)
        Khoi_tao()
        FLAG = 1
        For chi_so As Integer = 0 To 1
            AddMonthToCbo(CboThang(chi_so))
            If CboThang(2).Items.Count > 0 Then CboThang(2).SelectedIndex = CboThang(2).Items.Count - 1
        Next
        Dim iIndex As Integer = 0
        Dim Objects() As Object

        iIndex = 0
        Objects = New Object() {"1", "2", "3", "4", "5", "6"}

        For Each objItem As Object In Objects
            _CboThang_2.Items.Add(objItem.ToString, 0)
            iIndex += 1
        Next
        If CboThang(0).Items.Count > 0 Then CboThang(0).SelectedIndex = tdau
        If CboThang(1).Items.Count > 0 Then CboThang(1).SelectedIndex = tcuoi
        If CboThang(2).Items.Count > 0 Then CboThang(2).SelectedIndex = cap
        co = 1
        Me.ShowDialog()
    End Sub

    Private Sub LietkeCandoi(ByRef saukc As Boolean, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cap As Integer, ByRef ct As Integer)
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim i As Integer
        Dim NoCK, NoTK, NoDK, CoDK, CoTK, CoCK, no, co As Double
        Dim captk As Integer

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
        ClearGrid(Grd, Grd.Rows)
        If rs.Rows.Count > 0 Then
            'rs.MoveLast()
            GauGe.Maximum = rs.Rows.Count
            i = 1
            GauGe.Value = 1
            ''rs.MoveFirst()
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                Grd.AddItem(String.Format("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}", Chr(9), " "))
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                With Grd
                    .Row = (i - 1)
                    .Col = 0
                    .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(i)
                    captk = CInt(rsItem("cap"))
                    If captk > 0 Then
                        For j As Integer = 1 To 2
                            .Col = (j)
                            .Items(.Row).SubItems(.Col).Text = String.Format("{0}{1}", New String(" "c, rsItem(0)), rsItem(j))
                        Next
                        If rsItem("SoHieu") Like "131%" Or rsItem("SoHieu") Like "331%" Or rsItem("SoHieu") Like "138%" Or rsItem("SoHieu") Like "338%" Then
                            .Col = 3
                            no = rsItem("dkno")
                            .Items(.Row).SubItems(.Col).Text = Format(no, Mask_0)
                            If captk = 1 Then NoDK += no
                            .Col = 4
                            co = rsItem("dkco")
                            .Items(.Row).SubItems(.Col).Text = Format(co, Mask_0)
                            If captk = 1 Then CoDK += co
                            .Col = 7
                            no = rsItem("ckno")
                            .Items(.Row).SubItems(.Col).Text = Format(no, Mask_0)
                            If captk = 1 Then NoCK += no
                            .Col = 8
                            co = rsItem("ckco")
                            .Items(.Row).SubItems(.Col).Text = Format(co, Mask_0)
                            If captk = 1 Then CoCK += co
                        Else
                            If ConvertToDblSafe(rsItem("dkno")) > ConvertToDblSafe(rsItem("dkco")) Then
                                .Col = 3
                                no = ConvertToDblSafe(rsItem("dkno")) - ConvertToDblSafe(rsItem("dkco"))
                                .Items(.Row).SubItems(.Col).Text = Format(no, Mask_0)
                                If captk = 1 Then NoDK += no
                            Else
                                .Col = 4
                                co = ConvertToDblSafe(rsItem("dkco")) - ConvertToDblSafe(rsItem("dkno"))
                                .Items(.Row).SubItems(.Col).Text = Format(co, Mask_0)
                                If captk = 1 Then CoDK += co
                            End If
                            If CDbl(rsItem("ckno")) > CDbl(rsItem("ckco")) Then
                                .Col = 7
                                no = CDbl(rsItem("ckno")) - CDbl(rsItem("ckco"))
                                .Items(.Row).SubItems(.Col).Text = Format(no, Mask_0)
                                If captk = 1 Then NoCK += no
                            Else
                                .Col = 8
                                co = CDbl(rsItem("ckco")) - CDbl(rsItem("ckno"))
                                .Items(.Row).SubItems(.Col).Text = Format(co, Mask_0)
                                If captk = 1 Then CoCK += co
                            End If
                        End If
                        .Col = 5
                        no = CDbl(rsItem("psno"))
                        .Items(.Row).SubItems(.Col).Text = Format(no, Mask_0)
                        If captk = 1 Then NoTK += no
                        .Col = 6
                        co = CDbl(rsItem("psco"))
                        .Items(.Row).SubItems(.Col).Text = Format(co, Mask_0)
                        If captk = 1 Then CoTK += co
                    End If
                End With
                GauGe.Value = i
                i += 1
            End While
            Label(21).Text = Format(NoDK, Mask_0)
            Label(22).Text = Format(CoDK, Mask_0)
            Label(23).Text = Format(NoTK, Mask_0)
            Label(24).Text = Format(CoTK, Mask_0)
            Label(25).Text = Format(NoCK, Mask_0)
            Label(26).Text = Format(CoCK, Mask_0)
        End If
    End Sub

    Private Sub FrmCandoi_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.L
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub

    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.DoubleClick
        mnct_Click(mnct(0), New EventArgs())
    End Sub

    Private Sub Grd_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grd.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(Grd, Grd.Row)
    End Sub

    Public Sub mnct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnct_0.Click
        Grd.Col = 1
        FrmSochitiet.Hienthi(Me)
    End Sub
    Private Sub FrmCandoi_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
