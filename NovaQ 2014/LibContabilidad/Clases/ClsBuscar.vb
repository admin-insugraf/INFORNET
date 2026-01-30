Imports LibConexion
Imports LibComunVar
Imports System.Data.SqlClient
Public Class ClsBuscar
    Private LibData As LibConexion.ClsData
    Private drDatos As SqlClient.SqlDataReader

    Dim cn As SqlConnection
    Dim dataBL As New LibConexion.ClsData

    Public Sub New()
        cn = dataBL.ConexionBD
    End Sub

    Public Function Get_MostrarDescripcion(ByVal _Cadena As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, _Cadena).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_MostrarDescripcionFiltros(ByVal _Cadena As String, ByVal _Filtro1 As String, Optional ByVal _Filtro2 As String = "") As DataTable
        Try
            If _Filtro2 = String.Empty Then
                Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1).Tables(0)
            Else
                Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1, _Filtro2).Tables(0)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    '----------------
    '----------PEDIDOS--

    Public Function Get_FormaCobro(ByVal Codigo As String) As String
        Dim Descripcion As String = String.Empty
        Try
            Dim dtFormaPago As New DataTable
            dtFormaPago = SqlHelper.ExecuteDataset(cn, "SAL_HLP_FIND_FORMA_COBRO", Codigo).Tables(0)
            If dtFormaPago.Rows.Count() <> 0 Then
                Descripcion = dtFormaPago.Rows(0).Item(1).ToString
            Else
                Descripcion = ""
            End If
            Return Descripcion
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Get_NombreVendedor(ByVal Codigo As String) As String
        Dim Descripcion As String = String.Empty
        Try
            Dim dtFormaPago As New DataTable
            dtFormaPago = SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_VENDEDOR", Codigo).Tables(0)
            If dtFormaPago.Rows.Count() <> 0 Then
                Descripcion = dtFormaPago.Rows(0).Item(1).ToString
            Else
                Descripcion = ""
            End If
            Return Descripcion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_NombrePuntoVenta(ByVal Codigo As String) As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_PV", Codigo).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_NombreTerceros(ByVal Codigo As String) As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_ORDER_CLIENTES", Codigo).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Get_FormaPagoFechaVencimiento(ByVal Codigo As String) As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_I_R_F_PAGO_FECHA", Codigo).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''FACTURACION VERFICACION ORDEN DE COMPRA

    Public Function Get_VerificacionOrdenCompra(ByVal _Cadena As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, _Cadena).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    '-------------impresion de la facturacion ----
    Public Function EjecutarReporteFacturacion(ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SALimprimefacturas", tipodoc_, serie_, num_).Tables(0)
    End Function

    '-------------GUIA DE REMISION ----
    Public Function EjecutarReporteGuiaRemision(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
    End Function

    Public Function EjecutarReporteVoucher(ByVal CodAsientoContable As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_CONTA_SP_S_ASIENTO_CONTABLE", CodAsientoContable).Tables(0)
    End Function



    Public Function EjecutarReporteListaCuentasContables(ByVal CodCuentaContable As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_LISTA_CUENTAS", CodCuentaContable).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function EjecutarReporteAnexos(ByVal tipo_ As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_ANNEXED_LISTADO", tipo_).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Public Function EjecutarConsulta(ByVal consulta As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function EjecutarReporteRegistroVentas(ByVal Mes As String, ByVal anno As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_REGISTRO_VENTAS", Mes, anno).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function EjecutarReporteRegistroCompras(ByVal Mes As String, ByVal anno As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_REGISTRO_COMPRAS", Mes, anno).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function EjecutarReporteRegistroCompras_No_Domiciliados(ByVal Mes As String, ByVal anno As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_REGISTRO_COMPRAS_NO_DOMICILIADOS", Mes, anno).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    '-------------COMPROBANTE DÉ PERCEPCION
    Public Function EjecutarReporteComprobantePercepcion(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SALimprimeComprobantePercepcion", alm_, doc_, num_).Tables(0)
    End Function

    Public Function Get_GuiasAsociadas(ByVal _Almacen As String, ByVal _NumeroReferencia As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_GUIA_R", _Almacen, _NumeroReferencia).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    '---Verificacion Docuemetos a  Anular
    Public Function Get_VerificacionDocumentosAnular(ByVal NombreStore As String, ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, NombreStore, tipodoc_, serie_, num_).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''REPORTE DE DESPACHOS
    Public Function EjecutarReporteDespacho(ByVal FechaIni As String, ByVal FechaFin As String, ByVal TipoDoc As String, ByVal TipoDespacho As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "MOSTRAR_DESPACHO", FechaIni, FechaFin, TipoDoc, TipoDespacho).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EjecutarReporteDespachoGuias(ByVal FechaIni As String, ByVal FechaFin As String, ByVal TipoDespacho As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "MOSTRAR_DESPACHO_GUIAS", FechaIni, FechaFin, TipoDespacho).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function


    ''REPORTE DE VENTAS MENSUALES
    ''REPORTE DE VENTAS POR ARTICULO
    Public Function PuntoVenta() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "FACT_SP_S_R_VENTAS_ART_SALES_P").Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_MostrarAlmacenes(ByVal _ACCESOALAMACEN As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_WAREHOUSE_AYUDA", _ACCESOALAMACEN).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function EjecutarReporteDetraccion(ByVal FechaIni As String, ByVal FechaFin As String, ByVal TipoDoc As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_FACT_SP_S_DOC_DETRACCION", FechaIni, FechaFin, TipoDoc).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function



End Class
