Public Class FrmManufactura_Orden_Compra

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
    Dim Modo_Edicion As Boolean = False

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Dim dtResultados As DataTable

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
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalles.DataSource = Nothing
            dgvDetalles.DataSource = dtdetalleArticuloPrincipal

            dgvDetalles.Columns(6).DefaultCellStyle.Format = "N2"
            dgvDetalles.Columns(7).DefaultCellStyle.Format = "N2"
            dgvDetalles.Columns(9).DefaultCellStyle.Format = "N2"
            dgvDetalles.Columns(10).DefaultCellStyle.Format = "N2"
            dgvDetalles.Columns(12).DefaultCellStyle.Format = "N2"

            dgvDetalles.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            dgvDetalles.Columns(0).HeaderText = "Item"
            dgvDetalles.Columns(1).HeaderText = "Codigo"
            dgvDetalles.Columns(2).HeaderText = "Producto"
            dgvDetalles.Columns(3).HeaderText = "Unidad"
            dgvDetalles.Columns(4).HeaderText = "Unid.Ref"
            ' dgvDetalles.Columns(5).HeaderText = "Factor.Ref"
            dgvDetalles.Columns(6).HeaderText = "Cantidad"
            dgvDetalles.Columns(7).HeaderText = "Precio"
            dgvDetalles.Columns(8).HeaderText = "%.Descuento"
            dgvDetalles.Columns(9).HeaderText = "Descuento"
            dgvDetalles.Columns(10).HeaderText = "I.g.v"
            dgvDetalles.Columns(12).HeaderText = "Valor.Venta"
            dgvDetalles.Columns(14).HeaderText = "Total"

            dgvDetalles.Columns(4).Visible = False
            dgvDetalles.Columns(5).Visible = False
            dgvDetalles.Columns(11).Visible = False
            dgvDetalles.Columns(13).Visible = False

            dgvDetalles.Columns(15).Visible = False
            dgvDetalles.Columns(16).Visible = False
            dgvDetalles.Columns(17).Visible = False
            dgvDetalles.Columns(18).Visible = False
            dgvDetalles.Columns(19).Visible = False
            dgvDetalles.Columns(20).Visible = False
            dgvDetalles.Columns(21).Visible = False
            dgvDetalles.Columns(22).Visible = False
            dgvDetalles.Columns(23).Visible = False
            dgvDetalles.Columns(24).Visible = False
            dgvDetalles.Columns(25).Visible = False
            dgvDetalles.Columns(26).Visible = False

            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

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
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
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
                dtdetalleArticuloPrincipal = OrdenCompraBl.DetalleInicialOrdenCompras(dtResultados.Rows(0).Item("PART_FORM").ToString, dtResultados.Rows(0).Item("PART_FORM_EE").ToString, _NRO_OF)
                ConfigurarGrila()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DocumentosFormulacion()
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
            dtDocumentos = OrdenCompraBl.Mostrar_Documentos_Principal(_NRO_OF, sTipoOrden, dtpfechaInicial.Value.ToString("dd/MM/yyyy"), CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")), IIf(cboopcionesBusqueda.SelectedIndex = 0, "TODOS", "RANGO"))
            dtv = dtDocumentos.DefaultView
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.Columns(0).Width = 100
                dgvCabecera.Columns(1).Width = 80
                dgvCabecera.Columns(2).Width = 80
                dgvCabecera.Columns(3).Width = 300
                dgvCabecera.Columns(4).Width = 100
                dgvCabecera.Columns(5).Visible = False
                dgvCabecera.Columns(6).Width = 100
                dgvCabecera.Columns(7).Width = 80
                dgvCabecera.Columns(8).Width = 80

                dgvCabecera.Columns(0).HeaderText = "Nro.O.F"
                dgvCabecera.Columns(1).HeaderText = "Fecha"
                dgvCabecera.Columns(2).HeaderText = "Codigo"
                dgvCabecera.Columns(3).HeaderText = "Proveedor"
                dgvCabecera.Columns(4).HeaderText = "Ruc"
                dgvCabecera.Columns(6).HeaderText = "Total"
                dgvCabecera.Columns(7).HeaderText = "Moneda"
                dgvCabecera.Columns(8).HeaderText = "Estado"

                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Else
                ' MsgBox("No hay Informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "CODIGO"
        cboMoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub


    Private Sub FrmManufactura_Formulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        cboopcionesBusqueda.SelectedIndex = 0
        Botonera_Estado_Cambiar(False)
        Cargar_Moneda()
    End Sub

    Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs)
        DocumentosFormulacion()
    End Sub

    Private Sub Limpiar()
        txtcodigo.Text = String.Empty
        dtpemision.Value = Date.Now
        txtestado.Text = String.Empty
        txtproveedor.Text = String.Empty
        txtproveedor_razons.Text = String.Empty
        txtproveedor_ruc.Text = String.Empty
        dtpEntrega.Value = Date.Now
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
        txtPrecioVenta.Text = "0.00"
        dgvDetalles.DataSource = Nothing
    End Sub

    Private Sub Nuevo()
        Try
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            Modo_Edicion = False
            gbcabecera.Enabled = True
            Limpiar()
            If Modo_Edicion = False Then
                txtcodigo.Enabled = True
                txtproveedor.Enabled = True
                cbomoneda.Enabled = True
            End If
            txtcodigo.Text = Numeracion()
            txtproveedor.Focus()
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            dtResultados = New DataTable
            Dim sql As String = String.Empty
            sql = "SELECT ADDR , REPORT_SCREEN , VAT_REGISTRATION   FROM COMPANY "
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
            DetalleInicialOrdenCompras()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.PURCHASE_ORDER
            CORRELATIVOBL.Get_NumeroCorrelativoOrdenCompra()

            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
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

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Modo_Edicion = True
        Call Botonera_Estado_Cambiar(True)
        pnlCabecera.Visible = False
        Dim _id As String = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        If Modo_Edicion = True Then
            txtcodigo.Enabled = False
            txtproveedor.Enabled = False
            cbomoneda.Enabled = False
        End If

        Try
            ''cabecera
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            Dim dtCabeceraoC As New DataTable
            dtCabeceraoC = OrdenCompraBl.Modo_Edicion_Cabecera(_id)
            If dtCabeceraoC.Rows.Count() <> 0 Then
                txtcodigo.Text = dtCabeceraoC.Rows(0).Item(0).ToString
                dtpemision.Value = dtCabeceraoC.Rows(0).Item("DOCUMENT_DATE").ToString
                txtestado.Text = dtCabeceraoC.Rows(0).Item("STATUS_ID").ToString
                txtproveedor.Text = dtCabeceraoC.Rows(0).Item("VENDOR_ID").ToString
                txtproveedor_razons.Text = dtCabeceraoC.Rows(0).Item("NAME").ToString
                txtproveedor_ruc.Text = dtCabeceraoC.Rows(0).Item("VAT_REGISTRATION").ToString
                dtpEntrega.Value = dtCabeceraoC.Rows(0).Item("PROMISE_DATE").ToString
                cbomoneda.SelectedValue = dtCabeceraoC.Rows(0).Item("CURRENCY_TYPE").ToString
                txttipoCambio.Text = dtCabeceraoC.Rows(0).Item("SELL_RATE").ToString
                txtFormaPago.Text = dtCabeceraoC.Rows(0).Item("TERMS_NAME").ToString
                txtcotizacion.Text = dtCabeceraoC.Rows(0).Item("NUMBER_ESTIMATING").ToString
                txtentrega.Text = dtCabeceraoC.Rows(0).Item("ADDR_FACT").ToString
                txtnombreFacturar.Text = dtCabeceraoC.Rows(0).Item("NAME_FACT").ToString
                txtdireccionFacturar.Text = dtCabeceraoC.Rows(0).Item("ADDR_FACT").ToString
                txtrucfacturar.Text = dtCabeceraoC.Rows(0).Item("VAT_REGISTRATION_FACT").ToString
                txtComentario.Text = dtCabeceraoC.Rows(0).Item("COMMENT").ToString
                txtSolicitante.Text = dtCabeceraoC.Rows(0).Item("AUTORIZED_ID").ToString

                txtBruto.Text = dtCabeceraoC.Rows(0).Item("AMOUNT").ToString
                txtDescuentos.Text = dtCabeceraoC.Rows(0).Item("DISCOUNT").ToString
                txtIgv.Text = dtCabeceraoC.Rows(0).Item("AMOUNT_TAX").ToString
                txtPrecioVenta.Text = dtCabeceraoC.Rows(0).Item("AMOUNT_SALES").ToString
                txtresponsable.Text = dtCabeceraoC.Rows(0).Item("BUYER_PURCHASE_ID").ToString
                'FORMATEANDO
                txtBruto.Text = Format(CDbl(txtBruto.Text), "##,##0.00")
                txtDescuentos.Text = Format(CDbl(txtDescuentos.Text), "##,##0.00")
                txtIgv.Text = Format(CDbl(txtIgv.Text), "##,##0.00")
                txtPrecioVenta.Text = Format(CDbl(txtPrecioVenta.Text), "##,##0.00")

                ''Detalle
                OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = OrdenCompraBl.Modo_Edicion_Detalle(_id)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    ConfigurarGrila()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardar_Orden_Produccion()
        Try
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            OrdenCompraCabENT = New ClsEntidades.PURCHASE_ORDER
            ListaDetalles = New List(Of ClsEntidades.PURCHASE_ORDER_LINE)

            If Modo_Edicion = True Then
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
                .TERMS_NAME = txtFormaPago.Text
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
                .ADDR_FACT = txtentrega.Text
                .REFER_DOCUMENT_TYPE = ""
                .REFER_DOCUMENT_NUMBER = ""
                .PROJECT_ID = ""
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
                    .QTY_ENTER = item("QTY_ENTER")
                    .QTY_OUT = .QTY
                    .STATUS_ID = "01"
                    .COMMENT1 = item("COMMENT1")
                    .TEXT_COMMENT = item("TEXT_COMMENT")
                    .IS_VAT = item("IS_VAT")
                    .PRICE_UNIT = item("PRICE_UNIT")
                    .CCOST_ID = item("CCOST_ID")
                    .PROJECT_ID = item("PROJECT_ID")
                    .AREA_ID = item("AREA_ID")
                    .COTI_ID = ""
                    .REQUI_ID = ""
                End With
                ListaDetalles.Add(OrdenCompraDetENT)
            Next
            If OrdenCompraBl.GuardarOrdenCompra(OrdenCompraCabENT, ListaDetalles) Then
                If Modo_Edicion = True Then
                    MsgBox("Documento Modificado Correctamente," & vbCrLf & " Nro Documento: " & OrdenCompraCabENT.ID)
                Else
                    MsgBox("Nuevo documento Generado Correctamente," & vbCrLf & " Nro Documento: " & OrdenCompraCabENT.ID)
                End If

                If MessageBox.Show("Se procedera a la Impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    imprimir_Orden_Compra(OrdenCompraCabENT.ID, OrdenCompraCabENT.AMOUNT_SALES, OrdenCompraCabENT.CURRENCY_TYPE)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalles.Rows.Count() = 0 Then Exit Sub
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            ValidacionesGenerales()
            For Each row As DataRow In dtdetalleArticuloPrincipal.Select("QTY=0 AND PRICE=0", "")
                MessageBox.Show("Falta ingresar el Precio y/o Cantidad a los Articulos.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Next
        End If
        Guardar_Orden_Produccion()
        btnCancelar_Click(sender, e)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Try
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim _id As String = String.Empty
                Dim Alm As String = String.Empty
                _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
                If OrdenCompraBl.Eliminar_Oden_Compra(_id) Then
                    MsgBox("Documento eliminado Correctamente.", MsgBoxStyle.Information)
                    btnCancelar_Click(sender, e)
                End If
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
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Nuevos Soles"
            Else
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Dólares Americanos"
            End If

            dtImprimir = reporteBL.EjecutarReporteOrdenCompra(_Codigo)
            If dtImprimir.Rows.Count() <> 0 Then
                'crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                crystalBL.Muestra_Reporte("rpt_Orden_Compra.rpt", "", "", "", "@NUMERO;" & _Codigo, "@TIPO;" & "OC", "@LETRA;" & STRmontotexto)
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
        _Monto = IIf(String.IsNullOrEmpty(dgvCabecera.Item(6, dgvCabecera.CurrentRow.Index).Value.ToString), 0, dgvCabecera.Item(6, dgvCabecera.CurrentRow.Index).Value)
        _Moneda = dgvCabecera.Item(7, dgvCabecera.CurrentRow.Index).Value
        imprimir_Orden_Compra(_Id, _Monto, IIf(_Moneda = "MN", "Nuevos Soles", "Dólares Americanos"))
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        Limpiar()
        DocumentosFormulacion()
    End Sub

    

    Private Sub txtGlosaGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComentario.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtComentario.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarDetalle_OrdenCompra
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                row("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                row("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                row("UNIT_REFERENCE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT_REFERENCE")
                row("FACTOR_REFERENCE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("FACTOR_REFERENCE")
                row("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                row("PRICE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRICE")
                row("DISCOUNT_PER") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DISCOUNT_PER")
                row("AMOUNT_TAX") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AMOUNT_TAX")
                row("PERCENT_TAX") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PERCENT_TAX")
                row("PRICE_NET") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRICE_NET")
                row("AMOUNT_TOTAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AMOUNT_TOTAL")
                row("AMOUNT_TOTAL_NET") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AMOUNT_TOTAL_NET")
                row("QTY_OUT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY_OUT")
                row("STATUS_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("STATUS_ID")
                row("COMMENT1") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COMMENT1")
                row("TEXT_COMMENT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TEXT_COMMENT")
                row("IS_VAT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IS_VAT")
                row("PRICE_UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRICE_UNIT")
                row("CCOST_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CCOST_ID")
                row("PROJECT_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PROJECT_ID")
                row("AREA_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AREA_ID")
                row("COTI_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COTI_ID")
                row("REQUI_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("REQUI_ID")
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                Fl_close = False
            Else
                Fl_close = True
            End If
            ConfigurarGrila()
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If gbcabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            gbcabecera.Enabled = False
        End If
        Modo_Edicion = False
        AgregandoArticulos()
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_Click(sender, e)
        End If
    End Sub

    Private Sub ModificandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarDetalle_OrdenCompra
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.Flag_Modo_Edicion = True
            Dim Codigo As String = dgvDetalles.Item(0, dgvDetalles.CurrentRow.Index).Value
            'Enviando datos seleccioandos a Modificar
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
                row("ITEM") = item("ITEM")
                row("PART_ID") = item("PART_ID")
                row("DESCRIPTION") = item("DESCRIPTION")
                row("UNIT") = item("UNIT")
                row("UNIT_REFERENCE") = item("UNIT_REFERENCE")
                row("FACTOR_REFERENCE") = item("FACTOR_REFERENCE")
                row("QTY") = item("QTY")
                row("PRICE") = item("PRICE")
                row("DISCOUNT_PER") = item("DISCOUNT_PER")
                row("DISCOUNT") = item("DISCOUNT")
                row("AMOUNT_TAX") = item("AMOUNT_TAX")
                row("PERCENT_TAX") = item("PERCENT_TAX")
                row("PRICE_NET") = item("PRICE_NET")
                row("AMOUNT_TOTAL") = item("AMOUNT_TOTAL")
                row("AMOUNT_TOTAL_NET") = item("AMOUNT_TOTAL_NET")
                row("QTY_OUT") = item("QTY_OUT")
                row("STATUS_ID") = item("STATUS_ID")
                row("COMMENT1") = item("COMMENT1")
                row("TEXT_COMMENT") = item("TEXT_COMMENT")
                row("IS_VAT") = item("IS_VAT")
                row("PRICE_UNIT") = item("PRICE_UNIT")
                row("CCOST_ID") = item("CCOST_ID")
                row("PROJECT_ID") = item("PROJECT_ID")
                row("AREA_ID") = item("AREA_ID")
                row("COTI_ID") = item("COTI_ID")
                row("REQUI_ID") = item("REQUI_ID")
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                frmArticulo.dtdetalleArticulo.AcceptChanges()
            Next
            frmArticulo.ShowDialog()
            If frmArticulo.fl_close = False Then
                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                        dtdetalleArticuloPrincipal.BeginInit()
                        item("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                        item("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                        item("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                        item("UNIT_REFERENCE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT_REFERENCE")
                        item("FACTOR_REFERENCE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("FACTOR_REFERENCE")
                        item("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                        item("PRICE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRICE")
                        item("DISCOUNT_PER") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DISCOUNT_PER")
                        item("DISCOUNT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DISCOUNT")
                        item("AMOUNT_TAX") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AMOUNT_TAX")
                        item("PERCENT_TAX") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PERCENT_TAX")
                        item("PRICE_NET") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRICE_NET")
                        item("AMOUNT_TOTAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AMOUNT_TOTAL")
                        item("AMOUNT_TOTAL_NET") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AMOUNT_TOTAL_NET")
                        item("QTY_OUT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY_OUT")
                        item("STATUS_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("STATUS_ID")
                        item("COMMENT1") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COMMENT1")
                        item("TEXT_COMMENT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TEXT_COMMENT")
                        item("IS_VAT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IS_VAT")
                        item("PRICE_UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRICE_UNIT")
                        item("CCOST_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CCOST_ID")
                        item("PROJECT_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PROJECT_ID")
                        item("AREA_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AREA_ID")
                        item("COTI_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COTI_ID")
                        item("REQUI_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("REQUI_ID")
                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                    Next
                End If
            End If
            CalcularTotales()
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CalcularTotales()
        Try
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                txtDescuentos.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (DISCOUNT) ", ""), "0.00")
                txtvalorVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (AMOUNT_TOTAL) ", ""), "0.00")
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
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If gbcabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            gbcabecera.Enabled = False
        End If
        ModificandoArticulos()
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
                Codigo = dgvDetalles.Item(0, dgvDetalles.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
                CalcularTotales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
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
        DocumentosFormulacion()
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
            sql = "SAL_HLP_FIND_FORMA_COBRO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Forma de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
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
                        STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(3).Name
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
            DocumentosFormulacion()
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Clientes()
        End If
    End Sub

    Private Sub txtFormaPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFormaPago.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_FormaPago()
        End If
    End Sub

    Private Sub txtSolicitante_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSolicitante.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Solicitante()
        End If
    End Sub

    Private Sub txtresponsable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtresponsable.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Responsable()
        End If
    End Sub
End Class