Imports LibConexion
Imports System.Data.SqlClient

Public Class ClsUsuario
    Private LibData As LibConexion.ClsData
    Public LibDatos As LibConexion.ClsData

    Private _CODUSUARIO As String
    Private _PASSUSUARIO As String
    Private _NOMUSUARIO As String
    Private _NIVEL_ACCESO As String
    Private _FECHA_INICIO As String
    Private _FECHA_FIN As String
    Private _ESTADO As String
    Private _ACCESO_ALMACENES As String
    Private _ACCESO_VENDEDORES As String
    Private _OPT_VALIDADO As String
    Private _MAIL As String
    Private _TIPO_DOC As String
    Private _SERIE_DOC As String
    Private _VENDEDOR As String
    Private _MANEJO_CARTERA As String
    Private _DESHACER_PEDIDO As String
    Private _USUARIO_SOL As String
    Private _PASSWORD_SOL As String
    Private _MODIFICA_NUMERACION_FACT As String
    Private _ACT_PE As String
    Private _AUTORIZA_GD As String
    Private _PUNTO_VENTA_ASIGNADO As String
    Private _SERIE_GUIA_ASIGNADO As String

    Public Property SERIE_GUIA_ASIGNADO As String
        Get
            Return _SERIE_GUIA_ASIGNADO
        End Get
        Set(value As String)
            _SERIE_GUIA_ASIGNADO = value
        End Set
    End Property

    Public Property PUNTO_VENTA_ASIGNADO As String
        Get
            Return _PUNTO_VENTA_ASIGNADO
        End Get
        Set(value As String)
            _PUNTO_VENTA_ASIGNADO = value
        End Set
    End Property

    Public Property AUTORIZA_GD As String
        Get
            Return _AUTORIZA_GD
        End Get
        Set(value As String)
            _AUTORIZA_GD = value
        End Set
    End Property

    Public Property ACT_PE As String
        Get
            Return _ACT_PE
        End Get
        Set(value As String)
            _ACT_PE = value
        End Set
    End Property
    Public Property MODIFICA_NUMERACION_FACT As String
        Get
            Return _MODIFICA_NUMERACION_FACT
        End Get
        Set(value As String)
            _MODIFICA_NUMERACION_FACT = value
        End Set
    End Property
    Public Property USUARIO_SOL As String
        Get
            Return _USUARIO_SOL
        End Get
        Set(value As String)
            _USUARIO_SOL = value
        End Set
    End Property
    Public Property PASSWORD_SOL As String
        Get
            Return _PASSWORD_SOL
        End Get
        Set(value As String)
            _PASSWORD_SOL = value
        End Set
    End Property

    Public Property DESHACER_PEDIDO As String
        Get
            Return _DESHACER_PEDIDO
        End Get
        Set(value As String)
            _DESHACER_PEDIDO = value
        End Set
    End Property
    Public Property MANEJO_CARTERA As String
        Get
            Return _MANEJO_CARTERA
        End Get
        Set(value As String)
            _MANEJO_CARTERA = value
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

    Public Property MAIL As String
        Get
            Return _MAIL
        End Get
        Set(value As String)
            _MAIL = value
        End Set
    End Property


    Public Property CODUSUARIO As String
        Get
            Return _CODUSUARIO
        End Get
        Set(value As String)
            _CODUSUARIO = value
        End Set
    End Property

    Public Property PASSUSUARIO As String
        Get
            Return _PASSUSUARIO
        End Get
        Set(value As String)
            _PASSUSUARIO = value
        End Set
    End Property

    Public Property NOMUSUARIO As String
        Get
            Return _NOMUSUARIO
        End Get
        Set(value As String)
            _NOMUSUARIO = value
        End Set
    End Property

    Public Property NIVEL_ACCESO As String
        Get
            Return _NIVEL_ACCESO
        End Get
        Set(value As String)
            _NIVEL_ACCESO = value
        End Set
    End Property

    Public Property FECHA_INICIO As String
        Get
            Return _FECHA_INICIO
        End Get
        Set(value As String)
            _FECHA_INICIO = value
        End Set
    End Property

    Public Property FECHA_FIN As String
        Get
            Return _FECHA_FIN
        End Get
        Set(value As String)
            _FECHA_FIN = value
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

    Public Property ACCESO_ALMACENES As String
        Get
            Return _ACCESO_ALMACENES
        End Get
        Set(value As String)
            _ACCESO_ALMACENES = value
        End Set
    End Property

    Public Property ACCESO_VENDEDORES As String
        Get
            Return _ACCESO_VENDEDORES
        End Get
        Set(value As String)
            _ACCESO_VENDEDORES = value
        End Set
    End Property

    Public Property OPT_VALIDADO As String
        Get
            Return _OPT_VALIDADO
        End Get
        Set(value As String)
            _OPT_VALIDADO = value
        End Set
    End Property

    Public Function FechaSistema() As Date
        Try
            Dim dtFecha As Date
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("FECHA_SISTEMA")
            dtFecha = Convert.ToDateTime(dtTable.Rows(0).Item(0))
            dtTable = Nothing
            LibData.Dispose()
            Return dtFecha
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function Accesos_Usuario(ByVal STRCodigo As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("AX_ACCESO_USUARIO", _
                            LibData.DatosParam("@codigo", SqlDbType.Char, 15, STRCodigo))
            LibData.Dispose()

            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function
    Public Function BulkMenu(ByVal myDataTable As DataTable) As Boolean
        Try
            LibData = New LibConexion.ClsData
            If LibData.Run_Store_Procedure("AX_ELIMINA_MENU_SISTEMA", Nothing) = True Then
                'Inserto datos a la tabla
                If LibData.CopyDataTableBulk(myDataTable, "MENU_SISTEMA") Then
                    Return True
                End If
            Else
                Return False
            End If
            LibData = Nothing
            LibData.Dispose()
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function
    Public Function get_Datos_Empresa() As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_DATOS_EMPRESA")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarUsuariosIngresos(ByVal codigoUsuario As String) As DataTable
        Try
            LibDatos = New LibConexion.ClsData
            dtTable = New DataTable("Datos_Usuarios")
            dtTable = LibDatos.Run_SP_DataTable("ADM_DATOS_USUARIO_GENERAL", _
                            LibDatos.DatosParam("@CODUSUARIO", SqlDbType.Char, 20, codigoUsuario))
            If dtTable.Rows.Count() <> 0 Then
                CODUSUARIO = dtTable.Rows(0).Item("CODUSUARIO").ToString
                PASSUSUARIO = dtTable.Rows(0).Item("PASSUSUARIO").ToString
                NOMUSUARIO = dtTable.Rows(0).Item("NOMUSUARIO").ToString
                NIVEL_ACCESO = dtTable.Rows(0).Item("NIVEL_ACCESO").ToString
                FECHA_INICIO = dtTable.Rows(0).Item("FECHA_INICIO").ToString
                FECHA_FIN = dtTable.Rows(0).Item("FECHA_FIN").ToString
                ESTADO = dtTable.Rows(0).Item("ESTADO").ToString
                ACCESO_ALMACENES = dtTable.Rows(0).Item("ACCESO_ALMACENES").ToString
                ACCESO_VENDEDORES = dtTable.Rows(0).Item("ACCESO_VENDEDORES").ToString
                OPT_VALIDADO = dtTable.Rows(0).Item("OPT_VALIDADO").ToString
                MAIL = dtTable.Rows(0).Item("MAIL").ToString

                TIPO_DOC = dtTable.Rows(0).Item("TIPO_DOC_DEFECTO").ToString
                SERIE_DOC = dtTable.Rows(0).Item("SERIE_DOC_DEFECTO").ToString
                VENDEDOR = dtTable.Rows(0).Item("VENDEDOR").ToString
                MANEJO_CARTERA = dtTable.Rows(0).Item("MANEJO_CARTERA").ToString
                DESHACER_PEDIDO = dtTable.Rows(0).Item("DESHACER_PEDIDO").ToString

                USUARIO_SOL = dtTable.Rows(0).Item("USUARIO_SOL").ToString
                PASSWORD_SOL = dtTable.Rows(0).Item("PASSWORD_SOL").ToString
                MODIFICA_NUMERACION_FACT = dtTable.Rows(0).Item("MODIFICA_NUMERACION_FACT").ToString
                ACT_PE = dtTable.Rows(0).Item("ACTUALIZA_PE").ToString
                AUTORIZA_GD = dtTable.Rows(0).Item("AUTORIZA_GD").ToString
                PUNTO_VENTA_ASIGNADO = dtTable.Rows(0).Item("PUNTO_VENTA_ASIGNADO").ToString
                SERIE_GUIA_ASIGNADO = dtTable.Rows(0).Item("SERIE_GUIA_ASIGNADO").ToString
            End If
            LibDatos.Dispose()
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
