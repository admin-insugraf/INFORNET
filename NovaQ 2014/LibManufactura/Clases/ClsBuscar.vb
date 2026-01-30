Imports LibConexion
Imports LibComunVar
Imports System.Data.SqlClient
Imports LibCobranzas
Imports System.IO

Public Class ClsBuscar
    Private LibData As LibConexion.ClsData
    Private drDatos As SqlClient.SqlDataReader
    Private dtDetallesConsulta As DataTable

    Dim cn As SqlConnection
    Dim dataBL As New LibConexion.ClsData

    Public Sub New()
        cn = dataBL.ConexionBD
    End Sub

    Public Function Get_RetornarAlmacenes(ByVal _ACCESOALAMACEN As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_AYUDA_I", _ACCESOALAMACEN).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_Detalle_Archivos(ByVal _id_formula As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_RECEIVABLE_LIST_LINE_PAY_FILES", _id_formula).Tables(0)
    End Function

    Public Function Get_Imprimir_Orden_produccion(ByVal codigo_op As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "MANUFAC_SP_S_PRODUCCION_OP", codigo_op).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function EliminaArchivo(ByVal num_planilla As String, ByVal item As String, ByVal item_archivo As Integer) As Boolean
        Try
            LibData = New ClsData
            EliminaArchivo = LibData.Run_Store_Procedure("COB_ELIMINA_ARCHIVO", _
                            LibData.DatosParam("@num_planilla", SqlDbType.VarChar, 15, num_planilla), _
                            LibData.DatosParam("@item", SqlDbType.VarChar, 3, item), _
                            LibData.DatosParam("@item_archivo", SqlDbType.VarChar, 3, item_archivo))
            LibData = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Ver_Archivo(ByVal num_planilla As String, ByVal item As String, ByVal item_archivo As Integer) As SqlClient.SqlDataReader
        Try
            LibData = New ClsData
            Ver_Archivo = LibData.Run_SP_DataReader("SP_FORMULAS_VER_ARCHIVO", _
                            LibData.DatosParam("@num_planilla", SqlDbType.VarChar, 15, num_planilla), _
                            LibData.DatosParam("@item", SqlDbType.VarChar, 3, item), _
                            LibData.DatosParam("@item_archivo", SqlDbType.VarChar, 3, item_archivo))
            LibData = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function GrabarArchivo(ByVal STRRutaArchivo As String, ByVal _codPlanilla As String, ByVal item As String, _
                                  ByVal STRExtension As String, ByVal STRNombre As String, ByVal INTtam As Integer, _
                                  ByVal STRUsuario As String, ByVal pc_name As String, ByVal item_archivo As Integer, ByVal descripcion As String) As Boolean
        Try
            Dim ruta As New FileStream(STRRutaArchivo, FileMode.Open, FileAccess.Read)

            Dim binario(ruta.Length - 1) As Byte
            ruta.Read(binario, 0, binario.Length) 'Leo el archivo y lo convierto a binario 
            ruta.Close() 'Cierro el FileStream 

            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "Guardar_Archivo_Formulas", STRExtension, _codPlanilla, item, _
                                          descripcion, binario, INTtam, STRUsuario, pc_name, item_archivo, descripcion)

                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                estados = False
            End Try
            Return estados

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_Imprimir_Orden_Desarrollo(ByVal codigo_op As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "MANUFAC_SP_S_ORDEN_DESARROLLO", codigo_op).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_Imprimir_Orden_produccion_II(ByVal codigo_op As Integer, ByVal item_op As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "MANUFAC_SP_S_PRODUCCION_OP_II", codigo_op, item_op).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_Imprimir_Requerimiento_Orden_produccion(ByVal codigo_op As Integer) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "MANUFAC_SP_S_REQUERIMIENTO_PRODUCCION_OP", codigo_op).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function get_DatosGenerales_Produccion_Op(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
        Try

            Return SqlHelper.ExecuteDataset(cn, "MANUFACTURA_SP_S_PRODUCCION_OP_PRINCIPAL_I", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function get_DatosGenerales_Ordenes_Desarrollo(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
        Try

            Return SqlHelper.ExecuteDataset(cn, "MANUFACTURA_SP_S_ORDEN_DESARROLLO_PRINCIPAL_I", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function get_DatosGenerales_Requerimiento_Produccion_Op(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
        Try

            Return SqlHelper.ExecuteDataset(cn, "MANUFACTURA_SP_S_REQUERIMIENTO_PRODUCCION_OP_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function

    Public Function get_DatosGenerales_Produccion_Op_Liquidacion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
        Try

            Return SqlHelper.ExecuteDataset(cn, "MANUFACTURA_SP_S_PRODUCCION_OP_PRINCIPAL_LIQUIDACION", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Function


    Public Function get_DatosGeneralesAlmacen_E_S(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ALMACEN As String) As DataTable
        Try

            'Dim alma As String = String.Empty
            'alma = MostrandoAlmacenes()
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_TRANS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ALMACEN).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function GET_DEVOLVER_DATOS_ENVIO_EMAIL(ByVal _CODIGO As String) As DataTable
        Try

            'Dim alma As String = String.Empty
            'alma = MostrandoAlmacenes()
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_DATOS_ENVIO_EMAIL", _CODIGO).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener_Datos_Empresa() As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_COMPANY").Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GET_MENSAJE(ByVal _CODIGO_ALMACEN As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_DOCUMENT As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_LINE_MENSAJE", _CODIGO_ALMACEN, _DOCUMENT_ID, _NUMBER_DOCUMENT).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GET_LIBERACION_PT(ByVal _CODIGO_ALMACEN As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_DOCUMENT As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_LINE_MENSAJE", _CODIGO_ALMACEN, _DOCUMENT_ID, _NUMBER_DOCUMENT).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Detalle_Correo(ByVal _DOCUMENT_ID As String, ByVal _SERIE As String, ByVal _NUMBER_DOCUMENT As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "SALimprimeRegistroDevolucion", _DOCUMENT_ID, _SERIE, _NUMBER_DOCUMENT).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Detalle_Correo_Requisiciones(ByVal _NUMBER_DOCUMENT As String, ByVal _TIPO As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_COMPRAS_REQUISICIONES", _NUMBER_DOCUMENT, _TIPO).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function




    Public Function get_DatosGeneralesAlmacen_E_S_Control(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ALMACEN As String, ByVal _Estado As String) As DataTable
        Try
            If _Estado = "APROBADOS" Then
                _Estado = "L"
            ElseIf _Estado = "RECHAZADOS" Then
                _Estado = "R"
            ElseIf _Estado = "CUARENTENA" Then
                _Estado = "C"
            End If
            'Dim alma As String = String.Empty
            'alma = MostrandoAlmacenes()
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_TRANS_PRINCIPAL_CONTROL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ALMACEN, _Estado).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Documentos_Liberacion_PT(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                              ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ALMACEN As String, ByVal _Estado As String) As DataTable
        Try
            If _Estado = "APROBADOS" Then
                _Estado = "L"
            ElseIf _Estado = "RECHAZADOS" Then
                _Estado = "R"
            ElseIf _Estado = "CUARENTENA" Then
                _Estado = "C"
            End If
            'Dim alma As String = String.Empty
            'alma = MostrandoAlmacenes()
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_TRANS_PRINCIPAL_CONTROL_PT", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ALMACEN, _Estado).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Sub ActualizandoNumeroAnalisis(ByVal _idlamacen As String, ByVal _documentId As String, _
                                          ByVal _NumeroDocumento As String)
        Try
            SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_WAREHOUSE_TRANS_NUM_ANALISIS", _idlamacen, _documentId, _NumeroDocumento)
        Catch ex As Exception
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
            Throw
        End Try
    End Sub
    Public Function get_VerificarGuiaAnalisis(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_VERIFICAR_GUIA_ANALISIS", alm_, doc_, num_).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function EjecutarReporteGuiaAlmacen(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_RPT_NOTA_ING_SAL", alm_, doc_, num_).Tables(0)
    End Function

    Public Function Ejecutar_Lista_Dispensacion_x_OP(ByVal numero_op_ As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "INV_LISTA_DISPENSACIONES", numero_op_).Tables(0)
    End Function


    Public Function EjecutarReporteFormulacion(ByVal codigo As String, ByVal almacen As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_FORMULACION_FORMULAS", codigo, almacen).Tables(0)
    End Function

    Public Function EjecutarReporteOrdenProduccion(ByVal codigo As String, ByVal almacen As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SP_MUESTRA_OF", codigo, almacen).Tables(0)
    End Function

    Public Function EjecutarReporteOrdenCompra(ByVal codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "PUR_RPT_PURCHASE_ORDER_ORI", codigo, "OC").Tables(0)
    End Function

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
End Class
