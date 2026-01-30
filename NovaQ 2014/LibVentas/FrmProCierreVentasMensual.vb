Imports LibCobranzas
Imports System.Windows.Forms
Public Class FrmProCierreVentasMensual
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim Modo_consultar As Boolean = False

    Dim ClsTipoCambioBl As ClsOperaciones.CURRENCY_EXCHANGE
    Dim CLsTipoCambioEnt As ClsEntidades.CURRENCY_EXCHANGE
    Dim dttipoCambio As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Private Sub FrmProCierreVentasMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botonera_Estado_Cambiar(False)
        dgvDetallesTipoC.Select()
    End Sub
    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            nuevo()
            gbFiltroTipoCambio.Visible = False
            gbGenerarTipoCambio.Visible = True
            btn_grabar.Enabled = True
            If Modo_consultar = True Then
                'txtMoneda.Enabled = False
                dtpFecha.Enabled = False
            Else
                'txtMoneda.Enabled = True
                dtpFecha.Enabled = True
            End If
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
        Else
            gbFiltroTipoCambio.Visible = True
            gbGenerarTipoCambio.Visible = False
            btn_Nuevo.Enabled = True
            btn_grabar.Enabled = False
            If Modo_consultar = True Then
                ' txtMoneda.Enabled = False
                dtpFecha.Enabled = False
            Else
                'txtMoneda.Enabled = True
                dtpFecha.Enabled = True
            End If
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
        End If
    End Sub
    Private Sub nuevo()
        Dim hoy As DateTime = DateTime.Now
        Dim mesfinal As DateTime = hoy.AddMonths(1)
        ' txtMoneda.Text = String.Empty
        dtpFecha.Value = Date.Now
        dtpFechacierre.Value = mesfinal
        txtTipoCompra.Text = String.Empty
        txtTipoVenta.Text = String.Empty
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        If dtpFechaMes.Enabled = True Then
            MostrandoProgramacionCierreVentas(dtpFechaMes.Value.Year, dtpFechaMes.Value.Month)
        ElseIf dtpFechaDia.Enabled = True Then
            MostrandoProgramacionCierreVentas(dtpFechaDia.Value.Year, dtpFechaDia.Value.Month, dtpFechaDia.Value.Day)
        End If
    End Sub

    Private Sub rbMesProceso_CheckedChanged(sender As Object, e As EventArgs) Handles rbFechaAnno.CheckedChanged
        If rbFechaAnno.Checked = True Then
            dtpFechaMes.Enabled = True
            MostrandoProgramacionCierreVentas(dtpFechaMes.Value.Year, dtpFechaMes.Value.Month)
        Else
            dtpFechaMes.Enabled = False
        End If
    End Sub

    Private Sub MostrandoProgramacionCierreVentas(ByVal Anio As String, ByVal Mes As String, Optional ByVal Dia As String = "")
        Try
            ClsTipoCambioBl = New ClsOperaciones.CURRENCY_EXCHANGE
            dttipoCambio = New DataTable
            If String.IsNullOrEmpty(Dia) Then
                dttipoCambio = ClsTipoCambioBl.get_ProgCierreVentasMensual(Anio, Mes)
            Else
                dttipoCambio = ClsTipoCambioBl.get_ProgCierreVentasMensual(Anio, Mes, Dia)
            End If
            If dttipoCambio.Rows.Count() <> 0 Then
                dgvDetallesTipoC.DataSource = dttipoCambio
                dgvDetallesTipoC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                dgvDetallesTipoC.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFechaMes.CheckedChanged
        If rbFechaMes.Checked = True Then
            dtpFechaDia.Enabled = True
            MostrandoProgramacionCierreVentas(dtpFechaDia.Value.Year, dtpFechaDia.Value.Month, dtpFechaDia.Value.Day)
        Else
            dtpFechaDia.Enabled = False
        End If
    End Sub
 

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        rbFechaAnno.Checked = True
        dtpFecha.Select()
    End Sub
    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpFecha.Value.ToString("dd/MM/yyyy")) > CDate(dtpFechacierre.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpFecha.Focus()
                estado = False
                Exit Try
            End If

            ClsTipoCambioBl = New ClsOperaciones.CURRENCY_EXCHANGE
            dttipoCambio = New DataTable("Verificar_TipoC")
            dttipoCambio = ClsTipoCambioBl.get_VerificarProgCierreVentasMensual(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day)
            If dttipoCambio.Rows.Count() <> 0 Then
                MsgBox("Ya se Ingreso el día de cierre para la fecha elegida.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function
    Private Function GuardarProgramacionCierreVentasMensuales() As Boolean
        Dim resultado As Boolean = True
        Try
            Dim REGISTRO As New ClsReporteGenerales.ReportesGerenciales
            If REGISTRO.Guardar_ProgCierreVentasMensuales(dtpFecha.Value.Month.ToString, dtpFecha.Value.Year.ToString, dtpFechacierre.Value.ToString("dd/MM/yyyy"), LibComunVar.ClsVarComun.USUARIO, Date.Now.ToString("dd/MM/yyyy")) = True Then
                resultado = True
            Else
                resultado = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            resultado = False
        End Try
        Return resultado
    End Function
    Private Function ModificarProgramacionCierreventasMensuales() As Boolean
        Dim resultado As Boolean = True
        Try
            Dim REGISTRO As New ClsReporteGenerales.ReportesGerenciales
            If REGISTRO.Modificar_ProgCierreVentasMensuales(dtpFecha.Value.Month.ToString, dtpFecha.Value.Year.ToString, dtpFechacierre.Value.ToString("dd/MM/yyyy"), LibComunVar.ClsVarComun.USUARIO, Date.Now.ToString("dd/MM/yyyy")) = True Then
                resultado = True
            Else
                resultado = False
            End If
        Catch ex As Exception
            resultado = False
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function
    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If Modo_consultar = False Then
            If Validaciones() = False Then Exit Sub
            If GuardarProgramacionCierreVentasMensuales() = True Then
                MsgBox("Programación guardado exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox("No se pudo registrar la programación.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            If ModificarProgramacionCierreventasMensuales() = True Then
                MsgBox("Programación Modificado exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox("No se pudo modificar la programación.", MsgBoxStyle.Critical)
            End If
        End If
        Modo_consultar = False
        Botonera_Estado_Cambiar(False)
        'rbMesProceso.Checked = True
        MostrandoProgramacionCierreVentas(dtpFechaMes.Value.Year, dtpFechaMes.Value.Month)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgvDetallesTipoC.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Call Botonera_Estado_Cambiar(True)
        'txtMoneda.Text = dgvDetallesTipoC.Item(0, dgvDetallesTipoC.CurrentRow.Index).Value
        dtpFecha.Value = "01/" + dgvDetallesTipoC.Item(1, dgvDetallesTipoC.CurrentRow.Index).Value + "/" + dgvDetallesTipoC.Item(2, dgvDetallesTipoC.CurrentRow.Index).Value
        'txtTipoVenta.Text = dgvDetallesTipoC.Item(2, dgvDetallesTipoC.CurrentRow.Index).Value
        dtpFechacierre.Value = dgvDetallesTipoC.Item(3, dgvDetallesTipoC.CurrentRow.Index).Value
        'txtTipoCompra.Text = dgvDetallesTipoC.Item(3, dgvDetallesTipoC.CurrentRow.Index).Value
    End Sub

    Private Sub gbFiltroTipoCambio_Enter(sender As Object, e As EventArgs) Handles gbFiltroTipoCambio.Enter

    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Dim hoy As DateTime = dtpFecha.Value
        Dim mesfinal As DateTime = hoy.AddMonths(1)
        ' txtMoneda.Text = String.Empty
        'dtpFecha.Value = Date.Now
        dtpFechacierre.Value = mesfinal
    End Sub


    Private Sub imprimirProgramacionCierreVentas( )
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            If rbFechaMes.Checked = True Then
                dtImprimir = reporteBL.EjecutarReporteCierreVentas_Mes(dtpFechaDia.Value.Month, dtpFechaDia.Value.Year)
            ElseIf rbFechaAnno.Checked = True Then
                dtImprimir = reporteBL.EjecutarReporteCierreVentas_Año(dtpFechaMes.Value.Year)
            End If
            If dtImprimir.Rows.Count() <> 0 Then
                If rbFechaMes.Checked = True Then
                    crystalBL.Muestra_Reporte("rpt_Programacion_Cierre_Mes.rpt", "", "", "", "@MES;" & dtpFechaDia.Value.Month, "@ANNO;" & dtpFechaDia.Value.Year)
                ElseIf rbFechaAnno.Checked = True Then
                    crystalBL.Muestra_Reporte("rpt_Programacion_Cierre_Año.rpt", "", "", "", "@ANNO;" & dtpFechaMes.Value.Year)
                End If
            Else
                MsgBox("No hay informacion para Mostrar", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If dgvDetallesTipoC.Rows.Count() = 0 Then Exit Sub
        If dgvDetallesTipoC.CurrentRow Is Nothing Then Exit Sub
        imprimirProgramacionCierreVentas()
    End Sub

    Private Sub dtpFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpFechacierre.Select()
        End If
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class