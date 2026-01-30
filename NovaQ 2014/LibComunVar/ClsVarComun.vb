Public Class ClsVarComun
    Private Shared STRBaseDatos As String
    Private Shared DTFechaSistema As Date
    Private Shared DBLTCVenta As Double
    Private Shared DBLTCCompra As Double
    Private Shared STRNomEmpresa As String
    Private Shared STRNomEmpresa_completo As String
    Private Shared STRRucEmpresa As String
    Private Shared STRDirEmpresa As String
    Private Shared STRUSER As String
    Private Shared _AcesoAlmacenes As String
    Private Shared _AcesoVendedores As String
    Private Shared _MAIL_USER As String

    Private Shared _TIPO_DOC As String
    Private Shared _SERI_DOC As String
    Private Shared _VENDEDOR As String
    Private Shared _MANEJO_CARTERA As String
    Private Shared _DESHACER_PEDIDO As String
    Private Shared _STRUSUARIO_SOL As String
    Private Shared _STRPASSWORD_SOL As String
    Private Shared _MODIFICA_NUMERACION_FACT As String
    Private Shared _ACT_PE As String
    Private Shared _AUTORIZA_GD As String
    Private Shared _PUNTO_VENTA_ASIGNADO As String
    Private Shared _PUNTO_VENTA As String
    Private Shared _SERIE_GUIA_ASIGNADO As String

    Public Shared Property SERIE_GUIA_ASIGNADO As String
        Get
            Return _SERIE_GUIA_ASIGNADO
        End Get
        Set(value As String)
            _SERIE_GUIA_ASIGNADO = value
        End Set
    End Property

    Public Shared Property PUNTO_VENTA_ASIGNADO As String
        Get
            Return _PUNTO_VENTA_ASIGNADO
        End Get
        Set(value As String)
            _PUNTO_VENTA_ASIGNADO = value
        End Set
    End Property

    Public Shared Property PUNTO_VENTA As String
        Get
            Return _PUNTO_VENTA
        End Get
        Set(value As String)
            _PUNTO_VENTA = value
        End Set
    End Property

    Public Shared Property AUTORIZA_GD As String
        Get
            Return _AUTORIZA_GD
        End Get
        Set(value As String)
            _AUTORIZA_GD = value
        End Set
    End Property

    Public Shared Property ACT_PE As String
        Get
            Return _ACT_PE
        End Get
        Set(value As String)
            _ACT_PE = value
        End Set
    End Property

    Public Shared Property MODIFICA_NUMERACION_FACT As String
        Get
            Return _MODIFICA_NUMERACION_FACT
        End Get
        Set(value As String)
            _MODIFICA_NUMERACION_FACT = value
        End Set
    End Property

    Public Shared Property STRUSUARIO_SOL As String
        Get
            Return _STRUSUARIO_SOL
        End Get
        Set(value As String)
            _STRUSUARIO_SOL = value
        End Set
    End Property
    Public Shared Property STRPASSWORD_SOL As String
        Get
            Return _STRPASSWORD_SOL
        End Get
        Set(value As String)
            _STRPASSWORD_SOL = value
        End Set
    End Property

    Public Shared Property DESHACER_PEDIDO As String
        Get
            Return _DESHACER_PEDIDO
        End Get
        Set(value As String)
            _DESHACER_PEDIDO = value
        End Set
    End Property
    Public Shared Property MANEJO_CARTERA As String
        Get
            Return _MANEJO_CARTERA
        End Get
        Set(value As String)
            _MANEJO_CARTERA = value
        End Set
    End Property

    Public Shared Property VENDEDOR As String
        Get
            Return _VENDEDOR
        End Get
        Set(value As String)
            _VENDEDOR = value
        End Set
    End Property

    Public Shared Property TIPO_DOC As String
        Get
            Return _TIPO_DOC
        End Get
        Set(value As String)
            _TIPO_DOC = value
        End Set
    End Property
    Public Shared Property SERI_DOC As String
        Get
            Return _SERI_DOC
        End Get
        Set(value As String)
            _SERI_DOC = value
        End Set
    End Property

    Public Shared Property DirEmpresa As String
        Get
            Return STRDirEmpresa
        End Get
        Set(value As String)
            STRDirEmpresa = value
        End Set
    End Property

    Public Shared Property RucEmpresa As String
        Get
            Return STRRucEmpresa
        End Get
        Set(value As String)
            STRRucEmpresa = value
        End Set
    End Property

    Public Shared Property NomEmpresa As String
        Get
            Return STRNomEmpresa
        End Get
        Set(value As String)
            STRNomEmpresa = value
        End Set
    End Property

    Public Shared Property NomEmpresa_completo As String
        Get
            Return STRNomEmpresa_completo
        End Get
        Set(value As String)
            STRNomEmpresa_completo = value
        End Set
    End Property

    Public Shared Property BaseDatos As String
        Get
            BaseDatos = STRBaseDatos
        End Get
        Set(value As String)
            STRBaseDatos = value
        End Set
    End Property

    Public Shared Property FechaSistema As Date
        Get
            Return DTFechaSistema
        End Get
        Set(value As Date)
            DTFechaSistema = value
        End Set

    End Property

    Public Shared Property TCVenta As Double
        Get
            Return DBLTCVenta
        End Get
        Set(value As Double)
            DBLTCVenta = value
        End Set
    End Property


    Public Shared Property TCCompra As Double
        Get
            Return DBLTCCompra
        End Get
        Set(value As Double)
            DBLTCCompra = value
        End Set
    End Property

    Public Shared Property USUARIO As String
        Get
            Return STRUSER
        End Get
        Set(value As String)
            STRUSER = value
        End Set
    End Property

    Public Shared Property AccesoAlmacenes As String
        Get
            Return _AcesoAlmacenes
        End Get
        Set(value As String)
            _AcesoAlmacenes = value
        End Set
    End Property

    Public Shared Property AcesoVendedores As String
        Get
            Return _AcesoVendedores
        End Get
        Set(value As String)
            _AcesoVendedores = value
        End Set
    End Property

    Public Shared Property MAIL_USER As String
        Get
            Return _MAIL_USER
        End Get
        Set(value As String)
            _MAIL_USER = value
        End Set
    End Property

End Class
