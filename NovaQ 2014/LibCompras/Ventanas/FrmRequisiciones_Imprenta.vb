Imports LibCompras
Imports LibComunVar
Imports LibCobranzas

Public Class FrmRequisiciones_Imprenta
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
    Dim dt_datos As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_ME As DataTable
    Dim dtdetalleArticuloPrincipal_Puente As DataTable
    Dim dtdetalleArticuloPrincipal_Puente_ME As DataTable
    Dim _ITEM_PRODUCTO As Integer = 0
    Private Sub FrmRequisiciones_Imprenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        Cargar_Areas()
        cboopcionesBusqueda.SelectedIndex = 1
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
            frm.Titulo = "Seleccion de Material de Empaque"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_me.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_me.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_un_me.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txt_cantidad.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mostrando_Producto()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_ARTICULO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = "RR"
            frm.Titulo = "Seleccion de Productos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_producto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_Des_producto.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_producto_rs.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txt_producto_rs.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mostrando_Reg_Sanit()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_REG_SANIT"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_producto.Text.Trim
            frm.Titulo = "Registro(s) Sanitario(s) del Producto"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_producto_rs.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_cod_me.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        MostrandoArticulos()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        CONTROLES(True, 0)
        btn_menu.Enabled = True
        configurarGrilla()
        dgvDetalle.DataSource = dtdetallePrincipal
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try
            If txt_producto.Text = "" Then
                MsgBox("Debe seleccionar un Producto.", MsgBoxStyle.Critical)
                txt_producto.Select()
                Exit Sub
            End If
            If txt_producto_rs.Text = "" Then
                MsgBox("El producto seleccionado no tiene un Reg. Sanitario.", MsgBoxStyle.Critical)
                txt_producto_rs.Select()
                Exit Sub
            End If
            If dgv_lotes.Rows.Count = 0 Then
                MsgBox("Debe anexar los lotes de los Materiales de Empaque.", MsgBoxStyle.Critical)
                txt_lote.Select()
                Exit Sub
            End If
            If dgv_me.Rows.Count = 0 Then
                MsgBox("Debe anexar los Materiales de Empaque.", MsgBoxStyle.Critical)
                txt_cod_me.Select()
                Exit Sub
            End If
            

            If _Flag_edicion = False Then
                Dim row As DataRow = dtdetallePrincipal.NewRow
                row("ITEM") = dtdetallePrincipal.Rows.Count() + 1
                row("PART_ID") = txt_producto.Text
                row("PART_DESCRIPTION") = txt_Des_producto.Text
                row("UNIT") = txt_producto_rs.Text
                row("QTY") = 0
                row("AMOUNT_BALANCE") = 0
                row("CCOST_ID") = ""
                row("COMMENT") = txtobservacion.Text
                row("PROJECT_ID") = ""
                row("COD_PRIORIDAD") = ""
                row("ID_VENDOR") = ""
                row("VENDOR") = ""
                row("COD_ROTULADO") = IIf(rb_muestramedica.Checked, "1", IIf(rb_estadoperuano.Checked, "2", IIf(rb_estadoperuano_pv.Checked, "3", "")))
                dtdetallePrincipal.Rows.Add(row)
                dtdetallePrincipal.AcceptChanges()

                For i As Integer = 0 To dtdetalleArticuloPrincipal_Puente.Rows.Count - 1
                    Dim row2 As DataRow = dtdetalleArticuloPrincipal.NewRow
                    row2("ITEM_PRODUCTO") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("ITEM_PRODUCTO").ToString
                    row2("ITEM") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("ITEM").ToString
                    row2("LOTE") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("LOTE").ToString
                    row2("VCTO") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("VCTO").ToString
                    row2("PRODUCTO") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("PRODUCTO").ToString
                    dtdetalleArticuloPrincipal.Rows.Add(row2)
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next

                For i As Integer = 0 To dtdetalleArticuloPrincipal_Puente_ME.Rows.Count - 1
                    Dim row3 As DataRow = dtdetalleArticuloPrincipal_ME.NewRow
                    row3("ITEM_PRODUCTO") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("ITEM_PRODUCTO").ToString
                    row3("ITEM") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("ITEM").ToString
                    row3("PART_ID") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("PART_ID").ToString
                    row3("PART_DESCRIPTION") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("PART_DESCRIPTION").ToString
                    row3("PART_UNIT") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("PART_UNIT").ToString
                    row3("CANTIDAD") = CDbl(dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("CANTIDAD").ToString)
                    row3("PRODUCTO") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("PRODUCTO").ToString
                    dtdetalleArticuloPrincipal_ME.Rows.Add(row3)
                    dtdetalleArticuloPrincipal_ME.AcceptChanges()
                Next

                configurarGrilla()
                blank()
                txt_cod_me.Select()
            Else
                For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & _Codigo_Ini)
                    dtdetallePrincipal.BeginInit()
                    item("PART_ID") = txt_producto.Text
                    item("PART_DESCRIPTION") = txt_Des_producto.Text
                    item("UNIT") = txt_producto_rs.Text
                    item("QTY") = 0
                    item("COMMENT") = txtobservacion.Text
                    item("COD_PRIORIDAD") = ""
                    item("ID_VENDOR") = ""
                    item("VENDOR") = ""
                    item("COD_ROTULADO") = IIf(rb_muestramedica.Checked, "1", IIf(rb_estadoperuano.Checked, "2", IIf(rb_estadoperuano_pv.Checked, "3", "")))
                    dtdetallePrincipal.EndInit()
                    dtdetallePrincipal.AcceptChanges()

                Next
                'elimino mis lotes
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM_PRODUCTO=" & _Codigo_Ini)
                    item.Delete()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next

                For i As Integer = 0 To dtdetalleArticuloPrincipal_Puente.Rows.Count - 1
                    Dim row2 As DataRow = dtdetalleArticuloPrincipal.NewRow
                    row2("ITEM_PRODUCTO") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("ITEM_PRODUCTO").ToString
                    row2("ITEM") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("ITEM").ToString
                    row2("LOTE") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("LOTE").ToString
                    row2("VCTO") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("VCTO").ToString
                    row2("PRODUCTO") = dtdetalleArticuloPrincipal_Puente.Rows(i).Item("PRODUCTO").ToString
                    dtdetalleArticuloPrincipal.Rows.Add(row2)
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                'elimino mis mat de empaque
                For Each item2 As DataRow In dtdetalleArticuloPrincipal_ME.Select("ITEM_PRODUCTO=" & _Codigo_Ini)
                    item2.Delete()
                    dtdetalleArticuloPrincipal_ME.AcceptChanges()
                Next

                For i As Integer = 0 To dtdetalleArticuloPrincipal_Puente_ME.Rows.Count - 1
                    Dim row3 As DataRow = dtdetalleArticuloPrincipal_ME.NewRow
                    row3("ITEM_PRODUCTO") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("ITEM_PRODUCTO").ToString
                    row3("ITEM") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("ITEM").ToString
                    row3("PART_ID") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("PART_ID").ToString
                    row3("PART_DESCRIPTION") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("PART_DESCRIPTION").ToString
                    row3("PART_UNIT") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("PART_UNIT").ToString
                    row3("CANTIDAD") = CDbl(dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("CANTIDAD").ToString)
                    row3("PRODUCTO") = dtdetalleArticuloPrincipal_Puente_ME.Rows(i).Item("PRODUCTO").ToString
                    dtdetalleArticuloPrincipal_ME.Rows.Add(row3)
                    dtdetalleArticuloPrincipal_ME.AcceptChanges()
                Next
                configurarGrilla()
                btn_salir_Click(sender, e)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub blank()
        txt_cod_me.Text = ""
        txt_des_me.Text = ""
        txt_un_me.Text = ""
        txt_cantidad.Text = ""
        txtobservacion.Text = ""
        chk_prioridad.Checked = False
        txt_producto.Text = ""
        txt_Des_producto.Text = ""
        txt_producto_rs.Text = ""
        txt_lote.Text = ""
        txt_vcto.Text = ""
        rb_muestramedica.Checked = False
        rb_estadoperuano.Checked = False
        rb_estadoperuano_pv.Checked = False
        dtdetalleArticuloPrincipal_Puente.Rows.Clear()
        dtdetalleArticuloPrincipal_Puente_ME.Rows.Clear()
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
            dtdetalleArticuloPrincipal_Puente.Rows.Clear()
            dgv_lotes.DataSource = dtdetalleArticuloPrincipal_Puente

            dtdetalleArticuloPrincipal_Puente_ME.Rows.Clear()
            dgv_me.DataSource = dtdetalleArticuloPrincipal_Puente_ME

            btn_menu.Enabled = False
            txt_producto.Select()
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
                txt_producto.Text = item("PART_ID")
                txt_Des_producto.Text = item("PART_DESCRIPTION")
                txt_producto_rs.Text = item("UNIT")
                txtobservacion.Text = item("COMMENT")


                If String.IsNullOrEmpty(item("COD_ROTULADO")) Then
                    rb_muestramedica.Checked = False
                    rb_estadoperuano.Checked = False
                    rb_estadoperuano_pv.Checked = False
                Else
                    If item("COD_ROTULADO") = "1" Then
                        rb_muestramedica.Checked = True
                    ElseIf item("COD_ROTULADO") = "2" Then
                        rb_estadoperuano.Checked = True
                    ElseIf item("COD_ROTULADO") = "3" Then
                        rb_estadoperuano_pv.Checked = True
                    End If
                End If
            Next

            For Each ITEM2 As DataRow In dtdetalleArticuloPrincipal.Select("ITEM_PRODUCTO=" & _Codigo_Ini)
                Dim ROW As DataRow = dtdetalleArticuloPrincipal_Puente.NewRow
                ROW("ITEM_PRODUCTO") = ITEM2("ITEM_PRODUCTO")
                ROW("ITEM") = ITEM2("ITEM")
                ROW("LOTE") = ITEM2("LOTE")
                ROW("VCTO") = ITEM2("VCTO")
                ROW("PRODUCTO") = ITEM2("PRODUCTO")
                dtdetalleArticuloPrincipal_Puente.Rows.Add(ROW)
                dtdetalleArticuloPrincipal_Puente.AcceptChanges()
            Next
            dgv_lotes.DataSource = dtdetalleArticuloPrincipal_Puente

            For Each ITEM2 As DataRow In dtdetalleArticuloPrincipal_ME.Select("ITEM_PRODUCTO=" & _Codigo_Ini)
                Dim ROW As DataRow = dtdetalleArticuloPrincipal_Puente_ME.NewRow
                ROW("ITEM_PRODUCTO") = ITEM2("ITEM_PRODUCTO")
                ROW("ITEM") = ITEM2("ITEM")
                ROW("PART_ID") = ITEM2("PART_ID")
                ROW("PART_DESCRIPTION") = ITEM2("PART_DESCRIPTION")
                ROW("PART_UNIT") = ITEM2("PART_UNIT")
                ROW("CANTIDAD") = ITEM2("CANTIDAD")
                ROW("PRODUCTO") = ITEM2("PRODUCTO")
                dtdetalleArticuloPrincipal_Puente_ME.Rows.Add(ROW)
                dtdetalleArticuloPrincipal_Puente_ME.AcceptChanges()
            Next
            dgv_me.DataSource = dtdetalleArticuloPrincipal_Puente_ME
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

                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM_PRODUCTO=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next

                For Each item As DataRow In dtdetalleArticuloPrincipal_ME.Select("ITEM_PRODUCTO=" & Codigo)
                    dtdetalleArticuloPrincipal_ME.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal_ME.EndInit()
                    dtdetalleArticuloPrincipal_ME.AcceptChanges()
                Next

                'RehacerSecuencia()
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
        DocumentosRequisiones()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalle.RowCount() = 0 Then Exit Sub
        If txtcomentario.Text = "" Then
            MsgBox("Es necesario agregar una descripción para la Requisición de Imprenta.", MsgBoxStyle.Information)
            txtcomentario.Select()
            Exit Sub
        End If
        Dim MSJ As String = ""
        Dim MSJ_RES As String = ""
        If Modo_consultar = True Then
            MSJ = "¿Desea Modificar la Requisición de Imprenta.?"
            MSJ_RES = "Actualizado Exitosamente."
        Else
            MSJ = "¿Desea Generar la Requisición de Imprenta.?"
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

    Private Function GuardarModificarRequisiciones() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            Dim cabeceraBL As New ClsOperaciones.REQUIREMENT
            Dim cabeceraBE As New ClsEntidades.REQUIREMENT
            Dim ls_det As New List(Of ClsEntidades.REQUIREMENT_LINE)
            Dim ls_det_lotes As New List(Of ClsEntidades.REQUIREMENT_LINE_IMPRENTA)
            Dim ls_det_me As New List(Of ClsEntidades.REQUIREMENT_LINE_IMPRENTA_ME)
            Dim detalle As New ClsEntidades.REQUIREMENT_LINE
            Dim detalle_lotes As New ClsEntidades.REQUIREMENT_LINE_IMPRENTA
            Dim detalle_me As New ClsEntidades.REQUIREMENT_LINE_IMPRENTA_ME

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
                    .COD_PRIORIDAD = dtdetallePrincipal.Rows(i).Item("COD_ROTULADO")
                    'If String.IsNullOrEmpty(dtdetallePrincipal.Rows(i).Item("COD_ROTULADO").ToString) Then
                    '    .COD_PRIORIDAD = "0"
                    'Else
                    '    If dtdetallePrincipal.Rows(i).Item("COD_ROTULADO") = "Urgente" Then
                    '        .COD_PRIORIDAD = "1"
                    '    End If
                    'End If
                    .ID_VENDOR = dtdetallePrincipal.Rows(i).Item("ID_VENDOR").ToString
                End With
                ls_det.Add(detalle)
            Next

            'Detalle de Lotes
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                detalle_lotes = New ClsEntidades.REQUIREMENT_LINE_IMPRENTA
                With detalle_lotes
                    .ID = cabeceraBE.ID
                    .TYPE = TipoMov
                    .ITEM_PRODUCTO = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_PRODUCTO")
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM")
                    .LOTE = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE")
                    .VCTO = dtdetalleArticuloPrincipal.Rows(i).Item("VCTO")
                    .PRODUCTO = dtdetalleArticuloPrincipal.Rows(i).Item("PRODUCTO")
                End With
                ls_det_lotes.Add(detalle_lotes)
            Next

            'Detalle de los Materiales de Empaque
            For i As Integer = 0 To dtdetalleArticuloPrincipal_ME.Rows.Count() - 1
                detalle_me = New ClsEntidades.REQUIREMENT_LINE_IMPRENTA_ME
                With detalle_me
                    .ID = cabeceraBE.ID
                    .TYPE = TipoMov
                    .ITEM_PRODUCTO = dtdetalleArticuloPrincipal_ME.Rows(i).Item("ITEM_PRODUCTO")
                    .ITEM = dtdetalleArticuloPrincipal_ME.Rows(i).Item("ITEM")
                    .PART_ID = dtdetalleArticuloPrincipal_ME.Rows(i).Item("PART_ID")
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal_ME.Rows(i).Item("PART_DESCRIPTION")
                    .PART_UNIT = dtdetalleArticuloPrincipal_ME.Rows(i).Item("PART_UNIT")
                    .CANTIDAD = dtdetalleArticuloPrincipal_ME.Rows(i).Item("CANTIDAD")
                    .PRODUCTO = dtdetalleArticuloPrincipal_ME.Rows(i).Item("PRODUCTO")
                End With
                ls_det_me.Add(detalle_me)
            Next
            ''GUARDANDO DATOS DE LA FACTURACION
            If Modo_consultar = True Then
                If cabeceraBL.ActualizarRequisiciones_Imprenta(cabeceraBE, ls_det, ls_det_lotes, ls_det_me) = False Then
                    MsgBox("Hubo un Error en la Actualizacion de la Requisición de Imprenta", MsgBoxStyle.Critical)
                    indicadorF = False
                    Exit Try
                End If
            Else
                If cabeceraBL.GuardarRequerimientos_Imprenta(cabeceraBE, ls_det, ls_det_lotes, ls_det_me) = False Then
                    MsgBox("Hubo un Error en la Generacion de la Requisición de Imprenta", MsgBoxStyle.Critical)
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
            envio_mail._codigo_datos_email = "07"
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
            If estadoInicial = "OI" Or estadoInicial = "OP" Then
                MsgBox("El documento ya se encuentra anexado a una " & Chr(13) & "Orden de Servicio de Imprenta, no se puede anular.", MsgBoxStyle.Critical)
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
        Dim estado As String = dgvCabecera.Item(8, dgvCabecera.CurrentRow.Index).Value
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
            dtdetallePrincipal = clsRequisionesBl.DatosRequisicion_Imprenta_DetalleModoEdicion(TipoMov, codigo)
            If dtdetallePrincipal.Rows.Count() <> 0 Then
                configurarGrilla()
            End If

            GenerarColummnaDataTable_Contenedor()
            GenerarColummnaDataTable_Puente()

            GenerarColummnaDataTable_Contenedor_ME()
            GenerarColummnaDataTable_Puente_ME()

            dtdetalleArticuloPrincipal = clsRequisionesBl.DatosRequisicion_Imprenta_Detalle_Lotes(TipoMov, codigo)
            dtdetalleArticuloPrincipal_ME = clsRequisionesBl.DatosRequisicion_Imprenta_Detalle_ME(TipoMov, codigo)
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
            dtImprimir = reporteBL.EjecutarReporteRequisiciones_Imprenta(tipo, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Compras_requisiciones_imprenta.rpt", "", "", "", "@TYPE;" & tipo, "@ID;" & numerodocument, "user;" & LibComunVar.ClsVarComun.USUARIO)
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

    

    Private Sub txtobservacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobservacion.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    btn_aceptar_Click(sender, e)
        'End If
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

    Private Sub cboareas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboareas.SelectedIndexChanged
        txtFiltro.Text = String.Empty
        DocumentosRequisiones()
    End Sub

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
            dtdetallePrincipal.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
            dtdetallePrincipal.Columns.Add("PART_ID", Type.GetType("System.String")) '1
            dtdetallePrincipal.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String")) '2
            dtdetallePrincipal.Columns.Add("UNIT", Type.GetType("System.String")) '3
            dtdetallePrincipal.Columns.Add("ID_VENDOR", Type.GetType("System.String")) '4
            dtdetallePrincipal.Columns.Add("VENDOR", Type.GetType("System.String")) '5
            dtdetallePrincipal.Columns.Add("QTY", Type.GetType("System.Double")) '6
            dtdetallePrincipal.Columns.Add("AMOUNT_BALANCE", Type.GetType("System.Double")) '7
            dtdetallePrincipal.Columns.Add("COMMENT", Type.GetType("System.String")) '8
            dtdetallePrincipal.Columns.Add("CCOST_ID", Type.GetType("System.String")) '9
            dtdetallePrincipal.Columns.Add("PROJECT_ID", Type.GetType("System.String")) '10
            dtdetallePrincipal.Columns.Add("COD_PRIORIDAD", Type.GetType("System.String")) '11
            dtdetallePrincipal.Columns.Add("COD_ROTULADO", Type.GetType("System.String")) '12
            
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
        
        dgvDetalle.Columns("ITEM").HeaderText = "Item"
        dgvDetalle.Columns("PART_ID").HeaderText = "Codigo"
        dgvDetalle.Columns("PART_DESCRIPTION").HeaderText = "Descripcion"
        dgvDetalle.Columns("UNIT").HeaderText = "Reg. Sanitario"

        dgvDetalle.Columns("QTY").Visible = False
        dgvDetalle.Columns("AMOUNT_BALANCE").Visible = False
        dgvDetalle.Columns("COMMENT").Visible = False
        dgvDetalle.Columns("COD_PRIORIDAD").Visible = False
        dgvDetalle.Columns("ID_VENDOR").Visible = False
        dgvDetalle.Columns("VENDOR").Visible = False
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
            GenerarColummnaDataTable_Contenedor()
            GenerarColummnaDataTable_Puente()

            GenerarColummnaDataTable_Contenedor_ME()
            GenerarColummnaDataTable_Puente_ME()

            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            Modo_consultar = False
            CONTROLES(True, 0)
            GbCabecera.Enabled = True
            gbOpciones.Enabled = True
            txttipoDoc.Text = TipoMov
            txtcodigo.Text = Numeracion()
            txtarea.Select()
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

    Private Sub txt_producto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_producto.MouseDoubleClick
        Mostrando_Producto()
    End Sub

    Private Sub txt_producto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_producto.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Producto()
        If e.KeyCode = Keys.Enter Then
            If txt_producto.Text = String.Empty Then
                Mostrando_Producto()
            Else
                txt_producto_rs.Select()
            End If
        End If
    End Sub

    Private Sub txt_lote_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_lote.MouseDoubleClick
        Mostrando_Lotes()
    End Sub
    Private Sub Mostrando_Lotes()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "REQUI_SP_S_LOTES"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_producto.Text.Trim
            frm.Titulo = "Lista de Lotes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_lote.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_vcto.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                btn_add.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If Validacion_Ingreso() = False Then Exit Sub
            If dtdetalleArticuloPrincipal_Puente.Rows.Count > 0 Then
                If dtdetalleArticuloPrincipal_Puente.Rows.Count > 0 Then
                    For Each rows As DataRow In dtdetalleArticuloPrincipal_Puente.Select("LOTE='" & txt_lote.Text.Trim & "' ")
                        MsgBox("El Lote ya se encuentra adjuntado.", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Try
                    Next
                End If
            End If
            
            Dim row As DataRow = dtdetalleArticuloPrincipal_Puente.NewRow
            If _Flag_edicion = False Then
                row("ITEM_PRODUCTO") = dtdetallePrincipal.Rows.Count + 1
            Else
                row("ITEM_PRODUCTO") = _Codigo_Ini
            End If

            row("ITEM") = dtdetalleArticuloPrincipal_Puente.Rows.Count() + 1
            row("LOTE") = txt_lote.Text.Trim
            row("VCTO") = txt_vcto.Text.Trim
            row("PRODUCTO") = txt_producto.Text.Trim
            dtdetalleArticuloPrincipal_Puente.Rows.Add(row)
            dtdetalleArticuloPrincipal_Puente.AcceptChanges()
            txt_lote.Text = String.Empty
            txt_vcto.Text = String.Empty
            txt_lote.Focus()
            dgv_lotes.DataSource = dtdetalleArticuloPrincipal_Puente

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Validacion_Ingreso() As Boolean

        If txt_lote.Text.Trim = "" Then
            MsgBox("Debe elegir un Lote.", MsgBoxStyle.Exclamation, "Sistemas Lusa")
            Return False
            Exit Function
        End If

        Return True

    End Function

    Function Validacion_Ingreso_ME() As Boolean

        If txt_cod_me.Text.Trim = "" Then
            MsgBox("Debe elegir un Material de Empaque.", MsgBoxStyle.Exclamation, "Sistemas Lusa")
            Return False
            Exit Function
        End If

        If txt_cantidad.Text.Trim = "" Then
            MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Exclamation, "Sistemas Lusa")
            Return False
            Exit Function
        Else
            If CDbl(txt_cantidad.Text) = 0 Then
                MsgBox("La cantidad no puede ser cero.", MsgBoxStyle.Exclamation, "Sistemas Lusa")
                Return False
                Exit Function
            End If
        End If

        Return True

    End Function

    Public Sub GenerarColummnaDataTable_Contenedor()
        dtdetalleArticuloPrincipal = New DataTable
        dtdetalleArticuloPrincipal.Columns.Add("ITEM_PRODUCTO", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("VCTO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("PRODUCTO", Type.GetType("System.String"))
    End Sub

    Public Sub GenerarColummnaDataTable_Contenedor_ME()
        dtdetalleArticuloPrincipal_ME = New DataTable
        dtdetalleArticuloPrincipal_ME.Columns.Add("ITEM_PRODUCTO", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal_ME.Columns.Add("ITEM", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal_ME.Columns.Add("PART_ID", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_ME.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_ME.Columns.Add("PART_UNIT", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_ME.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
        dtdetalleArticuloPrincipal_ME.Columns.Add("PRODUCTO", Type.GetType("System.String"))
    End Sub

    Public Sub GenerarColummnaDataTable_Puente()
        dtdetalleArticuloPrincipal_Puente = New DataTable
        dtdetalleArticuloPrincipal_Puente.Columns.Add("ITEM_PRODUCTO", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal_Puente.Columns.Add("ITEM", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal_Puente.Columns.Add("LOTE", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_Puente.Columns.Add("VCTO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_Puente.Columns.Add("PRODUCTO", Type.GetType("System.String"))
        dgv_lotes.DataSource = Nothing
        dgv_lotes.DataSource = dtdetalleArticuloPrincipal_Puente

        dgv_lotes.Columns(0).Visible = False
        dgv_lotes.Columns(1).HeaderText = "Item"
        dgv_lotes.Columns(2).HeaderText = "Lote"
        dgv_lotes.Columns(3).HeaderText = "Vencimiento"
        dgv_lotes.Columns(4).Visible = False
        dgv_lotes.AutoResizeColumns()
        dgv_lotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Public Sub GenerarColummnaDataTable_Puente_ME()
        dtdetalleArticuloPrincipal_Puente_ME = New DataTable
        dtdetalleArticuloPrincipal_Puente_ME.Columns.Add("ITEM_PRODUCTO", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal_Puente_ME.Columns.Add("ITEM", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal_Puente_ME.Columns.Add("PART_ID", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_Puente_ME.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_Puente_ME.Columns.Add("PART_UNIT", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_Puente_ME.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
        dtdetalleArticuloPrincipal_Puente_ME.Columns.Add("PRODUCTO", Type.GetType("System.String"))

        dgv_me.DataSource = Nothing
        dgv_me.DataSource = dtdetalleArticuloPrincipal_Puente_ME

        dgv_me.Columns(0).Visible = False
        dgv_me.Columns(1).HeaderText = "Item"
        dgv_me.Columns(2).HeaderText = "Codigo"
        dgv_me.Columns(3).HeaderText = "Descripción"
        dgv_me.Columns(4).HeaderText = "Unidad"
        dgv_me.Columns(5).HeaderText = "Cantidad"
        dgv_me.Columns(6).Visible = False

        dgv_me.AutoResizeColumns()
        dgv_me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgv_lotes.RowCount = 0 Then Exit Sub
        If dgv_lotes.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            EliminandoLote()
        End If
    End Sub
    Private Sub EliminandoLote()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgv_lotes.Item(1, dgv_lotes.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticuloPrincipal_Puente.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal_Puente.AcceptChanges()
            Next
            RehacerSecuencia_Lotes()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RehacerSecuencia_Lotes()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal_Puente.Rows
            i += 1
            dtdetalleArticuloPrincipal_Puente.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal_Puente.EndInit()
            dtdetalleArticuloPrincipal_Puente.AcceptChanges()
        Next
    End Sub

    Private Sub txt_lote_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_lote.KeyDown
        If e.KeyCode = Keys.F1 Then
            Mostrando_Lotes()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_lote.Text = String.Empty Then
                Mostrando_Lotes()
            Else
                btn_add.Focus()
            End If
        End If
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtobservacion.Focus()
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

    Private Sub rb_muestramedica_CheckedChanged(sender As Object, e As EventArgs) Handles rb_muestramedica.CheckedChanged
        If rb_muestramedica.Checked And _Flag_edicion = False Then
            txtobservacion.Text = "MUESTRA MÉDICA" + vbCrLf
            txtobservacion.Text = txtobservacion.Text & "CANTIDAD REDUCIDA" + vbCrLf
            txtobservacion.Text = txtobservacion.Text & "PROHIBIDA SU VENTA" + vbCrLf
            rb_estadoperuano.Checked = False
            rb_estadoperuano_pv.Checked = False
        ElseIf rb_muestramedica.Checked = False Then
            txtobservacion.Text = ""
            rb_estadoperuano.Checked = False
            rb_estadoperuano_pv.Checked = False
        End If
    End Sub

    Private Sub rb_estadoperuano_CheckedChanged(sender As Object, e As EventArgs) Handles rb_estadoperuano.CheckedChanged
        If rb_estadoperuano.Checked And _Flag_edicion = False Then
            txtobservacion.Text = "ESTADO PERUANO"
            rb_muestramedica.Checked = False
            rb_estadoperuano_pv.Checked = False
        ElseIf rb_estadoperuano.Checked = False Then
            txtobservacion.Text = ""
            rb_muestramedica.Checked = False
            rb_estadoperuano_pv.Checked = False
        End If
    End Sub

    Private Sub rb_estadoperuano_pv_CheckedChanged(sender As Object, e As EventArgs) Handles rb_estadoperuano_pv.CheckedChanged
        If rb_estadoperuano_pv.Checked And _Flag_edicion = False Then
            txtobservacion.Text = "ESTADO PERUANO" + vbCrLf
            txtobservacion.Text = txtobservacion.Text & "COMPRA CORPORATIVA"
            rb_muestramedica.Checked = False
            rb_estadoperuano.Checked = False
        ElseIf rb_estadoperuano_pv.Checked = False Then
            txtobservacion.Text = ""
            rb_muestramedica.Checked = False
            rb_estadoperuano.Checked = False
        End If
    End Sub

    Private Sub txt_cod_me_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_me.MouseDoubleClick
        MostrandoArticulos()
    End Sub

    Private Sub txt_cod_me_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_me.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_me.Text = String.Empty Then
                MostrandoArticulos()
            Else
                txt_cantidad.Select()
            End If
        End If
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add_me_Click(sender, e)
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


    Private Sub btn_add_me_Click(sender As Object, e As EventArgs) Handles btn_add_me.Click
        Try
            If Validacion_Ingreso_ME() = False Then Exit Sub
            If dtdetalleArticuloPrincipal_Puente_ME.Rows.Count > 0 Then
                If dtdetalleArticuloPrincipal_Puente_ME.Rows.Count > 0 Then
                    For Each rows As DataRow In dtdetalleArticuloPrincipal_Puente_ME.Select("PART_ID='" & txt_cod_me.Text.Trim & "' ")
                        MsgBox("El Material de Empaque ya se encuentra adjuntado.", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Try
                    Next
                End If
            End If

            Dim row As DataRow = dtdetalleArticuloPrincipal_Puente_ME.NewRow
            If _Flag_edicion = False Then
                row("ITEM_PRODUCTO") = dtdetallePrincipal.Rows.Count + 1
            Else
                row("ITEM_PRODUCTO") = _Codigo_Ini
            End If

            row("ITEM") = dtdetalleArticuloPrincipal_Puente_ME.Rows.Count() + 1
            row("PART_ID") = txt_cod_me.Text.Trim
            row("PART_DESCRIPTION") = txt_des_me.Text.Trim
            row("PART_UNIT") = txt_un_me.Text.Trim
            row("CANTIDAD") = CDbl(txt_cantidad.Text)
            row("PRODUCTO") = txt_producto.Text.Trim
            dtdetalleArticuloPrincipal_Puente_ME.Rows.Add(row)
            dtdetalleArticuloPrincipal_Puente_ME.AcceptChanges()
            txt_cod_me.Text = String.Empty
            txt_des_me.Text = String.Empty
            txt_un_me.Text = String.Empty
            txt_cantidad.Text = String.Empty
            txt_cod_me.Focus()
            dgv_me.DataSource = dtdetalleArticuloPrincipal_Puente_ME

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Del_me_Click(sender As Object, e As EventArgs) Handles btn_Del_me.Click
        If dgv_me.RowCount = 0 Then Exit Sub
        If dgv_me.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            EliminandoMe()
        End If
    End Sub

    Private Sub EliminandoMe()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgv_me.Item(1, dgv_me.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticuloPrincipal_Puente_ME.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal_Puente_ME.AcceptChanges()
            Next
            RehacerSecuencia_ME()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia_ME()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal_Puente_ME.Rows
            i += 1
            dtdetalleArticuloPrincipal_Puente_ME.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal_Puente_ME.EndInit()
            dtdetalleArticuloPrincipal_Puente_ME.AcceptChanges()
        Next
    End Sub

    Private Sub txt_producto_rs_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_producto_rs.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Reg_Sanit()
        If e.KeyCode = Keys.Enter Then
            If txt_producto_rs.Text = String.Empty Then
                Mostrando_Reg_Sanit()
            Else
                txt_cod_me.Select()
            End If
        End If
    End Sub

    Private Sub txt_producto_rs_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_producto_rs.MouseDoubleClick
        Mostrando_Reg_Sanit()
    End Sub
End Class