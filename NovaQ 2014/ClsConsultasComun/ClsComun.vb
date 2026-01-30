Imports LibConexion
Imports System.Data.SqlClient
Imports LibComunVar

Public Class ClsComun
    Implements IDisposable

    Private LibData As LibConexion.ClsData

    Public Function GuardarTipoCambio(ByVal fecha As Date, ByVal compra As Double, ByVal venta As Double) As Integer
        Try
            LibData = New ClsData

            Dim parametros As SqlParameter() = {LibData.DatosParam("@CURRENCY_ID", SqlDbType.VarChar, 2, "ME"),
                                                LibData.DatosParam("@CURRENCY_DATE", SqlDbType.Date, 0, fecha),
                                                LibData.DatosParam("@BUY_RATE", SqlDbType.Decimal, 15, compra),
                                                LibData.DatosParam("@BUY_EQUIV", SqlDbType.Decimal, 15, 0),
                                                LibData.DatosParam("@SELL_RATE", SqlDbType.Decimal, 15, venta),
                                                LibData.DatosParam("@SELL_EQUIV", SqlDbType.Decimal, 15, 0),
                                                LibData.DatosParam("@USUARIO", SqlDbType.VarChar, 100, LibComunVar.ClsVarComun.USUARIO),
                                                LibData.DatosParam("@TERMINAL", SqlDbType.VarChar, 100, Environment.MachineName)}

            Dim ok As Boolean = LibData.Run_Store_Procedure("ADM_SP_I_CURRENCY_EXCHANGE", parametros)

            LibData.Dispose()
            LibData = Nothing

            If ok Then
                Return 1
            Else
                Return -1
            End If


        Catch ex As Exception
            Call MostrarError(ex.Message)
            Return -2
        End Try
    End Function

    Public Function get_Lista_ubigeo() As DataTable
        Try
            dtTable = New DataTable
            LibData = New LibConexion.ClsData
            dtTable = LibData.Run_SP_DataTable("lista_ubigeo")
            LibData.Dispose()
            LibData = Nothing
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function get_TipoCambio(ByVal DTFecha As Date) As DataTable
        Try
            dtTable = New DataTable
            LibData = New LibConexion.ClsData
            dtTable = LibData.Run_SP_DataTable("HSP_TIPO_CAMBIO", _
                                LibData.DatosParam("@FECHA", SqlDbType.Date, 0, DTFecha))
            LibData.Dispose()
            LibData = Nothing
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function Lista_Datos_TCambio(ByVal STRNombreStore As String, ByRef daAdaptador As SqlClient.SqlDataAdapter, _
                                            ByVal STRAnyo As String, ByVal STRMes As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable(STRNombreStore, daAdaptador, _
                                    LibData.DatosParam("@ano", SqlDbType.VarChar, 4, STRAnyo), _
                                    LibData.DatosParam("@mes", SqlDbType.VarChar, 2, STRMes))
            LibData = Nothing
            Return dtTable
        Catch ex As Exception
            Throw
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
