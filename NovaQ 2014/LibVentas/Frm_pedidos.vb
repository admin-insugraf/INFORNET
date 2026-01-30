Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing

Public Class Frm_pedidos

    Public CodigoVendedor As String = String.Empty
    Public DescripcionVendedor As String = String.Empty
    Public tipo_Vendedor As String = String.Empty
    Dim _igv As Double = 0

    Dim Modo_consultar As Boolean = False
    Dim PedidoCabENT As ClsEntidades.ORDER
    Dim PedidoDetENT As ClsEntidades.ORDER_LINE
    Dim ListaDetalles As List(Of ClsEntidades.ORDER_LINE)

    Dim clsPedidoBl As ClsOperaciones.ORDERS

    Dim CORRELATIVOBL As ClsTransacciones.ORDERS
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_cencosud As DataTable
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


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable("Pedido")
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRICE_SALES", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRICE_ORI", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DISCOUNT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT_TAX", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DISCOUNT_CUST", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DISCOUNT_SP", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PERCENT_TAX", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PERCENT_DISCOUNT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT_US", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("STATUS", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("SERIE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("TEXT_COMMENT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY_REF", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("LOT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("BALANCE", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("IS_PART_TAX", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("LIST_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT_ISC", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PERCENT_ISC", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRICE_NET", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("CENTRO_COSTO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CENTRO_COSTO_DES", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_LISTA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Cencosud()
        Try
            dtdetalleArticuloPrincipal_cencosud = New DataTable("Pedido")
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("ITEM_OC", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("ORDEN_COMPRA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("FECHA_EMISION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("FECHA_DESPACHO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("EAN13_CLIENTE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("PRICE_ORI", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_cencosud.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal_cencosud.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Spsa()
        Try
            dtdetalleArticuloPrincipal_cencosud = New DataTable("Pedido")
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("ITEM_OC", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("ORDEN_COMPRA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("FECHA_EMISION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("FECHA_DESPACHO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("EAN13_CLIENTE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_cencosud.Columns.Add("PRICE_ORI", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_cencosud.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal_cencosud.Columns("ITEM")}
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
            'For i As Integer = 6 To 12
            '    dgvDetalle.Columns(i).DefaultCellStyle.Format = "##,##0.00"
            'Next
            For i As Integer = 4 To dgvDetalle.ColumnCount() - 1
                dgvDetalle.Columns(i).Visible = False
            Next
            dgvDetalle.Columns(0).HeaderText = "Item"
            dgvDetalle.Columns(1).HeaderText = "Codigo"
            dgvDetalle.Columns(2).HeaderText = "Producto"
            dgvDetalle.Columns(3).HeaderText = "Cantidad"
            dgvDetalle.Columns(5).HeaderText = "Precio"
            dgvDetalle.Columns(6).HeaderText = "Descuento"
            dgvDetalle.Columns(7).HeaderText = "I.g.v"
            dgvDetalle.Columns(11).HeaderText = "%.Descuento"
            dgvDetalle.Columns(13).HeaderText = "Total"

            dgvDetalle.Columns(17).HeaderText = "Comentario"
            dgvDetalle.Columns(19).HeaderText = "Lote"
            dgvDetalle.Columns(23).HeaderText = "Unidad"
            dgvDetalle.Columns(26).HeaderText = "Valor.Venta"

            dgvDetalle.Columns(23).DisplayIndex = 3
            dgvDetalle.Columns(17).DisplayIndex = 12
            dgvDetalle.Columns(19).DisplayIndex = 4
            dgvDetalle.Columns(3).DisplayIndex = 5
            dgvDetalle.Columns(5).DisplayIndex = 6
            dgvDetalle.Columns(11).DisplayIndex = 7
            dgvDetalle.Columns(6).DisplayIndex = 8
            dgvDetalle.Columns(7).DisplayIndex = 9
            dgvDetalle.Columns(26).DisplayIndex = 10
            dgvDetalle.Columns(13).DisplayIndex = 11

            dgvDetalle.Columns(17).Visible = True

            dgvDetalle.Columns(4).Visible = False

            dgvDetalle.Columns(11).Visible = True
            dgvDetalle.Columns(13).Visible = True
            dgvDetalle.Columns(17).Visible = True
            dgvDetalle.Columns(19).Visible = True
            dgvDetalle.Columns(23).Visible = True
            dgvDetalle.Columns(26).Visible = True
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btn_importar_pedidos.Enabled = False
            btnGrabar.Enabled = True
            'btn_aprobar.Enabled = True
            btn_eliminar.Enabled = False
            btn_anular.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            btn_cotizacion.Enabled = False
        Else
            btnNuevo.Enabled = True
            btn_importar_pedidos.Enabled = True
            btn_cotizacion.Enabled = True
            btnGrabar.Enabled = False
            btn_anular.Enabled = True
            btn_aprobar.Enabled = False
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btn_eliminar.Enabled = True
            btnImprimir.Enabled = True
        End If
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
            Dim dtdocumentoPrin As DataTable
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtdocumentoPrin = New DataTable
            dtdocumentoPrin = clsPedidoBl.get_DatosGeneralesPedido(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                   cboopcionesBusqueda.SelectedIndex, CodigoVendedor, tipo_Vendedor, LibComunVar.ClsVarComun.AcesoVendedores)
            dgvCabecera.DataSource = Nothing
            If dtdocumentoPrin.Rows.Count() <> 0 Then
                dtv = dtdocumentoPrin.DefaultView
                dgvCabecera.DataSource = dtv
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvCabecera.Columns(2).Visible = False
                dgvCabecera.Columns(5).Visible = False
                'dgvCabecera.Columns(10).Visible = False
                'dgvCabecera.Columns(11).Visible = False
                'dgvCabecera.Columns(12).Visible = False

                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cbomoneda.DataSource = monedaBL.get_TiposCambio()
        cbomoneda.ValueMember = "CODIGO"
        cbomoneda.DisplayMember = "DESCRIPCION"

        cbo_moneda_importar.DataSource = monedaBL.get_TiposCambio()
        cbo_moneda_importar.ValueMember = "CODIGO"
        cbo_moneda_importar.DisplayMember = "DESCRIPCION"

        monedaBL = Nothing
    End Sub



    Private Sub FrmManufactura_Formulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        Cargar_Moneda()
        GenerarColummnaDataTable()
        Dim dtDatosCompany As DataTable
        reporteBL = New ClsBuscar
        dtDatosCompany = reporteBL.Obtener_Parametros_Empresa()
        If dtDatosCompany.Rows.Count > 0 Then
            _igv = dtDatosCompany.Rows(0).Item("AMOUNT_TAX").ToString
        Else
            _igv = 0
        End If
    End Sub

    'Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    DocumentosOrdenCompra()
    'End Sub

    Private Sub Limpiar()
        txtcodigo.Text = ""
        dtp_vencimiento.Value = Date.Today
        dtp_emision.Value = Date.Now
        txtvendedor.Text = String.Empty
        txtestado.Text = String.Empty
        txtcliente.Text = String.Empty
        txtrazonsocial.Text = String.Empty
        txtruc.Text = String.Empty
        txtdireccion.Text = ""
        cbomoneda.SelectedIndex = 0
        txttipoCambio.Text = LibComunVar.ClsVarComun.TCVenta
        txtFormaPago.Text = String.Empty
        txtPtoVenta.Text = String.Empty
        lblPtoVenta.Text = ""
        txtAlmacen.Text = ""
        lblAlmacen.Text = ""
        txttrama.Text = ""
        txtglosa.Text = String.Empty
        txtBruto.Text = "0.00"
        txtDescuentos.Text = "0.00"
        txtIgv.Text = "0.00"
        txtvalorVenta.Text = "0.00"
        txtPrecioVenta.Text = "0.00"
        dgvDetalle.DataSource = Nothing
        txtordencompra.Text = ""
        lblvendedor.Text = ""
        lblformapago.Text = ""
        txt_centro_costo.Text = ""
        lbl_centro_costo.Text = ""
        dtdetalleArticuloPrincipal.Rows.Clear()
    End Sub

    Private Sub Nuevo()
        Try
            dtdetalleArticuloPrincipal.Rows.Clear()
            ConfigurarGrila()
            Modo_consultar = False
            CONTROLES(True, 0)
            Botonera_Estado_Cambiar(True)
            btn_aprobar.Enabled = False
            pnlCabecera.Visible = False
            gbcabecera.Enabled = True
            Limpiar()
            txtcodigoArticulo.Enabled = True
            gbOpciones.Enabled = True
            txtcodigo.Text = "" 'Numeracion()
            txtvendedor.Text = CodigoVendedor
            lblvendedor.Text = DescripcionVendedor
            dtp_vencimiento.Select()
        Catch ex As Exception
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


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Call Botonera_Estado_Cambiar(True)
        CONTROLES(True, 0)
        btn_aprobar.Enabled = True
        pnlCabecera.Visible = False
        Dim _id As String = String.Empty
        Dim STREstado As String = String.Empty
        Dim Status_order As String = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        STREstado = dgvCabecera.Rows(dgvCabecera.CurrentRow.Index).Cells(8).Value
        Status_order = dgvCabecera.Rows(dgvCabecera.CurrentRow.Index).Cells(9).Value
        Try
            ''cabecera

            If Status_order = "FACTURADO" Then
                gbOpciones.Enabled = False
                btnGrabar.Enabled = False
            ElseIf Status_order = "ANULADO" Then
                gbOpciones.Enabled = False
                btnGrabar.Enabled = False
            Else
                gbOpciones.Enabled = True
            End If
            'If STREstado = "APROBADO" Then
            '    gbOpciones.Enabled = False
            '    btnGrabar.Enabled = False
            '    btn_aprobar.Enabled = False
            'ElseIf STREstado = "ANULADO" Then
            '    gbOpciones.Enabled = False
            '    btnGrabar.Enabled = False
            '    btn_aprobar.Enabled = False
            'ElseIf STREstado = "EMITIDO" Then
            '    gbOpciones.Enabled = True
            '    'btnGrabar.Enabled = True
            '    btn_aprobar.Enabled = True
            'End If
            clsPedidoBl = New ClsOperaciones.ORDERS
            Dim dtCabeceraoC As New DataTable
            dtCabeceraoC = clsPedidoBl.Modo_Edicion_Cabecera(_id)
            If dtCabeceraoC.Rows.Count() <> 0 Then
                txtcodigo.Text = dtCabeceraoC.Rows(0).Item(0).ToString
                dtp_emision.Value = dtCabeceraoC.Rows(0).Item("ORDER_DATE").ToString
                dtp_vencimiento.Value = dtCabeceraoC.Rows(0).Item("CADUCATE_DATE").ToString
                txtvendedor.Text = dtCabeceraoC.Rows(0).Item("SALES_ID").ToString
                lblvendedor.Text = dtCabeceraoC.Rows(0).Item("VENDEDOR").ToString
                txtPtoVenta.Text = dtCabeceraoC.Rows(0).Item("PLACE_SALES").ToString
                lblPtoVenta.Text = dtCabeceraoC.Rows(0).Item("PVENTA").ToString
                txtcliente.Text = dtCabeceraoC.Rows(0).Item("CUSTOMER_ID").ToString
                txtrazonsocial.Text = dtCabeceraoC.Rows(0).Item("CUSTOMER_NAME").ToString
                txtdireccion.Text = dtCabeceraoC.Rows(0).Item("CUSTOMER_ADDR").ToString
                txtruc.Text = dtCabeceraoC.Rows(0).Item("VAT_REGISTRATION").ToString
                txttipoCambio.Text = dtCabeceraoC.Rows(0).Item("SELL_RATE").ToString
                txtFormaPago.Text = dtCabeceraoC.Rows(0).Item("TERMS").ToString
                lblformapago.Text = dtCabeceraoC.Rows(0).Item("FPAGO").ToString
                cbomoneda.SelectedValue = dtCabeceraoC.Rows(0).Item("CURRENCY_ID").ToString
                txtestado.Text = dtCabeceraoC.Rows(0).Item("STATUS").ToString
                txtglosa.Text = dtCabeceraoC.Rows(0).Item("COMMENT").ToString
                txtordencompra.Text = dtCabeceraoC.Rows(0).Item("ORDER_PURCHASE").ToString
                txttrama.Text = dtCabeceraoC.Rows(0).Item("TRAMA_ID").ToString
                txt_centro_costo.Text = dtCabeceraoC.Rows(0).Item("ID_CENTRO_COSTO").ToString
                lbl_centro_costo.Text = dtCabeceraoC.Rows(0).Item("CENTRO_COSTO").ToString
                ''Ayuda_PuntoVenta(txtPtoVenta.Text)

                ''Detalle
                clsPedidoBl = New ClsOperaciones.ORDERS
                ' GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsPedidoBl.Modo_Edicion_Detalle(_id)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    ConfigurarGrila()
                    CalcularTotales()
                End If

                Call Cargar_Direccion_Entrega(txtcliente.Text.Trim)

                cbo_direc_entrega.Text = dtCabeceraoC.Rows(0).Item("CUSTOMER_ADDR_DLV").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardar_Pedido()
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
                .ORDER_DATE = dtp_emision.Value.ToShortDateString
                .CADUCATE_DATE = dtp_vencimiento.Value.ToShortDateString
                .SALES_ID = txtvendedor.Text
                .PLACE_SALES = txtPtoVenta.Text
                .CUSTOMER_ID = txtcliente.Text
                .CUSTOMER_NAME = txtrazonsocial.Text
                .CUSTOMER_ADDR = txtdireccion.Text
                .CUSTOMER_ADDR_DLV = cbo_direc_entrega.Text
                .VAT_REGISTRATION = txtruc.Text
                .AMOUNT = txtPrecioVenta.Text
                .DISCOUNT_CUSTOMER = 0
                .DISCOUNT_SP = 0
                .TERMS = txtFormaPago.Text
                .SELL_RATE = txttipoCambio.Text
                .CURRENCY_ID = cbomoneda.SelectedValue
                .DOCUMENT_REF = ""
                .SERIE_REF = ""
                .NUMBER_REF = ""
                .CREATE_DATE = Date.Today
                .STATUS = "V"
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .COMMENT = txtGlosa.Text
                .NUMBER_GUIA = ""
                .NUMBER_REC = ""
                .ORDER_PURCHASE = txtordencompra.Text
                .COMMENT1 = ""
                .AMOUNT_VAT = 0
                .DISCOUNT = 0
                .DISCOUNT_AMOUNT = 0
                .REC_TYPE = ""
                .DISCOUNT_VAL = 0
                .STATUS_ORDER = "EMITIDO"
                .TRAMA_ID = txttrama.Text
                .AMOUNT_ISC = 0
                .ID_CENTRO_COSTO = txt_centro_costo.Text
            End With
            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                PedidoDetENT = New ClsEntidades.ORDER_LINE
                With PedidoDetENT
                    .ID = PedidoCabENT.ID
                    .ITEM = item("ITEM")
                    .PART_ID = item("PART_ID")
                    .PART_DESCRIPTION = item("PART_DESCRIPTION")
                    .QTY = item("QTY")
                    .PRICE_SALES = item("PRICE_SALES")
                    .PRICE_ORI = item("PRICE_ORI")
                    .DISCOUNT = item("DISCOUNT")
                    .AMOUNT_TAX = item("AMOUNT_TAX")
                    .DISCOUNT_CUST = item("DISCOUNT_CUST")
                    .DISCOUNT_SP = item("DISCOUNT_SP")
                    .PERCENT_TAX = item("PERCENT_TAX")
                    .PERCENT_DISCOUNT = item("PERCENT_DISCOUNT")
                    .AMOUNT_US = item("AMOUNT_US")
                    .AMOUNT = item("AMOUNT")
                    .STATUS = item("STATUS")
                    .SERIE = item("SERIE")
                    .WAREHOUSE_ID = item("WAREHOUSE_ID")
                    .TEXT_COMMENT = item("TEXT_COMMENT")
                    .QTY_REF = item("QTY_REF")
                    .LOT = item("LOT")
                    .BALANCE = item("BALANCE")
                    .IS_PART_TAX = item("IS_PART_TAX")
                    .LIST_ID = item("LIST_ID")
                    .UNIT = item("UNIT")
                    .AMOUNT_ISC = item("AMOUNT_ISC")
                    .PERCENT_ISC = item("PERCENT_ISC")
                    .PRICE_NET = item("PRICE_NET")
                    .ID_CENTRO_COSTO = item("CENTRO_COSTO")
                End With
                ListaDetalles.Add(PedidoDetENT)
            Next
            If clsPedidoBl.GuardarPedido(PedidoCabENT, ListaDetalles, Modo_consultar) Then
                If Modo_consultar = True Then
                    MsgBox("Documento Modificado Correctamente," & vbCrLf & " Nro Documento: " & PedidoCabENT.ID, MsgBoxStyle.Information)
                Else
                    MsgBox("Nuevo documento Generado Correctamente," & vbCrLf & " Nro Documento: " & PedidoCabENT.ID, MsgBoxStyle.Information)
                End If
                If MessageBox.Show("Se procedera a la impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    imprimir_pedido(PedidoCabENT.ID)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardar_Pedido_Cencosud()
        Try
            clsPedidoBl = New ClsOperaciones.ORDERS
            PedidoCabENT = New ClsEntidades.ORDER


            Dim _contador As Integer = 0

            For i As Integer = 0 To dtdetalleArticuloPrincipal_cencosud.Rows.Count - 1
                With PedidoCabENT
                    Dim _CORRELATIVO As String = Numeracion()
                    .ID = _CORRELATIVO
                    .ORDER_DATE = dtp_fecha_pedido.Value.ToShortDateString

                    .SALES_ID = CodigoVendedor 'txtvendedor.Text
                    .PLACE_SALES = "" 'txtPtoVenta.Text
                    .CUSTOMER_ID = txt_cod_cliente_importar.Text
                    .CUSTOMER_NAME = txt_razon_social_importar.Text
                    .CUSTOMER_ADDR = txt_direccion_importar.Text
                    .CUSTOMER_ADDR_DLV = cbo_dir_entrega_importar.Text
                    .VAT_REGISTRATION = txt_ruc_importar.Text
                    .AMOUNT = 0 'txtPrecioVenta.Text
                    .DISCOUNT_CUSTOMER = 0
                    .DISCOUNT_SP = 0
                    .TERMS = txt_fp_importar.Text
                    .SELL_RATE = txt_tc_importar.Text
                    .CURRENCY_ID = cbo_moneda_importar.SelectedValue
                    .DOCUMENT_REF = ""
                    .SERIE_REF = ""
                    .NUMBER_REF = ""
                    .CREATE_DATE = Date.Today
                    .STATUS = "V"
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .COMMENT = "" 'txtglosa.Text
                    .NUMBER_GUIA = ""
                    .NUMBER_REC = ""

                    .COMMENT1 = ""
                    .AMOUNT_VAT = 0
                    .DISCOUNT = 0
                    .DISCOUNT_AMOUNT = 0
                    .REC_TYPE = ""
                    .DISCOUNT_VAL = 0
                    .STATUS_ORDER = "EMITIDO"
                    .TRAMA_ID = "" 'txttrama.Text
                    .AMOUNT_ISC = 0
                    .ID_CENTRO_COSTO = txt_cc_importar.Text
                End With
                Dim _items As Integer = 1
                ListaDetalles = New List(Of ClsEntidades.ORDER_LINE)
                For Each item As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM_OC=" & i + 1)
                    _contador = 1
                    PedidoCabENT.CADUCATE_DATE = CDate(item("FECHA_DESPACHO")).ToString("dd/MM/yyyy") 'dtdetalleArticuloPrincipal_cencosud.Rows(i).Item("FECHA_DESPACHO").ToString
                    PedidoCabENT.ORDER_PURCHASE = item("ORDEN_COMPRA") 'dtdetalleArticuloPrincipal_cencosud.Rows(i).Item("ORDEN_COMPRA").ToString
                    PedidoDetENT = New ClsEntidades.ORDER_LINE
                    With PedidoDetENT
                        .ID = PedidoCabENT.ID
                        .ITEM = _items
                        .PART_ID = item("PART_ID")
                        .PART_DESCRIPTION = item("PART_DESCRIPTION")
                        .QTY = item("CANTIDAD")
                        .PRICE_ORI = item("PRICE_ORI")
                        .PRICE_SALES = item("PRICE_ORI") * (1 + (_igv / 100))     'item("PRICE_SALES")
                        .DISCOUNT = 0 'item("DISCOUNT")
                        .AMOUNT_TAX = (.QTY * .PRICE_ORI) * (_igv / 100) 'item("AMOUNT_TAX")
                        .DISCOUNT_CUST = 0 'item("DISCOUNT_CUST")
                        .DISCOUNT_SP = 0 'item("DISCOUNT_SP")
                        .PERCENT_TAX = _igv 'item("PERCENT_TAX")
                        .PERCENT_DISCOUNT = 0 'item("PERCENT_DISCOUNT")
                        .AMOUNT_US = 0 'item("AMOUNT_US")
                        .AMOUNT = (.QTY * .PRICE_ORI) * (1 + (_igv / 100)) 'item("AMOUNT")
                        .STATUS = "" 'item("STATUS")
                        .SERIE = "" 'item("SERIE")
                        .WAREHOUSE_ID = "" ' item("WAREHOUSE_ID")
                        .TEXT_COMMENT = "" 'item("TEXT_COMMENT")
                        .QTY_REF = 0 'item("QTY_REF")
                        .LOT = "" 'item("LOT")
                        .BALANCE = 0 'item("BALANCE")
                        .IS_PART_TAX = 0 ' item("IS_PART_TAX")
                        .LIST_ID = "" 'item("LIST_ID")
                        .UNIT = item("UNIT")
                        .AMOUNT_ISC = 0 'item("AMOUNT_ISC")
                        .PERCENT_ISC = 0 'item("PERCENT_ISC")
                        .PRICE_NET = .QTY * .PRICE_ORI 'item("PRICE_NET")
                        .ID_CENTRO_COSTO = "" 'item("CENTRO_COSTO")
                    End With
                    ListaDetalles.Add(PedidoDetENT)
                    _items = _items + 1
                Next

                If _contador > 0 Then
                    If clsPedidoBl.GuardarPedido(PedidoCabENT, ListaDetalles, Modo_consultar) Then
                        MsgBox("Nuevo documento Generado Correctamente," & vbCrLf & " Nro Documento: " & PedidoCabENT.ID, MsgBoxStyle.Information)
                        'If MessageBox.Show("Se procedera a la impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        '    imprimir_pedido(PedidoCabENT.ID)
                        'End If
                    End If
                    _contador = 0
                End If
                _items = 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardar_Pedido_Spsa()
        Try
            clsPedidoBl = New ClsOperaciones.ORDERS
            PedidoCabENT = New ClsEntidades.ORDER

            'Dim _igv As Double = 0
            Dim _contador As Integer = 0

            For i As Integer = 0 To dtdetalleArticuloPrincipal_cencosud.Rows.Count - 1
                With PedidoCabENT
                    Dim _CORRELATIVO As String = Numeracion()
                    .ID = _CORRELATIVO
                    .SALES_ID = CodigoVendedor 'txtvendedor.Text
                    .PLACE_SALES = "" 'txtPtoVenta.Text
                    .CUSTOMER_ID = txt_cod_cliente_importar.Text
                    .CUSTOMER_NAME = txt_razon_social_importar.Text
                    .CUSTOMER_ADDR = txt_direccion_importar.Text
                    .CUSTOMER_ADDR_DLV = cbo_dir_entrega_importar.Text
                    .VAT_REGISTRATION = txt_ruc_importar.Text
                    .AMOUNT = 0 'txtPrecioVenta.Text
                    .DISCOUNT_CUSTOMER = 0
                    .DISCOUNT_SP = 0
                    .TERMS = txt_fp_importar.Text
                    .SELL_RATE = txt_tc_importar.Text
                    .CURRENCY_ID = cbo_moneda_importar.SelectedValue
                    .DOCUMENT_REF = ""
                    .SERIE_REF = ""
                    .NUMBER_REF = ""
                    .CREATE_DATE = Date.Today
                    .STATUS = "V"
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .COMMENT = "" 'txtglosa.Text
                    .NUMBER_GUIA = ""
                    .NUMBER_REC = ""

                    .COMMENT1 = ""
                    .AMOUNT_VAT = 0
                    .DISCOUNT = 0
                    .DISCOUNT_AMOUNT = 0
                    .REC_TYPE = ""
                    .DISCOUNT_VAL = 0
                    .STATUS_ORDER = "EMITIDO"
                    .TRAMA_ID = "" 'txttrama.Text
                    .AMOUNT_ISC = 0
                    .ID_CENTRO_COSTO = txt_cc_importar.Text
                End With
                Dim _items As Integer = 1
                ListaDetalles = New List(Of ClsEntidades.ORDER_LINE)
                For Each item As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM_OC=" & i + 1)
                    _contador = 1
                    PedidoCabENT.CADUCATE_DATE = CDate(item("FECHA_DESPACHO")).ToString("dd/MM/yyyy") 'dtdetalleArticuloPrincipal_cencosud.Rows(i).Item("FECHA_DESPACHO").ToString
                    PedidoCabENT.ORDER_PURCHASE = item("ORDEN_COMPRA") 'dtdetalleArticuloPrincipal_cencosud.Rows(i).Item("ORDEN_COMPRA").ToString
                    PedidoCabENT.ORDER_DATE = item("FECHA_EMISION") 'dtp_fecha_pedido.Value.ToShortDateString
                    PedidoDetENT = New ClsEntidades.ORDER_LINE
                    With PedidoDetENT
                        .ID = PedidoCabENT.ID
                        .ITEM = _items
                        .PART_ID = item("PART_ID")
                        .PART_DESCRIPTION = item("PART_DESCRIPTION")
                        .QTY = item("CANTIDAD")
                        .PRICE_ORI = item("PRICE_ORI")
                        .PRICE_SALES = item("PRICE_ORI") * (1 + (_igv / 100))     'item("PRICE_SALES")
                        .DISCOUNT = 0 'item("DISCOUNT")
                        .AMOUNT_TAX = (.QTY * .PRICE_ORI) * (_igv / 100) 'item("AMOUNT_TAX")
                        .DISCOUNT_CUST = 0 'item("DISCOUNT_CUST")
                        .DISCOUNT_SP = 0 'item("DISCOUNT_SP")
                        .PERCENT_TAX = _igv 'item("PERCENT_TAX")
                        .PERCENT_DISCOUNT = 0 'item("PERCENT_DISCOUNT")
                        .AMOUNT_US = 0 'item("AMOUNT_US")
                        .AMOUNT = (.QTY * .PRICE_ORI) * (1 + (_igv / 100)) 'item("AMOUNT")
                        .STATUS = "" 'item("STATUS")
                        .SERIE = "" 'item("SERIE")
                        .WAREHOUSE_ID = "" ' item("WAREHOUSE_ID")
                        .TEXT_COMMENT = "" 'item("TEXT_COMMENT")
                        .QTY_REF = 0 'item("QTY_REF")
                        .LOT = "" 'item("LOT")
                        .BALANCE = 0 'item("BALANCE")
                        .IS_PART_TAX = 0 ' item("IS_PART_TAX")
                        .LIST_ID = "" 'item("LIST_ID")
                        .UNIT = item("UNIT")
                        .AMOUNT_ISC = 0 'item("AMOUNT_ISC")
                        .PERCENT_ISC = 0 'item("PERCENT_ISC")
                        .PRICE_NET = .QTY * .PRICE_ORI 'item("PRICE_NET")
                        .ID_CENTRO_COSTO = "" 'item("CENTRO_COSTO")
                    End With
                    ListaDetalles.Add(PedidoDetENT)
                    _items = _items + 1
                Next

                If _contador > 0 Then
                    If clsPedidoBl.GuardarPedido(PedidoCabENT, ListaDetalles, Modo_consultar) Then
                        MsgBox("Nuevo documento Generado Correctamente," & vbCrLf & " Nro Documento: " & PedidoCabENT.ID, MsgBoxStyle.Information)
                        'If MessageBox.Show("Se procedera a la impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        '    imprimir_pedido(PedidoCabENT.ID)
                        'End If
                    End If
                    _contador = 0
                End If
                _items = 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardar_Pedido_Tottus()
        Try
            clsPedidoBl = New ClsOperaciones.ORDERS
            PedidoCabENT = New ClsEntidades.ORDER

            'Dim _igv As Double = 0
            Dim _contador As Integer = 0

            For i As Integer = 0 To dtdetalleArticuloPrincipal_cencosud.Rows.Count - 1
                With PedidoCabENT
                    Dim _CORRELATIVO As String = Numeracion()
                    .ID = _CORRELATIVO
                    .SALES_ID = CodigoVendedor 'txtvendedor.Text
                    .ORDER_DATE = dtp_fecha_pedido.Value.ToShortDateString
                    .PLACE_SALES = "" 'txtPtoVenta.Text
                    .CUSTOMER_ID = txt_cod_cliente_importar.Text
                    .CUSTOMER_NAME = txt_razon_social_importar.Text
                    .CUSTOMER_ADDR = txt_direccion_importar.Text
                    .CUSTOMER_ADDR_DLV = cbo_dir_entrega_importar.Text
                    .VAT_REGISTRATION = txt_ruc_importar.Text
                    .AMOUNT = 0 'txtPrecioVenta.Text
                    .DISCOUNT_CUSTOMER = 0
                    .DISCOUNT_SP = 0
                    .TERMS = txt_fp_importar.Text
                    .SELL_RATE = txt_tc_importar.Text
                    .CURRENCY_ID = cbo_moneda_importar.SelectedValue
                    .DOCUMENT_REF = ""
                    .SERIE_REF = ""
                    .NUMBER_REF = ""
                    .CREATE_DATE = Date.Today
                    .STATUS = "V"
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .COMMENT = "" 'txtglosa.Text
                    .NUMBER_GUIA = ""
                    .NUMBER_REC = ""

                    .COMMENT1 = ""
                    .AMOUNT_VAT = 0
                    .DISCOUNT = 0
                    .DISCOUNT_AMOUNT = 0
                    .REC_TYPE = ""
                    .DISCOUNT_VAL = 0
                    .STATUS_ORDER = "EMITIDO"
                    .TRAMA_ID = "" 'txttrama.Text
                    .AMOUNT_ISC = 0
                    .ID_CENTRO_COSTO = txt_cc_importar.Text
                End With
                Dim _items As Integer = 1
                ListaDetalles = New List(Of ClsEntidades.ORDER_LINE)
                For Each item As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM_OC=" & i + 1)
                    _contador = 1
                    PedidoCabENT.CADUCATE_DATE = CDate(item("FECHA_DESPACHO")).ToString("dd/MM/yyyy") 'dtdetalleArticuloPrincipal_cencosud.Rows(i).Item("FECHA_DESPACHO").ToString
                    PedidoCabENT.ORDER_PURCHASE = item("ORDEN_COMPRA") 'dtdetalleArticuloPrincipal_cencosud.Rows(i).Item("ORDEN_COMPRA").ToString

                    PedidoDetENT = New ClsEntidades.ORDER_LINE
                    With PedidoDetENT
                        .ID = PedidoCabENT.ID
                        .ITEM = _items
                        .PART_ID = item("PART_ID")
                        .PART_DESCRIPTION = item("PART_DESCRIPTION")
                        .QTY = item("CANTIDAD")
                        .PRICE_ORI = item("PRICE_ORI")
                        .PRICE_SALES = item("PRICE_ORI") * (1 + (_igv / 100))     'item("PRICE_SALES")
                        .DISCOUNT = 0 'item("DISCOUNT")
                        .AMOUNT_TAX = (.QTY * .PRICE_ORI) * (_igv / 100) 'item("AMOUNT_TAX")
                        .DISCOUNT_CUST = 0 'item("DISCOUNT_CUST")
                        .DISCOUNT_SP = 0 'item("DISCOUNT_SP")
                        .PERCENT_TAX = _igv 'item("PERCENT_TAX")
                        .PERCENT_DISCOUNT = 0 'item("PERCENT_DISCOUNT")
                        .AMOUNT_US = 0 'item("AMOUNT_US")
                        .AMOUNT = (.QTY * .PRICE_ORI) * (1 + (_igv / 100)) 'item("AMOUNT")
                        .STATUS = "" 'item("STATUS")
                        .SERIE = "" 'item("SERIE")
                        .WAREHOUSE_ID = "" ' item("WAREHOUSE_ID")
                        .TEXT_COMMENT = "" 'item("TEXT_COMMENT")
                        .QTY_REF = 0 'item("QTY_REF")
                        .LOT = "" 'item("LOT")
                        .BALANCE = 0 'item("BALANCE")
                        .IS_PART_TAX = 0 ' item("IS_PART_TAX")
                        .LIST_ID = "" 'item("LIST_ID")
                        .UNIT = item("UNIT")
                        .AMOUNT_ISC = 0 'item("AMOUNT_ISC")
                        .PERCENT_ISC = 0 'item("PERCENT_ISC")
                        .PRICE_NET = .QTY * .PRICE_ORI 'item("PRICE_NET")
                        .ID_CENTRO_COSTO = "" 'item("CENTRO_COSTO")
                    End With
                    ListaDetalles.Add(PedidoDetENT)
                    _items = _items + 1
                Next

                If _contador > 0 Then
                    If clsPedidoBl.GuardarPedido(PedidoCabENT, ListaDetalles, Modo_consultar) Then
                        MsgBox("Nuevo documento Generado Correctamente," & vbCrLf & " Nro Documento: " & PedidoCabENT.ID, MsgBoxStyle.Information)
                        'If MessageBox.Show("Se procedera a la impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        '    imprimir_pedido(PedidoCabENT.ID)
                        'End If
                    End If
                    _contador = 0
                End If
                _items = 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalle.Rows.Count() = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            If ValidacionesGenerales() = False Then Exit Sub
            For Each row As DataRow In dtdetalleArticuloPrincipal.Select("QTY=0", "")
                MessageBox.Show("Falta ingresar el precio y/o cantidad a los Articulos.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Next
        End If
        Guardar_Pedido()
        btnCancelar_Click(sender, e)
        DocumentosPedidos()
    End Sub


    Private Function Ayuda_CambioEstado(ByVal _Estado As String) As String
        Dim Estado As String = ""
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_PEDIDO_ESTADO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = _Estado
            frm.Titulo = "Listado de estado de pedidos"
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


    Private Sub btn_anular_Click(sender As Object, e As EventArgs) Handles btn_anular.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim STRPedido As String = String.Empty
            Dim STREstado As String = String.Empty
            Dim Estado As String = String.Empty


            STRPedido = dgvCabecera.Rows(dgvCabecera.CurrentRow.Index).Cells(0).Value
            STREstado = dgvCabecera.Rows(dgvCabecera.CurrentRow.Index).Cells(8).Value
            Estado = dgvCabecera.Rows(dgvCabecera.CurrentRow.Index).Cells(9).Value

            If STREstado = "AUTORIZADO" Then
                MessageBox.Show("El pedido ya se encuentra AUTORIZADO, no puede anularse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf STREstado = "RECHAZADO" Then
                MessageBox.Show("El pedido se encuentra RECHAZADO, no puede anularse .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If Estado = "ANULADO" Then
                MessageBox.Show("El pedido ya se encuentra ANULADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf Estado = "FACTURADO" Then
                MessageBox.Show("El pedido ya se encuentra FACTURADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("¿Desea anular el pedido " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If STREstado = "EMITIDO" Then
                    clsPedidoBl = New ClsOperaciones.ORDERS
                    If clsPedidoBl.Anular_Pedido(STRPedido) = True Then
                        MsgBox("Pedido anulado correctamente.", MsgBoxStyle.Information)
                        DocumentosPedidos()
                    End If
                End If
            End If
            btnCancelar_Click(sender, e)
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim _Id As String = String.Empty
        _Id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        imprimir_pedido(_Id)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        gbOpciones.Enabled = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        Limpiar()
        gbcabecera.Enabled = True
        'DocumentosPedidos()
    End Sub



    Private Sub txtComentario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtglosa.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtglosa.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try

            If txtcliente.Text = String.Empty Then
                MsgBox("Debe ingresar un cliente.", MsgBoxStyle.Information)
                estado = False
                txtcliente.Focus()
                Exit Try
            ElseIf txtvendedor.Text = String.Empty Then
                MsgBox("Debe seleccionar un vendedor .", MsgBoxStyle.Information)
                estado = False
                txtvendedor.Focus()
                Exit Try
            ElseIf txtFormaPago.Text = String.Empty Then
                MsgBox("Debe seleccionar una forma de Pago.", MsgBoxStyle.Information)
                estado = False
                txtFormaPago.Focus()
                Exit Try
            End If
            If cbomoneda.Text = String.Empty Then
                MsgBox("No se cargo datos del Tipo de Moneda.", MsgBoxStyle.Critical)
                estado = False
                cbomoneda.Focus()
                Exit Try
            End If
            If cbo_direc_entrega.Text = String.Empty Then
                MsgBox("Debe elegir una dirección de entrega.", MsgBoxStyle.Critical)
                estado = False
                cbo_direc_entrega.Focus()
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function



    Public Sub blank()
        txtcodigoArticulo.Text = ""
        txtdescripcionArticulo.Text = ""
        txtunidadMedida.Text = ""
        txtunidadMedRef.Text = ""
        txtcantidad.Text = ""
        txtcantidadref.Text = ""
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
        txtcentroCosto.Text = ""
        txtarea.Text = ""
        txtproyecto.Text = ""
        txtcomentario.Text = ""
        txt_centro_costo_detalle.Text = ""
        lbl_centro_costo_detalle.Text = ""
        cboLotes.DataSource = Nothing
        dgv_stock.DataSource = Nothing
        chkigv.Checked = Precio_Con_Sin_IGV()
        txtStockLote.Text = 0
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
                    If dtNivel.Rows(0).Item("PRECIO_IGV").ToString = True Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("PRECIO_IGV").ToString = False Then
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
            txttasa.Text = TasaIgvEstandar()
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
            clsPedidoBl = New ClsOperaciones.ORDERS
            Dim dtSistema As New DataTable("IGV_SISTEMA")
            dtSistema = clsPedidoBl.Get_DatosIgvsSistema()
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
                txtPrecioVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (AMOUNT) ", ""), "0.00")
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
                txtdescripcionArticulo.Text = row("PART_DESCRIPTION")
                txtunidadMedida.Text = row("UNIT")
                txtcantidad.Text = CDbl(row("QTY"))
                txtcantidadref.Text = IIf(row("QTY_REF").ToString = "", 0, row("QTY_REF"))
                txtValorunitario.Text = CDbl(row("PRICE_ORI"))
                txtporc_descuento.Text = row("PERCENT_DISCOUNT")
                txtdescuento.Text = row("DISCOUNT")
                txt_igv.Text = row("AMOUNT_TAX")
                txttasa.Text = row("PERCENT_TAX")
                txtvalorvent.Text = CDbl(row("PRICE_NET"))
                txttotalneto.Text = row("AMOUNT")
                txtcomentario.Text = row("TEXT_COMMENT")
                txt_centro_costo_detalle.Text = row("CENTRO_COSTO")
                lbl_centro_costo_detalle.Text = row("CENTRO_COSTO_DES")
                chkigv.Checked = row("IS_PART_TAX")
                ''Lotes
                MostrandoLotes(txtcodigoArticulo.Text)
                If Not cboLotes.DataSource Is Nothing Then
                    For i As Integer = 0 To cboLotes.Items.Count() - 1
                        cboLotes.SelectedIndex = i
                        'Dim Lot As String = dtlote.Rows(0).Item("NUMBER_LOT").ToString
                        If cboLotes.Text.ToString = row("LOT") Then
                            Exit For
                        Else
                            cboLotes.SelectedIndex = 0
                        End If
                    Next
                End If
                'chkigv.Checked = False
                If txtcantidadref.Text <> 0 Then
                    txtvalorventaref.Text = txtdescuento.Text
                Else
                    txtvalorventaref.Text = 0
                End If
                txtvalorbruto.Text = Format(Val(txtdescuento.Text) + Val(txtvalorVenta.Text), "0.00")
            Next
            txtcodigoArticulo.Enabled = False
            txtcantidad.Select()
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
                    RehacerSecuencia()
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
        DocumentosPedidos()
    End Sub

    'Private Sub Ayuda_Clientes()
    '    Try
    '        Dim frm As New frmBuscar
    '        Dim sql As String = String.Empty
    '        sql = "PUR_SP_S_PROVEEDORES"
    '        frm.CadenaConsulta = sql
    '        frm.Titulo = "Proveedores"
    '        frm.ShowDialog()
    '        If frm.Data_Matriz.Rows.Count > 0 Then
    '            txtcliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
    '            txtrazonsocial.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
    '            txtruc.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
    '        End If
    '        frm.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


    Private Sub Ayuda_FormaPago()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_FORMA_COBRO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Lista de Forma de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblformapago.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtordencompra.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_FormaPago_Importar()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_FORMA_COBRO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Lista de Forma de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_fp_importar.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lb_fp_importar.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_cc_importar.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Public Function Get_FormaPagoFechaVencimiento() As Date
    '    Dim fechaVencimiento As Date
    '    Try
    '        Dim clsBuscarBl As New ClsBuscar
    '        Dim dtFormaPagoFechaV As DataTable
    '        dtFormaPagoFechaV = clsBuscarBl.FormaPagoFechaVencimiento(txtFormaPago.Text)
    '        If dtFormaPagoFechaV.Rows.Count() <> 0 Then
    '            fechaVencimiento = DateAdd(DateInterval.Day, CInt(dtFormaPagoFechaV.Rows(0).Item("Dias")), CDate(dtp_emision.Value.ToString("dd/MM/yyyy")))
    '        Else
    '            fechaVencimiento = CDate(dtp_emision.Value.ToString("dd/MM/yyyy"))
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Return fechaVencimiento
    'End Function

    Private Sub txtFormaPago_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFormaPago.MouseDoubleClick
        Ayuda_FormaPago()
    End Sub


    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
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
                    STRorden = dgvCabecera.Columns(1).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    DocumentosPedidos()
        'End If
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
            nTasaIGV = (Val(txttasa.Text) / 100)
            If Val(txtValorunitario.Text) <> 0 Then  'Valor unitario
                'Aplicando descuento
                If chkigv.Checked = True Then
                    nValorUnit = Math.Round(Val(txtValorunitario.Text) / (1 + nTasaIGV), 6)
                Else
                    nValorUnit = Val(txtValorunitario.Text)
                End If
                If Val(txtcantidadref.Text) <> 0 And Val(txtcantidad.Text) <> 0 Then
                    nValorUniRef = Math.Round((Val(txtcantidadref.Text) / Val(txtcantidad.Text)) * nValorUnit, 6)
                    nDsctoUnit = nValorUniRef * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
                    nValorUniRef = nValorUniRef - nDsctoUnit
                    nValorUnit = nValorUniRef
                Else
                    nValorUniRef = 0
                    nDsctoUnit = nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
                    nValorUnit = nValorUnit - nDsctoUnit
                End If
                'Precio Unitario
                nPrecioUnit = nValorUnit * (1 + nTasaIGV)
                nValorVta = nValorUnit * Val(txtcantidad.Text)
                nMontodes = nDsctoUnit * Val(txtcantidad.Text)
                nMontoIgv = (nValorUnit * nTasaIGV) * Val(txtcantidad.Text)
                nMontoTotal = nValorVta + nMontoIgv
                nValorBruto = nValorVta + nMontodes

                txtvalorventaref.Text = Format(nValorUniRef, "0.00")
                txtvalorventaunit.Text = Format(nValorUnit, "0.00")
                txtpreciounitario.Text = Format(nPrecioUnit, "0.00")
                txtvalorbruto.Text = Format(nValorBruto, "0.00")
                txtdescuento.Text = Format(nMontodes, "0.00")
                txtvalorvent.Text = Format(nValorVta, "0.00")
                txt_igv.Text = Format(nMontoIgv, "0.00")
                txttotalneto.Text = Format(nMontoTotal, "0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub chkigv_CheckedChanged(sender As Object, e As EventArgs) Handles chkigv.CheckedChanged
        Calcular_Importes_Detalle()
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
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("PART_ID") = txtcodigoArticulo.Text
                row("PART_DESCRIPTION") = txtdescripcionArticulo.Text
                row("QTY") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
                row("PRICE_SALES") = 0
                row("PRICE_ORI") = IIf(txtValorunitario.Text = "", 0, txtValorunitario.Text)
                row("DISCOUNT") = IIf(txtdescuento.Text = "", 0, txtdescuento.Text)
                row("AMOUNT_TAX") = IIf(txt_igv.Text = "", 0, txt_igv.Text)
                row("DISCOUNT_CUST") = 0
                row("DISCOUNT_SP") = 0
                row("PERCENT_TAX") = IIf(txttasa.Text = "", 0, txttasa.Text)
                row("PERCENT_DISCOUNT") = IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)
                row("AMOUNT_US") = 0
                row("AMOUNT") = IIf(txttotalneto.Text = "", 0.0, txttotalneto.Text)
                row("STATUS") = ""
                row("SERIE") = ""
                row("WAREHOUSE_ID") = txtAlmacen.Text
                row("TEXT_COMMENT") = txtcomentario.Text
                row("QTY_REF") = IIf(txtcantidadref.Text = "", 0, txtcantidadref.Text)
                row("LOT") = IIf(cboLotes.Text = "", "", cboLotes.Text)
                row("BALANCE") = 0
                row("IS_PART_TAX") = IIf(chkigv.Checked, 1, 0)
                row("LIST_ID") = ""
                row("UNIT") = txtunidadMedida.Text
                row("AMOUNT_ISC") = 0
                row("PERCENT_ISC") = 0
                row("PRICE_NET") = IIf(txtvalorvent.Text = "", 0, txtvalorvent.Text)
                row("CENTRO_COSTO") = txt_centro_costo_detalle.Text.Trim
                row("CENTRO_COSTO_DES") = lbl_centro_costo_detalle.Text.Trim

                Dim clsArticuloBl As New ClsOperaciones.PART
                '++Informacion de Lotes
                Dim dtlote As DataTable
                dtlote = New DataTable
                dtlote = clsArticuloBl.get_Precios_Pedido(txtcodigoArticulo.Text, txtcliente.Text, cbomoneda.SelectedValue)
                If dtlote.Rows.Count() <> 0 Then
                    row("PRECIO_LISTA") = dtlote.Rows(0).Item("PRECIO").ToString
                Else
                    row("PRECIO_LISTA") = "0"
                End If

                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()

                'btn_cancel.PerformClick()
                'ConfigurarGrila()
                blank()
                txtcodigoArticulo.Select()
            Else
                For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _Codigo_Ini)
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("PART_ID") = txtcodigoArticulo.Text
                    row("PART_DESCRIPTION") = txtdescripcionArticulo.Text
                    row("QTY") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
                    row("PRICE_SALES") = 0
                    row("PRICE_ORI") = IIf(txtValorunitario.Text = "", 0, txtValorunitario.Text)
                    row("DISCOUNT") = IIf(txtdescuento.Text = "", 0, txtdescuento.Text)
                    row("AMOUNT_TAX") = IIf(txt_igv.Text = "", 0, txt_igv.Text)
                    row("DISCOUNT_CUST") = 0
                    row("DISCOUNT_SP") = 0
                    row("PERCENT_TAX") = IIf(txttasa.Text = "", 0, txttasa.Text)
                    row("PERCENT_DISCOUNT") = IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)
                    row("AMOUNT_US") = 0
                    row("AMOUNT") = IIf(txttotalneto.Text = "", 0.0, txttotalneto.Text)
                    row("STATUS") = ""
                    row("SERIE") = ""
                    row("WAREHOUSE_ID") = txtAlmacen.Text
                    row("TEXT_COMMENT") = txtcomentario.Text
                    row("QTY_REF") = IIf(txtcantidadref.Text = "", 0, txtcantidadref.Text)
                    row("LOT") = IIf(cboLotes.Text = "", "", cboLotes.Text)
                    row("BALANCE") = 0
                    row("IS_PART_TAX") = IIf(chkigv.Checked, 1, 0)
                    row("LIST_ID") = ""
                    row("UNIT") = txtunidadMedida.Text
                    row("AMOUNT_ISC") = 0
                    row("PERCENT_ISC") = 0
                    row("PRICE_NET") = IIf(txtvalorvent.Text = "", 0, txtvalorvent.Text)
                    row("CENTRO_COSTO") = txt_centro_costo_detalle.Text.Trim
                    row("CENTRO_COSTO_DES") = lbl_centro_costo_detalle.Text.Trim

                    Dim clsArticuloBl As New ClsOperaciones.PART
                    '++Informacion de Lotes
                    Dim dtlote As DataTable
                    dtlote = New DataTable
                    dtlote = clsArticuloBl.get_Precios_Pedido(txtcodigoArticulo.Text, txtcliente.Text, cbomoneda.SelectedValue)
                    If dtlote.Rows.Count() <> 0 Then
                        row("PRECIO_LISTA") = dtlote.Rows(0).Item("PRECIO").ToString
                    Else
                        row("PRECIO_LISTA") = "0"
                    End If

                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()

                Next
                blank()
                btn_cancel.PerformClick()
                'ConfigurarGrila()
                'txtcodigoArticulo.Select()
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
            ElseIf Val(txtValorunitario.Text) <= 0 Then
                MsgBox("El Valor Unitario debe ser mayor a Cero", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtValorunitario.Focus()
                Exit Try
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PED_SP_S_LISTAR_ARTICULO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString

                Mostrando_Precios(txtcodigoArticulo.Text, txtcliente.Text, cbomoneda.SelectedValue)

                txt_centro_costo_detalle.Select()
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


    Private Sub MostrandoLotes(ByVal codigoArticulo As String)
        Dim clsArticuloBl As New ClsOperaciones.PART
        '++Informacion de Lotes
        Dim dtlote As DataTable
        dtlote = New DataTable
        dtlote = clsArticuloBl.Datos_Lotes_articulo(txtAlmacen.Text, txtcodigoArticulo.Text)
        If dtlote.Rows.Count() <> 0 Then
            cboLotes.DisplayMember = "LOTE"
            cboLotes.ValueMember = "CANTIDAD"
            cboLotes.DataSource = dtlote
        Else
            cboLotes.DataSource = Nothing
            txtStockLote.Text = 0
        End If
    End Sub

    Private Sub Mostrando_Precios(ByVal codigoArticulo As String, ByVal codigoCliente As String, ByVal moneda As String)
        Dim clsArticuloBl As New ClsOperaciones.PART
        '++Informacion de Lotes
        Dim dtlote As DataTable
        dtlote = New DataTable
        dtlote = clsArticuloBl.get_Precios_Pedido(codigoArticulo, codigoCliente, moneda)
        If dtlote.Rows.Count() <> 0 Then
            txtValorunitario.Text = dtlote.Rows(0).Item("PRECIO").ToString
        Else
            txtValorunitario.Text = "0"
        End If
    End Sub

    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            Dim clsArticuloBl As New LibCobranzas.ClsOperaciones.PART
            Dim dtDocumentoGuias As New DataTable
            dtDocumentoGuias = clsArticuloBl.VerificacionArticuloCodigo_pedido(txtAlmacen.Text, _codigoArticulo)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNID_MED").ToString
                Mostrando_Precios(txtcodigoArticulo.Text, txtcliente.Text, cbomoneda.SelectedValue)
                txt_centro_costo_detalle.Select()
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

    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtunidadMedRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtunidadMedRef.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Select()
        End If
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidadref_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidadref.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGlosa.Select()
        End If
    End Sub

    Private Sub txtGlosa_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtValorunitario.Select()
        End If
    End Sub

    Private Sub txtporc_descuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalorventaunit.KeyPress, txtvalorventaref.KeyPress, txtvalorvent.KeyPress, txtValorunitario.KeyPress, txtvalorbruto.KeyPress, txttasa.KeyPress, txtpreciounitario.KeyPress, txtdescuento.KeyPress, txt_igv.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtobservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcentroCosto.KeyPress, txtarea.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtproyecto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproyecto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub Ayuda_OrdenesCompra()
        Try
            'Dim frm As New frmBuscar
            'Dim sql As String = String.Empty
            'Dim ID_COMPRA As String = ""
            'sql = "COMPRA_SP_S_LISTA_ORDEN_COMPRA"
            'frm.CadenaConsulta = sql
            'frm.Titulo = "LISTA DE ORDENES DE COMPRA"
            'frm.ShowDialog()
            'If frm.Data_Matriz.Rows.Count > 0 Then
            '    ID_COMPRA = frm.Data_Matriz.Rows(0).Item(0).ToString
            '    txtordencompra.Text = ID_COMPRA
            '    txtproveedor.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
            '    txtproveedor_razons.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            '    txtproveedor_ruc.Text = frm.Data_Matriz.Rows(0).Item(4).ToString
            'End If
            'frm.Close()
            'If ID_COMPRA = "" Then Exit Sub
            ''DETALLES
            'clsPedidoBl = New ClsOperaciones.ORDERS
            'GenerarColummnaDataTable()
            'dtdetalleArticuloPrincipal = CompraBl.Compras_Detalle(ID_COMPRA)
            'If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            '    ConfigurarGrila()
            '    Calcular_Importes_Detalle_Ayuda()
            '    CalcularTotales()
            'End If
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
                nTasaIGV = (Val(row("AMOUNT_TAX")) / 100)
                If Val(row("PRICE")) <> 0 Then  'Valor unitario
                    'Aplicando descuento
                    If row("IS_VAT") = "1" Then
                        nValorUnit = Math.Round(Val(row("PRICE")) / (1 + nTasaIGV), 6)
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
                    nPrecioUnit = nValorUnit * (1 + nTasaIGV)
                    nValorVta = nValorUnit * Val(row("QTY"))
                    nMontodes = nDsctoUnit * Val(row("QTY"))
                    nMontoIgv = (nValorUnit * nTasaIGV) * Val(row("QTY"))
                    nMontoTotal = nValorVta + nMontoIgv
                    nValorBruto = nValorVta + nMontodes
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
        End If
    End Sub

 
    Private Sub txtFormaPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFormaPago.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_FormaPago()
        If e.KeyCode = Keys.Enter Then
            If txtFormaPago.Text = String.Empty Then
                Ayuda_FormaPago()
            Else
                txtordencompra.Focus() ' Ayuda_Vendedor(txtvendedor.Text)
            End If
        End If
    End Sub

    Private Sub txtporc_descuento_Leave(sender As Object, e As EventArgs) Handles txtporc_descuento.Leave
        If txtValorunitario.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub

    Private Sub txtobservaciones_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub

    Private Sub txtComentario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtglosa.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    btnAgregar.Select()
        'End If
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
                Dim clsFacturaBl As New ClsOperaciones.RECEIVABLE
                Dim dtDetalleFact As New DataTable("Punto_Venta")
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
                    txtPtoVenta.Focus()
                    Exit Sub
                End If
            End If
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
 
    Private Sub Ayuda_Clientes(Optional ByVal _CodigoCliente As String = "")
        Try
            Dim clsBuscarBl As New ClsBuscar
            If _CodigoCliente = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "PED_SP_S_ORDER_CLIENTE"
                frm.CadenaConsulta = sql
                frm.Titulo = "Clientes"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtcliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtrazonsocial.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txtruc.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                    txtdireccion.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                    txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                    txtvendedor.Text = frm.Data_Matriz.Rows(0).Item("SALES_ID").ToString
                End If
                frm.Close()
            Else
                Dim clsFacturaBl As New ClsOperaciones.RECEIVABLE
                Dim dtDetalleFact As New DataTable("Clientes")
                dtDetalleFact = clsFacturaBl.Get_ManualClientes(_CodigoCliente)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtcliente.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txtrazonsocial.Text = dtDetalleFact.Rows(0).Item(1).ToString
                    txtruc.Text = dtDetalleFact.Rows(0).Item(2).ToString
                    txtdireccion.Text = dtDetalleFact.Rows(0).Item(3).ToString
                    txtFormaPago.Text = dtDetalleFact.Rows(0).Item(5).ToString
                    'txtvendedor.Text = dtDetalleFact.Rows(0).Item("SALES_ID").ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtcliente.Text = String.Empty
                    txtrazonsocial.Text = String.Empty
                    txtruc.Text = String.Empty
                    txtdireccion.Text = String.Empty
                    txtFormaPago.Text = String.Empty
                    txtvendedor.Text = String.Empty
                    lblvendedor.Text = String.Empty
                    lblformapago.Text = String.Empty
                    txtFormaPago.Focus()
                    Exit Sub
                End If
            End If
            If txtFormaPago.Text = String.Empty Then
                lblformapago.Text = ""
            Else
                clsBuscarBl = New ClsBuscar
                lblformapago.Text = clsBuscarBl.Get_FormaCobro(txtFormaPago.Text)
                If lblformapago.Text = String.Empty Then
                    txtFormaPago.Text = ""
                End If
            End If
            If txtcliente.Text = String.Empty Then Exit Sub

            Call Cargar_Direccion_Entrega(txtcliente.Text.Trim)
            If txtvendedor.Text <> String.Empty Then
                clsBuscarBl = New ClsBuscar
                lblvendedor.Text = clsBuscarBl.Get_NombreVendedor(txtvendedor.Text)
                If lblvendedor.Text = String.Empty Then
                    txtvendedor.Text = ""
                End If
            Else
                lblvendedor.Text = ""
            End If
            txtFormaPago.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Clientes_Importar(Optional ByVal _CodigoCliente As String = "")
        Try
            Dim clsBuscarBl As New ClsBuscar
            If _CodigoCliente = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "PED_SP_S_ORDER_CLIENTE"
                frm.CadenaConsulta = sql
                frm.Titulo = "Clientes"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txt_cod_cliente_importar.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txt_razon_social_importar.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txt_ruc_importar.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                    txt_direccion_importar.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                    txt_fp_importar.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                End If
                frm.Close()
            Else
                Dim clsFacturaBl As New ClsOperaciones.RECEIVABLE
                Dim dtDetalleFact As New DataTable("Clientes")
                dtDetalleFact = clsFacturaBl.Get_ManualClientes(_CodigoCliente)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txt_cod_cliente_importar.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txt_razon_social_importar.Text = dtDetalleFact.Rows(0).Item(1).ToString
                    txt_ruc_importar.Text = dtDetalleFact.Rows(0).Item(2).ToString
                    txt_direccion_importar.Text = dtDetalleFact.Rows(0).Item(3).ToString
                    txt_fp_importar.Text = dtDetalleFact.Rows(0).Item(5).ToString
                    'txtvendedor.Text = dtDetalleFact.Rows(0).Item("SALES_ID").ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txt_cod_cliente_importar.Text = String.Empty
                    txt_razon_social_importar.Text = String.Empty
                    txt_ruc_importar.Text = String.Empty
                    txt_direccion_importar.Text = String.Empty
                    txt_fp_importar.Text = String.Empty
                    lb_fp_importar.Text = String.Empty
                    txt_fp_importar.Focus()
                    Exit Sub
                End If
            End If
            If txt_fp_importar.Text = String.Empty Then
                lb_fp_importar.Text = ""
            Else
                clsBuscarBl = New ClsBuscar
                lb_fp_importar.Text = clsBuscarBl.Get_FormaCobro(txt_fp_importar.Text)
                If lb_fp_importar.Text = String.Empty Then
                    txt_fp_importar.Text = ""
                End If
            End If
            If txt_cod_cliente_importar.Text = String.Empty Then Exit Sub

            Call Cargar_Direccion_Entrega_Importar(txt_cod_cliente_importar.Text.Trim)
            
            txt_fp_importar.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Direccion_Entrega(ByVal _codigo_cli As String)
        Dim tipoDocBL As New LibContabilidad.ClsOperaciones.CO_TB_TIPO_DOC_ANE
        Dim CADENA As String
        CADENA = "SELECT A.CUSTOMER_ID,A.ADDR+' '+ISNULL(UBBB.NOMBRE,'')+' '+ISNULL(UBB.NOMBRE,'')+' '+ISNULL(ub.NOMBRE,'') AS DIRECCION_ENTREGA FROM dbo.ADDR_CUSTOMER A LEFT join dbo.ubigeo ub on ub.CODDPTO=A.DEPARTAMENTO_ID AND "
        CADENA = CADENA & " ub.CODPROV=A.PROVINCIA_ID AND ub.CODDIS=A.DISTRITO_ID LEFT join dbo.ubigeo UBB on UBB.CODDPTO=A.DEPARTAMENTO_ID AND UBB.CODPROV=A.PROVINCIA_ID AND UBB.CODDIS='00' LEFT join dbo.ubigeo UBBB on UBBB.CODDPTO=A.DEPARTAMENTO_ID AND UBBB.CODPROV='00' AND UBBB.CODDIS='00' "
        CADENA = CADENA & " WHERE A.CUSTOMER_ID='" & _codigo_cli & "' "
        cbo_direc_entrega.DataSource = Nothing
        cbo_direc_entrega.DataSource = tipoDocBL.get_Direc_entrega(CADENA)
        cbo_direc_entrega.DisplayMember = "DIRECCION_ENTREGA"
        cbo_direc_entrega.ValueMember = "CUSTOMER_ID"
        tipoDocBL = Nothing
    End Sub

    Private Sub Cargar_Direccion_Entrega_Importar(ByVal _codigo_cli As String)
        Dim tipoDocBL As New LibContabilidad.ClsOperaciones.CO_TB_TIPO_DOC_ANE
        Dim CADENA As String
        CADENA = "SELECT A.CUSTOMER_ID,A.ADDR+' '+ISNULL(UBBB.NOMBRE,'')+' '+ISNULL(UBB.NOMBRE,'')+' '+ISNULL(ub.NOMBRE,'') AS DIRECCION_ENTREGA FROM dbo.ADDR_CUSTOMER A LEFT join dbo.ubigeo ub on ub.CODDPTO=A.DEPARTAMENTO_ID AND "
        CADENA = CADENA & " ub.CODPROV=A.PROVINCIA_ID AND ub.CODDIS=A.DISTRITO_ID LEFT join dbo.ubigeo UBB on UBB.CODDPTO=A.DEPARTAMENTO_ID AND UBB.CODPROV=A.PROVINCIA_ID AND UBB.CODDIS='00' LEFT join dbo.ubigeo UBBB on UBBB.CODDPTO=A.DEPARTAMENTO_ID AND UBBB.CODPROV='00' AND UBBB.CODDIS='00' "
        CADENA = CADENA & " WHERE A.CUSTOMER_ID='" & _codigo_cli & "' "
        cbo_dir_entrega_importar.DataSource = Nothing
        cbo_dir_entrega_importar.DataSource = tipoDocBL.get_Direc_entrega(CADENA)
        cbo_dir_entrega_importar.DisplayMember = "DIRECCION_ENTREGA"
        cbo_dir_entrega_importar.ValueMember = "CUSTOMER_ID"
        tipoDocBL = Nothing
    End Sub

    Private Sub txtCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Clientes()
        If e.KeyCode = Keys.Enter Then
            If txtcliente.Text = String.Empty Then
                Ayuda_Clientes()
            Else
                txtFormaPago.Focus() 'Ayuda_Clientes(txtcliente.Text)
            End If
        End If
    End Sub

    Private Sub txtCodCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcliente.MouseDoubleClick
        Ayuda_Clientes()
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
                    txtvendedor.Text = frm.Data_Matriz.Rows(0).Item(0)
                    lblvendedor.Text = frm.Data_Matriz.Rows(0).Item(1)
                End If
                frm.Close()
            Else
                Dim clsFacturaBl As New ClsOperaciones.RECEIVABLE
                Dim dtDetalleVend As New DataTable("Vendedor")
                dtDetalleVend = clsFacturaBl.Get_ManualVendedor(_CodigoVendedor)
                If dtDetalleVend.Rows.Count() <> 0 Then
                    txtvendedor.Text = dtDetalleVend.Rows(0).Item(0).ToString
                    lblvendedor.Text = dtDetalleVend.Rows(0).Item(1).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtvendedor.Text = String.Empty
                    lblvendedor.Text = String.Empty
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvendedor.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Vendedor()
        If e.KeyCode = Keys.Enter Then
            If txtvendedor.Text = String.Empty Then
                Ayuda_Vendedor()
            Else
                txtFormaPago.Focus() ' Ayuda_Vendedor(txtvendedor.Text)
            End If
        End If
    End Sub

    Private Sub txtVendedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtvendedor.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub


    Private Sub cboLotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLotes.SelectedIndexChanged
        If cboLotes.DataSource Is Nothing Then Exit Sub
        If cboLotes.Items.Count() <> 0 Then
            txtStockLote.Text = cboLotes.SelectedValue.ToString
        End If
    End Sub

    Private Sub txttrama_KeyDown(sender As Object, e As KeyEventArgs) Handles txttrama.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtglosa.Select()
        End If
    End Sub


    Private Sub txtcomentario_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtcomentario.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Select()
        End If
    End Sub

    Private Sub cboLotes_KeyDown(sender As Object, e As KeyEventArgs) Handles cboLotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Select()
        End If
    End Sub

    Private Sub txtporc_descuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtporc_descuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcomentario.Select()
        End If
    End Sub

    Private Sub btn_aprobar_Click(sender As Object, e As EventArgs) Handles btn_aprobar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If Modo_consultar = False Then Exit Sub

        Try
            Dim estadoInicial As String = ""
            Dim estadoActualizado As String = ""
            Dim ESTADO As String = ""
            Dim _id As String = String.Empty
            _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            estadoInicial = dgvCabecera.Item(8, dgvCabecera.CurrentRow.Index).Value
            ESTADO = dgvCabecera.Rows(dgvCabecera.CurrentRow.Index).Cells(9).Value

            If estadoInicial = "RECHAZADO" Then
                MessageBox.Show("El pedido se encuentra RECHAZADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf ESTADO = "ANULADO" Then
                MessageBox.Show("El pedido ya se encuentra ANULADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf ESTADO = "FACTURADO" Then
                MessageBox.Show("El pedido ya se encuentra FACTURADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If MessageBox.Show("Se va a cambiar el estado del pedido" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                estadoActualizado = Ayuda_CambioEstado(estadoInicial)
                If String.IsNullOrEmpty(estadoActualizado) Then
                    Exit Sub
                End If
                Dim sql As String = ""
                clsPedidoBl = New ClsOperaciones.ORDERS
                Select Case estadoActualizado
                    Case "02"
                        If MessageBox.Show("Confirmacion de cambio de estado a : APROBADA" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            clsPedidoBl = New ClsOperaciones.ORDERS
                            If clsPedidoBl.Actualiza_Status_Pedido(_id, "APROBADO") = True Then
                                MsgBox("Pedido APROBADA correctamente.", MsgBoxStyle.Information)
                            End If
                        End If
                    Case "03"
                        If MessageBox.Show("Confirmacion de cambio de estado a : RECHAZADO" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            clsPedidoBl = New ClsOperaciones.ORDERS
                            If clsPedidoBl.Actualiza_Status_Pedido(_id, "RECHAZADO") = True Then
                                MsgBox("Pedido RECHAZADO correctamente.", MsgBoxStyle.Information)
                            End If
                        End If

                End Select
                btnCancelar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim STRPedido As String = String.Empty
        STRPedido = dgvCabecera.Rows(dgvCabecera.CurrentRow.Index).Cells(0).Value
        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            clsPedidoBl = New ClsOperaciones.ORDERS
            If clsPedidoBl.Elimina_Pedido(STRPedido) = True Then
                MsgBox("Pedido eliminado correctamente.", MessageBoxIcon.Information, "Sistemas")
            End If
        End If
        btnCancelar_Click(sender, e)
    End Sub

    Private Sub btn_stock_Click(sender As Object, e As EventArgs) Handles btn_stock.Click
        Try
            If txtcodigoArticulo.Text = "" Then Exit Sub
            pnl_stock.Visible = True
            clsPedidoBl = New ClsOperaciones.ORDERS
            Dim dtdetalle_part As New DataTable
            dtdetalle_part = clsPedidoBl.Datos_Stock(txtcodigoArticulo.Text)
            dgv_stock.DataSource = Nothing
            dgv_stock.DataSource = dtdetalle_part
            If dtdetalle_part.Rows.Count() <> 0 Then
                dgv_stock.Columns(0).Width = 50
                dgv_stock.Columns(1).Width = 300
                dgv_stock.Columns(2).Width = 95
                txtcomentario.Select()
            Else
                txtcomentario.Select()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpfechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaInicial.ValueChanged
        DocumentosPedidos()
    End Sub

    Private Sub dtpfechafinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechafinal.ValueChanged
        DocumentosPedidos()
    End Sub

    Private Sub dtp_vencimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_vencimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcliente.Focus()
        End If
    End Sub

    Private Sub txtordencompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtordencompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_centro_costo.Focus()
        End If
    End Sub

    Private Sub txt_centro_costo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_centro_costo.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Centro_Costo(txt_centro_costo, lbl_centro_costo)
        If e.KeyCode = Keys.Enter Then
            If txt_centro_costo.Text = String.Empty Then
                Ayuda_Centro_Costo(txt_centro_costo, lbl_centro_costo)
            Else
                btnAgregar.Focus()
            End If
        End If
    End Sub

    Private Sub txt_centro_costo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_centro_costo.MouseDoubleClick
        Ayuda_Centro_Costo(txt_centro_costo, lbl_centro_costo)
    End Sub
    Private Sub Ayuda_Centro_Costo(ByVal _CAJA_TEXTO As TextBox, ByVal _LABEL As Label)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_CENTRO_COSTO_COMPRAS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centro de Costo"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                _CAJA_TEXTO.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                _LABEL.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                btnAgregar.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtValorunitario.Select()
        End If
    End Sub

    Private Sub txt_centro_costo_detalle_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_centro_costo_detalle.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Centro_Costo(txt_centro_costo_detalle, lbl_centro_costo_detalle)
            txtcantidad.Focus()
        End If
    End Sub

    Private Sub txt_centro_costo_detalle_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_centro_costo_detalle.MouseDoubleClick
        Ayuda_Centro_Costo(txt_centro_costo_detalle, lbl_centro_costo_detalle)
    End Sub

    Private Sub dgvDetalle_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDetalle.CellFormatting
        If Modo_consultar = True Then
            If dgvDetalle.Rows(e.RowIndex).Cells("PRICE_ORI").Value <> dgvDetalle.Rows(e.RowIndex).Cells("PRECIO_LISTA").Value Then
                dgvDetalle.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
                dgvDetalle.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
            Else
                dgvDetalle.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
                dgvDetalle.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub btn_ruta_Click(sender As Object, e As EventArgs) Handles btn_ruta.Click
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        txt_ruta.Text = myFileDialog.FileName.ToString
    End Sub

    Private Sub btn_mostrar_ped_Click(sender As Object, e As EventArgs) Handles btn_mostrar_ped.Click

        If cbo_cliente.SelectedIndex = -1 Then
            MsgBox("Debe elegir una Cliente.", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If

        If txt_ruta.Text.Trim = "" Then
            MsgBox("Debe elegir una Ruta donde se encuentra el archivo.", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If


        If cbo_cliente.SelectedIndex = 0 Then
            Importar_Bienes_Cencosud("cencosud")
        ElseIf cbo_cliente.SelectedIndex = 1 Then
            Importar_Bienes_Spsa("spsa")
        ElseIf cbo_cliente.SelectedIndex = 2 Then
            Importar_Bienes_Tottus("tottus")
        End If


        'txt_ruta.Text = ""

    End Sub

    Private Sub Importar_Bienes_Cencosud(ByVal _nombre_hoja As String)

        Try
            Me.Cursor = Cursors.WaitCursor
            progreso.Visible = True
            dgvdetalles.DataSource = Nothing
            Call importarExcel(dgvdetalles, txt_ruta.Text.Trim, _nombre_hoja)

            progreso.Minimum = 0
            progreso.Maximum = dgvdetalles.Rows.Count()
            If dgvdetalles.Rows.Count > 0 Then
                GenerarColummnaDataTable_Cencosud()
                Dim dtdocumentoPrin As DataTable
                clsPedidoBl = New ClsOperaciones.ORDERS
                For i As Integer = 0 To dgvdetalles.Rows.Count() - 1
                    progreso.Value = i
                    Dim row As DataRow = dtdetalleArticuloPrincipal_cencosud.NewRow
                    row("ITEM") = i + 1
                    row("ORDEN_COMPRA") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(3).Value), "", Strings.Left(Trim(Strings.Right(Trim(dgvdetalles.Rows(i).Cells(3).Value), 11)), 10)) 'oc
                    row("FECHA_EMISION") = Date.Now.ToString("dd/MM/yyyy")
                    row("FECHA_DESPACHO") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(8).Value), "", CDate(dgvdetalles.Rows(i).Cells(8).Value).ToString("dd/MM/yyyy")) 'fecha_Despacho
                    row("EAN13_CLIENTE") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(10).Value), "", dgvdetalles.Rows(i).Cells(10).Value) 'ean 13 del prod del cliente

                    dtdocumentoPrin = New DataTable
                    dtdocumentoPrin = clsPedidoBl.get_DatosProducto_Cencosud(row("EAN13_CLIENTE"))
                    If dtdocumentoPrin.Rows.Count > 0 Then
                        row("PART_ID") = dtdocumentoPrin.Rows(0).Item("part_id").ToString
                        row("PART_DESCRIPTION") = dtdocumentoPrin.Rows(0).Item("part_description").ToString
                        row("UNIT") = dtdocumentoPrin.Rows(0).Item("UNIT").ToString
                    Else
                        row("PART_ID") = ""
                        row("PART_DESCRIPTION") = ""
                        row("UNIT") = ""
                    End If

                    row("CANTIDAD") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(15).Value), 0, CInt(Fix(CDbl(dgvdetalles.Rows(i).Cells(15).Value) / 12)) * (12)) 'cantidad solo multiplos de 12
                    row("PRICE_ORI") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(19).Value), 0, dgvdetalles.Rows(i).Cells(19).Value) 'precio sin igv

                    dtdetalleArticuloPrincipal_cencosud.Rows.Add(row)
                    dtdetalleArticuloPrincipal_cencosud.AcceptChanges()

                    progreso.PerformStep()
                Next

                Dim _contador As Integer = 1
                Dim _oc_anterior As String = ""
                Dim _oc_actual As String = ""
                progreso.Minimum = 0
                progreso.Maximum = dtdetalleArticuloPrincipal_cencosud.Rows.Count()

                
                For j As Integer = 0 To dtdetalleArticuloPrincipal_cencosud.Rows.Count - 1
                    progreso.Value = j
                    Dim row As DataRow = dtdetalleArticuloPrincipal_cencosud.NewRow
                    _oc_actual = dtdetalleArticuloPrincipal_cencosud.Rows(j).Item("ORDEN_COMPRA").ToString
                    If j = 0 Then
                        _oc_anterior = _oc_actual
                        For Each row2 As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM=" & j + 1)
                            dtdetalleArticuloPrincipal_cencosud.BeginInit()
                            row2("ITEM_OC") = _contador
                            dtdetalleArticuloPrincipal_cencosud.EndInit()
                            dtdetalleArticuloPrincipal_cencosud.AcceptChanges()
                        Next
                        
                    Else
                        If _oc_anterior = _oc_actual Then
                            _oc_anterior = _oc_actual
                            For Each row2 As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM=" & j + 1)
                                dtdetalleArticuloPrincipal_cencosud.BeginInit()
                                row2("ITEM_OC") = _contador
                                dtdetalleArticuloPrincipal_cencosud.EndInit()
                                dtdetalleArticuloPrincipal_cencosud.AcceptChanges()
                            Next
                        Else
                            _contador = _contador + 1
                            _oc_anterior = _oc_actual
                            For Each row2 As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM=" & j + 1)
                                dtdetalleArticuloPrincipal_cencosud.BeginInit()
                                row2("ITEM_OC") = _contador
                                dtdetalleArticuloPrincipal_cencosud.EndInit()
                                dtdetalleArticuloPrincipal_cencosud.AcceptChanges()
                            Next
                        End If
                    End If
                    progreso.PerformStep()
                Next
                dgv_detalles_pedidos.DataSource = Nothing
                dgv_detalles_pedidos.DataSource = dtdetalleArticuloPrincipal_cencosud


                dgv_detalles_pedidos.Columns(0).HeaderText = "Item O/C"
                dgv_detalles_pedidos.Columns(1).HeaderText = "Item"
                dgv_detalles_pedidos.Columns(2).HeaderText = "Orden de Compra"
                dgv_detalles_pedidos.Columns(3).HeaderText = "Fecha Emisión"
                dgv_detalles_pedidos.Columns(4).HeaderText = "Fecha Despacho"
                dgv_detalles_pedidos.Columns(5).HeaderText = "EAN 13"
                dgv_detalles_pedidos.Columns(6).HeaderText = "Cod. Producto"
                dgv_detalles_pedidos.Columns(7).HeaderText = "Producto"
                dgv_detalles_pedidos.Columns(8).HeaderText = "Unidad"
                dgv_detalles_pedidos.Columns(9).HeaderText = "Cantidad"
                dgv_detalles_pedidos.Columns(10).HeaderText = "Precio S/IGV"

                dgv_detalles_pedidos.AutoResizeColumns()
                dgv_detalles_pedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgv_detalles_pedidos.Columns(9).DefaultCellStyle.Format = "N2"
                dgv_detalles_pedidos.Columns(10).DefaultCellStyle.Format = "N3"
                dgv_detalles_pedidos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv_detalles_pedidos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                progreso.Value = dgvdetalles.Rows.Count()
            End If
            progreso.Visible = False
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Importar_Bienes_Spsa(ByVal _nombre_hoja As String)

        Try
            Me.Cursor = Cursors.WaitCursor
            progreso.Visible = True
            dgvdetalles.DataSource = Nothing
            Call importarExcel(dgvdetalles, txt_ruta.Text.Trim, _nombre_hoja)

            progreso.Minimum = 0
            progreso.Maximum = dgvdetalles.Rows.Count()
            If dgvdetalles.Rows.Count > 0 Then
                GenerarColummnaDataTable_Spsa()
                Dim dtdocumentoPrin As DataTable
                clsPedidoBl = New ClsOperaciones.ORDERS
                For i As Integer = 0 To dgvdetalles.Rows.Count() - 1
                    progreso.Value = i
                    Dim row As DataRow = dtdetalleArticuloPrincipal_cencosud.NewRow
                    row("ITEM") = i + 1
                    row("ORDEN_COMPRA") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(1).Value), "", dgvdetalles.Rows(i).Cells(1).Value) 'oc
                    row("FECHA_EMISION") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(6).Value), Date.Now.ToString("dd/MM/yyyy"), CDate(dgvdetalles.Rows(i).Cells(6).Value).ToString("dd/MM/yyyy")) 'oc 
                    row("FECHA_DESPACHO") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(7).Value), "", CDate(dgvdetalles.Rows(i).Cells(7).Value).ToString("dd/MM/yyyy")) 'fecha_Despacho
                    row("EAN13_CLIENTE") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(9).Value), "", dgvdetalles.Rows(i).Cells(9).Value) 'ean 13 del prod del cliente
                    dtp_fecha_pedido.Value = row("FECHA_EMISION")
                    dtdocumentoPrin = New DataTable
                    dtdocumentoPrin = clsPedidoBl.get_DatosProducto_Spsa(row("EAN13_CLIENTE"))
                    If dtdocumentoPrin.Rows.Count > 0 Then
                        row("PART_ID") = dtdocumentoPrin.Rows(0).Item("part_id").ToString
                        row("PART_DESCRIPTION") = dtdocumentoPrin.Rows(0).Item("part_description").ToString
                        row("UNIT") = dtdocumentoPrin.Rows(0).Item("UNIT").ToString
                    Else
                        row("PART_ID") = ""
                        row("PART_DESCRIPTION") = ""
                        row("UNIT") = ""
                    End If

                    row("CANTIDAD") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(22).Value), 0, CDbl(dgvdetalles.Rows(i).Cells(22).Value)) 'cantidad solo multiplos de 12
                    row("PRICE_ORI") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(14).Value), 0, dgvdetalles.Rows(i).Cells(14).Value) 'precio sin igv

                    dtdetalleArticuloPrincipal_cencosud.Rows.Add(row)
                    dtdetalleArticuloPrincipal_cencosud.AcceptChanges()

                    progreso.PerformStep()
                Next

                Dim _contador As Integer = 1
                Dim _oc_anterior As String = ""
                Dim _oc_actual As String = ""
                progreso.Minimum = 0
                progreso.Maximum = dtdetalleArticuloPrincipal_cencosud.Rows.Count()


                For j As Integer = 0 To dtdetalleArticuloPrincipal_cencosud.Rows.Count - 1
                    progreso.Value = j
                    Dim row As DataRow = dtdetalleArticuloPrincipal_cencosud.NewRow
                    _oc_actual = dtdetalleArticuloPrincipal_cencosud.Rows(j).Item("ORDEN_COMPRA").ToString
                    If j = 0 Then
                        _oc_anterior = _oc_actual
                        For Each row2 As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM=" & j + 1)
                            dtdetalleArticuloPrincipal_cencosud.BeginInit()
                            row2("ITEM_OC") = _contador
                            dtdetalleArticuloPrincipal_cencosud.EndInit()
                            dtdetalleArticuloPrincipal_cencosud.AcceptChanges()
                        Next

                    Else
                        If _oc_anterior = _oc_actual Then
                            _oc_anterior = _oc_actual
                            For Each row2 As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM=" & j + 1)
                                dtdetalleArticuloPrincipal_cencosud.BeginInit()
                                row2("ITEM_OC") = _contador
                                dtdetalleArticuloPrincipal_cencosud.EndInit()
                                dtdetalleArticuloPrincipal_cencosud.AcceptChanges()
                            Next
                        Else
                            _contador = _contador + 1
                            _oc_anterior = _oc_actual
                            For Each row2 As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM=" & j + 1)
                                dtdetalleArticuloPrincipal_cencosud.BeginInit()
                                row2("ITEM_OC") = _contador
                                dtdetalleArticuloPrincipal_cencosud.EndInit()
                                dtdetalleArticuloPrincipal_cencosud.AcceptChanges()
                            Next
                        End If
                    End If
                    progreso.PerformStep()
                Next
                dgv_detalles_pedidos.DataSource = Nothing
                dgv_detalles_pedidos.DataSource = dtdetalleArticuloPrincipal_cencosud


                dgv_detalles_pedidos.Columns(0).HeaderText = "Item O/C"
                dgv_detalles_pedidos.Columns(1).HeaderText = "Item"
                dgv_detalles_pedidos.Columns(2).HeaderText = "Orden de Compra"
                dgv_detalles_pedidos.Columns(3).HeaderText = "Fecha Emisión"
                dgv_detalles_pedidos.Columns(4).HeaderText = "Fecha Despacho"
                dgv_detalles_pedidos.Columns(5).HeaderText = "EAN 13"
                dgv_detalles_pedidos.Columns(6).HeaderText = "Cod. Producto"
                dgv_detalles_pedidos.Columns(7).HeaderText = "Producto"
                dgv_detalles_pedidos.Columns(8).HeaderText = "Unidad"
                dgv_detalles_pedidos.Columns(9).HeaderText = "Cantidad"
                dgv_detalles_pedidos.Columns(10).HeaderText = "Precio S/IGV"

                dgv_detalles_pedidos.AutoResizeColumns()
                dgv_detalles_pedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgv_detalles_pedidos.Columns(9).DefaultCellStyle.Format = "N2"
                dgv_detalles_pedidos.Columns(10).DefaultCellStyle.Format = "N3"
                dgv_detalles_pedidos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv_detalles_pedidos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                progreso.Value = dgvdetalles.Rows.Count()
            End If
            progreso.Visible = False
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Importar_Bienes_Tottus(ByVal _nombre_hoja As String)

        Try
            Me.Cursor = Cursors.WaitCursor
            progreso.Visible = True
            dgvdetalles.DataSource = Nothing
            Call importarExcel(dgvdetalles, txt_ruta.Text.Trim, _nombre_hoja)

            progreso.Minimum = 0
            progreso.Maximum = dgvdetalles.Rows.Count()
            If dgvdetalles.Rows.Count > 0 Then
                GenerarColummnaDataTable_Cencosud()
                Dim dtdocumentoPrin As DataTable
                clsPedidoBl = New ClsOperaciones.ORDERS
                For i As Integer = 0 To dgvdetalles.Rows.Count() - 1
                    progreso.Value = i
                    Dim row As DataRow = dtdetalleArticuloPrincipal_cencosud.NewRow
                    row("ITEM") = i + 1
                    row("ORDEN_COMPRA") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(8).Value), "", dgvdetalles.Rows(i).Cells(8).Value) 'oc
                    row("FECHA_EMISION") = Date.Now.ToString("dd/MM/yyyy")
                    row("FECHA_DESPACHO") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(9).Value), "", CDate(dgvdetalles.Rows(i).Cells(9).Value).ToString("dd/MM/yyyy")) 'fecha_Despacho
                    row("EAN13_CLIENTE") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(0).Value), "", dgvdetalles.Rows(i).Cells(0).Value) 'ean 13 del prod del cliente

                    dtdocumentoPrin = New DataTable
                    dtdocumentoPrin = clsPedidoBl.get_DatosProducto_Tottus(row("EAN13_CLIENTE"))
                    If dtdocumentoPrin.Rows.Count > 0 Then
                        row("PART_ID") = dtdocumentoPrin.Rows(0).Item("part_id").ToString
                        row("PART_DESCRIPTION") = dtdocumentoPrin.Rows(0).Item("part_description").ToString
                        row("UNIT") = dtdocumentoPrin.Rows(0).Item("UNIT").ToString
                    Else
                        row("PART_ID") = ""
                        row("PART_DESCRIPTION") = ""
                        row("UNIT") = ""
                    End If

                    If row("PART_ID") = "414000110" Then
                        row("CANTIDAD") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(3).Value), 0, CInt(Fix(CDbl(dgvdetalles.Rows(i).Cells(3).Value) / 50)) * (50)) 'cantidad solo multiplos de 12
                    ElseIf row("PART_ID") <> "414000110" Then
                        row("CANTIDAD") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(3).Value), 0, CInt(Fix(CDbl(dgvdetalles.Rows(i).Cells(3).Value) / 12)) * (12)) 'cantidad solo multiplos de 12
                    End If

                    row("PRICE_ORI") = IIf(IsDBNull(dgvdetalles.Rows(i).Cells(6).Value), 0, CDbl(dgvdetalles.Rows(i).Cells(6).Value)) 'precio sin igv

                    dtdetalleArticuloPrincipal_cencosud.Rows.Add(row)
                    dtdetalleArticuloPrincipal_cencosud.AcceptChanges()

                    progreso.PerformStep()
                Next

                Dim _contador As Integer = 1
                Dim _oc_anterior As String = ""
                Dim _oc_actual As String = ""
                progreso.Minimum = 0
                progreso.Maximum = dtdetalleArticuloPrincipal_cencosud.Rows.Count()


                For j As Integer = 0 To dtdetalleArticuloPrincipal_cencosud.Rows.Count - 1
                    progreso.Value = j
                    Dim row As DataRow = dtdetalleArticuloPrincipal_cencosud.NewRow
                    _oc_actual = dtdetalleArticuloPrincipal_cencosud.Rows(j).Item("ORDEN_COMPRA").ToString
                    If j = 0 Then
                        _oc_anterior = _oc_actual
                        For Each row2 As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM=" & j + 1)
                            dtdetalleArticuloPrincipal_cencosud.BeginInit()
                            row2("ITEM_OC") = _contador
                            dtdetalleArticuloPrincipal_cencosud.EndInit()
                            dtdetalleArticuloPrincipal_cencosud.AcceptChanges()
                        Next

                    Else
                        If _oc_anterior = _oc_actual Then
                            _oc_anterior = _oc_actual
                            For Each row2 As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM=" & j + 1)
                                dtdetalleArticuloPrincipal_cencosud.BeginInit()
                                row2("ITEM_OC") = _contador
                                dtdetalleArticuloPrincipal_cencosud.EndInit()
                                dtdetalleArticuloPrincipal_cencosud.AcceptChanges()
                            Next
                        Else
                            _contador = _contador + 1
                            _oc_anterior = _oc_actual
                            For Each row2 As DataRow In dtdetalleArticuloPrincipal_cencosud.Select("ITEM=" & j + 1)
                                dtdetalleArticuloPrincipal_cencosud.BeginInit()
                                row2("ITEM_OC") = _contador
                                dtdetalleArticuloPrincipal_cencosud.EndInit()
                                dtdetalleArticuloPrincipal_cencosud.AcceptChanges()
                            Next
                        End If
                    End If
                    progreso.PerformStep()
                Next
                dgv_detalles_pedidos.DataSource = Nothing
                dgv_detalles_pedidos.DataSource = dtdetalleArticuloPrincipal_cencosud


                dgv_detalles_pedidos.Columns(0).HeaderText = "Item O/C"
                dgv_detalles_pedidos.Columns(1).HeaderText = "Item"
                dgv_detalles_pedidos.Columns(2).HeaderText = "Orden de Compra"
                dgv_detalles_pedidos.Columns(3).HeaderText = "Fecha Emisión"
                dgv_detalles_pedidos.Columns(4).HeaderText = "Fecha Despacho"
                dgv_detalles_pedidos.Columns(5).HeaderText = "SKU"
                dgv_detalles_pedidos.Columns(6).HeaderText = "Cod. Producto"
                dgv_detalles_pedidos.Columns(7).HeaderText = "Producto"
                dgv_detalles_pedidos.Columns(8).HeaderText = "Unidad"
                dgv_detalles_pedidos.Columns(9).HeaderText = "Cantidad"
                dgv_detalles_pedidos.Columns(10).HeaderText = "Precio S/IGV"

                dgv_detalles_pedidos.AutoResizeColumns()
                dgv_detalles_pedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgv_detalles_pedidos.Columns(9).DefaultCellStyle.Format = "N2"
                dgv_detalles_pedidos.Columns(10).DefaultCellStyle.Format = "N3"
                dgv_detalles_pedidos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv_detalles_pedidos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                progreso.Value = dgvdetalles.Rows.Count()
            End If
            progreso.Visible = False
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub
   
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btn_importar_pedidos.Click
        cbo_cliente.SelectedIndex = -1
        txt_ruta.Text = ""
        btn_menu.Enabled = False
        dgv_detalles_pedidos.DataSource = Nothing
        txt_cod_cliente_importar.Text = ""
        txt_razon_social_importar.Text = ""
        txt_ruc_importar.Text = ""
        txt_direccion_importar.Text = ""
        cbo_dir_entrega_importar.DataSource = Nothing
        txt_fp_importar.Text = ""
        txt_cc_importar.Text = ""
        lb_fp_importar.Text = ""
        lb_cc_importar.Text = ""

        'pnlCabecera.Enabled = False
        dtp_fecha_pedido.Value = LibComunVar.ClsVarComun.FechaSistema
        txt_tc_importar.Text = LibComunVar.ClsVarComun.TCVenta
        Panel1.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbo_cliente.SelectedIndex = -1
        txt_ruta.Text = ""
        btn_menu.Enabled = True
        'pnlCabecera.Enabled = True
        Panel1.Visible = False
    End Sub

    Private Sub btn_importar_ped_Click(sender As Object, e As EventArgs) Handles btn_importar_ped.Click
        If dgv_detalles_pedidos.Rows.Count() = 0 Then Exit Sub
        If dgv_detalles_pedidos.CurrentRow Is Nothing Then Exit Sub

        If cbo_cliente.SelectedIndex = 0 Then
            Guardar_Pedido_Cencosud()
        ElseIf cbo_cliente.SelectedIndex = 1 Then
            Guardar_Pedido_Spsa()
        ElseIf cbo_cliente.SelectedIndex = 2 Then
            Guardar_Pedido_Tottus()
        End If
        Button1_Click(sender, e)
        DocumentosPedidos()
    End Sub

    Private Sub txt_cod_cliente_importar_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_cliente_importar.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Clientes_Importar()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_cliente_importar.Text = String.Empty Then
                Ayuda_Clientes_Importar()
            Else
                Ayuda_Clientes_Importar(txt_cod_cliente_importar.Text)
            End If
        End If
    End Sub

    Private Sub txt_cod_cliente_importar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_cliente_importar.MouseDoubleClick
        Ayuda_Clientes_Importar()
    End Sub

    Private Sub txt_fp_importar_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fp_importar.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_FormaPago_Importar()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_fp_importar.Text = "" Then
                Ayuda_FormaPago_Importar()
            Else
                txt_cc_importar.Focus()
            End If
        End If
    End Sub

    Private Sub txt_fp_importar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_fp_importar.MouseDoubleClick
        Ayuda_FormaPago_Importar()
    End Sub

    Private Sub txt_cc_importar_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cc_importar.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Centro_Costo(txt_cc_importar, lb_cc_importar)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cc_importar.Text = "" Then
                Ayuda_Centro_Costo(txt_cc_importar, lb_cc_importar)
            Else
                dtp_fecha_pedido.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_fecha_pedido_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_pedido.ValueChanged
        validar_Fecha()
    End Sub
    Public Sub validar_Fecha()
        Dim FechaIngr As Date
        FechaIngr = dtp_fecha_pedido.Value
        Dim facturacionBl As New ClsOperaciones.RECEIVABLE
        Dim dtFecha As New DataTable("TipoCambioFecha")
        Dim Sql = String.Empty
        Sql = "SELECT ISNULL(SELL_RATE,0) [SELL_RATE] FROM CURRENCY_EXCHANGE WHERE CURRENCY_DATE='" & FechaIngr.ToShortDateString & "'"
        dtFecha = facturacionBl.Muestra_consulta(Sql)
        If dtFecha.Rows.Count() <> 0 Then
            txtTipoCambio.Text = CDbl(dtFecha.Rows(0).Item("SELL_RATE"))
            txttipoCambio.Text = Format(CDbl(txttipoCambio.Text), "##,##0.000")
            cbo_moneda_importar.Focus()
        Else
            MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
            txttipoCambio.Text = String.Empty
            cbo_moneda_importar.Focus()
        End If
    End Sub

    Private Sub dtp_fecha_pedido_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_pedido.KeyDown
        If e.KeyCode = Keys.Enter Then
            validar_Fecha()
        End If
    End Sub

    Private Sub txt_cc_importar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cc_importar.MouseDoubleClick
        Ayuda_Centro_Costo(txt_cc_importar, lb_cc_importar)
    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("Estado.Facturacion").Value = "ANULADO" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub btn_cotizacion_Click(sender As Object, e As EventArgs) Handles btn_cotizacion.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim _Id As String = String.Empty
        _Id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        imprimir_Cotizacion(_Id)
    End Sub

    Private Sub imprimir_Cotizacion(ByVal _Codigo As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Pedidos")
            Dim dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReportePedidos(_Codigo)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Impresion_Cotizacion.rpt", dtImprimir, "", "", "@ID;" & _Codigo, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
