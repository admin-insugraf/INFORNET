Imports LibConexion
Public Class ClsConsultas
    Implements IDisposable

    Private LibData As LibConexion.ClsData

    Public Function get_Lista_Pedidos(ByVal DTFechaInicio As Date, ByVal DTFechaFin As Date) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_LIST_PEDIDOS", _
                        LibData.DatosParam("@fecha_ini", SqlDbType.SmallDateTime, 0, DTFechaInicio), _
                        LibData.DatosParam("@fecha_fin", SqlDbType.SmallDateTime, 0, DTFechaFin))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function get_Pedido(ByVal STRNumPedido As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_LISTA_PEDIDO", _
                        LibData.DatosParam("@id", SqlDbType.VarChar, 7, STRNumPedido))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function get_Direcciones_Cliente(ByVal STRCodCliente As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            'dtTable = LibData.Run_SP_DataTable("SAL_HLP_ADDR_CLIENTES", _
            dtTable = LibData.Run_SP_DataTable("SAL_HLP_DIRECC_CLIENTES", _
                        LibData.DatosParam("@customer_id", SqlDbType.VarChar, 11, STRCodCliente))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Sub get_All_Productos(ByRef STRProIni As String, ByRef STRProNomIni As String, _
                                ByRef STRProFin As String, ByRef STRProNomFin As String)
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_HLP_ALL_PRODUCTOS")
            If dtTable.Rows.Count > 0 Then
                STRProIni = dtTable.Rows(0).Item(0).ToString
                STRProNomIni = dtTable.Rows(0).Item(1).ToString
                STRProFin = dtTable.Rows(0).Item(2).ToString
                STRProNomFin = dtTable.Rows(0).Item(3).ToString
            Else
                STRProIni = String.Empty
                STRProNomIni = String.Empty
                STRProFin = String.Empty
                STRProNomFin = String.Empty
            End If
            dtTable.Dispose()
            LibData.Dispose()
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Sub
    Public Sub get_All_Clientes(ByRef STRCliIni As String, ByRef STRCliNomIni As String, _
                                ByRef STRCliFin As String, ByRef STRCliNomFin As String)
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_HLP_ALL_CLIENTES")
            If dtTable.Rows.Count > 0 Then
                STRCliIni = dtTable.Rows(0).Item(0).ToString
                STRCliNomIni = dtTable.Rows(0).Item(1).ToString
                STRCliFin = dtTable.Rows(0).Item(2).ToString
                STRCliNomFin = dtTable.Rows(0).Item(3).ToString
            Else
                STRCliIni = String.Empty
                STRCliNomIni = String.Empty
                STRCliFin = String.Empty
                STRCliNomFin = String.Empty
            End If
            dtTable.Dispose()
            LibData.Dispose()
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Sub

    Public Sub get_All_Vendedores(ByRef STRVenIni As String, ByRef STRVenNomIni As String, _
                                ByRef STRVenFin As String, ByRef STRVenNomFin As String)
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_HLP_ALL_VENDEDORES")
            If dtTable.Rows.Count > 0 Then
                STRVenIni = dtTable.Rows(0).Item(0).ToString
                STRVenNomIni = dtTable.Rows(0).Item(1).ToString
                STRVenFin = dtTable.Rows(0).Item(2).ToString
                STRVenNomFin = dtTable.Rows(0).Item(3).ToString
            Else
                STRVenIni = String.Empty
                STRVenNomIni = String.Empty
                STRVenFin = String.Empty
                STRVenNomFin = String.Empty
            End If
            dtTable.Dispose()
            LibData.Dispose()
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Sub

    Public Function get_Lista_Transacciones_Cab(ByVal STRFechaIni As Date, ByVal STRFechaFin As Date) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_LIST_DOCUMENTOS_FECHA_CAB", _
                        LibData.DatosParam("@fecha_ini", SqlDbType.Date, 0, STRFechaIni),
                        LibData.DatosParam("@fecha_fin", SqlDbType.Date, 0, STRFechaFin))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function get_Lista_Transacciones_Det(ByVal STRFechaIni As Date, ByVal STRFechaFin As Date) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_LIST_DOCUMENTOS_FECHA_DET", _
                        LibData.DatosParam("@fecha_ini", SqlDbType.Date, 0, STRFechaIni),
                        LibData.DatosParam("@fecha_fin", SqlDbType.Date, 0, STRFechaFin))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: eliminar estado administrado (objetos administrados).
            End If

            ' TODO: liberar recursos no administrados (objetos no administrados) e invalidar Finalize() below.
            ' TODO: Establecer campos grandes como Null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: invalidar Finalize() sólo si la instrucción Dispose(ByVal disposing As Boolean) anterior tiene código para liberar recursos no administrados.
    'Protected Overrides Sub Finalize()
    '    ' No cambie este código. Ponga el código de limpieza en la instrucción Dispose(ByVal disposing As Boolean) anterior.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose(disposing As Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
