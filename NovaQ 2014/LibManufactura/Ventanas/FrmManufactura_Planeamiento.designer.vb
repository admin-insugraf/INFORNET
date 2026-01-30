<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManufactura_Planeamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManufactura_Planeamiento))
        Me.cboMostrar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.cboalmacen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpAño = New System.Windows.Forms.DateTimePicker()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_genera_xls = New System.Windows.Forms.ToolStripButton()
        Me.btn_Materiales = New System.Windows.Forms.ToolStripButton()
        Me.btn_GenerarOf = New System.Windows.Forms.ToolStripButton()
        Me.btn_terminarof = New System.Windows.Forms.ToolStripButton()
        Me.btn_adicional = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.pnlterminar = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtp_vcto_lote = New System.Windows.Forms.DateTimePicker()
        Me.txt_num_lote = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_confirmartermino = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtp_terminar = New System.Windows.Forms.DateTimePicker()
        Me.txtcatidadterminar = New System.Windows.Forms.TextBox()
        Me.pnlGenerar = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_numero_lote = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.pnl_adicionales = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvdetalles_adicional = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txt_lote_detalle = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtcodigo_adicional = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkFormula = New System.Windows.Forms.CheckBox()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.gbcabecera.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlterminar.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlGenerar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnl_adicionales.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvdetalles_adicional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMostrar
        '
        Me.cboMostrar.FormattingEnabled = True
        Me.cboMostrar.Items.AddRange(New Object() {"-Todas--", "Planificacion", "Produccion", "Anuladas", "Terminadas"})
        Me.cboMostrar.Location = New System.Drawing.Point(63, 30)
        Me.cboMostrar.Name = "cboMostrar"
        Me.cboMostrar.Size = New System.Drawing.Size(177, 21)
        Me.cboMostrar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
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
        Me.dgvCabecera.Location = New System.Drawing.Point(12, 72)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.Size = New System.Drawing.Size(928, 420)
        Me.dgvCabecera.TabIndex = 2
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Controls.Add(Me.cboMostrar)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Location = New System.Drawing.Point(10, 38)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(952, 503)
        Me.pnlCabecera.TabIndex = 177
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(268, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 45)
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
        Me.gbRangofechas.Location = New System.Drawing.Point(452, 14)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 123
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(230, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Año"
        '
        'gbcabecera
        '
        Me.gbcabecera.Controls.Add(Me.cboalmacen)
        Me.gbcabecera.Controls.Add(Me.Label4)
        Me.gbcabecera.Controls.Add(Me.dtpAño)
        Me.gbcabecera.Controls.Add(Me.cboMes)
        Me.gbcabecera.Controls.Add(Me.Label2)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.Label5)
        Me.gbcabecera.Controls.Add(Me.Label3)
        Me.gbcabecera.Location = New System.Drawing.Point(12, 38)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(755, 79)
        Me.gbcabecera.TabIndex = 178
        Me.gbcabecera.TabStop = False
        '
        'cboalmacen
        '
        Me.cboalmacen.FormattingEnabled = True
        Me.cboalmacen.Location = New System.Drawing.Point(77, 43)
        Me.cboalmacen.Name = "cboalmacen"
        Me.cboalmacen.Size = New System.Drawing.Size(292, 21)
        Me.cboalmacen.TabIndex = 180
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(13, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Almacen"
        '
        'dtpAño
        '
        Me.dtpAño.CustomFormat = "yyyy"
        Me.dtpAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAño.Location = New System.Drawing.Point(262, 16)
        Me.dtpAño.Name = "dtpAño"
        Me.dtpAño.Size = New System.Drawing.Size(107, 20)
        Me.dtpAño.TabIndex = 184
        '
        'cboMes
        '
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(77, 15)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(147, 21)
        Me.cboMes.TabIndex = 184
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtcodigo.Location = New System.Drawing.Point(77, 70)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(147, 24)
        Me.txtcodigo.TabIndex = 6
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcodigo.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(9, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nro O.F"
        Me.Label5.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(9, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mes de Fab."
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.dgvDetalles)
        Me.gbDetalles.Location = New System.Drawing.Point(10, 123)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(855, 408)
        Me.gbDetalles.TabIndex = 179
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
        Me.dgvDetalles.Location = New System.Drawing.Point(10, 10)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.Size = New System.Drawing.Size(838, 392)
        Me.dgvDetalles.TabIndex = 0
        '
        'txtComentario
        '
        Me.txtComentario.BackColor = System.Drawing.Color.White
        Me.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComentario.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtComentario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentario.Location = New System.Drawing.Point(827, 99)
        Me.txtComentario.MaxLength = 355
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentario.Size = New System.Drawing.Size(639, 20)
        Me.txtComentario.TabIndex = 180
        Me.txtComentario.Text = " "
        Me.txtComentario.Visible = False
        '
        'gbOpciones
        '
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.ForeColor = System.Drawing.Color.Navy
        Me.gbOpciones.Location = New System.Drawing.Point(871, 167)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(72, 203)
        Me.gbOpciones.TabIndex = 182
        Me.gbOpciones.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(7, 79)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(58, 41)
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
        Me.btnquitar.Location = New System.Drawing.Point(7, 139)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(58, 41)
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
        Me.btnAgregar.Location = New System.Drawing.Point(7, 22)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(58, 41)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(832, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Comentarios / Observacione"
        Me.Label7.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnEliminar, Me.btnGrabar, Me.btnImprimir, Me.btn_genera_xls, Me.btn_Materiales, Me.btn_GenerarOf, Me.btn_terminarof, Me.btn_adicional, Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(974, 25)
        Me.ToolStrip1.TabIndex = 184
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 22)
        Me.btnEliminar.Text = "&Anular"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(66, 22)
        Me.btnGrabar.Text = "&Grabar"
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
        'btn_genera_xls
        '
        Me.btn_genera_xls.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_genera_xls.Image = CType(resources.GetObject("btn_genera_xls.Image"), System.Drawing.Image)
        Me.btn_genera_xls.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_genera_xls.Name = "btn_genera_xls"
        Me.btn_genera_xls.Size = New System.Drawing.Size(144, 22)
        Me.btn_genera_xls.Text = "Generar formato .xls"
        '
        'btn_Materiales
        '
        Me.btn_Materiales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Materiales.Image = CType(resources.GetObject("btn_Materiales.Image"), System.Drawing.Image)
        Me.btn_Materiales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Materiales.Name = "btn_Materiales"
        Me.btn_Materiales.Size = New System.Drawing.Size(87, 22)
        Me.btn_Materiales.Text = "&Materiales"
        Me.btn_Materiales.Visible = False
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
        Me.btn_GenerarOf.Visible = False
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
        Me.btn_terminarof.Visible = False
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
        Me.btn_adicional.Visible = False
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
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 20)
        Me.btn_salir.Text = "&Salir"
        '
        'pnlterminar
        '
        Me.pnlterminar.BackColor = System.Drawing.Color.White
        Me.pnlterminar.Controls.Add(Me.GroupBox3)
        Me.pnlterminar.Controls.Add(Me.TextBox1)
        Me.pnlterminar.Controls.Add(Me.Button1)
        Me.pnlterminar.Controls.Add(Me.btn_confirmartermino)
        Me.pnlterminar.Controls.Add(Me.GroupBox1)
        Me.pnlterminar.Location = New System.Drawing.Point(267, 38)
        Me.pnlterminar.Name = "pnlterminar"
        Me.pnlterminar.Size = New System.Drawing.Size(411, 246)
        Me.pnlterminar.TabIndex = 195
        Me.pnlterminar.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(15, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "N° Lote"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(15, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "F. Vcto."
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
        Me.TextBox1.Size = New System.Drawing.Size(411, 19)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtp_terminar)
        Me.GroupBox1.Controls.Add(Me.txtcatidadterminar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(30, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(17, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 182
        Me.Label9.Text = "Cantidad Terminada"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(17, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 181
        Me.Label10.Text = "Fecha Terminada"
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
        'pnlGenerar
        '
        Me.pnlGenerar.BackColor = System.Drawing.Color.White
        Me.pnlGenerar.Controls.Add(Me.TextBox3)
        Me.pnlGenerar.Controls.Add(Me.btn_cancelar)
        Me.pnlGenerar.Controls.Add(Me.btn_generar)
        Me.pnlGenerar.Controls.Add(Me.GroupBox4)
        Me.pnlGenerar.Location = New System.Drawing.Point(301, 38)
        Me.pnlGenerar.Name = "pnlGenerar"
        Me.pnlGenerar.Size = New System.Drawing.Size(407, 166)
        Me.pnlGenerar.TabIndex = 194
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
        Me.btn_cancelar.Location = New System.Drawing.Point(211, 121)
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
        Me.btn_generar.Location = New System.Drawing.Point(139, 121)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(65, 39)
        Me.btn_generar.TabIndex = 124
        Me.btn_generar.Text = "Confirmar"
        Me.btn_generar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txt_numero_lote)
        Me.GroupBox4.Controls.Add(Me.dtpFecha)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(30, 33)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(351, 83)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Elegir Fecha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(25, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 183
        Me.Label11.Text = "N° Lote"
        '
        'txt_numero_lote
        '
        Me.txt_numero_lote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_lote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_lote.ForeColor = System.Drawing.Color.Navy
        Me.txt_numero_lote.Location = New System.Drawing.Point(79, 47)
        Me.txt_numero_lote.Name = "txt_numero_lote"
        Me.txt_numero_lote.Size = New System.Drawing.Size(200, 26)
        Me.txt_numero_lote.TabIndex = 182
        Me.txt_numero_lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(79, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'pnl_adicionales
        '
        Me.pnl_adicionales.Controls.Add(Me.GroupBox5)
        Me.pnl_adicionales.Controls.Add(Me.GroupBox6)
        Me.pnl_adicionales.Controls.Add(Me.GroupBox7)
        Me.pnl_adicionales.Location = New System.Drawing.Point(10, 38)
        Me.pnl_adicionales.Name = "pnl_adicionales"
        Me.pnl_adicionales.Size = New System.Drawing.Size(952, 503)
        Me.pnl_adicionales.TabIndex = 196
        Me.pnl_adicionales.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(764, 140)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 240)
        Me.GroupBox5.TabIndex = 204
        Me.GroupBox5.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(7, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 44)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "&Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(7, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 44)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "&Quitar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(7, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 44)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "&Agregar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.dgvdetalles_adicional)
        Me.GroupBox6.Location = New System.Drawing.Point(20, 140)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(738, 347)
        Me.GroupBox6.TabIndex = 203
        Me.GroupBox6.TabStop = False
        '
        'dgvdetalles_adicional
        '
        Me.dgvdetalles_adicional.AllowUserToAddRows = False
        Me.dgvdetalles_adicional.AllowUserToDeleteRows = False
        Me.dgvdetalles_adicional.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdetalles_adicional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles_adicional.Location = New System.Drawing.Point(10, 15)
        Me.dgvdetalles_adicional.Name = "dgvdetalles_adicional"
        Me.dgvdetalles_adicional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdetalles_adicional.Size = New System.Drawing.Size(716, 320)
        Me.dgvdetalles_adicional.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txt_lote_detalle)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.txt_producto)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.cboMoneda)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.txtcodigo_adicional)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.chkFormula)
        Me.GroupBox7.Location = New System.Drawing.Point(20, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(816, 120)
        Me.GroupBox7.TabIndex = 202
        Me.GroupBox7.TabStop = False
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(466, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 198
        Me.Label12.Text = "N° Lote"
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(24, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 196
        Me.Label13.Text = "Producto"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(230, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Almacen"
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 185)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Moneda"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(294, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(248, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Fecha"
        '
        'txtcodigo_adicional
        '
        Me.txtcodigo_adicional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo_adicional.Enabled = False
        Me.txtcodigo_adicional.Location = New System.Drawing.Point(78, 15)
        Me.txtcodigo_adicional.Name = "txtcodigo_adicional"
        Me.txtcodigo_adicional.ReadOnly = True
        Me.txtcodigo_adicional.Size = New System.Drawing.Size(146, 20)
        Me.txtcodigo_adicional.TabIndex = 1
        Me.txtcodigo_adicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(32, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "N° O.F."
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
        'FrmManufactura_Planeamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 545)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.pnl_adicionales)
        Me.Controls.Add(Me.pnlterminar)
        Me.Controls.Add(Me.pnlGenerar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbcabecera)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmManufactura_Planeamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planeamiento"
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        Me.gbDetalles.ResumeLayout(False)
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlterminar.ResumeLayout(False)
        Me.pnlterminar.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlGenerar.ResumeLayout(False)
        Me.pnlGenerar.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.pnl_adicionales.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvdetalles_adicional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMostrar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents txtComentario As System.Windows.Forms.RichTextBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents dtpAño As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Materiales As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_GenerarOf As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_terminarof As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_adicional As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlterminar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_vcto_lote As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_num_lote As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_confirmartermino As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtp_terminar As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcatidadterminar As System.Windows.Forms.TextBox
    Friend WithEvents pnlGenerar As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_lote As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnl_adicionales As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdetalles_adicional As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_lote_detalle As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo_adicional As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkFormula As System.Windows.Forms.CheckBox
    Friend WithEvents btn_genera_xls As System.Windows.Forms.ToolStripButton
End Class
