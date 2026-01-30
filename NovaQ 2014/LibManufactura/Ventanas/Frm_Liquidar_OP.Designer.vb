<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Liquidar_OP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Liquidar_OP))
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
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbCabceraDocumento = New System.Windows.Forms.GroupBox()
        Me.gb_producto_producir = New System.Windows.Forms.GroupBox()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cantidad_op = New System.Windows.Forms.TextBox()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.dtp_fecha_liquidacion = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_costo_unitario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_costo_total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cantidad_liq_total = New System.Windows.Forms.TextBox()
        Me.rdb_total = New System.Windows.Forms.RadioButton()
        Me.rdb_parcial = New System.Windows.Forms.RadioButton()
        Me.btn_generar_liquidacion = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cantidad_prod_producir = New System.Windows.Forms.TextBox()
        Me.txt_unidad_prod_producir = New System.Windows.Forms.TextBox()
        Me.txt_des_prod_producir = New System.Windows.Forms.TextBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_producto_producir = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.GbTransaccion = New System.Windows.Forms.GroupBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_insumos = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvDetalle_insumos = New System.Windows.Forms.DataGridView()
        Me.pnlprincipal.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbCabceraDocumento.SuspendLayout()
        Me.gb_producto_producir.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbTransaccion.SuspendLayout()
        Me.gb_insumos.SuspendLayout()
        CType(Me.dgvDetalle_insumos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlprincipal.Location = New System.Drawing.Point(11, 37)
        Me.pnlprincipal.Name = "pnlprincipal"
        Me.pnlprincipal.Size = New System.Drawing.Size(891, 481)
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
        Me.lblDetalle.Size = New System.Drawing.Size(891, 20)
        Me.lblDetalle.TabIndex = 201
        Me.lblDetalle.Text = "LIQUIDACION DE ORDEN DE PRODUCCION"
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
        Me.gbRangofechas.Location = New System.Drawing.Point(578, 56)
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
        Me.lblCantidad.Location = New System.Drawing.Point(6, 456)
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
        Me.dgvCabeceraAlmacen.Location = New System.Drawing.Point(3, 111)
        Me.dgvCabeceraAlmacen.Name = "dgvCabeceraAlmacen"
        Me.dgvCabeceraAlmacen.ReadOnly = True
        Me.dgvCabeceraAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabeceraAlmacen.Size = New System.Drawing.Size(875, 341)
        Me.dgvCabeceraAlmacen.TabIndex = 104
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(418, 56)
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
        Me.GroupBox7.Location = New System.Drawing.Point(3, 56)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btnCancelar, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(907, 25)
        Me.ToolStrip1.TabIndex = 114
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.ForeColor = System.Drawing.Color.Navy
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 22)
        Me.btnNuevo.Text = "&Liquidar"
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
        'btnGrabar
        '
        Me.btnGrabar.ForeColor = System.Drawing.Color.Navy
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(66, 22)
        Me.btnGrabar.Text = "&Grabar"
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
        Me.gbCabceraDocumento.Controls.Add(Me.gb_producto_producir)
        Me.gbCabceraDocumento.Controls.Add(Me.GbTransaccion)
        Me.gbCabceraDocumento.Controls.Add(Me.gb_insumos)
        Me.gbCabceraDocumento.Location = New System.Drawing.Point(18, 33)
        Me.gbCabceraDocumento.Name = "gbCabceraDocumento"
        Me.gbCabceraDocumento.Size = New System.Drawing.Size(885, 470)
        Me.gbCabceraDocumento.TabIndex = 113
        Me.gbCabceraDocumento.TabStop = False
        '
        'gb_producto_producir
        '
        Me.gb_producto_producir.Controls.Add(Me.cboAlmacen)
        Me.gb_producto_producir.Controls.Add(Me.Label14)
        Me.gb_producto_producir.Controls.Add(Me.Label13)
        Me.gb_producto_producir.Controls.Add(Me.txt_cantidad_op)
        Me.gb_producto_producir.Controls.Add(Me.btn_del)
        Me.gb_producto_producir.Controls.Add(Me.dtp_fecha_liquidacion)
        Me.gb_producto_producir.Controls.Add(Me.Label12)
        Me.gb_producto_producir.Controls.Add(Me.Label11)
        Me.gb_producto_producir.Controls.Add(Me.txt_costo_unitario)
        Me.gb_producto_producir.Controls.Add(Me.Label9)
        Me.gb_producto_producir.Controls.Add(Me.txt_costo_total)
        Me.gb_producto_producir.Controls.Add(Me.Label8)
        Me.gb_producto_producir.Controls.Add(Me.txt_cantidad_liq_total)
        Me.gb_producto_producir.Controls.Add(Me.rdb_total)
        Me.gb_producto_producir.Controls.Add(Me.rdb_parcial)
        Me.gb_producto_producir.Controls.Add(Me.btn_generar_liquidacion)
        Me.gb_producto_producir.Controls.Add(Me.Label7)
        Me.gb_producto_producir.Controls.Add(Me.Label5)
        Me.gb_producto_producir.Controls.Add(Me.Label4)
        Me.gb_producto_producir.Controls.Add(Me.Label3)
        Me.gb_producto_producir.Controls.Add(Me.txt_cantidad_prod_producir)
        Me.gb_producto_producir.Controls.Add(Me.txt_unidad_prod_producir)
        Me.gb_producto_producir.Controls.Add(Me.txt_des_prod_producir)
        Me.gb_producto_producir.Controls.Add(Me.PictureBox12)
        Me.gb_producto_producir.Controls.Add(Me.txt_cod_producto_producir)
        Me.gb_producto_producir.Controls.Add(Me.Label42)
        Me.gb_producto_producir.ForeColor = System.Drawing.Color.Navy
        Me.gb_producto_producir.Location = New System.Drawing.Point(6, 63)
        Me.gb_producto_producir.Name = "gb_producto_producir"
        Me.gb_producto_producir.Size = New System.Drawing.Size(874, 158)
        Me.gb_producto_producir.TabIndex = 39
        Me.gb_producto_producir.TabStop = False
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(109, 120)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(381, 24)
        Me.cboAlmacen.TabIndex = 240
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(9, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 16)
        Me.Label14.TabIndex = 239
        Me.Label14.Text = "Almacen destino"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(673, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 16)
        Me.Label13.TabIndex = 238
        Me.Label13.Text = "Cantidad O.P."
        '
        'txt_cantidad_op
        '
        Me.txt_cantidad_op.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad_op.Location = New System.Drawing.Point(673, 51)
        Me.txt_cantidad_op.Name = "txt_cantidad_op"
        Me.txt_cantidad_op.ReadOnly = True
        Me.txt_cantidad_op.Size = New System.Drawing.Size(83, 20)
        Me.txt_cantidad_op.TabIndex = 237
        '
        'btn_del
        '
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_del.ForeColor = System.Drawing.Color.Navy
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(773, 99)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(93, 23)
        Me.btn_del.TabIndex = 236
        Me.btn_del.Text = "Eliminar Liq."
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'dtp_fecha_liquidacion
        '
        Me.dtp_fecha_liquidacion.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtp_fecha_liquidacion.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_liquidacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_liquidacion.Location = New System.Drawing.Point(626, 89)
        Me.dtp_fecha_liquidacion.Name = "dtp_fecha_liquidacion"
        Me.dtp_fecha_liquidacion.Size = New System.Drawing.Size(103, 24)
        Me.dtp_fecha_liquidacion.TabIndex = 234
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(658, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 235
        Me.Label12.Text = "Fecha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(210, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 16)
        Me.Label11.TabIndex = 233
        Me.Label11.Text = "Costo Unitario"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_costo_unitario
        '
        Me.txt_costo_unitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costo_unitario.Location = New System.Drawing.Point(208, 91)
        Me.txt_costo_unitario.MaxLength = 50
        Me.txt_costo_unitario.Name = "txt_costo_unitario"
        Me.txt_costo_unitario.ReadOnly = True
        Me.txt_costo_unitario.Size = New System.Drawing.Size(93, 20)
        Me.txt_costo_unitario.TabIndex = 232
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(120, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 231
        Me.Label9.Text = "Costo Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_costo_total
        '
        Me.txt_costo_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costo_total.Location = New System.Drawing.Point(109, 91)
        Me.txt_costo_total.MaxLength = 50
        Me.txt_costo_total.Name = "txt_costo_total"
        Me.txt_costo_total.ReadOnly = True
        Me.txt_costo_total.Size = New System.Drawing.Size(93, 20)
        Me.txt_costo_total.TabIndex = 230
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(9, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 229
        Me.Label8.Text = "Cant. Liq. Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_cantidad_liq_total
        '
        Me.txt_cantidad_liq_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad_liq_total.Location = New System.Drawing.Point(9, 91)
        Me.txt_cantidad_liq_total.MaxLength = 50
        Me.txt_cantidad_liq_total.Name = "txt_cantidad_liq_total"
        Me.txt_cantidad_liq_total.ReadOnly = True
        Me.txt_cantidad_liq_total.Size = New System.Drawing.Size(93, 20)
        Me.txt_cantidad_liq_total.TabIndex = 228
        '
        'rdb_total
        '
        Me.rdb_total.AutoSize = True
        Me.rdb_total.Checked = True
        Me.rdb_total.Location = New System.Drawing.Point(495, 93)
        Me.rdb_total.Name = "rdb_total"
        Me.rdb_total.Size = New System.Drawing.Size(106, 17)
        Me.rdb_total.TabIndex = 227
        Me.rdb_total.TabStop = True
        Me.rdb_total.Text = "Liquidación Total"
        Me.rdb_total.UseVisualStyleBackColor = True
        '
        'rdb_parcial
        '
        Me.rdb_parcial.AutoSize = True
        Me.rdb_parcial.Location = New System.Drawing.Point(331, 93)
        Me.rdb_parcial.Name = "rdb_parcial"
        Me.rdb_parcial.Size = New System.Drawing.Size(114, 17)
        Me.rdb_parcial.TabIndex = 226
        Me.rdb_parcial.TabStop = True
        Me.rdb_parcial.Text = "Liquidación Parcial"
        Me.rdb_parcial.UseVisualStyleBackColor = True
        '
        'btn_generar_liquidacion
        '
        Me.btn_generar_liquidacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_generar_liquidacion.ForeColor = System.Drawing.Color.Navy
        Me.btn_generar_liquidacion.Image = CType(resources.GetObject("btn_generar_liquidacion.Image"), System.Drawing.Image)
        Me.btn_generar_liquidacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_liquidacion.Location = New System.Drawing.Point(773, 74)
        Me.btn_generar_liquidacion.Name = "btn_generar_liquidacion"
        Me.btn_generar_liquidacion.Size = New System.Drawing.Size(93, 23)
        Me.btn_generar_liquidacion.TabIndex = 225
        Me.btn_generar_liquidacion.Text = "Agregar Liq."
        Me.btn_generar_liquidacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_liquidacion.UseVisualStyleBackColor = True
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
        Me.Label5.Location = New System.Drawing.Point(615, 32)
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
        Me.txt_unidad_prod_producir.Location = New System.Drawing.Point(611, 51)
        Me.txt_unidad_prod_producir.Name = "txt_unidad_prod_producir"
        Me.txt_unidad_prod_producir.ReadOnly = True
        Me.txt_unidad_prod_producir.Size = New System.Drawing.Size(56, 20)
        Me.txt_unidad_prod_producir.TabIndex = 217
        '
        'txt_des_prod_producir
        '
        Me.txt_des_prod_producir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_prod_producir.ForeColor = System.Drawing.Color.Black
        Me.txt_des_prod_producir.Location = New System.Drawing.Point(129, 51)
        Me.txt_des_prod_producir.Name = "txt_des_prod_producir"
        Me.txt_des_prod_producir.ReadOnly = True
        Me.txt_des_prod_producir.Size = New System.Drawing.Size(475, 20)
        Me.txt_des_prod_producir.TabIndex = 216
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(106, 52)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox12.TabIndex = 215
        Me.PictureBox12.TabStop = False
        '
        'txt_cod_producto_producir
        '
        Me.txt_cod_producto_producir.BackColor = System.Drawing.SystemColors.Control
        Me.txt_cod_producto_producir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_producto_producir.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_producto_producir.Location = New System.Drawing.Point(9, 51)
        Me.txt_cod_producto_producir.Name = "txt_cod_producto_producir"
        Me.txt_cod_producto_producir.ReadOnly = True
        Me.txt_cod_producto_producir.Size = New System.Drawing.Size(93, 20)
        Me.txt_cod_producto_producir.TabIndex = 214
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Navy
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(-3, 7)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(882, 19)
        Me.Label42.TabIndex = 36
        Me.Label42.Text = "  Producto Fabricado"
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
        Me.GbTransaccion.Size = New System.Drawing.Size(868, 46)
        Me.GbTransaccion.TabIndex = 36
        Me.GbTransaccion.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero.Location = New System.Drawing.Point(299, 15)
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
        Me.Label2.Location = New System.Drawing.Point(242, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "N° O. P."
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFecha.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(53, 13)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(103, 24)
        Me.dtpFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha"
        '
        'gb_insumos
        '
        Me.gb_insumos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_insumos.Controls.Add(Me.Label10)
        Me.gb_insumos.Controls.Add(Me.dgvDetalle_insumos)
        Me.gb_insumos.Location = New System.Drawing.Point(6, 226)
        Me.gb_insumos.Name = "gb_insumos"
        Me.gb_insumos.Size = New System.Drawing.Size(874, 230)
        Me.gb_insumos.TabIndex = 38
        Me.gb_insumos.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Navy
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(-4, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(882, 19)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "  Lista de Liquidaciones"
        '
        'dgvDetalle_insumos
        '
        Me.dgvDetalle_insumos.AllowUserToAddRows = False
        Me.dgvDetalle_insumos.AllowUserToDeleteRows = False
        Me.dgvDetalle_insumos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle_insumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle_insumos.Location = New System.Drawing.Point(8, 30)
        Me.dgvDetalle_insumos.Name = "dgvDetalle_insumos"
        Me.dgvDetalle_insumos.ReadOnly = True
        Me.dgvDetalle_insumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle_insumos.Size = New System.Drawing.Size(857, 192)
        Me.dgvDetalle_insumos.TabIndex = 13
        '
        'Frm_Liquidar_OP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(907, 519)
        Me.Controls.Add(Me.pnlprincipal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbCabceraDocumento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Liquidar_OP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidación de Orden de Producción"
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
        Me.gb_producto_producir.ResumeLayout(False)
        Me.gb_producto_producir.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbTransaccion.ResumeLayout(False)
        Me.GbTransaccion.PerformLayout()
        Me.gb_insumos.ResumeLayout(False)
        CType(Me.dgvDetalle_insumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlprincipal As System.Windows.Forms.Panel
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
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbCabceraDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents gb_producto_producir As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_prod_producir As System.Windows.Forms.TextBox
    Friend WithEvents txt_unidad_prod_producir As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_prod_producir As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_producto_producir As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GbTransaccion As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb_insumos As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle_insumos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_generar_liquidacion As System.Windows.Forms.Button
    Friend WithEvents rdb_total As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_parcial As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_fecha_liquidacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_costo_unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_costo_total As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_liq_total As System.Windows.Forms.TextBox
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_op As System.Windows.Forms.TextBox
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
End Class
