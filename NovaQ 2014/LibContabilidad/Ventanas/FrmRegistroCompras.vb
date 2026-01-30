Imports System.Windows.Forms

Public Class FrmRegistroCompras
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Private Sub ImprimirRegistroCompras()
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Registro_Compras")
            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If

            Me.Cursor = Cursors.WaitCursor
            'dtImprimir = reporteBL.EjecutarReporteRegistroCompras(dtpfecha.Value.Month, dtpfecha.Value.Year)

            If rdb_domiciliados.Checked Then
                dtImprimir = reporteBL.EjecutarReporteRegistroCompras(dtpfecha.Value.Month, dtpfecha.Value.Year)
            ElseIf rdb_no_domiciliados.Checked Then
                dtImprimir = reporteBL.EjecutarReporteRegistroCompras_No_Domiciliados(dtpfecha.Value.Month, dtpfecha.Value.Year)
            End If

            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Registro_Compras.rpt", dtImprimir, "", "", "@MES;" & dtpfecha.Value.Month, "@ANNO;" & dtpfecha.Value.Year, "@PERIODO;" & dtpfecha.Text.ToUpper, "EMPRESA;" & razon)
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
        ImprimirRegistroCompras()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub FrmRegistroCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfecha.Focus()
    End Sub
End Class