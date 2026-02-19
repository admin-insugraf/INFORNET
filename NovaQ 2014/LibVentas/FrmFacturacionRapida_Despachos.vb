Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing
Imports System.Drawing.Printing
Imports LibSeguridad.ClsUsuario
Imports System.Collections.Specialized
Imports System.IO
'Imports Microsoft.Office.Interop
Imports LibBillService.Process


Public Class FrmFacturacionRapida_Despachos

    Dim dtDatosCompany As DataTable
    Dim total_soles As Double
    Dim total_dolares As Double
    Dim contador_doc_vencidos As Integer
    Dim clienteBL As ClsNegocio.CUSTOMER
    Public dtUsuarioAcceso As DataTable
    Public ClsUsuarioBl As LibSeguridad.ClsUsuario
    Public ClsData As LibConexion.ClsData
    Dim clsReceivablaBl As ClsOperaciones.RECEIVABLE
    Dim clsBuscarBl As ClsBuscar
    Private cProcesosbL As ClsProcesos
    Private cConsultabL As ClsConsultas
    ' Private clsFacturaBl As ClsOperaciones.RECEIVABLE
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Dim clsPedidoBl As ClsOperaciones.ORDERS

    Dim PedidoCabENT As ClsEntidades.ORDER
    Dim PedidoDetENT As ClsEntidades.ORDER_LINE
    Dim ListaDetalles As List(Of ClsEntidades.ORDER_LINE)
    Dim ListaDetalles_op As List(Of ClsEntidades.ORDER_PRODUCTION_LINE)
    Dim ListaCabecera_op As List(Of ClsEntidades.ORDER_PRODUCTION)
    Dim OrdenProduccionCabENT As ClsEntidades.ORDER_PRODUCTION
    Dim OrdenProduccionDetENT As ClsEntidades.ORDER_PRODUCTION_LINE
    Dim CORRELATIVOBL As ClsTransacciones.ORDERS
    Dim CORRELATIVOBL_op As LibManufactura.ClsTransacciones.ORDER_PRODUCTION

    Private dtDocumentoFactura As DataTable
    Private dt_lista_productos As DataTable
    Dim _filtra As Boolean
    Public CodigoVendedor As String = String.Empty
    Public DescripcionVendedor As String = String.Empty
    Public tipo_Vendedor As String = String.Empty

    Dim Flag_Ref As Boolean = False

    Dim Flag_Verificar As Boolean = False
    Dim Modo_consultar As Boolean = False
    Dim Modo_programar As Boolean = False
    Dim Modo_editar As Boolean = False
    Dim dtv As DataView
    Dim dtv_lista_productos As DataView
    Dim STRorden As String = String.Empty
    Dim STRorden_Lista_Productos As String = String.Empty
    Dim STRordenCliente As String = String.Empty
    Dim STRordenPedido As String = String.Empty
    Dim STRordenDevol As String = String.Empty

    Dim edicion As Boolean = False
    Public dtdetalleArticuloPrincipal As DataTable
    Dim Fl_close As Boolean = False
    Dim Fl_NC_REF As Boolean = False

    Dim _DT_SALDO_INICIAL As DataTable
    Dim _SALDO_INICIAL As Double = 0.0
    Dim _FLAG_INICIAL As Boolean = False
    Dim FLAG_CLIENTE As String
    Dim _ARTS_INICIALES As String = String.Empty
    Dim _CANT_INICIALES As Double = 0.0

    Dim TIPO_DEV, NUM_DEV, POSICION_DEV As String

    Dim NumeracionGuiaRemision, NumeracionFacturacion, NumeracionFacturaNotac, NumeracionFacturaNotaD, NumeracionFacturaCP As String
    Dim vuelto As Double, monto_soles As Double, monto_dolares As Double, monto_visa As Double, monto_mastercard As Double, monto_american_expres As Double, monto_diners_club As Double
    Dim num_operacion_visa As String, num_operacion_master As String, num_operacion_diners As String, num_operacion_american As String
    Dim Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, ref_fecha_doc, Ref_ALMACEN As String
    Dim Ref_GUIA_DOCUMENT_ID, Ref_GUIA_NUMBER_SERIE, Ref_GUIA_NUMBER_DOCUMENT As String
    Dim Ref_CP_DOCUMENT_ID, Ref_CP_NUMBER_SERIE, Ref_CP_NUMBER_DOCUMENT As String

    Dim Flag_ComprobPerc As Boolean = False
    Dim Flag_Detraccion As Boolean = False

    Dim indicadorG As Boolean = True
    Dim Tipo_cancelacion As String
    Dim TipoNumeracion As String
    Dim TipoNumeracionCp As String
    Dim ListaDocCliente As List(Of String)
    Dim NumerosDocClientes As String
    Dim PorcentajePercepcion, PorcentajeDetraccion As String

    Dim cabeceraBL As LibCobranzas.ClsOperaciones.RECEIVABLE
    Dim cabeceraBE As LibCobranzas.ClsEntidades.RECEIVABLE
    Dim carteraBE As LibCobranzas.ClsEntidades.CUSTOMER_BALANCE
    Dim detalle As LibCobranzas.ClsEntidades.RECEIVABLE_LINE
    Dim ls_det As List(Of LibCobranzas.ClsEntidades.RECEIVABLE_LINE)
    Dim ls_det_alm As List(Of LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE)
    Dim ListaGuia_Alm As List(Of LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE)
    Dim ListaGuiaCab_alm As List(Of LibCobranzas.ClsEntidades.WAREHOUSE_TRANS)
    Dim alm_cabBE As LibCobranzas.ClsEntidades.WAREHOUSE_TRANS
    Dim alm_detBE As LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE
    Dim numeracionBE As LibCobranzas.ClsEntidades.NUMBER_DOCUMENT


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
    Dim dtCabeceraFact_otro As DataTable
    Dim dtDetalleFact As DataTable
    Dim dtValidacion As DataTable
    Dim _GENERA_DETRACCION As String
    Dim _GENERA_COMP_PER As String
    Dim _GENERA_ESTADO_CUENTA As String
    Dim _GENERA_FACTURA_ELECTRONICA As String
    Dim _GENERA_GUIA_ELECTRONICA As String
    Dim po_TasaIgv As Double
    Dim Igv As Double = 0.0
    Dim Isc As Double = 0.0
    Dim po_TasaIsc As Double

    Dim ListaDatosArticulo As New List(Of StructuraPart)
    Dim ListaCompleta As New List(Of StructuraPart)

    Dim Dt_principal_lista_Doc_Ref As DataTable
    Public IGV_POR_ITEM As Double
    Public IGV_GENERAL As Double
    Public TIPO_ISC As Double
    Public ISC_POR As Double
    Dim clsArticuloBl As ClsOperaciones.PART
    Dim dtDocumentoGuias As DataTable
    Public Flag_Modo_Edicion As Boolean = False
    Dim _txt_unidad_producto As String
    Dim Codigo As String
    Private mySetting As NameValueCollection
    Dim ID_COMUNICACION_BAJA_ As String
    Protected dtHelp As New DataTable
    Dim dtAccesoVendedor As DataTable
    Dim clsVendedorBl As ClsTransacciones.clsVendedores

    Dim _numero_pedido As String
    Dim _item As String
    Dim _codigo_producto As String

    Private Sub FrmFacturacionRapida_Despachos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboopcionesBusqueda.SelectedIndex = 1
        cboopcionesdespacho.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        dtpfechafinal.Value = ClsVarComun.FechaSistema
        dtpfechaInicial.Value = ClsVarComun.FechaSistema
        Call Cargar_Moneda()
        btnImprimir.Visible = NIVEL_ACCESO()
        txtFiltro.Select()
    End Sub

    Public Sub GenerarColummnaDataTable_Documento_Referencia()
        Try
            Dt_principal_lista_Doc_Ref = New DataTable
            Dt_principal_lista_Doc_Ref.Columns.Add("TIPO_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("SERIE_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("NUM_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("FECHA_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("MONTO", Type.GetType("System.Double"))
            Dt_principal_lista_Doc_Ref.Columns.Add("IGV", Type.GetType("System.Double"))
            'dgv_Lista_Doc_Ref.DataSource = Nothing
            'dgv_Lista_Doc_Ref.DataSource = Dt_principal_lista_Doc_Ref
            'dgv_Lista_Doc_Ref.Columns(0).Width = 40
            'dgv_Lista_Doc_Ref.Columns(1).Width = 50
            'dgv_Lista_Doc_Ref.Columns(2).Width = 80
            'dgv_Lista_Doc_Ref.Columns(3).Width = 80
            'dgv_Lista_Doc_Ref.Columns(4).Width = 80
            'dgv_Lista_Doc_Ref.Columns(5).Width = 80
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    ''Contabilidad

    Private Function Contabilizar(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Contabilizar(TipoDoc, SerieDoc, NumDoc) Then
                MsgBox("Proceso de Contabilización generado correctamente.", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "CODIGO"
        cboMoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub

    Private Sub DocumentosFactura()
        Try
            Me.Cursor = Cursors.WaitCursor
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtv = New DataView

            Dim dtdocumentoPrin As DataTable
            dtdocumentoPrin = New DataTable
            dtdocumentoPrin = clsPedidoBl.get_DatosGeneralesPedido_Despachos(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                   cboopcionesBusqueda.SelectedIndex, CodigoVendedor, tipo_Vendedor, cboopcionesdespacho.SelectedIndex)
            dgvDocumentosFactura.DataSource = Nothing
            STRorden = ""
            If dtdocumentoPrin.Rows.Count() <> 0 Then
                dtv = dtdocumentoPrin.DefaultView
                dgvDocumentosFactura.DataSource = dtv

                dgvDocumentosFactura.Columns("Numero").Width = 60
                dgvDocumentosFactura.Columns("Emision").Width = 70
                dgvDocumentosFactura.Columns("Codigo").Width = 80
                dgvDocumentosFactura.Columns("Cliente").Width = 300
                dgvDocumentosFactura.Columns("Monto").Width = 100
                dgvDocumentosFactura.Columns("Moneda").Width = 50
                dgvDocumentosFactura.Columns("Tipo.Cambio").Width = 100
                dgvDocumentosFactura.Columns("Situacion").Width = 100
                dgvDocumentosFactura.Columns("Estado.Facturacion").Width = 150
                dgvDocumentosFactura.Columns("Tipo.Ref").Width = 100
                dgvDocumentosFactura.Columns("Serie.Ref").Width = 100
                dgvDocumentosFactura.Columns("Numero.Ref").Width = 100
                dgvDocumentosFactura.Columns("Vendedor").Width = 150
                dgvDocumentosFactura.Columns("FECHA_APROBACION").Width = 150
                dgvDocumentosFactura.Columns("FECHA_DESPACHO").Width = 150
                dgvDocumentosFactura.Columns("ESTADO_OP").Width = 150

                dgvDocumentosFactura.Columns("Numero").HeaderText = "N° Pedido"
                dgvDocumentosFactura.Columns("Emision").HeaderText = "Fecha"
                dgvDocumentosFactura.Columns("FECHA_APROBACION").HeaderText = "Fecha y Hora Aprobación"
                dgvDocumentosFactura.Columns("FECHA_DESPACHO").HeaderText = "Fecha y Hora Despacho"
                dgvDocumentosFactura.Columns("Punto.Venta").Visible = False
                dgvDocumentosFactura.Columns("Monto").DefaultCellStyle.Format = "N2"
                dgvDocumentosFactura.Columns("Monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvDocumentosFactura.Columns("Tipo.Cambio").Visible = False
                dgvDocumentosFactura.Columns("Situacion").HeaderText = "Estado Pedido"
                dgvDocumentosFactura.Columns("Estado.Facturacion").Visible = False '.HeaderText = "Estado Facturación"
                dgvDocumentosFactura.Columns("Tipo.Ref").Visible = False '.HeaderText = "Tipo Ref."
                dgvDocumentosFactura.Columns("Serie.Ref").Visible = False '.HeaderText = "Serie Ref."
                dgvDocumentosFactura.Columns("Numero.Ref").Visible = False '.HeaderText = "N° Doc. Ref."

                dgvDocumentosFactura.Columns("Estado.Despacho").Width = 150
                dgvDocumentosFactura.Columns("Responsable.Despacho").Width = 200
                dgvDocumentosFactura.Columns("Vehiculo.Despacho").Width = 200
                dgvDocumentosFactura.Columns("FECHA_APROBACION").DisplayIndex = 3
                dgvDocumentosFactura.Columns("FECHA_DESPACHO").DisplayIndex = 11
                dgvDocumentosFactura.Columns("FECHA_ENTREGA").DisplayIndex = 11

                dgvDocumentosFactura.Columns("Estado.Despacho").HeaderText = "Estado de Despacho"
                dgvDocumentosFactura.Columns("Responsable.Despacho").HeaderText = "Responsable de Despacho"
                dgvDocumentosFactura.Columns("Vehiculo.Despacho").HeaderText = "Vehiculo de Despacho"
                dgvDocumentosFactura.Columns("ESTADO_OP").HeaderText = "Estado de O.P."

                dgvDocumentosFactura.Columns("FECHA_ENTREGA").HeaderText = "Fecha Entrega"
                dgvDocumentosFactura.Columns("FECHA_ENTREGA").Width = 80
                dgvDocumentosFactura.Columns("FECHA_ENTREGA").DefaultCellStyle.Format = "dd/MM/yyyy"

                dgvDocumentosFactura.Columns("FECHA_INICIO_PICKING").HeaderText = "F.Inicio Picking"
                dgvDocumentosFactura.Columns("FECHA_INICIO_PICKING").Width = 120

                dgvDocumentosFactura.Columns("PC_PICKING").HeaderText = "PC I.Picking"
                dgvDocumentosFactura.Columns("USER_PICKING").HeaderText = "Usuario I.Picking"

                dgvDocumentosFactura.Columns("id_cab").Visible = False

                STRorden = dgvDocumentosFactura.Columns("Numero").Name & "+" & dgvDocumentosFactura.Columns("Codigo").Name & "+" & dgvDocumentosFactura.Columns("Cliente").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            If Modo_consultar = True Then
                btnGrabar.Enabled = False
                btn_habilitar_facturacion.Enabled = False
            Else
                btnGrabar.Enabled = True
                btn_habilitar_facturacion.Enabled = True
            End If
            If Modo_editar = True Then btnGrabar.Enabled = True
            btnConsultar.Enabled = False
            btnPicking.Enabled = False
            btn_programar_despacho.Enabled = False
            btnImprimir.Enabled = False
            btn_imprimir_tk.Enabled = False
            btnCancelar.Enabled = True
            lblCantidad.Visible = False
        Else
            btnGrabar.Enabled = False
            btn_habilitar_facturacion.Enabled = False
            btnConsultar.Enabled = True
            btnPicking.Enabled = True
            btn_programar_despacho.Enabled = True
            btnImprimir.Enabled = True
            btn_imprimir_tk.Enabled = True
            btnCancelar.Enabled = False
            lblCantidad.Visible = True
        End If
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
            dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double")) '2
            dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String")) '4
            dtdetalleArticuloPrincipal.Columns.Add("LOTE", Type.GetType("System.String")) '5
            dtdetalleArticuloPrincipal.Columns.Add("PREC_UNITARIO", Type.GetType("System.Double")) '6
            dtdetalleArticuloPrincipal.Columns.Add("%DESC.ART_1", Type.GetType("System.Double")) '7
            dtdetalleArticuloPrincipal.Columns.Add("%DESC.ART_2", Type.GetType("System.Double")) '8
            dtdetalleArticuloPrincipal.Columns.Add("VALOR_VENTA", Type.GetType("System.Double")) '9
            dtdetalleArticuloPrincipal.Columns.Add("IMP_DESC_01", Type.GetType("System.Double")) '10
            dtdetalleArticuloPrincipal.Columns.Add("IMP_DESC_02", Type.GetType("System.Double")) '11
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_IGV", Type.GetType("System.Double")) '12
            dtdetalleArticuloPrincipal.Columns.Add("IGV_ART", Type.GetType("System.Double")) '13
            dtdetalleArticuloPrincipal.Columns.Add("IGV_ART_US", Type.GetType("System.Double")) '14
            dtdetalleArticuloPrincipal.Columns.Add("IMPORTE", Type.GetType("System.Double")) '15
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_INICIAL", Type.GetType("System.Double")) '16
            dtdetalleArticuloPrincipal.Columns.Add("TOTAL_INICIAL", Type.GetType("System.Double")) '17
            dtdetalleArticuloPrincipal.Columns.Add("IGV_POR", Type.GetType("System.Double")) '18
            dtdetalleArticuloPrincipal.Columns.Add("TIPO", Type.GetType("System.String")) '19
            dtdetalleArticuloPrincipal.Columns.Add("PESO_NETO", Type.GetType("System.Double")) '20
            dtdetalleArticuloPrincipal.Columns.Add("PESO_BRUTO", Type.GetType("System.Double")) '21
            dtdetalleArticuloPrincipal.Columns.Add("ITEM_INI", Type.GetType("System.String")) '22
            dtdetalleArticuloPrincipal.Columns.Add("OBSERVACIONES", Type.GetType("System.String")) '23
            dtdetalleArticuloPrincipal.Columns.Add("DOC_REF", Type.GetType("System.String")) '24
            dtdetalleArticuloPrincipal.Columns.Add("NUM_REF", Type.GetType("System.String")) '25
            dtdetalleArticuloPrincipal.Columns.Add("ITEM_REF", Type.GetType("System.Int64")) '26
            dtdetalleArticuloPrincipal.Columns.Add("TIPOISC", Type.GetType("System.Int64")) '27
            dtdetalleArticuloPrincipal.Columns.Add("ISCPOR", Type.GetType("System.Double")) '28
            dtdetalleArticuloPrincipal.Columns.Add("ISC", Type.GetType("System.Double")) '29
            dtdetalleArticuloPrincipal.Columns.Add("PRESENTACION", Type.GetType("System.String")) '30
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD_FRACCION", Type.GetType("System.Double")) '31

            dtdetalleArticuloPrincipal.Columns.Add("PREC_UNITARIO_FRACCION", Type.GetType("System.Double")) '32
            dtdetalleArticuloPrincipal.Columns.Add("VALOR_VENTA_FRACCION", Type.GetType("System.Double")) '33
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_IGV_FRACCION", Type.GetType("System.Double")) '34
            dtdetalleArticuloPrincipal.Columns.Add("IGV_ART_FRACCION", Type.GetType("System.Double")) '35
            dtdetalleArticuloPrincipal.Columns.Add("IMPORTE_FRACCION", Type.GetType("System.Double")) '36
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_INICIAL_FRACCION", Type.GetType("System.Double")) '37
            dtdetalleArticuloPrincipal.Columns.Add("TOTAL_INICIAL_FRACCION", Type.GetType("System.Double")) '38
            dtdetalleArticuloPrincipal.Columns.Add("TOTAL", Type.GetType("System.Double")) '39
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_CON_IGV", Type.GetType("System.String")) '40
            dtdetalleArticuloPrincipal.Columns.Add("ESTADO_OP", Type.GetType("System.String")) '40
            dtdetalleArticuloPrincipal.Columns.Add("NUMERO_OP", Type.GetType("System.String")) '40
            dtdetalleArticuloPrincipal.Columns.Add("Sel", Type.GetType("System.Boolean"))
            dtdetalleArticuloPrincipal.Columns.Add("SALDO", Type.GetType("System.Double")) '38
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD_HABILITADO", Type.GetType("System.Double")) '38
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD_FACTURADO", Type.GetType("System.Double")) '38

            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            'dgvDetalle.AutoResizeColumns()
            'dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'dgvDetalle.Columns(0).HeaderText = "ITEM"
            'dgvDetalle.Columns(1).HeaderText = "CODIGO"
            'dgvDetalle.Columns(2).HeaderText = "CANTIDAD"
            'dgvDetalle.Columns("SALDO").HeaderText = "SALDO"
            'dgvDetalle.Columns("CANTIDAD_HABILITADO").HeaderText = "CANTIDAD HABILITADO PARA FACTURAR"
            'dgvDetalle.Columns("CANTIDAD_FACTURADO").HeaderText = "CANTIDAD FACTURADO"
            'dgvDetalle.Columns(31).Visible = False ' "CANTIDAD FRAC."
            'dgvDetalle.Columns(3).HeaderText = "UM"
            'dgvDetalle.Columns(4).HeaderText = "DESCRIPCION"
            'dgvDetalle.Columns(30).Visible = False '.HeaderText = "PRESENTACION"
            'dgvDetalle.Columns(5).Visible = False '"LOTE"
            'dgvDetalle.Columns(12).HeaderText = "PRECIO "
            'dgvDetalle.Columns(34).Visible = False ' "PRECIO FRAC."
            'dgvDetalle.Columns(7).Visible = False '.HeaderText = "%.Desc.Articulo"
            'dgvDetalle.Columns(8).Visible = False '.HeaderText = "%.Desc.Articulo.2"
            'dgvDetalle.Columns(15).Visible = False '.HeaderText = "TOTAL"
            'dgvDetalle.Columns(39).HeaderText = "TOTAL"
            'dgvDetalle.Columns(40).Visible = False
            'dgvDetalle.Columns(36).Visible = False
            'dgvDetalle.Columns(10).Visible = False '.HeaderText = "Importe.desc"
            'dgvDetalle.Columns(11).Visible = False '.HeaderText = "Importe.desc.2"
            'dgvDetalle.Columns(6).Visible = False
            'dgvDetalle.Columns(32).Visible = False
            'dgvDetalle.Columns(13).Visible = False
            'dgvDetalle.Columns(35).Visible = False
            'dgvDetalle.Columns(14).Visible = False
            'dgvDetalle.Columns(9).Visible = False
            'dgvDetalle.Columns(33).Visible = False
            'dgvDetalle.Columns(16).Visible = False
            'dgvDetalle.Columns(37).Visible = False
            'dgvDetalle.Columns(17).Visible = False
            'dgvDetalle.Columns(38).Visible = False
            'dgvDetalle.Columns(18).Visible = False '.HeaderText = "% I.G.V"
            'dgvDetalle.Columns(19).Visible = False
            'dgvDetalle.Columns(20).Visible = False '.HeaderText = "Peso Neto"
            'dgvDetalle.Columns(21).Visible = False '.HeaderText = "Peso Bruto"
            'dgvDetalle.Columns(22).Visible = False
            'dgvDetalle.Columns(23).Visible = False '.HeaderText = "Observaciones"

            'dgvDetalle.Columns(24).Visible = False '.HeaderText = "Doc. Referencia"
            'dgvDetalle.Columns(25).Visible = False '.HeaderText = "N° Referencia"
            'dgvDetalle.Columns(26).Visible = False '.HeaderText = "Item Referencia"
            'dgvDetalle.Columns(27).Visible = False '.HeaderText = "Item Referencia"

            'For i As Integer = 0 To dgvDetalle.Columns.Count - 1
            '    dgvDetalle.Columns(i).ReadOnly = True
            'Next

            'dgvDetalle.Columns("CANTIDAD").ReadOnly = False
            'dgvDetalle.Columns("SALDO").ReadOnly = False
            'dgvDetalle.Columns("CANTIDAD_FRACCION").ReadOnly = False

            'dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.00"
            'dgvDetalle.Columns("SALDO").DefaultCellStyle.Format = "##,##0.00"
            'dgvDetalle.Columns("CANTIDAD_HABILITADO").DefaultCellStyle.Format = "##,##0.00"
            'dgvDetalle.Columns("CANTIDAD_FACTURADO").DefaultCellStyle.Format = "##,##0.00"
            'dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Format = "##,##0.00"
            'dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Format = "##,##0.0000"
            'dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Format = "##,##0.0000"
            'dgvDetalle.Columns("%DESC.ART_1").DefaultCellStyle.Format = "##,##0.00"
            'dgvDetalle.Columns("%DESC.ART_2").DefaultCellStyle.Format = "##,##0.00"
            'dgvDetalle.Columns("TOTAL").DefaultCellStyle.Format = "##,##0.00"
            'dgvDetalle.Columns("IMP_DESC_01").DefaultCellStyle.Format = "##,##0.0000"
            'dgvDetalle.Columns("IMP_DESC_02").DefaultCellStyle.Format = "##,##0.0000"

            'dgvDetalle.Columns("PESO_NETO").DefaultCellStyle.Format = "##,##0.000"
            'dgvDetalle.Columns("PESO_BRUTO").DefaultCellStyle.Format = "##,##0.000"

            'dgvDetalle.Columns("ISCPOR").DefaultCellStyle.Format = "##,##0.00"
            'dgvDetalle.Columns("ISC").DefaultCellStyle.Format = "##,##0.000"

            'dgvDetalle.Columns("ISCPOR").Visible = False ' "% I.S.C."
            'dgvDetalle.Columns("ISC").Visible = False ' "I.S.C."
            'dgvDetalle.Columns("SALDO").Visible = True ' "I.S.C."
            'dgvDetalle.Columns("CANTIDAD_HABILITADO").Visible = True ' "I.S.C."
            'dgvDetalle.Columns("CANTIDAD_FACTURADO").Visible = True ' "I.S.C."


            'dgvDetalle.Columns("ITEM").DisplayIndex = 0
            'dgvDetalle.Columns("CODIGO").DisplayIndex = 1
            'dgvDetalle.Columns("DESCRIPCION").DisplayIndex = 2
            'dgvDetalle.Columns("PRESENTACION").DisplayIndex = 3
            'dgvDetalle.Columns("UNIDAD").DisplayIndex = 4
            'dgvDetalle.Columns("CANTIDAD").DisplayIndex = 5
            'dgvDetalle.Columns("CANTIDAD_FRACCION").DisplayIndex = 6
            'dgvDetalle.Columns("PRECIO_IGV").DisplayIndex = 7
            'dgvDetalle.Columns("PRECIO_IGV_FRACCION").DisplayIndex = 8
            'dgvDetalle.Columns("TOTAL").DisplayIndex = 9
            'dgvDetalle.Columns("LOTE").DisplayIndex = 10
            'dgvDetalle.Columns("SEL").DisplayIndex = 11
            'dgvDetalle.Columns("SALDO").DisplayIndex = 12
            'dgvDetalle.Columns("CANTIDAD_HABILITADO").DisplayIndex = 13
            'dgvDetalle.Columns("CANTIDAD_FACTURADO").DisplayIndex = 14

            'dgvDetalle.Columns("ITEM").Width = 25
            'dgvDetalle.Columns("CODIGO").Width = 100
            'dgvDetalle.Columns("DESCRIPCION").Width = 350
            'dgvDetalle.Columns("PRESENTACION").Width = 100
            'dgvDetalle.Columns("UNIDAD").Width = 45
            'dgvDetalle.Columns("LOTE").Width = 100
            'dgvDetalle.Columns("CANTIDAD").Width = 60
            'dgvDetalle.Columns("SALDO").Width = 60
            'dgvDetalle.Columns("CANTIDAD_HABILITADO").Width = 60
            'dgvDetalle.Columns("CANTIDAD_FACTURADO").Width = 60
            'dgvDetalle.Columns("CANTIDAD_FRACCION").Width = 60
            'dgvDetalle.Columns("PRECIO_IGV").Width = 60
            'dgvDetalle.Columns("PRECIO_IGV_FRACCION").Width = 60
            'dgvDetalle.Columns("TOTAL").Width = 60

            'dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("CANTIDAD_HABILITADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("CANTIDAD_FACTURADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("PREC_UNITARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("PREC_UNITARIO_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("VALOR_VENTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("VALOR_VENTA_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("ISCPOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvDetalle.Columns("ISC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Nuevo()
        Try
            pnlPrincipal.Visible = False
            Flag_Ref = False
            Button5.Enabled = False
            txt_tip_nota_electronica.Enabled = False
            'gbTipoFacturacion.Enabled = True
            'rbFacturaDirecta.Checked = True
            rbDocRef_uno.Checked = True
            GbCabecera.Enabled = True
            'gbOpciones.Enabled = True
            GbdetalleDocumento.Visible = False
            Limpiar()
            GenerarColummnaDataTable()
            GenerarColummnaDataTable_Documento_Referencia()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NuevaVenta()
        Try
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtCabeceraFact = New DataTable
            dtCabeceraFact = clsFacturaCabBl.get_PuntoVenta_Default()
            If dtCabeceraFact.Rows.Count > 0 Then
                txtPtoVenta.Text = dtCabeceraFact.Rows(0).Item("SALES_PLACE_ID").ToString
                If txtPtoVenta.Text = String.Empty Then
                    Ayuda_PuntoVenta()
                Else
                    Ayuda_PuntoVenta(txtPtoVenta.Text)
                End If
                dtCabeceraFact.Clear()
                dtCabeceraFact = Nothing
                dtCabeceraFact = clsFacturaCabBl.get_Cliente_Default()
                If dtCabeceraFact.Rows.Count > 0 Then
                    txtCodCliente.Text = Trim(dtCabeceraFact.Rows(0).Item("ID").ToString)
                    If txtCodCliente.Text = String.Empty Then
                        Ayuda_Clientes()
                    Else
                        Ayuda_Clientes(txtCodCliente.Text)
                    End If
                End If
                cboTipoDoc.Text = "PF"
                rdb_f_ticket.Checked = True
                chk_facturar_obsequio.Checked = False
                'dgv_lista_productos.DataSource = Nothing
                'chkigv.Checked = True
                'txtdescripcionArticulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MostrarModoConsultar(ByVal DOCUMENT_ID As String, ByVal NUMBER_SERIE As String, ByVal NUMBER_DOCUMENT As String)
        Try
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtCabeceraFact = New DataTable
            dtDetalleFact = New DataTable
            Ref_GUIA_DOCUMENT_ID = ""
            Ref_GUIA_NUMBER_SERIE = ""
            Ref_GUIA_NUMBER_DOCUMENT = ""
            Ref_ALMACEN = ""
            Ref_CP_DOCUMENT_ID = ""
            Ref_CP_NUMBER_SERIE = ""
            Ref_CP_NUMBER_DOCUMENT = ""
            _numero_pedido = ""
            _item = ""
            _codigo_producto = ""
            '---Mostrando Datos de Cabecera
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtCabeceraFact = clsPedidoBl.Modo_Edicion_Cabecera(DOCUMENT_ID)

            If dtCabeceraFact.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraFact.Rows.Count() - 1
                    txtPtoVenta.Text = dtCabeceraFact.Rows(i).Item("PLACE_SALES").ToString
                    txtAlmacen.Text = dtCabeceraFact.Rows(i).Item("WAREHOUSE_ID").ToString
                    lblAlmacen.Text = dtCabeceraFact.Rows(i).Item("ALMACEN_NOMBRE").ToString
                    dtpFechaFactura.Text = dtCabeceraFact.Rows(i).Item("ORDER_DATE").ToString
                    cboTipoDoc.Text = dtCabeceraFact.Rows(0).Item("TRAMA_ID").ToString
                    cboMoneda.SelectedValue = dtCabeceraFact.Rows(i).Item("CURRENCY_ID").ToString
                    txtTipoCambio.Text = dtCabeceraFact.Rows(i).Item("SELL_RATE").ToString
                    txtCodCliente.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRucDni.Text = dtCabeceraFact.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtRazonSocial.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtDireccion.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ADDR").ToString
                    txtVendedor.Text = dtCabeceraFact.Rows(i).Item("SALES_ID").ToString
                    txtFormaPago.Text = dtCabeceraFact.Rows(i).Item("TERMS").ToString
                    lblFormaPago.Text = dtCabeceraFact.Rows(i).Item("FPAGO").ToString
                    txtcotizacion.Text = ""
                    txtordenCompra.Text = dtCabeceraFact.Rows(i).Item("ORDER_PURCHASE").ToString
                    txtpedido.Text = ""
                    txtcodigo.Text = dtCabeceraFact.Rows(i).Item("ID").ToString
                    txt_validez_oferta.Text = dtCabeceraFact.Rows(i).Item("VALIDEZ_OFERTA").ToString
                    txt_fecha_hora_aprobacion.Text = dtCabeceraFact.Rows(i).Item("FECHA_APROBACION").ToString

                    txt_provincia.Text = dtCabeceraFact.Rows(i).Item("PROVINCIA").ToString
                    txt_cod_agencia_trans.Text = dtCabeceraFact.Rows(i).Item("AGENCIA_TRANSPORTE").ToString
                    txt_des_agencia_trans.Text = dtCabeceraFact.Rows(i).Item("AGENCIA_TRANSPORTE_DES").ToString
                    txt_guia.Text = dtCabeceraFact.Rows(i).Item("GUIA").ToString
                    If dtCabeceraFact.Rows(i).Item("AGE_DOMI").ToString = "AGENCIA" Then
                        rdb_agencia.Checked = True
                        rdb_domicilio.Checked = False
                    ElseIf dtCabeceraFact.Rows(i).Item("AGE_DOMI").ToString = "DOMICILIO" Then
                        rdb_agencia.Checked = False
                        rdb_domicilio.Checked = True
                    Else
                        rdb_agencia.Checked = False
                        rdb_domicilio.Checked = False
                    End If

                    txt_lt_ft.Text = dtCabeceraFact.Rows(i).Item("LT_FT").ToString
                    If dtCabeceraFact.Rows(i).Item("CHEQUE").ToString = "SI" Then
                        chk_cheque.Checked = True
                    Else
                        chk_cheque.Checked = False
                    End If

                    txt_cod_transferencia.Text = dtCabeceraFact.Rows(i).Item("TRANSFERENCIA").ToString
                    txt_des_transferencia.Text = dtCabeceraFact.Rows(i).Item("TRANSFERENCIA_DES").ToString
                    txt_n_operacion.Text = dtCabeceraFact.Rows(i).Item("N_OPERACION").ToString
                    txt_obs_general.Text = dtCabeceraFact.Rows(i).Item("OBS_GENERAL").ToString
                    txt_recepcion_tercero.Text = dtCabeceraFact.Rows(i).Item("RECEPCION_TERCERO").ToString
                Next

                '---Mostrando datos del Detalle
                clsPedidoBl = New ClsOperaciones.ORDERS
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsPedidoBl.Modo_Edicion_Detalle2(DOCUMENT_ID)

                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal

                    dgvDetalle.Columns(0).HeaderText = "ITEM"
                    dgvDetalle.Columns(1).HeaderText = "CODIGO"
                    dgvDetalle.Columns(2).HeaderText = "CANTIDAD"
                    dgvDetalle.Columns("SALDO").HeaderText = "SALDO"
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").HeaderText = "CANTIDAD HABILITADO PARA FACTURAR"
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").HeaderText = "CANTIDAD FACTURADO"
                    dgvDetalle.Columns(31).Visible = False ' "CANTIDAD FRAC."
                    dgvDetalle.Columns(3).HeaderText = "UM"
                    dgvDetalle.Columns(4).HeaderText = "DESCRIPCION"
                    dgvDetalle.Columns(30).Visible = False '.HeaderText = "PRESENTACION"
                    dgvDetalle.Columns(5).Visible = False '"LOTE"
                    dgvDetalle.Columns(12).HeaderText = "PRECIO "
                    dgvDetalle.Columns(34).Visible = False ' "PRECIO FRAC."
                    dgvDetalle.Columns(7).Visible = False '.HeaderText = "%.Desc.Articulo"
                    dgvDetalle.Columns(8).Visible = False '.HeaderText = "%.Desc.Articulo.2"
                    dgvDetalle.Columns(15).Visible = False '.HeaderText = "TOTAL"
                    dgvDetalle.Columns(39).HeaderText = "TOTAL"
                    dgvDetalle.Columns(36).Visible = False
                    dgvDetalle.Columns(10).Visible = False '.HeaderText = "Importe.desc"
                    dgvDetalle.Columns(11).Visible = False '.HeaderText = "Importe.desc.2"
                    dgvDetalle.Columns(6).Visible = False
                    dgvDetalle.Columns(32).Visible = False
                    dgvDetalle.Columns(13).Visible = False
                    dgvDetalle.Columns(35).Visible = False
                    dgvDetalle.Columns(14).Visible = False
                    dgvDetalle.Columns(9).Visible = False
                    dgvDetalle.Columns(33).Visible = False
                    dgvDetalle.Columns(16).Visible = False
                    dgvDetalle.Columns(37).Visible = False
                    dgvDetalle.Columns(17).Visible = False
                    dgvDetalle.Columns(38).Visible = False
                    dgvDetalle.Columns(18).Visible = False '.HeaderText = "% I.G.V"
                    dgvDetalle.Columns(19).Visible = False
                    dgvDetalle.Columns(20).Visible = False '.HeaderText = "Peso Neto"
                    dgvDetalle.Columns(21).Visible = False '.HeaderText = "Peso Bruto"
                    dgvDetalle.Columns(22).Visible = False
                    dgvDetalle.Columns(23).Visible = False '.HeaderText = "Observaciones"
                    dgvDetalle.Columns(24).Visible = False '.HeaderText = "Doc. Referencia"
                    dgvDetalle.Columns(25).Visible = False '.HeaderText = "N° Referencia"
                    dgvDetalle.Columns(26).Visible = False '.HeaderText = "Item Referencia"
                    dgvDetalle.Columns(27).Visible = False '.HeaderText = "Item Referencia"

                    dgvDetalle.Columns("ESTADO_OP").HeaderText = "ESTADO REQ. O.P."
                    dgvDetalle.Columns("NUMERO_OP").HeaderText = "N° REQ. O.P."

                    For i As Integer = 0 To dgvDetalle.Columns.Count - 1
                        dgvDetalle.Columns(i).ReadOnly = True
                    Next

                    'dgvDetalle.Columns("CANTIDAD").ReadOnly = False
                    dgvDetalle.Columns("SALDO").ReadOnly = False
                    dgvDetalle.Columns("SEL").ReadOnly = False

                    dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("SALDO").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("%DESC.ART_1").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("%DESC.ART_2").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("TOTAL").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("IMP_DESC_01").DefaultCellStyle.Format = "##,##0.0000"
                    dgvDetalle.Columns("IMP_DESC_02").DefaultCellStyle.Format = "##,##0.0000"
                    dgvDetalle.Columns("PESO_NETO").DefaultCellStyle.Format = "##,##0.000"
                    dgvDetalle.Columns("PESO_BRUTO").DefaultCellStyle.Format = "##,##0.000"
                    dgvDetalle.Columns("ISCPOR").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("ISC").DefaultCellStyle.Format = "##,##0.000"
                    dgvDetalle.Columns("ISCPOR").Visible = False ' "% I.S.C."
                    dgvDetalle.Columns("ISC").Visible = False ' "I.S.C."
                    dgvDetalle.Columns("PRECIO_CON_IGV").Visible = False ' "I.S.C."
                    dgvDetalle.Columns("CANTIDAD_MAXIMA").Visible = False ' "I.S.C."

                    dgvDetalle.Columns("ITEM").DisplayIndex = 0
                    dgvDetalle.Columns("CODIGO").DisplayIndex = 1
                    dgvDetalle.Columns("DESCRIPCION").DisplayIndex = 2
                    dgvDetalle.Columns("PRESENTACION").DisplayIndex = 3
                    dgvDetalle.Columns("UNIDAD").DisplayIndex = 4
                    dgvDetalle.Columns("CANTIDAD").DisplayIndex = 5
                    dgvDetalle.Columns("CANTIDAD_FRACCION").DisplayIndex = 6
                    dgvDetalle.Columns("PRECIO_IGV").DisplayIndex = 7
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").DisplayIndex = 8
                    dgvDetalle.Columns("TOTAL").DisplayIndex = 9
                    dgvDetalle.Columns("LOTE").DisplayIndex = 10
                    dgvDetalle.Columns("SEL").DisplayIndex = 11
                    dgvDetalle.Columns("SALDO").DisplayIndex = 12
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").DisplayIndex = 13
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").DisplayIndex = 14

                    dgvDetalle.Columns("ITEM").Width = 25
                    dgvDetalle.Columns("CODIGO").Width = 100
                    dgvDetalle.Columns("DESCRIPCION").Width = 350
                    dgvDetalle.Columns("PRESENTACION").Width = 100
                    dgvDetalle.Columns("UNIDAD").Width = 45
                    dgvDetalle.Columns("LOTE").Width = 100
                    dgvDetalle.Columns("CANTIDAD").Width = 60
                    dgvDetalle.Columns("SALDO").Width = 60
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").Width = 60
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").Width = 60
                    dgvDetalle.Columns("CANTIDAD_FRACCION").Width = 60
                    dgvDetalle.Columns("PRECIO_IGV").Width = 60
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").Width = 60
                    dgvDetalle.Columns("TOTAL").Width = 60

                    dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("PREC_UNITARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("PREC_UNITARIO_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("VALOR_VENTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("VALOR_VENTA_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("ISCPOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("ISC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    dgvDetalle.AutoResizeColumns()
                    dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    chkSinIGV.Checked = Not Precio_Con_Sin_IGV()
                    Calcular_Totales()

                Else
                    MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                    ''CALCULANDO TOTALES GENERALES
                    
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If dgvDocumentosFactura.RowCount() = 0 Then Exit Sub
            If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
            Modo_consultar = True
            Modo_editar = False
            Modo_programar = False
            Ref_DOCUMENT_ID = ""
            Ref_DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
            Ref_NUMBER_SERIE = String.Empty
            Ref_NUMBER_DOCUMENT = String.Empty
            'If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Me.Cursor = Cursors.WaitCursor : Exit Sub
            'Mostrando resultados
            Ayuda_TipoDocPuntoVenta()
            MostrarModoConsultar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)

            pnlPrincipal.Visible = False
            'GbdetalleDocumento.Visible = True
            Call Botonera_Estado_Cambiar(True)

            Dim Status_order As String = ""
            Status_order = dgvDocumentosFactura.CurrentRow.Cells("Situacion").Value

            If Status_order = "ANULADO" Then
                btnGrabar.Enabled = False
                btn_habilitar_facturacion.Enabled = False
            Else
                Status_order = dgvDocumentosFactura.CurrentRow.Cells("Estado.Despacho").Value

                If Status_order = "DESPACHADO" Then
                    btnGrabar.Enabled = False
                    btn_habilitar_facturacion.Enabled = False
                Else
                    btnGrabar.Enabled = True
                    btn_habilitar_facturacion.Enabled = True
                End If
            End If
            btnGrabar.Text = "Despachar"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
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
            frmTipoNum.Serie = cbSerieGuia.Text
            frmTipoNum.TipoDocumento = "GS"
            frmTipoNum.txtTitulo.Text = "GUIA"
            If Modo_editar = True Then
                frmTipoNum.Modo_edicion = True
                frmTipoNum.Numero_edicion = Ref_GUIA_NUMBER_SERIE & Ref_GUIA_NUMBER_DOCUMENT
            End If
            frmTipoNum.ShowDialog()
            If frmTipoNum.fl_datos = False Then
                estado = False
                frmTipoNum.Close()
                Exit Try
            End If
            NumeracionGuiaRemision = String.Empty
            TipoNumeracion = String.Empty
            NumeracionGuiaRemision = frmTipoNum.NumeracionGeneral
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
            If Modo_editar = True Then
                frmTipoNum.Modo_edicion = True
                frmTipoNum.Numero_edicion = Ref_NUMBER_DOCUMENT
            End If
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

    Private Function CodigoNumeraciondocumentoGeneral() As Boolean
        Dim estado As Boolean = True
        'Try
        '    If Modo_editar = True Then
        '        clsAlmacenBl = New ClsTransacciones.clsAlmacen
        '        TipoNumeracion = String.Empty
        '        NumeracionFacturacion = Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
        '        TipoNumeracion = "A"
        '    Else
        '        clsAlmacenBl = New ClsTransacciones.clsAlmacen
        '        clsAlmacenBl.Get_NumeroGuiaRemision(cboSerieDoc.Text, cboTipoDoc.Text)
        '        TipoNumeracion = String.Empty
        '        NumeracionFacturacion = CStr(clsAlmacenBl.NUMBER_SERIE & String.Format("{0:0000000}", CInt(clsAlmacenBl.LAST_NUMBER + 1)))
        '        TipoNumeracion = "A"
        '    End If
        'Catch ex As Exception
        '    estado = False
        'End Try
        'Return estado

        'Dim estado As Boolean = True
        Try
            Dim frmTipoNum As New FrmTipoNumeracion
            frmTipoNum.Serie = cboSerieDoc.Text
            frmTipoNum.TipoDocumento = cboTipoDoc.Text '"NC"
            frmTipoNum.Almacen = txtAlmacen.Text
            frmTipoNum.txtTitulo.Text = cboTipoDoc.Text '"NOTA DE CREDITO"
            If Modo_editar = True Then
                frmTipoNum.Modo_edicion = True
                frmTipoNum.Numero_edicion = Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
            End If
            frmTipoNum.ShowDialog()
            If frmTipoNum.fl_datos = False Then
                estado = False
                frmTipoNum.Close()
                Exit Try
            End If
            NumeracionFacturacion = String.Empty
            vuelto = 0.0
            monto_soles = 0.0
            monto_dolares = 0.0
            monto_visa = 0.0
            monto_mastercard = 0.0
            monto_american_expres = 0.0
            monto_diners_club = 0.0

            num_operacion_visa = ""
            num_operacion_master = ""
            num_operacion_diners = ""
            num_operacion_american = ""

            TipoNumeracion = String.Empty
            NumeracionFacturacion = frmTipoNum.NumeracionGeneral
            TipoNumeracion = frmTipoNum.TipoNumeracion

            frmTipoNum.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
            If Modo_editar = True Then
                frmTipoNum.Modo_edicion = True
                frmTipoNum.Numero_edicion = Ref_NUMBER_DOCUMENT
            End If
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
            If Modo_editar = True Then
                frmTipoNum.Modo_edicion = True
                frmTipoNum.Numero_edicion = Ref_NUMBER_DOCUMENT
            End If
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
            frmTipoNum.txtTitulo.Text = "COMPROBANTE PERCEPCION"
            If Modo_editar = True Then
                frmTipoNum.Modo_edicion = True
                frmTipoNum.Numero_edicion = Ref_CP_NUMBER_SERIE & Ref_CP_NUMBER_DOCUMENT
            End If
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

    Public Sub validar_Fecha()
        Dim FechaIngr As Date
        FechaIngr = dtpFechaFactura.Value
        Dim facturacionBl As New ClsOperaciones.RECEIVABLE
        Dim dtFecha As New DataTable("TipoCambioFecha")
        Dim Sql = String.Empty
        Sql = "SELECT ISNULL(SELL_RATE,0) [SELL_RATE] FROM CURRENCY_EXCHANGE WHERE CURRENCY_DATE='" & FechaIngr.ToShortDateString & "'"
        dtFecha = facturacionBl.Muestra_consulta(Sql)
        If dtFecha.Rows.Count() <> 0 Then
            txtTipoCambio.Text = CDbl(dtFecha.Rows(0).Item("SELL_RATE"))
            txtTipoCambio.Text = Format(CDbl(txtTipoCambio.Text), "##,##0.000")
            'SendKeys.Send("{TAB}")
            'If rb_facturar_devolucion.Checked Then
            '    txtNumDocRef.Select()
            '    txtNumDocRef.ReadOnly = True
            'Else
            '    cboTipoDoc.Select()
            '    txtNumDocRef.ReadOnly = False
            'End If

        Else
            MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
            txtTipoCambio.Text = String.Empty
            dtpFechaFactura.Focus()
        End If
    End Sub

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

            Dim planilladetBE As ClsEntidades.RECEIVABLE_LIST_LINE
            Dim ls_detalle As New List(Of ClsEntidades.RECEIVABLE_LIST_LINE)

            With cabeceraBE
                .DOCUMENT_ID = cboTipoDoc.Text
                .NUMBER_SERIE = cboSerieDoc.Text
                .NUMBER_DOCUMENT = NumeracionFacturacion
                .DOCUMENT_DATE = dtpFechaFactura.Value.ToString("dd/MM/yyyy")
                .CADUCATE_DATE = Get_FormaPagoFechaVencimiento()
                .DR_CR = "D"
                .SALES_REP_ID = txtVendedor.Text
                .PLACE_SALES = txtPtoVenta.Text
                .NUMBER_QUOTE = txtcotizacion.Text
                .NUMBER_ORDER_PUR = txtordenCompra.Text
                'If rbunalineaDoc.Checked Then
                '    .CFDESCPG = 0
                'ElseIf rbVariaslineasDoc.Checked Then
                '    .CFDESCPG = 1
                'End If
                .POINT_ORIG = 0
                .POINT_BOARD = 0
                .POINT_ARRIVAL = 0
                If chk_facturar_obsequio.Checked Then
                    .RECEIVABLE_TYPE = "FO"
                Else
                    .RECEIVABLE_TYPE = cboTipoDoc.Text
                End If
                '.RECEIVABLE_TYPE = cboTipoDoc.Text
                .CUSTOMER_ID = txtCodCliente.Text.Trim
                .CUSTOMER_NAME = txtRazonSocial.Text.Trim
                .CUSTOMER_ADDR = txtDireccion.Text.Trim
                .VAT_REGISTRATION = txtRucDni.Text.Trim
                .WAREHOUSE_ID = txtAlmacen.Text
                .AMOUNT = 0
                .TERMS_ID = txtFormaPago.Text.Trim
                .BALANCE = 0
                .SELL_RATE = CDbl(txtTipoCambio.Text)
                .CURRENCY_ID = cboMoneda.SelectedValue
                If checkSinGuia.Checked = False Then
                    .DOCUMENT_REF = "GS"
                    .SERIE_REF = cbSerieGuia.Text
                    'If rbFacturaRepMedico.Checked Then
                    '    .NUMBER_REF = NumerosDocClientes
                    'Else
                    '    .NUMBER_REF = Strings.Right(Trim(NumeracionGuiaRemision), 7)
                    'End If
                Else
                    'If rb_facturar_pedido.Checked = True Then
                    '    .DOCUMENT_REF = "PD"
                    '    .SERIE_REF = ""
                    '    .NUMBER_REF = txtpedido.Text
                    'Else
                    '    .DOCUMENT_REF = txttipoDocRef.Text
                    '    .SERIE_REF = txtSerieDocRef.Text
                    '    If rbFacturaGuiaVenta.Checked Or rbFacturaRepMedico.Checked Then
                    '        .NUMBER_REF = "GUIAS"
                    '    Else
                    '        .NUMBER_REF = txtNumDocRef.Text
                    '    End If
                    'End If
                End If
                .NUMBER_ORDER = txtpedido.Text
                .CREATE_DATE = Date.Now.ToShortDateString
                .STATUS = "V"
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .COMMENT = ""
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
                .AMOUNT_TAX = 0
                .DISCOUNTV = 0
                .DISCOUNTP = 0
                'If rbFacturaGuiaVenta.Checked Then
                '    .LIST_GUIA = txtNumDocRef.Text
                'Else
                '    .LIST_GUIA = ""
                'End If

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
                .TRAMA_ID = txt_trama.Text
                .VEHICULO_ID = txt_vehiculo.Text
                .EMPTRA_ID = txt_Empresa.Text
                .FECHA_TRASLADO = dtpFechaFactura.Value.ToString("dd/MM/yyyy")

                'If Flag_ComprobPerc = True Then
                '    .ISC = CDbl(PorcentajePercepcion)
                'Else
                '    .ISC = 0
                'End If
                .ISC = 0

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
                    .AMOUNT_DETRAC = 0
                Else
                    .PERCENT_DETRAC = 0
                    .AMOUNT_DETRAC = 0
                End If
                'For Each Control As Control In gbTipoFacturacion.Controls
                '    If TypeOf Control Is RadioButton Then
                '        If CType(Control, RadioButton).Checked = True Then
                '            .MOV_OPTION_ID = CType(Control, RadioButton).Text
                '            Exit For
                '        End If
                '    End If
                'Next
                .NUM_LICITACION = ""
                .TIPO_NOTA_ELECTRONICA = txt_tip_nota_electronica.Text.Trim
                .DESCRIPCION_TIPO_NOTA_ELECTRONICA = txt_desc_tipo_nota_electronica.Text.Trim
                .EMAIL_CLIENTE = ""
            End With
            'Detalle de Factura
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                detalle = New ClsEntidades.RECEIVABLE_LINE
                With detalle
                    .DOCUMENT_ID = cboTipoDoc.Text
                    .NUMBER_SERIE = cboSerieDoc.Text
                    'If cboTipoDoc.Text = "FT" Then
                    .NUMBER_DOCUMENT = NumeracionFacturacion
                    'ElseIf cboTipoDoc.Text = "NC" Then
                    '    .NUMBER_DOCUMENT = NumeracionFacturaNotac
                    'ElseIf cboTipoDoc.Text = "ND" Then
                    '    .NUMBER_DOCUMENT = NumeracionFacturaNotaD
                    'End If
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM")
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO")
                    .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD")
                    .PRICE_SALES = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO_IGV"))
                    .PRICE_ORI = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO"))
                    .DISCOUNT = 0
                    .AMOUNT_TAX = dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART")
                    .TAX_PERCENT = dtdetalleArticuloPrincipal.Rows(i).Item("IGV_POR")
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
                    .TIPOISC = dtdetalleArticuloPrincipal.Rows(i).Item("TIPOISC")
                    .ISCPOR = dtdetalleArticuloPrincipal.Rows(i).Item("ISCPOR")
                    'If Flag_ComprobPerc = True Then
                    '    .ISC = CDbl(PorcentajePercepcion)
                    'Else
                    '    .ISC = 0
                    'End If
                    .ISC = dtdetalleArticuloPrincipal.Rows(i).Item("ISC")
                    'If rb_facturar_devolucion.Checked Then
                    '    .ITEM_INI = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_INI")
                    'Else
                    '    .ITEM_INI = ""
                    'End If
                    .OBSERVACIONES = dtdetalleArticuloPrincipal.Rows(i).Item("OBSERVACIONES")
                End With
                ls_det.Add(detalle)
            Next
            If chk_facturar_obsequio.Checked = False Then
                'CLIENTES
                With carteraBE
                    .CUSTOMER_ID = txtCodCliente.Text.Trim
                    .DOCUMENT_ID = cboTipoDoc.Text
                    .NUMBER_DOC = NumeracionFacturacion
                    .DOC_DATE = CDate(dtpFechaFactura.Text).ToShortDateString
                    .CADUCATE_DATE = Get_FormaPagoFechaVencimiento()
                    'If rb_facturar_pedido.Checked = True Then
                    '    .DOCUMENT_REF = "PD"
                    'Else
                    '    .DOCUMENT_REF = txttipoDocRef.Text
                    'End If
                    'If rbFacturaDirecta.Checked = True Then
                    '    .NUMBER_REF = txtSerieDocRef.Text & txtNumDocRef.Text
                    'Else
                    '    If rb_facturar_pedido.Checked = True Then
                    '        .NUMBER_REF = txtpedido.Text
                    '    Else
                    '        .NUMBER_REF = txtNumDocRef.Text
                    '    End If

                    'End If
                    .SALES_ID = txtVendedor.Text.Trim
                    .AMOUNT = 0
                    .AMOUNT_BALANCE = .AMOUNT
                    .CURRENCY_ID = cboMoneda.SelectedValue
                    .SELL_RATE = CDbl(txtTipoCambio.Text)
                    .IS_DR_CR = 0
                    .STATUS = "V"
                    .CREATE_DATE = Date.Now.ToShortDateString
                    .LAST_MODIFIED = Date.Now.ToShortDateString
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .ACCOUNT = ""
                    .AMOUNT_COMM = 0 'cboTipoDoc.Text
                    .TYPE_REC = 0
                    .REFERENCE_DATE = Date.Now.ToShortDateString
                    .IS_CHECK_DIF = 0
                    .AMOUNT_BALANCE_INI = 0
                    .TERMS = txtFormaPago.Text
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
                        .AMOUNT_DETRAC = 0
                    Else
                        .PERCENT_DETRAC = 0
                        .AMOUNT_DETRAC = 0
                    End If
                End With
            End If

            'REGISTRAR EL COBRO
            If Tipo_cancelacion <> "Credito" Then

                If monto_soles > 0 Then
                    planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
                    With planilladetBE
                        .ID = ""
                        .ITEM = 0
                        .TYPE_DOC = cboTipoDoc.Text
                        .NUMBER_DOC = NumeracionFacturacion
                        .TYPE_OPERATION = "F"
                        .REC_ID = "03"
                        .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
                        .AMOUNT = monto_soles
                        .CURRENCY_ID = "MN"
                        .SELL_RATE = CDbl(txtTipoCambio.Text)
                        .CREATE_DATE = Now.Date.ToShortDateString
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .COMMENT = ""
                        .SALES_ID = txtVendedor.Text.Trim
                        .BANK_ID = ""
                        .BANK_DESCRIPTION = ""
                        .DOC_REF = cboTipoDoc.Text
                        .NUM_REF = NumeracionFacturacion
                        .BANK_BUSSINESS_ID = ""
                        .ACCOUNT_BANK_CHECK = ""
                        .LIST_ID = 0
                        .IS_CASH_BANK = "0"
                        .AMOUNT_PER = 0
                        .PAY_AUTO = 0
                        .ANNEX_ID_AUX = txtCodCliente.Text.Trim
                        .DOCUMET_ID = cboTipoDoc.Text
                        .NUMBER_SERIE = cboSerieDoc.Text
                        .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
                        .MEDIOS_PAGO = 0
                        .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
                    End With
                    ls_detalle.Add(planilladetBE)
                End If

                If monto_dolares > 0 Then
                    planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
                    With planilladetBE
                        .ID = ""
                        .ITEM = 0
                        .TYPE_DOC = cboTipoDoc.Text
                        .NUMBER_DOC = NumeracionFacturacion
                        .TYPE_OPERATION = "F"
                        .REC_ID = "04"
                        .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
                        .AMOUNT = monto_dolares
                        .CURRENCY_ID = "ME"
                        .SELL_RATE = CDbl(txtTipoCambio.Text)
                        .CREATE_DATE = Now.Date.ToShortDateString
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .COMMENT = ""
                        .SALES_ID = txtVendedor.Text.Trim
                        .BANK_ID = ""
                        .BANK_DESCRIPTION = ""
                        .DOC_REF = cboTipoDoc.Text
                        .NUM_REF = NumeracionFacturacion
                        .BANK_BUSSINESS_ID = ""
                        .ACCOUNT_BANK_CHECK = ""
                        .LIST_ID = 0
                        .IS_CASH_BANK = "0"
                        .AMOUNT_PER = 0
                        .PAY_AUTO = 0
                        .ANNEX_ID_AUX = txtCodCliente.Text.Trim
                        .DOCUMET_ID = cboTipoDoc.Text
                        .NUMBER_SERIE = cboSerieDoc.Text
                        .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
                        .MEDIOS_PAGO = 0
                        .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
                    End With
                    ls_detalle.Add(planilladetBE)
                End If

                If monto_visa > 0 Then
                    planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
                    With planilladetBE
                        .ID = ""
                        .ITEM = 0
                        .TYPE_DOC = cboTipoDoc.Text
                        .NUMBER_DOC = NumeracionFacturacion
                        .TYPE_OPERATION = "F"
                        .REC_ID = "16"
                        .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
                        .AMOUNT = monto_visa
                        .CURRENCY_ID = "MN"
                        .SELL_RATE = CDbl(txtTipoCambio.Text)
                        .CREATE_DATE = Now.Date.ToShortDateString
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .COMMENT = ""
                        .SALES_ID = txtVendedor.Text.Trim

                        .BANK_ID = ""
                        .BANK_DESCRIPTION = ""
                        .DOC_REF = "TB"
                        .NUM_REF = num_operacion_visa
                        .BANK_BUSSINESS_ID = ""
                        .ACCOUNT_BANK_CHECK = ""

                        .LIST_ID = 0
                        .IS_CASH_BANK = "0"
                        .AMOUNT_PER = 0
                        .PAY_AUTO = 0
                        .ANNEX_ID_AUX = txtCodCliente.Text.Trim
                        .DOCUMET_ID = cboTipoDoc.Text
                        .NUMBER_SERIE = cboSerieDoc.Text
                        .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
                        .MEDIOS_PAGO = 0
                        .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
                    End With
                    ls_detalle.Add(planilladetBE)
                End If

                If monto_mastercard > 0 Then
                    planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
                    With planilladetBE
                        .ID = ""
                        .ITEM = 0
                        .TYPE_DOC = cboTipoDoc.Text
                        .NUMBER_DOC = NumeracionFacturacion
                        .TYPE_OPERATION = "F"
                        .REC_ID = "17"
                        .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
                        .AMOUNT = monto_mastercard
                        .CURRENCY_ID = "MN"
                        .SELL_RATE = CDbl(txtTipoCambio.Text)
                        .CREATE_DATE = Now.Date.ToShortDateString
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .COMMENT = ""
                        .SALES_ID = txtVendedor.Text.Trim

                        .BANK_ID = ""
                        .BANK_DESCRIPTION = ""
                        .DOC_REF = "TB"
                        .NUM_REF = num_operacion_master
                        .BANK_BUSSINESS_ID = ""
                        .ACCOUNT_BANK_CHECK = ""

                        .LIST_ID = 0
                        .IS_CASH_BANK = "0"
                        .AMOUNT_PER = 0
                        .PAY_AUTO = 0
                        .ANNEX_ID_AUX = txtCodCliente.Text.Trim
                        .DOCUMET_ID = cboTipoDoc.Text
                        .NUMBER_SERIE = cboSerieDoc.Text
                        .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
                        .MEDIOS_PAGO = 0
                        .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
                    End With
                    ls_detalle.Add(planilladetBE)
                End If

                If monto_diners_club > 0 Then
                    planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
                    With planilladetBE
                        .ID = ""
                        .ITEM = 0
                        .TYPE_DOC = cboTipoDoc.Text
                        .NUMBER_DOC = NumeracionFacturacion
                        .TYPE_OPERATION = "F"
                        .REC_ID = "18"
                        .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
                        .AMOUNT = monto_diners_club
                        .CURRENCY_ID = "MN"
                        .SELL_RATE = CDbl(txtTipoCambio.Text)
                        .CREATE_DATE = Now.Date.ToShortDateString
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .COMMENT = ""
                        .SALES_ID = txtVendedor.Text.Trim

                        .BANK_ID = ""
                        .BANK_DESCRIPTION = ""
                        .DOC_REF = "TB"
                        .NUM_REF = num_operacion_diners
                        .BANK_BUSSINESS_ID = ""
                        .ACCOUNT_BANK_CHECK = ""

                        .LIST_ID = 0
                        .IS_CASH_BANK = "0"
                        .AMOUNT_PER = 0
                        .PAY_AUTO = 0
                        .ANNEX_ID_AUX = txtCodCliente.Text.Trim
                        .DOCUMET_ID = cboTipoDoc.Text
                        .NUMBER_SERIE = cboSerieDoc.Text
                        .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
                        .MEDIOS_PAGO = 0
                        .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
                    End With
                    ls_detalle.Add(planilladetBE)
                End If

                If monto_american_expres > 0 Then
                    planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
                    With planilladetBE
                        .ID = ""
                        .ITEM = 0
                        .TYPE_DOC = cboTipoDoc.Text
                        .NUMBER_DOC = NumeracionFacturacion
                        .TYPE_OPERATION = "F"
                        .REC_ID = "19"
                        .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
                        .AMOUNT = monto_american_expres
                        .CURRENCY_ID = "MN"
                        .SELL_RATE = CDbl(txtTipoCambio.Text)
                        .CREATE_DATE = Now.Date.ToShortDateString
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .COMMENT = ""
                        .SALES_ID = txtVendedor.Text.Trim

                        .BANK_ID = ""
                        .BANK_DESCRIPTION = ""
                        .DOC_REF = "TB"
                        .NUM_REF = num_operacion_american
                        .BANK_BUSSINESS_ID = ""
                        .ACCOUNT_BANK_CHECK = ""

                        .LIST_ID = 0
                        .IS_CASH_BANK = "0"
                        .AMOUNT_PER = 0
                        .PAY_AUTO = 0
                        .ANNEX_ID_AUX = txtCodCliente.Text.Trim
                        .DOCUMET_ID = cboTipoDoc.Text
                        .NUMBER_SERIE = cboSerieDoc.Text
                        .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
                        .MEDIOS_PAGO = 0
                        .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
                    End With
                    ls_detalle.Add(planilladetBE)
                End If
            End If


            'If rbFacturaDirecta.Checked = True Or rbFacturaExistencias.Checked = True Then
            '    'la parte de almacen
            '    With alm_cabBE
            '        .WAREHOUSE_ID = txtAlmacen.Text
            '        .DOCUMENT_ID = cboTipoDoc.Text
            '        .NUMBER_DOCUMENT = NumeracionFacturacion
            '        If cboTipoDoc.Text = "NC" Then
            '            .TYPE_TRANS = "I"
            '        Else
            '            .TYPE_TRANS = "S"
            '        End If
            '        .TRANS_ID = "FT"
            '        .DATE_DOCUMENT = CDate(dtpFechaFactura.Value).ToShortDateString
            '        'If rb_facturar_pedido.Checked = True Then
            '        '    .DOC_ID_REF = "PD"
            '        'Else
            '        '    .DOC_ID_REF = txttipoDocRef.Text
            '        'End If
            '        'If rbFacturaDirecta.Checked = True Then
            '        '    .NUM_ID_REF = txtSerieDocRef.Text & txtNumDocRef.Text
            '        'Else
            '        '    If rb_facturar_pedido.Checked = True Then
            '        '        .NUM_ID_REF = txtpedido.Text
            '        '    Else
            '        '        .NUM_ID_REF = txtNumDocRef.Text
            '        '    End If

            '        'End If
            '        .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
            '        .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '        .CUSTOMER_ID = txtCodCliente.Text
            '        .VAT_REGISTRATION = txtRucDni.Text
            '        .CUSTOMER_NAME = txtRazonSocial.Text
            '        .SALES_TERM = txtFormaPago.Text.Trim
            '        .CURRENCY_TYPE = cboMoneda.SelectedValue
            '        .CURRENCY_EXCHANGE = CDbl(txtTipoCambio.Text)
            '        'If rbFacturaExistencias.Checked = True Then
            '        '    .STATUS_GUIA = "S"
            '        'Else
            '        '    .STATUS_GUIA = "F"
            '        'End If
            '        .TYPE_GUIA = ""
            '        .CARRIER_ID = txtCodTrans.Text
            '        .CARRIER_NAME = txtNomTrans.Text
            '        .CARRIER_ADDR = cboDirEntrega.Text
            '        .AMOUNT = 0
            '        .COMMENT = ""
            '        .WAREHOUSE_REF = ""
            '        .NUMBER_PURCHASE = txtordenCompra.Text
            '        .INTERFACEE = 0
            '        .FECHA_TRASLADO = CDate(dtpFechaFactura.Value).ToShortDateString
            '    End With

            '    For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
            '        alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
            '        With alm_detBE
            '            .WAREHOUSE_ID = txtAlmacen.Text
            '            .DOCUMENT_ID = cboTipoDoc.Text
            '            .NUMBER_DOCUMENT = NumeracionFacturacion
            '            .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
            '            .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
            '            .QTY = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD"))
            '            .QTY_DLV = 0
            '            .QTY_REF = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD"))
            '            .QTY_INVOICED = 0
            '            .AMOUNT_SALES = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO"))
            '            .AVERAGE_COST = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO_IGV"))
            '            .AMOUNT_TAX = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART"))
            '            .AMOUNT_US = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IGV_ART_US"))
            '            .AMOUNT = Math.Abs(dtdetalleArticuloPrincipal.Rows(i).Item("IMPORTE"))
            '            .STATUS = ""
            '            .TRANS_ID = ""
            '            .CURRENCY_ID = cboMoneda.SelectedValue().ToString
            '            .TYPE_EXCHANGE = CDbl(txtTipoCambio.Text)
            '            .PRICE_SALES = 0
            '            .TAX_PERCENT = dtdetalleArticuloPrincipal.Rows(i).Item("IGV_POR")
            '            .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
            '            .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
            '            .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
            '        End With
            '        ls_det_alm.Add(alm_detBE)
            '    Next
            'End If

            ''GUARDANDO DATOS DE LA FACTURACION
            'If cabeceraBL.GuardarFactura(cabeceraBE, ls_det, carteraBE, alm_cabBE, ls_det_alm, ls_detalle, "MN", CDate(dtpFechaFactura.Value).ToShortDateString, TipoNumeracion, cboTipoDoc.Text, IIf(rbFacturaGuiaVenta.Checked = True Or rbFacturaRepMedico.Checked = True, True, False), _
            '                             NumerosDocClientes, IIf(rbsinDescargo.Checked = True, True, False), IIf(rb_facturar_pedido.Checked = True, True, False), _
            '                             IIf(Modo_editar = True, True, False), Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, Ref_ALMACEN, _
            '                              IIf(rb_facturar_devolucion.Checked = True, True, False), TIPO_DEV, NUM_DEV) = False Then
            '    MsgBox("Hubo un Error en la Generacion de la Factura", MsgBoxStyle.Critical)
            '    indicadorF = False
            '    Exit Try
            'End If
            ''GUARDANDO DATOS DEL COMPROBANTE DE PERCEPCION
            If Flag_ComprobPerc = True Then
                cabeceraBL = New ClsOperaciones.RECEIVABLE
                Dim MontoPercepcion As Double = 0.0
                MontoPercepcion = 0
                If cboTipoDoc.Text = "FT" Then
                    If cabeceraBL.GuardarComprobantePercepcion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturacion, _
                                                               NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion, PorcentajePercepcion) = False Then
                        MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                        indicadorF = False
                        Exit Try
                    End If
                ElseIf cboTipoDoc.Text = "NC" Then
                    If cabeceraBL.GuardarComprobantePercepcion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturaNotac, _
                                                               NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion, PorcentajePercepcion) = False Then
                        MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                        indicadorF = False
                        Exit Try
                    End If
                ElseIf cboTipoDoc.Text = "ND" Then
                    If cabeceraBL.GuardarComprobantePercepcion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturaNotaD, _
                                                               NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion, PorcentajePercepcion) = False Then
                        MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                        indicadorF = False
                        Exit Try
                    End If
                End If
            End If
            Dim msj As String = String.Empty
            'If rbFacturaDirecta.Checked = True Or rb_facturar_pedido.Checked Then
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
                    .NUM_ID_REF = NumeracionFacturacion ' cboSerieDoc.Text & NumeracionFacturacion
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
                    .AMOUNT = 0
                    .COMMENT = ""
                    .WAREHOUSE_REF = ""
                    .NUMBER_PURCHASE = txtordenCompra.Text
                    'If rbunalinea.Checked Then
                    '    .INTERFACEE = 0
                    'ElseIf rbVariaslineas.Checked Then
                    '    .INTERFACEE = 1
                    'End If
                    .NUMBER_ORDER = txtpedido.Text
                    .TRAMA_ID = txt_trama.Text
                    .VEHICULO_ID = txt_vehiculo.Text
                    .EMPTRA_ID = txt_Empresa.Text
                    .ADDR_DLV = cboDirEntrega.Text
                    .FECHA_TRASLADO = CDate(dtpFechaFactura.Value).ToShortDateString
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
                        .TAX_PERCENT = dtdetalleArticuloPrincipal.Rows(i).Item("IGV_POR")
                        .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                        .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                    End With
                    ls_det_alm.Add(alm_detBE)
                Next
                ''GUARDANDO DATOS DE LA  GUIA DE SALIDA
                cabeceraBL = New ClsOperaciones.RECEIVABLE
                If cabeceraBL.GuardarGuiaSalida_Facturacion(alm_cabBE, ls_det_alm, TipoNumeracion) = False Then
                    MsgBox("Hubo un error en la Generacion de la Guia", MsgBoxStyle.Critical)
                    indicadorG = False
                    Dim Usuario As String = String.Empty
                    Dim PuntoVenta As String = cabeceraBE.PLACE_SALES
                    Dim WareHouse As String = String.Empty
                    '+++++Borrando los Datos
                    If cabeceraBE.DOCUMENT_ID <> "CP" Then
                        'ELIMINACION Factura 
                        Usuario = LibComunVar.ClsVarComun.USUARIO
                        clsFacturaBl = New ClsNegocio.RECEIVABLE
                        dtDetalleFact = New DataTable("Punto_Venta")
                        If String.IsNullOrEmpty(PuntoVenta.ToString) Then
                            MsgBox("El documento no posee un Punto de Venta Asociado", MsgBoxStyle.Critical)
                            indicadorG = False
                            Exit Try
                        End If
                        dtDetalleFact = clsFacturaBl.Get_ManualPuntoVenta(PuntoVenta)
                        If dtDetalleFact.Rows.Count() <> 0 Then
                            WareHouse = dtDetalleFact.Rows(0).Item(2).ToString
                        Else
                            MsgBox("No existe Almacen en el Punto de venta", MsgBoxStyle.Critical)
                            indicadorG = False
                            Exit Try
                        End If
                        If EliminarFacturas(Usuario, cabeceraBE.DOCUMENT_ID, cabeceraBE.NUMBER_SERIE, cabeceraBE.NUMBER_DOCUMENT, "", WareHouse) = False Then
                            MsgBox("Hubo un error, no se completo el Proceso de Eliminacion", MsgBoxStyle.Information)
                            indicadorG = False
                            Exit Try
                        End If
                    Else
                        'ELIMIANCION  CP
                        Usuario = LibComunVar.ClsVarComun.USUARIO
                        If EliminarFacturas(Usuario, cabeceraBE.DOCUMENT_ID, cabeceraBE.NUMBER_SERIE, cabeceraBE.NUMBER_DOCUMENT, "CP") = False Then
                            MsgBox("Hubo un error, no se completo el Proceso de Eliminacion", MsgBoxStyle.Information)
                            indicadorG = False
                            Exit Try
                        End If
                    End If
                    Exit Try
                End If
            End If

            If rbDocRef_varios.Checked = True Then Guardar_Detalle_Doc_Referencias()
            'If rb_facturar_devolucion.Checked = True Then Guardar_Detalle_Doc_Referencias()

        Catch ex As Exception
            indicadorF = False
            MsgBox(ex.Message)
        End Try
        Return indicadorF
    End Function

    Public Function RetornarDocReferenciaNotaC(ByVal Tipo As String, ByVal Serie As String, numero As String) As String
        Dim RelacionDoc As String = String.Empty
        Try
            Dim FacturacionesBl As New ClsOperaciones.RECEIVABLE
            Dim DtdocReferencia As New DataTable
            DtdocReferencia = FacturacionesBl.RelacionDocumentosReferencia(Tipo, Serie, numero)
            If DtdocReferencia.Rows.Count() <> 0 Then
                For Each rows As DataRow In DtdocReferencia.Rows
                    RelacionDoc += rows("TIPO_DOC").ToString & " " & rows("SERIE_DOC").ToString & " " & rows("NUMBER_DOC").ToString & " , "
                Next
                If RelacionDoc.Length() <> 0 Then
                    RelacionDoc = Mid(RelacionDoc, 1, RelacionDoc.Length - 3)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            RelacionDoc = String.Empty
        End Try
        Return RelacionDoc
    End Function

    Private Sub Limpiar()
        txtPtoVenta.Clear()
        txtAlmacen.Clear()
        dtpFechaFactura.Value = Date.Now
        txtCodCliente.Clear()
        txtRucDni.Clear()
        txtRazonSocial.Clear()
        txtDireccion.Clear()
        txtVendedor.Clear()
        txtFormaPago.Clear()

        chkSinIGV.Checked = Not Precio_Con_Sin_IGV()
        chkSinIGV.Visible = True
        chkSinIGV.ForeColor = Color.Navy
        
        lblVendedor.Text = String.Empty
        lblAlmacen.Text = String.Empty
        lblFormaPago.Text = String.Empty
        lblPtoVenta.Text = String.Empty
        cboTipoDoc.DataSource = Nothing
        cboSerieDoc.DataSource = Nothing
        txtNumDocRef.Text = String.Empty
        cbSerieGuia.DataSource = Nothing
        txtCodTrans.Text = String.Empty
        
        txtpedido.Text = String.Empty
        cboDirEntrega.DataSource = Nothing
        checkSinGuia.Checked = False
        txttipoDocRef.Text = String.Empty
        txtSerieDocRef.Text = String.Empty
        txtNumDocRef.Text = String.Empty
        cboDirEntrega.Items.Clear()
        cboDirEntrega.Text = String.Empty
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
        
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Ref_GUIA_DOCUMENT_ID = String.Empty
        Ref_GUIA_NUMBER_SERIE = String.Empty
        Ref_GUIA_NUMBER_DOCUMENT = String.Empty
        Ref_ALMACEN = String.Empty
        Ref_CP_DOCUMENT_ID = String.Empty
        Ref_CP_NUMBER_SERIE = String.Empty
        Ref_CP_NUMBER_DOCUMENT = String.Empty
        Modo_consultar = False
        Modo_editar = False

        TIPO_DEV = String.Empty
        NUM_DEV = String.Empty
        POSICION_DEV = String.Empty

        txt_vehiculo.Text = String.Empty
        txt_Empresa.Text = String.Empty
        txt_trama.Text = String.Empty

        txt_tip_nota_electronica.Text = String.Empty
        txt_desc_tipo_nota_electronica.Text = String.Empty
        IGV_POR_ITEM = 0
        TIPO_ISC = 0
        ISC_POR = 0
        _txt_unidad_producto = ""

        Flag_Modo_Edicion = False
        
        vuelto = 0
        chk_facturar_obsequio.Checked = False
        
        txt_validez_oferta.Text = "3 días calendario."

        txt_provincia.Text = ""
        txt_cod_agencia_trans.Text = ""
        txt_des_agencia_trans.Text = ""
        txt_guia.Text = ""
        rdb_agencia.Checked = False
        rdb_domicilio.Checked = False
        txt_lt_ft.Text = ""
        chk_cheque.Checked = False
        txt_cod_transferencia.Text = ""
        txt_des_transferencia.Text = ""
        txt_n_operacion.Text = ""
        txt_obs_general.Text = ""
        txt_recepcion_tercero.Text = ""
    End Sub
    Private Function Precio_Con_Sin_IGV() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.Obtener_Datos_Empresa()
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("PRECIO_IGV").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("PRECIO_IGV").ToString = "True" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("PRECIO_IGV").ToString = "False" Then
                        FLAG_NIVEL = False
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function


    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            If Modo_consultar = True Then
                ToolStrip1.Enabled = False
                txt_responsable_despacho.Text = ""
                txt_vehiculo_despacho.Text = ""
                lbl_numero.Text = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
                dtp_fecha_pedido.Value = dgvDocumentosFactura.CurrentRow.Cells("Emision").Value
                pnl_despacho_pedidos.Visible = True
                pnl_despacho_pedidos.BringToFront()
                txt_responsable_despacho.Focus()
            ElseIf Modo_programar = True Then
                ToolStrip1.Enabled = False
                txt_cod_trans.Text = ""
                txt_des_trans.Text = ""
                dtp_fecha_programacion.Value = Date.Now
                txt_direccion_entrega.Text = ""
                txt_factura.Text = ""
                txt_guia_programacion.Text = ""
                lbl_numero_programacion.Text = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
                dtp_fecha_pedido_programacion.Value = dgvDocumentosFactura.CurrentRow.Cells("Emision").Value
                pnl_programar_despacho.Visible = True
                pnl_programar_despacho.BringToFront()
                dtp_fecha_programacion.Focus()
            End If
            
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.ORDERS
            CORRELATIVOBL.NumeroCorrelativoPedido()
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                Correlativo = String.Format("{0:0000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Function Guardar_Pedido() As Boolean
        Try
            clsPedidoBl = New ClsOperaciones.ORDERS
            PedidoCabENT = New ClsEntidades.ORDER
            ListaDetalles = New List(Of ClsEntidades.ORDER_LINE)

            If Modo_consultar = True Then
                PedidoCabENT.ID = txtcodigo.Text
            Else
                Dim _CORRELATIVO As String = Numeracion()
                PedidoCabENT.ID = _CORRELATIVO
            End If
            With PedidoCabENT
                .ORDER_DATE = dtpFechaFactura.Value.ToShortDateString
                .CADUCATE_DATE = dtpFechaFactura.Value.ToShortDateString
                .SALES_ID = txtVendedor.Text
                .PLACE_SALES = txtPtoVenta.Text
                .CUSTOMER_ID = txtCodCliente.Text
                .CUSTOMER_NAME = txtRazonSocial.Text
                .CUSTOMER_ADDR = txtDireccion.Text
                .CUSTOMER_ADDR_DLV = txtDireccion.Text
                .VAT_REGISTRATION = txtRucDni.Text
                .AMOUNT = 0
                .DISCOUNT_CUSTOMER = 0
                .DISCOUNT_SP = 0
                .TERMS = txtFormaPago.Text
                .SELL_RATE = txtTipoCambio.Text
                .CURRENCY_ID = cboMoneda.SelectedValue
                .DOCUMENT_REF = ""
                .SERIE_REF = ""
                .NUMBER_REF = ""
                .CREATE_DATE = Date.Today
                .STATUS = "V"
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .COMMENT = ""
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
                .TRAMA_ID = cboTipoDoc.Text
                .AMOUNT_ISC = 0
                .ID_CENTRO_COSTO = ""
                .VALIDEZ_OFERTA = txt_validez_oferta.Text.Trim

                .PROVINCIA = txt_provincia.Text
                .AGENCIA_TRANSPORTE = txt_cod_agencia_trans.Text
                .GUIA = txt_guia.Text
                If rdb_agencia.Checked Then
                    .AGE_DOMI = "AGENCIA"
                ElseIf rdb_domicilio.Checked Then
                    .AGE_DOMI = "DOMICILIO"
                End If
                .LT_FT = txt_lt_ft.Text
                If chk_cheque.Checked Then
                    .CHEQUE = "SI"
                Else
                    .CHEQUE = "NO"
                End If
                .TRANSFERENCIA = txt_cod_transferencia.Text
                .N_OPERACION = txt_n_operacion.Text
                .OBS_GENERAL = txt_obs_general.Text
                .RECEPCION_TERCERO = txt_recepcion_tercero.Text
            End With
            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                PedidoDetENT = New ClsEntidades.ORDER_LINE
                With PedidoDetENT
                    .ID = PedidoCabENT.ID
                    .ITEM = item("ITEM")
                    .PART_ID = item("CODIGO")
                    .PART_DESCRIPTION = item("DESCRIPCION")
                    .QTY = item("CANTIDAD")
                    .PRICE_SALES = item("PRECIO_IGV")
                    .PRICE_ORI = item("PREC_UNITARIO")
                    .DISCOUNT = 0
                    .AMOUNT_TAX = item("IGV_ART")
                    .DISCOUNT_CUST = 0
                    .DISCOUNT_SP = 0
                    .PERCENT_TAX = item("IGV_POR")
                    .PERCENT_DISCOUNT = 0
                    .AMOUNT_US = 0
                    .AMOUNT = item("IMPORTE")
                    .STATUS = "V"
                    .SERIE = ""
                    .WAREHOUSE_ID = txtAlmacen.Text.Trim
                    .TEXT_COMMENT = ""
                    .QTY_REF = .QTY
                    .LOT = ""
                    .BALANCE = item("IMPORTE")
                    .IS_PART_TAX = 1
                    .LIST_ID = ""
                    .UNIT = item("UNIDAD")
                    .AMOUNT_ISC = 0
                    .PERCENT_ISC = 0
                    .PRICE_NET = item("PRECIO_IGV")
                    .ID_CENTRO_COSTO = ""
                End With
                ListaDetalles.Add(PedidoDetENT)
            Next
            If clsPedidoBl.GuardarPedido(PedidoCabENT, ListaDetalles, Modo_consultar) Then
                If Modo_consultar = True Then
                    MsgBox("Pedido Modificado Correctamente" & vbCrLf & "N° Pedido " & PedidoCabENT.ID, MsgBoxStyle.Information)
                Else
                    MsgBox("Pedido Generado Correctamente" & vbCrLf & "N° Pedido " & PedidoCabENT.ID, MsgBoxStyle.Information)
                End If
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Generar_XML_Factura_Guia(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Monto_Letras As String, _
                                 Optional ByVal _envia_email As String = "", _
                                 Optional ByVal _email_cliente As String = "") As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_FT_GS_Xml(TipoDoc, SerieDoc, NumDoc, Ruta_FE() & "\InputXML", Monto_Letras, _envia_email, _email_cliente) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Ruta_FE() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE = mySetting("Ruta_FE")
        Return STRRuta_FE
    End Function

    Private Function Ruc_Electronico() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuc = mySetting("Ruc")
        Return STRRuc
    End Function

    Private Function OpenSubForm(ByVal form As Form) As Boolean
        Dim estado As Boolean = True
        Try
            For Each formulario As Form In Application.OpenForms
                If formulario.Name = form.Name Then
                    estado = False
                    formulario.Activate()
                    Exit Try
                End If
            Next
            form.Show()
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub Guardar_Detalle_Doc_Referencias()
        Try
            Dim FacturacionBl As New ClsOperaciones.RECEIVABLE
            Dim Num As String = String.Empty
            'If cboTipoDoc.Text = "FT" Then
            Num = NumeracionFacturacion
            'ElseIf cboTipoDoc.Text = "NC" Then
            '    Num = NumeracionFacturaNotac
            'ElseIf cboTipoDoc.Text = "ND" Then
            '    Num = NumeracionFacturaNotaD
            'End If
            If FacturacionBl.Guardar_Lista_Detalle_Referencias(cboTipoDoc.Text, cboSerieDoc.Text, Num, Dt_principal_lista_Doc_Ref) = True Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Function Verificar_Documento_cerrado(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            'If Mes_Ant = 1 Then
            'Mes_Ant = "12"
            'Anio_Ant = CInt(Anio_Ant) - 1
            'Else
            '    Mes_Ant = CInt(Mes_Ant) - 1
            '    Anio_Ant = anyo
            ' End If
            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.ValidarFechaVentas(Mes_Ant, Anio_Ant, "CIERRE")
            If dtCierre.Rows.Count() <> 0 Then
                ' Dim Resultado As Integer
                If dtCierre.Rows(0).Item(0) = 1 Then
                    MsgBox("El documento pertenece a un mes cerrado, no procede la transacción.", MsgBoxStyle.Critical)
                    Estado = False
                    Flag_Verificar = True
                    Exit Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Function Verificar_Documento_Cierre_Ventas(ByVal fecha As String) As Boolean
        Dim Estado As Boolean = True
        Try

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            'dtCierre = VentasBl.ValidarFechaVentas_Cierre_ventas(fecha)
            If dtCierre.Rows.Count() = 0 Then
                MsgBox("El documento pertenece a un día cerrado, no procede la transacción.", MsgBoxStyle.Critical)
                Estado = False
                Flag_Verificar = True
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Dim Store As String = String.Empty
        Dim msj As String = String.Empty
        Dim Usuario As String = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub

        ref_fecha_doc = dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value

        If dgvDocumentosFactura.CurrentRow.Cells("Estado").Value = "ANULADO" Then
            MsgBox("El documento se encuentra anulado," & Chr(13) & "no procede la eliminación.", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If

        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        'Verificando Cancelacion
        Store = "FACT_SP_S_R_VERIFICAR_CANCEL"
        If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
            msj = String.Empty
            msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Cancelacion , no se puede Eliminar."
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
        Else
            'Verificando si posee Letra
            Store = String.Empty
            Store = "FACT_SP_S_R_VERIFICAR_LETRA"
            If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                msj = String.Empty
                msj = "   EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Letra, no se puede Eliminar."
                MsgBox(msj, MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                'verificamos si esta contabilizado
                Store = String.Empty
                Store = "FACT_SP_S_R_VERIFICAR_CONTABILIZACION"
                If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                    msj = String.Empty
                    msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " esta contabilizado, no se puede Eliminar."
                    MsgBox(msj, MsgBoxStyle.Information)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
        End If

        If MessageBox.Show("¿Desea Eliminar el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            If Ref_DOCUMENT_ID <> "CP" Then
                'ELIMINACION Factura 
                Usuario = LibComunVar.ClsVarComun.USUARIO
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Punto_Venta")
                Dim PuntoVenta As String = dgvDocumentosFactura.CurrentRow.Cells("PV").Value
                Dim WareHouse As String = String.Empty
                If String.IsNullOrEmpty(PuntoVenta.ToString) Then
                    MsgBox("El documento no posee un Punto de Venta Asociado", MsgBoxStyle.Critical)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                dtDetalleFact = clsFacturaBl.Get_ManualPuntoVenta(PuntoVenta)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    WareHouse = dtDetalleFact.Rows(0).Item(2).ToString
                Else
                    MsgBox("No existe Almacen en el Punto de venta", MsgBoxStyle.Critical)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                If EliminarFacturas(Usuario, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "", WareHouse) = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de Eliminacion", MsgBoxStyle.Information)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                DocumentosFactura()
                msj = String.Empty
                msj = "Documento Eliminado Correctamente." & vbCrLf & " Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                MsgBox(msj, MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
                'Else
                '    'ELIMIANCION  CP
                '    Usuario = LibComunVar.ClsVarComun.USUARIO
                '    If EliminarFacturas(Usuario, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "CP") = False Then
                '        MsgBox("Hubo un error, no se completo el Proceso de Anulacion", MsgBoxStyle.Information)
                '        Me.Cursor = Cursors.Default
                '        Exit Sub
                '    End If
                '    msj = String.Empty
                '    msj = "Documento Eliminado Correctamente." & vbCrLf & " Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                '    MsgBox(msj, MsgBoxStyle.Information)
                '    Me.Cursor = Cursors.Default
                '    DocumentosFactura()
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
                                    ByVal _NUMBER_DOCUMENT As String, Optional ByVal ComprobanteP As String = "", _
                                    Optional ByVal ALMACEN As String = "", Optional ByVal motivo As String = "") As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If ComprobanteP = String.Empty Then
                clsFacturaBl.AnulacionFacturacion(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, ALMACEN, motivo)
            Else
                clsFacturaBl.AnulacionFacturacionComprobanteP(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function Cierre_Ventas(ByVal _FECHA As String, ByVal _USUARIO As String, ByVal _SALDO_FINAL As Double, _
                                    ByVal _SALDO_FINAL_VISA As Double, ByVal _SALDO_FINAL_MASTER As Double, _
                                    ByVal _SALDO_FINAL_DINERS As Double, ByVal _SALDO_FINAL_AMERICAN_EXPRESS As Double) As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            'If clsFacturaBl.Cierre_Ventas(_FECHA, _USUARIO, _SALDO_FINAL, _SALDO_FINAL_VISA, _SALDO_FINAL_MASTER, _SALDO_FINAL_DINERS, _SALDO_FINAL_AMERICAN_EXPRESS) = False Then
            '    estado = False
            'End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function Apertura_Documento(ByVal _documento As String, ByVal _serie As String, ByVal _numero As String) As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            'If clsFacturaBl.Apertura_Ventas_doc(_documento, _serie, _numero) = False Then
            '    estado = False
            'End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function Reenvio_Docs_Electronicos(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String, _
                                                ByVal _DOCUMENT_ID_SUNAT As String, ByVal _MONTO As String) As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            'clsFacturaBl.Reenvio_Docs_Electronicos(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, _DOCUMENT_ID_SUNAT, _MONTO)
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnAnular_Click(sender As Object, e As EventArgs)

    End Sub


    Private Function ValidacionConsultas(ByRef _DOCUMENT_ID As String, ByRef _NUMBER_SERIE As String, ByRef _NUMBER_DOCUMENT As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            _DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("DOCUMENT_ID").Value
            _NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value
            _NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_DOCUMENT").Value
            'validacion
            If _DOCUMENT_ID = String.Empty Or _NUMBER_SERIE = String.Empty Or _NUMBER_DOCUMENT = String.Empty Then
                estado = False
                Exit Try
            End If

        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
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
                cWork = cWork.Trim
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

                        If cCENTENA & cDECENA & cUNIDAD = "001" And num > 2999999 Then
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
    ' Funcion que crea la imagen para el reporte
    'Public Function Parte1_PDF(sValorPDF As String) As Bitmap
    '    Dim barset As BarcodeSettings
    '    Dim bardata As String
    '    Dim bartype As String = "Code128"
    '    Dim generator As BarCodeGenerator

    '    bardata = sValorPDF

    '    barset = New BarcodeSettings
    '    barset.Data2D = bardata
    '    barset.Data = bardata
    '    barset.Type = Pdf417ECL.Level5
    '    barset.Unit = GraphicsUnit.Millimeter
    '    barset.X = 0.17F
    '    barset.XYRatio = 3.0F
    '    barset.ShowText = False
    '    generator = New BarCodeGenerator(barset)
    '    Dim bitmap As Bitmap = DirectCast(generator.GenerateImage(), Bitmap)
    '    Dim rect As Rectangle
    '    rect = New Rectangle(15, 15, bitmap.Width - 27, bitmap.Height - 15)
    '    Return bitmap.Clone(rect, bitmap.PixelFormat)
    'End Function


    Public Function Obtiene_Barcode_Byte(imagen As Bitmap) As Byte()

        Dim result As Byte()
        Try
            Dim MemoryStream1 As New MemoryStream()
            imagen.Save(MemoryStream1, Imaging.ImageFormat.Jpeg)
            Dim array As Byte() = MemoryStream1.ToArray()
            result = array
        Catch ex As Exception
            result = Nothing
        End Try
        Return result

    End Function


    Private Sub imprimirFacturacion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String, _
                                    ByVal _Moneda As String, ByVal _Igv As Double, ByVal _Monto As Double)
        Try

            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Dim STRmontotexto As String = String.Empty
            Dim Nom_Reporte As String = String.Empty
            If _Moneda = "MN" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   SOLES"
            Else
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   DOLARES AMERICANOS"
            End If
            Me.Cursor = Cursors.WaitCursor
            'dtImprimir = reporteBL.Obtener_Nombre_Reporte(_DOCUMENT_ID)
            If dtImprimir.Rows.Count > 0 Then
                Nom_Reporte = dtImprimir.Rows(0).Item("REPORT_NAME_NUEVO").ToString
            Else
                MsgBox("No se encuentra el formato del reporte, no se puede imprimir el documento " & _DOCUMENT_ID & ".", MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            If Nom_Reporte = "" Then
                MsgBox("No se encuentra el formato del reporte, no se puede imprimir el documento " & _DOCUMENT_ID & ".", MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            dtImprimir = reporteBL.EjecutarReporteFacturacion(_DOCUMENT_ID, _NUMBER_SERIE, Strings.Right(_NUMBER_DOCUMENT, 7))
            If dtImprimir.Rows.Count() <> 0 Then
                If _DOCUMENT_ID = "NC" Then
                    Dim RelacionDoc As String = String.Empty
                    Dim REF_NC As String = ""
                    RelacionDoc = RetornarDocReferenciaNotaC(_DOCUMENT_ID, _NUMBER_SERIE, Strings.Right(_NUMBER_DOCUMENT, 7))
                    If RelacionDoc.Length() > 12 Then
                        REF_NC = "1"
                    Else
                        REF_NC = "0"
                    End If

                    crystalBL.Muestra_Reporte(Nom_Reporte, dtImprimir, "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE, _
                                              "@NUMERO;" & _NUMBER_DOCUMENT, "@LETRAS;" & STRmontotexto, "@DOC_REF;" & RelacionDoc, "@REF_NC;" & REF_NC)
                Else
                    crystalBL.Muestra_Reporte(Nom_Reporte, dtImprimir, "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE, _
                                              "@NUMERO;" & _NUMBER_DOCUMENT, "LETRAS;" & STRmontotexto)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
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
                crystalBL.Muestra_Reporte("rpt_Impresion_Factura_Guia_Remision.rpt", dtImprimir, "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
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
                crystalBL.Muestra_Reporte("rpt_Impresion_Factura_Comprobante_P.rpt", dtImprimir, "", "", "@TIPO;" & documentid, "@SERIE;" & serie, "@NUMERO;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Imprimir_Directo(ByVal _nombre_archivo As String)
        'Dim filename As String = "C:\Users\Alfonso\Desktop\PrintPDF_VBNet\VB.Net\test.pdf"

        Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
        psi.UseShellExecute = True
        psi.Verb = "print"
        psi.FileName = _nombre_archivo
        psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        psi.ErrorDialog = False
        psi.Arguments = "/p"
        Dim p As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
        p.WaitForInputIdle()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Dim _Id As String = String.Empty
        _Id = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
        imprimir_pedido(_Id)
    End Sub

    Private Sub imprimir_pedido(ByVal _Codigo As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Pedidos")
            Dim dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReportePedidos(_Codigo)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                Dim STRmontotexto As String = ""
                If cboMoneda.SelectedValue = "MN" Then
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(dtImprimir.Rows(0).Item("AMOUNT"))))) & " Soles"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(dtImprimir.Rows(0).Item("AMOUNT"))))) & " Dólares Americanos"
                End If

                crystalBL.Muestra_Reporte("rpt_Impresion_pedido.rpt", dtImprimir, "", "", "@ID;" & _Codigo, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                          "LETRA;" & STRmontotexto)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlPrincipal.Visible = True
        GbdetalleDocumento.Visible = False
        Botonera_Estado_Cambiar(False)
        Limpiar()
        Ref_DOCUMENT_ID = ""
    End Sub

    Private Sub cambiarResolucion(ByVal formulario As System.Windows.Forms.Form, ByVal ancho As Double, ByVal alto As Double)
        formulario.AutoScaleDimensions = New System.Drawing.SizeF(ancho, alto) 'Ajusto la resolución
        formulario.PerformAutoScale() 'Escalo el control contenedor y sus elementos secundarios.
    End Sub

    Private Function NIVEL_ACCESO() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "01" Then 'administrador
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "02" Then 'usuario estandar
                        FLAG_NIVEL = False
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function

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
            Ayuda_TipoDocPuntoVenta()
            cboTipoDoc.Text = "PF"
            If cboTipoDoc.Text = String.Empty Then Exit Sub

            GenerarColummnaDataTable()
            Calcular_Totales()
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
                    txtVendedor.Select()
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
                    'If rb_facturar_pedido.Checked = False Then
                    '    txtFormaPago.Text = dtDetalleFact.Rows(0).Item(5).ToString
                    '    If rbFacturaRepMedico.Checked = False Then
                    '        txtVendedor.Text = dtDetalleFact.Rows(0).Item("SALES_ID").ToString
                    '    End If
                    'End If
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

            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtDetalleFact = New DataTable("Vendedor")
            dtDetalleFact = clsFacturaBl.Get_ManualVendedor_usuario(LibComunVar.ClsVarComun.USUARIO)
            If dtDetalleFact.Rows.Count() <> 0 Then
                txtVendedor.Text = dtDetalleFact.Rows(0).Item("CODIGO").ToString
                lblVendedor.Text = dtDetalleFact.Rows(0).Item("DESCRIPCION").ToString
            Else
                txtVendedor.Text = ""
                lblVendedor.Text = ""
                MsgBox("El Usuario: " & LibComunVar.ClsVarComun.USUARIO & Chr(13) & "no tiene un vendedor asignado. Verifique!!!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            txtVendedor.Select()
            
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
                    txtFormaPago.Select()
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
                'If txt_tip_nota_electronica.Enabled = True Then
                '    txt_tip_nota_electronica.Focus()
                '    'Else
                '    '    btnAgregar.Select()
                'End If
            Else
                Ayuda_FormaPago(txtFormaPago.Text)
                'If txt_tip_nota_electronica.Enabled = True Then
                '    txt_tip_nota_electronica.Focus()
                '    'Else
                '    '    btnAgregar.Select()
                'End If
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

            If FechaFacturacion_Mes_anterior(dtpFechaFactura.Value.Month, dtpFechaFactura.Value.Year) = False Then
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
            Else
                If txtTipoCambio.Text = 0 Then
                    MsgBox("El tipo de cambio debe de ser diferente de 0.", MsgBoxStyle.Critical)
                    estado = False
                    Exit Try
                End If
            End If
            If txtCodCliente.Text = String.Empty Then
                MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Information)
                estado = False
                txtCodCliente.Focus()
                Exit Try
            End If

            If txtVendedor.Text = String.Empty Then
                MsgBox("No se cargo el dato del Vendedor.", MsgBoxStyle.Critical)
                estado = False
                txtVendedor.Focus()
                Exit Try
            End If

            If txtFormaPago.Text = String.Empty Then
                MsgBox("Debe elegir una Forma de Pago.", MsgBoxStyle.Critical)
                estado = False
                txtFormaPago.Focus()
                Exit Try
            End If

            If cboTipoDoc.Text = String.Empty Then
                MessageBox.Show("Debe elegir el tipo de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboTipoDoc.Focus()
                estado = False
                Exit Try
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Public Structure StructuraPart
        Dim Codigo As String
        Dim Lote As String
        Dim Cantidad As Double
    End Structure


    Private Function DatosLotes() As List(Of StructuraPart)
        Dim Cadena As String = String.Empty
        Try
            Dim cadena_lote As String = String.Empty
            ListaDatosArticulo = New List(Of StructuraPart)
            ListaCompleta = New List(Of StructuraPart)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                For i As Integer = 0 To dgvDetalle.Rows.Count() - 1
                    Dim Str As New StructuraPart
                    Str.Codigo = dgvDetalle.Item(1, i).Value
                    Str.Lote = dgvDetalle.Item(5, i).Value
                    If ListaDatosArticulo.Contains(Str) = False Then
                        ListaDatosArticulo.Add(Str)
                    End If
                Next
                For Each item As StructuraPart In ListaDatosArticulo
                    Dim Str As New StructuraPart
                    Str.Codigo = item.Codigo
                    Str.Cantidad = dtdetalleArticuloPrincipal.Compute("sum(CANTIDAD)", "CODIGO='" & item.Codigo & "' and LOTE = '" & item.Lote & "'")
                    Str.Lote = item.Lote
                    ListaCompleta.Add(Str)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ListaCompleta
    End Function

    

    


    Private Sub Calcular_Totales()
        Try
            Dim i As Integer = 0
            Dim total As Double = 0.0
            Dim totaldesc1 As Double = 0.0
            Dim totaldesc2 As Double = 0.0
            Dim TasaIgv As Double = 0.0
            Dim TasaISC As Double = 0.0
            Dim Monto As Double = 0.0

            If dgvDetalle.RowCount > 0 Then
                'Datos del Sistema Parametros Generales
                clsIgvArticuloBL = New ClsTransacciones.clsPedidos
                dtIgvArticulo = New DataTable("IGV_SISTEMA")
                po_TasaIgv = 0.0
                Igv = 0.0
                po_TasaIsc = 0.0
                Isc = 0.0

                'obteniendo Datos del Articulo
                For Each row As DataRow In dtdetalleArticuloPrincipal.Rows
                    'VERIFICA SI EL ARTICULO ESTA SUJETO A IGV
                    po_TasaIgv = CDbl(row("IGV_POR").ToString)
                    po_TasaIsc = CDbl(row("ISCPOR").ToString)
                    clsIgvArticuloBL = New ClsTransacciones.clsPedidos
                    dtIgvArticulo = New DataTable("Fl_igv")
                    dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvArticulo(row("CODIGO").ToString())

                    If dtIgvArticulo.Rows.Count() <> 0 Then
                        If row("PRECIO_CON_IGV") = "SI" Then 'si el precio contiene el IGV

                            If dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = False Then
                                If cboTipoDoc.Text = "NC" Then
                                    Igv = CDbl(row("IGV_POR").ToString) 'IGV_POR_ITEM 'CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    Isc = CDbl(row("ISCPOR").ToString) 'IGV_POR_ITEM '(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaISC = 0.0
                                    TasaIgv = po_TasaIgv / 100
                                    TasaISC = po_TasaIsc / 100
                                    Monto = 0.0
                                    'Monto = CDbl(row("PRECIO_INICIAL")) + (CDbl(row("PRECIO_INICIAL")) * (CDbl(Igv) / 100))
                                    Monto = CDbl(row("PRECIO_INICIAL"))
                                    Monto = Val(Format((Monto / (1 + TasaIgv)) / (1 + TasaISC), "0.000000"))
                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = -Math.Abs(CDbl(Monto))
                                    row("VALOR_VENTA") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO")))
                                    row("IMP_DESC_01") = Math.Abs(CDbl((row("PREC_UNITARIO") * row("%DESC.ART_1") / 100) * row("CANTIDAD")))
                                    row("IMP_DESC_02") = Math.Abs(CDbl(((row("PREC_UNITARIO") - (row("PREC_UNITARIO") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD")))
                                    row("PRECIO_IGV") = -Math.Abs(CDbl(row("PRECIO_INICIAL")))
                                    row("IGV_ART") = -Math.Abs(CDbl(CDbl(row("CANTIDAD") * (row("PREC_UNITARIO") - row("IMP_DESC_01")) * (1 + TasaISC)) * TasaIgv))
                                    row("ISC") = -Math.Abs(CDbl(row("CANTIDAD") * (row("PREC_UNITARIO") - row("IMP_DESC_01")) * TasaISC))
                                    row("IGV_ART_US") = -Math.Abs(0)
                                    row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()
                                Else
                                    Igv = CDbl(row("IGV_POR").ToString) 'IGV_POR_ITEM '(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    Isc = CDbl(row("ISCPOR").ToString) 'IGV_POR_ITEM '(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaISC = 0.0
                                    TasaIgv = po_TasaIgv / 100
                                    TasaISC = po_TasaIsc / 100
                                    Monto = 0.0
                                    'OBTENEMOS LOS VALORES DE LA CANTIDAD PRESENTACION
                                    Monto = CDbl(row("PRECIO_INICIAL"))
                                    Monto = Val(Format((Monto / (1 + TasaIgv)) / (1 + TasaISC), "0.000000"))

                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = CDbl(Monto)
                                    row("VALOR_VENTA") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO"))
                                    row("IMP_DESC_01") = CDbl((row("PREC_UNITARIO") * row("%DESC.ART_1") / 100) * row("CANTIDAD"))
                                    row("IMP_DESC_02") = CDbl(((row("PREC_UNITARIO") - (row("PREC_UNITARIO") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD"))
                                    row("PRECIO_IGV") = row("PRECIO_INICIAL")
                                    row("IGV_ART") = CDbl(CDbl(row("CANTIDAD") * (row("PREC_UNITARIO") - row("IMP_DESC_01")) * (1 + TasaISC)) * TasaIgv)
                                    row("ISC") = CDbl(row("CANTIDAD") * (row("PREC_UNITARIO") - row("IMP_DESC_01")) * TasaISC)
                                    row("IGV_ART_US") = 0
                                    row("IMPORTE") = CDbl(row("PRECIO_IGV") * row("CANTIDAD"))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()

                                    'OBTENEMOS LOS VALORES DE LA CANTIDAD FRACCION
                                    Monto = 0.0

                                    Monto = CDbl(row("PRECIO_INICIAL_FRACCION"))
                                    Monto = Val(Format((Monto / (1 + TasaIgv)) / (1 + TasaISC), "0.000000"))

                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO_FRACCION") = CDbl(Monto)
                                    row("VALOR_VENTA_FRACCION") = CDbl(row("CANTIDAD_FRACCION") * row("PREC_UNITARIO_FRACCION"))
                                    row("IMP_DESC_01") = CDbl((row("PREC_UNITARIO_FRACCION") * row("%DESC.ART_1") / 100) * row("CANTIDAD_FRACCION"))
                                    row("IMP_DESC_02") = CDbl(((row("PREC_UNITARIO_FRACCION") - (row("PREC_UNITARIO_FRACCION") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD_FRACCION"))
                                    row("PRECIO_IGV_FRACCION") = row("PRECIO_INICIAL_FRACCION")
                                    row("IGV_ART_FRACCION") = CDbl(CDbl(row("CANTIDAD_FRACCION") * (row("PREC_UNITARIO_FRACCION") - row("IMP_DESC_01")) * (1 + TasaISC)) * TasaIgv)
                                    row("ISC") = CDbl(row("CANTIDAD_FRACCION") * (row("PREC_UNITARIO_FRACCION") - row("IMP_DESC_01")) * TasaISC)
                                    row("IGV_ART_US") = 0
                                    row("IMPORTE_FRACCION") = CDbl(row("PRECIO_IGV_FRACCION") * row("CANTIDAD_FRACCION"))
                                    row("TOTAL") = CDbl(row("IMPORTE")) + CDbl(row("IMPORTE_FRACCION"))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()
                                End If
                            End If

                        Else 'si el precio no contiene el IGV

                            If dtIgvArticulo.Rows(0).Item("IS_VAT").ToString = False Then
                                If cboTipoDoc.Text = "NC" Then
                                    Igv = CDbl(row("IGV_POR").ToString) 'IGV_POR_ITEM 'CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    Isc = CDbl(row("ISCPOR").ToString)
                                    TasaIgv = 0.0
                                    TasaISC = 0.0
                                    TasaIgv = po_TasaIgv / 100
                                    TasaISC = po_TasaIsc / 100
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL"))

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
                                    row("IGV_ART") = -Math.Abs(CDbl(((row("CANTIDAD") * (row("PREC_UNITARIO") - row("IMP_DESC_01"))) * (1 + TasaISC)) * TasaIgv))
                                    row("ISC") = -Math.Abs(CDbl(row("CANTIDAD") * (row("PREC_UNITARIO") - row("IMP_DESC_01")) * TasaISC))
                                    row("IGV_ART_US") = -Math.Abs(0)
                                    row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))
                                    row("CANTIDAD") = -Math.Abs(CDbl(row("CANTIDAD")))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()
                                Else
                                    Igv = CDbl(row("IGV_POR").ToString)
                                    Isc = CDbl(row("ISCPOR").ToString)
                                    TasaIgv = 0.0
                                    TasaISC = 0.0
                                    TasaIgv = po_TasaIgv / 100
                                    TasaISC = po_TasaIsc / 100
                                    'OBTENEMOS EL PRECIO DE LA CANTIDAD PRESENTACION
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL"))

                                    Monto = Val(Format((Monto * (1 + TasaIgv)) * (1 + TasaISC), "0.000000"))

                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = row("PRECIO_INICIAL")
                                    row("VALOR_VENTA") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO"))
                                    row("IMP_DESC_01") = CDbl((row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100) * row("CANTIDAD"))
                                    row("IMP_DESC_02") = CDbl(((row("PRECIO_INICIAL") - (row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD"))
                                    row("PRECIO_IGV") = Monto
                                    row("IGV_ART") = CDbl(((row("CANTIDAD") * (row("PREC_UNITARIO") - row("IMP_DESC_01"))) * (1 + TasaISC)) * TasaIgv)
                                    row("ISC") = CDbl(row("CANTIDAD") * (row("PREC_UNITARIO") - row("IMP_DESC_01")) * TasaISC)
                                    row("IGV_ART_US") = 0
                                    row("IMPORTE") = CDbl(row("PRECIO_IGV") * row("CANTIDAD"))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()

                                    'OBTENEMOS EL PRECIO DE LA CANTIDAD FRACCION
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL_FRACCION"))

                                    Monto = Val(Format((Monto * (1 + TasaIgv)) * (1 + TasaISC), "0.000000"))

                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO_FRACCION") = row("PRECIO_INICIAL_FRACCION")
                                    row("VALOR_VENTA_FRACCION") = CDbl(row("CANTIDAD_FRACCION") * row("PREC_UNITARIO_FRACCION"))
                                    row("IMP_DESC_01") = CDbl((row("PRECIO_INICIAL_FRACCION") * row("%DESC.ART_1") / 100) * row("CANTIDAD_FRACCION"))
                                    row("IMP_DESC_02") = CDbl(((row("PRECIO_INICIAL_FRACCION") - (row("PRECIO_INICIAL_FRACCION") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD_FRACCION"))
                                    row("PRECIO_IGV_FRACCION") = Monto
                                    row("IGV_ART_FRACCION") = CDbl(((row("CANTIDAD_FRACCION") * (row("PREC_UNITARIO_FRACCION") - row("IMP_DESC_01"))) * (1 + TasaISC)) * TasaIgv)
                                    row("ISC") = CDbl(row("CANTIDAD_FRACCION") * (row("PREC_UNITARIO_FRACCION") - row("IMP_DESC_01")) * TasaISC)
                                    row("IGV_ART_US") = 0
                                    row("IMPORTE_FRACCION") = CDbl(row("PRECIO_IGV_FRACCION") * row("CANTIDAD_FRACCION"))
                                    row("TOTAL") = CDbl(row("IMPORTE")) + CDbl(row("IMPORTE_FRACCION"))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()
                                End If
                            End If
                        End If
                    End If
                Next

            Else
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        If GbCabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            If FechaFacturacion_Mes_anterior(dtpFechaFactura.Value.Month, dtpFechaFactura.Value.Year) = False Then
                btnCancelar_Click(sender, e)
                Exit Sub
            Else
                If FechaFacturacion(dtpFechaFactura.Value.Month + 1, dtpFechaFactura.Value.Year) = False Then
                    btnCancelar_Click(sender, e)
                    Exit Sub
                End If
            End If
            ''Confirmaciones
            Dim NombreTipoFacturacion As String = String.Empty
            
            'If MessageBox.Show("Se va a generar el registro con Tipo de Facturacion : " & vbCrLf & NombreTipoFacturacion.Substring(1) & vbCrLf & " y con  Documento : " & cboTipoDoc.Text & vbCrLf & " ¿ Desea continuar ?", "Confirmaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '    GbCabecera.Enabled = False
            '    gbTipoFacturacion.Enabled = False
            'Else
            '    Exit Sub
            'End If
        End If
        If dgvDetalle.Rows.Count() = NumeroItemsDocumentos() Then
            MsgBox("Ya alcanzo el numero maximo de items permitido para este Tipo de Documento.", MsgBoxStyle.Information)
            Exit Sub
        End If
        edicion = False
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
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
                Calcular_Totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs)
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()

    End Sub

    Private Sub Ayuda_TipoDocPuntoVenta()
        Try
            cVenta = New ClsAyudas
            dtTipoDoc = New DataTable
            'If txtPtoVenta.Text = String.Empty Then Exit Sub
            dtTipoDoc = cVenta.get_Tipo_Doc_Pto_Venta_Pedido(txtPtoVenta.Text.Trim)
            cboTipoDoc.ValueMember = "SERIE"
            cboTipoDoc.DisplayMember = "TIPO"
            cboTipoDoc.DataSource = dtTipoDoc

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
            cbSerieGuia.ValueMember = dtSerieGuia.Columns(0).ToString
            cbSerieGuia.DisplayMember = dtSerieGuia.Columns(0).ToString
            cbSerieGuia.DataSource = dtSerieGuia

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SerieDocumentoPuntoVenta()
        cVenta = New ClsAyudas
        dtSerieDoc = New DataTable
        dtSerieDoc = cVenta.get_Serie_Doc_Pto_Venta(cboTipoDoc.Text, txtPtoVenta.Text.Trim)
        cboSerieDoc.ValueMember = dtSerieDoc.Columns(0).ToString
        cboSerieDoc.DisplayMember = dtSerieDoc.Columns(0).ToString
        cboSerieDoc.DataSource = dtSerieDoc
        cVenta = Nothing
    End Sub

    Private Sub cbTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoDoc.SelectionChangeCommitted
        If cboTipoDoc.SelectedIndex <> -1 Then
            'SerieDocumentoPuntoVenta()
            If cboTipoDoc.Text = "NC" Or cboTipoDoc.Text = "ND" Then
                txt_tip_nota_electronica.Text = String.Empty
                txt_desc_tipo_nota_electronica.Text = String.Empty
                txt_tip_nota_electronica.Enabled = True
                Button5.Enabled = True
            Else
                txt_tip_nota_electronica.Text = String.Empty
                txt_desc_tipo_nota_electronica.Text = String.Empty
                txt_tip_nota_electronica.Enabled = False
                Button5.Enabled = False
            End If
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
        'cboSerieDoc.Text = cboTipoDoc.SelectedValue.ToString
        'If rbFacturaGuiaVenta.Checked = True Or rb_facturar_devolucion.Checked Or rb_facturar_pedido.Checked Then
        '    If rb_facturar_pedido.Checked Then
        '        cboTipoDoc.Enabled = False
        '    Else
        '        checkSinGuia.Checked = True
        '        checkSinGuia.Enabled = False
        '        gbOpciones.Enabled = False
        '    End If
        'ElseIf rbFacturaExistencias.Checked = True Or rbsinDescargo.Checked = True Then
        '    checkSinGuia.Checked = True
        '    checkSinGuia.Enabled = False
        '    cboTipoDoc.Enabled = True
        '    gbOpciones.Enabled = True
        'Else
        '    cboTipoDoc.Enabled = True
        '    If cboTipoDoc.Text = "FT" Then
        '        checkSinGuia.Checked = True ' False
        '        checkSinGuia.Enabled = False ' True
        '        rbunalinea.Checked = True
        '        cboSerieDoc.Text = "F001"
        '        GroupBox8.Text = " &Tipo de la Glosa de la Factura"
        '    ElseIf cboTipoDoc.Text = "BV" Then
        '        cboSerieDoc.Text = "B001"
        '    Else
        '        checkSinGuia.Checked = True
        '        checkSinGuia.Enabled = False
        '        rbunalinea.Checked = True
        '        GroupBox8.Text = "&Tipo de la Glosa del Documento"
        '    End If
        'End If
        'clsFacturaBl = New ClsNegocio.RECEIVABLE
        'dtCabeceraFact_otro = New DataTable
        'Dim flag_modifica_precio As String

        '---Mostrando Datos de Cabecera
        'dtCabeceraFact_otro = clsFacturaBl.Get_Validacion_Modifica_Precio(cboTipoDoc.Text, cboSerieDoc.Text)
        'If dtCabeceraFact_otro.Rows.Count > 0 Then
        '    flag_modifica_precio = dtCabeceraFact_otro.Rows(0).Item("IS_UPDATE_PRECIO").ToString
        '    If flag_modifica_precio = "S" Then
        '        txtprecioUnitario.ReadOnly = False
        '        txtprecioUnitario_fraccion.ReadOnly = False
        '    Else
        '        txtprecioUnitario.ReadOnly = False
        '        txtprecioUnitario_fraccion.ReadOnly = False
        '    End If
        'End If
    End Sub

    

    Private Sub txtVendedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedor.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub
    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden <> "" Then
            If txtFiltro.Text = String.Empty Then
                dtv.RowFilter = String.Empty
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                Exit Sub
            Else
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvDocumentosFactura.Columns("Numero").Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvDocumentosFactura.Columns("Codigo").Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvDocumentosFactura.Columns("Cliente").Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvDocumentosFactura.Columns("Numero").Name & "+" & dgvDocumentosFactura.Columns("Codigo").Name & "+" & dgvDocumentosFactura.Columns("Cliente").Name
                                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                Exit Sub
                            End If
                        End If
                    End If
                End If
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
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
        txtNumDocRef.Focus()
    End Sub

    Private Sub txttipoDocRef_DoubleClick(sender As Object, e As EventArgs) Handles txttipoDocRef.DoubleClick
        TipoDocumento()
    End Sub

    Private Sub Limpiar_FacturaNotasCredito()
        If rbDocRef_varios.Checked = False Then
            txtCodCliente.Text = ""
            txtRucDni.Text = ""
            txtRazonSocial.Text = ""
            txtDireccion.Text = ""
            txtVendedor.Text = ""
            txtFormaPago.Text = ""
        End If
        txtcotizacion.Text = ""
        txtordenCompra.Text = ""
        txtpedido.Text = ""
        txtCodTrans.Text = ""
        cboDirEntrega.Text = ""
        cboDirEntrega.DataSource = Nothing
        cboDirEntrega.Items.Clear()
        lblFormaPago.Text = ""
        lblVendedor.Text = ""
        GenerarColummnaDataTable()

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
                    txtCodTrans.Text = ""
                    cboDirEntrega.Text = ""
                    If CDbl(dtCabeceraFact.Rows(i).Item("AMOUNT_TAX").ToString) = 0 Then
                        IGV_POR_ITEM = 0
                    Else
                        clsIgvArticuloBL = New ClsTransacciones.clsPedidos
                        dtIgvArticulo = New DataTable("IGV_SISTEMA")
                        po_TasaIgv = 0.0
                        dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvsSistema()
                        po_TasaIgv = CDbl(dtIgvArticulo.Rows(0).Item("AMOUNT_TAX"))
                        IGV_POR_ITEM = po_TasaIgv
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
                        'cboDirEntrega.DataSource = Nothing
                        'cboDirEntrega.Items.Clear()
                        'cboDirEntrega.Items.Add(dtDatos.Rows(0).Item("ADDR_DLV").ToString)
                        'cboDirEntrega.SelectedIndex = 0
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
                dtdetalleArticuloPrincipal = clsFacturaCabBl.get_DetalleFacturacionNotaCredito(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, cboTipoDoc.Text)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    chkSinIGV.Checked = True

                    'Formato_Grillas()
                    Fl_NC_REF = True
                Else
                    MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                    ''CALCULANDO TOTALES GENERALES
                    

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
                MostrandoFacturaNotasCredito(txttipoDocRef.Text, txtSerieDocRef.Text, txtNumDocRef.Text)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoFacturaGuias(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String)
        Try
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtDetalleFact = New DataTable
            '---Mostrando datos del Detalle
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = clsFacturaCabBl.get_DetalleFacturacionGuiasRemision(_DOCUMENT_ID, _NUMBER_SERIE + _NUMBER_DOCUMENT)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                chkSinIGV.Checked = True
            Else
                MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                ''CALCULANDO TOTALES GENERALES
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_NumeroDocumentosReferenciaGuias()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_R_RECEIVABLE_GUIAS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Listado de Guias"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtNumDocRef.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtSerieDocRef.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                MostrandoFacturaGuias("GS", txtSerieDocRef.Text, txtNumDocRef.Text)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtNumDocRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtNumDocRef.MouseDoubleClick

        If txtPtoVenta.Text = String.Empty Then
            MsgBox("Debe seleccionar un Punto Venta.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf txttipoDocRef.Text = String.Empty Then
            MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If cboTipoDoc.Text = "NC" Then
            
        End If
        
    End Sub

    Private Sub txttipoDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txttipoDocRef.KeyDown
        If e.KeyCode = Keys.F1 Then
            TipoDocumento()
        End If
    End Sub

    'Private Sub dtpFechaFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFechaFactura.KeyPress
    '    'If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    'End Sub


    'Private Sub txtBuscarOrdenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarOrdenCompra.KeyPress
    '    'If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
    '    '    e.Handled = False
    '    'ElseIf Char.IsControl(e.KeyChar) Then
    '    '    e.Handled = False
    '    'Else
    '    '    e.Handled = True
    '    'End If
    'End Sub

    Private Sub txtordenCompra_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtordenCompra.MouseDoubleClick
        If txtCodCliente.Text = String.Empty Then
            MsgBox("Es necesario Elegir un Cliente para poder Continuar.", MsgBoxStyle.Information)
            txtCodCliente.Focus()
            Exit Sub
        End If
        GbCabecera.Enabled = False
        'txtBuscarOrdenCompra.Text = String.Empty
        'PnlBuscarordenCompra.Visible = True
        'txtBuscarOrdenCompra.Focus()
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

    

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub



    'Private Sub txtFiltroCliente_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroCliente.TextChanged
    '    Dim wbusqueda As String = UCase(txtFiltroCliente.Text)
    '    Dim myCurrencyManager As CurrencyManager
    '    myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
    '    Dim INTnewpos As Integer
    '    dtv.RowFilter = STRordenCliente & " like '%" & txtFiltroCliente.Text & "%'"
    '    myCurrencyManager.Position = INTnewpos
    'End Sub

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

    Private Sub btnDespacho_Click(sender As Object, e As EventArgs)
        If dgvDocumentosFactura.RowCount() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        If dgvDocumentosFactura.CurrentRow.Cells("Estado").Value.ToString = "COBRADO" Then
            MsgBox("EL documento ya fue cobrado, no procede la cobranza.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            Dim _DOCUMENT_ID As String, _NUMBER_SERIE As String, _NUMBER_DOCUMENT As String
            _DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("DOCUMENT_ID").Value
            _NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value
            _NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_DOCUMENT").Value
            If MessageBox.Show("¿Desea Generar el  Cobro de " & _DOCUMENT_ID & " " & _NUMBER_SERIE & _NUMBER_DOCUMENT & ".?", "Cobranza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                If clsFacturaBl.GenerarCobro(_DOCUMENT_ID, _NUMBER_SERIE & _NUMBER_DOCUMENT, _
                                             Date.Now.ToString("dd/MM/yyyy"), LibComunVar.ClsVarComun.USUARIO) Then
                    MsgBox("Cobro realizado correctamente", MsgBoxStyle.Information)

                    clsFacturaBl = New ClsNegocio.RECEIVABLE
                    dtValidacion = New DataTable("Validacion")
                    dtValidacion = clsFacturaBl.Get_Validacion(_DOCUMENT_ID, _NUMBER_SERIE)
                    If dtValidacion.Rows.Count > 0 Then
                        _GENERA_ESTADO_CUENTA = dtValidacion.Rows(0).Item("IS_GENERA_ASIENTO_VENTA").ToString
                        If _GENERA_ESTADO_CUENTA = "S" Then
                            Call btnContabilizar_Click(sender, e)
                            'Exit Sub
                        End If
                    End If
                    'btnDespacho.Visible = False
                    DocumentosFactura()
                    'btnDespacho.Enabled = NIVEL_ACCESO()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ImprimirVoucher(ByRef _DOCUMENT_ID As String, ByRef _NUMBER_SERIE As String, ByRef _NUMBER_DOCUMENT As String)
        Try
            ''Imprimiendo
            If MessageBox.Show("¿Desea imprimir el Documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                reporteBL = New ClsBuscar
                crystalBL = New LibReportes.ClsReporte
                Me.Cursor = Cursors.WaitCursor
                dtImprimir = New DataTable("CONSULTA")
                Dim SQL As String = String.Empty
                SQL = "SELECT * FROM CO_TB_ASIENTO_DET WHERE AD_TDOC='" & _DOCUMENT_ID & "' AND AD_SDOC='" & _NUMBER_SERIE.PadLeft(5, Char.Parse("0")) & "' AND AD_NDOC='" & _NUMBER_DOCUMENT.PadLeft(15, Char.Parse("0")) & "'"
                dtImprimir = reporteBL.EjecutarConsulta(SQL)
                If dtImprimir.Rows.Count() <> 0 Then
                    Dim CodAsiento As String = dtImprimir.Rows(0).Item("AD_IDCAB").ToString
                    reporteBL = New ClsBuscar
                    dtImprimir = New DataTable("REPORTE")
                    dtImprimir = reporteBL.EjecutarReporteVoucher(CodAsiento)
                    If dtImprimir.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", "", "", "", "@AC_ID;" & CodAsiento)
                    End If
                    Me.Cursor = Cursors.Default
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnContabilizar_Click(sender As Object, e As EventArgs)
        If dgvDocumentosFactura.RowCount() = 0 Then
            MsgBox("No hay documentos para Contabilizar.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            If dgvDocumentosFactura.CurrentRow Is Nothing Then
                dgvDocumentosFactura.Focus()
                Exit Sub
            End If
        End If
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        reporteBL = New ClsBuscar
        dtImprimir = reporteBL.Verif_Contab_Ventas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Strings.Right(Ref_NUMBER_DOCUMENT, 7))
        If dtImprimir.Rows.Count > 0 Then
            If dtImprimir.Rows(0).Item("AC_ID").ToString <> "" Then
                If dtImprimir.Rows(0).Item("AC_ID").ToString <> 0 Then
                    MsgBox("El documento se encuentra contabilizado." & Chr(13) & " No procede la contabilización.", MsgBoxStyle.Critical, "Sistemas")
                Else
                    If MessageBox.Show("¿Desea Contabilizar el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If Contabilizar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = True Then

                        End If
                    End If
                End If
            Else
                If MessageBox.Show("¿Desea Contabilizar el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If Contabilizar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = True Then

                    End If
                End If
            End If
        End If
    End Sub


    Private Function FechaFacturacion(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            If Mes_Ant = 1 Then
                Mes_Ant = "12"
                Anio_Ant = CInt(Anio_Ant) - 1
            Else
                Mes_Ant = CInt(Mes_Ant) - 1
                Anio_Ant = anyo
            End If

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.ValidarFechaVentas(Mes_Ant, Anio_Ant, "CIERRE")
            If dtCierre.Rows.Count() <> 0 Then
                If dtCierre.Rows(0).Item(0) = 1 Then
                    MsgBox("Fecha invalida para facturar.", MsgBoxStyle.Critical)
                    Estado = False
                    Flag_Verificar = True
                    Exit Try
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Function FechaFacturacion_Mes_anterior(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            'If Mes_Ant = 1 Then
            '    Mes_Ant = "12"
            '    Anio_Ant = CInt(Anio_Ant) - 1
            'Else
            '    Mes_Ant = CInt(Mes_Ant) - 1
            '    Anio_Ant = anyo
            'End If
            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.ValidarFechaVentas(Mes_Ant, Anio_Ant, "CIERRE")
            If dtCierre.Rows.Count() <> 0 Then
                ' Dim Resultado As Integer
                If dtCierre.Rows(0).Item(0) = 1 Then
                    'MsgBox("Fecha invalida para facturar.", MsgBoxStyle.Critical)
                    MsgBox("El mes seleccionado se encuentra cerrado," & Chr(13) & "aperturar para proceder con la Facturación.", MsgBoxStyle.Critical)
                    Estado = False
                    Flag_Verificar = True
                    Exit Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function


    Private Sub dtpFechaFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaFactura.KeyDown
        Flag_Verificar = False
        If e.KeyCode = Keys.Enter Then
            If FechaFacturacion_Mes_anterior(dtpFechaFactura.Value.Month, dtpFechaFactura.Value.Year) = False Then
                '    btnCancelar_Click(sender, e)
                'Else
                '    If FechaFacturacion(dtpFechaFactura.Value.Month + 1, dtpFechaFactura.Value.Year) = False Then btnCancelar_Click(sender, e)
            End If
            validar_Fecha()
        End If
    End Sub

    Private Sub dtpFechaFactura_Leave(sender As Object, e As EventArgs) Handles dtpFechaFactura.Leave
        If Flag_Verificar = False Then
            If FechaFacturacion_Mes_anterior(dtpFechaFactura.Value.Month, dtpFechaFactura.Value.Year) = False Then
                '    btnCancelar_Click(sender, e)
                'Else
                '    If FechaFacturacion(dtpFechaFactura.Value.Month + 1, dtpFechaFactura.Value.Year) = False Then
                '        btnCancelar_Click(sender, e)
                '    End If
            End If
        End If
        validar_Fecha()
    End Sub

    Private Sub rbDocRef_varios_CheckedChanged(sender As Object, e As EventArgs) Handles rbDocRef_varios.CheckedChanged
        If Modo_editar = True Then Exit Sub
        If cboTipoDoc.Text <> "NC" Then
            rbDocRef_uno.Checked = True
            Exit Sub
        End If

        If txtCodCliente.Text = "" Then
            MsgBox("Debe seleccionar un Cliente para poder Elegir esta opcion.", MsgBoxStyle.Information)
            txtCodCliente.Focus()
            rbDocRef_uno.Checked = True
            Exit Sub
        End If
        'pnlDocReferencia.Visible = rbDocRef_varios.Checked
        'If pnlDocReferencia.Visible = True Then GenerarColummnaDataTable_Documento_Referencia()
        txttipoDocRef.Enabled = Not rbDocRef_varios.Checked
        txtSerieDocRef.Enabled = Not rbDocRef_varios.Checked
        txtNumDocRef.Enabled = Not rbDocRef_varios.Checked
        GbCabecera.Enabled = Not rbDocRef_varios.Checked
        Limpiar_FacturaNotasCredito()
    End Sub

    'Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
    '    Try
    '        Dim row As DataRow = Dt_principal_lista_Doc_Ref.NewRow
    '        If txtref_tipo.Text = String.Empty Then
    '            MsgBox("Debe seleccionar un Tipo de Doc.", MsgBoxStyle.Information)
    '            txtref_tipo.Focus()
    '            Exit Try
    '        End If
    '        If txtref_serie.Text = String.Empty Then
    '            MsgBox("Debe ingresar una serie.", MsgBoxStyle.Information)
    '            txtref_serie.Focus()
    '            Exit Try
    '        End If
    '        If txtref_num_doc.Text = String.Empty Then
    '            MsgBox("No se asigno un numero de documento.", MsgBoxStyle.Critical)
    '            txtref_num_doc.Focus()
    '            Exit Try
    '        End If
    '        If txtref_igv.Text = String.Empty Then
    '            MsgBox("Debe asignar el valor del Igv.", MsgBoxStyle.Critical)
    '            txtref_igv.Focus()
    '            Exit Try
    '        End If
    '        If txtref_monto.Text = String.Empty Then
    '            MsgBox("Debe ingresar un monto.", MsgBoxStyle.Information)
    '            txtref_monto.Focus()
    '            Exit Try
    '        End If
    '        Dim Resultado() As DataRow
    '        Resultado = Dt_principal_lista_Doc_Ref.Select("TIPO_DOC='" & txtref_tipo.Text & "' and SERIE_DOC='" & txtref_serie.Text & "' and NUM_DOC='" & txtref_num_doc.Text & "' ", "")
    '        If Resultado.Count() <> 0 Then
    '            MsgBox("El documento ya se ingreso anteriormente.", MsgBoxStyle.Critical)
    '            Exit Try
    '        End If

    '        Dim VentasBl As ClsOperaciones.RECEIVABLE
    '        VentasBl = New ClsOperaciones.RECEIVABLE
    '        Dim dtVerficarNc As New DataTable
    '        dtVerficarNc = VentasBl.Verificacion_Existencia_Doc_Ref(txtref_tipo.Text, txtref_serie.Text, txtref_num_doc.Text, txtCodCliente.Text)
    '        If dtVerficarNc.Rows.Count() <> 0 Then
    '            MsgBox("El numero de documento ya se encuentra  anexado en otro Documento NC: " & dtVerficarNc.Rows(0).Item("NUMBER_SERIE").ToString & " - " & dtVerficarNc.Rows(0).Item("NUMBER_DOCUMENT").ToString, MsgBoxStyle.Critical)
    '            If MsgBox("Desea agregar el documento como referencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
    '                row("TIPO_DOC") = txtref_tipo.Text
    '                row("SERIE_DOC") = txtref_serie.Text
    '                row("NUM_DOC") = txtref_num_doc.Text
    '                row("FECHA_DOC") = dtpRef_fecha.Value
    '                row("MONTO") = txtref_monto.Text
    '                row("IGV") = txtref_igv.Text
    '                Dt_principal_lista_Doc_Ref.Rows.Add(row)
    '                Dt_principal_lista_Doc_Ref.AcceptChanges()
    '                Limpiar_Lista_Doc()
    '                txtref_tipo.Focus()
    '                Exit Sub
    '            Else
    '                Exit Sub
    '            End If

    '        End If
    '        row("TIPO_DOC") = txtref_tipo.Text
    '        row("SERIE_DOC") = txtref_serie.Text
    '        row("NUM_DOC") = txtref_num_doc.Text
    '        row("FECHA_DOC") = dtpRef_fecha.Value
    '        row("MONTO") = txtref_monto.Text
    '        row("IGV") = txtref_igv.Text
    '        Dt_principal_lista_Doc_Ref.Rows.Add(row)
    '        Dt_principal_lista_Doc_Ref.AcceptChanges()
    '        Limpiar_Lista_Doc()
    '        txtref_tipo.Focus()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Public Sub Limpiar_Lista_Doc()
    '    'txtref_tipo.Text = String.Empty
    '    'txtref_serie.Text = String.Empty
    '    txtref_num_doc.Text = String.Empty
    '    dtpRef_fecha.Value = Date.Now
    '    txtref_monto.Text = String.Empty
    '    txtref_igv.Text = String.Empty
    'End Sub

    'Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
    '    pnlDocReferencia.Visible = False
    '    Limpiar_Lista_Doc()
    '    If Dt_principal_lista_Doc_Ref.Rows.Count() = 0 Then
    '        rbDocRef_uno.Checked = True
    '    Else
    '        txttipoDocRef.Text = String.Empty
    '        txtSerieDocRef.Text = String.Empty
    '        txtNumDocRef.Text = String.Empty
    '    End If
    '    GbCabecera.Enabled = True
    'End Sub

    'Private Sub btnSalr_Click(sender As Object, e As EventArgs) Handles btnSalr.Click
    '    pnlDocReferencia.Visible = False
    '    Limpiar_Lista_Doc()
    '    rbDocRef_uno.Checked = True
    '    GbCabecera.Enabled = True
    '    txttipoDocRef.Text = String.Empty
    '    txtSerieDocRef.Text = String.Empty
    '    txtNumDocRef.Text = String.Empty
    'End Sub

    'Private Sub dgv_Lista_Doc_Ref_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_Lista_Doc_Ref.KeyDown
    '    If e.KeyCode = Keys.Delete Then
    '        Dim fila As Integer = dgv_Lista_Doc_Ref.CurrentRow.Index
    '        Dt_principal_lista_Doc_Ref.BeginInit()
    '        Dt_principal_lista_Doc_Ref.Rows(fila).Delete()
    '        Dt_principal_lista_Doc_Ref.EndInit()
    '        Dt_principal_lista_Doc_Ref.AcceptChanges()
    '    End If
    'End Sub

    Private Sub txtref_tipo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub



    Private Sub dgvDocumentosFactura_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDocumentosFactura.CellFormatting

        If dgvDocumentosFactura.Rows(e.RowIndex).Cells("Situacion").Value = "ANULADO" Then
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

   

    Private Sub imprimirNotaCreditosLetras(ByVal PuntoVenta As String, ByVal SERIE As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteNotaCreditos_letras(PuntoVenta, SERIE, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("FT_NC.rpt", "", "", "", "@PLACE_SALES;" & PuntoVenta, "@SERIE;" & SERIE, "@NUMBER;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_consultando_Click(sender As Object, e As EventArgs)
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim clsVentas As New ClsOperaciones.RECEIVABLE
            Dim ref_PuntoVenta As String = String.Empty
            Ref_NUMBER_SERIE = String.Empty
            Ref_NUMBER_DOCUMENT = String.Empty

            ref_PuntoVenta = dgvDocumentosFactura.CurrentRow.Cells("PV").Value
            Ref_DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("DOCUMENT_ID").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_DOCUMENT").Value

            If Ref_DOCUMENT_ID <> "FT" Then Exit Sub
            imprimirNotaCreditosLetras(ref_PuntoVenta, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboopcionesBusqueda.Select()
        End If
    End Sub

    Private Sub cboOpcionTipoDoc_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cboopcionesBusqueda.Select()
        End If
    End Sub

    Private Sub cboopcionesBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboopcionesBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvDocumentosFactura.Select()
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub


    Private Sub MostrandoDocumentoPedidos()
        Try
            Dim FacturaBl As New ClsOperaciones.RECEIVABLE
            dtDetalleFact = New DataTable("Documento_Pedidos")
            dtv = New DataView
            dtDetalleFact = FacturaBl.Documento_pedido()
            dtv = dtDetalleFact.DefaultView
            If dtDetalleFact.Rows.Count() <> 0 Then
                'pnl_pedido.Visible = True
                'dgv_cab_ped.DataSource = dtv
                'dgv_cab_ped.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'STRordenPedido = dgv_cab_ped.Columns(0).Name & "+" & dgv_cab_ped.Columns(2).Name & "+" & dgv_cab_ped.Columns(3).Name
                'dgv_cab_ped.Columns(1).ReadOnly = True
                'dgv_cab_ped.Columns(2).ReadOnly = True
                'txt_filtrar_pedido.Text = String.Empty
                'txt_filtrar_pedido.Select()
            Else
                MsgBox("No hay documentos para mostrar.", MsgBoxStyle.Information, "Sistemas")
                'pnl_pedido.Visible = False
                GenerarColummnaDataTable()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub txtCodCliente_Leave(sender As Object, e As EventArgs) Handles txtCodCliente.Leave
    '    If txtCodCliente.Text = "" Then Exit Sub
    '    Ayuda_Clientes(txtCodCliente.Text)
    'End Sub

    Private Sub txtVendedor_Leave(sender As Object, e As EventArgs) Handles txtVendedor.Leave
        If txtVendedor.Text = "" Then Exit Sub
        Ayuda_Vendedor(txtVendedor.Text)
    End Sub

    Private Sub txtFormaPago_Leave(sender As Object, e As EventArgs) Handles txtFormaPago.Leave
        If txtFormaPago.Text = "" Then Exit Sub
        Ayuda_FormaPago(txtFormaPago.Text)
    End Sub


    Private Sub btn_modificar_Click(sender As Object, e As EventArgs)
        If dgvDocumentosFactura.RowCount() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Modo_editar = True

        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Ref_ALMACEN = String.Empty
        Dim Store As String = String.Empty
        Dim msj As String = String.Empty
        Dim Usuario As String = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        If Ref_DOCUMENT_ID = "CP" Then Exit Sub
        ''Validaciones propias de la edicion de la Facturacion
        If MessageBox.Show("¿Desea modificar el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Verificando Cancelacion
            Store = "FACT_SP_S_R_VERIFICAR_CANCEL"
            If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                msj = String.Empty
                msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Cancelacion , no se puede modificar."
                MsgBox(msj, MsgBoxStyle.Critical)
                'btnCancelar.PerformClick()
                Exit Sub
            Else
                'Verificando si posee Letra
                Store = String.Empty
                Store = "FACT_SP_S_R_VERIFICAR_LETRA"
                If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                    msj = String.Empty
                    msj = "   EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Letra , no se puede modificar."
                    MsgBox(msj, MsgBoxStyle.Critical)
                    'btnCancelar.PerformClick()
                    Exit Sub
                Else
                    Store = String.Empty
                    Store = "FACT_SP_S_R_VERIFICAR_CONTABILIZACION"
                    If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                        msj = String.Empty
                        msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " esta contabilizado, no se puede Eliminar."
                        MsgBox(msj, MsgBoxStyle.Critical)
                        ' btnCancelar.PerformClick()
                        Exit Sub
                    End If
                End If
            End If
            'Mostrando resultados
            Botonera_Estado_Cambiar(True)
            MostrarModoConsultar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
            pnlPrincipal.Visible = False
            GbCabecera.Enabled = True
            'btnDespacho.Visible = False
            Dim Estado As String = String.Empty
            Estado = dgvDocumentosFactura.CurrentRow.Cells("Estado").Value
        Else
            btnCancelar.PerformClick()
        End If
    End Sub

    Private Sub Ayuda_NumeroDocumentosDevoluciones()
        Try
            Dim frm As New frmBuscar
            TIPO_DEV = ""
            NUM_DEV = ""
            POSICION_DEV = ""
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_DOCUMENTOS_DEVOLUCIONES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Listado de documentos de Devolucion"
            frm._Flag_Ajuste_Automatico = True
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'pnl_devoluciones.Visible = True
                'dgv_detalle_dev.DataSource = Nothing
                GbCabecera.Enabled = False
                TIPO_DEV = frm.Data_Matriz.Rows(0).Item(0).ToString
                NUM_DEV = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtSerieDocRef.Text = "001"
                txtNumDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtCodCliente.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txtdescCli.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtRucDni.Text = frm.Data_Matriz.Rows(0).Item(4).ToString
                txtDireccion.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                dtdetalleArticuloPrincipal.Rows.Clear()
                'Motrando_detalles_devolucion(frm.Data_Matriz.Rows(0).Item(0).ToString, frm.Data_Matriz.Rows(0).Item(1).ToString, txtAlmacen.Text)
                Ayuda_Clientes(frm.Data_Matriz.Rows(0).Item(2).ToString)
            Else
                'pnl_devoluciones.Visible = False
                GbCabecera.Enabled = True
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Ayuda_Vehiculos()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_VEHICULOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de vehiculos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_vehiculo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            frm.Close()
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub txt_vehiculo_DoubleClick(sender As Object, e As EventArgs) Handles txt_vehiculo.DoubleClick
        Ayuda_Vehiculos()
    End Sub

    Private Sub txt_vehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_vehiculo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vehiculos()
        End If
    End Sub

    'Private Sub Ayuda_Transporte()
    '    Dim frm As New frmBuscar
    '    Try
    '        Dim sql As String = String.Empty
    '        sql = "FACT_SP_S_EMPRESA_TRANSPORTE"
    '        frm.CadenaConsulta = sql
    '        frm.Titulo = "Lista de empresa de transportes"
    '        frm.ShowDialog()
    '        If frm.Data_Matriz.Rows.Count > 0 Then
    '            txt_Empresa.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
    '        End If
    '        frm.Close()
    '    Catch ex As Exception
    '        frm.Close()
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub txt_Empresa_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_Empresa.MouseDoubleClick
        Ayuda_Transporte()
    End Sub

    Private Sub txt_Empresa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Empresa.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Transporte()
        End If
    End Sub

    Private Sub Ayuda_Tramas()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_TRAMAS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de vehiculos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_trama.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            frm.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub txt_trama_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_trama.MouseDoubleClick
        Ayuda_Tramas()
    End Sub

    Private Sub txt_trama_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_trama.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tramas()
        End If
    End Sub

    Private Sub dtpFechaFactura_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFactura.ValueChanged
        validar_Fecha()
    End Sub

    

    Private Function ValidarUsuariosIngreso() As Boolean
        Dim estado As Boolean = True
        Dim STRUserSys As String, STRPassSys As String
        Try
            ClsUsuarioBl = New LibSeguridad.ClsUsuario
            ClsData = New LibConexion.ClsData
            dtUsuarioAcceso = New DataTable
            Dim codigoUsuario As String = String.Empty
            codigoUsuario = "admin"
            dtUsuarioAcceso = ClsUsuarioBl.ValidarUsuariosIngresos(codigoUsuario)
            If dtUsuarioAcceso.Rows.Count() <> 0 Then
                If ClsUsuarioBl.ESTADO = "N" Then
                    MessageBox.Show("El estado del usuario ingresado se encuentra Inactivo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    estado = False
                    Exit Try
                Else
                    STRUserSys = ClsUsuarioBl.CODUSUARIO
                    STRPassSys = ClsUsuarioBl.PASSUSUARIO
                    STRPassSys = ClsData.DesEncryptString(STRPassSys)
                    'If txtpassword.Text = STRPassSys Then
                    '    estado = True
                    '    Exit Try
                    'ElseIf txtpassword.Text <> STRPassSys Then
                    '    MessageBox.Show("El password ingresado es incorrecto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    estado = False
                    '    Exit Try
                    'End If
                End If
            Else
                MessageBox.Show("El Usuario ingresado es incorrecto o no Existe, Verifique.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    
    Private Sub txt_tip_nota_electronica_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tip_nota_electronica.MouseDoubleClick
        Ayuda_Tipo_Nota_Electronica()
    End Sub

    Private Sub txt_tip_nota_electronica_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tip_nota_electronica.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Tipo_Nota_Electronica()
        If e.KeyCode = Keys.Enter Then
            If txt_tip_nota_electronica.Text = String.Empty Then
                Ayuda_Tipo_Nota_Electronica()
            Else
                Ayuda_Tipo_Nota_Electronica(txt_tip_nota_electronica.Text)
            End If
        End If
    End Sub
    Private Sub Ayuda_Tipo_Nota_Electronica(Optional ByVal _codigo_Nota As String = "")
        Try
            If _codigo_Nota = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "SAL_HLP_FIND_TIPO_NOTA_ELECTRONICA"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = cboTipoDoc.Text
                frm.Titulo = "Codigos de Tipo de Nota Electronica"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txt_tip_nota_electronica.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txt_desc_tipo_nota_electronica.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                End If
                frm.Close()
            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Nota_Electronica")
                'dtDetalleFact = clsFacturaBl.Get_Manual_Nota_Electronica(cboTipoDoc.Text, _codigo_Nota)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txt_tip_nota_electronica.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txt_desc_tipo_nota_electronica.Text = dtDetalleFact.Rows(0).Item(1).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txt_tip_nota_electronica.Text = String.Empty
                    txt_desc_tipo_nota_electronica.Text = String.Empty
                    txt_tip_nota_electronica.Select()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub brn_reenvio_factron_Click(sender As Object, e As EventArgs)
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Dim STREstado As String = String.Empty
        STREstado = dgvDocumentosFactura.CurrentRow.Cells("Estado").Value
        If STREstado = "ANULADO" Then
            MessageBox.Show("El Documento se encuentra ANULADO, no procede el envio. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        STREstado = dgvDocumentosFactura.CurrentRow.Cells("Estado.FE").Value
        If STREstado = "ENVIADO" Then
            MessageBox.Show("El Documento se encuentra ENVIADO a FE, no procede el envio. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ref_fecha_doc = dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value
        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Dim STRmontotexto = String.Empty

        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        If Strings.Left(Ref_NUMBER_SERIE, 1) <> "F" And Strings.Left(Ref_NUMBER_SERIE, 1) <> "B" Then
            MessageBox.Show("El documento no es Electronico, no procede el envio. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea Reenviar el Documento : " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor

            If dgvDocumentosFactura.CurrentRow.Cells("Moneda").Value = "MN" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(dgvDocumentosFactura.CurrentRow.Cells("Monto").Value)))) & "   SOLES"
            Else
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(dgvDocumentosFactura.CurrentRow.Cells("Monto").Value)))) & "   DOLARES AMERICANOS"
            End If

            If Reenvio_Docs_Electronicos(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))), STRmontotexto) = False Then
                MsgBox("Hubo un error, no se completo el Proceso de Reenvio del Documento Electronico.", MsgBoxStyle.Critical)
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                MsgBox("Documento Reenviado Correctamente." & vbCrLf & " Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT, MsgBoxStyle.Information)
                DocumentosFactura()
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub


    Private Function AgregarArticuloManual(ByVal _codigoArticulo As String) As Boolean
        Try

            'Me.Cursor = Cursors.WaitCursor

            'clsArticuloBl = New ClsOperaciones.PART
            'dtDocumentoGuias = New DataTable
            'dtDocumentoGuias = clsArticuloBl.get_VerificacionArticuloCodigoFactura(txtAlmacen.Text.Trim, _codigoArticulo, True, cboTipoDoc.Text, False, _ARTS_INICIALES)
            'Dim codArticulo As String = String.Empty
            'If dtDocumentoGuias.Rows.Count() <> 0 Then
            '    txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
            '    txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
            '    _txt_unidad_producto = dtDocumentoGuias.Rows(0).Item("UNID_MED").ToString
            '    txtprecioUnitario.Text = dtDocumentoGuias.Rows(0).Item("PRECIO").ToString
            '    IGV_POR_ITEM = dtDocumentoGuias.Rows(0).Item("IGV")
            '    txtStock.Text = Format(dtDocumentoGuias.Rows(0).Item("STOCK"), "##,##0.0.0")
            '    TIPO_ISC = dtDocumentoGuias.Rows(0).Item("TIPO_ISC")
            '    ISC_POR = dtDocumentoGuias.Rows(0).Item("ISC_POR")
            '    Me.Cursor = Cursors.Default
            '    Return True
            'Else
            '    Me.Cursor = Cursors.Default
            '    MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Exclamation)
            '    txtcodigoArticulo.Text = String.Empty
            '    txtdescripcionArticulo.Text = String.Empty
            '    txtcantidad.Text = String.Empty
            '    txtprecioUnitario.Text = String.Empty
            '    txtStock.Text = String.Empty
            '    _txt_unidad_producto = String.Empty
            '    IGV_POR_ITEM = 0
            '    TIPO_ISC = 0
            '    ISC_POR = 0
            '    txtcodigoArticulo.Focus()
            '    Return False
            'End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub txtprecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    'Private Sub Formato_Grillas()
    '    If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
    '        dgvDetalle.DataSource = dtdetalleArticuloPrincipal
    '        dgvDetalle.Columns("ITEM").Width = 25
    '        dgvDetalle.Columns("CODIGO").Width = 70
    '        dgvDetalle.Columns("DESCRIPCION").Width = 200
    '        dgvDetalle.Columns("PRESENTACION").Width = 200
    '        dgvDetalle.Columns("UNIDAD").Width = 40
    '        dgvDetalle.Columns("CANTIDAD").Width = 70
    '        dgvDetalle.Columns("CANTIDAD_FRACCION").Width = 70
    '        dgvDetalle.Columns("PREC_UNITARIO").Width = 50
    '        dgvDetalle.Columns("PREC_UNITARIO_FRACCION").Width = 50
    '        dgvDetalle.Columns("VALOR_VENTA").Width = 100
    '        dgvDetalle.Columns("LOTE").Width = 80
    '    End If

    'End Sub

    Private Sub txt_por_Des_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Function Generar_XML_Comunicacion_Baja(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Fecha_baja As String, _
                                                   ByRef ID_COMUNICACION_BAJA_ As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            'If clsFacturaBl.Generar_XML_Comunicacion_Baja(TipoDoc, SerieDoc, NumDoc, Ruta_FE() & "\InputXML", Fecha_baja, ID_COMUNICACION_BAJA_) Then
            '    Return True
            'Else
            '    Return False
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Private Sub btn_Apertura_Doc_Click(sender As Object, e As EventArgs)
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Dim STREstado As String = String.Empty
        STREstado = dgvDocumentosFactura.CurrentRow.Cells("Estado").Value
        If STREstado = "ANULADO" Then
            MessageBox.Show("El Documento ya se encuentra anulado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Strings.Left(dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value, 1) = "B" Or Strings.Left(dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value, 1) = "F" Then
            If CInt(dgvDocumentosFactura.CurrentRow.Cells("DIAS").Value) > 7 Then
                Me.Cursor = Cursors.Default
                MsgBox("No aplica el Proceso de APERTURA" & Chr(13) & " por superar el limite de día habiles.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        ref_fecha_doc = dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value
        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        If dgvDocumentosFactura.CurrentRow.Cells("IS_CLOSED").Value = True Then
            If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
            If MessageBox.Show("¿Desea Aperturar el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                If Apertura_Documento(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de APERTURA del documeto elegido.", MsgBoxStyle.Exclamation)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    DocumentosFactura()
                    Dim msj As String
                    msj = String.Empty
                    msj = "APERTURA de documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " generado correctamente."
                    MsgBox(msj, MsgBoxStyle.Information)
                End If

                Me.Cursor = Cursors.Default
            End If
        End If


    End Sub


    Public Property Data_Matriz() As DataTable
        Get
            Return dtHelp
        End Get
        Set(ByVal Value As DataTable)
            dtHelp = Value
        End Set
    End Property


    Private Sub txtprecioUnitario_fraccion_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dgvDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellValueChanged
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        Try
            Dim _codigo As Integer = 0
            For i As Integer = 0 To dgvDetalle.Rows.Count - 1
                _codigo = dgvDetalle.Rows(i).Cells("ITEM").Value
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item("CANTIDAD") = dgvDetalle.Rows(i).Cells("CANTIDAD").Value
                    item("CANTIDAD_FRACCION") = dgvDetalle.Rows(i).Cells("CANTIDAD_FRACCION").Value
                    item("TOTAL_INICIAL") = Math.Round(item("CANTIDAD") * item("PRECIO_INICIAL"), 6)
                    item("TOTAL_INICIAL_FRACCION") = Math.Round(item("CANTIDAD_FRACCION") * item("PRECIO_INICIAL_FRACCION"), 6)
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
            Next

            Calcular_Totales()
            If dgvDetalle.Rows.Count() <> 0 Then
                dgvDetalle.CurrentCell = dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells(2)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_agencia_trans_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_agencia_trans.MouseDoubleClick
        Ayuda_Transporte()
    End Sub

    Private Sub Ayuda_Transporte()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_EMPRESA_TRANSPORTE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de empresa de transportes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_agencia_trans.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_agencia_trans.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            frm.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_agencia_trans_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_agencia_trans.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Transporte()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_agencia_trans.Text = String.Empty Then
                Ayuda_Transporte()
            Else
                txt_guia.Focus()
            End If
        End If
    End Sub

    Private Sub txt_provincia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_provincia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_agencia_trans.Focus()
        End If
    End Sub

    Private Sub txt_guia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_guia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_lt_ft.Focus()
        End If
    End Sub

    Private Sub txt_lt_ft_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_lt_ft.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_transferencia.Focus()
        End If
    End Sub

    Private Sub txt_cod_transferencia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_transferencia.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Transferencia()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_transferencia.Text = String.Empty Then
                Ayuda_Transferencia()
            Else
                txt_n_operacion.Focus()
            End If
        End If
    End Sub
    Private Sub Ayuda_Transferencia()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_BANCOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Bancos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_transferencia.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_transferencia.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            frm.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_transferencia_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_transferencia.MouseDoubleClick
        Ayuda_Transferencia()
    End Sub

    Private Sub btn_aprobar_Click(sender As Object, e As EventArgs)
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim STRPedido As String = String.Empty
            Dim STREstado As String = String.Empty
            Dim Estado As String = String.Empty


            STRPedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
            STREstado = dgvDocumentosFactura.CurrentRow.Cells("Situacion").Value
            Estado = dgvDocumentosFactura.CurrentRow.Cells("Estado.Facturacion").Value

            If STREstado = "AUTORIZADO" Or STREstado = "APROBADO" Then
                MessageBox.Show("El pedido ya se encuentra AUTORIZADO/APROBADO, no puede aprobarse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf STREstado = "RECHAZADO" Then
                MessageBox.Show("El pedido se encuentra RECHAZADO, no puede aprobarse .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf STREstado = "ANULADO" Then
                MessageBox.Show("El pedido ya se encuentra ANULADO, no puede aprobarse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf STREstado = "FACTURADO" Then
                MessageBox.Show("El pedido ya se encuentra FACTURADO, no puede aprobarse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Estado = "FACTURADO" Or Estado = "FACTURADO TOTAL" Or Estado = "FACTURADO PARCIAL" Then
                MessageBox.Show("El pedido ya se encuentra FACTURADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("¿Desea APROBAR el pedido N° " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If STREstado = "EMITIDO" Then
                    clsPedidoBl = New ClsOperaciones.ORDERS
                    If clsPedidoBl.APROBAR_Pedido(STRPedido, LibComunVar.ClsVarComun.USUARIO) = True Then
                        MsgBox("Pedido APROBADO correctamente.", MsgBoxStyle.Information)
                        DocumentosFactura()
                    End If
                End If
            End If
            btnCancelar_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboopcionesdespacho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesdespacho.SelectedIndexChanged
        txtFiltro.Text = String.Empty
        DocumentosFactura()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStrip1.Enabled = True
        pnl_despacho_pedidos.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim STRPedido As String = String.Empty
            STRPedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value

            If MessageBox.Show("¿Desea despachar el pedido N° " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                clsPedidoBl = New ClsOperaciones.ORDERS
                If clsPedidoBl.Despachar_Pedido(STRPedido, txt_responsable_despacho.Text, txt_vehiculo_despacho.Text, LibComunVar.ClsVarComun.USUARIO) = True Then
                    MsgBox("Pedido despachado correctamente.", MsgBoxStyle.Information)
                    DocumentosFactura()
                    Button1_Click(sender, e)
                    btnCancelar_Click(sender, e)
                Else
                    Me.Cursor = Cursors.Default
                End If
            Else
                Me.Cursor = Cursors.Default
            End If
            
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click_1(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Dim _Id As String = String.Empty
        _Id = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
        imprimir_pedido(_Id)
    End Sub

    Private Sub btn_imprimir_tk_Click(sender As Object, e As EventArgs) Handles btn_imprimir_tk.Click
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Dim _Id As String = String.Empty
        _Id = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
        imprimir_pedido_Formato_TK(_Id)
    End Sub
    Private Sub imprimir_pedido_Formato_TK(ByVal _Codigo As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Pedidos")
            Dim dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReportePedidos(_Codigo)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                Dim STRmontotexto As String = ""
                If cboMoneda.SelectedValue = "MN" Then
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(dtImprimir.Rows(0).Item("AMOUNT"))))) & " Soles"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(dtImprimir.Rows(0).Item("AMOUNT"))))) & " Dólares Americanos"
                End If

                crystalBL.Muestra_Reporte("SAL_PEDIDO_TK.rpt", dtImprimir, "", "", "@ID;" & _Codigo, _
                                          "LETRAS;" & STRmontotexto)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarOrdenDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarOrdenDeProducciónToolStripMenuItem.Click
        If dgvDetalle.RowCount() = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            ToolStrip1.Enabled = False
            txtcantidad.Text = ""
            txt_cod_formula.Text = ""
            txt_des_formula.Text = ""
            txt_cod_cliente.Text = txtCodCliente.Text
            txt_razon_social.Text = txtRazonSocial.Text
            txtComentarios.Text = ""
            _numero_pedido = ""
            _item = ""
            _codigo_producto = ""
            _numero_pedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
            _codigo_producto = dgvDetalle.CurrentRow.Cells("CODIGO").Value
            _item = dgvDetalle.CurrentRow.Cells("ITEM").Value
            MostrandoAlmacenes()
            dtp_fecha_op.Value = Date.Now
            dtp_fecha_entrega.Value = Date.Now
            pnl_genera_op.Visible = True
            cbo_destinatario.SelectedIndex = -1
            chk_urgente.Checked = False
            pnl_genera_op.BringToFront()
            txt_cod_cliente.Focus()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MostrandoAlmacenes()
        Try
            Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
            Dim dtAlmacen As New DataTable
            dtAlmacen = monedaBL.Mostrar_Almacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            cboalmacen.DataSource = Nothing
            If dtAlmacen.Rows.Count() <> 0 Then
                cboalmacen.DisplayMember = "DESCRIPCION"
                cboalmacen.ValueMember = "CODIGO"
                cboalmacen.DataSource = dtAlmacen
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcantidad_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_formula_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_formula.MouseDoubleClick
        Ayuda_Formulas()
    End Sub

    Private Sub txt_cod_formula_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_formula.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Formulas()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_formula.Text = "" Then
                Ayuda_Formulas()
            Else
                Button3.Select()
            End If

        End If
    End Sub

    Private Sub Ayuda_Formulas()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "lista_formula"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Formulas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_formula.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_des_formula.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ToolStrip1.Enabled = True
        pnl_genera_op.Visible = False
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_destinatario.Focus()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If txt_cod_cliente.Text = "" Then
                MsgBox("Debe elegir un Cliente!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtcantidad.Text = "" Then
                MsgBox("Debe ingresar una cantidad!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If MessageBox.Show("¿Desea generar el Requerimiento de la Orden de Producción " & Chr(13) & "del item seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                'PARTE DE LA PRODUCCION DE ALIMENTOS
                Dim ls_det_alm As New List(Of ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE)
                Dim alm_cabBE As New ClsEntidades.REQUERIMIENTO_PRODUCCION_OP
                Dim alm_detBE As ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE

                Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

                With alm_cabBE
                    .ID = 0
                    .FECHA = dtp_fecha_op.Value.ToString("dd/MM/yyyy")
                    .STATUS = "V"
                    .PART_ID = "" '_codigo_producto
                    .CANTIDAD = 0 'CDbl(txtcantidad.Text)
                    .FACTOR = 1
                    .COSTO = 0
                    .TOTAL = 0
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .COD_CLIENTE = txt_cod_cliente.Text
                    .OBSERVACIONES = txtComentarios.Text
                    .NUMERO_PEDIDO = _numero_pedido
                    .ITEM_PEDIDO = _item
                    .FECHA_ENTREGA = dtp_fecha_entrega.Value.ToString("dd/MM/yyyy")
                    .VENDEDOR = txtVendedor.Text
                    .DESTINATARIO = cbo_destinatario.Text
                    .URGENTE = IIf(chk_urgente.Checked, "SI", "NO")
                End With

                alm_detBE = New ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE
                With alm_detBE
                    .ID_CAB = alm_cabBE.ID
                    .ITEM = 1
                    .CODIGO = _codigo_producto
                    .COSTO = 0
                    .CANTIDAD = CDbl(txtcantidad.Text)
                    .TOTAL = 0
                End With
                ls_det_alm.Add(alm_detBE)

                clsPedidoBl = New ClsOperaciones.ORDERS

                If clsPedidoBl.Guardar_Requerimiento_Produccion_OP(alm_cabBE, ls_det_alm) Then
                    MsgBox("Generación de Requerimiento de Orden de Producción correctamente.", MsgBoxStyle.Information)
                    'DocumentosFactura()
                    Button2_Click(sender, e)

                    clsPedidoBl = New ClsOperaciones.ORDERS
                    GenerarColummnaDataTable()
                    dtdetalleArticuloPrincipal = clsPedidoBl.Modo_Edicion_Detalle2(Ref_DOCUMENT_ID)

                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvDetalle.DataSource = dtdetalleArticuloPrincipal

                        dgvDetalle.Columns(0).HeaderText = "ITEM"
                        dgvDetalle.Columns(1).HeaderText = "CODIGO"
                        dgvDetalle.Columns(2).HeaderText = "CANTIDAD"
                        dgvDetalle.Columns("SALDO").HeaderText = "SALDO"
                        dgvDetalle.Columns("CANTIDAD_HABILITADO").HeaderText = "CANTIDAD HABILITADO PARA FACTURAR"
                        dgvDetalle.Columns("CANTIDAD_FACTURADO").HeaderText = "CANTIDAD FACTURADO"
                        dgvDetalle.Columns(31).Visible = False ' "CANTIDAD FRAC."
                        dgvDetalle.Columns(3).HeaderText = "UM"
                        dgvDetalle.Columns(4).HeaderText = "DESCRIPCION"
                        dgvDetalle.Columns(30).Visible = False '.HeaderText = "PRESENTACION"
                        dgvDetalle.Columns(5).Visible = False '"LOTE"
                        dgvDetalle.Columns(12).HeaderText = "PRECIO "
                        dgvDetalle.Columns(34).Visible = False ' "PRECIO FRAC."
                        dgvDetalle.Columns(7).Visible = False '.HeaderText = "%.Desc.Articulo"
                        dgvDetalle.Columns(8).Visible = False '.HeaderText = "%.Desc.Articulo.2"
                        dgvDetalle.Columns(15).Visible = False '.HeaderText = "TOTAL"
                        dgvDetalle.Columns(39).HeaderText = "TOTAL"
                        dgvDetalle.Columns(36).Visible = False
                        dgvDetalle.Columns(10).Visible = False '.HeaderText = "Importe.desc"
                        dgvDetalle.Columns(11).Visible = False '.HeaderText = "Importe.desc.2"
                        dgvDetalle.Columns(6).Visible = False
                        dgvDetalle.Columns(32).Visible = False
                        dgvDetalle.Columns(13).Visible = False
                        dgvDetalle.Columns(35).Visible = False
                        dgvDetalle.Columns(14).Visible = False
                        dgvDetalle.Columns(9).Visible = False
                        dgvDetalle.Columns(33).Visible = False
                        dgvDetalle.Columns(16).Visible = False
                        dgvDetalle.Columns(37).Visible = False
                        dgvDetalle.Columns(17).Visible = False
                        dgvDetalle.Columns(38).Visible = False
                        dgvDetalle.Columns(18).Visible = False '.HeaderText = "% I.G.V"
                        dgvDetalle.Columns(19).Visible = False
                        dgvDetalle.Columns(20).Visible = False '.HeaderText = "Peso Neto"
                        dgvDetalle.Columns(21).Visible = False '.HeaderText = "Peso Bruto"
                        dgvDetalle.Columns(22).Visible = False
                        dgvDetalle.Columns(23).Visible = False '.HeaderText = "Observaciones"
                        dgvDetalle.Columns(24).Visible = False '.HeaderText = "Doc. Referencia"
                        dgvDetalle.Columns(25).Visible = False '.HeaderText = "N° Referencia"
                        dgvDetalle.Columns(26).Visible = False '.HeaderText = "Item Referencia"
                        dgvDetalle.Columns(27).Visible = False '.HeaderText = "Item Referencia"

                        dgvDetalle.Columns("ESTADO_OP").HeaderText = "ESTADO REQ. O.P."
                        dgvDetalle.Columns("NUMERO_OP").HeaderText = "N° REQ. O.P."

                        For i As Integer = 0 To dgvDetalle.Columns.Count - 1
                            dgvDetalle.Columns(i).ReadOnly = True
                        Next

                        'dgvDetalle.Columns("CANTIDAD").ReadOnly = False
                        dgvDetalle.Columns("SALDO").ReadOnly = False
                        dgvDetalle.Columns("SEL").ReadOnly = False

                        dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("SALDO").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("CANTIDAD_HABILITADO").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("CANTIDAD_FACTURADO").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("%DESC.ART_1").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("%DESC.ART_2").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("TOTAL").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("IMP_DESC_01").DefaultCellStyle.Format = "##,##0.0000"
                        dgvDetalle.Columns("IMP_DESC_02").DefaultCellStyle.Format = "##,##0.0000"
                        dgvDetalle.Columns("PESO_NETO").DefaultCellStyle.Format = "##,##0.000"
                        dgvDetalle.Columns("PESO_BRUTO").DefaultCellStyle.Format = "##,##0.000"
                        dgvDetalle.Columns("ISCPOR").DefaultCellStyle.Format = "##,##0.00"
                        dgvDetalle.Columns("ISC").DefaultCellStyle.Format = "##,##0.000"
                        dgvDetalle.Columns("ISCPOR").Visible = False ' "% I.S.C."
                        dgvDetalle.Columns("ISC").Visible = False ' "I.S.C."
                        dgvDetalle.Columns("PRECIO_CON_IGV").Visible = False ' "I.S.C."
                        dgvDetalle.Columns("CANTIDAD_MAXIMA").Visible = False ' "I.S.C."

                        dgvDetalle.Columns("ITEM").DisplayIndex = 0
                        dgvDetalle.Columns("CODIGO").DisplayIndex = 1
                        dgvDetalle.Columns("DESCRIPCION").DisplayIndex = 2
                        dgvDetalle.Columns("PRESENTACION").DisplayIndex = 3
                        dgvDetalle.Columns("UNIDAD").DisplayIndex = 4
                        dgvDetalle.Columns("CANTIDAD").DisplayIndex = 5
                        dgvDetalle.Columns("CANTIDAD_FRACCION").DisplayIndex = 6
                        dgvDetalle.Columns("PRECIO_IGV").DisplayIndex = 7
                        dgvDetalle.Columns("PRECIO_IGV_FRACCION").DisplayIndex = 8
                        dgvDetalle.Columns("TOTAL").DisplayIndex = 9
                        dgvDetalle.Columns("LOTE").DisplayIndex = 10
                        dgvDetalle.Columns("SEL").DisplayIndex = 11
                        dgvDetalle.Columns("SALDO").DisplayIndex = 12
                        dgvDetalle.Columns("CANTIDAD_HABILITADO").DisplayIndex = 13
                        dgvDetalle.Columns("CANTIDAD_FACTURADO").DisplayIndex = 14

                        dgvDetalle.Columns("ITEM").Width = 25
                        dgvDetalle.Columns("CODIGO").Width = 100
                        dgvDetalle.Columns("DESCRIPCION").Width = 350
                        dgvDetalle.Columns("PRESENTACION").Width = 100
                        dgvDetalle.Columns("UNIDAD").Width = 45
                        dgvDetalle.Columns("LOTE").Width = 100
                        dgvDetalle.Columns("CANTIDAD").Width = 60
                        dgvDetalle.Columns("SALDO").Width = 60
                        dgvDetalle.Columns("CANTIDAD_HABILITADO").Width = 60
                        dgvDetalle.Columns("CANTIDAD_FACTURADO").Width = 60
                        dgvDetalle.Columns("CANTIDAD_FRACCION").Width = 60
                        dgvDetalle.Columns("PRECIO_IGV").Width = 60
                        dgvDetalle.Columns("PRECIO_IGV_FRACCION").Width = 60
                        dgvDetalle.Columns("TOTAL").Width = 60

                        dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("CANTIDAD_HABILITADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("CANTIDAD_FACTURADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("PREC_UNITARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("PREC_UNITARIO_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("VALOR_VENTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("VALOR_VENTA_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("ISCPOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetalle.Columns("ISC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                        dgvDetalle.AutoResizeColumns()
                        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        chkSinIGV.Checked = Not Precio_Con_Sin_IGV()
                        Calcular_Totales()

                    Else
                        MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                        ''CALCULANDO TOTALES GENERALES

                    End If
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Numeracion_OP() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL_op = New LibManufactura.ClsTransacciones.ORDER_PRODUCTION
            CORRELATIVOBL_op.Get_NumeroCorrelativoOrdenProduccion(dtp_fecha_op.Value.Month, dtp_fecha_op.Value.Year)
            If String.IsNullOrEmpty(CORRELATIVOBL_op.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                Correlativo = String.Format("{0:000}", CInt(CORRELATIVOBL_op.NumeroCorrelativo + 1))
            End If
            Correlativo = Correlativo & "." & String.Format("{0:00}", dtp_fecha_op.Value.Month) & "." & Strings.Right(dtp_fecha_op.Value.Year, 2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub btn_habilitar_facturacion_Click(sender As Object, e As EventArgs) Handles btn_habilitar_facturacion.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Dim Estado As Boolean = False
        For Each row As DataRow In dtdetalleArticuloPrincipal.Select("Sel=true")
            Estado = True
            Exit For
        Next
        If ESTADO = False Then
            MsgBox("No selecciono ningun item.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        For Each row As DataRow In dtdetalleArticuloPrincipal.Select("Sel=true")
            If row("SALDO") > row("CANTIDAD_MAXIMA") Then
                MsgBox("La cantidad habilitada en el item " & row("ITEM") & " supera el saldo. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        Next

        Try
            clsPedidoBl = New ClsOperaciones.ORDERS
            PedidoCabENT = New ClsEntidades.ORDER
            ListaDetalles = New List(Of ClsEntidades.ORDER_LINE)

            Dim STRPedido As String = String.Empty
            STRPedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value

            If MessageBox.Show("¿Desea habilitar para facturación el pedido N° " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                
                For Each row As DataRow In dtdetalleArticuloPrincipal.Select("Sel=true")
                    PedidoDetENT = New ClsEntidades.ORDER_LINE
                    With PedidoDetENT
                        .ID = STRPedido
                        .ITEM = row("ITEM")
                        .CANTIDAD_HABILITADO = row("SALDO")
                    End With
                    ListaDetalles.Add(PedidoDetENT)

                Next

                If clsPedidoBl.GuardarPedido_Habilitar_Facturacion(ListaDetalles) Then
                    MsgBox("Pedido habilitado para facturación Correctamente" & vbCrLf & "N° Pedido " & STRPedido, MsgBoxStyle.Information)
                    DocumentosFactura()
                    btnCancelar_Click(sender, e)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_cliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_cliente.MouseDoubleClick
        Ayuda_Clientes2()
    End Sub

    Private Sub txt_cod_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_cliente.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Clientes2()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_cliente.Text = String.Empty Then
                Ayuda_Clientes2()
            Else
                txtcantidad.Focus()
            End If
        End If
    End Sub
    Private Sub Ayuda_Clientes2(Optional ByVal _CodigoCliente As String = "")
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_ORDER_CLIENTE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_cliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_razon_social.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()

            txtcantidad.Select()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub HabilitarParaFacturarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabilitarParaFacturarToolStripMenuItem.Click
        If dgvDetalle.RowCount() = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim frm As New FrmFacturacionRapida_Despachos_Hab_facturacion
            frm.pedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
            frm.item_pedido = dgvDetalle.CurrentRow.Cells("ITEM").Value
            frm.producto_pedido = dgvDetalle.CurrentRow.Cells("DESCRIPCION").Value
            frm.cantidad_pedido = dgvDetalle.CurrentRow.Cells("CANTIDAD").Value
            Me.Cursor = Cursors.Default
            frm.ShowDialog()
            If frm.flag_hab Then
                clsPedidoBl = New ClsOperaciones.ORDERS
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsPedidoBl.Modo_Edicion_Detalle2(dgvDocumentosFactura.CurrentRow.Cells("Numero").Value)

                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal

                    dgvDetalle.Columns(0).HeaderText = "ITEM"
                    dgvDetalle.Columns(1).HeaderText = "CODIGO"
                    dgvDetalle.Columns(2).HeaderText = "CANTIDAD"
                    dgvDetalle.Columns("SALDO").HeaderText = "SALDO"
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").HeaderText = "CANTIDAD HABILITADO PARA FACTURAR"
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").HeaderText = "CANTIDAD FACTURADO"
                    dgvDetalle.Columns(31).Visible = False ' "CANTIDAD FRAC."
                    dgvDetalle.Columns(3).HeaderText = "UM"
                    dgvDetalle.Columns(4).HeaderText = "DESCRIPCION"
                    dgvDetalle.Columns(30).Visible = False '.HeaderText = "PRESENTACION"
                    dgvDetalle.Columns(5).Visible = False '"LOTE"
                    dgvDetalle.Columns(12).HeaderText = "PRECIO "
                    dgvDetalle.Columns(34).Visible = False ' "PRECIO FRAC."
                    dgvDetalle.Columns(7).Visible = False '.HeaderText = "%.Desc.Articulo"
                    dgvDetalle.Columns(8).Visible = False '.HeaderText = "%.Desc.Articulo.2"
                    dgvDetalle.Columns(15).Visible = False '.HeaderText = "TOTAL"
                    dgvDetalle.Columns(39).HeaderText = "TOTAL"
                    dgvDetalle.Columns(36).Visible = False
                    dgvDetalle.Columns(10).Visible = False '.HeaderText = "Importe.desc"
                    dgvDetalle.Columns(11).Visible = False '.HeaderText = "Importe.desc.2"
                    dgvDetalle.Columns(6).Visible = False
                    dgvDetalle.Columns(32).Visible = False
                    dgvDetalle.Columns(13).Visible = False
                    dgvDetalle.Columns(35).Visible = False
                    dgvDetalle.Columns(14).Visible = False
                    dgvDetalle.Columns(9).Visible = False
                    dgvDetalle.Columns(33).Visible = False
                    dgvDetalle.Columns(16).Visible = False
                    dgvDetalle.Columns(37).Visible = False
                    dgvDetalle.Columns(17).Visible = False
                    dgvDetalle.Columns(38).Visible = False
                    dgvDetalle.Columns(18).Visible = False '.HeaderText = "% I.G.V"
                    dgvDetalle.Columns(19).Visible = False
                    dgvDetalle.Columns(20).Visible = False '.HeaderText = "Peso Neto"
                    dgvDetalle.Columns(21).Visible = False '.HeaderText = "Peso Bruto"
                    dgvDetalle.Columns(22).Visible = False
                    dgvDetalle.Columns(23).Visible = False '.HeaderText = "Observaciones"
                    dgvDetalle.Columns(24).Visible = False '.HeaderText = "Doc. Referencia"
                    dgvDetalle.Columns(25).Visible = False '.HeaderText = "N° Referencia"
                    dgvDetalle.Columns(26).Visible = False '.HeaderText = "Item Referencia"
                    dgvDetalle.Columns(27).Visible = False '.HeaderText = "Item Referencia"

                    dgvDetalle.Columns("ESTADO_OP").HeaderText = "ESTADO O.P."
                    dgvDetalle.Columns("NUMERO_OP").HeaderText = "N° O.P."

                    For i As Integer = 0 To dgvDetalle.Columns.Count - 1
                        dgvDetalle.Columns(i).ReadOnly = True
                    Next

                    'dgvDetalle.Columns("CANTIDAD").ReadOnly = False
                    dgvDetalle.Columns("SALDO").ReadOnly = False
                    dgvDetalle.Columns("SEL").ReadOnly = False

                    dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("SALDO").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("%DESC.ART_1").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("%DESC.ART_2").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("TOTAL").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("IMP_DESC_01").DefaultCellStyle.Format = "##,##0.0000"
                    dgvDetalle.Columns("IMP_DESC_02").DefaultCellStyle.Format = "##,##0.0000"
                    dgvDetalle.Columns("PESO_NETO").DefaultCellStyle.Format = "##,##0.000"
                    dgvDetalle.Columns("PESO_BRUTO").DefaultCellStyle.Format = "##,##0.000"
                    dgvDetalle.Columns("ISCPOR").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("ISC").DefaultCellStyle.Format = "##,##0.000"
                    dgvDetalle.Columns("ISCPOR").Visible = False ' "% I.S.C."
                    dgvDetalle.Columns("ISC").Visible = False ' "I.S.C."
                    dgvDetalle.Columns("PRECIO_CON_IGV").Visible = False ' "I.S.C."
                    dgvDetalle.Columns("CANTIDAD_MAXIMA").Visible = False ' "I.S.C."

                    dgvDetalle.Columns("ITEM").DisplayIndex = 0
                    dgvDetalle.Columns("CODIGO").DisplayIndex = 1
                    dgvDetalle.Columns("DESCRIPCION").DisplayIndex = 2
                    dgvDetalle.Columns("PRESENTACION").DisplayIndex = 3
                    dgvDetalle.Columns("UNIDAD").DisplayIndex = 4
                    dgvDetalle.Columns("CANTIDAD").DisplayIndex = 5
                    dgvDetalle.Columns("CANTIDAD_FRACCION").DisplayIndex = 6
                    dgvDetalle.Columns("PRECIO_IGV").DisplayIndex = 7
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").DisplayIndex = 8
                    dgvDetalle.Columns("TOTAL").DisplayIndex = 9
                    dgvDetalle.Columns("LOTE").DisplayIndex = 10
                    dgvDetalle.Columns("SEL").DisplayIndex = 11
                    dgvDetalle.Columns("SALDO").DisplayIndex = 12
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").DisplayIndex = 13
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").DisplayIndex = 14

                    dgvDetalle.Columns("ITEM").Width = 25
                    dgvDetalle.Columns("CODIGO").Width = 100
                    dgvDetalle.Columns("DESCRIPCION").Width = 350
                    dgvDetalle.Columns("PRESENTACION").Width = 100
                    dgvDetalle.Columns("UNIDAD").Width = 45
                    dgvDetalle.Columns("LOTE").Width = 100
                    dgvDetalle.Columns("CANTIDAD").Width = 60
                    dgvDetalle.Columns("SALDO").Width = 60
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").Width = 60
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").Width = 60
                    dgvDetalle.Columns("CANTIDAD_FRACCION").Width = 60
                    dgvDetalle.Columns("PRECIO_IGV").Width = 60
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").Width = 60
                    dgvDetalle.Columns("TOTAL").Width = 60

                    dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("CANTIDAD_HABILITADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("CANTIDAD_FACTURADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("PREC_UNITARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("PREC_UNITARIO_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("VALOR_VENTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("VALOR_VENTA_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("ISCPOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns("ISC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    dgvDetalle.AutoResizeColumns()
                    dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    chkSinIGV.Checked = Not Precio_Con_Sin_IGV()
                    Calcular_Totales()

                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_destinatario_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_destinatario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtComentarios.Focus()
        End If
    End Sub

    Private Sub btn_programar_despacho_Click(sender As Object, e As EventArgs) Handles btn_programar_despacho.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If dgvDocumentosFactura.RowCount() = 0 Then Exit Sub
            If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
            Modo_consultar = False
            Modo_programar = True
            Modo_editar = False
            Ref_DOCUMENT_ID = ""
            Ref_DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
            Ref_NUMBER_SERIE = String.Empty
            Ref_NUMBER_DOCUMENT = String.Empty
            'If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Me.Cursor = Cursors.WaitCursor : Exit Sub
            'Mostrando resultados
            Ayuda_TipoDocPuntoVenta()
            MostrarModoConsultar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)

            pnlPrincipal.Visible = False
            'GbdetalleDocumento.Visible = True
            Call Botonera_Estado_Cambiar(True)

            Dim Status_order As String = ""
            Status_order = dgvDocumentosFactura.CurrentRow.Cells("Situacion").Value

            If Status_order = "ANULADO" Then
                btnGrabar.Enabled = False
                btn_habilitar_facturacion.Enabled = False
            Else
                Status_order = dgvDocumentosFactura.CurrentRow.Cells("Estado.Despacho").Value

                If Status_order = "DESPACHADO" Then
                    btnGrabar.Enabled = False
                    btn_habilitar_facturacion.Enabled = False
                Else
                    btnGrabar.Enabled = True
                    btn_habilitar_facturacion.Enabled = True
                End If
            End If
            btnGrabar.Text = "Programar Despacho"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txt_cod_trans_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_trans.MouseDoubleClick
        Call Ayuda_Transportista()
    End Sub

    Private Sub txt_cod_trans_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_trans.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Transportista()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_trans.Text = "" Then
                Ayuda_Transportista()
            Else
                txt_direccion_entrega.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Transportista()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CARRIER_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Transportista"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_trans.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_trans.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Dim Estado As Boolean = False
        For Each row As DataRow In dtdetalleArticuloPrincipal.Select("Sel=true")
            Estado = True
            Exit For
        Next
        If Estado = False Then
            MsgBox("No selecciono ningun item.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        For Each row As DataRow In dtdetalleArticuloPrincipal.Select("Sel=true")
            If row("SALDO") > row("CANTIDAD_MAXIMA") Then
                MsgBox("La cantidad habilitada en el item " & row("ITEM") & " supera el saldo. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        Next

        Try
            clsPedidoBl = New ClsOperaciones.ORDERS
            PedidoCabENT = New ClsEntidades.ORDER
            ListaDetalles = New List(Of ClsEntidades.ORDER_LINE)

            Dim STRPedido As String = String.Empty
            STRPedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value

            If MessageBox.Show("¿Desea programar el despacho para el pedido N° " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                With PedidoCabENT
                    .ID = STRPedido
                    .ORDER_DATE = dtp_fecha_programacion.Value.ToShortDateString
                    .CUSTOMER_ADDR_DLV = txt_direccion_entrega.Text
                    .NUMBER_REF = txt_factura.Text
                    .NUMBER_GUIA = txt_guia_programacion.Text
                    .TRAMA_ID = txt_cod_trans.Text
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                End With

                For Each row As DataRow In dtdetalleArticuloPrincipal.Select("Sel=true")
                    PedidoDetENT = New ClsEntidades.ORDER_LINE
                    With PedidoDetENT
                        .ID = STRPedido
                        .ITEM = row("ITEM")
                        .PART_ID = row("CODIGO")
                        .PART_DESCRIPTION = row("DESCRIPCION")
                        .UNIT = row("UNIDAD")
                        .CANTIDAD_HABILITADO = row("SALDO")
                    End With
                    ListaDetalles.Add(PedidoDetENT)
                Next

                If clsPedidoBl.GuardarPedido_Programar_Despacho(PedidoCabENT, ListaDetalles) Then
                    MsgBox("Pedido programado para despacho Correctamente" & vbCrLf & "N° Pedido " & STRPedido, MsgBoxStyle.Information)
                    DocumentosFactura()
                    Button4_Click(sender, e)
                    btnCancelar_Click(sender, e)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtp_fecha_programacion_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_programacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_trans.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ToolStrip1.Enabled = True
        pnl_programar_despacho.Visible = False
    End Sub

    Private Sub txt_direccion_entrega_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_direccion_entrega.MouseDoubleClick
        Call Ayuda_Dir_Entrega_Cliente(txtCodCliente.Text.Trim)
    End Sub

    Private Sub txt_direccion_entrega_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_direccion_entrega.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call Ayuda_Dir_Entrega_Cliente(txtCodCliente.Text.Trim)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_direccion_entrega.Text = "" Then
                Call Ayuda_Dir_Entrega_Cliente(txtCodCliente.Text.Trim)
            Else
                txt_factura.Focus()
            End If
        End If
    End Sub
    Private Sub Ayuda_Dir_Entrega_Cliente(ByVal _cod_cliente As String)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SP_S_DIRECCION_ENTREGA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = _cod_cliente
            frm.Titulo = "Dir. Entrega Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_direccion_entrega.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_factura_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_factura.MouseDoubleClick
        Call Ayuda_Factura()
    End Sub

    Private Sub txt_factura_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_factura.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Factura()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_factura.Text = "" Then
                Ayuda_Factura()
            Else
                txt_guia_programacion.Focus()
            End If
        End If
    End Sub
    Private Sub Ayuda_Factura()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_RECEIVABLE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Comprobantes de Venta"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_factura.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_guia_programacion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_guia_programacion.MouseDoubleClick
        Call Ayuda_Guia()
    End Sub

    Private Sub txt_guia_programacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_guia_programacion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Guia()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_guia_programacion.Text = "" Then
                Ayuda_Guia()
            Else
                Button7.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Guia()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_WAREHOUSE_TRANS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Guias de Remisión"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_guia_programacion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnPicking_Click(sender As Object, e As EventArgs) Handles btnPicking.Click
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim STRFechaPicking As String = String.Empty
            Dim STRPedido As String = String.Empty



            STRFechaPicking = dgvDocumentosFactura.CurrentRow.Cells("FECHA_INICIO_PICKING").Value.ToString
            STRPedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value

            If STRFechaPicking = String.Empty Then
                MessageBox.Show("El pedido ya fue iniciado el proceso de Picking.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim frmPickingAceptar As New frmPickingAceptar
            With frmPickingAceptar
                If .ShowDialog = DialogResult.OK Then
                    clsPedidoBl = New ClsOperaciones.ORDERS
                    If clsPedidoBl.iniciar_Picking(STRPedido, LibComunVar.ClsVarComun.USUARIO, 0, .txtVendedor.Text, .dtpFechaRecepcion.Value.ToString("dd/MM/yyyy"), .dtpHoraRecepcion.Value.ToString("HH:mm:ss"), 0) = True Then
                        MsgBox("Proceso de picking iniciado", MsgBoxStyle.Information)
                        DocumentosFactura()

                    End If
                End If

            End With


            btnCancelar_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDocumentosFactura_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDocumentosFactura.SelectionChanged
        With dgvDocumentosFactura
            If .Rows.Count > 0 Then
                If .Item("Estado.Despacho", .CurrentCell.RowIndex).Value.ToString.Trim = "DESPACHADO" Then
                    btnPicking.Visible = False
                    btndeshacerPicking.Visible = False
                ElseIf .Item("FECHA_INICIO_PICKING", .CurrentCell.RowIndex).Value.ToString.Trim = String.Empty Then
                    btnPicking.Visible = True
                    btndeshacerPicking.Visible = False
                    btn_programar_despacho.Visible = False
                Else
                    btnPicking.Visible = False
                    btndeshacerPicking.Visible = True
                    btn_programar_despacho.Visible = True
                End If
            End If
        End With
    End Sub

    Private Sub btndeshacerPicking_Click(sender As Object, e As EventArgs) Handles btndeshacerPicking.Click
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim STRFechaPicking As String = String.Empty
            Dim STRPedido As String = String.Empty
            Dim strId_cab As Integer = 0


            STRFechaPicking = dgvDocumentosFactura.CurrentRow.Cells("FECHA_INICIO_PICKING").Value.ToString.Trim
            STRPedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
            strId_cab = dgvDocumentosFactura.CurrentRow.Cells("id_cab").Value

            If STRFechaPicking = String.Empty Then
                MessageBox.Show("El pedido ya fue iniciado el proceso de Picking.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            reporteBL = New ClsBuscar
            Dim dt = New DataTable("CONSULTA")
            Dim SQL As String = String.Empty
            SQL = "select 1 from ORDERS where STATUS_DESPACHO=" & "'P'" & "AND ID_CAB =" & strId_cab
            dt = reporteBL.EjecutarConsulta(SQL)
            If dt.Rows.Count() <> 0 Then
                MessageBox.Show("El pedido no pude revertir por que ya esta en proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            Dim frmPickingAceptar As New frmPickingRevertir
            With frmPickingAceptar
                If .ShowDialog = DialogResult.OK Then
                    clsPedidoBl = New ClsOperaciones.ORDERS
                    If clsPedidoBl.iniciar_Picking(STRPedido, LibComunVar.ClsVarComun.USUARIO, 1, "", Now.ToShortDateString, Now.ToString("HH:mm:ss"), .txtVendedor.Text) = True Then
                        MsgBox("Proceso de picking revertido", MsgBoxStyle.Information)
                        DocumentosFactura()
                    End If
                End If

            End With


            btnCancelar_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDocumentosFactura_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvDocumentosFactura.RowPostPaint
        If e.RowIndex < dgvDocumentosFactura.RowCount Then
            Dim dgvRow As DataGridViewRow = dgvDocumentosFactura.Rows(e.RowIndex)
            If dgvRow.Cells("FECHA_INICIO_PICKING").Value.ToString.Trim = String.Empty Then
                dgvRow.DefaultCellStyle.BackColor = Color.White
            Else
                dgvRow.DefaultCellStyle.BackColor = Color.LightYellow
            End If
        End If
    End Sub
End Class