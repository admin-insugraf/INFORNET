Imports System.Windows.Forms
Public Class frm_CO_RP_BalInven

    Private Sub frm_CO_RP_BalInven_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtb_ayo.Text = Date.Now.Year
    End Sub

    Private Sub Tool_imprimir_Click(sender As Object, e As EventArgs) Handles Tool_imprimir.Click
        Dim dt_repor As DataTable = Nothing
        Dim repBL As New ClsOperaciones.ReportesCO
        Dim crystalBL As New LibReportes.ClsReporte
        Dim periodo_repo As Integer = Integer.Parse(mtb_ayo.Text)

        If (rb10.Checked) Then dt_repor = repBL.get_BI_cta10(periodo_repo)
        If (rb12.Checked) Then dt_repor = repBL.get_BI_cta12(periodo_repo, IIf(rdb_resumido.Checked, 1, 2))
        If (rb14.Checked) Then dt_repor = repBL.get_BI_cta14(periodo_repo)
        If (rb16.Checked) Then dt_repor = repBL.get_BI_cta16(periodo_repo)
        If (rb19.Checked) Then dt_repor = repBL.get_BI_cta19(periodo_repo)
        If (rb31.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA31", periodo_repo)
        If (rb33.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA33", periodo_repo)
        If (rb34.Checked) Then dt_repor = repBL.get_BI_cta34(periodo_repo)
        If (rb37.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA37", periodo_repo)
        If (rb39.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA39", periodo_repo)
        If (rb40.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA40", periodo_repo)
        If (rb41.Checked) Then dt_repor = repBL.get_BI_cta41(periodo_repo)
        If (rb42.Checked) Then dt_repor = repBL.get_BI_cta42(periodo_repo, IIf(rdb_resumido.Checked, 1, 2))
        If (rb44.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA44", periodo_repo)
        If (rb45.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA45", periodo_repo)
        If (rb46.Checked) Then dt_repor = repBL.get_BI_cta46(periodo_repo)
        If (rb49.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA49", periodo_repo)
        If (rb50.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA50", periodo_repo)
        If (rb52.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA52", periodo_repo)
        If (rb59.Checked) Then dt_repor = repBL.get_BI_ctaX("CO_SP_S_BI_CTA59", periodo_repo)

        Dim fq As New ClsOperaciones.freeQuery
        Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
        Dim ruc As String = String.Empty
        Dim razon As String = String.Empty

        If dt_info_emp.Rows.Count > 0 Then
            razon = dt_info_emp.Rows(0)("NAME").ToString()
        End If

        dt_info_emp = Nothing
        fq = Nothing

        If (rb10.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb12.Checked) Then
            If rdb_resumido.Checked Then
                dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'crystalBL.Muestra_Reporte("CO_IB_12.RPT", dt_repor, "", "", "pPeriodo;" & mtb_ayo.Text.Trim(), "pEmpresa;" & razon, "@P_PERIODO;" & mtb_ayo.Text.Trim())
            ElseIf rdb_detallado.Checked Then
                dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'crystalBL.Muestra_Reporte("CO_IB_12_DETALLADO.RPT", dt_repor, "", "", "pPeriodo;" & mtb_ayo.Text.Trim(), "pEmpresa;" & razon, "@P_PERIODO;" & mtb_ayo.Text.Trim())
            End If
        End If

        If (rb14.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb16.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb19.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb31.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb33.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb34.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb37.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb39.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb40.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb41.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb42.Checked) Then
            If rdb_resumido.Checked Then
                'crystalBL.Muestra_Reporte("CO_IB_42.RPT", dt_repor, "", "", "pPeriodo;" & mtb_ayo.Text.Trim(), "pEmpresa;" & razon, "@P_PERIODO;" & mtb_ayo.Text.Trim())
                dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            ElseIf rdb_detallado.Checked Then
                'crystalBL.Muestra_Reporte("CO_IB_42_DETALLADO.RPT", dt_repor, "", "", "pPeriodo;" & mtb_ayo.Text.Trim(), "pEmpresa;" & razon, "@P_PERIODO;" & mtb_ayo.Text.Trim())
                dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        End If
        If (rb44.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb45.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb46.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb49.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb50.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb52.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If (rb59.Checked) Then dgv_detalle.DataSource = dt_repor : dgv_detalle.AutoResizeColumns() : dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        crystalBL = Nothing

        '        MessageBox.Show("Informacion procesada, No se encuentra Reporte Fisico", "Sistema")
        Cursor = Cursors.Default
    End Sub

    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub
End Class