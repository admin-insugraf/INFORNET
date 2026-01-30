<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PR_Adelanto_Quincena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PR_Adelanto_Quincena))
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.checkTodos = New System.Windows.Forms.CheckBox()
        Me.mtb_total_adelanto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvDetalle1 = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO_DOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS_NOMBRES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BASICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASIGNACION_FAMILIAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOVILIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_INGRESOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO_ADELANTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirBoletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarDescuentoVariableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarIngresoVariableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.btn_calcular_adelanto = New System.Windows.Forms.Button()
        Me.txt_por_adelanto = New System.Windows.Forms.TextBox()
        Me.lbl_por_adelanto = New System.Windows.Forms.Label()
        Me.btn_anexar = New System.Windows.Forms.Button()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.dtpFecha_inicial = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.pnlCabecera.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvDetalle1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GbCabecera.SuspendLayout()
        Me.btn_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.BackColor = System.Drawing.Color.White
        Me.pnlCabecera.Controls.Add(Me.lblDetalle)
        Me.pnlCabecera.Controls.Add(Me.lblCantidad)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(11, 39)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1004, 541)
        Me.pnlCabecera.TabIndex = 235
        '
        'lblDetalle
        '
        Me.lblDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetalle.BackColor = System.Drawing.Color.White
        Me.lblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalle.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblDetalle.Location = New System.Drawing.Point(6, 11)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(989, 20)
        Me.lblDetalle.TabIndex = 195
        Me.lblDetalle.Text = "LISTA DE ADELANTO DE QUINCENA"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(11, 515)
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
        Me.gbRangofechas.Location = New System.Drawing.Point(485, 45)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(367, 45)
        Me.gbRangofechas.TabIndex = 123
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(187, 20)
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
        Me.dtpfechafinal.Location = New System.Drawing.Point(254, 14)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(11, 20)
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
        Me.dtpfechaInicial.Location = New System.Drawing.Point(86, 14)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(7, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 45)
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
        Me.txtFiltro.Size = New System.Drawing.Size(292, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(320, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 45)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Año de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(152, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(7, 102)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(987, 407)
        Me.dgvCabecera.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(23, 134)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(979, 441)
        Me.TabControl1.TabIndex = 238
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.checkTodos)
        Me.TabPage1.Controls.Add(Me.mtb_total_adelanto)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.dgvDetalle1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(971, 415)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LISTA DE PERSONAL"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'checkTodos
        '
        Me.checkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkTodos.AutoSize = True
        Me.checkTodos.ForeColor = System.Drawing.Color.Navy
        Me.checkTodos.Location = New System.Drawing.Point(9, 372)
        Me.checkTodos.Name = "checkTodos"
        Me.checkTodos.Size = New System.Drawing.Size(154, 17)
        Me.checkTodos.TabIndex = 178
        Me.checkTodos.Text = "Marcar todos los Registros."
        Me.checkTodos.UseVisualStyleBackColor = True
        '
        'mtb_total_adelanto
        '
        Me.mtb_total_adelanto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_total_adelanto.BackColor = System.Drawing.Color.Pink
        Me.mtb_total_adelanto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_total_adelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_total_adelanto.ForeColor = System.Drawing.Color.Green
        Me.mtb_total_adelanto.Location = New System.Drawing.Point(307, 370)
        Me.mtb_total_adelanto.Name = "mtb_total_adelanto"
        Me.mtb_total_adelanto.ReadOnly = True
        Me.mtb_total_adelanto.Size = New System.Drawing.Size(103, 20)
        Me.mtb_total_adelanto.TabIndex = 117
        Me.mtb_total_adelanto.Text = "0.0"
        Me.mtb_total_adelanto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(204, 374)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "Total Adelanto"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(3, 399)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(463, 13)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "***Marque los items que se registraran en la Planilla de Adelanto de Quincena***"
        '
        'dgvDetalle1
        '
        Me.dgvDetalle1.AllowUserToAddRows = False
        Me.dgvDetalle1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalle1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.ITEM, Me.CODIGO, Me.NUMERO_DOC, Me.APELLIDOS_NOMBRES, Me.BASICO, Me.ASIGNACION_FAMILIAR, Me.MOVILIDAD, Me.TOTAL_INGRESOS, Me.MONTO_ADELANTO})
        Me.dgvDetalle1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalle1.EnableHeadersVisualStyles = False
        Me.dgvDetalle1.Location = New System.Drawing.Point(9, 10)
        Me.dgvDetalle1.Name = "dgvDetalle1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetalle1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle1.Size = New System.Drawing.Size(952, 350)
        Me.dgvDetalle1.TabIndex = 113
        '
        'Sel
        '
        Me.Sel.DataPropertyName = "Sel"
        Me.Sel.HeaderText = "SEL"
        Me.Sel.Name = "Sel"
        Me.Sel.Width = 30
        '
        'ITEM
        '
        Me.ITEM.DataPropertyName = "ITEM"
        Me.ITEM.HeaderText = "N°"
        Me.ITEM.Name = "ITEM"
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "CODIGO"
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Visible = False
        '
        'NUMERO_DOC
        '
        Me.NUMERO_DOC.DataPropertyName = "NUMERO_DOC"
        Me.NUMERO_DOC.HeaderText = "NUMERO_DOC"
        Me.NUMERO_DOC.Name = "NUMERO_DOC"
        Me.NUMERO_DOC.Visible = False
        '
        'APELLIDOS_NOMBRES
        '
        Me.APELLIDOS_NOMBRES.DataPropertyName = "APELLIDOS_NOMBRES"
        Me.APELLIDOS_NOMBRES.HeaderText = "APELLIDOS Y NOMBRES"
        Me.APELLIDOS_NOMBRES.Name = "APELLIDOS_NOMBRES"
        '
        'BASICO
        '
        Me.BASICO.DataPropertyName = "BASICO"
        Me.BASICO.HeaderText = "BASICO"
        Me.BASICO.Name = "BASICO"
        '
        'ASIGNACION_FAMILIAR
        '
        Me.ASIGNACION_FAMILIAR.DataPropertyName = "ASIGNACION_FAMILIAR"
        Me.ASIGNACION_FAMILIAR.HeaderText = "ASIGNACIÓN FAMILIAR"
        Me.ASIGNACION_FAMILIAR.Name = "ASIGNACION_FAMILIAR"
        '
        'MOVILIDAD
        '
        Me.MOVILIDAD.DataPropertyName = "MOVILIDAD"
        Me.MOVILIDAD.HeaderText = "MOVILIDAD"
        Me.MOVILIDAD.Name = "MOVILIDAD"
        '
        'TOTAL_INGRESOS
        '
        Me.TOTAL_INGRESOS.DataPropertyName = "TOTAL_INGRESOS"
        Me.TOTAL_INGRESOS.HeaderText = "TOTAL INGRESOS"
        Me.TOTAL_INGRESOS.Name = "TOTAL_INGRESOS"
        '
        'MONTO_ADELANTO
        '
        Me.MONTO_ADELANTO.DataPropertyName = "MONTO_ADELANTO"
        Me.MONTO_ADELANTO.HeaderText = "MONTO DE ADELANTO"
        Me.MONTO_ADELANTO.Name = "MONTO_ADELANTO"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem, Me.ImprimirBoletaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(282, 48)
        '
        'RegistrarIngresosdescuentosVariablesToolStripMenuItem
        '
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem.Image = CType(resources.GetObject("RegistrarIngresosdescuentosVariablesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem.Name = "RegistrarIngresosdescuentosVariablesToolStripMenuItem"
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem.Text = "Registrar ingresos/descuentos variables"
        '
        'ImprimirBoletaToolStripMenuItem
        '
        Me.ImprimirBoletaToolStripMenuItem.Image = CType(resources.GetObject("ImprimirBoletaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirBoletaToolStripMenuItem.Name = "ImprimirBoletaToolStripMenuItem"
        Me.ImprimirBoletaToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.ImprimirBoletaToolStripMenuItem.Text = "Imprimir Boleta de remuneración"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarDescuentoVariableToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(220, 26)
        '
        'EliminarDescuentoVariableToolStripMenuItem
        '
        Me.EliminarDescuentoVariableToolStripMenuItem.Image = CType(resources.GetObject("EliminarDescuentoVariableToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarDescuentoVariableToolStripMenuItem.Name = "EliminarDescuentoVariableToolStripMenuItem"
        Me.EliminarDescuentoVariableToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.EliminarDescuentoVariableToolStripMenuItem.Text = "Eliminar descuento variable"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarIngresoVariableToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(204, 26)
        '
        'EliminarIngresoVariableToolStripMenuItem
        '
        Me.EliminarIngresoVariableToolStripMenuItem.Image = CType(resources.GetObject("EliminarIngresoVariableToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarIngresoVariableToolStripMenuItem.Name = "EliminarIngresoVariableToolStripMenuItem"
        Me.EliminarIngresoVariableToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EliminarIngresoVariableToolStripMenuItem.Text = "Eliminar ingreso variable"
        '
        'GbCabecera
        '
        Me.GbCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.btn_calcular_adelanto)
        Me.GbCabecera.Controls.Add(Me.txt_por_adelanto)
        Me.GbCabecera.Controls.Add(Me.lbl_por_adelanto)
        Me.GbCabecera.Controls.Add(Me.btn_anexar)
        Me.GbCabecera.Controls.Add(Me.txt_titulo)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.Label2)
        Me.GbCabecera.Controls.Add(Me.txtcodigo)
        Me.GbCabecera.Controls.Add(Me.dtpFecha_inicial)
        Me.GbCabecera.Controls.Add(Me.Label5)
        Me.GbCabecera.Location = New System.Drawing.Point(23, 49)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(979, 77)
        Me.GbCabecera.TabIndex = 237
        Me.GbCabecera.TabStop = False
        '
        'btn_calcular_adelanto
        '
        Me.btn_calcular_adelanto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calcular_adelanto.ForeColor = System.Drawing.Color.Green
        Me.btn_calcular_adelanto.Location = New System.Drawing.Point(439, 44)
        Me.btn_calcular_adelanto.Name = "btn_calcular_adelanto"
        Me.btn_calcular_adelanto.Size = New System.Drawing.Size(111, 23)
        Me.btn_calcular_adelanto.TabIndex = 296
        Me.btn_calcular_adelanto.Text = "Calcular Adelanto"
        Me.btn_calcular_adelanto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_calcular_adelanto.UseVisualStyleBackColor = True
        Me.btn_calcular_adelanto.Visible = False
        '
        'txt_por_adelanto
        '
        Me.txt_por_adelanto.BackColor = System.Drawing.Color.White
        Me.txt_por_adelanto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_por_adelanto.ForeColor = System.Drawing.Color.Maroon
        Me.txt_por_adelanto.Location = New System.Drawing.Point(318, 45)
        Me.txt_por_adelanto.MaxLength = 250
        Me.txt_por_adelanto.Name = "txt_por_adelanto"
        Me.txt_por_adelanto.Size = New System.Drawing.Size(111, 20)
        Me.txt_por_adelanto.TabIndex = 295
        Me.txt_por_adelanto.Visible = False
        '
        'lbl_por_adelanto
        '
        Me.lbl_por_adelanto.AutoSize = True
        Me.lbl_por_adelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_por_adelanto.ForeColor = System.Drawing.Color.Navy
        Me.lbl_por_adelanto.Location = New System.Drawing.Point(237, 49)
        Me.lbl_por_adelanto.Name = "lbl_por_adelanto"
        Me.lbl_por_adelanto.Size = New System.Drawing.Size(76, 13)
        Me.lbl_por_adelanto.TabIndex = 294
        Me.lbl_por_adelanto.Text = "% ADELANTO"
        Me.lbl_por_adelanto.Visible = False
        '
        'btn_anexar
        '
        Me.btn_anexar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_anexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_anexar.ForeColor = System.Drawing.Color.Blue
        Me.btn_anexar.Image = CType(resources.GetObject("btn_anexar.Image"), System.Drawing.Image)
        Me.btn_anexar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_anexar.Location = New System.Drawing.Point(821, 13)
        Me.btn_anexar.Name = "btn_anexar"
        Me.btn_anexar.Size = New System.Drawing.Size(144, 56)
        Me.btn_anexar.TabIndex = 293
        Me.btn_anexar.Text = "&Anexar Personal"
        Me.btn_anexar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_anexar.UseVisualStyleBackColor = True
        '
        'txt_titulo
        '
        Me.txt_titulo.BackColor = System.Drawing.Color.White
        Me.txt_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_titulo.ForeColor = System.Drawing.Color.Maroon
        Me.txt_titulo.Location = New System.Drawing.Point(318, 17)
        Me.txt_titulo.MaxLength = 250
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(482, 20)
        Me.txt_titulo.TabIndex = 270
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(237, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 269
        Me.Label3.Text = "TITULO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(21, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "N° PLANILLA"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Location = New System.Drawing.Point(98, 17)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(129, 20)
        Me.txtcodigo.TabIndex = 210
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha_inicial
        '
        Me.dtpFecha_inicial.CalendarMonthBackground = System.Drawing.Color.Aquamarine
        Me.dtpFecha_inicial.CustomFormat = "MMMM/yyyy"
        Me.dtpFecha_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha_inicial.Location = New System.Drawing.Point(98, 45)
        Me.dtpFecha_inicial.Name = "dtpFecha_inicial"
        Me.dtpFecha_inicial.Size = New System.Drawing.Size(129, 20)
        Me.dtpFecha_inicial.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(35, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "MES/AÑO"
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btnImprimir, Me.btnCancelar, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(1026, 25)
        Me.btn_menu.TabIndex = 236
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
        Me.btnConsultar.Size = New System.Drawing.Size(81, 22)
        Me.btnConsultar.Text = "&Consultar"
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
        'Frm_PR_Adelanto_Quincena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 582)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GbCabecera)
        Me.Controls.Add(Me.btn_menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_PR_Adelanto_Quincena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adelanto de Quincena"
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvDetalle1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.btn_menu.ResumeLayout(False)
        Me.btn_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents mtb_total_adelanto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle1 As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RegistrarIngresosdescuentosVariablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirBoletaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarDescuentoVariableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarIngresoVariableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents btn_anexar As System.Windows.Forms.Button
    Friend WithEvents txt_titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_por_adelanto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_por_adelanto As System.Windows.Forms.Label
    Friend WithEvents btn_calcular_adelanto As System.Windows.Forms.Button
    Friend WithEvents checkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERO_DOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS_NOMBRES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BASICO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ASIGNACION_FAMILIAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOVILIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_INGRESOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO_ADELANTO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
