Public Class spirit_info

    Private path_value As String
    Private name_value As String

    Public Property path() As String
        Get
            Return path_value
        End Get
        Set(ByVal value As String)
            path_value = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return name_value
        End Get
        Set(ByVal value As String)
            name_value = value
        End Set
    End Property



End Class
