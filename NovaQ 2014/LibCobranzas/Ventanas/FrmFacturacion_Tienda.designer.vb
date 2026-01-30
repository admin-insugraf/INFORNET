Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacion_Tienda
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacion_Tienda))
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboOpcionTipoDoc = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.dgvDocumentosFactura = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActualizarCantidadEnComprobanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.gbdetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.txt_numero_comprobante = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.chk_venta_sin_Descargo = New System.Windows.Forms.CheckBox()
        Me.btn_facturar_pedido = New System.Windows.Forms.Button()
        Me.chk_venta_cortesia = New System.Windows.Forms.CheckBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.dtpFechaFactura_vcto = New System.Windows.Forms.DateTimePicker()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
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
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtRucDni = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.txtPtoVenta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodTrans = New System.Windows.Forms.TextBox()
        Me.chk_facturar_obsequio = New System.Windows.Forms.CheckBox()
        Me.rdb_f_a4 = New System.Windows.Forms.RadioButton()
        Me.rdb_f_ticket = New System.Windows.Forms.RadioButton()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnAnular = New System.Windows.Forms.ToolStripButton()
        Me.btn_enviar_mail = New System.Windows.Forms.ToolStripButton()
        Me.btn_Apertura_Doc = New System.Windows.Forms.ToolStripButton()
        Me.btn_descargar_archivos = New System.Windows.Forms.ToolStripButton()
        Me.btn_rep_arqueo_caja = New System.Windows.Forms.ToolStripButton()
        Me.btn_cierre_ventas = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad_equivalente = New System.Windows.Forms.TextBox()
        Me.btn_cal_cantidad = New System.Windows.Forms.Button()
        Me.txtprecioTotal = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
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
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
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
        Me.panel_cliente_nuevo = New System.Windows.Forms.Panel()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btn_cancelar_nuevo_cliente = New System.Windows.Forms.Button()
        Me.btn_grabar_nuevo_cliente = New System.Windows.Forms.Button()
        Me.gbTipoFacturacion = New System.Windows.Forms.GroupBox()
        Me.rb_facturar_devolucion = New System.Windows.Forms.RadioButton()
        Me.rb_facturar_pedido = New System.Windows.Forms.RadioButton()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.rbFacturaRepMedico = New System.Windows.Forms.RadioButton()
        Me.rbFacturaExistencias = New System.Windows.Forms.RadioButton()
        Me.rbFacturaGuiaVenta = New System.Windows.Forms.RadioButton()
        Me.rbFacturaDirecta = New System.Windows.Forms.RadioButton()
        Me.rbsinDescargo = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rbVariaslineasDoc = New System.Windows.Forms.RadioButton()
        Me.rbunalineaDoc = New System.Windows.Forms.RadioButton()
        Me.txtGlosa = New System.Windows.Forms.RichTextBox()
        Me.gbTipoGuia = New System.Windows.Forms.GroupBox()
        Me.rbVariaslineas = New System.Windows.Forms.RadioButton()
        Me.rbunalinea = New System.Windows.Forms.RadioButton()
        Me.txtGlosaGuia = New System.Windows.Forms.RichTextBox()
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
        Me.pnl_cierre_ventas = New System.Windows.Forms.Panel()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt_cobro_venta_anterior = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.gb_pago_tarjeta = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.txt_plin = New System.Windows.Forms.TextBox()
        Me.txt_yape = New System.Windows.Forms.TextBox()
        Me.txt_bbva = New System.Windows.Forms.TextBox()
        Me.txt_bcp = New System.Windows.Forms.TextBox()
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
        Me.pnl_motivo_anulacion = New System.Windows.Forms.Panel()
        Me.txt_motivo_anulacion = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_anulacion = New System.Windows.Forms.DateTimePicker()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.lbl_numero_documento = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.btn_cancelar_anulacion = New System.Windows.Forms.Button()
        Me.btn_confirmar_anulacion = New System.Windows.Forms.Button()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rb_detallado = New System.Windows.Forms.RadioButton()
        Me.rb_resumido = New System.Windows.Forms.RadioButton()
        Me.chkTodosPersonal = New System.Windows.Forms.CheckBox()
        Me.txt_des_personal = New System.Windows.Forms.TextBox()
        Me.txt_cod_personal = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.checkConceptos = New System.Windows.Forms.CheckBox()
        Me.txt_des_concepto = New System.Windows.Forms.TextBox()
        Me.txt_cod_concepto = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.dtp_rep_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtp_rep_ini = New System.Windows.Forms.DateTimePicker()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.pnlDocumentosGuiaVenta = New System.Windows.Forms.Panel()
        Me.lblDetalle = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.txtFiltroCliente = New System.Windows.Forms.TextBox()
        Me.dgvDocumentosCliente = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.PictureBox28 = New System.Windows.Forms.PictureBox()
        Me.txt_interbank = New System.Windows.Forms.TextBox()
        Me.txt_scotiabank = New System.Windows.Forms.TextBox()
        Me.pnlPrincipal.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.gbdetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        Me.GbCabecera.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgv_lista_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_cliente_nuevo.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.gbTipoFacturacion.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.gbTipoGuia.SuspendLayout()
        Me.pnl_ref.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_cierre_ventas.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.gb_pago_tarjeta.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_pago_efectivo.SuspendLayout()
        Me.pnlNuevaPlanilla.SuspendLayout()
        Me.gb_nueva_planilla.SuspendLayout()
        Me.pnl_motivo_anulacion.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.pnlDocumentosGuiaVenta.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.dgvDocumentosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnlPrincipal.Location = New System.Drawing.Point(6, 33)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1005, 626)
        Me.pnlPrincipal.TabIndex = 211
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboOpcionTipoDoc)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(341, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(138, 45)
        Me.GroupBox4.TabIndex = 123
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Documento"
        '
        'cboOpcionTipoDoc
        '
        Me.cboOpcionTipoDoc.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpcionTipoDoc.FormattingEnabled = True
        Me.cboOpcionTipoDoc.Items.AddRange(New Object() {"Todos", "BV", "FT", "PF", "PD", "NC", "ND"})
        Me.cboOpcionTipoDoc.Location = New System.Drawing.Point(6, 15)
        Me.cboOpcionTipoDoc.Name = "cboOpcionTipoDoc"
        Me.cboOpcionTipoDoc.Size = New System.Drawing.Size(125, 25)
        Me.cboOpcionTipoDoc.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(8, 12)
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
        Me.dgvDocumentosFactura.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvDocumentosFactura.Location = New System.Drawing.Point(8, 67)
        Me.dgvDocumentosFactura.MultiSelect = False
        Me.dgvDocumentosFactura.Name = "dgvDocumentosFactura"
        Me.dgvDocumentosFactura.ReadOnly = True
        Me.dgvDocumentosFactura.Size = New System.Drawing.Size(992, 524)
        Me.dgvDocumentosFactura.TabIndex = 117
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarCantidadEnComprobanteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(267, 26)
        '
        'ActualizarCantidadEnComprobanteToolStripMenuItem
        '
        Me.ActualizarCantidadEnComprobanteToolStripMenuItem.Image = CType(resources.GetObject("ActualizarCantidadEnComprobanteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActualizarCantidadEnComprobanteToolStripMenuItem.Name = "ActualizarCantidadEnComprobanteToolStripMenuItem"
        Me.ActualizarCantidadEnComprobanteToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.ActualizarCantidadEnComprobanteToolStripMenuItem.Text = "Actualizar cantidad en comprobante"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(487, 12)
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
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Dia de Proceso", "Rango Fechas"})
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
        Me.gbRangofechas.Location = New System.Drawing.Point(671, 12)
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
        'gbdetalle
        '
        Me.gbdetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbdetalle.BackColor = System.Drawing.Color.White
        Me.gbdetalle.Controls.Add(Me.dgvDetalle)
        Me.gbdetalle.Location = New System.Drawing.Point(17, 368)
        Me.gbdetalle.Name = "gbdetalle"
        Me.gbdetalle.Size = New System.Drawing.Size(483, 146)
        Me.gbdetalle.TabIndex = 209
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
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle37
        Me.dgvDetalle.ColumnHeadersHeight = 30
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle38
        Me.dgvDetalle.EnableHeadersVisualStyles = False
        Me.dgvDetalle.Location = New System.Drawing.Point(8, 13)
        Me.dgvDetalle.Name = "dgvDetalle"
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle39
        Me.dgvDetalle.RowHeadersVisible = False
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDetalle.RowsDefaultCellStyle = DataGridViewCellStyle40
        Me.dgvDetalle.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(470, 127)
        Me.dgvDetalle.TabIndex = 112
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.txt_numero_comprobante)
        Me.gbOpciones.Controls.Add(Me.Button2)
        Me.gbOpciones.Controls.Add(Me.Button1)
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Location = New System.Drawing.Point(17, 583)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(483, 65)
        Me.gbOpciones.TabIndex = 210
        Me.gbOpciones.TabStop = False
        '
        'txt_numero_comprobante
        '
        Me.txt_numero_comprobante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_numero_comprobante.BackColor = System.Drawing.Color.White
        Me.txt_numero_comprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_comprobante.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_comprobante.ForeColor = System.Drawing.Color.Green
        Me.txt_numero_comprobante.Location = New System.Drawing.Point(92, 16)
        Me.txt_numero_comprobante.Multiline = True
        Me.txt_numero_comprobante.Name = "txt_numero_comprobante"
        Me.txt_numero_comprobante.ReadOnly = True
        Me.txt_numero_comprobante.Size = New System.Drawing.Size(228, 36)
        Me.txt_numero_comprobante.TabIndex = 208
        Me.txt_numero_comprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_numero_comprobante.Visible = False
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
        Me.Button2.Location = New System.Drawing.Point(332, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 44)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "&Grabar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.Button1.Location = New System.Drawing.Point(404, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 44)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "&Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
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
        'GbCabecera
        '
        Me.GbCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.chk_venta_sin_Descargo)
        Me.GbCabecera.Controls.Add(Me.btn_facturar_pedido)
        Me.GbCabecera.Controls.Add(Me.chk_venta_cortesia)
        Me.GbCabecera.Controls.Add(Me.Label105)
        Me.GbCabecera.Controls.Add(Me.dtpFechaFactura_vcto)
        Me.GbCabecera.Controls.Add(Me.Label104)
        Me.GbCabecera.Controls.Add(Me.Label103)
        Me.GbCabecera.Controls.Add(Me.txtcodigo)
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
        Me.GbCabecera.Controls.Add(Me.txtVendedor)
        Me.GbCabecera.Controls.Add(Me.txtDireccion)
        Me.GbCabecera.Controls.Add(Me.txtRazonSocial)
        Me.GbCabecera.Controls.Add(Me.txtRucDni)
        Me.GbCabecera.Controls.Add(Me.txtCodCliente)
        Me.GbCabecera.Controls.Add(Me.txtPtoVenta)
        Me.GbCabecera.Controls.Add(Me.Label13)
        Me.GbCabecera.Controls.Add(Me.Label11)
        Me.GbCabecera.Controls.Add(Me.Label10)
        Me.GbCabecera.Controls.Add(Me.Label9)
        Me.GbCabecera.Controls.Add(Me.Label8)
        Me.GbCabecera.Controls.Add(Me.Label7)
        Me.GbCabecera.Controls.Add(Me.Label6)
        Me.GbCabecera.Controls.Add(Me.Label5)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.txtCodTrans)
        Me.GbCabecera.Controls.Add(Me.chk_facturar_obsequio)
        Me.GbCabecera.Controls.Add(Me.rdb_f_a4)
        Me.GbCabecera.Controls.Add(Me.rdb_f_ticket)
        Me.GbCabecera.Controls.Add(Me.txtTipoCambio)
        Me.GbCabecera.Controls.Add(Me.Label12)
        Me.GbCabecera.Location = New System.Drawing.Point(506, 368)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(502, 286)
        Me.GbCabecera.TabIndex = 208
        Me.GbCabecera.TabStop = False
        '
        'chk_venta_sin_Descargo
        '
        Me.chk_venta_sin_Descargo.AutoSize = True
        Me.chk_venta_sin_Descargo.ForeColor = System.Drawing.Color.Navy
        Me.chk_venta_sin_Descargo.Location = New System.Drawing.Point(234, 263)
        Me.chk_venta_sin_Descargo.Name = "chk_venta_sin_Descargo"
        Me.chk_venta_sin_Descargo.Size = New System.Drawing.Size(128, 17)
        Me.chk_venta_sin_Descargo.TabIndex = 202
        Me.chk_venta_sin_Descargo.Text = "Facturar sin descargo"
        Me.chk_venta_sin_Descargo.UseVisualStyleBackColor = True
        Me.chk_venta_sin_Descargo.Visible = False
        '
        'btn_facturar_pedido
        '
        Me.btn_facturar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_facturar_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_facturar_pedido.ForeColor = System.Drawing.Color.Red
        Me.btn_facturar_pedido.Image = CType(resources.GetObject("btn_facturar_pedido.Image"), System.Drawing.Image)
        Me.btn_facturar_pedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturar_pedido.Location = New System.Drawing.Point(239, 103)
        Me.btn_facturar_pedido.Name = "btn_facturar_pedido"
        Me.btn_facturar_pedido.Size = New System.Drawing.Size(108, 27)
        Me.btn_facturar_pedido.TabIndex = 201
        Me.btn_facturar_pedido.Text = "Fact. Pedido"
        Me.btn_facturar_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_facturar_pedido.UseVisualStyleBackColor = True
        '
        'chk_venta_cortesia
        '
        Me.chk_venta_cortesia.AutoSize = True
        Me.chk_venta_cortesia.ForeColor = System.Drawing.Color.Navy
        Me.chk_venta_cortesia.Location = New System.Drawing.Point(94, 263)
        Me.chk_venta_cortesia.Name = "chk_venta_cortesia"
        Me.chk_venta_cortesia.Size = New System.Drawing.Size(111, 17)
        Me.chk_venta_cortesia.TabIndex = 200
        Me.chk_venta_cortesia.Text = "Facturar obsequio"
        Me.chk_venta_cortesia.UseVisualStyleBackColor = True
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label105.ForeColor = System.Drawing.Color.Navy
        Me.Label105.Location = New System.Drawing.Point(33, 240)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(52, 13)
        Me.Label105.TabIndex = 199
        Me.Label105.Text = "T.N. Elec"
        '
        'dtpFechaFactura_vcto
        '
        Me.dtpFechaFactura_vcto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaFactura_vcto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura_vcto.Location = New System.Drawing.Point(386, 47)
        Me.dtpFechaFactura_vcto.Name = "dtpFechaFactura_vcto"
        Me.dtpFechaFactura_vcto.Size = New System.Drawing.Size(109, 21)
        Me.dtpFechaFactura_vcto.TabIndex = 197
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label104.ForeColor = System.Drawing.Color.Navy
        Me.Label104.Location = New System.Drawing.Point(311, 51)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(68, 13)
        Me.Label104.TabIndex = 198
        Me.Label104.Text = "Fecha Vcto"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label103.ForeColor = System.Drawing.Color.Navy
        Me.Label103.Location = New System.Drawing.Point(38, 214)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(47, 13)
        Me.Label103.TabIndex = 196
        Me.Label103.Text = "F. Pago"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(120, 194)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(81, 20)
        Me.txtcodigo.TabIndex = 195
        Me.txtcodigo.Visible = False
        '
        'txt_desc_tipo_nota_electronica
        '
        Me.txt_desc_tipo_nota_electronica.BackColor = System.Drawing.Color.White
        Me.txt_desc_tipo_nota_electronica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_tipo_nota_electronica.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_desc_tipo_nota_electronica.ForeColor = System.Drawing.Color.Green
        Me.txt_desc_tipo_nota_electronica.Location = New System.Drawing.Point(164, 236)
        Me.txt_desc_tipo_nota_electronica.Name = "txt_desc_tipo_nota_electronica"
        Me.txt_desc_tipo_nota_electronica.ReadOnly = True
        Me.txt_desc_tipo_nota_electronica.Size = New System.Drawing.Size(330, 21)
        Me.txt_desc_tipo_nota_electronica.TabIndex = 189
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(203, 290)
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
        Me.txt_tip_nota_electronica.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_tip_nota_electronica.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_tip_nota_electronica.Location = New System.Drawing.Point(94, 236)
        Me.txt_tip_nota_electronica.MaxLength = 2
        Me.txt_tip_nota_electronica.Name = "txt_tip_nota_electronica"
        Me.txt_tip_nota_electronica.ReadOnly = True
        Me.txt_tip_nota_electronica.Size = New System.Drawing.Size(64, 21)
        Me.txt_tip_nota_electronica.TabIndex = 188
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(14, 294)
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
        Me.Button5.Location = New System.Drawing.Point(386, 103)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 27)
        Me.Button5.TabIndex = 187
        Me.Button5.Text = "Datos de Ref."
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnclientenuevo
        '
        Me.btnclientenuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientenuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnclientenuevo.ForeColor = System.Drawing.Color.Green
        Me.btnclientenuevo.Image = CType(resources.GetObject("btnclientenuevo.Image"), System.Drawing.Image)
        Me.btnclientenuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclientenuevo.Location = New System.Drawing.Point(94, 103)
        Me.btnclientenuevo.Name = "btnclientenuevo"
        Me.btnclientenuevo.Size = New System.Drawing.Size(136, 27)
        Me.btnclientenuevo.TabIndex = 186
        Me.btnclientenuevo.Text = "C&liente nuevo"
        Me.btnclientenuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclientenuevo.UseVisualStyleBackColor = True
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
        Me.GbdetalleDocumento.Location = New System.Drawing.Point(148, 289)
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
        Me.PictureBox9.Location = New System.Drawing.Point(256, 308)
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
        Me.lblAlmacen.Location = New System.Drawing.Point(329, 15)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.ReadOnly = True
        Me.lblAlmacen.Size = New System.Drawing.Size(166, 21)
        Me.lblAlmacen.TabIndex = 22
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtAlmacen.ForeColor = System.Drawing.Color.Green
        Me.txtAlmacen.Location = New System.Drawing.Point(281, 15)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(42, 21)
        Me.txtAlmacen.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(217, 19)
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
        Me.lblVendedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.ForeColor = System.Drawing.Color.Green
        Me.lblVendedor.Location = New System.Drawing.Point(291, 309)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.ReadOnly = True
        Me.lblVendedor.Size = New System.Drawing.Size(257, 27)
        Me.lblVendedor.TabIndex = 29
        Me.lblVendedor.Visible = False
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
        Me.lblFormaPago.Location = New System.Drawing.Point(164, 210)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.ReadOnly = True
        Me.lblFormaPago.Size = New System.Drawing.Size(330, 21)
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
        Me.lblPtoVenta.Location = New System.Drawing.Point(296, 22)
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
        Me.cboSerieDoc.Location = New System.Drawing.Point(430, 75)
        Me.cboSerieDoc.Name = "cboSerieDoc"
        Me.cboSerieDoc.Size = New System.Drawing.Size(65, 21)
        Me.cboSerieDoc.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(388, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Serie"
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(94, 47)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(109, 21)
        Me.dtpFechaFactura.TabIndex = 2
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboTipoDoc.ForeColor = System.Drawing.Color.Green
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Location = New System.Drawing.Point(319, 75)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(65, 21)
        Me.cboTipoDoc.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(284, 79)
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
        Me.cboMoneda.Location = New System.Drawing.Point(94, 75)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(177, 21)
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
        Me.txtFormaPago.Location = New System.Drawing.Point(94, 210)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(64, 21)
        Me.txtFormaPago.TabIndex = 11
        '
        'txtVendedor
        '
        Me.txtVendedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtVendedor.Location = New System.Drawing.Point(148, 308)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(100, 27)
        Me.txtVendedor.TabIndex = 10
        Me.txtVendedor.Visible = False
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDireccion.ForeColor = System.Drawing.Color.Green
        Me.txtDireccion.Location = New System.Drawing.Point(94, 184)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(400, 21)
        Me.txtDireccion.TabIndex = 28
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.White
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.Green
        Me.txtRazonSocial.Location = New System.Drawing.Point(94, 159)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(400, 21)
        Me.txtRazonSocial.TabIndex = 27
        '
        'txtRucDni
        '
        Me.txtRucDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRucDni.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtRucDni.ForeColor = System.Drawing.Color.Green
        Me.txtRucDni.Location = New System.Drawing.Point(343, 135)
        Me.txtRucDni.Name = "txtRucDni"
        Me.txtRucDni.ReadOnly = True
        Me.txtRucDni.Size = New System.Drawing.Size(151, 21)
        Me.txtRucDni.TabIndex = 26
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodCliente.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCodCliente.Location = New System.Drawing.Point(94, 135)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(137, 21)
        Me.txtCodCliente.TabIndex = 9
        '
        'txtPtoVenta
        '
        Me.txtPtoVenta.BackColor = System.Drawing.Color.Aquamarine
        Me.txtPtoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPtoVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPtoVenta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPtoVenta.Location = New System.Drawing.Point(94, 15)
        Me.txtPtoVenta.Name = "txtPtoVenta"
        Me.txtPtoVenta.Size = New System.Drawing.Size(85, 21)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(32, 79)
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
        Me.Label10.Location = New System.Drawing.Point(58, 311)
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
        Me.Label9.Location = New System.Drawing.Point(26, 187)
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
        Me.Label8.Location = New System.Drawing.Point(30, 163)
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
        Me.Label7.Location = New System.Drawing.Point(279, 138)
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
        Me.Label6.Location = New System.Drawing.Point(38, 138)
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
        Me.Label5.Location = New System.Drawing.Point(44, 51)
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
        Me.Label3.Location = New System.Drawing.Point(28, 19)
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
        'chk_facturar_obsequio
        '
        Me.chk_facturar_obsequio.AutoSize = True
        Me.chk_facturar_obsequio.ForeColor = System.Drawing.Color.Navy
        Me.chk_facturar_obsequio.Location = New System.Drawing.Point(334, 17)
        Me.chk_facturar_obsequio.Name = "chk_facturar_obsequio"
        Me.chk_facturar_obsequio.Size = New System.Drawing.Size(142, 17)
        Me.chk_facturar_obsequio.TabIndex = 194
        Me.chk_facturar_obsequio.Text = "Facturar como Obsequio"
        Me.chk_facturar_obsequio.UseVisualStyleBackColor = True
        Me.chk_facturar_obsequio.Visible = False
        '
        'rdb_f_a4
        '
        Me.rdb_f_a4.AutoSize = True
        Me.rdb_f_a4.ForeColor = System.Drawing.Color.Navy
        Me.rdb_f_a4.Location = New System.Drawing.Point(214, 17)
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
        Me.rdb_f_ticket.Location = New System.Drawing.Point(94, 17)
        Me.rdb_f_ticket.Name = "rdb_f_ticket"
        Me.rdb_f_ticket.Size = New System.Drawing.Size(96, 17)
        Me.rdb_f_ticket.TabIndex = 192
        Me.rdb_f_ticket.TabStop = True
        Me.rdb_f_ticket.Text = "Formato Ticket"
        Me.rdb_f_ticket.UseVisualStyleBackColor = True
        Me.rdb_f_ticket.Visible = False
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.Green
        Me.txtTipoCambio.Location = New System.Drawing.Point(416, 103)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(79, 21)
        Me.txtTipoCambio.TabIndex = 24
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTipoCambio.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(370, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "T.C."
        Me.Label12.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btnEliminar, Me.btnAnular, Me.btn_enviar_mail, Me.btn_Apertura_Doc, Me.btn_descargar_archivos, Me.btn_rep_arqueo_caja, Me.btn_cierre_ventas, Me.btnImprimir, Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1020, 25)
        Me.ToolStrip1.TabIndex = 207
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
        'btnAnular
        '
        Me.btnAnular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(64, 22)
        Me.btnAnular.Text = "&Anular"
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
        'btn_Apertura_Doc
        '
        Me.btn_Apertura_Doc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_Apertura_Doc.Image = CType(resources.GetObject("btn_Apertura_Doc.Image"), System.Drawing.Image)
        Me.btn_Apertura_Doc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Apertura_Doc.Name = "btn_Apertura_Doc"
        Me.btn_Apertura_Doc.Size = New System.Drawing.Size(110, 22)
        Me.btn_Apertura_Doc.Text = "Aperturar Doc."
        Me.btn_Apertura_Doc.Visible = False
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
        'btn_rep_arqueo_caja
        '
        Me.btn_rep_arqueo_caja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_rep_arqueo_caja.Image = CType(resources.GetObject("btn_rep_arqueo_caja.Image"), System.Drawing.Image)
        Me.btn_rep_arqueo_caja.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_rep_arqueo_caja.Name = "btn_rep_arqueo_caja"
        Me.btn_rep_arqueo_caja.Size = New System.Drawing.Size(124, 22)
        Me.btn_rep_arqueo_caja.Text = "Rep. Arqueo Caja"
        '
        'btn_cierre_ventas
        '
        Me.btn_cierre_ventas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cierre_ventas.Image = CType(resources.GetObject("btn_cierre_ventas.Image"), System.Drawing.Image)
        Me.btn_cierre_ventas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cierre_ventas.Name = "btn_cierre_ventas"
        Me.btn_cierre_ventas.Size = New System.Drawing.Size(143, 22)
        Me.btn_cierre_ventas.Text = "Cierre de Ventas(F7)"
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
        Me.btn_salir.Size = New System.Drawing.Size(52, 20)
        Me.btn_salir.Text = "&Salir"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.txtcantidad_equivalente)
        Me.GroupBox5.Controls.Add(Me.btn_cal_cantidad)
        Me.GroupBox5.Controls.Add(Me.txtprecioTotal)
        Me.GroupBox5.Controls.Add(Me.Label98)
        Me.GroupBox5.Controls.Add(Me.txt_observaciones)
        Me.GroupBox5.Controls.Add(Me.Label86)
        Me.GroupBox5.Controls.Add(Me.txtcantidad_fraccion)
        Me.GroupBox5.Controls.Add(Me.Label95)
        Me.GroupBox5.Controls.Add(Me.txtprecioUnitario_fraccion)
        Me.GroupBox5.Controls.Add(Me.Label93)
        Me.GroupBox5.Controls.Add(Me.txt_numero_lote)
        Me.GroupBox5.Controls.Add(Me.Label90)
        Me.GroupBox5.Controls.Add(Me.txt_por_Des)
        Me.GroupBox5.Controls.Add(Me.Label83)
        Me.GroupBox5.Controls.Add(Me.txtStock)
        Me.GroupBox5.Controls.Add(Me.Label68)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.btn_agregar_carrito)
        Me.GroupBox5.Controls.Add(Me.txtcantidad)
        Me.GroupBox5.Controls.Add(Me.txtprecioUnitario)
        Me.GroupBox5.Controls.Add(Me.Label66)
        Me.GroupBox5.Controls.Add(Me.Label67)
        Me.GroupBox5.Controls.Add(Me.Label65)
        Me.GroupBox5.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox5.Controls.Add(Me.Label61)
        Me.GroupBox5.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(17, 54)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(991, 94)
        Me.GroupBox5.TabIndex = 212
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle del Producto"
        '
        'txtcantidad_equivalente
        '
        Me.txtcantidad_equivalente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad_equivalente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad_equivalente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad_equivalente.Location = New System.Drawing.Point(797, 44)
        Me.txtcantidad_equivalente.Name = "txtcantidad_equivalente"
        Me.txtcantidad_equivalente.Size = New System.Drawing.Size(90, 21)
        Me.txtcantidad_equivalente.TabIndex = 204
        Me.txtcantidad_equivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcantidad_equivalente.Visible = False
        '
        'btn_cal_cantidad
        '
        Me.btn_cal_cantidad.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cal_cantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cal_cantidad.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cal_cantidad.ForeColor = System.Drawing.Color.Navy
        Me.btn_cal_cantidad.Image = CType(resources.GetObject("btn_cal_cantidad.Image"), System.Drawing.Image)
        Me.btn_cal_cantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cal_cantidad.Location = New System.Drawing.Point(163, 44)
        Me.btn_cal_cantidad.Name = "btn_cal_cantidad"
        Me.btn_cal_cantidad.Size = New System.Drawing.Size(27, 22)
        Me.btn_cal_cantidad.TabIndex = 203
        Me.btn_cal_cantidad.Text = "&LIMPIAR"
        Me.btn_cal_cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cal_cantidad.UseVisualStyleBackColor = True
        Me.btn_cal_cantidad.Visible = False
        '
        'txtprecioTotal
        '
        Me.txtprecioTotal.BackColor = System.Drawing.Color.White
        Me.txtprecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecioTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecioTotal.Location = New System.Drawing.Point(277, 44)
        Me.txtprecioTotal.Name = "txtprecioTotal"
        Me.txtprecioTotal.Size = New System.Drawing.Size(96, 21)
        Me.txtprecioTotal.TabIndex = 201
        Me.txtprecioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label98.ForeColor = System.Drawing.Color.Navy
        Me.Label98.Location = New System.Drawing.Point(199, 48)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(74, 13)
        Me.Label98.TabIndex = 202
        Me.Label98.Text = "Precio Total"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(71, 68)
        Me.txt_observaciones.MaxLength = 200
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(914, 21)
        Me.txt_observaciones.TabIndex = 200
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label86.ForeColor = System.Drawing.Color.Navy
        Me.Label86.Location = New System.Drawing.Point(36, 72)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(31, 13)
        Me.Label86.TabIndex = 199
        Me.Label86.Text = "Obs."
        '
        'txtcantidad_fraccion
        '
        Me.txtcantidad_fraccion.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad_fraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad_fraccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad_fraccion.Location = New System.Drawing.Point(277, 92)
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
        Me.Label95.Location = New System.Drawing.Point(217, 96)
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
        Me.txtprecioUnitario_fraccion.Location = New System.Drawing.Point(679, 91)
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
        Me.Label93.Location = New System.Drawing.Point(603, 95)
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
        Me.txt_numero_lote.Location = New System.Drawing.Point(824, 92)
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
        Me.Label90.Location = New System.Drawing.Point(770, 96)
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
        Me.txt_por_Des.Location = New System.Drawing.Point(618, 92)
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
        Me.Label83.Location = New System.Drawing.Point(556, 96)
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
        Me.txtStock.Location = New System.Drawing.Point(432, 92)
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
        Me.Label68.Location = New System.Drawing.Point(384, 96)
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
        Me.Button9.Location = New System.Drawing.Point(596, 43)
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
        Me.btn_agregar_carrito.Location = New System.Drawing.Point(601, 45)
        Me.btn_agregar_carrito.Name = "btn_agregar_carrito"
        Me.btn_agregar_carrito.Size = New System.Drawing.Size(177, 19)
        Me.btn_agregar_carrito.TabIndex = 187
        Me.btn_agregar_carrito.Text = "AÑADIR AL CARRITO"
        Me.btn_agregar_carrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar_carrito.UseVisualStyleBackColor = True
        Me.btn_agregar_carrito.Visible = False
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(71, 44)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(90, 21)
        Me.txtcantidad.TabIndex = 114
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.BackColor = System.Drawing.Color.White
        Me.txtprecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecioUnitario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecioUnitario.Location = New System.Drawing.Point(489, 44)
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
        Me.Label67.Location = New System.Drawing.Point(412, 48)
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
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(708, 21)
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
        Me.GroupBox6.Location = New System.Drawing.Point(17, 515)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(483, 62)
        Me.GroupBox6.TabIndex = 213
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
        Me.TextBox19.Size = New System.Drawing.Size(465, 35)
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
        Me.txtIsc.Location = New System.Drawing.Point(377, 34)
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
        Me.Label71.Location = New System.Drawing.Point(335, 38)
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
        Me.txtDescuentos.Location = New System.Drawing.Point(377, -10)
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
        Me.Label23.Location = New System.Drawing.Point(300, -6)
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
        Me.txtBruto.Location = New System.Drawing.Point(163, 18)
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
        Me.Label16.Location = New System.Drawing.Point(115, 21)
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
        Me.txtPrecioVenta.Location = New System.Drawing.Point(170, 40)
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
        Me.Label28.Location = New System.Drawing.Point(125, 42)
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
        Me.txtIgv.Location = New System.Drawing.Point(377, 11)
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
        Me.Label24.Location = New System.Drawing.Point(334, 16)
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
        Me.txtvalorVenta.Location = New System.Drawing.Point(377, -32)
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
        Me.Label22.Location = New System.Drawing.Point(314, -29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 201
        Me.Label22.Text = "V. Venta"
        Me.Label22.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.dgv_lista_productos)
        Me.GroupBox7.Controls.Add(Me.txt_buscador_productos)
        Me.GroupBox7.Controls.Add(Me.txt_buscador_especial)
        Me.GroupBox7.Controls.Add(Me.PictureBox16)
        Me.GroupBox7.Controls.Add(Me.PictureBox17)
        Me.GroupBox7.Controls.Add(Me.PictureBox18)
        Me.GroupBox7.Controls.Add(Me.TextBox21)
        Me.GroupBox7.Controls.Add(Me.Label62)
        Me.GroupBox7.Controls.Add(Me.TextBox22)
        Me.GroupBox7.Controls.Add(Me.Label63)
        Me.GroupBox7.Controls.Add(Me.TextBox23)
        Me.GroupBox7.Controls.Add(Me.Label64)
        Me.GroupBox7.Controls.Add(Me.PictureBox19)
        Me.GroupBox7.Controls.Add(Me.PictureBox20)
        Me.GroupBox7.Controls.Add(Me.RadioButton1)
        Me.GroupBox7.Controls.Add(Me.RadioButton2)
        Me.GroupBox7.Controls.Add(Me.Label69)
        Me.GroupBox7.Controls.Add(Me.TextBox33)
        Me.GroupBox7.Controls.Add(Me.TextBox34)
        Me.GroupBox7.Controls.Add(Me.Label70)
        Me.GroupBox7.Controls.Add(Me.TextBox35)
        Me.GroupBox7.Controls.Add(Me.ComboBox1)
        Me.GroupBox7.Controls.Add(Me.Label72)
        Me.GroupBox7.Controls.Add(Me.TextBox37)
        Me.GroupBox7.Controls.Add(Me.Label73)
        Me.GroupBox7.Controls.Add(Me.TextBox38)
        Me.GroupBox7.Controls.Add(Me.Label74)
        Me.GroupBox7.Controls.Add(Me.TextBox39)
        Me.GroupBox7.Controls.Add(Me.Label75)
        Me.GroupBox7.Controls.Add(Me.TextBox40)
        Me.GroupBox7.Controls.Add(Me.Label76)
        Me.GroupBox7.Controls.Add(Me.TextBox41)
        Me.GroupBox7.Controls.Add(Me.PictureBox22)
        Me.GroupBox7.Controls.Add(Me.TextBox42)
        Me.GroupBox7.Controls.Add(Me.Label77)
        Me.GroupBox7.Controls.Add(Me.TextBox43)
        Me.GroupBox7.Controls.Add(Me.PictureBox23)
        Me.GroupBox7.Controls.Add(Me.TextBox44)
        Me.GroupBox7.Controls.Add(Me.Label78)
        Me.GroupBox7.Controls.Add(Me.TextBox45)
        Me.GroupBox7.Controls.Add(Me.PictureBox24)
        Me.GroupBox7.Controls.Add(Me.TextBox46)
        Me.GroupBox7.Controls.Add(Me.Label79)
        Me.GroupBox7.Controls.Add(Me.TextBox47)
        Me.GroupBox7.Controls.Add(Me.Label80)
        Me.GroupBox7.Controls.Add(Me.TextBox49)
        Me.GroupBox7.Controls.Add(Me.TextBox51)
        Me.GroupBox7.Controls.Add(Me.Label81)
        Me.GroupBox7.Controls.Add(Me.Label82)
        Me.GroupBox7.Controls.Add(Me.TextBox52)
        Me.GroupBox7.Controls.Add(Me.PictureBox27)
        Me.GroupBox7.Controls.Add(Me.ComboBox2)
        Me.GroupBox7.Controls.Add(Me.Label85)
        Me.GroupBox7.Controls.Add(Me.TextBox61)
        Me.GroupBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(17, 154)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(991, 211)
        Me.GroupBox7.TabIndex = 214
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Productos"
        '
        'dgv_lista_productos
        '
        Me.dgv_lista_productos.AllowUserToAddRows = False
        Me.dgv_lista_productos.AllowUserToDeleteRows = False
        Me.dgv_lista_productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle41.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lista_productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle41
        Me.dgv_lista_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_productos.EnableHeadersVisualStyles = False
        Me.dgv_lista_productos.Location = New System.Drawing.Point(12, 49)
        Me.dgv_lista_productos.Name = "dgv_lista_productos"
        Me.dgv_lista_productos.ReadOnly = True
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle42.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lista_productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle42
        Me.dgv_lista_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_productos.Size = New System.Drawing.Size(969, 150)
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
        Me.txt_buscador_productos.Size = New System.Drawing.Size(969, 21)
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
        Me.txt_buscador_especial.Size = New System.Drawing.Size(617, 21)
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
        'panel_cliente_nuevo
        '
        Me.panel_cliente_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_cliente_nuevo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.panel_cliente_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_cliente_nuevo.Controls.Add(Me.GroupBox14)
        Me.panel_cliente_nuevo.Location = New System.Drawing.Point(506, 322)
        Me.panel_cliente_nuevo.Name = "panel_cliente_nuevo"
        Me.panel_cliente_nuevo.Size = New System.Drawing.Size(502, 326)
        Me.panel_cliente_nuevo.TabIndex = 215
        Me.panel_cliente_nuevo.Visible = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox14.Controls.Add(Me.Button22)
        Me.GroupBox14.Controls.Add(Me.Button21)
        Me.GroupBox14.Controls.Add(Me.Label15)
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
        Me.GroupBox14.Controls.Add(Me.Label21)
        Me.GroupBox14.Controls.Add(Me.TextBox6)
        Me.GroupBox14.Controls.Add(Me.btn_cancelar_nuevo_cliente)
        Me.GroupBox14.Controls.Add(Me.btn_grabar_nuevo_cliente)
        Me.GroupBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox14.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(480, 314)
        Me.GroupBox14.TabIndex = 211
        Me.GroupBox14.TabStop = False
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(58, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 16)
        Me.Label15.TabIndex = 244
        Me.Label15.Text = "Dirección"
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
        Me.txt_correo.Location = New System.Drawing.Point(135, 222)
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
        Me.Label56.Location = New System.Drawing.Point(73, 225)
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
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(325, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(108, 19)
        Me.Label21.TabIndex = 214
        Me.Label21.Text = "Cod. Cliente"
        Me.Label21.Visible = False
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
        Me.TextBox6.Size = New System.Drawing.Size(474, 20)
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
        Me.btn_cancelar_nuevo_cliente.Location = New System.Drawing.Point(246, 254)
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
        Me.btn_grabar_nuevo_cliente.Location = New System.Drawing.Point(116, 254)
        Me.btn_grabar_nuevo_cliente.Name = "btn_grabar_nuevo_cliente"
        Me.btn_grabar_nuevo_cliente.Size = New System.Drawing.Size(115, 51)
        Me.btn_grabar_nuevo_cliente.TabIndex = 209
        Me.btn_grabar_nuevo_cliente.Text = "G&rabar"
        Me.btn_grabar_nuevo_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar_nuevo_cliente.UseVisualStyleBackColor = True
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
        Me.gbTipoFacturacion.Location = New System.Drawing.Point(9, 57)
        Me.gbTipoFacturacion.Name = "gbTipoFacturacion"
        Me.gbTipoFacturacion.Size = New System.Drawing.Size(1002, 34)
        Me.gbTipoFacturacion.TabIndex = 216
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
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.rbVariaslineasDoc)
        Me.GroupBox8.Controls.Add(Me.rbunalineaDoc)
        Me.GroupBox8.Controls.Add(Me.txtGlosa)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(435, 273)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(151, 37)
        Me.GroupBox8.TabIndex = 217
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
        Me.rbunalineaDoc.Location = New System.Drawing.Point(500, 300)
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
        Me.gbTipoGuia.Location = New System.Drawing.Point(493, 313)
        Me.gbTipoGuia.Name = "gbTipoGuia"
        Me.gbTipoGuia.Size = New System.Drawing.Size(34, 37)
        Me.gbTipoGuia.TabIndex = 218
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
        'pnl_ref
        '
        Me.pnl_ref.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_ref.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnl_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_ref.Controls.Add(Me.GroupBox1)
        Me.pnl_ref.Location = New System.Drawing.Point(506, 370)
        Me.pnl_ref.Name = "pnl_ref"
        Me.pnl_ref.Size = New System.Drawing.Size(502, 237)
        Me.pnl_ref.TabIndex = 219
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
        'pnl_cierre_ventas
        '
        Me.pnl_cierre_ventas.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_cierre_ventas.Controls.Add(Me.TextBox25)
        Me.pnl_cierre_ventas.Controls.Add(Me.GroupBox9)
        Me.pnl_cierre_ventas.Location = New System.Drawing.Point(352, 32)
        Me.pnl_cierre_ventas.Name = "pnl_cierre_ventas"
        Me.pnl_cierre_ventas.Size = New System.Drawing.Size(539, 525)
        Me.pnl_cierre_ventas.TabIndex = 221
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
        Me.TextBox25.Size = New System.Drawing.Size(539, 25)
        Me.TextBox25.TabIndex = 168
        Me.TextBox25.Text = "CIERRE DE VENTAS"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txt_cobro_venta_anterior)
        Me.GroupBox9.Controls.Add(Me.Label106)
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
        Me.GroupBox9.Size = New System.Drawing.Size(514, 487)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        '
        'txt_cobro_venta_anterior
        '
        Me.txt_cobro_venta_anterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cobro_venta_anterior.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cobro_venta_anterior.ForeColor = System.Drawing.Color.Maroon
        Me.txt_cobro_venta_anterior.Location = New System.Drawing.Point(178, 379)
        Me.txt_cobro_venta_anterior.Name = "txt_cobro_venta_anterior"
        Me.txt_cobro_venta_anterior.Size = New System.Drawing.Size(135, 26)
        Me.txt_cobro_venta_anterior.TabIndex = 242
        Me.txt_cobro_venta_anterior.Text = "0"
        Me.txt_cobro_venta_anterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label106.ForeColor = System.Drawing.Color.Green
        Me.Label106.Location = New System.Drawing.Point(19, 383)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(150, 19)
        Me.Label106.TabIndex = 241
        Me.Label106.Text = "Cobro Venta anterior"
        '
        'gb_pago_tarjeta
        '
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox26)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox28)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_interbank)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_scotiabank)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox1)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox15)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox21)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox25)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_plin)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_yape)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_bbva)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_bcp)
        Me.gb_pago_tarjeta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_pago_tarjeta.ForeColor = System.Drawing.Color.Green
        Me.gb_pago_tarjeta.Location = New System.Drawing.Point(9, 165)
        Me.gb_pago_tarjeta.Name = "gb_pago_tarjeta"
        Me.gb_pago_tarjeta.Size = New System.Drawing.Size(494, 201)
        Me.gb_pago_tarjeta.TabIndex = 240
        Me.gb_pago_tarjeta.TabStop = False
        Me.gb_pago_tarjeta.Text = "Cobro con Tarjeta"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(256, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(17, 140)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 10
        Me.PictureBox15.TabStop = False
        '
        'PictureBox21
        '
        Me.PictureBox21.Image = CType(resources.GetObject("PictureBox21.Image"), System.Drawing.Image)
        Me.PictureBox21.Location = New System.Drawing.Point(17, 84)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox21.TabIndex = 9
        Me.PictureBox21.TabStop = False
        '
        'PictureBox25
        '
        Me.PictureBox25.Image = CType(resources.GetObject("PictureBox25.Image"), System.Drawing.Image)
        Me.PictureBox25.Location = New System.Drawing.Point(17, 28)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox25.TabIndex = 8
        Me.PictureBox25.TabStop = False
        '
        'txt_plin
        '
        Me.txt_plin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_plin.ForeColor = System.Drawing.Color.Maroon
        Me.txt_plin.Location = New System.Drawing.Point(368, 151)
        Me.txt_plin.Name = "txt_plin"
        Me.txt_plin.Size = New System.Drawing.Size(114, 26)
        Me.txt_plin.TabIndex = 7
        Me.txt_plin.Text = "0"
        Me.txt_plin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_yape
        '
        Me.txt_yape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_yape.ForeColor = System.Drawing.Color.Maroon
        Me.txt_yape.Location = New System.Drawing.Point(129, 151)
        Me.txt_yape.Name = "txt_yape"
        Me.txt_yape.Size = New System.Drawing.Size(114, 26)
        Me.txt_yape.TabIndex = 6
        Me.txt_yape.Text = "0"
        Me.txt_yape.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_bbva
        '
        Me.txt_bbva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bbva.ForeColor = System.Drawing.Color.Maroon
        Me.txt_bbva.Location = New System.Drawing.Point(129, 95)
        Me.txt_bbva.Name = "txt_bbva"
        Me.txt_bbva.Size = New System.Drawing.Size(114, 26)
        Me.txt_bbva.TabIndex = 5
        Me.txt_bbva.Text = "0"
        Me.txt_bbva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_bcp
        '
        Me.txt_bcp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bcp.ForeColor = System.Drawing.Color.Maroon
        Me.txt_bcp.Location = New System.Drawing.Point(129, 39)
        Me.txt_bcp.Name = "txt_bcp"
        Me.txt_bcp.Size = New System.Drawing.Size(114, 26)
        Me.txt_bcp.TabIndex = 4
        Me.txt_bcp.Text = "0"
        Me.txt_bcp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gb_pago_efectivo
        '
        Me.gb_pago_efectivo.Controls.Add(Me.TxEfeDol)
        Me.gb_pago_efectivo.Controls.Add(Me.txt_saldo_final)
        Me.gb_pago_efectivo.Controls.Add(Me.Label96)
        Me.gb_pago_efectivo.Controls.Add(Me.Label97)
        Me.gb_pago_efectivo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_pago_efectivo.ForeColor = System.Drawing.Color.Green
        Me.gb_pago_efectivo.Location = New System.Drawing.Point(9, 89)
        Me.gb_pago_efectivo.Name = "gb_pago_efectivo"
        Me.gb_pago_efectivo.Size = New System.Drawing.Size(494, 59)
        Me.gb_pago_efectivo.TabIndex = 239
        Me.gb_pago_efectivo.TabStop = False
        Me.gb_pago_efectivo.Text = "Cobro en Efectivo"
        '
        'TxEfeDol
        '
        Me.TxEfeDol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxEfeDol.ForeColor = System.Drawing.Color.Maroon
        Me.TxEfeDol.Location = New System.Drawing.Point(153, 70)
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
        Me.txt_saldo_final.Location = New System.Drawing.Point(153, 24)
        Me.txt_saldo_final.Name = "txt_saldo_final"
        Me.txt_saldo_final.Size = New System.Drawing.Size(135, 26)
        Me.txt_saldo_final.TabIndex = 2
        Me.txt_saldo_final.Text = "0"
        Me.txt_saldo_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label96.Location = New System.Drawing.Point(81, 74)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(62, 19)
        Me.Label96.TabIndex = 1
        Me.Label96.Text = "Dolares"
        Me.Label96.Visible = False
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(98, 28)
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
        Me.Button11.Location = New System.Drawing.Point(268, 425)
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
        Me.Button12.Location = New System.Drawing.Point(176, 425)
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
        Me.pnlNuevaPlanilla.Location = New System.Drawing.Point(352, 36)
        Me.pnlNuevaPlanilla.Name = "pnlNuevaPlanilla"
        Me.pnlNuevaPlanilla.Size = New System.Drawing.Size(306, 223)
        Me.pnlNuevaPlanilla.TabIndex = 222
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
        Me.TextBox24.Size = New System.Drawing.Size(306, 20)
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
        'pnl_motivo_anulacion
        '
        Me.pnl_motivo_anulacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_motivo_anulacion.Controls.Add(Me.txt_motivo_anulacion)
        Me.pnl_motivo_anulacion.Controls.Add(Me.TextBox20)
        Me.pnl_motivo_anulacion.Controls.Add(Me.GroupBox19)
        Me.pnl_motivo_anulacion.Controls.Add(Me.GroupBox20)
        Me.pnl_motivo_anulacion.Location = New System.Drawing.Point(352, 33)
        Me.pnl_motivo_anulacion.Name = "pnl_motivo_anulacion"
        Me.pnl_motivo_anulacion.Size = New System.Drawing.Size(441, 129)
        Me.pnl_motivo_anulacion.TabIndex = 220
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
        Me.GroupBox19.Controls.Add(Me.lbl_numero_documento)
        Me.GroupBox19.Controls.Add(Me.Label87)
        Me.GroupBox19.Controls.Add(Me.btn_cancelar_anulacion)
        Me.GroupBox19.Controls.Add(Me.btn_confirmar_anulacion)
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
        'lbl_numero_documento
        '
        Me.lbl_numero_documento.AutoSize = True
        Me.lbl_numero_documento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero_documento.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_numero_documento.Location = New System.Drawing.Point(126, 12)
        Me.lbl_numero_documento.Name = "lbl_numero_documento"
        Me.lbl_numero_documento.Size = New System.Drawing.Size(16, 13)
        Me.lbl_numero_documento.TabIndex = 124
        Me.lbl_numero_documento.Text = "..."
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
        'btn_cancelar_anulacion
        '
        Me.btn_cancelar_anulacion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancelar_anulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_anulacion.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancelar_anulacion.Image = CType(resources.GetObject("btn_cancelar_anulacion.Image"), System.Drawing.Image)
        Me.btn_cancelar_anulacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar_anulacion.Location = New System.Drawing.Point(329, 12)
        Me.btn_cancelar_anulacion.Name = "btn_cancelar_anulacion"
        Me.btn_cancelar_anulacion.Size = New System.Drawing.Size(62, 37)
        Me.btn_cancelar_anulacion.TabIndex = 121
        Me.btn_cancelar_anulacion.Text = "Cancelar"
        Me.btn_cancelar_anulacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar_anulacion.UseVisualStyleBackColor = True
        '
        'btn_confirmar_anulacion
        '
        Me.btn_confirmar_anulacion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_confirmar_anulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar_anulacion.ForeColor = System.Drawing.Color.Navy
        Me.btn_confirmar_anulacion.Image = CType(resources.GetObject("btn_confirmar_anulacion.Image"), System.Drawing.Image)
        Me.btn_confirmar_anulacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_confirmar_anulacion.Location = New System.Drawing.Point(259, 12)
        Me.btn_confirmar_anulacion.Name = "btn_confirmar_anulacion"
        Me.btn_confirmar_anulacion.Size = New System.Drawing.Size(62, 37)
        Me.btn_confirmar_anulacion.TabIndex = 122
        Me.btn_confirmar_anulacion.Text = "Confirmar"
        Me.btn_confirmar_anulacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_confirmar_anulacion.UseVisualStyleBackColor = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Location = New System.Drawing.Point(8, 79)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(425, 43)
        Me.GroupBox20.TabIndex = 201
        Me.GroupBox20.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.TextBox13)
        Me.Panel1.Controls.Add(Me.GroupBox10)
        Me.Panel1.Location = New System.Drawing.Point(352, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 223)
        Me.Panel1.TabIndex = 223
        Me.Panel1.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.Navy
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox13.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox13.ForeColor = System.Drawing.Color.White
        Me.TextBox13.Location = New System.Drawing.Point(0, 0)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(448, 20)
        Me.TextBox13.TabIndex = 170
        Me.TextBox13.Text = "REPORTE DE ARQUEO DE CAJA"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox10.Controls.Add(Me.rb_detallado)
        Me.GroupBox10.Controls.Add(Me.rb_resumido)
        Me.GroupBox10.Controls.Add(Me.chkTodosPersonal)
        Me.GroupBox10.Controls.Add(Me.txt_des_personal)
        Me.GroupBox10.Controls.Add(Me.txt_cod_personal)
        Me.GroupBox10.Controls.Add(Me.Label99)
        Me.GroupBox10.Controls.Add(Me.checkConceptos)
        Me.GroupBox10.Controls.Add(Me.txt_des_concepto)
        Me.GroupBox10.Controls.Add(Me.txt_cod_concepto)
        Me.GroupBox10.Controls.Add(Me.Label100)
        Me.GroupBox10.Controls.Add(Me.dtp_rep_fin)
        Me.GroupBox10.Controls.Add(Me.dtp_rep_ini)
        Me.GroupBox10.Controls.Add(Me.Label101)
        Me.GroupBox10.Controls.Add(Me.Label102)
        Me.GroupBox10.Controls.Add(Me.Button3)
        Me.GroupBox10.Controls.Add(Me.Button4)
        Me.GroupBox10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox10.Location = New System.Drawing.Point(10, 24)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(423, 189)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        '
        'rb_detallado
        '
        Me.rb_detallado.AutoSize = True
        Me.rb_detallado.Location = New System.Drawing.Point(229, 102)
        Me.rb_detallado.Name = "rb_detallado"
        Me.rb_detallado.Size = New System.Drawing.Size(79, 17)
        Me.rb_detallado.TabIndex = 192
        Me.rb_detallado.Text = "Detallado"
        Me.rb_detallado.UseVisualStyleBackColor = True
        '
        'rb_resumido
        '
        Me.rb_resumido.AutoSize = True
        Me.rb_resumido.Checked = True
        Me.rb_resumido.Location = New System.Drawing.Point(117, 102)
        Me.rb_resumido.Name = "rb_resumido"
        Me.rb_resumido.Size = New System.Drawing.Size(81, 17)
        Me.rb_resumido.TabIndex = 191
        Me.rb_resumido.TabStop = True
        Me.rb_resumido.Text = "Resumido"
        Me.rb_resumido.UseVisualStyleBackColor = True
        '
        'chkTodosPersonal
        '
        Me.chkTodosPersonal.AutoSize = True
        Me.chkTodosPersonal.ForeColor = System.Drawing.Color.Navy
        Me.chkTodosPersonal.Location = New System.Drawing.Point(26, 200)
        Me.chkTodosPersonal.Name = "chkTodosPersonal"
        Me.chkTodosPersonal.Size = New System.Drawing.Size(144, 17)
        Me.chkTodosPersonal.TabIndex = 190
        Me.chkTodosPersonal.Text = "&Todos los personales"
        Me.chkTodosPersonal.UseVisualStyleBackColor = True
        Me.chkTodosPersonal.Visible = False
        '
        'txt_des_personal
        '
        Me.txt_des_personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_personal.Location = New System.Drawing.Point(175, 66)
        Me.txt_des_personal.Name = "txt_des_personal"
        Me.txt_des_personal.ReadOnly = True
        Me.txt_des_personal.Size = New System.Drawing.Size(239, 21)
        Me.txt_des_personal.TabIndex = 189
        '
        'txt_cod_personal
        '
        Me.txt_cod_personal.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_personal.Location = New System.Drawing.Point(94, 66)
        Me.txt_cod_personal.Name = "txt_cod_personal"
        Me.txt_cod_personal.ReadOnly = True
        Me.txt_cod_personal.Size = New System.Drawing.Size(75, 21)
        Me.txt_cod_personal.TabIndex = 187
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.ForeColor = System.Drawing.Color.Navy
        Me.Label99.Location = New System.Drawing.Point(26, 69)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(56, 13)
        Me.Label99.TabIndex = 188
        Me.Label99.Text = "Personal"
        '
        'checkConceptos
        '
        Me.checkConceptos.AutoSize = True
        Me.checkConceptos.ForeColor = System.Drawing.Color.Navy
        Me.checkConceptos.Location = New System.Drawing.Point(26, 224)
        Me.checkConceptos.Name = "checkConceptos"
        Me.checkConceptos.Size = New System.Drawing.Size(140, 17)
        Me.checkConceptos.TabIndex = 186
        Me.checkConceptos.Text = "&Todos los conceptos"
        Me.checkConceptos.UseVisualStyleBackColor = True
        Me.checkConceptos.Visible = False
        '
        'txt_des_concepto
        '
        Me.txt_des_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_concepto.Location = New System.Drawing.Point(175, 244)
        Me.txt_des_concepto.Name = "txt_des_concepto"
        Me.txt_des_concepto.ReadOnly = True
        Me.txt_des_concepto.Size = New System.Drawing.Size(252, 21)
        Me.txt_des_concepto.TabIndex = 185
        Me.txt_des_concepto.Visible = False
        '
        'txt_cod_concepto
        '
        Me.txt_cod_concepto.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_concepto.Location = New System.Drawing.Point(94, 244)
        Me.txt_cod_concepto.Name = "txt_cod_concepto"
        Me.txt_cod_concepto.ReadOnly = True
        Me.txt_cod_concepto.Size = New System.Drawing.Size(75, 21)
        Me.txt_cod_concepto.TabIndex = 183
        Me.txt_cod_concepto.Visible = False
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.ForeColor = System.Drawing.Color.Navy
        Me.Label100.Location = New System.Drawing.Point(22, 247)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(66, 13)
        Me.Label100.TabIndex = 184
        Me.Label100.Text = "Conceptos"
        Me.Label100.Visible = False
        '
        'dtp_rep_fin
        '
        Me.dtp_rep_fin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_rep_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_rep_fin.Location = New System.Drawing.Point(291, 193)
        Me.dtp_rep_fin.Name = "dtp_rep_fin"
        Me.dtp_rep_fin.Size = New System.Drawing.Size(101, 21)
        Me.dtp_rep_fin.TabIndex = 13
        Me.dtp_rep_fin.Visible = False
        '
        'dtp_rep_ini
        '
        Me.dtp_rep_ini.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_rep_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_rep_ini.Location = New System.Drawing.Point(94, 31)
        Me.dtp_rep_ini.Name = "dtp_rep_ini"
        Me.dtp_rep_ini.Size = New System.Drawing.Size(106, 21)
        Me.dtp_rep_ini.TabIndex = 12
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label101.ForeColor = System.Drawing.Color.Navy
        Me.Label101.Location = New System.Drawing.Point(214, 196)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(72, 13)
        Me.Label101.TabIndex = 10
        Me.Label101.Text = "Fecha. Final"
        Me.Label101.Visible = False
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label102.ForeColor = System.Drawing.Color.Navy
        Me.Label102.Location = New System.Drawing.Point(42, 34)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(40, 13)
        Me.Label102.TabIndex = 11
        Me.Label102.Text = "Fecha"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(229, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 39)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "&Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(117, 131)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 39)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "      &Mostrar " & Global.Microsoft.VisualBasic.ChrW(13) & "      Reporte"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'pnlDocumentosGuiaVenta
        '
        Me.pnlDocumentosGuiaVenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlDocumentosGuiaVenta.Controls.Add(Me.lblDetalle)
        Me.pnlDocumentosGuiaVenta.Controls.Add(Me.GroupBox11)
        Me.pnlDocumentosGuiaVenta.Location = New System.Drawing.Point(352, 31)
        Me.pnlDocumentosGuiaVenta.Name = "pnlDocumentosGuiaVenta"
        Me.pnlDocumentosGuiaVenta.Size = New System.Drawing.Size(462, 336)
        Me.pnlDocumentosGuiaVenta.TabIndex = 224
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
        Me.lblDetalle.Size = New System.Drawing.Size(464, 20)
        Me.lblDetalle.TabIndex = 169
        Me.lblDetalle.Text = "LISTA DE PEDIDOS"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox11
        '
        Me.GroupBox11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox11.Controls.Add(Me.btn_close)
        Me.GroupBox11.Controls.Add(Me.btn_ok)
        Me.GroupBox11.Controls.Add(Me.GroupBox12)
        Me.GroupBox11.Controls.Add(Me.dgvDocumentosCliente)
        Me.GroupBox11.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(432, 307)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(328, 30)
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
        Me.btn_ok.Location = New System.Drawing.Point(278, 30)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(49, 32)
        Me.btn_ok.TabIndex = 122
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.txtFiltroCliente)
        Me.GroupBox12.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox12.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(262, 45)
        Me.GroupBox12.TabIndex = 120
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Ingrese Nro Documento  a Buscar :"
        '
        'txtFiltroCliente
        '
        Me.txtFiltroCliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroCliente.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroCliente.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltroCliente.Name = "txtFiltroCliente"
        Me.txtFiltroCliente.Size = New System.Drawing.Size(247, 22)
        Me.txtFiltroCliente.TabIndex = 24
        '
        'dgvDocumentosCliente
        '
        Me.dgvDocumentosCliente.AllowUserToAddRows = False
        Me.dgvDocumentosCliente.AllowUserToDeleteRows = False
        Me.dgvDocumentosCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentosCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvDocumentosCliente.Location = New System.Drawing.Point(12, 71)
        Me.dgvDocumentosCliente.Name = "dgvDocumentosCliente"
        Me.dgvDocumentosCliente.Size = New System.Drawing.Size(403, 228)
        Me.dgvDocumentosCliente.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Seleccionar"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'PictureBox26
        '
        Me.PictureBox26.Image = CType(resources.GetObject("PictureBox26.Image"), System.Drawing.Image)
        Me.PictureBox26.Location = New System.Drawing.Point(256, 84)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox26.TabIndex = 15
        Me.PictureBox26.TabStop = False
        '
        'PictureBox28
        '
        Me.PictureBox28.Image = CType(resources.GetObject("PictureBox28.Image"), System.Drawing.Image)
        Me.PictureBox28.Location = New System.Drawing.Point(256, 28)
        Me.PictureBox28.Name = "PictureBox28"
        Me.PictureBox28.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox28.TabIndex = 14
        Me.PictureBox28.TabStop = False
        '
        'txt_interbank
        '
        Me.txt_interbank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_interbank.ForeColor = System.Drawing.Color.Maroon
        Me.txt_interbank.Location = New System.Drawing.Point(368, 95)
        Me.txt_interbank.Name = "txt_interbank"
        Me.txt_interbank.Size = New System.Drawing.Size(114, 26)
        Me.txt_interbank.TabIndex = 13
        Me.txt_interbank.Text = "0"
        Me.txt_interbank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_scotiabank
        '
        Me.txt_scotiabank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_scotiabank.ForeColor = System.Drawing.Color.Maroon
        Me.txt_scotiabank.Location = New System.Drawing.Point(368, 39)
        Me.txt_scotiabank.Name = "txt_scotiabank"
        Me.txt_scotiabank.Size = New System.Drawing.Size(114, 26)
        Me.txt_scotiabank.TabIndex = 12
        Me.txt_scotiabank.Text = "0"
        Me.txt_scotiabank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmFacturacion_Tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 662)
        Me.Controls.Add(Me.pnlDocumentosGuiaVenta)
        Me.Controls.Add(Me.pnl_motivo_anulacion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlNuevaPlanilla)
        Me.Controls.Add(Me.pnl_cierre_ventas)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.pnl_ref)
        Me.Controls.Add(Me.panel_cliente_nuevo)
        Me.Controls.Add(Me.gbdetalle)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.GbCabecera)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.gbTipoGuia)
        Me.Controls.Add(Me.gbTipoFacturacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFacturacion_Tienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación Tienda"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.gbdetalle.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones.PerformLayout()
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dgv_lista_productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_cliente_nuevo.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.gbTipoFacturacion.ResumeLayout(False)
        Me.gbTipoFacturacion.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.gbTipoGuia.ResumeLayout(False)
        Me.gbTipoGuia.PerformLayout()
        Me.pnl_ref.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_cierre_ventas.ResumeLayout(False)
        Me.pnl_cierre_ventas.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.gb_pago_tarjeta.ResumeLayout(False)
        Me.gb_pago_tarjeta.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_pago_efectivo.ResumeLayout(False)
        Me.gb_pago_efectivo.PerformLayout()
        Me.pnlNuevaPlanilla.ResumeLayout(False)
        Me.pnlNuevaPlanilla.PerformLayout()
        Me.gb_nueva_planilla.ResumeLayout(False)
        Me.gb_nueva_planilla.PerformLayout()
        Me.pnl_motivo_anulacion.ResumeLayout(False)
        Me.pnl_motivo_anulacion.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.pnlDocumentosGuiaVenta.ResumeLayout(False)
        Me.pnlDocumentosGuiaVenta.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.dgvDocumentosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents gbdetalle As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents chk_facturar_obsequio As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_f_a4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_f_ticket As System.Windows.Forms.RadioButton
    Friend WithEvents txt_desc_tipo_nota_electronica As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_tip_nota_electronica As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnclientenuevo As System.Windows.Forms.Button
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
    Friend WithEvents txtCodTrans As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcantidad_fraccion As System.Windows.Forms.TextBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents txtprecioUnitario_fraccion As System.Windows.Forms.TextBox
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_lote As System.Windows.Forms.TextBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents txt_por_Des As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_carrito As System.Windows.Forms.Button
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents txtIsc As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txtDescuentos As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtBruto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtvalorVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_lista_productos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_buscador_productos As System.Windows.Forms.TextBox
    Friend WithEvents txt_buscador_especial As System.Windows.Forms.TextBox
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
    Friend WithEvents panel_cliente_nuevo As System.Windows.Forms.Panel
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_grabar_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents gbTipoFacturacion As System.Windows.Forms.GroupBox
    Friend WithEvents rb_facturar_devolucion As System.Windows.Forms.RadioButton
    Friend WithEvents rb_facturar_pedido As System.Windows.Forms.RadioButton
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents rbFacturaRepMedico As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturaExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturaGuiaVenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturaDirecta As System.Windows.Forms.RadioButton
    Friend WithEvents rbsinDescargo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVariaslineasDoc As System.Windows.Forms.RadioButton
    Friend WithEvents rbunalineaDoc As System.Windows.Forms.RadioButton
    Friend WithEvents txtGlosa As System.Windows.Forms.RichTextBox
    Friend WithEvents gbTipoGuia As System.Windows.Forms.GroupBox
    Friend WithEvents rbVariaslineas As System.Windows.Forms.RadioButton
    Friend WithEvents rbunalinea As System.Windows.Forms.RadioButton
    Friend WithEvents txtGlosaGuia As System.Windows.Forms.RichTextBox
    Friend WithEvents pnl_ref As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents dtp_fec_doc_ref As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_ref_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_serie_ref_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo_doc_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents pnl_cierre_ventas As System.Windows.Forms.Panel
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents gb_pago_tarjeta As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox21 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox25 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_plin As System.Windows.Forms.TextBox
    Friend WithEvents txt_yape As System.Windows.Forms.TextBox
    Friend WithEvents txt_bbva As System.Windows.Forms.TextBox
    Friend WithEvents txt_bcp As System.Windows.Forms.TextBox
    Friend WithEvents gb_pago_efectivo As System.Windows.Forms.GroupBox
    Friend WithEvents TxEfeDol As System.Windows.Forms.TextBox
    Friend WithEvents txt_saldo_final As System.Windows.Forms.TextBox
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents lbl_usuario_cierre As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_cierre_ventas As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents pnlNuevaPlanilla As System.Windows.Forms.Panel
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents gb_nueva_planilla As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_nombre_usuario As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents txt_saldo_inicial_caja As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar_crear As System.Windows.Forms.Button
    Friend WithEvents btn_crear_planilla As System.Windows.Forms.Button
    Friend WithEvents dtp_fec_nueva_pla As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents pnl_motivo_anulacion As System.Windows.Forms.Panel
    Friend WithEvents txt_motivo_anulacion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_anulacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_documento As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar_anulacion As System.Windows.Forms.Button
    Friend WithEvents btn_confirmar_anulacion As System.Windows.Forms.Button
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboOpcionTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Button22 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents btn_cierre_ventas As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtprecioTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents btn_cal_cantidad As System.Windows.Forms.Button
    Friend WithEvents btn_descargar_archivos As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtcantidad_equivalente As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_detallado As System.Windows.Forms.RadioButton
    Friend WithEvents rb_resumido As System.Windows.Forms.RadioButton
    Friend WithEvents chkTodosPersonal As System.Windows.Forms.CheckBox
    Friend WithEvents txt_des_personal As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_personal As System.Windows.Forms.TextBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents checkConceptos As System.Windows.Forms.CheckBox
    Friend WithEvents txt_des_concepto As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_concepto As System.Windows.Forms.TextBox
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents dtp_rep_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_rep_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btn_rep_arqueo_caja As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFactura_vcto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents btn_enviar_mail As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk_venta_cortesia As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Apertura_Doc As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_facturar_pedido As System.Windows.Forms.Button
    Friend WithEvents pnlDocumentosGuiaVenta As System.Windows.Forms.Panel
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltroCliente As System.Windows.Forms.TextBox
    Friend WithEvents dgvDocumentosCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chk_venta_sin_Descargo As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ActualizarCantidadEnComprobanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_cobro_venta_anterior As System.Windows.Forms.TextBox
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_comprobante As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox26 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox28 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_interbank As System.Windows.Forms.TextBox
    Friend WithEvents txt_scotiabank As System.Windows.Forms.TextBox
End Class
