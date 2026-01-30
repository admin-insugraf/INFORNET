<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Calculo_Envio_Boletas_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Calculo_Envio_Boletas_Pago))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btn_enviarEmail = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
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
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblCantidad_detalle = New System.Windows.Forms.Label()
        Me.dgv_Lista_detalle = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO_PATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO_MATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO_DOCUMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS_ENVIO_BOLETA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTSERVER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTMSG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTUSERNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTPASSWORD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.dtpFecha_planilla = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_anexar = New System.Windows.Forms.Button()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btn_menu.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_Lista_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btn_enviarEmail, Me.btnGrabar, Me.btnCancelar, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(1026, 25)
        Me.btn_menu.TabIndex = 242
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
        'btn_enviarEmail
        '
        Me.btn_enviarEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviarEmail.Image = CType(resources.GetObject("btn_enviarEmail.Image"), System.Drawing.Image)
        Me.btn_enviarEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_enviarEmail.Name = "btn_enviarEmail"
        Me.btn_enviarEmail.Size = New System.Drawing.Size(95, 22)
        Me.btn_enviarEmail.Text = "Enviar Email"
        Me.btn_enviarEmail.Visible = False
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
        Me.pnlCabecera.Location = New System.Drawing.Point(12, 24)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(985, 534)
        Me.pnlCabecera.TabIndex = 244
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
        Me.lblDetalle.Size = New System.Drawing.Size(970, 20)
        Me.lblDetalle.TabIndex = 195
        Me.lblDetalle.Text = "LISTA DE ENVIO DE BOLETAS DE PAGO"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(11, 508)
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
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Año del Proceso", "Rango Fechas"})
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCabecera.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(7, 102)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(970, 403)
        Me.dgvCabecera.TabIndex = 2
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Location = New System.Drawing.Point(18, 175)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(979, 383)
        Me.tc_tipos.TabIndex = 246
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblCantidad_detalle)
        Me.TabPage1.Controls.Add(Me.dgv_Lista_detalle)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(971, 357)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LISTA DE PERSONAL"
        '
        'lblCantidad_detalle
        '
        Me.lblCantidad_detalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad_detalle.AutoSize = True
        Me.lblCantidad_detalle.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad_detalle.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad_detalle.Location = New System.Drawing.Point(13, 327)
        Me.lblCantidad_detalle.Name = "lblCantidad_detalle"
        Me.lblCantidad_detalle.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad_detalle.TabIndex = 125
        Me.lblCantidad_detalle.Text = "."
        '
        'dgv_Lista_detalle
        '
        Me.dgv_Lista_detalle.AllowUserToAddRows = False
        Me.dgv_Lista_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Lista_detalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Lista_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lista_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOMBRE, Me.APELLIDO_PATERNO, Me.APELLIDO_MATERNO, Me.NUMERO_DOCUMENTO, Me.EMAIL, Me.STATUS_ENVIO_BOLETA, Me.txtFrom, Me.TXTSERVER, Me.TXTMSG, Me.TXTUSERNAME, Me.TXTPASSWORD})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Lista_detalle.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Lista_detalle.EnableHeadersVisualStyles = False
        Me.dgv_Lista_detalle.Location = New System.Drawing.Point(9, 10)
        Me.dgv_Lista_detalle.Name = "dgv_Lista_detalle"
        Me.dgv_Lista_detalle.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Lista_detalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Lista_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lista_detalle.Size = New System.Drawing.Size(952, 314)
        Me.dgv_Lista_detalle.TabIndex = 113
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "CODIGO"
        Me.CODIGO.HeaderText = "COD. TRABAJADOR"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRES"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 200
        '
        'APELLIDO_PATERNO
        '
        Me.APELLIDO_PATERNO.DataPropertyName = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.HeaderText = "APELLIDO PATERNO"
        Me.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.ReadOnly = True
        Me.APELLIDO_PATERNO.Width = 200
        '
        'APELLIDO_MATERNO
        '
        Me.APELLIDO_MATERNO.DataPropertyName = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.HeaderText = "APELLIDOS MATERNO"
        Me.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.ReadOnly = True
        Me.APELLIDO_MATERNO.Width = 200
        '
        'NUMERO_DOCUMENTO
        '
        Me.NUMERO_DOCUMENTO.DataPropertyName = "NUMERO_DOCUMENTO"
        Me.NUMERO_DOCUMENTO.HeaderText = "N° DNI"
        Me.NUMERO_DOCUMENTO.Name = "NUMERO_DOCUMENTO"
        Me.NUMERO_DOCUMENTO.ReadOnly = True
        Me.NUMERO_DOCUMENTO.Visible = False
        '
        'EMAIL
        '
        Me.EMAIL.DataPropertyName = "EMAIL"
        Me.EMAIL.HeaderText = "CORREO ELECTRÓNICO"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        Me.EMAIL.Width = 200
        '
        'STATUS_ENVIO_BOLETA
        '
        Me.STATUS_ENVIO_BOLETA.DataPropertyName = "STATUS_ENVIO_BOLETA"
        Me.STATUS_ENVIO_BOLETA.HeaderText = "ESTADO DE ENVIO DE BOLETA"
        Me.STATUS_ENVIO_BOLETA.Name = "STATUS_ENVIO_BOLETA"
        Me.STATUS_ENVIO_BOLETA.ReadOnly = True
        Me.STATUS_ENVIO_BOLETA.Visible = False
        Me.STATUS_ENVIO_BOLETA.Width = 200
        '
        'txtFrom
        '
        Me.txtFrom.DataPropertyName = "txtFrom"
        Me.txtFrom.HeaderText = "txtFrom"
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.ReadOnly = True
        Me.txtFrom.Visible = False
        '
        'TXTSERVER
        '
        Me.TXTSERVER.DataPropertyName = "TXTSERVER"
        Me.TXTSERVER.HeaderText = "TXTSERVER"
        Me.TXTSERVER.Name = "TXTSERVER"
        Me.TXTSERVER.ReadOnly = True
        Me.TXTSERVER.Visible = False
        '
        'TXTMSG
        '
        Me.TXTMSG.DataPropertyName = "TXTMSG"
        Me.TXTMSG.HeaderText = "TXTMSG"
        Me.TXTMSG.Name = "TXTMSG"
        Me.TXTMSG.ReadOnly = True
        Me.TXTMSG.Visible = False
        '
        'TXTUSERNAME
        '
        Me.TXTUSERNAME.DataPropertyName = "TXTUSERNAME"
        Me.TXTUSERNAME.HeaderText = "TXTUSERNAME"
        Me.TXTUSERNAME.Name = "TXTUSERNAME"
        Me.TXTUSERNAME.ReadOnly = True
        Me.TXTUSERNAME.Visible = False
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.DataPropertyName = "TXTPASSWORD"
        Me.TXTPASSWORD.HeaderText = "TXTPASSWORD"
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.ReadOnly = True
        Me.TXTPASSWORD.Visible = False
        '
        'GbCabecera
        '
        Me.GbCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.ProgressBar1)
        Me.GbCabecera.Controls.Add(Me.txtRuta)
        Me.GbCabecera.Controls.Add(Me.Label10)
        Me.GbCabecera.Controls.Add(Me.btnRuta)
        Me.GbCabecera.Controls.Add(Me.dtpFecha_planilla)
        Me.GbCabecera.Controls.Add(Me.Label9)
        Me.GbCabecera.Controls.Add(Me.btn_anexar)
        Me.GbCabecera.Controls.Add(Me.txt_titulo)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.Label2)
        Me.GbCabecera.Controls.Add(Me.txtcodigo)
        Me.GbCabecera.Location = New System.Drawing.Point(18, 32)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(979, 137)
        Me.GbCabecera.TabIndex = 245
        Me.GbCabecera.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(252, 105)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(512, 18)
        Me.ProgressBar1.TabIndex = 299
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.txtRuta.Location = New System.Drawing.Point(252, 64)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(512, 20)
        Me.txtRuta.TabIndex = 296
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(212, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 298
        Me.Label10.Text = "Ruta :"
        '
        'btnRuta
        '
        Me.btnRuta.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRuta.Location = New System.Drawing.Point(776, 63)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(25, 23)
        Me.btnRuta.TabIndex = 297
        Me.btnRuta.Text = "..."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'dtpFecha_planilla
        '
        Me.dtpFecha_planilla.CalendarMonthBackground = System.Drawing.Color.Aquamarine
        Me.dtpFecha_planilla.CustomFormat = "MMMM/yyyy"
        Me.dtpFecha_planilla.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha_planilla.Location = New System.Drawing.Point(72, 64)
        Me.dtpFecha_planilla.Name = "dtpFecha_planilla"
        Me.dtpFecha_planilla.Size = New System.Drawing.Size(132, 20)
        Me.dtpFecha_planilla.TabIndex = 294
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(14, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 295
        Me.Label9.Text = "Mes/Año"
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
        Me.txt_titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_titulo.BackColor = System.Drawing.Color.White
        Me.txt_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_titulo.ForeColor = System.Drawing.Color.Maroon
        Me.txt_titulo.Location = New System.Drawing.Point(293, 17)
        Me.txt_titulo.MaxLength = 250
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(508, 20)
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
        Me.Label2.Location = New System.Drawing.Point(45, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "N°"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Location = New System.Drawing.Point(71, 17)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(110, 20)
        Me.txtcodigo.TabIndex = 210
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_Calculo_Envio_Boletas_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 582)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.tc_tipos)
        Me.Controls.Add(Me.GbCabecera)
        Me.Controls.Add(Me.btn_menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Calculo_Envio_Boletas_Pago"
        Me.Text = "Envio de Boletas de Pago"
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
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_Lista_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_enviarEmail As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblCantidad_detalle As System.Windows.Forms.Label
    Friend WithEvents dgv_Lista_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents btn_anexar As System.Windows.Forms.Button
    Friend WithEvents txt_titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents dtpFecha_planilla As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO_PATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO_MATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERO_DOCUMENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS_ENVIO_BOLETA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TXTSERVER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TXTMSG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TXTUSERNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TXTPASSWORD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
