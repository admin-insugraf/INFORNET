Public Class FrmManufactura_Generacion_Orden_Fabricacion
    Dim OrdenProduccionBl As ClsOperaciones.ORDER_PRODUCTION
    Dim _id As String = String.Empty
    Dim _Who As String = String.Empty
    Dim _estado_compromiso As String = String.Empty

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Dim CORRELATIVOBL As ClsTransacciones.ORDER_PRODUCTION
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim Fl_close As Boolean = False

    Dim clsAlmacenCorrelativoBl As LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo

    Dim Ref_idalamacen As String = String.Empty
    Dim Ref_documentid As String = String.Empty
    Dim Ref_numerodocument As String = String.Empty

    Private Sub Documentos_Orden_Fabricacion()
        Try
            Dim Tipodoc As String = String.Empty
            If cboMostrar.Text = "Planificacion" Then
                Tipodoc = "01"
            ElseIf cboMostrar.Text = "Produccion" Then
                Tipodoc = "02"
            ElseIf cboMostrar.Text = "Anuladas" Then
                Tipodoc = "03"
            ElseIf cboMostrar.Text = "Terminadas" Then
                Tipodoc = "04"
            End If
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtDocumentos As New DataTable
            dtDocumentos = OrdenProduccionBl.Mostrar_Documentos_Orden_Fabricacion(Tipodoc, cboopcionesBusqueda.SelectedIndex, _
                                                                          dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"))
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtDocumentos

                dgvCabecera.Columns(4).Visible = False
                dgvCabecera.Columns(7).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(9).HeaderText = "Observación"
                dgvCabecera.Columns(12).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(14).Visible = False
                dgvCabecera.Columns(15).Visible = False
                dgvCabecera.Columns(16).Visible = False
                dgvCabecera.Columns(17).Visible = False
                dgvCabecera.Columns(18).HeaderText = "Estado de Compromiso"
                dgvCabecera.Columns(19).Visible = False
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvCabecera.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Else
                ' MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_GenerarOf_Click(sender As Object, e As EventArgs) Handles btn_GenerarOf.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        _id = String.Empty
        _Who = String.Empty
        _estado_compromiso = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Who = dgvCabecera.Item(16, dgvCabecera.CurrentRow.Index).Value
        _estado_compromiso = dgvCabecera.Item(17, dgvCabecera.CurrentRow.Index).Value

        If _estado_compromiso = "0" Then
            MsgBox("No se realizo la reserva de los insumos para O.F., verifique.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If LibComunVar.ClsVarComun.TCVenta = 0 Then
            MsgBox("No se cargo el Tipo de Cambio del dia, verifique.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        pnlGenerar.Visible = True
        ToolStrip1.Enabled = False
        dtpFecha.Value = Date.Now
        Dim _CORRELATIVO As String = Numeracion()
        txt_numero_lote.Text = _CORRELATIVO
        pnlCabecera.Enabled = False
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmManufactura_Verificacion_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboopcionesBusqueda.SelectedIndex = 1
        cboMostrar.SelectedIndex = 1
        ' DocumentosVerificacionStock()
    End Sub

    Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMostrar.SelectedIndexChanged
        Documentos_Orden_Fabricacion()
    End Sub
 
    Private Sub btn_Imprimir_Click(sender As Object, e As EventArgs) Handles btn_Imprimir.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        _id = String.Empty
        _Who = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Who = dgvCabecera.Item(16, dgvCabecera.CurrentRow.Index).Value
        imprimirAlmacen(_id, _Who)
    End Sub

    Private Sub dgvCabecera_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCabecera.SelectionChanged
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtResultado As DataTable
            Dim _NroOf As String = String.Empty
            Dim TEXTO As String = String.Empty
            _NroOf = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            TEXTO = "SELECT COMPROMETIDO FROM dbo.ORDER_PRODUCTION WHERE ID='" & _NroOf & "'"
            dtResultado = New DataTable
            dtResultado = OrdenProduccionBl.Mostrar_Consulta(TEXTO)
            If dtResultado.Rows.Count() <> 0 Then
                If dtResultado.Rows(0).Item("COMPROMETIDO").ToString = "1" Then
                    btn_GenerarOf.Enabled = True
                Else
                    btn_GenerarOf.Enabled = False
                End If
            End If
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            dtResultado = New DataTable
            TEXTO = ""
            TEXTO = "SELECT STATUS FROM dbo.ORDER_PRODUCTION WHERE ID='" & _NroOf & "'"
            dtResultado = OrdenProduccionBl.Mostrar_Consulta(TEXTO)
            If dtResultado.Rows.Count() <> 0 Then
                If dtResultado.Rows(0).Item("STATUS") = "02" Then 'PRODUCCION
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = True
                    btn_adicional.Enabled = True
                ElseIf dtResultado.Rows(0).Item("STATUS") = "01" Then 'PLANIFICACION
                    btn_terminarof.Enabled = False
                    btn_adicional.Enabled = False
                ElseIf dtResultado.Rows(0).Item("STATUS") = "03" Then 'ANULADAS
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = False
                    btn_adicional.Enabled = False
                ElseIf dtResultado.Rows(0).Item("STATUS") = "04" Then 'TERMINADAS
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = True
                    btn_adicional.Enabled = False
                ElseIf dtResultado.Rows(0).Item("STATUS") = "05" Then 'LIQUIDADO
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = False
                    btn_adicional.Enabled = False
                Else 'LIQUIDADO MANUALMENTE
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = False
                    btn_adicional.Enabled = False
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        pnlGenerar.Visible = False
        ToolStrip1.Enabled = True
        pnlCabecera.Enabled = True
        _id = String.Empty
        _Who = String.Empty
    End Sub

    Private Sub Generar_Orden_Fabricacion()
        Try
            If MessageBox.Show("Desea Generar la Orden de Fabricación?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim QUERY_INSERTAR As String, QUERY_ACT_NUM As String

                QUERY_INSERTAR = " UPDATE  dbo.ORDER_PRODUCTION SET LOTE='" & txt_numero_lote.Text & "', STATUS='02',DATE_INIT='" & dtpFecha.Value.ToString("dd/MM/yyyy") & "' WHERE ID='" & _id & "' "
                QUERY_ACT_NUM = " UPDATE dbo.NUMBER_DOCUMENT SET LAST_NUMBER=" & CDbl(txt_numero_lote.Text) & " WHERE TYPE_DOC='99' "
                OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
                If OrdenProduccionBl.Ejecutar_Consulta(QUERY_INSERTAR) = True Then
                    OrdenProduccionBl.Ejecutar_Consulta(QUERY_ACT_NUM)
                    Dim dt_descarga As DataTable
                    dt_descarga = OrdenProduccionBl.Genera_Descarga(_id, _Who, LibComunVar.ClsVarComun.USUARIO, LibComunVar.ClsVarComun.TCVenta)
                    If dt_descarga.Rows.Count > 0 Then
                        MsgBox("Descarga de Insumos grabado correctamente." & Chr(13) & "N° Nota de Salida " & dt_descarga.Rows(0).Item("NUMERO_SALIDA").ToString, MsgBoxStyle.Information, "Sistemas")
                        imprimirAlmacen(_Who, "NS", dt_descarga.Rows(0).Item("NUMERO_SALIDA").ToString)
                    Else
                        MsgBox("No se realizo la descarga de los insumos.", MsgBoxStyle.Critical)
                    End If
                    imprimirAlmacen(_id, _Who)
                    Documentos_Orden_Fabricacion()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.ORDER_PRODUCTION
            CORRELATIVOBL.Get_NumeroCorrelativo_Lote()
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                Correlativo = CInt(CORRELATIVOBL.NumeroCorrelativo + 1)
            End If
            Correlativo = Correlativo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub imprimirAlmacen(ByVal _idalamacen As String, ByVal _documentid As String, ByVal _numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(_idalamacen, _documentid, _numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                If _idalamacen = "01" Then
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

    Private Function Generar_Termino_Orden_Fabricacion() As Boolean
        Try
            If MessageBox.Show("Desea Terminar la Orden de Fabricación?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim QUERY_INSERTAR As String
                QUERY_INSERTAR = " UPDATE  dbo.ORDER_PRODUCTION SET VENCIMIENTO='" & dtp_vcto_lote.Value.ToString("dd/MM/yyyy") & "', STATUS='04',DATE_OUT='" & dtp_terminar.Value.ToString("dd/MM/yyyy") & "',QTY_PRODUCID=" & CDbl(txtcatidadterminar.Text) & " WHERE ID='" & _id & "' "
                OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
                If OrdenProduccionBl.Ejecutar_Consulta(QUERY_INSERTAR) = True Then
                    'imprimirAlmacen(_id, _Who)
                    Documentos_Orden_Fabricacion()
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function


    Private Sub imprimirAlmacen(ByVal _Codigo As String, ByVal _Almacen As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtImprimir_OP As New DataTable()
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir_OP = reporteBL.EjecutarReporteOrdenProduccion(_Codigo, _Almacen)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir_OP.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Orden_Produccion_Planificacion.rpt", "", "", "", "@OF;" & _Codigo, "@ALMACEN;" & _Almacen, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Generar_Orden_Fabricacion()
            btn_cancelar_Click(sender, e)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
 
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txtcatidadterminar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcatidadterminar.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcatidadterminar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcatidadterminar.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmartermino.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlterminar.Visible = False
        ToolStrip1.Enabled = True
        pnlCabecera.Enabled = True
        _id = String.Empty
        _Who = String.Empty
    End Sub

    Private Sub btn_terminarof_Click(sender As Object, e As EventArgs) Handles btn_terminarof.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim fecha_fab As Date
        _id = String.Empty
        _Who = String.Empty
        _estado_compromiso = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        fecha_fab = CDate(dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value)
        _Who = dgvCabecera.Item(16, dgvCabecera.CurrentRow.Index).Value
        _estado_compromiso = dgvCabecera.Item(8, dgvCabecera.CurrentRow.Index).Value

        If _estado_compromiso <> "PRODUCCION" Then
            MsgBox("No se pueder terminar la O.F., su estado no lo permite, verifique.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If LibComunVar.ClsVarComun.TCVenta = 0 Then
            MsgBox("No se cargo el Tipo de Cambio del dia, verifique.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ToolStrip1.Enabled = False
        pnlterminar.Visible = True
        pnlCabecera.Enabled = False
        dtp_terminar.Value = Date.Now
        dtp_vcto_lote.Value = DateAdd("m", 6, fecha_fab)
        txt_num_lote.Text = dgvCabecera.Item(5, dgvCabecera.CurrentRow.Index).Value
        txtcatidadterminar.Text = "0.0"
        txtcatidadterminar.Select()
    End Sub

    Private Sub btn_confirmartermino_Click(sender As Object, e As EventArgs) Handles btn_confirmartermino.Click
        Try
            If txtcatidadterminar.Text = "" Then
                MsgBox("Debe ingresar una Cantidad Terminada valida. Verifique!!!", MsgBoxStyle.Critical, "Aviso")
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            If Generar_Termino_Orden_Fabricacion() Then
                Button1_Click(sender, e)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("Estado").Value = "ANULADAS" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
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
        Documentos_Orden_Fabricacion()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            Documentos_Orden_Fabricacion()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Documentos_Orden_Fabricacion()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        btnGrabar.Visible = False
    End Sub
    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_GenerarOf.Enabled = False
            btn_terminarof.Enabled = False
            btn_adicional.Enabled = False
            btn_cancelar.Enabled = True
            btn_Imprimir.Enabled = False
        Else
            btn_GenerarOf.Enabled = True
            btn_terminarof.Enabled = True
            btn_adicional.Enabled = True
            btn_cancelar.Enabled = False
            btn_Imprimir.Enabled = True
        End If
    End Sub

    Private Sub btn_adicional_Click(sender As Object, e As EventArgs) Handles btn_adicional.Click
        Nuevo()
        Botonera_Estado_Cambiar(True)
        btnGrabar.Visible = True
    End Sub
    Private Sub Nuevo()
        Try
            pnlCabecera.Visible = False
            gbcabecera.Enabled = True
            txtcodigo.Text = dgvCabecera.CurrentRow.Cells("Nro.O.F").Value
            txt_producto.Text = dgvCabecera.CurrentRow.Cells("Producto a Fabricar").Value
            txt_lote_detalle.Text = dgvCabecera.CurrentRow.Cells("Lote").Value
            GenerarColummnaDataTable()

            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            dtdetalleArticuloPrincipal = OrdenProduccionBl.Mostrar_OF_Adicionales(txtcodigo.Text.Trim)
            dgvDetalles.DataSource = Nothing
            If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
                dgvDetalles.DataSource = dtdetalleArticuloPrincipal
                dgvDetalles.AutoResizeColumns()
                dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvDetalles.Columns("ITEM").HeaderText = "Item"
                dgvDetalles.Columns("PART_ID").HeaderText = "Codigo"
                dgvDetalles.Columns("DESCRIPTION").HeaderText = "Producto"
                dgvDetalles.Columns("UNIT").HeaderText = "Unidad"
                dgvDetalles.Columns("LOTE").HeaderText = "N° Lote"
                dgvDetalles.Columns("QTY").HeaderText = "Cantidad"
                dgvDetalles.Columns("QTY").DefaultCellStyle.Format = "N4"
                dgvDetalles.Columns("QTY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvDetalles.Columns("ALMACEN_SALIDA").Visible = False
                dgvDetalles.Columns("DOC_SALIDA").HeaderText = "Tipo Documento Desc."
                dgvDetalles.Columns("NUM_SALIDA").HeaderText = "N° Documento Desc."
                dgvDetalles.Columns("FECHA").HeaderText = "Fecha Documento Desc."
                dgvDetalles.Columns("ESTADO").Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("ALMACEN_SALIDA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DOC_SALIDA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NUM_SALIDA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("FECHA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("ESTADO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        
        'Modo_Edicion = False
        AgregandoArticulos()
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_Click(sender, e)
        End If
    End Sub

    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignacionArticuloAdicional
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                row("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                row("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                row("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
                row("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                row("ALMACEN_SALIDA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("ALMACEN_SALIDA")
                row("DOC_SALIDA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DOC_SALIDA")
                row("NUM_SALIDA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NUM_SALIDA")
                row("FECHA") = ""
                row("ESTADO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("ESTADO")
                
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                Fl_close = False
            Else
                Fl_close = True
            End If
            ConfigurarGrilla()
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConfigurarGrilla()
        dgvDetalles.DataSource = Nothing
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalles.DataSource = dtdetalleArticuloPrincipal
            dgvDetalles.Columns(0).HeaderText = "Item"
            dgvDetalles.Columns(1).HeaderText = "Codigo"
            dgvDetalles.Columns(2).HeaderText = "Producto"
            dgvDetalles.Columns(3).HeaderText = "Unidad"
            dgvDetalles.Columns(4).HeaderText = "N° Lote"
            dgvDetalles.Columns(5).HeaderText = "Cantidad"
            dgvDetalles.Columns(6).Visible = False
            dgvDetalles.Columns(7).HeaderText = "Tipo Documento Desc."
            dgvDetalles.Columns(8).HeaderText = "N° Documento Desc."
            dgvDetalles.Columns(9).HeaderText = "Fecha Documento Desc."
            dgvDetalles.Columns(10).Visible = False

            dgvDetalles.Columns(5).DefaultCellStyle.Format = "N6"
            dgvDetalles.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.AutoResizeColumns()
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        End If
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub

        If dgvDetalles.CurrentRow.Cells("ESTADO").Value <> "" Then
            MsgBox("El item no puede ELIMINARSE porque ya descargo el Adicional. Verifique!!!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If

        EliminandoArticulo()
        ConfigurarGrilla()
    End Sub
    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalles.CurrentRow.Cells("ITEM").Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
                ' Calcular_Totales()
            End If
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

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dtdetalleArticuloPrincipal.Rows.Count = 0 Then Exit Sub
        If GenerarIngresoSalidaAlmacen() Then
            ToolStripButton2_Click(sender, e)
        End If
    End Sub

    Private Function GenerarIngresoSalidaAlmacen() As Boolean
        Try
            'Dim ls_det_alm As New List(Of LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE)
            'Dim alm_cabBE As New LibCobranzas.ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            Dim numero_bultos As String
            Dim qty_bultos As Double

            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ESTADO='' ")

                Dim alm_cabBE As New LibCobranzas.ClsEntidades.WAREHOUSE_TRANS
                clsAlmacenCorrelativoBl = New LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo
                clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(item("ALMACEN_SALIDA"), "S")
                'la parte de almacen
                With alm_cabBE
                    .WAREHOUSE_ID = item("ALMACEN_SALIDA")
                    .DOCUMENT_ID = "NS"
                    .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                    .DATE_DOCUMENT = CDate(DateTimePicker1.Value).ToShortDateString
                    .TYPE_TRANS = "S"
                    .TRANS_ID = "SP"
                    .DOC_ID_REF = "OF"
                    .NUM_ID_REF = txtcodigo.Text.Trim
                    .NUMBER_SERIE = ""
                    .OPT_COMPRAS = "NO"
                    .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .VAT_REGISTRATION = LibComunVar.ClsVarComun.RucEmpresa 'Ruc..
                    .ADDR_DLV = LibComunVar.ClsVarComun.DirEmpresa  'Direccion ..
                    .VENDOR_ID = LibComunVar.ClsVarComun.RucEmpresa 'Ruc..
                    .VENDOR_NAME = LibComunVar.ClsVarComun.NomEmpresa
                    .CUSTOMER_ID = ""
                    .CUSTOMER_NAME = ""
                    .SALES_TERM = ""
                    .CURRENCY_TYPE = "MN"
                    .CURRENCY_EXCHANGE = LibComunVar.ClsVarComun.TCVenta
                    .STATUS_GUIA = "V"
                    .AMOUNT = 0
                    .COMMENT = ""
                    .TYPE_GUIA = "SP"
                    .WAREHOUSE_REF = ""
                    .UPDATE_DATE = Date.Now()
                    .NUM_ORDER_MANUFACT = txtcodigo.Text.Trim
                    .NUMBER_PURCHASE = ""
                    '.STATUS_CONTROL = "C"
                    .IS_COD_PRODUCTO = ""
                End With
                'Detalle de la Guia...

                Dim ls_det_alm As New List(Of LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE)
                alm_detBE = New LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE
                    .WAREHOUSE_ID = item("ALMACEN_SALIDA")
                    .DOCUMENT_ID = "NS"
                    .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
                    .ITEM = item("ITEM")
                    .PART_ID = item("PART_ID")
                    .QTY = item("QTY")
                    .QTY_DLV = 0
                    .QTY_REF = .QTY
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .AVERAGE_COST = 0
                    .PART_DESCRIPTION = item("DESCRIPTION")
                    .UNIT_PART = item("UNIT")
                    .NUMBER_LOT = item("LOTE")
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
                    .CURRENCY_ID = "MN"
                    .STATUS_VALUE = 0
                    .NUMBER_ANALIS = ""
                End With
                ls_det_alm.Add(alm_detBE)

                Me.Cursor = Cursors.WaitCursor
                If almacenBL.GuardarInventarioAlmacen_Adicionales(alm_cabBE, ls_det_alm, "") Then
                    Dim msj As String = String.Empty
                    msj = String.Empty
                    msj = "Nuevo Documento Generado Correctamente" & vbCrLf & "Nro Documento: NS - " & alm_cabBE.NUMBER_DOCUMENT
                    MsgBox(msj, MsgBoxStyle.Information)
                    imprimirAlmacen(item("ALMACEN_SALIDA"), "NS", alm_cabBE.NUMBER_DOCUMENT)

                Else
                    Me.Cursor = Cursors.Default
                    Return False
                End If
            Next
            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        imprimirSalida_Adicional(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
    End Sub

    Private Function ValidacionGeneral(ByRef idalamacen As String, ByRef documentid As String, ByRef numerodocument As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            idalamacen = dgvDetalles.CurrentRow.Cells("ALMACEN_SALIDA").Value
            documentid = dgvDetalles.CurrentRow.Cells("DOC_SALIDA").Value
            numerodocument = dgvDetalles.CurrentRow.Cells("NUM_SALIDA").Value

            'validacion
            If idalamacen = String.Empty Or documentid = String.Empty Or numerodocument = String.Empty Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Return estado
    End Function
    Private Sub imprimirSalida_Adicional(ByVal _idalamacen As String, ByVal _documentid As String, ByVal _numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(_idalamacen, _documentid, _numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                If _idalamacen = "01" Then
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

    Private Sub btn_genera_xls_Click(sender As Object, e As EventArgs) Handles btn_genera_xls.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xls;*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With

        If myFileDialog.FileName.ToString() = "" Then Exit Sub

        Dim _id As String = String.Empty
        Dim _Alm As String = String.Empty
        _id = dgvCabecera.CurrentRow.Cells("Nro.O.F").Value
        _Alm = dgvCabecera.CurrentRow.Cells("WHO_ID").Value

        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtImprimir_OP As DataTable
            dtImprimir_OP = New DataTable
            Dim nombre_Archivo As String

            Me.Cursor = Cursors.WaitCursor
            dtImprimir_OP = reporteBL.EjecutarReporteOrdenProduccion(_id, _Alm)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir_OP.Rows.Count() <> 0 Then
                'crystalBL.Muestra_Reporte("rpt_Orden_Produccion_Planificacion.rpt", "", "", "", "@OF;" & _Codigo, "@ALMACEN;" & _Almacen, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                Dim xlibro As Microsoft.Office.Interop.Excel.Application
                Dim strRutaarchivo As String
                strRutaarchivo = myFileDialog.FileName.ToString()
                nombre_Archivo = (System.IO.Path.GetFileNameWithoutExtension(myFileDialog.FileName)) & (System.IO.Path.GetExtension(myFileDialog.FileName))

                xlibro = CreateObject("Excel.Application")
                xlibro.Workbooks.Open(strRutaarchivo)

                xlibro.Workbooks(nombre_Archivo).Activate()
                xlibro.Sheets("F-001").Select()

                Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet = xlibro.Sheets.Item("F-001")
                xlibro.Visible = True

                xlibro.Range("H6").Value = dtImprimir_OP.Rows(0).Item("ID").ToString
                xlibro.Range("B8").Value = dtImprimir_OP.Rows(0).Item("CUSTOMER_NAME").ToString
                xlibro.Range("H8").Value = dtImprimir_OP.Rows(0).Item("VENDEDOR").ToString
                xlibro.Range("H9").Value = dtImprimir_OP.Rows(0).Item("DESCRIPTION_PART").ToString
                xlibro.Range("B11").Value = dtImprimir_OP.Rows(0).Item("CANT_OP").ToString
                xlibro.Range("H11").Value = dtImprimir_OP.Rows(0).Item("CANT_OP").ToString

                For i As Integer = 0 To dtImprimir_OP.Rows.Count - 1
                    xlibro.Range("A" & 17 + i).Value = dtImprimir_OP.Rows(i).Item("DESCRIPTION").ToString
                    xlibro.Range("H" & 17 + i).Value = dtImprimir_OP.Rows(i).Item("CANTIDAD").ToString
                    xlibro.Range("J" & 17 + +i).Value = dtImprimir_OP.Rows(i).Item("UNIT").ToString
                Next

            Else
                MsgBox("No hay informacion disponible para la Orden de Producción elegida.", MsgBoxStyle.Exclamation)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class