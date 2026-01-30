<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Requerimiento_OP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Requerimiento_OP))
        Me.pnlprincipal = New System.Windows.Forms.Panel()
        Me.lblDetalle = New System.Windows.Forms.TextBox()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgvCabeceraAlmacen = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Anular = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbCabceraDocumento = New System.Windows.Forms.GroupBox()
        Me.gb_insumos = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_cantidad_insumo = New System.Windows.Forms.TextBox()
        Me.txt_unidad_insumo = New System.Windows.Forms.TextBox()
        Me.txt_des_insumo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_insumo = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvDetalle_insumos = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DerivaciónDePlaneamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarDerivPlaneamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_urgente = New System.Windows.Forms.CheckBox()
        Me.cbo_destinatario = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_des_vendedor = New System.Windows.Forms.TextBox()
        Me.txt_cod_vendedor = New System.Windows.Forms.TextBox()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.dtp_fecha_entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GbTransaccion = New System.Windows.Forms.GroupBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_producto_producir = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_factor = New System.Windows.Forms.TextBox()
        Me.btn_agregar_insumo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_total_prod_producir = New System.Windows.Forms.TextBox()
        Me.txt_costo_prod_producir = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_prod_producir = New System.Windows.Forms.TextBox()
        Me.txt_unidad_prod_producir = New System.Windows.Forms.TextBox()
        Me.txt_des_prod_producir = New System.Windows.Forms.TextBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_producto_producir = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.pnlprincipal.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbCabceraDocumento.SuspendLayout()
        Me.gb_insumos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle_insumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GbTransaccion.SuspendLayout()
        Me.gb_producto_producir.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlprincipal
        '
        Me.pnlprincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlprincipal.Controls.Add(Me.lblDetalle)
        Me.pnlprincipal.Controls.Add(Me.gbRangofechas)
        Me.pnlprincipal.Controls.Add(Me.lblCantidad)
        Me.pnlprincipal.Controls.Add(Me.dgvCabeceraAlmacen)
        Me.pnlprincipal.Controls.Add(Me.GroupBox6)
        Me.pnlprincipal.Controls.Add(Me.GroupBox7)
        Me.pnlprincipal.Location = New System.Drawing.Point(9, 37)
        Me.pnlprincipal.Name = "pnlprincipal"
        Me.pnlprincipal.Size = New System.Drawing.Size(896, 580)
        Me.pnlprincipal.TabIndex = 115
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
        Me.lblDetalle.Size = New System.Drawing.Size(896, 20)
        Me.lblDetalle.TabIndex = 200
        Me.lblDetalle.Text = "REQUERIMIENTOS DE ORDEN DE PRODUCCION"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbRangofechas
        '
        Me.gbRangofechas.BackColor = System.Drawing.Color.White
        Me.gbRangofechas.Controls.Add(Me.Label6)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label15)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(578, 65)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(276, 48)
        Me.gbRangofechas.TabIndex = 105
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        Me.gbRangofechas.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(179, 16)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(93, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(45, 16)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(93, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(6, 555)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 103
        Me.lblCantidad.Text = "."
        '
        'dgvCabeceraAlmacen
        '
        Me.dgvCabeceraAlmacen.AllowUserToAddRows = False
        Me.dgvCabeceraAlmacen.AllowUserToDeleteRows = False
        Me.dgvCabeceraAlmacen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabeceraAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabeceraAlmacen.Location = New System.Drawing.Point(3, 119)
        Me.dgvCabeceraAlmacen.Name = "dgvCabeceraAlmacen"
        Me.dgvCabeceraAlmacen.ReadOnly = True
        Me.dgvCabeceraAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabeceraAlmacen.Size = New System.Drawing.Size(882, 432)
        Me.dgvCabeceraAlmacen.TabIndex = 104
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(418, 65)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(157, 48)
        Me.GroupBox6.TabIndex = 104
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(8, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(142, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.txtFiltro)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(3, 65)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(409, 48)
        Me.GroupBox7.TabIndex = 103
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(396, 22)
        Me.txtFiltro.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.Tool_Anular, Me.btnEliminar, Me.btnGrabar, Me.btnImprimir, Me.btnCancelar, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(909, 25)
        Me.ToolStrip1.TabIndex = 114
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.ForeColor = System.Drawing.Color.Navy
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnConsultar
        '
        Me.btnConsultar.ForeColor = System.Drawing.Color.Navy
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 22)
        Me.btnConsultar.Text = "&Consultar"
        '
        'Tool_Anular
        '
        Me.Tool_Anular.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Anular.Image = CType(resources.GetObject("Tool_Anular.Image"), System.Drawing.Image)
        Me.Tool_Anular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Anular.Name = "Tool_Anular"
        Me.Tool_Anular.Size = New System.Drawing.Size(64, 22)
        Me.Tool_Anular.Text = "Anular"
        Me.Tool_Anular.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 22)
        Me.btnEliminar.Text = "&Anular"
        '
        'btnGrabar
        '
        Me.btnGrabar.ForeColor = System.Drawing.Color.Navy
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(66, 22)
        Me.btnGrabar.Text = "&Grabar"
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.Color.Navy
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(77, 22)
        Me.btnImprimir.Text = "&Imprimir"
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Navy
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnSalir
        '
        Me.btnSalir.ForeColor = System.Drawing.Color.Navy
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 22)
        Me.btnSalir.Text = "&Salir"
        '
        'gbCabceraDocumento
        '
        Me.gbCabceraDocumento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCabceraDocumento.Controls.Add(Me.gb_insumos)
        Me.gbCabceraDocumento.Controls.Add(Me.GroupBox1)
        Me.gbCabceraDocumento.Controls.Add(Me.GbTransaccion)
        Me.gbCabceraDocumento.Controls.Add(Me.gb_producto_producir)
        Me.gbCabceraDocumento.Location = New System.Drawing.Point(18, 33)
        Me.gbCabceraDocumento.Name = "gbCabceraDocumento"
        Me.gbCabceraDocumento.Size = New System.Drawing.Size(887, 569)
        Me.gbCabceraDocumento.TabIndex = 113
        Me.gbCabceraDocumento.TabStop = False
        '
        'gb_insumos
        '
        Me.gb_insumos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_insumos.Controls.Add(Me.Label11)
        Me.gb_insumos.Controls.Add(Me.txt_cantidad_insumo)
        Me.gb_insumos.Controls.Add(Me.txt_unidad_insumo)
        Me.gb_insumos.Controls.Add(Me.txt_des_insumo)
        Me.gb_insumos.Controls.Add(Me.PictureBox1)
        Me.gb_insumos.Controls.Add(Me.txt_cod_insumo)
        Me.gb_insumos.Controls.Add(Me.btn_add)
        Me.gb_insumos.Controls.Add(Me.btn_del)
        Me.gb_insumos.Controls.Add(Me.Label10)
        Me.gb_insumos.Controls.Add(Me.dgvDetalle_insumos)
        Me.gb_insumos.Location = New System.Drawing.Point(6, 212)
        Me.gb_insumos.Name = "gb_insumos"
        Me.gb_insumos.Size = New System.Drawing.Size(868, 346)
        Me.gb_insumos.TabIndex = 41
        Me.gb_insumos.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(508, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 225
        Me.Label11.Text = "Cantidad"
        '
        'txt_cantidad_insumo
        '
        Me.txt_cantidad_insumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad_insumo.Location = New System.Drawing.Point(573, 33)
        Me.txt_cantidad_insumo.Name = "txt_cantidad_insumo"
        Me.txt_cantidad_insumo.Size = New System.Drawing.Size(91, 20)
        Me.txt_cantidad_insumo.TabIndex = 223
        '
        'txt_unidad_insumo
        '
        Me.txt_unidad_insumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_unidad_insumo.Location = New System.Drawing.Point(425, 33)
        Me.txt_unidad_insumo.Name = "txt_unidad_insumo"
        Me.txt_unidad_insumo.ReadOnly = True
        Me.txt_unidad_insumo.Size = New System.Drawing.Size(69, 20)
        Me.txt_unidad_insumo.TabIndex = 222
        '
        'txt_des_insumo
        '
        Me.txt_des_insumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_insumo.ForeColor = System.Drawing.Color.Black
        Me.txt_des_insumo.Location = New System.Drawing.Point(105, 33)
        Me.txt_des_insumo.Name = "txt_des_insumo"
        Me.txt_des_insumo.ReadOnly = True
        Me.txt_des_insumo.Size = New System.Drawing.Size(312, 20)
        Me.txt_des_insumo.TabIndex = 221
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(80, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 220
        Me.PictureBox1.TabStop = False
        '
        'txt_cod_insumo
        '
        Me.txt_cod_insumo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_insumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_insumo.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_insumo.Location = New System.Drawing.Point(7, 33)
        Me.txt_cod_insumo.Name = "txt_cod_insumo"
        Me.txt_cod_insumo.ReadOnly = True
        Me.txt_cod_insumo.Size = New System.Drawing.Size(67, 20)
        Me.txt_cod_insumo.TabIndex = 219
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_add.ForeColor = System.Drawing.Color.Navy
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(678, 31)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(68, 23)
        Me.btn_add.TabIndex = 218
        Me.btn_add.Text = "Agregar"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_del.ForeColor = System.Drawing.Color.Navy
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(750, 31)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(68, 23)
        Me.btn_del.TabIndex = 217
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Navy
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(-4, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(873, 19)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "   Productos"
        '
        'dgvDetalle_insumos
        '
        Me.dgvDetalle_insumos.AllowUserToAddRows = False
        Me.dgvDetalle_insumos.AllowUserToDeleteRows = False
        Me.dgvDetalle_insumos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle_insumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle_insumos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvDetalle_insumos.Location = New System.Drawing.Point(8, 60)
        Me.dgvDetalle_insumos.Name = "dgvDetalle_insumos"
        Me.dgvDetalle_insumos.ReadOnly = True
        Me.dgvDetalle_insumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle_insumos.Size = New System.Drawing.Size(851, 275)
        Me.dgvDetalle_insumos.TabIndex = 13
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DerivaciónDePlaneamientoToolStripMenuItem, Me.RegistrarDerivPlaneamientoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(230, 48)
        '
        'DerivaciónDePlaneamientoToolStripMenuItem
        '
        Me.DerivaciónDePlaneamientoToolStripMenuItem.Image = CType(resources.GetObject("DerivaciónDePlaneamientoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DerivaciónDePlaneamientoToolStripMenuItem.Name = "DerivaciónDePlaneamientoToolStripMenuItem"
        Me.DerivaciónDePlaneamientoToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.DerivaciónDePlaneamientoToolStripMenuItem.Text = "Derivación de Planeamiento"
        '
        'RegistrarDerivPlaneamientoToolStripMenuItem
        '
        Me.RegistrarDerivPlaneamientoToolStripMenuItem.Image = CType(resources.GetObject("RegistrarDerivPlaneamientoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrarDerivPlaneamientoToolStripMenuItem.Name = "RegistrarDerivPlaneamientoToolStripMenuItem"
        Me.RegistrarDerivPlaneamientoToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RegistrarDerivPlaneamientoToolStripMenuItem.Text = "Registrar Deriv. Planeamiento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_urgente)
        Me.GroupBox1.Controls.Add(Me.cbo_destinatario)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_des_vendedor)
        Me.GroupBox1.Controls.Add(Me.txt_cod_vendedor)
        Me.GroupBox1.Controls.Add(Me.Label134)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_entrega)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.txtComentarios)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(866, 141)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'chk_urgente
        '
        Me.chk_urgente.AutoSize = True
        Me.chk_urgente.Font = New System.Drawing.Font("Book Antiqua", 9.0!)
        Me.chk_urgente.ForeColor = System.Drawing.Color.Navy
        Me.chk_urgente.Location = New System.Drawing.Point(654, 71)
        Me.chk_urgente.Name = "chk_urgente"
        Me.chk_urgente.Size = New System.Drawing.Size(71, 20)
        Me.chk_urgente.TabIndex = 266
        Me.chk_urgente.Text = "Urgente"
        Me.chk_urgente.UseVisualStyleBackColor = True
        '
        'cbo_destinatario
        '
        Me.cbo_destinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_destinatario.FormattingEnabled = True
        Me.cbo_destinatario.Items.AddRange(New Object() {"Para producción", "Para compra local"})
        Me.cbo_destinatario.Location = New System.Drawing.Point(654, 44)
        Me.cbo_destinatario.Name = "cbo_destinatario"
        Me.cbo_destinatario.Size = New System.Drawing.Size(177, 21)
        Me.cbo_destinatario.TabIndex = 265
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(573, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 16)
        Me.Label16.TabIndex = 264
        Me.Label16.Text = "Destinatario"
        '
        'txt_des_vendedor
        '
        Me.txt_des_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_vendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_des_vendedor.ForeColor = System.Drawing.Color.Green
        Me.txt_des_vendedor.Location = New System.Drawing.Point(360, 44)
        Me.txt_des_vendedor.MaxLength = 200
        Me.txt_des_vendedor.Name = "txt_des_vendedor"
        Me.txt_des_vendedor.ReadOnly = True
        Me.txt_des_vendedor.Size = New System.Drawing.Size(203, 21)
        Me.txt_des_vendedor.TabIndex = 263
        '
        'txt_cod_vendedor
        '
        Me.txt_cod_vendedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_vendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cod_vendedor.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txt_cod_vendedor.Location = New System.Drawing.Point(314, 44)
        Me.txt_cod_vendedor.MaxLength = 11
        Me.txt_cod_vendedor.Name = "txt_cod_vendedor"
        Me.txt_cod_vendedor.ReadOnly = True
        Me.txt_cod_vendedor.Size = New System.Drawing.Size(41, 21)
        Me.txt_cod_vendedor.TabIndex = 261
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Font = New System.Drawing.Font("Book Antiqua", 9.0!)
        Me.Label134.ForeColor = System.Drawing.Color.Navy
        Me.Label134.Location = New System.Drawing.Point(243, 46)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(62, 16)
        Me.Label134.TabIndex = 262
        Me.Label134.Text = "Vendedor"
        '
        'dtp_fecha_entrega
        '
        Me.dtp_fecha_entrega.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtp_fecha_entrega.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_entrega.Location = New System.Drawing.Point(112, 44)
        Me.dtp_fecha_entrega.Name = "dtp_fecha_entrega"
        Me.dtp_fecha_entrega.Size = New System.Drawing.Size(103, 21)
        Me.dtp_fecha_entrega.TabIndex = 125
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(9, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 16)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "Fecha de Entrega"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(9, 75)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(243, 13)
        Me.Label27.TabIndex = 124
        Me.Label27.Text = "Datos Adicionales / Observaciones / Comentarios"
        '
        'txtComentarios
        '
        Me.txtComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentarios.BackColor = System.Drawing.Color.White
        Me.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComentarios.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarios.Location = New System.Drawing.Point(9, 97)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarios.Size = New System.Drawing.Size(827, 36)
        Me.txtComentarios.TabIndex = 123
        Me.txtComentarios.Text = ""
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.White
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.Green
        Me.txtRazonSocial.Location = New System.Drawing.Point(314, 16)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(520, 21)
        Me.txtRazonSocial.TabIndex = 94
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodCliente.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCodCliente.Location = New System.Drawing.Point(65, 16)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(150, 21)
        Me.txtCodCliente.TabIndex = 92
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(251, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 16)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "R. Social"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Book Antiqua", 9.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(9, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 16)
        Me.Label17.TabIndex = 95
        Me.Label17.Text = "Cliente"
        '
        'GbTransaccion
        '
        Me.GbTransaccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbTransaccion.Controls.Add(Me.txt_numero)
        Me.GbTransaccion.Controls.Add(Me.Label2)
        Me.GbTransaccion.Controls.Add(Me.dtpFecha)
        Me.GbTransaccion.Controls.Add(Me.Label1)
        Me.GbTransaccion.ForeColor = System.Drawing.Color.Navy
        Me.GbTransaccion.Location = New System.Drawing.Point(6, 10)
        Me.GbTransaccion.Name = "GbTransaccion"
        Me.GbTransaccion.Size = New System.Drawing.Size(748, 46)
        Me.GbTransaccion.TabIndex = 36
        Me.GbTransaccion.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero.Location = New System.Drawing.Point(314, 16)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.ReadOnly = True
        Me.txt_numero.Size = New System.Drawing.Size(118, 20)
        Me.txt_numero.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(200, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "N° Requerimiento"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFecha.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(65, 14)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(103, 24)
        Me.dtpFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha"
        '
        'gb_producto_producir
        '
        Me.gb_producto_producir.Controls.Add(Me.Label13)
        Me.gb_producto_producir.Controls.Add(Me.Label12)
        Me.gb_producto_producir.Controls.Add(Me.txt_factor)
        Me.gb_producto_producir.Controls.Add(Me.btn_agregar_insumo)
        Me.gb_producto_producir.Controls.Add(Me.Label9)
        Me.gb_producto_producir.Controls.Add(Me.Label8)
        Me.gb_producto_producir.Controls.Add(Me.Label7)
        Me.gb_producto_producir.Controls.Add(Me.Label5)
        Me.gb_producto_producir.Controls.Add(Me.Label4)
        Me.gb_producto_producir.Controls.Add(Me.Label3)
        Me.gb_producto_producir.Controls.Add(Me.txt_total_prod_producir)
        Me.gb_producto_producir.Controls.Add(Me.txt_costo_prod_producir)
        Me.gb_producto_producir.Controls.Add(Me.txt_cantidad_prod_producir)
        Me.gb_producto_producir.Controls.Add(Me.txt_unidad_prod_producir)
        Me.gb_producto_producir.Controls.Add(Me.txt_des_prod_producir)
        Me.gb_producto_producir.Controls.Add(Me.PictureBox12)
        Me.gb_producto_producir.Controls.Add(Me.txt_cod_producto_producir)
        Me.gb_producto_producir.Controls.Add(Me.Label42)
        Me.gb_producto_producir.Location = New System.Drawing.Point(6, 205)
        Me.gb_producto_producir.Name = "gb_producto_producir"
        Me.gb_producto_producir.Size = New System.Drawing.Size(868, 79)
        Me.gb_producto_producir.TabIndex = 39
        Me.gb_producto_producir.TabStop = False
        Me.gb_producto_producir.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(564, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 16)
        Me.Label13.TabIndex = 230
        Me.Label13.Text = "x"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(584, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 16)
        Me.Label12.TabIndex = 229
        Me.Label12.Text = "Factor"
        Me.Label12.Visible = False
        '
        'txt_factor
        '
        Me.txt_factor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_factor.Location = New System.Drawing.Point(581, 72)
        Me.txt_factor.Name = "txt_factor"
        Me.txt_factor.Size = New System.Drawing.Size(49, 20)
        Me.txt_factor.TabIndex = 228
        Me.txt_factor.Visible = False
        '
        'btn_agregar_insumo
        '
        Me.btn_agregar_insumo.ForeColor = System.Drawing.Color.Navy
        Me.btn_agregar_insumo.Image = CType(resources.GetObject("btn_agregar_insumo.Image"), System.Drawing.Image)
        Me.btn_agregar_insumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar_insumo.Location = New System.Drawing.Point(798, 69)
        Me.btn_agregar_insumo.Name = "btn_agregar_insumo"
        Me.btn_agregar_insumo.Size = New System.Drawing.Size(68, 23)
        Me.btn_agregar_insumo.TabIndex = 227
        Me.btn_agregar_insumo.Text = "Ok     "
        Me.btn_agregar_insumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar_insumo.UseVisualStyleBackColor = True
        Me.btn_agregar_insumo.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(736, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 16)
        Me.Label9.TabIndex = 226
        Me.Label9.Text = "Total"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(658, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 225
        Me.Label8.Text = "Costo"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(781, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 224
        Me.Label7.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(707, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 223
        Me.Label5.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(103, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 222
        Me.Label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(21, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 221
        Me.Label3.Text = "Código"
        '
        'txt_total_prod_producir
        '
        Me.txt_total_prod_producir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_prod_producir.Location = New System.Drawing.Point(717, 72)
        Me.txt_total_prod_producir.Name = "txt_total_prod_producir"
        Me.txt_total_prod_producir.ReadOnly = True
        Me.txt_total_prod_producir.Size = New System.Drawing.Size(75, 20)
        Me.txt_total_prod_producir.TabIndex = 220
        Me.txt_total_prod_producir.Visible = False
        '
        'txt_costo_prod_producir
        '
        Me.txt_costo_prod_producir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costo_prod_producir.Location = New System.Drawing.Point(637, 72)
        Me.txt_costo_prod_producir.Name = "txt_costo_prod_producir"
        Me.txt_costo_prod_producir.ReadOnly = True
        Me.txt_costo_prod_producir.Size = New System.Drawing.Size(75, 20)
        Me.txt_costo_prod_producir.TabIndex = 219
        Me.txt_costo_prod_producir.Visible = False
        '
        'txt_cantidad_prod_producir
        '
        Me.txt_cantidad_prod_producir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad_prod_producir.Location = New System.Drawing.Point(773, 51)
        Me.txt_cantidad_prod_producir.MaxLength = 50
        Me.txt_cantidad_prod_producir.Name = "txt_cantidad_prod_producir"
        Me.txt_cantidad_prod_producir.Size = New System.Drawing.Size(93, 20)
        Me.txt_cantidad_prod_producir.TabIndex = 218
        '
        'txt_unidad_prod_producir
        '
        Me.txt_unidad_prod_producir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_unidad_prod_producir.Location = New System.Drawing.Point(703, 51)
        Me.txt_unidad_prod_producir.Name = "txt_unidad_prod_producir"
        Me.txt_unidad_prod_producir.ReadOnly = True
        Me.txt_unidad_prod_producir.Size = New System.Drawing.Size(56, 20)
        Me.txt_unidad_prod_producir.TabIndex = 217
        '
        'txt_des_prod_producir
        '
        Me.txt_des_prod_producir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_prod_producir.ForeColor = System.Drawing.Color.Black
        Me.txt_des_prod_producir.Location = New System.Drawing.Point(105, 51)
        Me.txt_des_prod_producir.Name = "txt_des_prod_producir"
        Me.txt_des_prod_producir.ReadOnly = True
        Me.txt_des_prod_producir.Size = New System.Drawing.Size(577, 20)
        Me.txt_des_prod_producir.TabIndex = 216
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(80, 52)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox12.TabIndex = 215
        Me.PictureBox12.TabStop = False
        '
        'txt_cod_producto_producir
        '
        Me.txt_cod_producto_producir.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_producto_producir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_producto_producir.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_producto_producir.Location = New System.Drawing.Point(7, 51)
        Me.txt_cod_producto_producir.Name = "txt_cod_producto_producir"
        Me.txt_cod_producto_producir.ReadOnly = True
        Me.txt_cod_producto_producir.Size = New System.Drawing.Size(67, 20)
        Me.txt_cod_producto_producir.TabIndex = 214
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Black
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(-3, 7)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(882, 19)
        Me.Label42.TabIndex = 36
        Me.Label42.Text = "  Producto"
        '
        'Frm_Requerimiento_OP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 618)
        Me.Controls.Add(Me.pnlprincipal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbCabceraDocumento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Requerimiento_OP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requerimientos de Orden de Producción"
        Me.pnlprincipal.ResumeLayout(False)
        Me.pnlprincipal.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbCabceraDocumento.ResumeLayout(False)
        Me.gb_insumos.ResumeLayout(False)
        Me.gb_insumos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle_insumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbTransaccion.ResumeLayout(False)
        Me.GbTransaccion.PerformLayout()
        Me.gb_producto_producir.ResumeLayout(False)
        Me.gb_producto_producir.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlprincipal As System.Windows.Forms.Panel
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dgvCabeceraAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Anular As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbCabceraDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_urgente As System.Windows.Forms.CheckBox
    Friend WithEvents cbo_destinatario As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_des_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GbTransaccion As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb_producto_producir As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_factor As System.Windows.Forms.TextBox
    Friend WithEvents btn_agregar_insumo As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_total_prod_producir As System.Windows.Forms.TextBox
    Friend WithEvents txt_costo_prod_producir As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad_prod_producir As System.Windows.Forms.TextBox
    Friend WithEvents txt_unidad_prod_producir As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_prod_producir As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_producto_producir As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents gb_insumos As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_insumo As System.Windows.Forms.TextBox
    Friend WithEvents txt_unidad_insumo As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_insumo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_insumo As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle_insumos As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DerivaciónDePlaneamientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarDerivPlaneamientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
