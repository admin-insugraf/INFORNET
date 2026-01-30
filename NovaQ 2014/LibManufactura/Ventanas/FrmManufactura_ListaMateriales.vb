Public Class FrmManufactura_ListaMateriales

    Public NRO_OF As String = String.Empty
    Public WHO_ID As String = String.Empty


    Dim Modo_consultar As Boolean = False
    Dim OrdenProduccionCabENT As ClsEntidades.ORDER_PRODUCTION
    Dim OrdenProduccionDetENT As ClsEntidades.ORDER_PRODUCTION_LINE
    Dim ListaDetalles As List(Of ClsEntidades.ORDER_PRODUCTION_LINE)

    Dim OrdenProduccionBl As ClsOperaciones.ORDER_PRODUCTION
    Dim CORRELATIVOBL As ClsTransacciones.ORDER_PRODUCTION
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim Fl_close As Boolean = False
    Dim Modo_Edicion As Boolean = False

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Dim _FechaVencimiento As String = String.Empty
    Dim _Rs As String = String.Empty
    Dim _Volumen As String = String.Empty
    Dim _Composicion As String = String.Empty

    Dim dtDocumentos As DataTable


    Public Sub valida_cantidad(ByVal dtDatos As DataTable)
        Dim validando_qty_sin_stock As Boolean = True
        Dim validando_qty_comprometido As Boolean
        For Each row As DataRow In dtDatos.Rows
            If row("DIFERENCIA") < 0 Then
                validando_qty_sin_stock = False
                Exit For
            End If
        Next
  
        Dim SQL As String
        SQL = "SELECT COMPROMETIDO FROM dbo.ORDER_PRODUCTION WHERE ID='" & NRO_OF & "'"
        OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
        Dim dtCantidad As New DataTable
        dtCantidad = OrdenProduccionBl.Mostrar_Consulta(SQL)
        If dtCantidad.Rows.Count() <> 0 Then
            If dtCantidad.Rows(0).Item("COMPROMETIDO").ToString = "1" Then
                validando_qty_comprometido = False
            Else
                validando_qty_comprometido = True
            End If
        End If
        If validando_qty_comprometido = True And validando_qty_sin_stock = True Then
            btn_comprometer.Enabled = True
            btn_liberar.Enabled = False
        ElseIf validando_qty_comprometido = False Then
            btn_comprometer.Enabled = False
            btn_liberar.Enabled = True
        ElseIf validando_qty_comprometido = True And validando_qty_sin_stock = False Then
            btn_comprometer.Enabled = False
            btn_liberar.Enabled = False
        End If
    End Sub

    Public Sub Comprometer_Mercaderia(ByVal dtDatos As DataTable)
        OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
        If OrdenProduccionBl.Comprometer_Mercaderia(dtDatos, NRO_OF, WHO_ID) Then
            MsgBox("Proceso Generado Correctamente.", MsgBoxStyle.Information)
        Else
            MsgBox("Se producierón errores al generar el proceso.", MsgBoxStyle.Critical, "Sistemas")
        End If
    End Sub

    Private Sub DocumentosPlanificacion()
        Try
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            dtDocumentos = New DataTable
            dtDocumentos = OrdenProduccionBl.Mostrar_Documentos_Principal_Materiales(NRO_OF)
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtDocumentos
                ''dgvCabecera.Columns(1).DefaultCellStyle.Format = "MMMM (yyyy)"
                dgvCabecera.Columns(0).HeaderText = "Nro.OF"
                dgvCabecera.Columns(1).HeaderText = "Cod.Producto"
                dgvCabecera.Columns(2).HeaderText = "Producto/Insumo"
                dgvCabecera.Columns(3).HeaderText = "Unidad"
                dgvCabecera.Columns(4).HeaderText = "Stock en el sistema"
                dgvCabecera.Columns(5).HeaderText = "Cantidad Comprometida"
                dgvCabecera.Columns(6).HeaderText = "Cantidad requerida de la O.F."
                dgvCabecera.Columns(7).HeaderText = "Diferencia"

                dgvCabecera.Columns(4).DefaultCellStyle.Format = "N6"
                dgvCabecera.Columns(5).DefaultCellStyle.Format = "N6"
                dgvCabecera.Columns(6).DefaultCellStyle.Format = "N6"
                dgvCabecera.Columns(7).DefaultCellStyle.Format = "N6"

                dgvCabecera.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvCabecera.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                valida_cantidad(dtDocumentos)
            Else
                MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmManufactura_Formulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DocumentosPlanificacion()
    End Sub

    Private Sub btn_orden_Compra_Click(sender As Object, e As EventArgs) Handles btn_orden_Compra.Click
        Dim frmOrdenC As New FrmManufactura_Orden_Compra
        frmOrdenC._NRO_OF = NRO_OF
        frmOrdenC.ShowDialog()
    End Sub

    Private Sub btn_comprometer_Click(sender As Object, e As EventArgs) Handles btn_comprometer.Click
        If dtDocumentos.Rows.Count() <> 0 Then
            Comprometer_Mercaderia(dtDocumentos)
            ToolStripButton1_Click(sender, e)
        End If
    End Sub

    Public Sub Liberar_Mercaderia(ByVal dtDatos As DataTable)
        OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
        If OrdenProduccionBl.Liberar_Mercaderia(dtDatos, NRO_OF, WHO_ID) Then
            MsgBox("Proceso Generado Correctamente.", MsgBoxStyle.Information)
        Else
            MsgBox("Se producierón errores al generar el proceso.", MsgBoxStyle.Critical, "Sistemas")
        End If
    End Sub


    Private Sub btn_liberar_Click(sender As Object, e As EventArgs) Handles btn_liberar.Click
        If dtDocumentos.Rows.Count() <> 0 Then
            Liberar_Mercaderia(dtDocumentos)
            ToolStripButton1_Click(sender, e)
        End If
    End Sub

    Private Sub imprimir_Lista_Materiales(ByVal _Codigo As String, ByVal _Almacen As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtImprimir_OP As New DataTable()
            Dim dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir_OP = reporteBL.EjecutarReporteOrdenProduccion(_Codigo, _Almacen)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir_OP.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Orden_Produccion_Planificacion.rpt", "", "", "", "@OF;" & _Codigo, "@ALMACEN;" & _Almacen, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_Imprimir_Click(sender As Object, e As EventArgs) Handles btn_Imprimir.Click
        Dim _id As String = String.Empty
        Dim _Alm As String = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Alm = WHO_ID
        imprimir_Lista_Materiales(_id, _Alm)
    End Sub

 
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If CDbl(dgvCabecera.Rows(e.RowIndex).Cells("DIFERENCIA").Value) < 0 Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub
End Class