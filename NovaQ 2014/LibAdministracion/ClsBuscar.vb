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

    Public Function ConsultaPerfil(ByVal _codigo As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_DETALLE_PERFIL", _codigo).Tables(0)
    End Function

    Public Function Eliminar_Perfil(ByVal _codigo As String) As Boolean
        Try
            SqlHelper.ExecuteNonQuery(cn, "ADM_SP_D_ELIMINA_PERFIL", _codigo)
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function Inserta_PtoVentas(ByVal cCab As ClsDocSerieTO.Cab_Pto_Venta, _
                                   ByVal cDet As List(Of ClsDocSerieTO.Det_Doc_Serie), _
                                   ByVal STRInsUpd As String) As Boolean
        Try
            With cCab
                SqlHelper.ExecuteNonQuery(cn, "ADM_INSERT_PTO_VENTA", .CodPtoVenta, .Descripcion, .Direccion, .CodAlmacen, STRInsUpd)
            End With
            ''BORRANDO
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "Delete from DOCUMENT_PLACE_SALES where PLACE_SALES_ID=" & cCab.CodPtoVenta)
            For Each detalle As ClsDocSerieTO.Det_Doc_Serie In cDet
                SqlHelper.ExecuteNonQuery(cn, "ADM_INSERT_DOC_PTO_VENTA", cCab.CodPtoVenta, detalle.TipoDoc, detalle.Serie)
            Next
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
        Return True
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

    Public Function EjecutarReporteRequisiciones(ByVal _Tipo As String, ByVal _Numero As String) As DataTable
        Return SqlHelper.ExecuteDataset(cn, "RPT_COMPRAS_REQUISICIONES", _Tipo, _Numero).Tables(0)
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








End Class
