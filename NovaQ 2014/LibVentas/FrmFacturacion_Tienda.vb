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

Public Class FrmFacturacion_Tienda

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

    Dim cabeceraBE_rb As LibCobranzas.ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS
    Dim detalleBE_rb As LibCobranzas.ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE
    Dim ls_det_rb As List(Of LibCobranzas.ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE)


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
    Dim num_operacion_visa As String, num_operacion_master As String, num_operacion_diners As String, num_operacion_american As String, modo_pago As String, forma_pago As String
    Dim Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, ref_fecha_doc, Ref_ALMACEN As String
    Dim Ref_DATE_DOC As Date
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
    Dim _GENERA_IMPRESION_DIRECTA As String
    Dim Nom_Impresora_Ticket As String
    Dim NUMERO_IMPRESIONES As Integer
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
    Dim ID_COMUNICACION_BAJA_CDR As String
    Protected dtHelp As New DataTable
    Dim dtAccesoVendedor As DataTable
    Dim clsVendedorBl As ClsTransacciones.clsVendedores
    Dim flag_inicio As Boolean


    Private Sub FrmFacturacion_Tienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        flag_inicio = False
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

        cboOpcionTipoDoc.SelectedIndex = 0
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        Botonera_Estado_Cambiar(False)
        Call Cargar_Moneda()
        txtFiltro.Select()
        flag_inicio = True
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



    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnImprimir.Enabled = False
            If Modo_consultar = True Then
                btnGrabar.Enabled = False
                'btnImprimir.Enabled = True
            Else
                'btnImprimir.Enabled = False
                btnGrabar.Enabled = True
            End If
            If Modo_editar = True Then btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnAnular.Enabled = False
            btnConsultar.Enabled = False
            'btn_modificar.Enabled = False
            btnCancelar.Enabled = True
            'btnImprimir.Enabled = False
            lblCantidad.Visible = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnAnular.Enabled = True
            btnConsultar.Enabled = True
            'btn_modificar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
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
            dgvDetalle.Columns(7).HeaderText = "%.DESC"
            dgvDetalle.Columns(8).Visible = False '.HeaderText = "%.Desc.Articulo.2"
            dgvDetalle.Columns(15).Visible = False '.HeaderText = "TOTAL"
            dgvDetalle.Columns(39).HeaderText = "TOTAL"
            dgvDetalle.Columns(36).Visible = False
            dgvDetalle.Columns(10).HeaderText = "MONTO DESC."
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
            dgvDetalle.Columns(23).HeaderText = "OBSERVACIONES"

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
            dgvDetalle.Columns("PRECIO_IGV").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns("PRECIO_IGV_FRACCION").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns("%DESC.ART_1").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns("%DESC.ART_2").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns("TOTAL").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns("IMP_DESC_01").DefaultCellStyle.Format = "##,##0.00"
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
            dgvDetalle.Columns("%DESC.ART_1").DisplayIndex = 9
            dgvDetalle.Columns("IMP_DESC_01").DisplayIndex = 10
            dgvDetalle.Columns("TOTAL").DisplayIndex = 11
            dgvDetalle.Columns("LOTE").DisplayIndex = 12
            dgvDetalle.Columns("OBSERVACIONES").DisplayIndex = 13

            dgvDetalle.Columns("ITEM").Width = 25
            dgvDetalle.Columns("CODIGO").Width = 60
            dgvDetalle.Columns("DESCRIPCION").Width = 350
            dgvDetalle.Columns("PRESENTACION").Width = 100
            dgvDetalle.Columns("UNIDAD").Width = 45
            dgvDetalle.Columns("LOTE").Width = 100
            dgvDetalle.Columns("CANTIDAD").Width = 60
            dgvDetalle.Columns("CANTIDAD_FRACCION").Width = 60
            dgvDetalle.Columns("PRECIO_IGV").Width = 60
            dgvDetalle.Columns("PRECIO_IGV_FRACCION").Width = 60
            dgvDetalle.Columns("%DESC.ART_1").Width = 60
            dgvDetalle.Columns("IMP_DESC_01").Width = 60
            dgvDetalle.Columns("TOTAL").Width = 60
            dgvDetalle.Columns("OBSERVACIONES").Width = 250

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
            dgvDetalle.Columns("%DESC.ART_1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle.Columns("IMP_DESC_01").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

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
                'cboTipoDoc.Text = "PF"
                rdb_f_ticket.Checked = True
                chk_facturar_obsequio.Checked = False
                dgv_lista_productos.DataSource = Nothing
                txt_buscador_productos.Focus()
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
            Button2.Visible = True
            txt_buscador_productos.Focus()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function MostrarModoConsultar(ByVal DOCUMENT_ID As String, ByVal NUMBER_SERIE As String, ByVal NUMBER_DOCUMENT As String) As Boolean
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
            dtCabeceraFact = clsPedidoBl.Modo_Facturacion_Edicion_Cabecera(DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT)

            If dtCabeceraFact.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraFact.Rows.Count() - 1
                    txtPtoVenta.Text = dtCabeceraFact.Rows(i).Item("PLACE_SALES").ToString
                    Ayuda_PuntoVenta(txtPtoVenta.Text)
                    txtAlmacen.Text = dtCabeceraFact.Rows(i).Item("WAREHOUSE_ID").ToString
                    lblAlmacen.Text = dtCabeceraFact.Rows(i).Item("NOMBRE_ALMACEN").ToString
                    dtpFechaFactura.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_DATE").ToString
                    cboTipoDoc.Text = dtCabeceraFact.Rows(0).Item("DOCUMENT_ID").ToString
                    SerieDocumentoPuntoVenta()
                    cboSerieDoc.Text = dtCabeceraFact.Rows(i).Item("NUMBER_SERIE").ToString
                    cboMoneda.SelectedValue = dtCabeceraFact.Rows(i).Item("CURRENCY_ID").ToString
                    txtTipoCambio.Text = dtCabeceraFact.Rows(i).Item("SELL_RATE").ToString
                    txtCodCliente.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRucDni.Text = dtCabeceraFact.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtRazonSocial.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtDireccion.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ADDR").ToString
                    txtVendedor.Text = dtCabeceraFact.Rows(i).Item("SALES_REP_ID").ToString
                    txtFormaPago.Text = dtCabeceraFact.Rows(i).Item("TERMS_ID").ToString
                    txtcotizacion.Text = ""
                    txtordenCompra.Text = dtCabeceraFact.Rows(i).Item("NUMBER_ORDER_PUR").ToString
                    txtpedido.Text = ""
                    txtcodigo.Text = dtCabeceraFact.Rows(i).Item("NUMBER_DOCUMENT").ToString

                    'txtModoPago.Text = dtCabeceraFact.Rows(i).Item("CODIGO_MODO_PAGO").ToString
                    'lblModoPago.Text = dtCabeceraFact.Rows(i).Item("NOMBRE_MODO_PAGO").ToString
                Next

                '---Mostrando datos del Detalle
                clsPedidoBl = New ClsOperaciones.ORDERS
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsPedidoBl.Modo_Facturacion_Edicion_Detalle(DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT)

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
                    dgvDetalle.Columns("CODIGO").Width = 60
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

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvDocumentosFactura.RowCount() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Modo_consultar = True
            Modo_editar = False
            Ref_DOCUMENT_ID = String.Empty
            Ref_NUMBER_SERIE = String.Empty
            Ref_NUMBER_DOCUMENT = String.Empty
            Ref_DATE_DOC = Date.Now
            If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, Ref_DATE_DOC) = False Then Exit Sub

            If MostrarModoConsultar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) Then
                pnlPrincipal.Visible = False
                GbCabecera.Enabled = False
                gbdetalle.Enabled = True
                'gbOpciones.Enabled = False
                GbdetalleDocumento.Visible = True
                Call Botonera_Estado_Cambiar(True)
                Button2.Visible = False
                txt_buscador_productos.Focus()
            End If

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
        Try
            Dim frmTipoNum As New FrmTipoNumeracion
            frmTipoNum.Serie = cboSerieDoc.Text
            frmTipoNum.TipoDocumento = cboTipoDoc.Text
            frmTipoNum.Almacen = txtAlmacen.Text
            frmTipoNum.txtTitulo.Text = cboTipoDoc.Text
            frmTipoNum.monto_ventas = CDbl(txtPrecioVenta.Text)
            frmTipoNum.Vuelto = 0
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
            modo_pago = ""
            forma_pago = ""

            TipoNumeracion = String.Empty
            NumeracionFacturacion = frmTipoNum.NumeracionGeneral
            TipoNumeracion = frmTipoNum.TipoNumeracion
            vuelto = frmTipoNum.Vuelto
            Tipo_cancelacion = frmTipoNum.TipoCanelacion
            modo_pago = frmTipoNum.modo_pago
            forma_pago = frmTipoNum.forma_pago

            monto_soles = frmTipoNum.monto_soles
            monto_dolares = frmTipoNum.monto_dolares
            monto_visa = frmTipoNum.monto_visa
            monto_mastercard = frmTipoNum.monto_mastercard
            monto_american_expres = frmTipoNum.monto_american_expres
            monto_diners_club = frmTipoNum.monto_diners_club

            num_operacion_visa = frmTipoNum.num_operacion_visa
            num_operacion_master = frmTipoNum.num_operacion_mastercard
            num_operacion_diners = frmTipoNum.num_operacion_diners
            num_operacion_american = frmTipoNum.num_operacion_american

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
                .NUM_GUIA_REF_DEVOLUCION = ""
                .DOCUMENT_DATE = dtpFechaFactura.Value.ToString("dd/MM/yyyy")
                .CADUCATE_DATE = Get_FormaPagoFechaVencimiento()
                .DR_CR = "T"
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
                .RECEIVABLE_TYPE = IIf(chk_facturar_obsequio.Checked, "FO", cboTipoDoc.Text)
                .CUSTOMER_ID = txtCodCliente.Text.Trim
                .CUSTOMER_NAME = txtRazonSocial.Text.Trim
                .CUSTOMER_ADDR = txtDireccion.Text.Trim
                .VAT_REGISTRATION = txtRucDni.Text.Trim
                .WAREHOUSE_ID = txtAlmacen.Text
                .AMOUNT = txtPrecioVenta.Text
                .TERMS_ID = forma_pago
                .MODO_PAGO = modo_pago
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
                    If cboTipoDoc.Text = "NC" Or cboTipoDoc.Text = "ND" Then
                        .DOCUMENT_REF = txttipoDocRef.Text
                        .SERIE_REF = txtSerieDocRef.Text
                        .FECHA_REFERENCIA = ""
                        If rbFacturaGuiaVenta.Checked Or rbFacturaRepMedico.Checked Then
                            .NUMBER_REF = "GUIAS"
                        Else
                            .NUMBER_REF = txtNumDocRef.Text
                        End If
                    Else
                        .DOCUMENT_REF = ""
                        .SERIE_REF = ""
                        .NUMBER_REF = ""
                        .FECHA_REFERENCIA = ""
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
                If checkSinGuia.Checked = True Then
                    .IS_GUIA = 0
                Else
                    .IS_GUIA = 1
                End If
                .IS_CASH_BANK = 0
                .TAX_TYPE = 0
                .REC_AUTO = ""
                .TRAMA_ID = txt_trama.Text
                .VEHICULO_ID = txt_vehiculo.Text
                .EMPTRA_ID = txt_Empresa.Text
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
                For Each Control As Control In gbTipoFacturacion.Controls
                    If TypeOf Control Is RadioButton Then
                        If CType(Control, RadioButton).Checked = True Then
                            .MOV_OPTION_ID = CType(Control, RadioButton).Text
                            Exit For
                        End If
                    End If
                Next
                .NUM_LICITACION = ""
                .FECHA_TRASLADO = dtpFechaFactura.Value.ToString("dd/MM/yyyy")

                .TIPO_NOTA_ELECTRONICA = ""
                .DESCRIPCION_TIPO_NOTA_ELECTRONICA = ""
                .EMAIL_CLIENTE = "" 'txt_email_cliente.Text.Trim

                .TIPO_CANCELACION = Tipo_cancelacion
                .VUELTO = vuelto
                .MONTO_SOLES = monto_soles
                .MONTO_DOLARES = monto_dolares
                .MONTO_VISA = monto_visa
                .MONTO_MASTERCARD = monto_mastercard
                .MONTO_AMERICAN = monto_american_expres
                .MONTO_DINERS = monto_diners_club

            End With
            'Detalle de Factura
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                detalle = New ClsEntidades.RECEIVABLE_LINE
                With detalle
                    .DOCUMENT_ID = cboTipoDoc.Text
                    .NUMBER_SERIE = cboSerieDoc.Text
                    .NUMBER_DOCUMENT = NumeracionFacturacion
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
                    .TIPOISC = 0
                    .ISCPOR = 0
                    If Flag_ComprobPerc = True Then
                        .ISC = CDbl(PorcentajePercepcion)
                    Else
                        .ISC = 0
                    End If
                    If rb_facturar_devolucion.Checked Then
                        .ITEM_INI = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_INI")
                    Else
                        .ITEM_INI = ""
                    End If

                    .OBSERVACIONES = dtdetalleArticuloPrincipal.Rows(i).Item("OBSERVACIONES")
                    .ITEM_GUIA_VENTA = 0
                    .NUM_GUIA_VENTA = ""
                    'If IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_GUIA_VENTA")) Then
                    '    .ITEM_GUIA_VENTA = 0
                    'Else
                    '    .ITEM_GUIA_VENTA = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_GUIA_VENTA")
                    'End If

                    'If IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("NUM_GUIA_VENTA")) Then
                    '    .NUM_GUIA_VENTA = ""
                    'Else
                    '    .NUM_GUIA_VENTA = dtdetalleArticuloPrincipal.Rows(i).Item("NUM_GUIA_VENTA")
                    'End If

                End With
                ls_det.Add(detalle)
            Next
            'CLIENTES
            If chk_facturar_obsequio.Checked = False Then
                With carteraBE
                    .CUSTOMER_ID = txtCodCliente.Text.Trim
                    .DOCUMENT_ID = cboTipoDoc.Text
                    .NUMBER_DOC = NumeracionFacturacion
                    .DOC_DATE = CDate(dtpFechaFactura.Text).ToString("dd/MM/yyyy")
                    .CADUCATE_DATE = Get_FormaPagoFechaVencimiento()
                    .DOCUMENT_REF = txttipoDocRef.Text
                    If rbFacturaDirecta.Checked = True Or chk_facturar_obsequio.Checked = True Then
                        .NUMBER_REF = txtSerieDocRef.Text & txtNumDocRef.Text
                    Else
                        .NUMBER_REF = txtNumDocRef.Text
                    End If
                    .SALES_ID = txtVendedor.Text.Trim
                    .AMOUNT = Math.Round(CDbl(txtPrecioVenta.Text), 2)
                    .AMOUNT_BALANCE = .AMOUNT
                    .CURRENCY_ID = cboMoneda.SelectedValue
                    .SELL_RATE = Math.Round(CDbl(txtTipoCambio.Text), 3)
                    .IS_DR_CR = 0
                    .STATUS = "V"
                    .CREATE_DATE = Date.Now.ToShortDateString
                    .LAST_MODIFIED = Date.Now.ToShortDateString
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .ACCOUNT = ""
                    .AMOUNT_COMM = 0
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

            'If Tipo_cancelacion <> "Credito" Then

            '    If monto_soles > 0 Then
            '        planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
            '        With planilladetBE
            '            .ID = ""
            '            .ITEM = 0
            '            .TYPE_DOC = cboTipoDoc.Text
            '            .NUMBER_DOC = NumeracionFacturacion
            '            .TYPE_OPERATION = "F"
            '            .REC_ID = "17"
            '            .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
            '            .AMOUNT = monto_soles
            '            .CURRENCY_ID = "MN"
            '            .SELL_RATE = CDbl(txtTipoCambio.Text)
            '            .CREATE_DATE = Now.Date.ToShortDateString
            '            .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '            .COMMENT = ""
            '            .SALES_ID = txtVendedor.Text.Trim
            '            .BANK_ID = ""
            '            .BANK_DESCRIPTION = ""
            '            .DOC_REF = cboTipoDoc.Text
            '            .NUM_REF = NumeracionFacturacion
            '            .BANK_BUSSINESS_ID = ""
            '            .ACCOUNT_BANK_CHECK = ""
            '            .LIST_ID = 0
            '            .IS_CASH_BANK = "0"
            '            .AMOUNT_PER = 0
            '            .PAY_AUTO = 0
            '            .ANNEX_ID_AUX = txtCodCliente.Text.Trim
            '            .DOCUMET_ID = cboTipoDoc.Text
            '            .NUMBER_SERIE = cboSerieDoc.Text
            '            .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
            '            .MEDIOS_PAGO = 0
            '            .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
            '        End With
            '        ls_detalle.Add(planilladetBE)
            '    End If

            '    If monto_dolares > 0 Then
            '        planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
            '        With planilladetBE
            '            .ID = ""
            '            .ITEM = 0
            '            .TYPE_DOC = cboTipoDoc.Text
            '            .NUMBER_DOC = NumeracionFacturacion
            '            .TYPE_OPERATION = "F"
            '            .REC_ID = "25"
            '            .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
            '            .AMOUNT = monto_dolares
            '            .CURRENCY_ID = "ME"
            '            .SELL_RATE = CDbl(txtTipoCambio.Text)
            '            .CREATE_DATE = Now.Date.ToShortDateString
            '            .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '            .COMMENT = ""
            '            .SALES_ID = txtVendedor.Text.Trim
            '            .BANK_ID = ""
            '            .BANK_DESCRIPTION = ""
            '            .DOC_REF = cboTipoDoc.Text
            '            .NUM_REF = NumeracionFacturacion
            '            .BANK_BUSSINESS_ID = ""
            '            .ACCOUNT_BANK_CHECK = ""
            '            .LIST_ID = 0
            '            .IS_CASH_BANK = "0"
            '            .AMOUNT_PER = 0
            '            .PAY_AUTO = 0
            '            .ANNEX_ID_AUX = txtCodCliente.Text.Trim
            '            .DOCUMET_ID = cboTipoDoc.Text
            '            .NUMBER_SERIE = cboSerieDoc.Text
            '            .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
            '            .MEDIOS_PAGO = 0
            '            .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
            '        End With
            '        ls_detalle.Add(planilladetBE)
            '    End If

            '    If monto_visa > 0 Then
            '        planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
            '        With planilladetBE
            '            .ID = ""
            '            .ITEM = 0
            '            .TYPE_DOC = cboTipoDoc.Text
            '            .NUMBER_DOC = NumeracionFacturacion
            '            .TYPE_OPERATION = "F"
            '            .REC_ID = "96"
            '            .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
            '            .AMOUNT = monto_visa
            '            .CURRENCY_ID = "MN"
            '            .SELL_RATE = CDbl(txtTipoCambio.Text)
            '            .CREATE_DATE = Now.Date.ToShortDateString
            '            .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '            .COMMENT = ""
            '            .SALES_ID = txtVendedor.Text.Trim

            '            .BANK_ID = ""
            '            .BANK_DESCRIPTION = ""
            '            .DOC_REF = "TB"
            '            .NUM_REF = num_operacion_visa
            '            .BANK_BUSSINESS_ID = ""
            '            .ACCOUNT_BANK_CHECK = ""

            '            .LIST_ID = 0
            '            .IS_CASH_BANK = "0"
            '            .AMOUNT_PER = 0
            '            .PAY_AUTO = 0
            '            .ANNEX_ID_AUX = txtCodCliente.Text.Trim
            '            .DOCUMET_ID = cboTipoDoc.Text
            '            .NUMBER_SERIE = cboSerieDoc.Text
            '            .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
            '            .MEDIOS_PAGO = 0
            '            .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
            '        End With
            '        ls_detalle.Add(planilladetBE)
            '    End If

            '    If monto_mastercard > 0 Then
            '        planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
            '        With planilladetBE
            '            .ID = ""
            '            .ITEM = 0
            '            .TYPE_DOC = cboTipoDoc.Text
            '            .NUMBER_DOC = NumeracionFacturacion
            '            .TYPE_OPERATION = "F"
            '            .REC_ID = "97"
            '            .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
            '            .AMOUNT = monto_mastercard
            '            .CURRENCY_ID = "MN"
            '            .SELL_RATE = CDbl(txtTipoCambio.Text)
            '            .CREATE_DATE = Now.Date.ToShortDateString
            '            .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '            .COMMENT = ""
            '            .SALES_ID = txtVendedor.Text.Trim

            '            .BANK_ID = ""
            '            .BANK_DESCRIPTION = ""
            '            .DOC_REF = "TB"
            '            .NUM_REF = num_operacion_master
            '            .BANK_BUSSINESS_ID = ""
            '            .ACCOUNT_BANK_CHECK = ""

            '            .LIST_ID = 0
            '            .IS_CASH_BANK = "0"
            '            .AMOUNT_PER = 0
            '            .PAY_AUTO = 0
            '            .ANNEX_ID_AUX = txtCodCliente.Text.Trim
            '            .DOCUMET_ID = cboTipoDoc.Text
            '            .NUMBER_SERIE = cboSerieDoc.Text
            '            .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
            '            .MEDIOS_PAGO = 0
            '            .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
            '        End With
            '        ls_detalle.Add(planilladetBE)
            '    End If

            '    If monto_diners_club > 0 Then
            '        planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
            '        With planilladetBE
            '            .ID = ""
            '            .ITEM = 0
            '            .TYPE_DOC = cboTipoDoc.Text
            '            .NUMBER_DOC = NumeracionFacturacion
            '            .TYPE_OPERATION = "F"
            '            .REC_ID = "98"
            '            .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
            '            .AMOUNT = monto_diners_club
            '            .CURRENCY_ID = "MN"
            '            .SELL_RATE = CDbl(txtTipoCambio.Text)
            '            .CREATE_DATE = Now.Date.ToShortDateString
            '            .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '            .COMMENT = ""
            '            .SALES_ID = txtVendedor.Text.Trim
            '            .BANK_ID = ""
            '            .BANK_DESCRIPTION = ""
            '            .DOC_REF = "TB"
            '            .NUM_REF = num_operacion_diners
            '            .BANK_BUSSINESS_ID = ""
            '            .ACCOUNT_BANK_CHECK = ""

            '            .LIST_ID = 0
            '            .IS_CASH_BANK = "0"
            '            .AMOUNT_PER = 0
            '            .PAY_AUTO = 0
            '            .ANNEX_ID_AUX = txtCodCliente.Text.Trim
            '            .DOCUMET_ID = cboTipoDoc.Text
            '            .NUMBER_SERIE = cboSerieDoc.Text
            '            .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
            '            .MEDIOS_PAGO = 0
            '            .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
            '        End With
            '        ls_detalle.Add(planilladetBE)
            '    End If

            '    If monto_american_expres > 0 Then
            '        planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
            '        With planilladetBE
            '            .ID = ""
            '            .ITEM = 0
            '            .TYPE_DOC = cboTipoDoc.Text
            '            .NUMBER_DOC = NumeracionFacturacion
            '            .TYPE_OPERATION = "F"
            '            .REC_ID = "99"
            '            .DATE_PLA = CDate(dtpFechaFactura.Text).ToShortDateString
            '            .AMOUNT = monto_american_expres
            '            .CURRENCY_ID = "MN"
            '            .SELL_RATE = CDbl(txtTipoCambio.Text)
            '            .CREATE_DATE = Now.Date.ToShortDateString
            '            .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '            .COMMENT = ""
            '            .SALES_ID = txtVendedor.Text.Trim
            '            .BANK_ID = ""
            '            .BANK_DESCRIPTION = ""
            '            .DOC_REF = "TB"
            '            .NUM_REF = num_operacion_american
            '            .BANK_BUSSINESS_ID = ""
            '            .ACCOUNT_BANK_CHECK = ""
            '            .LIST_ID = 0
            '            .IS_CASH_BANK = "0"
            '            .AMOUNT_PER = 0
            '            .PAY_AUTO = 0
            '            .ANNEX_ID_AUX = txtCodCliente.Text.Trim
            '            .DOCUMET_ID = cboTipoDoc.Text
            '            .NUMBER_SERIE = cboSerieDoc.Text
            '            .NUMBER_DOCUMENT = Strings.Right(NumeracionFacturacion, 7)
            '            .MEDIOS_PAGO = 0
            '            .DATE_REF = CDate(dtpFechaFactura.Text).ToShortDateString
            '        End With
            '        ls_detalle.Add(planilladetBE)
            '    End If
            'End If

            If rbFacturaDirecta.Checked = True Or rbFacturaExistencias.Checked = True Or rb_facturar_pedido.Checked = True Or chk_facturar_obsequio.Checked = True Then
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
                    .TRANS_ID = IIf(chk_facturar_obsequio.Checked, "FO", "FT")
                    .DATE_DOCUMENT = CDate(dtpFechaFactura.Value).ToShortDateString
                    .DOC_ID_REF = txttipoDocRef.Text
                    If rbFacturaDirecta.Checked = True Or chk_facturar_obsequio.Checked = True Then
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
                    .NUMBER_PURCHASE = txtordenCompra.Text
                    .INTERFACEE = 0
                    .FECHA_TRASLADO = dtpFechaFactura.Value.ToString("dd/MM/yyyy")
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
                        .OBSERVACIONES = dtdetalleArticuloPrincipal.Rows(i).Item("OBSERVACIONES").ToString
                    End With
                    ls_det_alm.Add(alm_detBE)
                Next
            End If

            ''GUARDANDO DATOS DE LA FACTURACION
            If cabeceraBL.GuardarFactura(cabeceraBE, ls_det, carteraBE, alm_cabBE, ls_det_alm, ls_detalle, cabeceraBE.CURRENCY_ID, CDate(dtpFechaFactura.Value).ToShortDateString,
                                         TipoNumeracion, cboTipoDoc.Text,
                                         IIf(rbFacturaGuiaVenta.Checked = True Or rbFacturaRepMedico.Checked = True, True, False),
                                         NumerosDocClientes, IIf(rbsinDescargo.Checked = True, True, False), IIf(rb_facturar_pedido.Checked = True, True, False),
                                         IIf(Modo_editar = True, True, False), Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, Ref_ALMACEN,
                                         IIf(rb_facturar_devolucion.Checked = True, True, False), TIPO_DEV, NUM_DEV) = False Then
                MsgBox("Hubo un Error en la Generacion de la Factura", MsgBoxStyle.Critical)
                indicadorF = False
                Exit Try
            End If

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
        txtdescuento1.Text = String.Empty
        txtStock.Text = String.Empty
        vuelto = 0
        chk_facturar_obsequio.Checked = False
        txt_buscador_especial.Text = ""
        txt_buscador_especial.Visible = True
        txt_buscador_productos.Text = ""
        txt_numero_lote.Text = ""
        txt_observaciones.Text = ""
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


    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles Button2.Click, btnGrabar.Click
        Try

            'Validaciones Generales
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            If ValidacionesGenerales() = False Then Me.Cursor = Cursors.Default : Exit Sub
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                If rb_facturar_pedido.Checked Then
                    For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                        If String.IsNullOrEmpty(dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString) Then
                            'MessageBox.Show("Falta ingresar el lote a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Exit Sub
                        ElseIf dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO") = 0 Then
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("Falta ingresar el Precio a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Next
                Else
                    For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                        If dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO") = 0 Then
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("Falta ingresar el Precio a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Next
                End If
            End If

            If CodigoNumeraciondocumentoGeneral() = False Then
                Me.Cursor = Cursors.Default
                MsgBox("Es necesario una Numeración para el documento a emitir.", MsgBoxStyle.Information)
                Exit Sub
            End If

            _GENERA_COMP_PER = ""
            _GENERA_DETRACCION = ""
            _GENERA_FACTURA_ELECTRONICA = ""
            _GENERA_IMPRESION_DIRECTA = ""
            Nom_Impresora_Ticket = ""
            NUMERO_IMPRESIONES = 0

            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtValidacion = New DataTable("Validacion")
            dtValidacion = clsFacturaBl.Get_Validacion(cboTipoDoc.Text, cboSerieDoc.Text)
            If dtValidacion.Rows.Count > 0 Then
                _GENERA_COMP_PER = dtValidacion.Rows(0).Item("IS_GENERA_COMP_PER").ToString
                _GENERA_DETRACCION = dtValidacion.Rows(0).Item("IS_GENERA_DETRACCION").ToString
                _GENERA_FACTURA_ELECTRONICA = dtValidacion.Rows(0).Item("IS_FACTUR_ELECTRONICO").ToString
                _GENERA_IMPRESION_DIRECTA = dtValidacion.Rows(0).Item("IS_PRINT_AUTOMATIC").ToString
                Nom_Impresora_Ticket = dtValidacion.Rows(0).Item("IMPRESORA").ToString
                NUMERO_IMPRESIONES = dtValidacion.Rows(0).Item("NUMERO_IMPRESIONES").ToString
            End If
            If _GENERA_COMP_PER = "S" Then
                '---Comprbante de Percepcion
                If MessageBox.Show("¿Desea Generar Comprobante de Percepcion.?", "Comprobante Percepcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    PorcentajePercepcion = String.Empty
                    PorcentajePercepcion = InputBox("Introduzca el porcentaje del Comprobante de Percepcion.", "Dato de Porcentaje de Percepcion")
                    While PorcentajePercepcion = "" Or PorcentajePercepcion <> ""
                        If IsNumeric(PorcentajePercepcion) = False Then
                            Me.Cursor = Cursors.Default
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
                            Me.Cursor = Cursors.Default
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
            End If
            If _GENERA_DETRACCION = "S" Then
                '-------Detraccion 
                If MessageBox.Show("¿Documento Sujeto a Detraccion.?", "Detraccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    PorcentajeDetraccion = String.Empty
                    PorcentajeDetraccion = InputBox("Introduzca el porcentaje de la Detraccion.", "Dato de Porcentaje de la Detraccion")
                    While PorcentajeDetraccion = "" Or PorcentajeDetraccion <> ""
                        If IsNumeric(PorcentajeDetraccion) = False Then
                            Me.Cursor = Cursors.Default
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
            End If
            'Me.Cursor = Cursors.WaitCursor
            If _GENERA_FACTURA_ELECTRONICA = "N" Then
                ToolStrip1.Enabled = False
                If GuardarFacturacion() = True Then

                    Dim msj As String = ""
                    msj = "Documento Generado Correctamente," & vbCrLf & "Nro Documento: " & cboTipoDoc.Text & " - " & NumeracionFacturacion
                    'MsgBox(msj, MsgBoxStyle.Information)

                    If MessageBox.Show(msj & vbCrLf & "Se procedera a la impresión del documento" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        imprimirFacturacion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturacion, cboMoneda.SelectedValue.ToString, txtIgv.Text, txtPrecioVenta.Text)
                    End If

                    'DocumentosFactura()
                    ToolStrip1.Enabled = True
                    Flag_Verificar = True
                    Nuevo()
                    Flag_Verificar = False
                    NuevaVenta()
                    txt_buscador_productos.Focus()
                    Me.Cursor = Cursors.Default
                End If
            ElseIf _GENERA_FACTURA_ELECTRONICA = "S" Then
                Dim StrNomArchivo_XML As String = ""
                Dim StrNomArchivo_PDF As String = ""
                ToolStrip1.Enabled = False
                If GuardarFacturacion() = True Then

                    Dim STRmontotexto As String = ""
                    If cboMoneda.SelectedValue = "MN" Then
                        If chk_facturar_obsequio.Checked Then
                            STRmontotexto = UCase(NUMEROLETRAS(0)) & " Soles"
                        Else
                            STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(txtPrecioVenta.Text)))) & " Soles"
                        End If
                    Else
                        If chk_facturar_obsequio.Checked Then
                            STRmontotexto = UCase(NUMEROLETRAS(0)) & " Dólares Americanos"
                        Else
                            STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(txtPrecioVenta.Text)))) & " Dólares Americanos"
                        End If
                    End If
                    Dim _existe_pdf As Boolean = False

                    '***************************
                    If Generar_XML_Factura_Guia(cboTipoDoc.Text, cboSerieDoc.Text, Strings.Right(NumeracionFacturacion, 7), STRmontotexto, "SI", IIf(rdb_f_ticket.Checked, "1", "2")) = False Then
                        MsgBox("El documento " & cboTipoDoc.Text & " -  " & cboSerieDoc.Text & Strings.Right(NumeracionFacturacion, 7) & " no genero el archivo XML ubl 2.1." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                        ToolStrip1.Enabled = True
                        Flag_Verificar = True
                        Nuevo()
                        Flag_Verificar = False
                        NuevaVenta()
                        txt_buscador_productos.Focus()
                        Me.Cursor = Cursors.Default
                    Else

                        StrNomArchivo_XML = Ruta_FE() & "\InputXML" & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(cboTipoDoc.Text = "FT", "01", IIf(cboTipoDoc.Text = "BV", "03",
                                            IIf(cboTipoDoc.Text = "NC", "07", IIf(cboTipoDoc.Text = "ND", "08", "")))) & "-" & cboSerieDoc.Text & "-" &
                                            Format(CInt(Strings.Right(NumeracionFacturacion, 7)), "00000000") & ".xml"

                        Dim oProcesaArchivo As New ProcesaArchivo
                        Dim strMensaje As String = ""

                        If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                            MsgBox(strMensaje, MsgBoxStyle.Critical)
                            ToolStrip1.Enabled = True
                            Flag_Verificar = True
                            Nuevo()
                            Flag_Verificar = False
                            NuevaVenta()
                            txt_buscador_productos.Focus()
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        End If

                        System.Threading.Thread.Sleep(3000)

                        StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                    dtpFechaFactura.Value.Year.ToString & "\" & Format(dtpFechaFactura.Value.Month, "00") & "\" &
                                                    Format(dtpFechaFactura.Value.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(cboTipoDoc.Text = "FT", "01",
                                                    IIf(cboTipoDoc.Text = "BV", "03", IIf(cboTipoDoc.Text = "NC", "07", IIf(cboTipoDoc.Text = "ND", "08", "")))) & "-" &
                                                    cboSerieDoc.Text & "-" & Format(CInt(Strings.Right(NumeracionFacturacion, 7)), "00000000") & ".pdf"

                        While _existe_pdf = False
                            If File.Exists(StrNomArchivo_PDF) Then
                                Dim msj As String = ""
                                msj = "Documento Generado Correctamente," & vbCrLf & "Nro Documento: " & cboTipoDoc.Text & " - " & NumeracionFacturacion

                                If MessageBox.Show(msj & vbCrLf & "Se procedera a la impresión del documento" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    'System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                                    If _GENERA_IMPRESION_DIRECTA = "S" Then
                                        For i As Integer = 0 To NUMERO_IMPRESIONES - 1
                                            'Imprimir_Directo(StrNomArchivo_PDF, Nom_Impresora_Ticket)
                                            If Nom_Impresora_Ticket = "" Then
                                                Imprimir_Directo(StrNomArchivo_PDF)
                                            Else
                                                Imprimir_Directo(StrNomArchivo_PDF, Nom_Impresora_Ticket)
                                            End If
                                        Next
                                    Else
                                        System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                                    End If
                                End If

                                _existe_pdf = True
                            End If
                        End While
                        _existe_pdf = False

                        StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                            dtpFechaFactura.Value.Year.ToString & "\" & Format(dtpFechaFactura.Value.Month, "00") &
                                            "\" & Format(dtpFechaFactura.Value.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(cboTipoDoc.Text = "FT", "01",
                                            IIf(cboTipoDoc.Text = "BV", "03", IIf(cboTipoDoc.Text = "NC", "07", IIf(cboTipoDoc.Text = "ND", "08", "")))) & "-" &
                                            cboSerieDoc.Text & "-" & Format(CInt(Strings.Right(NumeracionFacturacion, 7)), "00000000") & ".xml"


                        If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & cboTipoDoc.Text & " -  " & cboSerieDoc.Text & Strings.Right(NumeracionFacturacion, 7) & ".xml" & Chr(13) &
                                   "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If

                        If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & cboTipoDoc.Text & " -  " & cboSerieDoc.Text & Strings.Right(NumeracionFacturacion, 7) & ".pdf" & Chr(13) &
                            "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If

                    End If
                    '***************************

                    'Dim msj As String = ""
                    'msj = "Documento Generado Correctamente" & vbCrLf & "Nro Documento: " & cboTipoDoc.Text & " - " & NumeracionFacturacion
                    'MsgBox(msj, MsgBoxStyle.Information)

                    ToolStrip1.Enabled = True
                    'DocumentosFactura()
                    Flag_Verificar = True
                    Nuevo()
                    Flag_Verificar = False
                    NuevaVenta()
                    txt_buscador_productos.Focus()
                    Me.Cursor = Cursors.Default
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Imprimir_Directo(ByVal _nombre_archivo As String, ByVal _nombre_impresora As String)
        Dim Adjunto As String = _nombre_archivo 'Path & "\Reporte" & InstanciaID & ".pdf"
        Dim pathToExecutable As String = "AcroRd32.exe"
        Dim SPrinter As String
        SPrinter = _nombre_impresora

        Dim starter As New ProcessStartInfo(pathToExecutable, "/t """ + Adjunto + """ """ + SPrinter + """")
        Dim Process As New Process()
        Process.StartInfo = starter
        Process.Start()
        Process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
        Process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.WaitForExit(7000)
        Process.Kill()
        Process.Close()

    End Sub

    

    Private Sub DocumentosFactura()
        Try
            Me.Cursor = Cursors.WaitCursor
            STRorden = ""
            If cboopcionesBusqueda.SelectedIndex = 3 Then 'busqueda rapida
                If txtFiltro.Text.Trim = "" Then
                    dgvDocumentosFactura.DataSource = Nothing
                Else
                    clsFacturaBl = New ClsNegocio.RECEIVABLE
                    dtDocumentoFactura = New DataTable
                    dtv = New DataView
                    dtDocumentoFactura = clsFacturaBl.get_Busqueda_Rapida(txtFiltro.Text.Trim, IIf(cboOpcionTipoDoc.SelectedIndex = 0, "", cboOpcionTipoDoc.Text))
                    dgvDocumentosFactura.DataSource = Nothing
                    If dtDocumentoFactura.Rows.Count() <> 0 Then
                        dtv = dtDocumentoFactura.DefaultView
                        dgvDocumentosFactura.DataSource = dtv
                        'dgvDocumentosFactura.AutoResizeColumns()
                        'dgvDocumentosFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        For i As Integer = 0 To 3
                            dgvDocumentosFactura.Columns(i).Frozen = True
                        Next
                        dgvDocumentosFactura.Columns(3).Width = 300
                        dgvDocumentosFactura.Columns(0).Width = 50
                        dgvDocumentosFactura.Columns(2).Width = 90
                        dgvDocumentosFactura.Columns(4).Width = 50

                        dgvDocumentosFactura.Columns(5).HeaderText = "Monto"
                        dgvDocumentosFactura.Columns(5).DefaultCellStyle.Format = "N2"
                        dgvDocumentosFactura.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDocumentosFactura.Columns(7).Visible = False
                        dgvDocumentosFactura.Columns(8).Visible = False
                        dgvDocumentosFactura.Columns(9).Visible = False
                        dgvDocumentosFactura.Columns(12).Visible = True

                        dgvDocumentosFactura.Columns("PV").Visible = False
                        dgvDocumentosFactura.Columns("Comp.percepcion").Visible = False
                        dgvDocumentosFactura.Columns("Fecha.Despacho").Visible = False
                        dgvDocumentosFactura.Columns("Vendedor").Visible = False
                        dgvDocumentosFactura.Columns("Punto Venta").Visible = False
                        dgvDocumentosFactura.Columns("N° de Entrega - Licitación").Visible = False
                        dgvDocumentosFactura.Columns("Emp. Transporte de Despacho").Visible = False
                        dgvDocumentosFactura.Columns("Transportista de Despacho").Visible = False
                        dgvDocumentosFactura.Columns("Datos.del.Vehiculo").Visible = False
                        dgvDocumentosFactura.Columns("Observaciones de Despachos").Visible = False
                        dgvDocumentosFactura.Columns("Ruc").Visible = False
                        dgvDocumentosFactura.Columns("DIAS").Visible = False


                        dgvDocumentosFactura.Columns("ENVIO_MAIL").HeaderText = "Envio Mail"
                        STRorden = dgvDocumentosFactura.Columns(0).Name & "+" & dgvDocumentosFactura.Columns(1).Name & "+" & dgvDocumentosFactura.Columns(2).Name & "+" & dgvDocumentosFactura.Columns(3).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                    End If
                End If
            ElseIf cboopcionesBusqueda.SelectedIndex = 4 Then ' busqueda por serie
                If cboopcionesBusqueda.SelectedIndex = 4 Then
                    If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                        MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dtpfechaInicial.Focus()
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If
                If txtFiltro.Text.Trim = "" Then
                    dgvDocumentosFactura.DataSource = Nothing
                Else
                    clsFacturaBl = New ClsNegocio.RECEIVABLE
                    dtDocumentoFactura = New DataTable
                    dtv = New DataView
                    dtDocumentoFactura = clsFacturaBl.get_Busqueda_Por_Serie(txtFiltro.Text.Trim, IIf(cboOpcionTipoDoc.SelectedIndex = 0, "", cboOpcionTipoDoc.Text), dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"))
                    dgvDocumentosFactura.DataSource = Nothing
                    If dtDocumentoFactura.Rows.Count() <> 0 Then
                        dtv = dtDocumentoFactura.DefaultView
                        dgvDocumentosFactura.DataSource = dtv
                        'dgvDocumentosFactura.AutoResizeColumns()
                        'dgvDocumentosFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        For i As Integer = 0 To 3
                            dgvDocumentosFactura.Columns(i).Frozen = True
                        Next

                        dgvDocumentosFactura.Columns(3).Width = 300
                        dgvDocumentosFactura.Columns(0).Width = 50
                        dgvDocumentosFactura.Columns(2).Width = 90
                        dgvDocumentosFactura.Columns(4).Width = 50
                        dgvDocumentosFactura.Columns(5).HeaderText = "Monto"
                        dgvDocumentosFactura.Columns(5).DefaultCellStyle.Format = "N2"
                        dgvDocumentosFactura.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDocumentosFactura.Columns(7).Visible = False
                        dgvDocumentosFactura.Columns(8).Visible = False
                        dgvDocumentosFactura.Columns(9).Visible = False
                        dgvDocumentosFactura.Columns(12).Visible = True

                        dgvDocumentosFactura.Columns("PV").Visible = False
                        dgvDocumentosFactura.Columns("Comp.percepcion").Visible = False
                        dgvDocumentosFactura.Columns("Fecha.Despacho").Visible = False
                        dgvDocumentosFactura.Columns("Vendedor").Visible = False
                        dgvDocumentosFactura.Columns("Punto Venta").Visible = False
                        dgvDocumentosFactura.Columns("N° de Entrega - Licitación").Visible = False
                        dgvDocumentosFactura.Columns("Emp. Transporte de Despacho").Visible = False
                        dgvDocumentosFactura.Columns("Transportista de Despacho").Visible = False
                        dgvDocumentosFactura.Columns("Datos.del.Vehiculo").Visible = False
                        dgvDocumentosFactura.Columns("Observaciones de Despachos").Visible = False
                        dgvDocumentosFactura.Columns("Ruc").Visible = False
                        dgvDocumentosFactura.Columns("DIAS").Visible = False


                        dgvDocumentosFactura.Columns("ENVIO_MAIL").HeaderText = "Envio Mail"
                        STRorden = dgvDocumentosFactura.Columns(0).Name & "+" & dgvDocumentosFactura.Columns(1).Name & "+" & dgvDocumentosFactura.Columns(2).Name & "+" & dgvDocumentosFactura.Columns(3).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                    End If
                End If
            Else
                If cboopcionesBusqueda.SelectedIndex = 2 Then
                    If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                        MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dtpfechaInicial.Focus()
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDocumentoFactura = New DataTable
                dtv = New DataView
                dtDocumentoFactura = clsFacturaBl.get_DatosGeneralesFacturacion_Tienda(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"),
                                                                                cboopcionesBusqueda.SelectedIndex, IIf(cboOpcionTipoDoc.SelectedIndex = 0, "", cboOpcionTipoDoc.Text))
                dgvDocumentosFactura.DataSource = Nothing
                If dtDocumentoFactura.Rows.Count() <> 0 Then
                    dtv = dtDocumentoFactura.DefaultView
                    dgvDocumentosFactura.DataSource = dtv
                    'dgvDocumentosFactura.AutoResizeColumns()
                    'dgvDocumentosFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    For i As Integer = 0 To 3
                        dgvDocumentosFactura.Columns(i).Frozen = True
                    Next
                    dgvDocumentosFactura.Columns(3).Width = 300
                    dgvDocumentosFactura.Columns(0).Width = 50
                    dgvDocumentosFactura.Columns(2).Width = 90
                    dgvDocumentosFactura.Columns(4).Width = 50

                    dgvDocumentosFactura.Columns(5).HeaderText = "Monto"
                    dgvDocumentosFactura.Columns(5).DefaultCellStyle.Format = "N2"
                    dgvDocumentosFactura.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDocumentosFactura.Columns(7).Visible = False
                    dgvDocumentosFactura.Columns(8).Visible = False
                    dgvDocumentosFactura.Columns(9).Visible = False
                    dgvDocumentosFactura.Columns(12).Visible = True

                    dgvDocumentosFactura.Columns("PV").Visible = False
                    dgvDocumentosFactura.Columns("Comp.percepcion").Visible = False
                    dgvDocumentosFactura.Columns("Fecha.Despacho").Visible = False
                    dgvDocumentosFactura.Columns("Vendedor").Visible = False
                    dgvDocumentosFactura.Columns("Punto Venta").Visible = False
                    dgvDocumentosFactura.Columns("N° de Entrega - Licitación").Visible = False
                    dgvDocumentosFactura.Columns("Emp. Transporte de Despacho").Visible = False
                    dgvDocumentosFactura.Columns("Transportista de Despacho").Visible = False
                    dgvDocumentosFactura.Columns("Datos.del.Vehiculo").Visible = False
                    dgvDocumentosFactura.Columns("Observaciones de Despachos").Visible = False
                    dgvDocumentosFactura.Columns("Ruc").Visible = False
                    dgvDocumentosFactura.Columns("DIAS").Visible = False

                    dgvDocumentosFactura.Columns("Guia.Remision").Visible = False
                    dgvDocumentosFactura.Columns("Orden de Compra/N° Pedido").Visible = False
                    dgvDocumentosFactura.Columns("Numero.Voucher").Visible = False
                    dgvDocumentosFactura.Columns("ENVIO_MAIL").Visible = False
                    dgvDocumentosFactura.Columns("MOTIVO.BAJA").HeaderText = "Motivo de Anulación"

                    dgvDocumentosFactura.Columns("ENVIO_MAIL").HeaderText = "Envio Mail"
                    STRorden = dgvDocumentosFactura.Columns(0).Name & "+" & dgvDocumentosFactura.Columns(1).Name & "+" & dgvDocumentosFactura.Columns(2).Name & "+" & dgvDocumentosFactura.Columns(3).Name
                    lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
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
        Ref_DATE_DOC = Date.Now
        Dim Store As String = String.Empty
        Dim msj As String = String.Empty
        Dim Usuario As String = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, Ref_DATE_DOC) = False Then Exit Sub

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
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim STREstado As String = String.Empty
            STREstado = dgvDocumentosFactura.CurrentRow.Cells("Estado").Value
            If STREstado = "ANULADO" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("El Documento ya se encuentra ANULADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If Strings.Left(dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value, 1) = "F" Or Strings.Left(dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value, 1) = "B" Then
                If CInt(dgvDocumentosFactura.CurrentRow.Cells("DIAS").Value) > 7 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("No aplica el Proceso de ANULACION, por superar el limite de días habiles.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If

            ref_fecha_doc = dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value
            If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Ref_DOCUMENT_ID = String.Empty
            Ref_NUMBER_SERIE = String.Empty
            Ref_NUMBER_DOCUMENT = String.Empty
            Ref_DATE_DOC = Date.Now
            Dim Store As String = String.Empty
            Dim msj As String = String.Empty

            If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, Ref_DATE_DOC) = False Then Me.Cursor = Cursors.Default : Exit Sub

            Store = String.Empty
            Store = "FACT_SP_S_R_VERIFICAR_LETRA"
            If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                Me.Cursor = Cursors.Default
                msj = String.Empty
                msj = "EL Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Letra , no se puede Anular."
                MsgBox(msj, MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                'verificamos si esta contabilizado
                Store = String.Empty
                Store = "FACT_SP_S_R_VERIFICAR_CONTABILIZACION"
                If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                    Me.Cursor = Cursors.Default
                    msj = String.Empty
                    msj = "EL Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " esta contabilizado, no se puede Anular."
                    MsgBox(msj, MsgBoxStyle.Exclamation)
                    Exit Sub
                Else
                    'verificamos si esta cobrado
                    Store = String.Empty
                    Store = "FACT_SP_S_R_VERIFICAR_CANCEL"
                    If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                        Me.Cursor = Cursors.Default
                        msj = String.Empty
                        msj = "EL Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Cancelación, no se puede Anular."
                        MsgBox(msj, MsgBoxStyle.Exclamation)
                        Exit Sub
                    Else
                        ToolStrip1.Enabled = False
                        pnlPrincipal.Enabled = False
                        txt_motivo_anulacion.Text = ""
                        lbl_numero_documento.Text = Ref_DOCUMENT_ID & "-" & Ref_NUMBER_SERIE & "-" & Ref_NUMBER_DOCUMENT
                        dtp_fecha_anulacion.Value = Date.Now
                        pnl_motivo_anulacion.Visible = True
                        txt_motivo_anulacion.Focus()
                        Me.Cursor = Cursors.Default
                    End If
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function ValidacionConsultas(ByRef _DOCUMENT_ID As String, ByRef _NUMBER_SERIE As String, ByRef _NUMBER_DOCUMENT As String, ByRef _DATE_DOC As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            _DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("DOCUMENT_ID").Value
            _NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value
            _NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_DOCUMENT").Value
            _DATE_DOC = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value
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
            _GENERA_IMPRESION_DIRECTA = ""
            Nom_Impresora_Ticket = ""
            NUMERO_IMPRESIONES = 0

            If _Moneda = "MN" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   SOLES"
            Else
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   DOLARES AMERICANOS"
            End If
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.Obtener_Nombre_Reporte(_DOCUMENT_ID, _NUMBER_SERIE)
            If dtImprimir.Rows.Count > 0 Then
                Nom_Reporte = dtImprimir.Rows(0).Item("REPORT_NAME").ToString
                _GENERA_IMPRESION_DIRECTA = dtImprimir.Rows(0).Item("IS_PRINT_AUTOMATIC").ToString
                Nom_Impresora_Ticket = dtImprimir.Rows(0).Item("IMPRESORA").ToString
                NUMERO_IMPRESIONES = dtImprimir.Rows(0).Item("NUMERO_IMPRESIONES").ToString
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
                    If _GENERA_IMPRESION_DIRECTA = "S" Then
                        crystalBL.Muestra_Reporte_Imprime_Directo(Nom_Reporte, dtImprimir, "", "", "TICKET_PF", Nom_Impresora_Ticket,
                                                                  "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE,
                                                                  "@NUMERO;" & _NUMBER_DOCUMENT, "LETRAS;" & STRmontotexto)
                        For i As Integer = 0 To NUMERO_IMPRESIONES - 1
                            Imprimir_Directo(RutaReportes() & "\" & "TICKET_PF.pdf", Nom_Impresora_Ticket)
                        Next
                    Else
                        If _DOCUMENT_ID = "PF" Then
                            Dim codigo As String = String.Empty
                            codigo = InputBox("Digite 1 para imprimir en formato TK" & Chr(13) & "Digite 2 para imprimir en formato A4")
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
                                    If codigo = "1" Then
                                        crystalBL.Muestra_Reporte("SAL_proforma_TK.rpt", dtImprimir, "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE, "@NUMERO;" & _NUMBER_DOCUMENT, "LETRAS;" & STRmontotexto)
                                    ElseIf codigo = "2" Then
                                        crystalBL.Muestra_Reporte("SAL_proforma.rpt", dtImprimir, "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE, "@NUMERO;" & _NUMBER_DOCUMENT, "LETRAS;" & STRmontotexto)
                                    End If

                                    Me.Cursor = Cursors.Default
                                End If
                            End If

                        Else
                            crystalBL.Muestra_Reporte(Nom_Reporte, dtImprimir, "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE, "@NUMERO;" & _NUMBER_DOCUMENT, "LETRAS;" & STRmontotexto)
                            'crystalBL.Muestra_Reporte(Nom_Reporte, dtImprimir, "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE, "@NUMERO;" & _NUMBER_DOCUMENT, "LETRAS;" & STRmontotexto)
                        End If

                    End If

                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Function RutaReportes() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRutaReportes = mySetting("Reportes")
        Return STRRutaReportes
    End Function

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
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Ref_DOCUMENT_ID = String.Empty
            Ref_NUMBER_SERIE = String.Empty
            Ref_NUMBER_DOCUMENT = String.Empty
            Ref_DATE_DOC = Date.Now
            'Validacione Generales Reporte y consulta
            If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, Ref_DATE_DOC) = False Then Me.Cursor = Cursors.Default : Exit Sub
            Dim StrNomArchivo_PDF As String = ""
            _GENERA_IMPRESION_DIRECTA = ""
            Nom_Impresora_Ticket = ""
            NUMERO_IMPRESIONES = 0
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtValidacion = New DataTable("Validacion")
            dtValidacion = clsFacturaBl.Get_Validacion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE)
            If dtValidacion.Rows.Count > 0 Then
                _GENERA_IMPRESION_DIRECTA = dtValidacion.Rows(0).Item("IS_PRINT_AUTOMATIC").ToString
                Nom_Impresora_Ticket = dtValidacion.Rows(0).Item("IMPRESORA").ToString
                NUMERO_IMPRESIONES = dtValidacion.Rows(0).Item("NUMERO_IMPRESIONES").ToString
            End If

            If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then

                StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & Ref_DATE_DOC.Year.ToString & "\" &
                                    Format(Ref_DATE_DOC.Month, "00") & "\" & Format(Ref_DATE_DOC.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" &
                                    IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07",
                                    IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                If File.Exists(StrNomArchivo_PDF) Then
                    If _GENERA_IMPRESION_DIRECTA = "S" Then
                        For i As Integer = 0 To NUMERO_IMPRESIONES - 1
                            'Imprimir_Directo(StrNomArchivo_PDF, Nom_Impresora_Ticket)
                            If Nom_Impresora_Ticket = "" Then
                                Imprimir_Directo(StrNomArchivo_PDF)
                            Else
                                Imprimir_Directo(StrNomArchivo_PDF, Nom_Impresora_Ticket)
                            End If
                        Next
                    Else
                        System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                    End If

                    If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = False Then
                        MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf" & Chr(13) &
                        "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                    End If

                Else
                    Dim msj As String = ""
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                    MsgBox(msj, MsgBoxStyle.Information)
                End If
            Else
                imprimirFacturacion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, dgvDocumentosFactura.CurrentRow.Cells("Moneda").Value, 0, dgvDocumentosFactura.CurrentRow.Cells("Monto").Value)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

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
                crystalBL.Muestra_Reporte("rpt_Impresion_pedido.rpt", dtImprimir, "", "", "@ID;" & _Codigo, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles Button1.Click, btnCancelar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            DocumentosFactura()
            pnlPrincipal.Visible = True
            GbdetalleDocumento.Visible = False
            Botonera_Estado_Cambiar(False)
            Limpiar()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
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
            Case 3
                gbRangofechas.Enabled = False
            Case 4
                gbRangofechas.Enabled = True
        End Select
        txtFiltro.Text = String.Empty
        'If flag_inicio = True Then
        '    DocumentosFactura()
        'End If
        DocumentosFactura()
        txtFiltro.Focus()
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
            'cboTipoDoc.Text = "PF"
            Ayuda_SerieGuiaPuntoVenta()
            If cboTipoDoc.Text = String.Empty Then Exit Sub
            SerieDocumentoPuntoVenta()

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
                    txtCodCliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtRazonSocial.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txtRucDni.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                    txtDireccion.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                    txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                    If rbFacturaRepMedico.Checked = False Then
                        txtVendedor.Text = frm.Data_Matriz.Rows(0).Item("SALES_ID").ToString
                    End If
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
                    If rb_facturar_pedido.Checked = False Then
                        txtFormaPago.Text = dtDetalleFact.Rows(0).Item(5).ToString
                        If rbFacturaRepMedico.Checked = False Then
                            txtVendedor.Text = dtDetalleFact.Rows(0).Item("SALES_ID").ToString
                        End If
                    End If
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
            If rbFacturaGuiaVenta.Checked = True Then
                If String.IsNullOrEmpty(txtCodCliente.Text) Or String.IsNullOrEmpty(txtAlmacen.Text) Then
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
                If txt_tip_nota_electronica.Enabled = True Then
                    txt_tip_nota_electronica.Focus()
                Else
                    btnAgregar.Select()
                End If
            Else
                Ayuda_FormaPago(txtFormaPago.Text)
                If txt_tip_nota_electronica.Enabled = True Then
                    txt_tip_nota_electronica.Focus()
                Else
                    btnAgregar.Select()
                End If
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

            If cboTipoDoc.Text = String.Empty Then
                MessageBox.Show("Debe elegir el tipo de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboTipoDoc.Focus()
                estado = False
                Exit Try
            End If

            If cboTipoDoc.Text = "FT" Then
                If Strings.Len(Trim(txtRucDni.Text)) <> 11 Then
                    MsgBox("Esta Generando una Factura y el Tipo de Cliente elegido es invalido. Verifique!", MsgBoxStyle.Exclamation)
                    estado = False
                    txtCodCliente.Focus()
                    Exit Try
                End If
            ElseIf cboTipoDoc.Text = "BV" Then
                If Strings.Len(Trim(txtRucDni.Text)) <> 8 And Strings.Len(Trim(txtRucDni.Text)) <> 9 Then
                    MsgBox("Esta Generando una Boleta de Venta y el Tipo de Cliente elegido es invalido. Verifique!", MsgBoxStyle.Exclamation)
                    estado = False
                    txtCodCliente.Focus()
                    Exit Try
                End If
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
            frmArticulo.Flag_Cliente = txtCodCliente.Text
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
                    If cboTipoDoc.Text = "PF" Then
                        po_TasaIgv = CDbl(0)
                    Else
                        po_TasaIgv = CDbl(row("IGV_POR").ToString)
                    End If

                    po_TasaIsc = CDbl(row("ISCPOR").ToString)
                    clsIgvArticuloBL = New ClsTransacciones.clsPedidos
                    dtIgvArticulo = New DataTable("Fl_igv")
                    dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvArticulo(row("CODIGO").ToString())

                    If dtIgvArticulo.Rows.Count() <> 0 Then
                        If chkSinIGV.Checked = False Then 'si el precio contiene el IGV

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
                                    If cboTipoDoc.Text = "PF" Then
                                        Igv = CDbl(0) 'IGV_POR_ITEM '(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    Else
                                        Igv = CDbl(row("IGV_POR").ToString) 'IGV_POR_ITEM '(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    End If

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
                                    'row("IMP_DESC_01") = CDbl((row("PREC_UNITARIO_FRACCION") * row("%DESC.ART_1") / 100) * row("CANTIDAD_FRACCION"))
                                    'row("IMP_DESC_02") = CDbl(((row("PREC_UNITARIO_FRACCION") - (row("PREC_UNITARIO_FRACCION") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD_FRACCION"))
                                    row("PRECIO_IGV_FRACCION") = row("PRECIO_INICIAL_FRACCION")
                                    row("IGV_ART_FRACCION") = CDbl(CDbl(row("CANTIDAD_FRACCION") * (row("PREC_UNITARIO_FRACCION") - row("IMP_DESC_01")) * (1 + TasaISC)) * TasaIgv)
                                    row("ISC") = CDbl(row("CANTIDAD_FRACCION") * (row("PREC_UNITARIO_FRACCION") - row("IMP_DESC_01")) * TasaISC)
                                    'row("IGV_ART_US") = 0
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
                                    'row("IMP_DESC_01") = CDbl((row("PRECIO_INICIAL_FRACCION") * row("%DESC.ART_1") / 100) * row("CANTIDAD_FRACCION"))
                                    'row("IMP_DESC_02") = CDbl(((row("PRECIO_INICIAL_FRACCION") - (row("PRECIO_INICIAL_FRACCION") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD_FRACCION"))
                                    row("PRECIO_IGV_FRACCION") = Monto
                                    row("IGV_ART_FRACCION") = CDbl(((row("CANTIDAD_FRACCION") * (row("PREC_UNITARIO_FRACCION") - row("IMP_DESC_01"))) * (1 + TasaISC)) * TasaIgv)
                                    row("ISC") = CDbl(row("CANTIDAD_FRACCION") * (row("PREC_UNITARIO_FRACCION") - row("IMP_DESC_01")) * TasaISC)
                                    'row("IGV_ART_US") = 0
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
            frmArticulo.Flag_Cliente = txtCodCliente.Text
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
                    txt_observaciones.Text = item("OBSERVACIONES")
                    txt_numero_lote.Text = item("LOTE")
                    txtdescuento1.Text = item("%DESC.ART_1")
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
        txt_buscador_productos.Focus()
    End Sub

    Private Sub Ayuda_TipoDocPuntoVenta()
        Try
            cVenta = New ClsAyudas
            dtTipoDoc = New DataTable
            If txtPtoVenta.Text = String.Empty Then Exit Sub
            dtTipoDoc = cVenta.get_Tipo_Doc_Pto_Venta(txtPtoVenta.Text.Trim)
            cboTipoDoc.ValueMember = "SERIE"
            cboTipoDoc.DisplayMember = "TIPO"
            cboTipoDoc.DataSource = dtTipoDoc
            cboTipoDoc.Enabled = True

            If LibComunVar.ClsVarComun.TIPO_DOC <> "" Then
                cboTipoDoc.Text = LibComunVar.ClsVarComun.TIPO_DOC
            End If

            If rb_facturar_devolucion.Checked = True Then
                If Modo_consultar = True Then Exit Sub

                txttipoDocRef.Enabled = Not rb_facturar_devolucion.Checked
                txttipoDocRef.Text = "RD"
                cboTipoDoc.Text = "NC"
            End If
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

        If LibComunVar.ClsVarComun.SERI_DOC <> "" Then
            cboSerieDoc.Text = LibComunVar.ClsVarComun.SERI_DOC
        End If
        cVenta = Nothing
    End Sub

    Private Sub cbTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoDoc.SelectionChangeCommitted
        If cboTipoDoc.SelectedIndex <> -1 Then
            SerieDocumentoPuntoVenta()
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
        cboSerieDoc.Text = cboTipoDoc.SelectedValue.ToString
        If rbFacturaGuiaVenta.Checked = True Or rb_facturar_devolucion.Checked Or rb_facturar_pedido.Checked Then
            If rb_facturar_pedido.Checked Then
                cboTipoDoc.Enabled = False
            Else
                checkSinGuia.Checked = True
                checkSinGuia.Enabled = False
                gbOpciones.Enabled = False
            End If
        ElseIf rbFacturaExistencias.Checked = True Or rbsinDescargo.Checked = True Then
            checkSinGuia.Checked = True
            checkSinGuia.Enabled = False
            cboTipoDoc.Enabled = True
            gbOpciones.Enabled = True
        Else
            cboTipoDoc.Enabled = True
            If cboTipoDoc.Text = "FT" Then
                checkSinGuia.Checked = True ' False
                checkSinGuia.Enabled = False ' True
                rbunalinea.Checked = True
                cboSerieDoc.Text = "F001"
                GroupBox8.Text = " &Tipo de la Glosa de la Factura"
            ElseIf cboTipoDoc.Text = "BV" Then
                cboSerieDoc.Text = "B001"
            Else
                checkSinGuia.Checked = True
                checkSinGuia.Enabled = False
                rbunalinea.Checked = True
                GroupBox8.Text = "&Tipo de la Glosa del Documento"
            End If
        End If
        Calcular_Totales()
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
        If STRorden = "" Then Exit Sub
        If cboopcionesBusqueda.SelectedIndex <> 3 And cboopcionesBusqueda.SelectedIndex <> 4 Then
            If txtFiltro.Text = String.Empty Then
                dtv.RowFilter = String.Empty
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                Exit Sub
            Else
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvDocumentosFactura.Columns(0).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvDocumentosFactura.Columns(1).Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvDocumentosFactura.Columns(0).Name & "+" & dgvDocumentosFactura.Columns(1).Name & "+" & dgvDocumentosFactura.Columns(2).Name & "+" & dgvDocumentosFactura.Columns(3).Name
                            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                            Exit Sub
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


    Private Sub rbFacturaDirecta_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rbFacturaGuiaVenta_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rbFacturaExistencias_CheckedChanged(sender As Object, e As EventArgs)

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

    Private Sub txtGlosaGuia_KeyDown(sender As Object, e As KeyEventArgs)
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
        Ref_DATE_DOC = Date.Now
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, Ref_DATE_DOC) = False Then Exit Sub
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

        If dgvDocumentosFactura.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub rbsinDescargo_CheckedChanged(sender As Object, e As EventArgs)

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

    Private Sub rbFacturaRepMedico_CheckedChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If cboopcionesBusqueda.SelectedIndex = 3 Or cboopcionesBusqueda.SelectedIndex = 4 Then
            If e.KeyCode = Keys.Enter Then
                DocumentosFactura()
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                cboOpcionTipoDoc.Select()
            End If
        End If
    End Sub

    Private Sub cboOpcionTipoDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles cboOpcionTipoDoc.KeyDown
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

    Private Sub txtGlosa_KeyDown(sender As Object, e As KeyEventArgs)
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

    Private Sub rb_facturar_pedido_CheckedChanged(sender As Object, e As EventArgs)

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

    Private Sub rb_facturar_devolucion_CheckedChanged(sender As Object, e As EventArgs)

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

    Private Sub Ayuda_Transporte()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_EMPRESA_TRANSPORTE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de empresa de transportes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_Empresa.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            frm.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

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
        pnl_ref.Visible = False
        GbCabecera.Enabled = False
        gbdetalle.Enabled = False
        gbOpciones.Enabled = False

        txt_cod_cliente.Text = String.Empty
        txt_ruc_dni.Text = String.Empty
        txt_razon_social.Text = String.Empty
        txt_direccion.Text = String.Empty
        txt_cod_departamento.Text = String.Empty
        txt_des_departamento.Text = String.Empty
        txt_des_provincia.Text = String.Empty
        txt_cod_provincia.Text = String.Empty
        txt_des_distrito.Text = String.Empty
        txt_cod_distrito.Text = String.Empty
        txt_ubigeo.Text = String.Empty
        txt_correo.Text = String.Empty
        txt_Celular.Text = String.Empty

        Cargar_Documentos_Persona()
        cmb_tip_doc_per.SelectedIndex = -1
        panel_cliente_nuevo.Visible = True
        txt_ruc_dni.Focus()
    End Sub
    Private Sub Cargar_Documentos_Persona()
        Dim tipoDocBL As New LibContabilidad.ClsOperaciones.CO_TB_TIPO_DOC_ANE
        cmb_tip_doc_per.DataSource = tipoDocBL.get_Tipos
        cmb_tip_doc_per.DisplayMember = "TD_DESCRIPCION"
        cmb_tip_doc_per.ValueMember = "TD_ID"
        tipoDocBL = Nothing
    End Sub
    Private Sub GenerarCodigoCliente()
        Try
            Dim dtdetalles As DataTable
            clienteBL = New ClsNegocio.CUSTOMER
            dtdetalles = New DataTable("CodigoCliente")
            dtdetalles = clienteBL.GeneracionCodigoCliente("G", "L")
            If dtdetalles.Rows.Count() <> 0 Then
                txt_cod_cliente.Text = dtdetalles.Rows(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Consultando_Ruc() As Boolean
        Try
            Dim clienteBl As ClsOperaciones.CUSTOMER
            Dim dt_ruc As New DataTable
            clienteBl = New ClsOperaciones.CUSTOMER
            dt_ruc = clienteBl.Validacion_Ruc(Strings.Trim(txt_ruc_dni.Text))
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
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

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

    Private Sub Button6_Click(sender As Object, e As EventArgs)

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

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_tipo_doc_ref_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Ayuda_Doc_Referencia()
    End Sub

    Private Sub txt_tipo_doc_ref_KeyDown(sender As Object, e As KeyEventArgs)
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

    Private Sub TextBox13_MouseDoubleClick(sender As Object, e As MouseEventArgs)

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

    Private Sub TextBox13_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub TextBox16_MouseDoubleClick(sender As Object, e As MouseEventArgs)

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

    Private Sub TextBox16_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub TextBox18_MouseDoubleClick(sender As Object, e As MouseEventArgs)

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
                txt_cod_forma_pago.Focus()
            Else
                txt_cod_distrito.Text = String.Empty
                txt_des_distrito.Text = String.Empty
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox18_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_ruc_dni.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TextBox5.Select()
        End If
    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TextBox7.Select()
        End If
    End Sub

    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_direccion.Select()
        End If
    End Sub

    Private Sub TextBox9_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_cod_departamento.Select()
        End If
    End Sub

    Private Sub TextBox10_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_correo.Select()
        End If
    End Sub

    Private Sub TextBox11_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_Celular.Select()
        End If
    End Sub

    Private Sub TextBox12_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_grabar_nuevo_cliente.Select()
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
        End If
    End Sub

    Private Sub txtprecioUnitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprecioUnitario.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos_Precio()
        If e.KeyCode = Keys.Enter Then
            If txtprecioUnitario.Text = "" Then
                MostrandoArticulos_Precio()
            Else
                txtdescuento1.Focus() 'btn_agregar_carrito_Click(sender, e)
            End If

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
        txtdescuento1.Text = String.Empty
        txt_buscador_productos.Text = String.Empty
        txt_numero_lote.Text = String.Empty
        txt_observaciones.Text = String.Empty
        IGV_POR_ITEM = 0
        TIPO_ISC = 0
        ISC_POR = 0
        dgv_lista_productos.DataSource = Nothing
        txt_buscador_productos.Focus()
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
                If txtdescuento1.Text = "" Then
                    row("%DESC.ART_1") = 0
                Else
                    row("%DESC.ART_1") = CDbl(txtdescuento1.Text)
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
                row("OBSERVACIONES") = txt_observaciones.Text
                row("DOC_REF") = ""
                row("NUM_REF") = ""
                row("ITEM_REF") = 0

                row("TIPOISC") = TIPO_ISC
                row("ISCPOR") = ISC_POR
                row("ISC") = 0
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
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
                If txtdescuento1.Text = "" Then
                    row("%DESC.ART_1") = 0
                Else
                    row("%DESC.ART_1") = CDbl(txtdescuento1.Text)
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
                row("OBSERVACIONES") = txt_observaciones.Text
                row("DOC_REF") = ""
                row("NUM_REF") = ""
                row("ITEM_REF") = 0

                row("TIPOISC") = TIPO_ISC
                row("ISCPOR") = ISC_POR
                row("ISC") = 0
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
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
                If txtdescuento1.Text = "" Then
                    item("%DESC.ART_1") = 0
                Else
                    item("%DESC.ART_1") = CDbl(txtdescuento1.Text)
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
                item("OBSERVACIONES") = txt_observaciones.Text
                item("DOC_REF") = ""
                item("NUM_REF") = ""
                item("ITEM_REF") = 0
                item("TIPOISC") = TIPO_ISC
                item("ISCPOR") = ISC_POR
                item("ISC") = 0
                dtdetalleArticuloPrincipal.EndInit()
                dtdetalleArticuloPrincipal.AcceptChanges()
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
            If txtdescuento1.Text = String.Empty Then txtdescuento1.Text = "0"

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

    Private Sub txtdescripcionArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionArticulo.TextChanged

    End Sub

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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_confirmar_anulacion.Click
        'Anulacion Factura
        If txt_motivo_anulacion.Text.Trim = "" Then
            Me.Cursor = Cursors.Default
            MsgBox("Debe ingresar un motivo de anulación.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim PuntoVenta As String = dgvDocumentosFactura.CurrentRow.Cells("PV").Value
            Dim WareHouse As String = String.Empty
            If String.IsNullOrEmpty(PuntoVenta.ToString) Then
                Me.Cursor = Cursors.Default
                MsgBox("El documento no posee un Punto de Venta Asociado", MsgBoxStyle.Critical)
                Exit Sub
            End If
            dtDetalleFact = clsFacturaBl.Get_ManualPuntoVenta(PuntoVenta)
            If dtDetalleFact.Rows.Count() <> 0 Then
                WareHouse = dtDetalleFact.Rows(0).Item(2).ToString
            Else
                Me.Cursor = Cursors.Default
                MsgBox("No existe Almacen en el Punto de venta", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MessageBox.Show("¿Desea Anular el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


                If AnularFacturas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "", WareHouse, txt_motivo_anulacion.Text.Trim) = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de Anulacion", MsgBoxStyle.Exclamation)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Then
                        ID_COMUNICACION_BAJA_ = ""
                        ID_COMUNICACION_BAJA_CDR = ""
                        If Generar_XML_Comunicacion_Baja(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, dtp_fecha_anulacion.Value.ToString("dd/MM/yyyy"),
                                                         ID_COMUNICACION_BAJA_, ID_COMUNICACION_BAJA_CDR) = False Then
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
                                'COPIAMOS EL XML DE LA COMUNICACION DE BAJA
                                StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                    LibComunVar.ClsVarComun.FechaSistema.Year.ToString & "\" & Format(LibComunVar.ClsVarComun.FechaSistema.Month, "00") & "\" &
                                                    Format(LibComunVar.ClsVarComun.FechaSistema.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa &
                                                    "-RA-" & ID_COMUNICACION_BAJA_CDR

                                System.Threading.Thread.Sleep(2000)
                                If File.Exists(StrNomArchivo_XML) Then
                                    If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = False Then
                                        MsgBox("ERROR:" & Chr(13) & "El documento RA-" & ID_COMUNICACION_BAJA_CDR & Chr(13) &
                                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                    Else
                                        DocumentosFactura()
                                        Button8_Click(sender, e)
                                        Dim msj As String
                                        msj = String.Empty
                                        msj = "Documento Anulado Correctamente." & vbCrLf & "Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                                        MsgBox(msj, MsgBoxStyle.Information)
                                    End If
                                Else
                                    MsgBox("No existe el documento RA-" & ID_COMUNICACION_BAJA_CDR & " . Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                End If
                                'FIN DE COPIAMOS EL XML DE LA COMUNICACION DE BAJA
                            End If
                        End If
                    ElseIf Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then
                        clsFacturaBl = New ClsNegocio.RECEIVABLE
                        Dim dt_table As DataTable
                        Dim _txt_numero_resumen As String
                        Dim _txt_nombre_boletas As String
                        dt_table = New DataTable
                        dt_table = clsFacturaBl.get_Resumen_Boletas_SUNAT_Correlativo(Date.Now.ToString("dd/MM/yyyy"))
                        If dt_table.Rows.Count > 0 Then
                            _txt_numero_resumen = "RC-" & CDate(Date.Now).Year.ToString & Format(CDate(Date.Now).Month, "00") & Format(CDate(Date.Now).Day, "00") & "-" & Format(CInt(dt_table.Rows(0).Item("ITEMS")) + 1, "00000")
                            _txt_nombre_boletas = "RC-" & CDate(Date.Now).Year.ToString & Format(CDate(Date.Now).Month, "00") & Format(CDate(Date.Now).Day, "00") & "-" & CStr(CInt(dt_table.Rows(0).Item("ITEMS")) + 1) & ".xml"

                            If Guardar_Resumen_Boletas(_txt_numero_resumen, _txt_nombre_boletas) = True Then
                                If Generar_XML_Resumen_Boletas(dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value, _txt_numero_resumen, "3") = False Then
                                    MsgBox("No se Genero el Resumen de Boletas en versión del UBL 2.1, para la fecha " & dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                                Else
                                    Dim strMensaje As String = ""
                                    Dim StrNomArchivo_XML As String = ""

                                    StrNomArchivo_XML = Ruta_FE() & "\InputXML\" & _txt_nombre_boletas

                                    Dim oProcesaArchivo As New ProcesaArchivo

                                    If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                                        MsgBox(strMensaje, MsgBoxStyle.Critical)
                                        Me.Cursor = Cursors.Default
                                        Exit Sub
                                    Else
                                        DocumentosFactura()
                                        Button5_Click(sender, e)
                                        Dim msj As String
                                        msj = String.Empty
                                        msj = "Documento Anulado Correctamente." & vbCrLf & "Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                                        MsgBox(msj, MsgBoxStyle.Information)
                                    End If


                                End If
                            End If
                        Else
                            MsgBox("No existe el correlativo para el Resumen de Boletas", MsgBoxStyle.Exclamation, "Aviso")
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
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Generar_XML_Resumen_Boletas(ByVal fecha_resumen As String, ByVal codigo_resumen As String, ByVal estado_documentos As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_XML_Resumen_Boletas(fecha_resumen, Ruta_FE() & "\InputXML", codigo_resumen, estado_documentos) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Guardar_Resumen_Boletas(ByVal _txt_numero_resumen As String, ByVal _txt_nombre_boletas As String) As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            cabeceraBL = New ClsOperaciones.RECEIVABLE
            cabeceraBE_rb = New ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS
            detalleBE_rb = New ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE
            ls_det_rb = New List(Of ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE)

            With cabeceraBE_rb
                .ID = 0
                .CODIGO_RESUMEN = _txt_numero_resumen
                .CODIGO_RESUMEN_BOLETAS = _txt_nombre_boletas
                .FECHA_DOCUMENTOS = dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value
                .NUMERO_TICKET = ""
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .PC_ID = Environment.MachineName
            End With

            'Detalle de Resumen

            detalleBE_rb = New ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE
            With detalleBE_rb
                .ID_CAB = 0
                .ITEM = 1
                .TIPO_DOC = dgvDocumentosFactura.CurrentRow.Cells("DOCUMENT_ID").Value
                .SERIE_DOC = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value
                .NUMERO_DOC = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_DOCUMENT").Value
                .OPE_GRABADAS = 0
                .OPE_INAFECTAS = 0
                .OPE_EXONERADAS = 0
                .OPE_IGV = 0
                .OPE_TOTAL = 0
            End With
            ls_det_rb.Add(detalleBE_rb)

            If cabeceraBL.GuardarFactura_Resumen_Boletas_SUNAT(cabeceraBE_rb, ls_det_rb) = False Then
                MsgBox("Hubo un Error en la generación del Resumen de Boletas.", MsgBoxStyle.Critical)
                indicadorF = False
                Exit Try
            End If

        Catch ex As Exception
            indicadorF = False
            MsgBox(ex.Message)
        End Try
        Return indicadorF
    End Function

    Private Function Ruta_FE_Verificacion() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE_Verificacion = mySetting("Ruta_FE_Verificacion")
        Return STRRuta_FE_Verificacion
    End Function

    Private Function Generar_XML_Comunicacion_Baja(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Fecha_baja As String,
                                                   ByRef ID_COMUNICACION_BAJA_ As String, ByRef ID_COMUNICACION_BAJA_CDR As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_XML_Comunicacion_Baja(TipoDoc, SerieDoc, NumDoc, Ruta_FE() & "\InputXML", Fecha_baja, ID_COMUNICACION_BAJA_, ID_COMUNICACION_BAJA_CDR) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_cancelar_anulacion.Click
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

    End Sub

    Private Sub btn_crear_planilla_Click(sender As Object, e As EventArgs) Handles btn_crear_planilla.Click

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

    Private Sub cboOpcionTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOpcionTipoDoc.SelectedIndexChanged
        'If cboOpcionTipoDoc.Text = String.Empty Then Exit Sub
        'If flag_inicio = True Then
        '    DocumentosFactura()
        'End If
        DocumentosFactura()
    End Sub

    Private Sub txtdescripcionArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdescripcionArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If
    End Sub

    Private Sub btn_cancelar_nuevo_cliente_Click(sender As Object, e As EventArgs) Handles btn_cancelar_nuevo_cliente.Click
        panel_cliente_nuevo.Visible = False
        GbCabecera.Enabled = True
        gbdetalle.Enabled = True
        gbOpciones.Enabled = True
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
                MsgBox("Debe elegir una Forma de Pago.", MsgBoxStyle.Exclamation)
                txt_cod_forma_pago.Focus()
                Exit Sub

            ElseIf txt_cod_vendedor.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe elegir un Vendedor.", MsgBoxStyle.Exclamation)
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

    Private Sub txt_ruc_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_ruc_dni.TextChanged
        txt_cod_cliente.Text = txt_ruc_dni.Text
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

    Private Sub txt_cod_departamento_TextChanged(sender As Object, e As EventArgs) Handles txt_cod_departamento.TextChanged
        txt_ubigeo.Text = txt_cod_departamento.Text + txt_cod_provincia.Text + txt_cod_distrito.Text
    End Sub

    Private Sub txt_cod_provincia_TextChanged(sender As Object, e As EventArgs) Handles txt_cod_provincia.TextChanged
        txt_ubigeo.Text = txt_cod_departamento.Text + txt_cod_provincia.Text + txt_cod_distrito.Text
    End Sub

    Private Sub txt_cod_distrito_TextChanged(sender As Object, e As EventArgs) Handles txt_cod_distrito.TextChanged
        txt_ubigeo.Text = txt_cod_departamento.Text + txt_cod_provincia.Text + txt_cod_distrito.Text
    End Sub

    Private Sub txt_cod_departamento_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_departamento.MouseDoubleClick
        txt_cod_departamento.Text = String.Empty
        Cargar_Departamento_direc_entrega()
    End Sub

    Private Sub txt_cod_provincia_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_provincia.MouseDoubleClick
        txt_cod_provincia.Text = String.Empty
        Cargar_Provincia_direcc_entrega()
    End Sub

    Private Sub txt_cod_distrito_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_distrito.MouseDoubleClick
        txt_cod_distrito.Text = String.Empty
        Cargar_Distrito_direc_entrega()
    End Sub

    Private Sub txt_ruc_dni_Leave(sender As Object, e As EventArgs) Handles txt_ruc_dni.Leave

    End Sub

    Private Sub txt_observaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_observaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_agregar_carrito_Click(sender, e)
        End If
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

    Private Sub txtdescuento1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuento1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdescuento1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdescuento1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_observaciones.Focus() 'btn_agregar_carrito_Click(sender, e)
        End If
    End Sub
End Class