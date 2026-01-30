<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheques
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCheques))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_anular = New System.Windows.Forms.ToolStripButton()
        Me.btn_ImprimirPlanilla = New System.Windows.Forms.ToolStripButton()
        Me.btn_ImprimirLetra = New System.Windows.Forms.ToolStripButton()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnsalir = New System.Windows.Forms.ToolStripButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtnombreReprAval = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txttelefonoAval = New System.Windows.Forms.TextBox()
        Me.dgvPlanilla = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtdireccAval = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtnrodocAval = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtnumletra = New System.Windows.Forms.TextBox()
        Me.cboCuenta = New System.Windows.Forms.ComboBox()
        Me.txtdescripcionBanco = New System.Windows.Forms.TextBox()
        Me.txtnombreAval = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtoficina = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panelvcto = New System.Windows.Forms.Panel()
        Me.btncancelarvcto = New System.Windows.Forms.Button()
        Me.btnconfirmarvcto = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dtvctonuevo = New System.Windows.Forms.DateTimePicker()
        Me.dtvctoactual = New System.Windows.Forms.DateTimePicker()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtbanco = New System.Windows.Forms.TextBox()
        Me.Pnlcontabilidad = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.dtpfechaaceptacion = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txttotalHaber = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTotalDebe = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvDetalleAsiento = New System.Windows.Forms.DataGridView()
        Me.btn_retornar = New System.Windows.Forms.Button()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.PnlFiltros = New System.Windows.Forms.Panel()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtRucDni = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlLetraAdicionales = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtNroFacturas = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtnombreRepresentante = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalRetME = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtTotalLetraME = New System.Windows.Forms.TextBox()
        Me.txtTotalRetMN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalLetraMN = New System.Windows.Forms.TextBox()
        Me.dgvDetalleLetra = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro_Letra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_emision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idbanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanjeMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanjeME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetencMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetencME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCorrelativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDomingo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_sel = New System.Windows.Forms.Label()
        Me.lbl_tot = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txttotalME = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtImporteME = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttotalMN = New System.Windows.Forms.TextBox()
        Me.txtImporteMN = New System.Windows.Forms.TextBox()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGenerarLetra = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.txtNLetras = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbCabeceraLetra = New System.Windows.Forms.GroupBox()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.PnlDocumentos = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgvLetra = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtcomentario = New System.Windows.Forms.RichTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancelarLetra = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelvcto.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.Pnlcontabilidad.SuspendLayout()
        CType(Me.dgvDetalleAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFiltros.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLetraAdicionales.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalleLetra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbCabeceraLetra.SuspendLayout()
        Me.PnlDocumentos.SuspendLayout()
        CType(Me.dgvLetra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(172, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(62, 13)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(239, 15)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(93, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(75, 13)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(93, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label29)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label30)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(462, 4)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(340, 45)
        Me.gbRangofechas.TabIndex = 147
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(7, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(66, 13)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Fecha inicial"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(156, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(287, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(174, 45)
        Me.GroupBox8.TabIndex = 146
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Opciones  de Busquedas:"
        '
        'txtruc
        '
        Me.txtruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtruc.Enabled = False
        Me.txtruc.Location = New System.Drawing.Point(93, 14)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(138, 20)
        Me.txtruc.TabIndex = 100
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(8, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "&Ruc / Dni"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.BtnGuardar, Me.btnEliminar, Me.btn_anular, Me.btn_ImprimirPlanilla, Me.btn_ImprimirLetra, Me.btnAceptar, Me.ToolStripButton2, Me.BtnCancelar, Me.ToolStripButton1, Me.btnsalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1133, 25)
        Me.ToolStrip1.TabIndex = 180
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Navy
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 22)
        Me.btnNuevo.Text = "&Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Navy
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(65, 22)
        Me.BtnGuardar.Text = "&Grabar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(71, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'btn_anular
        '
        Me.btn_anular.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_anular.ForeColor = System.Drawing.Color.Navy
        Me.btn_anular.Image = CType(resources.GetObject("btn_anular.Image"), System.Drawing.Image)
        Me.btn_anular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(63, 22)
        Me.btn_anular.Text = "&Anular"
        '
        'btn_ImprimirPlanilla
        '
        Me.btn_ImprimirPlanilla.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ImprimirPlanilla.ForeColor = System.Drawing.Color.Navy
        Me.btn_ImprimirPlanilla.Image = CType(resources.GetObject("btn_ImprimirPlanilla.Image"), System.Drawing.Image)
        Me.btn_ImprimirPlanilla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ImprimirPlanilla.Name = "btn_ImprimirPlanilla"
        Me.btn_ImprimirPlanilla.Size = New System.Drawing.Size(117, 22)
        Me.btn_ImprimirPlanilla.Text = "Imprimir &Planilla"
        Me.btn_ImprimirPlanilla.Visible = False
        '
        'btn_ImprimirLetra
        '
        Me.btn_ImprimirLetra.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ImprimirLetra.ForeColor = System.Drawing.Color.Navy
        Me.btn_ImprimirLetra.Image = CType(resources.GetObject("btn_ImprimirLetra.Image"), System.Drawing.Image)
        Me.btn_ImprimirLetra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ImprimirLetra.Name = "btn_ImprimirLetra"
        Me.btn_ImprimirLetra.Size = New System.Drawing.Size(121, 22)
        Me.btn_ImprimirLetra.Text = "&Imprimir Cheque"
        Me.btn_ImprimirLetra.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAceptar.ForeColor = System.Drawing.Color.Navy
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(103, 22)
        Me.btnAceptar.Text = "&Aceptar Letra"
        Me.btnAceptar.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripButton2.Text = "Cambiar F. Vcto."
        Me.ToolStripButton2.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Navy
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(74, 22)
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripButton1.Text = "Cam&biar Estado"
        Me.ToolStripButton1.Visible = False
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.Navy
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(51, 22)
        Me.btnsalir.Text = "&Salir"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(6, 134)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 13)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Representante"
        '
        'txtnombreReprAval
        '
        Me.txtnombreReprAval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombreReprAval.Location = New System.Drawing.Point(94, 118)
        Me.txtnombreReprAval.Name = "txtnombreReprAval"
        Me.txtnombreReprAval.Size = New System.Drawing.Size(252, 20)
        Me.txtnombreReprAval.TabIndex = 105
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(6, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "&Nombre del"
        '
        'txttelefonoAval
        '
        Me.txttelefonoAval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelefonoAval.Location = New System.Drawing.Point(94, 92)
        Me.txttelefonoAval.Name = "txttelefonoAval"
        Me.txttelefonoAval.Size = New System.Drawing.Size(138, 20)
        Me.txttelefonoAval.TabIndex = 104
        '
        'dgvPlanilla
        '
        Me.dgvPlanilla.AllowUserToAddRows = False
        Me.dgvPlanilla.AllowUserToDeleteRows = False
        Me.dgvPlanilla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanilla.Location = New System.Drawing.Point(7, 15)
        Me.dgvPlanilla.Name = "dgvPlanilla"
        Me.dgvPlanilla.ReadOnly = True
        Me.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlanilla.Size = New System.Drawing.Size(1106, 254)
        Me.dgvPlanilla.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(8, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "&Telefono"
        '
        'txtdireccAval
        '
        Me.txtdireccAval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdireccAval.Location = New System.Drawing.Point(94, 67)
        Me.txtdireccAval.Name = "txtdireccAval"
        Me.txtdireccAval.Size = New System.Drawing.Size(252, 20)
        Me.txtdireccAval.TabIndex = 103
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(8, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "&Direccion"
        '
        'txtnrodocAval
        '
        Me.txtnrodocAval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnrodocAval.Location = New System.Drawing.Point(94, 41)
        Me.txtnrodocAval.Name = "txtnrodocAval"
        Me.txtnrodocAval.Size = New System.Drawing.Size(138, 20)
        Me.txtnrodocAval.TabIndex = 102
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(7, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "&Nro Documento"
        '
        'txtnumletra
        '
        Me.txtnumletra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumletra.Enabled = False
        Me.txtnumletra.Location = New System.Drawing.Point(93, 14)
        Me.txtnumletra.Name = "txtnumletra"
        Me.txtnumletra.ReadOnly = True
        Me.txtnumletra.Size = New System.Drawing.Size(109, 20)
        Me.txtnumletra.TabIndex = 100
        '
        'cboCuenta
        '
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(95, 66)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(250, 21)
        Me.cboCuenta.TabIndex = 110
        '
        'txtdescripcionBanco
        '
        Me.txtdescripcionBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionBanco.Location = New System.Drawing.Point(153, 14)
        Me.txtdescripcionBanco.Name = "txtdescripcionBanco"
        Me.txtdescripcionBanco.ReadOnly = True
        Me.txtdescripcionBanco.Size = New System.Drawing.Size(192, 20)
        Me.txtdescripcionBanco.TabIndex = 109
        '
        'txtnombreAval
        '
        Me.txtnombreAval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombreAval.Location = New System.Drawing.Point(94, 14)
        Me.txtnombreAval.Name = "txtnombreAval"
        Me.txtnombreAval.Size = New System.Drawing.Size(252, 20)
        Me.txtnombreAval.TabIndex = 101
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(8, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "&Nombre"
        '
        'txtoficina
        '
        Me.txtoficina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtoficina.Location = New System.Drawing.Point(93, 40)
        Me.txtoficina.Name = "txtoficina"
        Me.txtoficina.Size = New System.Drawing.Size(252, 20)
        Me.txtoficina.TabIndex = 107
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(8, 43)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "&Oficina"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(8, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "&Banco"
        '
        'Panelvcto
        '
        Me.Panelvcto.BackColor = System.Drawing.Color.White
        Me.Panelvcto.Controls.Add(Me.btncancelarvcto)
        Me.Panelvcto.Controls.Add(Me.btnconfirmarvcto)
        Me.Panelvcto.Controls.Add(Me.TextBox2)
        Me.Panelvcto.Controls.Add(Me.GroupBox9)
        Me.Panelvcto.Controls.Add(Me.GroupBox11)
        Me.Panelvcto.Location = New System.Drawing.Point(1174, 99)
        Me.Panelvcto.Name = "Panelvcto"
        Me.Panelvcto.Size = New System.Drawing.Size(264, 247)
        Me.Panelvcto.TabIndex = 181
        Me.Panelvcto.Visible = False
        '
        'btncancelarvcto
        '
        Me.btncancelarvcto.ForeColor = System.Drawing.Color.Navy
        Me.btncancelarvcto.Image = CType(resources.GetObject("btncancelarvcto.Image"), System.Drawing.Image)
        Me.btncancelarvcto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelarvcto.Location = New System.Drawing.Point(132, 193)
        Me.btncancelarvcto.Name = "btncancelarvcto"
        Me.btncancelarvcto.Size = New System.Drawing.Size(59, 37)
        Me.btncancelarvcto.TabIndex = 170
        Me.btncancelarvcto.Text = "Cancelar"
        Me.btncancelarvcto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelarvcto.UseVisualStyleBackColor = True
        '
        'btnconfirmarvcto
        '
        Me.btnconfirmarvcto.ForeColor = System.Drawing.Color.Navy
        Me.btnconfirmarvcto.Image = CType(resources.GetObject("btnconfirmarvcto.Image"), System.Drawing.Image)
        Me.btnconfirmarvcto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnconfirmarvcto.Location = New System.Drawing.Point(71, 193)
        Me.btnconfirmarvcto.Name = "btnconfirmarvcto"
        Me.btnconfirmarvcto.Size = New System.Drawing.Size(59, 37)
        Me.btnconfirmarvcto.TabIndex = 111
        Me.btnconfirmarvcto.Text = "Confirmar"
        Me.btnconfirmarvcto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnconfirmarvcto.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(2, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(261, 16)
        Me.TextBox2.TabIndex = 169
        Me.TextBox2.Text = "ACTUALIZACION DE F. VCTO."
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dtvctonuevo)
        Me.GroupBox9.Controls.Add(Me.dtvctoactual)
        Me.GroupBox9.Controls.Add(Me.Label42)
        Me.GroupBox9.Controls.Add(Me.Label43)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(11, 109)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 73)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Datos"
        '
        'dtvctonuevo
        '
        Me.dtvctonuevo.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtvctonuevo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvctonuevo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtvctonuevo.Location = New System.Drawing.Point(93, 38)
        Me.dtvctonuevo.Name = "dtvctonuevo"
        Me.dtvctonuevo.Size = New System.Drawing.Size(109, 24)
        Me.dtvctonuevo.TabIndex = 5
        Me.dtvctonuevo.Tag = ""
        '
        'dtvctoactual
        '
        Me.dtvctoactual.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtvctoactual.Enabled = False
        Me.dtvctoactual.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvctoactual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtvctoactual.Location = New System.Drawing.Point(93, 9)
        Me.dtvctoactual.Name = "dtvctoactual"
        Me.dtvctoactual.Size = New System.Drawing.Size(109, 24)
        Me.dtvctoactual.TabIndex = 4
        Me.dtvctoactual.Tag = ""
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(8, 46)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(79, 13)
        Me.Label42.TabIndex = 3
        Me.Label42.Text = "F. Vcto. Nueva"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(8, 17)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(77, 13)
        Me.Label43.TabIndex = 1
        Me.Label43.Text = "F. Vcto. Actual"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtnumletra)
        Me.GroupBox11.Controls.Add(Me.Label50)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox11.Location = New System.Drawing.Point(11, 61)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(240, 42)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Documento"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.Navy
        Me.Label50.Location = New System.Drawing.Point(8, 17)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(31, 13)
        Me.Label50.TabIndex = 1
        Me.Label50.Text = "Letra"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(8, 69)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 13)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "&Cuenta"
        '
        'txtbanco
        '
        Me.txtbanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbanco.Location = New System.Drawing.Point(93, 14)
        Me.txtbanco.Name = "txtbanco"
        Me.txtbanco.ReadOnly = True
        Me.txtbanco.Size = New System.Drawing.Size(38, 20)
        Me.txtbanco.TabIndex = 106
        '
        'Pnlcontabilidad
        '
        Me.Pnlcontabilidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnlcontabilidad.BackColor = System.Drawing.Color.White
        Me.Pnlcontabilidad.Controls.Add(Me.Label36)
        Me.Pnlcontabilidad.Controls.Add(Me.dtpfechaaceptacion)
        Me.Pnlcontabilidad.Controls.Add(Me.Label34)
        Me.Pnlcontabilidad.Controls.Add(Me.txttotalHaber)
        Me.Pnlcontabilidad.Controls.Add(Me.Label33)
        Me.Pnlcontabilidad.Controls.Add(Me.txtTotalDebe)
        Me.Pnlcontabilidad.Controls.Add(Me.TextBox1)
        Me.Pnlcontabilidad.Controls.Add(Me.dgvDetalleAsiento)
        Me.Pnlcontabilidad.Controls.Add(Me.btn_retornar)
        Me.Pnlcontabilidad.Controls.Add(Me.btn_generar)
        Me.Pnlcontabilidad.Location = New System.Drawing.Point(1163, 34)
        Me.Pnlcontabilidad.Name = "Pnlcontabilidad"
        Me.Pnlcontabilidad.Size = New System.Drawing.Size(69, 587)
        Me.Pnlcontabilidad.TabIndex = 175
        Me.Pnlcontabilidad.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(17, 531)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(109, 13)
        Me.Label36.TabIndex = 176
        Me.Label36.Text = "Fecha de Aceptación"
        '
        'dtpfechaaceptacion
        '
        Me.dtpfechaaceptacion.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaaceptacion.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaaceptacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaaceptacion.Location = New System.Drawing.Point(132, 526)
        Me.dtpfechaaceptacion.Name = "dtpfechaaceptacion"
        Me.dtpfechaaceptacion.Size = New System.Drawing.Size(96, 24)
        Me.dtpfechaaceptacion.TabIndex = 1
        Me.dtpfechaaceptacion.Tag = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(643, 540)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 13)
        Me.Label34.TabIndex = 174
        Me.Label34.Text = "Total Haber"
        '
        'txttotalHaber
        '
        Me.txttotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalHaber.Location = New System.Drawing.Point(708, 537)
        Me.txttotalHaber.Name = "txttotalHaber"
        Me.txttotalHaber.ReadOnly = True
        Me.txttotalHaber.Size = New System.Drawing.Size(70, 20)
        Me.txttotalHaber.TabIndex = 173
        Me.txttotalHaber.Text = "0.00"
        Me.txttotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(507, 540)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(60, 13)
        Me.Label33.TabIndex = 172
        Me.Label33.Text = "Total Debe"
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDebe.Location = New System.Drawing.Point(570, 537)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalDebe.TabIndex = 171
        Me.txtTotalDebe.Text = "0.00"
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(16, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(768, 16)
        Me.TextBox1.TabIndex = 170
        Me.TextBox1.Text = "GENERACION DEL ASIENTO CONTABLE DE LA LETRA"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvDetalleAsiento
        '
        Me.dgvDetalleAsiento.AllowUserToAddRows = False
        Me.dgvDetalleAsiento.AllowUserToDeleteRows = False
        Me.dgvDetalleAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleAsiento.Location = New System.Drawing.Point(15, 55)
        Me.dgvDetalleAsiento.Name = "dgvDetalleAsiento"
        Me.dgvDetalleAsiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleAsiento.Size = New System.Drawing.Size(768, 460)
        Me.dgvDetalleAsiento.TabIndex = 0
        '
        'btn_retornar
        '
        Me.btn_retornar.ForeColor = System.Drawing.Color.Navy
        Me.btn_retornar.Image = CType(resources.GetObject("btn_retornar.Image"), System.Drawing.Image)
        Me.btn_retornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_retornar.Location = New System.Drawing.Point(407, 523)
        Me.btn_retornar.Name = "btn_retornar"
        Me.btn_retornar.Size = New System.Drawing.Size(59, 37)
        Me.btn_retornar.TabIndex = 152
        Me.btn_retornar.Text = "&Salir"
        Me.btn_retornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_retornar.UseVisualStyleBackColor = True
        '
        'btn_generar
        '
        Me.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_generar.FlatAppearance.BorderSize = 0
        Me.btn_generar.ForeColor = System.Drawing.Color.Navy
        Me.btn_generar.Image = CType(resources.GetObject("btn_generar.Image"), System.Drawing.Image)
        Me.btn_generar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_generar.Location = New System.Drawing.Point(348, 523)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(59, 37)
        Me.btn_generar.TabIndex = 150
        Me.btn_generar.Text = "&Aceptar"
        Me.btn_generar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'PnlFiltros
        '
        Me.PnlFiltros.Controls.Add(Me.gbFiltros)
        Me.PnlFiltros.Controls.Add(Me.GroupBox8)
        Me.PnlFiltros.Controls.Add(Me.gbRangofechas)
        Me.PnlFiltros.Location = New System.Drawing.Point(5, 31)
        Me.PnlFiltros.Name = "PnlFiltros"
        Me.PnlFiltros.Size = New System.Drawing.Size(1121, 52)
        Me.PnlFiltros.TabIndex = 179
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(6, 3)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(281, 47)
        Me.gbFiltros.TabIndex = 142
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(6, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(273, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.cmbtipo)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.txtRucDni)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1107, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Datos del Cliente :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(1106, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(95, 13)
        Me.Label37.TabIndex = 127
        Me.Label37.Text = "Tipo de Operación"
        Me.Label37.Visible = False
        '
        'cmbtipo
        '
        Me.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Canje por Letras", "Renovacion de Letras"})
        Me.cmbtipo.Location = New System.Drawing.Point(1150, 13)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(220, 25)
        Me.cmbtipo.TabIndex = 126
        Me.cmbtipo.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(167, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.White
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Location = New System.Drawing.Point(475, 16)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(619, 20)
        Me.txtRazonSocial.TabIndex = 119
        '
        'txtRucDni
        '
        Me.txtRucDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRucDni.Location = New System.Drawing.Point(250, 16)
        Me.txtRucDni.Name = "txtRucDni"
        Me.txtRucDni.Size = New System.Drawing.Size(98, 20)
        Me.txtRucDni.TabIndex = 118
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Location = New System.Drawing.Point(63, 16)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(98, 20)
        Me.txtCodCliente.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(358, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Razón social / Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Ruc/ Dni"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Cliente"
        '
        'pnlLetraAdicionales
        '
        Me.pnlLetraAdicionales.BackColor = System.Drawing.Color.White
        Me.pnlLetraAdicionales.Controls.Add(Me.btn_exit)
        Me.pnlLetraAdicionales.Controls.Add(Me.btn_ok)
        Me.pnlLetraAdicionales.Controls.Add(Me.TextBox12)
        Me.pnlLetraAdicionales.Controls.Add(Me.Label28)
        Me.pnlLetraAdicionales.Controls.Add(Me.txtNroFacturas)
        Me.pnlLetraAdicionales.Controls.Add(Me.Label27)
        Me.pnlLetraAdicionales.Controls.Add(Me.txtnombreRepresentante)
        Me.pnlLetraAdicionales.Controls.Add(Me.Label26)
        Me.pnlLetraAdicionales.Controls.Add(Me.GroupBox7)
        Me.pnlLetraAdicionales.Controls.Add(Me.GroupBox6)
        Me.pnlLetraAdicionales.Controls.Add(Me.GroupBox5)
        Me.pnlLetraAdicionales.Location = New System.Drawing.Point(1142, 93)
        Me.pnlLetraAdicionales.Name = "pnlLetraAdicionales"
        Me.pnlLetraAdicionales.Size = New System.Drawing.Size(408, 462)
        Me.pnlLetraAdicionales.TabIndex = 176
        Me.pnlLetraAdicionales.Visible = False
        '
        'btn_exit
        '
        Me.btn_exit.ForeColor = System.Drawing.Color.Navy
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_exit.Location = New System.Drawing.Point(200, 424)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(59, 37)
        Me.btn_exit.TabIndex = 170
        Me.btn_exit.Text = "Cancelar"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.ForeColor = System.Drawing.Color.Navy
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.Location = New System.Drawing.Point(139, 424)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(59, 37)
        Me.btn_ok.TabIndex = 111
        Me.btn_ok.Text = "Confirmar"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.Black
        Me.TextBox12.Location = New System.Drawing.Point(2, 21)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(391, 16)
        Me.TextBox12.TabIndex = 169
        Me.TextBox12.Text = "DATOS ADICIONALES"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(62, 379)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Empresa"
        '
        'txtNroFacturas
        '
        Me.txtNroFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroFacturas.Location = New System.Drawing.Point(115, 398)
        Me.txtNroFacturas.Name = "txtNroFacturas"
        Me.txtNroFacturas.Size = New System.Drawing.Size(252, 20)
        Me.txtNroFacturas.TabIndex = 110
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(30, 401)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(66, 13)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "&Nro Factura:"
        '
        'txtnombreRepresentante
        '
        Me.txtnombreRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombreRepresentante.Location = New System.Drawing.Point(149, 369)
        Me.txtnombreRepresentante.Name = "txtnombreRepresentante"
        Me.txtnombreRepresentante.Size = New System.Drawing.Size(218, 20)
        Me.txtnombreRepresentante.TabIndex = 109
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(28, 364)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 13)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "&Nombre  Representante"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.PictureBox1)
        Me.GroupBox7.Controls.Add(Me.cboCuenta)
        Me.GroupBox7.Controls.Add(Me.txtdescripcionBanco)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.txtoficina)
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Controls.Add(Me.txtbanco)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(22, 266)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(362, 94)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "&Cuenta del Banco"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 171
        Me.PictureBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.txtnombreReprAval)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txttelefonoAval)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.txtdireccAval)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.txtnrodocAval)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txtnombreAval)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(21, 106)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(363, 157)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "&Aval"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtruc)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(22, 61)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(362, 42)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "&Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtTotalRetME)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.txtTotalLetraME)
        Me.GroupBox3.Controls.Add(Me.txtTotalRetMN)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtTotalLetraMN)
        Me.GroupBox3.Controls.Add(Me.dgvDetalleLetra)
        Me.GroupBox3.Controls.Add(Me.lblDomingo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(5, 397)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1121, 211)
        Me.GroupBox3.TabIndex = 173
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Detalle del Cheque"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(399, 187)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(70, 13)
        Me.Label31.TabIndex = 154
        Me.Label31.Text = "Total Ret ME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(756, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "Total Cheque ME"
        '
        'txtTotalRetME
        '
        Me.txtTotalRetME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalRetME.Location = New System.Drawing.Point(483, 185)
        Me.txtTotalRetME.Name = "txtTotalRetME"
        Me.txtTotalRetME.ReadOnly = True
        Me.txtTotalRetME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalRetME.Size = New System.Drawing.Size(76, 20)
        Me.txtTotalRetME.TabIndex = 153
        Me.txtTotalRetME.Text = "0.00"
        Me.txtTotalRetME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(243, 187)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(71, 13)
        Me.Label32.TabIndex = 152
        Me.Label32.Text = "Total Ret MN"
        '
        'txtTotalLetraME
        '
        Me.txtTotalLetraME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalLetraME.Location = New System.Drawing.Point(852, 185)
        Me.txtTotalLetraME.Name = "txtTotalLetraME"
        Me.txtTotalLetraME.ReadOnly = True
        Me.txtTotalLetraME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalLetraME.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalLetraME.TabIndex = 134
        Me.txtTotalLetraME.Text = "0.00"
        Me.txtTotalLetraME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalRetMN
        '
        Me.txtTotalRetMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalRetMN.Location = New System.Drawing.Point(320, 185)
        Me.txtTotalRetMN.Name = "txtTotalRetMN"
        Me.txtTotalRetMN.ReadOnly = True
        Me.txtTotalRetMN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalRetMN.Size = New System.Drawing.Size(73, 20)
        Me.txtTotalRetMN.TabIndex = 151
        Me.txtTotalRetMN.Text = "0.00"
        Me.txtTotalRetMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(565, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "Total Cheque MN"
        '
        'txtTotalLetraMN
        '
        Me.txtTotalLetraMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalLetraMN.Location = New System.Drawing.Point(662, 185)
        Me.txtTotalLetraMN.Name = "txtTotalLetraMN"
        Me.txtTotalLetraMN.ReadOnly = True
        Me.txtTotalLetraMN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalLetraMN.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalLetraMN.TabIndex = 132
        Me.txtTotalLetraMN.Text = "0.00"
        Me.txtTotalLetraMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalleLetra
        '
        Me.dgvDetalleLetra.AllowUserToAddRows = False
        Me.dgvDetalleLetra.AllowUserToDeleteRows = False
        Me.dgvDetalleLetra.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleLetra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalleLetra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleLetra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Nro_Letra, Me.fecha_emision, Me.Vencimiento, Me.idbanco, Me.banco, Me.Plazo, Me.CanjeMN, Me.CanjeME, Me.RetencMN, Me.RetencME, Me.LetraMN, Me.LetraME, Me.NroCorrelativo, Me.FechaVencimiento})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalleLetra.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetalleLetra.Location = New System.Drawing.Point(7, 19)
        Me.dgvDetalleLetra.Name = "dgvDetalleLetra"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleLetra.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalleLetra.RowHeadersWidth = 24
        Me.dgvDetalleLetra.Size = New System.Drawing.Size(1106, 159)
        Me.dgvDetalleLetra.TabIndex = 9
        '
        'Item
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Item.DefaultCellStyle = DataGridViewCellStyle2
        Me.Item.HeaderText = "#"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 30
        '
        'Nro_Letra
        '
        Me.Nro_Letra.FillWeight = 61.22011!
        Me.Nro_Letra.HeaderText = "Nro Cheque"
        Me.Nro_Letra.MaxInputLength = 10
        Me.Nro_Letra.Name = "Nro_Letra"
        Me.Nro_Letra.Width = 80
        '
        'fecha_emision
        '
        Me.fecha_emision.FillWeight = 61.22011!
        Me.fecha_emision.HeaderText = "F. Emision"
        Me.fecha_emision.Name = "fecha_emision"
        Me.fecha_emision.ReadOnly = True
        Me.fecha_emision.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fecha_emision.Width = 120
        '
        'Vencimiento
        '
        Me.Vencimiento.FillWeight = 61.22011!
        Me.Vencimiento.HeaderText = "F. de Cobro"
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.ReadOnly = True
        Me.Vencimiento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Vencimiento.Width = 120
        '
        'idbanco
        '
        Me.idbanco.HeaderText = "Cod. Banco"
        Me.idbanco.Name = "idbanco"
        '
        'banco
        '
        Me.banco.HeaderText = "Banco"
        Me.banco.Name = "banco"
        '
        'Plazo
        '
        Me.Plazo.FillWeight = 149.7006!
        Me.Plazo.HeaderText = "Plazo"
        Me.Plazo.Name = "Plazo"
        Me.Plazo.Visible = False
        Me.Plazo.Width = 50
        '
        'CanjeMN
        '
        Me.CanjeMN.FillWeight = 104.6497!
        Me.CanjeMN.HeaderText = "Canje MN"
        Me.CanjeMN.Name = "CanjeMN"
        Me.CanjeMN.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CanjeMN.Width = 80
        '
        'CanjeME
        '
        Me.CanjeME.FillWeight = 123.2094!
        Me.CanjeME.HeaderText = "Canje ME"
        Me.CanjeME.Name = "CanjeME"
        Me.CanjeME.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CanjeME.Width = 80
        '
        'RetencMN
        '
        Me.RetencMN.HeaderText = "Retenc. MN"
        Me.RetencMN.Name = "RetencMN"
        Me.RetencMN.ReadOnly = True
        Me.RetencMN.Width = 60
        '
        'RetencME
        '
        Me.RetencME.HeaderText = "Retenc. ME"
        Me.RetencME.Name = "RetencME"
        Me.RetencME.ReadOnly = True
        Me.RetencME.Width = 60
        '
        'LetraMN
        '
        Me.LetraMN.HeaderText = "Cheque MN"
        Me.LetraMN.Name = "LetraMN"
        Me.LetraMN.ReadOnly = True
        '
        'LetraME
        '
        Me.LetraME.HeaderText = "Cheque ME"
        Me.LetraME.Name = "LetraME"
        Me.LetraME.ReadOnly = True
        '
        'NroCorrelativo
        '
        Me.NroCorrelativo.HeaderText = "NroCorrelativo"
        Me.NroCorrelativo.Name = "NroCorrelativo"
        Me.NroCorrelativo.Visible = False
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.HeaderText = "FechaVencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Visible = False
        '
        'lblDomingo
        '
        Me.lblDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDomingo.AutoSize = True
        Me.lblDomingo.ForeColor = System.Drawing.Color.Red
        Me.lblDomingo.Location = New System.Drawing.Point(121, 184)
        Me.lblDomingo.Name = "lblDomingo"
        Me.lblDomingo.Size = New System.Drawing.Size(13, 13)
        Me.lblDomingo.TabIndex = 5
        Me.lblDomingo.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(25, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Día(s) no hábiles:"
        '
        'lbl_sel
        '
        Me.lbl_sel.ForeColor = System.Drawing.Color.Navy
        Me.lbl_sel.Location = New System.Drawing.Point(18, 201)
        Me.lbl_sel.Name = "lbl_sel"
        Me.lbl_sel.Size = New System.Drawing.Size(175, 15)
        Me.lbl_sel.TabIndex = 133
        Me.lbl_sel.Text = "..."
        '
        'lbl_tot
        '
        Me.lbl_tot.ForeColor = System.Drawing.Color.Navy
        Me.lbl_tot.Location = New System.Drawing.Point(18, 182)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(175, 15)
        Me.lbl_tot.TabIndex = 132
        Me.lbl_tot.Text = "..."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(924, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "Total Canje ME"
        '
        'txttotalME
        '
        Me.txttotalME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalME.Location = New System.Drawing.Point(1009, 198)
        Me.txttotalME.Name = "txttotalME"
        Me.txttotalME.ReadOnly = True
        Me.txttotalME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttotalME.Size = New System.Drawing.Size(85, 20)
        Me.txttotalME.TabIndex = 130
        Me.txttotalME.Text = "0.00"
        Me.txttotalME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(917, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Importa Canje ME"
        '
        'txtImporteME
        '
        Me.txtImporteME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporteME.Location = New System.Drawing.Point(1009, 177)
        Me.txtImporteME.Name = "txtImporteME"
        Me.txtImporteME.ReadOnly = True
        Me.txtImporteME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteME.Size = New System.Drawing.Size(85, 20)
        Me.txtImporteME.TabIndex = 128
        Me.txtImporteME.Text = "0.00"
        Me.txtImporteME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(743, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "Total Canje MN"
        '
        'txttotalMN
        '
        Me.txttotalMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalMN.Location = New System.Drawing.Point(826, 199)
        Me.txttotalMN.Name = "txttotalMN"
        Me.txttotalMN.ReadOnly = True
        Me.txttotalMN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttotalMN.Size = New System.Drawing.Size(88, 20)
        Me.txttotalMN.TabIndex = 126
        Me.txttotalMN.Text = "0.00"
        Me.txttotalMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporteMN
        '
        Me.txtImporteMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporteMN.Location = New System.Drawing.Point(826, 178)
        Me.txtImporteMN.Name = "txtImporteMN"
        Me.txtImporteMN.ReadOnly = True
        Me.txtImporteMN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteMN.Size = New System.Drawing.Size(88, 20)
        Me.txtImporteMN.TabIndex = 119
        Me.txtImporteMN.Text = "0.00"
        Me.txtImporteMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        Me.dgvDocumentos.AllowUserToDeleteRows = False
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(12, 19)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(1082, 152)
        Me.dgvDocumentos.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_sel)
        Me.GroupBox2.Controls.Add(Me.lbl_tot)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txttotalME)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtImporteME)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txttotalMN)
        Me.GroupBox2.Controls.Add(Me.BtnGenerarLetra)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtImporteMN)
        Me.GroupBox2.Controls.Add(Me.dgvDocumentos)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1107, 229)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Datos de Documentos:"
        '
        'BtnGenerarLetra
        '
        Me.BtnGenerarLetra.Image = CType(resources.GetObject("BtnGenerarLetra.Image"), System.Drawing.Image)
        Me.BtnGenerarLetra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGenerarLetra.Location = New System.Drawing.Point(574, 177)
        Me.BtnGenerarLetra.Name = "BtnGenerarLetra"
        Me.BtnGenerarLetra.Size = New System.Drawing.Size(119, 31)
        Me.BtnGenerarLetra.TabIndex = 125
        Me.BtnGenerarLetra.Text = "&Generar Cheque"
        Me.BtnGenerarLetra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGenerarLetra.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(733, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Importa Canje MN"
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(580, 16)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(214, 21)
        Me.cmb_moneda.TabIndex = 8
        '
        'btnMas
        '
        Me.btnMas.Location = New System.Drawing.Point(416, 15)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(27, 23)
        Me.btnMas.TabIndex = 2
        Me.btnMas.Text = "+"
        Me.btnMas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'txtNLetras
        '
        Me.txtNLetras.Location = New System.Drawing.Point(375, 17)
        Me.txtNLetras.MaxLength = 2
        Me.txtNLetras.Name = "txtNLetras"
        Me.txtNLetras.ReadOnly = True
        Me.txtNLetras.Size = New System.Drawing.Size(40, 20)
        Me.txtNLetras.TabIndex = 1
        Me.txtNLetras.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(279, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nro. de Cheques:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(528, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Moneda"
        '
        'gbCabeceraLetra
        '
        Me.gbCabeceraLetra.Controls.Add(Me.GroupBox2)
        Me.gbCabeceraLetra.Controls.Add(Me.GroupBox1)
        Me.gbCabeceraLetra.Location = New System.Drawing.Point(5, 26)
        Me.gbCabeceraLetra.Name = "gbCabeceraLetra"
        Me.gbCabeceraLetra.Size = New System.Drawing.Size(1121, 296)
        Me.gbCabeceraLetra.TabIndex = 177
        Me.gbCabeceraLetra.TabStop = False
        '
        'btnMenos
        '
        Me.btnMenos.Location = New System.Drawing.Point(442, 15)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(27, 23)
        Me.btnMenos.TabIndex = 3
        Me.btnMenos.Text = "-"
        Me.btnMenos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'PnlDocumentos
        '
        Me.PnlDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlDocumentos.Controls.Add(Me.Label9)
        Me.PnlDocumentos.Controls.Add(Me.lblCantidad)
        Me.PnlDocumentos.Controls.Add(Me.dgvLetra)
        Me.PnlDocumentos.Controls.Add(Me.dgvPlanilla)
        Me.PnlDocumentos.Location = New System.Drawing.Point(5, 86)
        Me.PnlDocumentos.Name = "PnlDocumentos"
        Me.PnlDocumentos.Size = New System.Drawing.Size(1121, 535)
        Me.PnlDocumentos.TabIndex = 178
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(9, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 13)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "&Detalle de la Panilla. ( Cheques )"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(10, 515)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 119
        Me.lblCantidad.Text = "."
        '
        'dgvLetra
        '
        Me.dgvLetra.AllowUserToAddRows = False
        Me.dgvLetra.AllowUserToDeleteRows = False
        Me.dgvLetra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLetra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLetra.Location = New System.Drawing.Point(7, 294)
        Me.dgvLetra.Name = "dgvLetra"
        Me.dgvLetra.ReadOnly = True
        Me.dgvLetra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLetra.Size = New System.Drawing.Size(1107, 219)
        Me.dgvLetra.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtcomentario)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.BtnCancelarLetra)
        Me.GroupBox4.Controls.Add(Me.dtpFecha)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cmb_moneda)
        Me.GroupBox4.Controls.Add(Me.btnMenos)
        Me.GroupBox4.Controls.Add(Me.btnMas)
        Me.GroupBox4.Controls.Add(Me.txtNLetras)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(5, 323)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1121, 68)
        Me.GroupBox4.TabIndex = 174
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de Canje de Cheques"
        '
        'txtcomentario
        '
        Me.txtcomentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomentario.Location = New System.Drawing.Point(7, 41)
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(790, 21)
        Me.txtcomentario.TabIndex = 139
        Me.txtcomentario.Text = ""
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(328, 43)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(70, 13)
        Me.Label35.TabIndex = 138
        Me.Label35.Text = "Observacion:"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCambio.Location = New System.Drawing.Point(1034, 15)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(66, 20)
        Me.txtTipoCambio.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(963, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo Cambio:"
        '
        'BtnCancelarLetra
        '
        Me.BtnCancelarLetra.Image = CType(resources.GetObject("BtnCancelarLetra.Image"), System.Drawing.Image)
        Me.BtnCancelarLetra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarLetra.Location = New System.Drawing.Point(829, 38)
        Me.BtnCancelarLetra.Name = "BtnCancelarLetra"
        Me.BtnCancelarLetra.Size = New System.Drawing.Size(111, 24)
        Me.BtnCancelarLetra.TabIndex = 137
        Me.BtnCancelarLetra.Text = "&Cancelar canje "
        Me.BtnCancelarLetra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelarLetra.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Checked = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(101, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(4, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha de Emision"
        '
        'FrmCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1133, 623)
        Me.Controls.Add(Me.PnlDocumentos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panelvcto)
        Me.Controls.Add(Me.Pnlcontabilidad)
        Me.Controls.Add(Me.PnlFiltros)
        Me.Controls.Add(Me.pnlLetraAdicionales)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbCabeceraLetra)
        Me.Controls.Add(Me.GroupBox4)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCheques"
        Me.Text = "Cheques de Cobranza"
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelvcto.ResumeLayout(False)
        Me.Panelvcto.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.Pnlcontabilidad.ResumeLayout(False)
        Me.Pnlcontabilidad.PerformLayout()
        CType(Me.dgvDetalleAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFiltros.ResumeLayout(False)
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLetraAdicionales.ResumeLayout(False)
        Me.pnlLetraAdicionales.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvDetalleLetra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbCabeceraLetra.ResumeLayout(False)
        Me.PnlDocumentos.ResumeLayout(False)
        Me.PnlDocumentos.PerformLayout()
        CType(Me.dgvLetra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_anular As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_ImprimirPlanilla As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_ImprimirLetra As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnsalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtnombreReprAval As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txttelefonoAval As System.Windows.Forms.TextBox
    Friend WithEvents dgvPlanilla As System.Windows.Forms.DataGridView
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtdireccAval As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtnrodocAval As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtnumletra As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtdescripcionBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreAval As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtoficina As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panelvcto As System.Windows.Forms.Panel
    Friend WithEvents btncancelarvcto As System.Windows.Forms.Button
    Friend WithEvents btnconfirmarvcto As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents dtvctonuevo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtvctoactual As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtbanco As System.Windows.Forms.TextBox
    Friend WithEvents Pnlcontabilidad As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaaceptacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txttotalHaber As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalleAsiento As System.Windows.Forms.DataGridView
    Friend WithEvents btn_retornar As System.Windows.Forms.Button
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents PnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtRucDni As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlLetraAdicionales As System.Windows.Forms.Panel
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtNroFacturas As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtnombreRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRetME As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLetraME As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalRetMN As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLetraMN As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalleLetra As System.Windows.Forms.DataGridView
    Friend WithEvents lblDomingo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_sel As System.Windows.Forms.Label
    Friend WithEvents lbl_tot As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txttotalME As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtImporteME As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txttotalMN As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenerarLetra As System.Windows.Forms.Button
    Friend WithEvents txtImporteMN As System.Windows.Forms.TextBox
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents btnMas As System.Windows.Forms.Button
    Friend WithEvents txtNLetras As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbCabeceraLetra As System.Windows.Forms.GroupBox
    Friend WithEvents btnMenos As System.Windows.Forms.Button
    Friend WithEvents PnlDocumentos As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dgvLetra As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcomentario As System.Windows.Forms.RichTextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelarLetra As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro_Letra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_emision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idbanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Plazo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanjeMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanjeME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetencMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetencME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetraMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetraME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroCorrelativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
