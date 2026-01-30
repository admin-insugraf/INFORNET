<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Compras_Importacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Compras_Importacion))
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Imprimir_Orden_Pago = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
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
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.Tc_principal = New System.Windows.Forms.TabControl()
        Me.tc_datos = New System.Windows.Forms.TabPage()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.txt_numero_dam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_fecha_dam = New System.Windows.Forms.DateTimePicker()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txt_invoice2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcompra = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.dtp_fecha_invoice = New System.Windows.Forms.DateTimePicker()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txttipoCambio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtproveedor_ruc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtproveedor_razons = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btn_agregar_gastos = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.tc_detalle = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_percepcion2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_sobretasa_sancion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_sobretasa_tributo = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_seguro2 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt_derechos_antidumping = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_derechos_especificos = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_ipm = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_igv = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_isc = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.txt_ad_valorem2 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_precio_total = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_precio_unitario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_sub_partida_dam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_percepcion = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_ipm_ = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_igv_ = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_ad_valorem = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_seguro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_flete = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txt_valor_ref_flete = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.tc_detalle2 = New System.Windows.Forms.TabPage()
        Me.btn_cancel2 = New System.Windows.Forms.Button()
        Me.btnAceptar2 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txt_15 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_14 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_13 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txt_12 = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txt_11 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_10 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txt_9 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txt_8 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt_7 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_6 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_5 = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txt_4 = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_3 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txt_2 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.btn_menu.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tc_principal.SuspendLayout()
        Me.tc_datos.SuspendLayout()
        Me.gbcabecera.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_detalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.tc_detalle2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btnEliminar, Me.btnImprimir, Me.btnCancelar, Me.Tool_Imprimir_Orden_Pago, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(1023, 25)
        Me.btn_menu.TabIndex = 205
        Me.btn_menu.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Navy
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.Navy
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 22)
        Me.btnConsultar.Text = "&Consultar"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ForeColor = System.Drawing.Color.Navy
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(73, 22)
        Me.btnGrabar.Text = "&Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 22)
        Me.btnEliminar.Text = "&Anular"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.Navy
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(77, 22)
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Navy
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = "Canc&elar"
        '
        'Tool_Imprimir_Orden_Pago
        '
        Me.Tool_Imprimir_Orden_Pago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Imprimir_Orden_Pago.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Imprimir_Orden_Pago.Image = CType(resources.GetObject("Tool_Imprimir_Orden_Pago.Image"), System.Drawing.Image)
        Me.Tool_Imprimir_Orden_Pago.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir_Orden_Pago.Name = "Tool_Imprimir_Orden_Pago"
        Me.Tool_Imprimir_Orden_Pago.Size = New System.Drawing.Size(121, 22)
        Me.Tool_Imprimir_Orden_Pago.Text = "Imp. Orden Pago"
        Me.Tool_Imprimir_Orden_Pago.Visible = False
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton7.Text = "&Salir"
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
        Me.pnlCabecera.Location = New System.Drawing.Point(13, 39)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(999, 557)
        Me.pnlCabecera.TabIndex = 203
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
        Me.lblDetalle.ReadOnly = True
        Me.lblDetalle.Size = New System.Drawing.Size(994, 20)
        Me.lblDetalle.TabIndex = 198
        Me.lblDetalle.Text = "LISTADO DE IMPORTACIONES"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(17, 528)
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
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.AllowUserToResizeColumns = False
        Me.dgvCabecera.AllowUserToResizeRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(13, 104)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.Size = New System.Drawing.Size(977, 421)
        Me.dgvCabecera.TabIndex = 2
        '
        'Tc_principal
        '
        Me.Tc_principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tc_principal.Controls.Add(Me.tc_datos)
        Me.Tc_principal.Controls.Add(Me.tc_detalle)
        Me.Tc_principal.Controls.Add(Me.tc_detalle2)
        Me.Tc_principal.Location = New System.Drawing.Point(13, 41)
        Me.Tc_principal.Multiline = True
        Me.Tc_principal.Name = "Tc_principal"
        Me.Tc_principal.SelectedIndex = 0
        Me.Tc_principal.Size = New System.Drawing.Size(998, 550)
        Me.Tc_principal.TabIndex = 204
        '
        'tc_datos
        '
        Me.tc_datos.BackColor = System.Drawing.Color.White
        Me.tc_datos.Controls.Add(Me.gbcabecera)
        Me.tc_datos.Controls.Add(Me.Label7)
        Me.tc_datos.Controls.Add(Me.gbOpciones)
        Me.tc_datos.Controls.Add(Me.txtComentario)
        Me.tc_datos.Controls.Add(Me.gbDetalles)
        Me.tc_datos.Location = New System.Drawing.Point(4, 22)
        Me.tc_datos.Name = "tc_datos"
        Me.tc_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_datos.Size = New System.Drawing.Size(990, 524)
        Me.tc_datos.TabIndex = 0
        Me.tc_datos.Text = "Datos del Registro de Importación"
        '
        'gbcabecera
        '
        Me.gbcabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbcabecera.Controls.Add(Me.txt_numero_dam)
        Me.gbcabecera.Controls.Add(Me.Label3)
        Me.gbcabecera.Controls.Add(Me.dtp_fecha_dam)
        Me.gbcabecera.Controls.Add(Me.Label48)
        Me.gbcabecera.Controls.Add(Me.txt_invoice2)
        Me.gbcabecera.Controls.Add(Me.Label1)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.lblcompra)
        Me.gbcabecera.Controls.Add(Me.txtproveedor)
        Me.gbcabecera.Controls.Add(Me.dtp_fecha_invoice)
        Me.gbcabecera.Controls.Add(Me.Label49)
        Me.gbcabecera.Controls.Add(Me.txttipoCambio)
        Me.gbcabecera.Controls.Add(Me.Label11)
        Me.gbcabecera.Controls.Add(Me.Label10)
        Me.gbcabecera.Controls.Add(Me.cbomoneda)
        Me.gbcabecera.Controls.Add(Me.Label8)
        Me.gbcabecera.Controls.Add(Me.txtproveedor_ruc)
        Me.gbcabecera.Controls.Add(Me.Label6)
        Me.gbcabecera.Controls.Add(Me.txtproveedor_razons)
        Me.gbcabecera.Controls.Add(Me.Label5)
        Me.gbcabecera.ForeColor = System.Drawing.Color.Navy
        Me.gbcabecera.Location = New System.Drawing.Point(6, 4)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(973, 111)
        Me.gbcabecera.TabIndex = 178
        Me.gbcabecera.TabStop = False
        '
        'txt_numero_dam
        '
        Me.txt_numero_dam.BackColor = System.Drawing.Color.White
        Me.txt_numero_dam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_dam.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_dam.Location = New System.Drawing.Point(465, 26)
        Me.txt_numero_dam.Name = "txt_numero_dam"
        Me.txt_numero_dam.Size = New System.Drawing.Size(136, 21)
        Me.txt_numero_dam.TabIndex = 272
        Me.txt_numero_dam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(498, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 273
        Me.Label3.Text = "Nro DAM"
        '
        'dtp_fecha_dam
        '
        Me.dtp_fecha_dam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_dam.Location = New System.Drawing.Point(606, 26)
        Me.dtp_fecha_dam.Name = "dtp_fecha_dam"
        Me.dtp_fecha_dam.Size = New System.Drawing.Size(80, 20)
        Me.dtp_fecha_dam.TabIndex = 270
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label48.ForeColor = System.Drawing.Color.Navy
        Me.Label48.Location = New System.Drawing.Point(614, 13)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(64, 13)
        Me.Label48.TabIndex = 271
        Me.Label48.Text = "Fecha DAM"
        '
        'txt_invoice2
        '
        Me.txt_invoice2.BackColor = System.Drawing.Color.White
        Me.txt_invoice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_invoice2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_invoice2.Location = New System.Drawing.Point(246, 26)
        Me.txt_invoice2.Name = "txt_invoice2"
        Me.txt_invoice2.Size = New System.Drawing.Size(117, 21)
        Me.txt_invoice2.TabIndex = 268
        Me.txt_invoice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(280, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "Invoice"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(763, 26)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(117, 21)
        Me.txtcodigo.TabIndex = 6
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcodigo.Visible = False
        '
        'lblcompra
        '
        Me.lblcompra.AutoSize = True
        Me.lblcompra.ForeColor = System.Drawing.Color.Navy
        Me.lblcompra.Location = New System.Drawing.Point(752, 13)
        Me.lblcompra.Name = "lblcompra"
        Me.lblcompra.Size = New System.Drawing.Size(138, 13)
        Me.lblcompra.TabIndex = 228
        Me.lblcompra.Text = "Nro documento Importación"
        Me.lblcompra.Visible = False
        '
        'txtproveedor
        '
        Me.txtproveedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor.Location = New System.Drawing.Point(105, 26)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.ReadOnly = True
        Me.txtproveedor.Size = New System.Drawing.Size(127, 20)
        Me.txtproveedor.TabIndex = 7
        '
        'dtp_fecha_invoice
        '
        Me.dtp_fecha_invoice.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_invoice.Location = New System.Drawing.Point(370, 26)
        Me.dtp_fecha_invoice.Name = "dtp_fecha_invoice"
        Me.dtp_fecha_invoice.Size = New System.Drawing.Size(80, 20)
        Me.dtp_fecha_invoice.TabIndex = 3
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(373, 13)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(75, 13)
        Me.Label49.TabIndex = 221
        Me.Label49.Text = "Fecha Invoice"
        '
        'txttipoCambio
        '
        Me.txttipoCambio.BackColor = System.Drawing.Color.White
        Me.txttipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipoCambio.Enabled = False
        Me.txttipoCambio.Location = New System.Drawing.Point(491, 80)
        Me.txttipoCambio.Name = "txttipoCambio"
        Me.txttipoCambio.ReadOnly = True
        Me.txttipoCambio.Size = New System.Drawing.Size(78, 20)
        Me.txttipoCambio.TabIndex = 13
        Me.txttipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(430, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "T/cambio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(7, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Moneda"
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(105, 80)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(175, 21)
        Me.cbomoneda.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(430, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 187
        Me.Label8.Text = "Ruc"
        '
        'txtproveedor_ruc
        '
        Me.txtproveedor_ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor_ruc.Enabled = False
        Me.txtproveedor_ruc.Location = New System.Drawing.Point(491, 54)
        Me.txtproveedor_ruc.Name = "txtproveedor_ruc"
        Me.txtproveedor_ruc.Size = New System.Drawing.Size(78, 20)
        Me.txtproveedor_ruc.TabIndex = 9
        Me.txtproveedor_ruc.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(7, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 185
        Me.Label6.Text = "Razon social"
        '
        'txtproveedor_razons
        '
        Me.txtproveedor_razons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor_razons.Enabled = False
        Me.txtproveedor_razons.Location = New System.Drawing.Point(105, 54)
        Me.txtproveedor_razons.Name = "txtproveedor_razons"
        Me.txtproveedor_razons.Size = New System.Drawing.Size(318, 20)
        Me.txtproveedor_razons.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(7, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Proveedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(6, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 13)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Comentarios / Observaciones"
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btn_agregar_gastos)
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.ForeColor = System.Drawing.Color.Navy
        Me.gbOpciones.Location = New System.Drawing.Point(912, 151)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(67, 363)
        Me.gbOpciones.TabIndex = 182
        Me.gbOpciones.TabStop = False
        '
        'btn_agregar_gastos
        '
        Me.btn_agregar_gastos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_agregar_gastos.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_agregar_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar_gastos.Image = CType(resources.GetObject("btn_agregar_gastos.Image"), System.Drawing.Image)
        Me.btn_agregar_gastos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_agregar_gastos.Location = New System.Drawing.Point(4, 68)
        Me.btn_agregar_gastos.Name = "btn_agregar_gastos"
        Me.btn_agregar_gastos.Size = New System.Drawing.Size(60, 63)
        Me.btn_agregar_gastos.TabIndex = 21
        Me.btn_agregar_gastos.Text = "&Agregar/Actualiza Gastos"
        Me.btn_agregar_gastos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_agregar_gastos.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(4, 187)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(60, 42)
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
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnquitar.Location = New System.Drawing.Point(4, 239)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(60, 42)
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
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(4, 139)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(60, 42)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.BackColor = System.Drawing.Color.White
        Me.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComentario.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtComentario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentario.Location = New System.Drawing.Point(161, 122)
        Me.txtComentario.MaxLength = 250
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtComentario.Size = New System.Drawing.Size(818, 23)
        Me.txtComentario.TabIndex = 20
        Me.txtComentario.Text = ""
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.dgvDetalle)
        Me.gbDetalles.Location = New System.Drawing.Point(6, 151)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(901, 363)
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
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(887, 347)
        Me.dgvDetalle.TabIndex = 0
        '
        'tc_detalle
        '
        Me.tc_detalle.BackColor = System.Drawing.Color.White
        Me.tc_detalle.Controls.Add(Me.GroupBox1)
        Me.tc_detalle.Location = New System.Drawing.Point(4, 22)
        Me.tc_detalle.Name = "tc_detalle"
        Me.tc_detalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_detalle.Size = New System.Drawing.Size(990, 524)
        Me.tc_detalle.TabIndex = 1
        Me.tc_detalle.Text = "Detalles del Registro de Importación"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(955, 511)
        Me.GroupBox1.TabIndex = 216
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txt_percepcion2)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txt_sobretasa_sancion)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txt_sobretasa_tributo)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.txt_seguro2)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.txt_derechos_antidumping)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.txt_derechos_especificos)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txt_ipm)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.txt_igv)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.txt_isc)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.TextBox19)
        Me.GroupBox4.Controls.Add(Me.txt_ad_valorem2)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(15, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(922, 166)
        Me.GroupBox4.TabIndex = 210
        Me.GroupBox4.TabStop = False
        '
        'txt_percepcion2
        '
        Me.txt_percepcion2.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_percepcion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_percepcion2.Location = New System.Drawing.Point(452, 132)
        Me.txt_percepcion2.Name = "txt_percepcion2"
        Me.txt_percepcion2.Size = New System.Drawing.Size(88, 20)
        Me.txt_percepcion2.TabIndex = 186
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(331, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 187
        Me.Label19.Text = "Percepción2"
        '
        'txt_sobretasa_sancion
        '
        Me.txt_sobretasa_sancion.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sobretasa_sancion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sobretasa_sancion.Location = New System.Drawing.Point(452, 106)
        Me.txt_sobretasa_sancion.Name = "txt_sobretasa_sancion"
        Me.txt_sobretasa_sancion.Size = New System.Drawing.Size(88, 20)
        Me.txt_sobretasa_sancion.TabIndex = 184
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(331, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 13)
        Me.Label20.TabIndex = 185
        Me.Label20.Text = "Sobretasa Sanción"
        '
        'txt_sobretasa_tributo
        '
        Me.txt_sobretasa_tributo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sobretasa_tributo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sobretasa_tributo.Location = New System.Drawing.Point(452, 81)
        Me.txt_sobretasa_tributo.Name = "txt_sobretasa_tributo"
        Me.txt_sobretasa_tributo.Size = New System.Drawing.Size(88, 20)
        Me.txt_sobretasa_tributo.TabIndex = 182
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(331, 85)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(91, 13)
        Me.Label32.TabIndex = 183
        Me.Label32.Text = "Sobretasa Tributo"
        '
        'txt_seguro2
        '
        Me.txt_seguro2.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_seguro2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_seguro2.Location = New System.Drawing.Point(452, 56)
        Me.txt_seguro2.Name = "txt_seguro2"
        Me.txt_seguro2.Size = New System.Drawing.Size(88, 20)
        Me.txt_seguro2.TabIndex = 180
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(331, 60)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 13)
        Me.Label33.TabIndex = 181
        Me.Label33.Text = "Seguro2"
        '
        'txt_derechos_antidumping
        '
        Me.txt_derechos_antidumping.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_derechos_antidumping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_derechos_antidumping.Location = New System.Drawing.Point(452, 32)
        Me.txt_derechos_antidumping.Name = "txt_derechos_antidumping"
        Me.txt_derechos_antidumping.Size = New System.Drawing.Size(88, 20)
        Me.txt_derechos_antidumping.TabIndex = 178
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(331, 36)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(114, 13)
        Me.Label34.TabIndex = 179
        Me.Label34.Text = "Derechos Antidumping"
        '
        'txt_derechos_especificos
        '
        Me.txt_derechos_especificos.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_derechos_especificos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_derechos_especificos.Location = New System.Drawing.Point(139, 132)
        Me.txt_derechos_especificos.Name = "txt_derechos_especificos"
        Me.txt_derechos_especificos.Size = New System.Drawing.Size(90, 20)
        Me.txt_derechos_especificos.TabIndex = 176
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(19, 136)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(110, 13)
        Me.Label21.TabIndex = 177
        Me.Label21.Text = "Derechos Especificos"
        '
        'txt_ipm
        '
        Me.txt_ipm.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_ipm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ipm.Location = New System.Drawing.Point(139, 106)
        Me.txt_ipm.Name = "txt_ipm"
        Me.txt_ipm.Size = New System.Drawing.Size(90, 20)
        Me.txt_ipm.TabIndex = 174
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(19, 110)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(35, 13)
        Me.Label27.TabIndex = 175
        Me.Label27.Text = "I.P.M."
        '
        'txt_igv
        '
        Me.txt_igv.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_igv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_igv.Location = New System.Drawing.Point(139, 81)
        Me.txt_igv.Name = "txt_igv"
        Me.txt_igv.Size = New System.Drawing.Size(90, 20)
        Me.txt_igv.TabIndex = 172
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(19, 85)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 173
        Me.Label29.Text = "I.G.V."
        '
        'txt_isc
        '
        Me.txt_isc.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_isc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_isc.Location = New System.Drawing.Point(139, 56)
        Me.txt_isc.Name = "txt_isc"
        Me.txt_isc.Size = New System.Drawing.Size(90, 20)
        Me.txt_isc.TabIndex = 170
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(19, 60)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 13)
        Me.Label30.TabIndex = 171
        Me.Label30.Text = "I.S.C."
        '
        'TextBox19
        '
        Me.TextBox19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox19.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox19.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox19.ForeColor = System.Drawing.Color.White
        Me.TextBox19.Location = New System.Drawing.Point(0, 4)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(922, 20)
        Me.TextBox19.TabIndex = 169
        Me.TextBox19.Text = "TRATAMIENTO ARANCELARIO POR SUBPARTIDA NACIONAL"
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ad_valorem2
        '
        Me.txt_ad_valorem2.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_ad_valorem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ad_valorem2.Location = New System.Drawing.Point(139, 32)
        Me.txt_ad_valorem2.Name = "txt_ad_valorem2"
        Me.txt_ad_valorem2.Size = New System.Drawing.Size(90, 20)
        Me.txt_ad_valorem2.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(19, 36)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(69, 13)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "AD-Valorem2"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.txt_precio_total)
        Me.GroupBox6.Controls.Add(Me.Label35)
        Me.GroupBox6.Controls.Add(Me.txt_precio_unitario)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.txt_cantidad)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.txt_sub_partida_dam)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.PictureBox9)
        Me.GroupBox6.Controls.Add(Me.txtunidadMedida)
        Me.GroupBox6.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox6.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox6.Controls.Add(Me.Label46)
        Me.GroupBox6.Controls.Add(Me.Label47)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(922, 101)
        Me.GroupBox6.TabIndex = 198
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Detalles del Articulo"
        '
        'txt_precio_total
        '
        Me.txt_precio_total.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_precio_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_precio_total.Enabled = False
        Me.txt_precio_total.Location = New System.Drawing.Point(529, 75)
        Me.txt_precio_total.Name = "txt_precio_total"
        Me.txt_precio_total.ReadOnly = True
        Me.txt_precio_total.Size = New System.Drawing.Size(93, 20)
        Me.txt_precio_total.TabIndex = 119
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(455, 79)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(64, 13)
        Me.Label35.TabIndex = 120
        Me.Label35.Text = "Precio Total"
        '
        'txt_precio_unitario
        '
        Me.txt_precio_unitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_precio_unitario.Location = New System.Drawing.Point(330, 75)
        Me.txt_precio_unitario.Name = "txt_precio_unitario"
        Me.txt_precio_unitario.Size = New System.Drawing.Size(93, 20)
        Me.txt_precio_unitario.TabIndex = 116
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(251, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Precio Unitario"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BackColor = System.Drawing.Color.White
        Me.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad.Location = New System.Drawing.Point(72, 75)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(87, 20)
        Me.txt_cantidad.TabIndex = 115
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(18, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Cantidad"
        '
        'txt_sub_partida_dam
        '
        Me.txt_sub_partida_dam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sub_partida_dam.Location = New System.Drawing.Point(330, 46)
        Me.txt_sub_partida_dam.Name = "txt_sub_partida_dam"
        Me.txt_sub_partida_dam.ReadOnly = True
        Me.txt_sub_partida_dam.Size = New System.Drawing.Size(93, 20)
        Me.txt_sub_partida_dam.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(193, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Sub Partida Nacional DAM"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(167, 18)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox9.TabIndex = 112
        Me.PictureBox9.TabStop = False
        '
        'txtunidadMedida
        '
        Me.txtunidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedida.Location = New System.Drawing.Point(72, 46)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.ReadOnly = True
        Me.txtunidadMedida.Size = New System.Drawing.Size(87, 20)
        Me.txtunidadMedida.TabIndex = 2
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(193, 17)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(641, 20)
        Me.txtdescripcionArticulo.TabIndex = 1
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(72, 17)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.ReadOnly = True
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(86, 21)
        Me.txtcodigoArticulo.TabIndex = 0
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(25, 21)
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
        Me.Label47.Location = New System.Drawing.Point(11, 49)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(56, 13)
        Me.Label47.TabIndex = 5
        Me.Label47.Text = "Unid. Med"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.Location = New System.Drawing.Point(482, 426)
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
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Navy
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(407, 426)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(69, 38)
        Me.btnAceptar.TabIndex = 208
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txt_percepcion)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txt_ipm_)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txt_igv_)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txt_ad_valorem)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txt_seguro)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txt_flete)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.TextBox6)
        Me.GroupBox5.Controls.Add(Me.txt_valor_ref_flete)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(15, 295)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(922, 79)
        Me.GroupBox5.TabIndex = 199
        Me.GroupBox5.TabStop = False
        '
        'txt_percepcion
        '
        Me.txt_percepcion.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_percepcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_percepcion.Location = New System.Drawing.Point(572, 45)
        Me.txt_percepcion.Name = "txt_percepcion"
        Me.txt_percepcion.Size = New System.Drawing.Size(88, 20)
        Me.txt_percepcion.TabIndex = 180
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(586, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 181
        Me.Label18.Text = "Percepción"
        '
        'txt_ipm_
        '
        Me.txt_ipm_.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_ipm_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ipm_.Location = New System.Drawing.Point(478, 45)
        Me.txt_ipm_.Name = "txt_ipm_"
        Me.txt_ipm_.Size = New System.Drawing.Size(88, 20)
        Me.txt_ipm_.TabIndex = 178
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(505, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 179
        Me.Label17.Text = "I.P.M."
        '
        'txt_igv_
        '
        Me.txt_igv_.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_igv_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_igv_.Location = New System.Drawing.Point(384, 45)
        Me.txt_igv_.Name = "txt_igv_"
        Me.txt_igv_.Size = New System.Drawing.Size(88, 20)
        Me.txt_igv_.TabIndex = 176
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(411, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 177
        Me.Label16.Text = "I.G.V."
        '
        'txt_ad_valorem
        '
        Me.txt_ad_valorem.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_ad_valorem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ad_valorem.Location = New System.Drawing.Point(290, 45)
        Me.txt_ad_valorem.Name = "txt_ad_valorem"
        Me.txt_ad_valorem.Size = New System.Drawing.Size(88, 20)
        Me.txt_ad_valorem.TabIndex = 174
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(303, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 175
        Me.Label15.Text = "AD-Valorem"
        '
        'txt_seguro
        '
        Me.txt_seguro.BackColor = System.Drawing.Color.White
        Me.txt_seguro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_seguro.Location = New System.Drawing.Point(196, 45)
        Me.txt_seguro.Name = "txt_seguro"
        Me.txt_seguro.Size = New System.Drawing.Size(88, 20)
        Me.txt_seguro.TabIndex = 172
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(220, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Seguro"
        '
        'txt_flete
        '
        Me.txt_flete.BackColor = System.Drawing.Color.White
        Me.txt_flete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_flete.Location = New System.Drawing.Point(102, 45)
        Me.txt_flete.Name = "txt_flete"
        Me.txt_flete.Size = New System.Drawing.Size(88, 20)
        Me.txt_flete.TabIndex = 170
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(131, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Flete"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(0, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(922, 20)
        Me.TextBox6.TabIndex = 169
        Me.TextBox6.Text = "DATOS DAM"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_valor_ref_flete
        '
        Me.txt_valor_ref_flete.BackColor = System.Drawing.Color.White
        Me.txt_valor_ref_flete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_valor_ref_flete.Location = New System.Drawing.Point(8, 45)
        Me.txt_valor_ref_flete.Name = "txt_valor_ref_flete"
        Me.txt_valor_ref_flete.Size = New System.Drawing.Size(88, 20)
        Me.txt_valor_ref_flete.TabIndex = 4
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label44.ForeColor = System.Drawing.Color.Navy
        Me.Label44.Location = New System.Drawing.Point(12, 29)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(80, 13)
        Me.Label44.TabIndex = 5
        Me.Label44.Text = "Valor Ref. Flete"
        '
        'tc_detalle2
        '
        Me.tc_detalle2.Controls.Add(Me.btn_cancel2)
        Me.tc_detalle2.Controls.Add(Me.btnAceptar2)
        Me.tc_detalle2.Controls.Add(Me.GroupBox7)
        Me.tc_detalle2.Location = New System.Drawing.Point(4, 22)
        Me.tc_detalle2.Name = "tc_detalle2"
        Me.tc_detalle2.Size = New System.Drawing.Size(990, 524)
        Me.tc_detalle2.TabIndex = 2
        Me.tc_detalle2.Text = "Detalles de los Gastos Varios"
        Me.tc_detalle2.UseVisualStyleBackColor = True
        '
        'btn_cancel2
        '
        Me.btn_cancel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_cancel2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel2.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancel2.Image = CType(resources.GetObject("btn_cancel2.Image"), System.Drawing.Image)
        Me.btn_cancel2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel2.Location = New System.Drawing.Point(498, 243)
        Me.btn_cancel2.Name = "btn_cancel2"
        Me.btn_cancel2.Size = New System.Drawing.Size(69, 38)
        Me.btn_cancel2.TabIndex = 213
        Me.btn_cancel2.Text = "&Retornar"
        Me.btn_cancel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel2.UseVisualStyleBackColor = True
        '
        'btnAceptar2
        '
        Me.btnAceptar2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAceptar2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAceptar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar2.ForeColor = System.Drawing.Color.Navy
        Me.btnAceptar2.Image = CType(resources.GetObject("btnAceptar2.Image"), System.Drawing.Image)
        Me.btnAceptar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar2.Location = New System.Drawing.Point(423, 243)
        Me.btnAceptar2.Name = "btnAceptar2"
        Me.btnAceptar2.Size = New System.Drawing.Size(69, 38)
        Me.btnAceptar2.TabIndex = 212
        Me.btnAceptar2.Text = "&Aceptar"
        Me.btnAceptar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.txt_15)
        Me.GroupBox7.Controls.Add(Me.Label51)
        Me.GroupBox7.Controls.Add(Me.txt_14)
        Me.GroupBox7.Controls.Add(Me.Label52)
        Me.GroupBox7.Controls.Add(Me.txt_13)
        Me.GroupBox7.Controls.Add(Me.Label53)
        Me.GroupBox7.Controls.Add(Me.txt_12)
        Me.GroupBox7.Controls.Add(Me.Label54)
        Me.GroupBox7.Controls.Add(Me.txt_11)
        Me.GroupBox7.Controls.Add(Me.Label55)
        Me.GroupBox7.Controls.Add(Me.txt_10)
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Controls.Add(Me.txt_9)
        Me.GroupBox7.Controls.Add(Me.Label37)
        Me.GroupBox7.Controls.Add(Me.txt_8)
        Me.GroupBox7.Controls.Add(Me.Label38)
        Me.GroupBox7.Controls.Add(Me.txt_7)
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.txt_6)
        Me.GroupBox7.Controls.Add(Me.Label40)
        Me.GroupBox7.Controls.Add(Me.txt_5)
        Me.GroupBox7.Controls.Add(Me.Label41)
        Me.GroupBox7.Controls.Add(Me.txt_4)
        Me.GroupBox7.Controls.Add(Me.Label42)
        Me.GroupBox7.Controls.Add(Me.txt_3)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Controls.Add(Me.txt_2)
        Me.GroupBox7.Controls.Add(Me.Label45)
        Me.GroupBox7.Controls.Add(Me.TextBox11)
        Me.GroupBox7.Controls.Add(Me.txt_1)
        Me.GroupBox7.Controls.Add(Me.Label50)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(32, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(922, 166)
        Me.GroupBox7.TabIndex = 211
        Me.GroupBox7.TabStop = False
        '
        'txt_15
        '
        Me.txt_15.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_15.Location = New System.Drawing.Point(787, 132)
        Me.txt_15.Name = "txt_15"
        Me.txt_15.Size = New System.Drawing.Size(88, 20)
        Me.txt_15.TabIndex = 196
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label51.ForeColor = System.Drawing.Color.Navy
        Me.Label51.Location = New System.Drawing.Point(666, 136)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(103, 13)
        Me.Label51.TabIndex = 197
        Me.Label51.Text = "Transporte Terrestre"
        '
        'txt_14
        '
        Me.txt_14.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_14.Location = New System.Drawing.Point(787, 106)
        Me.txt_14.Name = "txt_14"
        Me.txt_14.Size = New System.Drawing.Size(88, 20)
        Me.txt_14.TabIndex = 194
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(666, 110)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(72, 13)
        Me.Label52.TabIndex = 195
        Me.Label52.Text = "Flete Maritimo"
        '
        'txt_13
        '
        Me.txt_13.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_13.Location = New System.Drawing.Point(787, 81)
        Me.txt_13.Name = "txt_13"
        Me.txt_13.Size = New System.Drawing.Size(88, 20)
        Me.txt_13.TabIndex = 192
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(666, 85)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(95, 13)
        Me.Label53.TabIndex = 193
        Me.Label53.Text = "Rectificación Mani"
        '
        'txt_12
        '
        Me.txt_12.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_12.Location = New System.Drawing.Point(787, 56)
        Me.txt_12.Name = "txt_12"
        Me.txt_12.Size = New System.Drawing.Size(88, 20)
        Me.txt_12.TabIndex = 190
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(666, 60)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(120, 13)
        Me.Label54.TabIndex = 191
        Me.Label54.Text = "Reparación Contenedor"
        '
        'txt_11
        '
        Me.txt_11.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_11.Location = New System.Drawing.Point(787, 32)
        Me.txt_11.Name = "txt_11"
        Me.txt_11.Size = New System.Drawing.Size(88, 20)
        Me.txt_11.TabIndex = 188
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label55.ForeColor = System.Drawing.Color.Navy
        Me.Label55.Location = New System.Drawing.Point(666, 36)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(91, 13)
        Me.Label55.TabIndex = 189
        Me.Label55.Text = "Desconsolidación"
        '
        'txt_10
        '
        Me.txt_10.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_10.Location = New System.Drawing.Point(463, 132)
        Me.txt_10.Name = "txt_10"
        Me.txt_10.Size = New System.Drawing.Size(88, 20)
        Me.txt_10.TabIndex = 186
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(342, 136)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(119, 13)
        Me.Label36.TabIndex = 187
        Me.Label36.Text = "Devolución Contenedor"
        '
        'txt_9
        '
        Me.txt_9.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_9.Location = New System.Drawing.Point(463, 106)
        Me.txt_9.Name = "txt_9"
        Me.txt_9.Size = New System.Drawing.Size(88, 20)
        Me.txt_9.TabIndex = 184
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label37.ForeColor = System.Drawing.Color.Navy
        Me.Label37.Location = New System.Drawing.Point(342, 110)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(74, 13)
        Me.Label37.TabIndex = 185
        Me.Label37.Text = "Vistos Buenos"
        '
        'txt_8
        '
        Me.txt_8.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_8.Location = New System.Drawing.Point(463, 81)
        Me.txt_8.Name = "txt_8"
        Me.txt_8.Size = New System.Drawing.Size(88, 20)
        Me.txt_8.TabIndex = 182
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(342, 85)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(48, 13)
        Me.Label38.TabIndex = 183
        Me.Label38.Text = "Almacen"
        '
        'txt_7
        '
        Me.txt_7.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_7.Location = New System.Drawing.Point(463, 56)
        Me.txt_7.Name = "txt_7"
        Me.txt_7.Size = New System.Drawing.Size(88, 20)
        Me.txt_7.TabIndex = 180
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(342, 60)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(47, 13)
        Me.Label39.TabIndex = 181
        Me.Label39.Text = "Seguro3"
        '
        'txt_6
        '
        Me.txt_6.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_6.Location = New System.Drawing.Point(463, 32)
        Me.txt_6.Name = "txt_6"
        Me.txt_6.Size = New System.Drawing.Size(88, 20)
        Me.txt_6.TabIndex = 178
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(342, 36)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(99, 13)
        Me.Label40.TabIndex = 179
        Me.Label40.Text = "Gastos Op. Destino"
        '
        'txt_5
        '
        Me.txt_5.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_5.Location = New System.Drawing.Point(139, 132)
        Me.txt_5.Name = "txt_5"
        Me.txt_5.Size = New System.Drawing.Size(90, 20)
        Me.txt_5.TabIndex = 176
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(19, 136)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(114, 13)
        Me.Label41.TabIndex = 177
        Me.Label41.Text = "Transmisión Manifiesto"
        '
        'txt_4
        '
        Me.txt_4.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_4.Location = New System.Drawing.Point(139, 106)
        Me.txt_4.Name = "txt_4"
        Me.txt_4.Size = New System.Drawing.Size(90, 20)
        Me.txt_4.TabIndex = 174
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(19, 110)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(88, 13)
        Me.Label42.TabIndex = 175
        Me.Label42.Text = "Handling Destino"
        '
        'txt_3
        '
        Me.txt_3.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_3.Location = New System.Drawing.Point(139, 81)
        Me.txt_3.Name = "txt_3"
        Me.txt_3.Size = New System.Drawing.Size(90, 20)
        Me.txt_3.TabIndex = 172
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(19, 85)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(113, 13)
        Me.Label43.TabIndex = 173
        Me.Label43.Text = "Gastos Administrativos"
        '
        'txt_2
        '
        Me.txt_2.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_2.Location = New System.Drawing.Point(139, 56)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(90, 20)
        Me.txt_2.TabIndex = 170
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(19, 60)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(94, 13)
        Me.Label45.TabIndex = 171
        Me.Label45.Text = "Gastos Operativos"
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox11.BackColor = System.Drawing.Color.Navy
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox11.ForeColor = System.Drawing.Color.White
        Me.TextBox11.Location = New System.Drawing.Point(0, 4)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(922, 20)
        Me.TextBox11.TabIndex = 169
        Me.TextBox11.Text = "DATOS SEGÚN LIQUIDACION AGENCIA DE ADUANAS"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_1
        '
        Me.txt_1.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_1.Location = New System.Drawing.Point(139, 32)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(90, 20)
        Me.txt_1.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label50.ForeColor = System.Drawing.Color.Navy
        Me.Label50.Location = New System.Drawing.Point(19, 36)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(115, 13)
        Me.Label50.TabIndex = 5
        Me.Label50.Text = "Comi. Agen. Aduanas2"
        '
        'Frm_Compras_Importacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1023, 602)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.Tc_principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Compras_Importacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras de Importación"
        Me.btn_menu.ResumeLayout(False)
        Me.btn_menu.PerformLayout()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tc_principal.ResumeLayout(False)
        Me.tc_datos.ResumeLayout(False)
        Me.tc_datos.PerformLayout()
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbDetalles.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_detalle.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tc_detalle2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Imprimir_Orden_Pago As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents Tc_principal As System.Windows.Forms.TabControl
    Friend WithEvents tc_datos As System.Windows.Forms.TabPage
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblcompra As System.Windows.Forms.Label
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha_invoice As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txttipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor_ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor_razons As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtComentario As System.Windows.Forms.RichTextBox
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents tc_detalle As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents txtunidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_valor_ref_flete As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txt_invoice2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_dam As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_dam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txt_sub_partida_dam As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_percepcion As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_ipm_ As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_igv_ As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_ad_valorem As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_seguro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_flete As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_derechos_especificos As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_ipm As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_igv As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txt_isc As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ad_valorem2 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txt_percepcion2 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_sobretasa_sancion As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_sobretasa_tributo As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_seguro2 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txt_derechos_antidumping As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_total As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents tc_detalle2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_15 As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_14 As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txt_13 As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txt_12 As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txt_11 As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txt_10 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txt_9 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txt_8 As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txt_7 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txt_6 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txt_5 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txt_4 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txt_3 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txt_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel2 As System.Windows.Forms.Button
    Friend WithEvents btnAceptar2 As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_gastos As System.Windows.Forms.Button
End Class
