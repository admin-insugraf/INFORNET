Public Class Frm_Orden_Compra

    Public _NRO_OF As String = String.Empty


    Dim Modo_consultar As Boolean = False
    Dim OrdenCompraCabENT As ClsEntidades.PURCHASE_ORDER
    Dim OrdenCompraDetENT As ClsEntidades.PURCHASE_ORDER_LINE
    Dim ListaDetalles As List(Of ClsEntidades.PURCHASE_ORDER_LINE)

    Dim OrdenCompraBl As ClsOperaciones.PURCHASE_ORDER

    Dim CORRELATIVOBL As ClsTransacciones.PURCHASE_ORDER
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

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
    Public _valor_igv As Double


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable("Detalles_Orden_Compra")
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT_REFERENCE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("FACTOR_REFERENCE", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRICE", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DISCOUNT_PER", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DISCOUNT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT_TAX", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PERCENT_TAX", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRICE_NET", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AMOUNT_TOTAL_NET", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY_ENTER", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY_OUT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("STATUS_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("COMMENT1", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("TEXT_COMMENT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("IS_VAT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PRICE_UNIT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("CCOST_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PROJECT_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("AREA_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("COTI_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("REQUI_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("FLAG_FREE_IGV", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT_PROVEEDOR", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("EQUIVALENCIA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY_PROVEEDOR", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("CECOS", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CECOS_DES", Type.GetType("System.String"))
            'dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
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

            For i As Integer = 15 To 24
                dgvDetalle.Columns(i).Visible = False
            Next

            For j As Integer = 6 To 16
                dgvDetalle.Columns(j).DefaultCellStyle.Format = "N2" ' "##,##0.00"
                dgvDetalle.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
            dgvDetalle.Columns(25).HeaderText = "Nro.Cotizacion"
            dgvDetalle.Columns(26).HeaderText = "Nro.Requisicion"
            dgvDetalle.Columns("CECOS").HeaderText = "Codigo Centro de Costo"
            dgvDetalle.Columns("CECOS_DES").HeaderText = "Centro de Costo"

            dgvDetalle.Columns(4).Visible = False
            dgvDetalle.Columns(5).Visible = False
            dgvDetalle.Columns(11).Visible = False
            dgvDetalle.Columns(13).Visible = False
            dgvDetalle.Columns(25).Visible = True
            dgvDetalle.Columns(26).Visible = True
            dgvDetalle.Columns(27).Visible = False
            dgvDetalle.Columns(28).Visible = False
            dgvDetalle.Columns(29).Visible = False
            dgvDetalle.Columns(30).Visible = False

            dgvDetalle.Columns("CECOS").Visible = True
            dgvDetalle.Columns("CECOS_DES").Visible = True
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            'If Modo_Edicion = True Then
            '    btnGrabar.Enabled = False
            'Else
            btnGrabar.Enabled = True
            'End If
            btnEliminar.Enabled = False
            btn_anular.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btn_anular.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
        End If
    End Sub

    Private Sub DetalleInicialOrdenCompras()
        Try
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            dtResultados = New DataTable("Detalles_iniciales")
            GenerarColummnaDataTable()
            Dim _CONSULTA As String = String.Empty
            _CONSULTA = "SELECT PART_FORM, PART_FORM_EE  FROM  ORDER_PRODUCTION_LINE  WHERE ID= '" & _NRO_OF & "'"
            dtResultados = OrdenCompraBl.Consultas_Generales(_CONSULTA)
            If dtResultados.Rows.Count() <> 0 Then
                OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
                dtdetalleArticuloPrincipal = OrdenCompraBl.DetalleInicialOrdenCompras(dtResultados.Rows(0).Item("PART_FORM").ToString, dtResultados.Rows(0).Item("PART_FORM_EE").ToString)
                ConfigurarGrila()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DocumentosOrdenCompra()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            Dim sTipoOrden As String = String.Empty
            sTipoOrden = "OC"
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            Dim dtDocumentos As New DataTable
            dtv = New DataView
            dtDocumentos = OrdenCompraBl.Mostrar_Documentos_Principal(sTipoOrden, dtpfechaInicial.Value.ToString("dd/MM/yyyy"), CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")), IIf(cboopcionesBusqueda.SelectedIndex = 0, "TODOS", (IIf(cboopcionesBusqueda.SelectedIndex = 1, "MES", "RANGO"))))
            'dtDocumentos.Columns.Add("Imprimir Requisicion", Type.GetType("System.Boolean"))
            dtv = dtDocumentos.DefaultView
            'dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvCabecera.Columns(4).Visible = False
                dgvCabecera.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(8).DefaultCellStyle.Format = "##,##0.00"
                'dgvCabecera.Columns(0).HeaderText = "Numero"
                'dgvCabecera.Columns(1).HeaderText = "Fecha"
                'dgvCabecera.Columns(2).HeaderText = "Codigo"
                'dgvCabecera.Columns(3).HeaderText = "Proveedor"
                'dgvCabecera.Columns(4).HeaderText = "Ruc"
                'dgvCabecera.Columns(6).HeaderText = "Total"
                'dgvCabecera.Columns(7).HeaderText = "Moneda"
                'dgvCabecera.Columns(8).HeaderText = "Estado"

                For i As Integer = 0 To dgvCabecera.Columns.Count - 1
                    dgvCabecera.Columns(i).ReadOnly = True
                Next
                'dgvCabecera.Columns(9).ReadOnly = False

                STRorden = dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(5).Name & "+" & dgvCabecera.Columns(6).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub DataGridView1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dgvCabecera.Paint
    '    ' Datos para las celdas de cabezera 
    '    Dim Grupos As String() = {"A", "GRUPO 2", ""}
    '    For j As Integer = 0 To dgvCabecera.ColumnCount - 1 Step 2
    '        ' Obtener los límites de encabezado de columna 
    '        Dim r1 As Rectangle = dgvCabecera.GetCellDisplayRectangle(j, -1, True)
    '        r1.X += 1
    '        r1.Y += 1
    '        r1.Width = r1.Width * 2 - 2
    '        r1.Height = r1.Height / 2 - 2

    '        Using br As SolidBrush = _
    '          New SolidBrush(dgvCabecera.ColumnHeadersDefaultCellStyle.BackColor)
    '            e.Graphics.FillRectangle(br, r1)
    '        End Using
    '        Using p As Pen = New Pen(SystemColors.InactiveBorder)
    '            e.Graphics.DrawLine(p, r1.X, r1.Bottom, r1.Right, r1.Bottom)
    '        End Using
    '        Using format As StringFormat = New StringFormat()
    '            Using br As SolidBrush = New SolidBrush(dgvCabecera.ColumnHeadersDefaultCellStyle.ForeColor)
    '                format.Alignment = StringAlignment.Center
    '                format.LineAlignment = StringAlignment.Center

    '                e.Graphics.DrawString(Grupos(j / 2), dgvCabecera.ColumnHeadersDefaultCellStyle.Font, _
    '                            br, r1, format)
    '            End Using
    '        End Using
    '    Next
    'End Sub

    'Private Sub DataGridView1_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvCabecera.CellPainting
    '    If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
    '        e.PaintBackground(e.CellBounds, False)
    '        Dim r2 As Rectangle = e.CellBounds
    '        r2.Y += e.CellBounds.Height / 2
    '        r2.Height = e.CellBounds.Height / 2
    '        e.PaintContent(r2)
    '        e.Handled = True
    '    End If
    'End Sub


    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "CODIGO"
        cbomoneda.DisplayMember = "DESCRIPCION"

        cbo_prioridad.DataSource = monedaBL.get_Prioridad_Pedido()
        cbo_prioridad.ValueMember = "CODIGO"
        cbo_prioridad.DisplayMember = "DESCRIPCION"

        cbo_tipo_entrega.DataSource = monedaBL.get_Tipo_Entrega_Pedido()
        cbo_tipo_entrega.ValueMember = "CODIGO"
        cbo_tipo_entrega.DisplayMember = "DESCRIPCION"

        cbo_modo_entrega.DataSource = monedaBL.get_Modo_Entrega_Pedido()
        cbo_modo_entrega.ValueMember = "CODIGO"
        cbo_modo_entrega.DisplayMember = "DESCRIPCION"

        monedaBL = Nothing
    End Sub

    Private Sub Cargar_Porcen_IGV()
        Dim POR_IGVBL As New ClsOperaciones.CURRENCY_TYPE
        Dim DT_IGV As New DataTable
        DT_IGV = POR_IGVBL.get_Porcentaje_IGV()
        If DT_IGV.Rows.Count > 0 Then
            _valor_igv = CDbl(DT_IGV.Rows(0).Item("NUMERIC_TYPE"))
        Else
            _valor_igv = 0
        End If
        POR_IGVBL = Nothing
    End Sub



    Private Function TasaIgvEstandar() As Double
        Dim tasa As Double = 0.0
        Try
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            Dim dtSistema As New DataTable("IGV_SISTEMA")
            dtSistema = OrdenCompraBl.Get_DatosIgvsSistema()
            tasa = CDbl(dtSistema.Rows(0).Item("AMOUNT_TAX"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tasa
    End Function

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


    Private Sub FrmManufactura_Formulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        Cargar_Moneda()
        Cargar_Porcen_IGV()
        GenerarColummnaDataTable()
        btnEliminar.Enabled = NIVEL_ACCESO()
    End Sub

    'Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    DocumentosOrdenCompra()
    'End Sub

    Private Sub Limpiar()
        txtcodigo.Text = String.Empty
        dtpemision.Value = Date.Now
        txtestado.Text = String.Empty
        txtproveedor.Text = String.Empty
        txtproveedor_razons.Text = String.Empty
        txtproveedor_ruc.Text = String.Empty
        dtpEntrega.Value = Date.Now
        dtp_fecha_ingreso_oi.Value = Date.Now
        chkfecha_entrega.Checked = False
        cbomoneda.SelectedIndex = 0
        txttipoCambio.Text = LibComunVar.ClsVarComun.TCVenta
        txtFormaPago.Text = String.Empty
        txtcotizacion.Text = String.Empty
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
        TXTFLETE.Text = "0.00"
        dgvDetalle.DataSource = Nothing
        txtSolicitante.Text = ""
        txtresponsable.Text = ""
        lblformapago.Text = ""
        lblsolicitante.Text = ""
        lblresponsable.Text = ""
        dtdetalleArticuloPrincipal.Rows.Clear()
        btn_desaprobar.Visible = False
        btn_aprobar.Visible = False
        chkfecha_entrega.Checked = False
        dtpEntrega.Enabled = False
        chkflesinigv.Checked = False
        chk_para_importacion.Checked = False
        txt_numero_doc_importacion.Text = ""

        cbo_prioridad.SelectedIndex = -1
        cbo_tipo_entrega.SelectedIndex = -1
        cbo_modo_entrega.SelectedIndex = -1
    End Sub

    Private Sub Nuevo()
        Try
            Limpiar()
            ConfigurarGrila()
            Modo_consultar = False
            CONTROLES(True, 0)
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            gbcabecera.Enabled = True
            cbomoneda.Enabled = True
            If Modo_consultar = False Then
                txtcodigo.Enabled = True
                txtproveedor.Enabled = True
                cbomoneda.Enabled = True
                gbOpciones.Enabled = True
            End If
            txtcodigo.Text = Numeracion()
            txtproveedor.Focus()
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            dtResultados = New DataTable
            Dim sql As String = String.Empty
            sql = "SELECT ADDRESS1 [ADDR] , REPORT_SCREEN , VAT_REGISTRATION   FROM COMPANY "
            dtResultados = OrdenCompraBl.Consultas_Generales(sql)
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
            ' DetalleInicialOrdenCompras()
            _TipoAnexoDoc = ""
            _NumeroTipoAnexoDoc = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.PURCHASE_ORDER
            CORRELATIVOBL.Get_NumeroCorrelativoOrdenCompraII("OC")
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = String.Format("{0:0000000000000}", 1)
            Else
                Correlativo = String.Format("{0:0000000000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Function ConsultandoDocumentos() As Boolean
        Modo_consultar = True
        Call Botonera_Estado_Cambiar(True)
        CONTROLES(True, 0)
        pnlCabecera.Visible = False
        Try
            Dim _id As String = String.Empty
            Dim _IGV_FLETE As String
            _id = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            Dim dtCabeceraoC As New DataTable
            dtCabeceraoC = OrdenCompraBl.Modo_Edicion_Cabecera(_id)
            If dtCabeceraoC.Rows.Count() <> 0 Then
                txtcodigo.Text = dtCabeceraoC.Rows(0).Item(0).ToString
                dtpemision.Value = dtCabeceraoC.Rows(0).Item("DOCUMENT_DATE").ToString
                txtestado.Text = dtCabeceraoC.Rows(0).Item("STATUS_ID").ToString
                'If txtestado.Text = "05" Or txtestado.Text = "02" Then
                If txtestado.Text <> "01" Then
                    gbOpciones.Enabled = False
                    btnGrabar.Enabled = False
                Else
                    gbOpciones.Enabled = True
                End If
                If dtCabeceraoC.Rows(0).Item("ORDEN_PARA_IMPORTACION").ToString = "SI" Then
                    chk_para_importacion.Checked = True
                    dtp_fecha_ingreso_oi.Value = dtCabeceraoC.Rows(0).Item("FECHA_INGRESO_IMPORTACION").ToString
                Else
                    chk_para_importacion.Checked = False
                    dtp_fecha_ingreso_oi.Value = Date.Now
                End If
                txt_numero_doc_importacion.Text = dtCabeceraoC.Rows(0).Item("NUMERO_DOC_IMPORTACION").ToString

                If dtCabeceraoC.Rows(0).Item("PRIORIDAD").ToString = "" Then
                    cbo_prioridad.SelectedIndex = -1
                Else
                    cbo_prioridad.Text = dtCabeceraoC.Rows(0).Item("PRIORIDAD").ToString
                End If

                If dtCabeceraoC.Rows(0).Item("TIPO_ENTREGA").ToString = "" Then
                    cbo_tipo_entrega.SelectedIndex = -1
                Else
                    cbo_tipo_entrega.Text = dtCabeceraoC.Rows(0).Item("TIPO_ENTREGA").ToString
                End If

                If dtCabeceraoC.Rows(0).Item("MODO_ENTREGA").ToString = "" Then
                    cbo_modo_entrega.SelectedIndex = -1
                Else
                    cbo_modo_entrega.Text = dtCabeceraoC.Rows(0).Item("MODO_ENTREGA").ToString
                End If


                txtproveedor.Text = dtCabeceraoC.Rows(0).Item("VENDOR_ID").ToString
                txtproveedor_razons.Text = dtCabeceraoC.Rows(0).Item("NAME").ToString
                txtproveedor_ruc.Text = dtCabeceraoC.Rows(0).Item("VAT_REGISTRATION").ToString
                dtpEntrega.Value = dtCabeceraoC.Rows(0).Item("PROMISE_DATE").ToString
                cbomoneda.SelectedValue = dtCabeceraoC.Rows(0).Item("CURRENCY_TYPE").ToString
                txttipoCambio.Text = dtCabeceraoC.Rows(0).Item("SELL_RATE").ToString
                txtFormaPago.Text = dtCabeceraoC.Rows(0).Item("COD_PAGO").ToString
                lblformapago.Text = dtCabeceraoC.Rows(0).Item("TERMS_NAME").ToString
                txtcotizacion.Text = dtCabeceraoC.Rows(0).Item("NUMBER_ESTIMATING").ToString
                txtentrega.Text = dtCabeceraoC.Rows(0).Item("ADDR_DLV").ToString
                txtnombreFacturar.Text = dtCabeceraoC.Rows(0).Item("NAME_FACT").ToString
                txtdireccionFacturar.Text = dtCabeceraoC.Rows(0).Item("ADDR_FACT").ToString
                txtrucfacturar.Text = dtCabeceraoC.Rows(0).Item("VAT_REGISTRATION_FACT").ToString
                txtComentario.Text = dtCabeceraoC.Rows(0).Item("COMMENT").ToString
                txtSolicitante.Text = dtCabeceraoC.Rows(0).Item("AUTORIZED_ID").ToString
                lblsolicitante.Text = dtCabeceraoC.Rows(0).Item("SOLICITANTE").ToString
                txtresponsable.Text = dtCabeceraoC.Rows(0).Item("BUYER_PURCHASE_ID").ToString
                lblresponsable.Text = dtCabeceraoC.Rows(0).Item("RESPONSABLE").ToString
                TXTFLETE.Text = dtCabeceraoC.Rows(0).Item("AMOUNT_FLETE").ToString
                chkfecha_entrega.Checked = IIf(dtCabeceraoC.Rows(0).Item("FLAG_PROMISE_DATE").ToString = "0", False, True)
                dtpEntrega.Enabled = IIf(chkfecha_entrega.Checked, True, False)
                _IGV_FLETE = IIf(IsDBNull(dtCabeceraoC.Rows(0).Item("FLAG_FLETE_IGV").ToString), 0, dtCabeceraoC.Rows(0).Item("FLAG_FLETE_IGV").ToString)
                If Val(_IGV_FLETE) = 1 Or _IGV_FLETE = "" Then
                    chkflesinigv.Checked = False
                ElseIf Val(_IGV_FLETE) = 0 Then
                    chkflesinigv.Checked = True
                End If

                ''Detalle
                OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
                ' GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = OrdenCompraBl.Modo_Edicion_Detalle(_id)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    ConfigurarGrila()
                    CalcularTotales()
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        ConsultandoDocumentos()
    End Sub

    Private Function Guardar_Orden_Compra() As Boolean
        Try
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            OrdenCompraCabENT = New ClsEntidades.PURCHASE_ORDER
            ListaDetalles = New List(Of ClsEntidades.PURCHASE_ORDER_LINE)

            If Modo_consultar = True Then
                OrdenCompraCabENT.ID = txtcodigo.Text
            Else
                Dim _CORRELATIVO As String = Numeracion()
                OrdenCompraCabENT.ID = _CORRELATIVO
            End If
            With OrdenCompraCabENT
                .TYPE = "OC"
                .DOCUMENT_DATE = dtpemision.Value.ToString("dd/MM/yyyy")
                .VENDOR_ID = txtproveedor.Text
                .NUMBER_ESTIMATING = txtcotizacion.Text
                .CURRENCY_TYPE = cbomoneda.SelectedValue.ToString
                .TERMS_NAME = lblformapago.Text
                .SELL_RATE = IIf(txttipoCambio.Text = "", 0, txttipoCambio.Text)
                .PROMISE_DATE = dtpEntrega.Value.ToString("dd/MM/yyyy")
                .COMMENT = txtComentario.Text
                .AUTORIZED_ID = txtSolicitante.Text
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
                .ADDR_FACT = txtdireccionFacturar.Text
                .REFER_DOCUMENT_TYPE = ""
                .REFER_DOCUMENT_NUMBER = ""
                .PROJECT_ID = ""
                .FLAG_PROMISE_DATE = IIf(chkfecha_entrega.Checked, "1", "0")
                .AMOUNT_FLETE = Val(TXTFLETE.Text)
                .FLAG_FLETE_IGV = IIf(chkflesinigv.Checked = True, 0, 1)
                If chk_para_importacion.Checked = True Then
                    .ORDEN_PARA_IMPORTACION = "SI"
                    .FECHA_INGRESO_IMPORTACION = dtp_fecha_ingreso_oi.Value.ToString("dd/MM/yyyy")
                Else
                    .ORDEN_PARA_IMPORTACION = "NO"
                    .FECHA_INGRESO_IMPORTACION = ""
                End If
                .NUMERO_DOC_IMPORTACION = txt_numero_doc_importacion.Text
                .PRIORIDAD = cbo_prioridad.Text
                .TIPO_ENTREGA = cbo_tipo_entrega.Text
                .MODO_ENTREGA = cbo_modo_entrega.Text
            End With
            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                OrdenCompraDetENT = New ClsEntidades.PURCHASE_ORDER_LINE
                With OrdenCompraDetENT
                    .ID = OrdenCompraCabENT.ID
                    .TYPE = "OC"
                    .ITEM = item("ITEM")
                    .PART_ID = item("PART_ID")
                    .PART_DESCRIPTION = item("DESCRIPTION")
                    .UNIT = item("UNIT")
                    .UNIT_REFERENCE = item("UNIT_REFERENCE")
                    .FACTOR_REFERENCE = item("FACTOR_REFERENCE")
                    .QTY = item("QTY")
                    .PRICE = item("PRICE")
                    .DISCOUNT_PER = item("DISCOUNT_PER")
                    .DISCOUNT = item("DISCOUNT")
                    .AMOUNT_TAX = item("AMOUNT_TAX")
                    .PERCENT_TAX = item("PERCENT_TAX")
                    .PRICE_NET = item("PRICE_NET")
                    .AMOUNT_TOTAL = item("AMOUNT_TOTAL")
                    .AMOUNT_TOTAL_NET = item("AMOUNT_TOTAL_NET")
                    .QTY_ENTER = .QTY
                    .QTY_OUT = .QTY
                    .STATUS_ID = "01"
                    .COMMENT1 = item("COMMENT1")
                    .TEXT_COMMENT = item("TEXT_COMMENT")
                    .IS_VAT = item("IS_VAT")
                    .PRICE_UNIT = item("PRICE_UNIT")
                    .CCOST_ID = "" 'item("CCOST_ID")
                    .PROJECT_ID = IIf(String.IsNullOrEmpty(item("PROJECT_ID").ToString), "", item("PROJECT_ID"))
                    .AREA_ID = IIf(String.IsNullOrEmpty(item("AREA_ID").ToString), "", item("AREA_ID"))
                    .COTI_ID = IIf(String.IsNullOrEmpty(item("COTI_ID").ToString), "", item("COTI_ID"))
                    .REQUI_ID = IIf(String.IsNullOrEmpty(item("REQUI_ID").ToString), "", item("REQUI_ID"))
                    .FLAG_FREE_IGV = IIf(String.IsNullOrEmpty(item("FLAG_FREE_IGV").ToString), 0, CInt(item("FLAG_FREE_IGV")))
                    .QTY_ORIGINAL = item("QTY_PROVEEDOR")
                    .EQUIVALENCIA = item("EQUIVALENCIA")
                    .UNIT_PROVEEDOR = item("UNIT_PROVEEDOR")
                    .CECOS = item("CECOS")
                End With
                ListaDetalles.Add(OrdenCompraDetENT)
            Next
            If OrdenCompraBl.GuardarOrdenCompra(OrdenCompraCabENT, ListaDetalles, _TipoAnexoDoc, Modo_consultar) Then
                If Modo_consultar = True Then
                    MsgBox("Documento Modificado Correctamente," & vbCrLf & " Nro Documento: " & OrdenCompraCabENT.ID, MsgBoxStyle.Information)
                Else
                    MsgBox("Nuevo documento Generado Correctamente," & vbCrLf & " Nro Documento: " & OrdenCompraCabENT.ID, MsgBoxStyle.Information)
                End If
                OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
                OrdenCompraBl.ActualizandoEstado(ListaDetalles)
                DocumentosOrdenCompra()
                If MessageBox.Show("Se procedera a la Impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    imprimir_Orden_Compra(OrdenCompraCabENT.ID, OrdenCompraCabENT.AMOUNT_SALES, OrdenCompraCabENT.CURRENCY_TYPE)
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalle.Rows.Count() = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        Dim mensaje As String = ""
        If Modo_consultar = True Then
            mensaje = "Se va a modificar la orden de compra."
        Else
            mensaje = "Se va a Generar la orden de compra."
        End If
        If CInt(IIf(txttipoCambio.Text = "", 0, txttipoCambio.Text)) = 0 Or txttipoCambio.Text = "" Then
            MessageBox.Show("Falta ingresar el tipo de cambio del día.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            If ValidacionesGenerales() = False Then Exit Sub
            For Each row As DataRow In dtdetalleArticuloPrincipal.Select("QTY=0 OR PRICE=0", "")
                MessageBox.Show("Falta ingresar el precio y/o cantidad a los Articulos.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Next
        End If

        Try

            If MessageBox.Show(mensaje & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Modo_consultar = True Then
                    If txtestado.Text = "05" Or txtestado.Text = "02" Then Exit Sub
                End If
                Me.Cursor = Cursors.WaitCursor
                If Guardar_Orden_Compra() Then
                    DocumentosOrdenCompra()
                    btnCancelar_Click(sender, e)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub


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
            Dim _id As String = String.Empty
            _id = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value
            estadoInicial = dgvCabecera.Item(7, dgvCabecera.CurrentRow.Index).Value
            If estadoInicial = "05" Then
                MsgBox("El documento ya se encuentra anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If estadoInicial = "03" Or estadoInicial = "04" Or estadoInicial = "07" Or estadoInicial = "08" Then
                MsgBox("El documento ya se encuentra registrado por el Modulo de Compras.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If MessageBox.Show("Se va a cambiar el estado de la Orden de Compra" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                estadoActualizado = Ayuda_CambioEstado(estadoInicial)
                If String.IsNullOrEmpty(estadoActualizado) Then
                    MsgBox("Debe elegir un Tipo de estado.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                Dim sql As String = ""
                OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
                Select Case estadoActualizado
                    Case "01"
                        If MessageBox.Show("Confirmacion de cambio de estado a : EMITIDA " & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='" & estadoActualizado & "' WHERE ID='" & _id & "' and TYPE='OC'"
                            If OrdenCompraBl.Cambiar_Estado_Oden_Compra(sql) Then
                                MsgBox("Cambio de estado realizado Correctamente.", MsgBoxStyle.Information)
                            End If
                        End If
                    Case "02"
                        If MessageBox.Show("Confirmacion de cambio de estado a : APROBADA" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='" & estadoActualizado & "' WHERE ID='" & _id & "' and TYPE='OC'"
                            If OrdenCompraBl.Cambiar_Estado_Oden_Compra(sql) Then
                                MsgBox("Cambio de estado realizado Correctamente.", MsgBoxStyle.Information)
                            End If
                        End If
                        'Case "05"
                        '    If MessageBox.Show("Se va a anular la orden de compra" & vbCrLf & "¿Desea continuar?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        '        If OrdenCompraBl.Anular_Oden_Compra(_id) Then
                        '            MsgBox("Documento anulado Correctamente.", MsgBoxStyle.Information)
                        '        End If
                        '    End If
                    Case "06"
                        If MessageBox.Show("Confirmacion de cambio de estado a : APROBADA" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='" & estadoActualizado & "' WHERE ID='" & _id & "' and TYPE='OC'"
                            If OrdenCompraBl.Cambiar_Estado_Oden_Compra(sql) Then
                                MsgBox("Cambio de estado realizado Correctamente.", MsgBoxStyle.Information)
                            End If
                        End If
                End Select
                btnCancelar_Click(sender, e)
                DocumentosOrdenCompra()
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

    Private Sub imprimir_Orden_Compra(ByVal _Codigo As String, ByVal _Monto As Double, ByVal _Moneda As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("OrdenCompra")
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

            dtImprimir = reporteBL.EjecutarReporteOrdenCompra(_Codigo)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Orden_Compra.rpt", dtImprimir, "", "", "@NUMERO;" & _Codigo, "@TIPO;" & "OC", "@LETRA;" & STRmontotexto)
            End If
            'Dim Flag_marcado As String = ""
            'Flag_marcado = IIf(String.IsNullOrEmpty(dgvCabecera.Item(11, dgvCabecera.CurrentRow.Index).Value.ToString), 0, 1)
            'If Flag_marcado = "1" Then
            '    dtImprimir = reporteBL.BuscarRequisiciones_OrdenCompra(_Codigo)
            '    If dtImprimir.Rows.Count() <> 0 Then
            '        For Each row As DataRow In dtImprimir.Rows
            '            dtImprimir = reporteBL.EjecutarReporteRequisiciones("RQ", row("REQUI_ID"))
            '            If dtImprimir.Rows.Count() <> 0 Then
            '                crystalBL.Muestra_Reporte("rpt_Compras_requisiciones.rpt", "", "", "", "@TYPE;" & "RQ", "@ID;" & row("REQUI_ID"))
            '            End If
            '        Next
            '    End If
            'End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim _Id As String = String.Empty
        Dim _Monto As Double = 0.0
        Dim _Moneda As String = String.Empty
        _Id = dgvCabecera.CurrentRow.Cells("ID").Value
        _Monto = dgvCabecera.CurrentRow.Cells("AMOUNT_SALES").Value
        _Moneda = dgvCabecera.CurrentRow.Cells("CURRENCY_TYPE").Value
        imprimir_Orden_Compra(_Id, _Monto, _Moneda)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        Limpiar()
        'DocumentosOrdenCompra()
        gbcabecera.Enabled = True
        btnEliminar.Enabled = NIVEL_ACCESO()
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
            If txtcodigo.Text = String.Empty Then
                MsgBox("Debe no se cargo el Codigo.", MsgBoxStyle.Information)
                estado = False
                txtcodigo.Focus()
                Exit Try
            ElseIf txtproveedor.Text = String.Empty Then
                MsgBox("Debe ingresar un Proveedor, para poder continuar.", MsgBoxStyle.Information)
                estado = False
                txtproveedor.Focus()
                Exit Try
            ElseIf txtFormaPago.Text = String.Empty Then
                MsgBox("Debe seleccionar una forma de Pago.", MsgBoxStyle.Information)
                estado = False
                txtFormaPago.Focus()
                Exit Try
            ElseIf txtSolicitante.Text = String.Empty Then
                MsgBox("Debe seleccionar un Solicitante.", MsgBoxStyle.Information)
                estado = False
                txtSolicitante.Focus()
                Exit Try
            ElseIf txtresponsable.Text = String.Empty Then
                MsgBox("Debe seleccionar un Responsable.", MsgBoxStyle.Information)
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

            If txttipoCambio.Text = "" Then
                MsgBox("No se cargo el Tipo de Cambio de la fecha elegida.", MsgBoxStyle.Critical)
                estado = False
                dtpemision.Focus()
                Exit Try
            ElseIf CDbl(txttipoCambio.Text) = 0 Then
                MsgBox("El Tipo de Cambio no puede ser cero.", MsgBoxStyle.Critical)
                estado = False
                dtpemision.Focus()
                Exit Try
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
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar la Orden de Compra.", MsgBoxStyle.Critical)
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
        txtcantidadref.Text = "0"
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
        txtcantidadprov.Text = ""
        txtcentrocostodetalle.Text = ""
        txtcant_calculo_prov.Text = "0"
        txtunidadprov.Text = "0"
        chk_libre.Checked = False
        chkigv.Checked = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If gbcabecera.Enabled = True Then
                If ValidacionesGenerales() = False Then Exit Sub
                'gbcabecera.Enabled = False
            End If
            _Flag_edicion = False
            CONTROLES(True, 1)
            blank()
            btn_menu.Enabled = False
            txttasa.Text = TasaIgvEstandar()
            txtcodigoArticulo.Enabled = True
            txtcantidad.Enabled = True
            txtcodigoArticulo.Select()
            'txtcantidad.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CalcularTotales()
        Try
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                txtDescuentos.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (DISCOUNT) ", ""), "0.00")
                txtvalorVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (PRICE_NET) ", ""), "0.00")
                txtIgv.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (AMOUNT_TAX) ", ""), "0.00")
                txtPrecioVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (AMOUNT_TOTAL_NET) ", ""), "0.00")
                txtBruto.Text = Format(Val(txtvalorVenta.Text) + Val(txtDescuentos.Text), "0.00")

                If chkflesinigv.Checked = True Then
                    txtIgv.Text = CDbl(txtIgv.Text) '+ (Val(TXTFLETE.Text) * (_valor_igv / 100))
                Else
                    txtIgv.Text = CDbl(txtIgv.Text) + (Val(TXTFLETE.Text) * (_valor_igv / 100))
                End If

                txtvalorVenta.Text = Val(txtvalorVenta.Text) + Val(TXTFLETE.Text)
                txtBruto.Text = Format(Val(txtvalorVenta.Text) + Val(txtDescuentos.Text), "0.00")
                txtPrecioVenta.Text = Val(txtIgv.Text) + Val(txtvalorVenta.Text)

                txtBruto.Text = Format(Double.Parse(txtBruto.Text), "##,##0.00")
                txtDescuentos.Text = Format(Double.Parse(txtDescuentos.Text), "##,##0.00")
                txtvalorVenta.Text = Format(Double.Parse(txtvalorVenta.Text), "##,##0.00")
                txtIgv.Text = Format(Double.Parse(txtIgv.Text), "##,##0.00")
                txtPrecioVenta.Text = Double.Parse(txtBruto.Text) - Double.Parse(txtDescuentos.Text) + Double.Parse(txtIgv.Text)
                txtPrecioVenta.Text = Format(Double.Parse(txtPrecioVenta.Text), "##,##0.00")

            Else
                'TXTFLETE.Text = "0.00"
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
                'gbcabecera.Enabled = False
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
                If row("UNIT_PROVEEDOR") = "" Then
                    txtunidadMedida.Text = row("UNIT")
                    txtunidadprov.Text = row("UNIT_PROVEEDOR")
                Else
                    txtunidadMedida.Text = row("UNIT_PROVEEDOR")
                    txtunidadprov.Text = row("UNIT")
                End If

                txtunidadMedRef.Text = row("UNIT_REFERENCE")
                If CDbl(row("QTY_PROVEEDOR")) = 0 Then
                    txtcantidad.Text = CDbl(row("QTY"))
                    txtcant_calculo_prov.Text = CDbl(row("QTY_PROVEEDOR"))
                Else
                    txtcantidad.Text = CDbl(row("QTY_PROVEEDOR"))
                    txtcant_calculo_prov.Text = CDbl(row("QTY"))
                End If
                If CDbl(row("EQUIVALENCIA")) = 0 Then
                    txtcantidadprov.Text = ""
                Else
                    txtcantidadprov.Text = CDbl(row("EQUIVALENCIA"))
                End If

                txtcantidadref.Text = IIf(row("FACTOR_REFERENCE").ToString = "", 0, row("FACTOR_REFERENCE"))
                txtValorunitario.Text = CDbl(row("PRICE"))
                txtporc_descuento.Text = row("DISCOUNT_PER")
                txtdescuento.Text = row("DISCOUNT")
                txt_igv.Text = row("AMOUNT_TAX")
                If _TipoDato = "RQ" Then
                    txttasa.Text = TasaIgvEstandar()
                Else
                    txttasa.Text = row("PERCENT_TAX")
                End If
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
                'txtcentrocostodetalle.Text = row("CCOST_ID")
                'Ayuda_Centro_Costo_Compras(txtcentrocostodetalle.Text)
                txtcentrocostodetalle.Text = row("CECOS")
                lblcentrocostodetalle.Text = row("CECOS_DES")
                txtproyecto.Text = row("PROJECT_ID")
                txtarea.Text = row("AREA_ID")
                If txtcantidadref.Text <> 0 Then
                    txtvalorventaref.Text = txtdescuento.Text
                Else
                    txtvalorventaref.Text = 0
                End If
                txtvalorbruto.Text = Format(Val(txtdescuento.Text) + Val(txtvalorvent.Text), "0.00")
                If String.IsNullOrEmpty(row("AREA_ID").ToString) Or String.IsNullOrEmpty(row("REQUI_ID").ToString) Then
                    txtcodigoArticulo.Enabled = True
                    txtcantidad.Enabled = True
                    txtcodigoArticulo.Select()
                Else
                    txtcodigoArticulo.Enabled = False
                    txtcantidad.Enabled = False
                    txtValorunitario.Select()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub RehacerSecuencia()
    '    Dim i As Integer = 0
    '    For Each items As DataRow In dtdetalleArticuloPrincipal.Rows
    '        i += 1
    '        dtdetalleArticuloPrincipal.BeginInit()
    '        items("ITEM") = i
    '        dtdetalleArticuloPrincipal.EndInit()
    '        dtdetalleArticuloPrincipal.AcceptChanges()
    '    Next
    'End Sub

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
        DocumentosOrdenCompra()
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
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFormaPago_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFormaPago.MouseDoubleClick
        Ayuda_FormaPago()
    End Sub

    Private Sub Ayuda_Solicitante()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_SOLICITANTE"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE SOLICITANTES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtSolicitante.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblsolicitante.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                btnAgregar.Select()
            Else
                txtresponsable.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub txtSolicitante_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSolicitante.MouseDoubleClick
        Ayuda_Solicitante()
    End Sub

    Private Sub txtresponsable_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtresponsable.MouseDoubleClick
        Ayuda_Responsable()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            'For Each row As DataGridViewRow In dgvCabecera.Rows
            '    row.Cells(11).Value = False
            'Next
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns(2).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns(5).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(5).Name & "+" & dgvCabecera.Columns(6).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosOrdenCompra()
        End If
    End Sub

    Private Sub Tc_principal_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Tc_principal.Selecting
        If Not Tc_principal.SelectedTab.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Ayuda_Unidad_Medida(ByVal texto As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_UNIDAD_REF"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista Unidad de Medida de Referencia"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                texto.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                texto.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Ayuda_Unidad_Medida_Prov(ByVal texto As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_UNIDAD_REF"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista Unidad de Medida de Referencia"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                texto.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                texto.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtunidadMedRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtunidadMedRef.MouseDoubleClick
        Ayuda_Unidad_Medida(txtunidadMedRef)
    End Sub

    Private Sub txtValorunitario_Leave(sender As Object, e As EventArgs) Handles txtValorunitario.Leave
        If txtValorunitario.Text = String.Empty Then Exit Sub
        'If _Flag_edicion = False Then
        '    txtcantidad.Text = txtcantidadprov.Text
        'End If
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
            txttasa.Text = 18
            nTasaIGV = (CDbl(txttasa.Text) / 100)
            If CDbl(txtValorunitario.Text) <> 0 Then  'Valor unitario
                If chk_libre.Checked Then
                    If CDbl(txtcant_calculo_prov.Text) = 0 Or txtcant_calculo_prov.Text = "" Then
                        nValorUnit = CDbl(txtValorunitario.Text)
                        If CDbl(txtcantidad.Text) <> 0 Then
                            nValorUniRef = 0
                            nDsctoUnit = nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
                            nValorUnit = nValorUnit - nDsctoUnit
                        End If
                        'Precio Unitario
                        nPrecioUnit = nValorUnit
                        nValorVta = nValorUnit * CDbl(txtcantidad.Text)
                        nMontodes = nDsctoUnit * CDbl(txtcantidad.Text)
                        nMontoIgv = 0
                        nMontoTotal = nValorVta + nMontoIgv
                        nValorBruto = nValorVta + nMontodes
                        txttasa.Text = 0
                    ElseIf CDbl(txtcant_calculo_prov.Text) > 0 Then
                        nValorUnit = CDbl(txtValorunitario.Text)
                        If CDbl(txtcant_calculo_prov.Text) <> 0 Then
                            nValorUniRef = 0
                            nDsctoUnit = Math.Round(nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100, 6)
                            nValorUnit = nValorUnit - nDsctoUnit
                        End If
                        'Precio Unitario
                        nPrecioUnit = nValorUnit
                        nValorVta = Math.Round(nValorUnit * CDbl(txtcant_calculo_prov.Text), 6)
                        nMontodes = Math.Round(nDsctoUnit * CDbl(txtcant_calculo_prov.Text), 6)
                        nMontoIgv = 0
                        nMontoTotal = nValorVta + nMontoIgv
                        nValorBruto = nValorVta + nMontodes
                        txttasa.Text = 0
                    End If
                    'Aplicando descuento

                Else
                    'Aplicando descuento
                    If chkigv.Checked = True Then
                        nValorUnit = Math.Round(CDbl(txtValorunitario.Text) / (1 + nTasaIGV), 6)
                    Else
                        nValorUnit = CDbl(txtValorunitario.Text)
                    End If
                    If CDbl(txtcant_calculo_prov.Text) = 0 Or txtcant_calculo_prov.Text = "" Then
                        If CDbl(txtcantidadref.Text) <> 0 And CDbl(txtcantidad.Text) <> 0 Then
                            nValorUniRef = Math.Round((CDbl(txtcantidadref.Text) / Val(txtcantidad.Text)) * nValorUnit, 6)
                            nDsctoUnit = nValorUniRef * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
                            nValorUniRef = nValorUniRef - nDsctoUnit
                            nValorUnit = nValorUniRef
                        Else
                            nValorUniRef = 0
                            nDsctoUnit = Math.Round(nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100, 6)
                            nValorUnit = nValorUnit - nDsctoUnit
                        End If
                        'Precio Unitario
                        nPrecioUnit = Math.Round(nValorUnit * (1 + nTasaIGV), 6)
                        nValorVta = Math.Round(nValorUnit * CDbl(txtcantidad.Text), 2)
                        nMontodes = Math.Round(nDsctoUnit * CDbl(txtcantidad.Text), 2)
                        nMontoIgv = Math.Round((nValorUnit * nTasaIGV) * CDbl(txtcantidad.Text), 2)
                        nMontoTotal = nValorVta + nMontoIgv
                        nValorBruto = nValorVta + nMontodes
                    ElseIf CDbl(txtcant_calculo_prov.Text) > 0 Then
                        If CDbl(txtcantidadref.Text) <> 0 And CDbl(txtcant_calculo_prov.Text) <> 0 Then
                            nValorUniRef = Math.Round((CDbl(txtcantidadref.Text) / CDbl(txtcant_calculo_prov.Text)) * nValorUnit, 6)
                            nDsctoUnit = nValorUniRef * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
                            nValorUniRef = nValorUniRef - nDsctoUnit
                            nValorUnit = nValorUniRef
                        Else
                            nValorUniRef = 0
                            nDsctoUnit = Math.Round(nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100, 6)
                            nValorUnit = nValorUnit - nDsctoUnit
                        End If
                        'Precio Unitario
                        nPrecioUnit = Math.Round(nValorUnit * (1 + nTasaIGV), 6)
                        nValorVta = Math.Round(nValorUnit * CDbl(txtcant_calculo_prov.Text), 2)
                        nMontodes = Math.Round(nDsctoUnit * CDbl(txtcant_calculo_prov.Text), 2)
                        nMontoIgv = Math.Round((nValorUnit * nTasaIGV) * CDbl(txtcant_calculo_prov.Text), 2)
                        nMontoTotal = nValorVta + nMontoIgv
                        nValorBruto = nValorVta + nMontodes
                    End If

                End If
            End If
            txtvalorventaref.Text = Format(nValorUniRef, "0.00")
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
        chk_libre.Enabled = Not chkigv.Checked
        ' chk_libre.Checked = Not chkigv.Checked
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
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("PART_ID") = txtcodigoArticulo.Text
                row("DESCRIPTION") = txtdescripcionArticulo.Text
                If Val(txtcant_calculo_prov.Text) > 0 Then
                    row("UNIT") = txtunidadprov.Text
                    row("UNIT_PROVEEDOR") = txtunidadMedida.Text
                ElseIf txtcant_calculo_prov.Text = "" Or Val(txtcant_calculo_prov.Text) = 0 Then
                    row("UNIT") = txtunidadMedida.Text
                    row("UNIT_PROVEEDOR") = txtunidadprov.Text
                End If
                row("UNIT_REFERENCE") = txtunidadMedRef.Text
                If Val(txtcant_calculo_prov.Text) > 0 Then
                    row("QTY") = IIf(txtcant_calculo_prov.Text = "", 0, txtcant_calculo_prov.Text)
                    row("QTY_PROVEEDOR") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
                ElseIf txtcant_calculo_prov.Text = "" Or Val(txtcant_calculo_prov.Text) = 0 Then
                    row("QTY") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
                    row("QTY_PROVEEDOR") = IIf(txtcant_calculo_prov.Text = "", 0, txtcant_calculo_prov.Text)
                End If

                row("EQUIVALENCIA") = IIf(txtcantidadprov.Text = "", 0, txtcantidadprov.Text)

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
                row("CCOST_ID") = "" 'txtcentrocostodetalle.Text
                row("PROJECT_ID") = txtproyecto.Text
                row("AREA_ID") = txtarea.Text
                row("FLAG_FREE_IGV") = IIf(chk_libre.Checked = True, 1, 0)
                row("CECOS") = txtcentrocostodetalle.Text
                row("CECOS_DES") = lblcentrocostodetalle.Text
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                blank()
                txtcodigoArticulo.Select()
            Else
                For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _Codigo_Ini)
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("PART_ID") = txtcodigoArticulo.Text
                    row("DESCRIPTION") = txtdescripcionArticulo.Text

                    If Val(txtcant_calculo_prov.Text) > 0 Then
                        row("UNIT") = txtunidadprov.Text
                        row("UNIT_PROVEEDOR") = txtunidadMedida.Text
                    ElseIf txtcant_calculo_prov.Text = "" Or Val(txtcant_calculo_prov.Text) = 0 Then
                        row("UNIT") = txtunidadMedida.Text
                        row("UNIT_PROVEEDOR") = txtunidadprov.Text
                    End If
                    row("UNIT_REFERENCE") = txtunidadMedRef.Text

                    If Val(txtcant_calculo_prov.Text) > 0 Then
                        row("QTY") = IIf(txtcant_calculo_prov.Text = "", 0, txtcant_calculo_prov.Text)
                        row("QTY_PROVEEDOR") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
                    ElseIf txtcant_calculo_prov.Text = "" Or Val(txtcant_calculo_prov.Text) = 0 Then
                        row("QTY") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
                        row("QTY_PROVEEDOR") = IIf(txtcant_calculo_prov.Text = "", 0, txtcant_calculo_prov.Text)
                    End If
                    row("EQUIVALENCIA") = IIf(txtcantidadprov.Text = "", 0, txtcantidadprov.Text)

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
                    row("CCOST_ID") = "" 'txtcentrocostodetalle.Text
                    row("PROJECT_ID") = txtproyecto.Text
                    row("AREA_ID") = txtarea.Text
                    row("FLAG_FREE_IGV") = IIf(chk_libre.Checked = True, 1, 0)
                    row("CECOS") = txtcentrocostodetalle.Text
                    row("CECOS_DES") = lblcentrocostodetalle.Text
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                btn_cancel.PerformClick()
                ConfigurarGrila()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidacionesGeneralesArticulo() As Boolean
        Dim estado As Boolean = True
        Try
            If txtcodigoArticulo.Text = String.Empty Then
                MsgBox("Debe ingresar o seleccionar un articulo.", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtcodigoArticulo.Focus()
                Exit Try
            ElseIf txtcentrocostodetalle.Text = String.Empty And txtcentrocostodetalle.Enabled = True Then
                MsgBox("Debe elegir un Centro de Costo.", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtcentrocostodetalle.Focus()
                Exit Try
            ElseIf txtcantidad.Text = String.Empty Then
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
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtValorunitario.Focus()
                Exit Try
            ElseIf Val(txtcant_calculo_prov.Text) > 0 And txtunidadprov.Text = "" Then
                MsgBox("Debe elegir una unidad de medida del Proveedor.", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtunidadprov.Focus()
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
            Dim _NumeroCuenta As String
            Dim sql As String = String.Empty
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
                If Strings.Left(txtcodigoArticulo.Text.Trim, 1) = "N" Then
                    txtdescripcionArticulo.ReadOnly = False
                Else
                    txtdescripcionArticulo.ReadOnly = True
                End If

                If Strings.Left(_NumeroCuenta, 1) = "6" And Strings.Left(_NumeroCuenta, 2) <> "60" And Strings.Left(_NumeroCuenta, 2) <> "61" Then
                    txtcentrocostodetalle.Text = ""
                    lblcentrocostodetalle.Text = ""
                    txtcentrocostodetalle.Enabled = True
                    txtcentrocostodetalle.BackColor = Color.Aquamarine
                Else
                    txtcentrocostodetalle.Text = ""
                    lblcentrocostodetalle.Text = ""
                    txtcentrocostodetalle.Enabled = False
                    txtcentrocostodetalle.BackColor = Color.Gainsboro
                End If

                txtcentrocostodetalle.Focus()
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
            dtDocumentoGuias = clsArticuloBl.VerificacionArticuloCodigo(_codigoArticulo, "RQ")
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("ID").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPTION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNIT_OF_MEASUREMENT").ToString
                _NumeroCuenta = dtDocumentoGuias.Rows(0).Item("CUENTACOMPRA").ToString
                If Strings.Left(txtcodigoArticulo.Text.Trim, 1) = "N" Then
                    txtdescripcionArticulo.ReadOnly = False
                Else
                    txtdescripcionArticulo.ReadOnly = True
                End If
                If Strings.Left(_NumeroCuenta, 1) = "6" And Strings.Left(_NumeroCuenta, 2) <> "60" And Strings.Left(_NumeroCuenta, 2) <> "61" Then
                    txtcentrocostodetalle.Text = ""
                    lblcentrocostodetalle.Text = ""
                    txtcentrocostodetalle.Enabled = True
                    txtcentrocostodetalle.BackColor = Color.Aquamarine
                Else
                    txtcentrocostodetalle.Text = ""
                    lblcentrocostodetalle.Text = ""
                    txtcentrocostodetalle.Enabled = False
                    txtcentrocostodetalle.BackColor = Color.Gainsboro
                End If

                txtcantidad.Focus()
            Else
                MsgBox("El codigo ingresado no pertence a la Familia principal de la Empresa.", MsgBoxStyle.Critical)
                txtcodigoArticulo.Text = String.Empty
                txtdescripcionArticulo.Text = String.Empty
                txtunidadMedida.Text = String.Empty
                txtdescripcionArticulo.ReadOnly = True
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

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtValorunitario.Select()
        End If
    End Sub

    Private Sub txtGlosa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGlosa.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtValorunitario.Select()
        End If
    End Sub

    Private Sub txtporc_descuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalorventaunit.KeyPress, txtvalorventaref.KeyPress, txtvalorvent.KeyPress, txtValorunitario.KeyPress, txtvalorbruto.KeyPress, txttasa.KeyPress, txtpreciounitario.KeyPress, txtdescuento.KeyPress, txt_igv.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtporc_descuento.Focus() 'SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtobservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcentroCosto.KeyPress, txtarea.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtproyecto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproyecto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_anexar_Click(sender As Object, e As EventArgs) Handles btn_anexar.Click
        ContextMenuStrip1.Show(btn_anexar, 0, btn_anexar.Height)
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


    Private Sub Ayuda_Requisiciones()
        Try
            Dim frm As New frmBuscar
            Dim frm_detalles As New FrmDetallesRequisiciones
            Dim sql As String = String.Empty
            Dim ID_REQ As String = ""
            sql = "COMPRA_SP_S_LISTA_REQUIREMENT"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = "RQ"
            frm.Titulo = "LISTA DE REQUISICIONES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                ID_REQ = frm.Data_Matriz.Rows(0).Item(0).ToString
                frm_detalles._numero_requisicion = ID_REQ
                frm_detalles._tipo_requisicion = "RQ"
                frm_detalles.Titulo = "DETALLE DE REQUISICION N° " & ID_REQ
                frm_detalles.ShowDialog()
                If frm_detalles._lista_items = String.Empty Then
                    frm_detalles.Close()
                    frm.Close()
                    Exit Sub
                End If
                frm_detalles.Close()
            End If
            frm.Close()
            If ID_REQ = "" Then Exit Sub
            'DETALLES
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            Dim dtrequis As New DataTable
            dtrequis = OrdenCompraBl.Requisicion_Detalle(ID_REQ, frm_detalles._lista_items)
            'GenerarColummnaDataTable()
            For Each MydataRow In dtrequis.Rows
                dtdetalleArticuloPrincipal.ImportRow(MydataRow)
            Next MydataRow
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                RehacerSecuencia()
                ConfigurarGrila()
            End If

            txtcotizacion.Text = ""
            _TipoAnexoDoc = ""
            _NumeroTipoAnexoDoc = ""
            _TipoDato = ""
            _TipoDato = "RQ"
            _NumeroTipoAnexoDoc = ID_REQ
            _TipoAnexoDoc = "REQUISICION"
        Catch ex As Exception
            GenerarColummnaDataTable()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RequisicionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequisicionesToolStripMenuItem.Click
        Ayuda_Requisiciones()
    End Sub


    Private Sub Ayuda_Cotizaciones()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim ID_COT As String = ""
            sql = "COMPRA_SP_S_LISTA_QUOTE"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE COTIZACIONES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                ID_COT = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtcotizacion.Text = ID_COT
                txtproveedor.Text = frm.Data_Matriz.Rows(0).Item(4).ToString
                txtproveedor_razons.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtproveedor_ruc.Text = frm.Data_Matriz.Rows(0).Item(5).ToString
                txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(6).ToString
                lblformapago.Text = frm.Data_Matriz.Rows(0).Item(7).ToString
                cbomoneda.SelectedIndex = IIf(frm.Data_Matriz.Rows(0).Item(8).ToString = "MN", 0, 1)
                cbomoneda.Enabled = False
            End If

            frm.Close()
            If ID_COT = "" Then Exit Sub
            'DETALLES
            'OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            ''GenerarColummnaDataTable()
            'dtdetalleArticuloPrincipal = OrdenCompraBl.Cotizacion_Detalle(ID_COT)
            'If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            '    ConfigurarGrila()
            '    Calcular_Importes_Detalle_Ayuda()
            '    CalcularTotales()
            'End If

            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            Dim dtcotiz As New DataTable
            dtcotiz = OrdenCompraBl.Cotizacion_Detalle(ID_COT)
            'GenerarColummnaDataTable()
            For Each MydataRow In dtcotiz.Rows
                dtdetalleArticuloPrincipal.ImportRow(MydataRow)
            Next MydataRow
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                RehacerSecuencia()
                ConfigurarGrila()
                Calcular_Importes_Detalle_Ayuda()
                CalcularTotales()
            End If
            _TipoAnexoDoc = ""
            _NumeroTipoAnexoDoc = ""
            _TipoDato = ""
            _TipoDato = "SC"
            _TipoAnexoDoc = "COTIZACION"
            _NumeroTipoAnexoDoc = ID_COT
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
                nTasaIGV = (Val(IIf(String.IsNullOrEmpty(row("AMOUNT_TAX")), 0, row("AMOUNT_TAX"))) / 100)
                If Val(IIf(String.IsNullOrEmpty(row("PRICE")), 0, row("PRICE"))) <> 0 Then  'Valor unitario
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

                    'txtvalorventaref.Text = Format(nValorUniRef, "0.00")
                    'txtvalorventaunit.Text = Format(nValorUnit, "0.00")
                    'txtpreciounitario.Text = Format(nPrecioUnit, "0.00")
                    'txtvalorbruto.Text = Format(nValorBruto, "0.00")
                    'txtdescuento.Text = Format(nMontodes, "0.00")
                    'txtvalorvent.Text = Format(nValorVta, "0.00")
                    'txt_igv.Text = Format(nMontoIgv, "0.00")
                    'txttotalneto.Text = Format(nMontoTotal, "0.00")

                    'actualizando data
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("DISCOUNT") = Format(nMontodes, "0.00")
                    row("AMOUNT_TAX") = Format(nMontoIgv, "0.00")
                    row("PERCENT_TAX") = IIf(String.IsNullOrEmpty(txttasa.Text), 0, txttasa.Text)
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


    Private Sub CotizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacionesToolStripMenuItem.Click
        Ayuda_Cotizaciones()
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


    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Clientes()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtproveedor.Text = "" Then
                Ayuda_Clientes()
            Else
                SendKeys.Send("{TAB}")
            End If
        End If
    End Sub

    Private Sub txtFormaPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFormaPago.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_FormaPago()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtFormaPago.Text = "" Then
                Ayuda_FormaPago()
            End If
        End If
    End Sub

    Private Sub txtSolicitante_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSolicitante.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Solicitante()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtSolicitante.Text = "" Then
                Ayuda_Solicitante()
            End If
        End If
    End Sub

    Private Sub txtresponsable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtresponsable.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Responsable()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtresponsable.Text = "" Then
                Ayuda_Responsable()
            Else
                btnAgregar.Select()
            End If
        End If
    End Sub

    Private Sub txtunidadMedida_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Ayuda_Unidad_Medida(txtunidadMedida)
    End Sub

    Private Sub txtporc_descuento_Leave(sender As Object, e As EventArgs) Handles txtporc_descuento.Leave
        If txtValorunitario.Text = String.Empty Then Exit Sub
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

    Private Sub dtpEntrega_ValueChanged(sender As Object, e As EventArgs) Handles dtpEntrega.ValueChanged

    End Sub


    Private Sub txtporc_descuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtporc_descuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtobservaciones.Select()
        End If
    End Sub

    Private Sub dgvCabecera_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvCabecera.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvCabecera.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgvCabecera.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvCabecera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCabecera.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim Estado As String = dgvCabecera.Item(10, dgvCabecera.CurrentRow.Index).Value
            If Estado = "EMITIDA" Then
                If dgvCabecera.Rows.Count() = 0 Then Exit Sub
                If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
                If ConsultandoDocumentos() Then
                    btn_aprobar.Visible = True
                    btn_desaprobar.Visible = False
                End If
            Else
                If Estado = "RECHAZADA" Then
                    MsgBox("El documento, ya se encuentra RECHAZADA.", MsgBoxStyle.Information, "Sistemas")
                    Exit Sub
                ElseIf Estado = "APROBADA" Then
                    MsgBox("El documento, ya se encuentra APROBADA.", MsgBoxStyle.Information, "Sistemas")
                    Exit Sub
                End If
            End If
        ElseIf e.ColumnIndex = 1 Then
            Dim Estado As String = dgvCabecera.Item(10, dgvCabecera.CurrentRow.Index).Value
            If Estado = "EMITIDA" Then
                If dgvCabecera.Rows.Count() = 0 Then Exit Sub
                If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
                If ConsultandoDocumentos() Then
                    btn_desaprobar.Visible = True
                    btn_aprobar.Visible = False
                End If
            Else
                If Estado = "RECHAZADA" Then
                    MsgBox("El documento, ya se encuentra RECHAZADA.", MsgBoxStyle.Information, "Sistemas")
                    Exit Sub
                ElseIf Estado = "APROBADA" Then
                    MsgBox("El documento, ya se encuentra APROBADA.", MsgBoxStyle.Information, "Sistemas")
                    Exit Sub
                End If
            End If
        ElseIf e.ColumnIndex = 11 Then
            For Each row As DataGridViewRow In dgvCabecera.Rows
                row.Cells(11).Value = False
            Next
            dgvCabecera.Item(11, dgvCabecera.CurrentRow.Index).Value = True
        End If
    End Sub

    Private Sub chk_libre_CheckedChanged(sender As Object, e As EventArgs) Handles chk_libre.CheckedChanged
        chkigv.Enabled = Not chk_libre.Checked
        'chkigv.Checked = Not chk_libre.Checked
        Calcular_Importes_Detalle()
    End Sub

    Private Sub btn_aprobar_Click(sender As Object, e As EventArgs) Handles btn_aprobar.Click
        Try
            If txtcodigo.Text = "" Then Exit Sub
            If MessageBox.Show("Se va a proceder a APROBAR la Orden de Compra." & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = ""
                sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='02' WHERE ID='" & txtcodigo.Text & "' and TYPE='OC'"
                If OrdenCompraBl.Cambiar_Estado_Oden_Compra(sql) Then
                    MsgBox("Cambio de estado realizado Correctamente.", MsgBoxStyle.Information)
                    DocumentosOrdenCompra()
                    btnCancelar.PerformClick()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_desaprobar_Click(sender As Object, e As EventArgs) Handles btn_desaprobar.Click
        Try
            If txtcodigo.Text = "" Then Exit Sub
            If MessageBox.Show("Se va a proceder a RECHAZAR la Orden de Compra." & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = ""
                sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='06' WHERE ID='" & txtcodigo.Text & "' and TYPE='OC'"
                If OrdenCompraBl.Cambiar_Estado_Oden_Compra(sql) Then
                    MsgBox("Cambio de estado realizado Correctamente.", MsgBoxStyle.Information)
                    DocumentosOrdenCompra()
                    btnCancelar.PerformClick()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_anular_Click(sender As Object, e As EventArgs) Handles btn_anular.Click
        Dim estadoInicial As String = ""
        Dim _id As String = String.Empty
        _id = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value
        estadoInicial = dgvCabecera.Item(7, dgvCabecera.CurrentRow.Index).Value
        If estadoInicial = "05" Then
            MsgBox("El documento ya se encuentra anulado.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MessageBox.Show("Se va a Anular la orden de Compra" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If OrdenCompraBl.Anular_Oden_Compra(_id) Then
                MsgBox("Documento anulado Correctamente.", MsgBoxStyle.Information)
                DocumentosOrdenCompra()
                btnCancelar.PerformClick()
            End If
        End If
    End Sub

 
    Private Sub dtpemision_ValueChanged(sender As Object, e As EventArgs) Handles dtpemision.ValueChanged
        Try
            Dim cls_compras = New ClsOperaciones.CURRENCY_TYPE
            Dim dt_tc As Double

            dt_tc = cls_compras.get_TiposCambio_fecha_dada(dtpemision.Value.ToString("dd/MM/yyyy"))
            If dt_tc > 0 Then
                txttipoCambio.Text = dt_tc
            Else
                txttipoCambio.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtunidadprov_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtunidadprov.MouseDoubleClick
        Ayuda_Unidad_Medida_Prov(txtunidadprov)
    End Sub

    Private Sub btncalcularcantprov_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub txtcantidadprov_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidadprov.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txtValorunitario.Select()
            btncalcularcantprov_Click_1(sender, e)
        End If
    End Sub

    Private Sub txtunidadprov_KeyDown(sender As Object, e As KeyEventArgs) Handles txtunidadprov.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Unidad_Medida_Prov(txtunidadprov)
        End If
        If e.KeyCode = Keys.Enter Then
            If txtunidadprov.Text = "" Then
                Ayuda_Unidad_Medida_Prov(txtunidadprov)
            Else
                txtcantidadprov.Select()
            End If

        End If
    End Sub

    Private Sub btncalcularcantprov_Click_1(sender As Object, e As EventArgs) Handles btncalcularcantprov.Click
        Dim calculo As Double, num_entero As Integer, equivalencia As Double
        If Val(txtcantidad.Text) = 0 Or txtcantidad.Text = "" Then
            MsgBox("Debe ingresar una cantidad o debe ser mayor a cero.", MsgBoxStyle.Information, "Aviso")
            txtcantidadprov.Select()
            Exit Sub
        End If
        'If Val(txtcantidadprov.Text) = 0 Or txtcantidadprov.Text = "" Then
        '    MsgBox("Debe ingresar una cantidad del Proveedor o debe ser mayor a cero.", MsgBoxStyle.Information, "Aviso")
        '    txtcantidadprov.Select()
        '    Exit Sub
        'End If

        Try
            Dim clsArticuloBl As New LibCobranzas.ClsOperaciones.PART
            Dim dtDocumentoGuias As New DataTable
            dtDocumentoGuias = clsArticuloBl.VerificacionArticuloUnidad_Medida(txtunidadMedida.Text)

            If dtDocumentoGuias.Rows.Count() <> 0 Then
                equivalencia = IIf(dtDocumentoGuias.Rows(0).Item("EQUIVALENCIA").ToString = "", 0, CDbl(dtDocumentoGuias.Rows(0).Item("EQUIVALENCIA").ToString))
            Else
                equivalencia = 0
            End If

            If Val(txtcantidadprov.Text) = 0 Or txtcantidadprov.Text = "" Then
                calculo = 0 '(Val(txtcantidad.Text) * equivalencia) / Val(txtcantidadprov.Text)
                num_entero = calculo
                txtcant_calculo_prov.Text = "0"
            Else
                calculo = (Val(txtcantidad.Text) * equivalencia) / Val(txtcantidadprov.Text)
                num_entero = calculo
                If (calculo - num_entero) > 0 Then
                    txtcant_calculo_prov.Text = num_entero + 1
                Else
                    txtcant_calculo_prov.Text = num_entero
                End If
            End If

            'calculo = (Val(txtcantidad.Text) * equivalencia) / Val(txtcantidadprov.Text)
            'num_entero = calculo
            'If (calculo - num_entero) > 0 Then
            '    txtcant_calculo_prov.Text = num_entero + 1
            'Else
            '    txtcant_calculo_prov.Text = num_entero
            'End If

            txtValorunitario.Select()


        Catch ex As Exception
            MsgBox(ex.Message)
            txtcantidadprov.Select()
        End Try

        
    End Sub

    Private Sub chkfecha_entrega_CheckedChanged(sender As Object, e As EventArgs) Handles chkfecha_entrega.CheckedChanged
        If chkfecha_entrega.Checked = True Then
            dtpEntrega.Enabled = True
        Else
            dtpEntrega.Enabled = False
        End If
    End Sub

    Private Sub TXTFLETE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTFLETE.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub TXTFLETE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTFLETE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalcularTotales()
        End If
    End Sub

    Private Sub chkflesinigv_CheckedChanged(sender As Object, e As EventArgs) Handles chkflesinigv.CheckedChanged
        CalcularTotales()
    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("DESCRIPTION").Value = "ANULADA" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub dtpemision_Leave(sender As Object, e As EventArgs) Handles dtpemision.Leave
        Try
            Dim cls_compras = New ClsOperaciones.CURRENCY_TYPE
            Dim dt_tc As Double

            dt_tc = cls_compras.get_TiposCambio_fecha_dada(dtpemision.Value.ToString("dd/MM/yyyy"))
            If dt_tc > 0 Then
                txttipoCambio.Text = dt_tc
            Else
                txttipoCambio.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpemision_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpemision.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim cls_compras = New ClsOperaciones.CURRENCY_TYPE
                Dim dt_tc As Double

                dt_tc = cls_compras.get_TiposCambio_fecha_dada(dtpemision.Value.ToString("dd/MM/yyyy"))
                If dt_tc > 0 Then
                    txttipoCambio.Text = dt_tc
                Else
                    txttipoCambio.Text = "0"
                End If
                txtproveedor.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtcentrocostodetalle_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcentrocostodetalle.MouseDoubleClick
        Ayuda_Centro_Costo_Compras(txtcentrocostodetalle.Text)
    End Sub

    Private Sub txtcentrocostodetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcentrocostodetalle.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Centro_Costo_Compras(txtcentrocostodetalle.Text)
        End If
    End Sub
    Private Sub Ayuda_Centro_Costo_Compras(Optional ByVal _codigo As String = "")
        Try
            'If _codigo = "" Then
            '    Dim frm As New frmBuscar
            '    Dim sql As String = String.Empty
            '    sql = "PUR_SP_S_CENTRO_COSTO_COMPRAS"
            '    frm.CadenaConsulta = sql
            '    frm.Titulo = "LISTA DE CENTROS DE COSTO COMPRAS"
            '    frm.ShowDialog()
            '    If frm.Data_Matriz.Rows.Count > 0 Then
            '        txtcentrocostodetalle.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            '        lblcentrocostodetalle.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            '        txtcantidad.Select()
            '    Else
            '        txtcentrocostodetalle.Text = ""
            '        lblcentrocostodetalle.Text = ""
            '        txtcentrocostodetalle.Select()
            '    End If
            '    frm.Close()
            'Else
            '    Dim clsArticuloBl As New LibCobranzas.ClsOperaciones.PART
            '    Dim dtDocumentoGuias As New DataTable
            '    dtDocumentoGuias = clsArticuloBl.Verifica_Centro_Costo(_codigo)
            '    If dtDocumentoGuias.Rows.Count > 0 Then
            '        lblcentrocostodetalle.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPTION").ToString
            '    End If
            'End If

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CO_SP_S_CENCOS_MOV" 'PUR_SP_S_CENTRO_COSTO_COMPRAS"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE CENTROS DE COSTO COMPRAS"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcentrocostodetalle.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblcentrocostodetalle.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtcantidad.Select()
            Else
                txtcentrocostodetalle.Text = ""
                lblcentrocostodetalle.Text = ""
                txtcentrocostodetalle.Select()
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_menu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles btn_menu.ItemClicked

    End Sub

    Private Sub txtentrega_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtentrega.MouseDoubleClick
        Ayuda_Direccion()
    End Sub

    Private Sub txtentrega_KeyDown(sender As Object, e As KeyEventArgs) Handles txtentrega.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Direccion()
        End If
    End Sub

    Private Sub Ayuda_Direccion()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_ADDR_ENTREGA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Direcciones de Entrega"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtentrega.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
End Class
