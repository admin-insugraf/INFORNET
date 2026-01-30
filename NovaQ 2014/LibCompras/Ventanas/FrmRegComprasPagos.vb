Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Imports System.Drawing
Imports LibVentas

Public Class FrmRegComprasPagos
    Dim dt_tmp As DataTable
    Dim dtDatosCompany As DataTable
    Private Sub FrmRegComprasPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicio.Select()
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0

        ' ---Validaciones generales
        If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte) = False Then Exit Sub
        ' -----Mostrando el Reporte
        MostrarReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
    End Sub
    Private Function ValidacionesReporte(ByRef fecha_Inicial As String, ByRef fecha_Final As String, _
                                  ByRef tipo_Reporte As Integer) As Boolean

        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            '--
            fecha_Inicial = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            fecha_Final = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            ' -------------
            If txtplazo1.Text = "" Or Val(txtplazo1.Text) = 0 Then
                MessageBox.Show("Debe ingresar un plazo de vencimiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtplazo1.Focus()
                estado = False
                Exit Try
            End If
            If txtplazo5.Text = "" Or Val(txtplazo5.Text) = 0 Then
                MessageBox.Show("Debe ingresar un plazo de vencimiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtplazo5.Focus()
                estado = False
                Exit Try
            End If
            If txtplazo2.Text = "" Or Val(txtplazo2.Text) = 0 Then
                MessageBox.Show("Debe ingresar un plazo de vencimiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtplazo2.Focus()
                estado = False
                Exit Try
            End If
            If txtplazo3.Text = "" Or Val(txtplazo3.Text) = 0 Then
                MessageBox.Show("Debe ingresar un plazo de vencimiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtplazo3.Focus()
                estado = False
                Exit Try
            End If
            If txtplazo4.Text = "" Or Val(txtplazo4.Text) = 0 Then
                MessageBox.Show("Debe ingresar un plazo de vencimiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtplazo4.Focus()
                estado = False
                Exit Try
            End If

            If optrangocobro.Checked = True Then
                tipo_Reporte = 1
            ElseIf optdetallado.Checked = True Then
                tipo_Reporte = 2
            ElseIf optexcel.Checked = True Then
                tipo_Reporte = 3
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function
    Private Sub MostrarReporte(ByRef _fechaInicial As String, ByRef _fechaFinal As String, _
                               ByRef _TipoReporte As Integer)

        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim reporteBLC As ClsBuscar
        reporteBLC = New ClsBuscar
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim idTipoDoc As String = String.Empty
            Dim i As Integer = 0


            Select Case _TipoReporte
                Case 1
                    NombreStore = "reporte_por_plazos"
                    dt_tmp = New DataTable
                    dt_tmp = reporteBL.Get_ImprimirRegistroComprasPagos(NombreStore, _fechaInicial, _fechaFinal, _TipoReporte, idTipoDoc)
                    dtDatosCompany = reporteBLC.Obtener_Datos_Empresa()
                    If dt_tmp.Rows.Count() <> 0 Then
                        ' crystalBL.Muestra_Reporte("rpt_registro_ventas.rpt", dt_tmp, "", "", "@FECHA_INICIAL;" & _fechaInicial, "@FECHA_FINAL;" & _fechaFinal, "@PERIODO;" & dtpfechaInicio.Value.ToString("MMMM - yyyy").ToUpper, "@TIPOS_DOC;" & idTipoDoc)
                        crystalBL.Muestra_Reporte("REP_REGCOMPRAS_PAGOS.rpt", "", "", "", "@fechini;" & _fechaInicial, "@fechfin;" & _fechaFinal, "XVEN1;" & _fechaInicial, "XVEN2;" & _fechaFinal, "XPLAZO1;" & txtplazo1.Text, "XPLAZO2;" & txtplazo2.Text, "XPLAZO3;" & txtplazo3.Text, "XPLAZO4;" & txtplazo4.Text, "XPLAZOMAS;" & txtplazo5.Text, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
                    End If
                Case 2
                    NombreStore = "reporte_por_plazos_detallado"
                    dt_tmp = New DataTable
                    dt_tmp = reporteBL.Get_ImprimirRegistroComprasPagos(NombreStore, _fechaInicial, _fechaFinal, _TipoReporte, idTipoDoc)
                    dtDatosCompany = reporteBLC.Obtener_Datos_Empresa()
                    If dt_tmp.Rows.Count() <> 0 Then
                        ' crystalBL.Muestra_Reporte("rpt_registro_ventas.rpt", dt_tmp, "", "", "@FECHA_INICIAL;" & _fechaInicial, "@FECHA_FINAL;" & _fechaFinal, "@PERIODO;" & dtpfechaInicio.Value.ToString("MMMM - yyyy").ToUpper, "@TIPOS_DOC;" & idTipoDoc)
                        crystalBL.Muestra_Reporte("REP_REGCOMPRAS_PAGOS_DETALLADO.rpt", "", "", "", "XVEN1;" & _fechaInicial, "XVEN2;" & _fechaFinal, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
                    End If
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try

        crystalBL = Nothing
        reporteBL = Nothing
    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        Dim Carpeta As New FolderBrowserDialog
        If Carpeta.ShowDialog() = DialogResult.OK Then
            Me.txtRuta.Text = Carpeta.SelectedPath.ToString & "\"
        End If
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        'Detenemos el proceso de forma segura
        Me.BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        'Deshabilitamos el boton por posibles equibocaiones
        Me.Cursor = Cursors.WaitCursor
        Me.btnIniciar.Enabled = False
        Me.ProgressBar2.Visible = True
        Me.Label3.Visible = False
        'Iniciamos el proceso de exportacion de la tabla a Excel
        Me.BackgroundWorker1.RunWorkerAsync()
        'ProgressBar2.Visible = False
        'Label3.Visible = True
        'Me.btnIniciar.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim i As Integer
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Dim clase_excel As New ClsReporteGenerales.ReportesGerenciales

        Try

            ' ---Validaciones generales
            If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte) = False Then Exit Sub
            If txtArchivo.Text = "" Then
                MessageBox.Show("Ingrese una ruta correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Try
                Exit Sub
            End If
            If txtRuta.Text = "" Then
                MessageBox.Show("Ingrese un nombre para el archivo a generar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Try
                Exit Sub
            End If
            ' -----Mostrando el Reporte
            'MostrarReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
            NombreStore = "CXC_S_PEND_POR_DIA"
            dt_tmp = New DataTable
            dt_tmp = reporteBL.Get_ImprimirRegistroComprasPagos(NombreStore, dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), "3")

            If dt_tmp.Rows.Count() <> 0 Then
                For i = 1 To 100
                    If Me.BackgroundWorker1.CancellationPending = True Then
                        MsgBox("El proceso de exportación ha sido cancelado.", MsgBoxStyle.Exclamation, "Error")
                        Exit Sub
                    End If
                    BackgroundWorker1.ReportProgress(i)
                    'Indica el tiempo en el que se realizara la tarea en segundo plano
                    Threading.Thread.Sleep(1) ' 0 es casi instantaneo
                Next
                'Indicamos la ruta donde se guardara el archivo, en este caso es el escritorio.
                Dim Ruta As String = Me.txtRuta.Text
                'Indicamos el nombre del archivo sin la extencion.
                Dim Archivo = Me.txtArchivo.Text
                'Llamamos a la funcion ExportarSQLExcel de la Clase ExportarExcel.

                e.Result = clase_excel.ExportarSQLExcel_Rep_Reg_Compras_Pagos_Diario(dt_tmp, Ruta, Archivo)

            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If
            'Me.Cursor = Cursors.Default
        Catch ex As Exception
            'Me.btnIniciar.Enabled = True
            MessageBox.Show(ex.Message)

        End Try
        crystalBL = Nothing
        reporteBL = Nothing

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'Notificar el progreso de la tarea
        Me.ProgressBar1.Value = e.ProgressPercentage
        'Representa el porcentaje del progreso en el Label1.Text
        Label3.Text = e.ProgressPercentage & "%"
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Volvemos a habilitar el boton
        Me.btnIniciar.Enabled = True
        'Ponemos en cero la barra de progreso
        Me.ProgressBar1.Value = 0
        Me.ProgressBar2.Visible = False
        Me.Label3.Visible = True
        'Eliminamos el texto del Label1
        Label3.Text = ""
    End Sub

    Private Sub optexcel_CheckedChanged(sender As Object, e As EventArgs) Handles optexcel.CheckedChanged
        If optexcel.Checked = True Then
            Panel_Formato_Concar.Visible = True
            txtRuta.Text = ""
            txtArchivo.Text = "Reg_Ventas_Cobranza_Diario"
            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = 5
            ProgressBar2.Value = 0

            If ProgressBar2.Value < ProgressBar2.Maximum Then
                ProgressBar2.Value += 1
                If ProgressBar2.Value = ProgressBar2.Maximum Then
                    MsgBox("Finished!")
                End If
            End If
        End If
    End Sub

    Private Sub optrangocobro_CheckedChanged(sender As Object, e As EventArgs) Handles optrangocobro.CheckedChanged
        If optrangocobro.Checked = True Then
            Panel_Formato_Concar.Visible = False
            txtRuta.Text = ""
            txtArchivo.Text = "Reg_Ventas_Cobranza_Diario"
        End If
    End Sub

    Private Sub optdetallado_CheckedChanged(sender As Object, e As EventArgs) Handles optdetallado.CheckedChanged
        If optdetallado.Checked = True Then
            Panel_Formato_Concar.Visible = False
            txtRuta.Text = ""
            txtArchivo.Text = "Reg_Ventas_Cobranza_Diario"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_Formato_Concar.Visible = False
        optrangocobro.Checked = True
    End Sub
    Private Sub txtplazo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo1.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtplazo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo2.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtplazo3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo3.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtplazo4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo4.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtplazo5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo5.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

End Class