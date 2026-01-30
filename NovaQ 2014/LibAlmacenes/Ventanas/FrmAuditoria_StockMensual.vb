Imports LibComunVar
Imports System.Windows.Forms
Imports System.Drawing
Public Class FrmAuditoria_StockMensual
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable
    Dim dtReporteKardex As DataTable

    Private _NombreReporte As String

    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtProveedorPrincipal As DataTable
    Dim dtDocumentosProv As New DataTable
    Private dtv_proveedor As DataView
    Private STRorden_proveedor As String
    Private Sub FrmAuditoria_StockMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        MostrandoAlmacenes()
        dtpfechaInicio.Focus()
    End Sub

    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_MostrarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            If dtAlmacen.Rows.Count() <> 0 Then
                chklstAlmacenes.Items.Clear()
                For i As Integer = 0 To dtAlmacen.Rows.Count() - 1
                    chklstAlmacenes.Items.Add(dtAlmacen.Rows(i).Item("DESCRIPCION").ToString)
                Next
                'chklstAlmacenes.SelectedIndex = 1
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarticuloInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarticuloInicial.MouseDoubleClick
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_FAMILIA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarticuloInicial.Text = frm.Data_Matriz.Rows(0).Item(0)
                txtfamiliadesc.Text = frm.Data_Matriz.Rows(0).Item(1)
                txt_tipo_articulo.Text = ""
                txt_des_tipo_articulo.Text = ""
                txt_tipo_articulo.Focus()
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarticuloInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticuloInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtarticuloInicial_MouseDoubleClick(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then
            txt_tipo_articulo.Focus()
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Refalma As String = String.Empty
        Dim reffechaINI As String = String.Empty
        Dim reffechaFIN As String = String.Empty
        Dim reffamilia As String = String.Empty
        Dim reftipo_Articulo As String = String.Empty
        Dim refopcion As String = String.Empty
        'Validaciones Generales
        If ValidacionesLotes(reffechaINI, reffechaFIN, reffamilia, reftipo_Articulo, refopcion) = False Then Exit Sub
        ''Mostrando Reportes 
        MostrarReportes(reffechaINI, reffechaFIN, reffamilia, reftipo_Articulo, refopcion)
    End Sub
    Private Function ValidacionesLotes(ByRef fechaINI As String,
                       ByRef fechaFIN As String, ByRef reffamilia As String, ByRef reftipo_articulo As String, ByRef ref_opcion As String) As Boolean
        Dim estado As Boolean = True
        Try
            If txtarticuloInicial.Text = "" Then
                MessageBox.Show("Debe seleccionar una Familia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtarticuloInicial.Focus()
                estado = False
                Exit Try
            End If
            If txt_tipo_articulo.Text = "" Then
                MessageBox.Show("Debe seleccionar un Tipo de Articulo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_tipo_articulo.Focus()
                estado = False
                Exit Try
            End If
            If chklstAlmacenes.CheckedItems.Count() = 0 Then
                MsgBox("Debe seleccionar al menos un Almacen.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
            If dgv_proveedor.Rows.Count = 0 Then
                MsgBox("Debe elegir al menos un Producto.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
            
            Me.Cursor = Cursors.WaitCursor
            reporteBL = New ClsReporteGenerales
            reporteBL.Crear_Lista_Productos()

            For I As Integer = 0 To dgv_proveedor.Rows.Count - 1
                reporteBL.Inserta_Lista_Productos(dgv_proveedor.Rows(I).Cells("ID").Value, dgv_proveedor.Rows(I).Cells("NAME").Value)
            Next

            fechaINI = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            fechaFIN = dtpfechafin.Value.ToString("dd/MM/yyyy")
            reffamilia = txtarticuloInicial.Text.Trim
            reftipo_articulo = txt_tipo_articulo.Text.Trim
            If rb_positvo.Checked Then ref_opcion = "P"
            If rb_negativo.Checked Then ref_opcion = "N"
            If rb_todos.Checked Then ref_opcion = "T"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
            Me.Cursor = Cursors.Default
        End Try
        Return estado
    End Function
    Public Sub MostrarReportes(ByVal fechaINI As String,
                       ByVal fechaFIN As String, ByVal reffamilia As String, ByVal reftipoarticulo As String,
                       ByVal ref_opcion As String)
        Try
            reporteBL = New ClsReporteGenerales
            crystalBL = New LibReportes.ClsReporte
            Dim lista As New List(Of String)
            Dim idAlmacen As String = String.Empty
            Dim i As Integer = 0
            Dim DT_NOM_EMPRESA As DataTable, NOMBRE_EMPRESA As String
            Me.Cursor = Cursors.WaitCursor
            lista = New List(Of String)
            Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                idAlmacen = idAlmacen & """" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idAlmacen.Length() <> 0 Then
                idAlmacen = Mid(idAlmacen, 1, idAlmacen.Length - 1)
            End If

            DT_NOM_EMPRESA = New DataTable
            DT_NOM_EMPRESA = reporteBL.Get_Nombre_Empresa()
            If DT_NOM_EMPRESA.Rows.Count > 0 Then
                NOMBRE_EMPRESA = DT_NOM_EMPRESA.Rows(0).Item("REPORT_SCREEN").ToString
            Else
                NOMBRE_EMPRESA = ""
            End If

            dtReporteKardex = New DataTable("articulo_todos")
            dtReporteKardex = reporteBL.Get_Rpt_Auditoria_Stock(fechaINI, fechaFIN, reffamilia, reftipoarticulo, ref_opcion, idAlmacen)
            If dtReporteKardex.Rows.Count() <> 0 Then
                If txt_tipo_articulo.Text.Trim = "01" Then
                    crystalBL.Muestra_Reporte("RPT_AUDITORIA_STOCK_MAT_PRIMA.rpt", dtReporteKardex, "", "", "FECHA_INICIAL;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "FECHA_FINAL;" & dtpfechafin.Value.ToString("dd/MM/yyyy"), "EMPRESA;" & NOMBRE_EMPRESA)
                ElseIf txt_tipo_articulo.Text.Trim <> "01" Then
                    crystalBL.Muestra_Reporte("RPT_AUDITORIA_STOCK.rpt", dtReporteKardex, "", "", "FECHA_INICIAL;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "FECHA_FINAL;" & dtpfechafin.Value.ToString("dd/MM/yyyy"), "EMPRESA;" & NOMBRE_EMPRESA)
                End If

            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub dtpfechaInicio_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpfechafin.Focus()
        End If
    End Sub

    Private Sub checkAlmacen_KeyDown(sender As Object, e As KeyEventArgs) Handles checkAlmacen.KeyDown
        If e.KeyCode = Keys.Enter Then
            chklstAlmacenes.Focus()
        End If
    End Sub

    Private Sub chklstAlmacenes_KeyDown(sender As Object, e As KeyEventArgs) Handles chklstAlmacenes.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnMostrar.Select()
        End If
    End Sub

    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen.CheckedChanged
        chklstAlmacenes.Enabled = Not checkAlmacen.Checked
        Dim i As Integer = 0
        Do While i <= chklstAlmacenes.Items.Count - 1
            chklstAlmacenes.SetItemChecked(i, checkAlmacen.Checked)
            i = i + 1
        Loop
    End Sub

    Private Sub TextBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tipo_articulo.MouseDoubleClick
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_TIPO_ARTICULO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Tipo de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_tipo_articulo.Text = frm.Data_Matriz.Rows(0).Item(0)
                txt_des_tipo_articulo.Text = frm.Data_Matriz.Rows(0).Item(1)
                MostrandoProductos()
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MostrandoProductos()

        Try
            Dim Cotizacionbl As New ClsBuscar
            dtv_proveedor = New DataView

            dtDocumentosProv = Cotizacionbl.Get_MostrarProductos_Ayuda(txtarticuloInicial.Text.Trim, txt_tipo_articulo.Text.Trim)
            dgv_lista_proveedor.DataSource = Nothing
            dtv_proveedor = dtDocumentosProv.DefaultView
            If dtDocumentosProv.Rows.Count() <> 0 Then
                dgv_lista_proveedor.DataSource = dtv_proveedor
                dgv_lista_proveedor.Columns(0).Width = 60
                dgv_lista_proveedor.Columns(1).Width = 210

                dgv_lista_proveedor.Columns(0).HeaderText = "Codigo"
                dgv_lista_proveedor.Columns(1).HeaderText = "Descripción"

                STRorden_proveedor = dgv_lista_proveedor.Columns(0).Name & "+" & dgv_lista_proveedor.Columns(1).Name
                GenerarColummnaDataTableProveedor()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub GenerarColummnaDataTableProveedor()
        Try
            dtProveedorPrincipal = New DataTable("Proveedores")
            dtProveedorPrincipal.Columns.Add("ID", Type.GetType("System.String"))
            dtProveedorPrincipal.Columns.Add("NAME", Type.GetType("System.String"))
            'dtProveedorPrincipal.Columns.Add("VAT_REGISTRATION", Type.GetType("System.String"))
            'dtProveedorPrincipal.Columns.Add("NUMERACION", Type.GetType("System.String"))
            dtProveedorPrincipal.PrimaryKey = New DataColumn() {dtProveedorPrincipal.Columns("ID")}
            dgv_proveedor.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipo_articulo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call TextBox2_MouseDoubleClick(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then
            txtbusqueda.Focus()
        End If
    End Sub

    Private Sub dtpfechafin_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtarticuloInicial.Focus()
        End If
    End Sub

    Private Sub btn_mas_Click(sender As Object, e As EventArgs) Handles btn_mas.Click
        Dim _ID As String = ""
        Dim _NAME As String = ""
        Dim _VAT_REGISTRATION As String = ""
        _ID = dgv_lista_proveedor.Item(0, dgv_lista_proveedor.CurrentRow.Index).Value
        _NAME = dgv_lista_proveedor.Item(1, dgv_lista_proveedor.CurrentRow.Index).Value

        'Validaciones
        If dtProveedorPrincipal.Rows.Count() <> 0 Then
            Dim Resultado() As DataRow
            Resultado = dtProveedorPrincipal.Select("ID='" & _ID & "' and NAME='" & _NAME & "' ", "")
            If Resultado.Count() <> 0 Then
                'MsgBox("El documento ya se ingreso anteriormente.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        Dim row As DataRow = dtProveedorPrincipal.NewRow
        'row("ITEM") = dtProveedorPrincipal.Rows.Count() + 1
        row("ID") = _ID
        row("NAME") = _NAME
        'row("VAT_REGISTRATION") = _VAT_REGISTRATION
        dtProveedorPrincipal.Rows.Add(row)
        dtProveedorPrincipal.AcceptChanges()
        If dtProveedorPrincipal.Rows.Count() <> 0 Then
            configurarGrilla()
        End If
        txtbusqueda.Focus()
    End Sub
    Private Sub configurarGrilla()
        dgv_proveedor.DataSource = dtProveedorPrincipal
        dgv_proveedor.Columns(0).Width = 60
        dgv_proveedor.Columns(1).Width = 210
        dgv_proveedor.Columns("ID").HeaderText = "Codigo"
        dgv_proveedor.Columns("NAME").HeaderText = "Descripción"

    End Sub

    Private Sub btn_menos_Click(sender As Object, e As EventArgs) Handles btn_menos.Click
        Try
            If dgv_proveedor.CurrentRow Is Nothing Then
                dgv_proveedor.Focus()
            End If
            If dtProveedorPrincipal.Rows.Count = 0 Then Exit Sub
            Dim Codigo As String = String.Empty
            Codigo = dgv_proveedor.Item(0, dgv_proveedor.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dtProveedorPrincipal.Select("ID='" & Codigo & "' ")
                dtProveedorPrincipal.BeginInit()
                item.Delete()
                dtProveedorPrincipal.EndInit()
                dtProveedorPrincipal.AcceptChanges()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.Text = String.Empty Then
            dtv_proveedor.RowFilter = String.Empty
            Exit Sub
        Else
            dtv_proveedor.RowFilter = STRorden_proveedor & " like '%" & txtbusqueda.Text & "%'"
            If dtv_proveedor.Count() = 0 Then
                STRorden_proveedor = String.Empty
                STRorden_proveedor = dgv_lista_proveedor.Columns(0).Name
                dtv_proveedor.RowFilter = STRorden_proveedor & " like '%" & txtbusqueda.Text & "%'"
                If dtv_proveedor.Count() = 0 Then
                    STRorden_proveedor = String.Empty
                    STRorden_proveedor = dgv_lista_proveedor.Columns(1).Name
                    dtv_proveedor.RowFilter = STRorden_proveedor & " like '%" & txtbusqueda.Text & "%'"
                    If dtv_proveedor.Count() = 0 Then
                        STRorden_proveedor = String.Empty
                        STRorden_proveedor = dgv_lista_proveedor.Columns(0).Name & "+" & dgv_lista_proveedor.Columns(1).Name
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_mas_todos_Click(sender As Object, e As EventArgs) Handles btn_mas_todos.Click
        Dim _ID As String = ""
        Dim _NAME As String = ""
        Dim _VAT_REGISTRATION As String = ""
        _ID = dgv_lista_proveedor.Item(0, dgv_lista_proveedor.CurrentRow.Index).Value
        _NAME = dgv_lista_proveedor.Item(1, dgv_lista_proveedor.CurrentRow.Index).Value

        dtProveedorPrincipal = Nothing
        GenerarColummnaDataTableProveedor()
        For i As Integer = 0 To dtDocumentosProv.Rows.Count - 1
            Dim row As DataRow = dtProveedorPrincipal.NewRow
            'row("ITEM") = dtProveedorPrincipal.Rows.Count() + 1
            row("ID") = dtDocumentosProv.Rows(i).Item("ID")
            row("NAME") = dtDocumentosProv.Rows(i).Item("NAME")
            'row("VAT_REGISTRATION") = _VAT_REGISTRATION
            dtProveedorPrincipal.Rows.Add(row)
            dtProveedorPrincipal.AcceptChanges()
        Next

        If dtProveedorPrincipal.Rows.Count() <> 0 Then
            configurarGrilla()
        End If
        txtbusqueda.Focus()
    End Sub

    Private Sub btn_menos_todos_Click(sender As Object, e As EventArgs) Handles btn_menos_todos.Click
        Try
            If dgv_proveedor.CurrentRow Is Nothing Then
                dgv_proveedor.Focus()
            End If
            If dtProveedorPrincipal.Rows.Count = 0 Then Exit Sub
            'Borrando los Datos
            dtProveedorPrincipal = Nothing
            GenerarColummnaDataTableProveedor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class