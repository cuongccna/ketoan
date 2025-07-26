Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class frmSelectBC
    Private isInitializingComponent As Boolean
    Private Sub BCLoai_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _BCLoai_2.CheckedChanged, _BCLoai_1.CheckedChanged, _BCLoai_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(BCLoai, eventSender)
            Select Case Index
                Case 0
                    cboThang1.Visible = True
                    cboThang2.Visible = True
                    cboQuy.Visible = False
                    Label1.Visible = True
                    Label2.Visible = True
                    Label3.Visible = False
                Case 1
                    cboThang1.Visible = False
                    cboThang2.Visible = False
                    cboQuy.Visible = True
                    Label1.Visible = False
                    Label2.Visible = False
                    Label3.Visible = True
                Case 2
                    cboThang1.Visible = False
                    cboThang2.Visible = False
                    cboQuy.Visible = False
                    Label1.Visible = False
                    Label2.Visible = False
                    Label3.Visible = False
                Case Else
            End Select
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thangdau"></param>
    ''' <param name="thangcuoi"></param>
    ''' <param name="loai"></param>
    ''' <remarks></remarks>

    Private Sub TaoBC(ByRef thangdau As Integer, ByRef thangcuoi As Integer, ByRef loai As Integer)
        UpdateSLHoaDon()
        Dim i As Object = thangdau
        Dim j As Integer = thangcuoi
        If (ConvertToDblSafe(i) > 0 And ConvertToDblSafe(i) < 13) And (j > 0 And j < 13) And (j >= ConvertToDblSafe(i)) Then
            TaoBCHoaDonQuy(ConvertToDblSafe(i), j)
            InSLHoaDon(ConvertToDblSafe(i), j, loai)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cboThang1_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cboThang1.Leave
        If cboThang1.SelectedIndex > cboThang2.SelectedIndex Then
            If cboThang2.Items.Count > 0 Then cboThang2.SelectedIndex = cboThang1.SelectedIndex
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim i, j As Integer
        rptFrom.ReportDestination = 1
        Select Case Index
            Case 0
                rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
                If BCLoai(0).Checked Then
                    If cboThang1.SelectedIndex > cboThang2.SelectedIndex Then
                        If cboThang2.Items.Count > 0 Then cboThang2.SelectedIndex = cboThang1.SelectedIndex
                    End If
                    TaoBC(ConvertToDblSafe(cboThang1.Text), ConvertToDblSafe(cboThang2.Text), 1)
                End If
                If BCLoai(1).Checked Then
                    i = (ConvertToDblSafe(cboQuy.Text) - 1) * 3 + 1
                    j = ConvertToDblSafe(cboQuy.Text) * 3
                    TaoBC(i, j, 2)
                End If
                If BCLoai(2).Checked Then
                    i = 1
                    j = 12
                    TaoBC(i, j, 3)
                End If
            Case 1
                Me.Close() : Exit Sub
            Case Else
        End Select
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmSelectBC_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Try
            'Dim KeyCode As Integer = eventArgs.KeyCode
            Dim Shift As Integer = eventArgs.KeyData \ &H10000
            If (Shift And 4) > 0 Then
                Select Case eventArgs.KeyCode
                    Case Keys.V
                        Command(1).Focus()
                        ' Command_ClickEvent(Command(1), New EventArgs())
                    Case Keys.X
                        Command(0).Focus()
                        ' Command_ClickEvent(Command(0), New EventArgs())
                End Select
            End If
            If eventArgs.KeyCode = Keys.Escape Then Me.Close()
        Catch ex As Exception
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmSelectBC_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            If cboThang1.Items.Count > 0 Then cboThang1.SelectedIndex = FrmMNBaocao.CboThang(0).SelectedIndex
            If cboThang2.Items.Count > 0 Then cboThang2.SelectedIndex = FrmMNBaocao.CboThang(1).SelectedIndex
            If cboQuy.Items.Count > 0 Then cboQuy.SelectedIndex = 0
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Private Sub frmSelectBC_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
