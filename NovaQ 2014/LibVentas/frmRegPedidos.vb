Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Public Class frmRegPedidos
    Private frmHelp As frmAyudaVar
    Private frmDetalle As frmValoresDetalle
    Private cVenta As ClsAyudas
    Private cProcesos As ClsProcesos
    Private cConsulta As ClsConsultas
    Private dtPedido As DataTable
    Private dtDetPed As DataTable
    Private dtListPed As DataTable
    Private dtTipoDoc As DataTable
    Private dtSerieDoc As DataTable
    Private dtSerieGuia As DataTable
    Private dtDirCliente As DataTable
    Private DBLTotValorVenta As Double = 0
    Private DBLTotISC As Double = 0
    Private DBLTotIGV As Double = 0
    Private DBLTotPrecioVenta As Double = 0
    Private STRAccion As String = String.Empty
    Private CRep As LibReportes.ClsReporte

    Private Sub txtPtoVenta_DoubleClick(sender As Object, e As EventArgs) Handles txtPtoVenta.DoubleClick
        frmHelp = New frmAyudaVar
        With frmHelp
            .Titulo = "Puntos de venta"
            .TipoAyuda = frmAyudaVar.STipoAyuda.PtoVenta
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                txtPtoVenta.Text = .Data_Matriz.Rows(0).Item(0)
                txtAlmacen.Text = .Data_Matriz.Rows(0).Item(2)
                lblPtoVenta.Text = .Data_Matriz.Rows(0).Item(1)
                lblAlmacen.Text = .Data_Matriz.Rows(0).Item(3)
            End If
        End With
    End Sub

    Private Sub txtPtoVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPtoVenta.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtPtoVenta_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub txtCodCliente_DoubleClick(sender As Object, e As EventArgs) Handles txtCodCliente.DoubleClick
        frmHelp = New frmAyudaVar
        With frmHelp
            .Titulo = "Listado de clientes"
            .TipoAyuda = frmAyudaVar.STipoAyuda.Clientes
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                txtCodCliente.Text = .Data_Matriz.Rows(0).Item(0)
                txtRazonSocial.Text = .Data_Matriz.Rows(0).Item(1)
                txtRucDni.Text = .Data_Matriz.Rows(0).Item(2)
                txtDireccion.Text = .Data_Matriz.Rows(0).Item(3)
                txtVendedor.Text = .Data_Matriz.Rows(0).Item(4)
                If txtVendedor.Text.Trim.Length > 0 Then Call txtVendedor_LostFocus(sender, e)
                txtFormaPago.Text = .Data_Matriz.Rows(0).Item(5)
                If txtFormaPago.Text.Trim.Length > 0 Then Call txtFormaPago_LostFocus(sender, e)
            End If
        End With
    End Sub

    Private Sub txtVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVendedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtVendedor_LostFocus(sender As Object, e As EventArgs) Handles txtVendedor.LostFocus
        If txtVendedor.Text.Trim.Length > 0 Then
            cVenta = New ClsAyudas
            lblVendedor.Text = cVenta.get_Dato_Vendedor(txtVendedor.Text)
            cVenta = Nothing
        Else
            lblVendedor.Text = ""
        End If
    End Sub

    Private Sub frmRegPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cVenta = New ClsAyudas
        dtTable = cVenta.get_List_Monedas

        cboMoneda.DataSource = dtTable
        cboMoneda.ValueMember = dtTable.Columns(0).ToString
        cboMoneda.DisplayMember = dtTable.Columns(0).ToString
        cboMoneda.SelectedIndex = -1

        cVenta = Nothing

        Call Estructura_Detalle()
        txtTipoCambio.Text = ClsVarComun.TCVenta

        dtFechaIni.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtFechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)


        tcPedidos.TabPages.Remove(tpGenerar)
        Call btnBuscar_Click(sender, e)

    End Sub

    Private Sub Estructura_Detalle()
        dtDetPed = New DataTable("DetPedido")
        dtDetPed.Columns.Add("Codigo", Type.GetType("System.String"))
        dtDetPed.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtDetPed.Columns.Add("Unidad", Type.GetType("System.String"))
        dtDetPed.Columns.Add("Lote", Type.GetType("System.String"))
        dtDetPed.Columns.Add("Serie", Type.GetType("System.String"))

        dtDetPed.Columns.Add("Cantidad", Type.GetType("System.Double"))
        dtDetPed.Columns.Add("Precio", Type.GetType("System.Double"))
        dtDetPed.Columns.Add("Importe", Type.GetType("System.Double"))
        dtDetPed.Columns.Add("Igv", Type.GetType("System.Double"))
        dtDetPed.Columns.Add("IgvPor", Type.GetType("System.Double"))
        dtDetPed.Columns.Add("Isc", Type.GetType("System.Double"))
        dtDetPed.Columns.Add("IscPor", Type.GetType("System.Double"))

        dtDetPed.Columns.Add("PrecioCalculo", Type.GetType("System.Double"))
        dtDetPed.Columns.Add("ValorVenta", Type.GetType("System.Double"))

        dtDetPed.Columns.Add("IsLote", Type.GetType("System.String"))
        dtDetPed.Columns.Add("IsSerie", Type.GetType("System.String"))
        dtDetPed.Columns.Add("Item", Type.GetType("System.Int16"))
        dgwDetallePed.DataSource = dtDetPed
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim BOLSinIGV As Boolean = False
        Dim DBLPrecio As Double = 0, DBLPrecioCalculo As Double = 0

        If chkSinIGV.Checked = True Then BOLSinIGV = True Else BOLSinIGV = False

        Dim DBLStock As Double = 0

        frmHelp = New frmAyudaVar
        With frmHelp
            .Titulo = "Listado de productos"
            .CodAlmacen = txtAlmacen.Text.Trim
            .TipoAyuda = frmAyudaVar.STipoAyuda.Articulos
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then

                Dim myFila As DataRow = dtDetPed.NewRow
                myFila("Codigo") = .Data_Matriz.Rows(0).Item(0)
                myFila("Descripcion") = .Data_Matriz.Rows(0).Item(1)
                myFila("Unidad") = .Data_Matriz.Rows(0).Item(2)

                myFila("IsLote") = .Data_Matriz.Rows(0).Item("IS_LOT")
                myFila("IsSerie") = .Data_Matriz.Rows(0).Item("SERIES")
                myFila("IgvPor") = .Data_Matriz.Rows(0).Item("VAT_POR")
                myFila("IscPor") = IIf(.Data_Matriz.Rows(0).Item("ISCPOR").ToString = String.Empty, 0, .Data_Matriz.Rows(0).Item("ISCPOR"))
                DBLStock = IIf(.Data_Matriz.Rows(0).Item("QTY_ON_HAND").ToString = String.Empty, 0, .Data_Matriz.Rows(0).Item("QTY_ON_HAND"))

                'Pido cantidades y lote/serie si fuera el caso
                frmDetalle = New frmValoresDetalle
                With frmDetalle
                    .Codigo = myFila("Codigo")
                    .Descripcion = myFila("Descripcion")
                    .EsLote = myFila("IsLote")
                    .EsSerie = myFila("IsSerie")
                    .Almacen = txtAlmacen.Text.Trim
                    .Stock = DBLStock
                    .ShowDialog()
                    If .EsOK = True Then
                        myFila("Cantidad") = .Cantidad
                        myFila("Precio") = .Precio
                        myFila("Lote") = .Lote
                        myFila("Serie") = .Serie
                        If BOLSinIGV = False Then
                            DBLPrecioCalculo = Math.Round(.Precio / (1 + myFila("IgvPor") / 100), 6)
                            myFila("PrecioCalculo") = DBLPrecioCalculo
                            myFila("Importe") = Math.Round(.Cantidad * .Precio, 6)
                            MsgBox(myFila("IscPor"))


                            myFila("ValorVenta") = Math.Round((myFila("Importe") / (1 + myFila("IgvPor") / 100)) / ((1 + myFila("IscPor") / 100)), 6)
                            myFila("Igv") = Math.Round(myFila("Importe") - (myFila("Importe") / (1 + myFila("IgvPor") / 100)), 6)
                            myFila("Isc") = Math.Round((myFila("Importe") / (1 + myFila("IgvPor") / 100)) - (myFila("Importe") / (1 + myFila("IgvPor") / 100)) / ((1 + myFila("IscPor") / 100)), 6)
                        End If
                        myFila("Item") = dgwDetallePed.Rows.Count + 1

                        dtDetPed.Rows.Add(myFila)
                        dtDetPed.AcceptChanges()
                        dgwDetallePed.CurrentCell = dgwDetallePed.Item("Cantidad", dgwDetallePed.Rows.Count - 1)
                        Call CalculaTotales()
                    End If
                End With
            End If
        End With
    End Sub

    Private Sub CalculaTotales()
        If dtDetPed.Rows.Count > 0 Then
            DBLTotValorVenta = Math.Round(dtDetPed.Compute("Sum(ValorVenta)", ""), 6)
            DBLTotISC = Math.Round(dtDetPed.Compute("Sum(Isc)", ""), 6)
            DBLTotIGV = Math.Round(dtDetPed.Compute("Sum(Igv)", ""), 6)
            DBLTotPrecioVenta = Math.Round(DBLTotValorVenta + DBLTotISC + DBLTotIGV, 6)
        Else
            DBLTotValorVenta = Math.Round(0, 6)
            DBLTotISC = Math.Round(0, 6)
            DBLTotIGV = Math.Round(0, 6)
            DBLTotPrecioVenta = Math.Round(0, 6)
        End If

        txtValorVenta.Text = Math.Round(DBLTotValorVenta, 2)
        txtIGV.Text = Math.Round(DBLTotIGV, 2)
        txtISC.Text = Math.Round(DBLTotISC, 2)
        txtPrecioVenta.Text = Math.Round(DBLTotPrecioVenta, 2)
    End Sub

    Private Sub dgwDetallePed_DoubleClick(sender As Object, e As EventArgs) Handles dgwDetallePed.DoubleClick
        If dgwDetallePed.RowCount > 0 Then
            If MsgBox("¿Desea modificar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Aviso") = MsgBoxResult.Yes Then
                frmDetalle = New frmValoresDetalle
                Dim INTFila As Int16 = dgwDetallePed.CurrentRow.Index
                Dim INTitem As Int16 = Convert.ToInt16(dtDetPed.Rows(INTFila).Item("Item"))
                Dim BOLSinIGV As Boolean = False
                Dim DBLPrecio As Double = 0, DBLPrecioCalculo As Double = 0
                If chkSinIGV.Checked = True Then BOLSinIGV = True Else BOLSinIGV = False

                With frmDetalle
                    .Codigo = dtDetPed.Rows(INTFila).Item("Codigo").ToString
                    .Descripcion = dtDetPed.Rows(INTFila).Item("Descripcion").ToString
                    .Precio = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("Precio").ToString)
                    .Cantidad = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("Cantidad").ToString)
                    .Lote = dtDetPed.Rows(INTFila).Item("Lote").ToString
                    .Serie = dtDetPed.Rows(INTFila).Item("Serie").ToString
                    .ShowDialog()
                    If .EsOK = True Then
                        Dim result() As DataRow = dtDetPed.Select("Item=" & INTitem)
                        If result(0) IsNot Nothing Then
                            result(0)("Cantidad") = .Cantidad
                            result(0)("Precio") = .Precio
                            result(0)("Lote") = .Lote
                            result(0)("Serie") = .Serie
                            If BOLSinIGV = False Then
                                DBLPrecioCalculo = Math.Round(.Precio / (1 + result(0)("IgvPor") / 100), 6)
                                result(0)("PrecioCalculo") = DBLPrecioCalculo
                                result(0)("Importe") = Math.Round(.Cantidad * .Precio, 6)
                                result(0)("ValorVenta") = Math.Round((result(0)("Importe") / (1 + result(0)("IgvPor") / 100)) / ((1 + result(0)("IscPor") / 100)), 6)
                                result(0)("Igv") = Math.Round(result(0)("Importe") - (result(0)("Importe") / (1 + result(0)("IgvPor") / 100)), 6)
                                result(0)("Isc") = Math.Round((result(0)("Importe") / (1 + result(0)("IgvPor") / 100)) - (result(0)("Importe") / (1 + result(0)("IgvPor") / 100)) / ((1 + result(0)("IscPor") / 100)), 6)
                            End If
                            dtDetPed.AcceptChanges()
                            Call CalculaTotales()
                        End If
                    End If
                End With
            End If
        End If
    End Sub


    Private Sub dgwDetallePed_KeyDown(sender As Object, e As KeyEventArgs) Handles dgwDetallePed.KeyDown
        Dim iColumna As Int16, iFila As Int16

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            iColumna = dgwDetallePed.CurrentCell.ColumnIndex
            iFila = dgwDetallePed.CurrentCell.RowIndex


            If (iColumna = dgwDetallePed.Columns.Count - 1) Then
                If iFila < dgwDetallePed.Rows.Count - 1 Then
                    dgwDetallePed.CurrentCell = dgwDetallePed(0, iFila + 1)
                End If
            Else
                dgwDetallePed.CurrentCell = dgwDetallePed(iColumna + 1, iFila)
            End If
        End If

    End Sub

    Private Sub tGrabar_Click(sender As Object, e As EventArgs) Handles tGrabar.Click
        If STRAccion = "P" Then
            If txtPtoVenta.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe elegir el punto de venta.", "Aviso", MessageBoxButtons.OK)
                txtPtoVenta.Focus()
                Exit Sub
            ElseIf txtAlmacen.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe elegir el almacén.", "Aviso", MessageBoxButtons.OK)
                txtAlmacen.Focus()
                Exit Sub
            ElseIf Format(dtFechaEmision.Value, "Short Date") > Format(dtFechaEntrega.Value, "Short Date") Then
                MessageBox.Show("La fecha de emisión no puede ser mayor a la fecha de entrega.", "Aviso", MessageBoxButtons.OK)
                dtFechaEmision.Focus()
                Exit Sub
            ElseIf txtCodCliente.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe elegir el código del cliente.", "Aviso", MessageBoxButtons.OK)
                txtCodCliente.Focus()
                Exit Sub
            ElseIf txtRucDni.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar el número de documento.", "Aviso", MessageBoxButtons.OK)
                txtRucDni.Focus()
                Exit Sub
            ElseIf txtRazonSocial.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar la razón social y/o nombre del cliente.", "Aviso", MessageBoxButtons.OK)
                txtRazonSocial.Focus()
                Exit Sub
            ElseIf txtDireccion.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar la dirección del cliente.", "Aviso", MessageBoxButtons.OK)
                txtDireccion.Focus()
                Exit Sub
            ElseIf txtVendedor.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe elegir el código del vendedor.", "Aviso", MessageBoxButtons.OK)
                txtVendedor.Focus()
                Exit Sub
            ElseIf cboMoneda.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir la moneda para el pedido.", "Aviso", MessageBoxButtons.OK)
                cboMoneda.Focus()
                Exit Sub
            ElseIf txtTipoCambio.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar el tipo de cambio.", "Aviso", MessageBoxButtons.OK)
                txtTipoCambio.Focus()
                Exit Sub
            ElseIf txtFormaPago.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe elegir la forma de pago.", "Aviso", MessageBoxButtons.OK)
                txtFormaPago.Focus()
                Exit Sub
            ElseIf dtDetPed.Rows.Count = 0 Then
                MessageBox.Show("No ha ingresado ningún producto para el pedido.", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If

            If MessageBox.Show("¿Desea grabar el pedido?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim cCabPedido As New ClsPedidosTO.Cab_Pedidos_TO
                Dim cDetPedido As New List(Of ClsPedidosTO.Det_Pedidos_TO)
                Dim cFilPedido As ClsPedidosTO.Det_Pedidos_TO
                Dim STRNumeroPedido As String = String.Empty

                With cCabPedido
                    .NumPedido = STRNumeroPedido
                    .FechaPedido = dtFechaEmision.Value
                    .FechaVencimiento = dtFechaEntrega.Value
                    .CodVendedor = txtVendedor.Text.Trim
                    .PtoVenta = txtPtoVenta.Text.Trim
                    .CodCliente = txtCodCliente.Text.Trim
                    .NomCliente = txtRazonSocial.Text.Trim
                    .Direccion = txtDireccion.Text.Trim
                    .Ruc = txtRucDni.Text.Trim
                    .PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text.Trim)
                    .FormaPago = txtFormaPago.Text.Trim
                    .TipoCambio = Convert.ToDouble(txtTipoCambio.Text.Trim)
                    .CodMoneda = cboMoneda.SelectedValue
                    .Estado = "V"
                    .CodUsuario = ""
                    .Comentario = txtGlosa.Text.Trim
                    .ValorIGV = Convert.ToDouble(txtIGV.Text.Trim)
                    .ValorISC = Convert.ToDouble(txtISC.Text.Trim)
                    .EstatusPedido = "EMITIDO"
                End With

                Dim INTFila As Int16
                For INTFila = 0 To dtDetPed.Rows.Count - 1
                    cFilPedido = New ClsPedidosTO.Det_Pedidos_TO
                    With cFilPedido
                        .Item = String.Format(INTFila + 1, "{0:000}")
                        .CodParte = dtDetPed.Rows(INTFila).Item("Codigo").ToString
                        .DescripcionParte = dtDetPed.Rows(INTFila).Item("Descripcion").ToString
                        .Cantidad = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("Cantidad").ToString)
                        .Precio = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("Precio").ToString)
                        .PrecioCalculo = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("PrecioCalculo").ToString)
                        .MontoIGV = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("Igv").ToString)
                        .PorIGV = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("IgvPor").ToString)
                        .MontoISC = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("Isc").ToString)
                        .PorISC = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("IscPor").ToString)
                        If cboMoneda.SelectedValue = "MN" Then
                            .MontoSoles = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("ValorVenta").ToString)
                            .MontoDolares = Math.Round(Convert.ToDouble(dtDetPed.Rows(INTFila).Item("ValorVenta").ToString) / Convert.ToDouble(txtTipoCambio.Text), 6)
                        Else
                            .MontoDolares = Convert.ToDouble(dtDetPed.Rows(INTFila).Item("ValorVenta").ToString)
                            .MontoSoles = Math.Round(Convert.ToDouble(dtDetPed.Rows(INTFila).Item("ValorVenta").ToString) * Convert.ToDouble(txtTipoCambio.Text), 6)
                        End If
                        .CodAlmacen = txtAlmacen.Text.Trim
                        .SerieLote = String.Empty
                        If dtDetPed.Rows(INTFila).Item("IsLote").ToString = "S" Then
                            .SerieLote = dtDetPed.Rows(INTFila).Item("Lote").ToString
                        End If
                        If dtDetPed.Rows(INTFila).Item("IsSerie").ToString = "S" Then
                            .SerieLote = dtDetPed.Rows(INTFila).Item("Serie").ToString
                        End If
                        .UniMed = dtDetPed.Rows(INTFila).Item("Unidad").ToString
                        cDetPedido.Add(cFilPedido)
                    End With
                Next

                cProcesos = New ClsProcesos
                If cProcesos.Inserta_Pedido(cCabPedido, cDetPedido, STRNumeroPedido) = True Then
                    MessageBox.Show("Se generó el pedido número: " & STRNumeroPedido, "Generación de pedido", MessageBoxButtons.OK)
                    If MessageBox.Show("¿Desea imprimir el pedido?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        CRep = New ClsReporte
                        CRep.Muestra_Reporte("Sal_Orders.rpt", "", "@ID;" & STRNumeroPedido)
                        CRep = Nothing
                    End If
                    Call Limpiar()
                    txtPtoVenta.Focus()
                End If
                cProcesos = Nothing
            End If
        End If

        If STRAccion = "F" Then
            If cbTipoDoc.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir el tipo de documento a facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbTipoDoc.Focus()
                Exit Sub
            ElseIf cbSerieDoc.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir la serie para el documento a facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbSerieDoc.Focus()
                Exit Sub
            ElseIf cbSerieGuia.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir la serie para la guía de remisión.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbSerieGuia.Focus()
                Exit Sub
            ElseIf txtCodTrans.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar el código de transportista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodTrans.Focus()
                Exit Sub
            ElseIf cbDirEntrega.Items.Count > 0 Then
                If cbDirEntrega.SelectedIndex = -1 Then
                    MessageBox.Show("Debe elegir la dirección de entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cbDirEntrega.Focus()
                    Exit Sub
                End If
            End If

            Dim STRNumFactura As String = String.Empty
            Dim STRNumGuia As String = String.Empty
            Dim STRDirEntrega As String = String.Empty

            Dim STRTipoDoc As String = cbTipoDoc.SelectedValue
            Dim STRSerieDoc As String = cbSerieDoc.SelectedValue
            Dim STRSerieGuia As String = cbSerieGuia.SelectedValue

            If cbDirEntrega.SelectedIndex <> -1 Then
                STRDirEntrega = cbDirEntrega.SelectedValue
            Else
                STRDirEntrega = txtDireccion.Text.Trim
            End If

            cProcesos = New ClsProcesos
            If cProcesos.Factura_Pedido(lblNumPedido.Text, STRTipoDoc, STRSerieDoc, STRSerieGuia, _
                                        STRNumFactura, txtCodTrans.Text.Trim, txtPtoVenta.Text.Trim, _
                                        txtGlosaDoc.Text.Trim, txtAlmacen.Text.Trim, cboMoneda.SelectedValue, txtTipoCambio.Text, STRDirEntrega) = True Then
                Dim STRDocGen() As String = Split(STRNumFactura, "|")

                STRNumFactura = STRTipoDoc & " " & STRSerieDoc & STRDocGen(0)
                STRNumGuia = "GS" & " " & STRSerieGuia & STRDocGen(1)
                MessageBox.Show("Se generaron los siguientes documentos:" & vbCrLf & _
                                STRNumFactura & vbCrLf & STRNumGuia, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Limpiar()
                Call tCancelar_Click(sender, e)
                Call btnBuscar_Click(sender, e)
            End If

            cProcesos = Nothing

        End If

    End Sub
    Private Sub Limpiar()
        txtPtoVenta.Clear()
        txtAlmacen.Clear()
        dtFechaEmision.Value = Now
        dtFechaEntrega.Value = Now
        txtCodCliente.Clear()
        txtRucDni.Clear()
        txtRazonSocial.Clear()
        txtDireccion.Clear()
        txtVendedor.Clear()
        cboMoneda.SelectedIndex = -1
        txtTipoCambio.Clear()
        txtFormaPago.Clear()
        txtGlosa.Clear()
        chkSinIGV.Checked = False
        dtDetPed.Clear()
        txtValorVenta.Clear()
        txtIGV.Clear()
        txtISC.Clear()
        txtPrecioVenta.Clear()
        lblVendedor.Text = String.Empty
        lblAlmacen.Text = String.Empty
        lblFormaPago.Text = String.Empty
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Format(dtFechaIni.Value, "Short Date") > Format(dtFechaFin.Value, "Short Date") Then
            MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtFechaIni.Focus()
            Exit Sub
        End If
        cConsulta = New ClsConsultas
        dtListPed = New DataTable
        dtListPed = cConsulta.get_Lista_Pedidos(Format(dtFechaIni.Value, "Short Date"), Format(dtFechaFin.Value, "Short Date"))
        dgwListaPedidos.DataSource = dtListPed

        If dgwListaPedidos.RowCount > 0 Then
            dgwListaPedidos.ContextMenuStrip = cmPedidos
        End If
        cConsulta = Nothing
    End Sub

    Private Sub tNuevo_Click(sender As Object, e As EventArgs) Handles tNuevo.Click
        STRAccion = "P"
        tcPedidos.TabPages.Insert(1, tpGenerar)
        tcPedidos.SelectTab(1)
        tcPedidos.TabPages.Remove(tpLista)
        gbDatosGuia.Visible = False
        lblNumPedido.Visible = False
        txtPtoVenta.Focus()
        Me.Text = "Generación de pedidos"
    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        If dgwListaPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay pedidos por aprobar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STRPedido As String = String.Empty
        Dim STREstado As String = String.Empty

        STRPedido = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(8).Value

        If STREstado = "AUTORIZADO" Then
            MessageBox.Show("El pedido ya se encuentra autorizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "ANULADO" Then
            MessageBox.Show("El pedido se encuentra anulado, no puede aprobarse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea aprobar el pedido " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If STREstado = "EMITIDO" Then
                cProcesos = New ClsProcesos
                If cProcesos.Actualiza_Status_Pedido(STRPedido, "AUTORIZADO") = True Then
                    MessageBox.Show("Pedido autorizado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call btnBuscar_Click(sender, e)
                End If
                cProcesos = Nothing
            End If
        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If dgwListaPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay pedidos por anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STRPedido As String = String.Empty
        Dim STREstado As String = String.Empty

        STRPedido = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(8).Value

        If STREstado = "AUTORIZADO" Then
            MessageBox.Show("El pedido ya se encuentra autorizado, no puede anularse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "ANULADO" Then
            MessageBox.Show("El pedido ya se encuentra anulado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea anular el pedido " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If STREstado = "EMITIDO" Then
                cProcesos = New ClsProcesos
                If cProcesos.Actualiza_Status_Pedido(STRPedido, "ANULADO") = True Then
                    MessageBox.Show("Pedido anulado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call btnBuscar_Click(sender, e)
                End If
                cProcesos = Nothing
            End If
        End If
    End Sub

    Private Sub dgwListaPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwListaPedidos.CellContentClick

    End Sub

    Private Sub Muestra_Pedido(ByVal STRNumPedido)
        dtPedido = New DataTable
        cConsulta = New ClsConsultas
        dtPedido = cConsulta.get_Pedido(STRNumPedido)

        'Cabecera
        txtPtoVenta.Text = dtPedido.Rows(0).Item("PLACE_SALES").ToString
        txtAlmacen.Text = dtPedido.Rows(0).Item("WAREHOUSE_ID").ToString
        dtFechaEmision.Value = dtPedido.Rows(0).Item("ORDER_DATE").ToString
        dtFechaEntrega.Value = dtPedido.Rows(0).Item("CADUCATE_DATE").ToString
        txtCodCliente.Text = dtPedido.Rows(0).Item("CUSTOMER_ID").ToString
        txtRucDni.Text = dtPedido.Rows(0).Item("VAT_REGISTRATION").ToString
        txtRazonSocial.Text = dtPedido.Rows(0).Item("CUSTOMER_NAME").ToString
        txtDireccion.Text = dtPedido.Rows(0).Item("CUSTOMER_ADDR").ToString
        txtVendedor.Text = dtPedido.Rows(0).Item("SALES_ID").ToString
        cboMoneda.SelectedValue = dtPedido.Rows(0).Item("CURRENCY_ID").ToString
        txtTipoCambio.Text = dtPedido.Rows(0).Item("SELL_RATE").ToString
        txtFormaPago.Text = dtPedido.Rows(0).Item("TERMS").ToString
        txtGlosa.Text = dtPedido.Rows(0).Item("COMMENT").ToString

        'Detalle

        dtDetPed.Clear()
        Dim INTFila As Int16
        For INTFila = 0 To dtPedido.Rows.Count - 1
            Dim myFila As DataRow = dtDetPed.NewRow
            myFila("Codigo") = dtPedido.Rows(INTFila).Item("PART_ID").ToString
            myFila("Descripcion") = dtPedido.Rows(INTFila).Item("PART_DESCRIPTION").ToString
            myFila("Unidad") = dtPedido.Rows(INTFila).Item("UNIT").ToString
            myFila("Lote") = dtPedido.Rows(INTFila).Item("LOT").ToString
            myFila("Serie") = dtPedido.Rows(INTFila).Item("LOT").ToString
            myFila("Cantidad") = dtPedido.Rows(INTFila).Item("QTY").ToString
            myFila("Precio") = dtPedido.Rows(INTFila).Item("PRICE_SALES").ToString
            myFila("Importe") = Math.Round(dtPedido.Rows(INTFila).Item("QTY").ToString * dtPedido.Rows(INTFila).Item("PRICE_SALES").ToString, 6)
            myFila("Igv") = dtPedido.Rows(INTFila).Item("AMOUNT_TAX").ToString
            myFila("IgvPor") = dtPedido.Rows(INTFila).Item("PERCENT_TAX").ToString
            myFila("Isc") = IIf(dtPedido.Rows(INTFila).Item("AMOUNT_ISC_DET").ToString = String.Empty, 0, dtPedido.Rows(INTFila).Item("AMOUNT_ISC_DET"))

            myFila("IscPor") = IIf(dtPedido.Rows(INTFila).Item("PERCENT_ISC").ToString = String.Empty, 0, dtPedido.Rows(INTFila).Item("PERCENT_ISC").ToString)

            myFila("PrecioCalculo") = IIf(dtPedido.Rows(INTFila).Item("PRICE_ORI").ToString = String.Empty, 0, dtPedido.Rows(INTFila).Item("PRICE_ORI").ToString)
            myFila("ValorVenta") = Math.Round((myFila("Importe") / (1 + myFila("IgvPor") / 100)) / ((1 + myFila("IscPor") / 100)), 6)
            myFila("IsLote") = ""
            myFila("IsSerie") = ""
            myFila("Item") = dtPedido.Rows(INTFila).Item("ITEM").ToString

            dtDetPed.Rows.Add(myFila)
        Next
        dgwDetallePed.DataSource = dtDetPed

        'Busca direcciones en caso de facturacion con guia
        If STRAccion = "F" Then
            dtDirCliente = New DataTable
            dtDirCliente = cConsulta.get_Direcciones_Cliente(txtCodCliente.Text)
            cbDirEntrega.DataSource = dtDirCliente
            cbDirEntrega.ValueMember = dtDirCliente.Columns(1).ToString
            cbDirEntrega.DisplayMember = dtDirCliente.Columns(1).ToString
            cbDirEntrega.SelectedIndex = -1
        End If

        Call CalculaTotales()

        cConsulta = Nothing
    End Sub



    Private Sub dgwListaPedidos_DoubleClick(sender As Object, e As EventArgs) Handles dgwListaPedidos.DoubleClick
        If dgwListaPedidos.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim STRPedido As String = String.Empty

        tcPedidos.TabPages.Insert(1, tpGenerar)
        tcPedidos.SelectTab(1)
        tcPedidos.TabPages.Remove(tpLista)

        STRPedido = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(0).Value
        Call Muestra_Pedido(STRPedido)
        gbDatosGuia.Visible = False
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        If dgwListaPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay pedidos por facturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STRPedido As String = String.Empty
        Dim STREstado As String = String.Empty
        Dim STRStatus As String = String.Empty

        STRPedido = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(8).Value
        STRStatus = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(9).Value

        If STREstado = "ANULADO" Then
            MessageBox.Show("El pedido se encuentra anulado, no puede facturarse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "EMITIDO" Then
            MessageBox.Show("El pedido no ha sido aprobado, no puede facturarse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STRStatus = "F" Then
            MessageBox.Show("El pedido ya se encuentra facturado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea facturar el pedido " & STRPedido & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If STREstado = "AUTORIZADO" Then
                STRAccion = "F"
                tcPedidos.TabPages.Insert(1, tpGenerar)
                tcPedidos.SelectTab(1)
                tcPedidos.TabPages.Remove(tpLista)

                Call Muestra_Pedido(STRPedido)
                lblNumPedido.Text = STRPedido
                gbDatosGuia.Visible = True

                cVenta = New ClsAyudas
                dtTipoDoc = New DataTable
                dtTipoDoc = cVenta.get_Tipo_Doc_Pto_Venta(txtPtoVenta.Text.Trim)
                cbTipoDoc.DataSource = dtTipoDoc
                cbTipoDoc.ValueMember = dtTipoDoc.Columns(0).ToString
                cbTipoDoc.DisplayMember = dtTipoDoc.Columns(0).ToString
                cbTipoDoc.SelectedIndex = 0

                dtSerieGuia = New DataTable
                dtSerieGuia = cVenta.get_Serie_Guia_Pto_Venta(txtPtoVenta.Text.Trim)
                cbSerieGuia.DataSource = dtSerieGuia
                cbSerieGuia.ValueMember = dtSerieGuia.Columns(0).ToString
                cbSerieGuia.DisplayMember = dtSerieGuia.Columns(0).ToString
                cbSerieGuia.SelectedIndex = 0
                Me.Text = "Facturación de pedidos"

                cVenta = Nothing

            End If
        End If
    End Sub

    Private Sub cbTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbTipoDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cbTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbTipoDoc.SelectionChangeCommitted
        If cbTipoDoc.SelectedIndex <> -1 Then
            cVenta = New ClsAyudas
            dtSerieDoc = New DataTable
            dtSerieDoc = cVenta.get_Serie_Doc_Pto_Venta(cbTipoDoc.SelectedValue, txtPtoVenta.Text.Trim)
            cbSerieDoc.DataSource = dtSerieDoc
            cbSerieDoc.ValueMember = dtSerieDoc.Columns(0).ToString
            cbSerieDoc.DisplayMember = dtSerieDoc.Columns(0).ToString
            cbSerieDoc.SelectedIndex = 0
            cVenta = Nothing
        End If
    End Sub

    Private Sub txtPtoVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPtoVenta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtPtoVenta_TextChanged(sender As Object, e As EventArgs) Handles txtPtoVenta.TextChanged

    End Sub

    Private Sub txtCodTrans_DoubleClick(sender As Object, e As EventArgs) Handles txtCodTrans.DoubleClick
        frmHelp = New frmAyudaVar
        With frmHelp
            .Titulo = "Transportistas"
            .TipoAyuda = frmAyudaVar.STipoAyuda.Transportistas
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                txtCodTrans.Text = .Data_Matriz.Rows(0).Item(0)
                txtNomTrans.Text = .Data_Matriz.Rows(0).Item(1)
            End If
        End With
    End Sub

    Private Sub txtCodTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodTrans.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtCodTrans_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub txtCodTrans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodTrans.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtCodTrans_TextChanged(sender As Object, e As EventArgs) Handles txtCodTrans.TextChanged

    End Sub

    Private Sub tImprimir_Click(sender As Object, e As EventArgs) Handles tImprimir.Click

    End Sub

    Private Sub cmImprimirPedido_Click(sender As Object, e As EventArgs) Handles cmImprimirPedido.Click
        If dgwListaPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay pedidos por imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STRPedido As String = String.Empty
        Dim STREstado As String = String.Empty
        Dim STRStatus As String = String.Empty

        STRPedido = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(8).Value
        STRStatus = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(9).Value

        If STREstado = "ANULADO" Then
            MessageBox.Show("El pedido se encuentra anulado, no puede imprimirse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "EMITIDO" Then
            MessageBox.Show("El pedido no ha sido aprobado, no puede imprimirse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If STREstado = "AUTORIZADO" Then
            CRep = New ClsReporte
            CRep.Muestra_Reporte("Sal_Orders.rpt", "", "@ID;" & STRPedido)
            CRep = Nothing
        End If

    End Sub

    Private Sub dgwListaPedidos_MouseDown(sender As Object, e As MouseEventArgs) Handles dgwListaPedidos.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim STRFactura As String = String.Empty
            With dgwListaPedidos

                Dim hti As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
                If hti.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = _
                    .Rows(hti.RowIndex).Cells(hti.ColumnIndex)
                    STRFactura = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells("NUMBER_DOCUMENT").Value.ToString
                    If STRFactura.Trim.Length = 0 Then
                        cmImprimirFactura.Enabled = False
                    Else
                        cmImprimirFactura.Enabled = True
                    End If
                End If

            End With
        End If
    End Sub

    Private Sub cmImprimirFactura_Click(sender As Object, e As EventArgs) Handles cmImprimirFactura.Click
        If dgwListaPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay datos por imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STRTipoDoc As String = String.Empty
        Dim STRSerieDoc As String = String.Empty
        Dim STRNumeroDoc As String = String.Empty

        STRTipoDoc = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells("DOCUMENT_ID").Value
        STRSerieDoc = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells("NUMBER_SERIE").Value
        STRNumeroDoc = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells("NUMBER_DOCUMENT").Value

        CRep = New ClsReporte
        CRep.Muestra_Reporte("Sal_Receivable.rpt", "", "@DOCUMENT_ID;" & STRTipoDoc, "@NUMBER_SERIE;" & STRSerieDoc, "@NUMBER_DOCUMENT;" & STRNumeroDoc)
        CRep = Nothing

    End Sub

    Private Sub tCancelar_Click(sender As Object, e As EventArgs) Handles tCancelar.Click
        Call Limpiar()
        tcPedidos.TabPages.Remove(tpGenerar)
        tcPedidos.TabPages.Insert(0, tpLista)
        tcPedidos.SelectTab(0)
    End Sub

    Private Sub txtFormaPago_DoubleClick(sender As Object, e As EventArgs) Handles txtFormaPago.DoubleClick
        frmHelp = New frmAyudaVar
        With frmHelp
            .Titulo = "Listado de formas de pago"
            .TipoAyuda = frmAyudaVar.STipoAyuda.FormaPago
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                txtFormaPago.Text = .Data_Matriz.Rows(0).Item(0)
                lblFormaPago.Text = .Data_Matriz.Rows(0).Item(1)
            End If
        End With
    End Sub

    Private Sub txtFormaPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFormaPago.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtFormaPago_LostFocus(sender As Object, e As EventArgs) Handles txtFormaPago.LostFocus
        If txtFormaPago.Text.Trim.Length > 0 Then
            cVenta = New ClsAyudas
            lblFormaPago.Text = cVenta.get_Dato_FormaCobro(txtFormaPago.Text)
            cVenta = Nothing
        Else
            lblFormaPago.Text = ""
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgwDetallePed.SelectedRows.Count > 0 Then
            If MessageBox.Show("¿Seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dtDetPed.Rows(dgwDetallePed.CurrentRow.Index).Delete()
                dtDetPed.AcceptChanges()
                Call CalculaTotales()
            End If
        End If
    End Sub

    Private Sub txtTipoCambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoCambio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        ModFunciones.OnlyDecimal(e, txtTipoCambio)
    End Sub

    Private Sub txtAlmacen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlmacen.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtFechaEmision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtFechaEmision.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtFechaEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtFechaEntrega.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtCodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtRucDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRucDni.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboMoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboMoneda.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtGlosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGlosa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cbSerieDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSerieDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cbSerieGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSerieGuia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtGlosaDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGlosaDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cbDirEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbDirEntrega.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub
 
End Class