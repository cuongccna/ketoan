Public Class App
    Public Function getAppTitle(Optional ByVal Caption As String = "", Optional ByVal ShowShortCaption As Boolean = False) As String
        Return My.Application.Info.Title
    End Function
End Class
