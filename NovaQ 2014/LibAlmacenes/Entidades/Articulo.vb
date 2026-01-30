Public Class Articulo
    Public Sub New()
        Lotes = New List(Of Lote)()
    End Sub

    Public Property Codigo As String
    Public Property Descripcion As String
    Public Property Unidad As String
    Public Property IsLot As String
    Public Overridable Property Lotes As ICollection(Of Lote)

    Public ReadOnly Property EsLote As Boolean
        Get
            Return IsLot = "S"
        End Get
    End Property
End Class
