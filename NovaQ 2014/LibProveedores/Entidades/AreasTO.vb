Public Class AreasTO
    Private _STRId As String
    Private _STRDescripcion As String

    Public Sub New()
        _STRId = String.Empty
        _STRDescripcion = String.Empty
    End Sub

    Public Property Id As String
        Get
            Return _STRId
        End Get
        Set(value As String)
            _STRId = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _STRDescripcion
        End Get
        Set(value As String)
            _STRDescripcion = value
        End Set
    End Property



End Class
