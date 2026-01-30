Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas

Public Class FrmFacturacion

    Dim clsBuscarBl As ClsBuscar
    Private cProcesosbL As ClsProcesos
    Private cConsultabL As ClsConsultas
    ' Private clsFacturaBl As ClsOperaciones.RECEIVABLE
    Private clsFacturaBl As ClsNegocio.RECEIVABLE

    Private dtDocumentoFactura As DataTable
    Public CodigoVendedor As String = String.Empty
    Public DescripcionVendedor As String = String.Empty

    Dim Modo_consultar As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim STRordenCliente As String = String.Empty
    Dim edicion As Boolean = False
    Public dtdetalleArticuloPrincipal As DataTable
    Dim Fl_close As Boolean = False
    Dim Fl_NC_REF As Boolean = False

    Dim NumeracionGuiaRemision, NumeracionFacturacion, NumeracionFacturaNotac, NumeracionFacturaNotaD, NumeracionFacturaCP As String
    Dim Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT As String

    Dim Flag_ComprobPerc As Boolean = False
    Dim Flag_Detraccion As Boolean = False

    Dim indicadorG As Boolean = True

    Dim TipoNumeracion As String
    Dim TipoNumeracionCp As String
    Dim ListaDocCliente As List(Of String)
    Dim NumerosDocClientes As String
    Dim PorcentajePercepcion, PorcentajeDetraccion As String

    Dim cabeceraBL As ClsOperaciones.RECEIVABLE
    Dim cabeceraBE As ClsEntidades.RECEIVABLE
    Dim carteraBE As ClsEntidades.CUSTOMER_BALANCE
    Dim detalle As ClsEntidades.RECEIVABLE_LINE
    Dim ls_det As List(Of ClsEntidades.RECEIVABLE_LINE)
    Dim ls_det_alm As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
    Dim ListaGuia_Alm As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
    Dim ListaGuiaCab_alm As List(Of ClsEntidades.WAREHOUSE_TRANS)
    Dim alm_cabBE As ClsEntidades.WAREHOUSE_TRANS
    Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
    Dim numeracionBE As ClsEntidades.NUMBER_DOCUMENT


    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtVerificar As DataTable

    Dim cVenta As ClsAyudas
    Dim dtSerieDoc As DataTable
    Dim dtTipoDoc As DataTable
    Dim dtSerieGuia As DataTable
    Dim dtDirCliente As DataTable
    Dim dtPedido As DataTable
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen
    Dim NumeroLineas As Integer
    Dim STRAccion As String = String.Empty

    Dim clsIgvArticuloBL As ClsTransacciones.clsPedidos
    Dim dtIgvArticulo As DataTable

    Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE
    Dim clsFacturaDetBl As LibCobranzas.ClsOperaciones.RECEIVABLE_LIST
    Dim dtCabeceraFact As DataTable
    Dim dtDetalleFact As DataTable

    Dim po_TasaIgv As Double
    Dim Igv As Double = 0.0


    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "CODIGO"
        cboMoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub

    Private Sub DocumentosFactura()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtDocumentoFactura = New DataTable
            dtDocumentoFactura = clsFacturaBl.get_DatosGeneralesFacturacion(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                            cboopcionesBusqueda.SelectedIndex, IIf(cboOpcionTipoDoc.SelectedIndex = 0, "", cboOpcionTipoDoc.Text))
            dgvDocumentosFactura.DataSource = Nothing
            If dtDocumentoFactura.Rows.Count() <> 0 Then
                dtv = dtDocumentoFactura.DefaultView
                dgvDocumentosFactura.DataSource = dtv
                dgvDocumentosFactura.Columns(0).Width = 30
                dgvDocumentosFactura.Columns(1).Width = 100
                dgvDocumentosFactura.Columns(2).Width = 75
                dgvDocumentosFactura.Columns(3).Width = 300
                dgvDocumentosFactura.Columns(4).Width = 40
                dgvDocumentosFactura.Columns(6).Width = 80
                dgvDocumentosFactura.Columns(7).Visible = False
                dgvDocumentosFactura.Columns(8).Visible = False
                dgvDocumentosFactura.Columns(9).Visible = False
                dgvDocumentosFactura.Columns(12).Width = 80
                dgvDocumentosFactura.Columns(13).Width = 80
                STRorden = dgvDocumentosFactura.Columns(0).Name & "+" & dgvDocumentosFactura.Columns(1).Name & "+" & dgvDocumentosFactura.Columns(2).Name & "+" & dgvDocumentosFactura.Columns(3).Name
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
                btnImprimir.Enabled = True
            Else
                btnImprimir.Enabled = False
                btnGrabar.Enabled = True
            End If
            btnEliminar.Enabled = False
            btnAnular.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            'btnImprimir.Enabled = False
            lblCantidad.Visible = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnAnular.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            'btnImprimir.Enabled = True
            lblCantidad.Visible = True
        End If
    End Sub

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
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_INICIAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("TOTAL_INICIAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
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
            dgvDocumentosFactura.Visible = False
            pnlFiltros.Visible = False
            gbTipoFacturacion.Visible = True
            gbTipoFacturacion.Enabled = True
            rbFacturaDirecta.Checked = True
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
            GbdetalleDocumento.Visible = False
            gbGenerarCP.Visible = False
            Limpiar()
            GenerarColummnaDataTable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Botonera_Estado_Cambiar(True)
        Nuevo()
    End Sub

    Private Sub MostrarModoConsultar(ByVal DOCUMENT_ID As String, ByVal NUMBER_SERIE As String, ByVal NUMBER_DOCUMENT As String)
        Try
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtCabeceraFact = New DataTable
            dtDetalleFact = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraFact = clsFacturaCabBl.get_CabecearaFacturacion(DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT)
            If dtCabeceraFact.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraFact.Rows.Count() - 1
                    txtPtoVenta.Text = dtCabeceraFact.Rows(i).Item("PLACE_SALES").ToString
                    cboMoneda.SelectedValue = dtCabeceraFact.Rows(i).Item("CURRENCY_ID").ToString
                    txtTipoCambio.Text = dtCabeceraFact.Rows(i).Item("SELL_RATE").ToString
                    dtpFechaFactura.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_DATE").ToString
                    cboSerieDoc.Text = dtCabeceraFact.Rows(i).Item("NUMBER_SERIE").ToString
                    txttipoDocRef.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_REF").ToString
                    txtNumDocRef.Text = dtCabeceraFact.Rows(i).Item("NUMBER_REF").ToString
                    txtSerieDocRef.Text = dtCabeceraFact.Rows(i).Item("SERIE_REF").ToString
                    txtCodCliente.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRucDni.Text = dtCabeceraFact.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtRazonSocial.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtDireccion.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ADDR").ToString
                    txtVendedor.Text = dtCabeceraFact.Rows(i).Item("SALES_REP_ID").ToString
                    txtFormaPago.Text = dtCabeceraFact.Rows(i).Item("TERMS_ID").ToString
                    txtcotizacion.Text = ""
                    txtordenCompra.Text = dtCabeceraFact.Rows(i).Item("NUMBER_ORDER_PUR").ToString
                    txtpedido.Text = ""
                    cboMoneda.SelectedValue = dtCabeceraFact.Rows(i).Item("CURRENCY_ID").ToString
                    cbSerieGuia.SelectedValue = dtCabeceraFact.Rows(i).Item("SERIE_REF").ToString
                    txtCodTrans.Text = ""
                    cboDirEntrega.Text = ""
                    txtdetalledoc.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_ID").ToString()
                    txtdetalleserie.Text = dtCabeceraFact.Rows(i).Item("NUMBER_SERIE").ToString()
                    txtdetallenumero.Text = dtCabeceraFact.Rows(i).Item("NUMBER_DOCUMENT").ToString()
                    txtcodigoCP.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_TYPE_COMP_PER").ToString
                    txtSerieCP.Text = dtCabeceraFact.Rows(i).Item("SERIE_COMP_PER").ToString
                    txtNumeroCP.Text = dtCabeceraFact.Rows(i).Item("NUMBER_COMP_PER").ToString
                    txtGlosa.Text = dtCabeceraFact.Rows(i).Item("COMMENT").ToString
                    If txtdetalledoc.Text = "FT" Then
                        Dim GuiaBl As New ClsBuscar
                        Dim dtDatosGuia As New DataTable
                        dtDatosGuia = GuiaBl.Get_GuiasAsociadas(dtCabeceraFact.Rows(i).Item("WAREHOUSE_ID").ToString, txtdetalleserie.Text & txtdetallenumero.Text)
                        If dtDatosGuia.Rows.Count() <> 0 Then
                            txtdetalleguiadoc.Text = dtDatosGuia.Rows(i).Item("DOCUMENT_ID").ToString()
                            txtdetalleguiaserie.Text = Strings.Left(dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT"), 3)
                            txtdetalleguianumero.Text = Strings.Right(dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT"), dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT").Length() - 3)
                            If Not String.IsNullOrEmpty(dtDatosGuia.Rows(i).Item("INTERFACE").ToString) Then
                                If dtDatosGuia.Rows(i).Item("INTERFACE").ToString = "0" Then
                                    rbunalinea.Checked = True
                                Else
                                    rbunalinea.Checked = False
                                    rbVariaslineas.Checked = True
                                End If
                                txtGlosaGuia.Text = dtDatosGuia.Rows(i).Item("COMMENT").ToString
                            End If
                        End If
                    ElseIf txtdetalledoc.Text = "CP" Then
                        txtcodigoCP.Text = String.Empty
                        txtSerieCP.Text = String.Empty
                        txtNumeroCP.Text = String.Empty
                    End If
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
                        'Mostrando el tipo Doc asociado a Pnto venta
                        Ayuda_TipoDocPuntoVenta()
                        cboTipoDoc.Text = dtCabeceraFact.Rows(0).Item("RECEIVABLE_TYPE").ToString
                        'Mostrando la serie
                        Ayuda_SerieGuiaPuntoVenta()
                        If cboTipoDoc.Text = String.Empty Then Exit Sub
                        SerieDocumentoPuntoVenta()
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
                        cboDirEntrega.DataSource = Nothing
                        cboDirEntrega.Items.Clear()
                        cboDirEntrega.Items.Add(dtDatos.Rows(0).Item("ADDR_DLV").ToString)
                        cboDirEntrega.SelectedIndex = 0
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
                        txtRazonSocial.Text = ""
                        txtRucDni.Text = ""
                        txtDireccion.Text = ""
                    End If
                End If
                '---Mostrando datos del Detalle
                clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsFacturaCabBl.get_DetalleFacturacion(DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT)
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
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        'Mostrando resultados
        MostrarModoConsultar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
        dgvDocumentosFactura.Visible = False
        pnlFiltros.Visible = False
        gbTipoFacturacion.Visible = False
        GbCabecera.Enabled = False
        gbdetalle.Enabled = True
        gbOpciones.Enabled = False
        chkSinIGV.Visible = True
        GbdetalleDocumento.Visible = True
        Call Botonera_Estado_Cambiar(True)
        If Ref_DOCUMENT_ID <> "CP" Then
            cabeceraBL = New ClsOperaciones.RECEIVABLE
            dtVerificar = New DataTable("ComprobanteP")
            dtVerificar = cabeceraBL.get_VerificacionComprobanteP(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
            If dtVerificar.Rows.Count() <> 0 Then
                gbGenerarCP.Visible = False
            Else
                gbGenerarCP.Visible = True
            End If
            Dim Estado As String = String.Empty
            Estado = dgvDocumentosFactura.Item(6, dgvDocumentosFactura.CurrentRow.Index).Value
            If Estado <> "ANULADO" Then
                'Verificando si posee despacho
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtVerificar = New DataTable("Despacho")
                dtVerificar = clsFacturaBl.VerificarDespacho(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
                If dtVerificar.Rows.Count() <> 0 Then
                    gbGenerarDespacho.Visible = False
                Else
                    gbGenerarDespacho.Visible = True
                    lblDespachoNumero.Text = String.Empty
                    lblDespachoNumero.Text = Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & " - " & Ref_NUMBER_DOCUMENT
                End If
            End If
        Else
            gbGenerarCP.Visible = False
            gbGenerarDespacho.Visible = False
        End If
    End Sub

    'NUMERO DE ITEM POR DOCUMENTOS
    Private Function NumeroItemsDocumentos() As Integer
        NumeroLineas = 0
        Try
            clsAlmacenBl = New ClsTransacciones.clsAlmacen
            clsAlmacenBl.Get_ItemDocumentos(cboTipoDoc.Text, cboSerieDoc.Text)
            NumeroLineas = clsAlmacenBl.NUMBER_LINE
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return NumeroLineas
    End Function

    ''GUARDANDO DATOS DE LA FACTURACION

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

    Private Function CodigoNumeroComprobatePercepcion() As Boolean
        Dim estado As Boolean = True
        Try
            Dim frmTipoNum As New FrmTipoNumeracion
            frmTipoNum.Serie = "001"
            frmTipoNum.TipoDocumento = "CP"
            frmTipoNum.Serie = cboSerieDoc.Text
            frmTipoNum.txtTitulo.Text = "COMPROBANTE PERCEPCION"
            frmTipoNum.ShowDialog()
            If frmTipoNum.fl_datos = False Then
                estado = False
                NumeracionFacturaCP = String.Empty
                frmTipoNum.Close()
                Exit Try
            End If
            NumeracionFacturaCP = String.Empty
            TipoNumeracionCp = String.Empty
            NumeracionFacturaCP = frmTipoNum.NumeracionFacturaCP
            TipoNumeracionCp = frmTipoNum.TipoNumeracion
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
                fechaVencimiento = DateAdd(DateInterval.Day, CInt(dtFormaPagoFechaV.Rows(0).Item("Dias")), CDate(dtpFechaFactura.Value.ToString("dd/MM/yyyy")))
            Else
                fechaVencimiento = CDate(dtpFechaFactura.Value.ToString("dd/MM/yyyy"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return fechaVencimiento
    End Function

    Private Function GuardarFacturacion() As Boolean
        Dim indicadorF As Boolean = True
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
                .DOCUMENT_DATE = dtpFechaFactura.Value.ToString("dd/MM/yyyy")
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

                If checkSinGuia.Checked = False Then
                    .DOCUMENT_REF = "GS"
                    .SERIE_REF = cbSerieGuia.Text
                    .NUMBER_REF = Strings.Right(Trim(NumeracionGuiaRemision), 7)
                Else
                    .DOCUMENT_REF = txttipoDocRef.Text
                    .SERIE_REF = txtSerieDocRef.Text
                    If rbFacturaGuiaVenta.Checked Then
                        .NUMBER_REF = "GUIAS"
                    Else
                        .NUMBER_REF = txtNumDocRef.Text
                    End If
                End If
                
                .NUMBER_ORDER = txtpedido.Text
                .CREATE_DATE = Date.Now.ToShortDateString
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
                .LIST_GUIA = txtNumDocRef.Text
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
                If Flag_ComprobPerc = True Then
                    .ISC = CDbl(PorcentajePercepcion)
                Else
                    .ISC = 0
                End If
                If String.IsNullOrEmpty(NumeracionFacturaCP) Then
                    .DOCUMENT_TYPE_COMP_PER = ""
                Else
                    .DOCUMENT_TYPE_COMP_PER = "CP"
                End If
                If String.IsNullOrEmpty(NumeracionFacturaCP) Then
                    .SERIE_COMP_PER = ""
                Else
                    .SERIE_COMP_PER = "001"
                End If
                If String.IsNullOrEmpty(NumeracionFacturaCP) Then
                    .NUMBER_COMP_PER = ""
                Else
                    .NUMBER_COMP_PER = NumeracionFacturaCP.Substring(3)
                End If
                .ESTADO_DESPACHO = ""

                If Flag_Detraccion = True Then
                    .PERCENT_DETRAC = CDbl(PorcentajeDetraccion)
                    .AMOUNT_DETRAC = CDbl(txtPrecioVenta.Text * PorcentajeDetraccion / 100)
                Else
                    .PERCENT_DETRAC = 0
                    .AMOUNT_DETRAC = 0
                End If
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
                    If Flag_ComprobPerc = True Then
                        .ISC = CDbl(PorcentajePercepcion)
                    Else
                        .ISC = 0
                    End If
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
                .DOC_DATE = CDate(dtpFechaFactura.Text).ToShortDateString
                .CADUCATE_DATE = Get_FormaPagoFechaVencimiento()
                .DOCUMENT_REF = txttipoDocRef.Text
                If rbFacturaDirecta.Checked = True Then
                    .NUMBER_REF = txtSerieDocRef.Text & txtNumDocRef.Text
                Else
                    .NUMBER_REF = txtNumDocRef.Text
                End If
                .SALES_ID = txtVendedor.Text.Trim
                .AMOUNT = txtPrecioVenta.Text
                .AMOUNT_BALANCE = 0
                .CURRENCY_ID = cboMoneda.SelectedValue
                .SELL_RATE = CDbl(txtTipoCambio.Text)
                .IS_DR_CR = 0
                .STATUS = "A"
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
                If Flag_Detraccion = True Then
                    .PERCENT_DETRAC = CDbl(PorcentajeDetraccion)
                    .AMOUNT_DETRAC = CDbl(txtPrecioVenta.Text * PorcentajeDetraccion / 100)
                Else
                    .PERCENT_DETRAC = 0
                    .AMOUNT_DETRAC = 0
                End If
            End With
            If rbFacturaDirecta.Checked = True Or rbFacturaExistencias.Checked = True Then
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
                    .DATE_DOCUMENT = CDate(dtpFechaFactura.Value).ToShortDateString
                    .DOC_ID_REF = txttipoDocRef.Text
                    If rbFacturaDirecta.Checked = True Then
                        .NUM_ID_REF = txtSerieDocRef.Text & txtNumDocRef.Text
                    Else
                        .NUM_ID_REF = txtNumDocRef.Text
                    End If
                    .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .CUSTOMER_ID = txtCodCliente.Text
                    .VAT_REGISTRATION = txtRucDni.Text
                    .CUSTOMER_NAME = txtRazonSocial.Text
                    .SALES_TERM = txtFormaPago.Text.Trim
                    .CURRENCY_TYPE = cboMoneda.SelectedValue
                    .CURRENCY_EXCHANGE = CDbl(txtTipoCambio.Text)
                    If rbFacturaExistencias.Checked = True Then
                        .STATUS_GUIA = "S"
                    Else
                        .STATUS_GUIA = "F"
                    End If
                    .TYPE_GUIA = ""
                    .CARRIER_ID = txtCodTrans.Text
                    .CARRIER_NAME = txtNomTrans.Text
                    .CARRIER_ADDR = cboDirEntrega.Text
                    .AMOUNT = Math.Abs(CDbl(txtPrecioVenta.Text))
                    .COMMENT = txtGlosa.Text
                    .WAREHOUSE_REF = ""
                    .NUMBER_PURCHASE = ""
                    .INTERFACEE = 0
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
            End If

            ''GUARDANDO DATOS DE LA FACTURACION
            If cabeceraBL.GuardarFactura(cabeceraBE, ls_det, carteraBE, alm_cabBE, ls_det_alm, TipoNumeracion, cboTipoDoc.Text, IIf(rbFacturaGuiaVenta.Checked = True, True, False), NumerosDocClientes) = False Then
                MsgBox("Hubo un Error en la Generacion de la Factura", MsgBoxStyle.Critical)
                indicadorF = False
                Exit Try
            End If
            ''GUARDANDO DATOS DEL COMPROBANTE DE PERCEPCION
            If Flag_ComprobPerc = True Then
                cabeceraBL = New ClsOperaciones.RECEIVABLE
                Dim MontoPercepcion As Double = 0.0
                MontoPercepcion = (txtPrecioVenta.Text * CDbl(PorcentajePercepcion) / 100)
                If cboTipoDoc.Text = "FT" Then
                    If cabeceraBL.GuardarComprobantePercepcion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturacion, _
                                                               NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion) = False Then
                        MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                        indicadorF = False
                        Exit Try
                    End If
                ElseIf cboTipoDoc.Text = "NC" Then
                    If cabeceraBL.GuardarComprobantePercepcion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturaNotac, _
                                                               NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion) = False Then
                        MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                        indicadorF = False
                        Exit Try
                    End If
                ElseIf cboTipoDoc.Text = "ND" Then
                    If cabeceraBL.GuardarComprobantePercepcion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturaNotaD, _
                                                               NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion) = False Then
                        MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                        indicadorF = False
                        Exit Try
                    End If
                End If
            End If
            If rbFacturaDirecta.Checked = True Then
                ''GUARDANDO DATOS DE LA  GUIA DE SALIDA
                If checkSinGuia.Checked = False Then
                    alm_cabBE = New ClsEntidades.WAREHOUSE_TRANS
                    ls_det_alm = New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
                    With alm_cabBE
                        .WAREHOUSE_ID = txtAlmacen.Text
                        .DOCUMENT_ID = "GS"
                        .NUMBER_DOCUMENT = NumeracionGuiaRemision
                        .DATE_DOCUMENT = CDate(dtpFechaFactura.Value).ToShortDateString
                        .TYPE_TRANS = "S"
                        .TRANS_ID = "GF"
                        .DOC_ID_REF = cboTipoDoc.Text
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
                        .CARRIER_ADDR = cboDirEntrega.Text
                        .AMOUNT = CDbl(txtPrecioVenta.Text.Trim)
                        .COMMENT = txtGlosaGuia.Text
                        .WAREHOUSE_REF = ""
                        .NUMBER_PURCHASE = ""
                        If rbunalinea.Checked Then
                            .INTERFACEE = 0
                        ElseIf rbVariaslineas.Checked Then
                            .INTERFACEE = 1
                        End If
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
                        ls_det_alm.Add(alm_detBE)
                    Next
                    ''GUARDANDO DATOS DE LA  GUIA DE SALIDA
                    cabeceraBL = New ClsOperaciones.RECEIVABLE
                    If cabeceraBL.GuardarGuiaSalida(alm_cabBE, ls_det_alm, TipoNumeracion) = False Then
                        MsgBox("Hubo un error en la Generacion de la Guia", MsgBoxStyle.Critical)
                        indicadorG = False
                        Exit Try
                    End If
                End If
            End If

            Dim msj As String = String.Empty
            If cboTipoDoc.Text = "FT" Then
                msj = "Nueva Factura Generada Correctamente," & vbCrLf & " Nro Documento: FT- " & cboSerieDoc.Text & NumeracionFacturacion
                MsgBox(msj, MsgBoxStyle.Information)
            ElseIf cboTipoDoc.Text = "NC" Then
                msj = "Nueva Nota de Credito Generado Correctamente," & vbCrLf & " Nro Documento: NC- " & cboSerieDoc.Text & NumeracionFacturaNotac
                MsgBox(msj, MsgBoxStyle.Information)
            ElseIf cboTipoDoc.Text = "ND" Then
                msj = "Nueva Nota de Debito Generado Correctamente," & vbCrLf & " Nro Documento: ND- " & cboSerieDoc.Text & NumeracionFacturaNotaD
                MsgBox(msj, MsgBoxStyle.Information)
            End If
            If rbFacturaDirecta.Checked = True Then
                If checkSinGuia.Checked = False Then
                    If indicadorG = True Then
                        msj = String.Empty
                        msj = "Nueva Guia de Salida Generado Correctamente," & vbCrLf & " Nro Documento: GS-" & NumeracionGuiaRemision
                        MsgBox(msj, MsgBoxStyle.Information)
                    End If
                End If
            End If
            If Flag_ComprobPerc = True Then
                msj = String.Empty
                msj = "Nuevo Comprobante de Percepcion Generado Correctamente," & vbCrLf & " Nro Documento: CP-" & NumeracionFacturaCP
                MsgBox(msj, MsgBoxStyle.Information)
            End If

            If Windows.Forms.MessageBox.Show("Se procedera a la Impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If cboTipoDoc.Text = "FT" Then
                    imprimirFacturacion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturacion, cboMoneda.SelectedValue.ToString, txtIgv.Text, txtPrecioVenta.Text)
                ElseIf cboTipoDoc.Text = "NC" Then
                    imprimirFacturacion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturaNotac, cboMoneda.SelectedValue.ToString, txtIgv.Text, txtPrecioVenta.Text)
                ElseIf cboTipoDoc.Text = "ND" Then
                    imprimirFacturacion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturaNotaD, cboMoneda.SelectedValue.ToString, txtIgv.Text, txtPrecioVenta.Text)
                End If
                If rbFacturaDirecta.Checked = True Then
                    If checkSinGuia.Checked = False Then
                        If indicadorG = True Then
                            imprimirGuiaRemision(txtAlmacen.Text, "GS", NumeracionGuiaRemision)
                        End If
                    End If
                End If
                If Flag_ComprobPerc = True Then
                    imprimirComprobantePercepcion("CP", Strings.Left(NumeracionFacturaCP, 3), Strings.Right(NumeracionFacturaCP, NumeracionFacturaCP.Length() - 3))
                End If
            End If
        Catch ex As Exception
            indicadorF = False
            MsgBox(ex.Message)
        End Try
        Return indicadorF
    End Function

    Private Sub Limpiar()
        txtPtoVenta.Clear()
        txtAlmacen.Clear()
        dtpFechaFactura.Value = Now
        txtCodCliente.Clear()
        txtRucDni.Clear()
        txtRazonSocial.Clear()
        txtDireccion.Clear()
        txtVendedor.Clear()
        txtFormaPago.Clear()
        txtGlosa.Clear()
        chkSinIGV.Checked = True
        txtvalorVenta.Text = "0.00"
        txtIgv.Text = "0.00"
        txtPrecioVenta.Text = "0.00"
        txtBruto.Text = "0.00"
        txtDescuentos.Text = "0.00"
        lblVendedor.Text = String.Empty
        lblAlmacen.Text = String.Empty
        lblFormaPago.Text = String.Empty
        lblPtoVenta.Text = String.Empty
        cboTipoDoc.DataSource = Nothing
        cboSerieDoc.DataSource = Nothing
        txtNumDocRef.Text = String.Empty
        cbSerieGuia.DataSource = Nothing
        txtCodTrans.Text = String.Empty
        txtGlosa.Text = String.Empty
        txtGlosaGuia.Text = String.Empty
        txtpedido.Text = String.Empty
        cboDirEntrega.DataSource = Nothing
        checkSinGuia.Checked = False
        txttipoDocRef.Text = String.Empty
        txtSerieDocRef.Text = String.Empty
        txtNumDocRef.Text = String.Empty
        lbltipoDocRef.Text = String.Empty
        cboDirEntrega.Items.Clear()
        txtordenCompra.Text = String.Empty
        txtdetalledoc.Text = String.Empty
        txtdetalleserie.Text = String.Empty
        txtdetallenumero.Text = String.Empty
        txtdetalleguiadoc.Text = String.Empty
        txtdetalleguiaserie.Text = String.Empty
        txtdetalleguianumero.Text = String.Empty
        txtSerieCP.Text = String.Empty
        txtNumeroCP.Text = String.Empty
        txtcodigoCP.Text = String.Empty
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        'Validaciones Generales
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        If ValidacionesGenerales() = False Then Exit Sub
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                If dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO") = 0 Then
                    MessageBox.Show("Falta ingresar el Precio a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next
        End If
        If cboTipoDoc.Text = "FT" Then
            If CodigoNumeracionFacturacion() = False Then
                MsgBox("Es necesario una Numeracion para la Factura", MsgBoxStyle.Information)
                Exit Sub
            End If
            If rbFacturaDirecta.Checked = True Then
                If checkSinGuia.Checked = False Then
                    If CodigoNumeracionGuiaRemision() = False Then
                        MsgBox("Es necesario una Numeracion para la Guia Remision.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
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
        '---Comprbante de Percepcion
        If Windows.Forms.MessageBox.Show("¿Desea Generar Comprobante de Percepcion.?", "Comprobante Percepcion", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PorcentajePercepcion = String.Empty
            PorcentajePercepcion = InputBox("Introduzca el porcentaje del Comprobante de Percepcion.", "Dato de Porcentaje de Percepcion")
            While PorcentajePercepcion = "" Or PorcentajePercepcion <> ""
                If IsNumeric(PorcentajePercepcion) = False Then
                    MsgBox("Usted eligio generar Comprobante de Percepcion," & vbCrLf & " es necesario ingresar un porcentaje.", MsgBoxStyle.Information, "Sistemas")
                    PorcentajePercepcion = String.Empty
                    PorcentajePercepcion = InputBox("Introduzca el porcentaje del Comprobante de Percepcion.", "Dato de Porcentaje de Percepcion")
                    Continue While
                Else
                    Exit While
                End If
            End While
            Flag_ComprobPerc = True
            If CodigoNumeroComprobatePercepcion() = False Then
                While NumeracionFacturaCP = ""
                    MsgBox("Usted eligio generar Comprobante de Percepcion," & vbCrLf & " es necesario escoger un Tipo de Numeracion.", MsgBoxStyle.Information)
                    If CodigoNumeroComprobatePercepcion() = False Then
                        Continue While
                    Else
                        Exit While
                    End If
                End While
            End If
        Else
            PorcentajePercepcion = String.Empty
            Flag_ComprobPerc = False
            NumeracionFacturaCP = String.Empty
        End If
        '-------Detraccion 
        If Windows.Forms.MessageBox.Show("¿Documento Sujeto a Detraccion.?", "Detraccion", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PorcentajeDetraccion = String.Empty
            PorcentajeDetraccion = InputBox("Introduzca el porcentaje de la Detraccion.", "Dato de Porcentaje de la Detraccion")
            While PorcentajeDetraccion = "" Or PorcentajeDetraccion <> ""
                If IsNumeric(PorcentajeDetraccion) = False Then
                    MsgBox("Usted eligio ingresar la Detraccion," & vbCrLf & " es necesario ingresar un porcentaje.", MsgBoxStyle.Information, "Sistemas")
                    PorcentajeDetraccion = String.Empty
                    PorcentajeDetraccion = InputBox("Introduzca el porcentaje de la Detraccion.", "Dato de Porcentaje de la Detraccion")
                    Continue While
                Else
                    Exit While
                End If
            End While
            Flag_Detraccion = True
        Else
            PorcentajeDetraccion = String.Empty
            Flag_Detraccion = False
        End If
        Me.Cursor = Cursors.WaitCursor
        If GuardarFacturacion() = True Then
            'dgvDocumentosFactura.Visible = True
            'pnlFiltros.Visible = True
            'Botonera_Estado_Cambiar(False)
            'DocumentosFactura()
            Nuevo()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Function EliminarFacturas(ByVal _USER As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                ByVal _NUMBER_DOCUMENT As String, Optional ByVal ComprobanteP As String = "", Optional ByVal _ALMACEN As String = "") As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If ComprobanteP = String.Empty Then
                clsFacturaBl.EliminacionFacturacion(_USER, _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, _ALMACEN)
            Else
                clsFacturaBl.EliminacionFacturacionComprobanteP(_USER, _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Dim Store As String = String.Empty
        Dim msj As String = String.Empty
        Dim Usuario As String = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        If MessageBox.Show("¿Desea Eliminar el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            'Verificando Cancelacion
            Store = "FACT_SP_S_R_VERIFICAR_CANCEL"
            If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                msj = String.Empty
                msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Cancelacion , no se puede Eliminar."
                MsgBox(msj, MsgBoxStyle.Information)
                Exit Sub
            Else
                'Verificando si posee Letra
                Store = String.Empty
                Store = "FACT_SP_S_R_VERIFICAR_LETRA"
                If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                    msj = String.Empty
                    msj = "   EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Letra , no se puede Eliminar."
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                Else
                    If Ref_DOCUMENT_ID <> "CP" Then
                        'ELIMINACION Factura 
                        Usuario = LibComunVar.ClsVarComun.USUARIO
                        clsFacturaBl = New ClsNegocio.RECEIVABLE
                        dtDetalleFact = New DataTable("Punto_Venta")
                        Dim PuntoVenta As String = dgvDocumentosFactura.Item(0, dgvDocumentosFactura.CurrentRow.Index).Value
                        Dim WareHouse As String = String.Empty
                        If String.IsNullOrEmpty(PuntoVenta.ToString) Then
                            MsgBox("El documento no posee un Punto de Venta Asociado", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                        dtDetalleFact = clsFacturaBl.Get_ManualPuntoVenta(PuntoVenta)
                        If dtDetalleFact.Rows.Count() <> 0 Then
                            WareHouse = dtDetalleFact.Rows(0).Item(2).ToString
                        Else
                            MsgBox("No existe Almacen en el Punto de venta", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                        If EliminarFacturas(Usuario, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "", WareHouse) = False Then
                            MsgBox("Hubo un error, no se completo el Proceso de Eliminacion", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        msj = String.Empty
                        msj = "Documento Eliminado Correctamente." & vbCrLf & " Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                        MsgBox(msj, MsgBoxStyle.Information)
                        Me.Cursor = Cursors.Default
                        DocumentosFactura()
                    Else
                        'ELIMIANCION  Cp 
                        Usuario = LibComunVar.ClsVarComun.USUARIO
                        If EliminarFacturas(Usuario, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "CP") = False Then
                            MsgBox("Hubo un error, no se completo el Proceso de Anulacion", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        msj = String.Empty
                        msj = "Documento Eliminado Correctamente." & vbCrLf & " Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                        MsgBox(msj, MsgBoxStyle.Information)
                        Me.Cursor = Cursors.Default
                        DocumentosFactura()
                    End If
                End If
            End If
        End If
    End Sub

    Private Function VerificarDocumentos(ByVal _NombreStore As String, ByVal _DOCUMENT_ID As String, _
                                        ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String) As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            Dim dtAnulacion As New DataTable
            dtAnulacion = clsFacturaBl.Get_VerificacionDocumentos(_NombreStore, _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
            If dtAnulacion.Rows.Count() <> 0 Then
                estado = False
            Else
                estado = True
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function AnularFacturas(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                    ByVal _NUMBER_DOCUMENT As String, Optional ByVal ComprobanteP As String = "") As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If ComprobanteP = String.Empty Then
                clsFacturaBl.AnulacionFacturacion(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
            Else
                clsFacturaBl.AnulacionFacturacionComprobanteP(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Dim STREstado As String = String.Empty
        STREstado = dgvDocumentosFactura.Rows(dgvDocumentosFactura.CurrentRow.Index).Cells(6).Value
        If STREstado = "ANULADO" Then
            MessageBox.Show("El Documento ya se encuentra anulado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Dim Store As String = String.Empty
        Dim msj As String = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        If MessageBox.Show("¿Desea Anular el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            'Verificando Cancelacion
            Store = "FACT_SP_S_R_VERIFICAR_CANCEL"
            If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                msj = String.Empty
                msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Cancelacion , no se puede Anular."
                MsgBox(msj, MsgBoxStyle.Information)
                Exit Sub
            Else
                'Verificando si ´posee Letra
                Store = String.Empty
                Store = "FACT_SP_S_R_VERIFICAR_LETRA"
                If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                    msj = String.Empty
                    msj = "   EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Letra , no se puede Anular."
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                Else
                    If Ref_DOCUMENT_ID <> "CP" Then
                        'Anulacion Factura 
                        If AnularFacturas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                            MsgBox("Hubo un error, no se completo el Proceso de Anulacion", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        msj = String.Empty
                        msj = "Documento Anulado Correctamente." & vbCrLf & " Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                        MsgBox(msj, MsgBoxStyle.Information)
                        Me.Cursor = Cursors.Default
                        DocumentosFactura()
                    Else
                        'Anulacion CP
                        If AnularFacturas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "CP") = False Then
                            MsgBox("Hubo un error, no se completo el Proceso de Anulacion", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        msj = String.Empty
                        msj = "Documento Anulado Correctamente." & vbCrLf & " Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                        MsgBox(msj, MsgBoxStyle.Information)
                        Me.Cursor = Cursors.Default
                        DocumentosFactura()
                    End If
                End If
            End If
        End If
    End Sub


    Private Function ValidacionConsultas(ByRef _DOCUMENT_ID As String, ByRef _NUMBER_SERIE As String, ByRef _NUMBER_DOCUMENT As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            _DOCUMENT_ID = dgvDocumentosFactura.Item(7, dgvDocumentosFactura.CurrentRow.Index).Value
            _NUMBER_SERIE = dgvDocumentosFactura.Item(8, dgvDocumentosFactura.CurrentRow.Index).Value
            _NUMBER_DOCUMENT = dgvDocumentosFactura.Item(9, dgvDocumentosFactura.CurrentRow.Index).Value
            'validacion
            If _DOCUMENT_ID = String.Empty Or _NUMBER_SERIE = String.Empty Or _NUMBER_DOCUMENT = String.Empty Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Return estado
    End Function

    Public Function NUMEROLETRAS(num As Double) As String
        Dim cLET As String
        Dim cWork As String
        Dim cUNIDAD As String
        Dim cDECENA As String
        Dim cCENTENA As String
        Dim nMODULUS As Integer
        Dim nI As Integer
        Dim nK As Integer
        Dim Lit1 As String
        Dim Lit2 As String
        Dim Lit3 As String
        Dim Lit4 As String
        Dim Lit5 As String
        Lit1 = "Uno    Dos    Tres   Cuatroc  Quin   Seisc  Setec  Ochoc  Novec  "
        Lit2 = "Diez     Veinte   Treinta  Cuarenta CincuentaSesenta  Setenta  Ochenta  Noventa  "
        Lit3 = "Once      Doce      Trece     Catorce   Quince    Dieciseis DiecisieteDieciocho Diecinueve"
        Lit4 = "Uno   Dos   Tres  CuatroCinco Seis  Siete Ocho  Nueve "
        Lit5 = "Millon    Billon    Trillon   CuatrillonQuintillon"
        cLET = ""
        If num > 0.99 Then

            If InStr(1, Trim(Str(num)), ".", 0) > 0 Then
                cWork = Mid(Trim(Str(num)), 1, InStr(1, Trim(Str(num)), ".", 0) - 1)
            Else
                cWork = Str(num)
            End If
            nMODULUS = Int(Len(Trim(cWork)) / 3)
            nMODULUS = Len(Trim(cWork)) - (nMODULUS * 3)

            If nMODULUS > 0 Then
                'cWork = String.Format(3 - nMODULUS, "0") & Trim(cWork)
                cWork = cWork.PadLeft(CInt(3 - nMODULUS) + CInt(cWork.Length()), "0")
            End If
            nK = (Len(Trim(cWork)) / 3) - 1

            nI = 1
            Do While nI < Len(Trim(cWork)) - 1
                cCENTENA = Mid(Trim(cWork), nI, 1)
                cDECENA = Mid(Trim(cWork), nI + 1, 1)
                cUNIDAD = Mid(Trim(cWork), nI + 2, 1)

                If cCENTENA <> "0" Then
                    If cCENTENA = "1" Then
                        cLET = cLET & "Cien "
                        If cDECENA <> "0" Or cUNIDAD <> "0" Then
                            cLET = Mid(cLET, 1, (Len(cLET) - 1)) & "to "
                        End If
                    Else
                        If cCENTENA = 2 Or cCENTENA = 3 Then
                            cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "cientos "
                        Else
                            cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "ientos "
                        End If
                    End If
                End If

                If cDECENA <> "0" Then
                    If cDECENA = "1" And cUNIDAD <> "0" Then
                        If ((Val(cUNIDAD) - 1) * 10) + 1 > 0 Then cLET = cLET + Trim(Mid(Lit3, ((Val(cUNIDAD) - 1) * 10) + 1, 10))
                    Else
                        If ((Val(cDECENA) - 1) * 9) + 1 > 0 Then cLET = cLET + Trim(Mid(Lit2, ((Val(cDECENA) - 1) * 9) + 1, 9))
                    End If
                End If

                If cUNIDAD <> "0" Then
                    If cDECENA > "1" Then
                        'MODIFICADO PARA VER EL TEXTO CON LA Y GRIEGA
                        If cDECENA = "2" Then
                            cLET = Mid(cLET, 1, (Len(cLET) - 1)) & "i"
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET + LCase(Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6)))
                        Else
                            cLET = cLET & " y "
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET + LCase(Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6)))
                        End If
                    Else
                        If cDECENA < "1" Then
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET + Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6))
                        End If
                    End If
                End If
                cLET = cLET & " "
                'Pone Miles o Millones
                If nK > 0 Then
                    If cCENTENA & cDECENA & cUNIDAD = "001" Then
                        cLET = Mid(cLET, 1, Len(cLET) - 2) & " "
                    End If
                    nMODULUS = Int(nK / 2)
                    nMODULUS = nK - (nMODULUS * 2)
                    If nMODULUS = 0 Then
                        cLET = cLET + Trim(Mid(Lit5, (((nK / 2) - 1) * 10) + 1, 10))
                        If cCENTENA & cDECENA & cUNIDAD = "001" Or num > 1999999 Then
                            cLET = cLET & "es "
                        Else
                            cLET = cLET & " "
                        End If
                    Else
                        If cCENTENA & cDECENA & cUNIDAD > "000" Then
                            cLET = cLET & "Mil "
                        End If
                    End If
                    nK = nK - 1
                End If
                nI = nI + 3
            Loop

            cLET = cLET & "con "

        End If
        If InStr(1, Trim(Str(num)), ".", 0) > 0 Then
            cLET = cLET + Mid(Trim(Format(num, ".00")), InStr(1, Trim(Format(num, ".00")), ".", 0) + 1, 2) & "/100" & " "
        Else
            cLET = cLET + "00/100" & " "
        End If
        NUMEROLETRAS = cLET
    End Function


    Private Sub imprimirFacturacion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String, _
                                    ByVal _Moneda As String, ByVal _Igv As Double, ByVal _Monto As Double)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Dim STRmontotexto As String = String.Empty
            If _Moneda = "MN" Then
                If _DOCUMENT_ID = "FO" Then
                    STRmontotexto = UCase(NUMEROLETRAS(_Igv)) & "   Nuevos Soles"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Nuevos Soles"
                End If
            Else
                If _DOCUMENT_ID = "FO" Then
                    STRmontotexto = UCase(NUMEROLETRAS(_Igv)) & "   Dólares Americanos"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Dólares Americanos"
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteFacturacion(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
            If dtImprimir.Rows.Count() <> 0 Then
                If _DOCUMENT_ID = "NC" Then
                    crystalBL.Muestra_Reporte("rpt_Impresion_Factura_NotaCredito.rpt", "", "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE, "@NUMERO;" & _NUMBER_DOCUMENT, "@LETRAS;" & STRmontotexto)
                Else
                    crystalBL.Muestra_Reporte("rpt_Impresion_Factura.rpt", "", "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE, "@NUMERO;" & _NUMBER_DOCUMENT, "@LETRAS;" & STRmontotexto)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub imprimirGuiaRemision(ByVal idalamacen As String, ByVal documentid As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaRemision(idalamacen, documentid, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Impresion_Factura_Guia_Remision.rpt", "", "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub imprimirComprobantePercepcion(ByVal documentid As String, ByVal serie As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteComprobantePercepcion(documentid, serie, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Impresion_Factura_Comprobante_P.rpt", "", "", "", "@TIPO;" & documentid, "@SERIE;" & serie, "@NUMERO;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        'Validacione Generales Reporte y consulta
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        gbGenerarCP.Visible = False
        If dgvDocumentosFactura.Visible Then
            'Mostrando resultados
            MostrarModoConsultar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
            dgvDocumentosFactura.Visible = False
            pnlFiltros.Visible = False
            gbTipoFacturacion.Visible = False
            GbCabecera.Enabled = False
            gbdetalle.Enabled = True
            gbOpciones.Enabled = False
            chkSinIGV.Visible = True
            Modo_consultar = True
            Call Botonera_Estado_Cambiar(True)
            GbdetalleDocumento.Visible = True
        Else
            If Ref_DOCUMENT_ID <> "CP" Then
                imprimirFacturacion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, cboMoneda.SelectedValue.ToString, txtIgv.Text, txtPrecioVenta.Text)
                'Verificando si posee Guia Remision
                If Ref_DOCUMENT_ID = "FT" Then
                    Dim GuiaBl As New ClsBuscar
                    Dim dtDatosGuia As New DataTable
                    dtDatosGuia = GuiaBl.Get_GuiasAsociadas(txtAlmacen.Text, Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT)
                    If dtDatosGuia.Rows.Count() <> 0 Then
                        imprimirGuiaRemision(dtDatosGuia.Rows(0).Item("WAREHOUSE_ID").ToString, dtDatosGuia.Rows(0).Item("DOCUMENT_ID").ToString, dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString)
                    End If
                End If
                'Verficar Si posee  Comprobante Percepcion
                If txtcodigoCP.Text <> "" And txtSerieCP.Text <> "" And txtNumeroCP.Text <> "" Then
                    imprimirComprobantePercepcion(txtcodigoCP.Text, txtSerieCP.Text, txtNumeroCP.Text)
                End If
            ElseIf Ref_DOCUMENT_ID = "CP" Then
                imprimirComprobantePercepcion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvDocumentosFactura.Visible = True
        pnlFiltros.Visible = True
        chkSinIGV.Visible = True
        GbdetalleDocumento.Visible = False
        gbGenerarCP.Visible = False
        gbGenerarDespacho.Visible = False
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        Limpiar()
        DocumentosFactura()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmRegistroPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboOpcionTipoDoc.SelectedIndex = 0
        cboopcionesBusqueda.SelectedIndex = 0
        Botonera_Estado_Cambiar(False)
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        txtTipoCambio.Text = ClsVarComun.TCVenta
        Call Cargar_Moneda()
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Enabled = False
            Case 1
                gbRangofechas.Enabled = False
            Case 2
                gbRangofechas.Enabled = True
        End Select
        txtFiltro.Text = String.Empty
        DocumentosFactura()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosFactura()
        End If
    End Sub

    Private Sub Ayuda_PuntoVenta(Optional ByVal _codigoPuntoVenta As String = "")
        Try
            If _codigoPuntoVenta = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "SAL_HLP_PTO_VENTA"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = ""
                frm.Titulo = "Punto de Venta"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtPtoVenta.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    lblPtoVenta.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txtAlmacen.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                    lblAlmacen.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                End If
                frm.Close()
            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Punto_Venta")
                dtDetalleFact = clsFacturaBl.Get_ManualPuntoVenta(_codigoPuntoVenta)
                Dim codArticulo As String = String.Empty
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtPtoVenta.Text = dtDetalleFact.Rows(0).Item(0)
                    lblPtoVenta.Text = dtDetalleFact.Rows(0).Item(1)
                    txtAlmacen.Text = dtDetalleFact.Rows(0).Item(2).ToString
                    lblAlmacen.Text = dtDetalleFact.Rows(0).Item(3).ToString
                    ' gbTipoFacturacion.Enabled = False
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtPtoVenta.Text = String.Empty
                    lblPtoVenta.Text = String.Empty
                    txtAlmacen.Text = String.Empty
                    lblAlmacen.Text = String.Empty
                    cboTipoDoc.DataSource = Nothing
                    cbSerieGuia.DataSource = Nothing
                    cboSerieDoc.DataSource = Nothing
                    txtPtoVenta.Focus()
                    Exit Sub
                End If
            End If
            'detalles 
            If txtPtoVenta.Text = String.Empty Then Exit Sub
            'Mostrando el tipo Doc asociado a Pnto venta
            Ayuda_TipoDocPuntoVenta()
            'Mostrando la serie
            Ayuda_SerieGuiaPuntoVenta()
            If cboTipoDoc.Text = String.Empty Then Exit Sub
            SerieDocumentoPuntoVenta()
            dtpFechaFactura.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPtoVenta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtPtoVenta.MouseDoubleClick
        Ayuda_PuntoVenta()
    End Sub

    Private Sub txtPtoVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPtoVenta.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_PuntoVenta()
        If e.KeyCode = Keys.Enter Then
            If txtPtoVenta.Text = String.Empty Then
                Ayuda_PuntoVenta()
            Else
                Ayuda_PuntoVenta(txtPtoVenta.Text)
            End If
        End If
    End Sub

    Private Sub Ayuda_Vendedor(Optional ByVal _CodigoVendedor As String = "")
        Try
            If _CodigoVendedor = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "FACT_SP_S_RECEIVABLE_VENDEDOR"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = ""
                frm.Titulo = "Vendedor"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtVendedor.Text = frm.Data_Matriz.Rows(0).Item(0)
                    lblVendedor.Text = frm.Data_Matriz.Rows(0).Item(1)
                End If
                frm.Close()
            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Vendedor")
                dtDetalleFact = clsFacturaBl.Get_ManualVendedor(_CodigoVendedor)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtVendedor.Text = dtDetalleFact.Rows(0).Item(0)
                    lblVendedor.Text = dtDetalleFact.Rows(0).Item(1)
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtVendedor.Text = String.Empty
                    lblVendedor.Text = String.Empty
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Clientes(Optional ByVal _CodigoCliente As String = "")
        Try
            If _CodigoCliente = String.Empty Then
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
                    txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                    txtVendedor.Text = frm.Data_Matriz.Rows(0).Item("SALES_ID").ToString
                End If
                frm.Close()
            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Clientes")
                dtDetalleFact = clsFacturaBl.Get_ManualClientes(_CodigoCliente)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtCodCliente.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txtRazonSocial.Text = dtDetalleFact.Rows(0).Item(1).ToString
                    txtRucDni.Text = dtDetalleFact.Rows(0).Item(2).ToString
                    txtDireccion.Text = dtDetalleFact.Rows(0).Item(3).ToString
                    txtFormaPago.Text = dtDetalleFact.Rows(0).Item(5).ToString
                    txtVendedor.Text = dtDetalleFact.Rows(0).Item("SALES_ID").ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtCodCliente.Text = String.Empty
                    txtRazonSocial.Text = String.Empty
                    txtRucDni.Text = String.Empty
                    txtDireccion.Text = String.Empty
                    txtFormaPago.Text = String.Empty
                    txtVendedor.Text = String.Empty
                    lblVendedor.Text = String.Empty
                    lblFormaPago.Text = String.Empty
                    cboDirEntrega.DataSource = Nothing
                    txtCodCliente.Focus()
                    Exit Sub
                End If
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
            If txtCodCliente.Text = String.Empty Then Exit Sub
            Ayuda_DireccionEntrega()
            If txtVendedor.Text <> String.Empty Then
                clsBuscarBl = New ClsBuscar
                lblVendedor.Text = clsBuscarBl.Get_NombreVendedor(txtVendedor.Text)
                If lblVendedor.Text = String.Empty Then
                    txtVendedor.Text = ""
                End If
            Else
                lblVendedor.Text = ""
            End If
            txtVendedor.Focus()
            If rbFacturaGuiaVenta.Checked = True Then
                If String.IsNullOrEmpty(txtCodCliente.Text) Or String.IsNullOrEmpty(txtAlmacen.Text) Then
                    MsgBox("Para este tipo de Facturacion es necesario el Cliente y el Almacen.", MsgBoxStyle.Information)
                    pnlDocumentosGuiaVenta.Visible = False
                    Exit Sub
                Else
                    MostrandoDocumentoCliente()
                    txtFiltroCliente.Text = String.Empty
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_FormaPago(Optional ByVal _codigoVendedor As String = "")
        Try
            If _codigoVendedor = String.Empty Then
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
            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Forma_Pago")
                dtDetalleFact = clsFacturaBl.Get_ManualFormaPago(_codigoVendedor)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtFormaPago.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    lblFormaPago.Text = dtDetalleFact.Rows(0).Item(1).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtFormaPago.Text = String.Empty
                    lblFormaPago.Text = String.Empty
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCliente.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Clientes()
        If e.KeyCode = Keys.Enter Then
            If txtCodCliente.Text = String.Empty Then
                Ayuda_Clientes()
            Else
                Ayuda_Clientes(txtCodCliente.Text)
            End If
        End If
    End Sub

    Private Sub txtCodCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCodCliente.MouseDoubleClick
        Ayuda_Clientes()
    End Sub

    Private Sub txtFormaPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFormaPago.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_FormaPago()
        If e.KeyCode = Keys.Enter Then
            If txtFormaPago.Text = String.Empty Then
                Ayuda_FormaPago()
            Else
                Ayuda_FormaPago(txtFormaPago.Text)
            End If
        End If
    End Sub

    Private Sub txtFormaPago_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFormaPago.MouseDoubleClick
        Ayuda_FormaPago()
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If txtPtoVenta.Text = String.Empty Then
                MsgBox("Debe seleccionar un Punto de Venta.", MsgBoxStyle.Information)
                estado = False
                txtPtoVenta.Focus()
                Exit Try
            End If

            If txtAlmacen.Text = String.Empty Then
                MsgBox("Debe seleccionar un Almacen, para poder continuar.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
            If cboMoneda.Text = String.Empty Then
                MsgBox("No se cargo datos del Tipo de Moneda.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
            If txtTipoCambio.Text = String.Empty Then
                MsgBox("No se cargo el dato del Tipo de Cambio.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
            If txtCodCliente.Text = String.Empty Then
                MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Information)
                estado = False
                txtCodCliente.Focus()
                Exit Try
            End If

            If txtFormaPago.Text = String.Empty Then
                MsgBox("Debe seleccionar una Forma de Pago.", MsgBoxStyle.Information)
                txtFormaPago.Focus()
                estado = False
                Exit Try
            End If

            If txtVendedor.Text = String.Empty Then
                MsgBox("No se cargo el dato del Vendedor.", MsgBoxStyle.Critical)
                estado = False
                txtVendedor.Focus()
                Exit Try
            End If

            If cboTipoDoc.Text = String.Empty Then
                MessageBox.Show("Debe elegir el tipo de documento a facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboTipoDoc.Focus()
                estado = False
                Exit Try
            ElseIf cboSerieDoc.Text = String.Empty Then
                MessageBox.Show("Debe elegir la serie para el Documento a Facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboSerieDoc.Focus()
                estado = False
                Exit Try
            ElseIf cbSerieGuia.Text = String.Empty Then
                MessageBox.Show("Debe elegir la serie para la Guía de Remisión.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbSerieGuia.Focus()
                estado = False
                Exit Try
                If checkSinGuia.Checked = False Then
                    If txtCodTrans.Text.Trim.Length = 0 Then
                        MessageBox.Show("Debe ingresar el Código de Transportista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtCodTrans.Focus()
                        estado = False
                        Exit Try
                    End If
                End If
            ElseIf cboDirEntrega.Items.Count > 0 Then
                If cboDirEntrega.SelectedIndex = -1 Then
                    MessageBox.Show("Debe elegir la Dirección de Entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboDirEntrega.Focus()
                    estado = False
                    Exit Try
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
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

    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticulo
            frmArticulo.AlmacenOrigen = txtAlmacen.Text
            frmArticulo.TipoDocumento = cboTipoDoc.Text
            frmArticulo.Flag_Cliente = txtCodCliente.Text
            frmArticulo.ValidacionLotes = DatosLotes()
            If rbFacturaExistencias.Checked = True Then frmArticulo.Flag_FacturaExistencias = True
            frmArticulo.Fl_NC_REF = Fl_NC_REF
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
                Fl_close = False
            Else
                Fl_close = True
            End If
            Calcular_Totales()
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mostrando_Totales_Generales()
        Try
            Dim i As Integer = 0
            Dim total As Double = 0.0
            Dim totaldesc1 As Double = 0.0
            Dim totaldesc2 As Double = 0.0
            Dim TasaIgv As Double = 0.0
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
            Dim TasaIgv As Double = 0.0
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


    'Private Sub Calcular_Totales()
    '    Try
    '        Dim i As Integer = 0
    '        Dim total As Double = 0.0
    '        Dim totaldesc1 As Double = 0.0
    '        Dim totaldesc2 As Double = 0.0
    '        Dim TasaIgv As Double = 0.0
    '        Dim Monto As Double = 0.0

    '        If dgvDetalle.RowCount > 0 Then
    '            'Datos del Sistema Parametros Generales
    '            clsIgvArticuloBL = New ClsTransacciones.clsPedidos
    '            dtIgvArticulo = New DataTable("IGV_SISTEMA")
    '            po_TasaIgv = 0.0
    '            Igv = 0.0
    '            dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvsSistema()
    '            po_TasaIgv = CDbl(dtIgvArticulo.Rows(0).Item("AMOUNT_TAX"))
    '            'obteniendo Datos del Articulo
    '            For Each row As DataRow In dtdetalleArticuloPrincipal.Rows
    '                'VERIFICA SI EL ARTICULO ESTA SUJETO A IGV
    '                clsIgvArticuloBL = New ClsTransacciones.clsPedidos
    '                dtIgvArticulo = New DataTable("Fl_igv")
    '                dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvArticulo(row("CODIGO").ToString())
    '                If dtIgvArticulo.Rows.Count() <> 0 Then
    '                    If chkSinIGV.Checked = False Then
    '                        'SI EL ARTICULO NO INCLUYE IGV
    '                        If dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = True Then
    '                            Igv = 0
    '                            txtBruto.Text = Math.Round(total, 4, MidpointRounding.AwayFromZero)
    '                            'txtDescuentos.Text = Math.Round(Double.Parse(txtBruto.Text) - 0, 4, MidpointRounding.AwayFromZero)
    '                            txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) - Double.Parse(0), 4, MidpointRounding.AwayFromZero)
    '                            txtIgv.Text = Math.Round(Double.Parse(txtvalorVenta.Text) * (po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero)

    '                        ElseIf dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = False Then
    '                            If cboTipoDoc.Text = "NC" Then
    '                                Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
    '                                'txtBruto.Text = -Math.Abs(Math.Round((total / (1 + CDbl(po_TasaIgv) / 100)), 4, MidpointRounding.AwayFromZero))
    '                                ''txtDescuentos.Text = Math.Round(Double.Parse(txtBruto.Text) - (0 / (1 + po_TasaIgv / 100)), 4, MidpointRounding.AwayFromZero)
    '                                'txtvalorVenta.Text = -Math.Abs(Math.Round(Double.Parse(txtBruto.Text) - Double.Parse(0), 4, MidpointRounding.AwayFromZero))
    '                                'txtIgv.Text = -Math.Abs(Math.Round((Double.Parse(txtvalorVenta.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
    '                                TasaIgv = 0.0
    '                                TasaIgv = po_TasaIgv / 100
    '                                Monto = 0.0
    '                                Monto = CDbl(row("PRECIO_INICIAL")) + (CDbl(row("PRECIO_INICIAL")) * (CDbl(Igv) / 100))
    '                                If chkSinIGV.Checked = False Then
    '                                    Monto = Monto / (1 + (Igv / 100))
    '                                End If
    '                                If chkSinIGV.Checked Then
    '                                    Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
    '                                Else
    '                                    Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
    '                                End If
    '                                dtdetalleArticuloPrincipal.BeginInit()
    '                                'row("PREC_UNITARIO") = -Math.Abs(Monto)
    '                                'row("VALOR_VENTA") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO")))
    '                                'row("IMP_DESC_01") = 0
    '                                'row("IMP_DESC_02") = 0
    '                                'row("PRECIO_IGV") = -Math.Abs(row("PRECIO_INICIAL"))
    '                                'row("IGV_ART") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv))
    '                                'row("IGV_ART_US") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text))
    '                                'row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))

    '                                row("PREC_UNITARIO") = -Math.Abs(CDbl(Monto))
    '                                row("VALOR_VENTA") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO")))
    '                                row("IMP_DESC_01") = -Math.Abs(CDbl((row("PREC_UNITARIO") * row("%DESC.ART_1") / 100) * row("CANTIDAD")))
    '                                row("IMP_DESC_02") = -Math.Abs(CDbl(((row("PREC_UNITARIO") - (row("PREC_UNITARIO") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD")))
    '                                row("PRECIO_IGV") = -Math.Abs(CDbl(row("PRECIO_INICIAL")))
    '                                row("IGV_ART") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv))
    '                                row("IGV_ART_US") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text))
    '                                row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))
    '                                dtdetalleArticuloPrincipal.EndInit()
    '                                dtdetalleArticuloPrincipal.AcceptChanges()
    '                                '*********** CALCULOS DE TOTALES GENERALES ***
    '                                'total = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(PREC_UNITARIO)", "") * dtdetalleArticuloPrincipal.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero))
    '                                total = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(VALOR_VENTA)", ""), 4, MidpointRounding.AwayFromZero))
    '                                totaldesc1 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero))
    '                                totaldesc2 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero))
    '                                txtBruto.Text = -Math.Abs(Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero))
    '                                txtDescuentos.Text = -Math.Abs(Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero))
    '                                txtvalorVenta.Text = -Math.Abs(Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero))
    '                                txtIgv.Text = -Math.Abs(Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
    '                                '*********** 
    '                            Else
    '                                Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
    '                                TasaIgv = 0.0
    '                                TasaIgv = po_TasaIgv / 100
    '                                Monto = 0.0
    '                                Monto = CDbl(row("PRECIO_INICIAL")) + (CDbl(row("PRECIO_INICIAL")) * (CDbl(Igv) / 100))
    '                                If chkSinIGV.Checked = False Then
    '                                    Monto = Monto / (1 + (Igv / 100))
    '                                End If
    '                                If chkSinIGV.Checked Then
    '                                    Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
    '                                Else
    '                                    Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
    '                                End If
    '                                dtdetalleArticuloPrincipal.BeginInit()
    '                                row("PREC_UNITARIO") = CDbl(Monto)
    '                                row("VALOR_VENTA") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO"))
    '                                row("IMP_DESC_01") = CDbl((row("PREC_UNITARIO") * row("%DESC.ART_1") / 100) * row("CANTIDAD"))
    '                                row("IMP_DESC_02") = CDbl(((row("PREC_UNITARIO") - (row("PREC_UNITARIO") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD"))
    '                                row("PRECIO_IGV") = row("PRECIO_INICIAL")
    '                                row("IGV_ART") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv)
    '                                row("IGV_ART_US") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text)
    '                                row("IMPORTE") = CDbl(row("PRECIO_IGV") * row("CANTIDAD"))
    '                                dtdetalleArticuloPrincipal.EndInit()
    '                                dtdetalleArticuloPrincipal.AcceptChanges()

    '                                '*********** CALCULOS DE TOTALES GENERALES***
    '                                total = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(VALOR_VENTA)", ""), 4, MidpointRounding.AwayFromZero)
    '                                totaldesc1 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero)
    '                                totaldesc2 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero)
    '                                txtBruto.Text = Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero)
    '                                txtDescuentos.Text = Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero)
    '                                txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero)
    '                                txtIgv.Text = Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero)
    '                                '*********** 
    '                            End If
    '                        End If

    '                    Else
    '                        'SI EL ARTICULO NO INCLUYE IGV
    '                        If dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = True Then
    '                            If cboTipoDoc.Text = "NC" Then
    '                                Igv = 0
    '                                txtBruto.Text = -Math.Abs(Math.Round(total, 4, MidpointRounding.AwayFromZero))
    '                                'txtDescuentos.Text = Math.Round(Double.Parse(txtBruto.Text) - 0, 4, MidpointRounding.AwayFromZero)
    '                                txtvalorVenta.Text = -Math.Abs(Math.Round(Double.Parse(txtBruto.Text) - Double.Parse(0), 4, MidpointRounding.AwayFromZero))
    '                                txtIgv.Text = -Math.Abs(Math.Round(Double.Parse(txtvalorVenta.Text) * (po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
    '                            Else
    '                                Igv = 0
    '                                txtBruto.Text = Math.Round(total, 4, MidpointRounding.AwayFromZero)
    '                                'txtDescuentos.Text = Math.Round(Double.Parse(txtBruto.Text) - 0, 4, MidpointRounding.AwayFromZero)
    '                                txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) - Double.Parse(0), 4, MidpointRounding.AwayFromZero)
    '                                txtIgv.Text = Math.Round(Double.Parse(txtvalorVenta.Text) * (po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero)
    '                            End If
    '                        ElseIf dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = False Then
    '                            If cboTipoDoc.Text = "NC" Then
    '                                Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
    '                                'txtBruto.Text = -Math.Abs(Math.Round(total, 4, MidpointRounding.AwayFromZero))
    '                                ''txtDescuentos.Text = Math.Round(Double.Parse(txtBruto.Text) - (0 / (1 + po_TasaIgv / 100)), 4, MidpointRounding.AwayFromZero)
    '                                'txtvalorVenta.Text = -Math.Abs(Math.Round(Double.Parse(txtBruto.Text) - Double.Parse(0), 4, MidpointRounding.AwayFromZero))
    '                                'txtIgv.Text = -Math.Abs(Math.Round((Double.Parse(txtvalorVenta.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
    '                                TasaIgv = 0.0
    '                                TasaIgv = po_TasaIgv / 100
    '                                Monto = 0.0
    '                                Monto = CDbl(row("PRECIO_INICIAL"))
    '                                If chkSinIGV.Checked = False Then
    '                                    Monto = Monto / (1 + (Igv / 100))
    '                                End If
    '                                If chkSinIGV.Checked Then
    '                                    Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
    '                                Else
    '                                    Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
    '                                End If
    '                                dtdetalleArticuloPrincipal.BeginInit()
    '                                'row("PREC_UNITARIO") = -Math.Abs(row("PRECIO_INICIAL"))
    '                                'row("VALOR_VENTA") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO")))
    '                                'row("IMP_DESC_01") = 0
    '                                'row("IMP_DESC_02") = 0
    '                                'row("PRECIO_IGV") = -Math.Abs(Monto)
    '                                'row("IGV_ART") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv))
    '                                'row("IGV_ART_US") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text))
    '                                'row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))
    '                                'row("CANTIDAD") = -Math.Abs(row("CANTIDAD"))

    '                                row("PREC_UNITARIO") = -Math.Abs(CDbl(row("PRECIO_INICIAL")))
    '                                row("VALOR_VENTA") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO")))
    '                                row("IMP_DESC_01") = -Math.Abs(CDbl((row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100) * row("CANTIDAD")))
    '                                row("IMP_DESC_02") = -Math.Abs(CDbl(((row("PRECIO_INICIAL") - (row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD")))
    '                                row("PRECIO_IGV") = -Math.Abs(CDbl(Monto))
    '                                row("IGV_ART") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv))
    '                                row("IGV_ART_US") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text))
    '                                row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))



    '                                dtdetalleArticuloPrincipal.EndInit()
    '                                dtdetalleArticuloPrincipal.AcceptChanges()
    '                                '*********** CALCULOS DE TOTALES GENERALES
    '                                total = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL_INICIAL)", ""), 4, MidpointRounding.AwayFromZero))
    '                                totaldesc1 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero))
    '                                totaldesc2 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero))

    '                                txtBruto.Text = -Math.Abs(Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero))
    '                                txtDescuentos.Text = -Math.Abs(Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero))
    '                                txtvalorVenta.Text = -Math.Abs(Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero))
    '                                txtIgv.Text = -Math.Abs(Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
    '                                '***********
    '                            Else
    '                                Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
    '                                TasaIgv = 0.0
    '                                TasaIgv = po_TasaIgv / 100
    '                                Monto = 0.0
    '                                Monto = CDbl(row("PRECIO_INICIAL"))
    '                                If chkSinIGV.Checked = False Then
    '                                    Monto = Monto / (1 + (Igv / 100))
    '                                End If
    '                                If chkSinIGV.Checked Then
    '                                    Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
    '                                Else
    '                                    Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
    '                                End If
    '                                dtdetalleArticuloPrincipal.BeginInit()
    '                                row("PREC_UNITARIO") = row("PRECIO_INICIAL")
    '                                row("VALOR_VENTA") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO"))
    '                                row("IMP_DESC_01") = CDbl((row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100) * row("CANTIDAD"))
    '                                row("IMP_DESC_02") = CDbl(((row("PRECIO_INICIAL") - (row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD"))
    '                                row("PRECIO_IGV") = Monto
    '                                row("IGV_ART") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO") * TasaIgv)
    '                                row("IGV_ART_US") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO") / txtTipoCambio.Text)
    '                                row("IMPORTE") = CDbl(row("PRECIO_IGV") * row("CANTIDAD"))
    '                                dtdetalleArticuloPrincipal.EndInit()
    '                                dtdetalleArticuloPrincipal.AcceptChanges()
    '                                '*********** CALCULOS DE TOTALES GENERALES
    '                                total = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL_INICIAL)", ""), 4, MidpointRounding.AwayFromZero)
    '                                totaldesc1 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero)
    '                                totaldesc2 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero)

    '                                txtBruto.Text = Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero)
    '                                txtDescuentos.Text = Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero)
    '                                txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero)
    '                                txtIgv.Text = Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero)
    '                                '***********
    '                            End If
    '                        End If
    '                    End If
    '                    '***********

    '                    '***********
    '                End If
    '            Next
    '            '*********** FORMATO DE SALIDA
    '            txtBruto.Text = Format(Double.Parse(txtBruto.Text), "##,##0.00")
    '            txtDescuentos.Text = Format(Double.Parse(txtDescuentos.Text), "##,##0.00")
    '            txtvalorVenta.Text = Format(Double.Parse(txtvalorVenta.Text), "##,##0.00")
    '            txtIgv.Text = Format(Double.Parse(txtIgv.Text), "##,##0.00")
    '            txtPrecioVenta.Text = Double.Parse(txtBruto.Text) + Double.Parse(txtIgv.Text)
    '            txtPrecioVenta.Text = Format(Double.Parse(txtPrecioVenta.Text), "##,##0.00")
    '            '***********
    '        Else
    '            txtBruto.Text = "0.00"
    '            txtDescuentos.Text = "0.00"
    '            txtvalorVenta.Text = "0.00"
    '            txtIgv.Text = "0.00"
    '            txtPrecioVenta.Text = "0.00"
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If GbCabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            GbCabecera.Enabled = False
            gbTipoFacturacion.Enabled = False
        End If
        If dgvDetalle.Rows.Count() = NumeroItemsDocumentos() Then
            MsgBox("Ya alcanzo el numero maximo de Lineas permitido para este Tipo de Documento.", MsgBoxStyle.Information)
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

    Private Sub ActualizandoGenerarTotales()
        'Actualizando Totales
        For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
            dtdetalleArticuloPrincipal.BeginInit()
            If chkSinIGV.Checked = True Then
                item("PRECIO_INICIAL") = CDbl(Math.Abs(item("PREC_UNITARIO")))
                item("TOTAL_INICIAL") = CDbl(Math.Abs(item("CANTIDAD")) * item("PRECIO_INICIAL"))
            Else
                item("PRECIO_INICIAL") = CDbl(Math.Abs(item("PRECIO_IGV")))
                item("TOTAL_INICIAL") = CDbl(Math.Abs(item("CANTIDAD")) * item("PRECIO_INICIAL"))
            End If
            dtdetalleArticuloPrincipal.EndInit()
            dtdetalleArticuloPrincipal.AcceptChanges()
        Next
    End Sub

    Private Sub ModificandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticulo
            frmArticulo.AlmacenOrigen = txtAlmacen.Text
            frmArticulo.TipoDocumento = cboTipoDoc.Text
            frmArticulo.Flag_Cliente = txtCodCliente.Text
            Dim lote As String = dgvDetalle.Item(5, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim CodigoArticulo As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
            Dim Saldo As String = String.Empty
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.ItemLote = lote
            If lote = String.Empty Then
                frmArticulo.ValidacionLotes = DatosLotes()
            Else
                frmArticulo.ValidacionLotes = DatosLotes(lote, CodigoArticulo)
            End If
            frmArticulo.Flag_Modo_Edicion = True
            If rbFacturaGuiaVenta.Checked = True Then frmArticulo.Qt_saldo = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value
            If rbFacturaGuiaVenta.Checked = True Then frmArticulo.Flag_FacturaGuiaVenta = True
            Dim Codigo As String = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            If rbFacturaExistencias.Checked = True Then frmArticulo.Flag_FacturaExistencias = True
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
                        item("PRECIO_INICIAL") = CDbl(frmArticulo.dtdetalleArticulo.Rows(0).Item("PRECIO_INICIAL"))
                        item("TOTAL_INICIAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TOTAL_INICIAL")
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        edicion = True
        If GbCabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            GbCabecera.Enabled = False
            gbTipoFacturacion.Enabled = False
        End If
        ModificandoArticulos()
    End Sub

    Private Sub ActualizandoCorrelativoItem()
        'Actualizando Numeracion
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
            For Each items As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & lista(i))
                dtdetalleArticuloPrincipal.BeginInit()
                items("ITEM") = i + 1
                dtdetalleArticuloPrincipal.EndInit()
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next
        Next
    End Sub

    Private Sub EliminandoArticulo()
        Try
            If Windows.Forms.MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    item.Delete()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
                Calcular_Totales()
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
            cboTipoDoc.ValueMember = "SERIE"
            cboTipoDoc.DisplayMember = "TIPO"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_DireccionEntrega()
        Try
            cConsultabL = New ClsConsultas
            dtDirCliente = New DataTable
            dtDirCliente = cConsultabL.get_Direcciones_Cliente(txtCodCliente.Text)
            cboDirEntrega.DataSource = dtDirCliente
            cboDirEntrega.ValueMember = "ADDR_DLV"
            cboDirEntrega.DisplayMember = "ADDR_DLV"
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

    Private Sub SerieDocumentoPuntoVenta()
        cVenta = New ClsAyudas
        dtSerieDoc = New DataTable
        dtSerieDoc = cVenta.get_Serie_Doc_Pto_Venta(cboTipoDoc.Text, txtPtoVenta.Text.Trim)
        cboSerieDoc.DataSource = dtSerieDoc
        cboSerieDoc.ValueMember = dtSerieDoc.Columns(0).ToString
        cboSerieDoc.DisplayMember = dtSerieDoc.Columns(0).ToString
        cVenta = Nothing
    End Sub

    Private Sub cbTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoDoc.SelectionChangeCommitted
        If cboTipoDoc.SelectedIndex <> -1 Then
            SerieDocumentoPuntoVenta()
        End If
    End Sub


    Private Sub Ayuda_Transportistas(Optional ByVal _CodigoTransportista As String = "")
        Try
            If _CodigoTransportista = String.Empty Then
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
            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Transportista")
                dtDetalleFact = clsFacturaBl.Get_ManualTransportista(_CodigoTransportista)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtCodTrans.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txtNomTrans.Text = dtDetalleFact.Rows(0).Item(1).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtCodTrans.Text = String.Empty
                    txtNomTrans.Text = String.Empty
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtCodTrans_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCodTrans.MouseDoubleClick
        Ayuda_Transportistas()
    End Sub

    Private Sub cbTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDoc.SelectedIndexChanged
        If cboTipoDoc.DataSource Is Nothing Then Exit Sub
        cboSerieDoc.Text = cboTipoDoc.SelectedValue.ToString
        If rbFacturaGuiaVenta.Checked = True Then
            checkSinGuia.Checked = True
            checkSinGuia.Enabled = False
            gbOpciones.Enabled = False
            cboTipoDoc.Enabled = False
        ElseIf rbFacturaExistencias.Checked = True Then
            checkSinGuia.Checked = True
            checkSinGuia.Enabled = False
            cboTipoDoc.Enabled = False
            gbOpciones.Enabled = True
        Else
            cboTipoDoc.Enabled = True
            If cboTipoDoc.Text = "FT" Then
                checkSinGuia.Checked = False
                checkSinGuia.Enabled = True
                gbTipoGuia.Visible = True
                rbunalinea.Checked = True
                AjustarTamaño(False)
                lblGlosa.Text = " Glosa Factura"
            ElseIf cboTipoDoc.Text = "NC" Then
                checkSinGuia.Checked = True
                checkSinGuia.Enabled = False
                AjustarTamaño(True)
                gbTipoGuia.Visible = False
                rbunalinea.Checked = True
                lblGlosa.Text = "Glosa Nota de Credito"
            ElseIf cboTipoDoc.Text = "ND" Then
                checkSinGuia.Checked = True
                checkSinGuia.Enabled = False
                AjustarTamaño(True)
                gbTipoGuia.Visible = False
                rbunalinea.Checked = True
                lblGlosa.Text = "Glosa Nota de Debito"
            End If
        End If
    End Sub

    Public Sub AjustarTamaño(ByVal opcion As Boolean)
        If opcion = True Then
            Me.txtGlosa.Size = New System.Drawing.Size(784, 56)
        Else
            Me.txtGlosa.Size = New System.Drawing.Size(784, 25)
        End If
    End Sub

    Private Sub txtVendedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedor.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub
    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'dtv.Sort = STRorden
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub checkSinGuia_CheckedChanged(sender As Object, e As EventArgs) Handles checkSinGuia.CheckedChanged
        If checkSinGuia.Checked = True Then
            txtCodTrans.Text = String.Empty
            txtNomTrans.Text = String.Empty
            txtGlosaGuia.Text = String.Empty
            txtCodTrans.Enabled = False
            txtGlosaGuia.Enabled = False
            AjustarTamaño(True)
            gbTipoGuia.Visible = False
        Else
            txtCodTrans.Enabled = True
            txtGlosaGuia.Enabled = True
            AjustarTamaño(False)
            gbTipoGuia.Visible = True
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
            lbltipoDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
        txtNumDocRef.Focus()
    End Sub

    Private Sub txttipoDocRef_DoubleClick(sender As Object, e As EventArgs) Handles txttipoDocRef.DoubleClick
        TipoDocumento()
    End Sub


    Private Sub MostrandoFacturaNotasCredito(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String)
        Try
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtCabeceraFact = New DataTable
            dtDetalleFact = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraFact = clsFacturaCabBl.get_CabecearaFacturacion(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
            If dtCabeceraFact.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraFact.Rows.Count() - 1
                    txtCodCliente.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRucDni.Text = dtCabeceraFact.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtRazonSocial.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtDireccion.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ADDR").ToString
                    txtVendedor.Text = dtCabeceraFact.Rows(i).Item("SALES_REP_ID").ToString
                    txtFormaPago.Text = dtCabeceraFact.Rows(i).Item("TERMS_ID").ToString
                    txtcotizacion.Text = ""
                    txtordenCompra.Text = dtCabeceraFact.Rows(i).Item("NUMBER_ORDER_PUR").ToString
                    txtpedido.Text = ""
                    'checkSinGuia.Checked = ""
                    txtCodTrans.Text = ""
                    cboDirEntrega.Text = ""
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
                    Else
                        txtPtoVenta.Text = ""
                        lblPtoVenta.Text = ""
                    End If
                    Ayuda_SerieGuiaPuntoVenta()
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
                        txtFormaPago.Text = dtDatos.Rows(0).Item(5).ToString
                        txtVendedor.Text = dtDatos.Rows(0).Item("SALES_ID").ToString
                        cboDirEntrega.DataSource = Nothing
                        cboDirEntrega.Items.Clear()
                        cboDirEntrega.Items.Add(dtDatos.Rows(0).Item("ADDR_DLV").ToString)
                        cboDirEntrega.SelectedIndex = 0
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
                clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsFacturaCabBl.get_DetalleFacturacionNotaCredito(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    chkSinIGV.Checked = True
                    Mostrando_Totales_Generales()
                    Fl_NC_REF = True
                Else
                    MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                    ''CALCULANDO TOTALES GENERALES
                    txtBruto.Text = "-0.00"
                    txtDescuentos.Text = "-0.00"
                    txtvalorVenta.Text = "-0.00"
                    txtIgv.Text = "-0.00"
                    txtPrecioVenta.Text = "-0.00"
                    Fl_NC_REF = False
                End If
            Else
                MsgBox("No hay Datos con la Informacion Brindada.", MsgBoxStyle.Information)
                Fl_NC_REF = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_NumeroDocumentosReferencia()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_R_RECEIVABLE_NOTA_C"
            frm.CadenaConsulta = sql
            frm.Filtros1 = txtPtoVenta.Text
            frm._Flag_Filtro = True
            frm.Titulo = "Documentos Facturados"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtNumDocRef.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtSerieDocRef.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                MostrandoFacturaNotasCredito("FT", txtSerieDocRef.Text, txtNumDocRef.Text)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtNumDocRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtNumDocRef.MouseDoubleClick
        If cboTipoDoc.Text = "NC" Then
            If txttipoDocRef.Text <> "FT" Then Exit Sub
            If txtPtoVenta.Text = String.Empty Then
                MsgBox("Debe seleccionar un Punto Venta.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If txttipoDocRef.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Ayuda_NumeroDocumentosReferencia()
        End If
    End Sub

    Private Sub txttipoDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txttipoDocRef.KeyDown
        If e.KeyCode = Keys.F1 Then
            TipoDocumento()
        End If
    End Sub

    Private Sub dtpFechaFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFechaFactura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboSerieDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSerieDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txttipoDocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipoDocRef.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVendedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtFormaPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFormaPago.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcotizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcotizacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtordenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtordenCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtpedido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpedido.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtCodTrans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodTrans.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtSerieDocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerieDocRef.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtNumDocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumDocRef.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cbSerieGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSerieGuia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtBuscarOrdenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarOrdenCompra.KeyPress
        'If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
    End Sub

    Private Sub txtordenCompra_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtordenCompra.MouseDoubleClick
        If txtCodCliente.Text = String.Empty Then
            MsgBox("Es necesario Elegir un Cliente para poder Continuar.", MsgBoxStyle.Information)
            txtCodCliente.Focus()
            Exit Sub
        End If
        GbCabecera.Enabled = False
        txtBuscarOrdenCompra.Text = String.Empty
        PnlBuscarordenCompra.Visible = True
        txtBuscarOrdenCompra.Focus()
    End Sub

    Private Sub btnSalirNumeracion_Click(sender As Object, e As EventArgs) Handles btnSalirNumeracion.Click
        PnlBuscarordenCompra.Visible = False
        GbCabecera.Enabled = True
        txtBuscarOrdenCompra.Text = String.Empty
    End Sub

    Private Sub btnAceptarBusquedaOC_Click(sender As Object, e As EventArgs) Handles btnAceptarBusquedaOC.Click
        If txtBuscarOrdenCompra.Text = String.Empty Then
            MsgBox("Debe ingresar un Numero de Orden de Compra.", MsgBoxStyle.Information)
            txtBuscarOrdenCompra.Select()
            Exit Sub
        End If
        Dim Consulta As String = String.Empty
        Dim dtDetalles As DataTable

        If RadioButton1.Checked = True Then
            Consulta = "SELECT DOCUMENT_ID,NUMBER_SERIE,NUMBER_DOCUMENT,DOCUMENT_DATE " _
                     & "FROM RECEIVABLE WHERE NUMBER_ORDER_PUR='" & txtBuscarOrdenCompra.Text & "' AND CUSTOMER_ID='" & txtCodCliente.Text & "' AND STATUS<>'A' "
            clsBuscarBl = New ClsBuscar
            dtDetalles = New DataTable("Refacturar")
            dtDetalles = clsBuscarBl.Get_VerificacionOrdenCompra(Consulta)
            If dtDetalles.Rows.Count() = 1 Then
                Consulta = String.Empty
                Consulta = "SELECT DOCUMENT_ID,NUMBER_SERIE,NUMBER_DOCUMENT,DOCUMENT_DATE " _
                         & "FROM RECEIVABLE WHERE DOCUMENT_REF='" & dtDetalles.Rows(0).Item(0).ToString & "' AND SERIE_REF='" & dtDetalles.Rows(0).Item(1).ToString & "' AND NUMBER_REF='" & dtDetalles.Rows(0).Item(2).ToString & "' AND STATUS<>'A' "
                clsBuscarBl = New ClsBuscar
                Dim dtDetalles2 As New DataTable
                dtDetalles2 = clsBuscarBl.Get_VerificacionOrdenCompra(Consulta)
                If dtDetalles2.Rows.Count() = 0 Then
                    MsgBox("Debe de eliminar la  " & dtDetalles.Rows(0).Item(0).ToString & " " & dtDetalles.Rows(0).Item(1).ToString & "" & dtDetalles.Rows(0).Item(2).ToString & " , que contiene la OC   " & txtBuscarOrdenCompra.Text & "  ", vbInformation, "Información")
                    Exit Sub
                ElseIf dtDetalles2.Rows.Count() = 1 Then
                    txtordenCompra.Text = txtBuscarOrdenCompra.Text
                    PnlBuscarordenCompra.Visible = False
                    GbCabecera.Enabled = True
                    txtordenCompra.Focus()
                End If
            ElseIf dtDetalles.Rows.Count() = 0 Or dtDetalles.Rows.Count() > 1 Then
                MsgBox("El documento fue Refacturado,o a elegido la Opcion Incorrecta!!!", vbInformation, "Aviso")
                txtBuscarOrdenCompra.Text = ""
                txtBuscarOrdenCompra.Focus()
                Exit Sub
            End If
        ElseIf RadioButton2.Checked = True Then
            Consulta = "SELECT DOCUMENT_ID,NUMBER_SERIE,NUMBER_DOCUMENT,DOCUMENT_DATE " _
                      & "FROM RECEIVABLE WHERE NUMBER_ORDER_PUR='" & txtBuscarOrdenCompra.Text & "' AND CUSTOMER_ID='" & txtCodCliente.Text & "' AND STATUS<>'A' "
            clsBuscarBl = New ClsBuscar
            dtDetalles = New DataTable("Extension")
            dtDetalles = clsBuscarBl.Get_VerificacionOrdenCompra(Consulta)
            If dtDetalles.Rows.Count() <> 0 Then
                Dim Num_documentos As String = String.Empty
                For i As Integer = 0 To dtDetalles.Rows.Count() - 1
                    Num_documentos += dtDetalles.Rows(i).Item(0).ToString & "-" & dtDetalles.Rows(i).Item(1).ToString & dtDetalles.Rows(i).Item(2).ToString & ","
                Next
                Num_documentos = Num_documentos.Substring(0, Num_documentos.Length() - 1)
                MsgBox("Nro de documentos de Referencia : " & Num_documentos, MsgBoxStyle.Information, "Mensaje-Sistemas")
                txtordenCompra.Text = txtBuscarOrdenCompra.Text
                PnlBuscarordenCompra.Visible = False
                GbCabecera.Enabled = True
                txtordenCompra.Focus()
            Else
                MsgBox("A elegido la opcion incorrecta!!!", MsgBoxStyle.Information, "Aviso")
                txtBuscarOrdenCompra.Text = ""
                txtBuscarOrdenCompra.Focus()
            End If
        ElseIf RadioButton3.Checked = True Then
            Consulta = "SELECT DOCUMENT_ID,NUMBER_SERIE,NUMBER_DOCUMENT,DOCUMENT_DATE " _
                     & "FROM RECEIVABLE WHERE NUMBER_ORDER_PUR='" & txtBuscarOrdenCompra.Text & "' AND CUSTOMER_ID='" & txtCodCliente.Text & "' AND STATUS<>'A' "
            clsBuscarBl = New ClsBuscar
            dtDetalles = New DataTable("Todos")
            dtDetalles = clsBuscarBl.Get_VerificacionOrdenCompra(Consulta)
            If dtDetalles.Rows.Count() <> 0 Then
                MsgBox("La orden de compra se anexo a la   " & dtDetalles.Rows(0).Item(0).ToString & " " & dtDetalles.Rows(0).Item(1).ToString & "" & dtDetalles.Rows(0).Item(2).ToString & "  , o a elegido la Opcion Incorrecta!!!", vbInformation, "Aviso")
                txtBuscarOrdenCompra.Text = ""
                txtBuscarOrdenCompra.Focus()
                Exit Sub
            Else
                txtordenCompra.Text = txtBuscarOrdenCompra.Text
                PnlBuscarordenCompra.Visible = False
                GbCabecera.Enabled = True
                txtordenCompra.Focus()
            End If
        End If
    End Sub

    Private Sub cboOpcionTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOpcionTipoDoc.SelectedIndexChanged
        If cboOpcionTipoDoc.Text = String.Empty Then Exit Sub
        DocumentosFactura()
    End Sub

 
    Private Sub txtVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendedor.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Vendedor()
        If e.KeyCode = Keys.Enter Then
            If txtVendedor.Text = String.Empty Then
                Ayuda_Vendedor()
            Else
                Ayuda_Vendedor(txtVendedor.Text)
            End If
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosFactura()
        End If
    End Sub

    Private Sub txtBuscarOrdenCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscarOrdenCompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarBusquedaOC_Click(sender, e)
        End If
    End Sub

    Private Sub txtCodTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodTrans.KeyDown

        If e.KeyCode = Keys.F1 Then Ayuda_Transportistas()
        If e.KeyCode = Keys.Enter Then
            If txtFormaPago.Text = String.Empty Then
                Ayuda_Transportistas()
            Else
                Ayuda_Transportistas(txtCodTrans.Text)
            End If
        End If
    End Sub

    Private Sub btnGenerarCP_Click(sender As Object, e As EventArgs) Handles btnGenerarCP.Click
        '---Comprbante de Percepcion
        If Windows.Forms.MessageBox.Show("¿Desea Generar Comprobante de Percepcion.?", "Comprobante Percepcion", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ''GUARDANDO DATOS DEL COMPROBANTE DE PERCEPCION
            PorcentajePercepcion = String.Empty
            PorcentajePercepcion = InputBox("Introduzca el porcentaje del Comprobante de Percepcion.", "Dato de Porcentaje de Percepcion")
            While PorcentajePercepcion = "" Or PorcentajePercepcion <> ""
                If IsNumeric(PorcentajePercepcion) = False Then
                    MsgBox("Usted eligio generar Comprobante de Percepcion," & vbCrLf & " es necesario ingresar un porcentaje.", MsgBoxStyle.Information, "Sistemas")
                    PorcentajePercepcion = String.Empty
                    PorcentajePercepcion = InputBox("Introduzca el porcentaje del Comprobante de Percepcion.", "Dato de Porcentaje de Percepcion")
                    Continue While
                Else
                    Exit While
                End If
            End While
            cabeceraBL = New ClsOperaciones.RECEIVABLE
            dtVerificar = New DataTable

            Dim MontoPercepcion As Double = 0.0
            MontoPercepcion = (txtPrecioVenta.Text * CDbl(PorcentajePercepcion) / 100)

            dtVerificar = cabeceraBL.get_VerificacionComprobanteP(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
            If dtVerificar.Rows.Count() = 0 Then
                If CodigoNumeroComprobatePercepcion() = False Then
                    MsgBox("Usted eligio generar Comprobante de Percepcion, es necesario escoger un Tipo de Numeracion.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                cabeceraBL = New ClsOperaciones.RECEIVABLE
                If cabeceraBL.GuardarComprobantePercepcion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion) = False Then
                    MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    MsgBox("Comprobante de Percepcion generado Correctamente", MsgBoxStyle.Information)
                    gbGenerarCP.Visible = False
                End If
            Else
                MsgBox("Ya se Generó un Comprobante de Percepcion." & vbCrLf & " Nro Documento: CP - " & dtVerificar.Rows(0).Item("NUMBER_COMP_PER").ToString, MsgBoxStyle.Information)
                gbGenerarCP.Visible = False
            End If
        End If
    End Sub

    Private Sub cboDirEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDirEntrega.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

 
    Private Sub rbFacturaDirecta_CheckedChanged(sender As Object, e As EventArgs) Handles rbFacturaDirecta.CheckedChanged
        If rbFacturaDirecta.Checked = True Then
            Limpiar()
        End If
    End Sub

    Private Sub rbFacturaGuiaVenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbFacturaGuiaVenta.CheckedChanged
        If rbFacturaGuiaVenta.Checked = True Or rbFacturaExistencias.Checked = True Then
            Limpiar()
        Else
            Limpiar()
            cboTipoDoc.Enabled = True
            checkSinGuia.Checked = False
            checkSinGuia.Enabled = True
            gbOpciones.Enabled = True
            btnAgregar.Enabled = True
            btnquitar.Enabled = True
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
            End If
            txtNumDocRef.Text = String.Empty
        End If
    End Sub

    Private Sub rbFacturaExistencias_CheckedChanged(sender As Object, e As EventArgs) Handles rbFacturaExistencias.CheckedChanged
        If rbFacturaExistencias.Checked = True Then
            Limpiar()
        Else
            cboTipoDoc.Enabled = True
            checkSinGuia.Checked = False
            checkSinGuia.Enabled = True
            gbOpciones.Enabled = True
            btnAgregar.Enabled = True
            btnquitar.Enabled = True
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
            End If
            txtNumDocRef.Text = String.Empty
        End If
    End Sub

    Private Sub MostrandoDocumentoCliente()
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtDetalleFact = New DataTable("DocumentoCliente")
            dtv = New DataView
            dtDetalleFact = clsFacturaBl.Get_ClienteDocumento(txtCodCliente.Text, txtAlmacen.Text)
            dtv = dtDetalleFact.DefaultView
            If dtDetalleFact.Rows.Count() <> 0 Then
                pnlDocumentosGuiaVenta.Visible = True
                GbCabecera.Enabled = False
                dgvDocumentosCliente.DataSource = dtv
                dgvDocumentosCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRordenCliente = dgvDocumentosCliente.Columns(2).Name
                dgvDocumentosCliente.Columns(1).ReadOnly = True
                dgvDocumentosCliente.Columns(2).ReadOnly = True
                dgvDocumentosCliente.Columns(3).ReadOnly = True
            Else
                MsgBox("El Cliente no posee ninguna Guia de Venta.", MsgBoxStyle.Information, "Sistemas")
                pnlDocumentosGuiaVenta.Visible = False
                GenerarColummnaDataTable()
                txtNumDocRef.Text = String.Empty
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltroCliente_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroCliente.TextChanged
        Dim wbusqueda As String = UCase(txtFiltroCliente.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRordenCliente & " like '%" & txtFiltroCliente.Text & "%'"
        myCurrencyManager.Position = INTnewpos
    End Sub

    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal.Rows
            i += 1
            dtdetalleArticuloPrincipal.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal.EndInit()
            dtdetalleArticuloPrincipal.AcceptChanges()
        Next
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            ListaDocCliente = New List(Of String)
            NumerosDocClientes = String.Empty
            For Each row As DataGridViewRow In dgvDocumentosCliente.Rows
                If row.Cells(0).Value = True Then
                    ListaDocCliente.Add(row.Cells(2).Value)
                End If
            Next
            If ListaDocCliente.Count() <> 0 Then
                txtNumDocRef.Text = String.Empty
                For i As Integer = 0 To ListaDocCliente.Count() - 1
                    txtNumDocRef.Text += "GS-" & ListaDocCliente(i).Trim & ","
                    NumerosDocClientes = NumerosDocClientes & """" & ListaDocCliente(i).Trim & """" & ","
                    'NumerosDocClientes += ListaDocCliente(i).Trim & ","
                Next
                txtNumDocRef.Text = Mid(txtNumDocRef.Text, 1, txtNumDocRef.Text.Trim.Length - 1)
                NumerosDocClientes = Mid(NumerosDocClientes, 1, NumerosDocClientes.Trim.Length - 1)
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("DetalleDocumentoCliente")
                dtDetalleFact = clsFacturaBl.Get_ClienteDetallesDocumento(NumerosDocClientes)
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = dtDetalleFact
                If dtDetalleFact.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    RehacerSecuencia()
                    gbOpciones.Enabled = True
                    btnquitar.Enabled = False
                    btnAgregar.Enabled = False
                Else
                    MsgBox("No hay informacion disponible, en el Detalle")
                    gbOpciones.Enabled = False
                End If
                GbCabecera.Enabled = True
                pnlDocumentosGuiaVenta.Visible = False
                txtFiltroCliente.Text = String.Empty
            Else
                MsgBox("Debe seleccionar al menos un Documento", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        pnlDocumentosGuiaVenta.Visible = False
        txtFiltroCliente.Text = String.Empty
        GbCabecera.Enabled = True
        btnDespacho.Enabled = False
    End Sub


    Private Sub btnDespacho_Click(sender As Object, e As EventArgs) Handles btnDespacho.Click
        pnlConfirmarDespacho.Visible = True
        dtpDespacho.Value = Date.Now()
        gbGenerarDespacho.Enabled = False
    End Sub
 
    Private Sub btn_AceptarDesp_Click(sender As Object, e As EventArgs) Handles btn_AceptarDesp.Click
        Try
            If Windows.Forms.MessageBox.Show("¿Desea Generar el  Despacho.?", "Despacho", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If String.IsNullOrEmpty(txtdetalleserie.Text) Or String.IsNullOrEmpty(txtdetallenumero.Text) Then
                    MsgBox("Los numero del Documento no se cargo.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                If clsFacturaBl.GenerarDespacho(txtdetalledoc.Text, txtdetalleserie.Text & txtdetallenumero.Text, _
                                             dtpDespacho.Value.ToString("dd/MM/yyyy") & " " & String.Format("{0:HH:mm:ss}", DateTime.Now), LibComunVar.ClsVarComun.USUARIO) Then
                    MsgBox("Generacion de despacho realizado correctamente", MsgBoxStyle.Information)
                    pnlConfirmarDespacho.Visible = False
                    gbGenerarDespacho.Visible = False
                    gbGenerarDespacho.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_SalirDesp_Click(sender As Object, e As EventArgs) Handles btn_SalirDesp.Click
        pnlConfirmarDespacho.Visible = False
        gbGenerarDespacho.Enabled = True
    End Sub

    Private Sub rbunalinea_CheckedChanged(sender As Object, e As EventArgs) Handles rbunalinea.CheckedChanged
        Me.txtGlosaGuia.Size = New System.Drawing.Size(706, 25)
    End Sub

    Private Sub rbVariaslineas_CheckedChanged(sender As Object, e As EventArgs) Handles rbVariaslineas.CheckedChanged
        Me.txtGlosaGuia.Size = New System.Drawing.Size(706, 56)
    End Sub

    Private Sub txtGlosaGuia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGlosaGuia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rbunalinea.Checked = True Then
                e.Handled = True
                Exit Sub
            End If
        End If
    End Sub
End Class