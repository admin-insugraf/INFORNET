Imports LibComunVar
Imports System.Windows.Forms
Imports LibReportes
Public Class Frm_Reporte_ProvxProducto_Familia
    Dim reporteBL As ClsBuscar
    Dim crystalBL As ClsReporte
    Dim dtImprimir As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim dtDocumentosPrincipal As DataTable

    Private Sub Frm_Reporte_ProvxProducto_Familia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        MostrarDocumentosPendiente_Cliente()

    End Sub

    Private Sub MostrarDocumentosPendiente_Cliente()
        Try
            reporteBL = New ClsBuscar
            dtv = New DataView
            dgvDocumentos.DataSource = Nothing
            GenerarColummnaDataTable()
            dtDocumentosPrincipal = reporteBL.Mostrando_Familias_Rep()
            STRorden = ""
            If dtDocumentosPrincipal.Rows.Count() <> 0 Then
                dtv = dtDocumentosPrincipal.DefaultView
                dgvDocumentos.DataSource = dtv
                STRorden = dgvDocumentos.Columns(1).Name & "+" & dgvDocumentos.Columns(2).Name & "+" & dgvDocumentos.Columns(3).Name
            Else
                MsgBox("No hay informacion disponible para mostrar en este momento.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtDocumentosPrincipal = New DataTable
            dtDocumentosPrincipal.Columns.Add("Sel", Type.GetType("System.Boolean"))
            dtDocumentosPrincipal.Columns.Add("CUSTOMER_ID", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("NAME", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("VAT_REGISTRATION", Type.GetType("System.Double"))
            dgvDocumentos.DataSource = Nothing
            dgvDocumentos.DataSource = dtDocumentosPrincipal
            dgvDocumentos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDocumentos.Columns(0).Width = 40
            dgvDocumentos.Columns(0).ReadOnly = False
            dgvDocumentos.Columns(0).HeaderText = "Selec"
            dgvDocumentos.Columns(1).Width = 100
            dgvDocumentos.Columns(1).ReadOnly = True
            dgvDocumentos.Columns(1).HeaderText = "Codigo"
            dgvDocumentos.Columns(2).Width = 300
            dgvDocumentos.Columns(2).ReadOnly = True
            dgvDocumentos.Columns(2).HeaderText = "Familia"
            dgvDocumentos.Columns(3).Width = 120
            dgvDocumentos.Columns(3).ReadOnly = True
            dgvDocumentos.Columns(3).Visible = False
            dgvDocumentos.Columns(3).HeaderText = "Ruc"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtpfechaInicio.Focus()
                estado = False
            End If
            'If checkVendedor.Checked = False Then
            '    If txtClienteInicial.Text = String.Empty Then
            '        MsgBox("Debe seleccionar un Proveedor.", MsgBoxStyle.Exclamation)
            '        txtClienteInicial.Focus()
            '        estado = False
            '    End If
            'End If
            If chk_productos.Checked = False Then
                If txtProductoInicial.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Proveedor.", MsgBoxStyle.Exclamation)
                    txtProductoInicial.Focus()
                    estado = False
                End If
            End If

            'Dim Estado As Boolean = False
            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
                Estado = True
                Exit For
            Next
            If Estado = False Then
                MsgBox("No selecciono ningun Proveedor.", MsgBoxStyle.Exclamation)
                estado = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub ImprimirReporte(ByVal _Codigo As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New ClsReporte
            dtImprimir = New DataTable
            Dim dtDatosCompany As DataTable
            Me.Cursor = Cursors.WaitCursor
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            dtImprimir = reporteBL.EjecutarReporte_Compras_Proveedor_Producto_Familia(_Codigo, _
                                                                                      dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                                                                      dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                                                                      IIf(chk_productos.Checked = True, "", txtProductoInicial.Text))
            If dtImprimir.Rows.Count() <> 0 Then
                If rdb_detallado.Checked = True Then
                    crystalBL.Muestra_Reporte("rpt_Compras_Proveedor_x_producto_familia.rpt", dtImprimir, "", "", "@PROVEEDOR;" & _Codigo, _
                                              "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                              "@PRODUCTO;" & txtProductoInicial.Text, "FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                              "FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                              "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                ElseIf rdb_resumido.Checked = True Then
                    crystalBL.Muestra_Reporte("rpt_Compras_Proveedor_x_producto_resumido_familia.rpt", dtImprimir, "", "", "@PROVEEDOR;" & _Codigo, _
                                              "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                              "@PRODUCTO;" & txtProductoInicial.Text, "FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                              "FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                              "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                End If
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If dgvDocumentos.CurrentRow Is Nothing Then Exit Sub
        If Validaciones() = False Then Exit Sub

        Dim _Codigo As String = String.Empty

        For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
            _Codigo = _Codigo & """" & row("CUSTOMER_ID").ToString() & """" & ","
        Next
        If _Codigo.Length() <> 0 Then
            _Codigo = Mid(_Codigo, 1, _Codigo.Length - 1)
            ImprimirReporte(_Codigo)
        End If


    End Sub

    Private Sub txtVendedorInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtClienteInicial.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub


    Private Sub txtVendedorInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor()
        End If
    End Sub

    Private Sub checkVendedor_CheckedChanged(sender As Object, e As EventArgs) Handles checkVendedor.CheckedChanged
        txtClienteInicial.Text = String.Empty
        txtClienteInicialDesc.Text = String.Empty
        txtClienteInicial.Enabled = Not checkVendedor.Checked
        txtClienteInicialDesc.Enabled = Not checkVendedor.Checked
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txtProductoInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtProductoInicial.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub

    Private Sub txtProductoInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductoInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor()
        End If
    End Sub
    Private Sub Ayuda_Producto()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_FAMILIA"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE FAMILIAS"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtProductoInicial.Text = frm.Data_Matriz.Rows(0).Item(0)
                txtProductoInicialDesc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_productos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_productos.CheckedChanged
        txtProductoInicial.Text = String.Empty
        txtProductoInicialDesc.Text = String.Empty
        txtProductoInicial.Enabled = Not chk_productos.Checked
        txtProductoInicialDesc.Enabled = Not chk_productos.Checked
    End Sub

    Private Sub Ayuda_Vendedor()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_PROVEEDORE"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE PROVEEDORES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtClienteInicial.Text = frm.Data_Matriz.Rows(0).Item(0)
                txtClienteInicialDesc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then Exit Sub

        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
    End Sub

    Private Sub dgvDocumentos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvDocumentos.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvDocumentos.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgvDocumentos.CommitEdit(DataGridViewDataErrorContexts.Commit)
            Dim sel_proveedor As String = dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value.ToString
            For Each row As DataRow In dtDocumentosPrincipal.Select("CUSTOMER_ID='" & sel_proveedor & "' ")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = Not row("Sel")
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
        End If
    End Sub

    Private Sub checkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles checkTodos.CheckedChanged
        If checkTodos.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=False")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = True
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
            Me.Cursor = Cursors.Default
        Else
            Me.Cursor = Cursors.WaitCursor
            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = False
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class