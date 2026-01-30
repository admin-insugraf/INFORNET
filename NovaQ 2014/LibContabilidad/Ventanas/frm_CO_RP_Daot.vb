Imports System.Windows.Forms
Public Class frm_CO_RP_Daot

    Private Sub frm_CO_RP_Daot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtb_ayo.Text = gFechaSis.Year
        txt_uit.Text = "3950"
        txt_por.Text = "2"
        txt_tope.Text = (Double.Parse(txt_uit.Text) * Double.Parse(txt_por.Text))
    End Sub

    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As Object, e As EventArgs) Handles Tool_imprimir.Click
        If txt_tope.Text.Equals(String.Empty) Then
            MessageBox.Show("Ingrese el Tope", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Dim reporteBL As New ClsOperaciones.ReportesCO
        Dim crystalBL As New LibReportes.ClsReporte
        Dim fq As New ClsOperaciones.freeQuery
        Dim dt_tmp As DataTable = Nothing
        dt_tmp = New DataTable
        Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
        Dim ruc As String = String.Empty
        Dim razon As String = String.Empty
        Dim titulo As String = String.Empty

        If dt_info_emp.Rows.Count() <> 0 Then
            'ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
            'razon = dt_info_emp.Rows(0)("NAME").ToString()
            ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
            razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
        End If

        dt_info_emp = Nothing
        fq = Nothing

        If rb_gastos.Checked Then
            titulo = "Gastos acumulados a Diciembre " & mtb_ayo.Text
        Else
            titulo = "Ingresos acumulados a Diciembre " & mtb_ayo.Text
        End If

        dt_tmp = reporteBL.Daot(Integer.Parse(mtb_ayo.Text), IIf(rb_gastos.Checked, 1, 2), Double.Parse(txt_tope.Text))

        crystalBL.Muestra_Reporte("CO_08.RPT", dt_tmp, "", "", "pEmpresa;" & razon, "pRuc;", "pTitulo;" & titulo, "pResumen;" & IIf(rb_resumen.Checked, "1", "0"))

        dt_tmp = Nothing
        reporteBL = Nothing
        crystalBL = Nothing

        Cursor = Cursors.Default

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
End Class