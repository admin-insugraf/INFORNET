Imports LibCobranzas
Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing
Imports DllInventario
Public Class Frm_Liquidar_OP
    Private edicion As Boolean
    Private _tipoMov As String
    Private _ModoEdicion As Boolean = False
    Private _idAlmacen As String
    Private _documentId As String
    Private _NumeroDocumento As String


    Dim dtCabeceraAlm As DataTable
    Dim dtDetalleAlm As DataTable
    Dim clsAlmacenCabBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenDetBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
    Dim MostrarMovimientoBl As ClsTransacciones.clsMostrarTiposMovimiento
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim dtTransaccionTipo As DataTable

    Dim clsAlmacenCorrelativoBl As LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo
    Dim clsAlmacenCorrelativoBl_Ingreso As LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo

    Dim dtv As DataView
    Dim STRorden As String
    Dim dtData As DataTable
    Dim Modo_consultar As Boolean = False

    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleBultosPrincipal As DataTable

    Dim almacenBL As ClsOperaciones.WAREHOUSE
    Dim dtAlmacen As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim Fl_close As Boolean = False

    Dim clsBusquedaBl As ClsBuscar
    Dim TipoArticulo As String = String.Empty
    Dim PerteneceGuiaAnalisis As Boolean = False

    Dim _DIRECCION As String = String.Empty
    Dim _RUC As String = String.Empty
    Dim _STATUS_GUIA As String = String.Empty
    Dim _ACCOUNT As String = String.Empty

    Dim Ref_idalamacen As String = String.Empty
    Dim Ref_documentid As String = String.Empty
    Dim Ref_numerodocument As String = String.Empty
    Dim Ref_trasactiontype As String = String.Empty
    Dim Ref_tipo As String = String.Empty

    Dim _STOCK As Double
    Dim _COSTO As Double

    Dim clsBusquedaBl_val As ClsBuscar
    Dim dtUltimoMes As DataTable
    'Dim dtAlmacen As DataTable
    Dim dtTipoCambio As DataTable
    Dim dtDocumentosSinVal As DataTable
    Dim dtSaldoNegativo As DataTable
    Dim dtStockArticulo As DataTable
    Dim dtRevalorizaLotes As DataTable
    Dim dtDatosCompany As DataTable

    Dim _Fecha_Inicio As Date
    Dim _Fecha_Fin As Date
    Dim _item_producto As Integer

    Private Sub Frm_Liquidar_OP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MostrandoAlmacenes()
        Botonera_Estado_Cambiar(False)
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_RetornarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            If dtAlmacen.Rows.Count() <> 0 Then
                cboAlmacen.DisplayMember = "DESCRIPCION"
                cboAlmacen.ValueMember = "CODIGO"
                cboAlmacen.DataSource = dtAlmacen
            End If

            clsBusquedaBl = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden <> "" Then
            Dim wbusqueda As String = UCase(txtFiltro.Text)
            Dim myCurrencyManager As CurrencyManager
            myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
            Dim INTnewpos As Integer
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            myCurrencyManager.Position = INTnewpos
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub


    Private Sub MostrandoDatosGeneralesCabeceraAlmacen()
        Try
            Me.Cursor = Cursors.WaitCursor
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    dtpfechaInicial.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable
            STRorden = ""
            dtData = clsBusquedaBl.get_DatosGenerales_Produccion_Op_Liquidacion(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                 cboopcionesBusqueda.SelectedIndex)
            dgvCabeceraAlmacen.DataSource = Nothing
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                dgvCabeceraAlmacen.DataSource = dtv

                dgvCabeceraAlmacen.Columns("NUMERO_DOC").HeaderText = "N° Doc."
                dgvCabeceraAlmacen.Columns("FECHA_DOC").HeaderText = "Fecha Doc."
                dgvCabeceraAlmacen.Columns("COD_PRODUCTO").HeaderText = "Cod. Producto"
                dgvCabeceraAlmacen.Columns("PRODUCTO").HeaderText = "Producto"
                dgvCabeceraAlmacen.Columns("UNIDAD").HeaderText = "Unidad"
                dgvCabeceraAlmacen.Columns("CANTIDAD").HeaderText = "Cantidad"
                dgvCabeceraAlmacen.Columns("Estado").HeaderText = "Estado"
                dgvCabeceraAlmacen.Columns("FECHA_ENTREGA").HeaderText = "Fecha de Entrega"
                dgvCabeceraAlmacen.Columns("ITEM").Visible = False

                dgvCabeceraAlmacen.Columns("NUMERO_DOC").Width = 50
                dgvCabeceraAlmacen.Columns("FECHA_DOC").Width = 70
                dgvCabeceraAlmacen.Columns("COD_PRODUCTO").Width = 100
                dgvCabeceraAlmacen.Columns("PRODUCTO").Width = 300
                dgvCabeceraAlmacen.Columns("UNIDAD").Width = 50
                dgvCabeceraAlmacen.Columns("CANTIDAD").Width = 100
                dgvCabeceraAlmacen.Columns("Estado").Width = 150
                dgvCabeceraAlmacen.Columns("FECHA_ENTREGA").Width = 70

                dgvCabeceraAlmacen.Columns("CANTIDAD").DefaultCellStyle.Format = "N4"
                dgvCabeceraAlmacen.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                STRorden = dgvCabeceraAlmacen.Columns("NUMERO_DOC").Name & "+" & dgvCabeceraAlmacen.Columns("COD_PRODUCTO").Name & "+" & dgvCabeceraAlmacen.Columns("PRODUCTO").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                clsBusquedaBl = Nothing
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Visible = False
            Case 1
                gbRangofechas.Visible = False
            Case 2
                gbRangofechas.Visible = True
        End Select
        txtFiltro.Text = String.Empty
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub
    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            MostrandoDatosGeneralesCabeceraAlmacen()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            MostrandoDatosGeneralesCabeceraAlmacen()
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            If Modo_consultar = True Then
                btnGrabar.Enabled = False
            Else
                btnGrabar.Enabled = True
            End If

            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            lblCantidad.Visible = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            lblCantidad.Visible = True
        End If
    End Sub

    Private Sub dtpFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub


    Private Sub cboAlmacenBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs)
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlprincipal.Visible = True
        Modo_consultar = False
        Botonera_Estado_Cambiar(False)
    End Sub


    Private Sub btnConsultar_Click_1(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True

        If MostrarModoEdicion(CInt(dgvCabeceraAlmacen.CurrentRow.Cells("NUMERO_DOC").Value), CInt(dgvCabeceraAlmacen.CurrentRow.Cells("ITEM").Value)) Then
            _item_producto = CInt(dgvCabeceraAlmacen.CurrentRow.Cells("ITEM").Value)
            pnlprincipal.Visible = False
            gb_producto_producir.Enabled = False
            Call Botonera_Estado_Cambiar(True)
        End If

    End Sub

    Private Function MostrarModoEdicion(ByVal _codigo As Integer, ByVal _item As Integer) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtCabeceraAlm = New DataTable
            dtDetalleAlm = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraAlm = clsAlmacenCabBl.get_Cabecera_Produccion_OP_Liquidacion(_codigo, _item)
            If dtCabeceraAlm.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()

                GbTransaccion.Enabled = False
                For i As Integer = 0 To dtCabeceraAlm.Rows.Count() - 1
                    txt_numero.Text = dtCabeceraAlm.Rows(i).Item("NUMERO").ToString
                    dtpFecha.Value = dtCabeceraAlm.Rows(i).Item("FECHA").ToString
                    txt_cod_producto_producir.Text = dtCabeceraAlm.Rows(i).Item("COD_PRODUCTO").ToString
                    txt_des_prod_producir.Text = dtCabeceraAlm.Rows(i).Item("PRODUCTO").ToString
                    txt_unidad_prod_producir.Text = dtCabeceraAlm.Rows(i).Item("UNIDAD").ToString
                    txt_cantidad_op.Text = dtCabeceraAlm.Rows(i).Item("CANTIDAD").ToString
                    txt_cantidad_op.Text = Format(Double.Parse(txt_cantidad_op.Text), "##,##0.00")
                    txt_costo_total.Text = dtCabeceraAlm.Rows(i).Item("TOTAL").ToString
                    txt_costo_total.Text = Format(Double.Parse(txt_costo_total.Text), "##,##0.00")
                Next
                '---Mostrando datos del Detalle
                dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Detalle_Produccion_OP_Liquidacion(_codigo, _item)
                dgvDetalle_insumos.DataSource = Nothing
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle_insumos.DataSource = dtdetalleArticuloPrincipal

                    dgvDetalle_insumos.AutoResizeColumns()
                    dgvDetalle_insumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                    dgvDetalle_insumos.Columns(0).HeaderText = "Item"
                    dgvDetalle_insumos.Columns(1).HeaderText = "Tipo"
                    dgvDetalle_insumos.Columns(2).HeaderText = "Costo"
                    dgvDetalle_insumos.Columns(3).HeaderText = "Cantidad"
                    dgvDetalle_insumos.Columns(4).HeaderText = "T.D. Ref."
                    dgvDetalle_insumos.Columns(5).HeaderText = "N° Ref."
                    dgvDetalle_insumos.Columns(6).HeaderText = "Fecha"
                    dgvDetalle_insumos.Columns(7).Visible = False
                    dgvDetalle_insumos.Columns(8).Visible = False
                    dgvDetalle_insumos.Columns(9).HeaderText = "Almacen"
                    dgvDetalle_insumos.Columns(10).Visible = False

                    dgvDetalle_insumos.Columns(2).DefaultCellStyle.Format = "N6"
                    dgvDetalle_insumos.Columns(3).DefaultCellStyle.Format = "N0"

                    dgvDetalle_insumos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle_insumos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    txt_cantidad_liq_total.Text = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero)
                    txt_cantidad_liq_total.Text = Format(Double.Parse(txt_cantidad_liq_total.Text), "##,##0.00")

                    txt_costo_unitario.Text = CDbl(txt_costo_total.Text) / CDbl(txt_cantidad_liq_total.Text)
                    txt_costo_unitario.Text = Format(Double.Parse(txt_costo_unitario.Text), "##,##0.0000")
                Else
                    txt_cantidad_liq_total.Text = Format(Double.Parse(0), "##,##0.00")
                    txt_costo_unitario.Text = Format(Double.Parse(0), "##,##0.000000")
                End If

            End If
            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
            Return False
        End Try
    End Function

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub

        If dgvCabeceraAlmacen.CurrentRow.Cells("ESTADO").Value = "LIQUIDACION TOTAL" Then
            MsgBox("La O.P. esta liquidado totalmente. Verifique!!!", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        Modo_consultar = False

        If MostrarModoEdicion(CInt(dgvCabeceraAlmacen.CurrentRow.Cells("NUMERO_DOC").Value), CInt(dgvCabeceraAlmacen.CurrentRow.Cells("ITEM").Value)) Then
            _item_producto = CInt(dgvCabeceraAlmacen.CurrentRow.Cells("ITEM").Value)
            pnlprincipal.Visible = False
            gb_producto_producir.Enabled = True
            Call Botonera_Estado_Cambiar(True)
            Call Limpiar_liquidacion()
        End If
    End Sub
    Private Sub Limpiar_liquidacion()
        txt_cantidad_prod_producir.Text = "0"
        dtp_fecha_liquidacion.Value = LibComunVar.ClsVarComun.FechaSistema
        rdb_total.Checked = True
        cboAlmacen.Text = "ALMACEN HUARAL"
        txt_cantidad_prod_producir.Focus()
    End Sub


    Private Sub dtpfechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaInicial.ValueChanged
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub dtpfechafinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechafinal.ValueChanged
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub dgvCabeceraAlmacen_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabeceraAlmacen.CellFormatting

        If dgvCabeceraAlmacen.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16")) '0
            dtdetalleArticuloPrincipal.Columns.Add("TIPO", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal.Columns.Add("COSTO", Type.GetType("System.Double")) '2
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double")) '3
            dtdetalleArticuloPrincipal.Columns.Add("DOCUMENT_REF", Type.GetType("System.String")) '4
            dtdetalleArticuloPrincipal.Columns.Add("NUMBER_DOCUMENT_REF", Type.GetType("System.String")) '5
            dtdetalleArticuloPrincipal.Columns.Add("FECHA_REF", Type.GetType("System.String")) '6
            dtdetalleArticuloPrincipal.Columns.Add("ESTADO", Type.GetType("System.String")) '7
            dtdetalleArticuloPrincipal.Columns.Add("COD_ALMACEN", Type.GetType("System.String")) '8
            dtdetalleArticuloPrincipal.Columns.Add("ALMACEN", Type.GetType("System.String")) '9
            dtdetalleArticuloPrincipal.Columns.Add("ITEM_PRODUCTO", Type.GetType("System.Int16")) '10

            dgvDetalle_insumos.DataSource = Nothing
            dgvDetalle_insumos.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle_insumos.AutoResizeColumns()
            dgvDetalle_insumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvDetalle_insumos.Columns(0).HeaderText = "Item"
            dgvDetalle_insumos.Columns(1).HeaderText = "Tipo"
            dgvDetalle_insumos.Columns(2).HeaderText = "Costo"
            dgvDetalle_insumos.Columns(3).HeaderText = "Cantidad"
            dgvDetalle_insumos.Columns(4).HeaderText = "T.D. Ref."
            dgvDetalle_insumos.Columns(5).HeaderText = "N° Ref."
            dgvDetalle_insumos.Columns(6).HeaderText = "Fecha"
            dgvDetalle_insumos.Columns(7).Visible = False
            dgvDetalle_insumos.Columns(8).Visible = False
            dgvDetalle_insumos.Columns(9).HeaderText = "Almacen"
            dgvDetalle_insumos.Columns(10).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cantidad_prod_producir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_prod_producir.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_prod_producir_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad_prod_producir.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_generar_liquidacion.Focus()
        End If
    End Sub



    Private Function Generar_Descarga_Insumos() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            'PARTE DE LA PRODUCCION DE ALIMENTOS
            Dim ls_det_alm As New List(Of ClsEntidades.PRODUCCION_OP_LINE)
            Dim alm_cabBE As New ClsEntidades.PRODUCCION_OP
            'Dim alm_detBE As ClsEntidades.PRODUCCION_OP_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

            With alm_cabBE
                .ID = txt_numero.Text
            End With

            'PARTE DE LA PRODUCCION DE OP
            '--PARTE DE ALMACEN
            Dim ls_det_alm_almacen As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE_almacen As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE_almacen As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL_almacen As New ClsOperaciones.WAREHOUSE_TRANS

            clsAlmacenCorrelativoBl = New LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen("01", "S")
            'la parte de almacen
            With alm_cabBE_almacen
                .WAREHOUSE_ID = "01"
                Ref_idalamacen = .WAREHOUSE_ID
                .DOCUMENT_ID = "NS"
                Ref_documentid = .DOCUMENT_ID
                .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                Ref_numerodocument = .NUMBER_DOCUMENT
                .DATE_DOCUMENT = CDate(dtpFecha.Value).ToShortDateString
                .TYPE_TRANS = "S"
                Ref_tipo = .TYPE_TRANS
                .TRANS_ID = "SP"
                Ref_trasactiontype = .TRANS_ID
                .DOC_ID_REF = "OP"
                .NUM_ID_REF = txt_numero.Text
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .VAT_REGISTRATION = "" 'Ruc..
                .ADDR_DLV = ""  'Direccion ..
                .VENDOR_ID = ""
                .VENDOR_NAME = ""
                .CUSTOMER_ID = ""
                .CUSTOMER_NAME = ""
                .SALES_TERM = ""
                .CURRENCY_TYPE = "MN"
                .CURRENCY_EXCHANGE = LibComunVar.ClsVarComun.TCVenta
                .STATUS_GUIA = "V"
                .AMOUNT = 0
                .COMMENT = ""
                .TYPE_GUIA = "SP"
                .WAREHOUSE_REF = ""
                .UPDATE_DATE = Date.Now()
                .NUM_ORDER_MANUFACT = ""
                .NUMBER_PURCHASE = ""

            End With
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE_almacen = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE_almacen
                    .WAREHOUSE_ID = "01"
                    .DOCUMENT_ID = "NS"
                    .NUMBER_DOCUMENT = alm_cabBE_almacen.NUMBER_DOCUMENT
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_DLV = .QTY
                    .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .AVERAGE_COST = CDbl(dtdetalleArticuloPrincipal.Rows(i).Item("COSTO").ToString)
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                    .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                    .NUMBER_LOT = ""
                    .WAREHOUSE_REF = ""
                    .ACCOUNT = _ACCOUNT
                    .NUM_PROTOCOLOS = ""
                    .OPT_ENTREGA = ""
                    .QT_BULTOS = 0
                    .PROCEDENCIA = ""
                    .PAIS_ORIGEN = ""
                    .CURRENCY_ID = "MN"
                    .STATUS_VALUE = 0
                    .NUMBER_ANALIS = ""
                End With
                ls_det_alm_almacen.Add(alm_detBE_almacen)
            Next
            '--PARTE DE ALMACEN

            If almacenBL.Guardar_Descarga_OP(alm_cabBE, alm_cabBE_almacen, ls_det_alm_almacen) Then
                Dim msj As String = String.Empty
                msj = String.Empty
                msj = "Orde de Producción aprobado correctamente." '& vbCrLf & " Nro Documento: " & "NS" & " - " & alm_cabBE_almacen.NUMBER_DOCUMENT
                MsgBox(msj, MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btn_generar_liquidacion_Click(sender As Object, e As EventArgs) Handles btn_generar_liquidacion.Click
        Try
            If Validacion_Ingreso_Liquidacion() = False Then Exit Sub
            Dim _ultimo_item As Integer = 0


            If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
                For Each rows As DataRow In dtdetalleArticuloPrincipal.Select("FECHA_REF='" & dtp_fecha_liquidacion.Value.ToString("dd/MM/yyyy") & "' ")
                    MsgBox("Existe una Liquidación para la fecha elegida. Verifique!!!", MsgBoxStyle.Exclamation, "Aviso")
                    Exit Try
                Next
            End If

            For Each items As DataRow In dtdetalleArticuloPrincipal.Select("ITEM<>0", "ITEM DESC")
                _ultimo_item = items("ITEM")
                Exit For
            Next

            Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
            row("ITEM") = _ultimo_item + 1
            row("TIPO") = IIf(rdb_parcial.Checked, rdb_parcial.Text, rdb_total.Text)
            row("COSTO") = 0
            row("CANTIDAD") = txt_cantidad_prod_producir.Text
            row("DOCUMENT_REF") = ""
            row("NUMBER_DOCUMENT_REF") = ""
            row("FECHA_REF") = dtp_fecha_liquidacion.Value.ToString("dd/MM/yyyy")
            row("ESTADO") = "N"
            row("COD_ALMACEN") = cboAlmacen.SelectedValue
            row("ALMACEN") = cboAlmacen.Text
            row("ITEM_PRODUCTO") = _item_producto

            dtdetalleArticuloPrincipal.Rows.Add(row)
            dtdetalleArticuloPrincipal.AcceptChanges()

            Call ConfigurarGrila()
            Call Actualiza_Costo()
            Call Limpiar_liquidacion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalle_insumos.DataSource = dtdetalleArticuloPrincipal

            dgvDetalle_insumos.AutoResizeColumns()
            dgvDetalle_insumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgvDetalle_insumos.Columns(0).HeaderText = "Item"
            dgvDetalle_insumos.Columns(1).HeaderText = "Tipo"
            dgvDetalle_insumos.Columns(2).HeaderText = "Costo"
            dgvDetalle_insumos.Columns(3).HeaderText = "Cantidad"
            dgvDetalle_insumos.Columns(4).HeaderText = "T.D. Ref."
            dgvDetalle_insumos.Columns(5).HeaderText = "N° Ref."
            dgvDetalle_insumos.Columns(6).HeaderText = "Fecha"
            dgvDetalle_insumos.Columns(7).Visible = False
            dgvDetalle_insumos.Columns(8).Visible = False
            dgvDetalle_insumos.Columns(9).HeaderText = "Almacen"
            dgvDetalle_insumos.Columns(10).Visible = False

            dgvDetalle_insumos.Columns(2).DefaultCellStyle.Format = "N6"
            dgvDetalle_insumos.Columns(3).DefaultCellStyle.Format = "N0"

            dgvDetalle_insumos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle_insumos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            txt_cantidad_liq_total.Text = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero)
            txt_cantidad_liq_total.Text = Format(Double.Parse(txt_cantidad_liq_total.Text), "##,##0.00")

            txt_costo_unitario.Text = CDbl(txt_costo_total.Text) / CDbl(txt_cantidad_liq_total.Text)
            txt_costo_unitario.Text = Format(Double.Parse(txt_costo_unitario.Text), "##,##0.000000")
        Else
            txt_cantidad_liq_total.Text = Format(Double.Parse(0), "##,##0.00")
            txt_costo_unitario.Text = Format(Double.Parse(0), "##,##0.000000")
        End If
    End Sub

    Private Sub Actualiza_Costo()
        For Each items As DataRow In dtdetalleArticuloPrincipal.Rows
            dtdetalleArticuloPrincipal.BeginInit()
            items("COSTO") = CDbl(txt_costo_unitario.Text)
            dtdetalleArticuloPrincipal.EndInit()
            dtdetalleArticuloPrincipal.AcceptChanges()
        Next
    End Sub

    Function Validacion_Ingreso_Liquidacion() As Boolean


        If txt_cantidad_prod_producir.Text.Trim = "" Then
            MsgBox("Debe ingresar una cantidad a Liquidar.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cantidad_prod_producir.Focus()
            Return False
            Exit Function
        End If

        If CDbl(txt_cantidad_prod_producir.Text) = 0 Then
            MsgBox("Debe ingresar una cantidad diferente de cero.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cantidad_prod_producir.Focus()
            Return False
            Exit Function
        End If

        For Each items As DataRow In dtdetalleArticuloPrincipal.Select("TIPO='Liquidación Total'")
            MsgBox("No puede ingresar mas liquidaciones a la Orden de Producción. Verifique!!!", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        Next

        If cboAlmacen.SelectedIndex = -1 Then
            MsgBox("Debe elegir un almacen de destino.", MsgBoxStyle.Exclamation, "Sistemas")
            cboAlmacen.Focus()
            Return False
            Exit Function
        End If

        If CDbl(txt_cantidad_prod_producir.Text) + CDbl(txt_cantidad_liq_total.Text) > CDbl(txt_cantidad_op.Text) Then
            MsgBox("La cantidad total a liquidar es mayor a la" & Chr(13) & "cantidad de la Orden de Producción.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cantidad_prod_producir.Focus()
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub btn_del_Click_1(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgvDetalle_insumos.RowCount = 0 Then Exit Sub
        If dgvDetalle_insumos.CurrentRow Is Nothing Then Exit Sub

        If dgvDetalle_insumos.CurrentRow.Cells("Estado").Value = "A" Then
            MsgBox("Liquidación anterior, no puede eliminarse. Verifique!!!", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If

        If MsgBox("Seguro de eliminar el item seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            Eliminando_Liquidacion()
            Call ConfigurarGrila()
            Call Actualiza_Costo()
        End If
    End Sub

    Private Sub Eliminando_Liquidacion()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgvDetalle_insumos.CurrentRow.Cells("ITEM").Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dtdetalleArticuloPrincipal.Rows.Count = 0 Then Exit Sub

        If Generar_Liquidaciones() = True Then
            btnCancelar_Click_1(sender, e)
            MostrandoDatosGeneralesCabeceraAlmacen()
        End If
    End Sub
    Private Function Generar_Liquidaciones() As Boolean
        Try
            'PARTE DE LA PRODUCCION DE ALIMENTOS
            Dim ls_det_alm As New List(Of ClsEntidades.PRODUCCION_OP_LIQUIDACION)
            Dim alm_cabBE As New ClsEntidades.PRODUCCION_OP
            Dim alm_detBE As ClsEntidades.PRODUCCION_OP_LIQUIDACION
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS


            With alm_cabBE
                .ID = txt_numero.Text
            End With

            For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ESTADO='N' ", "ITEM ASC")
                alm_detBE = New ClsEntidades.PRODUCCION_OP_LIQUIDACION
                With alm_detBE
                    .ID_CAB = alm_cabBE.ID
                    .ITEM = row("ITEM")
                    .TIPO = row("TIPO")
                    .COSTO = row("COSTO")
                    .CANTIDAD = row("CANTIDAD")
                    .WAREHOUSE_REF = row("COD_ALMACEN")
                    .DOCUMENT_REF = ""
                    .NUMBER_DOCUMENT_REF = ""
                    .FECHA_REF = row("FECHA_REF")
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .ITEM_PRODUCTO = row("ITEM_PRODUCTO")
                End With
                ls_det_alm.Add(alm_detBE)
            Next

            Dim ls_det_alm_almacen As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim ls_det_alm_cabecera As New List(Of ClsEntidades.WAREHOUSE_TRANS)
            Dim alm_cabBE_almacen As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE_almacen As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL_almacen As New ClsOperaciones.WAREHOUSE_TRANS
            'PARTE DE LA PRODUCCION DE OP
            '--PARTE DE ALMACEN PARA LAS LIQUIDACIONES NUEVAS
            Dim _contador_cabecera As Integer = 1
            'For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ESTADO='N' ", "ITEM ASC")
            '    clsAlmacenCorrelativoBl = New LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo
            '    clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(row("COD_ALMACEN"), "I")
            '    'la parte de almacen

            '    alm_cabBE_almacen = New ClsEntidades.WAREHOUSE_TRANS
            '    With alm_cabBE_almacen
            '        .WAREHOUSE_ID = row("COD_ALMACEN")
            '        Ref_idalamacen = .WAREHOUSE_ID
            '        .DOCUMENT_ID = "NI"
            '        Ref_documentid = .DOCUMENT_ID
            '        .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + _contador_cabecera))
            '        Ref_numerodocument = .NUMBER_DOCUMENT
            '        .DATE_DOCUMENT = row("FECHA_REF")
            '        .TYPE_TRANS = "I"
            '        Ref_tipo = .TYPE_TRANS
            '        .TRANS_ID = "IP"
            '        Ref_trasactiontype = .TRANS_ID
            '        .DOC_ID_REF = "OP"
            '        .NUM_ID_REF = txt_numero.Text.Trim
            '        .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
            '        .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '        .VAT_REGISTRATION = "" 'Ruc..
            '        .ADDR_DLV = ""  'Direccion ..
            '        .VENDOR_ID = ""
            '        .VENDOR_NAME = ""
            '        .CUSTOMER_ID = ""
            '        .CUSTOMER_NAME = ""
            '        .SALES_TERM = ""
            '        .CURRENCY_TYPE = "MN"
            '        .CURRENCY_EXCHANGE = LibComunVar.ClsVarComun.TCVenta
            '        .STATUS_GUIA = "V"
            '        .AMOUNT = 0
            '        .COMMENT = ""
            '        .TYPE_GUIA = "IP"
            '        .WAREHOUSE_REF = ""
            '        .UPDATE_DATE = Date.Now()
            '        .NUM_ORDER_MANUFACT = ""
            '        .NUMBER_PURCHASE = row("ITEM_PRODUCTO")

            '    End With

            '    Dim _contador_detalle As Integer = 0
            '    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("FECHA_REF='" & row("FECHA_REF") & "' ")
            '        alm_detBE_almacen = New ClsEntidades.WAREHOUSE_TRANS_LINE
            '        With alm_detBE_almacen
            '            .WAREHOUSE_ID = item("COD_ALMACEN")
            '            .DOCUMENT_ID = "NI"
            '            .NUMBER_DOCUMENT = alm_cabBE_almacen.NUMBER_DOCUMENT
            '            .ITEM = _contador_detalle + 1
            '            .PART_ID = txt_cod_producto_producir.Text.Trim
            '            .QTY = item("CANTIDAD")
            '            .QTY_DLV = .QTY
            '            .QTY_REF = .QTY
            '            .QTY_INVOICED = 0
            '            .AMOUNT_SALES = 0
            '            .AVERAGE_COST = CDbl(item("COSTO"))
            '            .PART_DESCRIPTION = txt_des_prod_producir.Text.Trim
            '            .UNIT_PART = txt_unidad_prod_producir.Text.Trim
            '            .NUMBER_LOT = ""
            '            .WAREHOUSE_REF = ""
            '            .ACCOUNT = _ACCOUNT
            '            .NUM_PROTOCOLOS = ""
            '            .OPT_ENTREGA = ""
            '            .QT_BULTOS = 0
            '            .PROCEDENCIA = ""
            '            .PAIS_ORIGEN = ""
            '            .CURRENCY_ID = "MN"
            '            .STATUS_VALUE = 1
            '            .NUMBER_ANALIS = ""
            '        End With
            '        ls_det_alm_almacen.Add(alm_detBE_almacen)
            '        _contador_detalle = _contador_detalle + 1
            '    Next
            '    '--PARTE DE ALMACEN

            '    ls_det_alm_cabecera.Add(alm_cabBE_almacen)
            '    _contador_cabecera = _contador_cabecera + 1
            'Next
            _contador_cabecera = 1
            Me.Cursor = Cursors.WaitCursor
            '--PARTE DE ALMACEN
            If almacenBL.Guardar_Produccion_OP_Liquidacion(ls_det_alm, ls_det_alm_cabecera, ls_det_alm_almacen) Then
                Dim msj As String = String.Empty
                msj = String.Empty
                msj = "Liquidación Generado Correctamente." '& vbCrLf & " Nro Documento: " & "NS" & " - " & alm_cabBE_almacen.NUMBER_DOCUMENT
                MsgBox(msj, MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class