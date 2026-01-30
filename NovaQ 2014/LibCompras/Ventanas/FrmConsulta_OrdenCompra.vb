Public Class FrmConsulta_OrdenCompra
    Public _NRO_OF As String = String.Empty


    Dim Modo_consultar As Boolean = False
    Dim OrdenCompraCabENT As ClsEntidades.PURCHASE_ORDER
    Dim OrdenCompraDetENT As ClsEntidades.PURCHASE_ORDER_LINE
    Dim ListaDetalles As List(Of ClsEntidades.PURCHASE_ORDER_LINE)

    Dim OrdenCompraBl As ClsOperaciones.PURCHASE_ORDER

    Dim CORRELATIVOBL As ClsTransacciones.PURCHASE_ORDER
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Dim dtdetalleArticuloPrincipal As DataTable
    Dim Fl_close As Boolean = False
    Dim TIPO_FORMULA, TIPO_PROD As String

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim _Flag_edicion As Boolean = False
    Dim dtResultados As DataTable

    Dim _Codigo_Ini As String = ""
    Dim _TipoAnexoDoc As String = ""
    Dim _TipoDato As String = ""
    Dim _NumeroTipoAnexoDoc As String = ""
    Public _valor_igv As Double
    Private Sub FrmConsulta_OrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(Date.Now)
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(Date.Now)
        cboopcionesBusqueda.SelectedIndex = 1
        txtFiltro.Focus()
    End Sub

    Private Sub imprimir_Orden_Compra(ByVal _Codigo As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("OrdenCompra")
            Me.Cursor = Cursors.WaitCursor

            Dim fq As New LibContabilidad.ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty

            If dt_info_emp.Rows.Count > 0 Then
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
            End If

            dtImprimir = reporteBL.EjecutarReporte_Mov_Almacen_x_Orden_Compra(_Codigo)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_mov_alm_x_oc_II.rpt", dtImprimir, "", "", "@ID_OC;" & _Codigo, "@TYPE_OC;" & "OC", "RUC;" & ruc, "EMPRESA;" & razon)
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try

        'Try
        '    reporteBL = New ClsBuscar
        '    crystalBL = New LibReportes.ClsReporte
        '    dtImprimir = New DataTable("OrdenCompra")
        '    Me.Cursor = Cursors.WaitCursor

        '    dtImprimir = reporteBL.EjecutarReporte_Mov_Almacen_x_Orden_Compra_Detalle(_Codigo)
        '    If dtImprimir.Rows.Count() <> 0 Then
        '        crystalBL.Muestra_Reporte("rpt_mov_alm_x_oc_detalle.rpt", dtImprimir, "", "")
        '    End If
        '    Me.Cursor = Cursors.Default

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub

    Private Sub imprimir_Orden_Compra_Movs_Compras(ByVal _Codigo As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("OrdenCompra")
            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.EjecutarReporte_Mov_Almacen_x_Orden_Compra_Movs_Compras(_Codigo)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_mov_alm_x_oc.rpt", dtImprimir, "", "", "@ID_OC;" & _Codigo, "@TYPE_OC;" & "OC")
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function Cierre_Manual_Orden_Compra(ByVal _Codigo As String) As Boolean
        Try

            Me.Cursor = Cursors.WaitCursor

            If System.Windows.forms.MessageBox.Show("Se va a Cerrar Manualmente la Orden de Compra" & vbCrLf & "¿Desea continuar?", "Sistemas", System.Windows.forms.MessageBoxButtons.YesNo, System.Windows.forms.MessageBoxIcon.Question) = System.Windows.forms.DialogResult.Yes Then
                If OrdenCompraBl.Cierre_Manual_Oden_Compra(_Codigo, txtref_tipo.Text.Trim, txtref_serie.Text.Trim, txtref_num_doc.Text.Trim, _
                                                           dtpRef_fecha.Value.ToString("dd/MM/yyyy"), txt_observaciones.Text.Trim) Then
                    MsgBox("Orden de Compra cerrado correctamente", MsgBoxStyle.Information, "Sistemas")
                    DocumentosOrdenCompra()
                    Me.Cursor = Cursors.Default
                    Return True
                End If
            End If


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Dim _Id As String = String.Empty

        _Id = dgvCabecera.CurrentRow.Cells("ID").Value
        imprimir_Orden_Compra(_Id)
    End Sub


    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Enabled = False
            Case 1
                gbRangofechas.Enabled = False
            Case 2
                gbRangofechas.Enabled = True
        End Select
        txtFiltro.Text = String.Empty
        DocumentosOrdenCompra()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If dgvCabecera.Rows.Count > 0 Then
            If txtFiltro.Text = String.Empty Then
                dtv.RowFilter = String.Empty
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                Exit Sub
            Else
                'For Each row As DataGridViewRow In dgvCabecera.Rows
                '    row.Cells(11).Value = False
                'Next
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns(0).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(2).Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvCabecera.Columns(3).Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(3).Name
                                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                Exit Sub
                            End If
                        End If
                    End If
                End If
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        End If
        
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosOrdenCompra()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub


    Private Sub dgvCabecera_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvCabecera.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvCabecera.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgvCabecera.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("DESCRIPTION").Value = "ANULADA" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub


    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            For i As Integer = 15 To 33
                dgvDetalle.Columns(i).Visible = False
            Next

            For j As Integer = 6 To 16
                dgvDetalle.Columns(j).DefaultCellStyle.Format = "N2" ' "##,##0.00"
                dgvDetalle.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next
            dgvDetalle.Columns(0).HeaderText = "Item"
            dgvDetalle.Columns(1).HeaderText = "Codigo"
            dgvDetalle.Columns(2).HeaderText = "Producto"
            dgvDetalle.Columns(3).HeaderText = "Unidad"
            dgvDetalle.Columns(4).HeaderText = "Unid.Ref"
            dgvDetalle.Columns(6).HeaderText = "Cantidad"
            dgvDetalle.Columns(7).HeaderText = "Precio"
            dgvDetalle.Columns(8).HeaderText = "%.Descuento"
            dgvDetalle.Columns(9).HeaderText = "Descuento"
            dgvDetalle.Columns(10).HeaderText = "I.g.v"
            dgvDetalle.Columns(12).HeaderText = "Valor.Venta"
            dgvDetalle.Columns(14).HeaderText = "Total"
            dgvDetalle.Columns(25).HeaderText = "Nro.Cotizacion"
            dgvDetalle.Columns(26).HeaderText = "Nro.Requisicion"

            dgvDetalle.Columns(4).Visible = False
            dgvDetalle.Columns(5).Visible = False
            dgvDetalle.Columns(11).Visible = False
            dgvDetalle.Columns(13).Visible = False
            dgvDetalle.Columns(25).Visible = True
            dgvDetalle.Columns(26).Visible = True
            dgvDetalle.Columns(27).Visible = False
            dgvDetalle.Columns(28).Visible = False
            dgvDetalle.Columns(29).Visible = False
            dgvDetalle.Columns(30).Visible = False
        End If
    End Sub
    Private Sub DocumentosOrdenCompra()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim sTipoOrden As String = String.Empty
            sTipoOrden = "OC"
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            Dim dtDocumentos As New DataTable
            dtv = New DataView
            dtDocumentos = OrdenCompraBl.Mostrar_Documentos_Principal_Consulta(sTipoOrden, dtpfechaInicial.Value.ToString("dd/MM/yyyy"), CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")), IIf(cboopcionesBusqueda.SelectedIndex = 0, "TODOS", (IIf(cboopcionesBusqueda.SelectedIndex = 1, "MES", "RANGO"))), LibComunVar.ClsVarComun.USUARIO)
            'dtDocumentos.Columns.Add("Imprimir Requisicion", Type.GetType("System.Boolean"))
            dtv = dtDocumentos.DefaultView
            STRorden = ""
            Try
                If dgvCabecera.RowCount >= 1 Then
                    For i As Integer = 0 To dgvCabecera.RowCount - 1
                        dgvCabecera.Rows.Remove(dgvCabecera.CurrentRow)
                    Next
                End If
            Catch ex As InvalidOperationException ' Esta excepcion es por si ocurriera
                Me.Cursor = Cursors.Default
                MsgBox("Esta fila no se puede eliminar", MsgBoxStyle.Critical, "Operación inválida : : : . . .")
            End Try

            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv

                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(3).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DocumentosLetras(ByVal _CodigoPlanilla As String)
        Try
            OrdenCompraBl = New ClsOperaciones.PURCHASE_ORDER
            ' GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = OrdenCompraBl.Modo_Edicion_Detalle_II(_CodigoPlanilla)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                ConfigurarGrila()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cierre_manual_Click(sender As Object, e As EventArgs) Handles btn_cierre_manual.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        If dgvCabecera.CurrentRow.Cells("DESCRIPTION").Value = "REC.TOTAL" Then
            MsgBox("La Orden de Compra no puede cerrarse manualmente. Verifique!", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        Else
            pnlDocReferencia.Visible = True
            pnlCabecera.Enabled = False
            btn_menu.Enabled = False
            txtref_tipo.Text = ""
            txtref_serie.Text = ""
            txtref_num_doc.Text = ""
            txt_observaciones.Text = ""
            dtpRef_fecha.Value = Date.Now
            txtref_tipo.Focus()
            'Cierre_Manual_Orden_Compra(dgvCabecera.CurrentRow.Cells("ID").Value)
        End If

    End Sub

    Private Sub txtref_tipo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtref_tipo.MouseDoubleClick
        Ayuda_Tipo_Doc()
    End Sub

    Private Sub txtref_tipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_tipo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tipo_Doc()
        ElseIf e.KeyCode = Keys.Enter Then
            If txtref_tipo.Text = "" Then
                Ayuda_Tipo_Doc()
            Else
                txtref_serie.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Tipo_Doc()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_S_S_DOCUMENT_TYPE"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Titulo = "Tipos de Documentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtref_tipo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtref_tipo.Text = "" Then
            MsgBox("Debe elegir un Tipo de Documento de Referencia. Verifique!", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If

        If txtref_serie.Text = "" Then
            MsgBox("Debe ingresar la serie del Documento de Referencia. Verifique!", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If

        If txtref_num_doc.Text = "" Then
            MsgBox("Debe ingresar el Número del Documento de Referencia. Verifique!", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If

        If Cierre_Manual_Orden_Compra(dgvCabecera.CurrentRow.Cells("ID").Value) Then
            btnSalr_Click(sender, e)
        End If

    End Sub

    Private Sub btnSalr_Click(sender As Object, e As EventArgs) Handles btnSalr.Click
        pnlCabecera.Enabled = True
        btn_menu.Enabled = True
        pnlDocReferencia.Visible = False
    End Sub

    
    Private Sub txtref_serie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_serie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtref_num_doc.Focus()
        End If
    End Sub

    Private Sub txtref_num_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref_num_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpRef_fecha.Focus()
        End If
    End Sub

    Private Sub dtpRef_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpRef_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_observaciones.Focus()
        End If
    End Sub

    Private Sub btn_mov_compras_Click(sender As Object, e As EventArgs) Handles btn_mov_compras.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Dim _Id As String = String.Empty

        _Id = dgvCabecera.CurrentRow.Cells("ID").Value
        imprimir_Orden_Compra_Movs_Compras(_Id)
    End Sub

    Private Sub dgvCabecera_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCabecera.CellClick
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString) Then Exit Sub
        Dim CodigoPlanilla As String = dgvCabecera.CurrentRow.Cells("ID").Value
        DocumentosLetras(CodigoPlanilla)
    End Sub

    Private Sub txt_observaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_observaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()
        End If
    End Sub

    Private Sub IngresosAlAlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosAlAlmacenToolStripMenuItem.Click
        'If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        'If dgvDetalle.Rows.Count = 0 Then Exit Sub

        'Dim frmdetalle As new FrmListaIngresosOrdenCompra
        'frmdetalle.numero_orden = dgvCabecera.CurrentRow.Cells("ID").Value
        'frmdetalle.tipo_orden = "OC"
        'frmdetalle.item_orden = dgvDetalle.CurrentRow.Cells("ITEM").Value
        'frmdetalle.producto_orden = dgvDetalle.CurrentRow.Cells("PART_ID").Value
        'frmdetalle.ShowDialog()
    End Sub
End Class