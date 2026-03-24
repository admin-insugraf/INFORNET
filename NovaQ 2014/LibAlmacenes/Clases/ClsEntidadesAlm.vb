Public Class ClsEntidadesAlm

    Public Class GUIA_DEVOLUCION
        Private _ID As String
        Private _TYPE As String
        Private _REQUIRED_USER As String
        Private _COMMENT As String
        Private _AREA_ID As String
        Private _STATUS As String
        Private _USER_ID As String
        Private _PROJECT_ID As String
        Private _REQUIRED_DATE As Date
        Private _CREATE_DATE As Date
        Private _UPDATE_DATE As Date

        Private _RESP_COMPRAS As String

        Private _AMOUNT As Double
        Private _AMOUNT_ME As Double

        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _LOTE As String
        Private _VCTO_LOTE As String
        Private _CANTIDAD As Double
        Private _NUMERO_OP As String

        Public Property NUMERO_OP As String
            Get
                Return _NUMERO_OP
            End Get
            Set(value As String)
                _NUMERO_OP = value
            End Set
        End Property

        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property
        Public Property PART_DESCRIPTION As String
            Get
                Return _PART_DESCRIPTION
            End Get
            Set(value As String)
                _PART_DESCRIPTION = value
            End Set
        End Property
        Public Property LOTE As String
            Get
                Return _LOTE
            End Get
            Set(value As String)
                _LOTE = value
            End Set
        End Property
        Public Property VCTO_LOTE As String
            Get
                Return _VCTO_LOTE
            End Get
            Set(value As String)
                _VCTO_LOTE = value
            End Set
        End Property
        Public Property CANTIDAD As Double
            Get
                Return _CANTIDAD
            End Get
            Set(value As Double)
                _CANTIDAD = value
            End Set
        End Property
        Public Property AMOUNT As Double
            Get
                Return _AMOUNT
            End Get
            Set(value As Double)
                _AMOUNT = value
            End Set
        End Property
        Public Property AMOUNT_ME As Double
            Get
                Return _AMOUNT_ME
            End Get
            Set(value As Double)
                _AMOUNT_ME = value
            End Set
        End Property


        Public Property RESP_COMPRAS As String
            Get
                Return _RESP_COMPRAS
            End Get
            Set(value As String)
                _RESP_COMPRAS = value
            End Set
        End Property

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property REQUIRED_USER As String
            Get
                Return _REQUIRED_USER
            End Get
            Set(value As String)
                _REQUIRED_USER = value
            End Set
        End Property

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property AREA_ID As String
            Get
                Return _AREA_ID
            End Get
            Set(value As String)
                _AREA_ID = value
            End Set
        End Property

        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
            End Set
        End Property

        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property

        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property

        Public Property REQUIRED_DATE As Date
            Get
                Return _REQUIRED_DATE
            End Get
            Set(value As Date)
                _REQUIRED_DATE = value
            End Set
        End Property

        Public Property CREATE_DATE As Date
            Get
                Return _CREATE_DATE
            End Get
            Set(value As Date)
                _CREATE_DATE = value
            End Set
        End Property

        Public Property UPDATE_DATE As Date
            Get
                Return _UPDATE_DATE
            End Get
            Set(value As Date)
                _UPDATE_DATE = value
            End Set
        End Property


    End Class

    Public Class GUIA_DEVOLUCION_LINE

        Private _ID As String
        Private _TYPE As String
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _UNIT As String
        Private _STATUS As String
        Private _PROJECT_ID As String
        Private _CCOST_ID As String

        Private _DOCUMENT_DATE As Date

        Private _AMOUNT_BALANCE As Double
        Private _COMMENT As String
        Private _COMMENT_RM As String
        Private _QTY As Double
        Private _COD_PRIORIDAD As String
        Private _ID_VENDOR As String
        Private _COD_PRIORIDAD_RM As String
        Private _N_ANALISIS As String

        Public Property N_ANALISIS As String
            Get
                Return _N_ANALISIS
            End Get
            Set(value As String)
                _N_ANALISIS = value
            End Set
        End Property
        Public Property COMMENT_RM As String
            Get
                Return _COMMENT_RM
            End Get
            Set(value As String)
                _COMMENT_RM = value
            End Set

        End Property

        Public Property COD_PRIORIDAD_RM As String
            Get
                Return _COD_PRIORIDAD_RM
            End Get
            Set(value As String)
                _COD_PRIORIDAD_RM = value
            End Set

        End Property

        Public Property ID_VENDOR As String
            Get
                Return _ID_VENDOR
            End Get
            Set(value As String)
                _ID_VENDOR = value
            End Set

        End Property

        Public Property COD_PRIORIDAD As String
            Get
                Return _COD_PRIORIDAD
            End Get
            Set(value As String)
                _COD_PRIORIDAD = value
            End Set
        End Property



        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property

        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property

        Public Property PART_DESCRIPTION As String
            Get
                Return _PART_DESCRIPTION
            End Get
            Set(value As String)
                _PART_DESCRIPTION = value
            End Set
        End Property

        Public Property UNIT As String
            Get
                Return _UNIT
            End Get
            Set(value As String)
                _UNIT = value
            End Set
        End Property

        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
            End Set
        End Property

        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property

        Public Property CCOST_ID As String
            Get
                Return _CCOST_ID
            End Get
            Set(value As String)
                _CCOST_ID = value
            End Set
        End Property

        Public Property DOCUMENT_DATE As Date
            Get
                Return _DOCUMENT_DATE
            End Get
            Set(value As Date)
                _DOCUMENT_DATE = value
            End Set
        End Property

        Public Property AMOUNT_BALANCE As Double
            Get
                Return _AMOUNT_BALANCE
            End Get
            Set(value As Double)
                _AMOUNT_BALANCE = value
            End Set
        End Property

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property QTY As Double
            Get
                Return _QTY
            End Get
            Set(value As Double)
                _QTY = value
            End Set

        End Property

    End Class

    Public Class REQUIREMENT_LINE

        Private _ID As String
        Private _TYPE As String
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _UNIT As String
        Private _STATUS As String
        Private _PROJECT_ID As String
        Private _CCOST_ID As String

        Private _DOCUMENT_DATE As Date

        Private _AMOUNT_BALANCE As Double
        Private _COMMENT As String
        Private _QTY As Double
        Private _COD_PRIORIDAD As String
        Private _ID_VENDOR As String
        Private _NUMERO_OP As String
        Private _MARCA As String
        Private _QTY_ALMACEN As Double
        Public Property MARCA As String
            Get
                Return _MARCA
            End Get
            Set(value As String)
                _MARCA = value
            End Set

        End Property
        Public Property QTY_ALMACEN As Double
            Get
                Return _QTY_ALMACEN
            End Get
            Set(value As Double)
                _QTY_ALMACEN = value
            End Set

        End Property

        Public Property NUMERO_OP As String
            Get
                Return _NUMERO_OP
            End Get
            Set(value As String)
                _NUMERO_OP = value
            End Set

        End Property

        Public Property ID_VENDOR As String
            Get
                Return _ID_VENDOR
            End Get
            Set(value As String)
                _ID_VENDOR = value
            End Set

        End Property

        Public Property COD_PRIORIDAD As String
            Get
                Return _COD_PRIORIDAD
            End Get
            Set(value As String)
                _COD_PRIORIDAD = value
            End Set
        End Property



        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property

        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property

        Public Property PART_DESCRIPTION As String
            Get
                Return _PART_DESCRIPTION
            End Get
            Set(value As String)
                _PART_DESCRIPTION = value
            End Set
        End Property

        Public Property UNIT As String
            Get
                Return _UNIT
            End Get
            Set(value As String)
                _UNIT = value
            End Set
        End Property

        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
            End Set
        End Property

        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property

        Public Property CCOST_ID As String
            Get
                Return _CCOST_ID
            End Get
            Set(value As String)
                _CCOST_ID = value
            End Set
        End Property

        Public Property DOCUMENT_DATE As Date
            Get
                Return _DOCUMENT_DATE
            End Get
            Set(value As Date)
                _DOCUMENT_DATE = value
            End Set
        End Property

        Public Property AMOUNT_BALANCE As Double
            Get
                Return _AMOUNT_BALANCE
            End Get
            Set(value As Double)
                _AMOUNT_BALANCE = value
            End Set
        End Property

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property QTY As Double
            Get
                Return _QTY
            End Get
            Set(value As Double)
                _QTY = value
            End Set

        End Property

    End Class

    Public Class REQUIREMENT_LINE_IMPRENTA

        Private _ID As String
        Private _TYPE As String
        Private _ITEM_PRODUCTO As Integer
        Private _ITEM As Integer
        Private _LOTE As String
        Private _VCTO As String
        Private _PRODUCTO As String

        Public Property VCTO As String
            Get
                Return _VCTO
            End Get
            Set(value As String)
                _VCTO = value
            End Set

        End Property
        Public Property LOTE As String
            Get
                Return _LOTE
            End Get
            Set(value As String)
                _LOTE = value
            End Set
        End Property
        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property
        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property
        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property
        Public Property ITEM_PRODUCTO As Integer
            Get
                Return _ITEM_PRODUCTO
            End Get
            Set(value As Integer)
                _ITEM_PRODUCTO = value
            End Set
        End Property

        Public Property PRODUCTO As String
            Get
                Return _PRODUCTO
            End Get
            Set(value As String)
                _PRODUCTO = value
            End Set
        End Property
    End Class

    Public Class REQUIREMENT_LINE_IMPRENTA_ME

        Private _ID As String
        Private _TYPE As String
        Private _ITEM_PRODUCTO As Integer
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _PART_UNIT As String
        Private _CANTIDAD As Double
        Private _PRODUCTO As String

        Public Property CANTIDAD As Double
            Get
                Return _CANTIDAD
            End Get
            Set(value As Double)
                _CANTIDAD = value
            End Set

        End Property
        Public Property PART_UNIT As String
            Get
                Return _PART_UNIT
            End Get
            Set(value As String)
                _PART_UNIT = value
            End Set
        End Property
        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property
        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property
        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property
        Public Property ITEM_PRODUCTO As Integer
            Get
                Return _ITEM_PRODUCTO
            End Get
            Set(value As Integer)
                _ITEM_PRODUCTO = value
            End Set
        End Property

        Public Property PRODUCTO As String
            Get
                Return _PRODUCTO
            End Get
            Set(value As String)
                _PRODUCTO = value
            End Set
        End Property

        Public Property PART_DESCRIPTION As String
            Get
                Return _PART_DESCRIPTION
            End Get
            Set(value As String)
                _PART_DESCRIPTION = value
            End Set
        End Property
        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property
    End Class

    Public Class REQUIREMENT
        Private _ID As String
        Private _TYPE As String
        Private _REQUIRED_USER As String
        Private _COMMENT As String
        Private _AREA_ID As String
        Private _STATUS As String
        Private _USER_ID As String
        Private _PROJECT_ID As String
        Private _REQUIRED_DATE As Date
        Private _CREATE_DATE As Date
        Private _UPDATE_DATE As Date
        Private _TIPO As String
        Private _SEDE As String

        Public Property TIPO As String
            Get
                Return _TIPO
            End Get
            Set(value As String)
                _TIPO = value
            End Set
        End Property
        Public Property SEDE As String
            Get
                Return _SEDE
            End Get
            Set(value As String)
                _SEDE = value
            End Set
        End Property

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property REQUIRED_USER As String
            Get
                Return _REQUIRED_USER
            End Get
            Set(value As String)
                _REQUIRED_USER = value
            End Set
        End Property

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property AREA_ID As String
            Get
                Return _AREA_ID
            End Get
            Set(value As String)
                _AREA_ID = value
            End Set
        End Property

        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
            End Set
        End Property

        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property

        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property

        Public Property REQUIRED_DATE As Date
            Get
                Return _REQUIRED_DATE
            End Get
            Set(value As Date)
                _REQUIRED_DATE = value
            End Set
        End Property

        Public Property CREATE_DATE As Date
            Get
                Return _CREATE_DATE
            End Get
            Set(value As Date)
                _CREATE_DATE = value
            End Set
        End Property

        Public Property UPDATE_DATE As Date
            Get
                Return _UPDATE_DATE
            End Get
            Set(value As Date)
                _UPDATE_DATE = value
            End Set
        End Property


    End Class

    Public Class PURCHASE_ORDER

        Private _ID As String
        Private _TYPE As String
        Private _VENDOR_ID As String
        Private _NUMBER_ESTIMATING As String
        Private _CURRENCY_TYPE As String
        Private _TERMS_NAME As String
        Private _COMMENT As String
        Private _AUTORIZED_ID As String
        Private _BUYER_PURCHASE_ID As String

        Private _TIME_DLV As String
        Private _ADDR_DLV As String
        Private _STATUS_ID As String
        Private _UPDATE_HOUR As String
        Private _USER_ID As String
        Private _CURR_EXCHANGE_TYPE As String
        Private _NAME_FACT As String
        Private _VAT_REGISTRATION_FACT As String
        Private _ADDR_FACT As String
        Private _REFER_DOCUMENT_TYPE As String
        Private _REFER_DOCUMENT_NUMBER As String
        Private _PROJECT_ID As String

        Private _DOCUMENT_DATE As Date
        Private _PROMISE_DATE As Date
        Private _UPDATE_DATE As Date

        Private _SELL_RATE As Double
        Private _AMOUNT As Double
        Private _DISCOUNT As Double
        Private _AMOUNT_TAX As Double
        Private _AMOUNT_SALES As Double
        Private _FLAG_PROMISE_DATE As String
        Private _AMOUNT_FLETE As Double
        Private _FLAG_FLETE_IGV As Integer
        Private _ORDEN_PARA_IMPORTACION As String
        Private _FECHA_INGRESO_IMPORTACION As String
        Private _NUMERO_DOC_IMPORTACION As String

        Private _PRIORIDAD As String
        Private _TIPO_ENTREGA As String
        Private _MODO_ENTREGA As String
        Public Property PRIORIDAD As String
            Get
                Return _PRIORIDAD
            End Get
            Set(value As String)
                _PRIORIDAD = value
            End Set
        End Property
        Public Property TIPO_ENTREGA As String
            Get
                Return _TIPO_ENTREGA
            End Get
            Set(value As String)
                _TIPO_ENTREGA = value
            End Set
        End Property
        Public Property MODO_ENTREGA As String
            Get
                Return _MODO_ENTREGA
            End Get
            Set(value As String)
                _MODO_ENTREGA = value
            End Set
        End Property

        Public Property NUMERO_DOC_IMPORTACION As String
            Get
                Return _NUMERO_DOC_IMPORTACION
            End Get
            Set(value As String)
                _NUMERO_DOC_IMPORTACION = value
            End Set
        End Property

        Public Property FECHA_INGRESO_IMPORTACION As String
            Get
                Return _FECHA_INGRESO_IMPORTACION
            End Get
            Set(value As String)
                _FECHA_INGRESO_IMPORTACION = value
            End Set
        End Property

        Public Property ORDEN_PARA_IMPORTACION As String
            Get
                Return _ORDEN_PARA_IMPORTACION
            End Get
            Set(value As String)
                _ORDEN_PARA_IMPORTACION = value
            End Set
        End Property

        Public Property FLAG_FLETE_IGV As Integer
            Get
                Return _FLAG_FLETE_IGV
            End Get
            Set(value As Integer)
                _FLAG_FLETE_IGV = value
            End Set
        End Property

        Public Property FLAG_PROMISE_DATE As String
            Get
                Return _FLAG_PROMISE_DATE
            End Get
            Set(value As String)
                _FLAG_PROMISE_DATE = value
            End Set
        End Property

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property VENDOR_ID As String
            Get
                Return _VENDOR_ID
            End Get
            Set(value As String)
                _VENDOR_ID = value
            End Set
        End Property

        Public Property NUMBER_ESTIMATING As String
            Get
                Return _NUMBER_ESTIMATING
            End Get
            Set(value As String)
                _NUMBER_ESTIMATING = value
            End Set
        End Property

        Public Property CURRENCY_TYPE As String
            Get
                Return _CURRENCY_TYPE
            End Get
            Set(value As String)
                _CURRENCY_TYPE = value
            End Set
        End Property

        Public Property TERMS_NAME As String
            Get
                Return _TERMS_NAME
            End Get
            Set(value As String)
                _TERMS_NAME = value
            End Set
        End Property

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property AUTORIZED_ID As String
            Get
                Return _AUTORIZED_ID
            End Get
            Set(value As String)
                _AUTORIZED_ID = value
            End Set
        End Property

        Public Property BUYER_PURCHASE_ID As String
            Get
                Return _BUYER_PURCHASE_ID
            End Get
            Set(value As String)
                _BUYER_PURCHASE_ID = value
            End Set
        End Property

        Public Property TIME_DLV As String
            Get
                Return _TIME_DLV
            End Get
            Set(value As String)
                _TIME_DLV = value
            End Set
        End Property

        Public Property ADDR_DLV As String
            Get
                Return _ADDR_DLV
            End Get
            Set(value As String)
                _ADDR_DLV = value
            End Set
        End Property

        Public Property STATUS_ID As String
            Get
                Return _STATUS_ID
            End Get
            Set(value As String)
                _STATUS_ID = value
            End Set
        End Property

        Public Property UPDATE_HOUR As String
            Get
                Return _UPDATE_HOUR
            End Get
            Set(value As String)
                _UPDATE_HOUR = value
            End Set
        End Property

        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property

        Public Property CURR_EXCHANGE_TYPE As String
            Get
                Return _CURR_EXCHANGE_TYPE
            End Get
            Set(value As String)
                _CURR_EXCHANGE_TYPE = value
            End Set
        End Property

        Public Property NAME_FACT As String
            Get
                Return _NAME_FACT
            End Get
            Set(value As String)
                _NAME_FACT = value
            End Set
        End Property

        Public Property VAT_REGISTRATION_FACT As String
            Get
                Return _VAT_REGISTRATION_FACT
            End Get
            Set(value As String)
                _VAT_REGISTRATION_FACT = value
            End Set
        End Property

        Public Property ADDR_FACT As String
            Get
                Return _ADDR_FACT
            End Get
            Set(value As String)
                _ADDR_FACT = value
            End Set
        End Property

        Public Property REFER_DOCUMENT_TYPE As String
            Get
                Return _REFER_DOCUMENT_TYPE
            End Get
            Set(value As String)
                _REFER_DOCUMENT_TYPE = value
            End Set
        End Property

        Public Property REFER_DOCUMENT_NUMBER As String
            Get
                Return _REFER_DOCUMENT_NUMBER
            End Get
            Set(value As String)
                _REFER_DOCUMENT_NUMBER = value
            End Set
        End Property

        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property

        Public Property DOCUMENT_DATE As Date
            Get
                Return _DOCUMENT_DATE
            End Get
            Set(value As Date)
                _DOCUMENT_DATE = value
            End Set
        End Property

        Public Property PROMISE_DATE As Date
            Get
                Return _PROMISE_DATE
            End Get
            Set(value As Date)
                _PROMISE_DATE = value
            End Set
        End Property

        Public Property UPDATE_DATE As Date
            Get
                Return _UPDATE_DATE
            End Get
            Set(value As Date)
                _UPDATE_DATE = value
            End Set
        End Property

        Public Property AMOUNT_FLETE As Double
            Get
                Return _AMOUNT_FLETE
            End Get
            Set(value As Double)
                _AMOUNT_FLETE = value
            End Set
        End Property

        Public Property SELL_RATE As Double
            Get
                Return _SELL_RATE
            End Get
            Set(value As Double)
                _SELL_RATE = value
            End Set
        End Property

        Public Property AMOUNT As Double
            Get
                Return _AMOUNT
            End Get
            Set(value As Double)
                _AMOUNT = value
            End Set
        End Property

        Public Property DISCOUNT As Double
            Get
                Return _DISCOUNT
            End Get
            Set(value As Double)
                _DISCOUNT = value
            End Set
        End Property

        Public Property AMOUNT_TAX As Double
            Get
                Return _AMOUNT_TAX
            End Get
            Set(value As Double)
                _AMOUNT_TAX = value
            End Set
        End Property

        Public Property AMOUNT_SALES As Double
            Get
                Return _AMOUNT_SALES
            End Get
            Set(value As Double)
                _AMOUNT_SALES = value
            End Set
        End Property

    End Class

    Public Class PURCHASE_ORDER_LINE
        Private _ID As String
        Private _TYPE As String
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _UNIT As String
        Private _UNIT_REFERENCE As String
        Private _STATUS_ID As String
        Private _COMMENT1 As String
        Private _TEXT_COMMENT As String

        Private _IS_VAT As String
        Private _CCOST_ID As String
        Private _PROJECT_ID As String
        Private _AREA_ID As String
        Private _COTI_ID As String
        Private _REQUI_ID As String

        Private _PRICE_UNIT As Double
        Private _FACTOR_REFERENCE As Double
        Private _QTY As Double
        Private _PRICE As Double
        Private _DISCOUNT_PER As Double
        Private _DISCOUNT As Double
        Private _AMOUNT_TAX As Double
        Private _PERCENT_TAX As Double
        Private _PRICE_NET As Double
        Private _AMOUNT_TOTAL As Double
        Private _AMOUNT_TOTAL_NET As Double
        Private _QTY_ENTER As Double
        Private _QTY_OUT As Double
        Private _ITEM As Integer

        Private _FLAG_FREE_IGV As Integer

        Private _QTY_ORIGINAL As Double
        Private _EQUIVALENCIA As Double
        Private _UNIT_PROVEEDOR As String
        Private _CECOS As String

        Public Property CECOS As String
            Get
                Return _CECOS
            End Get
            Set(value As String)
                _CECOS = value
            End Set
        End Property

        Public Property UNIT_PROVEEDOR As String
            Get
                Return _UNIT_PROVEEDOR
            End Get
            Set(value As String)
                _UNIT_PROVEEDOR = value
            End Set
        End Property

        Public Property QTY_ORIGINAL As Double
            Get
                Return _QTY_ORIGINAL
            End Get
            Set(value As Double)
                _QTY_ORIGINAL = value
            End Set
        End Property

        Public Property EQUIVALENCIA As Double
            Get
                Return _EQUIVALENCIA
            End Get
            Set(value As Double)
                _EQUIVALENCIA = value
            End Set
        End Property

        Public Property FLAG_FREE_IGV As Integer
            Get
                Return _FLAG_FREE_IGV
            End Get
            Set(value As Integer)
                _FLAG_FREE_IGV = value
            End Set
        End Property


        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property

        Public Property PART_DESCRIPTION As String
            Get
                Return _PART_DESCRIPTION
            End Get
            Set(value As String)
                _PART_DESCRIPTION = value
            End Set
        End Property

        Public Property UNIT As String
            Get
                Return _UNIT
            End Get
            Set(value As String)
                _UNIT = value
            End Set
        End Property

        Public Property UNIT_REFERENCE As String
            Get
                Return _UNIT_REFERENCE
            End Get
            Set(value As String)
                _UNIT_REFERENCE = value
            End Set
        End Property

        Public Property STATUS_ID As String
            Get
                Return _STATUS_ID
            End Get
            Set(value As String)
                _STATUS_ID = value
            End Set
        End Property

        Public Property COMMENT1 As String
            Get
                Return _COMMENT1
            End Get
            Set(value As String)
                _COMMENT1 = value
            End Set
        End Property

        Public Property TEXT_COMMENT As String
            Get
                Return _TEXT_COMMENT
            End Get
            Set(value As String)
                _TEXT_COMMENT = value
            End Set
        End Property

        Public Property IS_VAT As String
            Get
                Return _IS_VAT
            End Get
            Set(value As String)
                _IS_VAT = value
            End Set
        End Property

        Public Property CCOST_ID As String
            Get
                Return _CCOST_ID
            End Get
            Set(value As String)
                _CCOST_ID = value
            End Set
        End Property

        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property

        Public Property AREA_ID As String
            Get
                Return _AREA_ID
            End Get
            Set(value As String)
                _AREA_ID = value
            End Set
        End Property

        Public Property COTI_ID As String
            Get
                Return _COTI_ID
            End Get
            Set(value As String)
                _COTI_ID = value
            End Set
        End Property

        Public Property REQUI_ID As String
            Get
                Return _REQUI_ID
            End Get
            Set(value As String)
                _REQUI_ID = value
            End Set
        End Property

        Public Property PRICE_UNIT As Double
            Get
                Return _PRICE_UNIT
            End Get
            Set(value As Double)
                _PRICE_UNIT = value
            End Set
        End Property

        Public Property FACTOR_REFERENCE As Double
            Get
                Return _FACTOR_REFERENCE
            End Get
            Set(value As Double)
                _FACTOR_REFERENCE = value
            End Set
        End Property

        Public Property QTY As Double
            Get
                Return _QTY
            End Get
            Set(value As Double)
                _QTY = value
            End Set
        End Property

        Public Property PRICE As Double
            Get
                Return _PRICE
            End Get
            Set(value As Double)
                _PRICE = value
            End Set
        End Property

        Public Property DISCOUNT_PER As Double
            Get
                Return _DISCOUNT_PER
            End Get
            Set(value As Double)
                _DISCOUNT_PER = value
            End Set
        End Property

        Public Property DISCOUNT As Double
            Get
                Return _DISCOUNT
            End Get
            Set(value As Double)
                _DISCOUNT = value
            End Set
        End Property

        Public Property AMOUNT_TAX As Double
            Get
                Return _AMOUNT_TAX
            End Get
            Set(value As Double)
                _AMOUNT_TAX = value
            End Set
        End Property

        Public Property PERCENT_TAX As Double
            Get
                Return _PERCENT_TAX
            End Get
            Set(value As Double)
                _PERCENT_TAX = value
            End Set
        End Property

        Public Property PRICE_NET As Double
            Get
                Return _PRICE_NET
            End Get
            Set(value As Double)
                _PRICE_NET = value
            End Set
        End Property

        Public Property AMOUNT_TOTAL As Double
            Get
                Return _AMOUNT_TOTAL
            End Get
            Set(value As Double)
                _AMOUNT_TOTAL = value
            End Set
        End Property

        Public Property AMOUNT_TOTAL_NET As Double
            Get
                Return _AMOUNT_TOTAL_NET
            End Get
            Set(value As Double)
                _AMOUNT_TOTAL_NET = value
            End Set
        End Property

        Public Property QTY_ENTER As Double
            Get
                Return _QTY_ENTER
            End Get
            Set(value As Double)
                _QTY_ENTER = value
            End Set
        End Property

        Public Property QTY_OUT As Double
            Get
                Return _QTY_OUT
            End Get
            Set(value As Double)
                _QTY_OUT = value
            End Set
        End Property

        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property
    End Class

    Public Class PURCHASE_ORDER_LINE_LOTES

        Private _ID As String
        Private _TYPE As String
        Private _ITEM_PRODUCTO As Integer
        Private _ITEM_ME As Integer
        Private _ITEM As Integer
        Private _PART_ID_ME As String
        Private _COD_PRODUCTO As String
        Private _REQUI_ID As String


        Public Property PART_ID_ME As String
            Get
                Return _PART_ID_ME
            End Get
            Set(value As String)
                _PART_ID_ME = value
            End Set
        End Property
        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property
        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property
        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property
        Public Property ITEM_PRODUCTO As Integer
            Get
                Return _ITEM_PRODUCTO
            End Get
            Set(value As Integer)
                _ITEM_PRODUCTO = value
            End Set
        End Property
        Public Property ITEM_ME As Integer
            Get
                Return _ITEM_ME
            End Get
            Set(value As Integer)
                _ITEM_ME = value
            End Set
        End Property

        Public Property COD_PRODUCTO As String
            Get
                Return _COD_PRODUCTO
            End Get
            Set(value As String)
                _COD_PRODUCTO = value
            End Set
        End Property

        Public Property REQUI_ID As String
            Get
                Return _REQUI_ID
            End Get
            Set(value As String)
                _REQUI_ID = value
            End Set
        End Property
    End Class

    Public Class PURCHASE_FACT_SUPPLIER_IMPORT

        Private _ID As Integer
        Private _VENDOR_ID As String
        Private _INVOICE As String
        Private _FECHA_INVOICE As String
        Private _NRO_DAM As String
        Private _FECHA_DAM As String
        Private _CURRENCY_TYPE As String
        Private _SELL_RATE As Double
        Private _COMMENT As String
        Private _USER_ID As String
        Private _STATUS_ID As String

        Public Property ID As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
            End Set
        End Property
        Public Property VENDOR_ID As String
            Get
                Return _VENDOR_ID
            End Get
            Set(value As String)
                _VENDOR_ID = value
            End Set
        End Property
        Public Property INVOICE As String
            Get
                Return _INVOICE
            End Get
            Set(value As String)
                _INVOICE = value
            End Set
        End Property
        Public Property FECHA_INVOICE As String
            Get
                Return _FECHA_INVOICE
            End Get
            Set(value As String)
                _FECHA_INVOICE = value
            End Set
        End Property
        Public Property NRO_DAM As String
            Get
                Return _NRO_DAM
            End Get
            Set(value As String)
                _NRO_DAM = value
            End Set
        End Property
        Public Property FECHA_DAM As String
            Get
                Return _FECHA_DAM
            End Get
            Set(value As String)
                _FECHA_DAM = value
            End Set
        End Property
        Public Property CURRENCY_TYPE As String
            Get
                Return _CURRENCY_TYPE
            End Get
            Set(value As String)
                _CURRENCY_TYPE = value
            End Set
        End Property
        Public Property SELL_RATE As Double
            Get
                Return _SELL_RATE
            End Get
            Set(value As Double)
                _SELL_RATE = value
            End Set
        End Property
        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property
        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property
        Public Property STATUS_ID As String
            Get
                Return _STATUS_ID
            End Get
            Set(value As String)
                _STATUS_ID = value
            End Set
        End Property
    End Class

    Public Class PURCHASE_FACT_SUPPLIER_LINE_IMPORT

        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _UNIT As String
        Private _DAM As String
        Private _QTY As Double
        Private _PRICE As Double
        Private _PRICE_TOTAL As Double
        Private _AD_VALOREM2 As Double
        Private _ISC As Double
        Private _IGV As Double
        Private _IPM As Double
        Private _DERECHOS_ESPECIFICOS As Double
        Private _DERECHOS_ANTIDUMPING As Double
        Private _SEGURO2 As Double
        Private _SOBRETASA_TRIBUTO As Double
        Private _SOBRETASA_SANCION As Double
        Private _PERCEPCION2 As Double
        Private _VALOR_REF_FLETE_DAM As Double
        Private _FLETE_DAM As Double
        Private _SEGURO_DAM As Double
        Private _AD_VALOREM_DAM As Double
        Private _IGV_DAM As Double
        Private _IPM_DAM As Double
        Private _PERCEPCION_DAM As Double

        Private _COMISION_AGENCIA_ADUANAS2 As Double
        Private _GASTOS_OPERATIVOS As Double
        Private _GASTOS_ADMINISTRATIVOS As Double
        Private _HANDLING_DESTINO As Double
        Private _TRANSMISION_MANIFIESTO As Double
        Private _GASTOS_OPERACIONAL_DESTINO As Double
        Private _SEGURO3 As Double
        Private _ALMACEN As Double
        Private _VISTOS_BUENOS As Double
        Private _DEVOLUCION_CONTENEDOR As Double
        Private _DESCONSOLIDACION As Double
        Private _REPARACION_CONTENEDOR As Double
        Private _RECTIFICACION_MANI As Double
        Private _FLETE_MARITIMO As Double
        Private _TRANSPORTE_TERRESTRE As Double
        Private _TC As Double
        Private _TOTAL_COSTO_AGENCIA_ADUANAS As Double
        Private _COSTO_INVOICE2_TOTAL As Double
        Private _COSTO_ADVALOREM_TOTAL As Double
        Private _COSTO_AGENCIA_ADUANA_TOTAL As Double
        Private _COSTO_TOTAL As Double
        Private _COSTO_UNITARIO As Double
        Private _COSTO_UNITARIO_SOLES As Double
        Public Property COMISION_AGENCIA_ADUANAS2 As Double
            Get
                Return _COMISION_AGENCIA_ADUANAS2
            End Get
            Set(value As Double)
                _COMISION_AGENCIA_ADUANAS2 = value
            End Set
        End Property
        Public Property GASTOS_OPERATIVOS As Double
            Get
                Return _GASTOS_OPERATIVOS
            End Get
            Set(value As Double)
                _GASTOS_OPERATIVOS = value
            End Set
        End Property
        Public Property GASTOS_ADMINISTRATIVOS As Double
            Get
                Return _GASTOS_ADMINISTRATIVOS
            End Get
            Set(value As Double)
                _GASTOS_ADMINISTRATIVOS = value
            End Set
        End Property
        Public Property HANDLING_DESTINO As Double
            Get
                Return _HANDLING_DESTINO
            End Get
            Set(value As Double)
                _HANDLING_DESTINO = value
            End Set
        End Property
        Public Property TRANSMISION_MANIFIESTO As Double
            Get
                Return _TRANSMISION_MANIFIESTO
            End Get
            Set(value As Double)
                _TRANSMISION_MANIFIESTO = value
            End Set
        End Property
        Public Property GASTOS_OPERACIONAL_DESTINO As Double
            Get
                Return _GASTOS_OPERACIONAL_DESTINO
            End Get
            Set(value As Double)
                _GASTOS_OPERACIONAL_DESTINO = value
            End Set
        End Property
        Public Property SEGURO3 As Double
            Get
                Return _SEGURO3
            End Get
            Set(value As Double)
                _SEGURO3 = value
            End Set
        End Property
        Public Property ALMACEN As Double
            Get
                Return _ALMACEN
            End Get
            Set(value As Double)
                _ALMACEN = value
            End Set
        End Property
        Public Property VISTOS_BUENOS As Double
            Get
                Return _VISTOS_BUENOS
            End Get
            Set(value As Double)
                _VISTOS_BUENOS = value
            End Set
        End Property
        Public Property DEVOLUCION_CONTENEDOR As Double
            Get
                Return _DEVOLUCION_CONTENEDOR
            End Get
            Set(value As Double)
                _DEVOLUCION_CONTENEDOR = value
            End Set
        End Property
        Public Property DESCONSOLIDACION As Double
            Get
                Return _DESCONSOLIDACION
            End Get
            Set(value As Double)
                _DESCONSOLIDACION = value
            End Set
        End Property
        Public Property REPARACION_CONTENEDOR As Double
            Get
                Return _REPARACION_CONTENEDOR
            End Get
            Set(value As Double)
                _REPARACION_CONTENEDOR = value
            End Set
        End Property
        Public Property RECTIFICACION_MANI As Double
            Get
                Return _RECTIFICACION_MANI
            End Get
            Set(value As Double)
                _RECTIFICACION_MANI = value
            End Set
        End Property
        Public Property FLETE_MARITIMO As Double
            Get
                Return _FLETE_MARITIMO
            End Get
            Set(value As Double)
                _FLETE_MARITIMO = value
            End Set
        End Property
        Public Property TRANSPORTE_TERRESTRE As Double
            Get
                Return _TRANSPORTE_TERRESTRE
            End Get
            Set(value As Double)
                _TRANSPORTE_TERRESTRE = value
            End Set
        End Property
        Public Property TC As Double
            Get
                Return _TC
            End Get
            Set(value As Double)
                _TC = value
            End Set
        End Property
        Public Property TOTAL_COSTO_AGENCIA_ADUANAS As Double
            Get
                Return _TOTAL_COSTO_AGENCIA_ADUANAS
            End Get
            Set(value As Double)
                _TOTAL_COSTO_AGENCIA_ADUANAS = value
            End Set
        End Property
        Public Property COSTO_INVOICE2_TOTAL As Double
            Get
                Return _COSTO_INVOICE2_TOTAL
            End Get
            Set(value As Double)
                _COSTO_INVOICE2_TOTAL = value
            End Set
        End Property
        Public Property COSTO_ADVALOREM_TOTAL As Double
            Get
                Return _COSTO_ADVALOREM_TOTAL
            End Get
            Set(value As Double)
                _COSTO_ADVALOREM_TOTAL = value
            End Set
        End Property
        Public Property COSTO_AGENCIA_ADUANA_TOTAL As Double
            Get
                Return _COSTO_AGENCIA_ADUANA_TOTAL
            End Get
            Set(value As Double)
                _COSTO_AGENCIA_ADUANA_TOTAL = value
            End Set
        End Property
        Public Property COSTO_TOTAL As Double
            Get
                Return _COSTO_TOTAL
            End Get
            Set(value As Double)
                _COSTO_TOTAL = value
            End Set
        End Property
        Public Property COSTO_UNITARIO As Double
            Get
                Return _COSTO_UNITARIO
            End Get
            Set(value As Double)
                _COSTO_UNITARIO = value
            End Set
        End Property
        Public Property COSTO_UNITARIO_SOLES As Double
            Get
                Return _COSTO_UNITARIO_SOLES
            End Get
            Set(value As Double)
                _COSTO_UNITARIO_SOLES = value
            End Set
        End Property

        Public Property ID_CAB As Integer
            Get
                Return _ID_CAB
            End Get
            Set(value As Integer)
                _ID_CAB = value
            End Set
        End Property
        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property
        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property
        Public Property PART_DESCRIPTION As String
            Get
                Return _PART_DESCRIPTION
            End Get
            Set(value As String)
                _PART_DESCRIPTION = value
            End Set
        End Property
        Public Property UNIT As String
            Get
                Return _UNIT
            End Get
            Set(value As String)
                _UNIT = value
            End Set
        End Property
        Public Property DAM As String
            Get
                Return _DAM
            End Get
            Set(value As String)
                _DAM = value
            End Set
        End Property
        Public Property QTY As Double
            Get
                Return _QTY
            End Get
            Set(value As Double)
                _QTY = value
            End Set
        End Property
        Public Property PRICE As Double
            Get
                Return _PRICE
            End Get
            Set(value As Double)
                _PRICE = value
            End Set
        End Property
        Public Property PRICE_TOTAL As Double
            Get
                Return _PRICE_TOTAL
            End Get
            Set(value As Double)
                _PRICE_TOTAL = value
            End Set
        End Property
        Public Property AD_VALOREM2 As Double
            Get
                Return _AD_VALOREM2
            End Get
            Set(value As Double)
                _AD_VALOREM2 = value
            End Set
        End Property
        Public Property ISC As Double
            Get
                Return _ISC
            End Get
            Set(value As Double)
                _ISC = value
            End Set
        End Property
        Public Property IGV As Double
            Get
                Return _IGV
            End Get
            Set(value As Double)
                _IGV = value
            End Set
        End Property
        Public Property IPM As Double
            Get
                Return _IPM
            End Get
            Set(value As Double)
                _IPM = value
            End Set
        End Property
        Public Property DERECHOS_ESPECIFICOS As Double
            Get
                Return _DERECHOS_ESPECIFICOS
            End Get
            Set(value As Double)
                _DERECHOS_ESPECIFICOS = value
            End Set
        End Property
        Public Property DERECHOS_ANTIDUMPING As Double
            Get
                Return _DERECHOS_ANTIDUMPING
            End Get
            Set(value As Double)
                _DERECHOS_ANTIDUMPING = value
            End Set
        End Property
        Public Property SEGURO2 As Double
            Get
                Return _SEGURO2
            End Get
            Set(value As Double)
                _SEGURO2 = value
            End Set
        End Property
        Public Property SOBRETASA_TRIBUTO As Double
            Get
                Return _SOBRETASA_TRIBUTO
            End Get
            Set(value As Double)
                _SOBRETASA_TRIBUTO = value
            End Set
        End Property
        Public Property SOBRETASA_SANCION As Double
            Get
                Return _SOBRETASA_SANCION
            End Get
            Set(value As Double)
                _SOBRETASA_SANCION = value
            End Set
        End Property
        Public Property PERCEPCION2 As Double
            Get
                Return _PERCEPCION2
            End Get
            Set(value As Double)
                _PERCEPCION2 = value
            End Set
        End Property
        Public Property VALOR_REF_FLETE_DAM As Double
            Get
                Return _VALOR_REF_FLETE_DAM
            End Get
            Set(value As Double)
                _VALOR_REF_FLETE_DAM = value
            End Set
        End Property
        Public Property FLETE_DAM As Double
            Get
                Return _FLETE_DAM
            End Get
            Set(value As Double)
                _FLETE_DAM = value
            End Set
        End Property
        Public Property SEGURO_DAM As Double
            Get
                Return _SEGURO_DAM
            End Get
            Set(value As Double)
                _SEGURO_DAM = value
            End Set
        End Property
        Public Property AD_VALOREM_DAM As Double
            Get
                Return _AD_VALOREM_DAM
            End Get
            Set(value As Double)
                _AD_VALOREM_DAM = value
            End Set
        End Property
        Public Property IGV_DAM As Double
            Get
                Return _IGV_DAM
            End Get
            Set(value As Double)
                _IGV_DAM = value
            End Set
        End Property
        Public Property IPM_DAM As Double
            Get
                Return _IPM_DAM
            End Get
            Set(value As Double)
                _IPM_DAM = value
            End Set
        End Property
        Public Property PERCEPCION_DAM As Double
            Get
                Return _PERCEPCION_DAM
            End Get
            Set(value As Double)
                _PERCEPCION_DAM = value
            End Set
        End Property
    End Class

    Public Class PURCHASE_FACT_SUPPLIER_LINE_IMPORT_GASTOS_VARIOS

        Private _ID_CAB As Integer
        Private _COMISION_AGENCIA_ADUANAS2 As Double
        Private _GASTOS_OPERATIVOS As Double
        Private _GASTOS_ADMINISTATIVOS As Double
        Private _HANDLING_DESTINO As Double
        Private _TRANSMISION_MANIFIESTO As Double
        Private _GASTOS_OPERACIONAL_DESTINO As Double
        Private _SEGURO3 As Double
        Private _ALMACEN As Double
        Private _VISTOS_BUENOS As Double
        Private _DEVOLUCION_CONTENEDOR As Double
        Private _DESCONSOLIDACION As Double
        Private _REPARACION_CONTENEDOR As Double
        Private _RECTIFICACION_MANI As Double
        Private _FLETE_MARITIMO As Double
        Private _TRANSPORTE_TERRESTRE As Double

        Public Property ID_CAB As Integer
            Get
                Return _ID_CAB
            End Get
            Set(value As Integer)
                _ID_CAB = value
            End Set
        End Property
        Public Property COMISION_AGENCIA_ADUANAS2 As Double
            Get
                Return _COMISION_AGENCIA_ADUANAS2
            End Get
            Set(value As Double)
                _COMISION_AGENCIA_ADUANAS2 = value
            End Set
        End Property
        Public Property GASTOS_OPERATIVOS As Double
            Get
                Return _GASTOS_OPERATIVOS
            End Get
            Set(value As Double)
                _GASTOS_OPERATIVOS = value
            End Set
        End Property
        Public Property GASTOS_ADMINISTATIVOS As Double
            Get
                Return _GASTOS_ADMINISTATIVOS
            End Get
            Set(value As Double)
                _GASTOS_ADMINISTATIVOS = value
            End Set
        End Property
        Public Property HANDLING_DESTINO As Double
            Get
                Return _HANDLING_DESTINO
            End Get
            Set(value As Double)
                _HANDLING_DESTINO = value
            End Set
        End Property
        Public Property TRANSMISION_MANIFIESTO As Double
            Get
                Return _TRANSMISION_MANIFIESTO
            End Get
            Set(value As Double)
                _TRANSMISION_MANIFIESTO = value
            End Set
        End Property
        Public Property GASTOS_OPERACIONAL_DESTINO As Double
            Get
                Return _GASTOS_OPERACIONAL_DESTINO
            End Get
            Set(value As Double)
                _GASTOS_OPERACIONAL_DESTINO = value
            End Set
        End Property
        Public Property SEGURO3 As Double
            Get
                Return _SEGURO3
            End Get
            Set(value As Double)
                _SEGURO3 = value
            End Set
        End Property
        Public Property ALMACEN As Double
            Get
                Return _ALMACEN
            End Get
            Set(value As Double)
                _ALMACEN = value
            End Set
        End Property
        Public Property VISTOS_BUENOS As Double
            Get
                Return _VISTOS_BUENOS
            End Get
            Set(value As Double)
                _VISTOS_BUENOS = value
            End Set
        End Property
        Public Property DEVOLUCION_CONTENEDOR As Double
            Get
                Return _DEVOLUCION_CONTENEDOR
            End Get
            Set(value As Double)
                _DEVOLUCION_CONTENEDOR = value
            End Set
        End Property
        Public Property DESCONSOLIDACION As Double
            Get
                Return _DESCONSOLIDACION
            End Get
            Set(value As Double)
                _DESCONSOLIDACION = value
            End Set
        End Property
        Public Property REPARACION_CONTENEDOR As Double
            Get
                Return _REPARACION_CONTENEDOR
            End Get
            Set(value As Double)
                _REPARACION_CONTENEDOR = value
            End Set
        End Property
        Public Property RECTIFICACION_MANI As Double
            Get
                Return _RECTIFICACION_MANI
            End Get
            Set(value As Double)
                _RECTIFICACION_MANI = value
            End Set
        End Property
        Public Property FLETE_MARITIMO As Double
            Get
                Return _FLETE_MARITIMO
            End Get
            Set(value As Double)
                _FLETE_MARITIMO = value
            End Set
        End Property
        Public Property TRANSPORTE_TERRESTRE As Double
            Get
                Return _TRANSPORTE_TERRESTRE
            End Get
            Set(value As Double)
                _TRANSPORTE_TERRESTRE = value
            End Set
        End Property

    End Class

    Public Class PURCHASE_FACT_SUPPLIER

        Private _ID As String
        Private _TYPE As String
        Private _VENDOR_ID As String
        Private _NUMBER_ESTIMATING As String
        Private _CURRENCY_TYPE As String
        Private _TERMS_NAME As String
        Private _COMMENT As String
        Private _AUTORIZED_ID As String
        Private _BUYER_PURCHASE_ID As String

        Private _TIME_DLV As String
        Private _ADDR_DLV As String
        Private _STATUS_ID As String
        Private _UPDATE_HOUR As String
        Private _USER_ID As String
        Private _CURR_EXCHANGE_TYPE As String
        Private _NAME_FACT As String
        Private _VAT_REGISTRATION_FACT As String
        Private _ADDR_FACT As String
        Private _REFER_DOCUMENT_TYPE As String
        Private _REFER_DOCUMENT_NUMBER As String
        Private _PROJECT_ID As String

        Private _DOCUMENT_DATE As Date
        Private _PROMISE_DATE As Date
        Private _UPDATE_DATE As Date

        Private _SELL_RATE As Double
        Private _AMOUNT As Double
        Private _AMOUNT_INAFECTO As Double
        Private _DISCOUNT As Double
        Private _AMOUNT_TAX As Double
        Private _AMOUNT_SALES As Double

        Private _SERIE As String
        Private _BUDGET_ID As String
        Private _ORDER_BUY_ID As String
        Private _NOTE_IN_ID As String
        Private _WAREHOUSE_ID As String
        Private _TYPE_DESTINE As String

        Private _REFER_DOCUMENT_DATE As Date
        Private _CREATE_DATE As Date
        Private _EXPIRATION_DATE As Date
        Private _PERCENT_DETRAC As Double

        Private _COM_PER_ID As String
        Private _COM_PER_TD As String
        Private _COM_PER_SERIE As String
        Private _COM_PER_NUMERO As String
        Private _COM_PER_PERCENT As Double
        Private _COM_PER_DATE_EMISION As Date
        Private _COM_PER_DATE_VCTO As Date

        Private _TD_AN As String
        Private _SERIE_AN As String
        Private _NUMERO_AN As String
        Private _FECHA_AN As String
        Private _MONTO_AN As Double
        Private _CENTRO_DE_COSTOS As String
        Private _NUM_ORDER_PAGO As String
        Private _IS_IMPORTATION As String

        Private _DETRAC_DATE As String
        Private _DETRAC_NUMBER As String

        Private _ID_CAJA_CHICA As String
        Private _ITEM_CAJA_CHICA As String
        Private _ITEM As String

        Public Property DETRAC_DATE As String
            Get
                Return _DETRAC_DATE
            End Get
            Set(value As String)
                _DETRAC_DATE = value
            End Set
        End Property

        Public Property DETRAC_NUMBER As String
            Get
                Return _DETRAC_NUMBER
            End Get
            Set(value As String)
                _DETRAC_NUMBER = value
            End Set
        End Property


        Public Property IS_IMPORTATION As String
            Get
                Return _IS_IMPORTATION
            End Get
            Set(value As String)
                _IS_IMPORTATION = value
            End Set
        End Property

        Public Property ID_CAJA_CHICA As String
            Get
                Return _ID_CAJA_CHICA
            End Get
            Set(value As String)
                _ID_CAJA_CHICA = value
            End Set
        End Property
        Public Property ITEM_CAJA_CHICA As String
            Get
                Return _ITEM_CAJA_CHICA
            End Get
            Set(value As String)
                _ITEM_CAJA_CHICA = value
            End Set
        End Property
        Public Property ITEM As String
            Get
                Return _ITEM
            End Get
            Set(value As String)
                _ITEM = value
            End Set
        End Property
        Public Property AMOUNT_INAFECTO As Double
            Get
                Return _AMOUNT_INAFECTO
            End Get
            Set(value As Double)
                _AMOUNT_INAFECTO = value
            End Set
        End Property

        Public Property NUM_ORDER_PAGO As String
            Get
                Return _NUM_ORDER_PAGO
            End Get
            Set(value As String)
                _NUM_ORDER_PAGO = value
            End Set
        End Property


        Public Property CENTRO_DE_COSTOS As String
            Get
                Return _CENTRO_DE_COSTOS
            End Get
            Set(value As String)
                _CENTRO_DE_COSTOS = value
            End Set
        End Property

        Public Property SERIE As String
            Get
                Return _SERIE
            End Get
            Set(value As String)
                _SERIE = value
            End Set
        End Property

        Public Property TD_AN As String
            Get
                Return _TD_AN
            End Get
            Set(value As String)
                _TD_AN = value
            End Set
        End Property

        Public Property SERIE_AN As String
            Get
                Return _SERIE_AN
            End Get
            Set(value As String)
                _SERIE_AN = value
            End Set
        End Property
        Public Property NUMERO_AN As String
            Get
                Return _NUMERO_AN
            End Get
            Set(value As String)
                _NUMERO_AN = value
            End Set
        End Property
        Public Property FECHA_AN As String
            Get
                Return _FECHA_AN
            End Get
            Set(value As String)
                _FECHA_AN = value
            End Set
        End Property

        Public Property MONTO_AN As Double
            Get
                Return _MONTO_AN
            End Get
            Set(value As Double)
                _MONTO_AN = value
            End Set
        End Property

        Public Property BUDGET_ID As String
            Get
                Return _BUDGET_ID
            End Get
            Set(value As String)
                _BUDGET_ID = value
            End Set
        End Property

        Public Property ORDER_BUY_ID As String
            Get
                Return _ORDER_BUY_ID
            End Get
            Set(value As String)
                _ORDER_BUY_ID = value
            End Set
        End Property

        Public Property NOTE_IN_ID As String
            Get
                Return _NOTE_IN_ID
            End Get
            Set(value As String)
                _NOTE_IN_ID = value
            End Set
        End Property

        Public Property WAREHOUSE_ID As String
            Get
                Return _WAREHOUSE_ID
            End Get
            Set(value As String)
                _WAREHOUSE_ID = value
            End Set
        End Property

        Public Property TYPE_DESTINE As String
            Get
                Return _TYPE_DESTINE
            End Get
            Set(value As String)
                _TYPE_DESTINE = value
            End Set
        End Property

        Public Property REFER_DOCUMENT_DATE As Date
            Get
                Return _REFER_DOCUMENT_DATE
            End Get
            Set(value As Date)
                _REFER_DOCUMENT_DATE = value
            End Set
        End Property

        Public Property CREATE_DATE As Date
            Get
                Return _CREATE_DATE
            End Get
            Set(value As Date)
                _CREATE_DATE = value
            End Set
        End Property

        Public Property COM_PER_DATE_EMISION As Date
            Get
                Return _COM_PER_DATE_EMISION
            End Get
            Set(value As Date)
                _COM_PER_DATE_EMISION = value
            End Set
        End Property

        Public Property COM_PER_DATE_VCTO As Date
            Get
                Return _COM_PER_DATE_VCTO
            End Get
            Set(value As Date)
                _COM_PER_DATE_VCTO = value
            End Set
        End Property

        Public Property EXPIRATION_DATE As Date
            Get
                Return _EXPIRATION_DATE
            End Get
            Set(value As Date)
                _EXPIRATION_DATE = value
            End Set
        End Property

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property VENDOR_ID As String
            Get
                Return _VENDOR_ID
            End Get
            Set(value As String)
                _VENDOR_ID = value
            End Set
        End Property

        Public Property NUMBER_ESTIMATING As String
            Get
                Return _NUMBER_ESTIMATING
            End Get
            Set(value As String)
                _NUMBER_ESTIMATING = value
            End Set
        End Property

        Public Property CURRENCY_TYPE As String
            Get
                Return _CURRENCY_TYPE
            End Get
            Set(value As String)
                _CURRENCY_TYPE = value
            End Set
        End Property

        Public Property TERMS_NAME As String
            Get
                Return _TERMS_NAME
            End Get
            Set(value As String)
                _TERMS_NAME = value
            End Set
        End Property

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property AUTORIZED_ID As String
            Get
                Return _AUTORIZED_ID
            End Get
            Set(value As String)
                _AUTORIZED_ID = value
            End Set
        End Property

        Public Property BUYER_PURCHASE_ID As String
            Get
                Return _BUYER_PURCHASE_ID
            End Get
            Set(value As String)
                _BUYER_PURCHASE_ID = value
            End Set
        End Property

        Public Property TIME_DLV As String
            Get
                Return _TIME_DLV
            End Get
            Set(value As String)
                _TIME_DLV = value
            End Set
        End Property

        Public Property ADDR_DLV As String
            Get
                Return _ADDR_DLV
            End Get
            Set(value As String)
                _ADDR_DLV = value
            End Set
        End Property

        Public Property STATUS_ID As String
            Get
                Return _STATUS_ID
            End Get
            Set(value As String)
                _STATUS_ID = value
            End Set
        End Property

        Public Property UPDATE_HOUR As String
            Get
                Return _UPDATE_HOUR
            End Get
            Set(value As String)
                _UPDATE_HOUR = value
            End Set
        End Property

        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property

        Public Property CURR_EXCHANGE_TYPE As String
            Get
                Return _CURR_EXCHANGE_TYPE
            End Get
            Set(value As String)
                _CURR_EXCHANGE_TYPE = value
            End Set
        End Property

        Public Property NAME_FACT As String
            Get
                Return _NAME_FACT
            End Get
            Set(value As String)
                _NAME_FACT = value
            End Set
        End Property

        Public Property VAT_REGISTRATION_FACT As String
            Get
                Return _VAT_REGISTRATION_FACT
            End Get
            Set(value As String)
                _VAT_REGISTRATION_FACT = value
            End Set
        End Property

        Public Property ADDR_FACT As String
            Get
                Return _ADDR_FACT
            End Get
            Set(value As String)
                _ADDR_FACT = value
            End Set
        End Property

        Public Property REFER_DOCUMENT_TYPE As String
            Get
                Return _REFER_DOCUMENT_TYPE
            End Get
            Set(value As String)
                _REFER_DOCUMENT_TYPE = value
            End Set
        End Property

        Public Property REFER_DOCUMENT_NUMBER As String
            Get
                Return _REFER_DOCUMENT_NUMBER
            End Get
            Set(value As String)
                _REFER_DOCUMENT_NUMBER = value
            End Set
        End Property

        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property

        Public Property DOCUMENT_DATE As Date
            Get
                Return _DOCUMENT_DATE
            End Get
            Set(value As Date)
                _DOCUMENT_DATE = value
            End Set
        End Property

        Public Property PROMISE_DATE As Date
            Get
                Return _PROMISE_DATE
            End Get
            Set(value As Date)
                _PROMISE_DATE = value
            End Set
        End Property

        Public Property UPDATE_DATE As Date
            Get
                Return _UPDATE_DATE
            End Get
            Set(value As Date)
                _UPDATE_DATE = value
            End Set
        End Property

        Public Property SELL_RATE As Double
            Get
                Return _SELL_RATE
            End Get
            Set(value As Double)
                _SELL_RATE = value
            End Set
        End Property

        Public Property AMOUNT As Double
            Get
                Return _AMOUNT
            End Get
            Set(value As Double)
                _AMOUNT = value
            End Set
        End Property

        Public Property DISCOUNT As Double
            Get
                Return _DISCOUNT
            End Get
            Set(value As Double)
                _DISCOUNT = value
            End Set
        End Property

        Public Property AMOUNT_TAX As Double
            Get
                Return _AMOUNT_TAX
            End Get
            Set(value As Double)
                _AMOUNT_TAX = value
            End Set
        End Property

        Public Property AMOUNT_SALES As Double
            Get
                Return _AMOUNT_SALES
            End Get
            Set(value As Double)
                _AMOUNT_SALES = value
            End Set
        End Property

        Public Property PERCENT_DETRAC As Double
            Get
                Return _PERCENT_DETRAC
            End Get
            Set(value As Double)
                _PERCENT_DETRAC = value
            End Set
        End Property

        Public Property COM_PER_ID As String
            Get
                Return _COM_PER_ID
            End Get
            Set(value As String)
                _COM_PER_ID = value
            End Set
        End Property

        Public Property COM_PER_TD As String
            Get
                Return _COM_PER_TD
            End Get
            Set(value As String)
                _COM_PER_TD = value
            End Set
        End Property

        Public Property COM_PER_SERIE As String
            Get
                Return _COM_PER_SERIE
            End Get
            Set(value As String)
                _COM_PER_SERIE = value
            End Set
        End Property

        Public Property COM_PER_NUMERO As String
            Get
                Return _COM_PER_NUMERO
            End Get
            Set(value As String)
                _COM_PER_NUMERO = value
            End Set
        End Property

        Public Property COM_PER_PERCENT As Double
            Get
                Return _COM_PER_PERCENT
            End Get
            Set(value As Double)
                _COM_PER_PERCENT = value
            End Set
        End Property
    End Class
    Public Class LICITACION
        Private _ID As Integer
        Private _NUMERO_LICITACION As String
        Private _FECHA As String
        Private _NUMERO_ENTREGAS As Integer
        Private _OBS As String
        Private _USUARIO As String
        Private _TERMINAL As String

        Public Property ID_CABECERA As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
            End Set
        End Property

        Public Property NUMERO_LICITACION As String
            Get
                Return _NUMERO_LICITACION
            End Get
            Set(value As String)
                _NUMERO_LICITACION = value
            End Set
        End Property

        Public Property FECHA As String
            Get
                Return _FECHA
            End Get
            Set(value As String)
                _FECHA = value
            End Set
        End Property

        Public Property NUMERO_ENTREGAS As Integer
            Get
                Return _NUMERO_ENTREGAS
            End Get
            Set(value As Integer)
                _NUMERO_ENTREGAS = value
            End Set
        End Property

        Public Property OBS As String
            Get
                Return _OBS
            End Get
            Set(value As String)
                _OBS = value
            End Set
        End Property

        Public Property USUARIO As String
            Get
                Return _USUARIO
            End Get
            Set(value As String)
                _USUARIO = value
            End Set
        End Property

        Public Property TERMINAL As String
            Get
                Return _TERMINAL
            End Get
            Set(value As String)
                _TERMINAL = value
            End Set
        End Property

    End Class

    Public Class LICITACION_LINE
        Private _ID As Integer
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _DESCRIPTION As String
        Private _UNIT As String
        Private _PRESENTACION As String
        Private _CANTIDAD_TOTAL As Double
        Private _COD_CLIENTE As String
        Private _CLIENTE As String
        Private _RUC As String
        Private _CANTIDAD_CLIENTE As Double
        Private _PRECIO As Double
        Private _PRECIO_CON_IGV As Double
        Private _PRECIO_SIN_IGV As Double
        Private _VALOR_VENTA As Double
        Private _IGV_ART As Double
        Private _IMPORTE As Double
        Private _FLAG_IGV As Integer
        Private _TEXTO_NRO_ENTREGA As String
        Private _CANTIDAD_ENTREGA As Double

        Public Property VALOR_VENTA As Double
            Get
                Return _VALOR_VENTA
            End Get
            Set(value As Double)
                _VALOR_VENTA = value
            End Set
        End Property

        Public Property IGV_ART As Double
            Get
                Return _IGV_ART
            End Get
            Set(value As Double)
                _IGV_ART = value
            End Set
        End Property

        Public Property IMPORTE As Double
            Get
                Return _IMPORTE
            End Get
            Set(value As Double)
                _IMPORTE = value
            End Set
        End Property

        Public Property ID_CABECERA As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
            End Set
        End Property

        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property

        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property

        Public Property DESCRIPTION As String
            Get
                Return _DESCRIPTION
            End Get
            Set(value As String)
                _DESCRIPTION = value
            End Set
        End Property

        Public Property UNIT As String
            Get
                Return _UNIT
            End Get
            Set(value As String)
                _UNIT = value
            End Set
        End Property

        Public Property PRESENTACION As String
            Get
                Return _PRESENTACION
            End Get
            Set(value As String)
                _PRESENTACION = value
            End Set
        End Property

        Public Property CANTIDAD_TOTAL As Double
            Get
                Return _CANTIDAD_TOTAL
            End Get
            Set(value As Double)
                _CANTIDAD_TOTAL = value
            End Set
        End Property

        Public Property COD_CLIENTE As String
            Get
                Return _COD_CLIENTE
            End Get
            Set(value As String)
                _COD_CLIENTE = value
            End Set
        End Property

        Public Property CLIENTE As String
            Get
                Return _CLIENTE
            End Get
            Set(value As String)
                _CLIENTE = value
            End Set
        End Property

        Public Property RUC As String
            Get
                Return _RUC
            End Get
            Set(value As String)
                _RUC = value
            End Set
        End Property

        Public Property CANTIDAD_CLIENTE As Double
            Get
                Return _CANTIDAD_CLIENTE
            End Get
            Set(value As Double)
                _CANTIDAD_CLIENTE = value
            End Set
        End Property

        Public Property PRECIO As Double
            Get
                Return _PRECIO
            End Get
            Set(value As Double)
                _PRECIO = value
            End Set
        End Property

        Public Property PRECIO_CON_IGV As Double
            Get
                Return _PRECIO_CON_IGV
            End Get
            Set(value As Double)
                _PRECIO_CON_IGV = value
            End Set
        End Property

        Public Property PRECIO_SIN_IGV As Double
            Get
                Return _PRECIO_SIN_IGV
            End Get
            Set(value As Double)
                _PRECIO_SIN_IGV = value
            End Set
        End Property

        Public Property FLAG_IGV As Integer
            Get
                Return _FLAG_IGV
            End Get
            Set(value As Integer)
                _FLAG_IGV = value
            End Set
        End Property

        Public Property TEXTO_NRO_ENTREGA As String
            Get
                Return _TEXTO_NRO_ENTREGA
            End Get
            Set(value As String)
                _TEXTO_NRO_ENTREGA = value
            End Set
        End Property

        Public Property CANTIDAD_ENTREGA As Double
            Get
                Return _CANTIDAD_ENTREGA
            End Get
            Set(value As Double)
                _CANTIDAD_ENTREGA = value
            End Set
        End Property

    End Class

    Public Class PURCHASE_FACT_SUPPLIER_LINE
        Private _ID As String
        Private _TYPE As String
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _UNIT As String
        Private _UNIT_REFERENCE As String
        Private _STATUS_ID As String
        Private _COMMENT1 As String
        Private _TEXT_COMMENT As String

        Private _IS_VAT As String
        Private _CCOST_ID As String
        Private _CENCOS As String
        Private _PROJECT_ID As String
        Private _AREA_ID As String
        Private _COTI_ID As String
        Private _REQUI_ID As String

        Private _PRICE_UNIT As Double
        Private _FACTOR_REFERENCE As Double
        Private _QTY As Double
        Private _PRICE As Double
        Private _DISCOUNT_PER As Double
        Private _DISCOUNT As Double
        Private _AMOUNT_TAX As Double
        Private _PERCENT_TAX As Double
        Private _PRICE_NET As Double
        Private _AMOUNT_TOTAL As Double
        Private _AMOUNT_TOTAL_NET As Double
        Private _QTY_ENTER As Double
        Private _QTY_OUT As Double
        Private _ITEM As Integer
        Private _FLAG_FREE_IGV As Integer


        Public Property FLAG_FREE_IGV As String
            Get
                Return _FLAG_FREE_IGV
            End Get
            Set(value As String)
                _FLAG_FREE_IGV = value
            End Set
        End Property


        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property

        Public Property PART_DESCRIPTION As String
            Get
                Return _PART_DESCRIPTION
            End Get
            Set(value As String)
                _PART_DESCRIPTION = value
            End Set
        End Property

        Public Property UNIT As String
            Get
                Return _UNIT
            End Get
            Set(value As String)
                _UNIT = value
            End Set
        End Property

        Public Property UNIT_REFERENCE As String
            Get
                Return _UNIT_REFERENCE
            End Get
            Set(value As String)
                _UNIT_REFERENCE = value
            End Set
        End Property

        Public Property STATUS_ID As String
            Get
                Return _STATUS_ID
            End Get
            Set(value As String)
                _STATUS_ID = value
            End Set
        End Property

        Public Property COMMENT1 As String
            Get
                Return _COMMENT1
            End Get
            Set(value As String)
                _COMMENT1 = value
            End Set
        End Property

        Public Property TEXT_COMMENT As String
            Get
                Return _TEXT_COMMENT
            End Get
            Set(value As String)
                _TEXT_COMMENT = value
            End Set
        End Property

        Public Property IS_VAT As String
            Get
                Return _IS_VAT
            End Get
            Set(value As String)
                _IS_VAT = value
            End Set
        End Property

        Public Property CCOST_ID As String
            Get
                Return _CCOST_ID
            End Get
            Set(value As String)
                _CCOST_ID = value
            End Set
        End Property

        Public Property CENCOS As String
            Get
                Return _CENCOS
            End Get
            Set(value As String)
                _CENCOS = value
            End Set
        End Property

        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property

        Public Property AREA_ID As String
            Get
                Return _AREA_ID
            End Get
            Set(value As String)
                _AREA_ID = value
            End Set
        End Property

        Public Property COTI_ID As String
            Get
                Return _COTI_ID
            End Get
            Set(value As String)
                _COTI_ID = value
            End Set
        End Property

        Public Property REQUI_ID As String
            Get
                Return _REQUI_ID
            End Get
            Set(value As String)
                _REQUI_ID = value
            End Set
        End Property

        Public Property PRICE_UNIT As Double
            Get
                Return _PRICE_UNIT
            End Get
            Set(value As Double)
                _PRICE_UNIT = value
            End Set
        End Property

        Public Property FACTOR_REFERENCE As Double
            Get
                Return _FACTOR_REFERENCE
            End Get
            Set(value As Double)
                _FACTOR_REFERENCE = value
            End Set
        End Property

        Public Property QTY As Double
            Get
                Return _QTY
            End Get
            Set(value As Double)
                _QTY = value
            End Set
        End Property

        Public Property PRICE As Double
            Get
                Return _PRICE
            End Get
            Set(value As Double)
                _PRICE = value
            End Set
        End Property

        Public Property DISCOUNT_PER As Double
            Get
                Return _DISCOUNT_PER
            End Get
            Set(value As Double)
                _DISCOUNT_PER = value
            End Set
        End Property

        Public Property DISCOUNT As Double
            Get
                Return _DISCOUNT
            End Get
            Set(value As Double)
                _DISCOUNT = value
            End Set
        End Property

        Public Property AMOUNT_TAX As Double
            Get
                Return _AMOUNT_TAX
            End Get
            Set(value As Double)
                _AMOUNT_TAX = value
            End Set
        End Property

        Public Property PERCENT_TAX As Double
            Get
                Return _PERCENT_TAX
            End Get
            Set(value As Double)
                _PERCENT_TAX = value
            End Set
        End Property

        Public Property PRICE_NET As Double
            Get
                Return _PRICE_NET
            End Get
            Set(value As Double)
                _PRICE_NET = value
            End Set
        End Property

        Public Property AMOUNT_TOTAL As Double
            Get
                Return _AMOUNT_TOTAL
            End Get
            Set(value As Double)
                _AMOUNT_TOTAL = value
            End Set
        End Property

        Public Property AMOUNT_TOTAL_NET As Double
            Get
                Return _AMOUNT_TOTAL_NET
            End Get
            Set(value As Double)
                _AMOUNT_TOTAL_NET = value
            End Set
        End Property

        Public Property QTY_ENTER As Double
            Get
                Return _QTY_ENTER
            End Get
            Set(value As Double)
                _QTY_ENTER = value
            End Set
        End Property

        Public Property QTY_OUT As Double
            Get
                Return _QTY_OUT
            End Get
            Set(value As Double)
                _QTY_OUT = value
            End Set
        End Property

        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property
    End Class


    Public Class REFERENCES_DOCUMENT_IMPORTACION_COMPRAS
        Private _ID As String
        Private _TYPE As String
        Private _TIPO_DOCUMENTO As String
        Private _SERIE As String
        Private _ANIO As String
        Private _NUMERO_DOCUMENTO As String


        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property TIPO_DOCUMENTO As String
            Get
                Return _TIPO_DOCUMENTO
            End Get
            Set(value As String)
                _TIPO_DOCUMENTO = value
            End Set
        End Property

        Public Property SERIE As String
            Get
                Return _SERIE
            End Get
            Set(value As String)
                _SERIE = value
            End Set
        End Property

        Public Property ANIO As String
            Get
                Return _ANIO
            End Get
            Set(value As String)
                _ANIO = value
            End Set
        End Property

        Public Property NUMERO_DOCUMENTO As String
            Get
                Return _NUMERO_DOCUMENTO
            End Get
            Set(value As String)
                _NUMERO_DOCUMENTO = value
            End Set
        End Property


    End Class

    Public Class PURCHASE_QUOTE

        Private _ID As String
        Private _DOCUMENT_DATE As Date
        Private _VENDOR_ID As String
        Private _CURRENCY_ID As String
        Private _COMMENT As String
        Private _COMMENT_COT As String
        Private _QUOTE_DATE As String
        Private _SCTIPCAM As Double
        Private _SCVALIDEZ As String
        Private _SCTIEMENT As String
        Private _SCFORPAG As String
        Private _SCNCOTIZ As String
        Private _CREATE_DATE As Date
        Private _UPDATE_DATE As String
        Private _USER_ID As String
        Private _PROJECT_ID As String
        Private _STATUS As String

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property
        Public Property DOCUMENT_DATE As Date
            Get
                Return _DOCUMENT_DATE
            End Get
            Set(value As Date)
                _DOCUMENT_DATE = value
            End Set
        End Property
        Public Property VENDOR_ID As String
            Get
                Return _VENDOR_ID
            End Get
            Set(value As String)
                _VENDOR_ID = value
            End Set
        End Property
        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property
        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property
        Public Property COMMENT_COT As String
            Get
                Return _COMMENT_COT
            End Get
            Set(value As String)
                _COMMENT_COT = value
            End Set
        End Property
        Public Property QUOTE_DATE As String
            Get
                Return _QUOTE_DATE
            End Get
            Set(value As String)
                _QUOTE_DATE = value
            End Set
        End Property
        Public Property SCTIPCAM As Double
            Get
                Return _SCTIPCAM
            End Get
            Set(value As Double)
                _SCTIPCAM = value
            End Set
        End Property
        Public Property SCVALIDEZ As String
            Get
                Return _SCVALIDEZ
            End Get
            Set(value As String)
                _SCVALIDEZ = value
            End Set
        End Property
        Public Property SCTIEMENT As String
            Get
                Return _SCTIEMENT
            End Get
            Set(value As String)
                _SCTIEMENT = value
            End Set
        End Property
        Public Property SCFORPAG As String
            Get
                Return _SCFORPAG
            End Get
            Set(value As String)
                _SCFORPAG = value
            End Set
        End Property
        Public Property SCNCOTIZ As String
            Get
                Return _SCNCOTIZ
            End Get
            Set(value As String)
                _SCNCOTIZ = value
            End Set
        End Property
        Public Property CREATE_DATE As Date
            Get
                Return _CREATE_DATE
            End Get
            Set(value As Date)
                _CREATE_DATE = value
            End Set
        End Property
        Public Property UPDATE_DATE As String
            Get
                Return _UPDATE_DATE
            End Get
            Set(value As String)
                _UPDATE_DATE = value
            End Set
        End Property
        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property
        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property
        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
            End Set
        End Property
    End Class

    Public Class PURCHASE_QUOTE_LINE

        Private _ID As String
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _UNIT As String
        Private _QTY As Double
        Private _PRICE As Double
        Private _AMOUNT_TAX As Double
        Private _AMOUNT As Double
        Private _GUARANTEE As String
        Private _QUALITY As String
        Private _MARK As String
        Private _COMMENT As String
        Private _CURRENCY_ID As String
        Private _DISCOUNT As Double
        Private _DLV_DATE As String
        Private _IS_VAT As String
        Private _PROJECT_ID As String
        Private _CC_ID As String
        Private _AREA_ID As String
        Private _REQUI_ID As String
        Private _REQUI_TYPE As String

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property
        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
            End Set
        End Property
        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property
        Public Property PART_DESCRIPTION As String
            Get
                Return _PART_DESCRIPTION
            End Get
            Set(value As String)
                _PART_DESCRIPTION = value
            End Set
        End Property
        Public Property UNIT As String
            Get
                Return _UNIT
            End Get
            Set(value As String)
                _UNIT = value
            End Set
        End Property
        Public Property QTY As Double
            Get
                Return _QTY
            End Get
            Set(value As Double)
                _QTY = value
            End Set
        End Property
        Public Property PRICE As Double
            Get
                Return _PRICE
            End Get
            Set(value As Double)
                _PRICE = value
            End Set
        End Property
        Public Property AMOUNT_TAX As Double
            Get
                Return _AMOUNT_TAX
            End Get
            Set(value As Double)
                _AMOUNT_TAX = value
            End Set
        End Property
        Public Property AMOUNT As Double
            Get
                Return _AMOUNT
            End Get
            Set(value As Double)
                _AMOUNT = value
            End Set
        End Property
        Public Property GUARANTEE As String
            Get
                Return _GUARANTEE
            End Get
            Set(value As String)
                _GUARANTEE = value
            End Set
        End Property
        Public Property QUALITY As String
            Get
                Return _QUALITY
            End Get
            Set(value As String)
                _QUALITY = value
            End Set
        End Property
        Public Property MARK As String
            Get
                Return _MARK
            End Get
            Set(value As String)
                _MARK = value
            End Set
        End Property
        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property
        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property
        Public Property DISCOUNT As Double
            Get
                Return _DISCOUNT
            End Get
            Set(value As Double)
                _DISCOUNT = value
            End Set
        End Property
        Public Property DLV_DATE As String
            Get
                Return _DLV_DATE
            End Get
            Set(value As String)
                _DLV_DATE = value
            End Set
        End Property
        Public Property IS_VAT As String
            Get
                Return _IS_VAT
            End Get
            Set(value As String)
                _IS_VAT = value
            End Set
        End Property
        Public Property PROJECT_ID As String
            Get
                Return _PROJECT_ID
            End Get
            Set(value As String)
                _PROJECT_ID = value
            End Set
        End Property
        Public Property CC_ID As String
            Get
                Return _CC_ID
            End Get
            Set(value As String)
                _CC_ID = value
            End Set
        End Property
        Public Property AREA_ID As String
            Get
                Return _AREA_ID
            End Get
            Set(value As String)
                _AREA_ID = value
            End Set
        End Property
        Public Property REQUI_ID As String
            Get
                Return _REQUI_ID
            End Get
            Set(value As String)
                _REQUI_ID = value
            End Set
        End Property
        Public Property REQUI_TYPE As String
            Get
                Return _REQUI_TYPE
            End Get
            Set(value As String)
                _REQUI_TYPE = value
            End Set
        End Property
    End Class

    Public Class AREA
        Private _ID As String
        Private _DESCRIPTION As String

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property DESCRIPTION As String
            Get
                Return _DESCRIPTION
            End Get
            Set(value As String)
                _DESCRIPTION = value
            End Set
        End Property

    End Class




    Public Class SOLICITANTE
        Private _TYPE_ID As String
        Private _ID As String
        Private _DESCRIPTION As String
        Private _CREATE_DATE As String
        Private _HOUR As String
        Private _COD_AREA As String

        Public Property TYPE_ID As String
            Get
                Return _TYPE_ID
            End Get
            Set(value As String)
                _TYPE_ID = value
            End Set
        End Property

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property DESCRIPTION As String
            Get
                Return _DESCRIPTION
            End Get
            Set(value As String)
                _DESCRIPTION = value
            End Set
        End Property

        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
                _CREATE_DATE = value
            End Set
        End Property

        Public Property HOUR As String
            Get
                Return _HOUR
            End Get
            Set(value As String)
                _HOUR = value
            End Set
        End Property

        Public Property COD_AREA As String
            Get
                Return _COD_AREA
            End Get
            Set(value As String)
                _COD_AREA = value
            End Set
        End Property

    End Class


End Class
