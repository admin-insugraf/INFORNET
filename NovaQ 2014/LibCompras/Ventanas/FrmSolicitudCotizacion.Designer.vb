<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicitudCotizacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSolicitudCotizacion))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDocumentosFactura = New System.Windows.Forms.DataGridView()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtobservacionesgenerales = New System.Windows.Forms.TextBox()
        Me.pnl_prov = New System.Windows.Forms.Panel()
        Me.btn_agregar_proveedor = New System.Windows.Forms.Button()
        Me.btn_agregar_requisicion = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.txtrazon_proveedor = New System.Windows.Forms.TextBox()
        Me.txtcod_proveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncancelaritem = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtobservaciones_articulo = New System.Windows.Forms.TextBox()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.txtcantidad_articulo = New System.Windows.Forms.TextBox()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvListaRequisiciones = New System.Windows.Forms.DataGridView()
        Me.btnAceptarListaRequi = New System.Windows.Forms.Button()
        Me.btnCancelarListaRequi = New System.Windows.Forms.Button()
        Me.tp_proveedor = New System.Windows.Forms.TabPage()
        Me.pnl_proveedor = New System.Windows.Forms.Panel()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgv_proveedor = New System.Windows.Forms.DataGridView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_menos = New System.Windows.Forms.Button()
        Me.btn_mas = New System.Windows.Forms.Button()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.dgv_lista_proveedor = New System.Windows.Forms.DataGridView()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.tc_registro_coti = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvdet_cotizacion_reg = New System.Windows.Forms.DataGridView()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnmodificar_reg = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtfp_cotizacion_reg = New System.Windows.Forms.TextBox()
        Me.txtvo_cotizacion_reg = New System.Windows.Forms.TextBox()
        Me.txtte_cotizacion_reg = New System.Windows.Forms.TextBox()
        Me.txtnum_cotizacion_reg = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtfp_des_cotizacion_reg = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbmoneda_cotizacion_reg = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtfecha_cotizacion_reg = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtobservaciones_reg = New System.Windows.Forms.TextBox()
        Me.txtproveedor_reg = New System.Windows.Forms.TextBox()
        Me.txtcod_proveedor_Reg = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtfecha_reg = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero_reg = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnaceptar_reg = New System.Windows.Forms.Button()
        Me.btncancelar_Reg = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.dtfec_entrega_reg = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtmarca_reg = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtcalidad_reg = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtgarantia_reg = New System.Windows.Forms.TextBox()
        Me.chkigvinc_reg = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtdescpor_reg = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtigvpor_reg = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtprecio_reg = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtcantidad_reg = New System.Windows.Forms.TextBox()
        Me.txtuni_reg = New System.Windows.Forms.TextBox()
        Me.txtdes_pro_reg = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtcod_prod_reg = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnAnular = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnact_coti = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltros.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnl_prov.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvListaRequisiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_proveedor.SuspendLayout()
        Me.pnl_proveedor.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        CType(Me.dgv_lista_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_registro_coti.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvdet_cotizacion_reg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDocumentosFactura
        '
        Me.dgvDocumentosFactura.AllowUserToAddRows = False
        Me.dgvDocumentosFactura.AllowUserToDeleteRows = False
        Me.dgvDocumentosFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocumentosFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDocumentosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocumentosFactura.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDocumentosFactura.Location = New System.Drawing.Point(12, 89)
        Me.dgvDocumentosFactura.MultiSelect = False
        Me.dgvDocumentosFactura.Name = "dgvDocumentosFactura"
        Me.dgvDocumentosFactura.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocumentosFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDocumentosFactura.Size = New System.Drawing.Size(981, 304)
        Me.dgvDocumentosFactura.TabIndex = 139
        '
        'pnlFiltros
        '
        Me.pnlFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFiltros.Controls.Add(Me.GroupBox3)
        Me.pnlFiltros.Controls.Add(Me.GroupBox2)
        Me.pnlFiltros.Controls.Add(Me.gbRangofechas)
        Me.pnlFiltros.Location = New System.Drawing.Point(13, 30)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(997, 55)
        Me.pnlFiltros.TabIndex = 140
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 45)
        Me.GroupBox3.TabIndex = 119
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
        Me.txtFiltro.Size = New System.Drawing.Size(465, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(497, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 45)
        Me.GroupBox2.TabIndex = 120
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
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(215, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(732, 5)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 121
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
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(10, 392)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(369, 26)
        Me.lblCantidad.TabIndex = 148
        Me.lblCantidad.Text = "."
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Controls.Add(Me.TabPage3)
        Me.tc_tipos.Controls.Add(Me.tp_proveedor)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 28)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(1003, 379)
        Me.tc_tipos.TabIndex = 149
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.gbOpciones)
        Me.TabPage1.Controls.Add(Me.dgvDetalle)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(995, 353)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Solicitud de Cotización"
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Location = New System.Drawing.Point(912, 137)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(69, 193)
        Me.gbOpciones.TabIndex = 116
        Me.gbOpciones.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(4, 72)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(59, 43)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnquitar.Location = New System.Drawing.Point(4, 131)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(59, 43)
        Me.btnquitar.TabIndex = 9
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(4, 13)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(59, 43)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(6, 144)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(900, 188)
        Me.dgvDetalle.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtobservacionesgenerales)
        Me.GroupBox1.Controls.Add(Me.pnl_prov)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_requisicion)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtruc)
        Me.GroupBox1.Controls.Add(Me.txtrazon_proveedor)
        Me.GroupBox1.Controls.Add(Me.txtcod_proveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtfecha)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(981, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(18, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Observaciones"
        '
        'txtobservacionesgenerales
        '
        Me.txtobservacionesgenerales.BackColor = System.Drawing.Color.Aquamarine
        Me.txtobservacionesgenerales.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacionesgenerales.Location = New System.Drawing.Point(17, 105)
        Me.txtobservacionesgenerales.Multiline = True
        Me.txtobservacionesgenerales.Name = "txtobservacionesgenerales"
        Me.txtobservacionesgenerales.Size = New System.Drawing.Size(926, 20)
        Me.txtobservacionesgenerales.TabIndex = 113
        '
        'pnl_prov
        '
        Me.pnl_prov.Controls.Add(Me.btn_agregar_proveedor)
        Me.pnl_prov.Location = New System.Drawing.Point(17, 43)
        Me.pnl_prov.Name = "pnl_prov"
        Me.pnl_prov.Size = New System.Drawing.Size(781, 40)
        Me.pnl_prov.TabIndex = 112
        '
        'btn_agregar_proveedor
        '
        Me.btn_agregar_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar_proveedor.Image = CType(resources.GetObject("btn_agregar_proveedor.Image"), System.Drawing.Image)
        Me.btn_agregar_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar_proveedor.Location = New System.Drawing.Point(72, 7)
        Me.btn_agregar_proveedor.Name = "btn_agregar_proveedor"
        Me.btn_agregar_proveedor.Size = New System.Drawing.Size(79, 27)
        Me.btn_agregar_proveedor.TabIndex = 111
        Me.btn_agregar_proveedor.Text = "Proveedor"
        Me.btn_agregar_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar_proveedor.UseVisualStyleBackColor = True
        '
        'btn_agregar_requisicion
        '
        Me.btn_agregar_requisicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_agregar_requisicion.FlatAppearance.BorderSize = 0
        Me.btn_agregar_requisicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar_requisicion.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar_requisicion.Image = CType(resources.GetObject("btn_agregar_requisicion.Image"), System.Drawing.Image)
        Me.btn_agregar_requisicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar_requisicion.Location = New System.Drawing.Point(804, 47)
        Me.btn_agregar_requisicion.Name = "btn_agregar_requisicion"
        Me.btn_agregar_requisicion.Size = New System.Drawing.Size(139, 27)
        Me.btn_agregar_requisicion.TabIndex = 6
        Me.btn_agregar_requisicion.Text = "&Agregar Requisición"
        Me.btn_agregar_requisicion.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(255, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(638, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Ruc"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(289, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Razon Social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(35, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Proveedor"
        '
        'txtruc
        '
        Me.txtruc.BackColor = System.Drawing.SystemColors.Menu
        Me.txtruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtruc.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruc.Location = New System.Drawing.Point(671, 50)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.ReadOnly = True
        Me.txtruc.Size = New System.Drawing.Size(126, 22)
        Me.txtruc.TabIndex = 4
        '
        'txtrazon_proveedor
        '
        Me.txtrazon_proveedor.BackColor = System.Drawing.SystemColors.Menu
        Me.txtrazon_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrazon_proveedor.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrazon_proveedor.Location = New System.Drawing.Point(372, 50)
        Me.txtrazon_proveedor.Name = "txtrazon_proveedor"
        Me.txtrazon_proveedor.ReadOnly = True
        Me.txtrazon_proveedor.Size = New System.Drawing.Size(260, 22)
        Me.txtrazon_proveedor.TabIndex = 3
        '
        'txtcod_proveedor
        '
        Me.txtcod_proveedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcod_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcod_proveedor.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod_proveedor.Location = New System.Drawing.Point(107, 48)
        Me.txtcod_proveedor.Name = "txtcod_proveedor"
        Me.txtcod_proveedor.Size = New System.Drawing.Size(170, 22)
        Me.txtcod_proveedor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(285, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nro.Cotizacion"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(68, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha"
        '
        'dtfecha
        '
        Me.dtfecha.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtfecha.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(110, 14)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(170, 24)
        Me.dtfecha.TabIndex = 0
        Me.dtfecha.Tag = ""
        '
        'txtnumero
        '
        Me.txtnumero.BackColor = System.Drawing.SystemColors.Menu
        Me.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumero.Enabled = False
        Me.txtnumero.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(372, 16)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(164, 22)
        Me.txtnumero.TabIndex = 1
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnumero.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(995, 353)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Agregar nuevo item"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1144, 330)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.btnAceptar)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.btncancelaritem)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txtobservaciones_articulo)
        Me.GroupBox6.Controls.Add(Me.txtarea)
        Me.GroupBox6.Controls.Add(Me.txtcantidad_articulo)
        Me.GroupBox6.Controls.Add(Me.txtunidadMedida)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Location = New System.Drawing.Point(25, 72)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(601, 235)
        Me.GroupBox6.TabIndex = 146
        Me.GroupBox6.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(190, 191)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(69, 36)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(20, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Observaciones"
        '
        'btncancelaritem
        '
        Me.btncancelaritem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btncancelaritem.FlatAppearance.BorderSize = 0
        Me.btncancelaritem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancelaritem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelaritem.ForeColor = System.Drawing.Color.Blue
        Me.btncancelaritem.Image = CType(resources.GetObject("btncancelaritem.Image"), System.Drawing.Image)
        Me.btncancelaritem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelaritem.Location = New System.Drawing.Point(265, 191)
        Me.btncancelaritem.Name = "btncancelaritem"
        Me.btncancelaritem.Size = New System.Drawing.Size(69, 36)
        Me.btncancelaritem.TabIndex = 17
        Me.btncancelaritem.Text = "&Cancelar"
        Me.btncancelaritem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelaritem.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(134, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Area"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(18, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Cantidad"
        '
        'txtobservaciones_articulo
        '
        Me.txtobservaciones_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtobservaciones_articulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtobservaciones_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobservaciones_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtobservaciones_articulo.Location = New System.Drawing.Point(16, 124)
        Me.txtobservaciones_articulo.Multiline = True
        Me.txtobservaciones_articulo.Name = "txtobservaciones_articulo"
        Me.txtobservaciones_articulo.Size = New System.Drawing.Size(576, 57)
        Me.txtobservaciones_articulo.TabIndex = 15
        '
        'txtarea
        '
        Me.txtarea.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtarea.BackColor = System.Drawing.Color.Aquamarine
        Me.txtarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtarea.Location = New System.Drawing.Point(137, 75)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(338, 20)
        Me.txtarea.TabIndex = 14
        Me.txtarea.Visible = False
        '
        'txtcantidad_articulo
        '
        Me.txtcantidad_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcantidad_articulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtcantidad_articulo.Location = New System.Drawing.Point(16, 75)
        Me.txtcantidad_articulo.Name = "txtcantidad_articulo"
        Me.txtcantidad_articulo.Size = New System.Drawing.Size(105, 20)
        Me.txtcantidad_articulo.TabIndex = 13
        '
        'txtunidadMedida
        '
        Me.txtunidadMedida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtunidadMedida.BackColor = System.Drawing.SystemColors.Menu
        Me.txtunidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtunidadMedida.Location = New System.Drawing.Point(16, 33)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.ReadOnly = True
        Me.txtunidadMedida.Size = New System.Drawing.Size(105, 20)
        Me.txtunidadMedida.TabIndex = 12
        Me.txtunidadMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(20, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Unid. Med"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.PictureBox1)
        Me.GroupBox7.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox7.Location = New System.Drawing.Point(25, 21)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(601, 45)
        Me.GroupBox7.TabIndex = 145
        Me.GroupBox7.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtdescripcionArticulo.BackColor = System.Drawing.SystemColors.Menu
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(137, 14)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(446, 20)
        Me.txtdescripcionArticulo.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Articulo"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(61, 14)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(53, 20)
        Me.txtcodigoArticulo.TabIndex = 10
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.dgvListaRequisiciones)
        Me.TabPage3.Controls.Add(Me.btnAceptarListaRequi)
        Me.TabPage3.Controls.Add(Me.btnCancelarListaRequi)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(995, 353)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Lista de Requisiciones"
        '
        'dgvListaRequisiciones
        '
        Me.dgvListaRequisiciones.AllowUserToAddRows = False
        Me.dgvListaRequisiciones.AllowUserToDeleteRows = False
        Me.dgvListaRequisiciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListaRequisiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaRequisiciones.Location = New System.Drawing.Point(11, 17)
        Me.dgvListaRequisiciones.Name = "dgvListaRequisiciones"
        Me.dgvListaRequisiciones.Size = New System.Drawing.Size(1138, 267)
        Me.dgvListaRequisiciones.TabIndex = 18
        '
        'btnAceptarListaRequi
        '
        Me.btnAceptarListaRequi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptarListaRequi.FlatAppearance.BorderSize = 0
        Me.btnAceptarListaRequi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptarListaRequi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarListaRequi.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptarListaRequi.Image = CType(resources.GetObject("btnAceptarListaRequi.Image"), System.Drawing.Image)
        Me.btnAceptarListaRequi.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptarListaRequi.Location = New System.Drawing.Point(478, 298)
        Me.btnAceptarListaRequi.Name = "btnAceptarListaRequi"
        Me.btnAceptarListaRequi.Size = New System.Drawing.Size(69, 36)
        Me.btnAceptarListaRequi.TabIndex = 19
        Me.btnAceptarListaRequi.Text = "&Aceptar"
        Me.btnAceptarListaRequi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptarListaRequi.UseVisualStyleBackColor = True
        '
        'btnCancelarListaRequi
        '
        Me.btnCancelarListaRequi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarListaRequi.FlatAppearance.BorderSize = 0
        Me.btnCancelarListaRequi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelarListaRequi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarListaRequi.ForeColor = System.Drawing.Color.Blue
        Me.btnCancelarListaRequi.Image = CType(resources.GetObject("btnCancelarListaRequi.Image"), System.Drawing.Image)
        Me.btnCancelarListaRequi.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelarListaRequi.Location = New System.Drawing.Point(553, 298)
        Me.btnCancelarListaRequi.Name = "btnCancelarListaRequi"
        Me.btnCancelarListaRequi.Size = New System.Drawing.Size(69, 36)
        Me.btnCancelarListaRequi.TabIndex = 20
        Me.btnCancelarListaRequi.Text = "&Cancelar"
        Me.btnCancelarListaRequi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelarListaRequi.UseVisualStyleBackColor = True
        '
        'tp_proveedor
        '
        Me.tp_proveedor.BackColor = System.Drawing.Color.White
        Me.tp_proveedor.Controls.Add(Me.pnl_proveedor)
        Me.tp_proveedor.ForeColor = System.Drawing.Color.Navy
        Me.tp_proveedor.Location = New System.Drawing.Point(4, 22)
        Me.tp_proveedor.Name = "tp_proveedor"
        Me.tp_proveedor.Size = New System.Drawing.Size(995, 353)
        Me.tp_proveedor.TabIndex = 3
        Me.tp_proveedor.Text = "Ingreso Proveedor"
        '
        'pnl_proveedor
        '
        Me.pnl_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_proveedor.Controls.Add(Me.GroupBox14)
        Me.pnl_proveedor.ForeColor = System.Drawing.Color.Navy
        Me.pnl_proveedor.Location = New System.Drawing.Point(19, 17)
        Me.pnl_proveedor.Name = "pnl_proveedor"
        Me.pnl_proveedor.Size = New System.Drawing.Size(959, 314)
        Me.pnl_proveedor.TabIndex = 152
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.Controls.Add(Me.GroupBox4)
        Me.GroupBox14.Controls.Add(Me.btn_cancel)
        Me.GroupBox14.Controls.Add(Me.btn_aceptar)
        Me.GroupBox14.Controls.Add(Me.btn_menos)
        Me.GroupBox14.Controls.Add(Me.btn_mas)
        Me.GroupBox14.Controls.Add(Me.GroupBox15)
        Me.GroupBox14.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox14.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(944, 297)
        Me.GroupBox14.TabIndex = 0
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Proveedores"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.dgv_proveedor)
        Me.GroupBox4.Location = New System.Drawing.Point(469, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(459, 227)
        Me.GroupBox4.TabIndex = 159
        Me.GroupBox4.TabStop = False
        '
        'dgv_proveedor
        '
        Me.dgv_proveedor.AllowUserToAddRows = False
        Me.dgv_proveedor.AllowUserToDeleteRows = False
        Me.dgv_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedor.Location = New System.Drawing.Point(9, 41)
        Me.dgv_proveedor.Name = "dgv_proveedor"
        Me.dgv_proveedor.ReadOnly = True
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_proveedor.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_proveedor.Size = New System.Drawing.Size(440, 172)
        Me.dgv_proveedor.TabIndex = 155
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.Location = New System.Drawing.Point(708, 251)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(69, 36)
        Me.btn_cancel.TabIndex = 158
        Me.btn_cancel.Text = "Cancelar"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_aceptar.Location = New System.Drawing.Point(630, 251)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(69, 36)
        Me.btn_aceptar.TabIndex = 157
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_menos
        '
        Me.btn_menos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_menos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menos.Location = New System.Drawing.Point(280, 251)
        Me.btn_menos.Name = "btn_menos"
        Me.btn_menos.Size = New System.Drawing.Size(69, 36)
        Me.btn_menos.TabIndex = 156
        Me.btn_menos.Text = "<"
        Me.btn_menos.UseVisualStyleBackColor = True
        '
        'btn_mas
        '
        Me.btn_mas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_mas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mas.Location = New System.Drawing.Point(193, 251)
        Me.btn_mas.Name = "btn_mas"
        Me.btn_mas.Size = New System.Drawing.Size(69, 36)
        Me.btn_mas.TabIndex = 155
        Me.btn_mas.Text = ">"
        Me.btn_mas.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox15.Controls.Add(Me.dgv_lista_proveedor)
        Me.GroupBox15.Controls.Add(Me.txtbusqueda)
        Me.GroupBox15.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(455, 227)
        Me.GroupBox15.TabIndex = 153
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Ingrese texto a Buscar :"
        '
        'dgv_lista_proveedor
        '
        Me.dgv_lista_proveedor.AllowUserToAddRows = False
        Me.dgv_lista_proveedor.AllowUserToDeleteRows = False
        Me.dgv_lista_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_proveedor.Location = New System.Drawing.Point(7, 42)
        Me.dgv_lista_proveedor.Name = "dgv_lista_proveedor"
        Me.dgv_lista_proveedor.ReadOnly = True
        Me.dgv_lista_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_proveedor.Size = New System.Drawing.Size(435, 176)
        Me.dgv_lista_proveedor.TabIndex = 25
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbusqueda.BackColor = System.Drawing.Color.Aquamarine
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbusqueda.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(7, 16)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(435, 22)
        Me.txtbusqueda.TabIndex = 24
        '
        'tc_registro_coti
        '
        Me.tc_registro_coti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_registro_coti.Controls.Add(Me.TabPage4)
        Me.tc_registro_coti.Controls.Add(Me.TabPage5)
        Me.tc_registro_coti.Location = New System.Drawing.Point(8, 30)
        Me.tc_registro_coti.Name = "tc_registro_coti"
        Me.tc_registro_coti.SelectedIndex = 0
        Me.tc_registro_coti.Size = New System.Drawing.Size(1003, 377)
        Me.tc_registro_coti.TabIndex = 151
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.dgvdet_cotizacion_reg)
        Me.TabPage4.Controls.Add(Me.GroupBox8)
        Me.TabPage4.Controls.Add(Me.GroupBox10)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(995, 351)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Registro de Datos de Cotización"
        '
        'dgvdet_cotizacion_reg
        '
        Me.dgvdet_cotizacion_reg.AllowUserToAddRows = False
        Me.dgvdet_cotizacion_reg.AllowUserToDeleteRows = False
        Me.dgvdet_cotizacion_reg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdet_cotizacion_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdet_cotizacion_reg.Location = New System.Drawing.Point(6, 179)
        Me.dgvdet_cotizacion_reg.Name = "dgvdet_cotizacion_reg"
        Me.dgvdet_cotizacion_reg.Size = New System.Drawing.Size(869, 304)
        Me.dgvdet_cotizacion_reg.TabIndex = 5
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Location = New System.Drawing.Point(881, 173)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(108, 304)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.btnmodificar_reg)
        Me.GroupBox9.Location = New System.Drawing.Point(20, 41)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(69, 285)
        Me.GroupBox9.TabIndex = 116
        Me.GroupBox9.TabStop = False
        '
        'btnmodificar_reg
        '
        Me.btnmodificar_reg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar_reg.ForeColor = System.Drawing.Color.Navy
        Me.btnmodificar_reg.Image = CType(resources.GetObject("btnmodificar_reg.Image"), System.Drawing.Image)
        Me.btnmodificar_reg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmodificar_reg.Location = New System.Drawing.Point(6, 28)
        Me.btnmodificar_reg.Name = "btnmodificar_reg"
        Me.btnmodificar_reg.Size = New System.Drawing.Size(59, 42)
        Me.btnmodificar_reg.TabIndex = 8
        Me.btnmodificar_reg.Text = "&Modificar"
        Me.btnmodificar_reg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificar_reg.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.GroupBox11)
        Me.GroupBox10.Controls.Add(Me.Label8)
        Me.GroupBox10.Controls.Add(Me.Label12)
        Me.GroupBox10.Controls.Add(Me.Label14)
        Me.GroupBox10.Controls.Add(Me.txtobservaciones_reg)
        Me.GroupBox10.Controls.Add(Me.txtproveedor_reg)
        Me.GroupBox10.Controls.Add(Me.txtcod_proveedor_Reg)
        Me.GroupBox10.Controls.Add(Me.Label15)
        Me.GroupBox10.Controls.Add(Me.Label16)
        Me.GroupBox10.Controls.Add(Me.dtfecha_reg)
        Me.GroupBox10.Controls.Add(Me.txtnumero_reg)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(983, 174)
        Me.GroupBox10.TabIndex = 3
        Me.GroupBox10.TabStop = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox11.BackColor = System.Drawing.Color.White
        Me.GroupBox11.Controls.Add(Me.txtfp_cotizacion_reg)
        Me.GroupBox11.Controls.Add(Me.txtvo_cotizacion_reg)
        Me.GroupBox11.Controls.Add(Me.txtte_cotizacion_reg)
        Me.GroupBox11.Controls.Add(Me.txtnum_cotizacion_reg)
        Me.GroupBox11.Controls.Add(Me.Label22)
        Me.GroupBox11.Controls.Add(Me.Label21)
        Me.GroupBox11.Controls.Add(Me.PictureBox3)
        Me.GroupBox11.Controls.Add(Me.txtfp_des_cotizacion_reg)
        Me.GroupBox11.Controls.Add(Me.Label20)
        Me.GroupBox11.Controls.Add(Me.Label19)
        Me.GroupBox11.Controls.Add(Me.cmbmoneda_cotizacion_reg)
        Me.GroupBox11.Controls.Add(Me.Label11)
        Me.GroupBox11.Controls.Add(Me.Label17)
        Me.GroupBox11.Controls.Add(Me.dtfecha_cotizacion_reg)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox11.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(959, 99)
        Me.GroupBox11.TabIndex = 35
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Datos de Cotización"
        '
        'txtfp_cotizacion_reg
        '
        Me.txtfp_cotizacion_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtfp_cotizacion_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfp_cotizacion_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtfp_cotizacion_reg.Location = New System.Drawing.Point(502, 30)
        Me.txtfp_cotizacion_reg.Name = "txtfp_cotizacion_reg"
        Me.txtfp_cotizacion_reg.Size = New System.Drawing.Size(51, 20)
        Me.txtfp_cotizacion_reg.TabIndex = 121
        '
        'txtvo_cotizacion_reg
        '
        Me.txtvo_cotizacion_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtvo_cotizacion_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvo_cotizacion_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtvo_cotizacion_reg.Location = New System.Drawing.Point(502, 72)
        Me.txtvo_cotizacion_reg.MaxLength = 75
        Me.txtvo_cotizacion_reg.Name = "txtvo_cotizacion_reg"
        Me.txtvo_cotizacion_reg.Size = New System.Drawing.Size(533, 20)
        Me.txtvo_cotizacion_reg.TabIndex = 120
        '
        'txtte_cotizacion_reg
        '
        Me.txtte_cotizacion_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtte_cotizacion_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtte_cotizacion_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtte_cotizacion_reg.Location = New System.Drawing.Point(10, 72)
        Me.txtte_cotizacion_reg.MaxLength = 75
        Me.txtte_cotizacion_reg.Name = "txtte_cotizacion_reg"
        Me.txtte_cotizacion_reg.Size = New System.Drawing.Size(444, 20)
        Me.txtte_cotizacion_reg.TabIndex = 119
        '
        'txtnum_cotizacion_reg
        '
        Me.txtnum_cotizacion_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtnum_cotizacion_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnum_cotizacion_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtnum_cotizacion_reg.Location = New System.Drawing.Point(10, 30)
        Me.txtnum_cotizacion_reg.MaxLength = 10
        Me.txtnum_cotizacion_reg.Name = "txtnum_cotizacion_reg"
        Me.txtnum_cotizacion_reg.Size = New System.Drawing.Size(181, 20)
        Me.txtnum_cotizacion_reg.TabIndex = 118
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(499, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 13)
        Me.Label22.TabIndex = 117
        Me.Label22.Text = "Validez de la Oferta"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(7, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 13)
        Me.Label21.TabIndex = 115
        Me.Label21.Text = "Tiempo de entrega"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(557, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 113
        Me.PictureBox3.TabStop = False
        '
        'txtfp_des_cotizacion_reg
        '
        Me.txtfp_des_cotizacion_reg.BackColor = System.Drawing.SystemColors.Menu
        Me.txtfp_des_cotizacion_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfp_des_cotizacion_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtfp_des_cotizacion_reg.Location = New System.Drawing.Point(578, 30)
        Me.txtfp_des_cotizacion_reg.Name = "txtfp_des_cotizacion_reg"
        Me.txtfp_des_cotizacion_reg.Size = New System.Drawing.Size(457, 20)
        Me.txtfp_des_cotizacion_reg.TabIndex = 112
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(499, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 13)
        Me.Label20.TabIndex = 110
        Me.Label20.Text = "Forma de Pago"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(330, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Moneda"
        '
        'cmbmoneda_cotizacion_reg
        '
        Me.cmbmoneda_cotizacion_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmoneda_cotizacion_reg.FormattingEnabled = True
        Me.cmbmoneda_cotizacion_reg.Items.AddRange(New Object() {"M. Nacional", "M. Extranjera"})
        Me.cmbmoneda_cotizacion_reg.Location = New System.Drawing.Point(333, 31)
        Me.cmbmoneda_cotizacion_reg.Name = "cmbmoneda_cotizacion_reg"
        Me.cmbmoneda_cotizacion_reg.Size = New System.Drawing.Size(121, 21)
        Me.cmbmoneda_cotizacion_reg.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Número"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(194, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Fecha"
        '
        'dtfecha_cotizacion_reg
        '
        Me.dtfecha_cotizacion_reg.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtfecha_cotizacion_reg.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha_cotizacion_reg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha_cotizacion_reg.Location = New System.Drawing.Point(197, 30)
        Me.dtfecha_cotizacion_reg.Name = "dtfecha_cotizacion_reg"
        Me.dtfecha_cotizacion_reg.Size = New System.Drawing.Size(95, 24)
        Me.dtfecha_cotizacion_reg.TabIndex = 28
        Me.dtfecha_cotizacion_reg.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(9, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Observaciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(587, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Razon Social"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(353, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Proveedor"
        '
        'txtobservaciones_reg
        '
        Me.txtobservaciones_reg.BackColor = System.Drawing.SystemColors.Menu
        Me.txtobservaciones_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobservaciones_reg.Enabled = False
        Me.txtobservaciones_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtobservaciones_reg.Location = New System.Drawing.Point(105, 42)
        Me.txtobservaciones_reg.Multiline = True
        Me.txtobservaciones_reg.Name = "txtobservaciones_reg"
        Me.txtobservaciones_reg.Size = New System.Drawing.Size(955, 21)
        Me.txtobservaciones_reg.TabIndex = 5
        '
        'txtproveedor_reg
        '
        Me.txtproveedor_reg.BackColor = System.Drawing.SystemColors.Menu
        Me.txtproveedor_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor_reg.Enabled = False
        Me.txtproveedor_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtproveedor_reg.Location = New System.Drawing.Point(671, 16)
        Me.txtproveedor_reg.Name = "txtproveedor_reg"
        Me.txtproveedor_reg.ReadOnly = True
        Me.txtproveedor_reg.Size = New System.Drawing.Size(389, 20)
        Me.txtproveedor_reg.TabIndex = 3
        '
        'txtcod_proveedor_Reg
        '
        Me.txtcod_proveedor_Reg.BackColor = System.Drawing.SystemColors.Menu
        Me.txtcod_proveedor_Reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcod_proveedor_Reg.Enabled = False
        Me.txtcod_proveedor_Reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtcod_proveedor_Reg.Location = New System.Drawing.Point(425, 15)
        Me.txtcod_proveedor_Reg.Name = "txtcod_proveedor_Reg"
        Me.txtcod_proveedor_Reg.Size = New System.Drawing.Size(156, 20)
        Me.txtcod_proveedor_Reg.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(9, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Número"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(206, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Fecha"
        '
        'dtfecha_reg
        '
        Me.dtfecha_reg.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtfecha_reg.Enabled = False
        Me.dtfecha_reg.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha_reg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha_reg.Location = New System.Drawing.Point(252, 12)
        Me.dtfecha_reg.Name = "dtfecha_reg"
        Me.dtfecha_reg.Size = New System.Drawing.Size(95, 24)
        Me.dtfecha_reg.TabIndex = 1
        Me.dtfecha_reg.Tag = ""
        '
        'txtnumero_reg
        '
        Me.txtnumero_reg.BackColor = System.Drawing.SystemColors.Menu
        Me.txtnumero_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumero_reg.Enabled = False
        Me.txtnumero_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtnumero_reg.Location = New System.Drawing.Point(66, 15)
        Me.txtnumero_reg.Name = "txtnumero_reg"
        Me.txtnumero_reg.Size = New System.Drawing.Size(134, 20)
        Me.txtnumero_reg.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.btnaceptar_reg)
        Me.TabPage5.Controls.Add(Me.btncancelar_Reg)
        Me.TabPage5.Controls.Add(Me.GroupBox12)
        Me.TabPage5.Controls.Add(Me.GroupBox13)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(995, 47)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Actualización de datos de Cotizacion"
        '
        'btnaceptar_reg
        '
        Me.btnaceptar_reg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnaceptar_reg.FlatAppearance.BorderSize = 0
        Me.btnaceptar_reg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaceptar_reg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar_reg.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar_reg.Image = CType(resources.GetObject("btnaceptar_reg.Image"), System.Drawing.Image)
        Me.btnaceptar_reg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnaceptar_reg.Location = New System.Drawing.Point(298, 290)
        Me.btnaceptar_reg.Name = "btnaceptar_reg"
        Me.btnaceptar_reg.Size = New System.Drawing.Size(69, 36)
        Me.btnaceptar_reg.TabIndex = 147
        Me.btnaceptar_reg.Text = "&Aceptar"
        Me.btnaceptar_reg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnaceptar_reg.UseVisualStyleBackColor = True
        '
        'btncancelar_Reg
        '
        Me.btncancelar_Reg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btncancelar_Reg.FlatAppearance.BorderSize = 0
        Me.btncancelar_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancelar_Reg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar_Reg.ForeColor = System.Drawing.Color.Blue
        Me.btncancelar_Reg.Image = CType(resources.GetObject("btncancelar_Reg.Image"), System.Drawing.Image)
        Me.btncancelar_Reg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar_Reg.Location = New System.Drawing.Point(373, 290)
        Me.btncancelar_Reg.Name = "btncancelar_Reg"
        Me.btncancelar_Reg.Size = New System.Drawing.Size(69, 36)
        Me.btncancelar_Reg.TabIndex = 148
        Me.btncancelar_Reg.Text = "&Cancelar"
        Me.btncancelar_Reg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar_Reg.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox12.Controls.Add(Me.Label33)
        Me.GroupBox12.Controls.Add(Me.dtfec_entrega_reg)
        Me.GroupBox12.Controls.Add(Me.Label32)
        Me.GroupBox12.Controls.Add(Me.txtmarca_reg)
        Me.GroupBox12.Controls.Add(Me.Label31)
        Me.GroupBox12.Controls.Add(Me.txtcalidad_reg)
        Me.GroupBox12.Controls.Add(Me.Label30)
        Me.GroupBox12.Controls.Add(Me.txtgarantia_reg)
        Me.GroupBox12.Controls.Add(Me.chkigvinc_reg)
        Me.GroupBox12.Controls.Add(Me.Label28)
        Me.GroupBox12.Controls.Add(Me.txtdescpor_reg)
        Me.GroupBox12.Controls.Add(Me.Label24)
        Me.GroupBox12.Controls.Add(Me.txtigvpor_reg)
        Me.GroupBox12.Controls.Add(Me.Label23)
        Me.GroupBox12.Controls.Add(Me.txtprecio_reg)
        Me.GroupBox12.Location = New System.Drawing.Point(8, 93)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(554, 184)
        Me.GroupBox12.TabIndex = 150
        Me.GroupBox12.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(8, 134)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(92, 13)
        Me.Label33.TabIndex = 128
        Me.Label33.Text = "Fecha de Entrega"
        '
        'dtfec_entrega_reg
        '
        Me.dtfec_entrega_reg.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtfec_entrega_reg.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfec_entrega_reg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfec_entrega_reg.Location = New System.Drawing.Point(127, 128)
        Me.dtfec_entrega_reg.Name = "dtfec_entrega_reg"
        Me.dtfec_entrega_reg.Size = New System.Drawing.Size(115, 24)
        Me.dtfec_entrega_reg.TabIndex = 127
        Me.dtfec_entrega_reg.Tag = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(8, 105)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 13)
        Me.Label32.TabIndex = 126
        Me.Label32.Text = "Marca/Modelo"
        '
        'txtmarca_reg
        '
        Me.txtmarca_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtmarca_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmarca_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtmarca_reg.Location = New System.Drawing.Point(127, 101)
        Me.txtmarca_reg.MaxLength = 75
        Me.txtmarca_reg.Name = "txtmarca_reg"
        Me.txtmarca_reg.Size = New System.Drawing.Size(565, 20)
        Me.txtmarca_reg.TabIndex = 125
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(8, 78)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 13)
        Me.Label31.TabIndex = 124
        Me.Label31.Text = "Calidad"
        '
        'txtcalidad_reg
        '
        Me.txtcalidad_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcalidad_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcalidad_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtcalidad_reg.Location = New System.Drawing.Point(127, 73)
        Me.txtcalidad_reg.MaxLength = 75
        Me.txtcalidad_reg.Name = "txtcalidad_reg"
        Me.txtcalidad_reg.Size = New System.Drawing.Size(565, 20)
        Me.txtcalidad_reg.TabIndex = 123
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(8, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 13)
        Me.Label30.TabIndex = 122
        Me.Label30.Text = "Garantia"
        '
        'txtgarantia_reg
        '
        Me.txtgarantia_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtgarantia_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgarantia_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtgarantia_reg.Location = New System.Drawing.Point(127, 46)
        Me.txtgarantia_reg.MaxLength = 75
        Me.txtgarantia_reg.Name = "txtgarantia_reg"
        Me.txtgarantia_reg.Size = New System.Drawing.Size(565, 20)
        Me.txtgarantia_reg.TabIndex = 121
        '
        'chkigvinc_reg
        '
        Me.chkigvinc_reg.AutoSize = True
        Me.chkigvinc_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkigvinc_reg.ForeColor = System.Drawing.Color.Navy
        Me.chkigvinc_reg.Location = New System.Drawing.Point(254, 22)
        Me.chkigvinc_reg.Name = "chkigvinc_reg"
        Me.chkigvinc_reg.Size = New System.Drawing.Size(84, 17)
        Me.chkigvinc_reg.TabIndex = 120
        Me.chkigvinc_reg.Text = "Incluido IGV"
        Me.chkigvinc_reg.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(505, 23)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 13)
        Me.Label28.TabIndex = 119
        Me.Label28.Text = "Descuento (%)"
        '
        'txtdescpor_reg
        '
        Me.txtdescpor_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtdescpor_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescpor_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtdescpor_reg.Location = New System.Drawing.Point(617, 19)
        Me.txtdescpor_reg.Name = "txtdescpor_reg"
        Me.txtdescpor_reg.Size = New System.Drawing.Size(75, 20)
        Me.txtdescpor_reg.TabIndex = 118
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(370, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 117
        Me.Label24.Text = "IGV (%)"
        '
        'txtigvpor_reg
        '
        Me.txtigvpor_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtigvpor_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtigvpor_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtigvpor_reg.Location = New System.Drawing.Point(429, 19)
        Me.txtigvpor_reg.Name = "txtigvpor_reg"
        Me.txtigvpor_reg.Size = New System.Drawing.Size(61, 20)
        Me.txtigvpor_reg.TabIndex = 116
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(8, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 115
        Me.Label23.Text = "Precio"
        '
        'txtprecio_reg
        '
        Me.txtprecio_reg.BackColor = System.Drawing.Color.Aquamarine
        Me.txtprecio_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecio_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtprecio_reg.Location = New System.Drawing.Point(127, 19)
        Me.txtprecio_reg.Name = "txtprecio_reg"
        Me.txtprecio_reg.Size = New System.Drawing.Size(115, 20)
        Me.txtprecio_reg.TabIndex = 114
        '
        'GroupBox13
        '
        Me.GroupBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox13.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox13.Controls.Add(Me.Label27)
        Me.GroupBox13.Controls.Add(Me.txtcantidad_reg)
        Me.GroupBox13.Controls.Add(Me.txtuni_reg)
        Me.GroupBox13.Controls.Add(Me.txtdes_pro_reg)
        Me.GroupBox13.Controls.Add(Me.Label29)
        Me.GroupBox13.Controls.Add(Me.txtcod_prod_reg)
        Me.GroupBox13.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(554, 79)
        Me.GroupBox13.TabIndex = 149
        Me.GroupBox13.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(8, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 113
        Me.Label27.Text = "Cantidad"
        '
        'txtcantidad_reg
        '
        Me.txtcantidad_reg.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtcantidad_reg.BackColor = System.Drawing.Color.White
        Me.txtcantidad_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad_reg.Enabled = False
        Me.txtcantidad_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtcantidad_reg.Location = New System.Drawing.Point(78, 44)
        Me.txtcantidad_reg.Name = "txtcantidad_reg"
        Me.txtcantidad_reg.Size = New System.Drawing.Size(94, 20)
        Me.txtcantidad_reg.TabIndex = 112
        '
        'txtuni_reg
        '
        Me.txtuni_reg.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtuni_reg.BackColor = System.Drawing.Color.White
        Me.txtuni_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuni_reg.Enabled = False
        Me.txtuni_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtuni_reg.Location = New System.Drawing.Point(579, 18)
        Me.txtuni_reg.Name = "txtuni_reg"
        Me.txtuni_reg.ReadOnly = True
        Me.txtuni_reg.Size = New System.Drawing.Size(94, 20)
        Me.txtuni_reg.TabIndex = 111
        Me.txtuni_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdes_pro_reg
        '
        Me.txtdes_pro_reg.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtdes_pro_reg.BackColor = System.Drawing.Color.White
        Me.txtdes_pro_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdes_pro_reg.Enabled = False
        Me.txtdes_pro_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtdes_pro_reg.Location = New System.Drawing.Point(178, 17)
        Me.txtdes_pro_reg.Name = "txtdes_pro_reg"
        Me.txtdes_pro_reg.ReadOnly = True
        Me.txtdes_pro_reg.Size = New System.Drawing.Size(393, 20)
        Me.txtdes_pro_reg.TabIndex = 11
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(8, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 13)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Articulo"
        '
        'txtcod_prod_reg
        '
        Me.txtcod_prod_reg.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtcod_prod_reg.BackColor = System.Drawing.Color.White
        Me.txtcod_prod_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcod_prod_reg.Enabled = False
        Me.txtcod_prod_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtcod_prod_reg.Location = New System.Drawing.Point(78, 17)
        Me.txtcod_prod_reg.Name = "txtcod_prod_reg"
        Me.txtcod_prod_reg.Size = New System.Drawing.Size(94, 20)
        Me.txtcod_prod_reg.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btnEliminar, Me.btnAnular, Me.btnImprimir, Me.btnact_coti, Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1028, 25)
        Me.ToolStrip1.TabIndex = 181
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
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(73, 22)
        Me.btnGrabar.Text = "&Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 22)
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.Visible = False
        '
        'btnAnular
        '
        Me.btnAnular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(64, 22)
        Me.btnAnular.Text = "&Anular"
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
        'btnact_coti
        '
        Me.btnact_coti.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnact_coti.Image = CType(resources.GetObject("btnact_coti.Image"), System.Drawing.Image)
        Me.btnact_coti.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnact_coti.Name = "btnact_coti"
        Me.btnact_coti.Size = New System.Drawing.Size(121, 22)
        Me.btnact_coti.Text = "&Actualizar  Cotiz."
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
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'FrmSolicitudCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 410)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_registro_coti)
        Me.Controls.Add(Me.tc_tipos)
        Me.Controls.Add(Me.dgvDocumentosFactura)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.lblCantidad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSolicitudCotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Cotización"
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltros.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnl_prov.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvListaRequisiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_proveedor.ResumeLayout(False)
        Me.pnl_proveedor.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.dgv_lista_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_registro_coti.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvdet_cotizacion_reg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDocumentosFactura As System.Windows.Forms.DataGridView
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents txtrazon_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelaritem As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtunidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones_articulo As System.Windows.Forms.TextBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad_articulo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar_requisicion As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvListaRequisiciones As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptarListaRequi As System.Windows.Forms.Button
    Friend WithEvents btnCancelarListaRequi As System.Windows.Forms.Button
    Friend WithEvents tc_registro_coti As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents dgvdet_cotizacion_reg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents btnmodificar_reg As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones_reg As System.Windows.Forms.TextBox
    Friend WithEvents txtproveedor_reg As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_proveedor_Reg As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtfecha_reg As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnumero_reg As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtfecha_cotizacion_reg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbmoneda_cotizacion_reg As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtfp_des_cotizacion_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar_reg As System.Windows.Forms.Button
    Friend WithEvents btncancelar_Reg As System.Windows.Forms.Button
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdes_pro_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtcod_prod_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad_reg As System.Windows.Forms.TextBox
    Friend WithEvents txtuni_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents dtfec_entrega_reg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtmarca_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtcalidad_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtgarantia_reg As System.Windows.Forms.TextBox
    Friend WithEvents chkigvinc_reg As System.Windows.Forms.CheckBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtdescpor_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtigvpor_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtprecio_reg As System.Windows.Forms.TextBox
    Friend WithEvents txtfp_cotizacion_reg As System.Windows.Forms.TextBox
    Friend WithEvents txtvo_cotizacion_reg As System.Windows.Forms.TextBox
    Friend WithEvents txtte_cotizacion_reg As System.Windows.Forms.TextBox
    Friend WithEvents txtnum_cotizacion_reg As System.Windows.Forms.TextBox
    Friend WithEvents btn_agregar_proveedor As System.Windows.Forms.Button
    Friend WithEvents tp_proveedor As System.Windows.Forms.TabPage
    Friend WithEvents pnl_proveedor As System.Windows.Forms.Panel
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_menos As System.Windows.Forms.Button
    Friend WithEvents btn_mas As System.Windows.Forms.Button
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dgv_lista_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents pnl_prov As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnact_coti As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtobservacionesgenerales As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_proveedor As System.Windows.Forms.DataGridView
End Class
