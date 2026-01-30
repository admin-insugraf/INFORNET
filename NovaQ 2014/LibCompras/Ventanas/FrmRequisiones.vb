Imports LibCompras
Imports LibComunVar
Imports LibCobranzas
'Imports Microsoft.Office.Interop.Outlook
'Imports Microsoft.Office.Interop.OutlookViewCtl

Public Class FrmRequisiones
    Dim Modo_consultar As Boolean = False
    Dim dtdetallePrincipal As DataTable
    Private _tipoMov As String = String.Empty

    Dim clsRequisionesBl As ClsOperaciones.REQUIREMENT
    Dim dtDocumentos As DataTable
    Dim dtv As DataView
    Dim STRorden As String = ""

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


    Public Property TipoMov() As String
        Get
            Return _tipoMov
        End Get
        Set(value As String)
            _tipoMov = value
        End Set
    End Property

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetallePrincipal = New DataTable("Requisiciones")
            dtdetallePrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetallePrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("AMOUNT_BALANCE", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("COMMENT", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("CCOST_ID", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("PROJECT_ID", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("COD_PRIORIDAD", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("ID_VENDOR", Type.GetType("System.String"))
            If Modo_consultar = True And estado <> "EMITIDO" Then
                dtdetallePrincipal.Columns.Add("TIPO_OC", Type.GetType("System.String"))
                dtdetallePrincipal.Columns.Add("NUMERO_OC", Type.GetType("System.String"))
                dtdetallePrincipal.Columns.Add("ESTADO_OC", Type.GetType("System.String"))
            End If
            dtdetallePrincipal.PrimaryKey = New DataColumn() {dtdetallePrincipal.Columns("ITEM")}
            dgvDetalle.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub configurarGrilla()
        dgvDetalle.DataSource = dtdetallePrincipal
        dgvDetalle.AutoResizeColumns()
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        For i As Integer = 7 To dgvDetalle.Columns.Count() - 1
            dgvDetalle.Columns(i).Visible = False
        Next
        dgvDetalle.Columns(5).Visible = False
        dgvDetalle.Columns(9).Visible = True
        dgvDetalle.Columns(10).Visible = True
        
        dgvDetalle.Columns("ITEM").HeaderText = "Item"
        dgvDetalle.Columns("PART_ID").HeaderText = "Codigo"
        dgvDetalle.Columns("PART_DESCRIPTION").HeaderText = "Descripcion"
        dgvDetalle.Columns("UNIT").HeaderText = "Unidad"
        dgvDetalle.Columns("QTY").HeaderText = "Cantidad"
        dgvDetalle.Columns("AMOUNT_BALANCE").HeaderText = "Monto"
        dgvDetalle.Columns("COMMENT").HeaderText = "Comentario"
        dgvDetalle.Columns("COD_PRIORIDAD").HeaderText = "Prioridad"
        dgvDetalle.Columns("ID_VENDOR").HeaderText = "Proveedor"
        If Modo_consultar = True And estado <> "EMITIDO" Then
            dgvDetalle.Columns(11).Visible = True
            dgvDetalle.Columns(12).Visible = True
            dgvDetalle.Columns(13).Visible = True
            dgvDetalle.Columns("TIPO_OC").HeaderText = "Tipo O.C"
            dgvDetalle.Columns("NUMERO_OC").HeaderText = "N° O.C"
            dgvDetalle.Columns("ESTADO_OC").HeaderText = "Estado O.C"
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnGrabar.Enabled = True
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
    End Sub

    Private Sub Nuevo()
        Try
            limpiar()
            'If DetallesRequisicion() = False Then Exit Sub
            configurarGrilla()
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            Modo_consultar = False
            CONTROLES(True, 0)
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
            txttipoDoc.Text = TipoMov
            txtcodigo.Text = Numeracion()
            txtcomentario.Select()
            lbl_usuario.Text = ClsVarComun.USUARIO
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Private Function DetallesRequisicion()
    '    Dim res As Boolean = True
    '    Try
    '        txtarea.Text = ""
    '        txtdescripcion_area.Text = ""
    '        txtsolicitante.Text = ""
    '        txtdescripcion_solicitante.Text = ""
    '        clsRequisionesBl = New ClsOperaciones.REQUIREMENT
    '        Dim dtrequirement As New DataTable
    '        dtrequirement = clsRequisionesBl.DatosUsuario(LibComunVar.ClsVarComun.USUARIO)
    '        If dtrequirement.Rows.Count <> 0 Then
    '            txtarea.Text = dtrequirement.Rows(0).Item("COD_AREA").ToString
    '            txtdescripcion_area.Text = dtrequirement.Rows(0).Item("Area").ToString
    '            txtsolicitante.Text = dtrequirement.Rows(0).Item("COD_PERSONAL").ToString
    '            txtdescripcion_solicitante.Text = dtrequirement.Rows(0).Item("Personal").ToString
    '            If txtarea.Text = "" Or txtsolicitante.Text = "" Then
    '                MsgBox("El usuario no esta permitido para realizar requisiciones.", MsgBoxStyle.Critical)
    '                res = False
    '            End If
    '        Else
    '            MsgBox("El usuario no esta permitido para realizar requisiciones.", MsgBoxStyle.Critical)
    '            res = False
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Return res
    'End Function

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.REQUIREMENT
            CORRELATIVOBL.NumeroCorrelativoRequisicion(TipoMov)
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                Correlativo = String.Format("{0:0000000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function


    Private Sub FrmRequisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        Cargar_Areas()
        cboopcionesBusqueda.SelectedIndex = 0
        Botonera_Estado_Cambiar(False)
        GenerarColummnaDataTable()
    End Sub
    Private Sub Cargar_Areas()
        Try
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtAlmacen = New DataTable
            dtAlmacen = clsRequisionesBl.get_Lista_Areas()
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("ID") = ""
            row.Item("DESCRIPTION") = "Todos"
            dtAlmacen.Rows.InsertAt(row, 0)
            cboareas.DataSource = dtAlmacen
            cboareas.DisplayMember = "DESCRIPTION"
            cboareas.ValueMember = "ID"
            cboareas.SelectedIndex = 0
            clsRequisionesBl = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub DocumentosRequisiones()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtDocumentos = New DataTable
            dtv = New DataView
            dtDocumentos = clsRequisionesBl.get_DatosGeneralesRequisiciones(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                           cboopcionesBusqueda.SelectedIndex, TipoMov, cboareas.SelectedValue.ToString)
            dgvCabecera.DataSource = Nothing
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                For i As Integer = 6 To dgvCabecera.ColumnCount() - 1
                    dgvCabecera.Columns(i).Visible = False
                Next
                dgvCabecera.Columns(8).Visible = True
                dgvCabecera.Columns(4).Visible = False
                STRorden = dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name & "+" & dgvCabecera.Columns(5).Name & "+" & dgvCabecera.Columns(6).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        DocumentosRequisiones()
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
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
                STRorden = dgvCabecera.Columns(3).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns(4).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(5).Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvCabecera.Columns(6).Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name & "+" & dgvCabecera.Columns(5).Name & "+" & dgvCabecera.Columns(6).Name
                                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub Ayuda_Solicitante()
        Try
            If txtarea.Text = "" Then
                MsgBox("Debe seleccionar primero una area.", MsgBoxStyle.Information)
                txtarea.Select()
                Exit Sub
            End If

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_SOLICITANTE"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txtarea.Text
            frm.Titulo = "Lista de solicitante"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtsolicitante.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcion_solicitante.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtsolicitante_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtsolicitante.MouseDoubleClick
        'Ayuda_Solicitante()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "COMPRAS_SP_S_AREA"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de areas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtsolicitante.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txtdescripcion_solicitante.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
    End Sub

    Private Sub txtsolicitante_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsolicitante.KeyDown
        If e.KeyCode = Keys.F1 Then
            'Ayuda_Solicitante()
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_AREA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de areas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtsolicitante.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcion_solicitante.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        End If
    End Sub

    Private Sub txtarea_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarea.MouseDoubleClick
        Ayuda_Area()
    End Sub

    Private Sub txtarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarea.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Area()
        End If
    End Sub

    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_ARTICULO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = TipoMov
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txtcantidad.Select()
            End If
            frm.Close()
            pnl_stock.Visible = False
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
            Dim dtDocumentoGuias As New DataTable
            dtDocumentoGuias = clsArticuloBl.VerificacionArticuloCodigo(_codigoArticulo, TipoMov)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("ID").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPTION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNIT_OF_MEASUREMENT").ToString
                txtcantidad.Select()
            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
                txtcodigoArticulo.Text = String.Empty
                txtdescripcionArticulo.Text = String.Empty
                txtunidadMedida.Text = String.Empty
                txtcodigoArticulo.Select()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_stock_Click(sender As Object, e As EventArgs) Handles btn_stock.Click
        Try
            If txtcodigoArticulo.Text = "" Then Exit Sub
            pnl_stock.Visible = True
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            Dim dtdetalle_part As New DataTable
            dtdetalle_part = clsRequisionesBl.Datos_Stock(txtcodigoArticulo.Text)
            dgv_stock.DataSource = Nothing
            dgv_stock.DataSource = dtdetalle_part
            If dtdetalle_part.Rows.Count() <> 0 Then
                dgv_stock.Columns(0).Width = 50
                dgv_stock.Columns(1).Width = 300
                dgv_stock.Columns(2).Width = 95
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

            If _Flag_edicion = False Then
                Dim row As DataRow = dtdetallePrincipal.NewRow
                row("ITEM") = dtdetallePrincipal.Rows.Count() + 1
                row("PART_ID") = txtcodigoArticulo.Text
                row("PART_DESCRIPTION") = txtdescripcionArticulo.Text
                row("UNIT") = txtunidadMedida.Text
                row("QTY") = txtcantidad.Text
                row("AMOUNT_BALANCE") = 0
                row("CCOST_ID") = ""
                row("COMMENT") = txtobservacion.Text
                row("PROJECT_ID") = ""
                row("COD_PRIORIDAD") = IIf(chk_prioridad.Checked, "Urgente", "")
                row("ID_VENDOR") = txt_proveedor.Text
                dtdetallePrincipal.Rows.Add(row)
                dtdetallePrincipal.AcceptChanges()
                blank()
                txtcodigoArticulo.Select()
            Else
                For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & _Codigo_Ini)
                    dtdetallePrincipal.BeginInit()
                    item("PART_ID") = txtcodigoArticulo.Text
                    item("PART_DESCRIPTION") = txtdescripcionArticulo.Text
                    item("UNIT") = txtunidadMedida.Text
                    item("QTY") = txtcantidad.Text
                    item("COMMENT") = txtobservacion.Text
                    item("COD_PRIORIDAD") = IIf(chk_prioridad.Checked, "Urgente", "")
                    item("ID_VENDOR") = txt_proveedor.Text
                    dtdetallePrincipal.EndInit()
                    dtdetallePrincipal.AcceptChanges()
                    btn_salir_Click(sender, e)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub blank()
        txtcodigoArticulo.Text = ""
        txtdescripcionArticulo.Text = ""
        txtunidadMedida.Text = ""
        txtcantidad.Text = ""
        txtobservacion.Text = ""
        chk_prioridad.Checked = False
        txt_proveedor.Text = ""
    End Sub

    Private Sub CONTROLES(ByVal opcion As Boolean, ByVal _indice As Integer)
        Tc_principal.TabPages(0).Enabled = False
        Tc_principal.TabPages(1).Enabled = False
        Tc_principal.TabPages(_indice).Enabled = opcion
        Tc_principal.SelectTab(_indice)
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            blank()
            If GbCabecera.Enabled = True Then
                If txtsolicitante.Text = "" Then
                    MsgBox("Debe seleccionar un Solicitante.", MsgBoxStyle.Information)
                    txtsolicitante.Select()
                    Exit Sub
                ElseIf txtarea.Text = "" Then
                    MsgBox("Debe seleccionar una area.", MsgBoxStyle.Information)
                    txtarea.Select()
                    Exit Sub
                End If
                GbCabecera.Enabled = False
            End If
            _Flag_edicion = False
            CONTROLES(True, 1)
            btn_menu.Enabled = False
            pnl_stock.Visible = False
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
                txtobservacion.Text = item("COMMENT")

                If String.IsNullOrEmpty(item("COD_PRIORIDAD")) Then
                    chk_prioridad.Checked = False
                Else
                    If item("COD_PRIORIDAD") = "Urgente" Then
                        chk_prioridad.Checked = True
                    ElseIf item("COD_PRIORIDAD") = "" Then
                        chk_prioridad.Checked = False
                    End If
                End If
                txt_proveedor.Text = IIf(String.IsNullOrEmpty(item("ID_VENDOR").ToString), "", item("ID_VENDOR").ToString)
            Next
            pnl_stock.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        Try
            If dgvDetalle.RowCount() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
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

    Private Sub Tc_principal_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Tc_principal.Selecting
        If Not Tc_principal.SelectedTab.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        limpiar()
        GbCabecera.Enabled = False
        gbOpciones.Enabled = True
        ' DocumentosRequisiones()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalle.RowCount() = 0 Then Exit Sub
        If txtcomentario.Text = "" Then
            MsgBox("Es necesario agregar una descripcion para la requisicion.", MsgBoxStyle.Information)
            txtcomentario.Select()
            Exit Sub
        End If

        If Verificar_Apertura_Cierre_Modulos(dtpFechad.Value.Month, dtpFechad.Value.Year) = False Then
            Exit Sub
        End If

        Dim MSJ As String = ""
        Dim MSJ_RES As String = ""
        If Modo_consultar = True Then
            MSJ = "¿Desea Modificar la Requisicion.?"
            MSJ_RES = "Actualizado Exitosamente."
        Else
            MSJ = "¿Desea Generar la Requisicion.?"
            MSJ_RES = "Guardado Exitosamente."
        End If
        If MessageBox.Show(MSJ, "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If GuardarModificarRequisiciones() = True Then
                MsgBox(MSJ_RES, MsgBoxStyle.Information)
            Else
                MsgBox("No se genero ningun documento.", MsgBoxStyle.Critical, "Aviso")
            End If
            btnCancelar_Click(sender, e)
        End If
    End Sub

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
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar la Requisición.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Function GuardarModificarRequisiciones() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            Dim cabeceraBL As New ClsOperaciones.REQUIREMENT
            Dim cabeceraBE As New ClsEntidades.REQUIREMENT
            Dim ls_det As New List(Of ClsEntidades.REQUIREMENT_LINE)
            Dim detalle As New ClsEntidades.REQUIREMENT_LINE

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
            End With

            'Detalle de Factura
            For i As Integer = 0 To dtdetallePrincipal.Rows.Count() - 1
                detalle = New ClsEntidades.REQUIREMENT_LINE
                With detalle
                    .ID = cabeceraBE.ID
                    .TYPE = TipoMov
                    .ITEM = dtdetallePrincipal.Rows(i).Item("ITEM")
                    .PART_ID = dtdetallePrincipal.Rows(i).Item("PART_ID")
                    .PART_DESCRIPTION = dtdetallePrincipal.Rows(i).Item("PART_DESCRIPTION")
                    .UNIT = dtdetallePrincipal.Rows(i).Item("UNIT")
                    .QTY = dtdetallePrincipal.Rows(i).Item("QTY")
                    .STATUS = "P"
                    .DOCUMENT_DATE = dtpFechad.Value
                    .AMOUNT_BALANCE = dtdetallePrincipal.Rows(i).Item("AMOUNT_BALANCE")
                    .CCOST_ID = dtdetallePrincipal.Rows(i).Item("CCOST_ID")
                    .COMMENT = dtdetallePrincipal.Rows(i).Item("COMMENT")
                    .PROJECT_ID = dtdetallePrincipal.Rows(i).Item("PROJECT_ID")

                    If String.IsNullOrEmpty(dtdetallePrincipal.Rows(i).Item("COD_PRIORIDAD").ToString) Then
                        .COD_PRIORIDAD = "0"
                    Else
                        If dtdetallePrincipal.Rows(i).Item("COD_PRIORIDAD") = "Urgente" Then
                            .COD_PRIORIDAD = "1"
                        End If
                    End If
                    .ID_VENDOR = dtdetallePrincipal.Rows(i).Item("ID_VENDOR").ToString
                End With
                ls_det.Add(detalle)
            Next
            ''GUARDANDO DATOS DE LA FACTURACION
            If Modo_consultar = True Then
                If cabeceraBL.ActualizarRequisiciones(cabeceraBE, ls_det) = False Then
                    MsgBox("Hubo un Error en la Actualizacion de la devolucion", MsgBoxStyle.Critical)
                    indicadorF = False
                    Exit Try
                End If
            Else
                If cabeceraBL.GuardarRequerimientos(cabeceraBE, ls_det) = False Then
                    MsgBox("Hubo un Error en la Generacion de la devolucion", MsgBoxStyle.Critical)
                    indicadorF = False
                    Exit Try
                End If
            End If
            If MessageBox.Show("¿Desea imprimir el documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                imprimirRequisicion(TipoMov, cabeceraBE.ID)
            End If
            EnviarMail(cabeceraBE.ID, TipoMov)
        Catch ex As Exception
            MsgBox(ex.Message)
            indicadorF = False
        End Try
        Return indicadorF
    End Function


    Private Sub EnviarMail(ByVal Numerodoc As String, ByVal _Tipodoc As String)
        Try
            Dim envio_mail As New LibManufactura.FrmEnvioEmail
            envio_mail._document_id = _Tipodoc
            envio_mail._number_document = Numerodoc
            envio_mail._codigo_datos_email = "02"
            envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
            envio_mail.ShowDialog()
            envio_mail.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'If dgvCabecera.RowCount() = 0 Then Exit Sub
            'If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            'If MessageBox.Show("¿Desea Eliminar el Documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '    Me.Cursor = Cursors.WaitCursor
            '    clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            '    Dim _CODIGO_REQUES As String = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
            '    If clsRequisionesBl.EliminacionRequisicion(TipoMov, _CODIGO_REQUES) = False Then
            '        MsgBox("Hubo un error, no se completo el Proceso de Eliminacion", MsgBoxStyle.Information)
            '        Exit Sub
            '    End If
            '    Me.Cursor = Cursors.Default
            '    btnCancelar_Click(sender, e)
            'End If

            If dgvCabecera.RowCount() = 0 Then Exit Sub
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            Dim estadoInicial As String = ""
            estadoInicial = dgvCabecera.Item(13, dgvCabecera.CurrentRow.Index).Value
            If estadoInicial = "A" Then
                MsgBox("El documento ya se encuentra anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If estadoInicial = "O" Then
                MsgBox("El documento ya se encuentra anexado a una Orden de compra no se puede anular.", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf estadoInicial = "SC" Or estadoInicial = "AC" Then
                MsgBox("El documento ya se encuentra anexado a una Cotización no se puede anular.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MessageBox.Show("¿Desea anular el documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsRequisionesBl = New ClsOperaciones.REQUIREMENT
                Dim _CODIGO_REQUES As String = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
                If clsRequisionesBl.Anular_Requisicion(_CODIGO_REQUES, TipoMov) = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de anulacion", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Me.Cursor = Cursors.Default
                btnCancelar_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        Modo_consultar = True
        limpiar()

        estado = dgvCabecera.Item(8, dgvCabecera.CurrentRow.Index).Value

        If estado = "EMITIDO" Then
            gbOpciones.Enabled = True
        Else
            btnGrabar.Enabled = False
            gbOpciones.Enabled = False
        End If
        pnlCabecera.Visible = False
        MostrarModoConsultar()
    End Sub


    Private Sub MostrarModoConsultar()
        Try

            dtCabeceraReq = New DataTable
            dtDetalleReq = New DataTable
            '---Mostrando Datos de Cabecera
            Dim codigo As String = ""
            codigo = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
            txtcodigo.Text = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
            txttipoDoc.Text = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            txtsolicitante.Text = IIf(String.IsNullOrEmpty(dgvCabecera.Item(6, dgvCabecera.CurrentRow.Index).Value.ToString), "", dgvCabecera.Item(6, dgvCabecera.CurrentRow.Index).Value)
            txtdescripcion_solicitante.Text = IIf(String.IsNullOrEmpty(dgvCabecera.Item(4, dgvCabecera.CurrentRow.Index).Value.ToString), "", dgvCabecera.Item(4, dgvCabecera.CurrentRow.Index).Value)
            txtarea.Text = dgvCabecera.Item(7, dgvCabecera.CurrentRow.Index).Value
            txtdescripcion_area.Text = dgvCabecera.Item(3, dgvCabecera.CurrentRow.Index).Value

            txtcomentario.Text = dgvCabecera.Item(5, dgvCabecera.CurrentRow.Index).Value
            dtpFechad.Value = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value
            txtestado.Text = dgvCabecera.Item(13, dgvCabecera.CurrentRow.Index).Value
            lbl_usuario.Text = dgvCabecera.Item(11, dgvCabecera.CurrentRow.Index).Value
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            'GenerarColummnaDataTable()
            If Modo_consultar = True And estado <> "EMITIDO" Then
                dtdetallePrincipal = clsRequisionesBl.DatosRequisicionDetalleModoEdicion_OC(TipoMov, codigo)
            Else
                dtdetallePrincipal = clsRequisionesBl.DatosRequisicionDetalleModoEdicion(TipoMov, codigo)
            End If
            If dtdetallePrincipal.Rows.Count() <> 0 Then
                configurarGrilla()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub imprimirRequisicion(ByVal tipo As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable

            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteRequisiciones(tipo, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Compras_requisiciones.rpt", "", "", "", "@TYPE;" & tipo, "@ID;" & numerodocument)
            Else
                MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim _CODIGO_REQUES As String = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        imprimirRequisicion(TipoMov, _CODIGO_REQUES)
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    'If gb_botonera.Width < 77 Then
    '    '    gb_botonera.Width = gb_botonera.Width + 1
    '    'ElseIf gb_botonera.Width = 77 Then
    '    '    Timer1.Enabled = False
    '    'End If
    'End Sub

    'Private Sub btnNuevo_MouseEnter(sender As Object, e As EventArgs) Handles btnSalir.MouseEnter, btnNuevo.MouseEnter, btnImprimir.MouseEnter, btnGrabar.MouseEnter, btnEliminar.MouseEnter, btnConsultar.MouseEnter, btnCancelar.MouseEnter
    '    Timer1.Enabled = True
    'End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    '    If gb_botonera.Width > 10 Then
    '        gb_botonera.Width = gb_botonera.Width - 1
    '    ElseIf gb_botonera.Width = 10 Then
    '        Timer2.Enabled = False
    '    End If
    'End Sub

    'Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnSalir.MouseLeave, btnNuevo.MouseLeave, btnImprimir.MouseLeave, btnGrabar.MouseLeave, btnEliminar.MouseLeave, btnConsultar.MouseLeave, btnCancelar.MouseLeave
    '    Timer1.Enabled = False
    '    Timer2.Enabled = True
    'End Sub


    Private Sub dtpFechad_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcomentario.Select()
        End If
    End Sub

    Private Sub txtsolicitante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsolicitante.KeyPress, txtdescripcion_solicitante.KeyPress, txtdescripcion_area.KeyPress, txtarea.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtobservacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobservacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_aceptar_Click(sender, e)
        End If
    End Sub

    Private Sub chk_prioridad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chk_prioridad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub


    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub
 
 
    Private Sub txtcomentario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcomentario.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregar_Click(sender, e)
        End If
    End Sub

    Private Sub dgvCabecera_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvCabecera.MouseDoubleClick
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        Modo_consultar = True
        limpiar()
        Dim estado As String = dgvCabecera.Item(8, dgvCabecera.CurrentRow.Index).Value
        If estado = "EMITIDO" Then
            gbOpciones.Enabled = True
        Else
            gbOpciones.Enabled = False
        End If
        pnlCabecera.Visible = False
        MostrarModoConsultar()
    End Sub


    Private Sub Ayuda_Proveedor()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_REQUI_PROVEEDORES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Proveedores"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_proveedor.Text = frm.Data_Matriz.Rows(0).Item(0).ToString & " : " & frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Unidad_Medida()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_UNIDAD_MEDIDA"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTADO DE UNIDADES DE MEDIDA"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proveedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Proveedor()
        End If
    End Sub

    Private Sub txt_proveedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_proveedor.MouseDoubleClick
        Ayuda_Proveedor()
    End Sub

    Private Sub txtunidadMedida_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtunidadMedida.MouseDoubleClick
        Ayuda_Unidad_Medida()
    End Sub

    Private Sub txtunidadMedida_KeyDown(sender As Object, e As KeyEventArgs) Handles txtunidadMedida.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Unidad_Medida()
        End If
    End Sub

    Private Sub cboareas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboareas.SelectedIndexChanged
        txtFiltro.Text = String.Empty
        DocumentosRequisiones()
    End Sub
End Class