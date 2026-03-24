<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacionRapida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacionRapida))
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_modificar = New System.Windows.Forms.ToolStripButton()
        Me.btn_aprobar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_imprimir_tk = New System.Windows.Forms.ToolStripButton()
        Me.btn_deshacer_aprobar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cotizacion = New System.Windows.Forms.ToolStripButton()
        Me.btnAnular = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_imprimir_fc = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rbVariaslineasDoc = New System.Windows.Forms.RadioButton()
        Me.rbunalineaDoc = New System.Windows.Forms.RadioButton()
        Me.txtGlosa = New System.Windows.Forms.RichTextBox()
        Me.gbTipoGuia = New System.Windows.Forms.GroupBox()
        Me.rbVariaslineas = New System.Windows.Forms.RadioButton()
        Me.rbunalinea = New System.Windows.Forms.RadioButton()
        Me.txtGlosaGuia = New System.Windows.Forms.RichTextBox()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.chkSinOC = New System.Windows.Forms.CheckBox()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.dtpFechaRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.dtpHoraRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.GrpContacto = New System.Windows.Forms.GroupBox()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.txtContactoNombres = New System.Windows.Forms.TextBox()
        Me.txtContactoCelular = New System.Windows.Forms.TextBox()
        Me.txtContactoDNI = New System.Windows.Forms.TextBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.txtDireccionEntregaCliente = New System.Windows.Forms.TextBox()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.txtNumeroOrdenCompra = New System.Windows.Forms.TextBox()
        Me.btnOrdenCompra = New System.Windows.Forms.Button()
        Me.cboTipoPedido = New System.Windows.Forms.ComboBox()
        Me.lblTipoPedido = New System.Windows.Forms.Label()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.txt_validez_oferta = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txt_desc_tipo_nota_electronica = New System.Windows.Forms.TextBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.txt_tip_nota_electronica = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnclientenuevo = New System.Windows.Forms.Button()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.txt_trama = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_Empresa = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txt_vehiculo = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.rbDocRef_varios = New System.Windows.Forms.RadioButton()
        Me.rbDocRef_uno = New System.Windows.Forms.RadioButton()
        Me.GbdetalleDocumento = New System.Windows.Forms.GroupBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtdetalleguiaserie = New System.Windows.Forms.TextBox()
        Me.txtdetalleserie = New System.Windows.Forms.TextBox()
        Me.txtNumeroCP = New System.Windows.Forms.TextBox()
        Me.txtdetalleguianumero = New System.Windows.Forms.TextBox()
        Me.txtSerieCP = New System.Windows.Forms.TextBox()
        Me.txtcodigoCP = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtdetallenumero = New System.Windows.Forms.TextBox()
        Me.txtdetalleguiadoc = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtdetalledoc = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtSerieDocRef = New System.Windows.Forms.TextBox()
        Me.txttipoDocRef = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.checkSinGuia = New System.Windows.Forms.CheckBox()
        Me.lblAlmacen = New System.Windows.Forms.TextBox()
        Me.txtAlmacen = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboDirEntrega = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtordenCompra = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtcotizacion = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtNumDocRef = New System.Windows.Forms.TextBox()
        Me.chkSinIGV = New System.Windows.Forms.CheckBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtpedido = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtdescripcionTrama = New System.Windows.Forms.TextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.txtcodigoTrama = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtdescripcionTransportista = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txtcodigoTransporte = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdescVehiculo = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtcodigoVehiculo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescEsp = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.TextBox()
        Me.txtdescCli = New System.Windows.Forms.TextBox()
        Me.lblFormaPago = New System.Windows.Forms.TextBox()
        Me.txtNomTrans = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblPtoVenta = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cbSerieGuia = New System.Windows.Forms.ComboBox()
        Me.cboSerieDoc = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtRucDni = New System.Windows.Forms.TextBox()
        Me.txtCod_Cliente = New System.Windows.Forms.TextBox()
        Me.txtPtoVenta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodTrans = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.rdb_f_a4 = New System.Windows.Forms.RadioButton()
        Me.rdb_f_ticket = New System.Windows.Forms.RadioButton()
        Me.chk_facturar_obsequio = New System.Windows.Forms.CheckBox()
        Me.gbTipoFacturacion = New System.Windows.Forms.GroupBox()
        Me.rb_facturar_devolucion = New System.Windows.Forms.RadioButton()
        Me.rb_facturar_pedido = New System.Windows.Forms.RadioButton()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.rbFacturaRepMedico = New System.Windows.Forms.RadioButton()
        Me.rbFacturaExistencias = New System.Windows.Forms.RadioButton()
        Me.rbFacturaGuiaVenta = New System.Windows.Forms.RadioButton()
        Me.rbFacturaDirecta = New System.Windows.Forms.RadioButton()
        Me.rbsinDescargo = New System.Windows.Forms.RadioButton()
        Me.gbdetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtredondeo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.lblFechaCreacion = New System.Windows.Forms.Label()
        Me.lblusuarioId = New System.Windows.Forms.Label()
        Me.TxtFechaCreacion = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblDetalle = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.dgvDocumentosFactura = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.pnl_ref = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.dtp_fec_doc_ref = New System.Windows.Forms.DateTimePicker()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txt_numero_ref_doc = New System.Windows.Forms.TextBox()
        Me.txt_serie_ref_doc = New System.Windows.Forms.TextBox()
        Me.txt_tipo_doc_ref = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GrpAgregarProductos = New System.Windows.Forms.GroupBox()
        Me.chkigv = New System.Windows.Forms.CheckBox()
        Me.txtcantidad_fraccion = New System.Windows.Forms.TextBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.txtprecioUnitario_fraccion = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.txt_numero_lote = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.txt_por_Des = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btn_agregar_carrito = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtprecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.txtIsc = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtBruto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtvalorVenta = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GrpProductos = New System.Windows.Forms.GroupBox()
        Me.dgv_lista_productos = New System.Windows.Forms.DataGridView()
        Me.txt_buscador_productos = New System.Windows.Forms.TextBox()
        Me.txt_buscador_especial = New System.Windows.Forms.TextBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.TextBox47 = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.PictureBox27 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.TextBox61 = New System.Windows.Forms.TextBox()
        Me.pnl_motivo_anulacion = New System.Windows.Forms.Panel()
        Me.txt_motivo_anulacion = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_anulacion = New System.Windows.Forms.DateTimePicker()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.pnl_cierre_ventas = New System.Windows.Forms.Panel()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.gb_pago_tarjeta = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.AMOUNT_AMERICAN_EXPRES = New System.Windows.Forms.TextBox()
        Me.AMOUNT_DINERS = New System.Windows.Forms.TextBox()
        Me.AMOUNT_CARD_MASTER = New System.Windows.Forms.TextBox()
        Me.AMOUNT_CARD_VISA = New System.Windows.Forms.TextBox()
        Me.gb_pago_efectivo = New System.Windows.Forms.GroupBox()
        Me.TxEfeDol = New System.Windows.Forms.TextBox()
        Me.txt_saldo_final = New System.Windows.Forms.TextBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.lbl_usuario_cierre = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.dtp_fecha_cierre_ventas = New System.Windows.Forms.DateTimePicker()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.pnlNuevaPlanilla = New System.Windows.Forms.Panel()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.gb_nueva_planilla = New System.Windows.Forms.GroupBox()
        Me.lbl_nombre_usuario = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.txt_saldo_inicial_caja = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.btn_cancelar_crear = New System.Windows.Forms.Button()
        Me.btn_crear_planilla = New System.Windows.Forms.Button()
        Me.dtp_fec_nueva_pla = New System.Windows.Forms.DateTimePicker()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.GrpObservaciones = New System.Windows.Forms.GroupBox()
        Me.txt_obs_general = New System.Windows.Forms.TextBox()
        Me.GrpRecepcionTercero = New System.Windows.Forms.GroupBox()
        Me.txt_recepcion_tercero = New System.Windows.Forms.TextBox()
        Me.GrpLugarEntrega = New System.Windows.Forms.GroupBox()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.txtDireccionTransportista = New System.Windows.Forms.TextBox()
        Me.txtLocalDescripcion = New System.Windows.Forms.TextBox()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.txtDireccionTransportistaDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDireccionAgencia = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.rdb_opt_Lima = New System.Windows.Forms.RadioButton()
        Me.rdb_opt_agencia = New System.Windows.Forms.RadioButton()
        Me.rdb_opt_domicilio = New System.Windows.Forms.RadioButton()
        Me.rdb_opt_recojo = New System.Windows.Forms.RadioButton()
        Me.chk_efectivo = New System.Windows.Forms.CheckBox()
        Me.chk_transferencia = New System.Windows.Forms.CheckBox()
        Me.chk_letra_2 = New System.Windows.Forms.CheckBox()
        Me.chk_factura_2 = New System.Windows.Forms.CheckBox()
        Me.chk_guia_2 = New System.Windows.Forms.CheckBox()
        Me.lblModoPago = New System.Windows.Forms.TextBox()
        Me.txtModoPago = New System.Windows.Forms.TextBox()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.txt_n_operacion = New System.Windows.Forms.TextBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.txt_des_transferencia = New System.Windows.Forms.TextBox()
        Me.txt_cod_transferencia = New System.Windows.Forms.TextBox()
        Me.chk_cheque = New System.Windows.Forms.CheckBox()
        Me.rdb_domicilio = New System.Windows.Forms.RadioButton()
        Me.rdb_agencia = New System.Windows.Forms.RadioButton()
        Me.txt_guia = New System.Windows.Forms.TextBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.txt_des_agencia_trans = New System.Windows.Forms.TextBox()
        Me.txt_cod_agencia_trans = New System.Windows.Forms.TextBox()
        Me.txt_provincia = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.PictureBox28 = New System.Windows.Forms.PictureBox()
        Me.PictureBox29 = New System.Windows.Forms.PictureBox()
        Me.PictureBox30 = New System.Windows.Forms.PictureBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.PictureBox31 = New System.Windows.Forms.PictureBox()
        Me.PictureBox32 = New System.Windows.Forms.PictureBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.TextBox53 = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.TextBox55 = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
        Me.TextBox57 = New System.Windows.Forms.TextBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.TextBox59 = New System.Windows.Forms.TextBox()
        Me.TextBox60 = New System.Windows.Forms.TextBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.PictureBox33 = New System.Windows.Forms.PictureBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.TextBox64 = New System.Windows.Forms.TextBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.TextBox65 = New System.Windows.Forms.TextBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.TextBox66 = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.TextBox68 = New System.Windows.Forms.TextBox()
        Me.PictureBox34 = New System.Windows.Forms.PictureBox()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.PictureBox35 = New System.Windows.Forms.PictureBox()
        Me.TextBox71 = New System.Windows.Forms.TextBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.TextBox72 = New System.Windows.Forms.TextBox()
        Me.PictureBox36 = New System.Windows.Forms.PictureBox()
        Me.TextBox73 = New System.Windows.Forms.TextBox()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.TextBox74 = New System.Windows.Forms.TextBox()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.TextBox75 = New System.Windows.Forms.TextBox()
        Me.TextBox76 = New System.Windows.Forms.TextBox()
        Me.TextBox78 = New System.Windows.Forms.TextBox()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.PictureBox37 = New System.Windows.Forms.PictureBox()
        Me.PictureBox38 = New System.Windows.Forms.PictureBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.TextBox82 = New System.Windows.Forms.TextBox()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.TextBox88 = New System.Windows.Forms.TextBox()
        Me.txt_lt_ft = New System.Windows.Forms.TextBox()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.panel_cliente_nuevo = New System.Windows.Forms.Panel()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.txt_des_vendedor = New System.Windows.Forms.TextBox()
        Me.txt_cod_vendedor = New System.Windows.Forms.TextBox()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.txt_des_forma_pago = New System.Windows.Forms.TextBox()
        Me.txt_cod_forma_pago = New System.Windows.Forms.TextBox()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_des_distrito = New System.Windows.Forms.TextBox()
        Me.txt_cod_distrito = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txt_des_provincia = New System.Windows.Forms.TextBox()
        Me.txt_cod_provincia = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txt_des_departamento = New System.Windows.Forms.TextBox()
        Me.txt_cod_departamento = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txt_Celular = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_ubigeo = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cmb_tip_doc_per = New System.Windows.Forms.ComboBox()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_ruc_dni = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_cod_cliente = New System.Windows.Forms.TextBox()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btn_cancelar_nuevo_cliente = New System.Windows.Forms.Button()
        Me.btn_grabar_nuevo_cliente = New System.Windows.Forms.Button()
        Me.gb_picking = New System.Windows.Forms.GroupBox()
        Me.lbl_texto_picking = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout
        Me.GroupBox8.SuspendLayout
        Me.gbTipoGuia.SuspendLayout
        Me.GbCabecera.SuspendLayout
        Me.GrpContacto.SuspendLayout
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GbdetalleDocumento.SuspendLayout
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbTipoFacturacion.SuspendLayout
        Me.gbdetalle.SuspendLayout
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbOpciones.SuspendLayout
        Me.pnlPrincipal.SuspendLayout
        Me.GroupBox3.SuspendLayout
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.gbRangofechas.SuspendLayout
        Me.pnl_ref.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GrpAgregarProductos.SuspendLayout
        Me.GroupBox6.SuspendLayout
        Me.GrpProductos.SuspendLayout
        CType(Me.dgv_lista_productos, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_motivo_anulacion.SuspendLayout
        Me.GroupBox19.SuspendLayout
        Me.pnl_cierre_ventas.SuspendLayout
        Me.GroupBox9.SuspendLayout
        Me.gb_pago_tarjeta.SuspendLayout
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gb_pago_efectivo.SuspendLayout
        Me.pnlNuevaPlanilla.SuspendLayout
        Me.gb_nueva_planilla.SuspendLayout
        Me.GrpObservaciones.SuspendLayout
        Me.GrpRecepcionTercero.SuspendLayout
        Me.GrpLugarEntrega.SuspendLayout
        Me.GroupBox13.SuspendLayout
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox12.SuspendLayout
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).BeginInit
        Me.panel_cliente_nuevo.SuspendLayout
        Me.GroupBox14.SuspendLayout
        Me.gb_picking.SuspendLayout
        Me.SuspendLayout
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btn_modificar, Me.btn_aprobar, Me.btnEliminar, Me.btn_imprimir_tk, Me.btnCancelar, Me.btn_deshacer_aprobar, Me.btn_cotizacion, Me.btnAnular, Me.btnImprimir, Me.btn_imprimir_fc, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1214, 25)
        Me.ToolStrip1.TabIndex = 182
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 22)
        Me.btnConsultar.Text = "C&onsultar"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(73, 22)
        Me.btnGrabar.Text = "&Guardar"
        '
        'btn_modificar
        '
        Me.btn_modificar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(79, 22)
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.Visible = False
        '
        'btn_aprobar
        '
        Me.btn_aprobar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_aprobar.Image = CType(resources.GetObject("btn_aprobar.Image"), System.Drawing.Image)
        Me.btn_aprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_aprobar.Name = "btn_aprobar"
        Me.btn_aprobar.Size = New System.Drawing.Size(114, 22)
        Me.btn_aprobar.Text = "Aprobar Pedido"
        Me.btn_aprobar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 22)
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.Visible = False
        '
        'btn_imprimir_tk
        '
        Me.btn_imprimir_tk.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_imprimir_tk.Image = CType(resources.GetObject("btn_imprimir_tk.Image"), System.Drawing.Image)
        Me.btn_imprimir_tk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_imprimir_tk.Name = "btn_imprimir_tk"
        Me.btn_imprimir_tk.Size = New System.Drawing.Size(129, 22)
        Me.btn_imprimir_tk.Text = "Imprimir Form. TK"
        '
        'btn_deshacer_aprobar
        '
        Me.btn_deshacer_aprobar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_deshacer_aprobar.Image = CType(resources.GetObject("btn_deshacer_aprobar.Image"), System.Drawing.Image)
        Me.btn_deshacer_aprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deshacer_aprobar.Name = "btn_deshacer_aprobar"
        Me.btn_deshacer_aprobar.Size = New System.Drawing.Size(170, 22)
        Me.btn_deshacer_aprobar.Text = "Deshacer Aprobar Pedido"
        Me.btn_deshacer_aprobar.Visible = False
        '
        'btn_cotizacion
        '
        Me.btn_cotizacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cotizacion.Image = CType(resources.GetObject("btn_cotizacion.Image"), System.Drawing.Image)
        Me.btn_cotizacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cotizacion.Name = "btn_cotizacion"
        Me.btn_cotizacion.Size = New System.Drawing.Size(138, 22)
        Me.btn_cotizacion.Text = "Adjuntar Cotización"
        Me.btn_cotizacion.Visible = False
        '
        'btnAnular
        '
        Me.btnAnular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(64, 22)
        Me.btnAnular.Text = "&Anular"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(77, 22)
        Me.btnImprimir.Text = "&Imprimir"
        '
        'btn_imprimir_fc
        '
        Me.btn_imprimir_fc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_imprimir_fc.Image = CType(resources.GetObject("btn_imprimir_fc.Image"), System.Drawing.Image)
        Me.btn_imprimir_fc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_imprimir_fc.Name = "btn_imprimir_fc"
        Me.btn_imprimir_fc.Size = New System.Drawing.Size(154, 22)
        Me.btn_imprimir_fc.Text = "Imprimir Form. Cliente"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.rbVariaslineasDoc)
        Me.GroupBox8.Controls.Add(Me.rbunalineaDoc)
        Me.GroupBox8.Controls.Add(Me.txtGlosa)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(1256, 317)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(194, 37)
        Me.GroupBox8.TabIndex = 186
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "&Tipo de la Glosa del Documento"
        Me.GroupBox8.Visible = False
        '
        'rbVariaslineasDoc
        '
        Me.rbVariaslineasDoc.AutoSize = True
        Me.rbVariaslineasDoc.ForeColor = System.Drawing.Color.Navy
        Me.rbVariaslineasDoc.Location = New System.Drawing.Point(104, 15)
        Me.rbVariaslineasDoc.Name = "rbVariaslineasDoc"
        Me.rbVariaslineasDoc.Size = New System.Drawing.Size(84, 17)
        Me.rbVariaslineasDoc.TabIndex = 1
        Me.rbVariaslineasDoc.Text = "&Varias lineas"
        Me.rbVariaslineasDoc.UseVisualStyleBackColor = True
        '
        'rbunalineaDoc
        '
        Me.rbunalineaDoc.AutoSize = True
        Me.rbunalineaDoc.Checked = True
        Me.rbunalineaDoc.ForeColor = System.Drawing.Color.Navy
        Me.rbunalineaDoc.Location = New System.Drawing.Point(7, 15)
        Me.rbunalineaDoc.Name = "rbunalineaDoc"
        Me.rbunalineaDoc.Size = New System.Drawing.Size(92, 17)
        Me.rbunalineaDoc.TabIndex = 0
        Me.rbunalineaDoc.TabStop = True
        Me.rbunalineaDoc.Text = "&Una sola linea"
        Me.rbunalineaDoc.UseVisualStyleBackColor = True
        '
        'txtGlosa
        '
        Me.txtGlosa.BackColor = System.Drawing.Color.White
        Me.txtGlosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGlosa.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGlosa.Location = New System.Drawing.Point(192, 10)
        Me.txtGlosa.MaxLength = 355
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtGlosa.Size = New System.Drawing.Size(706, 23)
        Me.txtGlosa.TabIndex = 18
        Me.txtGlosa.Text = ""
        '
        'gbTipoGuia
        '
        Me.gbTipoGuia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTipoGuia.Controls.Add(Me.rbVariaslineas)
        Me.gbTipoGuia.Controls.Add(Me.rbunalinea)
        Me.gbTipoGuia.Controls.Add(Me.txtGlosaGuia)
        Me.gbTipoGuia.ForeColor = System.Drawing.Color.Navy
        Me.gbTipoGuia.Location = New System.Drawing.Point(1256, 356)
        Me.gbTipoGuia.Name = "gbTipoGuia"
        Me.gbTipoGuia.Size = New System.Drawing.Size(194, 37)
        Me.gbTipoGuia.TabIndex = 185
        Me.gbTipoGuia.TabStop = False
        Me.gbTipoGuia.Text = "&Tipo de la Glosa de la Guia"
        Me.gbTipoGuia.Visible = False
        '
        'rbVariaslineas
        '
        Me.rbVariaslineas.AutoSize = True
        Me.rbVariaslineas.ForeColor = System.Drawing.Color.Navy
        Me.rbVariaslineas.Location = New System.Drawing.Point(104, 13)
        Me.rbVariaslineas.Name = "rbVariaslineas"
        Me.rbVariaslineas.Size = New System.Drawing.Size(84, 17)
        Me.rbVariaslineas.TabIndex = 1
        Me.rbVariaslineas.Text = "&Varias lineas"
        Me.rbVariaslineas.UseVisualStyleBackColor = True
        '
        'rbunalinea
        '
        Me.rbunalinea.AutoSize = True
        Me.rbunalinea.Checked = True
        Me.rbunalinea.ForeColor = System.Drawing.Color.Navy
        Me.rbunalinea.Location = New System.Drawing.Point(7, 15)
        Me.rbunalinea.Name = "rbunalinea"
        Me.rbunalinea.Size = New System.Drawing.Size(92, 17)
        Me.rbunalinea.TabIndex = 0
        Me.rbunalinea.TabStop = True
        Me.rbunalinea.Text = "&Una sola linea"
        Me.rbunalinea.UseVisualStyleBackColor = True
        '
        'txtGlosaGuia
        '
        Me.txtGlosaGuia.BackColor = System.Drawing.Color.White
        Me.txtGlosaGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGlosaGuia.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtGlosaGuia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGlosaGuia.Location = New System.Drawing.Point(192, 9)
        Me.txtGlosaGuia.MaxLength = 355
        Me.txtGlosaGuia.Name = "txtGlosaGuia"
        Me.txtGlosaGuia.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtGlosaGuia.Size = New System.Drawing.Size(706, 23)
        Me.txtGlosaGuia.TabIndex = 19
        Me.txtGlosaGuia.Text = " "
        '
        'GbCabecera
        '
        Me.GbCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.chkSinOC)
        Me.GbCabecera.Controls.Add(Me.txtDireccionCliente)
        Me.GbCabecera.Controls.Add(Me.dtpFechaRecepcion)
        Me.GbCabecera.Controls.Add(Me.Label141)
        Me.GbCabecera.Controls.Add(Me.dtpHoraRecepcion)
        Me.GbCabecera.Controls.Add(Me.dtpFechaEntrega)
        Me.GbCabecera.Controls.Add(Me.Label140)
        Me.GbCabecera.Controls.Add(Me.GrpContacto)
        Me.GbCabecera.Controls.Add(Me.txtDireccionEntregaCliente)
        Me.GbCabecera.Controls.Add(Me.Label139)
        Me.GbCabecera.Controls.Add(Me.Label135)
        Me.GbCabecera.Controls.Add(Me.txtNumeroOrdenCompra)
        Me.GbCabecera.Controls.Add(Me.btnOrdenCompra)
        Me.GbCabecera.Controls.Add(Me.cboTipoPedido)
        Me.GbCabecera.Controls.Add(Me.lblTipoPedido)
        Me.GbCabecera.Controls.Add(Me.Label131)
        Me.GbCabecera.Controls.Add(Me.txt_validez_oferta)
        Me.GbCabecera.Controls.Add(Me.Label99)
        Me.GbCabecera.Controls.Add(Me.Label98)
        Me.GbCabecera.Controls.Add(Me.txt_desc_tipo_nota_electronica)
        Me.GbCabecera.Controls.Add(Me.PictureBox13)
        Me.GbCabecera.Controls.Add(Me.txt_tip_nota_electronica)
        Me.GbCabecera.Controls.Add(Me.Label43)
        Me.GbCabecera.Controls.Add(Me.Button5)
        Me.GbCabecera.Controls.Add(Me.btnclientenuevo)
        Me.GbCabecera.Controls.Add(Me.PictureBox12)
        Me.GbCabecera.Controls.Add(Me.PictureBox11)
        Me.GbCabecera.Controls.Add(Me.PictureBox10)
        Me.GbCabecera.Controls.Add(Me.txt_trama)
        Me.GbCabecera.Controls.Add(Me.Label51)
        Me.GbCabecera.Controls.Add(Me.txt_Empresa)
        Me.GbCabecera.Controls.Add(Me.Label50)
        Me.GbCabecera.Controls.Add(Me.txt_vehiculo)
        Me.GbCabecera.Controls.Add(Me.Label49)
        Me.GbCabecera.Controls.Add(Me.PictureBox3)
        Me.GbCabecera.Controls.Add(Me.PictureBox6)
        Me.GbCabecera.Controls.Add(Me.rbDocRef_varios)
        Me.GbCabecera.Controls.Add(Me.rbDocRef_uno)
        Me.GbCabecera.Controls.Add(Me.GbdetalleDocumento)
        Me.GbCabecera.Controls.Add(Me.Label37)
        Me.GbCabecera.Controls.Add(Me.txtSerieDocRef)
        Me.GbCabecera.Controls.Add(Me.txttipoDocRef)
        Me.GbCabecera.Controls.Add(Me.Label36)
        Me.GbCabecera.Controls.Add(Me.PictureBox9)
        Me.GbCabecera.Controls.Add(Me.checkSinGuia)
        Me.GbCabecera.Controls.Add(Me.lblAlmacen)
        Me.GbCabecera.Controls.Add(Me.txtAlmacen)
        Me.GbCabecera.Controls.Add(Me.Label14)
        Me.GbCabecera.Controls.Add(Me.cboDirEntrega)
        Me.GbCabecera.Controls.Add(Me.Label1)
        Me.GbCabecera.Controls.Add(Me.txtordenCompra)
        Me.GbCabecera.Controls.Add(Me.Label35)
        Me.GbCabecera.Controls.Add(Me.txtcotizacion)
        Me.GbCabecera.Controls.Add(Me.Label34)
        Me.GbCabecera.Controls.Add(Me.txtNumDocRef)
        Me.GbCabecera.Controls.Add(Me.chkSinIGV)
        Me.GbCabecera.Controls.Add(Me.Label33)
        Me.GbCabecera.Controls.Add(Me.txtpedido)
        Me.GbCabecera.Controls.Add(Me.Label32)
        Me.GbCabecera.Controls.Add(Me.txtdescripcionTrama)
        Me.GbCabecera.Controls.Add(Me.PictureBox8)
        Me.GbCabecera.Controls.Add(Me.txtcodigoTrama)
        Me.GbCabecera.Controls.Add(Me.Label31)
        Me.GbCabecera.Controls.Add(Me.txtdescripcionTransportista)
        Me.GbCabecera.Controls.Add(Me.PictureBox7)
        Me.GbCabecera.Controls.Add(Me.txtcodigoTransporte)
        Me.GbCabecera.Controls.Add(Me.Label4)
        Me.GbCabecera.Controls.Add(Me.txtdescVehiculo)
        Me.GbCabecera.Controls.Add(Me.PictureBox5)
        Me.GbCabecera.Controls.Add(Me.txtcodigoVehiculo)
        Me.GbCabecera.Controls.Add(Me.Label2)
        Me.GbCabecera.Controls.Add(Me.txtdescEsp)
        Me.GbCabecera.Controls.Add(Me.Label30)
        Me.GbCabecera.Controls.Add(Me.lblVendedor)
        Me.GbCabecera.Controls.Add(Me.txtdescCli)
        Me.GbCabecera.Controls.Add(Me.lblFormaPago)
        Me.GbCabecera.Controls.Add(Me.txtNomTrans)
        Me.GbCabecera.Controls.Add(Me.Label29)
        Me.GbCabecera.Controls.Add(Me.Label18)
        Me.GbCabecera.Controls.Add(Me.PictureBox2)
        Me.GbCabecera.Controls.Add(Me.lblPtoVenta)
        Me.GbCabecera.Controls.Add(Me.PictureBox4)
        Me.GbCabecera.Controls.Add(Me.cbSerieGuia)
        Me.GbCabecera.Controls.Add(Me.cboSerieDoc)
        Me.GbCabecera.Controls.Add(Me.Label19)
        Me.GbCabecera.Controls.Add(Me.dtpFechaFactura)
        Me.GbCabecera.Controls.Add(Me.cboTipoDoc)
        Me.GbCabecera.Controls.Add(Me.Label20)
        Me.GbCabecera.Controls.Add(Me.cboMoneda)
        Me.GbCabecera.Controls.Add(Me.Label17)
        Me.GbCabecera.Controls.Add(Me.txtFormaPago)
        Me.GbCabecera.Controls.Add(Me.txtTipoCambio)
        Me.GbCabecera.Controls.Add(Me.txtVendedor)
        Me.GbCabecera.Controls.Add(Me.txtDireccion)
        Me.GbCabecera.Controls.Add(Me.txtRazonSocial)
        Me.GbCabecera.Controls.Add(Me.txtRucDni)
        Me.GbCabecera.Controls.Add(Me.txtCod_Cliente)
        Me.GbCabecera.Controls.Add(Me.txtPtoVenta)
        Me.GbCabecera.Controls.Add(Me.Label13)
        Me.GbCabecera.Controls.Add(Me.Label12)
        Me.GbCabecera.Controls.Add(Me.Label11)
        Me.GbCabecera.Controls.Add(Me.Label10)
        Me.GbCabecera.Controls.Add(Me.Label9)
        Me.GbCabecera.Controls.Add(Me.Label8)
        Me.GbCabecera.Controls.Add(Me.Label7)
        Me.GbCabecera.Controls.Add(Me.Label6)
        Me.GbCabecera.Controls.Add(Me.Label5)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.txtCodTrans)
        Me.GbCabecera.Controls.Add(Me.txtcodigo)
        Me.GbCabecera.Controls.Add(Me.rdb_f_a4)
        Me.GbCabecera.Controls.Add(Me.rdb_f_ticket)
        Me.GbCabecera.Controls.Add(Me.chk_facturar_obsequio)
        Me.GbCabecera.Location = New System.Drawing.Point(769, 343)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(437, 311)
        Me.GbCabecera.TabIndex = 183
        Me.GbCabecera.TabStop = False
        '
        'chkSinOC
        '
        Me.chkSinOC.AutoSize = True
        Me.chkSinOC.Location = New System.Drawing.Point(326, 93)
        Me.chkSinOC.Name = "chkSinOC"
        Me.chkSinOC.Size = New System.Drawing.Size(100, 17)
        Me.chkSinOC.TabIndex = 225
        Me.chkSinOC.Text = "Sin Ord.Compra"
        Me.chkSinOC.UseVisualStyleBackColor = True
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccionCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDireccionCliente.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtDireccionCliente.Location = New System.Drawing.Point(94, 162)
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.ReadOnly = True
        Me.txtDireccionCliente.Size = New System.Drawing.Size(33, 21)
        Me.txtDireccionCliente.TabIndex = 224
        Me.txtDireccionCliente.Visible = False
        '
        'dtpFechaRecepcion
        '
        Me.dtpFechaRecepcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRecepcion.Location = New System.Drawing.Point(241, 285)
        Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
        Me.dtpFechaRecepcion.Size = New System.Drawing.Size(105, 21)
        Me.dtpFechaRecepcion.TabIndex = 223
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label141.ForeColor = System.Drawing.Color.Navy
        Me.Label141.Location = New System.Drawing.Point(20, 289)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(215, 13)
        Me.Label141.TabIndex = 222
        Me.Label141.Text = "Fecha y hora de recepción del Pedido"
        Me.Label141.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraRecepcion
        '
        Me.dtpHoraRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraRecepcion.Location = New System.Drawing.Point(349, 284)
        Me.dtpHoraRecepcion.Name = "dtpHoraRecepcion"
        Me.dtpHoraRecepcion.Size = New System.Drawing.Size(77, 23)
        Me.dtpHoraRecepcion.TabIndex = 221
        Me.dtpHoraRecepcion.Value = New Date(2018, 11, 12, 0, 0, 0, 0)
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(321, 234)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(105, 21)
        Me.dtpFechaEntrega.TabIndex = 219
        '
        'Label140
        '
        Me.Label140.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label140.ForeColor = System.Drawing.Color.Navy
        Me.Label140.Location = New System.Drawing.Point(269, 231)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(51, 26)
        Me.Label140.TabIndex = 220
        Me.Label140.Text = "Fecha Entrega"
        Me.Label140.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrpContacto
        '
        Me.GrpContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrpContacto.Controls.Add(Me.Label136)
        Me.GrpContacto.Controls.Add(Me.Label137)
        Me.GrpContacto.Controls.Add(Me.Label138)
        Me.GrpContacto.Controls.Add(Me.txtContactoNombres)
        Me.GrpContacto.Controls.Add(Me.txtContactoCelular)
        Me.GrpContacto.Controls.Add(Me.txtContactoDNI)
        Me.GrpContacto.Controls.Add(Me.CheckBox4)
        Me.GrpContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpContacto.ForeColor = System.Drawing.Color.Navy
        Me.GrpContacto.Location = New System.Drawing.Point(12, 186)
        Me.GrpContacto.Name = "GrpContacto"
        Me.GrpContacto.Size = New System.Drawing.Size(418, 44)
        Me.GrpContacto.TabIndex = 218
        Me.GrpContacto.TabStop = False
        Me.GrpContacto.Text = "CONTACTO"
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label136.ForeColor = System.Drawing.Color.Navy
        Me.Label136.Location = New System.Drawing.Point(207, 25)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(59, 13)
        Me.Label136.TabIndex = 207
        Me.Label136.Text = "CELULAR:"
        Me.Label136.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label137.ForeColor = System.Drawing.Color.Navy
        Me.Label137.Location = New System.Drawing.Point(76, 23)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(30, 13)
        Me.Label137.TabIndex = 206
        Me.Label137.Text = "DNI:"
        Me.Label137.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label138.ForeColor = System.Drawing.Color.Navy
        Me.Label138.Location = New System.Drawing.Point(73, 1)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(60, 13)
        Me.Label138.TabIndex = 198
        Me.Label138.Text = "Nombres:"
        Me.Label138.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtContactoNombres
        '
        Me.txtContactoNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactoNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactoNombres.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtContactoNombres.ForeColor = System.Drawing.Color.Green
        Me.txtContactoNombres.Location = New System.Drawing.Point(133, 0)
        Me.txtContactoNombres.Name = "txtContactoNombres"
        Me.txtContactoNombres.Size = New System.Drawing.Size(282, 21)
        Me.txtContactoNombres.TabIndex = 0
        '
        'txtContactoCelular
        '
        Me.txtContactoCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactoCelular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtContactoCelular.ForeColor = System.Drawing.Color.Green
        Me.txtContactoCelular.Location = New System.Drawing.Point(266, 22)
        Me.txtContactoCelular.Name = "txtContactoCelular"
        Me.txtContactoCelular.Size = New System.Drawing.Size(149, 21)
        Me.txtContactoCelular.TabIndex = 2
        '
        'txtContactoDNI
        '
        Me.txtContactoDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactoDNI.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtContactoDNI.ForeColor = System.Drawing.Color.Green
        Me.txtContactoDNI.Location = New System.Drawing.Point(133, 22)
        Me.txtContactoDNI.Name = "txtContactoDNI"
        Me.txtContactoDNI.Size = New System.Drawing.Size(72, 21)
        Me.txtContactoDNI.TabIndex = 1
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox4.Location = New System.Drawing.Point(287, 1)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(130, 14)
        Me.CheckBox4.TabIndex = 194
        Me.CheckBox4.Text = "Facturar como Obsequio"
        Me.CheckBox4.UseVisualStyleBackColor = True
        Me.CheckBox4.Visible = False
        '
        'txtDireccionEntregaCliente
        '
        Me.txtDireccionEntregaCliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtDireccionEntregaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccionEntregaCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDireccionEntregaCliente.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtDireccionEntregaCliente.Location = New System.Drawing.Point(94, 162)
        Me.txtDireccionEntregaCliente.Name = "txtDireccionEntregaCliente"
        Me.txtDireccionEntregaCliente.ReadOnly = True
        Me.txtDireccionEntregaCliente.Size = New System.Drawing.Size(332, 21)
        Me.txtDireccionEntregaCliente.TabIndex = 217
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label139.ForeColor = System.Drawing.Color.Navy
        Me.Label139.Location = New System.Drawing.Point(20, 163)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(65, 13)
        Me.Label139.TabIndex = 216
        Me.Label139.Text = "D. Entrega"
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label135.ForeColor = System.Drawing.Color.Navy
        Me.Label135.Location = New System.Drawing.Point(268, 71)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(22, 13)
        Me.Label135.TabIndex = 215
        Me.Label135.Text = "OC"
        '
        'txtNumeroOrdenCompra
        '
        Me.txtNumeroOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrdenCompra.Enabled = False
        Me.txtNumeroOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroOrdenCompra.ForeColor = System.Drawing.Color.Green
        Me.txtNumeroOrdenCompra.Location = New System.Drawing.Point(293, 67)
        Me.txtNumeroOrdenCompra.MaxLength = 20
        Me.txtNumeroOrdenCompra.Name = "txtNumeroOrdenCompra"
        Me.txtNumeroOrdenCompra.Size = New System.Drawing.Size(103, 21)
        Me.txtNumeroOrdenCompra.TabIndex = 214
        '
        'btnOrdenCompra
        '
        Me.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOrdenCompra.ForeColor = System.Drawing.Color.Green
        Me.btnOrdenCompra.Image = CType(resources.GetObject("btnOrdenCompra.Image"), System.Drawing.Image)
        Me.btnOrdenCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenCompra.Location = New System.Drawing.Point(397, 66)
        Me.btnOrdenCompra.Name = "btnOrdenCompra"
        Me.btnOrdenCompra.Size = New System.Drawing.Size(30, 22)
        Me.btnOrdenCompra.TabIndex = 213
        Me.btnOrdenCompra.Text = "Datos de Ref."
        Me.btnOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOrdenCompra.UseVisualStyleBackColor = True
        '
        'cboTipoPedido
        '
        Me.cboTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoPedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboTipoPedido.ForeColor = System.Drawing.Color.Green
        Me.cboTipoPedido.FormattingEnabled = True
        Me.cboTipoPedido.Location = New System.Drawing.Point(269, 43)
        Me.cboTipoPedido.Name = "cboTipoPedido"
        Me.cboTipoPedido.Size = New System.Drawing.Size(158, 21)
        Me.cboTipoPedido.TabIndex = 212
        '
        'lblTipoPedido
        '
        Me.lblTipoPedido.AutoSize = True
        Me.lblTipoPedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTipoPedido.ForeColor = System.Drawing.Color.Navy
        Me.lblTipoPedido.Location = New System.Drawing.Point(208, 47)
        Me.lblTipoPedido.Name = "lblTipoPedido"
        Me.lblTipoPedido.Size = New System.Drawing.Size(55, 13)
        Me.lblTipoPedido.TabIndex = 211
        Me.lblTipoPedido.Text = "T.Pedido"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label131.ForeColor = System.Drawing.Color.Navy
        Me.Label131.Location = New System.Drawing.Point(24, 263)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(61, 13)
        Me.Label131.TabIndex = 199
        Me.Label131.Text = "Vendedor"
        Me.Label131.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_validez_oferta
        '
        Me.txt_validez_oferta.BackColor = System.Drawing.Color.White
        Me.txt_validez_oferta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_validez_oferta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_validez_oferta.ForeColor = System.Drawing.Color.Green
        Me.txt_validez_oferta.Location = New System.Drawing.Point(94, 332)
        Me.txt_validez_oferta.MaxLength = 250
        Me.txt_validez_oferta.Name = "txt_validez_oferta"
        Me.txt_validez_oferta.Size = New System.Drawing.Size(332, 21)
        Me.txt_validez_oferta.TabIndex = 197
        Me.txt_validez_oferta.Visible = False
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label99.ForeColor = System.Drawing.Color.Navy
        Me.Label99.Location = New System.Drawing.Point(8, 336)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(77, 13)
        Me.Label99.TabIndex = 198
        Me.Label99.Text = "Validez Ofer."
        Me.Label99.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label99.Visible = False
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label98.ForeColor = System.Drawing.Color.Navy
        Me.Label98.Location = New System.Drawing.Point(38, 238)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(47, 13)
        Me.Label98.TabIndex = 196
        Me.Label98.Text = "F. Pago"
        '
        'txt_desc_tipo_nota_electronica
        '
        Me.txt_desc_tipo_nota_electronica.BackColor = System.Drawing.Color.White
        Me.txt_desc_tipo_nota_electronica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_tipo_nota_electronica.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc_tipo_nota_electronica.ForeColor = System.Drawing.Color.Green
        Me.txt_desc_tipo_nota_electronica.Location = New System.Drawing.Point(238, 344)
        Me.txt_desc_tipo_nota_electronica.Name = "txt_desc_tipo_nota_electronica"
        Me.txt_desc_tipo_nota_electronica.ReadOnly = True
        Me.txt_desc_tipo_nota_electronica.Size = New System.Drawing.Size(257, 27)
        Me.txt_desc_tipo_nota_electronica.TabIndex = 189
        Me.txt_desc_tipo_nota_electronica.Visible = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(203, 344)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox13.TabIndex = 191
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Visible = False
        '
        'txt_tip_nota_electronica
        '
        Me.txt_tip_nota_electronica.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_tip_nota_electronica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tip_nota_electronica.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tip_nota_electronica.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_tip_nota_electronica.Location = New System.Drawing.Point(94, 344)
        Me.txt_tip_nota_electronica.MaxLength = 2
        Me.txt_tip_nota_electronica.Name = "txt_tip_nota_electronica"
        Me.txt_tip_nota_electronica.ReadOnly = True
        Me.txt_tip_nota_electronica.Size = New System.Drawing.Size(101, 27)
        Me.txt_tip_nota_electronica.TabIndex = 188
        Me.txt_tip_nota_electronica.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(14, 348)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(77, 19)
        Me.Label43.TabIndex = 190
        Me.Label43.Text = "Tip. N.E."
        Me.Label43.Visible = False
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Green
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(8, 80)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(22, 27)
        Me.Button5.TabIndex = 187
        Me.Button5.Text = "Datos de Ref."
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'btnclientenuevo
        '
        Me.btnclientenuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientenuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnclientenuevo.ForeColor = System.Drawing.Color.Green
        Me.btnclientenuevo.Image = CType(resources.GetObject("btnclientenuevo.Image"), System.Drawing.Image)
        Me.btnclientenuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclientenuevo.Location = New System.Drawing.Point(8, 106)
        Me.btnclientenuevo.Name = "btnclientenuevo"
        Me.btnclientenuevo.Size = New System.Drawing.Size(22, 27)
        Me.btnclientenuevo.TabIndex = 186
        Me.btnclientenuevo.Text = "C&liente nuevo"
        Me.btnclientenuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclientenuevo.UseVisualStyleBackColor = True
        Me.btnclientenuevo.Visible = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(2949, 290)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox12.TabIndex = 185
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(2780, 290)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox11.TabIndex = 184
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(2570, 290)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox10.TabIndex = 183
        Me.PictureBox10.TabStop = False
        '
        'txt_trama
        '
        Me.txt_trama.BackColor = System.Drawing.Color.White
        Me.txt_trama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trama.Location = New System.Drawing.Point(2846, 289)
        Me.txt_trama.Name = "txt_trama"
        Me.txt_trama.ReadOnly = True
        Me.txt_trama.Size = New System.Drawing.Size(122, 20)
        Me.txt_trama.TabIndex = 181
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label51.ForeColor = System.Drawing.Color.Navy
        Me.Label51.Location = New System.Drawing.Point(2804, 292)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 13)
        Me.Label51.TabIndex = 182
        Me.Label51.Text = "Trama"
        '
        'txt_Empresa
        '
        Me.txt_Empresa.BackColor = System.Drawing.Color.White
        Me.txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Empresa.Location = New System.Drawing.Point(2698, 289)
        Me.txt_Empresa.Name = "txt_Empresa"
        Me.txt_Empresa.ReadOnly = True
        Me.txt_Empresa.Size = New System.Drawing.Size(100, 20)
        Me.txt_Empresa.TabIndex = 179
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label50.ForeColor = System.Drawing.Color.Navy
        Me.Label50.Location = New System.Drawing.Point(2593, 292)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(102, 13)
        Me.Label50.TabIndex = 180
        Me.Label50.Text = "Empresa Transporte"
        '
        'txt_vehiculo
        '
        Me.txt_vehiculo.BackColor = System.Drawing.Color.White
        Me.txt_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vehiculo.Location = New System.Drawing.Point(2486, 289)
        Me.txt_vehiculo.Name = "txt_vehiculo"
        Me.txt_vehiculo.ReadOnly = True
        Me.txt_vehiculo.Size = New System.Drawing.Size(103, 20)
        Me.txt_vehiculo.TabIndex = 177
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(2433, 292)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(48, 13)
        Me.Label49.TabIndex = 178
        Me.Label49.Text = "Vehiculo"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(2789, 236)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 118
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1454, 39)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 176
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'rbDocRef_varios
        '
        Me.rbDocRef_varios.AutoSize = True
        Me.rbDocRef_varios.ForeColor = System.Drawing.Color.Navy
        Me.rbDocRef_varios.Location = New System.Drawing.Point(1770, 39)
        Me.rbDocRef_varios.Name = "rbDocRef_varios"
        Me.rbDocRef_varios.Size = New System.Drawing.Size(101, 17)
        Me.rbDocRef_varios.TabIndex = 174
        Me.rbDocRef_varios.Text = "& Varios doc Ref."
        Me.rbDocRef_varios.UseVisualStyleBackColor = True
        Me.rbDocRef_varios.Visible = False
        '
        'rbDocRef_uno
        '
        Me.rbDocRef_uno.AutoSize = True
        Me.rbDocRef_uno.ForeColor = System.Drawing.Color.Navy
        Me.rbDocRef_uno.Location = New System.Drawing.Point(1262, 40)
        Me.rbDocRef_uno.Name = "rbDocRef_uno"
        Me.rbDocRef_uno.Size = New System.Drawing.Size(86, 17)
        Me.rbDocRef_uno.TabIndex = 173
        Me.rbDocRef_uno.Text = "Un doc. Ref."
        Me.rbDocRef_uno.UseVisualStyleBackColor = True
        Me.rbDocRef_uno.Visible = False
        '
        'GbdetalleDocumento
        '
        Me.GbdetalleDocumento.BackColor = System.Drawing.Color.White
        Me.GbdetalleDocumento.Controls.Add(Me.Label41)
        Me.GbdetalleDocumento.Controls.Add(Me.txtdetalleguiaserie)
        Me.GbdetalleDocumento.Controls.Add(Me.txtdetalleserie)
        Me.GbdetalleDocumento.Controls.Add(Me.txtNumeroCP)
        Me.GbdetalleDocumento.Controls.Add(Me.txtdetalleguianumero)
        Me.GbdetalleDocumento.Controls.Add(Me.txtSerieCP)
        Me.GbdetalleDocumento.Controls.Add(Me.txtcodigoCP)
        Me.GbdetalleDocumento.Controls.Add(Me.Label40)
        Me.GbdetalleDocumento.Controls.Add(Me.Label38)
        Me.GbdetalleDocumento.Controls.Add(Me.txtdetallenumero)
        Me.GbdetalleDocumento.Controls.Add(Me.txtdetalleguiadoc)
        Me.GbdetalleDocumento.Controls.Add(Me.Label39)
        Me.GbdetalleDocumento.Controls.Add(Me.txtdetalledoc)
        Me.GbdetalleDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbdetalleDocumento.ForeColor = System.Drawing.Color.Navy
        Me.GbdetalleDocumento.Location = New System.Drawing.Point(148, 350)
        Me.GbdetalleDocumento.Name = "GbdetalleDocumento"
        Me.GbdetalleDocumento.Size = New System.Drawing.Size(400, 57)
        Me.GbdetalleDocumento.TabIndex = 170
        Me.GbdetalleDocumento.TabStop = False
        Me.GbdetalleDocumento.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(25, 123)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 11)
        Me.Label41.TabIndex = 175
        Me.Label41.Text = "Comprobante"
        Me.Label41.Visible = False
        '
        'txtdetalleguiaserie
        '
        Me.txtdetalleguiaserie.BackColor = System.Drawing.Color.White
        Me.txtdetalleguiaserie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalleguiaserie.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalleguiaserie.Location = New System.Drawing.Point(138, 100)
        Me.txtdetalleguiaserie.Name = "txtdetalleguiaserie"
        Me.txtdetalleguiaserie.ReadOnly = True
        Me.txtdetalleguiaserie.Size = New System.Drawing.Size(31, 18)
        Me.txtdetalleguiaserie.TabIndex = 173
        Me.txtdetalleguiaserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdetalleguiaserie.Visible = False
        '
        'txtdetalleserie
        '
        Me.txtdetalleserie.BackColor = System.Drawing.Color.White
        Me.txtdetalleserie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalleserie.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtdetalleserie.ForeColor = System.Drawing.Color.Green
        Me.txtdetalleserie.Location = New System.Drawing.Point(182, 19)
        Me.txtdetalleserie.Name = "txtdetalleserie"
        Me.txtdetalleserie.ReadOnly = True
        Me.txtdetalleserie.Size = New System.Drawing.Size(64, 27)
        Me.txtdetalleserie.TabIndex = 168
        Me.txtdetalleserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeroCP
        '
        Me.txtNumeroCP.BackColor = System.Drawing.Color.White
        Me.txtNumeroCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroCP.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCP.Location = New System.Drawing.Point(171, 124)
        Me.txtNumeroCP.Name = "txtNumeroCP"
        Me.txtNumeroCP.ReadOnly = True
        Me.txtNumeroCP.Size = New System.Drawing.Size(138, 18)
        Me.txtNumeroCP.TabIndex = 165
        Me.txtNumeroCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumeroCP.Visible = False
        '
        'txtdetalleguianumero
        '
        Me.txtdetalleguianumero.BackColor = System.Drawing.Color.White
        Me.txtdetalleguianumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalleguianumero.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalleguianumero.Location = New System.Drawing.Point(171, 100)
        Me.txtdetalleguianumero.Name = "txtdetalleguianumero"
        Me.txtdetalleguianumero.ReadOnly = True
        Me.txtdetalleguianumero.Size = New System.Drawing.Size(138, 18)
        Me.txtdetalleguianumero.TabIndex = 174
        Me.txtdetalleguianumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdetalleguianumero.Visible = False
        '
        'txtSerieCP
        '
        Me.txtSerieCP.BackColor = System.Drawing.Color.White
        Me.txtSerieCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerieCP.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieCP.Location = New System.Drawing.Point(138, 124)
        Me.txtSerieCP.Name = "txtSerieCP"
        Me.txtSerieCP.ReadOnly = True
        Me.txtSerieCP.Size = New System.Drawing.Size(31, 18)
        Me.txtSerieCP.TabIndex = 164
        Me.txtSerieCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSerieCP.Visible = False
        '
        'txtcodigoCP
        '
        Me.txtcodigoCP.BackColor = System.Drawing.Color.White
        Me.txtcodigoCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoCP.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoCP.Location = New System.Drawing.Point(107, 124)
        Me.txtcodigoCP.Name = "txtcodigoCP"
        Me.txtcodigoCP.ReadOnly = True
        Me.txtcodigoCP.Size = New System.Drawing.Size(30, 18)
        Me.txtcodigoCP.TabIndex = 163
        Me.txtcodigoCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcodigoCP.Visible = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(13, 103)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(90, 11)
        Me.Label40.TabIndex = 171
        Me.Label40.Text = "Guia de Remision"
        Me.Label40.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(40, 134)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(60, 11)
        Me.Label38.TabIndex = 162
        Me.Label38.Text = "Percepcion"
        Me.Label38.Visible = False
        '
        'txtdetallenumero
        '
        Me.txtdetallenumero.BackColor = System.Drawing.Color.White
        Me.txtdetallenumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetallenumero.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtdetallenumero.ForeColor = System.Drawing.Color.Green
        Me.txtdetallenumero.Location = New System.Drawing.Point(252, 19)
        Me.txtdetallenumero.Name = "txtdetallenumero"
        Me.txtdetallenumero.ReadOnly = True
        Me.txtdetallenumero.Size = New System.Drawing.Size(134, 27)
        Me.txtdetallenumero.TabIndex = 169
        Me.txtdetallenumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdetalleguiadoc
        '
        Me.txtdetalleguiadoc.BackColor = System.Drawing.Color.White
        Me.txtdetalleguiadoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalleguiadoc.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalleguiadoc.Location = New System.Drawing.Point(107, 100)
        Me.txtdetalleguiadoc.Name = "txtdetalleguiadoc"
        Me.txtdetalleguiadoc.ReadOnly = True
        Me.txtdetalleguiadoc.Size = New System.Drawing.Size(30, 18)
        Me.txtdetalleguiadoc.TabIndex = 172
        Me.txtdetalleguiadoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdetalleguiadoc.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(9, 23)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 19)
        Me.Label39.TabIndex = 166
        Me.Label39.Text = "Documento"
        '
        'txtdetalledoc
        '
        Me.txtdetalledoc.BackColor = System.Drawing.Color.White
        Me.txtdetalledoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalledoc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtdetalledoc.ForeColor = System.Drawing.Color.Green
        Me.txtdetalledoc.Location = New System.Drawing.Point(125, 19)
        Me.txtdetalledoc.Name = "txtdetalledoc"
        Me.txtdetalledoc.ReadOnly = True
        Me.txtdetalledoc.Size = New System.Drawing.Size(51, 27)
        Me.txtdetalledoc.TabIndex = 167
        Me.txtdetalledoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label37.ForeColor = System.Drawing.Color.Navy
        Me.Label37.Location = New System.Drawing.Point(1480, 41)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(74, 13)
        Me.Label37.TabIndex = 161
        Me.Label37.Text = "Serie.Doc.Ref"
        Me.Label37.Visible = False
        '
        'txtSerieDocRef
        '
        Me.txtSerieDocRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerieDocRef.Location = New System.Drawing.Point(1558, 37)
        Me.txtSerieDocRef.Name = "txtSerieDocRef"
        Me.txtSerieDocRef.Size = New System.Drawing.Size(32, 20)
        Me.txtSerieDocRef.TabIndex = 7
        Me.txtSerieDocRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSerieDocRef.Visible = False
        '
        'txttipoDocRef
        '
        Me.txttipoDocRef.BackColor = System.Drawing.Color.White
        Me.txttipoDocRef.Location = New System.Drawing.Point(1427, 38)
        Me.txttipoDocRef.Name = "txttipoDocRef"
        Me.txttipoDocRef.ReadOnly = True
        Me.txttipoDocRef.Size = New System.Drawing.Size(24, 20)
        Me.txttipoDocRef.TabIndex = 6
        Me.txttipoDocRef.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(1355, 42)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(71, 13)
        Me.Label36.TabIndex = 157
        Me.Label36.Text = "Tipo.Doc.Ref"
        Me.Label36.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(256, 344)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox9.TabIndex = 155
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Visible = False
        '
        'checkSinGuia
        '
        Me.checkSinGuia.AutoSize = True
        Me.checkSinGuia.Checked = True
        Me.checkSinGuia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkSinGuia.ForeColor = System.Drawing.Color.Navy
        Me.checkSinGuia.Location = New System.Drawing.Point(580, 255)
        Me.checkSinGuia.Name = "checkSinGuia"
        Me.checkSinGuia.Size = New System.Drawing.Size(127, 17)
        Me.checkSinGuia.TabIndex = 154
        Me.checkSinGuia.Text = "Sin Guia de Remision"
        Me.checkSinGuia.UseVisualStyleBackColor = True
        Me.checkSinGuia.Visible = False
        '
        'lblAlmacen
        '
        Me.lblAlmacen.BackColor = System.Drawing.Color.White
        Me.lblAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAlmacen.ForeColor = System.Drawing.Color.Green
        Me.lblAlmacen.Location = New System.Drawing.Point(198, 18)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.ReadOnly = True
        Me.lblAlmacen.Size = New System.Drawing.Size(133, 21)
        Me.lblAlmacen.TabIndex = 22
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtAlmacen.ForeColor = System.Drawing.Color.Green
        Me.txtAlmacen.Location = New System.Drawing.Point(198, 18)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(42, 21)
        Me.txtAlmacen.TabIndex = 21
        Me.txtAlmacen.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(134, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = "Almacén"
        '
        'cboDirEntrega
        '
        Me.cboDirEntrega.FormattingEnabled = True
        Me.cboDirEntrega.Location = New System.Drawing.Point(2522, 260)
        Me.cboDirEntrega.Name = "cboDirEntrega"
        Me.cboDirEntrega.Size = New System.Drawing.Size(597, 21)
        Me.cboDirEntrega.TabIndex = 17
        Me.cboDirEntrega.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(2426, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Dirección entrega"
        '
        'txtordenCompra
        '
        Me.txtordenCompra.BackColor = System.Drawing.Color.White
        Me.txtordenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtordenCompra.Location = New System.Drawing.Point(2684, 211)
        Me.txtordenCompra.Name = "txtordenCompra"
        Me.txtordenCompra.ReadOnly = True
        Me.txtordenCompra.Size = New System.Drawing.Size(110, 20)
        Me.txtordenCompra.TabIndex = 13
        Me.txtordenCompra.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(2591, 214)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(90, 13)
        Me.Label35.TabIndex = 149
        Me.Label35.Text = "Orden de Compra"
        Me.Label35.Visible = False
        '
        'txtcotizacion
        '
        Me.txtcotizacion.BackColor = System.Drawing.Color.White
        Me.txtcotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcotizacion.Location = New System.Drawing.Point(2486, 210)
        Me.txtcotizacion.Name = "txtcotizacion"
        Me.txtcotizacion.ReadOnly = True
        Me.txtcotizacion.Size = New System.Drawing.Size(100, 20)
        Me.txtcotizacion.TabIndex = 12
        Me.txtcotizacion.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(2425, 213)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 13)
        Me.Label34.TabIndex = 147
        Me.Label34.Text = "Cotizacion"
        Me.Label34.Visible = False
        '
        'txtNumDocRef
        '
        Me.txtNumDocRef.BackColor = System.Drawing.Color.White
        Me.txtNumDocRef.Location = New System.Drawing.Point(1658, 37)
        Me.txtNumDocRef.Multiline = True
        Me.txtNumDocRef.Name = "txtNumDocRef"
        Me.txtNumDocRef.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNumDocRef.Size = New System.Drawing.Size(107, 20)
        Me.txtNumDocRef.TabIndex = 8
        Me.txtNumDocRef.Visible = False
        '
        'chkSinIGV
        '
        Me.chkSinIGV.AutoSize = True
        Me.chkSinIGV.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSinIGV.ForeColor = System.Drawing.Color.Navy
        Me.chkSinIGV.Location = New System.Drawing.Point(76, 434)
        Me.chkSinIGV.Name = "chkSinIGV"
        Me.chkSinIGV.Size = New System.Drawing.Size(143, 23)
        Me.chkSinIGV.TabIndex = 84
        Me.chkSinIGV.Text = "&Precio sin Igv."
        Me.chkSinIGV.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(1593, 40)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(67, 13)
        Me.Label33.TabIndex = 145
        Me.Label33.Text = "Nro.Doc.Ref"
        Me.Label33.Visible = False
        '
        'txtpedido
        '
        Me.txtpedido.BackColor = System.Drawing.Color.White
        Me.txtpedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpedido.Location = New System.Drawing.Point(2880, 211)
        Me.txtpedido.Name = "txtpedido"
        Me.txtpedido.Size = New System.Drawing.Size(101, 20)
        Me.txtpedido.TabIndex = 14
        Me.txtpedido.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(2798, 215)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 13)
        Me.Label32.TabIndex = 143
        Me.Label32.Text = "Numero Pedido"
        Me.Label32.Visible = False
        '
        'txtdescripcionTrama
        '
        Me.txtdescripcionTrama.BackColor = System.Drawing.Color.White
        Me.txtdescripcionTrama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionTrama.Location = New System.Drawing.Point(1372, 178)
        Me.txtdescripcionTrama.Name = "txtdescripcionTrama"
        Me.txtdescripcionTrama.ReadOnly = True
        Me.txtdescripcionTrama.Size = New System.Drawing.Size(47, 20)
        Me.txtdescripcionTrama.TabIndex = 142
        Me.txtdescripcionTrama.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1354, 179)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox8.TabIndex = 141
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'txtcodigoTrama
        '
        Me.txtcodigoTrama.Location = New System.Drawing.Point(1314, 178)
        Me.txtcodigoTrama.Name = "txtcodigoTrama"
        Me.txtcodigoTrama.Size = New System.Drawing.Size(37, 20)
        Me.txtcodigoTrama.TabIndex = 139
        Me.txtcodigoTrama.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(1272, 181)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 13)
        Me.Label31.TabIndex = 140
        Me.Label31.Text = "Trama"
        Me.Label31.Visible = False
        '
        'txtdescripcionTransportista
        '
        Me.txtdescripcionTransportista.BackColor = System.Drawing.Color.White
        Me.txtdescripcionTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionTransportista.Location = New System.Drawing.Point(1265, 259)
        Me.txtdescripcionTransportista.Name = "txtdescripcionTransportista"
        Me.txtdescripcionTransportista.ReadOnly = True
        Me.txtdescripcionTransportista.Size = New System.Drawing.Size(47, 20)
        Me.txtdescripcionTransportista.TabIndex = 138
        Me.txtdescripcionTransportista.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(1247, 260)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox7.TabIndex = 137
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'txtcodigoTransporte
        '
        Me.txtcodigoTransporte.Location = New System.Drawing.Point(1376, 256)
        Me.txtcodigoTransporte.Name = "txtcodigoTransporte"
        Me.txtcodigoTransporte.Size = New System.Drawing.Size(44, 20)
        Me.txtcodigoTransporte.TabIndex = 135
        Me.txtcodigoTransporte.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1377, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Empresa Transporte"
        Me.Label4.Visible = False
        '
        'txtdescVehiculo
        '
        Me.txtdescVehiculo.BackColor = System.Drawing.Color.White
        Me.txtdescVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescVehiculo.Location = New System.Drawing.Point(1372, 153)
        Me.txtdescVehiculo.Name = "txtdescVehiculo"
        Me.txtdescVehiculo.ReadOnly = True
        Me.txtdescVehiculo.Size = New System.Drawing.Size(45, 20)
        Me.txtdescVehiculo.TabIndex = 134
        Me.txtdescVehiculo.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1354, 154)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox5.TabIndex = 133
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'txtcodigoVehiculo
        '
        Me.txtcodigoVehiculo.Location = New System.Drawing.Point(1314, 153)
        Me.txtcodigoVehiculo.Name = "txtcodigoVehiculo"
        Me.txtcodigoVehiculo.Size = New System.Drawing.Size(37, 20)
        Me.txtcodigoVehiculo.TabIndex = 131
        Me.txtcodigoVehiculo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1259, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Vehiculo "
        Me.Label2.Visible = False
        '
        'txtdescEsp
        '
        Me.txtdescEsp.BackColor = System.Drawing.Color.White
        Me.txtdescEsp.Location = New System.Drawing.Point(1291, 256)
        Me.txtdescEsp.Name = "txtdescEsp"
        Me.txtdescEsp.ReadOnly = True
        Me.txtdescEsp.Size = New System.Drawing.Size(58, 20)
        Me.txtdescEsp.TabIndex = 130
        Me.txtdescEsp.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.Location = New System.Drawing.Point(1270, 241)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(107, 13)
        Me.Label30.TabIndex = 129
        Me.Label30.Text = "%DescuentoEspecial"
        Me.Label30.Visible = False
        '
        'lblVendedor
        '
        Me.lblVendedor.BackColor = System.Drawing.Color.White
        Me.lblVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblVendedor.ForeColor = System.Drawing.Color.Green
        Me.lblVendedor.Location = New System.Drawing.Point(141, 259)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.ReadOnly = True
        Me.lblVendedor.Size = New System.Drawing.Size(286, 21)
        Me.lblVendedor.TabIndex = 29
        '
        'txtdescCli
        '
        Me.txtdescCli.BackColor = System.Drawing.Color.White
        Me.txtdescCli.Location = New System.Drawing.Point(1249, 201)
        Me.txtdescCli.Name = "txtdescCli"
        Me.txtdescCli.ReadOnly = True
        Me.txtdescCli.Size = New System.Drawing.Size(48, 20)
        Me.txtdescCli.TabIndex = 128
        Me.txtdescCli.Visible = False
        '
        'lblFormaPago
        '
        Me.lblFormaPago.BackColor = System.Drawing.Color.White
        Me.lblFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFormaPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFormaPago.ForeColor = System.Drawing.Color.Green
        Me.lblFormaPago.Location = New System.Drawing.Point(141, 234)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.ReadOnly = True
        Me.lblFormaPago.Size = New System.Drawing.Size(123, 21)
        Me.lblFormaPago.TabIndex = 30
        '
        'txtNomTrans
        '
        Me.txtNomTrans.BackColor = System.Drawing.Color.White
        Me.txtNomTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomTrans.Enabled = False
        Me.txtNomTrans.Location = New System.Drawing.Point(2810, 234)
        Me.txtNomTrans.Name = "txtNomTrans"
        Me.txtNomTrans.Size = New System.Drawing.Size(310, 20)
        Me.txtNomTrans.TabIndex = 31
        Me.txtNomTrans.Text = "."
        Me.txtNomTrans.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label29.Location = New System.Drawing.Point(1230, 211)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(99, 13)
        Me.Label29.TabIndex = 127
        Me.Label29.Text = "%DescuentoCliente"
        Me.Label29.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(2237, 238)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Transportista"
        Me.Label18.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(256, 350)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'lblPtoVenta
        '
        Me.lblPtoVenta.BackColor = System.Drawing.Color.White
        Me.lblPtoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPtoVenta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtoVenta.ForeColor = System.Drawing.Color.Green
        Me.lblPtoVenta.Location = New System.Drawing.Point(296, 25)
        Me.lblPtoVenta.Name = "lblPtoVenta"
        Me.lblPtoVenta.ReadOnly = True
        Me.lblPtoVenta.Size = New System.Drawing.Size(47, 27)
        Me.lblPtoVenta.TabIndex = 20
        Me.lblPtoVenta.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(620, 34)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 111
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'cbSerieGuia
        '
        Me.cbSerieGuia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSerieGuia.FormattingEnabled = True
        Me.cbSerieGuia.Location = New System.Drawing.Point(2627, 235)
        Me.cbSerieGuia.Name = "cbSerieGuia"
        Me.cbSerieGuia.Size = New System.Drawing.Size(60, 21)
        Me.cbSerieGuia.TabIndex = 15
        Me.cbSerieGuia.Visible = False
        '
        'cboSerieDoc
        '
        Me.cboSerieDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSerieDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboSerieDoc.ForeColor = System.Drawing.Color.Green
        Me.cboSerieDoc.FormattingEnabled = True
        Me.cboSerieDoc.Location = New System.Drawing.Point(365, 50)
        Me.cboSerieDoc.Name = "cboSerieDoc"
        Me.cboSerieDoc.Size = New System.Drawing.Size(61, 21)
        Me.cboSerieDoc.TabIndex = 5
        Me.cboSerieDoc.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(317, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Serie"
        Me.Label19.Visible = False
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(94, 43)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(105, 21)
        Me.dtpFechaFactura.TabIndex = 2
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboTipoDoc.ForeColor = System.Drawing.Color.Green
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Location = New System.Drawing.Point(372, 18)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(54, 21)
        Me.cboTipoDoc.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(337, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Doc."
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboMoneda.ForeColor = System.Drawing.Color.Green
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(94, 67)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(105, 21)
        Me.cboMoneda.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(2555, 239)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Serie de Guia"
        Me.Label17.Visible = False
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormaPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFormaPago.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtFormaPago.Location = New System.Drawing.Point(94, 234)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(42, 21)
        Me.txtFormaPago.TabIndex = 11
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.Green
        Me.txtTipoCambio.Location = New System.Drawing.Point(233, 67)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(35, 21)
        Me.txtTipoCambio.TabIndex = 24
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVendedor
        '
        Me.txtVendedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtVendedor.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtVendedor.Location = New System.Drawing.Point(94, 259)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(42, 21)
        Me.txtVendedor.TabIndex = 10
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDireccion.ForeColor = System.Drawing.Color.Green
        Me.txtDireccion.Location = New System.Drawing.Point(94, 138)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(332, 21)
        Me.txtDireccion.TabIndex = 28
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.White
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.Green
        Me.txtRazonSocial.Location = New System.Drawing.Point(94, 114)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(332, 21)
        Me.txtRazonSocial.TabIndex = 27
        '
        'txtRucDni
        '
        Me.txtRucDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRucDni.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtRucDni.ForeColor = System.Drawing.Color.Green
        Me.txtRucDni.Location = New System.Drawing.Point(238, 91)
        Me.txtRucDni.Name = "txtRucDni"
        Me.txtRucDni.ReadOnly = True
        Me.txtRucDni.Size = New System.Drawing.Size(85, 21)
        Me.txtRucDni.TabIndex = 26
        '
        'txtCod_Cliente
        '
        Me.txtCod_Cliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCod_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCod_Cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCod_Cliente.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCod_Cliente.Location = New System.Drawing.Point(94, 91)
        Me.txtCod_Cliente.Name = "txtCod_Cliente"
        Me.txtCod_Cliente.ReadOnly = True
        Me.txtCod_Cliente.Size = New System.Drawing.Size(85, 21)
        Me.txtCod_Cliente.TabIndex = 9
        '
        'txtPtoVenta
        '
        Me.txtPtoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPtoVenta.Enabled = False
        Me.txtPtoVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPtoVenta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPtoVenta.Location = New System.Drawing.Point(94, 18)
        Me.txtPtoVenta.Name = "txtPtoVenta"
        Me.txtPtoVenta.Size = New System.Drawing.Size(36, 21)
        Me.txtPtoVenta.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(15, 354)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 19)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Forma de pago"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(204, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "T.C."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(32, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Moneda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(58, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 19)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Vendedor"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(26, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(30, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "R. Social"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(181, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Ruc/ Dni"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(38, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(44, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(28, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Pto. Vta."
        '
        'txtCodTrans
        '
        Me.txtCodTrans.BackColor = System.Drawing.Color.White
        Me.txtCodTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTrans.Location = New System.Drawing.Point(2760, 235)
        Me.txtCodTrans.Name = "txtCodTrans"
        Me.txtCodTrans.Size = New System.Drawing.Size(25, 20)
        Me.txtCodTrans.TabIndex = 16
        Me.txtCodTrans.Text = "00"
        Me.txtCodTrans.Visible = False
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(120, 253)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(81, 20)
        Me.txtcodigo.TabIndex = 195
        Me.txtcodigo.Visible = False
        '
        'rdb_f_a4
        '
        Me.rdb_f_a4.AutoSize = True
        Me.rdb_f_a4.ForeColor = System.Drawing.Color.Navy
        Me.rdb_f_a4.Location = New System.Drawing.Point(214, 265)
        Me.rdb_f_a4.Name = "rdb_f_a4"
        Me.rdb_f_a4.Size = New System.Drawing.Size(79, 17)
        Me.rdb_f_a4.TabIndex = 193
        Me.rdb_f_a4.TabStop = True
        Me.rdb_f_a4.Text = "Formato A4"
        Me.rdb_f_a4.UseVisualStyleBackColor = True
        Me.rdb_f_a4.Visible = False
        '
        'rdb_f_ticket
        '
        Me.rdb_f_ticket.AutoSize = True
        Me.rdb_f_ticket.Checked = True
        Me.rdb_f_ticket.ForeColor = System.Drawing.Color.Navy
        Me.rdb_f_ticket.Location = New System.Drawing.Point(94, 265)
        Me.rdb_f_ticket.Name = "rdb_f_ticket"
        Me.rdb_f_ticket.Size = New System.Drawing.Size(96, 17)
        Me.rdb_f_ticket.TabIndex = 192
        Me.rdb_f_ticket.TabStop = True
        Me.rdb_f_ticket.Text = "Formato Ticket"
        Me.rdb_f_ticket.UseVisualStyleBackColor = True
        Me.rdb_f_ticket.Visible = False
        '
        'chk_facturar_obsequio
        '
        Me.chk_facturar_obsequio.AutoSize = True
        Me.chk_facturar_obsequio.ForeColor = System.Drawing.Color.Navy
        Me.chk_facturar_obsequio.Location = New System.Drawing.Point(334, 265)
        Me.chk_facturar_obsequio.Name = "chk_facturar_obsequio"
        Me.chk_facturar_obsequio.Size = New System.Drawing.Size(142, 17)
        Me.chk_facturar_obsequio.TabIndex = 194
        Me.chk_facturar_obsequio.Text = "Facturar como Obsequio"
        Me.chk_facturar_obsequio.UseVisualStyleBackColor = True
        Me.chk_facturar_obsequio.Visible = False
        '
        'gbTipoFacturacion
        '
        Me.gbTipoFacturacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTipoFacturacion.BackColor = System.Drawing.Color.White
        Me.gbTipoFacturacion.Controls.Add(Me.rb_facturar_devolucion)
        Me.gbTipoFacturacion.Controls.Add(Me.rb_facturar_pedido)
        Me.gbTipoFacturacion.Controls.Add(Me.Label48)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaRepMedico)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaExistencias)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaGuiaVenta)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaDirecta)
        Me.gbTipoFacturacion.Controls.Add(Me.rbsinDescargo)
        Me.gbTipoFacturacion.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbTipoFacturacion.Location = New System.Drawing.Point(1284, 28)
        Me.gbTipoFacturacion.Name = "gbTipoFacturacion"
        Me.gbTipoFacturacion.Size = New System.Drawing.Size(194, 34)
        Me.gbTipoFacturacion.TabIndex = 184
        Me.gbTipoFacturacion.TabStop = False
        Me.gbTipoFacturacion.Visible = False
        '
        'rb_facturar_devolucion
        '
        Me.rb_facturar_devolucion.AutoSize = True
        Me.rb_facturar_devolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rb_facturar_devolucion.Location = New System.Drawing.Point(1083, 12)
        Me.rb_facturar_devolucion.Name = "rb_facturar_devolucion"
        Me.rb_facturar_devolucion.Size = New System.Drawing.Size(119, 17)
        Me.rb_facturar_devolucion.TabIndex = 175
        Me.rb_facturar_devolucion.Text = "Facturar devolucion"
        Me.rb_facturar_devolucion.UseVisualStyleBackColor = True
        '
        'rb_facturar_pedido
        '
        Me.rb_facturar_pedido.AutoSize = True
        Me.rb_facturar_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rb_facturar_pedido.Location = New System.Drawing.Point(978, 12)
        Me.rb_facturar_pedido.Name = "rb_facturar_pedido"
        Me.rb_facturar_pedido.Size = New System.Drawing.Size(99, 17)
        Me.rb_facturar_pedido.TabIndex = 174
        Me.rb_facturar_pedido.Text = "Facturar pedido"
        Me.rb_facturar_pedido.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label48.Location = New System.Drawing.Point(7, 14)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(117, 13)
        Me.Label48.TabIndex = 173
        Me.Label48.Text = "Tipo de Facturacion"
        '
        'rbFacturaRepMedico
        '
        Me.rbFacturaRepMedico.AutoSize = True
        Me.rbFacturaRepMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaRepMedico.Location = New System.Drawing.Point(369, 13)
        Me.rbFacturaRepMedico.Name = "rbFacturaRepMedico"
        Me.rbFacturaRepMedico.Size = New System.Drawing.Size(174, 17)
        Me.rbFacturaRepMedico.TabIndex = 172
        Me.rbFacturaRepMedico.Text = "Guia por Facturar (Rep.Medico)"
        Me.rbFacturaRepMedico.UseVisualStyleBackColor = True
        '
        'rbFacturaExistencias
        '
        Me.rbFacturaExistencias.AutoSize = True
        Me.rbFacturaExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaExistencias.Location = New System.Drawing.Point(548, 13)
        Me.rbFacturaExistencias.Name = "rbFacturaExistencias"
        Me.rbFacturaExistencias.Size = New System.Drawing.Size(269, 17)
        Me.rbFacturaExistencias.TabIndex = 170
        Me.rbFacturaExistencias.Text = "Existencias por Entregar - Facturacion sin Descargo"
        Me.rbFacturaExistencias.UseVisualStyleBackColor = True
        '
        'rbFacturaGuiaVenta
        '
        Me.rbFacturaGuiaVenta.AutoSize = True
        Me.rbFacturaGuiaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaGuiaVenta.Location = New System.Drawing.Point(254, 13)
        Me.rbFacturaGuiaVenta.Name = "rbFacturaGuiaVenta"
        Me.rbFacturaGuiaVenta.Size = New System.Drawing.Size(107, 17)
        Me.rbFacturaGuiaVenta.TabIndex = 169
        Me.rbFacturaGuiaVenta.Text = "Guia por Facturar"
        Me.rbFacturaGuiaVenta.UseVisualStyleBackColor = True
        '
        'rbFacturaDirecta
        '
        Me.rbFacturaDirecta.AutoSize = True
        Me.rbFacturaDirecta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaDirecta.Location = New System.Drawing.Point(128, 13)
        Me.rbFacturaDirecta.Name = "rbFacturaDirecta"
        Me.rbFacturaDirecta.Size = New System.Drawing.Size(118, 17)
        Me.rbFacturaDirecta.TabIndex = 168
        Me.rbFacturaDirecta.Text = "Facturacion Directa"
        Me.rbFacturaDirecta.UseVisualStyleBackColor = True
        '
        'rbsinDescargo
        '
        Me.rbsinDescargo.AutoSize = True
        Me.rbsinDescargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbsinDescargo.Location = New System.Drawing.Point(826, 13)
        Me.rbsinDescargo.Name = "rbsinDescargo"
        Me.rbsinDescargo.Size = New System.Drawing.Size(146, 17)
        Me.rbsinDescargo.TabIndex = 171
        Me.rbsinDescargo.Text = "Facturacion sin Descargo"
        Me.rbsinDescargo.UseVisualStyleBackColor = True
        '
        'gbdetalle
        '
        Me.gbdetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbdetalle.BackColor = System.Drawing.Color.White
        Me.gbdetalle.Controls.Add(Me.dgvDetalle)
        Me.gbdetalle.Location = New System.Drawing.Point(17, 114)
        Me.gbdetalle.Name = "gbdetalle"
        Me.gbdetalle.Size = New System.Drawing.Size(1189, 228)
        Me.gbdetalle.TabIndex = 187
        Me.gbdetalle.TabStop = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvDetalle.ColumnHeadersHeight = 30
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle26
        Me.dgvDetalle.EnableHeadersVisualStyles = False
        Me.dgvDetalle.Location = New System.Drawing.Point(8, 13)
        Me.dgvDetalle.Name = "dgvDetalle"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgvDetalle.RowHeadersVisible = False
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDetalle.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvDetalle.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(1176, 209)
        Me.dgvDetalle.TabIndex = 112
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.Button2)
        Me.gbOpciones.Controls.Add(Me.Button1)
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Location = New System.Drawing.Point(17, 406)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(341, 65)
        Me.gbOpciones.TabIndex = 188
        Me.gbOpciones.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Green
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(190, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 44)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "&Grabar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(262, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 44)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "&Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.Green
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(126, 41)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(89, 51)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "&Editar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        Me.btnModificar.Visible = False
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnquitar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnquitar.ForeColor = System.Drawing.Color.Green
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnquitar.Location = New System.Drawing.Point(14, 10)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(68, 50)
        Me.btnquitar.TabIndex = 15
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAgregar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.Green
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(208, -1)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(45, 51)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        Me.btnAgregar.Visible = False
        '
        'txtredondeo
        '
        Me.txtredondeo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtredondeo.BackColor = System.Drawing.Color.White
        Me.txtredondeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtredondeo.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtredondeo.Location = New System.Drawing.Point(54, 482)
        Me.txtredondeo.Name = "txtredondeo"
        Me.txtredondeo.ReadOnly = True
        Me.txtredondeo.Size = New System.Drawing.Size(89, 18)
        Me.txtredondeo.TabIndex = 190
        Me.txtredondeo.Text = "0.00"
        Me.txtredondeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtredondeo.Visible = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(-3, 485)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 11)
        Me.Label15.TabIndex = 189
        Me.Label15.Text = "Redondeo"
        Me.Label15.Visible = False
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrincipal.Controls.Add(Me.lblFechaCreacion)
        Me.pnlPrincipal.Controls.Add(Me.lblusuarioId)
        Me.pnlPrincipal.Controls.Add(Me.TxtFechaCreacion)
        Me.pnlPrincipal.Controls.Add(Me.txtUserID)
        Me.pnlPrincipal.Controls.Add(Me.lblDetalle)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox3)
        Me.pnlPrincipal.Controls.Add(Me.dgvDocumentosFactura)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox2)
        Me.pnlPrincipal.Controls.Add(Me.lblCantidad)
        Me.pnlPrincipal.Controls.Add(Me.gbRangofechas)
        Me.pnlPrincipal.Location = New System.Drawing.Point(6, 30)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1200, 626)
        Me.pnlPrincipal.TabIndex = 201
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblFechaCreacion.ForeColor = System.Drawing.Color.Navy
        Me.lblFechaCreacion.Location = New System.Drawing.Point(994, 599)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(79, 16)
        Me.lblFechaCreacion.TabIndex = 222
        Me.lblFechaCreacion.Text = "F.Creación:"
        '
        'lblusuarioId
        '
        Me.lblusuarioId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblusuarioId.AutoSize = True
        Me.lblusuarioId.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblusuarioId.ForeColor = System.Drawing.Color.Navy
        Me.lblusuarioId.Location = New System.Drawing.Point(825, 600)
        Me.lblusuarioId.Name = "lblusuarioId"
        Me.lblusuarioId.Size = New System.Drawing.Size(61, 16)
        Me.lblusuarioId.TabIndex = 221
        Me.lblusuarioId.Text = "Usuario:"
        '
        'TxtFechaCreacion
        '
        Me.TxtFechaCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFechaCreacion.BackColor = System.Drawing.Color.White
        Me.TxtFechaCreacion.Location = New System.Drawing.Point(1077, 598)
        Me.TxtFechaCreacion.Name = "TxtFechaCreacion"
        Me.TxtFechaCreacion.ReadOnly = True
        Me.TxtFechaCreacion.Size = New System.Drawing.Size(114, 20)
        Me.TxtFechaCreacion.TabIndex = 220
        '
        'txtUserID
        '
        Me.txtUserID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserID.BackColor = System.Drawing.Color.White
        Me.txtUserID.Location = New System.Drawing.Point(890, 598)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(100, 20)
        Me.txtUserID.TabIndex = 219
        '
        'lblDetalle
        '
        Me.lblDetalle.BackColor = System.Drawing.Color.White
        Me.lblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDetalle.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblDetalle.Location = New System.Drawing.Point(0, 0)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(1198, 20)
        Me.lblDetalle.TabIndex = 199
        Me.lblDetalle.Text = "LISTADO DE  PEDIDOS"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(8, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(327, 45)
        Me.GroupBox3.TabIndex = 119
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(311, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'dgvDocumentosFactura
        '
        Me.dgvDocumentosFactura.AllowUserToAddRows = False
        Me.dgvDocumentosFactura.AllowUserToDeleteRows = False
        Me.dgvDocumentosFactura.AllowUserToResizeColumns = False
        Me.dgvDocumentosFactura.AllowUserToResizeRows = False
        Me.dgvDocumentosFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentosFactura.Location = New System.Drawing.Point(10, 112)
        Me.dgvDocumentosFactura.Name = "dgvDocumentosFactura"
        Me.dgvDocumentosFactura.ReadOnly = True
        Me.dgvDocumentosFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDocumentosFactura.Size = New System.Drawing.Size(1183, 479)
        Me.dgvDocumentosFactura.TabIndex = 117
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(347, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 45)
        Me.GroupBox2.TabIndex = 120
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(170, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(11, 598)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(10, 13)
        Me.lblCantidad.TabIndex = 118
        Me.lblCantidad.Text = "."
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(531, 60)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 121
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(185, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(258, 13)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(7, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 13)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Fecha inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(85, 15)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'pnl_ref
        '
        Me.pnl_ref.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_ref.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnl_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_ref.Controls.Add(Me.GroupBox1)
        Me.pnl_ref.Location = New System.Drawing.Point(1109, 387)
        Me.pnl_ref.Name = "pnl_ref"
        Me.pnl_ref.Size = New System.Drawing.Size(19, 237)
        Me.pnl_ref.TabIndex = 203
        Me.pnl_ref.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.PictureBox14)
        Me.GroupBox1.Controls.Add(Me.dtp_fec_doc_ref)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.txt_numero_ref_doc)
        Me.GroupBox1.Controls.Add(Me.txt_serie_ref_doc)
        Me.GroupBox1.Controls.Add(Me.txt_tipo_doc_ref)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 213)
        Me.GroupBox1.TabIndex = 211
        Me.GroupBox1.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(204, 64)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox14.TabIndex = 220
        Me.PictureBox14.TabStop = False
        '
        'dtp_fec_doc_ref
        '
        Me.dtp_fec_doc_ref.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fec_doc_ref.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_doc_ref.Location = New System.Drawing.Point(135, 104)
        Me.dtp_fec_doc_ref.Name = "dtp_fec_doc_ref"
        Me.dtp_fec_doc_ref.Size = New System.Drawing.Size(137, 27)
        Me.dtp_fec_doc_ref.TabIndex = 219
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label44.ForeColor = System.Drawing.Color.Navy
        Me.Label44.Location = New System.Drawing.Point(61, 108)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 19)
        Me.Label44.TabIndex = 218
        Me.Label44.Text = "Fecha"
        '
        'txt_numero_ref_doc
        '
        Me.txt_numero_ref_doc.BackColor = System.Drawing.Color.White
        Me.txt_numero_ref_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_ref_doc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_ref_doc.ForeColor = System.Drawing.Color.Green
        Me.txt_numero_ref_doc.Location = New System.Drawing.Point(306, 64)
        Me.txt_numero_ref_doc.MaxLength = 7
        Me.txt_numero_ref_doc.Name = "txt_numero_ref_doc"
        Me.txt_numero_ref_doc.Size = New System.Drawing.Size(164, 27)
        Me.txt_numero_ref_doc.TabIndex = 217
        '
        'txt_serie_ref_doc
        '
        Me.txt_serie_ref_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_serie_ref_doc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_serie_ref_doc.ForeColor = System.Drawing.Color.Green
        Me.txt_serie_ref_doc.Location = New System.Drawing.Point(238, 64)
        Me.txt_serie_ref_doc.MaxLength = 5
        Me.txt_serie_ref_doc.Name = "txt_serie_ref_doc"
        Me.txt_serie_ref_doc.Size = New System.Drawing.Size(63, 27)
        Me.txt_serie_ref_doc.TabIndex = 215
        '
        'txt_tipo_doc_ref
        '
        Me.txt_tipo_doc_ref.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_tipo_doc_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipo_doc_ref.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipo_doc_ref.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_tipo_doc_ref.Location = New System.Drawing.Point(135, 64)
        Me.txt_tipo_doc_ref.MaxLength = 2
        Me.txt_tipo_doc_ref.Name = "txt_tipo_doc_ref"
        Me.txt_tipo_doc_ref.Size = New System.Drawing.Size(63, 27)
        Me.txt_tipo_doc_ref.TabIndex = 213
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(21, 66)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(101, 19)
        Me.Label46.TabIndex = 214
        Me.Label46.Text = "Documento"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Navy
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(3, 16)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(478, 23)
        Me.TextBox8.TabIndex = 212
        Me.TextBox8.Text = "REGISTRO DE DOCUMENTO DE REFERENCIA"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.Green
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(248, 148)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 51)
        Me.Button6.TabIndex = 210
        Me.Button6.Text = "Cancelar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.Green
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(123, 148)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(115, 51)
        Me.Button7.TabIndex = 209
        Me.Button7.Text = "Grabar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GrpAgregarProductos
        '
        Me.GrpAgregarProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpAgregarProductos.BackColor = System.Drawing.Color.White
        Me.GrpAgregarProductos.Controls.Add(Me.chkigv)
        Me.GrpAgregarProductos.Controls.Add(Me.txtcantidad_fraccion)
        Me.GrpAgregarProductos.Controls.Add(Me.Label95)
        Me.GrpAgregarProductos.Controls.Add(Me.txtprecioUnitario_fraccion)
        Me.GrpAgregarProductos.Controls.Add(Me.Label93)
        Me.GrpAgregarProductos.Controls.Add(Me.txt_numero_lote)
        Me.GrpAgregarProductos.Controls.Add(Me.Label90)
        Me.GrpAgregarProductos.Controls.Add(Me.txt_por_Des)
        Me.GrpAgregarProductos.Controls.Add(Me.Label83)
        Me.GrpAgregarProductos.Controls.Add(Me.txtStock)
        Me.GrpAgregarProductos.Controls.Add(Me.Label68)
        Me.GrpAgregarProductos.Controls.Add(Me.Button9)
        Me.GrpAgregarProductos.Controls.Add(Me.btn_agregar_carrito)
        Me.GrpAgregarProductos.Controls.Add(Me.txtcantidad)
        Me.GrpAgregarProductos.Controls.Add(Me.txtprecioUnitario)
        Me.GrpAgregarProductos.Controls.Add(Me.Label66)
        Me.GrpAgregarProductos.Controls.Add(Me.Label67)
        Me.GrpAgregarProductos.Controls.Add(Me.Label65)
        Me.GrpAgregarProductos.Controls.Add(Me.txtdescripcionArticulo)
        Me.GrpAgregarProductos.Controls.Add(Me.Label61)
        Me.GrpAgregarProductos.Controls.Add(Me.txtcodigoArticulo)
        Me.GrpAgregarProductos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GrpAgregarProductos.ForeColor = System.Drawing.Color.Navy
        Me.GrpAgregarProductos.Location = New System.Drawing.Point(17, 37)
        Me.GrpAgregarProductos.Name = "GrpAgregarProductos"
        Me.GrpAgregarProductos.Size = New System.Drawing.Size(1189, 72)
        Me.GrpAgregarProductos.TabIndex = 204
        Me.GrpAgregarProductos.TabStop = False
        Me.GrpAgregarProductos.Text = "Detalle del Producto"
        '
        'chkigv
        '
        Me.chkigv.AutoSize = True
        Me.chkigv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkigv.Location = New System.Drawing.Point(382, 46)
        Me.chkigv.Name = "chkigv"
        Me.chkigv.Size = New System.Drawing.Size(93, 17)
        Me.chkigv.TabIndex = 199
        Me.chkigv.Text = "Incluido Igv"
        Me.chkigv.UseVisualStyleBackColor = True
        '
        'txtcantidad_fraccion
        '
        Me.txtcantidad_fraccion.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad_fraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad_fraccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad_fraccion.Location = New System.Drawing.Point(277, 78)
        Me.txtcantidad_fraccion.Name = "txtcantidad_fraccion"
        Me.txtcantidad_fraccion.Size = New System.Drawing.Size(119, 21)
        Me.txtcantidad_fraccion.TabIndex = 197
        Me.txtcantidad_fraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcantidad_fraccion.Visible = False
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label95.ForeColor = System.Drawing.Color.Navy
        Me.Label95.Location = New System.Drawing.Point(217, 82)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(54, 13)
        Me.Label95.TabIndex = 198
        Me.Label95.Text = "Fracción"
        Me.Label95.Visible = False
        '
        'txtprecioUnitario_fraccion
        '
        Me.txtprecioUnitario_fraccion.BackColor = System.Drawing.Color.White
        Me.txtprecioUnitario_fraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecioUnitario_fraccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecioUnitario_fraccion.Location = New System.Drawing.Point(679, 67)
        Me.txtprecioUnitario_fraccion.Name = "txtprecioUnitario_fraccion"
        Me.txtprecioUnitario_fraccion.Size = New System.Drawing.Size(96, 21)
        Me.txtprecioUnitario_fraccion.TabIndex = 195
        Me.txtprecioUnitario_fraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtprecioUnitario_fraccion.Visible = False
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label93.ForeColor = System.Drawing.Color.Navy
        Me.Label93.Location = New System.Drawing.Point(603, 70)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(72, 13)
        Me.Label93.TabIndex = 196
        Me.Label93.Text = "Precio Frac."
        Me.Label93.Visible = False
        '
        'txt_numero_lote
        '
        Me.txt_numero_lote.BackColor = System.Drawing.Color.White
        Me.txt_numero_lote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_lote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_lote.Location = New System.Drawing.Point(824, 72)
        Me.txt_numero_lote.Name = "txt_numero_lote"
        Me.txt_numero_lote.ReadOnly = True
        Me.txt_numero_lote.Size = New System.Drawing.Size(119, 21)
        Me.txt_numero_lote.TabIndex = 193
        Me.txt_numero_lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_numero_lote.Visible = False
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label90.ForeColor = System.Drawing.Color.Navy
        Me.Label90.Location = New System.Drawing.Point(770, 76)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(48, 13)
        Me.Label90.TabIndex = 194
        Me.Label90.Text = "N° Lote"
        Me.Label90.Visible = False
        '
        'txt_por_Des
        '
        Me.txt_por_Des.BackColor = System.Drawing.Color.White
        Me.txt_por_Des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_por_Des.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_por_Des.Location = New System.Drawing.Point(618, 72)
        Me.txt_por_Des.Name = "txt_por_Des"
        Me.txt_por_Des.Size = New System.Drawing.Size(119, 21)
        Me.txt_por_Des.TabIndex = 191
        Me.txt_por_Des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_por_Des.Visible = False
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label83.ForeColor = System.Drawing.Color.Navy
        Me.Label83.Location = New System.Drawing.Point(556, 76)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(58, 13)
        Me.Label83.TabIndex = 192
        Me.Label83.Text = "% Dscto."
        Me.Label83.Visible = False
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.White
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(432, 72)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(96, 21)
        Me.txtStock.TabIndex = 189
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStock.Visible = False
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label68.ForeColor = System.Drawing.Color.Navy
        Me.Label68.Location = New System.Drawing.Point(384, 76)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(39, 13)
        Me.Label68.TabIndex = 190
        Me.Label68.Text = "Stock"
        Me.Label68.Visible = False
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Navy
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(481, 45)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(115, 22)
        Me.Button9.TabIndex = 188
        Me.Button9.Text = "&LIMPIAR"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btn_agregar_carrito
        '
        Me.btn_agregar_carrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar_carrito.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_agregar_carrito.ForeColor = System.Drawing.Color.Green
        Me.btn_agregar_carrito.Image = CType(resources.GetObject("btn_agregar_carrito.Image"), System.Drawing.Image)
        Me.btn_agregar_carrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar_carrito.Location = New System.Drawing.Point(607, 45)
        Me.btn_agregar_carrito.Name = "btn_agregar_carrito"
        Me.btn_agregar_carrito.Size = New System.Drawing.Size(177, 22)
        Me.btn_agregar_carrito.TabIndex = 187
        Me.btn_agregar_carrito.Text = "AÑADIR AL CARRITO"
        Me.btn_agregar_carrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar_carrito.UseVisualStyleBackColor = True
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(71, 44)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(119, 21)
        Me.txtcantidad.TabIndex = 114
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.BackColor = System.Drawing.Color.White
        Me.txtprecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecioUnitario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecioUnitario.Location = New System.Drawing.Point(277, 44)
        Me.txtprecioUnitario.Name = "txtprecioUnitario"
        Me.txtprecioUnitario.Size = New System.Drawing.Size(96, 21)
        Me.txtprecioUnitario.TabIndex = 115
        Me.txtprecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label66.ForeColor = System.Drawing.Color.Navy
        Me.Label66.Location = New System.Drawing.Point(10, 48)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(57, 13)
        Me.Label66.TabIndex = 116
        Me.Label66.Text = "Cantidad"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label67.ForeColor = System.Drawing.Color.Navy
        Me.Label67.Location = New System.Drawing.Point(200, 48)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(71, 13)
        Me.Label67.TabIndex = 117
        Me.Label67.Text = "Precio Unit."
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Navy
        Me.Label65.Location = New System.Drawing.Point(199, 26)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(72, 13)
        Me.Label65.TabIndex = 113
        Me.Label65.Text = "Descripción"
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(277, 22)
        Me.txtdescripcionArticulo.MaxLength = 200
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(906, 21)
        Me.txtdescripcionArticulo.TabIndex = 112
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Navy
        Me.Label61.Location = New System.Drawing.Point(22, 26)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(45, 13)
        Me.Label61.TabIndex = 111
        Me.Label61.Text = "Codigo"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(71, 22)
        Me.txtcodigoArticulo.MaxLength = 20
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.ReadOnly = True
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(119, 21)
        Me.txtcodigoArticulo.TabIndex = 110
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.TextBox19)
        Me.GroupBox6.Controls.Add(Me.txtIsc)
        Me.GroupBox6.Controls.Add(Me.Label71)
        Me.GroupBox6.Controls.Add(Me.txtDescuentos)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.txtBruto)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.txtPrecioVenta)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.txtIgv)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.txtvalorVenta)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 342)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(341, 62)
        Me.GroupBox6.TabIndex = 205
        Me.GroupBox6.TabStop = False
        '
        'TextBox19
        '
        Me.TextBox19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox19.BackColor = System.Drawing.Color.White
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox19.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.ForeColor = System.Drawing.Color.Green
        Me.TextBox19.Location = New System.Drawing.Point(9, 15)
        Me.TextBox19.Multiline = True
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(323, 35)
        Me.TextBox19.TabIndex = 207
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIsc
        '
        Me.txtIsc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIsc.BackColor = System.Drawing.Color.White
        Me.txtIsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIsc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIsc.ForeColor = System.Drawing.Color.Green
        Me.txtIsc.Location = New System.Drawing.Point(235, 34)
        Me.txtIsc.Name = "txtIsc"
        Me.txtIsc.ReadOnly = True
        Me.txtIsc.Size = New System.Drawing.Size(97, 21)
        Me.txtIsc.TabIndex = 213
        Me.txtIsc.Text = "0.00"
        Me.txtIsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIsc.Visible = False
        '
        'Label71
        '
        Me.Label71.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Navy
        Me.Label71.Location = New System.Drawing.Point(193, 38)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(32, 13)
        Me.Label71.TabIndex = 212
        Me.Label71.Text = "I.S.C"
        Me.Label71.Visible = False
        '
        'txtDescuentos
        '
        Me.txtDescuentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentos.BackColor = System.Drawing.Color.White
        Me.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescuentos.ForeColor = System.Drawing.Color.Green
        Me.txtDescuentos.Location = New System.Drawing.Point(235, -10)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(97, 21)
        Me.txtDescuentos.TabIndex = 211
        Me.txtDescuentos.Text = "0.00"
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDescuentos.Visible = False
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(158, -6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 210
        Me.Label23.Text = "Descuento"
        Me.Label23.Visible = False
        '
        'txtBruto
        '
        Me.txtBruto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBruto.BackColor = System.Drawing.Color.White
        Me.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBruto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtBruto.ForeColor = System.Drawing.Color.Green
        Me.txtBruto.Location = New System.Drawing.Point(21, 18)
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.ReadOnly = True
        Me.txtBruto.Size = New System.Drawing.Size(89, 23)
        Me.txtBruto.TabIndex = 209
        Me.txtBruto.Text = "0.00"
        Me.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBruto.Visible = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(-27, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 16)
        Me.Label16.TabIndex = 208
        Me.Label16.Text = "Bruto"
        Me.Label16.Visible = False
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.White
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.ForeColor = System.Drawing.Color.Green
        Me.txtPrecioVenta.Location = New System.Drawing.Point(28, 40)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.ReadOnly = True
        Me.txtPrecioVenta.Size = New System.Drawing.Size(97, 23)
        Me.txtPrecioVenta.TabIndex = 206
        Me.txtPrecioVenta.Text = "0.00"
        Me.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioVenta.Visible = False
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(-17, 42)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 16)
        Me.Label28.TabIndex = 205
        Me.Label28.Text = "Total"
        Me.Label28.Visible = False
        '
        'txtIgv
        '
        Me.txtIgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIgv.BackColor = System.Drawing.Color.White
        Me.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIgv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtIgv.ForeColor = System.Drawing.Color.Green
        Me.txtIgv.Location = New System.Drawing.Point(235, 11)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.ReadOnly = True
        Me.txtIgv.Size = New System.Drawing.Size(97, 21)
        Me.txtIgv.TabIndex = 204
        Me.txtIgv.Text = "0.00"
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIgv.Visible = False
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(192, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 13)
        Me.Label24.TabIndex = 203
        Me.Label24.Text = "I.G.V"
        Me.Label24.Visible = False
        '
        'txtvalorVenta
        '
        Me.txtvalorVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvalorVenta.BackColor = System.Drawing.Color.White
        Me.txtvalorVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtvalorVenta.ForeColor = System.Drawing.Color.Green
        Me.txtvalorVenta.Location = New System.Drawing.Point(235, -32)
        Me.txtvalorVenta.Name = "txtvalorVenta"
        Me.txtvalorVenta.ReadOnly = True
        Me.txtvalorVenta.Size = New System.Drawing.Size(97, 21)
        Me.txtvalorVenta.TabIndex = 202
        Me.txtvalorVenta.Text = "0.00"
        Me.txtvalorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtvalorVenta.Visible = False
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(172, -29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 201
        Me.Label22.Text = "V. Venta"
        Me.Label22.Visible = False
        '
        'GrpProductos
        '
        Me.GrpProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpProductos.BackColor = System.Drawing.Color.White
        Me.GrpProductos.Controls.Add(Me.dgv_lista_productos)
        Me.GrpProductos.Controls.Add(Me.txt_buscador_productos)
        Me.GrpProductos.Controls.Add(Me.txt_buscador_especial)
        Me.GrpProductos.Controls.Add(Me.PictureBox16)
        Me.GrpProductos.Controls.Add(Me.PictureBox17)
        Me.GrpProductos.Controls.Add(Me.PictureBox18)
        Me.GrpProductos.Controls.Add(Me.TextBox21)
        Me.GrpProductos.Controls.Add(Me.Label62)
        Me.GrpProductos.Controls.Add(Me.TextBox22)
        Me.GrpProductos.Controls.Add(Me.Label63)
        Me.GrpProductos.Controls.Add(Me.TextBox23)
        Me.GrpProductos.Controls.Add(Me.Label64)
        Me.GrpProductos.Controls.Add(Me.PictureBox19)
        Me.GrpProductos.Controls.Add(Me.PictureBox20)
        Me.GrpProductos.Controls.Add(Me.RadioButton1)
        Me.GrpProductos.Controls.Add(Me.RadioButton2)
        Me.GrpProductos.Controls.Add(Me.Label69)
        Me.GrpProductos.Controls.Add(Me.TextBox33)
        Me.GrpProductos.Controls.Add(Me.TextBox34)
        Me.GrpProductos.Controls.Add(Me.Label70)
        Me.GrpProductos.Controls.Add(Me.TextBox35)
        Me.GrpProductos.Controls.Add(Me.ComboBox1)
        Me.GrpProductos.Controls.Add(Me.Label72)
        Me.GrpProductos.Controls.Add(Me.TextBox37)
        Me.GrpProductos.Controls.Add(Me.Label73)
        Me.GrpProductos.Controls.Add(Me.TextBox38)
        Me.GrpProductos.Controls.Add(Me.Label74)
        Me.GrpProductos.Controls.Add(Me.TextBox39)
        Me.GrpProductos.Controls.Add(Me.Label75)
        Me.GrpProductos.Controls.Add(Me.TextBox40)
        Me.GrpProductos.Controls.Add(Me.Label76)
        Me.GrpProductos.Controls.Add(Me.TextBox41)
        Me.GrpProductos.Controls.Add(Me.PictureBox22)
        Me.GrpProductos.Controls.Add(Me.TextBox42)
        Me.GrpProductos.Controls.Add(Me.Label77)
        Me.GrpProductos.Controls.Add(Me.TextBox43)
        Me.GrpProductos.Controls.Add(Me.PictureBox23)
        Me.GrpProductos.Controls.Add(Me.TextBox44)
        Me.GrpProductos.Controls.Add(Me.Label78)
        Me.GrpProductos.Controls.Add(Me.TextBox45)
        Me.GrpProductos.Controls.Add(Me.PictureBox24)
        Me.GrpProductos.Controls.Add(Me.TextBox46)
        Me.GrpProductos.Controls.Add(Me.Label79)
        Me.GrpProductos.Controls.Add(Me.TextBox47)
        Me.GrpProductos.Controls.Add(Me.Label80)
        Me.GrpProductos.Controls.Add(Me.TextBox49)
        Me.GrpProductos.Controls.Add(Me.TextBox51)
        Me.GrpProductos.Controls.Add(Me.Label81)
        Me.GrpProductos.Controls.Add(Me.Label82)
        Me.GrpProductos.Controls.Add(Me.TextBox52)
        Me.GrpProductos.Controls.Add(Me.PictureBox27)
        Me.GrpProductos.Controls.Add(Me.ComboBox2)
        Me.GrpProductos.Controls.Add(Me.Label85)
        Me.GrpProductos.Controls.Add(Me.TextBox61)
        Me.GrpProductos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GrpProductos.ForeColor = System.Drawing.Color.Navy
        Me.GrpProductos.Location = New System.Drawing.Point(46, 144)
        Me.GrpProductos.Name = "GrpProductos"
        Me.GrpProductos.Size = New System.Drawing.Size(1120, 180)
        Me.GrpProductos.TabIndex = 206
        Me.GrpProductos.TabStop = False
        Me.GrpProductos.Text = "Productos"
        Me.GrpProductos.Visible = False
        '
        'dgv_lista_productos
        '
        Me.dgv_lista_productos.AllowUserToAddRows = False
        Me.dgv_lista_productos.AllowUserToDeleteRows = False
        Me.dgv_lista_productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lista_productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.dgv_lista_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_productos.EnableHeadersVisualStyles = False
        Me.dgv_lista_productos.Location = New System.Drawing.Point(12, 49)
        Me.dgv_lista_productos.Name = "dgv_lista_productos"
        Me.dgv_lista_productos.ReadOnly = True
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lista_productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.dgv_lista_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_productos.Size = New System.Drawing.Size(1098, 119)
        Me.dgv_lista_productos.TabIndex = 189
        '
        'txt_buscador_productos
        '
        Me.txt_buscador_productos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_buscador_productos.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_buscador_productos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscador_productos.Location = New System.Drawing.Point(12, 19)
        Me.txt_buscador_productos.MaxLength = 200
        Me.txt_buscador_productos.Name = "txt_buscador_productos"
        Me.txt_buscador_productos.Size = New System.Drawing.Size(1098, 21)
        Me.txt_buscador_productos.TabIndex = 188
        '
        'txt_buscador_especial
        '
        Me.txt_buscador_especial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_buscador_especial.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_buscador_especial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscador_especial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscador_especial.Location = New System.Drawing.Point(12, 84)
        Me.txt_buscador_especial.Name = "txt_buscador_especial"
        Me.txt_buscador_especial.Size = New System.Drawing.Size(746, 21)
        Me.txt_buscador_especial.TabIndex = 187
        Me.txt_buscador_especial.Visible = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(2949, 290)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox16.TabIndex = 185
        Me.PictureBox16.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), System.Drawing.Image)
        Me.PictureBox17.Location = New System.Drawing.Point(2780, 290)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox17.TabIndex = 184
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = CType(resources.GetObject("PictureBox18.Image"), System.Drawing.Image)
        Me.PictureBox18.Location = New System.Drawing.Point(2570, 290)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox18.TabIndex = 183
        Me.PictureBox18.TabStop = False
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.Color.White
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox21.Location = New System.Drawing.Point(2846, 289)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = True
        Me.TextBox21.Size = New System.Drawing.Size(122, 21)
        Me.TextBox21.TabIndex = 181
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label62.ForeColor = System.Drawing.Color.Navy
        Me.Label62.Location = New System.Drawing.Point(2804, 292)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(37, 13)
        Me.Label62.TabIndex = 182
        Me.Label62.Text = "Trama"
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.Color.White
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox22.Location = New System.Drawing.Point(2698, 289)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.ReadOnly = True
        Me.TextBox22.Size = New System.Drawing.Size(100, 21)
        Me.TextBox22.TabIndex = 179
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label63.ForeColor = System.Drawing.Color.Navy
        Me.Label63.Location = New System.Drawing.Point(2593, 292)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(102, 13)
        Me.Label63.TabIndex = 180
        Me.Label63.Text = "Empresa Transporte"
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.Color.White
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox23.Location = New System.Drawing.Point(2486, 289)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.ReadOnly = True
        Me.TextBox23.Size = New System.Drawing.Size(103, 21)
        Me.TextBox23.TabIndex = 177
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label64.ForeColor = System.Drawing.Color.Navy
        Me.Label64.Location = New System.Drawing.Point(2433, 292)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(48, 13)
        Me.Label64.TabIndex = 178
        Me.Label64.Text = "Vehiculo"
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = CType(resources.GetObject("PictureBox19.Image"), System.Drawing.Image)
        Me.PictureBox19.Location = New System.Drawing.Point(2789, 236)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox19.TabIndex = 118
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Visible = False
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = CType(resources.GetObject("PictureBox20.Image"), System.Drawing.Image)
        Me.PictureBox20.Location = New System.Drawing.Point(1454, 39)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox20.TabIndex = 176
        Me.PictureBox20.TabStop = False
        Me.PictureBox20.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton1.Location = New System.Drawing.Point(1770, 39)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(111, 17)
        Me.RadioButton1.TabIndex = 174
        Me.RadioButton1.Text = "& Varios doc Ref."
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton2.Location = New System.Drawing.Point(1262, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(91, 17)
        Me.RadioButton2.TabIndex = 173
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Un doc. Ref."
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label69.ForeColor = System.Drawing.Color.Navy
        Me.Label69.Location = New System.Drawing.Point(1480, 41)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(74, 13)
        Me.Label69.TabIndex = 161
        Me.Label69.Text = "Serie.Doc.Ref"
        Me.Label69.Visible = False
        '
        'TextBox33
        '
        Me.TextBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox33.Location = New System.Drawing.Point(1558, 37)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(32, 21)
        Me.TextBox33.TabIndex = 7
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox33.Visible = False
        '
        'TextBox34
        '
        Me.TextBox34.BackColor = System.Drawing.Color.White
        Me.TextBox34.Location = New System.Drawing.Point(1427, 38)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.ReadOnly = True
        Me.TextBox34.Size = New System.Drawing.Size(24, 21)
        Me.TextBox34.TabIndex = 6
        Me.TextBox34.Visible = False
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label70.ForeColor = System.Drawing.Color.Navy
        Me.Label70.Location = New System.Drawing.Point(1355, 42)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(71, 13)
        Me.Label70.TabIndex = 157
        Me.Label70.Text = "Tipo.Doc.Ref"
        Me.Label70.Visible = False
        '
        'TextBox35
        '
        Me.TextBox35.BackColor = System.Drawing.Color.White
        Me.TextBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox35.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox35.ForeColor = System.Drawing.Color.Green
        Me.TextBox35.Location = New System.Drawing.Point(650, 72)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.ReadOnly = True
        Me.TextBox35.Size = New System.Drawing.Size(47, 27)
        Me.TextBox35.TabIndex = 22
        Me.TextBox35.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(2522, 260)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(597, 21)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.Visible = False
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label72.ForeColor = System.Drawing.Color.Navy
        Me.Label72.Location = New System.Drawing.Point(2426, 262)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(91, 13)
        Me.Label72.TabIndex = 13
        Me.Label72.Text = "Dirección entrega"
        '
        'TextBox37
        '
        Me.TextBox37.BackColor = System.Drawing.Color.White
        Me.TextBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox37.Location = New System.Drawing.Point(2684, 211)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.ReadOnly = True
        Me.TextBox37.Size = New System.Drawing.Size(110, 21)
        Me.TextBox37.TabIndex = 13
        Me.TextBox37.Visible = False
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label73.ForeColor = System.Drawing.Color.Navy
        Me.Label73.Location = New System.Drawing.Point(2591, 214)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(90, 13)
        Me.Label73.TabIndex = 149
        Me.Label73.Text = "Orden de Compra"
        Me.Label73.Visible = False
        '
        'TextBox38
        '
        Me.TextBox38.BackColor = System.Drawing.Color.White
        Me.TextBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox38.Location = New System.Drawing.Point(2486, 210)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.ReadOnly = True
        Me.TextBox38.Size = New System.Drawing.Size(100, 21)
        Me.TextBox38.TabIndex = 12
        Me.TextBox38.Visible = False
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label74.ForeColor = System.Drawing.Color.Navy
        Me.Label74.Location = New System.Drawing.Point(2425, 213)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(56, 13)
        Me.Label74.TabIndex = 147
        Me.Label74.Text = "Cotizacion"
        Me.Label74.Visible = False
        '
        'TextBox39
        '
        Me.TextBox39.BackColor = System.Drawing.Color.White
        Me.TextBox39.Location = New System.Drawing.Point(1658, 37)
        Me.TextBox39.Multiline = True
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox39.Size = New System.Drawing.Size(107, 20)
        Me.TextBox39.TabIndex = 8
        Me.TextBox39.Visible = False
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label75.ForeColor = System.Drawing.Color.Navy
        Me.Label75.Location = New System.Drawing.Point(1593, 40)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(67, 13)
        Me.Label75.TabIndex = 145
        Me.Label75.Text = "Nro.Doc.Ref"
        Me.Label75.Visible = False
        '
        'TextBox40
        '
        Me.TextBox40.BackColor = System.Drawing.Color.White
        Me.TextBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox40.Location = New System.Drawing.Point(2880, 211)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(101, 21)
        Me.TextBox40.TabIndex = 14
        Me.TextBox40.Visible = False
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label76.ForeColor = System.Drawing.Color.Navy
        Me.Label76.Location = New System.Drawing.Point(2798, 215)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(80, 13)
        Me.Label76.TabIndex = 143
        Me.Label76.Text = "Numero Pedido"
        Me.Label76.Visible = False
        '
        'TextBox41
        '
        Me.TextBox41.BackColor = System.Drawing.Color.White
        Me.TextBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox41.Location = New System.Drawing.Point(1372, 178)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.ReadOnly = True
        Me.TextBox41.Size = New System.Drawing.Size(47, 21)
        Me.TextBox41.TabIndex = 142
        Me.TextBox41.Visible = False
        '
        'PictureBox22
        '
        Me.PictureBox22.Image = CType(resources.GetObject("PictureBox22.Image"), System.Drawing.Image)
        Me.PictureBox22.Location = New System.Drawing.Point(1354, 179)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox22.TabIndex = 141
        Me.PictureBox22.TabStop = False
        Me.PictureBox22.Visible = False
        '
        'TextBox42
        '
        Me.TextBox42.Location = New System.Drawing.Point(1314, 178)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(37, 21)
        Me.TextBox42.TabIndex = 139
        Me.TextBox42.Visible = False
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(1272, 181)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(44, 13)
        Me.Label77.TabIndex = 140
        Me.Label77.Text = "Trama"
        Me.Label77.Visible = False
        '
        'TextBox43
        '
        Me.TextBox43.BackColor = System.Drawing.Color.White
        Me.TextBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox43.Location = New System.Drawing.Point(1265, 259)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.ReadOnly = True
        Me.TextBox43.Size = New System.Drawing.Size(47, 21)
        Me.TextBox43.TabIndex = 138
        Me.TextBox43.Visible = False
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = CType(resources.GetObject("PictureBox23.Image"), System.Drawing.Image)
        Me.PictureBox23.Location = New System.Drawing.Point(1247, 260)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox23.TabIndex = 137
        Me.PictureBox23.TabStop = False
        Me.PictureBox23.Visible = False
        '
        'TextBox44
        '
        Me.TextBox44.Location = New System.Drawing.Point(1376, 256)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(44, 21)
        Me.TextBox44.TabIndex = 135
        Me.TextBox44.Visible = False
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(1377, 237)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(122, 13)
        Me.Label78.TabIndex = 136
        Me.Label78.Text = "Empresa Transporte"
        Me.Label78.Visible = False
        '
        'TextBox45
        '
        Me.TextBox45.BackColor = System.Drawing.Color.White
        Me.TextBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox45.Location = New System.Drawing.Point(1372, 153)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.ReadOnly = True
        Me.TextBox45.Size = New System.Drawing.Size(45, 21)
        Me.TextBox45.TabIndex = 134
        Me.TextBox45.Visible = False
        '
        'PictureBox24
        '
        Me.PictureBox24.Image = CType(resources.GetObject("PictureBox24.Image"), System.Drawing.Image)
        Me.PictureBox24.Location = New System.Drawing.Point(1354, 154)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox24.TabIndex = 133
        Me.PictureBox24.TabStop = False
        Me.PictureBox24.Visible = False
        '
        'TextBox46
        '
        Me.TextBox46.Location = New System.Drawing.Point(1314, 153)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(37, 21)
        Me.TextBox46.TabIndex = 131
        Me.TextBox46.Visible = False
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(1259, 156)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(57, 13)
        Me.Label79.TabIndex = 132
        Me.Label79.Text = "Vehiculo "
        Me.Label79.Visible = False
        '
        'TextBox47
        '
        Me.TextBox47.BackColor = System.Drawing.Color.White
        Me.TextBox47.Location = New System.Drawing.Point(1291, 256)
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.ReadOnly = True
        Me.TextBox47.Size = New System.Drawing.Size(58, 21)
        Me.TextBox47.TabIndex = 130
        Me.TextBox47.Visible = False
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label80.Location = New System.Drawing.Point(1270, 241)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(107, 13)
        Me.Label80.TabIndex = 129
        Me.Label80.Text = "%DescuentoEspecial"
        Me.Label80.Visible = False
        '
        'TextBox49
        '
        Me.TextBox49.BackColor = System.Drawing.Color.White
        Me.TextBox49.Location = New System.Drawing.Point(1249, 201)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.ReadOnly = True
        Me.TextBox49.Size = New System.Drawing.Size(48, 21)
        Me.TextBox49.TabIndex = 128
        Me.TextBox49.Visible = False
        '
        'TextBox51
        '
        Me.TextBox51.BackColor = System.Drawing.Color.White
        Me.TextBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox51.Enabled = False
        Me.TextBox51.Location = New System.Drawing.Point(2810, 234)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(310, 21)
        Me.TextBox51.TabIndex = 31
        Me.TextBox51.Text = "."
        Me.TextBox51.Visible = False
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label81.Location = New System.Drawing.Point(1230, 211)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(99, 13)
        Me.Label81.TabIndex = 127
        Me.Label81.Text = "%DescuentoCliente"
        Me.Label81.Visible = False
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label82.ForeColor = System.Drawing.Color.Navy
        Me.Label82.Location = New System.Drawing.Point(2690, 238)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(68, 13)
        Me.Label82.TabIndex = 2
        Me.Label82.Text = "Transportista"
        Me.Label82.Visible = False
        '
        'TextBox52
        '
        Me.TextBox52.BackColor = System.Drawing.Color.White
        Me.TextBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox52.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox52.ForeColor = System.Drawing.Color.Green
        Me.TextBox52.Location = New System.Drawing.Point(650, 34)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.ReadOnly = True
        Me.TextBox52.Size = New System.Drawing.Size(47, 27)
        Me.TextBox52.TabIndex = 20
        Me.TextBox52.Visible = False
        '
        'PictureBox27
        '
        Me.PictureBox27.Image = CType(resources.GetObject("PictureBox27.Image"), System.Drawing.Image)
        Me.PictureBox27.Location = New System.Drawing.Point(620, 34)
        Me.PictureBox27.Name = "PictureBox27"
        Me.PictureBox27.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox27.TabIndex = 111
        Me.PictureBox27.TabStop = False
        Me.PictureBox27.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(2627, 235)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(60, 21)
        Me.ComboBox2.TabIndex = 15
        Me.ComboBox2.Visible = False
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label85.ForeColor = System.Drawing.Color.Navy
        Me.Label85.Location = New System.Drawing.Point(2555, 239)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(71, 13)
        Me.Label85.TabIndex = 0
        Me.Label85.Text = "Serie de Guia"
        Me.Label85.Visible = False
        '
        'TextBox61
        '
        Me.TextBox61.BackColor = System.Drawing.Color.White
        Me.TextBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox61.Location = New System.Drawing.Point(2760, 235)
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New System.Drawing.Size(25, 21)
        Me.TextBox61.TabIndex = 16
        Me.TextBox61.Text = "00"
        Me.TextBox61.Visible = False
        '
        'pnl_motivo_anulacion
        '
        Me.pnl_motivo_anulacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_motivo_anulacion.Controls.Add(Me.txt_motivo_anulacion)
        Me.pnl_motivo_anulacion.Controls.Add(Me.TextBox20)
        Me.pnl_motivo_anulacion.Controls.Add(Me.GroupBox19)
        Me.pnl_motivo_anulacion.Controls.Add(Me.GroupBox20)
        Me.pnl_motivo_anulacion.Location = New System.Drawing.Point(1012, 30)
        Me.pnl_motivo_anulacion.Name = "pnl_motivo_anulacion"
        Me.pnl_motivo_anulacion.Size = New System.Drawing.Size(46, 129)
        Me.pnl_motivo_anulacion.TabIndex = 207
        Me.pnl_motivo_anulacion.Visible = False
        '
        'txt_motivo_anulacion
        '
        Me.txt_motivo_anulacion.BackColor = System.Drawing.Color.White
        Me.txt_motivo_anulacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_motivo_anulacion.ForeColor = System.Drawing.Color.Maroon
        Me.txt_motivo_anulacion.Location = New System.Drawing.Point(18, 94)
        Me.txt_motivo_anulacion.MaxLength = 200
        Me.txt_motivo_anulacion.Name = "txt_motivo_anulacion"
        Me.txt_motivo_anulacion.Size = New System.Drawing.Size(405, 20)
        Me.txt_motivo_anulacion.TabIndex = 185
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.Navy
        Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox20.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox20.ForeColor = System.Drawing.Color.White
        Me.TextBox20.Location = New System.Drawing.Point(1, 1)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(440, 20)
        Me.TextBox20.TabIndex = 168
        Me.TextBox20.Text = "MOTIVO DE ANULACIÓN"
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.dtp_fecha_anulacion)
        Me.GroupBox19.Controls.Add(Me.Label84)
        Me.GroupBox19.Controls.Add(Me.Label86)
        Me.GroupBox19.Controls.Add(Me.Label87)
        Me.GroupBox19.Controls.Add(Me.Button8)
        Me.GroupBox19.Controls.Add(Me.Button10)
        Me.GroupBox19.Location = New System.Drawing.Point(9, 21)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(424, 55)
        Me.GroupBox19.TabIndex = 0
        Me.GroupBox19.TabStop = False
        '
        'dtp_fecha_anulacion
        '
        Me.dtp_fecha_anulacion.Enabled = False
        Me.dtp_fecha_anulacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_anulacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_anulacion.Location = New System.Drawing.Point(124, 26)
        Me.dtp_fecha_anulacion.Name = "dtp_fecha_anulacion"
        Me.dtp_fecha_anulacion.Size = New System.Drawing.Size(119, 21)
        Me.dtp_fecha_anulacion.TabIndex = 126
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.Navy
        Me.Label84.Location = New System.Drawing.Point(7, 31)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(108, 13)
        Me.Label84.TabIndex = 125
        Me.Label84.Text = "Fecha Documento"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.Maroon
        Me.Label86.Location = New System.Drawing.Point(126, 12)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(16, 13)
        Me.Label86.TabIndex = 124
        Me.Label86.Text = "..."
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.Navy
        Me.Label87.Location = New System.Drawing.Point(8, 12)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(97, 13)
        Me.Label87.TabIndex = 123
        Me.Label87.Text = "Nro. Documento"
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Navy
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(329, 12)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(62, 37)
        Me.Button8.TabIndex = 121
        Me.Button8.Text = "Cancelar"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.Navy
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(259, 12)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(62, 37)
        Me.Button10.TabIndex = 122
        Me.Button10.Text = "Confirmar"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.UseVisualStyleBackColor = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Location = New System.Drawing.Point(8, 79)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(425, 43)
        Me.GroupBox20.TabIndex = 201
        Me.GroupBox20.TabStop = False
        '
        'pnl_cierre_ventas
        '
        Me.pnl_cierre_ventas.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_cierre_ventas.Controls.Add(Me.TextBox25)
        Me.pnl_cierre_ventas.Controls.Add(Me.GroupBox9)
        Me.pnl_cierre_ventas.Location = New System.Drawing.Point(1012, 30)
        Me.pnl_cierre_ventas.Name = "pnl_cierre_ventas"
        Me.pnl_cierre_ventas.Size = New System.Drawing.Size(20, 486)
        Me.pnl_cierre_ventas.TabIndex = 208
        Me.pnl_cierre_ventas.Visible = False
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.Color.Navy
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox25.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox25.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.ForeColor = System.Drawing.Color.White
        Me.TextBox25.Location = New System.Drawing.Point(0, 0)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(20, 25)
        Me.TextBox25.TabIndex = 168
        Me.TextBox25.Text = "CIERRE DE VENTAS"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.gb_pago_tarjeta)
        Me.GroupBox9.Controls.Add(Me.gb_pago_efectivo)
        Me.GroupBox9.Controls.Add(Me.lbl_usuario_cierre)
        Me.GroupBox9.Controls.Add(Me.Label94)
        Me.GroupBox9.Controls.Add(Me.dtp_fecha_cierre_ventas)
        Me.GroupBox9.Controls.Add(Me.Label88)
        Me.GroupBox9.Controls.Add(Me.Button11)
        Me.GroupBox9.Controls.Add(Me.Button12)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(435, 443)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        '
        'gb_pago_tarjeta
        '
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox1)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox15)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox21)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox25)
        Me.gb_pago_tarjeta.Controls.Add(Me.AMOUNT_AMERICAN_EXPRES)
        Me.gb_pago_tarjeta.Controls.Add(Me.AMOUNT_DINERS)
        Me.gb_pago_tarjeta.Controls.Add(Me.AMOUNT_CARD_MASTER)
        Me.gb_pago_tarjeta.Controls.Add(Me.AMOUNT_CARD_VISA)
        Me.gb_pago_tarjeta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_pago_tarjeta.ForeColor = System.Drawing.Color.Green
        Me.gb_pago_tarjeta.Location = New System.Drawing.Point(25, 172)
        Me.gb_pago_tarjeta.Name = "gb_pago_tarjeta"
        Me.gb_pago_tarjeta.Size = New System.Drawing.Size(291, 258)
        Me.gb_pago_tarjeta.TabIndex = 240
        Me.gb_pago_tarjeta.TabStop = False
        Me.gb_pago_tarjeta.Text = "Cobro con Tarjeta"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 196)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(17, 140)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox15.TabIndex = 10
        Me.PictureBox15.TabStop = False
        '
        'PictureBox21
        '
        Me.PictureBox21.Image = CType(resources.GetObject("PictureBox21.Image"), System.Drawing.Image)
        Me.PictureBox21.Location = New System.Drawing.Point(17, 84)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox21.TabIndex = 9
        Me.PictureBox21.TabStop = False
        '
        'PictureBox25
        '
        Me.PictureBox25.Image = CType(resources.GetObject("PictureBox25.Image"), System.Drawing.Image)
        Me.PictureBox25.Location = New System.Drawing.Point(17, 28)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox25.TabIndex = 8
        Me.PictureBox25.TabStop = False
        '
        'AMOUNT_AMERICAN_EXPRES
        '
        Me.AMOUNT_AMERICAN_EXPRES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMOUNT_AMERICAN_EXPRES.ForeColor = System.Drawing.Color.Maroon
        Me.AMOUNT_AMERICAN_EXPRES.Location = New System.Drawing.Point(133, 207)
        Me.AMOUNT_AMERICAN_EXPRES.Name = "AMOUNT_AMERICAN_EXPRES"
        Me.AMOUNT_AMERICAN_EXPRES.Size = New System.Drawing.Size(135, 26)
        Me.AMOUNT_AMERICAN_EXPRES.TabIndex = 7
        Me.AMOUNT_AMERICAN_EXPRES.Text = "0"
        Me.AMOUNT_AMERICAN_EXPRES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AMOUNT_DINERS
        '
        Me.AMOUNT_DINERS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMOUNT_DINERS.ForeColor = System.Drawing.Color.Maroon
        Me.AMOUNT_DINERS.Location = New System.Drawing.Point(133, 151)
        Me.AMOUNT_DINERS.Name = "AMOUNT_DINERS"
        Me.AMOUNT_DINERS.Size = New System.Drawing.Size(135, 26)
        Me.AMOUNT_DINERS.TabIndex = 6
        Me.AMOUNT_DINERS.Text = "0"
        Me.AMOUNT_DINERS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AMOUNT_CARD_MASTER
        '
        Me.AMOUNT_CARD_MASTER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMOUNT_CARD_MASTER.ForeColor = System.Drawing.Color.Maroon
        Me.AMOUNT_CARD_MASTER.Location = New System.Drawing.Point(133, 95)
        Me.AMOUNT_CARD_MASTER.Name = "AMOUNT_CARD_MASTER"
        Me.AMOUNT_CARD_MASTER.Size = New System.Drawing.Size(135, 26)
        Me.AMOUNT_CARD_MASTER.TabIndex = 5
        Me.AMOUNT_CARD_MASTER.Text = "0"
        Me.AMOUNT_CARD_MASTER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AMOUNT_CARD_VISA
        '
        Me.AMOUNT_CARD_VISA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMOUNT_CARD_VISA.ForeColor = System.Drawing.Color.Maroon
        Me.AMOUNT_CARD_VISA.Location = New System.Drawing.Point(133, 39)
        Me.AMOUNT_CARD_VISA.Name = "AMOUNT_CARD_VISA"
        Me.AMOUNT_CARD_VISA.Size = New System.Drawing.Size(135, 26)
        Me.AMOUNT_CARD_VISA.TabIndex = 4
        Me.AMOUNT_CARD_VISA.Text = "0"
        Me.AMOUNT_CARD_VISA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gb_pago_efectivo
        '
        Me.gb_pago_efectivo.Controls.Add(Me.TxEfeDol)
        Me.gb_pago_efectivo.Controls.Add(Me.txt_saldo_final)
        Me.gb_pago_efectivo.Controls.Add(Me.Label96)
        Me.gb_pago_efectivo.Controls.Add(Me.Label97)
        Me.gb_pago_efectivo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_pago_efectivo.ForeColor = System.Drawing.Color.Green
        Me.gb_pago_efectivo.Location = New System.Drawing.Point(25, 89)
        Me.gb_pago_efectivo.Name = "gb_pago_efectivo"
        Me.gb_pago_efectivo.Size = New System.Drawing.Size(291, 77)
        Me.gb_pago_efectivo.TabIndex = 239
        Me.gb_pago_efectivo.TabStop = False
        Me.gb_pago_efectivo.Text = "Cobro en Efectivo"
        '
        'TxEfeDol
        '
        Me.TxEfeDol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxEfeDol.ForeColor = System.Drawing.Color.Maroon
        Me.TxEfeDol.Location = New System.Drawing.Point(133, 70)
        Me.TxEfeDol.Name = "TxEfeDol"
        Me.TxEfeDol.Size = New System.Drawing.Size(135, 26)
        Me.TxEfeDol.TabIndex = 3
        Me.TxEfeDol.Text = "0"
        Me.TxEfeDol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxEfeDol.Visible = False
        '
        'txt_saldo_final
        '
        Me.txt_saldo_final.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_saldo_final.ForeColor = System.Drawing.Color.Maroon
        Me.txt_saldo_final.Location = New System.Drawing.Point(133, 31)
        Me.txt_saldo_final.Name = "txt_saldo_final"
        Me.txt_saldo_final.Size = New System.Drawing.Size(135, 26)
        Me.txt_saldo_final.TabIndex = 2
        Me.txt_saldo_final.Text = "0"
        Me.txt_saldo_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(17, 70)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(91, 26)
        Me.Label96.TabIndex = 1
        Me.Label96.Text = "Dolares"
        Me.Label96.Visible = False
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(73, 35)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(45, 19)
        Me.Label97.TabIndex = 0
        Me.Label97.Text = "Soles"
        '
        'lbl_usuario_cierre
        '
        Me.lbl_usuario_cierre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_cierre.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_usuario_cierre.Location = New System.Drawing.Point(154, 16)
        Me.lbl_usuario_cierre.Name = "lbl_usuario_cierre"
        Me.lbl_usuario_cierre.Size = New System.Drawing.Size(257, 31)
        Me.lbl_usuario_cierre.TabIndex = 236
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.Green
        Me.Label94.Location = New System.Drawing.Point(76, 18)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(66, 19)
        Me.Label94.TabIndex = 235
        Me.Label94.Text = "Usuario:"
        '
        'dtp_fecha_cierre_ventas
        '
        Me.dtp_fecha_cierre_ventas.CalendarForeColor = System.Drawing.Color.Maroon
        Me.dtp_fecha_cierre_ventas.Enabled = False
        Me.dtp_fecha_cierre_ventas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_cierre_ventas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_cierre_ventas.Location = New System.Drawing.Point(154, 51)
        Me.dtp_fecha_cierre_ventas.Name = "dtp_fecha_cierre_ventas"
        Me.dtp_fecha_cierre_ventas.Size = New System.Drawing.Size(109, 26)
        Me.dtp_fecha_cierre_ventas.TabIndex = 126
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.Green
        Me.Label88.Location = New System.Drawing.Point(88, 55)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(54, 19)
        Me.Label88.TabIndex = 125
        Me.Label88.Text = "Fecha:"
        '
        'Button11
        '
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Navy
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button11.Location = New System.Drawing.Point(346, 376)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 42)
        Me.Button11.TabIndex = 121
        Me.Button11.Text = "Cancelar"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Navy
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button12.Location = New System.Drawing.Point(346, 323)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 42)
        Me.Button12.TabIndex = 122
        Me.Button12.Text = "Confirmar"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button12.UseVisualStyleBackColor = True
        '
        'pnlNuevaPlanilla
        '
        Me.pnlNuevaPlanilla.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlNuevaPlanilla.Controls.Add(Me.TextBox24)
        Me.pnlNuevaPlanilla.Controls.Add(Me.gb_nueva_planilla)
        Me.pnlNuevaPlanilla.Location = New System.Drawing.Point(1012, 30)
        Me.pnlNuevaPlanilla.Name = "pnlNuevaPlanilla"
        Me.pnlNuevaPlanilla.Size = New System.Drawing.Size(29, 223)
        Me.pnlNuevaPlanilla.TabIndex = 212
        Me.pnlNuevaPlanilla.Visible = False
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.Color.Navy
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox24.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox24.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox24.ForeColor = System.Drawing.Color.White
        Me.TextBox24.Location = New System.Drawing.Point(0, 0)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(29, 20)
        Me.TextBox24.TabIndex = 169
        Me.TextBox24.Text = "APERTURA CAJA CHICA"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gb_nueva_planilla
        '
        Me.gb_nueva_planilla.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gb_nueva_planilla.Controls.Add(Me.lbl_nombre_usuario)
        Me.gb_nueva_planilla.Controls.Add(Me.Label92)
        Me.gb_nueva_planilla.Controls.Add(Me.txt_saldo_inicial_caja)
        Me.gb_nueva_planilla.Controls.Add(Me.Label91)
        Me.gb_nueva_planilla.Controls.Add(Me.btn_cancelar_crear)
        Me.gb_nueva_planilla.Controls.Add(Me.btn_crear_planilla)
        Me.gb_nueva_planilla.Controls.Add(Me.dtp_fec_nueva_pla)
        Me.gb_nueva_planilla.Controls.Add(Me.Label89)
        Me.gb_nueva_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_nueva_planilla.ForeColor = System.Drawing.Color.Navy
        Me.gb_nueva_planilla.Location = New System.Drawing.Point(9, 29)
        Me.gb_nueva_planilla.Name = "gb_nueva_planilla"
        Me.gb_nueva_planilla.Size = New System.Drawing.Size(284, 182)
        Me.gb_nueva_planilla.TabIndex = 2
        Me.gb_nueva_planilla.TabStop = False
        Me.gb_nueva_planilla.Text = "Datos"
        '
        'lbl_nombre_usuario
        '
        Me.lbl_nombre_usuario.AutoSize = True
        Me.lbl_nombre_usuario.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_usuario.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nombre_usuario.Location = New System.Drawing.Point(113, 31)
        Me.lbl_nombre_usuario.Name = "lbl_nombre_usuario"
        Me.lbl_nombre_usuario.Size = New System.Drawing.Size(0, 16)
        Me.lbl_nombre_usuario.TabIndex = 234
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.Navy
        Me.Label92.Location = New System.Drawing.Point(43, 31)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(61, 16)
        Me.Label92.TabIndex = 233
        Me.Label92.Text = "Usuario:"
        '
        'txt_saldo_inicial_caja
        '
        Me.txt_saldo_inicial_caja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_saldo_inicial_caja.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_saldo_inicial_caja.ForeColor = System.Drawing.Color.Maroon
        Me.txt_saldo_inicial_caja.Location = New System.Drawing.Point(113, 104)
        Me.txt_saldo_inicial_caja.MaxLength = 200
        Me.txt_saldo_inicial_caja.Name = "txt_saldo_inicial_caja"
        Me.txt_saldo_inicial_caja.Size = New System.Drawing.Size(106, 23)
        Me.txt_saldo_inicial_caja.TabIndex = 232
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.Navy
        Me.Label91.Location = New System.Drawing.Point(15, 107)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(89, 16)
        Me.Label91.TabIndex = 10
        Me.Label91.Text = "Saldo Inicial:"
        '
        'btn_cancelar_crear
        '
        Me.btn_cancelar_crear.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancelar_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_crear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_crear.Image = CType(resources.GetObject("btn_cancelar_crear.Image"), System.Drawing.Image)
        Me.btn_cancelar_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar_crear.Location = New System.Drawing.Point(144, 135)
        Me.btn_cancelar_crear.Name = "btn_cancelar_crear"
        Me.btn_cancelar_crear.Size = New System.Drawing.Size(64, 39)
        Me.btn_cancelar_crear.TabIndex = 9
        Me.btn_cancelar_crear.Text = "&Salir"
        Me.btn_cancelar_crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar_crear.UseVisualStyleBackColor = True
        '
        'btn_crear_planilla
        '
        Me.btn_crear_planilla.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_crear_planilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_crear_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear_planilla.Image = CType(resources.GetObject("btn_crear_planilla.Image"), System.Drawing.Image)
        Me.btn_crear_planilla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_crear_planilla.Location = New System.Drawing.Point(78, 135)
        Me.btn_crear_planilla.Name = "btn_crear_planilla"
        Me.btn_crear_planilla.Size = New System.Drawing.Size(64, 39)
        Me.btn_crear_planilla.TabIndex = 8
        Me.btn_crear_planilla.Text = "&Guardar"
        Me.btn_crear_planilla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_crear_planilla.UseVisualStyleBackColor = True
        '
        'dtp_fec_nueva_pla
        '
        Me.dtp_fec_nueva_pla.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtp_fec_nueva_pla.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_nueva_pla.Location = New System.Drawing.Point(113, 61)
        Me.dtp_fec_nueva_pla.Name = "dtp_fec_nueva_pla"
        Me.dtp_fec_nueva_pla.Size = New System.Drawing.Size(106, 23)
        Me.dtp_fec_nueva_pla.TabIndex = 4
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.Navy
        Me.Label89.Location = New System.Drawing.Point(54, 65)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(50, 16)
        Me.Label89.TabIndex = 3
        Me.Label89.Text = "Fecha:"
        '
        'GrpObservaciones
        '
        Me.GrpObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpObservaciones.BackColor = System.Drawing.Color.White
        Me.GrpObservaciones.Controls.Add(Me.txt_obs_general)
        Me.GrpObservaciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GrpObservaciones.ForeColor = System.Drawing.Color.Navy
        Me.GrpObservaciones.Location = New System.Drawing.Point(17, 471)
        Me.GrpObservaciones.Name = "GrpObservaciones"
        Me.GrpObservaciones.Size = New System.Drawing.Size(341, 144)
        Me.GrpObservaciones.TabIndex = 213
        Me.GrpObservaciones.TabStop = False
        Me.GrpObservaciones.Text = "Observaciones generales"
        '
        'txt_obs_general
        '
        Me.txt_obs_general.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_obs_general.BackColor = System.Drawing.Color.White
        Me.txt_obs_general.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs_general.Location = New System.Drawing.Point(10, 18)
        Me.txt_obs_general.MaxLength = 500
        Me.txt_obs_general.Multiline = True
        Me.txt_obs_general.Name = "txt_obs_general"
        Me.txt_obs_general.Size = New System.Drawing.Size(320, 115)
        Me.txt_obs_general.TabIndex = 203
        '
        'GrpRecepcionTercero
        '
        Me.GrpRecepcionTercero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpRecepcionTercero.BackColor = System.Drawing.Color.White
        Me.GrpRecepcionTercero.Controls.Add(Me.txt_recepcion_tercero)
        Me.GrpRecepcionTercero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GrpRecepcionTercero.ForeColor = System.Drawing.Color.Navy
        Me.GrpRecepcionTercero.Location = New System.Drawing.Point(17, 539)
        Me.GrpRecepcionTercero.Name = "GrpRecepcionTercero"
        Me.GrpRecepcionTercero.Size = New System.Drawing.Size(341, 65)
        Me.GrpRecepcionTercero.TabIndex = 214
        Me.GrpRecepcionTercero.TabStop = False
        Me.GrpRecepcionTercero.Text = "Recepción de Tercero"
        Me.GrpRecepcionTercero.Visible = False
        '
        'txt_recepcion_tercero
        '
        Me.txt_recepcion_tercero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_recepcion_tercero.BackColor = System.Drawing.Color.White
        Me.txt_recepcion_tercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_recepcion_tercero.Location = New System.Drawing.Point(10, 18)
        Me.txt_recepcion_tercero.MaxLength = 200
        Me.txt_recepcion_tercero.Multiline = True
        Me.txt_recepcion_tercero.Name = "txt_recepcion_tercero"
        Me.txt_recepcion_tercero.Size = New System.Drawing.Size(320, 36)
        Me.txt_recepcion_tercero.TabIndex = 203
        '
        'GrpLugarEntrega
        '
        Me.GrpLugarEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpLugarEntrega.BackColor = System.Drawing.Color.White
        Me.GrpLugarEntrega.Controls.Add(Me.txtLocal)
        Me.GrpLugarEntrega.Controls.Add(Me.txtDireccionTransportista)
        Me.GrpLugarEntrega.Controls.Add(Me.txtLocalDescripcion)
        Me.GrpLugarEntrega.Controls.Add(Me.Label142)
        Me.GrpLugarEntrega.Controls.Add(Me.txtDireccionTransportistaDescripcion)
        Me.GrpLugarEntrega.Controls.Add(Me.lblDireccionAgencia)
        Me.GrpLugarEntrega.Controls.Add(Me.GroupBox13)
        Me.GrpLugarEntrega.Controls.Add(Me.chk_efectivo)
        Me.GrpLugarEntrega.Controls.Add(Me.chk_transferencia)
        Me.GrpLugarEntrega.Controls.Add(Me.chk_letra_2)
        Me.GrpLugarEntrega.Controls.Add(Me.chk_factura_2)
        Me.GrpLugarEntrega.Controls.Add(Me.chk_guia_2)
        Me.GrpLugarEntrega.Controls.Add(Me.lblModoPago)
        Me.GrpLugarEntrega.Controls.Add(Me.txtModoPago)
        Me.GrpLugarEntrega.Controls.Add(Me.Label129)
        Me.GrpLugarEntrega.Controls.Add(Me.txt_n_operacion)
        Me.GrpLugarEntrega.Controls.Add(Me.Label128)
        Me.GrpLugarEntrega.Controls.Add(Me.Label125)
        Me.GrpLugarEntrega.Controls.Add(Me.txt_des_transferencia)
        Me.GrpLugarEntrega.Controls.Add(Me.txt_cod_transferencia)
        Me.GrpLugarEntrega.Controls.Add(Me.chk_cheque)
        Me.GrpLugarEntrega.Controls.Add(Me.rdb_domicilio)
        Me.GrpLugarEntrega.Controls.Add(Me.rdb_agencia)
        Me.GrpLugarEntrega.Controls.Add(Me.txt_guia)
        Me.GrpLugarEntrega.Controls.Add(Me.Label112)
        Me.GrpLugarEntrega.Controls.Add(Me.Label101)
        Me.GrpLugarEntrega.Controls.Add(Me.txt_des_agencia_trans)
        Me.GrpLugarEntrega.Controls.Add(Me.txt_cod_agencia_trans)
        Me.GrpLugarEntrega.Controls.Add(Me.txt_provincia)
        Me.GrpLugarEntrega.Controls.Add(Me.Label100)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox27)
        Me.GrpLugarEntrega.Controls.Add(Me.CheckBox1)
        Me.GrpLugarEntrega.Controls.Add(Me.RadioButton3)
        Me.GrpLugarEntrega.Controls.Add(Me.RadioButton4)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox28)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox26)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox29)
        Me.GrpLugarEntrega.Controls.Add(Me.Label102)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox28)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox29)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox30)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox30)
        Me.GrpLugarEntrega.Controls.Add(Me.Label103)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox31)
        Me.GrpLugarEntrega.Controls.Add(Me.Label104)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox32)
        Me.GrpLugarEntrega.Controls.Add(Me.Label105)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox31)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox32)
        Me.GrpLugarEntrega.Controls.Add(Me.RadioButton5)
        Me.GrpLugarEntrega.Controls.Add(Me.RadioButton6)
        Me.GrpLugarEntrega.Controls.Add(Me.GroupBox12)
        Me.GrpLugarEntrega.Controls.Add(Me.Label110)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox59)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox60)
        Me.GrpLugarEntrega.Controls.Add(Me.Label111)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox33)
        Me.GrpLugarEntrega.Controls.Add(Me.CheckBox2)
        Me.GrpLugarEntrega.Controls.Add(Me.ComboBox3)
        Me.GrpLugarEntrega.Controls.Add(Me.Label113)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox64)
        Me.GrpLugarEntrega.Controls.Add(Me.Label114)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox65)
        Me.GrpLugarEntrega.Controls.Add(Me.Label115)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox66)
        Me.GrpLugarEntrega.Controls.Add(Me.CheckBox3)
        Me.GrpLugarEntrega.Controls.Add(Me.Label116)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox67)
        Me.GrpLugarEntrega.Controls.Add(Me.Label117)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox68)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox34)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox69)
        Me.GrpLugarEntrega.Controls.Add(Me.Label118)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox70)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox35)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox71)
        Me.GrpLugarEntrega.Controls.Add(Me.Label119)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox72)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox36)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox73)
        Me.GrpLugarEntrega.Controls.Add(Me.Label120)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox74)
        Me.GrpLugarEntrega.Controls.Add(Me.Label121)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox75)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox76)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox78)
        Me.GrpLugarEntrega.Controls.Add(Me.Label122)
        Me.GrpLugarEntrega.Controls.Add(Me.Label123)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox37)
        Me.GrpLugarEntrega.Controls.Add(Me.PictureBox38)
        Me.GrpLugarEntrega.Controls.Add(Me.ComboBox4)
        Me.GrpLugarEntrega.Controls.Add(Me.Label126)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox82)
        Me.GrpLugarEntrega.Controls.Add(Me.Label127)
        Me.GrpLugarEntrega.Controls.Add(Me.Label130)
        Me.GrpLugarEntrega.Controls.Add(Me.TextBox88)
        Me.GrpLugarEntrega.Controls.Add(Me.txt_lt_ft)
        Me.GrpLugarEntrega.Controls.Add(Me.Label124)
        Me.GrpLugarEntrega.Location = New System.Drawing.Point(364, 343)
        Me.GrpLugarEntrega.Name = "GrpLugarEntrega"
        Me.GrpLugarEntrega.Size = New System.Drawing.Size(399, 311)
        Me.GrpLugarEntrega.TabIndex = 215
        Me.GrpLugarEntrega.TabStop = False
        '
        'txtLocal
        '
        Me.txtLocal.BackColor = System.Drawing.Color.Aquamarine
        Me.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtLocal.Location = New System.Drawing.Point(94, 99)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(57, 21)
        Me.txtLocal.TabIndex = 242
        Me.txtLocal.Visible = False
        '
        'txtDireccionTransportista
        '
        Me.txtDireccionTransportista.BackColor = System.Drawing.Color.Aquamarine
        Me.txtDireccionTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccionTransportista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDireccionTransportista.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtDireccionTransportista.Location = New System.Drawing.Point(94, 76)
        Me.txtDireccionTransportista.Name = "txtDireccionTransportista"
        Me.txtDireccionTransportista.ReadOnly = True
        Me.txtDireccionTransportista.Size = New System.Drawing.Size(57, 21)
        Me.txtDireccionTransportista.TabIndex = 241
        Me.txtDireccionTransportista.Visible = False
        '
        'txtLocalDescripcion
        '
        Me.txtLocalDescripcion.BackColor = System.Drawing.Color.Aquamarine
        Me.txtLocalDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalDescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtLocalDescripcion.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtLocalDescripcion.Location = New System.Drawing.Point(94, 99)
        Me.txtLocalDescripcion.Name = "txtLocalDescripcion"
        Me.txtLocalDescripcion.ReadOnly = True
        Me.txtLocalDescripcion.Size = New System.Drawing.Size(298, 21)
        Me.txtLocalDescripcion.TabIndex = 239
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label142.ForeColor = System.Drawing.Color.Navy
        Me.Label142.Location = New System.Drawing.Point(54, 103)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(36, 13)
        Me.Label142.TabIndex = 240
        Me.Label142.Text = "Local"
        '
        'txtDireccionTransportistaDescripcion
        '
        Me.txtDireccionTransportistaDescripcion.BackColor = System.Drawing.Color.Aquamarine
        Me.txtDireccionTransportistaDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccionTransportistaDescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDireccionTransportistaDescripcion.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtDireccionTransportistaDescripcion.Location = New System.Drawing.Point(94, 76)
        Me.txtDireccionTransportistaDescripcion.MaxLength = 250
        Me.txtDireccionTransportistaDescripcion.Name = "txtDireccionTransportistaDescripcion"
        Me.txtDireccionTransportistaDescripcion.ReadOnly = True
        Me.txtDireccionTransportistaDescripcion.Size = New System.Drawing.Size(298, 21)
        Me.txtDireccionTransportistaDescripcion.TabIndex = 237
        '
        'lblDireccionAgencia
        '
        Me.lblDireccionAgencia.AutoSize = True
        Me.lblDireccionAgencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDireccionAgencia.ForeColor = System.Drawing.Color.Navy
        Me.lblDireccionAgencia.Location = New System.Drawing.Point(5, 79)
        Me.lblDireccionAgencia.Name = "lblDireccionAgencia"
        Me.lblDireccionAgencia.Size = New System.Drawing.Size(85, 13)
        Me.lblDireccionAgencia.TabIndex = 238
        Me.lblDireccionAgencia.Text = "Agen. Destino"
        Me.lblDireccionAgencia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox13.Controls.Add(Me.rdb_opt_Lima)
        Me.GroupBox13.Controls.Add(Me.rdb_opt_agencia)
        Me.GroupBox13.Controls.Add(Me.rdb_opt_domicilio)
        Me.GroupBox13.Controls.Add(Me.rdb_opt_recojo)
        Me.GroupBox13.Location = New System.Drawing.Point(2, 10)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(388, 36)
        Me.GroupBox13.TabIndex = 236
        Me.GroupBox13.TabStop = False
        '
        'rdb_opt_Lima
        '
        Me.rdb_opt_Lima.AutoSize = True
        Me.rdb_opt_Lima.Checked = True
        Me.rdb_opt_Lima.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdb_opt_Lima.ForeColor = System.Drawing.Color.Navy
        Me.rdb_opt_Lima.Location = New System.Drawing.Point(13, 10)
        Me.rdb_opt_Lima.Name = "rdb_opt_Lima"
        Me.rdb_opt_Lima.Size = New System.Drawing.Size(52, 17)
        Me.rdb_opt_Lima.TabIndex = 230
        Me.rdb_opt_Lima.TabStop = True
        Me.rdb_opt_Lima.Text = "Lima"
        Me.rdb_opt_Lima.UseVisualStyleBackColor = True
        '
        'rdb_opt_agencia
        '
        Me.rdb_opt_agencia.AutoSize = True
        Me.rdb_opt_agencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdb_opt_agencia.ForeColor = System.Drawing.Color.Navy
        Me.rdb_opt_agencia.Location = New System.Drawing.Point(93, 10)
        Me.rdb_opt_agencia.Name = "rdb_opt_agencia"
        Me.rdb_opt_agencia.Size = New System.Drawing.Size(70, 17)
        Me.rdb_opt_agencia.TabIndex = 225
        Me.rdb_opt_agencia.Text = "Agencia"
        Me.rdb_opt_agencia.UseVisualStyleBackColor = True
        '
        'rdb_opt_domicilio
        '
        Me.rdb_opt_domicilio.AutoSize = True
        Me.rdb_opt_domicilio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdb_opt_domicilio.ForeColor = System.Drawing.Color.Navy
        Me.rdb_opt_domicilio.Location = New System.Drawing.Point(179, 10)
        Me.rdb_opt_domicilio.Name = "rdb_opt_domicilio"
        Me.rdb_opt_domicilio.Size = New System.Drawing.Size(126, 17)
        Me.rdb_opt_domicilio.TabIndex = 226
        Me.rdb_opt_domicilio.Text = "Agencia-Domicilio"
        Me.rdb_opt_domicilio.UseVisualStyleBackColor = True
        '
        'rdb_opt_recojo
        '
        Me.rdb_opt_recojo.AutoSize = True
        Me.rdb_opt_recojo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdb_opt_recojo.ForeColor = System.Drawing.Color.Navy
        Me.rdb_opt_recojo.Location = New System.Drawing.Point(319, 10)
        Me.rdb_opt_recojo.Name = "rdb_opt_recojo"
        Me.rdb_opt_recojo.Size = New System.Drawing.Size(64, 17)
        Me.rdb_opt_recojo.TabIndex = 229
        Me.rdb_opt_recojo.Text = "Recojo"
        Me.rdb_opt_recojo.UseVisualStyleBackColor = True
        '
        'chk_efectivo
        '
        Me.chk_efectivo.AutoSize = True
        Me.chk_efectivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_efectivo.ForeColor = System.Drawing.Color.Navy
        Me.chk_efectivo.Location = New System.Drawing.Point(206, 130)
        Me.chk_efectivo.Name = "chk_efectivo"
        Me.chk_efectivo.Size = New System.Drawing.Size(71, 17)
        Me.chk_efectivo.TabIndex = 228
        Me.chk_efectivo.Text = "Efectivo"
        Me.chk_efectivo.UseVisualStyleBackColor = True
        '
        'chk_transferencia
        '
        Me.chk_transferencia.AutoSize = True
        Me.chk_transferencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_transferencia.ForeColor = System.Drawing.Color.Navy
        Me.chk_transferencia.Location = New System.Drawing.Point(95, 130)
        Me.chk_transferencia.Name = "chk_transferencia"
        Me.chk_transferencia.Size = New System.Drawing.Size(104, 17)
        Me.chk_transferencia.TabIndex = 227
        Me.chk_transferencia.Text = "Transferencia"
        Me.chk_transferencia.UseVisualStyleBackColor = True
        '
        'chk_letra_2
        '
        Me.chk_letra_2.AutoSize = True
        Me.chk_letra_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_letra_2.ForeColor = System.Drawing.Color.Navy
        Me.chk_letra_2.Location = New System.Drawing.Point(250, 277)
        Me.chk_letra_2.Name = "chk_letra_2"
        Me.chk_letra_2.Size = New System.Drawing.Size(56, 17)
        Me.chk_letra_2.TabIndex = 224
        Me.chk_letra_2.Text = "Letra"
        Me.chk_letra_2.UseVisualStyleBackColor = True
        Me.chk_letra_2.Visible = False
        '
        'chk_factura_2
        '
        Me.chk_factura_2.AutoSize = True
        Me.chk_factura_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_factura_2.ForeColor = System.Drawing.Color.Navy
        Me.chk_factura_2.Location = New System.Drawing.Point(163, 277)
        Me.chk_factura_2.Name = "chk_factura_2"
        Me.chk_factura_2.Size = New System.Drawing.Size(69, 17)
        Me.chk_factura_2.TabIndex = 223
        Me.chk_factura_2.Text = "Factura"
        Me.chk_factura_2.UseVisualStyleBackColor = True
        Me.chk_factura_2.Visible = False
        '
        'chk_guia_2
        '
        Me.chk_guia_2.AutoSize = True
        Me.chk_guia_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_guia_2.ForeColor = System.Drawing.Color.Navy
        Me.chk_guia_2.Location = New System.Drawing.Point(94, 277)
        Me.chk_guia_2.Name = "chk_guia_2"
        Me.chk_guia_2.Size = New System.Drawing.Size(51, 17)
        Me.chk_guia_2.TabIndex = 222
        Me.chk_guia_2.Text = "Guía"
        Me.chk_guia_2.UseVisualStyleBackColor = True
        Me.chk_guia_2.Visible = False
        '
        'lblModoPago
        '
        Me.lblModoPago.BackColor = System.Drawing.Color.White
        Me.lblModoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblModoPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblModoPago.ForeColor = System.Drawing.Color.Green
        Me.lblModoPago.Location = New System.Drawing.Point(157, 211)
        Me.lblModoPago.Name = "lblModoPago"
        Me.lblModoPago.ReadOnly = True
        Me.lblModoPago.Size = New System.Drawing.Size(235, 21)
        Me.lblModoPago.TabIndex = 220
        '
        'txtModoPago
        '
        Me.txtModoPago.BackColor = System.Drawing.Color.Aquamarine
        Me.txtModoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModoPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtModoPago.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtModoPago.Location = New System.Drawing.Point(94, 211)
        Me.txtModoPago.MaxLength = 4
        Me.txtModoPago.Name = "txtModoPago"
        Me.txtModoPago.ReadOnly = True
        Me.txtModoPago.Size = New System.Drawing.Size(57, 21)
        Me.txtModoPago.TabIndex = 219
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label129.ForeColor = System.Drawing.Color.Navy
        Me.Label129.Location = New System.Drawing.Point(5, 215)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(86, 13)
        Me.Label129.TabIndex = 221
        Me.Label129.Text = "Modo de pago"
        '
        'txt_n_operacion
        '
        Me.txt_n_operacion.BackColor = System.Drawing.Color.White
        Me.txt_n_operacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_n_operacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_n_operacion.ForeColor = System.Drawing.Color.Green
        Me.txt_n_operacion.Location = New System.Drawing.Point(94, 184)
        Me.txt_n_operacion.MaxLength = 250
        Me.txt_n_operacion.Name = "txt_n_operacion"
        Me.txt_n_operacion.Size = New System.Drawing.Size(138, 21)
        Me.txt_n_operacion.TabIndex = 214
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label128.ForeColor = System.Drawing.Color.Navy
        Me.Label128.Location = New System.Drawing.Point(11, 188)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(80, 13)
        Me.Label128.TabIndex = 215
        Me.Label128.Text = "N° Operación"
        Me.Label128.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label125.ForeColor = System.Drawing.Color.Navy
        Me.Label125.Location = New System.Drawing.Point(50, 163)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(41, 13)
        Me.Label125.TabIndex = 213
        Me.Label125.Text = "Banco"
        '
        'txt_des_transferencia
        '
        Me.txt_des_transferencia.BackColor = System.Drawing.Color.White
        Me.txt_des_transferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_transferencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_des_transferencia.ForeColor = System.Drawing.Color.Green
        Me.txt_des_transferencia.Location = New System.Drawing.Point(157, 159)
        Me.txt_des_transferencia.Name = "txt_des_transferencia"
        Me.txt_des_transferencia.ReadOnly = True
        Me.txt_des_transferencia.Size = New System.Drawing.Size(235, 21)
        Me.txt_des_transferencia.TabIndex = 212
        '
        'txt_cod_transferencia
        '
        Me.txt_cod_transferencia.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_transferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_transferencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_transferencia.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_transferencia.Location = New System.Drawing.Point(94, 159)
        Me.txt_cod_transferencia.Name = "txt_cod_transferencia"
        Me.txt_cod_transferencia.ReadOnly = True
        Me.txt_cod_transferencia.Size = New System.Drawing.Size(57, 21)
        Me.txt_cod_transferencia.TabIndex = 211
        '
        'chk_cheque
        '
        Me.chk_cheque.AutoSize = True
        Me.chk_cheque.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_cheque.ForeColor = System.Drawing.Color.Navy
        Me.chk_cheque.Location = New System.Drawing.Point(324, 277)
        Me.chk_cheque.Name = "chk_cheque"
        Me.chk_cheque.Size = New System.Drawing.Size(68, 17)
        Me.chk_cheque.TabIndex = 208
        Me.chk_cheque.Text = "Cheque"
        Me.chk_cheque.UseVisualStyleBackColor = True
        Me.chk_cheque.Visible = False
        '
        'rdb_domicilio
        '
        Me.rdb_domicilio.AutoSize = True
        Me.rdb_domicilio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdb_domicilio.ForeColor = System.Drawing.Color.Navy
        Me.rdb_domicilio.Location = New System.Drawing.Point(175, 274)
        Me.rdb_domicilio.Name = "rdb_domicilio"
        Me.rdb_domicilio.Size = New System.Drawing.Size(93, 17)
        Me.rdb_domicilio.TabIndex = 207
        Me.rdb_domicilio.TabStop = True
        Me.rdb_domicilio.Text = "Guía - LT/FT"
        Me.rdb_domicilio.UseVisualStyleBackColor = True
        Me.rdb_domicilio.Visible = False
        '
        'rdb_agencia
        '
        Me.rdb_agencia.AutoSize = True
        Me.rdb_agencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdb_agencia.ForeColor = System.Drawing.Color.Navy
        Me.rdb_agencia.Location = New System.Drawing.Point(94, 178)
        Me.rdb_agencia.Name = "rdb_agencia"
        Me.rdb_agencia.Size = New System.Drawing.Size(70, 17)
        Me.rdb_agencia.TabIndex = 206
        Me.rdb_agencia.TabStop = True
        Me.rdb_agencia.Text = "Agencia"
        Me.rdb_agencia.UseVisualStyleBackColor = True
        Me.rdb_agencia.Visible = False
        '
        'txt_guia
        '
        Me.txt_guia.BackColor = System.Drawing.Color.White
        Me.txt_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_guia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_guia.ForeColor = System.Drawing.Color.Green
        Me.txt_guia.Location = New System.Drawing.Point(94, 104)
        Me.txt_guia.MaxLength = 250
        Me.txt_guia.Name = "txt_guia"
        Me.txt_guia.Size = New System.Drawing.Size(298, 21)
        Me.txt_guia.TabIndex = 204
        Me.txt_guia.Visible = False
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label112.ForeColor = System.Drawing.Color.Navy
        Me.Label112.Location = New System.Drawing.Point(33, 108)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(58, 13)
        Me.Label112.TabIndex = 205
        Me.Label112.Text = "Domicilio"
        Me.Label112.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label112.Visible = False
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label101.ForeColor = System.Drawing.Color.Navy
        Me.Label101.Location = New System.Drawing.Point(14, 56)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(76, 13)
        Me.Label101.TabIndex = 203
        Me.Label101.Text = "Emp.Transp."
        '
        'txt_des_agencia_trans
        '
        Me.txt_des_agencia_trans.BackColor = System.Drawing.Color.White
        Me.txt_des_agencia_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_agencia_trans.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_des_agencia_trans.ForeColor = System.Drawing.Color.Green
        Me.txt_des_agencia_trans.Location = New System.Drawing.Point(157, 52)
        Me.txt_des_agencia_trans.Name = "txt_des_agencia_trans"
        Me.txt_des_agencia_trans.ReadOnly = True
        Me.txt_des_agencia_trans.Size = New System.Drawing.Size(235, 21)
        Me.txt_des_agencia_trans.TabIndex = 202
        '
        'txt_cod_agencia_trans
        '
        Me.txt_cod_agencia_trans.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_agencia_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_agencia_trans.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_agencia_trans.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_agencia_trans.Location = New System.Drawing.Point(94, 52)
        Me.txt_cod_agencia_trans.Name = "txt_cod_agencia_trans"
        Me.txt_cod_agencia_trans.ReadOnly = True
        Me.txt_cod_agencia_trans.Size = New System.Drawing.Size(57, 21)
        Me.txt_cod_agencia_trans.TabIndex = 201
        '
        'txt_provincia
        '
        Me.txt_provincia.BackColor = System.Drawing.Color.White
        Me.txt_provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_provincia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_provincia.ForeColor = System.Drawing.Color.Green
        Me.txt_provincia.Location = New System.Drawing.Point(94, 242)
        Me.txt_provincia.MaxLength = 250
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(298, 21)
        Me.txt_provincia.TabIndex = 199
        Me.txt_provincia.Visible = False
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label100.ForeColor = System.Drawing.Color.Navy
        Me.Label100.Location = New System.Drawing.Point(32, 246)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(59, 13)
        Me.Label100.TabIndex = 200
        Me.Label100.Text = "Provincia"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label100.Visible = False
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(120, 196)
        Me.TextBox27.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(81, 20)
        Me.TextBox27.TabIndex = 195
        Me.TextBox27.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox1.Location = New System.Drawing.Point(334, 320)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(142, 17)
        Me.CheckBox1.TabIndex = 194
        Me.CheckBox1.Text = "Facturar como Obsequio"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton3.Location = New System.Drawing.Point(214, 320)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton3.TabIndex = 193
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Formato A4"
        Me.RadioButton3.UseVisualStyleBackColor = True
        Me.RadioButton3.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton4.Location = New System.Drawing.Point(94, 320)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(96, 17)
        Me.RadioButton4.TabIndex = 192
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Formato Ticket"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.Color.White
        Me.TextBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox28.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.ForeColor = System.Drawing.Color.Green
        Me.TextBox28.Location = New System.Drawing.Point(238, 319)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.ReadOnly = True
        Me.TextBox28.Size = New System.Drawing.Size(257, 27)
        Me.TextBox28.TabIndex = 189
        Me.TextBox28.Visible = False
        '
        'PictureBox26
        '
        Me.PictureBox26.Image = CType(resources.GetObject("PictureBox26.Image"), System.Drawing.Image)
        Me.PictureBox26.Location = New System.Drawing.Point(203, 319)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox26.TabIndex = 191
        Me.PictureBox26.TabStop = False
        Me.PictureBox26.Visible = False
        '
        'TextBox29
        '
        Me.TextBox29.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox29.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.ForeColor = System.Drawing.Color.SaddleBrown
        Me.TextBox29.Location = New System.Drawing.Point(94, 319)
        Me.TextBox29.MaxLength = 2
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.ReadOnly = True
        Me.TextBox29.Size = New System.Drawing.Size(101, 27)
        Me.TextBox29.TabIndex = 188
        Me.TextBox29.Visible = False
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.ForeColor = System.Drawing.Color.Navy
        Me.Label102.Location = New System.Drawing.Point(14, 323)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(77, 19)
        Me.Label102.TabIndex = 190
        Me.Label102.Text = "Tip. N.E."
        Me.Label102.Visible = False
        '
        'PictureBox28
        '
        Me.PictureBox28.Image = CType(resources.GetObject("PictureBox28.Image"), System.Drawing.Image)
        Me.PictureBox28.Location = New System.Drawing.Point(2949, 290)
        Me.PictureBox28.Name = "PictureBox28"
        Me.PictureBox28.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox28.TabIndex = 185
        Me.PictureBox28.TabStop = False
        '
        'PictureBox29
        '
        Me.PictureBox29.Image = CType(resources.GetObject("PictureBox29.Image"), System.Drawing.Image)
        Me.PictureBox29.Location = New System.Drawing.Point(2780, 290)
        Me.PictureBox29.Name = "PictureBox29"
        Me.PictureBox29.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox29.TabIndex = 184
        Me.PictureBox29.TabStop = False
        '
        'PictureBox30
        '
        Me.PictureBox30.Image = CType(resources.GetObject("PictureBox30.Image"), System.Drawing.Image)
        Me.PictureBox30.Location = New System.Drawing.Point(2570, 290)
        Me.PictureBox30.Name = "PictureBox30"
        Me.PictureBox30.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox30.TabIndex = 183
        Me.PictureBox30.TabStop = False
        '
        'TextBox30
        '
        Me.TextBox30.BackColor = System.Drawing.Color.White
        Me.TextBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox30.Location = New System.Drawing.Point(2846, 289)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.ReadOnly = True
        Me.TextBox30.Size = New System.Drawing.Size(122, 20)
        Me.TextBox30.TabIndex = 181
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label103.ForeColor = System.Drawing.Color.Navy
        Me.Label103.Location = New System.Drawing.Point(2804, 292)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(37, 13)
        Me.Label103.TabIndex = 182
        Me.Label103.Text = "Trama"
        '
        'TextBox31
        '
        Me.TextBox31.BackColor = System.Drawing.Color.White
        Me.TextBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox31.Location = New System.Drawing.Point(2698, 289)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.ReadOnly = True
        Me.TextBox31.Size = New System.Drawing.Size(100, 20)
        Me.TextBox31.TabIndex = 179
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label104.ForeColor = System.Drawing.Color.Navy
        Me.Label104.Location = New System.Drawing.Point(2593, 292)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(102, 13)
        Me.Label104.TabIndex = 180
        Me.Label104.Text = "Empresa Transporte"
        '
        'TextBox32
        '
        Me.TextBox32.BackColor = System.Drawing.Color.White
        Me.TextBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox32.Location = New System.Drawing.Point(2486, 289)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.ReadOnly = True
        Me.TextBox32.Size = New System.Drawing.Size(103, 20)
        Me.TextBox32.TabIndex = 177
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label105.ForeColor = System.Drawing.Color.Navy
        Me.Label105.Location = New System.Drawing.Point(2433, 292)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(48, 13)
        Me.Label105.TabIndex = 178
        Me.Label105.Text = "Vehiculo"
        '
        'PictureBox31
        '
        Me.PictureBox31.Image = CType(resources.GetObject("PictureBox31.Image"), System.Drawing.Image)
        Me.PictureBox31.Location = New System.Drawing.Point(2789, 236)
        Me.PictureBox31.Name = "PictureBox31"
        Me.PictureBox31.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox31.TabIndex = 118
        Me.PictureBox31.TabStop = False
        Me.PictureBox31.Visible = False
        '
        'PictureBox32
        '
        Me.PictureBox32.Image = CType(resources.GetObject("PictureBox32.Image"), System.Drawing.Image)
        Me.PictureBox32.Location = New System.Drawing.Point(1454, 39)
        Me.PictureBox32.Name = "PictureBox32"
        Me.PictureBox32.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox32.TabIndex = 176
        Me.PictureBox32.TabStop = False
        Me.PictureBox32.Visible = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton5.Location = New System.Drawing.Point(1770, 39)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton5.TabIndex = 174
        Me.RadioButton5.Text = "& Varios doc Ref."
        Me.RadioButton5.UseVisualStyleBackColor = True
        Me.RadioButton5.Visible = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton6.Location = New System.Drawing.Point(1262, 40)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton6.TabIndex = 173
        Me.RadioButton6.Text = "Un doc. Ref."
        Me.RadioButton6.UseVisualStyleBackColor = True
        Me.RadioButton6.Visible = False
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.Label106)
        Me.GroupBox12.Controls.Add(Me.TextBox36)
        Me.GroupBox12.Controls.Add(Me.TextBox48)
        Me.GroupBox12.Controls.Add(Me.TextBox50)
        Me.GroupBox12.Controls.Add(Me.TextBox53)
        Me.GroupBox12.Controls.Add(Me.TextBox54)
        Me.GroupBox12.Controls.Add(Me.TextBox55)
        Me.GroupBox12.Controls.Add(Me.Label107)
        Me.GroupBox12.Controls.Add(Me.Label108)
        Me.GroupBox12.Controls.Add(Me.TextBox56)
        Me.GroupBox12.Controls.Add(Me.TextBox57)
        Me.GroupBox12.Controls.Add(Me.Label109)
        Me.GroupBox12.Controls.Add(Me.TextBox58)
        Me.GroupBox12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox12.Location = New System.Drawing.Point(148, 311)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(400, 57)
        Me.GroupBox12.TabIndex = 170
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Visible = False
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.ForeColor = System.Drawing.Color.Navy
        Me.Label106.Location = New System.Drawing.Point(25, 123)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(72, 11)
        Me.Label106.TabIndex = 175
        Me.Label106.Text = "Comprobante"
        Me.Label106.Visible = False
        '
        'TextBox36
        '
        Me.TextBox36.BackColor = System.Drawing.Color.White
        Me.TextBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox36.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox36.Location = New System.Drawing.Point(138, 100)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.ReadOnly = True
        Me.TextBox36.Size = New System.Drawing.Size(31, 18)
        Me.TextBox36.TabIndex = 173
        Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox36.Visible = False
        '
        'TextBox48
        '
        Me.TextBox48.BackColor = System.Drawing.Color.White
        Me.TextBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox48.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox48.ForeColor = System.Drawing.Color.Green
        Me.TextBox48.Location = New System.Drawing.Point(182, 19)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.ReadOnly = True
        Me.TextBox48.Size = New System.Drawing.Size(64, 27)
        Me.TextBox48.TabIndex = 168
        Me.TextBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox50
        '
        Me.TextBox50.BackColor = System.Drawing.Color.White
        Me.TextBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox50.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox50.Location = New System.Drawing.Point(171, 124)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.ReadOnly = True
        Me.TextBox50.Size = New System.Drawing.Size(138, 18)
        Me.TextBox50.TabIndex = 165
        Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox50.Visible = False
        '
        'TextBox53
        '
        Me.TextBox53.BackColor = System.Drawing.Color.White
        Me.TextBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox53.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox53.Location = New System.Drawing.Point(171, 100)
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.ReadOnly = True
        Me.TextBox53.Size = New System.Drawing.Size(138, 18)
        Me.TextBox53.TabIndex = 174
        Me.TextBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox53.Visible = False
        '
        'TextBox54
        '
        Me.TextBox54.BackColor = System.Drawing.Color.White
        Me.TextBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox54.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox54.Location = New System.Drawing.Point(138, 124)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.ReadOnly = True
        Me.TextBox54.Size = New System.Drawing.Size(31, 18)
        Me.TextBox54.TabIndex = 164
        Me.TextBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox54.Visible = False
        '
        'TextBox55
        '
        Me.TextBox55.BackColor = System.Drawing.Color.White
        Me.TextBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox55.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox55.Location = New System.Drawing.Point(107, 124)
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.ReadOnly = True
        Me.TextBox55.Size = New System.Drawing.Size(30, 18)
        Me.TextBox55.TabIndex = 163
        Me.TextBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox55.Visible = False
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.ForeColor = System.Drawing.Color.Navy
        Me.Label107.Location = New System.Drawing.Point(13, 103)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(90, 11)
        Me.Label107.TabIndex = 171
        Me.Label107.Text = "Guia de Remision"
        Me.Label107.Visible = False
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.ForeColor = System.Drawing.Color.Navy
        Me.Label108.Location = New System.Drawing.Point(40, 134)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(60, 11)
        Me.Label108.TabIndex = 162
        Me.Label108.Text = "Percepcion"
        Me.Label108.Visible = False
        '
        'TextBox56
        '
        Me.TextBox56.BackColor = System.Drawing.Color.White
        Me.TextBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox56.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox56.ForeColor = System.Drawing.Color.Green
        Me.TextBox56.Location = New System.Drawing.Point(252, 19)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.ReadOnly = True
        Me.TextBox56.Size = New System.Drawing.Size(134, 27)
        Me.TextBox56.TabIndex = 169
        Me.TextBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox57
        '
        Me.TextBox57.BackColor = System.Drawing.Color.White
        Me.TextBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox57.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox57.Location = New System.Drawing.Point(107, 100)
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.ReadOnly = True
        Me.TextBox57.Size = New System.Drawing.Size(30, 18)
        Me.TextBox57.TabIndex = 172
        Me.TextBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox57.Visible = False
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label109.ForeColor = System.Drawing.Color.Navy
        Me.Label109.Location = New System.Drawing.Point(9, 23)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(101, 19)
        Me.Label109.TabIndex = 166
        Me.Label109.Text = "Documento"
        '
        'TextBox58
        '
        Me.TextBox58.BackColor = System.Drawing.Color.White
        Me.TextBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox58.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox58.ForeColor = System.Drawing.Color.Green
        Me.TextBox58.Location = New System.Drawing.Point(125, 19)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.ReadOnly = True
        Me.TextBox58.Size = New System.Drawing.Size(51, 27)
        Me.TextBox58.TabIndex = 167
        Me.TextBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label110.ForeColor = System.Drawing.Color.Navy
        Me.Label110.Location = New System.Drawing.Point(1480, 41)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(74, 13)
        Me.Label110.TabIndex = 161
        Me.Label110.Text = "Serie.Doc.Ref"
        Me.Label110.Visible = False
        '
        'TextBox59
        '
        Me.TextBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox59.Location = New System.Drawing.Point(1558, 37)
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(32, 20)
        Me.TextBox59.TabIndex = 7
        Me.TextBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox59.Visible = False
        '
        'TextBox60
        '
        Me.TextBox60.BackColor = System.Drawing.Color.White
        Me.TextBox60.Location = New System.Drawing.Point(1427, 38)
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.ReadOnly = True
        Me.TextBox60.Size = New System.Drawing.Size(24, 20)
        Me.TextBox60.TabIndex = 6
        Me.TextBox60.Visible = False
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label111.ForeColor = System.Drawing.Color.Navy
        Me.Label111.Location = New System.Drawing.Point(1355, 42)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(71, 13)
        Me.Label111.TabIndex = 157
        Me.Label111.Text = "Tipo.Doc.Ref"
        Me.Label111.Visible = False
        '
        'PictureBox33
        '
        Me.PictureBox33.Image = CType(resources.GetObject("PictureBox33.Image"), System.Drawing.Image)
        Me.PictureBox33.Location = New System.Drawing.Point(256, 315)
        Me.PictureBox33.Name = "PictureBox33"
        Me.PictureBox33.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox33.TabIndex = 155
        Me.PictureBox33.TabStop = False
        Me.PictureBox33.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox2.Location = New System.Drawing.Point(580, 255)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox2.TabIndex = 154
        Me.CheckBox2.Text = "Sin Guia de Remision"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(2522, 260)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(597, 21)
        Me.ComboBox3.TabIndex = 17
        Me.ComboBox3.Visible = False
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label113.ForeColor = System.Drawing.Color.Navy
        Me.Label113.Location = New System.Drawing.Point(2426, 262)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(91, 13)
        Me.Label113.TabIndex = 13
        Me.Label113.Text = "Dirección entrega"
        '
        'TextBox64
        '
        Me.TextBox64.BackColor = System.Drawing.Color.White
        Me.TextBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox64.Location = New System.Drawing.Point(2684, 211)
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.ReadOnly = True
        Me.TextBox64.Size = New System.Drawing.Size(110, 20)
        Me.TextBox64.TabIndex = 13
        Me.TextBox64.Visible = False
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label114.ForeColor = System.Drawing.Color.Navy
        Me.Label114.Location = New System.Drawing.Point(2591, 214)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(90, 13)
        Me.Label114.TabIndex = 149
        Me.Label114.Text = "Orden de Compra"
        Me.Label114.Visible = False
        '
        'TextBox65
        '
        Me.TextBox65.BackColor = System.Drawing.Color.White
        Me.TextBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox65.Location = New System.Drawing.Point(2486, 210)
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.ReadOnly = True
        Me.TextBox65.Size = New System.Drawing.Size(100, 20)
        Me.TextBox65.TabIndex = 12
        Me.TextBox65.Visible = False
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label115.ForeColor = System.Drawing.Color.Navy
        Me.Label115.Location = New System.Drawing.Point(2425, 213)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(56, 13)
        Me.Label115.TabIndex = 147
        Me.Label115.Text = "Cotizacion"
        Me.Label115.Visible = False
        '
        'TextBox66
        '
        Me.TextBox66.BackColor = System.Drawing.Color.White
        Me.TextBox66.Location = New System.Drawing.Point(1658, 37)
        Me.TextBox66.Multiline = True
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox66.Size = New System.Drawing.Size(107, 20)
        Me.TextBox66.TabIndex = 8
        Me.TextBox66.Visible = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox3.Location = New System.Drawing.Point(76, 397)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(143, 23)
        Me.CheckBox3.TabIndex = 84
        Me.CheckBox3.Text = "&Precio sin Igv."
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label116.ForeColor = System.Drawing.Color.Navy
        Me.Label116.Location = New System.Drawing.Point(1593, 40)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(67, 13)
        Me.Label116.TabIndex = 145
        Me.Label116.Text = "Nro.Doc.Ref"
        Me.Label116.Visible = False
        '
        'TextBox67
        '
        Me.TextBox67.BackColor = System.Drawing.Color.White
        Me.TextBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox67.Location = New System.Drawing.Point(2880, 211)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(101, 20)
        Me.TextBox67.TabIndex = 14
        Me.TextBox67.Visible = False
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label117.ForeColor = System.Drawing.Color.Navy
        Me.Label117.Location = New System.Drawing.Point(2798, 215)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(80, 13)
        Me.Label117.TabIndex = 143
        Me.Label117.Text = "Numero Pedido"
        Me.Label117.Visible = False
        '
        'TextBox68
        '
        Me.TextBox68.BackColor = System.Drawing.Color.White
        Me.TextBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox68.Location = New System.Drawing.Point(1372, 178)
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.ReadOnly = True
        Me.TextBox68.Size = New System.Drawing.Size(47, 20)
        Me.TextBox68.TabIndex = 142
        Me.TextBox68.Visible = False
        '
        'PictureBox34
        '
        Me.PictureBox34.Image = CType(resources.GetObject("PictureBox34.Image"), System.Drawing.Image)
        Me.PictureBox34.Location = New System.Drawing.Point(1354, 179)
        Me.PictureBox34.Name = "PictureBox34"
        Me.PictureBox34.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox34.TabIndex = 141
        Me.PictureBox34.TabStop = False
        Me.PictureBox34.Visible = False
        '
        'TextBox69
        '
        Me.TextBox69.Location = New System.Drawing.Point(1314, 178)
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New System.Drawing.Size(37, 20)
        Me.TextBox69.TabIndex = 139
        Me.TextBox69.Visible = False
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Location = New System.Drawing.Point(1272, 181)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(37, 13)
        Me.Label118.TabIndex = 140
        Me.Label118.Text = "Trama"
        Me.Label118.Visible = False
        '
        'TextBox70
        '
        Me.TextBox70.BackColor = System.Drawing.Color.White
        Me.TextBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox70.Location = New System.Drawing.Point(1265, 259)
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.ReadOnly = True
        Me.TextBox70.Size = New System.Drawing.Size(47, 20)
        Me.TextBox70.TabIndex = 138
        Me.TextBox70.Visible = False
        '
        'PictureBox35
        '
        Me.PictureBox35.Image = CType(resources.GetObject("PictureBox35.Image"), System.Drawing.Image)
        Me.PictureBox35.Location = New System.Drawing.Point(1247, 260)
        Me.PictureBox35.Name = "PictureBox35"
        Me.PictureBox35.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox35.TabIndex = 137
        Me.PictureBox35.TabStop = False
        Me.PictureBox35.Visible = False
        '
        'TextBox71
        '
        Me.TextBox71.Location = New System.Drawing.Point(1376, 256)
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New System.Drawing.Size(44, 20)
        Me.TextBox71.TabIndex = 135
        Me.TextBox71.Visible = False
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Location = New System.Drawing.Point(1377, 237)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(102, 13)
        Me.Label119.TabIndex = 136
        Me.Label119.Text = "Empresa Transporte"
        Me.Label119.Visible = False
        '
        'TextBox72
        '
        Me.TextBox72.BackColor = System.Drawing.Color.White
        Me.TextBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox72.Location = New System.Drawing.Point(1372, 153)
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.ReadOnly = True
        Me.TextBox72.Size = New System.Drawing.Size(45, 20)
        Me.TextBox72.TabIndex = 134
        Me.TextBox72.Visible = False
        '
        'PictureBox36
        '
        Me.PictureBox36.Image = CType(resources.GetObject("PictureBox36.Image"), System.Drawing.Image)
        Me.PictureBox36.Location = New System.Drawing.Point(1354, 154)
        Me.PictureBox36.Name = "PictureBox36"
        Me.PictureBox36.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox36.TabIndex = 133
        Me.PictureBox36.TabStop = False
        Me.PictureBox36.Visible = False
        '
        'TextBox73
        '
        Me.TextBox73.Location = New System.Drawing.Point(1314, 153)
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New System.Drawing.Size(37, 20)
        Me.TextBox73.TabIndex = 131
        Me.TextBox73.Visible = False
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Location = New System.Drawing.Point(1259, 156)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(51, 13)
        Me.Label120.TabIndex = 132
        Me.Label120.Text = "Vehiculo "
        Me.Label120.Visible = False
        '
        'TextBox74
        '
        Me.TextBox74.BackColor = System.Drawing.Color.White
        Me.TextBox74.Location = New System.Drawing.Point(1291, 256)
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.ReadOnly = True
        Me.TextBox74.Size = New System.Drawing.Size(58, 20)
        Me.TextBox74.TabIndex = 130
        Me.TextBox74.Visible = False
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label121.Location = New System.Drawing.Point(1270, 241)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(107, 13)
        Me.Label121.TabIndex = 129
        Me.Label121.Text = "%DescuentoEspecial"
        Me.Label121.Visible = False
        '
        'TextBox75
        '
        Me.TextBox75.BackColor = System.Drawing.Color.White
        Me.TextBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox75.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox75.ForeColor = System.Drawing.Color.Green
        Me.TextBox75.Location = New System.Drawing.Point(291, 316)
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.ReadOnly = True
        Me.TextBox75.Size = New System.Drawing.Size(257, 27)
        Me.TextBox75.TabIndex = 29
        Me.TextBox75.Visible = False
        '
        'TextBox76
        '
        Me.TextBox76.BackColor = System.Drawing.Color.White
        Me.TextBox76.Location = New System.Drawing.Point(1249, 201)
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.ReadOnly = True
        Me.TextBox76.Size = New System.Drawing.Size(48, 20)
        Me.TextBox76.TabIndex = 128
        Me.TextBox76.Visible = False
        '
        'TextBox78
        '
        Me.TextBox78.BackColor = System.Drawing.Color.White
        Me.TextBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox78.Enabled = False
        Me.TextBox78.Location = New System.Drawing.Point(2810, 234)
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New System.Drawing.Size(310, 20)
        Me.TextBox78.TabIndex = 31
        Me.TextBox78.Text = "."
        Me.TextBox78.Visible = False
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label122.Location = New System.Drawing.Point(1230, 211)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(99, 13)
        Me.Label122.TabIndex = 127
        Me.Label122.Text = "%DescuentoCliente"
        Me.Label122.Visible = False
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label123.ForeColor = System.Drawing.Color.Navy
        Me.Label123.Location = New System.Drawing.Point(2237, 238)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(68, 13)
        Me.Label123.TabIndex = 2
        Me.Label123.Text = "Transportista"
        Me.Label123.Visible = False
        '
        'PictureBox37
        '
        Me.PictureBox37.Image = CType(resources.GetObject("PictureBox37.Image"), System.Drawing.Image)
        Me.PictureBox37.Location = New System.Drawing.Point(256, 347)
        Me.PictureBox37.Name = "PictureBox37"
        Me.PictureBox37.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox37.TabIndex = 115
        Me.PictureBox37.TabStop = False
        Me.PictureBox37.Visible = False
        '
        'PictureBox38
        '
        Me.PictureBox38.Image = CType(resources.GetObject("PictureBox38.Image"), System.Drawing.Image)
        Me.PictureBox38.Location = New System.Drawing.Point(620, 34)
        Me.PictureBox38.Name = "PictureBox38"
        Me.PictureBox38.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox38.TabIndex = 111
        Me.PictureBox38.TabStop = False
        Me.PictureBox38.Visible = False
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(2627, 235)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(60, 21)
        Me.ComboBox4.TabIndex = 15
        Me.ComboBox4.Visible = False
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label126.ForeColor = System.Drawing.Color.Navy
        Me.Label126.Location = New System.Drawing.Point(2555, 239)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(71, 13)
        Me.Label126.TabIndex = 0
        Me.Label126.Text = "Serie de Guia"
        Me.Label126.Visible = False
        '
        'TextBox82
        '
        Me.TextBox82.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox82.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox82.ForeColor = System.Drawing.Color.SaddleBrown
        Me.TextBox82.Location = New System.Drawing.Point(148, 315)
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.ReadOnly = True
        Me.TextBox82.Size = New System.Drawing.Size(100, 27)
        Me.TextBox82.TabIndex = 10
        Me.TextBox82.Visible = False
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.ForeColor = System.Drawing.Color.Navy
        Me.Label127.Location = New System.Drawing.Point(15, 351)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(130, 19)
        Me.Label127.TabIndex = 96
        Me.Label127.Text = "Forma de pago"
        Me.Label127.Visible = False
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.ForeColor = System.Drawing.Color.Navy
        Me.Label130.Location = New System.Drawing.Point(58, 318)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(87, 19)
        Me.Label130.TabIndex = 93
        Me.Label130.Text = "Vendedor"
        Me.Label130.Visible = False
        '
        'TextBox88
        '
        Me.TextBox88.BackColor = System.Drawing.Color.White
        Me.TextBox88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox88.Location = New System.Drawing.Point(2760, 235)
        Me.TextBox88.Name = "TextBox88"
        Me.TextBox88.Size = New System.Drawing.Size(25, 20)
        Me.TextBox88.TabIndex = 16
        Me.TextBox88.Text = "00"
        Me.TextBox88.Visible = False
        '
        'txt_lt_ft
        '
        Me.txt_lt_ft.BackColor = System.Drawing.Color.White
        Me.txt_lt_ft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lt_ft.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_lt_ft.ForeColor = System.Drawing.Color.Green
        Me.txt_lt_ft.Location = New System.Drawing.Point(94, 158)
        Me.txt_lt_ft.MaxLength = 250
        Me.txt_lt_ft.Name = "txt_lt_ft"
        Me.txt_lt_ft.Size = New System.Drawing.Size(138, 21)
        Me.txt_lt_ft.TabIndex = 209
        Me.txt_lt_ft.Visible = False
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label124.ForeColor = System.Drawing.Color.Navy
        Me.Label124.Location = New System.Drawing.Point(52, 162)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(39, 13)
        Me.Label124.TabIndex = 210
        Me.Label124.Text = "LT/FT"
        Me.Label124.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label124.Visible = False
        '
        'panel_cliente_nuevo
        '
        Me.panel_cliente_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_cliente_nuevo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.panel_cliente_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_cliente_nuevo.Controls.Add(Me.GroupBox14)
        Me.panel_cliente_nuevo.Location = New System.Drawing.Point(701, 245)
        Me.panel_cliente_nuevo.Name = "panel_cliente_nuevo"
        Me.panel_cliente_nuevo.Size = New System.Drawing.Size(19, 409)
        Me.panel_cliente_nuevo.TabIndex = 225
        Me.panel_cliente_nuevo.Visible = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox14.Controls.Add(Me.txt_des_vendedor)
        Me.GroupBox14.Controls.Add(Me.txt_cod_vendedor)
        Me.GroupBox14.Controls.Add(Me.Label134)
        Me.GroupBox14.Controls.Add(Me.txt_des_forma_pago)
        Me.GroupBox14.Controls.Add(Me.txt_cod_forma_pago)
        Me.GroupBox14.Controls.Add(Me.Label133)
        Me.GroupBox14.Controls.Add(Me.Button22)
        Me.GroupBox14.Controls.Add(Me.Button21)
        Me.GroupBox14.Controls.Add(Me.Label21)
        Me.GroupBox14.Controls.Add(Me.txt_des_distrito)
        Me.GroupBox14.Controls.Add(Me.txt_cod_distrito)
        Me.GroupBox14.Controls.Add(Me.Label60)
        Me.GroupBox14.Controls.Add(Me.txt_des_provincia)
        Me.GroupBox14.Controls.Add(Me.txt_cod_provincia)
        Me.GroupBox14.Controls.Add(Me.Label59)
        Me.GroupBox14.Controls.Add(Me.txt_des_departamento)
        Me.GroupBox14.Controls.Add(Me.txt_cod_departamento)
        Me.GroupBox14.Controls.Add(Me.Label58)
        Me.GroupBox14.Controls.Add(Me.txt_Celular)
        Me.GroupBox14.Controls.Add(Me.Label57)
        Me.GroupBox14.Controls.Add(Me.txt_correo)
        Me.GroupBox14.Controls.Add(Me.Label56)
        Me.GroupBox14.Controls.Add(Me.txt_ubigeo)
        Me.GroupBox14.Controls.Add(Me.Label55)
        Me.GroupBox14.Controls.Add(Me.txt_direccion)
        Me.GroupBox14.Controls.Add(Me.Label54)
        Me.GroupBox14.Controls.Add(Me.TextBox7)
        Me.GroupBox14.Controls.Add(Me.Label53)
        Me.GroupBox14.Controls.Add(Me.TextBox5)
        Me.GroupBox14.Controls.Add(Me.Label52)
        Me.GroupBox14.Controls.Add(Me.TextBox4)
        Me.GroupBox14.Controls.Add(Me.Label47)
        Me.GroupBox14.Controls.Add(Me.Label45)
        Me.GroupBox14.Controls.Add(Me.cmb_tip_doc_per)
        Me.GroupBox14.Controls.Add(Me.txt_razon_social)
        Me.GroupBox14.Controls.Add(Me.Label42)
        Me.GroupBox14.Controls.Add(Me.txt_ruc_dni)
        Me.GroupBox14.Controls.Add(Me.Label27)
        Me.GroupBox14.Controls.Add(Me.txt_cod_cliente)
        Me.GroupBox14.Controls.Add(Me.Label132)
        Me.GroupBox14.Controls.Add(Me.TextBox6)
        Me.GroupBox14.Controls.Add(Me.btn_cancelar_nuevo_cliente)
        Me.GroupBox14.Controls.Add(Me.btn_grabar_nuevo_cliente)
        Me.GroupBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox14.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(0, 397)
        Me.GroupBox14.TabIndex = 211
        Me.GroupBox14.TabStop = False
        '
        'txt_des_vendedor
        '
        Me.txt_des_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_vendedor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_des_vendedor.ForeColor = System.Drawing.Color.Green
        Me.txt_des_vendedor.Location = New System.Drawing.Point(182, 250)
        Me.txt_des_vendedor.MaxLength = 200
        Me.txt_des_vendedor.Name = "txt_des_vendedor"
        Me.txt_des_vendedor.ReadOnly = True
        Me.txt_des_vendedor.Size = New System.Drawing.Size(294, 23)
        Me.txt_des_vendedor.TabIndex = 260
        '
        'txt_cod_vendedor
        '
        Me.txt_cod_vendedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_vendedor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_vendedor.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_vendedor.Location = New System.Drawing.Point(135, 250)
        Me.txt_cod_vendedor.MaxLength = 11
        Me.txt_cod_vendedor.Name = "txt_cod_vendedor"
        Me.txt_cod_vendedor.ReadOnly = True
        Me.txt_cod_vendedor.Size = New System.Drawing.Size(41, 23)
        Me.txt_cod_vendedor.TabIndex = 258
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label134.ForeColor = System.Drawing.Color.Navy
        Me.Label134.Location = New System.Drawing.Point(54, 253)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(71, 16)
        Me.Label134.TabIndex = 259
        Me.Label134.Text = "Vendedor"
        '
        'txt_des_forma_pago
        '
        Me.txt_des_forma_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_forma_pago.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_des_forma_pago.ForeColor = System.Drawing.Color.Green
        Me.txt_des_forma_pago.Location = New System.Drawing.Point(182, 223)
        Me.txt_des_forma_pago.MaxLength = 200
        Me.txt_des_forma_pago.Name = "txt_des_forma_pago"
        Me.txt_des_forma_pago.ReadOnly = True
        Me.txt_des_forma_pago.Size = New System.Drawing.Size(294, 23)
        Me.txt_des_forma_pago.TabIndex = 257
        '
        'txt_cod_forma_pago
        '
        Me.txt_cod_forma_pago.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_forma_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_forma_pago.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_forma_pago.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_forma_pago.Location = New System.Drawing.Point(135, 223)
        Me.txt_cod_forma_pago.MaxLength = 11
        Me.txt_cod_forma_pago.Name = "txt_cod_forma_pago"
        Me.txt_cod_forma_pago.ReadOnly = True
        Me.txt_cod_forma_pago.Size = New System.Drawing.Size(41, 23)
        Me.txt_cod_forma_pago.TabIndex = 255
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label133.ForeColor = System.Drawing.Color.Navy
        Me.Label133.Location = New System.Drawing.Point(22, 226)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(103, 16)
        Me.Label133.TabIndex = 256
        Me.Label133.Text = "Forma de pago"
        '
        'Button22
        '
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.Green
        Me.Button22.Image = CType(resources.GetObject("Button22.Image"), System.Drawing.Image)
        Me.Button22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button22.Location = New System.Drawing.Point(360, 45)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(113, 22)
        Me.Button22.TabIndex = 254
        Me.Button22.Text = "DNI"
        Me.Button22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.Green
        Me.Button21.Image = CType(resources.GetObject("Button21.Image"), System.Drawing.Image)
        Me.Button21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button21.Location = New System.Drawing.Point(269, 45)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(86, 22)
        Me.Button21.TabIndex = 253
        Me.Button21.Text = "RUC"
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(58, 125)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 16)
        Me.Label21.TabIndex = 244
        Me.Label21.Text = "Dirección"
        '
        'txt_des_distrito
        '
        Me.txt_des_distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_distrito.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_des_distrito.ForeColor = System.Drawing.Color.Green
        Me.txt_des_distrito.Location = New System.Drawing.Point(182, 197)
        Me.txt_des_distrito.MaxLength = 200
        Me.txt_des_distrito.Name = "txt_des_distrito"
        Me.txt_des_distrito.ReadOnly = True
        Me.txt_des_distrito.Size = New System.Drawing.Size(294, 23)
        Me.txt_des_distrito.TabIndex = 243
        '
        'txt_cod_distrito
        '
        Me.txt_cod_distrito.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_distrito.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_distrito.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_distrito.Location = New System.Drawing.Point(135, 197)
        Me.txt_cod_distrito.MaxLength = 11
        Me.txt_cod_distrito.Name = "txt_cod_distrito"
        Me.txt_cod_distrito.ReadOnly = True
        Me.txt_cod_distrito.Size = New System.Drawing.Size(41, 23)
        Me.txt_cod_distrito.TabIndex = 241
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label60.ForeColor = System.Drawing.Color.Navy
        Me.Label60.Location = New System.Drawing.Point(69, 200)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(56, 16)
        Me.Label60.TabIndex = 242
        Me.Label60.Text = "Distrito"
        '
        'txt_des_provincia
        '
        Me.txt_des_provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_provincia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_des_provincia.ForeColor = System.Drawing.Color.Green
        Me.txt_des_provincia.Location = New System.Drawing.Point(182, 172)
        Me.txt_des_provincia.MaxLength = 200
        Me.txt_des_provincia.Name = "txt_des_provincia"
        Me.txt_des_provincia.ReadOnly = True
        Me.txt_des_provincia.Size = New System.Drawing.Size(294, 23)
        Me.txt_des_provincia.TabIndex = 240
        '
        'txt_cod_provincia
        '
        Me.txt_cod_provincia.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_provincia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_provincia.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_provincia.Location = New System.Drawing.Point(135, 172)
        Me.txt_cod_provincia.MaxLength = 11
        Me.txt_cod_provincia.Name = "txt_cod_provincia"
        Me.txt_cod_provincia.ReadOnly = True
        Me.txt_cod_provincia.Size = New System.Drawing.Size(41, 23)
        Me.txt_cod_provincia.TabIndex = 238
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label59.ForeColor = System.Drawing.Color.Navy
        Me.Label59.Location = New System.Drawing.Point(58, 175)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(67, 16)
        Me.Label59.TabIndex = 239
        Me.Label59.Text = "Provincia"
        '
        'txt_des_departamento
        '
        Me.txt_des_departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_departamento.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_des_departamento.ForeColor = System.Drawing.Color.Green
        Me.txt_des_departamento.Location = New System.Drawing.Point(182, 147)
        Me.txt_des_departamento.MaxLength = 200
        Me.txt_des_departamento.Name = "txt_des_departamento"
        Me.txt_des_departamento.ReadOnly = True
        Me.txt_des_departamento.Size = New System.Drawing.Size(294, 23)
        Me.txt_des_departamento.TabIndex = 237
        '
        'txt_cod_departamento
        '
        Me.txt_cod_departamento.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_departamento.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_departamento.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_departamento.Location = New System.Drawing.Point(135, 147)
        Me.txt_cod_departamento.MaxLength = 11
        Me.txt_cod_departamento.Name = "txt_cod_departamento"
        Me.txt_cod_departamento.ReadOnly = True
        Me.txt_cod_departamento.Size = New System.Drawing.Size(41, 23)
        Me.txt_cod_departamento.TabIndex = 235
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label58.ForeColor = System.Drawing.Color.Navy
        Me.Label58.Location = New System.Drawing.Point(23, 150)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(102, 16)
        Me.Label58.TabIndex = 236
        Me.Label58.Text = "Departamento"
        '
        'txt_Celular
        '
        Me.txt_Celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Celular.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Celular.ForeColor = System.Drawing.Color.Green
        Me.txt_Celular.Location = New System.Drawing.Point(135, 432)
        Me.txt_Celular.MaxLength = 200
        Me.txt_Celular.Name = "txt_Celular"
        Me.txt_Celular.Size = New System.Drawing.Size(400, 27)
        Me.txt_Celular.TabIndex = 233
        Me.txt_Celular.Visible = False
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Navy
        Me.Label57.Location = New System.Drawing.Point(64, 435)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(67, 19)
        Me.Label57.TabIndex = 234
        Me.Label57.Text = "Celular"
        Me.Label57.Visible = False
        '
        'txt_correo
        '
        Me.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_correo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_correo.ForeColor = System.Drawing.Color.Green
        Me.txt_correo.Location = New System.Drawing.Point(135, 279)
        Me.txt_correo.MaxLength = 200
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(341, 23)
        Me.txt_correo.TabIndex = 231
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label56.ForeColor = System.Drawing.Color.Navy
        Me.Label56.Location = New System.Drawing.Point(73, 282)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(52, 16)
        Me.Label56.TabIndex = 232
        Me.Label56.Text = "Correo"
        '
        'txt_ubigeo
        '
        Me.txt_ubigeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ubigeo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ubigeo.ForeColor = System.Drawing.Color.Green
        Me.txt_ubigeo.Location = New System.Drawing.Point(135, 372)
        Me.txt_ubigeo.MaxLength = 6
        Me.txt_ubigeo.Name = "txt_ubigeo"
        Me.txt_ubigeo.Size = New System.Drawing.Size(176, 27)
        Me.txt_ubigeo.TabIndex = 229
        Me.txt_ubigeo.Visible = False
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Navy
        Me.Label55.Location = New System.Drawing.Point(65, 375)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(66, 19)
        Me.Label55.TabIndex = 230
        Me.Label55.Text = "Ubigeo"
        Me.Label55.Visible = False
        '
        'txt_direccion
        '
        Me.txt_direccion.BackColor = System.Drawing.Color.White
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_direccion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_direccion.ForeColor = System.Drawing.Color.Green
        Me.txt_direccion.Location = New System.Drawing.Point(135, 122)
        Me.txt_direccion.MaxLength = 200
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(341, 23)
        Me.txt_direccion.TabIndex = 227
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(47, 548)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(84, 19)
        Me.Label54.TabIndex = 228
        Me.Label54.Text = "Dirección"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Green
        Me.TextBox7.Location = New System.Drawing.Point(135, 515)
        Me.TextBox7.MaxLength = 200
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(400, 27)
        Me.TextBox7.TabIndex = 225
        Me.TextBox7.Visible = False
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(22, 517)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(109, 19)
        Me.Label53.TabIndex = 226
        Me.Label53.Text = "Ap. Materno"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label53.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Green
        Me.TextBox5.Location = New System.Drawing.Point(135, 485)
        Me.TextBox5.MaxLength = 200
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(400, 27)
        Me.TextBox5.TabIndex = 223
        Me.TextBox5.Visible = False
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(25, 487)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(106, 19)
        Me.Label52.TabIndex = 224
        Me.Label52.Text = "Ap. Paterno"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label52.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Green
        Me.TextBox4.Location = New System.Drawing.Point(135, 455)
        Me.TextBox4.MaxLength = 200
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(400, 27)
        Me.TextBox4.TabIndex = 221
        Me.TextBox4.Visible = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(50, 457)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(81, 19)
        Me.Label47.TabIndex = 222
        Me.Label47.Text = "Nombres"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label47.Visible = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(59, 75)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(66, 16)
        Me.Label45.TabIndex = 220
        Me.Label45.Text = "Tipo Doc."
        '
        'cmb_tip_doc_per
        '
        Me.cmb_tip_doc_per.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tip_doc_per.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmb_tip_doc_per.ForeColor = System.Drawing.Color.Green
        Me.cmb_tip_doc_per.FormattingEnabled = True
        Me.cmb_tip_doc_per.Location = New System.Drawing.Point(135, 71)
        Me.cmb_tip_doc_per.Name = "cmb_tip_doc_per"
        Me.cmb_tip_doc_per.Size = New System.Drawing.Size(341, 24)
        Me.cmb_tip_doc_per.TabIndex = 219
        '
        'txt_razon_social
        '
        Me.txt_razon_social.BackColor = System.Drawing.Color.White
        Me.txt_razon_social.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_razon_social.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_razon_social.ForeColor = System.Drawing.Color.Green
        Me.txt_razon_social.Location = New System.Drawing.Point(135, 97)
        Me.txt_razon_social.MaxLength = 200
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(341, 23)
        Me.txt_razon_social.TabIndex = 217
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(33, 100)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(92, 16)
        Me.Label42.TabIndex = 218
        Me.Label42.Text = "Razón social "
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_ruc_dni
        '
        Me.txt_ruc_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc_dni.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_ruc_dni.ForeColor = System.Drawing.Color.Green
        Me.txt_ruc_dni.Location = New System.Drawing.Point(135, 45)
        Me.txt_ruc_dni.MaxLength = 11
        Me.txt_ruc_dni.Name = "txt_ruc_dni"
        Me.txt_ruc_dni.Size = New System.Drawing.Size(127, 23)
        Me.txt_ruc_dni.TabIndex = 215
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(61, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 216
        Me.Label27.Text = "Ruc/ Dni"
        '
        'txt_cod_cliente
        '
        Me.txt_cod_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_cliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_cliente.ForeColor = System.Drawing.Color.Green
        Me.txt_cod_cliente.Location = New System.Drawing.Point(439, 49)
        Me.txt_cod_cliente.MaxLength = 11
        Me.txt_cod_cliente.Name = "txt_cod_cliente"
        Me.txt_cod_cliente.Size = New System.Drawing.Size(176, 27)
        Me.txt_cod_cliente.TabIndex = 213
        Me.txt_cod_cliente.Visible = False
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label132.ForeColor = System.Drawing.Color.Navy
        Me.Label132.Location = New System.Drawing.Point(325, 51)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(108, 19)
        Me.Label132.TabIndex = 214
        Me.Label132.Text = "Cod. Cliente"
        Me.Label132.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Navy
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(3, 16)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(0, 20)
        Me.TextBox6.TabIndex = 212
        Me.TextBox6.Text = "REGISTRO DE CLIENTE NUEVO"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_cancelar_nuevo_cliente
        '
        Me.btn_cancelar_nuevo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_nuevo_cliente.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_cancelar_nuevo_cliente.ForeColor = System.Drawing.Color.Green
        Me.btn_cancelar_nuevo_cliente.Image = CType(resources.GetObject("btn_cancelar_nuevo_cliente.Image"), System.Drawing.Image)
        Me.btn_cancelar_nuevo_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar_nuevo_cliente.Location = New System.Drawing.Point(246, 331)
        Me.btn_cancelar_nuevo_cliente.Name = "btn_cancelar_nuevo_cliente"
        Me.btn_cancelar_nuevo_cliente.Size = New System.Drawing.Size(119, 51)
        Me.btn_cancelar_nuevo_cliente.TabIndex = 210
        Me.btn_cancelar_nuevo_cliente.Text = "&Cancelar"
        Me.btn_cancelar_nuevo_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar_nuevo_cliente.UseVisualStyleBackColor = True
        '
        'btn_grabar_nuevo_cliente
        '
        Me.btn_grabar_nuevo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar_nuevo_cliente.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_grabar_nuevo_cliente.ForeColor = System.Drawing.Color.Green
        Me.btn_grabar_nuevo_cliente.Image = CType(resources.GetObject("btn_grabar_nuevo_cliente.Image"), System.Drawing.Image)
        Me.btn_grabar_nuevo_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar_nuevo_cliente.Location = New System.Drawing.Point(116, 331)
        Me.btn_grabar_nuevo_cliente.Name = "btn_grabar_nuevo_cliente"
        Me.btn_grabar_nuevo_cliente.Size = New System.Drawing.Size(115, 51)
        Me.btn_grabar_nuevo_cliente.TabIndex = 209
        Me.btn_grabar_nuevo_cliente.Text = "G&rabar"
        Me.btn_grabar_nuevo_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar_nuevo_cliente.UseVisualStyleBackColor = True
        '
        'gb_picking
        '
        Me.gb_picking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_picking.BackColor = System.Drawing.Color.White
        Me.gb_picking.Controls.Add(Me.lbl_texto_picking)
        Me.gb_picking.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gb_picking.ForeColor = System.Drawing.Color.Navy
        Me.gb_picking.Location = New System.Drawing.Point(17, 604)
        Me.gb_picking.Name = "gb_picking"
        Me.gb_picking.Size = New System.Drawing.Size(341, 47)
        Me.gb_picking.TabIndex = 226
        Me.gb_picking.TabStop = False
        Me.gb_picking.Visible = False
        '
        'lbl_texto_picking
        '
        Me.lbl_texto_picking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_texto_picking.ForeColor = System.Drawing.Color.Red
        Me.lbl_texto_picking.Location = New System.Drawing.Point(11, 22)
        Me.lbl_texto_picking.Name = "lbl_texto_picking"
        Me.lbl_texto_picking.Size = New System.Drawing.Size(318, 13)
        Me.lbl_texto_picking.TabIndex = 0
        Me.lbl_texto_picking.Text = "Label143"
        Me.lbl_texto_picking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmFacturacionRapida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1214, 662)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.gb_picking)
        Me.Controls.Add(Me.panel_cliente_nuevo)
        Me.Controls.Add(Me.pnl_cierre_ventas)
        Me.Controls.Add(Me.pnlNuevaPlanilla)
        Me.Controls.Add(Me.pnl_motivo_anulacion)
        Me.Controls.Add(Me.pnl_ref)
        Me.Controls.Add(Me.GbCabecera)
        Me.Controls.Add(Me.gbdetalle)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.gbTipoGuia)
        Me.Controls.Add(Me.gbTipoFacturacion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GrpAgregarProductos)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.txtredondeo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GrpProductos)
        Me.Controls.Add(Me.GrpObservaciones)
        Me.Controls.Add(Me.GrpRecepcionTercero)
        Me.Controls.Add(Me.GrpLugarEntrega)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFacturacionRapida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout
        Me.gbTipoGuia.ResumeLayout(False)
        Me.gbTipoGuia.PerformLayout
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout
        Me.GrpContacto.ResumeLayout(False)
        Me.GrpContacto.PerformLayout
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit
        Me.GbdetalleDocumento.ResumeLayout(False)
        Me.GbdetalleDocumento.PerformLayout
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit
        Me.gbTipoFacturacion.ResumeLayout(False)
        Me.gbTipoFacturacion.PerformLayout
        Me.gbdetalle.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit
        Me.gbOpciones.ResumeLayout(False)
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout
        Me.pnl_ref.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit
        Me.GrpAgregarProductos.ResumeLayout(False)
        Me.GrpAgregarProductos.PerformLayout
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout
        Me.GrpProductos.ResumeLayout(False)
        Me.GrpProductos.PerformLayout
        CType(Me.dgv_lista_productos, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_motivo_anulacion.ResumeLayout(False)
        Me.pnl_motivo_anulacion.PerformLayout
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout
        Me.pnl_cierre_ventas.ResumeLayout(False)
        Me.pnl_cierre_ventas.PerformLayout
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout
        Me.gb_pago_tarjeta.ResumeLayout(False)
        Me.gb_pago_tarjeta.PerformLayout
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit
        Me.gb_pago_efectivo.ResumeLayout(False)
        Me.gb_pago_efectivo.PerformLayout
        Me.pnlNuevaPlanilla.ResumeLayout(False)
        Me.pnlNuevaPlanilla.PerformLayout
        Me.gb_nueva_planilla.ResumeLayout(False)
        Me.gb_nueva_planilla.PerformLayout
        Me.GrpObservaciones.ResumeLayout(False)
        Me.GrpObservaciones.PerformLayout
        Me.GrpRecepcionTercero.ResumeLayout(False)
        Me.GrpRecepcionTercero.PerformLayout
        Me.GrpLugarEntrega.ResumeLayout(False)
        Me.GrpLugarEntrega.PerformLayout
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).EndInit
        Me.panel_cliente_nuevo.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout
        Me.gb_picking.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVariaslineasDoc As System.Windows.Forms.RadioButton
    Friend WithEvents rbunalineaDoc As System.Windows.Forms.RadioButton
    Friend WithEvents txtGlosa As System.Windows.Forms.RichTextBox
    Friend WithEvents gbTipoGuia As System.Windows.Forms.GroupBox
    Friend WithEvents rbVariaslineas As System.Windows.Forms.RadioButton
    Friend WithEvents rbunalinea As System.Windows.Forms.RadioButton
    Friend WithEvents txtGlosaGuia As System.Windows.Forms.RichTextBox
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_trama As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txt_vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents rbDocRef_varios As System.Windows.Forms.RadioButton
    Friend WithEvents rbDocRef_uno As System.Windows.Forms.RadioButton
    Friend WithEvents GbdetalleDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtdetalleguiaserie As System.Windows.Forms.TextBox
    Friend WithEvents txtdetalleserie As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroCP As System.Windows.Forms.TextBox
    Friend WithEvents txtdetalleguianumero As System.Windows.Forms.TextBox
    Friend WithEvents txtSerieCP As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoCP As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtdetallenumero As System.Windows.Forms.TextBox
    Friend WithEvents txtdetalleguiadoc As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtdetalledoc As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtSerieDocRef As System.Windows.Forms.TextBox
    Friend WithEvents txttipoDocRef As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents checkSinGuia As System.Windows.Forms.CheckBox
    Friend WithEvents lblAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents txtAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboDirEntrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtordenCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtcotizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtNumDocRef As System.Windows.Forms.TextBox
    Friend WithEvents chkSinIGV As System.Windows.Forms.CheckBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtpedido As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionTrama As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcodigoTrama As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionTransportista As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcodigoTransporte As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdescVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcodigoVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdescEsp As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtdescCli As System.Windows.Forms.TextBox
    Friend WithEvents lblFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtNomTrans As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPtoVenta As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents cbSerieGuia As System.Windows.Forms.ComboBox
    Friend WithEvents cboSerieDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtRucDni As System.Windows.Forms.TextBox
    Friend WithEvents txtCod_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents txtPtoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodTrans As System.Windows.Forms.TextBox
    Friend WithEvents gbTipoFacturacion As System.Windows.Forms.GroupBox
    Friend WithEvents rb_facturar_devolucion As System.Windows.Forms.RadioButton
    Friend WithEvents rb_facturar_pedido As System.Windows.Forms.RadioButton
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents rbFacturaRepMedico As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturaExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturaGuiaVenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturaDirecta As System.Windows.Forms.RadioButton
    Friend WithEvents rbsinDescargo As System.Windows.Forms.RadioButton
    Friend WithEvents gbdetalle As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtredondeo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents dgvDocumentosFactura As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnclientenuevo As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txt_desc_tipo_nota_electronica As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_tip_nota_electronica As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents pnl_ref As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fec_doc_ref As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_ref_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_serie_ref_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo_doc_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents GrpAgregarProductos As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtvalorVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GrpProductos As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents PictureBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox22 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox42 As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents TextBox43 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox23 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox44 As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents TextBox45 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox24 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox46 As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents TextBox47 As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents TextBox49 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox51 As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents TextBox52 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox27 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents TextBox61 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents btn_agregar_carrito As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtDescuentos As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtBruto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtIsc As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txt_por_Des As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents rdb_f_a4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_f_ticket As System.Windows.Forms.RadioButton
    Friend WithEvents pnl_motivo_anulacion As System.Windows.Forms.Panel
    Friend WithEvents txt_motivo_anulacion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_anulacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents pnl_cierre_ventas As System.Windows.Forms.Panel
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_cierre_ventas As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents chk_facturar_obsequio As System.Windows.Forms.CheckBox
    Friend WithEvents pnlNuevaPlanilla As System.Windows.Forms.Panel
    Friend WithEvents gb_nueva_planilla As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar_crear As System.Windows.Forms.Button
    Friend WithEvents btn_crear_planilla As System.Windows.Forms.Button
    Friend WithEvents dtp_fec_nueva_pla As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents txt_buscador_especial As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents txt_saldo_inicial_caja As System.Windows.Forms.TextBox
    Friend WithEvents txt_buscador_productos As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero_lote As System.Windows.Forms.TextBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents dgv_lista_productos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_nombre_usuario As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents lbl_usuario_cierre As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents gb_pago_tarjeta As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox21 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox25 As System.Windows.Forms.PictureBox
    Friend WithEvents AMOUNT_AMERICAN_EXPRES As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNT_DINERS As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNT_CARD_MASTER As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNT_CARD_VISA As System.Windows.Forms.TextBox
    Friend WithEvents gb_pago_efectivo As System.Windows.Forms.GroupBox
    Friend WithEvents TxEfeDol As System.Windows.Forms.TextBox
    Friend WithEvents txt_saldo_final As System.Windows.Forms.TextBox
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad_fraccion As System.Windows.Forms.TextBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents txtprecioUnitario_fraccion As System.Windows.Forms.TextBox
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents txt_validez_oferta As System.Windows.Forms.TextBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents chkigv As System.Windows.Forms.CheckBox
    Friend WithEvents GrpObservaciones As System.Windows.Forms.GroupBox
    Friend WithEvents txt_obs_general As System.Windows.Forms.TextBox
    Friend WithEvents GrpRecepcionTercero As System.Windows.Forms.GroupBox
    Friend WithEvents txt_recepcion_tercero As System.Windows.Forms.TextBox
    Friend WithEvents GrpLugarEntrega As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox26 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents PictureBox28 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox29 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox30 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents PictureBox31 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox32 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox48 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox50 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox53 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox54 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox55 As System.Windows.Forms.TextBox
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents TextBox56 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox57 As System.Windows.Forms.TextBox
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents TextBox58 As System.Windows.Forms.TextBox
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents TextBox59 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox60 As System.Windows.Forms.TextBox
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents PictureBox33 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents TextBox64 As System.Windows.Forms.TextBox
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents TextBox65 As System.Windows.Forms.TextBox
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents TextBox66 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents TextBox67 As System.Windows.Forms.TextBox
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents TextBox68 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox34 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox69 As System.Windows.Forms.TextBox
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents TextBox70 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox35 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox71 As System.Windows.Forms.TextBox
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents TextBox72 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox36 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox73 As System.Windows.Forms.TextBox
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents TextBox74 As System.Windows.Forms.TextBox
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents TextBox75 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox76 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox78 As System.Windows.Forms.TextBox
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents PictureBox37 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox38 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents TextBox82 As System.Windows.Forms.TextBox
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents TextBox88 As System.Windows.Forms.TextBox
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents txt_des_agencia_trans As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_agencia_trans As System.Windows.Forms.TextBox
    Friend WithEvents txt_provincia As System.Windows.Forms.TextBox
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents txt_guia As System.Windows.Forms.TextBox
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents rdb_domicilio As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_agencia As System.Windows.Forms.RadioButton
    Friend WithEvents txt_lt_ft As System.Windows.Forms.TextBox
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents chk_cheque As System.Windows.Forms.CheckBox
    Friend WithEvents txt_n_operacion As System.Windows.Forms.TextBox
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents txt_des_transferencia As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_transferencia As System.Windows.Forms.TextBox
    Friend WithEvents btn_aprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblModoPago As System.Windows.Forms.TextBox
    Friend WithEvents txtModoPago As System.Windows.Forms.TextBox
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents btn_deshacer_aprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk_letra_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_factura_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_guia_2 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_imprimir_fc As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_imprimir_tk As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk_efectivo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_transferencia As System.Windows.Forms.CheckBox
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents panel_cliente_nuevo As System.Windows.Forms.Panel
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_des_distrito As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_distrito As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txt_des_provincia As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_provincia As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txt_des_departamento As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_departamento As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txt_Celular As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txt_ubigeo As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cmb_tip_doc_per As System.Windows.Forms.ComboBox
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txt_ruc_dni As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_grabar_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_cotizacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_des_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents txt_des_forma_pago As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_forma_pago As System.Windows.Forms.TextBox
    Friend WithEvents Label133 As System.Windows.Forms.Label
    Friend WithEvents Label135 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents btnOrdenCompra As System.Windows.Forms.Button
    Friend WithEvents cboTipoPedido As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoPedido As System.Windows.Forms.Label
    Friend WithEvents GrpContacto As System.Windows.Forms.GroupBox
    Friend WithEvents Label136 As System.Windows.Forms.Label
    Friend WithEvents Label137 As System.Windows.Forms.Label
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents txtContactoNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtContactoCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtContactoDNI As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDireccionEntregaCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents dtpHoraRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label140 As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_opt_agencia As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_opt_domicilio As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_opt_recojo As System.Windows.Forms.RadioButton
    Friend WithEvents txtLocalDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionTransportistaDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionAgencia As System.Windows.Forms.Label
    Friend WithEvents txtDireccionCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionTransportista As System.Windows.Forms.TextBox
    Friend WithEvents txtLocal As System.Windows.Forms.TextBox
    Friend WithEvents gb_picking As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_texto_picking As System.Windows.Forms.Label
    Friend WithEvents chkSinOC As System.Windows.Forms.CheckBox
    Friend WithEvents lblFechaCreacion As System.Windows.Forms.Label
    Friend WithEvents lblusuarioId As System.Windows.Forms.Label
    Friend WithEvents TxtFechaCreacion As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents rdb_opt_Lima As System.Windows.Forms.RadioButton
End Class
