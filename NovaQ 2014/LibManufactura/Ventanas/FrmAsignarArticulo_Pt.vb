Imports System.Windows.Forms
Imports LibCobranzas


Public Class FrmAsignarArticulo_Pt

    Public AlmacenOrigen As String
    Public MonedaOrigen As String
    Public EstadoOrigen As Boolean = False
    Public _id_item As String
    Public _costo_unitario As Double

    Public TipoDocumento As String
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE

    Dim dtDocumentoGuias As DataTable
    Dim dtlote As DataTable
    Dim dtDescuentos As DataTable
    Public dtdetalleArticulo As DataTable
    Public dtdetalleArticulo_costos_varios As DataTable
    'Public ValidacionLotes As String = String.Empty
    Public Flag_Modo_Edicion As Boolean = False
    ''Producccion
    Public TIPO_FORMULA = String.Empty
    Public TIPO_PROD As String = String.Empty
    Dim ManufacturaBl As ClsOperaciones.FORMULATION
    Public fl_close As Boolean = False
    Dim flag_modifica_obs As Boolean = False
    Dim Item_Detalle As Integer
    Dim _costo_total_formula As Double

    Private Sub FrmAsignarArticulo_Pt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ayuda_Unidad_Medida()
        If Flag_Modo_Edicion = True Then
            ModoEdicion()
            Calcula_Costo_Varios_Total()
            flag_modifica_obs = False
            Item_Detalle = 0
        Else
            GenerarColummnaDataTable()
            GenerarColummnaDataTable_Costos_Varios()

            flag_modifica_obs = False
            Item_Detalle = 0
            txtcodigoArticulo.Focus()
        End If
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If txtcodigoArticulo.Text = String.Empty Then
                MsgBox("Debe seleccionar o ingresar el codigo de un Articulo.", MsgBoxStyle.Exclamation)
                txtcodigoArticulo.Focus()
                estado = False
                Exit Try
            ElseIf txt_costo_unitario.Text = String.Empty Then
                MsgBox("Debe ingresar un costo unitario.", MsgBoxStyle.Exclamation)
                estado = False
                txt_costo_unitario.Focus()
                Exit Try
            ElseIf txt_cantidad.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Exclamation)
                estado = False
                txt_cantidad.Focus()
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidacionesGenerales() = False Then Exit Sub
        If Flag_Modo_Edicion = False Then
            'Agregando los datos a devolver
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("PART_ID") = txtcodigoArticulo.Text
            row("DESCRIPTION") = txtdescripcionArticulo.Text
            row("UNIT") = cbounidadMedida.SelectedValue
            row("CANTIDAD") = If(txt_cantidad.Text = String.Empty, 0, txt_cantidad.Text)
            row("COSTO_UNITARIO") = If(txt_costo_unitario.Text = String.Empty, 0, txt_costo_unitario.Text)
            row("COSTOS_VARIOS") = If(txt_costos_varios.Text = String.Empty, 0, txt_costos_varios.Text)
            row("SUB_TOTAL") = If(txt_subtotal.Text = String.Empty, 0, txt_subtotal.Text)
            row("IGV") = If(txt_igv.Text = String.Empty, 0, txt_igv.Text)
            row("COSTO_FINAL") = If(txt_costo_final.Text = String.Empty, 0, txt_costo_final.Text)

            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        Else
            'Agregando los datos a devolver
            GenerarColummnaDataTable()
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = _id_item 'dtdetalleArticulo.Rows.Count() + 1
            row("PART_ID") = txtcodigoArticulo.Text
            row("DESCRIPTION") = txtdescripcionArticulo.Text
            row("UNIT") = cbounidadMedida.SelectedValue
            row("CANTIDAD") = If(txt_cantidad.Text = String.Empty, 0, txt_cantidad.Text)
            row("COSTO_UNITARIO") = If(txt_costo_unitario.Text = String.Empty, 0, txt_costo_unitario.Text)
            row("COSTOS_VARIOS") = If(txt_costos_varios.Text = String.Empty, 0, txt_costos_varios.Text)
            row("SUB_TOTAL") = If(txt_subtotal.Text = String.Empty, 0, txt_subtotal.Text)
            row("IGV") = If(txt_igv.Text = String.Empty, 0, txt_igv.Text)
            row("COSTO_FINAL") = If(txt_costo_final.Text = String.Empty, 0, txt_costo_final.Text)
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        End If
        Me.Close()
    End Sub



    Private Sub txtcodigoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            txtcodigoArticulo.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub



    Private Sub txtcantidadPractica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_costo_unitario.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        '------
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidadteorica_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        '------
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        '------
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub cbounidadMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbounidadMedida.SelectedIndexChanged
        If cbounidadMedida.DataSource Is Nothing Then Exit Sub
        If cbounidadMedida.SelectedIndex <> -1 Then
            'Ayuda_Unidad_Medida_Equivalencia()
        End If
    End Sub
    Private Sub txtexceso_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    
    Private Sub txtcantidadPractica_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_costo_unitario.KeyDown

        If e.KeyCode = Keys.Enter Then
            txt_costos_varios.Focus()
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        fl_close = True
        Me.Close()
    End Sub

    Public Sub GenerarColummnaDataTable_Costos_Varios()
        Try
            dtdetalleArticulo_costos_varios = New DataTable
            dtdetalleArticulo_costos_varios.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticulo_costos_varios.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticulo_costos_varios.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticulo_costos_varios.Columns.Add("COSTO_UNITARIO", Type.GetType("System.Double"))

            dtdetalleArticulo_costos_varios.PrimaryKey = New DataColumn() {dtdetalleArticulo_costos_varios.Columns("ITEM")}

            dgvDetalle_costosvarios.DataSource = Nothing
            dgvDetalle_costosvarios.DataSource = dtdetalleArticulo_costos_varios

            dgvDetalle_costosvarios.Columns(0).HeaderText = "Item"
            dgvDetalle_costosvarios.Columns(1).HeaderText = "Codigo"
            dgvDetalle_costosvarios.Columns(2).HeaderText = "Descripción"
            dgvDetalle_costosvarios.Columns(3).HeaderText = "Costo"

            dgvDetalle_costosvarios.Columns(3).DefaultCellStyle.Format = "N4"
            dgvDetalle_costosvarios.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvDetalle_costosvarios.AutoResizeColumns()
            dgvDetalle_costosvarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticulo.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("COSTO_UNITARIO", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("COSTOS_VARIOS", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("SUB_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("IGV", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("COSTO_FINAL", Type.GetType("System.Double"))

            dtdetalleArticulo.PrimaryKey = New DataColumn() {dtdetalleArticulo.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoArticulos()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "CTR_SP_S_ARTICULO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = AlmacenOrigen
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                cbounidadMedida.SelectedValue = frm.Data_Matriz.Rows(0).Item("UNIDAD").ToString

            End If
            frm.Close()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            ManufacturaBl = New ClsOperaciones.FORMULATION
            dtDocumentoGuias = New DataTable("Part_Manufactura")
            Dim Stock As Double = 0.0
            dtDocumentoGuias = ManufacturaBl.Mostrar_Articulo_Manual(AlmacenOrigen, _codigoArticulo)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                codArticulo = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                cbounidadMedida.SelectedValue = dtDocumentoGuias.Rows(0).Item("UNIDAD").ToString
            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
                txtcodigoArticulo.Text = String.Empty
                txtdescripcionArticulo.Text = String.Empty
                txtcodigoArticulo.Focus()
            End If
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
                txt_cantidad.Select()
            End If

        End If
    End Sub

    Private Sub ModoEdicion()
        Try
            'Obteniendo los datos para Mostrarlos
            If dtdetalleArticulo.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtdetalleArticulo.Rows.Count() - 1
                    txt_cantidad.Text = dtdetalleArticulo.Rows(i).Item("CANTIDAD").ToString
                    txt_costo_unitario.Text = dtdetalleArticulo.Rows(i).Item("COSTO_UNITARIO").ToString
                    txt_costos_varios.Text = dtdetalleArticulo.Rows(i).Item("COSTOS_VARIOS").ToString
                    txt_subtotal.Text = dtdetalleArticulo.Rows(i).Item("SUB_TOTAL").ToString
                    txt_igv.Text = dtdetalleArticulo.Rows(i).Item("IGV").ToString
                    txt_costo_final.Text = dtdetalleArticulo.Rows(i).Item("COSTO_FINAL").ToString
                    AgregarArticuloManual(dtdetalleArticulo.Rows(i).Item("PART_ID").ToString)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos()
    End Sub

    Private Sub Ayuda_Unidad_Medida()
        Try
            ManufacturaBl = New ClsOperaciones.FORMULATION
            Dim dtUnidad As New DataTable
            dtUnidad = ManufacturaBl.UnidadesReferencia()
            If dtUnidad.Rows.Count() <> 0 Then
                cbounidadMedida.ValueMember = "CODIGO"
                cbounidadMedida.DisplayMember = "DESCRIPCION"
                cbounidadMedida.DataSource = dtUnidad
            Else
                MsgBox("No hay Unidades para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_costo_final.KeyPress, txt_igv.KeyPress, txt_subtotal.KeyPress, txt_costos_varios.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_costos_varios_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_costos_varios.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_subtotal.Focus()
        End If
    End Sub

    Private Sub txt_subtotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_subtotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_igv.Focus()
        End If
    End Sub

    Private Sub txt_igv_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_igv.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_costo_final.Focus()
        End If
    End Sub

    Private Sub txt_costo_final_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_costo_final.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub txt_costo_unitario_Leave(sender As Object, e As EventArgs) Handles txt_costo_unitario.Leave
        If txt_costo_unitario.Text = "" Then Exit Sub
        If txt_costos_varios.Text = "" Then Exit Sub
        txt_subtotal.Text = CDbl(txt_costo_unitario.Text) + CDbl(txt_costos_varios.Text)
        txt_costo_unitario.Text = Format(CDbl(txt_costo_unitario.Text), "##,##0.000")
    End Sub

    Private Sub txt_costos_varios_Leave(sender As Object, e As EventArgs) Handles txt_costos_varios.Leave
        If txt_costos_varios.Text = "" Then Exit Sub
        If txt_costo_unitario.Text = "" Then Exit Sub
        txt_subtotal.Text = CDbl(txt_costo_unitario.Text) + CDbl(txt_costos_varios.Text)
        txt_costos_varios.Text = Format(CDbl(txt_costos_varios.Text), "##,##0.000")
    End Sub

    Private Sub txt_subtotal_Leave(sender As Object, e As EventArgs) Handles txt_subtotal.Leave
        If txt_subtotal.Text = "" Then Exit Sub
        txt_igv.Text = Math.Round(CDbl(txt_subtotal.Text) * 0.18, 6)
        txt_subtotal.Text = Format(CDbl(txt_subtotal.Text), "##,##0.000")
    End Sub

    Private Sub txt_igv_Leave(sender As Object, e As EventArgs) Handles txt_igv.Leave
        If txt_igv.Text = "" Then Exit Sub
        If txt_subtotal.Text = "" Then Exit Sub
        txt_costo_final.Text = Math.Round(CDbl(txt_subtotal.Text) + CDbl(txt_igv.Text), 6)
        txt_igv.Text = Format(CDbl(txt_igv.Text), "##,##0.000")
        txt_costo_final.Text = Format(CDbl(txt_costo_final.Text), "##,##0.000")
    End Sub

    Private Sub txt_costo_costos_varios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_costo_costos_varios.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_costos_varios_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_costos_varios.MouseDoubleClick
        MostrandoArticulos_EE()
    End Sub

    Private Sub txt_cod_costos_varios_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_costos_varios.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos_EE()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_costos_varios.Text = String.Empty Then
                MostrandoArticulos_EE()
            Else
                txt_costo_costos_varios.Select()
            End If
        End If
    End Sub

    Private Sub MostrandoArticulos_EE()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "CTR_SP_S_ARTICULO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = AlmacenOrigen
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_costos_varios.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_des_costos_varios.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString

                Stock = frm.Data_Matriz.Rows(0).Item("COSTO_MN").ToString
                txt_costo_costos_varios.Text = Format(Stock, "##,##0.000")
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If Validacion_Ingreso_Costos_varios() = False Then Exit Sub
            If dtdetalleArticulo_costos_varios.Rows.Count > 0 Then
                If flag_modifica_obs = False Then
                    For Each rows As DataRow In dtdetalleArticulo_costos_varios.Select("PART_ID='" & txt_cod_costos_varios.Text.Trim & "' ")
                        MsgBox("El concepto de gastos ya se encuentra adjuntado.", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Try
                    Next
                End If

            End If

            If flag_modifica_obs = False Then ' crea nuevo detalle
                Dim row As DataRow = dtdetalleArticulo_costos_varios.NewRow
                row("ITEM") = dtdetalleArticulo_costos_varios.Rows.Count() + 1
                row("PART_ID") = txt_cod_costos_varios.Text.Trim
                row("DESCRIPTION") = txt_des_costos_varios.Text.Trim
                row("COSTO_UNITARIO") = txt_costo_costos_varios.Text.Trim
                dtdetalleArticulo_costos_varios.Rows.Add(row)
                dtdetalleArticulo_costos_varios.AcceptChanges()
                txt_cod_costos_varios.Text = String.Empty
                txt_des_costos_varios.Text = String.Empty
                txt_costo_costos_varios.Text = String.Empty
                txt_cod_costos_varios.Focus()
                dgvDetalle_costosvarios.DataSource = dtdetalleArticulo_costos_varios
                flag_modifica_obs = False
            ElseIf flag_modifica_obs = True Then
                For Each row As DataRow In dtdetalleArticulo_costos_varios.Select("ITEM=" & Item_Detalle)
                    dtdetalleArticulo_costos_varios.BeginInit()
                    row("PART_ID") = txt_cod_costos_varios.Text.Trim
                    row("DESCRIPTION") = txt_des_costos_varios.Text.Trim
                    row("COSTO_UNITARIO") = txt_costo_costos_varios.Text.Trim
                    dtdetalleArticulo_costos_varios.EndInit()
                    dtdetalleArticulo_costos_varios.AcceptChanges()
                Next

                txt_cod_costos_varios.Text = String.Empty
                txt_des_costos_varios.Text = String.Empty
                txt_costo_costos_varios.Text = String.Empty
                txt_cod_costos_varios.Focus()
                dgvDetalle_costosvarios.DataSource = dtdetalleArticulo_costos_varios
                flag_modifica_obs = False
                btn_up.Enabled = True
                btn_del.Enabled = True
            End If

            Calcula_Costo_Varios_Total()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Calcula_Costo_Varios_Total()
        If dtdetalleArticulo_costos_varios.Rows.Count > 0 Then
            _costo_total_formula = dtdetalleArticulo_costos_varios.Compute("sum(COSTO_UNITARIO)", "")
        Else
            _costo_total_formula = 0
        End If

        txt_costos_varios.Text = Format(_costo_total_formula, "##,##0.000")
        If txt_costo_unitario.Text = "" Then txt_costo_unitario.Text = "0"
        If txt_costos_varios.Text = "" Then txt_costos_varios.Text = "0"

        txt_subtotal.Text = CDbl(txt_costo_unitario.Text) + CDbl(txt_costos_varios.Text)
        If txt_subtotal.Text = "" Then txt_subtotal.Text = "0"
        txt_igv.Text = Math.Round(CDbl(txt_subtotal.Text) * 0.18, 6)

        If txt_igv.Text = "" Then txt_igv.Text = "0"
        txt_costo_final.Text = Math.Round(CDbl(txt_subtotal.Text) + CDbl(txt_igv.Text), 6)

        txt_costo_unitario.Text = Format(CDbl(txt_costo_unitario.Text), "##,##0.000")
        txt_subtotal.Text = Format(CDbl(txt_subtotal.Text), "##,##0.000")
        txt_igv.Text = Format(CDbl(txt_igv.Text), "##,##0.000")
        txt_costo_final.Text = Format(CDbl(txt_costo_final.Text), "##,##0.000")

    End Sub

    Function Validacion_Ingreso_Costos_varios() As Boolean

        If txt_cod_costos_varios.Text.Trim = "" Then
            MsgBox("Debe elegir concepto de Gasto.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cod_costos_varios.Focus()
            Return False
            Exit Function
        End If

        If txt_costo_costos_varios.Text.Trim = "" Then txt_costo_costos_varios.Text = "0"


        Return True

    End Function

    Private Sub txt_costo_costos_varios_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_costo_costos_varios.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add_Click(sender, e)
        End If
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If dgvDetalle_costosvarios.RowCount() = 0 Then Exit Sub
        If dgvDetalle_costosvarios.CurrentRow Is Nothing Then Exit Sub

        Item_Detalle = dgvDetalle_costosvarios.CurrentRow.Cells("ITEM").Value

        For Each item As DataRow In dtdetalleArticulo_costos_varios.Select("ITEM=" & Item_Detalle)
            Dim Stock As Double = 0
            txt_cod_costos_varios.Text = item("PART_ID")
            txt_des_costos_varios.Text = item("DESCRIPTION")
            Stock = item("COSTO_UNITARIO")
            txt_costo_costos_varios.Text = Format(Stock, "##,##0.000")
            flag_modifica_obs = True
            btn_up.Enabled = False
            btn_del.Enabled = False
        Next
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgvDetalle_costosvarios.RowCount = 0 Then Exit Sub
        If dgvDetalle_costosvarios.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            EliminandoArticulo_Costos_varios()
        End If
        Calcula_Costo_Varios_Total()
    End Sub

    Private Sub EliminandoArticulo_Costos_varios()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgvDetalle_costosvarios.Item(0, dgvDetalle_costosvarios.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticulo_costos_varios.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticulo_costos_varios.AcceptChanges()
            Next
            RehacerSecuencia_Costos_Varios()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RehacerSecuencia_Costos_Varios()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticulo_costos_varios.Rows
            i += 1
            dtdetalleArticulo_costos_varios.BeginInit()
            items("ITEM") = i
            dtdetalleArticulo_costos_varios.EndInit()
            dtdetalleArticulo_costos_varios.AcceptChanges()
        Next
    End Sub

    Private Sub txt_cod_formula_ee_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_formula_ee.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Formulas()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_formula_ee.Text = "" Then
                Ayuda_Formulas()
            End If
        End If
    End Sub

    Private Sub txt_cod_formula_ee_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_formula_ee.MouseDoubleClick
        Ayuda_Formulas()
    End Sub

    Private Sub Ayuda_Formulas()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "MANUFAC_SP_S_FORMULATION_EE"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Formulas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_formula_ee.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_des_formula_ee.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            Consultar_Formula(txt_cod_formula_ee.Text)
        End If
        frm.Close()
    End Sub

    Private Sub Consultar_Formula(ByVal _codigo As String)
        Try
            ''cabecera
            ManufacturaBl = New ClsOperaciones.FORMULATION
            GenerarColummnaDataTable_Costos_Varios()
            dtdetalleArticulo_costos_varios = ManufacturaBl.Modo_Edicion_Detalle_Formula_EE(_codigo, "")
            If dtdetalleArticulo_costos_varios.Rows.Count() <> 0 Then
                Calcula_Costo_Varios_Total()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cantidad_Leave(sender As Object, e As EventArgs) Handles txt_cantidad.Leave
        txt_costo_unitario.Text = "0"
        If txt_cantidad.Text = "" Then txt_cantidad.Text = "0"
        If CDbl(txt_cantidad.Text) = 0 Then Exit Sub

        txt_costo_unitario.Text = Format((_costo_unitario / CDbl(txt_cantidad.Text)), "##,##0.000")

        If txt_factor.Text = "" Then txt_factor.Text = "0"
        If CDbl(txt_factor.Text) = 0 Then Exit Sub

        txt_costo_unitario.Text = Format((CDbl(txt_costo_unitario.Text) / CDbl(txt_factor.Text)), "##,##0.000")
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

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_factor.Focus()
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles txt_factor.Leave
        'If txt_costo_unitario.Text = "" Then txt_costo_unitario.Text = "0"
        'If txt_factor.Text = "" Then Exit Sub

        'txt_costo_unitario.Text = Format((CDbl(txt_costo_unitario.Text) / CDbl(txt_factor.Text)), "##,##0.0000")
        txt_costo_unitario.Text = "0"

        If txt_cantidad.Text = "" Then txt_cantidad.Text = "0"
        If CDbl(txt_cantidad.Text) = 0 Then Exit Sub

        txt_costo_unitario.Text = Format((_costo_unitario / CDbl(txt_cantidad.Text)), "##,##0.000")

        If txt_factor.Text = "" Then txt_factor.Text = "0"
        If CDbl(txt_factor.Text) = 0 Then Exit Sub

        txt_costo_unitario.Text = Format((CDbl(txt_costo_unitario.Text) / CDbl(txt_factor.Text)), "##,##0.000")
    End Sub

    Private Sub txt_factor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_factor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_costos_varios.Focus()
        End If
    End Sub

    Private Sub txt_factor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_factor.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class