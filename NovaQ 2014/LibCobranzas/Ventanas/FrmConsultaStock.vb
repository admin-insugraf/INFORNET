Imports LibComunVar
Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmConsultaStock
    Dim clsBusquedaBl As ClsBuscar
    Dim ArticuloBl As ClsNegocio.PART
    Dim dtAlmacen As DataTable
    Dim dtdetalles As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Dim dtReporte As DataTable



    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_RetornarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(SELECCIONE UN ALMACEN)"
            dtAlmacen.Rows.InsertAt(row, 0)
            If dtAlmacen.Rows.Count() <> 0 Then
                cboAlmacen.DisplayMember = "DESCRIPCION"
                cboAlmacen.ValueMember = "CODIGO"
                cboAlmacen.DataSource = dtAlmacen
            End If

            Dim dtTipoOrigen As DataTable
            dtTipoOrigen = New DataTable
            dtTipoOrigen = clsBusquedaBl.Get_Retornar_Tipo_Origen()
            'agregando una nueva Fila (Seleccione) --
            Dim row2 As DataRow = dtTipoOrigen.NewRow()
            row2.Item("CODIGO") = ""
            row2.Item("DESCRIPCION") = "TODOS"
            dtTipoOrigen.Rows.InsertAt(row2, 0)
            If dtTipoOrigen.Rows.Count() <> 0 Then
                cbo_tipo_origen.DisplayMember = "DESCRIPCION"
                cbo_tipo_origen.ValueMember = "CODIGO"
                cbo_tipo_origen.DataSource = dtTipoOrigen

            End If

            clsBusquedaBl = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Datos()
        Try
            ArticuloBl = New ClsNegocio.PART
            dtdetalles = New DataTable("Articulos")
            dtv = New DataView
            Dim ListaAlmacen As List(Of String)
            ' Seleccion de Almacen
            If chkTodosAlmacenes.Checked = True Then
                ListaAlmacen = New List(Of String)
            Else
                'Seleccionando almacen
                If cboAlmacen.SelectedIndex = 0 Then
                    MsgBox("Debe seleccionar un Almacen.", MsgBoxStyle.Information)
                    cboAlmacen.Focus()
                    Exit Sub
                End If
                ListaAlmacen = New List(Of String)
                ListaAlmacen.Add(cboAlmacen.SelectedValue.ToString)
            End If
            Me.Cursor = Cursors.WaitCursor
            dtdetalles = ArticuloBl.RetornarStockProductos(ListaAlmacen, IIf(chkTodosAlmacenes.Checked, 1, 0), IIf(chk_stock_cero.Checked, True, False), cbo_tipo_origen.SelectedValue)
            If dtdetalles.Rows.Count() <> 0 Then
                dtv = dtdetalles.DefaultView
                dgvConsulta.DataSource = dtv
                dgvConsulta.Columns(0).Width = 80
                dgvConsulta.Columns(0).HeaderText = "Codigo"
                dgvConsulta.Columns(1).Width = 400
                dgvConsulta.Columns(1).HeaderText = "Descripción "
                dgvConsulta.Columns(2).Width = 200
                dgvConsulta.Columns(2).HeaderText = "Presentación "
                dgvConsulta.Columns(3).Width = 60
                dgvConsulta.Columns(3).HeaderText = "Unidad "
                'dgvConsulta.Columns(4).Width = 80
                dgvConsulta.Columns(4).HeaderText = "Laboratorio "
                dgvConsulta.Columns(5).Width = 80
                dgvConsulta.Columns(5).HeaderText = "Stock "
                dgvConsulta.Columns(12).HeaderText = "Tipo Origen"
                dgvConsulta.Columns("FAMILIA").HeaderText = "Familia"
                dgvConsulta.Columns("FAMILIA").DisplayIndex = 1
                dgvConsulta.Columns("FAMILIA").Width = 250
                dgvConsulta.Columns(12).Width = 120
                'dgvConsulta.AutoResizeColumns()
                'dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvConsulta.Columns(2).Visible = False
                dgvConsulta.Columns(4).Visible = False
                dgvConsulta.Columns(6).Visible = False
                dgvConsulta.Columns(7).Visible = False
                dgvConsulta.Columns(8).Visible = False
                dgvConsulta.Columns(9).Visible = False
                dgvConsulta.Columns(10).Visible = False
                dgvConsulta.Columns(11).Visible = False

                If LibComunVar.ClsVarComun.RucEmpresa <> "20556850454" Then
                    dgvConsulta.Columns("CONVERSION_KG").Visible = False
                Else
                    dgvConsulta.Columns("CONVERSION_KG").Visible = True
                    dgvConsulta.Columns("CONVERSION_KG").HeaderText = "Conversión en Kg"
                    dgvConsulta.Columns("CONVERSION_KG").DefaultCellStyle.Format = "N6"
                    dgvConsulta.Columns("CONVERSION_KG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvConsulta.Columns("CONVERSION_KG").Width = 100
                End If


                dgvConsulta.Columns("STOCK_MINIMO").HeaderText = "Stock Minimo"
                dgvConsulta.Columns("STOCK_PUNTO_PEDIDO").HeaderText = "Punto de Pedido"
                dgvConsulta.Columns("STOCK_MINIMO").Width = 100
                dgvConsulta.Columns("STOCK_PUNTO_PEDIDO").Width = 100
                dgvConsulta.Columns("STOCK_MINIMO").DefaultCellStyle.Format = "N2"
                dgvConsulta.Columns("STOCK_MINIMO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvConsulta.Columns("STOCK_PUNTO_PEDIDO").DefaultCellStyle.Format = "N2"
                dgvConsulta.Columns("STOCK_PUNTO_PEDIDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvConsulta.Columns(5).DefaultCellStyle.Format = "N6"
                dgvConsulta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                STRorden = dgvConsulta.Columns(0).Name & "+" & dgvConsulta.Columns(1).Name ' & "+" & dgvConsulta.Columns(2).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                ArticuloBl = Nothing
            Else
                dgvConsulta.DataSource = Nothing
                lblCantidad.Text = "Se encontraron 0 registros"
                MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
            'lblmensaje.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub FrmConsultaStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MostrandoAlmacenes()
        ArticuloBl = New ClsNegocio.PART
        dtdetalles = New DataTable("Usuario")
        dtdetalles = ArticuloBl.DatosUsuarios(LibComunVar.ClsVarComun.USUARIO)
        If dtdetalles.Rows.Count() <> 0 Then
            If dtdetalles.Rows(0).Item("NIVEL_ACCESO").ToString = "01" Then
                'gbTodosAlmacenes.Enabled = True
            Else
                'gbTodosAlmacenes.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'If dgvConsulta.DataSource Is Nothing Then Exit Sub
        ''dtv.Sort = STRorden
        'Dim wbusqueda As String = UCase(txtFiltro.Text)
        'Dim myCurrencyManager As CurrencyManager
        'myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        'Dim INTnewpos As Integer
        'dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        'myCurrencyManager.Position = INTnewpos
        'lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        ElseIf STRorden = "" Then

        Else
            STRorden = dgvConsulta.Columns(0).Name
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvConsulta.Columns(0).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvConsulta.Columns(1).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvConsulta.Columns(0).Name & "+" & dgvConsulta.Columns(1).Name ' & "+" & dgvConsulta.Columns(2).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub chkTodosAlmacenes_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodosAlmacenes.CheckedChanged
        If chkTodosAlmacenes.Checked Then
            cboAlmacen.SelectedIndex = 0
            cboAlmacen.Enabled = False
            btnMostrar.Enabled = True
        Else
            cboAlmacen.SelectedIndex = 0
            cboAlmacen.Enabled = True
            btnMostrar.Enabled = False
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If cboAlmacen.DataSource Is Nothing Then Exit Sub
        Cargar_Datos()
    End Sub

    Private Sub cboAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If cboAlmacen.DataSource Is Nothing Then Exit Sub
        If cboAlmacen.SelectedIndex = 0 Then
            dgvConsulta.DataSource = Nothing
            dgvdetalles.DataSource = Nothing
            lblCantidad.Text = "Se encontraron 0 registros"
            Exit Sub
        End If
        Cargar_Datos()
        dgvdetalles.DataSource = Nothing
    End Sub
    Private Sub ConsultaDetalles(ByVal _codigo As String, ByVal _Almacen As String, ByVal Todos As Boolean)
        Try
            ArticuloBl = New ClsNegocio.PART
            dtdetalles = New DataTable("DetallesLote")
            dtdetalles = ArticuloBl.ConsultarArticuloLote(_codigo)
            If dtdetalles.Rows.Count() <> 0 Then
                gbdetalles.Text = "Detalles de Lotes"
                ArticuloBl = New ClsNegocio.PART
                dtdetalles = New DataTable("RegistroLote")
                dtdetalles = ArticuloBl.DetalleArticuloLote(_codigo, _Almacen, Todos)
                If dtdetalles.Rows.Count() <> 0 Then
                    dgvdetalles.DataSource = dtdetalles
                    dgvdetalles.Columns(0).Width = 200
                Else
                    dgvdetalles.DataSource = Nothing
                End If
            Else
                ArticuloBl = New ClsNegocio.PART
                dtdetalles = New DataTable("DetallesSerie")
                dtdetalles = ArticuloBl.ConsultarArticuloSerie(_codigo)
                If dtdetalles.Rows.Count() <> 0 Then
                    gbdetalles.Text = "Detalles de Serie"
                Else
                    ArticuloBl = New ClsNegocio.PART
                    dtdetalles = New DataTable("DetallesLibre")
                    dtdetalles = ArticuloBl.ConsultarArticuloLibre(_codigo)
                    If dtdetalles.Rows.Count() <> 0 Then
                        gbdetalles.Text = "Detalles de Stock libre"
                        ArticuloBl = New ClsNegocio.PART
                        dtdetalles = New DataTable("RegistroLibre")
                        dtdetalles = ArticuloBl.DetalleArticuloLibre(_codigo, _Almacen, Todos)
                        dgvdetalles.DataSource = Nothing
                        If dtdetalles.Rows.Count() <> 0 Then
                            dgvdetalles.DataSource = dtdetalles
                            'dgvdetalles.Columns(0).Width = 200
                            dgvdetalles.AutoResizeColumns()
                            dgvdetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            dgvdetalles.Columns(2).DefaultCellStyle.Format = "N2"
                        Else
                            dgvdetalles.DataSource = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvConsulta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvConsulta.MouseDoubleClick
        If dgvConsulta.CurrentRow Is Nothing Then Exit Sub
        Dim codigoPart As String = String.Empty
        Dim Almacen As String = String.Empty
        codigoPart = IIf(String.IsNullOrEmpty(dgvConsulta.Item(0, dgvConsulta.CurrentRow.Index).Value.ToString), "", dgvConsulta.Item(0, dgvConsulta.CurrentRow.Index).Value)
        If chkTodosAlmacenes.Checked = True Then

        Else
            Almacen = cboAlmacen.SelectedValue.ToString
        End If
        If codigoPart = String.Empty Then Exit Sub
        ConsultaDetalles(codigoPart, Almacen, IIf(chkTodosAlmacenes.Checked, 1, 0))
    End Sub

    Private Sub dgvConsulta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellClick
        If dgvConsulta.CurrentRow Is Nothing Then Exit Sub
        Dim codigoPart As String = String.Empty
        Dim Almacen As String = String.Empty
        codigoPart = IIf(String.IsNullOrEmpty(dgvConsulta.Item(0, dgvConsulta.CurrentRow.Index).Value.ToString), "", dgvConsulta.Item(0, dgvConsulta.CurrentRow.Index).Value)
        If chkTodosAlmacenes.Checked = True Then

        Else
            Almacen = cboAlmacen.SelectedValue.ToString
        End If
        If codigoPart = String.Empty Then Exit Sub
        ConsultaDetalles(codigoPart, Almacen, IIf(chkTodosAlmacenes.Checked, 1, 0))
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub btn_ImprimirPlanilla_Click(sender As Object, e As EventArgs) Handles btn_ImprimirPlanilla.Click
        Try
            If cboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe elegir un almacen correcto.", MsgBoxStyle.Information)
                Exit Sub
            End If
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.Obtener_Rpt_Consulta_Stock(cboAlmacen.SelectedValue.ToString, IIf(chk_stock_cero.Checked, "1", "0"))

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Consulta_Stock.rpt", dtImprimir, "", "", _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chk_stock_cero_CheckedChanged(sender As Object, e As EventArgs) Handles chk_stock_cero.CheckedChanged
        cboAlmacen_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cbo_tipo_origen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_origen.SelectedIndexChanged
        If cboAlmacen.DataSource Is Nothing Then Exit Sub
        If cboAlmacen.SelectedIndex = 0 Then
            dgvConsulta.DataSource = Nothing
            dgvdetalles.DataSource = Nothing
            lblCantidad.Text = "Se encontraron 0 registros"
            Exit Sub
        End If
        Cargar_Datos()
        dgvdetalles.DataSource = Nothing
    End Sub

    Private Sub dgvConsulta_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvConsulta.CellFormatting
        If dgvConsulta.Rows(e.RowIndex).Cells("STOCK").Value <= dgvConsulta.Rows(e.RowIndex).Cells("STOCK_MINIMO").Value Then
            dgvConsulta.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvConsulta.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        ElseIf (dgvConsulta.Rows(e.RowIndex).Cells("STOCK").Value > dgvConsulta.Rows(e.RowIndex).Cells("STOCK_MINIMO").Value) And dgvConsulta.Rows(e.RowIndex).Cells("STOCK").Value <= dgvConsulta.Rows(e.RowIndex).Cells("STOCK_PUNTO_PEDIDO").Value Then
            dgvConsulta.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
            dgvConsulta.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        Else
            dgvConsulta.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvConsulta.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub btn_reporte_vida_util_Click(sender As Object, e As EventArgs) Handles btn_reporte_vida_util.Click
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim lista As New List(Of String)
            Dim idAlmacen As String = String.Empty
            dtDatosCompany = New DataTable

            Me.Cursor = Cursors.WaitCursor

            idAlmacen = cboAlmacen.SelectedValue.ToString

            dtReporte = New DataTable("ProductoVencer")
            dtReporte = reporteBL.Get_Imprimir_Producto_Vencer(idAlmacen, "", "", "", "", "")
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtReporte.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("PRO_VEN_VIDA_UTIL.rpt", dtReporte, "", "", "", "@ALMACEN;" & idAlmacen, "@PROD_INI;" & "", "@PROD_FIN;" & "", "@FECHA_LIMITE;" & "" _
                                          , "@FAMILIA;" & "", "@LINEA;" & "", _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_stock_logistico_Click(sender As Object, e As EventArgs) Handles btn_stock_logistico.Click
        Try
            If cboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe elegir un almacen correcto.", MsgBoxStyle.Information)
                Exit Sub
            End If
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.Obtener_Rpt_Consulta_Stock_Logistico(cboAlmacen.SelectedValue.ToString)

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Consulta_Stock_Logistico.rpt", dtImprimir, "", "", _
                                          "@CODIGO_ALMACEN;" & cboAlmacen.SelectedValue.ToString, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class