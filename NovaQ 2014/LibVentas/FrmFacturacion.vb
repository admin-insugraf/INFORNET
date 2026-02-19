Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing
Imports LibSeguridad.ClsUsuario
Imports System.Collections.Specialized
Imports System.IO
Imports LibBillService.Process


Public Class FrmFacturacion
    Dim dtDatosCompany As DataTable
    Dim total_soles As Double
    Dim total_dolares As Double
    Dim contador_doc_vencidos As Integer
    Dim _FECHA_REFERENCIA As String = String.Empty
    Dim _cliente_retenedor As String = ""

    Public dtUsuarioAcceso As DataTable
    Public ClsUsuarioBl As LibSeguridad.ClsUsuario
    Public ClsData As LibConexion.ClsData
    Dim _VALIDA_STOCK As Boolean = False

    Dim clsBuscarBl As ClsBuscar
    Private cProcesosbL As ClsProcesos
    Private cConsultabL As ClsConsultas
    ' Private clsFacturaBl As ClsOperaciones.RECEIVABLE
    Private clsFacturaBl As ClsNegocio.RECEIVABLE

    Private dtDocumentoFactura As DataTable
    Public CodigoVendedor As String = String.Empty
    Public DescripcionVendedor As String = String.Empty

    Dim Flag_Verificar As Boolean = False
    Dim Modo_consultar As Boolean = False
    Dim Modo_editar As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim STRordenCliente As String = String.Empty
    Dim STRordenPedido As String = String.Empty
    Dim STRordenDevol As String = String.Empty

    Dim edicion As Boolean = False
    Public dtdetalleArticuloPrincipal As DataTable
    Dim Fl_close As Boolean = False
    Dim Fl_NC_REF As Boolean = False

    Dim cabeceraBE_rb As LibCobranzas.ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS
    Dim detalleBE_rb As LibCobranzas.ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE
    Dim ls_det_rb As List(Of LibCobranzas.ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE)

    Dim _DT_SALDO_INICIAL As DataTable
    Dim _SALDO_INICIAL As Double = 0.0
    Dim _FLAG_INICIAL As Boolean = False
    Dim FLAG_CLIENTE As String
    Dim _ARTS_INICIALES As String = String.Empty
    Dim _CANT_INICIALES As Double = 0.0

    Dim TIPO_DEV, NUM_DEV, POSICION_DEV As String

    Dim NumeracionGuiaRemision, NumeracionFacturacion, NumeracionFacturaNotac, NumeracionFacturaNotaD, NumeracionFacturaCP As String
    Dim Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, ref_fecha_doc, Ref_ALMACEN As String
    Dim Ref_GUIA_DOCUMENT_ID, Ref_GUIA_NUMBER_SERIE, Ref_GUIA_NUMBER_DOCUMENT As String
    Dim Ref_CP_DOCUMENT_ID, Ref_CP_NUMBER_SERIE, Ref_CP_NUMBER_DOCUMENT As String

    Dim Flag_ComprobPerc As Boolean = False
    Dim Flag_Detraccion As Boolean = False

    Dim indicadorG As Boolean = True

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
    Dim dtDetalleFact As DataTable
    Dim dtValidacion As DataTable
    Dim _GENERA_DETRACCION As String
    Dim _GENERA_FACTURA_ELECTRONICA As String
    Dim _GENERA_GUIA_ELECTRONICA As String
    Dim _GENERA_COMP_PER As String
    Dim _GENERA_ESTADO_CUENTA As String
    Dim po_TasaIgv As Double
    Dim Igv As Double = 0.0

    Dim ListaDatosArticulo As New List(Of StructuraPart)
    Dim ListaCompleta As New List(Of StructuraPart)

    Dim Dt_principal_lista_Doc_Ref As DataTable
    Public IGV_POR_ITEM As Double
    Dim flag_inicio As Boolean

    Private mySetting As NameValueCollection
    Dim ID_COMUNICACION_BAJA_ As String
    Dim ID_COMUNICACION_BAJA_CDR As String


    Public Sub GenerarColummnaDataTable_Documento_Referencia()
        Try
            Dt_principal_lista_Doc_Ref = New DataTable
            Dt_principal_lista_Doc_Ref.Columns.Add("TIPO_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("SERIE_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("NUM_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("FECHA_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("MONTO", Type.GetType("System.Double"))
            Dt_principal_lista_Doc_Ref.Columns.Add("IGV", Type.GetType("System.Double"))
            dgv_Lista_Doc_Ref.DataSource = Nothing
            dgv_Lista_Doc_Ref.DataSource = Dt_principal_lista_Doc_Ref
            dgv_Lista_Doc_Ref.Columns(0).HeaderText = "T. Doc."
            dgv_Lista_Doc_Ref.Columns(1).HeaderText = "S. Doc"
            dgv_Lista_Doc_Ref.Columns(2).HeaderText = "N° Doc."
            dgv_Lista_Doc_Ref.Columns(3).HeaderText = "F. Doc."
            dgv_Lista_Doc_Ref.Columns(4).HeaderText = "Monto"
            dgv_Lista_Doc_Ref.Columns(5).HeaderText = "Igv"
            dgv_Lista_Doc_Ref.AutoResizeColumns()
            dgv_Lista_Doc_Ref.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
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
                        dgvDocumentosFactura.Columns("COD_ALMACEN").Visible = False
                        dgvDocumentosFactura.Columns("MOTIVO.BAJA").Width = 250
                        dgvDocumentosFactura.Columns("MOTIVO.BAJA").HeaderText = "Motivo Baja"
                        dgvDocumentosFactura.Columns("SINCRONIZADO").HeaderText = "Sincronizado PDF"
                        dgvDocumentosFactura.Columns("SINCRONIZADO_XML").HeaderText = "Sincronizado XML"

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
                        dgvDocumentosFactura.Columns("COD_ALMACEN").Visible = False
                        dgvDocumentosFactura.Columns("MOTIVO.BAJA").Width = 250
                        dgvDocumentosFactura.Columns("MOTIVO.BAJA").HeaderText = "Motivo Baja"
                        dgvDocumentosFactura.Columns("SINCRONIZADO").HeaderText = "Sincronizado PDF"
                        dgvDocumentosFactura.Columns("SINCRONIZADO_XML").HeaderText = "Sincronizado XML"

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
                dtDocumentoFactura = clsFacturaBl.get_DatosGeneralesFacturacion(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
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
                    dgvDocumentosFactura.Columns("COD_ALMACEN").Visible = False
                    dgvDocumentosFactura.Columns("MOTIVO.BAJA").Width = 250
                    dgvDocumentosFactura.Columns("MOTIVO.BAJA").HeaderText = "Motivo Baja"
                    dgvDocumentosFactura.Columns("SINCRONIZADO").HeaderText = "Sincronizado PDF"
                    dgvDocumentosFactura.Columns("SINCRONIZADO_XML").HeaderText = "Sincronizado XML"

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

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btn_sincronizar_cpe.Enabled = False
            btn_descargar_archivos.Enabled = False
            'btn_descargar_archivos.Visible = False
            btn_act_vendedor.Enabled = False
            btn_enviar_mail.Enabled = False
            If Modo_consultar = True Then
                btnGrabar.Enabled = False
                btnImprimir.Enabled = True
            Else
                btnImprimir.Enabled = False
                btnGrabar.Enabled = True
            End If
            If Modo_editar = True Then btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnAnular.Enabled = False
            btnConsultar.Enabled = False
            btn_modificar.Enabled = False
            btnCancelar.Enabled = True
            'btnImprimir.Enabled = False
            lblCantidad.Visible = False
            btnContabilizar.Enabled = False
            btn_consultando.Enabled = False
        Else
            btnNuevo.Enabled = True
            btn_sincronizar_cpe.Enabled = True
            btn_descargar_archivos.Enabled = True
            'btn_descargar_archivos.Visible = True
            btn_act_vendedor.Enabled = True
            btn_enviar_mail.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnAnular.Enabled = True
            btnConsultar.Enabled = True
            btn_modificar.Enabled = True
            btnCancelar.Enabled = False
            'btnImprimir.Enabled = True
            lblCantidad.Visible = True
            btnContabilizar.Enabled = True
            btn_consultando.Enabled = True
        End If
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
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
            dtdetalleArticuloPrincipal.Columns.Add("IGV_POR", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("OBSERVACIONES", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("ITEM_GUIA_VENTA", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("NUM_GUIA_VENTA", Type.GetType("System.String"))
            If rb_facturar_devolucion.Checked Then
                dtdetalleArticuloPrincipal.Columns.Add("ITEM_INI", Type.GetType("System.String"))
            End If
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvDetalle.Columns(0).HeaderText = "Item"
            dgvDetalle.Columns(1).HeaderText = "Codigo"
            dgvDetalle.Columns(2).HeaderText = "Cantidad"
            dgvDetalle.Columns(3).HeaderText = "Unidad"
            dgvDetalle.Columns(4).HeaderText = "Descripcion"
            dgvDetalle.Columns(5).HeaderText = "Lote"
            dgvDetalle.Columns(5).Visible = False
            dgvDetalle.Columns(6).HeaderText = "Precio.Unitario"
            dgvDetalle.Columns(7).HeaderText = "%.Desc.Articulo.1"
            dgvDetalle.Columns(8).HeaderText = "%.Desc.Articulo.2"
            dgvDetalle.Columns(9).HeaderText = "Valor Venta"
            dgvDetalle.Columns(10).HeaderText = "Importe.desc.1"
            dgvDetalle.Columns(11).HeaderText = "Importe.desc.2"
            dgvDetalle.Columns(12).Visible = False
            dgvDetalle.Columns(13).Visible = False
            dgvDetalle.Columns(14).Visible = False
            dgvDetalle.Columns(15).Visible = False
            dgvDetalle.Columns(16).Visible = False
            dgvDetalle.Columns(17).Visible = False
            dgvDetalle.Columns(18).HeaderText = "% I.G.V"
            dgvDetalle.Columns(19).HeaderText = "Observaciones"
            dgvDetalle.Columns(20).HeaderText = "Item. G.V."
            dgvDetalle.Columns(21).HeaderText = "N° G.V."
            If rb_facturar_devolucion.Checked Then
                dgvDetalle.Columns(22).Visible = False
            End If

            dgvDetalle.Columns("PREC_UNITARIO").DefaultCellStyle.Format = "##,##0.000000"
            dgvDetalle.Columns("%DESC.ART_1").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns("%DESC.ART_2").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns("VALOR_VENTA").DefaultCellStyle.Format = "##,##0.000000"
            dgvDetalle.Columns("IMP_DESC_01").DefaultCellStyle.Format = "##,##0.0000"
            dgvDetalle.Columns("IMP_DESC_02").DefaultCellStyle.Format = "##,##0.0000"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Nuevo()
        Try
            pnlPrincipal.Visible = False
            panel_estado_cuenta.Visible = False
            gbTipoFacturacion.Visible = True
            gbTipoFacturacion.Enabled = True
            rbFacturaDirecta.Checked = True
            rbDocRef_uno.Checked = True
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
            GbdetalleDocumento.Visible = False
            txtPtoVenta.Enabled = True
            ' gbGenerarCP.Visible = False
            btnGenerarCP.Visible = False
            Limpiar()
            GenerarColummnaDataTable()
            GenerarColummnaDataTable_Documento_Referencia()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Modo_consultar = False
        Modo_editar = False
        Botonera_Estado_Cambiar(True)
        Flag_Verificar = True
        Nuevo()
        Flag_Verificar = False
        txtPtoVenta.Select()
    End Sub

    Private Function MostrarModoConsultar(ByVal DOCUMENT_ID As String, ByVal NUMBER_SERIE As String, ByVal NUMBER_DOCUMENT As String) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtCabeceraFact = New DataTable
            dtDetalleFact = New DataTable
            Dim FLAG_SIN_GUIAS As Boolean = False
            Ref_GUIA_DOCUMENT_ID = ""
            Ref_GUIA_NUMBER_SERIE = ""
            Ref_GUIA_NUMBER_DOCUMENT = ""
            Ref_ALMACEN = ""
            Ref_CP_DOCUMENT_ID = ""
            Ref_CP_NUMBER_SERIE = ""
            Ref_CP_NUMBER_DOCUMENT = ""
            'Limpiar()
            chkSinIGV.Checked = True 'Precio_Con_Sin_IGV()
            '---Mostrando Datos de Cabecera
            dtCabeceraFact = clsFacturaCabBl.get_CabecearaFacturacion(DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT)
            If dtCabeceraFact.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraFact.Rows.Count() - 1
                    txtPtoVenta.Text = dtCabeceraFact.Rows(i).Item("PLACE_SALES").ToString
                    Ref_ALMACEN = dtCabeceraFact.Rows(i).Item("WAREHOUSE_ID").ToString
                    cboMoneda.SelectedValue = dtCabeceraFact.Rows(i).Item("CURRENCY_ID").ToString
                    txtTipoCambio.Text = dtCabeceraFact.Rows(i).Item("SELL_RATE").ToString
                    dtpFechaFactura.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_DATE").ToString

                    txt_forma_de_pago.Text = dtCabeceraFact.Rows(i).Item("FORMA_DE_PAGO").ToString
                    txt_forma_de_pago2.Text = dtCabeceraFact.Rows(i).Item("FORMA_DE_PAGO").ToString

                    If dtCabeceraFact.Rows(i).Item("FECHA_TRASLADO").ToString = "" Then
                        dtp_fecha_traslado.Value = Date.Today
                    Else
                        dtp_fecha_traslado.Text = dtCabeceraFact.Rows(i).Item("FECHA_TRASLADO").ToString
                    End If

                    cboSerieDoc.Text = dtCabeceraFact.Rows(i).Item("NUMBER_SERIE").ToString
                    txt_nro_entrega.Text = dtCabeceraFact.Rows(i).Item("NUM_LICITACION").ToString
                    txt_ref_guia_Devolucion.Text = dtCabeceraFact.Rows(i).Item("NUM_GUIA_DEVOLUCION").ToString

                    txt_emp_trans_manual.Text = dtCabeceraFact.Rows(i).Item("DESC_TRANSPORTISTAS_DESPACHOS").ToString
                    txt_trans_manual_despacho.Text = dtCabeceraFact.Rows(i).Item("ID_TRANSPORTISTAS").ToString
                    txt_datos_vehiculo.Text = dtCabeceraFact.Rows(i).Item("DATOS_VEHICULO").ToString

                    FLAG_SIN_GUIAS = Not dtCabeceraFact.Rows(i).Item("IS_GUIA")

                    'If Modo_editar Then
                    '    If DOCUMENT_ID = "NC" Or DOCUMENT_ID = "ND" Then
                    '        clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
                    '        GenerarColummnaDataTable_Documento_Referencia()
                    '        'Dt_principal_lista_Doc_Ref = clsFacturaCabBl.Documentos_Referencia_NotaC(DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT)
                    '        'If Dt_principal_lista_Doc_Ref.Rows.Count() <> 0 Then
                    '        '    dgv_Lista_Doc_Ref.DataSource = Dt_principal_lista_Doc_Ref
                    '        '    rbDocRef_varios.Checked = True
                    '        'End If
                    '    End If
                    'End If
                    txttipoDocRef.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_REF").ToString
                    txtNumDocRef.Text = dtCabeceraFact.Rows(i).Item("NUMBER_REF").ToString
                    txtSerieDocRef.Text = dtCabeceraFact.Rows(i).Item("SERIE_REF").ToString
                    _FECHA_REFERENCIA = dtCabeceraFact.Rows(i).Item("DATE_REF").ToString
                    txtCodCliente.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRucDni.Text = dtCabeceraFact.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtRazonSocial.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtDireccion.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ADDR").ToString
                    txtVendedor.Text = dtCabeceraFact.Rows(i).Item("SALES_REP_ID").ToString
                    txtFormaPago.Text = dtCabeceraFact.Rows(i).Item("TERMS_ID").ToString
                    txtModoPago.Text = dtCabeceraFact.Rows(i).Item("CODIGO_MODO_PAGO").ToString
                    lblModoPago.Text = dtCabeceraFact.Rows(i).Item("NOMBRE_MODO_PAGO").ToString
                    txtcotizacion.Text = ""
                    txtordenCompra.Text = dtCabeceraFact.Rows(i).Item("NUMBER_ORDER_PUR").ToString
                    txtpedido.Text = dtCabeceraFact.Rows(i).Item("NUMBER_ORDER").ToString
                    cboMoneda.SelectedValue = dtCabeceraFact.Rows(i).Item("CURRENCY_ID").ToString
                    cbSerieGuia.SelectedValue = dtCabeceraFact.Rows(i).Item("SERIE_REF").ToString
                    txtCodTrans.Text = ""
                    cboDirEntrega.Text = ""
                    'Datos del documento de Facturacion
                    txtdetalledoc.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_ID").ToString()
                    txtdetalleserie.Text = dtCabeceraFact.Rows(i).Item("NUMBER_SERIE").ToString()
                    txtdetallenumero.Text = dtCabeceraFact.Rows(i).Item("NUMBER_DOCUMENT").ToString()
                    ''Documento de referencia del Comprobante de percepcion
                    If Modo_editar Then
                        Ref_CP_DOCUMENT_ID = dtCabeceraFact.Rows(i).Item("DOCUMENT_TYPE_COMP_PER").ToString
                        Ref_CP_NUMBER_SERIE = dtCabeceraFact.Rows(i).Item("SERIE_COMP_PER").ToString
                        Ref_CP_NUMBER_DOCUMENT = dtCabeceraFact.Rows(i).Item("NUMBER_COMP_PER").ToString
                    End If
                    txtcodigoCP.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_TYPE_COMP_PER").ToString
                    txtSerieCP.Text = dtCabeceraFact.Rows(i).Item("SERIE_COMP_PER").ToString
                    txtNumeroCP.Text = dtCabeceraFact.Rows(i).Item("NUMBER_COMP_PER").ToString
                    txtGlosa.Text = dtCabeceraFact.Rows(i).Item("COMMENT").ToString

                    txt_vehiculo.Text = dtCabeceraFact.Rows(i).Item("VEHICULO_ID").ToString
                    txt_Empresa.Text = dtCabeceraFact.Rows(i).Item("EMPTRA_ID").ToString
                    txt_trama.Text = dtCabeceraFact.Rows(i).Item("TRAMA_ID").ToString

                    If CDbl(dtCabeceraFact.Rows(i).Item("AMOUNT_TAX").ToString) = 0 Then
                        IGV_POR_ITEM = 0
                    Else
                        'clsIgvArticuloBL = New ClsTransacciones.clsPedidos
                        'dtIgvArticulo = New DataTable("IGV_SISTEMA")
                        po_TasaIgv = 0.0
                        'dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvsSistema()
                        po_TasaIgv = CDbl(dtCabeceraFact.Rows(i).Item("po_TasaIgv").ToString)
                        IGV_POR_ITEM = po_TasaIgv
                    End If


                    If String.IsNullOrEmpty(dtCabeceraFact.Rows(i).Item("MOV_OPTION_ID").ToString) Then
                        For Each Control As Control In gbTipoFacturacion.Controls
                            If TypeOf Control Is RadioButton Then
                                CType(Control, RadioButton).Checked = False
                            End If
                        Next
                    Else
                        For Each Control As Control In gbTipoFacturacion.Controls
                            If TypeOf Control Is RadioButton Then
                                If dtCabeceraFact.Rows(i).Item("MOV_OPTION_ID").ToString = CType(Control, RadioButton).Text Then
                                    CType(Control, RadioButton).Checked = True
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                    ''Documento de Referencia de la Facturacion
                    If txtdetalledoc.Text <> "CP" Then 'txtdetalledoc.Text = "FT" Then
                        'Dim GuiaBl As New ClsBuscar
                        'Dim dtDatosGuia As New DataTable
                        'dtDatosGuia = GuiaBl.Get_GuiasAsociadas(Ref_ALMACEN, txtdetalleserie.Text & txtdetallenumero.Text, txtdetalledoc.Text)
                        'If dtDatosGuia.Rows.Count() <> 0 Then
                        'If Modo_editar = True Then
                        '    Ref_GUIA_DOCUMENT_ID = dtDatosGuia.Rows(i).Item("DOCUMENT_ID").ToString()
                        '    Ref_GUIA_NUMBER_SERIE = Strings.Left(dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT"), 3)
                        '    If dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT").Length() > 0 Then
                        '        Ref_GUIA_NUMBER_DOCUMENT = Strings.Right(dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT"), dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT").Length() - 3)
                        '    Else
                        '        Ref_GUIA_NUMBER_DOCUMENT = ""
                        '    End If
                        'End If
                        'If Modo_consultar Then
                        '    txtdetalleguiadoc.Text = dtDatosGuia.Rows(i).Item("DOCUMENT_ID").ToString()
                        '    txtdetalleguiaserie.Text = Strings.Left(dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT"), 3)
                        '    If dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT").Length() > 0 Then
                        '        txtdetalleguianumero.Text = Strings.Right(dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT"), dtDatosGuia.Rows(i).Item("NUMBER_DOCUMENT").Length() - 3)
                        '    Else
                        '        txtdetalleguianumero.Text = ""
                        '    End If
                        'End If
                        If Not String.IsNullOrEmpty(dtCabeceraFact.Rows(i).Item("INTERFACE").ToString) Then
                            If dtCabeceraFact.Rows(0).Item("INTERFACE").ToString = "0" Then
                                rbunalinea.Checked = True
                            Else
                                rbunalinea.Checked = False
                                rbVariaslineas.Checked = True
                            End If
                        End If
                        txtdetalleguiadoc.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_REF").ToString
                        txtdetalleguiaserie.Text = dtCabeceraFact.Rows(i).Item("SERIE_REF").ToString
                        txtdetalleguianumero.Text = dtCabeceraFact.Rows(i).Item("NUMBER_REF").ToString

                        txtGlosaGuia.Text = dtCabeceraFact.Rows(i).Item("GLOSA_GUIA").ToString
                        cboDirEntrega.DataSource = Nothing
                        cboDirEntrega.Items.Clear()
                        cboDirEntrega.Items.Add(dtCabeceraFact.Rows(i).Item("ADDR_DLV").ToString)
                        cboDirEntrega.SelectedIndex = 0
                        txtCodTrans.Text = dtCabeceraFact.Rows(i).Item("CARRIER_ID").ToString
                        txtNomTrans.Text = dtCabeceraFact.Rows(i).Item("CARRIER_NAME").ToString
                        'End If
                    ElseIf txtdetalledoc.Text = "CP" Then
                        txtcodigoCP.Text = String.Empty
                        txtSerieCP.Text = String.Empty
                        txtNumeroCP.Text = String.Empty
                    End If


                    If dtCabeceraFact.Rows(i).Item("MOV_OPTION_ID").ToString = "Guia por Facturar" Then
                        'Dim GuiaBl As New ClsBuscar
                        'Dim dtDatosGuia As New DataTable
                        'dtDatosGuia = GuiaBl.Get_Guias_Venta(Ref_ALMACEN, txtdetalleserie.Text & txtdetallenumero.Text, txtdetalledoc.Text)
                        'If dtDatosGuia.Rows.Count > 0 Then
                        NumerosDocClientes = ""
                        txtNumDocRef.Text = ""
                        'For x As Integer = 0 To dtDatosGuia.Rows.Count - 1
                        '    txtNumDocRef.Text += "GS-" & dtDatosGuia.Rows(x).Item("NUMBER_DOCUMENT").ToString.Trim & ","
                        '    NumerosDocClientes = NumerosDocClientes & """" & dtDatosGuia.Rows(x).Item("NUMBER_DOCUMENT").ToString.Trim & """" & ","
                        'Next

                        txtNumDocRef.Text = dtCabeceraFact.Rows(i).Item("LIST_GUIA").ToString 'Mid(txtNumDocRef.Text, 1, txtNumDocRef.Text.Trim.Length - 1)
                        NumerosDocClientes = dtCabeceraFact.Rows(i).Item("LIST_GUIA").ToString 'Mid(NumerosDocClientes, 1, NumerosDocClientes.Trim.Length - 1)

                        'End If
                    End If

                    'Mostrando Descripcion de la cabecera
                    If txtPtoVenta.Text <> String.Empty Then
                        'clsBuscarBl = New ClsBuscar
                        'Dim dtDatos As New DataTable
                        'dtDatos = clsBuscarBl.Get_NombrePuntoVenta(txtPtoVenta.Text)
                        'If dtDatos.Rows.Count() <> 0 Then
                        lblPtoVenta.Text = dtCabeceraFact.Rows(i).Item("SALES_PLACE_DESCRIPTION").ToString
                        txtAlmacen.Text = dtCabeceraFact.Rows(i).Item("WAREHOUSE_ID").ToString
                        lblAlmacen.Text = dtCabeceraFact.Rows(i).Item("NOMBRE_ALMACEN").ToString
                        'Mostrando el tipo Doc asociado a Pnto venta
                        'Ayuda_TipoDocPuntoVenta()
                        cboTipoDoc.Text = dtCabeceraFact.Rows(i).Item("DOCUMENT_ID").ToString
                        'Mostrando la serie
                        'Ayuda_SerieGuiaPuntoVenta()
                        'If cboTipoDoc.Text = String.Empty Then Exit Sub
                        'SerieDocumentoPuntoVenta()
                        cboSerieDoc.Text = dtCabeceraFact.Rows(i).Item("NUMBER_SERIE").ToString
                        'End If
                    End If
                    If txtCodCliente.Text <> String.Empty Then
                        txtCodCliente.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ID").ToString
                        txtRazonSocial.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_NAME").ToString
                        txtRucDni.Text = dtCabeceraFact.Rows(i).Item("VAT_REGISTRATION").ToString
                        txtDireccion.Text = dtCabeceraFact.Rows(i).Item("CUSTOMER_ADDR").ToString
                        If txtFormaPago.Text = String.Empty Then
                            lblFormaPago.Text = ""
                        Else
                            lblFormaPago.Text = dtCabeceraFact.Rows(i).Item("NOMBRE_FORMA_PAGO").ToString
                        End If

                        If txtVendedor.Text <> String.Empty Then
                            lblVendedor.Text = dtCabeceraFact.Rows(i).Item("NOMBRE_VENDEDOR").ToString
                        Else
                            lblVendedor.Text = ""
                        End If

                    End If
                Next
                '---Mostrando datos del Detalle
                clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsFacturaCabBl.get_DetalleFacturacion(DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT)
                If txtdetalledoc.Text <> "CP" Then
                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                        dgvDetalle.AutoResizeColumns()
                        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        'chkSinIGV.Checked = True
                        If Modo_consultar = True Then
                            Mostrando_Totales_Generales()
                        End If
                        If Modo_editar = True Then
                            Calcular_Totales()
                        End If
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
                If Modo_consultar = True Then
                    txtIgv.Text = Format(Double.Parse(dtCabeceraFact.Rows(0).Item("AMOUNT_TAX").ToString), "##,##0.00")
                    txtPrecioVenta.Text = Format(Double.Parse(dtCabeceraFact.Rows(0).Item("AMOUNT").ToString), "##,##0.00")
                End If
            End If
            checkSinGuia.Checked = FLAG_SIN_GUIAS
            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvDocumentosFactura.RowCount() = 0 Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Modo_editar = False
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        'Mostrando resultados
        If MostrarModoConsultar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) Then
            pnlPrincipal.Visible = False
            GbCabecera.Enabled = False
            gbdetalle.Enabled = True
            gbOpciones.Enabled = False
            btn_cliente_nuevo.Visible = False
            GbdetalleDocumento.Visible = True
            Call Botonera_Estado_Cambiar(True)
        End If


        'If Ref_DOCUMENT_ID <> "CP" Then
        '    cabeceraBL = New ClsOperaciones.RECEIVABLE
        '    dtVerificar = New DataTable("ComprobanteP")
        '    dtVerificar = cabeceraBL.get_VerificacionComprobanteP(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
        '    If dtVerificar.Rows.Count() <> 0 Then
        '        btnGenerarCP.Visible = False
        '    Else
        '        btnGenerarCP.Visible = True
        '    End If
        'Else
        '    btnGenerarCP.Visible = False
        '    btnDespacho.Visible = False
        'End If
        'Dim Estado As String = String.Empty
        'Estado = dgvDocumentosFactura.Item(6, dgvDocumentosFactura.CurrentRow.Index).Value
        'If Estado <> "ANULADO" Then
        '    'Verificando si posee despacho
        '    clsFacturaBl = New ClsNegocio.RECEIVABLE
        '    dtVerificar = New DataTable("Despacho")
        '    dtVerificar = clsFacturaBl.VerificarDespacho(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
        '    If dtVerificar.Rows.Count() <> 0 Then
        '        btnDespacho.Visible = False
        '    Else
        '        btnDespacho.Visible = False
        '        lblDespachoNumero.Text = String.Empty
        '        lblDespachoNumero.Text = Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & " - " & Ref_NUMBER_DOCUMENT
        '    End If
        'End If
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
            Dim frmTipoNum As New FrmTipoNumeracionRapido
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
            Dim frmTipoNum As New FrmTipoNumeracionRapido
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
            Dim frmTipoNum As New FrmTipoNumeracionRapido
            frmTipoNum.Serie = cboSerieDoc.Text
            frmTipoNum.TipoDocumento = cboTipoDoc.Text '"NC"
            'frmTipoNum.Serie = cboSerieDoc.Text
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
            Dim frmTipoNum As New FrmTipoNumeracionRapido
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
            Dim frmTipoNum As New FrmTipoNumeracionRapido
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
            Dim frmTipoNum As New FrmTipoNumeracionRapido
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
                ' txtNumDocRef.ReadOnly = True
            Else
                cboTipoDoc.Select()
                'txtNumDocRef.ReadOnly = False
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
                .NUM_GUIA_REF_DEVOLUCION = txt_ref_guia_Devolucion.Text.Trim
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
                .RECEIVABLE_TYPE = IIf(rb_facturar_obsequio.Checked Or rb_facturar_obsequio_sin_pedido.Checked, "FO", cboTipoDoc.Text)
                .CUSTOMER_ID = txtCodCliente.Text.Trim
                .CUSTOMER_NAME = txtRazonSocial.Text.Trim
                .CUSTOMER_ADDR = txtDireccion.Text.Trim
                .VAT_REGISTRATION = txtRucDni.Text.Trim
                .WAREHOUSE_ID = txtAlmacen.Text
                .AMOUNT = txtPrecioVenta.Text
                .TERMS_ID = txtFormaPago.Text.Trim
                .MODO_PAGO = txtModoPago.Text.Trim
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
                        .FECHA_REFERENCIA = _FECHA_REFERENCIA
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
                .FORMA_DE_PAGO = txt_forma_de_pago2.Text.Trim
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
                .NUM_LICITACION = txt_nro_entrega.Text.Trim
                .FECHA_TRASLADO = dtp_fecha_traslado.Value.ToString("dd/MM/yyyy")

                .TIPO_NOTA_ELECTRONICA = txt_cod_tipo_nota_electronica.Text.Trim
                .DESCRIPCION_TIPO_NOTA_ELECTRONICA = txt_desc_tipo_nota_electronica.Text.Trim
                .EMAIL_CLIENTE = txt_email_cliente.Text.Trim

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
                    If IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_GUIA_VENTA")) Then
                        .ITEM_GUIA_VENTA = 0
                        'ElseIf dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_GUIA_VENTA") = "" Then
                        '    .ITEM_GUIA_VENTA = 0
                    Else
                        .ITEM_GUIA_VENTA = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_GUIA_VENTA")
                    End If

                    If IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("NUM_GUIA_VENTA")) Then
                        .NUM_GUIA_VENTA = ""
                        'ElseIf dtdetalleArticuloPrincipal.Rows(i).Item("NUM_GUIA_VENTA") = "" Then
                        '    .NUM_GUIA_VENTA = ""
                    Else
                        .NUM_GUIA_VENTA = dtdetalleArticuloPrincipal.Rows(i).Item("NUM_GUIA_VENTA")
                    End If

                End With
                ls_det.Add(detalle)
            Next
            'CLIENTES
            If rb_facturar_obsequio.Checked = False And rb_facturar_obsequio_sin_pedido.Checked = False Then
                With carteraBE
                    .CUSTOMER_ID = txtCodCliente.Text.Trim
                    .DOCUMENT_ID = cboTipoDoc.Text
                    .NUMBER_DOC = NumeracionFacturacion
                    .DOC_DATE = CDate(dtpFechaFactura.Text).ToString("dd/MM/yyyy")
                    .CADUCATE_DATE = Get_FormaPagoFechaVencimiento()
                    .DOCUMENT_REF = txttipoDocRef.Text
                    If rbFacturaDirecta.Checked = True Or rb_facturar_obsequio.Checked = True Or rbfacturaExportacion.Checked = True Then
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
                    .AMOUNT_COMM = 0 'cboTipoDoc.SelectedValue().ToString
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

            If rbFacturaDirecta.Checked = True Or rbfacturaExportacion.Checked = True Or rbFacturaExistencias.Checked = True Or rb_facturar_pedido.Checked = True Or rb_facturar_obsequio.Checked = True Or rb_facturar_obsequio_sin_pedido.Checked = True Then
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
                    .TRANS_ID = IIf(rb_facturar_obsequio.Checked Or rb_facturar_obsequio_sin_pedido.Checked, "FO", "FT")
                    .DATE_DOCUMENT = CDate(dtpFechaFactura.Value).ToShortDateString
                    .DOC_ID_REF = txttipoDocRef.Text
                    If rbFacturaDirecta.Checked = True Or rbfacturaExportacion.Checked = True Or rb_facturar_obsequio.Checked = True Or rb_facturar_obsequio_sin_pedido.Checked = True Then
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
                    .FECHA_TRASLADO = dtp_fecha_traslado.Value.ToString("dd/MM/yyyy")
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
            If cabeceraBL.GuardarFactura(cabeceraBE, ls_det, carteraBE, alm_cabBE, ls_det_alm, ls_detalle, cabeceraBE.CURRENCY_ID, CDate(dtpFechaFactura.Value).ToShortDateString, _
                                         TipoNumeracion, cboTipoDoc.Text, IIf(rbFacturaGuiaVenta.Checked = True Or rbFacturaRepMedico.Checked = True, True, False), _
                                         NumerosDocClientes, IIf(rbsinDescargo.Checked = True, True, False), IIf(rb_facturar_pedido.Checked = True Or rb_facturar_obsequio.Checked = True Or rbfacturaExportacion.Checked = True, True, False), _
                                         IIf(Modo_editar = True, True, False), Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, Ref_ALMACEN, _
                                          IIf(rb_facturar_devolucion.Checked = True, True, False), TIPO_DEV, NUM_DEV) = False Then
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
                    .SALES_ID = txtVendedor.Text.Trim
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
                    .FECHA_TRASLADO = dtp_fecha_traslado.Value.ToString("dd/MM/yyyy")
                    .MODALIDAD_TRANSPORTE = IIf(rdb_trans_privado.Checked, rdb_trans_privado.Text, rdb_trans_publico.Text)
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
                        .OBSERVACIONES = dtdetalleArticuloPrincipal.Rows(i).Item("OBSERVACIONES").ToString
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
            'End If
            'If cboTipoDoc.Text = "FT" Then
            'msj = "Documento Generado Correctamente," & vbCrLf & " Nro Documento: " & cboTipoDoc.Text & " - " & NumeracionFacturacion
            'MsgBox(msj, MsgBoxStyle.Information)
            'ElseIf cboTipoDoc.Text = "NC" Then
            '    msj = "Nueva Nota de Credito Generado Correctamente," & vbCrLf & " Nro Documento: NC- " & cboSerieDoc.Text & NumeracionFacturaNotac
            '    MsgBox(msj, MsgBoxStyle.Information)
            'ElseIf cboTipoDoc.Text = "ND" Then
            '    msj = "Nueva Nota de Debito Generado Correctamente," & vbCrLf & " Nro Documento: ND- " & cboSerieDoc.Text & NumeracionFacturaNotaD
            '    MsgBox(msj, MsgBoxStyle.Information)
            'End If
            'If rbFacturaDirecta.Checked = True Then
            'If checkSinGuia.Checked = False Then
            '    If indicadorG = True Then
            '        msj = String.Empty
            '        msj = "Nueva Guia de Salida Generado Correctamente," & vbCrLf & " Nro Documento: GS-" & NumeracionGuiaRemision
            '        MsgBox(msj, MsgBoxStyle.Information)
            '    End If
            'End If
            'End If
            'If Flag_ComprobPerc = True Then
            '    msj = String.Empty
            '    msj = "Nuevo Comprobante de Percepcion Generado Correctamente," & vbCrLf & " Nro Documento: CP-" & NumeracionFacturaCP
            '    MsgBox(msj, MsgBoxStyle.Information)
            'End If
            'If rbDocRef_varios.Checked = True Then Guardar_Detalle_Doc_Referencias()
            'If rb_facturar_devolucion.Checked = True Then Guardar_Detalle_Doc_Referencias()
            'If MessageBox.Show("Se procedera a la Impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '    imprimirFacturacion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturacion, cboMoneda.SelectedValue.ToString, txtIgv.Text, txtPrecioVenta.Text)
            '    If checkSinGuia.Checked = False Then
            '        If indicadorG = True Then
            '            imprimirGuiaRemision(txtAlmacen.Text, "GS", NumeracionGuiaRemision)
            '        End If
            '    End If
            '    'End If
            '    If Flag_ComprobPerc = True Then
            '        imprimirComprobantePercepcion("CP", Strings.Left(NumeracionFacturaCP, 3), Strings.Right(NumeracionFacturaCP, NumeracionFacturaCP.Length() - 3))
            '    End If
            'End If
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
                'RelacionDoc = DtdocReferencia.Rows(0).Item("SERIE_DOC").ToString
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
        dtp_fecha_traslado.Value = Date.Now
        txtCodCliente.Clear()
        txtRucDni.Clear()
        txtRazonSocial.Clear()
        txtDireccion.Clear()
        txtVendedor.Clear()
        txtFormaPago.Clear()
        txtModoPago.Clear()
        txtGlosa.Clear()
        chkSinIGV.Checked = Precio_Con_Sin_IGV()
        chkSinIGV.Visible = True
        chkSinIGV.ForeColor = Color.Navy
        txtvalorVenta.Text = "0.00"
        txtIgv.Text = "0.00"
        txtPrecioVenta.Text = "0.00"
        txtBruto.Text = "0.00"
        txtDescuentos.Text = "0.00"
        lblVendedor.Text = String.Empty
        lblAlmacen.Text = String.Empty
        lblFormaPago.Text = String.Empty
        lblModoPago.Text = String.Empty
        lblPtoVenta.Text = String.Empty
        cboTipoDoc.DataSource = Nothing
        cboSerieDoc.DataSource = Nothing
        txtNumDocRef.Text = String.Empty
        cbSerieGuia.DataSource = Nothing
        txtCodTrans.Text = String.Empty
        txtNomTrans.Text = String.Empty
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
        txt_nro_entrega.Text = String.Empty
        txtSerieCP.Text = String.Empty
        txtNumeroCP.Text = String.Empty
        txtcodigoCP.Text = String.Empty
        rbunalineaDoc.Checked = True
        rbunalinea.Checked = True
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Ref_GUIA_DOCUMENT_ID = ""
        Ref_GUIA_NUMBER_SERIE = ""
        Ref_GUIA_NUMBER_DOCUMENT = ""
        Ref_ALMACEN = ""
        Ref_CP_DOCUMENT_ID = ""
        Ref_CP_NUMBER_SERIE = ""
        Ref_CP_NUMBER_DOCUMENT = ""
        'Modo_consultar = False
        'Modo_editar = False
        _FECHA_REFERENCIA = ""

        TIPO_DEV = ""
        NUM_DEV = ""
        POSICION_DEV = ""

        txt_vehiculo.Text = ""
        txt_Empresa.Text = ""
        txt_trama.Text = ""

        NumerosDocClientes = ""
        txtNumDocRef.Text = ""

        txt_email_cliente.Text = ""
        txt_cod_tipo_nota_electronica.Text = ""
        txt_desc_tipo_nota_electronica.Text = ""
        txt_fecha_ref.Text = ""
        txt_forma_de_pago.Text = ""
        txt_forma_de_pago2.Text = ""
        pnl_forma_de_pago.Visible = False
        btn_detalle_pedido.Visible = False
        rdb_trans_privado.Checked = True
        _cliente_retenedor = ""
    End Sub

    Private Sub MostrarEstadoCuentaCliente(ByVal _Codigo As String)
        Try

            cabeceraBL = New ClsOperaciones.RECEIVABLE
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte

            Me.Cursor = Cursors.WaitCursor
            panel_estado_cuenta.Visible = True
            total_soles = 0
            total_dolares = 0
            txtpassword.Text = ""
            lbltotalsoles.Text = ""
            lbltotaldolares.Text = ""
            lblmensaje.Text = ""
            lblmensajedocvencidos.Text = ""
            dtImprimir = New DataTable("Clientes")
            dtDatosCompany = reporteBL.Obtener_LimiteCredito_Cliente(_Codigo)
            _Codigo = """" & _Codigo & """"
            dtImprimir = cabeceraBL.Get_estadocuentacliente(_Codigo)
            dgv_estado_cuenta_cliente.DataSource = Nothing
            If dtImprimir.Rows.Count() <> 0 Then
                dgv_estado_cuenta_cliente.DataSource = dtImprimir
                dgv_estado_cuenta_cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                Dim rowssoles() As DataRow = dtImprimir.Select("moneda='MN'")
                Dim dtsoles As DataTable = dtImprimir.Clone()
                For Each fila As DataRow In rowssoles
                    dtsoles.ImportRow(fila)
                Next

                Dim rowsdolares() As DataRow = dtImprimir.Select("moneda='ME'")
                Dim dtdolares As DataTable = dtImprimir.Clone()
                For Each fila As DataRow In rowsdolares
                    dtdolares.ImportRow(fila)
                Next
                If dtsoles.Rows.Count > 0 Then
                    total_soles = Math.Round(dtsoles.Compute("Sum(saldo)", "(moneda='MN')"), 4, MidpointRounding.AwayFromZero)
                Else
                    total_soles = 0
                End If

                If dtdolares.Rows.Count > 0 Then
                    total_dolares = Math.Round(dtdolares.Compute("Sum(saldo)", "(moneda='ME')"), 4, MidpointRounding.AwayFromZero)
                Else
                    total_dolares = 0
                End If
                lbltotalsoles.Text = "PENDIENTE TOTAL SOLES: " & CStr(Format(total_soles, "##,##00.00"))
                lbltotaldolares.Text = "PENDIENTE TOTAL DOLARES: " & CStr(Format(total_dolares, "##,##00.00"))
                txtpassword.Select()
            End If
            If dtDatosCompany.Rows.Count() > 0 Then
                lblcreditlimitsoles.Text = "Limite de Credito Soles: " & dtDatosCompany.Rows(0).Item("CREDIT_LIMIT").ToString
                lblcreditlimitdolares.Text = "Limite de Credito Dolares:" & dtDatosCompany.Rows(0).Item("CREDIT_LIMIT_US").ToString
                If total_soles > CDbl(dtDatosCompany.Rows(0).Item("CREDIT_LIMIT").ToString) Or total_dolares > CDbl(dtDatosCompany.Rows(0).Item("CREDIT_LIMIT_US").ToString) Then
                    lblmensaje.Text = "El cliente superó el limite de credito otorgado por la empresa."
                    lblmensaje.ForeColor = Color.Red
                Else
                    lblmensaje.Text = "El cliente no superó el limite de credito otorgado por la empresa."
                    lblmensaje.ForeColor = Color.Blue
                End If
            End If
            Dim valor_dias As String, i As Integer, valos_dias_int As Integer
            contador_doc_vencidos = 0
            For i = 0 To dtImprimir.Rows.Count - 1
                valor_dias = dtImprimir.Rows(i).Item("Dias Vencidos").ToString
                valos_dias_int = Val(Strings.Mid(valor_dias, 2, Strings.Len(valor_dias) - 1))
                If Strings.Left(valor_dias, 1) = "(" And Strings.Right(valor_dias, 1) = ")" Then
                    If valos_dias_int > 8 Then
                        contador_doc_vencidos = contador_doc_vencidos + 1
                    End If
                End If
            Next

            If contador_doc_vencidos > 0 Then
                lblmensajedocvencidos.Text = "El cliente tiene " + CStr(contador_doc_vencidos) + " documentos vencidos."
                lblmensajedocvencidos.ForeColor = Color.Red
            Else
                lblmensajedocvencidos.Text = "El cliente tiene 0 documentos vencidos."
                lblmensajedocvencidos.ForeColor = Color.Blue
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        'Validaciones Generales
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        If ValidacionesGenerales() = False Then Exit Sub
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            If rb_facturar_pedido.Checked Or rb_facturar_obsequio.Checked Or rbfacturaExportacion.Checked Then
                For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                    If String.IsNullOrEmpty(dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString) Then
                        'MessageBox.Show("Falta ingresar el lote a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Exit Sub
                        'ElseIf dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO") = 0 Then
                        '    MessageBox.Show("Falta ingresar el Precio a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    Exit Sub
                    End If
                Next
            Else
                For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                    If dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO") = 0 Then
                        MessageBox.Show("Falta ingresar el Precio a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
            End If

            If rbfacturaExportacion.Checked And cboTipoDoc.Text <> "PF" Then
                For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                    If dtdetalleArticuloPrincipal.Rows(i).Item("IGV_POR") <> 0 Then
                        MessageBox.Show("El comprobante no debe estar afecto al IGV. Verifique!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                        'ElseIf dtdetalleArticuloPrincipal.Rows(i).Item("PREC_UNITARIO") = 0 Then
                        '    MessageBox.Show("Falta ingresar el Precio a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    Exit Sub
                    End If
                Next
            End If
        End If
        clsFacturaBl = New ClsNegocio.RECEIVABLE
        dtValidacion = New DataTable("Validacion")
        dtValidacion = clsFacturaBl.Get_Validacion(cboTipoDoc.Text, cboSerieDoc.Text)
        If dtValidacion.Rows.Count > 0 Then
            _GENERA_ESTADO_CUENTA = dtValidacion.Rows(0).Item("IS_GENERA_ESTADO_CUENTA").ToString
            If _GENERA_ESTADO_CUENTA = "S" Then
                MostrarEstadoCuentaCliente(txtCodCliente.Text)
                Exit Sub
            End If
        End If
        If cboTipoDoc.Text = "FT" Then
            If CodigoNumeraciondocumentoGeneral() = False Then
                MsgBox("Es necesario una Numeracion para la Factura", MsgBoxStyle.Information)
                Exit Sub
            End If
            If checkSinGuia.Checked = False Then
                If CodigoNumeracionGuiaRemision() = False Then
                    MsgBox("Es necesario una Numeracion para la Guia Remision.", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
        Else
            If CodigoNumeraciondocumentoGeneral() = False Then
                MsgBox("Es necesario una Numeracion para el documento a emitir.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If checkSinGuia.Checked = False Then
                If CodigoNumeracionGuiaRemision() = False Then
                    MsgBox("Es necesario una Numeracion para la Guia Remision.", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
        End If
        _GENERA_COMP_PER = ""
        _GENERA_DETRACCION = ""
        _GENERA_FACTURA_ELECTRONICA = ""
        _GENERA_GUIA_ELECTRONICA = ""
        clsFacturaBl = New ClsNegocio.RECEIVABLE
        dtValidacion = New DataTable("Validacion")
        dtValidacion = clsFacturaBl.Get_Validacion(cboTipoDoc.Text, cboSerieDoc.Text)
        If dtValidacion.Rows.Count > 0 Then
            _GENERA_COMP_PER = dtValidacion.Rows(0).Item("IS_GENERA_COMP_PER").ToString
            _GENERA_DETRACCION = dtValidacion.Rows(0).Item("IS_GENERA_DETRACCION").ToString
            _GENERA_FACTURA_ELECTRONICA = dtValidacion.Rows(0).Item("IS_FACTUR_ELECTRONICO").ToString
        End If

        dtValidacion = New DataTable("Validacion")
        dtValidacion = clsFacturaBl.Get_Validacion("GS", cbSerieGuia.Text)
        If dtValidacion.Rows.Count > 0 Then
            _GENERA_GUIA_ELECTRONICA = dtValidacion.Rows(0).Item("IS_FACTUR_ELECTRONICO").ToString
        End If

        If _GENERA_COMP_PER = "S" Then
            '---Comprbante de Percepcion
            If MessageBox.Show("¿Desea Generar Comprobante de Percepcion.?", "Comprobante Percepcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        End If
        If _GENERA_DETRACCION = "S" Then
            '-------Detraccion 
            If MessageBox.Show("¿Documento Sujeto a Detraccion.?", "Detraccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        End If
        Me.Cursor = Cursors.WaitCursor
        If _GENERA_FACTURA_ELECTRONICA = "N" Then
            ToolStrip1.Enabled = False
            If GuardarFacturacion() = True Then

                Dim msj As String = ""
                msj = "Documento Generado Correctamente," & vbCrLf & " Nro Documento: " & cboTipoDoc.Text & " - " & NumeracionFacturacion
                MsgBox(msj, MsgBoxStyle.Information)

                If checkSinGuia.Checked = False Then
                    If indicadorG = True Then
                        msj = String.Empty
                        msj = "Nueva Guia de Salida Generado Correctamente," & vbCrLf & " Nro Documento: GS-" & NumeracionGuiaRemision
                        MsgBox(msj, MsgBoxStyle.Information)
                    End If
                End If

                If MessageBox.Show("Se procedera a la Impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    imprimirFacturacion(cboTipoDoc.Text, cboSerieDoc.Text, NumeracionFacturacion, cboMoneda.SelectedValue.ToString, txtIgv.Text, txtPrecioVenta.Text)
                    If checkSinGuia.Checked = False Then
                        If indicadorG = True Then
                            imprimirGuiaRemision(txtAlmacen.Text, "GS", NumeracionGuiaRemision)
                        End If
                    End If
                End If

                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtValidacion = New DataTable("Validacion")
                dtValidacion = clsFacturaBl.Get_Validacion(cboTipoDoc.Text, cboSerieDoc.Text)
                If dtValidacion.Rows.Count > 0 Then
                    _GENERA_ESTADO_CUENTA = dtValidacion.Rows(0).Item("IS_GENERA_CANJE_LETRA").ToString
                    If _GENERA_ESTADO_CUENTA = "S" Then
                        Dim FrmLetras As New FrmLetras
                        'FrmLetras.MdiParent = Me
                        OpenSubForm(FrmLetras)
                        'Exit Sub
                    End If
                End If
                DocumentosFactura()
                ToolStrip1.Enabled = True
                Nuevo()
                txtPtoVenta.Select()
            End If
        ElseIf _GENERA_FACTURA_ELECTRONICA = "S" Then
            Dim StrNomArchivo_XML As String = ""
            Dim StrNomArchivo_PDF As String = ""

            If GuardarFacturacion() = True Then

                Dim STRmontotexto As String = ""
                If cboMoneda.SelectedValue = "MN" Then
                    If rb_facturar_obsequio.Checked Or rb_facturar_obsequio_sin_pedido.Checked Then
                        STRmontotexto = UCase(NUMEROLETRAS(0)) & " Soles"
                    Else
                        STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(txtPrecioVenta.Text)))) & " Soles"
                    End If
                Else
                    If rb_facturar_obsequio.Checked Or rb_facturar_obsequio_sin_pedido.Checked Then
                        STRmontotexto = UCase(NUMEROLETRAS(0)) & " Dólares Americanos"
                    Else
                        STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(CDbl(txtPrecioVenta.Text)))) & " Dólares Americanos"
                    End If
                End If
                Dim _existe_pdf As Boolean = False

                '***************************
                If Generar_XML_Factura_Guia(cboTipoDoc.Text, cboSerieDoc.Text, Strings.Right(NumeracionFacturacion, 7), STRmontotexto, "SI", "2") = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El documento " & cboTipoDoc.Text & " -  " & cboSerieDoc.Text & Strings.Right(NumeracionFacturacion, 7) & " no genero el archivo XML ubl 2.1." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                    DocumentosFactura()
                    ToolStrip1.Enabled = True
                    Nuevo()
                    txtPtoVenta.Select()
                Else


                    StrNomArchivo_XML = Ruta_FE() & "\InputXML" & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(cboTipoDoc.Text = "FT", "01", IIf(cboTipoDoc.Text = "BV", "03", _
                                        IIf(cboTipoDoc.Text = "NC", "07", IIf(cboTipoDoc.Text = "ND", "08", "")))) & "-" & cboSerieDoc.Text & "-" & _
                                        Format(CInt(Strings.Right(NumeracionFacturacion, 7)), "00000000") & ".xml"

                    Dim oProcesaArchivo As New ProcesaArchivo
                    Dim strMensaje As String = ""

                    If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                        MsgBox(strMensaje, MsgBoxStyle.Critical)
                        DocumentosFactura()
                        ToolStrip1.Enabled = True
                        Nuevo()
                        txtPtoVenta.Select()
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
                                If File.Exists(StrNomArchivo_PDF) Then
                                    System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                                    _existe_pdf = True
                                End If
                            End If

                            If _GENERA_GUIA_ELECTRONICA = "N" Then
                                If checkSinGuia.Checked = False Then
                                    If indicadorG = True Then
                                        msj = String.Empty
                                        msj = "Nueva Guia de Salida Generado Correctamente," & vbCrLf & " Nro Documento: GS-" & NumeracionGuiaRemision
                                        MsgBox(msj, MsgBoxStyle.Information)
                                    End If
                                End If
                                If checkSinGuia.Checked = False Then
                                    If indicadorG = True Then
                                        imprimirGuiaRemision(txtAlmacen.Text, "GS", NumeracionGuiaRemision)
                                    End If
                                End If
                            ElseIf _GENERA_GUIA_ELECTRONICA = "S" Then
                                If checkSinGuia.Checked = False Then
                                    If indicadorG = True Then
                                        If Generar_XML_Guia_Electronica("GS", txtAlmacen.Text.Trim, NumeracionGuiaRemision, "", "SI", "") = False Then
                                            Me.Cursor = Cursors.Default
                                            MsgBox("El documento GS -  " & NumeracionGuiaRemision & " no genero el archivo XML ubl 2.1." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                                        Else
                                            StrNomArchivo_XML = Ruta_FE() & "\InputXML" & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
                                                                Strings.Left(NumeracionGuiaRemision, Strings.Len(NumeracionGuiaRemision) - 7) & "-" &
                                                                Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".xml"

                                            _existe_pdf = False

                                            If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                                                MsgBox(strMensaje, MsgBoxStyle.Critical)
                                                Me.Cursor = Cursors.Default
                                                Exit Sub
                                            End If

                                            System.Threading.Thread.Sleep(3000)

                                            StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                                        dtpFechaFactura.Value.Year.ToString & "\" & Format(dtpFechaFactura.Value.Month, "00") & "\" &
                                                                        Format(dtpFechaFactura.Value.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
                                                                        Strings.Left(NumeracionGuiaRemision, Strings.Len(NumeracionGuiaRemision) - 7) &
                                                                        "-" & Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".pdf"

                                            While _existe_pdf = False
                                                If File.Exists(StrNomArchivo_PDF) Then
                                                    'Dim msj As String = ""
                                                    msj = "Documento Generado Correctamente" & vbCrLf & "Nro Documento: GS - " & NumeracionGuiaRemision
                                                    If MessageBox.Show(msj & vbCrLf & "Se procedera a la impresión del documento" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                                        System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                                                    End If
                                                    _existe_pdf = True
                                                End If
                                            End While

                                            'COPIAMOS LOS ARCHIVOS XML Y PDF A LA RUTA GENERAL DEL SERVIDOR
                                            StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                                        dtpFechaFactura.Value.Year.ToString & "\" & Format(dtpFechaFactura.Value.Month, "00") & "\" &
                                                                        Format(dtpFechaFactura.Value.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
                                                                        Strings.Left(NumeracionGuiaRemision, Strings.Len(NumeracionGuiaRemision) - 7) &
                                                                        "-" & Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".xml"


                                            If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = False Then
                                                MsgBox("ERROR:" & Chr(13) & "El documento GS -  " & cbSerieGuia.Text & Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".xml" & Chr(13) &
                                                       "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                            End If

                                            If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = False Then
                                                MsgBox("ERROR:" & Chr(13) & "El documento GS -  " & cbSerieGuia.Text & Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".pdf" & Chr(13) &
                                                "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                            End If
                                            'FIN DE COPIAMOS LOS ARCHIVOS XML Y PDF A LA RUTA GENERAL DEL SERVIDOR

                                        End If

                                    End If
                                End If
                            End If


                            _existe_pdf = True
                        End If
                    End While
                    _existe_pdf = False

                    'COPIAMOS LOS ARCHIVOS XML Y PDF A LA RUTA GENERAL DEL SERVIDOR
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
                    'FIN DE COPIAMOS LOS ARCHIVOS XML Y PDF A LA RUTA GENERAL DEL SERVIDOR
                End If
                '***************************


                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtValidacion = New DataTable("Validacion")
                dtValidacion = clsFacturaBl.Get_Validacion(cboTipoDoc.Text, cboSerieDoc.Text)
                If dtValidacion.Rows.Count > 0 Then
                    _GENERA_ESTADO_CUENTA = dtValidacion.Rows(0).Item("IS_GENERA_CANJE_LETRA").ToString
                    If _GENERA_ESTADO_CUENTA = "S" Then
                        Dim FrmLetras As New FrmLetras
                        OpenSubForm(FrmLetras)
                    End If
                End If
                DocumentosFactura()
                ToolStrip1.Enabled = True
                Nuevo()
                txtPtoVenta.Select()
            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Function Generar_XML_Guia_Electronica(ByVal TipoDoc As String, ByVal Warehouse_id As String, ByVal NumDoc As String, ByVal Monto_Letras As String, _
                                 Optional ByVal _envia_email As String = "", _
                                 Optional ByVal _email_cliente As String = "") As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_GS_Xml(TipoDoc, Warehouse_id, NumDoc, Ruta_FE() & "\InputXML", Monto_Letras, _envia_email, _email_cliente) Then
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

    Private Function Ruta_REPORTES() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRutaReportes = mySetting("Reportes")
        Return STRRutaReportes
    End Function

    


    Private Function Generar_Txt(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Monto_Letras As String, _
                                 Optional ByVal _envia_email As String = "", _
                                 Optional ByVal _email_cliente As String = "") As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_Txt(TipoDoc, SerieDoc, NumDoc, Ruta_FE() & "\Input", Monto_Letras, _envia_email, _email_cliente) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Generar_XML_Factura_Guia(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Monto_Letras As String, _
                                 Optional ByVal _envia_email As String = "", _
                                 Optional ByVal _ticket_a4 As String = "") As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_FT_GS_Xml(TipoDoc, SerieDoc, NumDoc, Ruta_FE() & "\InputXML", Monto_Letras, _envia_email, _ticket_a4) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Dim Store As String = String.Empty
        Dim msj As String = String.Empty
        Dim Usuario As String = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub

        If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then
            MsgBox("El documento elegido no puede ELIMINARSE. Verifique!!!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If

        ref_fecha_doc = dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value

        If dgvDocumentosFactura.CurrentRow.Cells("Estado").Value = "ANULADO" Then
            MsgBox("El documento se encuentra anulado," & Chr(13) & "no procede la eliminación.", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If

        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If


        Me.Cursor = Cursors.WaitCursor
        'Verificando Cancelacion
        Store = "FACT_SP_S_R_VERIFICAR_CANCEL"
        If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
            msj = String.Empty
            msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Cancelacion , no se puede Eliminar."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub
        Else
            'Verificando si posee Letra
            Store = String.Empty
            Store = "FACT_SP_S_R_VERIFICAR_LETRA"
            If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                msj = String.Empty
                msj = "   EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Letra, no se puede Eliminar."
                MsgBox(msj, MsgBoxStyle.Exclamation)
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                'verificamos si esta contabilizado
                Store = String.Empty
                Store = "FACT_SP_S_R_VERIFICAR_CONTABILIZACION"
                If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                    msj = String.Empty
                    msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " esta contabilizado, no se puede Eliminar."
                    MsgBox(msj, MsgBoxStyle.Exclamation)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    If Ref_DOCUMENT_ID <> "CP" Then
                        'ELIMINACION Factura 
                        Usuario = LibComunVar.ClsVarComun.USUARIO
                        clsFacturaBl = New ClsNegocio.RECEIVABLE
                        dtDetalleFact = New DataTable("Punto_Venta")
                        Dim PuntoVenta As String = dgvDocumentosFactura.CurrentRow.Cells("PV").Value
                        Dim WareHouse As String = String.Empty
                        If String.IsNullOrEmpty(PuntoVenta.ToString) Then
                            MsgBox("El documento no posee un Punto de Venta Asociado", MsgBoxStyle.Exclamation)
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        End If
                        dtDetalleFact = clsFacturaBl.Get_ManualPuntoVenta(PuntoVenta)
                        If dtDetalleFact.Rows.Count() <> 0 Then
                            WareHouse = dtDetalleFact.Rows(0).Item(2).ToString
                        Else
                            MsgBox("No existe Almacen en el Punto de venta", MsgBoxStyle.Exclamation)
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        End If
                        If MessageBox.Show("¿Desea Eliminar el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            If EliminarFacturas(Usuario, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "", WareHouse) = False Then
                                MsgBox("Hubo un error, no se completo el Proceso de Eliminacion", MsgBoxStyle.Exclamation)
                                Me.Cursor = Cursors.Default
                                Exit Sub
                            End If
                        End If

                        msj = String.Empty
                        msj = "Documento Eliminado Correctamente." & vbCrLf & " Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                        MsgBox(msj, MsgBoxStyle.Information)
                        Me.Cursor = Cursors.Default
                        DocumentosFactura()
                    Else
                        'ELIMIANCION  CP
                        Usuario = LibComunVar.ClsVarComun.USUARIO
                        If EliminarFacturas(Usuario, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "CP") = False Then
                            MsgBox("Hubo un error, no se completo el Proceso de Eliminacion", MsgBoxStyle.Exclamation)
                            Me.Cursor = Cursors.Default
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
                                    ByVal _NUMBER_DOCUMENT As String, Optional ByVal ComprobanteP As String = "", Optional ByVal ALMACEN As String = "", _
                                    Optional ByVal MOTIVO As String = "") As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If ComprobanteP = String.Empty Then
                clsFacturaBl.AnulacionFacturacion(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, ALMACEN, MOTIVO)
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
        STREstado = dgvDocumentosFactura.CurrentRow.Cells("Estado").Value
        If STREstado = "ANULADO" Then
            Me.Cursor = Cursors.Default
            MessageBox.Show("El Documento ya se encuentra anulado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Strings.Left(dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value, 1) = "F" Then
            If CInt(dgvDocumentosFactura.CurrentRow.Cells("DIAS").Value) > 7 Then
                Me.Cursor = Cursors.Default
                MsgBox("No aplica el Proceso de ANULACION, por superar el limite de días habiles.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If


        ref_fecha_doc = dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value
        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Dim Store As String = String.Empty
        Dim msj As String = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        'If MessageBox.Show("¿Desea Anular el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        Me.Cursor = Cursors.WaitCursor
        'Verificando Cancelacion
        Store = "FACT_SP_S_R_VERIFICAR_CANCEL"
        If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
            msj = String.Empty
            msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Cancelacion , no se puede Anular."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub
        Else
            'Verificando si ´posee Letra
            Store = String.Empty
            Store = "FACT_SP_S_R_VERIFICAR_LETRA"
            If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                msj = String.Empty
                msj = "   EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Letra , no se puede Anular."
                MsgBox(msj, MsgBoxStyle.Exclamation)
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                'verificamos si esta contabilizado
                Store = String.Empty
                Store = "FACT_SP_S_R_VERIFICAR_CONTABILIZACION"
                If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                    msj = String.Empty
                    msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " esta contabilizado, no se puede Anular."
                    MsgBox(msj, MsgBoxStyle.Exclamation)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    'verificamos si esta en un resumen de boletas
                    Store = String.Empty
                    Store = "FACT_SP_S_R_VERIFICAR_PERTENECE_RESUMEN"
                    If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                        msj = String.Empty
                        msj = "      EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " pertenece a un RESUMEN DE BOLETAS, no se puede Anular."
                        MsgBox(msj, MsgBoxStyle.Exclamation)
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    Else
                        Me.Cursor = Cursors.Default
                        ToolStrip1.Enabled = False
                        pnlPrincipal.Enabled = False
                        txt_motivo_anulacion.Text = ""
                        Label66.Text = Ref_DOCUMENT_ID & "-" & Ref_NUMBER_SERIE & "-" & Ref_NUMBER_DOCUMENT
                        dtp_fecha_anulacion.Value = Date.Now
                        pnl_motivo_anulacion.Visible = True
                        txt_motivo_anulacion.Focus()
                    End If
                End If
            End If
        End If
        'End If
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


    Private Sub imprimirFacturacion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String, _
                                    ByVal _Moneda As String, ByVal _Igv As Double, ByVal _Monto As Double)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Dim STRmontotexto As String = String.Empty
            Dim Nom_Reporte As String = String.Empty
            If _Moneda = "MN" Then
                If rb_facturar_obsequio.Checked Or rb_facturar_obsequio_sin_pedido.Checked Then
                    STRmontotexto = UCase(NUMEROLETRAS(0)) & "   SOLES"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   SOLES"
                End If
            Else
                If rb_facturar_obsequio.Checked Or rb_facturar_obsequio_sin_pedido.Checked Then
                    STRmontotexto = UCase(NUMEROLETRAS(0)) & "   DOLARES AMERICANOS"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   DOLARES AMERICANOS"
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.Obtener_Nombre_Reporte(_DOCUMENT_ID, _NUMBER_SERIE)
            If dtImprimir.Rows.Count > 0 Then
                Nom_Reporte = dtImprimir.Rows(0).Item("REPORT_NAME").ToString
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
                If _DOCUMENT_ID = "NC" Or _DOCUMENT_ID = "ND" Then
                    Dim RelacionDoc As String = String.Empty
                    Dim DENOMINACION_REFERENCIA As String = String.Empty
                    Dim NUMERO_REFERENCIA As String = String.Empty
                    Dim FECHA_REFERENCIA As String = String.Empty
                    Dim REF_NC As String = ""
                    'RelacionDoc = RetornarDocReferenciaNotaC(_DOCUMENT_ID, _NUMBER_SERIE, Strings.Right(_NUMBER_DOCUMENT, 7))

                    Dim FacturacionesBl As New ClsOperaciones.RECEIVABLE
                    Dim DtdocReferencia As New DataTable
                    'DtdocReferencia = FacturacionesBl.RelacionDocumentosReferencia(_DOCUMENT_ID, _NUMBER_SERIE, Strings.Right(_NUMBER_DOCUMENT, 7))
                    RelacionDoc = RetornarDocReferenciaNotaC(_DOCUMENT_ID, _NUMBER_SERIE, Strings.Right(_NUMBER_DOCUMENT, 7))
                    If RelacionDoc.Length() > 12 Then
                        REF_NC = "1"
                    Else
                        REF_NC = "0"
                    End If
                    'If DtdocReferencia.Rows.Count > 0 Then
                    '    DENOMINACION_REFERENCIA = DtdocReferencia.Rows(0).Item("DENOMINACION_REF").ToString
                    '    NUMERO_REFERENCIA = DtdocReferencia.Rows(0).Item("NUMERO_REF").ToString
                    '    FECHA_REFERENCIA = DtdocReferencia.Rows(0).Item("FECHA_REF").ToString
                    '    REF_NC = "1"
                    'Else
                    '    REF_NC = "0"
                    'End If
                    'If RelacionDoc.Length() > 12 Then

                    'Else
                    '    REF_NC = "0"
                    'End If
                    crystalBL.Muestra_Reporte(Nom_Reporte, dtImprimir, "", "", "@TIPO;" & _DOCUMENT_ID, "@SERIE;" & _NUMBER_SERIE, "@NUMERO;" & _NUMBER_DOCUMENT, "LETRAS;" & STRmontotexto, "@DOC_REF;" & IIf(REF_NC = "0", NUMERO_REFERENCIA, IIf(REF_NC = "1", RelacionDoc, "")), "@REF_NC;" & REF_NC) ', "DENOMINACION_REF;" & DENOMINACION_REFERENCIA, "FECHA_REF;" & FECHA_REFERENCIA)
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
                    End If

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
            Dim Nom_Reporte As String

            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.Obtener_Nombre_Reporte(documentid, Strings.Left(numerodocument, 3))
            If dtImprimir.Rows.Count > 0 Then
                Nom_Reporte = dtImprimir.Rows(0).Item("REPORT_NAME").ToString
            Else
                MsgBox("No se encuentra el formato del reporte, no se puede imprimir el documento " & documentid & ".", MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            If Nom_Reporte = "" Then
                MsgBox("No se encuentra el formato del reporte, no se puede imprimir el documento " & documentid & ".", MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If


            dtImprimir = reporteBL.EjecutarReporteGuiaRemision(idalamacen, documentid, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte(Nom_Reporte, dtImprimir, "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
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


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        'Validacione Generales Reporte y consulta
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        'gbGenerarCP.Visible = False
        btnGenerarCP.Visible = False
        If dgvDocumentosFactura.Visible Then
            'Mostrando resultados
            If MostrarModoConsultar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) Then
                pnlPrincipal.Visible = False
                gbTipoFacturacion.Visible = False
                GbCabecera.Enabled = False
                gbdetalle.Enabled = True
                gbOpciones.Enabled = False
                'chkSinIGV.Visible = True
                Modo_consultar = True
                Call Botonera_Estado_Cambiar(True)
                GbdetalleDocumento.Visible = True
            End If
        Else
            If Ref_DOCUMENT_ID <> "CP" Then
                Dim StrNomArchivo_PDF As String = ""
                If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then

                    'VERIFICAMOS SI SE ENCUENTRA EN LA RUTA DEL SERVIDOR
                    StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", _
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & _
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                    If File.Exists(StrNomArchivo_PDF) Then
                        System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                    Else
                        StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & dtpFechaFactura.Value.Year.ToString & "\" &
                                        Format(dtpFechaFactura.Value.Month, "00") & "\" & Format(dtpFechaFactura.Value.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" &
                                        IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07",
                                        IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                        If File.Exists(StrNomArchivo_PDF) Then
                            If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = True Then
                                StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", _
                                                    IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & _
                                                    Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                                If File.Exists(StrNomArchivo_PDF) Then
                                    System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                                Else
                                    Dim msj As String = ""
                                    msj = String.Empty
                                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                                    MsgBox(msj, MsgBoxStyle.Information)
                                End If
                            Else
                                MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".PDF" & Chr(13) & _
                                       "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                            End If
                        Else
                            Dim msj As String = ""
                            msj = String.Empty
                            msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                            MsgBox(msj, MsgBoxStyle.Information)
                        End If
                    End If
                Else
                    imprimirFacturacion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, cboMoneda.SelectedValue.ToString, txtIgv.Text, txtPrecioVenta.Text)
                End If

                'Verificando si posee Guia Remision
                'If Ref_DOCUMENT_ID = "FT" Then
                Dim GuiaBl As New ClsBuscar
                Dim dtDatosGuia As New DataTable
                dtDatosGuia = GuiaBl.Get_GuiasAsociadas(txtAlmacen.Text, Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT, Ref_DOCUMENT_ID)
                If dtDatosGuia.Rows.Count() <> 0 Then
                    If Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 1) = "T" Then
                        StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                        If File.Exists(StrNomArchivo_PDF) Then
                            System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                        Else
                            StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & dtpFechaFactura.Value.Year.ToString & "\" & _
                                                    Format(dtpFechaFactura.Value.Month, "00") & "\" & Format(dtpFechaFactura.Value.Day, "00") & "\" & _
                                                    LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                    Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                    "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                            If File.Exists(StrNomArchivo_PDF) Then
                                If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = True Then
                                    StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                    Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                    "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                                    If File.Exists(StrNomArchivo_PDF) Then
                                        System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                                    Else
                                        Dim msj As String = ""
                                        msj = String.Empty
                                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"
                                        MsgBox(msj, MsgBoxStyle.Information)
                                    End If
                                Else
                                    MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".PDF" & Chr(13) &
                                           "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                End If
                            Else
                                Dim msj As String = ""
                                msj = String.Empty
                                msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"
                                MsgBox(msj, MsgBoxStyle.Information)
                            End If
                        End If
                    Else
                        imprimirGuiaRemision(dtDatosGuia.Rows(0).Item("WAREHOUSE_ID").ToString, dtDatosGuia.Rows(0).Item("DOCUMENT_ID").ToString, dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString)
                    End If
                End If
                'End If
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
        pnlPrincipal.Visible = True
        'chkSinIGV.Visible = True
        GbdetalleDocumento.Visible = False
        ' gbGenerarCP.Visible = False
        btnGenerarCP.Visible = False
        btnDespacho.Visible = False
        Botonera_Estado_Cambiar(False)
        Limpiar()
        'DocumentosFactura()
        'If NIVEL_ACCESO() Then
        '    btn_modificar.Visible = NIVEL_ACCESO()
        'Else
        '    btn_modificar.Visible = NIVEL_ACCESO_FACTURACION()
        'End If
        btn_modificar.Visible = False 'NIVEL_ACCESO_FACTURACION()
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
                    If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "01" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "02" Then
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
                    If dtNivel.Rows(0).Item("PRECIO_IGV").ToString = False Then
                        FLAG_NIVEL = False
                    ElseIf dtNivel.Rows(0).Item("PRECIO_IGV").ToString = True Then
                        FLAG_NIVEL = True
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

    Private Function NIVEL_ACCESO_FACTURACION() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("COD_PERFIL").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("COD_PERFIL").ToString = "0000000007" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("COD_PERFIL").ToString <> "0000000007" Then
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


    Private Sub FrmRegistroPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        flag_inicio = False
        cboOpcionTipoDoc.SelectedIndex = 3
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        'If NIVEL_ACCESO() Then
        '    btn_modificar.Visible = NIVEL_ACCESO()
        'Else
        '    btn_modificar.Visible = NIVEL_ACCESO_FACTURACION()
        'End If
        btn_modificar.Visible = False
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        Call Cargar_Moneda()
        txtFiltro.Select()

        Dim clsBusquedaBl As New ClsBuscar
        Dim dtNivel As New DataTable
        dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
        If dtNivel.Rows.Count() <> 0 Then
            If dtNivel.Rows(0).Item("VALIDA_STOCK").ToString = "" Then
                _VALIDA_STOCK = False
            Else
                If dtNivel.Rows(0).Item("VALIDA_STOCK").ToString = "SI" Then
                    _VALIDA_STOCK = True
                ElseIf dtNivel.Rows(0).Item("VALIDA_STOCK").ToString = "NO" Then
                    _VALIDA_STOCK = False
                End If
            End If
        Else
            _VALIDA_STOCK = False
        End If

        flag_inicio = True
    End Sub

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
        If flag_inicio = True Then
            DocumentosFactura()
        End If
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
                    pnlDocumentosGuiaVenta.Visible = False
                    Exit Sub
                Else
                    MostrandoDocumentoCliente()
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
                sql = "PED_SP_S_ORDER_CLIENTE_I"
                frm.CadenaConsulta = sql
                frm.Titulo = "Clientes"
                frm._Flag_Filtro = True
                frm.Filtros1 = cboTipoDoc.Text
                frm.Filtros2 = cboSerieDoc.Text
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtCodCliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtRazonSocial.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txtRucDni.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                    txtDireccion.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                    txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                    txt_email_cliente.Text = frm.Data_Matriz.Rows(0).Item(8).ToString
                    _cliente_retenedor = frm.Data_Matriz.Rows(0).Item("RETENTION").ToString

                    If frm.Data_Matriz.Rows(0).Item("VALIDADO").ToString = "NO" Then
                        MsgBox("El cliente NO se encuentra validado. Verifique para continuar!!!", MsgBoxStyle.Exclamation, "Aviso")
                        txtCodCliente.ForeColor = Color.Red
                        txtRazonSocial.ForeColor = Color.Red
                        txtRucDni.ForeColor = Color.Red
                        txtDireccion.ForeColor = Color.Red
                        txt_email_cliente.ForeColor = Color.Red
                    ElseIf frm.Data_Matriz.Rows(0).Item("VALIDADO").ToString = "SI" Then
                        txtCodCliente.ForeColor = Color.Blue
                        txtRazonSocial.ForeColor = Color.Blue
                        txtRucDni.ForeColor = Color.Blue
                        txtDireccion.ForeColor = Color.Blue
                        txt_email_cliente.ForeColor = Color.Blue
                    End If

                    If rbFacturaRepMedico.Checked = False Then
                        If LibComunVar.ClsVarComun.VENDEDOR <> "" Then
                            txtVendedor.Text = LibComunVar.ClsVarComun.VENDEDOR
                        Else
                            txtVendedor.Text = frm.Data_Matriz.Rows(0).Item("SALES_ID").ToString
                        End If
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
                    _cliente_retenedor = dtDetalleFact.Rows(0).Item("RETENTION").ToString
                    If rb_facturar_pedido.Checked = False Then
                        txtFormaPago.Text = dtDetalleFact.Rows(0).Item(5).ToString
                        If rbFacturaRepMedico.Checked = False Then
                            If LibComunVar.ClsVarComun.VENDEDOR <> "" Then
                                txtVendedor.Text = LibComunVar.ClsVarComun.VENDEDOR
                            Else
                                txtVendedor.Text = dtDetalleFact.Rows(0).Item("SALES_ID").ToString
                            End If
                        End If
                    End If

                    txt_email_cliente.Text = dtDetalleFact.Rows(0).Item(8).ToString

                    If dtDetalleFact.Rows(0).Item("VALIDADO").ToString = "NO" Then
                        MsgBox("El cliente NO se encuentra validado. Verifique para continuar!!!", MsgBoxStyle.Exclamation, "Aviso")
                        txtCodCliente.ForeColor = Color.Red
                        txtRazonSocial.ForeColor = Color.Red
                        txtRucDni.ForeColor = Color.Red
                        txtDireccion.ForeColor = Color.Red
                        txt_email_cliente.ForeColor = Color.Red
                    ElseIf dtDetalleFact.Rows(0).Item("VALIDADO").ToString = "SI" Then
                        txtCodCliente.ForeColor = Color.Blue
                        txtRazonSocial.ForeColor = Color.Blue
                        txtRucDni.ForeColor = Color.Blue
                        txtDireccion.ForeColor = Color.Blue
                        txt_email_cliente.ForeColor = Color.Blue
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
                    txt_email_cliente.Text = String.Empty
                    _cliente_retenedor = ""
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
                If rb_facturar_pedido.Checked = False Then
                    lblVendedor.Text = clsBuscarBl.Get_NombreVendedor(txtVendedor.Text)
                    If lblVendedor.Text = String.Empty Then
                        txtVendedor.Text = ""
                    End If
                End If
            Else
                lblVendedor.Text = ""
            End If
            txtVendedor.Select()
            If rbFacturaGuiaVenta.Checked = True Then
                If String.IsNullOrEmpty(txtCodCliente.Text) Or String.IsNullOrEmpty(txtAlmacen.Text) Then
                    MsgBox("Para este tipo de Facturacion es necesario el Cliente y el Almacen.", MsgBoxStyle.Information)
                    pnlDocumentosGuiaVenta.Visible = False
                    Exit Sub
                Else
                    MostrandoDocumentoCliente()
                    txtFiltroCliente.Text = String.Empty
                    lblDetalle.Text = "GUIAS DE VENTA"
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

                    If txtFormaPago.Text = "00" Then 'si es contado contra entrega
                        txtModoPago.Text = ""
                        lblModoPago.Text = ""
                    Else
                        txtModoPago.Text = "11"
                        lblModoPago.Text = "OTROS"
                    End If
                End If
                frm.Close()
            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Forma_Pago")
                dtDetalleFact = clsFacturaBl.Get_ManualFormaPago(_codigoVendedor)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtFormaPago.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    lblFormaPago.Text = dtDetalleFact.Rows(0).Item(1).ToString

                    If txtFormaPago.Text = "00" Then 'si es contado contra entrega
                        txtModoPago.Text = ""
                        lblModoPago.Text = ""
                    Else
                        txtModoPago.Text = "11"
                        lblModoPago.Text = "OTROS"
                    End If
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtFormaPago.Text = String.Empty
                    lblFormaPago.Text = String.Empty
                    txtModoPago.Text = ""
                    lblModoPago.Text = ""
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
                MsgBox("Debe seleccionar un Punto de Venta.", MsgBoxStyle.Exclamation)
                estado = False
                txtPtoVenta.Focus()
                Exit Try
            End If

            If txtAlmacen.Text = String.Empty Then
                MsgBox("Debe seleccionar un Almacen, para poder continuar.", MsgBoxStyle.Exclamation)
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
                MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Exclamation)
                estado = False
                txtCodCliente.Focus()
                Exit Try
            End If

            If txtFormaPago.Text = String.Empty Then
                MsgBox("Debe seleccionar una Forma de Pago.", MsgBoxStyle.Exclamation)
                txtFormaPago.Focus()
                estado = False
                Exit Try
            End If

            If txtModoPago.Text = String.Empty Then
                MsgBox("Debe seleccionar un Modo de Pago.", MsgBoxStyle.Exclamation)
                txtModoPago.Focus()
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
                MessageBox.Show("Debe elegir el tipo de documento a facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cboTipoDoc.Focus()
                estado = False
                Exit Try
            ElseIf cboSerieDoc.Text = String.Empty Then
                MessageBox.Show("Debe elegir la serie para el Documento a Facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cboSerieDoc.Focus()
                estado = False
                Exit Try
            ElseIf cbSerieGuia.Text = String.Empty Then
                MessageBox.Show("Debe elegir la serie para la Guía de Remisión.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbSerieGuia.Focus()
                estado = False
                Exit Try
                If checkSinGuia.Checked = False Then
                    If txtCodTrans.Text.Trim.Length = 0 Then
                        MessageBox.Show("Debe ingresar el Código de Transportista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtCodTrans.Focus()
                        estado = False
                        Exit Try
                    End If
                End If
            ElseIf cboDirEntrega.Items.Count > 0 Then
                If cboDirEntrega.SelectedIndex = -1 Then
                    If cboDirEntrega.Text = String.Empty Then
                        MessageBox.Show("Debe elegir la Dirección de Entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        cboDirEntrega.Focus()
                        estado = False
                        Exit Try
                    End If
                End If
            End If
            If cboTipoDoc.Text = "NC" Or cboTipoDoc.Text = "ND" Then
                If rb_facturar_devolucion.Checked = True Then

                Else
                    If rbDocRef_uno.Checked = True Then
                        If txttipoDocRef.Text = String.Empty Then
                            MsgBox("Debe de ingresar un tipo de doc de Referencia.", MsgBoxStyle.Exclamation)
                            txttipoDocRef.Focus()
                            estado = False
                            Exit Try
                        ElseIf txtSerieDocRef.Text = String.Empty Then
                            MsgBox("Debe ingresar una serie del doc de Referencia.", MsgBoxStyle.Exclamation)
                            txtSerieDocRef.Focus()
                            estado = False
                            Exit Try
                        ElseIf txtNumDocRef.Text = String.Empty Then
                            MsgBox("Debe de ingresar un numero de  doc de Referencia.", MsgBoxStyle.Exclamation)
                            txtNumDocRef.Focus()
                            estado = False
                            Exit Try
                        ElseIf txt_cod_tipo_nota_electronica.Text = String.Empty Then
                            MsgBox("Debe elegir un Tipo de Nota Electronica", MsgBoxStyle.Exclamation)
                            txt_cod_tipo_nota_electronica.Focus()
                            estado = False
                            Exit Try
                        End If
                    ElseIf rbDocRef_varios.Checked = True Then
                        If Dt_principal_lista_Doc_Ref.Rows.Count() = 0 Then
                            MsgBox("Eligio la opcion varios doc Referencia, debe ingresar esos doc.", MsgBoxStyle.Exclamation)
                            estado = False
                            Exit Try
                        End If
                    End If
                End If

            End If

            If dtp_fecha_traslado.Value.ToString("dd/MM/yyyy") < dtpFechaFactura.Value.ToString("dd/MM/yyyy") Then
                MsgBox("La fecha de traslado no puede ser menor a la fecha de emisión. Verifique!!!", MsgBoxStyle.Critical)
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

            If Strings.Left(cbSerieGuia.Text, 1) = "T" Then
                If rdb_trans_privado.Checked Then
                    If checkSinGuia.Checked = False Then
                        If txtCodTrans.Text.Trim.Length = 0 Then
                            MessageBox.Show("Debe elegir el Código de Transportista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtCodTrans.Focus()
                            estado = False
                            Exit Try
                        ElseIf cboDirEntrega.Items.Count = 0 Then
                            MessageBox.Show("Debe registrar una Dirección de Entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            cboDirEntrega.Focus()
                            estado = False
                            Exit Try
                        ElseIf txt_vehiculo.Text.Trim.Length = 0 Then
                            MessageBox.Show("Debe elegir un Vehiculo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txt_vehiculo.Focus()
                            estado = False
                            Exit Try
                        End If
                    End If
                ElseIf rdb_trans_publico.Checked Then
                    If checkSinGuia.Checked = False Then
                        If cboDirEntrega.Items.Count = 0 Then
                            MessageBox.Show("Debe registrar una Dirección de Entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            cboDirEntrega.Focus()
                            estado = False
                            Exit Try
                        End If
                    End If
                End If
            End If

            

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    'Private Function DatosLotes(Optional ByVal Lote As String = "", Optional ByVal CodigoPart As String = "") As String
    '    Dim Cadena As String = String.Empty
    '    Try
    '        Dim listaLot As New List(Of String)
    '        Dim cadena_lote As String = String.Empty
    '        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
    '            If edicion = True Then
    '                If dtdetalleArticuloPrincipal.Rows.Count() = 1 Then
    '                    Exit Try
    '                End If
    '            End If
    '            If Lote = String.Empty Then
    '                For i As Integer = 0 To dgvDetalle.Rows.Count() - 1
    '                    Dim lotes As String = String.Empty
    '                    lotes = dgvDetalle.Item(5, i).Value
    '                    If listaLot.Contains(lotes) = False Then
    '                        listaLot.Add(lotes)
    '                    End If
    '                Next
    '                For j As Integer = 0 To listaLot.Count() - 1
    '                    cadena_lote += "'" & listaLot(j) & "',"
    '                Next
    '                Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
    '            Else
    '                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("CODIGO='" & CodigoPart & "' and LOTE NOT IN ('" & Lote & "')")
    '                    Dim lotes As String = String.Empty
    '                    lotes = item("LOTE")
    '                    If listaLot.Contains(lotes) = False Then
    '                        listaLot.Add(lotes)
    '                    End If
    '                Next
    '                If listaLot.Count() <> 0 Then
    '                    For j As Integer = 0 To listaLot.Count() - 1
    '                        cadena_lote += "'" & listaLot(j) & "',"
    '                    Next
    '                    Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Return Cadena
    'End Function

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
            Dim frmArticulo As New FrmAsignarArticulo
            frmArticulo.AlmacenOrigen = txtAlmacen.Text
            frmArticulo.TipoDocumento = cboTipoDoc.Text
            frmArticulo.Flag_Cliente = txtCodCliente.Text
            frmArticulo._valida_stock = _VALIDA_STOCK
            If rbFacturaDirecta.Checked = True Or rb_facturar_pedido.Checked Or rb_facturar_obsequio.Checked Or rbfacturaExportacion.Checked Or rb_facturar_obsequio_sin_pedido.Checked Then frmArticulo.Flag_Factura_directa = True
            If rbfacturaExportacion.Checked Then frmArticulo.Flag_Factura_Exportacion = True
            If rb_facturar_pedido.Checked Or rb_facturar_obsequio.Checked Or rbfacturaExportacion.Checked Then frmArticulo.Flag_Factura_Pedido = True
            If rb_facturar_pedido.Checked = True Or rb_facturar_obsequio.Checked = True Or rbfacturaExportacion.Checked Then
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
            frmArticulo.ValidacionLotes = DatosLotes()
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
                row("IGV_POR") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                IGV_POR_ITEM = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV_POR")
                row("IMPORTE") = 0
                row("PRECIO_INICIAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRECIO_INICIAL").ToString
                row("TOTAL_INICIAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TOTAL_INICIAL").ToString

                row("OBSERVACIONES") = frmArticulo.dtdetalleArticulo.Rows(0).Item("OBSERVACIONES").ToString

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
                If _cliente_retenedor = "1" Then
                    Dim _monto As Double = 0
                    _monto = CDbl(txtPrecioVenta.Text)
                    If cboMoneda.SelectedValue = "ME" Then
                        _monto = _monto * CDbl(txtTipoCambio.Text)
                    End If
                    If _monto >= 700 Then
                        _monto = CDbl(txtPrecioVenta.Text)
                        _monto = Math.Round(_monto - Math.Round(_monto * 0.03, 2), 2)
                    End If
                    txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & _monto
                Else
                    txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & txtPrecioVenta.Text
                End If

            Else
                txt_forma_de_pago2.Text = ""
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
                            'txtIgv.Text = -Math.Abs(Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
                            txtIgv.Text = -Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART)", ""), 4, MidpointRounding.AwayFromZero)
                            'txtIgv.Text = -Math.Abs(Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
                            '*********** 
                        Else
                            '*********** CALCULOS DE TOTALES GENERALES***
                            total = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(VALOR_VENTA)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc1 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc2 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero)
                            txtBruto.Text = Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtDescuentos.Text = Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero)
                            'txtIgv.Text = Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero)
                            txtIgv.Text = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART)", ""), 4, MidpointRounding.AwayFromZero)
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
                            'txtIgv.Text = -Math.Abs(Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero))
                            txtIgv.Text = -Math.Abs(Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART)", ""), 4, MidpointRounding.AwayFromZero))
                            '***********
                        Else
                            '*********** CALCULOS DE TOTALES GENERALES

                            total = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL_INICIAL)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc1 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_01)", ""), 4, MidpointRounding.AwayFromZero)
                            totaldesc2 = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IMP_DESC_02)", ""), 4, MidpointRounding.AwayFromZero)

                            txtBruto.Text = Math.Round(total - totaldesc1 - totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtDescuentos.Text = Math.Round(totaldesc1 + totaldesc2, 4, MidpointRounding.AwayFromZero)
                            txtvalorVenta.Text = Math.Round(Double.Parse(txtBruto.Text) + Double.Parse(txtDescuentos.Text), 4, MidpointRounding.AwayFromZero)
                            'txtIgv.Text = Math.Round((Double.Parse(txtBruto.Text) * po_TasaIgv / 100), 4, MidpointRounding.AwayFromZero)
                            txtIgv.Text = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(IGV_ART)", ""), 4, MidpointRounding.AwayFromZero)
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
                po_TasaIgv = IGV_POR_ITEM ' 'CDbl(dtIgvArticulo.Rows(0).Item("AMOUNT_TAX"))
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
                                    Igv = IIf(cboTipoDoc.Text = "PF", 0, row("IGV_POR")) 'IGV_POR_ITEM 'CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaIgv = Igv / 100
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL")) + (CDbl(row("PRECIO_INICIAL")) * (CDbl(Igv) / 100))
                                    If chkSinIGV.Checked = False Then
                                        Monto = Monto / (1 + (Igv / 100))
                                    End If
                                    If chkSinIGV.Checked Then
                                        Monto = Val(Format(Monto * (1 + TasaIgv), "0.0000000000"))
                                    Else
                                        Monto = Val(Format(Monto / (1 + TasaIgv), "0.0000000000"))
                                    End If
                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = -Math.Abs(CDbl(Monto))
                                    row("VALOR_VENTA") = -Math.Abs(CDbl(row("CANTIDAD") * row("PREC_UNITARIO")))
                                    row("IMP_DESC_01") = Math.Abs(CDbl((row("PREC_UNITARIO") * row("%DESC.ART_1") / 100) * row("CANTIDAD")))
                                    row("IMP_DESC_02") = Math.Abs(CDbl(((row("PREC_UNITARIO") - (row("PREC_UNITARIO") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD")))
                                    row("PRECIO_IGV") = -Math.Abs(CDbl(row("PRECIO_INICIAL")))
                                    row("IGV_ART") = -Math.Abs(CDbl(((row("CANTIDAD") * row("PREC_UNITARIO")) - row("IMP_DESC_01") - row("IMP_DESC_02")) * TasaIgv))
                                    row("IGV_ART_US") = -Math.Abs(CDbl(((row("CANTIDAD") * row("PREC_UNITARIO")) - row("IMP_DESC_01") - row("IMP_DESC_02")) * TasaIgv / txtTipoCambio.Text))
                                    row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()

                                Else
                                    Igv = IIf(cboTipoDoc.Text = "PF", 0, row("IGV_POR")) ' 'IGV_POR_ITEM '(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaIgv = Igv / 100
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL")) + (CDbl(row("PRECIO_INICIAL")) * (CDbl(Igv) / 100))
                                    If chkSinIGV.Checked = False Then
                                        Monto = Monto / (1 + (Igv / 100))
                                    End If
                                    If chkSinIGV.Checked Then
                                        Monto = Val(Format(Monto * (1 + TasaIgv), "0.0000000000"))
                                    Else
                                        Monto = Val(Format(Monto / (1 + TasaIgv), "0.0000000000"))
                                    End If
                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = CDbl(Monto)
                                    row("VALOR_VENTA") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO"))
                                    row("IMP_DESC_01") = CDbl((row("PREC_UNITARIO") * row("%DESC.ART_1") / 100) * row("CANTIDAD"))
                                    row("IMP_DESC_02") = CDbl(((row("PREC_UNITARIO") - (row("PREC_UNITARIO") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD"))
                                    row("PRECIO_IGV") = row("PRECIO_INICIAL")
                                    row("IGV_ART") = CDbl(((row("CANTIDAD") * row("PREC_UNITARIO")) - row("IMP_DESC_01") - row("IMP_DESC_02")) * TasaIgv)
                                    row("IGV_ART_US") = CDbl(((row("CANTIDAD") * row("PREC_UNITARIO")) - row("IMP_DESC_01") - row("IMP_DESC_02")) * TasaIgv / txtTipoCambio.Text)
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
                                    Igv = IIf(cboTipoDoc.Text = "PF", 0, row("IGV_POR")) 'IGV_POR_ITEM 'CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaIgv = Igv / 100
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL"))
                                    If chkSinIGV.Checked = False Then
                                        Monto = Monto / (1 + (Igv / 100))
                                    End If
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
                                    row("IGV_ART") = -Math.Abs(CDbl(((row("CANTIDAD") * row("PREC_UNITARIO")) - row("IMP_DESC_01") - row("IMP_DESC_02")) * TasaIgv))
                                    row("IGV_ART_US") = -Math.Abs(CDbl(((row("CANTIDAD") * row("PREC_UNITARIO")) - row("IMP_DESC_01") - row("IMP_DESC_02")) * TasaIgv / txtTipoCambio.Text))
                                    row("IMPORTE") = -Math.Abs(CDbl(row("PRECIO_IGV") * row("CANTIDAD")))
                                    row("CANTIDAD") = -Math.Abs(CDbl(row("CANTIDAD")))
                                    dtdetalleArticuloPrincipal.EndInit()
                                    dtdetalleArticuloPrincipal.AcceptChanges()

                                Else
                                    Igv = IIf(cboTipoDoc.Text = "PF", 0, row("IGV_POR")) 'IGV_POR_ITEM 'CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                                    TasaIgv = 0.0
                                    TasaIgv = Igv / 100
                                    Monto = 0.0
                                    Monto = CDbl(row("PRECIO_INICIAL"))
                                    If chkSinIGV.Checked = False Then
                                        Monto = Monto / (1 + (Igv / 100))
                                    End If
                                    If chkSinIGV.Checked Then
                                        Monto = Val(Format(Monto * (1 + TasaIgv), "0.0000000000"))
                                    Else
                                        Monto = Val(Format(Monto / (1 + TasaIgv), "0.0000000000"))
                                    End If
                                    dtdetalleArticuloPrincipal.BeginInit()
                                    row("PREC_UNITARIO") = row("PRECIO_INICIAL")
                                    row("VALOR_VENTA") = CDbl(row("CANTIDAD") * row("PREC_UNITARIO"))
                                    row("IMP_DESC_01") = CDbl((row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100) * row("CANTIDAD"))
                                    row("IMP_DESC_02") = CDbl(((row("PRECIO_INICIAL") - (row("PRECIO_INICIAL") * row("%DESC.ART_1") / 100)) * row("%DESC.ART_2") / 100) * row("CANTIDAD"))
                                    row("PRECIO_IGV") = Monto
                                    row("IGV_ART") = CDbl(((row("CANTIDAD") * row("PREC_UNITARIO")) - row("IMP_DESC_01") - row("IMP_DESC_02")) * TasaIgv)
                                    row("IGV_ART_US") = CDbl((((row("CANTIDAD") * row("PREC_UNITARIO")) - row("IMP_DESC_01") - row("IMP_DESC_02")) * TasaIgv) / txtTipoCambio.Text)
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
            ElseIf rbfacturaExportacion.Checked = True Then
                NombreTipoFacturacion = rbfacturaExportacion.Text
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
                NombreTipoFacturacion = rb_facturar_devolucion.Text
            ElseIf rb_facturar_obsequio.Checked = True Then
                NombreTipoFacturacion = rb_facturar_obsequio.Text
            ElseIf rb_facturar_obsequio_sin_pedido.Checked = True Then
                NombreTipoFacturacion = rb_facturar_obsequio_sin_pedido.Text
            End If
            If MessageBox.Show("Se va a generar el registro con Tipo de Facturación : " & vbCrLf & NombreTipoFacturacion.Substring(1) & vbCrLf & " y con  Documento : " & cboTipoDoc.Text & vbCrLf & " ¿ Desea continuar ?", "Confirmaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GbCabecera.Enabled = False
                gbTipoFacturacion.Enabled = False
            Else
                Exit Sub
            End If
        End If
        If dgvDetalle.Rows.Count() = NumeroItemsDocumentos() Then
            MsgBox("Ya alcanzo el numero maximo de Lineas permitido para este Tipo de Documento.", MsgBoxStyle.Exclamation)
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
            frmArticulo._valida_stock = _VALIDA_STOCK
            Dim _CANTIDAD As String
            Dim _CANTIDAD_TOTAL_LOTE As Double = 0.0
            Dim _CANTIDAD_LOTE As Double = 0.0
            Dim _DIF_CANTIDAD As Double = 0.0
            Dim _LOTE As String = dgvDetalle.Item(5, dgvDetalle.CurrentRow.Index).Value.ToString
            _CANTIDAD = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value
            If rbFacturaDirecta.Checked = True Or rb_facturar_pedido.Checked Or rb_facturar_obsequio.Checked Or rbfacturaExportacion.Checked Or rb_facturar_obsequio_sin_pedido.Checked Then frmArticulo.Flag_Factura_directa = True
            If rbfacturaExportacion.Checked Then frmArticulo.Flag_Factura_Exportacion = True
            If rb_facturar_pedido.Checked Or rb_facturar_obsequio.Checked Or rbfacturaExportacion.Checked Then
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
            frmArticulo.ValidacionLotes = DatosLotes()
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

                row("OBSERVACIONES") = item("OBSERVACIONES").ToString

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

                        item("OBSERVACIONES") = frmArticulo.dtdetalleArticulo.Rows(0).Item("OBSERVACIONES")

                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                        Calcular_Totales()
                    Next
                End If
            End If
            If dgvDetalle.Rows.Count() <> 0 Then
                If _cliente_retenedor = "1" Then
                    Dim _monto As Double = 0
                    _monto = CDbl(txtPrecioVenta.Text)
                    If cboMoneda.SelectedValue = "ME" Then
                        _monto = _monto * CDbl(txtTipoCambio.Text)
                    End If
                    If _monto >= 700 Then
                        _monto = CDbl(txtPrecioVenta.Text)
                        _monto = Math.Round(_monto - Math.Round(_monto * 0.03, 2), 2)
                    End If
                    txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & _monto
                Else
                    txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & txtPrecioVenta.Text
                End If
                'txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & txtPrecioVenta.Text
            Else
                txt_forma_de_pago2.Text = ""
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
                If rb_facturar_pedido.Checked = False Or rb_facturar_obsequio.Checked = False Or rbfacturaExportacion.Checked = False Then
                    RehacerSecuencia()
                End If

                Calcular_Totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
        If dgvDetalle.Rows.Count() <> 0 Then
            If _cliente_retenedor = "1" Then
                Dim _monto As Double = 0
                _monto = CDbl(txtPrecioVenta.Text)
                If cboMoneda.SelectedValue = "ME" Then
                    _monto = _monto * CDbl(txtTipoCambio.Text)
                End If
                If _monto >= 700 Then
                    _monto = CDbl(txtPrecioVenta.Text)
                    _monto = Math.Round(_monto - Math.Round(_monto * 0.03, 2), 2)
                End If
                txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & _monto
            Else
                txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & txtPrecioVenta.Text
            End If
            'txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & txtPrecioVenta.Text
        Else
            txt_forma_de_pago2.Text = ""
        End If
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
            If Modo_consultar = False And Modo_editar = False And cboTipoDoc.Text = "PF" Then
                btn_cliente_nuevo.Visible = True
                Calcular_Totales()
            Else
                btn_cliente_nuevo.Visible = False
                Calcular_Totales()
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
        If rbFacturaGuiaVenta.Checked = True Or rb_facturar_devolucion.Checked Or rb_facturar_pedido.Checked Or rbFacturaRepMedico.Checked Or rb_facturar_obsequio.Checked Or rbfacturaExportacion.Checked Then
            If rb_facturar_pedido.Checked Or rb_facturar_obsequio.Checked Or rbfacturaExportacion.Checked Then
                cboTipoDoc.Enabled = True
            Else
                checkSinGuia.Checked = True
                checkSinGuia.Enabled = False
                'gbOpciones.Enabled = False
            End If
        ElseIf rbFacturaExistencias.Checked = True Or rbsinDescargo.Checked = True Then
            If Modo_consultar Then
                If txtdetalleguiadoc.Text = "" And txtdetalleguiaserie.Text = "" And txtdetalleguianumero.Text = "" Then
                    checkSinGuia.Checked = True
                    checkSinGuia.Enabled = True
                    cboTipoDoc.Enabled = True
                    'gbOpciones.Enabled = True
                Else
                    checkSinGuia.Checked = False
                    checkSinGuia.Enabled = True
                    cboTipoDoc.Enabled = True
                    'gbOpciones.Enabled = True
                End If
            ElseIf Modo_editar Then
                If txttipoDocRef.Text = "" And txtSerieDocRef.Text = "" And txtNumDocRef.Text = "" Then
                    checkSinGuia.Checked = True
                    checkSinGuia.Enabled = True
                    cboTipoDoc.Enabled = True
                    ' gbOpciones.Enabled = True
                Else
                    checkSinGuia.Checked = False
                    checkSinGuia.Enabled = True
                    cboTipoDoc.Enabled = True
                    '  gbOpciones.Enabled = True
                End If
            Else
                If rbsinDescargo.Checked = True Then
                    checkSinGuia.Checked = True
                    checkSinGuia.Enabled = True
                    ' gbOpciones.Enabled = False
                ElseIf rbFacturaExistencias.Checked Then
                    checkSinGuia.Checked = True
                    checkSinGuia.Enabled = False
                    ' gbOpciones.Enabled = False
                End If

            End If

        Else
            If Modo_consultar Then
                If txtdetalleguiadoc.Text = "" And txtdetalleguiaserie.Text = "" And txtdetalleguianumero.Text = "" Then
                    If cboTipoDoc.Text = "FT" Then
                        checkSinGuia.Checked = False
                    Else
                        checkSinGuia.Checked = True
                    End If
                    cboTipoDoc.Enabled = True
                    checkSinGuia.Enabled = True
                    'gbTipoGuia.Visible = True
                    'txtGlosaGuia.Visible = True
                    rbunalinea.Checked = True
                    GroupBox8.Text = "&Tipo de la Glosa del Documento"
                Else
                    checkSinGuia.Checked = False
                    cboTipoDoc.Enabled = True
                    checkSinGuia.Enabled = True
                    'gbTipoGuia.Visible = True
                    'txtGlosaGuia.Visible = True
                    rbunalinea.Checked = True
                    GroupBox8.Text = "&Tipo de la Glosa del Documento"
                End If
            Else

                If cboTipoDoc.Text = "FT" Then
                    checkSinGuia.Checked = False
                Else
                    checkSinGuia.Checked = True
                End If
                cboTipoDoc.Enabled = True
                checkSinGuia.Enabled = True
                'gbTipoGuia.Visible = True
                'txtGlosaGuia.Visible = True
                rbunalinea.Checked = True
                GroupBox8.Text = "&Tipo de la Glosa del Documento"
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
            gbTipoGuia.Visible = False
        Else
            txtCodTrans.Enabled = True
            txtGlosaGuia.Enabled = True
            txtGlosaGuia.Visible = True
            ' AjustarTamaño(False)
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


    Private Sub TipoDocumento(ByVal CAJA_TEXO As TextBox)
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "ALM_SP_S_WAREHOUSE_TIPO_DOCUMENTO_III"
        frm.CadenaConsulta = sql
        frm.Titulo = "Tipo de Documentos de Referencias"
        frm._Flag_Filtro = True
        frm.Filtros1 = cboSerieDoc.Text
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            CAJA_TEXO.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
        End If
        frm.Close()
        txtNumDocRef.Focus()
    End Sub

    Private Sub txttipoDocRef_DoubleClick(sender As Object, e As EventArgs) Handles txttipoDocRef.DoubleClick
        TipoDocumento(txttipoDocRef)
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

    Private Sub Ayuda_NumeroDocumentosReferencia(Optional ByVal _tipo_doc As String = "")
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_R_RECEIVABLE_NOTA_C"
            frm.CadenaConsulta = sql
            frm.Filtros1 = _tipo_doc 'txtPtoVenta.Text
            frm._Flag_Filtro = True
            frm.Titulo = "Documentos Facturados"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtNumDocRef.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtSerieDocRef.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                _FECHA_REFERENCIA = CDate(frm.Data_Matriz.Rows(0).Item(4).ToString).ToString("dd/MM/yyyy")
                txt_fecha_ref.Text = _FECHA_REFERENCIA
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
        If cboTipoDoc.Text = "NC" Or cboTipoDoc.Text = "ND" Then
            If rb_facturar_devolucion.Checked Then
                If txttipoDocRef.Text <> "RD" Then Exit Sub
                Ayuda_NumeroDocumentosDevoluciones()
            Else
                'If txttipoDocRef.Text <> "FT" Then Exit Sub
                Ayuda_NumeroDocumentosReferencia(txttipoDocRef.Text)
            End If
        End If
        If rbsinDescargo.Checked Then
            If txttipoDocRef.Text <> "GR" Then Exit Sub
            Ayuda_NumeroDocumentosReferenciaGuias()
        End If
    End Sub

    Private Sub txttipoDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txttipoDocRef.KeyDown
        If e.KeyCode = Keys.F1 Then
            TipoDocumento(txttipoDocRef)
        End If
        If e.KeyCode = Keys.Enter Then
            If txttipoDocRef.Text = "" Then
                TipoDocumento(txttipoDocRef)
            Else
                txtNumDocRef.Focus()
            End If

        End If
    End Sub

    'Private Sub dtpFechaFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFechaFactura.KeyPress
    '    'If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    'End Sub

    Private Sub cboTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboSerieDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSerieDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtCodCliente.Focus() ' SendKeys.Send("{TAB}")
    End Sub

    Private Sub txttipoDocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipoDocRef.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    'Private Sub txtVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVendedor.KeyPress
    '    If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    'End Sub

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
        If flag_inicio = True Then
            DocumentosFactura()
        End If

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
                    btnGenerarCP.Visible = False
                End If
            Else
                MsgBox("Ya se Generó un Comprobante de Percepcion." & vbCrLf & " Nro Documento: CP - " & dtVerificar.Rows(0).Item("NUMBER_COMP_PER").ToString, MsgBoxStyle.Information)
                ' gbGenerarCP.Visible = False
                btnGenerarCP.Visible = False
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
            txtPtoVenta.Select()
        Else
            Limpiar()
            cboTipoDoc.Enabled = True
            checkSinGuia.Checked = False
            checkSinGuia.Enabled = True
            'gbOpciones.Enabled = True
            btnAgregar.Enabled = True
            btnquitar.Enabled = True
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
            End If
            txtNumDocRef.Text = String.Empty
            txtPtoVenta.Select()
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
            'gbOpciones.Enabled = True
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
            If rbFacturaGuiaVenta.Checked Then
                dtDetalleFact = clsFacturaBl.Get_ClienteDocumento(txtCodCliente.Text, txtAlmacen.Text)
            ElseIf rbFacturaRepMedico.Checked Then
                dtDetalleFact = clsFacturaBl.Get_ClienteDocumento_Representante_Medico(txtVendedor.Text, txtAlmacen.Text)
            End If
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

                txtFiltroCliente.Text = String.Empty
                'txtFiltroCliente.Select()
                lblDetalle.Text = "Guia representante medico"
            Else
                If rbFacturaGuiaVenta.Checked Then
                    MsgBox("El Cliente no posee ninguna Guia de Venta.", MsgBoxStyle.Information, "Sistemas")
                ElseIf rbFacturaRepMedico.Checked Then
                    MsgBox("El representante medico no posee ninguna Guia de Venta.", MsgBoxStyle.Information, "Sistemas")
                End If
                pnlDocumentosGuiaVenta.Visible = False
                GenerarColummnaDataTable()
                txtNumDocRef.Text = String.Empty
                txtVendedor.Select()
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
            Dim contador As Integer = 0
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
                    If rbFacturaRepMedico.Checked Then
                        txtNumDocRef.Text += ListaDocCliente(i).Trim & ","
                        NumerosDocClientes += ListaDocCliente(i).Trim & ","
                        contador += 1
                    Else
                        txtNumDocRef.Text += "GS-" & ListaDocCliente(i).Trim & ","
                        NumerosDocClientes = NumerosDocClientes & """" & ListaDocCliente(i).Trim & """" & ","
                        contador += 1
                    End If
                    If contador = 1 Then
                        clsFacturaBl = New ClsNegocio.RECEIVABLE
                        Dim _dt_cabecera_primera_guia = New DataTable
                        _dt_cabecera_primera_guia = clsFacturaBl.Get_Cabecera_primera_guia(Mid(NumerosDocClientes, 1, NumerosDocClientes.Trim.Length - 1))
                        If _dt_cabecera_primera_guia.Rows.Count <> 0 Then
                            txtcotizacion.Text = IIf(IsDBNull(_dt_cabecera_primera_guia.Rows(0).Item(34).ToString), "", _dt_cabecera_primera_guia.Rows(0).Item(34).ToString)
                            txtordenCompra.Text = IIf(IsDBNull(_dt_cabecera_primera_guia.Rows(0).Item(30).ToString), "", _dt_cabecera_primera_guia.Rows(0).Item(30).ToString)
                            txtpedido.Text = IIf(IsDBNull(_dt_cabecera_primera_guia.Rows(0).Item(33).ToString), "", _dt_cabecera_primera_guia.Rows(0).Item(33).ToString)
                        Else
                            txtcotizacion.Text = ""
                            txtordenCompra.Text = ""
                            txtpedido.Text = ""
                        End If
                    End If
                Next
                txtNumDocRef.Text = Mid(txtNumDocRef.Text, 1, txtNumDocRef.Text.Trim.Length - 1)
                NumerosDocClientes = Mid(NumerosDocClientes, 1, NumerosDocClientes.Trim.Length - 1)
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                _DT_SALDO_INICIAL = New DataTable
                _SALDO_INICIAL = 0.0
                _DT_SALDO_INICIAL = clsFacturaBl.Get_ClienteDetallesDocumento(NumerosDocClientes)
                _FLAG_INICIAL = True
                GenerarColummnaDataTable()
                If rbFacturaRepMedico.Checked Then
                    dtdetalleArticuloPrincipal = clsFacturaBl.Get_ClienteDetallesDocumento_Rep_Medico("GS", NumerosDocClientes)
                Else
                    dtdetalleArticuloPrincipal = clsFacturaBl.Get_ClienteDetallesDocumento(NumerosDocClientes)
                End If
                If _DT_SALDO_INICIAL.Rows.Count() <> 0 Then
                    If rbFacturaGuiaVenta.Checked Then
                        dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    ElseIf rbFacturaRepMedico.Checked Then
                        If dtdetalleArticuloPrincipal.Rows.Count() = 0 Then
                            MsgBox("Guia elegida se facturo en su totalidad.", MsgBoxStyle.Information, "Sistemas")
                            gbOpciones.Enabled = False
                            Exit Sub
                        Else
                            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                        End If
                    End If
                    ' RehacerSecuencia()
                    gbOpciones.Enabled = True
                    btnquitar.Enabled = True
                    'btnAgregar.Enabled = False
                Else
                    MsgBox("No hay informacion disponible, en el Detalle", MsgBoxStyle.Critical)
                    gbOpciones.Enabled = False
                End If
                GbCabecera.Enabled = True
                pnlDocumentosGuiaVenta.Visible = False
                txtFiltroCliente.Text = String.Empty
                txtFormaPago.Select()
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
        txt_cod_emp_trans.Text = ""
        txt_des_emp_trans.Text = ""
        txt_obs_despachos.Text = ""
        txt_cod_transportista.Text = ""
        txt_des_transportista_despacho.Text = ""
        pnlConfirmarDespacho.Visible = True
        dtpDespacho.Value = Date.Now()
        btnDespacho.Enabled = False
    End Sub

    Private Sub btn_AceptarDesp_Click(sender As Object, e As EventArgs) Handles btn_AceptarDesp.Click
        Try
            If MessageBox.Show("¿Desea Generar el  Despacho.?", "Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If String.IsNullOrEmpty(txtdetalleserie.Text) Or String.IsNullOrEmpty(txtdetallenumero.Text) Then
                    MsgBox("Los numero del Documento no se cargo.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                If clsFacturaBl.GenerarDespacho(txtdetalledoc.Text, txtdetalleserie.Text & txtdetallenumero.Text, _
                                             dtpDespacho.Value.ToString("dd/MM/yyyy"), LibComunVar.ClsVarComun.USUARIO, IIf(RadioButton7.Checked, txt_emp_trans_manual.Text.Trim, txt_des_emp_trans.Text.Trim), txt_obs_despachos.Text.Trim, IIf(RadioButton4.Checked, txt_trans_manual_despacho.Text.Trim, txt_des_transportista_despacho.Text.Trim), IIf(rb_manual_datos_vehiculo.Checked, txt_datos_vehiculo.Text.Trim, txt_des_datos_vehiculo.Text.Trim)) Then
                    MsgBox("Generacion de despacho realizado correctamente", MsgBoxStyle.Information)

                    clsFacturaBl = New ClsNegocio.RECEIVABLE
                    dtValidacion = New DataTable("Validacion")
                    dtValidacion = clsFacturaBl.Get_Validacion(txtdetalledoc.Text, txtdetalleserie.Text)
                    If dtValidacion.Rows.Count > 0 Then
                        _GENERA_ESTADO_CUENTA = dtValidacion.Rows(0).Item("IS_GENERA_ASIENTO_VENTA").ToString
                        If _GENERA_ESTADO_CUENTA = "S" Then
                            Call btnContabilizar_Click(sender, e)
                            'Exit Sub
                        End If
                    End If
                    pnlConfirmarDespacho.Visible = False
                    btnDespacho.Visible = False
                    btnDespacho.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_SalirDesp_Click(sender As Object, e As EventArgs) Handles btn_SalirDesp.Click
        pnlConfirmarDespacho.Visible = False
        btnDespacho.Enabled = True
    End Sub


    Private Sub txtGlosaGuia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGlosaGuia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rbunalinea.Checked = True Then
                e.Handled = True
                If rb_facturar_pedido.Checked Or rb_facturar_obsequio.Checked Or rbfacturaExportacion.Checked Then
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

    Private Sub btnContabilizar_Click(sender As Object, e As EventArgs) Handles btnContabilizar.Click
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

    Private Sub dtpFechaFactura_GotFocus(sender As Object, e As EventArgs) Handles dtpFechaFactura.GotFocus

    End Sub

    Private Sub dtpFechaFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaFactura.KeyDown
        Flag_Verificar = False
        If e.KeyCode = Keys.Enter Then
            If FechaFacturacion_Mes_anterior(dtpFechaFactura.Value.Month, dtpFechaFactura.Value.Year) = False Then
                'btnCancelar_Click(sender, e)
                'Else
                '    If FechaFacturacion(dtpFechaFactura.Value.Month + 1, dtpFechaFactura.Value.Year) = False Then btnCancelar_Click(sender, e)
            End If
            If Modo_consultar = False Then
                validar_Fecha()
            End If
        End If
    End Sub

    Private Sub dtpFechaFactura_Leave(sender As Object, e As EventArgs) Handles dtpFechaFactura.Leave
        If Flag_Verificar = False Then
            If FechaFacturacion_Mes_anterior(dtpFechaFactura.Value.Month, dtpFechaFactura.Value.Year) = False Then
                'btnCancelar_Click(sender, e)
                'Else
                '    If FechaFacturacion(dtpFechaFactura.Value.Month + 1, dtpFechaFactura.Value.Year) = False Then
                '        btnCancelar_Click(sender, e)
                '    End If
            End If
        End If
        If Modo_consultar = False Then
            validar_Fecha()
        End If

    End Sub

    Private Sub rbDocRef_varios_CheckedChanged(sender As Object, e As EventArgs) Handles rbDocRef_varios.CheckedChanged
        If Modo_editar = True Then Exit Sub
        If cboTipoDoc.Text <> "NC" And cboTipoDoc.Text <> "ND" Then
            rbDocRef_uno.Checked = True
            Exit Sub
        End If

        If txtCodCliente.Text = "" Then
            MsgBox("Debe seleccionar un Cliente para poder Elegir esta opcion.", MsgBoxStyle.Exclamation)
            txtCodCliente.Focus()
            rbDocRef_uno.Checked = True
            Exit Sub
        End If
        pnlDocReferencia.Visible = rbDocRef_varios.Checked
        If pnlDocReferencia.Visible = True Then GenerarColummnaDataTable_Documento_Referencia()
        txttipoDocRef.Enabled = Not rbDocRef_varios.Checked
        txtSerieDocRef.Enabled = Not rbDocRef_varios.Checked
        txtNumDocRef.Enabled = Not rbDocRef_varios.Checked
        GbCabecera.Enabled = Not rbDocRef_varios.Checked
        Limpiar_FacturaNotasCredito()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            Dim row As DataRow = Dt_principal_lista_Doc_Ref.NewRow
            If txtref_tipo.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo de Doc.", MsgBoxStyle.Information)
                txtref_tipo.Focus()
                Exit Try
            End If
            If txtref_serie.Text = String.Empty Then
                MsgBox("Debe ingresar una serie.", MsgBoxStyle.Information)
                txtref_serie.Focus()
                Exit Try
            End If
            If txtref_num_doc.Text = String.Empty Then
                MsgBox("No se asigno un numero de documento.", MsgBoxStyle.Critical)
                txtref_num_doc.Focus()
                Exit Try
            End If
            If txtref_igv.Text = String.Empty Then
                MsgBox("Debe asignar el valor del Igv.", MsgBoxStyle.Critical)
                txtref_igv.Focus()
                Exit Try
            End If
            If txtref_monto.Text = String.Empty Then
                MsgBox("Debe ingresar un monto.", MsgBoxStyle.Information)
                txtref_monto.Focus()
                Exit Try
            End If
            Dim Resultado() As DataRow
            Resultado = Dt_principal_lista_Doc_Ref.Select("TIPO_DOC='" & txtref_tipo.Text & "' and SERIE_DOC='" & txtref_serie.Text & "' and NUM_DOC='" & txtref_num_doc.Text & "' ", "")
            If Resultado.Count() <> 0 Then
                MsgBox("El documento ya se ingreso anteriormente.", MsgBoxStyle.Critical)
                Exit Try
            End If

            Dim VentasBl As ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtVerficarNc As New DataTable
            dtVerficarNc = VentasBl.Verificacion_Existencia_Doc_Ref(txtref_tipo.Text, txtref_serie.Text, txtref_num_doc.Text, txtCodCliente.Text)
            If dtVerficarNc.Rows.Count() <> 0 Then
                If dtVerficarNc.Rows(0).Item("DOCUMENT_ID").ToString = "NC" Then
                    MsgBox("El numero de documento ya se encuentra  anexado en otro Documento NC: " & dtVerficarNc.Rows(0).Item("NUMBER_SERIE").ToString & " - " & dtVerficarNc.Rows(0).Item("NUMBER_DOCUMENT").ToString, MsgBoxStyle.Critical)
                ElseIf dtVerficarNc.Rows(0).Item("DOCUMENT_ID").ToString = "ND" Then
                    MsgBox("El numero de documento ya se encuentra  anexado en otro Documento ND: " & dtVerficarNc.Rows(0).Item("NUMBER_SERIE").ToString & " - " & dtVerficarNc.Rows(0).Item("NUMBER_DOCUMENT").ToString, MsgBoxStyle.Critical)
                End If
                If MsgBox("Desea agregar el documento como referencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    row("TIPO_DOC") = txtref_tipo.Text
                    row("SERIE_DOC") = txtref_serie.Text
                    row("NUM_DOC") = txtref_num_doc.Text
                    row("FECHA_DOC") = dtpRef_fecha.Value
                    row("MONTO") = txtref_monto.Text
                    row("IGV") = txtref_igv.Text
                    Dt_principal_lista_Doc_Ref.Rows.Add(row)
                    Dt_principal_lista_Doc_Ref.AcceptChanges()
                    Limpiar_Lista_Doc()
                    txtref_tipo.Focus()
                    Exit Sub
                Else
                    Exit Sub
                End If

            End If
            row("TIPO_DOC") = txtref_tipo.Text
            row("SERIE_DOC") = txtref_serie.Text
            row("NUM_DOC") = txtref_num_doc.Text
            row("FECHA_DOC") = dtpRef_fecha.Value
            row("MONTO") = txtref_monto.Text
            row("IGV") = txtref_igv.Text
            Dt_principal_lista_Doc_Ref.Rows.Add(row)
            Dt_principal_lista_Doc_Ref.AcceptChanges()
            Limpiar_Lista_Doc()
            txtref_tipo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Limpiar_Lista_Doc()
        'txtref_tipo.Text = String.Empty
        'txtref_serie.Text = String.Empty
        txtref_num_doc.Text = String.Empty
        dtpRef_fecha.Value = Date.Now
        txtref_monto.Text = String.Empty
        txtref_igv.Text = String.Empty
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        pnlDocReferencia.Visible = False
        Limpiar_Lista_Doc()
        If Dt_principal_lista_Doc_Ref.Rows.Count() = 0 Then
            rbDocRef_uno.Checked = True
        Else
            txttipoDocRef.Text = String.Empty
            txtSerieDocRef.Text = String.Empty
            txtNumDocRef.Text = String.Empty
        End If
        GbCabecera.Enabled = True
    End Sub

    Private Sub btnSalr_Click(sender As Object, e As EventArgs) Handles btnSalr.Click
        pnlDocReferencia.Visible = False
        Limpiar_Lista_Doc()
        rbDocRef_uno.Checked = True
        GbCabecera.Enabled = True
        txttipoDocRef.Text = String.Empty
        txtSerieDocRef.Text = String.Empty
        txtNumDocRef.Text = String.Empty
    End Sub

    Private Sub dgv_Lista_Doc_Ref_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_Lista_Doc_Ref.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim fila As Integer = dgv_Lista_Doc_Ref.CurrentRow.Index
            Dt_principal_lista_Doc_Ref.BeginInit()
            Dt_principal_lista_Doc_Ref.Rows(fila).Delete()
            Dt_principal_lista_Doc_Ref.EndInit()
            Dt_principal_lista_Doc_Ref.AcceptChanges()
        End If
    End Sub

    Private Sub txtref_tipo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtref_serie_Leave(sender As Object, e As EventArgs) Handles txtref_serie.Leave
        If txtref_serie.Text.Trim().Length > 0 Then
            txtref_serie.Text = txtref_serie.Text.PadLeft(3, Char.Parse("0"))
        End If
    End Sub

    Private Sub txtref_num_doc_Leave(sender As Object, e As EventArgs) Handles txtref_num_doc.Leave
        If txtref_num_doc.Text.Trim().Length > 0 Then
            txtref_num_doc.Text = txtref_num_doc.Text.PadLeft(7, Char.Parse("0"))
        End If
    End Sub

    'Private Sub txtref_tipo_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtref_tipo.KeyPress
    '    If Char.IsLower(e.KeyChar) Then
    '        txtref_tipo.SelectedText = Char.ToUpper(e.KeyChar)
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub txtref_serie_tipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtref_serie.KeyPress, txtref_num_doc.KeyPress, txtref_monto.KeyPress, txtref_igv.KeyPress, dtpRef_fecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub
    Private Sub txtref_tipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_tipo.KeyDown
        If e.KeyCode = Keys.F1 Then
            TipoDocumento(txtref_tipo)
        End If
        If e.KeyCode = Keys.Enter Then
            If txtref_tipo.Text = "" Then
                TipoDocumento(txtref_tipo)
            Else
                txtref_serie.Focus()
            End If

        End If
    End Sub

    Private Sub txtref_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_monto.KeyDown

    End Sub


    Private Sub txtref_num_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_num_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboTipoDoc.Text = "NC" Or cboTipoDoc.Text = "ND" Then
                If txtref_tipo.Text = String.Empty Then
                    MsgBox("Debe ingresar un tipo de documento.", MsgBoxStyle.Critical)
                    txtref_tipo.Focus()
                    Exit Sub
                ElseIf txtref_serie.Text = String.Empty Then
                    MsgBox("Debe ingresar una serie del documento.", MsgBoxStyle.Critical)
                    txtref_serie.Focus()
                    Exit Sub
                ElseIf txtref_tipo.Text = String.Empty Then
                    MsgBox("Debe ingresar un numero de documento.", MsgBoxStyle.Critical)
                    txtref_tipo.Focus()
                    Exit Sub
                End If
                Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
                VentasBl = New ClsOperaciones.RECEIVABLE
                Dim dtMontoDocRef As New DataTable
                dtMontoDocRef = VentasBl.Montos_Documentos_Referencia(txtref_tipo.Text, txtref_serie.Text, txtref_num_doc.Text.PadLeft(7, Char.Parse("0")), txtCodCliente.Text)
                If dtMontoDocRef.Rows.Count() <> 0 Then
                    VentasBl = New ClsOperaciones.RECEIVABLE
                    Dim dtVerficarNc As New DataTable
                    dtVerficarNc = VentasBl.Verificacion_Existencia_Doc_Ref(txtref_tipo.Text, txtref_serie.Text, txtref_num_doc.Text, txtCodCliente.Text)
                    If dtVerficarNc.Rows.Count() <> 0 Then
                        MsgBox("El numero de documento ya se encuentra  anexado en otro Documento NC: " & dtVerficarNc.Rows(0).Item("NUMBER_SERIE").ToString & " - " & dtVerficarNc.Rows(0).Item("NUMBER_DOCUMENT").ToString, MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        dtpRef_fecha.Value = dtMontoDocRef.Rows(0).Item(2).ToString
                        txtref_igv.Text = dtMontoDocRef.Rows(0).Item(0).ToString
                        txtref_monto.Text = dtMontoDocRef.Rows(0).Item(1).ToString
                    End If
                Else
                    MsgBox("No hay ningun doc registrado con la informacion brindada.", MsgBoxStyle.Information)
                    txtref_igv.Text = ""
                    txtref_monto.Text = ""
                End If
            End If
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
            'gbOpciones.Enabled = True
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

    Private Sub btn_consultando_Click(sender As Object, e As EventArgs) Handles btn_consultando.Click
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
            ' gbOpciones.Enabled = True
            btnAgregar.Enabled = True
            btnquitar.Enabled = True
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
            End If
            txtNumDocRef.Text = String.Empty
        End If
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
                pnl_pedido.Visible = True
                dgv_cab_ped.DataSource = dtv
                dgv_cab_ped.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRordenPedido = dgv_cab_ped.Columns(0).Name & "+" & dgv_cab_ped.Columns(2).Name & "+" & dgv_cab_ped.Columns(3).Name
                dgv_cab_ped.Columns(1).ReadOnly = True
                dgv_cab_ped.Columns(2).ReadOnly = True
                txt_filtrar_pedido.Text = String.Empty
                txt_filtrar_pedido.Select()
            Else
                MsgBox("No hay documentos para mostrar.", MsgBoxStyle.Information, "Sistemas")
                pnl_pedido.Visible = False
                GenerarColummnaDataTable()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_filtrar_pedido_TextChanged(sender As Object, e As EventArgs) Handles txt_filtrar_pedido.TextChanged
        Dim wbusqueda As String = UCase(txt_filtrar_pedido.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRordenPedido & " like '%" & txt_filtrar_pedido.Text & "%'"
        myCurrencyManager.Position = INTnewpos
    End Sub

    Private Sub btn_ok_pedido_Click(sender As Object, e As EventArgs) Handles btn_ok_pedido.Click
        Try
            If dgv_cab_ped.Rows.Count() = 0 Then Exit Sub
            If dgv_cab_ped.CurrentRow Is Nothing Then Exit Sub
            Dim CODIGO As String = ""
            CODIGO = dgv_cab_ped.Item(0, dgv_cab_ped.CurrentRow.Index).Value
            If CODIGO = "" Then Exit Sub
            Dim facturabl As ClsOperaciones.RECEIVABLE
            facturabl = New ClsOperaciones.RECEIVABLE
            Dim dt_pedido_cab As New DataTable

            'Dim frm_detalles As New FrmFacturacion_Detalles_Hab
            'frm_detalles._numero_requisicion = CODIGO
            'frm_detalles._tipo_requisicion = ""
            'frm_detalles.ShowDialog()
            'If frm_detalles._lista_items = String.Empty Then
            '    frm_detalles.Close()
            '    Exit Sub
            'End If
            'frm_detalles.Close()

            ''Cabecera
            Me.Cursor = Cursors.WaitCursor
            dt_pedido_cab = facturabl.Muestra_cabecera_pedido(CODIGO)
            If dt_pedido_cab.Rows.Count() <> 0 Then
                GbCabecera.Enabled = True
                txtpedido.Text = dt_pedido_cab.Rows(0).Item("ID").ToString
                txtVendedor.Text = dt_pedido_cab.Rows(0).Item("SALES_ID").ToString
                lblVendedor.Text = dt_pedido_cab.Rows(0).Item("VENDEDOR").ToString

                If LibComunVar.ClsVarComun.PUNTO_VENTA_ASIGNADO = "" Then
                    txtPtoVenta.Text = dt_pedido_cab.Rows(0).Item("PLACE_SALES").ToString
                    lblPtoVenta.Text = dt_pedido_cab.Rows(0).Item("PVENTA").ToString
                Else
                    txtPtoVenta.Text = LibComunVar.ClsVarComun.PUNTO_VENTA_ASIGNADO
                End If
                

                txtModoPago.Text = dt_pedido_cab.Rows(0).Item("MODO_PAGO").ToString
                lblModoPago.Text = dt_pedido_cab.Rows(0).Item("MODO_PAGO_DESC").ToString

                txt_Empresa.Text = dt_pedido_cab.Rows(0).Item("AGENCIA_TRANSPORTE").ToString
                txtordenCompra.Text = dt_pedido_cab.Rows(0).Item("ORDER_PURCHASE").ToString

                'txtGlosa.Text = dt_pedido_cab.Rows(0).Item("OBS_GENERAL").ToString
                'txtGlosa.Text = txtGlosa.Text & " " & dt_pedido_cab.Rows(0).Item("RECEPCION_TERCERO").ToString

                Ayuda_PuntoVenta(txtPtoVenta.Text)

                cboTipoDoc.Text = dt_pedido_cab.Rows(0).Item("TRAMA_ID").ToString
                SerieDocumentoPuntoVenta()
                txtCodCliente.Text = dt_pedido_cab.Rows(0).Item("CUSTOMER_ID").ToString
                txtRazonSocial.Text = dt_pedido_cab.Rows(0).Item("CUSTOMER_NAME").ToString
                txtDireccion.Text = dt_pedido_cab.Rows(0).Item("CUSTOMER_ADDR").ToString
                txtRucDni.Text = dt_pedido_cab.Rows(0).Item("VAT_REGISTRATION").ToString
                txtTipoCambio.Text = LibComunVar.ClsVarComun.TCVenta
                txtFormaPago.Text = dt_pedido_cab.Rows(0).Item("TERMS").ToString
                lblFormaPago.Text = dt_pedido_cab.Rows(0).Item("FPAGO").ToString
                _cliente_retenedor = dt_pedido_cab.Rows(0).Item("RETENTION").ToString

                txtpedido.Text = CODIGO
                cboMoneda.SelectedValue = dt_pedido_cab.Rows(0).Item("CURRENCY_ID").ToString
                Ayuda_DireccionEntrega()
                'cboDirEntrega.Text = dt_pedido_cab.Rows(0).Item("CUSTOMER_ADDR_DLV").ToString
                ''Detalles
                dtdetalleArticuloPrincipal.Rows.Clear()
                _DT_SALDO_INICIAL = New DataTable
                _DT_SALDO_INICIAL = facturabl.Muestra_detalles_pedido(CODIGO) ', frm_detalles._lista_items)
                facturabl = New ClsOperaciones.RECEIVABLE
                dtdetalleArticuloPrincipal = facturabl.Muestra_detalles_pedido(CODIGO) ', frm_detalles._lista_items)

                Dim query = (From c In dtdetalleArticuloPrincipal.AsEnumerable() _
                                 Select c.Field(Of String)("CODIGO")).Distinct()
                Dim ListaProductos = query.ToList()
                _ARTS_INICIALES = String.Empty
                For Each Fil In ListaProductos
                    _ARTS_INICIALES = _ARTS_INICIALES & """" & Fil & """" & ","
                Next
                If _ARTS_INICIALES.Length() <> 0 Then
                    _ARTS_INICIALES = Mid(_ARTS_INICIALES, 1, _ARTS_INICIALES.Length - 1)
                End If
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    pnl_pedido.Visible = False
                    txt_filtrar_pedido.Text = String.Empty
                    txtPtoVenta.Select()
                    Calcular_Totales()
                Else
                    MsgBox("No hay informacion disponible, en el Detalle", MsgBoxStyle.Critical)
                    gbOpciones.Enabled = False
                End If

                Dim frm_pedido_detalle As FrmFacturacion_Detalle_Pedido
                frm_pedido_detalle = New FrmFacturacion_Detalle_Pedido
                frm_pedido_detalle._numero_pedido = txtpedido.Text
                frm_pedido_detalle.ShowDialog()
                btn_detalle_pedido.Visible = True

                If _cliente_retenedor = "1" Then
                    Dim _monto As Double = 0
                    _monto = CDbl(txtPrecioVenta.Text)
                    If cboMoneda.SelectedValue = "ME" Then
                        _monto = _monto * CDbl(txtTipoCambio.Text)
                    End If
                    If _monto >= 700 Then
                        _monto = CDbl(txtPrecioVenta.Text)
                        _monto = Math.Round(_monto - Math.Round(_monto * 0.03, 2), 2)
                    End If
                    txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & _monto
                Else
                    txt_forma_de_pago2.Text = "CREDITO|N° de Cuotas:1|Fecha Pago: " & Get_FormaPagoFechaVencimiento().ToString("dd/MM/yyyy") & "|Monto: " & txtPrecioVenta.Text
                End If

            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_salir_pedido_Click(sender As Object, e As EventArgs) Handles btn_salir_pedido.Click
        pnl_pedido.Visible = False
        dgv_cab_ped.DataSource = Nothing
        txt_filtrar_pedido.Text = String.Empty
        GbCabecera.Enabled = True
        gbOpciones.Enabled = True
        btn_detalle_pedido.Visible = False
    End Sub

    Private Sub rb_facturar_pedido_CheckedChanged(sender As Object, e As EventArgs) Handles rb_facturar_pedido.CheckedChanged
        If Modo_consultar = True Or Modo_editar Then btn_detalle_pedido.Visible = True : Exit Sub
        'txtCodCliente.Enabled = Not rb_facturar_pedido.Checked
        'txtVendedor.Enabled = Not rb_facturar_pedido.Checked
        'txtFormaPago.Enabled = Not rb_facturar_pedido.Checked
        ''btnquitar.Visible = Not rb_facturar_pedido.Checked
        ''btnAgregar.Visible = Not rb_facturar_pedido.Checked
        'cboTipoDoc.Enabled = Not rb_facturar_pedido.Checked
        If rb_facturar_pedido.Checked = True Then
            Limpiar()
            checkSinGuia.Checked = True
            pnl_pedido.Visible = True
            dgv_cab_ped.DataSource = Nothing
            GbCabecera.Enabled = False
            MostrandoDocumentoPedidos()
        Else
            pnl_pedido.Visible = False
            dtdetalleArticuloPrincipal.Rows.Clear()
            dgv_cab_ped.DataSource = Nothing
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
        Modo_consultar = False

        Ref_DOCUMENT_ID = String.Empty
        Ref_NUMBER_SERIE = String.Empty
        Ref_NUMBER_DOCUMENT = String.Empty
        Ref_ALMACEN = String.Empty
        Dim Store As String = String.Empty
        Dim msj As String = String.Empty
        Dim Usuario As String = String.Empty
        If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
        If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then
            MsgBox("El documento elegido no puede MODIFICARSE. Verifique!!!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If
        If Ref_DOCUMENT_ID = "CP" Then Exit Sub
        ''Validaciones propias de la edicion de la Facturacion
        'Verificando Cancelacion
        Store = "FACT_SP_S_R_VERIFICAR_CANCEL"
        If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
            msj = String.Empty
            msj = "EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " posee una Cancelacion, no se puede modificar."
            MsgBox(msj, MsgBoxStyle.Critical)
            'btnCancelar.PerformClick()
            Exit Sub
        Else
            'Verificando si posee Letra
            Store = String.Empty
            Store = "FACT_SP_S_R_VERIFICAR_LETRA"
            If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                msj = String.Empty
                msj = "EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " forma parte de un canje por Letra, no se puede modificar."
                MsgBox(msj, MsgBoxStyle.Critical)
                'btnCancelar.PerformClick()
                Exit Sub
            Else
                Store = String.Empty
                Store = "FACT_SP_S_R_VERIFICAR_CONTABILIZACION"
                If VerificarDocumentos(Store, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then
                    msj = String.Empty
                    msj = "EL Documento:   " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & vbCrLf & " esta contabilizado, no se puede modificar."
                    MsgBox(msj, MsgBoxStyle.Critical)
                    ' btnCancelar.PerformClick()
                    Exit Sub
                End If
            End If
        End If

        If MessageBox.Show("¿Desea modificar el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Mostrando resultados
            Botonera_Estado_Cambiar(True)
            MostrarModoConsultar(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
            pnlPrincipal.Visible = False
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
            gbTipoFacturacion.Enabled = False
            txtPtoVenta.Enabled = False
            btnGenerarCP.Visible = False
            btnDespacho.Visible = False
            Dim Estado As String = String.Empty
            Estado = dgvDocumentosFactura.Item(6, dgvDocumentosFactura.CurrentRow.Index).Value
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
                pnl_devoluciones.Visible = True
                dgv_detalle_dev.DataSource = Nothing
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
                Motrando_detalles_devolucion(frm.Data_Matriz.Rows(0).Item(0).ToString, frm.Data_Matriz.Rows(0).Item(1).ToString, txtAlmacen.Text)
                Ayuda_Clientes(frm.Data_Matriz.Rows(0).Item(2).ToString)
            Else
                pnl_devoluciones.Visible = False
                GbCabecera.Enabled = True
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Motrando_detalles_devolucion(ByVal Tipo As String, ByVal Numero As String, ByVal Almacen As String)
        Try
            Dim FacturaBl As New ClsOperaciones.RECEIVABLE
            dtv = New DataView
            dtv = FacturaBl.Documentos_Detalle_devoluciones(Tipo, Numero, Almacen).DefaultView
            dgv_detalle_dev.DataSource = dtv
            dgv_detalle_dev.AutoResizeColumns()
            dgv_detalle_dev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            STRordenDevol = dgv_detalle_dev.Columns(3).Name & "+" & dgv_detalle_dev.Columns(6).Name & "+" & dgv_detalle_dev.Columns(7).Name
            For i As Integer = 0 To dgv_detalle_dev.Columns.Count - 1
                dgv_detalle_dev.Columns(i).ReadOnly = True
            Next
            dgv_detalle_dev.Columns(0).ReadOnly = False
            For i As Integer = 8 To 19
                dgv_detalle_dev.Columns(i).Visible = False
            Next
            dgv_detalle_dev.Columns(28).Visible = False
            dgv_detalle_dev.Columns(1).Visible = False
            dgv_detalle_dev.Columns(24).Visible = False

            dgv_detalle_dev.Columns(25).HeaderText = "TIP. DOC. REF."
            dgv_detalle_dev.Columns(26).HeaderText = "SER. DOC. REF."
            dgv_detalle_dev.Columns(27).HeaderText = "N° DOC. REF."

            dgv_detalle_dev.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle_dev.Columns(4).DefaultCellStyle.Format = "N2"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub rb_facturar_devolucion_CheckedChanged(sender As Object, e As EventArgs) Handles rb_facturar_devolucion.CheckedChanged
        If Modo_consultar = True Or Modo_editar Then Exit Sub
        txtCodCliente.Enabled = Not rb_facturar_devolucion.Checked
        btnAgregar.Visible = Not rb_facturar_devolucion.Checked
        btnquitar.Visible = Not rb_facturar_devolucion.Checked
        cboTipoDoc.Enabled = Not rb_facturar_devolucion.Checked
        dtdetalleArticuloPrincipal.Rows.Clear()
        dgv_detalle_dev.DataSource = Nothing
        If rb_facturar_devolucion.Checked = True Then
            Limpiar()
        Else
            gbOpciones.Enabled = True
            btnAgregar.Visible = True
            btnquitar.Visible = True
        End If
    End Sub

    Private Sub btn_devolucion_ok_Click(sender As Object, e As EventArgs) Handles btn_devolucion_ok.Click
        Try
            If dgv_detalle_dev.RowCount = 0 Then Exit Sub
            Dim estado As Boolean = False
            For Each rows As DataGridViewRow In dgv_detalle_dev.Rows
                If rows.Cells(0).Value = True Then
                    estado = True
                    Exit For
                End If
            Next
            If estado = False Then
                MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dgv_detalle_dev.Focus()
                Exit Sub
            End If
            '++++
            GenerarColummnaDataTable()
            GenerarColummnaDataTable_Documento_Referencia()
            For Each fila As DataGridViewRow In dgv_detalle_dev.Rows
                If fila.Cells(0).Value = True Then
                    Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                    row("ITEM") = fila.Cells("ITEM").Value.ToString() 'dtdetalleArticuloPrincipal.Rows.Count() + 1
                    row("CODIGO") = fila.Cells("CODIGO").Value.ToString()
                    row("CANTIDAD") = fila.Cells("CANTIDAD").Value.ToString()
                    row("UNIDAD") = fila.Cells("UNIDAD").Value.ToString()
                    row("DESCRIPCION") = fila.Cells("DESCRIPCION").Value.ToString()
                    row("LOTE") = fila.Cells("LOTE").Value.ToString()
                    row("PREC_UNITARIO") = fila.Cells("PREC_UNITARIO").Value.ToString()
                    row("%DESC.ART_1") = fila.Cells("%DESC.ART_1").Value.ToString()
                    row("%DESC.ART_2") = fila.Cells("%DESC.ART_2").Value.ToString()
                    row("VALOR_VENTA") = fila.Cells("VALOR_VENTA").Value.ToString()
                    row("IMP_DESC_01") = fila.Cells("IMP_DESC_01").Value.ToString()
                    row("IMP_DESC_02") = fila.Cells("IMP_DESC_02").Value.ToString()
                    row("PRECIO_IGV") = fila.Cells("PRECIO_IGV").Value.ToString()
                    row("IGV_ART") = fila.Cells("IGV_ART").Value.ToString()
                    row("IGV_ART_US") = fila.Cells("IGV_ART_US").Value.ToString()
                    row("IMPORTE") = fila.Cells("IMPORTE").Value.ToString()
                    row("PRECIO_INICIAL") = fila.Cells("PRECIO_INICIAL").Value.ToString()
                    row("TOTAL_INICIAL") = fila.Cells("TOTAL_INICIAL").Value.ToString()
                    row("ITEM_INI") = fila.Cells("ITEM_INI").Value.ToString()
                    row("IGV_POR") = 18
                    IGV_POR_ITEM = row("IGV_POR")
                    dtdetalleArticuloPrincipal.Rows.Add(row)
                    dtdetalleArticuloPrincipal.AcceptChanges()

                    Dim rowss As DataRow = Dt_principal_lista_Doc_Ref.NewRow
                    rowss("TIPO_DOC") = fila.Cells("TD_REF").Value.ToString()
                    rowss("SERIE_DOC") = fila.Cells("SERIE_REF").Value.ToString()
                    rowss("NUM_DOC") = fila.Cells("NUM_DOC_REF").Value.ToString()
                    rowss("FECHA_DOC") = ""
                    rowss("MONTO") = CDbl(fila.Cells("IMPORTE").Value) - CDbl(fila.Cells("IGV_ART").Value)
                    rowss("IGV") = CDbl(fila.Cells("IGV_ART").Value)
                    Dt_principal_lista_Doc_Ref.Rows.Add(rowss)
                    Dt_principal_lista_Doc_Ref.AcceptChanges()

                End If
            Next
            btn_devolucion_salir.PerformClick()
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                Calcular_Totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_devolucion_salir_Click(sender As Object, e As EventArgs) Handles btn_devolucion_salir.Click
        txt_busqueda_dev.Text = ""
        pnl_devoluciones.Visible = False
        txtPtoVenta.Select()
        GbCabecera.Enabled = True
        gbOpciones.Enabled = True
    End Sub

    Private Sub txt_busqueda_dev_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_dev.TextChanged
        Dim wbusqueda As String = UCase(txt_busqueda_dev.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRordenDevol & " like '%" & txt_busqueda_dev.Text & "%'"
        myCurrencyManager.Position = INTnewpos
    End Sub

    Private Sub dgv_detalle_dev_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_detalle_dev.CurrentCellDirtyStateChanged
        dgv_detalle_dev.CommitEdit(DataGridViewDataErrorContexts.Commit)
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
    Private Sub Ayuda_Vehiculos_Despachos()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_VEHICULOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Vehiculos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_datos_vehiculo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_datos_vehiculo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
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

    Private Sub dtpFechaFactura_LostFocus(sender As Object, e As EventArgs) Handles dtpFechaFactura.LostFocus

    End Sub

    Private Sub dtpFechaFactura_SystemColorsChanged(sender As Object, e As EventArgs) Handles dtpFechaFactura.SystemColorsChanged

    End Sub

    Private Sub dtpFechaFactura_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFactura.ValueChanged
        If Modo_consultar = False Then
            validar_Fecha()
        End If
    End Sub

    Private Sub txtNumDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumDocRef.KeyDown
        If e.KeyCode = Keys.F1 Then
            If txtPtoVenta.Text = String.Empty Then
                MsgBox("Debe seleccionar un Punto Venta.", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf txttipoDocRef.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If cboTipoDoc.Text = "NC" Or cboTipoDoc.Text = "ND" Then
                If rb_facturar_devolucion.Checked Then
                    If txttipoDocRef.Text <> "RD" Then Exit Sub
                    Ayuda_NumeroDocumentosDevoluciones()
                Else
                    'If txttipoDocRef.Text <> "FT" Then Exit Sub
                    Ayuda_NumeroDocumentosReferencia(txttipoDocRef.Text)
                End If
            End If
            If rbsinDescargo.Checked Then
                If txttipoDocRef.Text <> "GR" Then Exit Sub
                Ayuda_NumeroDocumentosReferenciaGuias()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If txtNumDocRef.Text = "" Then
                If txtPtoVenta.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Punto Venta.", MsgBoxStyle.Exclamation)
                    Exit Sub
                ElseIf txttipoDocRef.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If cboTipoDoc.Text = "NC" Or cboTipoDoc.Text = "ND" Then
                    If rb_facturar_devolucion.Checked Then
                        If txttipoDocRef.Text <> "RD" Then Exit Sub
                        Ayuda_NumeroDocumentosDevoluciones()
                    Else
                        'If txttipoDocRef.Text <> "FT" Then Exit Sub
                        Ayuda_NumeroDocumentosReferencia(txttipoDocRef.Text)
                    End If
                End If
                If rbsinDescargo.Checked Then
                    If txttipoDocRef.Text <> "GR" Then Exit Sub
                    Ayuda_NumeroDocumentosReferenciaGuias()
                End If
            Else
                txtCodCliente.Focus()
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panel_estado_cuenta.Visible = False
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
                    If txtpassword.Text = STRPassSys Then
                        estado = True
                        Exit Try
                    ElseIf txtpassword.Text <> STRPassSys Then
                        MessageBox.Show("El password ingresado es incorrecto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        estado = False
                        Exit Try
                    End If
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dtDatosCompany.Rows.Count() > 0 Then
            If total_soles > CDbl(dtDatosCompany.Rows(0).Item("CREDIT_LIMIT").ToString) And total_dolares > CDbl(dtDatosCompany.Rows(0).Item("CREDIT_LIMIT_US").ToString) Then
                If txtpassword.Text = String.Empty Then
                    MessageBox.Show("Debe ingresar un contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpassword.Focus()
                    Exit Sub
                End If
                If ValidarUsuariosIngreso() = False Then
                    txtpassword.Text = ""
                    txtpassword.Focus()
                    Exit Sub
                Else
                    panel_estado_cuenta.Visible = False
                End If
            ElseIf contador_doc_vencidos > 0 Then
                If txtpassword.Text = String.Empty Then
                    MessageBox.Show("Debe ingresar un contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpassword.Focus()
                    Exit Sub
                End If
                If ValidarUsuariosIngreso() = False Then
                    txtpassword.Text = ""
                    txtpassword.Focus()
                    Exit Sub
                Else
                    panel_estado_cuenta.Visible = False
                End If
            Else
                panel_estado_cuenta.Visible = False
            End If
        End If


        If cboTipoDoc.Text = "FT" Then
            If CodigoNumeraciondocumentoGeneral() = False Then
                MsgBox("Es necesario una Numeracion para la Factura", MsgBoxStyle.Information)
                Exit Sub
            End If
            If checkSinGuia.Checked = False Then
                If CodigoNumeracionGuiaRemision() = False Then
                    MsgBox("Es necesario una Numeracion para la Guia Remision.", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
        Else
            If CodigoNumeraciondocumentoGeneral() = False Then
                MsgBox("Es necesario una Numeracion para el documento a emitir.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If checkSinGuia.Checked = False Then
                If CodigoNumeracionGuiaRemision() = False Then
                    MsgBox("Es necesario una Numeracion para la Guia Remision.", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
        End If
        _GENERA_COMP_PER = ""
        _GENERA_DETRACCION = ""
        clsFacturaBl = New ClsNegocio.RECEIVABLE
        dtValidacion = New DataTable("Validacion")
        dtValidacion = clsFacturaBl.Get_Validacion(cboTipoDoc.Text, cboSerieDoc.Text)
        If dtValidacion.Rows.Count > 0 Then
            _GENERA_COMP_PER = dtValidacion.Rows(0).Item("IS_GENERA_COMP_PER").ToString
            _GENERA_DETRACCION = dtValidacion.Rows(0).Item("IS_GENERA_DETRACCION").ToString
        End If
        If _GENERA_COMP_PER = "S" Then
            '---Comprbante de Percepcion
            If MessageBox.Show("¿Desea Generar Comprobante de Percepcion.?", "Comprobante Percepcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        End If
        If _GENERA_DETRACCION = "S" Then
            '-------Detraccion 
            If MessageBox.Show("¿Documento Sujeto a Detraccion.?", "Detraccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        End If
        Me.Cursor = Cursors.WaitCursor
        If GuardarFacturacion() = True Then
            'Botonera_Estado_Cambiar(False)
            'DocumentosFactura()

            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtValidacion = New DataTable("Validacion")
            dtValidacion = clsFacturaBl.Get_Validacion(cboTipoDoc.Text, cboSerieDoc.Text)
            If dtValidacion.Rows.Count > 0 Then
                _GENERA_ESTADO_CUENTA = dtValidacion.Rows(0).Item("IS_GENERA_CANJE_LETRA").ToString
                If _GENERA_ESTADO_CUENTA = "S" Then
                    Dim FrmLetras As New FrmLetras
                    'FrmLetras.MdiParent = Me
                    OpenSubForm(FrmLetras)
                    'Exit Sub
                End If
            End If
            Nuevo()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txt_cod_emp_trans_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_emp_trans.KeyDown
        If e.KeyCode = Keys.F1 Then
            Lista_Transportistas()
        End If
    End Sub

    Private Sub txt_cod_emp_trans_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_emp_trans.MouseDoubleClick
        Lista_Transportistas()
    End Sub
    Private Sub Lista_Transportistas()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "FACT_SP_S_EMPRESA_TRANSPORTE"
        frm.CadenaConsulta = sql
        frm.Titulo = "Empresa de Transporte"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_emp_trans.Text = frm.Data_Matriz.Rows(0).Item(0)
            txt_des_emp_trans.Text = frm.Data_Matriz.Rows(0).Item(1)
        End If
        frm.Close()
        txt_cod_transportista.Focus()
    End Sub

    Private Sub txt_cod_transportista_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_transportista.KeyDown
        If e.KeyCode = Keys.F1 Then
            Lista_Transportistas_Despachos()
        End If
    End Sub

    Private Sub txt_cod_transportista_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_transportista.MouseDoubleClick
        Lista_Transportistas_Despachos()
    End Sub
    Private Sub Lista_Transportistas_Despachos()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "SAL_HLP_CARRIER"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Transportistas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_transportista.Text = frm.Data_Matriz.Rows(0).Item(0)
            txt_des_transportista_despacho.Text = frm.Data_Matriz.Rows(0).Item(1)
        End If
        frm.Close()
        txt_obs_despachos.Focus()
    End Sub
    Private Sub Lista_Datos_Vehiculo_Despachos()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "SAL_HLP_CARRIER"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Vehiculo"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_transportista.Text = frm.Data_Matriz.Rows(0).Item(0)
            txt_des_transportista_despacho.Text = frm.Data_Matriz.Rows(0).Item(1)
        End If
        frm.Close()
        txt_obs_despachos.Focus()
    End Sub


    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            txt_cod_transportista.Enabled = True
            txt_cod_transportista.Text = ""
            txt_des_transportista_despacho.Text = ""
            txt_trans_manual_despacho.Enabled = False
            txt_trans_manual_despacho.Text = ""
            txt_cod_transportista.Focus()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            txt_cod_transportista.Enabled = False
            txt_cod_transportista.Text = ""
            txt_des_transportista_despacho.Text = ""
            txt_trans_manual_despacho.Enabled = True
            txt_trans_manual_despacho.Text = ""
            txt_trans_manual_despacho.Focus()
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            txt_cod_emp_trans.Text = ""
            txt_des_emp_trans.Text = ""
            txt_cod_emp_trans.Enabled = False
            txt_des_emp_trans.Enabled = False
            txt_emp_trans_manual.Text = ""
            txt_emp_trans_manual.Enabled = True
            txt_emp_trans_manual.Focus()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            txt_cod_emp_trans.Text = ""
            txt_des_emp_trans.Text = ""
            txt_cod_emp_trans.Enabled = True
            txt_des_emp_trans.Enabled = False
            txt_emp_trans_manual.Text = ""
            txt_emp_trans_manual.Enabled = False
            txt_cod_emp_trans.Focus()
        End If
    End Sub


    Private Sub txt_cod_datos_vehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_datos_vehiculo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vehiculos_Despachos()
        End If
    End Sub

    Private Sub txt_cod_datos_vehiculo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_datos_vehiculo.MouseDoubleClick
        Ayuda_Vehiculos_Despachos()
    End Sub


    Private Sub txt_ref_guia_Devolucion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ref_guia_Devolucion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Consulta As String
            Dim dtDetalles As DataTable

            Consulta = "SELECT DOCUMENT_ID,NUMBER_SERIE,NUMBER_DOCUMENT,DOCUMENT_DATE " _
                      & "FROM RECEIVABLE WHERE NUM_GUIA_DEVOLUCION='" & txt_ref_guia_Devolucion.Text & "' AND CUSTOMER_ID='" & txtCodCliente.Text & "' AND STATUS<>'A' "
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
                txt_ref_guia_Devolucion.Focus()
            End If
        End If
    End Sub

    Private Sub rb_manual_datos_vehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_manual_datos_vehiculo.CheckedChanged
        If rb_manual_datos_vehiculo.Checked = True Then
            txt_cod_datos_vehiculo.Enabled = False
            txt_cod_datos_vehiculo.Text = ""
            txt_des_datos_vehiculo.Text = ""
            txt_datos_vehiculo.Enabled = True
            txt_datos_vehiculo.Text = ""
            txt_datos_vehiculo.Focus()
        End If
    End Sub

    Private Sub rb_electivo_datos_vehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_electivo_datos_vehiculo.CheckedChanged
        If rb_electivo_datos_vehiculo.Checked = True Then
            txt_cod_datos_vehiculo.Enabled = True
            txt_cod_datos_vehiculo.Text = ""
            txt_des_datos_vehiculo.Text = ""
            txt_datos_vehiculo.Enabled = False
            txt_datos_vehiculo.Text = ""
            txt_cod_datos_vehiculo.Focus()
        End If
    End Sub

    Private Sub rb_facturar_obsequio_CheckedChanged(sender As Object, e As EventArgs) Handles rb_facturar_obsequio.CheckedChanged
        'If Modo_consultar = True Or Modo_editar = True Then Exit Sub
        'If rb_facturar_obsequio.Checked = True Then
        '    Limpiar()
        '    txtPtoVenta.Select()
        'End If

        If Modo_consultar = True Or Modo_editar Then btn_detalle_pedido.Visible = True : Exit Sub
        If rb_facturar_obsequio.Checked = True Then
            Limpiar()
            pnl_pedido.Visible = True
            dgv_cab_ped.DataSource = Nothing
            GbCabecera.Enabled = False
            MostrandoDocumentoPedidos()
        Else
            pnl_pedido.Visible = False
            dtdetalleArticuloPrincipal.Rows.Clear()
            dgv_cab_ped.DataSource = Nothing
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
        End If
    End Sub

    Private Sub pnlPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles pnlPrincipal.Paint

    End Sub

    Private Sub txtref_tipo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtref_tipo.MouseDoubleClick
        TipoDocumento(txtref_tipo)
    End Sub

    Private Sub txt_cod_tipo_nota_electronica_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_tipo_nota_electronica.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Tipo_Nota_Electronica()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_tipo_nota_electronica.Text = String.Empty Then
                Ayuda_Tipo_Nota_Electronica()
            Else
                txtCodTrans.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cod_tipo_nota_electronica_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_tipo_nota_electronica.MouseDoubleClick
        Ayuda_Tipo_Nota_Electronica()
    End Sub
    Private Sub Ayuda_Tipo_Nota_Electronica()
        Try

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_TIPO_NOTA_ELECTRONICA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = cboTipoDoc.Text
            frm.Titulo = "Tipo de Nota Electronica"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_tipo_nota_electronica.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_desc_tipo_nota_electronica.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ToolStrip1.Enabled = True
        pnlPrincipal.Enabled = True
        pnl_motivo_anulacion.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txt_motivo_anulacion.Text.Trim = "" Then
            MsgBox("Debe ingresar un motivo de anulación.", MsgBoxStyle.Critical)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        'Anulacion Factura 
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

        If MessageBox.Show("¿Desea Anular el Documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor

            If AnularFacturas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "", WareHouse, txt_motivo_anulacion.Text.Trim) = False Then
                MsgBox("Hubo un error, no se completo el Proceso de Anulacion", MsgBoxStyle.Exclamation)
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                'If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Then
                '    If Generar_Txt_Comunicacion_Baja(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, dtp_fecha_anulacion.Value.ToString("dd/MM/yyyy")) = False Then
                '        MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " no genero el archivo TXT de Comunicación de Baja." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                '        Me.Cursor = Cursors.Default
                '    Else
                '        DocumentosFactura()
                '        Button5_Click(sender, e)
                '        Dim msj As String
                '        msj = String.Empty
                '        msj = "Documento Anulado Correctamente." & vbCrLf & " Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                '        MsgBox(msj, MsgBoxStyle.Information)
                '        Me.Cursor = Cursors.Default
                '    End If
                'End If

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
                                    Button5_Click(sender, e)
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
                    Button5_Click(sender, e)
                    Dim msj As String
                    msj = String.Empty
                    msj = "Documento Anulado Correctamente." & vbCrLf & "Nro Documento: " & Ref_DOCUMENT_ID & " - " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT
                    MsgBox(msj, MsgBoxStyle.Information)
                End If
            End If

            Me.Cursor = Cursors.Default
        End If
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
    Private Function Generar_Txt_Comunicacion_Baja(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Fecha_baja As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_Txt_Comunicacion_Baja(TipoDoc, SerieDoc, NumDoc, Ruta_FE_Verificacion() & "\Input", Fecha_baja) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Generar_XML_Comunicacion_Baja(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Fecha_baja As String, _
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

    Private Sub btn_enviar_mail_Click(sender As Object, e As EventArgs) Handles btn_enviar_mail.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Try
            Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String, Envio_Mail_Cliente As String, REF_COD_ALMACEN As String
            Dim dtCabeceraFact As DataTable
            Dim _fecha_doc As Date
            Dim _EMAIL_RECEPCIONANTE As String = ""
            Dim StrNomArchivo_PDF As String = ""
            Dim StrNomArchivo_XML As String = ""
            Dim StrNomArchivo_CDR As String = ""
            Dim StrNomArchivo_PDF_GS As String = ""
            Dim StrNomArchivo_XML_GS As String = ""
            Dim mensaje_ As String = ""

            Ref_DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("DOCUMENT_ID").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_DOCUMENT").Value
            Envio_Mail_Cliente = dgvDocumentosFactura.CurrentRow.Cells("ENVIO_MAIL").Value
            REF_COD_ALMACEN = dgvDocumentosFactura.CurrentRow.Cells("COD_ALMACEN").Value

            If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then

                clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
                dtCabeceraFact = New DataTable

                dtCabeceraFact = clsFacturaCabBl.get_CabecearaFacturacion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Strings.Right(Ref_NUMBER_DOCUMENT, 7))
                If dtCabeceraFact.Rows.Count() <> 0 Then
                    _fecha_doc = dtCabeceraFact.Rows(0).Item("CREATE_DATE")
                    _EMAIL_RECEPCIONANTE = dtCabeceraFact.Rows(0).Item("EMAIL")
                Else
                    Exit Sub
                End If

                'BUSCAMOS LOS ARCHIVOS PDF Y XML DESDE LA RUTA GENERAL DEL SERVIDOR
                'PDF
                StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", _
                                    IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & _
                                    Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                If File.Exists(StrNomArchivo_PDF) = False Then
                    StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & Format(_fecha_doc.Month, "00") & "\" &
                                        Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                    If File.Exists(StrNomArchivo_PDF) = True Then
                        If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".PDF" & Chr(13) & _
                                    "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If
                    Else
                        Dim msj As String = ""
                        msj = String.Empty
                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                        MsgBox(msj, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If

                'XML
                StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & _
                                    IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", _
                                    IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"
                If File.Exists(StrNomArchivo_XML) = False Then
                    StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & Format(_fecha_doc.Month, "00") &
                                        "\" & Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

                    If File.Exists(StrNomArchivo_XML) = True Then
                        If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".XML" & Chr(13) & _
                                    "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If
                    Else
                        Dim msj As String = ""
                        msj = String.Empty
                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                        MsgBox(msj, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If

                'CDR
                StrNomArchivo_CDR = Ruta_FE_Verificacion() & "CDR\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & _
                                    IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", _
                                    IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"
                If File.Exists(StrNomArchivo_CDR) = False Then
                    StrNomArchivo_CDR = Ruta_FE() & "\Output\Send\CDR\" & LibComunVar.ClsVarComun.RucEmpresa & "\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

                    If File.Exists(StrNomArchivo_CDR) = True Then
                        If Copiar_Archivos(StrNomArchivo_CDR, Ruta_FE_Verificacion() & "CDR") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".CDR" & Chr(13) & _
                                    "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If
                    Else
                        Dim msj As String = ""
                        msj = String.Empty
                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".cdr"
                        MsgBox(msj, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
                'FIN DE BUSCAMOS LOS ARCHIVOS PDF Y XML DESDE LA RUTA GENERAL DEL SERVIDOR

                StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", _
                                    IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & _
                                    Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                If File.Exists(StrNomArchivo_PDF) = False Then
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                    MsgBox(msj, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", _
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & _
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

                    If File.Exists(StrNomArchivo_XML) = False Then
                        Dim msj As String = ""
                        msj = String.Empty
                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                        MsgBox(msj, MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        StrNomArchivo_CDR = Ruta_FE_Verificacion() & "CDR\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", _
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & _
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

                        If File.Exists(StrNomArchivo_CDR) = False Then
                            Dim msj As String = ""
                            msj = String.Empty
                            msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".cdr"
                            MsgBox(msj, MsgBoxStyle.Critical)
                            Exit Sub
                        Else
                            If Envio_Mail_Cliente = "SI" Then
                                mensaje_ = "Los archivos electronicos ya se enviarón en un Mail anterior"
                                If MessageBox.Show("Los archivos electronicos ya se enviarón en un Mail anterior!!!" & Chr(13) & "¿Desea Continuar con el envio?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    '**************
                                    Dim GuiaBl As New ClsBuscar
                                    Dim dtDatosGuia As New DataTable
                                    dtDatosGuia = GuiaBl.Get_GuiasAsociadas(REF_COD_ALMACEN, Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7), Ref_DOCUMENT_ID)
                                    If dtDatosGuia.Rows.Count() <> 0 Then
                                        If Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 1) = "T" Then

                                            If MessageBox.Show("Dese adjuntar la guia del comprobante?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                                StrNomArchivo_PDF_GS = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                    Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                    "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                                                If File.Exists(StrNomArchivo_PDF_GS) = False Then
                                                    StrNomArchivo_PDF_GS = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & _
                                                                            Format(_fecha_doc.Month, "00") & "\" & Format(_fecha_doc.Day, "00") & "\" & _
                                                                            LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                            Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                            "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                                                    If File.Exists(StrNomArchivo_PDF_GS) Then
                                                        If Copiar_Archivos(StrNomArchivo_PDF_GS, Ruta_FE_Verificacion() & "PDF") = False Then
                                                            MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".PDF" & Chr(13) &
                                                                   "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                                        End If
                                                    Else
                                                        Dim msj As String = ""
                                                        msj = String.Empty
                                                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"
                                                        MsgBox(msj, MsgBoxStyle.Information)
                                                        Exit Sub
                                                    End If
                                                End If

                                                StrNomArchivo_XML_GS = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                        Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                        "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"

                                                If File.Exists(StrNomArchivo_XML_GS) = False Then
                                                    StrNomArchivo_XML_GS = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & _
                                                                            Format(_fecha_doc.Month, "00") & "\" & Format(_fecha_doc.Day, "00") & "\" & _
                                                                            LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                            Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                            "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"

                                                    If File.Exists(StrNomArchivo_XML_GS) Then
                                                        If Copiar_Archivos(StrNomArchivo_XML_GS, Ruta_FE_Verificacion() & "XML") = False Then
                                                            MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".XML" & Chr(13) &
                                                                   "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                                        End If
                                                    Else
                                                        Dim msj As String = ""
                                                        msj = String.Empty
                                                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"
                                                        MsgBox(msj, MsgBoxStyle.Information)
                                                        Exit Sub
                                                    End If
                                                End If

                                                Dim envio_mail As New FrmEnvioEmail_FT_GS
                                                envio_mail._document_id = Ref_DOCUMENT_ID
                                                envio_mail._serie_document = Ref_NUMBER_SERIE
                                                envio_mail._number_document = Ref_NUMBER_DOCUMENT

                                                envio_mail._serie_document_gs = Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7)
                                                envio_mail._number_document_gs = Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000")

                                                envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                                envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                                envio_mail._nombre_documento_gs = "09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000")
                                                envio_mail._archivo_pdf = StrNomArchivo_PDF
                                                envio_mail._archivo_xml = StrNomArchivo_XML
                                                envio_mail._archivo_cdr = StrNomArchivo_CDR
                                                envio_mail._archivo_pdf_gs = StrNomArchivo_PDF_GS
                                                envio_mail._archivo_xml_gs = StrNomArchivo_XML_GS
                                                envio_mail._codigo_datos_email = "99"
                                                envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                                envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                                envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                                IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))

                                                envio_mail._nombre_tipo_documento_gs = "GUÍA DE REMISION REMITENTE ELECTRÓNICA"

                                                envio_mail._tipo_moneda = IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                                envio_mail._monto_documento = dgvDocumentosFactura.CurrentRow.Cells("MONTO").Value
                                                envio_mail._fecha_documento = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value


                                                envio_mail.ShowDialog()
                                                envio_mail.Close()

                                            Else
                                                Dim envio_mail As New FrmEnvioEmail
                                                envio_mail._document_id = Ref_DOCUMENT_ID
                                                envio_mail._serie_document = Ref_NUMBER_SERIE
                                                envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                                envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                                envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                                envio_mail._archivo_pdf = StrNomArchivo_PDF
                                                envio_mail._archivo_xml = StrNomArchivo_XML
                                                envio_mail._archivo_cdr = StrNomArchivo_CDR
                                                envio_mail._codigo_datos_email = "99"
                                                envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                                envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                                envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                                IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                                envio_mail._tipo_moneda = IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                                envio_mail._monto_documento = dgvDocumentosFactura.CurrentRow.Cells("MONTO").Value
                                                envio_mail._fecha_documento = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value


                                                envio_mail.ShowDialog()
                                                envio_mail.Close()
                                            End If
                                        Else
                                            Dim envio_mail As New FrmEnvioEmail
                                            envio_mail._document_id = Ref_DOCUMENT_ID
                                            envio_mail._serie_document = Ref_NUMBER_SERIE
                                            envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                            envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                            envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                            envio_mail._archivo_pdf = StrNomArchivo_PDF
                                            envio_mail._archivo_xml = StrNomArchivo_XML
                                            envio_mail._archivo_cdr = StrNomArchivo_CDR
                                            envio_mail._codigo_datos_email = "99"
                                            envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                            envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                            envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                            envio_mail._tipo_moneda = IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                            envio_mail._monto_documento = dgvDocumentosFactura.CurrentRow.Cells("MONTO").Value
                                            envio_mail._fecha_documento = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value


                                            envio_mail.ShowDialog()
                                            envio_mail.Close()
                                        End If
                                    Else
                                        Dim envio_mail As New FrmEnvioEmail
                                        envio_mail._document_id = Ref_DOCUMENT_ID
                                        envio_mail._serie_document = Ref_NUMBER_SERIE
                                        envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                        envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                        envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                        envio_mail._archivo_pdf = StrNomArchivo_PDF
                                        envio_mail._archivo_xml = StrNomArchivo_XML
                                        envio_mail._archivo_cdr = StrNomArchivo_CDR
                                        envio_mail._codigo_datos_email = "99"
                                        envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                        envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                        envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                        envio_mail._tipo_moneda = IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                        envio_mail._monto_documento = dgvDocumentosFactura.CurrentRow.Cells("MONTO").Value
                                        envio_mail._fecha_documento = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value


                                        envio_mail.ShowDialog()
                                        envio_mail.Close()
                                    End If
                                    '**************
                                End If
                            ElseIf Envio_Mail_Cliente = "NO" Then

                                '**************
                                Dim GuiaBl As New ClsBuscar
                                Dim dtDatosGuia As New DataTable
                                dtDatosGuia = GuiaBl.Get_GuiasAsociadas(REF_COD_ALMACEN, Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7), Ref_DOCUMENT_ID)
                                If dtDatosGuia.Rows.Count() <> 0 Then
                                    If Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 1) = "T" Then

                                        If MessageBox.Show("Dese adjuntar la guia del comprobante?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                            StrNomArchivo_PDF_GS = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                                            If File.Exists(StrNomArchivo_PDF_GS) = False Then
                                                StrNomArchivo_PDF_GS = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & _
                                                                        Format(_fecha_doc.Month, "00") & "\" & Format(_fecha_doc.Day, "00") & "\" & _
                                                                        LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                        Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                        "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                                                If File.Exists(StrNomArchivo_PDF_GS) Then
                                                    If Copiar_Archivos(StrNomArchivo_PDF_GS, Ruta_FE_Verificacion() & "PDF") = False Then
                                                        MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".PDF" & Chr(13) &
                                                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                                    End If
                                                Else
                                                    Dim msj As String = ""
                                                    msj = String.Empty
                                                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"
                                                    MsgBox(msj, MsgBoxStyle.Information)
                                                    Exit Sub
                                                End If
                                            End If

                                            StrNomArchivo_XML_GS = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                    Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                    "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"

                                            If File.Exists(StrNomArchivo_XML_GS) = False Then
                                                StrNomArchivo_XML_GS = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & _
                                                                        Format(_fecha_doc.Month, "00") & "\" & Format(_fecha_doc.Day, "00") & "\" & _
                                                                        LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                        Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                        "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"

                                                If File.Exists(StrNomArchivo_XML_GS) Then
                                                    If Copiar_Archivos(StrNomArchivo_XML_GS, Ruta_FE_Verificacion() & "XML") = False Then
                                                        MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".XML" & Chr(13) &
                                                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                                    End If
                                                Else
                                                    Dim msj As String = ""
                                                    msj = String.Empty
                                                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"
                                                    MsgBox(msj, MsgBoxStyle.Information)
                                                    Exit Sub
                                                End If
                                            End If

                                            Dim envio_mail As New FrmEnvioEmail_FT_GS
                                            envio_mail._document_id = Ref_DOCUMENT_ID
                                            envio_mail._serie_document = Ref_NUMBER_SERIE
                                            envio_mail._number_document = Ref_NUMBER_DOCUMENT

                                            envio_mail._serie_document_gs = Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7)
                                            envio_mail._number_document_gs = Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000")

                                            envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                            envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                            envio_mail._nombre_documento_gs = "09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000")
                                            envio_mail._archivo_pdf = StrNomArchivo_PDF
                                            envio_mail._archivo_xml = StrNomArchivo_XML
                                            envio_mail._archivo_cdr = StrNomArchivo_CDR
                                            envio_mail._archivo_pdf_gs = StrNomArchivo_PDF_GS
                                            envio_mail._archivo_xml_gs = StrNomArchivo_XML_GS
                                            envio_mail._codigo_datos_email = "99"
                                            envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                            envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                            envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))

                                            envio_mail._nombre_tipo_documento_gs = "GUÍA DE REMISION REMITENTE ELECTRÓNICA"

                                            envio_mail._tipo_moneda = IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                            envio_mail._monto_documento = dgvDocumentosFactura.CurrentRow.Cells("MONTO").Value
                                            envio_mail._fecha_documento = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value


                                            envio_mail.ShowDialog()
                                            envio_mail.Close()

                                        Else
                                            Dim envio_mail As New FrmEnvioEmail
                                            envio_mail._document_id = Ref_DOCUMENT_ID
                                            envio_mail._serie_document = Ref_NUMBER_SERIE
                                            envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                            envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                            envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                            envio_mail._archivo_pdf = StrNomArchivo_PDF
                                            envio_mail._archivo_xml = StrNomArchivo_XML
                                            envio_mail._archivo_cdr = StrNomArchivo_CDR
                                            envio_mail._codigo_datos_email = "99"
                                            envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                            envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                            envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                            envio_mail._tipo_moneda = IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                            envio_mail._monto_documento = dgvDocumentosFactura.CurrentRow.Cells("MONTO").Value
                                            envio_mail._fecha_documento = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value


                                            envio_mail.ShowDialog()
                                            envio_mail.Close()
                                        End If
                                    Else
                                        Dim envio_mail As New FrmEnvioEmail
                                        envio_mail._document_id = Ref_DOCUMENT_ID
                                        envio_mail._serie_document = Ref_NUMBER_SERIE
                                        envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                        envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                        envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                        envio_mail._archivo_pdf = StrNomArchivo_PDF
                                        envio_mail._archivo_xml = StrNomArchivo_XML
                                        envio_mail._archivo_cdr = StrNomArchivo_CDR
                                        envio_mail._codigo_datos_email = "99"
                                        envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                        envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                        envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                        envio_mail._tipo_moneda = IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                        envio_mail._monto_documento = dgvDocumentosFactura.CurrentRow.Cells("MONTO").Value
                                        envio_mail._fecha_documento = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value


                                        envio_mail.ShowDialog()
                                        envio_mail.Close()
                                    End If
                                Else
                                    Dim envio_mail As New FrmEnvioEmail
                                    envio_mail._document_id = Ref_DOCUMENT_ID
                                    envio_mail._serie_document = Ref_NUMBER_SERIE
                                    envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                    envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                    envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                    envio_mail._archivo_pdf = StrNomArchivo_PDF
                                    envio_mail._archivo_xml = StrNomArchivo_XML
                                    envio_mail._archivo_cdr = StrNomArchivo_CDR
                                    envio_mail._codigo_datos_email = "99"
                                    envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                    envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                    envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                            IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                    envio_mail._tipo_moneda = IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                    envio_mail._monto_documento = dgvDocumentosFactura.CurrentRow.Cells("MONTO").Value
                                    envio_mail._fecha_documento = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value


                                    envio_mail.ShowDialog()
                                    envio_mail.Close()
                                End If
                                '************** 
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Ruta_FE_Verificacion() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE_Verificacion = mySetting("Ruta_FE_Verificacion")
        Return STRRuta_FE_Verificacion
    End Function


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

    Private Sub btn_act_vendedor_Click(sender As Object, e As EventArgs) Handles btn_act_vendedor.Click
        Try
            If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
            Dim STREstado As String = String.Empty
            STREstado = dgvDocumentosFactura.CurrentRow.Cells("Estado").Value
            If STREstado = "ANULADO" Then
                MessageBox.Show("El Documento esta anulado. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ToolStrip1.Enabled = False
            pnlPrincipal.Enabled = False
            pnl_vendedor.Visible = True
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtCabeceraFact = New DataTable
            Dim _DOCUMENT_ID As String, _NUMBER_SERIE As String, _NUMBER_DOCUMENT As String
            _DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("DOCUMENT_ID").Value
            _NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value
            _NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_DOCUMENT").Value

            TextBox12.Text = "ACTUALIZANDO DATOS - " & _DOCUMENT_ID & " " & _NUMBER_SERIE & "-" & _NUMBER_DOCUMENT

            dtCabeceraFact = clsFacturaCabBl.get_Vendedor_Registrado(_DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
            If dtCabeceraFact.Rows.Count > 0 Then
                txt_vend_ant.Text = dtCabeceraFact.Rows(0).Item("COD_VENDEDOR").ToString
                txt_vend_ant_desc.Text = dtCabeceraFact.Rows(0).Item("VENDEDOR").ToString
                txt_fp_ant.Text = dtCabeceraFact.Rows(0).Item("COD_FP").ToString
                txt_fp_ant_desc.Text = dtCabeceraFact.Rows(0).Item("FP").ToString
                txt_mp_ant.Text = dtCabeceraFact.Rows(0).Item("COD_MP").ToString
                txt_mp_ant_desc.Text = dtCabeceraFact.Rows(0).Item("MP").ToString
            Else
                txt_vend_ant.Text = ""
                txt_vend_ant_desc.Text = ""
                txt_fp_ant.Text = ""
                txt_fp_ant_desc.Text = ""
                txt_mp_ant.Text = ""
                txt_mp_ant_desc.Text = ""
            End If

            txt_vend_act.Text = ""
            txt_vend_act_desc.Text = ""
            txt_fp_act.Text = ""
            txt_fp_act_desc.Text = ""
            txt_mp_act.Text = ""
            txt_mp_act_desc.Text = ""

            txt_vend_act.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_vend_act_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_vend_act.MouseDoubleClick
        Ayuda_Vendedor_Act(txt_vend_act, txt_vend_act_desc)
    End Sub

    Private Sub txt_vend_act_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_vend_act.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor_Act(txt_vend_act, txt_vend_act_desc)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_vend_ant.Text = "" Then
                Ayuda_Vendedor_Act(txt_vend_act, txt_vend_act_desc)
            Else
                Button6.Focus()
            End If
        End If
    End Sub
    Private Sub Ayuda_Vendedor_Act(cajaTexto As TextBox, cajaDescTexto As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_RECEIVABLE_VENDEDOR"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Lista de Vendedores"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                cajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0)
                cajaDescTexto.Text = frm.Data_Matriz.Rows(0).Item(1)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnl_vendedor.Visible = False
        ToolStrip1.Enabled = True
        pnlPrincipal.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            'If String.IsNullOrEmpty(txt_vend_act.Text) And String.IsNullOrEmpty(txt_vend_act_desc.Text) Then
            '    MsgBox("No se ingreso ningun vendedor.", MsgBoxStyle.Exclamation)
            '    Me.Cursor = Cursors.Default
            '    Exit Sub
            'End If
            'If txt_vend_ant.Text = txt_vend_act.Text Then
            '    MsgBox("No se puede actualizar por el mismo vendedor. Verifique!", MsgBoxStyle.Exclamation)
            '    Me.Cursor = Cursors.Default
            '    Exit Sub
            'End If

            If MessageBox.Show("¿Desea actualizar los datos del documento?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim _DOCUMENT_ID As String, _NUMBER_SERIE As String, _NUMBER_DOCUMENT As String
                _DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("DOCUMENT_ID").Value
                _NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value
                _NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_DOCUMENT").Value

                clsFacturaBl = New ClsNegocio.RECEIVABLE
                If clsFacturaBl.Generar_Datos_Act_vendedor(_DOCUMENT_ID, _NUMBER_DOCUMENT, _NUMBER_SERIE, LibComunVar.ClsVarComun.USUARIO, _
                                             txt_vend_act.Text.Trim, txt_fp_act.Text, txt_mp_act.Text) Then
                    MsgBox("Actualización correcta.", MsgBoxStyle.Information)
                    DocumentosFactura()
                    Button3_Click(sender, e)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Forma_Pago_Act(cajaTexto As TextBox, cajaDescTexto As TextBox)
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
                cajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0)
                cajaDescTexto.Text = frm.Data_Matriz.Rows(0).Item(1)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Modo_Pago(cajaTexto As TextBox, cajaDescTexto As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_MODO_COBRO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Modo de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                cajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0)
                cajaDescTexto.Text = frm.Data_Matriz.Rows(0).Item(1)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_fp_act_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fp_act.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Forma_Pago_Act(txt_fp_act, txt_fp_act_desc)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_fp_act.Text = "" Then
                Ayuda_Forma_Pago_Act(txt_fp_act, txt_fp_act_desc)
            Else
                Button6.Focus()
            End If
        End If
    End Sub

    Private Sub txt_fp_act_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_fp_act.MouseDoubleClick
        Ayuda_Forma_Pago_Act(txt_fp_act, txt_fp_act_desc)
    End Sub

    Private Sub txt_mp_act_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_mp_act.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Modo_Pago(txt_mp_act, txt_mp_act_desc)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_mp_act.Text = "" Then
                Ayuda_Modo_Pago(txt_mp_act, txt_mp_act_desc)
            Else
                Button6.Focus()
            End If
        End If
    End Sub

    Private Sub txt_mp_act_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_mp_act.MouseDoubleClick
        Ayuda_Modo_Pago(txt_mp_act, txt_mp_act_desc)
    End Sub

    Private Sub rbfacturaExportacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbfacturaExportacion.CheckedChanged
        'If Modo_consultar = True Or Modo_editar = True Then Exit Sub
        'If rbfacturaExportacion.Checked = True Then
        '    Limpiar()
        '    txtPtoVenta.Select()
        'End If

        If Modo_consultar = True Or Modo_editar Then btn_detalle_pedido.Visible = True : Exit Sub
        If rbfacturaExportacion.Checked = True Then
            Limpiar()
            pnl_pedido.Visible = True
            dgv_cab_ped.DataSource = Nothing
            GbCabecera.Enabled = False
            MostrandoDocumentoPedidos()
        Else
            pnl_pedido.Visible = False
            dtdetalleArticuloPrincipal.Rows.Clear()
            dgv_cab_ped.DataSource = Nothing
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pnl_forma_de_pago.Visible = True
        GbCabecera.Enabled = False
        txt_forma_de_pago.Focus()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pnl_forma_de_pago.Visible = False
        GbCabecera.Enabled = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_detalle_pedido.Click
        Dim frm_pedido_detalle As FrmFacturacion_Detalle_Pedido
        frm_pedido_detalle = New FrmFacturacion_Detalle_Pedido
        frm_pedido_detalle._numero_pedido = txtpedido.Text
        frm_pedido_detalle.ShowDialog()
    End Sub

    Private Sub btn_descargar_archivos_Click(sender As Object, e As EventArgs) Handles btn_descargar_archivos.Click

        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Ref_DOCUMENT_ID = String.Empty
            Ref_NUMBER_SERIE = String.Empty
            Ref_NUMBER_DOCUMENT = String.Empty
            Dim _fecha As Date = dgvDocumentosFactura.CurrentRow.Cells("Fecha").Value
            'Validacione Generales Reporte y consulta
            If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub

            Dim StrNomArchivo_PDF As String = ""
            Dim StrNomArchivo_XML As String = ""
            Dim StrNomArchivo_CDR As String = ""

            If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then
                Dim _ruta As String = ""
                Dim Carpeta As New FolderBrowserDialog
                If Carpeta.ShowDialog() = DialogResult.OK Then
                    _ruta = Carpeta.SelectedPath.ToString
                Else
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" &
                                   IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07",
                                    IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                If File.Exists(StrNomArchivo_PDF) Then
                    If Copiar_Archivos(StrNomArchivo_PDF, _ruta) = False Then
                        Me.Cursor = Cursors.Default
                        MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".PDF" & Chr(13) &
                                    "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        Exit Sub
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                End If

                StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-" &
                                   IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07",
                                    IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

                If File.Exists(StrNomArchivo_XML) = True Then
                    If Copiar_Archivos(StrNomArchivo_XML, _ruta) = False Then
                        Me.Cursor = Cursors.Default
                        MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".XML" & Chr(13) &
                                "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        Exit Sub
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                End If

                'StrNomArchivo_CDR = Ruta_FE_Verificacion() & "CDR\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" &
                '                   IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07",
                '                    IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

                'If File.Exists(StrNomArchivo_CDR) = True Then
                '    If Copiar_Archivos(StrNomArchivo_CDR, _ruta) = False Then
                '        Me.Cursor = Cursors.Default
                '        MsgBox("ERROR:" & Chr(13) & "El documento CDR " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".XML" & Chr(13) &
                '                "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                '        Exit Sub
                '    End If
                'Else
                '    Me.Cursor = Cursors.Default
                '    Dim msj As String = ""
                '    msj = String.Empty
                '    msj = "No existe el archivo " & vbCrLf & "R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                '    MsgBox(msj, MsgBoxStyle.Information)
                '    Exit Sub
                'End If

                MsgBox("CPE descargados correctamente.", MsgBoxStyle.Information, "Sistemas")

            End If

            Me.Cursor = Cursors.Default
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
        ToolStrip1.Enabled = True
    End Sub

    Private Sub btn_grabar_nuevo_cliente_Click(sender As Object, e As EventArgs) Handles btn_grabar_nuevo_cliente.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If txt_razon_social.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe ingresar la Razón Social del cliente.", MsgBoxStyle.Exclamation)
                txt_razon_social.Focus()
                Exit Sub
            ElseIf txt_direccion.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe ingresar la Dirección del cliente.", MsgBoxStyle.Exclamation)
                txt_direccion.Focus()
                Exit Sub
            End If

            Dim _codigo_cliente_nuevo As String
            clsBuscarBl = New ClsBuscar
            Dim dtDatos As New DataTable
            dtDatos = clsBuscarBl.Get_Cod_Cliente_nuevo()
            If dtDatos.Rows.Count > 0 Then
                _codigo_cliente_nuevo = dtDatos.Rows(0).Item("codigo").ToString
            Else
                _codigo_cliente_nuevo = ""
            End If

            Dim CONSULTA As String = String.Empty
            CONSULTA = "INSERT INTO dbo.CUSTOMER (ID, NAME, ADDR, PHONE, VAT_REGISTRATION, NUMBER_DOC, DISCOUNT_PERCENT, TERMS_TYPE, STATUS, OPEN_DATE, CONTACT, STATE_ID, CREATE_USER, CREATE_DATE, MODIFY_DATE, TYPE_PRICE, SALES_ID, SELL_ZONE, COUNTRY, " _
                    & "  DEPARTMENT, PROVINCE, ADDR_DLV, CURRENCY_CREDIT_LIMIT, CREDIT_LIMIT_US, CREDIT_LIMIT, BALANCE, BALANCE_US, OBSERV, TOTAL_LETTER, TOTAL_RECEIVABLE, TOTAL_CHECK, TOTAL_LETTER_PROTESTED, CUSTOMER_TYPE, BUSINESS_TYPE, TERRITORY, ROUTE, " _
                    & "  SEGMENT, SEGMENT_LOCATION, BANK_ID, ACCOUNT_NO, DATE_REVIEW, HOUR_VISIT, ATTENTION_TYPE, FAX_NUMBER, EMAIL, WEBSITE,COMMENT, IS_PRIMARY, RETENTION, DOCUMENT_TYPE_PERSON_ID, TYPE_COMPANY, ACCOUNT_LOCAL, ACCOUNT_EXTERNAL, NAME_COMERTIAL, " _
                    & " TYPE_DISCOUNT, FLAG_PRINCIPAL, IS_DEFAULT, AP_PATERNO, AP_MATERNO,OPT_PF,ESTADO_VALIDACION_FE) " _
                    & " VALUES ('" & _codigo_cliente_nuevo & "', '" & txt_razon_social.Text & "', '" & txt_direccion.Text & "', '', '" & _codigo_cliente_nuevo & "', '', 0, '00', 'V', GETDATE(), '', '99', '" & LibComunVar.ClsVarComun.USUARIO & "', " _
                    & " GETDATE(), GETDATE(), '', '00', '', '', '99', '99', '', '', 0, 0, 0, 0, '', 0, 0, 0, 0, '', '', '', '',  " _
                    & " '', '', '01', '', GETDATE(), '', '', '', '', '', '', '0', '0', '0', '', '121201', '121201', '', '1', '1', 'N', " _
                    & " '','','1','SI') "

            Dim clsReceivablaBl As ClsOperaciones.RECEIVABLE
            clsReceivablaBl = New ClsOperaciones.RECEIVABLE
            If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                Ayuda_Clientes(_codigo_cliente_nuevo)
                btn_cliente_nuevo.Visible = False
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

    Private Sub btn_cliente_nuevo_Click(sender As Object, e As EventArgs) Handles btn_cliente_nuevo.Click

        GbCabecera.Enabled = False
        gbdetalle.Enabled = False
        gbOpciones.Enabled = False
        ToolStrip1.Enabled = False
        txt_razon_social.Text = ""
        txt_direccion.Text = ""
        panel_cliente_nuevo.Visible = True
        txt_razon_social.Focus()
    End Sub

    Private Sub txt_razon_social_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_razon_social.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_direccion.Focus()
        End If
    End Sub

    Private Sub txt_direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_nuevo_cliente.Focus()
        End If
    End Sub

    Private Sub rb_facturar_obsequio_sin_pedido_CheckedChanged(sender As Object, e As EventArgs) Handles rb_facturar_obsequio_sin_pedido.CheckedChanged
        If Modo_consultar = True Or Modo_editar = True Then Exit Sub
        If rb_facturar_obsequio_sin_pedido.Checked = True Then
            Limpiar()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btn_sincronizar_cpe.Click

        If dtDocumentoFactura.Rows.Count = 0 Then Exit Sub

        Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String
        Dim _fecha_doc As Date


        Try
            Me.Cursor = Cursors.WaitCursor

            For Each item As DataRow In dtDocumentoFactura.Rows
                dtDocumentoFactura.BeginInit()

                Ref_DOCUMENT_ID = item("DOCUMENT_ID")
                Ref_NUMBER_SERIE = item("NUMBER_SERIE")
                Ref_NUMBER_DOCUMENT = item("NUMBER_DOCUMENT")
                _fecha_doc = item("Fecha")

                Dim StrNomArchivo_PDF As String = ""
                Dim StrNomArchivo_XML As String = ""
                If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then

                    'VERIFICAMOS SI SE ENCUENTRA EN LA RUTA DEL SERVIDOR
                    StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                    If File.Exists(StrNomArchivo_PDF) Then
                        item("SINCRONIZADO") = "Si"
                    Else
                        StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & Format(_fecha_doc.Month, "00") & "\" &
                                            Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03",
                                            IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" &
                                            Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                        If File.Exists(StrNomArchivo_PDF) Then
                            If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = True Then
                                item("SINCRONIZADO") = "Si"
                            Else
                                item("SINCRONIZADO") = ""
                            End If
                        Else
                            item("SINCRONIZADO") = ""
                        End If
                    End If


                    'VERIFICAMOS SI SE ENCUENTRA EN LA RUTA DEL SERVIDOR
                    StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & _
                                        "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & _
                                        "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

                    If File.Exists(StrNomArchivo_XML) Then
                        item("SINCRONIZADO_XML") = "Si"
                    Else
                        StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                    _fecha_doc.Year.ToString & "\" & Format(_fecha_doc.Month, "00") & "\" &
                                    Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                                    IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                                    Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                        If File.Exists(StrNomArchivo_XML) Then
                            If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = True Then
                                item("SINCRONIZADO_XML") = "Si"
                            Else
                                item("SINCRONIZADO_XML") = ""
                            End If
                        Else
                            item("SINCRONIZADO_XML") = ""
                        End If
                    End If
                End If

                dtDocumentoFactura.EndInit()
                dtDocumentoFactura.AcceptChanges()
            Next

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub pnlDocumentosGuiaVenta_Paint(sender As Object, e As PaintEventArgs) Handles pnlDocumentosGuiaVenta.Paint

    End Sub

    Private Sub btnPdfOrdenCompra_Click(sender As Object, e As EventArgs) Handles btnPdfOrdenCompra.Click
        If txtpedido.Text <> String.Empty And txtordenCompra.Text <> String.Empty Then
            Dim dtdocumentoPrin As DataTable
            dtdocumentoPrin = New DataTable

            Dim clsPedidoBl As ClsOperaciones.ORDERS
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtdocumentoPrin = clsPedidoBl.Mostrar_OrdenCompra_Pedido(txtpedido.Text)

            If dtdocumentoPrin IsNot Nothing AndAlso dtdocumentoPrin.Rows.Count > 0 Then
                If dtdocumentoPrin.Rows(0)("Archivo") IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(dtdocumentoPrin.Rows(0)("Archivo").ToString()) Then

                    Dim archivoBytes As Byte() = CType(dtdocumentoPrin.Rows(0)("Archivo"), Byte())
                    'Dim rutaDestino As String = Ruta_FE() & "\OC"
                    Dim rutaDestino As String = Path.GetTempPath()
                    Dim nombreArchivo As String = "Orden_" & txtpedido.Text & DateTime.Now.ToString("HHmmss") & ".pdf" ' o extraído si está disponible
                    Dim rutaCompleta As String = Path.Combine(rutaDestino, nombreArchivo)
                    File.WriteAllBytes(rutaCompleta, archivoBytes)
                    Try
                        ' Opcional: Abrir el PDF
                        Process.Start(rutaCompleta)

                    Catch ex As Exception
                        MessageBox.Show("Error al recuperar PDF: " & ex.Message)
                    End Try

                End If
            End If
        End If
    End Sub
End Class

