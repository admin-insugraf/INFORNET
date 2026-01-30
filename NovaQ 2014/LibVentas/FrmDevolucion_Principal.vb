Imports LibCobranzas
Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing

Public Class FrmDevolucion_Principal

    Dim ClsdevolucionesBl As ClsOperaciones.DEVOLUTION
    Dim dtdatoscabecera As DataTable
    Dim dtdatosdetalle As DataTable
    Dim dtDocumentoGuias As DataTable
    Dim dtv As DataView
    Dim dtv_doc_cab As DataView
    Dim STRorden As String = String.Empty
    Dim clsReceivablaBl As ClsOperaciones.RECEIVABLE

    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Dim Filtracion As String = String.Empty
    Dim clsBusquedaBl As ClsBuscar
    Dim reporteBL As ClsBuscar
    Dim CORRELATIVOBL As ClsTransacciones.DEVOLUTION
    Dim clsArticuloBl As ClsOperaciones.PART
    Public dtdetallePrincipal As DataTable
    Dim clsIgvArticuloBL As ClsTransacciones.clsPedidos
    Dim dtIgvArticulo As DataTable
    Dim clsAlmacenCorrelativoBl As LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo

    Dim po_TasaIgv As Double
    Dim Igv As Double = 0.0
    Dim codigo As String = String.Empty

    Dim _TIPODOC As String = String.Empty
    Dim _SERIE As String = String.Empty
    Dim _NUMERO As String = String.Empty

    Dim _ALMACEN_IN As String = String.Empty
    Dim _DOCUMENT_IN As String = String.Empty
    Dim _NUMBER_DOCUMENT_IN As String = String.Empty

    Dim _OPTION_STATUS As String = String.Empty

    Dim Modo_consultar As Boolean = False
    Dim dtCabeceraDevol As New DataTable
    Dim dtDetalleDevol As New DataTable

    Dim _ESTADO_ORIGINAL As String = String.Empty



    Public Sub GenerarColummnaDataTable()
        Try
            dtdetallePrincipal = New DataTable("Devoluciones")
            dtdetallePrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetallePrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("PREC_UNITARIO", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("%DESC.ART_1", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("%DESC.ART_2", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("VALOR_VENTA", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("IMP_DESC_01", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("IMP_DESC_02", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("PRECIO_IGV", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("IGV_ART", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("IGV_ART_US", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("IMPORTE", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("PRECIO_INICIAL", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("TOTAL_INICIAL", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("MOTIVO_DEVOLUCION", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("OBSERVACIONES", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("FIN_DEVOLUCION_ID", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("TEXTO_FIN_DEVOLUCION_ID", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("ALMACEN_DESTINO", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("TD_REF", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("SERIE_REF", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("NUM_DOC_REF", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("SEL", Type.GetType("System.Boolean"))
            dtdetallePrincipal.Columns.Add("ESTADO", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("GENERO_NC_GUIA", Type.GetType("System.String"))
            dtdetallePrincipal.PrimaryKey = New DataColumn() {dtdetallePrincipal.Columns("ITEM")}
            dgvDetalle.DataSource = Nothing
            configurarGrilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub configurarGrilla()

        If dtdetallePrincipal.Rows.Count() <> 0 Then
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetallePrincipal
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            For i As Integer = 6 To 17
                dgvDetalle.Columns(i).Visible = False
            Next

            For i As Integer = 0 To dgvDetalle.Columns.Count - 1
                dgvDetalle.Columns(i).ReadOnly = True
            Next
            If _OPTION_STATUS = "2" Or _OPTION_STATUS = "3" Or _OPTION_STATUS = "4" Then
                dgvDetalle.Columns(26).ReadOnly = True
            Else
                dgvDetalle.Columns(26).ReadOnly = False
            End If
            If Modo_consultar = True Then
                dgvDetalle.Columns(22).Visible = False
            Else
                dgvDetalle.Columns(22).Visible = False
            End If

            If _OPTION_STATUS = "2" Or _OPTION_STATUS = "3" Then
                dgvDetalle.Columns(26).Visible = False
                dgvDetalle.Columns(27).Visible = False
                dgvDetalle.Columns(28).Visible = False
                dgvDetalle.Columns(26).DisplayIndex = 0
                dgvDetalle.Columns(27).DisplayIndex = 1
                If _OPTION_STATUS = "3" Then
                    If Modo_consultar = True Then
                        dgvDetalle.Columns(26).Visible = False
                    Else
                        dgvDetalle.Columns(26).Visible = False
                    End If
                End If
            ElseIf _OPTION_STATUS = "4" Then
                If Modo_consultar = True Then
                    dgvDetalle.Columns(26).Visible = False
                Else
                    dgvDetalle.Columns(26).Visible = False
                End If
                dgvDetalle.Columns(27).Visible = False
                dgvDetalle.Columns(28).Visible = False
                dgvDetalle.Columns(26).DisplayIndex = 0
                dgvDetalle.Columns(27).DisplayIndex = 1

            Else
                dgvDetalle.Columns(26).Visible = False
                dgvDetalle.Columns(27).Visible = False
                dgvDetalle.Columns(28).Visible = False
            End If
            dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0"
            dgvDetalle.Columns("PREC_UNITARIO").DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvDetalle.Columns(0).HeaderText = "Item"
            dgvDetalle.Columns(1).HeaderText = "Codigo"
            dgvDetalle.Columns(2).HeaderText = "Cantidad"
            dgvDetalle.Columns(3).HeaderText = "Unidad"
            dgvDetalle.Columns(4).HeaderText = "Descripción"
            dgvDetalle.Columns(5).HeaderText = "Lote"

            dgvDetalle.Columns(18).HeaderText = "Motivo de Devolución"
            dgvDetalle.Columns(19).HeaderText = "Obs. de Motivo de Devolución"
            dgvDetalle.Columns(20).HeaderText = "Fin de Devolución"
            dgvDetalle.Columns(21).HeaderText = "Obs. Fin de Devolución"

            dgvDetalle.Columns(23).HeaderText = "Doc. Referencia "
            dgvDetalle.Columns(24).HeaderText = "Serie Referencia"
            dgvDetalle.Columns(25).HeaderText = "Número Referencia"
        End If

    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnAnular.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnAnular.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
        End If
    End Sub


    Private Sub DocumentosDevoluciones()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            ClsdevolucionesBl = New ClsOperaciones.DEVOLUTION
            Dim dtDocumentos As New DataTable
            dtv = New DataView
            dtDocumentos = ClsdevolucionesBl.get_DatosGeneralesDevolucion(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                           cboopcionesBusqueda.SelectedIndex)
            dgvCabecera.DataSource = Nothing
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                For i As Integer = 0 To 2
                    dgvCabecera.Columns(i).Visible = False
                Next
                dgvCabecera.Columns(10).Visible = False
                dgvCabecera.Columns(11).Visible = False
                dgvCabecera.Columns(12).Visible = False
                dgvCabecera.Columns(13).Visible = False

                STRorden = dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(5).Name & "+" & dgvCabecera.Columns(6).Name & "+" & dgvCabecera.Columns(7).Name & "+" & dgvCabecera.Columns(9).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Else
                dgvCabecera.DataSource = Nothing
                'MsgBox("No hay Informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmDevolucion_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboopcionesBusqueda.SelectedIndex = 1
        cbo_filtro_opcion.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        Cargar_Almacen(cboalmacenDestino)
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtp_filtro_fecha_ini.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtp_filtro_fecha_fin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpFechadevol.Value = ClsVarComun.FechaSistema
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
        DocumentosDevoluciones()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            DocumentosDevoluciones()
        End If
    End Sub

    Private Sub dtpfechaInicial_KeyDown_1(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosDevoluciones()
        End If
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.DEVOLUTION
            CORRELATIVOBL.Get_NumeroCorrelativoDevolucion()
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                Correlativo = String.Format("{0:0000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
                txtSerie.Text = CORRELATIVOBL.NumeroSerie
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub limpiar()
        txttipoReferencia.Text = ""
        txtnumeroReferencia.Text = ""
        txtSerie.Text = ""
        txtcodigo.Text = ""
        dtpFechadevol.Text = ""
        cbodevolucion.Text = ""
        txtnumdevolucion.Text = ""
        txtCodCliente.Text = ""
        txtRazonSocial.Text = ""
        txtRucDni.Text = ""
        txtDireccion.Text = ""
        txtmoneda.Text = ""
        'txtTipoCambio.Text = ""
        txtobservacionAlmacen.Text = ""
        txtobservacionDireccion.Text = ""
        txtobservaciongerencia.Text = ""
        txtobservacionAlmacen.Enabled = False
        txtobservacionDireccion.Enabled = False
        txtobservaciongerencia.Enabled = False
        Modo_consultar = False
        _TIPODOC = String.Empty
        _SERIE = String.Empty
        _NUMERO = String.Empty
        _OPTION_STATUS = String.Empty
        'lbl_descripcion.Visible = False
        gbOpciones.Visible = True
        btnAgregar.Visible = True
        btnquitar.Visible = True
        cbodevolucion.SelectedIndex = -1
        cboalmacenDestino.SelectedIndex = 0
        dgvDetalle.DataSource = Nothing
        GbCabecera.Enabled = True
    End Sub

    Private Sub Nuevo()
        Try
            GenerarColummnaDataTable()
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            Modo_consultar = False
            GbCabecera.Enabled = True
            limpiar()
            txtcodigo.Text = Numeracion()
            txtobservacionAlmacen.Enabled = True
            txtobservacionDireccion.Enabled = False
            txtobservaciongerencia.Enabled = False
            _OPTION_STATUS = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub



    Private Sub MostrandoRelacionDocumentosDetalles(ByVal tipo As String, ByVal serie As String, ByVal numero As String)
        Try
            ClsdevolucionesBl = New ClsOperaciones.DEVOLUTION
            dtdatosdetalle = New DataTable
            dtdatosdetalle = ClsdevolucionesBl.get_DatosDetalleDevolucion(tipo, serie, numero)
            dgv_doc_detalle.DataSource = Nothing
            If dtdatosdetalle.Rows.Count() <> 0 Then
                dgv_doc_detalle.DataSource = dtdatosdetalle
                dgv_doc_detalle.AutoResizeColumns()
                dgv_doc_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                For i As Integer = 7 To 18
                    dgv_doc_detalle.Columns(i).Visible = False
                Next
                For i As Integer = 0 To dgv_doc_detalle.Columns.Count - 1
                    dgv_doc_detalle.Columns(i).ReadOnly = True
                Next
                dgv_doc_detalle.Columns(0).ReadOnly = False
                dgv_doc_detalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        ' GbCabecera.Enabled = False
        If cbodevolucion.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un tipo de devolucion.", MsgBoxStyle.Information)
            cbodevolucion.Select()
            Exit Sub
        ElseIf txtnumdevolucion.Text.Trim = "" Then
            MsgBox("Debe ingresar un numero de documento.", MsgBoxStyle.Information)
            txtnumdevolucion.Select()
            Exit Sub
        End If
        pnlDocumentos.Visible = True
        MostrandoRelacionDocumentos()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If dgvDetalle.RowCount <> 0 Then
            GbCabecera.Enabled = False
        Else
            GbCabecera.Enabled = True
        End If
        pnlDocumentos.Visible = False
        configurarGrilla()
        If rb_cliente.Checked = True Then
            rb_cliente.Checked = False
        ElseIf rb_lote.Checked = True Then
            rb_lote.Checked = False
        End If
        dgv_doc_cabecera.DataSource = Nothing
        dgv_doc_detalle.DataSource = Nothing
        ToolStrip1.Enabled = True
        txtbuscar.Text = ""
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If dgv_doc_cabecera.Rows.Count = 0 Then Exit Sub
        If dgv_doc_detalle.Rows.Count = 0 Then Exit Sub
        If dgv_doc_detalle.CurrentRow Is Nothing Then Exit Sub
        Dim Indicador = False
        Dim PuntoVentas As String = String.Empty
        For Each item As DataRow In dtdatosdetalle.Select("sel=True", "")
            Indicador = True
            Exit For
        Next
        If Indicador = False Then
            MsgBox("Debe marcar al menos un item, para continuar.", MsgBoxStyle.Critical)
            dgv_doc_detalle.Focus()
            Exit Sub
        End If
        ''  PuntoVentas = dgv_doc_cabecera.Item(10, dgv_doc_cabecera.CurrentRow.Index).Value
        If GbCabecera.Enabled = True Then
            txttipoReferencia.Text = dgv_doc_cabecera.Item(0, dgv_doc_cabecera.CurrentRow.Index).Value
            txtnumeroReferencia.Text = dgv_doc_cabecera.Item(1, dgv_doc_cabecera.CurrentRow.Index).Value & dgv_doc_cabecera.Item(2, dgv_doc_cabecera.CurrentRow.Index).Value
            txtCodCliente.Text = dgv_doc_cabecera.Item(4, dgv_doc_cabecera.CurrentRow.Index).Value
            txtRucDni.Text = dgv_doc_cabecera.Item(6, dgv_doc_cabecera.CurrentRow.Index).Value
            txtRazonSocial.Text = dgv_doc_cabecera.Item(5, dgv_doc_cabecera.CurrentRow.Index).Value
            txtDireccion.Text = dgv_doc_cabecera.Item(7, dgv_doc_cabecera.CurrentRow.Index).Value
            txtmoneda.Text = dgv_doc_cabecera.Item(8, dgv_doc_cabecera.CurrentRow.Index).Value
            'txtTipoCambio.Text = dgv_doc_cabecera.Item(9, dgv_doc_cabecera.CurrentRow.Index).Value
            GbCabecera.Enabled = False
        End If

        Dim Filtros_val As String = ""
        Filtros_val = "TD_REF= '" & dgv_doc_cabecera.Item(0, dgv_doc_cabecera.CurrentRow.Index).Value & "'" _
            & " and SERIE_REF='" & dgv_doc_cabecera.Item(1, dgv_doc_cabecera.CurrentRow.Index).Value & "'" _
            & " and NUM_DOC_REF='" & dgv_doc_cabecera.Item(2, dgv_doc_cabecera.CurrentRow.Index).Value & "'" _
            & " and CODIGO='" & dgv_doc_detalle.Item(2, dgv_doc_detalle.CurrentRow.Index).Value & "'" _
            & " and CANTIDAD='" & dgv_doc_detalle.Item(3, dgv_doc_detalle.CurrentRow.Index).Value & "'" _
             & " and PREC_UNITARIO='" & dgv_doc_detalle.Item(7, dgv_doc_detalle.CurrentRow.Index).Value & "'" _
            & " and LOTE='" & dgv_doc_detalle.Item(6, dgv_doc_detalle.CurrentRow.Index).Value & "'"
        Dim Producto() As DataRow = dtdetallePrincipal.Select(Filtros_val, "")
        If Producto.Count() <> 0 Then
            MsgBox("Ya se agrego el documento anteriormente.", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If
        For Each item As DataRow In dtdatosdetalle.Select("sel=True", "")
            Dim row As DataRow = dtdetallePrincipal.NewRow
            row("ITEM") = dtdetallePrincipal.Rows.Count() + 1
            row("CODIGO") = item("CODIGO")
            row("CANTIDAD") = item("CANTIDAD")
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
            row("IGV_ART_US") = item("IGV_ART_US")
            row("IMPORTE") = item("IMPORTE")
            row("PRECIO_INICIAL") = item("PRECIO_INICIAL")
            row("TOTAL_INICIAL") = item("TOTAL_INICIAL")
            row("OBSERVACIONES") = ""
            row("MOTIVO_DEVOLUCION") = ""
            row("FIN_DEVOLUCION_ID") = ""
            row("TEXTO_FIN_DEVOLUCION_ID") = ""
            row("ALMACEN_DESTINO") = ""
            row("TD_REF") = dgv_doc_cabecera.Item(0, dgv_doc_cabecera.CurrentRow.Index).Value
            row("SERIE_REF") = dgv_doc_cabecera.Item(1, dgv_doc_cabecera.CurrentRow.Index).Value
            row("NUM_DOC_REF") = dgv_doc_cabecera.Item(2, dgv_doc_cabecera.CurrentRow.Index).Value
            dtdetallePrincipal.Rows.Add(row)
            dtdetallePrincipal.AcceptChanges()
        Next
        btn_salir.PerformClick()
    End Sub

    Private Sub dgv_doc_cabecera_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_doc_cabecera.SelectionChanged
        If dgv_doc_cabecera.Rows.Count() = 0 Then Exit Sub
        If dgv_doc_cabecera.CurrentRow Is Nothing Then Exit Sub
        Dim Tipodoc As String = String.Empty
        Dim serie As String = String.Empty
        Dim numero As String = String.Empty
        Tipodoc = dgv_doc_cabecera.Item(0, dgv_doc_cabecera.CurrentRow.Index).Value
        serie = dgv_doc_cabecera.Item(1, dgv_doc_cabecera.CurrentRow.Index).Value
        numero = dgv_doc_cabecera.Item(2, dgv_doc_cabecera.CurrentRow.Index).Value
        MostrandoRelacionDocumentosDetalles(Tipodoc, serie, numero)
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If txtbuscar.Text = String.Empty Then
            dtv_doc_cab.RowFilter = String.Empty
            Exit Sub
        Else
            dtv_doc_cab.RowFilter = Filtracion & " like '%" & txtbuscar.Text & "%'"
            If dtv_doc_cab.Count() = 0 Then
                Filtracion = String.Empty
                Filtracion = dgv_doc_cabecera.Columns(2).Name
                dtv_doc_cab.RowFilter = Filtracion & " like '%" & txtbuscar.Text & "%'"
                If dtv_doc_cab.Count() = 0 Then
                    Filtracion = String.Empty
                    Filtracion = dgv_doc_cabecera.Columns(4).Name
                    dtv_doc_cab.RowFilter = Filtracion & " like '%" & txtbuscar.Text & "%'"
                    If dtv_doc_cab.Count() = 0 Then
                        Filtracion = String.Empty
                        Filtracion = dgv_doc_cabecera.Columns(2).Name & "+" & dgv_doc_cabecera.Columns(4).Name & "+" & dgv_doc_cabecera.Columns(5).Name
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then

        ElseIf txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns(3).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns(5).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(5).Name & "+" & dgvCabecera.Columns(6).Name & "+" & dgvCabecera.Columns(7).Name & "+" & dgvCabecera.Columns(9).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cbodevolucion.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un tipo de devolucion.", MsgBoxStyle.Information)
            cbodevolucion.Select()
            Exit Sub
        ElseIf txtnumdevolucion.Text.Trim = "" Then
            MsgBox("Debe ingresar un numero de documento.", MsgBoxStyle.Information)
            txtnumdevolucion.Select()
            Exit Sub
        End If
        pnlDocumentos.Visible = True
        gb_detalles_art.Enabled = True
        rb_cliente.Checked = True
        cbo_filtro_opcion.SelectedIndex = 1
        dtp_filtro_fecha_ini.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtp_filtro_fecha_fin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        ToolStrip1.Enabled = False
        ' MostrandoRelacionDocumentos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
    End Sub

    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & Codigo)
                    dtdetallePrincipal.BeginInit()
                    item.Delete()
                    dtdetallePrincipal.EndInit()
                    dtdetallePrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetallePrincipal.Rows
            i += 1
            dtdetallePrincipal.BeginInit()
            items("ITEM") = i
            dtdetallePrincipal.EndInit()
            dtdetallePrincipal.AcceptChanges()
        Next
    End Sub

    Private Sub MostrarFechaVencimiento(ByVal codigooLote As String)
        Dim cadena As String = String.Empty
        Dim dtTableFecha As New DataTable
        Dim LibData As New LibConexion.ClsData
        cadena = "SELECT DISTINCT CADUCATE_DATE FROM LOT  WHERE  PART_ID ='" & txtcodigoArticulo.Text & "' and  LOT_ID='" & codigooLote & "'"
        Dim fecha As String = String.Empty
        dtTableFecha = LibData.Run_Query_DataTable(cadena)
        LibData.Dispose()
        If dtTableFecha.Rows.Count() <> 0 Then
            fecha = dtTableFecha.Rows(0).Item(0).ToString()
            dtpVencimiento.Text = Format(fecha, "Short date")
        End If
    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvDetalle.RowCount() = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        Dim tempArray() As String
        pnlmodificacionDoc.Visible = True
        gbOpciones.Enabled = False
        codigo = String.Empty
        codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
        Limpiando()
        If _OPTION_STATUS <> "" Then
            cboalmacenDestino.Visible = True
            txtalmacendestino.Visible = True
            gb_detalles_art.Enabled = False
            cboalmacenDestino.SelectedIndex = 0
        Else
            txtalmacendestino.Visible = False
            cboalmacenDestino.Visible = False
            gb_detalles_art.Enabled = True
        End If
        For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & codigo)
            txtcodigoArticulo.Text = item("CODIGO")
            txtcantidad.Text = CDbl(item("CANTIDAD"))
            txtunidadMedida.Text = item("UNIDAD")
            txtdescripcionArticulo.Text = item("DESCRIPCION")
            If item("LOTE") = String.Empty Then
                txtlote.Text = item("LOTE")
            Else
                txtlote.Text = item("LOTE")
                MostrarFechaVencimiento(txtlote.Text)
            End If
            txtprecioUnitario.Text = item("PREC_UNITARIO")
            txtdescuento1.Text = item("%DESC.ART_1")
            txtdescuento2.Text = item("%DESC.ART_2")
            txtobservacionProducto.Text = item("OBSERVACIONES")
            If item("MOTIVO_DEVOLUCION") <> "" Then
                tempArray = Split(item("MOTIVO_DEVOLUCION"), ",")

                For i = LBound(tempArray) To UBound(tempArray)
                    For Each Control As Control In gbmotivodevolucion.Controls
                        If TypeOf Control Is CheckBox Then
                            If tempArray(i) = CType(Control, CheckBox).Text Then
                                CType(Control, CheckBox).Checked = True
                                Exit For
                            End If
                        End If
                    Next
                Next i
            End If
            

            'For Each Control As Control In gbmotivodevolucion.Controls
            '    If TypeOf Control Is RadioButton Then
            '        If item("MOTIVO_DEVOLUCION") = "" Then
            '            If CType(Control, RadioButton).Text = "Otros" Then
            '                CType(Control, RadioButton).Checked = True
            '                Exit For
            '            End If
            '        Else
            '            If item("MOTIVO_DEVOLUCION") = CType(Control, RadioButton).Text Then
            '                CType(Control, RadioButton).Checked = True
            '                Exit For
            '            End If
            '        End If
            '    End If
            'Next
            For Each Control As Control In gbFinDevolucion.Controls
                If TypeOf Control Is RadioButton Then
                    If item("FIN_DEVOLUCION_ID") = "" Then
                        If CType(Control, RadioButton).Text = "Otros" Then
                            CType(Control, RadioButton).Checked = True
                            Exit For
                        End If
                    Else
                        If item("FIN_DEVOLUCION_ID") = CType(Control, RadioButton).Text Then
                            CType(Control, RadioButton).Checked = True
                            Exit For
                        End If
                    End If
                End If
            Next
            txtobservacionesOtros.Text = item("TEXTO_FIN_DEVOLUCION_ID")
            If _OPTION_STATUS <> "" Then
                If String.IsNullOrEmpty(item("ALMACEN_DESTINO").ToString) Then
                    cboalmacenDestino.SelectedIndex = 0
                Else
                    cboalmacenDestino.SelectedValue = TraerCodigo(item("ALMACEN_DESTINO").ToString)
                End If
            Else
                txtalmacendestino.Visible = False
                cboalmacenDestino.Visible = False
            End If
        Next
    End Sub

    Private Sub Limpiando()
        txtcodigoArticulo.Text = String.Empty
        txtdescripcionArticulo.Text = String.Empty
        txtunidadMedida.Text = String.Empty
        txtcantidad.Text = String.Empty
        txtlote.Text = String.Empty
        txtprecioUnitario.Text = String.Empty
        txtdescuento1.Text = String.Empty
        txtdescuento2.Text = String.Empty
        'RadioButton6.Checked = True
        RadioButton7.Checked = True
        txtobservacionProducto.Text = String.Empty
        txtobservacionesOtros.Text = String.Empty
        dtpVencimiento.Text = ""
        cboalmacenDestino.SelectedIndex = 0
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox10.Checked = False
    End Sub

    Private Sub Limpiando_IngresoManual()
        TextBox6.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox7.Text = String.Empty
        MaskedTextBox1.Text = String.Empty
        TextBox2.Text = String.Empty


        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlmodificacionDoc.Visible = False
        Limpiando()
        gbOpciones.Enabled = True
        ToolStrip1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtcantidad.Text = String.Empty Then
            MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Critical)
            txtcantidad.Focus()
            Exit Sub
        End If
        If txtcantidad.Text = 0 Then
            MsgBox("Debe ingresar una cantidad diferente de 0.", MsgBoxStyle.Critical)
            txtcantidad.Focus()
            Exit Sub
        End If
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False And CheckBox10.Checked = False Then
            MsgBox("Debe elegir un Motivo de Devolución.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If _OPTION_STATUS <> "" Then
            'If cboalmacenDestino.SelectedIndex = 0 Then
            '    MsgBox("Debe seleccionar un almacen de destino.", MsgBoxStyle.Critical)
            '    cboalmacenDestino.Focus()
            '    Exit Sub
            'End If
        End If
        Dim _motivos As String = String.Empty
        For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & codigo)
            dtdetallePrincipal.BeginInit()
            item("CANTIDAD") = txtcantidad.Text
            item("OBSERVACIONES") = txtobservacionProducto.Text
            For Each Control As Control In gbmotivodevolucion.Controls
                If TypeOf Control Is CheckBox Then
                    If CType(Control, CheckBox).Checked = True Then
                        _motivos = _motivos & CType(Control, CheckBox).Text & ","
                        ' Exit For
                    End If
                End If
            Next
            If _motivos <> "" Then
                _motivos = Strings.Mid(_motivos, 1, Len(_motivos) - 1)
            End If
            item("MOTIVO_DEVOLUCION") = _motivos

            For Each Control As Control In gbFinDevolucion.Controls
                If TypeOf Control Is RadioButton Then
                    If CType(Control, RadioButton).Checked = True Then
                        item("FIN_DEVOLUCION_ID") = CType(Control, RadioButton).Text
                        Exit For
                    End If
                End If
            Next
            item("TEXTO_FIN_DEVOLUCION_ID") = txtobservacionesOtros.Text
            If _OPTION_STATUS = "" Then
                item("ALMACEN_DESTINO") = ""
            Else
                item("ALMACEN_DESTINO") = IIf(cboalmacenDestino.SelectedIndex = 0, "", cboalmacenDestino.Text.ToString)
            End If
            dtdetallePrincipal.EndInit()
            dtdetallePrincipal.AcceptChanges()
        Next
        Button1.PerformClick()
    End Sub

    Private Function GuardarModificarDevoluciones() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            Me.Cursor = Cursors.WaitCursor
            Dim cabeceraBL As New ClsOperaciones.DEVOLUTION
            Dim cabeceraBE As New ClsEntidades.DEVOLUTION
            Dim ls_det As New List(Of ClsEntidades.DEVOLUTION_LINE)
            Dim detalle As New ClsEntidades.DEVOLUTION_LINE

            Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Dim numero_bultos As String
            Dim qty_bultos As Double

            With cabeceraBE
                .DOCUMENT_ID = txttipoDoc.Text
                If Modo_consultar = True Then
                    .NUMBER_DOCUMENT = txtcodigo.Text
                Else
                    .NUMBER_DOCUMENT = Numeracion()
                End If
                .NUMBER_SERIE = txtSerie.Text
                .DOCUMENT_DATE = dtpFechadevol.Value.ToString("dd/MM/yyyy")
                .CADUCATE_DATE = dtpFechadevol.Value.ToString("dd/MM/yyyy")
                .DR_CR = "D"
                .SALES_REP_ID = ""
                .PLACE_SALES = ""
                .NUMBER_QUOTE = 0
                .NUMBER_ORDER_PUR = ""
                .CFDESCPG = 0
                .POINT_ORIG = 0
                .POINT_BOARD = 0
                .POINT_ARRIVAL = 0
                .RECEIVABLE_TYPE = txttipoDoc.Text
                .CUSTOMER_ID = txtCodCliente.Text.Trim
                .CUSTOMER_NAME = txtRazonSocial.Text.Trim
                .CUSTOMER_ADDR = txtDireccion.Text.Trim
                .VAT_REGISTRATION = txtRucDni.Text.Trim
                .WAREHOUSE_ID = ""
                .AMOUNT = 0
                .TERMS_ID = ""
                .BALANCE = 0
                .SELL_RATE = CDbl(txtTipoCambio.Text)
                .CURRENCY_ID = txtmoneda.Text
                .DOCUMENT_REF = ""
                .SERIE_REF = ""
                .NUMBER_REF = ""
                .NUMBER_ORDER = ""
                .CREATE_DATE = Date.Now.ToShortDateString
                .STATUS = "V"
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .COMMENT = ""
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
                .AMOUNT_TAX = 0
                .DISCOUNTV = 0
                .DISCOUNTP = 0
                .LIST_GUIA = ""
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
                .DOCUMENT_TYPE_COMP_PER = ""
                .SERIE_COMP_PER = ""
                .NUMBER_COMP_PER = ""
                .COMMENT_ALMACEN = txtobservacionAlmacen.Text
                .FECHA_COMMENT_ALMACEN = Date.Now.ToShortDateString
                .HORA_COMMENT_ALMACEN = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .COMMENT_DIR = txtobservacionDireccion.Text
                .FECHA_COMMENT_DIR = ""
                .HORA_COMMENT_DIR = ""
                .COMMENT_GER = txtobservaciongerencia.Text
                .FECHA_COMMENT_GER = ""
                .HORA_COMMENT_GER = ""
                If Modo_consultar = False Then
                    .ESTADO = "EMITIDO"
                    .OPCION_ESTADO = "1"
                Else
                    Select Case _OPTION_STATUS
                        Case "1"
                            .ESTADO = "TRAMITE A CONTROL DE CALIDAD"
                            .OPCION_ESTADO = 2
                        Case "2"
                            .ESTADO = "ACTUALIZADO GERENCIA DE VENTAS"
                            .OPCION_ESTADO = 3
                    End Select
                End If
                .MOTIVO_DEVOLUCION_ID = ""
                .TEXTO_MOTIVO_DEVOLUCION = ""
                .DOC_DEVOLUCION = cbodevolucion.Text & "-" & txtnumdevolucion.Text
                .FIN_DEVOLUCION_ID = ""
                .TEXTO_FIN_DEVOLUCION_ID = ""
                .DATE_DOC_DEVOLUCION = dtpFechaDevolucion.Value.ToString("dd/MM/yyyy")
            End With

            'Detalle de Factura
            For i As Integer = 0 To dtdetallePrincipal.Rows.Count() - 1
                detalle = New ClsEntidades.DEVOLUTION_LINE
                With detalle
                    .DOCUMENT_ID = txttipoDoc.Text
                    .NUMBER_SERIE = txtSerie.Text
                    .NUMBER_DOCUMENT = cabeceraBE.NUMBER_DOCUMENT
                    .ITEM = dtdetallePrincipal.Rows(i).Item("ITEM")
                    .PART_ID = dtdetallePrincipal.Rows(i).Item("CODIGO")
                    .QTY = dtdetallePrincipal.Rows(i).Item("CANTIDAD")
                    .PRICE_SALES = Math.Abs(dtdetallePrincipal.Rows(i).Item("PRECIO_IGV"))
                    .PRICE_ORI = Math.Abs(dtdetallePrincipal.Rows(i).Item("PREC_UNITARIO"))
                    .DISCOUNT = 0
                    .AMOUNT_TAX = dtdetallePrincipal.Rows(i).Item("IGV_ART")
                    .TAX_PERCENT = 18
                    .AMOUNT_US = dtdetallePrincipal.Rows(i).Item("IGV_ART_US")
                    .AMOUNT = dtdetallePrincipal.Rows(i).Item("IMPORTE")
                    .UNIT = dtdetallePrincipal.Rows(i).Item("UNIDAD")
                    .STATUS = "V"
                    .PART_SERIE = 0
                    .WAREHOUSE_ID = "04"
                    .TEXT_DESCRIPTION = ""
                    .DFTR = 0
                    .STOCK = 0
                    .PART_DESCRIPTION = dtdetallePrincipal.Rows(i).Item("DESCRIPCION")
                    .QTY_REF = 0
                    .DISCOUNT_PERCENT = 0
                    .BALANCE_PART = 0
                    .DISCOUNT_CUSTOMER = 0
                    .DISCOUNT_SP = 0
                    .PART_LOT = dtdetallePrincipal.Rows(i).Item("LOTE")
                    .NUMBER_GUIA = 0
                    .PART_TAX = 0
                    .DISCOUNT1 = Math.Abs(dtdetallePrincipal.Rows(i).Item("IMP_DESC_01"))
                    .DISCOUNT2 = Math.Abs(dtdetallePrincipal.Rows(i).Item("IMP_DESC_02"))
                    .PERCENT1 = Math.Abs(dtdetallePrincipal.Rows(i).Item("%DESC.ART_1"))
                    .PERCENT2 = Math.Abs(dtdetallePrincipal.Rows(i).Item("%DESC.ART_2"))
                    .PRICE_LIST_ID = 0
                    .SHIPPER_QTY = 0
                    .BUDGET_ID = 0
                    .ORDER_ID = 0
                    .BRUTE_QTY = 0
                    .DISCOUNT_QTY_BRUTE = 0
                    .UM_REFERENCE = 0
                    .QTY_REFERENCE = 0
                    .COMISION = 0
                    .OBSERVACIONES = dtdetallePrincipal.Rows(i).Item("OBSERVACIONES")
                    .MOTIVO_DEVOLUCION = dtdetallePrincipal.Rows(i).Item("MOTIVO_DEVOLUCION")
                    .FIN_DEVOLUCION_ID = dtdetallePrincipal.Rows(i).Item("FIN_DEVOLUCION_ID")
                    .TEXTO_FIN_DEVOLUCION_ID = dtdetallePrincipal.Rows(i).Item("TEXTO_FIN_DEVOLUCION_ID")
                    If String.IsNullOrEmpty(dtdetallePrincipal.Rows(i).Item("ALMACEN_DESTINO").ToString) Then
                        .ALMACEN_DESTINO = ""
                    Else
                        .ALMACEN_DESTINO = TraerCodigo(dtdetallePrincipal.Rows(i).Item("ALMACEN_DESTINO").ToString)
                    End If
                    .TD_REF = dtdetallePrincipal.Rows(i).Item("TD_REF")
                    .SERIE_REF = dtdetallePrincipal.Rows(i).Item("SERIE_REF")
                    .NUM_DOC_REF = dtdetallePrincipal.Rows(i).Item("NUM_DOC_REF")
                    .OPT_APROB = IIf(String.IsNullOrEmpty(dtdetallePrincipal.Rows(i).Item("ESTADO").ToString), "", dtdetallePrincipal.Rows(i).Item("ESTADO"))
                    .GENERO_NC_GUIA = IIf(String.IsNullOrEmpty(dtdetallePrincipal.Rows(i).Item("GENERO_NC_GUIA").ToString), "", dtdetallePrincipal.Rows(i).Item("GENERO_NC_GUIA"))
                End With
                ls_det.Add(detalle)
            Next

            If Modo_consultar = False Then
                clsAlmacenCorrelativoBl = New LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo
                clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen("04", "I")
                'la parte de almacen
                With alm_cabBE
                    .WAREHOUSE_ID = "04"
                    .DOCUMENT_ID = "NI"
                    .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                    cabeceraBE.WAREHOUSE_ID_IN = "04"
                    cabeceraBE.DOCUMENT_ID_IN = "NI"
                    cabeceraBE.NUMBER_DOCUMENT_IN = .NUMBER_DOCUMENT
                    .DATE_DOCUMENT = dtpFechadevol.Value.ToString("dd/MM/yyyy")
                    .TYPE_TRANS = "I"
                    .TRANS_ID = "DD"
                    .DOC_ID_REF = txttipoDoc.Text.Trim
                    .NUM_ID_REF = cabeceraBE.NUMBER_DOCUMENT
                    .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .VAT_REGISTRATION = txtRucDni.Text.Trim 'Ruc..
                    .ADDR_DLV = txtDireccion.Text.Trim  'Direccion ..
                    .VENDOR_ID = ""
                    .VENDOR_NAME = ""
                    .CUSTOMER_ID = txtCodCliente.Text.Trim
                    .CUSTOMER_NAME = txtRazonSocial.Text.Trim
                    .SALES_TERM = ""
                    .CURRENCY_TYPE = txtmoneda.Text.Trim
                    .CURRENCY_EXCHANGE = LibComunVar.ClsVarComun.TCVenta
                    .STATUS_GUIA = "V"
                    .AMOUNT = 0
                    .COMMENT = ""
                    .TYPE_GUIA = .TRANS_ID
                    .WAREHOUSE_REF = ""
                    .UPDATE_DATE = Date.Now()
                    .NUM_ORDER_MANUFACT = ""
                    .NUMBER_PURCHASE = ""
                    '.STATUS_CONTROL = "C"
                    .IS_COD_PRODUCTO = ""
                End With
                'Detalle de la Guia...
                For i As Integer = 0 To dtdetallePrincipal.Rows.Count() - 1
                    alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                    With alm_detBE
                        .WAREHOUSE_ID = "04"
                        .DOCUMENT_ID = "NI"
                        .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
                        .ITEM = dtdetallePrincipal.Rows(i).Item("ITEM").ToString
                        .PART_ID = dtdetallePrincipal.Rows(i).Item("CODIGO").ToString
                        .QTY = dtdetallePrincipal.Rows(i).Item("CANTIDAD").ToString
                        .QTY_DLV = 0
                        .QTY_REF = dtdetallePrincipal.Rows(i).Item("CANTIDAD").ToString
                        .QTY_INVOICED = 0
                        .AMOUNT_SALES = 0
                        .AVERAGE_COST = 0
                        .PART_DESCRIPTION = dtdetallePrincipal.Rows(i).Item("DESCRIPCION")
                        .UNIT_PART = dtdetallePrincipal.Rows(i).Item("UNIDAD").ToString
                        .NUMBER_LOT = dtdetallePrincipal.Rows(i).Item("LOTE").ToString
                        .WAREHOUSE_REF = ""
                        .ACCOUNT = ""
                        '.STATUS_VALUE = IIf(chkValorizado.Checked = True, True, False)
                        .NUM_PROTOCOLOS = ""
                        .OPT_ENTREGA = ""
                        numero_bultos = ""
                        If numero_bultos = "" Then
                            qty_bultos = 0
                        Else
                            qty_bultos = CDbl(numero_bultos)
                        End If
                        'qty_bultos = IIf(numero_bultos = "", 0, CDbl(numero_bultos))
                        .QT_BULTOS = qty_bultos 'dtdetalleArticuloPrincipal.Rows(i).Item("NRO_BULTOS").ToString
                        .PROCEDENCIA = ""
                        .PAIS_ORIGEN = ""
                        .CURRENCY_ID = txtmoneda.Text.Trim
                        .STATUS_VALUE = 0
                        .NUMBER_ANALIS = ""
                    End With
                    ls_det_alm.Add(alm_detBE)
                Next
            Else
                cabeceraBE.WAREHOUSE_ID_IN = _ALMACEN_IN
                cabeceraBE.DOCUMENT_ID_IN = _DOCUMENT_IN
                cabeceraBE.NUMBER_DOCUMENT_IN = _NUMBER_DOCUMENT_IN
            End If
            

            ''GUARDANDO DATOS DE LA FACTURACION
            If Modo_consultar = True Then
                If cabeceraBL.ActualizarDevoluciones(cabeceraBE, ls_det) = False Then
                    MsgBox("Hubo un Error en la Actualizacion de la devolucion", MsgBoxStyle.Critical)
                    indicadorF = False
                    Me.Cursor = Cursors.Default
                    Exit Try
                End If
                EnviarMail_Devoluciones(cabeceraBE.DOCUMENT_ID, cabeceraBE.NUMBER_SERIE, cabeceraBE.NUMBER_DOCUMENT, cabeceraBE.OPCION_ESTADO.Trim, "06")
            Else
                If cabeceraBL.GuardarDevoluciones(cabeceraBE, ls_det, alm_cabBE, ls_det_alm) = False Then
                    MsgBox("Hubo un Error en la Generacion de la devolucion", MsgBoxStyle.Critical)
                    indicadorF = False
                    Me.Cursor = Cursors.Default
                    Exit Try
                Else

                    Call Actualiza_Lotes_Devolucion("04", "NI", alm_cabBE.NUMBER_DOCUMENT)

                    Dim msj As String = String.Empty
                    msj = String.Empty
                    msj = "Nuevo Documento Generado Correctamente," & vbCrLf & " Nro Documento: " & "NI" & " - " & alm_cabBE.NUMBER_DOCUMENT
                    MsgBox(msj, MsgBoxStyle.Information)
                    If MessageBox.Show("Se procedera a la Impresion del Documento" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        'Imprimir ingreso o salida  Almacen
                        imprimirAlmacen("04", "NI", alm_cabBE.NUMBER_DOCUMENT)
                    End If
                    EnviarMail_Devoluciones(cabeceraBE.DOCUMENT_ID, cabeceraBE.NUMBER_SERIE, cabeceraBE.NUMBER_DOCUMENT, cabeceraBE.OPCION_ESTADO, "05")
                End If

            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
        Return indicadorF
    End Function
    Private Sub imprimirAlmacen(ByVal _idalamacen As String, ByVal _documentid As String, ByVal _numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(_idalamacen, _documentid, _numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                If _idalamacen = "01" And _idalamacen = "04" Then
                    crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                Else
                    crystalBL.Muestra_Reporte("rpt_Mov_Almacen_Guia_Analisis.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   
    Public Sub Actualiza_Lotes_Devolucion(ByVal _almacen As String, ByVal _td As String, ByVal _numero As String)

        Try
            Dim dt_ingreso_general As DataTable
            Dim dt_lista_almacenes As DataTable
            Dim dt_existe As DataTable
            Dim dt_datos_lote As DataTable
            Dim cadena As String
            ClsdevolucionesBl = New ClsOperaciones.DEVOLUTION
            dt_ingreso_general = ClsdevolucionesBl.get_DatosGeneralesIngreso_Devolucion(_almacen, _td, _numero)
            dt_lista_almacenes = ClsdevolucionesBl.get_almacen()

            If dt_ingreso_general.Rows.Count > 0 Then
                For I As Integer = 0 To dt_ingreso_general.Rows.Count - 1
                    If dt_lista_almacenes.Rows.Count > 0 Then
                        For J As Integer = 0 To dt_lista_almacenes.Rows.Count - 1
                            If dt_ingreso_general.Rows(I).Item("IS_LOT").ToString = "S" Then
                                'VERIFICO SI EXISTE EN EL LOTE
                                dt_existe = ClsdevolucionesBl.get_Existe_Lote(dt_lista_almacenes.Rows(J).Item("ID").ToString, dt_ingreso_general.Rows(I).Item("PART_ID").ToString, dt_ingreso_general.Rows(I).Item("NUMBER_LOT").ToString)
                                If dt_existe.Rows.Count = 0 Then
                                    dt_datos_lote = ClsdevolucionesBl.get_Datos_Lote(dt_lista_almacenes.Rows(J).Item("ID").ToString, dt_ingreso_general.Rows(I).Item("PART_ID").ToString, dt_ingreso_general.Rows(I).Item("NUMBER_LOT").ToString)
                                    If dt_datos_lote.Rows.Count > 0 Then
                                        cadena = "INSERT INTO dbo.LOT (WHO_ID, PART_ID, LOT_ID, QTY_ON_HAND, MANUFACT_DATE, CADUCATE_DATE, QTY_RESERVE, COMMENT, COD_BARRAS, VALORACION) "
                                        cadena = cadena & "VALUES ('" & dt_lista_almacenes.Rows(J).Item("ID").ToString & "', '" & dt_ingreso_general.Rows(I).Item("PART_ID").ToString & "', '" & dt_ingreso_general.Rows(I).Item("NUMBER_LOT").ToString & "', 0,'" & dt_datos_lote.Rows(0).Item("FABRICACION").ToString & "', '" & dt_datos_lote.Rows(0).Item("VCTO").ToString & "', NULL, NULL, NULL, NULL)"
                                    Else
                                        cadena = "INSERT INTO dbo.LOT (WHO_ID, PART_ID, LOT_ID, QTY_ON_HAND, MANUFACT_DATE, CADUCATE_DATE, QTY_RESERVE, COMMENT, COD_BARRAS, VALORACION) "
                                        cadena = cadena & "VALUES ('" & dt_lista_almacenes.Rows(J).Item("ID").ToString & "', '" & dt_ingreso_general.Rows(I).Item("PART_ID").ToString & "', '" & dt_ingreso_general.Rows(I).Item("NUMBER_LOT").ToString & "', 0,'', '', NULL, NULL, NULL, NULL)"
                                    End If
                                    clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                                    clsReceivablaBl.Ejecuta_consulta(cadena)
                                End If
                                'VERIFICO SI EXISTE EN EL PART_QTY
                                dt_existe = ClsdevolucionesBl.get_Existe_Part_Qty(dt_lista_almacenes.Rows(J).Item("ID").ToString, dt_ingreso_general.Rows(I).Item("PART_ID").ToString, dt_ingreso_general.Rows(I).Item("NUMBER_LOT").ToString)
                                If dt_existe.Rows.Count = 0 Then
                                    cadena = "INSERT INTO dbo.PART_QTY (WAREHOUSE_ID, PART_ID, QTY_ON_HAND, MIN_QTY, MAX_QTY, QTY_ON_ORDER, WEEK_SUPPLY, CLASIFICATION_ID, WHS_LOCATION, TYPE_BUY, QTY_RESERVE, COST_AVG, LAST_PRICE, LAST_RECEIVED_DATE, COST_AVG_US, QTY_REFERENCE) "
                                    cadena = cadena & "VALUES ('" & dt_lista_almacenes.Rows(J).Item("ID").ToString & "', '" & dt_ingreso_general.Rows(I).Item("PART_ID").ToString & "', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, '', 0, 0)"
                                    clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                                    clsReceivablaBl.Ejecuta_consulta(cadena)
                                End If

                            ElseIf dt_ingreso_general.Rows(I).Item("IS_STOCKED").ToString = "S" Then
                                'VERIFICO SI EXISTE EN EL PART_QTY
                                dt_existe = ClsdevolucionesBl.get_Existe_Part_Qty(dt_lista_almacenes.Rows(J).Item("ID").ToString, dt_ingreso_general.Rows(I).Item("PART_ID").ToString, dt_ingreso_general.Rows(I).Item("NUMBER_LOT").ToString)
                                If dt_existe.Rows.Count = 0 Then
                                    cadena = "INSERT INTO dbo.PART_QTY (WAREHOUSE_ID, PART_ID, QTY_ON_HAND, MIN_QTY, MAX_QTY, QTY_ON_ORDER, WEEK_SUPPLY, CLASIFICATION_ID, WHS_LOCATION, TYPE_BUY, QTY_RESERVE, COST_AVG, LAST_PRICE, LAST_RECEIVED_DATE, COST_AVG_US, QTY_REFERENCE) "
                                    cadena = cadena & "VALUES ('" & dt_lista_almacenes.Rows(J).Item("ID").ToString & "', '" & dt_ingreso_general.Rows(I).Item("PART_ID").ToString & "', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, '', 0, 0)"

                                    clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                                    clsReceivablaBl.Ejecuta_consulta(cadena)

                                End If

                            End If

                        Next


                    End If
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function TraerCodigo(ByVal cadena As String) As String
        Dim resul As String = ""
        Try
            If InStr(cadena, ":") = 0 Then
                resul = ""
            Else
                If cadena.Length > 0 Then
                    resul = Mid(cadena, 1, InStr(cadena, ":") - 1)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.InnerException, MsgBoxStyle.Critical)
        End Try
        Return resul
    End Function

    Private Sub EnviarMail(ByVal _Tipodoc As String, _Serie As String, ByVal Numerodoc As String, ByVal TipoEstado As String)
        Try
            Dim envio_mail As New LibManufactura.FrmEnvioEmail
            envio_mail._document_id = _Tipodoc
            envio_mail._serie_doc = _Serie
            envio_mail._number_document = Numerodoc
            envio_mail._codigo_datos_email = "01"
            envio_mail._TIPO_ESTADO = TipoEstado
            envio_mail.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnviarMail_Devoluciones(ByVal _Tipodoc As String, _Serie As String, ByVal Numerodoc As String, ByVal TipoEstado As String, ByVal Estado As String)
        Try
            Dim envio_mail As New LibManufactura.FrmEnvioEmail
            envio_mail._document_id = _Tipodoc
            envio_mail._serie_doc = _Serie
            envio_mail._number_document = Numerodoc
            envio_mail._codigo_datos_email = Estado
            envio_mail._TIPO_ESTADO = TipoEstado
            envio_mail.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalle.RowCount() = 0 Then Exit Sub
        Dim Mensaje As String = ""
        If Modo_consultar = True Then
            Mensaje = "¿Desea Actualizar la Devolucion.?"
            'Dim Flag_indicador As Boolean = False
            'For Each row As DataRow In dtdetallePrincipal.Select("ALMACEN_DESTINO IS NULL", "")
            '    Flag_indicador = True
            '    Exit For
            'Next
            'If Flag_indicador = True Then
            '    MsgBox("No se ingreso un almacen  de referencia.", MsgBoxStyle.Critical)
            '    btnModificar.PerformClick()
            '    cboalmacenDestino.Select()
            '    Exit Sub
            'End If
        Else
            Mensaje = "¿Desea Generar la Devolucion.?"
        End If
        If MessageBox.Show(Mensaje, "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If GuardarModificarDevoluciones() = True Then
                If Modo_consultar = True Then
                    MsgBox("Actualizado Exitosamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("Guardado Exitosamente.", MsgBoxStyle.Information)
                End If

                btnCancelar_Click(sender, e)

            End If

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim msj As String = String.Empty
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim Estado_Dev As String = ""
        Dim Estado_Doc As String = ""
        _TIPODOC = String.Empty
        _SERIE = String.Empty
        _NUMERO = String.Empty
        Estado_Dev = dgvCabecera.Item(10, dgvCabecera.CurrentRow.Index).Value
        If Estado_Dev = "4" Or Estado_Dev = "3" Then
            MsgBox("Para Eliminar el documento seleccionado " & vbCrLf & "debe eliminarce primero en los documentos " & Chr(13) & " donde se encuentra anexado.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Eliminar el Documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Me.Cursor = Cursors.WaitCursor
            Dim Usuario As String = LibComunVar.ClsVarComun.USUARIO
            Dim cabeceraBL As New ClsOperaciones.DEVOLUTION
            _TIPODOC = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            _SERIE = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
            _NUMERO = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value


            If cabeceraBL.EliminacionDevolucion(Usuario, _TIPODOC, _SERIE, _NUMERO) = False Then
                MsgBox("Hubo un error, no se completo el Proceso de Eliminacion", MsgBoxStyle.Information)
                Exit Sub
            End If
            msj = String.Empty
            msj = "Documento Eliminado Correctamente." & vbCrLf & " Nro Documento: " & _TIPODOC & " - " & _SERIE & _NUMERO
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            btnCancelar_Click(sender, e)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        limpiar()
        DocumentosDevoluciones()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Call Botonera_Estado_Cambiar(True)
        limpiar()
        Modo_consultar = True
        _TIPODOC = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _SERIE = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        _NUMERO = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value

        _ALMACEN_IN = dgvCabecera.CurrentRow.Cells("WAREHOUSE_ID_IN").Value.ToString
        _DOCUMENT_IN = dgvCabecera.CurrentRow.Cells("DOCUMENT_ID_IN").Value.ToString
        _NUMBER_DOCUMENT_IN = dgvCabecera.CurrentRow.Cells("NUMBER_DOCUMENT_IN").Value.ToString

        pnlCabecera.Visible = False
        GbCabecera.Enabled = False
        MostrarModoConsultar(_TIPODOC, _SERIE, _NUMERO)
        btnAgregar.Visible = False
        btnquitar.Visible = False
        'If _OPTION_STATUS = "2" Then
        '    lbl_descripcion.Visible = True
        'Else
        '    lbl_descripcion.Visible = False
        'End If
        If _OPTION_STATUS = "2" Or _OPTION_STATUS = "3" Or _OPTION_STATUS = "4" Or _OPTION_STATUS = "1" Then
            gbOpciones.Visible = False
        Else
            gbOpciones.Visible = True
        End If
        If _OPTION_STATUS = "2" Or _OPTION_STATUS = "3" Or _OPTION_STATUS = "4" Then
            btnGrabar.Enabled = False
        Else
            btnGrabar.Enabled = True
        End If
    End Sub

    Private Sub MostrarModoConsultar(ByVal DOCUMENT_ID As String, ByVal NUMBER_SERIE As String, ByVal NUMBER_DOCUMENT As String)
        Try
            ClsdevolucionesBl = New ClsOperaciones.DEVOLUTION
            dtCabeceraDevol = New DataTable
            dtDetalleDevol = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraDevol = ClsdevolucionesBl.DatosDevolucionModoEdicion(DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT)
            If dtCabeceraDevol.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraDevol.Rows.Count() - 1
                    txtSerie.Text = dtCabeceraDevol.Rows(i).Item("NUMBER_SERIE").ToString
                    txtcodigo.Text = dtCabeceraDevol.Rows(i).Item("NUMBER_DOCUMENT").ToString
                    cbodevolucion.Text = Strings.Left(dtCabeceraDevol.Rows(i).Item("DOC_DEVOLUCION"), 2)
                    txtnumdevolucion.Text = Strings.Right(dtCabeceraDevol.Rows(i).Item("DOC_DEVOLUCION"), Len(dtCabeceraDevol.Rows(i).Item("DOC_DEVOLUCION")) - 3)
                    txtmoneda.Text = dtCabeceraDevol.Rows(i).Item("CURRENCY_ID").ToString
                    txtTipoCambio.Text = dtCabeceraDevol.Rows(i).Item("SELL_RATE").ToString
                    txtCodCliente.Text = dtCabeceraDevol.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRucDni.Text = dtCabeceraDevol.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtRazonSocial.Text = dtCabeceraDevol.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtDireccion.Text = dtCabeceraDevol.Rows(i).Item("CUSTOMER_ADDR").ToString

                    dtpFechadevol.Value = dtCabeceraDevol.Rows(i).Item("DOCUMENT_DATE").ToString
                    dtpFechaDevolucion.Value = dtCabeceraDevol.Rows(i).Item("DATE_DOC_DEVOLUCION").ToString

                    For Each Control As Control In gb_estados.Controls
                        If TypeOf Control Is TextBox Then
                            CType(Control, TextBox).Enabled = False
                        End If
                    Next
                    _OPTION_STATUS = dtCabeceraDevol.Rows(i).Item("OPCION_ESTADO").ToString
                    Select Case dtCabeceraDevol.Rows(i).Item("OPCION_ESTADO")
                        Case "1"
                            txtobservacionDireccion.Enabled = True
                        Case "2"
                            txtobservaciongerencia.Enabled = True
                        Case Else
                    End Select
                    txtobservacionAlmacen.Text = dtCabeceraDevol.Rows(i).Item("COMMENT_ALMACEN").ToString
                    txtobservacionDireccion.Text = dtCabeceraDevol.Rows(i).Item("COMMENT_DIR").ToString
                    txtobservaciongerencia.Text = dtCabeceraDevol.Rows(i).Item("COMMENT_GER").ToString
                Next
                '---Mostrando datos del Detalle
                ClsdevolucionesBl = New ClsOperaciones.DEVOLUTION
                GenerarColummnaDataTable()
                dtdetallePrincipal = ClsdevolucionesBl.DatosDevolucionDetalleModoEdicion(DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT)
                If dtdetallePrincipal.Rows.Count() <> 0 Then
                    configurarGrilla()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Almacen(ByVal Combobox As ComboBox)
        Dim almacenBL As New ClsOperaciones.WAREHOUSE
        Dim dtAlmacen As New DataTable
        dtAlmacen = almacenBL.get_Almacenes_Ayuda(LibComunVar.ClsVarComun.AccesoAlmacenes)
        Dim row As DataRow = dtAlmacen.NewRow()
        row.Item("CODIGO") = ""
        row.Item("DESCRIPCION") = "(-SELECCIONE-)"
        dtAlmacen.Rows.InsertAt(row, 0)
        Combobox.DataSource = dtAlmacen
        Combobox.DisplayMember = "DESCRIPCION"
        Combobox.ValueMember = "CODIGO"
        almacenBL = Nothing
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub MostrandoRelacionDocumentos()
        Try
            If cbo_filtro_opcion.SelectedIndex = 2 Then
                If CDate(dtp_filtro_fecha_ini.Value.ToString("dd/MM/yyyy")) > CDate(dtp_filtro_fecha_fin.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtp_filtro_fecha_ini.Focus()
                    Exit Sub
                End If
            End If
            ClsdevolucionesBl = New ClsOperaciones.DEVOLUTION
            dtdatoscabecera = New DataTable
            dtv_doc_cab = New DataView
            dtdatoscabecera = ClsdevolucionesBl.get_DatosCabeceraDevolucion(dtp_filtro_fecha_ini.Value.ToString("dd/MM/yyyy"), dtp_filtro_fecha_fin.Value, _
                                                                            cbo_filtro_opcion.SelectedIndex, txtCodCliente.Text)
            dtv_doc_cab = dtdatoscabecera.DefaultView
            dgv_doc_cabecera.DataSource = Nothing
            dgv_doc_detalle.DataSource = Nothing
            Filtracion = String.Empty
            If dtdatoscabecera.Rows.Count() <> 0 Then
                dgv_doc_cabecera.DataSource = dtv_doc_cab
                dgv_doc_cabecera.AutoResizeColumns()
                dgv_doc_cabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgv_doc_cabecera.Columns(8).Visible = False
                dgv_doc_cabecera.Columns(9).Visible = False
                Filtracion = dgv_doc_cabecera.Columns(2).Name & "+" & dgv_doc_cabecera.Columns(4).Name & "+" & dgv_doc_cabecera.Columns(5).Name
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoRelacionDocumentos_Lotes(ByVal Lote As String)
        Try
            If cbo_filtro_opcion.SelectedIndex = 2 Then
                If CDate(dtp_filtro_fecha_ini.Value.ToString("dd/MM/yyyy")) > CDate(dtp_filtro_fecha_fin.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtp_filtro_fecha_ini.Focus()
                    Exit Sub
                End If
            End If

            ClsdevolucionesBl = New ClsOperaciones.DEVOLUTION
            dtdatoscabecera = New DataTable
            dtv_doc_cab = New DataView
            dtdatoscabecera = ClsdevolucionesBl.get_DatosCabecera_Devolucion_Lote(dtp_filtro_fecha_ini.Value.ToString("dd/MM/yyyy"), dtp_filtro_fecha_fin.Value, _
                                                                            cbo_filtro_opcion.SelectedIndex, Lote, txtCodCliente.Text)
            dtv_doc_cab = dtdatoscabecera.DefaultView
            dgv_doc_cabecera.DataSource = Nothing
            dgv_doc_detalle.DataSource = Nothing
            Filtracion = String.Empty
            If dtdatoscabecera.Rows.Count() <> 0 Then
                dgv_doc_cabecera.DataSource = dtv_doc_cab
                dgv_doc_cabecera.AutoResizeColumns()
                dgv_doc_cabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgv_doc_cabecera.Columns(7).Visible = False
                dgv_doc_cabecera.Columns(8).Visible = False
                Filtracion = dgv_doc_cabecera.Columns(2).Name & "+" & dgv_doc_cabecera.Columns(4).Name & "+" & dgv_doc_cabecera.Columns(5).Name
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rb_cliente_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cliente.CheckedChanged
        If pnlDocumentos.Visible = False Then Exit Sub
        If rb_cliente.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            MostrandoRelacionDocumentos()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub rb_lote_CheckedChanged(sender As Object, e As EventArgs) Handles rb_lote.CheckedChanged
        txt_lote.Text = String.Empty
        dgv_doc_cabecera.DataSource = Nothing
        dgv_doc_detalle.DataSource = Nothing
        If rb_lote.Checked Then
            txt_lote.Visible = True
            txt_lote.Select()
        Else
            txt_lote.Visible = False
        End If
    End Sub

    Private Sub txt_lote_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_lote.KeyDown
        If txt_lote.Text = String.Empty Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            MostrandoRelacionDocumentos_Lotes(txt_lote.Text)
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub cbo_filtro_opcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_filtro_opcion.SelectedIndexChanged
        Select Case cbo_filtro_opcion.SelectedIndex
            Case 0
                gb_filtro_rango_fechas.Enabled = False
            Case 1
                gb_filtro_rango_fechas.Enabled = False
            Case 2
                gb_filtro_rango_fechas.Enabled = True
        End Select
        txtFiltro.Text = String.Empty
        Me.Cursor = Cursors.WaitCursor
        MostrandoRelacionDocumentos()
        Me.Cursor = Cursors.Default


    End Sub

    Private Sub dtp_filtro_fecha_fin_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_filtro_fecha_ini.KeyDown, dtp_filtro_fecha_fin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFiltro.Text = String.Empty
            Me.Cursor = Cursors.WaitCursor
            MostrandoRelacionDocumentos()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub dgvDetalle_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvDetalle.CurrentCellDirtyStateChanged
        dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub


    Private Sub dgvDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellValueChanged
        If e.ColumnIndex = 26 Then
            If dgvDetalle.Item(26, dgvDetalle.CurrentRow.Index).Value = True Then
                dgvDetalle.Item(27, dgvDetalle.CurrentRow.Index).Value = "APROBADO"
            Else
                dgvDetalle.Item(27, dgvDetalle.CurrentRow.Index).Value = "DESAPROBADO"
            End If
        End If
    End Sub

    Private Sub dgvDetalle_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDetalle.CellFormatting
        If _OPTION_STATUS = "2" Then
            If dgvDetalle.Rows(e.RowIndex).Cells("ESTADO").Value = "DESAPROBADO" Then
                dgvDetalle.Rows(e.RowIndex).Cells("ESTADO").Style.ForeColor = Color.Red
            Else
                dgvDetalle.Rows(e.RowIndex).Cells("ESTADO").Style.ForeColor = Color.Blue
            End If
        End If
    End Sub

    Private Sub cbodevolucion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumdevolucion.KeyPress, cbodevolucion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpFechaDevolucion_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaDevolucion.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpFechadevol.Select()
        End If
    End Sub

    Private Sub dtpFechadevol_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechadevol.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    dtpFechadevol.Select()
        'End If
    End Sub

    Private Sub dtpFechadevol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtobservaciongerencia.KeyPress, txtobservacionDireccion.KeyPress, txtobservacionAlmacen.KeyPress, dtpFechadevol.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            Dim msj As String = String.Empty
            If dgvCabecera.RowCount() = 0 Then Exit Sub
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            Dim Estado_Dev As String = ""
            Dim Estado_Doc As String = ""
            _TIPODOC = String.Empty
            _SERIE = String.Empty
            _NUMERO = String.Empty
            Dim cabeceraBL As ClsOperaciones.DEVOLUTION
            _TIPODOC = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            _SERIE = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
            _NUMERO = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value

            Estado_Doc = dgvCabecera.Item(9, dgvCabecera.CurrentRow.Index).Value
            Estado_Dev = dgvCabecera.Item(10, dgvCabecera.CurrentRow.Index).Value
            If Estado_Doc = "ANULADO" Then
                MsgBox("No se puede anular el documento, ya se encuentra Anulado", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If Estado_Dev = "4" Or Estado_Dev = "3" Then
                cabeceraBL = New ClsOperaciones.DEVOLUTION
                Dim dtAnulacion As DataTable
                dtAnulacion = New DataTable
                dtAnulacion = cabeceraBL.Verificacion_Anulacion(_TIPODOC, _SERIE, _NUMERO)
                If dtAnulacion.Rows.Count() <> 0 Then
                    Dim documentos As String = ""
                    For i As Integer = 0 To dtAnulacion.Rows.Count() - 1
                        documentos += dtAnulacion.Rows(i).Item(0).ToString & " : " & dtAnulacion.Rows(i).Item(1).ToString & "-" & dtAnulacion.Rows(i).Item(2).ToString + vbCr
                    Next
                    MsgBox("Para Anular el documento. " & vbCrLf & "debe anularce primero en los documentos donde se encuentra anexado:" + vbCr & documentos, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    MsgBox("No se puede Anular el Registro," & Chr(13) & " por estar en un estado superior al de Emitido.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

            pnl_anulacion.Visible = True
            txt_motivo_anulacion.Text = ""
            gbOpciones.Enabled = False
            ToolStrip1.Enabled = False
            txt_motivo_anulacion.Select()
            'If MessageBox.Show("¿Desea anular el Documento.?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '    Me.Cursor = Cursors.WaitCursor
            '    cabeceraBL = New ClsOperaciones.DEVOLUTION
            '    If cabeceraBL.AnularDevolucion(_TIPODOC, _SERIE, _NUMERO) = False Then
            '        MsgBox("Hubo un error, no se completo el Proceso de Anulacion.", MsgBoxStyle.Information)
            '        Exit Sub
            '    End If
            '    msj = String.Empty
            '    msj = "Documento Anulado Correctamente." & vbCrLf & " Nro Documento: " & _TIPODOC & " - " & _SERIE & _NUMERO
            '    MsgBox(msj, MsgBoxStyle.Information)
            '    Me.Cursor = Cursors.Default
            '    btnCancelar_Click(sender, e)
            'End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCliente.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Cliente()
        If e.KeyCode = Keys.Enter Then btnAgregar_Click(sender, e)
    End Sub
    Private Sub Ayuda_Cliente(Optional ByVal _CodigoVendedor As String = "")
        Try
            If _CodigoVendedor = String.Empty Then
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
                End If
                frm.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCodCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCodCliente.MouseDoubleClick
        Ayuda_Cliente()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        pnl_detalle_manual.Visible = True
        gbOpciones.Enabled = False
        codigo = String.Empty
        Limpiando_IngresoManual()
        TextBox6.Focus()
    End Sub

    Private Sub TextBox6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox6.MouseDoubleClick
        MostrandoArticulos()
    End Sub
    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "DEVOLUCION_SP_S_PART"
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox6.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                TextBox4.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                TextBox5.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                TextBox3.Focus()
            Else
                TextBox6.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsLower(e.KeyChar) Then
            TextBox6.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos()
        If e.KeyCode = Keys.Enter Then
            If TextBox6.Text = String.Empty Then
                MostrandoArticulos()
            Else
                Dim codigoArticulo As String = String.Empty
                codigoArticulo = TextBox6.Text.Trim
                AgregarArticuloManual(codigoArticulo)
            End If
            
        End If
    End Sub

    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            clsArticuloBl = New ClsOperaciones.PART
            dtDocumentoGuias = New DataTable
            dtDocumentoGuias = clsArticuloBl.get_VerificacionArticulo_Dev_Manual(_codigoArticulo)
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                TextBox6.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                TextBox4.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                TextBox5.Text = dtDocumentoGuias.Rows(0).Item("UNID_MED").ToString
                TextBox3.Focus()
            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
                TextBox6.Text = String.Empty
                TextBox4.Text = String.Empty
                TextBox5.Text = String.Empty
                TextBox6.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox3.MouseDoubleClick
        MostrandoLotes(TextBox6.Text.Trim)
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoLotes(TextBox6.Text.Trim)
        If e.KeyCode = Keys.Enter Then
            If TextBox3.Text = String.Empty Then
                MostrandoLotes(TextBox6.Text.Trim)
            Else
                Dim codigoArticulo As String = String.Empty
                Dim loteArticulo As String = String.Empty
                codigoArticulo = TextBox6.Text.Trim
                loteArticulo = TextBox3.Text.Trim
                AgregarLoteManual(codigoArticulo, loteArticulo)
            End If

        End If
    End Sub

    Private Sub MostrandoLotes(ByVal _CODIGO As String)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "DEVOLUCION_SP_S_PART_LOTE"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = _CODIGO
            frm.Titulo = "Seleccion de Lotes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox3.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                MaskedTextBox1.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                TextBox3.Focus()
            Else
                TextBox3.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AgregarLoteManual(ByVal _codigoArticulo As String, ByVal _loteArticulo As String)
        Try
            clsArticuloBl = New ClsOperaciones.PART
            dtDocumentoGuias = New DataTable
            dtDocumentoGuias = clsArticuloBl.get_Verificacion_Lote_Articulo_Dev_Manual(_codigoArticulo, _loteArticulo)
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                TextBox3.Text = dtDocumentoGuias.Rows(0).Item("LOT_ID").ToString
                MaskedTextBox1.Text = dtDocumentoGuias.Rows(0).Item("VCTO").ToString
                TextBox7.Focus()
            Else
                MsgBox("No hay informacion con el lote especificado", MsgBoxStyle.Information)
                TextBox3.Text = String.Empty
                MaskedTextBox1.Text = String.Empty
                TextBox3.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnl_detalle_manual.Visible = False
        Limpiando_IngresoManual()
        gbOpciones.Enabled = True
        ToolStrip1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox7.Text = String.Empty Then
            MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Critical)
            TextBox7.Focus()
            Exit Sub
        End If
        If TextBox7.Text = 0 Then
            MsgBox("Debe ingresar una cantidad diferente de 0.", MsgBoxStyle.Critical)
            TextBox7.Focus()
            Exit Sub
        End If
        If CheckBox5.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox9.Checked = False Then
            MsgBox("Debe elegir un Motivo de Devolución.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False And RadioButton5.Checked = False Then
            MsgBox("Debe elegir un Fin de Devolución.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim _motivos As String = String.Empty
        Dim item As DataRow = dtdetallePrincipal.NewRow

        item("ITEM") = dtdetallePrincipal.Rows.Count + 1
        item("CODIGO") = TextBox6.Text.Trim
        item("UNIDAD") = TextBox5.Text.Trim
        item("DESCRIPCION") = TextBox4.Text.Trim
        item("LOTE") = TextBox3.Text.Trim
        item("PREC_UNITARIO") = 0
        item("%DESC.ART_1") = 0
        item("%DESC.ART_2") = 0
        item("VALOR_VENTA") = 0
        item("IMP_DESC_01") = 0
        item("IMP_DESC_02") = 0
        item("PRECIO_IGV") = 0
        item("IGV_ART") = 0
        item("IGV_ART_US") = 0
        item("IMPORTE") = 0
        item("PRECIO_INICIAL") = 0
        item("TOTAL_INICIAL") = 0

        item("TD_REF") = ""
        item("SERIE_REF") = ""
        item("NUM_DOC_REF") = ""
        item("ESTADO") = ""
        item("GENERO_NC_GUIA") = ""

        item("CANTIDAD") = TextBox7.Text
        item("OBSERVACIONES") = TextBox2.Text
        For Each Control As Control In GroupBox14.Controls
            If TypeOf Control Is CheckBox Then
                If CType(Control, CheckBox).Checked = True Then
                    _motivos = _motivos & CType(Control, CheckBox).Text & ","
                    ' Exit For
                End If
            End If
        Next
        If _motivos <> "" Then
            _motivos = Strings.Mid(_motivos, 1, Len(_motivos) - 1)
        End If
        item("MOTIVO_DEVOLUCION") = _motivos

        For Each Control As Control In GroupBox12.Controls
            If TypeOf Control Is RadioButton Then
                If CType(Control, RadioButton).Checked = True Then
                    item("FIN_DEVOLUCION_ID") = CType(Control, RadioButton).Text
                    Exit For
                End If
            End If
        Next
        item("TEXTO_FIN_DEVOLUCION_ID") = ""
        item("ALMACEN_DESTINO") = ""
        dtdetallePrincipal.Rows.Add(item)
        dtdetallePrincipal.AcceptChanges()
        configurarGrilla()
        Button4.PerformClick()
    End Sub

    Private Sub dtpFechadevol_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechadevol.ValueChanged
        Try
            Dim cls_compras As ClsOperaciones.CURRENCY_TYPE
            cls_compras = New ClsOperaciones.CURRENCY_TYPE
            Dim dt_Tc As Double

            dt_Tc = cls_compras.get_TiposCambio_fecha_dada(dtpFechadevol.Value.ToString("dd/MM/yyyy"))

            If dt_Tc > 0 Then
                txtTipoCambio.Text = dt_Tc
            Else
                txtTipoCambio.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor

            _TIPODOC = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            _SERIE = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
            _NUMERO = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value

            dtImprimir = reporteBL.Imprimir_Devolucion(_TIPODOC, _SERIE, _NUMERO)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("RD001.rpt", dtImprimir, "", "", "@TIPO;" & _TIPODOC, "@SERIE;" & _SERIE, "@NUMERO;" & _NUMERO, "usuario;" & LibComunVar.ClsVarComun.USUARIO)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pnl_anulacion.Visible = False
        txt_motivo_anulacion.Text = ""
        gbOpciones.Enabled = True
        ToolStrip1.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If Len(Trim(txt_motivo_anulacion.Text)) = 0 Then
                MsgBox("Debe ingresar un motivo para Anular la Devolución.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim msj As String
            Dim cabeceraBL As ClsOperaciones.DEVOLUTION

            If MessageBox.Show("¿Desea anular el Documento.?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                cabeceraBL = New ClsOperaciones.DEVOLUTION
                If cabeceraBL.AnularDevolucion(_TIPODOC, _SERIE, _NUMERO, txt_motivo_anulacion.Text.Trim, LibComunVar.ClsVarComun.USUARIO) = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de Anulacion.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                msj = String.Empty
                msj = "Documento Anulado Correctamente." & vbCrLf & " Nro Documento: " & _TIPODOC & " - " & _SERIE & _NUMERO
                MsgBox(msj, MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
                Button7_Click(sender, e)
                DocumentosDevoluciones()
                'btnCancelar_Click(sender, e)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("ESTADO.DOCUMENTO").Value = "ANULADO" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub
End Class