Imports LibComunVar
Imports System.Windows.Forms
Imports LibReportes

Public Class FrmRpt_Guias_Venta
    Dim reporteBL As ClsBuscar
    Dim crystalBL As ClsReporte
    Dim dtImprimir As DataTable
    Private Sub txtClienteInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtClienteInicial.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub
    Private Sub Ayuda_Vendedor()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_CUSTOMER"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE CLIENTES"
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

    Private Sub txtClienteInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteInicial.KeyDown
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

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub FrmRpt_Guias_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If Validaciones() = False Then Exit Sub
        ImprimirReporte()
    End Sub
    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtpfechaInicio.Focus()
                estado = False
            End If
            If checkVendedor.Checked = False Then
                If txtClienteInicial.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Exclamation)
                    txtClienteInicial.Focus()
                    estado = False
                End If
            End If
            If rdb_pendientes.Checked = False And rdb_entregados.Checked = False And rdb_todos.Checked = False Then
                MessageBox.Show("Debe elegir una opción para el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                estado = False
            End If
            If rdb_detallado.Checked = False And rdb_resumido.Checked = False Then
                MessageBox.Show("Debe elegir Resumido/Detallado para el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                estado = False
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub ImprimirReporte()

        Try
            Me.Cursor = Cursors.WaitCursor
            'NombreStore = "DOC_PENDIENTES_X_CLIENTES"
            dtImprimir = New DataTable("Reporte6")
            reporteBL = New ClsBuscar
            crystalBL = New ClsReporte
            Dim dtDatosCompany As DataTable

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If rdb_resumido.Checked Then
                dtImprimir = reporteBL.Get_ImprimirReporteII("DOC_PENDIENTES_GV_X_CLIENTES", dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), txtClienteInicial.Text.Trim, 1, "", _
                                                             "", "", IIf(rdb_pendientes.Checked, "1", IIf(rdb_entregados.Checked, "2", IIf(rdb_todos.Checked, "0", ""))))
            ElseIf rdb_detallado.Checked Then
                dtImprimir = reporteBL.Get_ImprimirReporteII("DOC_PENDIENTES_GV_X_CLIENTES_DETALLADO", dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), txtClienteInicial.Text.Trim, 1, "", _
                                                             "", "", IIf(rdb_pendientes.Checked, "1", IIf(rdb_entregados.Checked, "2", IIf(rdb_todos.Checked, "0", ""))))
            End If
            

            If dtImprimir.Rows.Count() <> 0 Then
                If rdb_resumido.Checked Then
                    crystalBL.Muestra_Reporte("rpt_pendiente_cliente_GV_Resumido.rpt", dtImprimir, "", "", "empresa;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                              "fi;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "ff;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                              "@CODIGO;" & txtClienteInicial.Text.Trim, "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                              "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), "@PRODUCTO;" & "", _
                                              "@DOCUMENTO;" & "", "@LOTE_PROD;" & "", _
                                              "@OPCION;" & "1", "@NUEVA_OPCION;" & IIf(rdb_pendientes.Checked, "1", IIf(rdb_entregados.Checked, "2", IIf(rdb_todos.Checked, "0", ""))))
                ElseIf rdb_detallado.Checked Then
                    crystalBL.Muestra_Reporte("rpt_pendiente_cliente_GV_Detallado.rpt", dtImprimir, "", "", "empresa;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                              "fi;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "ff;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                              "@CODIGO;" & txtClienteInicial.Text.Trim, "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                              "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), "@PRODUCTO;" & "", _
                                              "@DOCUMENTO;" & "", "@LOTE_PROD;" & "", _
                                              "@OPCION;" & "1", "@NUEVA_OPCION;" & IIf(rdb_pendientes.Checked, "1", IIf(rdb_entregados.Checked, "2", IIf(rdb_todos.Checked, "0", ""))))
                End If

            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class