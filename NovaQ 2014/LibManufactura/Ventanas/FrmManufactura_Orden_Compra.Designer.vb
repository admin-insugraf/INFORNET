<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManufactura_Orden_Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManufactura_Orden_Compra))
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtrucfacturar = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtdireccionFacturar = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtnombreFacturar = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtresponsable = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtentrega = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcotizacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttipoCambio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtproveedor_ruc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtproveedor_razons = New System.Windows.Forms.TextBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpemision = New System.Windows.Forms.DateTimePicker()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtvalorVenta = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtBruto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbcabecera.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(19, 88)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.Size = New System.Drawing.Size(1018, 327)
        Me.dgvCabecera.TabIndex = 2
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.lblCantidad)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Location = New System.Drawing.Point(12, 29)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1061, 441)
        Me.pnlCabecera.TabIndex = 177
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(22, 419)
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
        Me.gbRangofechas.Location = New System.Drawing.Point(682, 30)
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
        Me.GroupBox3.Location = New System.Drawing.Point(19, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(465, 45)
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
        Me.txtFiltro.Size = New System.Drawing.Size(452, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(493, 30)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listado de Orden de Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(281, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha de emision"
        '
        'gbcabecera
        '
        Me.gbcabecera.Controls.Add(Me.PictureBox4)
        Me.gbcabecera.Controls.Add(Me.PictureBox3)
        Me.gbcabecera.Controls.Add(Me.PictureBox2)
        Me.gbcabecera.Controls.Add(Me.PictureBox1)
        Me.gbcabecera.Controls.Add(Me.txtrucfacturar)
        Me.gbcabecera.Controls.Add(Me.Label20)
        Me.gbcabecera.Controls.Add(Me.txtdireccionFacturar)
        Me.gbcabecera.Controls.Add(Me.Label19)
        Me.gbcabecera.Controls.Add(Me.txtnombreFacturar)
        Me.gbcabecera.Controls.Add(Me.Label18)
        Me.gbcabecera.Controls.Add(Me.txtresponsable)
        Me.gbcabecera.Controls.Add(Me.Label17)
        Me.gbcabecera.Controls.Add(Me.txtSolicitante)
        Me.gbcabecera.Controls.Add(Me.Label16)
        Me.gbcabecera.Controls.Add(Me.txtentrega)
        Me.gbcabecera.Controls.Add(Me.Label15)
        Me.gbcabecera.Controls.Add(Me.txtcotizacion)
        Me.gbcabecera.Controls.Add(Me.Label14)
        Me.gbcabecera.Controls.Add(Me.txtFormaPago)
        Me.gbcabecera.Controls.Add(Me.Label12)
        Me.gbcabecera.Controls.Add(Me.txttipoCambio)
        Me.gbcabecera.Controls.Add(Me.Label11)
        Me.gbcabecera.Controls.Add(Me.Label10)
        Me.gbcabecera.Controls.Add(Me.cbomoneda)
        Me.gbcabecera.Controls.Add(Me.Label9)
        Me.gbcabecera.Controls.Add(Me.dtpEntrega)
        Me.gbcabecera.Controls.Add(Me.Label8)
        Me.gbcabecera.Controls.Add(Me.txtproveedor_ruc)
        Me.gbcabecera.Controls.Add(Me.Label6)
        Me.gbcabecera.Controls.Add(Me.txtproveedor_razons)
        Me.gbcabecera.Controls.Add(Me.txtestado)
        Me.gbcabecera.Controls.Add(Me.Label4)
        Me.gbcabecera.Controls.Add(Me.Label2)
        Me.gbcabecera.Controls.Add(Me.txtproveedor)
        Me.gbcabecera.Controls.Add(Me.Label5)
        Me.gbcabecera.Controls.Add(Me.dtpemision)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.Label3)
        Me.gbcabecera.Location = New System.Drawing.Point(12, 35)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(1049, 151)
        Me.gbcabecera.TabIndex = 178
        Me.gbcabecera.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(750, 98)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 215
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(958, 97)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 214
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(646, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 213
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(231, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 212
        Me.PictureBox1.TabStop = False
        '
        'txtrucfacturar
        '
        Me.txtrucfacturar.Enabled = False
        Me.txtrucfacturar.Location = New System.Drawing.Point(920, 122)
        Me.txtrucfacturar.Name = "txtrucfacturar"
        Me.txtrucfacturar.ReadOnly = True
        Me.txtrucfacturar.Size = New System.Drawing.Size(123, 20)
        Me.txtrucfacturar.TabIndex = 211
        Me.txtrucfacturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(891, 125)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(22, 13)
        Me.Label20.TabIndex = 210
        Me.Label20.Text = "ruc"
        '
        'txtdireccionFacturar
        '
        Me.txtdireccionFacturar.Enabled = False
        Me.txtdireccionFacturar.Location = New System.Drawing.Point(344, 122)
        Me.txtdireccionFacturar.Name = "txtdireccionFacturar"
        Me.txtdireccionFacturar.ReadOnly = True
        Me.txtdireccionFacturar.Size = New System.Drawing.Size(541, 20)
        Me.txtdireccionFacturar.TabIndex = 209
        Me.txtdireccionFacturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(286, 125)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 208
        Me.Label19.Text = "Direccion"
        '
        'txtnombreFacturar
        '
        Me.txtnombreFacturar.Enabled = False
        Me.txtnombreFacturar.Location = New System.Drawing.Point(128, 122)
        Me.txtnombreFacturar.Name = "txtnombreFacturar"
        Me.txtnombreFacturar.ReadOnly = True
        Me.txtnombreFacturar.Size = New System.Drawing.Size(154, 20)
        Me.txtnombreFacturar.TabIndex = 207
        Me.txtnombreFacturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(10, 125)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 13)
        Me.Label18.TabIndex = 206
        Me.Label18.Text = "Facturar a nombre de "
        '
        'txtresponsable
        '
        Me.txtresponsable.Location = New System.Drawing.Point(979, 96)
        Me.txtresponsable.Name = "txtresponsable"
        Me.txtresponsable.ReadOnly = True
        Me.txtresponsable.Size = New System.Drawing.Size(64, 20)
        Me.txtresponsable.TabIndex = 205
        Me.txtresponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(826, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 13)
        Me.Label17.TabIndex = 204
        Me.Label17.Text = "Responsable de Compras"
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Location = New System.Drawing.Point(772, 97)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.ReadOnly = True
        Me.txtSolicitante.Size = New System.Drawing.Size(48, 20)
        Me.txtSolicitante.TabIndex = 203
        Me.txtSolicitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(648, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 13)
        Me.Label16.TabIndex = 202
        Me.Label16.Text = "Personal Solicitante"
        '
        'txtentrega
        '
        Me.txtentrega.Enabled = False
        Me.txtentrega.Location = New System.Drawing.Point(128, 96)
        Me.txtentrega.Name = "txtentrega"
        Me.txtentrega.ReadOnly = True
        Me.txtentrega.Size = New System.Drawing.Size(514, 20)
        Me.txtentrega.TabIndex = 201
        Me.txtentrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(54, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 200
        Me.Label15.Text = "Entregar en "
        '
        'txtcotizacion
        '
        Me.txtcotizacion.BackColor = System.Drawing.Color.White
        Me.txtcotizacion.Location = New System.Drawing.Point(866, 69)
        Me.txtcotizacion.MaxLength = 15
        Me.txtcotizacion.Name = "txtcotizacion"
        Me.txtcotizacion.Size = New System.Drawing.Size(177, 20)
        Me.txtcotizacion.TabIndex = 199
        Me.txtcotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(784, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 198
        Me.Label14.Text = "Nro.Cotizacion"
        '
        'txtFormaPago
        '
        Me.txtFormaPago.Location = New System.Drawing.Point(671, 69)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(105, 20)
        Me.txtFormaPago.TabIndex = 195
        Me.txtFormaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(579, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 194
        Me.Label12.Text = "Forma Pago"
        '
        'txttipoCambio
        '
        Me.txttipoCambio.Enabled = False
        Me.txttipoCambio.Location = New System.Drawing.Point(497, 67)
        Me.txttipoCambio.Name = "txttipoCambio"
        Me.txttipoCambio.ReadOnly = True
        Me.txttipoCambio.Size = New System.Drawing.Size(72, 20)
        Me.txttipoCambio.TabIndex = 193
        Me.txttipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(439, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "T/cambio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(229, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Moneda"
        '
        'cbomoneda
        '
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(281, 67)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(152, 21)
        Me.cbomoneda.TabIndex = 190
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(30, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 188
        Me.Label9.Text = "Fecha de entrega"
        '
        'dtpEntrega
        '
        Me.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntrega.Location = New System.Drawing.Point(129, 67)
        Me.dtpEntrega.Name = "dtpEntrega"
        Me.dtpEntrega.Size = New System.Drawing.Size(97, 20)
        Me.dtpEntrega.TabIndex = 189
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(891, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 187
        Me.Label8.Text = "Ruc"
        '
        'txtproveedor_ruc
        '
        Me.txtproveedor_ruc.Location = New System.Drawing.Point(920, 41)
        Me.txtproveedor_ruc.Name = "txtproveedor_ruc"
        Me.txtproveedor_ruc.Size = New System.Drawing.Size(123, 20)
        Me.txtproveedor_ruc.TabIndex = 186
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(261, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 185
        Me.Label6.Text = "Razon social"
        '
        'txtproveedor_razons
        '
        Me.txtproveedor_razons.Location = New System.Drawing.Point(335, 42)
        Me.txtproveedor_razons.Name = "txtproveedor_razons"
        Me.txtproveedor_razons.Size = New System.Drawing.Size(550, 20)
        Me.txtproveedor_razons.TabIndex = 184
        '
        'txtestado
        '
        Me.txtestado.Enabled = False
        Me.txtestado.Location = New System.Drawing.Point(538, 17)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.ReadOnly = True
        Me.txtestado.Size = New System.Drawing.Size(128, 20)
        Me.txtestado.TabIndex = 183
        Me.txtestado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(490, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 182
        Me.Label4.Text = "Estado"
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(129, 41)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(96, 20)
        Me.txtproveedor.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(65, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Proveedor"
        '
        'dtpemision
        '
        Me.dtpemision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpemision.Location = New System.Drawing.Point(377, 17)
        Me.dtpemision.Name = "dtpemision"
        Me.dtpemision.Size = New System.Drawing.Size(107, 20)
        Me.dtpemision.TabIndex = 4
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(129, 16)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(146, 20)
        Me.txtcodigo.TabIndex = 1
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(11, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nro de Orden Compra"
        '
        'gbDetalles
        '
        Me.gbDetalles.Controls.Add(Me.dgvDetalles)
        Me.gbDetalles.Location = New System.Drawing.Point(12, 217)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(946, 179)
        Me.gbDetalles.TabIndex = 179
        Me.gbDetalles.TabStop = False
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(11, 13)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles.Size = New System.Drawing.Size(928, 158)
        Me.dgvDetalles.TabIndex = 0
        '
        'txtComentario
        '
        Me.txtComentario.BackColor = System.Drawing.Color.White
        Me.txtComentario.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtComentario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentario.Location = New System.Drawing.Point(161, 189)
        Me.txtComentario.MaxLength = 355
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentario.Size = New System.Drawing.Size(900, 25)
        Me.txtComentario.TabIndex = 180
        Me.txtComentario.Text = " "
        '
        'gbOpciones
        '
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Location = New System.Drawing.Point(961, 216)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(99, 176)
        Me.gbOpciones.TabIndex = 182
        Me.gbOpciones.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(8, 71)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(83, 36)
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
        Me.btnquitar.Location = New System.Drawing.Point(8, 113)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(83, 36)
        Me.btnquitar.TabIndex = 15
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(6, 29)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(83, 36)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(17, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Comentarios / Observacione"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.White
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.Location = New System.Drawing.Point(865, 445)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(89, 21)
        Me.txtPrecioVenta.TabIndex = 195
        Me.txtPrecioVenta.Text = "0.00"
        Me.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(786, 448)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 13)
        Me.Label28.TabIndex = 194
        Me.Label28.Text = "&Precio Venta"
        '
        'txtIgv
        '
        Me.txtIgv.BackColor = System.Drawing.Color.White
        Me.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIgv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgv.Location = New System.Drawing.Point(865, 422)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(89, 21)
        Me.txtIgv.TabIndex = 193
        Me.txtIgv.Text = "0.00"
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(823, 424)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 13)
        Me.Label24.TabIndex = 192
        Me.Label24.Text = "&I.G.V"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.BackColor = System.Drawing.Color.White
        Me.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentos.Location = New System.Drawing.Point(698, 399)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(89, 21)
        Me.txtDescuentos.TabIndex = 191
        Me.txtDescuentos.Text = "0.00"
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(629, 403)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 190
        Me.Label23.Text = "&Descuento"
        '
        'txtvalorVenta
        '
        Me.txtvalorVenta.BackColor = System.Drawing.Color.White
        Me.txtvalorVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalorVenta.Location = New System.Drawing.Point(865, 399)
        Me.txtvalorVenta.Name = "txtvalorVenta"
        Me.txtvalorVenta.Size = New System.Drawing.Size(89, 21)
        Me.txtvalorVenta.TabIndex = 189
        Me.txtvalorVenta.Text = "0.00"
        Me.txtvalorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(792, 402)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 188
        Me.Label22.Text = "&Valor Venta"
        '
        'txtBruto
        '
        Me.txtBruto.BackColor = System.Drawing.Color.White
        Me.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBruto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBruto.Location = New System.Drawing.Point(536, 400)
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.ReadOnly = True
        Me.txtBruto.Size = New System.Drawing.Size(89, 21)
        Me.txtBruto.TabIndex = 187
        Me.txtBruto.Text = "0.00"
        Me.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(462, 404)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 186
        Me.Label13.Text = "Valor Bruto"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGrabar, Me.btnConsultar, Me.btnEliminar, Me.btnImprimir, Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1085, 25)
        Me.ToolStrip1.TabIndex = 196
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
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(66, 22)
        Me.btnGrabar.Text = "&Grabar"
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
        Me.btnEliminar.Size = New System.Drawing.Size(72, 22)
        Me.btnEliminar.Text = "&Eliminar"
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
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'FrmManufactura_Orden_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1085, 479)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbcabecera)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtIgv)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtDescuentos)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtvalorVenta)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtBruto)
        Me.Controls.Add(Me.Label13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmManufactura_Orden_Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Compra"
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalles.ResumeLayout(False)
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpemision As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents txtComentario As System.Windows.Forms.RichTextBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor_ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor_razons As System.Windows.Forms.TextBox
    Friend WithEvents txtestado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtentrega As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcotizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txttipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtresponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSolicitante As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtrucfacturar As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtdireccionFacturar As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtnombreFacturar As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDescuentos As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtvalorVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtBruto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
