Imports System.Windows.Forms
Public Class FrmManufactura_Liquidacion
    Dim OrdenProduccionBl As ClsOperaciones.ORDER_PRODUCTION
    Dim _id As String = String.Empty
    Dim _Who As String = String.Empty
    Dim _estado_compromiso As String = String.Empty
    Dim _cantidad_terminada As Double
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim Fl_close As Boolean = False
    Dim Modo_Edicion As Boolean = False
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim ManufactutraBl As ClsOperaciones.FORMULATION
    Dim ManufactutraCabENT As ClsEntidades.LIQUIDACION_OP
    Dim ManufactutraDetENT As ClsEntidades.LIQUIDACION_OP_LINE
    Dim ListaDetalles As List(Of ClsEntidades.LIQUIDACION_OP_LINE)
    Private Sub FrmManufactura_Liquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        cboopcionesBusqueda.SelectedIndex = 1
        cboMostrar.SelectedIndex = 4
        Cargar_Moneda()
        Documentos_Orden_Fabricacion()
    End Sub
    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_GenerarOf.Enabled = False
            btn_liquidacion_manual.Enabled = False
            btn_grabar.Enabled = True
            btn_cancelar.Enabled = True
            btn_Imprimir.Enabled = False
        Else
            btn_GenerarOf.Enabled = True
            btn_liquidacion_manual.Enabled = True
            btn_grabar.Enabled = False
            btn_cancelar.Enabled = False
            btn_Imprimir.Enabled = True
        End If
    End Sub
    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cmbmoneda.DataSource = monedaBL.get_TiposCambio()
        cmbmoneda.ValueMember = "CODIGO"
        cmbmoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub
    Private Sub Documentos_Orden_Fabricacion()
        Try
            Dim Tipodoc As String = String.Empty
            If cboMostrar.Text = "Planificacion" Then
                Tipodoc = "01"
            ElseIf cboMostrar.Text = "Produccion" Then
                Tipodoc = "02"
            ElseIf cboMostrar.Text = "Anuladas" Then
                Tipodoc = "03"
            ElseIf cboMostrar.Text = "Terminadas" Then
                Tipodoc = "04"
            ElseIf cboMostrar.Text = "Liquidadas" Then
                Tipodoc = "05"
            End If
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtDocumentos As New DataTable
            dtDocumentos = OrdenProduccionBl.Mostrar_Documentos_Orden_Fabricacion(Tipodoc, cboopcionesBusqueda.SelectedIndex, _
                                                                          dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"))
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtDocumentos

                dgvCabecera.Columns(4).Visible = False
                dgvCabecera.Columns(7).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(9).HeaderText = "Observación"
                dgvCabecera.Columns(12).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(14).Visible = False
                dgvCabecera.Columns(15).Visible = False
                dgvCabecera.Columns(16).Visible = False
                dgvCabecera.Columns(17).Visible = False
                dgvCabecera.Columns(18).HeaderText = "Estado de Compromiso"
                dgvCabecera.Columns(19).Visible = False
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvCabecera.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Else
                ' MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_GenerarOf_Click(sender As Object, e As EventArgs) Handles btn_GenerarOf.Click
        Nuevo()
        Botonera_Estado_Cambiar(True)
    End Sub
    Private Sub Nuevo()
        Try
            pnlCabecera.Visible = False
            Modo_Edicion = False
            gbcabecera.Enabled = True
            txtcodigo.Text = dgvCabecera.CurrentRow.Cells("Nro.O.F").Value
            lblsaldo.Text = dgvCabecera.CurrentRow.Cells("Cantidad Terminada").Value
            _cantidad_terminada = CDbl(dgvCabecera.CurrentRow.Cells("Cantidad Terminada").Value)
            txt_producto.Text = dgvCabecera.CurrentRow.Cells("Producto a Fabricar").Value
            txt_num_lote.Text = dgvCabecera.CurrentRow.Cells("Lote").Value
            GenerarColummnaDataTable()
            cmbmoneda.SelectedIndex = 1
            dgvDetalles.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID_PRES", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION_PRES", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT_PRES", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AVERAGE_COST_PROM", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AVERAGE_COST_ULT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AVERAGE_COST_PRES_PROM", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AVERAGE_COST_PRES_ULT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("WHO_PRES", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("AVERAGE_COST_TOTAL_PROM", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AVERAGE_COST_TOTAL_ULT", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("WHO_INGRESO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("WHO_DES_INGRESO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY_REAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("TIPO_LIQUIDACION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_Imprimir_Click(sender As Object, e As EventArgs) Handles btn_Imprimir.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        _id = String.Empty
        _Who = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Who = dgvCabecera.Item(16, dgvCabecera.CurrentRow.Index).Value
        imprimirAlmacen(_id, _Who)
    End Sub

    Private Sub dgvCabecera_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCabecera.SelectionChanged
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtResultado As DataTable
            Dim _NroOf As String = String.Empty
            Dim TEXTO As String = String.Empty
            _NroOf = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value

            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            dtResultado = New DataTable
            TEXTO = ""
            TEXTO = "SELECT STATUS FROM dbo.ORDER_PRODUCTION WHERE ID='" & _NroOf & "'"
            dtResultado = OrdenProduccionBl.Mostrar_Consulta(TEXTO)
            If dtResultado.Rows.Count() <> 0 Then
                If dtResultado.Rows(0).Item("STATUS") = "02" Then
                    btn_GenerarOf.Enabled = False
                    btn_liquidacion_manual.Enabled = False
                ElseIf dtResultado.Rows(0).Item("STATUS") = "01" Then
                    btn_GenerarOf.Enabled = False
                    btn_liquidacion_manual.Enabled = False
                ElseIf dtResultado.Rows(0).Item("STATUS") = "03" Then 'anulados
                    btn_GenerarOf.Enabled = False
                    btn_liquidacion_manual.Enabled = False
                ElseIf dtResultado.Rows(0).Item("STATUS") = "04" Then 'terminadas
                    btn_GenerarOf.Enabled = True
                    btn_liquidacion_manual.Enabled = True
                ElseIf dtResultado.Rows(0).Item("STATUS") = "05" Then 'liquidado por sistema
                    btn_GenerarOf.Enabled = False
                    btn_liquidacion_manual.Enabled = False
                Else 'liquidado manualmente
                    btn_GenerarOf.Enabled = False
                    btn_liquidacion_manual.Enabled = False
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub imprimirAlmacen(ByVal _Codigo As String, ByVal _Almacen As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("OrdenProduccion")
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteOrdenProduccion(_Codigo, _Almacen)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Orden_Fabricacion.rpt", "", "", "", "@OF;" & _Codigo, "@ALMACEN;" & _Almacen)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Liquidacion_Manual(ByVal _Codigo As String, ByVal _Almacen As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("OrdenProduccion")
            Me.Cursor = Cursors.WaitCursor
            
            If MessageBox.Show("Se va a Liquidar Manualmente la O.F. N° " & _Codigo & vbCrLf & "¿Desea continuar?", "Liquidación Manual", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If OrdenProduccionBl.Liquidacion_Manual_OF(_Codigo, _Almacen) Then
                    MsgBox("Documento Liquidado Manualmente Correctamente.", MsgBoxStyle.Information)
                    Documentos_Orden_Fabricacion()
                Else
                    MsgBox("Error al generar proceso. Verifique!", MsgBoxStyle.Critical)
                    Documentos_Orden_Fabricacion()
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMostrar.SelectedIndexChanged
        Documentos_Orden_Fabricacion()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If gbcabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            gbcabecera.Enabled = False
        End If
        'Modo_Edicion = False
        AgregandoArticulos()
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_Click(sender, e)
        End If
    End Sub
    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalles.DataSource = Nothing
            dgvDetalles.DataSource = dtdetalleArticuloPrincipal

            dgvDetalles.Columns(0).HeaderText = "Item"
            dgvDetalles.Columns(1).HeaderText = "Codigo"
            dgvDetalles.Columns(2).HeaderText = "Producto"
            dgvDetalles.Columns(3).HeaderText = "Unidad"
            dgvDetalles.Columns(4).HeaderText = "Codigo Pres."
            dgvDetalles.Columns(5).HeaderText = "Presentación"
            dgvDetalles.Columns(6).Visible = False
            dgvDetalles.Columns(7).HeaderText = "Cantidad"
            dgvDetalles.Columns(8).HeaderText = "Costo Prom. Insumos"
            dgvDetalles.Columns(9).HeaderText = "Costo Ult. Insumos"
            dgvDetalles.Columns(10).HeaderText = "Costo Prom. Pres."
            dgvDetalles.Columns(11).HeaderText = "Costo Ult. Pres."

            dgvDetalles.Columns(13).HeaderText = "Costo Promedio P.T."
            dgvDetalles.Columns(14).HeaderText = "Costo Ultimo P.T"

            dgvDetalles.Columns(15).HeaderText = "Cod. Alm. Ingreso"
            dgvDetalles.Columns(16).HeaderText = "Des. Alm. Ingreso"
            dgvDetalles.Columns(18).HeaderText = "Tipo Liquidación"

            dgvDetalles.Columns(7).DefaultCellStyle.Format = "N6"
            dgvDetalles.Columns(8).DefaultCellStyle.Format = "N6"
            dgvDetalles.Columns(9).DefaultCellStyle.Format = "N6"
            dgvDetalles.Columns(10).DefaultCellStyle.Format = "N6"
            dgvDetalles.Columns(11).DefaultCellStyle.Format = "N6"
            dgvDetalles.Columns(12).Visible = False
            dgvDetalles.Columns(13).DefaultCellStyle.Format = "N6"
            dgvDetalles.Columns(14).DefaultCellStyle.Format = "N6"
            dgvDetalles.Columns(17).Visible = False
            dgvDetalles.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Sumar_Cantidad()
            'lblsaldo.Text = Format(_cantidad_terminada - CType(dtdetalleArticuloPrincipal.Compute("sum(QTY)", "TIPO_LIQUIDACION='L'"), Decimal) + CType(dtdetalleArticuloPrincipal.Compute("sum(QTY)", "TIPO_LIQUIDACION='A'"), Decimal), "##,##00")
        Else
            lblsaldo.Text = dgvCabecera.CurrentRow.Cells("Cantidad Terminada").Value
            lblsaldo.Text = Format(Double.Parse(lblsaldo.Text), "##,##0.00")
        End If
    End Sub

    Private Sub Sumar_Cantidad()
        Dim s As Double = 0
        Dim d As Double = 0

        For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count - 1
            If dtdetalleArticuloPrincipal.Rows(i).Item("TIPO_LIQUIDACION").ToString = "L" Then
                s += dtdetalleArticuloPrincipal.Rows(i).Item("QTY").ToString
            ElseIf dtdetalleArticuloPrincipal.Rows(i).Item("TIPO_LIQUIDACION").ToString = "A" Then
                d += dtdetalleArticuloPrincipal.Rows(i).Item("QTY_REAL").ToString
            End If
        Next
        _cantidad_terminada = CDbl(dgvCabecera.CurrentRow.Cells("Cantidad Terminada").Value)
        lblsaldo.Text = (_cantidad_terminada + d) - s

        lblsaldo.Text = Format(Double.Parse(lblsaldo.Text), "##,##0.00")
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If cmbmoneda.Text = String.Empty Then
                MsgBox("No se cargo datos del Tipo de Moneda.", MsgBoxStyle.Critical)
                estado = False
                cboMoneda.Focus()
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticuloLiquidacion
            frmArticulo._ID_FORMULA = dgvCabecera.CurrentRow.Cells("PART_FORM").Value
            frmArticulo._ID_OF = txtcodigo.Text
            frmArticulo._CANTIDAD_OF = dgvCabecera.CurrentRow.Cells("Cantidad a Fabricar").Value
            frmArticulo._CANTIDAD_TERMINADA = dgvCabecera.CurrentRow.Cells("Cantidad Terminada").Value
            frmArticulo._MONEDA = cmbmoneda.SelectedValue.ToString
            frmArticulo._CANTIDAD_SALDO = CDbl(lblsaldo.Text)
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                row("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                row("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                row("PART_ID_PRES") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID_PRES")
                row("DESCRIPTION_PRES") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION_PRES")
                row("UNIT_PRES") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT_PRES")
                row("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                row("AVERAGE_COST_PROM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST_PROM")
                row("AVERAGE_COST_ULT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST_ULT")
                row("AVERAGE_COST_PRES_PROM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST_PRES_PROM")
                row("AVERAGE_COST_PRES_ULT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST_PRES_ULT")
                row("WHO_PRES") = frmArticulo.dtdetalleArticulo.Rows(0).Item("WHO_PRES")
                row("AVERAGE_COST_TOTAL_PROM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST_TOTAL_PROM")
                row("AVERAGE_COST_TOTAL_ULT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST_TOTAL_ULT")
                row("WHO_INGRESO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("WHO_INGRESO")
                row("WHO_DES_INGRESO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("WHO_DES_INGRESO")
                row("QTY_REAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY_REAL")
                row("TIPO_LIQUIDACION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TIPO_LIQUIDACION")
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                Fl_close = False
            Else
                Fl_close = True
            End If
            ConfigurarGrila()
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
        ConfigurarGrila()
    End Sub
    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalles.Item(0, dgvDetalles.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
                ' Calcular_Totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal.Rows
            i += 1
            dtdetalleArticuloPrincipal.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal.EndInit()
            dtdetalleArticuloPrincipal.AcceptChanges()
        Next
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If dgvDetalles.Rows.Count() = 0 Then Exit Sub
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If Format(CType(lblsaldo.Text, Decimal), "##,##00") > 0 Then
            MsgBox("La Liquidación tiene un saldo pendiente.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Guardar_Formulacion() Then
            btn_cancelar_Click(sender, e)
        End If

    End Sub
    Private Function Guardar_Formulacion() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            ManufactutraBl = New ClsOperaciones.FORMULATION
            ManufactutraCabENT = New ClsEntidades.LIQUIDACION_OP
            ListaDetalles = New List(Of ClsEntidades.LIQUIDACION_OP_LINE)

            ManufactutraCabENT.ID = txtcodigo.Text
            ManufactutraCabENT.FECHA = dtpFecha.Value
            ManufactutraCabENT.USER_ID = LibComunVar.ClsVarComun.USUARIO


            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                ManufactutraDetENT = New ClsEntidades.LIQUIDACION_OP_LINE
                ManufactutraDetENT.ID = ManufactutraCabENT.ID
                ManufactutraDetENT.PART_ID = item("PART_ID").ToString
                ManufactutraDetENT.DESCRIPTION = item("DESCRIPTION").ToString
                ManufactutraDetENT.UNIT = item("UNIT").ToString
                ManufactutraDetENT.PART_ID_PRES = item("PART_ID_PRES").ToString
                ManufactutraDetENT.DESCRIPTION_PRES = item("DESCRIPTION_PRES").ToString
                ManufactutraDetENT.UNIT_PRES = item("UNIT_PRES").ToString
                ManufactutraDetENT.QTY = item("QTY_REAL").ToString
                ManufactutraDetENT.AVERAGE_COST_PROM = item("AVERAGE_COST_PROM").ToString
                ManufactutraDetENT.AVERAGE_COST_ULT = item("AVERAGE_COST_ULT").ToString
                ManufactutraDetENT.AVERAGE_COST_PRES_PROM = item("AVERAGE_COST_PRES_PROM").ToString
                ManufactutraDetENT.AVERAGE_COST_PRES_ULT = item("AVERAGE_COST_PRES_ULT").ToString
                ManufactutraDetENT.WHO_PRES = item("WHO_PRES").ToString
                ManufactutraDetENT.AVERAGE_COST_TOTAL_PROM = item("AVERAGE_COST_TOTAL_PROM").ToString
                ManufactutraDetENT.AVERAGE_COST_TOTAL_ULT = item("AVERAGE_COST_TOTAL_ULT").ToString
                ManufactutraDetENT.WHO_INGRESO = item("WHO_INGRESO").ToString
                ManufactutraDetENT.WHO_DES_INGRESO = item("WHO_DES_INGRESO").ToString
                ManufactutraDetENT.MONEDA = cmbmoneda.SelectedValue.ToString
                ManufactutraDetENT.TIPO_LIQUIDACION = item("TIPO_LIQUIDACION").ToString
                ListaDetalles.Add(ManufactutraDetENT)
            Next
            If ManufactutraBl.GuardarLiquidacionProduccion(ManufactutraCabENT, ListaDetalles, LibComunVar.ClsVarComun.TCVenta) Then
                MsgBox("Liquidación O.F. " & ManufactutraCabENT.ID & ", grabado correctamente.", MsgBoxStyle.Information, "Sistemas")
                Documentos_Orden_Fabricacion()
            End If
            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btn_liquidacion_manual_Click(sender As Object, e As EventArgs) Handles btn_liquidacion_manual.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        _id = String.Empty
        _Who = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Who = dgvCabecera.Item(16, dgvCabecera.CurrentRow.Index).Value
        Liquidacion_Manual(_id, _Who)
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
        Documentos_Orden_Fabricacion()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            Documentos_Orden_Fabricacion()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Documentos_Orden_Fabricacion()
        End If
    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("Estado").Value = "ANULADAS" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub
End Class