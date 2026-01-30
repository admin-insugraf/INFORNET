Imports LibConexion

Public Class ClsProcesos
    Implements IDisposable


    Private LibDataTipo As LibConexion.ClsDataTipo
    Private LibData As LibConexion.ClsData

    Public Function Actualiza_Status_Orden(ByVal STRNumPedido As String, ByVal STRStatus As String) As Boolean
        Try
            Dim BOLOk As Boolean = False
            LibData = New LibConexion.ClsData
            BOLOk = LibData.Run_Store_Procedure("SAL_ACTUALIZA_STATUS_ORDEN", _
                            LibData.DatosParam("@ID", SqlDbType.VarChar, 7, STRNumPedido), _
                            LibData.DatosParam("@STATUS_ORDER", SqlDbType.VarChar, 40, STRStatus))
            LibData = Nothing
            Return BOLOk
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function Factura_OrdenCompra(ByVal STRNumOrden As String, ByVal STRTipoDoc As String, ByVal STRNumSerie As String, _
                                    ByVal STRNumDocumento As String, ByVal DBLTipoCambio As Double, _
                                    ByVal STRNotaIngreso As String) As Boolean
        Try
            Dim BOLOk As Boolean = False
            LibData = New LibConexion.ClsData
            BOLOk = LibData.Run_Store_Procedure("SUP_FACTURA_ORDEN_COMPRA",
                            LibData.DatosParam("@NUMBER_ORDER", SqlDbType.VarChar, 7, STRNumOrden), _
                            LibData.DatosParam("@DOCUMENT_ID", SqlDbType.VarChar, 2, STRTipoDoc), _
                            LibData.DatosParam("@NUMBER_SERIE", SqlDbType.VarChar, 3, STRNumSerie), _
                            LibData.DatosParam("@NUMBER_DOCUMENT_FAC", SqlDbType.VarChar, 20, STRNumDocumento), _
                            LibData.DatosParam("@SELL_RATE", SqlDbType.Float, 0, DBLTipoCambio), _
                            LibData.DatosParam("@NOTE_IN_ID", SqlDbType.VarChar, 50, STRNotaIngreso))
            LibData = Nothing
            Return BOLOk
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function Inserta_OrdenCompra(ByVal cCab As ClsOrdenCompraTO.Cab_Ordenes_TO, _
                                   ByVal cDet As List(Of ClsOrdenCompraTO.Det_Ordenes_TO), _
                                   ByRef STRNumeroPedido As String) As Boolean
        Try
            Dim BOLOk As Boolean = False
            LibDataTipo = New LibConexion.ClsDataTipo

            BOLOk = LibDataTipo.Run_Store_Procedure("SUP_GENERA_ORDEN_CAB", _
                                            STRNumeroPedido, "@ID", _
                            LibDataTipo.DatosParam("@ID", SqlDbType.VarChar, 7, STRNumeroPedido, ParameterDirection.Output), _
                            LibDataTipo.DatosParam("@ORDER_DATE", SqlDbType.SmallDateTime, 0, cCab.FechaPedido, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@CADUCATE_DATE", SqlDbType.SmallDateTime, 0, cCab.FechaVencimiento, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@SALES_ID", SqlDbType.VarChar, 2, cCab.CodVendedor, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@PLACE_SALES", SqlDbType.VarChar, 2, cCab.PtoVenta, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@CUSTOMER_ID", SqlDbType.VarChar, 11, cCab.CodCliente, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@CUSTOMER_NAME", SqlDbType.VarChar, 70, cCab.NomCliente, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@CUSTOMER_ADDR", SqlDbType.VarChar, 100, cCab.Direccion, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@VAT_REGISTRATION", SqlDbType.VarChar, 11, cCab.Ruc, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@AMOUNT", SqlDbType.Float, 0, cCab.PrecioVenta, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@TERMS", SqlDbType.VarChar, 4, cCab.FormaPago, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@SELL_RATE", SqlDbType.Float, 0, cCab.TipoCambio, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@CURRENCY_ID", SqlDbType.VarChar, 3, cCab.CodMoneda, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@STATUS", SqlDbType.VarChar, 1, cCab.Estado, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@USER_ID", SqlDbType.VarChar, 8, cCab.CodUsuario, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@COMMENT", SqlDbType.VarChar, 100, cCab.Comentario, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@AMOUNT_VAT", SqlDbType.Float, 0, cCab.ValorIGV, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@AMOUNT_ISC", SqlDbType.Float, 0, cCab.ValorISC, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@STATUS_ORDER", SqlDbType.VarChar, 40, cCab.EstatusPedido, ParameterDirection.Input))
            LibDataTipo = Nothing

            BOLOk = False
            LibData = New LibConexion.ClsData
            For Each detalle As ClsOrdenCompraTO.Det_Ordenes_TO In cDet
                BOLOk = LibData.Run_Store_Procedure("SUP_GENERA_ORDEN_DET", _
                                    LibData.DatosParam("@ID", SqlDbType.VarChar, 7, STRNumeroPedido), _
                                    LibData.DatosParam("@ITEM", SqlDbType.VarChar, 3, detalle.Item), _
                                    LibData.DatosParam("@PART_ID", SqlDbType.VarChar, 20, detalle.CodParte), _
                                    LibData.DatosParam("@PART_DESCRIPTION", SqlDbType.VarChar, 64, detalle.DescripcionParte), _
                                    LibData.DatosParam("@QTY", SqlDbType.Float, 0, detalle.Cantidad, 15, 6), _
                                    LibData.DatosParam("@PRICE_SALES", SqlDbType.Float, 0, detalle.Precio, 15, 6), _
                                    LibData.DatosParam("@PRICE_ORI", SqlDbType.Float, 0, detalle.PrecioCalculo, 15, 6), _
                                    LibData.DatosParam("@AMOUNT_TAX", SqlDbType.Float, 0, detalle.MontoIGV, 15, 6), _
                                    LibData.DatosParam("@PERCENT_TAX", SqlDbType.Float, 0, detalle.PorIGV, 15, 6), _
                                    LibData.DatosParam("@AMOUNT_ISC", SqlDbType.Float, 0, detalle.MontoISC, 15, 6), _
                                    LibData.DatosParam("@PERCENT_ISC", SqlDbType.Float, 0, detalle.PorISC, 15, 6), _
                                    LibData.DatosParam("@AMOUNT_US", SqlDbType.Float, 0, detalle.MontoDolares, 15, 6), _
                                    LibData.DatosParam("@AMOUNT", SqlDbType.Float, 0, detalle.MontoSoles, 15, 6), _
                                    LibData.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, detalle.CodAlmacen), _
                                    LibData.DatosParam("@LOT", SqlDbType.VarChar, 20, detalle.SerieLote), _
                                    LibData.DatosParam("@UNIT", SqlDbType.VarChar, 6, detalle.UniMed))
            Next
            LibData = Nothing
            Return BOLOk
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
