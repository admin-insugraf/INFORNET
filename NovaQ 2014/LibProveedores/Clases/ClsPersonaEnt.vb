Public Class ClsPersonaEnt
    Private _CODIGO As String
    Private _NOMBRE As String
    Private _APELLIDO As String
    Private _EDAD As Integer

    Public Sub New()
        _CODIGO = String.Empty
        _NOMBRE = String.Empty
        _APELLIDO = String.Empty
        _EDAD = 0
    End Sub

    Public Property CODIGO As String
        Get
            Return _CODIGO
        End Get
        Set(value As String)
            _CODIGO = value
        End Set
    End Property

    Public Property NOMBRE As String
        Get
            Return _NOMBRE
        End Get
        Set(value As String)
            _NOMBRE = value
        End Set
    End Property

    Public Property APELLIDO As String
        Get
            Return _APELLIDO
        End Get
        Set(value As String)
            _APELLIDO = value
        End Set
    End Property

    Public Property EDAD As Integer
        Get
            Return _EDAD
        End Get
        Set(value As Integer)
            _EDAD = value
        End Set
    End Property

End Class
