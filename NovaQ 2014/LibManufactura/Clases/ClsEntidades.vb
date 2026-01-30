Public Class ClsEntidades

    Public Class MANTENIMIENTO_OP_PARTE_PRODUCCION_DETALLE_TRABAJOS_MANTENIMIENTO
        Private _ITEM As Integer
        Private _ID As String
        Private _DESCRIPCION As String

        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
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
        Public Property DESCRIPCION As String
            Get
                Return _DESCRIPCION
            End Get
            Set(value As String)
                _DESCRIPCION = value
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
        Private _AREA_PP As String
        Private _TIPO_ORDEN As String

        Public Property TIPO_ORDEN As String
            Get
                Return _TIPO_ORDEN
            End Get
            Set(value As String)
                _TIPO_ORDEN = value
            End Set
        End Property

        Public Property AREA_PP As String
            Get
                Return _AREA_PP
            End Get
            Set(value As String)
                _AREA_PP = value
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

        Private _MOTIVO_REPROGRAMACION As String
        Private _OBSERVACION_REPROGRAMACION As String
        Private _REPROGRAMACION As String
        Private _TIPO_ORDEN As String

        Public Property TIPO_ORDEN As String
            Get
                Return _TIPO_ORDEN
            End Get
            Set(value As String)
                _TIPO_ORDEN = value
            End Set
        End Property

        Public Property MOTIVO_REPROGRAMACION As String
            Get
                Return _MOTIVO_REPROGRAMACION
            End Get
            Set(value As String)
                _MOTIVO_REPROGRAMACION = value
            End Set
        End Property
        Public Property OBSERVACION_REPROGRAMACION As String
            Get
                Return _OBSERVACION_REPROGRAMACION
            End Get
            Set(value As String)
                _OBSERVACION_REPROGRAMACION = value
            End Set
        End Property
        Public Property REPROGRAMACION As String
            Get
                Return _REPROGRAMACION
            End Get
            Set(value As String)
                _REPROGRAMACION = value
            End Set
        End Property

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
    Public Class MANTENIMIENTO_OP_CORTE

        Private _ID As Integer
        Private _ITEM As Integer
        Private _MAQUINA_COD As String
        Private _ELEMENTO_COD As String
        Private _ELEMENTO As String
        Private _TIPO_CORTE As String
        Private _HORA As String
        Private _FORMATO As String
        Private _CANTIDAD As String
        Private _OBSERVACIONES As String
        Private _ESTADO As String
        Private _USER_ID As String
        Private _PC_ID As String
        Private _CONFORME As String
        Private _FECHA_PROGRAMADO As String
        Private _ITEM_PROGRAMADO As Integer
        Private _ESTADO_PROGRAMA_PRODUCCION As String
        Private _TIEMPO As Double
        Private _TIEMPO_PREPARACION As Double

        Private _NUMERO_GR As String
        Private _FECHA_GR As String
        Private _CANTIDAD_GR As String
        Private _OBS_GR As String
        Private _PROVEEDOR_SRV As String
        Private _PROVEEDOR_SRV_NAME As String
        Private _TURNO As String
        Private _ORDEN As Integer
        Private _OBS_PLANEAMIENTO As String

        Private _CAMBIA_TIEMPO As String
        Private _HORA_REAL As Double
        Private _MINUTO_REAL As Double
        Private _CIERRA_DESPACHO As String

        Public Property CIERRA_DESPACHO As String
            Get
                Return _CIERRA_DESPACHO
            End Get
            Set(value As String)
                _CIERRA_DESPACHO = value
            End Set
        End Property

        Public Property CAMBIA_TIEMPO As String
            Get
                Return _CAMBIA_TIEMPO
            End Get
            Set(value As String)
                _CAMBIA_TIEMPO = value
            End Set
        End Property
        Public Property HORA_REAL As Double
            Get
                Return _HORA_REAL
            End Get
            Set(value As Double)
                _HORA_REAL = value
            End Set
        End Property
        Public Property MINUTO_REAL As Double
            Get
                Return _MINUTO_REAL
            End Get
            Set(value As Double)
                _MINUTO_REAL = value
            End Set
        End Property

        Public Property OBS_PLANEAMIENTO As String
            Get
                Return _OBS_PLANEAMIENTO
            End Get
            Set(value As String)
                _OBS_PLANEAMIENTO = value
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
        Public Property ORDEN As Integer
            Get
                Return _ORDEN
            End Get
            Set(value As Integer)
                _ORDEN = value
            End Set
        End Property

        Public Property PROVEEDOR_SRV As String
            Get
                Return _PROVEEDOR_SRV
            End Get
            Set(value As String)
                _PROVEEDOR_SRV = value
            End Set
        End Property
        Public Property PROVEEDOR_SRV_NAME As String
            Get
                Return _PROVEEDOR_SRV_NAME
            End Get
            Set(value As String)
                _PROVEEDOR_SRV_NAME = value
            End Set
        End Property
        Public Property NUMERO_GR As String
            Get
                Return _NUMERO_GR
            End Get
            Set(value As String)
                _NUMERO_GR = value
            End Set
        End Property
        Public Property FECHA_GR As String
            Get
                Return _FECHA_GR
            End Get
            Set(value As String)
                _FECHA_GR = value
            End Set
        End Property
        Public Property CANTIDAD_GR As String
            Get
                Return _CANTIDAD_GR
            End Get
            Set(value As String)
                _CANTIDAD_GR = value
            End Set
        End Property
        Public Property OBS_GR As String
            Get
                Return _OBS_GR
            End Get
            Set(value As String)
                _OBS_GR = value
            End Set
        End Property

        Public Property TIEMPO_PREPARACION As Double
            Get
                Return _TIEMPO_PREPARACION
            End Get
            Set(value As Double)
                _TIEMPO_PREPARACION = value
            End Set
        End Property
        Public Property TIEMPO As Double
            Get
                Return _TIEMPO
            End Get
            Set(value As Double)
                _TIEMPO = value
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
        Public Property MAQUINA_COD As String
            Get
                Return _MAQUINA_COD
            End Get
            Set(value As String)
                _MAQUINA_COD = value
            End Set
        End Property
        Public Property ELEMENTO_COD As String
            Get
                Return _ELEMENTO_COD
            End Get
            Set(value As String)
                _ELEMENTO_COD = value
            End Set
        End Property
        Public Property ELEMENTO As String
            Get
                Return _ELEMENTO
            End Get
            Set(value As String)
                _ELEMENTO = value
            End Set
        End Property
        Public Property TIPO_CORTE As String
            Get
                Return _TIPO_CORTE
            End Get
            Set(value As String)
                _TIPO_CORTE = value
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
        Public Property FORMATO As String
            Get
                Return _FORMATO
            End Get
            Set(value As String)
                _FORMATO = value
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
        Public Property OBSERVACIONES As String
            Get
                Return _OBSERVACIONES
            End Get
            Set(value As String)
                _OBSERVACIONES = value
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
        Public Property CONFORME As String
            Get
                Return _CONFORME
            End Get
            Set(value As String)
                _CONFORME = value
            End Set
        End Property
        Public Property FECHA_PROGRAMADO As String
            Get
                Return _FECHA_PROGRAMADO
            End Get
            Set(value As String)
                _FECHA_PROGRAMADO = value
            End Set
        End Property
        Public Property ITEM_PROGRAMADO As Integer
            Get
                Return _ITEM_PROGRAMADO
            End Get
            Set(value As Integer)
                _ITEM_PROGRAMADO = value
            End Set
        End Property
        Public Property ESTADO_PROGRAMA_PRODUCCION As String
            Get
                Return _ESTADO_PROGRAMA_PRODUCCION
            End Get
            Set(value As String)
                _ESTADO_PROGRAMA_PRODUCCION = value
            End Set
        End Property
    End Class
    Public Class PERSONAL
        Private _TYPE_ID As String
        Private _NAME As String
        Private _CODIGO_EQUIPO As String

        Public Sub New()
            _TYPE_ID = String.Empty
            _NAME = String.Empty
            _CODIGO_EQUIPO = String.Empty
        End Sub

        Public Property CODIGO_EQUIPO As String
            Get
                Return _CODIGO_EQUIPO
            End Get
            Set(value As String)
                _CODIGO_EQUIPO = value
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

    Public Class ORDER_LINE_APP_DESPACHO
        Private _ID_CAB As Integer
        Private _CODIGO_INTERNO As Integer
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _UNIT As String
        Private _QTY As Double
        Private _EMPRESA As String

        Public Sub New()
            _ID_CAB = 0
            _ITEM = 0
            _CODIGO_INTERNO = 0
            _PART_ID = String.Empty
            _PART_DESCRIPTION = String.Empty
            _UNIT = String.Empty
            _QTY = 0.0
            _EMPRESA = String.Empty
        End Sub

        Public Property CODIGO_INTERNO As Integer
            Get
                Return _CODIGO_INTERNO
            End Get
            Set(value As Integer)
                _CODIGO_INTERNO = value
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
        Public Property EMPRESA As String
            Get
                Return _EMPRESA
            End Get
            Set(value As String)
                _EMPRESA = value
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

    End Class

    Public Class PROCESO_COSTEO

        Private _ID As Integer
        Private _FECHA As String
        Private _ID_FORMULA As String
        Private _USER_ID As String
        Private _GLOSA As String
        Private _LOTE As String

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
        Public Property ID_FORMULA As String
            Get
                Return _ID_FORMULA
            End Get
            Set(value As String)
                _ID_FORMULA = value
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
        Public Property GLOSA As String
            Get
                Return _GLOSA
            End Get
            Set(value As String)
                _GLOSA = value
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
    End Class

    Public Class PROCESO_COSTEO_MP

        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _UNIT As String
        Private _QTY As Double
        Private _AVERAGE_COST As Double


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
        Public Property QTY As Double
            Get
                Return _QTY
            End Get
            Set(value As Double)
                _QTY = value
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
    End Class

    Public Class PROCESO_COSTEO_PT

        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _UNIT As String
        Private _CANTIDAD As Double
        Private _COSTO_UNITARIO As Double
        Private _COSTOS_VARIOS As Double
        Private _SUB_TOTAL As Double
        Private _IGV As Double
        Private _COSTO_FINAL As Double

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
        Public Property CANTIDAD As Double
            Get
                Return _CANTIDAD
            End Get
            Set(value As Double)
                _CANTIDAD = value
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
        Public Property COSTOS_VARIOS As Double
            Get
                Return _COSTOS_VARIOS
            End Get
            Set(value As Double)
                _COSTOS_VARIOS = value
            End Set
        End Property
        Public Property SUB_TOTAL As Double
            Get
                Return _SUB_TOTAL
            End Get
            Set(value As Double)
                _SUB_TOTAL = value
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
        Public Property COSTO_FINAL As Double
            Get
                Return _COSTO_FINAL
            End Get
            Set(value As Double)
                _COSTO_FINAL = value
            End Set
        End Property
    End Class

    Public Class PROCESO_COSTEO_PT_LINE

        Private _ID_CAB As Integer
        Private _ITEM_PT As Integer
        Private _ITEM As Integer
        Private _PART_ID As String
        Private _PART_DESCRIPTION As String
        Private _COSTO_UNITARIO As Double

        Public Property ID_CAB As Integer
            Get
                Return _ID_CAB
            End Get
            Set(value As Integer)
                _ID_CAB = value
            End Set
        End Property
        Public Property ITEM_PT As Integer
            Get
                Return _ITEM_PT
            End Get
            Set(value As Integer)
                _ITEM_PT = value
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
        Public Property COSTO_UNITARIO As Double
            Get
                Return _COSTO_UNITARIO
            End Get
            Set(value As Double)
                _COSTO_UNITARIO = value
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

        Private _STOCK_MINIMO As Double
        Private _STOCK_MAXIMO As Double
        Private _STOCK_PUNTO_PEDIDO As Double
        Private _PESO As Double
        Private _GROUP_ID As String

        Public Sub New()
            _GROUP_ID = ""
            _PESO = 0
            _STOCK_MINIMO = 0
            _STOCK_MAXIMO = 0
            _STOCK_PUNTO_PEDIDO = 0
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
        Public Property GROUP_ID As String
            Get
                Return _GROUP_ID
            End Get
            Set(value As String)
                _GROUP_ID = value
            End Set
        End Property

        Public Property PESO As Double
            Get
                Return _PESO
            End Get
            Set(value As Double)
                _PESO = value
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

    Public Class DATOS_ARCHIVO
        Private _ID_CAB As Integer
        Private _USER_ID As String
        Private _PC_ID As String
        Private _IP_PC As String
        Private _NOMBRE_ARCHIVO As String
        Private _ARCHIVO As Byte()
        Private _DES_ARCHIVO As String
        Private _ITEM As Integer

        Public Sub New()
            _NOMBRE_ARCHIVO = String.Empty
            _DES_ARCHIVO = String.Empty
        End Sub

        Public Property ITEM As Integer
            Get
                Return _ITEM
            End Get
            Set(value As Integer)
                _ITEM = value
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
        Public Property IP_PC As String
            Get
                Return _IP_PC
            End Get
            Set(value As String)
                _IP_PC = value
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
        Public Property ARCHIVO As Byte()
            Get
                Return _ARCHIVO
            End Get
            Set(value As Byte())
                _ARCHIVO = value
            End Set
        End Property
        Public Property DES_ARCHIVO As String
            Get
                Return _DES_ARCHIVO
            End Get
            Set(value As String)
                _DES_ARCHIVO = value
            End Set
        End Property
    End Class

    Public Class QUEJAS_RECLAMOS_ARCHIVOS

        Private _ID_CAB As String
        Private _ITEM As Integer
        Private _DESCRIPCION As String
        Private _ARCHIVO As Byte
        Private _NOMBRE_ARCHIVO As String

        Public Property ID_CAB As String
            Get
                Return _ID_CAB
            End Get
            Set(value As String)
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
        Public Property DESCRIPCION As String
            Get
                Return _DESCRIPCION
            End Get
            Set(value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Public Property ARCHIVO As Byte
            Get
                Return _ARCHIVO
            End Get
            Set(value As Byte)
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

    End Class


    Public Class QUEJAS_RECLAMOS
        Private _ID As Integer
        Private _FECHA As String
        Private _TIPO As String
        Private _COD_CLIENTE As String
        Private _CONTACTO As String
        Private _CARGO As String
        Private _CORREO_ELECTRONICO As String
        Private _TELEFONO As String
        Private _PRODUCTO As String
        Private _FECHA_ACONTECIMIENTO As String
        Private _REDACCION_HECHOS As String
        Private _SOLICITA_CLIENTE As String
        Private _ACCIONES_INMEDIATAS As String
        Private _ACCIONES_CORRECTIVAS As String
        Private _CONCLUSION As String
        Private _STATUS As String
        Private _USER_PC As String
        Private _PC_ID As String
        Private _NOMBRE_RESPONSABLE As String
        Private _CARGO_RESPONSABLE As String

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
        Public Property TIPO As String
            Get
                Return _TIPO
            End Get
            Set(value As String)
                _TIPO = value
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
        Public Property CONTACTO As String
            Get
                Return _CONTACTO
            End Get
            Set(value As String)
                _CONTACTO = value
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
        Public Property CORREO_ELECTRONICO As String
            Get
                Return _CORREO_ELECTRONICO
            End Get
            Set(value As String)
                _CORREO_ELECTRONICO = value
            End Set
        End Property
        Public Property TELEFONO As String
            Get
                Return _TELEFONO
            End Get
            Set(value As String)
                _TELEFONO = value
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
        Public Property FECHA_ACONTECIMIENTO As String
            Get
                Return _FECHA_ACONTECIMIENTO
            End Get
            Set(value As String)
                _FECHA_ACONTECIMIENTO = value
            End Set
        End Property
        Public Property REDACCION_HECHOS As String
            Get
                Return _REDACCION_HECHOS
            End Get
            Set(value As String)
                _REDACCION_HECHOS = value
            End Set
        End Property
        Public Property SOLICITA_CLIENTE As String
            Get
                Return _SOLICITA_CLIENTE
            End Get
            Set(value As String)
                _SOLICITA_CLIENTE = value
            End Set
        End Property
        Public Property ACCIONES_INMEDIATAS As String
            Get
                Return _ACCIONES_INMEDIATAS
            End Get
            Set(value As String)
                _ACCIONES_INMEDIATAS = value
            End Set
        End Property
        Public Property ACCIONES_CORRECTIVAS As String
            Get
                Return _ACCIONES_CORRECTIVAS
            End Get
            Set(value As String)
                _ACCIONES_CORRECTIVAS = value
            End Set
        End Property
        Public Property CONCLUSION As String
            Get
                Return _CONCLUSION
            End Get
            Set(value As String)
                _CONCLUSION = value
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
        Public Property USER_PC As String
            Get
                Return _USER_PC
            End Get
            Set(value As String)
                _USER_PC = value
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
        Public Property NOMBRE_RESPONSABLE As String
            Get
                Return _NOMBRE_RESPONSABLE
            End Get
            Set(value As String)
                _NOMBRE_RESPONSABLE = value
            End Set
        End Property
        Public Property CARGO_RESPONSABLE As String
            Get
                Return _CARGO_RESPONSABLE
            End Get
            Set(value As String)
                _CARGO_RESPONSABLE = value
            End Set
        End Property
    End Class


    Public Class GESTION_MUESTRAS_DESARROLLO
        Private _ID As Integer
        Private _FECHA As String
        Private _COD_CLIENTE As String
        Private _CONTACTO As String
        Private _VENDEDOR As String
        Private _FECHA_VISITA As String
        Private _NOMBRE_MUESTRA As String
        Private _CANTIDAD_MUESTRA As Double
        Private _CANTIDAD_PROYECTADA_VENTAS As Double
        Private _FECHA_ENVIO_MUESTRA As String
        Private _FECHA_RECEPCION_MUESTRA As String
        Private _ESTADO_MUESTRA As String
        Private _ESTADO_COMERCIAL As String
        Private _USER_PC As String
        Private _PC_ID As String
        Private _OBSERVACIONES As String
        Private _USO As String

        Private _FECHA_ENVIO As String
        Private _CODIGO_QI As String
        Private _CANTIDAD_M As String
        Public Property FECHA_ENVIO As String
            Get
                Return _FECHA_ENVIO
            End Get
            Set(value As String)
                _FECHA_ENVIO = value
            End Set
        End Property
        Public Property CODIGO_QI As String
            Get
                Return _CODIGO_QI
            End Get
            Set(value As String)
                _CODIGO_QI = value
            End Set
        End Property
        Public Property CANTIDAD_M As String
            Get
                Return _CANTIDAD_M
            End Get
            Set(value As String)
                _CANTIDAD_M = value
            End Set
        End Property

        Public Property USO As String
            Get
                Return _USO
            End Get
            Set(value As String)
                _USO = value
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
        Public Property COD_CLIENTE As String
            Get
                Return _COD_CLIENTE
            End Get
            Set(value As String)
                _COD_CLIENTE = value
            End Set
        End Property
        Public Property CONTACTO As String
            Get
                Return _CONTACTO
            End Get
            Set(value As String)
                _CONTACTO = value
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
        Public Property FECHA_VISITA As String
            Get
                Return _FECHA_VISITA
            End Get
            Set(value As String)
                _FECHA_VISITA = value
            End Set
        End Property
        Public Property NOMBRE_MUESTRA As String
            Get
                Return _NOMBRE_MUESTRA
            End Get
            Set(value As String)
                _NOMBRE_MUESTRA = value
            End Set
        End Property
        Public Property CANTIDAD_MUESTRA As Double
            Get
                Return _CANTIDAD_MUESTRA
            End Get
            Set(value As Double)
                _CANTIDAD_MUESTRA = value
            End Set
        End Property
        Public Property CANTIDAD_PROYECTADA_VENTAS As Double
            Get
                Return _CANTIDAD_PROYECTADA_VENTAS
            End Get
            Set(value As Double)
                _CANTIDAD_PROYECTADA_VENTAS = value
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
        Public Property FECHA_ENVIO_MUESTRA As String
            Get
                Return _FECHA_ENVIO_MUESTRA
            End Get
            Set(value As String)
                _FECHA_ENVIO_MUESTRA = value
            End Set
        End Property

        Public Property FECHA_RECEPCION_MUESTRA As String
            Get
                Return _FECHA_RECEPCION_MUESTRA
            End Get
            Set(value As String)
                _FECHA_RECEPCION_MUESTRA = value
            End Set
        End Property
        Public Property ESTADO_MUESTRA As String
            Get
                Return _ESTADO_MUESTRA
            End Get
            Set(value As String)
                _ESTADO_MUESTRA = value
            End Set
        End Property
        Public Property ESTADO_COMERCIAL As String
            Get
                Return _ESTADO_COMERCIAL
            End Get
            Set(value As String)
                _ESTADO_COMERCIAL = value
            End Set
        End Property
        Public Property USER_PC As String
            Get
                Return _USER_PC
            End Get
            Set(value As String)
                _USER_PC = value
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
    Public Class PRODUCCION_OP

        Private _ID As Integer
        Private _ID_CAB As Integer
        Private _FECHA As String
        Private _STATUS As String
        Private _PART_ID As String
        Private _DESCRIPCION As String
        Private _UNIDAD As String
        Private _CANTIDAD As Double
        Private _FACTOR As Double
        Private _COSTO As Double
        Private _TOTAL As Double
        Private _USER_ID As String
        Private _COD_CLIENTE As String
        Private _OBSERVACIONES As String
        Private _NUMERO_PEDIDO As String
        Private _ITEM_PEDIDO As String
        Private _ITEM As Integer
        Private _ITEM_PRODUCTO As Integer

        Private _FECHA_ENTREGA As String
        Private _VENDEDOR As String
        Private _DESTINATARIO As String
        Private _URGENTE As String
        Private _ID_REQUERIMIENTO As String
        Private _ITEM_REQUERIMIENTO As String

        Public Property DESCRIPCION As String
            Get
                Return _DESCRIPCION
            End Get
            Set(value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Public Property UNIDAD As String
            Get
                Return _UNIDAD
            End Get
            Set(value As String)
                _UNIDAD = value
            End Set
        End Property

        Public Property ITEM_REQUERIMIENTO As String
            Get
                Return _ITEM_REQUERIMIENTO
            End Get
            Set(value As String)
                _ITEM_REQUERIMIENTO = value
            End Set
        End Property
        Public Property ID_REQUERIMIENTO As String
            Get
                Return _ID_REQUERIMIENTO
            End Get
            Set(value As String)
                _ID_REQUERIMIENTO = value
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

        Public Property ID_CAB As Integer
            Get
                Return _ID_CAB
            End Get
            Set(value As Integer)
                _ID_CAB = value
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
        Private _ITEM_PRODUCTO As Integer
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
        Public Property ITEM_PRODUCTO As Integer
            Get
                Return _ITEM_PRODUCTO
            End Get
            Set(value As Integer)
                _ITEM_PRODUCTO = value
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
        Private _PLANEAMIENTO As String

        Public Property PLANEAMIENTO As String
            Get
                Return _PLANEAMIENTO
            End Get
            Set(value As String)
                _PLANEAMIENTO = value
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

    Public Class PRODUCCION_OP_LINE_PROCESOS

        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _ITEM_PRODUCTO As Integer
        Private _PROCESO As String
        Private _MAQUINA As String
        Private _INICIO As String
        Private _FIN As String

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
        Public Property ITEM_PRODUCTO As Integer
            Get
                Return _ITEM_PRODUCTO
            End Get
            Set(value As Integer)
                _ITEM_PRODUCTO = value
            End Set
        End Property
        Public Property PROCESO As String
            Get
                Return _PROCESO
            End Get
            Set(value As String)
                _PROCESO = value
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
        Public Property INICIO As String
            Get
                Return _INICIO
            End Get
            Set(value As String)
                _INICIO = value
            End Set
        End Property
        Public Property FIN As String
            Get
                Return _FIN
            End Get
            Set(value As String)
                _FIN = value
            End Set
        End Property

    End Class

    Public Class PRODUCCION_OP_LIQUIDACION

        Private _ID_CAB As Integer
        Private _ITEM As Integer
        Private _ITEM_PRODUCTO As Integer
        Private _TIPO As String
        Private _COSTO As Double
        Private _CANTIDAD As Double

        Private _WAREHOUSE_REF As String
        Private _DOCUMENT_REF As String
        Private _NUMBER_DOCUMENT_REF As String
        Private _FECHA_REF As String
        Private _USER_ID As String

        Public Property ID_CAB As Integer
            Get
                Return _ID_CAB
            End Get
            Set(value As Integer)
                _ID_CAB = value
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
        Public Property WAREHOUSE_REF As String
            Get
                Return _WAREHOUSE_REF
            End Get
            Set(value As String)
                _WAREHOUSE_REF = value
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
        Public Property NUMBER_DOCUMENT_REF As String
            Get
                Return _NUMBER_DOCUMENT_REF
            End Get
            Set(value As String)
                _NUMBER_DOCUMENT_REF = value
            End Set
        End Property
        Public Property FECHA_REF As String
            Get
                Return _FECHA_REF
            End Get
            Set(value As String)
                _FECHA_REF = value
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


    Public Class FORMULATION

        Private _ID As String
        Private _WHO_ID As String
        Private _DESCRIPTION As String
        Private _DOCUMENT_DATE As String
        Private _USER_ID As String
        Private _STATUS As String
        Private _COMMENT As String
        Private _MONEDA As String
        Private _TYPE_DOC As String
        Private _DESCARGA_TOTAL As String


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

        Public Property DESCRIPTION As String
            Get
                Return _DESCRIPTION
            End Get
            Set(value As String)
                _DESCRIPTION = value
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

        Public Property MONEDA As String
            Get
                Return _MONEDA
            End Get
            Set(value As String)
                _MONEDA = value
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

        Public Property DESCARGA_TOTAL As String
            Get
                Return _DESCARGA_TOTAL
            End Get
            Set(value As String)
                _DESCARGA_TOTAL = value
            End Set
        End Property

    End Class

    Public Class FORMULATION_LINE

        Private _ID As String
        Private _WHO_ID As String
        Private _ITEM As String
        Private _PART_ID As String
        Private _STATUS As String
        Private _TYPE As String
        Private _DESCRIPTION As String
        Private _SECUENCE As String
        Private _UNIT As String
        Private _DESCARGA_TOTAL As String

        Private _QTY As Double
        Private _AVERAGE_COST As Double
        Private _EQUIVALENCIA As Double
        Private _POR_EXCESO As Double
        Private _QTY_TEORICA As Double


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

        Public Property STATUS As String
            Get
                Return _STATUS
            End Get
            Set(value As String)
                _STATUS = value
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

        Public Property DESCRIPTION As String
            Get
                Return _DESCRIPTION
            End Get
            Set(value As String)
                _DESCRIPTION = value
            End Set
        End Property

        Public Property SECUENCE As String
            Get
                Return _SECUENCE
            End Get
            Set(value As String)
                _SECUENCE = value
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

        Public Property DESCARGA_TOTAL As String
            Get
                Return _DESCARGA_TOTAL
            End Get
            Set(value As String)
                _DESCARGA_TOTAL = value
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

        Public Property AVERAGE_COST As Double
            Get
                Return _AVERAGE_COST
            End Get
            Set(value As Double)
                _AVERAGE_COST = value
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

        Public Property POR_EXCESO As Double
            Get
                Return _POR_EXCESO
            End Get
            Set(value As Double)
                _POR_EXCESO = value
            End Set
        End Property

        Public Property QTY_TEORICA As Double
            Get
                Return _QTY_TEORICA
            End Get
            Set(value As Double)
                _QTY_TEORICA = value
            End Set
        End Property

    End Class

    Public Class FORMULATION_LINE_PROCESOS

        Private _ID As String
        Private _ITEM As Integer
        Private _PROCESO As String
        Private _MAQUINA As String

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
        Public Property PROCESO As String
            Get
                Return _PROCESO
            End Get
            Set(value As String)
                _PROCESO = value
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

    End Class
    Public Class LIQUIDACION_OP

        Private _ID As String
        Private _FECHA As String
        Private _USER_ID As String


        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
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


        Public Property USER_ID As String
            Get
                Return _USER_ID
            End Get
            Set(value As String)
                _USER_ID = value
            End Set
        End Property

    End Class

    Public Class LIQUIDACION_OP_LINE

        Private _ID As String
        Private _PART_ID As String
        Private _DESCRIPTION As String
        Private _UNIT As String
        Private _PART_ID_PRES As String
        Private _DESCRIPTION_PRES As String
        Private _UNIT_PRES As String
        Private _QTY As Double
        Private _AVERAGE_COST_PROM As Double
        Private _AVERAGE_COST_ULT As Double
        Private _AVERAGE_COST_PRES_PROM As Double
        Private _AVERAGE_COST_PRES_ULT As Double
        Private _WHO_PRES As String
        Private _AVERAGE_COST_TOTAL_PROM As Double
        Private _AVERAGE_COST_TOTAL_ULT As Double
        Private _WHO_INGRESO As String
        Private _WHO_DES_INGRESO As String
        Private _MONEDA As String
        Private _TIPO_LIQUIDACION As String

        Public Property TIPO_LIQUIDACION As String
            Get
                Return _TIPO_LIQUIDACION
            End Get
            Set(value As String)
                _TIPO_LIQUIDACION = value
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

        Public Property PART_ID_PRES As String
            Get
                Return _PART_ID_PRES
            End Get
            Set(value As String)
                _PART_ID_PRES = value
            End Set
        End Property

        Public Property DESCRIPTION_PRES As String
            Get
                Return _DESCRIPTION_PRES
            End Get
            Set(value As String)
                _DESCRIPTION_PRES = value
            End Set
        End Property

        Public Property UNIT_PRES As String
            Get
                Return _UNIT_PRES
            End Get
            Set(value As String)
                _UNIT_PRES = value
            End Set
        End Property

        Public Property WHO_PRES As String
            Get
                Return _WHO_PRES
            End Get
            Set(value As String)
                _WHO_PRES = value
            End Set
        End Property

        Public Property WHO_INGRESO As String
            Get
                Return _WHO_INGRESO
            End Get
            Set(value As String)
                _WHO_INGRESO = value
            End Set
        End Property

        Public Property WHO_DES_INGRESO As String
            Get
                Return _WHO_DES_INGRESO
            End Get
            Set(value As String)
                _WHO_DES_INGRESO = value
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

        Public Property QTY As Double
            Get
                Return _QTY
            End Get
            Set(value As Double)
                _QTY = value
            End Set
        End Property

        Public Property AVERAGE_COST_PROM As Double
            Get
                Return _AVERAGE_COST_PROM
            End Get
            Set(value As Double)
                _AVERAGE_COST_PROM = value
            End Set
        End Property

        Public Property AVERAGE_COST_ULT As Double
            Get
                Return _AVERAGE_COST_ULT
            End Get
            Set(value As Double)
                _AVERAGE_COST_ULT = value
            End Set
        End Property

        Public Property AVERAGE_COST_PRES_PROM As Double
            Get
                Return _AVERAGE_COST_PRES_PROM
            End Get
            Set(value As Double)
                _AVERAGE_COST_PRES_PROM = value
            End Set
        End Property

        Public Property AVERAGE_COST_PRES_ULT As Double
            Get
                Return _AVERAGE_COST_PRES_ULT
            End Get
            Set(value As Double)
                _AVERAGE_COST_PRES_ULT = value
            End Set
        End Property

        Public Property AVERAGE_COST_TOTAL_PROM As Double
            Get
                Return _AVERAGE_COST_TOTAL_PROM
            End Get
            Set(value As Double)
                _AVERAGE_COST_TOTAL_PROM = value
            End Set
        End Property

        Public Property AVERAGE_COST_TOTAL_ULT As Double
            Get
                Return _AVERAGE_COST_TOTAL_ULT
            End Get
            Set(value As Double)
                _AVERAGE_COST_TOTAL_ULT = value
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
End Class
