Public Class ClsEntidades

    Public Class AF_MA_FAMI_CTA_CC
        Private _FC_IDFAMILIA As String
        Private _FC_NUM_CUENTA As String
        Private _FC_PORCE As Double

        Public Sub New()
            _FC_IDFAMILIA = String.Empty
            _FC_NUM_CUENTA = String.Empty
            _FC_PORCE = 0.0R
        End Sub

        Public Property FC_IDFAMILIA As String
            Get
                Return _FC_IDFAMILIA
            End Get
            Set(value As String)
                _FC_IDFAMILIA = value
            End Set
        End Property

        Public Property FC_NUM_CUENTA As String
            Get
                Return _FC_NUM_CUENTA
            End Get
            Set(value As String)
                _FC_NUM_CUENTA = value
            End Set
        End Property

        Public Property FC_PORCE As Double
            Get
                Return _FC_PORCE
            End Get
            Set(value As Double)
                _FC_PORCE = value
            End Set
        End Property

    End Class


    Public Class AF_PR_MANTE_D_DATOS
        Private _DD_IDFOLIO As Integer
        Private _DD_IDACTIVO As Integer
        Private _DD_ID As Integer
        Private _DD_VALOR As String

        Public Sub New()
            _DD_IDFOLIO = 0
            _DD_IDACTIVO = 0
            _DD_ID = 0
            _DD_VALOR = String.Empty
        End Sub

        Public Property DD_IDFOLIO As Integer
            Get
                Return _DD_IDFOLIO
            End Get
            Set(value As Integer)
                _DD_IDFOLIO = value
            End Set
        End Property

        Public Property DD_IDACTIVO As Integer
            Get
                Return _DD_IDACTIVO
            End Get
            Set(value As Integer)
                _DD_IDACTIVO = value
            End Set
        End Property

        Public Property DD_ID As Integer
            Get
                Return _DD_ID
            End Get
            Set(value As Integer)
                _DD_ID = value
            End Set
        End Property

        Public Property DD_VALOR As String
            Get
                Return _DD_VALOR
            End Get
            Set(value As String)
                _DD_VALOR = value
            End Set
        End Property

    End Class

    Public Class AF_PR_ACTIVO_MEJORA
        Private _AM_IDACTIVO As Integer
        Private _AM_SEC As Integer
        Private _AM_REF As String
        Private _AM_IDPROVE As String
        Private _AM_TDOC As String
        Private _AM_SDOC As String
        Private _AM_NDOC As String
        Private _AM_FDOC As String
        Private _AM_MDOC As Double
        Private _AM_IDMONEDA As String
        Private _AM_TCAM As Double
        Private _AM_IDTIPO_PAGO As String
        Private _AM_OBS As String
        Private _AM_TASA As Double
        Private _AM_FEC_REG As String
        Private _AM_USUARIO As String
        Private _AM_TERMINAL As String

        Public Sub New()
            _AM_IDACTIVO = 0
            _AM_SEC = 0
            _AM_REF = String.Empty
            _AM_IDPROVE = String.Empty
            _AM_TDOC = String.Empty
            _AM_SDOC = String.Empty
            _AM_NDOC = String.Empty
            _AM_FDOC = String.Empty
            _AM_MDOC = 0
            _AM_IDMONEDA = String.Empty
            _AM_TCAM = 0
            _AM_IDTIPO_PAGO = String.Empty
            _AM_OBS = String.Empty
            _AM_TASA = 0
            _AM_FEC_REG = String.Empty
            _AM_USUARIO = String.Empty
            _AM_TERMINAL = String.Empty
        End Sub

        Public Property AM_TDOC As String
            Get
                Return _AM_TDOC
            End Get
            Set(value As String)
                _AM_TDOC = value
            End Set
        End Property

        Public Property AM_REF As String
            Get
                Return _AM_REF
            End Get
            Set(value As String)
                _AM_REF = value
            End Set
        End Property

        Public Property AM_SEC As Integer
            Get
                Return _AM_SEC
            End Get
            Set(value As Integer)
                _AM_SEC = value
            End Set
        End Property

        Public Property AM_IDACTIVO As Integer
            Get
                Return _AM_IDACTIVO
            End Get
            Set(value As Integer)
                _AM_IDACTIVO = value
            End Set
        End Property

        Public Property AM_IDPROVE As String
            Get
                Return _AM_IDPROVE
            End Get
            Set(value As String)
                _AM_IDPROVE = value
            End Set
        End Property

        Public Property AM_SDOC As String
            Get
                Return _AM_SDOC
            End Get
            Set(value As String)
                _AM_SDOC = value
            End Set
        End Property

        Public Property AM_NDOC As String
            Get
                Return _AM_NDOC
            End Get
            Set(value As String)
                _AM_NDOC = value
            End Set
        End Property

        Public Property AM_FDOC As String
            Get
                Return _AM_FDOC
            End Get
            Set(value As String)
                _AM_FDOC = value
            End Set
        End Property

        Public Property AM_MDOC As Double
            Get
                Return _AM_MDOC
            End Get
            Set(value As Double)
                _AM_MDOC = value
            End Set
        End Property

        Public Property AM_IDMONEDA As String
            Get
                Return _AM_IDMONEDA
            End Get
            Set(value As String)
                _AM_IDMONEDA = value
            End Set
        End Property

        Public Property AM_TCAM As Double
            Get
                Return _AM_TCAM
            End Get
            Set(value As Double)
                _AM_TCAM = value
            End Set
        End Property

        Public Property AM_IDTIPO_PAGO As String
            Get
                Return _AM_IDTIPO_PAGO
            End Get
            Set(value As String)
                _AM_IDTIPO_PAGO = value
            End Set
        End Property

        Public Property AM_OBS As String
            Get
                Return _AM_OBS
            End Get
            Set(value As String)
                _AM_OBS = value
            End Set
        End Property

        Public Property AM_TASA As Double
            Get
                Return _AM_TASA
            End Get
            Set(value As Double)
                _AM_TASA = value
            End Set
        End Property

        Public Property AM_FEC_REG As String
            Get
                Return _AM_FEC_REG
            End Get
            Set(value As String)
                _AM_FEC_REG = value
            End Set
        End Property

        Public Property AM_USUARIO As String
            Get
                Return _AM_USUARIO
            End Get
            Set(value As String)
                _AM_USUARIO = value
            End Set
        End Property

        Public Property AM_TERMINAL As String
            Get
                Return _AM_TERMINAL
            End Get
            Set(value As String)
                _AM_TERMINAL = value
            End Set
        End Property

    End Class

    Public Class AF_MA_ACTIVO_FIC
        Private _AF_IDACTIVO As Integer
        Private _AF_SEC As Integer
        Private _AF_ARCHIVO As String
        Private _AF_FICHA As Byte()

        Public Sub New()
            _AF_IDACTIVO = 0
            _AF_SEC = 0
            _AF_ARCHIVO = String.Empty
            _AF_FICHA = Nothing
        End Sub

        Public Property AF_IDACTIVO As Integer
            Get
                Return _AF_IDACTIVO
            End Get
            Set(value As Integer)
                _AF_IDACTIVO = value
            End Set
        End Property

        Public Property AF_SEC As Integer
            Get
                Return _AF_SEC
            End Get
            Set(value As Integer)
                _AF_SEC = value
            End Set
        End Property

        Public Property AF_ARCHIVO As String
            Get
                Return _AF_ARCHIVO
            End Get
            Set(value As String)
                _AF_ARCHIVO = value
            End Set
        End Property

        Public Property AF_FICHA As Byte()
            Get
                Return _AF_FICHA
            End Get
            Set(value As Byte())
                _AF_FICHA = value
            End Set
        End Property


    End Class

    Public Class AF_MA_ACTIVO_IMG
        Private _AI_IDACTIVO As Integer
        Private _AI_IMG As Byte()
        Private _AI_NOM As String
        Private _AI_DES As String
        Private _AI_SEC As Integer
        Private _AI_FECREG As String

        Public Sub New()
            _AI_IDACTIVO = 0
            _AI_IMG = Nothing
            _AI_NOM = String.Empty
            _AI_DES = String.Empty
            _AI_SEC = 0
            _AI_FECREG = String.Empty
        End Sub

        Public Property AI_IDACTIVO As Integer
            Get
                Return _AI_IDACTIVO
            End Get
            Set(value As Integer)
                _AI_IDACTIVO = value
            End Set
        End Property

        Public Property AI_IMG As Byte()
            Get
                Return _AI_IMG
            End Get
            Set(value As Byte())
                _AI_IMG = value
            End Set
        End Property

        Public Property AI_NOM As String
            Get
                Return _AI_NOM
            End Get
            Set(value As String)
                _AI_NOM = value
            End Set
        End Property

        Public Property AI_DES As String
            Get
                Return _AI_DES
            End Get
            Set(value As String)
                _AI_DES = value
            End Set
        End Property

        Public Property AI_SEC As String
            Get
                Return _AI_SEC
            End Get
            Set(value As String)
                _AI_SEC = value
            End Set
        End Property

        Public Property AI_FECREG As String
            Get
                Return _AI_FECREG
            End Get
            Set(value As String)
                _AI_FECREG = value
            End Set
        End Property

    End Class

    Public Class AF_LT_TOMA_INV_C
        Private _TI_ID As Integer
        Private _TI_FECHA As String
        Private _TI_OBS As String
        Private _TI_ESTADO As Integer
        Private _TI_TERMINAL As String
        Private _TI_USUARIO As String
        Private _TI_FECREG As String
        Private _TI_FECHA_FIN As String
        Private _TI_IDRESPONSABLE As String


        Public Sub New()
            _TI_ID = 0
            _TI_FECHA = String.Empty
            _TI_OBS = String.Empty
            _TI_ESTADO = 0
            _TI_TERMINAL = String.Empty
            _TI_USUARIO = String.Empty
            _TI_FECREG = String.Empty
            _TI_FECHA_FIN = String.Empty
            _TI_IDRESPONSABLE = String.Empty
        End Sub

        Public Property TI_FECHA_FIN As String
            Get
                Return _TI_FECHA_FIN
            End Get
            Set(value As String)
                _TI_FECHA_FIN = value
            End Set
        End Property

        Public Property TI_IDRESPONSABLE As String
            Get
                Return _TI_IDRESPONSABLE
            End Get
            Set(value As String)
                _TI_IDRESPONSABLE = value
            End Set
        End Property

        Public Property TI_ID As Integer
            Get
                Return _TI_ID
            End Get
            Set(value As Integer)
                _TI_ID = value
            End Set
        End Property

        Public Property TI_FECHA As String
            Get
                Return _TI_FECHA
            End Get
            Set(value As String)
                _TI_FECHA = value
            End Set
        End Property

        Public Property TI_OBS As String
            Get
                Return _TI_OBS
            End Get
            Set(value As String)
                _TI_OBS = value
            End Set
        End Property

        Public Property TI_ESTADO As Integer
            Get
                Return _TI_ESTADO
            End Get
            Set(value As Integer)
                _TI_ESTADO = value
            End Set
        End Property

        Public Property TI_TERMINAL As String
            Get
                Return _TI_TERMINAL
            End Get
            Set(value As String)
                _TI_TERMINAL = value
            End Set
        End Property

        Public Property TI_USUARIO As String
            Get
                Return _TI_USUARIO
            End Get
            Set(value As String)
                _TI_USUARIO = value
            End Set
        End Property

        Public Property TI_FECREG As String
            Get
                Return _TI_FECREG
            End Get
            Set(value As String)
                _TI_FECREG = value
            End Set
        End Property

    End Class

    Public Class AF_LT_TOMA_INV_D
        Private _TD_IDCAB As Integer
        Private _TD_IDACTIVO As Integer
        Private _TD_ESTADO_INV As Integer
        Private _TD_IDUBICACION As String
        Private _TD_IDAREA As String
        Private _TD_IDEST_FIS As String
        Private _TD_IDRESPO As String
        Private _TD_IDIMG As Byte()
        Private _TD_COMENTARIOS As String

        Public Sub New()
            _TD_IDCAB = 0
            _TD_IDACTIVO = 0
            _TD_ESTADO_INV = 0
            _TD_IDUBICACION = String.Empty
            _TD_IDAREA = String.Empty
            _TD_IDEST_FIS = String.Empty
            _TD_IDRESPO = String.Empty
            _TD_IDIMG = Nothing
            _TD_COMENTARIOS = String.Empty
        End Sub

        Public Property TD_IDUBICACION As String
            Get
                Return _TD_IDUBICACION
            End Get
            Set(value As String)
                _TD_IDUBICACION = value
            End Set
        End Property

        Public Property TD_IDAREA As String
            Get
                Return _TD_IDAREA
            End Get
            Set(value As String)
                _TD_IDAREA = value
            End Set
        End Property

        Public Property TD_IDEST_FIS As String
            Get
                Return _TD_IDEST_FIS
            End Get
            Set(value As String)
                _TD_IDEST_FIS = value
            End Set
        End Property

        Public Property TD_IDRESPO As String
            Get
                Return _TD_IDRESPO
            End Get
            Set(value As String)
                _TD_IDRESPO = value
            End Set
        End Property

        Public Property TD_IDIMG As Byte()
            Get
                Return _TD_IDIMG
            End Get
            Set(value As Byte())
                _TD_IDIMG = value
            End Set
        End Property

        Public Property TD_COMENTARIOS As String
            Get
                Return _TD_COMENTARIOS
            End Get
            Set(value As String)
                _TD_COMENTARIOS = value
            End Set
        End Property

        Public Property TD_IDCAB As Integer
            Get
                Return _TD_IDCAB
            End Get
            Set(value As Integer)
                _TD_IDCAB = value
            End Set
        End Property

        Public Property TD_IDACTIVO As Integer
            Get
                Return _TD_IDACTIVO
            End Get
            Set(value As Integer)
                _TD_IDACTIVO = value
            End Set
        End Property

        Public Property TD_ESTADO_INV As Integer
            Get
                Return _TD_ESTADO_INV
            End Get
            Set(value As Integer)
                _TD_ESTADO_INV = value
            End Set
        End Property



    End Class

    Public Class AF_MA_RESPO_EJE
        Private _RE_ID As String
        Private _RE_DESCRIPCION As String

        Public Sub New()
            _RE_ID = String.Empty
            _RE_DESCRIPCION = String.Empty
        End Sub

        Public Property RE_ID As String
            Get
                Return _RE_ID
            End Get
            Set(value As String)
                _RE_ID = value
            End Set
        End Property

        Public Property RE_DESCRIPCION As String
            Get
                Return _RE_DESCRIPCION
            End Get
            Set(value As String)
                _RE_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class AF_PR_BAJA_ACTIVO
        Private _BA_IDACTIVO As Integer
        Private _BA_FECHA As String
        Private _BA_IDMOTIVO As String
        Private _BA_TIPO_DOC As String
        Private _BA_SER_DOC As String
        Private _BA_NUM_DOC As String
        Private _BA_PRECIO_VENTA As Double
        Private _BA_IDMONEDA As String
        Private _BA_FEC_VENTA As String
        Private _BA_IDCLIENTE As String
        Private _BA_OBS As String

        Public Sub New()
            _BA_IDACTIVO = 0
            _BA_FECHA = String.Empty
            _BA_IDMOTIVO = String.Empty
            _BA_TIPO_DOC = String.Empty
            _BA_SER_DOC = String.Empty
            _BA_NUM_DOC = String.Empty
            _BA_PRECIO_VENTA = 0.0R
            _BA_IDMONEDA = String.Empty
            _BA_FEC_VENTA = String.Empty
            _BA_IDCLIENTE = String.Empty
            _BA_OBS = String.Empty
        End Sub

        Public Property BA_IDACTIVO As Integer
            Get
                Return _BA_IDACTIVO
            End Get
            Set(value As Integer)
                _BA_IDACTIVO = value
            End Set
        End Property

        Public Property BA_FECHA As String
            Get
                Return _BA_FECHA
            End Get
            Set(value As String)
                _BA_FECHA = value
            End Set
        End Property

        Public Property BA_IDMOTIVO As String
            Get
                Return _BA_IDMOTIVO
            End Get
            Set(value As String)
                _BA_IDMOTIVO = value
            End Set
        End Property

        Public Property BA_TIPO_DOC As String
            Get
                Return _BA_TIPO_DOC
            End Get
            Set(value As String)
                _BA_TIPO_DOC = value
            End Set
        End Property

        Public Property BA_SER_DOC As String
            Get
                Return _BA_SER_DOC
            End Get
            Set(value As String)
                _BA_SER_DOC = value
            End Set
        End Property

        Public Property BA_NUM_DOC As String
            Get
                Return _BA_NUM_DOC
            End Get
            Set(value As String)
                _BA_NUM_DOC = value
            End Set
        End Property

        Public Property BA_PRECIO_VENTA As Double
            Get
                Return _BA_PRECIO_VENTA
            End Get
            Set(value As Double)
                _BA_PRECIO_VENTA = value
            End Set
        End Property

        Public Property BA_IDMONEDA As String
            Get
                Return _BA_IDMONEDA
            End Get
            Set(value As String)
                _BA_IDMONEDA = value
            End Set
        End Property

        Public Property BA_FEC_VENTA As String
            Get
                Return _BA_FEC_VENTA
            End Get
            Set(value As String)
                _BA_FEC_VENTA = value
            End Set
        End Property

        Public Property BA_IDCLIENTE As String
            Get
                Return _BA_IDCLIENTE
            End Get
            Set(value As String)
                _BA_IDCLIENTE = value
            End Set
        End Property

        Public Property BA_OBS As String
            Get
                Return _BA_OBS
            End Get
            Set(value As String)
                _BA_OBS = value
            End Set
        End Property

    End Class

    Public Class AF_MA_MOTIVO_BAJA
        Private _MB_ID As String
        Private _MB_DESCRIPCION As String
        Private _MB_ESTADO As Integer

        Public Sub New()
            _MB_ID = String.Empty
            _MB_DESCRIPCION = String.Empty
            _MB_ESTADO = 0
        End Sub

        Public Property MB_ID As String
            Get
                Return _MB_ID
            End Get
            Set(value As String)
                _MB_ID = value
            End Set
        End Property

        Public Property MB_DESCRIPCION As String
            Get
                Return _MB_DESCRIPCION
            End Get
            Set(value As String)
                _MB_DESCRIPCION = value
            End Set
        End Property

        Public Property MB_ESTADO As Integer
            Get
                Return _MB_ESTADO
            End Get
            Set(value As Integer)
                _MB_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_PR_MANTE_D
        Private _MD_IDFOLIO As Integer
        Private _MD_IDACTIVO As Integer
        Private _MD_FEC_INI As String
        Private _MD_FEC_FIN As String
        Private _MD_HOR_INI As String
        Private _MD_HOR_FIN As String
        Private _MD_IDRESPO_ACTIVO As String
        Private _MD_IDAREA As String
        Private _MD_IDEJECUTOR As String
        Private _MD_OBS As String
        Private _MD_IMG_ANT As Byte()
        Private _MD_IMG_DES As Byte()

        Public Sub New()
            _MD_IDFOLIO = 0
            _MD_IDACTIVO = 0
            _MD_FEC_INI = String.Empty
            _MD_FEC_FIN = String.Empty
            _MD_HOR_INI = String.Empty
            _MD_HOR_FIN = String.Empty
            _MD_IDRESPO_ACTIVO = String.Empty
            _MD_IDAREA = String.Empty
            _MD_IDEJECUTOR = String.Empty
            _MD_OBS = String.Empty
            _MD_IMG_ANT = Nothing
            _MD_IMG_DES = Nothing
        End Sub

        Public Property MD_IMG_ANT As Byte()
            Get
                Return _MD_IMG_ANT
            End Get
            Set(value As Byte())
                _MD_IMG_ANT = value
            End Set
        End Property

        Public Property MD_IMG_DES As Byte()
            Get
                Return _MD_IMG_DES
            End Get
            Set(value As Byte())
                _MD_IMG_DES = value
            End Set
        End Property

        Public Property MD_IDFOLIO As Integer
            Get
                Return _MD_IDFOLIO
            End Get
            Set(value As Integer)
                _MD_IDFOLIO = value
            End Set
        End Property

        Public Property MD_IDACTIVO As Integer
            Get
                Return _MD_IDACTIVO
            End Get
            Set(value As Integer)
                _MD_IDACTIVO = value
            End Set
        End Property

        Public Property MD_FEC_INI As String
            Get
                Return _MD_FEC_INI
            End Get
            Set(value As String)
                _MD_FEC_INI = value
            End Set
        End Property

        Public Property MD_FEC_FIN As String
            Get
                Return _MD_FEC_FIN
            End Get
            Set(value As String)
                _MD_FEC_FIN = value
            End Set
        End Property

        Public Property MD_HOR_INI As String
            Get
                Return _MD_HOR_INI
            End Get
            Set(value As String)
                _MD_HOR_INI = value
            End Set
        End Property

        Public Property MD_HOR_FIN As String
            Get
                Return _MD_HOR_FIN
            End Get
            Set(value As String)
                _MD_HOR_FIN = value
            End Set
        End Property

        Public Property MD_IDRESPO_ACTIVO As String
            Get
                Return _MD_IDRESPO_ACTIVO
            End Get
            Set(value As String)
                _MD_IDRESPO_ACTIVO = value
            End Set
        End Property

        Public Property MD_IDAREA As String
            Get
                Return _MD_IDAREA
            End Get
            Set(value As String)
                _MD_IDAREA = value
            End Set
        End Property

        Public Property MD_IDEJECUTOR As String
            Get
                Return _MD_IDEJECUTOR
            End Get
            Set(value As String)
                _MD_IDEJECUTOR = value
            End Set
        End Property

        Public Property MD_OBS As String
            Get
                Return _MD_OBS
            End Get
            Set(value As String)
                _MD_OBS = value
            End Set
        End Property

    End Class

    Public Class AF_PR_MANTE_C
        Private _MA_ID As Integer
        Private _MA_FEC_INI As String
        Private _MA_FEC_FIN As String
        Private _MA_IDTIPO_MANTE As String
        Private _MA_OBS As String
        Private _MA_IDTIPO_EJECUTOR As String
        Private _MA_IDRESPO_EJECU As String
        Private _MA_IDTERCERO_EJECU As String
        Private _MA_ESTADO As Integer
        Private _MA_USUARIO As String
        Private _MA_TERMINAL As String
        Private _MA_FECREG As String

        Public Sub New()
            _MA_ID = 0
            _MA_FEC_INI = String.Empty
            _MA_FEC_FIN = String.Empty
            _MA_IDTIPO_MANTE = String.Empty
            _MA_OBS = String.Empty
            _MA_IDTIPO_EJECUTOR = String.Empty
            _MA_IDRESPO_EJECU = String.Empty
            _MA_IDTERCERO_EJECU = String.Empty
            _MA_ESTADO = 0
            _MA_USUARIO = String.Empty
            _MA_TERMINAL = String.Empty
            _MA_FECREG = String.Empty
        End Sub

        Public Property MA_ID As Integer
            Get
                Return _MA_ID
            End Get
            Set(value As Integer)
                _MA_ID = value
            End Set
        End Property

        Public Property MA_FEC_INI As String
            Get
                Return _MA_FEC_INI
            End Get
            Set(value As String)
                _MA_FEC_INI = value
            End Set
        End Property

        Public Property MA_FEC_FIN As String
            Get
                Return _MA_FEC_FIN
            End Get
            Set(value As String)
                _MA_FEC_FIN = value
            End Set
        End Property

        Public Property MA_IDTIPO_MANTE As String
            Get
                Return _MA_IDTIPO_MANTE
            End Get
            Set(value As String)
                _MA_IDTIPO_MANTE = value
            End Set
        End Property

        Public Property MA_OBS As String
            Get
                Return _MA_OBS
            End Get
            Set(value As String)
                _MA_OBS = value
            End Set
        End Property

        Public Property MA_IDTIPO_EJECUTOR As String
            Get
                Return _MA_IDTIPO_EJECUTOR
            End Get
            Set(value As String)
                _MA_IDTIPO_EJECUTOR = value
            End Set
        End Property

        Public Property MA_IDRESPO_EJECU As String
            Get
                Return _MA_IDRESPO_EJECU
            End Get
            Set(value As String)
                _MA_IDRESPO_EJECU = value
            End Set
        End Property

        Public Property MA_IDTERCERO_EJECU As String
            Get
                Return _MA_IDTERCERO_EJECU
            End Get
            Set(value As String)
                _MA_IDTERCERO_EJECU = value
            End Set
        End Property

        Public Property MA_ESTADO As Integer
            Get
                Return _MA_ESTADO
            End Get
            Set(value As Integer)
                _MA_ESTADO = value
            End Set
        End Property

        Public Property MA_USUARIO As String
            Get
                Return _MA_USUARIO
            End Get
            Set(value As String)
                _MA_USUARIO = value
            End Set
        End Property

        Public Property MA_TERMINAL As String
            Get
                Return _MA_TERMINAL
            End Get
            Set(value As String)
                _MA_TERMINAL = value
            End Set
        End Property

        Public Property MA_FECREG As String
            Get
                Return _MA_FECREG
            End Get
            Set(value As String)
                _MA_FECREG = value
            End Set
        End Property

    End Class

    Public Class AF_MA_TIPO_MANTE
        Private _TM_ID As String
        Private _TM_DESCRIPCION As String
        Private _TM_ESTADO As Integer

        Public Sub New()
            _TM_ID = String.Empty
            _TM_DESCRIPCION = String.Empty
            _TM_ESTADO = 0
        End Sub

        Public Property TM_ID As String
            Get
                Return _TM_ID
            End Get
            Set(value As String)
                _TM_ID = value
            End Set
        End Property

        Public Property TM_DESCRIPCION As String
            Get
                Return _TM_DESCRIPCION
            End Get
            Set(value As String)
                _TM_DESCRIPCION = value
            End Set
        End Property

        Public Property TM_ESTADO As Integer
            Get
                Return _TM_ESTADO
            End Get
            Set(value As Integer)
                _TM_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_TERCE_EJE
        Private _TE_ID As String
        Private _TE_DESCRIPCION As String
        Private _TE_ESTADO As Integer

        Public Sub New()
            _TE_ID = String.Empty
            _TE_DESCRIPCION = String.Empty
            _TE_ESTADO = 0
        End Sub

        Public Property TE_ID As String
            Get
                Return _TE_ID
            End Get
            Set(value As String)
                _TE_ID = value
            End Set
        End Property

        Public Property TE_DESCRIPCION As String
            Get
                Return _TE_DESCRIPCION
            End Get
            Set(value As String)
                _TE_DESCRIPCION = value
            End Set
        End Property

        Public Property TE_ESTADO As Integer
            Get
                Return _TE_ESTADO
            End Get
            Set(value As Integer)
                _TE_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_RESPO_ACTI
        Private _RA_ID As String
        Private _RA_DESCRIPCION As String
        Private _RA_ESTADO As Integer

        Public Sub New()
            _RA_ID = String.Empty
            _RA_DESCRIPCION = String.Empty
            _RA_ESTADO = 0
        End Sub

        Public Property RA_ID As String
            Get
                Return _RA_ID
            End Get
            Set(value As String)
                _RA_ID = value
            End Set
        End Property

        Public Property RA_DESCRIPCION As String
            Get
                Return _RA_DESCRIPCION
            End Get
            Set(value As String)
                _RA_DESCRIPCION = value
            End Set
        End Property

        Public Property RA_ESTADO As Integer
            Get
                Return _RA_ESTADO
            End Get
            Set(value As Integer)
                _RA_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_PR_TRANSFE_D
        Private _TD_IDFOLIO As Integer
        Private _TD_IDACTIVO As Integer

        Public Sub New()
            _TD_IDFOLIO = 0
            _TD_IDACTIVO = 0
        End Sub

        Public Property TD_IDFOLIO As Integer
            Get
                Return _TD_IDFOLIO
            End Get
            Set(value As Integer)
                _TD_IDFOLIO = value
            End Set
        End Property

        Public Property TD_IDACTIVO As Integer
            Get
                Return _TD_IDACTIVO
            End Get
            Set(value As Integer)
                _TD_IDACTIVO = value
            End Set
        End Property

    End Class

    Public Class AF_PR_TRANSFE_C
        Private _TR_IDFOLIO As Integer
        Private _TR_FECHA_TR As String
        Private _TR_IDAREA_ORI As String
        Private _TR_IDAREA_DES As String
        Private _TR_OBS As String
        Private _TR_USUARIO As String
        Private _TR_TERMINAL As String
        Private _TR_FECREG As String
        Private _TR_IDRESPO_ACTI As String

        Public Sub New()
            _TR_IDFOLIO = 0
            _TR_FECHA_TR = String.Empty
            _TR_IDAREA_ORI = String.Empty
            _TR_IDAREA_DES = String.Empty
            _TR_OBS = String.Empty
            _TR_USUARIO = String.Empty
            _TR_TERMINAL = String.Empty
            _TR_FECREG = String.Empty
            _TR_IDRESPO_ACTI = String.Empty
        End Sub

        Public Property TR_IDRESPO_ACTI As String
            Get
                Return _TR_IDRESPO_ACTI
            End Get
            Set(value As String)
                _TR_IDRESPO_ACTI = value
            End Set
        End Property

        Public Property TR_IDFOLIO As Integer
            Get
                Return _TR_IDFOLIO
            End Get
            Set(value As Integer)
                _TR_IDFOLIO = value
            End Set
        End Property

        Public Property TR_FECHA_TR As String
            Get
                Return _TR_FECHA_TR
            End Get
            Set(value As String)
                _TR_FECHA_TR = value
            End Set
        End Property

        Public Property TR_IDAREA_ORI As String
            Get
                Return _TR_IDAREA_ORI
            End Get
            Set(value As String)
                _TR_IDAREA_ORI = value
            End Set
        End Property

        Public Property TR_IDAREA_DES As String
            Get
                Return _TR_IDAREA_DES
            End Get
            Set(value As String)
                _TR_IDAREA_DES = value
            End Set
        End Property

        Public Property TR_OBS As String
            Get
                Return _TR_OBS
            End Get
            Set(value As String)
                _TR_OBS = value
            End Set
        End Property

        Public Property TR_USUARIO As String
            Get
                Return _TR_USUARIO
            End Get
            Set(value As String)
                _TR_USUARIO = value
            End Set
        End Property

        Public Property TR_TERMINAL As String
            Get
                Return _TR_TERMINAL
            End Get
            Set(value As String)
                _TR_TERMINAL = value
            End Set
        End Property

        Public Property TR_FECREG As String
            Get
                Return _TR_FECREG
            End Get
            Set(value As String)
                _TR_FECREG = value
            End Set
        End Property


    End Class

    Public Class AF_MA_USO
        Private _US_ID As String
        Private _US_DESCRIPCION As String
        Private _US_ESTADO As Integer

        Public Sub New()
            _US_ID = String.Empty
            _US_DESCRIPCION = String.Empty
            _US_ESTADO = 0
        End Sub

        Public Property US_ID As String
            Get
                Return _US_ID
            End Get
            Set(value As String)
                _US_ID = value
            End Set
        End Property

        Public Property US_DESCRIPCION As String
            Get
                Return _US_DESCRIPCION
            End Get
            Set(value As String)
                _US_DESCRIPCION = value
            End Set
        End Property

        Public Property US_ESTADO As Integer
            Get
                Return _US_ESTADO
            End Get
            Set(value As Integer)
                _US_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_UBICACION
        Private _UB_ID As String
        Private _UB_DESCRIPCION As String
        Private _UB_ESTADO As Integer

        Public Sub New()
            _UB_ID = String.Empty
            _UB_DESCRIPCION = String.Empty
            _UB_ESTADO = 0
        End Sub

        Public Property UB_ID As String
            Get
                Return _UB_ID
            End Get
            Set(value As String)
                _UB_ID = value
            End Set
        End Property

        Public Property UB_DESCRIPCION As String
            Get
                Return _UB_DESCRIPCION
            End Get
            Set(value As String)
                _UB_DESCRIPCION = value
            End Set
        End Property

        Public Property UB_ESTADO As Integer
            Get
                Return _UB_ESTADO
            End Get
            Set(value As Integer)
                _UB_ESTADO = value
            End Set
        End Property
    End Class

    Public Class AF_MA_TIPOPAGO
        Private _TP_ID As String
        Private _TP_DESCRIPCION As String
        Private _TP_ESTADO As Integer

        Public Sub New()
            _TP_ID = String.Empty
            _TP_DESCRIPCION = String.Empty
            _TP_ESTADO = 0
        End Sub

        Public Property TP_ID As String
            Get
                Return _TP_ID
            End Get
            Set(value As String)
                _TP_ID = value
            End Set
        End Property

        Public Property TP_DESCRIPCION As String
            Get
                Return _TP_DESCRIPCION
            End Get
            Set(value As String)
                _TP_DESCRIPCION = value
            End Set
        End Property

        Public Property TP_ESTADO As Integer
            Get
                Return _TP_ESTADO
            End Get
            Set(value As Integer)
                _TP_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_MARCA
        Private _MA_ID As String
        Private _MA_DESCRIPCION As String
        Private _MA_ESTADO As Integer

        Public Sub New()
            _MA_ID = String.Empty
            _MA_DESCRIPCION = String.Empty
            _MA_ESTADO = 0
        End Sub

        Public Property MA_ID As String
            Get
                Return _MA_ID
            End Get
            Set(value As String)
                _MA_ID = value
            End Set
        End Property

        Public Property MA_DESCRIPCION As String
            Get
                Return _MA_DESCRIPCION
            End Get
            Set(value As String)
                _MA_DESCRIPCION = value
            End Set
        End Property

        Public Property MA_ESTADO As Integer
            Get
                Return _MA_ESTADO
            End Get
            Set(value As Integer)
                _MA_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_CLASE
        Private _CL_ID As String
        Private _CL_DESCRIPCION As String
        Private _CL_ESTADO As Integer

        Public Sub New()
            _CL_ID = String.Empty
            _CL_DESCRIPCION = String.Empty
            _CL_ESTADO = 0
        End Sub

        Public Property CL_ID As String
            Get
                Return _CL_ID
            End Get
            Set(value As String)
                _CL_ID = value
            End Set
        End Property

        Public Property CL_DESCRIPCION As String
            Get
                Return _CL_DESCRIPCION
            End Get
            Set(value As String)
                _CL_DESCRIPCION = value
            End Set
        End Property

        Public Property CL_ESTADO As Integer
            Get
                Return _CL_ESTADO
            End Get
            Set(value As Integer)
                _CL_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_CENCOS
        Private _CC_ID As String
        Private _CC_DESCRIPCION As String
        Private _CC_ESTADO As Integer

        Public Sub New()
            _CC_ID = String.Empty
            _CC_DESCRIPCION = String.Empty
            _CC_ESTADO = 0
        End Sub

        Public Property CC_ID As String
            Get
                Return _CC_ID
            End Get
            Set(value As String)
                _CC_ID = value
            End Set
        End Property

        Public Property CC_DESCRIPCION As String
            Get
                Return _CC_DESCRIPCION
            End Get
            Set(value As String)
                _CC_DESCRIPCION = value
            End Set
        End Property

        Public Property CC_ESTADO As Integer
            Get
                Return _CC_ESTADO
            End Get
            Set(value As Integer)
                _CC_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_AREA
        Private _AR_ID As String
        Private _AR_DESCRIPCION As String
        Private _AR_ESTADO As Integer

        Public Sub New()
            _AR_ID = String.Empty
            _AR_DESCRIPCION = String.Empty
            _AR_ESTADO = 0
        End Sub

        Public Property AR_ID As String
            Get
                Return _AR_ID
            End Get
            Set(value As String)
                _AR_ID = value
            End Set
        End Property

        Public Property AR_DESCRIPCION As String
            Get
                Return _AR_DESCRIPCION
            End Get
            Set(value As String)
                _AR_DESCRIPCION = value
            End Set
        End Property

        Public Property AR_ESTADO As Integer
            Get
                Return _AR_ESTADO
            End Get
            Set(value As Integer)
                _AR_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_NIVEL_OBSO
        Private _NO_ID As String
        Private _NO_DESCRIPCION As String
        Private _NO_ESTADO As Integer

        Public Sub New()
            _NO_ID = String.Empty
            _NO_DESCRIPCION = String.Empty
            _NO_ESTADO = 0
        End Sub

        Public Property NO_ID As String
            Get
                Return _NO_ID
            End Get
            Set(value As String)
                _NO_ID = value
            End Set
        End Property

        Public Property NO_DESCRIPCION As String
            Get
                Return _NO_DESCRIPCION
            End Get
            Set(value As String)
                _NO_DESCRIPCION = value
            End Set
        End Property

        Public Property NO_ESTADO As Integer
            Get
                Return _NO_ESTADO
            End Get
            Set(value As Integer)
                _NO_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_ESTADO_FISICO
        Private _EF_ID As String
        Private _EF_DESCRIPCION As String
        Private _EF_ESTADO As Integer

        Public Sub New()
            _EF_ID = String.Empty
            _EF_DESCRIPCION = String.Empty
            _EF_ESTADO = 0
        End Sub

        Public Property EF_ID As String
            Get
                Return _EF_ID
            End Get
            Set(value As String)
                _EF_ID = value
            End Set
        End Property

        Public Property EF_DESCRIPCION As String
            Get
                Return _EF_DESCRIPCION
            End Get
            Set(value As String)
                _EF_DESCRIPCION = value
            End Set
        End Property

        Public Property EF_ESTADO As Integer
            Get
                Return _EF_ESTADO
            End Get
            Set(value As Integer)
                _EF_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_SUBGRUPO
        Private _SG_ID As String
        Private _SG_DESCRIPCION As String
        Private _SG_IDGRUPO As String
        Private _SG_ESTADO As Integer

        Public Sub New()
            _SG_ID = String.Empty
            _SG_DESCRIPCION = String.Empty
            _SG_IDGRUPO = String.Empty
            _SG_ESTADO = 0
        End Sub

        Public Property SG_ID As String
            Get
                Return _SG_ID
            End Get
            Set(value As String)
                _SG_ID = value
            End Set
        End Property

        Public Property SG_DESCRIPCION As String
            Get
                Return _SG_DESCRIPCION
            End Get
            Set(value As String)
                _SG_DESCRIPCION = value
            End Set
        End Property

        Public Property SG_IDGRUPO As String
            Get
                Return _SG_IDGRUPO
            End Get
            Set(value As String)
                _SG_IDGRUPO = value
            End Set
        End Property

        Public Property SG_ESTADO As Integer
            Get
                Return _SG_ESTADO
            End Get
            Set(value As Integer)
                _SG_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_GRUPO
        Private _GR_ID As String
        Private _GR_DESCRIPCION As String
        Private _GR_ESTADO As Integer

        Public Sub New()
            _GR_ID = String.Empty
            _GR_DESCRIPCION = String.Empty
            _GR_ESTADO = 0
        End Sub

        Public Property GR_ID As String
            Get
                Return _GR_ID
            End Get
            Set(value As String)
                _GR_ID = value
            End Set
        End Property

        Public Property GR_DESCRIPCION As String
            Get
                Return _GR_DESCRIPCION
            End Get
            Set(value As String)
                _GR_DESCRIPCION = value
            End Set
        End Property

        Public Property GR_ESTADO As Integer
            Get
                Return _GR_ESTADO
            End Get
            Set(value As Integer)
                _GR_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_ACTIVO

        Private _AC_NUM_COTIZA As String
        Private _AC_NUM_ORD_COMPRA As String
        Private _AC_AUTORIZA_ADQ As String
        Private _AC_IDORIGEN_REQ As String
        Private _AC_IDRESPON_ACTI As String

        Public Property AC_IDRESPON_ACTI As String
            Get
                Return _AC_IDRESPON_ACTI
            End Get
            Set(value As String)
                _AC_IDRESPON_ACTI = value
            End Set
        End Property

        Public Property AC_IDORIGEN_REQ As String
            Get
                Return _AC_IDORIGEN_REQ
            End Get
            Set(value As String)
                _AC_IDORIGEN_REQ = value
            End Set
        End Property

        Public Property AC_AUTORIZA_ADQ As String
            Get
                Return _AC_AUTORIZA_ADQ
            End Get
            Set(value As String)
                _AC_AUTORIZA_ADQ = value
            End Set
        End Property

        Public Property AC_NUM_ORD_COMPRA As String
            Get
                Return _AC_NUM_ORD_COMPRA
            End Get
            Set(value As String)
                _AC_NUM_ORD_COMPRA = value
            End Set
        End Property

        Public Property AC_NUM_COTIZA As String
            Get
                Return _AC_NUM_COTIZA
            End Get
            Set(value As String)
                _AC_NUM_COTIZA = value
            End Set
        End Property

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property

        Private _AC_IDACTIVO As System.Int32

        Public Property AC_IDACTIVO As System.Int32
            Get
                Return (_AC_IDACTIVO)
            End Get
            Set(ByVal value As System.Int32)
                _AC_IDACTIVO = value
            End Set
        End Property

        Private _AC_IDACTIVO_REF As System.Int32

        Public Property AC_IDACTIVO_REF As System.Int32
            Get
                Return (_AC_IDACTIVO_REF)
            End Get
            Set(ByVal value As System.Int32)
                _AC_IDACTIVO_REF = value
            End Set
        End Property

        Private _AC_CODIGO_ALT As System.String

        Public Property AC_CODIGO_ALT As System.String
            Get
                Return (_AC_CODIGO_ALT)
            End Get
            Set(ByVal value As System.String)
                _AC_CODIGO_ALT = value
            End Set
        End Property

        Private _AC_ACTIVO_DES As System.String

        Public Property AC_ACTIVO_DES As System.String
            Get
                Return (_AC_ACTIVO_DES)
            End Get
            Set(ByVal value As System.String)
                _AC_ACTIVO_DES = value
            End Set
        End Property

        Private _AC_IDFAMILIA As System.String

        Public Property AC_IDFAMILIA As System.String
            Get
                Return (_AC_IDFAMILIA)
            End Get
            Set(ByVal value As System.String)
                _AC_IDFAMILIA = value
            End Set
        End Property

        Private _AC_FECHA_COMPRA As String

        Public Property AC_FECHA_COMPRA As String
            Get
                Return (_AC_FECHA_COMPRA)
            End Get
            Set(ByVal value As String)
                _AC_FECHA_COMPRA = value
            End Set
        End Property

        Private _AC_FECHA_INI_OPE As String

        Public Property AC_FECHA_INI_OPE As String
            Get
                Return (_AC_FECHA_INI_OPE)
            End Get
            Set(ByVal value As String)
                _AC_FECHA_INI_OPE = value
            End Set
        End Property

        Private _AC_IDGRUPO As System.String

        Public Property AC_IDGRUPO As System.String
            Get
                Return (_AC_IDGRUPO)
            End Get
            Set(ByVal value As System.String)
                _AC_IDGRUPO = value
            End Set
        End Property

        Private _AC_IDSUB_GRUPO As System.String

        Public Property AC_IDSUB_GRUPO As System.String
            Get
                Return (_AC_IDSUB_GRUPO)
            End Get
            Set(ByVal value As System.String)
                _AC_IDSUB_GRUPO = value
            End Set
        End Property

        Private _AC_IDMARCA As System.String

        Public Property AC_IDMARCA As System.String
            Get
                Return (_AC_IDMARCA)
            End Get
            Set(ByVal value As System.String)
                _AC_IDMARCA = value
            End Set
        End Property

        Private _AC_MODELO As System.String

        Public Property AC_MODELO As System.String
            Get
                Return (_AC_MODELO)
            End Get
            Set(ByVal value As System.String)
                _AC_MODELO = value
            End Set
        End Property

        Private _AC_NUMSERIE As System.String

        Public Property AC_NUMSERIE As System.String
            Get
                Return (_AC_NUMSERIE)
            End Get
            Set(ByVal value As System.String)
                _AC_NUMSERIE = value
            End Set
        End Property

        Private _AC_NUMPLACA As System.String

        Public Property AC_NUMPLACA As System.String
            Get
                Return (_AC_NUMPLACA)
            End Get
            Set(ByVal value As System.String)
                _AC_NUMPLACA = value
            End Set
        End Property

        Private _AC_IDPROVE As System.String

        Public Property AC_IDPROVE As System.String
            Get
                Return (_AC_IDPROVE)
            End Get
            Set(ByVal value As System.String)
                _AC_IDPROVE = value
            End Set
        End Property

        Private _AC_TDOC As System.String

        Public Property AC_TDOC As System.String
            Get
                Return (_AC_TDOC)
            End Get
            Set(ByVal value As System.String)
                _AC_TDOC = value
            End Set
        End Property

        Private _AC_SDOC As System.String

        Public Property AC_SDOC As System.String
            Get
                Return (_AC_SDOC)
            End Get
            Set(ByVal value As System.String)
                _AC_SDOC = value
            End Set
        End Property

        Private _AC_NDOC As System.String

        Public Property AC_NDOC As System.String
            Get
                Return (_AC_NDOC)
            End Get
            Set(ByVal value As System.String)
                _AC_NDOC = value
            End Set
        End Property

        Private _AC_FDOC As String

        Public Property AC_FDOC As String
            Get
                Return (_AC_FDOC)
            End Get
            Set(ByVal value As String)
                _AC_FDOC = value
            End Set
        End Property

        Private _AC_MDOC As System.Double

        Public Property AC_MDOC As System.Double
            Get
                Return (_AC_MDOC)
            End Get
            Set(ByVal value As System.Double)
                _AC_MDOC = value
            End Set
        End Property

        Private _AC_IDMONEDA As System.String

        Public Property AC_IDMONEDA As System.String
            Get
                Return (_AC_IDMONEDA)
            End Get
            Set(ByVal value As System.String)
                _AC_IDMONEDA = value
            End Set
        End Property

        Private _AC_TCAM As System.Double

        Public Property AC_TCAM As System.Double
            Get
                Return (_AC_TCAM)
            End Get
            Set(ByVal value As System.Double)
                _AC_TCAM = value
            End Set
        End Property

        Private _AC_IDTIPO_PAGO As System.String

        Public Property AC_IDTIPO_PAGO As System.String
            Get
                Return (_AC_IDTIPO_PAGO)
            End Get
            Set(ByVal value As System.String)
                _AC_IDTIPO_PAGO = value
            End Set
        End Property

        Private _AC_IDESTADO_FISICO As System.String

        Public Property AC_IDESTADO_FISICO As System.String
            Get
                Return (_AC_IDESTADO_FISICO)
            End Get
            Set(ByVal value As System.String)
                _AC_IDESTADO_FISICO = value
            End Set
        End Property

        Private _AC_IDCLASE As System.String

        Public Property AC_IDCLASE As System.String
            Get
                Return (_AC_IDCLASE)
            End Get
            Set(ByVal value As System.String)
                _AC_IDCLASE = value
            End Set
        End Property

        Private _AC_IDUSO As System.String

        Public Property AC_IDUSO As System.String
            Get
                Return (_AC_IDUSO)
            End Get
            Set(ByVal value As System.String)
                _AC_IDUSO = value
            End Set
        End Property

        Private _AC_IDNIVEL_OBS As System.String

        Public Property AC_IDNIVEL_OBS As System.String
            Get
                Return (_AC_IDNIVEL_OBS)
            End Get
            Set(ByVal value As System.String)
                _AC_IDNIVEL_OBS = value
            End Set
        End Property

        Private _AC_CODIGO_BARRA As System.String

        Public Property AC_CODIGO_BARRA As System.String
            Get
                Return (_AC_CODIGO_BARRA)
            End Get
            Set(ByVal value As System.String)
                _AC_CODIGO_BARRA = value
            End Set
        End Property

        Private _AC_IDUBICACION As System.String

        Public Property AC_IDUBICACION As System.String
            Get
                Return (_AC_IDUBICACION)
            End Get
            Set(ByVal value As System.String)
                _AC_IDUBICACION = value
            End Set
        End Property

        Private _AC_IDCENCOS As System.String

        Public Property AC_IDCENCOS As System.String
            Get
                Return (_AC_IDCENCOS)
            End Get
            Set(ByVal value As System.String)
                _AC_IDCENCOS = value
            End Set
        End Property

        Private _AC_IDAREA As System.String

        Public Property AC_IDAREA As System.String
            Get
                Return (_AC_IDAREA)
            End Get
            Set(ByVal value As System.String)
                _AC_IDAREA = value
            End Set
        End Property

        Private _AC_LEA_NUM_CONTRATO As System.String

        Public Property AC_LEA_NUM_CONTRATO As System.String
            Get
                Return (_AC_LEA_NUM_CONTRATO)
            End Get
            Set(ByVal value As System.String)
                _AC_LEA_NUM_CONTRATO = value
            End Set
        End Property

        Private _AC_LEA_FECHA_CONTRA As String

        Public Property AC_LEA_FECHA_CONTRA As String
            Get
                Return (_AC_LEA_FECHA_CONTRA)
            End Get
            Set(ByVal value As String)
                _AC_LEA_FECHA_CONTRA = value
            End Set
        End Property

        Private _AC_LEA_FECHA_ARRENDA As String

        Public Property AC_LEA_FECHA_ARRENDA As String
            Get
                Return (_AC_LEA_FECHA_ARRENDA)
            End Get
            Set(ByVal value As String)
                _AC_LEA_FECHA_ARRENDA = value
            End Set
        End Property

        Private _AC_LEA_NUM_COUTAS As System.Int32

        Public Property AC_LEA_NUM_COUTAS As System.Int32
            Get
                Return (_AC_LEA_NUM_COUTAS)
            End Get
            Set(ByVal value As System.Int32)
                _AC_LEA_NUM_COUTAS = value
            End Set
        End Property

        Private _AC_LEA_MONTO_TOTAL As System.Double

        Public Property AC_LEA_MONTO_TOTAL As System.Double
            Get
                Return (_AC_LEA_MONTO_TOTAL)
            End Get
            Set(ByVal value As System.Double)
                _AC_LEA_MONTO_TOTAL = value
            End Set
        End Property

        Private _AC_ANHOS As System.Double

        Public Property AC_ANHOS As System.Double
            Get
                Return (_AC_ANHOS)
            End Get
            Set(ByVal value As System.Double)
                _AC_ANHOS = value
            End Set
        End Property

        Private _AC_MESES As System.Double

        Public Property AC_MESES As System.Double
            Get
                Return (_AC_MESES)
            End Get
            Set(ByVal value As System.Double)
                _AC_MESES = value
            End Set
        End Property

        Private _AC_OBSERVACIONES As System.String

        Public Property AC_OBSERVACIONES As System.String
            Get
                Return (_AC_OBSERVACIONES)
            End Get
            Set(ByVal value As System.String)
                _AC_OBSERVACIONES = value
            End Set
        End Property

        Private _AC_MESESGARANTIA As System.Double

        Public Property AC_MESESGARANTIA As System.Double
            Get
                Return (_AC_MESESGARANTIA)
            End Get
            Set(ByVal value As System.Double)
                _AC_MESESGARANTIA = value
            End Set
        End Property

        Private _AC_FEC_VENCE_GARAN As String

        Public Property AC_FEC_VENCE_GARAN As String
            Get
                Return (_AC_FEC_VENCE_GARAN)
            End Get
            Set(ByVal value As String)
                _AC_FEC_VENCE_GARAN = value
            End Set
        End Property

        Private _AC_NUM_CONTRATO As System.String

        Public Property AC_NUM_CONTRATO As System.String
            Get
                Return (_AC_NUM_CONTRATO)
            End Get
            Set(ByVal value As System.String)
                _AC_NUM_CONTRATO = value
            End Set
        End Property

        Private _AC_PERIODICIDAD_DIAS As System.Double

        Public Property AC_PERIODICIDAD_DIAS As System.Double
            Get
                Return (_AC_PERIODICIDAD_DIAS)
            End Get
            Set(ByVal value As System.Double)
                _AC_PERIODICIDAD_DIAS = value
            End Set
        End Property

        Private _AC_FEC_VENCE_CON As String

        Public Property AC_FEC_VENCE_CON As String
            Get
                Return (_AC_FEC_VENCE_CON)
            End Get
            Set(ByVal value As String)
                _AC_FEC_VENCE_CON = value
            End Set
        End Property

        Private _AC_DEPRE_INICIAL As System.Double

        Public Property AC_DEPRE_INICIAL As System.Double
            Get
                Return (_AC_DEPRE_INICIAL)
            End Get
            Set(ByVal value As System.Double)
                _AC_DEPRE_INICIAL = value
            End Set
        End Property

        Private _AC_ES_TASA_PARTICULAR As System.Int32

        Public Property AC_ES_TASA_PARTICULAR As System.Int32
            Get
                Return (_AC_ES_TASA_PARTICULAR)
            End Get
            Set(ByVal value As System.Int32)
                _AC_ES_TASA_PARTICULAR = value
            End Set
        End Property

        Private _AC_USUARIO As System.String

        Public Property AC_USUARIO As System.String
            Get
                Return (_AC_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _AC_USUARIO = value
            End Set
        End Property

        Private _AC_TERMINAL As System.String

        Public Property AC_TERMINAL As System.String
            Get
                Return (_AC_TERMINAL)
            End Get
            Set(ByVal value As System.String)
                _AC_TERMINAL = value
            End Set
        End Property

        Private _AC_FECREG As String

        Public Property AC_FECREG As String
            Get
                Return (_AC_FECREG)
            End Get
            Set(ByVal value As String)
                _AC_FECREG = value
            End Set
        End Property

        Private _AC_ESTADO As System.Int32

        Public Property AC_ESTADO As System.Int32
            Get
                Return (_AC_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _AC_ESTADO = value
            End Set
        End Property

        Private _AC_USUARIO_MOD As System.String

        Public Property AC_USUARIO_MOD As System.String
            Get
                Return (_AC_USUARIO_MOD)
            End Get
            Set(ByVal value As System.String)
                _AC_USUARIO_MOD = value
            End Set
        End Property

        Private _AC_TERMINAL_MOD As System.String

        Public Property AC_TERMINAL_MOD As System.String
            Get
                Return (_AC_TERMINAL_MOD)
            End Get
            Set(ByVal value As System.String)
                _AC_TERMINAL_MOD = value
            End Set
        End Property

        Private _AC_FECREG_MOD As String

        Public Property AC_FECREG_MOD As String
            Get
                Return (_AC_FECREG_MOD)
            End Get
            Set(ByVal value As String)
                _AC_FECREG_MOD = value
            End Set
        End Property

        Private _AC_VALOR_RESIDUAL As System.Double

        Public Property AC_VALOR_RESIDUAL As System.Double
            Get
                Return (_AC_VALOR_RESIDUAL)
            End Get
            Set(ByVal value As System.Double)
                _AC_VALOR_RESIDUAL = value
            End Set
        End Property

    End Class

    Public Class AF_MA_CATEGORIA
        Private _CA_ID As String
        Private _CA_DESCRIPCION As String
        Private _CA_TASA As Double
        Private _CA_ESTADO As Integer

        Public Sub New()
            _CA_ID = String.Empty
            _CA_DESCRIPCION = String.Empty
            _CA_TASA = 0.0R
            _CA_ESTADO = 0
        End Sub

        Public Property CA_ID As String
            Get
                Return _CA_ID
            End Get
            Set(value As String)
                _CA_ID = value
            End Set
        End Property

        Public Property CA_DESCRIPCION As String
            Get
                Return _CA_DESCRIPCION
            End Get
            Set(value As String)
                _CA_DESCRIPCION = value
            End Set
        End Property

        Public Property CA_TASA As Double
            Get
                Return _CA_TASA
            End Get
            Set(value As Double)
                _CA_TASA = value
            End Set
        End Property

        Public Property CA_ESTADO As Integer
            Get
                Return _CA_ESTADO
            End Get
            Set(value As Integer)
                _CA_ESTADO = value
            End Set
        End Property

    End Class

    Public Class AF_MA_FAMILIA
        Private _FA_ID As String
        Private _FA_DESCRIPCION As String
        Private _FA_IDMETODO As String
        Private _FA_IDCATEGORIA As String
        Private _FA_CUENTA_DEPRE As String
        Private _FA_CUENTA_ACTIVO As String
        Private _FA_CUENTA_GASTO As String
        Private _FA_ESTADO As Integer

        Public Sub New()
            _FA_ID = String.Empty
            _FA_DESCRIPCION = String.Empty
            _FA_IDMETODO = String.Empty
            _FA_IDCATEGORIA = String.Empty
            _FA_CUENTA_DEPRE = String.Empty
            _FA_CUENTA_ACTIVO = String.Empty
            _FA_CUENTA_GASTO = String.Empty
            _FA_ESTADO = 0
        End Sub

        Public Property FA_ID As String
            Get
                Return _FA_ID
            End Get
            Set(value As String)
                _FA_ID = value
            End Set
        End Property

        Public Property FA_DESCRIPCION As String
            Get
                Return _FA_DESCRIPCION
            End Get
            Set(value As String)
                _FA_DESCRIPCION = value
            End Set
        End Property

        Public Property FA_IDMETODO As String
            Get
                Return _FA_IDMETODO
            End Get
            Set(value As String)
                _FA_IDMETODO = value
            End Set
        End Property

        Public Property FA_IDCATEGORIA As String
            Get
                Return _FA_IDCATEGORIA
            End Get
            Set(value As String)
                _FA_IDCATEGORIA = value
            End Set
        End Property

        Public Property FA_CUENTA_DEPRE As String
            Get
                Return _FA_CUENTA_DEPRE
            End Get
            Set(value As String)
                _FA_CUENTA_DEPRE = value
            End Set
        End Property

        Public Property FA_CUENTA_ACTIVO As String
            Get
                Return _FA_CUENTA_ACTIVO
            End Get
            Set(value As String)
                _FA_CUENTA_ACTIVO = value
            End Set
        End Property


        Public Property FA_CUENTA_GASTO As String
            Get
                Return _FA_CUENTA_GASTO
            End Get
            Set(value As String)
                _FA_CUENTA_GASTO = value
            End Set
        End Property

        Public Property FA_ESTADO As Integer
            Get
                Return _FA_ESTADO
            End Get
            Set(value As Integer)
                _FA_ESTADO = value
            End Set
        End Property

    End Class


End Class
