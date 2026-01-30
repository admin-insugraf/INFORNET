Imports System.Windows.Forms
Imports LibComunVar
Imports LibContabilidad
Public Class FrmRep_Daot_Ventas

    Private Sub FrmRep_Daot_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtb_ayo.Text = LibComunVar.ClsVarComun.FechaSistema.Year
        txt_uit.Text = "3885"
        txt_por.Text = "2"
        txt_tope.Text = (Double.Parse(txt_uit.Text) * Double.Parse(txt_por.Text))
        mtb_ayo.Focus()
    End Sub


    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As Object, e As EventArgs) Handles Tool_imprimir.Click
        If txt_tope.Text.Equals(String.Empty) Then
            MessageBox.Show("Ingrese el Tope", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Cursor = Cursors.WaitCursor

            Dim reporteBL As New ClsOperaciones.ReportesCO
            Dim crystalBL As New LibReportes.ClsReporte
            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_tmp As DataTable = Nothing
            dt_tmp = New DataTable
            Dim dt_info_emp As DataTable
            dt_info_emp = New DataTable
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            Dim titulo As String = String.Empty

            If dt_info_emp.Rows.Count() <> 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("NAME").ToString()
            End If

            dt_info_emp = Nothing
            fq = Nothing

            titulo = "Ventas acumuladas a Diciembre " & mtb_ayo.Text

            dt_tmp = reporteBL.Daot_Ventas(Integer.Parse(mtb_ayo.Text), 0, Double.Parse(txt_tope.Text))
            If dt_tmp.Rows.Count > 0 Then
                crystalBL.Muestra_Reporte("CO_08_DAOT_VENTAS.RPT", dt_tmp, "", "", "pEmpresa;" & razon, "pRuc;", "pTitulo;" & titulo, "pResumen;" & IIf(rb_resumen.Checked, "1", "0"))
            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If



            dt_tmp = Nothing
            reporteBL = Nothing
            crystalBL = Nothing

            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_uit_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_uit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_uit.Text.Equals(String.Empty) Then Exit Sub
            If txt_por.Text.Equals(String.Empty) Then Exit Sub
            txt_tope.Text = (Double.Parse(txt_uit.Text) * Double.Parse(txt_por.Text)).ToString()
            txt_por.Focus()
        End If
    End Sub

    Private Sub txt_por_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_por.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_uit.Text.Equals(String.Empty) Then Exit Sub
            If txt_por.Text.Equals(String.Empty) Then Exit Sub
            txt_tope.Text = (Double.Parse(txt_uit.Text) * Double.Parse(txt_por.Text)).ToString()
            txt_tope.Focus()
        End If
    End Sub

    Private Sub mtb_ayo_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_ayo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_uit.Focus()
        End If
    End Sub

    Private Sub txt_tope_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tope.KeyDown
        If e.KeyCode = Keys.Enter Then
            rb_resumen.Focus()
        End If
    End Sub
End Class