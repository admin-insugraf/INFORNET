Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes

Public Class frmRegOrdenCompra
    Private frmHelp As frmAyudaVar
    Private frmDetalle As frmValoresDetalle
    Private cVenta As LibProveedores.ClsAyudas
    Private cProcesos As ClsProcesos
    Private cConsulta As ClsConsultas
    Private dtPedido As DataTable
    Private dtDetPed As DataTable
    Private dtListPed As DataTable
    Private dtTipoDoc As DataTable
    Private dtDirCliente As DataTable
    Private DBLTotValorVenta As Double = 0
    Private DBLTotISC As Double = 0
    Private DBLTotIGV As Double = 0
    Private DBLTotPrecioVenta As Double = 0
    Private STRAccion As String = String.Empty
    Private CRep As LibReportes.ClsReporte

    Private Sub txtPtoVenta_DoubleClick(sender As Object, e As EventArgs) Handles txtCodCompra.DoubleClick
        frmHelp = New frmAyudaVar
        With frmHelp
            .Titulo = "Puntos de venta"
            .TipoAyuda = frmAyudaVar.STipoAyuda.TipoCompra
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                txtCodCompra.Text = .Data_Matriz.Rows(0).Item(0)
                lblDesCompra.Text = .Data_Matriz.Rows(0).Item(1)
            End If
        End With
    End Sub

    Private Sub txtCodCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCompra.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtPtoVenta_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub txtCodProveedor_DoubleClick(sender As Object, e As EventArgs) Handles txtCodProveedor.DoubleClick
        frmHelp = New frmAyudaVar
        With frmHelp
            .Titulo = "Listado de proveedores"
            .TipoAyuda = frmAyudaVar.STipoAyuda.Proveedores
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                txtCodProveedor.Text = .Data_Matriz.Rows(0).Item(0)
                txtRazonSocial.Text = .Data_Matriz.Rows(0).Item(1)
                txtRucDni.Text = .Data_Matriz.Rows(0).Item(2)
                txtDireccion.Text = .Data_Matriz.Rows(0).Item(3)
            End If
        End With
    End Sub

    Private Sub frmRegPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cVenta = New LibProveedores.ClsAyudas
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
        dtDetPed.Columns.Add("Item", Type.GetType("SF"))
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
                myFila("IscPor") = .Data_Matriz.Rows(0).Item("ISCPOR")
                DBLStock = Val(.Data_Matriz.Rows(0).Item("QTY_ON_HAND"))

                'Pido cantidades y lote/serie si fuera el caso
                frmDetalle = New frmValoresDetalle
                With frmDetalle
                    .Codigo = myFila("Codigo")
                    .Descripcion = myFila("Descripcion")
                    .Almacen = txtAlmacen.Text.Trim
                    .Stock = DBLStock
                    .ShowDialog()
                    If .EsOK = True Then
                        myFila("Cantidad") = .Cantidad
                        myFila("Precio") = .Precio
                        If BOLSinIGV = False Then
                            DBLPrecioCalculo = Math.Round(.Precio / (1 + myFila("IgvPor") / 100), 6)
                            myFila("PrecioCalculo") = DBLPrecioCalculo
                            myFila("Importe") = Math.Round(.Cantidad * .Precio, 6)
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
                    .ShowDialog()
                    If .EsOK = True Then
                        Dim result() As DataRow = dtDetPed.Select("Item=" & INTitem)
                        If result(0) IsNot Nothing Then
                            result(0)("Cantidad") = .Cantidad
                            result(0)("Precio") = .Precio
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
            If txtCodCompra.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe elegir el punto de venta.", "Aviso", MessageBoxButtons.OK)
                txtCodCompra.Focus()
                Exit Sub
            ElseIf txtAlmacen.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe elegir el almacén.", "Aviso", MessageBoxButtons.OK)
                txtAlmacen.Focus()
                Exit Sub
            ElseIf Format(dtFechaEmision.Value, "Short Date") > Format(dtFechaEntrega.Value, "Short Date") Then
                MessageBox.Show("La fecha de emisión no puede ser mayor a la fecha de entrega.", "Aviso", MessageBoxButtons.OK)
                dtFechaEmision.Focus()
                Exit Sub
            ElseIf txtCodProveedor.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe elegir el código del cliente.", "Aviso", MessageBoxButtons.OK)
                txtCodProveedor.Focus()
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

            If MessageBox.Show("¿Desea grabar la orden de compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim cCabPedido As New ClsOrdenCompraTO.Cab_Ordenes_TO
                Dim cDetPedido As New List(Of ClsOrdenCompraTO.Det_Ordenes_TO)
                Dim cFilPedido As ClsOrdenCompraTO.Det_Ordenes_TO
                Dim STRNumeroOrden As String = String.Empty

                With cCabPedido
                    .NumPedido = STRNumeroOrden
                    .FechaPedido = dtFechaEmision.Value
                    .FechaVencimiento = dtFechaEntrega.Value
                    .PtoVenta = txtCodCompra.Text.Trim
                    .CodCliente = txtCodProveedor.Text.Trim
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
                    cFilPedido = New ClsOrdenCompraTO.Det_Ordenes_TO
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
                If cProcesos.Inserta_OrdenCompra(cCabPedido, cDetPedido, STRNumeroOrden) = True Then
                    MessageBox.Show("Se generó la orden de compra: " & STRNumeroOrden, "Generación de OC", MessageBoxButtons.OK)
                    If MessageBox.Show("¿Desea imprimir la orden de compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        CRep = New ClsReporte
                        CRep.Muestra_Reporte("Sal_Orders.rpt", "", "@ID;" & STRNumeroOrden)
                        CRep = Nothing
                    End If
                    Call Limpiar()
                    txtCodCompra.Focus()
                End If
                cProcesos = Nothing
            End If
        End If

        If STRAccion = "F" Then
            If cbTipoDoc.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir el tipo de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbTipoDoc.Focus()
                Exit Sub
            ElseIf txtSerieProv.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar la serie del documento de proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSerieProv.Focus()
                Exit Sub
            ElseIf txtNumeroProv.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar el número del documento de proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtNumeroProv.Focus()
                Exit Sub
            End If

            Dim STRNumFactura As String = String.Empty
            Dim STRNumGuia As String = String.Empty
            Dim STRDirEntrega As String = String.Empty

            Dim STRTipoDoc As String = cbTipoDoc.SelectedValue
            Dim STRSerieDoc As String = txtSerieProv.Text.Trim
            Dim STRSerieGuia As String = txtNumeroProv.Text.Trim
            Dim STRNotaIngreso As String = txtNotaIngreso.Text.Trim

            cProcesos = New ClsProcesos
            If cProcesos.Factura_OrdenCompra(lblNumPedido.Text, STRTipoDoc, STRSerieDoc, _
                                        STRNumFactura, txtTipoCambio.Text, STRNotaIngreso) = True Then

                MessageBox.Show("Se facturó la orden de compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Limpiar()
                Call tCancelar_Click(sender, e)
                Call btnBuscar_Click(sender, e)
            End If

            cProcesos = Nothing

        End If

    End Sub
    Private Sub Limpiar()
        txtCodCompra.Clear()
        txtAlmacen.Clear()
        dtFechaEmision.Value = Now
        dtFechaEntrega.Value = Now
        txtCodProveedor.Clear()
        txtRucDni.Clear()
        txtRazonSocial.Clear()
        txtDireccion.Clear()
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
        dtListPed = cConsulta.get_Lista_Ordenes(Format(dtFechaIni.Value, "Short Date"), Format(dtFechaFin.Value, "Short Date"))
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
        txtCodCompra.Focus()
        Me.Text = "Generación de ordenes de compra"
    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        If dgwListaPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay ordenes por aprobar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STROrden As String = String.Empty
        Dim STREstado As String = String.Empty

        STROrden = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(8).Value

        If STREstado = "AUTORIZADO" Then
            MessageBox.Show("La orden de compra ya se encuentra autorizada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "ANULADO" Then
            MessageBox.Show("La orden de compra se encuentra anulada, no puede aprobarse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea aprobar la orden de compra " & STROrden & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If STREstado = "EMITIDO" Then
                cProcesos = New ClsProcesos
                If cProcesos.Actualiza_Status_Orden(STROrden, "AUTORIZADO") = True Then
                    MessageBox.Show("Orden de compra autorizada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call btnBuscar_Click(sender, e)
                End If
                cProcesos = Nothing
            End If
        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If dgwListaPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay ordenes de compra por anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STROrden As String = String.Empty
        Dim STREstado As String = String.Empty

        STROrden = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(8).Value

        If STREstado = "AUTORIZADO" Then
            MessageBox.Show("La orden de compra ya se encuentra autorizada, no puede anularse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "ANULADO" Then
            MessageBox.Show("La orden de compra ya se encuentra anulada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea anular la orden de compra " & STROrden & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If STREstado = "EMITIDO" Then
                cProcesos = New ClsProcesos
                If cProcesos.Actualiza_Status_Orden(STROrden, "ANULADO") = True Then
                    MessageBox.Show("Orden de compra anulada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call btnBuscar_Click(sender, e)
                End If
                cProcesos = Nothing
            End If
        End If
    End Sub

    Private Sub Muestra_Pedido(ByVal STRNumOrden)
        dtPedido = New DataTable
        cConsulta = New ClsConsultas
        dtPedido = cConsulta.get_OrdenCompra(STRNumOrden)
        If dtPedido.Rows.Count() <> 0 Then
            'Cabecera
            txtCodCompra.Text = dtPedido.Rows(0).Item("PLACE_SALES").ToString
            txtAlmacen.Text = dtPedido.Rows(0).Item("WAREHOUSE_ID").ToString
            dtFechaEmision.Value = dtPedido.Rows(0).Item("ORDER_DATE").ToString
            dtFechaEntrega.Value = dtPedido.Rows(0).Item("CADUCATE_DATE").ToString
            txtCodProveedor.Text = dtPedido.Rows(0).Item("CUSTOMER_ID").ToString
            txtRucDni.Text = dtPedido.Rows(0).Item("VAT_REGISTRATION").ToString
            txtRazonSocial.Text = dtPedido.Rows(0).Item("CUSTOMER_NAME").ToString
            txtDireccion.Text = dtPedido.Rows(0).Item("CUSTOMER_ADDR").ToString
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
                myFila("Isc") = dtPedido.Rows(INTFila).Item("AMOUNT_ISC_DET").ToString
                myFila("IscPor") = dtPedido.Rows(INTFila).Item("PERCENT_ISC").ToString
                myFila("PrecioCalculo") = dtPedido.Rows(INTFila).Item("PRICE_ORI").ToString
                myFila("ValorVenta") = Math.Round((myFila("Importe") / (1 + myFila("IgvPor") / 100)) / ((1 + myFila("IscPor") / 100)), 6)
                myFila("IsLote") = ""
                myFila("IsSerie") = ""
                myFila("Item") = dtPedido.Rows(INTFila).Item("ITEM").ToString
                dtDetPed.Rows.Add(myFila)
            Next
            dgwDetallePed.DataSource = dtDetPed
            Call CalculaTotales()

            cConsulta = Nothing
        Else
            MessageBox.Show("No hay informacion disponible.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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

        Dim STROrden As String = String.Empty
        Dim STREstado As String = String.Empty
        Dim STRStatus As String = String.Empty

        STROrden = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(8).Value
        STRStatus = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(9).Value

        If STREstado = "ANULADO" Then
            MessageBox.Show("La orden de compra se encuentra anulada, no puede facturarse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "EMITIDO" Then
            MessageBox.Show("La orden de compra no ha sido aprobada, no puede facturarse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STRStatus = "F" Then
            MessageBox.Show("La orden de compra ya se encuentra facturada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea facturar la orden de compra " & STROrden & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If STREstado = "AUTORIZADO" Then
                STRAccion = "F"
                tcPedidos.TabPages.Insert(1, tpGenerar)
                tcPedidos.SelectTab(1)
                tcPedidos.TabPages.Remove(tpLista)

                Call Muestra_Pedido(STROrden)
                lblNumPedido.Text = STROrden
                gbDatosGuia.Visible = True

                cVenta = New ClsAyudas
                dtTipoDoc = New DataTable
                dtTipoDoc = cVenta.get_Tipo_Doc_Pto_Venta(txtCodCompra.Text.Trim)
                cbTipoDoc.DataSource = dtTipoDoc
                cbTipoDoc.ValueMember = dtTipoDoc.Columns(0).ToString
                cbTipoDoc.DisplayMember = dtTipoDoc.Columns(0).ToString
                cbTipoDoc.SelectedIndex = -1


                Me.Text = "Facturación de pedidos"

                cVenta = Nothing

            End If
        End If
    End Sub

    Private Sub cbTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbTipoDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtPtoVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmImprimirPedido_Click(sender As Object, e As EventArgs) Handles cmImprimirPedido.Click
        If dgwListaPedidos.Rows.Count = 0 Then
            MessageBox.Show("No hay ordenes de compra por imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STROrden As String = String.Empty
        Dim STREstado As String = String.Empty
        Dim STRStatus As String = String.Empty

        STROrden = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(0).Value
        STREstado = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(8).Value
        STRStatus = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells(9).Value

        If STREstado = "ANULADO" Then
            MessageBox.Show("La orden de compra se encuentra anulada, no puede imprimirse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf STREstado = "EMITIDO" Then
            MessageBox.Show("La orden de compra no ha sido aprobada, no puede imprimirse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If STREstado = "AUTORIZADO" Then
            CRep = New ClsReporte
            CRep.Muestra_Reporte("Sal_Orders.rpt", "", "@ID;" & STROrden)
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
                    STRFactura = dgwListaPedidos.Rows(dgwListaPedidos.CurrentRow.Index).Cells("REFER_DOCUMENT_NUMBER").Value.ToString
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

    Private Sub txtAlmacen_DoubleClick(sender As Object, e As EventArgs) Handles txtAlmacen.DoubleClick
        frmHelp = New frmAyudaVar
        With frmHelp
            .Titulo = "Almacenes"
            .TipoAyuda = frmAyudaVar.STipoAyuda.Almacenes
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                txtAlmacen.Text = .Data_Matriz.Rows(0).Item(0)
                lblAlmacen.Text = .Data_Matriz.Rows(0).Item(1)
            End If
        End With
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

    Private Sub txtCodProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProveedor.KeyPress
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

    Private Sub cbSerieDoc_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cbSerieGuia_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub
    Private Sub txtCodResponsable_DoubleClick(sender As Object, e As EventArgs) Handles txtCodResponsable.DoubleClick
        frmHelp = New frmAyudaVar
        With frmHelp
            .Titulo = "Listado de responsables de compras"
            .TipoAyuda = frmAyudaVar.STipoAyuda.Compradores
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                txtCodResponsable.Text = .Data_Matriz.Rows(0).Item(0)
                lblResponsable.Text = .Data_Matriz.Rows(0).Item(1)
            End If
        End With
    End Sub

 
End Class