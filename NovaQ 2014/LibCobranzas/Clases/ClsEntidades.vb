Public Class ClsEntidades

    'Public Class ORDER

    '    Private _ARCHIVO As Byte()
    '    Private _ITEM_TRANSPORTE As String
    '    Private _PLACE_DELIVERY As String
    '    Private _CONTACTO_NOMBRES As String
    '    Private _TIPO_PEDIDO As String
    '    Private _CONTACTO_DNI As String
    '    Private _CONTACTO_CELULAR As String
    '    Private _FECHA_ENTREGA As Date
    '    Private _FECHA_RECEPCION As Date
    '    Private _HORA_RECEPCION As String


    '    Public Property TIPO_PEDIDO As String
    '        Get
    '            Return _TIPO_PEDIDO
    '        End Get
    '        Set(value As String)
    '            _TIPO_PEDIDO = value
    '        End Set
    '    End Property

    '    Public Property CONTACTO_NOMBRES As String
    '        Get
    '            Return _CONTACTO_NOMBRES
    '        End Get
    '        Set(value As String)
    '            _CONTACTO_NOMBRES = value
    '        End Set
    '    End Property

    '    Public Property CONTACTO_DNI As String
    '        Get
    '            Return _CONTACTO_DNI
    '        End Get
    '        Set(value As String)
    '            _CONTACTO_DNI = value
    '        End Set
    '    End Property

    '    Public Property CONTACTO_CELULAR As String
    '        Get
    '            Return _CONTACTO_CELULAR
    '        End Get
    '        Set(value As String)
    '            _CONTACTO_CELULAR = value
    '        End Set
    '    End Property

    '    Public Property PLACE_DELIVERY As String
    '        Get
    '            Return _PLACE_DELIVERY
    '        End Get
    '        Set(value As String)
    '            _PLACE_DELIVERY = value
    '        End Set
    '    End Property

    '    Public Property ITEM_TRANSPORTE As String
    '        Get
    '            Return _ITEM_TRANSPORTE
    '        End Get
    '        Set(value As String)
    '            _ITEM_TRANSPORTE = value
    '        End Set
    '    End Property

    '    Public Property ARCHIVO As Byte()
    '        Get
    '            Return _ARCHIVO
    '        End Get
    '        Set(value As Byte())
    '            _ARCHIVO = value
    '        End Set
    '    End Property

    '    Public Property FECHA_ENTREGA As Date
    '        Get
    '            Return _FECHA_ENTREGA
    '        End Get
    '        Set(value As Date)
    '            _FECHA_ENTREGA = value
    '        End Set
    '    End Property

    '    Public Property FECHA_RECEPCION As Date
    '        Get
    '            Return _FECHA_RECEPCION
    '        End Get
    '        Set(value As Date)
    '            _FECHA_RECEPCION = value
    '        End Set
    '    End Property

    '    Public Property HORA_RECEPCION As String
    '        Get
    '            Return _HORA_RECEPCION
    '        End Get
    '        Set(value As String)
    '            _HORA_RECEPCION = value
    '        End Set
    '    End Property


    'End Class


    Public Class PURCHASE_ORDER

        Private _ORDER_PURCHASE As String
        Private _ARCHIVO As Byte()
    End Class




    Public Class UNIDADESmeDIDA
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _UNIT_ID As String
        Private _FACTOR As Integer
        Private _ALIAS As String
        Private _CODBAR As String
        Private _MOQ As Integer
        Private _MASTERPACK As Integer
        Private _IS_MAINUNIT As Boolean
        Private _IS_NOSALE As Boolean
        Private _IS_STOCKETD As Boolean
        Private _ID_DELETED As Boolean
        Private _USUCREA As String
        Private _FECCREA As DateTime
        Private _USUMOD As String
        Private _FECMOD As DateTime?
        Private _USUDEL As String
        Private _FECDEL As DateTime?
        Public Sub New()
            _ITEM = 0
            _PART_ID = String.Empty
            _UNIT_ID = String.Empty
            _FACTOR = 0
            _ALIAS = String.Empty
            _CODBAR = String.Empty
            _MOQ = 0
            _MASTERPACK = 0
            _IS_MAINUNIT = False
            _IS_NOSALE = False
            _IS_STOCKETD = False
            _ID_DELETED = False
            _USUCREA = String.Empty
            _FECCREA = DateTime.MinValue
            _USUMOD = String.Empty
            _FECMOD = Nothing
            _USUDEL = String.Empty
            _FECDEL = Nothing
        End Sub
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
        Public Property UNIT_ID As String
            Get
                Return _UNIT_ID
            End Get
            Set(value As String)
                _UNIT_ID = value
            End Set
        End Property
        Public Property FACTOR As Integer
            Get
                Return _FACTOR
            End Get
            Set(value As Integer)
                _FACTOR = value
            End Set
        End Property
        Public Property [ALIAS] As String
            Get
                Return _ALIAS
            End Get
            Set(value As String)
                _ALIAS = value
            End Set
        End Property
        Public Property CODBAR As String
            Get
                Return _CODBAR
            End Get
            Set(value As String)
                _CODBAR = value
            End Set
        End Property
        Public Property MOQ As Integer
            Get
                Return _MOQ
            End Get
            Set(value As Integer)
                _MOQ = value
            End Set
        End Property
        Public Property MASTERPACK As Integer
            Get
                Return _MASTERPACK
            End Get
            Set(value As Integer)
                _MASTERPACK = value
            End Set
        End Property
        Public Property IS_MAINUNIT As Boolean
            Get
                Return _IS_MAINUNIT
            End Get
            Set(value As Boolean)
                _IS_MAINUNIT = value
            End Set
        End Property
        Public Property IS_NOSALE As Boolean
            Get
                Return _IS_NOSALE
            End Get
            Set(value As Boolean)
                _IS_NOSALE = value
            End Set
        End Property
        Public Property IS_STOCKETD As Boolean
            Get
                Return _IS_STOCKETD
            End Get
            Set(value As Boolean)
                _IS_STOCKETD = value
            End Set
        End Property
        Public Property ID_DELETED As Boolean
            Get
                Return _ID_DELETED
            End Get
            Set(value As Boolean)
                _ID_DELETED = value
            End Set
        End Property
        Public Property USUCREA As String
            Get
                Return _USUCREA
            End Get
            Set(value As String)
                _USUCREA = value
            End Set
        End Property
        Public Property FECCREA As DateTime
            Get
                Return _FECCREA
            End Get
            Set(value As DateTime)
                _FECCREA = value
            End Set
        End Property
        Public Property USUMOD As String
            Get
                Return _USUMOD
            End Get
            Set(value As String)
                _USUMOD = value
            End Set
        End Property
        Public Property FECMOD As DateTime?
            Get
                Return _FECMOD
            End Get
            Set(value As DateTime?)
                _FECMOD = value
            End Set
        End Property
        Public Property USUDEL As String
            Get
                Return _USUDEL
            End Get
            Set(value As String)
                _USUDEL = value
            End Set
        End Property
        Public Property FECDEL As DateTime?
            Get
                Return _FECDEL
            End Get
            Set(value As DateTime?)
                _FECDEL = value
            End Set
        End Property
    End Class
    Public Class DIRECCIONESTRANSPORTISTAS
        Private _CODIGO As String
        Private _ITEM As String
        Private _ADDR As String
        Private _DEPARTAMENTO_ID As String
        Private _PROVINCIA_ID As String
        Private _DISTRITO_ID As String
        Public Sub New()
            _CODIGO = String.Empty
            _ITEM = String.Empty
            _ADDR = String.Empty
            _DEPARTAMENTO_ID = String.Empty
            _PROVINCIA_ID = String.Empty
            _DISTRITO_ID = String.Empty
        End Sub
        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
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
        Public Property ADDR As String
            Get
                Return _ADDR
            End Get
            Set(value As String)
                _ADDR = value
            End Set
        End Property
        Public Property DEPARTAMENTO_ID As String
            Get
                Return _DEPARTAMENTO_ID
            End Get
            Set(value As String)
                _DEPARTAMENTO_ID = value
            End Set
        End Property
        Public Property PROVINCIA_ID As String
            Get
                Return _PROVINCIA_ID
            End Get
            Set(value As String)
                _PROVINCIA_ID = value
            End Set
        End Property
        Public Property DISTRITO_ID As String
            Get
                Return _DISTRITO_ID
            End Get
            Set(value As String)
                _DISTRITO_ID = value
            End Set
        End Property
    End Class


    'Public Class TRANSACTION_TYPE

    '    Private _IS_GUIA_REMISION As String

    '    Public Sub New()
    '        _IS_GUIA_REMISION = String.Empty
    '    End Sub

    '    Public Property IS_GUIA_REMISION As String
    '        Get
    '            Return _IS_GUIA_REMISION
    '        End Get
    '        Set(value As String)
    '            _IS_GUIA_REMISION = value
    '        End Set
    '    End Property

    'End Class


    'Public Class WAREHOUSE_TRANS

    '    Private _UBIGEO_PARTIDA As String
    '    Private _DIRECCION_PARTIDA As String



    '    Public Sub New()
    '        _UBIGEO_PARTIDA = String.Empty
    '        _DIRECCION_PARTIDA = String.Empty
    '    End Sub

    '    Public Property UBIGEO_PARTIDA As String
    '        Get
    '            Return _UBIGEO_PARTIDA
    '        End Get
    '        Set(value As String)
    '            _UBIGEO_PARTIDA = value
    '        End Set
    '    End Property

    '    Public Property DIRECCION_PARTIDA As String
    '        Get
    '            Return _DIRECCION_PARTIDA
    '        End Get
    '        Set(value As String)
    '            _DIRECCION_PARTIDA = value
    '        End Set
    '    End Property



    'End Class


    Public Class PRICE_LIST_MASTER
        Private _ID As Integer
        Private _DESCRIPTION As String
        Private _DESCRIPTION_SHORT As String
        Private _TERMS_ID As Integer?
        Private _STATUS As String
        Private _IS_DELETED As Boolean
        Private _USUCREA As String
        Private _FECCREA As Date
        Private _USUMOD As String
        Private _FECMOD As Date?
        Private _USUDEL As String
        Private _FECDEL As Date?
        Public Sub New()
            _ID = 0
            _DESCRIPTION = String.Empty
            _DESCRIPTION_SHORT = String.Empty
            _TERMS_ID = Nothing
            _STATUS = String.Empty
            _IS_DELETED = False
            _USUCREA = String.Empty
            _FECCREA = Date.MinValue
            _USUMOD = String.Empty
            _FECMOD = Nothing
            _USUDEL = String.Empty
            _FECDEL = Nothing
        End Sub
        Public Property ID As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
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
        Public Property DESCRIPTION_SHORT As String
            Get
                Return _DESCRIPTION_SHORT
            End Get
            Set(value As String)
                _DESCRIPTION_SHORT = value
            End Set
        End Property
        Public Property TERMS_ID As Integer?
            Get
                Return _TERMS_ID
            End Get
            Set(value As Integer?)
                _TERMS_ID = value
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
        Public Property IS_DELETED As Boolean
            Get
                Return _IS_DELETED
            End Get
            Set(value As Boolean)
                _IS_DELETED = value
            End Set
        End Property
        Public Property USUCREA As String
            Get
                Return _USUCREA
            End Get
            Set(value As String)
                _USUCREA = value
            End Set
        End Property
        Public Property FECCREA As Date
            Get
                Return _FECCREA
            End Get
            Set(value As Date)
                _FECCREA = value
            End Set
        End Property
        Public Property USUMOD As String
            Get
                Return _USUMOD
            End Get
            Set(value As String)
                _USUMOD = value
            End Set
        End Property
        Public Property FECMOD As Date?
            Get
                Return _FECMOD
            End Get
            Set(value As Date?)
                _FECMOD = value
            End Set
        End Property
        Public Property USUDEL As String
            Get
                Return _USUDEL
            End Get
            Set(value As String)
                _USUDEL = value
            End Set
        End Property
        Public Property FECDEL As Date?
            Get
                Return _FECDEL
            End Get
            Set(value As Date?)
                _FECDEL = value
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
        Private _INGRESOS_VENTAS As Double
        Private _EGRESOS As Double
        Private _SALDO_FINAL As Double
        Private _SALDO_INICIAL_ME As Double
        Private _INGRESOS_ME As Double
        Private _INGRESOS_ME_VENTAS As Double
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
            _INGRESOS_VENTAS = 0
            _EGRESOS = 0

            _SALDO_INICIAL_ME = 0
            _SALDO_FINAL_ME = 0
            _INGRESOS_ME = 0
            _INGRESOS_ME_VENTAS = 0
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

        Public Property INGRESOS_ME_VENTAS As Double
            Get
                Return _INGRESOS_ME_VENTAS
            End Get
            Set(value As Double)
                _INGRESOS_ME_VENTAS = value
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
        Public Property INGRESOS_VENTAS As Double
            Get
                Return _INGRESOS_VENTAS
            End Get
            Set(value As Double)
                _INGRESOS_VENTAS = value
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

    Public Class PARTE_PRODUCCION
        Private _MAQUINA_COD As String
        Private _FECHA As String
        Private _MAQUINA As String
        Private _HORARIO As String
        Private _TURNO As String
        Private _TURNO_COD As String
        Private _SUPERVISOR As String
        Private _MAQUINISTA As String
        Private _AYUDANTE As String
        Private _HORAS_FIJAS As String
        Private _HORAS_EXTRAS As String
        Private _HORAS_PROGRAMADAS As String
        Private _HORAS_TRABAJADAS As String
        Private _VELOCIDAD_TEORICA As String
        Private _VELOCIDAD_REAL As String
        Private _PRODUCTIVIDAD As String
        Private _RESULTADOS As String
        Private _AREA_IMPRODUCTIVA As String
        Private _OBSERVACIONES As String
        Private _DETALLE_SERVICIO As String
        Private _TIEMPO_INVERTIDO As Double
        Private _USER_ID As String
        Private _PC_ID As String
        Private _CODIGO As String
        Private _OBS As String

        Private _PORCENTAJE As String
        Private _HORAS_PRODUCTIVAS As String
        Private _MANTENIMIENTO_PREVENTIVO As String

        Private _REFRIGERIO As String
        Private _PLIEGOS_PRODUCIDOS As String

        Private _HORAS_PROGRAMADAS_ISOGRAF As String
        Private _PLIEGOS_PROGRAMADAS_ISOGRAF As String
        Private _PLIEGOS_BUENOS As String
        Private _PLIEGOS_MALOS As String
        Public Property HORAS_PROGRAMADAS_ISOGRAF As String
            Get
                Return _HORAS_PROGRAMADAS_ISOGRAF
            End Get
            Set(value As String)
                _HORAS_PROGRAMADAS_ISOGRAF = value
            End Set
        End Property
        Public Property PLIEGOS_PROGRAMADAS_ISOGRAF As String
            Get
                Return _PLIEGOS_PROGRAMADAS_ISOGRAF
            End Get
            Set(value As String)
                _PLIEGOS_PROGRAMADAS_ISOGRAF = value
            End Set
        End Property
        Public Property PLIEGOS_BUENOS As String
            Get
                Return _PLIEGOS_BUENOS
            End Get
            Set(value As String)
                _PLIEGOS_BUENOS = value
            End Set
        End Property
        Public Property PLIEGOS_MALOS As String
            Get
                Return _PLIEGOS_MALOS
            End Get
            Set(value As String)
                _PLIEGOS_MALOS = value
            End Set
        End Property

        Public Property REFRIGERIO As String
            Get
                Return _REFRIGERIO
            End Get
            Set(value As String)
                _REFRIGERIO = value
            End Set
        End Property
        Public Property PLIEGOS_PRODUCIDOS As String
            Get
                Return _PLIEGOS_PRODUCIDOS
            End Get
            Set(value As String)
                _PLIEGOS_PRODUCIDOS = value
            End Set
        End Property

        Public Property PORCENTAJE As String
            Get
                Return _PORCENTAJE
            End Get
            Set(value As String)
                _PORCENTAJE = value
            End Set
        End Property
        Public Property HORAS_PRODUCTIVAS As String
            Get
                Return _HORAS_PRODUCTIVAS
            End Get
            Set(value As String)
                _HORAS_PRODUCTIVAS = value
            End Set
        End Property
        Public Property MANTENIMIENTO_PREVENTIVO As String
            Get
                Return _MANTENIMIENTO_PREVENTIVO
            End Get
            Set(value As String)
                _MANTENIMIENTO_PREVENTIVO = value
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
        Public Property OBS As String
            Get
                Return _OBS
            End Get
            Set(value As String)
                _OBS = value
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
        Public Property PC_ID As String
            Get
                Return _PC_ID
            End Get
            Set(value As String)
                _PC_ID = value
            End Set
        End Property

        Public Property MAQUINA_COD As String
            Get
                Return _MAQUINA_COD
            End Get
            Set(value As String)
                _MAQUINA_COD = value
            End Set
        End Property
        Public Property TURNO_COD As String
            Get
                Return _TURNO_COD
            End Get
            Set(value As String)
                _TURNO_COD = value
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
        Public Property MAQUINA As String
            Get
                Return _MAQUINA
            End Get
            Set(value As String)
                _MAQUINA = value
            End Set
        End Property
        Public Property HORARIO As String
            Get
                Return _HORARIO
            End Get
            Set(value As String)
                _HORARIO = value
            End Set
        End Property
        Public Property TURNO As String
            Get
                Return _TURNO
            End Get
            Set(value As String)
                _TURNO = value
            End Set
        End Property
        Public Property SUPERVISOR As String
            Get
                Return _SUPERVISOR
            End Get
            Set(value As String)
                _SUPERVISOR = value
            End Set
        End Property
        Public Property MAQUINISTA As String
            Get
                Return _MAQUINISTA
            End Get
            Set(value As String)
                _MAQUINISTA = value
            End Set
        End Property
        Public Property AYUDANTE As String
            Get
                Return _AYUDANTE
            End Get
            Set(value As String)
                _AYUDANTE = value
            End Set
        End Property
        Public Property HORAS_FIJAS As String
            Get
                Return _HORAS_FIJAS
            End Get
            Set(value As String)
                _HORAS_FIJAS = value
            End Set
        End Property
        Public Property HORAS_EXTRAS As String
            Get
                Return _HORAS_EXTRAS
            End Get
            Set(value As String)
                _HORAS_EXTRAS = value
            End Set
        End Property
        Public Property HORAS_PROGRAMADAS As String
            Get
                Return _HORAS_PROGRAMADAS
            End Get
            Set(value As String)
                _HORAS_PROGRAMADAS = value
            End Set
        End Property
        Public Property HORAS_TRABAJADAS As String
            Get
                Return _HORAS_TRABAJADAS
            End Get
            Set(value As String)
                _HORAS_TRABAJADAS = value
            End Set
        End Property
        Public Property VELOCIDAD_TEORICA As String
            Get
                Return _VELOCIDAD_TEORICA
            End Get
            Set(value As String)
                _VELOCIDAD_TEORICA = value
            End Set
        End Property
        Public Property VELOCIDAD_REAL As String
            Get
                Return _VELOCIDAD_REAL
            End Get
            Set(value As String)
                _VELOCIDAD_REAL = value
            End Set
        End Property
        Public Property PRODUCTIVIDAD As String
            Get
                Return _PRODUCTIVIDAD
            End Get
            Set(value As String)
                _PRODUCTIVIDAD = value
            End Set
        End Property
        Public Property RESULTADOS As String
            Get
                Return _RESULTADOS
            End Get
            Set(value As String)
                _RESULTADOS = value
            End Set
        End Property
        Public Property AREA_IMPRODUCTIVA As String
            Get
                Return _AREA_IMPRODUCTIVA
            End Get
            Set(value As String)
                _AREA_IMPRODUCTIVA = value
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
        Public Property DETALLE_SERVICIO As String
            Get
                Return _DETALLE_SERVICIO
            End Get
            Set(value As String)
                _DETALLE_SERVICIO = value
            End Set
        End Property
        Public Property TIEMPO_INVERTIDO As Double
            Get
                Return _TIEMPO_INVERTIDO
            End Get
            Set(value As Double)
                _TIEMPO_INVERTIDO = value
            End Set
        End Property
    End Class

    Public Class MANTENIMIENTO_OP_HISTORIAL_PERSONAL
        Private _USER_ID As String
        Private _EQUIPO_COD As String
        Private _FECHA As String
        Private _ITEM As Integer
        Private _DESCRIPCION As String
        Private _NUMERO_OP As String
        Private _USER_ID_REGISTRO As String
        Private _PC_ID_REGISTRO As String

        Private _NUMERO_OP_ID As Integer
        Private _ITEM_OP_ID As Integer
        Private _TURNO As String
        Private _FECHA_TURNO As String
        Private _MOTIVO_ACT_NO_PROGRAMADA As String
        Private _NUMERO_OP_II As String
        Private _AYUDANTE As String
        Private _SUPERVISOR As String
        Private _PLIEGOS_BUENOS As String
        Private _PLIEGOS_MALOS As String

        Private _HORAS_PROGRAMADAS_ISOGRAF As Double
        Private _PLIEGOS_PROGRAMADAS_ISOGRAF As Double

        Public Property HORAS_PROGRAMADAS_ISOGRAF As Double
            Get
                Return _HORAS_PROGRAMADAS_ISOGRAF
            End Get
            Set(value As Double)
                _HORAS_PROGRAMADAS_ISOGRAF = value
            End Set
        End Property
        Public Property PLIEGOS_PROGRAMADAS_ISOGRAF As Double
            Get
                Return _PLIEGOS_PROGRAMADAS_ISOGRAF
            End Get
            Set(value As Double)
                _PLIEGOS_PROGRAMADAS_ISOGRAF = value
            End Set
        End Property


        Public Property PLIEGOS_BUENOS As String
            Get
                Return _PLIEGOS_BUENOS
            End Get
            Set(value As String)
                _PLIEGOS_BUENOS = value
            End Set
        End Property
        Public Property PLIEGOS_MALOS As String
            Get
                Return _PLIEGOS_MALOS
            End Get
            Set(value As String)
                _PLIEGOS_MALOS = value
            End Set
        End Property

        Public Property SUPERVISOR As String
            Get
                Return _SUPERVISOR
            End Get
            Set(value As String)
                _SUPERVISOR = value
            End Set
        End Property

        Public Property AYUDANTE As String
            Get
                Return _AYUDANTE
            End Get
            Set(value As String)
                _AYUDANTE = value
            End Set
        End Property

        Public Property NUMERO_OP_II As String
            Get
                Return _NUMERO_OP_II
            End Get
            Set(value As String)
                _NUMERO_OP_II = value
            End Set
        End Property

        Public Property MOTIVO_ACT_NO_PROGRAMADA As String
            Get
                Return _MOTIVO_ACT_NO_PROGRAMADA
            End Get
            Set(value As String)
                _MOTIVO_ACT_NO_PROGRAMADA = value
            End Set
        End Property

        Public Property FECHA_TURNO As String
            Get
                Return _FECHA_TURNO
            End Get
            Set(value As String)
                _FECHA_TURNO = value
            End Set
        End Property
        Public Property TURNO As String
            Get
                Return _TURNO
            End Get
            Set(value As String)
                _TURNO = value
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
        Public Property EQUIPO_COD As String
            Get
                Return _EQUIPO_COD
            End Get
            Set(value As String)
                _EQUIPO_COD = value
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
        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
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
        Public Property NUMERO_OP As String
            Get
                Return _NUMERO_OP
            End Get
            Set(value As String)
                _NUMERO_OP = value
            End Set
        End Property
        Public Property USER_ID_REGISTRO As String
            Get
                Return _USER_ID_REGISTRO
            End Get
            Set(value As String)
                _USER_ID_REGISTRO = value
            End Set
        End Property
        Public Property PC_ID_REGISTRO As String
            Get
                Return _PC_ID_REGISTRO
            End Get
            Set(value As String)
                _PC_ID_REGISTRO = value
            End Set
        End Property
        Public Property NUMERO_OP_ID As Integer
            Get
                Return _NUMERO_OP_ID
            End Get
            Set(value As Integer)
                _NUMERO_OP_ID = value
            End Set
        End Property
        Public Property ITEM_OP_ID As Integer
            Get
                Return _ITEM_OP_ID
            End Get
            Set(value As Integer)
                _ITEM_OP_ID = value
            End Set
        End Property
    End Class

    Public Class MANTENIMIENTO_OP_PARTE_PRODUCCION

        Private _ID As Integer
        Private _ITEM As Integer
        Private _ITEM_DET As Integer
        Private _CONCEPTO As String
        Private _FECHA As String
        Private _HORA As String
        Private _OBSERVACIONES As String
        Private _USER_ID As String
        Private _PC_ID As String
        Private _TIEMPO_CIERRE As String
        Private _SIGNO As String
        Private _ESTADO As String

        Private _TURNO As String
        Private _FECHA_TURNO As String
        Private _MOTIVO_PAUSA As String
        Private _PLIEGOS_BUENOS As String
        Private _PLIEGOS_MALOS As String
        Public Property PLIEGOS_BUENOS As String
            Get
                Return _PLIEGOS_BUENOS
            End Get
            Set(value As String)
                _PLIEGOS_BUENOS = value
            End Set
        End Property
        Public Property PLIEGOS_MALOS As String
            Get
                Return _PLIEGOS_MALOS
            End Get
            Set(value As String)
                _PLIEGOS_MALOS = value
            End Set
        End Property

        Public Property MOTIVO_PAUSA As String
            Get
                Return _MOTIVO_PAUSA
            End Get
            Set(value As String)
                _MOTIVO_PAUSA = value
            End Set
        End Property

        Public Property FECHA_TURNO As String
            Get
                Return _FECHA_TURNO
            End Get
            Set(value As String)
                _FECHA_TURNO = value
            End Set
        End Property
        Public Property TURNO As String
            Get
                Return _TURNO
            End Get
            Set(value As String)
                _TURNO = value
            End Set
        End Property
        Public Property ESTADO As String
            Get
                Return _ESTADO
            End Get
            Set(value As String)
                _ESTADO = value
            End Set
        End Property

        Public Property TIEMPO_CIERRE As String
            Get
                Return _TIEMPO_CIERRE
            End Get
            Set(value As String)
                _TIEMPO_CIERRE = value
            End Set
        End Property
        Public Property SIGNO As String
            Get
                Return _SIGNO
            End Get
            Set(value As String)
                _SIGNO = value
            End Set
        End Property

        Public Property ID As Integer
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
        Public Property ITEM_DET As Integer
            Get
                Return _ITEM_DET
            End Get
            Set(value As Integer)
                _ITEM_DET = value
            End Set
        End Property
        Public Property CONCEPTO As String
            Get
                Return _CONCEPTO
            End Get
            Set(value As String)
                _CONCEPTO = value
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
        Public Property HORA As String
            Get
                Return _HORA
            End Get
            Set(value As String)
                _HORA = value
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

        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property
        Public Property PC_ID As String
            Get
                Return _PC_ID
            End Get
            Set(value As String)
                _PC_ID = value
            End Set
        End Property

    End Class
    Public Class MANTENIMIENTO_OP

        Private _ID As Integer
        Private _NUMERO_PRES As String
        Private _NUMERO_OP As String
        Private _USER_ID As String
        Private _PC_ID As String
        Private _ESTADO As String
        Private _VENTAS As String
        Private _PRE_PRENSA As String
        Private _LOGISTICA As String
        Private _IMPRESION As String
        Private _POST_PRENSA As String
        Private _DESPACHO As String
        Private _PRODUCTO As String
        Private _CANTIDAD As String
        Private _ITEM As String
        Private _ITEM_DETALLE As String
        Private _PRENSA_CORTE As String
        Private _FORMATO As String
        Private _ACABADOS_MANUALES As String

        Private _ESTADO_DESPACHO As String
        Private _FECHA_ANT_DESPACHO As String
        Private _FECHA_DESPACHO As String
        Private _CANTIDAD_DESPACHO As String
        Private _PUNTO_SALIDA_DESPACHO As String
        Private _OBSERVACIONES_DESPACHO As String
        Private _USER_ID_DESPACHO As String
        Private _ITEM_DESPACHO As Integer
        Private _ITEM_ANT_DESPACHO As Integer

        Private _HORA_INICIO_PRODUCCION As String
        Private _HORA_FINAL_PRODUCCION As String
        Private _PLIEGOS_BUENOS_PRODUCCION As String
        Private _PLIEGOS_MALOS_PRODUCCION As String
        Private _OBS_PRODUCCION As String

        Private _FECHA_ACEPTACION As String
        Private _FECHA_ENTREGA As String
        Private _TIEMPO_EJECUTADO As String
        Private _CIERRA_DESPACHO As String
        Private _HORA_ENTREGA_ACORDADO As String

        Private _ARCHIVO As Byte()
        Private _NOMBRE_ARCHIVO As String

        Private _RESPONSABLE As String
        Private _TROQUEL As String
        Private _COD_TROQUEL As String
        Private _REVISION_COLORES As String
        Private _MEDIDA_CERRADA As String
        Private _MEDIDA_ABIERTA As String
        Private _REVISION_NRO_PAGINAS As String
        Private _REVISION_ACABADOS As String
        Private _OBSERVACIONES As String
        Private _CONFORMIDAD_MATERIALES As String
        Private _ARTES As String
        Private _PLACAS As String
        Private _COD_EQUIPO As String
        Private _EMPRESA As String

        Public Property EMPRESA As String
            Get
                Return _EMPRESA
            End Get
            Set(value As String)
                _EMPRESA = value
            End Set
        End Property

        Public Property COD_EQUIPO As String
            Get
                Return _COD_EQUIPO
            End Get
            Set(value As String)
                _COD_EQUIPO = value
            End Set
        End Property

        Public Property ARTES As String
            Get
                Return _ARTES
            End Get
            Set(value As String)
                _ARTES = value
            End Set
        End Property
        Public Property PLACAS As String
            Get
                Return _PLACAS
            End Get
            Set(value As String)
                _PLACAS = value
            End Set
        End Property

        Public Property CONFORMIDAD_MATERIALES As String
            Get
                Return _CONFORMIDAD_MATERIALES
            End Get
            Set(value As String)
                _CONFORMIDAD_MATERIALES = value
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
        Public Property RESPONSABLE As String
            Get
                Return _RESPONSABLE
            End Get
            Set(value As String)
                _RESPONSABLE = value
            End Set
        End Property
        Public Property TROQUEL As String
            Get
                Return _TROQUEL
            End Get
            Set(value As String)
                _TROQUEL = value
            End Set
        End Property
        Public Property COD_TROQUEL As String
            Get
                Return _COD_TROQUEL
            End Get
            Set(value As String)
                _COD_TROQUEL = value
            End Set
        End Property
        Public Property REVISION_COLORES As String
            Get
                Return _REVISION_COLORES
            End Get
            Set(value As String)
                _REVISION_COLORES = value
            End Set
        End Property
        Public Property MEDIDA_CERRADA As String
            Get
                Return _MEDIDA_CERRADA
            End Get
            Set(value As String)
                _MEDIDA_CERRADA = value
            End Set
        End Property
        Public Property MEDIDA_ABIERTA As String
            Get
                Return _MEDIDA_ABIERTA
            End Get
            Set(value As String)
                _MEDIDA_ABIERTA = value
            End Set
        End Property
        Public Property REVISION_NRO_PAGINAS As String
            Get
                Return _REVISION_NRO_PAGINAS
            End Get
            Set(value As String)
                _REVISION_NRO_PAGINAS = value
            End Set
        End Property
        Public Property REVISION_ACABADOS As String
            Get
                Return _REVISION_ACABADOS
            End Get
            Set(value As String)
                _REVISION_ACABADOS = value
            End Set
        End Property

        Public Property ARCHIVO As Byte()
            Get
                Return _ARCHIVO
            End Get
            Set(value As Byte())
                _ARCHIVO = value
            End Set
        End Property
        Public Property NOMBRE_ARCHIVO As String
            Get
                Return _NOMBRE_ARCHIVO
            End Get
            Set(value As String)
                _NOMBRE_ARCHIVO = value
            End Set
        End Property
        Public Property HORA_ENTREGA_ACORDADO As String
            Get
                Return _HORA_ENTREGA_ACORDADO
            End Get
            Set(value As String)
                _HORA_ENTREGA_ACORDADO = value
            End Set
        End Property

        Public Property CIERRA_DESPACHO As String
            Get
                Return _CIERRA_DESPACHO
            End Get
            Set(value As String)
                _CIERRA_DESPACHO = value
            End Set
        End Property

        Public Property TIEMPO_EJECUTADO As String
            Get
                Return _TIEMPO_EJECUTADO
            End Get
            Set(value As String)
                _TIEMPO_EJECUTADO = value
            End Set
        End Property

        Public Property FECHA_ENTREGA As String
            Get
                Return _FECHA_ENTREGA
            End Get
            Set(value As String)
                _FECHA_ENTREGA = value
            End Set
        End Property
        Public Property FECHA_ACEPTACION As String
            Get
                Return _FECHA_ACEPTACION
            End Get
            Set(value As String)
                _FECHA_ACEPTACION = value
            End Set
        End Property

        Public Property HORA_INICIO_PRODUCCION As String
            Get
                Return _HORA_INICIO_PRODUCCION
            End Get
            Set(value As String)
                _HORA_INICIO_PRODUCCION = value
            End Set
        End Property
        Public Property HORA_FINAL_PRODUCCION As String
            Get
                Return _HORA_FINAL_PRODUCCION
            End Get
            Set(value As String)
                _HORA_FINAL_PRODUCCION = value
            End Set
        End Property
        Public Property PLIEGOS_BUENOS_PRODUCCION As String
            Get
                Return _PLIEGOS_BUENOS_PRODUCCION
            End Get
            Set(value As String)
                _PLIEGOS_BUENOS_PRODUCCION = value
            End Set
        End Property
        Public Property PLIEGOS_MALOS_PRODUCCION As String
            Get
                Return _PLIEGOS_MALOS_PRODUCCION
            End Get
            Set(value As String)
                _PLIEGOS_MALOS_PRODUCCION = value
            End Set
        End Property
        Public Property OBS_PRODUCCION As String
            Get
                Return _OBS_PRODUCCION
            End Get
            Set(value As String)
                _OBS_PRODUCCION = value
            End Set
        End Property

        Public Property ITEM_DESPACHO As Integer
            Get
                Return _ITEM_DESPACHO
            End Get
            Set(value As Integer)
                _ITEM_DESPACHO = value
            End Set
        End Property
        Public Property ITEM_ANT_DESPACHO As Integer
            Get
                Return _ITEM_ANT_DESPACHO
            End Get
            Set(value As Integer)
                _ITEM_ANT_DESPACHO = value
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
        Public Property FECHA_ANT_DESPACHO As String
            Get
                Return _FECHA_ANT_DESPACHO
            End Get
            Set(value As String)
                _FECHA_ANT_DESPACHO = value
            End Set
        End Property
        Public Property FECHA_DESPACHO As String
            Get
                Return _FECHA_DESPACHO
            End Get
            Set(value As String)
                _FECHA_DESPACHO = value
            End Set
        End Property
        Public Property CANTIDAD_DESPACHO As String
            Get
                Return _CANTIDAD_DESPACHO
            End Get
            Set(value As String)
                _CANTIDAD_DESPACHO = value
            End Set
        End Property
        Public Property PUNTO_SALIDA_DESPACHO As String
            Get
                Return _PUNTO_SALIDA_DESPACHO
            End Get
            Set(value As String)
                _PUNTO_SALIDA_DESPACHO = value
            End Set
        End Property
        Public Property OBSERVACIONES_DESPACHO As String
            Get
                Return _OBSERVACIONES_DESPACHO
            End Get
            Set(value As String)
                _OBSERVACIONES_DESPACHO = value
            End Set
        End Property
        Public Property USER_ID_DESPACHO As String
            Get
                Return _USER_ID_DESPACHO
            End Get
            Set(value As String)
                _USER_ID_DESPACHO = value
            End Set
        End Property

        Public Property ID As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
            End Set
        End Property
        Public Property NUMERO_PRES As String
            Get
                Return _NUMERO_PRES
            End Get
            Set(value As String)
                _NUMERO_PRES = value
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
        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property
        Public Property PC_ID As String
            Get
                Return _PC_ID
            End Get
            Set(value As String)
                _PC_ID = value
            End Set
        End Property
        Public Property ESTADO As String
            Get
                Return _ESTADO
            End Get
            Set(value As String)
                _ESTADO = value
            End Set
        End Property
        Public Property VENTAS As String
            Get
                Return _VENTAS
            End Get
            Set(value As String)
                _VENTAS = value
            End Set
        End Property
        Public Property PRE_PRENSA As String
            Get
                Return _PRE_PRENSA
            End Get
            Set(value As String)
                _PRE_PRENSA = value
            End Set
        End Property
        Public Property LOGISTICA As String
            Get
                Return _LOGISTICA
            End Get
            Set(value As String)
                _LOGISTICA = value
            End Set
        End Property
        Public Property IMPRESION As String
            Get
                Return _IMPRESION
            End Get
            Set(value As String)
                _IMPRESION = value
            End Set
        End Property
        Public Property POST_PRENSA As String
            Get
                Return _POST_PRENSA
            End Get
            Set(value As String)
                _POST_PRENSA = value
            End Set
        End Property
        Public Property DESPACHO As String
            Get
                Return _DESPACHO
            End Get
            Set(value As String)
                _DESPACHO = value
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
        Public Property CANTIDAD As String
            Get
                Return _CANTIDAD
            End Get
            Set(value As String)
                _CANTIDAD = value
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
        Public Property ITEM_DETALLE As String
            Get
                Return _ITEM_DETALLE
            End Get
            Set(value As String)
                _ITEM_DETALLE = value
            End Set
        End Property
        Public Property PRENSA_CORTE As String
            Get
                Return _PRENSA_CORTE
            End Get
            Set(value As String)
                _PRENSA_CORTE = value
            End Set
        End Property
        Public Property FORMATO As String
            Get
                Return _FORMATO
            End Get
            Set(value As String)
                _FORMATO = value
            End Set
        End Property
        Public Property ACABADOS_MANUALES As String
            Get
                Return _ACABADOS_MANUALES
            End Get
            Set(value As String)
                _ACABADOS_MANUALES = value
            End Set
        End Property


    End Class

    Public Class PL_ATTENDENCE_STAFF_BOLETAS_PAGO
        Private _NUMBER_DOCUMENT As Integer
        Private _DESCRIPCION As String
        Private _USER_ID As String
        Private _NOMBRE_PC As String
        Private _IP_PC As String
        Private _OPCION As Integer
        Private _MES As Integer
        Private _ANIO As Integer
        Private _FECHA As Date
        Private _TIPO As String

        Public Sub New()
            _NUMBER_DOCUMENT = 0
            _DESCRIPCION = String.Empty
            _USER_ID = String.Empty
            _NOMBRE_PC = String.Empty
            _IP_PC = String.Empty
            _OPCION = 0
            _MES = 0
            _ANIO = 0
            _FECHA = Date.Now
            _TIPO = String.Empty
        End Sub

        Public Property TIPO As String
            Get
                Return _TIPO
            End Get
            Set(value As String)
                _TIPO = value
            End Set
        End Property

        Public Property FECHA As Date
            Get
                Return _FECHA
            End Get
            Set(value As Date)
                _FECHA = value
            End Set
        End Property
        Public Property ANIO As Integer
            Get
                Return _ANIO
            End Get
            Set(value As Integer)
                _ANIO = value
            End Set
        End Property
        Public Property MES As Integer
            Get
                Return _MES
            End Get
            Set(value As Integer)
                _MES = value
            End Set
        End Property
        Public Property OPCION As Integer
            Get
                Return _OPCION
            End Get
            Set(value As Integer)
                _OPCION = value
            End Set
        End Property
        Public Property NUMBER_DOCUMENT As Integer
            Get
                Return _NUMBER_DOCUMENT
            End Get
            Set(value As Integer)
                _NUMBER_DOCUMENT = value
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
        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property
        Public Property NOMBRE_PC As String
            Get
                Return _NOMBRE_PC
            End Get
            Set(value As String)
                _NOMBRE_PC = value
            End Set
        End Property
        Public Property IP_PC As String
            Get
                Return _IP_PC
            End Get
            Set(value As String)
                _IP_PC = value
            End Set
        End Property

    End Class

    Public Class PL_ATTENDENCE_STAFF_BOLETAS_PAGO_DETALLE
        Private _ITEM As Integer
        Private _EMPLOYEE_ID As String
        Private _NOMBRES As String
        Private _APELLIDO_PATERNO As String
        Private _APELLIDO_MATERNO As String
        Private _EMAIL As String
        Private _STATUS_ENVIO_BOLETA As String
        Private _USER_ID As String
        Private _NOMBRE_PC As String
        Private _IP_PC As String

        Public Sub New()
            _ITEM = 0
            _EMPLOYEE_ID = String.Empty
            _NOMBRES = String.Empty
            _APELLIDO_PATERNO = String.Empty
            _APELLIDO_MATERNO = String.Empty
            _EMAIL = String.Empty
            _STATUS_ENVIO_BOLETA = String.Empty
            _USER_ID = String.Empty
            _NOMBRE_PC = String.Empty
            _IP_PC = String.Empty
        End Sub

        Public Property NOMBRES As String
            Get
                Return _NOMBRES
            End Get
            Set(value As String)
                _NOMBRES = value
            End Set
        End Property
        Public Property APELLIDO_PATERNO As String
            Get
                Return _APELLIDO_PATERNO
            End Get
            Set(value As String)
                _APELLIDO_PATERNO = value
            End Set
        End Property
        Public Property APELLIDO_MATERNO As String
            Get
                Return _APELLIDO_MATERNO
            End Get
            Set(value As String)
                _APELLIDO_MATERNO = value
            End Set
        End Property
        Public Property STATUS_ENVIO_BOLETA As String
            Get
                Return _STATUS_ENVIO_BOLETA
            End Get
            Set(value As String)
                _STATUS_ENVIO_BOLETA = value
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
        Public Property EMPLOYEE_ID As String
            Get
                Return _EMPLOYEE_ID
            End Get
            Set(value As String)
                _EMPLOYEE_ID = value
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
        Public Property NOMBRE_PC As String
            Get
                Return _NOMBRE_PC
            End Get
            Set(value As String)
                _NOMBRE_PC = value
            End Set
        End Property
        Public Property IP_PC As String
            Get
                Return _IP_PC
            End Get
            Set(value As String)
                _IP_PC = value
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
    Public Class REQUERIMIENTO_PRODUCCION_OP

        Private _ID As Integer
        Private _FECHA As String
        Private _STATUS As String
        Private _PART_ID As String
        Private _CANTIDAD As Double
        Private _FACTOR As Double
        Private _COSTO As Double
        Private _TOTAL As Double
        Private _USER_ID As String
        Private _COD_CLIENTE As String
        Private _OBSERVACIONES As String
        Private _NUMERO_PEDIDO As String
        Private _ITEM_PEDIDO As String

        Private _FECHA_ENTREGA As String
        Private _VENDEDOR As String
        Private _DESTINATARIO As String
        Private _URGENTE As String

        Public Property FECHA_ENTREGA As String
            Get
                Return _FECHA_ENTREGA
            End Get
            Set(value As String)
                _FECHA_ENTREGA = value
            End Set
        End Property
        Public Property VENDEDOR As String
            Get
                Return _VENDEDOR
            End Get
            Set(value As String)
                _VENDEDOR = value
            End Set
        End Property
        Public Property DESTINATARIO As String
            Get
                Return _DESTINATARIO
            End Get
            Set(value As String)
                _DESTINATARIO = value
            End Set
        End Property
        Public Property URGENTE As String
            Get
                Return _URGENTE
            End Get
            Set(value As String)
                _URGENTE = value
            End Set
        End Property

        Public Property NUMERO_PEDIDO As String
            Get
                Return _NUMERO_PEDIDO
            End Get
            Set(value As String)
                _NUMERO_PEDIDO = value
            End Set
        End Property
        Public Property ITEM_PEDIDO As String
            Get
                Return _ITEM_PEDIDO
            End Get
            Set(value As String)
                _ITEM_PEDIDO = value
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
        Public Property OBSERVACIONES As String
            Get
                Return _OBSERVACIONES
            End Get
            Set(value As String)
                _OBSERVACIONES = value
            End Set
        End Property

        Public Property ID As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
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
        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
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
        Public Property CANTIDAD As Double
            Get
                Return _CANTIDAD
            End Get
            Set(value As Double)
                _CANTIDAD = value
            End Set
        End Property
        Public Property FACTOR As Double
            Get
                Return _FACTOR
            End Get
            Set(value As Double)
                _FACTOR = value
            End Set
        End Property
        Public Property COSTO As Double
            Get
                Return _COSTO
            End Get
            Set(value As Double)
                _COSTO = value
            End Set
        End Property
        Public Property TOTAL As Double
            Get
                Return _TOTAL
            End Get
            Set(value As Double)
                _TOTAL = value
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

    End Class

    Public Class REQUERIMIENTO_PRODUCCION_OP_LINE

        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _CODIGO As String
        Private _COSTO As Double
        Private _CANTIDAD As Double
        Private _TOTAL As Double
        Private _DESTINATARIO As String
        Private _URGENTE As String

        Public Property DESTINATARIO As String
            Get
                Return _DESTINATARIO
            End Get
            Set(value As String)
                _DESTINATARIO = value
            End Set
        End Property
        Public Property URGENTE As String
            Get
                Return _URGENTE
            End Get
            Set(value As String)
                _URGENTE = value
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
        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
            End Set
        End Property
        Public Property COSTO As Double
            Get
                Return _COSTO
            End Get
            Set(value As Double)
                _COSTO = value
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
        Public Property TOTAL As Double
            Get
                Return _TOTAL
            End Get
            Set(value As Double)
                _TOTAL = value
            End Set
        End Property

    End Class

    Public Class PRODUCCION_OP

        Private _ID As Integer
        Private _FECHA As String
        Private _STATUS As String
        Private _PART_ID As String
        Private _CANTIDAD As Double
        Private _FACTOR As Double
        Private _COSTO As Double
        Private _TOTAL As Double
        Private _USER_ID As String
        Private _COD_CLIENTE As String
        Private _OBSERVACIONES As String
        Private _NUMERO_PEDIDO As String
        Private _ITEM_PEDIDO As String

        Private _FECHA_ENTREGA As String
        Private _VENDEDOR As String
        Private _DESTINATARIO As String
        Private _URGENTE As String

        Public Property FECHA_ENTREGA As String
            Get
                Return _FECHA_ENTREGA
            End Get
            Set(value As String)
                _FECHA_ENTREGA = value
            End Set
        End Property
        Public Property VENDEDOR As String
            Get
                Return _VENDEDOR
            End Get
            Set(value As String)
                _VENDEDOR = value
            End Set
        End Property
        Public Property DESTINATARIO As String
            Get
                Return _DESTINATARIO
            End Get
            Set(value As String)
                _DESTINATARIO = value
            End Set
        End Property
        Public Property URGENTE As String
            Get
                Return _URGENTE
            End Get
            Set(value As String)
                _URGENTE = value
            End Set
        End Property

        Public Property NUMERO_PEDIDO As String
            Get
                Return _NUMERO_PEDIDO
            End Get
            Set(value As String)
                _NUMERO_PEDIDO = value
            End Set
        End Property
        Public Property ITEM_PEDIDO As String
            Get
                Return _ITEM_PEDIDO
            End Get
            Set(value As String)
                _ITEM_PEDIDO = value
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
        Public Property OBSERVACIONES As String
            Get
                Return _OBSERVACIONES
            End Get
            Set(value As String)
                _OBSERVACIONES = value
            End Set
        End Property

        Public Property ID As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
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
        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
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
        Public Property CANTIDAD As Double
            Get
                Return _CANTIDAD
            End Get
            Set(value As Double)
                _CANTIDAD = value
            End Set
        End Property
        Public Property FACTOR As Double
            Get
                Return _FACTOR
            End Get
            Set(value As Double)
                _FACTOR = value
            End Set
        End Property
        Public Property COSTO As Double
            Get
                Return _COSTO
            End Get
            Set(value As Double)
                _COSTO = value
            End Set
        End Property
        Public Property TOTAL As Double
            Get
                Return _TOTAL
            End Get
            Set(value As Double)
                _TOTAL = value
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

    End Class

    Public Class PRODUCCION_OP_LINE

        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _CODIGO As String
        Private _COSTO As Double
        Private _CANTIDAD As Double
        Private _TOTAL As Double

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
        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
            End Set
        End Property
        Public Property COSTO As Double
            Get
                Return _COSTO
            End Get
            Set(value As Double)
                _COSTO = value
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
        Public Property TOTAL As Double
            Get
                Return _TOTAL
            End Get
            Set(value As Double)
                _TOTAL = value
            End Set
        End Property

    End Class

    Public Class CIERRE_MODULOS
        Private _ID_INTERNO As Integer
        Private _ANIO As Integer
        Private _MES As Integer
        Private _PROVEEDORES As String
        Private _ALMACENES As String
        Private _CLIENTES As String
        Private _CAJA_BANCOS As String
        Private _MANUFACTURA As String
        Private _CONTABILIDAD As String
        Private _RECURSOS_HUMANOS As String
        Private _ACTIVO_FIJO As String
        Private _CAJA_CHICA As String
        Private _USER_CREATE As String
        Private _PC_CREATE As String
        Private _USER_UPDATE As String
        Private _PC_UPDATE As String
        Public Sub New()
            _ID_INTERNO = 0
            _ANIO = 0
            _MES = 0
            _PROVEEDORES = String.Empty
            _ALMACENES = String.Empty
            _CLIENTES = String.Empty
            _CAJA_BANCOS = String.Empty
            _MANUFACTURA = String.Empty
            _CONTABILIDAD = String.Empty
            _RECURSOS_HUMANOS = String.Empty
            _ACTIVO_FIJO = String.Empty
            _CAJA_CHICA = String.Empty
            _USER_CREATE = String.Empty
            _PC_CREATE = String.Empty
            _USER_UPDATE = String.Empty
            _PC_UPDATE = String.Empty
        End Sub
        Public Property ID_INTERNO As Integer
            Get
                Return _ID_INTERNO
            End Get
            Set(value As Integer)
                _ID_INTERNO = value
            End Set
        End Property
        Public Property ANIO As Integer
            Get
                Return _ANIO
            End Get
            Set(value As Integer)
                _ANIO = value
            End Set
        End Property
        Public Property MES As Integer
            Get
                Return _MES
            End Get
            Set(value As Integer)
                _MES = value
            End Set
        End Property
        Public Property PROVEEDORES As String
            Get
                Return _PROVEEDORES
            End Get
            Set(value As String)
                _PROVEEDORES = value
            End Set
        End Property
        Public Property ALMACENES As String
            Get
                Return _ALMACENES
            End Get
            Set(value As String)
                _ALMACENES = value
            End Set
        End Property
        Public Property CLIENTES As String
            Get
                Return _CLIENTES
            End Get
            Set(value As String)
                _CLIENTES = value
            End Set
        End Property
        Public Property CAJA_BANCOS As String
            Get
                Return _CAJA_BANCOS
            End Get
            Set(value As String)
                _CAJA_BANCOS = value
            End Set
        End Property
        Public Property MANUFACTURA As String
            Get
                Return _MANUFACTURA
            End Get
            Set(value As String)
                _MANUFACTURA = value
            End Set
        End Property
        Public Property CONTABILIDAD As String
            Get
                Return _CONTABILIDAD
            End Get
            Set(value As String)
                _CONTABILIDAD = value
            End Set
        End Property
        Public Property RECURSOS_HUMANOS As String
            Get
                Return _RECURSOS_HUMANOS
            End Get
            Set(value As String)
                _RECURSOS_HUMANOS = value
            End Set
        End Property
        Public Property ACTIVO_FIJO As String
            Get
                Return _ACTIVO_FIJO
            End Get
            Set(value As String)
                _ACTIVO_FIJO = value
            End Set
        End Property
        Public Property CAJA_CHICA As String
            Get
                Return _CAJA_CHICA
            End Get
            Set(value As String)
                _CAJA_CHICA = value
            End Set
        End Property
        Public Property USER_CREATE As String
            Get
                Return _USER_CREATE
            End Get
            Set(value As String)
                _USER_CREATE = value
            End Set
        End Property
        Public Property PC_CREATE As String
            Get
                Return _PC_CREATE
            End Get
            Set(value As String)
                _PC_CREATE = value
            End Set
        End Property
        Public Property USER_UPDATE As String
            Get
                Return _USER_UPDATE
            End Get
            Set(value As String)
                _USER_UPDATE = value
            End Set
        End Property
        Public Property PC_UPDATE As String
            Get
                Return _PC_UPDATE
            End Get
            Set(value As String)
                _PC_UPDATE = value
            End Set
        End Property


    End Class

    Public Class ORDER_PRODUCTION

        Private _ID As String
        Private _WHO_ID As String
        Private _DOCUMENT_DATE As String
        Private _DATE_INIT As String
        Private _DATE_OUT As String
        Private _TURNO As String
        Private _DOCUMENT_REF As String
        Private _USER_ID As String
        Private _STATUS As String
        Private _COMMENT As String
        Private _COMPROMETIDO As String
        Private _MONEDA As String
        Private _QTY_PRODUCID As Double
        Private _LIQUID As String
        Private _VENCIMIENTO As String
        Private _LOTE As String
        Private _RS As String
        Private _VOLUMEN_LLENADO As String
        Private _TEXTO_COMPOSICION As String
        Private _FECHA_REGISTRO As String
        
        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
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

        Public Property DOCUMENT_DATE As String
            Get
                Return _DOCUMENT_DATE
            End Get
            Set(value As String)
                _DOCUMENT_DATE = value
            End Set
        End Property

        Public Property DATE_INIT As String
            Get
                Return _DATE_INIT
            End Get
            Set(value As String)
                _DATE_INIT = value
            End Set
        End Property

        Public Property DATE_OUT As String
            Get
                Return _DATE_OUT
            End Get
            Set(value As String)
                _DATE_OUT = value
            End Set
        End Property

        Public Property TURNO As String
            Get
                Return _TURNO
            End Get
            Set(value As String)
                _TURNO = value
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

        Public Property COMMENT As String
            Get
                Return _COMMENT
            End Get
            Set(value As String)
                _COMMENT = value
            End Set
        End Property

        Public Property COMPROMETIDO As String
            Get
                Return _COMPROMETIDO
            End Get
            Set(value As String)
                _COMPROMETIDO = value
            End Set
        End Property

        Public Property MONEDA As String
            Get
                Return _MONEDA
            End Get
            Set(value As String)
                _MONEDA = value
            End Set
        End Property

        Public Property LIQUID As String
            Get
                Return _LIQUID
            End Get
            Set(value As String)
                _LIQUID = value
            End Set
        End Property

        Public Property VENCIMIENTO As String
            Get
                Return _VENCIMIENTO
            End Get
            Set(value As String)
                _VENCIMIENTO = value
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

        Public Property RS As String
            Get
                Return _RS
            End Get
            Set(value As String)
                _RS = value
            End Set
        End Property

        Public Property VOLUMEN_LLENADO As String
            Get
                Return _VOLUMEN_LLENADO
            End Get
            Set(value As String)
                _VOLUMEN_LLENADO = value
            End Set
        End Property

        Public Property TEXTO_COMPOSICION As String
            Get
                Return _TEXTO_COMPOSICION
            End Get
            Set(value As String)
                _TEXTO_COMPOSICION = value
            End Set
        End Property

        Public Property FECHA_REGISTRO As String
            Get
                Return _FECHA_REGISTRO
            End Get
            Set(value As String)
                _FECHA_REGISTRO = value
            End Set
        End Property

        Public Property QTY_PRODUCID As Double
            Get
                Return _QTY_PRODUCID
            End Get
            Set(value As Double)
                _QTY_PRODUCID = value
            End Set
        End Property

    End Class

    Public Class ORDER_PRODUCTION_LINE
        Private _ID As String
        Private _WHO_ID As String
        Private _PART_ID As String
        Private _UNIT_PART As String
        Private _PART_FORM As String
        Private _DESCRIPTION_PART As String
        Private _DESCRIPTION_FORM As String
        Private _PART_FORM_EE As String
        Private _DESCRIPTION_FORM_EE As String
        Private _COMMENT As String
        Private _QTY As Double
        Private _NUMERO_PEDIDO As String
        Private _ITEM_PEDIDO As Integer

        Public Property ITEM_PEDIDO As Integer
            Get
                Return _ITEM_PEDIDO
            End Get
            Set(value As Integer)
                _ITEM_PEDIDO = value
            End Set
        End Property

        Public Property NUMERO_PEDIDO As String
            Get
                Return _NUMERO_PEDIDO
            End Get
            Set(value As String)
                _NUMERO_PEDIDO = value
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

        Public Property UNIT_PART As String
            Get
                Return _UNIT_PART
            End Get
            Set(value As String)
                _UNIT_PART = value
            End Set
        End Property

        Public Property PART_FORM As String
            Get
                Return _PART_FORM
            End Get
            Set(value As String)
                _PART_FORM = value
            End Set
        End Property

        Public Property DESCRIPTION_PART As String
            Get
                Return _DESCRIPTION_PART
            End Get
            Set(value As String)
                _DESCRIPTION_PART = value
            End Set
        End Property

        Public Property DESCRIPTION_FORM As String
            Get
                Return _DESCRIPTION_FORM
            End Get
            Set(value As String)
                _DESCRIPTION_FORM = value
            End Set
        End Property

        Public Property PART_FORM_EE As String
            Get
                Return _PART_FORM_EE
            End Get
            Set(value As String)
                _PART_FORM_EE = value
            End Set
        End Property

        Public Property DESCRIPTION_FORM_EE As String
            Get
                Return _DESCRIPTION_FORM_EE
            End Get
            Set(value As String)
                _DESCRIPTION_FORM_EE = value
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

    Public Class PL_PLANILLA
        Private _ID As Integer
        Private _CODIGO As String
        Private _TITULO As String
        Private _MES_ANIO As String
        Private _STATUS As String
        Private _USER_ID As String
        Private _PORCENTAJE_ADELANTO As Double

        Public Sub New()
            _ID = 0
            _CODIGO = String.Empty
            _TITULO = String.Empty
            _MES_ANIO = String.Empty
            _STATUS = String.Empty
            _USER_ID = String.Empty
            _PORCENTAJE_ADELANTO = 0.0
        End Sub
        Public Property PORCENTAJE_ADELANTO As Double
            Get
                Return _PORCENTAJE_ADELANTO
            End Get
            Set(value As Double)
                _PORCENTAJE_ADELANTO = value
            End Set
        End Property

        Public Property ID As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
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
        Public Property TITULO As String
            Get
                Return _TITULO
            End Get
            Set(value As String)
                _TITULO = value
            End Set
        End Property
        Public Property MES_ANIO As String
            Get
                Return _MES_ANIO
            End Get
            Set(value As String)
                _MES_ANIO = value
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

    End Class

    Public Class PL_ADELANTO_QUINCENA_LINE
        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _CODIGO As String
        Private _NUMERO_DOC As String
        Private _BASICO As Double
        Private _ASIGNACION_FAMILIAR As Double
        Private _MOVILIDAD As Double
        Private _TOTAL_INGRESOS As Double
        Private _MONTO_ADELANTO As Double


        Public Sub New()
            _ID_CAB = 0
            _ITEM = 0
            _CODIGO = String.Empty
            _NUMERO_DOC = String.Empty
            _BASICO = 0.0
            _ASIGNACION_FAMILIAR = 0.0
            _MOVILIDAD = 0.0
            _TOTAL_INGRESOS = 0.0
            _MONTO_ADELANTO = 0.0

        End Sub

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
        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
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
        Public Property BASICO As Double
            Get
                Return _BASICO
            End Get
            Set(value As Double)
                _BASICO = value
            End Set
        End Property
        Public Property ASIGNACION_FAMILIAR As Double
            Get
                Return _ASIGNACION_FAMILIAR
            End Get
            Set(value As Double)
                _ASIGNACION_FAMILIAR = value
            End Set
        End Property
        Public Property MOVILIDAD As Double
            Get
                Return _MOVILIDAD
            End Get
            Set(value As Double)
                _MOVILIDAD = value
            End Set
        End Property
        Public Property TOTAL_INGRESOS As Double
            Get
                Return _TOTAL_INGRESOS
            End Get
            Set(value As Double)
                _TOTAL_INGRESOS = value
            End Set
        End Property
        Public Property MONTO_ADELANTO As Double
            Get
                Return _MONTO_ADELANTO
            End Get
            Set(value As Double)
                _MONTO_ADELANTO = value
            End Set
        End Property

    End Class

    Public Class PL_CONCEPTOS_VARIABLES
        Private _ID As String
        Private _DESCRIPTION As String
        Private _TIPO As String
        Private _AFECTO_REM_ESSALUD As String
        Private _AFECTO_REM_AFP As String

        Private _CUENTA_ADM As String
        Private _CUENTA_VTA As String
        Private _CUENTA_PROD As String
        Private _DEBE_HABER As String

        Private _DETALLE_ANEXO As String
        Private _RUC_ANEXO As String
        Public Property DETALLE_ANEXO As String
            Get
                Return _DETALLE_ANEXO
            End Get
            Set(value As String)
                _DETALLE_ANEXO = value
            End Set
        End Property
        Public Property RUC_ANEXO As String
            Get
                Return _RUC_ANEXO
            End Get
            Set(value As String)
                _RUC_ANEXO = value
            End Set
        End Property

        Public Property CUENTA_ADM As String
            Get
                Return _CUENTA_ADM
            End Get
            Set(value As String)
                _CUENTA_ADM = value
            End Set
        End Property
        Public Property CUENTA_VTA As String
            Get
                Return _CUENTA_VTA
            End Get
            Set(value As String)
                _CUENTA_VTA = value
            End Set
        End Property
        Public Property CUENTA_PROD As String
            Get
                Return _CUENTA_PROD
            End Get
            Set(value As String)
                _CUENTA_PROD = value
            End Set
        End Property
        Public Property DEBE_HABER As String
            Get
                Return _DEBE_HABER
            End Get
            Set(value As String)
                _DEBE_HABER = value
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
        Public Property TIPO As String
            Get
                Return _TIPO
            End Get
            Set(value As String)
                _TIPO = value
            End Set
        End Property
        Public Property AFECTO_REM_ESSALUD As String
            Get
                Return _AFECTO_REM_ESSALUD
            End Get
            Set(value As String)
                _AFECTO_REM_ESSALUD = value
            End Set
        End Property
        Public Property AFECTO_REM_AFP As String
            Get
                Return _AFECTO_REM_AFP
            End Get
            Set(value As String)
                _AFECTO_REM_AFP = value
            End Set
        End Property
    End Class

    Public Class PL_ESTABLISHMENT
        Private _ID As String
        Private _DESCRIPTION As String
        Private _JORNADA_TRABAJO As Double

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

        Public Property JORNADA_TRABAJO As Double
            Get
                Return _JORNADA_TRABAJO
            End Get
            Set(value As Double)
                _JORNADA_TRABAJO = value
            End Set
        End Property
    End Class

    Public Class PL_AFP
        Private _ID As String
        Private _DESCRIPTION As String
        Private _RUC As String
        Private _APORTE_OBLIGATORIO As Double
        Private _COMISION_VARIABLE As Double
        Private _COMISION_MIXTA As Double
        Private _PRIMA_SEGURO As Double

        Public Property RUC As String
            Get
                Return _RUC
            End Get
            Set(value As String)
                _RUC = value
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
        Public Property APORTE_OBLIGATORIO As Double
            Get
                Return _APORTE_OBLIGATORIO
            End Get
            Set(value As Double)
                _APORTE_OBLIGATORIO = value
            End Set
        End Property
        Public Property COMISION_VARIABLE As Double
            Get
                Return _COMISION_VARIABLE
            End Get
            Set(value As Double)
                _COMISION_VARIABLE = value
            End Set
        End Property
        Public Property COMISION_MIXTA As Double
            Get
                Return _COMISION_MIXTA
            End Get
            Set(value As Double)
                _COMISION_MIXTA = value
            End Set
        End Property
        Public Property PRIMA_SEGURO As Double
            Get
                Return _PRIMA_SEGURO
            End Get
            Set(value As Double)
                _PRIMA_SEGURO = value
            End Set
        End Property
    End Class

    Public Class PL_PLANILLA_LINE_CONCEPTOS_VARIABLES
        Private _ID_CAB As Integer
        Private _CODIGO As String
        Private _NUMERO_DOC As String
        Private _ITEM As Integer
        Private _TIPO As String
        Private _COD_CONCEPTO As String
        Private _MONTO As Double

        Public Sub New()
            _ID_CAB = 0
            _CODIGO = String.Empty
            _NUMERO_DOC = String.Empty
            _ITEM = 0
            _TIPO = String.Empty
            _COD_CONCEPTO = String.Empty
            _MONTO = 0.0
        End Sub

        Public Property ID_CAB As Integer
            Get
                Return _ID_CAB
            End Get
            Set(value As Integer)
                _ID_CAB = value
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
        Public Property NUMERO_DOC As String
            Get
                Return _NUMERO_DOC
            End Get
            Set(value As String)
                _NUMERO_DOC = value
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
        Public Property TIPO As String
            Get
                Return _TIPO
            End Get
            Set(value As String)
                _TIPO = value
            End Set
        End Property
        Public Property COD_CONCEPTO As String
            Get
                Return _COD_CONCEPTO
            End Get
            Set(value As String)
                _COD_CONCEPTO = value
            End Set
        End Property
        Public Property MONTO As Double
            Get
                Return _MONTO
            End Get
            Set(value As Double)
                _MONTO = value
            End Set
        End Property

    End Class

    Public Class PL_PLANILLA_LINE
        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _CODIGO As String
        Private _NUMERO_DOC As String
        Private _BASICO As Double
        Private _FALTAS_D As Double
        Private _TARDANZAS_H As Double
        Private _TRABAJO_DESCANSO_DIAS As Double
        Private _DIAS_MES As Double
        Private _DOMINGOS_FERIADOS As Double
        Private _DIAS_EFECTIVOS As Double
        Private _HORAS_TRABAJADAS As Double
        Private _TOTAL_HORAS_NORMALES As Double
        Private _HR_EXT_25 As Double
        Private _HR_EXT_35 As Double
        Private _HR_EXT_100 As Double
        Private _TOTAL_HR_EXT As Double
        Private _INASISTENCIA As Double
        Private _TARDANZAS As Double
        Private _TRABAJO_DESCANSO As Double
        Private _REMUNERACION_BASICA_EFECTIVA As Double
        Private _ASIG_FAMILIAR As Double
        Private _COMISIONES As Double
        Private _REM_HR_EXT_25 As Double
        Private _REM_HR_EXT_35 As Double
        Private _REM_HR_EXT_100 As Double
        Private _TOTAL_REM_HR_EXT As Double
        Private _TOTAL_REMUNERACION As Double
        Private _REMUNERACION_AFECTA_ESSALUD As Double
        Private _REMUNERACION_AFECTA_AFP As Double
        Private _TOTAL_INGRESOS As Double
        Private _ESSALUD_VIDA_ASEG_PENSION As Double
        Private _ONP As Double
        Private _AFP_APORTE_OBLIGATORIO As Double
        Private _AFP_COMISION As Double
        Private _AFP_PRIMA_SEG As Double
        Private _TOTAL_AFP As Double
        Private _TOTAL_DESCUENTOS As Double
        Private _NETO_PAGAR As Double
        Private _ESSALUD As Double
        Private _SCTR_SALUD As Double
        Private _SCTR_PENSION As Double
        Private _SENATI As Double
        Private _TOTAL_APORTES As Double

        Private _AFP_ID As String
        Private _APORTE_OBLIGATORIO As Double
        Private _COMISION_VARIABLE As Double
        Private _COMISION_MIXTA As Double
        Private _PRIMA_SEGURO As Double
        Private _ADELANTO As Double
        Private _SUSPENSION_PERFECTA As Double

        Private _EPS As Double
        Private _EPS_POR As Double

        Public Sub New()
            _EPS = 0.0
            _EPS_POR = 0.0

            _SUSPENSION_PERFECTA = 0.0
            _AFP_ID = String.Empty
            _APORTE_OBLIGATORIO = 0
            _COMISION_VARIABLE = 0
            _COMISION_MIXTA = 0
            _PRIMA_SEGURO = 0
            _ADELANTO = 0

            _ID_CAB = 0
            _ITEM = 0
            _CODIGO = String.Empty
            _NUMERO_DOC = String.Empty
            _BASICO = 0.0
            _FALTAS_D = 0.0
            _TARDANZAS_H = 0.0
            _TRABAJO_DESCANSO_DIAS = 0.0
            _DIAS_MES = 0.0
            _DOMINGOS_FERIADOS = 0.0
            _DIAS_EFECTIVOS = 0.0
            _HORAS_TRABAJADAS = 0.0
            _TOTAL_HORAS_NORMALES = 0.0
            _HR_EXT_25 = 0.0
            _HR_EXT_35 = 0.0
            _HR_EXT_100 = 0.0
            _TOTAL_HR_EXT = 0.0
            _INASISTENCIA = 0.0
            _TARDANZAS = 0.0
            _TRABAJO_DESCANSO = 0.0
            _REMUNERACION_BASICA_EFECTIVA = 0.0
            _ASIG_FAMILIAR = 0.0
            _COMISIONES = 0.0
            _REM_HR_EXT_25 = 0.0
            _REM_HR_EXT_35 = 0.0
            _REM_HR_EXT_100 = 0.0
            _TOTAL_REM_HR_EXT = 0.0
            _TOTAL_REMUNERACION = 0.0
            _REMUNERACION_AFECTA_ESSALUD = 0.0
            _REMUNERACION_AFECTA_AFP = 0.0
            _TOTAL_INGRESOS = 0.0
            _ESSALUD_VIDA_ASEG_PENSION = 0.0
            _ONP = 0.0
            _AFP_APORTE_OBLIGATORIO = 0.0
            _AFP_COMISION = 0.0
            _AFP_PRIMA_SEG = 0.0
            _TOTAL_AFP = 0.0
            _TOTAL_DESCUENTOS = 0.0
            _NETO_PAGAR = 0.0
            _ESSALUD = 0.0
            _SCTR_SALUD = 0.0
            _SCTR_PENSION = 0.0
            _SENATI = 0.0
            _TOTAL_APORTES = 0.0
        End Sub
        Public Property EPS As Double
            Get
                Return _EPS
            End Get
            Set(value As Double)
                _EPS = value
            End Set
        End Property
        Public Property EPS_POR As Double
            Get
                Return _EPS_POR
            End Get
            Set(value As Double)
                _EPS_POR = value
            End Set
        End Property


        Public Property SUSPENSION_PERFECTA As Double
            Get
                Return _SUSPENSION_PERFECTA
            End Get
            Set(value As Double)
                _SUSPENSION_PERFECTA = value
            End Set
        End Property
        Public Property AFP_ID As String
            Get
                Return _AFP_ID
            End Get
            Set(value As String)
                _AFP_ID = value
            End Set
        End Property
        Public Property APORTE_OBLIGATORIO As Double
            Get
                Return _APORTE_OBLIGATORIO
            End Get
            Set(value As Double)
                _APORTE_OBLIGATORIO = value
            End Set
        End Property
        Public Property COMISION_VARIABLE As Double
            Get
                Return _COMISION_VARIABLE
            End Get
            Set(value As Double)
                _COMISION_VARIABLE = value
            End Set
        End Property
        Public Property COMISION_MIXTA As Double
            Get
                Return _COMISION_MIXTA
            End Get
            Set(value As Double)
                _COMISION_MIXTA = value
            End Set
        End Property
        Public Property PRIMA_SEGURO As Double
            Get
                Return _PRIMA_SEGURO
            End Get
            Set(value As Double)
                _PRIMA_SEGURO = value
            End Set
        End Property
        Public Property ADELANTO As Double
            Get
                Return _ADELANTO
            End Get
            Set(value As Double)
                _ADELANTO = value
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
        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
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
        Public Property BASICO As Double
            Get
                Return _BASICO
            End Get
            Set(value As Double)
                _BASICO = value
            End Set
        End Property
        Public Property FALTAS_D As Double
            Get
                Return _FALTAS_D
            End Get
            Set(value As Double)
                _FALTAS_D = value
            End Set
        End Property
        Public Property TRABAJO_DESCANSO_DIAS As Double
            Get
                Return _TRABAJO_DESCANSO_DIAS
            End Get
            Set(value As Double)
                _TRABAJO_DESCANSO_DIAS = value
            End Set
        End Property

        Public Property TRABAJO_DESCANSO As Double
            Get
                Return _TRABAJO_DESCANSO
            End Get
            Set(value As Double)
                _TRABAJO_DESCANSO = value
            End Set
        End Property
        Public Property TARDANZAS_H As Double
            Get
                Return _TARDANZAS_H
            End Get
            Set(value As Double)
                _TARDANZAS_H = value
            End Set
        End Property
        Public Property DIAS_MES As Double
            Get
                Return _DIAS_MES
            End Get
            Set(value As Double)
                _DIAS_MES = value
            End Set
        End Property
        Public Property DOMINGOS_FERIADOS As Double
            Get
                Return _DOMINGOS_FERIADOS
            End Get
            Set(value As Double)
                _DOMINGOS_FERIADOS = value
            End Set
        End Property
        Public Property DIAS_EFECTIVOS As Double
            Get
                Return _DIAS_EFECTIVOS
            End Get
            Set(value As Double)
                _DIAS_EFECTIVOS = value
            End Set
        End Property
        Public Property HORAS_TRABAJADAS As Double
            Get
                Return _HORAS_TRABAJADAS
            End Get
            Set(value As Double)
                _HORAS_TRABAJADAS = value
            End Set
        End Property
        Public Property TOTAL_HORAS_NORMALES As Double
            Get
                Return _TOTAL_HORAS_NORMALES
            End Get
            Set(value As Double)
                _TOTAL_HORAS_NORMALES = value
            End Set
        End Property
        Public Property HR_EXT_25 As Double
            Get
                Return _HR_EXT_25
            End Get
            Set(value As Double)
                _HR_EXT_25 = value
            End Set
        End Property
        Public Property HR_EXT_35 As Double
            Get
                Return _HR_EXT_35
            End Get
            Set(value As Double)
                _HR_EXT_35 = value
            End Set
        End Property
        Public Property HR_EXT_100 As Double
            Get
                Return _HR_EXT_100
            End Get
            Set(value As Double)
                _HR_EXT_100 = value
            End Set
        End Property
        Public Property TOTAL_HR_EXT As Double
            Get
                Return _TOTAL_HR_EXT
            End Get
            Set(value As Double)
                _TOTAL_HR_EXT = value
            End Set
        End Property
        Public Property INASISTENCIA As Double
            Get
                Return _INASISTENCIA
            End Get
            Set(value As Double)
                _INASISTENCIA = value
            End Set
        End Property
        Public Property TARDANZAS As Double
            Get
                Return _TARDANZAS
            End Get
            Set(value As Double)
                _TARDANZAS = value
            End Set
        End Property
        Public Property REMUNERACION_BASICA_EFECTIVA As Double
            Get
                Return _REMUNERACION_BASICA_EFECTIVA
            End Get
            Set(value As Double)
                _REMUNERACION_BASICA_EFECTIVA = value
            End Set
        End Property
        Public Property ASIG_FAMILIAR As Double
            Get
                Return _ASIG_FAMILIAR
            End Get
            Set(value As Double)
                _ASIG_FAMILIAR = value
            End Set
        End Property
        Public Property COMISIONES As Double
            Get
                Return _COMISIONES
            End Get
            Set(value As Double)
                _COMISIONES = value
            End Set
        End Property
        Public Property REM_HR_EXT_25 As Double
            Get
                Return _REM_HR_EXT_25
            End Get
            Set(value As Double)
                _REM_HR_EXT_25 = value
            End Set
        End Property
        Public Property REM_HR_EXT_35 As Double
            Get
                Return _REM_HR_EXT_35
            End Get
            Set(value As Double)
                _REM_HR_EXT_35 = value
            End Set
        End Property
        Public Property REM_HR_EXT_100 As Double
            Get
                Return _REM_HR_EXT_100
            End Get
            Set(value As Double)
                _REM_HR_EXT_100 = value
            End Set
        End Property
        Public Property TOTAL_REM_HR_EXT As Double
            Get
                Return _TOTAL_REM_HR_EXT
            End Get
            Set(value As Double)
                _TOTAL_REM_HR_EXT = value
            End Set
        End Property
        Public Property TOTAL_REMUNERACION As Double
            Get
                Return _TOTAL_REMUNERACION
            End Get
            Set(value As Double)
                _TOTAL_REMUNERACION = value
            End Set
        End Property
        Public Property REMUNERACION_AFECTA_ESSALUD As Double
            Get
                Return _REMUNERACION_AFECTA_ESSALUD
            End Get
            Set(value As Double)
                _REMUNERACION_AFECTA_ESSALUD = value
            End Set
        End Property
        Public Property REMUNERACION_AFECTA_AFP As Double
            Get
                Return _REMUNERACION_AFECTA_AFP
            End Get
            Set(value As Double)
                _REMUNERACION_AFECTA_AFP = value
            End Set
        End Property
        Public Property TOTAL_INGRESOS As Double
            Get
                Return _TOTAL_INGRESOS
            End Get
            Set(value As Double)
                _TOTAL_INGRESOS = value
            End Set
        End Property
        Public Property ESSALUD_VIDA_ASEG_PENSION As Double
            Get
                Return _ESSALUD_VIDA_ASEG_PENSION
            End Get
            Set(value As Double)
                _ESSALUD_VIDA_ASEG_PENSION = value
            End Set
        End Property
        Public Property ONP As Double
            Get
                Return _ONP
            End Get
            Set(value As Double)
                _ONP = value
            End Set
        End Property
        Public Property AFP_APORTE_OBLIGATORIO As Double
            Get
                Return _AFP_APORTE_OBLIGATORIO
            End Get
            Set(value As Double)
                _AFP_APORTE_OBLIGATORIO = value
            End Set
        End Property
        Public Property AFP_COMISION As Double
            Get
                Return _AFP_COMISION
            End Get
            Set(value As Double)
                _AFP_COMISION = value
            End Set
        End Property
        Public Property AFP_PRIMA_SEG As Double
            Get
                Return _AFP_PRIMA_SEG
            End Get
            Set(value As Double)
                _AFP_PRIMA_SEG = value
            End Set
        End Property
        Public Property TOTAL_AFP As Double
            Get
                Return _TOTAL_AFP
            End Get
            Set(value As Double)
                _TOTAL_AFP = value
            End Set
        End Property
        Public Property TOTAL_DESCUENTOS As Double
            Get
                Return _TOTAL_DESCUENTOS
            End Get
            Set(value As Double)
                _TOTAL_DESCUENTOS = value
            End Set
        End Property
        Public Property NETO_PAGAR As Double
            Get
                Return _NETO_PAGAR
            End Get
            Set(value As Double)
                _NETO_PAGAR = value
            End Set
        End Property
        Public Property ESSALUD As Double
            Get
                Return _ESSALUD
            End Get
            Set(value As Double)
                _ESSALUD = value
            End Set
        End Property
        Public Property SCTR_SALUD As Double
            Get
                Return _SCTR_SALUD
            End Get
            Set(value As Double)
                _SCTR_SALUD = value
            End Set
        End Property
        Public Property SCTR_PENSION As Double
            Get
                Return _SCTR_PENSION
            End Get
            Set(value As Double)
                _SCTR_PENSION = value
            End Set
        End Property
        Public Property SENATI As Double
            Get
                Return _SENATI
            End Get
            Set(value As Double)
                _SENATI = value
            End Set
        End Property
        Public Property TOTAL_APORTES As Double
            Get
                Return _TOTAL_APORTES
            End Get
            Set(value As Double)
                _TOTAL_APORTES = value
            End Set
        End Property

    End Class




    Public Class PL_EMPLOYEE
        Private _EMPLOYEE_ID As String
        Private _EMPLOYEE_FIRST_NAME As String
        Private _EMPLOYEE_SECOND_NAME As String
        Private _PATERNAL_LAST_NAME As String
        Private _MATERNAL_LAST_NAME As String
        Private _EMP_TYPE_DOCUMENT As String
        Private _EMP_NUMBER_DOC As String
        Private _EMP_TYPE_VIA As String
        Private _EMP_NAME_VIA As String
        Private _EMP_NUMBER_VIA As String
        Private _EMP_ZONA_TYPE As String
        Private _EMP_ZONA_NAME As String
        Private _EMP_ZONA_REFERENCE As String
        Private _EMP_UBIGEO As String
        Private _NATIONALITY_ID As String
        Private _EMP_PHONE As String
        Private _EMP_CEL As String
        Private _EMP_DATE_BIRTH As String
        Private _EMP_SEX As String
        Private _CIVIL_STATE_ID As String
        Private _EMAIL As String
        Private _USER_ID As String
        Private _STATUS As String
        Private _NATIONALITY_DESC As String

        Private _FECHA_INGRESO As String
        Private _ESTABLECIMIENTO As String
        Private _CARGO As String
        Private _AREA As String
        Private _FONDO_PENSIONES As String
        Private _CUSPP As String
        Private _COMISION_AFP As String
        Private _FECHA_INSCRIP_AFP As String
        Private _SENATI As String
        Private _SCTR As String
        Private _ASEG_PENSION As String
        Private _ESSALUD_VIDA As String
        Private _ASIG_FAMILIAR As String
        Private _AFECTO_QUINTA As String
        Private _REMUNERACION As Double
        Private _BANCO_REMUNERACION As String
        Private _MONEDA_REMUNERACION As String
        Private _NUM_CUENTA_REMUNERACION As String
        Private _BANCO_CTS As String
        Private _MONEDA_CTS As String
        Private _NUM_CUENTA_CTS As String
        Private _TIPO_PLANILLA As String
        Private _FECHA_CESE As String
        Private _EPS As Double
        Private _MOVILIDAD As Double
        Private _AFECTO_EPS As String
        Private _AFECTO_ESSALUD As String

        Public Sub New()
            _AFECTO_ESSALUD = String.Empty
            _MOVILIDAD = 0.0
            _AFECTO_EPS = String.Empty

            _FECHA_CESE = String.Empty
            _TIPO_PLANILLA = String.Empty
            _FECHA_INGRESO = String.Empty
            _ESTABLECIMIENTO = String.Empty
            _CARGO = String.Empty
            _AREA = String.Empty
            _FONDO_PENSIONES = String.Empty
            _CUSPP = String.Empty
            _COMISION_AFP = String.Empty
            _FECHA_INSCRIP_AFP = String.Empty
            _SENATI = String.Empty
            _SCTR = String.Empty
            _ASEG_PENSION = String.Empty
            _ESSALUD_VIDA = String.Empty
            _ASIG_FAMILIAR = String.Empty
            _AFECTO_QUINTA = String.Empty
            _REMUNERACION = 0.0
            _BANCO_REMUNERACION = String.Empty
            _MONEDA_REMUNERACION = String.Empty
            _NUM_CUENTA_REMUNERACION = String.Empty
            _BANCO_CTS = String.Empty
            _MONEDA_CTS = String.Empty
            _NUM_CUENTA_CTS = String.Empty

            _EMPLOYEE_ID = String.Empty
            _EMPLOYEE_FIRST_NAME = String.Empty
            _EMPLOYEE_SECOND_NAME = String.Empty
            _PATERNAL_LAST_NAME = String.Empty
            _MATERNAL_LAST_NAME = String.Empty
            _EMP_TYPE_DOCUMENT = String.Empty
            _EMP_NUMBER_DOC = String.Empty
            _EMP_TYPE_VIA = String.Empty
            _EMP_NAME_VIA = String.Empty
            _EMP_NUMBER_VIA = String.Empty
            _EMP_ZONA_TYPE = String.Empty
            _EMP_ZONA_NAME = String.Empty
            _EMP_ZONA_REFERENCE = String.Empty
            _EMP_UBIGEO = String.Empty
            _NATIONALITY_ID = String.Empty
            _NATIONALITY_DESC = String.Empty
            _EMP_PHONE = String.Empty
            _EMP_CEL = String.Empty
            _EMP_DATE_BIRTH = String.Empty
            _EMP_SEX = String.Empty
            _CIVIL_STATE_ID = String.Empty
            _EMAIL = String.Empty
            _USER_ID = String.Empty
            _STATUS = String.Empty
            _EPS = 0.0
        End Sub
        Public Property AFECTO_ESSALUD As String
            Get
                Return _AFECTO_ESSALUD
            End Get
            Set(value As String)
                _AFECTO_ESSALUD = value
            End Set
        End Property
        Public Property MOVILIDAD As Double
            Get
                Return _MOVILIDAD
            End Get
            Set(value As Double)
                _MOVILIDAD = value
            End Set
        End Property
        Public Property AFECTO_EPS As String
            Get
                Return _AFECTO_EPS
            End Get
            Set(value As String)
                _AFECTO_EPS = value
            End Set
        End Property


        Public Property EPS As Double
            Get
                Return _EPS
            End Get
            Set(value As Double)
                _EPS = value
            End Set
        End Property
        Public Property FECHA_CESE As String
            Get
                Return _FECHA_CESE
            End Get
            Set(value As String)
                _FECHA_CESE = value
            End Set
        End Property
        Public Property TIPO_PLANILLA As String
            Get
                Return _TIPO_PLANILLA
            End Get
            Set(value As String)
                _TIPO_PLANILLA = value
            End Set
        End Property
        Public Property FECHA_INGRESO As String
            Get
                Return _FECHA_INGRESO
            End Get
            Set(value As String)
                _FECHA_INGRESO = value
            End Set
        End Property
        Public Property ESTABLECIMIENTO As String
            Get
                Return _ESTABLECIMIENTO
            End Get
            Set(value As String)
                _ESTABLECIMIENTO = value
            End Set
        End Property
        Public Property CARGO As String
            Get
                Return _CARGO
            End Get
            Set(value As String)
                _CARGO = value
            End Set
        End Property
        Public Property AREA As String
            Get
                Return _AREA
            End Get
            Set(value As String)
                _AREA = value
            End Set
        End Property
        Public Property FONDO_PENSIONES As String
            Get
                Return _FONDO_PENSIONES
            End Get
            Set(value As String)
                _FONDO_PENSIONES = value
            End Set
        End Property
        Public Property CUSPP As String
            Get
                Return _CUSPP
            End Get
            Set(value As String)
                _CUSPP = value
            End Set
        End Property
        Public Property COMISION_AFP As String
            Get
                Return _COMISION_AFP
            End Get
            Set(value As String)
                _COMISION_AFP = value
            End Set
        End Property
        Public Property FECHA_INSCRIP_AFP As String
            Get
                Return _FECHA_INSCRIP_AFP
            End Get
            Set(value As String)
                _FECHA_INSCRIP_AFP = value
            End Set
        End Property
        Public Property SENATI As String
            Get
                Return _SENATI
            End Get
            Set(value As String)
                _SENATI = value
            End Set
        End Property
        Public Property SCTR As String
            Get
                Return _SCTR
            End Get
            Set(value As String)
                _SCTR = value
            End Set
        End Property
        Public Property ASEG_PENSION As String
            Get
                Return _ASEG_PENSION
            End Get
            Set(value As String)
                _ASEG_PENSION = value
            End Set
        End Property
        Public Property ESSALUD_VIDA As String
            Get
                Return _ESSALUD_VIDA
            End Get
            Set(value As String)
                _ESSALUD_VIDA = value
            End Set
        End Property
        Public Property ASIG_FAMILIAR As String
            Get
                Return _ASIG_FAMILIAR
            End Get
            Set(value As String)
                _ASIG_FAMILIAR = value
            End Set
        End Property
        Public Property AFECTO_QUINTA As String
            Get
                Return _AFECTO_QUINTA
            End Get
            Set(value As String)
                _AFECTO_QUINTA = value
            End Set
        End Property
        Public Property REMUNERACION As Double
            Get
                Return _REMUNERACION
            End Get
            Set(value As Double)
                _REMUNERACION = value
            End Set
        End Property
        Public Property BANCO_REMUNERACION As String
            Get
                Return _BANCO_REMUNERACION
            End Get
            Set(value As String)
                _BANCO_REMUNERACION = value
            End Set
        End Property
        Public Property MONEDA_REMUNERACION As String
            Get
                Return _MONEDA_REMUNERACION
            End Get
            Set(value As String)
                _MONEDA_REMUNERACION = value
            End Set
        End Property
        Public Property NUM_CUENTA_REMUNERACION As String
            Get
                Return _NUM_CUENTA_REMUNERACION
            End Get
            Set(value As String)
                _NUM_CUENTA_REMUNERACION = value
            End Set
        End Property
        Public Property BANCO_CTS As String
            Get
                Return _BANCO_CTS
            End Get
            Set(value As String)
                _BANCO_CTS = value
            End Set
        End Property
        Public Property MONEDA_CTS As String
            Get
                Return _MONEDA_CTS
            End Get
            Set(value As String)
                _MONEDA_CTS = value
            End Set
        End Property
        Public Property NUM_CUENTA_CTS As String
            Get
                Return _NUM_CUENTA_CTS
            End Get
            Set(value As String)
                _NUM_CUENTA_CTS = value
            End Set
        End Property

        Public Property NATIONALITY_DESC As String
            Get
                Return _NATIONALITY_DESC
            End Get
            Set(value As String)
                _NATIONALITY_DESC = value
            End Set
        End Property

        Public Property EMPLOYEE_ID As String
            Get
                Return _EMPLOYEE_ID
            End Get
            Set(value As String)
                _EMPLOYEE_ID = value
            End Set
        End Property
        Public Property EMPLOYEE_FIRST_NAME As String
            Get
                Return _EMPLOYEE_FIRST_NAME
            End Get
            Set(value As String)
                _EMPLOYEE_FIRST_NAME = value
            End Set
        End Property
        Public Property EMPLOYEE_SECOND_NAME As String
            Get
                Return _EMPLOYEE_SECOND_NAME
            End Get
            Set(value As String)
                _EMPLOYEE_SECOND_NAME = value
            End Set
        End Property
        Public Property PATERNAL_LAST_NAME As String
            Get
                Return _PATERNAL_LAST_NAME
            End Get
            Set(value As String)
                _PATERNAL_LAST_NAME = value
            End Set
        End Property
        Public Property MATERNAL_LAST_NAME As String
            Get
                Return _MATERNAL_LAST_NAME
            End Get
            Set(value As String)
                _MATERNAL_LAST_NAME = value
            End Set
        End Property
        Public Property EMP_TYPE_DOCUMENT As String
            Get
                Return _EMP_TYPE_DOCUMENT
            End Get
            Set(value As String)
                _EMP_TYPE_DOCUMENT = value
            End Set
        End Property
        Public Property EMP_NUMBER_DOC As String
            Get
                Return _EMP_NUMBER_DOC
            End Get
            Set(value As String)
                _EMP_NUMBER_DOC = value
            End Set
        End Property
        Public Property EMP_TYPE_VIA As String
            Get
                Return _EMP_TYPE_VIA
            End Get
            Set(value As String)
                _EMP_TYPE_VIA = value
            End Set
        End Property
        Public Property EMP_NAME_VIA As String
            Get
                Return _EMP_NAME_VIA
            End Get
            Set(value As String)
                _EMP_NAME_VIA = value
            End Set
        End Property
        Public Property EMP_NUMBER_VIA As String
            Get
                Return _EMP_NUMBER_VIA
            End Get
            Set(value As String)
                _EMP_NUMBER_VIA = value
            End Set
        End Property
        Public Property EMP_ZONA_TYPE As String
            Get
                Return _EMP_ZONA_TYPE
            End Get
            Set(value As String)
                _EMP_ZONA_TYPE = value
            End Set
        End Property
        Public Property EMP_ZONA_NAME As String
            Get
                Return _EMP_ZONA_NAME
            End Get
            Set(value As String)
                _EMP_ZONA_NAME = value
            End Set
        End Property
        Public Property EMP_ZONA_REFERENCE As String
            Get
                Return _EMP_ZONA_REFERENCE
            End Get
            Set(value As String)
                _EMP_ZONA_REFERENCE = value
            End Set
        End Property
        Public Property EMP_UBIGEO As String
            Get
                Return _EMP_UBIGEO
            End Get
            Set(value As String)
                _EMP_UBIGEO = value
            End Set
        End Property
        Public Property NATIONALITY_ID As String
            Get
                Return _NATIONALITY_ID
            End Get
            Set(value As String)
                _NATIONALITY_ID = value
            End Set
        End Property
        Public Property EMP_PHONE As String
            Get
                Return _EMP_PHONE
            End Get
            Set(value As String)
                _EMP_PHONE = value
            End Set
        End Property
        Public Property EMP_CEL As String
            Get
                Return _EMP_CEL
            End Get
            Set(value As String)
                _EMP_CEL = value
            End Set
        End Property
        Public Property EMP_DATE_BIRTH As String
            Get
                Return _EMP_DATE_BIRTH
            End Get
            Set(value As String)
                _EMP_DATE_BIRTH = value
            End Set
        End Property
        Public Property EMP_SEX As String
            Get
                Return _EMP_SEX
            End Get
            Set(value As String)
                _EMP_SEX = value
            End Set
        End Property
        Public Property CIVIL_STATE_ID As String
            Get
                Return _CIVIL_STATE_ID
            End Get
            Set(value As String)
                _CIVIL_STATE_ID = value
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
    End Class

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

    Public Class ADDR_CUSTOMER
        Private _ADDR As String
        Private _DEPARTAMENTO As String
        Private _PROVINCIA As String
        Private _DISTRITO As String
        Private _IS_DEFAULT As Boolean

        Public Sub New()
            _ADDR = String.Empty
            _DEPARTAMENTO = String.Empty
            _PROVINCIA = String.Empty
            _DISTRITO = String.Empty
            _IS_DEFAULT = False
        End Sub
        Public Property ADDR As String
            Get
                Return _ADDR
            End Get
            Set(value As String)
                _ADDR = value
            End Set
        End Property

        Public Property DEPARTAMENTO As String
            Get
                Return _DEPARTAMENTO
            End Get
            Set(value As String)
                _DEPARTAMENTO = value
            End Set
        End Property

        Public Property PROVINCIA As String
            Get
                Return _PROVINCIA
            End Get
            Set(value As String)
                _PROVINCIA = value
            End Set
        End Property
        Public Property DISTRITO As String
            Get
                Return _DISTRITO
            End Get
            Set(value As String)
                _DISTRITO = value
            End Set
        End Property

        Public Property IS_DEFAULT As Boolean
            Get
                Return _IS_DEFAULT
            End Get
            Set(value As Boolean)
                _IS_DEFAULT = value
            End Set
        End Property



    End Class

    Public Class RECEIVABLE_RESUMEN_BOLETAS
        Private _ID As Integer
        Private _FECHA_RESUMEN As String
        Private _CODIGO_RESUMEN As String
        Private _CODIGO_RESUMEN_BOLETAS As String
        Private _FECHA_DOCUMENTOS As String
        Private _NUMERO_TICKET As String
        Private _USER_ID As String
        Private _PC_ID As String

        Public Sub New()
            _ID = 0
            _FECHA_RESUMEN = String.Empty
            _CODIGO_RESUMEN = String.Empty
            _CODIGO_RESUMEN_BOLETAS = String.Empty
            _FECHA_DOCUMENTOS = String.Empty
            _NUMERO_TICKET = String.Empty
            _USER_ID = String.Empty
            _PC_ID = String.Empty
        End Sub

        Public Property ID As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
            End Set
        End Property
        Public Property FECHA_RESUMEN As String
            Get
                Return _FECHA_RESUMEN
            End Get
            Set(value As String)
                _FECHA_RESUMEN = value
            End Set
        End Property
        Public Property CODIGO_RESUMEN As String
            Get
                Return _CODIGO_RESUMEN
            End Get
            Set(value As String)
                _CODIGO_RESUMEN = value
            End Set
        End Property
        Public Property CODIGO_RESUMEN_BOLETAS As String
            Get
                Return _CODIGO_RESUMEN_BOLETAS
            End Get
            Set(value As String)
                _CODIGO_RESUMEN_BOLETAS = value
            End Set
        End Property
        Public Property FECHA_DOCUMENTOS As String
            Get
                Return _FECHA_DOCUMENTOS
            End Get
            Set(value As String)
                _FECHA_DOCUMENTOS = value
            End Set
        End Property
        Public Property NUMERO_TICKET As String
            Get
                Return _NUMERO_TICKET
            End Get
            Set(value As String)
                _NUMERO_TICKET = value
            End Set
        End Property
        Public Property PC_ID As String
            Get
                Return _PC_ID
            End Get
            Set(value As String)
                _PC_ID = value
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
    End Class

    Public Class RECEIVABLE_RESUMEN_BOLETAS_LINE
        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _TIPO_DOC As String
        Private _SERIE_DOC As String
        Private _NUMERO_DOC As String
        Private _OPE_GRABADAS As Double
        Private _OPE_INAFECTAS As Double
        Private _OPE_EXONERADAS As Double
        Private _OPE_IGV As Double
        Private _OPE_TOTAL As Double

        Public Sub New()
            _ID_CAB = 0
            _ITEM = 0
            _TIPO_DOC = String.Empty
            _SERIE_DOC = String.Empty
            _NUMERO_DOC = String.Empty
            _OPE_GRABADAS = 0.0
            _OPE_INAFECTAS = 0.0
            _OPE_EXONERADAS = 0.0
            _OPE_IGV = 0.0
            _OPE_TOTAL = 0.0
        End Sub

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
        Public Property OPE_GRABADAS As Double
            Get
                Return _OPE_GRABADAS
            End Get
            Set(value As Double)
                _OPE_GRABADAS = value
            End Set
        End Property
        Public Property OPE_INAFECTAS As Double
            Get
                Return _OPE_INAFECTAS
            End Get
            Set(value As Double)
                _OPE_INAFECTAS = value
            End Set
        End Property
        Public Property OPE_EXONERADAS As Double
            Get
                Return _OPE_EXONERADAS
            End Get
            Set(value As Double)
                _OPE_EXONERADAS = value
            End Set
        End Property
        Public Property OPE_IGV As Double
            Get
                Return _OPE_IGV
            End Get
            Set(value As Double)
                _OPE_IGV = value
            End Set
        End Property
        Public Property OPE_TOTAL As Double
            Get
                Return _OPE_TOTAL
            End Get
            Set(value As Double)
                _OPE_TOTAL = value
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
        Private _LAST_NAME_CARRIER As String
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

        Public Property LAST_NAME_CARRIER As String
            Get
                Return _LAST_NAME_CARRIER
            End Get
            Set(value As String)
                _LAST_NAME_CARRIER = value
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
        Private _TERMINAL As String
        Private _COMMENT As String
        Private _STATUS As String
        Private _CONDITION As Integer
        Private _ORDER_ID As Integer

        Public Property TERMINAL As String
            Get
                Return _TERMINAL
            End Get
            Set(value As String)
                _TERMINAL = value
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
        Private _DIRECCION_ENTREGA As String
        Private _CUSTOMER_ADDR_DLV As String
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
        Private _ID_CENTRO_COSTO As String
        Private _CREATE_DATE As Date
        Private _SELL_RATE As Double
        Private _AMOUNT_VAT As Double
        Private _DISCOUNT As Double
        Private _DISCOUNT_AMOUNT As Double
        Private _DISCOUNT_VAL As Double
        Private _AMOUNT_ISC As Double
        Private _VALIDEZ_OFERTA As String

        Private _PROVINCIA As String
        Private _AGENCIA_TRANSPORTE As String
        Private _GUIA As String
        Private _AGE_DOMI As String
        Private _LT_FT As String
        Private _CHEQUE As String
        Private _TRANSFERENCIA As String
        Private _N_OPERACION As String
        Private _OBS_GENERAL As String
        Private _RECEPCION_TERCERO As String
        Private _MODO_PAGO As String
        Private _GUIA_2 As String
        Private _FACTURA_2 As String
        Private _LETRA_2 As String
        Private _OPT_A_D As String

        Private _TRANSFERENCIA_2 As String
        Private _EFECTIVO_2 As String
        Private _NUM_COTIZACION As String
        Private _NUM_DIAS As Integer
        Private _ITEM_TRANSPORTE As String
        Private _PLACE_DELIVERY As String

        Private _CONTACTO_NOMBRES As String

        Private _TIPO_PEDIDO As String
        Private _CONTACTO_DNI As String
        Private _CONTACTO_CELULAR As String

        Private _FECHA_ENTREGA As Date
        Private _FECHA_RECEPCION As Date
        Private _HORA_RECEPCION As String

        Public Property DIRECCION_ENTREGA As String
            Get
                Return _DIRECCION_ENTREGA
            End Get
            Set(value As String)
                _DIRECCION_ENTREGA = value
            End Set
        End Property

        Public Property TIPO_PEDIDO As String
            Get
                Return _TIPO_PEDIDO
            End Get
            Set(value As String)
                _TIPO_PEDIDO = value
            End Set
        End Property
        Public Property CONTACTO_NOMBRES As String
            Get
                Return _CONTACTO_NOMBRES
            End Get
            Set(value As String)
                _CONTACTO_NOMBRES = value
            End Set
        End Property
        Public Property CONTACTO_DNI As String
            Get
                Return _CONTACTO_DNI
            End Get
            Set(value As String)
                _CONTACTO_DNI = value
            End Set
        End Property
        Public Property CONTACTO_CELULAR As String
            Get
                Return _CONTACTO_CELULAR
            End Get
            Set(value As String)
                _CONTACTO_CELULAR = value
            End Set
        End Property
        Public Property PLACE_DELIVERY As String
            Get
                Return _PLACE_DELIVERY
            End Get
            Set(value As String)
                _PLACE_DELIVERY = value
            End Set
        End Property
        Public Property ITEM_TRANSPORTE As String
            Get
                Return _ITEM_TRANSPORTE
            End Get
            Set(value As String)
                _ITEM_TRANSPORTE = value
            End Set
        End Property
        Public Property NUM_DIAS As Integer
            Get
                Return _NUM_DIAS
            End Get
            Set(value As Integer)
                _NUM_DIAS = value
            End Set
        End Property
        Public Property NUM_COTIZACION As String
            Get
                Return _NUM_COTIZACION
            End Get
            Set(value As String)
                _NUM_COTIZACION = value
            End Set
        End Property
        Public Property TRANSFERENCIA_2 As String
            Get
                Return _TRANSFERENCIA_2
            End Get
            Set(value As String)
                _TRANSFERENCIA_2 = value
            End Set
        End Property
        Public Property EFECTIVO_2 As String
            Get
                Return _EFECTIVO_2
            End Get
            Set(value As String)
                _EFECTIVO_2 = value
            End Set
        End Property
        Private _ARCHIVO As Byte()

        Public Property FECHA_ENTREGA As Date
            Get
                Return _FECHA_ENTREGA
            End Get
            Set(value As Date)
                _FECHA_ENTREGA = value
            End Set
        End Property
        Public Property FECHA_RECEPCION As Date
            Get
                Return _FECHA_RECEPCION
            End Get
            Set(value As Date)
                _FECHA_RECEPCION = value
            End Set
        End Property
        Public Property HORA_RECEPCION As String
            Get
                Return _HORA_RECEPCION
            End Get
            Set(value As String)
                _HORA_RECEPCION = value
            End Set
        End Property

        Public Property OPT_A_D As String
            Get
                Return _OPT_A_D
            End Get
            Set(value As String)
                _OPT_A_D = value
            End Set
        End Property

        Public Property GUIA_2 As String
            Get
                Return _GUIA_2
            End Get
            Set(value As String)
                _GUIA_2 = value
            End Set
        End Property
        Public Property FACTURA_2 As String
            Get
                Return _FACTURA_2
            End Get
            Set(value As String)
                _FACTURA_2 = value
            End Set
        End Property
        Public Property LETRA_2 As String
            Get
                Return _LETRA_2
            End Get
            Set(value As String)
                _LETRA_2 = value
            End Set
        End Property

        Public Property MODO_PAGO As String
            Get
                Return _MODO_PAGO
            End Get
            Set(value As String)
                _MODO_PAGO = value
            End Set
        End Property
        Public Property PROVINCIA As String
            Get
                Return _PROVINCIA
            End Get
            Set(value As String)
                _PROVINCIA = value
            End Set
        End Property
        Public Property AGENCIA_TRANSPORTE As String
            Get
                Return _AGENCIA_TRANSPORTE
            End Get
            Set(value As String)
                _AGENCIA_TRANSPORTE = value
            End Set
        End Property
        Public Property GUIA As String
            Get
                Return _GUIA
            End Get
            Set(value As String)
                _GUIA = value
            End Set
        End Property
        Public Property AGE_DOMI As String
            Get
                Return _AGE_DOMI
            End Get
            Set(value As String)
                _AGE_DOMI = value
            End Set
        End Property
        Public Property LT_FT As String
            Get
                Return _LT_FT
            End Get
            Set(value As String)
                _LT_FT = value
            End Set
        End Property
        Public Property CHEQUE As String
            Get
                Return _CHEQUE
            End Get
            Set(value As String)
                _CHEQUE = value
            End Set
        End Property
        Public Property TRANSFERENCIA As String
            Get
                Return _TRANSFERENCIA
            End Get
            Set(value As String)
                _TRANSFERENCIA = value
            End Set
        End Property
        Public Property N_OPERACION As String
            Get
                Return _N_OPERACION
            End Get
            Set(value As String)
                _N_OPERACION = value
            End Set
        End Property
        Public Property OBS_GENERAL As String
            Get
                Return _OBS_GENERAL
            End Get
            Set(value As String)
                _OBS_GENERAL = value
            End Set
        End Property
        Public Property RECEPCION_TERCERO As String
            Get
                Return _RECEPCION_TERCERO
            End Get
            Set(value As String)
                _RECEPCION_TERCERO = value
            End Set
        End Property

        Public Property VALIDEZ_OFERTA As String
            Get
                Return _VALIDEZ_OFERTA
            End Get
            Set(value As String)
                _VALIDEZ_OFERTA = value
            End Set
        End Property
        Public Property ID_CENTRO_COSTO As String
            Get
                Return _ID_CENTRO_COSTO
            End Get
            Set(value As String)
                _ID_CENTRO_COSTO = value
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

        Public Property CUSTOMER_ADDR_DLV As String
            Get
                Return _CUSTOMER_ADDR_DLV
            End Get
            Set(value As String)
                _CUSTOMER_ADDR_DLV = value
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
        Public Property ARCHIVO As Byte()
            Get
                Return _ARCHIVO
            End Get
            Set(value As Byte())
                _ARCHIVO = value
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
        Private _ID_CENTRO_COSTO As String
        Private _LOT As String
        Private _LIST_ID As String
        Private _UNIT As String
        Private _QTY As Double
        Private _CANTIDAD_HABILITADO As Double
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

        Public Property ID_CENTRO_COSTO As String
            Get
                Return _ID_CENTRO_COSTO
            End Get
            Set(value As String)
                _ID_CENTRO_COSTO = value
            End Set
        End Property

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

        Public Property CANTIDAD_HABILITADO As Double
            Get
                Return _CANTIDAD_HABILITADO
            End Get
            Set(value As Double)
                _CANTIDAD_HABILITADO = value
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



    'Public Class PURCHASE_ORDER

    '    Private _ID As String
    '    Private _TYPE As String
    '    Private _DOCUMENT_DATE As Date
    '    Private _VENDOR_ID As String
    '    Private _NUMBER_ESTIMATING As String
    '    Private _CURRENCY_TYPE As String
    '    Private _TERMS_NAME As String
    '    Private _SELL_RATE As Decimal
    '    Private _PROMISE_DATE As Date
    '    Private _COMMENT As String
    '    Private _AUTORIZED_ID As String
    '    Private _BUYER_PURCHASE_ID As String
    '    Private _TIME_DLV As String
    '    Private _ADDR_DLV As String
    '    Private _STATUS_ID As String
    '    Private _AMOUNT As Decimal
    '    Private _DISCOUNT As Decimal
    '    Private _AMOUNT_TAX As Decimal
    '    Private _AMOUNT_SALES As Decimal
    '    Private _UPDATE_DATE As Date
    '    Private _UPDATE_HOUR As String
    '    Private _USER_ID As String
    '    Private _CURR_EXCHANGE_TYPE As String
    '    Private _NAME_FACT As String
    '    Private _VAT_REGISTRATION_FACT As String
    '    Private _ADDR_FACT As String
    '    Private _REFER_DOCUMENT_TYPE As String
    '    Private _REFER_DOCUMENT_NUMBER As String
    'End Class

    'Public Class PURCHASE_ORDER_LINE

    'End Class


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
        Private _USER_ID As String

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
            _USER_ID = String.Empty
        End Sub
        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property
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
        Private _IS_COD_ARTICULO As String
        Private _IS_GUIA_REMISION As String

        Public Sub New()
            _IS_GUIA_REMISION = String.Empty
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
            _IS_COD_ARTICULO = String.Empty
        End Sub

        Public Property IS_COD_ARTICULO As String
            Get
                Return _IS_COD_ARTICULO
            End Get
            Set(value As String)
                _IS_COD_ARTICULO = value
            End Set
        End Property

        Public Property IS_GUIA_REMISION As String
            Get
                Return _IS_GUIA_REMISION
            End Get
            Set(value As String)
                _IS_GUIA_REMISION = value
            End Set
        End Property

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
        Private _ABREVITURA As String

        Public Sub New()
            _ID = String.Empty
            _NAME = String.Empty
            _ABREVITURA = String.Empty
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

        Public Property ABREVITURA As String
            Get
                Return _ABREVITURA
            End Get
            Set(value As String)
                _ABREVITURA = value
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
        Private _PAIS As String

        Private _AP_PATERNO As String
        Private _AP_MATERNO As String
        Private _PRIMER_NOMBRE As String
        Private _SEGUNDO_NOMBRE As String

        Private _COD_DEPARTAMENTO As String
        Private _COD_PROVINCIA As String
        Private _COD_DISTRITO As String


        Public Sub New()
            _COD_DEPARTAMENTO = String.Empty
            _COD_PROVINCIA = String.Empty
            _COD_DISTRITO = String.Empty

            _AP_PATERNO = String.Empty
            _AP_MATERNO = String.Empty
            _PRIMER_NOMBRE = String.Empty
            _SEGUNDO_NOMBRE = String.Empty
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
            _PAIS = String.Empty
        End Sub
        Public Property COD_DEPARTAMENTO As String
            Get
                Return _COD_DEPARTAMENTO
            End Get
            Set(value As String)
                _COD_DEPARTAMENTO = value
            End Set
        End Property
        Public Property COD_PROVINCIA As String
            Get
                Return _COD_PROVINCIA
            End Get
            Set(value As String)
                _COD_PROVINCIA = value
            End Set
        End Property
        Public Property COD_DISTRITO As String
            Get
                Return _COD_DISTRITO
            End Get
            Set(value As String)
                _COD_DISTRITO = value
            End Set
        End Property


        Public Property AP_PATERNO As String
            Get
                Return _AP_PATERNO
            End Get
            Set(value As String)
                _AP_PATERNO = value
            End Set
        End Property
        Public Property AP_MATERNO As String
            Get
                Return _AP_MATERNO
            End Get
            Set(value As String)
                _AP_MATERNO = value
            End Set
        End Property
        Public Property PRIMER_NOMBRE As String
            Get
                Return _PRIMER_NOMBRE
            End Get
            Set(value As String)
                _PRIMER_NOMBRE = value
            End Set
        End Property
        Public Property SEGUNDO_NOMBRE As String
            Get
                Return _SEGUNDO_NOMBRE
            End Get
            Set(value As String)
                _SEGUNDO_NOMBRE = value
            End Set
        End Property
        Public Property PAIS As String
            Get
                Return _PAIS
            End Get
            Set(value As String)
                _PAIS = value
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
        Private _IS_PRODUCTION As String
        Private _FORMULA_ID As String
        Private _COD_PRESENTACION As String
        Private _QTY_PRESENTACION As Double

        Private _COD_FORMA_FARMACEUTICO As String
        Private _COD_CONDICION_VENTA As String
        Private _COD_ESTADO_RS As String
        Private _COD_NORMA_TECNICA As String

        Private _FEC_EMISION_NORMA_TECNICA As String
        Private _FEC_VCTO_NORMA_TECNICA As String
        Private _NUMERO_NORMA_TECNICA As String

        Private _FLAG_PRODUCTO_CONTROLADO As String
        Private _COD_TIPO_PRODUCTO_CONTROLADO As String
        Private _COMMENT As String
        Private _STATUS_MAT_EMPAQUE As String
        Private _TIPO_ORIGEN As String

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
        Private _DAM As String
        Private _STOCK_MINIMO As Double
        Private _STOCK_MAXIMO As Double
        Private _STOCK_PUNTO_PEDIDO As Double
        Private _LINEA_PRODUCCION As String

        Public Sub New()
            _STOCK_MINIMO = 0
            _STOCK_MAXIMO = 0
            _STOCK_PUNTO_PEDIDO = 0
            _AD_VALOREM2 = 0.0
            _ISC = 0.0
            _IGV = 0.0
            _IPM = 0.0
            _DERECHOS_ESPECIFICOS = 0.0
            _DERECHOS_ANTIDUMPING = 0.0
            _SEGURO2 = 0.0
            _SOBRETASA_TRIBUTO = 0.0
            _SOBRETASA_SANCION = 0.0
            _PERCEPCION2 = 0.0
            _DAM = String.Empty
            _LINEA_PRODUCCION = String.Empty

            _FLAG_PRODUCTO_CONTROLADO = String.Empty
            _COD_TIPO_PRODUCTO_CONTROLADO = String.Empty
            _COMMENT = String.Empty
            _STATUS_MAT_EMPAQUE = String.Empty
            _TIPO_ORIGEN = String.Empty

            _FEC_EMISION_NORMA_TECNICA = String.Empty
            _FEC_VCTO_NORMA_TECNICA = String.Empty
            _NUMERO_NORMA_TECNICA = String.Empty

            _COD_FORMA_FARMACEUTICO = String.Empty
            _COD_CONDICION_VENTA = String.Empty
            _COD_ESTADO_RS = String.Empty
            _COD_NORMA_TECNICA = String.Empty

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
            _IS_PRODUCTION = String.Empty
            _FORMULA_ID = String.Empty
            _COD_PRESENTACION = String.Empty
            _QTY_PRESENTACION = 0
        End Sub
        Public Property LINEA_PRODUCCION As String
            Get
                Return _LINEA_PRODUCCION
            End Get
            Set(value As String)
                _LINEA_PRODUCCION = value
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

        Public Property STOCK_MINIMO As Double
            Get
                Return _STOCK_MINIMO
            End Get
            Set(value As Double)
                _STOCK_MINIMO = value
            End Set
        End Property
        Public Property STOCK_MAXIMO As Double
            Get
                Return _STOCK_MAXIMO
            End Get
            Set(value As Double)
                _STOCK_MAXIMO = value
            End Set
        End Property
        Public Property STOCK_PUNTO_PEDIDO As Double
            Get
                Return _STOCK_PUNTO_PEDIDO
            End Get
            Set(value As Double)
                _STOCK_PUNTO_PEDIDO = value
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

        Public Property TIPO_ORIGEN As String
            Get
                Return _TIPO_ORIGEN
            End Get
            Set(value As String)
                _TIPO_ORIGEN = value
            End Set
        End Property

        Public Property STATUS_MAT_EMPAQUE As String
            Get
                Return _STATUS_MAT_EMPAQUE
            End Get
            Set(value As String)
                _STATUS_MAT_EMPAQUE = value
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

        Public Property FLAG_PRODUCTO_CONTROLADO As String
            Get
                Return _FLAG_PRODUCTO_CONTROLADO
            End Get
            Set(value As String)
                _FLAG_PRODUCTO_CONTROLADO = value
            End Set
        End Property
        Public Property COD_TIPO_PRODUCTO_CONTROLADO As String
            Get
                Return _COD_TIPO_PRODUCTO_CONTROLADO
            End Get
            Set(value As String)
                _COD_TIPO_PRODUCTO_CONTROLADO = value
            End Set
        End Property

        Public Property FEC_EMISION_NORMA_TECNICA As String
            Get
                Return _FEC_EMISION_NORMA_TECNICA
            End Get
            Set(value As String)
                _FEC_EMISION_NORMA_TECNICA = value
            End Set
        End Property

        Public Property FEC_VCTO_NORMA_TECNICA As String
            Get
                Return _FEC_VCTO_NORMA_TECNICA
            End Get
            Set(value As String)
                _FEC_VCTO_NORMA_TECNICA = value
            End Set
        End Property

        Public Property NUMERO_NORMA_TECNICA As String
            Get
                Return _NUMERO_NORMA_TECNICA
            End Get
            Set(value As String)
                _NUMERO_NORMA_TECNICA = value
            End Set
        End Property

        Public Property COD_CONDICION_VENTA As String
            Get
                Return _COD_CONDICION_VENTA
            End Get
            Set(value As String)
                _COD_CONDICION_VENTA = value
            End Set
        End Property

        Public Property COD_ESTADO_RS As String
            Get
                Return _COD_ESTADO_RS
            End Get
            Set(value As String)
                _COD_ESTADO_RS = value
            End Set
        End Property
        Public Property COD_NORMA_TECNICA As String
            Get
                Return _COD_NORMA_TECNICA
            End Get
            Set(value As String)
                _COD_NORMA_TECNICA = value
            End Set
        End Property

        Public Property COD_FORMA_FARMACEUTICO As String
            Get
                Return _COD_FORMA_FARMACEUTICO
            End Get
            Set(value As String)
                _COD_FORMA_FARMACEUTICO = value
            End Set
        End Property

        Public Property QTY_PRESENTACION As Double
            Get
                Return _QTY_PRESENTACION
            End Get
            Set(value As Double)
                _QTY_PRESENTACION = value
            End Set
        End Property

        Public Property COD_PRESENTACION As String
            Get
                Return _COD_PRESENTACION
            End Get
            Set(value As String)
                _COD_PRESENTACION = value
            End Set
        End Property

        Public Property FORMULA_ID As String
            Get
                Return _FORMULA_ID
            End Get
            Set(value As String)
                _FORMULA_ID = value
            End Set
        End Property

        Public Property IS_PRODUCTION As String
            Get
                Return _IS_PRODUCTION
            End Get
            Set(value As String)
                _IS_PRODUCTION = value
            End Set
        End Property

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

    Public Class PRINCIPIOS_ACTIVOS_DETALLE
        Private _PART_ID As String
        Private _ID_PRINCIPIO As String
        Private _NAME_PRINCIPIO As String
        Private _USUARIO As String
        Private _TERMINAL As String


        Public Sub New()
            _PART_ID = String.Empty
            _ID_PRINCIPIO = String.Empty
            _NAME_PRINCIPIO = String.Empty
            _USUARIO = String.Empty
            _TERMINAL = String.Empty
        End Sub
        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property

        Public Property ID_PRINCIPIO As String
            Get
                Return _ID_PRINCIPIO
            End Get
            Set(value As String)
                _ID_PRINCIPIO = value
            End Set
        End Property

        Public Property NAME_PRINCIPIO As String
            Get
                Return _NAME_PRINCIPIO
            End Get
            Set(value As String)
                _NAME_PRINCIPIO = value
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

    Public Class INCRIPCIONES_REG_SANIT
        Private _PART_ID As String
        Private _NUM_REG_SANIT As String
        Private _FEC_EMISION As String
        Private _FEC_VENCIMIENTO As String
        Private _USUARIO As String
        Private _TERMINAL As String


        Public Sub New()
            _PART_ID = String.Empty
            _NUM_REG_SANIT = String.Empty
            _FEC_EMISION = String.Empty
            _FEC_VENCIMIENTO = String.Empty
            _USUARIO = String.Empty
            _TERMINAL = String.Empty
        End Sub
        Public Property PART_ID As String
            Get
                Return _PART_ID
            End Get
            Set(value As String)
                _PART_ID = value
            End Set
        End Property

        Public Property NUM_REG_SANIT As String
            Get
                Return _NUM_REG_SANIT
            End Get
            Set(value As String)
                _NUM_REG_SANIT = value
            End Set
        End Property

        Public Property FEC_EMISION As String
            Get
                Return _FEC_EMISION
            End Get
            Set(value As String)
                _FEC_EMISION = value
            End Set
        End Property

        Public Property FEC_VENCIMIENTO As String
            Get
                Return _FEC_VENCIMIENTO
            End Get
            Set(value As String)
                _FEC_VENCIMIENTO = value
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




    Public Class WAREHOUSE_TRANS_LINE
        Private _WAREHOUSE_ID As String
        Private _DOCUMENT_ID As String
        Private _NUMBER_DOCUMENT As String
        Private _ITEM As Integer
        Private _ITEM_ORDEN_COMPRA As Integer
        Private _PART_ID As String
        Private _REF_ID As String
        Private _QTY As Double
        Private _QTY_EQUIVALENTE As Double
        Private _TAMAÑO As Double
        Private _NUEVA_CANTIDAD As Double
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
        Private _OBSERVACIONES As String

        Private _F_VCTO As String
        Private _F_FABRICACION As String

        Private _ITEM_GUIA_VENTA As String
        Private _NUM_GUIA_VENTA As String

        Public Sub New()
            _ITEM_GUIA_VENTA = String.Empty
            _NUM_GUIA_VENTA = String.Empty

            _F_VCTO = String.Empty
            _F_FABRICACION = String.Empty

            _OBSERVACIONES = String.Empty
            _WAREHOUSE_ID = String.Empty
            _DOCUMENT_ID = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _ITEM = 0
            _ITEM_ORDEN_COMPRA = 0
            _PART_ID = String.Empty
            _REF_ID = String.Empty
            _QTY = 0.0R
            _QTY_EQUIVALENTE = 0.0R
            _TAMAÑO = 0.0R
            _NUEVA_CANTIDAD = 0.0R
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
        Public Property NUM_GUIA_VENTA As String
            Get
                Return _NUM_GUIA_VENTA
            End Get
            Set(value As String)
                _NUM_GUIA_VENTA = value
            End Set
        End Property
        Public Property ITEM_GUIA_VENTA As String
            Get
                Return _ITEM_GUIA_VENTA
            End Get
            Set(value As String)
                _ITEM_GUIA_VENTA = value
            End Set
        End Property


        Public Property F_VCTO As String
            Get
                Return _F_VCTO
            End Get
            Set(value As String)
                _F_VCTO = value
            End Set
        End Property
        Public Property F_FABRICACION As String
            Get
                Return _F_FABRICACION
            End Get
            Set(value As String)
                _F_FABRICACION = value
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

        Public Property ITEM_ORDEN_COMPRA As Integer
            Get
                Return _ITEM_ORDEN_COMPRA
            End Get
            Set(value As Integer)
                _ITEM_ORDEN_COMPRA = value
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

        Public Property QTY_EQUIVALENTE As Double
            Get
                Return _QTY_EQUIVALENTE
            End Get
            Set(value As Double)
                _QTY_EQUIVALENTE = value
            End Set
        End Property
        Public Property TAMAÑO As Double
            Get
                Return _TAMAÑO
            End Get
            Set(value As Double)
                _TAMAÑO = value
            End Set
        End Property
        Public Property NUEVA_CANTIDAD As Double
            Get
                Return _NUEVA_CANTIDAD
            End Get
            Set(value As Double)
                _NUEVA_CANTIDAD = value
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
        Private _IS_COD_PRODUCTO As String

        Private _NUMBER_SERIE As String
        Private _OPT_COMPRAS As String

        Private _PESO_BRUTO_TOTAL As Double
        Private _UM_PESO_BRUTO_TOTAL As String
        Private _FECHA_TRASLADO As String
        Private _EMAIL_CLIENTE As String
        Private _MODALIDAD_TRANSPORTE As String
        Private _NUMERO_ENTREGA As String
        Private _MOTIVO_TRASLADO As String
        Private _UBIGEO_PARTIDA As String
        Private _DIRECCION_PARTIDA As String

        Public Sub New()
            _UBIGEO_PARTIDA = String.Empty
            _DIRECCION_PARTIDA = String.Empty
            _MOTIVO_TRASLADO = String.Empty
            _NUMERO_ENTREGA = String.Empty
            _MODALIDAD_TRANSPORTE = String.Empty
            _EMAIL_CLIENTE = String.Empty

            _PESO_BRUTO_TOTAL = 0.0R
            _UM_PESO_BRUTO_TOTAL = String.Empty
            _FECHA_TRASLADO = String.Empty

            _NUMBER_SERIE = String.Empty
            _OPT_COMPRAS = String.Empty

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
            _IS_COD_PRODUCTO = String.Empty
        End Sub
        Public Property MOTIVO_TRASLADO As String
            Get
                Return _MOTIVO_TRASLADO
            End Get
            Set(value As String)
                _MOTIVO_TRASLADO = value
            End Set
        End Property
        Public Property NUMERO_ENTREGA As String
            Get
                Return _NUMERO_ENTREGA
            End Get
            Set(value As String)
                _NUMERO_ENTREGA = value
            End Set
        End Property
        Public Property MODALIDAD_TRANSPORTE As String
            Get
                Return _MODALIDAD_TRANSPORTE
            End Get
            Set(value As String)
                _MODALIDAD_TRANSPORTE = value
            End Set
        End Property

        Public Property EMAIL_CLIENTE As String
            Get
                Return _EMAIL_CLIENTE
            End Get
            Set(value As String)
                _EMAIL_CLIENTE = value
            End Set
        End Property

        Public Property PESO_BRUTO_TOTAL As Double
            Get
                Return _PESO_BRUTO_TOTAL
            End Get
            Set(value As Double)
                _PESO_BRUTO_TOTAL = value
            End Set
        End Property
        Public Property UM_PESO_BRUTO_TOTAL As String
            Get
                Return _UM_PESO_BRUTO_TOTAL
            End Get
            Set(value As String)
                _UM_PESO_BRUTO_TOTAL = value
            End Set
        End Property
        Public Property FECHA_TRASLADO As String
            Get
                Return _FECHA_TRASLADO
            End Get
            Set(value As String)
                _FECHA_TRASLADO = value
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
        Public Property OPT_COMPRAS As String
            Get
                Return _OPT_COMPRAS
            End Get
            Set(value As String)
                _OPT_COMPRAS = value
            End Set
        End Property


        Public Property IS_COD_PRODUCTO As String
            Get
                Return _IS_COD_PRODUCTO
            End Get
            Set(value As String)
                _IS_COD_PRODUCTO = value
            End Set
        End Property
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

        Public Property UBIGEO_PARTIDA As String
            Get
                Return _UBIGEO_PARTIDA
            End Get
            Set(value As String)
                _UBIGEO_PARTIDA = value
            End Set
        End Property
        Public Property DIRECCION_PARTIDA As String
            Get
                Return _DIRECCION_PARTIDA
            End Get
            Set(value As String)
                _DIRECCION_PARTIDA = value
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
        Private _USUARIO As String
        Private _TERMINAL As String

        Public Sub New()
            _USUARIO = String.Empty
            _TERMINAL = String.Empty
            _CURRENCY_ID = String.Empty
            _CURRENCY_DATE = String.Empty
            _BUY_RATE = 0.0R
            _BUY_EQUIV = 0.0R
            _SELL_RATE = 0.0R
            _SELL_EQUIV = 0.0R
        End Sub
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
        Private _QTY_EQUIVALENTE As Double
        Private _TAMAÑO As Double
        Private _NUEVA_CANTIDAD As Double
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
        Private _OBSERVACIONES As String

        Private _ITEM_GUIA_VENTA As Double
        Private _NUM_GUIA_VENTA As String

        Public Sub New()
            _ITEM_GUIA_VENTA = 0
            _NUM_GUIA_VENTA = String.Empty

            _DOCUMENT_ID = String.Empty
            _OBSERVACIONES = String.Empty
            _NUMBER_SERIE = String.Empty
            _NUMBER_DOCUMENT = String.Empty
            _ITEM = String.Empty
            _PART_ID = String.Empty
            _QTY = 0.0R
            _QTY_EQUIVALENTE = 0.0R
            _TAMAÑO = 0.0R
            _NUEVA_CANTIDAD = 0.0R
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

        Public Property ITEM_GUIA_VENTA As Double
            Get
                Return _ITEM_GUIA_VENTA
            End Get
            Set(value As Double)
                _ITEM_GUIA_VENTA = value
            End Set

        End Property
        Public Property NUM_GUIA_VENTA As String
            Get
                Return _NUM_GUIA_VENTA
            End Get
            Set(value As String)
                _NUM_GUIA_VENTA = value
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

        Public Property QTY_EQUIVALENTE As Double
            Get
                Return _QTY_EQUIVALENTE
            End Get
            Set(value As Double)
                _QTY_EQUIVALENTE = value
            End Set
        End Property
        Public Property TAMAÑO As Double
            Get
                Return _TAMAÑO
            End Get
            Set(value As Double)
                _TAMAÑO = value
            End Set
        End Property
        Public Property NUEVA_CANTIDAD As Double
            Get
                Return _NUEVA_CANTIDAD
            End Get
            Set(value As Double)
                _NUEVA_CANTIDAD = value
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

        Private _WAREHOUSE_ID_IN As String
        Private _DOCUMENT_ID_IN As String
        Private _NUMBER_DOCUMENT_IN As String
        Private _DATE_DOC_DEVOLUCION As String
        Public Sub New()
            _DATE_DOC_DEVOLUCION = String.Empty
            _WAREHOUSE_ID_IN = String.Empty
            _DOCUMENT_ID_IN = String.Empty
            _NUMBER_DOCUMENT_IN = String.Empty

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

        Public Property DATE_DOC_DEVOLUCION As String
            Get
                Return _DATE_DOC_DEVOLUCION
            End Get
            Set(value As String)
                _DATE_DOC_DEVOLUCION = value
            End Set
        End Property

        Public Property WAREHOUSE_ID_IN As String
            Get
                Return _WAREHOUSE_ID_IN
            End Get
            Set(value As String)
                _WAREHOUSE_ID_IN = value
            End Set
        End Property
        Public Property DOCUMENT_ID_IN As String
            Get
                Return _DOCUMENT_ID_IN
            End Get
            Set(value As String)
                _DOCUMENT_ID_IN = value
            End Set
        End Property
        Public Property NUMBER_DOCUMENT_IN As String
            Get
                Return _NUMBER_DOCUMENT_IN
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT_IN = value
            End Set
        End Property

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
        Private _FECHA_REFERENCIA As String
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
        Private _FORMA_DE_PAGO As String
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
        Private _NUM_LICITACION As String
        Private _NUM_GUIA_REF_DEVOLUCION As String

        Private _FECHA_TRASLADO As String
        Private _TIPO_NOTA_ELECTRONICA As String
        Private _DESCRIPCION_TIPO_NOTA_ELECTRONICA As String
        Private _EMAIL_CLIENTE As String

        Private _CDR As String
        Private _CRESUMEN As String
        Private _FECHA_RECEPCION As String
        Private _HORA_RECEPCION As String
        Private _FECHA_GENERACION As String
        Private _HORA_GENERACION As String
        Private _RUC_EMISOR As String
        Private _RESPUESTA_SUNAT As String
        Private _ID_RECEPTOR As String
        Private _CODIGO_RESPUESTA As String
        Private _MODO_PAGO As String
        Private _ORIGEN As String

        Private _TIPO_CANCELACION As String
        Private _VUELTO As Double

        Private _MONTO_SOLES As Double
        Private _MONTO_DOLARES As Double
        Private _MONTO_VISA As Double
        Private _MONTO_MASTERCARD As Double
        Private _MONTO_AMERICAN As Double
        Private _MONTO_DINERS As Double
        Private _STATUS_PEDIDO As String
        Private _MONTO_SCOTIABANK As Double
        Private _MONTO_INTERBANK As Double


        Public Sub New()
            _STATUS_PEDIDO = String.Empty
            _MONTO_SCOTIABANK = 0.0R
            _MONTO_INTERBANK = 0.0R
            _MONTO_SOLES = 0.0R
            _MONTO_DOLARES = 0.0R
            _MONTO_VISA = 0.0R
            _MONTO_MASTERCARD = 0.0R
            _MONTO_AMERICAN = 0.0R
            _MONTO_DINERS = 0.0R

            _VUELTO = 0.0R
            _ORIGEN = String.Empty
            _TIPO_CANCELACION = String.Empty
            _FORMA_DE_PAGO = String.Empty
            _MODO_PAGO = String.Empty
            _CDR = String.Empty
            _CRESUMEN = String.Empty
            _FECHA_RECEPCION = String.Empty
            _HORA_RECEPCION = String.Empty
            _FECHA_GENERACION = String.Empty
            _HORA_GENERACION = String.Empty
            _RUC_EMISOR = String.Empty
            _RESPUESTA_SUNAT = String.Empty
            _ID_RECEPTOR = String.Empty
            _CODIGO_RESPUESTA = String.Empty

            _FECHA_TRASLADO = String.Empty
            _STATUS = 0
            _NUM_LICITACION = String.Empty
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
            _FECHA_REFERENCIA = String.Empty
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
            _MOV_OPTION_ID = String.Empty
            _NUM_GUIA_REF_DEVOLUCION = String.Empty

            _EMAIL_CLIENTE = String.Empty
            _TIPO_NOTA_ELECTRONICA = String.Empty
            _DESCRIPCION_TIPO_NOTA_ELECTRONICA = String.Empty
        End Sub
        Public Property MONTO_SCOTIABANK As Double
            Get
                Return _MONTO_SCOTIABANK
            End Get
            Set(value As Double)
                _MONTO_SCOTIABANK = value
            End Set
        End Property
        Public Property MONTO_INTERBANK As Double
            Get
                Return _MONTO_INTERBANK
            End Get
            Set(value As Double)
                _MONTO_INTERBANK = value
            End Set
        End Property

        Public Property STATUS_PEDIDO As String
            Get
                Return _STATUS_PEDIDO
            End Get
            Set(value As String)
                _STATUS_PEDIDO = value
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

        Public Property FORMA_DE_PAGO As String
            Get
                Return _FORMA_DE_PAGO
            End Get
            Set(value As String)
                _FORMA_DE_PAGO = value
            End Set
        End Property

        Public Property MONTO_SOLES As Double
            Get
                Return _MONTO_SOLES
            End Get
            Set(value As Double)
                _MONTO_SOLES = value
            End Set
        End Property
        Public Property MONTO_DOLARES As Double
            Get
                Return _MONTO_DOLARES
            End Get
            Set(value As Double)
                _MONTO_DOLARES = value
            End Set
        End Property
        Public Property MONTO_VISA As Double
            Get
                Return _MONTO_VISA
            End Get
            Set(value As Double)
                _MONTO_VISA = value
            End Set
        End Property
        Public Property MONTO_MASTERCARD As Double
            Get
                Return _MONTO_MASTERCARD
            End Get
            Set(value As Double)
                _MONTO_MASTERCARD = value
            End Set
        End Property
        Public Property MONTO_AMERICAN As Double
            Get
                Return _MONTO_AMERICAN
            End Get
            Set(value As Double)
                _MONTO_AMERICAN = value
            End Set
        End Property
        Public Property MONTO_DINERS As Double
            Get
                Return _MONTO_DINERS
            End Get
            Set(value As Double)
                _MONTO_DINERS = value
            End Set
        End Property


        Public Property VUELTO As Double
            Get
                Return _VUELTO
            End Get
            Set(value As Double)
                _VUELTO = value
            End Set
        End Property
        Public Property TIPO_CANCELACION As String
            Get
                Return _TIPO_CANCELACION
            End Get
            Set(value As String)
                _TIPO_CANCELACION = value
            End Set
        End Property

        Public Property MODO_PAGO As String
            Get
                Return _MODO_PAGO
            End Get
            Set(value As String)
                _MODO_PAGO = value
            End Set
        End Property

        Public Property CDR As String
            Get
                Return _CDR
            End Get
            Set(value As String)
                _CDR = value
            End Set
        End Property
        Public Property CRESUMEN As String
            Get
                Return _CRESUMEN
            End Get
            Set(value As String)
                _CRESUMEN = value
            End Set
        End Property
        Public Property FECHA_RECEPCION As String
            Get
                Return _FECHA_RECEPCION
            End Get
            Set(value As String)
                _FECHA_RECEPCION = value
            End Set
        End Property
        Public Property HORA_RECEPCION As String
            Get
                Return _HORA_RECEPCION
            End Get
            Set(value As String)
                _HORA_RECEPCION = value
            End Set
        End Property
        Public Property FECHA_GENERACION As String
            Get
                Return _FECHA_GENERACION
            End Get
            Set(value As String)
                _FECHA_GENERACION = value
            End Set
        End Property
        Public Property HORA_GENERACION As String
            Get
                Return _HORA_GENERACION
            End Get
            Set(value As String)
                _HORA_GENERACION = value
            End Set
        End Property
        Public Property RUC_EMISOR As String
            Get
                Return _RUC_EMISOR
            End Get
            Set(value As String)
                _RUC_EMISOR = value
            End Set
        End Property
        Public Property RESPUESTA_SUNAT As String
            Get
                Return _RESPUESTA_SUNAT
            End Get
            Set(value As String)
                _RESPUESTA_SUNAT = value
            End Set
        End Property
        Public Property ID_RECEPTOR As String
            Get
                Return _ID_RECEPTOR
            End Get
            Set(value As String)
                _ID_RECEPTOR = value
            End Set
        End Property
        Public Property CODIGO_RESPUESTA As String
            Get
                Return _CODIGO_RESPUESTA
            End Get
            Set(value As String)
                _CODIGO_RESPUESTA = value
            End Set
        End Property


        Public Property TIPO_NOTA_ELECTRONICA As String
            Get
                Return _TIPO_NOTA_ELECTRONICA
            End Get
            Set(value As String)
                _TIPO_NOTA_ELECTRONICA = value
            End Set
        End Property
        Public Property DESCRIPCION_TIPO_NOTA_ELECTRONICA As String
            Get
                Return _DESCRIPCION_TIPO_NOTA_ELECTRONICA
            End Get
            Set(value As String)
                _DESCRIPCION_TIPO_NOTA_ELECTRONICA = value
            End Set
        End Property
        Public Property EMAIL_CLIENTE As String
            Get
                Return _EMAIL_CLIENTE
            End Get
            Set(value As String)
                _EMAIL_CLIENTE = value
            End Set
        End Property

        Public Property FECHA_TRASLADO As String
            Get
                Return _FECHA_TRASLADO
            End Get
            Set(value As String)
                _FECHA_TRASLADO = value
            End Set
        End Property
        Public Property FECHA_REFERENCIA As String
            Get
                Return _FECHA_REFERENCIA
            End Get
            Set(value As String)
                _FECHA_REFERENCIA = value
            End Set
        End Property

        Public Property NUM_GUIA_REF_DEVOLUCION As String
            Get
                Return _NUM_GUIA_REF_DEVOLUCION
            End Get
            Set(value As String)
                _NUM_GUIA_REF_DEVOLUCION = value
            End Set
        End Property

        Public Property NUM_LICITACION As String
            Get
                Return _NUM_LICITACION
            End Get
            Set(value As String)
                _NUM_LICITACION = value
            End Set
        End Property

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

    Public Class DOCUMENT_TYPE
        Private _TYPE_ID As String
        Private _NAME As String
        Private _SUNAT_ID As String
        Private _ACCOUNT As String
        Private _ACCOUNT_ME As String


        Public Sub New()
            _TYPE_ID = String.Empty
            _NAME = String.Empty
            _SUNAT_ID = String.Empty
            _ACCOUNT = String.Empty
            _ACCOUNT_ME = String.Empty
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

        Public Property SUNAT_ID As String
            Get
                Return _SUNAT_ID
            End Get
            Set(value As String)
                _SUNAT_ID = value
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
        Public Property ACCOUNT_ME As String
            Get
                Return _ACCOUNT_ME
            End Get
            Set(value As String)
                _ACCOUNT_ME = value
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

        Private _AP_PATERNO As String
        Private _AP_MATERNO As String
        Private _PRIMER_NOMBRE As String
        Private _SEGUNDO_NOMBRE As String

        Private _ESTADO_VALIDACION_FE As String


        Public Sub New()
            _ESTADO_VALIDACION_FE = String.Empty
            _AP_PATERNO = String.Empty
            _AP_MATERNO = String.Empty
            _PRIMER_NOMBRE = String.Empty
            _SEGUNDO_NOMBRE = String.Empty

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
        Public Property ESTADO_VALIDACION_FE As String
            Get
                Return _ESTADO_VALIDACION_FE
            End Get
            Set(value As String)
                _ESTADO_VALIDACION_FE = value
            End Set
        End Property
        Public Property AP_PATERNO As String
            Get
                Return _AP_PATERNO
            End Get
            Set(value As String)
                _AP_PATERNO = value
            End Set
        End Property
        Public Property AP_MATERNO As String
            Get
                Return _AP_MATERNO
            End Get
            Set(value As String)
                _AP_MATERNO = value
            End Set
        End Property
        Public Property PRIMER_NOMBRE As String
            Get
                Return _PRIMER_NOMBRE
            End Get
            Set(value As String)
                _PRIMER_NOMBRE = value
            End Set
        End Property
        Public Property SEGUNDO_NOMBRE As String
            Get
                Return _SEGUNDO_NOMBRE
            End Get
            Set(value As String)
                _SEGUNDO_NOMBRE = value
            End Set
        End Property

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
        Private _AMOUNT_DETRAC As Double
        Private _PERCENT_DETRAC As Double

        Public Sub New()
            _ID = String.Empty
            _ITEM = String.Empty
            _TYPE_DOC = String.Empty
            _NUMBER_DOC = String.Empty
            _AMOUNT = 0
            _CADUCATE_DATE = String.Empty
            _IS_ORIG = String.Empty
            _OPCION = String.Empty
            _AMOUNT_DETRAC = 0
            _PERCENT_DETRAC = 0
        End Sub
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
        Private _SERIE_DOCUMENTO As String
        Private _NUMERO_DOCUMENTO As String

        Public Sub New()
            _ID = String.Empty
            _ITEM = String.Empty
            _TYPE_DOC = String.Empty
            _NUMBER_DOC = String.Empty
            _AMOUNT = 0
            _CADUCATE_DATE = String.Empty
            _IS_ORIG = String.Empty
            _OPCION = String.Empty

            _SERIE_DOCUMENTO = String.Empty
            _NUMERO_DOCUMENTO = String.Empty
        End Sub
        Public Property SERIE_DOCUMENTO As String
            Get
                Return _SERIE_DOCUMENTO
            End Get
            Set(value As String)
                _SERIE_DOCUMENTO = value
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
        Private _GRUPO_COBRANZA As String

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
            _GRUPO_COBRANZA = String.Empty
        End Sub
        Public Property GRUPO_COBRANZA As String
            Get
                Return _GRUPO_COBRANZA
            End Get
            Set(value As String)
                _GRUPO_COBRANZA = value
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
        Private _DATE_REF As String
        Private _AMOUNT_ITF As Double
        Private _AMOUNT_COMISIONES As Double
        Private _AMOUNT_GASTOS_FINANCIEROS As Double
        Private _SERIE_REF As String
        Private _INGRESOS_POR_REDONDEO As Double
        Private _GASTOS_POR_REDONDEO As Double

        Public Sub New()
            _INGRESOS_POR_REDONDEO = 0
            _GASTOS_POR_REDONDEO = 0

            _SERIE_REF = String.Empty
            _AMOUNT_ITF = 0
            _AMOUNT_COMISIONES = 0
            _AMOUNT_GASTOS_FINANCIEROS = 0
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
        Public Property INGRESOS_POR_REDONDEO As Double
            Get
                Return _INGRESOS_POR_REDONDEO
            End Get
            Set(value As Double)
                _INGRESOS_POR_REDONDEO = value
            End Set
        End Property
        Public Property GASTOS_POR_REDONDEO As Double
            Get
                Return _GASTOS_POR_REDONDEO
            End Get
            Set(value As Double)
                _GASTOS_POR_REDONDEO = value
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

        Public Property AMOUNT_GASTOS_FINANCIEROS As Double
            Get
                Return _AMOUNT_GASTOS_FINANCIEROS
            End Get
            Set(value As Double)
                _AMOUNT_GASTOS_FINANCIEROS = value
            End Set
        End Property

        Public Property AMOUNT_COMISIONES As Double
            Get
                Return _AMOUNT_COMISIONES
            End Get
            Set(value As Double)
                _AMOUNT_COMISIONES = value
            End Set
        End Property

        Public Property AMOUNT_ITF As Double
            Get
                Return _AMOUNT_ITF
            End Get
            Set(value As Double)
                _AMOUNT_ITF = value
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
        Private _CLIENTE As String

        Public Sub New()
            _CUENTA = String.Empty
            _RUC = String.Empty
            _TIPO_DOC = String.Empty
            _SERIE_DOC = String.Empty
            _NUMERO_DOC = String.Empty
            _FEC_DOC = String.Empty
            _FEC_VEN_DOC = String.Empty
            _CLIENTE = String.Empty
            _MONTO_DOC = 0
            _TIPO_MONEDA = 0
            _TC = 0
        End Sub

        Public Property CLIENTE As String
            Get
                Return _CLIENTE
            End Get
            Set(value As String)
                _CLIENTE = value
            End Set
        End Property

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
        Private _AMOUNT_INTERES As Double
        Private _AMOUNT_ITF As Double
        Private _AMOUNT_GASTOS_BANCARIOS As Double
        Private _SERIE_REF As String
        Private _GENERA_CR As String
        Private _INGRESOS_POR_REDONDEO As Double
        Private _GASTOS_POR_REDONDEO As Double

        Public Sub New()
            _INGRESOS_POR_REDONDEO = 0
            _GASTOS_POR_REDONDEO = 0
            _GENERA_CR = String.Empty
            _SERIE_REF = String.Empty
            _AMOUNT_GASTOS_BANCARIOS = 0
            _AMOUNT_INTERES = 0
            _AMOUNT_ITF = 0
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
        Public Property GENERA_CR As String
            Get
                Return _GENERA_CR
            End Get
            Set(value As String)
                _GENERA_CR = value
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

        Public Property AMOUNT_ITF As Double
            Get
                Return _AMOUNT_ITF
            End Get
            Set(value As Double)
                _AMOUNT_ITF = value
            End Set
        End Property

        Public Property AMOUNT_GASTOS_BANCARIOS As Double
            Get
                Return _AMOUNT_GASTOS_BANCARIOS
            End Get
            Set(value As Double)
                _AMOUNT_GASTOS_BANCARIOS = value
            End Set
        End Property

        Public Property AMOUNT_INTERES As Double
            Get
                Return _AMOUNT_INTERES
            End Get
            Set(value As Double)
                _AMOUNT_INTERES = value
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

        Public Property INGRESOS_POR_REDONDEO As Double
            Get
                Return _INGRESOS_POR_REDONDEO
            End Get
            Set(value As Double)
                _INGRESOS_POR_REDONDEO = value
            End Set
        End Property
        Public Property GASTOS_POR_REDONDEO As Double
            Get
                Return _GASTOS_POR_REDONDEO
            End Get
            Set(value As Double)
                _GASTOS_POR_REDONDEO = value
            End Set
        End Property

    End Class

End Class

