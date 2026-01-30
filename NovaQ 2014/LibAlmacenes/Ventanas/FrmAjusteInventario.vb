Imports LibCobranzas
Imports System.Windows.Forms

Public Class FrmAjusteInventario

    Dim almacenBL As ClsOperaciones.WAREHOUSE
    Dim dtAlmacen As DataTable

    Dim dtdetalleAjustes As DataTable
    Dim ListaArticulos As List(Of String)

    Dim clsInventarioEnt As ClsEntidades.INVENTORY_COUNT
    Dim clsInventarioDetEnt As ClsEntidades.INVENTORY_COUNT_LINE
    Dim clsInventarioBl As ClsOperaciones.INVENTORY_COUNT

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimirPlantillas As DataTable
    Dim dtImprimirAnalisis As DataTable
 
    Dim dtImprimir As DataTable
    Dim clsAlmacenCorrelativoBl As ClsTransacciones.clsAlmacenCorrelativo

    Dim Flag_modo_edicion As Boolean = False
    Dim Flag_Ajuste As Boolean = False

    Dim clsFamiliasBl As ClsOperaciones.FAMILY
    Dim dtFamilia As DataTable

    Dim clsTipoProductoBl As ClsOperaciones.PART_TYPE
    Dim dtTipoProducto As DataTable

    Dim clsLineasBl As ClsOperaciones.LINES
    Dim dtLineas As DataTable
    Dim _almacen_ingreso As String
    Dim _tipo_doc_ingreso As String
    Dim _numero_doc_ingreso As String


    Private Sub DocumentosPrincipal()
        Try
            clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
            Dim dtCabecera As New DataTable
            dtCabecera = clsInventarioBl.DocumentosInventarios()
            dgvCabecera.DataSource = Nothing
            If dtCabecera.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtCabecera
                dgvCabecera.Columns(0).HeaderText = "N° de Inventario"
                dgvCabecera.Columns(1).HeaderText = "Fecha de Inventario"
                'dgvCabecera.Columns(2).HeaderText = "Cod. Almacen"
                dgvCabecera.Columns(3).HeaderText = "Almacen"
                dgvCabecera.Columns(4).HeaderText = "Estado de Inventario"
                dgvCabecera.Columns(5).HeaderText = "Observaciones de Inventario"

                dgvCabecera.Columns(0).Width = 150
                dgvCabecera.Columns(1).Width = 100
                dgvCabecera.Columns(3).Width = 250
                dgvCabecera.Columns(2).Visible = False
                dgvCabecera.Columns(4).Width = 150
                dgvCabecera.Columns(5).Width = 200
                
                'dgvCabecera.Columns(5).Visible = False
            Else
                '  MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Botonera_Estado_Inicio(frm As Form)
        frm.Controls("btn_Nuevo").Enabled = True
        frm.Controls("btn_grabar").Enabled = False
        frm.Controls("btn_ajuste_inventario").Enabled = False
        frm.Controls("btn_Editar").Enabled = True
        frm.Controls("btn_cancelar").Enabled = False
        frm.Controls("btnImprimir").Enabled = True
        frm.Controls("btn_Imprimir_Analisis").Enabled = True
        frm.Controls("btn_eliminar").Enabled = False
        frm.Controls("btn_salir").Enabled = True
    End Sub

    Public Sub Botonera_Estado_Cambiar(frm As Form)
        frm.Controls("btn_Nuevo").Enabled = Not frm.Controls("btn_Nuevo").Enabled
        frm.Controls("btn_grabar").Enabled = Not frm.Controls("btn_grabar").Enabled
        frm.Controls("btn_ajuste_inventario").Enabled = Not frm.Controls("btn_ajuste_inventario").Enabled
        frm.Controls("btn_Editar").Enabled = Not frm.Controls("btn_Editar").Enabled
        frm.Controls("btn_cancelar").Enabled = Not frm.Controls("btn_cancelar").Enabled
        frm.Controls("btnImprimir").Enabled = Not frm.Controls("btnImprimir").Enabled
        frm.Controls("btn_Imprimir_Analisis").Enabled = Not frm.Controls("btn_Imprimir_Analisis").Enabled
        frm.Controls("btn_eliminar").Enabled = Not frm.Controls("btn_eliminar").Enabled
        frm.Controls("btn_salir").Enabled = Not frm.Controls("btn_salir").Enabled
    End Sub

    Private Sub EliminarDetalle()
        Try
            clsInventarioDetEnt = New ClsEntidades.INVENTORY_COUNT_LINE
            clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
            With clsInventarioDetEnt
                .ID = txtCodigoInventario.Text
                .WAREHOUSE_ID = dgvdetalle.Item(2, dgvdetalle.CurrentRow.Index).Value.ToString
                .FAMILY_ID = dgvdetalle.Item(2, dgvdetalle.CurrentRow.Index).Value.ToString
                .PART_ID = dgvdetalle.Item(0, dgvdetalle.CurrentRow.Index).Value.ToString
            End With
            GenerarColummnaDataTable()
            dtdetalleAjustes = clsInventarioBl.Eliminar_DetalleInventario(clsInventarioDetEnt)
            ConfigurarGrilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function GuardarModificarDetalle() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            clsInventarioDetEnt = New ClsEntidades.INVENTORY_COUNT_LINE
            clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
            With clsInventarioDetEnt
                .ID = txtCodigoInventario.Text
                .WAREHOUSE_ID = cbo_almacen_adicional.SelectedValue.ToString
                .FAMILY_ID = txtLote.Text
                .PART_ID = txtArticulo.Text
                .STOCK = IIf(txtcantidadLote.Text = String.Empty, 0, txtcantidadLote.Text)
                .ENTER_QTY = CDbl(txtcantidadConteo.Text)
                .DIF_QTY = CDbl(Val(txtcantidadConteo.Text) - Val(IIf(txtcantidadLote.Text = String.Empty, 0, txtcantidadLote.Text)))
                .UBICATION = ""
            End With
            GenerarColummnaDataTable()
            dtdetalleAjustes = clsInventarioBl.Guardar_Actualizar_DetalleInventario(clsInventarioDetEnt)
            ConfigurarGrilla()
            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Private Function Correlativo() As String
        clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
        Dim dtCorrelativo As New DataTable
        Dim _correlativo As String = String.Empty
        dtCorrelativo = clsInventarioBl.CorrelativoInventario(CboAlmacen.SelectedValue.ToString)
        _correlativo = IIf(String.IsNullOrEmpty(dtCorrelativo.Rows(0).Item(0).ToString), 0, dtCorrelativo.Rows(0).Item(0).ToString)
        _correlativo = _correlativo + 1
        _correlativo = _correlativo.PadLeft(6, Char.Parse("0"))
        Return _correlativo
    End Function


    Private Sub GuardarCabecera()
        Try
            clsInventarioEnt = New ClsEntidades.INVENTORY_COUNT
            clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
            With clsInventarioEnt
                .ID = Correlativo()
                .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                .FECHA = dtpFecha.Value.ToShortDateString
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .TERMINAL = Environment.MachineName
                .COMMENT = txtComentarios.Text
                .STATUS = "C"
                .CONDITION = 0
                .ORDER_ID = 0
            End With
            clsInventarioBl.GuardarCabeceraInventario(clsInventarioEnt)
            txtCodigoInventario.Text = clsInventarioEnt.ID
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrilla()
        'If CboAlmacen.SelectedValue.ToString = "01" Then
        '    dtdetalleAjustes.DefaultView.RowFilter = "STOCK<>0"
        ' '    dtdetalleAjustes.DefaultView.Sort = "AD_SECUENCIA ASC"
        'End If
        dgvdetalle.DataSource = Nothing
        dgvdetalle.DataSource = dtdetalleAjustes
        For i As Integer = 0 To dtdetalleAjustes.Columns.Count() - 1
            dgvdetalle.Columns(i).Visible = True
            dgvdetalle.Columns(i).ReadOnly = True
        Next
        dgvdetalle.AutoResizeColumns()
        dgvdetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgvdetalle.Columns(0).Width = 60
        'dgvdetalle.Columns(1).Width = 400
        'dgvdetalle.Columns(2).Width = 100
        'dgvdetalle.Columns(3).Width = 50
        'dgvdetalle.Columns(4).Width = 300
        dgvdetalle.Columns(6).ReadOnly = False
        dgvdetalle.Columns(2).Visible = False
        dgvdetalle.Columns(3).Visible = False
        dgvdetalle.Columns(7).Visible = False
        dgvdetalle.Columns(5).Visible = False
        dgvdetalle.Columns(6).DefaultCellStyle.Format = "N0"
        dgvdetalle.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvdetalle.Columns(0).HeaderText = "Codigo"
        dgvdetalle.Columns(1).HeaderText = "Descripcion"
        dgvdetalle.Columns(2).HeaderText = "Lote"
        'dgvdetalle.Columns(3).HeaderText = "Cod. Alm."
        dgvdetalle.Columns(4).HeaderText = "Almacen"
        dgvdetalle.Columns(6).HeaderText = "Conteo"
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleAjustes = New DataTable
            dtdetalleAjustes.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleAjustes.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleAjustes.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleAjustes.Columns.Add("COD_ALMACEN", Type.GetType("System.String"))
            dtdetalleAjustes.Columns.Add("ALMACEN", Type.GetType("System.String"))
            dtdetalleAjustes.Columns.Add("STOCK", Type.GetType("System.Double"))
            dtdetalleAjustes.Columns.Add("CANT_ING", Type.GetType("System.Double"))
            dtdetalleAjustes.Columns.Add("CANT_DIF", Type.GetType("System.Double"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Almacen()
        Try
            almacenBL = New ClsOperaciones.WAREHOUSE
            dtAlmacen = New DataTable
            dtAlmacen = almacenBL.get_Almacenes_Ayuda(LibComunVar.ClsVarComun.AccesoAlmacenes)
            CboAlmacen.DataSource = Nothing
            CboAlmacen.Items.Clear()

            cbo_almacen_adicional.DataSource = Nothing
            cbo_almacen_adicional.Items.Clear()

            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(-SELECCIONE-)"
            dtAlmacen.Rows.InsertAt(row, 0)
            CboAlmacen.DisplayMember = "DESCRIPCION"
            CboAlmacen.ValueMember = "CODIGO"
            CboAlmacen.DataSource = dtAlmacen

            cbo_almacen_adicional.DisplayMember = "DESCRIPCION"
            cbo_almacen_adicional.ValueMember = "CODIGO"
            cbo_almacen_adicional.DataSource = dtAlmacen

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Almacen_Ajuste()
        Try
            almacenBL = New ClsOperaciones.WAREHOUSE
            dtAlmacen = New DataTable
            dtAlmacen = almacenBL.get_Almacenes_Ajuste_Inventario(txtCodigoInventario.Text)

            cbo_almacen_ajuste.DataSource = Nothing
            cbo_almacen_ajuste.Items.Clear()

            Dim row As DataRow = dtAlmacen.NewRow()
            'row.Item("CODIGO") = ""
            'row.Item("DESCRIPCION") = "(-SELECCIONE-)"
            'dtAlmacen.Rows.InsertAt(row, 0)
            cbo_almacen_ajuste.DisplayMember = "DESCRIPCION"
            cbo_almacen_ajuste.ValueMember = "CODIGO"
            cbo_almacen_ajuste.DataSource = dtAlmacen
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarArticulos(ByVal txtcodigo As TextBox, ByVal txtDescripcion As TextBox)
        Try
            Dim frmM As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_INVENTARIO_PRODUCTOS"
            frmM.CadenaConsulta = sql
            frmM.Titulo = "Articulos"
            frmM._Flag_Filtro = True
            frmM.Filtros1 = CboAlmacen.SelectedValue.ToString
            frmM.Filtros2 = cboFamily.SelectedValue.ToString
            frmM.Filtros3 = cbopart_Type.SelectedValue.ToString
            frmM.Filtros4 = IIf(String.IsNullOrEmpty(cboLine.SelectedValue.ToString), "''", cboLine.SelectedValue.ToString)
            frmM.ShowDialog()
            If frmM.Data_Matriz.Rows.Count > 0 Then
                txtcodigo.Text = frmM.Data_Matriz.Rows(0).Item(0).ToString
                txtDescripcion.Text = frmM.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frmM.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Ayuda_Articulo()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtcantidadConteo.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_LOT()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_INV_LOTES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lotes"
            frm._Flag_Filtro = True
            frm.Filtros1 = CboAlmacen.SelectedValue.ToString
            frm.Filtros2 = txtArticulo.Text
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtLote.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtcantidadLote.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtcantidadLote.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidacionesCabecera() As Boolean
        Dim estado As Boolean = True
        Try
            If cbo_almacen_adicional.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar una Almacen.", MsgBoxStyle.Information)
                cbo_almacen_adicional.Focus()
                estado = False
                Exit Try
            End If
            If txtArticulo.Text = String.Empty Then
                MsgBox("Debe seleccionar un Articulo.", MsgBoxStyle.Critical)
                estado = False
                txtArticulo.Focus()
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub MostrarLineas()
        Try
            clsLineasBl = New ClsOperaciones.LINES
            dtLineas = New DataTable
            If cbopart_Type.SelectedIndex = -1 Or cboFamily.SelectedIndex = -1 Then Exit Sub
            dtLineas = clsLineasBl.get_MostrarLineas(cboFamily.SelectedValue.ToString, cbopart_Type.SelectedValue.ToString)
            cboLine.DataSource = Nothing
            Dim row As DataRow = dtLineas.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(-TODOS LOS REGISTROS-)"
            dtLineas.Rows.InsertAt(row, 0)
            If dtLineas.Rows.Count() <> 0 Then
                Me.cboLine.DisplayMember = "DESCRIPCION"
                Me.cboLine.ValueMember = "CODIGO"
                cboLine.DataSource = dtLineas
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TiposArticulos()
        Try
            clsTipoProductoBl = New ClsOperaciones.PART_TYPE
            dtTipoProducto = New DataTable
            dtTipoProducto = clsTipoProductoBl.get_TipoArticulo()
            Me.cbopart_Type.DataSource = Nothing
            If dtTipoProducto.Rows.Count() <> 0 Then
                Me.cbopart_Type.DisplayMember = "DESCRIPCION"
                Me.cbopart_Type.ValueMember = "CODIGO"
                Me.cbopart_Type.DataSource = dtTipoProducto
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarFamilias()
        Try
            clsFamiliasBl = New ClsOperaciones.FAMILY
            dtFamilia = New DataTable
            dtFamilia = clsFamiliasBl.get_MostrarFamilias()
            clsFamiliasBl = Nothing
            cboFamily.DataSource = Nothing
            If dtFamilia.Rows.Count() <> 0 Then
                cboFamily.DisplayMember = "DESCRIPCION"
                cboFamily.ValueMember = "CODIGO"
                cboFamily.DataSource = dtFamilia
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_nuevo.Enabled = False
            btn_grabar.Enabled = True
            btn_Editar.Enabled = False
            btneliminar.Enabled = False
            btnImprimir.Enabled = False
            btn_Imprimir_Analisis.Enabled = False
            btn_ajuste_inventario.Enabled = True
            btn_cancelar.Enabled = True
            btn_eliminar.Enabled = False
        Else
            btn_nuevo.Enabled = True
            btn_grabar.Enabled = False
            btn_Editar.Enabled = True
            btneliminar.Enabled = False
            btnImprimir.Enabled = True
            btn_Imprimir_Analisis.Enabled = True
            btn_ajuste_inventario.Enabled = False
            btn_cancelar.Enabled = False
            btn_eliminar.Enabled = True
        End If
    End Sub


    Private Sub FrmAjusteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        Cargar_Almacen()
        Call MostrarFamilias()
        Call TiposArticulos()
        Call MostrarLineas()
        DocumentosPrincipal()
    End Sub


    Private Sub btninsertar_Click(sender As Object, e As EventArgs) Handles btninsertar.Click
        If txtArticulo.Text = "" Then
            MsgBox("Debe elegir un artículo.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If txtcantidadConteo.Text = "" Then
            MsgBox("Debe ingresar una cantidad del artículo.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If GuardarModificarDetalle() Then
            txtArticulo.Text = String.Empty
            txtdescripcionArticulo.Text = String.Empty
            txtLote.Text = String.Empty
            txtcantidadLote.Text = String.Empty
            txtcantidadConteo.Text = String.Empty
        End If

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If dgvdetalle.CurrentRow Is Nothing Then Exit Sub
        If dgvdetalle.ColumnCount() <> 0 Then
            EliminarDetalle()
        End If
    End Sub

    Private Sub txtArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtArticulo.MouseDoubleClick
        Ayuda_Articulo()
    End Sub

    Private Sub txtArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Articulo()
        If e.KeyCode = Keys.Enter Then
            'Ayuda_Articulo()
            If txtArticulo.Text = "" Then
                Ayuda_Articulo()
            Else
                txtcantidadConteo.Focus()
            End If
        End If
    End Sub

    Private Sub txtLote_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLote.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidacionesCabecera() = False Then Exit Sub
            '    Ayuda_LOT()
            txtcantidadLote.Focus()
        End If
    End Sub

    Private Sub txtLote_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtLote.MouseDoubleClick
        If ValidacionesCabecera() = False Then Exit Sub
        Ayuda_LOT()
    End Sub



    Private Sub btn_nuevo_Click_1(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Botonera_Estado_Cambiar(True)
        Flag_modo_edicion = False
        pnlcabecera.Visible = False
        Blank()
        gbCabecera.Enabled = True
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If dgvCabecera.Rows.Count() = 0 Then Exit Sub
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            Flag_modo_edicion = True
            Botonera_Estado_Cambiar(True)
            pnlcabecera.Visible = False
            Blank()
            Dim _Estado As String = String.Empty
            txtCodigoInventario.Text = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString
            CboAlmacen.SelectedValue = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value.ToString
            dtpFecha.Value = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value.ToString
            txtComentarios.Text = dgvCabecera.Item(5, dgvCabecera.CurrentRow.Index).Value.ToString
            _Estado = IIf(String.IsNullOrEmpty(dgvCabecera.Item(4, dgvCabecera.CurrentRow.Index).Value.ToString), "", dgvCabecera.Item(4, dgvCabecera.CurrentRow.Index).Value.ToString)
            If _Estado = "INVENT FINALIZADO" Then
                Flag_Ajuste = True
                btn_ajuste_inventario.Enabled = False
            Else
                Flag_Ajuste = False
                btn_ajuste_inventario.Enabled = True
            End If
            btn_ok_Click(sender, e)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvdetalle_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvdetalle.CellMouseDoubleClick
        txtArticulo.Text = dgvdetalle.Item(0, dgvdetalle.CurrentRow.Index).Value.ToString
        txtdescripcionArticulo.Text = dgvdetalle.Item(1, dgvdetalle.CurrentRow.Index).Value.ToString
        txtLote.Text = dgvdetalle.Item(2, dgvdetalle.CurrentRow.Index).Value.ToString
        txtcantidadLote.Text = dgvdetalle.Item(5, dgvdetalle.CurrentRow.Index).Value.ToString
        txtcantidadConteo.Text = dgvdetalle.Item(6, dgvdetalle.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub Blank()
        CboAlmacen.SelectedIndex = 0
        cbopart_Type.SelectedIndex = 0
        cboFamily.SelectedIndex = 0
        'cboLine.SelectedIndex = 0
        dtpFecha.Value = Date.Now
        dgvdetalle.DataSource = Nothing
        txtCodigoInventario.Text = String.Empty
        txtComentarios.Text = String.Empty
        txtinicioArticulo.Text = String.Empty
        txtdescripcionArticuloInicial.Text = String.Empty
        txtFinArticulo.Text = String.Empty
        txtDescripcionArticulofinal.Text = String.Empty
        txtArticulo.Text = String.Empty
        txtdescripcionArticulo.Text = String.Empty
        txtLote.Text = String.Empty
        txtcantidadLote.Text = String.Empty
        txtcantidadConteo.Text = String.Empty
        checkArticulo.Checked = False
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If dgvdetalle.CurrentRow Is Nothing Then Exit Sub
        If dgvdetalle.ColumnCount() <> 0 Then
            If Flag_modo_edicion = False Then
                If MessageBox.Show("Se va a Guardar el registro" & vbCrLf & "¿Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    MsgBox("Guardado Exitosamente", MsgBoxStyle.Information)
                    dgvCabecera.Focus()
                    Botonera_Estado_Cambiar(False)
                    pnlcabecera.Visible = True
                    DocumentosPrincipal()
                Else
                    clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
                    clsInventarioBl.Eliminar_Inventario_conteo(txtCodigoInventario.Text, CboAlmacen.SelectedValue())
                    dgvCabecera.Focus()
                    Botonera_Estado_Cambiar(False)
                    pnlcabecera.Visible = True
                    DocumentosPrincipal()
                End If
            Else
                If MessageBox.Show("Se va a Actualizar el registro" & vbCrLf & "¿Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
                    ProgressBar1.Visible = True
                    If clsInventarioBl.Actualizar_DetallesInventario(txtCodigoInventario.Text, CboAlmacen.SelectedValue.ToString, dtdetalleAjustes, ProgressBar1) = True Then
                        MsgBox("Guardado Exitosamente", MsgBoxStyle.Information)
                        dgvCabecera.Focus()
                        Botonera_Estado_Cambiar(False)
                        pnlcabecera.Visible = True
                        DocumentosPrincipal()
                    End If
                    ProgressBar1.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If Flag_modo_edicion = False Then
            clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
            If clsInventarioBl.Eliminar_Inventario_conteo(txtCodigoInventario.Text, CboAlmacen.SelectedValue()) = True Then
            End If
        End If
        dgvCabecera.Focus()
        Botonera_Estado_Cambiar(False)
        pnlcabecera.Visible = True
        DocumentosPrincipal()
    End Sub

    Private Sub CboAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAlmacen.SelectedIndexChanged
        'If CboAlmacen.SelectedIndex > -1 Then
        '    checkArticulo.Checked = False
        '    txtinicioArticulo.Text = String.Empty
        '    txtFinArticulo.Text = String.Empty
        '    txtdescripcionArticuloInicial.Text = String.Empty
        '    txtDescripcionArticulofinal.Text = String.Empty
        '    ' CboAlmacen.SelectedIndex = 0
        '    'cbopart_Type.SelectedIndex = 0
        '    'cboFamily.SelectedIndex = 0
        '    '  cboLine.SelectedIndex = 0
        '    If CboAlmacen.SelectedIndex = 0 Then
        '        gbDetalleArticulo.Enabled = False
        '    Else
        '        gbDetalleArticulo.Enabled = True
        '    End If
        'End If
    End Sub

    Private Sub checkArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles checkArticulo.CheckedChanged
        Dim rsql As String = String.Empty
        Dim BusquedaBl As ClsBuscar
        Dim dtBusquedaBl As DataTable
        If checkArticulo.Checked Then
            '' GbArticulos.Enabled = False
            txtinicioArticulo.Text = String.Empty
            txtFinArticulo.Text = String.Empty
            txtdescripcionArticuloInicial.Text = String.Empty
            txtDescripcionArticulofinal.Text = String.Empty
            BusquedaBl = New ClsBuscar
            dtBusquedaBl = New DataTable
            'rsql = "SELECT  TOP 1 a.ID,a.description  FROM PART a     INNER JOIN dbo.PART_QTY b ON a.ID=b.PART_ID " _
            '    & " WHERE b.WAREHOUSE_ID='" & CboAlmacen.SelectedValue.ToString & "'  ORDER BY ID"
            rsql = "SELECT DISTINCT  TOP 1 TP.ID,TP.description  FROM PART AS TP  INNER JOIN dbo.PART_QTY b ON TP.ID=B.PART_ID  AND b.WAREHOUSE_ID='" & CboAlmacen.SelectedValue.ToString & "'" _
                & " INNER JOIN FAMILY AS TF  ON TP.FAMILY=TF.ID  INNER JOIN LINES AS  TL  ON TL.ID = TF.ID  INNER JOIN PART_TYPE AS TPT ON TPT.ID=TP.TYPE_PART " _
            & " WHERE TP.FAMILY='" & cboFamily.SelectedValue.ToString & "' AND  TP.TYPE_PART='" & cbopart_Type.SelectedValue.ToString & "'  AND  TP.MODEL like '%" & cboLine.SelectedValue.ToString & "%' ORDER BY ID "
            dtBusquedaBl = BusquedaBl.Busquedas(rsql)
            If dtBusquedaBl.Rows.Count() <> 0 Then
                txtinicioArticulo.Text = dtBusquedaBl.Rows(0).Item(0).ToString
                txtdescripcionArticuloInicial.Text = dtBusquedaBl.Rows(0).Item(1).ToString
                rsql = String.Empty
                BusquedaBl = New ClsBuscar
                dtBusquedaBl = New DataTable
                rsql = "SELECT DISTINCT  TOP 1 TP.ID,TP.description  FROM PART AS TP  INNER JOIN dbo.PART_QTY b ON TP.ID=B.PART_ID  AND b.WAREHOUSE_ID='" & CboAlmacen.SelectedValue.ToString & "'" _
                     & " INNER JOIN FAMILY AS TF  ON TP.FAMILY=TF.ID  INNER JOIN LINES AS  TL  ON TL.ID = TF.ID  INNER JOIN PART_TYPE AS TPT ON TPT.ID=TP.TYPE_PART " _
                 & " WHERE TP.FAMILY='" & cboFamily.SelectedValue.ToString & "' AND  TP.TYPE_PART='" & cbopart_Type.SelectedValue.ToString & "'  AND  TP.MODEL like '%" & cboLine.SelectedValue.ToString & "%'  ORDER BY ID DESC"
                dtBusquedaBl = BusquedaBl.Busquedas(rsql)
                txtFinArticulo.Text = dtBusquedaBl.Rows(0).Item(0).ToString
                txtDescripcionArticulofinal.Text = dtBusquedaBl.Rows(0).Item(1).ToString
            Else
                txtinicioArticulo.Text = String.Empty
                txtFinArticulo.Text = String.Empty
                txtdescripcionArticuloInicial.Text = String.Empty
                txtDescripcionArticulofinal.Text = String.Empty
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If

        Else
            'GbArticulos.Enabled = True
            txtinicioArticulo.Text = String.Empty
            txtFinArticulo.Text = String.Empty
            txtdescripcionArticuloInicial.Text = String.Empty
            txtDescripcionArticulofinal.Text = String.Empty
        End If
    End Sub

    Private Sub txtinicioArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinicioArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial)
        End If
    End Sub

    Private Sub txtinicioArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtinicioArticulo.MouseDoubleClick
        BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial)
    End Sub


    Private Sub txtFinArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFinArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarArticulos(txtFinArticulo, txtDescripcionArticulofinal)
        End If
    End Sub

    Private Sub txtFinArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFinArticulo.MouseDoubleClick
        BuscarArticulos(txtFinArticulo, txtDescripcionArticulofinal)
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If Flag_modo_edicion = False Then
            'If CboAlmacen.SelectedIndex = 0 Then
            '    MsgBox("Debe seleccionar una Almacen.", MsgBoxStyle.Information)
            '    CboAlmacen.Focus()
            '    Exit Sub
            'End If
            'If txtinicioArticulo.Text = String.Empty Then
            '    MsgBox("Debe seleccionar un articulo inicial.", MsgBoxStyle.Information)
            '    txtinicioArticulo.Focus()
            '    Exit Sub
            'End If
            'If txtFinArticulo.Text = String.Empty Then
            '    MsgBox("Debe seleccionar un articulo final.", MsgBoxStyle.Information)
            '    txtFinArticulo.Focus()
            '    Exit Sub
            'End If
            GuardarCabecera()
            ProgressBar1.Visible = True
            clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
            GenerarColummnaDataTable()
            dtdetalleAjustes = clsInventarioBl.Guardar_Actualizar_DetallesInventario(txtCodigoInventario.Text, dtpFecha.Value.ToString("dd/MM/yyyy"), CboAlmacen.SelectedValue.ToString, _
                                                                  txtinicioArticulo.Text, txtFinArticulo.Text, cboFamily.SelectedValue.ToString, cbopart_Type.SelectedValue.ToString, cboLine.SelectedValue.ToString, ProgressBar1)
            ConfigurarGrilla()
            ProgressBar1.Visible = False
        Else
            If txtCodigoInventario.Text = String.Empty Then Exit Sub
            GenerarColummnaDataTable()
            clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
            dtdetalleAjustes = clsInventarioBl.MostrandodetallesInventario(txtCodigoInventario.Text, CboAlmacen.SelectedValue.ToString)
            ConfigurarGrilla()
        End If
        gbCabecera.Enabled = False
        gbDetalle.Enabled = True
    End Sub

    Private Sub Imprimir_Inventario_Analisis(ByVal _DOCUMENT_ID As String, ByVal _WAREHOUSE As String, ByVal DESCRIPTION As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimirAnalisis = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimirAnalisis = reporteBL.EjecutarReporteDetallesInventario(_DOCUMENT_ID, _WAREHOUSE)
            If dtImprimirAnalisis.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Inventario_Analisis.rpt", dtImprimirAnalisis, "", "", "@ID_INVENTARIO;" & _DOCUMENT_ID, "@ALMACEN;" & _WAREHOUSE, "@NOMBRE_ALM;" & _DOCUMENT_ID)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Imprimir_Inventario_Planilla(ByVal _DOCUMENT_ID As String, ByVal _WAREHOUSE As String, ByVal DESCRIPTION As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimirPlantillas = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimirPlantillas = reporteBL.EjecutarReporteDetallesInventario(_DOCUMENT_ID, _WAREHOUSE)
            If dtImprimirPlantillas.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Inventario_Listado.rpt", dtImprimirPlantillas, "", "", "@ID_INVENTARIO;" & _DOCUMENT_ID, "@ALMACEN;" & _WAREHOUSE, "@NOMBRE_ALM;" & _DOCUMENT_ID)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If dgvCabecera.ColumnCount() <> 0 Then
            Dim Codigo As String = String.Empty
            Dim Almacen As String = String.Empty
            Dim DescripcionAlm As String = String.Empty
            Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString
            Almacen = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value.ToString
            DescripcionAlm = dgvCabecera.Item(3, dgvCabecera.CurrentRow.Index).Value.ToString

            'If Codigo = String.Empty Or Almacen = String.Empty Then Exit Sub
            Imprimir_Inventario_Planilla(Codigo, Almacen, DescripcionAlm)
        End If
    End Sub


    Private Sub btn_eliminar_Click_1(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If dgvCabecera.ColumnCount() <> 0 Then
            If MessageBox.Show("Se va a eliminar el registro " & dgvCabecera.CurrentRow.Cells("NRO_INVENTARIO").Value.ToString & " " & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
                If clsInventarioBl.Eliminar_Inventario_conteo(dgvCabecera.CurrentRow.Cells("NRO_INVENTARIO").Value.ToString, dgvCabecera.CurrentRow.Cells("WAREHOUSE_ID").Value.ToString) = True Then
                    MsgBox("Eliminado Exitosamente", MsgBoxStyle.Information)
                    dgvCabecera.Focus()
                    Botonera_Estado_Cambiar(False)
                    pnlcabecera.Visible = True
                    DocumentosPrincipal()
                End If
            End If
        End If

    End Sub

    Private Sub btn_Imprimir_Analisis_Click(sender As Object, e As EventArgs) Handles btn_Imprimir_Analisis.Click
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If dgvCabecera.ColumnCount() <> 0 Then
            Dim Codigo As String = String.Empty
            Dim Almacen As String = String.Empty
            Dim DescripcionAlm As String = String.Empty
            Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString
            Almacen = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value.ToString
            DescripcionAlm = dgvCabecera.Item(3, dgvCabecera.CurrentRow.Index).Value.ToString
            'If Codigo = String.Empty Or Almacen = String.Empty Then Exit Sub
            Imprimir_Inventario_Analisis(Codigo, Almacen, DescripcionAlm)
        End If
    End Sub

    Private Sub imprimirAlmacen(ByVal _idalamacen As String, ByVal _documentid As String, ByVal _numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(_idalamacen, _documentid, _numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function GenerarIngresoAlmacen() As Boolean
        Try
            Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

            clsAlmacenCorrelativoBl = New ClsTransacciones.clsAlmacenCorrelativo
            'clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(CboAlmacen.SelectedValue.ToString, "I")
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(cbo_almacen_ajuste.SelectedValue.ToString, "I")
            'la parte de almacen
            With alm_cabBE
                .WAREHOUSE_ID = cbo_almacen_ajuste.SelectedValue.ToString
                .DOCUMENT_ID = "NI"
                .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                _almacen_ingreso = .WAREHOUSE_ID
                _tipo_doc_ingreso = .DOCUMENT_ID
                _numero_doc_ingreso = .NUMBER_DOCUMENT
                .DATE_DOCUMENT = dtpFechaInventario.Value.ToShortDateString
                .TYPE_TRANS = "I"
                .TRANS_ID = "AJ"
                .DOC_ID_REF = "INV"
                .NUM_ID_REF = txtCodigoInventario.Text
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .UPDATE_DATE = ""
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .VAT_REGISTRATION = ""
                .ADDR_DLV = ""
                .VENDOR_ID = ""
                .VENDOR_NAME = ""
                .CUSTOMER_ID = "20547008902"
                .CUSTOMER_NAME = "IMPORTACIONES INSUGRAF SAC"
                .SALES_TERM = ""
                .CURRENCY_TYPE = "MN"
                .CURRENCY_EXCHANGE = LibComunVar.ClsVarComun.TCVenta
                .STATUS_GUIA = "V"
                .AMOUNT = 0
                .COMMENT = txtComentarioAjuste.Text
                .TYPE_GUIA = "AJ"
                .WAREHOUSE_REF = ""
            End With
            'Detalle de la Guia...
            Dim i As Integer = 0
            For Each item As DataRow In dtdetalleAjustes.Select("CANT_DIF > 0 AND COD_ALMACEN='" & cbo_almacen_ajuste.SelectedValue.ToString & "' ", "")
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                i = i + 1
                With alm_detBE
                    .WAREHOUSE_ID = cbo_almacen_ajuste.SelectedValue.ToString
                    .DOCUMENT_ID = "NI"
                    .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
                    .ITEM = i
                    .PART_ID = item("CODIGO").ToString
                    .QTY = item("CANT_DIF").ToString
                    .QTY_DLV = 0
                    .QTY_REF = item("CANT_DIF").ToString
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .PART_DESCRIPTION = item("DESCRIPCION").ToString
                    .UNIT_PART = ""
                    .NUMBER_LOT = item("LOTE").ToString
                    .WAREHOUSE_REF = ""
                    .ACCOUNT = ""
                End With
                ls_det_alm.Add(alm_detBE)
            Next
            Me.Cursor = Cursors.WaitCursor
            If ls_det_alm.Count() <> 0 Then
                If almacenBL.GuardarAlmacen(alm_cabBE, ls_det_alm, "I") Then
                    Dim msj As String = String.Empty
                    msj = "Ingreso al Almacen Destino Generado Correctamente," & Chr(13) & "Nro Documento: " & alm_cabBE.NUMBER_DOCUMENT
                    MsgBox(msj, MsgBoxStyle.Information)
                    imprimirAlmacen(cbo_almacen_ajuste.SelectedValue.ToString, "NI", alm_cabBE.NUMBER_DOCUMENT)
                    Me.Cursor = Cursors.Default
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Private Function GenerarSalidaAlmacen() As Boolean
        Try
            Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

            clsAlmacenCorrelativoBl = New ClsTransacciones.clsAlmacenCorrelativo
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(cbo_almacen_ajuste.SelectedValue.ToString, "S")
            'la parte de almacen
            With alm_cabBE
                .WAREHOUSE_ID = cbo_almacen_ajuste.SelectedValue.ToString
                .DOCUMENT_ID = "NS"
                .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                .DATE_DOCUMENT = dtpFechaInventario.Value.ToShortDateString
                .TYPE_TRANS = "S"
                .TRANS_ID = "AJ"
                .DOC_ID_REF = "INV"
                .NUM_ID_REF = txtCodigoInventario.Text
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .UPDATE_DATE = ""
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .VAT_REGISTRATION = ""
                .ADDR_DLV = ""
                .VENDOR_ID = ""
                .VENDOR_NAME = ""
                .CUSTOMER_ID = "20547008902"
                .CUSTOMER_NAME = "IMPORTACIONES INSUGRAF SAC"
                .SALES_TERM = ""
                .CURRENCY_TYPE = "MN"
                .CURRENCY_EXCHANGE = LibComunVar.ClsVarComun.TCVenta
                .STATUS_GUIA = "V"
                .AMOUNT = 0
                .COMMENT = txtComentarioAjuste.Text
                .TYPE_GUIA = "AJ"
                .WAREHOUSE_REF = ""
            End With
            'Detalle de la Guia...
            Dim i As Integer = 0
            For Each item As DataRow In dtdetalleAjustes.Select("CANT_DIF < 0 AND COD_ALMACEN='" & cbo_almacen_ajuste.SelectedValue.ToString & "' ", "")
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                i = i + 1
                With alm_detBE
                    .WAREHOUSE_ID = cbo_almacen_ajuste.SelectedValue.ToString
                    .DOCUMENT_ID = "NS"
                    .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
                    .ITEM = i
                    .PART_ID = item("CODIGO").ToString
                    .QTY = Math.Abs(CDbl(item("CANT_DIF").ToString))
                    .QTY_DLV = 0
                    .QTY_REF = Math.Abs(CDbl(item("CANT_DIF").ToString))
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .PART_DESCRIPTION = item("DESCRIPCION").ToString
                    .UNIT_PART = ""
                    .NUMBER_LOT = item("LOTE").ToString
                    .WAREHOUSE_REF = ""
                    .ACCOUNT = ""
                End With
                ls_det_alm.Add(alm_detBE)
            Next
            Me.Cursor = Cursors.WaitCursor
            If ls_det_alm.Count() <> 0 Then
                If almacenBL.GuardarAlmacen(alm_cabBE, ls_det_alm, "S") Then
                    Dim msj As String = String.Empty
                    msj = "Nota de Salida generada Correctamente" & Chr(13) & "Nro Documento: " & alm_cabBE.NUMBER_DOCUMENT
                    MsgBox(msj, MsgBoxStyle.Information)
                    imprimirAlmacen(cbo_almacen_ajuste.SelectedValue.ToString, "NS", alm_cabBE.NUMBER_DOCUMENT)
                    Me.Cursor = Cursors.Default
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btn_ajuste_inventario_Click(sender As Object, e As EventArgs) Handles btn_ajuste_inventario.Click
        If Flag_modo_edicion = True Then
            If Flag_Ajuste = True Then
                MsgBox("Ya se Genero un ajuste de inventario por el sistema.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Cargar_Almacen_Ajuste()
                pnlGenerarAjuste.Visible = True
                dtpFechaInventario.Value = Date.Now
                txtComentarioAjuste.Text = String.Empty
                'MsgBox("Se estan realizando algunos ajustes para terminar el proceso.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btn_Aceptar_Ajuste_Click(sender As Object, e As EventArgs) Handles btn_Aceptar_Ajuste.Click
        If dgvdetalle.Rows.Count() <> 0 Then
            If MessageBox.Show("Se va a Generar el Ajuste de Inventario" & vbCrLf & "¿Desea continuar?", "Ajuste de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If GenerarIngresoAlmacen() Then
                    If GenerarSalidaAlmacen() Then
                        clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
                        clsInventarioBl.Actualizar_Inventario_Estado(txtCodigoInventario.Text, cbo_almacen_ajuste.SelectedValue.ToString)
                        Cargar_Almacen_Ajuste()
                        btn_cancelar_Click(sender, e)
                    Else
                        clsInventarioBl = New ClsOperaciones.INVENTORY_COUNT
                        clsInventarioBl.Elimina_Ingreso_Inventario_Fisico(_almacen_ingreso, _tipo_doc_ingreso, _numero_doc_ingreso)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_Salir_Ajuste_Click(sender As Object, e As EventArgs) Handles btn_Salir_Ajuste.Click
        pnlGenerarAjuste.Visible = False
        dtpFechaInventario.Value = Date.Now
        txtComentarioAjuste.Text = String.Empty
    End Sub

    Private Sub cbopart_Type_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbopart_Type.SelectionChangeCommitted
        Call MostrarLineas()
    End Sub

    Private Sub cboFamily_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboFamily.SelectionChangeCommitted
        Call MostrarLineas()
    End Sub

    Private Sub cbopart_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopart_Type.SelectedIndexChanged
        checkArticulo.Checked = False
        txtinicioArticulo.Text = String.Empty
        txtFinArticulo.Text = String.Empty
        txtdescripcionArticuloInicial.Text = String.Empty
        txtDescripcionArticulofinal.Text = String.Empty
    End Sub

 
    Private Sub cboFamily_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFamily.SelectedIndexChanged
        checkArticulo.Checked = False
        txtinicioArticulo.Text = String.Empty
        txtFinArticulo.Text = String.Empty
        txtdescripcionArticuloInicial.Text = String.Empty
        txtDescripcionArticulofinal.Text = String.Empty
    End Sub

    Private Sub cboLine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLine.SelectedIndexChanged
        checkArticulo.Checked = False
        txtinicioArticulo.Text = String.Empty
        txtFinArticulo.Text = String.Empty
        txtdescripcionArticuloInicial.Text = String.Empty
        txtDescripcionArticulofinal.Text = String.Empty
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub cbo_almacen_adicional_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_almacen_adicional.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Ayuda_Articulo()
            txtArticulo.Focus()
        End If
    End Sub

    Private Sub txtcantidadConteo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidadConteo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btninsertar.Focus()
        End If
    End Sub

    Private Sub txtcantidadConteo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidadConteo.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class