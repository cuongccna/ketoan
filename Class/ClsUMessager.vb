Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms

Public Class myUMessager
    Public Shared Sub mError(ByVal mes As String, ByVal title As String, ByVal ok As MessageBoxButtons, ByVal icon As MessageBoxIcon)
        Dim _frm As FrmUMessager = New FrmUMessager()
        _frm.txtNoiDung.Text = mes
        _frm.lab_TieuDe.Text = title
        '_frm.lab_TB.Text = "...ERROR ! ..."
        _frm.lab_TB.Image = My.Resources.errorMessager
        _frm.Type = 1
        _frm.lab_TieuDe.ForeColor = Color.Red
        _frm.lab_TB.ForeColor = Color.Red
        If mes.Length > 300 Then
            _frm.Height = 300
        Else
            _frm.Height = 187
        End If
        If _frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Public Shared Sub mWarning(ByVal mes As String, ByVal title As String, ByVal ok As MessageBoxButtons, ByVal icon As MessageBoxIcon)
        Dim _frm As FrmUMessager = New FrmUMessager()
        _frm.txtNoiDung.Text = mes
        _frm.lab_TieuDe.Text = title
        '_frm.lab_TB.Text = "...WARNING ! ..."
        _frm.lab_TB.Image = My.Resources.warningMessager
        _frm.Type = 1
        _frm.lab_TieuDe.ForeColor = Color.YellowGreen
        _frm.lab_TB.ForeColor = Color.YellowGreen
        If mes.Length > 300 Then
            _frm.Height = 300
        Else
            _frm.Height = 187
        End If
        If _frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Public Shared Sub mInformation(ByVal mes As String, ByVal title As String, ByVal ok As MessageBoxButtons, ByVal icon As MessageBoxIcon)
        Dim _frm As FrmUMessager = New FrmUMessager()
        _frm.txtNoiDung.Text = mes
        _frm.lab_TieuDe.Text = title
        '_frm.lab_TB.Text = "...SUCCESS ! ..."
        _frm.lab_TB.Image = My.Resources.informationMessager
        _frm.Type = 1
        _frm.lab_TieuDe.ForeColor = Color.Green
        _frm.lab_TB.ForeColor = Color.Green
        If mes.Length > 300 Then
            _frm.Height = 300
        Else
            _frm.Height = 187
        End If
        If _frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Public Shared Function mQuestion(ByVal mes As String, ByVal title As String, ByVal ok As MessageBoxButtons, ByVal icon As MessageBoxIcon) As System.Windows.Forms.DialogResult
        Dim res As System.Windows.Forms.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Dim _frm As FrmUMessager = New FrmUMessager()
        _frm.txtNoiDung.Text = mes
        _frm.lab_TieuDe.Text = title
        _frm.btnNo.Focus()
        '_frm.lab_TB.Text = "...QUESTION ? ..."
        _frm.lab_TB.Image = My.Resources.questionMessager
        _frm.Type = 2
        _frm.lab_TieuDe.ForeColor = Color.Blue
        _frm.lab_TB.ForeColor = Color.Blue
        If mes.Length > 300 Then
            _frm.Height = 300
        Else
            _frm.Height = 187
        End If
        If _frm.ShowDialog() = System.Windows.Forms.DialogResult.Yes Then
            res = System.Windows.Forms.DialogResult.Yes
        Else
            res = System.Windows.Forms.DialogResult.No
        End If

        Return res
    End Function
End Class
