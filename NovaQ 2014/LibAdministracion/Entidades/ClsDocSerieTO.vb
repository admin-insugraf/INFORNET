Public Class ClsDocSerieTO

    Public Class Cab_Pto_Venta
        Private _STRCodPtoVenta As String
        Private _STRDescripcion As String
        Private _STRDireccion As String
        Private _STRCodAlmacen As String

        Public Sub New()
            _STRCodPtoVenta = String.Empty
            _STRDescripcion = String.Empty
            _STRDireccion = String.Empty
            _STRCodAlmacen = String.Empty
        End Sub

        Public Property CodPtoVenta As String
            Get
                Return _STRCodPtoVenta
            End Get
            Set(value As String)
                _STRCodPtoVenta = value
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

        Public Property Direccion As String
            Get
                Return _STRDireccion
            End Get
            Set(value As String)
                _STRDireccion = value
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
    End Class

    Public Class Det_Doc_Serie
        Private _STRTipoDoc As String
        Private _STRSerie As String

        Public Sub New()
            _STRTipoDoc = String.Empty
            _STRSerie = String.Empty
        End Sub

        Public Property TipoDoc As String
            Get
                Return _STRTipoDoc
            End Get
            Set(value As String)
                _STRTipoDoc = value
            End Set
        End Property

        Public Property Serie As String
            Get
                Return _STRSerie
            End Get
            Set(value As String)
                _STRSerie = value
            End Set
        End Property
    End Class

    
End Class
