
Public Class ClsNegocio

    Public Class LETTER_EXCHANGE_PAY
        Dim datos As New ClsOperaciones.LETTER_EXCHANGE_PAY

        Public Function EliminacionPlanilla(ByVal _CodigoPlanilla As String, ByVal _Usuario As String) As Boolean
            Return datos.EliminacionPlanilla(_CodigoPlanilla, _Usuario)
        End Function

        Public Function VerificacionNumeracion(ByVal _CodigoCliente As String, ByVal _TipoDoc As String, ByVal _Numero As String) As DataTable
            Return datos.VerificacionNumeracion(_CodigoCliente, _TipoDoc, _Numero)
        End Function

        Public Function EliminacionCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String) As Boolean
            Return datos.EliminacionCarteraClientes(CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC)
        End Function
        Public Function Get_DocumentoAnticipos(ByVal _Codigo As String, ByVal _Codigo_Documento As String) As DataTable
            Return datos.Get_DocumentosAnticipos(_Codigo, _Codigo_Documento)
        End Function

        Public Function ActualizandoCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String, _
                                                ByVal DOC_DATE As String, ByVal CADUCATE_DATE As String, ByVal SALES_ID As String, _
                                                ByVal CURRENCY_ID As String, ByVal SELL_RATE As String, ByVal USER_ID As String, _
                                                ByVal AMOUNT As String, ByVal SALDO As String) As Boolean
            Return datos.ActualizandoCarteraClientes(CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC, DOC_DATE, CADUCATE_DATE, SALES_ID, _
                                                     CURRENCY_ID, SELL_RATE, USER_ID, AMOUNT, SALDO)
        End Function

        Public Function GuardandoCarteraClientes(ByVal EntidadCliente As LibContabilidad.ClsEntidades.CUSTOMER_BALANCE_PAY) As Boolean
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

        Public Function InsertDetallesLetra(ByRef entidad As ClsEntidades.LETTER_PAY) As Boolean
            Return datos.InsertDetallesLetra(entidad)
        End Function

        Public Function Insert(ByRef entidad As ClsEntidades.LETTER_EXCHANGE_PAY, ls_det As List(Of ClsEntidades.LETTER_EXCHANGE_LINE_PAY), _
                               ByVal Tabla As DataTable, ByVal TipoNumeracion As String, ByVal NumMaximo As String, ByVal MonedaLetra As String, ByVal PorcPercepcion As Double, _
                                ByVal Flag_Retencion As Boolean) As Boolean
            Return datos.Insert(entidad, ls_det, Tabla, TipoNumeracion, NumMaximo, MonedaLetra, PorcPercepcion, Flag_Retencion)
        End Function
        Public Function Get_ManualClientes(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualClientes(_Codigo)
        End Function

        Public Function Get_DocumentosPendientes(ByVal _Codigo As String, ByVal _Opcion As String) As DataTable
            Return datos.Get_DocumentosPendientes(_Codigo, _Opcion)
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


    Public Class LETTER_EXCHANGE
        Dim datos As New ClsOperaciones.LETTER_EXCHANGE

        Public Function EliminacionPlanilla(ByVal _CodigoPlanilla As String, ByVal _Usuario As String) As Boolean
            Return datos.EliminacionPlanilla(_CodigoPlanilla, _Usuario)
        End Function
        Public Function EliminacionPlanillaCheque(ByVal _CodigoPlanilla As String, ByVal _Usuario As String) As Boolean
            Return datos.EliminacionPlanillaCheque(_CodigoPlanilla, _Usuario)
        End Function
        Public Function VerificacionNumeracion(ByVal _CodigoCliente As String, ByVal _TipoDoc As String, ByVal _Numero As String) As DataTable
            Return datos.VerificacionNumeracion(_CodigoCliente, _TipoDoc, _Numero)
        End Function

        Public Function EliminacionCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String) As Boolean
            Return datos.EliminacionCarteraClientes(CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC)
        End Function


        Public Function ActualizandoCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String, _
                                                ByVal DOC_DATE As String, ByVal CADUCATE_DATE As String, ByVal SALES_ID As String, _
                                                ByVal CURRENCY_ID As String, ByVal SELL_RATE As String, ByVal USER_ID As String, _
                                                ByVal AMOUNT As Double, ByVal SALDO As Double) As Boolean
            Return datos.ActualizandoCarteraClientes(CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC, DOC_DATE, CADUCATE_DATE, SALES_ID, _
                                                     CURRENCY_ID, SELL_RATE, USER_ID, AMOUNT, SALDO)
        End Function

        Public Function GuardandoCarteraClientes(ByVal EntidadCliente As ClsEntidades.CUSTOMER_BALANCE) As Boolean
            Return datos.GuardandoCarteraClientes(EntidadCliente)
        End Function

        Public Function Get_ManualVendedor(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualVendedor(_Codigo)
        End Function

        Public Function Get_DocumentoAnticipos(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosAnticipos(_Codigo)
        End Function

        Public Function MostrandoClientesManejoDocumentoDetalles(ByVal _Codigo As String) As DataTable
            Return datos.MostrandoClientesManejoDocumentoDetalles(_Codigo)
        End Function

        Public Function MostrandoClientesManejoDocumento() As DataTable
            Return datos.MostrandoClientesManejoDocumento()
        End Function

        Public Function MostrandoVendedorDocPendientes() As DataTable
            Return datos.MostrandoVendedorDocPendientes()
        End Function

        Public Function MostrandoClientesDocPendientes() As DataTable
            Return datos.MostrandoClientesDocPendientes()
        End Function

        Public Function MostrandoProveedoresDocPendientes() As DataTable
            Return datos.MostrandoProveedoresDocPendientes()
        End Function

        Public Function VerificacionClienteVendedor(ByVal Consulta As String) As DataTable
            Return datos.VerificacionClienteVendedor(Consulta)
        End Function


        Public Function GeneracionCambioEstadoLetra(ByVal LETTER_ID As String, ByVal BANK_ID As String, ByVal COMMENT As String, _
                                                   ByVal STATUS_ACT As String, ByVal NUMBER_ACCOUNT As String, ByVal NUMBER_BANK As String, ByVal UPDATE_DATE As String, ByVal _opcion As String) As Boolean
            Return datos.GeneracionCambioEstadoLetra(LETTER_ID, BANK_ID, COMMENT, STATUS_ACT, NUMBER_ACCOUNT, NUMBER_BANK, UPDATE_DATE, _opcion)
        End Function

        Public Function GeneracionCambioEstadoLetraPago(ByVal LETTER_ID As String, ByVal BANK_ID As String, ByVal COMMENT As String, _
                                                   ByVal STATUS_ACT As String, ByVal NUMBER_ACCOUNT As String, ByVal NUMBER_BANK As String, ByVal UPDATE_DATE As String, ByVal _opcion As String) As Boolean
            Return datos.GeneracionCambioEstadoLetraPago(LETTER_ID, BANK_ID, COMMENT, STATUS_ACT, NUMBER_ACCOUNT, NUMBER_BANK, UPDATE_DATE, _opcion)
        End Function

        Public Function InsertDetallesLetra(ByRef entidad As ClsEntidades.LETTER) As Boolean
            Return datos.InsertDetallesLetra(entidad)
        End Function

        Public Function Insert(ByRef entidad As ClsEntidades.LETTER_EXCHANGE, ls_det As List(Of ClsEntidades.LETTER_EXCHANGE_LINE), _
                               ByVal Tabla As DataTable, ByVal TipoNumeracion As String, ByVal NumMaximo As String, ByVal MonedaLetra As String, ByVal PorcPercepcion As Double, _
                                ByVal Flag_Retencion As Boolean) As Boolean
            Return datos.Insert(entidad, ls_det, Tabla, TipoNumeracion, NumMaximo, MonedaLetra, PorcPercepcion, Flag_Retencion)
        End Function
        Public Function InsertCheque(ByRef entidad As ClsEntidades.CHECK_EXCHANGE, ls_det As List(Of ClsEntidades.CHECK_EXCHANGE_LINE), _
                               ByVal Tabla As DataTable, ByVal TipoNumeracion As String, ByVal NumMaximo As String, ByVal MonedaLetra As String, ByVal PorcPercepcion As Double, _
                                ByVal Flag_Retencion As Boolean) As Boolean
            Return datos.InsertCheque(entidad, ls_det, Tabla, TipoNumeracion, NumMaximo, MonedaLetra, PorcPercepcion, Flag_Retencion)
        End Function
        Public Function Get_ManualClientes(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualClientes(_Codigo)
        End Function

        Public Function Get_DocumentosPendientes(ByVal _Codigo As String, ByVal _Opcion As String) As DataTable
            Return datos.Get_DocumentosPendientes(_Codigo, _Opcion)
        End Function

        Public Function Get_DocumentosPendientesCheques(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosPendientesCheques(_Codigo)
        End Function

        Public Function Get_VerificacionNumeracionLetra(ByVal _Codigo As String) As DataTable
            Return datos.Get_VerificacionNumeracionLetra(_Codigo)
        End Function

        Public Function Get_DocumentosPlanilla(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Return datos.Get_DocumentosPlanilla(_FECHA_INI, _FECHA_FIN, _OPCION)
        End Function

        Public Function Get_DocumentosPlanillaCheques(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Return datos.Get_DocumentosPlanillaCheques(_FECHA_INI, _FECHA_FIN, _OPCION)
        End Function

        Public Function Get_DocumentosLetras(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosLetras(_Codigo)
        End Function

        Public Function Get_DocumentosCheques(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosCheques(_Codigo)
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
        Public Function DocumentoLetrasAceptadasPagos() As DataTable
            Return datos.DocumentoLetrasAceptadasPagos()
        End Function

    End Class


    Public Class PART
        Dim datos As New ClsOperaciones.PART



        Public Function ValidarCliente_Ruc(ByVal _cod_proveedor As String)
            Return datos.ValidarCliente_Ruc(_cod_proveedor)
        End Function


        Public Function ValidarProveedor(ByVal _cod_proveedor As String)
            Return datos.ValidarProveedor(_cod_proveedor)
        End Function


        Public Function ValidarProveedor_Ruc(ByVal _cod_proveedor As String)
            Return datos.ValidarProveedor_Ruc(_cod_proveedor)
        End Function



        Public Function RetornarStockProductos(ByVal _codigoAlmacen As List(Of String), ByVal _Todos As Integer)
            Return datos.RetornarStockProductos(_codigoAlmacen, _Todos)
        End Function


        Public Function ConsultarArticuloLibre(ByVal _codigoPart As String) As DataTable
            Return datos.ConsultarArticuloLibre(_codigoPart)
        End Function

        Public Function ConsultarArticuloLote(ByVal _codigoPart As String) As DataTable
            Return datos.ConsultarArticuloLote(_codigoPart)
        End Function

        Public Function ConsultarArticuloSerie(ByVal _codigoPart As String) As DataTable
            Return datos.ConsultarArticuloSerie(_codigoPart)
        End Function


        Public Function DetalleArticuloLote(ByVal _codigoPart As String, ByVal _Almacen As String, ByVal Todos As Boolean) As DataTable
            Return datos.DetalleArticuloLote(_codigoPart, _Almacen, Todos)
        End Function


        Public Function DetalleArticuloLibre(ByVal _codigoPart As String, ByVal _Almacen As String, ByVal Todos As Boolean) As DataTable
            Return datos.DetalleArticuloLibre(_codigoPart, _Almacen, Todos)
        End Function



        Public Function DatosUsuarios(ByVal _codigoUsuario As String) As DataTable
            Return datos.DatosUsuarios(_codigoUsuario)
        End Function
    End Class



    Public Class WAREHOUSE
        Dim datos As New ClsOperaciones.WAREHOUSE

        Public Function GuardarActualizar(ByVal Entidades As ClsEntidades.WAREHOUSE, ByVal Nuevo As Boolean)
            Return datos.GuardarActualizar(Entidades, Nuevo)
        End Function

        Public Function get_AlmacenesGenerales() As DataTable
            Return datos.get_AlmacenesGenerales()
        End Function

        Public Function get_GeneracionCodigoAutomatico() As DataTable
            Return datos.get_GeneracionCodigoAutomatico()
        End Function

        Public Function get_GeneracionCodigoAutomaticoLineas() As DataTable
            Return datos.get_GeneracionCodigoAutomaticoLineas()
        End Function

        Public Function get_EliminacionAlmacen(ByVal Codigo As String) As Boolean
            Return datos.get_EliminacionAlmacen(Codigo)
        End Function

        Public Function get_Almacenes_Ayuda_Lotes(ByVal ID_ALAMACEN As String) As DataTable
            Return datos.get_Almacenes_Ayuda_Lotes(ID_ALAMACEN)
        End Function

        Public Function get_Almacenes_Ayuda(ByVal ID_ALAMACEN As String) As DataTable
            Return datos.get_Almacenes_Ayuda(ID_ALAMACEN)
        End Function
    End Class

    Public Class CUSTOMER
        Dim datos As New ClsOperaciones.CUSTOMER

        Public Function get_Clientes_mt() As DataTable
            Return datos.get_Clientes_mt()
        End Function

        Public Function GeneracionCodigoCliente(ByVal TipoCliente As String, ByVal Departamento As String) As DataTable
            Return datos.GeneracionCodigoCliente(TipoCliente, Departamento)
        End Function
    End Class



    Public Class LOT
        Dim datos As New ClsOperaciones.LOT
        Public Function get_Lotes() As DataTable
            Return datos.get_Lotes()
        End Function

        Public Function Eliminar(ByVal WHO_ID As String, ByVal PART_ID As String, ByVal LOT_ID As String) As Boolean
            Return datos.Eliminar(WHO_ID, PART_ID, LOT_ID)
        End Function

        Public Function VerificarCodigoLote(ByVal WHO_ID As String, ByVal PART_ID As String, ByVal LOT_ID As String) As DataTable
            Return datos.VerificarCodigoLote(WHO_ID, PART_ID, LOT_ID)
        End Function
    End Class

    Public Class RECEIVABLE
        Inherits ClsEntidades.RECEIVABLE
        Implements Implementacion.RECEIVABLE

        Dim datos As New ClsOperaciones.RECEIVABLE

        Public Function Contabilizar(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String) As Boolean
            Return datos.Contabilizar(_TipoDoc, _serie, _NumeroDoc)
        End Function

        Public Function get_DatosGeneralesFacturacion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String) As DataTable Implements Implementacion.RECEIVABLE.get_DatosGeneralesFacturacion
            Return datos.get_DatosGeneralesFacturacion(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO)
        End Function
        Public Function Get_ManualProveedor(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualProveedor(_Codigo)
        End Function

        Public Function AnulacionFacturacion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                             ByVal _NUMBER_DOCUMENT As String, ByVal _ALMACEN As String) As Boolean
            Return datos.AnulacionFacturacion(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, _ALMACEN)
        End Function

        Public Function AnulacionFacturacionComprobanteP(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                          ByVal _NUMBER_DOCUMENT As String) As Boolean
            Return datos.AnulacionFacturacionComprobanteP(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
        End Function

        Public Function Get_VerificacionDocumentos(ByVal NombreStore As String, ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
            Return datos.Get_VerificacionDocumentos(NombreStore, tipodoc_, serie_, num_)
        End Function

        Public Function EliminacionFacturacion(ByVal _USER As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                               ByVal _NUMBER_DOCUMENT As String, ByVal _ALMACEN As String) As Boolean
            Return datos.EliminacionFacturacion(_USER, _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, _ALMACEN)
        End Function

        Public Function EliminacionFacturacionComprobanteP(ByVal _USER As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                                           ByVal _NUMBER_DOCUMENT As String) As Boolean
            Return datos.EliminacionFacturacionComprobanteP(_USER, _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
        End Function

        Public Function Get_ManualPuntoVenta(ByVal Codigo As String) As DataTable
            Return datos.Get_ManualPuntoVenta(Codigo)
        End Function

        Public Function Get_Validacion(ByVal tipo_doc As String, ByVal serie_doc As String) As DataTable
            Return datos.Get_Validacion_CP_Det(tipo_doc, serie_doc)
        End Function

        Public Function Get_Validacion_Doc_Cobro(ByVal tipo_doc As String, ByVal serie_doc As String) As DataTable
            Return datos.Get_Validacion_Cobro(tipo_doc, serie_doc)
        End Function
        Public Function Get_Validacion_Doc_Pago(ByVal tipo_doc As String, ByVal serie_doc As String) As DataTable
            Return datos.Get_Validacion_Pago(tipo_doc, serie_doc)
        End Function
        Public Function Get_ClienteDetallesDocumento(ByVal _NumeroDocumentos As String) As DataTable
            Return datos.Get_ClienteDetallesDocumento(_NumeroDocumentos)
        End Function
        Public Function Get_Cabecera_primera_guia(ByVal _NumeroDocumentos As String) As DataTable
            Return datos.Get_Cabecera_primera_guia_datos(_NumeroDocumentos)
        End Function

        Public Function Get_ClienteDetallesDocumento_Rep_Medico(ByVal Tipodoc As String, ByVal _NumeroDocumentos As String) As DataTable
            Return datos.Get_ClienteDetallesDocumento_Rep_Medico(Tipodoc, _NumeroDocumentos)
        End Function

        Public Function Get_ClienteDocumento(ByVal _CodigoCliente As String, ByVal _Almacen As String) As DataTable
            Return datos.Get_ClienteDocumento(_CodigoCliente, _Almacen)
        End Function

        Public Function Get_ClienteDocumento_Representante_Medico(ByVal _CodigoCliente As String, ByVal _Almacen As String) As DataTable
            Return datos.Get_ClienteDocumento_Representante_Medico(_CodigoCliente, _Almacen)
        End Function

        Public Function Get_ManualClientes(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualClientes(_Codigo)
        End Function

        Public Function Get_ManualFormaPago(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualFormaPago(_Codigo)
        End Function

        Public Function Get_ManualTransportista(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualTransportista(_Codigo)
        End Function

        Public Function Get_ManualVendedor(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualVendedor(_Codigo)
        End Function

        Public Function VerificarDespacho(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String) As DataTable
            Return datos.VerificarDespacho(_TipoDoc, _serie, _NumeroDoc)
        End Function

        Public Function GenerarDespacho(ByVal _Tipodoc As String, ByVal _NumeroDocumento As String, ByVal _Fecha As String, ByVal _Usuario As String) As Boolean
            Return datos.GenerarDespacho(_Tipodoc, _NumeroDocumento, _Fecha, _Usuario)
        End Function


        Public Function GenerarDespachoVarios(ByVal DTDOCUMENTOS As DataTable, ByVal _Fecha As String, ByVal _Usuario As String) As Boolean
            Return datos.GenerarDespachoVarios(DTDOCUMENTOS, _Fecha, _Usuario)
        End Function
 
    End Class
End Class
