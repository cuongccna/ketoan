Imports System
Imports System.Text
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmGetStr

    Dim pms As String = String.Empty

    Public Function GetString(ByRef des As String, ByRef title As String, Optional ByRef ans As String = "") As String
        Dim result As String = String.Empty
        Me.Text = title
        Label(0).Text = des
        Text_Renamed.Text = ans
        Me.ShowDialog()
        result = Text_Renamed.Text
        Me.Close()
        Return result

    End Function

    Private Sub FormInit()
        If ConvertToDblSafe(Me.Tag) = 0 Then
            Me.Height = 86
        Else
            Select Case ConvertToStrSafe(Me.Tag)
                Case "1"
                    Int_RecsetToListbox(String.Format("SELECT DISTINCT MaSo AS F2, Sohieu+' - '+Ten" & IIf(pNN = 1, "E", "") & " AS F1, SoHieu FROM HethongTK WHERE TK_ID={0} AND TKCon=0 ORDER BY SoHieu", TKVT_ID), List)
                Case "2"
                    Int_RecsetToListbox(String.Format("SELECT DISTINCT MaSo AS F2, Sohieu+' - '+Ten" & IIf(pNN = 1, "E", "") & " AS F1, SoHieu FROM HethongTK WHERE (TK_ID={0} OR TK_ID={1}) AND TKCon=0 ORDER BY SoHieu", TKCNKH_ID, TKCNPT_ID), List)
                Case "3"
                    Int_RecsetToListbox(String.Format("SELECT DISTINCT MaSo AS F2, Sohieu+' - '+Ten" & IIf(pNN = 1, "E", "") & " AS F1, SoHieu FROM HethongTK WHERE TK_ID2={0} AND TKCon=0 ORDER BY SoHieu", TKCPSX_ID), List)
                Case "4"
                    Int_RecsetToListbox(String.Format("SELECT DISTINCT MaSo AS F2, Sohieu+' - '+Ten" & IIf(pNN = 1, "E", "") & " AS F1, SoHieu FROM HethongTK WHERE TK_ID2={0} AND TKCon=0 ORDER BY SoHieu", TKDT_ID), List)
            End Select
        End If
    End Sub

    Private Sub FrmGetStr_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case 13
                If (FrmChamcong.Visible Or FrmMNTaiSan.Visible Or FrmMNCongCu.Visible Or FrmChungtutonghop.Visible) And Text_Renamed.Text = "" Then
                    Text_Renamed.Text = FrmTP.ChonTP(Text_Renamed.Text)
                Else
                    Me.Hide()
                End If
            Case 27
                Text_Renamed.Text = ""
                Me.Hide()
        End Select
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    Private Sub FrmGetStr_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub Text_Renamed_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Text_Renamed.Enter
        Text_Renamed.SelectAll()
    End Sub

    Public Function GetMK(ByRef MST As String, Optional ByRef off As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim str As String = FrmOptions.Text_Renamed(0).Text
        Dim Tr As Double = Int_StrToCode(str)
        Me.Text = String.Format(Ngonngu("Mã số chương trình:  {0} - {1}", "Program code:  {0} - {1}"), GetRandom(), ConvertToStrSafe(Tr))
        Label(0).Text = Ngonngu("Nhập mã số cài đặt", "Enter settings")
        Me.ShowDialog()
        result = Int_StrToCode(pms) + Int_StrToCode(MST) + Tr + 2006 = ConvertToDblSafe(Text_Renamed.Text)
        If Strings.Len(Text_Renamed.Text) = 0 Then off = 1
        Me.Close()
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetRandom() As String
        Dim i As Integer
        Dim st As New StringBuilder
        pms = ""
        VBMath.Randomize()
        Do While pms.Length < 11
            ' Initialize random-number generator.
            i = 0
            Do While Not ((i >= 65 And i <= 90) Or (i >= 49 And i <= 57))
                i = CSng(Math.Floor((44 * VBMath.Rnd()) + 47))
            Loop
            pms = pms & Chr(i).ToString()
            st.Append(String.Format("{0}  ", Chr(i)))
        Loop
        Return st.ToString()
    End Function
End Class
