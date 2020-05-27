Public Class form1_card_list

    Private status_name_value As String
    Private name_value As String

    Public Property status_name() As String
        Get
            Return status_name_value
        End Get
        Set(ByVal value As String)
            status_name_value = value
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
