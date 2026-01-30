Public Class ClsPedidosTO

    Public Class Cab_Pedidos_TO
        Private _STRNumPedido As String
        Private _DTFechaPedido As Date
        Private _DTFechaVencimiento As Date
        Private _STRCodVendedor As String
        Private _STRPtoVenta As String
        Private _STRCodCliente As String
        Private _STRNomCliente As String
        Private _STRDireccion As String
        Private _STRRuc As String
        Private _DBLPrecioVenta As Double
        Private _STRFormaPago As String
        Private _DBLTipoCambio As Double
        Private _STRCodMoneda As String
        Private _STREstado As String
        Private _STRCodUsuario As String
        Private _STRComentario As String
        Private _DBLValorIGV As Double
        Private _DBLValorISC As Double
        Private _STREstatusPedido As String

        Public Sub New()
            _STRNumPedido = String.Empty
            _DTFechaPedido = Date.Now
            _DTFechaVencimiento = Date.Now
            _STRCodVendedor = String.Empty
            _STRPtoVenta = String.Empty
            _STRCodCliente = String.Empty
            _STRNomCliente = String.Empty
            _STRDireccion = String.Empty
            _STRRuc = String.Empty
            _DBLPrecioVenta = 0
            _STRFormaPago = String.Empty
            _DBLTipoCambio = 0
            _STRCodMoneda = String.Empty
            _STREstado = String.Empty
            _STRCodUsuario = String.Empty
            _STRComentario = String.Empty
            _DBLValorIGV = 0
            _DBLValorISC = 0
            _STREstatusPedido = String.Empty
        End Sub

        Public Property NumPedido As String
            Get
                Return _STRNumPedido
            End Get
            Set(value As String)
                _STRNumPedido = value
            End Set
        End Property

        Public Property EstatusPedido As String
            Get
                Return _STREstatusPedido
            End Get
            Set(value As String)
                _STREstatusPedido = value
            End Set
        End Property

        Public Property ValorISC As Double
            Get
                Return _DBLValorISC
            End Get
            Set(value As Double)
                _DBLValorISC = value
            End Set
        End Property

        Public Property ValorIGV As Double
            Get
                Return _DBLValorIGV
            End Get
            Set(value As Double)
                _DBLValorIGV = value
            End Set
        End Property

        Public Property Comentario As String
            Get
                Return _STRComentario
            End Get
            Set(value As String)
                _STRComentario = value
            End Set
        End Property

        Public Property CodUsuario As String
            Get
                Return _STRCodUsuario
            End Get
            Set(value As String)
                _STRCodUsuario = value
            End Set
        End Property

        Public Property Estado As String
            Get
                Return _STREstado
            End Get
            Set(value As String)
                _STREstado = value
            End Set
        End Property

        Public Property CodMoneda As String
            Get
                Return _STRCodMoneda
            End Get
            Set(value As String)
                _STRCodMoneda = value
            End Set
        End Property

        Public Property TipoCambio As Double
            Get
                Return _DBLTipoCambio
            End Get
            Set(value As Double)
                _DBLTipoCambio = value
            End Set
        End Property

        Public Property FormaPago As String
            Get
                Return _STRFormaPago
            End Get
            Set(value As String)
                _STRFormaPago = value
            End Set
        End Property

        Public Property PrecioVenta As Double
            Get
                Return _DBLPrecioVenta
            End Get
            Set(value As Double)
                _DBLPrecioVenta = value
            End Set
        End Property

        Public Property Ruc As String
            Get
                Return _STRRuc
            End Get
            Set(value As String)
                _STRRuc = value
            End Set
        End Property

        Public Property Direccion As String
            Get
                Return _STRDireccion
            End Get
            Set(value As String)
                _STRDireccion = value
            End Set
        End Property

        Public Property NomCliente As String
            Get
                Return _STRNomCliente
            End Get
            Set(value As String)
                _STRNomCliente = value
            End Set
        End Property

        Public Property CodCliente As String
            Get
                Return _STRCodCliente
            End Get
            Set(value As String)
                _STRCodCliente = value
            End Set
        End Property

        Public Property FechaPedido As Date
            Get
                Return _DTFechaPedido
            End Get
            Set(value As Date)
                _DTFechaPedido = value
            End Set
        End Property

        Public Property FechaVencimiento As Date
            Get
                Return _DTFechaVencimiento
            End Get
            Set(value As Date)
                _DTFechaVencimiento = value
            End Set
        End Property

        Public Property CodVendedor As String
            Get
                Return _STRCodVendedor
            End Get
            Set(value As String)
                _STRCodVendedor = value
            End Set
        End Property

        Public Property PtoVenta As String
            Get
                Return _STRPtoVenta
            End Get
            Set(value As String)
                _STRPtoVenta = value
            End Set
        End Property


    End Class

    Public Class Det_Pedidos_TO
        Private _STRItem As String
        Private _STRCodParte As String
        Private _STRDescripcionParte As String
        Private _DBLCantidad As Double
        Private _DBLPrecio As Double
        Private _DBLPrecioCalculo As Double
        Private _DBLMontoIGV As Double
        Private _DBLPorIGV As Double
        Private _DBLMontoISC As Double
        Private _DBLPorISC As Double
        Private _DBLMontoDolares As Double
        Private _DBLMontoSoles As Double
        Private _STRCodAlmacen As String
        Private _STRSerieLote As String
        Private _STRUniMed As String

        Public Sub New()
            _STRItem = String.Empty
            _STRCodParte = String.Empty
            _STRDescripcionParte = String.Empty
            _DBLCantidad = 0
            _DBLPrecio = 0
            _DBLPrecioCalculo = 0
            _DBLMontoIGV = 0
            _DBLPorIGV = 0
            _DBLMontoISC = 0
            _DBLPorISC = 0
            _DBLMontoDolares = 0
            _DBLMontoSoles = 0
            _STRCodAlmacen = String.Empty
            _STRSerieLote = String.Empty
            _STRUniMed = String.Empty
        End Sub

        Public Property UniMed As String
            Get
                Return _STRUniMed
            End Get
            Set(value As String)
                _STRUniMed = value
            End Set
        End Property

        Public Property SerieLote As String
            Get
                Return _STRSerieLote
            End Get
            Set(value As String)
                _STRSerieLote = value
            End Set
        End Property

        Public Property CodAlmacen As String
            Get
                Return _STRCodAlmacen
            End Get
            Set(value As String)
                _STRCodAlmacen = value
            End Set
        End Property

        Public Property MontoSoles As Double
            Get
                Return _DBLMontoSoles
            End Get
            Set(value As Double)
                _DBLMontoSoles = value
            End Set
        End Property

        Public Property MontoDolares As Double
            Get
                Return _DBLMontoDolares
            End Get
            Set(value As Double)
                _DBLMontoDolares = value
            End Set
        End Property
        Public Property PorISC As Double
            Get
                Return _DBLPorISC
            End Get
            Set(value As Double)
                _DBLPorISC = value
            End Set
        End Property

        Public Property MontoISC As Double
            Get
                Return _DBLMontoISC
            End Get
            Set(value As Double)
                _DBLMontoISC = value
            End Set
        End Property

        Public Property PorIGV As Double
            Get
                Return _DBLPorIGV
            End Get
            Set(value As Double)
                _DBLPorIGV = value
            End Set
        End Property

        Public Property MontoIGV As Double
            Get
                Return _DBLMontoIGV
            End Get
            Set(value As Double)
                _DBLMontoIGV = value
            End Set
        End Property
        Public Property PrecioCalculo As Double
            Get
                Return _DBLPrecioCalculo
            End Get
            Set(value As Double)
                _DBLPrecioCalculo = value
            End Set
        End Property

        Public Property Precio As Double
            Get
                Return _DBLPrecio
            End Get
            Set(value As Double)
                _DBLPrecio = value
            End Set
        End Property

        Public Property Cantidad As Double
            Get
                Return _DBLCantidad
            End Get
            Set(value As Double)
                _DBLCantidad = value
            End Set
        End Property

        Public Property DescripcionParte As String
            Get
                Return _STRDescripcionParte
            End Get
            Set(value As String)
                _STRDescripcionParte = value
            End Set
        End Property

        Public Property CodParte As String
            Get
                Return _STRCodParte
            End Get
            Set(value As String)
                _STRCodParte = value
            End Set
        End Property

        Public Property Item As String
            Get
                Return _STRItem
            End Get
            Set(value As String)
                _STRItem = value
            End Set
        End Property
    End Class
End Class
