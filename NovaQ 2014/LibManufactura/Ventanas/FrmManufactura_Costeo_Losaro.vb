Public Class FrmManufactura_Costeo_Losaro
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
    Dim dtdetalleArticuloPrincipal_pt As DataTable
    Dim dtdetalleArticulo_costos_varios As DataTable
    Dim Fl_close As Boolean = False

    Dim clsAlmacenCorrelativoBl As LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo

    Dim Ref_idalamacen As String = String.Empty
    Dim Ref_documentid As String = String.Empty
    Dim Ref_numerodocument As String = String.Empty

    Dim ManufactutraBl As ClsOperaciones.FORMULATION
    Dim Modo_Edicion As Boolean = False
    Dim _cantidad_formula As Double
    Dim _costo_total_formula As Double
    Dim ProcesoCosteoCab As ClsEntidades.PROCESO_COSTEO
    Dim ProcesoCosteo_Mp As ClsEntidades.PROCESO_COSTEO_MP
    Dim ProcesoCosteo_Pt As ClsEntidades.PROCESO_COSTEO_PT
    Dim ProcesoCosteo_Pt_Line As ClsEntidades.PROCESO_COSTEO_PT_LINE
    Dim ListaDetalles_mp As List(Of ClsEntidades.PROCESO_COSTEO_MP)
    Dim ListaDetalles_pt As List(Of ClsEntidades.PROCESO_COSTEO_PT)
    Dim ListaDetalles_pt_line As List(Of ClsEntidades.PROCESO_COSTEO_PT_LINE)

    Dim ManufactutraDetENT As ClsEntidades.FORMULATION_LINE
    Dim ListaDetalles As List(Of ClsEntidades.FORMULATION_LINE)
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Private Sub FrmManufactura_Costeo_Losaro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        cboopcionesBusqueda.SelectedIndex = 1
        'cboMostrar.SelectedIndex = 1
        ' DocumentosVerificacionStock()
    End Sub

    Private Sub Documentos_Orden_Fabricacion()
        Try
            Dim Tipodoc As String = String.Empty

            Tipodoc = ""
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtDocumentos As New DataTable
            dtDocumentos = OrdenProduccionBl.Mostrar_Documentos_Orden_Fabricacion(Tipodoc, cboopcionesBusqueda.SelectedIndex, _
                                                                          dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"))
            dgvCabecera.DataSource = Nothing
            dtv = New DataView
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.Columns("Codigo").HeaderText = "Codigo"
                dgvCabecera.Columns("Fecha").HeaderText = "Fecha"
                dgvCabecera.Columns("Formula.Producto").HeaderText = "Formula de Producto"
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvCabecera.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                STRorden = dgvCabecera.Columns("Codigo").Name & "+" & dgvCabecera.Columns("Formula.Producto").Name
            Else
                STRorden = ""
                ' MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs)
        Documentos_Orden_Fabricacion()
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


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
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

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btn_eliminar.Enabled = False
            btn_reprocesar.Enabled = False
            btnGrabar.Enabled = True
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnimprimir.Enabled = False
        Else
            btnNuevo.Enabled = True
            btn_eliminar.Enabled = True
            btn_reprocesar.Enabled = True
            btnGrabar.Enabled = False
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnimprimir.Enabled = True
        End If
    End Sub


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY_TEORICA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AVERAGE_COST", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("EQUIVALENCIA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("TYPE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("POR_EXCESO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCARGA_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Pt()
        Try
            dtdetalleArticuloPrincipal_pt = New DataTable
            dtdetalleArticuloPrincipal_pt.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal_pt.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_pt.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_pt.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_pt.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_pt.Columns.Add("COSTO_UNITARIO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_pt.Columns.Add("COSTOS_VARIOS", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_pt.Columns.Add("SUB_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_pt.Columns.Add("IGV", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_pt.Columns.Add("COSTO_FINAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_pt.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal_pt.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Costos_Varios()
        Try
            dtdetalleArticulo_costos_varios = New DataTable
            dtdetalleArticulo_costos_varios.Columns.Add("ITEM_PT", Type.GetType("System.Int64"))
            dtdetalleArticulo_costos_varios.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticulo_costos_varios.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticulo_costos_varios.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticulo_costos_varios.Columns.Add("COSTO_UNITARIO", Type.GetType("System.Double"))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregandoArticulos()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmArticulo As New FrmAsignarArticulo_MP
            frmArticulo.AlmacenOrigen = ""
            frmArticulo.MonedaOrigen = "" 'cboMoneda.SelectedValue
            frmArticulo.EstadoOrigen = False
            frmArticulo.TIPO_FORMULA = "FO"
            frmArticulo.TIPO_PROD = "MP"
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                row("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                row("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                row("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                row("QTY_TEORICA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY_TEORICA")
                row("AVERAGE_COST") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST")
                row("EQUIVALENCIA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("EQUIVALENCIA")
                row("TYPE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TYPE")
                row("POR_EXCESO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("POR_EXCESO")
                row("DESCARGA_TOTAL") = Math.Round(row("QTY") * row("AVERAGE_COST"), 3)
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                Fl_close = False
            Else
                Fl_close = True
            End If
            ConfigurarGrila()
            frmArticulo.Close()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
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

    Private Sub txt_cod_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_articulo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Formulas()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_articulo.Text = "" Then
                Ayuda_Formulas()
            End If
        End If
    End Sub

    Private Sub txt_cod_articulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_articulo.MouseDoubleClick
        Ayuda_Formulas()
    End Sub
    Private Sub Ayuda_Formulas()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "MANUFAC_SP_S_FORMULATION"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Formulas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_articulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_des_articulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            Consultar_Formula(txt_cod_articulo.Text)
        End If
        frm.Close()
    End Sub

    Private Sub Consultar_Formula(ByVal _codigo As String)
        Try
            ''cabecera
            ManufactutraBl = New ClsOperaciones.FORMULATION
            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = ManufactutraBl.Modo_Edicion_Detalle(_codigo, "")
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                ConfigurarGrila()
                _cantidad_formula = dtdetalleArticuloPrincipal.Compute("sum(QTY)", "")
                _costo_total_formula = dtdetalleArticuloPrincipal.Compute("sum(DESCARGA_TOTAL)", "")
                Calcula_Total_Cantidad_Costo_Formula()
            Else
                _cantidad_formula = 0
                _costo_total_formula = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalles.DataSource = Nothing
            dgvDetalles.DataSource = dtdetalleArticuloPrincipal
            dgvDetalles.Columns("ITEM").Width = 40
            dgvDetalles.Columns(1).Width = 80
            dgvDetalles.Columns(2).Width = 300
            dgvDetalles.Columns(3).Width = 60
            dgvDetalles.Columns(4).Width = 80
            dgvDetalles.Columns(5).Width = 80
            dgvDetalles.Columns(6).Width = 80
            dgvDetalles.Columns(7).Width = 80
            dgvDetalles.Columns(8).Width = 80
            dgvDetalles.Columns(9).Width = 80
            dgvDetalles.Columns(10).Width = 80

            dgvDetalles.Columns(0).HeaderText = "Item"
            dgvDetalles.Columns(1).HeaderText = "Codigo"
            dgvDetalles.Columns(2).HeaderText = "Producto"
            dgvDetalles.Columns(3).HeaderText = "Unidad"
            dgvDetalles.Columns(4).HeaderText = "Cantidad"
            dgvDetalles.Columns(5).Visible = False '.HeaderText = "Cant.Teor"
            dgvDetalles.Columns(6).HeaderText = "Costo"
            dgvDetalles.Columns(7).Visible = False 'HeaderText = "Equival"
            dgvDetalles.Columns(8).Visible = False 'HeaderText = "Tipo"
            dgvDetalles.Columns(9).Visible = False 'HeaderText = "%.Exceso"
            dgvDetalles.Columns(10).HeaderText = "Total Costo"

            dgvDetalles.Columns(4).DefaultCellStyle.Format = "N4"
            dgvDetalles.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(6).DefaultCellStyle.Format = "N4"
            dgvDetalles.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(10).DefaultCellStyle.Format = "N4"
            dgvDetalles.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            Modo_Edicion = False
            gbcabecera.Enabled = True
            gbOpciones.Enabled = True
            gbOpciones_pt.Enabled = True
            Limpiar()
            'If Modo_Edicion = False Then
            '    txtcodigo.Enabled = True
            'End If
            txtcodigo.Text = ""
            GenerarColummnaDataTable()
            GenerarColummnaDataTable_Pt()
            GenerarColummnaDataTable_Costos_Varios()
            txt_cod_articulo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        txtcodigo.Text = String.Empty
        dtp_fecha.Value = Date.Now
        txt_cod_articulo.Text = String.Empty
        txt_des_articulo.Text = String.Empty
        txt_glosa.Text = String.Empty
        txt_lote.Text = String.Empty
        'cboMoneda.SelectedIndex = 0
        dgvDetalles.DataSource = Nothing
        dgvDetalles_pt.DataSource = Nothing
        _cantidad_formula = 0
        _costo_total_formula = 0
        Label7.Visible = False
        txt_porcentaje.Visible = False

        txt_cantidad_total.Text = Format(_cantidad_formula, "##,##0.0000")
        txt_costo_total.Text = Format(_costo_total_formula, "##,##0.0000")
    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregandoArticulos()
        Calcula_Total_Cantidad_Costo_Formula()
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_Click_1(sender, e)
        End If
    End Sub

    Private Sub Calcula_Total_Cantidad_Costo_Formula()
        If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
            _cantidad_formula = dtdetalleArticuloPrincipal.Compute("sum(QTY)", "")
            _costo_total_formula = dtdetalleArticuloPrincipal.Compute("sum(DESCARGA_TOTAL)", "")
        Else
            _cantidad_formula = 0
            _costo_total_formula = 0
        End If

        txt_cantidad_total.Text = Format(_cantidad_formula, "##,##0.0000")
        txt_costo_total.Text = Format(_costo_total_formula, "##,##0.0000")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        ModificandoArticulos()
        Calcula_Total_Cantidad_Costo_Formula
    End Sub

    Private Sub ModificandoArticulos()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmArticulo As New FrmAsignarArticulo_MP
            frmArticulo.AlmacenOrigen = ""
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.Flag_Modo_Edicion = True
            Dim Codigo As String = dgvDetalles.Item(0, dgvDetalles.CurrentRow.Index).Value
            'Enviando datos seleccioandos a Modificar
            frmArticulo._id_item = Codigo
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
                row("ITEM") = item("ITEM")
                row("PART_ID") = item("PART_ID")
                row("DESCRIPTION") = item("DESCRIPTION")
                row("UNIT") = item("UNIT")
                row("QTY") = item("QTY")
                row("QTY_TEORICA") = item("QTY_TEORICA")
                row("AVERAGE_COST") = item("AVERAGE_COST")
                row("EQUIVALENCIA") = item("EQUIVALENCIA")
                row("TYPE") = item("TYPE")
                row("POR_EXCESO") = item("POR_EXCESO")
                row("DESCARGA_TOTAL") = item("DESCARGA_TOTAL")
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                frmArticulo.dtdetalleArticulo.AcceptChanges()
            Next
            frmArticulo.ShowDialog()
            If frmArticulo.fl_close = False Then
                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                        dtdetalleArticuloPrincipal.BeginInit()

                        item("ITEM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("ITEM")
                        item("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                        item("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                        item("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                        item("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                        item("QTY_TEORICA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY_TEORICA")
                        item("AVERAGE_COST") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST")
                        item("EQUIVALENCIA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("EQUIVALENCIA")
                        item("TYPE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TYPE")
                        item("POR_EXCESO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("POR_EXCESO")
                        item("DESCARGA_TOTAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCARGA_TOTAL")
                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                    Next
                End If
            End If
            frmArticulo.Close()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click_1(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
        Calcula_Total_Cantidad_Costo_Formula()
    End Sub
    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
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
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub btnAgregar_pt_Click(sender As Object, e As EventArgs) Handles btnAgregar_pt.Click
        AgregandoArticulos_Pt()
        If dgvDetalles_pt.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_pt_Click(sender, e)
        End If
    End Sub
    Private Sub AgregandoArticulos_Pt()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmArticulo As New FrmAsignarArticulo_Pt
            Dim _correlativo_pt As Integer = 0
            If _cantidad_formula = 0 Then
                frmArticulo._costo_unitario = Math.Round(0, 4)
            Else
                frmArticulo._costo_unitario = _costo_total_formula
            End If

            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal_pt.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal_pt.Rows.Count() + 1
                _correlativo_pt = row("ITEM")
                row("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                row("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                row("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                row("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
                row("COSTO_UNITARIO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COSTO_UNITARIO")
                row("COSTOS_VARIOS") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COSTOS_VARIOS")
                row("SUB_TOTAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("SUB_TOTAL")
                row("IGV") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV")
                row("COSTO_FINAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COSTO_FINAL")
                dtdetalleArticuloPrincipal_pt.Rows.Add(row)
                dtdetalleArticuloPrincipal_pt.AcceptChanges()
                Fl_close = False
            Else
                Fl_close = True
            End If

            If frmArticulo.dtdetalleArticulo_costos_varios.Rows.Count() <> 0 Then

                For Each item As DataRow In dtdetalleArticulo_costos_varios.Select("ITEM_PT=" & _correlativo_pt)
                    dtdetalleArticulo_costos_varios.BeginInit()
                    item.Delete()
                    dtdetalleArticulo_costos_varios.EndInit()
                    dtdetalleArticulo_costos_varios.AcceptChanges()
                Next

                For Each item As DataRow In frmArticulo.dtdetalleArticulo_costos_varios.Select()
                    Dim row As DataRow = dtdetalleArticulo_costos_varios.NewRow
                    row("ITEM_PT") = _correlativo_pt
                    row("ITEM") = item("ITEM")
                    row("PART_ID") = item("PART_ID")
                    row("DESCRIPTION") = item("DESCRIPTION")
                    row("COSTO_UNITARIO") = item("COSTO_UNITARIO")
                    dtdetalleArticulo_costos_varios.Rows.Add(row)
                    dtdetalleArticulo_costos_varios.AcceptChanges()
                Next
                Fl_close = False
            Else
                Fl_close = True
            End If

            ConfigurarGrila_Pt()
            frmArticulo.Close()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila_Pt()
        If dtdetalleArticuloPrincipal_pt.Rows.Count() <> 0 Then
            dgvDetalles_pt.DataSource = Nothing
            dgvDetalles_pt.DataSource = dtdetalleArticuloPrincipal_pt
            dgvDetalles_pt.Columns("ITEM").Width = 40
            dgvDetalles_pt.Columns("PART_ID").Width = 80
            dgvDetalles_pt.Columns("DESCRIPTION").Width = 350
            dgvDetalles_pt.Columns("UNIT").Width = 60
            dgvDetalles_pt.Columns("CANTIDAD").Width = 80
            dgvDetalles_pt.Columns("COSTO_UNITARIO").Width = 80
            dgvDetalles_pt.Columns("COSTOS_VARIOS").Width = 80
            dgvDetalles_pt.Columns("SUB_TOTAL").Width = 80
            dgvDetalles_pt.Columns("IGV").Width = 80
            dgvDetalles_pt.Columns("COSTO_FINAL").Width = 80

            dgvDetalles_pt.Columns("ITEM").HeaderText = "Item"
            dgvDetalles_pt.Columns("PART_ID").HeaderText = "Codigo"
            dgvDetalles_pt.Columns("DESCRIPTION").HeaderText = "Producto"
            dgvDetalles_pt.Columns("UNIT").HeaderText = "Unidad"
            dgvDetalles_pt.Columns("CANTIDAD").HeaderText = "Cantidad"
            dgvDetalles_pt.Columns("COSTO_UNITARIO").HeaderText = "Costo Unitario"
            dgvDetalles_pt.Columns("COSTOS_VARIOS").HeaderText = "Costos Varios"
            dgvDetalles_pt.Columns("SUB_TOTAL").HeaderText = "Sub Total"
            dgvDetalles_pt.Columns("IGV").HeaderText = "I.G.V."
            dgvDetalles_pt.Columns("COSTO_FINAL").HeaderText = "Costo Final"

            dgvDetalles_pt.Columns("CANTIDAD").DefaultCellStyle.Format = "N4"
            dgvDetalles_pt.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles_pt.Columns("COSTO_UNITARIO").DefaultCellStyle.Format = "N4"
            dgvDetalles_pt.Columns("COSTO_UNITARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles_pt.Columns("COSTOS_VARIOS").DefaultCellStyle.Format = "N4"
            dgvDetalles_pt.Columns("COSTOS_VARIOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles_pt.Columns("SUB_TOTAL").DefaultCellStyle.Format = "N4"
            dgvDetalles_pt.Columns("SUB_TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles_pt.Columns("IGV").DefaultCellStyle.Format = "N4"
            dgvDetalles_pt.Columns("IGV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles_pt.Columns("COSTO_FINAL").DefaultCellStyle.Format = "N4"
            dgvDetalles_pt.Columns("COSTO_FINAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub

    Private Sub btnModificar_pt_Click(sender As Object, e As EventArgs) Handles btnModificar_pt.Click
        If dgvDetalles_pt.CurrentRow Is Nothing Then Exit Sub
        ModificandoArticulos_Pt()
    End Sub

    Private Sub ModificandoArticulos_Pt()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmArticulo As New FrmAsignarArticulo_Pt
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.GenerarColummnaDataTable_Costos_Varios()
            frmArticulo.Flag_Modo_Edicion = True
            Dim Codigo As String = dgvDetalles_pt.Item(0, dgvDetalles_pt.CurrentRow.Index).Value
            'Enviando datos seleccioandos a Modificar
            If _cantidad_formula = 0 Then
                frmArticulo._costo_unitario = Math.Round(0, 4)
            Else
                frmArticulo._costo_unitario = _costo_total_formula
            End If

            frmArticulo._id_item = Codigo
            For Each item As DataRow In dtdetalleArticuloPrincipal_pt.Select("ITEM=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
                row("ITEM") = item("ITEM")
                row("PART_ID") = item("PART_ID")
                row("DESCRIPTION") = item("DESCRIPTION")
                row("UNIT") = item("UNIT")
                row("CANTIDAD") = item("CANTIDAD")
                row("COSTO_UNITARIO") = item("COSTO_UNITARIO")
                row("COSTOS_VARIOS") = item("COSTOS_VARIOS")
                row("SUB_TOTAL") = item("SUB_TOTAL")
                row("IGV") = item("IGV")
                row("COSTO_FINAL") = item("COSTO_FINAL")
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                frmArticulo.dtdetalleArticulo.AcceptChanges()
            Next

            For Each item As DataRow In dtdetalleArticulo_costos_varios.Select("ITEM_PT=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo_costos_varios.NewRow
                row("ITEM") = item("ITEM")
                row("PART_ID") = item("PART_ID")
                row("DESCRIPTION") = item("DESCRIPTION")
                row("COSTO_UNITARIO") = item("COSTO_UNITARIO")
                frmArticulo.dtdetalleArticulo_costos_varios.Rows.Add(row)
                frmArticulo.dtdetalleArticulo_costos_varios.AcceptChanges()
            Next

            frmArticulo.ShowDialog()
            If frmArticulo.fl_close = False Then
                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                    For Each item As DataRow In dtdetalleArticuloPrincipal_pt.Select("ITEM=" & Codigo)
                        dtdetalleArticuloPrincipal_pt.BeginInit()
                        item("ITEM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("ITEM")
                        item("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                        item("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                        item("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                        item("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
                        item("COSTO_UNITARIO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COSTO_UNITARIO")
                        item("COSTOS_VARIOS") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COSTOS_VARIOS")
                        item("SUB_TOTAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("SUB_TOTAL")
                        item("IGV") = frmArticulo.dtdetalleArticulo.Rows(0).Item("IGV")
                        item("COSTO_FINAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("COSTO_FINAL")
                        dtdetalleArticuloPrincipal_pt.EndInit()
                        dtdetalleArticuloPrincipal_pt.AcceptChanges()
                    Next
                End If

                If frmArticulo.dtdetalleArticulo_costos_varios.Rows.Count() <> 0 Then

                    For Each item As DataRow In dtdetalleArticulo_costos_varios.Select("ITEM_PT=" & Codigo)
                        dtdetalleArticulo_costos_varios.BeginInit()
                        item.Delete()
                        dtdetalleArticulo_costos_varios.EndInit()
                        dtdetalleArticulo_costos_varios.AcceptChanges()
                    Next

                    For Each item As DataRow In frmArticulo.dtdetalleArticulo_costos_varios.Select()
                        Dim row As DataRow = dtdetalleArticulo_costos_varios.NewRow
                        row("ITEM_PT") = Codigo
                        row("ITEM") = item("ITEM")
                        row("PART_ID") = item("PART_ID")
                        row("DESCRIPTION") = item("DESCRIPTION")
                        row("COSTO_UNITARIO") = item("COSTO_UNITARIO")
                        dtdetalleArticulo_costos_varios.Rows.Add(row)
                        dtdetalleArticulo_costos_varios.AcceptChanges()
                    Next

                End If
            End If
            frmArticulo.Close()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_pt_Click(sender As Object, e As EventArgs) Handles btnquitar_pt.Click
        If dgvDetalles_pt.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo_Pt()
    End Sub

    Private Sub EliminandoArticulo_Pt()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalles_pt.Item(0, dgvDetalles_pt.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal_pt.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal_pt.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal_pt.EndInit()
                    dtdetalleArticuloPrincipal_pt.AcceptChanges()
                Next
                RehacerSecuencia_Pt()
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RehacerSecuencia_Pt()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal_pt.Rows
            i += 1
            dtdetalleArticuloPrincipal_pt.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal_pt.EndInit()
            dtdetalleArticuloPrincipal_pt.AcceptChanges()
        Next
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalles_pt.Rows.Count() = 0 Then Exit Sub
        If dgvDetalles_pt.CurrentRow Is Nothing Then Exit Sub

        If Guardar_Proceso_Costeo() Then
            Documentos_Orden_Fabricacion()
            btnCancelar_Click(sender, e)
        End If
    End Sub

    Private Function Guardar_Proceso_Costeo() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            ManufactutraBl = New ClsOperaciones.FORMULATION
            ProcesoCosteoCab = New ClsEntidades.PROCESO_COSTEO
            ListaDetalles_mp = New List(Of ClsEntidades.PROCESO_COSTEO_MP)
            ListaDetalles_pt = New List(Of ClsEntidades.PROCESO_COSTEO_PT)
            ListaDetalles_pt_line = New List(Of ClsEntidades.PROCESO_COSTEO_PT_LINE)

            If Modo_Edicion = True Then
                ProcesoCosteoCab.ID = CInt(txtcodigo.Text)
            Else
                ProcesoCosteoCab.ID = 0
            End If

            ProcesoCosteoCab.FECHA = dtp_fecha.Value.ToString("dd/MM/yyyy")
            ProcesoCosteoCab.ID_FORMULA = txt_cod_articulo.Text
            ProcesoCosteoCab.USER_ID = LibComunVar.ClsVarComun.USUARIO
            ProcesoCosteoCab.GLOSA = txt_glosa.Text
            ProcesoCosteoCab.LOTE = txt_lote.Text

            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                ProcesoCosteo_Mp = New ClsEntidades.PROCESO_COSTEO_MP
                ProcesoCosteo_Mp.ID_CAB = ProcesoCosteoCab.ID
                ProcesoCosteo_Mp.ITEM = item("ITEM").ToString
                ProcesoCosteo_Mp.PART_ID = item("PART_ID").ToString
                ProcesoCosteo_Mp.PART_DESCRIPTION = item("DESCRIPTION").ToString
                ProcesoCosteo_Mp.UNIT = item("UNIT").ToString
                ProcesoCosteo_Mp.QTY = CDbl(item("QTY").ToString)
                ProcesoCosteo_Mp.AVERAGE_COST = CDbl(item("AVERAGE_COST"))
                ListaDetalles_mp.Add(ProcesoCosteo_Mp)
            Next

            For Each item As DataRow In dtdetalleArticuloPrincipal_pt.Rows
                ProcesoCosteo_Pt = New ClsEntidades.PROCESO_COSTEO_PT
                ProcesoCosteo_Pt.ID_CAB = ProcesoCosteoCab.ID
                ProcesoCosteo_Pt.ITEM = item("ITEM").ToString
                ProcesoCosteo_Pt.PART_ID = item("PART_ID").ToString
                ProcesoCosteo_Pt.PART_DESCRIPTION = item("DESCRIPTION").ToString
                ProcesoCosteo_Pt.UNIT = item("UNIT").ToString
                ProcesoCosteo_Pt.CANTIDAD = CDbl(item("CANTIDAD").ToString)
                ProcesoCosteo_Pt.COSTO_UNITARIO = CDbl(item("COSTO_UNITARIO").ToString)
                ProcesoCosteo_Pt.COSTOS_VARIOS = CDbl(item("COSTOS_VARIOS"))
                ProcesoCosteo_Pt.SUB_TOTAL = CDbl(item("SUB_TOTAL"))
                ProcesoCosteo_Pt.IGV = CDbl(item("IGV"))
                ProcesoCosteo_Pt.COSTO_FINAL = CDbl(item("COSTO_FINAL"))
                ListaDetalles_pt.Add(ProcesoCosteo_Pt)
            Next

            For Each item As DataRow In dtdetalleArticulo_costos_varios.Rows
                ProcesoCosteo_Pt_Line = New ClsEntidades.PROCESO_COSTEO_PT_LINE
                ProcesoCosteo_Pt_Line.ID_CAB = ProcesoCosteoCab.ID
                ProcesoCosteo_Pt_Line.ITEM_PT = item("ITEM_PT").ToString
                ProcesoCosteo_Pt_Line.ITEM = item("ITEM").ToString
                ProcesoCosteo_Pt_Line.PART_ID = item("PART_ID").ToString
                ProcesoCosteo_Pt_Line.PART_DESCRIPTION = item("DESCRIPTION").ToString
                ProcesoCosteo_Pt_Line.COSTO_UNITARIO = CDbl(item("COSTO_UNITARIO").ToString)
                ListaDetalles_pt_line.Add(ProcesoCosteo_Pt_Line)
            Next

            If ManufactutraBl.GuardarProceso_Costeo(ProcesoCosteoCab, ListaDetalles_mp, ListaDetalles_pt, ListaDetalles_pt_line, Modo_Edicion) Then
                If Modo_Edicion = True Then
                    MsgBox("Proceso de Costeo Modificado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                Else
                    MsgBox("Nuevo Proceso de Costeo Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                End If

            End If
            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Modo_Edicion = True
        Call Botonera_Estado_Cambiar(True)
        pnlCabecera.Visible = False
        Dim _id As Integer = 0
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value

        Try
            ''cabecera
            ManufactutraBl = New ClsOperaciones.FORMULATION
            Dim dtCabeceraF As New DataTable
            dtCabeceraF = ManufactutraBl.Modo_Edicion_Cabecera_Proceso_Costeo(_id)
            If dtCabeceraF.Rows.Count() <> 0 Then
                txtcodigo.Text = dtCabeceraF.Rows(0).Item("ID").ToString
                dtp_fecha.Value = dtCabeceraF.Rows(0).Item("FECHA").ToString
                txt_cod_articulo.Text = dtCabeceraF.Rows(0).Item("ID_FORMULA").ToString
                txt_des_articulo.Text = dtCabeceraF.Rows(0).Item("DESCRIPTION").ToString
                txt_glosa.Text = dtCabeceraF.Rows(0).Item("GLOSA").ToString
                txt_lote.Text = dtCabeceraF.Rows(0).Item("LOTE").ToString
            End If

            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = ManufactutraBl.Modo_Edicion_Detalle_Proceso_Costeo_MP(_id)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                ConfigurarGrila()
                Calcula_Total_Cantidad_Costo_Formula()
            End If

            GenerarColummnaDataTable_Pt()
            dtdetalleArticuloPrincipal_pt = ManufactutraBl.Modo_Edicion_Detalle_Proceso_Costeo_PT(_id)
            If dtdetalleArticuloPrincipal_pt.Rows.Count() <> 0 Then
                'ConfigurarGrila()
                ConfigurarGrila_Pt()
            End If

            GenerarColummnaDataTable_Costos_Varios()
            dtdetalleArticulo_costos_varios = ManufactutraBl.Modo_Edicion_Detalle_Proceso_Costeo_PT_LINE(_id)
            If dtdetalleArticulo_costos_varios.Rows.Count() <> 0 Then
                'ConfigurarGrila()
            End If

            'btnGrabar.Enabled = True
            gbOpciones.Enabled = True
            gbOpciones_pt.Enabled = True
            Label7.Visible = False
            txt_porcentaje.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then

        ElseIf txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            'lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns("Codigo").Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns("Formula.Producto").Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns("Codigo").Name & "+" & dgvCabecera.Columns("Formula.Producto").Name
                        Exit Sub
                    End If
                End If
            End If
            ' lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub btn_reprocesar_Click(sender As Object, e As EventArgs) Handles btn_reprocesar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Modo_Edicion = True
        Call Botonera_Estado_Cambiar(True)
        pnlCabecera.Visible = False
        Dim _id As Integer = 0
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value

        Try
            ''cabecera
            ManufactutraBl = New ClsOperaciones.FORMULATION
            Dim dtCabeceraF As New DataTable
            dtCabeceraF = ManufactutraBl.Modo_Edicion_Cabecera_Proceso_Costeo(_id)
            If dtCabeceraF.Rows.Count() <> 0 Then
                txtcodigo.Text = dtCabeceraF.Rows(0).Item("ID").ToString
                dtp_fecha.Value = Date.Now
                txt_cod_articulo.Text = dtCabeceraF.Rows(0).Item("ID_FORMULA").ToString
                txt_des_articulo.Text = dtCabeceraF.Rows(0).Item("DESCRIPTION").ToString
                txt_glosa.Text = ""
                txt_lote.Text = ""
                txt_porcentaje.Text = ""
            End If

            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = ManufactutraBl.Modo_Edicion_Detalle_Proceso_Costeo_MP_REPROCESO(_id)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                ConfigurarGrila()
                Calcula_Total_Cantidad_Costo_Formula()
            End If

            GenerarColummnaDataTable_Pt()
            dtdetalleArticuloPrincipal_pt = ManufactutraBl.Modo_Edicion_Detalle_Proceso_Costeo_PT_REPROCESO(_id)
            If dtdetalleArticuloPrincipal_pt.Rows.Count() <> 0 Then
                'ConfigurarGrila()
                ConfigurarGrila_Pt()
            End If

            GenerarColummnaDataTable_Costos_Varios()
            dtdetalleArticulo_costos_varios = ManufactutraBl.Modo_Edicion_Detalle_Proceso_Costeo_PT_LINE_REPROCESO(_id)
            If dtdetalleArticulo_costos_varios.Rows.Count() <> 0 Then
                'ConfigurarGrila()
            End If

            Calcula_Total_Cantidad_Costo_Formula()
            btnGrabar.Enabled = True
            gbOpciones.Enabled = True
            gbOpciones_pt.Enabled = True
            Modo_Edicion = False
            Label7.Visible = True
            txt_porcentaje.Visible = True
            txtcodigo.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
                Dim _id As String = String.Empty
                Dim Alm As String = String.Empty
                If OrdenProduccionBl.Eliminar_Proceso_Costeo(dgvCabecera.CurrentRow.Cells("Codigo").Value) Then
                    MsgBox("Registro eliminado Correctamente.", MsgBoxStyle.Information)
                    Documentos_Orden_Fabricacion()
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_porcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_porcentaje.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_porcentaje_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_porcentaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            If LTrim(RTrim(txt_porcentaje.Text)) = "" Then
                MsgBox("Debe ingresar un % para el costeo.", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf CInt(txt_porcentaje.Text) = 0 Then
                MsgBox("Debe ingresar un % mayor a cero.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("Esta seguro de costear al porcentaje indicado?" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    ''cabecera
                    Me.Cursor = Cursors.WaitCursor
                    ManufactutraBl = New ClsOperaciones.FORMULATION
                    Dim dtCabeceraF As New DataTable

                    Dim _id As Integer = 0
                    _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value

                    GenerarColummnaDataTable()
                    dtdetalleArticuloPrincipal = ManufactutraBl.Modo_Edicion_Detalle_Proceso_Costeo_MP_REPROCESO(_id, CInt(txt_porcentaje.Text))
                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        ConfigurarGrila()
                        Calcula_Total_Cantidad_Costo_Formula()
                    End If

                    GenerarColummnaDataTable_Pt()
                    dtdetalleArticuloPrincipal_pt = ManufactutraBl.Modo_Edicion_Detalle_Proceso_Costeo_PT_REPROCESO(_id, CInt(txt_porcentaje.Text))
                    If dtdetalleArticuloPrincipal_pt.Rows.Count() <> 0 Then
                        'ConfigurarGrila()
                        ConfigurarGrila_Pt()
                    End If

                    GenerarColummnaDataTable_Costos_Varios()
                    dtdetalleArticulo_costos_varios = ManufactutraBl.Modo_Edicion_Detalle_Proceso_Costeo_PT_LINE_REPROCESO(_id, CInt(txt_porcentaje.Text))
                    If dtdetalleArticulo_costos_varios.Rows.Count() <> 0 Then
                        'ConfigurarGrila()
                    End If

                    Calcula_Total_Cantidad_Costo_Formula()
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class