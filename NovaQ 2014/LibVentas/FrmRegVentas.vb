Imports System.Windows.Forms
Imports LibComunVar
Imports LibCobranzas
Imports LibReportes
Imports System.Drawing
Public Class FrmRegVentas
    Public opcion As String = String.Empty
    Public dt_tmp As DataTable
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Dim cVenta As ClsAyudas
    Dim dtSerieGuia As DataTable

    Private Sub FrmRegVentas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'para detener el proceso en caso de cerrar el formulario.
        Me.BackgroundWorker1.CancelAsync()
    End Sub
    Private Sub FrmRegVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        cbo_moneda.SelectedIndex = 0
        MostrandoTipoDocumentos()
        Ayuda_SerieGuiaPuntoVenta()
        dtpfechaInicio.Select()
    End Sub

    Private Sub Ayuda_SerieGuiaPuntoVenta()
        Try
            cVenta = New ClsAyudas
            dtSerieGuia = New DataTable
            dtSerieGuia = cVenta.get_Series_Reg_Ventas("")
            cbo_series.ValueMember = dtSerieGuia.Columns(0).ToString
            cbo_series.DisplayMember = dtSerieGuia.Columns(0).ToString
            cbo_series.DataSource = dtSerieGuia
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoTipoDocumentos()
        Try
            chklstDocumentos.Items.Clear()
            Dim Documentos(5) As String
            Documentos(0) = "BV:BOLETA DE VENTA"
            Documentos(1) = "CP:COMPROBANTE DE PERCEPCION"
            Documentos(2) = "FT:FACTURA DE VENTA"
            Documentos(3) = "NC:NOTA DE CREDITO"
            Documentos(4) = "ND:NOTA DE DEBITO"
            Documentos(5) = "PF:PROFORMAS"
            For i As Integer = 0 To Documentos.Count() - 1
                chklstDocumentos.Items.Add(Documentos(i))
            Next
            chklstDocumentos.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        Dim moneda As String = String.Empty
        ' ---Validaciones generales
        If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte, moneda) = False Then Exit Sub
        ' -----Mostrando el Reporte
        moneda = IIf(cbo_moneda.SelectedIndex = 0, "MN", IIf(cbo_moneda.SelectedIndex = 1, "ME", ""))
        MostrarReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte, moneda)
    End Sub

 

    Private Sub MostrarReporte(ByRef _fechaInicial As String, ByRef _fechaFinal As String, _
                               ByRef _TipoReporte As Integer, ByRef _moneda As String)

        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim dtDatosCompany As DataTable
        Dim NombreStore As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim idTipoDoc As String = String.Empty
            Dim i As Integer = 0
            Do While i <= chklstDocumentos.CheckedItems.Count - 1
                idTipoDoc = idTipoDoc & """" & TraerCodigo(chklstDocumentos.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idTipoDoc.Length() <> 0 Then
                idTipoDoc = Mid(idTipoDoc, 1, idTipoDoc.Length - 1)
            End If

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            Select Case _TipoReporte
                Case 1
                    NombreStore = "SP_REGISTRO_VENTAS_SUNAT"
                    dt_tmp = New DataTable
                    dt_tmp = reporteBL.Get_ImprimirRegistroVentas(NombreStore, _fechaInicial, _fechaFinal, _TipoReporte, idTipoDoc, _moneda, IIf(chk_todos_series.Checked, "", cbo_series.SelectedValue))
                    If dt_tmp.Rows.Count() <> 0 Then
                        ' crystalBL.Muestra_Reporte("rpt_registro_ventas.rpt", dt_tmp, "", "", "@FECHA_INICIAL;" & _fechaInicial, "@FECHA_FINAL;" & _fechaFinal, "@PERIODO;" & dtpfechaInicio.Value.ToString("MMMM - yyyy").ToUpper, "@TIPOS_DOC;" & idTipoDoc)
                        crystalBL.Muestra_Reporte("rpt_registro_ventas.rpt", dt_tmp, "", "", "@PERIODO;" & dtpfechaInicio.Value.ToString("MMMM - yyyy").ToUpper, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
                    End If
                Case 2
                    NombreStore = "SP_REGISTRO_VENTAS_SUNAT"
                    dt_tmp = New DataTable
                    dt_tmp = reporteBL.Get_ImprimirRegistroVentas(NombreStore, _fechaInicial, _fechaFinal, "1", idTipoDoc, _moneda, IIf(chk_todos_series.Checked, "", cbo_series.SelectedValue))
                    If dt_tmp.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_registro_ventas_insugraf.rpt", dt_tmp, "", "", "@PERIODO;" & dtpfechaInicio.Value.ToString("MMMM - yyyy").ToUpper, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
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

    Private Function ValidacionesReporte(ByRef fecha_Inicial As String, ByRef fecha_Final As String, _
                                  ByRef tipo_Reporte As Integer, ByRef moneda As String) As Boolean

        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            '--
            fecha_Inicial = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            fecha_Final = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            'moneda = cbo_moneda.SelectedValue

            ' -------------
            If rdbsunat.Checked = False And rdbconcar.Checked = False Then
                MessageBox.Show("Debe elegir una de las opciones.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                rdbsunat.Focus()
                estado = False
                Exit Try
            End If

            If cbo_series.SelectedIndex = -1 And chk_todos_series.Checked = False Then
                MessageBox.Show("Debe elegir una de las series.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_series.Focus()
                estado = False
                Exit Try
            End If

            If rdbsunat.Checked = True Then
                tipo_Reporte = 1
            ElseIf rdbconcar.Checked = True Then
                tipo_Reporte = 2
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub rdbconcar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbconcar.CheckedChanged
        'If rdbconcar.Checked = True Then
        '    Panel_Formato_Concar.Visible = True
        '    rb_ventas.Checked = True
        '    'gbDatosGenerales.Enabled = False
        'End If
    End Sub

    Private Sub rdbsunat_CheckedChanged(sender As Object, e As EventArgs) Handles rdbsunat.CheckedChanged
        If rdbsunat.Checked = True Then
            Panel_Formato_Concar.Visible = False
            gbDatosGenerales.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtRuta.Text = "" '"C:\Documents and Settings\ejemplo\Escritorio\"
        rdbsunat.Checked = True
        Panel_Formato_Concar.Visible = False
        gbDatosGenerales.Enabled = True
        Me.btnIniciar.Enabled = True
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        'Detenemos el proceso de forma segura
        Me.BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        Dim Carpeta As New FolderBrowserDialog
        If Carpeta.ShowDialog() = DialogResult.OK Then
            Me.txtRuta.Text = Carpeta.SelectedPath.ToString & "\"
        End If
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        'Deshabilitamos el boton por posibles equibocaiones
        Me.Cursor = Cursors.WaitCursor
        Me.btnIniciar.Enabled = False
        'Iniciamos el proceso de exportacion de la tabla a Excel
        Me.BackgroundWorker1.RunWorkerAsync()
        Me.ProgressBar2.Visible = True
        'Me.btnIniciar.Enabled = True
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim i As Integer
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim moneda As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Dim clase_excel As New ClsReporteGenerales.ReportesGerenciales

        Try

            ' ---Validaciones generales
            If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte, moneda) = False Then Exit Sub
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
            If rb_ventas.Checked Then
                NombreStore = "SP_REGISTRO_VENTAS_CONCAR"
            ElseIf rb_cobranzas.Checked Then
                NombreStore = "SP_REGISTRO_COBRANZAS_CONCAR"
            End If

            dt_tmp = New DataTable
            'Me.Cursor = Cursors.WaitCursor
            dt_tmp = reporteBL.Get_ImprimirRegistroVentas(NombreStore, Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
            If dt_tmp.Rows.Count() <> 0 Then
                'Indicamos la ruta donde se guardara el archivo, en este caso es el escritorio.
                Dim Ruta As String = Me.txtRuta.Text
                'Indicamos el nombre del archivo sin la extencion.
                Dim Archivo = Me.txtArchivo.Text
                'Llamamos a la funcion ExportarSQLExcel de la Clase ExportarExcel.

                e.Result = clase_excel.ExportarSQLExcel(dt_tmp, Ruta, Archivo)

                For i = 1 To 100
                    If Me.BackgroundWorker1.CancellationPending = True Then
                        MsgBox("El proceso de exportación ha sido cancelado.", MsgBoxStyle.Exclamation, "Error")
                        Exit Sub
                    End If
                    BackgroundWorker1.ReportProgress(i)
                    'Indica el tiempo en el que se realizara la tarea en segundo plano
                    Threading.Thread.Sleep(1) ' 0 es casi instantaneo
                Next

            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
                For i = 1 To 1
                    If Me.BackgroundWorker1.CancellationPending = True Then
                        MsgBox("El proceso de exportación ha sido cancelado.", MsgBoxStyle.Exclamation, "Error")
                        Exit Sub
                    End If
                    BackgroundWorker1.ReportProgress(i)
                    'Indica el tiempo en el que se realizara la tarea en segundo plano
                    Threading.Thread.Sleep(1) ' 0 es casi instantaneo
                Next
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
        Me.ProgressBar2.Visible = False
        'Representa el porcentaje del progreso en el Label1.Text
        Label1.Text = e.ProgressPercentage & "%"
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Volvemos a habilitar el boton
        Me.btnIniciar.Enabled = True
        'Ponemos en cero la barra de progreso
        Me.ProgressBar1.Value = 0
        Me.ProgressBar2.Visible = False
        'Eliminamos el texto del Label1
        Label1.Text = ""
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtpfechaInicio_DockChanged(sender As Object, e As EventArgs) Handles dtpfechaInicio.DockChanged

    End Sub

    Private Sub dtpfechaInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaInicio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpfechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaInicio.ValueChanged

    End Sub

    Private Sub dtpfechaFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaFin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpfechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaFin.ValueChanged

    End Sub

    Private Sub rdbsunat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdbsunat.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rdbconcar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdbconcar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Sub ActivarCheck(ByVal opcion As Boolean)
        Dim i As Integer = 0
        If opcion Then
            Do While i <= chklstDocumentos.Items.Count - 1
                chklstDocumentos.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= chklstDocumentos.Items.Count - 1
                chklstDocumentos.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub checkTipoDoc_CheckedChanged(sender As Object, e As EventArgs) Handles checkTipoDoc.CheckedChanged
        If checkTipoDoc.Checked Then
            ActivarCheck(True)
            chklstDocumentos.Enabled = False
        Else
            ActivarCheck(False)
            chklstDocumentos.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub rb_ventas_CheckedChanged(sender As Object, e As EventArgs) Handles rb_ventas.CheckedChanged
        If rb_ventas.Checked = True Then
            txtArchivo.Text = "Formato_Ventas"
        End If
    End Sub

    Private Sub rb_cobranzas_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cobranzas.CheckedChanged
        If rb_cobranzas.Checked = True Then
            txtArchivo.Text = "Formato_Cobranzas"
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Try

        '    If MessageBox.Show("¿Desea actualizar el Tipo de Cambio " & Chr(13) & " en los Documentos en el rango de fechas elegido?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '        Me.Cursor = Cursors.WaitCursor
        '        clsFacturaBl = New ClsNegocio.RECEIVABLE
        '        If clsFacturaBl.GenerarAct_Tipo_Cambio_Doc(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
        '            MsgBox("Actualización de docs. realizado correctamente", MsgBoxStyle.Information)
        '        End If
        '        Me.Cursor = Cursors.Default
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Me.Cursor = Cursors.Default
        'End Try
        
    End Sub

    Private Sub chk_todos_series_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_series.CheckedChanged
        If chk_todos_series.Checked Then
            cbo_series.SelectedIndex = -1
            cbo_series.Enabled = False
        Else
            cbo_series.SelectedIndex = -1
            cbo_series.Enabled = True
        End If
    End Sub
End Class