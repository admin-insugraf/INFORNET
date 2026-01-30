Imports System.Windows.Forms

Public Class frmNotaIngSal
    Private edicion As Boolean
    Private _tipoNota As String
    Private _ModoEdicion As Boolean = False
    Private _idAlmacen As String
    Private _documentId As String
    Private _NumeroDocumento As String

    Dim dtCabeceraAlm As DataTable
    Dim dtDetalleAlm As DataTable
    Dim clsAlmacenCabBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenDetBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
    Dim MostrarMovimientoBl As ClsTransacciones.clsMostrarTiposMovimiento

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Dim clsBusquedaBl As ClsBuscar
    Dim dtdetalleBultosPrincipal As DataTable

    Dim TipoArticulo As String
    Dim PerteneceGuiaAnalisis As Boolean = False
    Dim Fl_close As Boolean = False

    Public Property TipoNota() As String
        Get
            Return _tipoNota
        End Get
        Set(value As String)
            _tipoNota = value
            If _tipoNota = "I" Then
                chkValorizado.Visible = False
            End If
        End Set
    End Property

    Public Property ModoEdicion() As Boolean
        Get
            Return _ModoEdicion
        End Get
        Set(value As Boolean)
            _ModoEdicion = value
            If _ModoEdicion = True Then
            End If
        End Set
    End Property

    Public Property idAlmacen() As String
        Get
            Return _idAlmacen
        End Get
        Set(value As String)
            _idAlmacen = value
        End Set
    End Property

    Public Property documentId() As String
        Get
            Return _documentId
        End Get
        Set(value As String)
            _documentId = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return _NumeroDocumento
        End Get
        Set(value As String)
            _NumeroDocumento = value
        End Set
    End Property

    Public Property Data_Matriz() As DataTable
        Get
            Return dtdetalleBultosPrincipal
        End Get
        Set(ByVal Value As DataTable)
            dtdetalleBultosPrincipal = Value
        End Set
    End Property

    Private Sub MostrandoTipoTransacciones()
        Try
            If ModoEdicion = True Then Exit Sub
            MostrarMovimientoBl = New ClsTransacciones.clsMostrarTiposMovimiento
            Dim CodigoTransaccion As String = String.Empty
            CodigoTransaccion = cmbTipoMovimiento.SelectedValue.ToString
            MostrarMovimientoBl.Get_TipoTransacciones(_tipoNota, CodigoTransaccion)
            'Valorizado
            If MostrarMovimientoBl.IS_VALUED = "F" Then
                chkValorizado.Visible = False
            ElseIf MostrarMovimientoBl.IS_VALUED = "V" Then
                chkValorizado.Visible = True
                chkValorizado.Checked = False
            End If
            If MostrarMovimientoBl.IS_CUSTOMER = "N" Then
                txtcodigoTercero.Enabled = False
                lbltercero.Text = String.Empty
                txtcodigoTercero.Text = String.Empty
                txtcodigoTercero.BackColor = Drawing.Color.White
                txtcodigoTercero.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_CUSTOMER = "S" Then
                txtcodigoTercero.Enabled = True
                lbltercero.Text = String.Empty
                txtcodigoTercero.Text = String.Empty
                txtcodigoTercero.BackColor = Drawing.Color.Aquamarine
                txtcodigoTercero.ForeColor = Drawing.Color.Black
            End If
            If MostrarMovimientoBl.IS_VENDOR = "N" Then
                txtcodigoProveedor.Enabled = False
                lblproveedor.Text = String.Empty
                txtcodigoProveedor.Text = String.Empty
                txtcodigoProveedor.BackColor = Drawing.Color.White
                txtcodigoProveedor.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_VENDOR = "S" Then
                txtcodigoProveedor.Enabled = True
                lblproveedor.Text = String.Empty
                txtcodigoProveedor.Text = String.Empty
                txtcodigoProveedor.BackColor = Drawing.Color.Aquamarine
                txtcodigoProveedor.ForeColor = Drawing.Color.Black
            End If
            'Centro de Costo
            If MostrarMovimientoBl.IS_CCOST = "N" Then
                cmbCentroCosto.Enabled = False
            ElseIf MostrarMovimientoBl.IS_CCOST = "S" Then
                cmbCentroCosto.Enabled = True
            End If
            ' Almacen   
            If MostrarMovimientoBl.WHO_ID = String.Empty Then
                cmbAlmacen.Enabled = True
                cmbAlmacen.SelectedIndex = 0
                cmbAlmacen.BackColor = Drawing.Color.Aquamarine
                cmbAlmacen.ForeColor = Drawing.Color.Black
            Else
                cmbAlmacen.Enabled = False
                cmbAlmacen.SelectedValue = MostrarMovimientoBl.WHO_ID
                cmbAlmacen.BackColor = Drawing.Color.White
                cmbAlmacen.ForeColor = Drawing.Color.Black
            End If
            ' tipo Doc Ref   
            If MostrarMovimientoBl.IS_DOC_REF = "N" Then
                txtTipoDocumento.Enabled = False
                txtNumeroReferencia.Enabled = False
                txtTipoDocumento.Text = String.Empty
                txtNumeroReferencia.Text = String.Empty
                txtTipoDocumento.BackColor = Drawing.Color.White
                txtNumeroReferencia.BackColor = Drawing.Color.White
                txtTipoDocumento.ForeColor = Drawing.Color.White
                txtNumeroReferencia.ForeColor = Drawing.Color.White
            ElseIf MostrarMovimientoBl.IS_DOC_REF = "S" Then
                txtNumeroReferencia.Enabled = True
                txtTipoDocumento.Enabled = True
                txtTipoDocumento.Text = String.Empty
                txtNumeroReferencia.Text = String.Empty
                txtTipoDocumento.BackColor = Drawing.Color.Aquamarine
                txtTipoDocumento.ForeColor = Drawing.Color.Black
                txtNumeroReferencia.BackColor = Drawing.Color.Aquamarine
                txtNumeroReferencia.ForeColor = Drawing.Color.Black
            End If
            'Orden de compra
            If MostrarMovimientoBl.IS_ORDER_PURCHASE = "N" Then
                txtordenCompra.Enabled = False
                txtordenCompra.Text = String.Empty
                txtordenCompra.BackColor = Drawing.Color.White
                txtordenCompra.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_ORDER_PURCHASE = "S" Then
                txtordenCompra.Enabled = True
                txtordenCompra.Text = String.Empty
                txtordenCompra.BackColor = Drawing.Color.Aquamarine
                txtordenCompra.ForeColor = Drawing.Color.Black
            End If
            'Orden de Fabricacion
            If MostrarMovimientoBl.IS_ORDER_MANUFACT = "N" Then
                txtorderFabricacion.Enabled = False
                txtorderFabricacion.Text = String.Empty
                txtorderFabricacion.BackColor = Drawing.Color.White
                txtorderFabricacion.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_ORDER_MANUFACT = "S" Then
                txtorderFabricacion.Enabled = True
                txtorderFabricacion.Text = String.Empty
                txtorderFabricacion.BackColor = Drawing.Color.Aquamarine
                txtorderFabricacion.ForeColor = Drawing.Color.Black
            End If
            'Tipo Articulo 
            TipoArticulo = String.Empty
            TipoArticulo = MostrarMovimientoBl.WHO_ID_PART_TYPE
            'Generacion de Guia de Analisis
            If MostrarMovimientoBl.IS_GUIA_ANALISIS = "S" Then
                PerteneceGuiaAnalisis = True
            ElseIf MostrarMovimientoBl.IS_GUIA_ANALISIS = "N" Then
                PerteneceGuiaAnalisis = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            Using context = AlmacenContext.CrearContext() ' New AlmacenContext
                Dim lstMoneda = (From m In context.Monedas
                                 Select m).ToList()
                bsMoneda.DataSource = lstMoneda

                Dim lstAlmacen = (From a In context.Almacenes
                                  Select a).ToList()
                bsAlmacen.DataSource = lstAlmacen

                Dim lstCentroCosto = (From c In context.CentrosCosto
                                      Select c).ToList()
                lstCentroCosto.Insert(0, New CentroCosto With {.Codigo = "XX", .Nombre = "(Seleccione)"})
                bsCentroCosto.DataSource = lstCentroCosto

                Dim lstTipoMovimiento As IList(Of TipoMovimiento)


                If _tipoNota = "I" Then
              
                    Dim q = (From t In context.TiposMovimiento
                                      Where t.Tipo = "I"
                                        Order By t.Codigo Ascending
                                      Select t)
                    lstTipoMovimiento = q.ToList

                Else
                    lstTipoMovimiento = (From t In context.TiposMovimiento
                                         Where t.Tipo = "S"
                                         Order By t.Codigo Ascending
                                         Select t).ToList()
                End If
                lstTipoMovimiento.Insert(0, New TipoMovimiento With {.Codigo = "XX", .Nombre = "(SELECCIONE UN TIPO DE TRANSACCION)"})
                bsTipoMovimiento.DataSource = lstTipoMovimiento

                Dim qry = (From t In context.TiposDeCambio
                           Where t.Fecha = Date.Today
                           Select t)
                Dim tc = qry.FirstOrDefault()
                If Not IsNothing(tc) Then
                    MsgBox(tc.Venta)
                    txtTipoCambio.Text = tc.Venta
                Else
                    txtTipoCambio.Text = ""
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ShowDetalle(tipoDocumento As String, documento As String)
        LlenarCombos()

        Using context = AlmacenContext.CrearContext() 'New AlmacenContext
            Dim qry = (From n In context.NotasPedido
                      Where n.TipoDocumento = tipoDocumento And n.NumeroDocumento = documento
                      Select n)
            Dim nota = qry.First()
            dtpFecha.Value = nota.Fecha
            cmbTipoMovimiento.SelectedValue = nota.TipoMovimiento
            cmbMoneda.SelectedValue = nota.IDMoneda
            cmbAlmacen.SelectedValue = nota.IDAlmacen
            If nota.IDCentroCosto <> Nothing Then
                cmbCentroCosto.SelectedValue = nota.IDCentroCosto
            Else
                cmbCentroCosto.SelectedValue = "XX"
            End If
            txtTipoCambio.Text = nota.TipoCambio.ToString("N6")
            txtTipoDocumento.Text = nota.TipoDocReferencia
            txtNumeroReferencia.Text = nota.NumeroDocReferencia
            txtcodigoTercero.Text = nota.IDCliente
            lbltercero.Text = nota.Cliente
            txtcodigoProveedor.Text = nota.IDProveedor
            lblproveedor.Text = nota.Proveedor
            txtTotal.Text = nota.Monto.ToString("N6")
            bsLineaNotaPedido.DataSource = nota.Lineas.OrderBy(Function(c) c.NumeroLinea).ToList()
        End Using
        dtpFecha.Enabled = False
        chkValorizado.Enabled = False
        cmbTipoMovimiento.Enabled = False
        cmbMoneda.Enabled = False
        cmbAlmacen.Enabled = False
        txtTipoCambio.Enabled = False
        txtTipoDocumento.Enabled = False
        txtNumeroReferencia.Enabled = False
        txtcodigoTercero.Enabled = False
        txtcodigoTercero.Enabled = False
        cmbCentroCosto.Enabled = False
        btnAgregar.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnAceptar.Visible = False
        LinkLabel1.Enabled = False
        LinkLabel2.Enabled = False

        ShowDialog()
    End Sub

    Public Function ShowNuevo() As System.Windows.Forms.DialogResult
        dtpFecha.Value = Date.Today
        edicion = False
        bsLineaNotaPedido.DataSource = New List(Of LineaNotaPedido)()
        LlenarCombos()
        GenerarColummnaDataTable()
        Return ShowDialog()
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function ValidarAgregacion() As Boolean
        Dim res As Boolean = True
        Dim msg As String = String.Empty
        Try
            Dim controles As Control = GroupBox2
            For Each ctrl As Control In controles.Controls
                'si es Label continuar
                If TypeOf (ctrl) Is Label Then Continue For
                '---------
                If TypeOf (ctrl) Is TextBox Then
                    '---validando Cajas de Texto
                    If ctrl.Enabled = True Then
                        If ctrl.Text = String.Empty Then
                            msg = "Es necesario ingresar: " & ctrl.Tag
                            MsgBox(msg, MsgBoxStyle.Information)
                            ctrl.Focus()
                            res = False
                            Exit Try
                        End If
                    End If
                ElseIf TypeOf (ctrl) Is ComboBox Then
                    Dim combo As ComboBox = DirectCast(ctrl, ComboBox)
                    '---validando Combo  Box
                    If ctrl.Enabled = True Then
                        If ctrl.Text = "(Seleccione)" Then
                            MsgBox("Es necesario seleccionar al menos un item", MsgBoxStyle.Information)
                            ctrl.Focus()
                            res = False
                            Exit Try
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return res
    End Function

    Private Function Validar() As Boolean
        Dim res As Boolean = True
        Dim msg As String = String.Empty
        Try
            Dim valor = CDec(txtTipoCambio.Text)
            If valor <= 0 Then
                errores.SetError(txtTipoCambio, "Debe ingresar el tipo de cambio")
                res = False
                Exit Try
            End If

            Dim controles As Control = GroupBox2
            For Each ctrl As Control In controles.Controls
                'si es Label continuar
                If TypeOf (ctrl) Is Label Then Continue For
                '---------
                If TypeOf (ctrl) Is TextBox Then
                    '---validando Cajas de Texto
                    If ctrl.Enabled = True Then
                        If ctrl.Text = String.Empty Then
                            msg = "Es necesario ingresar: " & ctrl.Tag
                            MsgBox(msg, MsgBoxStyle.Information)
                            ctrl.Focus()
                            res = False
                            Exit Try
                        End If
                    End If
                ElseIf TypeOf (ctrl) Is ComboBox Then
                    Dim combo As ComboBox = DirectCast(ctrl, ComboBox)
                    '---validando Combo  Box
                    If ctrl.Enabled = True Then
                        If ctrl.Text = "(Seleccione)" Then
                            MsgBox("Es necesario seleccionar al menos un item", MsgBoxStyle.Information)
                            ctrl.Focus()
                            res = False
                            Exit Try
                        End If
                    End If
                End If
            Next
            Dim lst = CType(bsLineaNotaPedido.DataSource, IList(Of LineaNotaPedido))
            If lst.Count = 0 Then
                errores.SetError(dgvdetalleAlmacen, "Debe agregar por lo menos una linea a la nota de pedido")
                res = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return res
    End Function

    Private Sub MostrarModoEdicion()
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtCabeceraAlm = New DataTable
            dtDetalleAlm = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraAlm = clsAlmacenCabBl.get_CabeceraAlmacen(idAlmacen, documentId, NumeroDocumento)
            If dtCabeceraAlm.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraAlm.Rows.Count() - 1
                    dtpFecha.Text = dtCabeceraAlm.Rows(i).Item("DATE_DOCUMENT").ToString
                    cmbTipoMovimiento.SelectedValue = dtCabeceraAlm.Rows(i).Item("TRANS_ID").ToString
                    cmbAlmacen.SelectedValue = dtCabeceraAlm.Rows(i).Item(0).ToString
                    txtTipoDocumento.Text = dtCabeceraAlm.Rows(i).Item("DOC_ID_REF").ToString
                    txtNumeroReferencia.Text = dtCabeceraAlm.Rows(i).Item("NUM_ID_REF").ToString
                    txtorderFabricacion.Text = dtCabeceraAlm.Rows(i).Item("NUM_ORDER_MANUFACT").ToString
                    txtcodigoProveedor.Text = dtCabeceraAlm.Rows(i).Item("VENDOR_ID").ToString
                    lblproveedor.Text = dtCabeceraAlm.Rows(i).Item("VENDOR_NAME").ToString
                    txtcodigoTercero.Text = dtCabeceraAlm.Rows(i).Item("CUSTOMER_ID").ToString
                    lbltercero.Text = dtCabeceraAlm.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtComentarios.Text = dtCabeceraAlm.Rows(i).Item("COMMENT").ToString
                    txtordenCompra.Text = dtCabeceraAlm.Rows(i).Item("NUMBER_PURCHASE").ToString
                Next
                '---Mostrando datos del Detalle
                dtDetalleAlm = clsAlmacenDetBl.get_DetalleAlmacen(idAlmacen, documentId, NumeroDocumento)
                dgvDetalle.DataSource = Nothing
                If dtDetalleAlm.Rows.Count() <> 0 Then
                    For j As Integer = 0 To dtDetalleAlm.Rows.Count() - 1
                        dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                           dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_ANALIS").ToString, dtDetalleAlm.Rows(j).Item("QTY").ToString, _
                           dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString, IIf(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString = "0", "Parcial", "Total"), dtDetalleAlm.Rows(j).Item("NUM_PROTOCOLOS").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, 0.0)
                    Next
                End If
                Dim total As Double = 0.0
                For Each row As DataGridViewRow In dgvdetalleAlmacen.Rows
                    total += CDbl(row.Cells(5).Value)
                Next
                txtTotal.Text = Format(total, "##.##0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarNumeroAnalisis(ByVal idlamacen As String, ByVal documentId As String, ByVal NumeroDocumento As String)
        Try
            clsBusquedaBl = New ClsBuscar
            clsBusquedaBl.ActualizandoNumeroAnalisis(idlamacen, documentId, NumeroDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarInsercionLotes(ByVal WAREHOUSE_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOCUMENT As String, _
                                      ByVal DATE_DOCUMENT As String, ByVal TYPE_TRANS As String)
        Try
            clsBusquedaBl = New ClsBuscar
            For i As Integer = 0 To dtdetalleBultosPrincipal.Rows.Count() - 1

                clsBusquedaBl.InsertarCantidadLotes(WAREHOUSE_ID, DOCUMENT_ID, NUMBER_DOCUMENT, DATE_DOCUMENT, TYPE_TRANS, dtdetalleBultosPrincipal.Rows(i).Item("PART_ID").ToString(), _
                                                    dtdetalleBultosPrincipal.Rows(i).Item("LOTE").ToString(), dtdetalleBultosPrincipal.Rows(i).Item("QTY").ToString(), _
                                                    dtdetalleBultosPrincipal.Rows(i).Item("QTY_BULTOS").ToString(), i + 1)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub imprimirAlmacen(ByVal idalamacen As String, ByVal documentid As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable

            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAnalisis(idalamacen, documentid, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If ModoEdicion = True Then Exit Sub
            If Validar() Then
                If Windows.Forms.MessageBox.Show("Se va a proceder a la creacion de un Nuevo documento" & vbCrLf & "¿Desea continuar?", "Guardar", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim nota As NotaPedido
                    Dim NumeroDocumento As String = String.Empty
                    Using context = AlmacenContext.CrearContext() 'New AlmacenContext
                        If edicion Then
                            nota = context.NotasPedido.Find(cmbAlmacen.SelectedValue.ToString(), txtTipoDocumento.Text, txtNumeroReferencia.Text)
                        Else
                            nota = New NotaPedido
                        End If

                        nota.Fecha = dtpFecha.Value
                        nota.IDMoneda = cmbMoneda.SelectedValue.ToString()
                        nota.TipoCambio = CDec(txtTipoCambio.Text)
                        nota.IDAlmacen = cmbAlmacen.SelectedValue.ToString()
                        nota.IDProveedor = txtcodigoProveedor.Text
                        nota.Proveedor = lblproveedor.Text
                        nota.TipoDocReferencia = txtTipoDocumento.Text
                        nota.NumeroDocReferencia = txtNumeroReferencia.Text
                        nota.IDCliente = txtcodigoTercero.Text
                        nota.Cliente = lbltercero.Text
                        nota.TipoMovimiento = cmbTipoMovimiento.SelectedValue
                        nota.TipoNota = Me._tipoNota
                        If Not edicion Then
                            Dim alm = (From a In context.Almacenes
                                       Where a.Codigo = nota.IDAlmacen
                                       Select a).First()
                            If Me._tipoNota = "I" Then
                                nota.TipoDocumento = "NI"
                                alm.UltimoIngreso = alm.UltimoIngreso + 1
                                nota.NumeroDocumento = alm.UltimoIngreso.ToString("F0")
                            Else
                                nota.TipoDocumento = "NS"
                                alm.UltimaSalida = alm.UltimaSalida + 1
                                nota.NumeroDocumento = alm.UltimaSalida.ToString("F0")
                            End If
                            While nota.NumeroDocumento.Length < 10
                                NumeroDocumento = "0" & nota.NumeroDocumento
                                nota.NumeroDocumento = "0" & nota.NumeroDocumento
                            End While
                        End If
                        nota.FechaActualizado = Date.Today
                        nota.Hora = Date.Now.ToString("HH:mm:ss")
                        'nota.Usuario = Threading.Thread.CurrentPrincipal.Identity.Name
                        nota.Usuario = LibComunVar.ClsVarComun.USUARIO
                        nota.NUM_ORDER_MANUFACT = txtorderFabricacion.Text
                        nota.NUMBER_PURCHASE = txtordenCompra.Text
                        nota.COMMENT = txtComentarios.Text
                        nota.Estado = "V"

                        Dim lst = CType(bsLineaNotaPedido.DataSource, IList(Of LineaNotaPedido))
                        For Each linea In lst
                            linea.IDAlmacen = nota.IDAlmacen
                            linea.TipoDocumento = nota.TipoDocumento
                            linea.NumeroDocumento = nota.NumeroDocumento
                            linea.CostoPromedio = nota.Monto
                            linea.IDMoneda = nota.IDMoneda
                            linea.TipoCambio = nota.TipoCambio
                            linea.EsValorizado = chkValorizado.Checked
                            If nota.IDMoneda = "MN" Then linea.MontoEnDolares = linea.Monto / nota.TipoCambio Else linea.MontoEnDolares = linea.Monto
                            nota.Lineas.Add(linea)
                        Next

                        If Not edicion Then
                            context.NotasPedido.Add(nota)
                        End If
                        Me.Cursor = Cursors.WaitCursor
                        context.SaveChanges()
                        context.Database.ExecuteSqlCommand(String.Format("Exec ACT_QTY_LOTE_2010_AL '{0}'", cmbAlmacen.SelectedValue.ToString()))
                        '--Generando el Numero de Analiss
                        If PerteneceGuiaAnalisis Then
                            GenerarNumeroAnalisis(cmbAlmacen.SelectedValue.ToString(), IIf(_tipoNota = "I", "NI", "NS"), NumeroDocumento)
                        End If
                        '--guardando CantidadAsigandaLote
                        GenerarInsercionLotes(cmbAlmacen.SelectedValue.ToString(), IIf(_tipoNota = "I", "NI", "NS"), NumeroDocumento, Date.Today, _tipoNota)
                        Dim msj As String = String.Empty
                        msj = "Documento generado Correctamente, Nro Documento: " & NumeroDocumento
                        MsgBox(msj, MsgBoxStyle.Information)
                        If Windows.Forms.MessageBox.Show("Se procedera a la Impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            imprimirAlmacen(cmbAlmacen.SelectedValue.ToString(), IIf(_tipoNota = "I", "NI", "NS"), NumeroDocumento)
                        End If
                        Me.Cursor = Cursors.Default
                    End Using
                    DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RefrescarLineas()
        Dim lst = CType(bsLineaNotaPedido.DataSource, List(Of LineaNotaPedido))
        Dim total As Decimal = 0
        For i = 1 To lst.Count
            lst(i - 1).NumeroLinea = i
            total = total + lst(i - 1).Monto
        Next
        txtTotal.Text = total.ToString("N2")
        bsLineaNotaPedido.ResetBindings(False)
    End Sub


    Private Sub AgregandoNuevosDatosBultos(TablaOrigen As DataTable, ByVal TablaDestino As DataTable, ByVal indice As String)
        Try
            For i As Integer = 0 To TablaOrigen.Rows.Count() - 1
                Dim row As DataRow = TablaDestino.NewRow
                row("WAREHOUSE_ID") = ""
                row("DOCUMENT_ID") = ""
                row("NUMBER_DOCUMENT") = ""
                row("DATE_DOCUMENT") = Date.Now()
                row("PART_ID") = TablaOrigen.Rows(i).Item("PART_ID")
                row("LOTE") = TablaOrigen.Rows(i).Item("LOTE")
                row("ITEM") = i + 1
                row("QTY") = TablaOrigen.Rows(i).Item("QTY")
                row("QTY_BULTOS") = TablaOrigen.Rows(i).Item("QTY_BULTOS")
                row("IDENTIFICADOR") = indice
                dtdetalleBultosPrincipal.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function DatosLotes(Optional ByVal Lote As String = "", Optional ByVal CodigoPart As String = "") As String
        Dim Cadena As String = String.Empty
        Try
            Dim listaLot As New List(Of String)
            Dim cadena_lote As String = String.Empty
            If dgvdetalleAlmacen.Rows.Count() <> 0 Then
                If edicion = True Then
                    If dgvdetalleAlmacen.Rows.Count() = 1 Then
                        Exit Try
                    End If
                End If
                If Lote = String.Empty Then
                    For i As Integer = 0 To dgvdetalleAlmacen.Rows.Count() - 1
                        Dim lotes As String = String.Empty
                        lotes = dgvdetalleAlmacen.Item(8, i).Value
                        If listaLot.Contains(lotes) = False Then
                            listaLot.Add(lotes)
                        End If
                    Next
                    For j As Integer = 0 To listaLot.Count() - 1
                        cadena_lote += "'" & listaLot(j) & "',"
                    Next
                    Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
                Else
                    For Each row As DataGridViewRow In dgvdetalleAlmacen.Rows
                        If row.Cells("CODIGO").Value = CodigoPart And row.Cells("LOTE").Value <> Lote Then
                            Dim lotes As String = String.Empty
                            lotes = row.Cells("LOTE").Value
                            If listaLot.Contains(lotes) = False Then
                                listaLot.Add(lotes)
                            End If
                        End If
                    Next
                    If listaLot.Count() <> 0 Then
                        For j As Integer = 0 To listaLot.Count() - 1
                            cadena_lote += "'" & listaLot(j) & "',"
                        Next
                        Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Cadena
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cmbTipoMovimiento.SelectedIndex = 0 Then Exit Sub
        If ValidarAgregacion() = False Then Exit Sub
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        Dim frm As New frmLineaNotaPedido
        frm.Text = Me.Text
        frm.EsValorizado = chkValorizado.Checked
        frm.IDAlmacen = cmbAlmacen.SelectedValue.ToString()
        frm.Flag_ModoEdicion = False
        frm.TransaccionTipoArticulo = TipoArticulo
        frm.TipoMov = TipoNota
        If TipoNota = "S" Then
            frm.ValidacionLotes = DatosLotes()
            frm.AlmacenOrigen = cmbAlmacen.SelectedValue.ToString
        End If
        If frm.ShowAgregar() = Windows.Forms.DialogResult.OK Then
            Dim nota = frm.Objeto
            Dim lst = CType(bsLineaNotaPedido.DataSource, List(Of LineaNotaPedido))
            nota.NumeroLinea = lst.Count + 1
            lst.Add(nota)
            RefrescarLineas()
            If frm.dtDetallesBulto.Rows.Count() > 0 Then
                If frm.Flag_ModoEdicion = False Then
                    AgregandoNuevosDatosBultos(frm.dtDetallesBulto, dtdetalleBultosPrincipal, dgvdetalleAlmacen.Rows.Count())
                End If
            End If
            errores.SetError(dgvdetalleAlmacen, "")
            Fl_close = False
        Else
            Fl_close = True
        End If
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_Click(sender, e)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim linea = CType(bsLineaNotaPedido.Current, LineaNotaPedido)
        If Not IsNothing(linea) Then
            Dim frm As New frmLineaNotaPedido
            frm.Text = Me.Text
            frm.EsValorizado = chkValorizado.Checked
            frm.IDAlmacen = cmbAlmacen.SelectedValue.ToString()
            frm.GenerarColummnaDataTable()
            frm.Flag_ModoEdicion = True
            frm.Identificador = dgvdetalleAlmacen.Item(0, dgvdetalleAlmacen.CurrentRow.Index).Value
            'Enviando datos seleccioandos a Modificar
            For Each item As DataRow In dtdetalleBultosPrincipal.Select("IDENTIFICADOR=" & dgvdetalleAlmacen.Item(0, dgvdetalleAlmacen.CurrentRow.Index).Value)
                Dim row As DataRow = frm.dtDetallesBulto.NewRow
                row("WAREHOUSE_ID") = item("WAREHOUSE_ID")
                row("DOCUMENT_ID") = item("DOCUMENT_ID")
                row("NUMBER_DOCUMENT") = item("NUMBER_DOCUMENT")
                row("DATE_DOCUMENT") = item("DATE_DOCUMENT")
                row("PART_ID") = item("PART_ID")
                row("LOTE") = item("LOTE")
                row("ITEM") = item("ITEM")
                row("QTY") = item("QTY")
                row("QTY_BULTOS") = item("QTY_BULTOS")
                row("IDENTIFICADOR") = item("IDENTIFICADOR")
                frm.dtDetallesBulto.Rows.Add(row)
            Next
            If frm.ShowEditar(linea) = Windows.Forms.DialogResult.OK Then
                'Borrando los Datos
                For Each item As DataRow In dtdetalleBultosPrincipal.Select("IDENTIFICADOR=" & frm.Identificador)
                    item.Delete()
                    dtdetalleBultosPrincipal.AcceptChanges()
                Next
                'Agregando Nuevamente los Datos
                AgregandoNuevosDatosBultos(frm.dtDetallesBulto, dtdetalleBultosPrincipal, frm.Identificador)
                RefrescarLineas()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not IsNothing(bsLineaNotaPedido.Current) Then
            If Windows.Forms.MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvdetalleAlmacen.Item(0, dgvdetalleAlmacen.CurrentRow.Index).Value
                bsLineaNotaPedido.RemoveCurrent()
                RefrescarLineas()
                'Borrando los Datos
                For Each item As DataRow In dtdetalleBultosPrincipal.Select("IDENTIFICADOR=" & Codigo)
                    item.Delete()
                    dtdetalleBultosPrincipal.AcceptChanges()
                Next
                'Actualizando Numeracion
                Dim Index As Integer = 0
                Dim fila As Integer = 0
                Dim ident As String = String.Empty
                Dim lista As New List(Of String)
                For Each rows As DataRow In dtdetalleBultosPrincipal.Rows
                    ident = rows("IDENTIFICADOR")
                    If lista.Contains(ident) = False Then
                        lista.Add(ident)
                        Continue For
                    End If
                Next
                For i As Integer = 0 To lista.Count() - 1
                    For Each item As DataRow In dtdetalleBultosPrincipal.Select("IDENTIFICADOR=" & lista(i))
                        dtdetalleBultosPrincipal.BeginInit()
                        item("IDENTIFICADOR") = i + 1
                        dtdetalleBultosPrincipal.EndInit()
                        dtdetalleBultosPrincipal.AcceptChanges()
                    Next
                Next
            End If
        End If
    End Sub

    Private Sub txtNumeroReferencia_TextChanged(sender As Object, e As EventArgs)
        errores.SetError(txtNumeroReferencia, "")
    End Sub

    Private Sub txtTipoCambio_TextChanged(sender As Object, e As EventArgs)
        errores.SetError(txtTipoCambio, "")
    End Sub
    Private Sub CodigoProveedor()
        Dim frm As New bscProveedor
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtcodigoProveedor.Text = frm.Objeto
            lblproveedor.Text = frm.ObjetoDescripcion
        End If
    End Sub

    Private Sub txtcodigoProveedor_MouseDoubleClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles txtcodigoProveedor.MouseDoubleClick
        CodigoProveedor()
    End Sub
    Private Sub CodigoTercero()
        Dim frm As New bscCliente
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtcodigoTercero.Text = frm.Objeto
            lbltercero.Text = frm.ObjetoDescripcion
        End If
    End Sub


    Private Sub txtcodigoTercero_MouseDoubleClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles txtcodigoTercero.MouseDoubleClick
    CodigoTercero()
    End Sub

    Private Sub cmbTipoMovimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoMovimiento.SelectedIndexChanged
        If cmbTipoMovimiento.Items.Count() <> 0 Then
            If cmbTipoMovimiento.SelectedIndex = 0 Then
                GroupBox2.Enabled = False
                GroupBox3.Enabled = False
            Else
                GroupBox2.Enabled = True
                GroupBox3.Enabled = True
                MostrandoTipoTransacciones()
            End If
        End If

    End Sub

    Private Sub txtTipoDocumento_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtTipoDocumento.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtTipoDocumento.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub GenerarColummnaDataTable()
        dtdetalleBultosPrincipal = New DataTable
        dtdetalleBultosPrincipal.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("DATE_DOCUMENT", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("TYPE_TRANS", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
        dtdetalleBultosPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
        dtdetalleBultosPrincipal.Columns.Add("QTY_BULTOS", Type.GetType("System.Double"))
        dtdetalleBultosPrincipal.Columns.Add("IDENTIFICADOR", Type.GetType("System.String"))
    End Sub

    Private Sub frmNotaIngSal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        cmbMoneda.SelectedIndex = 1
        If ModoEdicion = True Then
            MostrarModoEdicion()
            gbCabceraDocumento.Enabled = False
            gbLeyenda.Visible = False
            btnAceptar.Visible = False
            dgvdetalleAlmacen.Visible = False
            GroupBox4.Visible = False
            txtTotal.Visible = False
            Label5.Visible = False
            dgvDetalle.Visible = True
            Exit Sub
        End If
        GenerarColummnaDataTable()
    End Sub

    Private Sub TipoDocumento()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "ALM_SP_S_WAREHOUSE_TIPO_DOCUMENTO"
        frm.CadenaConsulta = sql
        frm.Titulo = "Tipo de Documentos de Referencias"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtTipoDocumento.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            lblTipoDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
        txtNumeroReferencia.Focus()
    End Sub

    Private Sub txtTipoDocumento_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDocumento.MouseDoubleClick
        TipoDocumento()
    End Sub

    Private Sub txtComentarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComentarios.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtComentarios.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub
    Private Sub txtNumeroReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroReferencia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmbCentroCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCentroCosto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmbAlmacen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAlmacen.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtorderFabricacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtorderFabricacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcodigoProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcodigoTercero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoTercero.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmbTipoMovimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTipoMovimiento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtTipoDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDocumento.KeyDown
        If e.KeyCode = Keys.F1 Then
            TipoDocumento()
        End If
    End Sub

    Private Sub txtcodigoProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoProveedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            CodigoProveedor()
        End If
    End Sub

    Private Sub txtcodigoTercero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoTercero.KeyDown
        If e.KeyCode = Keys.F1 Then
            CodigoTercero()
        End If
    End Sub

    Private Sub txtordenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtordenCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub gbCabceraDocumento_Enter(sender As Object, e As EventArgs) Handles gbCabceraDocumento.Enter

    End Sub
End Class