Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas

Public Class FrmRegistroPedidos
    Private cProcesosbL As ClsProcesos
    Private cConsultabL As ClsConsultas
    Private clsPedidoBl As ClsOperaciones.ORDERS
    Private dtDocumentoPedidos As DataTable
    Public CodigoVendedor As String = String.Empty
    Public DescripcionVendedor As String = String.Empty
    Public Tipo_Vendedor As String = String.Empty

    Dim Modo_consultar As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim edicion As Boolean = False
    Dim dtdetalleArticuloPrincipal As DataTable

    Dim cVenta As ClsAyudas
    Dim dtSerieDoc As DataTable
    Dim dtTipoDoc As DataTable
    Dim dtSerieGuia As DataTable
    Dim dtDirCliente As DataTable
    Dim dtPedido As DataTable
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen
    Dim NumeracionPedido As String = String.Empty
    Dim Flag_TipoDocumento As String = String.Empty

    Dim clsIgvArticuloBL As ClsTransacciones.clsPedidos
    Dim dtIgvArticulo As DataTable
 
    Dim cabeceraBL As ClsOperaciones.RECEIVABLE
    Dim cabeceraBE As ClsEntidades.RECEIVABLE
    Dim carteraBE As ClsEntidades.CUSTOMER_BALANCE
    Dim detalle As ClsEntidades.RECEIVABLE_LINE
    Dim ls_det As List(Of ClsEntidades.RECEIVABLE_LINE)
    Dim ls_det_alm As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
    Dim ListaGuia_Alm As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
    Dim alm_cabBE As ClsEntidades.WAREHOUSE_TRANS
    Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
    Dim ListaGuiaCab_alm As List(Of ClsEntidades.WAREHOUSE_TRANS)


    Dim cabeceraPedidoBL As ClsOperaciones.ORDERS
    Dim cabeceraPedidoENT As ClsEntidades.ORDER
    Dim DetallePedidoBL As ClsOperaciones.ORDERS_LINE
    Dim listaDetallepedido As List(Of ClsEntidades.ORDER_LINE)
    Dim DetallePedidoENT As ClsEntidades.ORDER_LINE

    Dim dtCabeceraPedido As DataTable
    Dim dtDetallePedido As DataTable
    Dim clsBuscarBl As ClsBuscar

    Dim NumeracionGuiaRemision, NumeracionFacturacion, NumeracionFacturaNotac, NumeracionFacturaNotaD As String
    Dim TipoNumeracion As String
    Dim NumeroLineas As Integer
    Dim Fl_close As Boolean = False

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "CODIGO"
        cboMoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub

    Private Sub DocumentosPedidos()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtDocumentoPedidos = New DataTable

            dtDocumentoPedidos = clsPedidoBl.get_DatosGeneralesPedido(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                      cboopcionesBusqueda.SelectedIndex, CodigoVendedor, Tipo_Vendedor, LibComunVar.ClsVarComun.AcesoVendedores)
            dgvDocumentosPedidos.DataSource = Nothing
            If dtDocumentoPedidos.Rows.Count() <> 0 Then
                dtv = dtDocumentoPedidos.DefaultView
                dgvDocumentosPedidos.DataSource = dtv
                dgvDocumentosPedidos.Columns(0).Width = 70
                dgvDocumentosPedidos.Columns(1).Width = 68
                dgvDocumentosPedidos.Columns(2).Width = 120
                dgvDocumentosPedidos.Columns(3).Width = 80
                dgvDocumentosPedidos.Columns(4).Width = 170
                dgvDocumentosPedidos.Columns(6).Width = 60
                dgvDocumentosPedidos.Columns(7).Width = 100
                STRorden = dgvDocumentosPedidos.Columns(0).Name & "+" & dgvDocumentosPedidos.Columns(1).Name & "+" & dgvDocumentosPedidos.Columns(2).Name & "+" & dgvDocumentosPedidos.Columns(3).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False

            If Modo_consultar = True Then
                btnGrabar.Enabled = False
            Else
                btnGrabar.Enabled = True
            End If
            btnEliminar.Enabled = False
            btnAnular.Enabled = False
            btnConsultar.Enabled = False
            btnFacturar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            lblCantidad.Visible = False
        Else

            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnAnular.Enabled = True
            btnConsultar.Enabled = True
            btnFacturar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            lblCantidad.Visible = True
        End If
    End Sub


 



    'Private Sub ParametrosSistema()
    '    ''IGV DEL SISTEMA PREDENTERMINADO
    '    clsIgvArticuloBL = New ClsTransacciones.clsPedidos
    '    dtIgvArticulo = New DataTable("IGV_SISTEMA")
    '    dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvsSistema()
    '    nIgvGlobal = dtIgvArticulo.Rows(0).Item("AMOUNT_TAX").ToString
    '    If dtIgvArticulo.Rows(0).Item("CURRENCY_ID").ToString = "MN" Then

    '    Else

    '    End If
    '    If cTipDoc = "FT" Then
    '        If dtIgvArticulo.Rows(0).Item("IS_BOUNCER") Then cValChe = True
    '        If dtIgvArticulo.Rows(0).Item("IS_SALES_DOC") Then cValDocv = True
    '        If dtIgvArticulo.Rows(0).Item("IS_BILL_PROTESTED") Then cVallet = True
    '        If dtIgvArticulo.Rows(0).Item("IS_BILL_CADUCATE") Then cValletv = True
    '        If dtIgvArticulo.Rows(0).Item("IS_CREDIT_LIMIT") Then cVallicr = True
    '    End If
    'End Sub


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PREC_UNITARIO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("%DESC.ART_1", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("%DESC.ART_2", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("VALOR_VENTA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("IMP_DESC_01", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("IMP_DESC_02", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_IGV", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("IGV_ART", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("IGV_ART_US", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("IMPORTE", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_INICIAL", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("TOTAL_INICIAL", Type.GetType("System.Double"))
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.Columns(0).Width = 60
            dgvDetalle.Columns(1).Width = 80
            dgvDetalle.Columns(2).Width = 80
            dgvDetalle.Columns(3).Width = 80
            dgvDetalle.Columns(4).Width = 350
            dgvDetalle.Columns(5).Width = 80
            dgvDetalle.Columns(6).Width = 70
            dgvDetalle.Columns(7).Width = 90
            dgvDetalle.Columns(8).Width = 90
            dgvDetalle.Columns(9).Width = 80
            dgvDetalle.Columns(12).Visible = False
            dgvDetalle.Columns(13).Visible = False
            dgvDetalle.Columns(14).Visible = False
            dgvDetalle.Columns(15).Visible = False
            dgvDetalle.Columns(16).Visible = False
            dgvDetalle.Columns(17).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Nuevo()
        Try
            dgvDocumentosPedidos.Visible = False
            pnlFiltro.Visible = False
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
            Limpiar()
            GenerarColummnaDataTable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Botonera_Estado_Cambiar(True)
        Nuevo()
        Flag_TipoDocumento = String.Empty
        Flag_TipoDocumento = "P"
        txtVendedor.Text = CodigoVendedor
        lblVendedor.Text = DescripcionVendedor
    End Sub

    Private Sub SerieDocumentoPuntoVenta()
        cVenta = New ClsAyudas
        dtSerieDoc = New DataTable
        dtSerieDoc = cVenta.get_Serie_Doc_Pto_Venta(cboTipoDoc.Text, txtPtoVenta.Text.Trim)
        cboSerieDoc.DataSource = dtSerieDoc
        cboSerieDoc.ValueMember = dtSerieDoc.Columns(0).ToString
        cboSerieDoc.DisplayMember = dtSerieDoc.Columns(0).ToString
        cVenta = Nothing
    End Sub


    Private Sub MostrarModoConsultar(ByVal NUMBER_DOCUMENT As String)
        Try
            cabeceraPedidoBL = New ClsOperaciones.ORDERS
            dtCabeceraPedido = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraPedido = cabeceraPedidoBL.Get_cabeceraPedido(NUMBER_DOCUMENT)
            If dtCabeceraPedido.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraPedido.Rows.Count() - 1
                    txtPtoVenta.Text = dtCabeceraPedido.Rows(i).Item("PLACE_SALES").ToString
                    cboMoneda.SelectedValue = dtCabeceraPedido.Rows(i).Item("CURRENCY_ID").ToString
                    txtTipoCambio.Text = dtCabeceraPedido.Rows(i).Item("SELL_RATE").ToString
                    dtFechaEmision.Value = dtCabeceraPedido.Rows(i).Item("ORDER_DATE").ToString
                    dtFechaEntrega.Value = dtCabeceraPedido.Rows(i).Item("CADUCATE_DATE").ToString
                    txttipoDocRef.Text = dtCabeceraPedido.Rows(i).Item("DOCUMENT_REF").ToString
                    txtNumDocRef.Text = dtCabeceraPedido.Rows(i).Item("NUMBER_REF").ToString
                    txtSerieDocRef.Text = dtCabeceraPedido.Rows(i).Item("SERIE_REF").ToString
                    txtCodCliente.Text = dtCabeceraPedido.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRucDni.Text = dtCabeceraPedido.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtRazonSocial.Text = dtCabeceraPedido.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtDireccion.Text = dtCabeceraPedido.Rows(i).Item("CUSTOMER_ADDR").ToString
                    txtVendedor.Text = dtCabeceraPedido.Rows(i).Item("SALES_ID").ToString
                    txtFormaPago.Text = dtCabeceraPedido.Rows(i).Item("TERMS").ToString
                    txtGlosa.Text = dtCabeceraPedido.Rows(i).Item("COMMENT").ToString
                    cboMoneda.SelectedValue = dtCabeceraPedido.Rows(i).Item("CURRENCY_ID").ToString
                    cbSerieGuia.SelectedValue = dtCabeceraPedido.Rows(i).Item("SERIE_REF").ToString
                    txtCodTrans.Text = ""
                    cbDirEntrega.Text = ""
                Next
                'Mostrando Descripcion de la cabecera
                If txtPtoVenta.Text <> String.Empty Then
                    clsBuscarBl = New ClsBuscar
                    Dim dtDatos As New DataTable
                    dtDatos = clsBuscarBl.Get_NombrePuntoVenta(txtPtoVenta.Text)
                    If dtDatos.Rows.Count() <> 0 Then
                        lblPtoVenta.Text = dtDatos.Rows(0).Item(1)
                        txtAlmacen.Text = dtDatos.Rows(0).Item(2).ToString
                        lblAlmacen.Text = dtDatos.Rows(0).Item(3).ToString
                        If Flag_TipoDocumento = "F" Then
                            If txtPtoVenta.Text <> String.Empty Then
                                'Mostrando el tipo Doc asociado a Pnto venta
                                Ayuda_TipoDocPuntoVenta()
                                'Mostrando la serie
                                Ayuda_SerieGuiaPuntoVenta()
                                If cboTipoDoc.Text = String.Empty Then
                                    SerieDocumentoPuntoVenta()
                                End If
                            End If
                        End If
                    Else
                        txtPtoVenta.Text = ""
                        lblPtoVenta.Text = ""
                    End If
                End If

                If txtCodCliente.Text <> String.Empty Then
                    clsBuscarBl = New ClsBuscar
                    Dim dtDatos As New DataTable
                    dtDatos = clsBuscarBl.Get_NombreTerceros(txtCodCliente.Text)
                    If dtDatos.Rows.Count() <> 0 Then
                        txtCodCliente.Text = dtDatos.Rows(0).Item(0).ToString
                        txtRazonSocial.Text = dtDatos.Rows(0).Item(1).ToString
                        txtRucDni.Text = dtDatos.Rows(0).Item(2).ToString
                        txtDireccion.Text = dtDatos.Rows(0).Item(3).ToString
                        If Flag_TipoDocumento = "F" Then
                            cbDirEntrega.DataSource = Nothing
                            cbDirEntrega.Items.Clear()
                            cbDirEntrega.Items.Add(dtDatos.Rows(0).Item("ADDR_DLV").ToString)
                            cbDirEntrega.SelectedIndex = 0
                        End If

                        If txtFormaPago.Text = String.Empty Then
                            lblFormaPago.Text = ""
                        Else
                            clsBuscarBl = New ClsBuscar
                            lblFormaPago.Text = clsBuscarBl.Get_FormaCobro(txtFormaPago.Text)
                            If lblFormaPago.Text = String.Empty Then
                                txtFormaPago.Text = ""
                            End If
                        End If
                        If txtVendedor.Text <> String.Empty Then
                            clsBuscarBl = New ClsBuscar
                            lblVendedor.Text = clsBuscarBl.Get_NombreVendedor(txtVendedor.Text)
                            If lblVendedor.Text = String.Empty Then
                                txtVendedor.Text = ""
                            End If
                        Else
                            lblVendedor.Text = ""
                        End If
                    Else
                        txtCodCliente.Text = ""
                    End If
                End If
                '---Mostrando datos del Detalle
                cabeceraPedidoBL = New ClsOperaciones.ORDERS
                dtDetallePedido = New DataTable
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = cabeceraPedidoBL.Get_DetallePedido(NUMBER_DOCUMENT)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    chkSinIGV.Checked = True
                    Mostrando_Totales_Generales()
                Else
                    MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                    ''CALCULANDO TOTALES GENERALES
                    txtBruto.Text = "0.00"
                    txtDescuentos.Text = "0.00"
                    txtvalorVenta.Text = "0.00"
                    txtIgv.Text = "0.00"
                    txtPrecioVenta.Text = "0.00"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvDocumentosPedidos.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Dim NumeroPedido As String = String.Empty
        NumeroPedido = dgvDocumentosPedidos.Item(0, dgvDocumentosPedidos.CurrentRow.Index).Value
        MostrarModoConsultar(NumeroPedido)
        dgvDocumentosPedidos.Visible = False
        GbCabecera.Enabled = False
        gbdetalle.Enabled = True
        gbOpciones.Enabled = False
        Call Botonera_Estado_Cambiar(True)
    End Sub

    Private Function CodigoNumeracionPedidos() As Boolean
        Dim estado As Boolean = True
        Try
            clsAlmacenBl = New ClsTransacciones.clsAlmacen
            clsAlmacenBl.Get_NumeroPedidos()
            NumeracionPedido = String.Empty
            NumeracionPedido = CStr(String.Format("{0:0000000}", CInt(clsAlmacenBl.LAST_NUMBER + 1)))
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function




    Private Function validacionesFacturacion() As Boolean
        Dim estado As Boolean = True
        Try
            If cboTipoDoc.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir el tipo de documento a facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cboTipoDoc.Focus()
                estado = False
                Exit Try
            ElseIf cboSerieDoc.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir la serie para el Documento a Facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cboSerieDoc.Focus()
                estado = False
                Exit Try
            ElseIf cbSerieGuia.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir la serie para la Guía de Remisión.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbSerieGuia.Focus()
                estado = False
                Exit Try
            ElseIf txtCodTrans.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar el Código de Transportista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodTrans.Focus()
                estado = False
                Exit Try
            ElseIf cbDirEntrega.Items.Count > 0 Then
                If cbDirEntrega.SelectedIndex = -1 Then
                    MessageBox.Show("Debe elegir la Dirección de Entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cbDirEntrega.Focus()
                    estado = False
                    Exit Try
                End If
            End If
            If dgvDetalle.Rows.Count() = 0 Then
                MsgBox("No hay items en el Detalle de la Guia", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub GuardarPedidos()
        Try
            ''Cabecera PEDIDO
            cabeceraPedidoBL = New ClsOperaciones.ORDERS
            cabeceraPedidoENT = New ClsEntidades.ORDER
            DetallePedidoBL = New ClsOperaciones.ORDERS_LINE
            listaDetallepedido = New List(Of ClsEntidades.ORDER_LINE)

            With cabeceraPedidoENT
                .ID = NumeracionPedido
                .ORDER_DATE = dtFechaEmision.Value.ToString("dd/MM/yyyy")
                .CADUCATE_DATE = dtFechaEntrega.Value.ToString("dd/MM/yyyy")
                .SALES_ID = txtVendedor.Text
                .PLACE_SALES = txtPtoVenta.Text
                .CUSTOMER_ID = txtCodCliente.Text
                .CUSTOMER_NAME = txtRazonSocial.Text
                .CUSTOMER_ADDR = txtDireccion.Text
                .VAT_REGISTRATION = txtRucDni.Text
                .AMOUNT = txtPrecioVenta.Text
                .DISCOUNT_CUSTOMER = 0
                .DISCOUNT_SP = 0
                .TERMS = txtFormaPago.Text
                .SELL_RATE = txtTipoCambio.Text
                .CURRENCY_ID = cboMoneda.SelectedValue.ToString
                .DOCUMENT_REF = txttipoDocRef.Text
                .SERIE_REF = txtSerieDocRef.Text
                .NUMBER_REF = txtNumDocRef.Text
                .CREATE_DATE = DateTime.Now()
                .STATUS = "V"
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .COMMENT = txtGlosa.Text
                .NUMBER_GUIA = ""
                .NUMBER_REC = ""
                .ORDER_PURCHASE = txtordenCompra.Text
                .COMMENT1 = ""
                .AMOUNT_VAT = 0
                .DISCOUNT = 0
                .DISCOUNT_AMOUNT = 0
                .REC_TYPE = ""
                .DISCOUNT_VAL = 0
                .STATUS_ORDER = "EMITIDO"
                .TRAMA_ID = ""
                .AMOUNT_ISC = 0
            End With

            'Detalle deL PEDIDO
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                DetallePedidoENT = New ClsEntidades.ORDER_LINE
                With DetallePedidoENT
                    .ID = NumeracionPedido
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM")
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO")
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION")
                    .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD")
                    .PRICE_SALES = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO_IGV"))
                    .PRICE_ORI = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO"))
                    .DISCOUNT = 0
                    .AMOUNT_TAX = dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART")
                    .DISCOUNT_CUST = 0
                    .DISCOUNT_SP = 0
                    .PERCENT_TAX = 18
                    .PERCENT_DISCOUNT = 0
                    .AMOUNT_US = dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART_US")
                    .AMOUNT = dtdetalleArticuloPrincipal.Rows(i).Item("IMPORTE")
                    .STATUS = ""
                    .SERIE = ""
                    .WAREHOUSE_ID = txtAlmacen.Text
                    .TEXT_COMMENT = txtGlosa.Text
                    .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD")
                    .LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE")
                    .BALANCE = 0
                    .IS_PART_TAX = 0
                    .LIST_ID = ""
                    .UNIT = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD")
                    .PERCENT_ISC = 0
                    .AMOUNT_ISC = 0
                End With
                listaDetallepedido.Add(DetallePedidoENT)
            Next
            ''GUARDANDO DATOS DEL PEDIDO
            cabeceraPedidoBL.GuardarPedido(cabeceraPedidoENT, listaDetallepedido, False)
            Dim msj As String = String.Empty
            msj = "Nueva Pedido Generado Correctamente," & vbCrLf & " Nro Documento: PD - " & NumeracionPedido
            MsgBox(msj, MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        txtPtoVenta.Clear()
        txtAlmacen.Clear()
        dtFechaEmision.Value = DateTime.Now
        dtFechaEntrega.Value = DateTime.Now
        txtCodCliente.Clear()
        txtRucDni.Clear()
        txtRazonSocial.Clear()
        txtDireccion.Clear()
        txtFormaPago.Clear()
        txtGlosa.Clear()
        chkSinIGV.Checked = True
        txtvalorVenta.Text = "0.00"
        txtIgv.Text = "0.00"
        txtPrecioVenta.Text = "0.00"
        txtBruto.Text = "0.00"
        txtDescuentos.Text = "0.00"
        lblAlmacen.Text = String.Empty
        lblFormaPago.Text = String.Empty
        lblPtoVenta.Text = String.Empty
        cboTipoDoc.DataSource = Nothing
        cboSerieDoc.DataSource = Nothing
        txtNumDocRef.Text = String.Empty
        cbSerieGuia.DataSource = Nothing
        txtCodTrans.Text = String.Empty
        txtGlosa.Text = String.Empty
        txtGlosaDoc.Text = String.Empty
        checkSinGuia.Checked = True
        txttipoDocRef.Text = String.Empty
        txtSerieDocRef.Text = String.Empty
        txtNumDocRef.Text = String.Empty
        cbDirEntrega.Items.Clear()
        txtordenCompra.Text = String.Empty
    End Sub

    Private Function CodigoNumeracionGuiaRemision() As Boolean
        Dim estado As Boolean = True
        Try
            Dim frmTipoNum As New FrmTipoNumeracion
            frmTipoNum.Almacen = txtAlmacen.Text
            frmTipoNum.TipoDocumento = "G"
            frmTipoNum.txtTitulo.Text = "GUIA"
            frmTipoNum.ShowDialog()
            If frmTipoNum.fl_datos = False Then
                estado = False
                frmTipoNum.Close()
                Exit Try
            End If
            NumeracionGuiaRemision = String.Empty
            TipoNumeracion = String.Empty
            NumeracionGuiaRemision = frmTipoNum.NumeracionGuiaRemision
            TipoNumeracion = frmTipoNum.TipoNumeracion
            frmTipoNum.Close()
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Function CodigoNumeracionFacturacion() As Boolean
        Dim estado As Boolean = True
        Try
            Dim frmTipoNum As New FrmTipoNumeracion
            frmTipoNum.Serie = cboSerieDoc.Text
            frmTipoNum.TipoDocumento = "F"
            frmTipoNum.txtTitulo.Text = "FACTURA"
            frmTipoNum.ShowDialog()
            If frmTipoNum.fl_datos = False Then
                estado = False
                frmTipoNum.Close()
                Exit Try
            End If
            NumeracionFacturacion = String.Empty
            TipoNumeracion = String.Empty
            NumeracionFacturacion = frmTipoNum.NumeracionFactura
            TipoNumeracion = frmTipoNum.TipoNumeracion
            frmTipoNum.Close()
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Function CodigoNumeracionNotaCredito() As Boolean
        Dim estado As Boolean = True
        Try
            Dim frmTipoNum As New FrmTipoNumeracion
            frmTipoNum.Serie = cboSerieDoc.Text
            frmTipoNum.TipoDocumento = "NC"
            frmTipoNum.Serie = cboSerieDoc.Text
            frmTipoNum.txtTitulo.Text = "NOTA DE CREDITO"
            frmTipoNum.ShowDialog()
            If frmTipoNum.fl_datos = False Then
                estado = False
                frmTipoNum.Close()
                Exit Try
            End If
            NumeracionFacturaNotac = String.Empty
            TipoNumeracion = String.Empty
            NumeracionFacturaNotac = frmTipoNum.NumeracionFacturaNotaC
            TipoNumeracion = frmTipoNum.TipoNumeracion
            frmTipoNum.Close()
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Function CodigoNumeracionNotaDebito() As Boolean
        Dim estado As Boolean = True
        Try
            Dim frmTipoNum As New FrmTipoNumeracion
            frmTipoNum.Serie = cboSerieDoc.Text
            frmTipoNum.TipoDocumento = "ND"
            frmTipoNum.Serie = cboSerieDoc.Text
            frmTipoNum.txtTitulo.Text = "NOTA DE DEBITO"
            frmTipoNum.ShowDialog()
            If frmTipoNum.fl_datos = False Then
                estado = False
                frmTipoNum.Close()
                Exit Try
            End If
            NumeracionFacturaNotaD = String.Empty
            TipoNumeracion = String.Empty
            NumeracionFacturaNotaD = frmTipoNum.NumeracionFacturaNotaD
            TipoNumeracion = frmTipoNum.TipoNumeracion
            frmTipoNum.Close()
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Public Function Get_FormaPagoFechaVencimiento() As Date
        Dim fechaVencimiento As Date
        Try
            clsBuscarBl = New ClsBuscar
            Dim dtFormaPagoFechaV As DataTable
            dtFormaPagoFechaV = clsBuscarBl.Get_FormaPagoFechaVencimiento(txtFormaPago.Text)
            If dtFormaPagoFechaV.Rows.Count() <> 0 Then
                fechaVencimiento = DateAdd(DateInterval.Day, CInt(dtFormaPagoFechaV.Rows(0).Item("Dias")), CDate(dtFechaEmision.Value.ToString("dd/MM/yyyy")))
            Else
                fechaVencimiento = CDate(dtFechaEmision.Value.ToString("dd/MM/yyyy"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return fechaVencimiento
    End Function


    Private Sub GuardarFacturacion()
        Try
            ''Cabecera FACTURA
            cabeceraBL = New ClsOperaciones.RECEIVABLE
            cabeceraBE = New ClsEntidades.RECEIVABLE
            carteraBE = New ClsEntidades.CUSTOMER_BALANCE
            ls_det = New List(Of ClsEntidades.RECEIVABLE_LINE)
            ls_det_alm = New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            ListaGuia_Alm = New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            alm_cabBE = New ClsEntidades.WAREHOUSE_TRANS
            ListaGuiaCab_alm = New List(Of ClsEntidades.WAREHOUSE_TRANS)

            With cabeceraBE
                .DOCUMENT_ID = cboTipoDoc.Text
                .NUMBER_SERIE = cboSerieDoc.Text
                If cboTipoDoc.Text = "FT" Then
                    .NUMBER_DOCUMENT = NumeracionFacturacion
                ElseIf cboTipoDoc.Text = "NC" Then
                    .NUMBER_DOCUMENT = NumeracionFacturaNotac
                ElseIf cboTipoDoc.Text = "ND" Then
                    .NUMBER_DOCUMENT = NumeracionFacturaNotaD
                End If
                .DOCUMENT_DATE = dtFechaEmision.Value
                .CADUCATE_DATE = Get_FormaPagoFechaVencimiento()
                .DR_CR = "D"
                .SALES_REP_ID = txtVendedor.Text
                .PLACE_SALES = txtPtoVenta.Text
                .NUMBER_QUOTE = 0
                .NUMBER_ORDER_PUR = txtordenCompra.Text
                .CFDESCPG = 0
                .POINT_ORIG = 0
                .POINT_BOARD = 0
                .POINT_ARRIVAL = 0
                .RECEIVABLE_TYPE = cboTipoDoc.Text
                .CUSTOMER_ID = txtCodCliente.Text.Trim
                .CUSTOMER_NAME = txtRazonSocial.Text.Trim
                .CUSTOMER_ADDR = txtDireccion.Text.Trim
                .VAT_REGISTRATION = txtRucDni.Text.Trim
                .WAREHOUSE_ID = txtAlmacen.Text
                .AMOUNT = txtPrecioVenta.Text
                .TERMS_ID = txtFormaPago.Text.Trim
                .BALANCE = txtPrecioVenta.Text
                .SELL_RATE = CDbl(txtTipoCambio.Text)
                .CURRENCY_ID = cboMoneda.SelectedValue
                .DOCUMENT_REF = "PD"
                .SERIE_REF = ""
                .NUMBER_REF = txtNumeroPedido.Text
                .NUMBER_ORDER = 0
                .CREATE_DATE = Date.Now.ToShortDateString
                .LAST_MODIFIED = Date.Now.ToShortDateString
                .STATUS = "V"
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .COMMENT = txtGlosa.Text.Trim
                .IS_GUIA_REC = 0
                .NUMBER_REGISTRATION = 0
                .DISCOUNT_PERCENT = 0
                .CARD_ID = "NO"
                .DISCOUNT_PERCENT_SP = 0
                .NUMBER_CARD = 0
                .AMOUNT_CARD_US = 0
                .AMOUNT_CARD = 0
                .BANK_CHECK = 0
                .NUMBER_CHECK = 0
                .AMOUNT_CH_US = 0
                .AMOUNT_CH = 0
                .VOUCHER_ID = 0
                .NUMBER_TRA = 0
                .AMOUNT_TAX = txtIgv.Text
                .DISCOUNTV = 0
                .DISCOUNTP = 0
                .LIST_GUIA = 0
                .IS_PRINT = 0
                .DISCOUNT_RECIVABLE = 0
                .IS_CLOSED = 0
                .SUB_ID = ""
                .TOTAL_ERROR = 0
                .PROMISE_DAYS = 0
                .SHIPPER_TYPE = ""
                .ZONE_FREIGTH = ""
                .AMOUNT_FREIGTH = 0
                .IS_GUIA = 0
                .IS_CASH_BANK = 0
                .TAX_TYPE = 0
                .REC_AUTO = ""
                .TRAMA_ID = ""
                .VEHICULO_ID = ""
                .EMPTRA_ID = ""
                .ISC = 0
                .DOCUMENT_TYPE_COMP_PER = ""
                .SERIE_COMP_PER = ""
                .NUMBER_COMP_PER = ""
                .ESTADO_DESPACHO = ""
            End With

            'Detalle de Factura
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                detalle = New ClsEntidades.RECEIVABLE_LINE
                With detalle
                    .DOCUMENT_ID = cboTipoDoc.Text
                    .NUMBER_SERIE = cboSerieDoc.Text
                    If cboTipoDoc.Text = "FT" Then
                        .NUMBER_DOCUMENT = NumeracionFacturacion
                    ElseIf cboTipoDoc.Text = "NC" Then
                        .NUMBER_DOCUMENT = NumeracionFacturaNotac
                    ElseIf cboTipoDoc.Text = "ND" Then
                        .NUMBER_DOCUMENT = NumeracionFacturaNotaD
                    End If
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM")
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO")
                    .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD")
                    .PRICE_SALES = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO_IGV"))
                    .PRICE_ORI = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO"))
                    .DISCOUNT = 0
                    .AMOUNT_TAX = dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART")
                    .TAX_PERCENT = 18
                    .AMOUNT_US = dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART_US")
                    .AMOUNT = dtdetalleArticuloPrincipal.Rows(i).Item("IMPORTE")
                    .UNIT = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD")
                    .STATUS = "V"
                    .PART_SERIE = 0
                    .WAREHOUSE_ID = txtAlmacen.Text
                    .TEXT_DESCRIPTION = ""
                    .DFTR = 0
                    .STOCK = 0
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION")
                    .QTY_REF = 0
                    .DISCOUNT_PERCENT = 0
                    .BALANCE_PART = 0
                    .DISCOUNT_CUSTOMER = 0
                    .DISCOUNT_SP = 0
                    .PART_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE")
                    .NUMBER_GUIA = 0
                    .PART_TAX = 0
                    .DISCOUNT1 = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IMP_DESC_01"))
                    .DISCOUNT2 = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IMP_DESC_02"))
                    .PERCENT1 = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("%DESC.ART_1"))
                    .PERCENT2 = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("%DESC.ART_2"))
                    .PRICE_LIST_ID = 0
                    .SHIPPER_QTY = 0
                    .BUDGET_ID = 0
                    .ORDER_ID = 0
                    .BRUTE_QTY = 0
                    .DISCOUNT_QTY_BRUTE = 0
                    .UM_REFERENCE = 0
                    .QTY_REFERENCE = 0
                    .COMISION = 0
                    .TIPOISC = 0
                    .ISCPOR = 0
                    .ISC = 0
                End With
                ls_det.Add(detalle)
            Next

            'CLIENTES
            With carteraBE
                .CUSTOMER_ID = txtCodCliente.Text.Trim
                .DOCUMENT_ID = cboTipoDoc.Text
                If cboTipoDoc.Text = "FT" Then
                    .NUMBER_DOC = cboSerieDoc.Text & NumeracionFacturacion
                ElseIf cboTipoDoc.Text = "NC" Then
                    .NUMBER_DOC = cboSerieDoc.Text & NumeracionFacturaNotac
                ElseIf cboTipoDoc.Text = "ND" Then
                    .NUMBER_DOC = cboSerieDoc.Text & NumeracionFacturaNotaD
                End If
                .DOC_DATE = CDate(dtFechaEmision.Value).ToShortDateString
                .CADUCATE_DATE = Get_FormaPagoFechaVencimiento()
                .DOCUMENT_REF = txttipoDocRef.Text
                .NUMBER_REF = txtSerieDocRef.Text & txtNumDocRef.Text
                .SALES_ID = txtVendedor.Text.Trim
                .AMOUNT = txtPrecioVenta.Text
                .AMOUNT_BALANCE = txtPrecioVenta.Text
                .CURRENCY_ID = cboMoneda.SelectedValue
                .SELL_RATE = CDbl(txtTipoCambio.Text)
                .IS_DR_CR = 0
                .STATUS = "V"
                .CREATE_DATE = Date.Now.ToShortDateString
                .LAST_MODIFIED = Date.Now.ToShortDateString
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .ACCOUNT = ""
                .AMOUNT_COMM = cboTipoDoc.SelectedValue().ToString
                .TYPE_REC = 0
                .REFERENCE_DATE = Date.Now.ToShortDateString
                .IS_CHECK_DIF = 0
                .AMOUNT_BALANCE_INI = txtPrecioVenta.Text
                .TERMS = 0
                .PLACE_SALES = txtPtoVenta.Text
                .BANK_ID = 0
                .BANK_DESCRIPTION = 0
                .AMOUNT_PER = 0
                .PERCENT_PER = 0
                .ACCOUNT_PER = 0
                .CUST_AUTO = 0
                .SERIE_AUX = cboSerieDoc.Text
                .NUM_DOC_AUX = .NUMBER_DOC
            End With

            'la parte de almacen
            With alm_cabBE
                .WAREHOUSE_ID = txtAlmacen.Text
                If cboTipoDoc.Text = "FT" Then
                    .DOCUMENT_ID = "FT"
                    .NUMBER_DOCUMENT = cboSerieDoc.Text & NumeracionFacturacion
                    .TYPE_TRANS = "S"
                    .TRANS_ID = "FT"
                ElseIf cboTipoDoc.Text = "NC" Then
                    .DOCUMENT_ID = "NC"
                    .NUMBER_DOCUMENT = cboSerieDoc.Text & NumeracionFacturaNotac
                    .TYPE_TRANS = "I"
                    .TRANS_ID = "FT"
                ElseIf cboTipoDoc.Text = "ND" Then
                    .DOCUMENT_ID = "ND"
                    .NUMBER_DOCUMENT = cboSerieDoc.Text & NumeracionFacturaNotaD
                    .TYPE_TRANS = "S"
                    .TRANS_ID = "FT"
                End If
                .DATE_DOCUMENT = CDate(dtFechaEmision.Value).ToShortDateString
                .DOC_ID_REF = "PD"
                .NUM_ID_REF = txtNumeroPedido.Text
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .CUSTOMER_ID = txtCodCliente.Text
                .VAT_REGISTRATION = txtRucDni.Text
                .CUSTOMER_NAME = txtRazonSocial.Text
                .SALES_TERM = txtFormaPago.Text.Trim
                .CURRENCY_TYPE = cboMoneda.SelectedValue
                .CURRENCY_EXCHANGE = CDbl(txtTipoCambio.Text)
                .STATUS_GUIA = "F"
                .TYPE_GUIA = ""
                .CARRIER_ID = txtCodTrans.Text
                .CARRIER_NAME = txtNomTrans.Text
                .CARRIER_ADDR = cbDirEntrega.Text
                .AMOUNT = Math.Abs(CDbl(txtPrecioVenta.Text))
                .COMMENT = txtGlosa.Text
                .WAREHOUSE_REF = ""
                .NUMBER_PURCHASE = ""
            End With

            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE
                    .WAREHOUSE_ID = txtAlmacen.Text
                    If cboTipoDoc.Text = "FT" Then
                        .DOCUMENT_ID = "FT"
                        .NUMBER_DOCUMENT = cboSerieDoc.Text & NumeracionFacturacion
                    ElseIf cboTipoDoc.Text = "NC" Then
                        .DOCUMENT_ID = "NC"
                        .NUMBER_DOCUMENT = cboSerieDoc.Text & NumeracionFacturaNotac
                    ElseIf cboTipoDoc.Text = "ND" Then
                        .DOCUMENT_ID = "ND"
                        .NUMBER_DOCUMENT = cboSerieDoc.Text & NumeracionFacturaNotaD
                    End If
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .QTY = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD"))
                    .QTY_DLV = 0
                    .QTY_REF = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD"))
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO"))
                    .AVERAGE_COST = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO_IGV"))
                    .AMOUNT_TAX = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART"))
                    .AMOUNT_US = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART_US"))
                    .AMOUNT = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IMPORTE"))
                    .STATUS = ""
                    .TRANS_ID = ""
                    .CURRENCY_ID = cboMoneda.SelectedValue().ToString
                    .TYPE_EXCHANGE = CDbl(txtTipoCambio.Text)
                    .PRICE_SALES = 0
                    .TAX_PERCENT = 18
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                    .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                    .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                End With
                ls_det_alm.Add(alm_detBE)
            Next

            ''GUARDANDO DATOS DE LA FACTURACION
            'cabeceraBL.GuardarFactura(cabeceraBE, ls_det, carteraBE, alm_cabBE, ls_det_alm, TipoNumeracion, cboTipoDoc.Text)
            ''GUARDANDO DATOS DE LA  GUIA DE SALIDA
            If checkSinGuia.Checked = False Then
                alm_cabBE = New ClsEntidades.WAREHOUSE_TRANS
                ls_det_alm = New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
                With alm_cabBE
                    .WAREHOUSE_ID = txtAlmacen.Text
                    .DOCUMENT_ID = "GS"
                    .NUMBER_DOCUMENT = NumeracionGuiaRemision
                    .DATE_DOCUMENT = CDate(dtFechaEmision.Value).ToShortDateString
                    .TYPE_TRANS = "S"
                    .TRANS_ID = "GF"
                    .DOC_ID_REF = txttipoDocRef.Text
                    .NUM_ID_REF = cboSerieDoc.Text & NumeracionFacturacion
                    .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .CUSTOMER_ID = txtCodCliente.Text
                    .VAT_REGISTRATION = txtRucDni.Text
                    .CUSTOMER_NAME = txtRazonSocial.Text
                    .SALES_TERM = txtFormaPago.Text.Trim
                    .CURRENCY_TYPE = cboMoneda.SelectedValue
                    .CURRENCY_EXCHANGE = CDbl(txtTipoCambio.Text)
                    .STATUS_GUIA = "F"
                    .TYPE_GUIA = "GF"
                    .CARRIER_ID = txtCodTrans.Text
                    .CARRIER_NAME = txtNomTrans.Text
                    .CARRIER_ADDR = cbDirEntrega.Text
                    .AMOUNT = CDbl(txtPrecioVenta.Text.Trim)
                    .COMMENT = txtGlosaDoc.Text
                    .WAREHOUSE_REF = ""
                    .NUMBER_PURCHASE = ""
                End With
                For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                    alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                    With alm_detBE
                        .WAREHOUSE_ID = txtAlmacen.Text
                        .DOCUMENT_ID = "GS"
                        .NUMBER_DOCUMENT = NumeracionGuiaRemision
                        .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM")
                        .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO")
                        .QTY = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD"))
                        .QTY_DLV = 0
                        .QTY_REF = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD"))
                        .QTY_INVOICED = 0
                        .AMOUNT_SALES = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO"))
                        .AVERAGE_COST = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO_IGV"))
                        .AMOUNT_TAX = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART"))
                        .AMOUNT_US = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART_US"))
                        .AMOUNT = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IMPORTE"))
                        .STATUS = "F"
                        .TRANS_ID = "GF"
                        .CURRENCY_ID = cboMoneda.SelectedValue().ToString
                        .TYPE_EXCHANGE = txtTipoCambio.Text
                        .PRICE_SALES = 0
                        .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                        .TAX_PERCENT = 18
                        .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                        .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                    End With
                Next
                ls_det_alm.Add(alm_detBE)
                ''GUARDANDO DATOS DE LA  GUIA DE SALIDA
                cabeceraBL.GuardarGuiaSalida(alm_cabBE, ls_det_alm, TipoNumeracion)
            End If

            Dim msj As String = String.Empty
            If cboTipoDoc.Text = "FT" Then
                msj = "Nueva Factura Generado Correctamente," & vbCrLf & " Nro Documento: FT- " & cboSerieDoc.Text & NumeracionFacturacion
                MsgBox(msj, MsgBoxStyle.Information)
            ElseIf cboTipoDoc.Text = "NC" Then
                msj = "Nueva Nota de Credito Generado Correctamente," & vbCrLf & " Nro Documento: NC- " & cboSerieDoc.Text & NumeracionFacturaNotac
                MsgBox(msj, MsgBoxStyle.Information)
            ElseIf cboTipoDoc.Text = "ND" Then
                msj = "Nueva Nota de Debito Generado Correctamente," & vbCrLf & " Nro Documento: ND- " & cboSerieDoc.Text & NumeracionFacturaNotaD
                MsgBox(msj, MsgBoxStyle.Information)
            End If

            If checkSinGuia.Checked = False Then
                msj = String.Empty
                msj = "Nueva Guia de Salida Generado Correctamente," & vbCrLf & " Nro Documento: GS-" & NumeracionGuiaRemision
                MsgBox(msj, MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If Flag_TipoDocumento = "P" Then
            If validacionesPedidos() = False Then Exit Sub
            If CodigoNumeracionPedidos() = False Then
                MsgBox("Es necesario una Numeracion para el Pedido", MsgBoxStyle.Information)
                Exit Sub
            End If
            GuardarPedidos()
        ElseIf Flag_TipoDocumento = "F" Then
            If validacionesFacturacion() = False Then Exit Sub
            MsgBox("Es necesario una Numeracion para la Factura", MsgBoxStyle.Information)
            Exit Sub

            If cboTipoDoc.Text = "FT" Then
                If CodigoNumeracionFacturacion() = False Then
                    MsgBox("Es necesario una Numeracion para la Factura", MsgBoxStyle.Information)
                    Exit Sub
                End If
                If checkSinGuia.Checked = False Then
                    If CodigoNumeracionGuiaRemision() = False Then
                        MsgBox("Es necesario una Numeracion para la Guia Remision.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If
            ElseIf cboTipoDoc.Text = "NC" Then
                If CodigoNumeracionNotaCredito() = False Then
                    MsgBox("Es necesario una Numeracion para la Nota de Credito.", MsgBoxStyle.Information)
                    Exit Sub
                End If
            ElseIf cboTipoDoc.Text = "ND" Then
                If CodigoNumeracionNotaDebito() = False Then
                    MsgBox("Es necesario una Numeracion para la Nota de Debito.", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
            GuardarFacturacion()
        End If
        dgvDocumentosPedidos.Visible = True
        pnlFiltro.Visible = True
        Botonera_Estado_Cambiar(False)
        DocumentosPedidos()
        Nuevo()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvDocumentosPedidos.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'EliminarGuiasRemision()
        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click

        If dgvDocumentosPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay pedidos por anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STRPedido As String = String.Empty
        Dim STREstado As String = String.Empty

        STRPedido = dgvDocumentosPedidos.Rows(dgvDocumentosPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgvDocumentosPedidos.Rows(dgvDocumentosPedidos.CurrentRow.Index).Cells(8).Value
        If STREstado = "AUTORIZADO" Then
            MessageBox.Show("El pedido ya se encuentra autorizado, no puede anularse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "ANULADO" Then
            MessageBox.Show("El pedido ya se encuentra anulado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea Anular el Pedido " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If STREstado = "EMITIDO" Then
                cProcesosbL = New ClsProcesos
                If cProcesosbL.Actualiza_Status_Pedido(STRPedido, "ANULADO") = True Then
                    MessageBox.Show("Pedido anulado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                dgvDocumentosPedidos.Visible = True
                'Mostrando todos los Datos Actuales
                DocumentosPedidos()
                Botonera_Estado_Cambiar(False)
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvDocumentosPedidos.CurrentRow Is Nothing Then Exit Sub
        Dim Ref_idalamacen As String = String.Empty
        Dim Ref_documentid As String = String.Empty
        Dim Ref_numerodocument As String = String.Empty

        'If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        'imprimirGuiaRemision(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvDocumentosPedidos.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmRegistroPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboopcionesBusqueda.SelectedIndex = 0
        DocumentosPedidos()
        Botonera_Estado_Cambiar(False)
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        txtTipoCambio.Text = ClsVarComun.TCVenta
        txtVendedor.Text = CodigoVendedor
        lblVendedor.Text = DescripcionVendedor
        Call Cargar_Moneda()
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Visible = False
            Case 1
                gbRangofechas.Visible = False
            Case 2
                gbRangofechas.Visible = True
        End Select
        txtFiltro.Text = String.Empty
        DocumentosPedidos()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosPedidos()
        End If
    End Sub

    Private Sub Ayuda_PuntoVenta()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_PTO_VENTA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Punto de Venta"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtPtoVenta.Text = frm.Data_Matriz.Rows(0).Item(0)
                lblPtoVenta.Text = frm.Data_Matriz.Rows(0).Item(1)
                txtAlmacen.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                lblAlmacen.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPtoVenta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtPtoVenta.MouseDoubleClick
        Ayuda_PuntoVenta()
    End Sub

    Private Sub txtPtoVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPtoVenta.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_PuntoVenta()
        End If
    End Sub

    Private Sub Ayuda_Clientes()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_ORDER_CLIENTE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtCodCliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtRazonSocial.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtRucDni.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txtDireccion.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(5)
                If txtFormaPago.Text.Trim.Length > 0 Then
                    Dim clsBuscarBl As New ClsBuscar
                    lblFormaPago.Text = clsBuscarBl.Get_FormaCobro(txtFormaPago.Text)
                    If lblFormaPago.Text = String.Empty Then
                        txtFormaPago.Text = ""
                    End If
                Else
                    lblFormaPago.Text = ""
                End If
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_FormaPago()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_FORMA_COBRO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Forma de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblFormaPago.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Clientes()
        End If
    End Sub

    Private Sub txtCodCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCodCliente.MouseDoubleClick
        Ayuda_Clientes()
    End Sub

    Private Sub txtFormaPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFormaPago.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_FormaPago()
        End If
    End Sub

    Private Sub txtFormaPago_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFormaPago.MouseDoubleClick
        Ayuda_FormaPago()
    End Sub

    Private Function validacionesPedidos() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtFechaEmision.Value.ToString("dd/MM/yyyy")) > CDate(dtFechaEntrega.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtFechaEmision.Focus()
                estado = False
                Exit Try
            End If

            If txtPtoVenta.Text = String.Empty Then
                MsgBox("Debe seleccionar un Punto de venta.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If txtAlmacen.Text = String.Empty Then
                MsgBox("Debe seleccionar un Almacen, para poder continuar.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If cboMoneda.Text = String.Empty Then
                MsgBox("No se cargo datos del Tipo de Moneda.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If txtTipoCambio.Text = String.Empty Then
                MsgBox("No se cargo el dato del Tipo de Cambio.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If txtCodCliente.Text = String.Empty Then
                MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If txtFormaPago.Text = String.Empty Then
                MsgBox("Debe seleccionar una Forma de Pago.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If txtVendedor.Text = String.Empty Then
                MsgBox("No se cargo el dato del Vendedor.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If dgvDetalle.Rows.Count() = 0 Then
                MessageBox.Show("No ha ingresado ningún producto para el pedido.", "Aviso", MessageBoxButtons.OK)
                estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function DatosArticulos(Optional ByVal CodigoPart As String = "") As List(Of String)
        Dim listaArt As List(Of String)
        listaArt = New List(Of String)
        Try
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                For i As Integer = 0 To dgvDetalle.Rows.Count() - 1
                    Dim Articulos As String = String.Empty
                    Articulos = dgvDetalle.Item(1, i).Value
                    If listaArt.Contains(Articulos) = False Then
                        listaArt.Add(Articulos)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return listaArt
    End Function

    'NUMERO DE ITEM POR DOCUMENTOS
    Private Function NumeroItemsDocumentos() As Integer
        NumeroLineas = 0
        Try
            clsAlmacenBl = New ClsTransacciones.clsAlmacen
            ' clsAlmacenBl.Get_ItemDocumentos(cboTipoDoc.Text, cboSerieDoc.Text)
            clsAlmacenBl.Get_ItemDocumentos("PD", "001")
            NumeroLineas = clsAlmacenBl.NUMBER_LINE
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return NumeroLineas
    End Function

    Private Function DatosLotes(Optional ByVal Lote As String = "", Optional ByVal CodigoPart As String = "") As String
        Dim Cadena As String = String.Empty
        Try
            Dim listaLot As New List(Of String)
            Dim cadena_lote As String = String.Empty
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                If edicion = True Then
                    If dtdetalleArticuloPrincipal.Rows.Count() = 1 Then
                        Exit Try
                    End If
                End If
                If Lote = String.Empty Then
                    For i As Integer = 0 To dgvDetalle.Rows.Count() - 1
                        Dim lotes As String = String.Empty
                        lotes = dgvDetalle.Item(5, i).Value
                        If listaLot.Contains(lotes) = False Then
                            listaLot.Add(lotes)
                        End If
                    Next
                    For j As Integer = 0 To listaLot.Count() - 1
                        cadena_lote += "'" & listaLot(j) & "',"
                    Next
                    Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
                Else
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("CODIGO='" & CodigoPart & "' and LOTE NOT IN ('" & Lote & "')")
                        Dim lotes As String = String.Empty
                        lotes = item("LOTE")
                        If listaLot.Contains(lotes) = False Then
                            listaLot.Add(lotes)
                        End If
                    Next
                    If listaLot.Count() <> 0 Then
                        For j As Integer = 0 To listaLot.Count() - 1
                            cadena_lote += "'" & listaLot(j) & "',"
                        Next
                        Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Cadena
    End Function




    Private Sub Mostrando_Totales_Generales()
        Try
            Dim i As Integer = 0
            Dim total As Double = 0.0
            Dim totaldesc1 As Double = 0.0
            Dim totaldesc2 As Double = 0.0
            Dim TasaIgv, po_TasaIgv As Double
            Dim Monto As Double = 0.0

            If dgvDetalle.RowCount > 0 Then
                'Datos del Sistema Parametros Generales
                clsIgvArticuloBL = New ClsTransacciones.clsPedidos
                dtIgvArticulo = New DataTable("IGV_SISTEMA")
                po_TasaIgv = 0.0
                dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvsSistema()
                po_TasaIgv = CDbl(dtIgvArticulo.Rows(0).Item("AMOUNT_TAX"))

                If dtIgvArticulo.Rows.Count() <> 0 Then
                    If chkSinIGV.Checked = False Then
                        If cboTipoDoc.Text = "NC" Then
                            '*********** CALCULOS DE TOTALES GENERALES ***
                            'total = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(PREC_UNITARIO)", "") * dtdetalleArticuloPrincipal.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero))
                            total = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(VALOR_VENTA)", ""), 4, MidpointRounding.AwayFromZero))
                            totaldesc1 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero))
                            totaldesc2 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero))
                            txtBruto.Text = -Math.Abs(Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero))
                            txtDescuentos.Text = -Math.Abs(Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero))
                            txtvalorVenta.Text = -Math.Abs(Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero))
                            txtIgv.Text = -Math.Abs(Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
                            '*********** 
                        Else
                            '*********** CALCULOS DE TOTALES GENERALES***
                            total = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(VALOR_VENTA)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc1 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc2 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero)
                            txtBruto.Text = Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtDescuentos.Text = Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero)
                            txtIgv.Text = Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero)
                            '*********** 
                        End If
                    Else
                        If cboTipoDoc.Text = "NC" Then
                            '*********** CALCULOS DE TOTALES GENERALES
                            total = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL_INICIAL)", ""), 4, MidpointRounding.AwayFromZero))
                            totaldesc1 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero))
                            totaldesc2 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero))

                            txtBruto.Text = -Math.Abs(Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero))
                            txtDescuentos.Text = -Math.Abs(Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero))
                            txtvalorVenta.Text = -Math.Abs(Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero))
                            txtIgv.Text = -Math.Abs(Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
                            '***********
                        Else
                            '*********** CALCULOS DE TOTALES GENERALES
                            total = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL_INICIAL)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc1 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc2 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero)

                            txtBruto.Text = Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtDescuentos.Text = Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero)
                            txtIgv.Text = Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero)
                            '***********
                        End If
                    End If
                End If
                '*********** FORMATO DE SALIDA
                txtBruto.Text = Format(Double.Parse(txtBruto.Text), "##,##0.00")
                txtDescuentos.Text = Format(Double.Parse(txtDescuentos.Text), "##,##0.00")
                txtvalorVenta.Text = Format(Double.Parse(txtvalorVenta.Text), "##,##0.00")
                txtIgv.Text = Format(Double.Parse(txtIgv.Text), "##,##0.00")
                txtPrecioVenta.Text = Double.Parse(txtBruto.Text) + Double.Parse(txtIgv.Text)
                txtPrecioVenta.Text = Format(Double.Parse(txtPrecioVenta.Text), "##,##0.00")
                '***********
            Else
                txtBruto.Text = "0.00"
                txtDescuentos.Text = "0.00"
                txtvalorVenta.Text = "0.00"
                txtIgv.Text = "0.00"
                txtPrecioVenta.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Calcular_Totales()
        Try
            Dim i As Integer = 0
            Dim total As Double = 0.0
            Dim totaldesc1 As Double = 0.0
            Dim totaldesc2 As Double = 0.0
            Dim TasaIgv, po_TasaIgv, Igv As Double
            Dim Monto As Double = 0.0

            If dgvDetalle.RowCount > 0 Then
                'Datos del Sistema Parametros Generales
                clsIgvArticuloBL = New ClsTransacciones.clsPedidos
                dtIgvArticulo = New DataTable("IGV_SISTEMA")
                po_TasaIgv = 0.0
                Igv = 0.0
                dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvsSistema()
                po_TasaIgv = CDbl(dtIgvArticulo.Rows(0).Item("AMOUNT_TAX"))
                'obteniendo Datos del Articulo
                For Each row As DataRow In dtdetalleArticuloPrincipal.Rows
                    'VERIFICA SI EL ARTICULO ESTA SUJETO A IGV
                    clsIgvArticuloBL = New ClsTransacciones.clsPedidos
                    dtIgvArticulo = New DataTable("Fl_igv")
                    dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvArticulo(row("CODIGO").ToString())
                    If dtIgvArticulo.Rows.Count() <> 0 Then
                        If chkSinIGV.Checked = False Then
                            'SI EL ARTICULO NO INCLUYE IGV
                            If dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = True Then
                                If cboTipoDoc.Text = "NC" Then

                                Else

                                End If

                            ElseIf dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = False Then
                                If cboTipoDoc.Text = "NC" Then
                                    Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaIgv = po_TasaIgv / 100
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL")) + (CDbl(row("PRECIO_INICIAL")) * (CDbl(Igv) / 100))
                                    If chkSinIGV.Checked = False Then
                                        Monto = Monto / (1 + (Igv / 100))
                                    End If
                                    If chkSinIGV.Checked Then
                                        Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
                                    Else
                                        Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
                                    End If
                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = -Math.Abs(CDbl(Monto))
                                    row("VALOR_VENTA") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO")))
                                    row("IMP_DESC_01") = Math.Abs(CDbl((row("PREC_UNITARIO") * row("%DESC.ART_1") / 100) * row("CANTIDAD")))
                                    row("IMP_DESC_02") = Math.Abs(CDbl(((row("PREC_UNITARIO") - (row("PREC_UNITARIO") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD")))
                                    row("PRECIO_IGV") = -Math.Abs(CDbl(row("PRECIO_INICIAL")))
                                    row("IGV_ART") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv))
                                    row("IGV_ART_US") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text))
                                    row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()
                                Else
                                    Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaIgv = po_TasaIgv / 100
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL")) + (CDbl(row("PRECIO_INICIAL")) * (CDbl(Igv) / 100))
                                    If chkSinIGV.Checked = False Then
                                        Monto = Monto / (1 + (Igv / 100))
                                    End If
                                    If chkSinIGV.Checked Then
                                        Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
                                    Else
                                        Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
                                    End If
                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = CDbl(Monto)
                                    row("VALOR_VENTA") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO"))
                                    row("IMP_DESC_01") = CDbl((row("PREC_UNITARIO") * row("%DESC.ART_1") / 100) * row("CANTIDAD"))
                                    row("IMP_DESC_02") = CDbl(((row("PREC_UNITARIO") - (row("PREC_UNITARIO") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD"))
                                    row("PRECIO_IGV") = row("PRECIO_INICIAL")
                                    row("IGV_ART") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv)
                                    row("IGV_ART_US") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text)
                                    row("IMPORTE") = CDbl(row("PRECIO_IGV") * row("CANTIDAD"))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()
                                End If
                            End If

                        Else
                            'SI EL ARTICULO NO INCLUYE IGV
                            If dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = True Then
                                If cboTipoDoc.Text = "NC" Then

                                Else

                                End If
                            ElseIf dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = False Then
                                If cboTipoDoc.Text = "NC" Then
                                    Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaIgv = po_TasaIgv / 100
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL"))
                                    If chkSinIGV.Checked = False Then
                                        Monto = Monto / (1 + (Igv / 100))
                                    End If
                                    If chkSinIGV.Checked Then
                                        Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
                                    Else
                                        Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
                                    End If
                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = Math.Abs(CDbl(row("PRECIO_INICIAL")))
                                    row("VALOR_VENTA") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO")))
                                    row("IMP_DESC_01") = Math.Abs(CDbl((row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100) * row("CANTIDAD")))
                                    row("IMP_DESC_02") = Math.Abs(CDbl(((row("PRECIO_INICIAL") - (row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD")))
                                    row("PRECIO_IGV") = -Math.Abs(CDbl(Monto))
                                    row("IGV_ART") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv))
                                    row("IGV_ART_US") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text))
                                    row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))
                                    row("CANTIDAD") = -Math.Abs(CDbl(row("CANTIDAD")))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()
                                Else
                                    Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaIgv = po_TasaIgv / 100
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL"))
                                    If chkSinIGV.Checked = False Then
                                        Monto = Monto / (1 + (Igv / 100))
                                    End If
                                    If chkSinIGV.Checked Then
                                        Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
                                    Else
                                        Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
                                    End If
                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = row("PRECIO_INICIAL")
                                    row("VALOR_VENTA") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO"))
                                    row("IMP_DESC_01") = CDbl((row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100) * row("CANTIDAD"))
                                    row("IMP_DESC_02") = CDbl(((row("PRECIO_INICIAL") - (row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD"))
                                    row("PRECIO_IGV") = Monto
                                    row("IGV_ART") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv)
                                    row("IGV_ART_US") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text)
                                    row("IMPORTE") = CDbl(row("PRECIO_IGV") * row("CANTIDAD"))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()
                                End If
                            End If
                        End If
                    End If
                Next
                Mostrando_Totales_Generales()
            Else
                txtBruto.Text = "0.00"
                txtDescuentos.Text = "0.00"
                txtvalorVenta.Text = "0.00"
                txtIgv.Text = "0.00"
                txtPrecioVenta.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticulo
            frmArticulo.AlmacenOrigen = txtAlmacen.Text
            ' frmArticulo.ValidacionLotes = DatosLotes()
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
                row("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
                row("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD")
                row("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION")
                row("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
                row("PREC_UNITARIO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PREC_UNITARIO")
                row("%DESC.ART_1") = frmArticulo.dtdetalleArticulo.Rows(0).Item("%DESC.ART_1")
                row("%DESC.ART_2") = frmArticulo.dtdetalleArticulo.Rows(0).Item("%DESC.ART_2")
                row("VALOR_VENTA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("VALOR_VENTA")

                row("IMP_DESC_01") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IMP_DESC_01")
                row("IMP_DESC_02") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IMP_DESC_02")
                row("PRECIO_IGV") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRECIO_IGV")
                row("IGV_ART") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_ART")
                row("IGV_ART_US") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_ART_US")
                row("IMPORTE") = 0
                row("PRECIO_INICIAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRECIO_INICIAL").ToString
                row("TOTAL_INICIAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TOTAL_INICIAL").ToString
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                'CALCULANDO TOTALES GENERALES
                Calcular_Totales()
                Fl_close = False
            Else
                Fl_close = True
            End If
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If GbCabecera.Enabled = True Then
            'If ValidacionesGenerales() = False Then Exit Sub
            GbCabecera.Enabled = False
        End If
        If dgvDetalle.Rows.Count() = NumeroItemsDocumentos() Then
            MsgBox("Ya alcanzo el Numero maximo de Lineas permitido para este tipo de Documento.", MsgBoxStyle.Information)
            Exit Sub
        End If
        edicion = False
        AgregandoArticulos()
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_Click(sender, e)
        End If
    End Sub

    Private Sub ModificandoArticulos()
        Try
            GbCabecera.Enabled = False
            Dim frmArticulo As New FrmAsignarArticulo
            frmArticulo.AlmacenOrigen = txtAlmacen.Text
            Dim lote As String = dgvDetalle.Item(5, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim CodigoArticulo As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
            Dim Saldo As String = String.Empty
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo._LOTE = lote
            If lote = String.Empty Then
                ' frmArticulo.ValidacionLotes = DatosLotes()
            Else
                ' frmArticulo.ValidacionLotes = DatosLotes(lote, CodigoArticulo)
            End If

            frmArticulo.Flag_Modo_Edicion = True
            Dim Codigo As String = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            'Enviando datos seleccioandos a Modificar
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
                row("ITEM") = item("ITEM")
                row("CODIGO") = item("CODIGO")
                row("CANTIDAD") = Math.Abs(item("CANTIDAD"))
                row("UNIDAD") = item("UNIDAD")
                row("DESCRIPCION") = item("DESCRIPCION")
                row("LOTE") = item("LOTE")
                row("PREC_UNITARIO") = item("PREC_UNITARIO")
                row("%DESC.ART_1") = item("%DESC.ART_1")
                row("%DESC.ART_2") = item("%DESC.ART_2")
                row("VALOR_VENTA") = item("VALOR_VENTA")

                row("IMP_DESC_01") = item("IMP_DESC_01")
                row("IMP_DESC_02") = item("IMP_DESC_02")
                row("PRECIO_IGV") = item("PRECIO_IGV")
                row("IGV_ART") = item("IGV_ART")
                row("IGV_ART_US") = item("IGV_ART_US")
                row("PRECIO_INICIAL") = item("PRECIO_INICIAL")
                row("TOTAL_INICIAL") = item("TOTAL_INICIAL").ToString
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                frmArticulo.dtdetalleArticulo.AcceptChanges()
            Next
            frmArticulo.ShowDialog()
            If frmArticulo.fl_close = False Then
                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                        dtdetalleArticuloPrincipal.BeginInit()
                        item("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
                        item("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
                        item("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD")
                        item("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION")
                        item("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
                        item("PREC_UNITARIO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PREC_UNITARIO")
                        item("%DESC.ART_1") = frmArticulo.dtdetalleArticulo.Rows(0).Item("%DESC.ART_1")
                        item("%DESC.ART_2") = frmArticulo.dtdetalleArticulo.Rows(0).Item("%DESC.ART_2")
                        item("VALOR_VENTA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("VALOR_VENTA")

                        item("IMP_DESC_01") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IMP_DESC_01")
                        item("IMP_DESC_02") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IMP_DESC_02")
                        item("PRECIO_IGV") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRECIO_IGV")
                        item("IGV_ART") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_ART")
                        item("IGV_ART_US") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_ART_US")
                        item("IMPORTE") = 0
                        item("PRECIO_INICIAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRECIO_INICIAL").ToString
                        item("TOTAL_INICIAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TOTAL_INICIAL").ToString
                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                        Calcular_Totales()
                    Next
                End If
            End If
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub ModificandoArticulos()
    '    Try
    '        If MsgBox("¿Desea modificar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Aviso") = MsgBoxResult.Yes Then
    '            Dim frmArticulo As New FrmAsignarArticuloS
    '            frmArticulo.AlmacenOrigen = txtAlmacen.Text
    '            frmArticulo.GenerarColummnaDataTable()
    '            frmArticulo.Flag_Modo_Edicion = True
    '            Dim Codigo As String = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
    '            'Enviando datos seleccioandos a Modificar
    '            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
    '                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
    '                row("ITEM") = item("ITEM")
    '                row("CODIGO") = item("CODIGO")
    '                row("CANTIDAD") = item("CANTIDAD")
    '                row("UNIDAD") = item("UNIDAD")
    '                row("DESCRIPCION") = item("DESCRIPCION")
    '                row("LOTE") = item("LOTE")
    '                row("PREC_UNITARIO") = item("PREC_UNITARIO")
    '                row("%DESC.ART_1") = item("%DESC.ART_1")
    '                row("%DESC.ART_2") = item("%DESC.ART_2")
    '                row("VALOR_VENTA") = item("VALOR_VENTA")
    '                frmArticulo.dtdetalleArticulo.Rows.Add(row)
    '                frmArticulo.dtdetalleArticulo.AcceptChanges()
    '            Next
    '            frmArticulo.ShowDialog()
    '            If frmArticulo.fl_close = False Then
    '                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
    '                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
    '                        dtdetalleArticuloPrincipal.BeginInit()
    '                        item("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
    '                        item("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
    '                        item("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD")
    '                        item("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION")
    '                        item("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
    '                        item("PREC_UNITARIO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PREC_UNITARIO")
    '                        item("%DESC.ART_1") = frmArticulo.dtdetalleArticulo.Rows(0).Item("%DESC.ART_1")
    '                        item("%DESC.ART_2") = frmArticulo.dtdetalleArticulo.Rows(0).Item("%DESC.ART_2")
    '                        item("VALOR_VENTA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("VALOR_VENTA")
    '                        dtdetalleArticuloPrincipal.EndInit()
    '                        dtdetalleArticuloPrincipal.AcceptChanges()
    '                    Next
    '                End If
    '            End If
    '            frmArticulo.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        edicion = True
        ModificandoArticulos()
    End Sub

    Private Sub ActualizandoCorrelativoItem()
        'Actualizando Numeracion
        Dim Index As Integer = 0
        Dim fila As Integer = 0
        Dim ident As String = String.Empty
        Dim lista As New List(Of String)
        For Each rows As DataRow In dtdetalleArticuloPrincipal.Rows
            ident = rows("ITEM")
            If lista.Contains(ident) = False Then
                lista.Add(ident)
                Continue For
            End If
        Next
        For i As Integer = 0 To lista.Count() - 1
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & lista(i))
                dtdetalleArticuloPrincipal.BeginInit()
                item("ITEM") = i + 1
                dtdetalleArticuloPrincipal.EndInit()
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next
        Next
    End Sub

    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    item.Delete()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                ActualizandoCorrelativoItem()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
    End Sub

    Private Sub Ayuda_TipoDocPuntoVenta()
        Try
            cVenta = New ClsAyudas
            dtTipoDoc = New DataTable
            If txtPtoVenta.Text = String.Empty Then Exit Sub
            dtTipoDoc = cVenta.get_Tipo_Doc_Pto_Venta(txtPtoVenta.Text.Trim)
            cboTipoDoc.DataSource = dtTipoDoc
            cboTipoDoc.ValueMember = dtTipoDoc.Columns(0).ToString
            cboTipoDoc.DisplayMember = dtTipoDoc.Columns(1).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_DireccionEntrega()
        Try
            cConsultabL = New ClsConsultas
            dtDirCliente = New DataTable

            If txtCodCliente.Text = String.Empty Then Exit Sub
            dtDirCliente = cConsultabL.get_Direcciones_Cliente(txtCodCliente.Text)
            cbDirEntrega.DataSource = dtDirCliente
            cbDirEntrega.ValueMember = dtDirCliente.Columns(1).ToString
            cbDirEntrega.DisplayMember = dtDirCliente.Columns(1).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_SerieGuiaPuntoVenta()
        Try
            cVenta = New ClsAyudas
            dtSerieGuia = New DataTable
            If txtPtoVenta.Text = String.Empty Then Exit Sub
            dtSerieGuia = cVenta.get_Serie_Guia_Pto_Venta(txtPtoVenta.Text.Trim)
            cbSerieGuia.DataSource = dtSerieGuia
            cbSerieGuia.ValueMember = dtSerieGuia.Columns(0).ToString
            cbSerieGuia.DisplayMember = dtSerieGuia.Columns(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        If dgvDocumentosPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay pedidos por facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim NumeroPedido As String = String.Empty
        Dim Estado As String = String.Empty
        Dim Estatus As String = String.Empty

        NumeroPedido = dgvDocumentosPedidos.Rows(dgvDocumentosPedidos.CurrentRow.Index).Cells(0).Value
        Estado = dgvDocumentosPedidos.Rows(dgvDocumentosPedidos.CurrentRow.Index).Cells(8).Value
        Estatus = dgvDocumentosPedidos.Rows(dgvDocumentosPedidos.CurrentRow.Index).Cells(9).Value

        If Estado = "ANULADO" Then
            MessageBox.Show("El pedido se encuentra anulado, no puede Facturarse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Estado = "EMITIDO" Then
            MessageBox.Show("El Pedido no ha sido aprobado, no puede Facturarse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Estatus = "F" Then
            MessageBox.Show("El Pedido ya se encuentra Facturado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea facturar el Pedido " & NumeroPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Estado = "AUTORIZADO" Then
                Flag_TipoDocumento = "F"
                MostrarModoConsultar(NumeroPedido)
                dgvDocumentosPedidos.Visible = False
                PnlDatosGuia.Visible = True
                GbCabecera.Enabled = False
                gbdetalle.Enabled = True
                gbOpciones.Enabled = False
                txtNumeroPedido.Visible = True
                txtNumeroPedido.Text = String.Empty
                txtNumeroPedido.Text = NumeroPedido
                lblNumeroPedido.Visible = True
                Call Botonera_Estado_Cambiar(True)
            End If
        End If
    End Sub

    Private Sub Ayuda_Transportistas()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_CARRIER"
            frm.CadenaConsulta = sql
            frm.Titulo = "Transportistas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtCodTrans.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtNomTrans.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtCodTrans_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCodTrans.MouseDoubleClick
        Ayuda_Transportistas()
    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        If dgvDocumentosPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay pedidos por aprobar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim STRPedido As String = String.Empty
        Dim STREstado As String = String.Empty
        STRPedido = dgvDocumentosPedidos.Rows(dgvDocumentosPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgvDocumentosPedidos.Rows(dgvDocumentosPedidos.CurrentRow.Index).Cells(8).Value

        If STREstado = "AUTORIZADO" Then
            MessageBox.Show("El pedido ya se encuentra autorizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "ANULADO" Then
            MessageBox.Show("El pedido se encuentra anulado, no puede aprobarse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea Aprobar el pedido " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If STREstado = "EMITIDO" Then
                cProcesosbL = New ClsProcesos
                If cProcesosbL.Actualiza_Status_Pedido(STRPedido, "AUTORIZADO") = True Then
                    MessageBox.Show("Pedido Autorizado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                dgvDocumentosPedidos.Visible = True
                'Mostrando todos los Datos Actuales
                DocumentosPedidos()
                Botonera_Estado_Cambiar(False)
            End If
        End If
    End Sub

    Private Sub chkSinIGV_CheckedChanged(sender As Object, e As EventArgs) Handles chkSinIGV.CheckedChanged
        If chkSinIGV.Checked = True Then
            chkSinIGV.ForeColor = Drawing.Color.Red
        Else
            chkSinIGV.ForeColor = Drawing.Color.Black
        End If
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        Calcular_Totales()
    End Sub

    Private Sub TipoDocumento()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "ALM_SP_S_WAREHOUSE_TIPO_DOCUMENTO"
        frm.CadenaConsulta = sql
        frm.Titulo = "Tipo de Documentos de Referencias"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txttipoDocRef.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
        End If
        frm.Close()
        txtSerieDocRef.Focus()
    End Sub

    Private Sub txttipoDocRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txttipoDocRef.MouseDoubleClick
        TipoDocumento()
    End Sub
 

    Private Sub checkSinGuia_CheckedChanged(sender As Object, e As EventArgs) Handles checkSinGuia.CheckedChanged
        If checkSinGuia.Checked = True Then
            txtCodTrans.Text = String.Empty
            txtNomTrans.Text = String.Empty
            txtGlosaDoc.Text = String.Empty
            txtCodTrans.Enabled = False
            txtGlosaDoc.Enabled = False
            chkSinIGV.ForeColor = Drawing.Color.Red
        Else
            txtCodTrans.Enabled = True
            txtGlosaDoc.Enabled = True
            chkSinIGV.ForeColor = Drawing.Color.Black
        End If
    End Sub

    Private Sub cboTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDoc.SelectedIndexChanged
        If cboTipoDoc.DataSource Is Nothing Then Exit Sub
        cboSerieDoc.Text = cboTipoDoc.SelectedValue.ToString
        If cboTipoDoc.Text = "FT" Then
            checkSinGuia.Checked = False
            checkSinGuia.Enabled = True
        ElseIf cboTipoDoc.Text = "NC" Then
            checkSinGuia.Checked = True
            checkSinGuia.Enabled = False
        ElseIf cboTipoDoc.Text = "ND" Then
            checkSinGuia.Checked = True
            checkSinGuia.Enabled = False
        End If
    End Sub

    Private Sub cboTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoDoc.SelectionChangeCommitted
        If cboTipoDoc.SelectedIndex <> -1 Then
            SerieDocumentoPuntoVenta()
        End If
    End Sub
End Class