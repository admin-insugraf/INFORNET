Imports LibConexion
Imports LibComunVar
Imports System.Data.SqlClient
Imports LibCobranzas

Public Class ClsBuscar
    Private LibData As LibConexion.ClsData
    Private drDatos As SqlClient.SqlDataReader
    Private dtDetallesConsulta As DataTable

    Dim cn As SqlConnection
    Dim dataBL As New LibConexion.ClsData

    Public Sub New()
        cn = dataBL.ConexionBD
    End Sub

    Public Function EjecutarReporteComprobantePercepcion(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SALimprimeComprobantePercepcion", alm_, doc_, num_).Tables(0)
    End Function

    Public Function NIVEL_ACCESO(ByVal CODIGO As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_NIVEL_ACCESO", CODIGO).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function GET_DEVOLVER_DATOS_ENVIO_EMAIL(ByVal _CODIGO As String) As DataTable
        Try

            'Dim alma As String = String.Empty
            'alma = MostrandoAlmacenes()
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_DATOS_ENVIO_EMAIL", _CODIGO).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Verif_Contab_Ventas(ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_RECEIVABLE_CONTAB", tipodoc_, serie_, num_).Tables(0)
    End Function

    Public Function Reporte_Cierre_Ventas(ByVal fecha_ As String, ByVal usuario_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "CIERRE_DIARIO_VENTAS", fecha_, usuario_).Tables(0)
    End Function

    Public Function Get_NombrePuntoVenta(ByVal Codigo As String) As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_PV", Codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Reporte_Cierre_Ventas_Detallado(ByVal fecha_ As String, ByVal usuario_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "CIERRE_DIARIO_VENTAS_II", fecha_, usuario_).Tables(0)
    End Function


    Public Function Get_NombreTerceros(ByVal Codigo As String) As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_ORDER_CLIENTES", Codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_FormaPagoFechaVencimiento(ByVal Codigo As String) As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_I_R_F_PAGO_FECHA", Codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReportePedidos(ByVal CodigoPedido As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_PED_PEDIDOS", CodigoPedido).Tables(0)
    End Function

    Public Function EjecutarReporteNotaCreditos_letras(ByVal alm_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "FT_CON_NC", alm_, serie_, num_).Tables(0)
    End Function

    Public Function Obtener_Nombre_Reporte(ByVal tipodoc_ As String, ByVal seriedoc_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SAL_SP_S_FORMAT_REPORT", tipodoc_, seriedoc_).Tables(0)
    End Function

    Public Function Get_Mostrar_Transacciones(ByVal _TIPO As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_TRANSACTION_TYPE_AYUDA", _TIPO).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteFacturacion(ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SALimprimefacturas", tipodoc_, serie_, num_).Tables(0)
    End Function

    Public Function Obtener_Rpt_Consulta_Stock_Logistico(ByVal _codigo As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REP_CONSULTA_STOCK_LOGISTICO", _codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub ActualizandoEstadoControl_C(ByVal _idlamacen As String, ByVal _documentId As String, _
                                      ByVal _NumeroDocumento As String)
        Try
            SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_STATUS_CONTROL", _idlamacen, _documentId, _NumeroDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Get_Imprimir_Producto_Vencer(ByVal Almacen As String, ByVal prod_inicial As String, ByVal prod_final As String, ByVal fecha As String, _
                                                 ByVal familia As String, ByVal linea As String) As DataTable
        Try

            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_PROD_CON_VIDA_UTIL", Almacen, prod_inicial, prod_final, fecha, familia, linea).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutaReporte_Precios_Anual(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _PRODUCTO As String, ByVal _CLIENTE As String, _
                                                 ByVal _OPCION As String) As DataTable
        Try
            If _OPCION = "0" Then 'RESUMIDO
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RPT_PRECIOS_ANUAL", _FECHA_INI, _FECHA_FIN, _PRODUCTO, _CLIENTE).Tables(0)
            ElseIf _OPCION = "1" Then
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RPT_PRECIOS_ANUAL_DETALLADO", _FECHA_INI, _FECHA_FIN, _PRODUCTO, _CLIENTE).Tables(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_Customer_Codigo(ByVal codigoInicial As String, ByVal codigoFinal As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_CUSTOMER_SP_CLIENTE_CODIGO", codigoInicial, codigoFinal).Tables(0)
    End Function
    Public Function EjecutarReporte_Customer_Vendedor(ByVal codigoInicial As String, ByVal codigoFinal As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_CUSTOMER_SP_VENDEDOR_CLIENTE_CODIGO", codigoInicial, codigoFinal).Tables(0)
    End Function
    Public Function EjecutarReporte_Customer_Tipo_Customer(ByVal codigoInicial As String, ByVal codigoFinal As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_CUSTOMER_SP_TIPO_CLIENTE_CODIGO", codigoInicial, codigoFinal).Tables(0)
    End Function
    'CONTABILIDAD ASIENTO CONTABLE CAJA Y BANCOS 
    Public Function EjecutarReporteVoucher(ByVal CodAsientoContable As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_CONTA_SP_S_ASIENTO_CONTABLE", CodAsientoContable).Tables(0)
    End Function

    Public Function EjecutarConsulta(ByVal consulta As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
    End Function

    Public Function get_Vendedores() As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("SAL_HLP_SALES")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function get_Transportistas() As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("SAL_HLP_CARRIER")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_Serie_Guia_Pto_Venta(ByVal STRptoVenta As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_SERIE_GUIA_PTO_VENTA", _
                        LibData.DatosParam("@PTO_VENTA", SqlDbType.VarChar, 2, STRptoVenta))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_Serie_Doc_Pto_Venta(ByVal STRTipoDoc As String, ByVal STRptoVenta As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_SERIE_DOC_PTO_VENTA", _
                        LibData.DatosParam("@PTO_VENTA", SqlDbType.VarChar, 2, STRptoVenta), _
                        LibData.DatosParam("@DOCUMENT_TYPE", SqlDbType.VarChar, 30, STRTipoDoc))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function get_Tipo_Doc_Pto_Venta(ByVal STRPtoVenta As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_TIPO_DOC_PTO_VENTA", _
                        LibData.DatosParam("@PTO_VENTA", SqlDbType.VarChar, 2, STRPtoVenta))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_Pto_Venta() As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_HLP_PTO_VENTA", _
                        LibData.DatosParam("@cod_compania", SqlDbType.VarChar, 50, ClsVarComun.BaseDatos))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_List_Clientes(ByVal STRCodigo As String, ByVal STRNombre As String, ByVal STRVat As String, ByVal STRDireccion As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_HLP_CLIENTES", _
                        LibData.DatosParam("@codigo", SqlDbType.VarChar, 20, STRCodigo), _
                        LibData.DatosParam("@nombre", SqlDbType.VarChar, 150, STRNombre), _
                        LibData.DatosParam("@vat", SqlDbType.VarChar, 11, STRVat), _
                        LibData.DatosParam("@direccion", SqlDbType.VarChar, 100, STRDireccion))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_List_Vendedores(ByVal STRCodigo As String, ByVal STRNombre As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_HLP_VENDEDORES", _
                        LibData.DatosParam("@codigo", SqlDbType.VarChar, 20, STRCodigo), _
                        LibData.DatosParam("@nombre", SqlDbType.VarChar, 150, STRNombre))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_List_Monedas() As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("SAL_HLP_MONEDAS")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_Lista_Articulos(ByVal STRCodAlmacen As String, ByVal STRCodigo As String, ByVal STRDescipcion As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_HLP_ARTICULOS", _
                                               LibData.DatosParam("@almacen", SqlDbType.VarChar, 2, STRCodAlmacen), _
                                               LibData.DatosParam("@codigo", SqlDbType.VarChar, 20, STRCodigo), _
                                               LibData.DatosParam("@descripcion", SqlDbType.VarChar, 64, STRDescipcion))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_Dato_Vendedor(ByVal STRCodigo As String) As String
        Try
            LibData = New LibConexion.ClsData

            drDatos = LibData.Run_SP_DataReader("SAL_HLP_FIND_VENDEDOR", _
                                        LibData.DatosParam("@codigo", SqlDbType.VarChar, 2, STRCodigo))
            If drDatos.Read Then
                get_Dato_Vendedor = drDatos.Item("name")
            End If
            Return get_Dato_Vendedor
            drDatos.Close()
            LibData.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function Get_NombreVendedor(ByVal Codigo As String) As String
        Dim Descripcion As String = String.Empty
        Try
            dtDetallesConsulta = New DataTable("Vendedor")
            dtDetallesConsulta = SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_VENDEDOR", Codigo).Tables(0)
            If dtDetallesConsulta.Rows.Count() <> 0 Then
                Descripcion = dtDetallesConsulta.Rows(0).Item(1).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Descripcion
    End Function

    Public Function Get_NombreTipoPrecio(ByVal Codigo As String) As String
        Dim Descripcion As String = String.Empty
        Try
            dtDetallesConsulta = New DataTable("Vendedor")
            dtDetallesConsulta = SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_TIPO_PRECIO", Codigo).Tables(0)
            If dtDetallesConsulta.Rows.Count() <> 0 Then
                Descripcion = dtDetallesConsulta.Rows(0).Item(1).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Descripcion
    End Function

    Public Function Get_NombreTipo_Empresa(ByVal Codigo As String) As String
        Dim Descripcion As String = String.Empty
        Try
            dtDetallesConsulta = New DataTable("Vendedor")
            dtDetallesConsulta = SqlHelper.ExecuteDataset(cn, "FACT_SP_S_TIPO_EMPRESA", Codigo).Tables(0)
            If dtDetallesConsulta.Rows.Count() <> 0 Then
                Descripcion = dtDetallesConsulta.Rows(0).Item(1).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Descripcion
    End Function

    Public Function Get_FormaCobro(ByVal Codigo As String) As String
        Dim Descripcion As String = String.Empty
        Try
            dtDetallesConsulta = New DataTable("Forma_Pago")
            dtDetallesConsulta = SqlHelper.ExecuteDataset(cn, "SAL_HLP_FIND_FORMA_COBRO", Codigo).Tables(0)
            If dtDetallesConsulta.Rows.Count() <> 0 Then
                Descripcion = dtDetallesConsulta.Rows(0).Item(1).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Descripcion
    End Function

    Public Function Get_Departamento_Manual(ByVal Codigo As String) As String
        Dim Descripcion As String = String.Empty
        Try
            dtDetallesConsulta = New DataTable("Departamento")
            dtDetallesConsulta = SqlHelper.ExecuteDataset(cn, "CLI_SP_S_CUSTOMER_REP_UBIGEO_M", Codigo).Tables(0)
            If dtDetallesConsulta.Rows.Count() <> 0 Then
                Descripcion = dtDetallesConsulta.Rows(0).Item("DEPARTAMENTO").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Descripcion
    End Function


    Public Function Get_Provincia_Manual(ByVal CodigoDepartamento As String, ByVal CodigoProvincia As String) As String
        Dim Descripcion As String = String.Empty
        Try
            dtDetallesConsulta = New DataTable("Provincia")
            dtDetallesConsulta = SqlHelper.ExecuteDataset(cn, "CLI_SP_S_CUSTOMER_UBIGEO_PROV_M", CodigoDepartamento, CodigoProvincia).Tables(0)
            If dtDetallesConsulta.Rows.Count() <> 0 Then
                Descripcion = dtDetallesConsulta.Rows(0).Item("PROVINCIA").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Descripcion
    End Function


    Public Function Get_Distrito_Manual(ByVal CodigoDepartamento As String, ByVal CodigoProvincia As String, ByVal CodigoDistrito As String) As String
        Dim Descripcion As String = String.Empty
        Try
            dtDetallesConsulta = New DataTable("Distrito")
            dtDetallesConsulta = SqlHelper.ExecuteDataset(cn, "CLI_SP_S_CUSTOMER_UBIGEO_DIST_M", CodigoDepartamento, CodigoProvincia, CodigoDistrito).Tables(0)
            If dtDetallesConsulta.Rows.Count() <> 0 Then
                Descripcion = dtDetallesConsulta.Rows(0).Item("DISTRITO").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Descripcion
    End Function

    Public Function get_Dato_FormaCobro(ByVal STRCodigo As String) As String
        Try
            LibData = New LibConexion.ClsData
            drDatos = LibData.Run_SP_DataReader("SAL_HLP_FIND_FORMA_COBRO", _
                                        LibData.DatosParam("@codigo", SqlDbType.VarChar, 2, STRCodigo))
            If drDatos.Read Then
                get_Dato_FormaCobro = drDatos.Item("name")
            End If
            Return get_Dato_FormaCobro
            drDatos.Close()
            LibData.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_FormasPago(ByVal STRCodigo As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("SAL_HLP_FIND_FORMA_COBRO", _
                                               LibData.DatosParam("@codigo", SqlDbType.VarChar, 2, STRCodigo))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_Lote_Parte(ByVal STRCodAlmacen As String, ByVal STRCodigo As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("SAL_HLP_BUSCA_LOTE", _
                                               LibData.DatosParam("@almacen", SqlDbType.VarChar, 2, STRCodAlmacen), _
                                               LibData.DatosParam("@codigo", SqlDbType.VarChar, 20, STRCodigo))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function




    '-----Guias Ingresos y Salidas
    Public Function Get_MostrarDescripcion(ByVal _Cadena As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, _Cadena).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
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
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function Get_MostrarDescripcionArticulo_TipoArticulo(ByVal _TipoArticulo As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_PRODUCTOS", _TipoArticulo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function MostrarDescripcionArticulo(ByVal _codArticulo As String, ByVal _tipoArticulo As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ALM_SP_S_WAREHOUSE_PRODUCTOS_COD", _
                            LibData.DatosParam("@ID", SqlDbType.VarChar, 20, _codArticulo),
                            LibData.DatosParam("@TYPE_PART", SqlDbType.VarChar, 2, _tipoArticulo))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Sub ActualizandoNumeroAnalisis(ByVal _idlamacen As String, ByVal _documentId As String, _
                                          ByVal _NumeroDocumento As String)
        Try
            SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_WAREHOUSE_TRANS_NUM_ANALISIS", _idlamacen, _documentId, _NumeroDocumento)
            SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_NUMBER_ANALISIS", _idlamacen, _documentId, _NumeroDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertarCantidadLotes(ByVal WAREHOUSE_ID As String, ByVal DOCUMENT_ID As String, _
                                          ByVal NUMBER_DOCUMENT As String, ByVal DATE_DOCUMENT As String, _
                                          ByVal TYPE_TRANS As String, ByVal PART_ID As String, ByVal LOTE As String, _
                                          ByVal QTY As Double, ByVal QTY_BULTOS As Double, ByVal ITEM As Integer)
        Try
            SqlHelper.ExecuteNonQuery(cn, "SP_I_WAREHOUSE_TRANS_LINE_BULTOS", WAREHOUSE_ID, DOCUMENT_ID, NUMBER_DOCUMENT, DATE_DOCUMENT, TYPE_TRANS, PART_ID, LOTE, QTY, QTY_BULTOS, ITEM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function get_DatosGeneralesAlmacen(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function get_VerificarGuiaAnalisis(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_VERIFICAR_GUIA_ANALISIS", alm_, doc_, num_).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    '----------------
    '----------REPORTES--

    Public Function EjecutarReporteGuiaAlmacen(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
    End Function

    Public Function Get_obtenerdatos_Transaccion(ByVal TYPE_ID As String, ByVal MOV_ID As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_TRASACCTION_TYPE", TYPE_ID, MOV_ID).Tables(0)
    End Function

    Public Function EjecutarReporteGuiaAnalisis(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
    End Function

    '----kARDEX CON REFERENCIA

    Public Function Get_MostrarAlmacenes() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WAREHOUSE_AYUDA").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function get_DatosGeneralesAlmacen_E_S_Control(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                               ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ALMACEN As String) As DataTable
        Try

            'Dim alma As String = String.Empty
            'alma = MostrandoAlmacenes()
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_TRANS_PRINCIPAL_CONTROL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ALMACEN).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function Get_RetornarAlmacenes(ByVal _ACCESOALAMACEN As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_AYUDA", _ACCESOALAMACEN).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_Retornar_Tipo_Origen() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_TIPO_ORIGEN").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_MostrarArticulos() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    '-------------GUIA DE REMISION ----
    Public Function EjecutarReporteGuiaRemision(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
    End Function

    Public Function Imprimir_Orden_Pago(ByVal proveedor_id As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "PAGOS_SP_RPT_CUSTOMER_BALANCE_PAY", proveedor_id, doc_, num_).Tables(0)
    End Function

    Public Function EjecutarReporteTrasladoInterno(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_REF", alm_, doc_, num_).Tables(0)
    End Function


    Public Function EjecutarReporte_Part_Codigo(ByVal codigoInicial As String, ByVal codigoFinal As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_PART_SP_ARTICULO_CODIGO", codigoInicial, codigoFinal).Tables(0)
    End Function

    Public Function EjecutarReporte_Part_Familia(ByVal codigoInicial As String, ByVal codigoFinal As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_PART_SP_ARTICULO_FAMILIA", codigoInicial, codigoFinal).Tables(0)
    End Function

    Public Function EjecutarReporte_Part_Linea(ByVal codigoInicial As String, ByVal codigoFinal As String, ByVal Familia As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_PART_SP_ARTICULO_LINEA", codigoInicial, codigoFinal, Familia).Tables(0)
    End Function

    Public Function EjecutarReporte_Part_Tipo(ByVal codigoInicial As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_PART_SP_ARTICULO_TIPO", codigoInicial).Tables(0)
    End Function


    'LETRAS
    Public Function EjecutarReporteLetrasPlanilla_Pago(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETRA_PLANILLA_IMPRIM_PAY", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteLetrasPlanilla(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETRA_PLANILLA_IMPRIM", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function Montos_S(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_PLANILLA_IMPRIM_S", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Montos_S_Pago(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_PLANILLA_IMPRIM_S_PAY", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_Registro_Vendedores(ByVal Estado As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "VEN_SP_S_SALES_REP", Estado).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Montos_N_Pago(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_PLANILLA_IMPRIM_N", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function VerificacionDocumentosDetraccion(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_DOC_DETRACCION", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function ClienteRetencion(ByVal _CodigoCliente As String) As DataTable
        Try
            Dim Query As String = String.Empty
            Query = "SELECT ISNULL(RETENTION,0) AS [RETENTION] FROM CUSTOMER WHERE ID= '" & _CodigoCliente & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Query).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function ClienteRetencionPay(ByVal _CodigoCliente As String) As DataTable
        Try
            Dim Query As String = String.Empty
            Query = "SELECT ISNULL(RETENTION,0) AS [RETENTION] FROM VENDOR WHERE ID= '" & _CodigoCliente & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Query).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function CuentasBancos(ByVal _CodigoBanco As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_BANK_ACCOUNT", _CodigoBanco).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function CuentasBancos_Pagos(ByVal _CodigoBanco As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_BANK_ACCOUNT_PAY", _CodigoBanco).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function MostrandoDescripcion(ByVal Consulta As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ''LETRAS
    Public Function EjecutarReporteLetras(ByVal ClienteIni As String, ByVal ClienteFin As String, ByVal VendedorIni As String, ByVal VendedorFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REPORTE_LETRAS", ClienteIni, ClienteFin, VendedorIni, VendedorFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocumentosPendientes_Vendedor(ByVal Codigo As String, ByVal _fecha_inicial As String, ByVal _fecha_final As String, ByVal _opcion As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR")
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_VEND_PEND_DOC_II", Codigo, _fecha_inicial, _fecha_final, _opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_Plan_Cob_Cliente_Codigo(ByVal Codigo As String, ByVal opcion As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REPORTE_PLAN_COB_CLIENTE_CODIGO", Codigo, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_Plan_Cob_Cliente_Codigo_PF(ByVal Codigo As String, ByVal opcion As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REPORTE_PLAN_COB_CLIENTE_CODIGO_PF", Codigo, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_Plan_Cob_Cliente_Codigo_CR(ByVal Codigo As String, ByVal opcion As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REPORTE_PLAN_COB_CLIENTE_CODIGO_CR", Codigo, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_Plan_Pagos_Proveedor_Codigo(ByVal Codigo As String, ByVal opcion As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REPORTE_PLAN_PAGOS_PROVEEDOR_CODIGO", Codigo, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_Plan_Cob_Cliente(ByVal Codigo As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REPORTE_PLAN_COB_CLIENTE", Codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocuementosPendientesCliente(ByVal CodigoClientes As String, ByVal _opcion As String, ByVal _fecha_inicial As String, _
                                                                ByVal _fecha_final As String, ByVal _opcion_reporte As String, ByVal _opt_ret_saldos As String, _
                                                                ByVal _num_serie As String, ByVal _opt_moneda As String, ByVal _tipo_doc As String) As DataTable
        Try
            If _opcion = "0" Then
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR_III", _fecha_inicial, _fecha_final, _opcion_reporte, _num_serie, _opt_moneda, _tipo_doc)
                'Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR_II_I").Tables(0)
            Else
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_III", CodigoClientes, _fecha_inicial, _fecha_final, _opcion_reporte, _num_serie, _opt_moneda, _tipo_doc)
                'Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR_II_I").Tables(0)
            End If
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR_II_II", _opt_ret_saldos).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocuementosPendientesVendedor(ByVal CodigoClientes As String, ByVal _opcion As String, ByVal _fecha_inicial As String, _
                                                                ByVal _fecha_final As String, ByVal _opcion_reporte As String, ByVal _opt_ret_saldos As String, _
                                                                ByVal _num_serie As String, ByVal _opt_moneda As String, ByVal _tipo_doc As String) As DataTable
        Try
            If _opcion = "0" Then
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_REP_VENDEDOR_PEND_DOC_VENDEDOR_III", _fecha_inicial, _fecha_final, _opcion_reporte, _num_serie, _opt_moneda, _tipo_doc)
                'Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR_II_I").Tables(0)
            Else
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_REP_VENDEDOR_PEND_DOC_III", CodigoClientes, _fecha_inicial, _fecha_final, _opcion_reporte, _num_serie, _opt_moneda, _tipo_doc)
                'Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR_II_I").Tables(0)
            End If
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR_II_II", _opt_ret_saldos).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocuementosPendientesCliente_gerencial(ByVal CodigoClientes As String, ByVal _opcion As String, ByVal _fecha_inicial As String, _
                                                                ByVal _fecha_final As String, ByVal _opcion_reporte As String, ByVal _opt_ret_saldos As String, _
                                                                ByVal _num_serie As String, ByVal _opt_moneda As String, ByVal _tipo_doc As String) As DataTable
        Try
            If _opcion = "0" Then
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR_II_GERENCIAL", _fecha_inicial, _fecha_final, _opcion_reporte, _num_serie, _opt_moneda, _tipo_doc)
            Else
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_II_GERENCIAL", CodigoClientes, _fecha_inicial, _fecha_final, _opcion_reporte, _num_serie, _opt_moneda, _tipo_doc)
            End If
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR_II_II_GERENCIAL", _opt_ret_saldos).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_PLanilla_Cobranza(ByVal CodigoClientes As String, ByVal opcion As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "REC_LIQUIDACION_COBRANZA2", CodigoClientes, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function EjecutarReporte_PLanilla_Cobranza_PF(ByVal CodigoClientes As String, ByVal opcion As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "REC_LIQUIDACION_COBRANZA2_PF", CodigoClientes, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_PLanilla_Cobranza_CR(ByVal CodigoClientes As String, ByVal opcion As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "REC_LIQUIDACION_COBRANZA2_CR", CodigoClientes, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_PLanilla_Pagos(ByVal CodigoClientes As String, ByVal opcion As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "REC_LIQUIDACION_PAGOS2", CodigoClientes, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Obtener_Datos_Empresa() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_COMPANY").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Obtener_Rpt_Consulta_Stock(ByVal _codigo As String, ByVal _stock_cero As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REP_CONSULTA_STOCK", _codigo, _stock_cero).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocuementosPendientesProveedor(ByVal CodigoClientes As String, ByVal _tipo_doc As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_PAY", CodigoClientes, _tipo_doc).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocuementosPendientesCliente_Pago(ByVal CodigoClientes As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_PAY", CodigoClientes).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function EjecutarReporteDocumentosCancelados(ByVal FechaIni As String, ByVal FechaFin As String, ByVal ClienteIni As String, ByVal ClienteFin As String, ByVal VendedorIni As String, ByVal VendedorFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_REPORTE_DOC_CANCELADOS", FechaIni, FechaFin, ClienteIni, ClienteFin, VendedorIni, VendedorFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocumentosCancelados_Pago(ByVal FechaIni As String, ByVal FechaFin As String, ByVal ClienteIni As String, _
                                                             ByVal ClienteFin As String, ByVal VendedorIni As String, ByVal VendedorFin As String, _
                                                             ByVal ConceptoPago As String, ByVal grupo_pago As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_REPORTE_DOC_CANCELADOS_PAY_I", FechaIni, FechaFin, ClienteIni, ClienteFin, VendedorIni, ConceptoPago, grupo_pago).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocumentosCancelados_Pago_Diario(ByVal FechaIni As String, ByVal FechaFin As String, ByVal ClienteIni As String, ByVal ClienteFin As String, ByVal VendedorIni As String, ByVal VendedorFin As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "SP_PAGOS_PROVEEDOR_DIARIO", FechaIni, FechaFin)
            Return SqlHelper.ExecuteDataset(cn, "SP_REP_PAGOS_DIARIO_PIVOT").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function ExportarSQLExcel_Rep_Pagos_Efectuada_Diario(ByVal dt_reg_concar As DataTable, ByVal Ruta As String, ByVal NombreArchivo As String)
        'Proceso de conección e instruccion SELECT * FROM

        Dim MiDataSet As New DataSet
        Dim Columnas, Filas As Integer
        Dim valor_celda As String
        Dim columna_fecha As String
        Dim fecha_puente As Date
        Try
            '=============================Proceso de carga del dataset========================================
            If dt_reg_concar.Rows.Count <= 0 Then
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en DataSet :" & ex.Message)
        End Try
        '===================================Fin del proceso===================================================

        '=======================Aquí comprueba si Excel está instalado en el PC===============================

        Dim Excel As Object = CreateObject("Excel.Application")
        If Excel Is Nothing Then
            MsgBox("Al parecer Excel no està instalado en su PC. El funcionamiento de este proceso exige tener MS Excel instalado en su PC.", MsgBoxStyle.Critical)
            Return Nothing
            Exit Function
        End If
        '======================================================================================================

        '=================================Aqui comienza el proceso de Exportación a Excel======================
        Try
            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()

                Dim i As Integer = 1
                For Columnas = 0 To dt_reg_concar.Columns.Count - 1
                    'For Columnas = 0 To MiDataSet.Tables(0).Columns.Count - 1
                    .cells(1, i).value = dt_reg_concar.Columns(Columnas).ColumnName 'MiDataSet.Tables(0).Columns(Columnas).ColumnName
                    .cells(1, i).EntireRow.Font.Bold = True
                    i += 1
                Next
                i = 2
                Dim k As Integer = 1
                For Columnas = 0 To dt_reg_concar.Columns.Count - 1 'MiDataSet.Tables(0).Columns.Count - 1
                    i = 2

                    For Filas = 0 To dt_reg_concar.Rows.Count - 1 'MiDataSet.Tables(0).Rows.Count - 1

                        If k = 1 Or k = 3 Or k = 2 Or k = 5 Or k = 11 Or k = 15 Then
                            ' .Cells(1, k).EntireColumn.NumberFormat = "@"
                            .Cells(i, k).EntireColumn.NumberFormat = "@"
                        Else
                            '.Cells(i, k).numberformat = "@"
                        End If
                        If Columnas >= 16 Then
                            valor_celda = IIf(IsDBNull(dt_reg_concar.Rows(Filas).ItemArray(Columnas)), 0, dt_reg_concar.Rows(Filas).ItemArray(Columnas)) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            If valor_celda = "" Or Val(valor_celda) = 0 Then
                                .Cells(i, k).Value = 0
                            Else
                                .Cells(i, k).Value = CDbl(valor_celda)
                            End If
                        Else
                            .Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                        End If
                        '.Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                        i += 1
                    Next
                    k += 1
                Next
                '===================Aquí es donde guarda el archivo en la ruta especificada=====================

                .ActiveCell.Worksheet.SaveAs(Ruta & NombreArchivo & ".xls")
            End With
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
            Excel = Nothing
            '==================================================================================================

        Catch ex As Exception
            MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical, "Error de proceso")
            Return Nothing
            Exit Function
        End Try

        ' El archivo excel se crea y se abre para insertar los valores.
        Dim Proceso() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
        For Each Pro As Process In Proceso
            Pro.Kill()
            'Advertimos que el trabajo de exportacion se ha realizado exitosamente
            MsgBox("Los datos han sido exportados correctamente.", MsgBoxStyle.Information)
        Next
        Return Excel
    End Function
    Public Function EjecutarReporteDocumentosVencimiento(ByVal FechaIni As String, ByVal FechaFin As String, ByVal ClienteIni As String, ByVal ClienteFin As String, ByVal VendedorIni As String, ByVal VendedorFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_CXC_S_S_DOC_PENDIENTES_VENCIDOS", FechaIni, FechaFin, ClienteIni, ClienteFin, VendedorIni, VendedorFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function EjecutarReporteDocumentosVencimiento_Fechas(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_CXC_S_S_DOC_PENDIENTES_VENCIDOS_FECHAS", FechaIni, FechaFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocumentos_Mensuales(ByVal Mes_ As Integer, ByVal Anio_ As Integer, ByVal Opcion As String, ByVal Serie As String, ByVal Documentos As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_CXC_S_S_DOC_PENDIENTES_EMITIDOS_MENSUALES", Mes_, Anio_, Opcion, Serie, Documentos).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocumentosEmision_Fechas(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_CXC_S_S_DOC_PENDIENTES_EMITIDOS_FECHAS", FechaIni, FechaFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function EjecutarReporteDocumentosVencimiento_Fechas_Pago(ByVal FechaIni As String, ByVal FechaFin As String, ByVal _tipo_doc As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_CXC_S_S_DOC_PENDIENTES_VENCIDOS_PAY", FechaIni, FechaFin, _tipo_doc).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocumentosEmision_Fechas_Pago(ByVal FechaIni As String, ByVal FechaFin As String, ByVal _tipo_doc As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_CXC_S_S_DOC_PENDIENTES_EMITIDOS_PAY", FechaIni, FechaFin, _tipo_doc).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDocumentos_Mensual_Pago(ByVal mes_ As Integer, ByVal anio_ As Integer, ByVal opcion_ As Integer, ByVal fecha_ As Date) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_CXP_S_S_DOC_PENDIENTES_EMITIDOS_MENSUAL_PAY_II", mes_, anio_, opcion_, fecha_).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



End Class
