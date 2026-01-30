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

    Public Function NIVEL_ACCESO(ByVal CODIGO As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_NIVEL_ACCESO", CODIGO).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
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
            Throw
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
            Throw
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
            Throw
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
            Throw
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
            Throw
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
            Throw
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
            MsgBox(ex.Message)
            Throw
        End Try
    End Function


    Public Function Get_MostrarDescripcionArticulo_TipoArticulo(ByVal _TipoArticulo As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_PRODUCTOS", _TipoArticulo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
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
            Throw
        End Try
    End Function


    Public Sub ActualizandoNumeroAnalisis(ByVal _idlamacen As String, ByVal _documentId As String, _
                                          ByVal _NumeroDocumento As String)
        Try
            SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_WAREHOUSE_TRANS_NUM_ANALISIS", _idlamacen, _documentId, _NumeroDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
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
            Throw
        End Try
    End Sub

    Public Function get_DatosGeneralesAlmacen(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function


    Public Function get_VerificarGuiaAnalisis(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_VERIFICAR_GUIA_ANALISIS", alm_, doc_, num_).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
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
            Throw
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
            Throw
        End Try
    End Function


    Public Function Get_RetornarAlmacenes(ByVal _ACCESOALAMACEN As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_AYUDA", _ACCESOALAMACEN).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function Get_MostrarArticulos() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function
    '-------------GUIA DE REMISION ----
    Public Function EjecutarReporteGuiaRemision(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
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
            Throw
        End Try
    End Function

    Public Function EjecutarReporteLetrasPlanilla(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETRA_PLANILLA_IMPRIM", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function


    Public Function Montos_S(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_PLANILLA_IMPRIM_S", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function Montos_S_Pago(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_PLANILLA_IMPRIM_S_PAY", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporte_Registro_Vendedores(ByVal Estado As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "VEN_SP_S_SALES_REP", Estado).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function Montos_N_Pago(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_PLANILLA_IMPRIM_N", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function VerificacionDocumentosDetraccion(ByVal _CodigoPlanilla As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_DOC_DETRACCION", _CodigoPlanilla).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function


    Public Function ClienteRetencion(ByVal _CodigoCliente As String) As DataTable
        Try
            Dim Query As String = String.Empty
            Query = "SELECT ISNULL(RETENTION,0) AS [RETENTION] FROM CUSTOMER WHERE ID= '" & _CodigoCliente & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Query).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function ClienteRetencionPay(ByVal _CodigoCliente As String) As DataTable
        Try
            Dim Query As String = String.Empty
            Query = "SELECT ISNULL(RETENTION,0) AS [RETENTION] FROM VENDOR WHERE ID= '" & _CodigoCliente & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Query).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function


    Public Function CuentasBancos(ByVal _CodigoBanco As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_BANK_ACCOUNT", _CodigoBanco).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function CuentasBancos_Pagos(ByVal _CodigoBanco As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_BANK_ACCOUNT_PAY", _CodigoBanco).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function MostrandoDescripcion(ByVal Consulta As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    ''LETRAS
    Public Function EjecutarReporteLetras(ByVal ClienteIni As String, ByVal ClienteFin As String, ByVal VendedorIni As String, ByVal VendedorFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REPORTE_LETRAS", ClienteIni, ClienteFin, VendedorIni, VendedorFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporteDocumentosPendientes_Vendedor(ByVal Codigo As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR")
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_VEND_PEND_DOC", Codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporte_Plan_Cob_Cliente_Codigo(ByVal Codigo As String, ByVal opcion As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REPORTE_PLAN_COB_CLIENTE_CODIGO", Codigo, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function Reporte_Caja_Chica(ByVal Codigo As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CCAJA_CHICA_SP_RPT_RECEIVABLE_CAJA_CHICA", Codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporte_Plan_Pagos_Proveedor_Codigo(ByVal Codigo As String, ByVal opcion As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REPORTE_PLAN_PAGOS_PROVEEDOR_CODIGO", Codigo, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporte_Plan_Cob_Cliente(ByVal Codigo As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SP_REPORTE_PLAN_COB_CLIENTE", Codigo).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporteDocuementosPendientesCliente(ByVal CodigoClientes As String, ByVal _opcion As String) As DataTable
        Try
            If _opcion = "0" Then
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_VENDEDOR").Tables(0)
            Else
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC", CodigoClientes).Tables(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporte_PLanilla_Cobranza(ByVal CodigoClientes As String, ByVal opcion As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "REC_LIQUIDACION_COBRANZA2", CodigoClientes, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporte_PLanilla_Varios_CChica(ByVal _fecha_inicio As String, ByVal _fecha_fin As String, ByVal _cod_concepto As String, ByVal _cod_personal As String, ByVal _cod_rendicion As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CCAJA_CHICA_SP_RPT_RECEIVABLE_CAJA_CHICA_VARIOS", _fecha_inicio, _fecha_fin, _cod_concepto, _cod_personal, _cod_rendicion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporte_PLanilla_Pagos(ByVal CodigoClientes As String, ByVal opcion As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "REC_LIQUIDACION_PAGOS2", CodigoClientes, opcion).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function Obtener_Datos_Empresa() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_COMPANY").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporteDocuementosPendientesProveedor(ByVal CodigoClientes As String) As DataTable
        Try
            ''Ya esttuve aqui proveedor
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_PAY", CodigoClientes).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporteDocuementosPendientesCliente_Pago(ByVal CodigoClientes As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC_PAY", CodigoClientes).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function


    Public Function EjecutarReporteDocumentosCancelados(ByVal FechaIni As String, ByVal FechaFin As String, ByVal ClienteIni As String, ByVal ClienteFin As String, ByVal VendedorIni As String, ByVal VendedorFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_REPORTE_DOC_CANCELADOS", FechaIni, FechaFin, ClienteIni, ClienteFin, VendedorIni, VendedorFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporteDocumentosCancelados_Pago(ByVal FechaIni As String, ByVal FechaFin As String, ByVal ClienteIni As String, ByVal ClienteFin As String, ByVal VendedorIni As String, ByVal VendedorFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_REPORTE_DOC_CANCELADOS_PAY", FechaIni, FechaFin, ClienteIni, ClienteFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function EjecutarReporteDocumentosCancelados_Pago_Diario(ByVal FechaIni As String, ByVal FechaFin As String, ByVal ClienteIni As String, ByVal ClienteFin As String, ByVal VendedorIni As String, ByVal VendedorFin As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "SP_PAGOS_PROVEEDOR_DIARIO", FechaIni, FechaFin)
            Return SqlHelper.ExecuteDataset(cn, "SP_REP_PAGOS_DIARIO_PIVOT").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
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
            Throw
        End Try
    End Function


    Public Function EjecutarReporteDocumentosVencimiento_Fechas(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_CXC_S_S_DOC_PENDIENTES_VENCIDOS_FECHAS", FechaIni, FechaFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function


    Public Function EjecutarReporteDocumentosVencimiento_Fechas_Pago(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_CXC_S_S_DOC_PENDIENTES_VENCIDOS_PAY", FechaIni, FechaFin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function



End Class
