<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacionRapida_Despachos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacionRapida_Despachos))
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesdespacho = New System.Windows.Forms.ComboBox()
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
        Me.gbdetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GenerarOrdenDeProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabilitarParaFacturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.txt_validez_oferta = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.chk_facturar_obsequio = New System.Windows.Forms.CheckBox()
        Me.rdb_f_a4 = New System.Windows.Forms.RadioButton()
        Me.rdb_f_ticket = New System.Windows.Forms.RadioButton()
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnPicking = New System.Windows.Forms.ToolStripButton()
        Me.btndeshacerPicking = New System.Windows.Forms.ToolStripButton()
        Me.btn_programar_despacho = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_habilitar_facturacion = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_imprimir_tk = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_obs_general = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txt_recepcion_tercero = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txt_n_operacion = New System.Windows.Forms.TextBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.txt_des_transferencia = New System.Windows.Forms.TextBox()
        Me.txt_cod_transferencia = New System.Windows.Forms.TextBox()
        Me.txt_lt_ft = New System.Windows.Forms.TextBox()
        Me.Label124 = New System.Windows.Forms.Label()
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
        Me.pnl_despacho_pedidos = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_vehiculo_despacho = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.txt_responsable_despacho = New System.Windows.Forms.TextBox()
        Me.txt_fecha_hora_aprobacion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnl_genera_op = New System.Windows.Forms.Panel()
        Me.chk_urgente = New System.Windows.Forms.CheckBox()
        Me.cbo_destinatario = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.txt_cod_cliente = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboalmacen = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_des_formula = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_formula = New System.Windows.Forms.TextBox()
        Me.cboformula_ee = New System.Windows.Forms.ComboBox()
        Me.cboformula_mp = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.dtp_fecha_op = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pnl_programar_despacho = New System.Windows.Forms.Panel()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_guia_programacion = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txt_factura = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt_direccion_entrega = New System.Windows.Forms.TextBox()
        Me.dtp_fecha_programacion = New System.Windows.Forms.DateTimePicker()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_pedido_programacion = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lbl_numero_programacion = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.txt_cod_trans = New System.Windows.Forms.TextBox()
        Me.txt_des_trans = New System.Windows.Forms.TextBox()
        Me.pnlPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.gbdetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_despacho_pedidos.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.pnl_genera_op.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.pnl_programar_despacho.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrincipal.Controls.Add(Me.GroupBox1)
        Me.pnlPrincipal.Controls.Add(Me.lblDetalle)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox3)
        Me.pnlPrincipal.Controls.Add(Me.dgvDocumentosFactura)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox2)
        Me.pnlPrincipal.Controls.Add(Me.lblCantidad)
        Me.pnlPrincipal.Controls.Add(Me.gbRangofechas)
        Me.pnlPrincipal.Location = New System.Drawing.Point(6, 33)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1246, 626)
        Me.pnlPrincipal.TabIndex = 220
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboopcionesdespacho)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(341, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 45)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opción de despacho:"
        '
        'cboopcionesdespacho
        '
        Me.cboopcionesdespacho.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesdespacho.FormattingEnabled = True
        Me.cboopcionesdespacho.Items.AddRange(New Object() {"Todos", "Por despachar", "Despachados"})
        Me.cboopcionesdespacho.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesdespacho.Name = "cboopcionesdespacho"
        Me.cboopcionesdespacho.Size = New System.Drawing.Size(170, 25)
        Me.cboopcionesdespacho.TabIndex = 5
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
        Me.lblDetalle.Size = New System.Drawing.Size(1244, 20)
        Me.lblDetalle.TabIndex = 199
        Me.lblDetalle.Text = "DESPACHO DE  PEDIDOS"
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
        Me.dgvDocumentosFactura.Size = New System.Drawing.Size(1229, 479)
        Me.dgvDocumentosFactura.TabIndex = 117
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(530, 60)
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
        Me.gbRangofechas.Location = New System.Drawing.Point(714, 60)
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
        Me.gbdetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbdetalle.BackColor = System.Drawing.Color.White
        Me.gbdetalle.Controls.Add(Me.dgvDetalle)
        Me.gbdetalle.Location = New System.Drawing.Point(17, 37)
        Me.gbdetalle.Name = "gbdetalle"
        Me.gbdetalle.Size = New System.Drawing.Size(1232, 328)
        Me.gbdetalle.TabIndex = 218
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalle.ColumnHeadersHeight = 30
        Me.dgvDetalle.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalle.EnableHeadersVisualStyles = False
        Me.dgvDetalle.Location = New System.Drawing.Point(8, 13)
        Me.dgvDetalle.Name = "dgvDetalle"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetalle.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDetalle.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalle.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(1219, 309)
        Me.dgvDetalle.TabIndex = 112
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarOrdenDeProducciónToolStripMenuItem, Me.HabilitarParaFacturarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(329, 48)
        '
        'GenerarOrdenDeProducciónToolStripMenuItem
        '
        Me.GenerarOrdenDeProducciónToolStripMenuItem.Image = CType(resources.GetObject("GenerarOrdenDeProducciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerarOrdenDeProducciónToolStripMenuItem.Name = "GenerarOrdenDeProducciónToolStripMenuItem"
        Me.GenerarOrdenDeProducciónToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.GenerarOrdenDeProducciónToolStripMenuItem.Text = "Generar Requerimiento de Orden de Producción"
        '
        'HabilitarParaFacturarToolStripMenuItem
        '
        Me.HabilitarParaFacturarToolStripMenuItem.Image = CType(resources.GetObject("HabilitarParaFacturarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HabilitarParaFacturarToolStripMenuItem.Name = "HabilitarParaFacturarToolStripMenuItem"
        Me.HabilitarParaFacturarToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.HabilitarParaFacturarToolStripMenuItem.Text = "Habilitar para Facturar"
        '
        'GbCabecera
        '
        Me.GbCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.txt_validez_oferta)
        Me.GbCabecera.Controls.Add(Me.Label99)
        Me.GbCabecera.Controls.Add(Me.Label98)
        Me.GbCabecera.Controls.Add(Me.txtcodigo)
        Me.GbCabecera.Controls.Add(Me.chk_facturar_obsequio)
        Me.GbCabecera.Controls.Add(Me.rdb_f_a4)
        Me.GbCabecera.Controls.Add(Me.rdb_f_ticket)
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
        Me.GbCabecera.Enabled = False
        Me.GbCabecera.Location = New System.Drawing.Point(747, 368)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(502, 274)
        Me.GbCabecera.TabIndex = 217
        Me.GbCabecera.TabStop = False
        '
        'txt_validez_oferta
        '
        Me.txt_validez_oferta.BackColor = System.Drawing.Color.White
        Me.txt_validez_oferta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_validez_oferta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_validez_oferta.ForeColor = System.Drawing.Color.Green
        Me.txt_validez_oferta.Location = New System.Drawing.Point(94, 236)
        Me.txt_validez_oferta.MaxLength = 250
        Me.txt_validez_oferta.Name = "txt_validez_oferta"
        Me.txt_validez_oferta.Size = New System.Drawing.Size(400, 21)
        Me.txt_validez_oferta.TabIndex = 197
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label99.ForeColor = System.Drawing.Color.Navy
        Me.Label99.Location = New System.Drawing.Point(8, 240)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(77, 13)
        Me.Label99.TabIndex = 198
        Me.Label99.Text = "Validez Ofer."
        Me.Label99.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label98.ForeColor = System.Drawing.Color.Navy
        Me.Label98.Location = New System.Drawing.Point(38, 215)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(47, 13)
        Me.Label98.TabIndex = 196
        Me.Label98.Text = "F. Pago"
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
        'txt_desc_tipo_nota_electronica
        '
        Me.txt_desc_tipo_nota_electronica.BackColor = System.Drawing.Color.White
        Me.txt_desc_tipo_nota_electronica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_tipo_nota_electronica.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc_tipo_nota_electronica.ForeColor = System.Drawing.Color.Green
        Me.txt_desc_tipo_nota_electronica.Location = New System.Drawing.Point(238, 290)
        Me.txt_desc_tipo_nota_electronica.Name = "txt_desc_tipo_nota_electronica"
        Me.txt_desc_tipo_nota_electronica.ReadOnly = True
        Me.txt_desc_tipo_nota_electronica.Size = New System.Drawing.Size(257, 27)
        Me.txt_desc_tipo_nota_electronica.TabIndex = 189
        Me.txt_desc_tipo_nota_electronica.Visible = False
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
        Me.txt_tip_nota_electronica.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tip_nota_electronica.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_tip_nota_electronica.Location = New System.Drawing.Point(94, 290)
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
        Me.Button5.Location = New System.Drawing.Point(343, 106)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 27)
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
        Me.btnclientenuevo.Location = New System.Drawing.Point(94, 106)
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
        Me.lblAlmacen.Location = New System.Drawing.Point(329, 18)
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
        Me.txtAlmacen.Location = New System.Drawing.Point(281, 18)
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
        Me.Label14.Location = New System.Drawing.Point(217, 22)
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
        Me.lblFormaPago.Location = New System.Drawing.Point(184, 211)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.ReadOnly = True
        Me.lblFormaPago.Size = New System.Drawing.Size(311, 21)
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
        Me.cboSerieDoc.Location = New System.Drawing.Point(416, 50)
        Me.cboSerieDoc.Name = "cboSerieDoc"
        Me.cboSerieDoc.Size = New System.Drawing.Size(79, 21)
        Me.cboSerieDoc.TabIndex = 5
        Me.cboSerieDoc.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(360, 54)
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
        Me.dtpFechaFactura.Location = New System.Drawing.Point(94, 50)
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
        Me.cboTipoDoc.Location = New System.Drawing.Point(281, 50)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(71, 21)
        Me.cboTipoDoc.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(239, 54)
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
        Me.cboMoneda.Location = New System.Drawing.Point(94, 78)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(186, 21)
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
        Me.txtFormaPago.Location = New System.Drawing.Point(94, 211)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(85, 21)
        Me.txtFormaPago.TabIndex = 11
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.Green
        Me.txtTipoCambio.Location = New System.Drawing.Point(416, 78)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(79, 21)
        Me.txtTipoCambio.TabIndex = 24
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtDireccion.Location = New System.Drawing.Point(94, 187)
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
        Me.txtRazonSocial.Location = New System.Drawing.Point(94, 162)
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
        Me.txtRucDni.Location = New System.Drawing.Point(343, 138)
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
        Me.txtCodCliente.Location = New System.Drawing.Point(94, 138)
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
        Me.txtPtoVenta.Location = New System.Drawing.Point(94, 18)
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(370, 82)
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
        Me.Label11.Location = New System.Drawing.Point(32, 82)
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
        Me.Label9.Location = New System.Drawing.Point(26, 190)
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
        Me.Label8.Location = New System.Drawing.Point(30, 166)
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
        Me.Label7.Location = New System.Drawing.Point(279, 141)
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
        Me.Label6.Location = New System.Drawing.Point(38, 141)
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
        Me.Label5.Location = New System.Drawing.Point(44, 54)
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConsultar, Me.btnPicking, Me.btndeshacerPicking, Me.btn_programar_despacho, Me.btnGrabar, Me.btn_habilitar_facturacion, Me.btnImprimir, Me.btn_imprimir_tk, Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1261, 25)
        Me.ToolStrip1.TabIndex = 216
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'btnPicking
        '
        Me.btnPicking.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPicking.Image = CType(resources.GetObject("btnPicking.Image"), System.Drawing.Image)
        Me.btnPicking.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPicking.Name = "btnPicking"
        Me.btnPicking.Size = New System.Drawing.Size(106, 22)
        Me.btnPicking.Text = "Iniciar Picking"
        '
        'btndeshacerPicking
        '
        Me.btndeshacerPicking.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btndeshacerPicking.Image = CType(resources.GetObject("btndeshacerPicking.Image"), System.Drawing.Image)
        Me.btndeshacerPicking.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndeshacerPicking.Name = "btndeshacerPicking"
        Me.btndeshacerPicking.Size = New System.Drawing.Size(117, 22)
        Me.btndeshacerPicking.Text = "Revertir Picking"
        Me.btndeshacerPicking.Visible = False
        '
        'btn_programar_despacho
        '
        Me.btn_programar_despacho.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_programar_despacho.Image = CType(resources.GetObject("btn_programar_despacho.Image"), System.Drawing.Image)
        Me.btn_programar_despacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_programar_despacho.Name = "btn_programar_despacho"
        Me.btn_programar_despacho.Size = New System.Drawing.Size(145, 22)
        Me.btn_programar_despacho.Text = "Programar despacho"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(87, 22)
        Me.btnGrabar.Text = "&Despachar"
        '
        'btn_habilitar_facturacion
        '
        Me.btn_habilitar_facturacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_habilitar_facturacion.Image = CType(resources.GetObject("btn_habilitar_facturacion.Image"), System.Drawing.Image)
        Me.btn_habilitar_facturacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_habilitar_facturacion.Name = "btn_habilitar_facturacion"
        Me.btn_habilitar_facturacion.Size = New System.Drawing.Size(153, 22)
        Me.btn_habilitar_facturacion.Text = "Habilitar para facturar"
        Me.btn_habilitar_facturacion.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(77, 22)
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.Visible = False
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
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txt_obs_general)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(17, 505)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(320, 65)
        Me.GroupBox4.TabIndex = 223
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Observaciones generales"
        '
        'txt_obs_general
        '
        Me.txt_obs_general.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_obs_general.BackColor = System.Drawing.Color.White
        Me.txt_obs_general.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs_general.Location = New System.Drawing.Point(10, 18)
        Me.txt_obs_general.MaxLength = 200
        Me.txt_obs_general.Multiline = True
        Me.txt_obs_general.Name = "txt_obs_general"
        Me.txt_obs_general.Size = New System.Drawing.Size(299, 36)
        Me.txt_obs_general.TabIndex = 203
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.txt_recepcion_tercero)
        Me.GroupBox10.Enabled = False
        Me.GroupBox10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox10.Location = New System.Drawing.Point(17, 577)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(320, 65)
        Me.GroupBox10.TabIndex = 224
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Recepción de Tercero"
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
        Me.txt_recepcion_tercero.Size = New System.Drawing.Size(299, 36)
        Me.txt_recepcion_tercero.TabIndex = 203
        '
        'GroupBox11
        '
        Me.GroupBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox11.BackColor = System.Drawing.Color.White
        Me.GroupBox11.Controls.Add(Me.txt_n_operacion)
        Me.GroupBox11.Controls.Add(Me.Label128)
        Me.GroupBox11.Controls.Add(Me.Label125)
        Me.GroupBox11.Controls.Add(Me.txt_des_transferencia)
        Me.GroupBox11.Controls.Add(Me.txt_cod_transferencia)
        Me.GroupBox11.Controls.Add(Me.txt_lt_ft)
        Me.GroupBox11.Controls.Add(Me.Label124)
        Me.GroupBox11.Controls.Add(Me.chk_cheque)
        Me.GroupBox11.Controls.Add(Me.rdb_domicilio)
        Me.GroupBox11.Controls.Add(Me.rdb_agencia)
        Me.GroupBox11.Controls.Add(Me.txt_guia)
        Me.GroupBox11.Controls.Add(Me.Label112)
        Me.GroupBox11.Controls.Add(Me.Label101)
        Me.GroupBox11.Controls.Add(Me.txt_des_agencia_trans)
        Me.GroupBox11.Controls.Add(Me.txt_cod_agencia_trans)
        Me.GroupBox11.Controls.Add(Me.txt_provincia)
        Me.GroupBox11.Controls.Add(Me.Label100)
        Me.GroupBox11.Controls.Add(Me.TextBox27)
        Me.GroupBox11.Controls.Add(Me.CheckBox1)
        Me.GroupBox11.Controls.Add(Me.RadioButton3)
        Me.GroupBox11.Controls.Add(Me.RadioButton4)
        Me.GroupBox11.Controls.Add(Me.TextBox28)
        Me.GroupBox11.Controls.Add(Me.PictureBox26)
        Me.GroupBox11.Controls.Add(Me.TextBox29)
        Me.GroupBox11.Controls.Add(Me.Label102)
        Me.GroupBox11.Controls.Add(Me.PictureBox28)
        Me.GroupBox11.Controls.Add(Me.PictureBox29)
        Me.GroupBox11.Controls.Add(Me.PictureBox30)
        Me.GroupBox11.Controls.Add(Me.TextBox30)
        Me.GroupBox11.Controls.Add(Me.Label103)
        Me.GroupBox11.Controls.Add(Me.TextBox31)
        Me.GroupBox11.Controls.Add(Me.Label104)
        Me.GroupBox11.Controls.Add(Me.TextBox32)
        Me.GroupBox11.Controls.Add(Me.Label105)
        Me.GroupBox11.Controls.Add(Me.PictureBox31)
        Me.GroupBox11.Controls.Add(Me.PictureBox32)
        Me.GroupBox11.Controls.Add(Me.RadioButton5)
        Me.GroupBox11.Controls.Add(Me.RadioButton6)
        Me.GroupBox11.Controls.Add(Me.GroupBox12)
        Me.GroupBox11.Controls.Add(Me.Label110)
        Me.GroupBox11.Controls.Add(Me.TextBox59)
        Me.GroupBox11.Controls.Add(Me.TextBox60)
        Me.GroupBox11.Controls.Add(Me.Label111)
        Me.GroupBox11.Controls.Add(Me.PictureBox33)
        Me.GroupBox11.Controls.Add(Me.CheckBox2)
        Me.GroupBox11.Controls.Add(Me.ComboBox3)
        Me.GroupBox11.Controls.Add(Me.Label113)
        Me.GroupBox11.Controls.Add(Me.TextBox64)
        Me.GroupBox11.Controls.Add(Me.Label114)
        Me.GroupBox11.Controls.Add(Me.TextBox65)
        Me.GroupBox11.Controls.Add(Me.Label115)
        Me.GroupBox11.Controls.Add(Me.TextBox66)
        Me.GroupBox11.Controls.Add(Me.CheckBox3)
        Me.GroupBox11.Controls.Add(Me.Label116)
        Me.GroupBox11.Controls.Add(Me.TextBox67)
        Me.GroupBox11.Controls.Add(Me.Label117)
        Me.GroupBox11.Controls.Add(Me.TextBox68)
        Me.GroupBox11.Controls.Add(Me.PictureBox34)
        Me.GroupBox11.Controls.Add(Me.TextBox69)
        Me.GroupBox11.Controls.Add(Me.Label118)
        Me.GroupBox11.Controls.Add(Me.TextBox70)
        Me.GroupBox11.Controls.Add(Me.PictureBox35)
        Me.GroupBox11.Controls.Add(Me.TextBox71)
        Me.GroupBox11.Controls.Add(Me.Label119)
        Me.GroupBox11.Controls.Add(Me.TextBox72)
        Me.GroupBox11.Controls.Add(Me.PictureBox36)
        Me.GroupBox11.Controls.Add(Me.TextBox73)
        Me.GroupBox11.Controls.Add(Me.Label120)
        Me.GroupBox11.Controls.Add(Me.TextBox74)
        Me.GroupBox11.Controls.Add(Me.Label121)
        Me.GroupBox11.Controls.Add(Me.TextBox75)
        Me.GroupBox11.Controls.Add(Me.TextBox76)
        Me.GroupBox11.Controls.Add(Me.TextBox78)
        Me.GroupBox11.Controls.Add(Me.Label122)
        Me.GroupBox11.Controls.Add(Me.Label123)
        Me.GroupBox11.Controls.Add(Me.PictureBox37)
        Me.GroupBox11.Controls.Add(Me.PictureBox38)
        Me.GroupBox11.Controls.Add(Me.ComboBox4)
        Me.GroupBox11.Controls.Add(Me.Label126)
        Me.GroupBox11.Controls.Add(Me.TextBox82)
        Me.GroupBox11.Controls.Add(Me.Label127)
        Me.GroupBox11.Controls.Add(Me.Label130)
        Me.GroupBox11.Controls.Add(Me.TextBox88)
        Me.GroupBox11.Enabled = False
        Me.GroupBox11.Location = New System.Drawing.Point(342, 368)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(399, 274)
        Me.GroupBox11.TabIndex = 225
        Me.GroupBox11.TabStop = False
        '
        'txt_n_operacion
        '
        Me.txt_n_operacion.BackColor = System.Drawing.Color.White
        Me.txt_n_operacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_n_operacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_n_operacion.ForeColor = System.Drawing.Color.Green
        Me.txt_n_operacion.Location = New System.Drawing.Point(94, 162)
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
        Me.Label128.Location = New System.Drawing.Point(8, 166)
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
        Me.Label125.Location = New System.Drawing.Point(3, 141)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(85, 13)
        Me.Label125.TabIndex = 213
        Me.Label125.Text = "Transferencia"
        '
        'txt_des_transferencia
        '
        Me.txt_des_transferencia.BackColor = System.Drawing.Color.White
        Me.txt_des_transferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_transferencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_des_transferencia.ForeColor = System.Drawing.Color.Green
        Me.txt_des_transferencia.Location = New System.Drawing.Point(159, 137)
        Me.txt_des_transferencia.Name = "txt_des_transferencia"
        Me.txt_des_transferencia.ReadOnly = True
        Me.txt_des_transferencia.Size = New System.Drawing.Size(231, 21)
        Me.txt_des_transferencia.TabIndex = 212
        '
        'txt_cod_transferencia
        '
        Me.txt_cod_transferencia.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_transferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_transferencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_transferencia.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_transferencia.Location = New System.Drawing.Point(94, 137)
        Me.txt_cod_transferencia.Name = "txt_cod_transferencia"
        Me.txt_cod_transferencia.ReadOnly = True
        Me.txt_cod_transferencia.Size = New System.Drawing.Size(57, 21)
        Me.txt_cod_transferencia.TabIndex = 211
        '
        'txt_lt_ft
        '
        Me.txt_lt_ft.BackColor = System.Drawing.Color.White
        Me.txt_lt_ft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lt_ft.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_lt_ft.ForeColor = System.Drawing.Color.Green
        Me.txt_lt_ft.Location = New System.Drawing.Point(94, 109)
        Me.txt_lt_ft.MaxLength = 250
        Me.txt_lt_ft.Name = "txt_lt_ft"
        Me.txt_lt_ft.Size = New System.Drawing.Size(138, 21)
        Me.txt_lt_ft.TabIndex = 209
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label124.ForeColor = System.Drawing.Color.Navy
        Me.Label124.Location = New System.Drawing.Point(49, 113)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(39, 13)
        Me.Label124.TabIndex = 210
        Me.Label124.Text = "LT/FT"
        Me.Label124.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chk_cheque
        '
        Me.chk_cheque.AutoSize = True
        Me.chk_cheque.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_cheque.ForeColor = System.Drawing.Color.Navy
        Me.chk_cheque.Location = New System.Drawing.Point(257, 111)
        Me.chk_cheque.Name = "chk_cheque"
        Me.chk_cheque.Size = New System.Drawing.Size(68, 17)
        Me.chk_cheque.TabIndex = 208
        Me.chk_cheque.Text = "Cheque"
        Me.chk_cheque.UseVisualStyleBackColor = True
        '
        'rdb_domicilio
        '
        Me.rdb_domicilio.AutoSize = True
        Me.rdb_domicilio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdb_domicilio.ForeColor = System.Drawing.Color.Navy
        Me.rdb_domicilio.Location = New System.Drawing.Point(322, 80)
        Me.rdb_domicilio.Name = "rdb_domicilio"
        Me.rdb_domicilio.Size = New System.Drawing.Size(76, 17)
        Me.rdb_domicilio.TabIndex = 207
        Me.rdb_domicilio.TabStop = True
        Me.rdb_domicilio.Text = "Domicilio"
        Me.rdb_domicilio.UseVisualStyleBackColor = True
        '
        'rdb_agencia
        '
        Me.rdb_agencia.AutoSize = True
        Me.rdb_agencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdb_agencia.ForeColor = System.Drawing.Color.Navy
        Me.rdb_agencia.Location = New System.Drawing.Point(241, 80)
        Me.rdb_agencia.Name = "rdb_agencia"
        Me.rdb_agencia.Size = New System.Drawing.Size(70, 17)
        Me.rdb_agencia.TabIndex = 206
        Me.rdb_agencia.TabStop = True
        Me.rdb_agencia.Text = "Agencia"
        Me.rdb_agencia.UseVisualStyleBackColor = True
        '
        'txt_guia
        '
        Me.txt_guia.BackColor = System.Drawing.Color.White
        Me.txt_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_guia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_guia.ForeColor = System.Drawing.Color.Green
        Me.txt_guia.Location = New System.Drawing.Point(94, 78)
        Me.txt_guia.MaxLength = 250
        Me.txt_guia.Name = "txt_guia"
        Me.txt_guia.Size = New System.Drawing.Size(138, 21)
        Me.txt_guia.TabIndex = 204
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label112.ForeColor = System.Drawing.Color.Navy
        Me.Label112.Location = New System.Drawing.Point(56, 82)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(32, 13)
        Me.Label112.TabIndex = 205
        Me.Label112.Text = "Guia"
        Me.Label112.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label101.ForeColor = System.Drawing.Color.Navy
        Me.Label101.Location = New System.Drawing.Point(11, 54)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(77, 13)
        Me.Label101.TabIndex = 203
        Me.Label101.Text = "Agen. Trans."
        '
        'txt_des_agencia_trans
        '
        Me.txt_des_agencia_trans.BackColor = System.Drawing.Color.White
        Me.txt_des_agencia_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_agencia_trans.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_des_agencia_trans.ForeColor = System.Drawing.Color.Green
        Me.txt_des_agencia_trans.Location = New System.Drawing.Point(159, 50)
        Me.txt_des_agencia_trans.Name = "txt_des_agencia_trans"
        Me.txt_des_agencia_trans.ReadOnly = True
        Me.txt_des_agencia_trans.Size = New System.Drawing.Size(231, 21)
        Me.txt_des_agencia_trans.TabIndex = 202
        '
        'txt_cod_agencia_trans
        '
        Me.txt_cod_agencia_trans.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_agencia_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_agencia_trans.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_agencia_trans.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_agencia_trans.Location = New System.Drawing.Point(94, 50)
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
        Me.txt_provincia.Location = New System.Drawing.Point(94, 19)
        Me.txt_provincia.MaxLength = 250
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(298, 21)
        Me.txt_provincia.TabIndex = 199
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label100.ForeColor = System.Drawing.Color.Navy
        Me.Label100.Location = New System.Drawing.Point(29, 23)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(59, 13)
        Me.Label100.TabIndex = 200
        Me.Label100.Text = "Provincia"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(120, 253)
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
        Me.CheckBox1.Location = New System.Drawing.Point(334, 265)
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
        Me.RadioButton3.Location = New System.Drawing.Point(214, 265)
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
        Me.RadioButton4.Location = New System.Drawing.Point(94, 265)
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
        Me.TextBox28.Location = New System.Drawing.Point(238, 290)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.ReadOnly = True
        Me.TextBox28.Size = New System.Drawing.Size(257, 27)
        Me.TextBox28.TabIndex = 189
        Me.TextBox28.Visible = False
        '
        'PictureBox26
        '
        Me.PictureBox26.Image = CType(resources.GetObject("PictureBox26.Image"), System.Drawing.Image)
        Me.PictureBox26.Location = New System.Drawing.Point(203, 290)
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
        Me.TextBox29.Location = New System.Drawing.Point(94, 290)
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
        Me.Label102.Location = New System.Drawing.Point(14, 294)
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
        Me.GroupBox12.Location = New System.Drawing.Point(148, 289)
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
        Me.PictureBox33.Location = New System.Drawing.Point(256, 308)
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
        Me.CheckBox3.Location = New System.Drawing.Point(76, 434)
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
        Me.TextBox75.Location = New System.Drawing.Point(291, 309)
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
        Me.PictureBox37.Location = New System.Drawing.Point(256, 350)
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
        Me.TextBox82.Location = New System.Drawing.Point(148, 308)
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
        Me.Label127.Location = New System.Drawing.Point(15, 354)
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
        Me.Label130.Location = New System.Drawing.Point(58, 311)
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
        'pnl_despacho_pedidos
        '
        Me.pnl_despacho_pedidos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_despacho_pedidos.Controls.Add(Me.GroupBox5)
        Me.pnl_despacho_pedidos.Controls.Add(Me.TextBox10)
        Me.pnl_despacho_pedidos.Controls.Add(Me.GroupBox19)
        Me.pnl_despacho_pedidos.Controls.Add(Me.GroupBox20)
        Me.pnl_despacho_pedidos.Location = New System.Drawing.Point(410, 35)
        Me.pnl_despacho_pedidos.Name = "pnl_despacho_pedidos"
        Me.pnl_despacho_pedidos.Size = New System.Drawing.Size(441, 186)
        Me.pnl_despacho_pedidos.TabIndex = 226
        Me.pnl_despacho_pedidos.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_vehiculo_despacho)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(8, 126)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(425, 52)
        Me.GroupBox5.TabIndex = 202
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vehiculo"
        '
        'txt_vehiculo_despacho
        '
        Me.txt_vehiculo_despacho.BackColor = System.Drawing.Color.White
        Me.txt_vehiculo_despacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vehiculo_despacho.ForeColor = System.Drawing.Color.Maroon
        Me.txt_vehiculo_despacho.Location = New System.Drawing.Point(10, 20)
        Me.txt_vehiculo_despacho.MaxLength = 200
        Me.txt_vehiculo_despacho.Name = "txt_vehiculo_despacho"
        Me.txt_vehiculo_despacho.Size = New System.Drawing.Size(405, 20)
        Me.txt_vehiculo_despacho.TabIndex = 186
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
        Me.TextBox10.Text = "DESPACHO DE PEDIDO"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.dtp_fecha_pedido)
        Me.GroupBox19.Controls.Add(Me.Label65)
        Me.GroupBox19.Controls.Add(Me.lbl_numero)
        Me.GroupBox19.Controls.Add(Me.Label69)
        Me.GroupBox19.Controls.Add(Me.Button1)
        Me.GroupBox19.Controls.Add(Me.Button6)
        Me.GroupBox19.Location = New System.Drawing.Point(8, 18)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(424, 52)
        Me.GroupBox19.TabIndex = 0
        Me.GroupBox19.TabStop = False
        '
        'dtp_fecha_pedido
        '
        Me.dtp_fecha_pedido.Enabled = False
        Me.dtp_fecha_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pedido.Location = New System.Drawing.Point(102, 26)
        Me.dtp_fecha_pedido.Name = "dtp_fecha_pedido"
        Me.dtp_fecha_pedido.Size = New System.Drawing.Size(105, 21)
        Me.dtp_fecha_pedido.TabIndex = 126
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Navy
        Me.Label65.Location = New System.Drawing.Point(7, 31)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(81, 13)
        Me.Label65.TabIndex = 125
        Me.Label65.Text = "Fecha Pedido"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_numero.Location = New System.Drawing.Point(102, 12)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(16, 13)
        Me.lbl_numero.TabIndex = 124
        Me.lbl_numero.Text = "..."
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Navy
        Me.Label69.Location = New System.Drawing.Point(5, 12)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(70, 13)
        Me.Label69.TabIndex = 123
        Me.Label69.Text = "Nro. Pedido"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(311, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 35)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.GroupBox20.Controls.Add(Me.txt_responsable_despacho)
        Me.GroupBox20.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox20.Location = New System.Drawing.Point(7, 74)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(425, 52)
        Me.GroupBox20.TabIndex = 201
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Responsable"
        '
        'txt_responsable_despacho
        '
        Me.txt_responsable_despacho.BackColor = System.Drawing.Color.White
        Me.txt_responsable_despacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_responsable_despacho.ForeColor = System.Drawing.Color.Maroon
        Me.txt_responsable_despacho.Location = New System.Drawing.Point(10, 20)
        Me.txt_responsable_despacho.MaxLength = 200
        Me.txt_responsable_despacho.Name = "txt_responsable_despacho"
        Me.txt_responsable_despacho.Size = New System.Drawing.Size(405, 20)
        Me.txt_responsable_despacho.TabIndex = 186
        '
        'txt_fecha_hora_aprobacion
        '
        Me.txt_fecha_hora_aprobacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_fecha_hora_aprobacion.BackColor = System.Drawing.Color.White
        Me.txt_fecha_hora_aprobacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fecha_hora_aprobacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_fecha_hora_aprobacion.ForeColor = System.Drawing.Color.Green
        Me.txt_fecha_hora_aprobacion.Location = New System.Drawing.Point(17, 479)
        Me.txt_fecha_hora_aprobacion.MaxLength = 250
        Me.txt_fecha_hora_aprobacion.Name = "txt_fecha_hora_aprobacion"
        Me.txt_fecha_hora_aprobacion.ReadOnly = True
        Me.txt_fecha_hora_aprobacion.Size = New System.Drawing.Size(320, 21)
        Me.txt_fecha_hora_aprobacion.TabIndex = 227
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(17, 461)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 13)
        Me.Label15.TabIndex = 228
        Me.Label15.Text = "Fecha y Hora de Aprobación"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnl_genera_op
        '
        Me.pnl_genera_op.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_genera_op.Controls.Add(Me.chk_urgente)
        Me.pnl_genera_op.Controls.Add(Me.cbo_destinatario)
        Me.pnl_genera_op.Controls.Add(Me.Label44)
        Me.pnl_genera_op.Controls.Add(Me.Label28)
        Me.pnl_genera_op.Controls.Add(Me.txtComentarios)
        Me.pnl_genera_op.Controls.Add(Me.txt_razon_social)
        Me.pnl_genera_op.Controls.Add(Me.txt_cod_cliente)
        Me.pnl_genera_op.Controls.Add(Me.Label27)
        Me.pnl_genera_op.Controls.Add(Me.cboalmacen)
        Me.pnl_genera_op.Controls.Add(Me.Label24)
        Me.pnl_genera_op.Controls.Add(Me.GroupBox6)
        Me.pnl_genera_op.Controls.Add(Me.GroupBox8)
        Me.pnl_genera_op.Controls.Add(Me.TextBox2)
        Me.pnl_genera_op.Controls.Add(Me.GroupBox7)
        Me.pnl_genera_op.Location = New System.Drawing.Point(410, 73)
        Me.pnl_genera_op.Name = "pnl_genera_op"
        Me.pnl_genera_op.Size = New System.Drawing.Size(441, 336)
        Me.pnl_genera_op.TabIndex = 230
        Me.pnl_genera_op.Visible = False
        '
        'chk_urgente
        '
        Me.chk_urgente.AutoSize = True
        Me.chk_urgente.Font = New System.Drawing.Font("Book Antiqua", 9.0!)
        Me.chk_urgente.ForeColor = System.Drawing.Color.Navy
        Me.chk_urgente.Location = New System.Drawing.Point(302, 238)
        Me.chk_urgente.Name = "chk_urgente"
        Me.chk_urgente.Size = New System.Drawing.Size(71, 20)
        Me.chk_urgente.TabIndex = 268
        Me.chk_urgente.Text = "Urgente"
        Me.chk_urgente.UseVisualStyleBackColor = True
        '
        'cbo_destinatario
        '
        Me.cbo_destinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_destinatario.FormattingEnabled = True
        Me.cbo_destinatario.Items.AddRange(New Object() {"Para producción", "Para compra local"})
        Me.cbo_destinatario.Location = New System.Drawing.Point(96, 238)
        Me.cbo_destinatario.Name = "cbo_destinatario"
        Me.cbo_destinatario.Size = New System.Drawing.Size(177, 21)
        Me.cbo_destinatario.TabIndex = 267
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Navy
        Me.Label44.Location = New System.Drawing.Point(15, 240)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(75, 16)
        Me.Label44.TabIndex = 266
        Me.Label44.Text = "Destinatario"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(12, 271)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(243, 13)
        Me.Label28.TabIndex = 187
        Me.Label28.Text = "Datos Adicionales / Observaciones / Comentarios"
        '
        'txtComentarios
        '
        Me.txtComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentarios.BackColor = System.Drawing.Color.White
        Me.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComentarios.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarios.Location = New System.Drawing.Point(8, 293)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarios.Size = New System.Drawing.Size(424, 36)
        Me.txtComentarios.TabIndex = 186
        Me.txtComentarios.Text = ""
        '
        'txt_razon_social
        '
        Me.txt_razon_social.BackColor = System.Drawing.Color.White
        Me.txt_razon_social.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_razon_social.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_razon_social.ForeColor = System.Drawing.Color.Green
        Me.txt_razon_social.Location = New System.Drawing.Point(76, 153)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.ReadOnly = True
        Me.txt_razon_social.Size = New System.Drawing.Size(353, 21)
        Me.txt_razon_social.TabIndex = 185
        '
        'txt_cod_cliente
        '
        Me.txt_cod_cliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_cliente.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_cliente.Location = New System.Drawing.Point(76, 128)
        Me.txt_cod_cliente.Name = "txt_cod_cliente"
        Me.txt_cod_cliente.ReadOnly = True
        Me.txt_cod_cliente.Size = New System.Drawing.Size(137, 21)
        Me.txt_cod_cliente.TabIndex = 183
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Book Antiqua", 9.0!)
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(20, 130)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 16)
        Me.Label27.TabIndex = 184
        Me.Label27.Text = "Cliente"
        '
        'cboalmacen
        '
        Me.cboalmacen.FormattingEnabled = True
        Me.cboalmacen.Location = New System.Drawing.Point(110, 317)
        Me.cboalmacen.Name = "cboalmacen"
        Me.cboalmacen.Size = New System.Drawing.Size(292, 21)
        Me.cboalmacen.TabIndex = 182
        Me.cboalmacen.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(48, 321)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 13)
        Me.Label24.TabIndex = 181
        Me.Label24.Text = "Almacen"
        Me.Label24.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_des_formula)
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Controls.Add(Me.txt_cod_formula)
        Me.GroupBox6.Controls.Add(Me.cboformula_ee)
        Me.GroupBox6.Controls.Add(Me.cboformula_mp)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(8, 321)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(424, 52)
        Me.GroupBox6.TabIndex = 170
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Detalles de Formulas"
        Me.GroupBox6.Visible = False
        '
        'txt_des_formula
        '
        Me.txt_des_formula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_formula.ForeColor = System.Drawing.Color.Black
        Me.txt_des_formula.Location = New System.Drawing.Point(187, 19)
        Me.txt_des_formula.Name = "txt_des_formula"
        Me.txt_des_formula.ReadOnly = True
        Me.txt_des_formula.Size = New System.Drawing.Size(228, 20)
        Me.txt_des_formula.TabIndex = 195
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(162, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 194
        Me.PictureBox1.TabStop = False
        '
        'txt_cod_formula
        '
        Me.txt_cod_formula.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_formula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_formula.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_formula.Location = New System.Drawing.Point(70, 19)
        Me.txt_cod_formula.Name = "txt_cod_formula"
        Me.txt_cod_formula.ReadOnly = True
        Me.txt_cod_formula.Size = New System.Drawing.Size(88, 20)
        Me.txt_cod_formula.TabIndex = 193
        '
        'cboformula_ee
        '
        Me.cboformula_ee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboformula_ee.FormattingEnabled = True
        Me.cboformula_ee.Location = New System.Drawing.Point(81, 64)
        Me.cboformula_ee.Name = "cboformula_ee"
        Me.cboformula_ee.Size = New System.Drawing.Size(472, 21)
        Me.cboformula_ee.TabIndex = 5
        Me.cboformula_ee.Visible = False
        '
        'cboformula_mp
        '
        Me.cboformula_mp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboformula_mp.FormattingEnabled = True
        Me.cboformula_mp.Location = New System.Drawing.Point(474, 21)
        Me.cboformula_mp.Name = "cboformula_mp"
        Me.cboformula_mp.Size = New System.Drawing.Size(80, 21)
        Me.cboformula_mp.TabIndex = 4
        Me.cboformula_mp.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(7, 66)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Formula ME"
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(6, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Formula MP"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtcantidad)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(8, 180)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(424, 47)
        Me.GroupBox8.TabIndex = 169
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Cantidad a Producir"
        '
        'txtcantidad
        '
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Location = New System.Drawing.Point(70, 19)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(88, 20)
        Me.txtcantidad.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(30, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Cant."
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Red
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(1, 1)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(440, 42)
        Me.TextBox2.TabIndex = 168
        Me.TextBox2.Text = "GENERACION DE REQUERIMIENTO DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDEN DE PRODUCCION"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dtp_fecha_entrega)
        Me.GroupBox7.Controls.Add(Me.Label42)
        Me.GroupBox7.Controls.Add(Me.dtp_fecha_op)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.Button3)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 45)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(424, 73)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'dtp_fecha_entrega
        '
        Me.dtp_fecha_entrega.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_entrega.Location = New System.Drawing.Point(113, 46)
        Me.dtp_fecha_entrega.Name = "dtp_fecha_entrega"
        Me.dtp_fecha_entrega.Size = New System.Drawing.Size(105, 21)
        Me.dtp_fecha_entrega.TabIndex = 128
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(7, 50)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(104, 13)
        Me.Label42.TabIndex = 127
        Me.Label42.Text = "Fecha de Entrega"
        '
        'dtp_fecha_op
        '
        Me.dtp_fecha_op.Enabled = False
        Me.dtp_fecha_op.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_op.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_op.Location = New System.Drawing.Point(112, 19)
        Me.dtp_fecha_op.Name = "dtp_fecha_op"
        Me.dtp_fecha_op.Size = New System.Drawing.Size(105, 21)
        Me.dtp_fecha_op.TabIndex = 126
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(71, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Fecha"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(315, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 35)
        Me.Button2.TabIndex = 121
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(246, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 35)
        Me.Button3.TabIndex = 122
        Me.Button3.Text = "Confirmar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'pnl_programar_despacho
        '
        Me.pnl_programar_despacho.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_programar_despacho.Controls.Add(Me.GroupBox15)
        Me.pnl_programar_despacho.Controls.Add(Me.GroupBox9)
        Me.pnl_programar_despacho.Controls.Add(Me.dtp_fecha_programacion)
        Me.pnl_programar_despacho.Controls.Add(Me.Label48)
        Me.pnl_programar_despacho.Controls.Add(Me.TextBox3)
        Me.pnl_programar_despacho.Controls.Add(Me.GroupBox13)
        Me.pnl_programar_despacho.Controls.Add(Me.GroupBox14)
        Me.pnl_programar_despacho.Location = New System.Drawing.Point(410, 35)
        Me.pnl_programar_despacho.Name = "pnl_programar_despacho"
        Me.pnl_programar_despacho.Size = New System.Drawing.Size(441, 305)
        Me.pnl_programar_despacho.TabIndex = 231
        Me.pnl_programar_despacho.Visible = False
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Label52)
        Me.GroupBox15.Controls.Add(Me.txt_guia_programacion)
        Me.GroupBox15.Controls.Add(Me.Label46)
        Me.GroupBox15.Controls.Add(Me.txt_factura)
        Me.GroupBox15.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox15.Location = New System.Drawing.Point(8, 241)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(425, 52)
        Me.GroupBox15.TabIndex = 205
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Documento de Facturación"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(217, 22)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(43, 13)
        Me.Label52.TabIndex = 191
        Me.Label52.Text = "N° Guia"
        '
        'txt_guia_programacion
        '
        Me.txt_guia_programacion.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_guia_programacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_guia_programacion.Location = New System.Drawing.Point(267, 19)
        Me.txt_guia_programacion.Name = "txt_guia_programacion"
        Me.txt_guia_programacion.ReadOnly = True
        Me.txt_guia_programacion.Size = New System.Drawing.Size(111, 20)
        Me.txt_guia_programacion.TabIndex = 190
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(18, 23)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(59, 13)
        Me.Label46.TabIndex = 189
        Me.Label46.Text = "N° Factura"
        '
        'txt_factura
        '
        Me.txt_factura.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_factura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_factura.Location = New System.Drawing.Point(85, 20)
        Me.txt_factura.Name = "txt_factura"
        Me.txt_factura.ReadOnly = True
        Me.txt_factura.Size = New System.Drawing.Size(111, 20)
        Me.txt_factura.TabIndex = 188
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txt_direccion_entrega)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(7, 183)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(425, 52)
        Me.GroupBox9.TabIndex = 204
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Dirección de entrega"
        '
        'txt_direccion_entrega
        '
        Me.txt_direccion_entrega.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_direccion_entrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_direccion_entrega.Location = New System.Drawing.Point(9, 20)
        Me.txt_direccion_entrega.Name = "txt_direccion_entrega"
        Me.txt_direccion_entrega.ReadOnly = True
        Me.txt_direccion_entrega.Size = New System.Drawing.Size(407, 20)
        Me.txt_direccion_entrega.TabIndex = 188
        '
        'dtp_fecha_programacion
        '
        Me.dtp_fecha_programacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_programacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_programacion.Location = New System.Drawing.Point(141, 83)
        Me.dtp_fecha_programacion.Name = "dtp_fecha_programacion"
        Me.dtp_fecha_programacion.Size = New System.Drawing.Size(105, 21)
        Me.dtp_fecha_programacion.TabIndex = 203
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Navy
        Me.Label48.Location = New System.Drawing.Point(15, 88)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(122, 13)
        Me.Label48.TabIndex = 202
        Me.Label48.Text = "Fecha Programación"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(1, 1)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(440, 20)
        Me.TextBox3.TabIndex = 168
        Me.TextBox3.Text = "PROGRAMACION DE DESPACHO"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.dtp_fecha_pedido_programacion)
        Me.GroupBox13.Controls.Add(Me.Label45)
        Me.GroupBox13.Controls.Add(Me.lbl_numero_programacion)
        Me.GroupBox13.Controls.Add(Me.Label47)
        Me.GroupBox13.Controls.Add(Me.Button4)
        Me.GroupBox13.Controls.Add(Me.Button7)
        Me.GroupBox13.Location = New System.Drawing.Point(8, 18)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(424, 52)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        '
        'dtp_fecha_pedido_programacion
        '
        Me.dtp_fecha_pedido_programacion.Enabled = False
        Me.dtp_fecha_pedido_programacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_pedido_programacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pedido_programacion.Location = New System.Drawing.Point(102, 26)
        Me.dtp_fecha_pedido_programacion.Name = "dtp_fecha_pedido_programacion"
        Me.dtp_fecha_pedido_programacion.Size = New System.Drawing.Size(105, 21)
        Me.dtp_fecha_pedido_programacion.TabIndex = 126
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(7, 31)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(81, 13)
        Me.Label45.TabIndex = 125
        Me.Label45.Text = "Fecha Pedido"
        '
        'lbl_numero_programacion
        '
        Me.lbl_numero_programacion.AutoSize = True
        Me.lbl_numero_programacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero_programacion.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_numero_programacion.Location = New System.Drawing.Point(102, 12)
        Me.lbl_numero_programacion.Name = "lbl_numero_programacion"
        Me.lbl_numero_programacion.Size = New System.Drawing.Size(16, 13)
        Me.lbl_numero_programacion.TabIndex = 124
        Me.lbl_numero_programacion.Text = "..."
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(5, 12)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(70, 13)
        Me.Label47.TabIndex = 123
        Me.Label47.Text = "Nro. Pedido"
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(311, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 35)
        Me.Button4.TabIndex = 121
        Me.Button4.Text = "Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Navy
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(246, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(63, 35)
        Me.Button7.TabIndex = 122
        Me.Button7.Text = "Confirmar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.txt_cod_trans)
        Me.GroupBox14.Controls.Add(Me.txt_des_trans)
        Me.GroupBox14.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox14.Location = New System.Drawing.Point(7, 123)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(425, 52)
        Me.GroupBox14.TabIndex = 201
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Transportista"
        '
        'txt_cod_trans
        '
        Me.txt_cod_trans.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_trans.Location = New System.Drawing.Point(9, 20)
        Me.txt_cod_trans.Name = "txt_cod_trans"
        Me.txt_cod_trans.ReadOnly = True
        Me.txt_cod_trans.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod_trans.TabIndex = 188
        '
        'txt_des_trans
        '
        Me.txt_des_trans.BackColor = System.Drawing.Color.White
        Me.txt_des_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_trans.Enabled = False
        Me.txt_des_trans.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_trans.Location = New System.Drawing.Point(84, 20)
        Me.txt_des_trans.MaxLength = 200
        Me.txt_des_trans.Name = "txt_des_trans"
        Me.txt_des_trans.ReadOnly = True
        Me.txt_des_trans.Size = New System.Drawing.Size(331, 20)
        Me.txt_des_trans.TabIndex = 186
        '
        'FrmFacturacionRapida_Despachos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1261, 662)
        Me.Controls.Add(Me.pnl_programar_despacho)
        Me.Controls.Add(Me.pnl_despacho_pedidos)
        Me.Controls.Add(Me.pnl_genera_op)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.gbdetalle)
        Me.Controls.Add(Me.GbCabecera)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.txt_fecha_hora_aprobacion)
        Me.Controls.Add(Me.Label15)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFacturacionRapida_Despachos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despachos de Pedidos"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.gbdetalle.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
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
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_despacho_pedidos.ResumeLayout(False)
        Me.pnl_despacho_pedidos.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.pnl_genera_op.ResumeLayout(False)
        Me.pnl_genera_op.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.pnl_programar_despacho.ResumeLayout(False)
        Me.pnl_programar_despacho.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
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
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents txt_validez_oferta As System.Windows.Forms.TextBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
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
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_obs_general As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_recepcion_tercero As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_n_operacion As System.Windows.Forms.TextBox
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents txt_des_transferencia As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_transferencia As System.Windows.Forms.TextBox
    Friend WithEvents txt_lt_ft As System.Windows.Forms.TextBox
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents chk_cheque As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_domicilio As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_agencia As System.Windows.Forms.RadioButton
    Friend WithEvents txt_guia As System.Windows.Forms.TextBox
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents txt_des_agencia_trans As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_agencia_trans As System.Windows.Forms.TextBox
    Friend WithEvents txt_provincia As System.Windows.Forms.TextBox
    Friend WithEvents Label100 As System.Windows.Forms.Label
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesdespacho As System.Windows.Forms.ComboBox
    Friend WithEvents pnl_despacho_pedidos As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_vehiculo_despacho As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_responsable_despacho As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_fecha_hora_aprobacion As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_imprimir_tk As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GenerarOrdenDeProducciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_genera_op As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_op As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_des_formula As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_formula As System.Windows.Forms.TextBox
    Friend WithEvents cboformula_ee As System.Windows.Forms.ComboBox
    Friend WithEvents cboformula_mp As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btn_habilitar_facturacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_cod_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents HabilitarParaFacturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtp_fecha_entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cbo_destinatario As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents chk_urgente As System.Windows.Forms.CheckBox
    Friend WithEvents btn_programar_despacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_programar_despacho As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_pedido_programacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_programacion As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_des_trans As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha_programacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_trans As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_factura As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_direccion_entrega As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txt_guia_programacion As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents btnPicking As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndeshacerPicking As System.Windows.Forms.ToolStripButton
End Class
