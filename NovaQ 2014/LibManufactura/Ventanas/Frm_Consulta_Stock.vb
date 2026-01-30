Public Class Frm_Consulta_Stock
    Public _codigo_producto As String
    Dim clsAlmacenCabBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
    Dim dtdetalleArticuloPrincipal As DataTable

    Private Sub Frm_Consulta_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS

            dtdetalleArticuloPrincipal = clsAlmacenCabBl.get_Detalle_Consulta_Stock(_codigo_producto)
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvDetalle.Columns(1).DefaultCellStyle.Format = "N4"
            dgvDetalle.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class