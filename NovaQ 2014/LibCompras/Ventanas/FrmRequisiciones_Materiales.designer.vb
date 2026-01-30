<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequisiciones_Materiales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRequisiciones_Materiales))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboareas = New System.Windows.Forms.ComboBox()
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.pnl_stock = New System.Windows.Forms.Panel()
        Me.dgv_stock = New System.Windows.Forms.DataGridView()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.txt_orden_produccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnquitar_2 = New System.Windows.Forms.Button()
        Me.btnModificar_2 = New System.Windows.Forms.Button()
        Me.btnAgregar_2 = New System.Windows.Forms.Button()
        Me.txtobservacion_2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcantidad_2 = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txtunidadMedida_2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionArticulo_2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcodigoArticulo_2 = New System.Windows.Forms.TextBox()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdb_sol_complementos = New System.Windows.Forms.RadioButton()
        Me.rdb_sol_mp = New System.Windows.Forms.RadioButton()
        Me.rdb_campoy = New System.Windows.Forms.RadioButton()
        Me.rdb_breña = New System.Windows.Forms.RadioButton()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txttipoDoc = New System.Windows.Forms.TextBox()
        Me.dtpFechad = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcion_area = New System.Windows.Forms.TextBox()
        Me.txtdescripcion_solicitante = New System.Windows.Forms.TextBox()
        Me.txtsolicitante = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.gbdetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcomentario = New System.Windows.Forms.RichTextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_menu.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tc_principal.SuspendLayout()
        Me.tc_datos.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.pnl_stock.SuspendLayout()
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCabecera.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnEliminar, Me.btnGrabar, Me.btnImprimir, Me.btnCancelar, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(1020, 25)
        Me.btn_menu.TabIndex = 198
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
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 22)
        Me.btnEliminar.Text = "&Anular"
        Me.btnEliminar.Visible = False
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
        Me.pnlCabecera.Controls.Add(Me.GroupBox4)
        Me.pnlCabecera.Controls.Add(Me.lblDetalle)
        Me.pnlCabecera.Controls.Add(Me.lblCantidad)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(8, 32)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1002, 519)
        Me.pnlCabecera.TabIndex = 196
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboareas)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(850, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(294, 45)
        Me.GroupBox4.TabIndex = 196
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Busquedas por Area"
        Me.GroupBox4.Visible = False
        '
        'cboareas
        '
        Me.cboareas.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboareas.FormattingEnabled = True
        Me.cboareas.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboareas.Location = New System.Drawing.Point(6, 15)
        Me.cboareas.Name = "cboareas"
        Me.cboareas.Size = New System.Drawing.Size(282, 25)
        Me.cboareas.TabIndex = 5
        '
        'lblDetalle
        '
        Me.lblDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetalle.BackColor = System.Drawing.Color.White
        Me.lblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalle.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblDetalle.Location = New System.Drawing.Point(1, 16)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(988, 20)
        Me.lblDetalle.TabIndex = 195
        Me.lblDetalle.Text = "LISTADO DE REQUISICIONES DE MATERIALES"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(11, 493)
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
        Me.GroupBox3.Location = New System.Drawing.Point(7, 46)
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
        Me.dgvCabecera.Location = New System.Drawing.Point(6, 102)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(984, 385)
        Me.dgvCabecera.TabIndex = 2
        '
        'Tc_principal
        '
        Me.Tc_principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tc_principal.Controls.Add(Me.tc_datos)
        Me.Tc_principal.Location = New System.Drawing.Point(11, 36)
        Me.Tc_principal.Multiline = True
        Me.Tc_principal.Name = "Tc_principal"
        Me.Tc_principal.SelectedIndex = 0
        Me.Tc_principal.Size = New System.Drawing.Size(999, 517)
        Me.Tc_principal.TabIndex = 197
        '
        'tc_datos
        '
        Me.tc_datos.BackColor = System.Drawing.Color.White
        Me.tc_datos.Controls.Add(Me.GroupBox5)
        Me.tc_datos.Controls.Add(Me.GbCabecera)
        Me.tc_datos.Controls.Add(Me.gbdetalle)
        Me.tc_datos.Controls.Add(Me.GroupBox1)
        Me.tc_datos.Location = New System.Drawing.Point(4, 22)
        Me.tc_datos.Name = "tc_datos"
        Me.tc_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_datos.Size = New System.Drawing.Size(991, 491)
        Me.tc_datos.TabIndex = 0
        Me.tc_datos.Text = "Datos de la Requisición de Materiales"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.pnl_stock)
        Me.GroupBox5.Controls.Add(Me.PictureBox6)
        Me.GroupBox5.Controls.Add(Me.txt_orden_produccion)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.btnquitar_2)
        Me.GroupBox5.Controls.Add(Me.btnModificar_2)
        Me.GroupBox5.Controls.Add(Me.btnAgregar_2)
        Me.GroupBox5.Controls.Add(Me.txtobservacion_2)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtcantidad_2)
        Me.GroupBox5.Controls.Add(Me.PictureBox7)
        Me.GroupBox5.Controls.Add(Me.txtunidadMedida_2)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.PictureBox8)
        Me.GroupBox5.Controls.Add(Me.txtdescripcionArticulo_2)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtcodigoArticulo_2)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(16, 117)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(955, 225)
        Me.GroupBox5.TabIndex = 208
        Me.GroupBox5.TabStop = False
        '
        'pnl_stock
        '
        Me.pnl_stock.Controls.Add(Me.dgv_stock)
        Me.pnl_stock.Location = New System.Drawing.Point(15, 94)
        Me.pnl_stock.Name = "pnl_stock"
        Me.pnl_stock.Size = New System.Drawing.Size(574, 118)
        Me.pnl_stock.TabIndex = 234
        '
        'dgv_stock
        '
        Me.dgv_stock.AllowUserToAddRows = False
        Me.dgv_stock.AllowUserToDeleteRows = False
        Me.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_stock.Location = New System.Drawing.Point(15, 3)
        Me.dgv_stock.Name = "dgv_stock"
        Me.dgv_stock.ReadOnly = True
        Me.dgv_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_stock.Size = New System.Drawing.Size(545, 113)
        Me.dgv_stock.TabIndex = 205
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(100, 44)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 233
        Me.PictureBox6.TabStop = False
        '
        'txt_orden_produccion
        '
        Me.txt_orden_produccion.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_orden_produccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_orden_produccion.Location = New System.Drawing.Point(124, 44)
        Me.txt_orden_produccion.MaxLength = 20
        Me.txt_orden_produccion.Name = "txt_orden_produccion"
        Me.txt_orden_produccion.ReadOnly = True
        Me.txt_orden_produccion.Size = New System.Drawing.Size(159, 20)
        Me.txt_orden_produccion.TabIndex = 232
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(44, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 231
        Me.Label7.Text = "Orden P."
        '
        'btnquitar_2
        '
        Me.btnquitar_2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnquitar_2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnquitar_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar_2.Image = CType(resources.GetObject("btnquitar_2.Image"), System.Drawing.Image)
        Me.btnquitar_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnquitar_2.Location = New System.Drawing.Point(760, 188)
        Me.btnquitar_2.Name = "btnquitar_2"
        Me.btnquitar_2.Size = New System.Drawing.Size(74, 23)
        Me.btnquitar_2.TabIndex = 230
        Me.btnquitar_2.Text = "&Quitar"
        Me.btnquitar_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnquitar_2.UseVisualStyleBackColor = True
        '
        'btnModificar_2
        '
        Me.btnModificar_2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnModificar_2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar_2.Image = CType(resources.GetObject("btnModificar_2.Image"), System.Drawing.Image)
        Me.btnModificar_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar_2.Location = New System.Drawing.Point(680, 188)
        Me.btnModificar_2.Name = "btnModificar_2"
        Me.btnModificar_2.Size = New System.Drawing.Size(74, 23)
        Me.btnModificar_2.TabIndex = 229
        Me.btnModificar_2.Text = "&Modificar"
        Me.btnModificar_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar_2.UseVisualStyleBackColor = True
        '
        'btnAgregar_2
        '
        Me.btnAgregar_2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAgregar_2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAgregar_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar_2.Image = CType(resources.GetObject("btnAgregar_2.Image"), System.Drawing.Image)
        Me.btnAgregar_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar_2.Location = New System.Drawing.Point(600, 188)
        Me.btnAgregar_2.Name = "btnAgregar_2"
        Me.btnAgregar_2.Size = New System.Drawing.Size(74, 23)
        Me.btnAgregar_2.TabIndex = 228
        Me.btnAgregar_2.Text = "&Agregar"
        Me.btnAgregar_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar_2.UseVisualStyleBackColor = True
        '
        'txtobservacion_2
        '
        Me.txtobservacion_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobservacion_2.Location = New System.Drawing.Point(100, 72)
        Me.txtobservacion_2.MaxLength = 250
        Me.txtobservacion_2.Name = "txtobservacion_2"
        Me.txtobservacion_2.Size = New System.Drawing.Size(734, 20)
        Me.txtobservacion_2.TabIndex = 226
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(16, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 227
        Me.Label11.Text = "Observaciones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(671, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 225
        Me.Label10.Text = "Cantidad"
        '
        'txtcantidad_2
        '
        Me.txtcantidad_2.BackColor = System.Drawing.Color.White
        Me.txtcantidad_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtcantidad_2.Location = New System.Drawing.Point(726, 18)
        Me.txtcantidad_2.Name = "txtcantidad_2"
        Me.txtcantidad_2.Size = New System.Drawing.Size(108, 20)
        Me.txtcantidad_2.TabIndex = 224
        Me.txtcantidad_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(626, 18)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox7.TabIndex = 223
        Me.PictureBox7.TabStop = False
        '
        'txtunidadMedida_2
        '
        Me.txtunidadMedida_2.BackColor = System.Drawing.Color.White
        Me.txtunidadMedida_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedida_2.Enabled = False
        Me.txtunidadMedida_2.Location = New System.Drawing.Point(575, 18)
        Me.txtunidadMedida_2.Name = "txtunidadMedida_2"
        Me.txtunidadMedida_2.Size = New System.Drawing.Size(46, 20)
        Me.txtunidadMedida_2.TabIndex = 219
        Me.txtunidadMedida_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(513, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 220
        Me.Label8.Text = "Unid. Med"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(142, 18)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox8.TabIndex = 222
        Me.PictureBox8.TabStop = False
        '
        'txtdescripcionArticulo_2
        '
        Me.txtdescripcionArticulo_2.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticulo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo_2.Location = New System.Drawing.Point(163, 18)
        Me.txtdescripcionArticulo_2.Name = "txtdescripcionArticulo_2"
        Me.txtdescripcionArticulo_2.ReadOnly = True
        Me.txtdescripcionArticulo_2.Size = New System.Drawing.Size(332, 20)
        Me.txtdescripcionArticulo_2.TabIndex = 218
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(13, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 221
        Me.Label9.Text = "Producto"
        '
        'txtcodigoArticulo_2
        '
        Me.txtcodigoArticulo_2.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo_2.Location = New System.Drawing.Point(69, 18)
        Me.txtcodigoArticulo_2.Name = "txtcodigoArticulo_2"
        Me.txtcodigoArticulo_2.ReadOnly = True
        Me.txtcodigoArticulo_2.Size = New System.Drawing.Size(69, 20)
        Me.txtcodigoArticulo_2.TabIndex = 217
        '
        'GbCabecera
        '
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.GroupBox6)
        Me.GbCabecera.Controls.Add(Me.rdb_campoy)
        Me.GbCabecera.Controls.Add(Me.rdb_breña)
        Me.GbCabecera.Controls.Add(Me.lbl_usuario)
        Me.GbCabecera.Controls.Add(Me.Label1)
        Me.GbCabecera.Controls.Add(Me.Label2)
        Me.GbCabecera.Controls.Add(Me.txtcodigo)
        Me.GbCabecera.Controls.Add(Me.txttipoDoc)
        Me.GbCabecera.Controls.Add(Me.dtpFechad)
        Me.GbCabecera.Controls.Add(Me.Label5)
        Me.GbCabecera.Controls.Add(Me.PictureBox2)
        Me.GbCabecera.Controls.Add(Me.txtarea)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.PictureBox1)
        Me.GbCabecera.Controls.Add(Me.txtdescripcion_area)
        Me.GbCabecera.Controls.Add(Me.txtdescripcion_solicitante)
        Me.GbCabecera.Controls.Add(Me.txtsolicitante)
        Me.GbCabecera.Controls.Add(Me.Label6)
        Me.GbCabecera.Controls.Add(Me.txtestado)
        Me.GbCabecera.Location = New System.Drawing.Point(16, 7)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(955, 110)
        Me.GbCabecera.TabIndex = 189
        Me.GbCabecera.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdb_sol_complementos)
        Me.GroupBox6.Controls.Add(Me.rdb_sol_mp)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(91, 55)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(404, 43)
        Me.GroupBox6.TabIndex = 217
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo"
        '
        'rdb_sol_complementos
        '
        Me.rdb_sol_complementos.AutoSize = True
        Me.rdb_sol_complementos.Location = New System.Drawing.Point(230, 18)
        Me.rdb_sol_complementos.Name = "rdb_sol_complementos"
        Me.rdb_sol_complementos.Size = New System.Drawing.Size(151, 17)
        Me.rdb_sol_complementos.TabIndex = 1
        Me.rdb_sol_complementos.TabStop = True
        Me.rdb_sol_complementos.Text = "Solicitud de complementos"
        Me.rdb_sol_complementos.UseVisualStyleBackColor = True
        '
        'rdb_sol_mp
        '
        Me.rdb_sol_mp.AutoSize = True
        Me.rdb_sol_mp.Location = New System.Drawing.Point(10, 18)
        Me.rdb_sol_mp.Name = "rdb_sol_mp"
        Me.rdb_sol_mp.Size = New System.Drawing.Size(195, 17)
        Me.rdb_sol_mp.TabIndex = 0
        Me.rdb_sol_mp.TabStop = True
        Me.rdb_sol_mp.Text = "Solicitud de materia prima e insumos"
        Me.rdb_sol_mp.UseVisualStyleBackColor = True
        '
        'rdb_campoy
        '
        Me.rdb_campoy.AutoSize = True
        Me.rdb_campoy.Checked = True
        Me.rdb_campoy.ForeColor = System.Drawing.Color.Navy
        Me.rdb_campoy.Location = New System.Drawing.Point(677, 105)
        Me.rdb_campoy.Name = "rdb_campoy"
        Me.rdb_campoy.Size = New System.Drawing.Size(70, 17)
        Me.rdb_campoy.TabIndex = 216
        Me.rdb_campoy.TabStop = True
        Me.rdb_campoy.Text = "CAMPOY"
        Me.rdb_campoy.UseVisualStyleBackColor = True
        Me.rdb_campoy.Visible = False
        '
        'rdb_breña
        '
        Me.rdb_breña.AutoSize = True
        Me.rdb_breña.ForeColor = System.Drawing.Color.Navy
        Me.rdb_breña.Location = New System.Drawing.Point(577, 105)
        Me.rdb_breña.Name = "rdb_breña"
        Me.rdb_breña.Size = New System.Drawing.Size(62, 17)
        Me.rdb_breña.TabIndex = 215
        Me.rdb_breña.Text = "BREÑA"
        Me.rdb_breña.UseVisualStyleBackColor = True
        Me.rdb_breña.Visible = False
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.Navy
        Me.lbl_usuario.Location = New System.Drawing.Point(118, 107)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(10, 13)
        Me.lbl_usuario.TabIndex = 214
        Me.lbl_usuario.Text = "."
        Me.lbl_usuario.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(46, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "Creado Por."
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(530, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "Numeración Documento"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Location = New System.Drawing.Point(557, 29)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(110, 20)
        Me.txtcodigo.TabIndex = 210
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttipoDoc
        '
        Me.txttipoDoc.BackColor = System.Drawing.Color.White
        Me.txttipoDoc.Location = New System.Drawing.Point(519, 29)
        Me.txttipoDoc.Name = "txttipoDoc"
        Me.txttipoDoc.ReadOnly = True
        Me.txttipoDoc.Size = New System.Drawing.Size(36, 20)
        Me.txttipoDoc.TabIndex = 209
        Me.txttipoDoc.Text = "RD"
        '
        'dtpFechad
        '
        Me.dtpFechad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechad.Location = New System.Drawing.Point(672, 29)
        Me.dtpFechad.Name = "dtpFechad"
        Me.dtpFechad.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechad.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(674, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "Fecha de emisión"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(182, 126)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 206
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'txtarea
        '
        Me.txtarea.BackColor = System.Drawing.Color.Aquamarine
        Me.txtarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtarea.Location = New System.Drawing.Point(118, 126)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(64, 20)
        Me.txtarea.TabIndex = 0
        Me.txtarea.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(13, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 205
        Me.Label3.Text = "Solicitado Por."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(161, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 112
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcion_area
        '
        Me.txtdescripcion_area.BackColor = System.Drawing.Color.White
        Me.txtdescripcion_area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion_area.Enabled = False
        Me.txtdescripcion_area.Location = New System.Drawing.Point(202, 126)
        Me.txtdescripcion_area.Name = "txtdescripcion_area"
        Me.txtdescripcion_area.ReadOnly = True
        Me.txtdescripcion_area.Size = New System.Drawing.Size(286, 20)
        Me.txtdescripcion_area.TabIndex = 1
        Me.txtdescripcion_area.Visible = False
        '
        'txtdescripcion_solicitante
        '
        Me.txtdescripcion_solicitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion_solicitante.Enabled = False
        Me.txtdescripcion_solicitante.Location = New System.Drawing.Point(186, 28)
        Me.txtdescripcion_solicitante.Name = "txtdescripcion_solicitante"
        Me.txtdescripcion_solicitante.Size = New System.Drawing.Size(309, 20)
        Me.txtdescripcion_solicitante.TabIndex = 3
        '
        'txtsolicitante
        '
        Me.txtsolicitante.BackColor = System.Drawing.Color.Aquamarine
        Me.txtsolicitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsolicitante.Location = New System.Drawing.Point(91, 28)
        Me.txtsolicitante.Name = "txtsolicitante"
        Me.txtsolicitante.ReadOnly = True
        Me.txtsolicitante.Size = New System.Drawing.Size(64, 20)
        Me.txtsolicitante.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(46, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Emitido Por."
        Me.Label6.Visible = False
        '
        'txtestado
        '
        Me.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtestado.Location = New System.Drawing.Point(491, 12)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(26, 20)
        Me.txtestado.TabIndex = 212
        Me.txtestado.Visible = False
        '
        'gbdetalle
        '
        Me.gbdetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbdetalle.BackColor = System.Drawing.Color.White
        Me.gbdetalle.Controls.Add(Me.dgvDetalle)
        Me.gbdetalle.Location = New System.Drawing.Point(13, 340)
        Me.gbdetalle.Name = "gbdetalle"
        Me.gbdetalle.Size = New System.Drawing.Size(958, 145)
        Me.gbdetalle.TabIndex = 190
        Me.gbdetalle.TabStop = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDetalle.Location = New System.Drawing.Point(8, 15)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(939, 122)
        Me.dgvDetalle.TabIndex = 112
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtcomentario)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(5, 477)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 40)
        Me.GroupBox1.TabIndex = 207
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descripción de Requisición"
        Me.GroupBox1.Visible = False
        '
        'txtcomentario
        '
        Me.txtcomentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcomentario.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcomentario.Location = New System.Drawing.Point(11, 14)
        Me.txtcomentario.Multiline = False
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(885, 20)
        Me.txtcomentario.TabIndex = 192
        Me.txtcomentario.Text = ""
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'FrmRequisiciones_Materiales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 558)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.Tc_principal)
        Me.Controls.Add(Me.btn_menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRequisiciones_Materiales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisiciones de Materiales"
        Me.btn_menu.ResumeLayout(False)
        Me.btn_menu.PerformLayout()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tc_principal.ResumeLayout(False)
        Me.tc_datos.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.pnl_stock.ResumeLayout(False)
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdetalle.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboareas As System.Windows.Forms.ComboBox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcomentario As System.Windows.Forms.RichTextBox
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_campoy As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_breña As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txttipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcion_area As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion_solicitante As System.Windows.Forms.TextBox
    Friend WithEvents txtsolicitante As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtestado As System.Windows.Forms.TextBox
    Friend WithEvents gbdetalle As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtobservacion_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad_2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txtunidadMedida_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcionArticulo_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo_2 As System.Windows.Forms.TextBox
    Friend WithEvents btnquitar_2 As System.Windows.Forms.Button
    Friend WithEvents btnModificar_2 As System.Windows.Forms.Button
    Friend WithEvents btnAgregar_2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_orden_produccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnl_stock As System.Windows.Forms.Panel
    Friend WithEvents dgv_stock As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_sol_complementos As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_sol_mp As System.Windows.Forms.RadioButton
End Class
