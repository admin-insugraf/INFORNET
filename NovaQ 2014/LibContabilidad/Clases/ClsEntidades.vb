Public Class ClsEntidades

    Public Class CO_TB_ASIENTO_CAB
        Private _AC_ID As Integer
        Private _AC_IDSUBDIARIO As String
        Private _AC_NUM_VOUCHER As String
        Private _AC_ANHO As Integer
        Private _AC_MES As Integer
        Private _AC_FEC_VOUCHER As String
        Private _AC_IDMONEDA As Integer
        Private _AC_DEBE As Double
        Private _AC_HABER As Double
        Private _AC_ESTADO As Integer
        Private _AC_GLOSA_VOU As String
        Private _AC_ES_INTERFACE As Integer
        Private _AC_IDPLANILLA As String
        Private _AC_RUC As String
        Private _AC_TIPO_DOC As String
        Private _AC_SER_DOC As String
        Private _AC_NUM_DOC As String
        Private _AC_FEC_DOC As Date
        Private _AC_FEC_DOC_VENCE As Date

        Private _AC_FEC_PLE As String
        Private _AC_FEC_DOC_REF As String

        Private _AC_POR_IGV As Double
        Private _AC_VAL_IGV As Double
        Private _AC_TOTAL_DOC As Double
        Private _AC_TIPO_CAMBIO As Double
        Private _AC_DETRAC As Double
        Private _AC_POR_ISC As Double
        Private _AC_ISC As Double
        Private _AC_POR_DETRAC As Double

        Private _AC_GLOSA_TRANSACCION As String
        Private _AC_DESTINO As String
        Private _AC_TIPO_DOC_REF As String
        Private _AC_SER_DOC_REF As String
        Private _AC_NUM_DOC_REF As String

        Private _AC_DUA As Integer
        Private _AC_OP_INAFECTA As Double
        Private _AC_OP_GRAVADA As Double

        Private _AC_ID_LETRA As String
        Private _AC_ID_PAGO As String
        Private _AC_ID_LETRA_PAGO As String
        Private _AC_ID_REGCOMPRA As String
        Private _AC_RECEIVABLE_TYPE As String

        Private _AC_TIPO_DOC_DETRAC As String
        Private _AC_SER_DOC_DETRAC As String
        Private _AC_NUM_DOC_DETRAC As String
        Private _AC_FEC_DOC_DETRAC As String

        Private _AC_NUMERO_CR As String


        Public Sub New()
            _AC_NUMERO_CR = String.Empty

            _AC_TIPO_DOC_DETRAC = String.Empty
            _AC_SER_DOC_DETRAC = String.Empty
            _AC_NUM_DOC_DETRAC = String.Empty
            _AC_FEC_DOC_DETRAC = String.Empty

            _AC_ID = 0
            _AC_RECEIVABLE_TYPE = String.Empty
            _AC_IDSUBDIARIO = String.Empty
            _AC_NUM_VOUCHER = 0
            _AC_ANHO = 0
            _AC_MES = 0
            _AC_FEC_VOUCHER = String.Empty
            _AC_IDMONEDA = 0
            _AC_DEBE = 0
            _AC_HABER = 0
            _AC_ESTADO = 0
            _AC_GLOSA_VOU = String.Empty
            _AC_ES_INTERFACE = 0
            _AC_IDPLANILLA = String.Empty
            _AC_ID_REGCOMPRA = String.Empty
        End Sub

        Public Property AC_NUMERO_CR As String
            Get
                Return _AC_NUMERO_CR
            End Get
            Set(value As String)
                _AC_NUMERO_CR = value
            End Set
        End Property

        Public Property AC_TIPO_DOC_DETRAC As String
            Get
                Return _AC_TIPO_DOC_DETRAC
            End Get
            Set(value As String)
                _AC_TIPO_DOC_DETRAC = value
            End Set
        End Property
        Public Property AC_SER_DOC_DETRAC As String
            Get
                Return _AC_SER_DOC_DETRAC
            End Get
            Set(value As String)
                _AC_SER_DOC_DETRAC = value
            End Set
        End Property
        Public Property AC_NUM_DOC_DETRAC As String
            Get
                Return _AC_NUM_DOC_DETRAC
            End Get
            Set(value As String)
                _AC_NUM_DOC_DETRAC = value
            End Set
        End Property

        Public Property AC_FEC_DOC_DETRAC As String
            Get
                Return _AC_FEC_DOC_DETRAC
            End Get
            Set(value As String)
                _AC_FEC_DOC_DETRAC = value
            End Set
        End Property

        Public Property AC_RECEIVABLE_TYPE As String
            Get
                Return _AC_RECEIVABLE_TYPE
            End Get
            Set(value As String)
                _AC_RECEIVABLE_TYPE = value
            End Set
        End Property

        Public Property AC_ID_REGCOMPRA As String
            Get
                Return _AC_ID_REGCOMPRA
            End Get
            Set(value As String)
                _AC_ID_REGCOMPRA = value
            End Set
        End Property

        Public Property AC_ID_LETRA_PAGO As String
            Get
                Return _AC_ID_LETRA_PAGO
            End Get
            Set(value As String)
                _AC_ID_LETRA_PAGO = value
            End Set
        End Property


        Public Property AC_ID_PAGO As String
            Get
                Return _AC_ID_PAGO
            End Get
            Set(value As String)
                _AC_ID_PAGO = value
            End Set
        End Property


        Public Property AC_ID_LETRA As String
            Get
                Return _AC_ID_LETRA
            End Get
            Set(value As String)
                _AC_ID_LETRA = value
            End Set
        End Property


        Public Property AC_OP_INAFECTA As Double
            Get
                Return _AC_OP_INAFECTA
            End Get
            Set(value As Double)
                _AC_OP_INAFECTA = value
            End Set
        End Property

        Public Property AC_OP_GRAVADA As Double
            Get
                Return _AC_OP_GRAVADA
            End Get
            Set(value As Double)
                _AC_OP_GRAVADA = value
            End Set
        End Property

        Public Property AC_DUA As Integer
            Get
                Return _AC_DUA
            End Get
            Set(value As Integer)
                _AC_DUA = value
            End Set
        End Property


        Public Property AC_RUC As String
            Get
                Return _AC_RUC
            End Get
            Set(value As String)
                _AC_RUC = value
            End Set
        End Property

        Public Property AC_TIPO_DOC As String
            Get
                Return _AC_TIPO_DOC
            End Get
            Set(value As String)
                _AC_TIPO_DOC = value
            End Set
        End Property

        Public Property AC_SER_DOC As String
            Get
                Return _AC_SER_DOC
            End Get
            Set(value As String)
                _AC_SER_DOC = value
            End Set
        End Property

        Public Property AC_NUM_DOC As String
            Get
                Return _AC_NUM_DOC
            End Get
            Set(value As String)
                _AC_NUM_DOC = value
            End Set
        End Property

        Public Property AC_FEC_DOC As Date
            Get
                Return _AC_FEC_DOC
            End Get
            Set(value As Date)
                _AC_FEC_DOC = value
            End Set
        End Property

        Public Property AC_FEC_DOC_VENCE As Date
            Get
                Return _AC_FEC_DOC_VENCE
            End Get
            Set(value As Date)
                _AC_FEC_DOC_VENCE = value
            End Set
        End Property

        Public Property AC_FEC_PLE As String

            Get
                Return _AC_FEC_PLE
            End Get
            Set(value As String)
                _AC_FEC_PLE = value
            End Set
        End Property

        Public Property AC_FEC_DOC_REF As String
            Get
                Return _AC_FEC_DOC_REF
            End Get
            Set(value As String)
                _AC_FEC_DOC_REF = value
            End Set
        End Property

        Public Property AC_POR_IGV As Double
            Get
                Return _AC_POR_IGV
            End Get
            Set(value As Double)
                _AC_POR_IGV = value
            End Set
        End Property

        Public Property AC_VAL_IGV As Double
            Get
                Return _AC_VAL_IGV
            End Get
            Set(value As Double)
                _AC_VAL_IGV = value
            End Set
        End Property


        Public Property AC_TOTAL_DOC As Double
            Get
                Return _AC_TOTAL_DOC
            End Get
            Set(value As Double)
                _AC_TOTAL_DOC = value
            End Set
        End Property

        Public Property AC_TIPO_CAMBIO As Double
            Get
                Return _AC_TIPO_CAMBIO
            End Get
            Set(value As Double)
                _AC_TIPO_CAMBIO = value
            End Set
        End Property

        Public Property AC_DETRAC As Double
            Get
                Return _AC_DETRAC
            End Get
            Set(value As Double)
                _AC_DETRAC = value
            End Set
        End Property

        Public Property AC_POR_ISC As Double
            Get
                Return _AC_POR_ISC
            End Get
            Set(value As Double)
                _AC_POR_ISC = value
            End Set
        End Property

        Public Property AC_ISC As Double
            Get
                Return _AC_ISC
            End Get
            Set(value As Double)
                _AC_ISC = value
            End Set
        End Property

        Public Property AC_POR_DETRAC As Double
            Get
                Return _AC_POR_DETRAC
            End Get
            Set(value As Double)
                _AC_POR_DETRAC = value
            End Set
        End Property

        Public Property AC_GLOSA_TRANSACCION As String
            Get
                Return _AC_GLOSA_TRANSACCION
            End Get
            Set(value As String)
                _AC_GLOSA_TRANSACCION = value
            End Set
        End Property

        Public Property AC_DESTINO As String
            Get
                Return _AC_DESTINO
            End Get
            Set(value As String)
                _AC_DESTINO = value
            End Set
        End Property

        Public Property AC_TIPO_DOC_REF As String
            Get
                Return _AC_TIPO_DOC_REF
            End Get
            Set(value As String)
                _AC_TIPO_DOC_REF = value
            End Set
        End Property

        Public Property AC_SER_DOC_REF As String
            Get
                Return _AC_SER_DOC_REF
            End Get
            Set(value As String)
                _AC_SER_DOC_REF = value
            End Set
        End Property

        Public Property AC_NUM_DOC_REF As String
            Get
                Return _AC_NUM_DOC_REF
            End Get
            Set(value As String)
                _AC_NUM_DOC_REF = value
            End Set
        End Property

        Public Property AC_IDPLANILLA As String
            Get
                Return _AC_IDPLANILLA
            End Get
            Set(value As String)
                _AC_IDPLANILLA = value
            End Set
        End Property

        Public Property AC_ID As Integer
            Get
                Return _AC_ID
            End Get
            Set(value As Integer)
                _AC_ID = value
            End Set
        End Property

        Public Property AC_IDSUBDIARIO As String
            Get
                Return _AC_IDSUBDIARIO
            End Get
            Set(value As String)
                _AC_IDSUBDIARIO = value
            End Set
        End Property

        Public Property AC_NUM_VOUCHER As String
            Get
                Return _AC_NUM_VOUCHER
            End Get
            Set(value As String)
                _AC_NUM_VOUCHER = value
            End Set
        End Property

        Public Property AC_ANHO As Integer
            Get
                Return _AC_ANHO
            End Get
            Set(value As Integer)
                _AC_ANHO = value
            End Set
        End Property

        Public Property AC_MES As Integer
            Get
                Return _AC_MES
            End Get
            Set(value As Integer)
                _AC_MES = value
            End Set
        End Property

        Public Property AC_FEC_VOUCHER As String
            Get
                Return _AC_FEC_VOUCHER
            End Get
            Set(value As String)
                _AC_FEC_VOUCHER = value
            End Set
        End Property

        Public Property AC_IDMONEDA As Integer
            Get
                Return _AC_IDMONEDA
            End Get
            Set(value As Integer)
                _AC_IDMONEDA = value
            End Set
        End Property

        Public Property AC_DEBE As Double
            Get
                Return _AC_DEBE
            End Get
            Set(value As Double)
                _AC_DEBE = value
            End Set
        End Property

        Public Property AC_HABER As Double
            Get
                Return _AC_HABER
            End Get
            Set(value As Double)
                _AC_HABER = value
            End Set
        End Property

        Public Property AC_ESTADO As Integer
            Get
                Return _AC_ESTADO
            End Get
            Set(value As Integer)
                _AC_ESTADO = value
            End Set
        End Property

        Public Property AC_GLOSA_VOU As String
            Get
                Return _AC_GLOSA_VOU
            End Get
            Set(value As String)
                _AC_GLOSA_VOU = value
            End Set
        End Property

        Public Property AC_ES_INTERFACE As Integer
            Get
                Return _AC_ES_INTERFACE
            End Get
            Set(value As Integer)
                _AC_ES_INTERFACE = value
            End Set
        End Property

    End Class

    Public Class RETENCIONES_GENERAL
        Private _RUC As String
        Private _SERIE_COMP As String
        Private _NUMERO_COMP As String
        Private _FECHA_COMP As String
        Private _IMPORTE_TOTAL_COMP As Double
        Private _TIPO As String
        Private _SERIE As String
        Private _NUMERO As String
        Private _FECHA_DOC As String
        Private _TOTAL_DOC As Double
        Private _POR_TRES_DOC As Double
        Private _MES As String
        Private _MES_INT As Integer
        Private _ANIO As Integer
        

        Public Sub New()
            _RUC = String.Empty
            _SERIE_COMP = String.Empty
            _NUMERO_COMP = String.Empty
            _FECHA_COMP = String.Empty
            _IMPORTE_TOTAL_COMP = 0.0
            _TIPO = String.Empty
            _SERIE = String.Empty
            _NUMERO = String.Empty
            _FECHA_DOC = String.Empty
            _TOTAL_DOC = 0.0
            _POR_TRES_DOC = 0.0
            _MES = String.Empty
            _MES_INT = 0
            _ANIO = 0
        End Sub

        Public Property RUC As String
            Get
                Return _RUC
            End Get
            Set(value As String)
                _RUC = value
            End Set
        End Property
        Public Property SERIE_COMP As String
            Get
                Return _SERIE_COMP
            End Get
            Set(value As String)
                _SERIE_COMP = value
            End Set
        End Property
        Public Property NUMERO_COMP As String
            Get
                Return _NUMERO_COMP
            End Get
            Set(value As String)
                _NUMERO_COMP = value
            End Set
        End Property
        Public Property FECHA_COMP As String
            Get
                Return _FECHA_COMP
            End Get
            Set(value As String)
                _FECHA_COMP = value
            End Set
        End Property

        Public Property IMPORTE_TOTAL_COMP As Double
            Get
                Return _IMPORTE_TOTAL_COMP
            End Get
            Set(value As Double)
                _IMPORTE_TOTAL_COMP = value
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
        Public Property SERIE As String
            Get
                Return _SERIE
            End Get
            Set(value As String)
                _SERIE = value
            End Set
        End Property
        Public Property NUMERO As String
            Get
                Return _NUMERO
            End Get
            Set(value As String)
                _NUMERO = value
            End Set
        End Property
        Public Property FECHA_DOC As String
            Get
                Return _FECHA_DOC
            End Get
            Set(value As String)
                _FECHA_DOC = value
            End Set
        End Property

        Public Property TOTAL_DOC As Double
            Get
                Return _TOTAL_DOC
            End Get
            Set(value As Double)
                _TOTAL_DOC = value
            End Set
        End Property
        Public Property POR_TRES_DOC As Double
            Get
                Return _POR_TRES_DOC
            End Get
            Set(value As Double)
                _POR_TRES_DOC = value
            End Set
        End Property

        Public Property MES As String
            Get
                Return _MES
            End Get
            Set(value As String)
                _MES = value
            End Set
        End Property

        Public Property MES_INT As Integer
            Get
                Return _MES_INT
            End Get
            Set(value As Integer)
                _MES_INT = value
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
        
    End Class

    Public Class CO_TB_ASIENTO_DET
        Private _AD_IDCAB As Integer
        Private _AD_SECUENCIA As Integer
        Private _AD_CUENTA As String
        Private _AD_CEN_COS As String
        Private _AD_TANEXO As Integer
        Private _AD_IDANEXO As String
        Private _AD_TDOC As String
        Private _AD_SDOC As String
        Private _AD_NDOC As String
        Private _AD_FDOC As String
        Private _AD_VDOC As String
        Private _AD_DEBE As Double
        Private _AD_HABER As Double
        Private _AD_TCAM As Double
        Private _AD_SEC_ORI_DES As Integer
        Private _AD_IDCC As String
        Private _AD_ES_DESTINO As Integer
        Private _AD_IDMEDIOPAGO As String
        Private _AD_MONTO_ORI As Double
        Private _AD_PORCE_DESTINO As Double
        Private _AD_ES_CONCI As Integer
        Private _AD_ANHO_CONI As Integer
        Private _AD_MES_CONCI As Integer
        Private _AD_ES_INAFECTO As Integer
        Private _AD_IDMONEDA As Integer
        Private _AD_TDOC_REF As String
        Private _AD_SDOC_REF As String
        Private _AD_NDOC_REF As String
        Private _AD_FDOC_REF As String
        Private _AD_VDOC_REF As String
        Private _AD_GLOSA As String
        Private _AD_PERCEN_DETRACC As String

        Public Sub New()
            _AD_IDCAB = 0
            _AD_SECUENCIA = 0
            _AD_CUENTA = String.Empty
            _AD_CEN_COS = String.Empty
            _AD_TANEXO = 0
            _AD_IDANEXO = String.Empty
            _AD_TDOC = String.Empty
            _AD_SDOC = String.Empty
            _AD_NDOC = String.Empty
            _AD_FDOC = String.Empty
            _AD_VDOC = String.Empty
            _AD_DEBE = 0
            _AD_HABER = 0
            _AD_TCAM = 0
            _AD_SEC_ORI_DES = 0
            _AD_IDCC = String.Empty
            _AD_ES_DESTINO = 0
            _AD_IDMEDIOPAGO = String.Empty
            _AD_MONTO_ORI = 0
            _AD_PORCE_DESTINO = 0
            _AD_ES_CONCI = 0
            _AD_ANHO_CONI = 0
            _AD_MES_CONCI = 0
            _AD_ES_INAFECTO = 0
            _AD_IDMONEDA = 0
            _AD_TDOC_REF = String.Empty
            _AD_SDOC_REF = String.Empty
            _AD_NDOC_REF = String.Empty
            _AD_FDOC_REF = String.Empty
            _AD_VDOC_REF = String.Empty
            _AD_GLOSA = String.Empty
        End Sub



        Public Property AD_PERCEN_DETRACC As Integer
            Get
                Return _AD_PERCEN_DETRACC
            End Get
            Set(value As Integer)
                _AD_PERCEN_DETRACC = value
            End Set
        End Property


        Public Property AD_IDCAB As Integer
            Get
                Return _AD_IDCAB
            End Get
            Set(value As Integer)
                _AD_IDCAB = value
            End Set
        End Property

        Public Property AD_SECUENCIA As Integer
            Get
                Return _AD_SECUENCIA
            End Get
            Set(value As Integer)
                _AD_SECUENCIA = value
            End Set
        End Property

        Public Property AD_CUENTA As String
            Get
                Return _AD_CUENTA
            End Get
            Set(value As String)
                _AD_CUENTA = value
            End Set
        End Property

        Public Property AD_CEN_COS As String
            Get
                Return _AD_CEN_COS
            End Get
            Set(value As String)
                _AD_CEN_COS = value
            End Set
        End Property

        Public Property AD_TANEXO As Integer
            Get
                Return _AD_TANEXO
            End Get
            Set(value As Integer)
                _AD_TANEXO = value
            End Set
        End Property

        Public Property AD_IDANEXO As String
            Get
                Return _AD_IDANEXO
            End Get
            Set(value As String)
                _AD_IDANEXO = value
            End Set
        End Property

        Public Property AD_TDOC As String
            Get
                Return _AD_TDOC
            End Get
            Set(value As String)
                _AD_TDOC = value
            End Set
        End Property

        Public Property AD_SDOC As String
            Get
                Return _AD_SDOC
            End Get
            Set(value As String)
                _AD_SDOC = value
            End Set
        End Property

        Public Property AD_NDOC As String
            Get
                Return _AD_NDOC
            End Get
            Set(value As String)
                _AD_NDOC = value
            End Set
        End Property

        Public Property AD_FDOC As String
            Get
                Return _AD_FDOC
            End Get
            Set(value As String)
                _AD_FDOC = value
            End Set
        End Property

        Public Property AD_VDOC As String
            Get
                Return _AD_VDOC
            End Get
            Set(value As String)
                _AD_VDOC = value
            End Set
        End Property

        Public Property AD_DEBE As Double
            Get
                Return _AD_DEBE
            End Get
            Set(value As Double)
                _AD_DEBE = value
            End Set
        End Property

        Public Property AD_HABER As Double
            Get
                Return _AD_HABER
            End Get
            Set(value As Double)
                _AD_HABER = value
            End Set
        End Property

        Public Property AD_TCAM As Double
            Get
                Return _AD_TCAM
            End Get
            Set(value As Double)
                _AD_TCAM = value
            End Set
        End Property

        Public Property AD_SEC_ORI_DES As Integer
            Get
                Return _AD_SEC_ORI_DES
            End Get
            Set(value As Integer)
                _AD_SEC_ORI_DES = value
            End Set
        End Property

        Public Property AD_IDCC As String
            Get
                Return _AD_IDCC
            End Get
            Set(value As String)
                _AD_IDCC = value
            End Set
        End Property

        Public Property AD_ES_DESTINO As Integer
            Get
                Return _AD_ES_DESTINO
            End Get
            Set(value As Integer)
                _AD_ES_DESTINO = value
            End Set
        End Property

        Public Property AD_IDMEDIOPAGO As String
            Get
                Return _AD_IDMEDIOPAGO
            End Get
            Set(value As String)
                _AD_IDMEDIOPAGO = value
            End Set
        End Property

        Public Property AD_MONTO_ORI As Double
            Get
                Return _AD_MONTO_ORI
            End Get
            Set(value As Double)
                _AD_MONTO_ORI = value
            End Set
        End Property

        Public Property AD_PORCE_DESTINO As Double
            Get
                Return _AD_PORCE_DESTINO
            End Get
            Set(value As Double)
                _AD_PORCE_DESTINO = value
            End Set
        End Property

        Public Property AD_ES_CONCI As Integer
            Get
                Return _AD_ES_CONCI
            End Get
            Set(value As Integer)
                _AD_ES_CONCI = value
            End Set
        End Property

        Public Property AD_ANHO_CONI As Integer
            Get
                Return _AD_ANHO_CONI
            End Get
            Set(value As Integer)
                _AD_ANHO_CONI = value
            End Set
        End Property

        Public Property AD_MES_CONCI As Integer
            Get
                Return _AD_MES_CONCI
            End Get
            Set(value As Integer)
                _AD_MES_CONCI = value
            End Set
        End Property

        Public Property AD_ES_INAFECTO As Integer
            Get
                Return _AD_ES_INAFECTO
            End Get
            Set(value As Integer)
                _AD_ES_INAFECTO = value
            End Set
        End Property

        Public Property AD_IDMONEDA As Integer
            Get
                Return _AD_IDMONEDA
            End Get
            Set(value As Integer)
                _AD_IDMONEDA = value
            End Set
        End Property

        Public Property AD_TDOC_REF As String
            Get
                Return _AD_TDOC_REF
            End Get
            Set(value As String)
                _AD_TDOC_REF = value
            End Set
        End Property

        Public Property AD_SDOC_REF As String
            Get
                Return _AD_SDOC_REF
            End Get
            Set(value As String)
                _AD_SDOC_REF = value
            End Set
        End Property

        Public Property AD_NDOC_REF As String
            Get
                Return _AD_NDOC_REF
            End Get
            Set(value As String)
                _AD_NDOC_REF = value
            End Set
        End Property

        Public Property AD_FDOC_REF As String
            Get
                Return _AD_FDOC_REF
            End Get
            Set(value As String)
                _AD_FDOC_REF = value
            End Set
        End Property

        Public Property AD_VDOC_REF As String
            Get
                Return _AD_VDOC_REF
            End Get
            Set(value As String)
                _AD_VDOC_REF = value
            End Set
        End Property

        Public Property AD_GLOSA As String
            Get
                Return _AD_GLOSA
            End Get
            Set(value As String)
                _AD_GLOSA = value
            End Set
        End Property

    End Class

    Public Class CO_TB_CODIGOS_TMP
        Private _CODIGO As String
        Private _PC As String

        Sub New(CODIGO_ As String, PC_ As String)
            _CODIGO = CODIGO_
            _PC = PC_
        End Sub

        Sub New()
            _CODIGO = String.Empty
            _PC = String.Empty
        End Sub

        Public Property CODIGO As String
            Get
                Return _CODIGO
            End Get
            Set(value As String)
                _CODIGO = value
            End Set
        End Property

        Public Property PC As String
            Get
                Return _PC
            End Get
            Set(value As String)
                _PC = value
            End Set
        End Property

    End Class

 
    Public Class CO_COMPRAS_CONCEPTOS_CABECERA
        Private _CO_CONCEPTO As String
        Private _CO_DESCRIPCION As String
        Private _CREATE_DATE As String
        Private _CREATE_USER As String
 
        Public Property CO_CONCEPTO As String
            Get
                Return _CO_CONCEPTO
            End Get
            Set(value As String)
                _CO_CONCEPTO = value
            End Set
        End Property

        Public Property CO_DESCRIPCION As String
            Get
                Return _CO_DESCRIPCION
            End Get
            Set(value As String)
                _CO_DESCRIPCION = value
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

        Public Property CREATE_USER As String
            Get
                Return _CREATE_USER
            End Get
            Set(value As String)
                _CREATE_USER = value
            End Set
        End Property

    End Class

    Public Class CO_COMPRAS_CONCEPTOS_DETALLE
        Private _CO_CONCEPTO As String
        Private _CO_ITEM As Integer
        Private _CO_CUENTA As String
        Private _CO_DESCRIPCION As String
 

        Public Property CO_CONCEPTO As String
            Get
                Return _CO_CONCEPTO
            End Get
            Set(value As String)
                _CO_CONCEPTO = value
            End Set
        End Property

        Public Property CO_DESCRIPCION As String
            Get
                Return _CO_DESCRIPCION
            End Get
            Set(value As String)
                _CO_DESCRIPCION = value
            End Set
        End Property

        Public Property CO_ITEM As Integer
            Get
                Return _CO_ITEM
            End Get
            Set(value As Integer)
                _CO_ITEM = value
            End Set
        End Property

        Public Property CO_CUENTA As String
            Get
                Return _CO_CUENTA
            End Get
            Set(value As String)
                _CO_CUENTA = value
            End Set
        End Property


 
    End Class


    Public Class CENTER_COST
        Dim _COST_CENTER_ID As String
        Dim _COST_CENTER_DESCRIPTION As String
        Dim _CREATE_DATE As Date
        Dim _IS_STATUS As String
        Dim _USER_ID As String
        Dim _LAST_MODIFY_DATE As Date
        Dim _COMPUTER_ID As String
        Dim _USER_MODIFIED As String
        Dim _NODE_ID As String
        Dim _NODE_KEY As String
        Dim _LEVEL_CCOST As String
        Dim _TYPE_MOV As Integer
        Dim _DESTINO_DEBE As String
        Dim _DESTINO_HABER As String

        Public Property COST_CENTER_ID As String
            Get
                Return _COST_CENTER_ID
            End Get
            Set(value As String)
                _COST_CENTER_ID = value
            End Set
        End Property

        Public Property COST_CENTER_DESCRIPTION As String
            Get
                Return _COST_CENTER_DESCRIPTION
            End Get
            Set(value As String)
                _COST_CENTER_DESCRIPTION = value
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

        Public Property IS_STATUS As String
            Get
                Return _IS_STATUS
            End Get
            Set(value As String)
                _IS_STATUS = value
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

        Public Property LAST_MODIFY_DATE As Date
            Get
                Return _LAST_MODIFY_DATE
            End Get
            Set(value As Date)
                _LAST_MODIFY_DATE = value
            End Set
        End Property

        Public Property COMPUTER_ID As String
            Get
                Return _COMPUTER_ID
            End Get
            Set(value As String)
                _COMPUTER_ID = value
            End Set
        End Property

        Public Property USER_MODIFIED As String
            Get
                Return _USER_MODIFIED
            End Get
            Set(value As String)
                _USER_MODIFIED = value
            End Set
        End Property

        Public Property NODE_ID As String
            Get
                Return _NODE_ID
            End Get
            Set(value As String)
                _NODE_ID = value
            End Set
        End Property

        Public Property NODE_KEY As String
            Get
                Return _NODE_KEY
            End Get
            Set(value As String)
                _NODE_KEY = value
            End Set
        End Property

        Public Property LEVEL_CCOST As String
            Get
                Return _LEVEL_CCOST
            End Get
            Set(value As String)
                _LEVEL_CCOST = value
            End Set
        End Property

        Public Property TYPE_MOV As Integer
            Get
                Return _TYPE_MOV
            End Get
            Set(value As Integer)
                _TYPE_MOV = value
            End Set
        End Property

        Public Property DESTINO_DEBE As String
            Get
                Return _DESTINO_DEBE
            End Get
            Set(value As String)
                _DESTINO_DEBE = value
            End Set
        End Property

        Public Property DESTINO_HABER As String
            Get
                Return _DESTINO_HABER
            End Get
            Set(value As String)
                _DESTINO_HABER = value
            End Set
        End Property

    End Class

    Public Class CUSTOMER_BALANCE_PAY

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

        Private _NUM_REF_ASIENTO As Integer
        Private _VOUCHER_REF_ASIENTO As String
        Private _FECHA_REF_ASIENTO As Date

        Private _OBS As String
        Private _NUM_ORDER_PAGO As String

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
            _OBS = String.Empty
            _NUM_ORDER_PAGO = String.Empty
        End Sub
        Public Property NUM_ORDER_PAGO As String
            Get
                Return _NUM_ORDER_PAGO
            End Get
            Set(value As String)
                _NUM_ORDER_PAGO = value
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

        Public Property NUM_REF_ASIENTO As Integer
            Get
                Return _NUM_REF_ASIENTO
            End Get
            Set(value As Integer)
                _NUM_REF_ASIENTO = value
            End Set
        End Property

        Public Property VOUCHER_REF_ASIENTO As String
            Get
                Return _VOUCHER_REF_ASIENTO
            End Get
            Set(value As String)
                _VOUCHER_REF_ASIENTO = value
            End Set
        End Property

        Public Property FECHA_REF_ASIENTO As Date
            Get
                Return _FECHA_REF_ASIENTO
            End Get
            Set(value As Date)
                _FECHA_REF_ASIENTO = value
            End Set
        End Property

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


    End Class

End Class
