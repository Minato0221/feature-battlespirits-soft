Public Class resource_info
    Private life_value As String
    Private reserve_value As String

    Public Property life() As String
        Get
            Return life_value
        End Get
        Set(ByVal value As String)
            life_value = value
        End Set
    End Property

    Public Property reserve() As String
        Get
            Return reserve_value
        End Get
        Set(ByVal value As String)
            reserve_value = value
        End Set
    End Property

End Class
