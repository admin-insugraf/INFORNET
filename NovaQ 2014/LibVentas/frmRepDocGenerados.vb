Imports System.Windows.Forms

Public Class frmRepDocGenerados
    Private CRep As LibReportes.ClsReporte
    Private Sub tImprimir_Click(sender As Object, e As EventArgs) Handles tImprimir.Click
        Dim DTFechaInicio As Date, DTFechaFin As Date

        DTFechaInicio = Format(dtpFechaIni.Value, "Short Date")
        DTFechaFin = Format(dtpFechaFin.Value, "Short Date")

        If DTFechaInicio > DTFechaFin Then
            MessageBox.Show("El rango de fechas es incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtpFechaIni.Focus()
            Exit Sub
        End If

        CRep = New LibReportes.ClsReporte
        CRep.Muestra_Reporte("Sal_Receivable_Date.rpt", "", "@FECHA_INI;" & DTFechaInicio,
                            "@FECHA_FIN;" & DTFechaFin)
        CRep = Nothing
    End Sub

    Private Sub tSalir_Click(sender As Object, e As EventArgs) Handles tSalir.Click
        CRep = Nothing
        Me.Close()
    End Sub
End Class