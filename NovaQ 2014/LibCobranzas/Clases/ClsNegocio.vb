
Public Class ClsNegocio

    Public Class UNIDADESMEDIDA

        Dim datos As New ClsOperaciones.UNIDADESmEDIDA

        Public Function GuardarActualizar(ByVal Entidades As ClsEntidades.UNIDADESmeDIDA, ByVal Nuevo As Boolean)
            Return datos.GuardarActualizar(Entidades, Nuevo)
        End Function

        Public Function get_UMGenerales(PART_ID As String) As DataTable
            Return datos.get_UMGenerales(PART_ID)
        End Function

        Public Function get_EliminacionUM(ByVal Codigo As String, PART_ID As String) As Boolean
            Return datos.get_EliminacionUM(Codigo, PART_ID)
        End Function

        Public Function get_GeneracionCodigoAutomatico() As DataTable
            Return datos.get_GeneracionCodigoAutomatico()
        End Function

        'Public Function Get_ManualEMPLOYEELOGISTICA(ByVal _Codigo As String) As DataTable
        '    Return datos.Get_ManUALeMPLOYEELOGISTICA(_Codigo)
        'End Function


        'Public Function Get_ManualTIPO_REVERTIR_PICKING(ByVal _Codigo As String) As DataTable
        '    Return datos.Get_ManualTIPO_REVERTIR_PICKING(_Codigo)
        'End Function
    End Class


    Public Class DIRECCIONESTRANSPORTISTAS

        Dim datos As New ClsOperaciones.DIRECCIONESTRANSPORTISTAS

        Public Function GuardarActualizar(ByVal Entidades As ClsEntidades.DIRECCIONESTRANSPORTISTAS, ByVal Nuevo As Boolean)
            Return datos.GuardarActualizar(Entidades, Nuevo)
        End Function

        Public Function get_DireccionesTransportistasGenerales(PART_ID As String) As DataTable
            Return datos.get_DireccionesTransportistasGenerales(PART_ID)
        End Function

        Public Function get_EliminacionDireccionesTransportistasget_EliminacionUM(ByVal Codigo As String, PART_ID As String) As Boolean
            Return datos.get_EliminacionDireccionesTransportistas(Codigo, PART_ID)
        End Function

        Public Function get_GeneracionCodigoAutomatico(PART_ID As String) As DataTable
            Return datos.get_GeneracionCodigoAutomatico(PART_ID)
        End Function
    End Class



    Public Class Personal_RRHH
        Dim datos As New ClsOperaciones.Personal_RRHH

        Public Function get_Personal_RRHH() As DataTable
            Return datos.get_Personal_RRHH()
        End Function

        Public Function Generar_codigo_Personal_RR_HH() As DataTable
            Return datos.Genera_codigo_Personal_RRHH()
        End Function

        Public Function get_Registro_Asistencia_RR_HH(ByVal _mes As Integer, ByVal _anio As Integer) As DataTable
            Return datos.get_Registro_Asistencia_RR_HH(_mes, _anio)
        End Function

        Public Function get_Registro_Asistencia_Detalle_RR_HH(ByVal _fecha As String) As DataTable
            Return datos.get_Registro_Asistencia_Detalle_RR_HH(_fecha)
        End Function

        Public Function get_Personal_RRHH_new_Envio_Boletas(ByVal _codigo As Integer, ByVal _tipo As String) As DataTable
            Return datos.get_Personal_RRHH_new_Envio_Boletas(_codigo, _tipo)
        End Function
    End Class

    Public Class LETTER_EXCHANGE_PAY
        Dim datos As New ClsOperaciones.LETTER_EXCHANGE_PAY



        Public Function EliminacionPlanilla(ByVal _CodigoPlanilla As String, ByVal _Usuario As String) As Boolean
            Return datos.EliminacionPlanilla(_CodigoPlanilla, _Usuario)
        End Function
        Public Function Get_Tipo_Cambio(ByVal _FECHA_INI As String) As DataTable
            Return datos.Get_Tipo_Cambio(_FECHA_INI)
        End Function

        Public Function Get_Numero_Letra(ByVal _numero_letra As String) As DataTable
            Return datos.Get_Numeracion_Letras(_numero_letra)
        End Function

        Public Function Get_Numero_Letra_Pagos(ByVal _numero_letra As String) As DataTable
            Return datos.Get_Numeracion_Letras_Pagos(_numero_letra)
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
                                                ByVal AMOUNT As String, ByVal SALDO As String, _
                                                ByVal PERCENT_DETRAC As Double, ByVal MONTO_DETRAC As Double, _
                                                ByVal OBS As String) As Boolean
            Return datos.ActualizandoCarteraClientes(CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC, DOC_DATE, CADUCATE_DATE, SALES_ID, _
                                                     CURRENCY_ID, SELL_RATE, USER_ID, AMOUNT, SALDO, PERCENT_DETRAC, MONTO_DETRAC, OBS)
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

        Public Function Get_DocumentosPlanilla(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, ByVal _NUMERO_LETRA As String) As DataTable
            Return datos.Get_DocumentosPlanilla(_FECHA_INI, _FECHA_FIN, _OPCION, _NUMERO_LETRA)
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

        Public Function EliminacionPlanillaChequePagos(ByVal _CodigoPlanilla As String, ByVal _Usuario As String) As Boolean
            Return datos.EliminacionPlanillaChequePagos(_CodigoPlanilla, _Usuario)
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
        Public Function InsertCheque(ByRef entidad As ClsEntidades.CHECK_EXCHANGE, ls_det As List(Of ClsEntidades.CHECK_EXCHANGE_LINE), ls_det_Cheque_Cartera As List(Of ClsEntidades.CUSTOMER_BALANCE), _
                               ByVal Tabla As DataTable, ByVal TipoNumeracion As String, ByVal NumMaximo As String, ByVal MonedaLetra As String, ByVal PorcPercepcion As Double, _
                                ByVal Flag_Retencion As Boolean) As Boolean
            Return datos.InsertCheque(entidad, ls_det, ls_det_Cheque_Cartera, Tabla, TipoNumeracion, NumMaximo, MonedaLetra, PorcPercepcion, Flag_Retencion)
        End Function

        Public Function InsertChequePagos(ByRef entidad As ClsEntidades.CHECK_EXCHANGE, ls_det As List(Of ClsEntidades.CHECK_EXCHANGE_LINE), ls_det_Cheque_CarteraPago As List(Of ClsEntidades.CUSTOMER_BALANCE), _
                               ByVal Tabla As DataTable, ByVal TipoNumeracion As String, ByVal NumMaximo As String, ByVal MonedaLetra As String, ByVal PorcPercepcion As Double, _
                                ByVal Flag_Retencion As Boolean) As Boolean
            Return datos.InsertChequePagos(entidad, ls_det, ls_det_Cheque_CarteraPago, Tabla, TipoNumeracion, NumMaximo, MonedaLetra, PorcPercepcion, Flag_Retencion)
        End Function
        Public Function Get_ManualClientes(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualClientes(_Codigo)
        End Function

        Public Function Get_ManualProveedores(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualProveedores(_Codigo)
        End Function

        Public Function Get_DocumentosPendientes(ByVal _Codigo As String, ByVal _Opcion As String) As DataTable
            Return datos.Get_DocumentosPendientes(_Codigo, _Opcion)
        End Function

        Public Function Get_DocumentosPendientesCheques(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosPendientesCheques(_Codigo)
        End Function

        Public Function Get_DocumentosPendientesChequesPago(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosPendientesChequesPagos(_Codigo)
        End Function

        Public Function Get_VerificacionNumeracionLetra(ByVal _Codigo As String) As DataTable
            Return datos.Get_VerificacionNumeracionLetra(_Codigo)
        End Function

        Public Function Get_VerificacionNumeracionCheque(ByVal _Codigo As String) As DataTable
            Return datos.Get_VerificacionNumeracionCheque(_Codigo)
        End Function

        Public Function Get_DocumentosPlanilla(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, ByVal _NUMERO_LETRA As String) As DataTable
            Return datos.Get_DocumentosPlanilla(_FECHA_INI, _FECHA_FIN, _OPCION, _NUMERO_LETRA)
        End Function

        Public Function Get_Tipo_Cambio(ByVal _FECHA_INI As String) As DataTable
            Return datos.Get_Tipo_Cambio(_FECHA_INI)
        End Function

        Public Function Get_Numero_Letra(ByVal _numero_letra As String) As DataTable
            Return datos.Get_Numeracion_Letras(_numero_letra)
        End Function

        Public Function Get_DocumentosPlanillaCheques(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Return datos.Get_DocumentosPlanillaCheques(_FECHA_INI, _FECHA_FIN, _OPCION)
        End Function

        Public Function Get_DocumentosPlanillaChequesPago(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Return datos.Get_DocumentosPlanillaChequesPago(_FECHA_INI, _FECHA_FIN, _OPCION)
        End Function

        Public Function Get_DocumentosLetras(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosLetras(_Codigo)
        End Function

        Public Function Get_DocumentosLetrasPagos(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosLetras(_Codigo)
        End Function

        Public Function Get_DocumentosCheques(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosCheques(_Codigo)
        End Function

        Public Function Get_DocumentosChequesPagos(ByVal _Codigo As String) As DataTable
            Return datos.Get_DocumentosChequesPagos(_Codigo)
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

        Public Function Generacion_Por_Recoger_Letra(ByVal CodigoPlanilla) As Boolean
            Return datos.Generacion_Por_Recoger_Letra(CodigoPlanilla)
        End Function

        Public Function DocumentoLetrasAceptadas(ByVal _ESTADO As String) As DataTable
            Return datos.DocumentoLetrasAceptadas(_ESTADO)
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

        Public Function ValidarMovimientos_Proveedor(ByVal _cod_proveedor As String)
            Return datos.ValidarMovimientos_Proveedor(_cod_proveedor)
        End Function



        Public Function RetornarStockProductos(ByVal _codigoAlmacen As List(Of String), ByVal _Todos As Integer, ByVal stock_Cero As Boolean, ByVal tipo_origen As String)
            Return datos.RetornarStockProductos(_codigoAlmacen, _Todos, stock_Cero, tipo_origen)
        End Function

        Public Function RetornarStockProductos_Anual(ByVal _codigoAlmacen As List(Of String), ByVal _Todos As Integer, _
                                                     ByVal _fecha_inicial As String, ByVal _fecha_final As String, _
                                                     ByVal _transacciones As String, ByVal _opcion As String)
            Return datos.RetornarStockProductos_Anual(_codigoAlmacen, _Todos, _fecha_inicial, _fecha_final, _transacciones, _opcion)
        End Function

        Public Function Retornar_Ordenes_Importacion(ByVal _codigo As String)
            Return datos.Retornar_Ordenes_Importacion(_codigo)
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

        Public Function get_Clientes_mt_Oportunidad_Cliente(ByVal _cod_vendedor As String, ByVal _opcion As Integer) As DataTable
            Return datos.get_Clientes_mt_oportunidad_Cliente(_cod_vendedor, _opcion)
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

        Dim datos As New ClsOperaciones.RECEIVABLE

        Public Function get_Valida_Resumen_Boletas_SUNAT(ByVal _FECHA As String) As DataTable
            Return datos.get_Valida_Resumen_Boletas_SUNAT(_FECHA)
        End Function

        Public Function Get_ClienteDocumento_Pedidos(ByVal _CodigoCliente As String, ByVal _Almacen As String) As DataTable
            Return datos.Get_ClienteDocumento_Pedidos(_CodigoCliente, _Almacen)
        End Function

        Public Function Get_ManualEMPLOYEELOGISTICA(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManUALeMPLOYEELOGISTICA(_Codigo)
        End Function
        Public Function Get_ManualTIPO_REVERTIR_PICKING(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualTIPO_REVERTIR_PICKING(_Codigo)
        End Function

        Public Function Get_ClienteDetallesDocumento_Pedidos(ByVal _NumeroDocumentos As String) As DataTable
            Return datos.Get_ClienteDetallesDocumento_Pedido(_NumeroDocumentos)
        End Function

        Public Function Apertura_Ventas_doc(ByVal _documento As String, ByVal _serie As String, ByVal _numero As String) As Boolean
            Return datos.Apertura_Ventas_doc(_documento, _serie, _numero)
        End Function

        Public Function Actualizar_Cantidad_Comprobante(ByVal _documento As String, ByVal _serie As String, ByVal _numero As String) As Boolean
            Return datos.Actualizar_Cantidad_Comprobante(_documento, _serie, _numero)
        End Function

        Public Function Generar_GS_Xml(ByVal _TipoDoc As String, ByVal _warehouse_id As String, ByVal _NumeroDoc As String, _
                                    ByVal _ruta As String, ByVal _monto_letras As String, Optional ByVal _envia_email As String = "", _
                                    Optional ByVal _email_cliente As String = "") As Boolean
            Try
                Return datos.Genera_GS_Xml_Electronico(_TipoDoc, _warehouse_id, _NumeroDoc, _ruta, _monto_letras, _envia_email, _email_cliente)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Cierre_Ventas(ByVal _FECHA As String, ByVal _USUARIO As String, ByVal _SALDO_FINAL As Double,
                                      ByVal _SALDO_FINAL_VISA As Double, ByVal _SALDO_FINAL_MASTER As Double,
                                    ByVal _SALDO_FINAL_DINERS As Double, ByVal _SALDO_FINAL_AMERICAN_EXPRESS As Double,
                                    ByVal _SALDO_FINAL_BCP As Double, ByVal _SALDO_FINAL_BBVA As Double,
                                    ByVal _SALDO_FINAL_YAPE As Double, ByVal _SALDO_FINAL_PLIN As Double, ByVal _COBRO_VENTA_ANTERIOR As Double,
                                    ByVal _SALDO_FINAL_SCOTIABANK As Double, ByVal _SALDO_FINAL_INTERBANK As Double) As Boolean
            Return datos.Cierre_Ventas(_FECHA, _USUARIO, _SALDO_FINAL, _SALDO_FINAL_VISA, _SALDO_FINAL_MASTER, _SALDO_FINAL_DINERS, _SALDO_FINAL_AMERICAN_EXPRESS,
                                       _SALDO_FINAL_BCP, _SALDO_FINAL_BBVA, _SALDO_FINAL_YAPE, _SALDO_FINAL_PLIN, _COBRO_VENTA_ANTERIOR, _SALDO_FINAL_SCOTIABANK, _SALDO_FINAL_INTERBANK)
        End Function

        Public Function Generar_Xml_Comprobante_Retencion(ByVal _numero_compra As String, ByVal _ruta As String, ByVal _monto_texto As String, ByRef _nombre_xml As String, ByRef _nombre_pdf As String) As Boolean
            Try
                Return datos.Genera_Xml_Electronico_Comprobante_Retencion(_numero_compra, _ruta, _monto_texto, _nombre_xml, _nombre_pdf)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Generar_Xml_Comprobante_Retencion_Pagos(ByVal _numero_compra As Integer, ByVal _ruta As String, ByVal _monto_texto As String, ByRef _nombre_xml As String, ByRef _nombre_pdf As String) As Boolean
            Try
                Return datos.Genera_Xml_Electronico_Comprobante_Retencion_Pagos(_numero_compra, _ruta, _monto_texto, _nombre_xml, _nombre_pdf)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_DatosGeneralesFacturacion_SUNAT_Guias(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_DatosGeneralesFacturacion_SUNAT_GUias(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO)
        End Function

        Public Function Get_Lista_Productos_Venta(ByVal _Almacen As String, ByVal _Producto As String) As DataTable
            Return datos.Get_Lista_Productos_Venta(_Almacen, _Producto)
        End Function

        Public Function Get_ManualVendedor_usuario(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualVendedor_usuario(_Codigo)
        End Function

        Public Function Get_ManualVendedor_cliente(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualVendedor_cliente(_Codigo)
        End Function

        Public Function Generar_Datos_Act_vendedor(ByVal _Tipodoc As String, ByVal _NumeroDocumento As String, ByVal _serieDocumento As String, _
                                                   ByVal _Usuario As String, ByVal _vendedor_Act As String, ByVal _fp_Act As String, ByVal _mp_Act As String) As Boolean
            Return datos.Generar_Datos_Act_Vendedor(_Tipodoc, _NumeroDocumento, _serieDocumento, _Usuario, _vendedor_Act, _fp_Act, _mp_Act)
        End Function

        Public Function Generar_Txt_Resumen_Boletas(ByVal _Fecha_Resumen As String, ByVal _ruta As String, ByVal _Codigo_Resumen As String) As Boolean
            Try
                Return datos.Genera_Txt_Electronico_Resumen_Boletas(_Fecha_Resumen, _ruta, _Codigo_Resumen)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function Generar_XML_Resumen_Boletas(ByVal _Fecha_Resumen As String, ByVal _ruta As String, ByVal codigo_resumen As String, ByVal estado_documentos As String) As Boolean
            Try
                Return datos.Genera_XML_Electronico_Resumen_Boletas(_Fecha_Resumen, _ruta, codigo_resumen, estado_documentos)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Resumen_Boletas_SUNAT_Correlativo(ByVal _FECHA As String) As DataTable
            Return datos.get_Resumen_Boletas_SUNAT_Correlativo(_FECHA)
        End Function

        Public Function get_Datos_Resumen_Boletas_SUNAT(ByVal _FECHA As String) As DataTable
            Return datos.get_Datos_Resumen_Boletas_SUNAT(_FECHA)
        End Function

        Public Function get_Datos_Resumen_Boletas_SUNAT_Anulados(ByVal _FECHA As String) As DataTable
            Return datos.get_Datos_Resumen_Boletas_SUNAT_Anulados(_FECHA)
        End Function

        Public Function get_Datos_CDR(ByVal _tipo_documento As String, ByVal _serie_documento As String, ByVal _numero_documento As String, ByVal _tipo_doc_electronico As String) As DataTable
            Return datos.get_Datos_CDR(_tipo_documento, _serie_documento, _numero_documento, _tipo_doc_electronico)
        End Function

        Public Function get_Datos_Resumen_Boletas_SUNAT_Cabecera(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String) As DataTable
            Return datos.get_Datos_Resumen_Boletas_SUNAT_Cabecera(_FECHA_INI, _FECHA_FIN)
        End Function

        Public Function Generar_Txt_Comunicacion_Baja(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String, _
                                   ByVal _ruta As String, ByVal _Fecha_Baja As String) As Boolean
            Try
                Return datos.Genera_Txt_Electronico_Comunicacion_Baja(_TipoDoc, _serie, _NumeroDoc, _ruta, _Fecha_Baja)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Generar_XML_Comunicacion_Baja(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String, _
                                    ByVal _ruta As String, ByVal _Fecha_Baja As String, ByRef _ID_COMUNICACION_BAJA As String, ByRef _ID_COMUNICACION_BAJA_CDR As String) As Boolean
            Try
                Return datos.Genera_XML_Electronico_Comunicacion_Baja(_TipoDoc, _serie, _NumeroDoc, _ruta, _Fecha_Baja, _ID_COMUNICACION_BAJA, _ID_COMUNICACION_BAJA_CDR)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Generar_XML_Comunicacion_Baja_CR(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String, _
                                    ByVal _ruta As String, ByVal _Fecha_Baja As String, ByRef _ID_COMUNICACION_BAJA As String, ByRef _ID_COMUNICACION_BAJA_CDR As String) As Boolean
            Try
                Return datos.Genera_XML_Electronico_Comunicacion_Baja_CR(_TipoDoc, _serie, _NumeroDoc, _ruta, _Fecha_Baja, _ID_COMUNICACION_BAJA, _ID_COMUNICACION_BAJA_CDR)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Generar_XML_Comunicacion_Baja_CR_Pagos(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String, _
                                    ByVal _ruta As String, ByVal _Fecha_Baja As String, ByRef _ID_COMUNICACION_BAJA As String, ByRef _ID_COMUNICACION_BAJA_CDR As String) As Boolean
            Try
                Return datos.Genera_XML_Electronico_Comunicacion_Baja_CR_Pagos(_TipoDoc, _serie, _NumeroDoc, _ruta, _Fecha_Baja, _ID_COMUNICACION_BAJA, _ID_COMUNICACION_BAJA_CDR)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Generar_Txt(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String, _
                                    ByVal _ruta As String, ByVal _monto_letras As String, Optional ByVal _envia_email As String = "", _
                                    Optional ByVal _email_cliente As String = "") As Boolean
            Try
                Return datos.Genera_Txt_Electronico(_TipoDoc, _serie, _NumeroDoc, _ruta, _monto_letras, _envia_email, _email_cliente)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Generar_FT_GS_Xml(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String, _
                                    ByVal _ruta As String, ByVal _monto_letras As String, Optional ByVal _envia_email As String = "", _
                                    Optional ByVal _ticket_a4 As String = "") As Boolean
            Try
                Return datos.Genera_FT_GS_Xml_Electronico(_TipoDoc, _serie, _NumeroDoc, _ruta, _monto_letras, _envia_email, _ticket_a4)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Contabilizar(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String) As Boolean
            Return datos.Contabilizar(_TipoDoc, _serie, _NumeroDoc)
        End Function

        Public Function Contabilizar_CR(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String) As Boolean
            Return datos.Contabilizar_CR(_TipoDoc, _serie, _NumeroDoc)
        End Function

        Public Function Contabilizar_Individual(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String, ByVal numero_asiento As String) As Boolean
            Return datos.Contabilizar_Individual(_TipoDoc, _serie, _NumeroDoc, numero_asiento)
        End Function

        Public Function Contabilizar_Individual_CR(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String, ByVal numero_asiento As String,
                                                   ByVal id_compra As String, ByVal origen As String) As Boolean
            Return datos.Contabilizar_Individual_CR(_TipoDoc, _serie, _NumeroDoc, numero_asiento, id_compra, origen)
        End Function

        Public Function get_DatosGeneralesFacturacion_SUNAT(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_DatosGeneralesFacturacion_SUNAT(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO)
        End Function

        Public Function get_DatosGeneralesFacturacion_SUNAT_Comp_Retencion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_DatosGeneralesFacturacion_SUNAT_Comp_Retencion(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO)
        End Function

        Public Function get_DatosGeneralesFacturacion_SUNAT_Comunicacion_Baja(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_DatosGeneralesFacturacion_SUNAT_Comunicacion_Baja(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO)
        End Function

        Public Function Contabilizar_Ventas_Contado(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String) As Boolean
            Return datos.Contabilizar_Caja_Ventas_Contado(_TipoDoc, _serie, _NumeroDoc)
        End Function

        Public Function get_DatosGeneralesFacturacion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_DatosGeneralesFacturacion(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO)
        End Function

        Public Function get_DatosGeneralesFacturacion_Tienda(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_DatosGeneralesFacturacion_Tienda(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO)
        End Function

        Public Function get_DatosGeneralesFacturacion_Tienda(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String, ByVal _USUARIO As String) As DataTable
            Return datos.get_DatosGeneralesFacturacion_Tienda(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO, _USUARIO)
        End Function

        Public Function get_DatosGeneralesFacturacion_Contabilizacion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_DatosGeneralesFacturacion_Contabilizacion(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO)
        End Function

        Public Function get_DatosGeneralesFacturacion_Contabilizacion_CR(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_DatosGeneralesFacturacion_Contabilizacion_CR(_FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO)
        End Function

        Public Function get_Busqueda_Rapida(ByVal _numero As String, ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_Busqueda_Rapida_Facturacion(_numero, _TIPODOCUMENTO)
        End Function

        Public Function get_Busqueda_Rapida(ByVal _numero As String, ByVal _TIPODOCUMENTO As String, ByVal _USUARIO As String) As DataTable
            Return datos.get_Busqueda_Rapida_Facturacion(_numero, _TIPODOCUMENTO, _USUARIO)
        End Function

        Public Function get_Busqueda_Rapida_Contabilizacion(ByVal _numero As String, ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_Busqueda_Rapida_Facturacion_Contabilizacion(_numero, _TIPODOCUMENTO)
        End Function

        Public Function get_Busqueda_Rapida_Contabilizacion_CR(ByVal _numero As String, ByVal _TIPODOCUMENTO As String) As DataTable
            Return datos.get_Busqueda_Rapida_Facturacion_Contabilizacion_CR(_numero, _TIPODOCUMENTO)
        End Function

        Public Function get_Busqueda_Por_Serie(ByVal _numero As String, ByVal _TIPODOCUMENTO As String, ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String) As DataTable
            Return datos.get_Busqueda_Por_Serie_Facturacion(_numero, _TIPODOCUMENTO, _FECHA_INI, _FECHA_FIN)
        End Function

        Public Function get_Busqueda_Por_Serie(ByVal _numero As String, ByVal _TIPODOCUMENTO As String, ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _USUARIO As String) As DataTable
            Return datos.get_Busqueda_Por_Serie_Facturacion(_numero, _TIPODOCUMENTO, _FECHA_INI, _FECHA_FIN, _USUARIO)
        End Function


        Public Function AnulacionFacturacion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                             ByVal _NUMBER_DOCUMENT As String, ByVal _ALMACEN As String, ByVal _MOTIVO As String) As Boolean
            Return datos.AnulacionFacturacion(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, _ALMACEN, _MOTIVO)
        End Function

        Public Function Act_Envio_Mail(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String) As Boolean
            Return datos.Act_Envio_Mail(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
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

        Public Function Get_Datos_Compra(ByVal numero_compra As String) As DataTable
            Return datos.Get_Datos_Compra(numero_compra)
        End Function

        Public Function Get_Validacion_Cartera(ByVal tipo_terms As String) As DataTable
            Return datos.Get_Validacion_Cartera(tipo_terms)
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

        Public Function Get_ManualArticulos(ByVal _Codigo As String) As DataTable
            Return datos.Get_ManualArticulos(_Codigo)
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

        Public Function GenerarDespacho(ByVal _Tipodoc As String, ByVal _NumeroDocumento As String, ByVal _Fecha As String, ByVal _Usuario As String, ByVal _Trans_despachos As String, ByVal _Obs_despachos As String, Optional ByVal _cod_transportista As String = "", Optional ByVal _datos_vehiculo As String = "") As Boolean
            Return datos.GenerarDespacho(_Tipodoc, _NumeroDocumento, _Fecha, _Usuario, _Trans_despachos, _Obs_despachos, _cod_transportista, _datos_vehiculo)
        End Function

        Public Function GenerarCobro(ByVal _Tipodoc As String, ByVal _NumeroDocumento As String, ByVal _Fecha As String, ByVal _Usuario As String) As Boolean
            Return datos.GenerarCobranza(_Tipodoc, _NumeroDocumento, _Fecha, _Usuario)
        End Function


        Public Function GenerarDespachoVarios(ByVal DTDOCUMENTOS As DataTable, ByVal _Fecha As String, ByVal _Usuario As String) As Boolean
            Return datos.GenerarDespachoVarios(DTDOCUMENTOS, _Fecha, _Usuario)
        End Function

    End Class
End Class
