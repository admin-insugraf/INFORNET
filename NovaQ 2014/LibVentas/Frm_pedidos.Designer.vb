<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_pedidos))
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.dtp_fecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.lb_cc_importar = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.txt_cc_importar = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cbo_dir_entrega_importar = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_direccion_importar = New System.Windows.Forms.TextBox()
        Me.lb_fp_importar = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.txt_fp_importar = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_cod_cliente_importar = New System.Windows.Forms.TextBox()
        Me.txt_tc_importar = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cbo_moneda_importar = New System.Windows.Forms.ComboBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txt_ruc_importar = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txt_razon_social_importar = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.progreso = New System.Windows.Forms.ProgressBar()
        Me.dgv_detalles_pedidos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_mostrar_ped = New System.Windows.Forms.Button()
        Me.btn_importar_ped = New System.Windows.Forms.Button()
        Me.cbo_cliente = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.dgvdetalles = New System.Windows.Forms.DataGridView()
        Me.btn_ruta = New System.Windows.Forms.Button()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.lbl_centro_costo = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_centro_costo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cbo_direc_entrega = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txttrama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.lblPtoVenta = New System.Windows.Forms.TextBox()
        Me.lblAlmacen = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.txtAlmacen = New System.Windows.Forms.TextBox()
        Me.txtPtoVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblvendedor = New System.Windows.Forms.Label()
        Me.lblformapago = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtordencompra = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcompra = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.dtp_emision = New System.Windows.Forms.DateTimePicker()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txttipoCambio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrazonsocial = New System.Windows.Forms.TextBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.txtglosa = New System.Windows.Forms.RichTextBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtvalorVenta = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtBruto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tc_principal = New System.Windows.Forms.TabControl()
        Me.tc_datos = New System.Windows.Forms.TabPage()
        Me.tc_detalle = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnl_stock = New System.Windows.Forms.Panel()
        Me.dgv_stock = New System.Windows.Forms.DataGridView()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtStockLote = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboLotes = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl_centro_costo_detalle = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.txt_centro_costo_detalle = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.txtunidadMedRef = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtcantidadref = New System.Windows.Forms.TextBox()
        Me.btn_stock = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtproyecto = New System.Windows.Forms.TextBox()
        Me.txtcentroCosto = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkigv = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtvalorvent = New System.Windows.Forms.TextBox()
        Me.txttasa = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txttotalneto = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txt_igv = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtvalorbruto = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtpreciounitario = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtvalorventaunit = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtvalorventaref = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtValorunitario = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtporc_descuento = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_aprobar = New System.Windows.Forms.ToolStripButton()
        Me.btn_anular = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_cotizacion = New System.Windows.Forms.ToolStripButton()
        Me.btn_importar_pedidos = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_detalles_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbcabecera.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        Me.Tc_principal.SuspendLayout()
        Me.tc_datos.SuspendLayout()
        Me.tc_detalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnl_stock.SuspendLayout()
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.btn_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(10, 104)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.Size = New System.Drawing.Size(849, 408)
        Me.dgvCabecera.TabIndex = 2
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.Panel1)
        Me.pnlCabecera.Controls.Add(Me.lblDetalle)
        Me.pnlCabecera.Controls.Add(Me.lblCantidad)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(12, 35)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(863, 544)
        Me.pnlCabecera.TabIndex = 177
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.progreso)
        Me.Panel1.Controls.Add(Me.dgv_detalles_pedidos)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_mostrar_ped)
        Me.Panel1.Controls.Add(Me.btn_importar_ped)
        Me.Panel1.Controls.Add(Me.cbo_cliente)
        Me.Panel1.Controls.Add(Me.Label48)
        Me.Panel1.Controls.Add(Me.dgvdetalles)
        Me.Panel1.Controls.Add(Me.btn_ruta)
        Me.Panel1.Controls.Add(Me.txt_ruta)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Location = New System.Drawing.Point(20, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(46, 522)
        Me.Panel1.TabIndex = 200
        Me.Panel1.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label51)
        Me.GroupBox8.Controls.Add(Me.dtp_fecha_pedido)
        Me.GroupBox8.Controls.Add(Me.lb_cc_importar)
        Me.GroupBox8.Controls.Add(Me.PictureBox12)
        Me.GroupBox8.Controls.Add(Me.txt_cc_importar)
        Me.GroupBox8.Controls.Add(Me.Label53)
        Me.GroupBox8.Controls.Add(Me.cbo_dir_entrega_importar)
        Me.GroupBox8.Controls.Add(Me.Label54)
        Me.GroupBox8.Controls.Add(Me.Label55)
        Me.GroupBox8.Controls.Add(Me.txt_direccion_importar)
        Me.GroupBox8.Controls.Add(Me.lb_fp_importar)
        Me.GroupBox8.Controls.Add(Me.PictureBox13)
        Me.GroupBox8.Controls.Add(Me.txt_fp_importar)
        Me.GroupBox8.Controls.Add(Me.Label57)
        Me.GroupBox8.Controls.Add(Me.txt_cod_cliente_importar)
        Me.GroupBox8.Controls.Add(Me.txt_tc_importar)
        Me.GroupBox8.Controls.Add(Me.Label58)
        Me.GroupBox8.Controls.Add(Me.Label59)
        Me.GroupBox8.Controls.Add(Me.cbo_moneda_importar)
        Me.GroupBox8.Controls.Add(Me.Label60)
        Me.GroupBox8.Controls.Add(Me.txt_ruc_importar)
        Me.GroupBox8.Controls.Add(Me.Label61)
        Me.GroupBox8.Controls.Add(Me.txt_razon_social_importar)
        Me.GroupBox8.Controls.Add(Me.Label62)
        Me.GroupBox8.Location = New System.Drawing.Point(23, 54)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(807, 144)
        Me.GroupBox8.TabIndex = 277
        Me.GroupBox8.TabStop = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Navy
        Me.Label51.Location = New System.Drawing.Point(439, 96)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(40, 13)
        Me.Label51.TabIndex = 300
        Me.Label51.Text = "Fecha "
        '
        'dtp_fecha_pedido
        '
        Me.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pedido.Location = New System.Drawing.Point(490, 93)
        Me.dtp_fecha_pedido.Name = "dtp_fecha_pedido"
        Me.dtp_fecha_pedido.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fecha_pedido.TabIndex = 299
        '
        'lb_cc_importar
        '
        Me.lb_cc_importar.AutoSize = True
        Me.lb_cc_importar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cc_importar.ForeColor = System.Drawing.Color.Navy
        Me.lb_cc_importar.Location = New System.Drawing.Point(206, 119)
        Me.lb_cc_importar.Name = "lb_cc_importar"
        Me.lb_cc_importar.Size = New System.Drawing.Size(16, 13)
        Me.lb_cc_importar.TabIndex = 298
        Me.lb_cc_importar.Text = "..."
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(183, 117)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox12.TabIndex = 297
        Me.PictureBox12.TabStop = False
        '
        'txt_cc_importar
        '
        Me.txt_cc_importar.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cc_importar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cc_importar.Location = New System.Drawing.Point(125, 116)
        Me.txt_cc_importar.Name = "txt_cc_importar"
        Me.txt_cc_importar.ReadOnly = True
        Me.txt_cc_importar.Size = New System.Drawing.Size(55, 20)
        Me.txt_cc_importar.TabIndex = 295
        Me.txt_cc_importar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(37, 119)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(83, 13)
        Me.Label53.TabIndex = 296
        Me.Label53.Text = "Centro de Costo"
        '
        'cbo_dir_entrega_importar
        '
        Me.cbo_dir_entrega_importar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_dir_entrega_importar.ForeColor = System.Drawing.Color.Black
        Me.cbo_dir_entrega_importar.FormattingEnabled = True
        Me.cbo_dir_entrega_importar.Location = New System.Drawing.Point(125, 68)
        Me.cbo_dir_entrega_importar.Name = "cbo_dir_entrega_importar"
        Me.cbo_dir_entrega_importar.Size = New System.Drawing.Size(626, 21)
        Me.cbo_dir_entrega_importar.TabIndex = 294
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(45, 71)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(75, 13)
        Me.Label54.TabIndex = 293
        Me.Label54.Text = "Direc. Entrega"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Navy
        Me.Label55.Location = New System.Drawing.Point(68, 47)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(52, 13)
        Me.Label55.TabIndex = 292
        Me.Label55.Text = "Direccion"
        '
        'txt_direccion_importar
        '
        Me.txt_direccion_importar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_direccion_importar.Enabled = False
        Me.txt_direccion_importar.Location = New System.Drawing.Point(125, 45)
        Me.txt_direccion_importar.Name = "txt_direccion_importar"
        Me.txt_direccion_importar.Size = New System.Drawing.Size(626, 20)
        Me.txt_direccion_importar.TabIndex = 281
        '
        'lb_fp_importar
        '
        Me.lb_fp_importar.AutoSize = True
        Me.lb_fp_importar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fp_importar.ForeColor = System.Drawing.Color.Navy
        Me.lb_fp_importar.Location = New System.Drawing.Point(206, 96)
        Me.lb_fp_importar.Name = "lb_fp_importar"
        Me.lb_fp_importar.Size = New System.Drawing.Size(16, 13)
        Me.lb_fp_importar.TabIndex = 291
        Me.lb_fp_importar.Text = "..."
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(183, 94)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox13.TabIndex = 290
        Me.PictureBox13.TabStop = False
        '
        'txt_fp_importar
        '
        Me.txt_fp_importar.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_fp_importar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fp_importar.Location = New System.Drawing.Point(125, 93)
        Me.txt_fp_importar.Name = "txt_fp_importar"
        Me.txt_fp_importar.ReadOnly = True
        Me.txt_fp_importar.Size = New System.Drawing.Size(55, 20)
        Me.txt_fp_importar.TabIndex = 284
        Me.txt_fp_importar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.Navy
        Me.Label57.Location = New System.Drawing.Point(42, 96)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(78, 13)
        Me.Label57.TabIndex = 289
        Me.Label57.Text = "Forma de pago"
        '
        'txt_cod_cliente_importar
        '
        Me.txt_cod_cliente_importar.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_cliente_importar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_cliente_importar.Location = New System.Drawing.Point(125, 21)
        Me.txt_cod_cliente_importar.Name = "txt_cod_cliente_importar"
        Me.txt_cod_cliente_importar.ReadOnly = True
        Me.txt_cod_cliente_importar.Size = New System.Drawing.Size(134, 20)
        Me.txt_cod_cliente_importar.TabIndex = 278
        '
        'txt_tc_importar
        '
        Me.txt_tc_importar.BackColor = System.Drawing.Color.White
        Me.txt_tc_importar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tc_importar.Enabled = False
        Me.txt_tc_importar.Location = New System.Drawing.Point(700, 115)
        Me.txt_tc_importar.Name = "txt_tc_importar"
        Me.txt_tc_importar.ReadOnly = True
        Me.txt_tc_importar.Size = New System.Drawing.Size(51, 20)
        Me.txt_tc_importar.TabIndex = 283
        Me.txt_tc_importar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.ForeColor = System.Drawing.Color.Navy
        Me.Label58.Location = New System.Drawing.Point(642, 118)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(53, 13)
        Me.Label58.TabIndex = 288
        Me.Label58.Text = "T/cambio"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.Color.Navy
        Me.Label59.Location = New System.Drawing.Point(439, 119)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(46, 13)
        Me.Label59.TabIndex = 287
        Me.Label59.Text = "Moneda"
        '
        'cbo_moneda_importar
        '
        Me.cbo_moneda_importar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_moneda_importar.FormattingEnabled = True
        Me.cbo_moneda_importar.Location = New System.Drawing.Point(490, 115)
        Me.cbo_moneda_importar.Name = "cbo_moneda_importar"
        Me.cbo_moneda_importar.Size = New System.Drawing.Size(148, 21)
        Me.cbo_moneda_importar.TabIndex = 282
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.Navy
        Me.Label60.Location = New System.Drawing.Point(636, 24)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(27, 13)
        Me.Label60.TabIndex = 286
        Me.Label60.Text = "Ruc"
        '
        'txt_ruc_importar
        '
        Me.txt_ruc_importar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc_importar.Enabled = False
        Me.txt_ruc_importar.Location = New System.Drawing.Point(673, 21)
        Me.txt_ruc_importar.Name = "txt_ruc_importar"
        Me.txt_ruc_importar.Size = New System.Drawing.Size(78, 20)
        Me.txt_ruc_importar.TabIndex = 280
        Me.txt_ruc_importar.Text = " "
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.ForeColor = System.Drawing.Color.Navy
        Me.Label61.Location = New System.Drawing.Point(264, 25)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(68, 13)
        Me.Label61.TabIndex = 285
        Me.Label61.Text = "Razon social"
        '
        'txt_razon_social_importar
        '
        Me.txt_razon_social_importar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_razon_social_importar.Enabled = False
        Me.txt_razon_social_importar.Location = New System.Drawing.Point(337, 21)
        Me.txt_razon_social_importar.Name = "txt_razon_social_importar"
        Me.txt_razon_social_importar.Size = New System.Drawing.Size(290, 20)
        Me.txt_razon_social_importar.TabIndex = 279
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.ForeColor = System.Drawing.Color.Navy
        Me.Label62.Location = New System.Drawing.Point(81, 22)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(39, 13)
        Me.Label62.TabIndex = 277
        Me.Label62.Text = "Cliente"
        '
        'progreso
        '
        Me.progreso.ForeColor = System.Drawing.Color.Lime
        Me.progreso.Location = New System.Drawing.Point(23, 207)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(809, 18)
        Me.progreso.TabIndex = 24
        Me.progreso.Visible = False
        '
        'dgv_detalles_pedidos
        '
        Me.dgv_detalles_pedidos.AllowUserToAddRows = False
        Me.dgv_detalles_pedidos.AllowUserToDeleteRows = False
        Me.dgv_detalles_pedidos.AllowUserToOrderColumns = True
        Me.dgv_detalles_pedidos.AllowUserToResizeColumns = False
        Me.dgv_detalles_pedidos.AllowUserToResizeRows = False
        Me.dgv_detalles_pedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalles_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles_pedidos.Location = New System.Drawing.Point(25, 231)
        Me.dgv_detalles_pedidos.Name = "dgv_detalles_pedidos"
        Me.dgv_detalles_pedidos.ReadOnly = True
        Me.dgv_detalles_pedidos.Size = New System.Drawing.Size(0, 280)
        Me.dgv_detalles_pedidos.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(726, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 42)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_mostrar_ped
        '
        Me.btn_mostrar_ped.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrar_ped.Image = CType(resources.GetObject("btn_mostrar_ped.Image"), System.Drawing.Image)
        Me.btn_mostrar_ped.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_mostrar_ped.Location = New System.Drawing.Point(552, 10)
        Me.btn_mostrar_ped.Name = "btn_mostrar_ped"
        Me.btn_mostrar_ped.Size = New System.Drawing.Size(87, 42)
        Me.btn_mostrar_ped.TabIndex = 21
        Me.btn_mostrar_ped.Text = "&Mostrar Ped."
        Me.btn_mostrar_ped.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_mostrar_ped.UseVisualStyleBackColor = True
        '
        'btn_importar_ped
        '
        Me.btn_importar_ped.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_importar_ped.Image = CType(resources.GetObject("btn_importar_ped.Image"), System.Drawing.Image)
        Me.btn_importar_ped.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_importar_ped.Location = New System.Drawing.Point(639, 10)
        Me.btn_importar_ped.Name = "btn_importar_ped"
        Me.btn_importar_ped.Size = New System.Drawing.Size(87, 42)
        Me.btn_importar_ped.TabIndex = 20
        Me.btn_importar_ped.Text = "&Importar"
        Me.btn_importar_ped.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_importar_ped.UseVisualStyleBackColor = True
        '
        'cbo_cliente
        '
        Me.cbo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cliente.FormattingEnabled = True
        Me.cbo_cliente.Items.AddRange(New Object() {"Cencosud", "Supermercados Peruanos", "Supermercado Tottus"})
        Me.cbo_cliente.Location = New System.Drawing.Point(118, 9)
        Me.cbo_cliente.Name = "cbo_cliente"
        Me.cbo_cliente.Size = New System.Drawing.Size(232, 21)
        Me.cbo_cliente.TabIndex = 19
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.Navy
        Me.Label48.Location = New System.Drawing.Point(22, 15)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(45, 13)
        Me.Label48.TabIndex = 18
        Me.Label48.Text = "Cliente :"
        '
        'dgvdetalles
        '
        Me.dgvdetalles.AllowUserToAddRows = False
        Me.dgvdetalles.AllowUserToDeleteRows = False
        Me.dgvdetalles.AllowUserToResizeColumns = False
        Me.dgvdetalles.AllowUserToResizeRows = False
        Me.dgvdetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles.Location = New System.Drawing.Point(25, 489)
        Me.dgvdetalles.Name = "dgvdetalles"
        Me.dgvdetalles.ReadOnly = True
        Me.dgvdetalles.Size = New System.Drawing.Size(0, 105)
        Me.dgvdetalles.TabIndex = 17
        Me.dgvdetalles.Visible = False
        '
        'btn_ruta
        '
        Me.btn_ruta.Location = New System.Drawing.Point(508, 30)
        Me.btn_ruta.Name = "btn_ruta"
        Me.btn_ruta.Size = New System.Drawing.Size(38, 23)
        Me.btn_ruta.TabIndex = 14
        Me.btn_ruta.Text = "..."
        Me.btn_ruta.UseVisualStyleBackColor = True
        '
        'txt_ruta
        '
        Me.txt_ruta.Location = New System.Drawing.Point(118, 32)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.ReadOnly = True
        Me.txt_ruta.Size = New System.Drawing.Size(384, 20)
        Me.txt_ruta.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(22, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Ruta de Archivo :"
        '
        'lblDetalle
        '
        Me.lblDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetalle.BackColor = System.Drawing.Color.White
        Me.lblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalle.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblDetalle.Location = New System.Drawing.Point(2, 18)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(853, 20)
        Me.lblDetalle.TabIndex = 198
        Me.lblDetalle.Text = "LISTADO DE  PEDIDOS"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(17, 515)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 124
        Me.lblCantidad.Text = "."
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(470, 52)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 123
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(183, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(250, 15)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(7, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 13)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Fecha inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(82, 15)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 45)
        Me.GroupBox3.TabIndex = 121
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
        Me.txtFiltro.Size = New System.Drawing.Size(245, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(276, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 45)
        Me.GroupBox2.TabIndex = 122
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
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(176, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'gbcabecera
        '
        Me.gbcabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbcabecera.Controls.Add(Me.lbl_centro_costo)
        Me.gbcabecera.Controls.Add(Me.PictureBox3)
        Me.gbcabecera.Controls.Add(Me.txt_centro_costo)
        Me.gbcabecera.Controls.Add(Me.Label30)
        Me.gbcabecera.Controls.Add(Me.cbo_direc_entrega)
        Me.gbcabecera.Controls.Add(Me.Label19)
        Me.gbcabecera.Controls.Add(Me.txttrama)
        Me.gbcabecera.Controls.Add(Me.Label2)
        Me.gbcabecera.Controls.Add(Me.Label14)
        Me.gbcabecera.Controls.Add(Me.txtdireccion)
        Me.gbcabecera.Controls.Add(Me.lblPtoVenta)
        Me.gbcabecera.Controls.Add(Me.lblAlmacen)
        Me.gbcabecera.Controls.Add(Me.PictureBox10)
        Me.gbcabecera.Controls.Add(Me.txtAlmacen)
        Me.gbcabecera.Controls.Add(Me.txtPtoVenta)
        Me.gbcabecera.Controls.Add(Me.Label1)
        Me.gbcabecera.Controls.Add(Me.Label3)
        Me.gbcabecera.Controls.Add(Me.lblvendedor)
        Me.gbcabecera.Controls.Add(Me.lblformapago)
        Me.gbcabecera.Controls.Add(Me.PictureBox2)
        Me.gbcabecera.Controls.Add(Me.txtFormaPago)
        Me.gbcabecera.Controls.Add(Me.Label12)
        Me.gbcabecera.Controls.Add(Me.txtordencompra)
        Me.gbcabecera.Controls.Add(Me.Label17)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.lblcompra)
        Me.gbcabecera.Controls.Add(Me.PictureBox1)
        Me.gbcabecera.Controls.Add(Me.txtcliente)
        Me.gbcabecera.Controls.Add(Me.PictureBox4)
        Me.gbcabecera.Controls.Add(Me.txtvendedor)
        Me.gbcabecera.Controls.Add(Me.Label9)
        Me.gbcabecera.Controls.Add(Me.dtp_vencimiento)
        Me.gbcabecera.Controls.Add(Me.Label50)
        Me.gbcabecera.Controls.Add(Me.dtp_emision)
        Me.gbcabecera.Controls.Add(Me.Label49)
        Me.gbcabecera.Controls.Add(Me.txttipoCambio)
        Me.gbcabecera.Controls.Add(Me.Label11)
        Me.gbcabecera.Controls.Add(Me.Label10)
        Me.gbcabecera.Controls.Add(Me.cbomoneda)
        Me.gbcabecera.Controls.Add(Me.Label8)
        Me.gbcabecera.Controls.Add(Me.txtruc)
        Me.gbcabecera.Controls.Add(Me.Label6)
        Me.gbcabecera.Controls.Add(Me.txtrazonsocial)
        Me.gbcabecera.Controls.Add(Me.txtestado)
        Me.gbcabecera.Controls.Add(Me.Label4)
        Me.gbcabecera.Controls.Add(Me.Label5)
        Me.gbcabecera.ForeColor = System.Drawing.Color.Navy
        Me.gbcabecera.Location = New System.Drawing.Point(6, 6)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(841, 230)
        Me.gbcabecera.TabIndex = 178
        Me.gbcabecera.TabStop = False
        '
        'lbl_centro_costo
        '
        Me.lbl_centro_costo.AutoSize = True
        Me.lbl_centro_costo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_centro_costo.ForeColor = System.Drawing.Color.Navy
        Me.lbl_centro_costo.Location = New System.Drawing.Point(178, 189)
        Me.lbl_centro_costo.Name = "lbl_centro_costo"
        Me.lbl_centro_costo.Size = New System.Drawing.Size(16, 13)
        Me.lbl_centro_costo.TabIndex = 254
        Me.lbl_centro_costo.Text = "..."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(155, 187)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 253
        Me.PictureBox3.TabStop = False
        '
        'txt_centro_costo
        '
        Me.txt_centro_costo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_centro_costo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_centro_costo.Location = New System.Drawing.Point(97, 186)
        Me.txt_centro_costo.Name = "txt_centro_costo"
        Me.txt_centro_costo.ReadOnly = True
        Me.txt_centro_costo.Size = New System.Drawing.Size(55, 20)
        Me.txt_centro_costo.TabIndex = 251
        Me.txt_centro_costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(9, 189)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 13)
        Me.Label30.TabIndex = 252
        Me.Label30.Text = "Centro de Costo"
        '
        'cbo_direc_entrega
        '
        Me.cbo_direc_entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_direc_entrega.ForeColor = System.Drawing.Color.Black
        Me.cbo_direc_entrega.FormattingEnabled = True
        Me.cbo_direc_entrega.Location = New System.Drawing.Point(97, 86)
        Me.cbo_direc_entrega.Name = "cbo_direc_entrega"
        Me.cbo_direc_entrega.Size = New System.Drawing.Size(626, 21)
        Me.cbo_direc_entrega.TabIndex = 250
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(17, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 249
        Me.Label19.Text = "Direc. Entrega"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txttrama
        '
        Me.txttrama.BackColor = System.Drawing.Color.White
        Me.txttrama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttrama.Location = New System.Drawing.Point(293, 161)
        Me.txttrama.Name = "txttrama"
        Me.txttrama.Size = New System.Drawing.Size(125, 20)
        Me.txttrama.TabIndex = 18
        Me.txttrama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txttrama.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(250, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 248
        Me.Label2.Text = "Trama"
        Me.Label2.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(40, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 246
        Me.Label14.Text = "Direccion"
        '
        'txtdireccion
        '
        Me.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Location = New System.Drawing.Point(97, 63)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(626, 20)
        Me.txtdireccion.TabIndex = 12
        '
        'lblPtoVenta
        '
        Me.lblPtoVenta.BackColor = System.Drawing.Color.White
        Me.lblPtoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPtoVenta.Enabled = False
        Me.lblPtoVenta.Location = New System.Drawing.Point(542, 166)
        Me.lblPtoVenta.Name = "lblPtoVenta"
        Me.lblPtoVenta.ReadOnly = True
        Me.lblPtoVenta.Size = New System.Drawing.Size(147, 20)
        Me.lblPtoVenta.TabIndex = 2
        Me.lblPtoVenta.Visible = False
        '
        'lblAlmacen
        '
        Me.lblAlmacen.BackColor = System.Drawing.Color.White
        Me.lblAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlmacen.Enabled = False
        Me.lblAlmacen.Location = New System.Drawing.Point(734, 166)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.ReadOnly = True
        Me.lblAlmacen.Size = New System.Drawing.Size(85, 20)
        Me.lblAlmacen.TabIndex = 4
        Me.lblAlmacen.Visible = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Enabled = False
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(522, 167)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox10.TabIndex = 242
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Visible = False
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlmacen.Enabled = False
        Me.txtAlmacen.Location = New System.Drawing.Point(692, 166)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(42, 20)
        Me.txtAlmacen.TabIndex = 3
        Me.txtAlmacen.Visible = False
        '
        'txtPtoVenta
        '
        Me.txtPtoVenta.BackColor = System.Drawing.Color.White
        Me.txtPtoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPtoVenta.Enabled = False
        Me.txtPtoVenta.Location = New System.Drawing.Point(470, 166)
        Me.txtPtoVenta.Name = "txtPtoVenta"
        Me.txtPtoVenta.ReadOnly = True
        Me.txtPtoVenta.Size = New System.Drawing.Size(50, 20)
        Me.txtPtoVenta.TabIndex = 1
        Me.txtPtoVenta.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(692, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Almacén"
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(471, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "Punto de venta"
        Me.Label3.Visible = False
        '
        'lblvendedor
        '
        Me.lblvendedor.AutoSize = True
        Me.lblvendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvendedor.ForeColor = System.Drawing.Color.Navy
        Me.lblvendedor.Location = New System.Drawing.Point(178, 115)
        Me.lblvendedor.Name = "lblvendedor"
        Me.lblvendedor.Size = New System.Drawing.Size(16, 13)
        Me.lblvendedor.TabIndex = 237
        Me.lblvendedor.Text = "..."
        '
        'lblformapago
        '
        Me.lblformapago.AutoSize = True
        Me.lblformapago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblformapago.ForeColor = System.Drawing.Color.Navy
        Me.lblformapago.Location = New System.Drawing.Point(178, 140)
        Me.lblformapago.Name = "lblformapago"
        Me.lblformapago.Size = New System.Drawing.Size(16, 13)
        Me.lblformapago.TabIndex = 236
        Me.lblformapago.Text = "..."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(155, 138)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 235
        Me.PictureBox2.TabStop = False
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormaPago.Location = New System.Drawing.Point(97, 137)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(55, 20)
        Me.txtFormaPago.TabIndex = 16
        Me.txtFormaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(14, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 234
        Me.Label12.Text = "Forma de pago"
        '
        'txtordencompra
        '
        Me.txtordencompra.BackColor = System.Drawing.Color.White
        Me.txtordencompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtordencompra.Location = New System.Drawing.Point(97, 161)
        Me.txtordencompra.MaxLength = 20
        Me.txtordencompra.Name = "txtordencompra"
        Me.txtordencompra.Size = New System.Drawing.Size(147, 20)
        Me.txtordencompra.TabIndex = 17
        Me.txtordencompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(3, 164)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 13)
        Me.Label17.TabIndex = 230
        Me.Label17.Text = "Orden de compra"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(97, 12)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(135, 21)
        Me.txtcodigo.TabIndex = 5
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcompra
        '
        Me.lblcompra.AutoSize = True
        Me.lblcompra.ForeColor = System.Drawing.Color.Navy
        Me.lblcompra.Location = New System.Drawing.Point(9, 14)
        Me.lblcompra.Name = "lblcompra"
        Me.lblcompra.Size = New System.Drawing.Size(83, 13)
        Me.lblcompra.TabIndex = 228
        Me.lblcompra.Text = "Nro documento "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(210, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 16)
        Me.PictureBox1.TabIndex = 212
        Me.PictureBox1.TabStop = False
        '
        'txtcliente
        '
        Me.txtcliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcliente.Location = New System.Drawing.Point(97, 39)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.ReadOnly = True
        Me.txtcliente.Size = New System.Drawing.Size(134, 20)
        Me.txtcliente.TabIndex = 9
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(154, 112)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 227
        Me.PictureBox4.TabStop = False
        '
        'txtvendedor
        '
        Me.txtvendedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtvendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvendedor.Location = New System.Drawing.Point(97, 111)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.ReadOnly = True
        Me.txtvendedor.Size = New System.Drawing.Size(55, 20)
        Me.txtvendedor.TabIndex = 13
        Me.txtvendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(40, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 226
        Me.Label9.Text = "Vendedor"
        '
        'dtp_vencimiento
        '
        Me.dtp_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_vencimiento.Location = New System.Drawing.Point(434, 15)
        Me.dtp_vencimiento.Name = "dtp_vencimiento"
        Me.dtp_vencimiento.Size = New System.Drawing.Size(95, 20)
        Me.dtp_vencimiento.TabIndex = 7
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label50.ForeColor = System.Drawing.Color.Navy
        Me.Label50.Location = New System.Drawing.Point(385, 17)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(44, 13)
        Me.Label50.TabIndex = 223
        Me.Label50.Text = "Entrega"
        '
        'dtp_emision
        '
        Me.dtp_emision.Enabled = False
        Me.dtp_emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_emision.Location = New System.Drawing.Point(283, 14)
        Me.dtp_emision.Name = "dtp_emision"
        Me.dtp_emision.Size = New System.Drawing.Size(95, 20)
        Me.dtp_emision.TabIndex = 6
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(235, 16)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(43, 13)
        Me.Label49.TabIndex = 221
        Me.Label49.Text = "Emision"
        '
        'txttipoCambio
        '
        Me.txttipoCambio.BackColor = System.Drawing.Color.White
        Me.txttipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipoCambio.Enabled = False
        Me.txttipoCambio.Location = New System.Drawing.Point(722, 111)
        Me.txttipoCambio.Name = "txttipoCambio"
        Me.txttipoCambio.ReadOnly = True
        Me.txttipoCambio.Size = New System.Drawing.Size(51, 20)
        Me.txttipoCambio.TabIndex = 15
        Me.txttipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(665, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "T/cambio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(465, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Moneda"
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(516, 110)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(148, 21)
        Me.cbomoneda.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(608, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 187
        Me.Label8.Text = "Ruc"
        '
        'txtruc
        '
        Me.txtruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtruc.Enabled = False
        Me.txtruc.Location = New System.Drawing.Point(645, 39)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(78, 20)
        Me.txtruc.TabIndex = 11
        Me.txtruc.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(236, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 185
        Me.Label6.Text = "Razon social"
        '
        'txtrazonsocial
        '
        Me.txtrazonsocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrazonsocial.Enabled = False
        Me.txtrazonsocial.Location = New System.Drawing.Point(309, 39)
        Me.txtrazonsocial.Name = "txtrazonsocial"
        Me.txtrazonsocial.Size = New System.Drawing.Size(290, 20)
        Me.txtrazonsocial.TabIndex = 10
        '
        'txtestado
        '
        Me.txtestado.BackColor = System.Drawing.Color.White
        Me.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtestado.Enabled = False
        Me.txtestado.Location = New System.Drawing.Point(586, 14)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.ReadOnly = True
        Me.txtestado.Size = New System.Drawing.Size(108, 20)
        Me.txtestado.TabIndex = 8
        Me.txtestado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtestado.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(542, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 182
        Me.Label4.Text = "Estado"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(53, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cliente"
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.dgvDetalle)
        Me.gbDetalles.Location = New System.Drawing.Point(6, 271)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(769, 171)
        Me.gbDetalles.TabIndex = 179
        Me.gbDetalles.TabStop = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(8, 11)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(755, 155)
        Me.dgvDetalle.TabIndex = 0
        '
        'txtglosa
        '
        Me.txtglosa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtglosa.BackColor = System.Drawing.Color.White
        Me.txtglosa.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtglosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtglosa.Location = New System.Drawing.Point(55, 244)
        Me.txtglosa.MaxLength = 100
        Me.txtglosa.Name = "txtglosa"
        Me.txtglosa.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtglosa.Size = New System.Drawing.Size(714, 26)
        Me.txtglosa.TabIndex = 20
        Me.txtglosa.Text = ""
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Location = New System.Drawing.Point(781, 271)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(67, 171)
        Me.gbOpciones.TabIndex = 182
        Me.gbOpciones.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(5, 67)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(58, 42)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnquitar.Location = New System.Drawing.Point(5, 119)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(58, 42)
        Me.btnquitar.TabIndex = 20
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(5, 15)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(58, 42)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(16, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Glosa"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.White
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.Location = New System.Drawing.Point(668, 488)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(89, 21)
        Me.txtPrecioVenta.TabIndex = 25
        Me.txtPrecioVenta.Text = "0.00"
        Me.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(589, 491)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 13)
        Me.Label28.TabIndex = 194
        Me.Label28.Text = "&Precio Venta"
        '
        'txtIgv
        '
        Me.txtIgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIgv.BackColor = System.Drawing.Color.White
        Me.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIgv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgv.Location = New System.Drawing.Point(668, 465)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(89, 21)
        Me.txtIgv.TabIndex = 24
        Me.txtIgv.Text = "0.00"
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(626, 469)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 13)
        Me.Label24.TabIndex = 192
        Me.Label24.Text = "&I.G.V"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentos.BackColor = System.Drawing.Color.White
        Me.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentos.Location = New System.Drawing.Point(501, 443)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(89, 21)
        Me.txtDescuentos.TabIndex = 22
        Me.txtDescuentos.Text = "0.00"
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(432, 447)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 190
        Me.Label23.Text = "&Descuento"
        '
        'txtvalorVenta
        '
        Me.txtvalorVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvalorVenta.BackColor = System.Drawing.Color.White
        Me.txtvalorVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalorVenta.Location = New System.Drawing.Point(668, 443)
        Me.txtvalorVenta.Name = "txtvalorVenta"
        Me.txtvalorVenta.Size = New System.Drawing.Size(89, 21)
        Me.txtvalorVenta.TabIndex = 23
        Me.txtvalorVenta.Text = "0.00"
        Me.txtvalorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(595, 446)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 188
        Me.Label22.Text = "&Valor Venta"
        '
        'txtBruto
        '
        Me.txtBruto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBruto.BackColor = System.Drawing.Color.White
        Me.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBruto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBruto.Location = New System.Drawing.Point(339, 444)
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.ReadOnly = True
        Me.txtBruto.Size = New System.Drawing.Size(89, 21)
        Me.txtBruto.TabIndex = 21
        Me.txtBruto.Text = "0.00"
        Me.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(265, 448)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 186
        Me.Label13.Text = "Valor Bruto"
        '
        'Tc_principal
        '
        Me.Tc_principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tc_principal.Controls.Add(Me.tc_datos)
        Me.Tc_principal.Controls.Add(Me.tc_detalle)
        Me.Tc_principal.Location = New System.Drawing.Point(13, 35)
        Me.Tc_principal.Multiline = True
        Me.Tc_principal.Name = "Tc_principal"
        Me.Tc_principal.SelectedIndex = 0
        Me.Tc_principal.Size = New System.Drawing.Size(866, 540)
        Me.Tc_principal.TabIndex = 196
        '
        'tc_datos
        '
        Me.tc_datos.BackColor = System.Drawing.Color.White
        Me.tc_datos.Controls.Add(Me.gbcabecera)
        Me.tc_datos.Controls.Add(Me.Label13)
        Me.tc_datos.Controls.Add(Me.txtBruto)
        Me.tc_datos.Controls.Add(Me.Label22)
        Me.tc_datos.Controls.Add(Me.txtvalorVenta)
        Me.tc_datos.Controls.Add(Me.Label23)
        Me.tc_datos.Controls.Add(Me.txtDescuentos)
        Me.tc_datos.Controls.Add(Me.Label24)
        Me.tc_datos.Controls.Add(Me.txtIgv)
        Me.tc_datos.Controls.Add(Me.Label7)
        Me.tc_datos.Controls.Add(Me.Label28)
        Me.tc_datos.Controls.Add(Me.gbOpciones)
        Me.tc_datos.Controls.Add(Me.txtPrecioVenta)
        Me.tc_datos.Controls.Add(Me.txtglosa)
        Me.tc_datos.Controls.Add(Me.gbDetalles)
        Me.tc_datos.Location = New System.Drawing.Point(4, 22)
        Me.tc_datos.Name = "tc_datos"
        Me.tc_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_datos.Size = New System.Drawing.Size(858, 514)
        Me.tc_datos.TabIndex = 0
        Me.tc_datos.Text = "Datos de la orden de compra"
        '
        'tc_detalle
        '
        Me.tc_detalle.BackColor = System.Drawing.Color.White
        Me.tc_detalle.Controls.Add(Me.GroupBox1)
        Me.tc_detalle.Location = New System.Drawing.Point(4, 22)
        Me.tc_detalle.Name = "tc_detalle"
        Me.tc_detalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_detalle.Size = New System.Drawing.Size(858, 514)
        Me.tc_detalle.TabIndex = 1
        Me.tc_detalle.Text = "Detalles de orden de compra"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.pnl_stock)
        Me.GroupBox1.Controls.Add(Me.txtcomentario)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.txtarea)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.txtproyecto)
        Me.GroupBox1.Controls.Add(Me.txtcentroCosto)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(113, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 408)
        Me.GroupBox1.TabIndex = 216
        Me.GroupBox1.TabStop = False
        '
        'pnl_stock
        '
        Me.pnl_stock.Controls.Add(Me.dgv_stock)
        Me.pnl_stock.Location = New System.Drawing.Point(20, 415)
        Me.pnl_stock.Name = "pnl_stock"
        Me.pnl_stock.Size = New System.Drawing.Size(615, 11)
        Me.pnl_stock.TabIndex = 220
        Me.pnl_stock.Visible = False
        '
        'dgv_stock
        '
        Me.dgv_stock.AllowUserToAddRows = False
        Me.dgv_stock.AllowUserToDeleteRows = False
        Me.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_stock.Location = New System.Drawing.Point(10, 3)
        Me.dgv_stock.Name = "dgv_stock"
        Me.dgv_stock.ReadOnly = True
        Me.dgv_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_stock.Size = New System.Drawing.Size(591, 113)
        Me.dgv_stock.TabIndex = 205
        '
        'txtcomentario
        '
        Me.txtcomentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcomentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomentario.Location = New System.Drawing.Point(85, 335)
        Me.txtcomentario.MaxLength = 100
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(549, 20)
        Me.txtcomentario.TabIndex = 217
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(20, 337)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 218
        Me.Label16.Text = "Comentario"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.txtStockLote)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.cboLotes)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(15, 416)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(619, 10)
        Me.GroupBox7.TabIndex = 216
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(64, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "&Lotes"
        '
        'txtStockLote
        '
        Me.txtStockLote.BackColor = System.Drawing.Color.White
        Me.txtStockLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockLote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockLote.ForeColor = System.Drawing.Color.Black
        Me.txtStockLote.Location = New System.Drawing.Point(310, 14)
        Me.txtStockLote.Name = "txtStockLote"
        Me.txtStockLote.ReadOnly = True
        Me.txtStockLote.Size = New System.Drawing.Size(76, 21)
        Me.txtStockLote.TabIndex = 26
        Me.txtStockLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(246, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Stock Lote"
        '
        'cboLotes
        '
        Me.cboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLotes.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cboLotes.FormattingEnabled = True
        Me.cboLotes.Location = New System.Drawing.Point(107, 11)
        Me.cboLotes.Name = "cboLotes"
        Me.cboLotes.Size = New System.Drawing.Size(134, 26)
        Me.cboLotes.TabIndex = 2
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.lbl_centro_costo_detalle)
        Me.GroupBox6.Controls.Add(Me.PictureBox11)
        Me.GroupBox6.Controls.Add(Me.txt_centro_costo_detalle)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.PictureBox8)
        Me.GroupBox6.Controls.Add(Me.txtunidadMedRef)
        Me.GroupBox6.Controls.Add(Me.Label45)
        Me.GroupBox6.Controls.Add(Me.PictureBox9)
        Me.GroupBox6.Controls.Add(Me.txtunidadMedida)
        Me.GroupBox6.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox6.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox6.Controls.Add(Me.Label46)
        Me.GroupBox6.Controls.Add(Me.Label47)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(619, 110)
        Me.GroupBox6.TabIndex = 198
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Detalles del Articulo"
        '
        'lbl_centro_costo_detalle
        '
        Me.lbl_centro_costo_detalle.AutoSize = True
        Me.lbl_centro_costo_detalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_centro_costo_detalle.ForeColor = System.Drawing.Color.Navy
        Me.lbl_centro_costo_detalle.Location = New System.Drawing.Point(175, 75)
        Me.lbl_centro_costo_detalle.Name = "lbl_centro_costo_detalle"
        Me.lbl_centro_costo_detalle.Size = New System.Drawing.Size(16, 13)
        Me.lbl_centro_costo_detalle.TabIndex = 258
        Me.lbl_centro_costo_detalle.Text = "..."
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(148, 73)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox11.TabIndex = 257
        Me.PictureBox11.TabStop = False
        '
        'txt_centro_costo_detalle
        '
        Me.txt_centro_costo_detalle.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_centro_costo_detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_centro_costo_detalle.Location = New System.Drawing.Point(70, 72)
        Me.txt_centro_costo_detalle.Name = "txt_centro_costo_detalle"
        Me.txt_centro_costo_detalle.ReadOnly = True
        Me.txt_centro_costo_detalle.Size = New System.Drawing.Size(74, 20)
        Me.txt_centro_costo_detalle.TabIndex = 255
        Me.txt_centro_costo_detalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(3, 75)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(62, 13)
        Me.Label31.TabIndex = 256
        Me.Label31.Text = "C. de Costo"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(248, 46)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox8.TabIndex = 113
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'txtunidadMedRef
        '
        Me.txtunidadMedRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedRef.Enabled = False
        Me.txtunidadMedRef.Location = New System.Drawing.Point(269, 46)
        Me.txtunidadMedRef.Name = "txtunidadMedRef"
        Me.txtunidadMedRef.Size = New System.Drawing.Size(56, 20)
        Me.txtunidadMedRef.TabIndex = 3
        Me.txtunidadMedRef.Visible = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(170, 50)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(73, 13)
        Me.Label45.TabIndex = 113
        Me.Label45.Text = "Unid.Med Ref"
        Me.Label45.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(148, 22)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox9.TabIndex = 112
        Me.PictureBox9.TabStop = False
        '
        'txtunidadMedida
        '
        Me.txtunidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedida.Location = New System.Drawing.Point(71, 46)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.ReadOnly = True
        Me.txtunidadMedida.Size = New System.Drawing.Size(73, 20)
        Me.txtunidadMedida.TabIndex = 2
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Enabled = False
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(173, 21)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(438, 20)
        Me.txtdescripcionArticulo.TabIndex = 1
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(71, 21)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(73, 21)
        Me.txtcodigoArticulo.TabIndex = 0
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(25, 22)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(42, 13)
        Me.Label46.TabIndex = 10
        Me.Label46.Text = "Articulo"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(11, 50)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(56, 13)
        Me.Label47.TabIndex = 5
        Me.Label47.Text = "Unid. Med"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.ForeColor = System.Drawing.Color.Blue
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.Location = New System.Drawing.Point(331, 364)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(69, 38)
        Me.btn_cancel.TabIndex = 209
        Me.btn_cancel.Text = "&Retornar"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(256, 364)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(69, 38)
        Me.btnAceptar.TabIndex = 208
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(328, 416)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(125, 20)
        Me.txtarea.TabIndex = 20
        Me.txtarea.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtcantidadref)
        Me.GroupBox5.Controls.Add(Me.btn_stock)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.txtcantidad)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(15, 153)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(619, 48)
        Me.GroupBox5.TabIndex = 199
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cantidad a Comprar"
        '
        'txtcantidadref
        '
        Me.txtcantidadref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidadref.Enabled = False
        Me.txtcantidadref.Location = New System.Drawing.Point(523, 19)
        Me.txtcantidadref.Name = "txtcantidadref"
        Me.txtcantidadref.Size = New System.Drawing.Size(88, 20)
        Me.txtcantidadref.TabIndex = 5
        Me.txtcantidadref.Visible = False
        '
        'btn_stock
        '
        Me.btn_stock.Location = New System.Drawing.Point(163, 18)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Size = New System.Drawing.Size(80, 23)
        Me.btn_stock.TabIndex = 219
        Me.btn_stock.Text = "Ver stock"
        Me.btn_stock.UseVisualStyleBackColor = True
        Me.btn_stock.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(468, 23)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(52, 13)
        Me.Label43.TabIndex = 53
        Me.Label43.Text = "Cant. Ref"
        Me.Label43.Visible = False
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Location = New System.Drawing.Point(71, 19)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(88, 20)
        Me.txtcantidad.TabIndex = 4
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label44.ForeColor = System.Drawing.Color.Navy
        Me.Label44.Location = New System.Drawing.Point(32, 21)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(32, 13)
        Me.Label44.TabIndex = 5
        Me.Label44.Text = "Cant."
        '
        'txtproyecto
        '
        Me.txtproyecto.Location = New System.Drawing.Point(137, 439)
        Me.txtproyecto.Name = "txtproyecto"
        Me.txtproyecto.Size = New System.Drawing.Size(316, 20)
        Me.txtproyecto.TabIndex = 21
        Me.txtproyecto.Visible = False
        '
        'txtcentroCosto
        '
        Me.txtcentroCosto.Location = New System.Drawing.Point(137, 416)
        Me.txtcentroCosto.Name = "txtcentroCosto"
        Me.txtcentroCosto.Size = New System.Drawing.Size(125, 20)
        Me.txtcentroCosto.TabIndex = 19
        Me.txtcentroCosto.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(27, 419)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 13)
        Me.Label29.TabIndex = 210
        Me.Label29.Text = "Centro de Costo"
        Me.Label29.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(114, 439)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 215
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(307, 416)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox5.TabIndex = 213
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(272, 419)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 13)
        Me.Label27.TabIndex = 212
        Me.Label27.Text = "Area"
        Me.Label27.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(114, 417)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox7.TabIndex = 211
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.chkigv)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.txtvalorvent)
        Me.GroupBox4.Controls.Add(Me.txttasa)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.txttotalneto)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.txtdescuento)
        Me.GroupBox4.Controls.Add(Me.txt_igv)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.txtvalorbruto)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.txtpreciounitario)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.txtvalorventaunit)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.txtvalorventaref)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Controls.Add(Me.txtValorunitario)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.txtporc_descuento)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(16, 204)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(619, 125)
        Me.GroupBox4.TabIndex = 201
        Me.GroupBox4.TabStop = False
        '
        'chkigv
        '
        Me.chkigv.AutoSize = True
        Me.chkigv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkigv.ForeColor = System.Drawing.Color.Navy
        Me.chkigv.Location = New System.Drawing.Point(387, 101)
        Me.chkigv.Name = "chkigv"
        Me.chkigv.Size = New System.Drawing.Size(93, 17)
        Me.chkigv.TabIndex = 55
        Me.chkigv.Text = "Incluido Igv"
        Me.chkigv.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(215, 100)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(57, 13)
        Me.Label32.TabIndex = 71
        Me.Label32.Text = "Total Neto"
        '
        'txtvalorvent
        '
        Me.txtvalorvent.BackColor = System.Drawing.Color.White
        Me.txtvalorvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorvent.Enabled = False
        Me.txtvalorvent.Location = New System.Drawing.Point(456, 72)
        Me.txtvalorvent.Name = "txtvalorvent"
        Me.txtvalorvent.ReadOnly = True
        Me.txtvalorvent.Size = New System.Drawing.Size(88, 20)
        Me.txtvalorvent.TabIndex = 15
        Me.txtvalorvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttasa
        '
        Me.txttasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttasa.Enabled = False
        Me.txttasa.Location = New System.Drawing.Point(412, 17)
        Me.txttasa.Name = "txttasa"
        Me.txttasa.Size = New System.Drawing.Size(88, 20)
        Me.txttasa.TabIndex = 9
        Me.txttasa.Text = "18"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(346, 21)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(60, 13)
        Me.Label41.TabIndex = 55
        Me.Label41.Text = "%Tasa IGV"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(388, 77)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 13)
        Me.Label33.TabIndex = 69
        Me.Label33.Text = "Valor Venta"
        '
        'txttotalneto
        '
        Me.txttotalneto.BackColor = System.Drawing.Color.White
        Me.txttotalneto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalneto.Enabled = False
        Me.txttotalneto.Location = New System.Drawing.Point(291, 98)
        Me.txttotalneto.Name = "txttotalneto"
        Me.txttotalneto.ReadOnly = True
        Me.txttotalneto.Size = New System.Drawing.Size(88, 20)
        Me.txttotalneto.TabIndex = 17
        Me.txttotalneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(213, 75)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(59, 13)
        Me.Label34.TabIndex = 61
        Me.Label34.Text = "Descuento"
        '
        'txtdescuento
        '
        Me.txtdescuento.BackColor = System.Drawing.Color.White
        Me.txtdescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescuento.Enabled = False
        Me.txtdescuento.Location = New System.Drawing.Point(291, 74)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.ReadOnly = True
        Me.txtdescuento.Size = New System.Drawing.Size(88, 20)
        Me.txtdescuento.TabIndex = 14
        Me.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_igv
        '
        Me.txt_igv.BackColor = System.Drawing.Color.White
        Me.txt_igv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_igv.Enabled = False
        Me.txt_igv.Location = New System.Drawing.Point(112, 96)
        Me.txt_igv.Name = "txt_igv"
        Me.txt_igv.ReadOnly = True
        Me.txt_igv.Size = New System.Drawing.Size(88, 20)
        Me.txt_igv.TabIndex = 16
        Me.txt_igv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(82, 98)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(22, 13)
        Me.Label35.TabIndex = 59
        Me.Label35.Text = "Igv"
        '
        'txtvalorbruto
        '
        Me.txtvalorbruto.BackColor = System.Drawing.Color.White
        Me.txtvalorbruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorbruto.Enabled = False
        Me.txtvalorbruto.Location = New System.Drawing.Point(112, 72)
        Me.txtvalorbruto.Name = "txtvalorbruto"
        Me.txtvalorbruto.ReadOnly = True
        Me.txtvalorbruto.Size = New System.Drawing.Size(88, 20)
        Me.txtvalorbruto.TabIndex = 13
        Me.txtvalorbruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(43, 74)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(59, 13)
        Me.Label36.TabIndex = 65
        Me.Label36.Text = "Valor Bruto"
        '
        'txtpreciounitario
        '
        Me.txtpreciounitario.BackColor = System.Drawing.Color.White
        Me.txtpreciounitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpreciounitario.Enabled = False
        Me.txtpreciounitario.Location = New System.Drawing.Point(456, 48)
        Me.txtpreciounitario.Name = "txtpreciounitario"
        Me.txtpreciounitario.ReadOnly = True
        Me.txtpreciounitario.Size = New System.Drawing.Size(88, 20)
        Me.txtpreciounitario.TabIndex = 12
        Me.txtpreciounitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label37.ForeColor = System.Drawing.Color.Navy
        Me.Label37.Location = New System.Drawing.Point(390, 51)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 13)
        Me.Label37.TabIndex = 63
        Me.Label37.Text = "Precio Unit"
        '
        'txtvalorventaunit
        '
        Me.txtvalorventaunit.BackColor = System.Drawing.Color.White
        Me.txtvalorventaunit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorventaunit.Enabled = False
        Me.txtvalorventaunit.Location = New System.Drawing.Point(291, 49)
        Me.txtvalorventaunit.Name = "txtvalorventaunit"
        Me.txtvalorventaunit.ReadOnly = True
        Me.txtvalorventaunit.Size = New System.Drawing.Size(88, 20)
        Me.txtvalorventaunit.TabIndex = 11
        Me.txtvalorventaunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(212, 52)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 13)
        Me.Label38.TabIndex = 61
        Me.Label38.Text = "Valor Vta Unit"
        '
        'txtvalorventaref
        '
        Me.txtvalorventaref.BackColor = System.Drawing.Color.White
        Me.txtvalorventaref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorventaref.Enabled = False
        Me.txtvalorventaref.Location = New System.Drawing.Point(112, 49)
        Me.txtvalorventaref.Name = "txtvalorventaref"
        Me.txtvalorventaref.ReadOnly = True
        Me.txtvalorventaref.Size = New System.Drawing.Size(88, 20)
        Me.txtvalorventaref.TabIndex = 10
        Me.txtvalorventaref.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(9, 51)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(92, 13)
        Me.Label39.TabIndex = 59
        Me.Label39.Text = "Valor Vta Unit Ref"
        '
        'txtValorunitario
        '
        Me.txtValorunitario.BackColor = System.Drawing.Color.Aquamarine
        Me.txtValorunitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorunitario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorunitario.Location = New System.Drawing.Point(71, 17)
        Me.txtValorunitario.Name = "txtValorunitario"
        Me.txtValorunitario.Size = New System.Drawing.Size(88, 21)
        Me.txtValorunitario.TabIndex = 7
        Me.txtValorunitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(9, 21)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(53, 13)
        Me.Label40.TabIndex = 57
        Me.Label40.Text = "Valor Unit"
        '
        'txtporc_descuento
        '
        Me.txtporc_descuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtporc_descuento.Location = New System.Drawing.Point(247, 19)
        Me.txtporc_descuento.Name = "txtporc_descuento"
        Me.txtporc_descuento.Size = New System.Drawing.Size(88, 20)
        Me.txtporc_descuento.TabIndex = 8
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(169, 21)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(67, 13)
        Me.Label42.TabIndex = 53
        Me.Label42.Text = "%Descuento"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(58, 441)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 214
        Me.Label21.Text = "Proyecto"
        Me.Label21.Visible = False
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btn_eliminar, Me.btn_aprobar, Me.btn_anular, Me.btnImprimir, Me.btn_cotizacion, Me.btn_importar_pedidos, Me.btnCancelar, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(884, 25)
        Me.btn_menu.TabIndex = 199
        Me.btn_menu.Text = "ToolStrip1"
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
        Me.btnConsultar.Size = New System.Drawing.Size(120, 22)
        Me.btnConsultar.Text = "&Consultar/Editar"
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
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.Visible = False
        '
        'btn_aprobar
        '
        Me.btn_aprobar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aprobar.Image = CType(resources.GetObject("btn_aprobar.Image"), System.Drawing.Image)
        Me.btn_aprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_aprobar.Name = "btn_aprobar"
        Me.btn_aprobar.Size = New System.Drawing.Size(132, 22)
        Me.btn_aprobar.Text = "&Aprobar/Rechazar"
        '
        'btn_anular
        '
        Me.btn_anular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anular.Image = CType(resources.GetObject("btn_anular.Image"), System.Drawing.Image)
        Me.btn_anular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(64, 22)
        Me.btn_anular.Text = "&Anular"
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
        'btn_cotizacion
        '
        Me.btn_cotizacion.Image = CType(resources.GetObject("btn_cotizacion.Image"), System.Drawing.Image)
        Me.btn_cotizacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cotizacion.Name = "btn_cotizacion"
        Me.btn_cotizacion.Size = New System.Drawing.Size(113, 22)
        Me.btn_cotizacion.Text = "Gen. Cotización"
        '
        'btn_importar_pedidos
        '
        Me.btn_importar_pedidos.Image = CType(resources.GetObject("btn_importar_pedidos.Image"), System.Drawing.Image)
        Me.btn_importar_pedidos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_importar_pedidos.Name = "btn_importar_pedidos"
        Me.btn_importar_pedidos.Size = New System.Drawing.Size(126, 22)
        Me.btn_importar_pedidos.Text = "Importar Pedidos"
        Me.btn_importar_pedidos.Visible = False
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
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton7.Text = "&Salir"
        '
        'Frm_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 591)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.Tc_principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_detalles_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalles.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.Tc_principal.ResumeLayout(False)
        Me.tc_datos.ResumeLayout(False)
        Me.tc_datos.PerformLayout()
        Me.tc_detalle.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnl_stock.ResumeLayout(False)
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.btn_menu.ResumeLayout(False)
        Me.btn_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtglosa As System.Windows.Forms.RichTextBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtrazonsocial As System.Windows.Forms.TextBox
    Friend WithEvents txtestado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDescuentos As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtvalorVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtBruto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents Tc_principal As System.Windows.Forms.TabControl
    Friend WithEvents tc_datos As System.Windows.Forms.TabPage
    Friend WithEvents tc_detalle As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents txtproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcentroCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcantidadref As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents txtunidadMedRef As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents txtunidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkigv As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtvalorvent As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txttotalneto As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents txt_igv As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtvalorbruto As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtpreciounitario As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtvalorventaunit As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtvalorventaref As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtValorunitario As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txttasa As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtporc_descuento As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents dtp_vencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents dtp_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtvendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblcompra As System.Windows.Forms.Label
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_anular As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtordencompra As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblformapago As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblvendedor As System.Windows.Forms.Label
    Friend WithEvents lblPtoVenta As System.Windows.Forms.TextBox
    Friend WithEvents lblAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents txtPtoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txttrama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStockLote As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboLotes As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcomentario As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_aprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_stock As System.Windows.Forms.Panel
    Friend WithEvents dgv_stock As System.Windows.Forms.DataGridView
    Friend WithEvents btn_stock As System.Windows.Forms.Button
    Friend WithEvents cbo_direc_entrega As System.Windows.Forms.ComboBox
    Private WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lbl_centro_costo As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_centro_costo As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lbl_centro_costo_detalle As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_centro_costo_detalle As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_ruta As System.Windows.Forms.Button
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dgvdetalles As System.Windows.Forms.DataGridView
    Friend WithEvents btn_importar_pedidos As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents cbo_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents btn_importar_ped As System.Windows.Forms.Button
    Friend WithEvents btn_mostrar_ped As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgv_detalles_pedidos As System.Windows.Forms.DataGridView
    Friend WithEvents progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_cc_importar As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cc_importar As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents cbo_dir_entrega_importar As System.Windows.Forms.ComboBox
    Private WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_importar As System.Windows.Forms.TextBox
    Friend WithEvents lb_fp_importar As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_fp_importar As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_cliente_importar As System.Windows.Forms.TextBox
    Friend WithEvents txt_tc_importar As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents cbo_moneda_importar As System.Windows.Forms.ComboBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txt_ruc_importar As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txt_razon_social_importar As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents btn_cotizacion As System.Windows.Forms.ToolStripButton
End Class
