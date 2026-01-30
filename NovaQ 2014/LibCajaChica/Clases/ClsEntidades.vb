Public Class ClsEntidades


    Public Class TRAMA
        Private _ID As String
        Private _DESCRIPCION As String

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property
        Public Property DESCRIPCION As String
            Get
                Return _DESCRIPCION
            End Get
            Set(value As String)
                _DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class PERSONAL
        Private _TYPE_ID As String
        Private _NAME As String
        Private _DNI As String

        Public Sub New()
            _TYPE_ID = String.Empty
            _NAME = String.Empty
            _DNI = String.Empty
        End Sub
        Public Property DNI As String
            Get
                Return _DNI
            End Get
            Set(value As String)
                _DNI = value
            End Set
        End Property

        Public Property TYPE_ID As String
            Get
                Return _TYPE_ID
            End Get
            Set(value As String)
                _TYPE_ID = value
            End Set
        End Property
        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property


    End Class

    Public Class DOCUMENT_TYPE_CAJA_CHICA
        Private _TYPE_ID As String
        Private _NAME As String

        Public Sub New()
            _TYPE_ID = String.Empty
            _NAME = String.Empty
        End Sub

        Public Property TYPE_ID As String
            Get
                Return _TYPE_ID
            End Get
            Set(value As String)
                _TYPE_ID = value
            End Set
        End Property
        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property


    End Class

    Public Class TRANSACTION_TYPE_CAJA_CHICA
        Private _TYPE_ID As String
        Private _NAME As String

        Public Sub New()
            _TYPE_ID = String.Empty
            _NAME = String.Empty
        End Sub

        Public Property TYPE_ID As String
            Get
                Return _TYPE_ID
            End Get
            Set(value As String)
                _TYPE_ID = value
            End Set
        End Property
        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property


    End Class

    Public Class VEHICLE
        Private _CODIGO As String
        Private _PLACA As String
        Private _MARCA As String
        Private _MODELO As String
        Private _CAPACIDAD As Integer

        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
            End Set
        End Property

        Public Property PLACA As String
            Get
                Return _PLACA
            End Get
            Set(value As String)
                _PLACA = value
            End Set
        End Property

        Public Property MARCA As String
            Get
                Return _MARCA
            End Get
            Set(value As String)
                _MARCA = value
            End Set
        End Property

        Public Property MODELO As String
            Get
                Return _MODELO
            End Get
            Set(value As String)
                _MODELO = value
            End Set
        End Property

        Public Property CAPACIDAD As Integer
            Get
                Return _CAPACIDAD
            End Get
            Set(value As Integer)
                _CAPACIDAD = value
            End Set
        End Property
    End Class

    Public Class EMPRESA_TRANSPORTE
        Private _CODIGO As String
        Private _RAZON_SOCIAL As String
        Private _RUC As String
        Private _DIRECCION As String
        Private _TELEFONO As Integer

        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
            End Set
        End Property

        Public Property RAZON_SOCIAL As String
            Get
                Return _RAZON_SOCIAL
            End Get
            Set(value As String)
                _RAZON_SOCIAL = value
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

        Public Property DIRECCION As String
            Get
                Return _DIRECCION
            End Get
            Set(value As String)
                _DIRECCION = value
            End Set
        End Property

        Public Property TELEFONO As Integer
            Get
                Return _TELEFONO
            End Get
            Set(value As Integer)
                _TELEFONO = value
            End Set
        End Property
    End Class

    Public Class CARRIER

        Private _ID As String
        Private _NAME_CARRIER As String
        Private _ADDR As String
        Private _PHONE As String
        Private _VAT_REGISTRATION As String
        Private _STATUS As String
        Private _CREATE_DATE As String
        Private _NAME As String
        Private _VAT_REGISTRATION_COMP As String
        Private _ADDR_COMP As String
        Private _PHONE_COMP As String
        Private _NUMBER_REGISTRATION As String
        Private _NUMBER_LICENSE As String
        Private _MODEL_VEH As String
        Private _NUMBER_INSCRIP As String
        Private _NUMBER_DOCUMENT As String


        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property NAME_CARRIER As String
            Get
                Return _NAME_CARRIER
            End Get
            Set(value As String)
                _NAME_CARRIER = value
            End Set
        End Property

        Public Property ADDR As String
            Get
                Return _ADDR
            End Get
            Set(value As String)
                _ADDR = value
            End Set
        End Property

        Public Property PHONE As String
            Get
                Return _PHONE
            End Get
            Set(value As String)
                _PHONE = value
            End Set
        End Property

        Public Property VAT_REGISTRATION As String
            Get
                Return _VAT_REGISTRATION
            End Get
            Set(value As String)
                _VAT_REGISTRATION = value
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

        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
                _CREATE_DATE = value
            End Set
        End Property

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property VAT_REGISTRATION_COMP As String
            Get
                Return _VAT_REGISTRATION_COMP
            End Get
            Set(value As String)
                _VAT_REGISTRATION_COMP = value
            End Set
        End Property

        Public Property ADDR_COMP As String
            Get
                Return _ADDR_COMP
            End Get
            Set(value As String)
                _ADDR_COMP = value
            End Set
        End Property

        Public Property PHONE_COMP As String
            Get
                Return _PHONE_COMP
            End Get
            Set(value As String)
                _PHONE_COMP = value
            End Set
        End Property

        Public Property NUMBER_REGISTRATION As String
            Get
                Return _NUMBER_REGISTRATION
            End Get
            Set(value As String)
                _NUMBER_REGISTRATION = value
            End Set
        End Property

        Public Property NUMBER_LICENSE As String
            Get
                Return _NUMBER_LICENSE
            End Get
            Set(value As String)
                _NUMBER_LICENSE = value
            End Set
        End Property

        Public Property MODEL_VEH As String
            Get
                Return _MODEL_VEH
            End Get
            Set(value As String)
                _MODEL_VEH = value
            End Set
        End Property

        Public Property NUMBER_INSCRIP As String
            Get
                Return _NUMBER_INSCRIP
            End Get
            Set(value As String)
                _NUMBER_INSCRIP = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
            End Set
        End Property

    End Class



    Public Class INVENTORY_COUNT_LINE
        Private _ID As String
        Private _WAREHOUSE_ID As String
        Private _FAMILY_ID As String
        Private _PART_ID As String
        Private _STOCK As Double
        Private _ENTER_QTY As Double
        Private _DIF_QTY As Double
        Private _UBICATION As String


        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
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

        Public Property FAMILY_ID As String
            Get
                Return _FAMILY_ID
            End Get
            Set(value As String)
                _FAMILY_ID = value
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

        Public Property UBICATION As String
            Get
                Return _UBICATION
            End Get
            Set(value As String)
                _UBICATION = value
            End Set
        End Property

        Public Property STOCK As Double
            Get
                Return _STOCK
            End Get
            Set(value As Double)
                _STOCK = value
            End Set
        End Property

        Public Property ENTER_QTY As Double
            Get
                Return _ENTER_QTY
            End Get
            Set(value As Double)
                _ENTER_QTY = value
            End Set
        End Property

        Public Property DIF_QTY As Double
            Get
                Return _DIF_QTY
            End Get
            Set(value As Double)
                _DIF_QTY = value
            End Set
        End Property

    End Class

    Public Class PART_TYPE
        Private _ID As String
        Private _NAME As String
        Private _CODIGO As String
        Private _CUENTA_CONTABLE As String

        Public Property CUENTA_CONTABLE As String
            Get
                Return _CUENTA_CONTABLE
            End Get
            Set(value As String)
                _CUENTA_CONTABLE = value
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

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
            End Set
        End Property

  
    End Class

    Public Class INVENTORY_COUNT
        Private _ID As String
        Private _WAREHOUSE_ID As String
        Private _FECHA As String
        Private _USER_ID As String
        Private _COMMENT As String
        Private _STATUS As String
        Private _CONDITION As Integer
        Private _ORDER_ID As Integer

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
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

        Public Property FECHA As String
            Get
                Return _FECHA
            End Get
            Set(value As String)
                _FECHA = value
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

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
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

        Public Property CONDITION As String
            Get
                Return _CONDITION
            End Get
            Set(value As String)
                _CONDITION = value
            End Set
        End Property

        Public Property ORDER_ID As String
            Get
                Return _ORDER_ID
            End Get
            Set(value As String)
                _ORDER_ID = value
            End Set
        End Property

    End Class






    Public Class ORDER

        Private _ID As String
        Private _ORDER_DATE As Date
        Private _CADUCATE_DATE As Date
        Private _SALES_ID As String
        Private _PLACE_SALES As String
        Private _CUSTOMER_ID As String
        Private _CUSTOMER_NAME As String
        Private _CUSTOMER_ADDR As String
        Private _VAT_REGISTRATION As String
        Private _AMOUNT As Double
        Private _DISCOUNT_CUSTOMER As Double
        Private _DISCOUNT_SP As Double

        Private _TERMS As String
        Private _CURRENCY_ID As String
        Private _DOCUMENT_REF As String
        Private _SERIE_REF As String
        Private _NUMBER_REF As String
        Private _STATUS As String
        Private _USER_ID As String
        Private _COMMENT As String
        Private _NUMBER_GUIA As String
        Private _NUMBER_REC As String
        Private _ORDER_PURCHASE As String
        Private _COMMENT1 As String
        Private _REC_TYPE As String
        Private _STATUS_ORDER As String
        Private _TRAMA_ID As String

        Private _CREATE_DATE As Date
        Private _SELL_RATE As Double
        Private _AMOUNT_VAT As Double
        Private _DISCOUNT As Double
        Private _DISCOUNT_AMOUNT As Double
        Private _DISCOUNT_VAL As Double
        Private _AMOUNT_ISC As Double




        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property ORDER_DATE As Date
            Get
                Return _ORDER_DATE
            End Get
            Set(value As Date)
                _ORDER_DATE = value
            End Set
        End Property

        Public Property CADUCATE_DATE As Date
            Get
                Return _CADUCATE_DATE
            End Get
            Set(value As Date)
                _CADUCATE_DATE = value
            End Set
        End Property

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
            End Set
        End Property

        Public Property PLACE_SALES As String
            Get
                Return _PLACE_SALES
            End Get
            Set(value As String)
                _PLACE_SALES = value
            End Set
        End Property

        Public Property CUSTOMER_ID As String
            Get
                Return _CUSTOMER_ID
            End Get
            Set(value As String)
                _CUSTOMER_ID = value
            End Set
        End Property

        Public Property CUSTOMER_NAME As String
            Get
                Return _CUSTOMER_NAME
            End Get
            Set(value As String)
                _CUSTOMER_NAME = value
            End Set
        End Property

        Public Property CUSTOMER_ADDR As String
            Get
                Return _CUSTOMER_ADDR
            End Get
            Set(value As String)
                _CUSTOMER_ADDR = value
            End Set
        End Property

        Public Property VAT_REGISTRATION As String
            Get
                Return _VAT_REGISTRATION
            End Get
            Set(value As String)
                _VAT_REGISTRATION = value
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

        Public Property DISCOUNT_CUSTOMER As Double
            Get
                Return _DISCOUNT_CUSTOMER
            End Get
            Set(value As Double)
                _DISCOUNT_CUSTOMER = value
            End Set
        End Property

        Public Property DISCOUNT_SP As Double
            Get
                Return _DISCOUNT_SP
            End Get
            Set(value As Double)
                _DISCOUNT_SP = value
            End Set
        End Property

        Public Property TERMS As String
            Get
                Return _TERMS
            End Get
            Set(value As String)
                _TERMS = value
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

        Public Property DOCUMENT_REF As String
            Get
                Return _DOCUMENT_REF
            End Get
            Set(value As String)
                _DOCUMENT_REF = value
            End Set
        End Property

        Public Property SERIE_REF As String
            Get
                Return _SERIE_REF
            End Get
            Set(value As String)
                _SERIE_REF = value
            End Set
        End Property

        Public Property NUMBER_REF As String
            Get
                Return _NUMBER_REF
            End Get
            Set(value As String)
                _NUMBER_REF = value
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

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property NUMBER_GUIA As String
            Get
                Return _NUMBER_GUIA
            End Get
            Set(value As String)
                _NUMBER_GUIA = value
            End Set
        End Property

        Public Property NUMBER_REC As String
            Get
                Return _NUMBER_REC
            End Get
            Set(value As String)
                _NUMBER_REC = value
            End Set
        End Property

        Public Property ORDER_PURCHASE As String
            Get
                Return _ORDER_PURCHASE
            End Get
            Set(value As String)
                _ORDER_PURCHASE = value
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

        Public Property REC_TYPE As String
            Get
                Return _REC_TYPE
            End Get
            Set(value As String)
                _REC_TYPE = value
            End Set
        End Property

        Public Property STATUS_ORDER As String
            Get
                Return _STATUS_ORDER
            End Get
            Set(value As String)
                _STATUS_ORDER = value
            End Set
        End Property

        Public Property TRAMA_ID As String
            Get
                Return _TRAMA_ID
            End Get
            Set(value As String)
                _TRAMA_ID = value
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

        Public Property SELL_RATE As Double
            Get
                Return _SELL_RATE
            End Get
            Set(value As Double)
                _SELL_RATE = value
            End Set
        End Property

        Public Property AMOUNT_VAT As Double
            Get
                Return _AMOUNT_VAT
            End Get
            Set(value As Double)
                _AMOUNT_VAT = value
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

        Public Property DISCOUNT_AMOUNT As Double
            Get
                Return _DISCOUNT_AMOUNT
            End Get
            Set(value As Double)
                _DISCOUNT_AMOUNT = value
            End Set
        End Property

        Public Property DISCOUNT_VAL As Double
            Get
                Return _DISCOUNT_VAL
            End Get
            Set(value As Double)
                _DISCOUNT_VAL = value
            End Set
        End Property

        Public Property AMOUNT_ISC As Double
            Get
                Return _AMOUNT_ISC
            End Get
            Set(value As Double)
                _AMOUNT_ISC = value
            End Set
        End Property

    End Class

    Public Class ORDER_LINE
        Private _ID As String
        Private _ITEM As String
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _STATUS As String
        Private _SERIE As String
        Private _WAREHOUSE_ID As String
        Private _TEXT_COMMENT As String
        Private _LOT As String
        Private _LIST_ID As String
        Private _UNIT As String
        Private _QTY As Double
        Private _PRICE_SALES As Double
        Private _PRICE_ORI As Double
        Private _DISCOUNT As Double
        Private _AMOUNT_TAX As Double
        Private _DISCOUNT_CUST As Double
        Private _DISCOUNT_SP As Double
        Private _PERCENT_TAX As Double
        Private _PERCENT_DISCOUNT As Double
        Private _AMOUNT_US As Double
        Private _AMOUNT As Double
        Private _QTY_REF As Double
        Private _BALANCE As Double
        Private _IS_PART_TAX As Integer
        Private _PERCENT_ISC As Double
        Private _AMOUNT_ISC As Double
        Private _PRICE_NET As Double



        Public Property PRICE_NET As String
            Get
                Return _PRICE_NET
            End Get
            Set(value As String)
                _PRICE_NET = value
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

        Public Property ITEM As String
            Get
                Return _ITEM
            End Get
            Set(value As String)
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

        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
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

        Public Property WAREHOUSE_ID As String
            Get
                Return _WAREHOUSE_ID
            End Get
            Set(value As String)
                _WAREHOUSE_ID = value
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

        Public Property LOT As String
            Get
                Return _LOT
            End Get
            Set(value As String)
                _LOT = value
            End Set
        End Property

        Public Property LIST_ID As String
            Get
                Return _LIST_ID
            End Get
            Set(value As String)
                _LIST_ID = value
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

        Public Property PRICE_SALES As Double
            Get
                Return _PRICE_SALES
            End Get
            Set(value As Double)
                _PRICE_SALES = value
            End Set
        End Property

        Public Property PRICE_ORI As Double
            Get
                Return _PRICE_ORI
            End Get
            Set(value As Double)
                _PRICE_ORI = value
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

        Public Property DISCOUNT_CUST As Double
            Get
                Return _DISCOUNT_CUST
            End Get
            Set(value As Double)
                _DISCOUNT_CUST = value
            End Set
        End Property

        Public Property DISCOUNT_SP As Double
            Get
                Return _DISCOUNT_SP
            End Get
            Set(value As Double)
                _DISCOUNT_SP = value
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

        Public Property PERCENT_DISCOUNT As Double
            Get
                Return _PERCENT_DISCOUNT
            End Get
            Set(value As Double)
                _PERCENT_DISCOUNT = value
            End Set
        End Property

        Public Property AMOUNT_US As Double
            Get
                Return _AMOUNT_US
            End Get
            Set(value As Double)
                _AMOUNT_US = value
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

        Public Property QTY_REF As Double
            Get
                Return _QTY_REF
            End Get
            Set(value As Double)
                _QTY_REF = value
            End Set
        End Property

        Public Property BALANCE As Double
            Get
                Return _BALANCE
            End Get
            Set(value As Double)
                _BALANCE = value
            End Set
        End Property

        Public Property IS_PART_TAX As Double
            Get
                Return _IS_PART_TAX
            End Get
            Set(value As Double)
                _IS_PART_TAX = value
            End Set
        End Property

        Public Property PERCENT_ISC As Double
            Get
                Return _PERCENT_ISC
            End Get
            Set(value As Double)
                _PERCENT_ISC = value
            End Set
        End Property

        Public Property AMOUNT_ISC As Double
            Get
                Return _AMOUNT_ISC
            End Get
            Set(value As Double)
                _AMOUNT_ISC = value
            End Set
        End Property

    End Class



    Public Class PURCHASE_ORDER

        Private _ID As String
        Private _TYPE As String
        Private _DOCUMENT_DATE As Date
        Private _VENDOR_ID As String
        Private _NUMBER_ESTIMATING As String
        Private _CURRENCY_TYPE As String
        Private _TERMS_NAME As String
        Private _SELL_RATE As Decimal
        Private _PROMISE_DATE As Date
        Private _COMMENT As String
        Private _AUTORIZED_ID As String
        Private _BUYER_PURCHASE_ID As String
        Private _TIME_DLV As String
        Private _ADDR_DLV As String
        Private _STATUS_ID As String
        Private _AMOUNT As Decimal
        Private _DISCOUNT As Decimal
        Private _AMOUNT_TAX As Decimal
        Private _AMOUNT_SALES As Decimal
        Private _UPDATE_DATE As Date
        Private _UPDATE_HOUR As String
        Private _USER_ID As String
        Private _CURR_EXCHANGE_TYPE As String
        Private _NAME_FACT As String
        Private _VAT_REGISTRATION_FACT As String
        Private _ADDR_FACT As String
        Private _REFER_DOCUMENT_TYPE As String
        Private _REFER_DOCUMENT_NUMBER As String
    End Class

    Public Class PURCHASE_ORDER_LINE

    End Class


    Public Class LOT
        Private _WHO_ID As String
        Private _PART_ID As String
        Private _LOT_ID As String
        Private _QTY_ON_HAND As Double
        Private _MANUFACT_DATE As String
        Private _CADUCATE_DATE As String
        Private _COMMENT As String
        Private _INFORME_ENSAYO As String
        Private _ACTA_MUESTREO As String
        Private _N_PROTOCOLO As String
        Private _REGISTRO_SANITARIO As String

        Public Sub New()
            _WHO_ID = String.Empty
            _PART_ID = String.Empty
            _LOT_ID = String.Empty
            _QTY_ON_HAND = 0.0R
            _MANUFACT_DATE = String.Empty
            _CADUCATE_DATE = String.Empty
            _COMMENT = String.Empty
            _INFORME_ENSAYO = String.Empty
            _ACTA_MUESTREO = String.Empty
            _N_PROTOCOLO = String.Empty
            _REGISTRO_SANITARIO = String.Empty
        End Sub
        Public Property INFORME_ENSAYO As String
            Get
                Return _INFORME_ENSAYO
            End Get
            Set(value As String)
                _INFORME_ENSAYO = value
            End Set
        End Property
        Public Property ACTA_MUESTREO As String
            Get
                Return _ACTA_MUESTREO
            End Get
            Set(value As String)
                _ACTA_MUESTREO = value
            End Set
        End Property
        Public Property N_PROTOCOLO As String
            Get
                Return _N_PROTOCOLO
            End Get
            Set(value As String)
                _N_PROTOCOLO = value
            End Set
        End Property
        Public Property REGISTRO_SANITARIO As String
            Get
                Return _REGISTRO_SANITARIO
            End Get
            Set(value As String)
                _REGISTRO_SANITARIO = value
            End Set
        End Property

        Public Property WHO_ID As String
            Get
                Return _WHO_ID
            End Get
            Set(value As String)
                _WHO_ID = value
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

        Public Property LOT_ID As String
            Get
                Return _LOT_ID
            End Get
            Set(value As String)
                _LOT_ID = value
            End Set
        End Property

        Public Property QTY_ON_HAND As Double
            Get
                Return _QTY_ON_HAND
            End Get
            Set(value As Double)
                _QTY_ON_HAND = value
            End Set
        End Property


        Public Property MANUFACT_DATE As String
            Get
                Return _MANUFACT_DATE
            End Get
            Set(value As String)
                _MANUFACT_DATE = value
            End Set
        End Property

        Public Property CADUCATE_DATE As String
            Get
                Return _CADUCATE_DATE
            End Get
            Set(value As String)
                _CADUCATE_DATE = value
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
    End Class


    Public Class WAREHOUSE

        Private _ID As String
        Private _NAME As String
        Private _ADDR_WHO As String
        Private _STATE_ID As String
        Private _TYPE_PART As String
        Private _PHONE As String
        Private _STATUS As String
        Private _IS_DEFAULT As String
        Private _LAST_NUM_IN As Double
        Private _LAST_NUM_OUT As Double

        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
            _ADDR_WHO = String.Empty
            _STATE_ID = String.Empty
            _TYPE_PART = String.Empty
            _PHONE = String.Empty
            _STATUS = String.Empty
            _IS_DEFAULT = String.Empty
            _LAST_NUM_IN = 0.0
            _LAST_NUM_OUT = 0.0
        End Sub

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property ADDR_WHO As String
            Get
                Return _ADDR_WHO
            End Get
            Set(value As String)
                _ADDR_WHO = value
            End Set
        End Property

        Public Property STATE_ID As String
            Get
                Return _STATE_ID
            End Get
            Set(value As String)
                _STATE_ID = value
            End Set
        End Property

        Public Property TYPE_PART As String
            Get
                Return _TYPE_PART
            End Get
            Set(value As String)
                _TYPE_PART = value
            End Set
        End Property

        Public Property PHONE As String
            Get
                Return _PHONE
            End Get
            Set(value As String)
                _PHONE = value
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

        Public Property IS_DEFAULT As String
            Get
                Return _IS_DEFAULT
            End Get
            Set(value As String)
                _IS_DEFAULT = value
            End Set
        End Property

        Public Property LAST_NUM_IN As Double
            Get
                Return _LAST_NUM_IN
            End Get
            Set(value As Double)
                _LAST_NUM_IN = value
            End Set
        End Property

        Public Property LAST_NUM_OUT As Double
            Get
                Return _LAST_NUM_OUT
            End Get
            Set(value As Double)
                _LAST_NUM_OUT = value
            End Set
        End Property
    End Class



    Public Class TRANSACTION_TYPE
        Private _TYPE_ID As String
        Private _MOV_ID As String
        Private _NAME As String
        Private _IS_VALUED As String
        Private _IS_VENDOR As String
        Private _IS_DOC_REF As String
        Private _IS_AUTHORIZED As String
        Private _IS_CCOST As String
        Private _IS_ORDER_PURCHASE As String
        Private _IS_COMMENT As String
        Private _IS_WHO As String
        Private _IS_CUSTOMER As String
        Private _IS_ORDER_MANUFACT As String

        Private _IS_ACCOUNT As String
        Private _VAR_COUNT As Double
        Private _WHO_ID As String
        Private _IS_GUIA_ANALISIS As String
        Private _WHO_ID_PART_TYPE As String

        Private _LOTE_A_FABRICAR As String

        Public Sub New()
            _TYPE_ID = String.Empty
            _MOV_ID = String.Empty
            _NAME = String.Empty
            _IS_VALUED = String.Empty
            _IS_VENDOR = String.Empty
            _IS_DOC_REF = String.Empty
            _IS_AUTHORIZED = String.Empty
            _IS_CCOST = String.Empty
            _IS_ORDER_PURCHASE = String.Empty
            _IS_COMMENT = String.Empty
            _IS_WHO = String.Empty
            _IS_CUSTOMER = String.Empty
            _IS_ORDER_MANUFACT = String.Empty
            _IS_ACCOUNT = String.Empty
            _VAR_COUNT = 0.0
            _WHO_ID = String.Empty
            _IS_GUIA_ANALISIS = String.Empty
            _WHO_ID_PART_TYPE = String.Empty
        End Sub

        Public Property LOTE_A_FABRICAR As String
            Get
                Return _LOTE_A_FABRICAR
            End Get
            Set(value As String)
                _LOTE_A_FABRICAR = value
            End Set
        End Property

        Public Property TYPE_ID As String
            Get
                Return _TYPE_ID
            End Get
            Set(value As String)
                _TYPE_ID = value
            End Set
        End Property

        Public Property MOV_ID As String
            Get
                Return _MOV_ID
            End Get
            Set(value As String)
                _MOV_ID = value
            End Set
        End Property

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property IS_VALUED As String
            Get
                Return _IS_VALUED
            End Get
            Set(value As String)
                _IS_VALUED = value
            End Set
        End Property

        Public Property IS_VENDOR As String
            Get
                Return _IS_VENDOR
            End Get
            Set(value As String)
                _IS_VENDOR = value
            End Set
        End Property

        Public Property IS_DOC_REF As String
            Get
                Return _IS_DOC_REF
            End Get
            Set(value As String)
                _IS_DOC_REF = value
            End Set
        End Property

        Public Property IS_AUTHORIZED As String
            Get
                Return _IS_AUTHORIZED
            End Get
            Set(value As String)
                _IS_AUTHORIZED = value
            End Set
        End Property

        Public Property IS_CCOST As String
            Get
                Return _IS_CCOST
            End Get
            Set(value As String)
                _IS_CCOST = value
            End Set
        End Property

        Public Property IS_ORDER_PURCHASE As String
            Get
                Return _IS_ORDER_PURCHASE
            End Get
            Set(value As String)
                _IS_ORDER_PURCHASE = value
            End Set
        End Property

        Public Property IS_COMMENT As String
            Get
                Return _IS_COMMENT
            End Get
            Set(value As String)
                _IS_COMMENT = value
            End Set
        End Property

        Public Property IS_WHO As String
            Get
                Return _IS_WHO
            End Get
            Set(value As String)
                _IS_WHO = value
            End Set
        End Property

        Public Property IS_CUSTOMER As String
            Get
                Return _IS_CUSTOMER
            End Get
            Set(value As String)
                _IS_CUSTOMER = value
            End Set
        End Property

        Public Property IS_ORDER_MANUFACT As String
            Get
                Return _IS_ORDER_MANUFACT
            End Get
            Set(value As String)
                _IS_ORDER_MANUFACT = value
            End Set
        End Property

        Public Property IS_ACCOUNT As String
            Get
                Return _IS_ACCOUNT
            End Get
            Set(value As String)
                _IS_ACCOUNT = value
            End Set
        End Property

        Public Property VAR_COUNT As Double
            Get
                Return _VAR_COUNT
            End Get
            Set(value As Double)
                _VAR_COUNT = value
            End Set
        End Property

        Public Property WHO_ID As String
            Get
                Return _WHO_ID
            End Get
            Set(value As String)
                _WHO_ID = value
            End Set
        End Property

        Public Property IS_GUIA_ANALISIS As String
            Get
                Return _IS_GUIA_ANALISIS
            End Get
            Set(value As String)
                _IS_GUIA_ANALISIS = value
            End Set
        End Property

        Public Property WHO_ID_PART_TYPE As String
            Get
                Return _WHO_ID_PART_TYPE
            End Get
            Set(value As String)
                _WHO_ID_PART_TYPE = value
            End Set
        End Property

    End Class

    Public Class LINES
        Private _FAMILY_ID As String
        Private _ID As String
        Private _NAME As String
        Private _CODIGO_PART_TYPE As String
        Private _IS_SHOW_FACT_GUIA As String
        Private _CODIGO As String

        Public Sub New()
            _FAMILY_ID = String.Empty
            _FAMILY_ID = String.Empty
            _NAME = String.Empty
            _CODIGO_PART_TYPE = String.Empty
            _IS_SHOW_FACT_GUIA = String.Empty
            _CODIGO = String.Empty
        End Sub

        Public Property IS_SHOW_FACT_GUIA As String
            Get
                Return _IS_SHOW_FACT_GUIA
            End Get
            Set(value As String)
                _IS_SHOW_FACT_GUIA = value
            End Set
        End Property

        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
            End Set
        End Property

        Public Property FAMILY_ID As String
            Get
                Return _FAMILY_ID
            End Get
            Set(value As String)
                _FAMILY_ID = value
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

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property CODIGO_PART_TYPE As String
            Get
                Return _CODIGO_PART_TYPE
            End Get
            Set(value As String)
                _CODIGO_PART_TYPE = value
            End Set
        End Property

    End Class

    Public Class FAMILY
        Private _ID As String
        Private _NAME As String

        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
        End Sub

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property
    End Class


    Public Class VENDOR
        Private _ID As String
        Private _NAME As String
        Private _VAT_REGISTRATION As String
        Private _ADDR As String
        Private _PHONE As String
        Private _EMAIL As String
        Private _WEBSITE As String
        Private _CONTACT As String
        Private _DOCUMENT_TYPE_PERSON_ID As String
        Private _TYPE_COMPANY As String
        Private _ACCOUNT_LOCAL As String
        Private _ACCOUNT_EXTERNAL As String

        Private _USER As String
        Private _CREATE_DATE As Date




        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
            _VAT_REGISTRATION = String.Empty
            _ADDR = String.Empty
            _PHONE = String.Empty
            _EMAIL = String.Empty
            _WEBSITE = String.Empty
            _CONTACT = String.Empty
            _DOCUMENT_TYPE_PERSON_ID = String.Empty
            _TYPE_COMPANY = String.Empty
            _ACCOUNT_LOCAL = String.Empty
            _ACCOUNT_EXTERNAL = String.Empty
        End Sub

        Public Property USER As String
            Get
                Return _USER
            End Get
            Set(value As String)
                _USER = value
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


        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property VAT_REGISTRATION As String
            Get
                Return _VAT_REGISTRATION
            End Get
            Set(value As String)
                _VAT_REGISTRATION = value
            End Set
        End Property

        Public Property ADDR As String
            Get
                Return _ADDR
            End Get
            Set(value As String)
                _ADDR = value
            End Set
        End Property

        Public Property PHONE As String
            Get
                Return _PHONE
            End Get
            Set(value As String)
                _PHONE = value
            End Set
        End Property

        Public Property EMAIL As String
            Get
                Return _EMAIL
            End Get
            Set(value As String)
                _EMAIL = value
            End Set
        End Property

        Public Property WEBSITE As String
            Get
                Return _WEBSITE
            End Get
            Set(value As String)
                _WEBSITE = value
            End Set
        End Property

        Public Property CONTACT As String
            Get
                Return _CONTACT
            End Get
            Set(value As String)
                _CONTACT = value
            End Set
        End Property

        Public Property DOCUMENT_TYPE_PERSON_ID As String
            Get
                Return _DOCUMENT_TYPE_PERSON_ID
            End Get
            Set(value As String)
                _DOCUMENT_TYPE_PERSON_ID = value
            End Set
        End Property

        Public Property TYPE_COMPANY As String
            Get
                Return _TYPE_COMPANY
            End Get
            Set(value As String)
                _TYPE_COMPANY = value
            End Set
        End Property

        Public Property ACCOUNT_LOCAL As String
            Get
                Return _ACCOUNT_LOCAL
            End Get
            Set(value As String)
                _ACCOUNT_LOCAL = value
            End Set
        End Property

        Public Property ACCOUNT_EXTERNAL As String
            Get
                Return _ACCOUNT_EXTERNAL
            End Get
            Set(value As String)
                _ACCOUNT_EXTERNAL = value
            End Set
        End Property

    End Class

    Public Class ACCOUNT_BANK
        Private _BANK_ID As String
        Private _ACCOUNT_BANK_ID As String
        Private _ACCOUNT_BANK_DES As String
        Private _NUMBER_ACCOUNT As String
        Private _CURRENCY_ID As String
        Private _TYPE_DOC As String
        Private _TYPE_ANNEX As String

        Public Sub New()
            _BANK_ID = String.Empty
            _ACCOUNT_BANK_ID = String.Empty
            _ACCOUNT_BANK_DES = String.Empty
            _NUMBER_ACCOUNT = String.Empty
            _CURRENCY_ID = String.Empty
            _TYPE_DOC = String.Empty
            _TYPE_ANNEX = String.Empty
        End Sub

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
            End Set
        End Property

        Public Property ACCOUNT_BANK_ID As String
            Get
                Return _ACCOUNT_BANK_ID
            End Get
            Set(value As String)
                _ACCOUNT_BANK_ID = value
            End Set
        End Property

        Public Property ACCOUNT_BANK_DES As String
            Get
                Return _ACCOUNT_BANK_DES
            End Get
            Set(value As String)
                _ACCOUNT_BANK_DES = value
            End Set
        End Property

        Public Property NUMBER_ACCOUNT As String
            Get
                Return _NUMBER_ACCOUNT
            End Get
            Set(value As String)
                _NUMBER_ACCOUNT = value
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

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

        Public Property TYPE_ANNEX As String
            Get
                Return _TYPE_ANNEX
            End Get
            Set(value As String)
                _TYPE_ANNEX = value
            End Set
        End Property

    End Class

    Public Class ACCOUNT_BANK_PAY
        Private _BANK_ID As String
        Private _ACCOUNT_BANK_ID As String
        Private _ACCOUNT_BANK_DES As String
        Private _NUMBER_ACCOUNT As String
        Private _CURRENCY_ID As String
        Private _TYPE_DOC As String

        Public Sub New()
            _BANK_ID = String.Empty
            _ACCOUNT_BANK_ID = String.Empty
            _ACCOUNT_BANK_DES = String.Empty
            _NUMBER_ACCOUNT = String.Empty
            _CURRENCY_ID = String.Empty
            _TYPE_DOC = String.Empty
        End Sub

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
            End Set
        End Property

        Public Property ACCOUNT_BANK_ID As String
            Get
                Return _ACCOUNT_BANK_ID
            End Get
            Set(value As String)
                _ACCOUNT_BANK_ID = value
            End Set
        End Property

        Public Property ACCOUNT_BANK_DES As String
            Get
                Return _ACCOUNT_BANK_DES
            End Get
            Set(value As String)
                _ACCOUNT_BANK_DES = value
            End Set
        End Property

        Public Property NUMBER_ACCOUNT As String
            Get
                Return _NUMBER_ACCOUNT
            End Get
            Set(value As String)
                _NUMBER_ACCOUNT = value
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

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

    End Class

    Public Class BANK
        Private _ID As String
        Private _NAME As String
        Private _RECEIVE_ID As String


        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
        End Sub

        Public Property RECEIVE_ID As String
            Get
                Return _RECEIVE_ID
            End Get
            Set(value As String)
                _RECEIVE_ID = value
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

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

    End Class


    Public Class BANK_PAY
        Private _ID As String
        Private _NAME As String
        Private _RECEIVE_ID As String


        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
        End Sub

        Public Property RECEIVE_ID As String
            Get
                Return _RECEIVE_ID
            End Get
            Set(value As String)
                _RECEIVE_ID = value
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

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

    End Class

    Public Class PART
        Private _ID As String
        Private _ID_FAB As String
        Private _DESCRIPTION As String
        Private _FAMILY As String
        Private _MODEL As String
        Private _UNIT_OF_MEASUREMENT As String
        Private _SERIES As String
        Private _IS_STOCKED As String
        Private _IS_LOT As String
        Private _VAT_POR As Double
        Private _IS_VAT As Integer
        Private _ACCOUNT_INTERNAL_ID As String
        Private _ACCOUNT_INV As String
        Private _ACCOUNT_PAY As String
        Private _ISCPOR As Double
        Private _TIPOISC As Integer

        Private _DESCRIPTION_OPT As String
        Private _UNIT_PRICE As Double
        Private _DISCOUNT As Double
        Private _PRICE_BUY As Double
        Private _VENDOR_ID_PART As String
        Private _CREATE_DATE As Date
        Private _CREATE_USER As String
        Private _STATUS As String
        Private _CURRENCY_ID As String
        Private _TYPE_PART As String
        Private _WEIGHT As Double
        Private _CST_POR As Double
        Private _HOUR_UPDATE As Date
        Private _COMMISSION_SALES As Double
        Private _ORIGEN As String
        Private _PRESS_VENTA As String
        Private _PRESS_MUESTRA_MEDICA As String
        Private _LINEA_MEDICA As String
        Private _NOMBRE_COMERCIAL As String
        Private _ID_ANTERIOR As String
        Private _TIPO_ARTICULO As Integer
        Private _PRESS_COMERCIAL As String
        Private _CLASS_PART As String
        Private _REG_SANIT As String
        Private _VIGENCIA_REG_SANIT As String
        Private _VIGENCIA_LOTE As String
        Private _IMAGEN As Byte()


        Public Sub New()
            _ID = String.Empty
            _ID_FAB = String.Empty
            _DESCRIPTION = String.Empty
            _FAMILY = String.Empty
            _UNIT_OF_MEASUREMENT = String.Empty
            _SERIES = String.Empty
            _IS_STOCKED = String.Empty
            _IS_LOT = String.Empty
            _VAT_POR = 0.0R
            _IS_VAT = 0
            _ACCOUNT_INTERNAL_ID = String.Empty
            _ACCOUNT_INV = String.Empty
            _ACCOUNT_PAY = String.Empty
            _ISCPOR = 0.0R
            _TIPOISC = 0
            _MODEL = String.Empty

            _DESCRIPTION_OPT = String.Empty
            _UNIT_PRICE = 0.0R
            _DISCOUNT = 0.0R
            _PRICE_BUY = 0.0R
            _VENDOR_ID_PART = String.Empty
            _CREATE_DATE = Date.Now()
            _CREATE_USER = String.Empty
            _STATUS = String.Empty
            _CURRENCY_ID = 0.0R
            _TYPE_PART = String.Empty
            _WEIGHT = 0.0R
            _CST_POR = 0.0R
            _HOUR_UPDATE = DateTime.Now().ToString("HH:mm:ss")
            _COMMISSION_SALES = 0.0R
            _ORIGEN = ChrW(0)
            _PRESS_VENTA = String.Empty
            _PRESS_MUESTRA_MEDICA = String.Empty
            _LINEA_MEDICA = String.Empty
            _NOMBRE_COMERCIAL = String.Empty
            _ID_ANTERIOR = String.Empty
            _TIPO_ARTICULO = 0
            _PRESS_COMERCIAL = String.Empty
            _CLASS_PART = String.Empty
            _IMAGEN = Nothing
        End Sub

        Public Property VIGENCIA_LOTE As String
            Get
                Return _VIGENCIA_LOTE
            End Get
            Set(value As String)
                _VIGENCIA_LOTE = value
            End Set
        End Property
        Public Property IMAGEN As Byte()
            Get
                Return _IMAGEN
            End Get
            Set(value As Byte())
                _IMAGEN = value
            End Set
        End Property
        Public Property VIGENCIA_REG_SANIT As String
            Get
                Return _VIGENCIA_REG_SANIT
            End Get
            Set(value As String)
                _VIGENCIA_REG_SANIT = value
            End Set
        End Property


        Public Property REG_SANIT As String
            Get
                Return _REG_SANIT
            End Get
            Set(value As String)
                _REG_SANIT = value
            End Set
        End Property


        Public Property MODEL As String
            Get
                Return _MODEL
            End Get
            Set(value As String)
                _MODEL = value
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

        Public Property ID_FAB As String
            Get
                Return _ID_FAB
            End Get
            Set(value As String)
                _ID_FAB = value
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

        Public Property FAMILY As String
            Get
                Return _FAMILY
            End Get
            Set(value As String)
                _FAMILY = value
            End Set
        End Property

        Public Property UNIT_OF_MEASUREMENT As String
            Get
                Return _UNIT_OF_MEASUREMENT
            End Get
            Set(value As String)
                _UNIT_OF_MEASUREMENT = value
            End Set
        End Property

        Public Property SERIES As String
            Get
                Return _SERIES
            End Get
            Set(value As String)
                _SERIES = value
            End Set
        End Property

        Public Property IS_STOCKED As String
            Get
                Return _IS_STOCKED
            End Get
            Set(value As String)
                _IS_STOCKED = value
            End Set
        End Property

        Public Property IS_LOT As String
            Get
                Return _IS_LOT
            End Get
            Set(value As String)
                _IS_LOT = value
            End Set
        End Property

        Public Property VAT_POR As Double
            Get
                Return _VAT_POR
            End Get
            Set(value As Double)
                _VAT_POR = value
            End Set
        End Property

        Public Property IS_VAT As Integer
            Get
                Return _IS_VAT
            End Get
            Set(value As Integer)
                _IS_VAT = value
            End Set
        End Property

        Public Property ACCOUNT_INTERNAL_ID As String
            Get
                Return _ACCOUNT_INTERNAL_ID
            End Get
            Set(value As String)
                _ACCOUNT_INTERNAL_ID = value
            End Set
        End Property

        Public Property ACCOUNT_INV As String
            Get
                Return _ACCOUNT_INV
            End Get
            Set(value As String)
                _ACCOUNT_INV = value
            End Set
        End Property

        Public Property ACCOUNT_PAY As String
            Get
                Return _ACCOUNT_PAY
            End Get
            Set(value As String)
                _ACCOUNT_PAY = value
            End Set
        End Property

        Public Property ISCPOR As Double
            Get
                Return _ISCPOR
            End Get
            Set(value As Double)
                _ISCPOR = value
            End Set
        End Property

        Public Property TIPOISC As Integer
            Get
                Return _TIPOISC
            End Get
            Set(value As Integer)
                _TIPOISC = value
            End Set
        End Property

        '------

        Public Property DESCRIPTION_OPT As String
            Get
                Return _DESCRIPTION_OPT
            End Get
            Set(value As String)
                _DESCRIPTION_OPT = value
            End Set
        End Property

        Public Property UNIT_PRICE As Double
            Get
                Return _UNIT_PRICE
            End Get
            Set(value As Double)
                _UNIT_PRICE = value
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

        Public Property PRICE_BUY As Double
            Get
                Return _PRICE_BUY
            End Get
            Set(value As Double)
                _PRICE_BUY = value
            End Set
        End Property

        Public Property VENDOR_ID_PART As String
            Get
                Return _VENDOR_ID_PART
            End Get
            Set(value As String)
                _VENDOR_ID_PART = value
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

        Public Property CREATE_USER As String
            Get
                Return _CREATE_USER
            End Get
            Set(value As String)
                _CREATE_USER = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property

        Public Property TYPE_PART As String
            Get
                Return _TYPE_PART
            End Get
            Set(value As String)
                _TYPE_PART = value
            End Set
        End Property

        Public Property WEIGHT As Double
            Get
                Return _WEIGHT
            End Get
            Set(value As Double)
                _WEIGHT = value
            End Set
        End Property

        Public Property CST_POR As Double
            Get
                Return _CST_POR
            End Get
            Set(value As Double)
                _CST_POR = value
            End Set
        End Property

        Public Property HOUR_UPDATE As Date
            Get
                Return _HOUR_UPDATE
            End Get
            Set(value As Date)
                _HOUR_UPDATE = value
            End Set
        End Property

        Public Property COMMISSION_SALES As Double
            Get
                Return _COMMISSION_SALES
            End Get
            Set(value As Double)
                _COMMISSION_SALES = value
            End Set
        End Property

        Public Property ORIGEN As String
            Get
                Return _ORIGEN
            End Get
            Set(value As String)
                _ORIGEN = value
            End Set
        End Property

        Public Property PRESS_VENTA As String
            Get
                Return _PRESS_VENTA
            End Get
            Set(value As String)
                _PRESS_VENTA = value
            End Set
        End Property

        Public Property PRESS_MUESTRA_MEDICA As String
            Get
                Return _PRESS_MUESTRA_MEDICA
            End Get
            Set(value As String)
                _PRESS_MUESTRA_MEDICA = value
            End Set
        End Property

        Public Property LINEA_MEDICA As String
            Get
                Return _LINEA_MEDICA
            End Get
            Set(value As String)
                _LINEA_MEDICA = value
            End Set
        End Property

        Public Property NOMBRE_COMERCIAL As String
            Get
                Return _NOMBRE_COMERCIAL
            End Get
            Set(value As String)
                _NOMBRE_COMERCIAL = value
            End Set
        End Property

        Public Property ID_ANTERIOR As String
            Get
                Return _ID_ANTERIOR
            End Get
            Set(value As String)
                _ID_ANTERIOR = value
            End Set
        End Property

        Public Property TIPO_ARTICULO As Integer
            Get
                Return _TIPO_ARTICULO
            End Get
            Set(value As Integer)
                _TIPO_ARTICULO = value
            End Set
        End Property

        Public Property PRESS_COMERCIAL As String
            Get
                Return _PRESS_COMERCIAL
            End Get
            Set(value As String)
                _PRESS_COMERCIAL = value
            End Set
        End Property

        Public Property CLASS_PART As String
            Get
                Return _CLASS_PART
            End Get
            Set(value As String)
                _CLASS_PART = value
            End Set
        End Property
    End Class




    Public Class WAREHOUSE_TRANS_LINE
        Private _WAREHOUSE_ID As String
        Private _DOCUMENT_ID As String
        Private _NUMBER_DOCUMENT As String
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _REF_ID As String
        Private _QTY As Double
        Private _QTY_DLV As Double
        Private _QTY_REF As Double
        Private _QTY_INVOICED As Double
        Private _NUM_ORDER As String
        Private _UNIT_PRICE As Double
        Private _AVERAGE_COST As Double
        Private _AMOUNT_SALES As Double
        Private _DISCOUNT As Double
        Private _STOCK As String
        Private _AMOUNT_TAX As Double
        Private _AMOUNT As Double
        Private _AMOUNT_US As Double
        Private _NUMBER_SERIE As String
        Private _STATUS_DOC As String
        Private _DATE_DOC As String
        Private _CCOST_ID As String
        Private _WAREHOUSE_REF As String
        Private _TEXT_COMMENT As String
        Private _STATUS As String
        Private _TRANS_ID As String
        Private _VAL_AMOUNT As Double
        Private _NUM_VOUCHER As String
        Private _CURRENCY_ID As String
        Private _TYPE As String
        Private _TYPE_EXCHANGE As Double
        Private _PRICE_SALES As Double
        Private _TOTAL_SALES As String
        Private _DATE_CADUCATE As String
        Private _RETURN_AMOUNT As Double
        Private _AUTHORIZED As String
        Private _PART_DESCRIPTION As String
        Private _DISCOUNT_PERCENT As Double
        Private _TAX_PERCENT As Double
        Private _DISCOUNT_CUST As Double
        Private _DISCOUNT_SP As Double
        Private _NUMBER_INVOICE As String
        Private _NUMBER_LOT As String
        Private _UNIT_PART As String
        Private _ORDER_MANUFACT_ID As String
        Private _EQUIP_ID As String
        Private _FREIGTH As Double
        Private _ITEMI As String
        Private _QTY_BRUTE As Double
        Private _DISCOUNT_PER_QTY As Double
        Private _STATUS_VALUE As Integer
        Private _UNIT_REFERENCE As String
        Private _QTY_REFERENCE As Double
        Private _COMMENT As String
        Private _REFERENCE As String
        Private _ACCOUNT As String
        Private _COMMENT_TEXT As String
        Private _PROJECT_ID As String

        Private _QT_BULTOS As Integer
        Private _OPT_ENTREGA As String
        Private _NUM_PROTOCOLOS As String
        Private _NUMBER_ANALIS As String
        Private _PROCEDENCIA As String
        Private _PAIS_ORIGEN As String

        Private _QTY_BULTOS_ANALIZADOS As String

        Public Sub New()
            _WAREHOUSE_ID = String.Empty
            _DOCUMENT_ID = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _ITEM = 0
            _PART_ID = String.Empty
            _REF_ID = String.Empty
            _QTY = 0.0R
            _QTY_DLV = 0.0R
            _QTY_REF = 0.0R
            _QTY_INVOICED = 0.0R
            _NUM_ORDER = String.Empty
            _UNIT_PRICE = 0.0R
            _AVERAGE_COST = 0.0R
            _AMOUNT_SALES = 0.0R
            _DISCOUNT = 0.0R
            _STOCK = String.Empty
            _AMOUNT_TAX = 0.0R
            _AMOUNT = 0.0R
            _AMOUNT_US = 0.0R
            _NUMBER_SERIE = String.Empty
            _STATUS_DOC = String.Empty
            _DATE_DOC = String.Empty
            _CCOST_ID = String.Empty
            _WAREHOUSE_REF = String.Empty
            _TEXT_COMMENT = String.Empty
            _STATUS = String.Empty
            _TRANS_ID = String.Empty
            _VAL_AMOUNT = 0.0R
            _NUM_VOUCHER = String.Empty
            _CURRENCY_ID = String.Empty
            _TYPE = String.Empty
            _TYPE_EXCHANGE = 0.0R
            _PRICE_SALES = 0.0R
            _TOTAL_SALES = String.Empty
            _DATE_CADUCATE = String.Empty
            _RETURN_AMOUNT = 0.0R
            _AUTHORIZED = String.Empty
            _PART_DESCRIPTION = String.Empty
            _DISCOUNT_PERCENT = 0.0R
            _TAX_PERCENT = 0.0R
            _DISCOUNT_CUST = 0.0R
            _DISCOUNT_SP = 0.0R
            _NUMBER_INVOICE = String.Empty
            _NUMBER_LOT = String.Empty
            _UNIT_PART = String.Empty
            _ORDER_MANUFACT_ID = String.Empty
            _EQUIP_ID = String.Empty
            _FREIGTH = 0.0R
            _ITEMI = String.Empty
            _QTY_BRUTE = 0.0R
            _DISCOUNT_PER_QTY = 0.0R
            _STATUS_VALUE = 0
            _UNIT_REFERENCE = String.Empty
            _QTY_REFERENCE = 0.0R
            _COMMENT = String.Empty
            _REFERENCE = String.Empty
            _ACCOUNT = String.Empty
            _COMMENT_TEXT = String.Empty
            _PROJECT_ID = String.Empty
            _PROCEDENCIA = String.Empty
            _PAIS_ORIGEN = String.Empty
            _QTY_BULTOS_ANALIZADOS = 0
        End Sub

        Public Property QTY_BULTOS_ANALIZADOS As Integer
            Get
                Return _QTY_BULTOS_ANALIZADOS
            End Get
            Set(value As Integer)
                _QTY_BULTOS_ANALIZADOS = value
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

        Public Property DOCUMENT_ID As String
            Get
                Return _DOCUMENT_ID
            End Get
            Set(value As String)
                _DOCUMENT_ID = value
            End Set
        End Property




        Public Property PROCEDENCIA As String
            Get
                Return _PROCEDENCIA
            End Get
            Set(value As String)
                _PROCEDENCIA = value
            End Set
        End Property

        Public Property PAIS_ORIGEN As String
            Get
                Return _PAIS_ORIGEN
            End Get
            Set(value As String)
                _PAIS_ORIGEN = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
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

        Public Property REF_ID As String
            Get
                Return _REF_ID
            End Get
            Set(value As String)
                _REF_ID = value
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

        Public Property QTY_DLV As Double
            Get
                Return _QTY_DLV
            End Get
            Set(value As Double)
                _QTY_DLV = value
            End Set
        End Property

        Public Property QTY_REF As Double
            Get
                Return _QTY_REF
            End Get
            Set(value As Double)
                _QTY_REF = value
            End Set
        End Property

        Public Property QTY_INVOICED As Double
            Get
                Return _QTY_INVOICED
            End Get
            Set(value As Double)
                _QTY_INVOICED = value
            End Set
        End Property

        Public Property NUM_ORDER As String
            Get
                Return _NUM_ORDER
            End Get
            Set(value As String)
                _NUM_ORDER = value
            End Set
        End Property

        Public Property UNIT_PRICE As Double
            Get
                Return _UNIT_PRICE
            End Get
            Set(value As Double)
                _UNIT_PRICE = value
            End Set
        End Property

        Public Property AVERAGE_COST As Double
            Get
                Return _AVERAGE_COST
            End Get
            Set(value As Double)
                _AVERAGE_COST = value
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

        Public Property DISCOUNT As Double
            Get
                Return _DISCOUNT
            End Get
            Set(value As Double)
                _DISCOUNT = value
            End Set
        End Property

        Public Property STOCK As String
            Get
                Return _STOCK
            End Get
            Set(value As String)
                _STOCK = value
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

        Public Property AMOUNT_US As Double
            Get
                Return _AMOUNT_US
            End Get
            Set(value As Double)
                _AMOUNT_US = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property STATUS_DOC As String
            Get
                Return _STATUS_DOC
            End Get
            Set(value As String)
                _STATUS_DOC = value
            End Set
        End Property

        Public Property DATE_DOC As String
            Get
                Return _DATE_DOC
            End Get
            Set(value As String)
                _DATE_DOC = value
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

        Public Property WAREHOUSE_REF As String
            Get
                Return _WAREHOUSE_REF
            End Get
            Set(value As String)
                _WAREHOUSE_REF = value
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

        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
            End Set
        End Property

        Public Property TRANS_ID As String
            Get
                Return _TRANS_ID
            End Get
            Set(value As String)
                _TRANS_ID = value
            End Set
        End Property

        Public Property VAL_AMOUNT As Double
            Get
                Return _VAL_AMOUNT
            End Get
            Set(value As Double)
                _VAL_AMOUNT = value
            End Set
        End Property

        Public Property NUM_VOUCHER As String
            Get
                Return _NUM_VOUCHER
            End Get
            Set(value As String)
                _NUM_VOUCHER = value
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

        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property TYPE_EXCHANGE As Double
            Get
                Return _TYPE_EXCHANGE
            End Get
            Set(value As Double)
                _TYPE_EXCHANGE = value
            End Set
        End Property

        Public Property PRICE_SALES As Double
            Get
                Return _PRICE_SALES
            End Get
            Set(value As Double)
                _PRICE_SALES = value
            End Set
        End Property

        Public Property TOTAL_SALES As String
            Get
                Return _TOTAL_SALES
            End Get
            Set(value As String)
                _TOTAL_SALES = value
            End Set
        End Property

        Public Property DATE_CADUCATE As String
            Get
                Return _DATE_CADUCATE
            End Get
            Set(value As String)
                _DATE_CADUCATE = value
            End Set
        End Property

        Public Property RETURN_AMOUNT As Double
            Get
                Return _RETURN_AMOUNT
            End Get
            Set(value As Double)
                _RETURN_AMOUNT = value
            End Set
        End Property

        Public Property AUTHORIZED As String
            Get
                Return _AUTHORIZED
            End Get
            Set(value As String)
                _AUTHORIZED = value
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

        Public Property DISCOUNT_PERCENT As Double
            Get
                Return _DISCOUNT_PERCENT
            End Get
            Set(value As Double)
                _DISCOUNT_PERCENT = value
            End Set
        End Property

        Public Property TAX_PERCENT As Double
            Get
                Return _TAX_PERCENT
            End Get
            Set(value As Double)
                _TAX_PERCENT = value
            End Set
        End Property

        Public Property DISCOUNT_CUST As Double
            Get
                Return _DISCOUNT_CUST
            End Get
            Set(value As Double)
                _DISCOUNT_CUST = value
            End Set
        End Property

        Public Property DISCOUNT_SP As Double
            Get
                Return _DISCOUNT_SP
            End Get
            Set(value As Double)
                _DISCOUNT_SP = value
            End Set
        End Property

        Public Property NUMBER_INVOICE As String
            Get
                Return _NUMBER_INVOICE
            End Get
            Set(value As String)
                _NUMBER_INVOICE = value
            End Set
        End Property

        Public Property NUMBER_LOT As String
            Get
                Return _NUMBER_LOT
            End Get
            Set(value As String)
                _NUMBER_LOT = value
            End Set
        End Property

        Public Property UNIT_PART As String
            Get
                Return _UNIT_PART
            End Get
            Set(value As String)
                _UNIT_PART = value
            End Set
        End Property

        Public Property ORDER_MANUFACT_ID As String
            Get
                Return _ORDER_MANUFACT_ID
            End Get
            Set(value As String)
                _ORDER_MANUFACT_ID = value
            End Set
        End Property

        Public Property EQUIP_ID As String
            Get
                Return _EQUIP_ID
            End Get
            Set(value As String)
                _EQUIP_ID = value
            End Set
        End Property

        Public Property FREIGTH As Double
            Get
                Return _FREIGTH
            End Get
            Set(value As Double)
                _FREIGTH = value
            End Set
        End Property

        Public Property ITEMI As String
            Get
                Return _ITEMI
            End Get
            Set(value As String)
                _ITEMI = value
            End Set
        End Property

        Public Property QTY_BRUTE As Double
            Get
                Return _QTY_BRUTE
            End Get
            Set(value As Double)
                _QTY_BRUTE = value
            End Set
        End Property

        Public Property DISCOUNT_PER_QTY As Double
            Get
                Return _DISCOUNT_PER_QTY
            End Get
            Set(value As Double)
                _DISCOUNT_PER_QTY = value
            End Set
        End Property

        Public Property STATUS_VALUE As Integer
            Get
                Return _STATUS_VALUE
            End Get
            Set(value As Integer)
                _STATUS_VALUE = value
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

        Public Property QTY_REFERENCE As Double
            Get
                Return _QTY_REFERENCE
            End Get
            Set(value As Double)
                _QTY_REFERENCE = value
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

        Public Property REFERENCE As String
            Get
                Return _REFERENCE
            End Get
            Set(value As String)
                _REFERENCE = value
            End Set
        End Property

        Public Property ACCOUNT As String
            Get
                Return _ACCOUNT
            End Get
            Set(value As String)
                _ACCOUNT = value
            End Set
        End Property

        Public Property COMMENT_TEXT As String
            Get
                Return _COMMENT_TEXT
            End Get
            Set(value As String)
                _COMMENT_TEXT = value
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


        Public Property QT_BULTOS As Integer
            Get
                Return _QT_BULTOS
            End Get
            Set(value As Integer)
                _QT_BULTOS = value
            End Set
        End Property
        Public Property OPT_ENTREGA As String
            Get
                Return _OPT_ENTREGA
            End Get
            Set(value As String)
                _OPT_ENTREGA = value
            End Set
        End Property
        Public Property NUM_PROTOCOLOS As String
            Get
                Return _NUM_PROTOCOLOS
            End Get
            Set(value As String)
                _NUM_PROTOCOLOS = value
            End Set
        End Property
        Public Property NUMBER_ANALIS As String
            Get
                Return _NUMBER_ANALIS
            End Get
            Set(value As String)
                _NUMBER_ANALIS = value
            End Set
        End Property

    End Class






    Public Class WAREHOUSE_TRANS
        Private _WAREHOUSE_ID As String
        Private _DOCUMENT_ID As String
        Private _NUMBER_DOCUMENT As String
        Private _DATE_DOCUMENT As String
        Private _TYPE_TRANS As String
        Private _TRANS_ID As String
        Private _DOCUMENT_STATUS As String
        Private _DOC_ID_REF As String
        Private _NUM_ID_REF As String
        Private _AUTORIZED_ID As String
        Private _DATE_RETURN As String
        Private _VENDOR_ID As String
        Private _CCOST_ID As String
        Private _WAREHOUSE_REF As String
        Private _COMMENT As String
        Private _UPDATE_DATE As String
        Private _HOUR As String
        Private _USER_ID As String
        Private _CUSTOMER_ID As String
        Private _VAT_REGISTRATION As String
        Private _CUSTOMER_NAME As String
        Private _SALES_TERM As String
        Private _CURRENCY_TYPE As String
        Private _SALES_ID As String
        Private _CURRENCY_EXCHANGE As Double
        Private _TYPE_GUIA As String
        Private _STATUS_GUIA As String
        Private _RECEIVABLE_GUIA As String
        Private _ADDR_DLV As String
        Private _CARRIER_ID As String
        Private _NUMBER_PURCHASE As String
        Private _IS_GUIA_RETURN As String
        Private _VENDOR_NAME As String
        Private _NUMBER_ORDER As String
        Private _NUMBER_ESTIMATING As String
        Private _DISCOUNT_PER_CUST As Double
        Private _DISCOUNT_PER_SP As Double
        Private _AMOUNT As Double
        Private _CARRIER_NAME As String
        Private _CARRIER_ADDR As String
        Private _CARRIER_VAT As String
        Private _NUMBER_REGISTRATION As String
        Private _NUMBER_IMPORT As String
        Private _NUMBER_LIQ As String
        Private _PRINTER_STATUS As String
        Private _STATUS_CLOSE As Integer
        Private _TYPE_SHIPPER As String
        Private _ZONE_FREIGHT As String
        Private _IS_GUIA As Integer
        Private _IS_POST As Integer
        Private _FREIGHT As Double
        Private _ORDER_REF As String
        Private _COST As Double
        Private _RECEP_NAME As String
        Private _DOCUMENT_RECEP As String
        Private _NUM_ORDER_MANUFACT As String
        Private _INTERFACE As Integer
        Private _ACCOUNT As String
        Private _PROJECT_ID As String
        Private _TRAMA_ID As String
        Private _VEHICULO_ID As String
        Private _EMPTRA_ID As String
        Private _MOV_OPTION_ID As String
        Private _STATUS_CONTROL As String


        Public Sub New()
            _WAREHOUSE_ID = String.Empty
            _DOCUMENT_ID = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _DATE_DOCUMENT = String.Empty
            _TYPE_TRANS = String.Empty
            _TRANS_ID = String.Empty
            _DOCUMENT_STATUS = String.Empty
            _DOC_ID_REF = String.Empty
            _NUM_ID_REF = String.Empty
            _AUTORIZED_ID = String.Empty
            _DATE_RETURN = String.Empty
            _VENDOR_ID = String.Empty
            _CCOST_ID = String.Empty
            _WAREHOUSE_REF = String.Empty
            _COMMENT = String.Empty
            _UPDATE_DATE = String.Empty
            _HOUR = String.Empty
            _USER_ID = String.Empty
            _CUSTOMER_ID = String.Empty
            _VAT_REGISTRATION = String.Empty
            _CUSTOMER_NAME = String.Empty
            _SALES_TERM = String.Empty
            _CURRENCY_TYPE = String.Empty
            _SALES_ID = String.Empty
            _CURRENCY_EXCHANGE = 0.0R
            _TYPE_GUIA = String.Empty
            _STATUS_GUIA = String.Empty
            _RECEIVABLE_GUIA = String.Empty
            _ADDR_DLV = String.Empty
            _CARRIER_ID = String.Empty
            _NUMBER_PURCHASE = String.Empty
            _IS_GUIA_RETURN = String.Empty
            _VENDOR_NAME = String.Empty
            _NUMBER_ORDER = String.Empty
            _NUMBER_ESTIMATING = String.Empty
            _DISCOUNT_PER_CUST = 0.0R
            _DISCOUNT_PER_SP = 0.0R
            _AMOUNT = 0.0R
            _CARRIER_NAME = String.Empty
            _CARRIER_ADDR = String.Empty
            _CARRIER_VAT = String.Empty
            _NUMBER_REGISTRATION = String.Empty
            _NUMBER_IMPORT = String.Empty
            _NUMBER_LIQ = String.Empty
            _PRINTER_STATUS = String.Empty
            _STATUS_CLOSE = 0
            _TYPE_SHIPPER = String.Empty
            _ZONE_FREIGHT = String.Empty
            _IS_GUIA = 0
            _IS_POST = 0
            _FREIGHT = 0.0R
            _ORDER_REF = String.Empty
            _COST = 0.0R
            _RECEP_NAME = String.Empty
            _DOCUMENT_RECEP = String.Empty
            _NUM_ORDER_MANUFACT = String.Empty
            _INTERFACE = 0
            _ACCOUNT = String.Empty
            _PROJECT_ID = String.Empty
            _TRAMA_ID = String.Empty
            _VEHICULO_ID = String.Empty
            _EMPTRA_ID = String.Empty
            _STATUS_CONTROL = String.Empty
        End Sub
        Public Property MOV_OPTION_ID As String
            Get
                Return _MOV_OPTION_ID
            End Get
            Set(value As String)
                _MOV_OPTION_ID = value
            End Set
        End Property

        Public Property STATUS_CONTROL As String
            Get
                Return _STATUS_CONTROL
            End Get
            Set(value As String)
                _STATUS_CONTROL = value
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

        Public Property DOCUMENT_ID As String
            Get
                Return _DOCUMENT_ID
            End Get
            Set(value As String)
                _DOCUMENT_ID = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
            End Set
        End Property

        Public Property DATE_DOCUMENT As String
            Get
                Return _DATE_DOCUMENT
            End Get
            Set(value As String)
                _DATE_DOCUMENT = value
            End Set
        End Property

        Public Property TYPE_TRANS As String
            Get
                Return _TYPE_TRANS
            End Get
            Set(value As String)
                _TYPE_TRANS = value
            End Set
        End Property

        Public Property TRANS_ID As String
            Get
                Return _TRANS_ID
            End Get
            Set(value As String)
                _TRANS_ID = value
            End Set
        End Property

        Public Property DOCUMENT_STATUS As String
            Get
                Return _DOCUMENT_STATUS
            End Get
            Set(value As String)
                _DOCUMENT_STATUS = value
            End Set
        End Property

        Public Property DOC_ID_REF As String
            Get
                Return _DOC_ID_REF
            End Get
            Set(value As String)
                _DOC_ID_REF = value
            End Set
        End Property

        Public Property NUM_ID_REF As String
            Get
                Return _NUM_ID_REF
            End Get
            Set(value As String)
                _NUM_ID_REF = value
            End Set
        End Property

        Public Property DATE_RETURN As String
            Get
                Return _DATE_RETURN
            End Get
            Set(value As String)
                _DATE_RETURN = value
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

        Public Property CCOST_ID As String
            Get
                Return _CCOST_ID
            End Get
            Set(value As String)
                _CCOST_ID = value
            End Set
        End Property

        Public Property WAREHOUSE_REF As String
            Get
                Return _WAREHOUSE_REF
            End Get
            Set(value As String)
                _WAREHOUSE_REF = value
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

        Public Property UPDATE_DATE As String
            Get
                Return _UPDATE_DATE
            End Get
            Set(value As String)
                _UPDATE_DATE = value
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

        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property

        Public Property CUSTOMER_ID As String
            Get
                Return _CUSTOMER_ID
            End Get
            Set(value As String)
                _CUSTOMER_ID = value
            End Set
        End Property

        Public Property VAT_REGISTRATION As String
            Get
                Return _VAT_REGISTRATION
            End Get
            Set(value As String)
                _VAT_REGISTRATION = value
            End Set
        End Property

        Public Property CUSTOMER_NAME As String
            Get
                Return _CUSTOMER_NAME
            End Get
            Set(value As String)
                _CUSTOMER_NAME = value
            End Set
        End Property

        Public Property SALES_TERM As String
            Get
                Return _SALES_TERM
            End Get
            Set(value As String)
                _SALES_TERM = value
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

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
            End Set
        End Property

        Public Property CURRENCY_EXCHANGE As Double
            Get
                Return _CURRENCY_EXCHANGE
            End Get
            Set(value As Double)
                _CURRENCY_EXCHANGE = value
            End Set
        End Property

        Public Property TYPE_GUIA As String
            Get
                Return _TYPE_GUIA
            End Get
            Set(value As String)
                _TYPE_GUIA = value
            End Set
        End Property

        Public Property STATUS_GUIA As String
            Get
                Return _STATUS_GUIA
            End Get
            Set(value As String)
                _STATUS_GUIA = value
            End Set
        End Property

        Public Property RECEIVABLE_GUIA As String
            Get
                Return _RECEIVABLE_GUIA
            End Get
            Set(value As String)
                _RECEIVABLE_GUIA = value
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

        Public Property CARRIER_ID As String
            Get
                Return _CARRIER_ID
            End Get
            Set(value As String)
                _CARRIER_ID = value
            End Set
        End Property

        Public Property NUMBER_PURCHASE As String
            Get
                Return _NUMBER_PURCHASE
            End Get
            Set(value As String)
                _NUMBER_PURCHASE = value
            End Set
        End Property

        Public Property IS_GUIA_RETURN As String
            Get
                Return _IS_GUIA_RETURN
            End Get
            Set(value As String)
                _IS_GUIA_RETURN = value
            End Set
        End Property

        Public Property VENDOR_NAME As String
            Get
                Return _VENDOR_NAME
            End Get
            Set(value As String)
                _VENDOR_NAME = value
            End Set
        End Property

        Public Property NUMBER_ORDER As String
            Get
                Return _NUMBER_ORDER
            End Get
            Set(value As String)
                _NUMBER_ORDER = value
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

        Public Property DISCOUNT_PER_CUST As Double
            Get
                Return _DISCOUNT_PER_CUST
            End Get
            Set(value As Double)
                _DISCOUNT_PER_CUST = value
            End Set
        End Property

        Public Property DISCOUNT_PER_SP As Double
            Get
                Return _DISCOUNT_PER_SP
            End Get
            Set(value As Double)
                _DISCOUNT_PER_SP = value
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

        Public Property CARRIER_NAME As String
            Get
                Return _CARRIER_NAME
            End Get
            Set(value As String)
                _CARRIER_NAME = value
            End Set
        End Property

        Public Property CARRIER_ADDR As String
            Get
                Return _CARRIER_ADDR
            End Get
            Set(value As String)
                _CARRIER_ADDR = value
            End Set
        End Property

        Public Property CARRIER_VAT As String
            Get
                Return _CARRIER_VAT
            End Get
            Set(value As String)
                _CARRIER_VAT = value
            End Set
        End Property

        Public Property NUMBER_REGISTRATION As String
            Get
                Return _NUMBER_REGISTRATION
            End Get
            Set(value As String)
                _NUMBER_REGISTRATION = value
            End Set
        End Property

        Public Property NUMBER_IMPORT As String
            Get
                Return _NUMBER_IMPORT
            End Get
            Set(value As String)
                _NUMBER_IMPORT = value
            End Set
        End Property

        Public Property NUMBER_LIQ As String
            Get
                Return _NUMBER_LIQ
            End Get
            Set(value As String)
                _NUMBER_LIQ = value
            End Set
        End Property

        Public Property PRINTER_STATUS As String
            Get
                Return _PRINTER_STATUS
            End Get
            Set(value As String)
                _PRINTER_STATUS = value
            End Set
        End Property

        Public Property STATUS_CLOSE As Integer
            Get
                Return _STATUS_CLOSE
            End Get
            Set(value As Integer)
                _STATUS_CLOSE = value
            End Set
        End Property

        Public Property TYPE_SHIPPER As String
            Get
                Return _TYPE_SHIPPER
            End Get
            Set(value As String)
                _TYPE_SHIPPER = value
            End Set
        End Property

        Public Property ZONE_FREIGHT As String
            Get
                Return _ZONE_FREIGHT
            End Get
            Set(value As String)
                _ZONE_FREIGHT = value
            End Set
        End Property

        Public Property IS_GUIA As Integer
            Get
                Return _IS_GUIA
            End Get
            Set(value As Integer)
                _IS_GUIA = value
            End Set
        End Property

        Public Property IS_POST As Integer
            Get
                Return _IS_POST
            End Get
            Set(value As Integer)
                _IS_POST = value
            End Set
        End Property

        Public Property FREIGHT As Double
            Get
                Return _FREIGHT
            End Get
            Set(value As Double)
                _FREIGHT = value
            End Set
        End Property

        Public Property ORDER_REF As String
            Get
                Return _ORDER_REF
            End Get
            Set(value As String)
                _ORDER_REF = value
            End Set
        End Property

        Public Property COST As Double
            Get
                Return _COST
            End Get
            Set(value As Double)
                _COST = value
            End Set
        End Property

        Public Property RECEP_NAME As String
            Get
                Return _RECEP_NAME
            End Get
            Set(value As String)
                _RECEP_NAME = value
            End Set
        End Property

        Public Property DOCUMENT_RECEP As String
            Get
                Return _DOCUMENT_RECEP
            End Get
            Set(value As String)
                _DOCUMENT_RECEP = value
            End Set
        End Property

        Public Property NUM_ORDER_MANUFACT As String
            Get
                Return _NUM_ORDER_MANUFACT
            End Get
            Set(value As String)
                _NUM_ORDER_MANUFACT = value
            End Set
        End Property

        Public Property INTERFACEE As Integer
            Get
                Return _INTERFACE
            End Get
            Set(value As Integer)
                _INTERFACE = value
            End Set
        End Property

        Public Property ACCOUNT As String
            Get
                Return _ACCOUNT
            End Get
            Set(value As String)
                _ACCOUNT = value
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

        Public Property TRAMA_ID As String
            Get
                Return _TRAMA_ID
            End Get
            Set(value As String)
                _TRAMA_ID = value
            End Set
        End Property

        Public Property VEHICULO_ID As String
            Get
                Return _VEHICULO_ID
            End Get
            Set(value As String)
                _VEHICULO_ID = value
            End Set
        End Property

        Public Property EMPTRA_ID As String
            Get
                Return _EMPTRA_ID
            End Get
            Set(value As String)
                _EMPTRA_ID = value
            End Set
        End Property

    End Class

    Public Class WAREHOUSE_TRANS_LINE_BULTOS
        Private _WAREHOUSE_ID As String
        Private _DOCUMENT_ID As String
        Private _NUMBER_DOCUMENT As String
        Private _DATE_DOCUMENT As String
        Private _TYPE_TRANS As String
        Private _PART_ID As String
        Private _LOTE As String
        Private _QTY As Double
        Private _QTY_BULTOS As Double
        Private _ITEM As Integer
        Private _QTY_ANALISIS As Double
        Private _QTY_LIBERACION As Double


        Public Sub New()
            _WAREHOUSE_ID = String.Empty
            _DOCUMENT_ID = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _DATE_DOCUMENT = String.Empty
            _TYPE_TRANS = String.Empty
            _PART_ID = String.Empty
            _LOTE = String.Empty
            _QTY = 0.0R
            _QTY_BULTOS = 0.0R
            _ITEM = 0
            _QTY_ANALISIS = 0.0R
            _QTY_LIBERACION = 0.0R
        End Sub

        Public Property WAREHOUSE_ID As String
            Get
                Return _WAREHOUSE_ID
            End Get
            Set(value As String)
                _WAREHOUSE_ID = value
            End Set
        End Property

        Public Property DOCUMENT_ID As String
            Get
                Return _DOCUMENT_ID
            End Get
            Set(value As String)
                _DOCUMENT_ID = value
            End Set
        End Property


        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
            End Set
        End Property

        Public Property DATE_DOCUMENT As String
            Get
                Return _DATE_DOCUMENT
            End Get
            Set(value As String)
                _DATE_DOCUMENT = value
            End Set
        End Property

        Public Property TYPE_TRANS As String
            Get
                Return _TYPE_TRANS
            End Get
            Set(value As String)
                _TYPE_TRANS = value
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

        Public Property LOTE As String
            Get
                Return _LOTE
            End Get
            Set(value As String)
                _LOTE = value
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

        Public Property QTY_BULTOS As Double
            Get
                Return _QTY_BULTOS
            End Get
            Set(value As Double)
                _QTY_BULTOS = value
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

        Public Property QTY_ANALISIS As Double
            Get
                Return _QTY_ANALISIS
            End Get
            Set(value As Double)
                _QTY_ANALISIS = value
            End Set
        End Property

        Public Property QTY_LIBERACION As Double
            Get
                Return _QTY_LIBERACION
            End Get
            Set(value As Double)
                _QTY_LIBERACION = value
            End Set
        End Property

    End Class

    Public Class CURRENCY_EXCHANGE
        Private _CURRENCY_ID As String
        Private _CURRENCY_DATE As String
        Private _BUY_RATE As Double
        Private _BUY_EQUIV As Double
        Private _SELL_RATE As Double
        Private _SELL_EQUIV As Double

        Public Sub New()
            _CURRENCY_ID = String.Empty
            _CURRENCY_DATE = String.Empty
            _BUY_RATE = 0.0R
            _BUY_EQUIV = 0.0R
            _SELL_RATE = 0.0R
            _SELL_EQUIV = 0.0R
        End Sub

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property

        Public Property CURRENCY_DATE As String
            Get
                Return _CURRENCY_DATE
            End Get
            Set(value As String)
                _CURRENCY_DATE = value
            End Set
        End Property

        Public Property BUY_RATE As Double
            Get
                Return _BUY_RATE
            End Get
            Set(value As Double)
                _BUY_RATE = value
            End Set
        End Property

        Public Property BUY_EQUIV As Double
            Get
                Return _BUY_EQUIV
            End Get
            Set(value As Double)
                _BUY_EQUIV = value
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

        Public Property SELL_EQUIV As Double
            Get
                Return _SELL_EQUIV
            End Get
            Set(value As Double)
                _SELL_EQUIV = value
            End Set
        End Property

    End Class

    Public Class NUMBER_DOCUMENT
        Private _TYPE_DOC As String
        Private _NUMBER_SERIE As String
        Private _BEGIN_NUMBER As String
        Private _END_NUMBER As String
        Private _LAST_NUMBER As String

        Public Sub New()
            _TYPE_DOC = String.Empty
            _NUMBER_SERIE = String.Empty
            _BEGIN_NUMBER = String.Empty
            _END_NUMBER = String.Empty
            _LAST_NUMBER = String.Empty
        End Sub

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property BEGIN_NUMBER As String
            Get
                Return _BEGIN_NUMBER
            End Get
            Set(value As String)
                _BEGIN_NUMBER = value
            End Set
        End Property

        Public Property END_NUMBER As String
            Get
                Return _END_NUMBER
            End Get
            Set(value As String)
                _END_NUMBER = value
            End Set
        End Property

        Public Property LAST_NUMBER As String
            Get
                Return _LAST_NUMBER
            End Get
            Set(value As String)
                _LAST_NUMBER = value
            End Set
        End Property
    End Class

    Public Class SALES_PLACE
        Private _COMPANY_ID As String
        Private _SALES_PLACE_ID As String
        Private _SALES_PLACE_DESCRIPTION As String
        Private _SALES_PLACE_ADDR As String
        Private _WAREHOUSE_ID As String
        Private _CCOST_ID As String

        Public Sub New()
            _COMPANY_ID = String.Empty
            _SALES_PLACE_ID = String.Empty
            _SALES_PLACE_DESCRIPTION = String.Empty
            _SALES_PLACE_ADDR = String.Empty
            _WAREHOUSE_ID = String.Empty
            _CCOST_ID = String.Empty
        End Sub

        Public Property COMPANY_ID As String
            Get
                Return _COMPANY_ID
            End Get
            Set(value As String)
                _COMPANY_ID = value
            End Set
        End Property

        Public Property SALES_PLACE_ID As String
            Get
                Return _SALES_PLACE_ID
            End Get
            Set(value As String)
                _SALES_PLACE_ID = value
            End Set
        End Property

        Public Property SALES_PLACE_DESCRIPTION As String
            Get
                Return _SALES_PLACE_DESCRIPTION
            End Get
            Set(value As String)
                _SALES_PLACE_DESCRIPTION = value
            End Set
        End Property

        Public Property SALES_PLACE_ADDR As String
            Get
                Return _SALES_PLACE_ADDR
            End Get
            Set(value As String)
                _SALES_PLACE_ADDR = value
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

        Public Property CCOST_ID As String
            Get
                Return _CCOST_ID
            End Get
            Set(value As String)
                _CCOST_ID = value
            End Set
        End Property
    End Class

    Public Class CUSTOMER_BALANCE
        Private _CUSTOMER_ID As String
        Private _DOCUMENT_ID As String
        Private _NUMBER_DOC As String
        Private _DOC_DATE As String
        Private _CADUCATE_DATE As String
        Private _DOCUMENT_REF As String
        Private _NUMBER_REF As String
        Private _SALES_ID As String
        Private _AMOUNT As Double
        Private _AMOUNT_BALANCE As Double
        Private _CURRENCY_ID As String
        Private _SELL_RATE As Double
        Private _IS_DR_CR As String
        Private _STATUS As String
        Private _CREATE_DATE As String
        Private _LAST_MODIFIED As String
        Private _USER_ID As String
        Private _ACCOUNT As String
        Private _AMOUNT_COMM As Double
        Private _TYPE_REC As String
        Private _REFERENCE_DATE As String
        Private _IS_CHECK_DIF As String
        Private _AMOUNT_BALANCE_INI
        Private _TERMS As String
        Private _PLACE_SALES As String
        Private _BANK_ID As String
        Private _BANK_DESCRIPTION As String
        Private _AMOUNT_PER As Double
        Private _PERCENT_PER As Double
        Private _ACCOUNT_PER As String
        Private _CUST_AUTO As String

        Private _SERIE_AUX As String
        Private _NUM_DOC_AUX As String
        Private _AMOUNT_DETRAC As Double
        Private _PERCENT_DETRAC As Double
        Private _SALDO As Double

        Public Sub New()
            _CUSTOMER_ID = String.Empty
            _DOCUMENT_ID = String.Empty
            _NUMBER_DOC = String.Empty
            _DOC_DATE = String.Empty
            _CADUCATE_DATE = String.Empty
            _DOCUMENT_REF = String.Empty
            _NUMBER_REF = String.Empty
            _SALES_ID = String.Empty
            _AMOUNT = 0.0R
            _AMOUNT_BALANCE = 0.0R
            _CURRENCY_ID = String.Empty
            _SELL_RATE = 0.0R
            _IS_DR_CR = String.Empty
            _STATUS = String.Empty
            _CREATE_DATE = String.Empty
            _LAST_MODIFIED = String.Empty
            _USER_ID = String.Empty
            _ACCOUNT = String.Empty
            _AMOUNT_COMM = 0.0R
            _TYPE_REC = String.Empty
            _REFERENCE_DATE = String.Empty
            _IS_CHECK_DIF = String.Empty
            _AMOUNT_BALANCE_INI = 0.0R
            _TERMS = String.Empty
            _PLACE_SALES = String.Empty
            _BANK_ID = String.Empty
            _BANK_DESCRIPTION = String.Empty
            _AMOUNT_PER = 0.0R
            _PERCENT_PER = 0.0R
            _ACCOUNT_PER = String.Empty
            _CUST_AUTO = String.Empty
            _SERIE_AUX = String.Empty
            _NUM_DOC_AUX = String.Empty
            _AMOUNT_DETRAC = 0.0
            _PERCENT_DETRAC = 0.0
            _SALDO = 0.0
        End Sub

        Public Property SALDO As Double
            Get
                Return _SALDO
            End Get
            Set(value As Double)
                _SALDO = value
            End Set
        End Property

        Public Property AMOUNT_DETRAC As Double
            Get
                Return _AMOUNT_DETRAC
            End Get
            Set(value As Double)
                _AMOUNT_DETRAC = value
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


        Public Property CUSTOMER_ID As String
            Get
                Return _CUSTOMER_ID
            End Get
            Set(value As String)
                _CUSTOMER_ID = value
            End Set
        End Property

        Public Property DOCUMENT_ID As String
            Get
                Return _DOCUMENT_ID
            End Get
            Set(value As String)
                _DOCUMENT_ID = value
            End Set
        End Property


        Public Property NUMBER_DOC As String
            Get
                Return _NUMBER_DOC
            End Get
            Set(value As String)
                _NUMBER_DOC = value
            End Set
        End Property

        Public Property DOC_DATE As String
            Get
                Return _DOC_DATE
            End Get
            Set(value As String)
                _DOC_DATE = value
            End Set
        End Property

        Public Property CADUCATE_DATE As String
            Get
                Return _CADUCATE_DATE
            End Get
            Set(value As String)
                _CADUCATE_DATE = value
            End Set
        End Property

        Public Property DOCUMENT_REF As String
            Get
                Return _DOCUMENT_REF
            End Get
            Set(value As String)
                _DOCUMENT_REF = value
            End Set
        End Property

        Public Property NUMBER_REF As String
            Get
                Return _NUMBER_REF
            End Get
            Set(value As String)
                _NUMBER_REF = value
            End Set
        End Property

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
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


        Public Property AMOUNT_BALANCE As Double
            Get
                Return _AMOUNT_BALANCE
            End Get
            Set(value As Double)
                _AMOUNT_BALANCE = value
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

        Public Property SELL_RATE As Double
            Get
                Return _SELL_RATE
            End Get
            Set(value As Double)
                _SELL_RATE = value
            End Set
        End Property

        Public Property IS_DR_CR As String
            Get
                Return _IS_DR_CR
            End Get
            Set(value As String)
                _IS_DR_CR = value
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


        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
                _CREATE_DATE = value
            End Set
        End Property

        Public Property LAST_MODIFIED As String
            Get
                Return _LAST_MODIFIED
            End Get
            Set(value As String)
                _LAST_MODIFIED = value
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

        Public Property ACCOUNT As String
            Get
                Return _ACCOUNT
            End Get
            Set(value As String)
                _ACCOUNT = value
            End Set
        End Property

        Public Property AMOUNT_COMM As Double
            Get
                Return _AMOUNT_COMM
            End Get
            Set(value As Double)
                _AMOUNT_COMM = value
            End Set
        End Property

        Public Property TYPE_REC As String
            Get
                Return _TYPE_REC
            End Get
            Set(value As String)
                _TYPE_REC = value
            End Set
        End Property

        Public Property REFERENCE_DATE As String
            Get
                Return _REFERENCE_DATE
            End Get
            Set(value As String)
                _REFERENCE_DATE = value
            End Set
        End Property

        Public Property IS_CHECK_DIF As String
            Get
                Return _IS_CHECK_DIF
            End Get
            Set(value As String)
                _IS_CHECK_DIF = value
            End Set
        End Property

        Public Property AMOUNT_BALANCE_INI As Double
            Get
                Return _AMOUNT_BALANCE_INI
            End Get
            Set(value As Double)
                _AMOUNT_BALANCE_INI = value
            End Set
        End Property

        Public Property TERMS As String
            Get
                Return _TERMS
            End Get
            Set(value As String)
                _TERMS = value
            End Set
        End Property

        Public Property PLACE_SALES As String
            Get
                Return _PLACE_SALES
            End Get
            Set(value As String)
                _PLACE_SALES = value
            End Set
        End Property

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
            End Set
        End Property

        Public Property BANK_DESCRIPTION As String
            Get
                Return _BANK_DESCRIPTION
            End Get
            Set(value As String)
                _BANK_DESCRIPTION = value
            End Set
        End Property

        Public Property AMOUNT_PER As Double
            Get
                Return _AMOUNT_PER
            End Get
            Set(value As Double)
                _AMOUNT_PER = value
            End Set
        End Property

        Public Property PERCENT_PER As Double
            Get
                Return _PERCENT_PER
            End Get
            Set(value As Double)
                _PERCENT_PER = value
            End Set
        End Property

        Public Property ACCOUNT_PER As String
            Get
                Return _ACCOUNT_PER
            End Get
            Set(value As String)
                _ACCOUNT_PER = value
            End Set
        End Property

        Public Property CUST_AUTO As String
            Get
                Return _CUST_AUTO
            End Get
            Set(value As String)
                _CUST_AUTO = value
            End Set
        End Property

        Public Property SERIE_AUX As String
            Get
                Return _SERIE_AUX
            End Get
            Set(value As String)
                _SERIE_AUX = value
            End Set
        End Property

        Public Property NUM_DOC_AUX As String
            Get
                Return _NUM_DOC_AUX
            End Get
            Set(value As String)
                _NUM_DOC_AUX = value
            End Set
        End Property
    End Class

    Public Class RECEIVABLE_LINE

        Private _DOCUMENT_ID As String
        Private _NUMBER_SERIE As String
        Private _NUMBER_DOCUMENT As String
        Private _ITEM As String
        Private _PART_ID As String
        Private _QTY As Double
        Private _PRICE_SALES As Double
        Private _PRICE_ORI As Double
        Private _DISCOUNT As Double
        Private _AMOUNT_TAX As Double
        Private _TAX_PERCENT As Double
        Private _AMOUNT_US As Double
        Private _AMOUNT As Double
        Private _UNIT As String
        Private _STATUS As String
        Private _PART_SERIE As String
        Private _WAREHOUSE_ID As String
        Private _TEXT_DESCRIPTION As String
        Private _DFTR As String
        Private _STOCK As String
        Private _PART_DESCRIPTION As String
        Private _QTY_REF As Double
        Private _DISCOUNT_PERCENT As Double
        Private _BALANCE_PART As Double
        Private _DISCOUNT_CUSTOMER As Double
        Private _DISCOUNT_SP As Double
        Private _PART_LOT As String
        Private _NUMBER_GUIA As String
        Private _PART_TAX As Integer
        Private _DISCOUNT1 As Double
        Private _DISCOUNT2 As Double
        Private _PERCENT1 As Double
        Private _PERCENT2 As Double
        Private _PRICE_LIST_ID As String
        Private _SHIPPER_QTY As Double
        Private _BUDGET_ID As String
        Private _ORDER_ID As String
        Private _BRUTE_QTY As Double
        Private _DISCOUNT_QTY_BRUTE As Double
        Private _UM_REFERENCE As String
        Private _QTY_REFERENCE As Double
        Private _COMISION As Double
        Private _TIPOISC As Double
        Private _ISCPOR As Double
        Private _ISC As Double
        Private _ITEM_INI As String

        Public Sub New()
            _DOCUMENT_ID = String.Empty
            _NUMBER_SERIE = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _ITEM = String.Empty
            _PART_ID = String.Empty
            _QTY = 0.0R
            _PRICE_SALES = 0.0R
            _PRICE_ORI = 0.0R
            _DISCOUNT = 0.0R
            _AMOUNT_TAX = 0.0R
            _TAX_PERCENT = 0.0R
            _AMOUNT_US = 0.0R
            _AMOUNT = 0.0R
            _UNIT = String.Empty
            _STATUS = String.Empty
            _PART_SERIE = String.Empty
            _WAREHOUSE_ID = String.Empty
            _TEXT_DESCRIPTION = String.Empty
            _DFTR = String.Empty
            _STOCK = String.Empty
            _PART_DESCRIPTION = String.Empty
            _QTY_REF = 0.0R
            _DISCOUNT_PERCENT = 0.0R
            _BALANCE_PART = 0.0R
            _DISCOUNT_CUSTOMER = 0.0R
            _DISCOUNT_SP = 0.0R
            _PART_LOT = String.Empty
            _NUMBER_GUIA = String.Empty
            _PART_TAX = 0
            _DISCOUNT1 = 0.0R
            _DISCOUNT2 = 0.0R
            _PERCENT1 = 0.0R
            _PERCENT2 = 0.0R
            _PRICE_LIST_ID = String.Empty
            _SHIPPER_QTY = 0.0R
            _BUDGET_ID = String.Empty
            _ORDER_ID = String.Empty
            _BRUTE_QTY = 0.0R
            _DISCOUNT_QTY_BRUTE = 0.0R
            _UM_REFERENCE = String.Empty
            _QTY_REFERENCE = 0.0R
            _COMISION = 0.0R
            _TIPOISC = 0.0R
            _ISCPOR = 0.0R
            _ISC = 0.0R
        End Sub

        Public Property ITEM_INI As String
            Get
                Return _ITEM_INI
            End Get
            Set(value As String)
                _ITEM_INI = value
            End Set

        End Property
        Public Property DOCUMENT_ID As String
            Get
                Return _DOCUMENT_ID
            End Get
            Set(value As String)
                _DOCUMENT_ID = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
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


        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
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


        Public Property PRICE_SALES As Double
            Get
                Return _PRICE_SALES
            End Get
            Set(value As Double)
                _PRICE_SALES = value
            End Set
        End Property


        Public Property PRICE_ORI As Double
            Get
                Return _PRICE_ORI
            End Get
            Set(value As Double)
                _PRICE_ORI = value
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


        Public Property TAX_PERCENT As Double
            Get
                Return _TAX_PERCENT
            End Get
            Set(value As Double)
                _TAX_PERCENT = value
            End Set
        End Property


        Public Property AMOUNT_US As Double
            Get
                Return _AMOUNT_US
            End Get
            Set(value As Double)
                _AMOUNT_US = value
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


        Public Property PART_SERIE As String
            Get
                Return _PART_SERIE
            End Get
            Set(value As String)
                _PART_SERIE = value
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


        Public Property TEXT_DESCRIPTION As String
            Get
                Return _TEXT_DESCRIPTION
            End Get
            Set(value As String)
                _TEXT_DESCRIPTION = value
            End Set
        End Property


        Public Property DFTR As String
            Get
                Return _DFTR
            End Get
            Set(value As String)
                _DFTR = value
            End Set
        End Property


        Public Property STOCK As String
            Get
                Return _STOCK
            End Get
            Set(value As String)
                _STOCK = value
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


        Public Property QTY_REF As Double
            Get
                Return _QTY_REF
            End Get
            Set(value As Double)
                _QTY_REF = value
            End Set
        End Property


        Public Property DISCOUNT_PERCENT As Double
            Get
                Return _DISCOUNT_PERCENT
            End Get
            Set(value As Double)
                _DISCOUNT_PERCENT = value
            End Set
        End Property


        Public Property BALANCE_PART As Double
            Get
                Return _BALANCE_PART
            End Get
            Set(value As Double)
                _BALANCE_PART = value
            End Set
        End Property


        Public Property DISCOUNT_CUSTOMER As Double
            Get
                Return _DISCOUNT_CUSTOMER
            End Get
            Set(value As Double)
                _DISCOUNT_CUSTOMER = value
            End Set
        End Property


        Public Property DISCOUNT_SP As String
            Get
                Return _DISCOUNT_SP
            End Get
            Set(value As String)
                _DISCOUNT_SP = value
            End Set
        End Property


        Public Property PART_LOT As String
            Get
                Return _PART_LOT
            End Get
            Set(value As String)
                _PART_LOT = value
            End Set
        End Property


        Public Property NUMBER_GUIA As String
            Get
                Return _NUMBER_GUIA
            End Get
            Set(value As String)
                _NUMBER_GUIA = value
            End Set
        End Property


        Public Property PART_TAX As Integer
            Get
                Return _PART_TAX
            End Get
            Set(value As Integer)
                _PART_TAX = value
            End Set
        End Property


        Public Property DISCOUNT1 As Double
            Get
                Return _DISCOUNT1
            End Get
            Set(value As Double)
                _DISCOUNT1 = value
            End Set
        End Property


        Public Property DISCOUNT2 As Double
            Get
                Return _DISCOUNT2
            End Get
            Set(value As Double)
                _DISCOUNT2 = value
            End Set
        End Property


        Public Property PERCENT1 As Double
            Get
                Return _PERCENT1
            End Get
            Set(value As Double)
                _PERCENT1 = value
            End Set
        End Property


        Public Property PERCENT2 As Double
            Get
                Return _PERCENT2
            End Get
            Set(value As Double)
                _PERCENT2 = value
            End Set
        End Property


        Public Property PRICE_LIST_ID As Double
            Get
                Return _PRICE_LIST_ID
            End Get
            Set(value As Double)
                _PRICE_LIST_ID = value
            End Set
        End Property


        Public Property SHIPPER_QTY As Double
            Get
                Return _SHIPPER_QTY
            End Get
            Set(value As Double)
                _SHIPPER_QTY = value
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


        Public Property ORDER_ID As Double
            Get
                Return _ORDER_ID
            End Get
            Set(value As Double)
                _ORDER_ID = value
            End Set
        End Property


        Public Property BRUTE_QTY As Double
            Get
                Return _BRUTE_QTY
            End Get
            Set(value As Double)
                _BRUTE_QTY = value
            End Set
        End Property


        Public Property DISCOUNT_QTY_BRUTE As String
            Get
                Return _DISCOUNT_QTY_BRUTE
            End Get
            Set(value As String)
                _DISCOUNT_QTY_BRUTE = value
            End Set
        End Property


        Public Property UM_REFERENCE As String
            Get
                Return _UM_REFERENCE
            End Get
            Set(value As String)
                _UM_REFERENCE = value
            End Set
        End Property


        Public Property QTY_REFERENCE As Double
            Get
                Return _QTY_REFERENCE
            End Get
            Set(value As Double)
                _QTY_REFERENCE = value
            End Set
        End Property


        Public Property COMISION As Double
            Get
                Return _COMISION
            End Get
            Set(value As Double)
                _COMISION = value
            End Set
        End Property

        Public Property TIPOISC As Double
            Get
                Return _TIPOISC
            End Get
            Set(value As Double)
                _TIPOISC = value
            End Set
        End Property

        Public Property ISCPOR As Double
            Get
                Return _ISCPOR
            End Get
            Set(value As Double)
                _ISCPOR = value
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

    End Class

    Public Class DEVOLUTION_LINE

        Private _DOCUMENT_ID As String
        Private _NUMBER_SERIE As String
        Private _NUMBER_DOCUMENT As String
        Private _ITEM As String
        Private _PART_ID As String
        Private _QTY As Double
        Private _PRICE_SALES As Double
        Private _PRICE_ORI As Double
        Private _DISCOUNT As Double
        Private _AMOUNT_TAX As Double
        Private _TAX_PERCENT As Double
        Private _AMOUNT_US As Double
        Private _AMOUNT As Double
        Private _UNIT As String
        Private _STATUS As String
        Private _PART_SERIE As String
        Private _WAREHOUSE_ID As String
        Private _TEXT_DESCRIPTION As String
        Private _DFTR As String
        Private _STOCK As String
        Private _PART_DESCRIPTION As String
        Private _QTY_REF As Double
        Private _DISCOUNT_PERCENT As Double
        Private _BALANCE_PART As Double
        Private _DISCOUNT_CUSTOMER As Double
        Private _DISCOUNT_SP As Double
        Private _PART_LOT As String
        Private _NUMBER_GUIA As String
        Private _PART_TAX As Integer
        Private _DISCOUNT1 As Double
        Private _DISCOUNT2 As Double
        Private _PERCENT1 As Double
        Private _PERCENT2 As Double
        Private _PRICE_LIST_ID As String
        Private _SHIPPER_QTY As Double
        Private _BUDGET_ID As String
        Private _ORDER_ID As String
        Private _BRUTE_QTY As Double
        Private _DISCOUNT_QTY_BRUTE As Double
        Private _UM_REFERENCE As String
        Private _QTY_REFERENCE As Double
        Private _COMISION As Double
        Private _TIPOISC As Double
        Private _ISCPOR As Double
        Private _ISC As Double

        Private _OBSERVACIONES As String
        Private _MOTIVO_DEVOLUCION As String
        Private _FIN_DEVOLUCION_ID As String
        Private _TEXTO_FIN_DEVOLUCION_ID As String
        Private _ALMACEN_DESTINO As String
        Private _TD_REF As String
        Private _SERIE_REF As String
        Private _NUM_DOC_REF As String
        Private _OPT_APROB As String

        Private _GENERO_NC_GUIA As String

        Public Sub New()
            _DOCUMENT_ID = String.Empty
            _NUMBER_SERIE = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _ITEM = String.Empty
            _PART_ID = String.Empty
            _QTY = 0.0R
            _PRICE_SALES = 0.0R
            _PRICE_ORI = 0.0R
            _DISCOUNT = 0.0R
            _AMOUNT_TAX = 0.0R
            _TAX_PERCENT = 0.0R
            _AMOUNT_US = 0.0R
            _AMOUNT = 0.0R
            _UNIT = String.Empty
            _STATUS = String.Empty
            _PART_SERIE = String.Empty
            _WAREHOUSE_ID = String.Empty
            _TEXT_DESCRIPTION = String.Empty
            _DFTR = String.Empty
            _STOCK = String.Empty
            _PART_DESCRIPTION = String.Empty
            _QTY_REF = 0.0R
            _DISCOUNT_PERCENT = 0.0R
            _BALANCE_PART = 0.0R
            _DISCOUNT_CUSTOMER = 0.0R
            _DISCOUNT_SP = 0.0R
            _PART_LOT = String.Empty
            _NUMBER_GUIA = String.Empty
            _PART_TAX = 0
            _DISCOUNT1 = 0.0R
            _DISCOUNT2 = 0.0R
            _PERCENT1 = 0.0R
            _PERCENT2 = 0.0R
            _PRICE_LIST_ID = String.Empty
            _SHIPPER_QTY = 0.0R
            _BUDGET_ID = String.Empty
            _ORDER_ID = String.Empty
            _BRUTE_QTY = 0.0R
            _DISCOUNT_QTY_BRUTE = 0.0R
            _UM_REFERENCE = String.Empty
            _QTY_REFERENCE = 0.0R
            _COMISION = 0.0R
            _TIPOISC = 0.0R
            _ISCPOR = 0.0R
            _ISC = 0.0R
        End Sub

        Public Property GENERO_NC_GUIA As String
            Get
                Return _GENERO_NC_GUIA
            End Get
            Set(value As String)
                _GENERO_NC_GUIA = value
            End Set
        End Property


        Public Property OPT_APROB As String
            Get
                Return _OPT_APROB
            End Get
            Set(value As String)
                _OPT_APROB = value
            End Set
        End Property


        Public Property OBSERVACIONES As String
            Get
                Return _OBSERVACIONES
            End Get
            Set(value As String)
                _OBSERVACIONES = value
            End Set
        End Property

        Public Property MOTIVO_DEVOLUCION As String
            Get
                Return _MOTIVO_DEVOLUCION
            End Get
            Set(value As String)
                _MOTIVO_DEVOLUCION = value
            End Set
        End Property

        Public Property FIN_DEVOLUCION_ID As String
            Get
                Return _FIN_DEVOLUCION_ID
            End Get
            Set(value As String)
                _FIN_DEVOLUCION_ID = value
            End Set
        End Property

        Public Property TEXTO_FIN_DEVOLUCION_ID As String
            Get
                Return _TEXTO_FIN_DEVOLUCION_ID
            End Get
            Set(value As String)
                _TEXTO_FIN_DEVOLUCION_ID = value
            End Set
        End Property

        Public Property ALMACEN_DESTINO As String
            Get
                Return _ALMACEN_DESTINO
            End Get
            Set(value As String)
                _ALMACEN_DESTINO = value
            End Set
        End Property

        Public Property TD_REF As String
            Get
                Return _TD_REF
            End Get
            Set(value As String)
                _TD_REF = value
            End Set
        End Property

        Public Property SERIE_REF As String
            Get
                Return _SERIE_REF
            End Get
            Set(value As String)
                _SERIE_REF = value
            End Set
        End Property

        Public Property NUM_DOC_REF As String
            Get
                Return _NUM_DOC_REF
            End Get
            Set(value As String)
                _NUM_DOC_REF = value
            End Set
        End Property



        Public Property DOCUMENT_ID As String
            Get
                Return _DOCUMENT_ID
            End Get
            Set(value As String)
                _DOCUMENT_ID = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
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


        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
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


        Public Property PRICE_SALES As Double
            Get
                Return _PRICE_SALES
            End Get
            Set(value As Double)
                _PRICE_SALES = value
            End Set
        End Property


        Public Property PRICE_ORI As Double
            Get
                Return _PRICE_ORI
            End Get
            Set(value As Double)
                _PRICE_ORI = value
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


        Public Property TAX_PERCENT As Double
            Get
                Return _TAX_PERCENT
            End Get
            Set(value As Double)
                _TAX_PERCENT = value
            End Set
        End Property


        Public Property AMOUNT_US As Double
            Get
                Return _AMOUNT_US
            End Get
            Set(value As Double)
                _AMOUNT_US = value
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


        Public Property PART_SERIE As String
            Get
                Return _PART_SERIE
            End Get
            Set(value As String)
                _PART_SERIE = value
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


        Public Property TEXT_DESCRIPTION As String
            Get
                Return _TEXT_DESCRIPTION
            End Get
            Set(value As String)
                _TEXT_DESCRIPTION = value
            End Set
        End Property


        Public Property DFTR As String
            Get
                Return _DFTR
            End Get
            Set(value As String)
                _DFTR = value
            End Set
        End Property


        Public Property STOCK As String
            Get
                Return _STOCK
            End Get
            Set(value As String)
                _STOCK = value
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


        Public Property QTY_REF As Double
            Get
                Return _QTY_REF
            End Get
            Set(value As Double)
                _QTY_REF = value
            End Set
        End Property


        Public Property DISCOUNT_PERCENT As Double
            Get
                Return _DISCOUNT_PERCENT
            End Get
            Set(value As Double)
                _DISCOUNT_PERCENT = value
            End Set
        End Property


        Public Property BALANCE_PART As Double
            Get
                Return _BALANCE_PART
            End Get
            Set(value As Double)
                _BALANCE_PART = value
            End Set
        End Property


        Public Property DISCOUNT_CUSTOMER As Double
            Get
                Return _DISCOUNT_CUSTOMER
            End Get
            Set(value As Double)
                _DISCOUNT_CUSTOMER = value
            End Set
        End Property


        Public Property DISCOUNT_SP As String
            Get
                Return _DISCOUNT_SP
            End Get
            Set(value As String)
                _DISCOUNT_SP = value
            End Set
        End Property


        Public Property PART_LOT As String
            Get
                Return _PART_LOT
            End Get
            Set(value As String)
                _PART_LOT = value
            End Set
        End Property


        Public Property NUMBER_GUIA As String
            Get
                Return _NUMBER_GUIA
            End Get
            Set(value As String)
                _NUMBER_GUIA = value
            End Set
        End Property


        Public Property PART_TAX As Integer
            Get
                Return _PART_TAX
            End Get
            Set(value As Integer)
                _PART_TAX = value
            End Set
        End Property


        Public Property DISCOUNT1 As Double
            Get
                Return _DISCOUNT1
            End Get
            Set(value As Double)
                _DISCOUNT1 = value
            End Set
        End Property


        Public Property DISCOUNT2 As Double
            Get
                Return _DISCOUNT2
            End Get
            Set(value As Double)
                _DISCOUNT2 = value
            End Set
        End Property


        Public Property PERCENT1 As Double
            Get
                Return _PERCENT1
            End Get
            Set(value As Double)
                _PERCENT1 = value
            End Set
        End Property


        Public Property PERCENT2 As Double
            Get
                Return _PERCENT2
            End Get
            Set(value As Double)
                _PERCENT2 = value
            End Set
        End Property


        Public Property PRICE_LIST_ID As Double
            Get
                Return _PRICE_LIST_ID
            End Get
            Set(value As Double)
                _PRICE_LIST_ID = value
            End Set
        End Property


        Public Property SHIPPER_QTY As Double
            Get
                Return _SHIPPER_QTY
            End Get
            Set(value As Double)
                _SHIPPER_QTY = value
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


        Public Property ORDER_ID As Double
            Get
                Return _ORDER_ID
            End Get
            Set(value As Double)
                _ORDER_ID = value
            End Set
        End Property


        Public Property BRUTE_QTY As Double
            Get
                Return _BRUTE_QTY
            End Get
            Set(value As Double)
                _BRUTE_QTY = value
            End Set
        End Property


        Public Property DISCOUNT_QTY_BRUTE As String
            Get
                Return _DISCOUNT_QTY_BRUTE
            End Get
            Set(value As String)
                _DISCOUNT_QTY_BRUTE = value
            End Set
        End Property


        Public Property UM_REFERENCE As String
            Get
                Return _UM_REFERENCE
            End Get
            Set(value As String)
                _UM_REFERENCE = value
            End Set
        End Property


        Public Property QTY_REFERENCE As Double
            Get
                Return _QTY_REFERENCE
            End Get
            Set(value As Double)
                _QTY_REFERENCE = value
            End Set
        End Property


        Public Property COMISION As Double
            Get
                Return _COMISION
            End Get
            Set(value As Double)
                _COMISION = value
            End Set
        End Property

        Public Property TIPOISC As Double
            Get
                Return _TIPOISC
            End Get
            Set(value As Double)
                _TIPOISC = value
            End Set
        End Property

        Public Property ISCPOR As Double
            Get
                Return _ISCPOR
            End Get
            Set(value As Double)
                _ISCPOR = value
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

    End Class

    Public Class DEVOLUTION

        Private _DOCUMENT_ID As String
        Private _NUMBER_SERIE As String
        Private _NUMBER_DOCUMENT As String
        Private _DOCUMENT_DATE As String
        Private _CADUCATE_DATE As String
        Private _DR_CR As String
        Private _SALES_REP_ID As String
        Private _PLACE_SALES As String
        Private _NUMBER_QUOTE As String
        Private _NUMBER_ORDER_PUR As String
        Private _CFDESCPG As String
        Private _POINT_ORIG As String
        Private _POINT_BOARD As String
        Private _POINT_ARRIVAL As String
        Private _RECEIVABLE_TYPE As String
        Private _CUSTOMER_ID As String
        Private _CUSTOMER_NAME As String
        Private _CUSTOMER_ADDR As String
        Private _VAT_REGISTRATION As String
        Private _WAREHOUSE_ID As String
        Private _AMOUNT As Double
        Private _TERMS_ID As String
        Private _BALANCE As Double
        Private _SELL_RATE As Double
        Private _CURRENCY_ID As String
        Private _DOCUMENT_REF As String
        Private _SERIE_REF As String
        Private _NUMBER_REF As String
        Private _NUMBER_ORDER As String
        Private _CREATE_DATE As String
        Private _LAST_MODIFIED As String
        Private _STATUS As String
        Private _USER_ID As String
        Private _COMMENT As String
        Private _IS_GUIA_REC As String
        Private _NUMBER_REGISTRATION As String
        Private _DISCOUNT_PERCENT As Double
        Private _DISCOUNT_PERCENT_SP As Double
        Private _CARD_ID As String
        Private _NUMBER_CARD As String
        Private _AMOUNT_CARD_US As Double
        Private _AMOUNT_CARD As Double
        Private _BANK_CHECK As String
        Private _NUMBER_CHECK As String
        Private _AMOUNT_CH_US As Double
        Private _AMOUNT_CH As Double
        Private _VOUCHER_ID As String
        Private _NUMBER_TRA As String
        Private _AMOUNT_TAX As Double
        Private _DISCOUNTV As Double
        Private _DISCOUNTP As Double
        Private _LIST_GUIA As String
        Private _IS_PRINT As Integer
        Private _DISCOUNT_RECIVABLE As Double
        Private _IS_CLOSED As Integer
        Private _SUB_ID As String
        Private _TOTAL_ERROR As Double
        Private _PROMISE_DAYS As Integer
        Private _SHIPPER_TYPE As String
        Private _ZONE_FREIGTH As String
        Private _AMOUNT_FREIGTH As Double
        Private _IS_GUIA As Integer
        Private _IS_CASH_BANK As Integer
        Private _TAX_TYPE As Integer
        Private _REC_AUTO As String
        Private _TRAMA_ID As String
        Private _VEHICULO_ID As String
        Private _EMPTRA_ID As String
        Private _ISC As Double
        Private _DOCUMENT_TYPE_COMP_PER As String
        Private _SERIE_COMP_PER As String
        Private _NUMBER_COMP_PER As String
        Private _ESTADO_DESPACHO As String
        Private _AMOUNT_DETRAC As Double
        Private _PERCENT_DETRAC As Double



        Private _FECHA_COMMENT_ALMACEN As String
        Private _FECHA_COMMENT_DIR As String
        Private _FECHA_COMMENT_GER As String

        Private _COMMENT_ALMACEN As String
        Private _HORA_COMMENT_ALMACEN As String
        Private _COMMENT_DIR As String
        Private _HORA_COMMENT_DIR As String
        Private _COMMENT_GER As String
        Private _HORA_COMMENT_GER As String





        Public Sub New()
            _STATUS = 0
            _NUMBER_SERIE = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _DOCUMENT_DATE = String.Empty
            _CADUCATE_DATE = String.Empty
            _DR_CR = String.Empty
            _SALES_REP_ID = String.Empty
            _PLACE_SALES = String.Empty
            _NUMBER_QUOTE = String.Empty
            _NUMBER_ORDER_PUR = String.Empty
            _CFDESCPG = String.Empty
            _POINT_ORIG = String.Empty
            _POINT_BOARD = String.Empty
            _POINT_ARRIVAL = String.Empty
            _RECEIVABLE_TYPE = String.Empty
            _CUSTOMER_ID = String.Empty
            _CUSTOMER_NAME = String.Empty
            _CUSTOMER_ADDR = String.Empty
            _VAT_REGISTRATION = String.Empty
            _WAREHOUSE_ID = String.Empty
            _AMOUNT = 0.0R
            _TERMS_ID = String.Empty
            _BALANCE = 0.0R
            _SELL_RATE = 0.0R
            _CURRENCY_ID = String.Empty
            _DOCUMENT_REF = String.Empty
            _SERIE_REF = String.Empty
            _NUMBER_REF = String.Empty
            _NUMBER_ORDER = String.Empty
            _CREATE_DATE = String.Empty
            _LAST_MODIFIED = String.Empty
            _STATUS = String.Empty
            _USER_ID = String.Empty
            _COMMENT = String.Empty
            _IS_GUIA_REC = String.Empty
            _NUMBER_REGISTRATION = String.Empty
            _DISCOUNT_PERCENT = 0.0R
            _DISCOUNT_PERCENT_SP = 0.0R
            _CARD_ID = String.Empty
            _NUMBER_CARD = String.Empty
            _AMOUNT_CARD_US = 0.0R
            _AMOUNT_CARD = 0.0R
            _BANK_CHECK = String.Empty
            _NUMBER_CHECK = String.Empty
            _AMOUNT_CH_US = 0.0R
            _AMOUNT_CH = 0.0R
            _VOUCHER_ID = String.Empty
            _NUMBER_TRA = String.Empty
            _AMOUNT_TAX = 0.0R
            _DISCOUNTV = 0.0R
            _DISCOUNTP = 0.0R
            _LIST_GUIA = String.Empty
            _IS_PRINT = 0
            _DISCOUNT_RECIVABLE = 0.0R
            _IS_CLOSED = 0
            _SUB_ID = String.Empty
            _TOTAL_ERROR = 0.0R
            _PROMISE_DAYS = 0
            _SHIPPER_TYPE = String.Empty
            _ZONE_FREIGTH = String.Empty
            _AMOUNT_FREIGTH = 0.0R
            _IS_GUIA = 0
            _IS_CASH_BANK = 0
            _TAX_TYPE = 0
            _REC_AUTO = String.Empty
            _TRAMA_ID = String.Empty
            _VEHICULO_ID = String.Empty
            _EMPTRA_ID = String.Empty
            _ISC = 0.0R

            _DOCUMENT_TYPE_COMP_PER = String.Empty
            _SERIE_COMP_PER = String.Empty
            _NUMBER_COMP_PER = String.Empty
            _ESTADO_DESPACHO = String.Empty
            _AMOUNT_DETRAC = 0.0
            _PERCENT_DETRAC = 0.0
        End Sub


        Public Property FECHA_COMMENT_ALMACEN As String
            Get
                Return _FECHA_COMMENT_ALMACEN
            End Get
            Set(value As String)
                _FECHA_COMMENT_ALMACEN = value
            End Set
        End Property

        Public Property FECHA_COMMENT_DIR As String
            Get
                Return _FECHA_COMMENT_DIR
            End Get
            Set(value As String)
                _FECHA_COMMENT_DIR = value
            End Set
        End Property

        Public Property FECHA_COMMENT_GER As String
            Get
                Return _FECHA_COMMENT_GER
            End Get
            Set(value As String)
                _FECHA_COMMENT_GER = value
            End Set
        End Property


        Public Property COMMENT_ALMACEN As String
            Get
                Return _COMMENT_ALMACEN
            End Get
            Set(value As String)
                _COMMENT_ALMACEN = value
            End Set
        End Property

        Public Property HORA_COMMENT_ALMACEN As String
            Get
                Return _HORA_COMMENT_ALMACEN
            End Get
            Set(value As String)
                _HORA_COMMENT_ALMACEN = value
            End Set
        End Property

        Public Property COMMENT_DIR As String
            Get
                Return _COMMENT_DIR
            End Get
            Set(value As String)
                _COMMENT_DIR = value
            End Set
        End Property

        Public Property HORA_COMMENT_DIR As String
            Get
                Return _HORA_COMMENT_DIR
            End Get
            Set(value As String)
                _HORA_COMMENT_DIR = value
            End Set
        End Property

        Public Property COMMENT_GER As String
            Get
                Return _COMMENT_GER
            End Get
            Set(value As String)
                _COMMENT_GER = value
            End Set
        End Property

        Public Property HORA_COMMENT_GER As String
            Get
                Return _HORA_COMMENT_GER
            End Get
            Set(value As String)
                _HORA_COMMENT_GER = value
            End Set
        End Property

        Private _ESTADO As String
        Private _OPCION_ESTADO As String
        Private _MOTIVO_DEVOLUCION_ID As String
        Private _TEXTO_MOTIVO_DEVOLUCION As String

        Private _DOC_DEVOLUCION As String
        Private _FIN_DEVOLUCION_ID As String
        Private _TEXTO_FIN_DEVOLUCION_ID As String


        Public Property ESTADO As String
            Get
                Return _ESTADO
            End Get
            Set(value As String)
                _ESTADO = value
            End Set
        End Property

        Public Property OPCION_ESTADO As String
            Get
                Return _OPCION_ESTADO
            End Get
            Set(value As String)
                _OPCION_ESTADO = value
            End Set
        End Property

        Public Property MOTIVO_DEVOLUCION_ID As String
            Get
                Return _MOTIVO_DEVOLUCION_ID
            End Get
            Set(value As String)
                _MOTIVO_DEVOLUCION_ID = value
            End Set
        End Property

        Public Property TEXTO_MOTIVO_DEVOLUCION As String
            Get
                Return _TEXTO_MOTIVO_DEVOLUCION
            End Get
            Set(value As String)
                _TEXTO_MOTIVO_DEVOLUCION = value
            End Set
        End Property

        Public Property DOC_DEVOLUCION As String
            Get
                Return _DOC_DEVOLUCION
            End Get
            Set(value As String)
                _DOC_DEVOLUCION = value
            End Set
        End Property

        Public Property FIN_DEVOLUCION_ID As String
            Get
                Return _FIN_DEVOLUCION_ID
            End Get
            Set(value As String)
                _FIN_DEVOLUCION_ID = value
            End Set
        End Property


        Public Property TEXTO_FIN_DEVOLUCION_ID As String
            Get
                Return _TEXTO_FIN_DEVOLUCION_ID
            End Get
            Set(value As String)
                _TEXTO_FIN_DEVOLUCION_ID = value
            End Set
        End Property

        Public Property AMOUNT_DETRAC As Double
            Get
                Return _AMOUNT_DETRAC
            End Get
            Set(value As Double)
                _AMOUNT_DETRAC = value
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

        Public Property DOCUMENT_TYPE_COMP_PER As String
            Get
                Return _DOCUMENT_TYPE_COMP_PER
            End Get
            Set(value As String)
                _DOCUMENT_TYPE_COMP_PER = value
            End Set
        End Property

        Public Property SERIE_COMP_PER As String
            Get
                Return _SERIE_COMP_PER
            End Get
            Set(value As String)
                _SERIE_COMP_PER = value
            End Set
        End Property

        Public Property NUMBER_COMP_PER As String
            Get
                Return _NUMBER_COMP_PER
            End Get
            Set(value As String)
                _NUMBER_COMP_PER = value
            End Set
        End Property


        Public Property ESTADO_DESPACHO As String
            Get
                Return _ESTADO_DESPACHO
            End Get
            Set(value As String)
                _ESTADO_DESPACHO = value
            End Set
        End Property


        Public Property DOCUMENT_ID As String
            Get
                Return _DOCUMENT_ID
            End Get
            Set(value As String)
                _DOCUMENT_ID = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
            End Set
        End Property

        Public Property DOCUMENT_DATE As String
            Get
                Return _DOCUMENT_DATE
            End Get
            Set(value As String)
                _DOCUMENT_DATE = value
            End Set
        End Property

        Public Property CADUCATE_DATE As String
            Get
                Return _CADUCATE_DATE
            End Get
            Set(value As String)
                _CADUCATE_DATE = value
            End Set
        End Property

        Public Property DR_CR As String
            Get
                Return _DR_CR
            End Get
            Set(value As String)
                _DR_CR = value
            End Set
        End Property

        Public Property SALES_REP_ID As String
            Get
                Return _SALES_REP_ID
            End Get
            Set(value As String)
                _SALES_REP_ID = value
            End Set
        End Property

        Public Property PLACE_SALES As String
            Get
                Return _PLACE_SALES
            End Get
            Set(value As String)
                _PLACE_SALES = value
            End Set
        End Property

        Public Property NUMBER_QUOTE As String
            Get
                Return _NUMBER_QUOTE
            End Get
            Set(value As String)
                _NUMBER_QUOTE = value
            End Set
        End Property

        Public Property NUMBER_ORDER_PUR As String
            Get
                Return _NUMBER_ORDER_PUR
            End Get
            Set(value As String)
                _NUMBER_ORDER_PUR = value
            End Set
        End Property

        Public Property CFDESCPG As String
            Get
                Return _CFDESCPG
            End Get
            Set(value As String)
                _CFDESCPG = value
            End Set
        End Property

        Public Property POINT_ORIG As String
            Get
                Return _POINT_ORIG
            End Get
            Set(value As String)
                _POINT_ORIG = value
            End Set
        End Property

        Public Property POINT_BOARD As String
            Get
                Return _POINT_BOARD
            End Get
            Set(value As String)
                _POINT_BOARD = value
            End Set
        End Property

        Public Property POINT_ARRIVAL As String
            Get
                Return _POINT_ARRIVAL
            End Get
            Set(value As String)
                _POINT_ARRIVAL = value
            End Set
        End Property

        Public Property RECEIVABLE_TYPE As String
            Get
                Return _RECEIVABLE_TYPE
            End Get
            Set(value As String)
                _RECEIVABLE_TYPE = value
            End Set
        End Property

        Public Property CUSTOMER_ID As String
            Get
                Return _CUSTOMER_ID
            End Get
            Set(value As String)
                _CUSTOMER_ID = value
            End Set
        End Property

        Public Property CUSTOMER_NAME As String
            Get
                Return _CUSTOMER_NAME
            End Get
            Set(value As String)
                _CUSTOMER_NAME = value
            End Set
        End Property

        Public Property CUSTOMER_ADDR As String
            Get
                Return _CUSTOMER_ADDR
            End Get
            Set(value As String)
                _CUSTOMER_ADDR = value
            End Set
        End Property

        Public Property VAT_REGISTRATION As String
            Get
                Return _VAT_REGISTRATION
            End Get
            Set(value As String)
                _VAT_REGISTRATION = value
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

        Public Property AMOUNT As Double
            Get
                Return _AMOUNT
            End Get
            Set(value As Double)
                _AMOUNT = value
            End Set
        End Property

        Public Property TERMS_ID As String
            Get
                Return _TERMS_ID
            End Get
            Set(value As String)
                _TERMS_ID = value
            End Set
        End Property

        Public Property BALANCE As Double
            Get
                Return _BALANCE
            End Get
            Set(value As Double)
                _BALANCE = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property

        Public Property DOCUMENT_REF As String
            Get
                Return _DOCUMENT_REF
            End Get
            Set(value As String)
                _DOCUMENT_REF = value
            End Set
        End Property

        Public Property SERIE_REF As String
            Get
                Return _SERIE_REF
            End Get
            Set(value As String)
                _SERIE_REF = value
            End Set
        End Property

        Public Property NUMBER_REF As String
            Get
                Return _NUMBER_REF
            End Get
            Set(value As String)
                _NUMBER_REF = value
            End Set
        End Property

        Public Property NUMBER_ORDER As String
            Get
                Return _NUMBER_ORDER
            End Get
            Set(value As String)
                _NUMBER_ORDER = value
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

        Public Property LAST_MODIFIED As String
            Get
                Return _LAST_MODIFIED
            End Get
            Set(value As String)
                _LAST_MODIFIED = value
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

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property IS_GUIA_REC As String
            Get
                Return _IS_GUIA_REC
            End Get
            Set(value As String)
                _IS_GUIA_REC = value
            End Set
        End Property

        Public Property NUMBER_REGISTRATION As String
            Get
                Return _NUMBER_REGISTRATION
            End Get
            Set(value As String)
                _NUMBER_REGISTRATION = value
            End Set
        End Property

        Public Property DISCOUNT_PERCENT As Double
            Get
                Return _DISCOUNT_PERCENT
            End Get
            Set(value As Double)
                _DISCOUNT_PERCENT = value
            End Set
        End Property

        Public Property DISCOUNT_PERCENT_SP As Double
            Get
                Return _DISCOUNT_PERCENT_SP
            End Get
            Set(value As Double)
                _DISCOUNT_PERCENT_SP = value
            End Set
        End Property

        Public Property CARD_ID As String
            Get
                Return _CARD_ID
            End Get
            Set(value As String)
                _CARD_ID = value
            End Set
        End Property

        Public Property NUMBER_CARD As String
            Get
                Return _NUMBER_CARD
            End Get
            Set(value As String)
                _NUMBER_CARD = value
            End Set
        End Property

        Public Property AMOUNT_CARD_US As Double
            Get
                Return _AMOUNT_CARD_US
            End Get
            Set(value As Double)
                _AMOUNT_CARD_US = value
            End Set
        End Property

        Public Property AMOUNT_CARD As Double
            Get
                Return _AMOUNT_CARD
            End Get
            Set(value As Double)
                _AMOUNT_CARD = value
            End Set
        End Property

        Public Property BANK_CHECK As String
            Get
                Return _BANK_CHECK
            End Get
            Set(value As String)
                _BANK_CHECK = value
            End Set
        End Property

        Public Property NUMBER_CHECK As String
            Get
                Return _NUMBER_CHECK
            End Get
            Set(value As String)
                _NUMBER_CHECK = value
            End Set
        End Property

        Public Property AMOUNT_CH_US As Double
            Get
                Return _AMOUNT_CH_US
            End Get
            Set(value As Double)
                _AMOUNT_CH_US = value
            End Set
        End Property

        Public Property AMOUNT_CH As Double
            Get
                Return _AMOUNT_CH
            End Get
            Set(value As Double)
                _AMOUNT_CH = value
            End Set
        End Property

        Public Property VOUCHER_ID As String
            Get
                Return _VOUCHER_ID
            End Get
            Set(value As String)
                _VOUCHER_ID = value
            End Set
        End Property

        Public Property NUMBER_TRA As String
            Get
                Return _NUMBER_TRA
            End Get
            Set(value As String)
                _NUMBER_TRA = value
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

        Public Property DISCOUNTV As Double
            Get
                Return _DISCOUNTV
            End Get
            Set(value As Double)
                _DISCOUNTV = value
            End Set
        End Property

        Public Property DISCOUNTP As Double
            Get
                Return _DISCOUNTP
            End Get
            Set(value As Double)
                _DISCOUNTP = value
            End Set
        End Property

        Public Property LIST_GUIA As String
            Get
                Return _LIST_GUIA
            End Get
            Set(value As String)
                _LIST_GUIA = value
            End Set
        End Property

        Public Property IS_PRINT As Integer
            Get
                Return _IS_PRINT
            End Get
            Set(value As Integer)
                _IS_PRINT = value
            End Set
        End Property

        Public Property DISCOUNT_RECIVABLE As Double
            Get
                Return _DISCOUNT_RECIVABLE
            End Get
            Set(value As Double)
                _DISCOUNT_RECIVABLE = value
            End Set
        End Property

        Public Property IS_CLOSED As Integer
            Get
                Return _IS_CLOSED
            End Get
            Set(value As Integer)
                _IS_CLOSED = value
            End Set
        End Property

        Public Property SUB_ID As String
            Get
                Return _SUB_ID
            End Get
            Set(value As String)
                _SUB_ID = value
            End Set
        End Property

        Public Property TOTAL_ERROR As Double
            Get
                Return _TOTAL_ERROR
            End Get
            Set(value As Double)
                _TOTAL_ERROR = value
            End Set
        End Property
        Public Property PROMISE_DAYS As Integer
            Get
                Return _PROMISE_DAYS
            End Get
            Set(value As Integer)
                _PROMISE_DAYS = value
            End Set
        End Property

        Public Property SHIPPER_TYPE As String
            Get
                Return _SHIPPER_TYPE
            End Get
            Set(value As String)
                _SHIPPER_TYPE = value
            End Set
        End Property

        Public Property ZONE_FREIGTH As String
            Get
                Return _ZONE_FREIGTH
            End Get
            Set(value As String)
                _ZONE_FREIGTH = value
            End Set
        End Property

        Public Property AMOUNT_FREIGTH As Double
            Get
                Return _AMOUNT_FREIGTH
            End Get
            Set(value As Double)
                _AMOUNT_FREIGTH = value
            End Set
        End Property

        Public Property IS_GUIA As Integer
            Get
                Return _IS_GUIA
            End Get
            Set(value As Integer)
                _IS_GUIA = value
            End Set
        End Property

        Public Property IS_CASH_BANK As Integer
            Get
                Return _IS_CASH_BANK
            End Get
            Set(value As Integer)
                _IS_CASH_BANK = value
            End Set
        End Property

        Public Property TAX_TYPE As Integer
            Get
                Return _TAX_TYPE
            End Get
            Set(value As Integer)
                _TAX_TYPE = value
            End Set
        End Property


        Public Property REC_AUTO As String
            Get
                Return _REC_AUTO
            End Get
            Set(value As String)
                _REC_AUTO = value
            End Set
        End Property

        Public Property TRAMA_ID As String
            Get
                Return _TRAMA_ID
            End Get
            Set(value As String)
                _TRAMA_ID = value
            End Set
        End Property

        Public Property VEHICULO_ID As String
            Get
                Return _VEHICULO_ID
            End Get
            Set(value As String)
                _VEHICULO_ID = value
            End Set
        End Property

        Public Property EMPTRA_ID As String
            Get
                Return _EMPTRA_ID
            End Get
            Set(value As String)
                _EMPTRA_ID = value
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

    End Class

    Public Class RECEIVABLE

        Private _DOCUMENT_ID As String
        Private _NUMBER_SERIE As String
        Private _NUMBER_DOCUMENT As String
        Private _DOCUMENT_DATE As String
        Private _CADUCATE_DATE As String
        Private _DR_CR As String
        Private _SALES_REP_ID As String
        Private _PLACE_SALES As String
        Private _NUMBER_QUOTE As String
        Private _NUMBER_ORDER_PUR As String
        Private _CFDESCPG As String
        Private _POINT_ORIG As String
        Private _POINT_BOARD As String
        Private _POINT_ARRIVAL As String
        Private _RECEIVABLE_TYPE As String
        Private _CUSTOMER_ID As String
        Private _CUSTOMER_NAME As String
        Private _CUSTOMER_ADDR As String
        Private _VAT_REGISTRATION As String
        Private _WAREHOUSE_ID As String
        Private _AMOUNT As Double
        Private _TERMS_ID As String
        Private _BALANCE As Double
        Private _SELL_RATE As Double
        Private _CURRENCY_ID As String
        Private _DOCUMENT_REF As String
        Private _SERIE_REF As String
        Private _NUMBER_REF As String
        Private _NUMBER_ORDER As String
        Private _CREATE_DATE As String
        Private _LAST_MODIFIED As String
        Private _STATUS As String
        Private _USER_ID As String
        Private _COMMENT As String
        Private _IS_GUIA_REC As String
        Private _NUMBER_REGISTRATION As String
        Private _DISCOUNT_PERCENT As Double
        Private _DISCOUNT_PERCENT_SP As Double
        Private _CARD_ID As String
        Private _NUMBER_CARD As String
        Private _AMOUNT_CARD_US As Double
        Private _AMOUNT_CARD As Double
        Private _BANK_CHECK As String
        Private _NUMBER_CHECK As String
        Private _AMOUNT_CH_US As Double
        Private _AMOUNT_CH As Double
        Private _VOUCHER_ID As String
        Private _NUMBER_TRA As String
        Private _AMOUNT_TAX As Double
        Private _DISCOUNTV As Double
        Private _DISCOUNTP As Double
        Private _LIST_GUIA As String
        Private _IS_PRINT As Integer
        Private _DISCOUNT_RECIVABLE As Double
        Private _IS_CLOSED As Integer
        Private _SUB_ID As String
        Private _TOTAL_ERROR As Double
        Private _PROMISE_DAYS As Integer
        Private _SHIPPER_TYPE As String
        Private _ZONE_FREIGTH As String
        Private _AMOUNT_FREIGTH As Double
        Private _IS_GUIA As Integer
        Private _IS_CASH_BANK As Integer
        Private _TAX_TYPE As Integer
        Private _REC_AUTO As String
        Private _TRAMA_ID As String
        Private _VEHICULO_ID As String
        Private _EMPTRA_ID As String
        Private _ISC As Double

        Private _DOCUMENT_TYPE_COMP_PER As String
        Private _SERIE_COMP_PER As String
        Private _NUMBER_COMP_PER As String
        Private _ESTADO_DESPACHO As String

        Private _AMOUNT_DETRAC As Double
        Private _PERCENT_DETRAC As Double

        Private _MOV_OPTION_ID As String


        Public Sub New()
            _STATUS = 0
            _NUMBER_SERIE = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _DOCUMENT_DATE = String.Empty
            _CADUCATE_DATE = String.Empty
            _DR_CR = String.Empty
            _SALES_REP_ID = String.Empty
            _PLACE_SALES = String.Empty
            _NUMBER_QUOTE = String.Empty
            _NUMBER_ORDER_PUR = String.Empty
            _CFDESCPG = String.Empty
            _POINT_ORIG = String.Empty
            _POINT_BOARD = String.Empty
            _POINT_ARRIVAL = String.Empty
            _RECEIVABLE_TYPE = String.Empty
            _CUSTOMER_ID = String.Empty
            _CUSTOMER_NAME = String.Empty
            _CUSTOMER_ADDR = String.Empty
            _VAT_REGISTRATION = String.Empty
            _WAREHOUSE_ID = String.Empty
            _AMOUNT = 0.0R
            _TERMS_ID = String.Empty
            _BALANCE = 0.0R
            _SELL_RATE = 0.0R
            _CURRENCY_ID = String.Empty
            _DOCUMENT_REF = String.Empty
            _SERIE_REF = String.Empty
            _NUMBER_REF = String.Empty
            _NUMBER_ORDER = String.Empty
            _CREATE_DATE = String.Empty
            _LAST_MODIFIED = String.Empty
            _STATUS = String.Empty
            _USER_ID = String.Empty
            _COMMENT = String.Empty
            _IS_GUIA_REC = String.Empty
            _NUMBER_REGISTRATION = String.Empty
            _DISCOUNT_PERCENT = 0.0R
            _DISCOUNT_PERCENT_SP = 0.0R
            _CARD_ID = String.Empty
            _NUMBER_CARD = String.Empty
            _AMOUNT_CARD_US = 0.0R
            _AMOUNT_CARD = 0.0R
            _BANK_CHECK = String.Empty
            _NUMBER_CHECK = String.Empty
            _AMOUNT_CH_US = 0.0R
            _AMOUNT_CH = 0.0R
            _VOUCHER_ID = String.Empty
            _NUMBER_TRA = String.Empty
            _AMOUNT_TAX = 0.0R
            _DISCOUNTV = 0.0R
            _DISCOUNTP = 0.0R
            _LIST_GUIA = String.Empty
            _IS_PRINT = 0
            _DISCOUNT_RECIVABLE = 0.0R
            _IS_CLOSED = 0
            _SUB_ID = String.Empty
            _TOTAL_ERROR = 0.0R
            _PROMISE_DAYS = 0
            _SHIPPER_TYPE = String.Empty
            _ZONE_FREIGTH = String.Empty
            _AMOUNT_FREIGTH = 0.0R
            _IS_GUIA = 0
            _IS_CASH_BANK = 0
            _TAX_TYPE = 0
            _REC_AUTO = String.Empty
            _TRAMA_ID = String.Empty
            _VEHICULO_ID = String.Empty
            _EMPTRA_ID = String.Empty
            _ISC = 0.0R

            _DOCUMENT_TYPE_COMP_PER = String.Empty
            _SERIE_COMP_PER = String.Empty
            _NUMBER_COMP_PER = String.Empty
            _ESTADO_DESPACHO = String.Empty
            _AMOUNT_DETRAC = 0.0
            _PERCENT_DETRAC = 0.0
            _MOV_OPTION_ID = ""
        End Sub

        Public Property MOV_OPTION_ID As String
            Get
                Return _MOV_OPTION_ID
            End Get
            Set(value As String)
                _MOV_OPTION_ID = value
            End Set
        End Property

        Public Property AMOUNT_DETRAC As Double
            Get
                Return _AMOUNT_DETRAC
            End Get
            Set(value As Double)
                _AMOUNT_DETRAC = value
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

        Public Property DOCUMENT_TYPE_COMP_PER As String
            Get
                Return _DOCUMENT_TYPE_COMP_PER
            End Get
            Set(value As String)
                _DOCUMENT_TYPE_COMP_PER = value
            End Set
        End Property

        Public Property SERIE_COMP_PER As String
            Get
                Return _SERIE_COMP_PER
            End Get
            Set(value As String)
                _SERIE_COMP_PER = value
            End Set
        End Property

        Public Property NUMBER_COMP_PER As String
            Get
                Return _NUMBER_COMP_PER
            End Get
            Set(value As String)
                _NUMBER_COMP_PER = value
            End Set
        End Property


        Public Property ESTADO_DESPACHO As String
            Get
                Return _ESTADO_DESPACHO
            End Get
            Set(value As String)
                _ESTADO_DESPACHO = value
            End Set
        End Property


        Public Property DOCUMENT_ID As String
            Get
                Return _DOCUMENT_ID
            End Get
            Set(value As String)
                _DOCUMENT_ID = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
            End Set
        End Property

        Public Property DOCUMENT_DATE As String
            Get
                Return _DOCUMENT_DATE
            End Get
            Set(value As String)
                _DOCUMENT_DATE = value
            End Set
        End Property

        Public Property CADUCATE_DATE As String
            Get
                Return _CADUCATE_DATE
            End Get
            Set(value As String)
                _CADUCATE_DATE = value
            End Set
        End Property

        Public Property DR_CR As String
            Get
                Return _DR_CR
            End Get
            Set(value As String)
                _DR_CR = value
            End Set
        End Property

        Public Property SALES_REP_ID As String
            Get
                Return _SALES_REP_ID
            End Get
            Set(value As String)
                _SALES_REP_ID = value
            End Set
        End Property

        Public Property PLACE_SALES As String
            Get
                Return _PLACE_SALES
            End Get
            Set(value As String)
                _PLACE_SALES = value
            End Set
        End Property

        Public Property NUMBER_QUOTE As String
            Get
                Return _NUMBER_QUOTE
            End Get
            Set(value As String)
                _NUMBER_QUOTE = value
            End Set
        End Property

        Public Property NUMBER_ORDER_PUR As String
            Get
                Return _NUMBER_ORDER_PUR
            End Get
            Set(value As String)
                _NUMBER_ORDER_PUR = value
            End Set
        End Property

        Public Property CFDESCPG As String
            Get
                Return _CFDESCPG
            End Get
            Set(value As String)
                _CFDESCPG = value
            End Set
        End Property

        Public Property POINT_ORIG As String
            Get
                Return _POINT_ORIG
            End Get
            Set(value As String)
                _POINT_ORIG = value
            End Set
        End Property

        Public Property POINT_BOARD As String
            Get
                Return _POINT_BOARD
            End Get
            Set(value As String)
                _POINT_BOARD = value
            End Set
        End Property

        Public Property POINT_ARRIVAL As String
            Get
                Return _POINT_ARRIVAL
            End Get
            Set(value As String)
                _POINT_ARRIVAL = value
            End Set
        End Property

        Public Property RECEIVABLE_TYPE As String
            Get
                Return _RECEIVABLE_TYPE
            End Get
            Set(value As String)
                _RECEIVABLE_TYPE = value
            End Set
        End Property

        Public Property CUSTOMER_ID As String
            Get
                Return _CUSTOMER_ID
            End Get
            Set(value As String)
                _CUSTOMER_ID = value
            End Set
        End Property

        Public Property CUSTOMER_NAME As String
            Get
                Return _CUSTOMER_NAME
            End Get
            Set(value As String)
                _CUSTOMER_NAME = value
            End Set
        End Property

        Public Property CUSTOMER_ADDR As String
            Get
                Return _CUSTOMER_ADDR
            End Get
            Set(value As String)
                _CUSTOMER_ADDR = value
            End Set
        End Property

        Public Property VAT_REGISTRATION As String
            Get
                Return _VAT_REGISTRATION
            End Get
            Set(value As String)
                _VAT_REGISTRATION = value
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

        Public Property AMOUNT As Double
            Get
                Return _AMOUNT
            End Get
            Set(value As Double)
                _AMOUNT = value
            End Set
        End Property

        Public Property TERMS_ID As String
            Get
                Return _TERMS_ID
            End Get
            Set(value As String)
                _TERMS_ID = value
            End Set
        End Property

        Public Property BALANCE As Double
            Get
                Return _BALANCE
            End Get
            Set(value As Double)
                _BALANCE = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property

        Public Property DOCUMENT_REF As String
            Get
                Return _DOCUMENT_REF
            End Get
            Set(value As String)
                _DOCUMENT_REF = value
            End Set
        End Property

        Public Property SERIE_REF As String
            Get
                Return _SERIE_REF
            End Get
            Set(value As String)
                _SERIE_REF = value
            End Set
        End Property

        Public Property NUMBER_REF As String
            Get
                Return _NUMBER_REF
            End Get
            Set(value As String)
                _NUMBER_REF = value
            End Set
        End Property

        Public Property NUMBER_ORDER As String
            Get
                Return _NUMBER_ORDER
            End Get
            Set(value As String)
                _NUMBER_ORDER = value
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

        Public Property LAST_MODIFIED As String
            Get
                Return _LAST_MODIFIED
            End Get
            Set(value As String)
                _LAST_MODIFIED = value
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

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property IS_GUIA_REC As String
            Get
                Return _IS_GUIA_REC
            End Get
            Set(value As String)
                _IS_GUIA_REC = value
            End Set
        End Property

        Public Property NUMBER_REGISTRATION As String
            Get
                Return _NUMBER_REGISTRATION
            End Get
            Set(value As String)
                _NUMBER_REGISTRATION = value
            End Set
        End Property

        Public Property DISCOUNT_PERCENT As Double
            Get
                Return _DISCOUNT_PERCENT
            End Get
            Set(value As Double)
                _DISCOUNT_PERCENT = value
            End Set
        End Property

        Public Property DISCOUNT_PERCENT_SP As Double
            Get
                Return _DISCOUNT_PERCENT_SP
            End Get
            Set(value As Double)
                _DISCOUNT_PERCENT_SP = value
            End Set
        End Property

        Public Property CARD_ID As String
            Get
                Return _CARD_ID
            End Get
            Set(value As String)
                _CARD_ID = value
            End Set
        End Property

        Public Property NUMBER_CARD As String
            Get
                Return _NUMBER_CARD
            End Get
            Set(value As String)
                _NUMBER_CARD = value
            End Set
        End Property

        Public Property AMOUNT_CARD_US As Double
            Get
                Return _AMOUNT_CARD_US
            End Get
            Set(value As Double)
                _AMOUNT_CARD_US = value
            End Set
        End Property

        Public Property AMOUNT_CARD As Double
            Get
                Return _AMOUNT_CARD
            End Get
            Set(value As Double)
                _AMOUNT_CARD = value
            End Set
        End Property

        Public Property BANK_CHECK As String
            Get
                Return _BANK_CHECK
            End Get
            Set(value As String)
                _BANK_CHECK = value
            End Set
        End Property

        Public Property NUMBER_CHECK As String
            Get
                Return _NUMBER_CHECK
            End Get
            Set(value As String)
                _NUMBER_CHECK = value
            End Set
        End Property

        Public Property AMOUNT_CH_US As Double
            Get
                Return _AMOUNT_CH_US
            End Get
            Set(value As Double)
                _AMOUNT_CH_US = value
            End Set
        End Property

        Public Property AMOUNT_CH As Double
            Get
                Return _AMOUNT_CH
            End Get
            Set(value As Double)
                _AMOUNT_CH = value
            End Set
        End Property

        Public Property VOUCHER_ID As String
            Get
                Return _VOUCHER_ID
            End Get
            Set(value As String)
                _VOUCHER_ID = value
            End Set
        End Property

        Public Property NUMBER_TRA As String
            Get
                Return _NUMBER_TRA
            End Get
            Set(value As String)
                _NUMBER_TRA = value
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

        Public Property DISCOUNTV As Double
            Get
                Return _DISCOUNTV
            End Get
            Set(value As Double)
                _DISCOUNTV = value
            End Set
        End Property

        Public Property DISCOUNTP As Double
            Get
                Return _DISCOUNTP
            End Get
            Set(value As Double)
                _DISCOUNTP = value
            End Set
        End Property

        Public Property LIST_GUIA As String
            Get
                Return _LIST_GUIA
            End Get
            Set(value As String)
                _LIST_GUIA = value
            End Set
        End Property

        Public Property IS_PRINT As Integer
            Get
                Return _IS_PRINT
            End Get
            Set(value As Integer)
                _IS_PRINT = value
            End Set
        End Property

        Public Property DISCOUNT_RECIVABLE As Double
            Get
                Return _DISCOUNT_RECIVABLE
            End Get
            Set(value As Double)
                _DISCOUNT_RECIVABLE = value
            End Set
        End Property

        Public Property IS_CLOSED As Integer
            Get
                Return _IS_CLOSED
            End Get
            Set(value As Integer)
                _IS_CLOSED = value
            End Set
        End Property

        Public Property SUB_ID As String
            Get
                Return _SUB_ID
            End Get
            Set(value As String)
                _SUB_ID = value
            End Set
        End Property

        Public Property TOTAL_ERROR As Double
            Get
                Return _TOTAL_ERROR
            End Get
            Set(value As Double)
                _TOTAL_ERROR = value
            End Set
        End Property
        Public Property PROMISE_DAYS As Integer
            Get
                Return _PROMISE_DAYS
            End Get
            Set(value As Integer)
                _PROMISE_DAYS = value
            End Set
        End Property

        Public Property SHIPPER_TYPE As String
            Get
                Return _SHIPPER_TYPE
            End Get
            Set(value As String)
                _SHIPPER_TYPE = value
            End Set
        End Property

        Public Property ZONE_FREIGTH As String
            Get
                Return _ZONE_FREIGTH
            End Get
            Set(value As String)
                _ZONE_FREIGTH = value
            End Set
        End Property

        Public Property AMOUNT_FREIGTH As Double
            Get
                Return _AMOUNT_FREIGTH
            End Get
            Set(value As Double)
                _AMOUNT_FREIGTH = value
            End Set
        End Property

        Public Property IS_GUIA As Integer
            Get
                Return _IS_GUIA
            End Get
            Set(value As Integer)
                _IS_GUIA = value
            End Set
        End Property

        Public Property IS_CASH_BANK As Integer
            Get
                Return _IS_CASH_BANK
            End Get
            Set(value As Integer)
                _IS_CASH_BANK = value
            End Set
        End Property

        Public Property TAX_TYPE As Integer
            Get
                Return _TAX_TYPE
            End Get
            Set(value As Integer)
                _TAX_TYPE = value
            End Set
        End Property


        Public Property REC_AUTO As String
            Get
                Return _REC_AUTO
            End Get
            Set(value As String)
                _REC_AUTO = value
            End Set
        End Property

        Public Property TRAMA_ID As String
            Get
                Return _TRAMA_ID
            End Get
            Set(value As String)
                _TRAMA_ID = value
            End Set
        End Property

        Public Property VEHICULO_ID As String
            Get
                Return _VEHICULO_ID
            End Get
            Set(value As String)
                _VEHICULO_ID = value
            End Set
        End Property

        Public Property EMPTRA_ID As String
            Get
                Return _EMPTRA_ID
            End Get
            Set(value As String)
                _EMPTRA_ID = value
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

    End Class

    Public Class TYPE_RECEIVE
        Private _TYPE As String
        Private _RECEIVE_ID As String
        Private _DESCRIPTION As String
        Private _CURRENCY_ID As String
        Private _ACCOUNT As String
        Private _VENDOR_ID As Integer
        Private _BANK_ID As Integer
        Private _USER_ID As String
        Private _DATE As String
        Private _EFFECTIVE_DATE As String
        Private _IS_CHECK_DIF As Integer
        Private _IS_APPL As Integer
        Private _TRANS_TYPE As Integer
        Private _IS_CREDIT_CARD As Integer

        Public Sub New()
            _TYPE = String.Empty
            _RECEIVE_ID = String.Empty
            _DESCRIPTION = String.Empty
            _CURRENCY_ID = String.Empty
            _ACCOUNT = String.Empty
            _VENDOR_ID = 0
            _BANK_ID = 0
            _USER_ID = String.Empty
            _DATE = String.Empty
            _EFFECTIVE_DATE = String.Empty
            _IS_CHECK_DIF = 0
            _IS_APPL = 0
            _TRANS_TYPE = 0
            _IS_CREDIT_CARD = 0
        End Sub


        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property RECEIVE_ID As String
            Get
                Return _RECEIVE_ID
            End Get
            Set(value As String)
                _RECEIVE_ID = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property

        Public Property ACCOUNT As String
            Get
                Return _ACCOUNT
            End Get
            Set(value As String)
                _ACCOUNT = value
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

        Public Property BANK_ID As Integer
            Get
                Return _BANK_ID
            End Get
            Set(value As Integer)
                _BANK_ID = value
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

        Public Property DATEE As String
            Get
                Return _DATE
            End Get
            Set(value As String)
                _DATE = value
            End Set
        End Property

        Public Property EFFECTIVE_DATE As String
            Get
                Return _EFFECTIVE_DATE
            End Get
            Set(value As String)
                _EFFECTIVE_DATE = value
            End Set
        End Property

        Public Property IS_CHECK_DIF As Integer
            Get
                Return _IS_CHECK_DIF
            End Get
            Set(value As Integer)
                _IS_CHECK_DIF = value
            End Set
        End Property

        Public Property IS_APPL As Integer
            Get
                Return _IS_APPL
            End Get
            Set(value As Integer)
                _IS_APPL = value
            End Set
        End Property

        Public Property TRANS_TYPE As Integer
            Get
                Return _TRANS_TYPE
            End Get
            Set(value As Integer)
                _TRANS_TYPE = value
            End Set
        End Property

        Public Property IS_CREDIT_CARD As Integer
            Get
                Return _IS_CREDIT_CARD
            End Get
            Set(value As Integer)
                _IS_CREDIT_CARD = value
            End Set
        End Property

    End Class

    Public Class STATUS_LETTER
        Private _STATUS_ID As String
        Private _CURRENCY_ID As String
        Private _DESCRIPTION As String
        Private _ACCOUNT As String
        Private _EVENTO As String
        Private _IS_GENERA_ASIENTO As String

        Public Sub New()
            _STATUS_ID = String.Empty
            _CURRENCY_ID = String.Empty
            _DESCRIPTION = String.Empty
            _ACCOUNT = String.Empty
            _EVENTO = String.Empty
            _IS_GENERA_ASIENTO = String.Empty
        End Sub

        Public Property STATUS_ID As String
            Get
                Return _STATUS_ID
            End Get
            Set(value As String)
                _STATUS_ID = value
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
        Public Property DESCRIPTION As String
            Get
                Return _DESCRIPTION
            End Get
            Set(value As String)
                _DESCRIPTION = value
            End Set
        End Property
        Public Property ACCOUNT As String
            Get
                Return _ACCOUNT
            End Get
            Set(value As String)
                _ACCOUNT = value
            End Set
        End Property
        Public Property EVENTO As String
            Get
                Return _EVENTO
            End Get
            Set(value As String)
                _EVENTO = value
            End Set
        End Property
        Public Property IS_GENERA_ASIENTO As String
            Get
                Return _IS_GENERA_ASIENTO
            End Get
            Set(value As String)
                _IS_GENERA_ASIENTO = value
            End Set
        End Property

    End Class

    Public Class TYPE_RECEIVE_PAY
        Private _TYPE As String
        Private _RECEIVE_ID As String
        Private _DESCRIPTION As String
        Private _CURRENCY_ID As String
        Private _ACCOUNT As String
        Private _VENDOR_ID As Integer
        Private _BANK_ID As Integer
        Private _USER_ID As String
        Private _DATE As String
        Private _EFFECTIVE_DATE As String
        Private _IS_CHECK_DIF As Integer
        Private _IS_APPL As Integer
        Private _TRANS_TYPE As Integer
        Private _IS_CREDIT_CARD As Integer

        Public Sub New()
            _TYPE = String.Empty
            _RECEIVE_ID = String.Empty
            _DESCRIPTION = String.Empty
            _CURRENCY_ID = String.Empty
            _ACCOUNT = String.Empty
            _VENDOR_ID = 0
            _BANK_ID = 0
            _USER_ID = String.Empty
            _DATE = String.Empty
            _EFFECTIVE_DATE = String.Empty
            _IS_CHECK_DIF = 0
            _IS_APPL = 0
            _TRANS_TYPE = 0
            _IS_CREDIT_CARD = 0
        End Sub


        Public Property TYPE As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Public Property RECEIVE_ID As String
            Get
                Return _RECEIVE_ID
            End Get
            Set(value As String)
                _RECEIVE_ID = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property

        Public Property ACCOUNT As String
            Get
                Return _ACCOUNT
            End Get
            Set(value As String)
                _ACCOUNT = value
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

        Public Property BANK_ID As Integer
            Get
                Return _BANK_ID
            End Get
            Set(value As Integer)
                _BANK_ID = value
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

        Public Property DATEE As String
            Get
                Return _DATE
            End Get
            Set(value As String)
                _DATE = value
            End Set
        End Property

        Public Property EFFECTIVE_DATE As String
            Get
                Return _EFFECTIVE_DATE
            End Get
            Set(value As String)
                _EFFECTIVE_DATE = value
            End Set
        End Property

        Public Property IS_CHECK_DIF As Integer
            Get
                Return _IS_CHECK_DIF
            End Get
            Set(value As Integer)
                _IS_CHECK_DIF = value
            End Set
        End Property

        Public Property IS_APPL As Integer
            Get
                Return _IS_APPL
            End Get
            Set(value As Integer)
                _IS_APPL = value
            End Set
        End Property

        Public Property TRANS_TYPE As Integer
            Get
                Return _TRANS_TYPE
            End Get
            Set(value As Integer)
                _TRANS_TYPE = value
            End Set
        End Property

        Public Property IS_CREDIT_CARD As Integer
            Get
                Return _IS_CREDIT_CARD
            End Get
            Set(value As Integer)
                _IS_CREDIT_CARD = value
            End Set
        End Property

    End Class

    Public Class SALES_REP
        Private _ID As String
        Private _NAME As String
        Private _ADDR As String
        Private _PHONE As String
        Private _EMAIL As String
        Private _VAT_REGISTRATION As String
        Private _DATE_ADMISSION As String
        Private _STATUS As String
        Private _USER As String
        Private _CREATE_DATE As Date
        Private _COD_CLI As String

        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
            _ADDR = String.Empty
            _PHONE = String.Empty
            _EMAIL = String.Empty
            _VAT_REGISTRATION = String.Empty
            _DATE_ADMISSION = String.Empty
        End Sub




        Public Property COD_CLI As String
            Get
                Return _COD_CLI
            End Get
            Set(value As String)
                _COD_CLI = value
            End Set
        End Property

        Public Property USER As String
            Get
                Return _USER
            End Get
            Set(value As String)
                _USER = value
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



        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
            End Set
        End Property

        Public Property DATE_ADMISSION As String
            Get
                Return _DATE_ADMISSION
            End Get
            Set(value As String)
                _DATE_ADMISSION = value
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

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property ADDR As String
            Get
                Return _ADDR
            End Get
            Set(value As String)
                _ADDR = value
            End Set
        End Property

        Public Property PHONE As String
            Get
                Return _PHONE
            End Get
            Set(value As String)
                _PHONE = value
            End Set
        End Property

        Public Property EMAIL As String
            Get
                Return _EMAIL
            End Get
            Set(value As String)
                _EMAIL = value
            End Set
        End Property

        Public Property VAT_REGISTRATION As String
            Get
                Return _VAT_REGISTRATION
            End Get
            Set(value As String)
                _VAT_REGISTRATION = value
            End Set
        End Property

    End Class

    Public Class TERMS
        Private _ID As String
        Private _NAME As String
        Private _NET_DAYS As Integer

        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
            _NET_DAYS = 0
        End Sub

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property NET_DAYS As Integer
            Get
                Return _NET_DAYS
            End Get
            Set(value As Integer)
                _NET_DAYS = value
            End Set
        End Property

    End Class

    Public Class TERMS_PAY
        Private _ID As String
        Private _NAME As String
        Private _NET_DAYS As Integer

        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
            _NET_DAYS = 0
        End Sub

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property NET_DAYS As Integer
            Get
                Return _NET_DAYS
            End Get
            Set(value As Integer)
                _NET_DAYS = value
            End Set
        End Property

    End Class


    Public Class CUSTOMER
        Private _ID As String
        Private _NAME As String
        Private _ADDR As String
        Private _PHONE As String
        Private _VAT_REGISTRATION As String
        Private _NUMBER_DOC As String
        Private _DISCOUNT_PERCENT As Double
        Private _TERMS_TYPE As String
        Private _STATUS As String
        Private _OPEN_DATE As String
        Private _CONTACT As String
        Private _STATE_ID As String
        Private _CREATE_USER As String
        Private _CREATE_DATE As String
        Private _MODIFY_DATE As String
        Private _TYPE_PRICE As String
        Private _SALES_ID As String
        Private _SELL_ZONE As String
        Private _COUNTRY As String
        Private _DEPARTMENT As String
        Private _PROVINCE As String
        Private _ADDR_DLV As String
        Private _CURRENCY_CREDIT_LIMIT As String
        Private _CREDIT_LIMIT_US As Double
        Private _CREDIT_LIMIT As Double
        Private _BALANCE As Double
        Private _BALANCE_US As Double
        Private _OBSERV As String
        Private _TOTAL_LETTER As Double
        Private _TOTAL_RECEIVABLE As Double
        Private _TOTAL_CHECK As Double
        Private _TOTAL_LETTER_PROTESTED As Double
        Private _CUSTOMER_TYPE As String
        Private _BUSINESS_TYPE As String
        Private _TERRITORY As String
        Private _ROUTE As String
        Private _SEGMENT As String
        Private _SEGMENT_LOCATION As String
        Private _BANK_ID As String
        Private _ACCOUNT_NO As String
        Private _DATE_REVIEW As String
        Private _HOUR_VISIT As String
        Private _ATTENTION_TYPE As String
        Private _FAX_NUMBER As String
        Private _EMAIL As String
        Private _WEBSITE As String
        Private _COMMENT As String
        Private _IS_PRIMARY As String
        Private _RETENTION As String
        Private _DOCUMENT_TYPE_PERSON_ID As String
        Private _TYPE_COMPANY As String
        Private _ACCOUNT_LOCAL As String
        Private _ACCOUNT_EXTERNAL As String
        Private _HasRows As Boolean
        Private _TYPE_DISCOUNT As String
        Private _NAME_COMERTIAL As String
        Private _FLAG_PRINCIPAL As String

        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
            _ADDR = String.Empty
            _PHONE = String.Empty
            _VAT_REGISTRATION = String.Empty
            _NUMBER_DOC = String.Empty
            _DISCOUNT_PERCENT = 0
            _TERMS_TYPE = String.Empty
            _STATUS = String.Empty
            _OPEN_DATE = String.Empty
            _CONTACT = String.Empty
            _STATE_ID = String.Empty
            _CREATE_USER = String.Empty
            _CREATE_DATE = String.Empty
            _MODIFY_DATE = String.Empty
            _TYPE_PRICE = String.Empty
            _SALES_ID = String.Empty
            _SELL_ZONE = String.Empty
            _COUNTRY = String.Empty
            _DEPARTMENT = String.Empty
            _PROVINCE = String.Empty
            _ADDR_DLV = String.Empty
            _CURRENCY_CREDIT_LIMIT = String.Empty
            _CREDIT_LIMIT_US = 0
            _CREDIT_LIMIT = 0
            _BALANCE = 0
            _BALANCE_US = 0
            _OBSERV = String.Empty
            _TOTAL_LETTER = 0
            _TOTAL_RECEIVABLE = 0
            _TOTAL_CHECK = 0
            _TOTAL_LETTER_PROTESTED = 0
            _CUSTOMER_TYPE = String.Empty
            _BUSINESS_TYPE = String.Empty
            _TERRITORY = String.Empty
            _ROUTE = String.Empty
            _SEGMENT = String.Empty
            _SEGMENT_LOCATION = String.Empty
            _BANK_ID = String.Empty
            _ACCOUNT_NO = String.Empty
            _DATE_REVIEW = String.Empty
            _HOUR_VISIT = String.Empty
            _ATTENTION_TYPE = String.Empty
            _FAX_NUMBER = String.Empty
            _EMAIL = String.Empty
            _WEBSITE = String.Empty
            _COMMENT = String.Empty
            _IS_PRIMARY = String.Empty
            _RETENTION = String.Empty
            _DOCUMENT_TYPE_PERSON_ID = String.Empty
            _TYPE_COMPANY = String.Empty
            _ACCOUNT_LOCAL = String.Empty
            _ACCOUNT_EXTERNAL = String.Empty
            _HasRows = False
            _TYPE_DISCOUNT = String.Empty
            _NAME_COMERTIAL = String.Empty
        End Sub



        Public Property FLAG_PRINCIPAL As String
            Get
                Return _FLAG_PRINCIPAL
            End Get
            Set(value As String)
                _FLAG_PRINCIPAL = value
            End Set
        End Property


        Public Property NAME_COMERTIAL As String
            Get
                Return _NAME_COMERTIAL
            End Get
            Set(value As String)
                _NAME_COMERTIAL = value
            End Set
        End Property


        Public Property TYPE_DISCOUNT As String
            Get
                Return _TYPE_DISCOUNT
            End Get
            Set(value As String)
                _TYPE_DISCOUNT = value
            End Set
        End Property

        Public Property HasRows As Boolean
            Get
                Return _HasRows
            End Get
            Set(value As Boolean)
                _HasRows = value
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

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property ADDR As String
            Get
                Return _ADDR
            End Get
            Set(value As String)
                _ADDR = value
            End Set
        End Property

        Public Property PHONE As String
            Get
                Return _PHONE
            End Get
            Set(value As String)
                _PHONE = value
            End Set
        End Property

        Public Property VAT_REGISTRATION As String
            Get
                Return _VAT_REGISTRATION
            End Get
            Set(value As String)
                _VAT_REGISTRATION = value
            End Set
        End Property

        Public Property NUMBER_DOC As String
            Get
                Return _NUMBER_DOC
            End Get
            Set(value As String)
                _NUMBER_DOC = value
            End Set
        End Property

        Public Property DISCOUNT_PERCENT As Double
            Get
                Return _DISCOUNT_PERCENT
            End Get
            Set(value As Double)
                _DISCOUNT_PERCENT = value
            End Set
        End Property

        Public Property TERMS_TYPE As String
            Get
                Return _TERMS_TYPE
            End Get
            Set(value As String)
                _TERMS_TYPE = value
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

        Public Property OPEN_DATE As String
            Get
                Return _OPEN_DATE
            End Get
            Set(value As String)
                _OPEN_DATE = value
            End Set
        End Property

        Public Property CONTACT As String
            Get
                Return _CONTACT
            End Get
            Set(value As String)
                _CONTACT = value
            End Set
        End Property

        Public Property STATE_ID As String
            Get
                Return _STATE_ID
            End Get
            Set(value As String)
                _STATE_ID = value
            End Set
        End Property

        Public Property CREATE_USER As String
            Get
                Return _CREATE_USER
            End Get
            Set(value As String)
                _CREATE_USER = value
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

        Public Property MODIFY_DATE As String
            Get
                Return _MODIFY_DATE
            End Get
            Set(value As String)
                _MODIFY_DATE = value
            End Set
        End Property

        Public Property TYPE_PRICE As String
            Get
                Return _TYPE_PRICE
            End Get
            Set(value As String)
                _TYPE_PRICE = value
            End Set
        End Property

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
            End Set
        End Property

        Public Property SELL_ZONE As String
            Get
                Return _SELL_ZONE
            End Get
            Set(value As String)
                _SELL_ZONE = value
            End Set
        End Property

        Public Property COUNTRY As String
            Get
                Return _COUNTRY
            End Get
            Set(value As String)
                _COUNTRY = value
            End Set
        End Property

        Public Property DEPARTMENT As String
            Get
                Return _DEPARTMENT
            End Get
            Set(value As String)
                _DEPARTMENT = value
            End Set
        End Property

        Public Property PROVINCE As String
            Get
                Return _PROVINCE
            End Get
            Set(value As String)
                _PROVINCE = value
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

        Public Property CURRENCY_CREDIT_LIMIT As String
            Get
                Return _CURRENCY_CREDIT_LIMIT
            End Get
            Set(value As String)
                _CURRENCY_CREDIT_LIMIT = value
            End Set
        End Property

        Public Property CREDIT_LIMIT_US As Double
            Get
                Return _CREDIT_LIMIT_US
            End Get
            Set(value As Double)
                _CREDIT_LIMIT_US = value
            End Set
        End Property

        Public Property CREDIT_LIMIT As Double
            Get
                Return _CREDIT_LIMIT
            End Get
            Set(value As Double)
                _CREDIT_LIMIT = value
            End Set
        End Property

        Public Property BALANCE As Double
            Get
                Return _BALANCE
            End Get
            Set(value As Double)
                _BALANCE = value
            End Set
        End Property

        Public Property BALANCE_US As Double
            Get
                Return _BALANCE_US
            End Get
            Set(value As Double)
                _BALANCE_US = value
            End Set
        End Property

        Public Property OBSERV As String
            Get
                Return _OBSERV
            End Get
            Set(value As String)
                _OBSERV = value
            End Set
        End Property

        Public Property TOTAL_LETTER As String
            Get
                Return _TOTAL_LETTER
            End Get
            Set(value As String)
                _TOTAL_LETTER = value
            End Set
        End Property

        Public Property TOTAL_RECEIVABLE As Double
            Get
                Return _TOTAL_RECEIVABLE
            End Get
            Set(value As Double)
                _TOTAL_RECEIVABLE = value
            End Set
        End Property

        Public Property TOTAL_CHECK As Double
            Get
                Return _TOTAL_CHECK
            End Get
            Set(value As Double)
                _TOTAL_CHECK = value
            End Set
        End Property

        Public Property TOTAL_LETTER_PROTESTED As Double
            Get
                Return _TOTAL_LETTER_PROTESTED
            End Get
            Set(value As Double)
                _TOTAL_LETTER_PROTESTED = value
            End Set
        End Property

        Public Property CUSTOMER_TYPE As String
            Get
                Return _CUSTOMER_TYPE
            End Get
            Set(value As String)
                _CUSTOMER_TYPE = value
            End Set
        End Property

        Public Property BUSINESS_TYPE As String
            Get
                Return _BUSINESS_TYPE
            End Get
            Set(value As String)
                _BUSINESS_TYPE = value
            End Set
        End Property

        Public Property TERRITORY As String
            Get
                Return _TERRITORY
            End Get
            Set(value As String)
                _TERRITORY = value
            End Set
        End Property

        Public Property ROUTE As String
            Get
                Return _ROUTE
            End Get
            Set(value As String)
                _ROUTE = value
            End Set
        End Property

        Public Property SEGMENT As String
            Get
                Return _SEGMENT
            End Get
            Set(value As String)
                _SEGMENT = value
            End Set
        End Property

        Public Property SEGMENT_LOCATION As String
            Get
                Return _SEGMENT_LOCATION
            End Get
            Set(value As String)
                _SEGMENT_LOCATION = value
            End Set
        End Property

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
            End Set
        End Property

        Public Property ACCOUNT_NO As String
            Get
                Return _ACCOUNT_NO
            End Get
            Set(value As String)
                _ACCOUNT_NO = value
            End Set
        End Property

        Public Property DATE_REVIEW As String
            Get
                Return _DATE_REVIEW
            End Get
            Set(value As String)
                _DATE_REVIEW = value
            End Set
        End Property

        Public Property HOUR_VISIT As String
            Get
                Return _HOUR_VISIT
            End Get
            Set(value As String)
                _HOUR_VISIT = value
            End Set
        End Property

        Public Property ATTENTION_TYPE As String
            Get
                Return _ATTENTION_TYPE
            End Get
            Set(value As String)
                _ATTENTION_TYPE = value
            End Set
        End Property

        Public Property FAX_NUMBER As String
            Get
                Return _FAX_NUMBER
            End Get
            Set(value As String)
                _FAX_NUMBER = value
            End Set
        End Property

        Public Property EMAIL As String
            Get
                Return _EMAIL
            End Get
            Set(value As String)
                _EMAIL = value
            End Set
        End Property

        Public Property WEBSITE As String
            Get
                Return _WEBSITE
            End Get
            Set(value As String)
                _WEBSITE = value
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

        Public Property IS_PRIMARY As String
            Get
                Return _IS_PRIMARY
            End Get
            Set(value As String)
                _IS_PRIMARY = value
            End Set
        End Property

        Public Property RETENTION As String
            Get
                Return _RETENTION
            End Get
            Set(value As String)
                _RETENTION = value
            End Set
        End Property

        Public Property DOCUMENT_TYPE_PERSON_ID As String
            Get
                Return _DOCUMENT_TYPE_PERSON_ID
            End Get
            Set(value As String)
                _DOCUMENT_TYPE_PERSON_ID = value
            End Set
        End Property

        Public Property TYPE_COMPANY As String
            Get
                Return _TYPE_COMPANY
            End Get
            Set(value As String)
                _TYPE_COMPANY = value
            End Set
        End Property

        Public Property ACCOUNT_LOCAL As String
            Get
                Return _ACCOUNT_LOCAL
            End Get
            Set(value As String)
                _ACCOUNT_LOCAL = value
            End Set
        End Property

        Public Property ACCOUNT_EXTERNAL As String
            Get
                Return _ACCOUNT_EXTERNAL
            End Get
            Set(value As String)
                _ACCOUNT_EXTERNAL = value
            End Set
        End Property

    End Class

    Public Class LETTER_EXCHANGE
        Private _ID As String
        Private _DATE_EXCHANGE As String
        Private _VOUCHER_ID As String
        Private _CREATE_DATE As String
        Private _USER_ID As String
        Private _STATUS As String
        Private _ACCEPT_DATE As String
        Private _SELL_RATE As Double
        Private _CURRENCY_ID As String
        Private _CUSTOMER_ID As String
        Private _COMMENT As String

        Public Sub New()
            _ID = String.Empty
            _DATE_EXCHANGE = String.Empty
            _VOUCHER_ID = String.Empty
            _CREATE_DATE = String.Empty
            _USER_ID = String.Empty
            _STATUS = String.Empty
            _ACCEPT_DATE = String.Empty
            _SELL_RATE = 0
            _CURRENCY_ID = String.Empty
            _CUSTOMER_ID = String.Empty
        End Sub

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
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

        Public Property DATE_EXCHANGE As String
            Get
                Return _DATE_EXCHANGE
            End Get
            Set(value As String)
                _DATE_EXCHANGE = value
            End Set
        End Property

        Public Property VOUCHER_ID As String
            Get
                Return _VOUCHER_ID
            End Get
            Set(value As String)
                _VOUCHER_ID = value
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


        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
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

        Public Property ACCEPT_DATE As String
            Get
                Return _ACCEPT_DATE
            End Get
            Set(value As String)
                _ACCEPT_DATE = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property

        Public Property CUSTOMER_ID As String
            Get
                Return _CUSTOMER_ID
            End Get
            Set(value As String)
                _CUSTOMER_ID = value
            End Set
        End Property

    End Class

    Public Class CHECK_EXCHANGE
        Private _ID As String
        Private _DATE_EXCHANGE As String
        Private _CREATE_DATE As String
        Private _USER_ID As String
        Private _CUSTOMER_ID As String
        Private _SELL_RATE As Double
        Private _AMOUNT As Double
        Private _CURRENCY_ID As String
        Private _SALES_ID As String
        Private _STATUS As String
        Private _COMMENT As String

        Public Sub New()
            _ID = String.Empty
            _DATE_EXCHANGE = String.Empty
            _CREATE_DATE = String.Empty
            _USER_ID = String.Empty
            _CUSTOMER_ID = String.Empty
            _SELL_RATE = 0
            _AMOUNT = 0
            _CURRENCY_ID = String.Empty
            _SALES_ID = String.Empty
            _STATUS = String.Empty
            _COMMENT = String.Empty
        End Sub

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
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

        Public Property DATE_EXCHANGE As String
            Get
                Return _DATE_EXCHANGE
            End Get
            Set(value As String)
                _DATE_EXCHANGE = value
            End Set
        End Property

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
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


        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
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


        Public Property SELL_RATE As Double
            Get
                Return _SELL_RATE
            End Get
            Set(value As Double)
                _SELL_RATE = value
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

        Public Property CUSTOMER_ID As String
            Get
                Return _CUSTOMER_ID
            End Get
            Set(value As String)
                _CUSTOMER_ID = value
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

    End Class

    Public Class LETTER

        Private _LETTER_ID As String
        Private _BANK_ID As String
        Private _COMMENT As String
        Private _STATUS_ACT As String
        Private _STATUS_LAST As String
        Private _PLACE_SHIP As String
        Private _GUARANTOR_NAME As String
        Private _GUARANTOR_PHONE As String
        Private _GUARANTOR_ADDR As String
        Private _GUARANTOR_NAME2 As String
        Private _GUARANTOR_ADDR2 As String
        Private _GUARANTOR_PHONE2 As String
        Private _LETTER_ORIG As String
        Private _NUMBER_ACCOUNT As String
        Private _NUMBER_BANK As String
        Private _TYPE_DOC As String
        Private _CREATE_DATE As String
        Private _UPDATE_DATE As String

        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
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

        Public Property LETTER_ID As String
            Get
                Return _LETTER_ID
            End Get
            Set(value As String)
                _LETTER_ID = value
            End Set
        End Property

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
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

        Public Property STATUS_ACT As String
            Get
                Return _STATUS_ACT
            End Get
            Set(value As String)
                _STATUS_ACT = value
            End Set
        End Property

        Public Property STATUS_LAST As String
            Get
                Return _STATUS_LAST
            End Get
            Set(value As String)
                _STATUS_LAST = value
            End Set
        End Property

        Public Property PLACE_SHIP As String
            Get
                Return _PLACE_SHIP
            End Get
            Set(value As String)
                _PLACE_SHIP = value
            End Set
        End Property

        Public Property GUARANTOR_NAME As String
            Get
                Return _GUARANTOR_NAME
            End Get
            Set(value As String)
                _GUARANTOR_NAME = value
            End Set
        End Property

        Public Property GUARANTOR_PHONE As String
            Get
                Return _GUARANTOR_PHONE
            End Get
            Set(value As String)
                _GUARANTOR_PHONE = value
            End Set
        End Property

        Public Property GUARANTOR_ADDR As String
            Get
                Return _GUARANTOR_ADDR
            End Get
            Set(value As String)
                _GUARANTOR_ADDR = value
            End Set
        End Property

        Public Property GUARANTOR_ADDR2 As String
            Get
                Return _GUARANTOR_ADDR2
            End Get
            Set(value As String)
                _GUARANTOR_ADDR2 = value
            End Set
        End Property

        Public Property GUARANTOR_NAME2 As String
            Get
                Return _GUARANTOR_NAME2
            End Get
            Set(value As String)
                _GUARANTOR_NAME2 = value
            End Set
        End Property

        Public Property GUARANTOR_PHONE2 As String
            Get
                Return _GUARANTOR_PHONE2
            End Get
            Set(value As String)
                _GUARANTOR_PHONE2 = value
            End Set
        End Property

        Public Property LETTER_ORIG As String
            Get
                Return _LETTER_ORIG
            End Get
            Set(value As String)
                _LETTER_ORIG = value
            End Set
        End Property

        Public Property NUMBER_ACCOUNT As String
            Get
                Return _NUMBER_ACCOUNT
            End Get
            Set(value As String)
                _NUMBER_ACCOUNT = value
            End Set
        End Property

        Public Property NUMBER_BANK As String
            Get
                Return _NUMBER_BANK
            End Get
            Set(value As String)
                _NUMBER_BANK = value
            End Set
        End Property

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

    End Class

    Public Class LETTER_PAY

        Private _LETTER_ID As String
        Private _BANK_ID As String
        Private _COMMENT As String
        Private _STATUS_ACT As String
        Private _STATUS_LAST As String
        Private _PLACE_SHIP As String
        Private _GUARANTOR_NAME As String
        Private _GUARANTOR_PHONE As String
        Private _GUARANTOR_ADDR As String
        Private _GUARANTOR_NAME2 As String
        Private _GUARANTOR_ADDR2 As String
        Private _GUARANTOR_PHONE2 As String
        Private _LETTER_ORIG As String
        Private _NUMBER_ACCOUNT As String
        Private _NUMBER_BANK As String
        Private _TYPE_DOC As String
        Private _CREATE_DATE As String
        Private _UPDATE_DATE As String

        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
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

        Public Property LETTER_ID As String
            Get
                Return _LETTER_ID
            End Get
            Set(value As String)
                _LETTER_ID = value
            End Set
        End Property

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
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

        Public Property STATUS_ACT As String
            Get
                Return _STATUS_ACT
            End Get
            Set(value As String)
                _STATUS_ACT = value
            End Set
        End Property

        Public Property STATUS_LAST As String
            Get
                Return _STATUS_LAST
            End Get
            Set(value As String)
                _STATUS_LAST = value
            End Set
        End Property

        Public Property PLACE_SHIP As String
            Get
                Return _PLACE_SHIP
            End Get
            Set(value As String)
                _PLACE_SHIP = value
            End Set
        End Property

        Public Property GUARANTOR_NAME As String
            Get
                Return _GUARANTOR_NAME
            End Get
            Set(value As String)
                _GUARANTOR_NAME = value
            End Set
        End Property

        Public Property GUARANTOR_PHONE As String
            Get
                Return _GUARANTOR_PHONE
            End Get
            Set(value As String)
                _GUARANTOR_PHONE = value
            End Set
        End Property

        Public Property GUARANTOR_ADDR As String
            Get
                Return _GUARANTOR_ADDR
            End Get
            Set(value As String)
                _GUARANTOR_ADDR = value
            End Set
        End Property

        Public Property GUARANTOR_ADDR2 As String
            Get
                Return _GUARANTOR_ADDR2
            End Get
            Set(value As String)
                _GUARANTOR_ADDR2 = value
            End Set
        End Property

        Public Property GUARANTOR_NAME2 As String
            Get
                Return _GUARANTOR_NAME2
            End Get
            Set(value As String)
                _GUARANTOR_NAME2 = value
            End Set
        End Property

        Public Property GUARANTOR_PHONE2 As String
            Get
                Return _GUARANTOR_PHONE2
            End Get
            Set(value As String)
                _GUARANTOR_PHONE2 = value
            End Set
        End Property

        Public Property LETTER_ORIG As String
            Get
                Return _LETTER_ORIG
            End Get
            Set(value As String)
                _LETTER_ORIG = value
            End Set
        End Property

        Public Property NUMBER_ACCOUNT As String
            Get
                Return _NUMBER_ACCOUNT
            End Get
            Set(value As String)
                _NUMBER_ACCOUNT = value
            End Set
        End Property

        Public Property NUMBER_BANK As String
            Get
                Return _NUMBER_BANK
            End Get
            Set(value As String)
                _NUMBER_BANK = value
            End Set
        End Property

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

    End Class

    Public Class LETTER_EXCHANGE_LINE
        Private _ID As String
        Private _ITEM As String
        Private _TYPE_DOC As String
        Private _NUMBER_DOC As String
        Private _AMOUNT As Double
        Private _CADUCATE_DATE As String
        Private _IS_ORIG As String
        Private _OPCION As String

        Public Sub New()
            _ID = String.Empty
            _ITEM = String.Empty
            _TYPE_DOC = String.Empty
            _NUMBER_DOC = String.Empty
            _AMOUNT = 0
            _CADUCATE_DATE = String.Empty
            _IS_ORIG = String.Empty
            _OPCION = String.Empty
        End Sub

        Public Property OPCION As String
            Get
                Return _OPCION
            End Get
            Set(value As String)
                _OPCION = value
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

        Public Property ITEM As String
            Get
                Return _ITEM
            End Get
            Set(value As String)
                _ITEM = value
            End Set
        End Property

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

        Public Property NUMBER_DOC As String
            Get
                Return _NUMBER_DOC
            End Get
            Set(value As String)
                _NUMBER_DOC = value
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

        Public Property CADUCATE_DATE As String
            Get
                Return _CADUCATE_DATE
            End Get
            Set(value As String)
                _CADUCATE_DATE = value
            End Set
        End Property

        Public Property IS_ORIG As String
            Get
                Return _IS_ORIG
            End Get
            Set(value As String)
                _IS_ORIG = value
            End Set
        End Property
    End Class

    Public Class CHECK_EXCHANGE_LINE
        Private _ID As String
        Private _ITEM As String
        Private _TYPE_DOC As String
        Private _NUMBER_DOC As String
        Private _DATE As String
        Private _CURRENCY_ID As String
        Private _AMOUNT As Double
        Private _AMOUNT_BALANCE As Double
        Private _AMOUNT_ACT As Double
        Private _BANK_DESCRIPTION As String
        Private _BANK_ID As String
        Private _CADUCATE_DATE As String
        Private _OPCION As String
        Private _IS_ORIG As String
        Private _NUMBER_TYPE As String

        Public Sub New()
            _ID = String.Empty
            _ITEM = String.Empty
            _TYPE_DOC = String.Empty
            _NUMBER_DOC = String.Empty
            _DATE = String.Empty
            _CURRENCY_ID = String.Empty
            _AMOUNT = 0
            _AMOUNT_BALANCE = 0
            _AMOUNT_ACT = 0
            _BANK_DESCRIPTION = String.Empty
            _BANK_ID = String.Empty
            _CADUCATE_DATE = String.Empty
            _IS_ORIG = String.Empty
            _OPCION = String.Empty
            _NUMBER_TYPE = String.Empty
        End Sub
        Public Property DATEE As String
            Get
                Return _DATE
            End Get
            Set(value As String)
                _DATE = value
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
        Public Property AMOUNT_BALANCE As Double
            Get
                Return _AMOUNT_BALANCE
            End Get
            Set(value As Double)
                _AMOUNT_BALANCE = value
            End Set
        End Property
        Public Property AMOUNT_ACT As Double
            Get
                Return _AMOUNT_ACT
            End Get
            Set(value As Double)
                _AMOUNT_ACT = value
            End Set
        End Property

        Public Property BANK_DESCRIPTION As String
            Get
                Return _BANK_DESCRIPTION
            End Get
            Set(value As String)
                _BANK_DESCRIPTION = value
            End Set
        End Property

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
            End Set
        End Property

        Public Property NUMBER_TYPE As String
            Get
                Return _NUMBER_TYPE
            End Get
            Set(value As String)
                _NUMBER_TYPE = value
            End Set
        End Property

        Public Property OPCION As String
            Get
                Return _OPCION
            End Get
            Set(value As String)
                _OPCION = value
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

        Public Property ITEM As String
            Get
                Return _ITEM
            End Get
            Set(value As String)
                _ITEM = value
            End Set
        End Property

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

        Public Property NUMBER_DOC As String
            Get
                Return _NUMBER_DOC
            End Get
            Set(value As String)
                _NUMBER_DOC = value
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

        Public Property CADUCATE_DATE As String
            Get
                Return _CADUCATE_DATE
            End Get
            Set(value As String)
                _CADUCATE_DATE = value
            End Set
        End Property

        Public Property IS_ORIG As String
            Get
                Return _IS_ORIG
            End Get
            Set(value As String)
                _IS_ORIG = value
            End Set
        End Property
    End Class

    Public Class LETTER_EXCHANGE_PAY
        Private _ID As String
        Private _DATE_EXCHANGE As String
        Private _VOUCHER_ID As String
        Private _CREATE_DATE As String
        Private _USER_ID As String
        Private _STATUS As String
        Private _ACCEPT_DATE As String
        Private _SELL_RATE As Double
        Private _CURRENCY_ID As String
        Private _CUSTOMER_ID As String
        Private _COMMENT As String

        Public Sub New()
            _ID = String.Empty
            _DATE_EXCHANGE = String.Empty
            _VOUCHER_ID = String.Empty
            _CREATE_DATE = String.Empty
            _USER_ID = String.Empty
            _STATUS = String.Empty
            _ACCEPT_DATE = String.Empty
            _SELL_RATE = 0
            _CURRENCY_ID = String.Empty
            _CUSTOMER_ID = String.Empty
            _COMMENT = String.Empty
        End Sub

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property DATE_EXCHANGE As String
            Get
                Return _DATE_EXCHANGE
            End Get
            Set(value As String)
                _DATE_EXCHANGE = value
            End Set
        End Property

        Public Property VOUCHER_ID As String
            Get
                Return _VOUCHER_ID
            End Get
            Set(value As String)
                _VOUCHER_ID = value
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


        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
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

        Public Property ACCEPT_DATE As String
            Get
                Return _ACCEPT_DATE
            End Get
            Set(value As String)
                _ACCEPT_DATE = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
            End Set
        End Property

        Public Property CUSTOMER_ID As String
            Get
                Return _CUSTOMER_ID
            End Get
            Set(value As String)
                _CUSTOMER_ID = value
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

    End Class

    Public Class LETTER_EXCHANGE_LINE_PAY
        Private _ID As String
        Private _ITEM As String
        Private _TYPE_DOC As String
        Private _NUMBER_DOC As String
        Private _AMOUNT As Double
        Private _CADUCATE_DATE As String
        Private _IS_ORIG As String
        Private _OPCION As String

        Public Sub New()
            _ID = String.Empty
            _ITEM = String.Empty
            _TYPE_DOC = String.Empty
            _NUMBER_DOC = String.Empty
            _AMOUNT = 0
            _CADUCATE_DATE = String.Empty
            _IS_ORIG = String.Empty
            _OPCION = String.Empty
        End Sub

        Public Property OPCION As String
            Get
                Return _OPCION
            End Get
            Set(value As String)
                _OPCION = value
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

        Public Property ITEM As String
            Get
                Return _ITEM
            End Get
            Set(value As String)
                _ITEM = value
            End Set
        End Property

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

        Public Property NUMBER_DOC As String
            Get
                Return _NUMBER_DOC
            End Get
            Set(value As String)
                _NUMBER_DOC = value
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

        Public Property CADUCATE_DATE As String
            Get
                Return _CADUCATE_DATE
            End Get
            Set(value As String)
                _CADUCATE_DATE = value
            End Set
        End Property

        Public Property IS_ORIG As String
            Get
                Return _IS_ORIG
            End Get
            Set(value As String)
                _IS_ORIG = value
            End Set
        End Property
    End Class




    Public Class RECEIVABLE_LIST
        Private _ID As String
        Private _DATE_PLA As String
        Private _AMOUNT As Double
        Private _AMOUNT_US As Double
        Private _AMOUNT_CH_DIF As Double
        Private _AMOUNT_CH_DIF_US As Double
        Private _VOUCHER_ID As String
        Private _STATUS As String
        Private _CREATE_DATE As String
        Private _USER_ID As String
        Private _SALES_ID As String
        Private _VOUCHER_ID_US As String
        Private _SELL_RATE As Double


        Public Sub New()
            _ID = String.Empty
            _DATE_PLA = String.Empty
            _AMOUNT = 0
            _AMOUNT_US = 0
            _AMOUNT_CH_DIF = 0
            _AMOUNT_CH_DIF_US = 0
            _VOUCHER_ID = String.Empty
            _STATUS = "0"
            _CREATE_DATE = String.Empty
            _USER_ID = String.Empty
            _SALES_ID = String.Empty
            _VOUCHER_ID_US = String.Empty
            _SELL_RATE = 0
        End Sub

        Public Property SELL_RATE As Double
            Get
                Return _SELL_RATE
            End Get
            Set(value As Double)
                _SELL_RATE = value
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

        Public Property DATE_PLA As String
            Get
                Return _DATE_PLA
            End Get
            Set(value As String)
                _DATE_PLA = value
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

        Public Property AMOUNT_US As Double
            Get
                Return _AMOUNT_US
            End Get
            Set(value As Double)
                _AMOUNT_US = value
            End Set
        End Property

        Public Property AMOUNT_CH_DIF As Double
            Get
                Return _AMOUNT_CH_DIF
            End Get
            Set(value As Double)
                _AMOUNT_CH_DIF = value
            End Set
        End Property

        Public Property AMOUNT_CH_DIF_US As Double
            Get
                Return _AMOUNT_CH_DIF_US
            End Get
            Set(value As Double)
                _AMOUNT_CH_DIF_US = value
            End Set
        End Property

        Public Property VOUCHER_ID As String
            Get
                Return _VOUCHER_ID
            End Get
            Set(value As String)
                _VOUCHER_ID = value
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

        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
                _CREATE_DATE = value
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

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
            End Set
        End Property

        Public Property VOUCHER_ID_US As String
            Get
                Return _VOUCHER_ID_US
            End Get
            Set(value As String)
                _VOUCHER_ID_US = value
            End Set
        End Property

    End Class

    Public Class RECEIVABLE_CAJA_CHICA
        Private _ID As String
        Private _DATE_PLA As String
        Private _AMOUNT As Double
        Private _AMOUNT_US As Double
        Private _AMOUNT_CH_DIF As Double
        Private _AMOUNT_CH_DIF_US As Double
        Private _VOUCHER_ID As String
        Private _STATUS As String
        Private _CREATE_DATE As String
        Private _USER_ID As String
        Private _SALES_ID As String
        Private _VOUCHER_ID_US As String
        Private _SELL_RATE As Double
        Private _SALDO_INICIAL As Double
        Private _INGRESOS As Double
        Private _EGRESOS As Double
        Private _SALDO_FINAL As Double
        Private _SALDO_INICIAL_ME As Double
        Private _INGRESOS_ME As Double
        Private _EGRESOS_ME As Double
        Private _SALDO_FINAL_ME As Double


        Public Sub New()
            _ID = String.Empty
            _DATE_PLA = String.Empty
            _AMOUNT = 0
            _AMOUNT_US = 0
            _AMOUNT_CH_DIF = 0
            _AMOUNT_CH_DIF_US = 0
            _VOUCHER_ID = String.Empty
            _STATUS = "0"
            _CREATE_DATE = String.Empty
            _USER_ID = String.Empty
            _SALES_ID = String.Empty
            _VOUCHER_ID_US = String.Empty
            _SELL_RATE = 0
            _SALDO_INICIAL = 0
            _SALDO_FINAL = 0
            _INGRESOS = 0
            _EGRESOS = 0

            _SALDO_INICIAL_ME = 0
            _SALDO_FINAL_ME = 0
            _INGRESOS_ME = 0
            _EGRESOS_ME = 0
        End Sub


        Public Property SALDO_INICIAL_ME As Double
            Get
                Return _SALDO_INICIAL_ME
            End Get
            Set(value As Double)
                _SALDO_INICIAL_ME = value
            End Set
        End Property
        Public Property SALDO_FINAL_ME As Double
            Get
                Return _SALDO_FINAL_ME
            End Get
            Set(value As Double)
                _SALDO_FINAL_ME = value
            End Set
        End Property
        Public Property INGRESOS_ME As Double
            Get
                Return _INGRESOS_ME
            End Get
            Set(value As Double)
                _INGRESOS_ME = value
            End Set
        End Property
        Public Property EGRESOS_ME As Double
            Get
                Return _EGRESOS_ME
            End Get
            Set(value As Double)
                _EGRESOS_ME = value
            End Set
        End Property


        Public Property SALDO_INICIAL As Double
            Get
                Return _SALDO_INICIAL
            End Get
            Set(value As Double)
                _SALDO_INICIAL = value
            End Set
        End Property
        Public Property SALDO_FINAL As Double
            Get
                Return _SALDO_FINAL
            End Get
            Set(value As Double)
                _SALDO_FINAL = value
            End Set
        End Property
        Public Property INGRESOS As Double
            Get
                Return _INGRESOS
            End Get
            Set(value As Double)
                _INGRESOS = value
            End Set
        End Property
        Public Property EGRESOS As Double
            Get
                Return _EGRESOS
            End Get
            Set(value As Double)
                _EGRESOS = value
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

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property DATE_PLA As String
            Get
                Return _DATE_PLA
            End Get
            Set(value As String)
                _DATE_PLA = value
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

        Public Property AMOUNT_US As Double
            Get
                Return _AMOUNT_US
            End Get
            Set(value As Double)
                _AMOUNT_US = value
            End Set
        End Property

        Public Property AMOUNT_CH_DIF As Double
            Get
                Return _AMOUNT_CH_DIF
            End Get
            Set(value As Double)
                _AMOUNT_CH_DIF = value
            End Set
        End Property

        Public Property AMOUNT_CH_DIF_US As Double
            Get
                Return _AMOUNT_CH_DIF_US
            End Get
            Set(value As Double)
                _AMOUNT_CH_DIF_US = value
            End Set
        End Property

        Public Property VOUCHER_ID As String
            Get
                Return _VOUCHER_ID
            End Get
            Set(value As String)
                _VOUCHER_ID = value
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

        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
                _CREATE_DATE = value
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

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
            End Set
        End Property

        Public Property VOUCHER_ID_US As String
            Get
                Return _VOUCHER_ID_US
            End Get
            Set(value As String)
                _VOUCHER_ID_US = value
            End Set
        End Property

    End Class

    Public Class RECEIVABLE_LIST_LINE
        Private _ID As String
        Private _ITEM As String
        Private _TYPE_DOC As String
        Private _NUMBER_DOC As String
        Private _TYPE_OPERATION As String
        Private _REC_ID As String
        Private _DATE_PLA As String
        Private _AMOUNT As Double
        Private _CURRENCY_ID As String
        Private _SELL_RATE As Double
        Private _CREATE_DATE As String
        Private _USER_ID As String
        Private _COMMENT As String
        Private _SALES_ID As String
        Private _BANK_ID As String
        Private _BANK_DESCRIPTION As String
        Private _DOC_REF As String
        Private _NUM_REF As String
        Private _LIST_ID As Integer
        Private _IS_CASH_BANK As Integer
        Private _AMOUNT_PER As Double
        Private _BANK_BUSSINESS_ID As String
        Private _ACCOUNT_BANK_CHECK As String
        Private _PAY_AUTO As String
        Private _ANNEX_ID_AUX As String
        Private _DOCUMET_ID As String
        Private _NUMBER_SERIE As String
        Private _NUMBER_DOCUMENT As String
        Private _MEDIOS_PAGO As String

        Public Sub New()
            _ID = String.Empty
            _ITEM = String.Empty
            _TYPE_DOC = String.Empty
            _NUMBER_DOC = String.Empty
            _TYPE_OPERATION = String.Empty
            _REC_ID = String.Empty
            _DATE_PLA = String.Empty
            _AMOUNT = 0
            _CURRENCY_ID = String.Empty
            _SELL_RATE = 0
            _CREATE_DATE = String.Empty
            _USER_ID = String.Empty
            _COMMENT = String.Empty
            _SALES_ID = String.Empty
            _BANK_ID = String.Empty
            _BANK_DESCRIPTION = String.Empty
            _DOC_REF = String.Empty
            _NUM_REF = String.Empty
            _LIST_ID = 0
            _IS_CASH_BANK = 0
            _AMOUNT_PER = 0
            _BANK_BUSSINESS_ID = String.Empty
            _ACCOUNT_BANK_CHECK = String.Empty
            _PAY_AUTO = 0
            _ANNEX_ID_AUX = String.Empty
            _DOCUMET_ID = String.Empty
            _NUMBER_SERIE = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _MEDIOS_PAGO = String.Empty
        End Sub

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
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

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

        Public Property NUMBER_DOC As String
            Get
                Return _NUMBER_DOC
            End Get
            Set(value As String)
                _NUMBER_DOC = value
            End Set
        End Property

        Public Property TYPE_OPERATION As String
            Get
                Return _TYPE_OPERATION
            End Get
            Set(value As String)
                _TYPE_OPERATION = value
            End Set
        End Property

        Public Property REC_ID As String
            Get
                Return _REC_ID
            End Get
            Set(value As String)
                _REC_ID = value
            End Set
        End Property

        Public Property DATE_PLA As String
            Get
                Return _DATE_PLA
            End Get
            Set(value As String)
                _DATE_PLA = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
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

        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
                _CREATE_DATE = value
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

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
            End Set
        End Property

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
            End Set
        End Property

        Public Property BANK_DESCRIPTION As String
            Get
                Return _BANK_DESCRIPTION
            End Get
            Set(value As String)
                _BANK_DESCRIPTION = value
            End Set
        End Property

        Public Property DOC_REF As String
            Get
                Return _DOC_REF
            End Get
            Set(value As String)
                _DOC_REF = value
            End Set
        End Property

        Public Property NUM_REF As String
            Get
                Return _NUM_REF
            End Get
            Set(value As String)
                _NUM_REF = value
            End Set
        End Property

        Public Property LIST_ID As String
            Get
                Return _LIST_ID
            End Get
            Set(value As String)
                _LIST_ID = value
            End Set
        End Property

        Public Property IS_CASH_BANK As Integer
            Get
                Return _IS_CASH_BANK
            End Get
            Set(value As Integer)
                _IS_CASH_BANK = value
            End Set
        End Property

        Public Property AMOUNT_PER As Double
            Get
                Return _AMOUNT_PER
            End Get
            Set(value As Double)
                _AMOUNT_PER = value
            End Set
        End Property

        Public Property BANK_BUSSINESS_ID As String
            Get
                Return _BANK_BUSSINESS_ID
            End Get
            Set(value As String)
                _BANK_BUSSINESS_ID = value
            End Set
        End Property

        Public Property ACCOUNT_BANK_CHECK As String
            Get
                Return _ACCOUNT_BANK_CHECK
            End Get
            Set(value As String)
                _ACCOUNT_BANK_CHECK = value
            End Set
        End Property

        Public Property PAY_AUTO As String
            Get
                Return _PAY_AUTO
            End Get
            Set(value As String)
                _PAY_AUTO = value
            End Set
        End Property

        Public Property ANNEX_ID_AUX As String
            Get
                Return _ANNEX_ID_AUX
            End Get
            Set(value As String)
                _ANNEX_ID_AUX = value
            End Set
        End Property

        Public Property DOCUMET_ID As String
            Get
                Return _DOCUMET_ID
            End Get
            Set(value As String)
                _DOCUMET_ID = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
            End Set
        End Property

        Public Property MEDIOS_PAGO As String
            Get
                Return _MEDIOS_PAGO
            End Get
            Set(value As String)
                _MEDIOS_PAGO = value
            End Set
        End Property

    End Class

    Public Class RECEIVABLE_LINE_CAJA_CHICA
        Private _ID As String
        Private _ITEM As String
        Private _TYPE_DOC As String
        Private _NUMBER_DOC As String
        Private _TYPE_OPERATION As String
        Private _REC_ID As String
        Private _DATE_PLA As String
        Private _AMOUNT As Double
        Private _CURRENCY_ID As String
        Private _SELL_RATE As Double
        Private _CREATE_DATE As String
        Private _USER_ID As String
        Private _COMMENT As String
        Private _SALES_ID As String
        Private _BANK_ID As String
        Private _BANK_DESCRIPTION As String
        Private _DOC_REF As String
        Private _NUM_REF As String
        Private _LIST_ID As Integer
        Private _IS_CASH_BANK As Integer
        Private _AMOUNT_PER As Double
        Private _BANK_BUSSINESS_ID As String
        Private _ACCOUNT_BANK_CHECK As String
        Private _PAY_AUTO As String
        Private _ANNEX_ID_AUX As String
        Private _DOCUMET_ID As String
        Private _NUMBER_SERIE As String
        Private _NUMBER_DOCUMENT As String
        Private _MEDIOS_PAGO As String
        Private _OPT_AN As String
        Private _ID_PERSONAL As String
        Private _ID_MOVIMIENTO As String
        Private _MONTO_INGRESO As Double
        Private _MONTO_EGRESO As Double

        Private _TYPE_DOC_RENDICION As String
        Private _SERIE_DOC_RENDICION As String
        Private _NUMERO_DOC_RENDICION As String
        Private _FECHA_DOC_RENDICION As String
        Private _OBS_DOC_RENDICION As String
        Private _STATUS As String

        Private _USUARIO_DOC_RENDICION As String
        Private _TERMINAL_DOC_RENDICION As String
        Private _FECHA_ACT_DOC_RENDICION As String
        Private _COD_PROV_RENDICION As String

        Public Sub New()
            _ID = String.Empty
            _ITEM = String.Empty
            _TYPE_DOC = String.Empty
            _NUMBER_DOC = String.Empty
            _TYPE_OPERATION = String.Empty
            _REC_ID = String.Empty
            _DATE_PLA = String.Empty
            _AMOUNT = 0
            _CURRENCY_ID = String.Empty
            _SELL_RATE = 0
            _CREATE_DATE = String.Empty
            _USER_ID = String.Empty
            _COMMENT = String.Empty
            _SALES_ID = String.Empty
            _BANK_ID = String.Empty
            _BANK_DESCRIPTION = String.Empty
            _DOC_REF = String.Empty
            _NUM_REF = String.Empty
            _LIST_ID = 0
            _IS_CASH_BANK = 0
            _AMOUNT_PER = 0
            _BANK_BUSSINESS_ID = String.Empty
            _ACCOUNT_BANK_CHECK = String.Empty
            _PAY_AUTO = 0
            _ANNEX_ID_AUX = String.Empty
            _DOCUMET_ID = String.Empty
            _NUMBER_SERIE = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _MEDIOS_PAGO = String.Empty
            _OPT_AN = String.Empty
            _ID_PERSONAL = String.Empty
            _ID_MOVIMIENTO = String.Empty
            _MONTO_INGRESO = 0
            _MONTO_EGRESO = 0

            _TYPE_DOC_RENDICION = String.Empty
            _SERIE_DOC_RENDICION = String.Empty
            _NUMERO_DOC_RENDICION = String.Empty
            _FECHA_DOC_RENDICION = String.Empty
            _OBS_DOC_RENDICION = String.Empty
            _STATUS = String.Empty

            _USUARIO_DOC_RENDICION = String.Empty
            _TERMINAL_DOC_RENDICION = String.Empty
            _FECHA_ACT_DOC_RENDICION = String.Empty
            _COD_PROV_RENDICION = String.Empty

        End Sub
        Public Property COD_PROV_RENDICION As String
            Get
                Return _COD_PROV_RENDICION
            End Get
            Set(value As String)
                _COD_PROV_RENDICION = value
            End Set
        End Property

        Public Property USUARIO_DOC_RENDICION As String
            Get
                Return _USUARIO_DOC_RENDICION
            End Get
            Set(value As String)
                _USUARIO_DOC_RENDICION = value
            End Set
        End Property
        Public Property TERMINAL_DOC_RENDICION As String
            Get
                Return _TERMINAL_DOC_RENDICION
            End Get
            Set(value As String)
                _TERMINAL_DOC_RENDICION = value
            End Set
        End Property
        Public Property FECHA_ACT_DOC_RENDICION As String
            Get
                Return _FECHA_ACT_DOC_RENDICION
            End Get
            Set(value As String)
                _FECHA_ACT_DOC_RENDICION = value
            End Set
        End Property


        Public Property TYPE_DOC_RENDICION As String
            Get
                Return _TYPE_DOC_RENDICION
            End Get
            Set(value As String)
                _TYPE_DOC_RENDICION = value
            End Set
        End Property
        Public Property SERIE_DOC_RENDICION As String
            Get
                Return _SERIE_DOC_RENDICION
            End Get
            Set(value As String)
                _SERIE_DOC_RENDICION = value
            End Set
        End Property
        Public Property NUMERO_DOC_RENDICION As String
            Get
                Return _NUMERO_DOC_RENDICION
            End Get
            Set(value As String)
                _NUMERO_DOC_RENDICION = value
            End Set
        End Property
        Public Property FECHA_DOC_RENDICION As String
            Get
                Return _FECHA_DOC_RENDICION
            End Get
            Set(value As String)
                _FECHA_DOC_RENDICION = value
            End Set
        End Property
        Public Property OBS_DOC_RENDICION As String
            Get
                Return _OBS_DOC_RENDICION
            End Get
            Set(value As String)
                _OBS_DOC_RENDICION = value
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

        Public Property OPT_AN As String
            Get
                Return _OPT_AN
            End Get
            Set(value As String)
                _OPT_AN = value
            End Set
        End Property

        Public Property ID_PERSONAL As String
            Get
                Return _ID_PERSONAL
            End Get
            Set(value As String)
                _ID_PERSONAL = value
            End Set
        End Property

        Public Property ID_MOVIMIENTO As String
            Get
                Return _ID_MOVIMIENTO
            End Get
            Set(value As String)
                _ID_MOVIMIENTO = value
            End Set
        End Property

        Public Property MONTO_INGRESO As Double
            Get
                Return _MONTO_INGRESO
            End Get
            Set(value As Double)
                _MONTO_INGRESO = value
            End Set
        End Property

        Public Property MONTO_EGRESO As Double
            Get
                Return _MONTO_EGRESO
            End Get
            Set(value As Double)
                _MONTO_EGRESO = value
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

        Public Property ITEM As String
            Get
                Return _ITEM
            End Get
            Set(value As String)
                _ITEM = value
            End Set
        End Property

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

        Public Property NUMBER_DOC As String
            Get
                Return _NUMBER_DOC
            End Get
            Set(value As String)
                _NUMBER_DOC = value
            End Set
        End Property

        Public Property TYPE_OPERATION As String
            Get
                Return _TYPE_OPERATION
            End Get
            Set(value As String)
                _TYPE_OPERATION = value
            End Set
        End Property

        Public Property REC_ID As String
            Get
                Return _REC_ID
            End Get
            Set(value As String)
                _REC_ID = value
            End Set
        End Property

        Public Property DATE_PLA As String
            Get
                Return _DATE_PLA
            End Get
            Set(value As String)
                _DATE_PLA = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
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

        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
                _CREATE_DATE = value
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

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
            End Set
        End Property

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
            End Set
        End Property

        Public Property BANK_DESCRIPTION As String
            Get
                Return _BANK_DESCRIPTION
            End Get
            Set(value As String)
                _BANK_DESCRIPTION = value
            End Set
        End Property

        Public Property DOC_REF As String
            Get
                Return _DOC_REF
            End Get
            Set(value As String)
                _DOC_REF = value
            End Set
        End Property

        Public Property NUM_REF As String
            Get
                Return _NUM_REF
            End Get
            Set(value As String)
                _NUM_REF = value
            End Set
        End Property

        Public Property LIST_ID As String
            Get
                Return _LIST_ID
            End Get
            Set(value As String)
                _LIST_ID = value
            End Set
        End Property

        Public Property IS_CASH_BANK As Integer
            Get
                Return _IS_CASH_BANK
            End Get
            Set(value As Integer)
                _IS_CASH_BANK = value
            End Set
        End Property

        Public Property AMOUNT_PER As Double
            Get
                Return _AMOUNT_PER
            End Get
            Set(value As Double)
                _AMOUNT_PER = value
            End Set
        End Property

        Public Property BANK_BUSSINESS_ID As String
            Get
                Return _BANK_BUSSINESS_ID
            End Get
            Set(value As String)
                _BANK_BUSSINESS_ID = value
            End Set
        End Property

        Public Property ACCOUNT_BANK_CHECK As String
            Get
                Return _ACCOUNT_BANK_CHECK
            End Get
            Set(value As String)
                _ACCOUNT_BANK_CHECK = value
            End Set
        End Property

        Public Property PAY_AUTO As String
            Get
                Return _PAY_AUTO
            End Get
            Set(value As String)
                _PAY_AUTO = value
            End Set
        End Property

        Public Property ANNEX_ID_AUX As String
            Get
                Return _ANNEX_ID_AUX
            End Get
            Set(value As String)
                _ANNEX_ID_AUX = value
            End Set
        End Property

        Public Property DOCUMET_ID As String
            Get
                Return _DOCUMET_ID
            End Get
            Set(value As String)
                _DOCUMET_ID = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
            End Set
        End Property

        Public Property MEDIOS_PAGO As String
            Get
                Return _MEDIOS_PAGO
            End Get
            Set(value As String)
                _MEDIOS_PAGO = value
            End Set
        End Property

    End Class

    Public Class LETRAS_CAMBIO_GRUPAL
        Private _CUENTA As String
        Private _RUC As String
        Private _TIPO_DOC As String
        Private _SERIE_DOC As String
        Private _NUMERO_DOC As String
        Private _FEC_DOC As String
        Private _FEC_VEN_DOC As String
        Private _MONTO_DOC As Double
        Private _TIPO_MONEDA As Integer
        Private _TC As Double

        Public Sub New()
            _CUENTA = String.Empty
            _RUC = String.Empty
            _TIPO_DOC = String.Empty
            _SERIE_DOC = String.Empty
            _NUMERO_DOC = String.Empty
            _FEC_DOC = String.Empty
            _FEC_VEN_DOC = String.Empty
            _MONTO_DOC = 0
            _TIPO_MONEDA = 0
            _TC = 0
        End Sub

        Public Property CUENTA As String
            Get
                Return _CUENTA
            End Get
            Set(value As String)
                _CUENTA = value
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
        Public Property TIPO_DOC As String
            Get
                Return _TIPO_DOC
            End Get
            Set(value As String)
                _TIPO_DOC = value
            End Set
        End Property
        Public Property SERIE_DOC As String
            Get
                Return _SERIE_DOC
            End Get
            Set(value As String)
                _SERIE_DOC = value
            End Set
        End Property
        Public Property NUMERO_DOC As String
            Get
                Return _NUMERO_DOC
            End Get
            Set(value As String)
                _NUMERO_DOC = value
            End Set
        End Property
        Public Property FEC_DOC As String
            Get
                Return _FEC_DOC
            End Get
            Set(value As String)
                _FEC_DOC = value
            End Set
        End Property
        Public Property FEC_VEN_DOC As String
            Get
                Return _FEC_VEN_DOC
            End Get
            Set(value As String)
                _FEC_VEN_DOC = value
            End Set
        End Property
        Public Property TC As Double
            Get
                Return _MONTO_DOC
            End Get
            Set(value As Double)
                _MONTO_DOC = value
            End Set
        End Property
        Public Property MONTO_DOC As Double
            Get
                Return _TC
            End Get
            Set(value As Double)
                _TC = value
            End Set
        End Property
        Public Property TIPO_MONEDA As Integer
            Get
                Return _TIPO_MONEDA
            End Get
            Set(value As Integer)
                _TIPO_MONEDA = value
            End Set
        End Property
    End Class

    Public Class RECEIVABLE_LIST_LINE_PAY
        Private _ID As String
        Private _ITEM As String
        Private _TYPE_DOC As String
        Private _NUMBER_DOC As String
        Private _TYPE_OPERATION As String
        Private _REC_ID As String
        Private _DATE_PLA As String
        Private _AMOUNT As Double
        Private _CURRENCY_ID As String
        Private _SELL_RATE As Double
        Private _CREATE_DATE As String
        Private _USER_ID As String
        Private _COMMENT As String
        Private _SALES_ID As String
        Private _BANK_ID As String
        Private _BANK_DESCRIPTION As String
        Private _DOC_REF As String
        Private _NUM_REF As String
        Private _LIST_ID As Integer
        Private _IS_CASH_BANK As Integer
        Private _AMOUNT_PER As Double
        Private _BANK_BUSSINESS_ID As String
        Private _ACCOUNT_BANK_CHECK As String
        Private _PAY_AUTO As String
        Private _ANNEX_ID_AUX As String
        Private _DOCUMET_ID As String
        Private _NUMBER_SERIE As String
        Private _NUMBER_DOCUMENT As String
        Private _MEDIOS_PAGO As String
        Private _DATE_REF As String

        Public Sub New()
            _ID = String.Empty
            _ITEM = String.Empty
            _TYPE_DOC = String.Empty
            _NUMBER_DOC = String.Empty
            _TYPE_OPERATION = String.Empty
            _REC_ID = String.Empty
            _DATE_PLA = String.Empty
            _AMOUNT = 0
            _CURRENCY_ID = String.Empty
            _SELL_RATE = 0
            _CREATE_DATE = String.Empty
            _USER_ID = String.Empty
            _COMMENT = String.Empty
            _SALES_ID = String.Empty
            _BANK_ID = String.Empty
            _BANK_DESCRIPTION = String.Empty
            _DOC_REF = String.Empty
            _NUM_REF = String.Empty
            _LIST_ID = 0
            _IS_CASH_BANK = 0
            _AMOUNT_PER = 0
            _BANK_BUSSINESS_ID = String.Empty
            _ACCOUNT_BANK_CHECK = String.Empty
            _PAY_AUTO = 0
            _ANNEX_ID_AUX = String.Empty
            _DOCUMET_ID = String.Empty
            _NUMBER_SERIE = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _MEDIOS_PAGO = String.Empty
            _DATE_REF = String.Empty
        End Sub

        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Public Property DATE_REF As String
            Get
                Return _DATE_REF
            End Get
            Set(value As String)
                _DATE_REF = value
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

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

        Public Property NUMBER_DOC As String
            Get
                Return _NUMBER_DOC
            End Get
            Set(value As String)
                _NUMBER_DOC = value
            End Set
        End Property

        Public Property TYPE_OPERATION As String
            Get
                Return _TYPE_OPERATION
            End Get
            Set(value As String)
                _TYPE_OPERATION = value
            End Set
        End Property

        Public Property REC_ID As String
            Get
                Return _REC_ID
            End Get
            Set(value As String)
                _REC_ID = value
            End Set
        End Property

        Public Property DATE_PLA As String
            Get
                Return _DATE_PLA
            End Get
            Set(value As String)
                _DATE_PLA = value
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

        Public Property CURRENCY_ID As String
            Get
                Return _CURRENCY_ID
            End Get
            Set(value As String)
                _CURRENCY_ID = value
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

        Public Property CREATE_DATE As String
            Get
                Return _CREATE_DATE
            End Get
            Set(value As String)
                _CREATE_DATE = value
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

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property SALES_ID As String
            Get
                Return _SALES_ID
            End Get
            Set(value As String)
                _SALES_ID = value
            End Set
        End Property

        Public Property BANK_ID As String
            Get
                Return _BANK_ID
            End Get
            Set(value As String)
                _BANK_ID = value
            End Set
        End Property

        Public Property BANK_DESCRIPTION As String
            Get
                Return _BANK_DESCRIPTION
            End Get
            Set(value As String)
                _BANK_DESCRIPTION = value
            End Set
        End Property

        Public Property DOC_REF As String
            Get
                Return _DOC_REF
            End Get
            Set(value As String)
                _DOC_REF = value
            End Set
        End Property

        Public Property NUM_REF As String
            Get
                Return _NUM_REF
            End Get
            Set(value As String)
                _NUM_REF = value
            End Set
        End Property

        Public Property LIST_ID As String
            Get
                Return _LIST_ID
            End Get
            Set(value As String)
                _LIST_ID = value
            End Set
        End Property

        Public Property IS_CASH_BANK As Integer
            Get
                Return _IS_CASH_BANK
            End Get
            Set(value As Integer)
                _IS_CASH_BANK = value
            End Set
        End Property

        Public Property AMOUNT_PER As Double
            Get
                Return _AMOUNT_PER
            End Get
            Set(value As Double)
                _AMOUNT_PER = value
            End Set
        End Property

        Public Property BANK_BUSSINESS_ID As String
            Get
                Return _BANK_BUSSINESS_ID
            End Get
            Set(value As String)
                _BANK_BUSSINESS_ID = value
            End Set
        End Property

        Public Property ACCOUNT_BANK_CHECK As String
            Get
                Return _ACCOUNT_BANK_CHECK
            End Get
            Set(value As String)
                _ACCOUNT_BANK_CHECK = value
            End Set
        End Property

        Public Property PAY_AUTO As String
            Get
                Return _PAY_AUTO
            End Get
            Set(value As String)
                _PAY_AUTO = value
            End Set
        End Property

        Public Property ANNEX_ID_AUX As String
            Get
                Return _ANNEX_ID_AUX
            End Get
            Set(value As String)
                _ANNEX_ID_AUX = value
            End Set
        End Property

        Public Property DOCUMET_ID As String
            Get
                Return _DOCUMET_ID
            End Get
            Set(value As String)
                _DOCUMET_ID = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property NUMBER_DOCUMENT As String
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT = value
            End Set
        End Property

        Public Property MEDIOS_PAGO As String
            Get
                Return _MEDIOS_PAGO
            End Get
            Set(value As String)
                _MEDIOS_PAGO = value
            End Set
        End Property

    End Class

End Class
