Imports LibConexion
Imports LibComunVar
Imports System.Data.SqlClient
Imports LibCobranzas
Imports System.Windows.Forms

Public Class ClsBuscar
    Private LibData As LibConexion.ClsData
    Private drDatos As SqlClient.SqlDataReader

    Dim cn As SqlConnection
    Dim dataBL As New LibConexion.ClsData

    Public Sub New()
        cn = dataBL.ConexionBD
    End Sub

    Public Function Obtener_Datos_Empresa() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_COMPANY").Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Verificar_Devolucion_Rep_Medico(ByVal tipo_doc As String, ByVal num_doc_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_S_WAREHOUSE_TRANS_VERIF_DEV_REP_MEDICO", tipo_doc, num_doc_).Tables(0)
    End Function
    Public Function Get_obtenerdatos_Transaccion(ByVal TYPE_ID As String, ByVal MOV_ID As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_TRASACCTION_TYPE", TYPE_ID, MOV_ID).Tables(0)
    End Function
    Public Function NIVEL_ACCESO(ByVal CODIGO As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_NIVEL_ACCESO", CODIGO).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function MostrandoDescripcion(ByVal Consulta As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function get_VerificarEnvioEmail(ByVal transaccion_ As String, ByVal tipo_ As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_TRANSACTION_TYPE_OPCION_ENVIO_EMAIL", transaccion_, tipo_).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_Vendedores() As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("SAL_HLP_SALES")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
        End Try
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
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
            Call MostrarError(ex.Message)
        End Try
    End Function




    '-----Guias Ingresos y Salidas
    Public Function Get_MostrarDescripcion(ByVal _Cadena As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, _Cadena).Tables(0)
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function Busquedas(ByVal _Consulta As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_MostrarDescripcionFiltros(ByVal _Cadena As String, ByVal _Filtro As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_MostrarDescripcionFiltros(ByVal _Cadena As String, ByVal _Filtro1 As String, ByVal _Filtro2 As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1, _Filtro2).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_MostrarDescripcionFiltros(ByVal _Cadena As String, ByVal _Filtro1 As String, ByVal _Filtro2 As String, ByVal _Filtro3 As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1, _Filtro2, _Filtro3).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_MostrarDescripcionFiltros(ByVal _Cadena As String, ByVal _Filtro1 As String, ByVal _Filtro2 As String, ByVal _Filtro3 As String, ByVal _Filtro4 As String) As DataTable
        Try
            If _Filtro4 = "''" Then _Filtro4 = ""
            Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1, _Filtro2, _Filtro3, _Filtro4).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Get_InventarioMostrarDescripcionFiltros(ByVal _Cadena As String, ByVal _Filtro1 As String, Optional ByVal _Filtro2 As String = "") As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro1, _Filtro2).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Get_MostrarDescripcionFiltrosSeleccionMultiple(ByVal _Filtro As String) As DataTable
        Try
            Dim query As String = String.Empty
            If _Filtro = String.Empty Then
                query = "SELECT DISTINCT LOT_ID AS [CODIGO] , COMMENT AS [DESCRIPCION]  FROM LOT ORDER BY LOT_ID DESC"
            Else
                query = "SELECT DISTINCT LOT_ID AS [CODIGO] , COMMENT AS [DESCRIPCION]  FROM LOT WHERE WHO_ID  in (" & _Filtro & ")"
            End If
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Get_MostrarDetalles(ByVal _Cadena As String, ByVal _Filtro As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, _Cadena, _Filtro).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function




    Public Function Get_MostrarDescripcionArticulo_TipoArticulo(ByVal _TipoArticulo As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_PRODUCTOS", _TipoArticulo).Tables(0)
        Catch ex As Exception
            Call MostrarError(ex.Message)
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
            SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_NUMBER_ANALISIS", _idlamacen, _documentId, _NumeroDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Sub

    Public Sub ActualizandoEstadoControl_C(ByVal _idlamacen As String, ByVal _documentId As String, _
                                      ByVal _NumeroDocumento As String)
        Try
            SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_STATUS_CONTROL", _idlamacen, _documentId, _NumeroDocumento)
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


    Private Function MostrandoAlmacenes() As String
        Dim Cadena As String = String.Empty
        Try

            Dim dtAlmacen = New DataTable
            dtAlmacen = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WAREHOUSE_AYUDA").Tables(0)
            If dtAlmacen.Rows.Count() <> 0 Then
                Dim id As String = ""
                Dim i As Integer = 0
                Do While i <= dtAlmacen.Rows.Count() - 1
                    id = id & """" & dtAlmacen.Rows(i).Item("CODIGO") & """" & ","
                    i = i + 1
                Loop
                id = Mid(id, 1, id.Length - 1)
                Cadena = id
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Cadena
    End Function


    Public Function DatosGeneralesGuiaAnalisis(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                               ByVal _ALMACEN As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_GUIA_ANALISIS", _FECHA_INI, _FECHA_FIN, _OPCION, _ALMACEN).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_DatosGeneralesAlmacen_E_S(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ALMACEN As String, _ALMACEN_BUSQUEDA As String) As DataTable
        Try
            ' Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_TRANS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ALMACEN).Tables(0)
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_TRANS_PRINCIPAL_MOV_I", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ALMACEN, _ALMACEN_BUSQUEDA).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_DatosGeneralesAlmacen_E_S_Parte_Entrega(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ALMACEN As String, _ALMACEN_BUSQUEDA As String) As DataTable
        Try
            ' Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_TRANS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ALMACEN).Tables(0)
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_PARTE_ENTREGA_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
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
    Public Function EjecutarReporteDetallesInventario(ByVal Documento As String, ByVal almacen As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_ALM_INVETARIO_DETALLES", Documento, almacen).Tables(0)
    End Function



    Public Function EjecutarReporteGuiaAlmacen(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
    End Function

    Public Function EjecutarReporteGuiaAlmacen_Parte_Entrega(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String, ByVal _id_cab As Integer) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL_PARTE_ENTREGA_LINE", alm_, doc_, num_, _id_cab).Tables(0)
    End Function


    Public Function EjecutarReporteGuiaAnalisis(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
    End Function

    '----kARDEX CON REFERENCIA

    Public Function Get_MostrarAlmacenes(ByVal _ACCESOALAMACEN As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_AYUDA", _ACCESOALAMACEN).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Get_MostrarLineas_Ayuda(ByVal _codigo_familia As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_FAMILY_AYUDA", _codigo_familia).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_MostrarProductos_Ayuda(ByVal _codigo_familia As String, ByVal _codigo_tipo_Articulos As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_PRODUCTOS_FAMILIA_TIPO_ARTICULO", _codigo_familia, _codigo_tipo_Articulos).Tables(0)
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

    '--------------RECALCULO DE STOCK

    Public Function Get_MesSinValorizar() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WH_TRANS_RECAL_STOCK").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    '--------------REVALORIZACION DE INVENTARIOS
    Public Function Get_MesSinRevalorizar() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "INV_ULTIMA_FECHA_CIERRE").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_TipoCambioCero() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "INV_TIPO_CAMBIO_CERO", "V", "I").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_DocumentosSinValorizar() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "INV_TIPO_CAMBIO_CERO", "V", "NI", "A", "N", "N", "N").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_SaldoNegativo() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "INV_SALDOS_NEGATIVOS").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function Get_ValidacionStockArticulo() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "INV_VALIDACION_STKART", "N", "N", "N").Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



    Public Function UltimoCierre() As String
        Dim dtmonth As DataTable
        dtmonth = New DataTable
        dtmonth = SqlHelper.ExecuteDataset(cn, "RPT_R_STOCK_CIERRE_MES").Tables(0)

        If dtmonth.Rows.Count() <> 0 Then
            UltimoCierre = dtmonth.Rows(0).Item("Tot").ToString
        Else
            UltimoCierre = ""
        End If
    End Function

    Public Function Get_Revalorizalotes(ByVal IDE As String, ByVal Almacen As String, fechaINI As String, _
                                             ByVal fechaFIN As String, ByVal progreso As ProgressBar) As DataTable
        Try
            Dim dtmes As DataTable
            dtmes = New DataTable
            Dim cMesActu = String.Empty
            Dim cMesCirr As String = String.Empty
            Dim mes_actual As String = String.Empty
            Dim ano_actual As String = String.Empty
            Dim cAnoMes As String = String.Empty

            Dim mes_Ant = String.Empty
            Dim ano_Ant = String.Empty
            Dim mesPost = String.Empty
            Dim anoPost = String.Empty
            'creando tabla Temporal
            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "RPT_R_STOCK_CREAR_MES")
            'Insertando datos tabla
            Dim i As Integer = 0
            Dim Fechainicial As String = String.Empty
            Do While CDate(fechaINI) <= CDate(fechaFIN)
                Fechainicial = (DateDiff("d", fechaINI, "01/01/1900") * -1)
                SqlHelper.ExecuteNonQuery(cn, "RPT_R_STOCK_MES", Fechainicial)
                fechaINI = DateAdd("M", 1, fechaINI)
                i = i + 1
            Loop
            'Recorriendo datos de los meses
            dtmes = SqlHelper.ExecuteDataset(cn, "RPT_R_STOCK_GET_MES").Tables(0)
            For j As Integer = 0 To dtmes.Rows.Count() - 1
                mes_actual = Format(Month(dtmes.Rows(j).Item("FECHAS")), "00")
                ano_actual = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                cMesCirr = UltimoCierre()
                cAnoMes = ano_actual & mes_actual
                If cMesCirr <> "" Then
                    If cAnoMes <= cMesCirr Then
                        MsgBox("Hay meses cerrados en el rango de fechas", vbInformation, "Aviso")
                        Exit Try
                    End If
                End If
            Next
            progreso.Minimum = 0
            progreso.Maximum = 100
            For j As Integer = 0 To dtmes.Rows.Count() - 1
                progreso.Value = j
                mes_actual = Format(Month(dtmes.Rows(j).Item("FECHAS")), "00")
                If Month(dtmes.Rows(j).Item("FECHAS")) = 1 Then
                    mes_Ant = "12"
                    mes_actual = "01"
                    mesPost = "02"
                    anoPost = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    ano_Ant = Format(Year(dtmes.Rows(j).Item("FECHAS")) - 1, "0000")
                    ano_actual = Year(dtmes.Rows(j).Item("FECHAS"))
                Else
                    mes_Ant = Format(Month(dtmes.Rows(j).Item("FECHAS")) - 1, "00")
                    mes_actual = Format(Month(dtmes.Rows(j).Item("FECHAS")), "00")
                    ano_Ant = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    ano_actual = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    mesPost = Format(Month(DateAdd("M", 1, dtmes.Rows(j).Item("FECHAS"))), "00")
                    If mes_actual = "12" Then
                        anoPost = Year(DateAdd("YYYY", 1, dtmes.Rows(j).Item("FECHAS")))
                    Else
                        anoPost = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    End If
                End If
                SqlHelper.ExecuteNonQuery(cn, "INV_MORESMESLOT", IDE, Almacen, mes_Ant, ano_Ant, mes_actual, ano_actual)
                progreso.PerformStep()
            Next
            SqlHelper.ExecuteNonQuery(cn, "INV_RECALCULO_STOCK_LOTE", Almacen, mesPost, anoPost)
            progreso.Value = 100
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Get_RevalorizaTodos(ByVal IDE As String, ByVal Almacen As String, fechaINI As String, _
                                            ByVal fechaFIN As String, ByVal progreso As ProgressBar) As DataTable
        Try
            Dim dtmes As DataTable
            dtmes = New DataTable
            Dim cMesActu = String.Empty
            Dim cMesCirr As String = String.Empty
            Dim mes_actual As String = String.Empty
            Dim ano_actual As String = String.Empty
            Dim cAnoMes As String = String.Empty

            Dim mes_Ant As String = String.Empty
            Dim ano_Ant As String = String.Empty
            Dim mesPost As String = String.Empty
            Dim anoPost As String = String.Empty

            Dim sAnoMes As String = String.Empty
            Dim sAnoMesAnt As String = String.Empty
            Dim sAnoMesFinal As String = String.Empty
            Dim sAnoMesAnterior As String = String.Empty
            Dim dateFechaFicticia As Date


            sAnoMes = Year(fechaINI) & Format(Month(fechaINI), "00")
            sAnoMesAnt = Year(fechaINI) & Format(Month(DateAdd("m", -1, CDate(fechaINI))), "00")
            sAnoMesFinal = DateSerial(Year(CDate(fechaFIN)), Month(CDate(fechaFIN)) + 2, Microsoft.VisualBasic.DateAndTime.Day(CDate(fechaFIN)))
            sAnoMesFinal = Year(fechaFIN) & Format(Month(fechaFIN), "00")
            sAnoMesAnterior = DateSerial(Year(CDate(fechaINI)), Month(CDate(fechaINI)) - 1, Microsoft.VisualBasic.DateAndTime.Day(CDate(fechaINI)))
            sAnoMesAnterior = Year(sAnoMesAnterior) & Format(Month(sAnoMesAnterior), "00")


            'creando tabla Temporal
            SqlHelper.ExecuteNonQuery(cn, "INV_TEMP_STKART", IDE & "TMPSTKART")
            'Crea Temporal TMPVWMORESMESINGSAL
            dateFechaFicticia = CDate("01/" & Format(Month(fechaINI), "00") & "/" & Year(fechaINI))
            fechaFIN = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0).ToString("dd") & "/" & Month(fechaFIN) & "/" & Year(fechaFIN)

            Dim DfechaFicticia As String = String.Empty
            Dim DsFechaFinal As String = String.Empty
            DfechaFicticia = (DateDiff("d", dateFechaFicticia, "01/01/1900") * -1)
            DsFechaFinal = (DateDiff("d", fechaFIN, "01/01/1900") * -1)

            SqlHelper.ExecuteNonQuery(cn, "INV_TEMP_MORESMESINGSAL", IDE & "TMPVWMORESMESINGSAL", DfechaFicticia, DsFechaFinal)

            'Crea Temporal TMPMOREMES
            SqlHelper.ExecuteNonQuery(cn, "INV_TEMP_TMPMOREMES", IDE, sAnoMesAnterior, sAnoMesFinal, sAnoMes)



            'creando tabla Temporal
            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "RPT_R_STOCK_CREAR_MES")
            'Insertando datos tabla
            Dim i As Integer = 0
            Dim Fechainicial As String = String.Empty
            Do While CDate(fechaINI) <= CDate(fechaFIN)
                Fechainicial = (DateDiff("d", fechaINI, "01/01/1900") * -1)
                SqlHelper.ExecuteNonQuery(cn, "RPT_R_STOCK_MES", Fechainicial)
                fechaINI = DateAdd("M", 1, fechaINI)
                i = i + 1
            Loop
            'Recorriendo datos de los meses
            dtmes = SqlHelper.ExecuteDataset(cn, "RPT_R_STOCK_GET_MES").Tables(0)
            For j As Integer = 0 To dtmes.Rows.Count() - 1
                mes_actual = Format(Month(dtmes.Rows(j).Item("FECHAS")), "00")
                ano_actual = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                cMesCirr = UltimoCierre()
                cAnoMes = ano_actual & mes_actual
                If cMesCirr <> "" Then
                    If cAnoMes <= cMesCirr Then
                        MsgBox("Hay meses cerrados en el rango de fechas", vbInformation, "Aviso")
                        Exit Try
                    End If
                End If
            Next
            progreso.Minimum = 0
            progreso.Maximum = 100
            For j As Integer = 0 To dtmes.Rows.Count() - 1
                progreso.Value = j
                mes_actual = Format(Month(dtmes.Rows(j).Item("FECHAS")), "00")
                If Month(dtmes.Rows(j).Item("FECHAS")) = 1 Then
                    mes_Ant = "12"
                    mes_actual = "01"
                    mesPost = "02"
                    anoPost = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    ano_Ant = Format(Year(dtmes.Rows(j).Item("FECHAS")) - 1, "0000")
                    ano_actual = Year(dtmes.Rows(j).Item("FECHAS"))
                Else
                    mes_Ant = Format(Month(dtmes.Rows(j).Item("FECHAS")) - 1, "00")
                    mes_actual = Format(Month(dtmes.Rows(j).Item("FECHAS")), "00")
                    ano_Ant = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    ano_actual = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    mesPost = Format(Month(DateAdd("M", 1, dtmes.Rows(j).Item("FECHAS"))), "00")
                    If mes_actual = "12" Then
                        anoPost = Year(DateAdd("YYYY", 1, dtmes.Rows(j).Item("FECHAS")))
                    Else
                        anoPost = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    End If
                End If
                SqlHelper.ExecuteNonQuery(cn, "INV_MORESMESLOT", IDE, Almacen, mes_Ant, ano_Ant, mes_actual, ano_actual)
                progreso.PerformStep()
            Next
            SqlHelper.ExecuteNonQuery(cn, "INV_RECALCULO_STOCK_LOTE", Almacen, mesPost, anoPost)
            progreso.Value = 100
        Catch ex As Exception
            Throw
        End Try
    End Function




End Class
