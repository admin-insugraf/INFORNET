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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.gbdetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.gbTipoGuia = New System.Windows.Forms.GroupBox()
        Me.rbVariaslineas = New System.Windows.Forms.RadioButton()
        Me.rbunalinea = New System.Windows.Forms.RadioButton()
        Me.GbdetalleDocumento = New System.Windows.Forms.GroupBox()
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
        Me.lbltipoDocRef = New System.Windows.Forms.TextBox()
        Me.txttipoDocRef = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
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
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.RichTextBox()
        Me.lblGlosa = New System.Windows.Forms.Label()
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
        Me.txtGlosaGuia = New System.Windows.Forms.RichTextBox()
        Me.txtdescEsp = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.TextBox()
        Me.txtdescCli = New System.Windows.Forms.TextBox()
        Me.lblFormaPago = New System.Windows.Forms.TextBox()
        Me.txtNomTrans = New System.Windows.Forms.TextBox()
        Me.txtCodTrans = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblPtoVenta = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.chkSinIGV = New System.Windows.Forms.CheckBox()
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
        Me.pnlFiltros = New System.Windows.Forms.Panel()
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
        Me.gbGenerarCP = New System.Windows.Forms.GroupBox()
        Me.btnGenerarCP = New System.Windows.Forms.Button()
        Me.gbTipoFacturacion = New System.Windows.Forms.GroupBox()
        Me.rbFacturaExistencias = New System.Windows.Forms.RadioButton()
        Me.rbFacturaGuiaVenta = New System.Windows.Forms.RadioButton()
        Me.rbFacturaDirecta = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.pnlDocumentosGuiaVenta = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtFiltroCliente = New System.Windows.Forms.TextBox()
        Me.dgvDocumentosCliente = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbGenerarDespacho = New System.Windows.Forms.GroupBox()
        Me.btnDespacho = New System.Windows.Forms.Button()
        Me.pnlConfirmarDespacho = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dtpDespacho = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lblDespachoNumero = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.btn_SalirDesp = New System.Windows.Forms.Button()
        Me.btn_AceptarDesp = New System.Windows.Forms.Button()
        Me.gbdetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        Me.GbCabecera.SuspendLayout()
        Me.gbTipoGuia.SuspendLayout()
        Me.GbdetalleDocumento.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlFiltros.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.PnlBuscarordenCompra.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbGenerarCP.SuspendLayout()
        Me.gbTipoFacturacion.SuspendLayout()
        Me.pnlDocumentosGuiaVenta.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvDocumentosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGenerarDespacho.SuspendLayout()
        Me.pnlConfirmarDespacho.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(489, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 52)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnular.FlatAppearance.BorderSize = 0
        Me.btnAnular.ForeColor = System.Drawing.Color.Black
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnular.Location = New System.Drawing.Point(285, 4)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(69, 52)
        Me.btnAnular.TabIndex = 13
        Me.btnAnular.Text = "&Anular"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(217, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(69, 52)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(353, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(69, 52)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(13, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 52)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.FlatAppearance.BorderSize = 0
        Me.btnConsultar.ForeColor = System.Drawing.Color.Black
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(81, 4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(69, 52)
        Me.btnConsultar.TabIndex = 9
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(421, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 52)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.FlatAppearance.BorderSize = 0
        Me.btnGrabar.ForeColor = System.Drawing.Color.Black
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(149, 4)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(69, 52)
        Me.btnGrabar.TabIndex = 0
        Me.btnGrabar.Text = "&Guardar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'gbdetalle
        '
        Me.gbdetalle.BackColor = System.Drawing.Color.Silver
        Me.gbdetalle.Controls.Add(Me.dgvDetalle)
        Me.gbdetalle.Location = New System.Drawing.Point(12, 442)
        Me.gbdetalle.Name = "gbdetalle"
        Me.gbdetalle.Size = New System.Drawing.Size(1235, 201)
        Me.gbdetalle.TabIndex = 114
        Me.gbdetalle.TabStop = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalle.Location = New System.Drawing.Point(8, 15)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(1217, 178)
        Me.dgvDetalle.TabIndex = 112
        '
        'gbOpciones
        '
        Me.gbOpciones.BackColor = System.Drawing.Color.Silver
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Location = New System.Drawing.Point(1253, 442)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(75, 201)
        Me.gbOpciones.TabIndex = 115
        Me.gbOpciones.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(8, 81)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(59, 53)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnquitar.Location = New System.Drawing.Point(9, 133)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(59, 53)
        Me.btnquitar.TabIndex = 15
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(9, 29)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(59, 53)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GbCabecera
        '
        Me.GbCabecera.BackColor = System.Drawing.Color.Silver
        Me.GbCabecera.Controls.Add(Me.gbTipoGuia)
        Me.GbCabecera.Controls.Add(Me.GbdetalleDocumento)
        Me.GbCabecera.Controls.Add(Me.Label37)
        Me.GbCabecera.Controls.Add(Me.txtSerieDocRef)
        Me.GbCabecera.Controls.Add(Me.lbltipoDocRef)
        Me.GbCabecera.Controls.Add(Me.txttipoDocRef)
        Me.GbCabecera.Controls.Add(Me.Label36)
        Me.GbCabecera.Controls.Add(Me.PictureBox10)
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
        Me.GbCabecera.Controls.Add(Me.Label33)
        Me.GbCabecera.Controls.Add(Me.txtGlosa)
        Me.GbCabecera.Controls.Add(Me.lblGlosa)
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
        Me.GbCabecera.Controls.Add(Me.txtGlosaGuia)
        Me.GbCabecera.Controls.Add(Me.txtdescEsp)
        Me.GbCabecera.Controls.Add(Me.PictureBox3)
        Me.GbCabecera.Controls.Add(Me.Label30)
        Me.GbCabecera.Controls.Add(Me.lblVendedor)
        Me.GbCabecera.Controls.Add(Me.txtdescCli)
        Me.GbCabecera.Controls.Add(Me.lblFormaPago)
        Me.GbCabecera.Controls.Add(Me.txtNomTrans)
        Me.GbCabecera.Controls.Add(Me.txtCodTrans)
        Me.GbCabecera.Controls.Add(Me.Label29)
        Me.GbCabecera.Controls.Add(Me.Label18)
        Me.GbCabecera.Controls.Add(Me.PictureBox2)
        Me.GbCabecera.Controls.Add(Me.lblPtoVenta)
        Me.GbCabecera.Controls.Add(Me.PictureBox1)
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
        Me.GbCabecera.Location = New System.Drawing.Point(12, 123)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(1316, 297)
        Me.GbCabecera.TabIndex = 116
        Me.GbCabecera.TabStop = False
        '
        'gbTipoGuia
        '
        Me.gbTipoGuia.Controls.Add(Me.rbVariaslineas)
        Me.gbTipoGuia.Controls.Add(Me.rbunalinea)
        Me.gbTipoGuia.Location = New System.Drawing.Point(6, 231)
        Me.gbTipoGuia.Name = "gbTipoGuia"
        Me.gbTipoGuia.Size = New System.Drawing.Size(193, 37)
        Me.gbTipoGuia.TabIndex = 171
        Me.gbTipoGuia.TabStop = False
        Me.gbTipoGuia.Text = "&Tipo de la Glosa de la Guia"
        '
        'rbVariaslineas
        '
        Me.rbVariaslineas.AutoSize = True
        Me.rbVariaslineas.Location = New System.Drawing.Point(104, 15)
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
        Me.rbunalinea.Location = New System.Drawing.Point(7, 15)
        Me.rbunalinea.Name = "rbunalinea"
        Me.rbunalinea.Size = New System.Drawing.Size(92, 17)
        Me.rbunalinea.TabIndex = 0
        Me.rbunalinea.TabStop = True
        Me.rbunalinea.Text = "&Una sola linea"
        Me.rbunalinea.UseVisualStyleBackColor = True
        '
        'GbdetalleDocumento
        '
        Me.GbdetalleDocumento.BackColor = System.Drawing.Color.Gainsboro
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
        Me.GbdetalleDocumento.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GbdetalleDocumento.ForeColor = System.Drawing.Color.Black
        Me.GbdetalleDocumento.Location = New System.Drawing.Point(919, 74)
        Me.GbdetalleDocumento.Name = "GbdetalleDocumento"
        Me.GbdetalleDocumento.Size = New System.Drawing.Size(347, 121)
        Me.GbdetalleDocumento.TabIndex = 170
        Me.GbdetalleDocumento.TabStop = False
        Me.GbdetalleDocumento.Text = "&Detalles del Documento de Facturacion"
        Me.GbdetalleDocumento.Visible = False
        '
        'txtdetalleguiaserie
        '
        Me.txtdetalleguiaserie.BackColor = System.Drawing.Color.White
        Me.txtdetalleguiaserie.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtdetalleguiaserie.Location = New System.Drawing.Point(210, 41)
        Me.txtdetalleguiaserie.Name = "txtdetalleguiaserie"
        Me.txtdetalleguiaserie.ReadOnly = True
        Me.txtdetalleguiaserie.Size = New System.Drawing.Size(31, 24)
        Me.txtdetalleguiaserie.TabIndex = 173
        Me.txtdetalleguiaserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdetalleserie
        '
        Me.txtdetalleserie.BackColor = System.Drawing.Color.White
        Me.txtdetalleserie.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtdetalleserie.Location = New System.Drawing.Point(41, 41)
        Me.txtdetalleserie.Name = "txtdetalleserie"
        Me.txtdetalleserie.ReadOnly = True
        Me.txtdetalleserie.Size = New System.Drawing.Size(31, 24)
        Me.txtdetalleserie.TabIndex = 168
        Me.txtdetalleserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeroCP
        '
        Me.txtNumeroCP.BackColor = System.Drawing.Color.White
        Me.txtNumeroCP.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroCP.Location = New System.Drawing.Point(166, 88)
        Me.txtNumeroCP.Name = "txtNumeroCP"
        Me.txtNumeroCP.ReadOnly = True
        Me.txtNumeroCP.Size = New System.Drawing.Size(94, 24)
        Me.txtNumeroCP.TabIndex = 165
        Me.txtNumeroCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdetalleguianumero
        '
        Me.txtdetalleguianumero.BackColor = System.Drawing.Color.White
        Me.txtdetalleguianumero.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtdetalleguianumero.Location = New System.Drawing.Point(242, 41)
        Me.txtdetalleguianumero.Name = "txtdetalleguianumero"
        Me.txtdetalleguianumero.ReadOnly = True
        Me.txtdetalleguianumero.Size = New System.Drawing.Size(94, 24)
        Me.txtdetalleguianumero.TabIndex = 174
        Me.txtdetalleguianumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerieCP
        '
        Me.txtSerieCP.BackColor = System.Drawing.Color.White
        Me.txtSerieCP.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSerieCP.Location = New System.Drawing.Point(134, 88)
        Me.txtSerieCP.Name = "txtSerieCP"
        Me.txtSerieCP.ReadOnly = True
        Me.txtSerieCP.Size = New System.Drawing.Size(31, 24)
        Me.txtSerieCP.TabIndex = 164
        Me.txtSerieCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoCP
        '
        Me.txtcodigoCP.BackColor = System.Drawing.Color.White
        Me.txtcodigoCP.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtcodigoCP.Location = New System.Drawing.Point(102, 88)
        Me.txtcodigoCP.Name = "txtcodigoCP"
        Me.txtcodigoCP.ReadOnly = True
        Me.txtcodigoCP.Size = New System.Drawing.Size(30, 24)
        Me.txtcodigoCP.TabIndex = 163
        Me.txtcodigoCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label40.Location = New System.Drawing.Point(181, 23)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(96, 16)
        Me.Label40.TabIndex = 171
        Me.Label40.Text = "Guia de Remision"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.Location = New System.Drawing.Point(105, 71)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(133, 16)
        Me.Label38.TabIndex = 162
        Me.Label38.Text = "Comprobante Percepcion"
        '
        'txtdetallenumero
        '
        Me.txtdetallenumero.BackColor = System.Drawing.Color.White
        Me.txtdetallenumero.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtdetallenumero.Location = New System.Drawing.Point(73, 41)
        Me.txtdetallenumero.Name = "txtdetallenumero"
        Me.txtdetallenumero.ReadOnly = True
        Me.txtdetallenumero.Size = New System.Drawing.Size(94, 24)
        Me.txtdetallenumero.TabIndex = 169
        Me.txtdetallenumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdetalleguiadoc
        '
        Me.txtdetalleguiadoc.BackColor = System.Drawing.Color.White
        Me.txtdetalleguiadoc.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtdetalleguiadoc.Location = New System.Drawing.Point(179, 41)
        Me.txtdetalleguiadoc.Name = "txtdetalleguiadoc"
        Me.txtdetalleguiadoc.ReadOnly = True
        Me.txtdetalleguiadoc.Size = New System.Drawing.Size(30, 24)
        Me.txtdetalleguiadoc.TabIndex = 172
        Me.txtdetalleguiadoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.Location = New System.Drawing.Point(12, 23)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(65, 16)
        Me.Label39.TabIndex = 166
        Me.Label39.Text = "Documento"
        '
        'txtdetalledoc
        '
        Me.txtdetalledoc.BackColor = System.Drawing.Color.White
        Me.txtdetalledoc.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtdetalledoc.Location = New System.Drawing.Point(10, 41)
        Me.txtdetalledoc.Name = "txtdetalledoc"
        Me.txtdetalledoc.ReadOnly = True
        Me.txtdetalledoc.Size = New System.Drawing.Size(30, 24)
        Me.txtdetalledoc.TabIndex = 167
        Me.txtdetalledoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label37.Location = New System.Drawing.Point(781, 40)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(74, 13)
        Me.Label37.TabIndex = 161
        Me.Label37.Text = "Serie.Doc.Ref"
        '
        'txtSerieDocRef
        '
        Me.txtSerieDocRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerieDocRef.Location = New System.Drawing.Point(859, 37)
        Me.txtSerieDocRef.Name = "txtSerieDocRef"
        Me.txtSerieDocRef.Size = New System.Drawing.Size(54, 20)
        Me.txtSerieDocRef.TabIndex = 7
        Me.txtSerieDocRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltipoDocRef
        '
        Me.lbltipoDocRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltipoDocRef.Location = New System.Drawing.Point(671, 37)
        Me.lbltipoDocRef.Name = "lbltipoDocRef"
        Me.lbltipoDocRef.Size = New System.Drawing.Size(105, 20)
        Me.lbltipoDocRef.TabIndex = 25
        Me.lbltipoDocRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttipoDocRef
        '
        Me.txttipoDocRef.BackColor = System.Drawing.Color.White
        Me.txttipoDocRef.Location = New System.Drawing.Point(598, 38)
        Me.txttipoDocRef.Name = "txttipoDocRef"
        Me.txttipoDocRef.ReadOnly = True
        Me.txttipoDocRef.Size = New System.Drawing.Size(48, 20)
        Me.txttipoDocRef.TabIndex = 6
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.Location = New System.Drawing.Point(524, 42)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(71, 13)
        Me.Label36.TabIndex = 157
        Me.Label36.Text = "Tipo.Doc.Ref"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(649, 38)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox10.TabIndex = 156
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(181, 111)
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
        Me.checkSinGuia.Location = New System.Drawing.Point(129, 161)
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
        Me.lblAlmacen.Location = New System.Drawing.Point(458, 12)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.ReadOnly = True
        Me.lblAlmacen.Size = New System.Drawing.Size(208, 20)
        Me.lblAlmacen.TabIndex = 22
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlmacen.Location = New System.Drawing.Point(416, 12)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(42, 20)
        Me.txtAlmacen.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(369, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = "Almacén"
        '
        'cboDirEntrega
        '
        Me.cboDirEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDirEntrega.FormattingEnabled = True
        Me.cboDirEntrega.Location = New System.Drawing.Point(127, 183)
        Me.cboDirEntrega.Name = "cboDirEntrega"
        Me.cboDirEntrega.Size = New System.Drawing.Size(786, 21)
        Me.cboDirEntrega.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(34, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Dirección entrega"
        '
        'txtordenCompra
        '
        Me.txtordenCompra.BackColor = System.Drawing.Color.White
        Me.txtordenCompra.Location = New System.Drawing.Point(341, 135)
        Me.txtordenCompra.Name = "txtordenCompra"
        Me.txtordenCompra.ReadOnly = True
        Me.txtordenCompra.Size = New System.Drawing.Size(110, 20)
        Me.txtordenCompra.TabIndex = 13
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.Location = New System.Drawing.Point(245, 139)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(90, 13)
        Me.Label35.TabIndex = 149
        Me.Label35.Text = "Orden de Compra"
        '
        'txtcotizacion
        '
        Me.txtcotizacion.BackColor = System.Drawing.Color.White
        Me.txtcotizacion.Location = New System.Drawing.Point(129, 135)
        Me.txtcotizacion.Name = "txtcotizacion"
        Me.txtcotizacion.ReadOnly = True
        Me.txtcotizacion.Size = New System.Drawing.Size(110, 20)
        Me.txtcotizacion.TabIndex = 12
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label34.Location = New System.Drawing.Point(68, 138)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 13)
        Me.Label34.TabIndex = 147
        Me.Label34.Text = "Cotizacion"
        '
        'txtNumDocRef
        '
        Me.txtNumDocRef.BackColor = System.Drawing.Color.White
        Me.txtNumDocRef.Location = New System.Drawing.Point(989, 38)
        Me.txtNumDocRef.Multiline = True
        Me.txtNumDocRef.Name = "txtNumDocRef"
        Me.txtNumDocRef.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNumDocRef.Size = New System.Drawing.Size(139, 20)
        Me.txtNumDocRef.TabIndex = 8
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.Location = New System.Drawing.Point(916, 41)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(67, 13)
        Me.Label33.TabIndex = 145
        Me.Label33.Text = "Nro.Doc.Ref"
        '
        'txtGlosa
        '
        Me.txtGlosa.BackColor = System.Drawing.Color.White
        Me.txtGlosa.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGlosa.Location = New System.Drawing.Point(127, 206)
        Me.txtGlosa.MaxLength = 355
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtGlosa.Size = New System.Drawing.Size(784, 25)
        Me.txtGlosa.TabIndex = 18
        Me.txtGlosa.Text = ""
        '
        'lblGlosa
        '
        Me.lblGlosa.AutoSize = True
        Me.lblGlosa.ForeColor = System.Drawing.Color.Black
        Me.lblGlosa.Location = New System.Drawing.Point(13, 211)
        Me.lblGlosa.Name = "lblGlosa"
        Me.lblGlosa.Size = New System.Drawing.Size(107, 13)
        Me.lblGlosa.TabIndex = 124
        Me.lblGlosa.Text = "Glosa del documento"
        Me.lblGlosa.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtpedido
        '
        Me.txtpedido.BackColor = System.Drawing.Color.White
        Me.txtpedido.Location = New System.Drawing.Point(539, 135)
        Me.txtpedido.Name = "txtpedido"
        Me.txtpedido.Size = New System.Drawing.Size(101, 20)
        Me.txtpedido.TabIndex = 14
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.Location = New System.Drawing.Point(456, 138)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 13)
        Me.Label32.TabIndex = 143
        Me.Label32.Text = "Numero Pedido"
        '
        'txtdescripcionTrama
        '
        Me.txtdescripcionTrama.BackColor = System.Drawing.Color.White
        Me.txtdescripcionTrama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionTrama.Location = New System.Drawing.Point(1256, 37)
        Me.txtdescripcionTrama.Name = "txtdescripcionTrama"
        Me.txtdescripcionTrama.ReadOnly = True
        Me.txtdescripcionTrama.Size = New System.Drawing.Size(47, 20)
        Me.txtdescripcionTrama.TabIndex = 142
        Me.txtdescripcionTrama.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1238, 38)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox8.TabIndex = 141
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'txtcodigoTrama
        '
        Me.txtcodigoTrama.Location = New System.Drawing.Point(1198, 37)
        Me.txtcodigoTrama.Name = "txtcodigoTrama"
        Me.txtcodigoTrama.Size = New System.Drawing.Size(37, 20)
        Me.txtcodigoTrama.TabIndex = 139
        Me.txtcodigoTrama.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(1156, 40)
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
        Me.txtdescripcionTransportista.Location = New System.Drawing.Point(1239, 246)
        Me.txtdescripcionTransportista.Name = "txtdescripcionTransportista"
        Me.txtdescripcionTransportista.ReadOnly = True
        Me.txtdescripcionTransportista.Size = New System.Drawing.Size(47, 20)
        Me.txtdescripcionTransportista.TabIndex = 138
        Me.txtdescripcionTransportista.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(1221, 247)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox7.TabIndex = 137
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'txtcodigoTransporte
        '
        Me.txtcodigoTransporte.Location = New System.Drawing.Point(1174, 243)
        Me.txtcodigoTransporte.Name = "txtcodigoTransporte"
        Me.txtcodigoTransporte.Size = New System.Drawing.Size(44, 20)
        Me.txtcodigoTransporte.TabIndex = 135
        Me.txtcodigoTransporte.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1175, 224)
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
        Me.txtdescVehiculo.Location = New System.Drawing.Point(1256, 12)
        Me.txtdescVehiculo.Name = "txtdescVehiculo"
        Me.txtdescVehiculo.ReadOnly = True
        Me.txtdescVehiculo.Size = New System.Drawing.Size(45, 20)
        Me.txtdescVehiculo.TabIndex = 134
        Me.txtdescVehiculo.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1238, 13)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox5.TabIndex = 133
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'txtcodigoVehiculo
        '
        Me.txtcodigoVehiculo.Location = New System.Drawing.Point(1198, 12)
        Me.txtcodigoVehiculo.Name = "txtcodigoVehiculo"
        Me.txtcodigoVehiculo.Size = New System.Drawing.Size(37, 20)
        Me.txtcodigoVehiculo.TabIndex = 131
        Me.txtcodigoVehiculo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1143, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Vehiculo "
        Me.Label2.Visible = False
        '
        'txtGlosaGuia
        '
        Me.txtGlosaGuia.BackColor = System.Drawing.Color.White
        Me.txtGlosaGuia.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtGlosaGuia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGlosaGuia.Location = New System.Drawing.Point(205, 237)
        Me.txtGlosaGuia.MaxLength = 355
        Me.txtGlosaGuia.Name = "txtGlosaGuia"
        Me.txtGlosaGuia.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtGlosaGuia.Size = New System.Drawing.Size(706, 25)
        Me.txtGlosaGuia.TabIndex = 19
        Me.txtGlosaGuia.Text = " "
        '
        'txtdescEsp
        '
        Me.txtdescEsp.BackColor = System.Drawing.Color.White
        Me.txtdescEsp.Location = New System.Drawing.Point(1050, 247)
        Me.txtdescEsp.Name = "txtdescEsp"
        Me.txtdescEsp.ReadOnly = True
        Me.txtdescEsp.Size = New System.Drawing.Size(110, 20)
        Me.txtdescEsp.TabIndex = 130
        Me.txtdescEsp.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(597, 159)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 118
        Me.PictureBox3.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.Location = New System.Drawing.Point(1051, 231)
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
        Me.lblVendedor.Location = New System.Drawing.Point(200, 111)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.ReadOnly = True
        Me.lblVendedor.Size = New System.Drawing.Size(251, 20)
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
        Me.lblFormaPago.Location = New System.Drawing.Point(599, 111)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.ReadOnly = True
        Me.lblFormaPago.Size = New System.Drawing.Size(314, 20)
        Me.lblFormaPago.TabIndex = 30
        '
        'txtNomTrans
        '
        Me.txtNomTrans.BackColor = System.Drawing.Color.White
        Me.txtNomTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomTrans.Enabled = False
        Me.txtNomTrans.Location = New System.Drawing.Point(620, 159)
        Me.txtNomTrans.Name = "txtNomTrans"
        Me.txtNomTrans.Size = New System.Drawing.Size(292, 20)
        Me.txtNomTrans.TabIndex = 31
        Me.txtNomTrans.Text = "."
        '
        'txtCodTrans
        '
        Me.txtCodTrans.BackColor = System.Drawing.Color.White
        Me.txtCodTrans.Location = New System.Drawing.Point(539, 159)
        Me.txtCodTrans.Name = "txtCodTrans"
        Me.txtCodTrans.Size = New System.Drawing.Size(53, 20)
        Me.txtCodTrans.TabIndex = 16
        Me.txtCodTrans.Text = "00"
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
        Me.Label18.Location = New System.Drawing.Point(460, 163)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Transportista"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(581, 112)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        '
        'lblPtoVenta
        '
        Me.lblPtoVenta.BackColor = System.Drawing.Color.White
        Me.lblPtoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPtoVenta.Location = New System.Drawing.Point(202, 13)
        Me.lblPtoVenta.Name = "lblPtoVenta"
        Me.lblPtoVenta.ReadOnly = True
        Me.lblPtoVenta.Size = New System.Drawing.Size(162, 20)
        Me.lblPtoVenta.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 112
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(182, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 111
        Me.PictureBox4.TabStop = False
        '
        'cbSerieGuia
        '
        Me.cbSerieGuia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSerieGuia.FormattingEnabled = True
        Me.cbSerieGuia.Location = New System.Drawing.Point(341, 159)
        Me.cbSerieGuia.Name = "cbSerieGuia"
        Me.cbSerieGuia.Size = New System.Drawing.Size(110, 21)
        Me.cbSerieGuia.TabIndex = 15
        '
        'cboSerieDoc
        '
        Me.cboSerieDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSerieDoc.FormattingEnabled = True
        Me.cboSerieDoc.Location = New System.Drawing.Point(440, 38)
        Me.cboSerieDoc.Name = "cboSerieDoc"
        Me.cboSerieDoc.Size = New System.Drawing.Size(79, 21)
        Me.cboSerieDoc.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(404, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Serie"
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(130, 38)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(126, 20)
        Me.dtpFechaFactura.TabIndex = 2
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Location = New System.Drawing.Point(329, 38)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(70, 21)
        Me.cboTipoDoc.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(261, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Documento"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(726, 11)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(185, 21)
        Me.cboMoneda.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(266, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Serie de Guia"
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BackColor = System.Drawing.Color.White
        Me.txtFormaPago.Location = New System.Drawing.Point(540, 110)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.Size = New System.Drawing.Size(37, 20)
        Me.txtFormaPago.TabIndex = 11
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Location = New System.Drawing.Point(1004, 12)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(79, 20)
        Me.txtTipoCambio.TabIndex = 24
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(129, 111)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(49, 20)
        Me.txtVendedor.TabIndex = 10
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(130, 87)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(783, 20)
        Me.txtDireccion.TabIndex = 28
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.White
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Location = New System.Drawing.Point(540, 63)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(372, 20)
        Me.txtRazonSocial.TabIndex = 27
        '
        'txtRucDni
        '
        Me.txtRucDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRucDni.Location = New System.Drawing.Point(285, 63)
        Me.txtRucDni.Name = "txtRucDni"
        Me.txtRucDni.Size = New System.Drawing.Size(131, 20)
        Me.txtRucDni.TabIndex = 26
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(130, 63)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(71, 20)
        Me.txtCodCliente.TabIndex = 9
        '
        'txtPtoVenta
        '
        Me.txtPtoVenta.BackColor = System.Drawing.Color.White
        Me.txtPtoVenta.Location = New System.Drawing.Point(130, 13)
        Me.txtPtoVenta.Name = "txtPtoVenta"
        Me.txtPtoVenta.Size = New System.Drawing.Size(50, 20)
        Me.txtPtoVenta.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(457, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Forma de pago"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(917, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Tipo de cambio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(673, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Moneda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(73, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Vendedor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(419, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Razón social / Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Ruc/ Dni"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(89, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Punto de venta"
        '
        'chkSinIGV
        '
        Me.chkSinIGV.AutoSize = True
        Me.chkSinIGV.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkSinIGV.Location = New System.Drawing.Point(1141, 424)
        Me.chkSinIGV.Name = "chkSinIGV"
        Me.chkSinIGV.Size = New System.Drawing.Size(104, 21)
        Me.chkSinIGV.TabIndex = 84
        Me.chkSinIGV.Text = "&Precio sin Igv."
        Me.chkSinIGV.UseVisualStyleBackColor = True
        '
        'dgvDocumentosFactura
        '
        Me.dgvDocumentosFactura.AllowUserToAddRows = False
        Me.dgvDocumentosFactura.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocumentosFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDocumentosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocumentosFactura.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDocumentosFactura.Location = New System.Drawing.Point(13, 125)
        Me.dgvDocumentosFactura.MultiSelect = False
        Me.dgvDocumentosFactura.Name = "dgvDocumentosFactura"
        Me.dgvDocumentosFactura.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocumentosFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDocumentosFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDocumentosFactura.Size = New System.Drawing.Size(1316, 613)
        Me.dgvDocumentosFactura.TabIndex = 117
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(14, 743)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 118
        Me.lblCantidad.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(556, 45)
        Me.GroupBox3.TabIndex = 119
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(540, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.Location = New System.Drawing.Point(898, 5)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 121
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(710, 5)
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(710, 651)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 17)
        Me.Label15.TabIndex = 126
        Me.Label15.Text = "Redondeo"
        '
        'txtredondeo
        '
        Me.txtredondeo.BackColor = System.Drawing.Color.Silver
        Me.txtredondeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtredondeo.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtredondeo.Location = New System.Drawing.Point(778, 648)
        Me.txtredondeo.Name = "txtredondeo"
        Me.txtredondeo.ReadOnly = True
        Me.txtredondeo.Size = New System.Drawing.Size(89, 22)
        Me.txtredondeo.TabIndex = 127
        Me.txtredondeo.Text = "0.00"
        Me.txtredondeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBruto
        '
        Me.txtBruto.BackColor = System.Drawing.Color.Silver
        Me.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBruto.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtBruto.Location = New System.Drawing.Point(939, 649)
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.ReadOnly = True
        Me.txtBruto.Size = New System.Drawing.Size(89, 22)
        Me.txtBruto.TabIndex = 129
        Me.txtBruto.Text = "0.00"
        Me.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(898, 651)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 17)
        Me.Label16.TabIndex = 128
        Me.Label16.Text = "Bruto"
        '
        'txtvalorVenta
        '
        Me.txtvalorVenta.BackColor = System.Drawing.Color.Silver
        Me.txtvalorVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorVenta.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtvalorVenta.Location = New System.Drawing.Point(1150, 649)
        Me.txtvalorVenta.Name = "txtvalorVenta"
        Me.txtvalorVenta.Size = New System.Drawing.Size(89, 22)
        Me.txtvalorVenta.TabIndex = 131
        Me.txtvalorVenta.Text = "0.00"
        Me.txtvalorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(1077, 652)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 17)
        Me.Label22.TabIndex = 130
        Me.Label22.Text = "&Valor Venta"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.BackColor = System.Drawing.Color.Silver
        Me.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuentos.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescuentos.Location = New System.Drawing.Point(1150, 672)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(89, 22)
        Me.txtDescuentos.TabIndex = 133
        Me.txtDescuentos.Text = "0.00"
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(1083, 675)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 17)
        Me.Label23.TabIndex = 132
        Me.Label23.Text = "&Descuento"
        '
        'txtIgv
        '
        Me.txtIgv.BackColor = System.Drawing.Color.Silver
        Me.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIgv.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtIgv.Location = New System.Drawing.Point(1150, 695)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(89, 22)
        Me.txtIgv.TabIndex = 135
        Me.txtIgv.Text = "0.00"
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(1108, 697)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 17)
        Me.Label24.TabIndex = 134
        Me.Label24.Text = "&I.G.V"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.Silver
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtPrecioVenta.Location = New System.Drawing.Point(1150, 718)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(89, 22)
        Me.txtPrecioVenta.TabIndex = 137
        Me.txtPrecioVenta.Text = "0.00"
        Me.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.Location = New System.Drawing.Point(1071, 721)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 17)
        Me.Label28.TabIndex = 136
        Me.Label28.Text = "&Precio Venta"
        '
        'pnlFiltros
        '
        Me.pnlFiltros.Controls.Add(Me.GroupBox4)
        Me.pnlFiltros.Controls.Add(Me.GroupBox3)
        Me.pnlFiltros.Controls.Add(Me.GroupBox2)
        Me.pnlFiltros.Controls.Add(Me.gbRangofechas)
        Me.pnlFiltros.Location = New System.Drawing.Point(13, 63)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(1316, 55)
        Me.pnlFiltros.TabIndex = 138
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboOpcionTipoDoc)
        Me.GroupBox4.Location = New System.Drawing.Point(567, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(138, 45)
        Me.GroupBox4.TabIndex = 122
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "&Tipo de Documento"
        '
        'cboOpcionTipoDoc
        '
        Me.cboOpcionTipoDoc.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpcionTipoDoc.FormattingEnabled = True
        Me.cboOpcionTipoDoc.Items.AddRange(New Object() {"Todos", "BV", "CP", "FT", "NC", "ND"})
        Me.cboOpcionTipoDoc.Location = New System.Drawing.Point(6, 15)
        Me.cboOpcionTipoDoc.Name = "cboOpcionTipoDoc"
        Me.cboOpcionTipoDoc.Size = New System.Drawing.Size(125, 25)
        Me.cboOpcionTipoDoc.TabIndex = 5
        '
        'btnSalirNumeracion
        '
        Me.btnSalirNumeracion.Image = CType(resources.GetObject("btnSalirNumeracion.Image"), System.Drawing.Image)
        Me.btnSalirNumeracion.Location = New System.Drawing.Point(185, 18)
        Me.btnSalirNumeracion.Name = "btnSalirNumeracion"
        Me.btnSalirNumeracion.Size = New System.Drawing.Size(30, 28)
        Me.btnSalirNumeracion.TabIndex = 163
        Me.btnSalirNumeracion.UseVisualStyleBackColor = True
        '
        'btnAceptarBusquedaOC
        '
        Me.btnAceptarBusquedaOC.Image = CType(resources.GetObject("btnAceptarBusquedaOC.Image"), System.Drawing.Image)
        Me.btnAceptarBusquedaOC.Location = New System.Drawing.Point(147, 19)
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
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
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
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
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
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(5, 54)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "&Refact"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtBuscarOrdenCompra
        '
        Me.txtBuscarOrdenCompra.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtBuscarOrdenCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBuscarOrdenCompra.Location = New System.Drawing.Point(2, 20)
        Me.txtBuscarOrdenCompra.MaxLength = 20
        Me.txtBuscarOrdenCompra.Name = "txtBuscarOrdenCompra"
        Me.txtBuscarOrdenCompra.Size = New System.Drawing.Size(138, 27)
        Me.txtBuscarOrdenCompra.TabIndex = 0
        Me.txtBuscarOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlBuscarordenCompra
        '
        Me.PnlBuscarordenCompra.BackColor = System.Drawing.Color.Gainsboro
        Me.PnlBuscarordenCompra.Controls.Add(Me.TextBox1)
        Me.PnlBuscarordenCompra.Controls.Add(Me.GroupBox1)
        Me.PnlBuscarordenCompra.Location = New System.Drawing.Point(471, 229)
        Me.PnlBuscarordenCompra.Name = "PnlBuscarordenCompra"
        Me.PnlBuscarordenCompra.Size = New System.Drawing.Size(249, 121)
        Me.PnlBuscarordenCompra.TabIndex = 163
        Me.PnlBuscarordenCompra.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(2, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 18)
        Me.TextBox1.TabIndex = 166
        Me.TextBox1.Text = "Ingrese un Nro. Orden de Compra"
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 79)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        '
        'gbGenerarCP
        '
        Me.gbGenerarCP.BackColor = System.Drawing.Color.Gainsboro
        Me.gbGenerarCP.Controls.Add(Me.btnGenerarCP)
        Me.gbGenerarCP.Location = New System.Drawing.Point(544, 66)
        Me.gbGenerarCP.Name = "gbGenerarCP"
        Me.gbGenerarCP.Size = New System.Drawing.Size(194, 53)
        Me.gbGenerarCP.TabIndex = 162
        Me.gbGenerarCP.TabStop = False
        Me.gbGenerarCP.Visible = False
        '
        'btnGenerarCP
        '
        Me.btnGenerarCP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerarCP.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerarCP.Location = New System.Drawing.Point(5, 9)
        Me.btnGenerarCP.Name = "btnGenerarCP"
        Me.btnGenerarCP.Size = New System.Drawing.Size(182, 42)
        Me.btnGenerarCP.TabIndex = 163
        Me.btnGenerarCP.Text = "&Generacion de Comprobante Percepcion"
        Me.btnGenerarCP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGenerarCP.UseVisualStyleBackColor = False
        '
        'gbTipoFacturacion
        '
        Me.gbTipoFacturacion.BackColor = System.Drawing.Color.Gainsboro
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaExistencias)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaGuiaVenta)
        Me.gbTipoFacturacion.Controls.Add(Me.rbFacturaDirecta)
        Me.gbTipoFacturacion.Controls.Add(Me.TextBox2)
        Me.gbTipoFacturacion.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbTipoFacturacion.Location = New System.Drawing.Point(12, 62)
        Me.gbTipoFacturacion.Name = "gbTipoFacturacion"
        Me.gbTipoFacturacion.Size = New System.Drawing.Size(527, 57)
        Me.gbTipoFacturacion.TabIndex = 164
        Me.gbTipoFacturacion.TabStop = False
        '
        'rbFacturaExistencias
        '
        Me.rbFacturaExistencias.AutoSize = True
        Me.rbFacturaExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaExistencias.Location = New System.Drawing.Point(251, 36)
        Me.rbFacturaExistencias.Name = "rbFacturaExistencias"
        Me.rbFacturaExistencias.Size = New System.Drawing.Size(269, 17)
        Me.rbFacturaExistencias.TabIndex = 170
        Me.rbFacturaExistencias.Text = "&Existencias por Entregar - Facturacion sin Descargo"
        Me.rbFacturaExistencias.UseVisualStyleBackColor = True
        '
        'rbFacturaGuiaVenta
        '
        Me.rbFacturaGuiaVenta.AutoSize = True
        Me.rbFacturaGuiaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaGuiaVenta.Location = New System.Drawing.Point(134, 36)
        Me.rbFacturaGuiaVenta.Name = "rbFacturaGuiaVenta"
        Me.rbFacturaGuiaVenta.Size = New System.Drawing.Size(110, 17)
        Me.rbFacturaGuiaVenta.TabIndex = 169
        Me.rbFacturaGuiaVenta.Text = "& Guia por Facturar"
        Me.rbFacturaGuiaVenta.UseVisualStyleBackColor = True
        '
        'rbFacturaDirecta
        '
        Me.rbFacturaDirecta.AutoSize = True
        Me.rbFacturaDirecta.Checked = True
        Me.rbFacturaDirecta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.rbFacturaDirecta.Location = New System.Drawing.Point(8, 36)
        Me.rbFacturaDirecta.Name = "rbFacturaDirecta"
        Me.rbFacturaDirecta.Size = New System.Drawing.Size(118, 17)
        Me.rbFacturaDirecta.TabIndex = 168
        Me.rbFacturaDirecta.TabStop = True
        Me.rbFacturaDirecta.Text = "&Facturacion Directa"
        Me.rbFacturaDirecta.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(3, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(522, 18)
        Me.TextBox2.TabIndex = 167
        Me.TextBox2.Text = "Seleccione un Tipo de Facturacion"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlDocumentosGuiaVenta
        '
        Me.pnlDocumentosGuiaVenta.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlDocumentosGuiaVenta.Controls.Add(Me.Label41)
        Me.pnlDocumentosGuiaVenta.Controls.Add(Me.GroupBox5)
        Me.pnlDocumentosGuiaVenta.Location = New System.Drawing.Point(484, 139)
        Me.pnlDocumentosGuiaVenta.Name = "pnlDocumentosGuiaVenta"
        Me.pnlDocumentosGuiaVenta.Size = New System.Drawing.Size(427, 258)
        Me.pnlDocumentosGuiaVenta.TabIndex = 165
        Me.pnlDocumentosGuiaVenta.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(143, 6)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(146, 21)
        Me.Label41.TabIndex = 1
        Me.Label41.Text = "GUIAS DE VENTA"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_close)
        Me.GroupBox5.Controls.Add(Me.btn_ok)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.dgvDocumentosCliente)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 18)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(396, 232)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(328, 27)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(49, 39)
        Me.btn_close.TabIndex = 121
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.Location = New System.Drawing.Point(280, 27)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(49, 39)
        Me.btn_ok.TabIndex = 122
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtFiltroCliente)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(262, 45)
        Me.GroupBox6.TabIndex = 120
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ingrese Nro Documento  a Buscar :"
        '
        'txtFiltroCliente
        '
        Me.txtFiltroCliente.BackColor = System.Drawing.Color.Aquamarine
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
        Me.dgvDocumentosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentosCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvDocumentosCliente.Location = New System.Drawing.Point(12, 75)
        Me.dgvDocumentosCliente.Name = "dgvDocumentosCliente"
        Me.dgvDocumentosCliente.Size = New System.Drawing.Size(367, 150)
        Me.dgvDocumentosCliente.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Seleccionar"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'gbGenerarDespacho
        '
        Me.gbGenerarDespacho.BackColor = System.Drawing.Color.Gainsboro
        Me.gbGenerarDespacho.Controls.Add(Me.btnDespacho)
        Me.gbGenerarDespacho.Location = New System.Drawing.Point(743, 65)
        Me.gbGenerarDespacho.Name = "gbGenerarDespacho"
        Me.gbGenerarDespacho.Size = New System.Drawing.Size(194, 53)
        Me.gbGenerarDespacho.TabIndex = 166
        Me.gbGenerarDespacho.TabStop = False
        Me.gbGenerarDespacho.Visible = False
        '
        'btnDespacho
        '
        Me.btnDespacho.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDespacho.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDespacho.Location = New System.Drawing.Point(6, 9)
        Me.btnDespacho.Name = "btnDespacho"
        Me.btnDespacho.Size = New System.Drawing.Size(182, 42)
        Me.btnDespacho.TabIndex = 163
        Me.btnDespacho.Text = "&Confirmar Despacho"
        Me.btnDespacho.UseVisualStyleBackColor = False
        '
        'pnlConfirmarDespacho
        '
        Me.pnlConfirmarDespacho.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlConfirmarDespacho.Controls.Add(Me.TextBox3)
        Me.pnlConfirmarDespacho.Controls.Add(Me.GroupBox7)
        Me.pnlConfirmarDespacho.Location = New System.Drawing.Point(467, 143)
        Me.pnlConfirmarDespacho.Name = "pnlConfirmarDespacho"
        Me.pnlConfirmarDespacho.Size = New System.Drawing.Size(461, 100)
        Me.pnlConfirmarDespacho.TabIndex = 167
        Me.pnlConfirmarDespacho.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(1, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(458, 20)
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
        Me.GroupBox7.Location = New System.Drawing.Point(16, 18)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(431, 71)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'dtpDespacho
        '
        Me.dtpDespacho.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpDespacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDespacho.Location = New System.Drawing.Point(117, 38)
        Me.dtpDespacho.Name = "dtpDespacho"
        Me.dtpDespacho.Size = New System.Drawing.Size(153, 25)
        Me.dtpDespacho.TabIndex = 126
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label45.Location = New System.Drawing.Point(7, 43)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(106, 17)
        Me.Label45.TabIndex = 125
        Me.Label45.Text = "&Fecha Documento"
        '
        'lblDespachoNumero
        '
        Me.lblDespachoNumero.AutoSize = True
        Me.lblDespachoNumero.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDespachoNumero.ForeColor = System.Drawing.Color.Maroon
        Me.lblDespachoNumero.Location = New System.Drawing.Point(118, 15)
        Me.lblDespachoNumero.Name = "lblDespachoNumero"
        Me.lblDespachoNumero.Size = New System.Drawing.Size(22, 21)
        Me.lblDespachoNumero.TabIndex = 124
        Me.lblDespachoNumero.Text = "..."
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label43.Location = New System.Drawing.Point(5, 17)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(106, 17)
        Me.Label43.TabIndex = 123
        Me.Label43.Text = "&Nro. Documento :"
        '
        'btn_SalirDesp
        '
        Me.btn_SalirDesp.Image = CType(resources.GetObject("btn_SalirDesp.Image"), System.Drawing.Image)
        Me.btn_SalirDesp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_SalirDesp.Location = New System.Drawing.Point(361, 12)
        Me.btn_SalirDesp.Name = "btn_SalirDesp"
        Me.btn_SalirDesp.Size = New System.Drawing.Size(59, 52)
        Me.btn_SalirDesp.TabIndex = 121
        Me.btn_SalirDesp.Text = "Cancelar"
        Me.btn_SalirDesp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_SalirDesp.UseVisualStyleBackColor = True
        '
        'btn_AceptarDesp
        '
        Me.btn_AceptarDesp.Image = CType(resources.GetObject("btn_AceptarDesp.Image"), System.Drawing.Image)
        Me.btn_AceptarDesp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_AceptarDesp.Location = New System.Drawing.Point(300, 12)
        Me.btn_AceptarDesp.Name = "btn_AceptarDesp"
        Me.btn_AceptarDesp.Size = New System.Drawing.Size(59, 52)
        Me.btn_AceptarDesp.TabIndex = 122
        Me.btn_AceptarDesp.Text = "Confirmar"
        Me.btn_AceptarDesp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_AceptarDesp.UseVisualStyleBackColor = True
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1339, 762)
        Me.Controls.Add(Me.dgvDocumentosFactura)
        Me.Controls.Add(Me.pnlConfirmarDespacho)
        Me.Controls.Add(Me.pnlDocumentosGuiaVenta)
        Me.Controls.Add(Me.PnlBuscarordenCompra)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.gbGenerarDespacho)
        Me.Controls.Add(Me.lblCantidad)
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
        Me.Controls.Add(Me.chkSinIGV)
        Me.Controls.Add(Me.gbGenerarCP)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.gbTipoFacturacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        Me.gbdetalle.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.gbTipoGuia.ResumeLayout(False)
        Me.gbTipoGuia.PerformLayout()
        Me.GbdetalleDocumento.ResumeLayout(False)
        Me.GbdetalleDocumento.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.pnlFiltros.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.PnlBuscarordenCompra.ResumeLayout(False)
        Me.PnlBuscarordenCompra.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbGenerarCP.ResumeLayout(False)
        Me.gbTipoFacturacion.ResumeLayout(False)
        Me.gbTipoFacturacion.PerformLayout()
        Me.pnlDocumentosGuiaVenta.ResumeLayout(False)
        Me.pnlDocumentosGuiaVenta.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvDocumentosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGenerarDespacho.ResumeLayout(False)
        Me.pnlConfirmarDespacho.ResumeLayout(False)
        Me.pnlConfirmarDespacho.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
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
    Friend WithEvents lblGlosa As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents txttipoDocRef As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lbltipoDocRef As System.Windows.Forms.TextBox
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
    Friend WithEvents gbGenerarCP As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerarCP As System.Windows.Forms.Button
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
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents pnlDocumentosGuiaVenta As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltroCliente As System.Windows.Forms.TextBox
    Friend WithEvents dgvDocumentosCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents rbFacturaExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents gbGenerarDespacho As System.Windows.Forms.GroupBox
    Friend WithEvents btnDespacho As System.Windows.Forms.Button
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
End Class
