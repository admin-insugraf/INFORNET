Public Class ClsClienteTO
    Private _STRCodigoCli As String
    Private _STRNombreCli As String
    Private _STRVat As String


    Public Property STRCodigoCli As String
        Get
            Return _STRCodigoCli
        End Get
        Set(value As String)
            _STRCodigoCli = value
        End Set
    End Property

    Public Property STRNombreCli As String
        Get
            Return _STRNombreCli
        End Get
        Set(value As String)
            _STRNombreCli = value
        End Set
    End Property

    Public Property STRVat As String
        Get
            Return _STRVat
        End Get
        Set(value As String)
            _STRVat = value
        End Set
    End Property


End Class
