Imports LibCompras
Imports LibComunVar
Imports LibCobranzas
Public Class FrmGuia_Devolucion
    Dim Modo_consultar As Boolean = False
    Dim dtdetallePrincipal As DataTable
    Private _tipoMov As String = String.Empty
    Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE
    Dim dtCabeceraFact As DataTable
    Private clsFacturaBl As ClsNegocio.RECEIVABLE

    Dim clsRequisionesBl As ClsOperaciones.REQUIREMENT
    Dim dtDocumentos As DataTable
    Dim dtv As DataView
    Dim STRorden As String = ""

    Dim dtDocumentos_OI As DataTable
    Dim dtv_OI As DataView

    Dim CORRELATIVOBL As ClsTransacciones.REQUIREMENT
    Dim _Flag_edicion As Boolean = False
    Dim _Codigo_Ini As String = ""

    Dim dtCabeceraReq As DataTable
    Dim dtDetalleReq As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtAlmacen As DataTable
    Dim estado As String
    Dim estado_atencion As String
    Dim _area_usuario As String = String.Empty
    Dim _nivel_acceso As String = String.Empty
    Dim _var_inicio As Boolean = False

    Private dtv_lotes As DataView
    Private STRorden_lotes As String
    Dim OrdenCompraBl As ClsOperaciones.PURCHASE_ORDER
    Dim dtlistaLotes As DataTable
    Private Sub FrmGuia_Devolución_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        Cargar_Areas()
        Cargar_Estados()
        cbo_estado_atencion.SelectedIndex = 0
        cboopcionesBusqueda.SelectedIndex = 1

        _var_inicio = True
        If _nivel_acceso = "01" Then
            cboareas.SelectedIndex = 0
        Else
            If _area_usuario = "" Then
                cboareas.SelectedIndex = -1
            Else
                cboareas.SelectedValue = _area_usuario
            End If
        End If
        Botonera_Estado_Cambiar(False)
        GenerarColummnaDataTable()
        'GroupBox4.Visible = True 'NIVEL_ACCESO_ADM()
        cboareas.Enabled = NIVEL_ACCESO_ADM()
    End Sub

    Private Sub Cargar_Areas()
        Try
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtAlmacen = New DataTable
            dtAlmacen = clsRequisionesBl.get_Lista_Areas()
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("ID") = ""
            row.Item("DESCRIPTION") = "TODOS"
            dtAlmacen.Rows.InsertAt(row, 0)
            cboareas.DataSource = dtAlmacen
            cboareas.DisplayMember = "DESCRIPTION"
            cboareas.ValueMember = "ID"

            dtAlmacen = New DataTable

            dtAlmacen = clsRequisionesBl.get_Area_Usuario(ClsVarComun.USUARIO)
            If dtAlmacen.Rows.Count > 0 Then
                _area_usuario = dtAlmacen.Rows(0).Item("AREA").ToString
                _nivel_acceso = dtAlmacen.Rows(0).Item("NIVEL_ACCESO").ToString
            End If
            If _nivel_acceso = "01" Then 'administrador
                cboareas.SelectedIndex = 0
            Else
                If _area_usuario = "" Then
                    cboareas.SelectedIndex = -1
                Else
                    cboareas.SelectedValue = _area_usuario
                End If
            End If

            clsRequisionesBl = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cargar_Estados()
        Try
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtAlmacen = New DataTable
            dtAlmacen = clsRequisionesBl.get_Lista_Estados_Requisiciones()
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("ID") = ""
            row.Item("DESCRIPCION") = "Todos"
            dtAlmacen.Rows.InsertAt(row, 0)
            'cbo_estados.DataSource = dtAlmacen
            'cbo_estados.DisplayMember = "DESCRIPCION"
            'cbo_estados.ValueMember = "ID"
            clsRequisionesBl = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btn_cierre_manul.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btn_cierre_manul.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
        End If
    End Sub

    Private Function NIVEL_ACCESO_ADM() As Boolean
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
            FLAG_NIVEL = False
        End Try
        Return FLAG_NIVEL
    End Function

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetallePrincipal = New DataTable("Requisiciones")
            dtdetallePrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetallePrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("ESTADO", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("COD_PRIORIDAD", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("N_ANALISIS", Type.GetType("System.String")) 'agregado
            dtdetallePrincipal.PrimaryKey = New DataColumn() {dtdetallePrincipal.Columns("ITEM")}
            dgvDetalle.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged

        If STRorden = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns("Codigo").Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns("NUMERO_OP").Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns("Solicitante").Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvCabecera.Columns("Comentario").Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvCabecera.Columns("REQUIRED_USER").Name
                                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                                If dtv.Count() = 0 Then
                                    STRorden = String.Empty
                                    STRorden = dgvCabecera.Columns("Codigo").Name & "+" & dgvCabecera.Columns("NUMERO_OP").Name & "+" & dgvCabecera.Columns("Solicitante").Name & "+" & dgvCabecera.Columns("Comentario").Name & "+" & dgvCabecera.Columns("REQUIRED_USER").Name
                                    lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                    Exit Sub
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Enabled = False
                txtFiltro.Text = String.Empty
                DocumentosRequisiones()
            Case 1
                gbRangofechas.Enabled = False
                txtFiltro.Text = String.Empty
                DocumentosRequisiones()
            Case 2
                gbRangofechas.Enabled = True
                txtFiltro.Text = String.Empty
                DocumentosRequisiones()
        End Select
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub


    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub DocumentosRequisiones()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    System.Windows.Forms.MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtDocumentos = New DataTable
            dtv = New DataView

            dtDocumentos = clsRequisionesBl.get_DatosGenerales_Guia_Devolucion(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                           cboopcionesBusqueda.SelectedIndex, "GD", cboareas.SelectedValue.ToString, _
                                                                           "", cbo_estado_atencion.Text)

            dgvCabecera.DataSource = Nothing
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'For i As Integer = 8 To dgvCabecera.ColumnCount() - 1
                '    dgvCabecera.Columns(i).Visible = False
                'Next
                dgvCabecera.Columns("Estado").Visible = True
                dgvCabecera.Columns("Solicitante").Visible = False
                dgvCabecera.Columns("ESTADO ATENCION").Visible = True
                dgvCabecera.Columns("ESTADO ATENCION").HeaderText = "Estado de Atención"
                dgvCabecera.Columns("ES_MANUAL").HeaderText = "Cierre Manual?" 'agregado
                dgvCabecera.Columns("ES_MANUAL").Visible = True
                dgvCabecera.Columns("NUMERO_OP").HeaderText = "N° O.P." 'agregado

                dgvCabecera.Columns("PART_ID").HeaderText = "Cod. Producto"
                dgvCabecera.Columns("PART_DESCRIPTION").HeaderText = "Descripción"
                dgvCabecera.Columns("LOTE_ID").HeaderText = "N° Lote"
                dgvCabecera.Columns("VCTO_LOTE").HeaderText = "Vencimiento"

                dgvCabecera.Columns("QTY").Visible = False
                dgvCabecera.Columns("AREA_ID").Visible = False
                dgvCabecera.Columns("CREATE_DATE").Visible = False
                dgvCabecera.Columns("UPDATE_DATE").Visible = False
                dgvCabecera.Columns("USER_ID").Visible = False
                dgvCabecera.Columns("STATUS").Visible = False
                dgvCabecera.Columns("EMITIDO").Visible = False

                dgvCabecera.Columns("REQUIRED_USER").Visible = False
                dgvCabecera.Columns("PART_ID").Visible = False
                dgvCabecera.Columns("PART_DESCRIPTION").Visible = False
                dgvCabecera.Columns("LOTE_ID").Visible = False
                dgvCabecera.Columns("Area").Visible = False
                dgvCabecera.Columns("VCTO_LOTE").Visible = False
                dgvCabecera.Columns("ES_MANUAL").Visible = False


                STRorden = dgvCabecera.Columns("Codigo").Name & "+" & dgvCabecera.Columns("NUMERO_OP").Name & "+" & dgvCabecera.Columns("Solicitante").Name & "+" & dgvCabecera.Columns("Comentario").Name & "+" & dgvCabecera.Columns("REQUIRED_USER").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub Nuevo()
        Try
            limpiar()
            configurarGrilla()
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            Modo_consultar = False
            CONTROLES(True, 0)
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
            txttipoDoc.Text = "GD"

            txtcodigo.Text = Numeracion()
            txt_numero_op.Select()
            lbl_usuario.Text = ClsVarComun.USUARIO
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        txtarea.Text = ""
        txtdescripcion_area.Text = ""
        txtsolicitante.Text = ""
        txtdescripcion_solicitante.Text = ""
        txtcomentario.Text = ""
        txttipoDoc.Text = ""
        txtcodigo.Text = ""
        dtpFechad.Value = Date.Today
        dtdetallePrincipal.Rows.Clear()
        dgvDetalle.DataSource = Nothing
        lbl_usuario.Text = ""
        txt_cod_producto.Text = ""
        txt_des_producto.Text = ""
        txt_lote.Text = ""
        txt_vcto_lote.Text = ""
        txt_cantidad.Text = ""
        txt_numero_op.Text = ""
    End Sub

    Private Sub configurarGrilla()
        dgvDetalle.DataSource = dtdetallePrincipal
        dgvDetalle.AutoResizeColumns()
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'For i As Integer = 7 To dgvDetalle.Columns.Count() - 1
        '    dgvDetalle.Columns(i).Visible = False
        'Next
        'dgvDetalle.Columns(5).Visible = False
        'dgvDetalle.Columns(9).Visible = True
        'dgvDetalle.Columns(10).Visible = True
        dgvDetalle.Columns("N_ANALISIS").Visible = True
        dgvDetalle.Columns("ESTADO").Visible = False

        dgvDetalle.Columns("ITEM").HeaderText = "Item"
        dgvDetalle.Columns("PART_ID").HeaderText = "Codigo"
        dgvDetalle.Columns("PART_DESCRIPTION").HeaderText = "Descripcion"
        dgvDetalle.Columns("UNIT").HeaderText = "Unidad"
        dgvDetalle.Columns("QTY").HeaderText = "Cantidad"
        dgvDetalle.Columns("COD_PRIORIDAD").Visible = False 'HeaderText = "Prioridad"
        dgvDetalle.Columns("N_ANALISIS").HeaderText = "N° Lote"
        Formatea_grilla(dgvDetalle)
    End Sub

    Private Sub CONTROLES(ByVal opcion As Boolean, ByVal _indice As Integer)
        Tc_principal.TabPages(0).Enabled = False
        Tc_principal.TabPages(1).Enabled = False
        Tc_principal.TabPages(_indice).Enabled = opcion
        Tc_principal.SelectTab(_indice)
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.REQUIREMENT
            CORRELATIVOBL.NumeroCorrelativo_Guia_Devolucion(dtpFechad.Value.Year)
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = String.Format("{0:0000000}", 1) & "-" & dtpFechad.Value.Year.ToString
            Else
                Correlativo = String.Format("{0:0000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1)) & "-" & dtpFechad.Value.Year.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Correlativo
    End Function

    Private Sub MostrandoArticulos(ByVal TEXTO As TextBox, ByVal TEXTO2 As TextBox)
        Try
            Dim frm As New LibCobranzas.frmBuscar
            Dim sql As String = String.Empty

            sql = "ALM_SP_S_WAREHOUSE_PRODUCTO_GUIA_DEVOLUCION"
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TEXTO.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                TEXTO2.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_producto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_producto.MouseDoubleClick
        MostrandoArticulos(txt_cod_producto, txt_des_producto)
    End Sub

    Private Sub txt_cod_producto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_producto.KeyDown
        If e.KeyCode = Keys.F1 Then
            MostrandoArticulos(txt_cod_producto, txt_des_producto)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_producto.Text = "" Then
                MostrandoArticulos(txt_cod_producto, txt_des_producto)
            Else
                txt_lote.Focus()
            End If
        End If
    End Sub

    Private Sub txt_lote_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_lote.MouseDoubleClick
        Mostrando_Lotes()
    End Sub

    Private Sub Mostrando_Lotes()
        Try
            Dim frm As New LibCobranzas.frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "CONTROL_SP_S_WAREHOUSE_LOTES_ETIQUETAS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_cod_producto.Text
            frm.Titulo = "Seleccion de Lotes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_lote.Text = frm.Data_Matriz.Rows(0).Item("LOTE").ToString
                txt_vcto_lote.Text = frm.Data_Matriz.Rows(0).Item("VENCIMIENTO").ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarea_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarea.MouseDoubleClick
        Ayuda_Area()
    End Sub

    Private Sub Ayuda_Area()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_AREA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de areas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarea.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcion_area.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtsolicitante.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarea.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Area()
        ElseIf e.KeyCode = Keys.Enter Then
            If txtarea.Text = String.Empty Then
                Ayuda_Area()
            Else
                txtsolicitante.Focus()
            End If
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub

    Private Sub txtsolicitante_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtsolicitante.MouseDoubleClick
        mostrandoAlmacen()
    End Sub

    Public Sub mostrandoAlmacen()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "COMPRAS_SP_S_AREA"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de areas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtsolicitante.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txtdescripcion_solicitante.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            txt_cod_producto.Focus()
        End If
        frm.Close()
    End Sub

    Private Sub txtcomentario_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnAgregar.Focus()
        End If
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try
            If txtcodigoArticulo.Text = "" Then
                MsgBox("Debe seleccionar un Articulo.", MsgBoxStyle.Critical)
                txtcodigoArticulo.Select()
                Exit Sub
            End If
            If txtcantidad.Text = "" Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Critical)
                txtcodigoArticulo.Select()
                Exit Sub
            ElseIf Val(txtcantidad.Text) = 0 Then
                MsgBox("Debe ingresar una cantidad diferente de 0.", MsgBoxStyle.Critical)
                txtcantidad.Select()
                Exit Sub
            End If

            'If txt_n_analisis.Text = "" Then
            '    MsgBox("Debe seleccionar un N° de análisis.", MsgBoxStyle.Critical)
            '    txt_n_analisis.Select()
            '    Exit Sub
            'End If

            If _Flag_edicion = False Then 'nuevo
                Dim row As DataRow = dtdetallePrincipal.NewRow
                row("ITEM") = dtdetallePrincipal.Rows.Count() + 1
                row("PART_ID") = txtcodigoArticulo.Text
                row("PART_DESCRIPTION") = txtdescripcionArticulo.Text
                row("UNIT") = txtunidadMedida.Text
                row("QTY") = txtcantidad.Text

                row("N_ANALISIS") = txt_n_analisis.Text
                dtdetallePrincipal.Rows.Add(row)
                dtdetallePrincipal.AcceptChanges()
                blank()
                txtcodigoArticulo.Select()
            Else 'modificacion
                For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & _Codigo_Ini)
                    dtdetallePrincipal.BeginInit()
                    item("PART_ID") = txtcodigoArticulo.Text
                    item("PART_DESCRIPTION") = txtdescripcionArticulo.Text
                    item("UNIT") = txtunidadMedida.Text
                    item("QTY") = txtcantidad.Text
                    item("COD_PRIORIDAD") = ""
                    item("N_ANALISIS") = txt_n_analisis.Text
                    dtdetallePrincipal.EndInit()
                    dtdetallePrincipal.AcceptChanges()
                    btn_salir_Click(sender, e)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        CONTROLES(True, 0)
        configurarGrilla()
        btn_menu.Enabled = True
    End Sub

    Public Sub blank()
        txtcodigoArticulo.Text = ""
        txtdescripcionArticulo.Text = ""
        txtunidadMedida.Text = ""
        txtcantidad.Text = ""
        txt_n_analisis.Text = ""
        'dgv_stock.DataSource = Nothing
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            blank()
            If GbCabecera.Enabled = True Then
                'If txt_cod_producto.Text = "" Then
                '    MsgBox("Debe seleccionar un Producto.", MsgBoxStyle.Exclamation)
                '    txt_cod_producto.Select()
                '    Exit Sub
                'End If
                'If txt_lote.Text = "" Then
                '    MsgBox("Debe seleccionar un Lote.", MsgBoxStyle.Exclamation)
                '    txt_lote.Select()
                '    Exit Sub
                'End If

                'If txtsolicitante.Text = "" Then
                '    MsgBox("Debe seleccionar un Almacen.", MsgBoxStyle.Exclamation)
                '    txtsolicitante.Select()
                '    Exit Sub
                'ElseIf txtarea.Text = "" Then
                '    MsgBox("Debe seleccionar una Area.", MsgBoxStyle.Exclamation)
                '    txtarea.Select()
                '    Exit Sub
                'End If
                GbCabecera.Enabled = False
            End If
            _Flag_edicion = False
            CONTROLES(True, 1)
            btn_menu.Enabled = False
            'pnl_stock.Visible = True
            'dgv_stock.DataSource = Nothing
            txtcodigoArticulo.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvDetalle.RowCount() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            _Flag_edicion = True
            _Codigo_Ini = String.Empty
            _Codigo_Ini = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            CONTROLES(True, 1)
            blank()
            btn_menu.Enabled = False
            For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & _Codigo_Ini)
                txtcodigoArticulo.Text = item("PART_ID")
                txtdescripcionArticulo.Text = item("PART_DESCRIPTION")
                txtunidadMedida.Text = item("UNIT")
                txtcantidad.Text = CDbl(item("QTY"))
                txt_n_analisis.Text = item("N_ANALISIS")
            Next
            'pnl_stock.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        Try
            If dgvDetalle.RowCount() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            If System.Windows.Forms.MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
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

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos()
    End Sub

    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_ARTICULO_I"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = "XX"
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txtcantidad.Select()
            End If
            frm.Close()
            'pnl_stock.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            Dim dtDocumentoGuias As New DataTable
            dtDocumentoGuias = clsArticuloBl.VerificacionArticuloCodigo(_codigoArticulo, "")
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("ID").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPTION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNIT_OF_MEASUREMENT").ToString
                txtcantidad.Select()
            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Exclamation)
                txtcodigoArticulo.Text = String.Empty
                txtdescripcionArticulo.Text = String.Empty
                txtunidadMedida.Text = String.Empty
                txtcodigoArticulo.Select()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_n_analisis.Focus()
        End If
    End Sub

    Private Sub MostrandoAnalisis()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRAS_SP_S_N_ANALISIS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txtcodigoArticulo.Text
            frm.Titulo = "Seleccion de N° de Análisis"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_n_analisis.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                btn_aceptar.Select()
            End If
            frm.Close()
            'pnl_stock.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_lote_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_lote.KeyDown
        If e.KeyCode = Keys.F1 Then
            Mostrando_Lotes()
        ElseIf e.KeyCode = Keys.Enter Then
            If txt_lote.Text = String.Empty Then
                Mostrando_Lotes()
            Else
                txtcomentario.Focus()
            End If
        End If
    End Sub

    Private Sub txtsolicitante_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsolicitante.KeyDown
        If e.KeyCode = Keys.F1 Then
            mostrandoAlmacen()
        ElseIf e.KeyCode = Keys.Enter Then
            If txtsolicitante.Text = String.Empty Then
                mostrandoAlmacen()
            Else
                txt_cod_producto.Focus()
            End If
        End If
    End Sub

    Private Sub txt_n_analisis_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_n_analisis.MouseDoubleClick
        'MostrandoAnalisis()
    End Sub

    Private Sub txt_n_analisis_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_n_analisis.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_aceptar.Select()
        End If
    End Sub

    Private Sub txtcomentario_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtcomentario.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnAgregar.Select()
        ElseIf e.KeyCode = Keys.Enter Then
            btnAgregar.Select()
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try

            If dgvDetalle.RowCount() = 0 Then
                MsgBox("Debe agregar al menos 1 item en el detalle.", MsgBoxStyle.Critical, "Aviso")
                Exit Sub
            End If

            Dim MSJ As String = ""
            Dim MSJ_RES As String = ""
            If Modo_consultar = True Then
                MSJ = "¿Desea Modificar Guia de Devolución.?"
                MSJ_RES = "Actualizado Exitosamente."
            Else
                MSJ = "¿Desea Generar la Guia de Devolución?"
                MSJ_RES = "Guardado Exitosamente."
            End If
            If System.Windows.Forms.MessageBox.Show(MSJ, "Sistemas", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                If GuardarModificarRequisiciones() = True Then
                    MsgBox(MSJ_RES, MsgBoxStyle.Information)
                Else
                    Me.Cursor = Cursors.Default
                    MsgBox("No se genero ningun documento.", MsgBoxStyle.Critical, "Aviso")
                End If
                DocumentosRequisiones()
                btnCancelar_Click(sender, e)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function GuardarModificarRequisiciones() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            Dim cabeceraBL As New ClsOperaciones.REQUIREMENT
            Dim cabeceraBE As New ClsEntidades.GUIA_DEVOLUCION
            Dim ls_det As New List(Of ClsEntidades.GUIA_DEVOLUCION_LINE)
            Dim detalle As New ClsEntidades.GUIA_DEVOLUCION_LINE

            With cabeceraBE
                .TYPE = txttipoDoc.Text
                If Modo_consultar = True Then
                    .ID = txtcodigo.Text
                    .STATUS = txtestado.Text
                Else
                    .ID = Numeracion()
                    .STATUS = "P"
                End If
                .REQUIRED_USER = txtsolicitante.Text
                .REQUIRED_DATE = dtpFechad.Value
                .COMMENT = txtcomentario.Text
                .AREA_ID = txtarea.Text
                .CREATE_DATE = Date.Now
                .UPDATE_DATE = Date.Now
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .PROJECT_ID = ""
                .RESP_COMPRAS = ""
                .PART_ID = txt_cod_producto.Text
                .PART_DESCRIPTION = txt_des_producto.Text
                .LOTE = txt_lote.Text
                .VCTO_LOTE = txt_vcto_lote.Text
                If txt_cantidad.Text = "" Then
                    .CANTIDAD = 0
                Else
                    .CANTIDAD = CDbl(txt_cantidad.Text)
                End If
                .NUMERO_OP = txt_numero_op.Text
            End With

            'Detalle de Factura
            For i As Integer = 0 To dtdetallePrincipal.Rows.Count() - 1
                detalle = New ClsEntidades.GUIA_DEVOLUCION_LINE
                With detalle
                    .ID = cabeceraBE.ID
                    .TYPE = txttipoDoc.Text
                    .ITEM = dtdetallePrincipal.Rows(i).Item("ITEM")
                    .PART_ID = dtdetallePrincipal.Rows(i).Item("PART_ID")
                    .PART_DESCRIPTION = dtdetallePrincipal.Rows(i).Item("PART_DESCRIPTION")
                    .UNIT = dtdetallePrincipal.Rows(i).Item("UNIT")
                    .QTY = dtdetallePrincipal.Rows(i).Item("QTY")
                    .STATUS = "P"
                    .DOCUMENT_DATE = dtpFechad.Value
                    .N_ANALISIS = dtdetallePrincipal.Rows(i).Item("N_ANALISIS")

                    If String.IsNullOrEmpty(dtdetallePrincipal.Rows(i).Item("COD_PRIORIDAD").ToString) Then
                        .COD_PRIORIDAD = "0"
                    Else
                        If dtdetallePrincipal.Rows(i).Item("COD_PRIORIDAD") = "Urgente" Then
                            .COD_PRIORIDAD = "1"
                        End If
                    End If
                End With
                ls_det.Add(detalle)
            Next
            ''GUARDANDO DATOS DE LA FACTURACION
            If Modo_consultar = True Then
                If cabeceraBL.Actualizar_Guia_Devolucion(cabeceraBE, ls_det) = False Then
                    MsgBox("Hubo un Error en la Actualizacion de la Guia de Salida Indirecta", MsgBoxStyle.Critical)
                    indicadorF = False
                    Exit Try
                End If
            Else
                If cabeceraBL.Guardar_Guia_Devolucion(cabeceraBE, ls_det) = False Then
                    MsgBox("Hubo un Error en la Generacion de la Guia de Salida Indirecta", MsgBoxStyle.Critical)
                    indicadorF = False
                    Exit Try
                End If
            End If
            If MessageBox.Show("¿Desea imprimir el documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                imprimirRequisicion("GD", cabeceraBE.ID)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            indicadorF = False
        End Try
        Return indicadorF
    End Function

    Private Sub imprimirRequisicion(ByVal tipo As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable

            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporte_Guia_Devolucion(tipo, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Almacen_Guia_Devolucion.rpt", dtImprimir, "", "", "@TYPE;" & tipo, "@ID;" & numerodocument)
            Else
                MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        limpiar()
        GbCabecera.Enabled = False
        gbOpciones.Enabled = True
        btn_autorizar.Visible = False
        btn_finalizar.Visible = False
    End Sub

    Private Sub cbo_estado_atencion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_estado_atencion.SelectedIndexChanged
        If _var_inicio = True Then
            txtFiltro.Text = String.Empty
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub cboareas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboareas.SelectedIndexChanged
        If _var_inicio = True Then
            txtFiltro.Text = String.Empty
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim _CODIGO_REQUES As String = dgvCabecera.CurrentRow.Cells("Codigo").Value

        If dgvCabecera.CurrentRow.Cells("Estado").Value = "ANULADO" Then
            MsgBox("La Guia de Devolución esta anulada, no se puede imprimir.", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            imprimirRequisicion("GD", _CODIGO_REQUES)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            If dgvCabecera.RowCount() = 0 Then Exit Sub
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            Dim estadoInicial As String = ""
            estadoInicial = dgvCabecera.CurrentRow.Cells("STATUS").Value
            If estadoInicial = "A" Then
                MsgBox("La Guia de Salida de Devolución ya se encuentra ANULADO.", MsgBoxStyle.Critical)
                Exit Sub
                'ElseIf estadoInicial = "AU" Then
                '    MsgBox("La Guia de Salida Indirecta ya se encuentra AUTORIZADO.", MsgBoxStyle.Critical)
                '    Exit Sub
            End If

            If MessageBox.Show("¿Desea anular el documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsRequisionesBl = New ClsOperaciones.REQUIREMENT
                Dim _CODIGO_REQUES As String = dgvCabecera.CurrentRow.Cells("Codigo").Value
                If clsRequisionesBl.Anular_Guia_Devolucion(_CODIGO_REQUES, "GD") = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de anulación", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    MsgBox("Guia de Salida de Devolución anulado correctamente.", MsgBoxStyle.Information)
                    DocumentosRequisiones()
                    btnCancelar_Click(sender, e)
                    Me.Cursor = Cursors.Default
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_autorizar_Click(sender As Object, e As EventArgs) Handles btn_autorizar.Click
        Try

            If dgvCabecera.RowCount() = 0 Then Exit Sub
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            Dim estadoInicial As String = ""
            estadoInicial = dgvCabecera.CurrentRow.Cells("STATUS").Value
            If estadoInicial = "A" Then
                MsgBox("La Guia de Salida de Devolución ya se encuentra anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MessageBox.Show("¿Desea autorizar la Guia de Devolución?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsRequisionesBl = New ClsOperaciones.REQUIREMENT
                Dim _CODIGO_REQUES As String = dgvCabecera.CurrentRow.Cells("Codigo").Value
                If clsRequisionesBl.Autorizar_Guia_Devolucion(_CODIGO_REQUES, "GD") = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de autorización", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    MsgBox("Guia de Salida de Devolución AUTORIZADO correctamente.", MsgBoxStyle.Information)
                    DocumentosRequisiones()
                    btnCancelar_Click(sender, e)
                    Me.Cursor = Cursors.Default
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        Try

            If dgvCabecera.RowCount() = 0 Then Exit Sub
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            Dim estadoInicial As String = ""
            estadoInicial = dgvCabecera.CurrentRow.Cells("STATUS").Value
            If estadoInicial = "A" Then
                MsgBox("La Guia de Devolución ya se encuentra anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MessageBox.Show("¿Desea finalizar la Guia de Devolución?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsRequisionesBl = New ClsOperaciones.REQUIREMENT
                Dim _CODIGO_REQUES As String = dgvCabecera.CurrentRow.Cells("Codigo").Value
                If clsRequisionesBl.Finalizar_Guia_Salida_Indirecta(_CODIGO_REQUES, "GD") = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de finalización", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    MsgBox("Guia de Salida de Devolución FINALIZADO correctamente.", MsgBoxStyle.Information)
                    DocumentosRequisiones()
                    btnCancelar_Click(sender, e)
                    Me.Cursor = Cursors.Default
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        Modo_consultar = True
        limpiar()

        clsRequisionesBl = New ClsOperaciones.REQUIREMENT
        Dim dt_verificar As DataTable
        dt_verificar = New DataTable

        dt_verificar = clsRequisionesBl.Datos_Guia_Devolucion_Consulta_Cabecera(dgvCabecera.CurrentRow.Cells("Tipo").Value, dgvCabecera.CurrentRow.Cells("Codigo").Value)
        If dt_verificar.Rows.Count > 0 Then
            estado = dt_verificar.Rows(0).Item("Estado").ToString
            estado_atencion = dt_verificar.Rows(0).Item("ESTADO_ATENCION").ToString
        Else
            estado = "EMITIDO"
            estado_atencion = ""
        End If

        'If estado = "AUTORIZADO" Then
        '    btn_autorizar.Visible = False
        'ElseIf estado = "ANULADO" Then
        '    btn_autorizar.Visible = False
        'Else
        '    If LibComunVar.ClsVarComun.AUTORIZA_GD = "S" Then
        '        btn_autorizar.Visible = True
        '    Else
        '        btn_autorizar.Visible = False
        '    End If
        'End If
        btn_autorizar.Visible = False

        If estado_atencion = "03" Or estado_atencion = "04" Then
            btn_finalizar.Visible = True
        ElseIf estado = "ANULADO" Then
            btn_finalizar.Visible = False
        End If

        btnGrabar.Enabled = False
        gbOpciones.Enabled = False

        GbCabecera.Enabled = True
        pnlCabecera.Visible = False
        MostrarModoConsultar()
    End Sub

    Private Sub MostrarModoConsultar()
        Try

            dtCabeceraReq = New DataTable
            dtDetalleReq = New DataTable
            '---Mostrando Datos de Cabecera
            Dim codigo As String = ""
            codigo = dgvCabecera.CurrentRow.Cells("Codigo").Value
            txtcodigo.Text = dgvCabecera.CurrentRow.Cells("Codigo").Value
            txttipoDoc.Text = dgvCabecera.CurrentRow.Cells("Tipo").Value
            txtsolicitante.Text = IIf(String.IsNullOrEmpty(dgvCabecera.CurrentRow.Cells("REQUIRED_USER").Value), "", dgvCabecera.CurrentRow.Cells("REQUIRED_USER").Value)
            txtdescripcion_solicitante.Text = IIf(String.IsNullOrEmpty(dgvCabecera.CurrentRow.Cells("SOLICITANTE").Value), "", dgvCabecera.CurrentRow.Cells("SOLICITANTE").Value)
            txtarea.Text = dgvCabecera.CurrentRow.Cells("AREA_ID").Value
            txtdescripcion_area.Text = dgvCabecera.CurrentRow.Cells("AREA").Value

            txtcomentario.Text = dgvCabecera.CurrentRow.Cells("COMENTARIO").Value
            dtpFechad.Value = dgvCabecera.CurrentRow.Cells("FECHA").Value
            txtestado.Text = dgvCabecera.CurrentRow.Cells("STATUS").Value
            lbl_usuario.Text = dgvCabecera.CurrentRow.Cells("USER_ID").Value

            txt_cod_producto.Text = dgvCabecera.CurrentRow.Cells("PART_ID").Value
            txt_des_producto.Text = dgvCabecera.CurrentRow.Cells("PART_DESCRIPTION").Value
            txt_lote.Text = dgvCabecera.CurrentRow.Cells("LOTE_ID").Value
            txt_vcto_lote.Text = dgvCabecera.CurrentRow.Cells("VCTO_LOTE").Value
            txt_cantidad.Text = dgvCabecera.CurrentRow.Cells("QTY").Value
            txt_numero_op.Text = dgvCabecera.CurrentRow.Cells("NUMERO_OP").Value

            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtdetallePrincipal = clsRequisionesBl.Datos_Guia_Devolucion_Consulta("GD", codigo)
            If dtdetallePrincipal.Rows.Count() <> 0 Then
                configurarGrilla()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtarea.Focus()
        End If
    End Sub

    Private Sub Tc_principal_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Tc_principal.Selecting
        If Not Tc_principal.SelectedTab.Enabled Then
            e.Cancel = True
        End If
    End Sub

    
    Private Sub btn_cierre_manul_Click(sender As Object, e As EventArgs) Handles btn_cierre_manul.Click
        Try

            If dgvCabecera.RowCount() = 0 Then Exit Sub
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            Dim estadoInicial As String = ""
            estadoInicial = dgvCabecera.CurrentRow.Cells("STATUS").Value
            If estadoInicial = "A" Then
                MsgBox("La Guia de Devolución ya se encuentra ANULADO.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            estadoInicial = dgvCabecera.CurrentRow.Cells("ES_MANUAL").Value
            If estadoInicial = "SI" Then
                MsgBox("La Guia de Devolución ya se encuentra Cerrado Manualmente.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MessageBox.Show("¿Desea realizar el Cierre Manual del documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsRequisionesBl = New ClsOperaciones.REQUIREMENT
                Dim _CODIGO_REQUES As String = dgvCabecera.CurrentRow.Cells("Codigo").Value
                If clsRequisionesBl.Cierre_Manual_Guia_Devolucion(_CODIGO_REQUES, "GD") = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Hubo un error, no se completo el Proceso de Cierre Manual", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    MsgBox("Guia de Devolución con Cierre Manual correctamente.", MsgBoxStyle.Information)
                    DocumentosRequisiones()
                    btnCancelar_Click(sender, e)
                    Me.Cursor = Cursors.Default
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_numero_op_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_numero_op.MouseDoubleClick
        Ayuda_OrdenProduccion()
    End Sub

    Private Sub txt_numero_op_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero_op.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_OrdenProduccion()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_numero_op.Text = "" Then
                Ayuda_OrdenProduccion()
            Else
                txtcomentario.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_OrdenProduccion()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_MANTENIMIENTO_OP_BANDEJA_PRE_PRENSA_REQUERIMIENTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Ordenes de Producción"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_numero_op.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GbCabecera_Enter(sender As Object, e As EventArgs) Handles GbCabecera.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class