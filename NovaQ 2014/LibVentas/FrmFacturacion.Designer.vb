<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacion
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacion))
        Me.gbdetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.btnPdfOrdenCompra = New System.Windows.Forms.Button()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.rdb_trans_privado = New System.Windows.Forms.RadioButton()
        Me.rdb_trans_publico = New System.Windows.Forms.RadioButton()
        Me.btn_cliente_nuevo = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.lblModoPago = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtModoPago = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.txt_desc_tipo_nota_electronica = New System.Windows.Forms.TextBox()
        Me.txt_cod_tipo_nota_electronica = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txt_email_cliente = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txt_fecha_ref = New System.Windows.Forms.TextBox()
        Me.dtp_fecha_traslado = New System.Windows.Forms.DateTimePicker()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txt_ref_guia_Devolucion = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txt_nro_entrega = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
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
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
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
        Me.pnlDocumentosGuiaVenta = New System.Windows.Forms.Panel()
        Me.lblDetalle = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtFiltroCliente = New System.Windows.Forms.TextBox()
        Me.dgvDocumentosCliente = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rbVariaslineasDoc = New System.Windows.Forms.RadioButton()
        Me.rbunalineaDoc = New System.Windows.Forms.RadioButton()
        Me.txtGlosa = New System.Windows.Forms.RichTextBox()
        Me.gbTipoGuia = New System.Windows.Forms.GroupBox()
        Me.rbVariaslineas = New System.Windows.Forms.RadioButton()
        Me.rbunalinea = New System.Windows.Forms.RadioButton()
        Me.txtGlosaGuia = New System.Windows.Forms.RichTextBox()
        Me.dgvDocumentosFactura = New System.Windows.Forms.DataGridView()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtredondeo = New System.Windows.Forms.TextBox()
        Me.txtBruto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtvalorVenta = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboOpcionTipoDoc = New System.Windows.Forms.ComboBox()
        Me.btnSalirNumeracion = New System.Windows.Forms.Button()
        Me.btnAceptarBusquedaOC = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtBuscarOrdenCompra = New System.Windows.Forms.TextBox()
        Me.PnlBuscarordenCompra = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbTipoFacturacion = New System.Windows.Forms.GroupBox()
        Me.rb_facturar_obsequio_sin_pedido = New System.Windows.Forms.RadioButton()
        Me.rbfacturaExportacion = New System.Windows.Forms.RadioButton()
        Me.rb_facturar_obsequio = New System.Windows.Forms.RadioButton()
        Me.rb_facturar_devolucion = New System.Windows.Forms.RadioButton()
        Me.rb_facturar_pedido = New System.Windows.Forms.RadioButton()
        Me.rbFacturaRepMedico = New System.Windows.Forms.RadioButton()
        Me.rbFacturaExistencias = New System.Windows.Forms.RadioButton()
        Me.rbFacturaGuiaVenta = New System.Windows.Forms.RadioButton()
        Me.rbFacturaDirecta = New System.Windows.Forms.RadioButton()
        Me.rbsinDescargo = New System.Windows.Forms.RadioButton()
        Me.pnlConfirmarDespacho = New System.Windows.Forms.Panel()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txt_emp_trans_manual = New System.Windows.Forms.TextBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_trans_manual_despacho = New System.Windows.Forms.TextBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_transportista = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txt_des_transportista_despacho = New System.Windows.Forms.TextBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_emp_trans = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_des_emp_trans = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txt_obs_despachos = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dtpDespacho = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lblDespachoNumero = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.btn_SalirDesp = New System.Windows.Forms.Button()
        Me.btn_AceptarDesp = New System.Windows.Forms.Button()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_datos_vehiculo = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txt_des_datos_vehiculo = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txt_datos_vehiculo = New System.Windows.Forms.TextBox()
        Me.rb_electivo_datos_vehiculo = New System.Windows.Forms.RadioButton()
        Me.rb_manual_datos_vehiculo = New System.Windows.Forms.RadioButton()
        Me.pnlDocReferencia = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtref_tipo = New System.Windows.Forms.TextBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.dgv_Lista_Doc_Ref = New System.Windows.Forms.DataGridView()
        Me.btnSalr = New System.Windows.Forms.Button()
        Me.txtref_monto = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.dtpRef_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtref_igv = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtref_serie = New System.Windows.Forms.TextBox()
        Me.txtref_num_doc = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btn_modificar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnAnular = New System.Windows.Forms.ToolStripButton()
        Me.btn_consultando = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_act_vendedor = New System.Windows.Forms.ToolStripButton()
        Me.btn_sincronizar_cpe = New System.Windows.Forms.ToolStripButton()
        Me.btn_descargar_archivos = New System.Windows.Forms.ToolStripButton()
        Me.btn_enviar_mail = New System.Windows.Forms.ToolStripButton()
        Me.btnContabilizar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnDespacho = New System.Windows.Forms.ToolStripButton()
        Me.btnGenerarCP = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.pnl_pedido = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btn_salir_pedido = New System.Windows.Forms.Button()
        Me.btn_ok_pedido = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txt_filtrar_pedido = New System.Windows.Forms.TextBox()
        Me.dgv_cab_ped = New System.Windows.Forms.DataGridView()
        Me.pnl_devoluciones = New System.Windows.Forms.Panel()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.txt_busqueda_dev = New System.Windows.Forms.TextBox()
        Me.dgv_detalle_dev = New System.Windows.Forms.DataGridView()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btn_devolucion_salir = New System.Windows.Forms.Button()
        Me.btn_devolucion_ok = New System.Windows.Forms.Button()
        Me.panel_estado_cuenta = New System.Windows.Forms.Panel()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.lblmensajedocvencidos = New System.Windows.Forms.Label()
        Me.lblmensaje = New System.Windows.Forms.Label()
        Me.lbltotaldolares = New System.Windows.Forms.Label()
        Me.lbltotalsoles = New System.Windows.Forms.Label()
        Me.lblcreditlimitdolares = New System.Windows.Forms.Label()
        Me.lblcreditlimitsoles = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.dgv_estado_cuenta_cliente = New System.Windows.Forms.DataGridView()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnl_motivo_anulacion = New System.Windows.Forms.Panel()
        Me.txt_motivo_anulacion = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_anulacion = New System.Windows.Forms.DateTimePicker()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.pnl_vendedor = New System.Windows.Forms.Panel()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.txt_mp_act_desc = New System.Windows.Forms.TextBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.txt_mp_act = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txt_mp_ant_desc = New System.Windows.Forms.TextBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.txt_mp_ant = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.txt_fp_act_desc = New System.Windows.Forms.TextBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.txt_fp_act = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txt_fp_ant_desc = New System.Windows.Forms.TextBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.txt_fp_ant = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.txt_vend_act_desc = New System.Windows.Forms.TextBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.txt_vend_act = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txt_vend_ant_desc = New System.Windows.Forms.TextBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.txt_vend_ant = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.pnl_forma_de_pago = New System.Windows.Forms.Panel()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.txt_forma_de_pago = New System.Windows.Forms.RichTextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txt_forma_de_pago2 = New System.Windows.Forms.RichTextBox()
        Me.btn_detalle_pedido = New System.Windows.Forms.Button()
        Me.panel_cliente_nuevo = New System.Windows.Forms.Panel()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txt_Celular = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txt_ubigeo = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.btn_cancelar_nuevo_cliente = New System.Windows.Forms.Button()
        Me.btn_grabar_nuevo_cliente = New System.Windows.Forms.Button()
        Me.gbdetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        Me.GbCabecera.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbdetalleDocumento.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDocumentosGuiaVenta.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvDocumentosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.gbTipoGuia.SuspendLayout()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.PnlBuscarordenCompra.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbTipoFacturacion.SuspendLayout()
        Me.pnlConfirmarDespacho.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDocReferencia.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgv_Lista_Doc_Ref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrincipal.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnl_pedido.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.dgv_cab_ped, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_devoluciones.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.dgv_detalle_dev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_estado_cuenta.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.dgv_estado_cuenta_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_motivo_anulacion.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.pnl_vendedor.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox22.SuspendLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox21.SuspendLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_forma_de_pago.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.panel_cliente_nuevo.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbdetalle
        '
        Me.gbdetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbdetalle.BackColor = System.Drawing.Color.White
        Me.gbdetalle.Controls.Add(Me.dgvDetalle)
        Me.gbdetalle.Location = New System.Drawing.Point(8, 399)
        Me.gbdetalle.Name = "gbdetalle"
        Me.gbdetalle.Size = New System.Drawing.Size(1064, 141)
        Me.gbdetalle.TabIndex = 114
        Me.gbdetalle.TabStop = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDetalle.Location = New System.Drawing.Point(8, 13)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(1051, 122)
        Me.dgvDetalle.TabIndex = 112
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.ForeColor = System.Drawing.Color.Navy
        Me.gbOpciones.Location = New System.Drawing.Point(1078, 399)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(69, 141)
        Me.gbOpciones.TabIndex = 115
        Me.gbOpciones.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(4, 53)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(60, 44)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnquitar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.Location = New System.Drawing.Point(4, 99)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(60, 44)
        Me.btnquitar.TabIndex = 15
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(4, 6)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(60, 44)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GbCabecera
        '
        Me.GbCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.btnPdfOrdenCompra)
        Me.GbCabecera.Controls.Add(Me.GroupBox30)
        Me.GbCabecera.Controls.Add(Me.btn_cliente_nuevo)
        Me.GbCabecera.Controls.Add(Me.Button7)
        Me.GbCabecera.Controls.Add(Me.lblModoPago)
        Me.GbCabecera.Controls.Add(Me.PictureBox1)
        Me.GbCabecera.Controls.Add(Me.txtModoPago)
        Me.GbCabecera.Controls.Add(Me.Label67)
        Me.GbCabecera.Controls.Add(Me.Label63)
        Me.GbCabecera.Controls.Add(Me.PictureBox18)
        Me.GbCabecera.Controls.Add(Me.txt_desc_tipo_nota_electronica)
        Me.GbCabecera.Controls.Add(Me.txt_cod_tipo_nota_electronica)
        Me.GbCabecera.Controls.Add(Me.Label64)
        Me.GbCabecera.Controls.Add(Me.txt_email_cliente)
        Me.GbCabecera.Controls.Add(Me.Label62)
        Me.GbCabecera.Controls.Add(Me.txt_fecha_ref)
        Me.GbCabecera.Controls.Add(Me.dtp_fecha_traslado)
        Me.GbCabecera.Controls.Add(Me.Label48)
        Me.GbCabecera.Controls.Add(Me.txt_ref_guia_Devolucion)
        Me.GbCabecera.Controls.Add(Me.Label59)
        Me.GbCabecera.Controls.Add(Me.txt_nro_entrega)
        Me.GbCabecera.Controls.Add(Me.Label55)
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
        Me.GbCabecera.Controls.Add(Me.txtCodCliente)
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
        Me.GbCabecera.ForeColor = System.Drawing.Color.Navy
        Me.GbCabecera.Location = New System.Drawing.Point(7, 60)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(1140, 259)
        Me.GbCabecera.TabIndex = 116
        Me.GbCabecera.TabStop = False
        '
        'btnPdfOrdenCompra
        '
        Me.btnPdfOrdenCompra.Image = CType(resources.GetObject("btnPdfOrdenCompra.Image"), System.Drawing.Image)
        Me.btnPdfOrdenCompra.Location = New System.Drawing.Point(149, 118)
        Me.btnPdfOrdenCompra.Name = "btnPdfOrdenCompra"
        Me.btnPdfOrdenCompra.Size = New System.Drawing.Size(29, 24)
        Me.btnPdfOrdenCompra.TabIndex = 238
        Me.btnPdfOrdenCompra.UseVisualStyleBackColor = True
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.rdb_trans_privado)
        Me.GroupBox30.Controls.Add(Me.rdb_trans_publico)
        Me.GroupBox30.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox30.Location = New System.Drawing.Point(982, 219)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(210, 33)
        Me.GroupBox30.TabIndex = 236
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Modalidad de Transporte"
        '
        'rdb_trans_privado
        '
        Me.rdb_trans_privado.AutoSize = True
        Me.rdb_trans_privado.Location = New System.Drawing.Point(109, 14)
        Me.rdb_trans_privado.Name = "rdb_trans_privado"
        Me.rdb_trans_privado.Size = New System.Drawing.Size(93, 17)
        Me.rdb_trans_privado.TabIndex = 1
        Me.rdb_trans_privado.TabStop = True
        Me.rdb_trans_privado.Text = "Trans. privado"
        Me.rdb_trans_privado.UseVisualStyleBackColor = True
        '
        'rdb_trans_publico
        '
        Me.rdb_trans_publico.AutoSize = True
        Me.rdb_trans_publico.Checked = True
        Me.rdb_trans_publico.Location = New System.Drawing.Point(10, 14)
        Me.rdb_trans_publico.Name = "rdb_trans_publico"
        Me.rdb_trans_publico.Size = New System.Drawing.Size(92, 17)
        Me.rdb_trans_publico.TabIndex = 0
        Me.rdb_trans_publico.TabStop = True
        Me.rdb_trans_publico.Text = "Trans. público"
        Me.rdb_trans_publico.UseVisualStyleBackColor = True
        '
        'btn_cliente_nuevo
        '
        Me.btn_cliente_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_cliente_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cliente_nuevo.ForeColor = System.Drawing.Color.Red
        Me.btn_cliente_nuevo.Image = CType(resources.GetObject("btn_cliente_nuevo.Image"), System.Drawing.Image)
        Me.btn_cliente_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cliente_nuevo.Location = New System.Drawing.Point(802, 53)
        Me.btn_cliente_nuevo.Name = "btn_cliente_nuevo"
        Me.btn_cliente_nuevo.Size = New System.Drawing.Size(110, 24)
        Me.btn_cliente_nuevo.TabIndex = 223
        Me.btn_cliente_nuevo.Text = "Cliente nuevo"
        Me.btn_cliente_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cliente_nuevo.UseVisualStyleBackColor = True
        Me.btn_cliente_nuevo.Visible = False
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(796, 97)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(23, 24)
        Me.Button7.TabIndex = 220
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'lblModoPago
        '
        Me.lblModoPago.BackColor = System.Drawing.Color.White
        Me.lblModoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblModoPago.Location = New System.Drawing.Point(518, 120)
        Me.lblModoPago.Name = "lblModoPago"
        Me.lblModoPago.ReadOnly = True
        Me.lblModoPago.Size = New System.Drawing.Size(275, 20)
        Me.lblModoPago.TabIndex = 216
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(500, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox1.TabIndex = 218
        Me.PictureBox1.TabStop = False
        '
        'txtModoPago
        '
        Me.txtModoPago.BackColor = System.Drawing.Color.Aquamarine
        Me.txtModoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModoPago.Location = New System.Drawing.Point(461, 120)
        Me.txtModoPago.MaxLength = 4
        Me.txtModoPago.Name = "txtModoPago"
        Me.txtModoPago.ReadOnly = True
        Me.txtModoPago.Size = New System.Drawing.Size(37, 20)
        Me.txtModoPago.TabIndex = 215
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.ForeColor = System.Drawing.Color.Navy
        Me.Label67.Location = New System.Drawing.Point(383, 124)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(76, 13)
        Me.Label67.TabIndex = 217
        Me.Label67.Text = "Modo de pago"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label63.ForeColor = System.Drawing.Color.Navy
        Me.Label63.Location = New System.Drawing.Point(26, 145)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(36, 13)
        Me.Label63.TabIndex = 214
        Me.Label63.Text = "E-Mail"
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = CType(resources.GetObject("PictureBox18.Image"), System.Drawing.Image)
        Me.PictureBox18.Location = New System.Drawing.Point(111, 163)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox18.TabIndex = 213
        Me.PictureBox18.TabStop = False
        '
        'txt_desc_tipo_nota_electronica
        '
        Me.txt_desc_tipo_nota_electronica.BackColor = System.Drawing.Color.White
        Me.txt_desc_tipo_nota_electronica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_tipo_nota_electronica.Location = New System.Drawing.Point(128, 162)
        Me.txt_desc_tipo_nota_electronica.MaxLength = 200
        Me.txt_desc_tipo_nota_electronica.Name = "txt_desc_tipo_nota_electronica"
        Me.txt_desc_tipo_nota_electronica.ReadOnly = True
        Me.txt_desc_tipo_nota_electronica.Size = New System.Drawing.Size(665, 20)
        Me.txt_desc_tipo_nota_electronica.TabIndex = 211
        '
        'txt_cod_tipo_nota_electronica
        '
        Me.txt_cod_tipo_nota_electronica.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_tipo_nota_electronica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_tipo_nota_electronica.Location = New System.Drawing.Point(67, 162)
        Me.txt_cod_tipo_nota_electronica.MaxLength = 5
        Me.txt_cod_tipo_nota_electronica.Name = "txt_cod_tipo_nota_electronica"
        Me.txt_cod_tipo_nota_electronica.ReadOnly = True
        Me.txt_cod_tipo_nota_electronica.Size = New System.Drawing.Size(42, 20)
        Me.txt_cod_tipo_nota_electronica.TabIndex = 210
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.ForeColor = System.Drawing.Color.Navy
        Me.Label64.Location = New System.Drawing.Point(4, 166)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(58, 13)
        Me.Label64.TabIndex = 212
        Me.Label64.Text = "T. N. Elec."
        '
        'txt_email_cliente
        '
        Me.txt_email_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email_cliente.Location = New System.Drawing.Point(67, 141)
        Me.txt_email_cliente.MaxLength = 255
        Me.txt_email_cliente.Name = "txt_email_cliente"
        Me.txt_email_cliente.Size = New System.Drawing.Size(726, 20)
        Me.txt_email_cliente.TabIndex = 209
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label62.ForeColor = System.Drawing.Color.Navy
        Me.Label62.Location = New System.Drawing.Point(799, 36)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(77, 13)
        Me.Label62.TabIndex = 208
        Me.Label62.Text = "Fec. Doc. Ref."
        '
        'txt_fecha_ref
        '
        Me.txt_fecha_ref.BackColor = System.Drawing.Color.White
        Me.txt_fecha_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fecha_ref.Location = New System.Drawing.Point(883, 32)
        Me.txt_fecha_ref.Name = "txt_fecha_ref"
        Me.txt_fecha_ref.ReadOnly = True
        Me.txt_fecha_ref.Size = New System.Drawing.Size(74, 20)
        Me.txt_fecha_ref.TabIndex = 207
        '
        'dtp_fecha_traslado
        '
        Me.dtp_fecha_traslado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_traslado.Location = New System.Drawing.Point(754, 209)
        Me.dtp_fecha_traslado.Name = "dtp_fecha_traslado"
        Me.dtp_fecha_traslado.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_traslado.TabIndex = 190
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label48.ForeColor = System.Drawing.Color.Navy
        Me.Label48.Location = New System.Drawing.Point(704, 206)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(48, 26)
        Me.Label48.TabIndex = 191
        Me.Label48.Text = "Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Traslado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_ref_guia_Devolucion
        '
        Me.txt_ref_guia_Devolucion.BackColor = System.Drawing.Color.White
        Me.txt_ref_guia_Devolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ref_guia_Devolucion.Location = New System.Drawing.Point(850, 235)
        Me.txt_ref_guia_Devolucion.MaxLength = 200
        Me.txt_ref_guia_Devolucion.Name = "txt_ref_guia_Devolucion"
        Me.txt_ref_guia_Devolucion.Size = New System.Drawing.Size(122, 20)
        Me.txt_ref_guia_Devolucion.TabIndex = 188
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label59.ForeColor = System.Drawing.Color.Navy
        Me.Label59.Location = New System.Drawing.Point(742, 239)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(93, 13)
        Me.Label59.TabIndex = 189
        Me.Label59.Text = "N° Ref. Guia Dev."
        '
        'txt_nro_entrega
        '
        Me.txt_nro_entrega.BackColor = System.Drawing.Color.White
        Me.txt_nro_entrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_entrega.Location = New System.Drawing.Point(613, 235)
        Me.txt_nro_entrega.MaxLength = 200
        Me.txt_nro_entrega.Name = "txt_nro_entrega"
        Me.txt_nro_entrega.Size = New System.Drawing.Size(122, 20)
        Me.txt_nro_entrega.TabIndex = 186
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label55.ForeColor = System.Drawing.Color.Navy
        Me.Label55.Location = New System.Drawing.Point(552, 239)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(59, 13)
        Me.Label55.TabIndex = 187
        Me.Label55.Text = "N° Entrega"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(530, 237)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox12.TabIndex = 185
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(361, 237)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox11.TabIndex = 184
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(151, 237)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox10.TabIndex = 183
        Me.PictureBox10.TabStop = False
        '
        'txt_trama
        '
        Me.txt_trama.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_trama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trama.Location = New System.Drawing.Point(427, 235)
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
        Me.Label51.Location = New System.Drawing.Point(385, 239)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 13)
        Me.Label51.TabIndex = 182
        Me.Label51.Text = "Trama"
        '
        'txt_Empresa
        '
        Me.txt_Empresa.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Empresa.Location = New System.Drawing.Point(279, 235)
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
        Me.Label50.Location = New System.Drawing.Point(174, 239)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(102, 13)
        Me.Label50.TabIndex = 180
        Me.Label50.Text = "Empresa Transporte"
        '
        'txt_vehiculo
        '
        Me.txt_vehiculo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vehiculo.Location = New System.Drawing.Point(67, 235)
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
        Me.Label49.Location = New System.Drawing.Point(14, 239)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(48, 13)
        Me.Label49.TabIndex = 178
        Me.Label49.Text = "Vehiculo"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(370, 187)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 118
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(482, 33)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 176
        Me.PictureBox6.TabStop = False
        '
        'rbDocRef_varios
        '
        Me.rbDocRef_varios.AutoSize = True
        Me.rbDocRef_varios.ForeColor = System.Drawing.Color.Navy
        Me.rbDocRef_varios.Location = New System.Drawing.Point(963, 37)
        Me.rbDocRef_varios.Name = "rbDocRef_varios"
        Me.rbDocRef_varios.Size = New System.Drawing.Size(98, 17)
        Me.rbDocRef_varios.TabIndex = 174
        Me.rbDocRef_varios.Text = "Varios doc Ref."
        Me.rbDocRef_varios.UseVisualStyleBackColor = True
        Me.rbDocRef_varios.Visible = False
        '
        'rbDocRef_uno
        '
        Me.rbDocRef_uno.AutoSize = True
        Me.rbDocRef_uno.Checked = True
        Me.rbDocRef_uno.ForeColor = System.Drawing.Color.Navy
        Me.rbDocRef_uno.Location = New System.Drawing.Point(388, 57)
        Me.rbDocRef_uno.Name = "rbDocRef_uno"
        Me.rbDocRef_uno.Size = New System.Drawing.Size(86, 17)
        Me.rbDocRef_uno.TabIndex = 173
        Me.rbDocRef_uno.TabStop = True
        Me.rbDocRef_uno.Text = "Un doc. Ref."
        Me.rbDocRef_uno.UseVisualStyleBackColor = True
        Me.rbDocRef_uno.Visible = False
        '
        'GbdetalleDocumento
        '
        Me.GbdetalleDocumento.BackColor = System.Drawing.SystemColors.GradientActiveCaption
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
        Me.GbdetalleDocumento.Location = New System.Drawing.Point(814, 62)
        Me.GbdetalleDocumento.Name = "GbdetalleDocumento"
        Me.GbdetalleDocumento.Size = New System.Drawing.Size(359, 95)
        Me.GbdetalleDocumento.TabIndex = 170
        Me.GbdetalleDocumento.TabStop = False
        Me.GbdetalleDocumento.Text = "Detalles del Documento de Facturacion"
        Me.GbdetalleDocumento.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(25, 68)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 11)
        Me.Label41.TabIndex = 175
        Me.Label41.Text = "Comprobante"
        '
        'txtdetalleguiaserie
        '
        Me.txtdetalleguiaserie.BackColor = System.Drawing.Color.White
        Me.txtdetalleguiaserie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalleguiaserie.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalleguiaserie.Location = New System.Drawing.Point(138, 45)
        Me.txtdetalleguiaserie.Name = "txtdetalleguiaserie"
        Me.txtdetalleguiaserie.ReadOnly = True
        Me.txtdetalleguiaserie.Size = New System.Drawing.Size(31, 18)
        Me.txtdetalleguiaserie.TabIndex = 173
        Me.txtdetalleguiaserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdetalleserie
        '
        Me.txtdetalleserie.BackColor = System.Drawing.Color.White
        Me.txtdetalleserie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalleserie.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalleserie.Location = New System.Drawing.Point(138, 21)
        Me.txtdetalleserie.Name = "txtdetalleserie"
        Me.txtdetalleserie.ReadOnly = True
        Me.txtdetalleserie.Size = New System.Drawing.Size(31, 18)
        Me.txtdetalleserie.TabIndex = 168
        Me.txtdetalleserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeroCP
        '
        Me.txtNumeroCP.BackColor = System.Drawing.Color.White
        Me.txtNumeroCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroCP.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCP.Location = New System.Drawing.Point(171, 69)
        Me.txtNumeroCP.Name = "txtNumeroCP"
        Me.txtNumeroCP.ReadOnly = True
        Me.txtNumeroCP.Size = New System.Drawing.Size(138, 18)
        Me.txtNumeroCP.TabIndex = 165
        Me.txtNumeroCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdetalleguianumero
        '
        Me.txtdetalleguianumero.BackColor = System.Drawing.Color.White
        Me.txtdetalleguianumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalleguianumero.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalleguianumero.Location = New System.Drawing.Point(171, 45)
        Me.txtdetalleguianumero.Name = "txtdetalleguianumero"
        Me.txtdetalleguianumero.ReadOnly = True
        Me.txtdetalleguianumero.Size = New System.Drawing.Size(138, 18)
        Me.txtdetalleguianumero.TabIndex = 174
        Me.txtdetalleguianumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerieCP
        '
        Me.txtSerieCP.BackColor = System.Drawing.Color.White
        Me.txtSerieCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerieCP.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieCP.Location = New System.Drawing.Point(138, 69)
        Me.txtSerieCP.Name = "txtSerieCP"
        Me.txtSerieCP.ReadOnly = True
        Me.txtSerieCP.Size = New System.Drawing.Size(31, 18)
        Me.txtSerieCP.TabIndex = 164
        Me.txtSerieCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoCP
        '
        Me.txtcodigoCP.BackColor = System.Drawing.Color.White
        Me.txtcodigoCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoCP.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoCP.Location = New System.Drawing.Point(107, 69)
        Me.txtcodigoCP.Name = "txtcodigoCP"
        Me.txtcodigoCP.ReadOnly = True
        Me.txtcodigoCP.Size = New System.Drawing.Size(30, 18)
        Me.txtcodigoCP.TabIndex = 163
        Me.txtcodigoCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(13, 48)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(90, 11)
        Me.Label40.TabIndex = 171
        Me.Label40.Text = "Guia de Remision"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(40, 79)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(60, 11)
        Me.Label38.TabIndex = 162
        Me.Label38.Text = "Percepcion"
        '
        'txtdetallenumero
        '
        Me.txtdetallenumero.BackColor = System.Drawing.Color.White
        Me.txtdetallenumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetallenumero.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetallenumero.Location = New System.Drawing.Point(171, 21)
        Me.txtdetallenumero.Name = "txtdetallenumero"
        Me.txtdetallenumero.ReadOnly = True
        Me.txtdetallenumero.Size = New System.Drawing.Size(138, 18)
        Me.txtdetallenumero.TabIndex = 169
        Me.txtdetallenumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdetalleguiadoc
        '
        Me.txtdetalleguiadoc.BackColor = System.Drawing.Color.White
        Me.txtdetalleguiadoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalleguiadoc.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalleguiadoc.Location = New System.Drawing.Point(107, 45)
        Me.txtdetalleguiadoc.Name = "txtdetalleguiadoc"
        Me.txtdetalleguiadoc.ReadOnly = True
        Me.txtdetalleguiadoc.Size = New System.Drawing.Size(30, 18)
        Me.txtdetalleguiadoc.TabIndex = 172
        Me.txtdetalleguiadoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(42, 24)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(60, 11)
        Me.Label39.TabIndex = 166
        Me.Label39.Text = "Documento"
        '
        'txtdetalledoc
        '
        Me.txtdetalledoc.BackColor = System.Drawing.Color.White
        Me.txtdetalledoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdetalledoc.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalledoc.Location = New System.Drawing.Point(107, 21)
        Me.txtdetalledoc.Name = "txtdetalledoc"
        Me.txtdetalledoc.ReadOnly = True
        Me.txtdetalledoc.Size = New System.Drawing.Size(30, 18)
        Me.txtdetalledoc.TabIndex = 167
        Me.txtdetalledoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label37.ForeColor = System.Drawing.Color.Navy
        Me.Label37.Location = New System.Drawing.Point(508, 36)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(66, 13)
        Me.Label37.TabIndex = 161
        Me.Label37.Text = "Se. Doc.Ref"
        '
        'txtSerieDocRef
        '
        Me.txtSerieDocRef.BackColor = System.Drawing.Color.White
        Me.txtSerieDocRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerieDocRef.Location = New System.Drawing.Point(576, 32)
        Me.txtSerieDocRef.Name = "txtSerieDocRef"
        Me.txtSerieDocRef.ReadOnly = True
        Me.txtSerieDocRef.Size = New System.Drawing.Size(43, 20)
        Me.txtSerieDocRef.TabIndex = 7
        Me.txtSerieDocRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttipoDocRef
        '
        Me.txttipoDocRef.BackColor = System.Drawing.Color.Aquamarine
        Me.txttipoDocRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipoDocRef.Location = New System.Drawing.Point(451, 32)
        Me.txttipoDocRef.Name = "txttipoDocRef"
        Me.txttipoDocRef.ReadOnly = True
        Me.txttipoDocRef.Size = New System.Drawing.Size(28, 20)
        Me.txttipoDocRef.TabIndex = 6
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(378, 36)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(71, 13)
        Me.Label36.TabIndex = 157
        Me.Label36.Text = "Tipo.Doc.Ref"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(111, 99)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox9.TabIndex = 155
        Me.PictureBox9.TabStop = False
        '
        'checkSinGuia
        '
        Me.checkSinGuia.AutoSize = True
        Me.checkSinGuia.Checked = True
        Me.checkSinGuia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkSinGuia.ForeColor = System.Drawing.Color.Navy
        Me.checkSinGuia.Location = New System.Drawing.Point(9, 188)
        Me.checkSinGuia.Name = "checkSinGuia"
        Me.checkSinGuia.Size = New System.Drawing.Size(127, 17)
        Me.checkSinGuia.TabIndex = 154
        Me.checkSinGuia.Text = "Sin Guia de Remision"
        Me.checkSinGuia.UseVisualStyleBackColor = True
        '
        'lblAlmacen
        '
        Me.lblAlmacen.BackColor = System.Drawing.Color.White
        Me.lblAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlmacen.Location = New System.Drawing.Point(414, 10)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.ReadOnly = True
        Me.lblAlmacen.Size = New System.Drawing.Size(205, 20)
        Me.lblAlmacen.TabIndex = 22
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlmacen.Location = New System.Drawing.Point(381, 10)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(30, 20)
        Me.txtAlmacen.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(331, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = "Almacén"
        '
        'cboDirEntrega
        '
        Me.cboDirEntrega.FormattingEnabled = True
        Me.cboDirEntrega.Location = New System.Drawing.Point(103, 209)
        Me.cboDirEntrega.Name = "cboDirEntrega"
        Me.cboDirEntrega.Size = New System.Drawing.Size(597, 21)
        Me.cboDirEntrega.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(7, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Dirección entrega"
        '
        'txtordenCompra
        '
        Me.txtordenCompra.BackColor = System.Drawing.Color.White
        Me.txtordenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtordenCompra.Location = New System.Drawing.Point(67, 120)
        Me.txtordenCompra.Name = "txtordenCompra"
        Me.txtordenCompra.ReadOnly = True
        Me.txtordenCompra.Size = New System.Drawing.Size(77, 20)
        Me.txtordenCompra.TabIndex = 13
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(19, 124)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(43, 13)
        Me.Label35.TabIndex = 149
        Me.Label35.Text = "N° O.C."
        '
        'txtcotizacion
        '
        Me.txtcotizacion.BackColor = System.Drawing.Color.White
        Me.txtcotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcotizacion.Location = New System.Drawing.Point(67, 136)
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
        Me.Label34.Location = New System.Drawing.Point(6, 137)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 13)
        Me.Label34.TabIndex = 147
        Me.Label34.Text = "Cotización"
        Me.Label34.Visible = False
        '
        'txtNumDocRef
        '
        Me.txtNumDocRef.BackColor = System.Drawing.Color.White
        Me.txtNumDocRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumDocRef.Location = New System.Drawing.Point(686, 32)
        Me.txtNumDocRef.Name = "txtNumDocRef"
        Me.txtNumDocRef.ReadOnly = True
        Me.txtNumDocRef.Size = New System.Drawing.Size(107, 20)
        Me.txtNumDocRef.TabIndex = 8
        '
        'chkSinIGV
        '
        Me.chkSinIGV.AutoSize = True
        Me.chkSinIGV.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkSinIGV.Location = New System.Drawing.Point(868, 209)
        Me.chkSinIGV.Name = "chkSinIGV"
        Me.chkSinIGV.Size = New System.Drawing.Size(104, 21)
        Me.chkSinIGV.TabIndex = 84
        Me.chkSinIGV.Text = "&Precio sin Igv."
        Me.chkSinIGV.UseVisualStyleBackColor = True
        Me.chkSinIGV.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(621, 36)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 13)
        Me.Label33.TabIndex = 145
        Me.Label33.Text = "N° Doc.Ref"
        '
        'txtpedido
        '
        Me.txtpedido.BackColor = System.Drawing.Color.White
        Me.txtpedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpedido.Location = New System.Drawing.Point(264, 120)
        Me.txtpedido.Name = "txtpedido"
        Me.txtpedido.Size = New System.Drawing.Size(101, 20)
        Me.txtpedido.TabIndex = 14
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(182, 124)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 13)
        Me.Label32.TabIndex = 143
        Me.Label32.Text = "Numero Pedido"
        '
        'txtdescripcionTrama
        '
        Me.txtdescripcionTrama.BackColor = System.Drawing.Color.White
        Me.txtdescripcionTrama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionTrama.Location = New System.Drawing.Point(1014, 178)
        Me.txtdescripcionTrama.Name = "txtdescripcionTrama"
        Me.txtdescripcionTrama.ReadOnly = True
        Me.txtdescripcionTrama.Size = New System.Drawing.Size(47, 20)
        Me.txtdescripcionTrama.TabIndex = 142
        Me.txtdescripcionTrama.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(996, 179)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox8.TabIndex = 141
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'txtcodigoTrama
        '
        Me.txtcodigoTrama.Location = New System.Drawing.Point(956, 178)
        Me.txtcodigoTrama.Name = "txtcodigoTrama"
        Me.txtcodigoTrama.Size = New System.Drawing.Size(37, 20)
        Me.txtcodigoTrama.TabIndex = 139
        Me.txtcodigoTrama.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(914, 181)
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
        Me.txtcodigoTransporte.Location = New System.Drawing.Point(1200, 256)
        Me.txtcodigoTransporte.Name = "txtcodigoTransporte"
        Me.txtcodigoTransporte.Size = New System.Drawing.Size(44, 20)
        Me.txtcodigoTransporte.TabIndex = 135
        Me.txtcodigoTransporte.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1201, 237)
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
        Me.txtdescVehiculo.Location = New System.Drawing.Point(1014, 153)
        Me.txtdescVehiculo.Name = "txtdescVehiculo"
        Me.txtdescVehiculo.ReadOnly = True
        Me.txtdescVehiculo.Size = New System.Drawing.Size(45, 20)
        Me.txtdescVehiculo.TabIndex = 134
        Me.txtdescVehiculo.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(996, 154)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox5.TabIndex = 133
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'txtcodigoVehiculo
        '
        Me.txtcodigoVehiculo.Location = New System.Drawing.Point(956, 153)
        Me.txtcodigoVehiculo.Name = "txtcodigoVehiculo"
        Me.txtcodigoVehiculo.Size = New System.Drawing.Size(37, 20)
        Me.txtcodigoVehiculo.TabIndex = 131
        Me.txtcodigoVehiculo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(901, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Vehiculo "
        Me.Label2.Visible = False
        '
        'txtdescEsp
        '
        Me.txtdescEsp.BackColor = System.Drawing.Color.White
        Me.txtdescEsp.Location = New System.Drawing.Point(1115, 256)
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
        Me.Label30.Location = New System.Drawing.Point(1094, 241)
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
        Me.lblVendedor.Location = New System.Drawing.Point(128, 98)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.ReadOnly = True
        Me.lblVendedor.Size = New System.Drawing.Size(247, 20)
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
        Me.lblFormaPago.Location = New System.Drawing.Point(518, 98)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.ReadOnly = True
        Me.lblFormaPago.Size = New System.Drawing.Size(275, 20)
        Me.lblFormaPago.TabIndex = 30
        '
        'txtNomTrans
        '
        Me.txtNomTrans.BackColor = System.Drawing.Color.White
        Me.txtNomTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomTrans.Enabled = False
        Me.txtNomTrans.Location = New System.Drawing.Point(391, 186)
        Me.txtNomTrans.Name = "txtNomTrans"
        Me.txtNomTrans.Size = New System.Drawing.Size(402, 20)
        Me.txtNomTrans.TabIndex = 31
        Me.txtNomTrans.Text = "."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label29.Location = New System.Drawing.Point(1147, 204)
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
        Me.Label18.Location = New System.Drawing.Point(271, 190)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Transportista"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(500, 99)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        '
        'lblPtoVenta
        '
        Me.lblPtoVenta.BackColor = System.Drawing.Color.White
        Me.lblPtoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPtoVenta.Location = New System.Drawing.Point(125, 10)
        Me.lblPtoVenta.Name = "lblPtoVenta"
        Me.lblPtoVenta.ReadOnly = True
        Me.lblPtoVenta.Size = New System.Drawing.Size(202, 20)
        Me.lblPtoVenta.TabIndex = 20
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(103, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 111
        Me.PictureBox4.TabStop = False
        '
        'cbSerieGuia
        '
        Me.cbSerieGuia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSerieGuia.FormattingEnabled = True
        Me.cbSerieGuia.Location = New System.Drawing.Point(208, 186)
        Me.cbSerieGuia.Name = "cbSerieGuia"
        Me.cbSerieGuia.Size = New System.Drawing.Size(60, 21)
        Me.cbSerieGuia.TabIndex = 15
        '
        'cboSerieDoc
        '
        Me.cboSerieDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSerieDoc.FormattingEnabled = True
        Me.cboSerieDoc.Location = New System.Drawing.Point(317, 32)
        Me.cboSerieDoc.Name = "cboSerieDoc"
        Me.cboSerieDoc.Size = New System.Drawing.Size(50, 21)
        Me.cboSerieDoc.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(283, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Serie"
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(67, 32)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaFactura.TabIndex = 2
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Location = New System.Drawing.Point(233, 32)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(45, 21)
        Me.cboTipoDoc.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(170, 36)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Documento"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(669, 10)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(151, 21)
        Me.cboMoneda.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(136, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Serie de Guia"
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormaPago.Location = New System.Drawing.Point(461, 98)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.Size = New System.Drawing.Size(37, 20)
        Me.txtFormaPago.TabIndex = 11
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Location = New System.Drawing.Point(907, 10)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(79, 20)
        Me.txtTipoCambio.TabIndex = 24
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVendedor
        '
        Me.txtVendedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendedor.Location = New System.Drawing.Point(67, 98)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(42, 20)
        Me.txtVendedor.TabIndex = 10
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(67, 77)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(726, 20)
        Me.txtDireccion.TabIndex = 28
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.White
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Location = New System.Drawing.Point(379, 55)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(414, 20)
        Me.txtRazonSocial.TabIndex = 27
        '
        'txtRucDni
        '
        Me.txtRucDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRucDni.Location = New System.Drawing.Point(226, 55)
        Me.txtRucDni.Name = "txtRucDni"
        Me.txtRucDni.Size = New System.Drawing.Size(78, 20)
        Me.txtRucDni.TabIndex = 26
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Location = New System.Drawing.Point(67, 55)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCliente.TabIndex = 9
        '
        'txtPtoVenta
        '
        Me.txtPtoVenta.BackColor = System.Drawing.Color.Aquamarine
        Me.txtPtoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPtoVenta.Location = New System.Drawing.Point(67, 10)
        Me.txtPtoVenta.Name = "txtPtoVenta"
        Me.txtPtoVenta.Size = New System.Drawing.Size(31, 20)
        Me.txtPtoVenta.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(381, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Forma de pago"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(824, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Tipo de cambio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(624, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Moneda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(9, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Vendedor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(10, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(308, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Razón social "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(172, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Ruc/Dni"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(23, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(25, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(5, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Pto. Venta"
        '
        'txtCodTrans
        '
        Me.txtCodTrans.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCodTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTrans.Location = New System.Drawing.Point(341, 186)
        Me.txtCodTrans.Name = "txtCodTrans"
        Me.txtCodTrans.Size = New System.Drawing.Size(25, 20)
        Me.txtCodTrans.TabIndex = 16
        Me.txtCodTrans.Text = "00"
        '
        'pnlDocumentosGuiaVenta
        '
        Me.pnlDocumentosGuiaVenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlDocumentosGuiaVenta.Controls.Add(Me.lblDetalle)
        Me.pnlDocumentosGuiaVenta.Controls.Add(Me.GroupBox5)
        Me.pnlDocumentosGuiaVenta.Location = New System.Drawing.Point(31, 107)
        Me.pnlDocumentosGuiaVenta.Name = "pnlDocumentosGuiaVenta"
        Me.pnlDocumentosGuiaVenta.Size = New System.Drawing.Size(582, 325)
        Me.pnlDocumentosGuiaVenta.TabIndex = 165
        Me.pnlDocumentosGuiaVenta.Visible = False
        '
        'lblDetalle
        '
        Me.lblDetalle.BackColor = System.Drawing.Color.Navy
        Me.lblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalle.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalle.ForeColor = System.Drawing.Color.White
        Me.lblDetalle.Location = New System.Drawing.Point(1, 1)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(584, 20)
        Me.lblDetalle.TabIndex = 169
        Me.lblDetalle.Text = "GUIAS DE VENTA"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.btn_close)
        Me.GroupBox5.Controls.Add(Me.btn_ok)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.dgvDocumentosCliente)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(552, 296)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(490, 30)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(49, 32)
        Me.btn_close.TabIndex = 121
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.Location = New System.Drawing.Point(440, 30)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(49, 32)
        Me.btn_ok.TabIndex = 122
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtFiltroCliente)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(421, 45)
        Me.GroupBox6.TabIndex = 120
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ingrese Nro Documento  a Buscar :"
        '
        'txtFiltroCliente
        '
        Me.txtFiltroCliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroCliente.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroCliente.Location = New System.Drawing.Point(9, 16)
        Me.txtFiltroCliente.Name = "txtFiltroCliente"
        Me.txtFiltroCliente.Size = New System.Drawing.Size(404, 22)
        Me.txtFiltroCliente.TabIndex = 24
        '
        'dgvDocumentosCliente
        '
        Me.dgvDocumentosCliente.AllowUserToAddRows = False
        Me.dgvDocumentosCliente.AllowUserToDeleteRows = False
        Me.dgvDocumentosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentosCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvDocumentosCliente.Location = New System.Drawing.Point(12, 71)
        Me.dgvDocumentosCliente.Name = "dgvDocumentosCliente"
        Me.dgvDocumentosCliente.Size = New System.Drawing.Size(528, 208)
        Me.dgvDocumentosCliente.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Seleccionar"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rbVariaslineasDoc)
        Me.GroupBox8.Controls.Add(Me.rbunalineaDoc)
        Me.GroupBox8.Controls.Add(Me.txtGlosa)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(8, 323)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(792, 37)
        Me.GroupBox8.TabIndex = 172
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Tipo de la Glosa del Documento"
        '
        'rbVariaslineasDoc
        '
        Me.rbVariaslineasDoc.AutoSize = True
        Me.rbVariaslineasDoc.ForeColor = System.Drawing.Color.Navy
        Me.rbVariaslineasDoc.Location = New System.Drawing.Point(104, 15)
        Me.rbVariaslineasDoc.Name = "rbVariaslineasDoc"
        Me.rbVariaslineasDoc.Size = New System.Drawing.Size(84, 17)
        Me.rbVariaslineasDoc.TabIndex = 1
        Me.rbVariaslineasDoc.Text = "Varias lineas"
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
        Me.rbunalineaDoc.Text = "Una sola linea"
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
        Me.txtGlosa.Size = New System.Drawing.Size(567, 23)
        Me.txtGlosa.TabIndex = 18
        Me.txtGlosa.Text = ""
        '
        'gbTipoGuia
        '
        Me.gbTipoGuia.Controls.Add(Me.rbVariaslineas)
        Me.gbTipoGuia.Controls.Add(Me.rbunalinea)
        Me.gbTipoGuia.Controls.Add(Me.txtGlosaGuia)
        Me.gbTipoGuia.ForeColor = System.Drawing.Color.Navy
        Me.gbTipoGuia.Location = New System.Drawing.Point(8, 362)
        Me.gbTipoGuia.Name = "gbTipoGuia"
        Me.gbTipoGuia.Size = New System.Drawing.Size(792, 37)
        Me.gbTipoGuia.TabIndex = 171
        Me.gbTipoGuia.TabStop = False
        Me.gbTipoGuia.Text = "Tipo de la Glosa de la Guia"
        '
        'rbVariaslineas
        '
        Me.rbVariaslineas.AutoSize = True
        Me.rbVariaslineas.ForeColor = System.Drawing.Color.Navy
        Me.rbVariaslineas.Location = New System.Drawing.Point(104, 13)
        Me.rbVariaslineas.Name = "rbVariaslineas"
        Me.rbVariaslineas.Size = New System.Drawing.Size(84, 17)
        Me.rbVariaslineas.TabIndex = 1
        Me.rbVariaslineas.Text = "Varias lineas"
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
        Me.rbunalinea.Text = "Una sola linea"
        Me.rbunalinea.UseVisualStyleBackColor = True
        '
        'txtGlosaGuia
        '
        Me.txtGlosaGuia.BackColor = System.Drawing.Color.White
        Me.txtGlosaGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGlosaGuia.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtGlosaGuia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGlosaGuia.Location = New System.Drawing.Point(192, 9)
        Me.txtGlosaGuia.MaxLength = 5000
        Me.txtGlosaGuia.Name = "txtGlosaGuia"
        Me.txtGlosaGuia.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtGlosaGuia.Size = New System.Drawing.Size(567, 23)
        Me.txtGlosaGuia.TabIndex = 19
        Me.txtGlosaGuia.Text = " "
        '
        'dgvDocumentosFactura
        '
        Me.dgvDocumentosFactura.AllowUserToAddRows = False
        Me.dgvDocumentosFactura.AllowUserToDeleteRows = False
        Me.dgvDocumentosFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentosFactura.Location = New System.Drawing.Point(10, 76)
        Me.dgvDocumentosFactura.Name = "dgvDocumentosFactura"
        Me.dgvDocumentosFactura.ReadOnly = True
        Me.dgvDocumentosFactura.Size = New System.Drawing.Size(1128, 491)
        Me.dgvDocumentosFactura.TabIndex = 117
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(11, 573)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(10, 13)
        Me.lblCantidad.TabIndex = 118
        Me.lblCantidad.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(8, 20)
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
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(664, 20)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(480, 20)
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
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas", "Busqueda Rapida", "Por Serie"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(170, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(662, 547)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 11)
        Me.Label15.TabIndex = 126
        Me.Label15.Text = "Redondeo"
        '
        'txtredondeo
        '
        Me.txtredondeo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtredondeo.BackColor = System.Drawing.Color.White
        Me.txtredondeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtredondeo.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtredondeo.Location = New System.Drawing.Point(719, 544)
        Me.txtredondeo.Name = "txtredondeo"
        Me.txtredondeo.ReadOnly = True
        Me.txtredondeo.Size = New System.Drawing.Size(89, 18)
        Me.txtredondeo.TabIndex = 127
        Me.txtredondeo.Text = "0.00"
        Me.txtredondeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBruto
        '
        Me.txtBruto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBruto.BackColor = System.Drawing.Color.White
        Me.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBruto.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBruto.Location = New System.Drawing.Point(852, 544)
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.ReadOnly = True
        Me.txtBruto.Size = New System.Drawing.Size(89, 18)
        Me.txtBruto.TabIndex = 129
        Me.txtBruto.Text = "0.00"
        Me.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(817, 547)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 11)
        Me.Label16.TabIndex = 128
        Me.Label16.Text = "Bruto"
        '
        'txtvalorVenta
        '
        Me.txtvalorVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvalorVenta.BackColor = System.Drawing.Color.White
        Me.txtvalorVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorVenta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalorVenta.Location = New System.Drawing.Point(1026, 544)
        Me.txtvalorVenta.Name = "txtvalorVenta"
        Me.txtvalorVenta.Size = New System.Drawing.Size(89, 18)
        Me.txtvalorVenta.TabIndex = 131
        Me.txtvalorVenta.Text = "0.00"
        Me.txtvalorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(958, 550)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 11)
        Me.Label22.TabIndex = 130
        Me.Label22.Text = "Valor Venta"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentos.BackColor = System.Drawing.Color.White
        Me.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuentos.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentos.Location = New System.Drawing.Point(1026, 567)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(89, 18)
        Me.txtDescuentos.TabIndex = 133
        Me.txtDescuentos.Text = "0.00"
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(965, 571)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 11)
        Me.Label23.TabIndex = 132
        Me.Label23.Text = "Descuento"
        '
        'txtIgv
        '
        Me.txtIgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIgv.BackColor = System.Drawing.Color.White
        Me.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIgv.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgv.Location = New System.Drawing.Point(1026, 589)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(89, 18)
        Me.txtIgv.TabIndex = 135
        Me.txtIgv.Text = "0.00"
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(991, 592)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 11)
        Me.Label24.TabIndex = 134
        Me.Label24.Text = "I.G.V"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.White
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.Location = New System.Drawing.Point(1026, 612)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(89, 18)
        Me.txtPrecioVenta.TabIndex = 137
        Me.txtPrecioVenta.Text = "0.00"
        Me.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(955, 615)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 11)
        Me.Label28.TabIndex = 136
        Me.Label28.Text = "Precio Venta"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboOpcionTipoDoc)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(337, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(138, 45)
        Me.GroupBox4.TabIndex = 122
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Documento"
        '
        'cboOpcionTipoDoc
        '
        Me.cboOpcionTipoDoc.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpcionTipoDoc.FormattingEnabled = True
        Me.cboOpcionTipoDoc.Items.AddRange(New Object() {"Todos", "BV", "CP", "FT", "NC", "ND", "PF"})
        Me.cboOpcionTipoDoc.Location = New System.Drawing.Point(6, 15)
        Me.cboOpcionTipoDoc.Name = "cboOpcionTipoDoc"
        Me.cboOpcionTipoDoc.Size = New System.Drawing.Size(125, 25)
        Me.cboOpcionTipoDoc.TabIndex = 5
        '
        'btnSalirNumeracion
        '
        Me.btnSalirNumeracion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSalirNumeracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirNumeracion.Image = CType(resources.GetObject("btnSalirNumeracion.Image"), System.Drawing.Image)
        Me.btnSalirNumeracion.Location = New System.Drawing.Point(185, 17)
        Me.btnSalirNumeracion.Name = "btnSalirNumeracion"
        Me.btnSalirNumeracion.Size = New System.Drawing.Size(30, 28)
        Me.btnSalirNumeracion.TabIndex = 163
        Me.btnSalirNumeracion.UseVisualStyleBackColor = True
        '
        'btnAceptarBusquedaOC
        '
        Me.btnAceptarBusquedaOC.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAceptarBusquedaOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarBusquedaOC.Image = CType(resources.GetObject("btnAceptarBusquedaOC.Image"), System.Drawing.Image)
        Me.btnAceptarBusquedaOC.Location = New System.Drawing.Point(150, 17)
        Me.btnAceptarBusquedaOC.Name = "btnAceptarBusquedaOC"
        Me.btnAceptarBusquedaOC.Size = New System.Drawing.Size(30, 28)
        Me.btnAceptarBusquedaOC.TabIndex = 164
        Me.btnAceptarBusquedaOC.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.RadioButton3.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton3.Location = New System.Drawing.Point(161, 54)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton3.TabIndex = 163
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "&Otros"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.RadioButton2.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton2.Location = New System.Drawing.Point(82, 54)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "OC Ext"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.RadioButton1.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton1.Location = New System.Drawing.Point(5, 54)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "&Refact"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtBuscarOrdenCompra
        '
        Me.txtBuscarOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscarOrdenCompra.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarOrdenCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBuscarOrdenCompra.Location = New System.Drawing.Point(5, 20)
        Me.txtBuscarOrdenCompra.MaxLength = 20
        Me.txtBuscarOrdenCompra.Name = "txtBuscarOrdenCompra"
        Me.txtBuscarOrdenCompra.Size = New System.Drawing.Size(138, 22)
        Me.txtBuscarOrdenCompra.TabIndex = 0
        Me.txtBuscarOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlBuscarordenCompra
        '
        Me.PnlBuscarordenCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PnlBuscarordenCompra.Controls.Add(Me.TextBox1)
        Me.PnlBuscarordenCompra.Controls.Add(Me.GroupBox1)
        Me.PnlBuscarordenCompra.Location = New System.Drawing.Point(65, 158)
        Me.PnlBuscarordenCompra.Name = "PnlBuscarordenCompra"
        Me.PnlBuscarordenCompra.Size = New System.Drawing.Size(249, 112)
        Me.PnlBuscarordenCompra.TabIndex = 163
        Me.PnlBuscarordenCompra.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(2, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 16)
        Me.TextBox1.TabIndex = 166
        Me.TextBox1.Text = "N° Orden de Compra"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.btnSalirNumeracion)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.btnAceptarBusquedaOC)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.txtBuscarOrdenCompra)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(13, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 79)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        '
        'gbTipoFacturacion
        '
        Me.gbTipoFacturacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTipoFacturacion.BackColor = System.Drawing.Color.White
        Me.gbTipoFacturacion.Controls.Add(Me.rb_facturar_obsequio_sin_pedido)
        Me.gbTipoFacturacion.Controls.Add(Me.rbfacturaExportacion)
        Me.gbTipoFacturacion.Controls.Add(Me.rb_facturar_obsequio)
        Me.gbTipoFacturacion.Controls.Add(Me.rb_facturar_devolucion)
        Me.gbTipoFacturacion.Controls.Add(Me.rb_facturar_pedido)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaRepMedico)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaExistencias)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaGuiaVenta)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaDirecta)
        Me.gbTipoFacturacion.Controls.Add(Me.rbsinDescargo)
        Me.gbTipoFacturacion.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbTipoFacturacion.ForeColor = System.Drawing.Color.Navy
        Me.gbTipoFacturacion.Location = New System.Drawing.Point(8, 23)
        Me.gbTipoFacturacion.Name = "gbTipoFacturacion"
        Me.gbTipoFacturacion.Size = New System.Drawing.Size(1139, 37)
        Me.gbTipoFacturacion.TabIndex = 164
        Me.gbTipoFacturacion.TabStop = False
        '
        'rb_facturar_obsequio_sin_pedido
        '
        Me.rb_facturar_obsequio_sin_pedido.AutoSize = True
        Me.rb_facturar_obsequio_sin_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rb_facturar_obsequio_sin_pedido.Location = New System.Drawing.Point(652, 16)
        Me.rb_facturar_obsequio_sin_pedido.Name = "rb_facturar_obsequio_sin_pedido"
        Me.rb_facturar_obsequio_sin_pedido.Size = New System.Drawing.Size(163, 17)
        Me.rb_facturar_obsequio_sin_pedido.TabIndex = 178
        Me.rb_facturar_obsequio_sin_pedido.Text = "Facturar Obsequio sin pedido"
        Me.rb_facturar_obsequio_sin_pedido.UseVisualStyleBackColor = True
        '
        'rbfacturaExportacion
        '
        Me.rbfacturaExportacion.AutoSize = True
        Me.rbfacturaExportacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbfacturaExportacion.Location = New System.Drawing.Point(411, 16)
        Me.rbfacturaExportacion.Name = "rbfacturaExportacion"
        Me.rbfacturaExportacion.Size = New System.Drawing.Size(120, 17)
        Me.rbfacturaExportacion.TabIndex = 177
        Me.rbfacturaExportacion.Text = "Factura Exportación"
        Me.rbfacturaExportacion.UseVisualStyleBackColor = True
        '
        'rb_facturar_obsequio
        '
        Me.rb_facturar_obsequio.AutoSize = True
        Me.rb_facturar_obsequio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rb_facturar_obsequio.Location = New System.Drawing.Point(240, 16)
        Me.rb_facturar_obsequio.Name = "rb_facturar_obsequio"
        Me.rb_facturar_obsequio.Size = New System.Drawing.Size(168, 17)
        Me.rb_facturar_obsequio.TabIndex = 176
        Me.rb_facturar_obsequio.Text = "Facturar Obsequio con pedido"
        Me.rb_facturar_obsequio.UseVisualStyleBackColor = True
        '
        'rb_facturar_devolucion
        '
        Me.rb_facturar_devolucion.AutoSize = True
        Me.rb_facturar_devolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rb_facturar_devolucion.Location = New System.Drawing.Point(789, 39)
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
        Me.rb_facturar_pedido.Location = New System.Drawing.Point(543, 16)
        Me.rb_facturar_pedido.Name = "rb_facturar_pedido"
        Me.rb_facturar_pedido.Size = New System.Drawing.Size(99, 17)
        Me.rb_facturar_pedido.TabIndex = 174
        Me.rb_facturar_pedido.Text = "Facturar pedido"
        Me.rb_facturar_pedido.UseVisualStyleBackColor = True
        '
        'rbFacturaRepMedico
        '
        Me.rbFacturaRepMedico.AutoSize = True
        Me.rbFacturaRepMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaRepMedico.Location = New System.Drawing.Point(235, 39)
        Me.rbFacturaRepMedico.Name = "rbFacturaRepMedico"
        Me.rbFacturaRepMedico.Size = New System.Drawing.Size(135, 17)
        Me.rbFacturaRepMedico.TabIndex = 172
        Me.rbFacturaRepMedico.Text = "G. x Fac. (Rep.Medico)"
        Me.rbFacturaRepMedico.UseVisualStyleBackColor = True
        '
        'rbFacturaExistencias
        '
        Me.rbFacturaExistencias.AutoSize = True
        Me.rbFacturaExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaExistencias.Location = New System.Drawing.Point(378, 37)
        Me.rbFacturaExistencias.Name = "rbFacturaExistencias"
        Me.rbFacturaExistencias.Size = New System.Drawing.Size(169, 17)
        Me.rbFacturaExistencias.TabIndex = 170
        Me.rbFacturaExistencias.Text = "Exis. x Ent.-Fact. sin Descargo"
        Me.rbFacturaExistencias.UseVisualStyleBackColor = True
        '
        'rbFacturaGuiaVenta
        '
        Me.rbFacturaGuiaVenta.AutoSize = True
        Me.rbFacturaGuiaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaGuiaVenta.Location = New System.Drawing.Point(124, 16)
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
        Me.rbFacturaDirecta.Location = New System.Drawing.Point(5, 16)
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
        Me.rbsinDescargo.Location = New System.Drawing.Point(563, 38)
        Me.rbsinDescargo.Name = "rbsinDescargo"
        Me.rbsinDescargo.Size = New System.Drawing.Size(90, 17)
        Me.rbsinDescargo.TabIndex = 171
        Me.rbsinDescargo.Text = "Fact. sin Des."
        Me.rbsinDescargo.UseVisualStyleBackColor = True
        '
        'pnlConfirmarDespacho
        '
        Me.pnlConfirmarDespacho.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlConfirmarDespacho.Controls.Add(Me.Label58)
        Me.pnlConfirmarDespacho.Controls.Add(Me.txt_emp_trans_manual)
        Me.pnlConfirmarDespacho.Controls.Add(Me.RadioButton6)
        Me.pnlConfirmarDespacho.Controls.Add(Me.RadioButton7)
        Me.pnlConfirmarDespacho.Controls.Add(Me.Label57)
        Me.pnlConfirmarDespacho.Controls.Add(Me.txt_trans_manual_despacho)
        Me.pnlConfirmarDespacho.Controls.Add(Me.PictureBox13)
        Me.pnlConfirmarDespacho.Controls.Add(Me.txt_cod_transportista)
        Me.pnlConfirmarDespacho.Controls.Add(Me.Label53)
        Me.pnlConfirmarDespacho.Controls.Add(Me.txt_des_transportista_despacho)
        Me.pnlConfirmarDespacho.Controls.Add(Me.PictureBox14)
        Me.pnlConfirmarDespacho.Controls.Add(Me.txt_cod_emp_trans)
        Me.pnlConfirmarDespacho.Controls.Add(Me.Label56)
        Me.pnlConfirmarDespacho.Controls.Add(Me.txt_des_emp_trans)
        Me.pnlConfirmarDespacho.Controls.Add(Me.Label54)
        Me.pnlConfirmarDespacho.Controls.Add(Me.txt_obs_despachos)
        Me.pnlConfirmarDespacho.Controls.Add(Me.TextBox3)
        Me.pnlConfirmarDespacho.Controls.Add(Me.GroupBox7)
        Me.pnlConfirmarDespacho.Controls.Add(Me.GroupBox15)
        Me.pnlConfirmarDespacho.Controls.Add(Me.GroupBox16)
        Me.pnlConfirmarDespacho.Controls.Add(Me.GroupBox17)
        Me.pnlConfirmarDespacho.Location = New System.Drawing.Point(301, 60)
        Me.pnlConfirmarDespacho.Name = "pnlConfirmarDespacho"
        Me.pnlConfirmarDespacho.Size = New System.Drawing.Size(442, 527)
        Me.pnlConfirmarDespacho.TabIndex = 167
        Me.pnlConfirmarDespacho.Visible = False
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Navy
        Me.Label58.Location = New System.Drawing.Point(16, 156)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(183, 13)
        Me.Label58.TabIndex = 198
        Me.Label58.Text = "Empresa de Transporte Manual"
        '
        'txt_emp_trans_manual
        '
        Me.txt_emp_trans_manual.BackColor = System.Drawing.Color.White
        Me.txt_emp_trans_manual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_emp_trans_manual.Location = New System.Drawing.Point(18, 172)
        Me.txt_emp_trans_manual.MaxLength = 200
        Me.txt_emp_trans_manual.Name = "txt_emp_trans_manual"
        Me.txt_emp_trans_manual.Size = New System.Drawing.Size(408, 20)
        Me.txt_emp_trans_manual.TabIndex = 197
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton6.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton6.Location = New System.Drawing.Point(226, 96)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton6.TabIndex = 196
        Me.RadioButton6.Text = "Electivo"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton7.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton7.Location = New System.Drawing.Point(85, 96)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton7.TabIndex = 195
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Manual"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Navy
        Me.Label57.Location = New System.Drawing.Point(16, 292)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(128, 13)
        Me.Label57.TabIndex = 194
        Me.Label57.Text = "Transportista Manual"
        '
        'txt_trans_manual_despacho
        '
        Me.txt_trans_manual_despacho.BackColor = System.Drawing.Color.White
        Me.txt_trans_manual_despacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_manual_despacho.Location = New System.Drawing.Point(16, 308)
        Me.txt_trans_manual_despacho.MaxLength = 200
        Me.txt_trans_manual_despacho.Name = "txt_trans_manual_despacho"
        Me.txt_trans_manual_despacho.Size = New System.Drawing.Size(410, 20)
        Me.txt_trans_manual_despacho.TabIndex = 193
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(107, 269)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox13.TabIndex = 190
        Me.PictureBox13.TabStop = False
        '
        'txt_cod_transportista
        '
        Me.txt_cod_transportista.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_transportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_transportista.Location = New System.Drawing.Point(16, 269)
        Me.txt_cod_transportista.MaxLength = 50
        Me.txt_cod_transportista.Name = "txt_cod_transportista"
        Me.txt_cod_transportista.ReadOnly = True
        Me.txt_cod_transportista.Size = New System.Drawing.Size(84, 20)
        Me.txt_cod_transportista.TabIndex = 189
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(16, 252)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(129, 13)
        Me.Label53.TabIndex = 188
        Me.Label53.Text = "Transportista a elegir"
        '
        'txt_des_transportista_despacho
        '
        Me.txt_des_transportista_despacho.BackColor = System.Drawing.Color.White
        Me.txt_des_transportista_despacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_transportista_despacho.Location = New System.Drawing.Point(129, 269)
        Me.txt_des_transportista_despacho.MaxLength = 200
        Me.txt_des_transportista_despacho.Name = "txt_des_transportista_despacho"
        Me.txt_des_transportista_despacho.ReadOnly = True
        Me.txt_des_transportista_despacho.Size = New System.Drawing.Size(297, 20)
        Me.txt_des_transportista_despacho.TabIndex = 187
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(107, 133)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox14.TabIndex = 186
        Me.PictureBox14.TabStop = False
        '
        'txt_cod_emp_trans
        '
        Me.txt_cod_emp_trans.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_emp_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_emp_trans.Location = New System.Drawing.Point(17, 133)
        Me.txt_cod_emp_trans.MaxLength = 50
        Me.txt_cod_emp_trans.Name = "txt_cod_emp_trans"
        Me.txt_cod_emp_trans.ReadOnly = True
        Me.txt_cod_emp_trans.Size = New System.Drawing.Size(84, 20)
        Me.txt_cod_emp_trans.TabIndex = 185
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Navy
        Me.Label56.Location = New System.Drawing.Point(16, 116)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(203, 13)
        Me.Label56.TabIndex = 184
        Me.Label56.Text = "Empresa de Transporte para elegir"
        '
        'txt_des_emp_trans
        '
        Me.txt_des_emp_trans.BackColor = System.Drawing.Color.White
        Me.txt_des_emp_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_emp_trans.Location = New System.Drawing.Point(129, 133)
        Me.txt_des_emp_trans.MaxLength = 200
        Me.txt_des_emp_trans.Name = "txt_des_emp_trans"
        Me.txt_des_emp_trans.ReadOnly = True
        Me.txt_des_emp_trans.Size = New System.Drawing.Size(297, 20)
        Me.txt_des_emp_trans.TabIndex = 183
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(16, 483)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(90, 13)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Observaciones"
        '
        'txt_obs_despachos
        '
        Me.txt_obs_despachos.BackColor = System.Drawing.Color.White
        Me.txt_obs_despachos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs_despachos.Location = New System.Drawing.Point(16, 499)
        Me.txt_obs_despachos.MaxLength = 200
        Me.txt_obs_despachos.Name = "txt_obs_despachos"
        Me.txt_obs_despachos.Size = New System.Drawing.Size(410, 20)
        Me.txt_obs_despachos.TabIndex = 171
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Navy
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(1, 1)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(440, 20)
        Me.TextBox3.TabIndex = 168
        Me.TextBox3.Text = "CONFIRMACION DE DESPACHO"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dtpDespacho)
        Me.GroupBox7.Controls.Add(Me.Label45)
        Me.GroupBox7.Controls.Add(Me.lblDespachoNumero)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Controls.Add(Me.btn_SalirDesp)
        Me.GroupBox7.Controls.Add(Me.btn_AceptarDesp)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 18)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(424, 52)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'dtpDespacho
        '
        Me.dtpDespacho.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDespacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDespacho.Location = New System.Drawing.Point(119, 26)
        Me.dtpDespacho.Name = "dtpDespacho"
        Me.dtpDespacho.Size = New System.Drawing.Size(119, 21)
        Me.dtpDespacho.TabIndex = 126
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(7, 31)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(108, 13)
        Me.Label45.TabIndex = 125
        Me.Label45.Text = "&Fecha Documento"
        '
        'lblDespachoNumero
        '
        Me.lblDespachoNumero.AutoSize = True
        Me.lblDespachoNumero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDespachoNumero.ForeColor = System.Drawing.Color.Maroon
        Me.lblDespachoNumero.Location = New System.Drawing.Point(113, 12)
        Me.lblDespachoNumero.Name = "lblDespachoNumero"
        Me.lblDespachoNumero.Size = New System.Drawing.Size(16, 13)
        Me.lblDespachoNumero.TabIndex = 124
        Me.lblDespachoNumero.Text = "..."
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(5, 12)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(103, 13)
        Me.Label43.TabIndex = 123
        Me.Label43.Text = "Nro. Documento :"
        '
        'btn_SalirDesp
        '
        Me.btn_SalirDesp.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_SalirDesp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SalirDesp.ForeColor = System.Drawing.Color.Navy
        Me.btn_SalirDesp.Image = CType(resources.GetObject("btn_SalirDesp.Image"), System.Drawing.Image)
        Me.btn_SalirDesp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_SalirDesp.Location = New System.Drawing.Point(312, 12)
        Me.btn_SalirDesp.Name = "btn_SalirDesp"
        Me.btn_SalirDesp.Size = New System.Drawing.Size(62, 35)
        Me.btn_SalirDesp.TabIndex = 121
        Me.btn_SalirDesp.Text = "Cancelar"
        Me.btn_SalirDesp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_SalirDesp.UseVisualStyleBackColor = True
        '
        'btn_AceptarDesp
        '
        Me.btn_AceptarDesp.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_AceptarDesp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AceptarDesp.ForeColor = System.Drawing.Color.Navy
        Me.btn_AceptarDesp.Image = CType(resources.GetObject("btn_AceptarDesp.Image"), System.Drawing.Image)
        Me.btn_AceptarDesp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_AceptarDesp.Location = New System.Drawing.Point(246, 12)
        Me.btn_AceptarDesp.Name = "btn_AceptarDesp"
        Me.btn_AceptarDesp.Size = New System.Drawing.Size(63, 35)
        Me.btn_AceptarDesp.TabIndex = 122
        Me.btn_AceptarDesp.Text = "Confirmar"
        Me.btn_AceptarDesp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_AceptarDesp.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.TextBox7)
        Me.GroupBox15.Location = New System.Drawing.Point(7, 64)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(425, 132)
        Me.GroupBox15.TabIndex = 201
        Me.GroupBox15.TabStop = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Navy
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(0, 8)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(425, 20)
        Me.TextBox7.TabIndex = 169
        Me.TextBox7.Text = "   Empresa de Transporte"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.TextBox8)
        Me.GroupBox16.Controls.Add(Me.RadioButton5)
        Me.GroupBox16.Controls.Add(Me.RadioButton4)
        Me.GroupBox16.Location = New System.Drawing.Point(7, 193)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(425, 141)
        Me.GroupBox16.TabIndex = 202
        Me.GroupBox16.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Navy
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(0, 8)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(425, 20)
        Me.TextBox8.TabIndex = 169
        Me.TextBox8.Text = "   Transportista"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton5.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton5.Location = New System.Drawing.Point(220, 39)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton5.TabIndex = 192
        Me.RadioButton5.Text = "Electivo"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton4.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton4.Location = New System.Drawing.Point(78, 39)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton4.TabIndex = 191
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Manual"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.Label60)
        Me.GroupBox17.Controls.Add(Me.PictureBox15)
        Me.GroupBox17.Controls.Add(Me.txt_cod_datos_vehiculo)
        Me.GroupBox17.Controls.Add(Me.Label61)
        Me.GroupBox17.Controls.Add(Me.txt_des_datos_vehiculo)
        Me.GroupBox17.Controls.Add(Me.TextBox5)
        Me.GroupBox17.Controls.Add(Me.txt_datos_vehiculo)
        Me.GroupBox17.Controls.Add(Me.rb_electivo_datos_vehiculo)
        Me.GroupBox17.Controls.Add(Me.rb_manual_datos_vehiculo)
        Me.GroupBox17.Location = New System.Drawing.Point(7, 338)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(425, 142)
        Me.GroupBox17.TabIndex = 203
        Me.GroupBox17.TabStop = False
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Navy
        Me.Label60.Location = New System.Drawing.Point(7, 95)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(154, 13)
        Me.Label60.TabIndex = 204
        Me.Label60.Text = "Datos del Vehiculo Manual"
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(98, 72)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox15.TabIndex = 203
        Me.PictureBox15.TabStop = False
        '
        'txt_cod_datos_vehiculo
        '
        Me.txt_cod_datos_vehiculo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_datos_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_datos_vehiculo.Location = New System.Drawing.Point(9, 72)
        Me.txt_cod_datos_vehiculo.MaxLength = 50
        Me.txt_cod_datos_vehiculo.Name = "txt_cod_datos_vehiculo"
        Me.txt_cod_datos_vehiculo.ReadOnly = True
        Me.txt_cod_datos_vehiculo.Size = New System.Drawing.Size(84, 20)
        Me.txt_cod_datos_vehiculo.TabIndex = 202
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Navy
        Me.Label61.Location = New System.Drawing.Point(7, 55)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(155, 13)
        Me.Label61.TabIndex = 201
        Me.Label61.Text = "Datos del Vehiculo a elegir"
        '
        'txt_des_datos_vehiculo
        '
        Me.txt_des_datos_vehiculo.BackColor = System.Drawing.Color.White
        Me.txt_des_datos_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_datos_vehiculo.Location = New System.Drawing.Point(120, 72)
        Me.txt_des_datos_vehiculo.MaxLength = 200
        Me.txt_des_datos_vehiculo.Name = "txt_des_datos_vehiculo"
        Me.txt_des_datos_vehiculo.ReadOnly = True
        Me.txt_des_datos_vehiculo.Size = New System.Drawing.Size(297, 20)
        Me.txt_des_datos_vehiculo.TabIndex = 200
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Navy
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(0, 8)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(425, 20)
        Me.TextBox5.TabIndex = 169
        Me.TextBox5.Text = "   Datos del Vehículo"
        '
        'txt_datos_vehiculo
        '
        Me.txt_datos_vehiculo.BackColor = System.Drawing.Color.White
        Me.txt_datos_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_datos_vehiculo.Location = New System.Drawing.Point(9, 114)
        Me.txt_datos_vehiculo.MaxLength = 200
        Me.txt_datos_vehiculo.Name = "txt_datos_vehiculo"
        Me.txt_datos_vehiculo.Size = New System.Drawing.Size(408, 20)
        Me.txt_datos_vehiculo.TabIndex = 199
        '
        'rb_electivo_datos_vehiculo
        '
        Me.rb_electivo_datos_vehiculo.AutoSize = True
        Me.rb_electivo_datos_vehiculo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_electivo_datos_vehiculo.ForeColor = System.Drawing.Color.Navy
        Me.rb_electivo_datos_vehiculo.Location = New System.Drawing.Point(220, 39)
        Me.rb_electivo_datos_vehiculo.Name = "rb_electivo_datos_vehiculo"
        Me.rb_electivo_datos_vehiculo.Size = New System.Drawing.Size(69, 17)
        Me.rb_electivo_datos_vehiculo.TabIndex = 192
        Me.rb_electivo_datos_vehiculo.Text = "Electivo"
        Me.rb_electivo_datos_vehiculo.UseVisualStyleBackColor = True
        '
        'rb_manual_datos_vehiculo
        '
        Me.rb_manual_datos_vehiculo.AutoSize = True
        Me.rb_manual_datos_vehiculo.Checked = True
        Me.rb_manual_datos_vehiculo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_manual_datos_vehiculo.ForeColor = System.Drawing.Color.Navy
        Me.rb_manual_datos_vehiculo.Location = New System.Drawing.Point(78, 39)
        Me.rb_manual_datos_vehiculo.Name = "rb_manual_datos_vehiculo"
        Me.rb_manual_datos_vehiculo.Size = New System.Drawing.Size(66, 17)
        Me.rb_manual_datos_vehiculo.TabIndex = 191
        Me.rb_manual_datos_vehiculo.TabStop = True
        Me.rb_manual_datos_vehiculo.Text = "Manual"
        Me.rb_manual_datos_vehiculo.UseVisualStyleBackColor = True
        '
        'pnlDocReferencia
        '
        Me.pnlDocReferencia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlDocReferencia.Controls.Add(Me.GroupBox9)
        Me.pnlDocReferencia.Location = New System.Drawing.Point(911, 158)
        Me.pnlDocReferencia.Name = "pnlDocReferencia"
        Me.pnlDocReferencia.Size = New System.Drawing.Size(15, 220)
        Me.pnlDocReferencia.TabIndex = 175
        Me.pnlDocReferencia.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtref_tipo)
        Me.GroupBox9.Controls.Add(Me.btnaceptar)
        Me.GroupBox9.Controls.Add(Me.dgv_Lista_Doc_Ref)
        Me.GroupBox9.Controls.Add(Me.btnSalr)
        Me.GroupBox9.Controls.Add(Me.txtref_monto)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Controls.Add(Me.btnAdicionar)
        Me.GroupBox9.Controls.Add(Me.dtpRef_fecha)
        Me.GroupBox9.Controls.Add(Me.Label46)
        Me.GroupBox9.Controls.Add(Me.Label42)
        Me.GroupBox9.Controls.Add(Me.txtref_igv)
        Me.GroupBox9.Controls.Add(Me.Label27)
        Me.GroupBox9.Controls.Add(Me.Label47)
        Me.GroupBox9.Controls.Add(Me.txtref_serie)
        Me.GroupBox9.Controls.Add(Me.txtref_num_doc)
        Me.GroupBox9.Controls.Add(Me.Label44)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(19, 9)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(471, 206)
        Me.GroupBox9.TabIndex = 141
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "&Detalles del Documento de Referencia"
        '
        'txtref_tipo
        '
        Me.txtref_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtref_tipo.Location = New System.Drawing.Point(68, 16)
        Me.txtref_tipo.Name = "txtref_tipo"
        Me.txtref_tipo.ReadOnly = True
        Me.txtref_tipo.Size = New System.Drawing.Size(65, 20)
        Me.txtref_tipo.TabIndex = 200
        Me.txtref_tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.Location = New System.Drawing.Point(179, 173)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(49, 30)
        Me.btnaceptar.TabIndex = 207
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'dgv_Lista_Doc_Ref
        '
        Me.dgv_Lista_Doc_Ref.AllowUserToAddRows = False
        Me.dgv_Lista_Doc_Ref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lista_Doc_Ref.Location = New System.Drawing.Point(14, 61)
        Me.dgv_Lista_Doc_Ref.MultiSelect = False
        Me.dgv_Lista_Doc_Ref.Name = "dgv_Lista_Doc_Ref"
        Me.dgv_Lista_Doc_Ref.ReadOnly = True
        Me.dgv_Lista_Doc_Ref.Size = New System.Drawing.Size(446, 108)
        Me.dgv_Lista_Doc_Ref.TabIndex = 139
        '
        'btnSalr
        '
        Me.btnSalr.Image = CType(resources.GetObject("btnSalr.Image"), System.Drawing.Image)
        Me.btnSalr.Location = New System.Drawing.Point(227, 173)
        Me.btnSalr.Name = "btnSalr"
        Me.btnSalr.Size = New System.Drawing.Size(49, 30)
        Me.btnSalr.TabIndex = 208
        Me.btnSalr.UseVisualStyleBackColor = True
        '
        'txtref_monto
        '
        Me.txtref_monto.BackColor = System.Drawing.Color.White
        Me.txtref_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtref_monto.Location = New System.Drawing.Point(313, 38)
        Me.txtref_monto.Name = "txtref_monto"
        Me.txtref_monto.Size = New System.Drawing.Size(74, 20)
        Me.txtref_monto.TabIndex = 205
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(8, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 126
        Me.Label21.Text = "FechaDoc"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.Location = New System.Drawing.Point(393, 34)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(67, 26)
        Me.btnAdicionar.TabIndex = 206
        Me.btnAdicionar.Text = "Agregar"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'dtpRef_fecha
        '
        Me.dtpRef_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRef_fecha.Location = New System.Drawing.Point(69, 37)
        Me.dtpRef_fecha.Name = "dtpRef_fecha"
        Me.dtpRef_fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtpRef_fecha.TabIndex = 203
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(274, 40)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(37, 13)
        Me.Label46.TabIndex = 136
        Me.Label46.Text = "Monto"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(17, 19)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(48, 13)
        Me.Label42.TabIndex = 128
        Me.Label42.Text = "TipoDoc"
        '
        'txtref_igv
        '
        Me.txtref_igv.BackColor = System.Drawing.Color.White
        Me.txtref_igv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtref_igv.Location = New System.Drawing.Point(202, 38)
        Me.txtref_igv.Name = "txtref_igv"
        Me.txtref_igv.Size = New System.Drawing.Size(50, 20)
        Me.txtref_igv.TabIndex = 204
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(146, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 13)
        Me.Label27.TabIndex = 130
        Me.Label27.Text = "SerieDoc"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(174, 40)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(22, 13)
        Me.Label47.TabIndex = 134
        Me.Label47.Text = "Igv"
        '
        'txtref_serie
        '
        Me.txtref_serie.BackColor = System.Drawing.Color.White
        Me.txtref_serie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtref_serie.Location = New System.Drawing.Point(202, 16)
        Me.txtref_serie.MaxLength = 3
        Me.txtref_serie.Name = "txtref_serie"
        Me.txtref_serie.Size = New System.Drawing.Size(50, 20)
        Me.txtref_serie.TabIndex = 201
        Me.txtref_serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtref_num_doc
        '
        Me.txtref_num_doc.BackColor = System.Drawing.Color.White
        Me.txtref_num_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtref_num_doc.Location = New System.Drawing.Point(314, 16)
        Me.txtref_num_doc.MaxLength = 7
        Me.txtref_num_doc.Name = "txtref_num_doc"
        Me.txtref_num_doc.Size = New System.Drawing.Size(73, 20)
        Me.txtref_num_doc.TabIndex = 202
        Me.txtref_num_doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.Navy
        Me.Label44.Location = New System.Drawing.Point(263, 18)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(48, 13)
        Me.Label44.TabIndex = 132
        Me.Label44.Text = "N°. Doc."
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrincipal.Controls.Add(Me.GroupBox4)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox3)
        Me.pnlPrincipal.Controls.Add(Me.dgvDocumentosFactura)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox2)
        Me.pnlPrincipal.Controls.Add(Me.lblCantidad)
        Me.pnlPrincipal.Controls.Add(Me.gbRangofechas)
        Me.pnlPrincipal.Location = New System.Drawing.Point(7, 28)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1145, 602)
        Me.pnlPrincipal.TabIndex = 179
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btn_modificar, Me.btnGrabar, Me.btnEliminar, Me.btnAnular, Me.btn_consultando, Me.btnImprimir, Me.btn_act_vendedor, Me.btn_sincronizar_cpe, Me.btn_descargar_archivos, Me.btn_enviar_mail, Me.btnContabilizar, Me.btnCancelar, Me.btnDespacho, Me.btnGenerarCP, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1155, 25)
        Me.ToolStrip1.TabIndex = 180
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
        Me.btnConsultar.Text = "&Consultar"
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
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(73, 22)
        Me.btnGrabar.Text = "&Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 22)
        Me.btnEliminar.Text = "&Eliminar"
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
        'btn_consultando
        '
        Me.btn_consultando.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultando.Image = CType(resources.GetObject("btn_consultando.Image"), System.Drawing.Image)
        Me.btn_consultando.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_consultando.Name = "btn_consultando"
        Me.btn_consultando.Size = New System.Drawing.Size(146, 22)
        Me.btn_consultando.Text = "&Consul( NotaC/Letra)"
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
        'btn_act_vendedor
        '
        Me.btn_act_vendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_act_vendedor.Image = CType(resources.GetObject("btn_act_vendedor.Image"), System.Drawing.Image)
        Me.btn_act_vendedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_act_vendedor.Name = "btn_act_vendedor"
        Me.btn_act_vendedor.Size = New System.Drawing.Size(85, 22)
        Me.btn_act_vendedor.Text = "Act. Datos"
        '
        'btn_sincronizar_cpe
        '
        Me.btn_sincronizar_cpe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_sincronizar_cpe.Image = CType(resources.GetObject("btn_sincronizar_cpe.Image"), System.Drawing.Image)
        Me.btn_sincronizar_cpe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_sincronizar_cpe.Name = "btn_sincronizar_cpe"
        Me.btn_sincronizar_cpe.Size = New System.Drawing.Size(113, 22)
        Me.btn_sincronizar_cpe.Text = "Sincronizar CPE"
        '
        'btn_descargar_archivos
        '
        Me.btn_descargar_archivos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_descargar_archivos.Image = CType(resources.GetObject("btn_descargar_archivos.Image"), System.Drawing.Image)
        Me.btn_descargar_archivos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_descargar_archivos.Name = "btn_descargar_archivos"
        Me.btn_descargar_archivos.Size = New System.Drawing.Size(108, 22)
        Me.btn_descargar_archivos.Text = "Descargar cpe"
        '
        'btn_enviar_mail
        '
        Me.btn_enviar_mail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_enviar_mail.Image = CType(resources.GetObject("btn_enviar_mail.Image"), System.Drawing.Image)
        Me.btn_enviar_mail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_enviar_mail.Name = "btn_enviar_mail"
        Me.btn_enviar_mail.Size = New System.Drawing.Size(165, 22)
        Me.btn_enviar_mail.Text = "Enviar Comp. Electronico"
        '
        'btnContabilizar
        '
        Me.btnContabilizar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContabilizar.Image = CType(resources.GetObject("btnContabilizar.Image"), System.Drawing.Image)
        Me.btnContabilizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnContabilizar.Name = "btnContabilizar"
        Me.btnContabilizar.Size = New System.Drawing.Size(135, 20)
        Me.btnContabilizar.Text = "&Enviar Contabilidad"
        Me.btnContabilizar.Visible = False
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
        'btnDespacho
        '
        Me.btnDespacho.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDespacho.Image = CType(resources.GetObject("btnDespacho.Image"), System.Drawing.Image)
        Me.btnDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDespacho.Name = "btnDespacho"
        Me.btnDespacho.Size = New System.Drawing.Size(118, 20)
        Me.btnDespacho.Text = "&Confir.Despacho"
        Me.btnDespacho.Visible = False
        '
        'btnGenerarCP
        '
        Me.btnGenerarCP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarCP.Image = CType(resources.GetObject("btnGenerarCP.Image"), System.Drawing.Image)
        Me.btnGenerarCP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerarCP.Name = "btnGenerarCP"
        Me.btnGenerarCP.Size = New System.Drawing.Size(81, 20)
        Me.btnGenerarCP.Text = "&Comp.Per"
        Me.btnGenerarCP.Visible = False
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 20)
        Me.btn_salir.Text = "&Salir"
        '
        'pnl_pedido
        '
        Me.pnl_pedido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_pedido.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_pedido.Controls.Add(Me.TextBox2)
        Me.pnl_pedido.Controls.Add(Me.GroupBox10)
        Me.pnl_pedido.Location = New System.Drawing.Point(226, 59)
        Me.pnl_pedido.Name = "pnl_pedido"
        Me.pnl_pedido.Size = New System.Drawing.Size(585, 346)
        Me.pnl_pedido.TabIndex = 181
        Me.pnl_pedido.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Navy
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(585, 16)
        Me.TextBox2.TabIndex = 169
        Me.TextBox2.Text = "PEDIDOS"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.btn_salir_pedido)
        Me.GroupBox10.Controls.Add(Me.btn_ok_pedido)
        Me.GroupBox10.Controls.Add(Me.GroupBox11)
        Me.GroupBox10.Controls.Add(Me.dgv_cab_ped)
        Me.GroupBox10.Location = New System.Drawing.Point(16, 18)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(559, 314)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        '
        'btn_salir_pedido
        '
        Me.btn_salir_pedido.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_salir_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir_pedido.Image = CType(resources.GetObject("btn_salir_pedido.Image"), System.Drawing.Image)
        Me.btn_salir_pedido.Location = New System.Drawing.Point(504, 28)
        Me.btn_salir_pedido.Name = "btn_salir_pedido"
        Me.btn_salir_pedido.Size = New System.Drawing.Size(49, 32)
        Me.btn_salir_pedido.TabIndex = 121
        Me.btn_salir_pedido.UseVisualStyleBackColor = True
        '
        'btn_ok_pedido
        '
        Me.btn_ok_pedido.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_ok_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok_pedido.Image = CType(resources.GetObject("btn_ok_pedido.Image"), System.Drawing.Image)
        Me.btn_ok_pedido.Location = New System.Drawing.Point(454, 28)
        Me.btn_ok_pedido.Name = "btn_ok_pedido"
        Me.btn_ok_pedido.Size = New System.Drawing.Size(49, 32)
        Me.btn_ok_pedido.TabIndex = 122
        Me.btn_ok_pedido.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txt_filtrar_pedido)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox11.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(436, 45)
        Me.GroupBox11.TabIndex = 120
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Ingrese Nro Pedido  a Buscar :"
        '
        'txt_filtrar_pedido
        '
        Me.txt_filtrar_pedido.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_filtrar_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtrar_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtrar_pedido.Location = New System.Drawing.Point(7, 16)
        Me.txt_filtrar_pedido.Name = "txt_filtrar_pedido"
        Me.txt_filtrar_pedido.Size = New System.Drawing.Size(423, 21)
        Me.txt_filtrar_pedido.TabIndex = 24
        '
        'dgv_cab_ped
        '
        Me.dgv_cab_ped.AllowUserToAddRows = False
        Me.dgv_cab_ped.AllowUserToDeleteRows = False
        Me.dgv_cab_ped.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_cab_ped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cab_ped.Location = New System.Drawing.Point(12, 71)
        Me.dgv_cab_ped.Name = "dgv_cab_ped"
        Me.dgv_cab_ped.Size = New System.Drawing.Size(541, 231)
        Me.dgv_cab_ped.TabIndex = 0
        '
        'pnl_devoluciones
        '
        Me.pnl_devoluciones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_devoluciones.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_devoluciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_devoluciones.Controls.Add(Me.GroupBox12)
        Me.pnl_devoluciones.Location = New System.Drawing.Point(133, 633)
        Me.pnl_devoluciones.Name = "pnl_devoluciones"
        Me.pnl_devoluciones.Size = New System.Drawing.Size(677, 282)
        Me.pnl_devoluciones.TabIndex = 113
        Me.pnl_devoluciones.Visible = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.GroupBox13)
        Me.GroupBox12.Controls.Add(Me.dgv_detalle_dev)
        Me.GroupBox12.Controls.Add(Me.TextBox4)
        Me.GroupBox12.Controls.Add(Me.btn_devolucion_salir)
        Me.GroupBox12.Controls.Add(Me.btn_devolucion_ok)
        Me.GroupBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox12.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(659, 270)
        Me.GroupBox12.TabIndex = 211
        Me.GroupBox12.TabStop = False
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.txt_busqueda_dev)
        Me.GroupBox13.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox13.Location = New System.Drawing.Point(5, 32)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(534, 45)
        Me.GroupBox13.TabIndex = 214
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Ingrese Nro Documento  a Buscar :"
        '
        'txt_busqueda_dev
        '
        Me.txt_busqueda_dev.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_busqueda_dev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_busqueda_dev.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_dev.Location = New System.Drawing.Point(7, 16)
        Me.txt_busqueda_dev.Name = "txt_busqueda_dev"
        Me.txt_busqueda_dev.Size = New System.Drawing.Size(513, 21)
        Me.txt_busqueda_dev.TabIndex = 24
        '
        'dgv_detalle_dev
        '
        Me.dgv_detalle_dev.AllowUserToAddRows = False
        Me.dgv_detalle_dev.AllowUserToDeleteRows = False
        Me.dgv_detalle_dev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_dev.Location = New System.Drawing.Point(6, 82)
        Me.dgv_detalle_dev.Name = "dgv_detalle_dev"
        Me.dgv_detalle_dev.Size = New System.Drawing.Size(640, 171)
        Me.dgv_detalle_dev.TabIndex = 213
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Navy
        Me.TextBox4.Location = New System.Drawing.Point(2, 13)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(654, 16)
        Me.TextBox4.TabIndex = 212
        Me.TextBox4.Text = "DEVOLUCIONES"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_devolucion_salir
        '
        Me.btn_devolucion_salir.Image = CType(resources.GetObject("btn_devolucion_salir.Image"), System.Drawing.Image)
        Me.btn_devolucion_salir.Location = New System.Drawing.Point(600, 40)
        Me.btn_devolucion_salir.Name = "btn_devolucion_salir"
        Me.btn_devolucion_salir.Size = New System.Drawing.Size(49, 30)
        Me.btn_devolucion_salir.TabIndex = 210
        Me.btn_devolucion_salir.UseVisualStyleBackColor = True
        '
        'btn_devolucion_ok
        '
        Me.btn_devolucion_ok.Image = CType(resources.GetObject("btn_devolucion_ok.Image"), System.Drawing.Image)
        Me.btn_devolucion_ok.Location = New System.Drawing.Point(552, 40)
        Me.btn_devolucion_ok.Name = "btn_devolucion_ok"
        Me.btn_devolucion_ok.Size = New System.Drawing.Size(49, 30)
        Me.btn_devolucion_ok.TabIndex = 209
        Me.btn_devolucion_ok.UseVisualStyleBackColor = True
        '
        'panel_estado_cuenta
        '
        Me.panel_estado_cuenta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel_estado_cuenta.BackColor = System.Drawing.Color.White
        Me.panel_estado_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_estado_cuenta.Controls.Add(Me.GroupBox14)
        Me.panel_estado_cuenta.Location = New System.Drawing.Point(139, 59)
        Me.panel_estado_cuenta.Name = "panel_estado_cuenta"
        Me.panel_estado_cuenta.Size = New System.Drawing.Size(22, 339)
        Me.panel_estado_cuenta.TabIndex = 182
        Me.panel_estado_cuenta.Visible = False
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.White
        Me.GroupBox14.Controls.Add(Me.lblmensajedocvencidos)
        Me.GroupBox14.Controls.Add(Me.lblmensaje)
        Me.GroupBox14.Controls.Add(Me.lbltotaldolares)
        Me.GroupBox14.Controls.Add(Me.lbltotalsoles)
        Me.GroupBox14.Controls.Add(Me.lblcreditlimitdolares)
        Me.GroupBox14.Controls.Add(Me.lblcreditlimitsoles)
        Me.GroupBox14.Controls.Add(Me.txtpassword)
        Me.GroupBox14.Controls.Add(Me.Label52)
        Me.GroupBox14.Controls.Add(Me.dgv_estado_cuenta_cliente)
        Me.GroupBox14.Controls.Add(Me.TextBox6)
        Me.GroupBox14.Controls.Add(Me.Button1)
        Me.GroupBox14.Controls.Add(Me.Button2)
        Me.GroupBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox14.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(867, 546)
        Me.GroupBox14.TabIndex = 211
        Me.GroupBox14.TabStop = False
        '
        'lblmensajedocvencidos
        '
        Me.lblmensajedocvencidos.AutoSize = True
        Me.lblmensajedocvencidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensajedocvencidos.ForeColor = System.Drawing.Color.Navy
        Me.lblmensajedocvencidos.Location = New System.Drawing.Point(8, 464)
        Me.lblmensajedocvencidos.Name = "lblmensajedocvencidos"
        Me.lblmensajedocvencidos.Size = New System.Drawing.Size(20, 16)
        Me.lblmensajedocvencidos.TabIndex = 221
        Me.lblmensajedocvencidos.Text = "..."
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.ForeColor = System.Drawing.Color.Navy
        Me.lblmensaje.Location = New System.Drawing.Point(8, 436)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(20, 16)
        Me.lblmensaje.TabIndex = 220
        Me.lblmensaje.Text = "..."
        '
        'lbltotaldolares
        '
        Me.lbltotaldolares.AutoSize = True
        Me.lbltotaldolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotaldolares.ForeColor = System.Drawing.Color.Navy
        Me.lbltotaldolares.Location = New System.Drawing.Point(504, 399)
        Me.lbltotaldolares.Name = "lbltotaldolares"
        Me.lbltotaldolares.Size = New System.Drawing.Size(20, 16)
        Me.lbltotaldolares.TabIndex = 219
        Me.lbltotaldolares.Text = "..."
        '
        'lbltotalsoles
        '
        Me.lbltotalsoles.AutoSize = True
        Me.lbltotalsoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalsoles.ForeColor = System.Drawing.Color.Navy
        Me.lbltotalsoles.Location = New System.Drawing.Point(504, 365)
        Me.lbltotalsoles.Name = "lbltotalsoles"
        Me.lbltotalsoles.Size = New System.Drawing.Size(20, 16)
        Me.lbltotalsoles.TabIndex = 218
        Me.lbltotalsoles.Text = "..."
        '
        'lblcreditlimitdolares
        '
        Me.lblcreditlimitdolares.AutoSize = True
        Me.lblcreditlimitdolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreditlimitdolares.ForeColor = System.Drawing.Color.Navy
        Me.lblcreditlimitdolares.Location = New System.Drawing.Point(8, 399)
        Me.lblcreditlimitdolares.Name = "lblcreditlimitdolares"
        Me.lblcreditlimitdolares.Size = New System.Drawing.Size(20, 16)
        Me.lblcreditlimitdolares.TabIndex = 217
        Me.lblcreditlimitdolares.Text = "..."
        '
        'lblcreditlimitsoles
        '
        Me.lblcreditlimitsoles.AutoSize = True
        Me.lblcreditlimitsoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreditlimitsoles.ForeColor = System.Drawing.Color.Navy
        Me.lblcreditlimitsoles.Location = New System.Drawing.Point(6, 365)
        Me.lblcreditlimitsoles.Name = "lblcreditlimitsoles"
        Me.lblcreditlimitsoles.Size = New System.Drawing.Size(20, 16)
        Me.lblcreditlimitsoles.TabIndex = 216
        Me.lblcreditlimitsoles.Text = "..."
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Aquamarine
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(123, 507)
        Me.txtpassword.MaxLength = 10
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(160, 22)
        Me.txtpassword.TabIndex = 214
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(8, 497)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(104, 32)
        Me.Label52.TabIndex = 215
        Me.Label52.Text = "Password de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Administrador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dgv_estado_cuenta_cliente
        '
        Me.dgv_estado_cuenta_cliente.AllowUserToAddRows = False
        Me.dgv_estado_cuenta_cliente.AllowUserToDeleteRows = False
        Me.dgv_estado_cuenta_cliente.AllowUserToResizeColumns = False
        Me.dgv_estado_cuenta_cliente.AllowUserToResizeRows = False
        Me.dgv_estado_cuenta_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estado_cuenta_cliente.Location = New System.Drawing.Point(5, 38)
        Me.dgv_estado_cuenta_cliente.Name = "dgv_estado_cuenta_cliente"
        Me.dgv_estado_cuenta_cliente.ReadOnly = True
        Me.dgv_estado_cuenta_cliente.Size = New System.Drawing.Size(851, 317)
        Me.dgv_estado_cuenta_cliente.TabIndex = 213
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Navy
        Me.TextBox6.Location = New System.Drawing.Point(2, 13)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(861, 23)
        Me.TextBox6.TabIndex = 212
        Me.TextBox6.Text = "ESTADO DE CUENTA POR CLIENTE"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(450, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 210
        Me.Button1.Text = "      Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(344, 505)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 209
        Me.Button2.Text = "      Continuar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pnl_motivo_anulacion
        '
        Me.pnl_motivo_anulacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_motivo_anulacion.Controls.Add(Me.txt_motivo_anulacion)
        Me.pnl_motivo_anulacion.Controls.Add(Me.TextBox10)
        Me.pnl_motivo_anulacion.Controls.Add(Me.GroupBox19)
        Me.pnl_motivo_anulacion.Controls.Add(Me.GroupBox20)
        Me.pnl_motivo_anulacion.Location = New System.Drawing.Point(289, 63)
        Me.pnl_motivo_anulacion.Name = "pnl_motivo_anulacion"
        Me.pnl_motivo_anulacion.Size = New System.Drawing.Size(440, 129)
        Me.pnl_motivo_anulacion.TabIndex = 185
        Me.pnl_motivo_anulacion.Visible = False
        '
        'txt_motivo_anulacion
        '
        Me.txt_motivo_anulacion.BackColor = System.Drawing.Color.White
        Me.txt_motivo_anulacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_motivo_anulacion.ForeColor = System.Drawing.Color.Maroon
        Me.txt_motivo_anulacion.Location = New System.Drawing.Point(17, 85)
        Me.txt_motivo_anulacion.MaxLength = 200
        Me.txt_motivo_anulacion.Name = "txt_motivo_anulacion"
        Me.txt_motivo_anulacion.Size = New System.Drawing.Size(405, 20)
        Me.txt_motivo_anulacion.TabIndex = 185
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Navy
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox10.ForeColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(1, 1)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(440, 20)
        Me.TextBox10.TabIndex = 168
        Me.TextBox10.Text = "MOTIVO DE ANULACION"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.dtp_fecha_anulacion)
        Me.GroupBox19.Controls.Add(Me.Label65)
        Me.GroupBox19.Controls.Add(Me.Label66)
        Me.GroupBox19.Controls.Add(Me.Label69)
        Me.GroupBox19.Controls.Add(Me.Button5)
        Me.GroupBox19.Controls.Add(Me.Button6)
        Me.GroupBox19.Location = New System.Drawing.Point(8, 18)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(424, 52)
        Me.GroupBox19.TabIndex = 0
        Me.GroupBox19.TabStop = False
        '
        'dtp_fecha_anulacion
        '
        Me.dtp_fecha_anulacion.Enabled = False
        Me.dtp_fecha_anulacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_anulacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_anulacion.Location = New System.Drawing.Point(119, 26)
        Me.dtp_fecha_anulacion.Name = "dtp_fecha_anulacion"
        Me.dtp_fecha_anulacion.Size = New System.Drawing.Size(119, 21)
        Me.dtp_fecha_anulacion.TabIndex = 126
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Navy
        Me.Label65.Location = New System.Drawing.Point(7, 31)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(108, 13)
        Me.Label65.TabIndex = 125
        Me.Label65.Text = "Fecha Documento"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Maroon
        Me.Label66.Location = New System.Drawing.Point(113, 12)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(16, 13)
        Me.Label66.TabIndex = 124
        Me.Label66.Text = "..."
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Navy
        Me.Label69.Location = New System.Drawing.Point(5, 12)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(103, 13)
        Me.Label69.TabIndex = 123
        Me.Label69.Text = "Nro. Documento :"
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Navy
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(311, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 35)
        Me.Button5.TabIndex = 121
        Me.Button5.Text = "Cancelar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Navy
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(246, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(63, 35)
        Me.Button6.TabIndex = 122
        Me.Button6.Text = "Confirmar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Location = New System.Drawing.Point(7, 64)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(425, 52)
        Me.GroupBox20.TabIndex = 201
        Me.GroupBox20.TabStop = False
        '
        'pnl_vendedor
        '
        Me.pnl_vendedor.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_vendedor.Controls.Add(Me.TextBox12)
        Me.pnl_vendedor.Controls.Add(Me.GroupBox18)
        Me.pnl_vendedor.Location = New System.Drawing.Point(271, 60)
        Me.pnl_vendedor.Name = "pnl_vendedor"
        Me.pnl_vendedor.Size = New System.Drawing.Size(478, 368)
        Me.pnl_vendedor.TabIndex = 186
        Me.pnl_vendedor.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Navy
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox12.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox12.ForeColor = System.Drawing.Color.White
        Me.TextBox12.Location = New System.Drawing.Point(0, 0)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(478, 20)
        Me.TextBox12.TabIndex = 168
        Me.TextBox12.Text = "ACTUALIZANDO DATOS"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.GroupBox23)
        Me.GroupBox18.Controls.Add(Me.GroupBox22)
        Me.GroupBox18.Controls.Add(Me.GroupBox21)
        Me.GroupBox18.Controls.Add(Me.Button3)
        Me.GroupBox18.Controls.Add(Me.Button4)
        Me.GroupBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox18.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox18.Location = New System.Drawing.Point(10, 26)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(457, 329)
        Me.GroupBox18.TabIndex = 0
        Me.GroupBox18.TabStop = False
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.txt_mp_act_desc)
        Me.GroupBox23.Controls.Add(Me.PictureBox21)
        Me.GroupBox23.Controls.Add(Me.txt_mp_act)
        Me.GroupBox23.Controls.Add(Me.Label73)
        Me.GroupBox23.Controls.Add(Me.txt_mp_ant_desc)
        Me.GroupBox23.Controls.Add(Me.PictureBox22)
        Me.GroupBox23.Controls.Add(Me.txt_mp_ant)
        Me.GroupBox23.Controls.Add(Me.Label74)
        Me.GroupBox23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox23.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox23.Location = New System.Drawing.Point(9, 191)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(439, 75)
        Me.GroupBox23.TabIndex = 125
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Modo de Pago"
        '
        'txt_mp_act_desc
        '
        Me.txt_mp_act_desc.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_mp_act_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mp_act_desc.Location = New System.Drawing.Point(158, 45)
        Me.txt_mp_act_desc.Name = "txt_mp_act_desc"
        Me.txt_mp_act_desc.ReadOnly = True
        Me.txt_mp_act_desc.Size = New System.Drawing.Size(276, 21)
        Me.txt_mp_act_desc.TabIndex = 242
        Me.txt_mp_act_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox21
        '
        Me.PictureBox21.Image = CType(resources.GetObject("PictureBox21.Image"), System.Drawing.Image)
        Me.PictureBox21.Location = New System.Drawing.Point(133, 46)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox21.TabIndex = 241
        Me.PictureBox21.TabStop = False
        '
        'txt_mp_act
        '
        Me.txt_mp_act.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_mp_act.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mp_act.Location = New System.Drawing.Point(73, 45)
        Me.txt_mp_act.Name = "txt_mp_act"
        Me.txt_mp_act.ReadOnly = True
        Me.txt_mp_act.Size = New System.Drawing.Size(57, 21)
        Me.txt_mp_act.TabIndex = 240
        Me.txt_mp_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Navy
        Me.Label73.Location = New System.Drawing.Point(6, 49)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(43, 13)
        Me.Label73.TabIndex = 239
        Me.Label73.Text = "Actual"
        '
        'txt_mp_ant_desc
        '
        Me.txt_mp_ant_desc.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_mp_ant_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mp_ant_desc.Enabled = False
        Me.txt_mp_ant_desc.Location = New System.Drawing.Point(158, 18)
        Me.txt_mp_ant_desc.Name = "txt_mp_ant_desc"
        Me.txt_mp_ant_desc.ReadOnly = True
        Me.txt_mp_ant_desc.Size = New System.Drawing.Size(276, 21)
        Me.txt_mp_ant_desc.TabIndex = 238
        Me.txt_mp_ant_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox22
        '
        Me.PictureBox22.Image = CType(resources.GetObject("PictureBox22.Image"), System.Drawing.Image)
        Me.PictureBox22.Location = New System.Drawing.Point(133, 19)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox22.TabIndex = 237
        Me.PictureBox22.TabStop = False
        '
        'txt_mp_ant
        '
        Me.txt_mp_ant.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_mp_ant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mp_ant.Enabled = False
        Me.txt_mp_ant.Location = New System.Drawing.Point(73, 18)
        Me.txt_mp_ant.Name = "txt_mp_ant"
        Me.txt_mp_ant.ReadOnly = True
        Me.txt_mp_ant.Size = New System.Drawing.Size(57, 21)
        Me.txt_mp_ant.TabIndex = 236
        Me.txt_mp_ant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.Navy
        Me.Label74.Location = New System.Drawing.Point(6, 22)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(54, 13)
        Me.Label74.TabIndex = 235
        Me.Label74.Text = "Anterior"
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.txt_fp_act_desc)
        Me.GroupBox22.Controls.Add(Me.PictureBox19)
        Me.GroupBox22.Controls.Add(Me.txt_fp_act)
        Me.GroupBox22.Controls.Add(Me.Label71)
        Me.GroupBox22.Controls.Add(Me.txt_fp_ant_desc)
        Me.GroupBox22.Controls.Add(Me.PictureBox20)
        Me.GroupBox22.Controls.Add(Me.txt_fp_ant)
        Me.GroupBox22.Controls.Add(Me.Label72)
        Me.GroupBox22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox22.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox22.Location = New System.Drawing.Point(9, 102)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(439, 75)
        Me.GroupBox22.TabIndex = 124
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Forma de Pago"
        '
        'txt_fp_act_desc
        '
        Me.txt_fp_act_desc.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_fp_act_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fp_act_desc.Location = New System.Drawing.Point(158, 45)
        Me.txt_fp_act_desc.Name = "txt_fp_act_desc"
        Me.txt_fp_act_desc.ReadOnly = True
        Me.txt_fp_act_desc.Size = New System.Drawing.Size(276, 21)
        Me.txt_fp_act_desc.TabIndex = 242
        Me.txt_fp_act_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = CType(resources.GetObject("PictureBox19.Image"), System.Drawing.Image)
        Me.PictureBox19.Location = New System.Drawing.Point(133, 46)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox19.TabIndex = 241
        Me.PictureBox19.TabStop = False
        '
        'txt_fp_act
        '
        Me.txt_fp_act.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_fp_act.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fp_act.Location = New System.Drawing.Point(73, 45)
        Me.txt_fp_act.Name = "txt_fp_act"
        Me.txt_fp_act.ReadOnly = True
        Me.txt_fp_act.Size = New System.Drawing.Size(57, 21)
        Me.txt_fp_act.TabIndex = 240
        Me.txt_fp_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Navy
        Me.Label71.Location = New System.Drawing.Point(6, 49)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(43, 13)
        Me.Label71.TabIndex = 239
        Me.Label71.Text = "Actual"
        '
        'txt_fp_ant_desc
        '
        Me.txt_fp_ant_desc.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_fp_ant_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fp_ant_desc.Enabled = False
        Me.txt_fp_ant_desc.Location = New System.Drawing.Point(158, 18)
        Me.txt_fp_ant_desc.Name = "txt_fp_ant_desc"
        Me.txt_fp_ant_desc.ReadOnly = True
        Me.txt_fp_ant_desc.Size = New System.Drawing.Size(276, 21)
        Me.txt_fp_ant_desc.TabIndex = 238
        Me.txt_fp_ant_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = CType(resources.GetObject("PictureBox20.Image"), System.Drawing.Image)
        Me.PictureBox20.Location = New System.Drawing.Point(133, 19)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox20.TabIndex = 237
        Me.PictureBox20.TabStop = False
        '
        'txt_fp_ant
        '
        Me.txt_fp_ant.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_fp_ant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fp_ant.Enabled = False
        Me.txt_fp_ant.Location = New System.Drawing.Point(73, 18)
        Me.txt_fp_ant.Name = "txt_fp_ant"
        Me.txt_fp_ant.ReadOnly = True
        Me.txt_fp_ant.Size = New System.Drawing.Size(57, 21)
        Me.txt_fp_ant.TabIndex = 236
        Me.txt_fp_ant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Navy
        Me.Label72.Location = New System.Drawing.Point(6, 22)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(54, 13)
        Me.Label72.TabIndex = 235
        Me.Label72.Text = "Anterior"
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.txt_vend_act_desc)
        Me.GroupBox21.Controls.Add(Me.PictureBox17)
        Me.GroupBox21.Controls.Add(Me.txt_vend_act)
        Me.GroupBox21.Controls.Add(Me.Label68)
        Me.GroupBox21.Controls.Add(Me.txt_vend_ant_desc)
        Me.GroupBox21.Controls.Add(Me.PictureBox16)
        Me.GroupBox21.Controls.Add(Me.txt_vend_ant)
        Me.GroupBox21.Controls.Add(Me.Label70)
        Me.GroupBox21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox21.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox21.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(439, 75)
        Me.GroupBox21.TabIndex = 123
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Vendedor"
        '
        'txt_vend_act_desc
        '
        Me.txt_vend_act_desc.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_vend_act_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vend_act_desc.Location = New System.Drawing.Point(158, 45)
        Me.txt_vend_act_desc.Name = "txt_vend_act_desc"
        Me.txt_vend_act_desc.ReadOnly = True
        Me.txt_vend_act_desc.Size = New System.Drawing.Size(276, 21)
        Me.txt_vend_act_desc.TabIndex = 242
        Me.txt_vend_act_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), System.Drawing.Image)
        Me.PictureBox17.Location = New System.Drawing.Point(133, 46)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox17.TabIndex = 241
        Me.PictureBox17.TabStop = False
        '
        'txt_vend_act
        '
        Me.txt_vend_act.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_vend_act.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vend_act.Location = New System.Drawing.Point(73, 45)
        Me.txt_vend_act.Name = "txt_vend_act"
        Me.txt_vend_act.ReadOnly = True
        Me.txt_vend_act.Size = New System.Drawing.Size(57, 21)
        Me.txt_vend_act.TabIndex = 240
        Me.txt_vend_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Navy
        Me.Label68.Location = New System.Drawing.Point(6, 49)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(43, 13)
        Me.Label68.TabIndex = 239
        Me.Label68.Text = "Actual"
        '
        'txt_vend_ant_desc
        '
        Me.txt_vend_ant_desc.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_vend_ant_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vend_ant_desc.Enabled = False
        Me.txt_vend_ant_desc.Location = New System.Drawing.Point(158, 18)
        Me.txt_vend_ant_desc.Name = "txt_vend_ant_desc"
        Me.txt_vend_ant_desc.ReadOnly = True
        Me.txt_vend_ant_desc.Size = New System.Drawing.Size(276, 21)
        Me.txt_vend_ant_desc.TabIndex = 238
        Me.txt_vend_ant_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(133, 19)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox16.TabIndex = 237
        Me.PictureBox16.TabStop = False
        '
        'txt_vend_ant
        '
        Me.txt_vend_ant.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_vend_ant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vend_ant.Enabled = False
        Me.txt_vend_ant.Location = New System.Drawing.Point(73, 18)
        Me.txt_vend_ant.Name = "txt_vend_ant"
        Me.txt_vend_ant.ReadOnly = True
        Me.txt_vend_ant.Size = New System.Drawing.Size(57, 21)
        Me.txt_vend_ant.TabIndex = 236
        Me.txt_vend_ant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Navy
        Me.Label70.Location = New System.Drawing.Point(6, 22)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(54, 13)
        Me.Label70.TabIndex = 235
        Me.Label70.Text = "Anterior"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(239, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 39)
        Me.Button3.TabIndex = 121
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(141, 280)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 39)
        Me.Button4.TabIndex = 122
        Me.Button4.Text = "Confirmar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'pnl_forma_de_pago
        '
        Me.pnl_forma_de_pago.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_forma_de_pago.Controls.Add(Me.TextBox9)
        Me.pnl_forma_de_pago.Controls.Add(Me.GroupBox24)
        Me.pnl_forma_de_pago.Location = New System.Drawing.Point(286, 145)
        Me.pnl_forma_de_pago.Name = "pnl_forma_de_pago"
        Me.pnl_forma_de_pago.Size = New System.Drawing.Size(462, 136)
        Me.pnl_forma_de_pago.TabIndex = 220
        Me.pnl_forma_de_pago.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Navy
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.White
        Me.TextBox9.Location = New System.Drawing.Point(2, 0)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(460, 16)
        Me.TextBox9.TabIndex = 166
        Me.TextBox9.Text = "Cuotas de Forma de Pago"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.txt_forma_de_pago)
        Me.GroupBox24.Controls.Add(Me.Button8)
        Me.GroupBox24.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox24.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(446, 109)
        Me.GroupBox24.TabIndex = 167
        Me.GroupBox24.TabStop = False
        '
        'txt_forma_de_pago
        '
        Me.txt_forma_de_pago.BackColor = System.Drawing.Color.White
        Me.txt_forma_de_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_forma_de_pago.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_forma_de_pago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_forma_de_pago.Location = New System.Drawing.Point(7, 14)
        Me.txt_forma_de_pago.MaxLength = 355
        Me.txt_forma_de_pago.Name = "txt_forma_de_pago"
        Me.txt_forma_de_pago.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txt_forma_de_pago.Size = New System.Drawing.Size(397, 85)
        Me.txt_forma_de_pago.TabIndex = 165
        Me.txt_forma_de_pago.Text = ""
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(411, 17)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(30, 28)
        Me.Button8.TabIndex = 164
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txt_forma_de_pago2
        '
        Me.txt_forma_de_pago2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_forma_de_pago2.BackColor = System.Drawing.Color.White
        Me.txt_forma_de_pago2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_forma_de_pago2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_forma_de_pago2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_forma_de_pago2.Location = New System.Drawing.Point(8, 547)
        Me.txt_forma_de_pago2.MaxLength = 355
        Me.txt_forma_de_pago2.Name = "txt_forma_de_pago2"
        Me.txt_forma_de_pago2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txt_forma_de_pago2.Size = New System.Drawing.Size(530, 64)
        Me.txt_forma_de_pago2.TabIndex = 221
        Me.txt_forma_de_pago2.Text = ""
        '
        'btn_detalle_pedido
        '
        Me.btn_detalle_pedido.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_detalle_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_detalle_pedido.ForeColor = System.Drawing.Color.Navy
        Me.btn_detalle_pedido.Image = CType(resources.GetObject("btn_detalle_pedido.Image"), System.Drawing.Image)
        Me.btn_detalle_pedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_detalle_pedido.Location = New System.Drawing.Point(809, 329)
        Me.btn_detalle_pedido.Name = "btn_detalle_pedido"
        Me.btn_detalle_pedido.Size = New System.Drawing.Size(104, 24)
        Me.btn_detalle_pedido.TabIndex = 222
        Me.btn_detalle_pedido.Text = "Detalle pedido"
        Me.btn_detalle_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_detalle_pedido.UseVisualStyleBackColor = True
        Me.btn_detalle_pedido.Visible = False
        '
        'panel_cliente_nuevo
        '
        Me.panel_cliente_nuevo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.panel_cliente_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_cliente_nuevo.Controls.Add(Me.GroupBox25)
        Me.panel_cliente_nuevo.Location = New System.Drawing.Point(488, 59)
        Me.panel_cliente_nuevo.Name = "panel_cliente_nuevo"
        Me.panel_cliente_nuevo.Size = New System.Drawing.Size(501, 182)
        Me.panel_cliente_nuevo.TabIndex = 223
        Me.panel_cliente_nuevo.Visible = False
        '
        'GroupBox25
        '
        Me.GroupBox25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox25.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox25.Controls.Add(Me.Label75)
        Me.GroupBox25.Controls.Add(Me.txt_Celular)
        Me.GroupBox25.Controls.Add(Me.Label79)
        Me.GroupBox25.Controls.Add(Me.txt_ubigeo)
        Me.GroupBox25.Controls.Add(Me.Label81)
        Me.GroupBox25.Controls.Add(Me.txt_direccion)
        Me.GroupBox25.Controls.Add(Me.Label82)
        Me.GroupBox25.Controls.Add(Me.TextBox11)
        Me.GroupBox25.Controls.Add(Me.Label83)
        Me.GroupBox25.Controls.Add(Me.TextBox13)
        Me.GroupBox25.Controls.Add(Me.Label84)
        Me.GroupBox25.Controls.Add(Me.TextBox14)
        Me.GroupBox25.Controls.Add(Me.Label85)
        Me.GroupBox25.Controls.Add(Me.txt_razon_social)
        Me.GroupBox25.Controls.Add(Me.Label87)
        Me.GroupBox25.Controls.Add(Me.TextBox15)
        Me.GroupBox25.Controls.Add(Me.btn_cancelar_nuevo_cliente)
        Me.GroupBox25.Controls.Add(Me.btn_grabar_nuevo_cliente)
        Me.GroupBox25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox25.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(479, 165)
        Me.GroupBox25.TabIndex = 211
        Me.GroupBox25.TabStop = False
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label75.ForeColor = System.Drawing.Color.Navy
        Me.Label75.Location = New System.Drawing.Point(37, 75)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(67, 16)
        Me.Label75.TabIndex = 244
        Me.Label75.Text = "Dirección"
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
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Navy
        Me.Label79.Location = New System.Drawing.Point(64, 435)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(67, 19)
        Me.Label79.TabIndex = 234
        Me.Label79.Text = "Celular"
        Me.Label79.Visible = False
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
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.Navy
        Me.Label81.Location = New System.Drawing.Point(65, 375)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(66, 19)
        Me.Label81.TabIndex = 230
        Me.Label81.Text = "Ubigeo"
        Me.Label81.Visible = False
        '
        'txt_direccion
        '
        Me.txt_direccion.BackColor = System.Drawing.Color.White
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_direccion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_direccion.ForeColor = System.Drawing.Color.Green
        Me.txt_direccion.Location = New System.Drawing.Point(106, 72)
        Me.txt_direccion.MaxLength = 200
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(364, 23)
        Me.txt_direccion.TabIndex = 227
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.Navy
        Me.Label82.Location = New System.Drawing.Point(47, 548)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(84, 19)
        Me.Label82.TabIndex = 228
        Me.Label82.Text = "Dirección"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.ForeColor = System.Drawing.Color.Green
        Me.TextBox11.Location = New System.Drawing.Point(135, 515)
        Me.TextBox11.MaxLength = 200
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(400, 27)
        Me.TextBox11.TabIndex = 225
        Me.TextBox11.Visible = False
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.Navy
        Me.Label83.Location = New System.Drawing.Point(22, 517)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(109, 19)
        Me.Label83.TabIndex = 226
        Me.Label83.Text = "Ap. Materno"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label83.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.White
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.ForeColor = System.Drawing.Color.Green
        Me.TextBox13.Location = New System.Drawing.Point(135, 485)
        Me.TextBox13.MaxLength = 200
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(400, 27)
        Me.TextBox13.TabIndex = 223
        Me.TextBox13.Visible = False
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.Navy
        Me.Label84.Location = New System.Drawing.Point(25, 487)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(106, 19)
        Me.Label84.TabIndex = 224
        Me.Label84.Text = "Ap. Paterno"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label84.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.ForeColor = System.Drawing.Color.Green
        Me.TextBox14.Location = New System.Drawing.Point(135, 455)
        Me.TextBox14.MaxLength = 200
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(400, 27)
        Me.TextBox14.TabIndex = 221
        Me.TextBox14.Visible = False
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.Navy
        Me.Label85.Location = New System.Drawing.Point(50, 457)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(81, 19)
        Me.Label85.TabIndex = 222
        Me.Label85.Text = "Nombres"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label85.Visible = False
        '
        'txt_razon_social
        '
        Me.txt_razon_social.BackColor = System.Drawing.Color.White
        Me.txt_razon_social.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_razon_social.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_razon_social.ForeColor = System.Drawing.Color.Green
        Me.txt_razon_social.Location = New System.Drawing.Point(106, 45)
        Me.txt_razon_social.MaxLength = 200
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(364, 23)
        Me.txt_razon_social.TabIndex = 217
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label87.ForeColor = System.Drawing.Color.Navy
        Me.Label87.Location = New System.Drawing.Point(12, 48)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(92, 16)
        Me.Label87.TabIndex = 218
        Me.Label87.Text = "Razón social "
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.Navy
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox15.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.ForeColor = System.Drawing.Color.White
        Me.TextBox15.Location = New System.Drawing.Point(3, 16)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(473, 20)
        Me.TextBox15.TabIndex = 212
        Me.TextBox15.Text = "REGISTRO DE CLIENTE NUEVO"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_cancelar_nuevo_cliente
        '
        Me.btn_cancelar_nuevo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_nuevo_cliente.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_cancelar_nuevo_cliente.ForeColor = System.Drawing.Color.Green
        Me.btn_cancelar_nuevo_cliente.Image = CType(resources.GetObject("btn_cancelar_nuevo_cliente.Image"), System.Drawing.Image)
        Me.btn_cancelar_nuevo_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar_nuevo_cliente.Location = New System.Drawing.Point(246, 107)
        Me.btn_cancelar_nuevo_cliente.Name = "btn_cancelar_nuevo_cliente"
        Me.btn_cancelar_nuevo_cliente.Size = New System.Drawing.Size(76, 45)
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
        Me.btn_grabar_nuevo_cliente.Location = New System.Drawing.Point(156, 107)
        Me.btn_grabar_nuevo_cliente.Name = "btn_grabar_nuevo_cliente"
        Me.btn_grabar_nuevo_cliente.Size = New System.Drawing.Size(76, 45)
        Me.btn_grabar_nuevo_cliente.TabIndex = 209
        Me.btn_grabar_nuevo_cliente.Text = "G&rabar"
        Me.btn_grabar_nuevo_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar_nuevo_cliente.UseVisualStyleBackColor = True
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1155, 633)
        Me.Controls.Add(Me.pnlDocumentosGuiaVenta)
        Me.Controls.Add(Me.pnl_motivo_anulacion)
        Me.Controls.Add(Me.pnl_pedido)
        Me.Controls.Add(Me.panel_cliente_nuevo)
        Me.Controls.Add(Me.pnl_forma_de_pago)
        Me.Controls.Add(Me.pnl_vendedor)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.panel_estado_cuenta)
        Me.Controls.Add(Me.pnl_devoluciones)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlDocReferencia)
        Me.Controls.Add(Me.pnlConfirmarDespacho)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.PnlBuscarordenCompra)
        Me.Controls.Add(Me.gbTipoGuia)
        Me.Controls.Add(Me.GbCabecera)
        Me.Controls.Add(Me.gbdetalle)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtIgv)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtDescuentos)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtvalorVenta)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtBruto)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtredondeo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.gbTipoFacturacion)
        Me.Controls.Add(Me.txt_forma_de_pago2)
        Me.Controls.Add(Me.btn_detalle_pedido)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        Me.gbdetalle.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox30.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbdetalleDocumento.ResumeLayout(False)
        Me.GbdetalleDocumento.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDocumentosGuiaVenta.ResumeLayout(False)
        Me.pnlDocumentosGuiaVenta.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvDocumentosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.gbTipoGuia.ResumeLayout(False)
        Me.gbTipoGuia.PerformLayout()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.PnlBuscarordenCompra.ResumeLayout(False)
        Me.PnlBuscarordenCompra.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbTipoFacturacion.ResumeLayout(False)
        Me.gbTipoFacturacion.PerformLayout()
        Me.pnlConfirmarDespacho.ResumeLayout(False)
        Me.pnlConfirmarDespacho.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDocReferencia.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.dgv_Lista_Doc_Ref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnl_pedido.ResumeLayout(False)
        Me.pnl_pedido.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.dgv_cab_ped, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_devoluciones.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.dgv_detalle_dev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_estado_cuenta.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.dgv_estado_cuenta_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_motivo_anulacion.ResumeLayout(False)
        Me.pnl_motivo_anulacion.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.pnl_vendedor.ResumeLayout(False)
        Me.pnl_vendedor.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_forma_de_pago.ResumeLayout(False)
        Me.pnl_forma_de_pago.PerformLayout()
        Me.GroupBox24.ResumeLayout(False)
        Me.panel_cliente_nuevo.ResumeLayout(False)
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbdetalle As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDocumentosFactura As System.Windows.Forms.DataGridView
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents cbSerieGuia As System.Windows.Forms.ComboBox
    Friend WithEvents cboSerieDoc As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtNomTrans As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTrans As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkSinIGV As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtRucDni As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
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
    Friend WithEvents txtGlosa As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPtoVenta As System.Windows.Forms.TextBox
    Friend WithEvents lblFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblVendedor As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtredondeo As System.Windows.Forms.TextBox
    Friend WithEvents txtBruto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtvalorVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDescuentos As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtdescEsp As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtdescCli As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtGlosaGuia As System.Windows.Forms.RichTextBox
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
    Friend WithEvents txtNumDocRef As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtordenCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtcotizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cboDirEntrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents txtAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents checkSinGuia As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents txttipoDocRef As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtSerieDocRef As System.Windows.Forms.TextBox
    Friend WithEvents PnlBuscarordenCompra As System.Windows.Forms.Panel
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscarOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents btnSalirNumeracion As System.Windows.Forms.Button
    Friend WithEvents btnAceptarBusquedaOC As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboOpcionTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroCP As System.Windows.Forms.TextBox
    Friend WithEvents txtSerieCP As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoCP As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GbdetalleDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents txtdetalleguiaserie As System.Windows.Forms.TextBox
    Friend WithEvents txtdetalleserie As System.Windows.Forms.TextBox
    Friend WithEvents txtdetalleguianumero As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtdetallenumero As System.Windows.Forms.TextBox
    Friend WithEvents txtdetalleguiadoc As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtdetalledoc As System.Windows.Forms.TextBox
    Friend WithEvents gbTipoFacturacion As System.Windows.Forms.GroupBox
    Friend WithEvents rbFacturaGuiaVenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturaDirecta As System.Windows.Forms.RadioButton
    Friend WithEvents pnlDocumentosGuiaVenta As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltroCliente As System.Windows.Forms.TextBox
    Friend WithEvents dgvDocumentosCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents rbFacturaExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents pnlConfirmarDespacho As System.Windows.Forms.Panel
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDespacho As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents lblDespachoNumero As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents btn_SalirDesp As System.Windows.Forms.Button
    Friend WithEvents btn_AceptarDesp As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents gbTipoGuia As System.Windows.Forms.GroupBox
    Friend WithEvents rbVariaslineas As System.Windows.Forms.RadioButton
    Friend WithEvents rbunalinea As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVariaslineasDoc As System.Windows.Forms.RadioButton
    Friend WithEvents rbunalineaDoc As System.Windows.Forms.RadioButton
    Friend WithEvents pnlDocReferencia As System.Windows.Forms.Panel
    Friend WithEvents rbDocRef_varios As System.Windows.Forms.RadioButton
    Friend WithEvents rbDocRef_uno As System.Windows.Forms.RadioButton
    Friend WithEvents btnSalr As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents txtref_monto As System.Windows.Forms.TextBox
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtref_igv As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtref_num_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtref_serie As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents dtpRef_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dgv_Lista_Doc_Ref As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtref_tipo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents rbsinDescargo As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturaRepMedico As System.Windows.Forms.RadioButton
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_consultando As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnContabilizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDespacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGenerarCP As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_pedido As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_salir_pedido As System.Windows.Forms.Button
    Friend WithEvents btn_ok_pedido As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_filtrar_pedido As System.Windows.Forms.TextBox
    Friend WithEvents dgv_cab_ped As System.Windows.Forms.DataGridView
    Friend WithEvents rb_facturar_pedido As System.Windows.Forms.RadioButton
    Friend WithEvents btn_modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents rb_facturar_devolucion As System.Windows.Forms.RadioButton
    Friend WithEvents pnl_devoluciones As System.Windows.Forms.Panel
    Friend WithEvents btn_devolucion_ok As System.Windows.Forms.Button
    Friend WithEvents btn_devolucion_salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_busqueda_dev As System.Windows.Forms.TextBox
    Friend WithEvents dgv_detalle_dev As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_trama As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txt_vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents panel_estado_cuenta As System.Windows.Forms.Panel
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_estado_cuenta_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents lblcreditlimitdolares As System.Windows.Forms.Label
    Friend WithEvents lblcreditlimitsoles As System.Windows.Forms.Label
    Friend WithEvents lbltotalsoles As System.Windows.Forms.Label
    Friend WithEvents lbltotaldolares As System.Windows.Forms.Label
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
    Friend WithEvents lblmensajedocvencidos As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txt_obs_despachos As System.Windows.Forms.TextBox
    Friend WithEvents txt_nro_entrega As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_transportista As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txt_des_transportista_despacho As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_emp_trans As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txt_des_emp_trans As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents txt_trans_manual_despacho As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txt_emp_trans_manual As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents txt_datos_vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_datos_vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txt_des_datos_vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents rb_electivo_datos_vehiculo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_manual_datos_vehiculo As System.Windows.Forms.RadioButton
    Friend WithEvents txt_ref_guia_Devolucion As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents rb_facturar_obsequio As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_fecha_traslado As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_desc_tipo_nota_electronica As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_tipo_nota_electronica As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents txt_email_cliente As System.Windows.Forms.TextBox
    Friend WithEvents pnl_motivo_anulacion As System.Windows.Forms.Panel
    Friend WithEvents txt_motivo_anulacion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_anulacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_enviar_mail As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblModoPago As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtModoPago As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents btn_act_vendedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_vendedor As System.Windows.Forms.Panel
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_vend_act_desc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_vend_act As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txt_vend_ant_desc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_vend_ant As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_mp_act_desc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox21 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_mp_act As System.Windows.Forms.TextBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents txt_mp_ant_desc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox22 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_mp_ant As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_fp_act_desc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_fp_act As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txt_fp_ant_desc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_fp_ant As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents rbfacturaExportacion As System.Windows.Forms.RadioButton
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents pnl_forma_de_pago As System.Windows.Forms.Panel
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_forma_de_pago As System.Windows.Forms.RichTextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents txt_forma_de_pago2 As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_detalle_pedido As System.Windows.Forms.Button
    Friend WithEvents btn_descargar_archivos As System.Windows.Forms.ToolStripButton
    Friend WithEvents panel_cliente_nuevo As System.Windows.Forms.Panel
    Friend WithEvents GroupBox25 As System.Windows.Forms.GroupBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents txt_Celular As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txt_ubigeo As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_grabar_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_cliente_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox30 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_trans_privado As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_trans_publico As System.Windows.Forms.RadioButton
    Friend WithEvents rb_facturar_obsequio_sin_pedido As System.Windows.Forms.RadioButton
    Friend WithEvents btn_sincronizar_cpe As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPdfOrdenCompra As System.Windows.Forms.Button
End Class
