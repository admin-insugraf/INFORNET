<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Parte_Entrega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Parte_Entrega))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboAlmacenBusqueda = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btn_act_costos = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Anular = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuiaAnalisis = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbCabceraDocumento = New System.Windows.Forms.GroupBox()
        Me.GbTransaccion = New System.Windows.Forms.GroupBox()
        Me.CboAlmacen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cboTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.gbLeyenda = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkValorizado = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbdetalleDocumento = New System.Windows.Forms.GroupBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.dgvdetalleAlmacen = New System.Windows.Forms.DataGridView()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblprodafabricar = New System.Windows.Forms.Label()
        Me.txtprodafabricar = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtloteFabricar = New System.Windows.Forms.TextBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbocentroCosto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipoDocRef = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtordenCompra = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltercero = New System.Windows.Forms.Label()
        Me.lblproveedor = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtorderFabricacion = New System.Windows.Forms.TextBox()
        Me.txtNumeroReferencia = New System.Windows.Forms.TextBox()
        Me.txtcodigoTercero = New System.Windows.Forms.TextBox()
        Me.txtTipoDocumentoRef = New System.Windows.Forms.TextBox()
        Me.txtcodigoProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlprincipal.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbCabceraDocumento.SuspendLayout()
        Me.GbTransaccion.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbLeyenda.SuspendLayout()
        Me.GbdetalleDocumento.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        CType(Me.dgvdetalleAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCabecera.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlprincipal.Controls.Add(Me.GroupBox1)
        Me.pnlprincipal.Location = New System.Drawing.Point(4, 35)
        Me.pnlprincipal.Name = "pnlprincipal"
        Me.pnlprincipal.Size = New System.Drawing.Size(876, 481)
        Me.pnlprincipal.TabIndex = 109
        '
        'lblDetalle
        '
        Me.lblDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetalle.BackColor = System.Drawing.Color.White
        Me.lblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalle.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblDetalle.Location = New System.Drawing.Point(1, 19)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.ReadOnly = True
        Me.lblDetalle.Size = New System.Drawing.Size(875, 20)
        Me.lblDetalle.TabIndex = 199
        Me.lblDetalle.Text = "LISTADO DE  PARTE DE ENTREGA"
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
        Me.gbRangofechas.Location = New System.Drawing.Point(578, 64)
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
        Me.dgvCabeceraAlmacen.Location = New System.Drawing.Point(3, 118)
        Me.dgvCabeceraAlmacen.Name = "dgvCabeceraAlmacen"
        Me.dgvCabeceraAlmacen.ReadOnly = True
        Me.dgvCabeceraAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabeceraAlmacen.Size = New System.Drawing.Size(860, 334)
        Me.dgvCabeceraAlmacen.TabIndex = 104
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(418, 64)
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
        Me.GroupBox7.Location = New System.Drawing.Point(3, 64)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(402, 48)
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
        Me.txtFiltro.Size = New System.Drawing.Size(389, 22)
        Me.txtFiltro.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cboAlmacenBusqueda)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(195, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 48)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Almacen"
        Me.GroupBox1.Visible = False
        '
        'cboAlmacenBusqueda
        '
        Me.cboAlmacenBusqueda.FormattingEnabled = True
        Me.cboAlmacenBusqueda.Location = New System.Drawing.Point(5, 17)
        Me.cboAlmacenBusqueda.Name = "cboAlmacenBusqueda"
        Me.cboAlmacenBusqueda.Size = New System.Drawing.Size(205, 21)
        Me.cboAlmacenBusqueda.TabIndex = 105
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btn_act_costos, Me.btnGrabar, Me.Tool_Anular, Me.btnEliminar, Me.btnGuiaAnalisis, Me.btnImprimir, Me.btnCancelar, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(892, 25)
        Me.ToolStrip1.TabIndex = 108
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
        'btn_act_costos
        '
        Me.btn_act_costos.ForeColor = System.Drawing.Color.Navy
        Me.btn_act_costos.Image = CType(resources.GetObject("btn_act_costos.Image"), System.Drawing.Image)
        Me.btn_act_costos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_act_costos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_act_costos.Name = "btn_act_costos"
        Me.btn_act_costos.Size = New System.Drawing.Size(84, 22)
        Me.btn_act_costos.Text = "Actualizar"
        Me.btn_act_costos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_act_costos.Visible = False
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
        'Tool_Anular
        '
        Me.Tool_Anular.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Anular.Image = CType(resources.GetObject("Tool_Anular.Image"), System.Drawing.Image)
        Me.Tool_Anular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Anular.Name = "Tool_Anular"
        Me.Tool_Anular.Size = New System.Drawing.Size(64, 22)
        Me.Tool_Anular.Text = "Anular"
        '
        'btnEliminar
        '
        Me.btnEliminar.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 22)
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.Visible = False
        '
        'btnGuiaAnalisis
        '
        Me.btnGuiaAnalisis.ForeColor = System.Drawing.Color.Navy
        Me.btnGuiaAnalisis.Image = CType(resources.GetObject("btnGuiaAnalisis.Image"), System.Drawing.Image)
        Me.btnGuiaAnalisis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuiaAnalisis.Name = "btnGuiaAnalisis"
        Me.btnGuiaAnalisis.Size = New System.Drawing.Size(115, 22)
        Me.btnGuiaAnalisis.Text = "&Guia de Analisis"
        Me.btnGuiaAnalisis.Visible = False
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
        Me.gbCabceraDocumento.Controls.Add(Me.GbTransaccion)
        Me.gbCabceraDocumento.Controls.Add(Me.GbdetalleDocumento)
        Me.gbCabceraDocumento.Controls.Add(Me.txtComentarios)
        Me.gbCabceraDocumento.Controls.Add(Me.Label27)
        Me.gbCabceraDocumento.Controls.Add(Me.GbCabecera)
        Me.gbCabceraDocumento.Location = New System.Drawing.Point(4, 31)
        Me.gbCabceraDocumento.Name = "gbCabceraDocumento"
        Me.gbCabceraDocumento.Size = New System.Drawing.Size(855, 470)
        Me.gbCabceraDocumento.TabIndex = 107
        Me.gbCabceraDocumento.TabStop = False
        '
        'GbTransaccion
        '
        Me.GbTransaccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbTransaccion.Controls.Add(Me.CboAlmacen)
        Me.GbTransaccion.Controls.Add(Me.Label4)
        Me.GbTransaccion.Controls.Add(Me.GroupBox5)
        Me.GbTransaccion.Controls.Add(Me.gbLeyenda)
        Me.GbTransaccion.Controls.Add(Me.chkValorizado)
        Me.GbTransaccion.Controls.Add(Me.dtpFecha)
        Me.GbTransaccion.Controls.Add(Me.Label1)
        Me.GbTransaccion.ForeColor = System.Drawing.Color.Navy
        Me.GbTransaccion.Location = New System.Drawing.Point(6, 10)
        Me.GbTransaccion.Name = "GbTransaccion"
        Me.GbTransaccion.Size = New System.Drawing.Size(838, 60)
        Me.GbTransaccion.TabIndex = 36
        Me.GbTransaccion.TabStop = False
        '
        'CboAlmacen
        '
        Me.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAlmacen.FormattingEnabled = True
        Me.CboAlmacen.Location = New System.Drawing.Point(178, 28)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(281, 21)
        Me.CboAlmacen.TabIndex = 112
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(122, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Almacen "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cboTipoMovimiento)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(116, 48)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(390, 49)
        Me.GroupBox5.TabIndex = 111
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TRANSACCIONES"
        Me.GroupBox5.Visible = False
        '
        'cboTipoMovimiento
        '
        Me.cboTipoMovimiento.DisplayMember = "Nombre"
        Me.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMovimiento.FormattingEnabled = True
        Me.cboTipoMovimiento.Location = New System.Drawing.Point(6, 17)
        Me.cboTipoMovimiento.Name = "cboTipoMovimiento"
        Me.cboTipoMovimiento.Size = New System.Drawing.Size(378, 21)
        Me.cboTipoMovimiento.TabIndex = 2
        Me.cboTipoMovimiento.ValueMember = "Codigo"
        '
        'gbLeyenda
        '
        Me.gbLeyenda.Controls.Add(Me.Label13)
        Me.gbLeyenda.Controls.Add(Me.TextBox1)
        Me.gbLeyenda.Controls.Add(Me.TextBox2)
        Me.gbLeyenda.Controls.Add(Me.Label12)
        Me.gbLeyenda.ForeColor = System.Drawing.Color.Navy
        Me.gbLeyenda.Location = New System.Drawing.Point(613, 12)
        Me.gbLeyenda.Name = "gbLeyenda"
        Me.gbLeyenda.Size = New System.Drawing.Size(218, 43)
        Me.gbLeyenda.TabIndex = 109
        Me.gbLeyenda.TabStop = False
        Me.gbLeyenda.Text = "Leyenda"
        Me.gbLeyenda.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(124, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "No ingresar datos"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(17, 15)
        Me.TextBox1.TabIndex = 37
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(103, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(17, 15)
        Me.TextBox2.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(27, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Ingresar datos"
        '
        'chkValorizado
        '
        Me.chkValorizado.AutoSize = True
        Me.chkValorizado.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkValorizado.ForeColor = System.Drawing.Color.Navy
        Me.chkValorizado.Location = New System.Drawing.Point(513, 30)
        Me.chkValorizado.Name = "chkValorizado"
        Me.chkValorizado.Size = New System.Drawing.Size(92, 21)
        Me.chkValorizado.TabIndex = 3
        Me.chkValorizado.Text = "Valorizado"
        Me.chkValorizado.UseVisualStyleBackColor = True
        Me.chkValorizado.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFecha.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(6, 27)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(103, 24)
        Me.dtpFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha"
        '
        'GbdetalleDocumento
        '
        Me.GbdetalleDocumento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbdetalleDocumento.Controls.Add(Me.gbOpciones)
        Me.GbdetalleDocumento.Controls.Add(Me.dgvdetalleAlmacen)
        Me.GbdetalleDocumento.Controls.Add(Me.dgvDetalle)
        Me.GbdetalleDocumento.Location = New System.Drawing.Point(6, 141)
        Me.GbdetalleDocumento.Name = "GbdetalleDocumento"
        Me.GbdetalleDocumento.Size = New System.Drawing.Size(838, 316)
        Me.GbdetalleDocumento.TabIndex = 38
        Me.GbdetalleDocumento.TabStop = False
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnQuitar)
        Me.gbOpciones.Location = New System.Drawing.Point(733, 9)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(99, 298)
        Me.gbOpciones.TabIndex = 39
        Me.gbOpciones.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.ForeColor = System.Drawing.Color.Navy
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(7, 103)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(85, 28)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "    Nuevo"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.ForeColor = System.Drawing.Color.Navy
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(7, 137)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(85, 28)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "   Editar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnQuitar.BackColor = System.Drawing.Color.White
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuitar.ForeColor = System.Drawing.Color.Navy
        Me.btnQuitar.Image = CType(resources.GetObject("btnQuitar.Image"), System.Drawing.Image)
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.Location = New System.Drawing.Point(7, 171)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(85, 28)
        Me.btnQuitar.TabIndex = 17
        Me.btnQuitar.Text = "    Eliminar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'dgvdetalleAlmacen
        '
        Me.dgvdetalleAlmacen.AllowUserToAddRows = False
        Me.dgvdetalleAlmacen.AllowUserToDeleteRows = False
        Me.dgvdetalleAlmacen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdetalleAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalleAlmacen.Location = New System.Drawing.Point(4, 17)
        Me.dgvdetalleAlmacen.Name = "dgvdetalleAlmacen"
        Me.dgvdetalleAlmacen.ReadOnly = True
        Me.dgvdetalleAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdetalleAlmacen.Size = New System.Drawing.Size(730, 292)
        Me.dgvdetalleAlmacen.TabIndex = 13
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.Column11, Me.codigo, Me.Column9, Me.Column10, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.DataGridViewTextBoxColumn1, Me.costo})
        Me.dgvDetalle.Location = New System.Drawing.Point(4, 17)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(823, 290)
        Me.dgvDetalle.TabIndex = 41
        Me.dgvDetalle.Visible = False
        '
        'item
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.item.DefaultCellStyle = DataGridViewCellStyle8
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 40
        '
        'Column11
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column11.HeaderText = "N° O.P."
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 60
        '
        'Column9
        '
        Me.Column9.HeaderText = "Descripcion"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 200
        '
        'Column10
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column10.HeaderText = "Unidad"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 45
        '
        'Column12
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column12.HeaderText = "Cantidad "
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 80
        '
        'Column13
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column13.HeaderText = "Bultos"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        Me.Column13.Width = 60
        '
        'Column14
        '
        Me.Column14.HeaderText = "Entrega"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Visible = False
        Me.Column14.Width = 60
        '
        'Column15
        '
        Me.Column15.HeaderText = "Num_Protocolo"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Visible = False
        Me.Column15.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'costo
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.costo.DefaultCellStyle = DataGridViewCellStyle14
        Me.costo.HeaderText = "Costo Unitario"
        Me.costo.Name = "costo"
        Me.costo.Visible = False
        Me.costo.Width = 300
        '
        'txtComentarios
        '
        Me.txtComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentarios.BackColor = System.Drawing.Color.White
        Me.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComentarios.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarios.Location = New System.Drawing.Point(6, 101)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarios.Size = New System.Drawing.Size(829, 34)
        Me.txtComentarios.TabIndex = 13
        Me.txtComentarios.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(6, 79)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(147, 13)
        Me.Label27.TabIndex = 122
        Me.Label27.Text = "Observaciones / Comentarios"
        '
        'GbCabecera
        '
        Me.GbCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecera.Controls.Add(Me.Label16)
        Me.GbCabecera.Controls.Add(Me.PictureBox5)
        Me.GbCabecera.Controls.Add(Me.lblprodafabricar)
        Me.GbCabecera.Controls.Add(Me.txtprodafabricar)
        Me.GbCabecera.Controls.Add(Me.PictureBox3)
        Me.GbCabecera.Controls.Add(Me.Label5)
        Me.GbCabecera.Controls.Add(Me.txtloteFabricar)
        Me.GbCabecera.Controls.Add(Me.cboMoneda)
        Me.GbCabecera.Controls.Add(Me.Label11)
        Me.GbCabecera.Controls.Add(Me.cbocentroCosto)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.Label2)
        Me.GbCabecera.Controls.Add(Me.lblTipoDocRef)
        Me.GbCabecera.Controls.Add(Me.Label14)
        Me.GbCabecera.Controls.Add(Me.txtordenCompra)
        Me.GbCabecera.Controls.Add(Me.PictureBox4)
        Me.GbCabecera.Controls.Add(Me.PictureBox2)
        Me.GbCabecera.Controls.Add(Me.PictureBox1)
        Me.GbCabecera.Controls.Add(Me.lbltercero)
        Me.GbCabecera.Controls.Add(Me.lblproveedor)
        Me.GbCabecera.Controls.Add(Me.Label8)
        Me.GbCabecera.Controls.Add(Me.txtorderFabricacion)
        Me.GbCabecera.Controls.Add(Me.txtNumeroReferencia)
        Me.GbCabecera.Controls.Add(Me.txtcodigoTercero)
        Me.GbCabecera.Controls.Add(Me.txtTipoDocumentoRef)
        Me.GbCabecera.Controls.Add(Me.txtcodigoProveedor)
        Me.GbCabecera.Controls.Add(Me.Label7)
        Me.GbCabecera.Controls.Add(Me.Label9)
        Me.GbCabecera.Controls.Add(Me.Label10)
        Me.GbCabecera.Enabled = False
        Me.GbCabecera.ForeColor = System.Drawing.Color.Black
        Me.GbCabecera.Location = New System.Drawing.Point(6, 185)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(837, 173)
        Me.GbCabecera.TabIndex = 37
        Me.GbCabecera.TabStop = False
        Me.GbCabecera.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(18, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 119
        Me.Label16.Text = "Prod. a Fabricar"
        Me.Label16.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(174, 137)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox5.TabIndex = 118
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'lblprodafabricar
        '
        Me.lblprodafabricar.AutoSize = True
        Me.lblprodafabricar.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblprodafabricar.ForeColor = System.Drawing.Color.Navy
        Me.lblprodafabricar.Location = New System.Drawing.Point(203, 138)
        Me.lblprodafabricar.Name = "lblprodafabricar"
        Me.lblprodafabricar.Size = New System.Drawing.Size(17, 18)
        Me.lblprodafabricar.TabIndex = 117
        Me.lblprodafabricar.Text = "..."
        Me.lblprodafabricar.Visible = False
        '
        'txtprodafabricar
        '
        Me.txtprodafabricar.BackColor = System.Drawing.Color.White
        Me.txtprodafabricar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprodafabricar.Location = New System.Drawing.Point(103, 136)
        Me.txtprodafabricar.Name = "txtprodafabricar"
        Me.txtprodafabricar.ReadOnly = True
        Me.txtprodafabricar.Size = New System.Drawing.Size(68, 20)
        Me.txtprodafabricar.TabIndex = 116
        Me.txtprodafabricar.Tag = "Cod. Articulo"
        Me.txtprodafabricar.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(580, 34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 115
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(597, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Lote a fabricar"
        Me.Label5.Visible = False
        '
        'txtloteFabricar
        '
        Me.txtloteFabricar.BackColor = System.Drawing.Color.White
        Me.txtloteFabricar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtloteFabricar.Location = New System.Drawing.Point(677, 60)
        Me.txtloteFabricar.Name = "txtloteFabricar"
        Me.txtloteFabricar.Size = New System.Drawing.Size(132, 20)
        Me.txtloteFabricar.TabIndex = 12
        Me.txtloteFabricar.Tag = "Orden de Fabricacion"
        Me.txtloteFabricar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtloteFabricar.Visible = False
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(442, 9)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(132, 21)
        Me.cboMoneda.TabIndex = 4
        Me.cboMoneda.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(393, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Moneda"
        Me.Label11.Visible = False
        '
        'cbocentroCosto
        '
        Me.cbocentroCosto.Enabled = False
        Me.cbocentroCosto.FormattingEnabled = True
        Me.cbocentroCosto.Location = New System.Drawing.Point(104, 186)
        Me.cbocentroCosto.Name = "cbocentroCosto"
        Me.cbocentroCosto.Size = New System.Drawing.Size(194, 21)
        Me.cbocentroCosto.TabIndex = 5
        Me.cbocentroCosto.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(61, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Cliente"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(44, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Proveedor"
        Me.Label2.Visible = False
        '
        'lblTipoDocRef
        '
        Me.lblTipoDocRef.AutoSize = True
        Me.lblTipoDocRef.Font = New System.Drawing.Font("Book Antiqua", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipoDocRef.ForeColor = System.Drawing.Color.Navy
        Me.lblTipoDocRef.Location = New System.Drawing.Point(172, 36)
        Me.lblTipoDocRef.Name = "lblTipoDocRef"
        Me.lblTipoDocRef.Size = New System.Drawing.Size(17, 16)
        Me.lblTipoDocRef.TabIndex = 110
        Me.lblTipoDocRef.Text = "..."
        Me.lblTipoDocRef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTipoDocRef.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(10, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Orden de Compra"
        Me.Label14.Visible = False
        '
        'txtordenCompra
        '
        Me.txtordenCompra.BackColor = System.Drawing.Color.White
        Me.txtordenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtordenCompra.Location = New System.Drawing.Point(104, 58)
        Me.txtordenCompra.Name = "txtordenCompra"
        Me.txtordenCompra.Size = New System.Drawing.Size(195, 20)
        Me.txtordenCompra.TabIndex = 8
        Me.txtordenCompra.Tag = "Orden de Compra"
        Me.txtordenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtordenCompra.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(153, 36)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 109
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(175, 111)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 108
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(175, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lbltercero
        '
        Me.lbltercero.AutoSize = True
        Me.lbltercero.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbltercero.ForeColor = System.Drawing.Color.Navy
        Me.lbltercero.Location = New System.Drawing.Point(204, 112)
        Me.lbltercero.Name = "lbltercero"
        Me.lbltercero.Size = New System.Drawing.Size(17, 18)
        Me.lbltercero.TabIndex = 43
        Me.lbltercero.Text = "..."
        Me.lbltercero.Visible = False
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblproveedor.ForeColor = System.Drawing.Color.Navy
        Me.lblproveedor.Location = New System.Drawing.Point(204, 86)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(17, 18)
        Me.lblproveedor.TabIndex = 36
        Me.lblproveedor.Text = "..."
        Me.lblproveedor.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(349, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Orden Fabricacion"
        Me.Label8.Visible = False
        '
        'txtorderFabricacion
        '
        Me.txtorderFabricacion.BackColor = System.Drawing.Color.White
        Me.txtorderFabricacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtorderFabricacion.Location = New System.Drawing.Point(443, 58)
        Me.txtorderFabricacion.Name = "txtorderFabricacion"
        Me.txtorderFabricacion.Size = New System.Drawing.Size(132, 20)
        Me.txtorderFabricacion.TabIndex = 9
        Me.txtorderFabricacion.Tag = "Orden de Fabricacion"
        Me.txtorderFabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtorderFabricacion.Visible = False
        '
        'txtNumeroReferencia
        '
        Me.txtNumeroReferencia.BackColor = System.Drawing.Color.White
        Me.txtNumeroReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroReferencia.Location = New System.Drawing.Point(443, 33)
        Me.txtNumeroReferencia.Name = "txtNumeroReferencia"
        Me.txtNumeroReferencia.Size = New System.Drawing.Size(131, 20)
        Me.txtNumeroReferencia.TabIndex = 7
        Me.txtNumeroReferencia.Tag = "Numero documento Referencia"
        Me.txtNumeroReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumeroReferencia.Visible = False
        '
        'txtcodigoTercero
        '
        Me.txtcodigoTercero.BackColor = System.Drawing.Color.White
        Me.txtcodigoTercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoTercero.Location = New System.Drawing.Point(104, 110)
        Me.txtcodigoTercero.Name = "txtcodigoTercero"
        Me.txtcodigoTercero.ReadOnly = True
        Me.txtcodigoTercero.Size = New System.Drawing.Size(68, 20)
        Me.txtcodigoTercero.TabIndex = 11
        Me.txtcodigoTercero.Tag = "Cliente"
        Me.txtcodigoTercero.Visible = False
        '
        'txtTipoDocumentoRef
        '
        Me.txtTipoDocumentoRef.BackColor = System.Drawing.Color.White
        Me.txtTipoDocumentoRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoDocumentoRef.Location = New System.Drawing.Point(104, 34)
        Me.txtTipoDocumentoRef.Name = "txtTipoDocumentoRef"
        Me.txtTipoDocumentoRef.ReadOnly = True
        Me.txtTipoDocumentoRef.Size = New System.Drawing.Size(46, 20)
        Me.txtTipoDocumentoRef.TabIndex = 6
        Me.txtTipoDocumentoRef.Tag = "Tipo documento Referencia"
        Me.txtTipoDocumentoRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTipoDocumentoRef.Visible = False
        '
        'txtcodigoProveedor
        '
        Me.txtcodigoProveedor.BackColor = System.Drawing.Color.White
        Me.txtcodigoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoProveedor.Location = New System.Drawing.Point(104, 84)
        Me.txtcodigoProveedor.Name = "txtcodigoProveedor"
        Me.txtcodigoProveedor.ReadOnly = True
        Me.txtcodigoProveedor.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoProveedor.TabIndex = 10
        Me.txtcodigoProveedor.Tag = "Proveedor"
        Me.txtcodigoProveedor.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(32, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Centro Costo"
        Me.Label7.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(30, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Tip Doc Ref."
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(367, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Num.Doc.Ref"
        Me.Label10.Visible = False
        '
        'Frm_Parte_Entrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(892, 519)
        Me.Controls.Add(Me.pnlprincipal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbCabceraDocumento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Parte_Entrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parte Entrega"
        Me.pnlprincipal.ResumeLayout(False)
        Me.pnlprincipal.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbCabceraDocumento.ResumeLayout(False)
        Me.gbCabceraDocumento.PerformLayout()
        Me.GbTransaccion.ResumeLayout(False)
        Me.GbTransaccion.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.gbLeyenda.ResumeLayout(False)
        Me.gbLeyenda.PerformLayout()
        Me.GbdetalleDocumento.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        CType(Me.dgvdetalleAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlprincipal As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacenBusqueda As System.Windows.Forms.ComboBox
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
    Friend WithEvents btn_act_costos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Anular As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuiaAnalisis As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbCabceraDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GbTransaccion As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkValorizado As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblprodafabricar As System.Windows.Forms.Label
    Friend WithEvents txtprodafabricar As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtloteFabricar As System.Windows.Forms.TextBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbocentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocRef As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtordenCompra As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbltercero As System.Windows.Forms.Label
    Friend WithEvents lblproveedor As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtorderFabricacion As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroReferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoTercero As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoDocumentoRef As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GbdetalleDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents dgvdetalleAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
