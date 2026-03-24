<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Hoja_Picking
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
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCUMENT_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDOR_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VAT_REGISTRATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNT_SALES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURRENCY_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cbo_modo_entrega = New System.Windows.Forms.ComboBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cbo_tipo_entrega = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.cbo_prioridad = New System.Windows.Forms.ComboBox()
        Me.txt_numero_doc_importacion = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.dtp_fecha_ingreso_oi = New System.Windows.Forms.DateTimePicker()
        Me.chk_para_importacion = New System.Windows.Forms.CheckBox()
        Me.chkfecha_entrega = New System.Windows.Forms.CheckBox()
        Me.btn_desaprobar = New System.Windows.Forms.Button()
        Me.btn_aprobar = New System.Windows.Forms.Button()
        Me.lblresponsable = New System.Windows.Forms.Label()
        Me.lblsolicitante = New System.Windows.Forms.Label()
        Me.lblformapago = New System.Windows.Forms.Label()
        Me.btn_anexar = New System.Windows.Forms.Button()
        Me.txtrucfacturar = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtdireccionFacturar = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtnombreFacturar = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtresponsable = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtentrega = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcotizacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttipoCambio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.dtpEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtproveedor_ruc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtproveedor_razons = New System.Windows.Forms.TextBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpemision = New System.Windows.Forms.DateTimePicker()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
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
        Me.chkflesinigv = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTFLETE = New System.Windows.Forms.TextBox()
        Me.tc_detalle = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btncalcularcantprov = New System.Windows.Forms.Button()
        Me.txtcant_calculo_prov = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtunidadprov = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtcantidadprov = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblcentrocostodetalle = New System.Windows.Forms.Label()
        Me.txtcentrocostodetalle = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.txtunidadMedRef = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtobservaciones = New System.Windows.Forms.RichTextBox()
        Me.txtGlosa = New System.Windows.Forms.RichTextBox()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtcantidadref = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtproyecto = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtcentroCosto = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chk_libre = New System.Windows.Forms.CheckBox()
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RequisicionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_anular = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbcabecera.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        Me.Tc_principal.SuspendLayout()
        Me.tc_datos.SuspendLayout()
        Me.tc_detalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.btn_menu.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvCabecera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DOCUMENT_DATE, Me.VENDOR_ID, Me.PROVEEDOR, Me.VAT_REGISTRATION, Me.STATUS_ID, Me.AMOUNT_SALES, Me.CURRENCY_TYPE, Me.DESCRIPTION, Me.Column10, Me.Column11})
        Me.dgvCabecera.Location = New System.Drawing.Point(12, 104)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.Size = New System.Drawing.Size(812, 406)
        Me.dgvCabecera.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "Numero"
        Me.ID.Name = "ID"
        '
        'DOCUMENT_DATE
        '
        Me.DOCUMENT_DATE.DataPropertyName = "DOCUMENT_DATE"
        Me.DOCUMENT_DATE.HeaderText = "Fecha"
        Me.DOCUMENT_DATE.Name = "DOCUMENT_DATE"
        '
        'VENDOR_ID
        '
        Me.VENDOR_ID.DataPropertyName = "VENDOR_ID"
        Me.VENDOR_ID.HeaderText = "Codigo"
        Me.VENDOR_ID.Name = "VENDOR_ID"
        '
        'PROVEEDOR
        '
        Me.PROVEEDOR.DataPropertyName = "PROVEEDOR"
        Me.PROVEEDOR.HeaderText = "Proveedor"
        Me.PROVEEDOR.Name = "PROVEEDOR"
        '
        'VAT_REGISTRATION
        '
        Me.VAT_REGISTRATION.DataPropertyName = "VAT_REGISTRATION"
        Me.VAT_REGISTRATION.HeaderText = "R.u.c"
        Me.VAT_REGISTRATION.Name = "VAT_REGISTRATION"
        '
        'STATUS_ID
        '
        Me.STATUS_ID.DataPropertyName = "STATUS_ID"
        Me.STATUS_ID.HeaderText = "STATUS_ID"
        Me.STATUS_ID.Name = "STATUS_ID"
        Me.STATUS_ID.Visible = False
        '
        'AMOUNT_SALES
        '
        Me.AMOUNT_SALES.DataPropertyName = "AMOUNT_SALES"
        Me.AMOUNT_SALES.HeaderText = "Total"
        Me.AMOUNT_SALES.Name = "AMOUNT_SALES"
        '
        'CURRENCY_TYPE
        '
        Me.CURRENCY_TYPE.DataPropertyName = "CURRENCY_TYPE"
        Me.CURRENCY_TYPE.HeaderText = "Moneda"
        Me.CURRENCY_TYPE.Name = "CURRENCY_TYPE"
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.DataPropertyName = "DESCRIPTION"
        Me.DESCRIPTION.HeaderText = "Estado"
        Me.DESCRIPTION.Name = "DESCRIPTION"
        '
        'Column10
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column10.HeaderText = "APROBAR"
        Me.Column10.Name = "Column10"
        Me.Column10.Text = "APROBAR"
        Me.Column10.UseColumnTextForButtonValue = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "RECHAZAR"
        Me.Column11.Name = "Column11"
        Me.Column11.Text = "RECHAZAR"
        Me.Column11.UseColumnTextForButtonValue = True
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.lblDetalle)
        Me.pnlCabecera.Controls.Add(Me.lblCantidad)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(9, 32)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(837, 547)
        Me.pnlCabecera.TabIndex = 177
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
        Me.lblDetalle.Size = New System.Drawing.Size(827, 20)
        Me.lblDetalle.TabIndex = 198
        Me.lblDetalle.Text = "LISTADO DE HOJA DE PICKING"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(15, 516)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(253, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha de emision"
        '
        'gbcabecera
        '
        Me.gbcabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbcabecera.Controls.Add(Me.Label54)
        Me.gbcabecera.Controls.Add(Me.cbo_modo_entrega)
        Me.gbcabecera.Controls.Add(Me.Label53)
        Me.gbcabecera.Controls.Add(Me.cbo_tipo_entrega)
        Me.gbcabecera.Controls.Add(Me.Label52)
        Me.gbcabecera.Controls.Add(Me.cbo_prioridad)
        Me.gbcabecera.Controls.Add(Me.txt_numero_doc_importacion)
        Me.gbcabecera.Controls.Add(Me.Label51)
        Me.gbcabecera.Controls.Add(Me.Label50)
        Me.gbcabecera.Controls.Add(Me.dtp_fecha_ingreso_oi)
        Me.gbcabecera.Controls.Add(Me.chk_para_importacion)
        Me.gbcabecera.Controls.Add(Me.chkfecha_entrega)
        Me.gbcabecera.Controls.Add(Me.btn_desaprobar)
        Me.gbcabecera.Controls.Add(Me.btn_aprobar)
        Me.gbcabecera.Controls.Add(Me.lblresponsable)
        Me.gbcabecera.Controls.Add(Me.lblsolicitante)
        Me.gbcabecera.Controls.Add(Me.lblformapago)
        Me.gbcabecera.Controls.Add(Me.btn_anexar)
        Me.gbcabecera.Controls.Add(Me.PictureBox4)
        Me.gbcabecera.Controls.Add(Me.PictureBox3)
        Me.gbcabecera.Controls.Add(Me.PictureBox2)
        Me.gbcabecera.Controls.Add(Me.PictureBox1)
        Me.gbcabecera.Controls.Add(Me.txtrucfacturar)
        Me.gbcabecera.Controls.Add(Me.Label20)
        Me.gbcabecera.Controls.Add(Me.txtdireccionFacturar)
        Me.gbcabecera.Controls.Add(Me.Label19)
        Me.gbcabecera.Controls.Add(Me.txtnombreFacturar)
        Me.gbcabecera.Controls.Add(Me.Label18)
        Me.gbcabecera.Controls.Add(Me.txtresponsable)
        Me.gbcabecera.Controls.Add(Me.Label17)
        Me.gbcabecera.Controls.Add(Me.txtSolicitante)
        Me.gbcabecera.Controls.Add(Me.Label16)
        Me.gbcabecera.Controls.Add(Me.txtentrega)
        Me.gbcabecera.Controls.Add(Me.Label15)
        Me.gbcabecera.Controls.Add(Me.txtcotizacion)
        Me.gbcabecera.Controls.Add(Me.Label14)
        Me.gbcabecera.Controls.Add(Me.txtFormaPago)
        Me.gbcabecera.Controls.Add(Me.Label12)
        Me.gbcabecera.Controls.Add(Me.txttipoCambio)
        Me.gbcabecera.Controls.Add(Me.Label11)
        Me.gbcabecera.Controls.Add(Me.Label10)
        Me.gbcabecera.Controls.Add(Me.cbomoneda)
        Me.gbcabecera.Controls.Add(Me.dtpEntrega)
        Me.gbcabecera.Controls.Add(Me.Label8)
        Me.gbcabecera.Controls.Add(Me.txtproveedor_ruc)
        Me.gbcabecera.Controls.Add(Me.Label6)
        Me.gbcabecera.Controls.Add(Me.txtproveedor_razons)
        Me.gbcabecera.Controls.Add(Me.txtestado)
        Me.gbcabecera.Controls.Add(Me.Label4)
        Me.gbcabecera.Controls.Add(Me.Label2)
        Me.gbcabecera.Controls.Add(Me.txtproveedor)
        Me.gbcabecera.Controls.Add(Me.Label5)
        Me.gbcabecera.Controls.Add(Me.dtpemision)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.Label3)
        Me.gbcabecera.Location = New System.Drawing.Point(6, 4)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(798, 310)
        Me.gbcabecera.TabIndex = 178
        Me.gbcabecera.TabStop = False
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(520, 277)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(89, 13)
        Me.Label54.TabIndex = 233
        Me.Label54.Text = "Modo de Entrega"
        '
        'cbo_modo_entrega
        '
        Me.cbo_modo_entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_modo_entrega.FormattingEnabled = True
        Me.cbo_modo_entrega.Location = New System.Drawing.Point(615, 273)
        Me.cbo_modo_entrega.Name = "cbo_modo_entrega"
        Me.cbo_modo_entrega.Size = New System.Drawing.Size(171, 21)
        Me.cbo_modo_entrega.TabIndex = 232
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(277, 277)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(83, 13)
        Me.Label53.TabIndex = 231
        Me.Label53.Text = "Tipo de Entrega"
        '
        'cbo_tipo_entrega
        '
        Me.cbo_tipo_entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_entrega.FormattingEnabled = True
        Me.cbo_tipo_entrega.Location = New System.Drawing.Point(365, 273)
        Me.cbo_tipo_entrega.Name = "cbo_tipo_entrega"
        Me.cbo_tipo_entrega.Size = New System.Drawing.Size(130, 21)
        Me.cbo_tipo_entrega.TabIndex = 230
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(57, 276)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(48, 13)
        Me.Label52.TabIndex = 229
        Me.Label52.Text = "Prioridad"
        '
        'cbo_prioridad
        '
        Me.cbo_prioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_prioridad.FormattingEnabled = True
        Me.cbo_prioridad.Location = New System.Drawing.Point(120, 273)
        Me.cbo_prioridad.Name = "cbo_prioridad"
        Me.cbo_prioridad.Size = New System.Drawing.Size(130, 21)
        Me.cbo_prioridad.TabIndex = 228
        '
        'txt_numero_doc_importacion
        '
        Me.txt_numero_doc_importacion.BackColor = System.Drawing.Color.White
        Me.txt_numero_doc_importacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_doc_importacion.Location = New System.Drawing.Point(583, 244)
        Me.txt_numero_doc_importacion.Name = "txt_numero_doc_importacion"
        Me.txt_numero_doc_importacion.Size = New System.Drawing.Size(147, 20)
        Me.txt_numero_doc_importacion.TabIndex = 226
        Me.txt_numero_doc_importacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Navy
        Me.Label51.Location = New System.Drawing.Point(483, 248)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(97, 13)
        Me.Label51.TabIndex = 227
        Me.Label51.Text = "N° doc importación"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.Navy
        Me.Label50.Location = New System.Drawing.Point(271, 248)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(89, 13)
        Me.Label50.TabIndex = 225
        Me.Label50.Text = "Fecha de ingreso"
        '
        'dtp_fecha_ingreso_oi
        '
        Me.dtp_fecha_ingreso_oi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_ingreso_oi.Location = New System.Drawing.Point(367, 244)
        Me.dtp_fecha_ingreso_oi.Name = "dtp_fecha_ingreso_oi"
        Me.dtp_fecha_ingreso_oi.Size = New System.Drawing.Size(107, 20)
        Me.dtp_fecha_ingreso_oi.TabIndex = 224
        '
        'chk_para_importacion
        '
        Me.chk_para_importacion.AutoSize = True
        Me.chk_para_importacion.ForeColor = System.Drawing.Color.Navy
        Me.chk_para_importacion.Location = New System.Drawing.Point(120, 246)
        Me.chk_para_importacion.Name = "chk_para_importacion"
        Me.chk_para_importacion.Size = New System.Drawing.Size(136, 17)
        Me.chk_para_importacion.TabIndex = 223
        Me.chk_para_importacion.Text = "Orden para importación"
        Me.chk_para_importacion.UseVisualStyleBackColor = True
        '
        'chkfecha_entrega
        '
        Me.chkfecha_entrega.AutoSize = True
        Me.chkfecha_entrega.ForeColor = System.Drawing.Color.Navy
        Me.chkfecha_entrega.Location = New System.Drawing.Point(8, 67)
        Me.chkfecha_entrega.Name = "chkfecha_entrega"
        Me.chkfecha_entrega.Size = New System.Drawing.Size(127, 17)
        Me.chkfecha_entrega.TabIndex = 222
        Me.chkfecha_entrega.Text = "Considerar F. entrega"
        Me.chkfecha_entrega.UseVisualStyleBackColor = True
        '
        'btn_desaprobar
        '
        Me.btn_desaprobar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_desaprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_desaprobar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desaprobar.ForeColor = System.Drawing.Color.Red
        Me.btn_desaprobar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_desaprobar.Location = New System.Drawing.Point(679, 193)
        Me.btn_desaprobar.Name = "btn_desaprobar"
        Me.btn_desaprobar.Size = New System.Drawing.Size(116, 51)
        Me.btn_desaprobar.TabIndex = 221
        Me.btn_desaprobar.Text = "&Rechazar"
        Me.btn_desaprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_desaprobar.UseVisualStyleBackColor = True
        Me.btn_desaprobar.Visible = False
        '
        'btn_aprobar
        '
        Me.btn_aprobar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aprobar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aprobar.ForeColor = System.Drawing.Color.DarkGreen
        Me.btn_aprobar.Location = New System.Drawing.Point(679, 193)
        Me.btn_aprobar.Name = "btn_aprobar"
        Me.btn_aprobar.Size = New System.Drawing.Size(116, 51)
        Me.btn_aprobar.TabIndex = 220
        Me.btn_aprobar.Text = "&Aprobar"
        Me.btn_aprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_aprobar.UseVisualStyleBackColor = True
        Me.btn_aprobar.Visible = False
        '
        'lblresponsable
        '
        Me.lblresponsable.AutoSize = True
        Me.lblresponsable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresponsable.ForeColor = System.Drawing.Color.Navy
        Me.lblresponsable.Location = New System.Drawing.Point(205, 221)
        Me.lblresponsable.Name = "lblresponsable"
        Me.lblresponsable.Size = New System.Drawing.Size(16, 13)
        Me.lblresponsable.TabIndex = 219
        Me.lblresponsable.Text = "..."
        '
        'lblsolicitante
        '
        Me.lblsolicitante.AutoSize = True
        Me.lblsolicitante.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsolicitante.ForeColor = System.Drawing.Color.Navy
        Me.lblsolicitante.Location = New System.Drawing.Point(205, 192)
        Me.lblsolicitante.Name = "lblsolicitante"
        Me.lblsolicitante.Size = New System.Drawing.Size(16, 13)
        Me.lblsolicitante.TabIndex = 218
        Me.lblsolicitante.Text = "..."
        '
        'lblformapago
        '
        Me.lblformapago.AutoSize = True
        Me.lblformapago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblformapago.ForeColor = System.Drawing.Color.Navy
        Me.lblformapago.Location = New System.Drawing.Point(205, 171)
        Me.lblformapago.Name = "lblformapago"
        Me.lblformapago.Size = New System.Drawing.Size(16, 13)
        Me.lblformapago.TabIndex = 217
        Me.lblformapago.Text = "..."
        '
        'btn_anexar
        '
        Me.btn_anexar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_anexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_anexar.ForeColor = System.Drawing.Color.Blue
        Me.btn_anexar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_anexar.Location = New System.Drawing.Point(676, 10)
        Me.btn_anexar.Name = "btn_anexar"
        Me.btn_anexar.Size = New System.Drawing.Size(116, 39)
        Me.btn_anexar.TabIndex = 216
        Me.btn_anexar.Text = "&Anexar Documentos"
        Me.btn_anexar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_anexar.UseVisualStyleBackColor = True
        '
        'txtrucfacturar
        '
        Me.txtrucfacturar.BackColor = System.Drawing.Color.White
        Me.txtrucfacturar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrucfacturar.Enabled = False
        Me.txtrucfacturar.Location = New System.Drawing.Point(671, 114)
        Me.txtrucfacturar.Name = "txtrucfacturar"
        Me.txtrucfacturar.ReadOnly = True
        Me.txtrucfacturar.Size = New System.Drawing.Size(147, 20)
        Me.txtrucfacturar.TabIndex = 12
        Me.txtrucfacturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(642, 117)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 13)
        Me.Label20.TabIndex = 210
        Me.Label20.Text = "Ruc"
        '
        'txtdireccionFacturar
        '
        Me.txtdireccionFacturar.BackColor = System.Drawing.Color.White
        Me.txtdireccionFacturar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdireccionFacturar.Enabled = False
        Me.txtdireccionFacturar.Location = New System.Drawing.Point(120, 141)
        Me.txtdireccionFacturar.Name = "txtdireccionFacturar"
        Me.txtdireccionFacturar.ReadOnly = True
        Me.txtdireccionFacturar.Size = New System.Drawing.Size(513, 20)
        Me.txtdireccionFacturar.TabIndex = 11
        Me.txtdireccionFacturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(6, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 208
        Me.Label19.Text = "Direccion"
        '
        'txtnombreFacturar
        '
        Me.txtnombreFacturar.BackColor = System.Drawing.Color.White
        Me.txtnombreFacturar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombreFacturar.Enabled = False
        Me.txtnombreFacturar.Location = New System.Drawing.Point(120, 114)
        Me.txtnombreFacturar.Name = "txtnombreFacturar"
        Me.txtnombreFacturar.ReadOnly = True
        Me.txtnombreFacturar.Size = New System.Drawing.Size(513, 20)
        Me.txtnombreFacturar.TabIndex = 14
        Me.txtnombreFacturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(6, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 13)
        Me.Label18.TabIndex = 206
        Me.Label18.Text = "Facturar a nombre de "
        '
        'txtresponsable
        '
        Me.txtresponsable.BackColor = System.Drawing.Color.Aquamarine
        Me.txtresponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtresponsable.Location = New System.Drawing.Point(120, 217)
        Me.txtresponsable.Name = "txtresponsable"
        Me.txtresponsable.ReadOnly = True
        Me.txtresponsable.Size = New System.Drawing.Size(54, 20)
        Me.txtresponsable.TabIndex = 15
        Me.txtresponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(6, 219)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 204
        Me.Label17.Text = "Resp. de Compras."
        '
        'txtSolicitante
        '
        Me.txtSolicitante.BackColor = System.Drawing.Color.Aquamarine
        Me.txtSolicitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSolicitante.Location = New System.Drawing.Point(120, 192)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.ReadOnly = True
        Me.txtSolicitante.Size = New System.Drawing.Size(54, 20)
        Me.txtSolicitante.TabIndex = 14
        Me.txtSolicitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(6, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 202
        Me.Label16.Text = "Solicitado Por."
        '
        'txtentrega
        '
        Me.txtentrega.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtentrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtentrega.Location = New System.Drawing.Point(120, 89)
        Me.txtentrega.MaxLength = 250
        Me.txtentrega.Name = "txtentrega"
        Me.txtentrega.Size = New System.Drawing.Size(716, 20)
        Me.txtentrega.TabIndex = 10
        Me.txtentrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(6, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 200
        Me.Label15.Text = "Entregar en "
        '
        'txtcotizacion
        '
        Me.txtcotizacion.BackColor = System.Drawing.Color.White
        Me.txtcotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcotizacion.Location = New System.Drawing.Point(671, 66)
        Me.txtcotizacion.MaxLength = 15
        Me.txtcotizacion.Name = "txtcotizacion"
        Me.txtcotizacion.Size = New System.Drawing.Size(162, 20)
        Me.txtcotizacion.TabIndex = 9
        Me.txtcotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(593, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 198
        Me.Label14.Text = "Nro.Cotizacion"
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormaPago.Location = New System.Drawing.Point(120, 168)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(54, 20)
        Me.txtFormaPago.TabIndex = 13
        Me.txtFormaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(6, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 194
        Me.Label12.Text = "Forma de Pago."
        '
        'txttipoCambio
        '
        Me.txttipoCambio.BackColor = System.Drawing.Color.White
        Me.txttipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipoCambio.Enabled = False
        Me.txttipoCambio.Location = New System.Drawing.Point(539, 67)
        Me.txttipoCambio.Name = "txttipoCambio"
        Me.txttipoCambio.ReadOnly = True
        Me.txttipoCambio.Size = New System.Drawing.Size(51, 20)
        Me.txttipoCambio.TabIndex = 8
        Me.txttipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(480, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "T/cambio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(271, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Moneda"
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(323, 66)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(130, 21)
        Me.cbomoneda.TabIndex = 7
        '
        'dtpEntrega
        '
        Me.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntrega.Location = New System.Drawing.Point(137, 66)
        Me.dtpEntrega.Name = "dtpEntrega"
        Me.dtpEntrega.Size = New System.Drawing.Size(112, 20)
        Me.dtpEntrega.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(638, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 187
        Me.Label8.Text = "Ruc"
        '
        'txtproveedor_ruc
        '
        Me.txtproveedor_ruc.BackColor = System.Drawing.Color.White
        Me.txtproveedor_ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor_ruc.Enabled = False
        Me.txtproveedor_ruc.Location = New System.Drawing.Point(671, 41)
        Me.txtproveedor_ruc.Name = "txtproveedor_ruc"
        Me.txtproveedor_ruc.Size = New System.Drawing.Size(78, 20)
        Me.txtproveedor_ruc.TabIndex = 5
        Me.txtproveedor_ruc.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(253, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 185
        Me.Label6.Text = "Razon social"
        '
        'txtproveedor_razons
        '
        Me.txtproveedor_razons.BackColor = System.Drawing.Color.White
        Me.txtproveedor_razons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor_razons.Enabled = False
        Me.txtproveedor_razons.Location = New System.Drawing.Point(323, 41)
        Me.txtproveedor_razons.Name = "txtproveedor_razons"
        Me.txtproveedor_razons.Size = New System.Drawing.Size(310, 20)
        Me.txtproveedor_razons.TabIndex = 4
        '
        'txtestado
        '
        Me.txtestado.BackColor = System.Drawing.Color.White
        Me.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtestado.Enabled = False
        Me.txtestado.Location = New System.Drawing.Point(539, 20)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.ReadOnly = True
        Me.txtestado.Size = New System.Drawing.Size(51, 20)
        Me.txtestado.TabIndex = 183
        Me.txtestado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtestado.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(494, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 182
        Me.Label4.Text = "Estado"
        Me.Label4.Visible = False
        '
        'txtproveedor
        '
        Me.txtproveedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor.Location = New System.Drawing.Point(120, 43)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.ReadOnly = True
        Me.txtproveedor.Size = New System.Drawing.Size(129, 20)
        Me.txtproveedor.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(6, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Proveedor"
        '
        'dtpemision
        '
        Me.dtpemision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpemision.Location = New System.Drawing.Point(349, 20)
        Me.dtpemision.Name = "dtpemision"
        Me.dtpemision.Size = New System.Drawing.Size(107, 20)
        Me.dtpemision.TabIndex = 2
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(120, 19)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(129, 21)
        Me.txtcodigo.TabIndex = 1
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nro de Orden Compra"
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.dgvDetalle)
        Me.gbDetalles.Location = New System.Drawing.Point(6, 343)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(729, 105)
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
        Me.dgvDetalle.Location = New System.Drawing.Point(8, 14)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(715, 85)
        Me.dgvDetalle.TabIndex = 0
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.BackColor = System.Drawing.Color.White
        Me.txtComentario.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtComentario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentario.Location = New System.Drawing.Point(148, 321)
        Me.txtComentario.MaxLength = 250
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentario.Size = New System.Drawing.Size(580, 21)
        Me.txtComentario.TabIndex = 17
        Me.txtComentario.Text = ""
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Location = New System.Drawing.Point(738, 343)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(67, 105)
        Me.gbOpciones.TabIndex = 182
        Me.gbOpciones.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.Navy
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(4, 36)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(60, 41)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnquitar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar.ForeColor = System.Drawing.Color.Navy
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnquitar.Location = New System.Drawing.Point(4, 88)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(60, 41)
        Me.btnquitar.TabIndex = 20
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.Navy
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(4, -16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(60, 41)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(5, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Comentarios / Observacione"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.White
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Enabled = False
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.Location = New System.Drawing.Point(640, 499)
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
        Me.Label28.Location = New System.Drawing.Point(561, 502)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 13)
        Me.Label28.TabIndex = 194
        Me.Label28.Text = "Precio Venta"
        '
        'txtIgv
        '
        Me.txtIgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIgv.BackColor = System.Drawing.Color.White
        Me.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIgv.Enabled = False
        Me.txtIgv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgv.Location = New System.Drawing.Point(640, 476)
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
        Me.Label24.Location = New System.Drawing.Point(598, 480)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 13)
        Me.Label24.TabIndex = 192
        Me.Label24.Text = "I.G.V"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentos.BackColor = System.Drawing.Color.White
        Me.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuentos.Enabled = False
        Me.txtDescuentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentos.Location = New System.Drawing.Point(473, 454)
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
        Me.Label23.Location = New System.Drawing.Point(404, 458)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 190
        Me.Label23.Text = "Descuento"
        '
        'txtvalorVenta
        '
        Me.txtvalorVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvalorVenta.BackColor = System.Drawing.Color.White
        Me.txtvalorVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorVenta.Enabled = False
        Me.txtvalorVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalorVenta.Location = New System.Drawing.Point(640, 454)
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
        Me.Label22.Location = New System.Drawing.Point(567, 457)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 188
        Me.Label22.Text = "Valor Venta"
        '
        'txtBruto
        '
        Me.txtBruto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBruto.BackColor = System.Drawing.Color.White
        Me.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBruto.Enabled = False
        Me.txtBruto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBruto.Location = New System.Drawing.Point(311, 455)
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
        Me.Label13.Location = New System.Drawing.Point(237, 459)
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
        Me.Tc_principal.Location = New System.Drawing.Point(9, 32)
        Me.Tc_principal.Multiline = True
        Me.Tc_principal.Name = "Tc_principal"
        Me.Tc_principal.SelectedIndex = 0
        Me.Tc_principal.Size = New System.Drawing.Size(824, 548)
        Me.Tc_principal.TabIndex = 196
        '
        'tc_datos
        '
        Me.tc_datos.BackColor = System.Drawing.Color.White
        Me.tc_datos.Controls.Add(Me.chkflesinigv)
        Me.tc_datos.Controls.Add(Me.Label9)
        Me.tc_datos.Controls.Add(Me.TXTFLETE)
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
        Me.tc_datos.Controls.Add(Me.txtComentario)
        Me.tc_datos.Controls.Add(Me.gbDetalles)
        Me.tc_datos.Location = New System.Drawing.Point(4, 22)
        Me.tc_datos.Name = "tc_datos"
        Me.tc_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_datos.Size = New System.Drawing.Size(816, 522)
        Me.tc_datos.TabIndex = 0
        Me.tc_datos.Text = "Datos de la Orden de Compra"
        '
        'chkflesinigv
        '
        Me.chkflesinigv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkflesinigv.AutoSize = True
        Me.chkflesinigv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkflesinigv.ForeColor = System.Drawing.Color.Navy
        Me.chkflesinigv.Location = New System.Drawing.Point(105, 482)
        Me.chkflesinigv.Name = "chkflesinigv"
        Me.chkflesinigv.Size = New System.Drawing.Size(122, 17)
        Me.chkflesinigv.TabIndex = 223
        Me.chkflesinigv.Text = "Flete libre de IGV"
        Me.chkflesinigv.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(101, 459)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 196
        Me.Label9.Text = "Flete"
        '
        'TXTFLETE
        '
        Me.TXTFLETE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTFLETE.BackColor = System.Drawing.Color.White
        Me.TXTFLETE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTFLETE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFLETE.Location = New System.Drawing.Point(142, 455)
        Me.TXTFLETE.Name = "TXTFLETE"
        Me.TXTFLETE.Size = New System.Drawing.Size(89, 21)
        Me.TXTFLETE.TabIndex = 195
        Me.TXTFLETE.Text = "0.00"
        Me.TXTFLETE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tc_detalle
        '
        Me.tc_detalle.BackColor = System.Drawing.Color.White
        Me.tc_detalle.Controls.Add(Me.GroupBox1)
        Me.tc_detalle.Location = New System.Drawing.Point(4, 22)
        Me.tc_detalle.Name = "tc_detalle"
        Me.tc_detalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_detalle.Size = New System.Drawing.Size(816, 522)
        Me.tc_detalle.TabIndex = 1
        Me.tc_detalle.Text = "Detalles de Orden de Compra"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.txtobservaciones)
        Me.GroupBox1.Controls.Add(Me.txtGlosa)
        Me.GroupBox1.Controls.Add(Me.txtarea)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.txtproyecto)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtcentroCosto)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(11, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 502)
        Me.GroupBox1.TabIndex = 216
        Me.GroupBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.btncalcularcantprov)
        Me.GroupBox7.Controls.Add(Me.txtcant_calculo_prov)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.txtunidadprov)
        Me.GroupBox7.Controls.Add(Me.Label49)
        Me.GroupBox7.Controls.Add(Me.txtcantidadprov)
        Me.GroupBox7.Controls.Add(Me.Label48)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(15, 155)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(762, 12)
        Me.GroupBox7.TabIndex = 216
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Presentación y Cantidad del Proveedor"
        Me.GroupBox7.Visible = False
        '
        'btncalcularcantprov
        '
        Me.btncalcularcantprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncalcularcantprov.ForeColor = System.Drawing.Color.Blue
        Me.btncalcularcantprov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncalcularcantprov.Location = New System.Drawing.Point(171, 55)
        Me.btncalcularcantprov.Name = "btncalcularcantprov"
        Me.btncalcularcantprov.Size = New System.Drawing.Size(77, 22)
        Me.btncalcularcantprov.TabIndex = 58
        Me.btncalcularcantprov.Text = "Calcular"
        Me.btncalcularcantprov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncalcularcantprov.UseVisualStyleBackColor = True
        '
        'txtcant_calculo_prov
        '
        Me.txtcant_calculo_prov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcant_calculo_prov.Enabled = False
        Me.txtcant_calculo_prov.Location = New System.Drawing.Point(313, 56)
        Me.txtcant_calculo_prov.Name = "txtcant_calculo_prov"
        Me.txtcant_calculo_prov.Size = New System.Drawing.Size(88, 20)
        Me.txtcant_calculo_prov.TabIndex = 56
        Me.txtcant_calculo_prov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(258, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Cant. Ref"
        '
        'txtunidadprov
        '
        Me.txtunidadprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadprov.Location = New System.Drawing.Point(70, 26)
        Me.txtunidadprov.Name = "txtunidadprov"
        Me.txtunidadprov.Size = New System.Drawing.Size(56, 20)
        Me.txtunidadprov.TabIndex = 54
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(5, 28)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(56, 13)
        Me.Label49.TabIndex = 55
        Me.Label49.Text = "Unid. Med"
        '
        'txtcantidadprov
        '
        Me.txtcantidadprov.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidadprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidadprov.Location = New System.Drawing.Point(70, 56)
        Me.txtcantidadprov.Name = "txtcantidadprov"
        Me.txtcantidadprov.Size = New System.Drawing.Size(88, 20)
        Me.txtcantidadprov.TabIndex = 4
        Me.txtcantidadprov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label48.ForeColor = System.Drawing.Color.Navy
        Me.Label48.Location = New System.Drawing.Point(29, 58)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(32, 13)
        Me.Label48.TabIndex = 5
        Me.Label48.Text = "Cant."
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.lblcentrocostodetalle)
        Me.GroupBox6.Controls.Add(Me.txtcentrocostodetalle)
        Me.GroupBox6.Controls.Add(Me.Label82)
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
        Me.GroupBox6.Location = New System.Drawing.Point(15, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(762, 84)
        Me.GroupBox6.TabIndex = 198
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Detalles del Articulo"
        '
        'lblcentrocostodetalle
        '
        Me.lblcentrocostodetalle.AutoSize = True
        Me.lblcentrocostodetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcentrocostodetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblcentrocostodetalle.Location = New System.Drawing.Point(206, 56)
        Me.lblcentrocostodetalle.Name = "lblcentrocostodetalle"
        Me.lblcentrocostodetalle.Size = New System.Drawing.Size(16, 13)
        Me.lblcentrocostodetalle.TabIndex = 259
        Me.lblcentrocostodetalle.Text = "..."
        '
        'txtcentrocostodetalle
        '
        Me.txtcentrocostodetalle.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcentrocostodetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcentrocostodetalle.Location = New System.Drawing.Point(103, 52)
        Me.txtcentrocostodetalle.Name = "txtcentrocostodetalle"
        Me.txtcentrocostodetalle.ReadOnly = True
        Me.txtcentrocostodetalle.Size = New System.Drawing.Size(95, 20)
        Me.txtcentrocostodetalle.TabIndex = 257
        Me.txtcentrocostodetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.ForeColor = System.Drawing.Color.Navy
        Me.Label82.Location = New System.Drawing.Point(9, 56)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(83, 13)
        Me.Label82.TabIndex = 258
        Me.Label82.Text = "Centro de Costo"
        '
        'txtunidadMedRef
        '
        Me.txtunidadMedRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedRef.Enabled = False
        Me.txtunidadMedRef.Location = New System.Drawing.Point(231, 76)
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
        Me.Label45.Location = New System.Drawing.Point(132, 79)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(73, 13)
        Me.Label45.TabIndex = 113
        Me.Label45.Text = "Unid.Med Ref"
        Me.Label45.Visible = False
        '
        'txtunidadMedida
        '
        Me.txtunidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedida.Enabled = False
        Me.txtunidadMedida.Location = New System.Drawing.Point(690, 20)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.Size = New System.Drawing.Size(56, 20)
        Me.txtunidadMedida.TabIndex = 2
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(229, 20)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(394, 20)
        Me.txtdescripcionArticulo.TabIndex = 1
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(103, 20)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(94, 21)
        Me.txtcodigoArticulo.TabIndex = 0
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(50, 24)
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
        Me.Label47.Location = New System.Drawing.Point(630, 24)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(56, 13)
        Me.Label47.TabIndex = 5
        Me.Label47.Text = "Unid. Med"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.Blue
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.Location = New System.Drawing.Point(400, 343)
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
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(325, 343)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(69, 38)
        Me.btnAceptar.TabIndex = 208
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobservaciones.Location = New System.Drawing.Point(16, 311)
        Me.txtobservaciones.MaxLength = 250
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(763, 19)
        Me.txtobservaciones.TabIndex = 18
        Me.txtobservaciones.Text = ""
        '
        'txtGlosa
        '
        Me.txtGlosa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGlosa.Location = New System.Drawing.Point(61, 479)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(716, 30)
        Me.txtGlosa.TabIndex = 6
        Me.txtGlosa.Text = ""
        Me.txtGlosa.Visible = False
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(328, 479)
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
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.txtcantidad)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(15, 102)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(762, 47)
        Me.GroupBox5.TabIndex = 199
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cantidad a Comprar"
        '
        'txtcantidadref
        '
        Me.txtcantidadref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidadref.Enabled = False
        Me.txtcantidadref.Location = New System.Drawing.Point(223, 19)
        Me.txtcantidadref.Name = "txtcantidadref"
        Me.txtcantidadref.Size = New System.Drawing.Size(88, 20)
        Me.txtcantidadref.TabIndex = 5
        Me.txtcantidadref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcantidadref.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(168, 23)
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
        Me.txtcantidad.Location = New System.Drawing.Point(70, 19)
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
        Me.txtproyecto.Location = New System.Drawing.Point(137, 484)
        Me.txtproyecto.Name = "txtproyecto"
        Me.txtproyecto.Size = New System.Drawing.Size(316, 20)
        Me.txtproyecto.TabIndex = 21
        Me.txtproyecto.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(21, 487)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 206
        Me.Label31.Text = "Glosa"
        Me.Label31.Visible = False
        '
        'txtcentroCosto
        '
        Me.txtcentroCosto.Location = New System.Drawing.Point(137, 479)
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
        Me.Label29.Location = New System.Drawing.Point(27, 482)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 13)
        Me.Label29.TabIndex = 210
        Me.Label29.Text = "Centro de Costo"
        Me.Label29.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(21, 295)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(78, 13)
        Me.Label30.TabIndex = 207
        Me.Label30.Text = "Observaciones"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(272, 482)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 13)
        Me.Label27.TabIndex = 212
        Me.Label27.Text = "Area"
        Me.Label27.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.chk_libre)
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
        Me.GroupBox4.Location = New System.Drawing.Point(16, 173)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(762, 115)
        Me.GroupBox4.TabIndex = 201
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalles de Compra"
        '
        'chk_libre
        '
        Me.chk_libre.AutoSize = True
        Me.chk_libre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_libre.Location = New System.Drawing.Point(486, 93)
        Me.chk_libre.Name = "chk_libre"
        Me.chk_libre.Size = New System.Drawing.Size(76, 17)
        Me.chk_libre.TabIndex = 217
        Me.chk_libre.Text = "Libre Igv"
        Me.chk_libre.UseVisualStyleBackColor = True
        '
        'chkigv
        '
        Me.chkigv.AutoSize = True
        Me.chkigv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkigv.Location = New System.Drawing.Point(387, 93)
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
        Me.Label32.Location = New System.Drawing.Point(215, 93)
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
        Me.txtvalorvent.Location = New System.Drawing.Point(457, 65)
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
        Me.txttasa.Location = New System.Drawing.Point(457, 16)
        Me.txttasa.Name = "txttasa"
        Me.txttasa.Size = New System.Drawing.Size(88, 20)
        Me.txttasa.TabIndex = 9
        Me.txttasa.Text = "18"
        Me.txttasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(383, 20)
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
        Me.Label33.Location = New System.Drawing.Point(388, 70)
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
        Me.txttotalneto.Location = New System.Drawing.Point(291, 91)
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
        Me.Label34.Location = New System.Drawing.Point(213, 68)
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
        Me.txtdescuento.Location = New System.Drawing.Point(291, 67)
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
        Me.txt_igv.Location = New System.Drawing.Point(112, 89)
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
        Me.Label35.Location = New System.Drawing.Point(82, 91)
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
        Me.txtvalorbruto.Location = New System.Drawing.Point(112, 65)
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
        Me.Label36.Location = New System.Drawing.Point(43, 67)
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
        Me.txtpreciounitario.Location = New System.Drawing.Point(457, 41)
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
        Me.Label37.Location = New System.Drawing.Point(390, 44)
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
        Me.txtvalorventaunit.Location = New System.Drawing.Point(291, 42)
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
        Me.Label38.Location = New System.Drawing.Point(212, 45)
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
        Me.txtvalorventaref.Location = New System.Drawing.Point(112, 42)
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
        Me.Label39.Location = New System.Drawing.Point(9, 44)
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
        Me.txtValorunitario.Location = New System.Drawing.Point(112, 17)
        Me.txtValorunitario.Name = "txtValorunitario"
        Me.txtValorunitario.Size = New System.Drawing.Size(88, 21)
        Me.txtValorunitario.TabIndex = 7
        Me.txtValorunitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(53, 21)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(53, 13)
        Me.Label40.TabIndex = 57
        Me.Label40.Text = "Valor Unit"
        '
        'txtporc_descuento
        '
        Me.txtporc_descuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtporc_descuento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtporc_descuento.Location = New System.Drawing.Point(291, 17)
        Me.txtporc_descuento.Name = "txtporc_descuento"
        Me.txtporc_descuento.Size = New System.Drawing.Size(88, 21)
        Me.txtporc_descuento.TabIndex = 8
        Me.txtporc_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(213, 19)
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
        Me.Label21.Location = New System.Drawing.Point(58, 486)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 214
        Me.Label21.Text = "Proyecto"
        Me.Label21.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequisicionesToolStripMenuItem, Me.CotizacionesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 48)
        '
        'RequisicionesToolStripMenuItem
        '
        Me.RequisicionesToolStripMenuItem.Name = "RequisicionesToolStripMenuItem"
        Me.RequisicionesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.RequisicionesToolStripMenuItem.Text = "Requisiciones"
        '
        'CotizacionesToolStripMenuItem
        '
        Me.CotizacionesToolStripMenuItem.Name = "CotizacionesToolStripMenuItem"
        Me.CotizacionesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CotizacionesToolStripMenuItem.Text = "Cotizaciones"
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btn_anular, Me.btnImprimir, Me.btnCancelar, Me.btnEliminar, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(858, 25)
        Me.btn_menu.TabIndex = 198
        Me.btn_menu.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(46, 22)
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(65, 22)
        Me.btnConsultar.Text = "&Consultar"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(57, 22)
        Me.btnGrabar.Text = "&Guardar"
        '
        'btn_anular
        '
        Me.btn_anular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(48, 22)
        Me.btn_anular.Text = "&Anular"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(61, 22)
        Me.btnImprimir.Text = "&Imprimir"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 22)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(99, 22)
        Me.btnEliminar.Text = "&Cambiar Estado"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton7.Text = "&Salir"
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(180, 193)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 215
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(180, 218)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 214
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(180, 169)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 213
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(228, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 15)
        Me.PictureBox1.TabIndex = 212
        Me.PictureBox1.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(210, 76)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox8.TabIndex = 113
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(204, 21)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox9.TabIndex = 112
        Me.PictureBox9.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(114, 484)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 215
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(307, 479)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox5.TabIndex = 213
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(114, 480)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox7.TabIndex = 211
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'Frm_Hoja_Picking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(858, 587)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.Tc_principal)
        Me.Name = "Frm_Hoja_Picking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hoja de Picking"
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        Me.gbDetalles.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.Tc_principal.ResumeLayout(False)
        Me.tc_datos.ResumeLayout(False)
        Me.tc_datos.PerformLayout()
        Me.tc_detalle.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.btn_menu.ResumeLayout(False)
        Me.btn_menu.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpemision As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtComentario As System.Windows.Forms.RichTextBox
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
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents dtpEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor_ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor_razons As System.Windows.Forms.TextBox
    Friend WithEvents txtestado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtentrega As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcotizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txttipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtresponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSolicitante As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtrucfacturar As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtdireccionFacturar As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtnombreFacturar As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
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
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.RichTextBox
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
    Friend WithEvents btn_anexar As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RequisicionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CotizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblresponsable As System.Windows.Forms.Label
    Friend WithEvents lblsolicitante As System.Windows.Forms.Label
    Friend WithEvents lblformapago As System.Windows.Forms.Label
    Friend WithEvents chk_libre As System.Windows.Forms.CheckBox
    Friend WithEvents btn_desaprobar As System.Windows.Forms.Button
    Friend WithEvents btn_aprobar As System.Windows.Forms.Button
    Friend WithEvents btn_anular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENT_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VENDOR_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVEEDOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VAT_REGISTRATION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNT_SALES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRENCY_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcantidadprov As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtunidadprov As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtcant_calculo_prov As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncalcularcantprov As System.Windows.Forms.Button
    Friend WithEvents chkfecha_entrega As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTFLETE As System.Windows.Forms.TextBox
    Friend WithEvents chkflesinigv As System.Windows.Forms.CheckBox
    Friend WithEvents lblcentrocostodetalle As System.Windows.Forms.Label
    Friend WithEvents txtcentrocostodetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents chk_para_importacion As System.Windows.Forms.CheckBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_ingreso_oi As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_numero_doc_importacion As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents cbo_modo_entrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_entrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cbo_prioridad As System.Windows.Forms.ComboBox
End Class
