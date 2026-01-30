Public Class NotaPedido
    Public Property IDAlmacen As String
    Public Property Fecha As Date
    Public Property IDMoneda As String
    Public Property TipoCambio As Decimal
    Public Property IDCliente As String
    Public Property Cliente As String
    Public Property TipoDocumento As String
    Public Property NumeroDocumento As String
    Public Property TipoDocReferencia As String
    Public Property NumeroDocReferencia As String
    Public Property OrdenCompra As String
    Public Property TipoNota As String
    Public Property IDProveedor As String
    Public Property Proveedor As String
    Public Property IDCentroCosto As String
    Public Property Monto As Decimal
    Public Property TipoMovimiento As String
    Public Property FechaActualizado As Date?
    Public Property Hora As String
    Public Property Usuario As String
    Public Property Estado As String
    Public Property NUM_ORDER_MANUFACT As String
    Public Property NUMBER_PURCHASE As String
    Public Property COMMENT As String
    Public Overridable Property Lineas As ICollection(Of LineaNotaPedido)

    Public Sub New()
        Lineas = New List(Of LineaNotaPedido)
    End Sub
End Class
