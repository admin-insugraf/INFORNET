<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManufactura_Liquidacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManufactura_Liquidacion))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_GenerarOf = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_liquidacion_manual = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.cboMostrar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.chkFormula = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbmoneda = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_num_lote = New System.Windows.Forms.TextBox()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcabecera.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalles.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_GenerarOf, Me.btn_grabar, Me.btn_Imprimir, Me.btn_liquidacion_manual, Me.btn_cancelar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(841, 25)
        Me.ToolStrip1.TabIndex = 193
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_GenerarOf
        '
        Me.btn_GenerarOf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GenerarOf.ForeColor = System.Drawing.Color.Navy
        Me.btn_GenerarOf.Image = CType(resources.GetObject("btn_GenerarOf.Image"), System.Drawing.Image)
        Me.btn_GenerarOf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_GenerarOf.Name = "btn_GenerarOf"
        Me.btn_GenerarOf.Size = New System.Drawing.Size(89, 22)
        Me.btn_GenerarOf.Text = "&Liquidar OF"
        '
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_grabar.ForeColor = System.Drawing.Color.Navy
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Imprimir.ForeColor = System.Drawing.Color.Navy
        Me.btn_Imprimir.Image = CType(resources.GetObject("btn_Imprimir.Image"), System.Drawing.Image)
        Me.btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(77, 22)
        Me.btn_Imprimir.Text = "&Imprimir"
        Me.btn_Imprimir.Visible = False
        '
        'btn_liquidacion_manual
        '
        Me.btn_liquidacion_manual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_liquidacion_manual.ForeColor = System.Drawing.Color.Navy
        Me.btn_liquidacion_manual.Image = CType(resources.GetObject("btn_liquidacion_manual.Image"), System.Drawing.Image)
        Me.btn_liquidacion_manual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_liquidacion_manual.Name = "btn_liquidacion_manual"
        Me.btn_liquidacion_manual.Size = New System.Drawing.Size(134, 22)
        Me.btn_liquidacion_manual.Text = "Liquidación Manual"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "Cancelar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton1.Text = "&Salir"
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.GroupBox4)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.cboMostrar)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(11, 33)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(818, 376)
        Me.pnlCabecera.TabIndex = 192
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(260, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(183, 45)
        Me.GroupBox4.TabIndex = 126
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones  de Busquedas:"
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
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(444, 10)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 127
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
        'cboMostrar
        '
        Me.cboMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMostrar.FormattingEnabled = True
        Me.cboMostrar.Items.AddRange(New Object() {"-Todas--", "Planificacion", "Produccion", "Anuladas", "Terminadas", "Liquidadas"})
        Me.cboMostrar.Location = New System.Drawing.Point(67, 26)
        Me.cboMostrar.Name = "cboMostrar"
        Me.cboMostrar.Size = New System.Drawing.Size(177, 21)
        Me.cboMostrar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mostrar"
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(19, 65)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(778, 303)
        Me.dgvCabecera.TabIndex = 2
        '
        'chkFormula
        '
        Me.chkFormula.AutoSize = True
        Me.chkFormula.Location = New System.Drawing.Point(11, 126)
        Me.chkFormula.Name = "chkFormula"
        Me.chkFormula.Size = New System.Drawing.Size(125, 17)
        Me.chkFormula.TabIndex = 181
        Me.chkFormula.Text = "Usar Formula Emitida"
        Me.chkFormula.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(32, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "N° O.F."
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(78, 15)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(146, 20)
        Me.txtcodigo.TabIndex = 1
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(248, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(294, 15)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpFecha.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Moneda"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(77, 182)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(147, 21)
        Me.cboMoneda.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Almacen"
        '
        'cmbmoneda
        '
        Me.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmoneda.FormattingEnabled = True
        Me.cmbmoneda.Location = New System.Drawing.Point(726, 17)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Size = New System.Drawing.Size(84, 21)
        Me.cmbmoneda.TabIndex = 192
        Me.cmbmoneda.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(674, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 193
        Me.Label10.Text = "Moneda"
        Me.Label10.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(31, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "Saldo a Liquidar :"
        '
        'lblsaldo
        '
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsaldo.ForeColor = System.Drawing.Color.Navy
        Me.lblsaldo.Location = New System.Drawing.Point(186, 41)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(34, 20)
        Me.lblsaldo.TabIndex = 195
        Me.lblsaldo.Text = "0.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(24, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 196
        Me.Label7.Text = "Producto"
        '
        'txt_producto
        '
        Me.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_producto.Enabled = False
        Me.txt_producto.Location = New System.Drawing.Point(78, 68)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.ReadOnly = True
        Me.txt_producto.Size = New System.Drawing.Size(379, 20)
        Me.txt_producto.TabIndex = 197
        Me.txt_producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(466, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "N° Lote"
        '
        'txt_num_lote
        '
        Me.txt_num_lote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_lote.Enabled = False
        Me.txt_num_lote.Location = New System.Drawing.Point(512, 69)
        Me.txt_num_lote.Name = "txt_num_lote"
        Me.txt_num_lote.ReadOnly = True
        Me.txt_num_lote.Size = New System.Drawing.Size(146, 20)
        Me.txt_num_lote.TabIndex = 199
        Me.txt_num_lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbcabecera
        '
        Me.gbcabecera.Controls.Add(Me.txt_num_lote)
        Me.gbcabecera.Controls.Add(Me.Label8)
        Me.gbcabecera.Controls.Add(Me.txt_producto)
        Me.gbcabecera.Controls.Add(Me.Label7)
        Me.gbcabecera.Controls.Add(Me.lblsaldo)
        Me.gbcabecera.Controls.Add(Me.Label5)
        Me.gbcabecera.Controls.Add(Me.Label10)
        Me.gbcabecera.Controls.Add(Me.cmbmoneda)
        Me.gbcabecera.Controls.Add(Me.Label2)
        Me.gbcabecera.Controls.Add(Me.cboMoneda)
        Me.gbcabecera.Controls.Add(Me.Label6)
        Me.gbcabecera.Controls.Add(Me.dtpFecha)
        Me.gbcabecera.Controls.Add(Me.Label4)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.Label3)
        Me.gbcabecera.Controls.Add(Me.chkFormula)
        Me.gbcabecera.Location = New System.Drawing.Point(13, 35)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(816, 120)
        Me.gbcabecera.TabIndex = 195
        Me.gbcabecera.TabStop = False
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(10, 15)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles.Size = New System.Drawing.Size(716, 213)
        Me.dgvDetalles.TabIndex = 0
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.dgvDetalles)
        Me.gbDetalles.Location = New System.Drawing.Point(13, 161)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(738, 240)
        Me.gbDetalles.TabIndex = 196
        Me.gbDetalles.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(7, 32)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(59, 53)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnquitar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.Location = New System.Drawing.Point(7, 94)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(59, 53)
        Me.btnquitar.TabIndex = 15
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'gbOpciones
        '
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.ForeColor = System.Drawing.Color.Navy
        Me.gbOpciones.Location = New System.Drawing.Point(757, 161)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(72, 240)
        Me.gbOpciones.TabIndex = 198
        Me.gbOpciones.TabStop = False
        '
        'FrmManufactura_Liquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(841, 411)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbcabecera)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmManufactura_Liquidacion"
        Me.Text = "Liquidaciones de Ordenes de Fabricación"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalles.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_GenerarOf As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents cboMostrar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_liquidacion_manual As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFormula As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbmoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblsaldo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_num_lote As System.Windows.Forms.TextBox
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
End Class
