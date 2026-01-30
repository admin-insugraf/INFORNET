Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing

Public Class frm_GuiaRemision_tranferencia_Interna_Materia_Prima
    Dim MostrarMovimientoBl As ClsTransacciones.clsMostrarTiposMovimiento
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim clsGuiaRemisionBl As ClsOperaciones.WAREHOUSE_TRANS
    Dim dtTransaccionTipo As DataTable
    Dim dtAlmacen As DataTable
    Dim cmbcell As DataGridViewComboBoxCell
    Dim clsAlmacenCorrelativoBl As ClsTransacciones.clsAlmacenCorrelativo

    Dim NumeracionGuiaRemision As String = String.Empty
    Dim NumeracionNotaSalida As String = String.Empty


    Dim _TIPODOC_NS, _NUMERO_NS, _ALMACEN_NS As String
    Dim TipoNumeracion As String
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDocumentoGuias As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable

    Dim clsAlmacenCabBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenDetBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
    Dim dtCabeceraAlm As DataTable
    Dim dtDetalleAlm As DataTable
    Dim PerteneceGuiaAnalisis As Boolean = False
    Dim dtFtsinDescargoCab As DataTable
    Dim dtFtsinDescargoDet As DataTable

    Dim Modo_consultar As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Dim _DIRECCION As String = String.Empty
    Dim _RUC As String = String.Empty
    Dim _STATUS_GUIA As String = String.Empty
    Dim _ACCOUNT As String = String.Empty

    Dim Fl_close As Boolean = False
    Dim clsBusquedaBl As ClsBuscar

    Dim NumeroLineas As String
    Dim SerieDocumento As String
    Dim edicion As Boolean = False
    Public _TipoTransaccion As String = String.Empty

    Dim dtdetalleBultosPrincipal As DataTable
    Dim TipoArticulo As String = String.Empty
    Private tipoMov As String

    Public Property TipoTransaccion() As String
        Get
            Return _TipoTransaccion
        End Get
        Set(value As String)
            _TipoTransaccion = value
        End Set
    End Property

    Public Property Data_Matriz() As DataTable
        Get
            Return dtdetalleBultosPrincipal
        End Get
        Set(ByVal Value As DataTable)
            dtdetalleBultosPrincipal = Value
        End Set
    End Property

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

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("NRO_PROTOCOLO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NRO_BULTOS", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("MONTO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("OPT_ENTREGA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PROCEDENCIA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PAIS_ORIGEN", Type.GetType("System.String"))
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'dgvDetalle.Columns(0).Width = 50
            dgvDetalle.Columns(0).HeaderText = "Item"
            'dgvDetalle.Columns(1).Width = 70
            dgvDetalle.Columns(1).HeaderText = "Codigo"
            'dgvDetalle.Columns(2).Width = 220
            dgvDetalle.Columns(2).HeaderText = "Articulo"
            ' dgvDetalle.Columns(3).Width = 50
            dgvDetalle.Columns(3).HeaderText = "Unidad"
            'dgvDetalle.Columns(4).Width = 70
            dgvDetalle.Columns(4).HeaderText = "Lote"
            'dgvDetalle.Columns(5).Width = 70
            dgvDetalle.Columns(5).HeaderText = "Cantidad"
            'dgvDetalle.Columns(6).Width = 90
            dgvDetalle.Columns(6).HeaderText = "Protocolo"
            'dgvDetalle.Columns(7).Width = 60
            dgvDetalle.Columns(7).HeaderText = "Bultos"
            'dgvDetalle.Columns(8).Width = 80
            dgvDetalle.Columns(8).HeaderText = "Monto"
            dgvDetalle.Columns(9).Visible = False
            dgvDetalle.Columns(10).Visible = False
            dgvDetalle.Columns(11).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_CX_LT_GuiaRemision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        clsAlmacenBl = New ClsTransacciones.clsAlmacen
        NumerosSerieGuia()
        NumeroLineas = String.Empty
        clsAlmacenBl.Get_NumeroGuiaRemision(cboserieguia.Text)
        NumeroLineas = clsAlmacenBl.NUMBER_LINE
        txt_num_guia.Text = clsAlmacenBl.NUMBER_SERIE
        txt_tc.Text = ClsVarComun.TCVenta
        Cargar_Almacen(CboAlmacen)
        TransaccionesTipos()
        Call Cargar_Moneda()
        Cargar_Almacen(cboAlmacenDestino)
        rbGuia_Transferencia.Checked = False
    End Sub
    Private Sub NumerosSerieGuia()
        Try
            clsTransaccionTipoBl = New LibCobranzas.ClsOperaciones.TRANSACTION_TYPE
            dtTransaccionTipo = New DataTable
            dtTransaccionTipo = clsTransaccionTipoBl.get_NumeroSeriesGuia()
            Dim row As DataRow = dtTransaccionTipo.NewRow()
            'row.Item("CODIGO") = ""
            'row.Item("DESCRIPCION") = "(-SELECCIONE-)"
            'dtTransaccionTipo.Rows.InsertAt(row, 0)
            If dtTransaccionTipo.Rows.Count() <> 0 Then
                cboserieguia.DataSource = dtTransaccionTipo
                cboserieguia.DisplayMember = "DESCRIPCION"
                cboserieguia.ValueMember = "CODIGO"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TransaccionesTipos()
        Try
            clsTransaccionTipoBl = New LibCobranzas.ClsOperaciones.TRANSACTION_TYPE
            dtTransaccionTipo = New DataTable
            dtTransaccionTipo = clsTransaccionTipoBl.get_TransaccionesTipo()
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
            MostrarMovimientoBl.Get_TipoTransacciones("S", CodigoTransaccion)
            'Valorizado
            If MostrarMovimientoBl.IS_CUSTOMER = "N" Then
                txt_cod_cli.Enabled = False
                txt_des_cli.Text = String.Empty
                txt_cod_cli.Text = String.Empty
                txt_cod_cli.BackColor = Drawing.Color.White
                txt_cod_cli.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_CUSTOMER = "S" Then
                txt_cod_cli.Enabled = True
                txt_des_cli.Text = String.Empty
                txt_cod_cli.Text = String.Empty
                txt_cod_cli.BackColor = Drawing.Color.Aquamarine
                txt_cod_cli.ForeColor = Drawing.Color.Black
            End If
            If MostrarMovimientoBl.IS_VENDOR = "N" Then
                txt_cod_prove.Enabled = False
                txt_des_prove.Text = String.Empty
                txt_cod_prove.Text = String.Empty
                txt_cod_prove.BackColor = Drawing.Color.White
                txt_cod_prove.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_VENDOR = "S" Then
                txt_cod_prove.Enabled = True
                txt_cod_prove.Text = String.Empty
                txt_cod_prove.Text = String.Empty
                txt_cod_prove.BackColor = Drawing.Color.Aquamarine
                txt_cod_prove.ForeColor = Drawing.Color.Black
            End If
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
            'almacen Destino
            If MostrarMovimientoBl.IS_WHO = "N" Then
                cboAlmacenDestino.Enabled = False
                cboAlmacenDestino.BackColor = Drawing.Color.White
                cboAlmacenDestino.ForeColor = Drawing.Color.Black

            ElseIf MostrarMovimientoBl.IS_WHO = "S" Then
                cboAlmacenDestino.Enabled = True
                cboAlmacenDestino.BackColor = Drawing.Color.Aquamarine
                cboAlmacenDestino.ForeColor = Drawing.Color.Black
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

    Private Sub Ayuda_NumeroDocumentosReferencia()
        Try
            If CboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un Almacen, para Continuar.", MsgBoxStyle.Information)
                CboAlmacen.Focus()
                Exit Sub
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_DOC_REF"
            frm.CadenaConsulta = sql
            frm.Titulo = "Documentos Pendientes"
            frm._Flag_Filtro = True
            frm.Filtros1 = CboAlmacen.SelectedValue.ToString
            frm.Filtros2 = txtTipoDocRef.Text
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtNumDocRef.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                MostrandoFTsinDescargo(frm.Data_Matriz.Rows(0).Item(0).ToString, frm.Data_Matriz.Rows(0).Item(2).ToString)
            End If
            frm.Close()
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

    Private Sub DevolverTipoGuia()
        If rbGuiaRemision.Checked = True Then
            _STATUS_GUIA = "V"
            _ACCOUNT = ""
        ElseIf rbGuia_ventaFacturar.Checked = True Then
            _STATUS_GUIA = "P"
            _ACCOUNT = ""
        ElseIf rbGuia_Transferencia.Checked = True Then
            _STATUS_GUIA = "P"
            _ACCOUNT = ""
        ElseIf rbGuia_sinDescargo.Checked = True Then
            _STATUS_GUIA = "F"
            _ACCOUNT = "1"
        ElseIf rbGuia_FTsinDescargo.Checked = True Then
            _STATUS_GUIA = "V"
            _ACCOUNT = "2"
        End If
    End Sub


    Private Function GenerarSalidaAlmacen() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE_salida As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_cabBE_ingreso As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

            _TIPODOC_NS = String.Empty
            _NUMERO_NS = String.Empty
            _ALMACEN_NS = String.Empty
            clsAlmacenCorrelativoBl = New ClsTransacciones.clsAlmacenCorrelativo
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(CboAlmacen.SelectedValue.ToString, "S")
            'la parte de almacen
            With alm_cabBE_salida
                .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                _ALMACEN_NS = .WAREHOUSE_ID
                .DOCUMENT_ID = "NS"
                _TIPODOC_NS = .DOCUMENT_ID
                NumeracionNotaSalida = String.Empty
                NumeracionNotaSalida = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                _NUMERO_NS = .NUMBER_DOCUMENT
                .DATE_DOCUMENT = CDate(dtp_fecha.Value).ToShortDateString
                .TYPE_TRANS = "S"
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
                .CURRENCY_TYPE = cmb_moneda.SelectedValue
                .CURRENCY_EXCHANGE = CDbl(txt_tc.Text)
                .STATUS_GUIA = "V"
                .AMOUNT = 0
                .COMMENT = txtComentarios.Text
                .TYPE_GUIA = CboTipoTransaccion.SelectedValue.ToString
                .WAREHOUSE_REF = cboAlmacenDestino.SelectedValue.ToString
                .UPDATE_DATE = Date.Now
                .MOV_OPTION_ID = "Guia de Remision - Transferencia"
            End With

            clsAlmacenCorrelativoBl = New ClsTransacciones.clsAlmacenCorrelativo
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(cboAlmacenDestino.SelectedValue.ToString, "I")
            'la parte de almacen
            With alm_cabBE_ingreso
                .WAREHOUSE_ID = cboAlmacenDestino.SelectedValue.ToString
                .DOCUMENT_ID = "NI"
                .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                .DATE_DOCUMENT = CDate(dtp_fecha.Value).ToShortDateString
                .TYPE_TRANS = "I"
                .TRANS_ID = CboTipoTransaccion.SelectedValue.ToString
                .DOC_ID_REF = "NS"
                .NUM_ID_REF = NumeracionNotaSalida
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .VAT_REGISTRATION = _RUC 'Ruc..
                .ADDR_DLV = _DIRECCION  'Direccion ..
                .VENDOR_ID = txt_cod_prove.Text
                .VENDOR_NAME = txt_des_prove.Text
                .CUSTOMER_ID = txt_cod_cli.Text
                .CUSTOMER_NAME = txt_des_cli.Text
                .SALES_TERM = ""
                .CURRENCY_TYPE = cmb_moneda.SelectedValue
                .CURRENCY_EXCHANGE = CDbl(txt_tc.Text)
                .STATUS_GUIA = "V"
                .AMOUNT = CDbl(0) * -1
                .COMMENT = txtComentarios.Text
                .TYPE_GUIA = CboTipoTransaccion.SelectedValue.ToString
                .WAREHOUSE_REF = CboAlmacen.SelectedValue.ToString
                .UPDATE_DATE = Date.Now
                .MOV_OPTION_ID = "Guia de Remision - Transferencia"
            End With

            'Detalle de la Guia...
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE
                    .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                    .DOCUMENT_ID = "NS"
                    .NUMBER_DOCUMENT = alm_cabBE_salida.NUMBER_DOCUMENT
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_DLV = 0
                    .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                    .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                    .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                    .WAREHOUSE_REF = cboAlmacenDestino.SelectedValue.ToString
                    .ACCOUNT = _ACCOUNT
                End With
                ls_det_alm.Add(alm_detBE)
            Next

            
            'Detalle de la Guia...
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE
                    .WAREHOUSE_ID = cboAlmacenDestino.SelectedValue.ToString
                    .DOCUMENT_ID = "NI"
                    .NUMBER_DOCUMENT = alm_cabBE_ingreso.NUMBER_DOCUMENT
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_DLV = 0
                    .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                    .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                    .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                    .WAREHOUSE_REF = ""
                    .ACCOUNT = _ACCOUNT
                End With
                ls_det_alm.Add(alm_detBE)
            Next

            If almacenBL.GuardarAlmacen_Traslado(alm_cabBE_salida, alm_cabBE_ingreso, ls_det_alm, _TIPODOC_NS, _NUMERO_NS, _ALMACEN_NS) Then
                Dim msj As String = String.Empty
                msj = "Nota de Salida generada Correctamente" & Chr(13) & "Nro Documento: " & alm_cabBE_salida.NUMBER_DOCUMENT
                MsgBox(msj, MsgBoxStyle.Information)

                msj = "Ingreso a Almacen Destino Generado Correctamente" & Chr(13) & "Nro Documento: " & alm_cabBE_ingreso.NUMBER_DOCUMENT
                MsgBox(msj, MsgBoxStyle.Information)
                'Imprimir ingreso a Almacen
                imprimirIngresoAlmacen(CboAlmacen.SelectedValue.ToString, "NS", alm_cabBE_salida.NUMBER_DOCUMENT)
                imprimirIngresoAlmacen(cboAlmacenDestino.SelectedValue.ToString, "NI", alm_cabBE_ingreso.NUMBER_DOCUMENT)
                Me.Cursor = Cursors.Default
                Return True
            Else
                Me.Cursor = Cursors.Default
                Return False
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function GenerarIngresoAlmacen() As Boolean
        Try
            Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

            clsAlmacenCorrelativoBl = New ClsTransacciones.clsAlmacenCorrelativo
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(cboAlmacenDestino.SelectedValue.ToString, "I")
            'la parte de almacen
            With alm_cabBE
                .WAREHOUSE_ID = cboAlmacenDestino.SelectedValue.ToString
                .DOCUMENT_ID = "NI"
                .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                .DATE_DOCUMENT = CDate(dtp_fecha.Value).ToShortDateString
                .TYPE_TRANS = "I"
                .TRANS_ID = CboTipoTransaccion.SelectedValue.ToString
                .DOC_ID_REF = "NS"
                .NUM_ID_REF = NumeracionNotaSalida
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .VAT_REGISTRATION = _RUC 'Ruc..
                .ADDR_DLV = _DIRECCION  'Direccion ..
                .VENDOR_ID = txt_cod_prove.Text
                .VENDOR_NAME = txt_des_prove.Text
                .CUSTOMER_ID = txt_cod_cli.Text
                .CUSTOMER_NAME = txt_des_cli.Text
                .SALES_TERM = ""
                .CURRENCY_TYPE = cmb_moneda.SelectedValue
                .CURRENCY_EXCHANGE = CDbl(txt_tc.Text)
                .STATUS_GUIA = "V"
                .AMOUNT = CDbl(0) * -1
                .COMMENT = txtComentarios.Text
                .TYPE_GUIA = CboTipoTransaccion.SelectedValue.ToString
                .WAREHOUSE_REF = CboAlmacen.SelectedValue.ToString
                .UPDATE_DATE = Date.Now
                .MOV_OPTION_ID = "Guia de Remision - Transferencia"
            End With
            'Detalle de la Guia...
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE
                    .WAREHOUSE_ID = cboAlmacenDestino.SelectedValue.ToString
                    .DOCUMENT_ID = "NI"
                    .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_DLV = 0
                    .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                    .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                    .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                    .WAREHOUSE_REF = ""
                    .ACCOUNT = _ACCOUNT
                End With
                ls_det_alm.Add(alm_detBE)
            Next
            Me.Cursor = Cursors.WaitCursor
            'If almacenBL.GuardarAlmacen(alm_cabBE, ls_det_alm, "I") Then
            '    Dim msj As String = String.Empty
            '    msj = "Ingreso a Almacen Destino Generado Correctamente" & Chr(13) & "Nro Documento: " & alm_cabBE.NUMBER_DOCUMENT
            '    MsgBox(msj, MsgBoxStyle.Information)
            '    imprimirIngresoAlmacen(cboAlmacenDestino.SelectedValue.ToString, "NI", alm_cabBE.NUMBER_DOCUMENT)
            '    Me.Cursor = Cursors.Default
            '    Return True
            'Else
            '    Me.Cursor = Cursors.Default
            '    Return False
            'End If
            '--Actualizando el Estado para Control de Calidad'
            'If cboAlmacenDestino.SelectedValue.ToString = "18" Then
            '    '--Generando el Numero de Analiss
            '    If PerteneceGuiaAnalisis Then
            '        GenerarNumeroAnalisis(cboAlmacenDestino.SelectedValue.ToString(), "NI", alm_cabBE.NUMBER_DOCUMENT)
            '    End If
            '    '--guardando CantidadAsigandaLote
            '    GenerarInsercionLotes(CboAlmacen.SelectedValue.ToString(), "NI", alm_cabBE.NUMBER_DOCUMENT, Date.Today, "I")
            'End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


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
    Private Sub GenerarNumeroAnalisis(ByVal idlamacen As String, ByVal documentId As String, ByVal NumeroDocumento As String)
        Try
            clsBusquedaBl = New ClsBuscar
            clsBusquedaBl.ActualizandoNumeroAnalisis(idlamacen, documentId, NumeroDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GuardarGuiaRemision()
        Try
            Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            'la parte de almacen
            With alm_cabBE
                .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                .DOCUMENT_ID = "GS"
                .NUMBER_DOCUMENT = NumeracionGuiaRemision
                .DATE_DOCUMENT = CDate(dtp_fecha.Value).ToShortDateString
                .TYPE_TRANS = "S"
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
                .CURRENCY_TYPE = cmb_moneda.SelectedValue
                .CURRENCY_EXCHANGE = CDbl(txt_tc.Text)
                .STATUS_GUIA = _STATUS_GUIA
                .AMOUNT = CDbl(0) * -1
                .COMMENT = txtComentarios.Text
                .TYPE_GUIA = CboTipoTransaccion.SelectedValue.ToString
                .WAREHOUSE_REF = cboAlmacenDestino.SelectedValue.ToString
            End With
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE
                    .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                    .DOCUMENT_ID = "GS"
                    .NUMBER_DOCUMENT = NumeracionGuiaRemision
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_DLV = 0
                    .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                    .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                    .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                    .WAREHOUSE_REF = cboAlmacenDestino.SelectedValue.ToString
                    .ACCOUNT = _ACCOUNT
                End With
                ls_det_alm.Add(alm_detBE)
            Next
            Me.Cursor = Cursors.WaitCursor
            almacenBL.Insert(alm_cabBE, ls_det_alm, TipoNumeracion)
            Dim msj As String = String.Empty
            msj = "Guia de Remision generada Correctamente, Nro Documento: " & NumeracionGuiaRemision
            MsgBox(msj, MsgBoxStyle.Information)
            imprimirGuiaRemision(CboAlmacen.SelectedValue.ToString, "GS", NumeracionGuiaRemision)
            Me.Cursor = Cursors.Default
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

    Private Sub imprimirGuiaRemision(ByVal idalamacen As String, ByVal documentid As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("GuiaRemision")
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaRemision(idalamacen, documentid, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Mov_Almacen_TE_PT.rpt", dtImprimir, "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
                If dtImprimir.Rows(0).Item("TRANS_ID1").ToString = "LC" Then
                    dtImprimir = reporteBL.EjecutarReporteTrasladoInterno(idalamacen, documentid, numerodocument)
                    If dtImprimir.Rows.Count() <> 0 Then
                        dtImprimir = reporteBL.EjecutarReporteGuiaRemision(dtImprimir.Rows(0).Item("WAREHOUSE_ID").ToString, dtImprimir.Rows(0).Item("DOCUMENT_ID").ToString, dtImprimir.Rows(0).Item("NUMBER_DOCUMENT").ToString)
                        If dtImprimir.Rows.Count() <> 0 Then
                            crystalBL.Muestra_Reporte("rpt_Mov_Almacen_TE_PT.rpt", dtImprimir, "", "", "@almacen;" & dtImprimir.Rows(0).Item("WAREHOUSE_ID").ToString, "@tipo;" & dtImprimir.Rows(0).Item("DOCUMENT_ID").ToString, "@numero;" & dtImprimir.Rows(0).Item("NUMBER_DOCUMENT").ToString)
                        End If
                    End If
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub imprimirIngresoAlmacen(ByVal idalamacen As String, ByVal documentid As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Me.Cursor = Cursors.WaitCursor
            '--Ingreso Almacen
            dtImprimir = New DataTable("IngresoAlmacen")
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(idalamacen, documentid, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

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
        'Try
        '    Dim frmArticulo As New FrmAsignarArticulo_Transferencia
        '    frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
        '    frmArticulo.ValidacionLotes = DatosLotes()
        '    frmArticulo.ShowDialog()
        '    If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
        '        Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
        '        row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
        '        row("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO").ToString
        '        row("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION").ToString
        '        row("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD").ToString
        '        row("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE").ToString
        '        row("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD").ToString
        '        dtdetalleArticuloPrincipal.Rows.Add(row)
        '        dtdetalleArticuloPrincipal.AcceptChanges()
        '        Fl_close = False
        '    Else
        '        Fl_close = True
        '    End If
        '    frmArticulo.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Try
            tipoMov = "S"
            Dim frmArticulo As New FrmAsignarArticuloInventario
            frmArticulo.Flag_ModoEdicion = False
            frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
            frmArticulo.TipoMov = "S"
            ' frmArticulo.TransaccionTipoArticulo = TipoArticulo
            If tipoMov = "S" Then
                frmArticulo.ValidacionLotes = DatosLotes()
            End If
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then

                If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
                    For Each rows As DataRow In dtdetalleArticuloPrincipal.Select("codigo='" & frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO").ToString & "' and lote='" & frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE").ToString & "' ")
                        MsgBox("Los datos elejidos ya se encuentran adjuntados en la transferencia.", MsgBoxStyle.Information, "Aviso")
                        Fl_close = False
                        Exit Try
                    Next
                End If

                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
                row("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION")
                row("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD")
                row("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
                row("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
                row("NRO_PROTOCOLO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NRO_PROTOCOLO")
                row("NRO_BULTOS") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NRO_BULTOS")
                row("MONTO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("MONTO")
                row("OPT_ENTREGA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("OPT_ENTREGA")
                row("PROCEDENCIA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PROCEDENCIA")
                row("PAIS_ORIGEN") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PAIS_ORIGEN")
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                If frmArticulo.dtDetallesBulto.Rows.Count() > 0 Then
                    If frmArticulo.Flag_ModoEdicion = False Then
                        AgregandoNuevosDatosBultos(frmArticulo.dtDetallesBulto, dtdetalleBultosPrincipal, dgvDetalle.Rows.Count())
                    End If
                End If
                Fl_close = False
            Else
                Fl_close = True
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


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If gbCabecera.Enabled = True Then
                If validaciones() = False Then Exit Sub
                gbCabecera.Enabled = False
            End If
            edicion = False
            AgregandoArticulos()
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            If Fl_close = True Then
                Exit Sub
            Else
                btnAgregar_Click(sender, e)
            End If
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
    Private Sub ModificandoArticulos()

        'Try
        '    If MsgBox("¿Desea modificar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Aviso") = MsgBoxResult.Yes Then
        '        Dim frmArticulo As New FrmAsignarArticulo_Transferencia
        '        frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
        '        Dim lote As String = dgvDetalle.Item(4, dgvDetalle.CurrentRow.Index).Value.ToString
        '        Dim CodigoArticulo As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
        '        Dim Saldo As String = String.Empty
        '        If rbGuia_FTsinDescargo.Checked = True Then
        '            frmArticulo.ft_sin_descargo = True
        '            Saldo = dgvDetalle.Item(6, dgvDetalle.CurrentRow.Index).Value
        '            frmArticulo.Qt_saldo = CDbl(Saldo)
        '        End If
        '        If lote = String.Empty Then
        '            frmArticulo.ValidacionLotes = DatosLotes()
        '        Else
        '            frmArticulo.ValidacionLotes = DatosLotes(lote, CodigoArticulo)
        '        End If
        '        frmArticulo.GenerarColummnaDataTable()
        '        frmArticulo.Flag_Modo_Edicion = True
        '        Dim Codigo As String = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
        '        'Enviando datos seleccioandos a Modificar
        '        For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
        '            Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
        '            row("ITEM") = item("ITEM")
        '            row("CODIGO") = item("CODIGO")
        '            row("DESCRIPCION") = item("DESCRIPCION")
        '            row("UNIDAD") = item("UNIDAD")
        '            row("LOTE") = item("LOTE")
        '            row("CANTIDAD") = item("CANTIDAD")
        '            frmArticulo.dtdetalleArticulo.Rows.Add(row)
        '            frmArticulo.dtdetalleArticulo.AcceptChanges()
        '        Next
        '        frmArticulo.ShowDialog()
        '        If frmArticulo.fl_close = False Then
        '            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
        '                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
        '                    dtdetalleArticuloPrincipal.BeginInit()
        '                    item("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
        '                    item("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION")
        '                    item("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD")
        '                    item("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
        '                    item("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
        '                    dtdetalleArticuloPrincipal.EndInit()
        '                    dtdetalleArticuloPrincipal.AcceptChanges()
        '                Next
        '            End If
        '        End If
        '        frmArticulo.Close()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Try
            gbCabecera.Enabled = False
            Dim frmArticulo As New FrmAsignarArticuloInventario
            tipoMov = "S"
            Dim lote As String = dgvDetalle.Item(4, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim CodigoArticulo As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
            frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
            frmArticulo.TransaccionTipoArticulo = TipoArticulo
            frmArticulo.Flag_ModoEdicion = True
            frmArticulo.Identificador = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            frmArticulo.TipoMov = tipoMov
            frmArticulo.TransaccionTipoArticulo = TipoArticulo
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.BultosGenerarColummnaDataTable()
            frmArticulo.ItemLote = lote
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
                row("PROCEDENCIA") = item("PROCEDENCIA")
                row("PAIS_ORIGEN") = item("PAIS_ORIGEN")
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
                        item("PROCEDENCIA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PROCEDENCIA")
                        item("PAIS_ORIGEN") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PAIS_ORIGEN")
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        edicion = True
        ModificandoArticulos()
    End Sub

    Private Function validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un Almacen, para poder continuar.", MsgBoxStyle.Information)
                CboAlmacen.Focus()
                estado = False
                Exit Try
            End If
            If cboAlmacenDestino.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un Almacen de Destino, para poder continuar.", MsgBoxStyle.Information)
                cboAlmacenDestino.Focus()
                estado = False
                Exit Try
            End If

            If CboAlmacen.SelectedValue = cboAlmacenDestino.SelectedValue Then
                MsgBox("Los Almacenes deben ser Distintos.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If txt_cod_prove.Enabled = True Then
                If txt_cod_prove.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Proveedor.", MsgBoxStyle.Information)
                    txt_cod_prove.Focus()
                    estado = False
                    Exit Try
                End If
            End If
            If txt_cod_cli.Enabled = True Then
                If txt_cod_cli.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Information)
                    estado = False
                    txt_cod_cli.Focus()
                    Exit Try
                End If
            End If
            If txtTipoDocRef.Enabled = True Then
                If txtTipoDocRef.Text = String.Empty Then
                    MsgBox("Debe seleccionar un tipo de documento de Referencia.", MsgBoxStyle.Information)
                    estado = False
                    txtTipoDocRef.Focus()
                    Exit Try
                End If
            End If
            If txtNumDocRef.Enabled = True Then
                If txtNumDocRef.Text = String.Empty Then
                    MsgBox("Debe ingresar un numero de documento de Referencia.", MsgBoxStyle.Information)
                    estado = False
                    txtNumDocRef.Focus()
                    Exit Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If gbOpciones.Enabled = False Then
            MsgBox("Debe seleccionar un Tipo de Transaccion, para poder continuar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
        If validaciones() = False Then Exit Sub
        If dgvDetalle.Rows.Count() = 0 Then
            MsgBox("No hay items en el Detalle.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim cantidad_evaluar As Double
        Dim dt_cantidad As DataTable
        For Each Fila As DataGridViewRow In dgvDetalle.Rows
            cantidad_evaluar = 0
            dt_cantidad = New DataTable
            If Not Fila Is Nothing Then
                dt_cantidad = almacenBL.get_VerificarCantidad_Lote_Analis(CboAlmacen.SelectedValue.ToString, Fila.Cells("CODIGO").Value, Fila.Cells("LOTE").Value, "")
                For Each MiDataRow As DataRow In dt_cantidad.Rows
                    cantidad_evaluar = MiDataRow("CANTIDAD")
                Next
                If cantidad_evaluar < Fila.Cells("CANTIDAD").Value Then
                    MsgBox("La cantidad ingresada es mayor que el stock" & Chr(13) & "Verificar el Item: " + Fila.Cells("ITEM").Value.ToString, MsgBoxStyle.Exclamation, "Sistemas")
                    Exit Sub
                End If
            End If
        Next

        If GenerarSalidaAlmacen() Then
            'If GenerarIngresoAlmacen() Then
            '    dgvDocumentosGuias.Visible = True
            '    DocumentosGuiaRemision()
            '    Botonera_Estado_Cambiar(False)
            '    rbGuiaRemision.Checked = True
            'Else
            '    'Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            '    almacenBL.Elimina_Ingreso_Inventario_Fisico(_ALMACEN_NS, _TIPODOC_NS, _NUMERO_NS)
            'End If

            dgvDocumentosGuias.Visible = True
            DocumentosGuiaRemision()
            Botonera_Estado_Cambiar(False)
            rbGuiaRemision.Checked = True
        Else
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
        dtp_fecha.MaxDate = Date.Today
        dtp_fecha.Value = Date.Today
    End Sub

    Private Sub Nuevo()
        Try
            dgvDocumentosGuias.Visible = False
            GbTransaccion.Enabled = True
            gbCabecera.Enabled = True
            gbdetalle.Enabled = True
            gbOpciones.Enabled = False
            Blank()
            GenerarColummnaDataTable()
            BultosGenerarColummnaDataTable()
            rbGuia_Transferencia.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevoDocumento.Enabled = False
            gbOpcionesBusquedas.Visible = False
            pnlTipoGuiaRemision.Visible = True
            If Modo_consultar = True Then
                btnGrabar.Enabled = False
                pnlTipoGuiaRemision.Enabled = False
            Else
                btnGrabar.Enabled = True
                pnlTipoGuiaRemision.Enabled = True
            End If
            btnEliminarDocum.Enabled = False
            btnAnular.Enabled = False
            btnConsultarDocumento.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            lblCantidad.Visible = False
        Else
            gbOpcionesBusquedas.Visible = True
            pnlTipoGuiaRemision.Visible = False
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
        cboAlmacenDestino.SelectedIndex = 0
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvDocumentosGuias.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        rbGuiaRemision.Checked = True
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub
        Dim Ref_idalamacen As String = String.Empty
        Dim Ref_documentid As String = String.Empty
        Dim Ref_numerodocument As String = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        imprimirGuiaRemision(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
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

            dgvDetalle.Columns(0).Width = 60
            dgvDetalle.Columns(1).Width = 80
            dgvDetalle.Columns(2).Width = 400
            dgvDetalle.Columns(3).Width = 80
            dgvDetalle.Columns(4).Width = 100
            dgvDetalle.Columns(5).Width = 100
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoFTsinDescargo(ByVal DOCUMENT_ID As String, ByVal NUMBER_DOCUMENT As String)
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtFtsinDescargoCab = New DataTable
            dtFtsinDescargoDet = New DataTable
            dtFtsinDescargoCab = clsAlmacenCabBl.get_GuiaFtsinDescargoCabecera(DOCUMENT_ID, NUMBER_DOCUMENT)
            _RUC = String.Empty
            _DIRECCION = String.Empty
            If dtFtsinDescargoCab.Rows.Count() <> 0 Then
                '---Mostrando Datos de Cabecera
                'CboTipoTransaccion.SelectedValue = dtCabeceraAlm.Rows(0).Item("TRANS_ID").ToString
                CboAlmacen.SelectedValue = dtFtsinDescargoCab.Rows(0).Item("WAREHOUSE_ID").ToString
                txt_cod_prove.Text = dtFtsinDescargoCab.Rows(0).Item("VENDOR_ID").ToString
                txt_des_prove.Text = dtFtsinDescargoCab.Rows(0).Item("VENDOR_NAME").ToString
                txt_cod_cli.Text = dtFtsinDescargoCab.Rows(0).Item("CUSTOMER_ID").ToString
                txt_des_cli.Text = dtFtsinDescargoCab.Rows(0).Item("CUSTOMER_NAME").ToString
                _RUC = dtFtsinDescargoCab.Rows(0).Item("VAT_REGISTRATION").ToString
                _DIRECCION = dtFtsinDescargoCab.Rows(0).Item("ADDR_DLV").ToString
                '---Mostrando Datos de Detalle
                '  GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_GuiaFtsinDescargoDetalle(DOCUMENT_ID, NUMBER_DOCUMENT)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    dgvDetalle.Columns(2).Width = 300
                    dgvDetalle.Columns(6).Visible = True
                    dgvDetalle.Columns(6).DefaultCellStyle.Format = "##,##0.00"
                    gbOpciones.Enabled = True
                    ActualizandoCorrelativoItem()
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
            Me.Cursor = Cursors.WaitCursor
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
                    txt_cod_cli.Text = dtCabeceraAlm.Rows(i).Item("CUSTOMER_ID").ToString
                    txt_des_cli.Text = dtCabeceraAlm.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtComentarios.Text = dtCabeceraAlm.Rows(i).Item("COMMENT").ToString
                    cboAlmacenDestino.SelectedValue = dtCabeceraAlm.Rows(i).Item("WAREHOUSE_REF").ToString

                    Select Case dtCabeceraAlm.Rows(i).Item("TRANS_ID").ToString
                        Case "GV"
                            rbGuia_ventaFacturar.Checked = True
                        Case "TD"
                            rbGuia_Transferencia.Checked = True
                        Case "GF"
                            rbGuia_sinDescargo.Checked = True
                        Case "SV"
                            rbGuia_FTsinDescargo.Checked = True
                        Case Else
                            rbGuiaRemision.Checked = True
                    End Select

                Next
                '---Mostrando datos del Detalle
                dtDetalleAlm = clsAlmacenDetBl.get_DetalleAlmacen(alm_, doc_, num_)
                configurarGrilla()
                dgvDetalle.Rows.Clear()
                If dtDetalleAlm.Rows.Count() <> 0 Then
                    For j As Integer = 0 To dtDetalleAlm.Rows.Count() - 1
                        dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                           dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, CDbl(dtDetalleAlm.Rows(j).Item("QTY").ToString))
                    Next
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnConsultarDocumento_Click(sender As Object, e As EventArgs) Handles btnConsultarDocumento.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub
        dtp_fecha.MaxDate = "31/12/9998"
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
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            almacenBL.EliminarGuiaRemision(Ref_idalamacen, Ref_documentid, Ref_numerodocument, LibComunVar.ClsVarComun.USUARIO)
            Dim msj As String = String.Empty
            msj = "Guia de Remision Eliminada Correctamente, Nro Documento: " & Ref_numerodocument
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            DocumentosGuiaRemision()
        Catch ex As Exception
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
            dtDocumentoGuias = clsGuiaRemisionBl.get_DatosGeneralesGuiaTransferencia_Materia_Prima(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                                    cboopcionesBusqueda.SelectedIndex, "S", "NS", LibComunVar.ClsVarComun.AccesoAlmacenes)
            dgvDocumentosGuias.DataSource = Nothing
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                dtv = dtDocumentoGuias.DefaultView
                dgvDocumentosGuias.DataSource = dtv
                dgvDocumentosGuias.AutoResizeColumns()
                dgvDocumentosGuias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'dgvDocumentosGuias.Columns(0).Width = 70
                'dgvDocumentosGuias.Columns(1).Width = 160
                'dgvDocumentosGuias.Columns(2).Width = 50
                'dgvDocumentosGuias.Columns(6).Width = 60
                'dgvDocumentosGuias.Columns(7).Width = 150
                STRorden = dgvDocumentosGuias.Columns(0).Name & "+" & dgvDocumentosGuias.Columns(1).Name & "+" & dgvDocumentosGuias.Columns(2).Name & "+" & dgvDocumentosGuias.Columns(3).Name
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

    Private Sub rbGuiaRemision_CheckedChanged(sender As Object, e As EventArgs) Handles rbGuiaRemision.CheckedChanged
        If Modo_consultar = True Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rbGuiaRemision.Checked Then
                CboTipoTransaccion.Enabled = True
                CboTipoTransaccion.SelectedIndex = 0
                CboAlmacen.SelectedIndex = 0
                cboAlmacenDestino.SelectedIndex = 0
                Blank()
                GenerarColummnaDataTable()
            End If
        End If
    End Sub

    Private Sub rbGuia_ventaFacturar_CheckedChanged(sender As Object, e As EventArgs) Handles rbGuia_ventaFacturar.CheckedChanged
        If Modo_consultar = True Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rbGuia_ventaFacturar.Checked Then
                CboTipoTransaccion.SelectedValue = "GV"
                CboTipoTransaccion.Enabled = False
                Blank()
                GenerarColummnaDataTable()
            End If
        End If

    End Sub

    Private Sub rbGuia_Transferencia_CheckedChanged(sender As Object, e As EventArgs) Handles rbGuia_Transferencia.CheckedChanged
        If Modo_consultar = True Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rbGuia_Transferencia.Checked Then
                CboTipoTransaccion.SelectedValue = TipoTransaccion
                CboTipoTransaccion.Enabled = False
                cboAlmacenDestino.Enabled = True
                Blank()
                GenerarColummnaDataTable()
            Else
                cboAlmacenDestino.SelectedIndex = 0
                cboAlmacenDestino.Enabled = False
            End If
        End If
    End Sub

    Private Sub rbGuia_sinDescargo_CheckedChanged(sender As Object, e As EventArgs) Handles rbGuia_sinDescargo.CheckedChanged
        If Modo_consultar = True Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rbGuia_sinDescargo.Checked Then
                CboTipoTransaccion.SelectedValue = "GF"
                CboTipoTransaccion.Enabled = False
                Blank()
                GenerarColummnaDataTable()
            End If
        End If
    End Sub

    Private Sub rbGuia_FTsinDescargo_CheckedChanged(sender As Object, e As EventArgs) Handles rbGuia_FTsinDescargo.CheckedChanged
        If Modo_consultar = True Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rbGuia_FTsinDescargo.Checked Then
                CboTipoTransaccion.SelectedValue = "SV"
                CboTipoTransaccion.Enabled = False
                btnAgregar.Enabled = False
                Blank()
                GenerarColummnaDataTable()
                dgvDetalle.Columns(2).Width = 300
                dgvDetalle.Columns(6).Visible = True
            Else
                btnAgregar.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtNumDocRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtNumDocRef.MouseDoubleClick
        If rbGuia_FTsinDescargo.Checked = True Then
            If txtTipoDocRef.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Information)
            End If
            Ayuda_NumeroDocumentosReferencia()
        End If

        If txtTipoDocRef.Text = "PE" Then
            Try
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "ALM_SP_S_LISTA_PARTE_ENTREGA"
                frm.CadenaConsulta = sql
                frm.Titulo = "Lista de Partes de Entrega"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtNumDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString

                    clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                    clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE

                    dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Parte_Entrega_Traslado_MP(CInt(txtNumDocRef.Text))

                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en este Documento.", MsgBoxStyle.Information)
                        GenerarColummnaDataTable()
                    End If

                End If
                frm.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If txtTipoDocRef.Text = "OP" Then
            Try
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "ALM_SP_S_PRODUCCION_OP_PRODUCTOS_LISTA_OPS"
                frm.CadenaConsulta = sql
                frm.Titulo = "Lista de Ordenes de Producción"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    Dim _ITEM As Integer
                    txtNumDocRef.Text = frm.Data_Matriz.Rows(0).Item("N.OP").ToString
                    _ITEM = frm.Data_Matriz.Rows(0).Item("ITEM").ToString

                    clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                    clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE

                    dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Orden_Produccion_Traslado_MP(CInt(txtNumDocRef.Text), _ITEM)

                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en este Documento.", MsgBoxStyle.Information)
                        GenerarColummnaDataTable()
                    End If

                End If
                frm.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Sub AnularGuiasRemision()
        Try
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            almacenBL.AnularGuiaRemision(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
            Dim msj As String = String.Empty
            msj = "Documento anulado correctamente, Nro Documento: " & Ref_numerodocument
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

    Private Sub dtp_fecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtp_fecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_num_guia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num_guia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub CboTipoTransaccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboTipoTransaccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmb_moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_moneda.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub CboAlmacen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboAlmacen.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboAlmacenDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAlmacenDestino.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.Close()
    End Sub

    Private Sub dtp_fecha_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha.ValueChanged
        If Modo_consultar = False Then
            If dtp_fecha.Value <> Date.Now Then
                dtp_fecha.MaxDate = Date.Now
            End If
        End If
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
End Class