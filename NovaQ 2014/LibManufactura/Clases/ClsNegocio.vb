
Public Class ClsNegocio

    Public Class LETTER_EXCHANGE
        Dim datos As New ClsOperaciones.LETTER_EXCHANGE

        Public Function VerificacionNumeracion(ByVal _CodigoCliente As String, ByVal _TipoDoc As String, ByVal _Numero As String) As DataTable
            Return datos.VerificacionNumeracion(_CodigoCliente, _TipoDoc, _Numero)
        End Function

        Public Function EliminacionCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String ) As Boolean
            Return datos.EliminacionCarteraClientes(CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC )
        End Function


        Public Function ActualizandoCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String, _
                                                ByVal DOC_DATE As String, ByVal CADUCATE_DATE As String, ByVal SALES_ID As String, _
                                                ByVal CURRENCY_ID As String, ByVal SELL_RATE As String, ByVal USER_ID As String, _
                                                ByVal AMOUNT As String, ByVal SALDO As String) As Boolean
            Return datos.ActualizandoCarteraClientes(CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC, DOC_DATE, CADUCATE_DATE, SALES_ID, _
                                                     CURRENCY_ID, SELL_RATE, USER_ID, AMOUNT, SALDO)
        End Function

        Public Function GuardandoCarteraClientes(ByVal EntidadCliente As ClsEntidades.CUSTOMER_BALANCE) As Boolean
            Return datos.GuardandoCarteraClientes(EntidadCliente)
        End Function

        Public Function Get_ManualVendedor(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualVendedor(_Codigo)
        End Function

        Public Function MostrandoClientesManejoDocumentoDetalles(ByVal _Codigo As String) As DataTable
            Return datos.MostrandoClientesManejoDocumentoDetalles(_Codigo)
        End Function

        Public Function MostrandoClientesManejoDocumento() As DataTable
            Return datos.MostrandoClientesManejoDocumento()
        End Function

        Public Function MostrandoClientesDocPendientes() As DataTable
            Return datos.MostrandoClientesDocPendientes()
        End Function

        Public Function VerificacionClienteVendedor(ByVal Consulta As String) As DataTable
            Return datos.VerificacionClienteVendedor(Consulta)
        End Function


        Public Function GeneracionCambioEstadoLetra(ByVal LETTER_ID As String, ByVal BANK_ID As String, ByVal COMMENT As String, _
                                                   ByVal STATUS_ACT As String, ByVal NUMBER_ACCOUNT As String, ByVal NUMBER_BANK As String, ByVal UPDATE_DATE As String) As Boolean
            Return datos.GeneracionCambioEstadoLetra(LETTER_ID, BANK_ID, COMMENT, STATUS_ACT, NUMBER_ACCOUNT, NUMBER_BANK, UPDATE_DATE)
        End Function

        Public Function InsertDetallesLetra(ByRef entidad As ClsEntidades.LETTER) As Boolean
            Return datos.InsertDetallesLetra(entidad)
        End Function

        Public Function Insert(ByRef entidad As ClsEntidades.LETTER_EXCHANGE, ls_det As List(Of ClsEntidades.LETTER_EXCHANGE_LINE), _
                               ByVal Tabla As DataTable, ByVal TipoNumeracion As String) As Boolean
            Return datos.Insert(entidad, ls_det, Tabla, TipoNumeracion)
        End Function
        Public Function Get_ManualClientes(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualClientes(_Codigo)
        End Function

        Public Function Get_DocumentosPendientes(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosPendientes(_Codigo)
        End Function

        Public Function Get_VerificacionNumeracionLetra(ByVal _Codigo As String) As DataTable
            Return datos.Get_VerificacionNumeracionLetra(_Codigo)
        End Function

        Public Function Get_DocumentosPlanilla(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Return datos.Get_DocumentosPlanilla(_FECHA_INI, _FECHA_FIN, _OPCION)
        End Function

        Public Function Get_DocumentosLetras(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosLetras(_Codigo)
        End Function


        Public Function Get_AdicionalesLetter(ByVal _CodigoPlanilla As String) As DataTable
            Return datos.Get_AdicionalesLetter(_CodigoPlanilla)
        End Function

        Public Function Get_AdicionalesAval(ByVal _CodigoCliente As String) As DataTable
            Return datos.Get_AdicionalesAval(_CodigoCliente)
        End Function

        Public Function Get_AdicionalDatosLetra(ByVal _CodigoPlanilla As String, ByVal CodigoCliente As String) As DataTable
            Return datos.Get_AdicionalDatosLetra(_CodigoPlanilla, CodigoCliente)
        End Function

        Public Function Get_AdicionalDatosCliente(ByVal _CodigoCliente As String) As DataTable
            Return datos.Get_AdicionalDatosCliente(_CodigoCliente)
        End Function
        Public Function Get_AdicionalDatosLetraDetalle(ByVal _CodigoPlanilla As String, ByVal _CodigoLetra As String) As DataTable
            Return datos.Get_AdicionalDatosLetraDetalle(_CodigoPlanilla, _CodigoLetra)
        End Function

        Public Function InsercionTablaTemporal(ByVal _Consulta As String) As Boolean
            Return datos.InsercionTablaTemporal(_Consulta)
        End Function

        Public Function DatosAdicionalesDireccion(ByVal _CodigoCliente As String) As DataTable
            Return datos.DatosAdicionalesDireccion(_CodigoCliente)
        End Function

        Public Function EjecutarReporteLetras() As DataTable
            Return datos.EjecutarReporteLetras()
        End Function

        Public Function GeneracionAceptacionLetra(ByVal CodigoPlanilla) As Boolean
            Return datos.GeneracionAceptacionLetra(CodigoPlanilla)
        End Function

        Public Function DocumentoLetrasAceptadas() As DataTable
            Return datos.DocumentoLetrasAceptadas()
        End Function

    End Class

End Class
