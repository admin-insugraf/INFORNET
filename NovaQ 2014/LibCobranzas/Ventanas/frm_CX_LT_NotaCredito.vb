Imports System.Windows.Forms

Public Class frm_CX_LT_NotaCredito

    Private Sub frm_CX_LT_NotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_PuntosVentas()
        Call Cargar_Monedas()
        Call Cargar_Documentos()
        Call Iniciar_formulario()
    End Sub

    Private Sub Iniciar_formulario()
        cmb_ptovta.SelectedIndex = -1
    End Sub

    Private Sub Cargar_Monedas()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cmb_moneda.DataSource = monedaBL.get_Monedas()
        cmb_moneda.DisplayMember = "ID"
        cmb_moneda.ValueMember = "NAME"
        monedaBL = Nothing
    End Sub


    Private Sub Cargar_PuntosVentas()
        Dim puntosvtaBL As New ClsOperaciones.SALES_PLACE
        cmb_ptovta.DataSource = puntosvtaBL.get_PuntosVentas()
        cmb_ptovta.DisplayMember = "DES"
        cmb_ptovta.ValueMember = "COD"
        puntosvtaBL = Nothing
    End Sub

    Private Sub Ayuda_Clientes()
        Dim frm_clientes As New frm_CX_LT_BuscaClientes
        frm_clientes.ShowDialog()
        If frm_clientes.bol_aceptar Then

            txt_cod_cli.Text = frm_clientes.ls_cliente(0)
            txt_des_ane.Text = frm_clientes.ls_cliente(1)

            Dim clienteBL As New ClsOperaciones.CUSTOMER
            Dim clienteBE As New ClsEntidades.CUSTOMER
            clienteBE.ID = txt_cod_cli.Text.Trim
            clienteBL.get_Clientes_x_DocPer(clienteBE)
            txt_dir.Text = clienteBE.ADDR

            clienteBE = Nothing
            clienteBL = Nothing

        End If
        frm_clientes.Dispose()
    End Sub

    Private Sub Ayuda_Articulos()
        Dim frm_articulos As New frm_CX_LT_BuscaArticulos
        frm_articulos.ShowDialog()
        If frm_articulos.bol_aceptar Then
            Dim f As Integer = 0
            Dim cod_art As String = String.Empty
            Dim almacen As String = txt_cod_alm.Text.Trim

            dgv_detalle.Rows.Add()
            f = dgv_detalle.Rows.Count - 1
            cod_art = frm_articulos.ls_cliente(0)

            dgv_detalle.Rows(f).Cells("col_item").Value = dgv_detalle.Rows.Count
            dgv_detalle.Rows(f).Cells("col_cod").Value = cod_art
            dgv_detalle.Rows(f).Cells("col_des").Value = frm_articulos.ls_cliente(1)
            dgv_detalle.Rows(f).Cells("col_uni").Value = frm_articulos.ls_cliente(2)
            dgv_detalle.Rows(f).Cells("col_can").Value = 1
            dgv_detalle.Rows(f).Cells("col_pre").Value = 0
            dgv_detalle.Rows(f).Cells("col_tot").Value = 0

            dgv_detalle.Update()

            Dim loteBL As New ClsOperaciones.LOT
            Dim cmbcell As DataGridViewComboBoxCell
            Dim dt_lotes As DataTable = loteBL.get_Lote_x_Articulo(almacen, cod_art)
            cmbcell = dgv_detalle.Rows(f).Cells("col_lote")
            cmbcell.Items.Clear()

            For i As Integer = 0 To dt_lotes.Rows.Count - 1
                cmbcell.Items.Add(dt_lotes.Rows(i)("LOT_ID").ToString)
            Next

        End If
        frm_articulos.Dispose()
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentosBL As New ClsOperaciones.DOCUMENT_TYPE
        cmb_tdr.DataSource = documentosBL.get_Documentos_xCmb()
        cmb_tdr.ValueMember = "COD"
        cmb_tdr.DisplayMember = "DES"
        documentosBL = Nothing
    End Sub

    Private Sub Cargar_Series()
        If cmb_ptovta.SelectedValue Is Nothing Then Exit Sub
        Dim seriesBL As New ClsOperaciones.DOCUMENT_PLACE_SALES
        Dim puntoVtaBE As New ClsEntidades.SALES_PLACE

        puntoVtaBE.SALES_PLACE_ID = cmb_ptovta.SelectedValue.ToString
        cmb_sd.DataSource = seriesBL.get_Series(puntoVtaBE)
        cmb_sd.DisplayMember = "NUMBER_SERIE"
        cmb_sd.ValueMember = "OTRO"

        txt_cod_alm.Text = seriesBL.get_almacen_x_ptovta(puntoVtaBE)

        puntoVtaBE = Nothing
        seriesBL = Nothing

    End Sub

    Public Sub Cargar_Correlativo()

        If cmb_sd.SelectedValue Is Nothing Then Exit Sub

        Dim numeracionBL As New ClsOperaciones.NUMBER_DOCUMENT
        Dim numeracionBE As New ClsEntidades.NUMBER_DOCUMENT
        numeracionBE.TYPE_DOC = "NC"
        numeracionBE.NUMBER_SERIE = cmb_sd.SelectedValue.ToString
        txt_nd.Text = numeracionBL.get_Correlativos(numeracionBE).PadLeft(7, "0")
        numeracionBE = Nothing
        numeracionBL = Nothing
    End Sub

    Private Sub Cargar_TipoCambio()
        Dim tcBL As New ClsOperaciones.CURRENCY_EXCHANGE
        Dim tcBE As New ClsEntidades.CURRENCY_EXCHANGE
        tcBE.CURRENCY_ID = "ME"
        tcBE.CURRENCY_DATE = CDate(dtp_fecha_emi.Value).ToShortDateString
        mtb_tc.Text = tcBL.get_tipoCambio(tcBE)
        tcBE = Nothing
        tcBL = Nothing
    End Sub

    Private Sub Sumar_totales()

        Dim total As Double = 0
        For i As Integer = 0 To dgv_detalle.Rows.Count - 1
            total += dgv_detalle.Rows(i).Cells("col_tot").Value
        Next

        txt_subtotal.Text = Format(Math.Round(total, 2), "##,###.#0")
        txt_igv.Text = Format(Math.Round(total * gIGV, 2), "##,###.#0")
        txt_total.Text = Format(Math.Round(total + CDbl(txt_igv.Text), 2), "##,###.#0")

    End Sub

    Private Sub ReHacer_Secuencia()
        For i As Integer = 0 To dgv_detalle.Rows.Count - 1
            dgv_detalle.Rows(i).Cells("col_item").Value = (i + 1)
        Next
    End Sub

    Private Sub Eliminar_Fila()
        If dgv_detalle.Rows.Count = 0 Then Exit Sub
        If dgv_detalle.CurrentRow Is Nothing Then Exit Sub

        dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow)

        Call ReHacer_Secuencia()
        Call Sumar_totales()
    End Sub

    Private Sub Ayuda_Vendedor()
        Dim frm_ayuda As New frm_CX_LT_Ayuda
        frm_ayuda.p_ops = 1
        frm_ayuda.ShowDialog()
        If frm_ayuda.p_bol_aceptar Then
            txt_vededor.Text = frm_ayuda.p_ls_sel(0)
            txt_vededor.Focus()
        End If
    End Sub

    Private Sub Ayuda_FormaPago()
        Dim frm_ayuda As New frm_CX_LT_Ayuda
        frm_ayuda.p_ops = 2
        frm_ayuda.ShowDialog()
        If frm_ayuda.p_bol_aceptar Then
            txt_forma_pago.Text = frm_ayuda.p_ls_sel(0)
            txt_forma_pago.Focus()
        End If
    End Sub








    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub dtp_fecha_emi_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_emi.ValueChanged
        Call Cargar_TipoCambio()
    End Sub

    Private Sub cmb_ptovta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ptovta.SelectedIndexChanged
        Call Cargar_Series()
    End Sub

    Private Sub cmb_sd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_sd.SelectedIndexChanged
        Call Cargar_Correlativo()
    End Sub

    Private Sub txt_cod_cli_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod_cli.DoubleClick
        Call Ayuda_Clientes()
    End Sub

    Private Sub txt_cod_cli_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txt_cod_cli.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F2 Then
            Call Ayuda_Clientes()
        End If

        If e.KeyCode = Windows.Forms.Keys.Enter Then
            dtp_fecha_emi.Focus()
        End If
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If cmb_ptovta.SelectedIndex = -1 Then
            Avisar("Seleccione el punto de venta")
            cmb_ptovta.Focus()
            Exit Sub
        End If

        If cmb_sd.SelectedIndex = -1 Then
            Avisar("Ingrese la serie de la Nota de Credito")
            cmb_sd.Focus()
            Exit Sub
        End If

        If txt_nd.Text.Trim = "" Then
            Avisar("Falta el numero correlativo")
            Exit Sub
        End If

        If txt_cod_cli.Text.Trim = "" Then
            Avisar("Ingrese el codgio de cliente")
            txt_cod_cli.Focus()
            Exit Sub
        End If

        If txt_vededor.Text.Trim = "" Then
            Avisar("Falta ingresar el Vendedor")
            txt_vededor.Focus()
            Exit Sub
        End If

        If txt_forma_pago.Text.Trim = "" Then
            Avisar("Ingrese la forma de pago")
            txt_forma_pago.Focus()
            Exit Sub
        End If

        If cmb_tdr.SelectedIndex = -1 Then
            Avisar("Seleccione un tipo de documento de referencia")
            cmb_tdr.Focus()
            Exit Sub
        End If

        If txt_sdr.Text.Trim = "" Then
            Avisar("Ingrese el numero de documento de referencia")
            txt_sdr.Focus()
            Exit Sub
        End If

        If Val(mtb_tc.Text.ToString) = 0 Then
            Avisar("Ingrese el tipo de cambio")
            mtb_tc.Focus()
            Exit Sub
        End If

        If dgv_detalle.Rows.Count = 0 Then
            Avisar("Ingrese Items al detalle")
            Exit Sub
        End If


        Dim tipoDocNC As String = "NC"
        Dim cod_almacen As String = txt_cod_alm.Text.Trim
        Dim cabeceraBL As New ClsOperaciones.RECEIVABLE
        Dim cabeceraBE As New ClsEntidades.RECEIVABLE
        Dim carteraBE As New ClsEntidades.CUSTOMER_BALANCE
        Dim detalle As ClsEntidades.RECEIVABLE_LINE
        Dim ls_det As New List(Of ClsEntidades.RECEIVABLE_LINE)
        Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
        Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
        Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
        Dim numeracionBE As New ClsEntidades.NUMBER_DOCUMENT

        Try

            numeracionBE.TYPE_DOC = tipoDocNC
            numeracionBE.NUMBER_SERIE = cmb_sd.SelectedValue.ToString
            numeracionBE.LAST_NUMBER = CInt(txt_nd.Text.Trim)

            With cabeceraBE
                .DOCUMENT_ID = tipoDocNC
                .NUMBER_SERIE = cmb_sd.SelectedValue
                .NUMBER_DOCUMENT = txt_nd.Text.Trim
                .DOCUMENT_DATE = dtp_fecha_emi.Value
                .CADUCATE_DATE = dtp_fecha_emi.Value
                .DR_CR = ""
                .SALES_REP_ID = txt_vededor.Text.Trim
                .PLACE_SALES = cmb_ptovta.SelectedValue
                .NUMBER_QUOTE = 0
                .NUMBER_ORDER_PUR = 0
                .CFDESCPG = 0
                .POINT_ORIG = 0
                .POINT_BOARD = 0
                .POINT_ARRIVAL = 0
                .RECEIVABLE_TYPE = 0
                .CUSTOMER_ID = txt_cod_cli.Text.Trim
                .CUSTOMER_NAME = txt_des_ane.Text.Trim
                .CUSTOMER_ADDR = txt_dir.Text.Trim
                .VAT_REGISTRATION = txt_cod_cli.Text.Trim
                .WAREHOUSE_ID = cod_almacen
                .AMOUNT = txt_total.Text.Trim
                .TERMS_ID = txt_forma_pago.Text.Trim
                .BALANCE = 0
                .SELL_RATE = CDbl(mtb_tc.Text)
                .CURRENCY_ID = cmb_moneda.SelectedValue
                .DOCUMENT_REF = cmb_tdr.SelectedValue
                .SERIE_REF = txt_sdr.Text.Trim
                .NUMBER_REF = txt_ndr.Text.Trim
                .NUMBER_ORDER = 0
                .CREATE_DATE = Date.Now.ToShortDateString
                .LAST_MODIFIED = Date.Now.ToShortDateString
                .STATUS = "1"
                .USER_ID = gUsuarioSis
                .COMMENT = txt_comen.Text.Trim
                .IS_GUIA_REC = 0
                .NUMBER_REGISTRATION = 0
                .DISCOUNT_PERCENT = 0
                .CARD_ID = 0
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
                .AMOUNT_TAX = txt_igv.Text.Trim
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
            End With

            With carteraBE
                .CUSTOMER_ID = txt_cod_cli.Text.Trim
                .DOCUMENT_ID = tipoDocNC
                .NUMBER_DOC = cmb_sd.Text & "" & txt_nd.Text.Trim
                .DOC_DATE = CDate(dtp_fecha_emi.Text).ToShortDateString
                .CADUCATE_DATE = CDate(dtp_fecha_emi.Text).ToShortDateString
                .DOCUMENT_REF = cmb_tdr.SelectedValue
                .NUMBER_REF = txt_sdr.Text & txt_ndr.Text.Trim
                .SALES_ID = txt_vededor.Text.Trim
                .AMOUNT = CDbl(txt_total.Text.Trim) * -1
                .AMOUNT_BALANCE = CDbl(txt_total.Text.Trim) * -1
                .CURRENCY_ID = cmb_moneda.SelectedValue
                .SELL_RATE = CDbl(mtb_tc.Text)
                .IS_DR_CR = 0
                .STATUS = "1"
                .CREATE_DATE = Date.Now.ToShortDateString
                .LAST_MODIFIED = Date.Now.ToShortDateString
                .USER_ID = gUsuarioSis
                .ACCOUNT = ""
                .AMOUNT_COMM = 0
                .TYPE_REC = 0
                .REFERENCE_DATE = Date.Now.ToShortDateString
                .IS_CHECK_DIF = 0
                .AMOUNT_BALANCE_INI = CDbl(txt_total.Text.Trim) * -1
                .TERMS = 0
                .PLACE_SALES = cmb_ptovta.SelectedValue
                .BANK_ID = 0
                .BANK_DESCRIPTION = 0
                .AMOUNT_PER = 0
                .PERCENT_PER = 0
                .ACCOUNT_PER = 0
                .CUST_AUTO = 0
                .SERIE_AUX = cmb_sd.SelectedValue
                .NUM_DOC_AUX = txt_nd.Text.Trim
            End With

            For i As Integer = 0 To dgv_detalle.Rows.Count - 1
                detalle = New ClsEntidades.RECEIVABLE_LINE
                With detalle
                    .DOCUMENT_ID = tipoDocNC
                    .NUMBER_SERIE = cmb_sd.SelectedValue
                    .NUMBER_DOCUMENT = txt_nd.Text.Trim
                    .ITEM = dgv_detalle.Rows(i).Cells("col_item").Value
                    .PART_ID = dgv_detalle.Rows(i).Cells("col_cod").Value
                    .QTY = dgv_detalle.Rows(i).Cells("col_can").Value
                    .PRICE_SALES = (dgv_detalle.Rows(i).Cells("col_pre").Value) * -1
                    .PRICE_ORI = (dgv_detalle.Rows(i).Cells("col_pre").Value) * -1
                    .DISCOUNT = 0
                    .AMOUNT_TAX = (.PRICE_ORI / 1.18) * -1
                    .TAX_PERCENT = 18
                    .AMOUNT_US = (dgv_detalle.Rows(i).Cells("col_tot").Value / CDbl(mtb_tc.Text)) * -1
                    .AMOUNT = (dgv_detalle.Rows(i).Cells("col_tot").Value) * -1
                    .UNIT = dgv_detalle.Rows(i).Cells("col_uni").Value
                    .STATUS = "1"
                    .PART_SERIE = 0
                    .WAREHOUSE_ID = cod_almacen
                    .TEXT_DESCRIPTION = ""
                    .DFTR = 0
                    .STOCK = 0
                    .PART_DESCRIPTION = dgv_detalle.Rows(i).Cells("col_des").Value
                    .QTY_REF = 0
                    .DISCOUNT_PERCENT = 0
                    .BALANCE_PART = 0
                    .DISCOUNT_CUSTOMER = 0
                    .DISCOUNT_SP = 0
                    .PART_LOT = dgv_detalle.Rows(i).Cells("col_lote").Value
                    .NUMBER_GUIA = 0
                    .PART_TAX = 0
                    .DISCOUNT1 = 0
                    .DISCOUNT2 = 0
                    .PERCENT1 = 0
                    .PERCENT2 = 0
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

            'la parte de almacen

            With alm_cabBE
                .WAREHOUSE_ID = cod_almacen
                .DOCUMENT_ID = tipoDocNC
                .NUMBER_DOCUMENT = cmb_sd.SelectedValue.ToString & txt_nd.Text.Trim
                .DATE_DOCUMENT = CDate(dtp_fecha_emi.Value).ToShortDateString
                .TYPE_TRANS = "I"
                .TRANS_ID = "FT"
                .DOC_ID_REF = cmb_tdr.SelectedValue.ToString
                .NUM_ID_REF = txt_sdr.Text.Trim & txt_ndr.Text.Trim
                .HOUR = Date.Now.Hour.ToString
                .USER_ID = gUsuarioSis
                .CUSTOMER_ID = txt_cod_cli.Text.Trim
                .VAT_REGISTRATION = txt_cod_cli.Text.Trim
                .CUSTOMER_NAME = txt_des_ane.Text.Trim
                .SALES_TERM = txt_forma_pago.Text.Trim
                .CURRENCY_TYPE = cmb_moneda.SelectedValue
                .CURRENCY_EXCHANGE = CDbl(mtb_tc.Text)
                .STATUS_GUIA = "F"
                .AMOUNT = CDbl(txt_total.Text.Trim) * -1
            End With

            For i As Integer = 0 To dgv_detalle.Rows.Count - 1
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE
                    .WAREHOUSE_ID = cod_almacen
                    .DOCUMENT_ID = tipoDocNC
                    .NUMBER_DOCUMENT = cmb_sd.SelectedValue.ToString & txt_nd.Text.Trim
                    .ITEM = dgv_detalle.Rows(i).Cells("col_item").Value
                    .PART_ID = dgv_detalle.Rows(i).Cells("col_cod").Value
                    .QTY = dgv_detalle.Rows(i).Cells("col_can").Value
                    .QTY_DLV = 0
                    .QTY_REF = dgv_detalle.Rows(i).Cells("col_can").Value
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .PART_DESCRIPTION = dgv_detalle.Rows(i).Cells("col_des").Value
                    .UNIT_PART = dgv_detalle.Rows(i).Cells("col_uni").Value
                    .NUMBER_LOT = dgv_detalle.Rows(i).Cells("col_lote").Value
                End With
                ls_det_alm.Add(alm_detBE)
            Next


            cabeceraBL.Insert(cabeceraBE, ls_det, carteraBE, alm_cabBE, ls_det_alm, numeracionBE)

            Call Avisar("Listo!")

            If Preguntar("Desea ingresar otra Nota d Credito?") Then

            End If

        Catch ex As Exception
            Call Avisar("Error al intentar Grabar!")
        End Try
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Call Ayuda_Articulos()
    End Sub

    Private Sub dgv_detalle_RowValidated(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgv_detalle.RowValidated
        If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Then
            Dim subtotal As Double = 0
            Dim can As Double = dgv_detalle.CurrentRow.Cells("col_can").Value
            Dim precio As Double = dgv_detalle.CurrentRow.Cells("col_pre").Value
            subtotal = Math.Round(can * precio, 2)
            dgv_detalle.CurrentRow.Cells("col_tot").Value = subtotal
        End If
        Call Sumar_totales()
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        Call Eliminar_Fila()
    End Sub


    Private Sub txt_vededor_DoubleClick(sender As Object, e As EventArgs) Handles txt_vededor.DoubleClick
        Call Ayuda_Vendedor()
    End Sub

    Private Sub txt_vededor_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txt_vededor.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F2 Then
            Call Ayuda_Vendedor()
        End If

        If e.KeyCode = Windows.Forms.Keys.Enter Then
            txt_comen.Focus()
        End If
    End Sub

    Private Sub txt_forma_pago_DoubleClick(sender As Object, e As EventArgs) Handles txt_forma_pago.DoubleClick
        Call Ayuda_FormaPago()
    End Sub

    Private Sub txt_forma_pago_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txt_forma_pago.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F2 Then
            Call Ayuda_FormaPago()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_sdr_Leave(sender As Object, e As EventArgs) Handles txt_sdr.Leave
        txt_sdr.Text = txt_sdr.Text.PadLeft(3, "0")
    End Sub

    Private Sub txt_ndr_Leave(sender As Object, e As EventArgs) Handles txt_ndr.Leave
        txt_ndr.Text = txt_ndr.Text.PadLeft(7, "0")
    End Sub

    Private Sub cmb_tdr_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles cmb_tdr.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            txt_sdr.Focus()
        End If
    End Sub

    Private Sub txt_sdr_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txt_sdr.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            txt_ndr.Focus()
        End If
    End Sub

    Private Sub txt_ndr_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txt_ndr.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            txt_vededor.Focus()
        End If
    End Sub

    Private Sub dgv_detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalle.CellContentClick

    End Sub
End Class