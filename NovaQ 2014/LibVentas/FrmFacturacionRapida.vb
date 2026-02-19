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
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class FrmFacturacionRapida
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
    Dim CORRELATIVOBL As ClsTransacciones.ORDERS

    Private dtDocumentoFactura As DataTable
    Private dt_lista_productos As DataTable
    Dim _filtra As Boolean
    Public CodigoVendedor As String = String.Empty
    Public DescripcionVendedor As String = String.Empty
    Public tipo_Vendedor As String = String.Empty

    Dim Flag_Ref As Boolean = False

    Dim Flag_Verificar As Boolean = False
    Dim Modo_consultar As Boolean = False
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
    Dim dtTipoPedido As DataTable
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
    Dim _numero_cotizacion As String

    Dim pdfBytes As Byte()
    Dim NumeroOC As String
    Dim RutaOC As String

    Dim ARCHIVO As Byte()
    Dim _FLAG_PICKING As Boolean


    Private Sub FrmFacturacionRapida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        clsVendedorBl = New ClsTransacciones.clsVendedores
        dtAccesoVendedor = New DataTable
        dtAccesoVendedor = clsVendedorBl.Get_Datos_Vendor_Pedido(LibComunVar.ClsVarComun.USUARIO, "")
        If dtAccesoVendedor.Rows.Count() = 0 Then
            MsgBox("El usuario loggeado no pertenece a un vendedor. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            CodigoVendedor = clsVendedorBl.ID
            tipo_Vendedor = clsVendedorBl.NIVEL
        End If

        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        dtpfechafinal.Value = ClsVarComun.FechaSistema
        dtpfechaInicial.Value = ClsVarComun.FechaSistema
        Call Cargar_Moneda()
        Call Cargar_TipoPedido()

        'If LibComunVar.ClsVarComun.DESHACER_PEDIDO = "SI" Then
        '    btn_deshacer_aprobar.Visible = True
        'Else
        '    btn_deshacer_aprobar.Visible = False
        'End If

        txtFiltro.Select()
    End Sub

    Private Sub Cargar_TipoPedido()
        cVenta = New ClsAyudas
        dtTipoPedido = New DataTable
        dtTipoPedido = cVenta.get_Tipo_Pedido()
        cboTipoPedido.ValueMember = "ID"
        cboTipoPedido.DisplayMember = "DESCRIPTION"
        cboTipoPedido.DataSource = dtTipoPedido
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
            STRorden = ""

            If LibComunVar.ClsVarComun.AcesoVendedores = "" Then Me.Cursor = Cursors.Default : dgvDocumentosFactura.DataSource = Nothing : Exit Sub

            clsPedidoBl = New ClsOperaciones.ORDERS
            dtv = New DataView

            Dim dtdocumentoPrin As DataTable
            dtdocumentoPrin = New DataTable
            dtdocumentoPrin = clsPedidoBl.get_DatosGeneralesPedido(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                   cboopcionesBusqueda.SelectedIndex, CodigoVendedor, tipo_Vendedor, LibComunVar.ClsVarComun.AcesoVendedores)
            dgvDocumentosFactura.DataSource = Nothing

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
                dgvDocumentosFactura.Columns("Vendedor").Width = 250

                dgvDocumentosFactura.Columns("Numero").HeaderText = "N° Pedido"
                dgvDocumentosFactura.Columns("Emision").HeaderText = "Fecha"
                dgvDocumentosFactura.Columns("Punto.Venta").Visible = False
                dgvDocumentosFactura.Columns("Monto").DefaultCellStyle.Format = "N2"
                dgvDocumentosFactura.Columns("Monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvDocumentosFactura.Columns("Tipo.Cambio").Visible = False
                dgvDocumentosFactura.Columns("Situacion").HeaderText = "Estado Pedido"
                dgvDocumentosFactura.Columns("Estado.Facturacion").HeaderText = "Estado Facturación"
                dgvDocumentosFactura.Columns("Tipo.Ref").HeaderText = "Tipo Ref."
                dgvDocumentosFactura.Columns("Serie.Ref").HeaderText = "Serie Ref."
                dgvDocumentosFactura.Columns("Numero.Ref").HeaderText = "N° Doc. Ref."



                STRorden = dgvDocumentosFactura.Columns("Numero").Name & "+" & dgvDocumentosFactura.Columns("Codigo").Name & "+" & dgvDocumentosFactura.Columns("Cliente").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False

            btnImprimir.Enabled = False
            btn_imprimir_fc.Enabled = False
            btn_imprimir_tk.Enabled = False
            If Modo_consultar = True Then
                btnGrabar.Enabled = False
                btn_cotizacion.Visible = False
                'btnImprimir.Enabled = True
            Else
                'btnImprimir.Enabled = False
                btnGrabar.Enabled = True
                btn_cotizacion.Visible = True
            End If
            If Modo_editar = True Then btnGrabar.Enabled = True : btn_cotizacion.Visible = False
            btnEliminar.Enabled = False
            btnAnular.Enabled = False
            btnConsultar.Enabled = False
            'btn_modificar.Enabled = False
            btnCancelar.Enabled = True
            'btnImprimir.Enabled = False
            lblCantidad.Visible = False
            btn_aprobar.Visible = False
            btn_deshacer_aprobar.Visible = False
        Else
            btnNuevo.Enabled = True
            btn_cotizacion.Visible = False
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnAnular.Enabled = True
            btnConsultar.Enabled = True
            'btn_modificar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            btn_imprimir_fc.Enabled = True
            btn_imprimir_tk.Enabled = True
            lblCantidad.Visible = True
            btn_aprobar.Visible = False
            btn_deshacer_aprobar.Visible = False
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



            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            'dgvDetalle.AutoResizeColumns()
            'dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvDetalle.Columns(0).HeaderText = "ITEM"
            dgvDetalle.Columns(1).HeaderText = "CODIGO"
            dgvDetalle.Columns(2).HeaderText = "CANTIDAD"
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
            dgvDetalle.Columns(40).Visible = False
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

            For i As Integer = 0 To dgvDetalle.Columns.Count - 1
                dgvDetalle.Columns(i).ReadOnly = True
            Next

            dgvDetalle.Columns("CANTIDAD").ReadOnly = False
            dgvDetalle.Columns("CANTIDAD_FRACCION").ReadOnly = False

            dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Format = "##,##0.000000"
            dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Format = "##,##0.000000"
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

            dgvDetalle.Columns("ITEM").Width = 25
            dgvDetalle.Columns("CODIGO").Width = 100
            dgvDetalle.Columns("DESCRIPCION").Width = 350
            dgvDetalle.Columns("PRESENTACION").Width = 100
            dgvDetalle.Columns("UNIDAD").Width = 45
            dgvDetalle.Columns("LOTE").Width = 100
            dgvDetalle.Columns("CANTIDAD").Width = 60
            dgvDetalle.Columns("CANTIDAD_FRACCION").Width = 60
            dgvDetalle.Columns("PRECIO_IGV").Width = 60
            dgvDetalle.Columns("PRECIO_IGV_FRACCION").Width = 60
            dgvDetalle.Columns("TOTAL").Width = 60

            dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
            gbTipoFacturacion.Enabled = True
            rbFacturaDirecta.Checked = True
            rbDocRef_uno.Checked = True
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
            GbdetalleDocumento.Visible = False
            _FLAG_PICKING = False
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
                If LibComunVar.ClsVarComun.PUNTO_VENTA_ASIGNADO = "" Then
                    txtPtoVenta.Text = dtCabeceraFact.Rows(0).Item("SALES_PLACE_ID").ToString
                Else
                    txtPtoVenta.Text = LibComunVar.ClsVarComun.PUNTO_VENTA_ASIGNADO
                End If

                If txtPtoVenta.Text = String.Empty Then
                    Ayuda_PuntoVenta()
                Else
                    Ayuda_PuntoVenta(txtPtoVenta.Text)
                End If
                dtCabeceraFact.Clear()
                dtCabeceraFact = Nothing
                dtCabeceraFact = clsFacturaCabBl.get_Cliente_Default()
                If dtCabeceraFact.Rows.Count > 0 Then
                    txtCod_Cliente.Text = Trim(dtCabeceraFact.Rows(0).Item("ID").ToString)
                    If txtCod_Cliente.Text = String.Empty Then
                        Ayuda_Clientes()
                    Else
                        Ayuda_Clientes(txtCod_Cliente.Text)
                    End If
                End If
                cboTipoDoc.Text = "PF"
                rdb_f_ticket.Checked = True
                chk_facturar_obsequio.Checked = False
                dgv_lista_productos.DataSource = Nothing
                chkigv.Checked = True
                txtdescripcionArticulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Botonera_Estado_Cambiar(True)
            Flag_Verificar = True
            Nuevo()
            Flag_Verificar = False
            NuevaVenta()
            txtdescripcionArticulo.Focus()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
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
                    cboTipoPedido.SelectedValue = dtCabeceraFact.Rows(i).Item("TIPO_PEDIDO").ToString
                    txtCod_Cliente.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRucDni.Text = dtCabeceraFact.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtRazonSocial.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtDireccion.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ADDR").ToString
                    txtDireccionEntregaCliente.Text = dtCabeceraFact.Rows(i).Item("DIRECCION_ENTREGA").ToString
                    txtVendedor.Text = dtCabeceraFact.Rows(i).Item("SALES_ID").ToString
                    lblVendedor.Text = dtCabeceraFact.Rows(i).Item("VENDEDOR").ToString
                    txtFormaPago.Text = dtCabeceraFact.Rows(i).Item("TERMS").ToString
                    lblFormaPago.Text = dtCabeceraFact.Rows(i).Item("FPAGO").ToString
                    txtcotizacion.Text = ""
                    txtordenCompra.Text = dtCabeceraFact.Rows(i).Item("ORDER_PURCHASE").ToString
                    chkSinOC.Checked = dtCabeceraFact.Rows(i).Item("IS_SIN_OC")

                    If dtCabeceraFact.Rows(0)("ARCHIVO") IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(dtCabeceraFact.Rows(0)("Archivo").ToString()) Then
                        ARCHIVO = CType(dtCabeceraFact.Rows(0)("ARCHIVO"), Byte())
                        pdfBytes = ARCHIVO
                    End If
                    txtDireccionTransportista.Text = dtCabeceraFact.Rows(i).Item("IDAGENCIA").ToString
                    txtDireccionTransportistaDescripcion.Text = dtCabeceraFact.Rows(i).Item("DIRECCIONAGENCIA").ToString

                    If dtCabeceraFact.Rows(i).Item("STATUS_PICKING") = 1 Then
                        _FLAG_PICKING = True
                        gb_picking.Visible = True
                        lbl_texto_picking.Text = "Picking iniciado: " & dtCabeceraFact.Rows(i).Item("FECHA_INICIO_PICKING").ToString
                    Else
                        _FLAG_PICKING = False
                        gb_picking.Visible = False
                    End If

                    txtpedido.Text = ""
                    txtcodigo.Text = dtCabeceraFact.Rows(i).Item("ID").ToString
                    txt_validez_oferta.Text = dtCabeceraFact.Rows(i).Item("VALIDEZ_OFERTA").ToString

                    txtModoPago.Text = dtCabeceraFact.Rows(i).Item("MODO_PAGO").ToString
                    lblModoPago.Text = dtCabeceraFact.Rows(i).Item("MODO_PAGO_DESC").ToString

                    txt_provincia.Text = dtCabeceraFact.Rows(i).Item("PROVINCIA").ToString
                    txt_cod_agencia_trans.Text = dtCabeceraFact.Rows(i).Item("AGENCIA_TRANSPORTE").ToString
                    txt_des_agencia_trans.Text = dtCabeceraFact.Rows(i).Item("AGENCIA_TRANSPORTE_DES").ToString

                    If dtCabeceraFact.Rows(i).Item("AGE_DOMI").ToString = "AGENCIA" Then
                        rdb_agencia.Checked = True
                        rdb_domicilio.Checked = False
                        'rdb_local.Checked = False
                        txtDireccionTransportistaDescripcion.Text = dtCabeceraFact.Rows(i).Item("GUIA").ToString
                        txtDireccionEntregaCliente.Text = txtDireccionCliente.Text
                    ElseIf dtCabeceraFact.Rows(i).Item("AGE_DOMI").ToString = "DOMICILIO" Then
                        rdb_agencia.Checked = False
                        rdb_domicilio.Checked = True
                        'rdb_local.Checked = False
                        txtDireccionEntregaCliente.Text = dtCabeceraFact.Rows(i).Item("GUIA").ToString
                    ElseIf dtCabeceraFact.Rows(i).Item("AGE_DOMI").ToString = "LOCAL" Then
                        rdb_agencia.Checked = False
                        rdb_domicilio.Checked = False
                        'rdb_local.Checked = True
                        txtLocalDescripcion.Text = dtCabeceraFact.Rows(i).Item("GUIA").ToString
                        txtDireccionEntregaCliente.Text = txtDireccionCliente.Text
                    Else
                        rdb_agencia.Checked = False
                        rdb_domicilio.Checked = False
                        'rdb_local.Checked = False
                    End If

                    If dtCabeceraFact.Rows(i).Item("OPT_A_D").ToString = "Agencia" Then
                        rdb_opt_agencia.Checked = True
                        rdb_opt_domicilio.Checked = False
                        rdb_opt_local.Checked = False
                        txtDireccionTransportistaDescripcion.Text = dtCabeceraFact.Rows(i).Item("GUIA").ToString
                        'txtDireccionEntregaCliente.Text = txtDireccionCliente.Text
                    ElseIf dtCabeceraFact.Rows(i).Item("OPT_A_D").ToString = "Domicilio" Then
                        rdb_opt_agencia.Checked = False
                        rdb_opt_domicilio.Checked = True
                        rdb_opt_local.Checked = False
                        'txtDireccionEntregaCliente.Text = dtCabeceraFact.Rows(i).Item("GUIA").ToString
                    ElseIf dtCabeceraFact.Rows(i).Item("OPT_A_D").ToString = "Local" Then
                        rdb_opt_agencia.Checked = False
                        rdb_opt_domicilio.Checked = False
                        rdb_opt_local.Checked = True
                        txtLocalDescripcion.Text = dtCabeceraFact.Rows(i).Item("GUIA").ToString
                        'txtDireccionEntregaCliente.Text = txtDireccionCliente.Text
                    Else
                        rdb_opt_agencia.Checked = False
                        rdb_opt_domicilio.Checked = False
                        rdb_opt_local.Checked = False

                    End If

                    txt_lt_ft.Text = dtCabeceraFact.Rows(i).Item("LT_FT").ToString
                    If dtCabeceraFact.Rows(i).Item("CHEQUE").ToString = "SI" Then
                        chk_cheque.Checked = True
                    Else
                        chk_cheque.Checked = False
                    End If

                    If dtCabeceraFact.Rows(i).Item("GUIA_2").ToString = "" Then
                        chk_guia_2.Checked = False
                    Else
                        chk_guia_2.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("FACTURA_2").ToString = "" Then
                        chk_factura_2.Checked = False
                    Else
                        chk_factura_2.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("LETRA_2").ToString = "" Then
                        chk_letra_2.Checked = False
                    Else
                        chk_letra_2.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("TRANSFERENCIA_2").ToString = "" Then
                        chk_transferencia.Checked = False
                    Else
                        chk_transferencia.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("EFECTIVO_2").ToString = "" Then
                        chk_efectivo.Checked = False
                    Else
                        chk_efectivo.Checked = True
                    End If

                    txtNumeroOrdenCompra.Text = dtCabeceraFact.Rows(i).Item("ORDER_PURCHASE").ToString
                    txt_cod_transferencia.Text = dtCabeceraFact.Rows(i).Item("TRANSFERENCIA").ToString
                    txt_des_transferencia.Text = dtCabeceraFact.Rows(i).Item("TRANSFERENCIA_DES").ToString
                    txt_n_operacion.Text = dtCabeceraFact.Rows(i).Item("N_OPERACION").ToString
                    txt_obs_general.Text = dtCabeceraFact.Rows(i).Item("OBS_GENERAL").ToString
                    txt_recepcion_tercero.Text = dtCabeceraFact.Rows(i).Item("RECEPCION_TERCERO").ToString

                    txtContactoNombres.Text = dtCabeceraFact.Rows(i).Item("CONTACTO_NOMBRES").ToString
                    txtContactoDNI.Text = dtCabeceraFact.Rows(i).Item("CONTACTO_DNI").ToString
                    txtContactoCelular.Text = dtCabeceraFact.Rows(i).Item("CONTACTO_CELULAR").ToString

                    If dtCabeceraFact.Rows(i).Item("FECHA_ENTREGA").ToString = String.Empty Then
                        dtpFechaEntrega.Text = dtCabeceraFact.Rows(i).Item("ORDER_DATE").ToString
                        dtpFechaRecepcion.Text = dtCabeceraFact.Rows(i).Item("ORDER_DATE").ToString
                        dtpHoraRecepcion.Text = "00:00:00"
                    Else
                        dtpFechaEntrega.Text = dtCabeceraFact.Rows(i).Item("FECHA_ENTREGA").ToString
                        dtpFechaRecepcion.Text = dtCabeceraFact.Rows(i).Item("FECHA_RECEPCION").ToString
                        dtpHoraRecepcion.Text = dtCabeceraFact.Rows(i).Item("HORA_RECEPCION").ToString
                    End If
                Next

                '---Mostrando datos del Detalle
                clsPedidoBl = New ClsOperaciones.ORDERS
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsPedidoBl.Modo_Edicion_Detalle(DOCUMENT_ID)

                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal

                    dgvDetalle.Columns(0).HeaderText = "ITEM"
                    dgvDetalle.Columns(1).HeaderText = "CODIGO"
                    dgvDetalle.Columns(2).HeaderText = "CANTIDAD"
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

                    For i As Integer = 0 To dgvDetalle.Columns.Count - 1
                        dgvDetalle.Columns(i).ReadOnly = True
                    Next

                    'dgvDetalle.Columns("CANTIDAD").ReadOnly = False
                    'dgvDetalle.Columns("CANTIDAD_FRACCION").ReadOnly = False

                    dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Format = "##,##0.000000"
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Format = "##,##0.000000"
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

                    dgvDetalle.Columns("ITEM").Width = 25
                    dgvDetalle.Columns("CODIGO").Width = 100
                    dgvDetalle.Columns("DESCRIPCION").Width = 350
                    dgvDetalle.Columns("PRESENTACION").Width = 100
                    dgvDetalle.Columns("UNIDAD").Width = 45
                    dgvDetalle.Columns("LOTE").Width = 100
                    dgvDetalle.Columns("CANTIDAD").Width = 60
                    dgvDetalle.Columns("CANTIDAD_FRACCION").Width = 60
                    dgvDetalle.Columns("PRECIO_IGV").Width = 60
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").Width = 60
                    dgvDetalle.Columns("TOTAL").Width = 60

                    dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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

                    chkSinIGV.Checked = Not Precio_Con_Sin_IGV()
                    Calcular_Totales()

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
        Try

            If dgvDocumentosFactura.RowCount() = 0 Then Exit Sub
            If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
            Modo_consultar = True
            Modo_editar = False
            _FLAG_PICKING = False
            Ref_DOCUMENT_ID = String.Empty
            Ref_NUMBER_SERIE = String.Empty
            Ref_NUMBER_DOCUMENT = String.Empty
            'If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
            'Mostrando resultados
            Ayuda_TipoDocPuntoVenta()
            pdfBytes = Nothing
            NumeroOC = dgvDocumentosFactura.CurrentRow.Cells("Orden.Compra").Value
            RutaOC = String.Empty
            MostrarModoConsultar(dgvDocumentosFactura.CurrentRow.Cells("Numero").Value, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
            Me.Cursor = Cursors.WaitCursor
            pnlPrincipal.Visible = False
            'GbdetalleDocumento.Visible = True
            Call Botonera_Estado_Cambiar(True)

            Dim Status_order As String = ""
            Status_order = dgvDocumentosFactura.CurrentRow.Cells("Estado.Facturacion").Value

            If Status_order = "FACTURADO" Or Status_order = "FACTURADO TOTAL" Or Status_order = "FACTURADO PARCIAL" Then
                gbOpciones.Enabled = False
                btnGrabar.Enabled = False
            ElseIf Status_order = "ANULADO" Then
                gbOpciones.Enabled = False
                btnGrabar.Enabled = False
            Else
                gbOpciones.Enabled = True
                btnGrabar.Enabled = True
            End If

            Dim STREstado As String = ""
            STREstado = dgvDocumentosFactura.CurrentRow.Cells("Situacion").Value

            If STREstado = "AUTORIZADO" Or STREstado = "APROBADO" Or STREstado = "FACTURADO" Then
                gbOpciones.Enabled = False
                btnGrabar.Enabled = False
            ElseIf STREstado = "RECHAZADO" Then
                gbOpciones.Enabled = False
                btnGrabar.Enabled = False
            ElseIf STREstado = "ANULADO" Then
                gbOpciones.Enabled = False
                btnGrabar.Enabled = False
            Else
                gbOpciones.Enabled = True
                btnGrabar.Enabled = True
            End If

            If _FLAG_PICKING = True Then
                gbOpciones.Enabled = False
                btnGrabar.Enabled = False
            End If

            txtdescripcionArticulo.Focus()
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
            If rb_facturar_devolucion.Checked Then
                txtNumDocRef.Select()
                txtNumDocRef.ReadOnly = True
            Else
                cboTipoDoc.Select()
                txtNumDocRef.ReadOnly = False
            End If

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
                If rbunalineaDoc.Checked Then
                    .CFDESCPG = 0
                ElseIf rbVariaslineasDoc.Checked Then
                    .CFDESCPG = 1
                End If
                .POINT_ORIG = 0
                .POINT_BOARD = 0
                .POINT_ARRIVAL = 0
                If chk_facturar_obsequio.Checked Then
                    .RECEIVABLE_TYPE = "FO"
                Else
                    .RECEIVABLE_TYPE = cboTipoDoc.Text
                End If
                '.RECEIVABLE_TYPE = cboTipoDoc.Text
                .CUSTOMER_ID = txtCod_Cliente.Text.Trim
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
                    If rbFacturaRepMedico.Checked Then
                        .NUMBER_REF = NumerosDocClientes
                    Else
                        .NUMBER_REF = Strings.Right(Trim(NumeracionGuiaRemision), 7)
                    End If
                Else
                    If rb_facturar_pedido.Checked = True Then
                        .DOCUMENT_REF = "PD"
                        .SERIE_REF = ""
                        .NUMBER_REF = txtpedido.Text
                    Else
                        .DOCUMENT_REF = txttipoDocRef.Text
                        .SERIE_REF = txtSerieDocRef.Text
                        If rbFacturaGuiaVenta.Checked Or rbFacturaRepMedico.Checked Then
                            .NUMBER_REF = "GUIAS"
                        Else
                            .NUMBER_REF = txtNumDocRef.Text
                        End If
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
                If rbFacturaGuiaVenta.Checked Then
                    .LIST_GUIA = txtNumDocRef.Text
                Else
                    .LIST_GUIA = ""
                End If

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
                .ISC = txtIsc.Text

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
                For Each Control As Control In gbTipoFacturacion.Controls
                    If TypeOf Control Is RadioButton Then
                        If CType(Control, RadioButton).Checked = True Then
                            .MOV_OPTION_ID = CType(Control, RadioButton).Text
                            Exit For
                        End If
                    End If
                Next
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
                    If rb_facturar_devolucion.Checked Then
                        .ITEM_INI = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_INI")
                    Else
                        .ITEM_INI = ""
                    End If
                    .OBSERVACIONES = dtdetalleArticuloPrincipal.Rows(i).Item("OBSERVACIONES")
                End With
                ls_det.Add(detalle)
            Next
            If chk_facturar_obsequio.Checked = False Then
                'CLIENTES
                With carteraBE
                    .CUSTOMER_ID = txtCod_Cliente.Text.Trim
                    .DOCUMENT_ID = cboTipoDoc.Text
                    .NUMBER_DOC = NumeracionFacturacion
                    .DOC_DATE = CDate(dtpFechaFactura.Text).ToShortDateString
                    .CADUCATE_DATE = Get_FormaPagoFechaVencimiento()
                    If rb_facturar_pedido.Checked = True Then
                        .DOCUMENT_REF = "PD"
                    Else
                        .DOCUMENT_REF = txttipoDocRef.Text
                    End If
                    If rbFacturaDirecta.Checked = True Then
                        .NUMBER_REF = txtSerieDocRef.Text & txtNumDocRef.Text
                    Else
                        If rb_facturar_pedido.Checked = True Then
                            .NUMBER_REF = txtpedido.Text
                        Else
                            .NUMBER_REF = txtNumDocRef.Text
                        End If

                    End If
                    .SALES_ID = txtVendedor.Text.Trim
                    .AMOUNT = txtPrecioVenta.Text
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
                    .AMOUNT_BALANCE_INI = txtPrecioVenta.Text
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
                        .AMOUNT_DETRAC = CDbl(txtPrecioVenta.Text * PorcentajeDetraccion / 100)
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
                        .ANNEX_ID_AUX = txtCod_Cliente.Text.Trim
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
                        .ANNEX_ID_AUX = txtCod_Cliente.Text.Trim
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
                        .ANNEX_ID_AUX = txtCod_Cliente.Text.Trim
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
                        .ANNEX_ID_AUX = txtCod_Cliente.Text.Trim
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
                        .ANNEX_ID_AUX = txtCod_Cliente.Text.Trim
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
                        .ANNEX_ID_AUX = txtCod_Cliente.Text.Trim
                        .DOCUMET_ID = cboTipoDoc.Text
                        .NUMBER_SERIE = cboSerieDoc.Text
                        .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
                        .MEDIOS_PAGO = 0
                        .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
                    End With
                    ls_detalle.Add(planilladetBE)
                End If
            End If


            If rbFacturaDirecta.Checked = True Or rbFacturaExistencias.Checked = True Then
                'la parte de almacen
                With alm_cabBE
                    .WAREHOUSE_ID = txtAlmacen.Text
                    .DOCUMENT_ID = cboTipoDoc.Text
                    .NUMBER_DOCUMENT = NumeracionFacturacion
                    If cboTipoDoc.Text = "NC" Then
                        .TYPE_TRANS = "I"
                    Else
                        .TYPE_TRANS = "S"
                    End If
                    .TRANS_ID = "FT"
                    .DATE_DOCUMENT = CDate(dtpFechaFactura.Value).ToShortDateString
                    If rb_facturar_pedido.Checked = True Then
                        .DOC_ID_REF = "PD"
                    Else
                        .DOC_ID_REF = txttipoDocRef.Text
                    End If
                    If rbFacturaDirecta.Checked = True Then
                        .NUM_ID_REF = txtSerieDocRef.Text & txtNumDocRef.Text
                    Else
                        If rb_facturar_pedido.Checked = True Then
                            .NUM_ID_REF = txtpedido.Text
                        Else
                            .NUM_ID_REF = txtNumDocRef.Text
                        End If

                    End If
                    .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .CUSTOMER_ID = txtCod_Cliente.Text
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
                    .NUMBER_PURCHASE = txtordenCompra.Text
                    .INTERFACEE = 0
                    .FECHA_TRASLADO = CDate(dtpFechaFactura.Value).ToShortDateString
                End With

                For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                    alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                    With alm_detBE
                        .WAREHOUSE_ID = txtAlmacen.Text
                        .DOCUMENT_ID = cboTipoDoc.Text
                        .NUMBER_DOCUMENT = NumeracionFacturacion
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
                        .TAX_PERCENT = dtdetalleArticuloPrincipal.Rows(i).Item("IGV_POR")
                        .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                        .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                        .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                    End With
                    ls_det_alm.Add(alm_detBE)
                Next
            End If

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
                MontoPercepcion = (txtPrecioVenta.Text * CDbl(PorcentajePercepcion) / 100)
                If cboTipoDoc.Text = "FT" Then
                    If cabeceraBL.GuardarComprobantePercepcion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturacion,
                                                               NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion, PorcentajePercepcion) = False Then
                        MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                        indicadorF = False
                        Exit Try
                    End If
                ElseIf cboTipoDoc.Text = "NC" Then
                    If cabeceraBL.GuardarComprobantePercepcion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturaNotac,
                                                               NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion, PorcentajePercepcion) = False Then
                        MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                        indicadorF = False
                        Exit Try
                    End If
                ElseIf cboTipoDoc.Text = "ND" Then
                    If cabeceraBL.GuardarComprobantePercepcion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturaNotaD,
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
                    .CUSTOMER_ID = txtCod_Cliente.Text
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
                    .NUMBER_PURCHASE = txtordenCompra.Text
                    If rbunalinea.Checked Then
                        .INTERFACEE = 0
                    ElseIf rbVariaslineas.Checked Then
                        .INTERFACEE = 1
                    End If
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
            If rb_facturar_devolucion.Checked = True Then Guardar_Detalle_Doc_Referencias()

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
        txtCod_Cliente.Clear()
        txtRucDni.Clear()
        txtRazonSocial.Clear()
        txtDireccion.Clear()
        txtVendedor.Clear()
        txtFormaPago.Clear()
        txtGlosa.Clear()
        chkSinIGV.Checked = Not Precio_Con_Sin_IGV()
        chkSinIGV.Visible = True
        chkSinIGV.ForeColor = Color.Navy
        txtvalorVenta.Text = "0.00"
        txtIgv.Text = "0.00"
        txtIsc.Text = "0.00"
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
        cboDirEntrega.Items.Clear()
        cboDirEntrega.Text = String.Empty
        txtordenCompra.Text = String.Empty
        chkSinOC.Checked = False
        txtdetalledoc.Text = String.Empty
        txtdetalleserie.Text = String.Empty
        txtdetallenumero.Text = String.Empty
        txtdetalleguiadoc.Text = String.Empty
        txtdetalleguiaserie.Text = String.Empty
        txtdetalleguianumero.Text = String.Empty
        txtSerieCP.Text = String.Empty
        txtNumeroCP.Text = String.Empty
        txtcodigoCP.Text = String.Empty
        rbunalineaDoc.Checked = True
        rbunalinea.Checked = True
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
        txtcodigoArticulo.Text = String.Empty
        txtdescripcionArticulo.Text = String.Empty
        txtcantidad.Text = String.Empty
        txtprecioUnitario.Text = String.Empty
        txtStock.Text = String.Empty
        vuelto = 0
        chk_facturar_obsequio.Checked = False
        txt_buscador_especial.Text = ""
        txt_buscador_especial.Visible = True
        txt_buscador_productos.Text = ""
        txt_numero_lote.Text = ""
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

        txtModoPago.Text = ""
        lblModoPago.Text = ""

        chk_guia_2.Checked = False
        chk_factura_2.Checked = False
        chk_letra_2.Checked = False
        rdb_opt_agencia.Checked = True
        rdb_opt_domicilio.Checked = False
        chk_transferencia.Checked = False
        chk_efectivo.Checked = False

        txtContactoNombres.Text = String.Empty
        txtContactoDNI.Text = String.Empty
        txtContactoCelular.Text = String.Empty
        txtNumeroOrdenCompra.Text = String.Empty
        txtVendedor.Text = String.Empty
        lblVendedor.Text = String.Empty

        'txtDireccion_Cliente.Text = String.Empty
        txtDireccionEntregaCliente.Text = String.Empty

        pdfBytes = Nothing
        NumeroOC = String.Empty
        RutaOC = String.Empty

        dtpFechaEntrega.Value = Date.Now
        dtpFechaRecepcion.Value = Date.Now
        dtpHoraRecepcion.Text = "00:00:00"

        txtDireccionTransportistaDescripcion.Text = ""
        txtDireccionTransportista.Text = ""

        txtLocalDescripcion.Text = ""
        txtLocal.Text = ""
        gb_picking.Visible = False
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


    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click, Button2.Click
        Try
            ''Validaciones Generales
            If dgvDetalle.Rows.Count() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            If ValidacionesGenerales() = False Then Exit Sub
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                    If dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD") = 0 Then
                        MessageBox.Show("Falta ingresar la cantidad a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    ElseIf dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO_INICIAL") = 0 Then
                        MessageBox.Show("Falta ingresar el Precio a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Next
            End If

            If MessageBox.Show("Se va a proceder a la creacion de un Pedido", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                If Guardar_Pedido() = True Then
                    If Modo_consultar = True Then
                        Me.Cursor = Cursors.WaitCursor
                        DocumentosFactura()
                        btnCancelar_Click(sender, e)
                        MsgBox("Transaccion realizada Exitosamente.!", MsgBoxStyle.Information)
                        Me.Cursor = Cursors.Default
                    Else
                        Me.Cursor = Cursors.WaitCursor
                        DocumentosFactura()
                        Flag_Verificar = True
                        Nuevo()
                        Flag_Verificar = False
                        NuevaVenta()
                        txt_buscador_productos.Focus()
                        MsgBox("Transaccion no realizada Exitosamente.!", MsgBoxStyle.Information)
                        Me.Cursor = Cursors.Default
                    End If
                End If
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
                .CUSTOMER_ID = txtCod_Cliente.Text
                .CUSTOMER_NAME = txtRazonSocial.Text
                .CUSTOMER_ADDR = txtDireccion.Text
                .CUSTOMER_ADDR_DLV = txtDireccion.Text
                .DIRECCION_ENTREGA = txtDireccionEntregaCliente.Text
                .ITEM_TRANSPORTE = txtDireccionTransportista.Text

                .PLACE_DELIVERY = txtLocal.Text

                .VAT_REGISTRATION = txtRucDni.Text
                .AMOUNT = txtPrecioVenta.Text
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
                .COMMENT = txtGlosa.Text
                .NUMBER_GUIA = ""
                .NUMBER_REC = ""
                .IS_SIN_OC = chkSinOC.Checked

                If pdfBytes Is Nothing Then
                    .ARCHIVO = Nothing
                    .ORDER_PURCHASE = String.Empty
                Else
                    .ARCHIVO = pdfBytes
                    .ORDER_PURCHASE = NumeroOC
                End If
                '.ORDER_PURCHASE = txtordenCompra.Text
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
                .NUM_COTIZACION = txtcotizacion.Text

                .PROVINCIA = txt_provincia.Text
                .AGENCIA_TRANSPORTE = txt_cod_agencia_trans.Text
                '.GUIA = txt_guia.Text
                If rdb_agencia.Checked Then
                    .AGE_DOMI = "AGENCIA"
                ElseIf rdb_domicilio.Checked Then
                    .AGE_DOMI = "DOMICILIO"
                End If

                If rdb_opt_agencia.Checked Then
                    .OPT_A_D = rdb_opt_agencia.Text
                    .GUIA = txtDireccionTransportistaDescripcion.Text
                ElseIf rdb_opt_domicilio.Checked Then
                    .OPT_A_D = rdb_opt_domicilio.Text
                    .GUIA = txtDireccionEntregaCliente.Text
                ElseIf rdb_opt_local.Checked Then
                    .GUIA = txtLocalDescripcion.Text
                    .OPT_A_D = rdb_opt_local.Text
                End If

                .LT_FT = txt_lt_ft.Text
                If chk_cheque.Checked Then
                    .CHEQUE = "SI"
                Else
                    .CHEQUE = "NO"
                End If

                If chk_guia_2.Checked Then
                    .GUIA_2 = chk_guia_2.Text
                Else
                    .GUIA_2 = ""
                End If
                If chk_factura_2.Checked Then
                    .FACTURA_2 = chk_factura_2.Text
                Else
                    .FACTURA_2 = ""
                End If
                If chk_letra_2.Checked Then
                    .LETRA_2 = chk_letra_2.Text
                Else
                    .LETRA_2 = ""
                End If
                .TRANSFERENCIA = txt_cod_transferencia.Text
                .N_OPERACION = txt_n_operacion.Text
                .OBS_GENERAL = txt_obs_general.Text
                .RECEPCION_TERCERO = txt_recepcion_tercero.Text
                .MODO_PAGO = txtModoPago.Text

                If chk_transferencia.Checked Then
                    .TRANSFERENCIA_2 = chk_transferencia.Text
                Else
                    .TRANSFERENCIA_2 = ""
                End If
                If chk_efectivo.Checked Then
                    .EFECTIVO_2 = chk_efectivo.Text
                Else
                    .EFECTIVO_2 = ""
                End If
                .TIPO_PEDIDO = cboTipoPedido.SelectedValue
                .CONTACTO_NOMBRES = txtContactoNombres.Text.Trim
                .CONTACTO_DNI = txtContactoDNI.Text.Trim
                .CONTACTO_CELULAR = txtContactoCelular.Text.Trim

                .FECHA_ENTREGA = dtpFechaEntrega.Value.ToShortDateString
                .FECHA_RECEPCION = dtpFechaRecepcion.Value.ToShortDateString
                .HORA_RECEPCION = dtpHoraRecepcion.Value.ToString("HH:mm:ss")
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

    Private Function Generar_XML_Factura_Guia(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Monto_Letras As String,
                                 Optional ByVal _envia_email As String = "",
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

    Private Function EliminarFacturas(ByVal _USER As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String,
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
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

    Private Function VerificarDocumentos(ByVal _NombreStore As String, ByVal _DOCUMENT_ID As String,
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

    Private Function AnularFacturas(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String,
                                    ByVal _NUMBER_DOCUMENT As String, Optional ByVal ComprobanteP As String = "",
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

    Private Function Cierre_Ventas(ByVal _FECHA As String, ByVal _USUARIO As String, ByVal _SALDO_FINAL As Double,
                                    ByVal _SALDO_FINAL_VISA As Double, ByVal _SALDO_FINAL_MASTER As Double,
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

    Private Function Reenvio_Docs_Electronicos(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String,
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

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim STRPedido As String = String.Empty
            Dim STREstado As String = String.Empty
            Dim Estado As String = String.Empty


            STRPedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
            STREstado = dgvDocumentosFactura.CurrentRow.Cells("Situacion").Value
            Estado = dgvDocumentosFactura.CurrentRow.Cells("Estado.Facturacion").Value

            If STREstado = "AUTORIZADO" Then 'Or STREstado = "APROBADO" Then
                MessageBox.Show("El pedido ya se encuentra AUTORIZADO/APROBADO, no puede anularse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf STREstado = "RECHAZADO" Then
                MessageBox.Show("El pedido se encuentra RECHAZADO, no puede anularse .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf STREstado = "ANULADO" Then
                MessageBox.Show("El pedido ya se encuentra ANULADO, no puede anularse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf STREstado = "FACTURADO" Then
                MessageBox.Show("El pedido ya se encuentra FACTURADO, no puede anularse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Estado = "FACTURADO" Or Estado = "FACTURADO TOTAL" Or Estado = "FACTURADO PARCIAL" Then
                MessageBox.Show("El pedido ya se encuentra FACTURADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("¿Desea ANULAR el pedido N° " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If STREstado = "EMITIDO" Or STREstado = "APROBADO" Then
                    clsPedidoBl = New ClsOperaciones.ORDERS
                    If clsPedidoBl.Anular_Pedido(STRPedido) = True Then
                        MsgBox("Pedido anulado correctamente.", MsgBoxStyle.Information)
                        DocumentosFactura()
                    End If
                End If
            End If
            btnCancelar_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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


    Private Sub imprimirFacturacion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String,
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

                    crystalBL.Muestra_Reporte(Nom_Reporte, dtImprimir, "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE,
                                              "@NUMERO;" & _NUMBER_DOCUMENT, "@LETRAS;" & STRmontotexto, "@DOC_REF;" & RelacionDoc, "@REF_NC;" & REF_NC)
                Else
                    crystalBL.Muestra_Reporte(Nom_Reporte, dtImprimir, "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE,
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

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
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

                crystalBL.Muestra_Reporte("rpt_Impresion_pedido.rpt", dtImprimir, "", "", "@ID;" & _Codigo,
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString,
                                          "LETRA;" & STRmontotexto)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub imprimir_pedido_Formato_Cliente(ByVal _Codigo As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Pedidos")
            Dim dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor


            Dim codigo As String = String.Empty
            codigo = InputBox("Digite 1 para imprimir CON IGV" & Chr(13) & "Digite 2 para imprimir SIN IGV")
            If codigo = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Es necesario digitar una opción.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                If codigo <> "1" And codigo <> "2" Then
                    Me.Cursor = Cursors.Default
                    MsgBox("La opción digitada no es correcta. Verifique!!!", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    dtImprimir = reporteBL.EjecutarReportePedidos_Formato_Cliente(_Codigo)
                    dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
                    If dtImprimir.Rows.Count() <> 0 Then
                        Dim STRmontotexto As String = ""
                        If cboMoneda.SelectedValue = "MN" Then
                            STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(dtImprimir.Rows(0).Item("TOTAL"))))) & " Soles"
                        Else
                            STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(dtImprimir.Rows(0).Item("TOTAL"))))) & " Dólares Americanos"
                        End If

                        If codigo = "1" Then
                            crystalBL.Muestra_Reporte("rpt_Impresion_pedido_formato_cliente_1.rpt", dtImprimir, "", "", "@ID;" & _Codigo,
                                                  "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString,
                                                  "LETRA;" & STRmontotexto)
                        ElseIf codigo = "2" Then
                            crystalBL.Muestra_Reporte("rpt_Impresion_pedido_formato_cliente_2.rpt", dtImprimir, "", "", "@ID;" & _Codigo,
                                                  "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString,
                                                  "LETRA;" & STRmontotexto)
                        End If
                    End If
                    Me.Cursor = Cursors.Default
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click, Button1.Click
        pnlPrincipal.Visible = True
        GbdetalleDocumento.Visible = False
        Botonera_Estado_Cambiar(False)
        Limpiar()
        'If LibComunVar.ClsVarComun.DESHACER_PEDIDO = "SI" Then
        '    btn_deshacer_aprobar.Visible = True
        'Else
        '    btn_deshacer_aprobar.Visible = False
        'End If
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
                If rbFacturaRepMedico.Checked = False Then
                    txtFormaPago.Select()
                End If
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
                If rbFacturaRepMedico.Checked = False Then
                    txtFormaPago.Select()
                End If
            End If
            If rbFacturaRepMedico.Checked = True Then
                If String.IsNullOrEmpty(txtVendedor.Text) Or String.IsNullOrEmpty(txtAlmacen.Text) Then
                    MsgBox("Para este tipo de Facturacion es necesario el Vendedor y el Almacen.", MsgBoxStyle.Information)
                    'pnlDocumentosGuiaVenta.Visible = False
                    Exit Sub
                Else
                    'MostrandoDocumentoCliente()
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

                    If cboTipoDoc.Text = "BV" And frm.Data_Matriz.Rows(0).Item(2).ToString.Length = 8 Or
                        cboTipoDoc.Text = "FT" And frm.Data_Matriz.Rows(0).Item(2).ToString.Length = 11 Or
                        cboTipoDoc.Text = "PF" Then
                        txtCod_Cliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                        txtRazonSocial.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                        txtRucDni.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                        txtDireccion.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                        txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                        If rbFacturaRepMedico.Checked = False Then
                            txtVendedor.Text = frm.Data_Matriz.Rows(0).Item("SALES_ID").ToString
                        End If
                    Else
                        MsgBox("Documento de Identidad no corresponde al documento de venta", MsgBoxStyle.Information)
                        txtCod_Cliente.Text = String.Empty
                        txtRazonSocial.Text = String.Empty
                        txtRucDni.Text = String.Empty
                        txtDireccion.Text = String.Empty
                        txtFormaPago.Text = String.Empty
                        txtVendedor.Text = String.Empty
                        lblVendedor.Text = String.Empty
                        lblFormaPago.Text = String.Empty
                        cboDirEntrega.DataSource = Nothing
                        txtCod_Cliente.Focus()
                        Exit Sub
                    End If


                End If
                frm.Close()
            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Clientes")
                dtDetalleFact = clsFacturaBl.Get_ManualClientes(_CodigoCliente)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtCod_Cliente.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txtRazonSocial.Text = dtDetalleFact.Rows(0).Item(1).ToString
                    txtRucDni.Text = dtDetalleFact.Rows(0).Item(2).ToString
                    txtDireccion.Text = dtDetalleFact.Rows(0).Item(3).ToString
                    If rb_facturar_pedido.Checked = False Then
                        txtFormaPago.Text = dtDetalleFact.Rows(0).Item(5).ToString
                        If rbFacturaRepMedico.Checked = False Then
                            txtVendedor.Text = dtDetalleFact.Rows(0).Item("SALES_ID").ToString
                        End If
                    End If
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtCod_Cliente.Text = String.Empty
                    txtRazonSocial.Text = String.Empty
                    txtRucDni.Text = String.Empty
                    txtDireccion.Text = String.Empty
                    txtFormaPago.Text = String.Empty
                    txtVendedor.Text = String.Empty
                    lblVendedor.Text = String.Empty
                    lblFormaPago.Text = String.Empty
                    cboDirEntrega.DataSource = Nothing
                    txtCod_Cliente.Focus()
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
            If txtCod_Cliente.Text = String.Empty Then Exit Sub
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
            If rbFacturaGuiaVenta.Checked = True Then
                If String.IsNullOrEmpty(txtCod_Cliente.Text) Or String.IsNullOrEmpty(txtAlmacen.Text) Then
                    MsgBox("Para este tipo de Facturacion es necesario el Cliente y el Almacen.", MsgBoxStyle.Information)
                    'pnlDocumentosGuiaVenta.Visible = False
                    Exit Sub
                Else
                    'MostrandoDocumentoCliente()
                    ' txtFiltroCliente.Text = String.Empty
                    ' lblDetalle.Text = "GUIAS DE VENTA"
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
                    txtFormaPago.Select()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCod_Cliente.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Clientes()
        If e.KeyCode = Keys.Enter Then
            If txtCod_Cliente.Text = String.Empty Then
                Ayuda_Clientes()
            Else
                Ayuda_Clientes(txtCod_Cliente.Text)
            End If
        End If
    End Sub

    Private Sub txtCodCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCod_Cliente.MouseDoubleClick
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
                MsgBox("Debe seleccionar un Almacén, para poder continuar.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If rdb_opt_local.Checked Then
                If txtLocalDescripcion.Text = String.Empty Then
                    MsgBox("Debe seleccionar un local", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If
            End If
            If rdb_opt_agencia.Checked Then
                If txt_cod_agencia_trans.Text = String.Empty Then
                    MsgBox("Debe seleccionar una Empresa de transporte", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If

                If txtDireccionTransportistaDescripcion.Text = String.Empty Then
                    MsgBox("Debe de indicar la dirección de la agencia", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If

                If txtContactoNombres.Text = String.Empty Then
                    MsgBox("Indique el Nombre del Contacto", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If

                If txtContactoDNI.Text = String.Empty Then
                    MsgBox("Indique el DNI del Contacto", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If

                If txtContactoCelular.Text = String.Empty Then
                    MsgBox("Indique el Celular del Contacto", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If

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
            If txtCod_Cliente.Text = String.Empty Then
                MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Information)
                estado = False
                txtCod_Cliente.Focus()
                Exit Try
            End If

            If txtVendedor.Text = String.Empty Then
                MsgBox("No se cargo el dato del Vendedor.", MsgBoxStyle.Information)
                estado = False
                txtVendedor.Focus()
                Exit Try
            End If

            If txtFormaPago.Text = String.Empty Then
                MsgBox("Debe elegir una Forma de Pago.", MsgBoxStyle.Information)
                estado = False
                txtFormaPago.Focus()
                Exit Try
            End If

            If chkSinOC.Checked = False And txtordenCompra.Text = String.Empty Then
                MsgBox("Debe de ingresar la Orden de compra del cliente.", MsgBoxStyle.Information)
                estado = False
                btnOrdenCompra.Focus()
                Exit Try
            End If

            If txtFormaPago.Text = "00" Then
                If txt_cod_transferencia.Text = String.Empty Then
                    MsgBox("Debe elegir un Banco", MsgBoxStyle.Information)
                    estado = False
                    txt_cod_transferencia.Focus()
                    Exit Try
                End If

                If txt_n_operacion.Text = String.Empty Then
                    MsgBox("Debe de ingresar el número de Operación", MsgBoxStyle.Information)
                    estado = False
                    txt_n_operacion.Focus()
                    Exit Try
                End If

                If txtModoPago.Text = String.Empty Then
                    MsgBox("Debe de ingresar el modo de pago", MsgBoxStyle.Information)
                    estado = False
                    txtModoPago.Focus()
                    Exit Try
                End If

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

    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticuloRapido
            frmArticulo.AlmacenOrigen = txtAlmacen.Text
            frmArticulo.TipoDocumento = cboTipoDoc.Text
            frmArticulo.Flag_Cliente = txtCod_Cliente.Text
            frmArticulo.NumeroSerie = cboSerieDoc.Text
            If rbFacturaDirecta.Checked = True Or rb_facturar_pedido.Checked Then frmArticulo.Flag_Factura_directa = True
            If rb_facturar_pedido.Checked Then frmArticulo.Flag_Factura_Pedido = True
            If rb_facturar_pedido.Checked = True Then
                frmArticulo._ARTS_INICIALES = _ARTS_INICIALES
                frmArticulo._DT_SALDO_INICIAL = _DT_SALDO_INICIAL
                frmArticulo._DT_SALDO_PRINCIPAL = dtdetalleArticuloPrincipal
            End If

            If rbFacturaGuiaVenta.Checked = True Or rbFacturaRepMedico.Checked = True Then
                frmArticulo.Flag_Factura_Rep_medico = True
                frmArticulo.Flag_FacturaGuiaVenta = True
                frmArticulo._DT_SALDO_INICIAL = _DT_SALDO_INICIAL
                frmArticulo._DT_SALDO_PRINCIPAL = dtdetalleArticuloPrincipal
            End If
            'frmArticulo.ValidacionLotes = DatosLotes()
            frmArticulo.GenerarColummnValidacionLotesGenerales()
            If rbFacturaExistencias.Checked = True Or rbsinDescargo.Checked = True Then frmArticulo.Flag_FacturaExistencias = True
            frmArticulo.Fl_NC_REF = Fl_NC_REF
            'frmArticulo.MdiParent = Me.MdiParent
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
                'If cboTipoDoc.Text = "FT" Then
                '    row("IGV_POR") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                '    IGV_POR_ITEM = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                'Else
                '    row("IGV_POR") = 0 'frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                '    IGV_POR_ITEM = 0 'frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                'End If

                If IGV_GENERAL > 0 Then
                    row("IGV_POR") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                    IGV_POR_ITEM = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                Else
                    row("IGV_POR") = 0 'frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                    IGV_POR_ITEM = 0 'frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                End If

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
            If dgvDetalle.Rows.Count() <> 0 Then
                dgvDetalle.CurrentCell = dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells(2)
            End If
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
                po_TasaIgv = IGV_POR_ITEM 'CDbl(dtIgvArticulo.Rows(0).Item("AMOUNT_TAX"))

                If dtIgvArticulo.Rows.Count() <> 0 Then
                    If chkSinIGV.Checked = False Then
                        If cboTipoDoc.Text = "NC" Then
                            '*********** CALCULOS DE TOTALES GENERALES ***
                            'total = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(PREC_UNITARIO)", "") * dtdetalleArticuloPrincipal.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero))
                            total = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(VALOR_VENTA)", ""), 4, MidpointRounding.AwayFromZero)) + Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(VALOR_VENTA_FRACCION)", ""), 4, MidpointRounding.AwayFromZero))
                            totaldesc1 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero))
                            totaldesc2 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero))
                            txtBruto.Text = -Math.Abs(Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero))
                            txtDescuentos.Text = -Math.Abs(Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero))
                            txtvalorVenta.Text = -Math.Abs(Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero))
                            txtIgv.Text = -Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART)", ""), 4, MidpointRounding.AwayFromZero) + Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART_FRACCION)", ""), 4, MidpointRounding.AwayFromZero))
                            txtIsc.Text = -Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(ISC)", ""), 4, MidpointRounding.AwayFromZero))
                            '*********** 
                        Else
                            '*********** CALCULOS DE TOTALES GENERALES***
                            total = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(VALOR_VENTA)", ""), 4, MidpointRounding.AwayFromZero) + Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(VALOR_VENTA_FRACCION)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc1 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc2 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero)
                            txtBruto.Text = Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtDescuentos.Text = Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero)
                            txtIgv.Text = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART)", ""), 4, MidpointRounding.AwayFromZero)) + Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART_FRACCION)", ""), 4, MidpointRounding.AwayFromZero))
                            txtIsc.Text = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(ISC)", ""), 4, MidpointRounding.AwayFromZero))
                            '*********** 
                        End If
                    Else
                        If cboTipoDoc.Text = "NC" Then
                            '*********** CALCULOS DE TOTALES GENERALES
                            total = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL_INICIAL)", ""), 4, MidpointRounding.AwayFromZero)) + Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL_INICIAL_FRACCION)", ""), 4, MidpointRounding.AwayFromZero))
                            totaldesc1 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero))
                            totaldesc2 = Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero))

                            txtBruto.Text = -Math.Abs(Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero))
                            txtDescuentos.Text = -Math.Abs(Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero))
                            txtvalorVenta.Text = -Math.Abs(Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero))
                            txtIgv.Text = -Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART)", ""), 4, MidpointRounding.AwayFromZero) + Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART_FRACCION)", ""), 4, MidpointRounding.AwayFromZero))
                            txtIsc.Text = -Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(ISC)", ""), 4, MidpointRounding.AwayFromZero))
                            '***********
                        Else
                            '*********** CALCULOS DE TOTALES GENERALES

                            total = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL_INICIAL)", ""), 4, MidpointRounding.AwayFromZero) + Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL_INICIAL_FRACCION)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc1 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc2 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero)

                            txtBruto.Text = Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtDescuentos.Text = Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero)
                            txtIgv.Text = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART)", ""), 4, MidpointRounding.AwayFromZero) + Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART_FRACCION)", ""), 4, MidpointRounding.AwayFromZero)
                            txtIsc.Text = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(ISC)", ""), 4, MidpointRounding.AwayFromZero)
                            '***********
                        End If
                    End If
                End If
                '*********** FORMATO DE SALIDA
                txtBruto.Text = Format(Double.Parse(txtBruto.Text), "##,##0.00")
                txtDescuentos.Text = Format(Double.Parse(txtDescuentos.Text), "##,##0.00")
                txtvalorVenta.Text = Format(Double.Parse(txtvalorVenta.Text), "##,##0.00")
                txtIgv.Text = Format(Double.Parse(txtIgv.Text), "##,##0.00")
                txtIsc.Text = Format(Double.Parse(txtIsc.Text), "##,##0.00")
                txtPrecioVenta.Text = Double.Parse(txtBruto.Text) + Double.Parse(txtIgv.Text) + Double.Parse(txtIsc.Text)
                txtPrecioVenta.Text = Format(Double.Parse(txtPrecioVenta.Text), "##,##0.00")
                '***********
            Else
                txtBruto.Text = "0.00"
                txtDescuentos.Text = "0.00"
                txtvalorVenta.Text = "0.00"
                txtIgv.Text = "0.00"
                txtIsc.Text = "0.00"
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
                                    Monto = Val(Format((Monto / (1 + TasaIgv)) / (1 + TasaISC), "0.0000000000"))
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
                                    Monto = Val(Format((Monto / (1 + TasaIgv)) / (1 + TasaISC), "0.0000000000"))

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
                                    Monto = Val(Format((Monto / (1 + TasaIgv)) / (1 + TasaISC), "0.0000000000"))

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
                                        Monto = Val(Format(Monto * (1 + TasaIgv), "0.0000000000"))
                                    Else
                                        Monto = Val(Format(Monto / (1 + TasaIgv), "0.0000000000"))
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

                                    Monto = Val(Format((Monto * (1 + TasaIgv)) * (1 + TasaISC), "0.0000000000"))

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

                                    Monto = Val(Format((Monto * (1 + TasaIgv)) * (1 + TasaISC), "0.0000000000"))

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
                Mostrando_Totales_Generales()
            Else
                txtBruto.Text = "0.00"
                txtDescuentos.Text = "0.00"
                txtvalorVenta.Text = "0.00"
                txtIgv.Text = "0.00"
                txtIsc.Text = "0.00"
                txtPrecioVenta.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
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
            If rbFacturaDirecta.Checked = True Then
                NombreTipoFacturacion = rbFacturaDirecta.Text
            ElseIf rbFacturaGuiaVenta.Checked = True Then
                NombreTipoFacturacion = rbFacturaGuiaVenta.Text
            ElseIf rbFacturaExistencias.Checked = True Then
                NombreTipoFacturacion = rbFacturaExistencias.Text
            ElseIf rbsinDescargo.Checked = True Then
                NombreTipoFacturacion = rbsinDescargo.Text
            ElseIf rbFacturaRepMedico.Checked = True Then
                NombreTipoFacturacion = rbFacturaRepMedico.Text
            ElseIf rb_facturar_pedido.Checked = True Then
                NombreTipoFacturacion = rb_facturar_pedido.Text
            ElseIf rb_facturar_devolucion.Checked = True Then
                NombreTipoFacturacion = rb_facturar_pedido.Text
            End If
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
            Dim frmArticulo As New FrmAsignarArticuloRapido
            frmArticulo.AlmacenOrigen = txtAlmacen.Text
            frmArticulo.TipoDocumento = cboTipoDoc.Text
            frmArticulo.Flag_Cliente = txtCod_Cliente.Text
            frmArticulo.NumeroSerie = cboSerieDoc.Text
            Dim _CANTIDAD As String
            Dim _CANTIDAD_TOTAL_LOTE As Double = 0.0
            Dim _CANTIDAD_LOTE As Double = 0.0
            Dim _DIF_CANTIDAD As Double = 0.0
            Dim _LOTE As String = dgvDetalle.Item(5, dgvDetalle.CurrentRow.Index).Value.ToString
            _CANTIDAD = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value
            If rbFacturaDirecta.Checked = True Or rb_facturar_pedido.Checked Then frmArticulo.Flag_Factura_directa = True
            If rb_facturar_pedido.Checked Then
                frmArticulo.Flag_Factura_Pedido = True
                frmArticulo._ARTS_INICIALES = _ARTS_INICIALES
                frmArticulo._DT_SALDO_INICIAL = _DT_SALDO_INICIAL
                frmArticulo._DT_SALDO_PRINCIPAL = dtdetalleArticuloPrincipal
            End If
            If rb_facturar_devolucion.Checked Then
                frmArticulo.Flag_Factura_directa = True
                frmArticulo.Flag_Factura_Dev = True
            End If
            If rbFacturaGuiaVenta.Checked = True Or rbFacturaRepMedico.Checked = True Then
                frmArticulo.Flag_Factura_Rep_medico = rbFacturaRepMedico.Checked
                Dim Exis() As DataRow = _DT_SALDO_INICIAL.Select("LOTE ='" & _LOTE & "'", "")
                If Exis.Count() <> 0 Then
                    _CANTIDAD_TOTAL_LOTE = _DT_SALDO_INICIAL.Compute("SUM (CANTIDAD)", "LOTE ='" & _LOTE & "'")
                    _CANTIDAD_LOTE = dtdetalleArticuloPrincipal.Compute("SUM (CANTIDAD)", "LOTE ='" & _LOTE & "'")
                End If
            End If
            Dim _ARTICULO As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
            frmArticulo.GenerarColummnValidacionLotesGenerales()
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo._ARTICULO = _ARTICULO
            frmArticulo._LOTE = _LOTE
            frmArticulo._CANTIDAD = _CANTIDAD
            'frmArticulo.ValidacionLotes = DatosLotes()
            frmArticulo.Flag_Modo_Edicion = True
            If rbFacturaGuiaVenta.Checked = True Or rbFacturaRepMedico.Checked = True Then
                If _CANTIDAD_TOTAL_LOTE = _CANTIDAD Then
                    frmArticulo.Qt_saldo = _CANTIDAD_TOTAL_LOTE
                Else
                    _DIF_CANTIDAD = _CANTIDAD_TOTAL_LOTE - _CANTIDAD_LOTE
                    frmArticulo.Qt_saldo = _CANTIDAD + _DIF_CANTIDAD
                End If
                frmArticulo.Flag_FacturaGuiaVenta = True
            Else
                frmArticulo.Qt_saldo = _CANTIDAD
            End If
            Dim Codigo As String = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            If rbFacturaExistencias.Checked = True Or rbsinDescargo.Checked = True Then frmArticulo.Flag_FacturaExistencias = True
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
                row("IGV_POR") = item("IGV_POR")
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
                        item("IGV_POR") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                        IGV_POR_ITEM = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                        item("IMPORTE") = 0
                        item("PRECIO_INICIAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRECIO_INICIAL")
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
        Flag_Modo_Edicion = True
        If GbCabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            'GbCabecera.Enabled = False
            gbTipoFacturacion.Enabled = False
        End If
        ModificandoArticulos_Detalle()
    End Sub

    Private Sub ModificandoArticulos_Detalle()
        Try
            Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value

            'Enviando datos seleccioandos a Modificar
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                txtcodigoArticulo.Text = item("CODIGO")
                If AgregarArticuloManual(txtcodigoArticulo.Text) Then
                    txtdescripcionArticulo.Text = item("DESCRIPCION")
                    txtcantidad.Text = Math.Abs(item("CANTIDAD"))
                    txtprecioUnitario.Text = item("PRECIO_INICIAL")
                    txt_numero_lote.Text = item("LOTE")
                    txt_por_Des.Text = item("%DESC.ART_1")
                    txtcantidad.Select()
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
        If dgvDetalle.Rows.Count = 0 Then
            txtCod_Cliente.Enabled = True
            cboTipoDoc.Enabled = True
        End If
        txt_buscador_productos.Focus()
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
            dtDirCliente = cConsultabL.get_Direcciones_Cliente(txtCod_Cliente.Text)
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

        txtCod_Cliente.Text = String.Empty
        txtRazonSocial.Text = String.Empty
        txtRucDni.Text = String.Empty
        txtDireccion.Text = String.Empty
        txtFormaPago.Text = String.Empty
        txtVendedor.Text = String.Empty

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

    Private Sub checkSinGuia_CheckedChanged(sender As Object, e As EventArgs) Handles checkSinGuia.CheckedChanged
        If checkSinGuia.Checked = True Then
            txtCodTrans.Text = String.Empty
            txtNomTrans.Text = String.Empty
            txtGlosaGuia.Text = String.Empty
            txtCodTrans.Enabled = False
            txtGlosaGuia.Enabled = False
            txtGlosaGuia.Visible = False
            ' AjustarTamaño(True)
            ' gbTipoGuia.Visible = False
        Else
            txtCodTrans.Enabled = True
            txtGlosaGuia.Enabled = True
            txtGlosaGuia.Visible = True
            ' AjustarTamaño(False)
            'gbTipoGuia.Visible = True
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
            txtCod_Cliente.Text = ""
            txtRucDni.Text = ""
            txtRazonSocial.Text = ""
            txtDireccion.Text = ""
            txtVendedor.Text = ""
            txtFormaPago.Text = ""
        End If
        txtcotizacion.Text = ""
        txtordenCompra.Text = ""
        chkSinOC.Checked = False
        txtpedido.Text = ""
        txtCodTrans.Text = ""
        cboDirEntrega.Text = ""
        cboDirEntrega.DataSource = Nothing
        cboDirEntrega.Items.Clear()
        lblFormaPago.Text = ""
        lblVendedor.Text = ""
        GenerarColummnaDataTable()
        Mostrando_Totales_Generales()
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
                    txtCod_Cliente.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ID").ToString
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

                If txtCod_Cliente.Text <> String.Empty Then
                    clsBuscarBl = New ClsBuscar
                    Dim dtDatos As New DataTable
                    dtDatos = clsBuscarBl.Get_NombreTerceros(txtCod_Cliente.Text)
                    If dtDatos.Rows.Count() <> 0 Then
                        txtCod_Cliente.Text = dtDatos.Rows(0).Item(0).ToString
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
                        txtCod_Cliente.Text = ""
                    End If
                End If
                '---Mostrando datos del Detalle
                clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsFacturaCabBl.get_DetalleFacturacionNotaCredito(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, cboTipoDoc.Text)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    chkSinIGV.Checked = True
                    Mostrando_Totales_Generales()
                    'Formato_Grillas()
                    Fl_NC_REF = True
                Else
                    MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                    ''CALCULANDO TOTALES GENERALES
                    If cboTipoDoc.Text = "NC" Then
                        txtBruto.Text = "-0.00"
                        txtDescuentos.Text = "-0.00"
                        txtvalorVenta.Text = "-0.00"
                        txtIgv.Text = "-0.00"
                        txtPrecioVenta.Text = "-0.00"
                        Fl_NC_REF = False
                    ElseIf cboTipoDoc.Text = "ND" Then
                        txtBruto.Text = "0.00"
                        txtDescuentos.Text = "0.00"
                        txtvalorVenta.Text = "0.00"
                        txtIgv.Text = "0.00"
                        txtPrecioVenta.Text = "0.00"
                        Fl_NC_REF = False
                    End If

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
                Mostrando_Totales_Generales()
            Else
                MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                ''CALCULANDO TOTALES GENERALES
                txtBruto.Text = "-0.00"
                txtDescuentos.Text = "-0.00"
                txtvalorVenta.Text = "-0.00"
                txtIgv.Text = "-0.00"
                txtPrecioVenta.Text = "-0.00"
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
            If rb_facturar_devolucion.Checked Then
                If txttipoDocRef.Text <> "RD" Then Exit Sub
                Ayuda_NumeroDocumentosDevoluciones()
            Else
                If txttipoDocRef.Text <> "FT" Then Exit Sub
                Ayuda_NumeroDocumentosReferencia()
            End If
        End If
        If rbsinDescargo.Checked Then
            If txttipoDocRef.Text <> "GR" Then Exit Sub
            Ayuda_NumeroDocumentosReferenciaGuias()
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
        If txtCod_Cliente.Text = String.Empty Then
            MsgBox("Es necesario Elegir un Cliente para poder Continuar.", MsgBoxStyle.Information)
            txtCod_Cliente.Focus()
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

    Private Sub btnGenerarCP_Click(sender As Object, e As EventArgs)
        '---Comprbante de Percepcion
        If MessageBox.Show("¿Desea Generar Comprobante de Percepcion.?", "Comprobante Percepcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
            MontoPercepcion = ((txtPrecioVenta.Text * PorcentajePercepcion) / 100)

            dtVerificar = cabeceraBL.get_VerificacionComprobanteP(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
            If dtVerificar.Rows.Count() = 0 Then
                If CodigoNumeroComprobatePercepcion() = False Then
                    MsgBox("Usted eligio generar Comprobante de Percepcion, es necesario escoger un Tipo de Numeracion.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                cabeceraBL = New ClsOperaciones.RECEIVABLE
                If cabeceraBL.GuardarComprobantePercepcion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, NumeracionFacturaCP, TipoNumeracionCp, MontoPercepcion, PorcentajePercepcion) = False Then
                    MsgBox("Hubo un error en la Generacion del Comprobante de Percepcion", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    MsgBox("Comprobante de Percepcion generado Correctamente", MsgBoxStyle.Information)
                    'gbGenerarCP.Visible = False
                End If
            Else
                MsgBox("Ya se Generó un Comprobante de Percepcion." & vbCrLf & " Nro Documento: CP - " & dtVerificar.Rows(0).Item("NUMBER_COMP_PER").ToString, MsgBoxStyle.Information)
                ' gbGenerarCP.Visible = False
            End If
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub


    Private Sub rbFacturaDirecta_CheckedChanged(sender As Object, e As EventArgs) Handles rbFacturaDirecta.CheckedChanged
        If Modo_consultar = True Or Modo_editar = True Then Exit Sub
        If rbFacturaDirecta.Checked = True Then
            Limpiar()
        End If
    End Sub

    Private Sub rbFacturaGuiaVenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbFacturaGuiaVenta.CheckedChanged
        If Modo_consultar = True Or Modo_editar = True Then Exit Sub
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
        If Modo_consultar = True Or Modo_editar = True Then Exit Sub
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
                If clsFacturaBl.GenerarCobro(_DOCUMENT_ID, _NUMBER_SERIE & _NUMBER_DOCUMENT,
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

    Private Sub txtGlosaGuia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGlosaGuia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rbunalinea.Checked = True Then
                e.Handled = True
                If rb_facturar_pedido.Checked Then
                    btnModificar.PerformClick()
                Else
                    btnAgregar_Click(sender, e)
                End If
            End If
        End If
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

        If txtCod_Cliente.Text = "" Then
            MsgBox("Debe seleccionar un Cliente para poder Elegir esta opcion.", MsgBoxStyle.Information)
            txtCod_Cliente.Focus()
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

    Private Sub rbsinDescargo_CheckedChanged(sender As Object, e As EventArgs) Handles rbsinDescargo.CheckedChanged
        If Modo_consultar = True Or Modo_editar Then Exit Sub
        If rbsinDescargo.Checked = True Then
            Limpiar()
            checkSinGuia.Checked = True
            checkSinGuia.Enabled = False
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

    Private Sub rbFacturaRepMedico_CheckedChanged(sender As Object, e As EventArgs) Handles rbFacturaRepMedico.CheckedChanged
        If Modo_consultar = True Or Modo_editar Then Exit Sub
        If rbFacturaRepMedico.Checked = True Then
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

    Private Sub cboDirEntrega_KeyDown(sender As Object, e As KeyEventArgs) Handles cboDirEntrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGlosa.Select()
        End If
    End Sub

    Private Sub txtGlosa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGlosa.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rbunalineaDoc.Checked = True Then
                e.Handled = True
                txtGlosaGuia.Select()
            End If
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

    Private Sub rb_facturar_pedido_CheckedChanged(sender As Object, e As EventArgs) Handles rb_facturar_pedido.CheckedChanged
        If Modo_consultar = True Or Modo_editar Then Exit Sub
        txtCod_Cliente.Enabled = Not rb_facturar_pedido.Checked
        txtVendedor.Enabled = Not rb_facturar_pedido.Checked
        txtFormaPago.Enabled = Not rb_facturar_pedido.Checked
        btnquitar.Visible = Not rb_facturar_pedido.Checked
        cboTipoDoc.Enabled = Not rb_facturar_pedido.Checked
        If rb_facturar_pedido.Checked = True Then
            Limpiar()
            'pnl_pedido.Visible = True
            'dgv_cab_ped.DataSource = Nothing
            GbCabecera.Enabled = False
            MostrandoDocumentoPedidos()
        Else
            'pnl_pedido.Visible = False
            dtdetalleArticuloPrincipal.Rows.Clear()
            'dgv_cab_ped.DataSource = Nothing
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
        End If
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


    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
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
            gbOpciones.Enabled = True
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
                txtCod_Cliente.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
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

    Private Sub rb_facturar_devolucion_CheckedChanged(sender As Object, e As EventArgs) Handles rb_facturar_devolucion.CheckedChanged
        If Modo_consultar = True Or Modo_editar Then Exit Sub
        txtCod_Cliente.Enabled = Not rb_facturar_devolucion.Checked
        btnAgregar.Visible = Not rb_facturar_devolucion.Checked
        btnquitar.Visible = Not rb_facturar_devolucion.Checked
        cboTipoDoc.Enabled = Not rb_facturar_devolucion.Checked
        dtdetalleArticuloPrincipal.Rows.Clear()
        'dgv_detalle_dev.DataSource = Nothing
        If rb_facturar_devolucion.Checked = True Then
            Limpiar()
        Else
            gbOpciones.Enabled = True
            btnAgregar.Visible = True
            btnquitar.Visible = True
        End If
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

    Private Sub txtNumDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumDocRef.KeyDown
        If txtPtoVenta.Text = String.Empty Then
            MsgBox("Debe seleccionar un Punto Venta.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf txttipoDocRef.Text = String.Empty Then
            MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If cboTipoDoc.Text = "NC" Then
            If rb_facturar_devolucion.Checked Then
                If txttipoDocRef.Text <> "RD" Then Exit Sub
                Ayuda_NumeroDocumentosDevoluciones()
            Else
                If txttipoDocRef.Text <> "FT" Then Exit Sub
                Ayuda_NumeroDocumentosReferencia()
            End If
        End If
        If rbsinDescargo.Checked Then
            If txttipoDocRef.Text <> "GR" Then Exit Sub
            Ayuda_NumeroDocumentosReferenciaGuias()
        End If
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


    Private Sub btnclientenuevo_Click(sender As Object, e As EventArgs) Handles btnclientenuevo.Click
        panel_cliente_nuevo.Visible = True
        pnl_ref.Visible = False
        GbCabecera.Enabled = False
        gbdetalle.Enabled = False
        gbOpciones.Enabled = False

        txt_ruc_dni.Text = String.Empty
        txt_razon_social.Text = String.Empty
        txt_direccion.Text = String.Empty
        txt_cod_departamento.Text = String.Empty
        txt_des_departamento.Text = String.Empty
        txt_cod_provincia.Text = String.Empty
        txt_des_provincia.Text = String.Empty
        txt_cod_distrito.Text = String.Empty
        txt_des_distrito.Text = String.Empty
        txt_correo.Text = String.Empty

        Cargar_Documentos_Persona()
        'GenerarCodigoCliente()
        cmb_tip_doc_per.SelectedIndex = -1
        txt_ruc_dni.Focus()
    End Sub
    Private Sub Cargar_Documentos_Persona()
        Dim tipoDocBL As New LibContabilidad.ClsOperaciones.CO_TB_TIPO_DOC_ANE
        cmb_tip_doc_per.DataSource = tipoDocBL.get_Tipos
        cmb_tip_doc_per.DisplayMember = "TD_DESCRIPCION"
        cmb_tip_doc_per.ValueMember = "TD_ID"
        tipoDocBL = Nothing
    End Sub
    'Private Sub GenerarCodigoCliente()
    '    Try
    '        Dim dtdetalles As DataTable
    '        clienteBL = New ClsNegocio.CUSTOMER
    '        dtdetalles = New DataTable("CodigoCliente")
    '        dtdetalles = clienteBL.GeneracionCodigoCliente("G", "L")
    '        If dtdetalles.Rows.Count() <> 0 Then
    '            TextBox1.Text = dtdetalles.Rows(0).Item(0).ToString
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Function Consultando_Ruc() As Boolean
        Try
            Dim clienteBl As ClsOperaciones.CUSTOMER
            Dim dt_ruc As New DataTable
            clienteBl = New ClsOperaciones.CUSTOMER
            dt_ruc = clienteBl.Validacion_Ruc(txt_ruc_dni.Text)
            If dt_ruc.Rows.Count() = 0 Then
                Return True
            Else
                MsgBox("El número del documento ingresado ya existe en la base de datos." & Chr(13) & " Ingrese uno correcto.", MsgBoxStyle.Critical, "Sistemas")
                Return False
                txt_ruc_dni.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        panel_cliente_nuevo.Visible = False
        pnl_ref.Visible = False
        GbCabecera.Enabled = True
        gbdetalle.Enabled = True
        gbOpciones.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        panel_cliente_nuevo.Visible = False
        pnl_ref.Visible = True
        GbCabecera.Enabled = False
        gbdetalle.Enabled = False
        gbOpciones.Enabled = False
        If Flag_Ref = False Then
            txt_tipo_doc_ref.Text = String.Empty
            txt_serie_ref_doc.Text = String.Empty
            txt_numero_ref_doc.Text = String.Empty
            dtp_fec_doc_ref.Value = Date.Now
        End If

        txt_tipo_doc_ref.Focus()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If txt_tipo_doc_ref.Text = "" Then
            MsgBox("Debe seleccionar y/o digitar un Tipo de Documento de Referencia.", MsgBoxStyle.Exclamation)
            txt_tipo_doc_ref.Focus()
            Exit Sub
        ElseIf txt_serie_ref_doc.Text = "" Then
            MsgBox("Debe seleccionar y/o digitar una Serie de Documento de Referencia.", MsgBoxStyle.Exclamation)
            txt_serie_ref_doc.Focus()
            Exit Sub
        ElseIf txt_numero_ref_doc.Text = "" Then
            MsgBox("Debe seleccionar y/o digitar una Número de Documento de Referencia.", MsgBoxStyle.Exclamation)
            txt_numero_ref_doc.Focus()
            Exit Sub
        ElseIf CDate(dtp_fec_doc_ref.Value.ToString("dd/MM/yyyy")) > CDate(dtpFechaFactura.Value.ToString("dd/MM/yyyy")) Then
            MsgBox("La Fecha de Referencia debe ser menor a la fecha del Documento a Emitir", MsgBoxStyle.Exclamation)
            dtp_fec_doc_ref.Focus()
            Exit Sub
        End If
        Flag_Ref = True
        panel_cliente_nuevo.Visible = False
        pnl_ref.Visible = False
        GbCabecera.Enabled = True
        gbdetalle.Enabled = True
        gbOpciones.Enabled = True
        MostrandoFacturaNotasCredito(txt_tipo_doc_ref.Text, txt_serie_ref_doc.Text, txt_numero_ref_doc.Text)
    End Sub

    Private Sub txt_tipo_doc_ref_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tipo_doc_ref.MouseDoubleClick
        Ayuda_Doc_Referencia()
    End Sub

    Private Sub txt_tipo_doc_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipo_doc_ref.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Doc_Referencia()
        If e.KeyCode = Keys.Enter Then
            If txt_tipo_doc_ref.Text = String.Empty Then
                Ayuda_Doc_Referencia()
            Else
                dtp_fec_doc_ref.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Doc_Referencia()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_DOCUMENTOS_REF"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Filtros1 = ""
            frm.Titulo = "Lista de Documentos de Referencia"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_tipo_doc_ref.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_serie_ref_doc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_numero_ref_doc.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                dtp_fec_doc_ref.Value = frm.Data_Matriz.Rows(0).Item(3).ToString
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Cargar_Departamento_direc_entrega()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_REP_UBIGEO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Departamentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'departamento
                txt_cod_departamento.Text = String.Empty
                txt_des_departamento.Text = String.Empty
                'provincia
                txt_cod_provincia.Text = String.Empty
                txt_des_provincia.Text = String.Empty
                'distrito
                txt_cod_distrito.Text = String.Empty
                txt_des_distrito.Text = String.Empty

                ''datos del departamento
                txt_cod_departamento.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_des_departamento.Text = frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString
                txt_cod_provincia.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Provincia_direcc_entrega()
        Try

            If String.IsNullOrEmpty(txt_cod_departamento.Text) Then
                MsgBox("Es necesario elegir un Departamento", MsgBoxStyle.Information)
                txt_cod_departamento.Focus()
                Exit Sub
            End If

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_PROV"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_cod_departamento.Text
            frm.Titulo = "Provincias"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'provincia
                txt_cod_provincia.Text = String.Empty
                txt_des_provincia.Text = String.Empty
                'distrito
                txt_cod_distrito.Text = String.Empty
                txt_des_distrito.Text = String.Empty

                txt_cod_provincia.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_provincia.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_cod_distrito.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Distrito_direc_entrega()
        Try
            If String.IsNullOrEmpty(txt_cod_departamento.Text) Then
                MsgBox("Es necesario elegir un Departamento", MsgBoxStyle.Information)
                txt_cod_departamento.Focus()
                Exit Sub
            ElseIf String.IsNullOrEmpty(txt_cod_provincia.Text) Then
                MsgBox("Es necesario elegir una Provincia", MsgBoxStyle.Information)
                txt_cod_provincia.Focus()
                Exit Sub
            End If

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_DIST"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_cod_departamento.Text
            frm.Filtros2 = txt_cod_provincia.Text
            frm.Titulo = "Distritos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_distrito.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_des_distrito.Text = frm.Data_Matriz.Rows(0).Item("DISTRITO").ToString
                txt_correo.Focus()
            Else
                txt_cod_distrito.Text = String.Empty
                txt_des_distrito.Text = String.Empty
            End If
            frm.Close()
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


    Private Sub txtPrecioVenta_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioVenta.TextChanged
        TextBox19.Text = "Total a Pagar " + txtPrecioVenta.Text
    End Sub


    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim codigoArticulo As String = String.Empty
            codigoArticulo = txtcodigoArticulo.Text.Trim
            If AgregarArticuloManual(codigoArticulo) Then
                txtcantidad.Text = "1"
                txtcantidad.Focus()
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

    Private Sub txtprecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioUnitario.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprecioUnitario.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Button9_Click(sender, e)
        End If
    End Sub

    Private Sub txtprecioUnitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprecioUnitario.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos_Precio()
        If e.KeyCode = Keys.Enter Then
            If txtprecioUnitario.Text = "" Then
                MostrandoArticulos_Precio()
            Else
                btn_agregar_carrito_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Button9_Click(sender, e)
        End If
    End Sub

    Private Sub MostrandoArticulos_Precio()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PED_SP_S_PRECIOS_PRODUCTO_HISTORIAL"
            frm._Flag_Filtro = True
            frm.Filtros1 = txtcodigoArticulo.Text.Trim
            frm.Filtros2 = txtCod_Cliente.Text.Trim
            frm.Filtros3 = cboMoneda.SelectedValue
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Precios"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtprecioUnitario.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtprecioUnitario.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Flag_Modo_Edicion = False
        txtcodigoArticulo.Text = String.Empty
        txtdescripcionArticulo.Text = String.Empty
        txtcantidad.Text = String.Empty
        txtcantidad_fraccion.Text = String.Empty
        txtprecioUnitario.Text = String.Empty
        txtprecioUnitario_fraccion.Text = String.Empty
        txtStock.Text = String.Empty
        txt_por_Des.Text = String.Empty
        txt_buscador_productos.Text = String.Empty
        txt_numero_lote.Text = String.Empty
        IGV_POR_ITEM = 0
        TIPO_ISC = 0
        ISC_POR = 0
        chkigv.Checked = True
        dgv_lista_productos.DataSource = Nothing
        txtdescripcionArticulo.Focus()
    End Sub

    Private Sub btn_agregar_carrito_Click(sender As Object, e As EventArgs) Handles btn_agregar_carrito.Click
        If ValidacionesGenerales_Detalle() = False Then Exit Sub
        If Flag_Modo_Edicion = False Then
            'Agregando los datos a devolver
            If CDbl(txtcantidad.Text) > 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("CODIGO") = txtcodigoArticulo.Text
                row("CANTIDAD") = txtcantidad.Text
                row("CANTIDAD_FRACCION") = 0
                row("UNIDAD") = _txt_unidad_producto
                row("DESCRIPCION") = txtdescripcionArticulo.Text
                row("LOTE") = txt_numero_lote.Text
                row("PREC_UNITARIO") = 0
                row("PREC_UNITARIO_FRACCION") = 0
                If txt_por_Des.Text = "" Then
                    row("%DESC.ART_1") = 0
                Else
                    row("%DESC.ART_1") = CDbl(txt_por_Des.Text)
                End If
                row("%DESC.ART_2") = 0
                row("VALOR_VENTA") = 0
                row("VALOR_VENTA_FRACCION") = 0
                row("IGV_POR") = IGV_POR_ITEM
                row("IMP_DESC_01") = 0
                row("IMP_DESC_02") = 0
                row("PRECIO_IGV") = 0
                row("PRECIO_IGV_FRACCION") = 0
                row("IGV_ART") = IGV_POR_ITEM
                row("IGV_ART_FRACCION") = 0
                row("IGV_ART_US") = IGV_POR_ITEM
                row("IMPORTE") = 0
                row("IMPORTE_FRACCION") = 0
                row("PRECIO_INICIAL") = txtprecioUnitario.Text
                row("PRECIO_INICIAL_FRACCION") = 0
                row("TOTAL_INICIAL") = Math.Round(row("CANTIDAD") * row("PRECIO_INICIAL"), 6)
                row("TOTAL_INICIAL_FRACCION") = 0
                row("TIPO") = "1"
                row("PESO_NETO") = 0
                row("PESO_BRUTO") = 0
                row("ITEM_INI") = ""
                row("OBSERVACIONES") = ""
                row("DOC_REF") = ""
                row("NUM_REF") = ""
                row("ITEM_REF") = 0

                row("TIPOISC") = TIPO_ISC
                row("ISCPOR") = ISC_POR
                row("ISC") = 0
                If chkigv.Checked = True Then
                    row("PRECIO_CON_IGV") = "SI"
                Else
                    row("PRECIO_CON_IGV") = "NO"
                End If

                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()

                txtCod_Cliente.Enabled = False
                cboTipoDoc.Enabled = False
            End If
            If CDbl(txtcantidad_fraccion.Text) > 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("CODIGO") = txtcodigoArticulo.Text
                row("CANTIDAD") = 0
                row("CANTIDAD_FRACCION") = txtcantidad_fraccion.Text
                row("UNIDAD") = _txt_unidad_producto
                row("DESCRIPCION") = txtdescripcionArticulo.Text
                row("LOTE") = txt_numero_lote.Text
                row("PREC_UNITARIO") = 0
                row("PREC_UNITARIO_FRACCION") = 0
                If txt_por_Des.Text = "" Then
                    row("%DESC.ART_1") = 0
                Else
                    row("%DESC.ART_1") = CDbl(txt_por_Des.Text)
                End If
                row("%DESC.ART_2") = 0
                row("VALOR_VENTA") = 0
                row("VALOR_VENTA_FRACCION") = 0
                row("IGV_POR") = IGV_POR_ITEM
                row("IMP_DESC_01") = 0
                row("IMP_DESC_02") = 0
                row("PRECIO_IGV") = 0
                row("PRECIO_IGV_FRACCION") = 0
                row("IGV_ART") = 0
                row("IGV_ART_FRACCION") = IGV_POR_ITEM
                row("IGV_ART_US") = 0
                row("IMPORTE") = 0
                row("IMPORTE_FRACCION") = 0
                row("PRECIO_INICIAL") = 0
                row("PRECIO_INICIAL_FRACCION") = txtprecioUnitario_fraccion.Text
                row("TOTAL_INICIAL") = 0
                row("TOTAL_INICIAL_FRACCION") = Math.Round(row("CANTIDAD_FRACCION") * row("PRECIO_INICIAL_FRACCION"), 6)
                row("TIPO") = "1"
                row("PESO_NETO") = 0
                row("PESO_BRUTO") = 0
                row("ITEM_INI") = ""
                row("OBSERVACIONES") = ""
                row("DOC_REF") = ""
                row("NUM_REF") = ""
                row("ITEM_REF") = 0

                row("TIPOISC") = TIPO_ISC
                row("ISCPOR") = ISC_POR
                row("ISC") = 0
                If chkigv.Checked = True Then
                    row("PRECIO_CON_IGV") = "SI"
                Else
                    row("PRECIO_CON_IGV") = "NO"
                End If
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                txtCod_Cliente.Enabled = False
                cboTipoDoc.Enabled = False
            End If

            Calcular_Totales()
            If dgvDetalle.Rows.Count() <> 0 Then
                dgvDetalle.CurrentCell = dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells(2)
            End If
            Button9_Click(sender, e)
            'Formato_Grillas()
        Else
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                dtdetalleArticuloPrincipal.BeginInit()
                item("CODIGO") = txtcodigoArticulo.Text
                item("CANTIDAD") = txtcantidad.Text
                item("CANTIDAD_FRACCION") = txtcantidad_fraccion.Text
                item("UNIDAD") = _txt_unidad_producto
                item("DESCRIPCION") = txtdescripcionArticulo.Text
                item("LOTE") = txt_numero_lote.Text
                item("PREC_UNITARIO") = 0
                item("PREC_UNITARIO_FRACCION") = 0
                If txt_por_Des.Text = "" Then
                    item("%DESC.ART_1") = 0
                Else
                    item("%DESC.ART_1") = CDbl(txt_por_Des.Text)
                End If
                item("%DESC.ART_2") = 0
                item("VALOR_VENTA") = 0
                item("VALOR_VENTA_FRACCION") = 0
                item("IMP_DESC_01") = 0
                item("IMP_DESC_02") = 0
                item("PRECIO_IGV") = 0
                item("PRECIO_IGV_FRACCION") = 0
                item("IGV_ART") = IGV_POR_ITEM
                item("IGV_ART_FRACCION") = IGV_POR_ITEM
                item("IGV_ART_US") = IGV_POR_ITEM
                item("IGV_POR") = IGV_POR_ITEM
                item("IMPORTE") = 0
                item("IMPORTE_FRACCION") = 0
                item("PRECIO_INICIAL") = txtprecioUnitario.Text
                item("PRECIO_INICIAL_FRACCION") = txtprecioUnitario_fraccion.Text
                item("TOTAL_INICIAL") = Math.Round(item("CANTIDAD") * item("PRECIO_INICIAL"), 6)
                item("TOTAL_INICIAL_FRACCION") = Math.Round(item("CANTIDAD_FRACCION") * item("PRECIO_INICIAL_FRACCION"), 6)
                item("TIPO") = "1"
                item("PESO_NETO") = 0
                item("PESO_BRUTO") = 0
                item("ITEM_INI") = ""
                item("OBSERVACIONES") = ""
                item("DOC_REF") = ""
                item("NUM_REF") = ""
                item("ITEM_REF") = 0
                item("TIPOISC") = TIPO_ISC
                item("ISCPOR") = ISC_POR
                item("ISC") = 0
                If chkigv.Checked = True Then
                    item("PRECIO_CON_IGV") = "SI"
                Else
                    item("PRECIO_CON_IGV") = "NO"
                End If
                dtdetalleArticuloPrincipal.EndInit()
                dtdetalleArticuloPrincipal.AcceptChanges()

                txtCod_Cliente.Enabled = False
                cboTipoDoc.Enabled = False
            Next

            Calcular_Totales()
            If dgvDetalle.Rows.Count() <> 0 Then
                dgvDetalle.CurrentCell = dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells(2)
            End If
            Button9_Click(sender, e)
            'Formato_Grillas()

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
    Private Function ValidacionesGenerales_Detalle() As Boolean
        Dim estado As Boolean = True
        Try
            If txtcantidad.Text = String.Empty Then txtcantidad.Text = "0"
            If txtcantidad_fraccion.Text = String.Empty Then txtcantidad_fraccion.Text = "0"

            If txtprecioUnitario.Text = String.Empty Then txtprecioUnitario.Text = "0"
            If txtprecioUnitario_fraccion.Text = String.Empty Then txtprecioUnitario_fraccion.Text = "0"

            If txtcodigoArticulo.Text = String.Empty Then
                MsgBox("Debe seleccionar o ingresar el codigo de un Articulo.", MsgBoxStyle.Exclamation)
                txtcodigoArticulo.Focus()
                estado = False
                Exit Try
            ElseIf txtcantidad.Text = String.Empty And txtcantidad_fraccion.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Exclamation)
                estado = False
                txtcantidad.Select()
                Exit Try
            ElseIf txtprecioUnitario.Text = String.Empty And txtprecioUnitario_fraccion.Text = String.Empty Then
                MsgBox("Debe ingresar el Precio Unitario.", MsgBoxStyle.Exclamation)
                estado = False
                txtprecioUnitario.Focus()
                Exit Try
            End If

            If CDbl(txtprecioUnitario.Text) <= 0 And CDbl(txtprecioUnitario_fraccion.Text) <= 0 Then
                MsgBox("El precio debe ser mayor a Cero", MsgBoxStyle.Exclamation)
                estado = False
                txtprecioUnitario.Focus()
                Exit Try
            End If
            If CDbl(txtcantidad.Text) <= 0 And CDbl(txtcantidad_fraccion.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Exclamation)
                estado = False
                txtcantidad.Focus()
                Exit Try
            End If

            'Dim _AFECTA_STOCK As String = "N"
            'clsFacturaBl = New ClsNegocio.RECEIVABLE
            'dtValidacion = New DataTable("Validacion")
            'dtValidacion = clsFacturaBl.Get_Validacion(cboTipoDoc.Text, cboSerieDoc.Text)
            'If dtValidacion.Rows.Count > 0 Then
            '    _AFECTA_STOCK = dtValidacion.Rows(0).Item("IS_STOCK").ToString
            '    If _AFECTA_STOCK = "S" Then
            '        If txtcodigoArticulo.Text <> "N0008" Then
            '            If CDbl(IIf(txtStock.Text = "", 0, txtStock.Text)) < CDbl(txtcantidad.Text) Then
            '                MsgBox("La cantidad debe ser menor o igual que el  Stock.", MsgBoxStyle.Exclamation)
            '                estado = False
            '                txtcantidad.SelectAll()
            '                Exit Try
            '            End If
            '        End If
            '    End If
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function



    Private Sub dgv_lista_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lista_productos.CellClick
        If dgv_lista_productos.CurrentRow Is Nothing Then Exit Sub

        Try
            _filtra = False
            txtcodigoArticulo.Text = dgv_lista_productos.CurrentRow.Cells("CODIGO").Value
            txtdescripcionArticulo.Text = dgv_lista_productos.CurrentRow.Cells("DESCRIPCION").Value & " " & dgv_lista_productos.CurrentRow.Cells("PRESENTACION").Value
            _txt_unidad_producto = dgv_lista_productos.CurrentRow.Cells("UNID_MED").Value
            txtprecioUnitario.Text = dgv_lista_productos.CurrentRow.Cells("PRECIO_MINORISTA").Value
            txtprecioUnitario_fraccion.Text = dgv_lista_productos.CurrentRow.Cells("PRECIO_FRACCION").Value
            IGV_POR_ITEM = dgv_lista_productos.CurrentRow.Cells("IGV").Value
            txtStock.Text = Format(CDbl(dgv_lista_productos.CurrentRow.Cells("STOCK").Value), "##,##0.0.0")
            TIPO_ISC = dgv_lista_productos.CurrentRow.Cells("TIPO_ISC").Value
            ISC_POR = dgv_lista_productos.CurrentRow.Cells("ISC_POR").Value
            txt_numero_lote.Text = dgv_lista_productos.CurrentRow.Cells("LOTE").Value
            txtcantidad.Text = "0"
            txtcantidad_fraccion.Text = "0"
            txtcantidad.Select()
            _filtra = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_por_Des_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_por_Des.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_por_Des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_por_Des.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_agregar_carrito_Click(sender, e)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If MessageBox.Show("¿Desea Anular el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor

            'Anulacion Factura 
            Dim PuntoVenta As String = dgvDocumentosFactura.Item(0, dgvDocumentosFactura.CurrentRow.Index).Value
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

            If AnularFacturas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "", WareHouse, txt_motivo_anulacion.Text.Trim) = False Then
                MsgBox("Hubo un error, no se completo el Proceso de Anulacion", MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Then
                    ID_COMUNICACION_BAJA_ = ""
                    If Generar_XML_Comunicacion_Baja(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, dtp_fecha_anulacion.Value.ToString("dd/MM/yyyy"), ID_COMUNICACION_BAJA_) = False Then
                        Me.Cursor = Cursors.Default
                        MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " no genero el archivo XML UBL 2.1, de la Comunicación de Baja." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                    Else
                        Dim StrNomArchivo_XML As String = ""

                        StrNomArchivo_XML = Ruta_FE() & "\InputXML\RA-" & ID_COMUNICACION_BAJA_

                        Dim oProcesaArchivo As New ProcesaArchivo
                        Dim strMensaje As String = ""

                        If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                            MsgBox(strMensaje, MsgBoxStyle.Critical)
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Else
                            DocumentosFactura()
                            Button8_Click(sender, e)
                            Dim msj As String
                            msj = String.Empty
                            msj = "Documento Anulado Correctamente." & vbCrLf & "Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                            MsgBox(msj, MsgBoxStyle.Information)
                        End If
                    End If
                Else
                    DocumentosFactura()
                    Button8_Click(sender, e)
                    Dim msj As String
                    msj = String.Empty
                    msj = "Documento Anulado Correctamente." & vbCrLf & "Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                    MsgBox(msj, MsgBoxStyle.Information)
                End If
            End If

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Function Generar_XML_Comunicacion_Baja(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Fecha_baja As String,
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ToolStrip1.Enabled = True
        pnlPrincipal.Enabled = True
        pnl_motivo_anulacion.Visible = False
    End Sub

    Private Sub btn_cierre_ventas_Click(sender As Object, e As EventArgs)
        Dim cl As LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
        cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
        Dim dtTipoCamb_tc As DataTable
        dtTipoCamb_tc = New DataTable

        cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
        'dtTipoCamb_tc = cl.get_Verificar_Cierre_Caja_Chica(LibComunVar.ClsVarComun.FechaSistema.ToString("dd/MM/yyyy"), LibComunVar.ClsVarComun.USUARIO)
        If dtTipoCamb_tc.Rows.Count() > 0 Then
            MsgBox("El proceso de Cierre de Caja Chica para" & vbCrLf & "Fecha: " & LibComunVar.ClsVarComun.FechaSistema.ToString("dd/MM/yyyy") & vbCrLf & "Usuario: " & LibComunVar.ClsVarComun.USUARIO & vbCrLf & "ya se llevo a cabo. Verifique!!!", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        Else
            ToolStrip1.Enabled = False
            pnlPrincipal.Enabled = False
            dtp_fecha_cierre_ventas.Value = Date.Now
            dtp_fecha_cierre_ventas.Enabled = True
            txt_saldo_final.Text = "0"
            AMOUNT_CARD_VISA.Text = "0"
            AMOUNT_CARD_MASTER.Text = "0"
            AMOUNT_DINERS.Text = "0"
            AMOUNT_AMERICAN_EXPRES.Text = "0"
            lbl_usuario_cierre.Text = LibComunVar.ClsVarComun.USUARIO
            pnl_cierre_ventas.Visible = True
            txt_saldo_final.Focus()
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ToolStrip1.Enabled = True
        pnlPrincipal.Enabled = True
        pnl_cierre_ventas.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            If MessageBox.Show("¿Desea generar el Cierre de Ventas?" & Chr(13) & "Fecha: " & dtp_fecha_cierre_ventas.Value.ToString("dd/MM/yyyy") & Chr(13) & "Usuario: " & LibComunVar.ClsVarComun.USUARIO, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                If txt_saldo_final.Text = "" Then txt_saldo_final.Text = "0"
                If AMOUNT_CARD_VISA.Text = "" Then AMOUNT_CARD_VISA.Text = "0"
                If AMOUNT_CARD_MASTER.Text = "" Then AMOUNT_CARD_MASTER.Text = "0"
                If AMOUNT_DINERS.Text = "" Then AMOUNT_DINERS.Text = "0"
                If AMOUNT_AMERICAN_EXPRES.Text = "" Then AMOUNT_AMERICAN_EXPRES.Text = "0"
                If Cierre_Ventas(dtp_fecha_cierre_ventas.Value.ToString("dd/MM/yyyy"),
                                 LibComunVar.ClsVarComun.USUARIO, CDbl(txt_saldo_final.Text),
                                 CDbl(AMOUNT_CARD_VISA.Text), CDbl(AMOUNT_CARD_MASTER.Text), CDbl(AMOUNT_DINERS.Text), CDbl(AMOUNT_AMERICAN_EXPRES.Text)) = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de Cierre de Ventas para la fecha elegida.", MsgBoxStyle.Exclamation)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    reporteBL = New ClsBuscar
                    crystalBL = New LibReportes.ClsReporte

                    'dtImprimir = reporteBL.Reporte_Cierre_Ventas(dtp_fecha_cierre_ventas.Value.ToString("dd/MM/yyyy"), LibComunVar.ClsVarComun.USUARIO)
                    dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
                    If dtImprimir.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_Arqueo_Caja.rpt", dtImprimir, "", "",
                                                  "@FECHA;" & dtp_fecha_cierre_ventas.Value.ToString("dd/MM/yyyy"),
                                                  "@USUARIO;" & LibComunVar.ClsVarComun.USUARIO,
                                                  "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString,
                                                  "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                    Else
                        MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
                    End If

                    'Dim cl As LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
                    'cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
                    'Dim dtTipoCamb_tc As DataTable
                    'dtTipoCamb_tc = New DataTable
                    'Dim numero_planilla As String = ""

                    'cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
                    'dtTipoCamb_tc = cl.get_Verificar_Numero_Planilla_Caja_Chica(dtp_fecha_cierre_ventas.Value.ToString("dd/MM/yyyy"), LibComunVar.ClsVarComun.USUARIO)
                    'If dtTipoCamb_tc.Rows.Count() <> 0 Then
                    '    numero_planilla = dtTipoCamb_tc.Rows(0).Item("planilla")
                    'Else
                    '    numero_planilla = ""
                    'End If

                    'Dim dtDatosCompany As DataTable
                    'Me.Cursor = Cursors.WaitCursor
                    'dtImprimir = New DataTable("CajaChica")
                    'dtImprimir = reporteBL.Reporte_Caja_Chica(numero_planilla, LibComunVar.ClsVarComun.USUARIO)
                    'dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
                    'If dtImprimir.Rows.Count() <> 0 Then
                    '    crystalBL.Muestra_Reporte("REP_PLA_CAJA_CHICA.rpt", dtImprimir, "", "", _
                    '                              "@ID_PLANILLA;" & numero_planilla, _
                    '                              "@USUARIO;" & LibComunVar.ClsVarComun.USUARIO, _
                    '                              "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                    '                              "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                    'Else
                    '    MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
                    'End If
                    DocumentosFactura()
                    Button11_Click(sender, e)
                    Dim msj As String
                    msj = String.Empty
                    msj = "Cierre de Ventas generado correctamente." & vbCrLf & "Fecha: " & dtp_fecha_cierre_ventas.Value.ToString("dd/MM/yyyy") & vbCrLf & "Usuario: " & LibComunVar.ClsVarComun.USUARIO
                    MsgBox(msj, MsgBoxStyle.Information)
                    Me.Cursor = Cursors.Default
                End If

                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtprecioUnitario_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtprecioUnitario.MouseDoubleClick
        MostrandoArticulos_Precio()
    End Sub

    Private Sub btn_cancelar_crear_Click(sender As Object, e As EventArgs) Handles btn_cancelar_crear.Click
        pnlNuevaPlanilla.Visible = False
        dtp_fec_nueva_pla.Value = Date.Now
        ToolStrip1.Enabled = True
        pnlPrincipal.Enabled = True
        txtFiltro.Select()
    End Sub

    Private Sub btn_crear_planilla_Click(sender As Object, e As EventArgs) Handles btn_crear_planilla.Click
        Try
            Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST
            'Dim planillaBE As New ClsEntidades.RECEIVABLE_CAJA_CHICA
            Dim numero_planilla As String = String.Empty
            Dim correlativo_planilla As String = String.Empty
            Dim fecha_puente As Date, fecha_a_guardar As Date, dtTipoCamb_tc As DataTable, tc_a_guardar As Double, tc_a_guardar_ME As Double
            Dim ingresos_vta_mn As Double = 0.0, ingresos_vta_me As Double = 0.0
            Dim cl As LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
            cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE

            Me.Cursor = Cursors.WaitCursor

            dtTipoCamb_tc = Nothing
            dtTipoCamb_tc = cl.Verifircar_Planilla_Caja_chica(dtp_fec_nueva_pla.Value.ToString("dd/MM/yyyy"))
            If dtTipoCamb_tc.Rows.Count() > 0 Then
                Me.Cursor = Cursors.Default
                MsgBox("Existe una planilla de Caja Chica con la fecha y usuario elegido" & Chr(13) & "elija una fecha correcta!!!", MsgBoxStyle.Critical, "Sistemas")
                Exit Sub
            End If

            'With planillaBE
            '    .ID = 0
            '    .DATE_PLA = CDate(dtp_fec_nueva_pla.Value).ToShortDateString
            '    fecha_puente = dtp_fec_nueva_pla.Text
            '    fecha_a_guardar = fecha_puente
            '    cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
            '    dtTipoCamb_tc = cl.get_VerificarTipoCambio(fecha_a_guardar.Year.ToString, fecha_a_guardar.Month.ToString, fecha_a_guardar.Day.ToString)
            '    If dtTipoCamb_tc.Rows.Count() <> 0 Then
            '        tc_a_guardar = dtTipoCamb_tc.Rows(0).Item("Tipo_Venta")
            '    Else
            '        tc_a_guardar = 0
            '    End If
            '    .AMOUNT = 0
            '    .AMOUNT_US = 0
            '    .AMOUNT_CH_DIF = 0
            '    .AMOUNT_CH_DIF_US = 0
            '    .VOUCHER_ID = 0
            '    .STATUS = "P"
            '    .CREATE_DATE = Now.Date.ToShortDateString
            '    .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '    .SALES_ID = ""
            '    .VOUCHER_ID_US = 0
            '    .SELL_RATE = tc_a_guardar
            '    If txt_saldo_inicial_caja.Text = "" Then
            '        .SALDO_INICIAL = 0
            '    Else
            '        .SALDO_INICIAL = CDbl(txt_saldo_inicial_caja.Text)
            '    End If

            '    .INGRESOS = 0
            '    .INGRESOS_VENTAS = 0
            '    .EGRESOS = 0
            '    .SALDO_FINAL = 0

            '    .SALDO_INICIAL_ME = 0
            '    .INGRESOS_ME = 0
            '    .INGRESOS_ME_VENTAS = 0
            '    .EGRESOS_ME = 0
            '    .SALDO_FINAL_ME = 0

            'End With
            'If planillaBL.InsertCajaChica(planillaBE, True, numero_planilla) Then
            '    'cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE

            '    'dtTipoCamb_tc = cl.get_Obtener_Saldo_Final(planillaBE.DATE_PLA)
            '    'If dtTipoCamb_tc.Rows.Count() <> 0 Then
            '    '    tc_a_guardar = dtTipoCamb_tc.Rows(0).Item("SALDO_FINAL")
            '    '    tc_a_guardar_ME = dtTipoCamb_tc.Rows(0).Item("SALDO_FINAL_ME")
            '    '    ingresos_vta_mn = 0
            '    '    ingresos_vta_me = 0

            '    '    Dim CONSULTA As String = String.Empty
            '    '    CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_INICIAL=" & tc_a_guardar + ingresos_vta_mn & ",SALDO_INICIAL_ME=" & tc_a_guardar_ME + ingresos_vta_me & " WHERE ID='" & numero_planilla & "' "
            '    '    cl = New ClsOperaciones.CURRENCY_EXCHANGE
            '    '    cl.Ejecuta_consulta(CONSULTA)
            '    'End If

            '    planillaBE = Nothing
            '    planillaBL = Nothing

            '    pnlNuevaPlanilla.Visible = False
            '    lbl_nombre_usuario.Text = ""
            '    dtp_fec_nueva_pla.Value = Date.Now
            '    ToolStrip1.Enabled = True
            '    pnlPrincipal.Enabled = True
            '    btnNuevo_Click(sender, e)
            '    Me.Cursor = Cursors.Default
            'End If


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


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

    Private Sub TextBox24_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_buscador_especial.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim _palabra_uno As String = ""
            Dim _palabra_dos As String = ""

            If txt_buscador_especial.Text = String.Empty Then
                dtv_lista_productos.RowFilter = String.Empty
                Exit Sub
            Else
                _palabra_uno = Strings.Left(txt_buscador_especial.Text, txt_buscador_especial.Text.IndexOf("*"))
                _palabra_dos = Strings.Mid(txt_buscador_especial.Text, txt_buscador_especial.Text.IndexOf("*") + 2, txt_buscador_especial.Text.Length)

                dtv_lista_productos.RowFilter = String.Format("Descripcion LIKE '%{0}%' And Descripcion LIKE '%{1}%'", _palabra_uno, _palabra_dos)
            End If
        End If
    End Sub

    Private Sub txt_saldo_inicial_caja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_saldo_inicial_caja.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dtp_fec_nueva_pla_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fec_nueva_pla.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_saldo_inicial_caja.Focus()
        End If
    End Sub

    Private Sub txt_saldo_inicial_caja_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_saldo_inicial_caja.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_crear_planilla.Focus()
        End If
    End Sub

    Private Sub txt_buscador_productos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscador_productos.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txt_buscador_productos.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_buscador_productos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_buscador_productos.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Down
                    If dgv_lista_productos.RowCount > 0 Then
                        dgv_lista_productos.Focus()
                    End If
                Case Keys.Enter
                    Me.Cursor = Cursors.WaitCursor

                    Dim _palabra_uno As String = ""
                    Dim _palabra_dos As String = ""

                    If InStr(txt_buscador_productos.Text, "*") > 0 Then
                        _palabra_uno = Strings.Left(txt_buscador_productos.Text, txt_buscador_productos.Text.IndexOf("*"))
                        _palabra_dos = Strings.Mid(txt_buscador_productos.Text, txt_buscador_productos.Text.IndexOf("*") + 2, txt_buscador_productos.Text.Length)

                        clsFacturaBl = New ClsNegocio.RECEIVABLE
                        dt_lista_productos = New DataTable
                        dtv_lista_productos = New DataView
                        dt_lista_productos = clsFacturaBl.Get_Lista_Productos_Venta(txtAlmacen.Text.Trim, "")
                        dgv_lista_productos.DataSource = Nothing
                        If dt_lista_productos.Rows.Count() <> 0 Then
                            dtv_lista_productos = dt_lista_productos.DefaultView

                            dtv_lista_productos.RowFilter = String.Format("Descripcion LIKE '%{0}%' And Descripcion LIKE '%{1}%'", _palabra_uno, _palabra_dos)

                            dgv_lista_productos.DataSource = dtv_lista_productos

                            dgv_lista_productos.Columns("IS_LOT").Visible = False
                            dgv_lista_productos.Columns("IS_STOCKED").Visible = False
                            dgv_lista_productos.Columns("IGV").Visible = False
                            dgv_lista_productos.Columns("TIPO_ISC").Visible = False
                            dgv_lista_productos.Columns("ISC_POR").Visible = False
                            dgv_lista_productos.Columns("CADUCATE_DATE").Visible = False

                            dgv_lista_productos.Columns("PRECIO_FRACCION").Visible = False
                            dgv_lista_productos.Columns("STOCK_FRACCION").Visible = False
                            dgv_lista_productos.Columns("LABORATORIO").Visible = False
                            dgv_lista_productos.Columns("LOTE").Visible = False
                            dgv_lista_productos.Columns("VCTO").Visible = False
                            dgv_lista_productos.Columns("PRESENTACION").Visible = False

                            dgv_lista_productos.Columns("CODIGO").Width = 70
                            dgv_lista_productos.Columns("DESCRIPCION").Width = 500
                            dgv_lista_productos.Columns("PRESENTACION").Width = 200
                            dgv_lista_productos.Columns("UNID_MED").Width = 50
                            dgv_lista_productos.Columns("UNID_MED").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgv_lista_productos.Columns("PRECIO_MINORISTA").Width = 80
                            dgv_lista_productos.Columns("PRECIO_FRACCION").Width = 80
                            dgv_lista_productos.Columns("STOCK").Width = 80
                            dgv_lista_productos.Columns("STOCK_FRACCION").Width = 80
                            dgv_lista_productos.Columns("LABORATORIO").Width = 150
                            dgv_lista_productos.Columns("LOTE").Width = 100
                            dgv_lista_productos.Columns("VCTO").Width = 60
                            dgv_lista_productos.Columns("VCTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                            dgv_lista_productos.Columns("CODIGO").HeaderText = "CODIGO"
                            dgv_lista_productos.Columns("DESCRIPCION").HeaderText = "PRODUCTO"
                            dgv_lista_productos.Columns("PRESENTACION").HeaderText = "PRESENTACION"
                            dgv_lista_productos.Columns("UNID_MED").HeaderText = "UM"
                            dgv_lista_productos.Columns("PRECIO_MINORISTA").HeaderText = "PRECIO"
                            dgv_lista_productos.Columns("PRECIO_FRACCION").HeaderText = "PRECIO FRAC."
                            dgv_lista_productos.Columns("STOCK").HeaderText = "STOCK"
                            dgv_lista_productos.Columns("STOCK_FRACCION").HeaderText = "STOCK"
                            dgv_lista_productos.Columns("LABORATORIO").HeaderText = "LABORATORIO"

                            dgv_lista_productos.Columns("LOTE").HeaderText = "N° LOTE"
                            dgv_lista_productos.Columns("VCTO").HeaderText = "F. VCTO"

                            dgv_lista_productos.Columns("STOCK").DefaultCellStyle.Format = "##,##0.00"
                            dgv_lista_productos.Columns("STOCK").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgv_lista_productos.Columns("STOCK_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                            dgv_lista_productos.Columns("STOCK_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                            dgv_lista_productos.Columns("PRECIO_MINORISTA").DefaultCellStyle.Format = "##,##0.00"
                            dgv_lista_productos.Columns("PRECIO_MINORISTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgv_lista_productos.Columns("PRECIO_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                            dgv_lista_productos.Columns("PRECIO_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                            dgv_lista_productos.Columns("CODIGO").DisplayIndex = 0
                            dgv_lista_productos.Columns("DESCRIPCION").DisplayIndex = 1
                            dgv_lista_productos.Columns("PRESENTACION").DisplayIndex = 2
                            dgv_lista_productos.Columns("UNID_MED").DisplayIndex = 3
                            dgv_lista_productos.Columns("PRECIO_MINORISTA").DisplayIndex = 4
                            dgv_lista_productos.Columns("PRECIO_FRACCION").DisplayIndex = 5
                            dgv_lista_productos.Columns("STOCK").DisplayIndex = 6
                            dgv_lista_productos.Columns("STOCK_FRACCION").DisplayIndex = 7
                            dgv_lista_productos.Columns("LABORATORIO").DisplayIndex = 8
                            dgv_lista_productos.Columns("LOTE").DisplayIndex = 9
                            dgv_lista_productos.Columns("VCTO").DisplayIndex = 10

                            STRorden_Lista_Productos = dgv_lista_productos.Columns("CODIGO").Name & "+" & dgv_lista_productos.Columns("DESCRIPCION").Name & "+" & dgv_lista_productos.Columns("LOTE").Name & "+" & dgv_lista_productos.Columns("LABORATORIO").Name
                            _filtra = True
                            dgv_lista_productos.Focus()
                        End If
                    Else

                        clsFacturaBl = New ClsNegocio.RECEIVABLE
                        dt_lista_productos = New DataTable
                        dtv_lista_productos = New DataView
                        dt_lista_productos = clsFacturaBl.Get_Lista_Productos_Venta(txtAlmacen.Text.Trim, txt_buscador_productos.Text.Trim)
                        dgv_lista_productos.DataSource = Nothing
                        If dt_lista_productos.Rows.Count() <> 0 Then
                            dtv_lista_productos = dt_lista_productos.DefaultView
                            dgv_lista_productos.DataSource = dt_lista_productos

                            dgv_lista_productos.Columns("IS_LOT").Visible = False
                            dgv_lista_productos.Columns("IS_STOCKED").Visible = False
                            dgv_lista_productos.Columns("IGV").Visible = False
                            dgv_lista_productos.Columns("TIPO_ISC").Visible = False
                            dgv_lista_productos.Columns("ISC_POR").Visible = False
                            dgv_lista_productos.Columns("CADUCATE_DATE").Visible = False

                            dgv_lista_productos.Columns("PRECIO_FRACCION").Visible = False
                            dgv_lista_productos.Columns("STOCK_FRACCION").Visible = False
                            dgv_lista_productos.Columns("LABORATORIO").Visible = False
                            dgv_lista_productos.Columns("LOTE").Visible = False
                            dgv_lista_productos.Columns("VCTO").Visible = False
                            dgv_lista_productos.Columns("PRESENTACION").Visible = False

                            dgv_lista_productos.Columns("CODIGO").Width = 70
                            dgv_lista_productos.Columns("DESCRIPCION").Width = 500
                            dgv_lista_productos.Columns("PRESENTACION").Width = 200
                            dgv_lista_productos.Columns("UNID_MED").Width = 50
                            dgv_lista_productos.Columns("UNID_MED").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgv_lista_productos.Columns("PRECIO_MINORISTA").Width = 80
                            dgv_lista_productos.Columns("PRECIO_FRACCION").Width = 80
                            dgv_lista_productos.Columns("STOCK").Width = 80
                            dgv_lista_productos.Columns("STOCK_FRACCION").Width = 80
                            dgv_lista_productos.Columns("LABORATORIO").Width = 150
                            dgv_lista_productos.Columns("LOTE").Width = 100
                            dgv_lista_productos.Columns("VCTO").Width = 60
                            dgv_lista_productos.Columns("VCTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                            dgv_lista_productos.Columns("CODIGO").HeaderText = "CODIGO"
                            dgv_lista_productos.Columns("DESCRIPCION").HeaderText = "PRODUCTO"
                            dgv_lista_productos.Columns("PRESENTACION").HeaderText = "PRESENTACION"
                            dgv_lista_productos.Columns("UNID_MED").HeaderText = "UM"
                            dgv_lista_productos.Columns("PRECIO_MINORISTA").HeaderText = "PRECIO"
                            dgv_lista_productos.Columns("PRECIO_FRACCION").HeaderText = "PRECIO FRAC."
                            dgv_lista_productos.Columns("STOCK").HeaderText = "STOCK"
                            dgv_lista_productos.Columns("STOCK_FRACCION").HeaderText = "STOCK"
                            dgv_lista_productos.Columns("LABORATORIO").HeaderText = "LABORATORIO"

                            dgv_lista_productos.Columns("LOTE").HeaderText = "N° LOTE"
                            dgv_lista_productos.Columns("VCTO").HeaderText = "F. VCTO"

                            dgv_lista_productos.Columns("STOCK").DefaultCellStyle.Format = "##,##0.00"
                            dgv_lista_productos.Columns("STOCK").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgv_lista_productos.Columns("STOCK_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                            dgv_lista_productos.Columns("STOCK_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                            dgv_lista_productos.Columns("PRECIO_MINORISTA").DefaultCellStyle.Format = "##,##0.00"
                            dgv_lista_productos.Columns("PRECIO_MINORISTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgv_lista_productos.Columns("PRECIO_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                            dgv_lista_productos.Columns("PRECIO_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                            dgv_lista_productos.Columns("CODIGO").DisplayIndex = 0
                            dgv_lista_productos.Columns("DESCRIPCION").DisplayIndex = 1
                            dgv_lista_productos.Columns("PRESENTACION").DisplayIndex = 2
                            dgv_lista_productos.Columns("UNID_MED").DisplayIndex = 3
                            dgv_lista_productos.Columns("PRECIO_MINORISTA").DisplayIndex = 4
                            dgv_lista_productos.Columns("PRECIO_FRACCION").DisplayIndex = 5
                            dgv_lista_productos.Columns("STOCK").DisplayIndex = 6
                            dgv_lista_productos.Columns("STOCK_FRACCION").DisplayIndex = 7
                            dgv_lista_productos.Columns("LABORATORIO").DisplayIndex = 8
                            dgv_lista_productos.Columns("LOTE").DisplayIndex = 9
                            dgv_lista_productos.Columns("VCTO").DisplayIndex = 10

                            STRorden_Lista_Productos = dgv_lista_productos.Columns("CODIGO").Name & "+" & dgv_lista_productos.Columns("DESCRIPCION").Name & "+" & dgv_lista_productos.Columns("LOTE").Name & "+" & dgv_lista_productos.Columns("LABORATORIO").Name
                            _filtra = True
                            dgv_lista_productos.Focus()
                        End If

                    End If


                    Me.Cursor = Cursors.Default
            End Select
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_lista_productos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_lista_productos.KeyDown
        If dgv_lista_productos.CurrentRow Is Nothing Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            If dgv_lista_productos.SelectedRows.Count > 0 Then
                DevuelveDatos()
                e.SuppressKeyPress = True
                txtcantidad.Select()
            End If
        End If

    End Sub

    Private Sub DevuelveDatos()
        Try
            If dgv_lista_productos.RowCount = 0 Then Exit Sub
            dgv_lista_productos.CommitEdit(DataGridViewDataErrorContexts.Commit)
            Dim miFila As DataRow
            Dim iCol As Int16
            dtHelp = New DataTable
            For iCol = 0 To dtv_lista_productos.Table.Columns.Count - 1
                dtHelp.Columns.Add(dgv_lista_productos.Columns(iCol).Name)
            Next
            If dgv_lista_productos.SelectedRows.Count = 0 Then
                'Me.Close()
                Exit Sub
            End If
            miFila = dtHelp.NewRow
            Dim INTDato As Int16
            For INTDato = 0 To dtv_lista_productos.Table.Columns.Count - 1
                miFila(dgv_lista_productos.Columns(INTDato).Name) = dgv_lista_productos.Item(INTDato, dgv_lista_productos.CurrentRow.Index).Value
            Next
            dtHelp.Rows.Add(miFila)
            Data_Matriz = dtHelp

            If Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = Data_Matriz.Rows(0).Item("CODIGO").ToString() 'dgv_lista_productos.CurrentRow.Cells("CODIGO").Value
                txtdescripcionArticulo.Text = Data_Matriz.Rows(0).Item("DESCRIPCION").ToString() & "" & Data_Matriz.Rows(0).Item("PRESENTACION").ToString() 'dgv_lista_productos.CurrentRow.Cells("DESCRIPCION").Value
                _txt_unidad_producto = Data_Matriz.Rows(0).Item("UNID_MED").ToString() 'dgv_lista_productos.CurrentRow.Cells("UNID_MED").Value
                txtprecioUnitario.Text = Data_Matriz.Rows(0).Item("PRECIO_MINORISTA").ToString() 'dgv_lista_productos.CurrentRow.Cells("PRECIO_MINORISTA").Value
                txtprecioUnitario.Text = Format(CDbl(txtprecioUnitario.Text), "##,##0.0.0")

                txtprecioUnitario_fraccion.Text = Data_Matriz.Rows(0).Item("PRECIO_FRACCION").ToString() 'dgv_lista_productos.CurrentRow.Cells("PRECIO_MINORISTA").Value
                txtprecioUnitario_fraccion.Text = Format(CDbl(txtprecioUnitario_fraccion.Text), "##,##0.0.0")

                IGV_POR_ITEM = Data_Matriz.Rows(0).Item("IGV").ToString() 'dgv_lista_productos.CurrentRow.Cells("IGV").Value
                txtStock.Text = Format(CDbl(Data_Matriz.Rows(0).Item("STOCK").ToString()), "##,##0.0.0")
                TIPO_ISC = Data_Matriz.Rows(0).Item("TIPO_ISC").ToString() 'dgv_lista_productos.CurrentRow.Cells("TIPO_ISC").Value
                ISC_POR = Data_Matriz.Rows(0).Item("ISC_POR").ToString() 'dgv_lista_productos.CurrentRow.Cells("ISC_POR").Value
                txt_numero_lote.Text = Data_Matriz.Rows(0).Item("LOTE").ToString() 'dgv_lista_productos.CurrentRow.Cells("LOTE").Value
                txtcantidad.Text = "0"
                txtcantidad_fraccion.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Property Data_Matriz() As DataTable
        Get
            Return dtHelp
        End Get
        Set(ByVal Value As DataTable)
            dtHelp = Value
        End Set
    End Property

    Private Sub txt_saldo_final_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_saldo_final.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_saldo_final_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_saldo_final.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Button12.Focus()
            AMOUNT_CARD_VISA.Focus()
        End If
    End Sub

    Private Sub AMOUNT_CARD_VISA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AMOUNT_CARD_VISA.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtModoPago_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtModoPago.MouseDoubleClick
        Ayuda_ModoPago()
    End Sub

    Private Sub txtModoPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtModoPago.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_ModoPago()
        If e.KeyCode = Keys.Enter Then
            If txtModoPago.Text = String.Empty Then
                Ayuda_ModoPago()
            Else

            End If
        End If
    End Sub

    Private Sub Ayuda_ModoPago()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_MODO_COBRO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Modo de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtModoPago.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblModoPago.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_deshacer_aprobar_Click(sender As Object, e As EventArgs) Handles btn_deshacer_aprobar.Click
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim STRPedido As String = String.Empty
            Dim STREstado As String = String.Empty
            Dim Estado As String = String.Empty


            STRPedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
            STREstado = dgvDocumentosFactura.CurrentRow.Cells("Situacion").Value
            Estado = dgvDocumentosFactura.CurrentRow.Cells("Estado.Facturacion").Value

            'If STREstado = "AUTORIZADO" Or STREstado = "APROBADO" Then
            '    MessageBox.Show("El pedido ya se encuentra AUTORIZADO/APROBADO, no puede aprobarse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
            'Else
            If STREstado = "RECHAZADO" Then
                MessageBox.Show("El pedido se encuentra RECHAZADO, no puede desaprobarse .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf STREstado = "ANULADO" Then
                MessageBox.Show("El pedido ya se encuentra ANULADO, no puede desaprobarse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf STREstado = "FACTURADO" Then
                MessageBox.Show("El pedido ya se encuentra FACTURADO, no puede desaprobarse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Estado = "FACTURADO" Or Estado = "FACTURADO TOTAL" Or Estado = "FACTURADO PARCIAL" Then
                MessageBox.Show("El pedido ya se encuentra FACTURADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("¿Desea deshacer la APROBACON del pedido N° " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If STREstado = "APROBADO" Then
                    clsPedidoBl = New ClsOperaciones.ORDERS
                    If clsPedidoBl.DESAPROBAR_Pedido(STRPedido) = True Then
                        MsgBox("Pedido DESAPROBADO correctamente.", MsgBoxStyle.Information)
                        DocumentosFactura()
                    End If
                End If
            End If
            btnCancelar_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AMOUNT_CARD_MASTER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AMOUNT_CARD_MASTER.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_DINERS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AMOUNT_DINERS.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_AMERICAN_EXPRES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AMOUNT_AMERICAN_EXPRES.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_CARD_VISA_KeyDown(sender As Object, e As KeyEventArgs) Handles AMOUNT_CARD_VISA.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Button12.Focus()
            AMOUNT_CARD_MASTER.Focus()
        End If
    End Sub

    Private Sub AMOUNT_CARD_MASTER_KeyDown(sender As Object, e As KeyEventArgs) Handles AMOUNT_CARD_MASTER.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Button12.Focus()
            AMOUNT_DINERS.Focus()
        End If
    End Sub

    Private Sub AMOUNT_DINERS_KeyDown(sender As Object, e As KeyEventArgs) Handles AMOUNT_DINERS.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Button12.Focus()
            AMOUNT_AMERICAN_EXPRES.Focus()
        End If
    End Sub

    Private Sub AMOUNT_AMERICAN_EXPRES_KeyDown(sender As Object, e As KeyEventArgs) Handles AMOUNT_AMERICAN_EXPRES.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button12.Focus()
        End If
    End Sub

    Private Sub txtcantidad_fraccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad_fraccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprecioUnitario.Focus()
        End If
    End Sub

    Private Sub txtcantidad_fraccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad_fraccion.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecioUnitario_fraccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprecioUnitario_fraccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_agregar_carrito_Click(sender, e)
        End If
    End Sub

    Private Sub txtprecioUnitario_fraccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioUnitario_fraccion.KeyPress
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

    Private Sub txtdescripcionArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdescripcionArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCod_Cliente.Text = "00000000" Or txtCod_Cliente.Text.Trim = String.Empty Then
                MessageBox.Show("Debe de Seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If txtdescripcionArticulo.Text <> "" Then
                Dim frm As New FrmMostrar_Productos
                Dim sql As String = String.Empty
                sql = "GUIA_SP_S_GUIA_REMISION_PART_POS_VENTA_MOSTRAR_PRODUCTO"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = txtAlmacen.Text
                frm.Filtros2 = txtdescripcionArticulo.Text.Trim
                frm.Filtros3 = cboMoneda.SelectedValue
                frm.Titulo = "Lista de productos"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    '/////////////////
                    _filtra = False
                    txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                    txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString & " " & frm.Data_Matriz.Rows(0).Item("PRESENTACION").ToString
                    _txt_unidad_producto = frm.Data_Matriz.Rows(0).Item("UNID_MED").ToString
                    txtprecioUnitario.Text = frm.Data_Matriz.Rows(0).Item("PRECIO_MINORISTA").ToString
                    txtprecioUnitario_fraccion.Text = frm.Data_Matriz.Rows(0).Item("PRECIO_FRACCION").ToString
                    IGV_POR_ITEM = frm.Data_Matriz.Rows(0).Item("IGV").ToString
                    txtStock.Text = Format(CDbl(frm.Data_Matriz.Rows(0).Item("STOCK").ToString), "##,##0.0.0")
                    TIPO_ISC = frm.Data_Matriz.Rows(0).Item("TIPO_ISC").ToString
                    ISC_POR = frm.Data_Matriz.Rows(0).Item("ISC_POR").ToString
                    txt_numero_lote.Text = frm.Data_Matriz.Rows(0).Item("LOTE").ToString
                    txtcantidad.Text = "0"
                    txtcantidad_fraccion.Text = "0"
                    txtcantidad.Select()
                    _filtra = True
                Else
                    Button9_Click(sender, e)
                End If
                frm.Close()
            Else
                txtdescripcionArticulo.Select()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Button9_Click(sender, e)
        End If
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
            sql = "FACT_SP_S_BANCOS_PEDIDOS"
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

    Private Sub dgvDocumentosFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumentosFactura.CellClick
        Try
            If dgvDocumentosFactura.RowCount() = 0 Then Exit Sub
            If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

            If dgvDocumentosFactura.CurrentRow.Cells("Situacion").Value = "EMITIDO" Then
                btn_aprobar.Visible = True
            Else
                btn_aprobar.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_aprobar_Click(sender As Object, e As EventArgs) Handles btn_aprobar.Click
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


            Dim _Id As String = String.Empty
            _Id = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
            imprimir_pedido_Formato_TK(_Id)


            If MessageBox.Show("¿Esta SEGURO DE APROBAR el pedido N° " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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

    Private Sub btn_imprimir_fc_Click(sender As Object, e As EventArgs) Handles btn_imprimir_fc.Click
        If dgvDocumentosFactura.Rows.Count() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Dim _Id As String = String.Empty
        _Id = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
        imprimir_pedido_Formato_Cliente(_Id)
    End Sub

    Private Sub rdb_opt_agencia_CheckedChanged(sender As Object, e As EventArgs)
        'If rdb_opt_agencia.Checked Then
        '    txt_cod_agencia_trans.Text = ""
        '    txt_des_agencia_trans.Text = ""
        '    txt_cod_agencia_trans.Enabled = True
        '    txt_guia.Text = ""
        '    txt_guia.Enabled = False
        'End If
    End Sub

    Private Sub rdb_opt_domicilio_CheckedChanged(sender As Object, e As EventArgs)
        'If rdb_opt_domicilio.Checked Then
        '    txt_cod_agencia_trans.Text = ""
        '    txt_des_agencia_trans.Text = ""
        '    txt_cod_agencia_trans.Enabled = False
        '    txt_guia.Text = ""
        '    txt_guia.Enabled = True
        'End If
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

                crystalBL.Muestra_Reporte("SAL_PEDIDO_TK.rpt", dtImprimir, "", "", "@ID;" & _Codigo,
                                          "LETRAS;" & STRmontotexto)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_ruc_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_ruc_dni.TextChanged
        txt_cod_cliente.Text = txt_ruc_dni.Text
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Len(Strings.Trim(txt_ruc_dni.Text)) = 11 Then
                cmb_tip_doc_per.SelectedValue = "6"
            ElseIf Len(Strings.Trim(txt_ruc_dni.Text)) = 8 Then
                Me.Cursor = Cursors.Default
                MsgBox("RUC incorrecto. Verifique", MsgBoxStyle.Exclamation)
                txt_ruc_dni.Focus()
                Exit Sub
                cmb_tip_doc_per.SelectedValue = "1"
            Else
                Me.Cursor = Cursors.Default
                MsgBox("El Código de Cliente debe tener 11 o 8 caracteres.", MsgBoxStyle.Exclamation)
                txt_ruc_dni.Focus()
                Exit Sub
            End If
            If Consultando_Ruc() Then
                Verifica_WS(txt_ruc_dni.Text)
                txt_razon_social.Focus()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Verifica_WS(ByVal _ruc As String)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim url As String = "https://api.apis.net.pe/v1/ruc?numero=" & _ruc
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Proxy = Nothing
            request.UserAgent = "Test"


            Dim response As HttpWebResponse = request.GetResponse
            Dim responseStream As System.IO.Stream = response.GetResponseStream

            Dim streamReader As New System.IO.StreamReader(responseStream)
            Dim data As String = streamReader.ReadToEnd
            streamReader.Close()

            txt_razon_social.Text = JObject.Parse(data)("nombre")
            txt_direccion.Text = JObject.Parse(data)("direccion")

            MsgBox("Estado: " & JObject.Parse(data)("estado").ToString & vbCrLf & "Condición: " & JObject.Parse(data)("condicion").ToString, MsgBoxStyle.Information, "Aviso")

            Dim dt_ubigeo As DataTable
            dt_ubigeo = New DataTable
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE

            txt_cod_departamento.Text = Strings.Left(JObject.Parse(data)("ubigeo"), 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Departamento(txt_cod_departamento.Text, "", "")
            If dt_ubigeo.Rows.Count > 0 Then
                txt_des_departamento.Text = dt_ubigeo.Rows(0).Item("DEPARTAMENTO")
            Else
                txt_des_departamento.Text = ""
            End If

            txt_cod_provincia.Text = Strings.Mid(JObject.Parse(data)("ubigeo"), 3, 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Provincia(txt_cod_departamento.Text, txt_cod_provincia.Text, "")
            If dt_ubigeo.Rows.Count > 0 Then
                txt_des_provincia.Text = dt_ubigeo.Rows(0).Item("PROVINCIA")
            Else
                txt_des_provincia.Text = ""
            End If

            txt_cod_distrito.Text = Strings.Right(JObject.Parse(data)("ubigeo"), 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Distrito(txt_cod_departamento.Text, txt_cod_provincia.Text, txt_cod_distrito.Text)
            If dt_ubigeo.Rows.Count > 0 Then
                txt_des_distrito.Text = dt_ubigeo.Rows(0).Item("DISTRITO")
            Else
                txt_des_distrito.Text = ""
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Len(Strings.Trim(txt_ruc_dni.Text)) = 11 Then
                Me.Cursor = Cursors.Default
                MsgBox("DNI incorrecto. Verifique", MsgBoxStyle.Exclamation)
                txt_ruc_dni.Focus()
                Exit Sub
                cmb_tip_doc_per.SelectedValue = "6"
            ElseIf Len(Strings.Trim(txt_ruc_dni.Text)) = 8 Then
                cmb_tip_doc_per.SelectedValue = "1"
            Else
                Me.Cursor = Cursors.Default
                MsgBox("El Código de Cliente debe tener 11 o 8 caracteres.", MsgBoxStyle.Exclamation)
                txt_ruc_dni.Focus()
                Exit Sub
            End If
            If Consultando_Ruc() Then
                Verifica_WS_DNI(txt_ruc_dni.Text)
                txt_razon_social.Focus()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Verifica_WS_DNI(ByVal _ruc As String)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim url As String = "https://api.apis.net.pe/v1/dni?numero=" & _ruc
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Proxy = Nothing
            request.UserAgent = "Test"


            Dim response As HttpWebResponse = request.GetResponse
            Dim responseStream As System.IO.Stream = response.GetResponseStream

            Dim streamReader As New System.IO.StreamReader(responseStream)
            Dim data As String = streamReader.ReadToEnd
            streamReader.Close()

            txt_razon_social.Text = JObject.Parse(data)("nombre")
            txt_direccion.Text = ""

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmb_tip_doc_per_KeyDown_1(sender As Object, e As KeyEventArgs) Handles cmb_tip_doc_per.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_razon_social.Focus()
        End If
    End Sub

    Private Sub txt_razon_social_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_razon_social.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_direccion.Focus()
        End If
    End Sub

    Private Sub txt_direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_departamento.Focus()
        End If
    End Sub

    Private Sub txt_cod_departamento_TextChanged(sender As Object, e As EventArgs) Handles txt_cod_departamento.TextChanged
        txt_ubigeo.Text = txt_cod_departamento.Text + txt_cod_provincia.Text + txt_cod_distrito.Text
    End Sub

    Private Sub txt_cod_departamento_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_departamento.MouseDoubleClick
        txt_cod_departamento.Text = String.Empty
        Cargar_Departamento_direc_entrega()
    End Sub

    Private Sub txt_cod_departamento_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_departamento.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_cod_departamento.Text = String.Empty
            Cargar_Departamento_direc_entrega()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_departamento.Text = "" Then
                txt_cod_departamento.Text = String.Empty
                Cargar_Departamento_direc_entrega()
            Else
                txt_cod_provincia.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cod_provincia_TextChanged(sender As Object, e As EventArgs) Handles txt_cod_provincia.TextChanged
        txt_ubigeo.Text = txt_cod_departamento.Text + txt_cod_provincia.Text + txt_cod_distrito.Text
    End Sub

    Private Sub txt_cod_provincia_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_provincia.MouseDoubleClick
        txt_cod_provincia.Text = String.Empty
        Cargar_Provincia_direcc_entrega()
    End Sub

    Private Sub chkSinOC_CheckedChanged(sender As Object, e As EventArgs) Handles chkSinOC.CheckedChanged

        If chkSinOC.Checked = True Then
            pdfBytes = Nothing
            NumeroOC = String.Empty
            RutaOC = String.Empty
            txtNumeroOrdenCompra.Text = String.Empty
            txtNumeroOrdenCompra.Enabled = False
            btnOrdenCompra.Enabled = False
        Else
            txtNumeroOrdenCompra.Enabled = True
            btnOrdenCompra.Enabled = True
        End If
    End Sub

    Private Sub txtCod_Cliente_TextChanged(sender As Object, e As EventArgs) Handles txtCod_Cliente.TextChanged

    End Sub

    Private Sub rdb_opt_local_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_opt_local.CheckedChanged
        If rdb_opt_local.Checked = True Then
            txt_cod_agencia_trans.Enabled = False
            txt_des_agencia_trans.Enabled = False
            txtDireccionTransportista.Enabled = False
            txtDireccionTransportistaDescripcion.Enabled = False

            txtDireccionCliente.Enabled = False
            txtDireccionEntregaCliente.Enabled = False

            txt_cod_agencia_trans.Text = String.Empty
            txt_des_agencia_trans.Text = String.Empty
            txtDireccionTransportista.Text = String.Empty
            txtDireccionTransportistaDescripcion.Text = String.Empty
            txtDireccionCliente.Text = String.Empty
            txtDireccionEntregaCliente.Text = String.Empty


            txtLocalDescripcion.Text = String.Empty
            txtLocal.Text = String.Empty
            txtLocal.Enabled = True
            txtLocalDescripcion.Enabled = True

            txt_cod_agencia_trans.BackColor = System.Drawing.Color.White
            txtDireccionTransportista.BackColor = System.Drawing.Color.White

            txtDireccionCliente.BackColor = System.Drawing.Color.White
            txtDireccionEntregaCliente.BackColor = System.Drawing.Color.White

            txtLocal.BackColor = System.Drawing.Color.Aquamarine
            txtLocalDescripcion.BackColor = System.Drawing.Color.Aquamarine

        Else
            txtLocal.BackColor = System.Drawing.Color.White
            txtLocalDescripcion.BackColor = System.Drawing.Color.White
            txtLocal.Enabled = False
            txtLocal.Text = String.Empty
            txtLocalDescripcion.Text = String.Empty
        End If
    End Sub

    Private Sub rdb_opt_agencia_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdb_opt_agencia.CheckedChanged

        If rdb_opt_agencia.Checked = True Then

            txt_cod_agencia_trans.Enabled = True
            txt_des_agencia_trans.Enabled = True
            txtDireccionTransportista.Enabled = True
            txtDireccionTransportistaDescripcion.Enabled = True

            txtDireccionCliente.Enabled = False
            txtDireccionEntregaCliente.Enabled = False

            txtLocal.Enabled = False
            txtLocalDescripcion.Enabled = False

            txt_cod_agencia_trans.Text = String.Empty
            txt_des_agencia_trans.Text = String.Empty
            txtDireccionTransportista.Text = String.Empty
            txtDireccionTransportistaDescripcion.Text = String.Empty
            txtDireccionCliente.Text = String.Empty
            txtDireccionEntregaCliente.Text = String.Empty


            txtLocalDescripcion.Text = String.Empty
            txtLocal.Text = String.Empty
            txtLocal.Enabled = True

            txt_cod_agencia_trans.BackColor = System.Drawing.Color.Aquamarine
            txtDireccionTransportistaDescripcion.BackColor = System.Drawing.Color.Aquamarine

            txtDireccionTransportista.BackColor = System.Drawing.Color.White
            txtDireccionCliente.BackColor = System.Drawing.Color.White
            txtDireccionEntregaCliente.BackColor = System.Drawing.Color.White

            txtLocal.BackColor = System.Drawing.Color.White
            txtLocalDescripcion.BackColor = System.Drawing.Color.White

        Else
            txt_cod_agencia_trans.BackColor = System.Drawing.Color.White
            txt_cod_agencia_trans.Enabled = False
            txt_cod_agencia_trans.Text = String.Empty

            txtDireccionTransportistaDescripcion.Text = String.Empty
            txtDireccionTransportistaDescripcion.BackColor = System.Drawing.Color.White
            txtDireccionTransportistaDescripcion.Enabled = False
        End If




    End Sub

    Private Sub rdb_opt_domicilio_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdb_opt_domicilio.CheckedChanged
        If rdb_opt_domicilio.Checked = True Then

            txt_cod_agencia_trans.Enabled = False
            txt_des_agencia_trans.Enabled = False
            txtDireccionTransportista.Enabled = False
            txtDireccionTransportistaDescripcion.Enabled = False

            txtDireccionCliente.Enabled = True
            txtDireccionEntregaCliente.Enabled = True

            txt_cod_agencia_trans.Text = String.Empty
            txt_des_agencia_trans.Text = String.Empty
            txtDireccionTransportista.Text = String.Empty
            txtDireccionTransportistaDescripcion.Text = String.Empty
            txtDireccionCliente.Text = String.Empty
            txtDireccionEntregaCliente.Text = String.Empty


            txtLocalDescripcion.Text = String.Empty
            txtLocal.Text = String.Empty
            txtLocal.Enabled = True

            txt_cod_agencia_trans.BackColor = System.Drawing.Color.White
            txtDireccionTransportista.BackColor = System.Drawing.Color.White

            txtDireccionCliente.BackColor = System.Drawing.Color.Aquamarine
            txtDireccionEntregaCliente.BackColor = System.Drawing.Color.Aquamarine

            txtLocal.BackColor = System.Drawing.Color.White
            txtLocalDescripcion.BackColor = System.Drawing.Color.White

        Else
            txtDireccionCliente.BackColor = System.Drawing.Color.White
            txtDireccionCliente.Enabled = False
            txtDireccionCliente.Text = String.Empty
            txtDireccionCliente.Text = String.Empty
        End If

    End Sub

    Private Sub txtDireccionTransportistaDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccionTransportistaDescripcion.TextChanged

    End Sub

    Private Sub dgvDocumentosFactura_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDocumentosFactura.SelectionChanged
        txtUserID.Text = String.Empty
        TxtFechaCreacion.Text = String.Empty

        If dgvDocumentosFactura.Rows.Count > 0 Then
            txtUserID.Text = dgvDocumentosFactura.CurrentRow.Cells("User_Id").Value
            TxtFechaCreacion.Text = dgvDocumentosFactura.CurrentRow.Cells("Create_date").Value
        End If
    End Sub

    Private Sub GrpLugarEntrega_Enter(sender As Object, e As EventArgs) Handles GrpLugarEntrega.Enter

    End Sub

    Private Sub txt_cod_provincia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_provincia.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_cod_provincia.Text = String.Empty
            Cargar_Provincia_direcc_entrega()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_provincia.Text = "" Then
                txt_cod_provincia.Text = String.Empty
                Cargar_Provincia_direcc_entrega()
            Else
                txt_cod_distrito.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cod_distrito_TextChanged(sender As Object, e As EventArgs) Handles txt_cod_distrito.TextChanged
        txt_ubigeo.Text = txt_cod_departamento.Text + txt_cod_provincia.Text + txt_cod_distrito.Text
    End Sub

    Private Sub txt_cod_distrito_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_distrito.MouseDoubleClick
        txt_cod_distrito.Text = String.Empty
        Cargar_Distrito_direc_entrega()
    End Sub

    Private Sub txt_cod_distrito_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_distrito.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_cod_distrito.Text = String.Empty
            Cargar_Distrito_direc_entrega()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_distrito.Text = "" Then
                txt_cod_distrito.Text = String.Empty
                Cargar_Distrito_direc_entrega()
            Else
                txt_cod_forma_pago.Focus()
            End If
        End If
    End Sub

    Private Sub txt_correo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_correo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_nuevo_cliente_Click(sender, e)
        End If
    End Sub

    Private Sub btn_grabar_nuevo_cliente_Click(sender As Object, e As EventArgs) Handles btn_grabar_nuevo_cliente.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If Len(Strings.Trim(txt_ruc_dni.Text)) = 11 Then
                cmb_tip_doc_per.SelectedValue = "6"
            ElseIf Len(Strings.Trim(txt_ruc_dni.Text)) = 8 Then
                cmb_tip_doc_per.SelectedValue = "1"
            Else
                'MsgBox("El Código de Cliente debe tener 11 o 8 caracteres.", MsgBoxStyle.Exclamation)
                'txt_ruc_dni.Focus()
                'Exit Sub
            End If

            If Consultando_Ruc() = False Then
                Me.Cursor = Cursors.Default
                MsgBox("El número del documento ingresado ya existe en la base de datos." & Chr(13) & " Ingrese uno correcto.", MsgBoxStyle.Critical, "Sistemas")
                txt_ruc_dni.Focus()
                Exit Sub
            End If

            If txt_cod_cliente.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("No se asigno el codigo del cliente.", MsgBoxStyle.Exclamation)
                txt_cod_cliente.Focus()
                Exit Sub
            ElseIf txt_ruc_dni.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe ingresar un número de RUC/DNI.", MsgBoxStyle.Exclamation)
                txt_ruc_dni.Focus()
                Exit Sub
            ElseIf txt_razon_social.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe ingresar la Razón Social del cliente.", MsgBoxStyle.Exclamation)
                txt_razon_social.Focus()
                Exit Sub
            ElseIf txt_direccion.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe ingresar la Dirección del cliente.", MsgBoxStyle.Exclamation)
                txt_direccion.Focus()
                Exit Sub
            ElseIf txt_cod_departamento.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe elegir un Departamento para el cliente.", MsgBoxStyle.Exclamation)
                txt_cod_departamento.Focus()
                Exit Sub
            ElseIf txt_cod_provincia.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe elegir un Provincia para el cliente.", MsgBoxStyle.Exclamation)
                txt_cod_provincia.Focus()
                Exit Sub
            ElseIf txt_cod_distrito.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe elegir un Distrito para el cliente.", MsgBoxStyle.Exclamation)
                txt_cod_distrito.Focus()
                Exit Sub

            ElseIf txt_cod_forma_pago.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe elegir una Forma de Pago para el cliente.", MsgBoxStyle.Exclamation)
                txt_cod_forma_pago.Focus()
                Exit Sub
            ElseIf txt_cod_vendedor.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe elegir un Vendedor para el cliente.", MsgBoxStyle.Exclamation)
                txt_cod_vendedor.Focus()
                Exit Sub
            End If

            If cmb_tip_doc_per.SelectedValue = "1" Then 'entonces es DNI
                If Len(Strings.Trim(txt_cod_cliente.Text)) <> 8 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El Código de Cliente debe tener 8 caracteres. ", MsgBoxStyle.Exclamation)
                    txt_cod_cliente.Focus()
                    Exit Sub
                ElseIf Len(Strings.Trim(txt_ruc_dni.Text)) <> 8 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El Número del Documento del Cliente debe tener 8 caracteres.", MsgBoxStyle.Exclamation)
                    txt_ruc_dni.Focus()
                    Exit Sub
                End If
            ElseIf cmb_tip_doc_per.SelectedValue = "0" Then
                If Len(Strings.Trim(txt_cod_cliente.Text)) <> 8 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El Código de Cliente debe tener de 8 a más caracteres. ", MsgBoxStyle.Exclamation)
                    txt_cod_cliente.Focus()
                    Exit Sub
                ElseIf Len(Strings.Trim(txt_ruc_dni.Text)) <> 8 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El Número del Documento del Cliente debe tener de 8 a más caracteres.", MsgBoxStyle.Exclamation)
                    txt_ruc_dni.Focus()
                    Exit Sub
                End If
            ElseIf cmb_tip_doc_per.SelectedValue = "6" Then 'entonces es RUC
                If Len(Strings.Trim(txt_cod_cliente.Text)) <> 11 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El Código de Cliente debe tener 11 caracteres. ", MsgBoxStyle.Exclamation)
                    txt_cod_cliente.Focus()
                    Exit Sub
                ElseIf Len(Strings.Trim(txt_ruc_dni.Text)) <> 11 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El Número del Documento del Cliente debe tener 11 caracteres.", MsgBoxStyle.Exclamation)
                    txt_ruc_dni.Focus()
                    Exit Sub
                End If
            End If

            Dim CONSULTA As String = String.Empty
            CONSULTA = "INSERT INTO dbo.CUSTOMER (ID, NAME, ADDR, PHONE, VAT_REGISTRATION, NUMBER_DOC, DISCOUNT_PERCENT, TERMS_TYPE, STATUS, OPEN_DATE, CONTACT, STATE_ID, CREATE_USER, CREATE_DATE, MODIFY_DATE, TYPE_PRICE, SALES_ID, SELL_ZONE, COUNTRY, " _
                    & "  DEPARTMENT, PROVINCE, ADDR_DLV, CURRENCY_CREDIT_LIMIT, CREDIT_LIMIT_US, CREDIT_LIMIT, BALANCE, BALANCE_US, OBSERV, TOTAL_LETTER, TOTAL_RECEIVABLE, TOTAL_CHECK, TOTAL_LETTER_PROTESTED, CUSTOMER_TYPE, BUSINESS_TYPE, TERRITORY, ROUTE, " _
                    & "  SEGMENT, SEGMENT_LOCATION, BANK_ID, ACCOUNT_NO, DATE_REVIEW, HOUR_VISIT, ATTENTION_TYPE, FAX_NUMBER, EMAIL, WEBSITE,COMMENT, IS_PRIMARY, RETENTION, DOCUMENT_TYPE_PERSON_ID, TYPE_COMPANY, ACCOUNT_LOCAL, ACCOUNT_EXTERNAL, NAME_COMERTIAL, " _
                    & " TYPE_DISCOUNT, FLAG_PRINCIPAL, IS_DEFAULT, AP_PATERNO, AP_MATERNO) " _
                    & " VALUES ('" & txt_cod_cliente.Text & "', '" & txt_razon_social.Text & "', '" & txt_direccion.Text & "', '" & txt_Celular.Text & "', '" & txt_ruc_dni.Text & "', '', 0, '" & txt_cod_forma_pago.Text & "', 'V', GETDATE(), '', '" & txt_cod_distrito.Text & "', '" & LibComunVar.ClsVarComun.USUARIO & "', " _
                    & " GETDATE(), GETDATE(), '', '" & txt_cod_vendedor.Text & "', '', '', '" & txt_cod_departamento.Text & "', '" & txt_cod_provincia.Text & "', '', '', 0, 0, 0, 0, '', 0, 0, 0, 0, '', '', '', '',  " _
                    & " '', '', '01', '', GETDATE(), '', '', '', '" & txt_correo.Text & "', '', '', '0', '0', '" & cmb_tip_doc_per.SelectedValue & "', '', '121201', '121201', '', '1', '1', 'N', " _
                    & " '','') "

            clsReceivablaBl = New ClsOperaciones.RECEIVABLE
            If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                Ayuda_Clientes(txt_cod_cliente.Text)
                btn_cancelar_nuevo_cliente_Click(sender, e)
                Me.Cursor = Cursors.Default
            Else
                Me.Cursor = Cursors.Default
                MsgBox("Cliente no se llego a registrar. Verifique!!!", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_nuevo_cliente_Click(sender As Object, e As EventArgs) Handles btn_cancelar_nuevo_cliente.Click
        panel_cliente_nuevo.Visible = False
        GbCabecera.Enabled = True
        gbdetalle.Enabled = True
        gbOpciones.Enabled = True
    End Sub

    Private Sub txt_ruc_dni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ruc_dni.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ruc_dni_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ruc_dni.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(Strings.Trim(txt_ruc_dni.Text)) = 11 Then
                cmb_tip_doc_per.SelectedValue = "6"
            ElseIf Len(Strings.Trim(txt_ruc_dni.Text)) = 8 Then
                cmb_tip_doc_per.SelectedValue = "1"
            Else
                MsgBox("El Código de Cliente debe tener 11 o 8 caracteres.", MsgBoxStyle.Exclamation)
                txt_ruc_dni.Focus()
                Exit Sub
            End If
            If Consultando_Ruc() Then
                txt_razon_social.Focus()
            End If
        End If
    End Sub

    Private Sub btn_cotizacion_Click(sender As Object, e As EventArgs) Handles btn_cotizacion.Click
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            _numero_cotizacion = ""
            sql = "QUOTE_SP_S_LISTA_I"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Cotizaciones"
            frm._Flag_Filtro = True
            frm.Filtros1 = CodigoVendedor
            frm.Filtros2 = tipo_Vendedor
            frm.Filtros3 = LibComunVar.ClsVarComun.AcesoVendedores
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                _numero_cotizacion = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
            If _numero_cotizacion <> "" Then
                Adjuntar_Cotizacion(_numero_cotizacion)
            End If
        Catch ex As Exception
            frm.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Adjuntar_Cotizacion(ByVal _numero_cotizacion As String)
        Try
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtCabeceraFact = New DataTable
            dtDetalleFact = New DataTable
            '---Mostrando Datos de Cabecera
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtCabeceraFact = clsPedidoBl.Adjunta_Cotizacion_Cabecera(_numero_cotizacion)

            If dtCabeceraFact.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraFact.Rows.Count() - 1
                    txtPtoVenta.Text = dtCabeceraFact.Rows(i).Item("PLACE_SALES").ToString
                    txtAlmacen.Text = dtCabeceraFact.Rows(i).Item("WAREHOUSE_ID").ToString
                    lblAlmacen.Text = dtCabeceraFact.Rows(i).Item("ALMACEN_NOMBRE").ToString
                    'dtpFechaFactura.Text = dtCabeceraFact.Rows(i).Item("ORDER_DATE").ToString
                    cboTipoDoc.Text = dtCabeceraFact.Rows(0).Item("TRAMA_ID").ToString
                    cboMoneda.SelectedValue = dtCabeceraFact.Rows(i).Item("CURRENCY_ID").ToString
                    txtTipoCambio.Text = dtCabeceraFact.Rows(i).Item("SELL_RATE").ToString
                    txtCod_Cliente.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRucDni.Text = dtCabeceraFact.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtRazonSocial.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtDireccion.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ADDR").ToString
                    txtVendedor.Text = dtCabeceraFact.Rows(i).Item("SALES_ID").ToString
                    lblVendedor.Text = dtCabeceraFact.Rows(i).Item("VENDEDOR").ToString
                    txtFormaPago.Text = dtCabeceraFact.Rows(i).Item("TERMS").ToString
                    lblFormaPago.Text = dtCabeceraFact.Rows(i).Item("FPAGO").ToString
                    txtcotizacion.Text = _numero_cotizacion
                    txtordenCompra.Text = dtCabeceraFact.Rows(i).Item("ORDER_PURCHASE").ToString
                    txtpedido.Text = ""
                    txtcodigo.Text = dtCabeceraFact.Rows(i).Item("ID").ToString
                    txt_validez_oferta.Text = dtCabeceraFact.Rows(i).Item("VALIDEZ_OFERTA").ToString

                    txtModoPago.Text = dtCabeceraFact.Rows(i).Item("MODO_PAGO").ToString
                    lblModoPago.Text = dtCabeceraFact.Rows(i).Item("MODO_PAGO_DESC").ToString

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

                    If dtCabeceraFact.Rows(i).Item("OPT_A_D").ToString = "Agencia" Then
                        rdb_opt_agencia.Checked = True
                        rdb_opt_domicilio.Checked = False
                    ElseIf dtCabeceraFact.Rows(i).Item("OPT_A_D").ToString = "Domicilio" Then
                        rdb_opt_agencia.Checked = False
                        rdb_opt_domicilio.Checked = True
                    Else
                        rdb_opt_agencia.Checked = False
                        rdb_opt_domicilio.Checked = False
                    End If

                    txt_lt_ft.Text = dtCabeceraFact.Rows(i).Item("LT_FT").ToString
                    If dtCabeceraFact.Rows(i).Item("CHEQUE").ToString = "SI" Then
                        chk_cheque.Checked = True
                    Else
                        chk_cheque.Checked = False
                    End If

                    If dtCabeceraFact.Rows(i).Item("GUIA_2").ToString = "" Then
                        chk_guia_2.Checked = False
                    Else
                        chk_guia_2.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("FACTURA_2").ToString = "" Then
                        chk_factura_2.Checked = False
                    Else
                        chk_factura_2.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("LETRA_2").ToString = "" Then
                        chk_letra_2.Checked = False
                    Else
                        chk_letra_2.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("TRANSFERENCIA_2").ToString = "" Then
                        chk_transferencia.Checked = False
                    Else
                        chk_transferencia.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("EFECTIVO_2").ToString = "" Then
                        chk_efectivo.Checked = False
                    Else
                        chk_efectivo.Checked = True
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
                dtdetalleArticuloPrincipal = clsPedidoBl.Adjunta_Cotizacion_Detalle(_numero_cotizacion)

                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal

                    dgvDetalle.Columns(0).HeaderText = "ITEM"
                    dgvDetalle.Columns(1).HeaderText = "CODIGO"
                    dgvDetalle.Columns(2).HeaderText = "CANTIDAD"
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

                    For i As Integer = 0 To dgvDetalle.Columns.Count - 1
                        dgvDetalle.Columns(i).ReadOnly = True
                    Next

                    'dgvDetalle.Columns("CANTIDAD").ReadOnly = False
                    'dgvDetalle.Columns("CANTIDAD_FRACCION").ReadOnly = False

                    dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("CANTIDAD_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                    dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Format = "##,##0.000000"
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Format = "##,##0.000000"
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

                    dgvDetalle.Columns("ITEM").Width = 25
                    dgvDetalle.Columns("CODIGO").Width = 100
                    dgvDetalle.Columns("DESCRIPCION").Width = 350
                    dgvDetalle.Columns("PRESENTACION").Width = 100
                    dgvDetalle.Columns("UNIDAD").Width = 45
                    dgvDetalle.Columns("LOTE").Width = 100
                    dgvDetalle.Columns("CANTIDAD").Width = 60
                    dgvDetalle.Columns("CANTIDAD_FRACCION").Width = 60
                    dgvDetalle.Columns("PRECIO_IGV").Width = 60
                    dgvDetalle.Columns("PRECIO_IGV_FRACCION").Width = 60
                    dgvDetalle.Columns("TOTAL").Width = 60

                    dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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

                    chkSinIGV.Checked = Not Precio_Con_Sin_IGV()
                    Calcular_Totales()

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

    Private Sub txt_cod_forma_pago_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_forma_pago.MouseDoubleClick
        Ayuda_FormaPago2()
    End Sub

    Private Sub txt_cod_forma_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_forma_pago.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_FormaPago2()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_forma_pago.Text = "" Then
                Ayuda_FormaPago2()
            Else
                txt_cod_vendedor.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_FormaPago2(Optional ByVal _codigoVendedor As String = "")
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
                    txt_cod_forma_pago.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txt_des_forma_pago.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txt_cod_vendedor.Focus()
                End If
                frm.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_vendedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_vendedor.MouseDoubleClick
        Ayuda_Vendedor2()
    End Sub

    Private Sub txt_cod_vendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_vendedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor2()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_vendedor.Text = "" Then
                Ayuda_Vendedor2()
            Else
                txt_correo.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Vendedor2(Optional ByVal _CodigoVendedor As String = "")
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
                    txt_cod_vendedor.Text = frm.Data_Matriz.Rows(0).Item(0)
                    txt_des_vendedor.Text = frm.Data_Matriz.Rows(0).Item(1)
                    txt_correo.Focus()
                End If
                frm.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOrdenCompra_Click(sender As Object, e As EventArgs) Handles btnOrdenCompra.Click
        Dim STRPedido As String = String.Empty

        If Modo_consultar = True Then
            STRPedido = dgvDocumentosFactura.CurrentRow.Cells("Numero").Value
        End If

        Try
            Dim frm As New frmOrdenCompra
            With frm
                .Titulo = "Orden de Compra"
                .NumeroPedido = STRPedido

                If pdfBytes Is Nothing Then
                    .txtRutaArchivo.Text = String.Empty
                    .txt_SerieNumero.Text = String.Empty
                Else
                    .txtRutaArchivo.Text = RutaOC
                    .txt_SerieNumero.Text = NumeroOC
                    .pdfBytes = pdfBytes
                End If


                If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    pdfBytes = .pdfBytes
                    NumeroOC = .txt_SerieNumero.Text.Trim
                    RutaOC = .txtRutaArchivo.Text.Trim
                    txtNumeroOrdenCompra.Text = .txt_SerieNumero.Text.Trim
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtDireccionEntregaCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtDireccionEntregaCliente.MouseDoubleClick
        Ayuda_DireccionCliente()
    End Sub

    Private Sub Ayuda_DireccionCliente()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "[ADDR_SP_S_CLIENTE_LISTA]"
        frm.CadenaConsulta = sql
        frm._Flag_Filtro = True
        frm.Filtros1 = txtCod_Cliente.Text
        frm.Titulo = "Direccion Cliente"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtDireccionCliente.Text = frm.Data_Matriz.Rows(0).Item("ITEM").ToString
            txtDireccionEntregaCliente.Text = frm.Data_Matriz.Rows(0).Item("DIRECCION").ToString + " " + frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString + "-" + frm.Data_Matriz.Rows(0).Item("PROVINCIA").ToString + "-" + frm.Data_Matriz.Rows(0).Item("DISTRITO").ToString

        End If
        frm.Close()
    End Sub

    Private Sub txtDireccionTransportistaDescripcion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtDireccionTransportistaDescripcion.MouseDoubleClick
        Ayuda_DireccionTransportista()
    End Sub

    Private Sub txtLocalDescripcion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtLocalDescripcion.MouseDoubleClick
        Ayuda_Local()
    End Sub

    Private Sub Ayuda_DireccionTransportista()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "[ADDR_SP_S_TRANSPORTISTAS_LISTA]"
        frm.CadenaConsulta = sql
        frm._Flag_Filtro = True
        frm.Filtros1 = txt_cod_agencia_trans.Text
        frm.Titulo = "Dirección Transportista"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtDireccionTransportista.Text = frm.Data_Matriz.Rows(0).Item("ITEM").ToString
            txtDireccionTransportistaDescripcion.Text = frm.Data_Matriz.Rows(0).Item("DIRECCION").ToString + " " + frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString + "-" + frm.Data_Matriz.Rows(0).Item("PROVINCIA").ToString + "-" + frm.Data_Matriz.Rows(0).Item("DISTRITO").ToString
            txt_provincia.Text = frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString + "-" + frm.Data_Matriz.Rows(0).Item("PROVINCIA").ToString + "-" + frm.Data_Matriz.Rows(0).Item("DISTRITO").ToString
        End If
        frm.Close()
    End Sub

    Private Sub Ayuda_Local()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "SAL_HLP_PTO_VENTA"
        frm.CadenaConsulta = sql
        frm._Flag_Filtro = True
        frm.Filtros1 = ""
        frm.Titulo = "Punto de Venta"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtLocal.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txtLocalDescripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString

        End If
        frm.Close()
    End Sub


End Class