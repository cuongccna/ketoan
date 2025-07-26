
Public Class ValueDescriptionPair
    Private m_Value As Object
    Private m_Description As String

    ''' <summary>
    ''' NewValue
    ''' </summary>
    ''' <param name="NewValue"></param>
    ''' <param name="NewDescription"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal NewValue As Object, ByVal NewDescription As String)
        m_Value = NewValue
        m_Description = NewDescription
    End Sub
    ''' <summary>
    ''' ToString
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return m_Description
    End Function
    ''' <summary>
    ''' Value
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Value() As Object
        Get
            Return m_Value
        End Get
    End Property
    ''' <summary>
    ''' Description
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Description() As String
        Get
            Return m_Description
        End Get
    End Property
End Class
