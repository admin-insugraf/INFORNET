Imports System.Windows.Forms
Imports LibComunVar

Public Class FrmVentasMensualArticulo
    Dim clsBusquedasBL As ClsBuscar
    Dim dtDetalles As DataTable
    Public dt_tmp As DataTable

    Dim dtReporte As DataTable
    Dim reporteBL As ClsReporteGenerales.ReportesGerenciales
    Dim crystalBL As LibReportes.ClsReporte


    Private Sub BuscarArticulos(ByVal txtcodigo As TextBox, ByVal txtDescripcion As TextBox, ByVal _opcion As String)
        Try
            Dim frmM As New frmBuscar
            Dim sql As String = String.Empty
            If _opcion = "1" Then
                sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA"
                frmM.Titulo = "Seleccion de Articulos"
            ElseIf _opcion = "2" Then
                sql = "ALM_SP_S_WAREHOUSE_VENDEDOR_AYUDA"
                frmM.Titulo = "Seleccion de Vendedores"
            End If
            frmM.CadenaConsulta = sql
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

    Private Sub FrmVentasMensualArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdb_articulo.Checked = True
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes("01/01/" + CStr(Year(Date.Now)))
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes("01/12/" + CStr(Year(Date.Now)))
        dtpfechaInicio_vendedor.Value = ModFunciones.Primer_Dia_Mes("01/01/" + CStr(Year(Date.Now)))
        dtpfechaFin_vendedor.Value = ModFunciones.Ultimo_Dia_Mes("01/12/" + CStr(Year(Date.Now)))
    End Sub

    Private Sub txtinicioArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtinicioArticulo.MouseDoubleClick
        BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial, "1")
    End Sub

    Private Sub txtinicioArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinicioArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then
            BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial, "1")
        End If
        If e.KeyCode = Keys.Enter Then
            If txtinicioArticulo.Text = "" Then
                BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial, "1")
            Else
                btnMostrar.Select()
            End If
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim estado As Boolean = True
        Try

            If rdb_articulo.Checked Then
                If dtpfechaInicio.Value.Year <> dtpfechaFin.Value.Year Then
                    MessageBox.Show("El rango de fechas no es correcto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    estado = False
                    Exit Try
                End If
                If chktodos.Checked = False Then
                    If txtinicioArticulo.Text = "" Then
                        MessageBox.Show("Debe elegir un articulo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtinicioArticulo.Focus()
                        estado = False
                        Exit Try
                    End If
                End If
            ElseIf rdb_vendedor.Checked Then
                If dtpfechaInicio_vendedor.Value.Year <> dtpfechaFin_vendedor.Value.Year Then
                    MessageBox.Show("El rango de fechas no es correcto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    estado = False
                    Exit Try
                End If
                If chktodos_vendedor.Checked = False Then
                    If txtinicioArticulo_vendedor.Text = "" Then
                        MessageBox.Show("Debe elegir un Vendedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtinicioArticulo_vendedor.Focus()
                        estado = False
                        Exit Try
                    End If
                End If
            End If
            

            reporteBL = New ClsReporteGenerales.ReportesGerenciales
            crystalBL = New LibReportes.ClsReporte
            Me.Cursor = Cursors.WaitCursor
            dt_tmp = New DataTable
            Dim _dt_totales As DataTable
            _dt_totales = New DataTable
            Dim query As String = String.Empty
            Dim _1 As Double = 0
            Dim _2 As Double = 0
            Dim _3 As Double = 0
            Dim _4 As Double = 0
            Dim _5 As Double = 0
            Dim _6 As Double = 0
            Dim _7 As Double = 0
            Dim _8 As Double = 0
            Dim _9 As Double = 0
            Dim _10 As Double = 0
            Dim _11 As Double = 0
            Dim _12 As Double = 0

            If rdb_articulo.Checked Then
                dt_tmp = reporteBL.EjecutaReporteVentasMensualArticulo(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), txtinicioArticulo.Text.Trim)
                If dt_tmp.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_VentasMensualArticulo_Gerencia.rpt", dt_tmp, "", "", _
                                              "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                              "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                              "@PRODUCTO;" & txtinicioArticulo.Text.Trim, _
                                              "ANIO;" & dtpfechaFin.Value.Year.ToString)
                Else
                    MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                End If
            ElseIf rdb_vendedor.Checked Then
                dt_tmp = reporteBL.EjecutaReporteVentasMensualVendedor(dtpfechaInicio_vendedor.Value.ToString("dd/MM/yyyy"), dtpfechaFin_vendedor.Value.ToString("dd/MM/yyyy"), txtinicioArticulo_vendedor.Text.Trim)
                _dt_totales = reporteBL.EjecutaReporteVentasMensualVendedor_Totales(dtpfechaInicio_vendedor.Value.ToString("dd/MM/yyyy"), dtpfechaFin_vendedor.Value.ToString("dd/MM/yyyy"), txtinicioArticulo_vendedor.Text.Trim)

                If _dt_totales.Rows.Count <> 0 Then
                    _1 = _dt_totales.Rows(0).Item("ENERO")
                    _2 = _dt_totales.Rows(0).Item("FEBRERO")
                    _3 = _dt_totales.Rows(0).Item("MARZO")
                    _4 = _dt_totales.Rows(0).Item("ABRIL")
                    _5 = _dt_totales.Rows(0).Item("MAYO")
                    _6 = _dt_totales.Rows(0).Item("JUNIO")
                    _7 = _dt_totales.Rows(0).Item("JULIO")
                    _8 = _dt_totales.Rows(0).Item("AGOSTO")
                    _9 = _dt_totales.Rows(0).Item("SEPTIEMBRE")
                    _10 = _dt_totales.Rows(0).Item("OCTUBRE")
                    _11 = _dt_totales.Rows(0).Item("NOVIEMBRE")
                    _12 = _dt_totales.Rows(0).Item("DICIEMBRE")
                End If
                If dt_tmp.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_VentasMensualVendedor_Gerencia.rpt", dt_tmp, "", "", _
                                              "@FECHA_INI;" & dtpfechaInicio_vendedor.Value.ToString("dd/MM/yyyy"), _
                                              "@FECHA_FIN;" & dtpfechaFin_vendedor.Value.ToString("dd/MM/yyyy"), _
                                              "@VENDEDOR;" & txtinicioArticulo_vendedor.Text.Trim, _
                                              "ANIO;" & dtpfechaFin_vendedor.Value.Year.ToString, _
                                              "_1;" & _1, "_2;" & _2, "_3;" & _3, "_4;" & _4, "_5;" & _5, "_6;" & _6, _
                                              "_7;" & _7, "_8;" & _8, "_9;" & _9, "_10;" & _10, "_11;" & _11, "_12;" & _12)
                Else
                    MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                End If
            End If
            
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            estado = False
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub mtb_ayo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtinicioArticulo.Focus()
        End If
    End Sub

    Private Sub cboTipoReporte_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnMostrar_Click(sender, e)
        End If
    End Sub

    Private Sub chktodos_CheckedChanged(sender As Object, e As EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked Then
            txtinicioArticulo.Text = String.Empty
            txtdescripcionArticuloInicial.Text = String.Empty
            txtinicioArticulo.Enabled = False
            txtdescripcionArticuloInicial.Enabled = False
        Else
            txtinicioArticulo.Text = String.Empty
            txtdescripcionArticuloInicial.Text = String.Empty
            txtinicioArticulo.Enabled = True
            txtdescripcionArticuloInicial.Enabled = True
            txtinicioArticulo.Focus()
        End If
    End Sub

    Private Sub rdb_articulo_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_articulo.CheckedChanged
        If rdb_articulo.Checked Then
            gb_articulo.Visible = True
            gb_vendedor.Visible = False
        End If
    End Sub

    Private Sub rdb_vendedor_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_vendedor.CheckedChanged
        If rdb_vendedor.Checked Then
            gb_articulo.Visible = False
            gb_vendedor.Visible = True
        End If
    End Sub

    Private Sub chktodos_vendedor_CheckedChanged(sender As Object, e As EventArgs) Handles chktodos_vendedor.CheckedChanged
        If chktodos_vendedor.Checked Then
            txtinicioArticulo_vendedor.Text = String.Empty
            txtdescripcionArticuloInicial_vendedor.Text = String.Empty
            txtinicioArticulo_vendedor.Enabled = False
            txtdescripcionArticuloInicial_vendedor.Enabled = False
        Else
            txtinicioArticulo_vendedor.Text = String.Empty
            txtdescripcionArticuloInicial_vendedor.Text = String.Empty
            txtinicioArticulo_vendedor.Enabled = True
            txtdescripcionArticuloInicial_vendedor.Enabled = True
            txtinicioArticulo_vendedor.Focus()
        End If
    End Sub

    Private Sub txtinicioArticulo_vendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinicioArticulo_vendedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            BuscarArticulos(txtinicioArticulo_vendedor, txtdescripcionArticuloInicial_vendedor, "2")
        End If
        If e.KeyCode = Keys.Enter Then
            If txtinicioArticulo_vendedor.Text = "" Then
                BuscarArticulos(txtinicioArticulo_vendedor, txtdescripcionArticuloInicial_vendedor, "2")
            Else
                btnMostrar.Select()
            End If
        End If
    End Sub

    Private Sub txtinicioArticulo_vendedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtinicioArticulo_vendedor.MouseDoubleClick
        BuscarArticulos(txtinicioArticulo_vendedor, txtdescripcionArticuloInicial_vendedor, "2")
    End Sub
End Class
