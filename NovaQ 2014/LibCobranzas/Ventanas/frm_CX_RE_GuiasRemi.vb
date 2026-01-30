Public Class frm_CX_RE_GuiasRemi

    Private Sub frm_CX_RE_GuiasRemi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Call Consultar()
    End Sub

    Private Sub Consultar()
        Dim almBL As New ClsOperaciones.WAREHOUSE_TRANS
        dgv_cab.DataSource = almBL.get_Guias_x_Fechas(CDate(dtp_fec_ini.Value).ToShortDateString, CDate(dtp_fec_fin.Value).ToShortDateString)
        almBL = Nothing
    End Sub

    Private Sub Consultar_Detalle()

        Dim alm As String = dgv_cab.CurrentRow.Cells("WAREHOUSE_ID").Value.ToString
        Dim doc As String = dgv_cab.CurrentRow.Cells("DOCUMENT_ID").Value.ToString
        Dim num As String = dgv_cab.CurrentRow.Cells("NUMBER_DOCUMENT").Value.ToString

        Dim guiaDetBL As New ClsOperaciones.WAREHOUSE_TRANS_LINE
        dgv_detalle.DataSource = guiaDetBL.get_Detalle_Guia(alm, doc, num)
        guiaDetBL = Nothing

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub dgv_cab_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgv_cab.CellClick
        Call Consultar_Detalle()
    End Sub

    Private Sub Tool_Imprimir_Click(sender As Object, e As EventArgs) Handles Tool_Imprimir.Click
        Dim dt_data_repo As DataTable = Nothing
        Dim reportesBL As New ClsOperaciones.ReportesCX
        Dim crystalBL As New LibReportes.ClsReporte

        Dim almacen As String = dgv_cab.CurrentRow.Cells("WAREHOUSE_ID").Value.ToString
        Dim docu As String = dgv_cab.CurrentRow.Cells("DOCUMENT_ID").Value.ToString & "-" & dgv_cab.CurrentRow.Cells("NUMBER_DOCUMENT").Value.ToString
        Dim cliente As String = dgv_cab.CurrentRow.Cells("CUSTOMER_NAME").Value.ToString
        Dim comentario As String = dgv_cab.CurrentRow.Cells("COMMENT").Value.ToString
        Dim fecha As String = dgv_cab.CurrentRow.Cells("DATE_DOCUMENT").Value.ToString

        Cursor = Windows.Forms.Cursors.WaitCursor
        dt_data_repo = CType(dgv_cab.DataSource, DataTable)  ' reportesBL.get_Saldos_x_Cliente(rb_todos.Checked, Environment.MachineName)
        crystalBL.Muestra_Reporte("CX_03.RPT", dt_data_repo, "", "", "pEmpresa;" & gNomEmpresa, "pAlmacen;" & almacen, "pDoc;" & docu, "pCliente;" & cliente, "pComen;" & comentario, "pFecha;" & fecha)
        Cursor = Windows.Forms.Cursors.Default
        crystalBL = Nothing
        reportesBL = Nothing
    End Sub
End Class