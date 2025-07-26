Imports Microsoft.Office.Interop

Module modUpgradeSupport
    Private _Excel_Global_definst As Excel.Global = Nothing
    Private _Word_Global_definst As Word.Global = Nothing

    Public ReadOnly Property Excel_Global() As Excel.Global
        Get
            If _Excel_Global_definst Is Nothing Then
                _Excel_Global_definst = New Excel.Global
            End If
            Return _Excel_Global_definst
        End Get
    End Property

    Public Property Word_Global() As Word.Global
        Get
            Return _Word_Global_definst
        End Get
        Set(ByVal value As Word.Global)
            _Word_Global_definst = value
        End Set
    End Property
End Module
