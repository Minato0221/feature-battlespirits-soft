Public Class spirit_first_status
    Private name_value As String
    Private place_value As String
    Private status_value As String
    Private core_value As String

    Public Property name() As String
        Get
            Return name_value
        End Get
        Set(ByVal value As String)
            name_value = value
        End Set
    End Property
    Public Property place() As String
        Get
            Return place_value
        End Get
        Set(ByVal value As String)
            place_value = value
        End Set
    End Property

    Public Property status() As String
        Get
            Return status_value
        End Get
        Set(ByVal value As String)
            status_value = value
        End Set
    End Property

    Public Property core() As String
        Get
            Return core_value
        End Get
        Set(ByVal value As String)
            core_value = value
        End Set
    End Property

End Class
