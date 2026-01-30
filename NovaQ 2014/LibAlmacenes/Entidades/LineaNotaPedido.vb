Public Class LineaNotaPedido
    Public Overridable Property NotaPedido() As NotaPedido
    Public Property IDAlmacen() As String
    Public Property TipoDocumento() As String
    Public Property NumeroDocumento() As String
    Public Property NumeroLinea() As Integer
    Public Property IDArticulo() As String
    Public Property Articulo() As String
    Public Property Cantidad() As Decimal
    Public Property UnitArticulo() As String
    Public Property PrecioUnitario() As Decimal
    Public Property CostoPromedio() As Decimal
    Public Property Monto() As Decimal
    Public Property MontoEnDolares() As Decimal
    Public Property IDMoneda() As String
    Public Property TipoCambio() As Decimal
    Public Property Lote() As String
    Public Property EsValorizado As Boolean
    Public Property PROJECT_ID As String
    Public Property QT_BULTOS As String
    Public Property OPT_ENTREGA As String
    Public Property NUM_PROTOCOLOS As String
End Class
