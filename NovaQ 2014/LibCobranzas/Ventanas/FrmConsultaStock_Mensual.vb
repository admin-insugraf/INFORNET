Imports LibComunVar
Imports System.Windows.Forms

Public Class FrmConsultaStock_Mensual
    Dim clsBusquedaBl As ClsBuscar
    Dim ArticuloBl As ClsNegocio.PART
    Dim dtAlmacen As DataTable
    Dim dtdetalles As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Private Sub FrmConsultaStock_Mensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MostrandoAlmacenes()
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(DateAdd("YYYY", -1, ClsVarComun.FechaSistema))
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)

    End Sub

    Private Sub Mostrando_Transacciones(ByVal _tipo As String)
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_Mostrar_Transacciones(_tipo)
            If dtAlmacen.Rows.Count() <> 0 Then
                chklstTransacciones.Items.Clear()
                For i As Integer = 0 To dtAlmacen.Rows.Count() - 1
                    chklstTransacciones.Items.Add(dtAlmacen.Rows(i).Item("DESCRIPCION").ToString)
                Next
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then Exit Sub

        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            STRorden = dgvConsulta.Columns(0).Name
            dtv.RowFilter = STRorden & " like '" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvConsulta.Columns(0).Name
                dtv.RowFilter = STRorden & " like '" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvConsulta.Columns(1).Name
                    dtv.RowFilter = STRorden & " like '" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvConsulta.Columns(0).Name & "+" & dgvConsulta.Columns(1).Name ' & "+" & dgvConsulta.Columns(2).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub btn_ImprimirPlanilla_Click(sender As Object, e As EventArgs) Handles btn_ImprimirPlanilla.Click
        Try
            If rdb_ingreso.Checked = False And rdb_salida.Checked = False Then
                MsgBox("Debe elegir una opción.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe elegir un almacen correcto.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If chklstTransacciones.CheckedItems.Count() = 0 Then
                MsgBox("Debe seleccionar al menos una Transacción.", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            Dim i As Integer = 0
            Dim lista_transacciones As String = ""

            Do While i <= chklstTransacciones.CheckedItems.Count - 1
                lista_transacciones = lista_transacciones & """" & TraerCodigo(chklstTransacciones.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop

            lista_transacciones = Mid(lista_transacciones, 1, lista_transacciones.Trim.Length - 1)

            Cargar_Datos(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), lista_transacciones, _
                         IIf(rdb_ingreso.Checked, "I", IIf(rdb_salida.Checked, "S", "")))

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_RetornarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(SELECCIONE UN ALMACEN)"
            dtAlmacen.Rows.InsertAt(row, 0)
            If dtAlmacen.Rows.Count() <> 0 Then
                cboAlmacen.DisplayMember = "DESCRIPCION"
                cboAlmacen.ValueMember = "CODIGO"
                cboAlmacen.DataSource = dtAlmacen
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Datos(ByVal _fecha_inicial As String, ByVal _fecha_final As String, ByVal _transacciones As String, ByVal _opcion As String)
        Try
            ArticuloBl = New ClsNegocio.PART
            dtdetalles = New DataTable("Articulos")
            dtv = New DataView
            Dim ListaAlmacen As List(Of String)
            If cboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un Almacen.", MsgBoxStyle.Information)
                cboAlmacen.Focus()
                Exit Sub
            End If
            ListaAlmacen = New List(Of String)
            ListaAlmacen.Add(cboAlmacen.SelectedValue.ToString)

            Me.Cursor = Cursors.WaitCursor
            dtdetalles = ArticuloBl.RetornarStockProductos_Anual(ListaAlmacen, 0, _fecha_inicial, _fecha_final, _transacciones, _opcion)
            If dtdetalles.Rows.Count() <> 0 Then
                dtv = dtdetalles.DefaultView
                dgvConsulta.DataSource = dtv
                dgvConsulta.Columns("CODIGO").Width = 60
                dgvConsulta.Columns("DESCRIPCION").Width = 300
                dgvConsulta.Columns("UNIDAD").Width = 50

                For i As Integer = 3 To dgvConsulta.Columns.Count - 1
                    dgvConsulta.Columns(i).Width = 100
                    dgvConsulta.Columns(i).DefaultCellStyle.Format = "N4"
                    dgvConsulta.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Next

                dgvConsulta.Columns("CODIGO").HeaderText = "Codigo"
                dgvConsulta.Columns("DESCRIPCION").HeaderText = "Descripción"
                dgvConsulta.Columns("UNIDAD").HeaderText = "Unidad"
                'dgvConsulta.Columns("PROMEDIO").HeaderText = "Promedio"
                dgvConsulta.Columns("STOCK").HeaderText = "Stock"
                'dgvConsulta.Columns("Existencia_x_recibir_importacion").HeaderText = "Exis. por Recibir de Importación"
                'dgvConsulta.Columns("Numeros_Importacion").HeaderText = "N° de Orden(es)"

                dgvConsulta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                STRorden = dgvConsulta.Columns("CODIGO").Name & "+" & dgvConsulta.Columns("DESCRIPCION").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                ArticuloBl = Nothing
            Else
                dgvConsulta.DataSource = Nothing
                STRorden = ""
                lblCantidad.Text = "Se encontraron 0 registros"
                MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
            'lblmensaje.Visible = False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub rdb_producto_CheckedChanged(sender As Object, e As EventArgs)
        dgvConsulta.DataSource = Nothing
        txtFiltro.Text = ""
        STRorden = ""
    End Sub

    Private Sub rdb_concepto_CheckedChanged(sender As Object, e As EventArgs)
        dgvConsulta.DataSource = Nothing
        txtFiltro.Text = ""
        STRorden = ""
    End Sub

    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen.CheckedChanged
        chklstTransacciones.Enabled = Not checkAlmacen.Checked
        Dim i As Integer = 0
        Do While i <= chklstTransacciones.Items.Count - 1
            chklstTransacciones.SetItemChecked(i, checkAlmacen.Checked)
            i = i + 1
        Loop
    End Sub

    Private Sub rdb_ingreso_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_ingreso.CheckedChanged
        If rdb_ingreso.Checked Then
            Mostrando_Transacciones("I")
        End If
    End Sub

    Private Sub rdb_salida_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_salida.CheckedChanged
        If rdb_salida.Checked Then
            Mostrando_Transacciones("S")
        End If
    End Sub

    Private Sub VerOrdenDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerOrdenDeCompraToolStripMenuItem.Click
        If dgvConsulta.CurrentRow Is Nothing Then Exit Sub
        If dgvConsulta.Rows.Count = 0 Then Exit Sub

        Dim fr As New FrmConsultaStock_Mensual_OrdenImportacion
        fr._codigo_producto = dgvConsulta.CurrentRow.Cells("CODIGO").Value
        fr.ShowDialog()
    End Sub
End Class