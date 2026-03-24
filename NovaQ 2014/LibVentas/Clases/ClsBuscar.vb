Imports LibConexion
Imports LibComunVar
Imports System.Data.SqlClient
Imports LibCobranzas

Public Class ClsBuscar
    Private LibData As LibConexion.ClsData
    Private drDatos As SqlClient.SqlDataReader

    Dim cn As SqlConnection
    Dim dataBL As New LibConexion.ClsData

    Public Sub New()
        cn = dataBL.ConexionBD
    End Sub

    Public Function Get_Lista_Productos_Venta(ByVal _Almacen As String, ByVal _Producto As String, ByVal _Moneda As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "GUIA_SP_S_GUIA_REMISION_PART_POS_VENTA_2022", _Almacen, _Producto, _Moneda).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function

    Public Function Ejecutar_Cobranza_Efectuada(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, _
                                            ByVal vendedor_inicial As String, ByVal vendedor_final As String, ByVal documento_inicial As String, _
                                            ByVal documento_final As String, ByVal opcion As String, ByVal grupo_cobranza As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "COB_SP_LIQUIDACIONES_COBRANZAS_CLIENTE_CONSULTA", FechaIni, FechaFin, cliente_inicial, TODOS, grupo_cobranza).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function

    Public Function Mostrando_Proveedores_Rep() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PROV_SP_VENDOR").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function

    Public Function Mostrando_Familias_Rep() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PROV_SP_FAMILY").Tables(0)
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

    Public Function GET_MENSAJE(ByVal _CODIGO_ALMACEN As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_DOCUMENT As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_LINE_MENSAJE", _CODIGO_ALMACEN, _DOCUMENT_ID, _NUMBER_DOCUMENT).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteGuiaAlmacen(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
    End Function
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

    Public Function EjecutarRep_Ordenes(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal prod_inicial As String, ByVal prod_final As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_REP_ORDENES", FechaIni, FechaFin, prod_inicial, prod_final, TODOS).Tables(0)
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

    Public Function Obtener_Parametros_Empresa() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_PARAMETERS").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function

    Public Function NIVEL_ACCESO(ByVal CODIGO As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_NIVEL_ACCESO", CODIGO).Tables(0)
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

    Public Function Get_MostrarDescripcionFiltros_Adicional(ByVal _Cadena As String, ByVal _Filtro1 As String, Optional ByVal _Filtro2 As String = "", Optional ByVal _Filtro3 As String = "") As DataTable
        Try
            If _Filtro2 = String.Empty And _Filtro3 = String.Empty Then
                Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1).Tables(0)
            ElseIf _Filtro2 <> String.Empty And _Filtro3 = String.Empty Then
                Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1, _Filtro2).Tables(0)
            Else
                Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1, _Filtro2, _Filtro3).Tables(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function

    Public Function Get_ConsultaStockComprometido(ByVal _Cadena As String, ByVal _Filtro1 As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1).Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)

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
            MsgBox(ex.Message)

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
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_NombrePuntoVenta(ByVal Codigo As String) As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_PV", Codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_Cod_Cliente_nuevo() As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_CLIENTE_NUEVO").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Public Function FormaPagoFechaVencimiento(ByVal Codigo As String) As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_I_R_F_PAGO_FECHA", Codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ''FACTURACION VERFICACION ORDEN DE COMPRA

    Public Function Get_VerificacionOrdenCompra(ByVal _Cadena As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, _Cadena).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    '-------------impresion de la facturacion ----
    Public Function EjecutarReporteFacturacion(ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SALimprimefacturas", tipodoc_, serie_, num_).Tables(0)
    End Function
    Public Function Obtener_Nombre_Reporte(ByVal tipodoc_ As String, ByVal seriedoc_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SAL_SP_S_FORMAT_REPORT", tipodoc_, seriedoc_).Tables(0)
    End Function
    Public Function Verif_Contab_Ventas(ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_RECEIVABLE_CONTAB", tipodoc_, serie_, num_).Tables(0)
    End Function

    Public Function Verif_Contab_CR(ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String, ByVal id_compra_ As String, ByVal origen As String) As DataTable
        If origen = "COMPRAS" Then
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_PURCHASE_FACT_SUPPLIER_CR_CONTAB", tipodoc_, serie_, num_, id_compra_).Tables(0)
        ElseIf origen = "PAGOS" Then
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_PURCHASE_FACT_SUPPLIER_CR_CONTAB_PAGOS", tipodoc_, serie_, num_, id_compra_).Tables(0)
        End If

    End Function


    '-------------impresioncierreVentas ----


    Public Function EjecutarReporteCierreVentas_Año(ByVal ano As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_VENTAS_CIERRE_VENTAS_PROG_ANNO", ano).Tables(0)
    End Function

    Public Function EjecutarReporteCierreVentas_Mes(ByVal mes As String, ByVal ano As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_VENTAS_CIERRE_VENTAS_PROG_MES", mes, ano).Tables(0)
    End Function

    '-------------GUIA DE REMISION ----
    Public Function EjecutarReporteGuiaRemision(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
    End Function

    Public Function EjecutarReporteVoucher(ByVal CodAsientoContable As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_CONTA_SP_S_ASIENTO_CONTABLE", CodAsientoContable).Tables(0)
    End Function


    Public Function EjecutarConsulta(ByVal consulta As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
    End Function


    Public Function EjecutarReporteNotaCreditos_letras(ByVal alm_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "FT_CON_NC", alm_, serie_, num_).Tables(0)
    End Function

    '-------------COMPROBANTE DÉ PERCEPCION
    Public Function EjecutarReporteComprobantePercepcion(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SALimprimeComprobantePercepcion", alm_, doc_, num_).Tables(0)
    End Function

    Public Function Imprimir_Devolucion(ByVal tipo_ As String, ByVal serie As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SALimprimeRegistroDevolucion", tipo_, serie, num_).Tables(0)
    End Function

    Public Function Get_GuiasAsociadas(ByVal _Almacen As String, ByVal _NumeroReferencia As String, ByVal _Tipo_Doc_Referencia As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_GUIA_R", _Almacen, _NumeroReferencia, _Tipo_Doc_Referencia).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_Guias_Venta(ByVal _Almacen As String, ByVal _NumeroReferencia As String, ByVal _Tipo_Doc_Referencia As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_GUIA_VENTA_R", _Almacen, _NumeroReferencia, _Tipo_Doc_Referencia).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    '---Verificacion Docuemetos a  Anular
    Public Function Get_VerificacionDocumentosAnular(ByVal NombreStore As String, ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, NombreStore, tipodoc_, serie_, num_).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ''REPORTE DE DESPACHOS
    'Public Function EjecutarReporteDespacho(ByVal FechaIni As String, ByVal FechaFin As String, ByVal TipoDoc As String, ByVal TipoDespacho As String) As DataTable
    '    Try
    '        Return SqlHelper.ExecuteDataset(cn, "MOSTRAR_DESPACHO", FechaIni, FechaFin, TipoDoc, TipoDespacho).Tables(0)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    Public Function EjecutarReporteDespacho(ByVal FechaIni As String, ByVal FechaFin As String, ByVal TipoDoc As String, ByVal TipoDespacho As String, _
                                            ByVal TIPO As String, ByVal TODOS As String, ByVal FILTRO_1 As String, ByVal FILTRO_2 As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "MOSTRAR_DESPACHO_FILTROS", FechaIni, FechaFin, TipoDoc, TipoDespacho, TIPO, TODOS, FILTRO_1, FILTRO_2).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteProyCobranza(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, ByVal vendedor_final As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_PROYECCION_COBRANZA", FechaIni, FechaFin, cliente_inicial, cliente_final, vendedor_inicial, vendedor_final, TODOS).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteResumenCobranza(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, ByVal vendedor_final As String, ByVal documento_inicial As String, ByVal documento_final As String, ByVal opcion As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_RESUMEN_COBRANZA", FechaIni, FechaFin, cliente_inicial, cliente_final, vendedor_inicial, vendedor_final, documento_inicial, documento_final, TODOS, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_Estado_Cuenta_Cliente(ByVal FechaIni As String, ByVal FechaFin As String, _
                                             ByVal cliente_inicial As String, ByVal todos As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_RPT_ESTADO_CUENTA_CLIENTE", cliente_inicial, FechaIni, FechaFin, todos).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporte_Retenciones_Cliente(ByVal FechaIni As String, ByVal FechaFin As String, _
                                             ByVal cliente_inicial As String, ByVal todos As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_RPT_RETENCIONES_CLIENTE", cliente_inicial, FechaIni, FechaFin, todos).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarResumenPagos(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, ByVal vendedor_final As String, ByVal opcion As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_PROYECCION_PAGOS", FechaIni, FechaFin, cliente_inicial, cliente_final, vendedor_inicial, vendedor_final, TODOS, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarRepCentrosCostos(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal cc_inicial As String, ByVal cc_final As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_REP_CENTROS_COSTOS_PAGOS", FechaIni, FechaFin, cc_inicial, cc_final, TODOS).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarRep_Gastos_Movilidad(ByVal Fecha As String, ByVal Personal As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CCHICA_SP_S_RPT_GASTOS_MOVILIDAD", Personal, Fecha).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteCobranzaEfectuadaVendedor(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, _
                                            ByVal vendedor_inicial As String, ByVal vendedor_final As String, ByVal documento_inicial As String, _
                                            ByVal documento_final As String, ByVal opcion As String, ByVal opcion_cobro As String, ByVal grupo_cobro As String) As DataTable
        Try
            If opcion = "1" Then
                Return SqlHelper.ExecuteDataset(cn, "SP_LIQUIDACIONES_COBRANZAS_CLIENTE_I", FechaIni, FechaFin, cliente_inicial, cliente_final, TODOS, opcion_cobro, grupo_cobro).Tables(0)
            ElseIf opcion = "2" Then
                SqlHelper.ExecuteNonQuery(cn, "SP_LIQUIDACIONES_COBRANZAS", FechaIni, FechaFin, vendedor_inicial, vendedor_final, TODOS)
                Return SqlHelper.ExecuteDataset(cn, "COB_SP_S_COB_EFECTUADA_VENDEDOR").Tables(0)
            ElseIf opcion = "3" Then
                Return SqlHelper.ExecuteDataset(cn, "SP_LIQUIDACIONES_COBRANZAS_DOCUMENTO", FechaIni, FechaFin, documento_inicial, documento_final, TODOS).Tables(0)
            ElseIf opcion = "4" Then
                SqlHelper.ExecuteNonQuery(cn, "SP_COBRANZAS_CLIENTE_DIARIO", FechaIni, FechaFin)
                Return SqlHelper.ExecuteDataset(cn, "SP_REP_COBRANZA_DIARIO_PIVOT").Tables(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteCobranzaEfectuadaVendedor_Consulta(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, _
                                            ByVal vendedor_inicial As String, ByVal vendedor_final As String, ByVal documento_inicial As String, _
                                            ByVal documento_final As String, ByVal opcion As String, ByVal opcion_cobro As String) As DataTable
        Try
            If opcion = "1" Then
                Return SqlHelper.ExecuteDataset(cn, "COB_SP_LIQUIDACIONES_COBRANZAS_CLIENTE_CONSULTA", FechaIni, FechaFin, cliente_inicial, TODOS, opcion_cobro).Tables(0)
            ElseIf opcion = "2" Then
                'SqlHelper.ExecuteNonQuery(cn, "SP_LIQUIDACIONES_COBRANZAS", FechaIni, FechaFin, vendedor_inicial, vendedor_final, TODOS)
                'Return SqlHelper.ExecuteDataset(cn, "COB_SP_S_COB_EFECTUADA_VENDEDOR").Tables(0)
                Return SqlHelper.ExecuteDataset(cn, "SP_LIQUIDACIONES_COBRANZAS_VENDEDOR", FechaIni, FechaFin, vendedor_inicial, vendedor_final, TODOS).Tables(0)
            ElseIf opcion = "3" Then
                Return SqlHelper.ExecuteDataset(cn, "SP_LIQUIDACIONES_COBRANZAS_DOCUMENTO", FechaIni, FechaFin, documento_inicial, documento_final, TODOS).Tables(0)
            ElseIf opcion = "4" Then
                SqlHelper.ExecuteNonQuery(cn, "SP_COBRANZAS_CLIENTE_DIARIO", FechaIni, FechaFin)
                Return SqlHelper.ExecuteDataset(cn, "SP_REP_COBRANZA_DIARIO_PIVOT").Tables(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function

    Public Function EjecutarReporteCobSemanal(ByVal FechaIni As String, ByVal FechaFin As String, ByVal Cod_Cliente As String) As DataTable
        Try
            Dim sql As String
            sql = "exec CLI_SP_S_COB_SEMANAL '" & FechaIni & "','" & FechaFin & "'"
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
            Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_COB_SEMANAL_REP", Cod_Cliente).Tables(0)
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

    Public Function Obtener_LimiteCredito_Cliente(ByVal _codigo As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_CUSTOMER", _codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteDespachoGuias(ByVal FechaIni As String, ByVal FechaFin As String, ByVal TipoDespacho As String, _
                                                  ByVal TIPO As String, ByVal TODOS As String, ByVal FILTRO_1 As String, ByVal FILTRO_2 As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "MOSTRAR_DESPACHO_GUIAS_FILTROS", FechaIni, FechaFin, TipoDespacho, TIPO, TODOS, FILTRO_1, FILTRO_2).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    ''REPORTE DE VENTAS MENSUALES
    ''REPORTE DE VENTAS POR ARTICULO
    Public Function PuntoVenta() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "FACT_SP_S_R_VENTAS_ART_SALES_P").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_MostrarAlmacenes(ByVal _ACCESOALAMACEN As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_WAREHOUSE_AYUDA", _ACCESOALAMACEN).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function EjecutarReporteDetraccion(ByVal FechaIni As String, ByVal FechaFin As String, ByVal TipoDoc As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_FACT_SP_S_DOC_DETRACCION", FechaIni, FechaFin, TipoDoc).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EjecutarReporteVentasVendedorProducto(ByVal _Vendedor As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_VENTAS_VENDEDOR_PRODUCTO", _Vendedor, _Fecha_ini, _Fecha_fin).Tables(0)
    End Function

    Public Function EjecutarReporteVendedor_Licitacion(ByVal _Vendedor As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _opcion As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "VENTAS_SP_S_REP_NUM_ENTREGAS", _Fecha_ini, _Fecha_fin, _Vendedor, _opcion).Tables(0)
    End Function

    Public Function EjecutarReporteVentasClienteProducto(ByVal _Vendedor As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _Producto As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_VENTAS_CLIENTE_PRODUCTO_I", _Vendedor, _Fecha_ini, _Fecha_fin, _Producto).Tables(0)
    End Function

    Public Function EjecutarReporte_Parte_Entrega(ByVal _Vendedor As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _Producto As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "ALM_SP_RPT_PARTE_ENTREGA", _Fecha_ini, _Fecha_fin, _Vendedor, _Producto).Tables(0)
    End Function

    Public Function EjecutarReporteVentasClienteProducto_Familia(ByVal _Vendedor As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _Producto As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_VENTAS_CLIENTE_PRODUCTO_FAMILIA", _Vendedor, _Fecha_ini, _Fecha_fin, _Producto).Tables(0)
    End Function

    Public Function EjecutarReporte_Compras_Proveedor_Producto(ByVal _Proveedor As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _Producto As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_COMPRAS_PROVEEDOR_PRODUCTO_I", _Proveedor, _Fecha_ini, _Fecha_fin, _Producto).Tables(0)
    End Function

    Public Function EjecutarReporte_Compras_Proveedor_Producto_Familia(ByVal _Proveedor As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _Producto As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_COMPRAS_PROVEEDOR_PRODUCTO_FAMILIA", _Proveedor, _Fecha_ini, _Fecha_fin, _Producto).Tables(0)
    End Function

    Public Function EjecutarReporteVentasProveedorProducto(ByVal _Vendedor As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _Producto As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_VENTAS_PROVEEDOR_PRODUCTO_I", _Vendedor, _Fecha_ini, _Fecha_fin, _Producto).Tables(0)
    End Function

    Public Function Get_Reporte_FT_Letras(ByVal _opcion As Integer, ByVal _id_cliente As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_FACTURA_LETRAS", _opcion, _id_cliente, _Fecha_ini, _Fecha_fin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Get_Canje_de_Letras(ByVal _id_cliente As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _estado_canje As String, ByVal _opcion_ger As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_CANJE_LETRAS_I", _id_cliente, _Fecha_ini, _Fecha_fin, _estado_canje, _opcion_ger).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Get_Reporte_Modo_Pago(ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _modo_pago As String, _
                                          ByVal _forma_pago As String, ByVal _series As String, ByVal _vendedor As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_RPT_MODO_PAGO", _Fecha_ini, _Fecha_fin, _modo_pago, _forma_pago, _series, _vendedor).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Get_Rep_Estados_de_Letras(ByVal _id_estado As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _cliente As String, ByVal _num_letra As String, ByVal _tipo_Fecha As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_ESTADOS", _id_estado, _Fecha_ini, _Fecha_fin, _cliente, _num_letra, _tipo_Fecha).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Get_Rep_Estados_de_Letras_Pagos(ByVal _id_estado As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String, ByVal _cliente As String, ByVal _num_letra As String, ByVal _tipo_Fecha As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_ESTADOS_PAGOS", _id_estado, _Fecha_ini, _Fecha_fin, _cliente, _num_letra, _tipo_Fecha).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Get_ImprimirReporteII(ByVal _NombreProcedimiento As String, ByVal _fec_ini_ As String, ByVal fec_fin_ As String, _
                                          ByVal _Filtro As String, ByVal _tipo_Reporte As Integer, ByVal _cod_producto As String, _
                                          ByVal _lote_producto As String, ByVal numero_documento As String, Optional ByVal opcion2 As String = "") As DataTable
        Select Case _tipo_Reporte
            Case 2
                Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, _Filtro, _fec_ini_, fec_fin_, numero_documento, _cod_producto, _lote_producto, _tipo_Reporte, opcion2).Tables(0)
            Case Else
                Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, _Filtro, _fec_ini_, fec_fin_, _cod_producto, numero_documento, _lote_producto, _tipo_Reporte, opcion2).Tables(0)
        End Select
    End Function

    Public Function EjecutarReporteVentasProductoCliente(ByVal _Vendedor As String, ByVal _Fecha_ini As String, ByVal _Fecha_fin As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_VENTAS_PRODUCTO_CLIENTE", _Vendedor, _Fecha_ini, _Fecha_fin).Tables(0)
    End Function

    Public Function EjecutarReportePedidos(ByVal CodigoPedido As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_PED_PEDIDOS", CodigoPedido).Tables(0)
    End Function

    Public Function EjecutarReporte_Cotizaciones(ByVal CodigoPedido As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_PED_QUOTE", CodigoPedido).Tables(0)
    End Function

    Public Function EjecutarReporte_Lista_Cotizaciones(ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal vendedor As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_SP_COTIZACIONES", fecha_inicial, fecha_final, vendedor).Tables(0)
    End Function

    Public Function EjecutarReportePedidos_Formato_Cliente(ByVal CodigoPedido As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_PED_PEDIDOS_FORMATO_CLIENTES", CodigoPedido).Tables(0)
    End Function

End Class
