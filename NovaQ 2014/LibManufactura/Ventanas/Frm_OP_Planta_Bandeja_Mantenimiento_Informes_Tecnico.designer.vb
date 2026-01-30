<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OP_Planta_Bandeja_Mantenimiento_Informes_Tecnico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_OP_Planta_Bandeja_Mantenimiento_Informes_Tecnico))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_actualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
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
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cargo_responsable = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_nombre_responsable = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbo_estado = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtp_fecha_acontecimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Cargo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txt_solicita_cliente = New System.Windows.Forms.RichTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_redaccion_hechos = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gb_cargararchivo = New System.Windows.Forms.GroupBox()
        Me.dgv_lista_archivos_dd = New System.Windows.Forms.DataGridView()
        Me.ITEM_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_ARCHIVO_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_agregar_archivo_dd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_descripcion_archivo_dd = New System.Windows.Forms.TextBox()
        Me.txt_ruta_archivo_dd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_ruta_archivo_dd = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_conclusion = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_acciones_correctivas = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_acciones_inmediatas = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_des_cliente = New System.Windows.Forms.TextBox()
        Me.txt_cod_cliente = New System.Windows.Forms.TextBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_contacto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btn_menu.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tc_principal.SuspendLayout()
        Me.tc_datos.SuspendLayout()
        Me.GbCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gb_cargararchivo.SuspendLayout()
        CType(Me.dgv_lista_archivos_dd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btnImprimir, Me.btn_actualizar, Me.btnCancelar, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(1020, 25)
        Me.btn_menu.TabIndex = 201
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
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_actualizar.Image = CType(resources.GetObject("btn_actualizar.Image"), System.Drawing.Image)
        Me.btn_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(84, 22)
        Me.btn_actualizar.Text = "&Actualizar"
        Me.btn_actualizar.Visible = False
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
        Me.pnlCabecera.Location = New System.Drawing.Point(8, 47)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1000, 552)
        Me.pnlCabecera.TabIndex = 199
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
        Me.lblDetalle.Size = New System.Drawing.Size(986, 20)
        Me.lblDetalle.TabIndex = 195
        Me.lblDetalle.Text = "LISTADO DE ATENCION DE QUEJAS Y RECLAMOS"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(11, 526)
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
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
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
        Me.dgvCabecera.Size = New System.Drawing.Size(986, 418)
        Me.dgvCabecera.TabIndex = 2
        '
        'Tc_principal
        '
        Me.Tc_principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tc_principal.Controls.Add(Me.tc_datos)
        Me.Tc_principal.Location = New System.Drawing.Point(8, 48)
        Me.Tc_principal.Multiline = True
        Me.Tc_principal.Name = "Tc_principal"
        Me.Tc_principal.SelectedIndex = 0
        Me.Tc_principal.Size = New System.Drawing.Size(999, 545)
        Me.Tc_principal.TabIndex = 200
        '
        'tc_datos
        '
        Me.tc_datos.BackColor = System.Drawing.Color.White
        Me.tc_datos.Controls.Add(Me.GbCabecera)
        Me.tc_datos.Location = New System.Drawing.Point(4, 22)
        Me.tc_datos.Name = "tc_datos"
        Me.tc_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_datos.Size = New System.Drawing.Size(991, 519)
        Me.tc_datos.TabIndex = 0
        Me.tc_datos.Text = "Detalle del Informe"
        '
        'GbCabecera
        '
        Me.GbCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.GroupBox1)
        Me.GbCabecera.Controls.Add(Me.cbo_estado)
        Me.GbCabecera.Controls.Add(Me.Label16)
        Me.GbCabecera.Controls.Add(Me.dtp_fecha_acontecimiento)
        Me.GbCabecera.Controls.Add(Me.Label12)
        Me.GbCabecera.Controls.Add(Me.txt_producto)
        Me.GbCabecera.Controls.Add(Me.Label11)
        Me.GbCabecera.Controls.Add(Me.txt_telefono)
        Me.GbCabecera.Controls.Add(Me.Label10)
        Me.GbCabecera.Controls.Add(Me.txt_correo)
        Me.GbCabecera.Controls.Add(Me.Label8)
        Me.GbCabecera.Controls.Add(Me.txt_Cargo)
        Me.GbCabecera.Controls.Add(Me.Label6)
        Me.GbCabecera.Controls.Add(Me.TabControl1)
        Me.GbCabecera.Controls.Add(Me.Label4)
        Me.GbCabecera.Controls.Add(Me.txt_des_cliente)
        Me.GbCabecera.Controls.Add(Me.txt_cod_cliente)
        Me.GbCabecera.Controls.Add(Me.dtp_fecha)
        Me.GbCabecera.Controls.Add(Me.Label9)
        Me.GbCabecera.Controls.Add(Me.cbo_tipo)
        Me.GbCabecera.Controls.Add(Me.Label7)
        Me.GbCabecera.Controls.Add(Me.txt_contacto)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.Label2)
        Me.GbCabecera.Controls.Add(Me.txtcodigo)
        Me.GbCabecera.Location = New System.Drawing.Point(3, 7)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(979, 506)
        Me.GbCabecera.TabIndex = 189
        Me.GbCabecera.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_cargo_responsable)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_responsable)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(21, 446)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 49)
        Me.GroupBox1.TabIndex = 322
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Responsable de la toma de acción"
        '
        'txt_cargo_responsable
        '
        Me.txt_cargo_responsable.BackColor = System.Drawing.Color.White
        Me.txt_cargo_responsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cargo_responsable.Location = New System.Drawing.Point(395, 19)
        Me.txt_cargo_responsable.MaxLength = 250
        Me.txt_cargo_responsable.Name = "txt_cargo_responsable"
        Me.txt_cargo_responsable.Size = New System.Drawing.Size(263, 20)
        Me.txt_cargo_responsable.TabIndex = 315
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(354, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 314
        Me.Label18.Text = "Cargo"
        '
        'txt_nombre_responsable
        '
        Me.txt_nombre_responsable.BackColor = System.Drawing.Color.White
        Me.txt_nombre_responsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre_responsable.Location = New System.Drawing.Point(64, 19)
        Me.txt_nombre_responsable.MaxLength = 250
        Me.txt_nombre_responsable.Name = "txt_nombre_responsable"
        Me.txt_nombre_responsable.Size = New System.Drawing.Size(263, 20)
        Me.txt_nombre_responsable.TabIndex = 313
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(13, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 312
        Me.Label17.Text = "Nombre"
        '
        'cbo_estado
        '
        Me.cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_estado.FormattingEnabled = True
        Me.cbo_estado.Items.AddRange(New Object() {"PENDIENTE", "ATENDIDO", "CERRADO"})
        Me.cbo_estado.Location = New System.Drawing.Point(738, 17)
        Me.cbo_estado.Name = "cbo_estado"
        Me.cbo_estado.Size = New System.Drawing.Size(173, 21)
        Me.cbo_estado.TabIndex = 321
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(693, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 320
        Me.Label16.Text = "Estado"
        '
        'dtp_fecha_acontecimiento
        '
        Me.dtp_fecha_acontecimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_acontecimiento.Location = New System.Drawing.Point(720, 182)
        Me.dtp_fecha_acontecimiento.Name = "dtp_fecha_acontecimiento"
        Me.dtp_fecha_acontecimiento.Size = New System.Drawing.Size(96, 20)
        Me.dtp_fecha_acontecimiento.TabIndex = 318
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(582, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 13)
        Me.Label12.TabIndex = 319
        Me.Label12.Text = "Fecha de Acontecimiento"
        '
        'txt_producto
        '
        Me.txt_producto.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_producto.Location = New System.Drawing.Point(21, 182)
        Me.txt_producto.MaxLength = 250
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(538, 20)
        Me.txt_producto.TabIndex = 317
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(21, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 316
        Me.Label11.Text = "Producto"
        '
        'txt_telefono
        '
        Me.txt_telefono.BackColor = System.Drawing.Color.White
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefono.Location = New System.Drawing.Point(582, 131)
        Me.txt_telefono.MaxLength = 250
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(263, 20)
        Me.txt_telefono.TabIndex = 315
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(582, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 314
        Me.Label10.Text = "Telefono"
        '
        'txt_correo
        '
        Me.txt_correo.BackColor = System.Drawing.Color.White
        Me.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_correo.Location = New System.Drawing.Point(296, 131)
        Me.txt_correo.MaxLength = 250
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(263, 20)
        Me.txt_correo.TabIndex = 313
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(296, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 312
        Me.Label8.Text = "Correo Electrónico"
        '
        'txt_Cargo
        '
        Me.txt_Cargo.BackColor = System.Drawing.Color.White
        Me.txt_Cargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cargo.Location = New System.Drawing.Point(21, 131)
        Me.txt_Cargo.MaxLength = 250
        Me.txt_Cargo.Name = "txt_Cargo"
        Me.txt_Cargo.Size = New System.Drawing.Size(263, 20)
        Me.txt_Cargo.TabIndex = 311
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(21, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 310
        Me.Label6.Text = "Cargo"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(21, 210)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(867, 228)
        Me.TabControl1.TabIndex = 309
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(859, 202)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Datos de los hechos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label54)
        Me.Panel1.Controls.Add(Me.txt_solicita_cliente)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.txt_redaccion_hechos)
        Me.Panel1.Location = New System.Drawing.Point(8, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 188)
        Me.Panel1.TabIndex = 306
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(8, 153)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(82, 52)
        Me.Label54.TabIndex = 237
        Me.Label54.Text = "¿Qué solicita el " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cliente para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "solucionar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el conflicto?"
        '
        'txt_solicita_cliente
        '
        Me.txt_solicita_cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_solicita_cliente.BackColor = System.Drawing.Color.LightYellow
        Me.txt_solicita_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_solicita_cliente.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_solicita_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_solicita_cliente.Location = New System.Drawing.Point(100, 153)
        Me.txt_solicita_cliente.MaxLength = 32767
        Me.txt_solicita_cliente.Name = "txt_solicita_cliente"
        Me.txt_solicita_cliente.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txt_solicita_cliente.Size = New System.Drawing.Size(432, 140)
        Me.txt_solicita_cliente.TabIndex = 236
        Me.txt_solicita_cliente.Text = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(7, 14)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 26)
        Me.Label30.TabIndex = 228
        Me.Label30.Text = "Redacción de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los hechos"
        '
        'txt_redaccion_hechos
        '
        Me.txt_redaccion_hechos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_redaccion_hechos.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_redaccion_hechos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_redaccion_hechos.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_redaccion_hechos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_redaccion_hechos.Location = New System.Drawing.Point(100, 5)
        Me.txt_redaccion_hechos.MaxLength = 32767
        Me.txt_redaccion_hechos.Name = "txt_redaccion_hechos"
        Me.txt_redaccion_hechos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txt_redaccion_hechos.Size = New System.Drawing.Size(432, 140)
        Me.txt_redaccion_hechos.TabIndex = 227
        Me.txt_redaccion_hechos.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gb_cargararchivo)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(859, 202)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Datos digitales"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gb_cargararchivo
        '
        Me.gb_cargararchivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_cargararchivo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gb_cargararchivo.Controls.Add(Me.dgv_lista_archivos_dd)
        Me.gb_cargararchivo.Controls.Add(Me.btn_agregar_archivo_dd)
        Me.gb_cargararchivo.Controls.Add(Me.Label1)
        Me.gb_cargararchivo.Controls.Add(Me.txt_descripcion_archivo_dd)
        Me.gb_cargararchivo.Controls.Add(Me.txt_ruta_archivo_dd)
        Me.gb_cargararchivo.Controls.Add(Me.Label5)
        Me.gb_cargararchivo.Controls.Add(Me.btn_ruta_archivo_dd)
        Me.gb_cargararchivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gb_cargararchivo.ForeColor = System.Drawing.Color.Navy
        Me.gb_cargararchivo.Location = New System.Drawing.Point(7, 10)
        Me.gb_cargararchivo.Name = "gb_cargararchivo"
        Me.gb_cargararchivo.Size = New System.Drawing.Size(839, 182)
        Me.gb_cargararchivo.TabIndex = 312
        Me.gb_cargararchivo.TabStop = False
        Me.gb_cargararchivo.Text = "Anexar Documentos"
        '
        'dgv_lista_archivos_dd
        '
        Me.dgv_lista_archivos_dd.AllowUserToAddRows = False
        Me.dgv_lista_archivos_dd.AllowUserToDeleteRows = False
        Me.dgv_lista_archivos_dd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista_archivos_dd.BackgroundColor = System.Drawing.Color.White
        Me.dgv_lista_archivos_dd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lista_archivos_dd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_lista_archivos_dd.ColumnHeadersHeight = 30
        Me.dgv_lista_archivos_dd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM_2, Me.DESCRIPCION_2, Me.NOMBRE_ARCHIVO_2, Me.DataGridViewImageColumn3, Me.DataGridViewImageColumn4})
        Me.dgv_lista_archivos_dd.EnableHeadersVisualStyles = False
        Me.dgv_lista_archivos_dd.Location = New System.Drawing.Point(15, 89)
        Me.dgv_lista_archivos_dd.Name = "dgv_lista_archivos_dd"
        Me.dgv_lista_archivos_dd.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lista_archivos_dd.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_lista_archivos_dd.RowHeadersVisible = False
        Me.dgv_lista_archivos_dd.RowHeadersWidth = 50
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_lista_archivos_dd.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_lista_archivos_dd.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_lista_archivos_dd.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy
        Me.dgv_lista_archivos_dd.RowTemplate.Height = 30
        Me.dgv_lista_archivos_dd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_archivos_dd.Size = New System.Drawing.Size(807, 75)
        Me.dgv_lista_archivos_dd.TabIndex = 124
        '
        'ITEM_2
        '
        Me.ITEM_2.DataPropertyName = "ITEM_2"
        Me.ITEM_2.Frozen = True
        Me.ITEM_2.HeaderText = "ITEM"
        Me.ITEM_2.Name = "ITEM_2"
        Me.ITEM_2.ReadOnly = True
        Me.ITEM_2.Width = 50
        '
        'DESCRIPCION_2
        '
        Me.DESCRIPCION_2.DataPropertyName = "DESCRIPCION_2"
        Me.DESCRIPCION_2.Frozen = True
        Me.DESCRIPCION_2.HeaderText = "DESCRIPCION DEL ARCHIVO"
        Me.DESCRIPCION_2.Name = "DESCRIPCION_2"
        Me.DESCRIPCION_2.ReadOnly = True
        Me.DESCRIPCION_2.Width = 400
        '
        'NOMBRE_ARCHIVO_2
        '
        Me.NOMBRE_ARCHIVO_2.DataPropertyName = "NOMBRE_ARCHIVO_2"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE_ARCHIVO_2.DefaultCellStyle = DataGridViewCellStyle8
        Me.NOMBRE_ARCHIVO_2.HeaderText = "NOMBRE ARCHIVO"
        Me.NOMBRE_ARCHIVO_2.Name = "NOMBRE_ARCHIVO_2"
        Me.NOMBRE_ARCHIVO_2.ReadOnly = True
        Me.NOMBRE_ARCHIVO_2.Visible = False
        Me.NOMBRE_ARCHIVO_2.Width = 130
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.DataPropertyName = "DESCARGAR"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.NullValue = CType(resources.GetObject("DataGridViewCellStyle9.NullValue"), Object)
        Me.DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewImageColumn3.HeaderText = "VISUALIZAR"
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.ToolTipText = "Descargar Archivo"
        Me.DataGridViewImageColumn3.Width = 80
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.DataPropertyName = "DELETE"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.NullValue = CType(resources.GetObject("DataGridViewCellStyle10.NullValue"), Object)
        Me.DataGridViewImageColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewImageColumn4.HeaderText = "ELIMINAR"
        Me.DataGridViewImageColumn4.Image = CType(resources.GetObject("DataGridViewImageColumn4.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.ReadOnly = True
        Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn4.ToolTipText = "Eliminar Archivo"
        Me.DataGridViewImageColumn4.Width = 80
        '
        'btn_agregar_archivo_dd
        '
        Me.btn_agregar_archivo_dd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar_archivo_dd.ForeColor = System.Drawing.Color.Navy
        Me.btn_agregar_archivo_dd.Image = CType(resources.GetObject("btn_agregar_archivo_dd.Image"), System.Drawing.Image)
        Me.btn_agregar_archivo_dd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar_archivo_dd.Location = New System.Drawing.Point(481, 54)
        Me.btn_agregar_archivo_dd.Name = "btn_agregar_archivo_dd"
        Me.btn_agregar_archivo_dd.Size = New System.Drawing.Size(79, 23)
        Me.btn_agregar_archivo_dd.TabIndex = 123
        Me.btn_agregar_archivo_dd.Text = "Agregar"
        Me.btn_agregar_archivo_dd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar_archivo_dd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(24, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Descripción del Archivo:"
        '
        'txt_descripcion_archivo_dd
        '
        Me.txt_descripcion_archivo_dd.BackColor = System.Drawing.Color.White
        Me.txt_descripcion_archivo_dd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcion_archivo_dd.Location = New System.Drawing.Point(183, 55)
        Me.txt_descripcion_archivo_dd.Name = "txt_descripcion_archivo_dd"
        Me.txt_descripcion_archivo_dd.Size = New System.Drawing.Size(292, 21)
        Me.txt_descripcion_archivo_dd.TabIndex = 121
        Me.txt_descripcion_archivo_dd.Tag = "Cliente"
        '
        'txt_ruta_archivo_dd
        '
        Me.txt_ruta_archivo_dd.Location = New System.Drawing.Point(183, 18)
        Me.txt_ruta_archivo_dd.Name = "txt_ruta_archivo_dd"
        Me.txt_ruta_archivo_dd.ReadOnly = True
        Me.txt_ruta_archivo_dd.Size = New System.Drawing.Size(292, 21)
        Me.txt_ruta_archivo_dd.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(74, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ruta de archivo"
        '
        'btn_ruta_archivo_dd
        '
        Me.btn_ruta_archivo_dd.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_ruta_archivo_dd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ruta_archivo_dd.Location = New System.Drawing.Point(481, 17)
        Me.btn_ruta_archivo_dd.Name = "btn_ruta_archivo_dd"
        Me.btn_ruta_archivo_dd.Size = New System.Drawing.Size(26, 23)
        Me.btn_ruta_archivo_dd.TabIndex = 7
        Me.btn_ruta_archivo_dd.Text = "..."
        Me.btn_ruta_archivo_dd.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(859, 202)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Acciones a Tomar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txt_conclusion)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txt_acciones_correctivas)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txt_acciones_inmediatas)
        Me.Panel2.Location = New System.Drawing.Point(9, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 188)
        Me.Panel2.TabIndex = 307
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(8, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 239
        Me.Label15.Text = "Conclusión"
        '
        'txt_conclusion
        '
        Me.txt_conclusion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_conclusion.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_conclusion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_conclusion.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_conclusion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_conclusion.Location = New System.Drawing.Point(100, 304)
        Me.txt_conclusion.MaxLength = 32767
        Me.txt_conclusion.Name = "txt_conclusion"
        Me.txt_conclusion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txt_conclusion.Size = New System.Drawing.Size(415, 140)
        Me.txt_conclusion.TabIndex = 238
        Me.txt_conclusion.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(8, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 26)
        Me.Label13.TabIndex = 237
        Me.Label13.Text = "Acciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Correctivas"
        '
        'txt_acciones_correctivas
        '
        Me.txt_acciones_correctivas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_acciones_correctivas.BackColor = System.Drawing.Color.LightYellow
        Me.txt_acciones_correctivas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_acciones_correctivas.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_acciones_correctivas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_acciones_correctivas.Location = New System.Drawing.Point(100, 153)
        Me.txt_acciones_correctivas.MaxLength = 32767
        Me.txt_acciones_correctivas.Name = "txt_acciones_correctivas"
        Me.txt_acciones_correctivas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txt_acciones_correctivas.Size = New System.Drawing.Size(415, 140)
        Me.txt_acciones_correctivas.TabIndex = 236
        Me.txt_acciones_correctivas.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(7, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 26)
        Me.Label14.TabIndex = 228
        Me.Label14.Text = "Acciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inmediatas"
        '
        'txt_acciones_inmediatas
        '
        Me.txt_acciones_inmediatas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_acciones_inmediatas.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_acciones_inmediatas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_acciones_inmediatas.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_acciones_inmediatas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_acciones_inmediatas.Location = New System.Drawing.Point(100, 5)
        Me.txt_acciones_inmediatas.MaxLength = 32767
        Me.txt_acciones_inmediatas.Name = "txt_acciones_inmediatas"
        Me.txt_acciones_inmediatas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txt_acciones_inmediatas.Size = New System.Drawing.Size(415, 140)
        Me.txt_acciones_inmediatas.TabIndex = 227
        Me.txt_acciones_inmediatas.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(21, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 286
        Me.Label4.Text = "Cliente"
        '
        'txt_des_cliente
        '
        Me.txt_des_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_cliente.Enabled = False
        Me.txt_des_cliente.Location = New System.Drawing.Point(106, 81)
        Me.txt_des_cliente.Name = "txt_des_cliente"
        Me.txt_des_cliente.Size = New System.Drawing.Size(345, 20)
        Me.txt_des_cliente.TabIndex = 284
        '
        'txt_cod_cliente
        '
        Me.txt_cod_cliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_cliente.Location = New System.Drawing.Point(21, 81)
        Me.txt_cod_cliente.Name = "txt_cod_cliente"
        Me.txt_cod_cliente.ReadOnly = True
        Me.txt_cod_cliente.Size = New System.Drawing.Size(79, 20)
        Me.txt_cod_cliente.TabIndex = 283
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(240, 17)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(96, 20)
        Me.dtp_fecha.TabIndex = 279
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(192, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 280
        Me.Label9.Text = "Fecha"
        '
        'cbo_tipo
        '
        Me.cbo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Items.AddRange(New Object() {"QUEJA", "RECLAMO"})
        Me.cbo_tipo.Location = New System.Drawing.Point(451, 17)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(173, 21)
        Me.cbo_tipo.TabIndex = 276
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(412, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 275
        Me.Label7.Text = "Tipo"
        '
        'txt_contacto
        '
        Me.txt_contacto.BackColor = System.Drawing.Color.White
        Me.txt_contacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_contacto.Location = New System.Drawing.Point(475, 81)
        Me.txt_contacto.MaxLength = 250
        Me.txt_contacto.Name = "txt_contacto"
        Me.txt_contacto.Size = New System.Drawing.Size(430, 20)
        Me.txt_contacto.TabIndex = 270
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(475, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 269
        Me.Label3.Text = "Contacto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(23, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "N°"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.ForeColor = System.Drawing.Color.Maroon
        Me.txtcodigo.Location = New System.Drawing.Point(47, 17)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(110, 20)
        Me.txtcodigo.TabIndex = 210
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_OP_Planta_Bandeja_Mantenimiento_Informes_Tecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 604)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.Tc_principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_OP_Planta_Bandeja_Mantenimiento_Informes_Tecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Atención de Quejas y Reclamos"
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
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.gb_cargararchivo.ResumeLayout(False)
        Me.gb_cargararchivo.PerformLayout()
        CType(Me.dgv_lista_archivos_dd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_actualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_contacto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_des_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_cliente As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txt_solicita_cliente As System.Windows.Forms.RichTextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_redaccion_hechos As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents gb_cargararchivo As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_lista_archivos_dd As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar_archivo_dd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion_archivo_dd As System.Windows.Forms.TextBox
    Friend WithEvents txt_ruta_archivo_dd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_ruta_archivo_dd As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha_acontecimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Cargo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_conclusion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_acciones_correctivas As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_acciones_inmediatas As System.Windows.Forms.RichTextBox
    Friend WithEvents ITEM_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_ARCHIVO_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cbo_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cargo_responsable As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_responsable As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
