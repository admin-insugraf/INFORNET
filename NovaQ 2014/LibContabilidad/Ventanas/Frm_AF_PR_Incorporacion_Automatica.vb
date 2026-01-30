Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing



Public Class Frm_AF_PR_Incorporacion_Automatica
    Dim AsientoContableCabs As ClsOperaciones.Asiento_Contable

    Private Sub Frm_AF_PR_Incorporacion_Automatica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click
        If dgvdetalles.Rows.Count = 0 Then Me.Cursor = Cursors.Default : Exit Sub

        If MsgBox("Esta seguro de realizar el Proceso de " & Chr(13) & " Incorporación de Retenciones.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            progreso.Visible = True
            If INGRESO_RETENCIONES() Then
                txt_ruta.Text = ""
                txt_total_valor_libros_soles.Text = ""
                txt_total_valor_libros_dolares.Text = ""
                txt_total_items.Text = ""
                progreso.Visible = False
                MsgBox("Importación correcta.", MsgBoxStyle.Information, "Sistemas")
            Else
                MsgBox("No se importarón los datos. Verifique!", MsgBoxStyle.Critical, "Sistemas")
                Exit Sub
            End If
            
        End If
    End Sub

    Private Function Importar_Bienes() As Boolean
        Dim sedesBL As New ClsOperaciones.Asiento_Contable
        Dim sedesBE As New ClsEntidades.RETENCIONES_GENERAL
        Dim ls_det_alm As New List(Of ClsEntidades.RETENCIONES_GENERAL)
        Try
            Me.Cursor = Cursors.WaitCursor

            progreso.Minimum = 0
            progreso.Maximum = dgvdetalles.Rows.Count()
            If dgvdetalles.Rows.Count > 0 Then
                Dim cateBL As New ClsOperaciones.Asiento_Contable
                sedesBL.Eliminar_Retenciones()
                For i As Integer = 0 To dgvdetalles.Rows.Count() - 1
                    sedesBE = New ClsEntidades.RETENCIONES_GENERAL
                    With sedesBE
                        progreso.Value = i
                        .RUC = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("RUC").Value), "", dgvdetalles.Rows(i).Cells("RUC").Value)
                        .SERIE_COMP = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("SERIE_COMP").Value), "", dgvdetalles.Rows(i).Cells("SERIE_COMP").Value)
                        .NUMERO_COMP = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("NUMERO_COMP").Value), "", dgvdetalles.Rows(i).Cells("NUMERO_COMP").Value)
                        .FECHA_COMP = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("FECHA_COMP").Value), "", dgvdetalles.Rows(i).Cells("FECHA_COMP").Value)
                        .IMPORTE_TOTAL_COMP = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("IMPORTE_TOTAL_COMP").Value), 0, dgvdetalles.Rows(i).Cells("IMPORTE_TOTAL_COMP").Value)
                        .TIPO = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("TIPO").Value), "", dgvdetalles.Rows(i).Cells("TIPO").Value)
                        .SERIE = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("SERIE").Value), "", dgvdetalles.Rows(i).Cells("SERIE").Value)
                        .NUMERO = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("NUMERO").Value), "", dgvdetalles.Rows(i).Cells("NUMERO").Value)
                        .FECHA_DOC = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("FECHA_DOC").Value), "", dgvdetalles.Rows(i).Cells("FECHA_DOC").Value)
                        .TOTAL_DOC = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("TOTAL_DOC").Value), 0, dgvdetalles.Rows(i).Cells("TOTAL_DOC").Value)
                        .POR_TRES_DOC = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("POR_TRES_DOC").Value), 0, dgvdetalles.Rows(i).Cells("POR_TRES_DOC").Value)
                        .MES = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("MES").Value), "", dgvdetalles.Rows(i).Cells("MES").Value)
                        .MES_INT = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("MES_INT").Value), 0, dgvdetalles.Rows(i).Cells("MES_INT").Value)
                        .ANIO = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("ANIO").Value), 0, dgvdetalles.Rows(i).Cells("ANIO").Value)
                    End With
                    'ls_det_alm.Add(sedesBE)
                    sedesBL.Guardar_Asiento_Retenciones(sedesBE)
                    progreso.PerformStep()
                Next
                progreso.Value = dgvdetalles.Rows.Count()

                cateBL = Nothing
                dgvdetalles.DataSource = Nothing
                sedesBE = Nothing
                sedesBL = Nothing
            End If

            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Private Function INGRESO_RETENCIONES() As Boolean
        Dim sedesBL As New ClsOperaciones.Asiento_Contable
        Dim sedesBE As New ClsEntidades.RETENCIONES_GENERAL
        Dim ls_det_alm As New List(Of ClsEntidades.RETENCIONES_GENERAL)
        Try
            Me.Cursor = Cursors.WaitCursor

            progreso.Minimum = 0
            progreso.Maximum = dgvdetalles.Rows.Count()
            If dgvdetalles.Rows.Count > 0 Then
                Dim cateBL As New ClsOperaciones.Asiento_Contable

                For i As Integer = 0 To dgvdetalles.Rows.Count() - 1
                    sedesBE = New ClsEntidades.RETENCIONES_GENERAL
                    With sedesBE
                        progreso.Value = i
                        .RUC = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("RUC").Value), "", dgvdetalles.Rows(i).Cells("RUC").Value)
                        .SERIE_COMP = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("Serie.Comp.Ret").Value), "", dgvdetalles.Rows(i).Cells("Serie.Comp.Ret").Value)
                        .NUMERO_COMP = IIf(IsDBNull(dgvdetalles.Rows(i).Cells("Numero.Comp.Ret").Value), "", dgvdetalles.Rows(i).Cells("Numero.Comp.Ret").Value)
                        .MES_INT = dtp_fecha.Value.Month
                        .MES = dtp_fecha.Value.ToString("MMMM")
                        .ANIO = dtp_fecha.Value.Year
                    End With
                    'ls_det_alm.Add(sedesBE)
                    sedesBL.Generar_Asiento_Retenciones_Automatico(sedesBE)
                    progreso.PerformStep()
                Next
                progreso.Value = dgvdetalles.Rows.Count()

                cateBL = Nothing
                dgvdetalles.DataSource = Nothing
                sedesBE = Nothing
                sedesBL = Nothing
            End If

            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
    Private Sub btn_ruta_Click(sender As Object, e As EventArgs) Handles btn_ruta.Click
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        txt_ruta.Text = myFileDialog.FileName.ToString

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub


    Private Sub Tool_Mostrar_Click(sender As Object, e As EventArgs) Handles Tool_Mostrar.Click
        If txt_ruta.Text.Trim = "" Then
            MsgBox("Debe elegir una Ruta del Maestro a Importar.", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If

        'If MsgBox("Esta seguro de realizar el Proceso de " & Chr(13) & " Incorporación Masiva de los Bienes.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
        Me.Cursor = Cursors.WaitCursor
        progreso.Visible = True
        Dim dt_datos As DataTable
        Dim ds_datos As DataSet
        Call importarExcel(dgvdetalles, txt_ruta.Text.Trim, dtp_fecha.Value.ToString("MMMM"))
        If dgvdetalles.Rows.Count = 0 Then Me.Cursor = Cursors.Default : Exit Sub
        ds_datos = dgvdetalles.DataSource
        dt_datos = ds_datos.Tables(0)
        txt_total_valor_libros_dolares.Text = Math.Abs(Math.Round(dt_datos.Compute("Sum(POR_TRES_DOC)", ""), 4, MidpointRounding.AwayFromZero))
        txt_total_items.Text = dt_datos.Rows.Count
        If dgvdetalles.Rows.Count > 0 Then
            If Importar_Bienes() Then
                Tool_Grabar.Enabled = True
                Dim ac As New ClsOperaciones.Asiento_Contable
                Dim dtListaAsientos As DataTable
                dtListaAsientos = New DataTable
                dtListaAsientos = ac.get_Lista_Retenciones_Importacion()
                dgvdetalles.DataSource = dtListaAsientos
                txt_total_valor_libros_soles.Text = Math.Abs(Math.Round(dtListaAsientos.Compute("Sum(MontoRetencion)", ""), 4, MidpointRounding.AwayFromZero))
                txt_total_valor_libros_soles.Text = Format(Double.Parse(txt_total_valor_libros_soles.Text), "##,##0.00")
                txt_total_valor_libros_dolares.Text = Format(Double.Parse(txt_total_valor_libros_dolares.Text), "##,##0.00")
                dgvdetalles.AutoResizeColumns()
                dgvdetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                MsgBox("No se cargo los datos.", MsgBoxStyle.Critical, "Sistemas")
                dgvdetalles.DataSource = Nothing
                Exit Sub
            End If
        End If
        progreso.Visible = False
        Me.Cursor = Cursors.Default
    End Sub

End Class