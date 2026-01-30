Imports System.Windows.Forms
Imports LibComunVar
Imports LibCobranzas
Imports System.Drawing
Imports LibContabilidad
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Collections.Specialized
Imports System.IO
Imports LibBillService.Process

Public Class Frm_Compras
    Private mySetting As NameValueCollection
    Private clsLetrasBl As ClsNegocio.PART
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Dim Modo_consultar As Boolean = False
    Dim CompraCabENT As ClsEntidades.PURCHASE_FACT_SUPPLIER
    Dim CompraImportacion As ClsEntidades.REFERENCES_DOCUMENT_IMPORTACION_COMPRAS
    Dim CompraDetENT As ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE
    Dim ListaDetalles As List(Of ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE)
    Dim dtTable As DataTable
    Dim carteraBE As LibContabilidad.ClsEntidades.CUSTOMER_BALANCE_PAY
    Dim CarteraBl As LibContabilidad.ClsOperaciones.Asiento_Contable

    Dim CompraBl As ClsOperaciones.PURCHASE_FACT_SUPPLIER

    Dim CORRELATIVOBL As ClsTransacciones.PURCHASE_FACT_SUPPLIER
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim LibData As LibConexion.ClsData
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim Fl_close As Boolean = False
    Dim TIPO_FORMULA, TIPO_PROD As String

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim _Flag_edicion As Boolean = False
    Dim dtResultados As DataTable

    Dim _Codigo_Ini As String = ""
    Dim _TipoAnexoDoc As String = ""
    Dim _TipoDato As String = ""
    Dim _NumeroTipoAnexoDoc As String = ""
    Dim _tipo_de_documento As String
    Dim Dt_principal_lista_Doc_Ref As DataTable

    Dim id_caja_chica As String = String.Empty
    Dim item_caja_chica As String = String.Empty
    Dim item As String = String.Empty
    Dim _AGENTE_RETENEDOR As String = ""
    Dim _BUEN_CONTRIBUYENTE As String = ""
    Dim _AGENTE_PERCEPCION As String = ""


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable("Detalles_Compra")
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT_REFERENCE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("FACTOR_REFERENCE", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRICE", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DISCOUNT_PER", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("DISCOUNT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT_TAX", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PERCENT_TAX", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRICE_NET", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT_TOTAL_NET", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY_OUT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("STATUS_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("COMMENT1", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("TEXT_COMMENT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("IS_VAT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PRICE_UNIT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("CCOST_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PROJECT_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("ORDEN_COMPRA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("FLAG_FREE_IGV", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("CENCOS", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CENCOS_DES", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            For i As Integer = 6 To 14
                dgvDetalle.Columns(i).DefaultCellStyle.Format = "##,##0.00"
            Next
            For i As Integer = 19 To dgvDetalle.ColumnCount() - 1
                dgvDetalle.Columns(i).Visible = False
            Next

            dgvDetalle.Columns(0).HeaderText = "Item"
            dgvDetalle.Columns(1).HeaderText = "Codigo"
            dgvDetalle.Columns(2).HeaderText = "Producto"
            dgvDetalle.Columns(3).HeaderText = "Unidad"
            dgvDetalle.Columns(4).HeaderText = "Unid.Ref"
            dgvDetalle.Columns(6).HeaderText = "Cantidad"
            dgvDetalle.Columns(7).HeaderText = "Precio"
            dgvDetalle.Columns(8).HeaderText = "%.Descuento"
            dgvDetalle.Columns(9).HeaderText = "Descuento"
            dgvDetalle.Columns(10).HeaderText = "I.g.v"
            dgvDetalle.Columns(12).HeaderText = "Valor.Venta"
            dgvDetalle.Columns(14).HeaderText = "Total"
            dgvDetalle.Columns(18).HeaderText = "Comentario"
            dgvDetalle.Columns(17).HeaderText = "Observacion"
            dgvDetalle.Columns("CENCOS").HeaderText = "Codigo Centro de Costo"
            dgvDetalle.Columns("CENCOS_DES").HeaderText = "Centro de Costo"

            dgvDetalle.Columns(5).Visible = False
            dgvDetalle.Columns(11).Visible = False
            dgvDetalle.Columns(13).Visible = False
            dgvDetalle.Columns(15).Visible = False
            dgvDetalle.Columns(16).Visible = False
            dgvDetalle.Columns("CENCOS").Visible = True
            dgvDetalle.Columns("CENCOS_DES").Visible = True
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btn_comp_retencion.Enabled = False
            'If Modo_Edicion = True Then
            '    btnGrabar.Enabled = False
            'End If

            'End If
            btn_verifica_cpe.Visible = True
            btn_act_cc.Enabled = False
            btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            btncontabilizar.Enabled = False
            Tool_Imprimir_Orden_Pago.Enabled = False
            btn_contabilizar_marcado.Enabled = False
        Else
            btnNuevo.Enabled = True
            btn_comp_retencion.Enabled = True
            btn_verifica_cpe.Visible = False
            btn_act_cc.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            btncontabilizar.Enabled = True
            Tool_Imprimir_Orden_Pago.Enabled = True
            btn_contabilizar_marcado.Enabled = True
        End If
    End Sub

    Private Sub DocumentosCompra()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtDocumentos As New DataTable
            dtv = New DataView
            dtDocumentos = CompraBl.Mostrar_Documentos_Principal(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                           cboopcionesBusqueda.SelectedIndex)
            dtv = dtDocumentos.DefaultView
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                'dgvCabecera.AutoResizeColumns()
                'dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                For i As Integer = 6 To dtDocumentos.Columns.Count - 1
                    dgvCabecera.Columns(i).Visible = False
                Next

                For i As Integer = 0 To dtDocumentos.Columns.Count - 1
                    dgvCabecera.Columns(i).ReadOnly = True
                Next

                dgvCabecera.Columns(2).Visible = False

                dgvCabecera.Columns(12).Visible = True
                dgvCabecera.Columns(23).Visible = True
                dgvCabecera.Columns(24).Visible = True
                dgvCabecera.Columns(25).Visible = True

                dgvCabecera.Columns(26).Visible = True
                dgvCabecera.Columns(27).Visible = True
                dgvCabecera.Columns(28).Visible = True
                dgvCabecera.Columns(29).Visible = False

                dgvCabecera.Columns(16).Visible = True
                dgvCabecera.Columns(17).Visible = True
                dgvCabecera.Columns(18).Visible = True
                dgvCabecera.Columns(19).Visible = True
                dgvCabecera.Columns("EXPIRATION_DATE").Visible = True
                'dgvCabecera.DataSource = dtv

                dgvCabecera.Columns(0).HeaderText = "Nro Compra"
                dgvCabecera.Columns(1).HeaderText = "Fecha"
                dgvCabecera.Columns(2).HeaderText = "Codigo"
                dgvCabecera.Columns(3).HeaderText = "Proveedor"
                dgvCabecera.Columns(4).HeaderText = "Ruc"
                dgvCabecera.Columns(5).HeaderText = "Moneda"
                dgvCabecera.Columns(12).HeaderText = "Estado"

                dgvCabecera.Columns(23).HeaderText = "Val. Afecto"
                dgvCabecera.Columns(24).HeaderText = "Val. Inafecto"
                dgvCabecera.Columns(25).HeaderText = "Val. IGV"
                dgvCabecera.Columns(26).HeaderText = "Val. Total"
                dgvCabecera.Columns(27).HeaderText = "Estado Contable"
                dgvCabecera.Columns(28).HeaderText = "N° Vou."

                dgvCabecera.Columns(0).Width = 90
                dgvCabecera.Columns(1).Width = 70
                dgvCabecera.Columns(2).Width = 80
                dgvCabecera.Columns(3).Width = 250
                dgvCabecera.Columns(4).Width = 80
                dgvCabecera.Columns(5).Width = 50
                dgvCabecera.Columns(12).Width = 60

                dgvCabecera.Columns(23).Width = 70
                dgvCabecera.Columns(24).Width = 70
                dgvCabecera.Columns(25).Width = 70
                dgvCabecera.Columns(26).Width = 70

                dgvCabecera.Columns(28).Width = 50

                dgvCabecera.Columns(23).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(24).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(25).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(26).DefaultCellStyle.Format = "N2"

                'dgvCabecera.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'dgvCabecera.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'dgvCabecera.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'dgvCabecera.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvCabecera.Columns(16).HeaderText = "Tip. Doc."
                dgvCabecera.Columns(17).HeaderText = "Ser. Doc."
                dgvCabecera.Columns(18).HeaderText = "N° Doc."
                dgvCabecera.Columns(19).HeaderText = "Fec. Emision"
                dgvCabecera.Columns("EXPIRATION_DATE").HeaderText = "Fec. Vcto."

                dgvCabecera.Columns(16).Width = 40
                dgvCabecera.Columns(17).Width = 70
                dgvCabecera.Columns(19).Width = 70

                dgvCabecera.Columns(34).ReadOnly = False
                dgvCabecera.Columns(34).Visible = True
                dgvCabecera.Columns(34).Width = 40
                dgvCabecera.Columns(35).Visible = True
                dgvCabecera.Columns(35).Width = 100

                dgvCabecera.Columns("COMPROBANTE_RETENCION").Visible = True
                dgvCabecera.Columns("COMPROBANTE_RETENCION").Width = 150
                dgvCabecera.Columns("COMPROBANTE_RETENCION").HeaderText = "Comprobante de Retención"
                dgvCabecera.Columns("FECHA_COM_PER").Visible = False

                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name & "+" & dgvCabecera.Columns(18).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cbomoneda.DataSource = monedaBL.get_TiposCambio()
        cbomoneda.ValueMember = "CODIGO"
        cbomoneda.DisplayMember = "DESCRIPCION"

        cmb_moneda_ref.DataSource = monedaBL.get_TiposCambio()
        cmb_moneda_ref.ValueMember = "CODIGO"
        cmb_moneda_ref.DisplayMember = "DESCRIPCION"

        monedaBL = Nothing
    End Sub


    Private Sub Ayuda_TipoDocumento()
        Try
            Dim CompraBl As New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtTipoDoc As New DataTable
            dtTipoDoc = CompraBl.Get_Tipo_Doc()
            cboTipoDoc_ref.ValueMember = "CODIGO"
            cboTipoDoc_ref.DisplayMember = "CODIGO"
            cboTipoDoc_ref.DataSource = dtTipoDoc
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Function Get_FormaPagoFechaVencimiento() As Date
        Dim fechaVencimiento As Date
        Try
            Dim clsBuscarBl As New ClsBuscar
            Dim dtFormaPagoFechaV As DataTable
            dtFormaPagoFechaV = clsBuscarBl.Get_FormaPagoFechaVencimiento(txtFormaPago.Text)
            If dtFormaPagoFechaV.Rows.Count() <> 0 Then
                fechaVencimiento = DateAdd(DateInterval.Day, CInt(dtFormaPagoFechaV.Rows(0).Item("Dias")), CDate(dtp_emision_ref.Value.ToString("dd/MM/yyyy")))
            Else
                fechaVencimiento = CDate(dtp_emision_ref.Value.ToString("dd/MM/yyyy"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return fechaVencimiento
    End Function


    Private Sub FrmManufactura_Formulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        Cargar_Moneda()
        GenerarColummnaDataTable()
        Ayuda_TipoDocumento()
    End Sub

    'Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    DocumentosOrdenCompra()
    'End Sub

    Private Sub Limpiar()
        cboTipoDoc_ref.SelectedIndex = 0
        dtpemision.MinDate = "01/01/1753"
        dtpemision.Value = Date.Now
        dtpemision.MaxDate = "31/12/9998"
        dtpemision.Enabled = True
        dtp_fec_detrac.Value = Date.Now
        dtp_vencimiento_ref.Value = Date.Now
        dtp_emision_ref.Value = Date.Now

        txtoperacion.Text = String.Empty
        txt_num_detrac.Text = String.Empty
        txtestado.Text = String.Empty
        txtproveedor.Text = String.Empty
        txtproveedor_razons.Text = String.Empty
        txtproveedor_ruc.Text = String.Empty
        txttipodoc.Text = String.Empty
        cbomoneda.SelectedIndex = 0
        txttipoCambio.Text = "0.000" 'LibComunVar.ClsVarComun.TCVenta
        txtFormaPago.Text = String.Empty
        txtserie_ref.Text = String.Empty
        txtentrega.Text = ""
        txtnombreFacturar.Text = ""
        txtdireccionFacturar.Text = ""
        txtrucfacturar.Text = ""
        txtComentario.Text = String.Empty
        txtBruto.Text = "0.00"
        txtDescuentos.Text = "0.00"
        txtIgv.Text = "0.00"
        txtvalorVenta.Text = "0.00"
        txtPrecioVenta.Text = "0.00"
        txtPorc_Detrac.Text = "0"
        dgvDetalle.DataSource = Nothing
        dtdetalleArticuloPrincipal.Rows.Clear()
        txtnumero_ref.Text = ""
        txtresponsable.Text = ""
        txtordencompra.Text = ""
        txt_num_caja_chica.Text = ""
        lbltipooperacion.Text = ""
        lblformapago.Text = ""
        lblresponsable.Text = ""
        txtproveedor.Enabled = True
        cbomoneda.Enabled = True
        txtFormaPago.Enabled = True
        txtresponsable.Enabled = True
        chkcomp_percepcion.Checked = False
        txttd_cp.Text = ""
        txtserie_cp.Text = ""
        txtnum_cp.Text = ""
        txtpor_cp.Text = "0"
        txtcentrocostocabecera.Text = ""
        lblcentrocostocabecera.Text = ""
        DTPEMISIONCP.Value = Date.Now
        DTPVCTOCP.Value = Date.Now
        Button2.Enabled = False
    End Sub

    Private Sub Nuevo()
        Try
            Limpiar()
            ConfigurarGrila()
            Modo_consultar = False
            CONTROLES(True, 0)
            Botonera_Estado_Cambiar(True)
            btn_add_prov.Visible = True
            pnlCabecera.Visible = False
            gbcabecera.Enabled = True
            gbcabecera.Enabled = True
            If Modo_consultar = False Then
                lblcompra.Visible = False
                txtcodigo.Visible = False
                txtproveedor.Enabled = True
                cbomoneda.Enabled = True
                gbOpciones.Enabled = True
            End If
            chk_importacion.Checked = False
            txtproveedor.Focus()
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            dtResultados = New DataTable
            Dim sql As String = String.Empty
            sql = "SELECT ADDR , REPORT_SCREEN , VAT_REGISTRATION   FROM COMPANY "
            dtResultados = CompraBl.Consultas_Generales(sql)
            If dtResultados.Rows().Count() <> 0 Then
                txtentrega.Text = dtResultados.Rows(0).Item("ADDR").ToString
                txtnombreFacturar.Text = dtResultados.Rows(0).Item("REPORT_SCREEN").ToString
                txtdireccionFacturar.Text = dtResultados.Rows(0).Item("ADDR").ToString
                txtrucfacturar.Text = dtResultados.Rows(0).Item("VAT_REGISTRATION").ToString
            Else
                txtentrega.Text = ""
                txtnombreFacturar.Text = ""
                txtdireccionFacturar.Text = ""
                txtrucfacturar.Text = ""
            End If
            GenerarColummnaDataTable_Documento_Referencia()
            txttipodoc.Select()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.PURCHASE_FACT_SUPPLIER
            CORRELATIVOBL.Get_NumeroCorrelativoCompra(dtpemision.Value.Year & Format(dtpemision.Value.Month, "00"))
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = dtpemision.Value.Year & Format(dtpemision.Value.Month, "00") & String.Format("{0:0000000}", 1)
            Else
                Correlativo = dtpemision.Value.Year & Format(dtpemision.Value.Month, "00") & String.Format("{0:0000000}", CInt(CORRELATIVOBL.NumeroCorrelativo))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Function Numeracion_Orden_Pago() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.PURCHASE_FACT_SUPPLIER
            CORRELATIVOBL.Get_NumeroCorrelativoOrdenPago(dtpemision.Value.Year)
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo_OrdenPago.ToString) Then
                Correlativo = dtpemision.Value.Year & Format(dtpemision.Value.Month, "00") & String.Format("{0:0000000}", 1)
            Else
                Correlativo = dtpemision.Value.Year & Format(dtpemision.Value.Month, "00") & String.Format("{0:0000000}", CInt(CORRELATIVOBL.NumeroCorrelativo_OrdenPago))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function




    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim Sql As String
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Call Botonera_Estado_Cambiar(True)
        CONTROLES(True, 0)
        pnlCabecera.Visible = False
        Dim _id As String = String.Empty
        Dim Store As String = String.Empty
        Dim msj As String = String.Empty

        _id = dgvCabecera.CurrentRow.Cells("ID").Value
        If Modo_consultar = True Then
            txtcodigo.Visible = True
            lblcompra.Visible = True
            'txtcodigo.Enabled = False
            'txtproveedor.Enabled = False
            'cbomoneda.Enabled = False
        End If
        Try
            ''cabecera
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtCabeceraoC As New DataTable
            dtCabeceraoC = CompraBl.Modo_Edicion_Cabecera(_id)
            If dtCabeceraoC.Rows.Count() <> 0 Then
                gbcabecera.Enabled = True
                txtcodigo.Text = dtCabeceraoC.Rows(0).Item(0).ToString
                txt_num_orden_pago.Text = dtCabeceraoC.Rows(0).Item("NUM_ORDER_PAGO").ToString
                dtpemision.Value = dtCabeceraoC.Rows(0).Item("DOCUMENT_DATE").ToString
                dtpemision.Enabled = True
                dtpemision.MinDate = ModFunciones.Primer_Dia_Mes(dtpemision.Value)
                dtpemision.MaxDate = ModFunciones.Ultimo_Dia_Mes(dtpemision.Value)

                dtp_fec_detrac.Value = dtCabeceraoC.Rows(0).Item("DETRAC_DATE").ToString
                txtestado.Text = dtCabeceraoC.Rows(0).Item("STATUS_ID").ToString
                txt_num_detrac.Text = dtCabeceraoC.Rows(0).Item("DETRAC_NUMBER").ToString
                If txtestado.Text = "02" Then
                    gbOpciones.Enabled = False
                    btnGrabar.Enabled = False
                Else
                    Store = "COMPRAS_SP_S_R_VERIFICAR_CANCEL"
                    If CompraBl.VerificarDocumentos(Store, dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_TYPE").Value, dgvCabecera.CurrentRow.Cells("SERIE").Value & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_NUMBER").Value, dgvCabecera.CurrentRow.Cells("VENDOR_ID").Value) = False Then
                        gbOpciones.Enabled = False
                        btnGrabar.Enabled = False
                    Else
                        'Verificando si posee Letra
                        Store = String.Empty
                        Store = "COMPRAS_SP_S_R_VERIFICAR_LETRA"
                        If CompraBl.VerificarDocumentos(Store, dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_TYPE").Value, dgvCabecera.CurrentRow.Cells("SERIE").Value & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_NUMBER").Value, dgvCabecera.CurrentRow.Cells("VENDOR_ID").Value) = False Then
                            gbOpciones.Enabled = False
                            btnGrabar.Enabled = False
                        Else
                            Store = String.Empty
                            Store = "COMPRAS_SP_S_R_VERIFICAR_CONTABILIZACION"
                            If CompraBl.VerificarDocumentos(Store, dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_TYPE").Value, dgvCabecera.CurrentRow.Cells("SERIE").Value & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_NUMBER").Value, dgvCabecera.CurrentRow.Cells("ID").Value) = False Then
                                gbOpciones.Enabled = False
                                btnGrabar.Enabled = False
                            Else
                                gbOpciones.Enabled = True
                                btnGrabar.Enabled = True
                            End If
                        End If
                    End If
                End If

                'btnGrabar.Enabled = Valida_Modificacion_Compras(txttipodoc.Text, txtserie_ref.Text, txtnumero_ref.Text, txtproveedor.Text)


                txtproveedor.Text = dtCabeceraoC.Rows(0).Item("VENDOR_ID").ToString
                txtproveedor_razons.Text = dtCabeceraoC.Rows(0).Item("NAME").ToString
                txtproveedor_ruc.Text = dtCabeceraoC.Rows(0).Item("VAT_REGISTRATION").ToString
                dtp_emision_ref.Value = dtCabeceraoC.Rows(0).Item("REFER_DOCUMENT_DATE").ToString
                dtp_vencimiento_ref.Value = dtCabeceraoC.Rows(0).Item("EXPIRATION_DATE").ToString
                cbomoneda.SelectedValue = dtCabeceraoC.Rows(0).Item("CURRENCY_TYPE").ToString
                txttipoCambio.Text = dtCabeceraoC.Rows(0).Item("SELL_RATE").ToString
                txtFormaPago.Text = dtCabeceraoC.Rows(0).Item("TERMS_NAME").ToString
                lblformapago.Text = dtCabeceraoC.Rows(0).Item("FORMA_PAGO").ToString
                txtentrega.Text = dtCabeceraoC.Rows(0).Item("ADDR_FACT").ToString
                txtnombreFacturar.Text = dtCabeceraoC.Rows(0).Item("NAME_FACT").ToString
                txtdireccionFacturar.Text = dtCabeceraoC.Rows(0).Item("ADDR_FACT").ToString
                txtrucfacturar.Text = dtCabeceraoC.Rows(0).Item("VAT_REGISTRATION_FACT").ToString
                txtComentario.Text = dtCabeceraoC.Rows(0).Item("COMMENT").ToString
                txtresponsable.Text = dtCabeceraoC.Rows(0).Item("BUYER_PURCHASE_ID").ToString
                lblresponsable.Text = dtCabeceraoC.Rows(0).Item("RESPONSABLE").ToString
                txtoperacion.Text = dtCabeceraoC.Rows(0).Item("TYPE_DESTINE").ToString
                lbltipooperacion.Text = dtCabeceraoC.Rows(0).Item("DESTINOS").ToString
                txtserie_ref.Text = dtCabeceraoC.Rows(0).Item("SERIE").ToString
                txttipodoc.Text = dtCabeceraoC.Rows(0).Item("REFER_DOCUMENT_TYPE").ToString
                txtnumero_ref.Text = dtCabeceraoC.Rows(0).Item("REFER_DOCUMENT_NUMBER").ToString
                txtordencompra.Text = dtCabeceraoC.Rows(0).Item("ORDER_BUY_ID").ToString
                txtPorc_Detrac.Text = dtCabeceraoC.Rows(0).Item("PERCENT_DETRAC").ToString

                id_caja_chica = dtCabeceraoC.Rows(0).Item("ID_CAJA_CHICA").ToString
                item_caja_chica = dtCabeceraoC.Rows(0).Item("ITEM_CAJA_CHICA").ToString
                item = dtCabeceraoC.Rows(0).Item("ITEM").ToString
                txt_num_caja_chica.Text = id_caja_chica & "-" & item_caja_chica & "-" & item

                If txttipodoc.Text = "NC" Or txttipodoc.Text = "ND" Or txttipodoc.Text = "NCE" Then
                    Button2.Enabled = True
                Else
                    Button2.Enabled = False
                End If

                chkcomp_percepcion.Checked = IIf(IIf(IsDBNull(dtCabeceraoC.Rows(0).Item("COM_PER_ID").ToString), "0", dtCabeceraoC.Rows(0).Item("COM_PER_ID").ToString) = "0", False, True)
                txttd_cp.Text = dtCabeceraoC.Rows(0).Item("COM_PER_TD").ToString
                txtserie_cp.Text = dtCabeceraoC.Rows(0).Item("COM_PER_SERIE").ToString
                txtnum_cp.Text = dtCabeceraoC.Rows(0).Item("COM_PER_NUMERO").ToString
                txtpor_cp.Text = dtCabeceraoC.Rows(0).Item("COM_PER_PERCENT").ToString
                DTPEMISIONCP.Value = IIf(dtCabeceraoC.Rows(0).Item("COM_PER_DATE_EMISION").ToString = "", Date.Now, dtCabeceraoC.Rows(0).Item("COM_PER_DATE_EMISION").ToString)
                DTPVCTOCP.Value = IIf(dtCabeceraoC.Rows(0).Item("COM_PER_DATE_VCTO").ToString = "", Date.Now, dtCabeceraoC.Rows(0).Item("COM_PER_DATE_VCTO").ToString)


                txttdanticipo.Text = dtCabeceraoC.Rows(0).Item("TD_AN").ToString
                If txttdanticipo.Text = "ANP" Then chkanticipo.Checked = True Else chkanticipo.Checked = False
                txttdanticipo.Text = dtCabeceraoC.Rows(0).Item("TD_AN").ToString
                txtserieanticipo.Text = dtCabeceraoC.Rows(0).Item("SERIE_AN").ToString
                txtnumeroanticipo.Text = dtCabeceraoC.Rows(0).Item("NUMERO_AN").ToString
                dtpfechaanticipo.Value = IIf(dtCabeceraoC.Rows(0).Item("FECHA_AN").ToString = "", Date.Now, CDate(dtCabeceraoC.Rows(0).Item("FECHA_AN").ToString))
                txtmontoanticipo.Text = CDbl(dtCabeceraoC.Rows(0).Item("MONTO_AN").ToString)

                txtcentrocostocabecera.Text = dtCabeceraoC.Rows(0).Item("CENTRO_COSTO").ToString
                Sql = "SELECT DESCRIPTION  FROM DBO.CENTRO_COSTOS  WHERE ID='" & txtcentrocostocabecera.Text & "'"
                lblcentrocostocabecera.Text = get_MostrarDescripcion(Sql)
                ''Detalle
                CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
                'GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = CompraBl.Modo_Edicion_Detalle(_id)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    ConfigurarGrila()
                    CalcularTotales()
                End If
                GenerarColummnaDataTable_Documento_Referencia()
                Dt_principal_lista_Doc_Ref = CompraBl.Modo_Edicion_Detalle_Doc_Ref_Compras(txttipodoc.Text, txtserie_ref.Text, txtnumero_ref.Text, txtproveedor.Text)

                If dtCabeceraoC.Rows(0).Item("IS_IMPORTATION").ToString = "1" Then
                    chk_importacion.Checked = True
                    chk_importacion.Visible = True
                    Dim DT_IMPORTACION As DataTable
                    DT_IMPORTACION = CompraBl.Get_Datos_Importacion(txtcodigo.Text, "FP")
                    If DT_IMPORTACION.Rows.Count() <> 0 Then
                        txt_tipo_doc_dua.Text = DT_IMPORTACION.Rows(0).Item("TIPO_DOCUMENTO").ToString
                        txt_ano_dua.Text = DT_IMPORTACION.Rows(0).Item("ANIO").ToString
                        txt_cod_aduanas.Text = DT_IMPORTACION.Rows(0).Item("SERIE").ToString
                        txt_numero_dua.Text = DT_IMPORTACION.Rows(0).Item("NUMERO_DOCUMENTO").ToString
                    Else
                        txt_tipo_doc_dua.Text = ""
                        txt_ano_dua.Text = ""
                        txt_cod_aduanas.Text = ""
                        txt_numero_dua.Text = ""
                    End If
                Else
                    chk_importacion.Checked = False
                    chk_importacion.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function get_MostrarDescripcion(ByVal cadena As String) As String
        Try
            dtTable = New DataTable
            LibData = New LibConexion.ClsData
            Dim description As String = String.Empty
            dtTable = LibData.Run_Query_DataTable(cadena)
            LibData.Dispose()
            description = dtTable.Rows(0).Item(0).ToString()
            Return description
        Catch ex As Exception
        End Try
    End Function

    Private Function Guardar_Compra() As Boolean
        Try
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            CompraCabENT = New ClsEntidades.PURCHASE_FACT_SUPPLIER
            ListaDetalles = New List(Of ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE)
            CompraImportacion = New ClsEntidades.REFERENCES_DOCUMENT_IMPORTACION_COMPRAS

            If Modo_consultar = True Then
                CompraCabENT.ID = txtcodigo.Text
            Else
                Dim _CORRELATIVO As String = Numeracion()
                CompraCabENT.ID = _CORRELATIVO
            End If

            If Modo_consultar = True Then
                CompraCabENT.NUM_ORDER_PAGO = txt_num_orden_pago.Text
            Else
                'Dim _CORRELATIVO_ORDEN_PAGO As String = Numeracion_Orden_Pago()
                CompraCabENT.NUM_ORDER_PAGO = "" '_CORRELATIVO_ORDEN_PAGO
            End If

            With CompraCabENT
                .TYPE = "FP"
                .DOCUMENT_DATE = dtpemision.Value.ToString("dd/MM/yyyy")
                .DETRAC_DATE = dtp_fec_detrac.Value.ToString("dd/MM/yyyy")
                .VENDOR_ID = txtproveedor.Text
                .DETRAC_NUMBER = txt_num_detrac.Text
                .NUMBER_ESTIMATING = ""
                .CURRENCY_TYPE = cbomoneda.SelectedValue.ToString
                .TERMS_NAME = txtFormaPago.Text
                .SELL_RATE = IIf(txttipoCambio.Text = "", 0, txttipoCambio.Text)
                .PROMISE_DATE = Get_FormaPagoFechaVencimiento()
                .COMMENT = txtComentario.Text
                .AUTORIZED_ID = ""
                .BUYER_PURCHASE_ID = txtresponsable.Text
                .TIME_DLV = ""
                .ADDR_DLV = txtentrega.Text
                .STATUS_ID = "01"
                .AMOUNT = txtBruto.Text
                .DISCOUNT = txtDescuentos.Text
                .AMOUNT_TAX = txtIgv.Text
                .AMOUNT_SALES = txtPrecioVenta.Text
                .UPDATE_DATE = Date.Now
                .UPDATE_HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .CURR_EXCHANGE_TYPE = "VTA"
                .NAME_FACT = txtnombreFacturar.Text
                .VAT_REGISTRATION_FACT = txtrucfacturar.Text
                .ADDR_FACT = txtentrega.Text
                .REFER_DOCUMENT_TYPE = txttipodoc.Text 'cboTipoDoc_ref.Text
                .REFER_DOCUMENT_NUMBER = txtnumero_ref.Text
                .SERIE = txtserie_ref.Text
                .EXPIRATION_DATE = dtp_vencimiento_ref.Value
                .BUDGET_ID = ""
                .ORDER_BUY_ID = txtordencompra.Text
                .NOTE_IN_ID = ""
                .WAREHOUSE_ID = ""
                .TYPE_DESTINE = txtoperacion.Text
                .REFER_DOCUMENT_DATE = dtp_emision_ref.Value
                .CREATE_DATE = Date.Now
                .PERCENT_DETRAC = Val(txtPorc_Detrac.Text)
                .COM_PER_ID = IIf(chkcomp_percepcion.Checked, "1", "0")
                .COM_PER_TD = txttd_cp.Text
                .COM_PER_SERIE = txtserie_cp.Text
                .COM_PER_NUMERO = txtnum_cp.Text
                .COM_PER_PERCENT = Val(IIf(txtpor_cp.Text = "", 0, txtpor_cp.Text))
                .COM_PER_DATE_EMISION = DTPEMISIONCP.Value.ToString("dd/MM/yyyy")
                .COM_PER_DATE_VCTO = DTPVCTOCP.Value.ToString("dd/MM/yyyy")
                .TD_AN = txttdanticipo.Text
                .SERIE_AN = txtserieanticipo.Text
                .NUMERO_AN = txtnumeroanticipo.Text
                .FECHA_AN = dtpfechaanticipo.Value.ToString("dd/MM/yyyy")
                .MONTO_AN = CDbl(IIf(txtmontoanticipo.Text = "", 0, txtmontoanticipo.Text))
                .CENTRO_DE_COSTOS = txtcentrocostocabecera.Text
                If txtoperacion.Text = "03" Or txtoperacion.Text = "02" Then
                    .AMOUNT_INAFECTO = IIf(IsDBNull(dtdetalleArticuloPrincipal.Compute("sum (AMOUNT_TOTAL_NET) ", "AMOUNT_TAX=0")), 0, dtdetalleArticuloPrincipal.Compute("sum (AMOUNT_TOTAL_NET) ", "AMOUNT_TAX=0"))
                Else
                    .AMOUNT_INAFECTO = 0
                End If
                .AMOUNT = .AMOUNT - .AMOUNT_INAFECTO
                .IS_IMPORTATION = IIf(chk_importacion.Checked, "1", "")

                .ID_CAJA_CHICA = id_caja_chica
                .ITEM_CAJA_CHICA = item_caja_chica
                .ITEM = item
            End With
            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                CompraDetENT = New ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE
                With CompraDetENT
                    .ID = CompraCabENT.ID
                    .TYPE = "FP"
                    .ITEM = item("ITEM")
                    .PART_ID = item("PART_ID")
                    .PART_DESCRIPTION = item("DESCRIPTION")
                    .UNIT = item("UNIT")
                    .UNIT_REFERENCE = item("UNIT_REFERENCE")
                    .FACTOR_REFERENCE = IIf(String.IsNullOrEmpty(item("FACTOR_REFERENCE")), 0.0, item("FACTOR_REFERENCE"))
                    .QTY = item("QTY")
                    .PRICE = item("PRICE")
                    .DISCOUNT_PER = item("DISCOUNT_PER")
                    .DISCOUNT = item("DISCOUNT")
                    .AMOUNT_TAX = item("AMOUNT_TAX")
                    .PERCENT_TAX = item("PERCENT_TAX")
                    .PRICE_NET = item("PRICE_NET")
                    .AMOUNT_TOTAL = item("AMOUNT_TOTAL")
                    .AMOUNT_TOTAL_NET = item("AMOUNT_TOTAL_NET")
                    .QTY_ENTER = 0
                    .QTY_OUT = .QTY
                    .STATUS_ID = "01"
                    .COMMENT1 = item("COMMENT1")
                    .TEXT_COMMENT = item("TEXT_COMMENT")
                    .IS_VAT = item("IS_VAT")
                    .PRICE_UNIT = item("PRICE_UNIT")
                    .CCOST_ID = item("CCOST_ID")
                    .PROJECT_ID = ""
                    .FLAG_FREE_IGV = IIf(String.IsNullOrEmpty(item("FLAG_FREE_IGV").ToString), 0, CInt(item("FLAG_FREE_IGV")))
                    .CENCOS = item("CENCOS")
                End With
                ListaDetalles.Add(CompraDetENT)
            Next

            With CompraImportacion
                .ID = CompraCabENT.ID
                .TYPE = CompraCabENT.TYPE
                .TIPO_DOCUMENTO = txt_tipo_doc_dua.Text.Trim
                .SERIE = txt_cod_aduanas.Text.Trim
                .ANIO = txt_ano_dua.Text.Trim
                .NUMERO_DOCUMENTO = txt_numero_dua.Text.Trim
            End With

            If CompraBl.GuardarCompra(CompraCabENT, ListaDetalles, _TipoAnexoDoc, IIf(Modo_consultar = False, True, False), Dt_principal_lista_Doc_Ref, CompraImportacion) Then
                If Modo_consultar = True Then
                    MsgBox("Documento Modificado Correctamente," & vbCrLf & "Nro Documento: " & CompraCabENT.ID, MsgBoxStyle.Information)
                Else
                    MsgBox("Nuevo documento Generado Correctamente," & vbCrLf & "Nro Documento: " & CompraCabENT.ID, MsgBoxStyle.Information)
                End If
                'verificamos si se configuro la opcion de guardar en la cartera de proveedores
                Dim carteraBE As LibContabilidad.ClsEntidades.CUSTOMER_BALANCE_PAY
                Dim CarteraBl As LibContabilidad.ClsOperaciones.Asiento_Contable
                Dim dtFinalizarCompra As DataTable
                dtFinalizarCompra = New DataTable
                CarteraBl = New LibContabilidad.ClsOperaciones.Asiento_Contable
                dtFinalizarCompra = CarteraBl.Get_Habilitado_CBP("FP")
                If dtFinalizarCompra.Rows.Count() <> 0 Then
                    Try
                        CarteraBl = New LibContabilidad.ClsOperaciones.Asiento_Contable
                        dtFinalizarCompra = New DataTable

                        Dim ListaDetalles As New List(Of LibContabilidad.ClsEntidades.CUSTOMER_BALANCE_PAY)
                        dtFinalizarCompra = CarteraBl.Get_Registro_Compras(CompraCabENT.ID)
                        If dtFinalizarCompra.Rows.Count() <> 0 Then
                            For Each item As DataRow In dtFinalizarCompra.Rows
                                carteraBE = New LibContabilidad.ClsEntidades.CUSTOMER_BALANCE_PAY
                                With carteraBE
                                    CarteraBl = New LibContabilidad.ClsOperaciones.Asiento_Contable

                                    .CUSTOMER_ID = item("VENDOR_ID")
                                    .DOCUMENT_ID = item("REFER_DOCUMENT_TYPE")
                                    .NUMBER_DOC = item("SERIE") + item("REFER_DOCUMENT_NUMBER")
                                    .DOC_DATE = CDate(item("REFER_DOCUMENT_DATE").ToString).ToString("dd/MM/yyyy")
                                    .CADUCATE_DATE = CDate(item("EXPIRATION_DATE").ToString).ToString("dd/MM/yyyy")
                                    .DOCUMENT_REF = item("TYPE").ToString
                                    .NUMBER_REF = item("ID").ToString
                                    .SALES_ID = "0000"
                                    .AMOUNT = item("AMOUNT_SALES")
                                    .AMOUNT_BALANCE = .AMOUNT
                                    .CURRENCY_ID = item("CURRENCY_TYPE")
                                    .SELL_RATE = item("SELL_RATE")
                                    .IS_DR_CR = "0"
                                    .STATUS = "V"
                                    .CREATE_DATE = Date.Now.ToShortDateString
                                    .LAST_MODIFIED = Date.Now.ToShortDateString
                                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                                    .ACCOUNT = ""
                                    .AMOUNT_COMM = 0
                                    .TYPE_REC = ""
                                    .REFERENCE_DATE = Date.Now.ToShortDateString
                                    .IS_CHECK_DIF = ""
                                    .AMOUNT_BALANCE_INI = .AMOUNT
                                    .TERMS = item("TERMS_NAME")
                                    .PLACE_SALES = ""
                                    .BANK_ID = ""
                                    .BANK_DESCRIPTION = ""
                                    .AMOUNT_PER = 0
                                    .PERCENT_PER = 0
                                    .ACCOUNT_PER = ""
                                    .CUST_AUTO = 0
                                    .SERIE_AUX = item("SERIE")
                                    .NUM_DOC_AUX = item("REFER_DOCUMENT_NUMBER")
                                    .PERCENT_DETRAC = 0 'item("PERCENT_DETRAC")
                                    .AMOUNT_DETRAC = 0 'item("AMOUNT_DETRAC")
                                    .SALDO = .AMOUNT
                                    .NUM_REF_ASIENTO = 0
                                    .VOUCHER_REF_ASIENTO = ""
                                    .FECHA_REF_ASIENTO = Date.Now.ToShortDateString
                                End With
                                ListaDetalles.Add(carteraBE)
                            Next
                        End If
                        CarteraBl = New LibContabilidad.ClsOperaciones.Asiento_Contable
                        If CarteraBl.Guardar_Finalizar_Compras(ListaDetalles) Then
                            MsgBox("Datos guardados en la Cartera de Proveedores.", MsgBoxStyle.Information)
                        Else
                            MsgBox("No se registro el documento en la Cartera de Proveedores. Verifique!", MsgBoxStyle.Critical)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                'fin
                'If MessageBox.Show("Se procedera a la Impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                '    imprimir_Compra(CompraCabENT.ID, CompraCabENT.AMOUNT_SALES, IIf(CompraCabENT.CURRENCY_TYPE = "MN", "MN", "ME"))
                'End If
                Return True
            Else
                MsgBox("No se registro el documento en las Compras. Verifique!", MsgBoxStyle.Critical)
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalle.Rows.Count() = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        If Modo_consultar = True Then
            If txtestado.Text = "05" Or txtestado.Text = "02" Then MsgBox("No se puede guardar los cambios en el documento elegido.", MsgBoxStyle.Critical, "Aviso") : Exit Sub
        End If
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            If ValidacionesGenerales() = False Then Exit Sub
            For Each row As DataRow In dtdetalleArticuloPrincipal.Select("QTY=0 OR PRICE=0", "")
                MessageBox.Show("Falta ingresar el precio y/o cantidad a los Articulos.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Next

            If txtoperacion.Text = "01" Then
                If txtIgv.Text = "" Then
                    MsgBox("El documento no posee IGV. Verifique!!!", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If CDbl(txtIgv.Text) = 0 Then
                        MsgBox("El documento no posee IGV. Verifique!!!", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

            If txtoperacion.Text = "02" Then
                If txtIgv.Text = "" Then
                    MsgBox("El documento no posee IGV. Verifique!!!", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If CDbl(txtIgv.Text) <> 0 Then
                        MsgBox("El documento posee IGV. Verifique!!!", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

        End If
        If MessageBox.Show("Se va a registrar la  compra" & vbCrLf & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Guardar_Compra() Then
                Dim dtValidacion As DataTable, _GENERA_ESTADO_CUENTA As String
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtValidacion = New DataTable("Validacion")
                dtValidacion = clsFacturaBl.Get_Validacion("FP", "000")
                If dtValidacion.Rows.Count > 0 Then
                    _GENERA_ESTADO_CUENTA = dtValidacion.Rows(0).Item("IS_GENERA_CANJE_LETRA").ToString
                    If _GENERA_ESTADO_CUENTA = "S" Then
                        Dim frmPagosLetras As New FrmLetras_Pagos
                        'frmPagosLetras.MdiParent = Me
                        OpenSubForm(frmPagosLetras)
                    End If
                End If
                DocumentosCompra()
                btnCancelar_Click(sender, e)
            End If
        End If


    End Sub
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

    Private Function Ayuda_CambioEstado(ByVal _Estado As String) As String
        Dim Estado As String = ""
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRA_SP_S_ESTADO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = _Estado
            frm.Titulo = "Listado de Estados de la orden de Compra"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                Estado = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim estadoInicial As String = ""
            Dim estadoActualizado As String = ""
            Dim estadoContabilizado As String = ""
            Dim _id As String = String.Empty
            Dim Store As String = ""
            Dim msj As String = String.Empty

            _id = dgvCabecera.CurrentRow.Cells("ID").Value
            estadoInicial = dgvCabecera.CurrentRow.Cells("ESTADO").Value '12
            estadoContabilizado = dgvCabecera.CurrentRow.Cells("ESTADO_CONTABLE").Value '23
            If estadoInicial = "ANULADO" Then
                MsgBox("El documento ya se encuentra anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If estadoContabilizado = "CONTABILIZADO" Then
                MsgBox("El documento se encuentra en Contabilidad," & Chr(13) & "no procede la anulación.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Store = "COMPRAS_SP_S_R_VERIFICAR_CANCEL"
            If CompraBl.VerificarDocumentos(Store, dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_TYPE").Value, dgvCabecera.CurrentRow.Cells("SERIE").Value & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_NUMBER").Value, dgvCabecera.CurrentRow.Cells("VENDOR_ID").Value) = False Then
                msj = "      EL Documento:   " & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_TYPE").Value & " -  " & dgvCabecera.CurrentRow.Cells("SERIE").Value & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_NUMBER").Value & vbCrLf & "posee una Cancelacion , no se puede ANULAR."
                MsgBox(msj, MsgBoxStyle.Critical)
                Exit Sub
            Else
                'Verificando si posee Letra
                Store = String.Empty
                Store = "COMPRAS_SP_S_R_VERIFICAR_LETRA"
                If CompraBl.VerificarDocumentos(Store, dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_TYPE").Value, dgvCabecera.CurrentRow.Cells("SERIE").Value & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_NUMBER").Value, dgvCabecera.CurrentRow.Cells("VENDOR_ID").Value) = False Then
                    msj = String.Empty
                    msj = "   EL Documento:   " & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_TYPE").Value & " -  " & dgvCabecera.CurrentRow.Cells("SERIE").Value & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_NUMBER").Value & vbCrLf & "posee un canje por Letra , no se puede ANULAR."
                    MsgBox(msj, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    Store = String.Empty
                    Store = "COMPRAS_SP_S_R_VERIFICAR_CONTABILIZACION"
                    If CompraBl.VerificarDocumentos(Store, dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_TYPE").Value, dgvCabecera.CurrentRow.Cells("SERIE").Value & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_NUMBER").Value, dgvCabecera.CurrentRow.Cells("ID").Value) = False Then
                        msj = String.Empty
                        msj = "      EL Documento:   " & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_TYPE").Value & " -  " & dgvCabecera.CurrentRow.Cells("SERIE").Value & dgvCabecera.CurrentRow.Cells("REFER_DOCUMENT_NUMBER").Value & vbCrLf & " esta contabilizado, no se puede ANULAR."
                        MsgBox(msj, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

            If estadoInicial = "EMITIDO" Then
                If MessageBox.Show("Se va a anular la  compra" & vbCrLf & "¿Desea continuar?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If CompraBl.Anular_Oden_Compra(_id) Then
                        MsgBox("Documento anulado Correctamente.", MsgBoxStyle.Information)
                        DocumentosCompra()
                    End If
                End If
                'btnCancelar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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

    Private Sub imprimir_Compra(ByVal _Codigo As String, ByVal _Monto As Double, ByVal _Moneda As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Compra")
            Me.Cursor = Cursors.WaitCursor

            Dim STRmontotexto As String = String.Empty
            If _Moneda = "MN" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Soles"
            ElseIf _Moneda = "ME" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Dólares Americanos"
            ElseIf _Moneda = "EE" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Euros"
            Else
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   "
            End If
            dtImprimir = reporteBL.EjecutarReporteCompra(_Codigo)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Facturar_Compra.rpt", "", "", "", "@NUMERO;" & _Codigo, "@LETRA;" & STRmontotexto)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim _Id As String = String.Empty
        Dim _Monto As Double = 0.0
        Dim _Moneda As String = String.Empty
        _Id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Monto = IIf(String.IsNullOrEmpty(dgvCabecera.Item(22, dgvCabecera.CurrentRow.Index).Value.ToString), 0, dgvCabecera.Item(22, dgvCabecera.CurrentRow.Index).Value)
        _Moneda = dgvCabecera.Item(5, dgvCabecera.CurrentRow.Index).Value
        imprimir_Compra(_Id, _Monto, _Moneda)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        dtpemision.MinDate = "01/01/1753"
        dtpemision.MaxDate = "31/12/9998"
        Limpiar()
        btn_add_prov.Visible = False
        'gbcabecera.Enabled = True
        'DocumentosCompra()
    End Sub



    Private Sub txtComentario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComentario.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtComentario.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub



    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If txttipodoc.Text = String.Empty Then
                MsgBox("Debe elegir un Tipo de Documento.", MsgBoxStyle.Exclamation)
                estado = False
                txttipodoc.Focus()
                Exit Try
            ElseIf txtserie_ref.Text = String.Empty Then
                MsgBox("Debe ingresar un numero de serie.", MsgBoxStyle.Exclamation)
                estado = False
                txtserie_ref.Focus()
                Exit Try
            ElseIf txtnumero_ref.Text = String.Empty Then
                MsgBox("Debe ingresar un numero de referencia.", MsgBoxStyle.Exclamation)
                estado = False
                txtnumero_ref.Focus()
                Exit Try
            ElseIf txtproveedor.Text = String.Empty Then
                MsgBox("Debe ingresar un numero de referencia.", MsgBoxStyle.Exclamation)
                estado = False
                txtproveedor.Focus()
                Exit Try
            ElseIf txtFormaPago.Text = String.Empty Then
                MsgBox("Debe seleccionar una forma de Pago.", MsgBoxStyle.Exclamation)
                estado = False
                txtFormaPago.Focus()
                Exit Try
            ElseIf txtoperacion.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo de operación.", MsgBoxStyle.Exclamation)
                estado = False
                txtoperacion.Focus()
                Exit Try
            ElseIf txtresponsable.Text = String.Empty Then
                MsgBox("Debe seleccionar un Responsable.", MsgBoxStyle.Exclamation)
                estado = False
                txtresponsable.Focus()
                Exit Try
            End If
            If cbomoneda.Text = String.Empty Then
                MsgBox("No se cargo datos del Tipo de Moneda.", MsgBoxStyle.Critical)
                estado = False
                cbomoneda.Focus()
                Exit Try
            End If
            If txttipoCambio.Text = String.Empty Or Val(txttipoCambio.Text) = 0 Then
                MsgBox("Debe registrar un tipo de cambio para la fecha elegida.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
            Dim fecha_emi_ref As Date, fecha_vcto_ref As Date, fecha_ple As Date
            fecha_emi_ref = CDate(dtp_emision_ref.Value.ToString("dd/MM/yyyy"))
            fecha_vcto_ref = CDate(dtp_vencimiento_ref.Value.ToString("dd/MM/yyyy"))
            fecha_ple = CDate(dtpemision.Value.ToString("dd/MM/yyyy"))
            If fecha_emi_ref > fecha_vcto_ref Then
                MsgBox("La fecha de emisión no puede ser menor que la fecha de vencimiento .", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
            If fecha_emi_ref > fecha_ple Then
                MsgBox("La fecha de emisión no puede ser menor que la fecha PLE .", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If

            If Modo_consultar = False Then
                If Valida_Ingreso_Compras(txttipodoc.Text.Trim, txtserie_ref.Text.Trim, txtnumero_ref.Text.Trim, txtproveedor.Text.Trim) = False Then
                    MsgBox("El documento a ingresar ya se encuentra registrado, verifique.", MsgBoxStyle.Critical)
                    estado = False
                    Exit Try
                End If
            End If

            If txttipodoc.Text.Trim = "NC" Or txttipodoc.Text.Trim = "ND" Or txttipodoc.Text.Trim = "NCE" Then
                If Dt_principal_lista_Doc_Ref.Rows.Count = 0 Then
                    MsgBox("Debe ingresar la referencia del documento, verifique.", MsgBoxStyle.Critical)
                    estado = False
                    Exit Try
                End If
            End If

            If txttipodoc.Text.Trim = "FI" Then
                If chk_importacion.Checked = False Or txt_tipo_doc_dua.Text = "" Or txt_ano_dua.Text = "" Or txt_cod_aduanas.Text = "" Or txt_numero_dua.Text = "" Then
                    MsgBox("Debe ingresar los datos de la Importación, verifique.", MsgBoxStyle.Critical)
                    estado = False
                    Exit Try
                End If
            End If

            If Verificar_Apertura_Cierre_Modulos(dtpemision.Value.Month, dtpemision.Value.Year) = False Then
                estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function Verificar_Apertura_Cierre_Modulos(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New LibCobranzas.ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.Validar_Cierre_Apertura_Modulos(Mes_Ant, Anio_Ant, "PROVEEDORES")
            If dtCierre.Rows.Count() > 0 Then
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar la Compra.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function


    Public Sub blank()
        txtcodigoArticulo.Text = ""
        txtdescripcionArticulo.Text = ""
        txtunidadMedida.Text = ""
        txtunidadMedRef.Text = ""
        txtcantidad.Text = ""
        txtcantidadref.Text = ""
        txtGlosa.Text = ""
        txtporc_descuento.Text = "0"
        txtValorunitario.Text = "0"
        txtvalorventaref.Text = "0"
        txtvalorventaunit.Text = "0"
        txtpreciounitario.Text = "0"
        txtvalorbruto.Text = "0"
        txtdescuento.Text = "0"
        txtvalorvent.Text = "0"
        txt_igv.Text = "0"
        txttotalneto.Text = "0"
        txtobservaciones.Text = ""
        txtcentroCosto.Text = ""
        txtarea.Text = ""
        txtproyecto.Text = ""
        txtcentrocostodetalle.Text = ""
        lblcentrocostodetalle.Text = ""
        chk_libre.Checked = False
        chkigv.Checked = False

        txt_cen_cos.Text = ""
        lbl_cen_cos_desc.Text = ""
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If gbcabecera.Enabled = True Then
                If ValidacionesGenerales() = False Then Exit Sub
                gbcabecera.Enabled = False
            End If
            _Flag_edicion = False
            CONTROLES(True, 1)
            blank()
            btn_menu.Enabled = False
            'txttasa.Text = "0"
            txttasa.Text = TasaIgvEstandar()
            If txtoperacion.Text = "01" Then
                txttasa.Enabled = True
            ElseIf txtoperacion.Text = "02" Then
                txttasa.Enabled = True
            ElseIf txtoperacion.Text = "03" Then
                txttasa.Enabled = True
            End If
            txtcodigoArticulo.Enabled = True
            txtValorunitario.Enabled = True
            txtcodigoArticulo.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function TasaIgvEstandar() As Double
        Dim tasa As Double = 0.0
        Try
            Dim OrdenCompraBl As New ClsOperaciones.PURCHASE_ORDER
            Dim dtSistema As New DataTable("IGV_SISTEMA")
            dtSistema = OrdenCompraBl.Get_DatosIgvsSistema()
            tasa = CDbl(dtSistema.Rows(0).Item("AMOUNT_TAX"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tasa
    End Function


    Private Sub CalcularTotales()
        Try
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                txtDescuentos.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (DISCOUNT) ", ""), "0.00")
                txtvalorVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (PRICE_NET) ", ""), "0.00")
                txtIgv.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (AMOUNT_TAX) ", ""), "0.00")
                txtPrecioVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (AMOUNT_TOTAL_NET) ", ""), "0.00")
                txtBruto.Text = Format(Val(txtvalorVenta.Text) + Val(txtDescuentos.Text), "0.00")
            Else
                txtBruto.Text = "0.00"
                txtDescuentos.Text = "0.00"
                txtvalorVenta.Text = "0.00"
                txtIgv.Text = "0.00"
                txtPrecioVenta.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvDetalle.RowCount() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            If gbcabecera.Enabled = True Then
                If ValidacionesGenerales() = False Then Exit Sub
                gbcabecera.Enabled = False
            End If

            _Flag_edicion = True
            _Codigo_Ini = String.Empty
            _Codigo_Ini = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            CONTROLES(True, 1)
            blank()
            btn_menu.Enabled = False
            For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _Codigo_Ini)
                txtcodigoArticulo.Text = row("PART_ID")
                txtdescripcionArticulo.Text = row("DESCRIPTION")
                txtunidadMedida.Text = row("UNIT")
                txtunidadMedRef.Text = row("UNIT_REFERENCE")
                txtcantidad.Text = CDbl(row("QTY"))
                txtcantidadref.Text = IIf(row("FACTOR_REFERENCE").ToString = "", 0, row("FACTOR_REFERENCE"))
                txtValorunitario.Text = CDbl(row("PRICE"))
                txtporc_descuento.Text = row("DISCOUNT_PER")
                txtdescuento.Text = row("DISCOUNT")
                txt_igv.Text = row("AMOUNT_TAX")
                If txtoperacion.Text = "01" Then
                    'txttasa.Text = "18"
                    txttasa.Enabled = True
                ElseIf txtoperacion.Text = "02" Then
                    txttasa.Enabled = True
                ElseIf txtoperacion.Text = "03" Then
                    txttasa.Enabled = True
                End If
                txttasa.Text = row("PERCENT_TAX")
                txtvalorvent.Text = CDbl(row("PRICE_NET"))
                txtvalorventaunit.Text = row("AMOUNT_TOTAL")
                txttotalneto.Text = row("AMOUNT_TOTAL_NET")
                txtobservaciones.Text = row("COMMENT1")
                txtGlosa.Text = row("TEXT_COMMENT")
                If String.IsNullOrEmpty(row("IS_VAT").ToString) Then
                    chkigv.Checked = False
                Else
                    If row("IS_VAT") = "1" Then
                        chkigv.Checked = True
                    Else
                        chkigv.Checked = False
                    End If
                End If
                If String.IsNullOrEmpty(row("FLAG_FREE_IGV").ToString) Then
                    chk_libre.Checked = False
                Else
                    If row("FLAG_FREE_IGV") = "1" Then
                        chk_libre.Checked = True
                    Else
                        chk_libre.Checked = False
                    End If
                End If
                txtpreciounitario.Text = row("PRICE_UNIT")
                txtcentrocostodetalle.Text = row("CCOST_ID")
                Ayuda_Centro_Costo_Compras(txtcentrocostodetalle.Text)
                txtproyecto.Text = ""
                If txtcantidadref.Text <> 0 Then
                    txtvalorventaref.Text = txtdescuento.Text
                Else
                    txtvalorventaref.Text = 0
                End If
                txtvalorbruto.Text = Format(Val(txtdescuento.Text) + Val(txtvalorVenta.Text), "0.00")
                If String.IsNullOrEmpty(row("ORDEN_COMPRA").ToString) Then
                    txtcodigoArticulo.Enabled = True
                    txtValorunitario.Enabled = True
                    txtcodigoArticulo.Select()
                Else
                    txtcodigoArticulo.Enabled = True
                    txtValorunitario.Enabled = True
                    txtcantidad.Select()
                End If

                txt_cen_cos.Text = row("CENCOS")
                lbl_cen_cos_desc.Text = row("CENCOS_DES")
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

                If dtdetalleArticuloPrincipal.Rows.Count() = 0 Then
                    _TipoAnexoDoc = ""
                Else
                    'RehacerSecuencia()
                End If
                CalcularTotales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
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
        DocumentosCompra()
    End Sub

    Private Sub Ayuda_Clientes()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_PROVEEDORES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Proveedores"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtproveedor.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtproveedor_razons.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtproveedor_ruc.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                dtpemision.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtproveedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtproveedor.MouseDoubleClick
        Ayuda_Clientes()
    End Sub



    Private Sub Ayuda_FormaPago()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRA_SP_S_FORMA_PAGO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Lista de Forma de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblformapago.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtresponsable.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFormaPago_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFormaPago.MouseDoubleClick
        Ayuda_FormaPago()
    End Sub

    Private Sub Ayuda_Responsable()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_RESPONSABLE"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE RESPONSABLES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtresponsable.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblresponsable.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtPorc_Detrac.Select()
            Else
                txtPorc_Detrac.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Centro_Costo_Compras(Optional ByVal _codigo As String = "")
        Try
            If _codigo = "" Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "PUR_SP_S_CENTRO_COSTO_COMPRAS"
                frm.CadenaConsulta = sql
                frm.Titulo = "LISTA DE CENTROS DE COSTO COMPRAS"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtcentrocostodetalle.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    lblcentrocostodetalle.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txtcantidad.Select()
                Else
                    txtcentrocostodetalle.Select()
                End If
                frm.Close()
            Else
                Dim clsArticuloBl As New LibCobranzas.ClsOperaciones.PART
                Dim dtDocumentoGuias As New DataTable
                dtDocumentoGuias = clsArticuloBl.Verifica_Centro_Costo(_codigo)
                If dtDocumentoGuias.Rows.Count > 0 Then
                    lblcentrocostodetalle.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPTION").ToString
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtresponsable_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtresponsable.MouseDoubleClick
        Ayuda_Responsable()
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
                    STRorden = dgvCabecera.Columns(0).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(2).Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvCabecera.Columns(3).Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvCabecera.Columns(4).Name
                                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                                If dtv.Count() = 0 Then
                                    STRorden = String.Empty
                                    STRorden = dgvCabecera.Columns(18).Name
                                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                                    If dtv.Count() = 0 Then
                                        STRorden = String.Empty
                                        STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name & "+" & dgvCabecera.Columns(18).Name
                                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        End If

    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosCompra()
        End If
        If e.KeyCode = Keys.Tab Then
            dtpfechafinal.Focus()
        End If
    End Sub

    Private Sub Tc_principal_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Tc_principal.Selecting
        If Not Tc_principal.SelectedTab.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Ayuda_Unidad_Medida()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_UNIDAD_REF"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista Unidad de Medida de Referencia"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtunidadMedRef.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                txtunidadMedRef.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtunidadMedRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtunidadMedRef.MouseDoubleClick
        Ayuda_Unidad_Medida()
    End Sub

    Private Sub txtValorunitario_Leave(sender As Object, e As EventArgs) Handles txtValorunitario.Leave
        If txtValorunitario.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub

    'Private Sub Calcular_Importes_Detalle()
    '    Try
    '        Dim nValorVta As Double
    '        Dim nValorUniRef As Double
    '        Dim nValorUnit As Double
    '        Dim nPrecioUnit As Double
    '        Dim nDsctoUnit As Double
    '        Dim nValorBruto As Double
    '        Dim nTasaIGV As Double
    '        Dim nMontoIgv As Double
    '        Dim nMontodes As Double
    '        Dim nMontoTotal As Double
    '        nTasaIGV = (Val(txttasa.Text) / 100)
    '        If Val(txtValorunitario.Text) <> 0 Then  'Valor unitario
    '            'Aplicando descuento
    '            If chkigv.Checked = True Then
    '                nValorUnit = Math.Round(Val(txtValorunitario.Text) / (1 + nTasaIGV), 6)
    '            Else
    '                nValorUnit = Val(txtValorunitario.Text)
    '            End If
    '            If Val(txtcantidadref.Text) <> 0 And Val(txtcantidad.Text) <> 0 Then
    '                nValorUniRef = Math.Round((Val(txtcantidadref.Text) / Val(txtcantidad.Text)) * nValorUnit, 6)
    '                nDsctoUnit = nValorUniRef * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
    '                nValorUniRef = nValorUniRef - nDsctoUnit
    '                nValorUnit = nValorUniRef
    '            Else
    '                nValorUniRef = 0
    '                nDsctoUnit = nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
    '                nValorUnit = nValorUnit - nDsctoUnit
    '            End If
    '            'Precio Unitario
    '            nPrecioUnit = nValorUnit * (1 + nTasaIGV)
    '            nValorVta = nValorUnit * Val(txtcantidad.Text)
    '            nMontodes = nDsctoUnit * Val(txtcantidad.Text)
    '            nMontoIgv = (nValorUnit * nTasaIGV) * Val(txtcantidad.Text)
    '            nMontoTotal = nValorVta + nMontoIgv
    '            nValorBruto = nValorVta + nMontodes

    '            txtvalorventaref.Text = Format(nValorUniRef, "0.00")
    '            txtvalorventaunit.Text = Format(nValorUnit, "0.00")
    '            txtpreciounitario.Text = Format(nPrecioUnit, "0.00")
    '            txtvalorbruto.Text = Format(nValorBruto, "0.00")
    '            txtdescuento.Text = Format(nMontodes, "0.00")
    '            txtvalorvent.Text = Format(nValorVta, "0.00")
    '            txt_igv.Text = Format(nMontoIgv, "0.00")
    '            txttotalneto.Text = Format(nMontoTotal, "0.00")
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    Private Sub Calcular_Importes_Detalle()
        Try
            Dim nValorVta As Double
            Dim nValorUniRef As Double
            Dim nValorUnit As Double
            Dim nPrecioUnit As Double
            Dim nDsctoUnit As Double
            Dim nValorBruto As Double
            Dim nTasaIGV As Double
            Dim nMontoIgv As Double
            Dim nMontodes As Double
            Dim nMontoTotal As Double
            'txttasa.Text = 18
            nTasaIGV = (Val(txttasa.Text) / 100)
            If Val(txtValorunitario.Text) <> 0 Then  'Valor unitario
                If chk_libre.Checked Then
                    'Aplicando descuento
                    nValorUnit = Val(txtValorunitario.Text)
                    If Val(txtcantidad.Text) <> 0 Then
                        nValorUniRef = 0
                        nDsctoUnit = Math.Round(nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100, 6)
                        nValorUnit = nValorUnit - nDsctoUnit
                    End If
                    'Precio Unitario
                    nPrecioUnit = nValorUnit
                    nValorVta = Math.Round(nValorUnit * Val(txtcantidad.Text), 2)
                    nMontodes = Math.Round(nDsctoUnit * Val(txtcantidad.Text), 2)
                    nMontoIgv = 0
                    nMontoTotal = nValorVta + nMontoIgv
                    nValorBruto = nValorVta + nMontodes
                    'txttasa.Text = 0
                Else
                    'Aplicando descuento
                    If chkigv.Checked = True Then
                        nValorUnit = Math.Round(Val(txtValorunitario.Text) / (1 + nTasaIGV), 6)
                    Else
                        nValorUnit = Val(txtValorunitario.Text)
                    End If
                    If Val(txtcantidadref.Text) <> 0 And Val(txtcantidad.Text) <> 0 Then
                        nValorUniRef = Math.Round((Val(txtcantidadref.Text) / Val(txtcantidad.Text)) * nValorUnit, 6)
                        nDsctoUnit = Math.Round(nValorUniRef * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100, 6)
                        nValorUniRef = nValorUniRef - nDsctoUnit
                        nValorUnit = nValorUniRef
                    Else
                        nValorUniRef = 0
                        nDsctoUnit = Math.Round(nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100, 6)
                        nValorUnit = nValorUnit - nDsctoUnit
                    End If
                    'Precio Unitario
                    nPrecioUnit = Math.Round(nValorUnit * (1 + nTasaIGV), 6)
                    nValorVta = Math.Round(nValorUnit * Val(txtcantidad.Text), 2)
                    nMontodes = Math.Round(nDsctoUnit * Val(txtcantidad.Text), 2)
                    nMontoIgv = Math.Round((nValorUnit * nTasaIGV) * Val(txtcantidad.Text), 2)
                    nMontoTotal = nValorVta + nMontoIgv
                    nValorBruto = nValorVta + nMontodes
                End If
            End If
            txtvalorventaref.Text = Format(nValorUniRef, "0.000000")
            txtvalorventaunit.Text = Format(nValorUnit, "0.000000")
            txtpreciounitario.Text = Format(nPrecioUnit, "0.000000")
            txtvalorbruto.Text = Format(nValorBruto, "0.00")
            txtdescuento.Text = Format(nMontodes, "0.00")
            txtvalorvent.Text = Format(nValorVta, "0.00")
            txt_igv.Text = Format(nMontoIgv, "0.00")
            txttotalneto.Text = Format(nMontoTotal, "0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub chkigv_CheckedChanged(sender As Object, e As EventArgs) Handles chkigv.CheckedChanged
        Calcular_Importes_Detalle()
        txtobservaciones.Focus()
    End Sub

    Private Sub Ayuda_Centro_Costo()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_CENTRO_COSTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centros de Costo"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcentroCosto.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                txtcentroCosto.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcentroCosto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcentroCosto.MouseDoubleClick
        Ayuda_Centro_Costo()
    End Sub

    Private Sub Ayuda_Area()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_AREA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centros de Costo"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarea.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                txtarea.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarea_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarea.MouseDoubleClick
        Ayuda_Area()
    End Sub

    Private Sub txtproyecto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtproyecto.MouseDoubleClick
        Ayuda_Proyecto()
    End Sub

    Private Sub Ayuda_Proyecto()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_PROYECTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centros de Costo"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtproyecto.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                txtproyecto.Text = ""

            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If ValidacionesGeneralesArticulo() = False Then Exit Sub
            If _Flag_edicion = False Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
                    row("ITEM") = CInt(dtdetalleArticuloPrincipal.Rows(dtdetalleArticuloPrincipal.Rows.Count - 1).Item("item").ToString) + 1 'dtdetalleArticuloPrincipal.Rows.Count() + 1
                Else
                    row("ITEM") = 1
                End If
                row("PART_ID") = txtcodigoArticulo.Text
                row("DESCRIPTION") = txtdescripcionArticulo.Text
                row("UNIT") = txtunidadMedida.Text
                row("UNIT_REFERENCE") = txtunidadMedRef.Text
                row("QTY") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
                row("FACTOR_REFERENCE") = IIf(txtcantidadref.Text = "", 0, txtcantidadref.Text)
                row("PRICE") = IIf(txtValorunitario.Text = "", 0, txtValorunitario.Text)
                row("DISCOUNT_PER") = IIf(txtporc_descuento.Text = "", 0, (txtporc_descuento.Text))
                row("DISCOUNT") = IIf(txtdescuento.Text = "", 0, txtdescuento.Text)
                row("AMOUNT_TAX") = IIf(txt_igv.Text = "", 0, txt_igv.Text)
                row("PERCENT_TAX") = IIf(txttasa.Text = "", 0, txttasa.Text)
                row("PRICE_NET") = IIf(txtvalorvent.Text = "", 0, txtvalorvent.Text)
                row("AMOUNT_TOTAL") = IIf(txtvalorventaunit.Text = "", 0, txtvalorventaunit.Text)
                row("AMOUNT_TOTAL_NET") = IIf(txttotalneto.Text = "", 0.0, txttotalneto.Text)
                row("COMMENT1") = txtobservaciones.Text
                row("TEXT_COMMENT") = txtGlosa.Text
                row("IS_VAT") = IIf(chkigv.Checked = True, "1", "0")
                row("PRICE_UNIT") = IIf(txtpreciounitario.Text = "", 0.0, txtpreciounitario.Text)
                row("CCOST_ID") = txtcentrocostodetalle.Text
                row("FLAG_FREE_IGV") = IIf(chk_libre.Checked = True, 1, 0)
                row("CENCOS") = txt_cen_cos.Text
                row("CENCOS_DES") = lbl_cen_cos_desc.Text
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                blank()
                txtcodigoArticulo.Select()
            Else
                For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _Codigo_Ini)
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("PART_ID") = txtcodigoArticulo.Text
                    row("DESCRIPTION") = txtdescripcionArticulo.Text
                    row("UNIT") = txtunidadMedida.Text
                    row("UNIT_REFERENCE") = txtunidadMedRef.Text
                    row("QTY") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
                    row("FACTOR_REFERENCE") = IIf(txtcantidadref.Text = "", 0, txtcantidadref.Text)
                    row("PRICE") = IIf(txtValorunitario.Text = "", 0, txtValorunitario.Text)
                    row("DISCOUNT_PER") = IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)
                    row("DISCOUNT") = IIf(txtdescuento.Text = "", 0, txtdescuento.Text)
                    row("AMOUNT_TAX") = IIf(txt_igv.Text = "", 0, txt_igv.Text)
                    row("PERCENT_TAX") = IIf(txttasa.Text = "", 0, txttasa.Text)
                    row("PRICE_NET") = IIf(txtvalorvent.Text = "", 0, txtvalorvent.Text)
                    row("AMOUNT_TOTAL") = IIf(txtvalorventaunit.Text = "", 0, txtvalorventaunit.Text)
                    row("AMOUNT_TOTAL_NET") = IIf(txttotalneto.Text = "", 0.0, txttotalneto.Text)
                    row("COMMENT1") = txtobservaciones.Text
                    row("TEXT_COMMENT") = txtGlosa.Text
                    row("IS_VAT") = IIf(chkigv.Checked = True, "1", "0")
                    row("PRICE_UNIT") = IIf(txtpreciounitario.Text = "", 0.0, txtpreciounitario.Text)
                    row("CCOST_ID") = txtcentrocostodetalle.Text
                    row("FLAG_FREE_IGV") = IIf(chk_libre.Checked = True, 1, 0)
                    row("CENCOS") = txt_cen_cos.Text
                    row("CENCOS_DES") = lbl_cen_cos_desc.Text
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                btn_cancel.PerformClick()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidacionesGeneralesArticulo() As Boolean
        Dim estado As Boolean = True
        Try
            If txtcantidad.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtcantidad.Focus()
                Exit Try
            ElseIf Val(txtcantidad.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtcantidad.Focus()
                Exit Try
            ElseIf txtValorunitario.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtValorunitario.Focus()
                Exit Try
            ElseIf Val(txtValorunitario.Text) = 0 Then
                MsgBox("La cantidad debe ser diferente a Cero", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtValorunitario.Focus()
                Exit Try
                'ElseIf txtcentrocostodetalle.Text = String.Empty Then
                '    MsgBox("Debe elegir un Centro de Costo.", MsgBoxStyle.Information, "Sistemas")
                '    estado = False
                '    txtcentrocostodetalle.Focus()
                '    Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim _NumeroCuenta As String
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_ARTICULO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = "RQ"
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                _NumeroCuenta = frm.Data_Matriz.Rows(0).Item("CUENTACOMPRA").ToString

                If Strings.Left(_NumeroCuenta, 1) = "6" And Strings.Left(_NumeroCuenta, 2) <> "60" And Strings.Left(_NumeroCuenta, 2) <> "61" Then
                    txt_cen_cos.Text = ""
                    lbl_cen_cos_desc.Text = ""
                    txt_cen_cos.Enabled = True
                    txt_cen_cos.BackColor = Color.Aquamarine
                Else
                    txt_cen_cos.Text = ""
                    lbl_cen_cos_desc.Text = ""
                    txt_cen_cos.Enabled = False
                    txt_cen_cos.BackColor = Color.Gainsboro
                End If
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos()
    End Sub

    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos()
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo.Text = String.Empty Then
                MostrandoArticulos()
            Else
                Dim codigoArticulo As String = String.Empty
                codigoArticulo = txtcodigoArticulo.Text.Trim
                AgregarArticuloManual(codigoArticulo)
            End If
        End If
    End Sub

    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            Dim clsArticuloBl As New LibCobranzas.ClsOperaciones.PART
            Dim _NumeroCuenta As String
            Dim dtDocumentoGuias As New DataTable
            dtDocumentoGuias = clsArticuloBl.Verifica_Cod_Producto(_codigoArticulo, "RS")
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("ID").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPTION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNIT_OF_MEASUREMENT").ToString
                _NumeroCuenta = dtDocumentoGuias.Rows(0).Item("CUENTACOMPRA").ToString

                If Strings.Left(_NumeroCuenta, 1) = "6" And Strings.Left(_NumeroCuenta, 2) <> "60" And Strings.Left(_NumeroCuenta, 2) <> "61" Then
                    txt_cen_cos.Text = ""
                    lbl_cen_cos_desc.Text = ""
                    txt_cen_cos.Enabled = True
                    txt_cen_cos.BackColor = Color.Aquamarine
                Else
                    txt_cen_cos.Text = ""
                    lbl_cen_cos_desc.Text = ""
                    txt_cen_cos.Enabled = False
                    txt_cen_cos.BackColor = Color.Gainsboro
                End If

                If txtcodigoArticulo.Text = "SERVICIO" Then
                    txtdescripcionArticulo.ReadOnly = False
                    txtdescripcionArticulo.Select()
                Else
                    txtdescripcionArticulo.ReadOnly = True
                    txtcentrocostodetalle.Select()
                End If

            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
                txtcodigoArticulo.Text = String.Empty
                txtdescripcionArticulo.Text = String.Empty
                txtunidadMedida.Text = String.Empty
                txtcodigoArticulo.Select()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        CONTROLES(True, 0)
        CalcularTotales()
        ConfigurarGrila()
        btn_menu.Enabled = True
    End Sub

    Private Sub CONTROLES(ByVal opcion As Boolean, ByVal _indice As Integer)
        For i As Integer = 0 To Tc_principal.TabPages.Count() - 1
            Tc_principal.TabPages(i).Enabled = False
        Next
        Tc_principal.TabPages(_indice).Enabled = opcion
        Tc_principal.SelectTab(_indice)
    End Sub



    Function Valida_Ingreso_Compras(ByVal _td As String, ByVal _serie As String, ByVal _numero As String, ByVal _proveedor As String) As Boolean
        Try
            Dim CompraBl As New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtTipoDoc As New DataTable
            dtTipoDoc = CompraBl.Get_Validacion_Ingreso_Compras(_td, _serie, _numero, _proveedor)
            If dtTipoDoc.Rows.Count > 0 Then
                Return False
                Exit Function
            End If
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Function Valida_Modificacion_Compras(ByVal _td As String, ByVal _serie As String, ByVal _numero As String, ByVal _proveedor As String) As Boolean
        Try
            Dim CompraBl As New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtTipoDoc As New DataTable
            dtTipoDoc = CompraBl.Get_Validacion_Modificacion_Compras(_td, _serie, _numero, _proveedor)
            If dtTipoDoc.Rows.Count > 0 Then
                Return False
                Exit Function
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub txtunidadMedRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtunidadMedRef.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Select()
        End If
    End Sub

    Private Sub txtcantidadref_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidadref.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGlosa.Select()
        End If
    End Sub

    Private Sub txtGlosa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGlosa.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtValorunitario.Select()
        End If
    End Sub



    Private Sub txtproyecto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproyecto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_anexar_Click(sender As Object, e As EventArgs) Handles btn_anexar.Click
        txtordencompra.Text = ""
        txtproveedor.Text = ""
        txtproveedor_razons.Text = ""
        txtproveedor_ruc.Text = ""
        dtdetalleArticuloPrincipal.Rows.Clear()
        Ayuda_OrdenesCompra()
        'CalcularTotales()
        dtpemision.Select()
    End Sub

    Private Sub Ayuda_Caja_Chica()
        Try
            Dim frm As New FrmBuscar_DetalleCajaChica

            Dim sql As String = String.Empty
            sql = "COMPRA_SP_S_LISTA_CAJA_CHICA"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE PLANILLAS DE CAJA CHICA"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                id_caja_chica = frm.Data_Matriz.Rows(0).Item(0).ToString
                item_caja_chica = frm.Data_Matriz.Rows(0).Item(1).ToString
                item = frm.Data_Matriz.Rows(0).Item(2).ToString
                txt_num_caja_chica.Text = frm.Data_Matriz.Rows(0).Item(0).ToString & "-" & frm.Data_Matriz.Rows(0).Item(1).ToString & "-" & frm.Data_Matriz.Rows(0).Item(2).ToString

                txttipodoc.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtserie_ref.Text = frm.Data_Matriz.Rows(0).Item(4).ToString
                If txtserie_ref.Text.Trim().Length > 0 Then
                    txtserie_ref.Text = txtserie_ref.Text '.PadLeft(10, Char.Parse("0"))
                End If
                txtnumero_ref.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                If txtnumero_ref.Text.Trim().Length > 0 Then
                    txtnumero_ref.Text = txtnumero_ref.Text '.PadLeft(15, Char.Parse("0"))
                End If

                dtp_emision_ref.Value = frm.Data_Matriz.Rows(0).Item(7).ToString
                dtp_vencimiento_ref.Value = frm.Data_Matriz.Rows(0).Item(7).ToString

                txtproveedor.Text = frm.Data_Matriz.Rows(0).Item(9).ToString
                txtproveedor_razons.Text = frm.Data_Matriz.Rows(0).Item(6).ToString
                txtproveedor_ruc.Text = frm.Data_Matriz.Rows(0).Item(9).ToString
                txtresponsable.Text = frm.Data_Matriz.Rows(0).Item(10).ToString
                lblresponsable.Text = frm.Data_Matriz.Rows(0).Item(11).ToString
                cbomoneda.SelectedValue = frm.Data_Matriz.Rows(0).Item(12).ToString
                txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(13).ToString
                lblformapago.Text = frm.Data_Matriz.Rows(0).Item(14).ToString
                txtComentario.Text = frm.Data_Matriz.Rows(0).Item(15).ToString
                txtproveedor.Enabled = False
                cbomoneda.Enabled = False
                txtFormaPago.Enabled = False
                txtresponsable.Enabled = False
            Else
                txtproveedor.Enabled = True
                cbomoneda.Enabled = True
                txtFormaPago.Enabled = True
                txtresponsable.Enabled = True
            End If
            frm.Close()
            'DETALLES
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = CompraBl.Compras_Detalle_Caja_Chica(id_caja_chica, item_caja_chica, item)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                ConfigurarGrila()
                Calcular_Importes_Detalle_Ayuda()
                CalcularTotales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_OrdenesCompra()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim ID_COMPRA As String = ""
            Dim TIPO_ID_COMPRA As String = ""
            sql = "COMPRA_SP_S_LISTA_ORDEN_COMPRA"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE ORDENES DE COMPRA"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TIPO_ID_COMPRA = frm.Data_Matriz.Rows(0).Item(0).ToString
                ID_COMPRA = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtordencompra.Text = TIPO_ID_COMPRA + ID_COMPRA
                txtproveedor.Text = frm.Data_Matriz.Rows(0).Item(4).ToString
                txtproveedor_razons.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txtproveedor_ruc.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                txtresponsable.Text = frm.Data_Matriz.Rows(0).Item(6).ToString
                lblresponsable.Text = frm.Data_Matriz.Rows(0).Item(7).ToString
                cbomoneda.SelectedValue = frm.Data_Matriz.Rows(0).Item(8).ToString
                txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(9).ToString
                lblformapago.Text = frm.Data_Matriz.Rows(0).Item(10).ToString
                txtproveedor.Enabled = False
                cbomoneda.Enabled = False
                txtFormaPago.Enabled = False
                txtresponsable.Enabled = False
            Else
                txtproveedor.Enabled = True
                cbomoneda.Enabled = True
                txtFormaPago.Enabled = True
                txtresponsable.Enabled = True
            End If
            frm.Close()
            If ID_COMPRA = "" Then Exit Sub
            'DETALLES
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = CompraBl.Compras_Detalle(ID_COMPRA, TIPO_ID_COMPRA)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                ConfigurarGrila()
                Calcular_Importes_Detalle_Ayuda()
                CalcularTotales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Calcular_Importes_Detalle_Ayuda()
        Try
            Dim nValorVta As Double
            Dim nValorUniRef As Double
            Dim nValorUnit As Double
            Dim nPrecioUnit As Double
            Dim nDsctoUnit As Double
            Dim nValorBruto As Double
            Dim nTasaIGV As Double
            Dim nMontoIgv As Double
            Dim nMontodes As Double
            Dim nMontoTotal As Double

            For Each row As DataRow In dtdetalleArticuloPrincipal.Rows
                nTasaIGV = (Val(row("PERCENT_TAX")) / 100)
                'nTasaIGV = (Val(IIf(String.IsNullOrEmpty(row("AMOUNT_TAX")), 0, row("AMOUNT_TAX"))) / 100)
                If Val(row("PRICE")) <> 0 Then  'Valor unitario
                    'Aplicando descuento
                    If row("FLAG_FREE_IGV") = "1" Then
                        'Aplicando descuento
                        nValorUnit = Val(row("PRICE"))
                        If Val(txtcantidad.Text) <> 0 Then
                            nValorUniRef = 0
                            nDsctoUnit = nValorUnit * (IIf(String.IsNullOrEmpty(row("DISCOUNT_PER")), 0, row("DISCOUNT_PER"))) / 100
                            nValorUnit = nValorUnit - nDsctoUnit
                        End If
                        'Precio Unitario
                        nPrecioUnit = nValorUnit
                        nValorVta = Math.Round(nValorUnit * Val(row("QTY")), 2)
                        nMontodes = Math.Round(nDsctoUnit * Val(row("QTY")), 2)
                        nMontoIgv = 0 '(nValorUnit * nTasaIGV) * Val(row("QTY"))
                        nMontoTotal = nValorVta + nMontoIgv
                        nValorBruto = nValorVta + nMontodes
                        'txttasa.Text = 0
                    Else
                        If row("IS_VAT") = "1" Then
                            nValorUnit = Math.Round(Val(row("PRICE")) / (1 + nTasaIGV), 10)
                        Else
                            nValorUnit = Val(row("PRICE"))
                        End If

                        If Val(row("FACTOR_REFERENCE")) <> 0 And Val(row("QTY")) <> 0 Then
                            nValorUniRef = Math.Round((Val(row("FACTOR_REFERENCE")) / Val(row("QTY"))) * nValorUnit, 6)
                            nDsctoUnit = nValorUniRef * (IIf(row("DISCOUNT_PER") = "", 0, row("DISCOUNT_PER"))) / 100
                            nValorUniRef = nValorUniRef - nDsctoUnit
                            nValorUnit = nValorUniRef
                        Else
                            nValorUniRef = 0
                            nDsctoUnit = nValorUnit * (IIf(String.IsNullOrEmpty(row("DISCOUNT_PER")), 0, row("DISCOUNT_PER"))) / 100
                            nValorUnit = nValorUnit - nDsctoUnit
                        End If
                        'Precio Unitario
                        nPrecioUnit = Math.Round(nValorUnit * (1 + nTasaIGV), 10)
                        nValorVta = Math.Round(nValorUnit * Val(row("QTY")), 2)
                        nMontodes = Math.Round(nDsctoUnit * Val(row("QTY")), 2)
                        nMontoIgv = Math.Round((nValorUnit * nTasaIGV) * Val(row("QTY")), 2)
                        nMontoTotal = nValorVta + nMontoIgv
                        nValorBruto = nValorVta + nMontodes
                    End If
                    'actualizando data
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("DISCOUNT") = Format(nMontodes, "0.00")
                    row("AMOUNT_TAX") = Format(nMontoIgv, "0.00")
                    row("PERCENT_TAX") = IIf(txttasa.Text = "", 0, txttasa.Text)
                    row("PRICE_NET") = Format(nValorVta, "0.00")
                    row("AMOUNT_TOTAL") = Format(nValorUnit, "0.00")
                    row("AMOUNT_TOTAL_NET") = Format(nMontoTotal, "0.00")
                    row("PRICE_UNIT") = Format(nPrecioUnit, "0.00")
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub txtcantidad_Leave(sender As Object, e As EventArgs) Handles txtcantidad.Leave
        If txtcantidad.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub

    Private Sub txttotalneto_KeyDown(sender As Object, e As KeyEventArgs) Handles txttotalneto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtobservaciones.Select()
        End If
    End Sub

    Private Sub Ayuda_Destinos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_TIPO_DESTINO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Titulo = "Tipo de Destinos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtoperacion.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lbltipooperacion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtFormaPago.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtoperacion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtoperacion.MouseDoubleClick
        Ayuda_Destinos()
    End Sub

    Private Sub txtoperacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtoperacion.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Destinos()
        End If
    End Sub

    Private Sub txtserie_ref_Leave(sender As Object, e As EventArgs) Handles txtserie_ref.Leave
        'If txtserie_ref.Text.Trim().Length > 0 Then
        '    txtserie_ref.Text = txtserie_ref.Text.PadLeft(10, Char.Parse("0"))
        'End If
    End Sub

    Private Sub txtnumero_ref_Leave(sender As Object, e As EventArgs) Handles txtnumero_ref.Leave
        'If txtnumero_ref.Text.Trim().Length > 0 Then
        '    txtnumero_ref.Text = txtnumero_ref.Text.PadLeft(15, Char.Parse("0"))
        'End If
    End Sub

    Private Sub cboTipoDoc_ref_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtserie_ref.KeyPress, txtnumero_ref.KeyPress, dtp_vencimiento_ref.KeyPress, cboTipoDoc_ref.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtoperacion_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub


    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Clientes()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtproveedor.Text = "" Then
                Ayuda_Clientes()
            Else
                dtpemision.Focus()
            End If
        End If
    End Sub

    Private Sub txtFormaPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFormaPago.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_FormaPago()
        End If
    End Sub

    Private Sub txtresponsable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtresponsable.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Responsable()
        End If
    End Sub

    Private Sub txtporc_descuento_Leave(sender As Object, e As EventArgs) Handles txtporc_descuento.Leave
        If txtporc_descuento.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub

    Private Sub txtobservaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub

    Private Sub txtoperacion_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then txtFormaPago.Focus()
    End Sub

    Private Sub txtComentario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtComentario.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregar.Select()
        End If
    End Sub

    Private Sub txttasa_Leave(sender As Object, e As EventArgs) Handles txttasa.Leave
        If txttasa.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub


    Private Sub chk_libre_CheckedChanged(sender As Object, e As EventArgs) Handles chk_libre.CheckedChanged
        chkigv.Enabled = Not chk_libre.Checked
        Calcular_Importes_Detalle()
    End Sub

    Private Sub dtp_emision_ref_ValueChanged(sender As Object, e As EventArgs) Handles dtp_emision_ref.ValueChanged
        Try
            Dim cls_compras = New ClsOperaciones.CURRENCY_TYPE
            Dim dt_Tc As Double

            dt_Tc = cls_compras.get_TiposCambio_fecha_dada(dtp_emision_ref.Value.ToString("dd/MM/yyyy"))

            If dt_Tc > 0 Then
                txttipoCambio.Text = dt_Tc
                txttipoCambio.Text = Format(CDbl(txttipoCambio.Text), "##,##0.000")
            Else
                txttipoCambio.Text = "0.000"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txttipodoc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txttipodoc.MouseDoubleClick
        Ayuda_Tipo_Doc()
        txttipodoc.Text = _tipo_de_documento
    End Sub
    Private Sub Ayuda_Tipo_Doc()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_S_S_DOCUMENT_TYPE"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Titulo = "Tipos de Documentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                _tipo_de_documento = frm.Data_Matriz.Rows(0).Item(0).ToString
                '                lbltipooperacion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Tipo_Doc_Anticipo()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_S_S_DOCUMENT_TYPE_ANTICIPOS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txtproveedor.Text
            frm.Titulo = "Anticipos del Sistema"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txttdanticipo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtserieanticipo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtnumeroanticipo.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                dtpfechaanticipo.Value = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtmontoanticipo.Text = Math.Round(CDbl(frm.Data_Matriz.Rows(0).Item(4).ToString), 2)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txttipodoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txttipodoc.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Tipo_Doc()
            txttipodoc.Text = _tipo_de_documento
            If txttipodoc.Text.Trim = "" Then
                txttipodoc.Focus()
            Else
                txtserie_ref.Focus()
            End If
        End If
    End Sub


    Private Sub btncontabilizar_Click(sender As Object, e As EventArgs) Handles btncontabilizar.Click

        If dgvCabecera.CurrentRow.Cells("ESTADO_CONTABLE").Value.ToString() = "CONTABILIZADO" Then MsgBox("El registro seleccionado, se encuentra CONTABILIZADO, no se puede Contabilizar.", MsgBoxStyle.Critical, "Aviso") : Exit Sub
        If dgvCabecera.CurrentRow.Cells("ESTADO").Value.ToString() = "ANULADO" Then MsgBox("El registro seleccionado, se encuentra ANULADO, no se puede Contabilizar.", MsgBoxStyle.Critical, "Aviso") : Exit Sub
        Dim id As Integer = Integer.Parse("0")
        Dim ff As New frm_CO_LT_IngVoucher
        ff.viene_de_compras = "si"
        ff.id_compras = "CO" & dgvCabecera.CurrentRow.Cells("ID").Value.ToString()
        ff.bol_edicion_Asiento = True
        Dim EstaDoc As String = String.Empty
        EstaDoc = "P"
        If EstaDoc = "F" Then ff.Flag_Estado_Fin = True Else ff.Flag_Estado_Fin = False
        ff.GenerarColummnaDataTableAsientoContable()
        ff.Cargar_Asiento_Editar(1, id, "CO" & dgvCabecera.CurrentRow.Cells("ID").Value.ToString(), CDate(dgvCabecera.CurrentRow.Cells("DOCUMENT_DATE").Value.ToString()).Year.ToString, CDate(dgvCabecera.CurrentRow.Cells("DOCUMENT_DATE").Value.ToString()).Month.ToString)
        'ff.Cargar_Asiento_Editar(1, id, "01", "2015", "1")
        ff.ShowDialog()
        DocumentosCompra()
    End Sub


    Private Sub txtPorc_Detrac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorc_Detrac.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtcentrocostocabecera.Focus()
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub txttd_cp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txttd_cp.MouseDoubleClick
        Ayuda_Tipo_Doc()
        txttd_cp.Text = _tipo_de_documento
    End Sub

    Private Sub txttd_cp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttd_cp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtserie_cp.Select()
    End Sub

    Private Sub txtserie_cp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtserie_cp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtnum_cp.Select()
    End Sub

    Private Sub txtnum_cp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnum_cp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtpor_cp.Select()
    End Sub

    Private Sub txttd_cp_KeyDown(sender As Object, e As KeyEventArgs) Handles txttd_cp.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Tipo_Doc()
            txttd_cp.Text = _tipo_de_documento
            txtserie_cp.Focus()
        End If
    End Sub

    Private Sub txtserie_cp_Leave(sender As Object, e As EventArgs) Handles txtserie_cp.Leave
        'If txtserie_cp.Text.Trim().Length > 0 Then
        '    txtserie_cp.Text = txtserie_cp.Text.PadLeft(5, Char.Parse("0"))
        'End If
    End Sub


    Private Sub txtnum_cp_Leave(sender As Object, e As EventArgs) Handles txtnum_cp.Leave
        'If txtnum_cp.Text.Trim().Length > 0 Then
        '    txtnum_cp.Text = txtnum_cp.Text.PadLeft(15, Char.Parse("0"))
        'End If
    End Sub

    Private Sub txtpor_cp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpor_cp.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then DTPEMISIONCP.Select()
    End Sub

    Private Sub chkcomp_percepcion_CheckedChanged(sender As Object, e As EventArgs) Handles chkcomp_percepcion.CheckedChanged
        If chkcomp_percepcion.Checked = True Then
            GroupBox7.Visible = True
            txttd_cp.Text = ""
            txtserie_cp.Text = ""
            txtnum_cp.Text = ""
            DTPEMISIONCP.Value = Date.Now
            DTPVCTOCP.Value = Date.Now
            txttd_cp.Focus()
        ElseIf chkcomp_percepcion.Checked = False Then
            GroupBox7.Visible = False
            txttd_cp.Text = ""
            txtserie_cp.Text = ""
            txtnum_cp.Text = ""
            DTPEMISIONCP.Value = Date.Now
            DTPVCTOCP.Value = Date.Now
        End If
    End Sub


    Private Sub dtp_emision_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_emision_ref.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim cls_compras = New ClsOperaciones.CURRENCY_TYPE
                Dim dt_Tc As Double

                dt_Tc = cls_compras.get_TiposCambio_fecha_dada(dtp_emision_ref.Value.ToString("dd/MM/yyyy"))

                If dt_Tc > 0 Then
                    txttipoCambio.Text = dt_Tc
                    txttipoCambio.Text = Format(CDbl(txttipoCambio.Text), "##,##0.000")
                Else
                    MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Exclamation, "Sistemas")
                    txttipoCambio.Text = "0.000"
                    dtp_emision_ref.Select()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvCabecera_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCabecera.CellContentDoubleClick
        Call btnConsultar_Click(sender, e)
    End Sub

    Private Sub dtp_emision_ref_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtp_emision_ref.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then dtp_vencimiento_ref.Focus()
    End Sub

    Private Sub txttdanticipo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txttdanticipo.MouseDoubleClick
        Ayuda_Tipo_Doc_Anticipo()
    End Sub

    Private Sub txttdanticipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txttdanticipo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tipo_Doc_Anticipo()
        End If
    End Sub

    Private Sub chkanticipo_CheckedChanged(sender As Object, e As EventArgs) Handles chkanticipo.CheckedChanged
        If chkanticipo.Checked = True Then
            txttdanticipo.Visible = True
            txtserieanticipo.Visible = True
            txtnumeroanticipo.Visible = True
            dtpfechaanticipo.Visible = True
            txtmontoanticipo.Visible = True
            PictureBox12.Visible = True
            txttdanticipo.Text = ""
            txtserieanticipo.Text = ""
            txtnumeroanticipo.Text = ""
            dtpfechaanticipo.Value = Date.Now
            txtmontoanticipo.Text = 0
        Else
            txttdanticipo.Visible = False
            txtserieanticipo.Visible = False
            txtnumeroanticipo.Visible = False
            dtpfechaanticipo.Visible = False
            txtmontoanticipo.Visible = False
            PictureBox12.Visible = False
            txttdanticipo.Text = ""
            txtserieanticipo.Text = ""
            txtnumeroanticipo.Text = ""
            dtpfechaanticipo.Value = Date.Now
            txtmontoanticipo.Text = 0
        End If
    End Sub

    Private Sub DTPEMISIONCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTPEMISIONCP.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then DTPVCTOCP.Select()
    End Sub

    Private Sub txtcentrocostocabecera_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcentrocostocabecera.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Centro_Costo_Compras()
        End If

    End Sub

    Private Sub txtcentrocostocabecera_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcentrocostocabecera.MouseDoubleClick
        Ayuda_Centro_Costo_Compras()
    End Sub

    Private Sub Tool_Imprimir_Orden_Pago_Click(sender As Object, e As EventArgs) Handles Tool_Imprimir_Orden_Pago.Click
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim CodigoCliente As String = String.Empty
        Dim NumeroDoc_OrdenPago As String = String.Empty

        CodigoCliente = dgvCabecera.CurrentRow.Cells("ID").Value.ToString
        NumeroDoc_OrdenPago = dgvCabecera.CurrentRow.Cells("NUM_ORDER_PAGO").Value.ToString

        Imprimir_Orden_Pago(CodigoCliente, NumeroDoc_OrdenPago)
    End Sub
    Private Sub Imprimir_Orden_Pago(ByVal customer_id As String, ByVal numerodocument As String)
        Try
            Dim dtImprimir As DataTable
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("OrdenPago")
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.Imprimir_Orden_Pago(customer_id, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Orden_Pago.rpt", dtImprimir, "", "", "usuario;" & LibComunVar.ClsVarComun.USUARIO, "numero_op;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtdescripcionArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdescripcionArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If
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
            If cmb_moneda_ref.SelectedIndex = -1 Then
                MsgBox("Debe elegir una moneda del Doc. de Ref.", MsgBoxStyle.Information)
                cmb_moneda_ref.Focus()
                Exit Try
            End If

            Dim Resultado() As DataRow
            Resultado = Dt_principal_lista_Doc_Ref.Select("TIPO_DOC='" & txtref_tipo.Text & "' and SERIE_DOC='" & txtref_serie.Text & "' and NUM_DOC='" & txtref_num_doc.Text & "' ", "")
            If Resultado.Count() <> 0 Then
                MsgBox("El documento ya se ingreso anteriormente.", MsgBoxStyle.Critical)
                Exit Try
            End If


            Dim VentasBl As LibContabilidad.ClsOperaciones.Asiento_Contable
            VentasBl = New LibContabilidad.ClsOperaciones.Asiento_Contable
            Dim dtVerficarNc As New DataTable
            dtVerficarNc = VentasBl.Verificacion_Existencia_Doc_Ref_Compras(txtref_tipo.Text, txtref_serie.Text, txtref_num_doc.Text, txtproveedor.Text)
            If dtVerficarNc.Rows.Count() <> 0 Then
                MsgBox("El número de documento ya se encuentra  anexado en otro Documento : " & dtVerficarNc.Rows(0).Item("DOCUMENT_ID").ToString & " - " & dtVerficarNc.Rows(0).Item("NUMBER_SERIE").ToString & " - " & dtVerficarNc.Rows(0).Item("NUMBER_DOCUMENT").ToString, MsgBoxStyle.Critical)
                If MsgBox("Desea agregar el documento como referencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    row("TIPO_DOC") = txtref_tipo.Text
                    row("SERIE_DOC") = txtref_serie.Text
                    row("NUM_DOC") = txtref_num_doc.Text
                    row("FECHA_DOC") = dtpRef_fecha.Value
                    row("MONEDA") = cmb_moneda_ref.SelectedValue
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
            row("MONEDA") = cmb_moneda_ref.SelectedValue
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
        txtref_tipo.Focus()
    End Sub
    Public Sub GenerarColummnaDataTable_Documento_Referencia()
        Try
            Dt_principal_lista_Doc_Ref = New DataTable
            Dt_principal_lista_Doc_Ref.Columns.Add("TIPO_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("SERIE_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("NUM_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("FECHA_DOC", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("MONEDA", Type.GetType("System.String"))
            Dt_principal_lista_Doc_Ref.Columns.Add("MONTO", Type.GetType("System.Double"))
            Dt_principal_lista_Doc_Ref.Columns.Add("IGV", Type.GetType("System.Double"))
            dgv_Lista_Doc_Ref.DataSource = Nothing
            dgv_Lista_Doc_Ref.DataSource = Dt_principal_lista_Doc_Ref
            dgv_Lista_Doc_Ref.AutoResizeColumns()
            dgv_Lista_Doc_Ref.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgv_Lista_Doc_Ref.Columns(0).HeaderText = "T. Doc."
            dgv_Lista_Doc_Ref.Columns(1).HeaderText = "S. Doc"
            dgv_Lista_Doc_Ref.Columns(2).HeaderText = "N° Doc."
            dgv_Lista_Doc_Ref.Columns(3).HeaderText = "Fec. Doc."
            dgv_Lista_Doc_Ref.Columns(4).HeaderText = "Moneda"
            dgv_Lista_Doc_Ref.Columns(5).HeaderText = "Monto"
            dgv_Lista_Doc_Ref.Columns(6).HeaderText = "Igv"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtref_tipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtref_tipo.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtref_tipo.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtref_tipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim VentasBl As LibContabilidad.ClsOperaciones.Asiento_Contable
            VentasBl = New LibContabilidad.ClsOperaciones.Asiento_Contable
            Dim dtMontoDocRef As New DataTable
            dtMontoDocRef = VentasBl.Verificar_Tipo_doc_Ref(txtref_tipo.Text)
            If dtMontoDocRef.Rows.Count() <> 0 Then
                txtref_serie.Focus()
            Else
                MsgBox("Debe ingresar un tipo de documento correcto.", MsgBoxStyle.Critical)
                txtref_tipo.Focus()
                Exit Sub
            End If

        End If
    End Sub

    Private Sub txtref_serie_Leave(sender As Object, e As EventArgs) Handles txtref_serie.Leave
        'If txtref_serie.Text.Trim().Length > 0 Then
        '    txtref_serie.Text = txtref_serie.Text.PadLeft(10, Char.Parse("0"))
        'End If
    End Sub



    Private Sub txtref_num_doc_Leave(sender As Object, e As EventArgs) Handles txtref_num_doc.Leave
        'If txtref_num_doc.Text.Trim().Length > 0 Then
        '    txtref_num_doc.Text = txtref_num_doc.Text.PadLeft(15, Char.Parse("0"))
        'End If
    End Sub

    Private Sub txtref_num_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_num_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txttipodoc.Text = "NC" Or txttipodoc.Text = "ND" Or txttipodoc.Text = "NCE" Then
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
                Dim VentasBl As LibContabilidad.ClsOperaciones.Asiento_Contable
                VentasBl = New LibContabilidad.ClsOperaciones.Asiento_Contable
                Dim dtMontoDocRef As New DataTable
                dtMontoDocRef = VentasBl.Montos_Documentos_Referencia_Compras(txtref_tipo.Text, txtref_serie.Text, txtref_num_doc.Text, txtproveedor.Text)
                If dtMontoDocRef.Rows.Count() <> 0 Then
                    VentasBl = New LibContabilidad.ClsOperaciones.Asiento_Contable
                    Dim dtVerficarNc As New DataTable
                    dtVerficarNc = VentasBl.Verificacion_Existencia_Doc_Ref_Compras(txtref_tipo.Text, txtref_serie.Text, txtref_num_doc.Text, txtproveedor.Text)
                    If dtVerficarNc.Rows.Count() <> 0 Then
                        MsgBox("El numero de documento ya se encuentra  anexado en otro Documento : " & dtVerficarNc.Rows(0).Item("DOCUMENT_ID").ToString & "  " & dtVerficarNc.Rows(0).Item("NUMBER_SERIE").ToString & " - " & dtVerficarNc.Rows(0).Item("NUMBER_DOCUMENT").ToString, MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        dtpRef_fecha.Value = dtMontoDocRef.Rows(0).Item(2).ToString
                        txtref_igv.Text = dtMontoDocRef.Rows(0).Item(0).ToString
                        txtref_monto.Text = dtMontoDocRef.Rows(0).Item(1).ToString
                        btnAdicionar.Focus()
                    End If
                Else
                    MsgBox("No hay ningun doc registrado con la informacion brindada.", MsgBoxStyle.Information)
                    txtref_igv.Text = ""
                    txtref_monto.Text = ""
                    dtpRef_fecha.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnSalr_Click(sender As Object, e As EventArgs) Handles btnSalr.Click
        pnlDocReferencia.Visible = False
        Limpiar_Lista_Doc()
        gbcabecera.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlDocReferencia.Visible = False
        Limpiar_Lista_Doc()
        'If Dt_principal_lista_Doc_Ref.Rows.Count() = 0 Then
        '    rbDocRef_uno.Checked = True
        'Else
        '    txttipoDocRef.Text = String.Empty
        '    txtSerieDocRef.Text = String.Empty
        '    txtNumDocRef.Text = String.Empty
        'End If
        gbcabecera.Enabled = True
    End Sub

    Private Sub txtref_serie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_serie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtref_num_doc.Focus()
        End If
    End Sub

    Private Sub dtpRef_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpRef_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtref_igv.Focus()
        End If
    End Sub

    Private Sub txtref_igv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_igv.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtref_monto.Focus()
        End If
    End Sub

    Private Sub txtref_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_monto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdicionar.Focus()
        End If

    End Sub

    Private Sub txtref_igv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtref_igv.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtref_monto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtref_monto.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtproveedor.Text = "" Then
            MsgBox("Debe seleccionar un Proveedor para poder Elegir esta opcion.", MsgBoxStyle.Information)
            txtproveedor.Focus()
            Exit Sub
        End If
        pnlDocReferencia.Visible = True
        dgv_Lista_Doc_Ref.DataSource = Nothing
        dgv_Lista_Doc_Ref.DataSource = Dt_principal_lista_Doc_Ref
        dgv_Lista_Doc_Ref.AutoResizeColumns()
        dgv_Lista_Doc_Ref.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        cmb_moneda_ref.SelectedIndex = 0
        gbcabecera.Enabled = False
        Limpiar_Lista_Doc()
    End Sub

    Private Sub txttipodoc_Leave(sender As Object, e As EventArgs) Handles txttipodoc.Leave
        If txttipodoc.Text = "NC" Or txttipodoc.Text = "ND" Or txttipodoc.Text = "NCE" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
        If txttipodoc.Text = "FI" Then
            chk_importacion.Visible = True
            chk_importacion.Checked = False
        Else
            chk_importacion.Visible = False
            chk_importacion.Checked = False
        End If
    End Sub

    Private Sub txt_tipo_doc_dua_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tipo_doc_dua.MouseDoubleClick
        Ayuda_Tipo_Doc()
        txt_tipo_doc_dua.Text = _tipo_de_documento
    End Sub

    Private Sub txt_tipo_doc_dua_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipo_doc_dua.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Tipo_Doc()
            txt_tipo_doc_dua.Text = _tipo_de_documento
            txt_ano_dua.Select()
        End If
    End Sub

    Private Sub txt_ano_dua_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ano_dua.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_aduanas.Select()
        End If
    End Sub

    Private Sub txt_cod_aduanas_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_aduanas.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Aduanas()
            txt_cod_aduanas.Text = _tipo_de_documento
            txt_numero_dua.Select()
        End If
    End Sub

    Private Sub txt_cod_aduanas_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_aduanas.MouseDoubleClick
        Ayuda_Aduanas()
        txt_cod_aduanas.Text = _tipo_de_documento
    End Sub
    Private Sub Ayuda_Aduanas()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_S_S_ADUANAS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Titulo = "Agencia de Aduanas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                _tipo_de_documento = frm.Data_Matriz.Rows(0).Item(0).ToString
                '                lbltipooperacion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_importacion_CheckedChanged(sender As Object, e As EventArgs) Handles chk_importacion.CheckedChanged
        If chk_importacion.Checked = True Then
            gb_datos_importacion.Visible = True
            txt_tipo_doc_dua.Text = ""
            txt_ano_dua.Text = ""
            txt_cod_aduanas.Text = ""
            txt_numero_dua.Text = ""
            txt_tipo_doc_dua.Focus()
        ElseIf chk_importacion.Checked = False Then
            gb_datos_importacion.Visible = False
            txt_tipo_doc_dua.Text = ""
            txt_ano_dua.Text = ""
            txt_cod_aduanas.Text = ""
            txt_numero_dua.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgv_Lista_Doc_Ref.RowCount = 0 Then Exit Sub
        If dgv_Lista_Doc_Ref.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            Eliminando()
        End If
    End Sub
    Private Sub Eliminando()
        Try
            Dim _TIPO_DOC As String = String.Empty
            Dim _SERIE_DOC As String = String.Empty
            Dim _NUM_DOC As String = String.Empty

            _TIPO_DOC = dgv_Lista_Doc_Ref.Item(0, dgv_Lista_Doc_Ref.CurrentRow.Index).Value
            _SERIE_DOC = dgv_Lista_Doc_Ref.Item(1, dgv_Lista_Doc_Ref.CurrentRow.Index).Value
            _NUM_DOC = dgv_Lista_Doc_Ref.Item(2, dgv_Lista_Doc_Ref.CurrentRow.Index).Value

            'Borrando los Datos
            For Each item As DataRow In Dt_principal_lista_Doc_Ref.Select("TIPO_DOC='" & _TIPO_DOC & "' and SERIE_DOC='" & _SERIE_DOC & "' and NUM_DOC='" & _NUM_DOC & "'")
                item.Delete()
                Dt_principal_lista_Doc_Ref.AcceptChanges()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_add_prov_Click(sender As Object, e As EventArgs) Handles btn_add_prov.Click
        btn_menu.Enabled = False
        Tc_principal.Enabled = False

        txt_cod.Text = ""
        txt_des.Text = ""
        txt_ruc.Text = ""
        txt_cod_pais.Text = ""
        txt_des_pais.Text = ""
        txt_ap_paterno.Text = ""
        txt_ap_materno.Text = ""
        txt_primer_nombre.Text = ""
        txt_segundo_nombre.Text = ""
        txt_dir.Text = ""
        cmb_td.SelectedIndex = -1
        cmb_tc.SelectedIndex = -1
        Call Cargar_TipoDoc()
        Call Cargar_TipoCompania()
        pnl_add_proveedor.Visible = True
        txt_cod.Focus()
    End Sub

    Private Sub Cargar_TipoDoc()
        Dim tipoDocBL As New LibCobranzas.ClsOperaciones.DOCUMENT_TYPE_PERSON
        cmb_td.DataSource = tipoDocBL.get_Documentos()
        cmb_td.DisplayMember = "DESCRIPTION"
        cmb_td.ValueMember = "DOCUMENT_TYPE_ID"
        tipoDocBL = Nothing
    End Sub

    Private Sub Cargar_TipoCompania()
        Dim companiaBL As New LibCobranzas.ClsOperaciones.COMPANY_TYPE
        cmb_tc.DataSource = companiaBL.get_TiposCompanis()
        cmb_tc.DisplayMember = "DESCRIPTION"
        cmb_tc.ValueMember = "COMPANY_TYPE_ID"
        companiaBL = Nothing
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        btn_menu.Enabled = True
        Tc_principal.Enabled = True
        pnl_add_proveedor.Visible = False
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dtproveedor As DataTable
            clsLetrasBl = New ClsNegocio.PART
            dtproveedor = New DataTable("Proveedores")
            dtproveedor = clsLetrasBl.ValidarProveedor(txt_cod.Text)
            If dtproveedor.Rows().Count() > 0 Then
                MsgBox("El codigo ingresado del Proveedor ya existe!", MsgBoxStyle.Critical)
                txt_cod.Focus()
            Else
                If cmb_td.SelectedValue = "01" Then
                    If txt_cod.Text.Length <> 8 Then
                        MsgBox("El codigo ingresado debe tener 8 caracteres!", MsgBoxStyle.Critical)
                        txt_cod.Focus()
                    Else
                        cmb_tc.Focus()
                    End If
                Else
                    If txt_cod.Text.Length <> 11 Then
                        MsgBox("El codigo ingresado debe tener 11 caracteres!", MsgBoxStyle.Critical)
                        txt_cod.Focus()
                    Else
                        cmb_tc.Focus()
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub cmb_td_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_td.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_tc.Focus()
        End If
    End Sub

    Private Sub cmb_tc_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ap_paterno.Focus()
        End If
    End Sub

    Private Sub txt_ruc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ruc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_dir.Focus()
        End If
    End Sub

    Private Sub txt_cod_pais_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_pais.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Pais(txt_cod_pais, txt_des_pais)
        ElseIf e.KeyCode = Keys.Enter Then
            If txt_cod_pais.Text = String.Empty Then
                Ayuda_Pais(txt_cod_pais, txt_des_pais)
            Else
                Button5.Select()
            End If
        End If
    End Sub

    Private Sub txt_cod_pais_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_pais.MouseDoubleClick
        Ayuda_Pais(txt_cod_pais, txt_des_pais)
    End Sub
    Private Sub Ayuda_Pais(ByVal CajaTexto As TextBox, ByVal CajaTexto_Des As TextBox)
        Try
            Dim frm As frmBuscar
            frm = New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_PAISES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Paises"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                CajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                CajaTexto_Des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If txt_cod.Text.Trim = "" Then
            MsgBox("Debe ingresar un codigo.", MsgBoxStyle.Critical, "Sistemas")
            txt_cod.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim = "" Then
            MsgBox("Debe ingresar la Razón Social.", MsgBoxStyle.Critical, "Sistemas")
            txt_des.Focus()
            Exit Sub
        End If

        If txt_dir.Text.Trim = "" Then
            MsgBox("Debe ingresar la dirección.", MsgBoxStyle.Critical, "Sistemas")
            txt_dir.Focus()
            Exit Sub
        End If

        If cmb_td.SelectedIndex = -1 Then
            MsgBox("Debe ingresar un Tipo de documento.", MsgBoxStyle.Critical, "Sistemas")
            cmb_td.Focus()
            Exit Sub
        End If
        If cmb_tc.SelectedIndex = -1 Then
            MsgBox("Debe ingresar un Tipo de compañia.", MsgBoxStyle.Critical, "Sistemas")
            cmb_tc.Focus()
            Exit Sub
        End If
        If txt_ruc.Text = "" Then
            MsgBox("Debe ingresar el nro de Ruc")
            txt_ruc.Select()
            Exit Sub
        End If
        If cmb_td.SelectedValue = "01" Then
            If txt_cod.Text.Length <> 8 Then
                MsgBox("El codigo ingresado debe tener 8 caracteres!", MsgBoxStyle.Critical)
                txt_cod.Focus()
                Exit Sub
            End If
            If txt_ruc.Text.Length <> 8 Then
                MsgBox("El RUC ingresado debe tener 8 caracteres!", MsgBoxStyle.Critical)
                txt_ruc.Focus()
                Exit Sub
            End If
            If txt_ap_paterno.Text.Trim = "" Then
                MsgBox("Debe ingresar el Apellido Paterno.", MsgBoxStyle.Critical, "Sistemas")
                txt_ap_paterno.Focus()
                Exit Sub
            End If
            If txt_ap_materno.Text.Trim = "" Then
                MsgBox("Debe ingresar el Apellido Materno.", MsgBoxStyle.Critical, "Sistemas")
                txt_ap_materno.Focus()
                Exit Sub
            End If
            If txt_primer_nombre.Text.Trim = "" Then
                MsgBox("Debe ingresar el Primer Nombre.", MsgBoxStyle.Critical, "Sistemas")
                txt_primer_nombre.Focus()
                Exit Sub
            End If
        Else
            If txt_cod.Text.Length <> 11 Then
                MsgBox("El codigo ingresado debe tener 11 caracteres!", MsgBoxStyle.Critical)
                txt_cod.Focus()
                Exit Sub
            End If
            If txt_ruc.Text.Length <> 11 Then
                MsgBox("El RUC ingresado debe tener 11 caracteres!", MsgBoxStyle.Critical)
                txt_cod.Focus()
                Exit Sub
            End If
        End If

        If cmb_tc.SelectedValue = "01" Or cmb_tc.SelectedValue = "02" Then
            If txt_ap_paterno.Text.Trim = "" Then
                MsgBox("Debe ingresar el Apellido Paterno.", MsgBoxStyle.Critical, "Sistemas")
                txt_ap_paterno.Focus()
                Exit Sub
            End If
            If txt_ap_materno.Text.Trim = "" Then
                MsgBox("Debe ingresar el Apellido Materno.", MsgBoxStyle.Critical, "Sistemas")
                txt_ap_materno.Focus()
                Exit Sub
            End If
            If txt_primer_nombre.Text.Trim = "" Then
                MsgBox("Debe ingresar el Primer Nombre.", MsgBoxStyle.Critical, "Sistemas")
                txt_primer_nombre.Focus()
                Exit Sub
            End If
        End If

        If Trim(txt_ruc.Text) <> Trim(txt_cod.Text) Then
            MsgBox("El RUC y codigo ingresado son diferentes, deben considerarse el mismo número.!", MsgBoxStyle.Critical)
            txt_cod.Focus()
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dtproveedor As DataTable
            clsLetrasBl = New ClsNegocio.PART
            dtproveedor = New DataTable("Proveedores")
            dtproveedor = clsLetrasBl.ValidarProveedor_Ruc(txt_ruc.Text)
            If dtproveedor.Rows().Count() > 0 Then
                MsgBox("El RUC ingresado ya existe, Verifique!", MsgBoxStyle.Critical)
                txt_ruc.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim proveedorBL As New LibCobranzas.ClsOperaciones.VENDOR
            Dim proveedorBE As New LibCobranzas.ClsEntidades.VENDOR

            With proveedorBE
                .ID = txt_cod.Text.Trim
                .NAME = txt_des.Text.Trim
                .VAT_REGISTRATION = txt_ruc.Text.Trim
                .ADDR = txt_dir.Text.Trim
                .PHONE = ""
                .EMAIL = ""
                .WEBSITE = ""
                .CONTACT = ""
                .DOCUMENT_TYPE_PERSON_ID = cmb_td.SelectedValue
                .TYPE_COMPANY = cmb_tc.SelectedValue
                .ACCOUNT_LOCAL = ""
                .ACCOUNT_EXTERNAL = ""
                .USER = LibComunVar.ClsVarComun.USUARIO
                .CREATE_DATE = Date.Now
                .PAIS = txt_cod_pais.Text.Trim
                .AP_PATERNO = txt_ap_paterno.Text.Trim
                .AP_MATERNO = txt_ap_materno.Text.Trim
                .PRIMER_NOMBRE = txt_primer_nombre.Text.Trim
                .SEGUNDO_NOMBRE = txt_segundo_nombre.Text.Trim
            End With

            If proveedorBL.Insert(proveedorBE) Then
                proveedorBE = Nothing
                proveedorBL = Nothing
                Me.Cursor = Cursors.Default
                Button6_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub dtpemision_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpemision.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Valida_Ingreso_Compras(txttipodoc.Text, txtserie_ref.Text, txtnumero_ref.Text, txtproveedor.Text) = False Then
                MsgBox("El documento a ingresar ya se encuentra registrado, verifique.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                cbomoneda.Focus()
            End If
        End If
    End Sub

    Private Sub cbomoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cbomoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtoperacion.Focus()
        End If
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGlosa.Select()
        End If
    End Sub

    Private Sub txtValorunitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValorunitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtobservaciones.Focus()
        End If
    End Sub

    Private Sub btn_anexar_caja_chica_Click(sender As Object, e As EventArgs) Handles btn_anexar_caja_chica.Click
        txtordencompra.Text = ""
        txtproveedor.Text = ""
        txtproveedor_razons.Text = ""
        txtproveedor_ruc.Text = ""
        txt_num_caja_chica.Text = ""
        dtdetalleArticuloPrincipal.Rows.Clear()
        Ayuda_Caja_Chica()
        'CalcularTotales()
        dtpemision.Select()

    End Sub

    Private Sub txt_ap_paterno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ap_paterno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ap_materno.Focus()
        End If
    End Sub

    Private Sub txt_ap_materno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ap_materno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_primer_nombre.Focus()
        End If
    End Sub

    Private Sub txt_primer_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_primer_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_segundo_nombre.Focus()
        End If
    End Sub

    Private Sub txt_segundo_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_segundo_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ruc.Focus()
        End If
    End Sub

    Private Sub txt_dir_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_dir.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_pais.Focus()
        End If
    End Sub

    Private Sub btn_contabilizar_marcado_Click(sender As Object, e As EventArgs) Handles btn_contabilizar_marcado.Click
        Try
            dgvCabecera.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgvCabecera.RowCount() = 0 Then
                MsgBox("No hay registros para Procesar.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                Dim estado As Boolean = False
                For Each row As DataGridViewRow In dgvCabecera.Rows
                    If row.Cells("SEL").Value = True Then
                        estado = True
                        Exit For
                    End If
                Next
                If estado = False Then
                    MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgvCabecera.Focus()
                    Exit Sub
                End If
            End If
            dgvCabecera.Refresh()

            If MessageBox.Show("Se van a CONTABILIZAR los items marcados" & vbCrLf & "¿Desea continuar?", "Contabilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                For Each row As DataGridViewRow In dgvCabecera.Rows
                    If row.Cells("SEL").Value And row.Cells("Estado").Value <> "ANULADO" Then
                        If Guardando_Asiento_Contable_marcado(row.Cells("ID").Value) = False Then
                            MsgBox("La compra N° " & row.Cells("ID").Value & " no se contabilizó. Verifique!!!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Next
                DocumentosCompra()
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardando_Asiento_Contable_marcado(ByVal codigo_compra As String) As Boolean
        Try
            Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalles As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)
            Dim asiento As New LibContabilidad.ClsOperaciones.Asiento_Contable
            Dim codigo_asiento As Integer = 0

            Dim dtDatos_Compra As DataTable
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtDatos_Compra = New DataTable("Datos_Compra")
            dtDatos_Compra = clsFacturaBl.Get_Datos_Compra(codigo_compra)
            If dtDatos_Compra.Rows.Count > 0 Then

                Dim fecha As DateTime = DateTime.Parse(dtDatos_Compra.Rows(0).Item("AC_FEC_VOUCHER").ToString)
                Dim ac As New LibContabilidad.ClsOperaciones.Asiento_Contable

                'ac = Nothing
                ''Ingresando Datos de la Cabecera del Asiento Contable
                cab.AC_ID = 0
                cab.AC_IDSUBDIARIO = dtDatos_Compra.Rows(0).Item("AC_IDSUBDIARIO").ToString
                cab.AC_NUM_VOUCHER = ac.get_Ult_num_voucher(dtDatos_Compra.Rows(0).Item("AC_IDSUBDIARIO").ToString, fecha.Year, Format(fecha.Month, "00"))
                While cab.AC_NUM_VOUCHER = ""
                    cab.AC_NUM_VOUCHER = ac.get_Ult_num_voucher(dtDatos_Compra.Rows(0).Item("AC_IDSUBDIARIO").ToString, fecha.Year, Format(fecha.Month, "00"))
                End While
                cab.AC_ANHO = fecha.Year
                cab.AC_MES = fecha.Month
                cab.AC_FEC_VOUCHER = dtDatos_Compra.Rows(0).Item("AC_FEC_VOUCHER").ToString
                cab.AC_IDMONEDA = Integer.Parse(dtDatos_Compra.Rows(0).Item("AC_IDMONEDA").ToString)
                cab.AC_DEBE = Double.Parse(dtDatos_Compra.Rows(0).Item("AC_DEBE").ToString)
                cab.AC_HABER = Double.Parse(dtDatos_Compra.Rows(0).Item("AC_HABER").ToString)
                cab.AC_ESTADO = 1
                cab.AC_GLOSA_VOU = dtDatos_Compra.Rows(0).Item("AC_GLOSA_VOU").ToString
                cab.AC_ES_INTERFACE = 0
                cab.AC_IDPLANILLA = ""
                cab.AC_RUC = dtDatos_Compra.Rows(0).Item("AC_RUC").ToString
                cab.AC_TIPO_DOC = dtDatos_Compra.Rows(0).Item("AC_TIPO_DOC").ToString
                cab.AC_SER_DOC = dtDatos_Compra.Rows(0).Item("AC_SER_DOC").ToString
                cab.AC_NUM_DOC = dtDatos_Compra.Rows(0).Item("AC_NUM_DOC").ToString
                cab.AC_FEC_DOC = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_DOC").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_DOC").ToString)
                cab.AC_FEC_DOC_VENCE = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_VENCE").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_VENCE").ToString)
                cab.AC_POR_IGV = dtDatos_Compra.Rows(0).Item("AC_POR_IGV")
                cab.AC_VAL_IGV = IIf(dtDatos_Compra.Rows(0).Item("AC_VAL_IGV").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_VAL_IGV"))
                cab.AC_TOTAL_DOC = IIf(dtDatos_Compra.Rows(0).Item("AC_TOTAL_DOC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_TOTAL_DOC"))
                cab.AC_TIPO_CAMBIO = IIf(dtDatos_Compra.Rows(0).Item("AC_TIPO_CAMBIO").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_TIPO_CAMBIO"))
                cab.AC_GLOSA_TRANSACCION = dtDatos_Compra.Rows(0).Item("AC_GLOSA_VOU").ToString
                cab.AC_DESTINO = dtDatos_Compra.Rows(0).Item("AC_DESTINO").ToString
                cab.AC_POR_ISC = IIf(dtDatos_Compra.Rows(0).Item("AC_POR_ISC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_POR_ISC"))
                cab.AC_ISC = IIf(dtDatos_Compra.Rows(0).Item("AC_ISC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_ISC"))
                cab.AC_POR_DETRAC = IIf(dtDatos_Compra.Rows(0).Item("AC_POR_DETRAC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_POR_DETRAC"))
                cab.AC_FEC_PLE = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_PLE").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_PLE").ToString)
                cab.AC_TIPO_DOC_REF = dtDatos_Compra.Rows(0).Item("AC_TIPO_DOC_REF").ToString
                cab.AC_SER_DOC_REF = dtDatos_Compra.Rows(0).Item("AC_SER_DOC_REF").ToString
                cab.AC_NUM_DOC_REF = dtDatos_Compra.Rows(0).Item("AC_NUM_DOC_REF").ToString
                cab.AC_FEC_DOC_REF = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_REF").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_REF").ToString)
                cab.AC_DETRAC = IIf(dtDatos_Compra.Rows(0).Item("AC_DETRAC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_DETRAC"))
                cab.AC_DUA = dtDatos_Compra.Rows(0).Item("AC_DUA")
                cab.AC_OP_INAFECTA = IIf(dtDatos_Compra.Rows(0).Item("AC_OP_INAFECTA").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_OP_INAFECTA"))
                cab.AC_OP_GRAVADA = IIf(dtDatos_Compra.Rows(0).Item("AC_OP_GRAVADA").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_OP_GRAVADA"))
                cab.AC_ID_REGCOMPRA = codigo_compra

                cab.AC_TIPO_DOC_DETRAC = dtDatos_Compra.Rows(0).Item("AC_TIPO_DOC_DETRAC").ToString
                cab.AC_SER_DOC_DETRAC = "" 'dtDatos_Compra.Rows(0).Item("").ToString
                cab.AC_NUM_DOC_DETRAC = dtDatos_Compra.Rows(0).Item("AC_NUM_DOC_DETRAC").ToString
                cab.AC_FEC_DOC_DETRAC = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_DETRAC").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_DETRAC").ToString)

                If asiento.Guardar_Asiento_Cabecera_Compras_Marcados(cab) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btn_act_cc_Click(sender As Object, e As EventArgs) Handles btn_act_cc.Click

        Try
            Cursor = Cursors.WaitCursor
            dgvCabecera.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgvCabecera.RowCount() = 0 Then
                Cursor = Cursors.Default
                MsgBox("No hay registros para Procesar.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                Dim estado As Boolean = False
                For Each row As DataGridViewRow In dgvCabecera.Rows
                    If row.Cells("SEL").Value = True Then
                        estado = True
                        Exit For
                    End If
                Next
                If estado = False Then
                    Cursor = Cursors.Default
                    MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgvCabecera.Focus()
                    Exit Sub
                Else
                    pnl_act_cc.Visible = True
                    pnlCabecera.Enabled = False
                    btn_menu.Enabled = False
                    txt_cod_act_cc.Text = ""
                    txt_desc_act_cc.Text = ""
                    txt_cod_act_cc.Focus()
                End If
            End If
            'dgvCabecera.Refresh()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_act_cc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_act_cc.MouseDoubleClick
        Ayuda_Centro_Costo_Compras_Act()
    End Sub

    Private Sub txt_cod_act_cc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_act_cc.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Centro_Costo_Compras_Act()
        End If
    End Sub

    Private Sub Ayuda_Centro_Costo_Compras_Act()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_CENTRO_COSTO_COMPRAS"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE CENTROS DE COSTO COMPRAS"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_act_cc.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_desc_act_cc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            Else
                txt_cod_act_cc.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnl_act_cc.Visible = False
        pnlCabecera.Enabled = True
        btn_menu.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try

            If MessageBox.Show("Se van a ACTUALIZAR los CENTROS DE COSTO de los items marcados" & vbCrLf & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                Dim asiento As New LibContabilidad.ClsOperaciones.Asiento_Contable

                For Each row As DataGridViewRow In dgvCabecera.Rows
                    If row.Cells("SEL").Value And row.Cells("Estado").Value <> "ANULADO" Then
                        If asiento.Actualiza_Centro_Costo_Compras(row.Cells("ID").Value, txt_cod_act_cc.Text.Trim) = False Then
                            MsgBox("La compra N° " & row.Cells("ID").Value & " no ACTUALIZO su CENTRO DE COSTOS. Verifique!!!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Next
                DocumentosCompra()
                Button4_Click(sender, e)
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Cursor = Cursors.Default
            Button4_Click(sender, e)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcentrocostodetalle_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcentrocostodetalle.MouseDoubleClick
        Ayuda_Centro_Costo_Compras(txtcentrocostodetalle.Text)
    End Sub

    Private Sub txtcentrocostodetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcentrocostodetalle.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Centro_Costo_Compras(txtcentrocostodetalle.Text)
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Len(Strings.Trim(txt_cod.Text)) = 11 Then
                cmb_td.SelectedValue = "06"
            ElseIf Len(Strings.Trim(txt_cod.Text)) = 8 Then
                Me.Cursor = Cursors.Default
                MsgBox("RUC incorrecto. Verifique", MsgBoxStyle.Exclamation)
                txt_cod.Focus()
                Exit Sub
            Else
                Me.Cursor = Cursors.Default
                MsgBox("El Código de Proveedor debe tener 11 caracteres.", MsgBoxStyle.Exclamation)
                txt_cod.Focus()
                Exit Sub
            End If

            Dim dtproveedor As DataTable
            clsLetrasBl = New ClsNegocio.PART
            dtproveedor = New DataTable("Proveedores")
            dtproveedor = clsLetrasBl.ValidarProveedor(txt_cod.Text)
            If dtproveedor.Rows().Count() > 0 Then
                MsgBox("El codigo ingresado del Proveedor ya existe!", MsgBoxStyle.Critical)
                txt_cod.Focus()
            Else
                Verifica_WS(txt_cod.Text)
                txt_cod.Focus()
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

            txt_des.Text = JObject.Parse(data)("nombre")
            txt_dir.Text = JObject.Parse(data)("direccion")
            txt_ruc.Text = _ruc

            MsgBox("Estado: " & JObject.Parse(data)("estado").ToString & vbCrLf & "Condición: " & JObject.Parse(data)("condicion").ToString, MsgBoxStyle.Information, "Aviso")


            Dim dt_ubigeo As DataTable
            dt_ubigeo = New DataTable
            Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            clsFacturaCabBl = New LibCobranzas.ClsOperaciones.RECEIVABLE
            Dim _cod_dep, _cod_prov, _cod_dis As String

            _cod_dep = Strings.Left(JObject.Parse(data)("ubigeo"), 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Departamento(_cod_dep, "", "")
            If dt_ubigeo.Rows.Count > 0 Then
                txt_dir.Text = txt_dir.Text & " " & dt_ubigeo.Rows(0).Item("DEPARTAMENTO")
            Else
                txt_dir.Text = txt_dir.Text
            End If

            _cod_prov = Strings.Mid(JObject.Parse(data)("ubigeo"), 3, 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Provincia(_cod_dep, _cod_prov, "")
            If dt_ubigeo.Rows.Count > 0 Then
                txt_dir.Text = txt_dir.Text & " " & dt_ubigeo.Rows(0).Item("PROVINCIA")
            Else
                txt_dir.Text = txt_dir.Text
            End If

            _cod_dis = Strings.Right(JObject.Parse(data)("ubigeo"), 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Distrito(_cod_dep, _cod_prov, _cod_dis)
            If dt_ubigeo.Rows.Count > 0 Then
                txt_dir.Text = txt_dir.Text & " " & dt_ubigeo.Rows(0).Item("DISTRITO")
            Else
                txt_dir.Text = txt_dir.Text
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
            If Len(Strings.Trim(txt_cod.Text)) = 11 Then
                Me.Cursor = Cursors.Default
                MsgBox("DNI incorrecto. Verifique", MsgBoxStyle.Exclamation)
                txt_cod.Focus()
                Exit Sub
            ElseIf Len(Strings.Trim(txt_cod.Text)) = 8 Then
                cmb_td.SelectedValue = "01"
            Else
                Me.Cursor = Cursors.Default
                MsgBox("El Código de Cliente debe tener 8 caracteres.", MsgBoxStyle.Exclamation)
                txt_cod.Focus()
                Exit Sub
            End If

            Dim dtproveedor As DataTable
            clsLetrasBl = New ClsNegocio.PART
            dtproveedor = New DataTable("Proveedores")
            dtproveedor = clsLetrasBl.ValidarProveedor(txt_cod.Text)
            If dtproveedor.Rows().Count() > 0 Then
                MsgBox("El codigo ingresado del Proveedor ya existe!", MsgBoxStyle.Critical)
                txt_cod.Focus()
            Else
                Verifica_WS_DNI(txt_cod.Text)
                txt_des.Focus()
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

            txt_des.Text = JObject.Parse(data)("nombre")
            txt_dir.Text = ""
            txt_ruc.Text = _ruc

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_verifica_cpe_Click(sender As Object, e As EventArgs) Handles btn_verifica_cpe.Click
        If txtproveedor.Text = String.Empty Then
            MsgBox("Debe elegir un Proveedor!!!", MsgBoxStyle.Exclamation)
            txtproveedor.Focus()
            Exit Sub
        ElseIf txttipodoc.Text = String.Empty Then
            MsgBox("Debe elegir un documento!!!", MsgBoxStyle.Exclamation)
            txttipodoc.Focus()
            Exit Sub
        ElseIf txtserie_ref.Text = String.Empty Then
            MsgBox("Debe ingresar la serie del comprobante!!!", MsgBoxStyle.Exclamation)
            txtserie_ref.Focus()
            Exit Sub
        ElseIf txtnumero_ref.Text = String.Empty Then
            MsgBox("Debe ingresar el número del comprobante!!!", MsgBoxStyle.Exclamation)
            txtnumero_ref.Focus()
            Exit Sub
        End If
        Dim _opcion_td As Integer = 0

        If txttipodoc.Text = "FT" Then
            _opcion_td = 0
        ElseIf txttipodoc.Text = "BV" Then
            _opcion_td = 1
        ElseIf txttipodoc.Text = "NC" Or txttipodoc.Text = "NCE" Then
            _opcion_td = 2
        ElseIf txttipodoc.Text = "ND" Then
            _opcion_td = 3
        Else
            _opcion_td = -1
        End If

        Dim frm_Valida_CPE As New FrmValida_CPE
        frm_Valida_CPE.txt_ruc_emisor.Text = txtproveedor.Text
        frm_Valida_CPE.cmb_ConsultaStatus.SelectedIndex = _opcion_td
        frm_Valida_CPE.txt_serie.Text = txtserie_ref.Text
        frm_Valida_CPE.txt_numero.Text = txtnumero_ref.Text
        frm_Valida_CPE.txt_fecha_emision.Text = dtp_emision_ref.Value.ToString("dd/MM/yyyy")
        frm_Valida_CPE.txt_total.Text = Replace(txtPrecioVenta.Text, ",", "")

        frm_Valida_CPE.ShowDialog()
    End Sub

    Private Sub btn_comp_retencion_Click(sender As Object, e As EventArgs) Handles btn_comp_retencion.Click
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        If dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value <> "-" Then
            MsgBox("No puede generar el Comprobante de Retención para el comprobante seleccionado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim percentDetrac As Double = 0
        Dim percentPercep As Double = 0
        Dim inafecto As String = ""
        Dim amount_sales As Double = 0
        Dim currency_type As String = ""
        Dim sell_rate As Double = 0

        Dim dtContribuyente As DataTable
        Dim dtCabeceraoC As New DataTable
        CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER

        dtCabeceraoC = CompraBl.Get_Datos_Verifica_Retencion(dgvCabecera.CurrentRow.Cells("ID").Value)
        If dtCabeceraoC.Rows.Count > 0 Then
            percentDetrac = dtCabeceraoC.Rows(0).Item("PERCENT_DETRAC").ToString
            percentPercep = dtCabeceraoC.Rows(0).Item("COM_PER_PERCENT").ToString
            inafecto = dtCabeceraoC.Rows(0).Item("TYPE_DESTINE").ToString
            amount_sales = dtCabeceraoC.Rows(0).Item("AMOUNT_SALES").ToString
            currency_type = dtCabeceraoC.Rows(0).Item("CURRENCY_TYPE").ToString
            sell_rate = dtCabeceraoC.Rows(0).Item("SELL_RATE").ToString
        End If

        If CDbl(percentDetrac) > 0 Then
            MsgBox("Tiene Detracción, No puede generar el Comprobante de Retención para el comprobante seleccionado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If CDbl(percentPercep) > 0 Then
            MsgBox("Tiene Percepción, No puede generar el Comprobante de Retención para el comprobante seleccionado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If CDbl(inafecto) = "02" Then
            MsgBox("Inafecto, No puede generar el Comprobante de Retención para el comprobante seleccionado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
        dtContribuyente = CompraBl.Get_ValidaRetencion(dgvCabecera.CurrentRow.Cells("VENDOR_ID").Value)
        If dtContribuyente.Rows.Count > 0 Then
            _AGENTE_RETENEDOR = dtContribuyente.Rows(0).Item("RETENEDOR").ToString
            _BUEN_CONTRIBUYENTE = dtContribuyente.Rows(0).Item("CONTRIBUYENTE").ToString
            _AGENTE_PERCEPCION = dtContribuyente.Rows(0).Item("PERCEPCION").ToString
        End If

        If _AGENTE_RETENEDOR = "V" Then
            MsgBox("Agente Retenedor, No puede generar el Comprobante de Retención para el Proveedor seleccionado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If _BUEN_CONTRIBUYENTE = "V" Then
            MsgBox("Buen Contribuyente, No puede generar el Comprobante de Retención para el Proveedor seleccionado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If _AGENTE_PERCEPCION = "V" Then
            MsgBox("Agente de Percepción, No puede generar el Comprobante de Retención para el Proveedor seleccionado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
        'Dim dtCabeceraoC As New DataTable
        dtCabeceraoC = CompraBl.get_Verifica_Ubigeo_Proveedor(dgvCabecera.CurrentRow.Cells("ID").Value)
        If dtCabeceraoC.Rows.Count() <> 0 Then
            MsgBox("Actualize el ubigeo del Proveedor!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If dgvCabecera.CurrentRow.Cells("CURRENCY_TYPE").Value = "MN" And CDbl(dgvCabecera.CurrentRow.Cells("AMOUNT_SALES").Value) < 700 Then
            MsgBox("El comprobante no esta afecto a una Retención a razón de que el total no supera el monto minimo!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf dgvCabecera.CurrentRow.Cells("CURRENCY_TYPE").Value = "ME" And (CDbl(dgvCabecera.CurrentRow.Cells("AMOUNT_SALES").Value) * CDbl(dgvCabecera.CurrentRow.Cells("SELL_RATE").Value)) < 700 Then
            MsgBox("El comprobante no esta afecto a una Retención a razón de que el total no supera el monto minimo!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        btn_menu.Enabled = False
        pnlCabecera.Enabled = False
        dtp_fecha_cr.Value = Date.Now
        lbl_id_compra.Text = dgvCabecera.CurrentRow.Cells("ID").Value
        pnl_genera_cr.Visible = True
        pnl_genera_cr.BringToFront()
        
    End Sub

    Private Function Generar_XML_Comprobante_retencion(ByVal Numero_compra As String, ByVal _monto_texto As String, ByRef _nombre_xml As String, ByRef _nombre_pdf As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_Xml_Comprobante_Retencion(Numero_compra, Ruta_FE() & "\InputXML", _monto_texto, _nombre_xml, _nombre_pdf) Then
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        btn_menu.Enabled = True
        pnlCabecera.Enabled = True
        pnl_genera_cr.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim STRmontotexto As String = ""
            Dim strMensaje As String = ""
            Dim nombre_xml As String = ""
            Dim nombre_pdf As String = ""

            If dgvCabecera.CurrentRow.Cells("CURRENCY_TYPE").Value = "MN" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(dgvCabecera.CurrentRow.Cells("AMOUNT_SALES").Value))) & " Soles"
            Else
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(dgvCabecera.CurrentRow.Cells("AMOUNT_SALES").Value))) & " Dólares Americanos"
            End If

            If MessageBox.Show("¿Desea generar el Comprobante de Retención?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If CompraBl.Genera_Comp_Retencion(dgvCabecera.CurrentRow.Cells("ID").Value, dtp_fecha_cr.Value.ToString("dd/MM/yyyy")) Then
                    If Generar_XML_Comprobante_retencion(dgvCabecera.CurrentRow.Cells("ID").Value, STRmontotexto, nombre_xml, nombre_pdf) = False Then
                        MsgBox("El documento " & dgvCabecera.CurrentRow.Cells("ID").Value & " no genero el archivo XML." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                    Else
                        Dim StrNomArchivo_XML As String = ""
                        Dim StrNomArchivo_PDF As String = ""

                        StrNomArchivo_XML = Ruta_FE() & "\InputXML" & "\" & nombre_xml

                        Dim oProcesaArchivo As New ProcesaArchivo

                        If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                            MsgBox(strMensaje, MsgBoxStyle.Critical)
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Else
                            StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & Date.Now.Year.ToString & "\" _
                                & Format(Date.Now.Month, "00") & "\" & Format(Date.Now.Day, "00") & "\" & nombre_pdf

                            StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & Date.Now.Year.ToString & "\" _
                                & Format(Date.Now.Month, "00") & "\" & Format(Date.Now.Day, "00") & "\" & nombre_xml

                            Dim msj As String = ""
                            msj = "Documento Generado Correctamente" & vbCrLf & "Nro Documento: " & dgvCabecera.CurrentRow.Cells("ID").Value & vbCrLf & "Desea imprimir el Comprobante de Retención?"
                            If MessageBox.Show(msj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                If File.Exists(StrNomArchivo_PDF) Then
                                    System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                                Else
                                    msj = String.Empty
                                    msj = "No existe el archivo " & vbCrLf & "" & nombre_pdf
                                    MsgBox(msj, MsgBoxStyle.Critical)
                                End If
                            End If

                            If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = False Then
                                MsgBox("ERROR:" & Chr(13) & "El documento " & nombre_xml & Chr(13) &
                                       "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                            End If

                            If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = False Then
                                MsgBox("ERROR:" & Chr(13) & "El documento " & nombre_pdf & Chr(13) &
                                "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                            End If

                            'MsgBox(msj, MsgBoxStyle.Information)
                        End If
                        DocumentosCompra()
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    MsgBox("No se genero el Comprobante de Retención. Verifique!!!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Ruta_FE_Verificacion() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE_Verificacion = mySetting("Ruta_FE_Verificacion")
        Return STRRuta_FE_Verificacion
    End Function

    Private Sub DescargarCompRetenciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarCompRetenciónToolStripMenuItem.Click
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        If dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value = "-" Then
            MsgBox("La compra seleccionada no tiene Comprobante de Retención.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim _fecha As Date = dgvCabecera.CurrentRow.Cells("FECHA_COM_PER").Value


            Dim StrNomArchivo_PDF As String = ""
            Dim StrNomArchivo_XML As String = ""
            Dim StrNomArchivo_CDR As String = ""

            Dim _ruta As String = ""
            Dim Carpeta As New FolderBrowserDialog
            If Carpeta.ShowDialog() = DialogResult.OK Then
                _ruta = Carpeta.SelectedPath.ToString
            Else
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" &
                               "20-" & dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".pdf"

            If File.Exists(StrNomArchivo_PDF) Then
                If Copiar_Archivos(StrNomArchivo_PDF, _ruta) = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("ERROR:" & Chr(13) & "El documento " & dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".PDF" & Chr(13) &
                                "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                    Exit Sub
                End If
            Else
                StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                    _fecha.Year.ToString & "\" & Format(_fecha.Month, "00") & "\" &
                                                    Format(_fecha.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-20-" &
                                                    dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".pdf"

                If File.Exists(StrNomArchivo_PDF) Then
                    If Copiar_Archivos(StrNomArchivo_PDF, _ruta) = False Then
                        Me.Cursor = Cursors.Default
                        MsgBox("ERROR:" & Chr(13) & "El documento " & dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".PDF" & Chr(13) &
                                    "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        Exit Sub
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-20-" & dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".pdf"
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If

            StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-" &
                               "20-" & dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".xml"

            If File.Exists(StrNomArchivo_XML) = True Then
                If Copiar_Archivos(StrNomArchivo_XML, _ruta) = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("ERROR:" & Chr(13) & "El documento " & dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".XML" & Chr(13) &
                            "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                    Exit Sub
                End If
            Else

                StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                    _fecha.Year.ToString & "\" & Format(_fecha.Month, "00") & "\" &
                                                    Format(_fecha.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-20-" &
                                                    dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".xml"

                If File.Exists(StrNomArchivo_XML) Then
                    If Copiar_Archivos(StrNomArchivo_XML, _ruta) = False Then
                        Me.Cursor = Cursors.Default
                        MsgBox("ERROR:" & Chr(13) & "El documento " & dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".XML" & Chr(13) &
                                    "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        Exit Sub
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-20-" & dgvCabecera.CurrentRow.Cells("COMPROBANTE_RETENCION").Value & ".xml"
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                End If

            End If

            MsgBox("CPE descargados correctamente.", MsgBoxStyle.Information, "Sistemas")

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_menu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles btn_menu.ItemClicked

    End Sub

    Private Sub txt_cen_cos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cen_cos.MouseDoubleClick
        Ayuda_Cen_Cos()
    End Sub

    Private Sub txt_cen_cos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cen_cos.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Cen_Cos()
        If e.KeyCode = Keys.Enter Then
            If txt_cen_cos.Text = "" Then
                Ayuda_Cen_Cos()
            End If
        End If
    End Sub
    Private Sub Ayuda_Cen_Cos(Optional ByVal _CodigoCuentaContable As String = "")
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CO_SP_S_CENCOS_MOV"
            frm.CadenaConsulta = sql
            'frm._Flag_Filtro = True
            'frm.Filtros1 = Date.Now.Year
            frm.Titulo = "Lista de Centros de Costos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cen_cos.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lbl_cen_cos_desc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                frm.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AplicarCentroDeCostoParaTodosLosItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicarCentroDeCostoParaTodosLosItemsToolStripMenuItem.Click
        If dgvDetalle.Rows.Count() = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub


        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CO_SP_S_CENCOS_MOV"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE CENTROS DE COSTO"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                For Each row As DataRow In dtdetalleArticuloPrincipal.Rows
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("CENCOS") = frm.Data_Matriz.Rows(0).Item(0).ToString
                    row("CENCOS_DES") = frm.Data_Matriz.Rows(0).Item(1).ToString
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
End Class