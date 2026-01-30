Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing

Public Class frm_Ingreso_Orden_Compra

    Dim MostrarMovimientoBl As ClsTransacciones.clsMostrarTiposMovimiento
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim clsGuiaRemisionBl As ClsOperaciones.WAREHOUSE_TRANS
    Dim dtTransaccionTipo As DataTable
    Dim dtAlmacen As DataTable
    Dim cmbcell As DataGridViewComboBoxCell
    Dim NumeracionGuiaRemision As String
    Dim TipoNumeracion As String
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDocumentoGuias As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleBultosPrincipal As DataTable

    Dim clsAlmacenCabBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenDetBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
    Dim dtCabeceraAlm As DataTable
    Dim dtDetalleAlm As DataTable

    Dim dtOrdenCompraCab As DataTable
    Dim dtOrdenCompraDet As DataTable

    Dim Modo_consultar As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Dim _DIRECCION As String = String.Empty
    Dim _RUC As String = String.Empty
    Dim _STATUS_GUIA As String = String.Empty
    Dim _ACCOUNT As String = String.Empty

    Dim NumeroLineas As String
    Dim SerieDocumento As String
    Dim edicion As Boolean = False

    Dim TipoArticulo As String = String.Empty
    Dim PerteneceGuiaAnalisis As Boolean = False
    Dim clsBusquedaBl As ClsBuscar
    Dim Ref_idalamacen As String = String.Empty
    Dim Ref_documentid As String = String.Empty
    Dim Ref_numerodocument As String = String.Empty
    Dim dtData As DataTable
    Dim _item_a_duplicar As Integer

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("SALDO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("NRO_PROTOCOLO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NRO_BULTOS", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("MONTO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("OPT_ENTREGA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("USO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("COSTO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("ITEM_ORDEN_COMPRA", Type.GetType("System.Int64"))
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.Columns(0).Width = 50
            dgvDetalle.Columns(0).HeaderText = "Item"
            dgvDetalle.Columns(1).Width = 50
            dgvDetalle.Columns(1).HeaderText = "Codigo"
            dgvDetalle.Columns(2).Width = 220
            dgvDetalle.Columns(2).HeaderText = "Articulo"
            dgvDetalle.Columns(3).Width = 60
            dgvDetalle.Columns(3).HeaderText = "Unidad"
            dgvDetalle.Columns(4).Width = 70
            dgvDetalle.Columns(4).HeaderText = "Lote"
            dgvDetalle.Columns(5).Width = 80
            dgvDetalle.Columns(5).HeaderText = "Cantidad"
            dgvDetalle.Columns(6).Width = 80
            dgvDetalle.Columns(6).HeaderText = "Saldo"
            dgvDetalle.Columns(7).Width = 80
            dgvDetalle.Columns(7).HeaderText = "Protocolo"
            dgvDetalle.Columns(8).Width = 80
            dgvDetalle.Columns(8).HeaderText = "Bultos"
            dgvDetalle.Columns(9).Width = 80
            dgvDetalle.Columns(9).HeaderText = "Monto"
            dgvDetalle.Columns(10).Visible = False
            dgvDetalle.Columns(11).HeaderText = "Uso"
            dgvDetalle.Columns(12).Visible = False
            dgvDetalle.Columns("ITEM_ORDEN_COMPRA").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BultosGenerarColummnaDataTable()
        dtdetalleBultosPrincipal = New DataTable
        dtdetalleBultosPrincipal.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("DATE_DOCUMENT", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("TYPE_TRANS", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
        dtdetalleBultosPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
        dtdetalleBultosPrincipal.Columns.Add("QTY_BULTOS", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("IDENTIFICADOR", Type.GetType("System.String"))
    End Sub

    'Public Sub GenerarColummnaDataTable()
    '    dtdetalleArticuloPrincipal = New DataTable
    '    dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
    '    dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
    '    dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
    '    dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String"))
    '    dtdetalleArticuloPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
    '    dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
    '    dtdetalleArticuloPrincipal.Columns.Add("SALDO", Type.GetType("System.Double"))
    '    dgvDetalle.DataSource = Nothing
    '    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
    '    dgvDetalle.Columns(0).Width = 60
    '    dgvDetalle.Columns(1).Width = 80
    '    dgvDetalle.Columns(2).Width = 400
    '    dgvDetalle.Columns(3).Width = 80
    '    dgvDetalle.Columns(4).Width = 100
    '    dgvDetalle.Columns(5).Width = 100
    '    dgvDetalle.Columns(6).Width = 100
    '    dgvDetalle.Columns(6).Visible = False
    'End Sub
    Private Sub frm_CX_LT_GuiaRemision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        clsAlmacenBl = New ClsTransacciones.clsAlmacen
        NumeroLineas = String.Empty
        clsAlmacenBl.Get_NumeroGuiaRemision("")
        NumeroLineas = clsAlmacenBl.NUMBER_LINE
        txt_num_guia.Text = clsAlmacenBl.NUMBER_SERIE
        txt_tc.Text = ClsVarComun.TCVenta
        Cargar_Almacen(CboAlmacen)
        btnEliminarDocum.Visible = NIVEL_ACCESO()
        TransaccionesTipos()
        Call Cargar_Moneda()
    End Sub
    Private Function NIVEL_ACCESO() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            clsBusquedaBl = New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "01" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "02" Then
                        FLAG_NIVEL = False
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function

    Private Sub TransaccionesTipos()
        Try
            clsTransaccionTipoBl = New LibCobranzas.ClsOperaciones.TRANSACTION_TYPE
            dtTransaccionTipo = New DataTable
            dtTransaccionTipo = clsTransaccionTipoBl.get_TransaccionesTipoOC()
            Dim row As DataRow = dtTransaccionTipo.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(-SELECCIONE-)"
            dtTransaccionTipo.Rows.InsertAt(row, 0)
            If dtTransaccionTipo.Rows.Count() <> 0 Then
                CboTipoTransaccion.DataSource = dtTransaccionTipo
                CboTipoTransaccion.DisplayMember = "DESCRIPCION"
                CboTipoTransaccion.ValueMember = "CODIGO"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoTipoTransacciones()
        Try
            MostrarMovimientoBl = New ClsTransacciones.clsMostrarTiposMovimiento
            Dim CodigoTransaccion As String = String.Empty
            CodigoTransaccion = CboTipoTransaccion.SelectedValue.ToString
            MostrarMovimientoBl.Get_TipoTransacciones("I", CodigoTransaccion)
            'Valorizado
            'If MostrarMovimientoBl.IS_CUSTOMER = "N" Then
            '    txt_cod_cli.Enabled = False
            '    txt_des_cli.Text = String.Empty
            '    txt_cod_cli.Text = String.Empty
            '    txt_cod_cli.BackColor = Drawing.Color.White
            '    txt_cod_cli.ForeColor = Drawing.Color.Black
            'ElseIf MostrarMovimientoBl.IS_CUSTOMER = "S" Then
            '    txt_cod_cli.Enabled = True
            '    txt_des_cli.Text = String.Empty
            '    txt_cod_cli.Text = String.Empty
            '    txt_cod_cli.BackColor = Drawing.Color.Aquamarine
            '    txt_cod_cli.ForeColor = Drawing.Color.Black
            'End If
            'If MostrarMovimientoBl.IS_VENDOR = "N" Then
            '    txt_cod_prove.Enabled = False
            '    txt_des_prove.Text = String.Empty
            '    txt_cod_prove.Text = String.Empty
            '    txt_cod_prove.BackColor = Drawing.Color.White
            '    txt_cod_prove.ForeColor = Drawing.Color.Black
            'ElseIf MostrarMovimientoBl.IS_VENDOR = "S" Then
            '    txt_cod_prove.Enabled = True
            '    txt_cod_prove.Text = String.Empty
            '    txt_cod_prove.Text = String.Empty
            '    txt_cod_prove.BackColor = Drawing.Color.Aquamarine
            '    txt_cod_prove.ForeColor = Drawing.Color.Black
            'End If
            ' Almacen   
            If MostrarMovimientoBl.WHO_ID = String.Empty Then
                CboAlmacen.Enabled = True
                CboAlmacen.SelectedIndex = 0
                CboAlmacen.BackColor = Drawing.Color.Aquamarine
                CboAlmacen.ForeColor = Drawing.Color.Black
            Else
                CboAlmacen.Enabled = False
                CboAlmacen.SelectedValue = MostrarMovimientoBl.WHO_ID
                CboAlmacen.BackColor = Drawing.Color.White
                CboAlmacen.ForeColor = Drawing.Color.Black
            End If
            'tipo Doc Ref   
            If MostrarMovimientoBl.IS_DOC_REF = "N" Then
                txtTipoDocRef.Enabled = False
                txtNumDocRef.Enabled = False
                txtTipoDocRef.Text = String.Empty
                txtNumDocRef.Text = String.Empty
                txtTipoDocRef.BackColor = Drawing.Color.White
                txtNumDocRef.BackColor = Drawing.Color.White
                txtTipoDocRef.ForeColor = Drawing.Color.White
                txtNumDocRef.ForeColor = Drawing.Color.White
            ElseIf MostrarMovimientoBl.IS_DOC_REF = "S" Then
                txtNumDocRef.Enabled = True
                txtTipoDocRef.Enabled = True
                txtTipoDocRef.Text = String.Empty
                txtNumDocRef.Text = String.Empty
                txtTipoDocRef.BackColor = Drawing.Color.Aquamarine
                txtTipoDocRef.ForeColor = Drawing.Color.Black
                txtNumDocRef.BackColor = Drawing.Color.Aquamarine
                txtNumDocRef.ForeColor = Drawing.Color.Black
            End If
            'Orden de Fabricacion
            'If MostrarMovimientoBl.IS_ORDER_PURCHASE = "N" Then
            '    txtorderFabricacion.Enabled = False
            '    txtorderFabricacion.Text = String.Empty
            '    txtorderFabricacion.BackColor = Drawing.Color.White
            '    txtorderFabricacion.ForeColor = Drawing.Color.Black
            'ElseIf MostrarMovimientoBl.IS_ORDER_PURCHASE = "S" Then
            '    txtorderFabricacion.Enabled = True
            '    txtorderFabricacion.Text = String.Empty
            '    txtorderFabricacion.BackColor = Drawing.Color.Aquamarine
            '    txtorderFabricacion.ForeColor = Drawing.Color.Black
            'End If
            ''Tipo Articulo 
            'TipoArticulo = String.Empty
            'TipoArticulo = MostrarMovimientoBl.WHO_ID_PART_TYPE
            'Tipo Articulo 
            TipoArticulo = String.Empty
            TipoArticulo = MostrarMovimientoBl.WHO_ID_PART_TYPE
            'Generacion de Guia de Analisis
            If MostrarMovimientoBl.IS_GUIA_ANALISIS = "S" Then
                PerteneceGuiaAnalisis = True
            ElseIf MostrarMovimientoBl.IS_GUIA_ANALISIS = "N" Then
                PerteneceGuiaAnalisis = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Almacen(ByVal Combobox As ComboBox)
        Dim almacenBL As New ClsOperaciones.WAREHOUSE
        dtAlmacen = New DataTable
        dtAlmacen = almacenBL.get_Almacenes_Ayuda(LibComunVar.ClsVarComun.AccesoAlmacenes)
        Dim row As DataRow = dtAlmacen.NewRow()
        row.Item("CODIGO") = ""
        row.Item("DESCRIPCION") = "(-SELECCIONE-)"
        dtAlmacen.Rows.InsertAt(row, 0)
        Combobox.DataSource = dtAlmacen
        Combobox.DisplayMember = "DESCRIPCION"
        Combobox.ValueMember = "CODIGO"
        almacenBL = Nothing
    End Sub

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cmb_moneda.DataSource = monedaBL.get_TiposCambio()
        cmb_moneda.ValueMember = "CODIGO"
        cmb_moneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub

    Private Sub Ayuda_Proveedor()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_VENDOR_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Proveedores"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_prove.Text = frm.Data_Matriz.Rows(0).Item(0)
                txt_des_prove.Text = frm.Data_Matriz.Rows(0).Item(1)
                _RUC = String.Empty
                _DIRECCION = String.Empty
                _RUC = frm.Data_Matriz.Rows(0).Item(2).ToString
                _DIRECCION = frm.Data_Matriz.Rows(0).Item(3).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Cliente()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CUSTOMER_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_cli.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_cli.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                _RUC = String.Empty
                _DIRECCION = String.Empty
                _RUC = frm.Data_Matriz.Rows(0).Item(2).ToString
                _DIRECCION = frm.Data_Matriz.Rows(0).Item(3).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Tramos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_TRAMOS_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Tramos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_tramo.Text = frm.Data_Matriz.Rows(0).Item(0)
                txt_des_tramo.Text = frm.Data_Matriz.Rows(0).Item(1)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Transporte()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CARRIER_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Transportista"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_trans.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_transportista.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
            Call Buscar_Datos_Transportista()
            txt_cod_trans.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Proyecto()
        Dim frm_ayuda As New frm_CX_LT_Ayuda
        frm_ayuda.p_ops = 11
        frm_ayuda.ShowDialog()
        If frm_ayuda.p_bol_aceptar Then
            txt_cod_proy.Text = frm_ayuda.p_ls_sel(0)
            txt_des_proy.Text = frm_ayuda.p_ls_sel(1)
            txt_cod_proy.Focus()
        End If
    End Sub

    Private Sub Ayuda_CentroCosto()
        Dim frm_ayuda As New frm_CX_LT_Ayuda
        frm_ayuda.p_ops = 12
        frm_ayuda.ShowDialog()
        If frm_ayuda.p_bol_aceptar Then
            txt_cod_cc.Text = frm_ayuda.p_ls_sel(0)
            txt_des_cc.Text = frm_ayuda.p_ls_sel(1)
            txt_cod_cc.Focus()
        End If
    End Sub

    Private Sub Ayuda_Tipo_Transacciones()
        Dim frm_ayuda As New frm_CX_LT_Ayuda
        frm_ayuda.p_ops = 13
        frm_ayuda.ShowDialog()
        If frm_ayuda.p_bol_aceptar Then
            txt_tipo_Trans.Text = frm_ayuda.p_ls_sel(0)
            txt_des_transacciones.Text = frm_ayuda.p_ls_sel(1)
            txt_tipo_Trans.Focus()
        End If
    End Sub

    Private Sub Buscar_Datos_Transportista()
        Dim transporBl As New ClsOperaciones.CARRIER
        Dim dt_tmp As DataTable = transporBl.get_Transportistas_por_Cod(txt_cod_trans.Text.Trim)

        If dt_tmp.Rows.Count > 0 Then
            txt_placa.Text = dt_tmp.Rows(0)("number_Inscrip").ToString
            txt_num_reg.Text = dt_tmp.Rows(0)("NUMBER_REGISTRATION").ToString
            txt_cod_chofer.Text = ""
            txt_des_chofer.Text = ""
            txt_dir_chofer.Text = dt_tmp.Rows(0)("ADDR").ToString
            txt_ruc_chofer.Text = ""
        End If

        dt_tmp.Dispose()
    End Sub

    Private Sub Ayuda_Articulos()
        'Dim frm_articulos As New frm_CX_LT_BuscaArticulos
        'frm_articulos.ShowDialog()
        'If frm_articulos.bol_aceptar Then
        '    Dim f As Integer = 0
        '    Dim cod_art As String = String.Empty
        '    Dim almacen As String = CboAlmacen.SelectedValue.ToString

        '    dgv_detalle.Rows.Add()
        '    f = dgv_detalle.Rows.Count - 1
        '    cod_art = frm_articulos.ls_cliente(0)

        '    dgv_detalle.Rows(f).Cells("col_item").Value = dgv_detalle.Rows.Count
        '    dgv_detalle.Rows(f).Cells("col_codarti").Value = cod_art
        '    dgv_detalle.Rows(f).Cells("col_desarti").Value = frm_articulos.ls_cliente(1)
        '    dgv_detalle.Rows(f).Cells("col_um").Value = frm_articulos.ls_cliente(2)
        '    dgv_detalle.Rows(f).Cells("col_can").Value = 1
        '    dgv_detalle.Rows(f).Cells("col_pu").Value = 0
        '    dgv_detalle.Rows(f).Cells("col_pro").Value = ""
        '    dgv_detalle.Rows(f).Cells("col_cc").Value = ""
        '    dgv_detalle.Update()

        '    Dim loteBL As New ClsOperaciones.LOT
        '    Dim cmbcell As DataGridViewComboBoxCell
        '    Dim dt_lotes As DataTable = loteBL.get_Lote_x_Articulo(almacen, cod_art)
        '    cmbcell = dgv_detalle.Rows(f).Cells("col_lote")
        '    cmbcell.Items.Clear()
        '    For i As Integer = 0 To dt_lotes.Rows.Count - 1
        '        cmbcell.Items.Add(dt_lotes.Rows(i)("LOT_ID").ToString)
        '    Next
        'End If
        'frm_articulos.Dispose()
    End Sub

    Private Sub Eliminar_Fila()
        'If dgv_detalle.Rows.Count = 0 Then Exit Sub
        'If dgv_detalle.CurrentRow Is Nothing Then Exit Sub

        'dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow)
        'Call ReHacer_Secuencia()
        ' Call Sumar_totales()
    End Sub

    Private Sub Sumar_totales()
        Dim total As Double = 0
        'For i As Integer = 0 To dgv_detalle.Rows.Count - 1
        '    'total += dgv_detalle.Rows(i).Cells("col_tot").Value
        'Next
        'txt_subtotal.Text = Format(Math.Round(total, 2), "##,###.#0")
        'txt_igv.Text = Format(Math.Round(total * gIGV, 2), "##,###.#0")
        'txt_total.Text = Format(Math.Round(total + CDbl(txt_igv.Text), 2), "##,###.#0")
    End Sub

    Private Sub ReHacer_Secuencia()
        'For i As Integer = 0 To dgv_detalle.Rows.Count - 1
        '    dgv_detalle.Rows(i).Cells("col_item").Value = (i + 1)
        'Next
    End Sub

    Private Sub txt_cod_tt_DoubleClick(sender As Object, e As EventArgs) Handles txt_tipo_Trans.DoubleClick
        Call Ayuda_Tipo_Transacciones()
    End Sub

    Private Sub txt_cod_prove_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod_prove.DoubleClick
        Call Ayuda_Proveedor()
    End Sub

    Private Sub txt_cod_cli_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod_cli.DoubleClick
        Call Ayuda_Cliente()
    End Sub

    Private Sub txt_cod_tramo_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod_tramo.DoubleClick
        Call Ayuda_Tramos()
    End Sub

    Private Sub txt_cod_trans_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod_trans.DoubleClick
        Call Ayuda_Transporte()
    End Sub

    Private Sub txt_cod_proy_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod_proy.DoubleClick
        Call Ayuda_Proyecto()
    End Sub

    Private Sub txt_cod_cc_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod_cc.DoubleClick
        Call Ayuda_CentroCosto()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs)
        Call Ayuda_Articulos()
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs)
        Call Eliminar_Fila()
    End Sub
    'Private Sub GenerarIngresoAlmacen()
    '    Try
    '        Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
    '        Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
    '        Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
    '        Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

    '        Dim clsAlmacenCorrelativoBl As New ClsTransacciones.clsAlmacenCorrelativo
    '        clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(CboAlmacen.SelectedValue.ToString, "I")
    '        'la parte de almacen
    '        With alm_cabBE
    '            .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
    '            .DOCUMENT_ID = "NI"
    '            .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
    '            NumeracionGuiaRemision = .NUMBER_DOCUMENT
    '            .DATE_DOCUMENT = CDate(dtp_fecha.Value).ToShortDateString
    '            .TYPE_TRANS = "I"
    '            .TRANS_ID = CboTipoTransaccion.SelectedValue.ToString
    '            .DOC_ID_REF = txtTipoDocRef.Text
    '            .NUM_ID_REF = txtNumDocRef.Text
    '            .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
    '            .USER_ID = LibComunVar.ClsVarComun.USUARIO
    '            .VAT_REGISTRATION = _RUC 'Ruc..
    '            .ADDR_DLV = _DIRECCION  'Direccion ..
    '            .VENDOR_ID = txt_cod_prove.Text
    '            .VENDOR_NAME = txt_des_prove.Text
    '            .CUSTOMER_ID = txt_cod_cli.Text
    '            .CUSTOMER_NAME = txt_des_cli.Text
    '            .SALES_TERM = ""
    '            .CURRENCY_TYPE = cmb_moneda.SelectedValue
    '            .CURRENCY_EXCHANGE = CDbl(txt_tc.Text)
    '            .STATUS_GUIA = "V"
    '            .AMOUNT = CDbl(0) * -1
    '            .COMMENT = txtComentarios.Text
    '            .TYPE_GUIA = CboTipoTransaccion.SelectedValue.ToString
    '            .WAREHOUSE_REF = ""
    '            .NUMBER_PURCHASE = txtOrdenCompra.Text
    '        End With
    '        'Detalle de la Guia...
    '        For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
    '            alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
    '            With alm_detBE
    '                .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
    '                .DOCUMENT_ID = "NI"
    '                .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
    '                .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
    '                .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
    '                .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
    '                .QTY_DLV = 0
    '                .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
    '                .QTY_INVOICED = 0
    '                .AMOUNT_SALES = 0
    '                .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
    '                .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
    '                .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
    '                .WAREHOUSE_REF = ""
    '                .ACCOUNT = ""
    '            End With
    '            ls_det_alm.Add(alm_detBE)
    '        Next
    '        Me.Cursor = Cursors.WaitCursor
    '        almacenBL.GuardarAlmacen(alm_cabBE, ls_det_alm, "I")
    '        Dim msj As String = String.Empty
    '        msj = "Documento generado Correctamente, Nro Documento: " & NumeracionGuiaRemision
    '        MsgBox(msj, MsgBoxStyle.Information)
    '        imprimirGuiaRemision(CboAlmacen.SelectedValue.ToString(), "NI", NumeracionGuiaRemision)
    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Function GenerarIngresoAlmacen() As Boolean
        Try
            Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Dim numero_bultos As String, qty_bultos As Double

            Dim clsAlmacenCorrelativoBl As New LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(CboAlmacen.SelectedValue.ToString, "I")
            'la parte de almacen
            With alm_cabBE
                .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                .DOCUMENT_ID = "NI"
                .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                .DATE_DOCUMENT = CDate(dtp_fecha.Value).ToShortDateString
                .TYPE_TRANS = "I"
                .TRANS_ID = CboTipoTransaccion.SelectedValue.ToString
                .DOC_ID_REF = txtTipoDocRef.Text
                .NUM_ID_REF = txtNumDocRef.Text
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .VAT_REGISTRATION = _RUC 'Ruc..
                .ADDR_DLV = _DIRECCION  'Direccion ..
                .VENDOR_ID = txt_cod_prove.Text
                .VENDOR_NAME = txt_des_prove.Text
                .CUSTOMER_ID = txt_cod_cli.Text
                .CUSTOMER_NAME = txt_des_cli.Text
                .SALES_TERM = ""
                .CURRENCY_TYPE = cmb_moneda.SelectedValue.ToString
                .CURRENCY_EXCHANGE = LibComunVar.ClsVarComun.TCVenta
                .STATUS_GUIA = "V"
                .AMOUNT = 0
                .COMMENT = txtComentarios.Text
                .TYPE_GUIA = CboTipoTransaccion.SelectedValue.ToString
                .WAREHOUSE_REF = ""
                .UPDATE_DATE = Date.Now()
                .NUM_ORDER_MANUFACT = ""
                .NUMBER_PURCHASE = txtOrdenCompra.Text
                .IS_COD_PRODUCTO = ""
            End With
            'Detalle de la Guia...
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE
                    .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                    .DOCUMENT_ID = "NI"
                    .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_DLV = 0
                    .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .AVERAGE_COST = CDbl(dtdetalleArticuloPrincipal.Rows(i).Item("COSTO").ToString)
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                    .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                    .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                    .WAREHOUSE_REF = ""
                    .ACCOUNT = _ACCOUNT
                    .STATUS_VALUE = False
                    .NUM_PROTOCOLOS = dtdetalleArticuloPrincipal.Rows(i).Item("NRO_PROTOCOLO").ToString
                    .OPT_ENTREGA = dtdetalleArticuloPrincipal.Rows(i).Item("OPT_ENTREGA").ToString
                    numero_bultos = dtdetalleArticuloPrincipal.Rows(i).Item("NRO_BULTOS").ToString
                    If numero_bultos = "" Then
                        qty_bultos = 0
                    Else
                        qty_bultos = CDbl(numero_bultos)
                    End If
                    'qty_bultos = IIf(numero_bultos = "", 0, CDbl(numero_bultos))
                    .QT_BULTOS = qty_bultos 'dtdetalleArticuloPrincipal.Rows(i).Item("NRO_BULTOS").ToString
                    .CURRENCY_ID = cmb_moneda.SelectedValue.ToString
                    reporteBL = New ClsBuscar
                    dtImprimir = New DataTable("Transaccion")
                    dtImprimir = reporteBL.Get_obtenerdatos_Transaccion("I", CboTipoTransaccion.SelectedValue.ToString)
                    If dtImprimir.Rows.Count > 0 Then
                        .STATUS_VALUE = IIf(dtImprimir.Rows(0).Item("IS_VALUED").ToString = "V", 1, 0)
                    Else
                        .STATUS_VALUE = 0
                    End If
                    .NUMBER_ANALIS = ""
                    .ITEM_ORDEN_COMPRA = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_ORDEN_COMPRA").ToString
                End With
                ls_det_alm.Add(alm_detBE)
            Next
            Me.Cursor = Cursors.WaitCursor
            almacenBL.GuardarInventarioAlmacenII(alm_cabBE, ls_det_alm)
            '--Generando el Numero de Analiss
            'If PerteneceGuiaAnalisis Then
            '    GenerarNumeroAnalisis(CboAlmacen.SelectedValue.ToString(), "NI", alm_cabBE.NUMBER_DOCUMENT)
            'End If
            'If CboAlmacen.SelectedValue.ToString = "18" Then
            '    clsBusquedaBl = New ClsBuscar
            '    clsBusquedaBl.ActualizandoEstadoControl_C(CboAlmacen.SelectedValue.ToString(), "NI", alm_cabBE.NUMBER_DOCUMENT)
            'End If
            '--Actualizando el Estado para Control de Calidad PT'
            'If CboAlmacen.SelectedValue.ToString = "04" And CboTipoTransaccion.SelectedValue = "IP" And txtTipoDocRef.Text = "GP" Then
            '    clsBusquedaBl = New ClsBuscar
            '    clsBusquedaBl.ActualizandoEstadoControl_C(CboAlmacen.SelectedValue.ToString(), "NI", alm_cabBE.NUMBER_DOCUMENT)
            'End If
            '--guardando CantidadAsigandaLote
            GenerarInsercionLotes(CboAlmacen.SelectedValue.ToString(), "NI", alm_cabBE.NUMBER_DOCUMENT, Date.Today, "I")
            Dim msj As String = String.Empty
            msj = String.Empty
            msj = "Nuevo Documento Generado Correctamente," & vbCrLf & " Nro Documento: " & "NI" & " - " & alm_cabBE.NUMBER_DOCUMENT
            MsgBox(msj, MsgBoxStyle.Information)
            If MessageBox.Show("Se procedera a la Impresion del Documento" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Imprimir ingreso o salida  Almacen
                imprimirAlmacen(CboAlmacen.SelectedValue.ToString, "NI", alm_cabBE.NUMBER_DOCUMENT)
            End If
            Return True

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub imprimirAlmacen(ByVal _idalamacen As String, ByVal _documentid As String, ByVal _numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Almacen")
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(_idalamacen, _documentid, _numerodocument)
            'If dtImprimir.Rows.Count() <> 0 Then
            '    crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", dtImprimir, "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
            'End If
            If dtImprimir.Rows.Count() <> 0 Then
                If _idalamacen = "01" Then
                    crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                Else
                    crystalBL.Muestra_Reporte("rpt_Mov_Almacen_Guia_Analisis.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarNumeroAnalisis(ByVal idlamacen As String, ByVal documentId As String, ByVal NumeroDocumento As String)
        Try
            clsBusquedaBl = New ClsBuscar
            clsBusquedaBl.ActualizandoNumeroAnalisis(idlamacen, documentId, NumeroDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarInsercionLotes(ByVal WAREHOUSE_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOCUMENT As String, _
                                  ByVal DATE_DOCUMENT As String, ByVal TYPE_TRANS As String)
        Try
            clsBusquedaBl = New ClsBuscar
            For i As Integer = 0 To dtdetalleBultosPrincipal.Rows.Count() - 1

                clsBusquedaBl.InsertarCantidadLotes(WAREHOUSE_ID, DOCUMENT_ID, NUMBER_DOCUMENT, DATE_DOCUMENT, TYPE_TRANS, dtdetalleBultosPrincipal.Rows(i).Item("PART_ID").ToString(), _
                                                    dtdetalleBultosPrincipal.Rows(i).Item("LOTE").ToString(), dtdetalleBultosPrincipal.Rows(i).Item("QTY").ToString(), _
                                                    dtdetalleBultosPrincipal.Rows(i).Item("QTY_BULTOS").ToString(), i + 1)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function ValidacionGeneral(ByRef idalamacen As String, ByRef documentid As String, ByRef numerodocument As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            idalamacen = dgvDocumentosGuias.Item(0, dgvDocumentosGuias.CurrentRow.Index).Value
            documentid = dgvDocumentosGuias.Item(2, dgvDocumentosGuias.CurrentRow.Index).Value
            numerodocument = dgvDocumentosGuias.Item(3, dgvDocumentosGuias.CurrentRow.Index).Value
            'validacion
            If idalamacen = String.Empty Or documentid = String.Empty Or numerodocument = String.Empty Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Return estado
    End Function


    Private Function CodigoNumeracionGuiaRemision() As Boolean
        Dim estado As Boolean = True
        Try
            Dim frmTipoNum As New FrmTipoNumeracion
            frmTipoNum.Almacen = CboAlmacen.SelectedValue.ToString
            frmTipoNum.ShowDialog()
            If frmTipoNum.fl_datos = False Then
                estado = False
                frmTipoNum.Close()
                Exit Try
            End If
            NumeracionGuiaRemision = String.Empty
            TipoNumeracion = String.Empty
            NumeracionGuiaRemision = frmTipoNum.NumeracionGuiaRemision
            TipoNumeracion = frmTipoNum.TipoNumeracion
            frmTipoNum.Close()
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub cmbTipoTransaccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoTransaccion.SelectedIndexChanged
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If CboTipoTransaccion.SelectedIndex = 0 Then
                gbCabecera.Enabled = False
                gbdetalle.Enabled = False
                gbOpciones.Enabled = False
            Else
                gbCabecera.Enabled = True
                gbdetalle.Enabled = True
                gbOpciones.Enabled = True
                MostrandoTipoTransacciones()
            End If
        End If

    End Sub
    Private Function DatosLotes(Optional ByVal Lote As String = "", Optional ByVal CodigoPart As String = "") As String
        Dim Cadena As String = String.Empty
        Try
            Dim listaLot As New List(Of String)
            Dim cadena_lote As String = String.Empty
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                If edicion = True Then
                    If dtdetalleArticuloPrincipal.Rows.Count() = 1 Then
                        Exit Try
                    End If
                End If
                If Lote = String.Empty Then
                    For i As Integer = 0 To dgvDetalle.Rows.Count() - 1
                        Dim lotes As String = String.Empty
                        lotes = dgvDetalle.Item(4, i).Value
                        If listaLot.Contains(lotes) = False Then
                            listaLot.Add(lotes)
                        End If
                    Next
                    For j As Integer = 0 To listaLot.Count() - 1
                        cadena_lote += "'" & listaLot(j) & "',"
                    Next
                    Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
                Else
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("CODIGO='" & CodigoPart & "' and LOTE NOT IN ('" & Lote & "')")
                        Dim lotes As String = String.Empty
                        lotes = item("LOTE")
                        If listaLot.Contains(lotes) = False Then
                            listaLot.Add(lotes)
                        End If
                    Next
                    If listaLot.Count() <> 0 Then
                        For j As Integer = 0 To listaLot.Count() - 1
                            cadena_lote += "'" & listaLot(j) & "',"
                        Next
                        Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Cadena
    End Function



    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticulo_Transferencia
            frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
            frmArticulo.ValidacionLotes = DatosLotes()
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO").ToString
                row("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION").ToString
                row("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD").ToString
                row("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE").ToString
                row("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD").ToString
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
            End If
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validaciones() = False Then Exit Sub
            GbTransaccion.Enabled = False
            gbCabecera.Enabled = False
            If dgvDetalle.Rows.Count() = NumeroLineas Then
                MsgBox("Ya alcanzo el Numero maximo de Lineas permitido para este tipo de Documento.", MsgBoxStyle.Information)
                Exit Sub
            End If
            edicion = False
            AgregandoArticulos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ActualizandoCorrelativoItem()
        'Actualizando Numeracion
        Dim Index As Integer = 0
        Dim fila As Integer = 0
        Dim ident As String = String.Empty
        Dim lista As New List(Of String)
        For Each rows As DataRow In dtdetalleArticuloPrincipal.Rows
            ident = rows("iTEM")
            If lista.Contains(ident) = False Then
                lista.Add(ident)
                Continue For
            End If
        Next
        For i As Integer = 0 To lista.Count() - 1
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & lista(i))
                dtdetalleArticuloPrincipal.BeginInit()
                item("ITEM") = i + 1
                dtdetalleArticuloPrincipal.EndInit()
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next
        Next
    End Sub

    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    item.Delete()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            EliminandoArticulo()
        Catch ex As Exception

        End Try
    End Sub
    'Private Sub ModificandoArticulos()
    '    Try
    '        If MsgBox("¿Desea modificar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Aviso") = MsgBoxResult.Yes Then
    '            Dim frmArticulo As New FrmAsignarArticulo_OC
    '            frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
    '            Dim lote As String = dgvDetalle.Item(4, dgvDetalle.CurrentRow.Index).Value.ToString
    '            Dim CodigoArticulo As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
    '            Dim Saldo As String = String.Empty
    '            If lote = String.Empty Then
    '                frmArticulo.ValidacionLotes = DatosLotes()
    '            Else
    '                frmArticulo.ValidacionLotes = DatosLotes(lote, CodigoArticulo)
    '            End If
    '            Saldo = dgvDetalle.Item(6, dgvDetalle.CurrentRow.Index).Value
    '            frmArticulo.Qt_saldo = CDbl(Saldo)
    '            frmArticulo.GenerarColummnaDataTable()
    '            frmArticulo.Flag_Modo_Edicion = True
    '            Dim Codigo As String = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
    '            'Enviando datos seleccioandos a Modificar
    '            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
    '                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
    '                row("ITEM") = item("ITEM")
    '                row("CODIGO") = item("CODIGO")
    '                row("DESCRIPCION") = item("DESCRIPCION")
    '                row("UNIDAD") = item("UNIDAD")
    '                row("LOTE") = item("LOTE")
    '                row("CANTIDAD") = item("CANTIDAD")
    '                frmArticulo.dtdetalleArticulo.Rows.Add(row)
    '                frmArticulo.dtdetalleArticulo.AcceptChanges()
    '            Next
    '            frmArticulo.ShowDialog()
    '            If frmArticulo.fl_close = False Then
    '                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
    '                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
    '                        dtdetalleArticuloPrincipal.BeginInit()
    '                        item("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
    '                        item("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION")
    '                        item("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD")
    '                        item("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
    '                        item("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
    '                        dtdetalleArticuloPrincipal.EndInit()
    '                        dtdetalleArticuloPrincipal.AcceptChanges()
    '                    Next
    '                End If
    '            End If
    '            frmArticulo.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub ModificandoArticulos()
        Try
            'GbCabecera.Enabled = False
            Dim frmArticulo As New FrmAsignarArticuloOrdenCompra
            Dim lote As String = dgvDetalle.Item(4, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim CodigoArticulo As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
            frmArticulo.EsValorizado = False
            frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
            frmArticulo.Flag_ModoEdicion = True
            frmArticulo.Identificador = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            frmArticulo.TipoMov = "I"
            frmArticulo.TransaccionTipoArticulo = TipoArticulo
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.BultosGenerarColummnaDataTable()
            frmArticulo.ItemLote = lote
            frmArticulo.Qt_saldo = dgvDetalle.Item(6, dgvDetalle.CurrentRow.Index).Value
            If lote = String.Empty Then
                frmArticulo.ValidacionLotes = DatosLotes()
            Else
                frmArticulo.ValidacionLotes = DatosLotes(lote, CodigoArticulo)
            End If
            Dim Codigo As String = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            'Enviando datos seleccioandos a Modificar
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
                row("ITEM") = item("ITEM")
                row("CODIGO") = item("CODIGO")
                row("DESCRIPCION") = item("DESCRIPCION")
                row("UNIDAD") = item("UNIDAD")
                row("LOTE") = item("LOTE")
                row("CANTIDAD") = item("CANTIDAD")
                row("NRO_PROTOCOLO") = item("NRO_PROTOCOLO")
                row("NRO_BULTOS") = item("NRO_BULTOS")
                row("MONTO") = item("MONTO")
                row("OPT_ENTREGA") = item("OPT_ENTREGA")
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                frmArticulo.dtdetalleArticulo.AcceptChanges()
            Next
            'Enviando datos de Bultos  seleccioandos a Modificar 
            For Each item As DataRow In dtdetalleBultosPrincipal.Select("IDENTIFICADOR=" & dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value)
                Dim row As DataRow = frmArticulo.dtDetallesBulto.NewRow
                row("WAREHOUSE_ID") = item("WAREHOUSE_ID")
                row("DOCUMENT_ID") = item("DOCUMENT_ID")
                row("NUMBER_DOCUMENT") = item("NUMBER_DOCUMENT")
                row("DATE_DOCUMENT") = item("DATE_DOCUMENT")
                row("PART_ID") = item("PART_ID")
                row("LOTE") = item("LOTE")
                row("ITEM") = item("ITEM")
                row("QTY") = item("QTY")
                row("QTY_BULTOS") = item("QTY_BULTOS")
                row("IDENTIFICADOR") = item("IDENTIFICADOR")
                frmArticulo.dtDetallesBulto.Rows.Add(row)
            Next
            frmArticulo.ShowDialog()
            If frmArticulo.fl_close = False Then
                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                        dtdetalleArticuloPrincipal.BeginInit()
                        item("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
                        item("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION")
                        item("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD")
                        item("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
                        item("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
                        item("NRO_PROTOCOLO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NRO_PROTOCOLO")
                        item("NRO_BULTOS") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NRO_BULTOS")
                        item("MONTO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("MONTO")
                        item("OPT_ENTREGA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("OPT_ENTREGA")
                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                    Next
                End If
                'detalles de los bultos 
                'Borrando los Datos
                For Each item As DataRow In dtdetalleBultosPrincipal.Select("IDENTIFICADOR=" & frmArticulo.Identificador)
                    item.Delete()
                    dtdetalleBultosPrincipal.AcceptChanges()
                Next
                If frmArticulo.dtDetallesBulto.Rows.Count() <> 0 Then
                    'Agregando Nuevamente los Datos
                    AgregandoNuevosDatosBultos(frmArticulo.dtDetallesBulto, dtdetalleBultosPrincipal, frmArticulo.Identificador)
                End If
            End If
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregandoNuevosDatosBultos(TablaOrigen As DataTable, ByVal TablaDestino As DataTable, ByVal indice As String)
        Try
            For i As Integer = 0 To TablaOrigen.Rows.Count() - 1
                Dim row As DataRow = TablaDestino.NewRow
                row("WAREHOUSE_ID") = ""
                row("DOCUMENT_ID") = ""
                row("NUMBER_DOCUMENT") = ""
                row("DATE_DOCUMENT") = Date.Now()
                row("PART_ID") = TablaOrigen.Rows(i).Item("PART_ID")
                row("LOTE") = TablaOrigen.Rows(i).Item("LOTE")
                row("ITEM") = i + 1
                row("QTY") = TablaOrigen.Rows(i).Item("QTY")
                row("QTY_BULTOS") = TablaOrigen.Rows(i).Item("QTY_BULTOS")
                row("IDENTIFICADOR") = indice
                dtdetalleBultosPrincipal.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        'edicion = True
        'If validaciones() = False Then Exit Sub
        'GbTransaccion.Enabled = False
        'gbCabecera.Enabled = False
        'ModificandoArticulos()
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        edicion = True
        If validaciones() = False Then Exit Sub
        GbTransaccion.Enabled = False
        gbCabecera.Enabled = False
        ModificandoArticulos()
    End Sub

    Private Function validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un Almacen, para poder continuar.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
            If txt_cod_prove.Enabled = True Then
                If txt_cod_prove.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Proveedor.", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If
            End If

            If txtTipoDocRef.Enabled = True Then
                If txtTipoDocRef.Text = String.Empty Then
                    MsgBox("Debe seleccionar un tipo de documento de Referencia.", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If
            End If
            If txtNumDocRef.Enabled = True Then
                If txtNumDocRef.Text = String.Empty Then
                    MsgBox("Debe ingresar un numero de documento de Referencia.", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If
            End If

            If Verificar_Apertura_Cierre_Modulos(dtp_fecha.Value.Month, dtp_fecha.Value.Year) = False Then
                estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function Verificar_Apertura_Cierre_Modulos(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New LibCobranzas.ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.Validar_Cierre_Apertura_Modulos(Mes_Ant, Anio_Ant, "ALMACENES")
            If dtCierre.Rows.Count() > 0 Then
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar el INGRESO.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If gbOpciones.Enabled = False Then
            MsgBox("Debe seleccionar un Tipo de Transaccion, para poder continuar.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If validaciones() = False Then Exit Sub
        If dgvDetalle.Rows.Count() = 0 Then
            MsgBox("No hay items en el Detalle", MsgBoxStyle.Information, "SISTEMAS")
            Exit Sub
        End If
        Dim ListaCant As New List(Of String)
        Dim Flag_indicador As Boolean = False
        'For Each row As DataGridViewRow In dgvDetalle.Rows
        '    If String.IsNullOrEmpty(row.Cells(4).Value.ToString) Then
        '        Flag_indicador = True
        '        dgvDetalle.CurrentCell = dgvDetalle(4, row.Index)
        '        Exit For
        '    End If
        'Next
        If Flag_indicador = True Then
            MsgBox("No se ingreso el lote .", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If
        If GenerarIngresoAlmacen() Then
            dgvDocumentosGuias.Visible = True
            DocumentosGuiaRemision()
            Botonera_Estado_Cambiar(False)
            Me.Cursor = Cursors.Default
        End If
        
    End Sub

    Private Sub Blank()
        dgvDetalle.Columns.Clear()
        Dim controles As Control = gbCabecera
        For Each ctrl As Control In controles.Controls
            'si es Label continuar
            If TypeOf (ctrl) Is Label Then Continue For
            '---------
            If TypeOf (ctrl) Is TextBox Then
                '---validando Cajas de Texto
                ctrl.Text = String.Empty
            End If
        Next
        txt_des_prove.Text = String.Empty
        txt_des_tramo.Text = String.Empty
        txt_des_transportista.Text = String.Empty
        txt_placa.Text = String.Empty
        txt_num_reg.Text = String.Empty
        txt_ruc_chofer.Text = String.Empty
        txt_des_cli.Text = String.Empty
        txtComentarios.Text = String.Empty
        txtOrdenCompra.Text = String.Empty
    End Sub

    Private Sub Nuevo()
        Try
            dgvDocumentosGuias.Visible = False
            GbTransaccion.Enabled = True
            gbCabecera.Enabled = False
            gbdetalle.Enabled = True
            gbOpciones.Enabled = False
            Blank()
            GenerarColummnaDataTable()
            BultosGenerarColummnaDataTable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevoDocumento.Enabled = False
            gbOpcionesBusquedas.Visible = False
            If Modo_consultar = True Then
                btnGrabar.Enabled = False
            Else
                btnGrabar.Enabled = True
            End If
            btnEliminarDocum.Enabled = False
            btnAnular.Enabled = False
            btnConsultarDocumento.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            lblCantidad.Visible = False
        Else
            gbOpcionesBusquedas.Visible = True
            btnNuevoDocumento.Enabled = True
            btnGrabar.Enabled = False
            btnEliminarDocum.Enabled = True
            btnAnular.Enabled = True
            btnConsultarDocumento.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            lblCantidad.Visible = True
        End If

    End Sub

    Private Sub btnNuevoDocumento_Click(sender As Object, e As EventArgs) Handles btnNuevoDocumento.Click
        Botonera_Estado_Cambiar(True)
        Nuevo()
        If CboAlmacen.DataSource Is Nothing Then Exit Sub
        CboAlmacen.SelectedIndex = 0
        CboTipoTransaccion.SelectedIndex = 0
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvDocumentosGuias.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub
        Dim Ref_idalamacen As String = String.Empty
        Dim Ref_documentid As String = String.Empty
        Dim Ref_numerodocument As String = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        imprimirAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
    End Sub

    Private Sub configurarGrilla()
        Try
            dgvDetalle.Columns.Clear()
            dgvDetalle.DataSource = Nothing
            dgvDetalle.Columns.Add("ITEM", "ITEM")
            dgvDetalle.Columns.Add("CODIGO", "CODIGO")
            dgvDetalle.Columns.Add("DESCRIPCION", "DESCRIPCION")
            dgvDetalle.Columns.Add("UNIDAD", "UNIDAD")
            dgvDetalle.Columns.Add("LOTE", "LOTE")
            dgvDetalle.Columns.Add("CANTIDAD", "CANTIDAD")
            dgvDetalle.Columns.Add("PROTOCOLO", "PROTOCOLO")
            dgvDetalle.Columns.Add("BULTOS", "BULTOS")
            dgvDetalle.Columns.Add("ENTREGA", "ENTREGA")
            dgvDetalle.Columns(0).Width = 60
            dgvDetalle.Columns(1).Width = 80
            dgvDetalle.Columns(2).Width = 220
            dgvDetalle.Columns(3).Width = 60
            dgvDetalle.Columns(4).Width = 70
            dgvDetalle.Columns(5).Width = 80
            dgvDetalle.Columns(6).Width = 80
            dgvDetalle.Columns(7).Width = 80
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

    Private Sub MostrandoOrdenCompras(ByVal NUMBER_DOCUMENT As String, ByVal lista As String)
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtOrdenCompraCab = New DataTable
            dtOrdenCompraDet = New DataTable
            dtOrdenCompraCab = clsAlmacenCabBl.get_WarehouseOrdencompraCab(NUMBER_DOCUMENT)
            _RUC = String.Empty
            _DIRECCION = String.Empty
            If dtOrdenCompraCab.Rows.Count() <> 0 Then
                '---Mostrando Datos de Cabecera
                txt_cod_prove.Text = dtOrdenCompraCab.Rows(0).Item("VENDOR_ID").ToString
                txt_des_prove.Text = dtOrdenCompraCab.Rows(0).Item("NAME").ToString
                _RUC = dtOrdenCompraCab.Rows(0).Item("VAT_REGISTRATION_FACT").ToString
                _DIRECCION = dtOrdenCompraCab.Rows(0).Item("ADDR_DLV").ToString
                cmb_moneda.SelectedIndex = IIf(dtOrdenCompraCab.Rows(0).Item("CURRENCY_TYPE").ToString = "MN", 0, 1)
                '---Mostrando Datos de Detalle
                dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_WarehouseOrdencompraDet(NUMBER_DOCUMENT, lista)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    gbOpciones.Enabled = True
                    'RehacerSecuencia()
                Else
                    MsgBox("No hay informacion disponible para Mostrar en este Documento.", MsgBoxStyle.Information)
                    GenerarColummnaDataTable()
                    dgvDetalle.Columns(2).Width = 300
                    dgvDetalle.Columns(6).Visible = True
                    gbOpciones.Enabled = False
                End If
            Else
                MsgBox("No hay informacion disponible para Mostrar.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub MostrarModoConsultar(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String)
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtCabeceraAlm = New DataTable
            dtDetalleAlm = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraAlm = clsAlmacenCabBl.get_CabeceraAlmacen(alm_, doc_, num_)
            If dtCabeceraAlm.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraAlm.Rows.Count() - 1
                    dtp_fecha.Text = dtCabeceraAlm.Rows(i).Item("DATE_DOCUMENT").ToString
                    CboTipoTransaccion.SelectedValue = dtCabeceraAlm.Rows(i).Item("TRANS_ID").ToString
                    CboAlmacen.SelectedValue = dtCabeceraAlm.Rows(i).Item(0).ToString
                    txtTipoDocRef.Text = dtCabeceraAlm.Rows(i).Item("DOC_ID_REF").ToString
                    txtNumDocRef.Text = dtCabeceraAlm.Rows(i).Item("NUM_ID_REF").ToString
                    txt_cod_prove.Text = dtCabeceraAlm.Rows(i).Item("VENDOR_ID").ToString
                    txt_des_prove.Text = dtCabeceraAlm.Rows(i).Item("VENDOR_NAME").ToString
                    txtOrdenCompra.Text = dtCabeceraAlm.Rows(i).Item("NUMBER_PURCHASE").ToString
                    txtComentarios.Text = dtCabeceraAlm.Rows(i).Item("COMMENT").ToString
                Next
                '---Mostrando datos del Detalle
                dtDetalleAlm = clsAlmacenDetBl.get_DetalleAlmacen(alm_, doc_, num_)
                configurarGrilla()
                dgvDetalle.Rows.Clear()
                If dtDetalleAlm.Rows.Count() <> 0 Then
                    For j As Integer = 0 To dtDetalleAlm.Rows.Count() - 1
                        dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                           dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, CDbl(dtDetalleAlm.Rows(j).Item("QTY").ToString), _
                           dtDetalleAlm.Rows(j).Item("NUM_PROTOCOLOS").ToString, _
                           IIf(String.IsNullOrEmpty(dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString), 0, dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString), _
                           IIf(String.IsNullOrEmpty(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString), "", dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString))
                        'IIf(IIf(String.IsNullOrEmpty(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString), "", dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString) = "0", "Parcial", "Total")
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnConsultarDocumento_Click(sender As Object, e As EventArgs) Handles btnConsultarDocumento.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Dim Ref_idalamacen As String = String.Empty
        Dim Ref_documentid As String = String.Empty
        Dim Ref_numerodocument As String = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        dgvDocumentosGuias.Visible = False
        MostrarModoConsultar(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
        GbTransaccion.Enabled = False
        gbCabecera.Enabled = False
        gbdetalle.Enabled = True
        gbOpciones.Enabled = False
        Call Botonera_Estado_Cambiar(True)
    End Sub

    Private Sub EliminarGuiasRemision()
        Try
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Dim NumOc As String = ""
            NumOc = dgvDocumentosGuias.Item(5, dgvDocumentosGuias.CurrentRow.Index).Value
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            almacenBL.EliminarGuiaRemisionII(Ref_idalamacen, Ref_documentid, Ref_numerodocument, NumOc)
            Dim msj As String = String.Empty
            msj = "Documento Eliminado Correctamente, Nro Documento: " & Ref_numerodocument
            MsgBox(msj, MsgBoxStyle.Information)
            DocumentosGuiaRemision()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarDocum_Click(sender As Object, e As EventArgs) Handles btnEliminarDocum.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EliminarGuiasRemision()
        End If
    End Sub

    Private Sub DocumentosGuiaRemision()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsGuiaRemisionBl = New ClsOperaciones.WAREHOUSE_TRANS
            dtDocumentoGuias = New DataTable
            dtDocumentoGuias = clsGuiaRemisionBl.get_DatosGeneralesIngresoOc(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                             cboopcionesBusqueda.SelectedIndex, "I", "NI", LibComunVar.ClsVarComun.AccesoAlmacenes)
            dgvDocumentosGuias.DataSource = Nothing
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                dtv = dtDocumentoGuias.DefaultView
                dgvDocumentosGuias.DataSource = dtv
                dgvDocumentosGuias.AutoResizeColumns()
                dgvDocumentosGuias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                STRorden = dgvDocumentosGuias.Columns(0).Name & "+" & dgvDocumentosGuias.Columns(3).Name & "+" & dgvDocumentosGuias.Columns(5).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                clsGuiaRemisionBl = Nothing
            End If
        Catch ex As Exception
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
        DocumentosGuiaRemision()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosGuiaRemision()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosGuiaRemision()
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim wbusqueda As String = txtFiltro.Text
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub


    Private Sub TipoDocumento()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "ALM_SP_S_WAREHOUSE_TIPO_DOCUMENTO"
        frm.CadenaConsulta = sql
        frm.Titulo = "Tipo de Documentos de Referencias"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtTipoDocRef.Text = frm.Data_Matriz.Rows(0).Item(0)
        End If
        frm.Close()
        txtNumDocRef.Focus()
    End Sub
    Private Sub txtTopoDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDocRef.KeyDown
        If e.KeyCode = Keys.F1 Then
            TipoDocumento()
        End If
    End Sub

    Private Sub txtTopoDocRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDocRef.MouseDoubleClick
        TipoDocumento()
    End Sub

    Private Sub txt_des_tramo_Click(sender As Object, e As EventArgs) Handles txt_des_tramo.Click

    End Sub

    Private Sub txt_des_transportista_Click(sender As Object, e As EventArgs) Handles txt_des_transportista.Click

    End Sub

    Private Sub txt_cod_cli_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_cli.KeyDown
        Ayuda_Cliente()
    End Sub

    Private Sub txt_cod_prove_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_prove.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Proveedor()
        End If
    End Sub

    Private Sub txt_cod_tramo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_tramo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tramos()
        End If
    End Sub

    Private Sub txt_cod_trans_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_trans.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Transporte()
        End If
    End Sub

    Private Sub txtTopoDocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoDocRef.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtNumDocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumDocRef.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_ord_prod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ord_prod.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_prove_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_prove.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_cli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_cli.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_tramo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_tramo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_trans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_trans.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub


    Private Sub AnularGuiasRemision()
        Try
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Dim NumOc As String = ""
            NumOc = dgvDocumentosGuias.Item(5, dgvDocumentosGuias.CurrentRow.Index).Value
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            almacenBL.AnularGuiaRemisionII(Ref_idalamacen, Ref_documentid, Ref_numerodocument, NumOc)
            Dim msj As String = String.Empty
            msj = "Guia de Remision Anulada Correctamente, Nro Documento: " & Ref_numerodocument
            MsgBox(msj, MsgBoxStyle.Information)
            DocumentosGuiaRemision()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Se va a proceder a Anular el Documento" & vbCrLf & "¿Desea continuar?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            AnularGuiasRemision()
        End If
    End Sub

    Private Sub Ayuda_DocumentosPorOrdenCompra()
        Try
            Dim frm As New frmBuscar
            Dim frm_detalles As New FrmDetalles_Ingreso_OrdenCompra
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_PURCHASE_ORDER_DOC"
            frm.CadenaConsulta = sql
            frm.Titulo = "Documentos de Orden de Compra"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtOrdenCompra.Text = frm.Data_Matriz.Rows(0).Item(0).ToString

                '**************
                frm_detalles._numero_requisicion = txtOrdenCompra.Text
                frm_detalles._tipo_requisicion = "OC"
                frm_detalles.Titulo = "DETALLE DE ORDEN DE COMPRA N° " & txtOrdenCompra.Text
                frm_detalles.ShowDialog()
                If frm_detalles._lista_items = String.Empty Then
                    frm_detalles.Close()
                    frm.Close()
                    Exit Sub
                End If
                frm_detalles.Close()
                '**************

                MostrandoOrdenCompras(txtOrdenCompra.Text, frm_detalles._lista_items)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtOrdenCompra_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtOrdenCompra.MouseDoubleClick
        Ayuda_DocumentosPorOrdenCompra()
    End Sub

    Private Sub dtp_fecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtp_fecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub CboTipoTransaccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboTipoTransaccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmb_moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_moneda.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtOrdenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrdenCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub CboAlmacen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboAlmacen.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub


    Private Sub txtOrdenCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrdenCompra.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_DocumentosPorOrdenCompra()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        GenerarGuiaAnalisis()
    End Sub
    Private Sub GenerarGuiaAnalisis()
        Try
            If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub
            Ref_idalamacen = String.Empty
            Ref_documentid = String.Empty
            Ref_numerodocument = String.Empty
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            ' Verificando si posee opcion a Guia de Analisis
            Dim TipoTransaccion As String = dgvDocumentosGuias.Item(2, dgvDocumentosGuias.CurrentRow.Index).Value
            Dim codigoTipoTransaccion As String = dgvDocumentosGuias.Item(6, dgvDocumentosGuias.CurrentRow.Index).Value
            'validacion
            If String.IsNullOrEmpty(TipoTransaccion) Or String.IsNullOrEmpty(codigoTipoTransaccion) Then Exit Sub
            'consulta
            MostrarMovimientoBl = New ClsTransacciones.clsMostrarTiposMovimiento
            MostrarMovimientoBl.Get_TipoTransacciones("I", codigoTipoTransaccion)
            If MostrarMovimientoBl.IS_GUIA_ANALISIS = "S" Then
                clsBusquedaBl = New ClsBuscar
                dtData = New DataTable("VerificandoGuia")
                dtData = clsBusquedaBl.get_VerificarGuiaAnalisis(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
                If dtData.Rows.Count() <> 0 Then
                    If CInt(dtData.Rows(0).Item("Resultado").ToString()) = 0 Then
                        Dim frmga As New FrmGuiaAnalisisCob
                        frmga.idAlmacen = Ref_idalamacen
                        frmga.documentId = Ref_documentid
                        frmga.NumeroDocumento = Ref_numerodocument
                        frmga.ShowDialog()
                        frmga.Close()
                    ElseIf CInt(dtData.Rows(0).Item("Resultado").ToString()) = 1 Then
                        MsgBox("Ya se genero Anteriormente una Guia de Analisis, para este Documento", MsgBoxStyle.Information)
                    End If
                End If
            Else
                MsgBox("EL Documento seleccionado, no permite la generacion de Guia de Analisis.", MsgBoxStyle.Information, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDocumentosGuias_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDocumentosGuias.CellFormatting
        If dgvDocumentosGuias.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvDocumentosGuias.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvDocumentosGuias.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvDocumentosGuias.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvDocumentosGuias.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub DuplicarItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicarItemToolStripMenuItem.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Codigo As Integer = dgvDetalle.CurrentRow.Cells("ITEM").Value
            _item_a_duplicar = Codigo
            Dim cantidad_item As Double = 0
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                cantidad_item = item("SALDO")
            Next

            Dim cantidad As String = String.Empty
            cantidad = InputBox("Digite la cantidad del item a agregar.", "Cantidad nuevo item", "0")
            If cantidad = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Es necesario digitar una cantidad.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                If IsNumeric(cantidad) = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("La cantidad ingresada no es correcta. Verifique!!!", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If CDbl(cantidad) >= cantidad_item Then
                        Me.Cursor = Cursors.Default
                        MsgBox("La cantidad ingresada es mayor o igual a la cantidad del Pedido. Verifique!!!", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

            For Each items As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                dtdetalleArticuloPrincipal.BeginInit()
                items("SALDO") = cantidad_item - CDbl(cantidad)
                dtdetalleArticuloPrincipal.EndInit()
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next

            Dim i As Integer = 0
            For Each items As DataRow In dtdetalleArticuloPrincipal.Select("ITEM>" & Codigo)
                i += 1
                _item_a_duplicar = items("ITEM")
                dtdetalleArticuloPrincipal.BeginInit()
                items("ITEM") = Codigo + i + 1
                dtdetalleArticuloPrincipal.EndInit()
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next

            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = Codigo + 1 'dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("CODIGO") = item("CODIGO")
                row("DESCRIPCION") = item("DESCRIPCION")
                row("UNIDAD") = item("UNIDAD")
                row("LOTE") = item("LOTE")
                row("CANTIDAD") = item("CANTIDAD")
                row("SALDO") = CDbl(cantidad) 'item("CANTIDAD")
                row("NRO_PROTOCOLO") = item("NRO_PROTOCOLO")
                row("NRO_BULTOS") = item("NRO_BULTOS")
                row("MONTO") = item("MONTO")
                row("OPT_ENTREGA") = item("OPT_ENTREGA")
                row("USO") = item("USO")
                row("COSTO") = item("COSTO")
                row("ITEM_ORDEN_COMPRA") = Codigo
                
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next

            dtdetalleArticuloPrincipal.DefaultView.Sort = "ITEM ASC"
            dtdetalleArticuloPrincipal = dtdetalleArticuloPrincipal.DefaultView.ToTable

            dgvDetalle.DataSource = dtdetalleArticuloPrincipal


            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class