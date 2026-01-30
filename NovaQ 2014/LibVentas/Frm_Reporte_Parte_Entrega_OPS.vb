Imports LibComunVar
Imports System.Windows.Forms
Imports LibReportes

Public Class Frm_Reporte_Parte_Entrega_OPS
    Dim reporteBL As ClsBuscar
    Dim crystalBL As ClsReporte
    Dim dtImprimir As DataTable

    Private Sub Frm_Reporte_Parte_Entrega_OPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
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
                    MsgBox("Debe seleccionar una O.P.", MsgBoxStyle.Exclamation)
                    txtClienteInicial.Focus()
                    estado = False
                End If
            End If
            If chk_productos.Checked = False Then
                If txtProductoInicial.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Producto.", MsgBoxStyle.Exclamation)
                    txtProductoInicial.Focus()
                    estado = False
                End If
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub ImprimirReporte()
        Try
            reporteBL = New ClsBuscar
            crystalBL = New ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor

            Dim dtDatosCompany As DataTable
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            dtImprimir = reporteBL.EjecutarReporte_Parte_Entrega(IIf(checkVendedor.Checked = True, "", txtClienteInicial.Text), dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), IIf(chk_productos.Checked = True, "", txtProductoInicial.Text))
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Parte_Entrega_Lista.rpt", dtImprimir, "", "",
                                          "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"),
                                          "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"),
                                          "@NUMERO_OP;" & txtClienteInicial.Text,
                                          "@PRODUCTO;" & txtProductoInicial.Text,
                                          "FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"),
                                          "FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"),
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
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
        If Validaciones() = False Then Exit Sub
        ImprimirReporte()
    End Sub

    Private Sub txtVendedorInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtClienteInicial.MouseDoubleClick
        Ayuda_Numero_OP()
    End Sub


    Private Sub txtVendedorInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Numero_OP()
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
        Ayuda_Producto()
    End Sub

    Private Sub txtProductoInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductoInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Producto()
        End If
    End Sub
    Private Sub Ayuda_Producto()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_PART"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE PRODUCTOS"
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

    Private Sub Ayuda_Numero_OP()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_PRODUCCION_OP"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE OPS"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtClienteInicial.Text = frm.Data_Matriz.Rows(0).Item("N.OP")
                txtClienteInicialDesc.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class