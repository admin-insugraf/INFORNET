Imports LibConexion
Imports LibComunVar
Imports System.Data.SqlClient
Public Class ClsAyudas
    Private LibData As LibConexion.ClsData
    Private drDatos As SqlClient.SqlDataReader

    Dim cn As SqlConnection
    Dim dataBL As New LibConexion.ClsData

    Public Sub New()
        cn = dataBL.ConexionBD
    End Sub

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

    Public Function get_Series_Reg_Ventas(ByVal STRptoVenta As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_SERIES_REG_VENTAS", _
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

            dtTable = LibData.Run_SP_DataTable("SAL_TIPO_DOC_PTO_VENTAS", _
                        LibData.DatosParam("@PLACE_SALES_ID", SqlDbType.VarChar, 50, STRPtoVenta))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function get_Tipo_Doc_Pto_Venta_Pedido(ByVal STRPtoVenta As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_TIPO_DOC_PTO_VENTAS_PEDIDO", _
                        LibData.DatosParam("@PLACE_SALES_ID", SqlDbType.VarChar, 50, STRPtoVenta))
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
                        LibData.DatosParam("@cod_compania", SqlDbType.VarChar, 50, ""))
            'LibData.DatosParam("@cod_compania", SqlDbType.VarChar, 50, ClsVarComun.BaseDatos))
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

    Public Function Get_MostrarDescripcion(ByVal cadena As String) As DataTable
        Try
            dtTable = New DataTable
            'LibData = New LibConexion.ClsData
            'dtTable = LibData.Run_Query_DataTable(cadena)
            dtTable = SqlHelper.ExecuteDataset(cn, CommandType.Text, cadena).Tables(0)
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function
End Class
