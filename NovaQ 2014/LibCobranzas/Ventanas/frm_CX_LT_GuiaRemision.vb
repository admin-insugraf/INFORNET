Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing
Imports System.Collections.Specialized
Imports LibBillService.Process
Imports System.IO

Public Class frm_CX_LT_GuiaRemision
    Dim MostrarMovimientoBl As ClsTransacciones.clsMostrarTiposMovimiento
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim clsGuiaRemisionBl As ClsOperaciones.WAREHOUSE_TRANS
    Dim dtTransaccionTipo As DataTable
    Dim dtAlmacen As DataTable
    Dim cmbcell As DataGridViewComboBoxCell
    Dim NumeracionGuiaRemision As String
    Dim TipoNumeracion As String
    Dim almacenBL As ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen
    Dim STRordenDevol As String = String.Empty

    Dim Flag_Verificar As Boolean = False
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDocumentoGuias As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable

    Dim clsAlmacenCabBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenDetBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
    Dim dtCabeceraAlm As New DataTable
    Dim dtDetalleAlm As DataTable

    Dim dtFtsinDescargoCab As DataTable
    Dim dtFtsinDescargoDet As DataTable
    Dim dtDetalleFact As DataTable

    Dim Modo_consultar As Boolean = False
    Dim Modo_editar As Boolean = False
    Dim dtv As DataView
    Dim dtv2 As DataView
    Dim STRorden As String = String.Empty
    Dim STRordenPedido As String = String.Empty

    Dim _DIRECCION As String = String.Empty
    Dim _RUC As String = String.Empty
    Dim _STATUS_GUIA As String = String.Empty
    Dim _ACCOUNT As String = String.Empty
    Dim _MOV_OPTION_ID As String = String.Empty
    Dim Fl_close As Boolean = False

    Dim NumeroLineas As String
    Dim ref_fecha_doc As String
    Dim SerieDocumento As String
    Dim edicion As Boolean = False

    Dim Ref_idalamacen As String = String.Empty
    Dim Ref_documentid As String = String.Empty
    Dim Ref_numerodocument As String = String.Empty
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Private mySetting As NameValueCollection


    Public Sub GenerarColummnaDataTable()
        dtdetalleArticuloPrincipal = New DataTable
        dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
        dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
        dtdetalleArticuloPrincipal.Columns.Add("SALDO", Type.GetType("System.Double"))
        dtdetalleArticuloPrincipal.Columns.Add("PRECIO", Type.GetType("System.Double"))
        dtdetalleArticuloPrincipal.Columns.Add("OBSERVACIONES", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("ITEM_GUIA_VENTA", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("NUM_GUIA_VENTA", Type.GetType("System.String"))
        dgvDetalle.DataSource = Nothing
        dgvDetalle.DataSource = dtdetalleArticuloPrincipal
        dgvDetalle.Columns(0).Width = 60
        dgvDetalle.Columns(1).Width = 100
        dgvDetalle.Columns(2).Width = 400
        dgvDetalle.Columns(3).Width = 100
        dgvDetalle.Columns(4).Width = 100
        dgvDetalle.Columns(5).Width = 100
        'dgvDetalle.Columns(6).Width = 100
        dgvDetalle.Columns(6).Visible = False
        dgvDetalle.Columns(7).Visible = False
        dgvDetalle.Columns(8).Width = 150
        dgvDetalle.Columns("ITEM_GUIA_VENTA").Width = 100
        dgvDetalle.Columns("NUM_GUIA_VENTA").Width = 100
        dgvDetalle.Columns("ITEM_GUIA_VENTA").HeaderText = "Item Pedido"
        dgvDetalle.Columns("NUM_GUIA_VENTA").HeaderText = "N° Pedido"
    End Sub

    Private Function NIVEL_ACCESO() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
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

    Private Function NIVEL_ACCESO_FACTURACION() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("COD_PERFIL").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("COD_PERFIL").ToString = "0000000007" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("COD_PERFIL").ToString <> "0000000007" Then
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


    Private Sub frm_CX_LT_GuiaRemision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        'btn_modificar.Visible = NIVEL_ACCESO_FACTURACION()
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        clsAlmacenBl = New ClsTransacciones.clsAlmacen
        NumerosSerieGuia()
        NumeroLineas = String.Empty
        clsAlmacenBl.Get_NumeroGuiaRemision(cboserieguia.Text)
        NumeroLineas = clsAlmacenBl.NUMBER_LINE
        txt_num_guia.Text = clsAlmacenBl.NUMBER_SERIE
        'txt_tc.Text = ClsVarComun.TCVenta
        Cargar_Almacen(CboAlmacen)
        TransaccionesTipos()
        'Call Cargar_Moneda()
        Cargar_Almacen(cboAlmacenDestino)
        Cargar_Motivos_Traslado(cbo_motivo_traslado)
        gbOpciones.Enabled = True
    End Sub
    Private Sub Cargar_Motivos_Traslado(ByVal Combobox As ComboBox)
        Dim almacenBL As New ClsOperaciones.WAREHOUSE
        dtAlmacen = New DataTable
        dtAlmacen = almacenBL.get_Motivo_Traslado()
        Combobox.DataSource = dtAlmacen
        Combobox.DisplayMember = "DESCRIPCION"
        Combobox.ValueMember = "CODIGO"

        almacenBL = Nothing
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
                If CboAlmacen.SelectedValue = MostrarMovimientoBl.WHO_ID Then
                    CboAlmacen.Enabled = False
                    CboAlmacen.SelectedValue = MostrarMovimientoBl.WHO_ID
                    CboAlmacen.BackColor = Drawing.Color.White
                    CboAlmacen.ForeColor = Drawing.Color.Black
                Else
                    CboAlmacen.SelectedIndex = 0
                    CboAlmacen.Enabled = False
                    CboAlmacen.BackColor = Drawing.Color.White
                    CboAlmacen.ForeColor = Drawing.Color.Black
                    MsgBox("Para este Tipo de Transaccion, usted no tiene Acceso.", MsgBoxStyle.Information)
                End If
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
            'Orden de COMPRA 

            If MostrarMovimientoBl.IS_ORDER_PURCHASE = "N" Then
                txtorderCompra.Enabled = False
                txtorderCompra.Text = String.Empty
                txtorderCompra.BackColor = Drawing.Color.White
                txtorderCompra.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_ORDER_PURCHASE = "S" Then
                txtorderCompra.Enabled = True
                txtorderCompra.Text = String.Empty
                txtorderCompra.BackColor = Drawing.Color.Aquamarine
                txtorderCompra.ForeColor = Drawing.Color.Black
            End If

            'TipoArticulo = String.Empty
            'TipoArticulo = MostrarMovimientoBl.WHO_ID_PART_TYPE
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

    Private Sub Ayuda_NumeroDocumentosReferencia_Devolucion()
        Try
            If CboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un Almacen, para Continuar.", MsgBoxStyle.Information)
                CboAlmacen.Focus()
                Exit Sub
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_DOCUMENTOS_DEVOLUCIONES_CANJES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Devoluciones Pendientes por Canje"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                pnl_devoluciones.Visible = True
                dgv_detalle_dev.DataSource = Nothing
                gbCabecera.Enabled = False
                txt_busqueda_dev.Text = ""
                gbOpciones.Enabled = False
                GbTransaccion.Enabled = False
                gbTipoGuia.Enabled = False

                txtNumDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                'MostrandoDatos_Devolucion(frm.Data_Matriz.Rows(0).Item(0).ToString, frm.Data_Matriz.Rows(0).Item(1).ToString)
                Motrando_detalles_devolucion(frm.Data_Matriz.Rows(0).Item(0).ToString, frm.Data_Matriz.Rows(0).Item(1).ToString, "")
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

    Private Sub Ayuda_Dir_Entrega_Cliente(ByVal _cod_cliente As String)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SP_S_DIRECCION_ENTREGA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = _cod_cliente
            frm.Titulo = "Dir. Entrega Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_dir_entrega.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lbl_dir_entrega.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
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
            txtComentarios.Select()
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
            'txt_cod_chofer.Text = ""
            'txt_des_chofer.Text = ""
            'txt_dir_chofer.Text = dt_tmp.Rows(0)("ADDR").ToString
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
            _MOV_OPTION_ID = rbGuiaRemision.Text
        ElseIf rbGuia_ventaFacturar.Checked = True Or rb_facturar_pedido.Checked = True Then
            _STATUS_GUIA = "P"
            _ACCOUNT = ""
            _MOV_OPTION_ID = rbGuia_ventaFacturar.Text
        ElseIf rbGuia_Transferencia.Checked = True Then
            _STATUS_GUIA = "P"
            _ACCOUNT = ""
            _MOV_OPTION_ID = rbGuia_Transferencia.Text
        ElseIf rbGuia_sinDescargo.Checked = True Then
            _STATUS_GUIA = "F"
            _ACCOUNT = "1"
            _MOV_OPTION_ID = rbGuia_sinDescargo.Text
        ElseIf rbGuia_FTsinDescargo.Checked = True Then
            _STATUS_GUIA = "V"
            _ACCOUNT = "2"
            _MOV_OPTION_ID = rbGuia_FTsinDescargo.Text
        ElseIf rbGuia_VF_RM.Checked = True Then
            _STATUS_GUIA = "P"
            _ACCOUNT = ""
            _MOV_OPTION_ID = rbGuia_VF_RM.Text
        ElseIf rbGuia_Devolucion.Checked = True Then
            _STATUS_GUIA = "V"
            _ACCOUNT = ""
            _MOV_OPTION_ID = rbGuia_Devolucion.Text
        End If
    End Sub

    Private Function GuardarGuiaRemision() As Boolean
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
                .ADDR_DLV = lbl_dir_entrega.Text '_DIRECCION  'Direccion ..
                .VENDOR_ID = txt_cod_prove.Text
                .VENDOR_NAME = txt_des_prove.Text
                .CUSTOMER_ID = txt_cod_cli.Text
                .CUSTOMER_NAME = txt_des_cli.Text
                .SALES_TERM = ""
                '.CURRENCY_TYPE = cmb_moneda.SelectedValue
                '.CURRENCY_EXCHANGE = CDbl(txt_tc.Text)
                .CURRENCY_TYPE = "MN"
                .CURRENCY_EXCHANGE = 1.0
                .STATUS_GUIA = _STATUS_GUIA
                .AMOUNT = CDbl(0) * -1
                .COMMENT = txtComentarios.Text
                .TYPE_GUIA = CboTipoTransaccion.SelectedValue.ToString
                .UPDATE_DATE = Date.Now
                .MOV_OPTION_ID = _MOV_OPTION_ID
                If rbunalinea.Checked = True Then
                    .INTERFACEE = 0
                ElseIf rbVariaslineas.Checked = True Then
                    .INTERFACEE = 1
                End If
                .NUMBER_PURCHASE = txtorderCompra.Text
                .SALES_ID = txt_cod_vendedor.Text.Trim
                .TRAMA_ID = txt_cod_tramo.Text.Trim
                .CARRIER_ID = txt_cod_trans.Text.Trim
                .CARRIER_NAME = txt_des_transportista.Text.Trim
                .SALES_ID = txt_cod_vendedor.Text.Trim
                .VEHICULO_ID = txt_cod_vehiculo.Text.Trim
                .EMPTRA_ID = txt_cod_empresa_trans.Text.Trim
                .NUMERO_ENTREGA = txt_numero_entrega.Text.Trim
                .FECHA_TRASLADO = dtp_fecha_traslado.Value.ToString("dd/MM/yyyy")
                .MODALIDAD_TRANSPORTE = IIf(rdb_trans_privado.Checked, rdb_trans_privado.Text, rdb_trans_publico.Text)
                .MOTIVO_TRASLADO = cbo_motivo_traslado.SelectedValue.ToString
                .NUMBER_ORDER = txt_numero_pedido.Text

                .UBIGEO_PARTIDA = txt_cod_dir_partida.Text
                .DIRECCION_PARTIDA = lbl_desc_dir_partida.Text
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
                    .UNIT_PRICE = dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO").ToString
                    .OBSERVACIONES = dtdetalleArticuloPrincipal.Rows(i).Item("OBSERVACIONES").ToString
                    .ITEM_GUIA_VENTA = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_GUIA_VENTA").ToString
                    .NUM_GUIA_VENTA = dtdetalleArticuloPrincipal.Rows(i).Item("NUM_GUIA_VENTA").ToString
                End With
                ls_det_alm.Add(alm_detBE)
            Next
            Me.Cursor = Cursors.WaitCursor
            If almacenBL.Guardar_All_Guias_Edicion(alm_cabBE, ls_det_alm, TipoNumeracion, IIf(Modo_editar = True, True, False), Ref_idalamacen, Ref_documentid, Ref_numerodocument, IIf(rbGuia_Devolucion.Checked, True, False)) Then
                'Dim msj As String = String.Empty
                'msj = "Guia de Remisión generada Correctamente." & Chr(13) & "Nro Documento: " & NumeracionGuiaRemision
                'MsgBox(msj, MsgBoxStyle.Information)
                'imprimirGuiaRemision(CboAlmacen.SelectedValue.ToString, "GS", NumeracionGuiaRemision)
                'Me.Cursor = Cursors.Default
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

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
            dtImprimir = New DataTable("Almacen_tipos_Guia_remision")

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaRemision(idalamacen, documentid, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                'crystalBL.Muestra_Reporte("rpt_Mov_Almacen_tipos_Guia_remision.rpt", dtImprimir, "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
                crystalBL.Muestra_Reporte("rpt_Impresion_Factura_Guia_Remision.rpt", dtImprimir, "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function CodigoNumeracionGuiaRemision() As Boolean
        Dim estado As Boolean = True
        Try
            Dim frmTipoNum As New FrmTipoNumeracion
            frmTipoNum.Numero_Serie = cboserieguia.Text
            frmTipoNum.Almacen = CboAlmacen.SelectedValue.ToString
            If Modo_editar = True Then
                frmTipoNum.Modo_edicion = True
                frmTipoNum.Numero_edicion = Ref_numerodocument
            End If
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

    'Private Sub btn_Grabar_Click(sender As Object, e As EventArgs)
    '    If CodigoNumeracionGuiaRemision() = False Then
    '        MsgBox("Es necesario una Numeracion para la Guia Remision", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If
    '    GuardarGuiaRemision()
    'End Sub

    Private Sub cmbTipoTransaccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoTransaccion.SelectedIndexChanged
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If CboTipoTransaccion.SelectedIndex = 0 Then
                gbCabecera.Enabled = False
                gbdetalle.Enabled = False
                ' gbOpciones.Enabled = False
            Else
                gbCabecera.Enabled = True
                gbdetalle.Enabled = True
                ' gbOpciones.Enabled = True
                MostrandoTipoTransacciones()
            End If
        End If
    End Sub

    'Private Function DatosLotes(Optional ByVal Lote As String = "", Optional ByVal CodigoPart As String = "") As String
    '    Dim Cadena As String = String.Empty
    '    Try
    '        Dim listaLot As New List(Of String)
    '        Dim cadena_lote As String = String.Empty
    '        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
    '            If edicion = True Then
    '                If dtdetalleArticuloPrincipal.Rows.Count() = 1 Then
    '                    Exit Try
    '                End If
    '            End If
    '            If Lote = String.Empty Then
    '                For i As Integer = 0 To dgvDetalle.Rows.Count() - 1
    '                    Dim lotes As String = String.Empty
    '                    lotes = dgvDetalle.Item(4, i).Value
    '                    If listaLot.Contains(lotes) = False Then
    '                        listaLot.Add(lotes)
    '                    End If
    '                Next
    '                For j As Integer = 0 To listaLot.Count() - 1
    '                    cadena_lote += "'" & listaLot(j) & "',"
    '                Next
    '                Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
    '            Else
    '                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("CODIGO='" & CodigoPart & "' and LOTE NOT IN ('" & Lote & "')")
    '                    Dim lotes As String = String.Empty
    '                    lotes = item("LOTE")
    '                    If listaLot.Contains(lotes) = False Then
    '                        listaLot.Add(lotes)
    '                    End If
    '                Next
    '                If listaLot.Count() <> 0 Then
    '                    For j As Integer = 0 To listaLot.Count() - 1
    '                        cadena_lote += "'" & listaLot(j) & "',"
    '                    Next
    '                    Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Return Cadena
    'End Function

    Public Structure StructuraPart
        Dim Codigo As String
        Dim Lote As String
        Dim Cantidad As Double
    End Structure

    Dim ListaDatosArticulo As New List(Of StructuraPart)
    Dim ListaCompleta As New List(Of StructuraPart)

    Private Function DatosLotes() As List(Of StructuraPart)
        Dim Cadena As String = String.Empty
        Try
            Dim cadena_lote As String = String.Empty
            ListaDatosArticulo = New List(Of StructuraPart)
            ListaCompleta = New List(Of StructuraPart)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                For i As Integer = 0 To dgvDetalle.Rows.Count() - 1
                    Dim Str As New StructuraPart
                    Str.Codigo = dgvDetalle.Item(1, i).Value
                    Str.Lote = dgvDetalle.Item(4, i).Value
                    If ListaDatosArticulo.Contains(Str) = False Then
                        ListaDatosArticulo.Add(Str)
                    End If
                Next
                For Each item As StructuraPart In ListaDatosArticulo
                    Dim Str As New StructuraPart
                    Str.Codigo = item.Codigo
                    Str.Cantidad = dtdetalleArticuloPrincipal.Compute("sum(CANTIDAD)", "CODIGO='" & item.Codigo & "' and LOTE = '" & item.Lote & "'")
                    Str.Lote = item.Lote
                    ListaCompleta.Add(Str)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ListaCompleta
    End Function

    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticulo
            frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
            frmArticulo.NumeroSerie = cboserieguia.Text
            frmArticulo.GenerarColummnValidacionLotesGenerales()
            frmArticulo.ValidacionLotes = DatosLotes()
            If rbGuia_sinDescargo.Checked = True Then frmArticulo.Sin_Descargo = True
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO").ToString
                row("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION").ToString
                row("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD").ToString
                row("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE").ToString
                row("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD").ToString
                row("PRECIO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRECIO").ToString
                row("OBSERVACIONES") = frmArticulo.dtdetalleArticulo.Rows(0).Item("OBSERVACIONES").ToString
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                Fl_close = False
            Else
                Fl_close = True
            End If
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DesabilitarNuevoDocumento(ByVal Opcion As Boolean)
        GbTransaccion.Enabled = Opcion
        gbCabecera.Enabled = Opcion
        pnlTipoGuiaRemision.Enabled = Opcion
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validaciones() = False Then Exit Sub

            If gbCabecera.Enabled = True Then
                DesabilitarNuevoDocumento(False)
                If FechaFacturacion_Mes_anterior(dtp_fecha.Value.Month, dtp_fecha.Value.Year) = False Then
                    btnCancelar_Click(sender, e)
                    Exit Sub
                Else
                    If FechaFacturacion(dtp_fecha.Value.Month + 1, dtp_fecha.Value.Year) = False Then
                        btnCancelar_Click(sender, e)
                        Exit Sub
                    End If
                End If
            End If
            If dgvDetalle.Rows.Count() = NumeroLineas Then
                MsgBox("Ya alcanzo el Numero maximo de Lineas permitido para este tipo de Documento.", MsgBoxStyle.Information)
                Exit Sub
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
        lista.Sort()
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
                'ActualizandoCorrelativoItem()
                RehacerSecuencia()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
    End Sub
    Private Sub ModificandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticulo
            frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
            frmArticulo.NumeroSerie = cboserieguia.Text
            Dim lote As String = dgvDetalle.Item(4, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim CodigoArticulo As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
            Dim Saldo As String = String.Empty
            If rbGuia_FTsinDescargo.Checked = True Or rbGuia_Devolucion.Checked = True Then
                frmArticulo.ft_sin_descargo = True
                Saldo = dgvDetalle.Item(6, dgvDetalle.CurrentRow.Index).Value
                frmArticulo.Qt_saldo = CDbl(Saldo)
            End If
            If rbGuia_sinDescargo.Checked = True Then frmArticulo.Sin_Descargo = True
            'frmArticulo.ItemLote = lote
            'If lote = String.Empty Then
            '    frmArticulo.ValidacionLotes = DatosLotes()
            'Else
            '    frmArticulo.ValidacionLotes = DatosLotes(lote, CodigoArticulo)
            'End If
            Dim _ARTICULO As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
            Dim _CANTIDAD As String = dgvDetalle.Item(5, dgvDetalle.CurrentRow.Index).Value
            Dim _LOTE As String = dgvDetalle.Item(4, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.GenerarColummnValidacionLotesGenerales()
            frmArticulo.ValidacionLotes = DatosLotes()
            frmArticulo._ARTICULO = _ARTICULO
            frmArticulo._LOTE = _LOTE
            frmArticulo._CANTIDAD = _CANTIDAD
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.Flag_Modo_Edicion = True
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
                row("PRECIO") = item("PRECIO")
                row("OBSERVACIONES") = item("OBSERVACIONES")
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                frmArticulo.dtdetalleArticulo.AcceptChanges()
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
                        item("PRECIO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PRECIO")
                        item("OBSERVACIONES") = frmArticulo.dtdetalleArticulo.Rows(0).Item("OBSERVACIONES")
                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                    Next
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
        If rbGuia_FTsinDescargo.Checked = True Or rbGuia_Devolucion.Checked = True Then
            DesabilitarNuevoDocumento(False)
        End If
        If gbCabecera.Enabled = True Then
            If validaciones() = False Then Exit Sub
            gbCabecera.Enabled = False
        End If
        ModificandoArticulos()
    End Sub

    Private Function validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un Almacen, para poder continuar.", MsgBoxStyle.Exclamation)
                estado = False
                Exit Try
            End If
            If txt_cod_prove.Enabled = True Then
                If txt_cod_prove.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Proveedor.", MsgBoxStyle.Exclamation)
                    estado = False
                    Exit Try
                End If
            End If
            If txt_cod_cli.Enabled = True Then
                If txt_cod_cli.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Exclamation)
                    estado = False
                    Exit Try
                End If
            End If
            If txtTipoDocRef.Enabled = True Then
                If txtTipoDocRef.Text = String.Empty Then
                    MsgBox("Debe seleccionar un tipo de documento de Referencia.", MsgBoxStyle.Exclamation)
                    estado = False
                    Exit Try
                End If
            End If
            If txtNumDocRef.Enabled = True Then
                If txtNumDocRef.Text = String.Empty Then
                    MsgBox("Debe ingresar un numero de documento de Referencia.", MsgBoxStyle.Exclamation)
                    estado = False
                    Exit Try
                End If
            End If

            If dtp_fecha_traslado.Value.ToString("dd/MM/yyyy") < dtp_fecha.Value.ToString("dd/MM/yyyy") Then
                MsgBox("La fecha de traslado no puede ser menor a la fecha de emisión. Verifique!!!", MsgBoxStyle.Exclamation)
                estado = False
                Exit Try
            End If

            If Strings.Left(cboserieguia.Text, 1) = "T" Then
                If rdb_trans_privado.Checked Then
                    If txt_cod_trans.Text.Trim.Length = 0 Then
                        MessageBox.Show("Debe elegir el Código de Transportista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txt_cod_trans.Focus()
                        estado = False
                        Exit Try
                    ElseIf txt_dir_entrega.Text.Trim.Length = 0 Then
                        MessageBox.Show("Debe elegir una Dirección de Entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txt_dir_entrega.Focus()
                        estado = False
                        Exit Try
                    ElseIf txt_cod_vehiculo.Text.Trim.Length = 0 Then
                        MessageBox.Show("Debe elegir un Vehiculo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txt_cod_vehiculo.Focus()
                        estado = False
                        Exit Try
                    End If
                ElseIf rdb_trans_publico.Checked Then

                    If txt_dir_entrega.Text.Trim.Length = 0 Then
                        MessageBox.Show("Debe elegir una Dirección de Entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txt_dir_entrega.Focus()
                        estado = False
                        Exit Try
                    End If
                End If
                If cbo_motivo_traslado.SelectedIndex = -1 Then
                    MsgBox("Debe elegir un Motivo de Traslado de la Guía.", MsgBoxStyle.Critical)
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
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar la Guia.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If validaciones() = False Then Exit Sub
        If dgvDetalle.Rows.Count() = 0 Then
            MsgBox("No hay items en el Detalle de la Guia", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim dtValidacion As DataTable
        Dim _GENERA_GUIA_ELECTRONICA As String = "NO"
        clsFacturaBl = New ClsNegocio.RECEIVABLE
        dtValidacion = New DataTable("Validacion")
        dtValidacion = clsFacturaBl.Get_Validacion("GS", cboserieguia.Text)
        If dtValidacion.Rows.Count > 0 Then
            _GENERA_GUIA_ELECTRONICA = dtValidacion.Rows(0).Item("IS_FACTUR_ELECTRONICO").ToString
        End If

        If CodigoNumeracionGuiaRemision() = False Then
            MsgBox("Es necesario una Numeracion para la Guia Remisión", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        DevolverTipoGuia()
        If GuardarGuiaRemision() Then

            Dim StrNomArchivo_XML As String = ""
            Dim StrNomArchivo_PDF As String = ""
            Dim _existe_pdf As Boolean = False
            Dim _existe_xml As Boolean = False
            Dim msj As String = String.Empty

            If _GENERA_GUIA_ELECTRONICA = "S" Then

                If Generar_XML_Guia_Electronica("GS", CboAlmacen.SelectedValue.ToString, NumeracionGuiaRemision, "", "SI", "") = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El documento GS -  " & NumeracionGuiaRemision & " no genero el archivo XML ubl 2.1." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                Else
                    StrNomArchivo_XML = Ruta_FE() & "\InputXML" & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
                                        Strings.Left(NumeracionGuiaRemision, Strings.Len(NumeracionGuiaRemision) - 7) & "-" &
                                        Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".xml"

                    Dim oProcesaArchivo As New ProcesaArchivo
                    Dim strMensaje As String = ""
                    _existe_pdf = False

                    If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                        MsgBox(strMensaje, MsgBoxStyle.Critical)
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If

                    System.Threading.Thread.Sleep(3000)

                    StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                dtp_fecha.Value.Year.ToString & "\" & Format(dtp_fecha.Value.Month, "00") & "\" &
                                                Format(dtp_fecha.Value.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
                                                Strings.Left(NumeracionGuiaRemision, Strings.Len(NumeracionGuiaRemision) - 7) &
                                                "-" & Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".pdf"

                    While _existe_pdf = False
                        If File.Exists(StrNomArchivo_PDF) Then
                            'Dim msj As String = ""
                            msj = "Documento Generado Correctamente" & vbCrLf & "Nro Documento: GS - " & NumeracionGuiaRemision
                            If MessageBox.Show(msj & vbCrLf & "Se procedera a la impresión del documento" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                            End If
                            _existe_pdf = True
                        End If
                    End While

                    'COPIAMOS LOS ARCHIVOS XML Y PDF A LA RUTA GENERAL DEL SERVIDOR
                    StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                dtp_fecha.Value.Year.ToString & "\" & Format(dtp_fecha.Value.Month, "00") & "\" &
                                                Format(dtp_fecha.Value.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
                                                Strings.Left(NumeracionGuiaRemision, Strings.Len(NumeracionGuiaRemision) - 7) &
                                                "-" & Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".xml"


                    If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = False Then
                        MsgBox("ERROR:" & Chr(13) & "El documento GS -  " & Strings.Left(NumeracionGuiaRemision, Strings.Len(NumeracionGuiaRemision) - 7) & Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".xml" & Chr(13) &
                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                    End If

                    If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = False Then
                        MsgBox("ERROR:" & Chr(13) & "El documento GS -  " & Strings.Left(NumeracionGuiaRemision, Strings.Len(NumeracionGuiaRemision) - 7) & Format(CInt(Strings.Right(NumeracionGuiaRemision, 7)), "00000000") & ".pdf" & Chr(13) &
                        "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                    End If
                    'FIN DE COPIAMOS LOS ARCHIVOS XML Y PDF A LA RUTA GENERAL DEL SERVIDOR

                End If
            Else
                msj = "Guia de Remisión generada Correctamente" & vbCrLf & "Nro Documento: GS - " & NumeracionGuiaRemision
                MsgBox(msj, MsgBoxStyle.Information)
                imprimirGuiaRemision(CboAlmacen.SelectedValue.ToString, "GS", NumeracionGuiaRemision)
                Me.Cursor = Cursors.Default
            End If

            If rbGuiaRemision.Checked And CboTipoTransaccion.SelectedValue = "SM" Then
                gbCabecera.Enabled = True
                GenerarColummnaDataTable()
                txt_cod_prove.Text = String.Empty
                txt_des_prove.Text = String.Empty
                txt_cod_cli.Text = String.Empty
                txt_des_cli.Text = String.Empty
                txtTipoDocRef.Text = String.Empty
                txtNumDocRef.Text = String.Empty
            Else
                dgvDocumentosGuias.Visible = True
                DocumentosGuiaRemision()
                Botonera_Estado_Cambiar(False)
                rbGuiaRemision.Checked = True
            End If
        End If

    End Sub

    Private Function Generar_XML_Guia_Electronica(ByVal TipoDoc As String, ByVal Warehouse_id As String, ByVal NumDoc As String, ByVal Monto_Letras As String, _
                                 Optional ByVal _envia_email As String = "", _
                                 Optional ByVal _email_cliente As String = "") As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_GS_Xml(TipoDoc, Warehouse_id, NumDoc, Ruta_FE() & "\InputXML", Monto_Letras, _envia_email, _email_cliente) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Ruta_FE() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE = mySetting("Ruta_FE")
        Return STRRuta_FE
    End Function

    Private Function Ruta_Reportes() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRutaReportes = mySetting("Reportes")
        Return STRRutaReportes
    End Function

    Private Function Ruta_FE_Verificacion() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE_Verificacion = mySetting("Ruta_FE_Verificacion")
        Return STRRuta_FE_Verificacion
    End Function

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
        txtorderCompra.Text = String.Empty
        dtp_fecha.MaxDate = Date.Today
        dtp_fecha.Value = Date.Today
        dtp_fecha_traslado.Value = Date.Today
        cbo_motivo_traslado.SelectedIndex = -1

        txt_dir_entrega.Text = String.Empty
        lbl_dir_entrega.Text = String.Empty

        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        Modo_consultar = False
        Modo_editar = False
        pnl_devoluciones.Visible = False
        rdb_trans_privado.Checked = True
        txt_numero_pedido.Text = String.Empty

        txt_cod_dir_partida.Text = ""
        lbl_desc_dir_partida.Text = ""
    End Sub

    Private Sub Nuevo()
        Try
            dgvDocumentosGuias.Visible = False
            GbTransaccion.Enabled = True
            gbCabecera.Enabled = False
            gbdetalle.Enabled = False
            gbOpciones.Enabled = False
            gbTipoGuia.Enabled = True
            Blank()
            GenerarColummnaDataTable()
            rbGuiaRemision.Checked = True
            rbunalinea.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevoDocumento.Enabled = False
            btn_sincronizar_cpe.Enabled = False
            btn_descargar_archivos.Enabled = False
            btn_cerrar_Guia_Venta.Visible = False
            gbOpcionesBusquedas.Visible = False
            pnlTipoGuiaRemision.Visible = True
            If Modo_consultar = True Then
                btnGrabar.Enabled = False
                pnlTipoGuiaRemision.Enabled = False
            Else
                btnGrabar.Enabled = True
                pnlTipoGuiaRemision.Enabled = True
            End If
            If Modo_editar = True Then btnGrabar.Enabled = True
            btnEliminarDocum.Enabled = False
            btnAnular.Enabled = False
            btnConsultarDocumento.Enabled = False
            btn_modificar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            lblCantidad.Visible = False
        Else
            gbOpcionesBusquedas.Visible = True
            btn_sincronizar_cpe.Enabled = True
            btn_descargar_archivos.Enabled = True
            btn_cerrar_Guia_Venta.Visible = False
            pnlTipoGuiaRemision.Visible = False
            btnNuevoDocumento.Enabled = True
            btnGrabar.Enabled = False
            btnEliminarDocum.Enabled = True
            btnAnular.Enabled = True
            btnConsultarDocumento.Enabled = True
            btn_modificar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            lblCantidad.Visible = True
        End If
    End Sub

    Private Sub btnNuevoDocumento_Click(sender As Object, e As EventArgs) Handles btnNuevoDocumento.Click
        Botonera_Estado_Cambiar(True)
        Flag_Verificar = True
        Nuevo()
        clsAlmacenBl.Get_NumeroGuiaRemision(cboserieguia.Text)
        Modo_consultar = False
        Modo_editar = False
        Flag_Verificar = False
        If CboAlmacen.DataSource Is Nothing Then Exit Sub
        CboTipoTransaccion.SelectedIndex = 0
        CboAlmacen.SelectedIndex = 0

        If LibComunVar.ClsVarComun.SERIE_GUIA_ASIGNADO <> "" Then
            cboserieguia.Text = LibComunVar.ClsVarComun.SERIE_GUIA_ASIGNADO
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvDocumentosGuias.Visible = True
        btnDespacho.Visible = False
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        Modo_editar = False
        Blank()
        'DocumentosGuiaRemision()
        btn_modificar.Visible = NIVEL_ACCESO_FACTURACION()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        Dim StrNomArchivo_PDF As String
        Dim StrNomArchivo_XML As String
        Dim _existe_pdf As Boolean = False
        Dim _existe_xml As Boolean = False

        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        If Strings.Left(Ref_numerodocument, 1) = "T" Then
            'StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
            '                        CDate(dgvDocumentosGuias.CurrentRow.Cells("Fecha").Value).Year.ToString & "\" &
            '                        Format(CDate(dgvDocumentosGuias.CurrentRow.Cells("Fecha").Value).Month, "00") & "\" &
            '                        Format(CDate(dgvDocumentosGuias.CurrentRow.Cells("Fecha").Value).Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
            '                        Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & "-" &
            '                        Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".pdf"

            'If File.Exists(StrNomArchivo_PDF) Then
            '    System.Diagnostics.Process.Start(StrNomArchivo_PDF)
            'Else
            '    Dim msj As String = ""
            '    msj = String.Empty
            '    msj = "No existe el archivo " & vbCrLf & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".pdf"
            '    MsgBox(msj, MsgBoxStyle.Information)
            'End If

            StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                        Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & _
                                        "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".pdf"

            If File.Exists(StrNomArchivo_PDF) Then
                System.Diagnostics.Process.Start(StrNomArchivo_PDF)
            Else
                StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                        CDate(dgvDocumentosGuias.CurrentRow.Cells("Fecha").Value).Year.ToString & "\" &
                                        Format(CDate(dgvDocumentosGuias.CurrentRow.Cells("Fecha").Value).Month, "00") & "\" &
                                        Format(CDate(dgvDocumentosGuias.CurrentRow.Cells("Fecha").Value).Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
                                        Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & "-" &
                                        Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".pdf"

                If File.Exists(StrNomArchivo_PDF) Then
                    If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = True Then
                        StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                        Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & _
                                        "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".pdf"

                        If File.Exists(StrNomArchivo_PDF) Then
                            System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                        Else
                            Dim msj As String = ""
                            msj = String.Empty
                            msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".pdf"
                            MsgBox(msj, MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".PDF" & Chr(13) &
                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                    End If
                Else
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".pdf"
                    MsgBox(msj, MsgBoxStyle.Information)
                End If
            End If


        Else
            imprimirGuiaRemision(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
        End If
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

    Private Sub MostrandoFTsinDescargo(ByVal DOCUMENT_ID As String, ByVal NUMBER_DOCUMENT As String)
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtFtsinDescargoCab = New DataTable
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
                dtFtsinDescargoDet = New DataTable
                dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_GuiaFtsinDescargoDetalle(DOCUMENT_ID, NUMBER_DOCUMENT)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    dgvDetalle.Columns(2).Width = 300
                    dgvDetalle.Columns(6).Visible = True
                    dgvDetalle.Columns(6).DefaultCellStyle.Format = "##,##0.00"
                    ' gbOpciones.Enabled = True
                    RehacerSecuencia()
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

    Private Sub MostrandoDatos_Devolucion(ByVal DOCUMENT_ID As String, ByVal NUMBER_DOCUMENT As String)
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtFtsinDescargoCab = New DataTable
            dtFtsinDescargoCab = clsAlmacenCabBl.get_Guia_Devolucion_Cabecera(DOCUMENT_ID, NUMBER_DOCUMENT)
            _RUC = String.Empty
            _DIRECCION = String.Empty
            Dim _Codigo As String = ""

            For Each fila As DataGridViewRow In dgv_detalle_dev.Rows
                If fila.Cells(0).Value = True Then
                    _Codigo = _Codigo & """" & fila.Cells("ITEM").Value.ToString() & """" & ","
                End If

            Next
            If _Codigo.Length() <> 0 Then
                _Codigo = Mid(_Codigo, 1, _Codigo.Length - 1)
            End If

            If dtFtsinDescargoCab.Rows.Count() <> 0 Then
                '---Mostrando Datos de Cabecera
                'CboTipoTransaccion.SelectedValue = dtCabeceraAlm.Rows(0).Item("TRANS_ID").ToString
                'CboAlmacen.SelectedValue = dtFtsinDescargoCab.Rows(0).Item("WAREHOUSE_ID").ToString
                txt_cod_prove.Text = dtFtsinDescargoCab.Rows(0).Item("VENDOR_ID").ToString
                txt_des_prove.Text = dtFtsinDescargoCab.Rows(0).Item("VENDOR_NAME").ToString
                txt_cod_cli.Text = dtFtsinDescargoCab.Rows(0).Item("CUSTOMER_ID").ToString
                txt_des_cli.Text = dtFtsinDescargoCab.Rows(0).Item("CUSTOMER_NAME").ToString
                _RUC = dtFtsinDescargoCab.Rows(0).Item("VAT_REGISTRATION").ToString
                _DIRECCION = dtFtsinDescargoCab.Rows(0).Item("ADDR_DLV").ToString
                '---Mostrando Datos de Detalle
                '  GenerarColummnaDataTable()
                dtFtsinDescargoDet = New DataTable
                dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Guia_Devolucion_Detalle(DOCUMENT_ID, NUMBER_DOCUMENT, _Codigo)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    dgvDetalle.Columns(2).Width = 300
                    dgvDetalle.Columns(6).Visible = True
                    dgvDetalle.Columns(6).DefaultCellStyle.Format = "##,##0.00"
                    ' gbOpciones.Enabled = True

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

    Private Sub Motrando_detalles_devolucion(ByVal Tipo As String, ByVal Numero As String, ByVal Almacen As String)
        Try
            Dim FacturaBl As New ClsOperaciones.RECEIVABLE
            dtv2 = New DataView
            dtv2 = FacturaBl.Documentos_Detalle_devoluciones_Canjes(Tipo, Numero, Almacen).DefaultView
            dgv_detalle_dev.DataSource = dtv2
            dgv_detalle_dev.AutoResizeColumns()
            dgv_detalle_dev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            STRordenDevol = dgv_detalle_dev.Columns(3).Name & "+" & dgv_detalle_dev.Columns(6).Name & "+" & dgv_detalle_dev.Columns(7).Name
            For i As Integer = 0 To dgv_detalle_dev.Columns.Count - 1
                dgv_detalle_dev.Columns(i).ReadOnly = True
            Next
            dgv_detalle_dev.Columns(0).ReadOnly = False
            For i As Integer = 8 To 19
                dgv_detalle_dev.Columns(i).Visible = False
            Next
            dgv_detalle_dev.Columns(28).Visible = False
            dgv_detalle_dev.Columns(1).Visible = False
            dgv_detalle_dev.Columns(24).Visible = False

            dgv_detalle_dev.Columns(25).HeaderText = "TIP. DOC. REF."
            dgv_detalle_dev.Columns(26).HeaderText = "SER. DOC. REF."
            dgv_detalle_dev.Columns(27).HeaderText = "N° DOC. REF."

            dgv_detalle_dev.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle_dev.Columns(4).DefaultCellStyle.Format = "N2"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarModoConsultar(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String)
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtDetalleAlm = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraAlm = clsAlmacenCabBl.get_CabeceraAlmacen(alm_, doc_, num_)
            If dtCabeceraAlm.Rows.Count() <> 0 Then
                If String.IsNullOrEmpty(dtCabeceraAlm.Rows(0).Item("MOV_OPTION_ID").ToString) Then
                    Select Case dtCabeceraAlm.Rows(0).Item("TRANS_ID").ToString
                        Case "GV"
                            rbGuia_ventaFacturar.Checked = True
                        Case "TD"
                            rbGuia_Transferencia.Checked = True
                        Case "GF"
                            'rbGuia_sinDescargo.Checked = True
                        Case "SV"
                            rbGuia_FTsinDescargo.Checked = True
                        Case Else
                            rbGuiaRemision.Checked = True
                    End Select
                Else
                    For Each Control As Control In gbTipoGuiaRemision.Controls
                        If TypeOf Control Is RadioButton Then
                            If dtCabeceraAlm.Rows(0).Item("MOV_OPTION_ID").ToString = CType(Control, RadioButton).Text Then
                                CType(Control, RadioButton).Checked = True
                                Exit For
                            End If
                        End If
                    Next
                End If
                dtp_fecha.Text = dtCabeceraAlm.Rows(0).Item("DATE_DOCUMENT").ToString
                If dtCabeceraAlm.Rows(0).Item("FECHA_TRASLADO").ToString = "" Then
                    dtp_fecha_traslado.Value = Date.Today
                Else
                    dtp_fecha_traslado.Text = dtCabeceraAlm.Rows(0).Item("FECHA_TRASLADO").ToString
                End If
                CboTipoTransaccion.SelectedValue = dtCabeceraAlm.Rows(0).Item("TRANS_ID").ToString
                CboAlmacen.SelectedValue = dtCabeceraAlm.Rows(0).Item(0).ToString
                txtTipoDocRef.Text = dtCabeceraAlm.Rows(0).Item("DOC_ID_REF").ToString
                txtNumDocRef.Text = dtCabeceraAlm.Rows(0).Item("NUM_ID_REF").ToString
                txt_cod_prove.Text = dtCabeceraAlm.Rows(0).Item("VENDOR_ID").ToString
                txt_des_prove.Text = dtCabeceraAlm.Rows(0).Item("VENDOR_NAME").ToString
                txt_cod_cli.Text = dtCabeceraAlm.Rows(0).Item("CUSTOMER_ID").ToString
                txt_des_cli.Text = dtCabeceraAlm.Rows(0).Item("CUSTOMER_NAME").ToString
                txtorderCompra.Text = dtCabeceraAlm.Rows(0).Item("NUMBER_PURCHASE").ToString
                txt_numero_entrega.Text = dtCabeceraAlm.Rows(0).Item("NUMERO_ENTREGA").ToString
                cbo_motivo_traslado.SelectedValue = dtCabeceraAlm.Rows(0).Item("MOTIVO_TRASLADO").ToString
                txt_numero_pedido.Text = dtCabeceraAlm.Rows(0).Item("NUMBER_ORDER").ToString

                txt_dir_entrega.Text = txt_cod_cli.Text
                lbl_dir_entrega.Text = dtCabeceraAlm.Rows(0).Item("ADDR_DLV").ToString

                txt_emp_trans_manual.Text = dtCabeceraAlm.Rows(0).Item("DESC_TRANSPORTISTAS_DESPACHOS").ToString
                txt_trans_manual_despacho.Text = dtCabeceraAlm.Rows(0).Item("ID_TRANSPORTISTAS").ToString
                txt_datos_vehiculo.Text = dtCabeceraAlm.Rows(0).Item("DATOS_VEHICULO").ToString

                txt_cod_vehiculo.Text = dtCabeceraAlm.Rows(0).Item("COD_VEHICULO").ToString
                txt_des_vehiculo.Text = dtCabeceraAlm.Rows(0).Item("DES_VEHICULO").ToString

                txt_cod_trans.Text = dtCabeceraAlm.Rows(0).Item("COD_TRANS").ToString
                txt_des_transportista.Text = dtCabeceraAlm.Rows(0).Item("DES_TRANS").ToString

                txt_cod_empresa_trans.Text = dtCabeceraAlm.Rows(0).Item("ID_EMPTRA").ToString
                txt_des_empresa_trans.Text = dtCabeceraAlm.Rows(0).Item("EMP_TRA").ToString

                If dtCabeceraAlm.Rows(0).Item("EMP_TRA").ToString = "Trans. privado" Then
                    rdb_trans_privado.Checked = True
                ElseIf dtCabeceraAlm.Rows(0).Item("EMP_TRA").ToString = "Trans. público" Then
                    rdb_trans_publico.Checked = True
                Else
                    rdb_trans_privado.Checked = False
                    rdb_trans_publico.Checked = False
                End If

                If Not String.IsNullOrEmpty(dtCabeceraAlm.Rows(0).Item("INTERFACE").ToString) Then
                    If dtCabeceraAlm.Rows(0).Item("INTERFACE").ToString = "0" Then
                        rbunalinea.Checked = True
                    Else
                        rbVariaslineas.Checked = True
                    End If
                End If
                txtComentarios.Text = dtCabeceraAlm.Rows(0).Item("COMMENT").ToString
                cboserieguia.Text = dtCabeceraAlm.Rows(0).Item("SERIE_GUIA").ToString
                '---Mostrando datos del Detalle
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_DetalleAlmacenEdicion(alm_, doc_, num_)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultarDocumento_Click(sender As Object, e As EventArgs) Handles btnConsultarDocumento.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub
        dtp_fecha.MaxDate = "31/12/9998"
        Modo_consultar = True
        Modo_editar = False
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        dgvDocumentosGuias.Visible = False
        MostrarModoConsultar(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
        GbTransaccion.Enabled = False
        gbCabecera.Enabled = False
        gbdetalle.Enabled = True
        gbOpciones.Enabled = False
        gbTipoGuia.Enabled = False
        Call Botonera_Estado_Cambiar(True)
        If String.IsNullOrEmpty(dtCabeceraAlm.Rows(0).Item("MOV_OPTION_ID").ToString) Then
            If dtCabeceraAlm.Rows(0).Item("TRANS_ID").ToString = "GF" Then
                'Verificando si posee despacho
                Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
                Dim dtVerificar As New DataTable("Despacho")
                dtVerificar = almacenBL.VerificarDespacho(Ref_idalamacen, Ref_numerodocument)
                If dtVerificar.Rows.Count() = 0 Then
                    btnDespacho.Visible = False
                Else
                    If String.IsNullOrEmpty(dtVerificar.Rows(0).Item("FECHA_DESPACHO").ToString) Then
                        btnDespacho.Visible = True
                        lblDespachoNumero.Text = String.Empty
                        lblDespachoNumero.Text = Ref_documentid & " - " & Ref_numerodocument
                    End If
                End If
            End If
        Else
            If dtCabeceraAlm.Rows(0).Item("TRANS_ID").ToString <> "GF" Then
                'Verificando si posee despacho
                Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
                Dim dtVerificar As New DataTable("Despacho")
                dtVerificar = almacenBL.VerificarDespacho(Ref_idalamacen, Ref_numerodocument)
                If dtVerificar.Rows.Count() = 0 Then
                    btnDespacho.Visible = False
                Else
                    If String.IsNullOrEmpty(dtVerificar.Rows(0).Item("FECHA_DESPACHO").ToString) Then
                        btnDespacho.Visible = True
                        lblDespachoNumero.Text = String.Empty
                        lblDespachoNumero.Text = Ref_documentid & " - " & Ref_numerodocument
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub EliminarGuiasRemision()
        Try
            Ref_idalamacen = String.Empty
            Ref_documentid = String.Empty
            Ref_numerodocument = String.Empty
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

    Private Sub Cierre_Manual_GuiasRemision()
        Try
            Ref_idalamacen = String.Empty
            Ref_documentid = String.Empty
            Ref_numerodocument = String.Empty
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            almacenBL.Cierre_Manual_GuiaRemision(Ref_idalamacen, Ref_documentid, Ref_numerodocument, LibComunVar.ClsVarComun.USUARIO)
            Dim msj As String = String.Empty
            msj = "Guia de Remision cerrado Correctamente, Nro Documento: " & Ref_numerodocument
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            DocumentosGuiaRemision()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarDocum_Click(sender As Object, e As EventArgs) Handles btnEliminarDocum.Click
        If dgvDocumentosGuias.RowCount = 0 Then Exit Sub
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub

        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value = "GF" Then
                MsgBox("El tipo de Guia seleccionada eliminela por el modulo de Facturacion.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value = "GV" And dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value = "FACTURADO" Then
                MsgBox("Para eliminar el tipo de guia seleccionado " & vbCrLf & "debe eliminar el documento de referencia.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value = "ANULADO" Then
                MsgBox("El documento se encuentra Anulado, no procede la eliminación.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

        ref_fecha_doc = dgvDocumentosGuias.Item(4, dgvDocumentosGuias.CurrentRow.Index).Value

        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EliminarGuiasRemision()
        End If
    End Sub

    Private Function Verificar_Documento_cerrado(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            'If Mes_Ant = 1 Then
            'Mes_Ant = "12"
            'Anio_Ant = CInt(Anio_Ant) - 1
            'Else
            '    Mes_Ant = CInt(Mes_Ant) - 1
            '    Anio_Ant = anyo
            ' End If
            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.ValidarFechaVentas(Mes_Ant, Anio_Ant, "CIERRE")
            If dtCierre.Rows.Count() <> 0 Then
                ' Dim Resultado As Integer
                If dtCierre.Rows(0).Item(0) = 1 Then
                    MsgBox("El documento pertenece a un mes cerrado, no procede la transacción.", MsgBoxStyle.Critical)
                    Estado = False
                    Exit Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub DocumentosGuiaRemision()
        Try
            Me.Cursor = Cursors.WaitCursor
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If

            clsGuiaRemisionBl = New ClsOperaciones.WAREHOUSE_TRANS
            dtDocumentoGuias = New DataTable
            dtDocumentoGuias = clsGuiaRemisionBl.get_DatosGeneralesGuiaRemision(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                                cboopcionesBusqueda.SelectedIndex, "S", "GS", LibComunVar.ClsVarComun.AccesoAlmacenes)

            dgvDocumentosGuias.DataSource = Nothing
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                dtv = dtDocumentoGuias.DefaultView
                dgvDocumentosGuias.DataSource = dtv
                'dgvDocumentosGuias.AutoResizeColumns()
                'dgvDocumentosGuias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvDocumentosGuias.Columns(0).Width = 40
                dgvDocumentosGuias.Columns(1).Width = 160
                dgvDocumentosGuias.Columns(2).Width = 30
                dgvDocumentosGuias.Columns(3).Width = 80
                dgvDocumentosGuias.Columns(4).Width = 70
                dgvDocumentosGuias.Columns(5).Width = 250
                dgvDocumentosGuias.Columns(6).Width = 30
                dgvDocumentosGuias.Columns(7).Width = 40
                dgvDocumentosGuias.Columns(8).Width = 180
                dgvDocumentosGuias.Columns(9).Width = 75
                dgvDocumentosGuias.Columns(10).Width = 70
                dgvDocumentosGuias.Columns(11).Width = 70
                dgvDocumentosGuias.Columns(12).Width = 90
                dgvDocumentosGuias.Columns(12).DisplayIndex = 9

                dgvDocumentosGuias.Columns("SINCRONIZADO").HeaderText = "Sincronizado PDF"
                dgvDocumentosGuias.Columns("SINCRONIZADO_XML").HeaderText = "Sincronizado XML"

                STRorden = dgvDocumentosGuias.Columns(0).Name & "+" & dgvDocumentosGuias.Columns(1).Name & "+" & dgvDocumentosGuias.Columns(2).Name & "+" & dgvDocumentosGuias.Columns(3).Name & "+" & dgvDocumentosGuias.Columns(5).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
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
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cliente()
        End If
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
        If e.KeyChar = ChrW(Keys.Enter) Then
            If CboTipoTransaccion.SelectedValue = "CP" Then
                Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
                VentasBl = New ClsOperaciones.RECEIVABLE
                Dim dtCierre As New DataTable
                dtCierre = VentasBl.ValidarGuiasCanje(txtTipoDocRef.Text.Trim, txtNumDocRef.Text.Trim)
                If dtCierre.Rows.Count() <> 0 Then
                    If dtCierre.Rows(0).Item(0) = 1 Then
                        MsgBox("El número de Guia ingresado," & Chr(13) & " se adjunto en un canje anterior.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txt_ord_prod_KeyPress(sender As Object, e As KeyPressEventArgs)
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



    Private Sub rbGuiaRemision_CheckedChanged(sender As Object, e As EventArgs) Handles rbGuiaRemision.CheckedChanged
        If Modo_consultar = True Or Modo_editar Then Exit Sub
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
        If Modo_consultar = True Or Modo_editar Then Exit Sub
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
        If Modo_consultar = True Or Modo_editar Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rbGuia_Transferencia.Checked Then
                CboTipoTransaccion.SelectedValue = "TD"
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
        If Modo_consultar = True Or Modo_editar Then Exit Sub
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
        If Modo_consultar = True Or Modo_editar Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rbGuia_FTsinDescargo.Checked Then
                CboTipoTransaccion.SelectedValue = "SV"
                CboTipoTransaccion.Enabled = False
                '  btnAgregar.Enabled = False
                Blank()
                GenerarColummnaDataTable()
                dgvDetalle.Columns(2).Width = 300
                dgvDetalle.Columns(6).Visible = True
                PictureBox7.Visible = True
            Else
                btnAgregar.Enabled = True
                PictureBox7.Visible = False
            End If
        End If
    End Sub

    Private Sub txtNumDocRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtNumDocRef.MouseDoubleClick
        If rbGuia_FTsinDescargo.Checked = True Then
            If txtTipoDocRef.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Ayuda_NumeroDocumentosReferencia()
        ElseIf rbGuia_Devolucion.Checked = True Then
            If txtTipoDocRef.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Ayuda_NumeroDocumentosReferencia_Devolucion()
        End If
    End Sub

    Private Sub AnularGuiasRemision()
        Try
            Ref_idalamacen = String.Empty
            Ref_documentid = String.Empty
            Ref_numerodocument = String.Empty
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            almacenBL.AnularGuiaRemision(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
            Dim msj As String = String.Empty
            msj = "Guia de Remision Anulada Correctamente, Nro Documento: " & Ref_numerodocument
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            DocumentosGuiaRemision()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub

        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value = "GF" Then
                MsgBox("El tipo de Guia seleccionada eliminela por el modulo de Facturacion.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value = "GV" And dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value = "FACTURADO" Then
                MsgBox("Para eliminar el tipo de guia seleccionado " & vbCrLf & "debe eliminar el documento de referencia.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value = "ANULADO" Then
                MsgBox("El documento se encuentra Anulado, no procede la eliminación.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

        ref_fecha_doc = dgvDocumentosGuias.Item(4, dgvDocumentosGuias.CurrentRow.Index).Value

        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        If MessageBox.Show("Se va a proceder a Anular el Documento" & vbCrLf & "¿Desea continuar?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            AnularGuiasRemision()
        End If
    End Sub

    Private Sub btnDespacho_Click(sender As Object, e As EventArgs) Handles btnDespacho.Click
        txt_cod_emp_trans.Text = ""
        txt_des_emp_trans.Text = ""
        txt_obs_despachos.Text = ""
        txt_cod_transportista.Text = ""
        txt_des_transportista_despacho.Text = ""
        pnlConfirmarDespacho.Visible = True
        dtpDespacho.Value = Date.Now()
        btnDespacho.Enabled = False
    End Sub

    Private Sub btn_AceptarDesp_Click(sender As Object, e As EventArgs) Handles btn_AceptarDesp.Click
        Try
            If MessageBox.Show("¿Desea Generar el  Despacho.?", "Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If String.IsNullOrEmpty(Ref_idalamacen) Or String.IsNullOrEmpty(Ref_numerodocument) Then
                    MsgBox("Los numero del Documento no se cargo.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
                If almacenBL.GenerarDespacho(Ref_idalamacen, Ref_numerodocument, dtpDespacho.Value.ToString("dd/MM/yyyy"), String.Format("{0:HH:mm:ss}", DateTime.Now), LibComunVar.ClsVarComun.USUARIO, IIf(RadioButton7.Checked, txt_emp_trans_manual.Text.Trim, txt_des_emp_trans.Text.Trim), txt_obs_despachos.Text.Trim, IIf(RadioButton4.Checked, txt_trans_manual_despacho.Text.Trim, txt_des_transportista_despacho.Text.Trim), IIf(rb_manual_datos_vehiculo.Checked, txt_datos_vehiculo.Text.Trim, txt_des_datos_vehiculo.Text.Trim)) Then
                    MsgBox("Generacion de despacho realizado correctamente", MsgBoxStyle.Information)
                    pnlConfirmarDespacho.Visible = False
                    btnDespacho.Visible = False
                    btnDespacho.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_SalirDesp_Click(sender As Object, e As EventArgs) Handles btn_SalirDesp.Click
        pnlConfirmarDespacho.Visible = False
        btnDespacho.Enabled = True
    End Sub

    Private Sub rbunalinea_CheckedChanged(sender As Object, e As EventArgs) Handles rbunalinea.CheckedChanged
        'Me.txtComentarios.Size = New System.Drawing.Size(764, 21)
        'txtComentarios.Text = ""
    End Sub

    Private Sub rbVariaslineas_CheckedChanged(sender As Object, e As EventArgs) Handles rbVariaslineas.CheckedChanged
        'Me.txtComentarios.Size = New System.Drawing.Size(764, 30)
        'txtComentarios.Text = ""
    End Sub

    Private Sub txtComentarios_KeyDown(sender As Object, e As KeyEventArgs) Handles txtComentarios.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If rbunalinea.Checked = True Then
        '        e.Handled = True
        '        btnAgregar.Select()
        '    End If
        'End If
    End Sub


    Private Function FechaFacturacion(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            If Mes_Ant = 1 Then
                Mes_Ant = "12"
                Anio_Ant = CInt(Anio_Ant) - 1
            Else
                Mes_Ant = CInt(Mes_Ant) - 1
                Anio_Ant = anyo
            End If

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.ValidarFechaVentas(Mes_Ant, Anio_Ant, "CIERRE")
            If dtCierre.Rows.Count() <> 0 Then
                If dtCierre.Rows(0).Item(0) = 1 Then
                    MsgBox("Fecha invalida para la Guia.", MsgBoxStyle.Critical)
                    Estado = False
                    Flag_Verificar = True
                    Exit Try
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Function FechaFacturacion_Mes_anterior(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            'If Mes_Ant = 1 Then
            'Mes_Ant = "12"
            'Anio_Ant = CInt(Anio_Ant) - 1
            'Else
            '    Mes_Ant = CInt(Mes_Ant) - 1
            '    Anio_Ant = anyo
            ' End If
            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.ValidarFechaVentas(Mes_Ant, Anio_Ant, "CIERRE")
            If dtCierre.Rows.Count() <> 0 Then
                ' Dim Resultado As Integer
                If dtCierre.Rows(0).Item(0) = 1 Then
                    MsgBox("El mes seleccionado se encuentra cerrado," & Chr(13) & "aperturar para proceder con la Facturación.", MsgBoxStyle.Critical)
                    Estado = False
                    Flag_Verificar = True
                    Exit Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub dtp_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha.KeyDown
        Flag_Verificar = False
        If e.KeyCode = Keys.Enter Then
            If FechaFacturacion_Mes_anterior(dtp_fecha.Value.Month, dtp_fecha.Value.Year) = False Then
                '    btnCancelar_Click(sender, e)
                'Else
                '    If FechaFacturacion(dtp_fecha.Value.Month + 1, dtp_fecha.Value.Year) = False Then btnCancelar_Click(sender, e)
            End If
        End If

    End Sub



    Private Sub dtp_fecha_Leave(sender As Object, e As EventArgs) Handles dtp_fecha.Leave
        If Flag_Verificar = False Then
            If FechaFacturacion_Mes_anterior(dtp_fecha.Value.Month, dtp_fecha.Value.Year) = False Then
                '    btnCancelar_Click(sender, e)
                '    Exit Sub
                'Else
                '    If FechaFacturacion(dtp_fecha.Value.Month + 1, dtp_fecha.Value.Year) = False Then btnCancelar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub rbGuia_VF_RM_CheckedChanged(sender As Object, e As EventArgs) Handles rbGuia_VF_RM.CheckedChanged
        If Modo_consultar = True Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rbGuia_VF_RM.Checked Then
                CboTipoTransaccion.SelectedValue = "GV"
                CboTipoTransaccion.Enabled = False
                Blank()
                GenerarColummnaDataTable()
            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub dtp_fecha_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha.ValueChanged
        If Modo_consultar = False Then
            If dtp_fecha.Value <> Date.Now Then
                dtp_fecha.MaxDate = Date.Now
            End If
        End If
    End Sub

    Private Sub txtorderCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtorderCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If dgvDocumentosGuias.RowCount() = 0 Then Exit Sub
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub

        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value = "GF" Then
                MsgBox("El tipo de Guia seleccionada no se puede modificar.", MsgBoxStyle.Critical)
                btnCancelar.PerformClick()
                Exit Sub
            End If
        End If
        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value = "GV" And dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value = "FACTURADO" Then
                MsgBox("Para modificar el tipo de guia seleccionado " & vbCrLf & "debe modificar el documento de referencia.", MsgBoxStyle.Critical)
                btnCancelar.PerformClick()
                Exit Sub
            End If
        End If

        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value = "ANULADO" Then
                MsgBox("El documento se encuentra Anulado. No procede la modificación.", MsgBoxStyle.Critical)
                btnCancelar.PerformClick()
                Exit Sub
            End If
        End If

        Modo_editar = True
        Call Botonera_Estado_Cambiar(True)
        dtp_fecha.MaxDate = "31/12/9998"
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        ''VALIDACIONES DE MODIFICACION


        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        dgvDocumentosGuias.Visible = False
        MostrarModoConsultar(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
        GbTransaccion.Enabled = True
        gbCabecera.Enabled = True
        gbdetalle.Enabled = True
        'gbOpciones.Enabled = True
        gbTipoGuia.Enabled = True
    End Sub
    Private Sub cboserieguia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboserieguia.SelectedIndexChanged
        NumeroLineas = String.Empty
        clsAlmacenBl.Get_NumeroGuiaRemision(cboserieguia.Text)
        NumeroLineas = clsAlmacenBl.NUMBER_LINE
        txt_num_guia.Text = clsAlmacenBl.NUMBER_SERIE
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_emp_trans.MouseDoubleClick
        Lista_Transportistas()
    End Sub

    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_emp_trans.KeyDown
        If e.KeyCode = Keys.F1 Then
            Lista_Transportistas()
        End If
    End Sub
    Private Sub Lista_Transportistas()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "FACT_SP_S_EMPRESA_TRANSPORTE"
        frm.CadenaConsulta = sql
        frm.Titulo = "Empresa de Transporte"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_emp_trans.Text = frm.Data_Matriz.Rows(0).Item(0)
            txt_des_emp_trans.Text = frm.Data_Matriz.Rows(0).Item(1)
        End If
        frm.Close()
        txt_cod_transportista.Focus()
    End Sub

    Private Sub txt_cod_transportista_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_transportista.MouseDoubleClick
        Lista_Transportistas_Despachos()
    End Sub

    Private Sub txt_cod_transportista_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_transportista.KeyDown
        If e.KeyCode = Keys.F1 Then
            Lista_Transportistas_Despachos()
        End If
    End Sub
    Private Sub Lista_Transportistas_Despachos()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "SAL_HLP_CARRIER"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Transportistas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_transportista.Text = frm.Data_Matriz.Rows(0).Item(0)
            txt_des_transportista_despacho.Text = frm.Data_Matriz.Rows(0).Item(1)
        End If
        frm.Close()
        txt_obs_despachos.Focus()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            txt_cod_transportista.Enabled = False
            txt_cod_transportista.Text = ""
            txt_des_transportista_despacho.Text = ""
            txt_trans_manual_despacho.Enabled = True
            txt_trans_manual_despacho.Text = ""
            txt_trans_manual_despacho.Focus()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            txt_cod_transportista.Enabled = True
            txt_cod_transportista.Text = ""
            txt_des_transportista_despacho.Text = ""
            txt_trans_manual_despacho.Enabled = False
            txt_trans_manual_despacho.Text = ""
            txt_cod_transportista.Focus()
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            txt_cod_emp_trans.Text = ""
            txt_des_emp_trans.Text = ""
            txt_cod_emp_trans.Enabled = False
            txt_des_emp_trans.Enabled = False
            txt_emp_trans_manual.Text = ""
            txt_emp_trans_manual.Enabled = True
            txt_emp_trans_manual.Focus()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            txt_cod_emp_trans.Text = ""
            txt_des_emp_trans.Text = ""
            txt_cod_emp_trans.Enabled = True
            txt_des_emp_trans.Enabled = False
            txt_emp_trans_manual.Text = ""
            txt_emp_trans_manual.Enabled = False
            txt_cod_emp_trans.Focus()
        End If
    End Sub

    Private Sub txt_cod_tramo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_tramo.MouseDoubleClick
        Ayuda_Tramos()
    End Sub

    Private Sub txt_cod_trans_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_trans.MouseDoubleClick
        Call Ayuda_Transporte()
    End Sub

    Private Sub txt_cod_vendedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_vendedor.MouseDoubleClick
        Call Ayuda_Vendedor()
    End Sub

    Private Sub txt_cod_vendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_vendedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor()
        End If
    End Sub
    Private Sub Ayuda_Vendedor()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_GUIA_VENDEDOR"
            frm.CadenaConsulta = sql
            frm.Titulo = "Vendedor"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_vendedor.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_vendedor.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
            Call Buscar_Datos_Transportista()
            txtComentarios.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_vehiculo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_vehiculo.MouseDoubleClick
        Ayuda_Vehiculos()
    End Sub

    Private Sub txt_cod_vehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_vehiculo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vehiculos()
        End If
    End Sub
    Private Sub Ayuda_Vehiculos()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_VEHICULOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Vehiculos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_vehiculo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_vehiculo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            frm.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_empresa_trans_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_empresa_trans.MouseDoubleClick
        Lista_Emp_transporte()
    End Sub

    Private Sub txt_cod_empresa_trans_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_empresa_trans.KeyDown
        If e.KeyCode = Keys.F1 Then
            Lista_Emp_transporte()
        End If
    End Sub
    Private Sub Lista_Emp_transporte()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "FACT_SP_S_EMPRESA_TRANSPORTE"
        frm.CadenaConsulta = sql
        frm.Titulo = "Empresa de Transporte"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_empresa_trans.Text = frm.Data_Matriz.Rows(0).Item(0)
            txt_des_empresa_trans.Text = frm.Data_Matriz.Rows(0).Item(1)
        End If
        frm.Close()
        txt_cod_transportista.Focus()
    End Sub

    Private Sub txt_cod_datos_vehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_datos_vehiculo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vehiculos_Despachos()
        End If
    End Sub

    Private Sub txt_cod_datos_vehiculo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_datos_vehiculo.MouseDoubleClick
        Ayuda_Vehiculos_Despachos()
    End Sub
    Private Sub Ayuda_Vehiculos_Despachos()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_VEHICULOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Vehiculos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_datos_vehiculo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_datos_vehiculo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            frm.Close()
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub rbGuia_Devolucion_CheckedChanged(sender As Object, e As EventArgs) Handles rbGuia_Devolucion.CheckedChanged
        If Modo_consultar = True Or Modo_editar Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rbGuia_Devolucion.Checked Then
                CboTipoTransaccion.SelectedValue = "CP"
                CboTipoTransaccion.Enabled = False
                '  btnAgregar.Enabled = False
                Blank()
                GenerarColummnaDataTable()
                dgvDetalle.Columns(2).Width = 300
                dgvDetalle.Columns(6).Visible = True
                PictureBox7.Visible = True
            Else
                btnAgregar.Enabled = True
                PictureBox7.Visible = False
            End If
        End If
    End Sub

    Private Sub txtNumDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumDocRef.KeyDown
        If e.KeyCode = Keys.F1 Then
            If rbGuia_FTsinDescargo.Checked = True Then
                If txtTipoDocRef.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Ayuda_NumeroDocumentosReferencia()
            ElseIf rbGuia_Devolucion.Checked = True Then
                If txtTipoDocRef.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Tipo De Documento.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Ayuda_NumeroDocumentosReferencia_Devolucion()
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

    Private Sub btn_devolucion_salir_Click(sender As Object, e As EventArgs) Handles btn_devolucion_salir.Click
        txt_busqueda_dev.Text = ""
        pnl_devoluciones.Visible = False

        gbCabecera.Enabled = True
        'gbOpciones.Enabled = True
        GbTransaccion.Enabled = True
        gbTipoGuia.Enabled = True
    End Sub

    Private Sub btn_devolucion_ok_Click(sender As Object, e As EventArgs) Handles btn_devolucion_ok.Click
        Try
            If dgv_detalle_dev.RowCount = 0 Then Exit Sub
            Dim estado As Boolean = False
            For Each rows As DataGridViewRow In dgv_detalle_dev.Rows
                If rows.Cells(0).Value = True Then
                    estado = True
                    Exit For
                End If
            Next
            If estado = False Then
                MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dgv_detalle_dev.Focus()
                Exit Sub
            End If
            '++++

            MostrandoDatos_Devolucion(txtTipoDocRef.Text, txtNumDocRef.Text)
            btn_devolucion_salir.PerformClick()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_busqueda_dev_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_dev.TextChanged
        Dim wbusqueda As String = UCase(txt_busqueda_dev.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv2), CurrencyManager)
        Dim INTnewpos As Integer
        dtv2.RowFilter = STRordenDevol & " like '%" & txt_busqueda_dev.Text & "%'"
        myCurrencyManager.Position = INTnewpos
    End Sub

    Private Sub dgv_detalle_dev_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_detalle_dev.CurrentCellDirtyStateChanged
        dgv_detalle_dev.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub txt_dir_entrega_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_dir_entrega.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call Ayuda_Dir_Entrega_Cliente(txt_cod_cli.Text.Trim)
        End If
    End Sub

    Private Sub txt_dir_entrega_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_dir_entrega.MouseDoubleClick
        Call Ayuda_Dir_Entrega_Cliente(txt_cod_cli.Text.Trim)
    End Sub

    Private Sub dgvDocumentosGuias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumentosGuias.CellClick
        If dgvDocumentosGuias.RowCount() = 0 Then Exit Sub
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub

        If dgvDocumentosGuias.CurrentRow.Cells("ID").Value = "GV" And dgvDocumentosGuias.CurrentRow.Cells("Estado").Value = "PEN. FACT." Then
            btn_cerrar_Guia_Venta.Visible = True
        Else
            btn_cerrar_Guia_Venta.Visible = False
        End If
    End Sub

    Private Sub btn_cerrar_Guia_Venta_Click(sender As Object, e As EventArgs) Handles btn_cerrar_Guia_Venta.Click
        If dgvDocumentosGuias.RowCount = 0 Then Exit Sub
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub

        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value = "GF" Then
                MsgBox("El tipo de Guia seleccionada  no procede para el cierre.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(7, dgvDocumentosGuias.CurrentRow.Index).Value = "GV" And dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value = "FACTURADO" Then
                MsgBox("Para eliminar el tipo de guia seleccionado " & vbCrLf & "debe encontrarse PENDIENTE.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        If Not String.IsNullOrEmpty(dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value.ToString) Then
            If dgvDocumentosGuias.Item(9, dgvDocumentosGuias.CurrentRow.Index).Value = "ANULADO" Then
                MsgBox("El documento se encuentra Anulado, no procede el cierre.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

        ref_fecha_doc = dgvDocumentosGuias.Item(4, dgvDocumentosGuias.CurrentRow.Index).Value

        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        If MessageBox.Show("Se va a cerrar el registro seleccionado" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Cierre_Manual_GuiasRemision()
        End If
    End Sub

    Private Sub rb_facturar_pedido_CheckedChanged(sender As Object, e As EventArgs) Handles rb_facturar_pedido.CheckedChanged
        If Modo_consultar = True Or Modo_editar Then Exit Sub
        If CboTipoTransaccion.Items.Count() <> 0 Then
            If rb_facturar_pedido.Checked Then
                'CboTipoTransaccion.SelectedValue = "GV"
                'CboTipoTransaccion.Enabled = False
                Blank()
                GenerarColummnaDataTable()
                'pnl_pedido.Visible = True
                dgv_cab_ped.DataSource = Nothing
                gbCabecera.Enabled = False
                btnPedidos.Enabled = True
                CboTipoTransaccion.Enabled = True
                'MostrandoDocumentoPedidos()
                gbOpciones.Enabled = False
            Else
                pnl_pedido.Visible = False
                dtdetalleArticuloPrincipal.Rows.Clear()
                dgv_cab_ped.DataSource = Nothing
                gbCabecera.Enabled = True
                gbOpciones.Enabled = True
                btnPedidos.Enabled = False

            End If

        End If
    End Sub

    Private Sub MostrandoDocumentoPedidos()
        Try
            Dim FacturaBl As New ClsOperaciones.RECEIVABLE
            dtDetalleFact = New DataTable("Documento_Pedidos")
            dtv = New DataView
            dtDetalleFact = FacturaBl.Documento_pedido()
            dtv = dtDetalleFact.DefaultView
            STRordenPedido = ""
            If dtDetalleFact.Rows.Count() <> 0 Then
                pnl_pedido.Visible = True
                dgv_cab_ped.DataSource = dtv
                dgv_cab_ped.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRordenPedido = dgv_cab_ped.Columns(0).Name & "+" & dgv_cab_ped.Columns(2).Name & "+" & dgv_cab_ped.Columns(3).Name
                dgv_cab_ped.Columns(1).ReadOnly = True
                dgv_cab_ped.Columns(2).ReadOnly = True
                txt_filtrar_pedido.Text = String.Empty
                txt_filtrar_pedido.Select()
            Else
                MsgBox("No hay documentos para mostrar.", MsgBoxStyle.Information, "Sistemas")
                pnl_pedido.Visible = False
                GenerarColummnaDataTable()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoDocumentoPedidos(ByVal Tipo_Pedido As String)
        Try
            Dim FacturaBl As New ClsOperaciones.RECEIVABLE
            dtDetalleFact = New DataTable("Documento_Pedidos")
            dtv = New DataView
            dtDetalleFact = FacturaBl.Documento_pedido(Tipo_Pedido)
            dtv = dtDetalleFact.DefaultView
            STRordenPedido = ""
            If dtDetalleFact.Rows.Count() <> 0 Then
                pnl_pedido.Visible = True
                dgv_cab_ped.DataSource = dtv
                dgv_cab_ped.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRordenPedido = dgv_cab_ped.Columns(0).Name & "+" & dgv_cab_ped.Columns(2).Name & "+" & dgv_cab_ped.Columns(3).Name
                dgv_cab_ped.Columns(1).ReadOnly = True
                dgv_cab_ped.Columns(2).ReadOnly = True
                txt_filtrar_pedido.Text = String.Empty
                txt_filtrar_pedido.Select()
            Else
                MsgBox("No hay documentos para mostrar.", MsgBoxStyle.Information, "Sistemas")
                pnl_pedido.Visible = False
                GenerarColummnaDataTable()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_filtrar_pedido_TextChanged(sender As Object, e As EventArgs) Handles txt_filtrar_pedido.TextChanged
        If STRordenPedido = "" Then Exit Sub

        Dim wbusqueda As String = UCase(txt_filtrar_pedido.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRordenPedido & " like '%" & txt_filtrar_pedido.Text & "%'"
        myCurrencyManager.Position = INTnewpos
    End Sub

    Private Sub btn_salir_pedido_Click(sender As Object, e As EventArgs) Handles btn_salir_pedido.Click
        pnl_pedido.Visible = False
        dgv_cab_ped.DataSource = Nothing
        txt_filtrar_pedido.Text = String.Empty
        gbCabecera.Enabled = True
        '  gbOpciones.Enabled = True

    End Sub

    Private Sub btn_ok_pedido_Click(sender As Object, e As EventArgs) Handles btn_ok_pedido.Click
        Try
            If dgv_cab_ped.Rows.Count() = 0 Then Exit Sub
            If dgv_cab_ped.CurrentRow Is Nothing Then Exit Sub
            Dim CODIGO As String = ""
            Dim Contacto_Nombres As String = String.Empty
            Dim Contacto_DNI As String = String.Empty
            Dim Contacto_Celular As String = String.Empty

            CODIGO = dgv_cab_ped.Item(0, dgv_cab_ped.CurrentRow.Index).Value
            If CODIGO = "" Then Exit Sub
            Dim facturabl As ClsOperaciones.RECEIVABLE
            facturabl = New ClsOperaciones.RECEIVABLE
            Dim dt_pedido_cab As New DataTable

            Me.Cursor = Cursors.WaitCursor
            dt_pedido_cab = facturabl.Muestra_cabecera_pedido(CODIGO)
            If dt_pedido_cab.Rows.Count() <> 0 Then
                gbCabecera.Enabled = True
                txt_numero_pedido.Text = dt_pedido_cab.Rows(0).Item("ID").ToString
                txt_cod_cli.Text = dt_pedido_cab.Rows(0).Item("CUSTOMER_ID").ToString
                txt_des_cli.Text = dt_pedido_cab.Rows(0).Item("CUSTOMER_NAME").ToString
                lbl_dir_entrega.Text = dt_pedido_cab.Rows(0).Item("GUIA").ToString
                txt_dir_entrega.Text = txt_cod_cli.Text
                txtorderCompra.Text = dt_pedido_cab.Rows(0).Item("ORDER_PURCHASE").ToString

                txt_cod_empresa_trans.Text = dt_pedido_cab.Rows(0).Item("AGENCIA_TRANSPORTE").ToString
                txt_des_empresa_trans.Text = dt_pedido_cab.Rows(0).Item("AGENCIA_TRANSPORTE_DES").ToString


                If txt_cod_empresa_trans.Text = String.Empty Then
                    rdb_trans_publico.Checked = False
                    rdb_trans_privado.Checked = True
                Else
                    rdb_trans_publico.Checked = True
                    rdb_trans_privado.Checked = False
                End If

                txt_cod_vendedor.Text = dt_pedido_cab.Rows(0).Item("SALES_ID").ToString
                txt_des_vendedor.Text = dt_pedido_cab.Rows(0).Item("VENDEDOR").ToString

                txt_cod_vendedor.Enabled = False
                txt_des_vendedor.Enabled = False

                txt_numero_pedido.Text = CODIGO
                dtdetalleArticuloPrincipal.Rows.Clear()
                
                facturabl = New ClsOperaciones.RECEIVABLE
                dtdetalleArticuloPrincipal = facturabl.Muestra_detalles_pedido_Guias(CODIGO) ', frm_detalles._lista_items)

                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    pnl_pedido.Visible = False
                    txt_filtrar_pedido.Text = String.Empty
                    CboAlmacen.Select()
                Else
                    MsgBox("No hay informacion disponible, en el Detalle", MsgBoxStyle.Critical)
                    gbOpciones.Enabled = False
                End If
                cbo_motivo_traslado.SelectedIndex = 0

                Contacto_Nombres = dt_pedido_cab.Rows(0).Item("Contacto_Nombres").ToString
                Contacto_DNI = dt_pedido_cab.Rows(0).Item("Contacto_DNI").ToString
                Contacto_Celular = dt_pedido_cab.Rows(0).Item("Contacto_Celular").ToString

                Dim textoObservacion As String = Contacto_Nombres

                If textoObservacion.Trim.Length > 0 Then
                    textoObservacion = "Contacto: " & Contacto_Nombres
                    If Not String.IsNullOrWhiteSpace(Contacto_DNI) Then
                        textoObservacion &= " - DNI: " & Contacto_DNI
                    End If

                    If Not String.IsNullOrWhiteSpace(Contacto_Celular) Then
                        textoObservacion &= " - Celular: " & Contacto_Celular
                    End If
                    txtComentarios.Text = textoObservacion
                End If

                'Dim frm_pedido_detalle As FrmFacturacion_Detalle_Pedido
                'frm_pedido_detalle = New FrmFacturacion_Detalle_Pedido
                'frm_pedido_detalle._numero_pedido = txt_numero_pedido.Text
                'frm_pedido_detalle.ShowDialog()

            End If

            
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub btn_descargar_archivos_Click(sender As Object, e As EventArgs) Handles btn_descargar_archivos.Click
        If dgvDocumentosGuias.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Ref_idalamacen = String.Empty
            Ref_documentid = String.Empty
            Ref_numerodocument = String.Empty
            Dim _fecha As Date = dgvDocumentosGuias.CurrentRow.Cells("Fecha").Value
            'Validacione Generales Reporte y consulta
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub

            Dim StrNomArchivo_PDF As String = ""
            Dim StrNomArchivo_XML As String = ""
            Dim StrNomArchivo_CDR As String = ""

            If Strings.Left(Ref_numerodocument, 1) = "T" Then
                Dim _ruta As String = ""
                Dim Carpeta As New FolderBrowserDialog
                If Carpeta.ShowDialog() = DialogResult.OK Then
                    _ruta = Carpeta.SelectedPath.ToString
                Else
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                        Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & _
                                        "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".pdf"

                If File.Exists(StrNomArchivo_PDF) Then
                    If Copiar_Archivos(StrNomArchivo_PDF, _ruta) = False Then
                        Me.Cursor = Cursors.Default
                        MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".PDF" & Chr(13) &
                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        Exit Sub
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".pdf"
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                End If

                StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                        Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & _
                                        "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".xml"

                If File.Exists(StrNomArchivo_XML) = True Then
                    If Copiar_Archivos(StrNomArchivo_XML, _ruta) = False Then
                        Me.Cursor = Cursors.Default
                        MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".XML" & Chr(13) &
                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        Exit Sub
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".xml"
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                End If

                'StrNomArchivo_CDR = Ruta_FE_Verificacion() & "CDR\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                '                        Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & _
                '                        "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".xml"

                'If File.Exists(StrNomArchivo_CDR) = True Then
                '    If Copiar_Archivos(StrNomArchivo_CDR, _ruta) = False Then
                '        Me.Cursor = Cursors.Default
                '        MsgBox("ERROR:" & Chr(13) & "El documento CDR R-09-" & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".XML" & Chr(13) &
                '               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")

                '        Exit Sub
                '    End If
                'Else
                '    Me.Cursor = Cursors.Default
                '    Dim msj As String = ""
                '    msj = String.Empty
                '    msj = "No existe el archivo " & vbCrLf & "R-" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(Ref_numerodocument, Strings.Len(Ref_numerodocument) - 7) & "-" & Format(CInt(Strings.Right(Ref_numerodocument, 7)), "00000000") & ".xml"
                '    MsgBox(msj, MsgBoxStyle.Information)
                '    Exit Sub
                'End If

                MsgBox("CPE descargados correctamente.", MsgBoxStyle.Information, "Sistemas")

            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_sincronizar_cpe_Click(sender As Object, e As EventArgs) Handles btn_sincronizar_cpe.Click
        If dgvDocumentosGuias.Rows.Count = 0 Then Exit Sub

        Dim Ref_DOCUMENT_ID As String, Ref_idalamacen As String, Ref_NUMBER_DOCUMENT As String
        Dim _fecha_doc As Date


        Try
            Me.Cursor = Cursors.WaitCursor

            For Each item As DataRow In dtDocumentoGuias.Rows
                dtDocumentoGuias.BeginInit()

                Ref_idalamacen = item("Codigo")
                Ref_DOCUMENT_ID = item("Tipo")
                Ref_NUMBER_DOCUMENT = item("Numero_Doc")
                _fecha_doc = item("Fecha")

                Dim StrNomArchivo_PDF As String = ""
                Dim StrNomArchivo_XML As String = ""
                If Strings.Left(Ref_NUMBER_DOCUMENT, 1) = "T" Then

                    'VERIFICAMOS SI SE ENCUENTRA EN LA RUTA DEL SERVIDOR
                    StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                        Strings.Left(Ref_NUMBER_DOCUMENT, Strings.Len(Ref_NUMBER_DOCUMENT) - 7) & _
                                        "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"

                    If File.Exists(StrNomArchivo_PDF) Then
                        item("SINCRONIZADO") = "Si"
                    Else
                        StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                        _fecha_doc.Year.ToString & "\" &
                                        Format(_fecha_doc.Month, "00") & "\" &
                                        Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
                                        Strings.Left(Ref_NUMBER_DOCUMENT, Strings.Len(Ref_NUMBER_DOCUMENT) - 7) & "-" &
                                        Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"

                        If File.Exists(StrNomArchivo_PDF) Then
                            If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = True Then
                                item("SINCRONIZADO") = "Si"
                            Else
                                item("SINCRONIZADO") = ""
                            End If
                        Else
                            item("SINCRONIZADO") = ""
                        End If
                    End If


                    'VERIFICAMOS SI SE ENCUENTRA EN LA RUTA DEL SERVIDOR
                    StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                        Strings.Left(Ref_NUMBER_DOCUMENT, Strings.Len(Ref_NUMBER_DOCUMENT) - 7) & _
                                        "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"

                    If File.Exists(StrNomArchivo_XML) Then
                        item("SINCRONIZADO_XML") = "Si"
                    Else
                        StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                        _fecha_doc.Year.ToString & "\" &
                                        Format(_fecha_doc.Month, "00") & "\" &
                                        Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" &
                                        Strings.Left(Ref_NUMBER_DOCUMENT, Strings.Len(Ref_NUMBER_DOCUMENT) - 7) & "-" &
                                        Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                        If File.Exists(StrNomArchivo_XML) Then
                            If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = True Then
                                item("SINCRONIZADO_XML") = "Si"
                            Else
                                item("SINCRONIZADO_XML") = ""
                            End If
                        Else
                            item("SINCRONIZADO_XML") = ""
                        End If
                    End If
                End If

                dtDocumentoGuias.EndInit()
                dtDocumentoGuias.AcceptChanges()
            Next

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_dir_partida_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_dir_partida.MouseDoubleClick
        Call Ayuda_Dir_Partida(txt_cod_dir_partida.Text.Trim)
    End Sub

    Private Sub txt_cod_dir_partida_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_dir_partida.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call Ayuda_Dir_Partida(txt_cod_dir_partida.Text.Trim)
        End If
    End Sub

    Private Sub Ayuda_Dir_Partida(ByVal _cod_cliente As String)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SP_S_DIRECCION_PARTIDA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = _cod_cliente
            frm.Titulo = "Dirección de Partida"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_dir_partida.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lbl_desc_dir_partida.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Dim CodigoTransaccion As String = String.Empty
        CodigoTransaccion = CboTipoTransaccion.SelectedValue.ToString

        If CodigoTransaccion = "" Then
            MessageBox.Show("Debe elegir una transacción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        MostrandoDocumentoPedidos(CodigoTransaccion)
    End Sub

    Private Sub btnPdfOrdenCompra_Click(sender As Object, e As EventArgs) Handles btnPdfOrdenCompra.Click
        'ordencompra
        If txtorderCompra.Text <> String.Empty Then
            Dim dtdocumentoPrin As DataTable
            dtdocumentoPrin = New DataTable

            Dim clsPedidoBl As ClsOperaciones.ORDERS
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtdocumentoPrin = clsPedidoBl.Mostrar_OrdenCompra_Pedido(txt_numero_pedido.Text)

            If dtdocumentoPrin IsNot Nothing AndAlso dtdocumentoPrin.Rows.Count > 0 Then
                If dtdocumentoPrin.Rows(0)("Archivo") IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(dtdocumentoPrin.Rows(0)("Archivo").ToString()) Then

                    Dim archivoBytes As Byte() = CType(dtdocumentoPrin.Rows(0)("Archivo"), Byte())
                    'Dim rutaDestino As String = Ruta_Reportes() & "\OC"
                    'Dim nombreArchivo As String = "Orden_" & txtorderCompra.Text & ".pdf" ' o extraído si está disponible

                    Dim rutaDestino As String = Path.GetTempPath()
                    Dim nombreArchivo As String = "Orden_" & txtorderCompra.Text & DateTime.Now.ToString("HHmmss") & ".pdf" ' o extraído si está disponible


                    Dim rutaCompleta As String = Path.Combine(rutaDestino, nombreArchivo)
                    File.WriteAllBytes(rutaCompleta, archivoBytes)

                    Try
                        ' Opcional: Abrir el PDF
                        Process.Start(rutaCompleta)
                    Catch ex As Exception
                        MessageBox.Show("Error al recuperar PDF: " & ex.Message)
                    End Try

                End If
            End If
        End If
    End Sub
End Class