Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Imports System.Drawing
Public Class Frm_rep_correlativo_faltantes
    Public opcion As String = String.Empty
    Public dt_tmp As DataTable

    Private Sub FrmRegVentas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'para detener el proceso en caso de cerrar el formulario.
        Me.BackgroundWorker1.CancelAsync()
    End Sub
    Private Sub FrmRegVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Series()
        chk_todos_series.Checked = True
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicio.Select()
    End Sub

    Private Sub Cargar_Series()
        Dim documentosBL As LibCobranzas.ClsOperaciones.DOCUMENT_TYPE
        documentosBL = New LibCobranzas.ClsOperaciones.DOCUMENT_TYPE
        cmb_tipo_cob.DataSource = documentosBL.get_Series()
        cmb_tipo_cob.ValueMember = "COD"
        cmb_tipo_cob.DisplayMember = "DES"
        documentosBL = Nothing
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub MostrarReporte(ByRef _fechaInicial As String, ByRef _fechaFinal As String, _
                               ByRef _TipoReporte As Integer)

        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            dt_tmp = New DataTable("correlativos")
            dt_tmp = reporteBL.EjecutarReporteCorrelativosFaltantes(_fechaInicial, _fechaFinal, IIf(chk_todos_series.Checked, "", cmb_tipo_cob.SelectedValue))
            If dt_tmp.Rows.Count() <> 0 Then
                'crystalBL.Muestra_Reporte("DOC_NO_INGRESADOS_DOS.rpt", "", "")
                crystalBL.Muestra_Reporte("DOC_NO_INGRESADOS_DOS.rpt", dt_tmp, "", "", "@FECHA1;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA2;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                          "FEC_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "FEC_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"))
            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try

        crystalBL = Nothing
        reporteBL = Nothing
    End Sub

    Private Function ValidacionesReporte(ByRef fecha_Inicial As String, ByRef fecha_Final As String, _
                                  ByRef tipo_Reporte As Integer) As Boolean

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
            ' -------------

            If chk_todos_series.Checked = False And cmb_tipo_cob.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir una serie.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmb_tipo_cob.Focus()
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub dtpfechaInicio_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpfechaFin.Select()
        End If
    End Sub

    Private Sub dtpfechaFin_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaFin.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnMostrar.Select()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub chk_todos_series_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_series.CheckedChanged
        If chk_todos_series.Checked = True Then
            cmb_tipo_cob.Enabled = False
            cmb_tipo_cob.SelectedIndex = -1
        Else
            cmb_tipo_cob.Enabled = True
            cmb_tipo_cob.SelectedIndex = -1
        End If
    End Sub
End Class