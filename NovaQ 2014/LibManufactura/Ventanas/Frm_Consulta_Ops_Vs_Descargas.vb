Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO

Public Class Frm_Consulta_Ops_Vs_Descargas
    Dim clsPedidoBl As LibManufactura.ClsOperaciones.ORDERS

    Private Sub Frm_Consulta_Ops_Vs_Descargas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub txt_numero_op_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_numero_op.MouseDoubleClick
        Mostrando_Ops()
    End Sub

    Private Sub txt_numero_op_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero_op.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Ops()
    End Sub

    Private Sub Mostrando_Ops()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_PRODUCCION_OP_PRODUCTOS_CONSULTA_OP"
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de O.P."
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_numero_op.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            Else
                txt_numero_op.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Try
            If txt_numero_op.Text = "" Then
                MsgBox("Debe elegir una Orden de Producción.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS

            Dim dt_detalle_despachos_programados As DataSet

            dt_detalle_despachos_programados = clsPedidoBl.get_Reporte_Comparativo_OP_vs_Dispensado_Consulta(txt_numero_op.Text)

            If dt_detalle_despachos_programados.Tables.Count <> 0 Then
                dgv_detalle_insumos.DataSource = dt_detalle_despachos_programados.Tables(0)
                dgv_detalle_descargas.DataSource = dt_detalle_despachos_programados.Tables(1)

                dgv_detalle_insumos.AutoResizeColumns()
                dgv_detalle_insumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                dgv_detalle_insumos.Columns("CANTIDAD.ORDEN").DefaultCellStyle.Format = "N2"
                dgv_detalle_insumos.Columns("CANTIDAD.ORDEN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgv_detalle_insumos.Columns("CANTIDAD.INSUMO").DefaultCellStyle.Format = "N2"
                dgv_detalle_insumos.Columns("CANTIDAD.INSUMO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgv_detalle_descargas.AutoResizeColumns()
                dgv_detalle_descargas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                dgv_detalle_descargas.Columns("CANTIDAD.INSUMO").DefaultCellStyle.Format = "N2"
                dgv_detalle_descargas.Columns("CANTIDAD.INSUMO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Else
                dgv_detalle_insumos.DataSource = Nothing
                dgv_detalle_descargas.DataSource = Nothing
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class