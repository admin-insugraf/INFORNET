<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManufactura_Generacion_Orden_Fabricacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManufactura_Generacion_Orden_Fabricacion))
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.cboMostrar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlGenerar = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_numero_lote = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_GenerarOf = New System.Windows.Forms.ToolStripButton()
        Me.btn_terminarof = New System.Windows.Forms.ToolStripButton()
        Me.btn_adicional = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancel = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.pnlterminar = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_vcto_lote = New System.Windows.Forms.DateTimePicker()
        Me.txt_num_lote = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_confirmartermino = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_terminar = New System.Windows.Forms.DateTimePicker()
        Me.txtcatidadterminar = New System.Windows.Forms.TextBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.txt_lote_detalle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkFormula = New System.Windows.Forms.CheckBox()
        Me.btn_genera_xls = New System.Windows.Forms.ToolStripButton()
        Me.pnlCabecera.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGenerar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlterminar.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.GroupBox4)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Controls.Add(Me.cboMostrar)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Location = New System.Drawing.Point(9, 31)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(862, 376)
        Me.pnlCabecera.TabIndex = 190
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(270, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(183, 45)
        Me.GroupBox4.TabIndex = 124
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
        Me.gbRangofechas.Location = New System.Drawing.Point(454, 9)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 125
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
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(19, 60)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(840, 308)
        Me.dgvCabecera.TabIndex = 2
        '
        'cboMostrar
        '
        Me.cboMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMostrar.FormattingEnabled = True
        Me.cboMostrar.Items.AddRange(New Object() {"-Todas--", "Planificacion", "Produccion", "Anuladas", "Terminadas"})
        Me.cboMostrar.Location = New System.Drawing.Point(63, 26)
        Me.cboMostrar.Name = "cboMostrar"
        Me.cboMostrar.Size = New System.Drawing.Size(177, 21)
        Me.cboMostrar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mostrar"
        '
        'pnlGenerar
        '
        Me.pnlGenerar.BackColor = System.Drawing.Color.White
        Me.pnlGenerar.Controls.Add(Me.TextBox3)
        Me.pnlGenerar.Controls.Add(Me.btn_cancelar)
        Me.pnlGenerar.Controls.Add(Me.btn_generar)
        Me.pnlGenerar.Controls.Add(Me.GroupBox1)
        Me.pnlGenerar.Location = New System.Drawing.Point(308, 76)
        Me.pnlGenerar.Name = "pnlGenerar"
        Me.pnlGenerar.Size = New System.Drawing.Size(407, 166)
        Me.pnlGenerar.TabIndex = 6
        Me.pnlGenerar.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Navy
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(0, 0)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(407, 19)
        Me.TextBox3.TabIndex = 169
        Me.TextBox3.Text = "GENERACION DE ORDEN DE FABRICACION"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(206, 121)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(65, 39)
        Me.btn_cancelar.TabIndex = 123
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_generar
        '
        Me.btn_generar.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generar.ForeColor = System.Drawing.Color.Navy
        Me.btn_generar.Image = CType(resources.GetObject("btn_generar.Image"), System.Drawing.Image)
        Me.btn_generar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_generar.Location = New System.Drawing.Point(134, 121)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(65, 39)
        Me.btn_generar.TabIndex = 124
        Me.btn_generar.Text = "Confirmar"
        Me.btn_generar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_numero_lote)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(30, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(13, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "Fecha de Fab."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(46, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "N° Lote"
        '
        'txt_numero_lote
        '
        Me.txt_numero_lote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_lote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_lote.ForeColor = System.Drawing.Color.Navy
        Me.txt_numero_lote.Location = New System.Drawing.Point(100, 47)
        Me.txt_numero_lote.Name = "txt_numero_lote"
        Me.txt_numero_lote.Size = New System.Drawing.Size(200, 26)
        Me.txt_numero_lote.TabIndex = 182
        Me.txt_numero_lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(100, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_GenerarOf, Me.btn_terminarof, Me.btn_adicional, Me.btnGrabar, Me.btn_Imprimir, Me.btn_genera_xls, Me.btn_cancel, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(883, 25)
        Me.ToolStrip1.TabIndex = 191
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_GenerarOf
        '
        Me.btn_GenerarOf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GenerarOf.ForeColor = System.Drawing.Color.Navy
        Me.btn_GenerarOf.Image = CType(resources.GetObject("btn_GenerarOf.Image"), System.Drawing.Image)
        Me.btn_GenerarOf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_GenerarOf.Name = "btn_GenerarOf"
        Me.btn_GenerarOf.Size = New System.Drawing.Size(90, 22)
        Me.btn_GenerarOf.Text = "&Generar OF"
        '
        'btn_terminarof
        '
        Me.btn_terminarof.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_terminarof.ForeColor = System.Drawing.Color.Navy
        Me.btn_terminarof.Image = CType(resources.GetObject("btn_terminarof.Image"), System.Drawing.Image)
        Me.btn_terminarof.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_terminarof.Name = "btn_terminarof"
        Me.btn_terminarof.Size = New System.Drawing.Size(96, 22)
        Me.btn_terminarof.Text = "&Terminar OF"
        '
        'btn_adicional
        '
        Me.btn_adicional.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_adicional.ForeColor = System.Drawing.Color.Navy
        Me.btn_adicional.Image = CType(resources.GetObject("btn_adicional.Image"), System.Drawing.Image)
        Me.btn_adicional.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_adicional.Name = "btn_adicional"
        Me.btn_adicional.Size = New System.Drawing.Size(91, 22)
        Me.btn_adicional.Text = "Adicionales"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGrabar.ForeColor = System.Drawing.Color.Navy
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(66, 22)
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.Visible = False
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
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancel.Text = "Cancelar"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Navy
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'pnlterminar
        '
        Me.pnlterminar.BackColor = System.Drawing.Color.White
        Me.pnlterminar.Controls.Add(Me.GroupBox3)
        Me.pnlterminar.Controls.Add(Me.TextBox1)
        Me.pnlterminar.Controls.Add(Me.Button1)
        Me.pnlterminar.Controls.Add(Me.btn_confirmartermino)
        Me.pnlterminar.Controls.Add(Me.GroupBox2)
        Me.pnlterminar.Location = New System.Drawing.Point(274, 76)
        Me.pnlterminar.Name = "pnlterminar"
        Me.pnlterminar.Size = New System.Drawing.Size(415, 246)
        Me.pnlterminar.TabIndex = 193
        Me.pnlterminar.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtp_vcto_lote)
        Me.GroupBox3.Controls.Add(Me.txt_num_lote)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(32, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(351, 78)
        Me.GroupBox3.TabIndex = 170
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Lote Fabricado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(15, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "N° Lote"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(15, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "F. Vcto."
        '
        'dtp_vcto_lote
        '
        Me.dtp_vcto_lote.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_vcto_lote.Location = New System.Drawing.Point(69, 19)
        Me.dtp_vcto_lote.Name = "dtp_vcto_lote"
        Me.dtp_vcto_lote.Size = New System.Drawing.Size(103, 20)
        Me.dtp_vcto_lote.TabIndex = 1
        '
        'txt_num_lote
        '
        Me.txt_num_lote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_lote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_lote.ForeColor = System.Drawing.Color.Navy
        Me.txt_num_lote.Location = New System.Drawing.Point(69, 46)
        Me.txt_num_lote.Name = "txt_num_lote"
        Me.txt_num_lote.ReadOnly = True
        Me.txt_num_lote.Size = New System.Drawing.Size(226, 26)
        Me.txt_num_lote.TabIndex = 0
        Me.txt_num_lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(415, 19)
        Me.TextBox1.TabIndex = 169
        Me.TextBox1.Text = "TERMINAR ORDEN DE FABRICACION"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(212, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 39)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_confirmartermino
        '
        Me.btn_confirmartermino.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btn_confirmartermino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmartermino.ForeColor = System.Drawing.Color.Navy
        Me.btn_confirmartermino.Image = CType(resources.GetObject("btn_confirmartermino.Image"), System.Drawing.Image)
        Me.btn_confirmartermino.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_confirmartermino.Location = New System.Drawing.Point(142, 201)
        Me.btn_confirmartermino.Name = "btn_confirmartermino"
        Me.btn_confirmartermino.Size = New System.Drawing.Size(63, 39)
        Me.btn_confirmartermino.TabIndex = 124
        Me.btn_confirmartermino.Text = "Confirmar"
        Me.btn_confirmartermino.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_confirmartermino.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtp_terminar)
        Me.GroupBox2.Controls.Add(Me.txtcatidadterminar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(30, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 78)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(17, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "Cantidad Terminada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(17, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "Fecha Terminada"
        '
        'dtp_terminar
        '
        Me.dtp_terminar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_terminar.Location = New System.Drawing.Point(124, 19)
        Me.dtp_terminar.Name = "dtp_terminar"
        Me.dtp_terminar.Size = New System.Drawing.Size(105, 20)
        Me.dtp_terminar.TabIndex = 1
        '
        'txtcatidadterminar
        '
        Me.txtcatidadterminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcatidadterminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcatidadterminar.ForeColor = System.Drawing.Color.Navy
        Me.txtcatidadterminar.Location = New System.Drawing.Point(124, 46)
        Me.txtcatidadterminar.Name = "txtcatidadterminar"
        Me.txtcatidadterminar.Size = New System.Drawing.Size(137, 26)
        Me.txtcatidadterminar.TabIndex = 0
        Me.txtcatidadterminar.Text = "0.0"
        Me.txtcatidadterminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbOpciones
        '
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnimprimir)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.ForeColor = System.Drawing.Color.Navy
        Me.gbOpciones.Location = New System.Drawing.Point(774, 162)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(72, 240)
        Me.gbOpciones.TabIndex = 201
        Me.gbOpciones.TabStop = False
        '
        'btnimprimir
        '
        Me.btnimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnimprimir.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
        Me.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnimprimir.Location = New System.Drawing.Point(7, 156)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(59, 44)
        Me.btnimprimir.TabIndex = 16
        Me.btnimprimir.Text = "&Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnquitar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnquitar.Location = New System.Drawing.Point(7, 94)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(59, 44)
        Me.btnquitar.TabIndex = 15
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(7, 32)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(59, 44)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.dgvDetalles)
        Me.gbDetalles.Location = New System.Drawing.Point(30, 162)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(738, 240)
        Me.gbDetalles.TabIndex = 200
        Me.gbDetalles.TabStop = False
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
        'gbcabecera
        '
        Me.gbcabecera.Controls.Add(Me.txt_lote_detalle)
        Me.gbcabecera.Controls.Add(Me.Label8)
        Me.gbcabecera.Controls.Add(Me.txt_producto)
        Me.gbcabecera.Controls.Add(Me.Label7)
        Me.gbcabecera.Controls.Add(Me.Label11)
        Me.gbcabecera.Controls.Add(Me.cboMoneda)
        Me.gbcabecera.Controls.Add(Me.Label12)
        Me.gbcabecera.Controls.Add(Me.DateTimePicker1)
        Me.gbcabecera.Controls.Add(Me.Label13)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.Label14)
        Me.gbcabecera.Controls.Add(Me.chkFormula)
        Me.gbcabecera.Location = New System.Drawing.Point(30, 36)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(816, 120)
        Me.gbcabecera.TabIndex = 199
        Me.gbcabecera.TabStop = False
        '
        'txt_lote_detalle
        '
        Me.txt_lote_detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lote_detalle.Enabled = False
        Me.txt_lote_detalle.Location = New System.Drawing.Point(512, 69)
        Me.txt_lote_detalle.Name = "txt_lote_detalle"
        Me.txt_lote_detalle.ReadOnly = True
        Me.txt_lote_detalle.Size = New System.Drawing.Size(146, 20)
        Me.txt_lote_detalle.TabIndex = 199
        Me.txt_lote_detalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(230, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Almacen"
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Moneda"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(294, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(248, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Fecha"
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(32, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "N° O.F."
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
        'btn_genera_xls
        '
        Me.btn_genera_xls.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_genera_xls.ForeColor = System.Drawing.Color.Navy
        Me.btn_genera_xls.Image = CType(resources.GetObject("btn_genera_xls.Image"), System.Drawing.Image)
        Me.btn_genera_xls.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_genera_xls.Name = "btn_genera_xls"
        Me.btn_genera_xls.Size = New System.Drawing.Size(144, 22)
        Me.btn_genera_xls.Text = "Generar formato .xls"
        '
        'FrmManufactura_Generacion_Orden_Fabricacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 411)
        Me.Controls.Add(Me.pnlGenerar)
        Me.Controls.Add(Me.pnlterminar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbcabecera)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmManufactura_Generacion_Orden_Fabricacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Fabricacion"
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGenerar.ResumeLayout(False)
        Me.pnlGenerar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlterminar.ResumeLayout(False)
        Me.pnlterminar.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbDetalles.ResumeLayout(False)
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents cboMostrar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlGenerar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_GenerarOf As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_terminarof As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlterminar As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_confirmartermino As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_terminar As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcatidadterminar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_vcto_lote As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_num_lote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_lote As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_adicional As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents txt_lote_detalle As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkFormula As System.Windows.Forms.CheckBox
    Friend WithEvents btn_cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_genera_xls As System.Windows.Forms.ToolStripButton
End Class
