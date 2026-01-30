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


    Public Function NIVEL_ACCESO(ByVal CODIGO As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ADM_NIVEL_ACCESO", CODIGO).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EjecutarReporte_Mov_Almacen_x_Orden_Compra(ByVal codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "COMPRA_S_MOV_ALMACEN_X_OC_II", codigo, "OC").Tables(0)
    End Function

    Public Function Imprimir_Orden_Pago(ByVal ID As String, ByVal num_orden_pago As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_RPT_ODEN_PAGO", ID, num_orden_pago).Tables(0)
    End Function
    Public Function EjecutarReportePagosSemanal(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        Try
            Dim sql As String
            sql = "exec COMPRAS_SP_S_PAGOS_SEMANAL '" & FechaIni & "','" & FechaFin & "'"
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
            Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_PAGOS_SEMANAL_REP").Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EjecutarReporte_Mov_Almacen_x_Orden_Compra_Movs_Compras(ByVal codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "COMPRA_S_MOV_ALMACEN_X_OC_MOVS_COMPRAS", codigo, "OC").Tables(0)
    End Function

    Public Function EjecutarReporte_Guia_Devolucion(ByVal _Tipo As String, ByVal _Numero As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_ALM_GUIA_DEVOLUCION", _Tipo, _Numero).Tables(0)
    End Function

    Public Function EjecutarReporteRequisiciones_RM(ByVal _Tipo As String, ByVal _Numero As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_COMPRAS_REQUISICIONES_RM", _Tipo, _Numero).Tables(0)
    End Function

    Public Function MostrandoDescripcion(ByVal Consulta As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EjecutarReporteMorosidadPagos(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, ByVal vendedor_final As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_PROYECCION_PAGOS", FechaIni, FechaFin, cliente_inicial, cliente_final, vendedor_inicial, vendedor_final, TODOS, "1").Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EjecutarReporteProyPagos(ByVal FechaIni As String, ByVal FechaFin As String, _
                                            ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, ByVal vendedor_final As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_PROYECCION_PAGOS", FechaIni, FechaFin, cliente_inicial, cliente_final, vendedor_inicial, vendedor_final, TODOS, "1").Tables(0)
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

    Public Function BuscarRequisiciones_OrdenServicio(ByVal codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "COMPRA_S_PURCHASE_ORDER_SERVICIO", codigo, "OS").Tables(0)
    End Function


    Public Function Get_MostrarDescripcion(ByVal _Cadena As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, _Cadena).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function BuscarRequisiciones_OrdenCompra(ByVal codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "COMPRA_S_PURCHASE_ORDER", codigo, "OC").Tables(0)
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

    Public Function EjecutarReporteRequisiciones(ByVal _Tipo As String, ByVal _Numero As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_COMPRAS_REQUISICIONES", _Tipo, _Numero).Tables(0)
    End Function

    Public Function EjecutarReporteRequisiciones_Imprenta(ByVal _Tipo As String, ByVal _Numero As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_COMPRAS_REQUISICIONES_IMPRENTA", _Tipo, _Numero).Tables(0)
    End Function

    Public Function EjecutarReporteOrdenCompra(ByVal codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "PUR_RPT_PURCHASE_ORDER_ORI", codigo, "OC").Tables(0)
    End Function


    Public Function EjecutarReporteCompra(ByVal codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_COMPRA_SP_S_REGISTRO_COMPRAS", codigo).Tables(0)
    End Function


    Public Function EjecutarReporteCompras(ByVal fecha_ini As String, ByVal fecha_fin As String, ByVal TipoDoc As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "SP_REGISTRO_COMPRAS_SUNAT ", fecha_ini, fecha_fin, TipoDoc).Tables(0)
    End Function

    Public Function Get_Tipos_Documentos() As DataTable
        Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "COMPRAS_SP_TIPO_DOC ").Tables(0)
    End Function

    Public Function EjecutarReporteCompras_Cuadro_comparativo(ByVal Cotizacion As String, ByVal fecha_ini As String, ByVal fecha_fin As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_COMPRAS_CUADRO_COMPARATIVO ", Cotizacion, fecha_ini, fecha_fin).Tables(0)
    End Function

    Public Function Get_FormaPagoFechaVencimiento(ByVal Codigo As String) As DataTable
        Dim Descripcion As String = String.Empty
        Try
            Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_I_R_F_PAGO_FECHA", Codigo).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListaCotizaciones(ByVal Fecha_ini As String, ByVal fecha_fin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LISTA_SOLICITUDES", Fecha_ini, fecha_fin).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function


    Public Function EjecutarReporteOrdenServicio(ByVal codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "PUR_RPT_PURCHASE_ORDER_ORI_OS", codigo, "OS").Tables(0)
    End Function

    Public Function EjecutarReporteOrdenServicio_Imprenta(ByVal codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "PUR_RPT_PURCHASE_ORDER_ORI_OS_IMPRENTA", codigo, "OI").Tables(0)
    End Function

End Class
