Imports LibComunVar
Imports System.Windows.Forms
Imports LibReportes


Public Class frm_Reporte_VendedorxProducto

    Dim reporteBL As ClsBuscar
    Dim crystalBL As ClsReporte
    Dim dtImprimir As DataTable


    Private Sub Ayuda_Vendedor()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_VENDOR"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE VENDEDORES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtVendedorInicial.Text = frm.Data_Matriz.Rows(0).Item(0)
                txtvendedorInicialDesc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_Reporte_VendedorxProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
            End If
            If checkVendedor.Checked = False Then
                If txtVendedorInicial.Text = String.Empty Then
                    MsgBox("Debe seleccionar un vendedor inicial", MsgBoxStyle.Information)
                    txtVendedorInicial.Focus()
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
            dtImprimir = New DataTable()
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteVentasVendedorProducto(IIf(checkVendedor.Checked = True, "", txtVendedorInicial.Text), dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"))
            If dtImprimir.Rows.Count() <> 0 Then
                If rbvendedorProducto.Checked = True Then
                    crystalBL.Muestra_Reporte("rpt_Ventas_vendedor_x_producto.rpt", "", "", "", "@VENDEDOR;" & txtVendedorInicial.Text, "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"))
                Else
                    crystalBL.Muestra_Reporte("rpt_Ventas_producto_x_vendedor.rpt", "", "", "", "@VENDEDOR;" & txtVendedorInicial.Text, "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"))
                End If
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If Validaciones() = False Then Exit Sub
        ImprimirReporte()
    End Sub

    Private Sub txtVendedorInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedorInicial.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub


    Private Sub txtVendedorInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendedorInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor()
        End If
    End Sub

    Private Sub checkVendedor_CheckedChanged(sender As Object, e As EventArgs) Handles checkVendedor.CheckedChanged
        txtVendedorInicial.Text = String.Empty
        txtvendedorInicialDesc.Text = String.Empty
        txtVendedorInicial.Enabled = Not checkVendedor.Checked
        txtvendedorInicialDesc.Enabled = Not checkVendedor.Checked
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class