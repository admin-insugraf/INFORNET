Imports LibConexion
Public Class ClsConsultas
    Implements IDisposable

    Private LibData As LibConexion.ClsData
    Private dtDatos As DataTable

    Public Function get_List_Areas() As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtDatos = New DataTable
            dtDatos = LibData.Run_Query_DataTable("Select id,description from area")
            Return dtDatos
            LibData = Nothing
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function get_OrdenCompra(ByVal STRNumOrden As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SAL_LISTA_ORDEN_COMPRA", _
                        LibData.DatosParam("@id", SqlDbType.VarChar, 7, STRNumOrden))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function get_Lista_Ordenes(ByVal DTFechaInicio As Date, ByVal DTFechaFin As Date) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable

            dtTable = LibData.Run_SP_DataTable("SUP_LIST_ORDENES", _
                        LibData.DatosParam("@fecha_ini", SqlDbType.SmallDateTime, 0, DTFechaInicio), _
                        LibData.DatosParam("@fecha_fin", SqlDbType.SmallDateTime, 0, DTFechaFin))
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
