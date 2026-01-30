<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulta_OrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsulta_OrdenCompra))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_cierre_manual = New System.Windows.Forms.ToolStripButton()
        Me.btn_mov_compras = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IngresosAlAlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCUMENT_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDOR_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VAT_REGISTRATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNT_SALES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURRENCY_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQUI_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIERRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONES_CIERRE_MANUAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlDocReferencia = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.txtref_tipo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSalr = New System.Windows.Forms.Button()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.dtpRef_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtref_serie = New System.Windows.Forms.TextBox()
        Me.txtref_num_doc = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.btn_menu.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDocReferencia.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimir, Me.btn_cierre_manual, Me.btn_mov_compras, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(858, 25)
        Me.btn_menu.TabIndex = 200
        Me.btn_menu.Text = "ToolStrip1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(177, 22)
        Me.btnImprimir.Text = "&Reportar Mov. en Almacen"
        '
        'btn_cierre_manual
        '
        Me.btn_cierre_manual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cierre_manual.Image = CType(resources.GetObject("btn_cierre_manual.Image"), System.Drawing.Image)
        Me.btn_cierre_manual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cierre_manual.Name = "btn_cierre_manual"
        Me.btn_cierre_manual.Size = New System.Drawing.Size(105, 22)
        Me.btn_cierre_manual.Text = "Cierre Manual"
        Me.btn_cierre_manual.Visible = False
        '
        'btn_mov_compras
        '
        Me.btn_mov_compras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_mov_compras.Image = CType(resources.GetObject("btn_mov_compras.Image"), System.Drawing.Image)
        Me.btn_mov_compras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_mov_compras.Name = "btn_mov_compras"
        Me.btn_mov_compras.Size = New System.Drawing.Size(178, 22)
        Me.btn_mov_compras.Text = "Reportar Mov. en Compras"
        Me.btn_mov_compras.Visible = False
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
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.dgvDetalle)
        Me.pnlCabecera.Controls.Add(Me.lblCantidad)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(9, 36)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(837, 514)
        Me.pnlCabecera.TabIndex = 199
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvDetalle.Location = New System.Drawing.Point(12, 285)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(817, 195)
        Me.dgvDetalle.TabIndex = 125
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosAlAlmacenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 26)
        '
        'IngresosAlAlmacenToolStripMenuItem
        '
        Me.IngresosAlAlmacenToolStripMenuItem.Name = "IngresosAlAlmacenToolStripMenuItem"
        Me.IngresosAlAlmacenToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.IngresosAlAlmacenToolStripMenuItem.Text = "Ingresos al almacen"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(15, 483)
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
        Me.gbRangofechas.Location = New System.Drawing.Point(470, 8)
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 7)
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
        Me.GroupBox2.Location = New System.Drawing.Point(276, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 45)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.dgvCabecera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DOCUMENT_DATE, Me.VENDOR_ID, Me.PROVEEDOR, Me.VAT_REGISTRATION, Me.STATUS_ID, Me.AMOUNT_SALES, Me.CURRENCY_TYPE, Me.DESCRIPTION, Me.REQUI_ID, Me.CIERRE, Me.TIPO_DOC_REF, Me.NUM_DOC_REF, Me.FECHA_DOC_REF, Me.OBSERVACIONES_CIERRE_MANUAL})
        Me.dgvCabecera.Location = New System.Drawing.Point(12, 58)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(816, 221)
        Me.dgvCabecera.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "Numero"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'DOCUMENT_DATE
        '
        Me.DOCUMENT_DATE.DataPropertyName = "DOCUMENT_DATE"
        Me.DOCUMENT_DATE.HeaderText = "Fecha"
        Me.DOCUMENT_DATE.Name = "DOCUMENT_DATE"
        Me.DOCUMENT_DATE.ReadOnly = True
        Me.DOCUMENT_DATE.Width = 70
        '
        'VENDOR_ID
        '
        Me.VENDOR_ID.DataPropertyName = "VENDOR_ID"
        Me.VENDOR_ID.HeaderText = "Codigo"
        Me.VENDOR_ID.Name = "VENDOR_ID"
        Me.VENDOR_ID.ReadOnly = True
        Me.VENDOR_ID.Width = 80
        '
        'PROVEEDOR
        '
        Me.PROVEEDOR.DataPropertyName = "PROVEEDOR"
        Me.PROVEEDOR.HeaderText = "Proveedor"
        Me.PROVEEDOR.Name = "PROVEEDOR"
        Me.PROVEEDOR.ReadOnly = True
        Me.PROVEEDOR.Width = 210
        '
        'VAT_REGISTRATION
        '
        Me.VAT_REGISTRATION.DataPropertyName = "VAT_REGISTRATION"
        Me.VAT_REGISTRATION.HeaderText = "R.u.c"
        Me.VAT_REGISTRATION.Name = "VAT_REGISTRATION"
        Me.VAT_REGISTRATION.ReadOnly = True
        Me.VAT_REGISTRATION.Visible = False
        Me.VAT_REGISTRATION.Width = 80
        '
        'STATUS_ID
        '
        Me.STATUS_ID.DataPropertyName = "STATUS_ID"
        Me.STATUS_ID.HeaderText = "STATUS_ID"
        Me.STATUS_ID.Name = "STATUS_ID"
        Me.STATUS_ID.ReadOnly = True
        Me.STATUS_ID.Visible = False
        '
        'AMOUNT_SALES
        '
        Me.AMOUNT_SALES.DataPropertyName = "AMOUNT_SALES"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.AMOUNT_SALES.DefaultCellStyle = DataGridViewCellStyle1
        Me.AMOUNT_SALES.HeaderText = "Total"
        Me.AMOUNT_SALES.Name = "AMOUNT_SALES"
        Me.AMOUNT_SALES.ReadOnly = True
        Me.AMOUNT_SALES.Width = 70
        '
        'CURRENCY_TYPE
        '
        Me.CURRENCY_TYPE.DataPropertyName = "CURRENCY_TYPE"
        Me.CURRENCY_TYPE.HeaderText = "Moneda"
        Me.CURRENCY_TYPE.Name = "CURRENCY_TYPE"
        Me.CURRENCY_TYPE.ReadOnly = True
        Me.CURRENCY_TYPE.Width = 50
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.DataPropertyName = "DESCRIPTION"
        Me.DESCRIPTION.HeaderText = "Estado"
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.ReadOnly = True
        '
        'REQUI_ID
        '
        Me.REQUI_ID.DataPropertyName = "REQUI_ID"
        Me.REQUI_ID.HeaderText = "N° Requisición"
        Me.REQUI_ID.Name = "REQUI_ID"
        Me.REQUI_ID.ReadOnly = True
        '
        'CIERRE
        '
        Me.CIERRE.DataPropertyName = "CIERRE"
        Me.CIERRE.HeaderText = "Opcion de Cierre"
        Me.CIERRE.Name = "CIERRE"
        '
        'TIPO_DOC_REF
        '
        Me.TIPO_DOC_REF.DataPropertyName = "TIPO_DOC_REF"
        Me.TIPO_DOC_REF.HeaderText = "Tipo Doc. Referencia"
        Me.TIPO_DOC_REF.Name = "TIPO_DOC_REF"
        '
        'NUM_DOC_REF
        '
        Me.NUM_DOC_REF.DataPropertyName = "NUM_DOC_REF"
        Me.NUM_DOC_REF.HeaderText = "N° Doc. Referencia"
        Me.NUM_DOC_REF.Name = "NUM_DOC_REF"
        '
        'FECHA_DOC_REF
        '
        Me.FECHA_DOC_REF.DataPropertyName = "FECHA_DOC_REF"
        Me.FECHA_DOC_REF.HeaderText = "Fecha Doc. Referencia"
        Me.FECHA_DOC_REF.Name = "FECHA_DOC_REF"
        '
        'OBSERVACIONES_CIERRE_MANUAL
        '
        Me.OBSERVACIONES_CIERRE_MANUAL.DataPropertyName = "OBSERVACIONES_CIERRE_MANUAL"
        Me.OBSERVACIONES_CIERRE_MANUAL.HeaderText = "Obs. Cierre Manual"
        Me.OBSERVACIONES_CIERRE_MANUAL.Name = "OBSERVACIONES_CIERRE_MANUAL"
        Me.OBSERVACIONES_CIERRE_MANUAL.Width = 200
        '
        'pnlDocReferencia
        '
        Me.pnlDocReferencia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlDocReferencia.Controls.Add(Me.GroupBox9)
        Me.pnlDocReferencia.Location = New System.Drawing.Point(155, 36)
        Me.pnlDocReferencia.Name = "pnlDocReferencia"
        Me.pnlDocReferencia.Size = New System.Drawing.Size(519, 128)
        Me.pnlDocReferencia.TabIndex = 201
        Me.pnlDocReferencia.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txt_observaciones)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Controls.Add(Me.PictureBox16)
        Me.GroupBox9.Controls.Add(Me.txtref_tipo)
        Me.GroupBox9.Controls.Add(Me.Button1)
        Me.GroupBox9.Controls.Add(Me.btnSalr)
        Me.GroupBox9.Controls.Add(Me.Label56)
        Me.GroupBox9.Controls.Add(Me.dtpRef_fecha)
        Me.GroupBox9.Controls.Add(Me.Label59)
        Me.GroupBox9.Controls.Add(Me.Label60)
        Me.GroupBox9.Controls.Add(Me.txtref_serie)
        Me.GroupBox9.Controls.Add(Me.txtref_num_doc)
        Me.GroupBox9.Controls.Add(Me.Label62)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(498, 108)
        Me.GroupBox9.TabIndex = 141
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Detalles del Documento de Referencia"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.BackColor = System.Drawing.Color.White
        Me.txt_observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_observaciones.Location = New System.Drawing.Point(69, 82)
        Me.txt_observaciones.MaxLength = 250
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(346, 20)
        Me.txt_observaciones.TabIndex = 215
        Me.txt_observaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(33, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "Obs."
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.White
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(221, 33)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(17, 16)
        Me.PictureBox16.TabIndex = 213
        Me.PictureBox16.TabStop = False
        '
        'txtref_tipo
        '
        Me.txtref_tipo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtref_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtref_tipo.Location = New System.Drawing.Point(69, 31)
        Me.txtref_tipo.MaxLength = 5
        Me.txtref_tipo.Name = "txtref_tipo"
        Me.txtref_tipo.ReadOnly = True
        Me.txtref_tipo.Size = New System.Drawing.Size(148, 20)
        Me.txtref_tipo.TabIndex = 200
        Me.txtref_tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(426, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 37)
        Me.Button1.TabIndex = 207
        Me.Button1.Text = "Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSalr
        '
        Me.btnSalr.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSalr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalr.Image = CType(resources.GetObject("btnSalr.Image"), System.Drawing.Image)
        Me.btnSalr.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalr.Location = New System.Drawing.Point(426, 61)
        Me.btnSalr.Name = "btnSalr"
        Me.btnSalr.Size = New System.Drawing.Size(58, 37)
        Me.btnSalr.TabIndex = 208
        Me.btnSalr.Text = "Retornar"
        Me.btnSalr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalr.UseVisualStyleBackColor = True
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label56.ForeColor = System.Drawing.Color.Navy
        Me.Label56.Location = New System.Drawing.Point(244, 60)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(51, 13)
        Me.Label56.TabIndex = 126
        Me.Label56.Text = "Fec. Doc"
        '
        'dtpRef_fecha
        '
        Me.dtpRef_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRef_fecha.Location = New System.Drawing.Point(305, 56)
        Me.dtpRef_fecha.Name = "dtpRef_fecha"
        Me.dtpRef_fecha.Size = New System.Drawing.Size(110, 20)
        Me.dtpRef_fecha.TabIndex = 203
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.Color.Navy
        Me.Label59.Location = New System.Drawing.Point(14, 35)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(48, 13)
        Me.Label59.TabIndex = 128
        Me.Label59.Text = "Tip. Doc"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.Navy
        Me.Label60.Location = New System.Drawing.Point(246, 35)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(49, 13)
        Me.Label60.TabIndex = 130
        Me.Label60.Text = "Ser. Doc"
        '
        'txtref_serie
        '
        Me.txtref_serie.BackColor = System.Drawing.Color.White
        Me.txtref_serie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtref_serie.Location = New System.Drawing.Point(305, 31)
        Me.txtref_serie.MaxLength = 15
        Me.txtref_serie.Name = "txtref_serie"
        Me.txtref_serie.Size = New System.Drawing.Size(110, 20)
        Me.txtref_serie.TabIndex = 201
        Me.txtref_serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtref_num_doc
        '
        Me.txtref_num_doc.BackColor = System.Drawing.Color.White
        Me.txtref_num_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtref_num_doc.Location = New System.Drawing.Point(69, 56)
        Me.txtref_num_doc.MaxLength = 15
        Me.txtref_num_doc.Name = "txtref_num_doc"
        Me.txtref_num_doc.Size = New System.Drawing.Size(170, 20)
        Me.txtref_num_doc.TabIndex = 202
        Me.txtref_num_doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.ForeColor = System.Drawing.Color.Navy
        Me.Label62.Location = New System.Drawing.Point(20, 60)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(42, 13)
        Me.Label62.TabIndex = 132
        Me.Label62.Text = "N° Doc"
        '
        'FrmConsulta_OrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(858, 554)
        Me.Controls.Add(Me.pnlDocReferencia)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConsulta_OrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Orden Compra"
        Me.btn_menu.ResumeLayout(False)
        Me.btn_menu.PerformLayout()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDocReferencia.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
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
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cierre_manual As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlDocReferencia As System.Windows.Forms.Panel
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents txtref_tipo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSalr As System.Windows.Forms.Button
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents dtpRef_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtref_serie As System.Windows.Forms.TextBox
    Friend WithEvents txtref_num_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents btn_mov_compras As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENT_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VENDOR_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVEEDOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VAT_REGISTRATION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNT_SALES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRENCY_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REQUI_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIERRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_DOC_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUM_DOC_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_DOC_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONES_CIERRE_MANUAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IngresosAlAlmacenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
