<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegOrdenCompra
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
        Me.ToolOpciones = New System.Windows.Forms.ToolStrip()
        Me.tNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tcPedidos = New System.Windows.Forms.TabControl()
        Me.tpLista = New System.Windows.Forms.TabPage()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAprobar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dgwListaPedidos = New System.Windows.Forms.DataGridView()
        Me.tpGenerar = New System.Windows.Forms.TabPage()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.txtISC = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.txtValorVenta = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.txtCodResponsable = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNumPedido = New System.Windows.Forms.Label()
        Me.gbDatosGuia = New System.Windows.Forms.GroupBox()
        Me.txtNotaIngreso = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNumeroProv = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSerieProv = New System.Windows.Forms.TextBox()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkSinIGV = New System.Windows.Forms.CheckBox()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.lblAlmacen = New System.Windows.Forms.Label()
        Me.lblDesCompra = New System.Windows.Forms.Label()
        Me.dtFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtRucDni = New System.Windows.Forms.TextBox()
        Me.txtCodProveedor = New System.Windows.Forms.TextBox()
        Me.txtAlmacen = New System.Windows.Forms.TextBox()
        Me.txtCodCompra = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgwDetallePed = New System.Windows.Forms.DataGridView()
        Me.cmPedidos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmImprimirPedido = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmImprimirFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolOpciones.SuspendLayout()
        Me.tcPedidos.SuspendLayout()
        Me.tpLista.SuspendLayout()
        CType(Me.dgwListaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpGenerar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDatosGuia.SuspendLayout()
        CType(Me.dgwDetallePed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmPedidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolOpciones
        '
        Me.ToolOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tNuevo, Me.tGrabar, Me.tImprimir, Me.tCancelar})
        Me.ToolOpciones.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpciones.Name = "ToolOpciones"
        Me.ToolOpciones.Size = New System.Drawing.Size(1028, 25)
        Me.ToolOpciones.TabIndex = 0
        Me.ToolOpciones.Text = "ToolStrip1"
        '
        'tNuevo
        '
        Me.tNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tNuevo.Image = Global.LibProveedores.My.Resources.Resource1.add_file_26
        Me.tNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tNuevo.Name = "tNuevo"
        Me.tNuevo.Size = New System.Drawing.Size(23, 22)
        Me.tNuevo.Text = "ToolStripButton1"
        '
        'tGrabar
        '
        Me.tGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tGrabar.Image = Global.LibProveedores.My.Resources.Resource1.grabar1
        Me.tGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tGrabar.Name = "tGrabar"
        Me.tGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tGrabar.Text = "ToolStripButton2"
        '
        'tImprimir
        '
        Me.tImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tImprimir.Image = Global.LibProveedores.My.Resources.Resource1.imprimir
        Me.tImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tImprimir.Name = "tImprimir"
        Me.tImprimir.Size = New System.Drawing.Size(23, 22)
        Me.tImprimir.Text = "ToolStripButton3"
        '
        'tCancelar
        '
        Me.tCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tCancelar.Image = Global.LibProveedores.My.Resources.Resource1.cancelar
        Me.tCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tCancelar.Name = "tCancelar"
        Me.tCancelar.Size = New System.Drawing.Size(23, 22)
        Me.tCancelar.Text = "ToolStripButton4"
        '
        'tcPedidos
        '
        Me.tcPedidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcPedidos.Controls.Add(Me.tpLista)
        Me.tcPedidos.Controls.Add(Me.tpGenerar)
        Me.tcPedidos.Location = New System.Drawing.Point(12, 41)
        Me.tcPedidos.Name = "tcPedidos"
        Me.tcPedidos.SelectedIndex = 0
        Me.tcPedidos.Size = New System.Drawing.Size(1004, 580)
        Me.tcPedidos.TabIndex = 66
        '
        'tpLista
        '
        Me.tpLista.Controls.Add(Me.btnFacturar)
        Me.tpLista.Controls.Add(Me.btnAnular)
        Me.tpLista.Controls.Add(Me.Label16)
        Me.tpLista.Controls.Add(Me.Label3)
        Me.tpLista.Controls.Add(Me.btnAprobar)
        Me.tpLista.Controls.Add(Me.btnBuscar)
        Me.tpLista.Controls.Add(Me.dtFechaFin)
        Me.tpLista.Controls.Add(Me.dtFechaIni)
        Me.tpLista.Controls.Add(Me.dgwListaPedidos)
        Me.tpLista.Location = New System.Drawing.Point(4, 22)
        Me.tpLista.Name = "tpLista"
        Me.tpLista.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLista.Size = New System.Drawing.Size(996, 554)
        Me.tpLista.TabIndex = 0
        Me.tpLista.Text = "Listado de OC"
        Me.tpLista.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(257, 489)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(115, 23)
        Me.btnFacturar.TabIndex = 8
        Me.btnFacturar.Text = "Facturar orden"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(136, 489)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(115, 23)
        Me.btnAnular.TabIndex = 7
        Me.btnAnular.Text = "Anular orden"
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(693, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(522, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Desde"
        '
        'btnAprobar
        '
        Me.btnAprobar.Location = New System.Drawing.Point(15, 489)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(115, 23)
        Me.btnAprobar.TabIndex = 4
        Me.btnAprobar.Text = "Aprobar orden"
        Me.btnAprobar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(861, 6)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(131, 37)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(738, 15)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(97, 20)
        Me.dtFechaFin.TabIndex = 2
        '
        'dtFechaIni
        '
        Me.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIni.Location = New System.Drawing.Point(579, 15)
        Me.dtFechaIni.Name = "dtFechaIni"
        Me.dtFechaIni.Size = New System.Drawing.Size(97, 20)
        Me.dtFechaIni.TabIndex = 1
        '
        'dgwListaPedidos
        '
        Me.dgwListaPedidos.AllowUserToAddRows = False
        Me.dgwListaPedidos.AllowUserToDeleteRows = False
        Me.dgwListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwListaPedidos.Location = New System.Drawing.Point(15, 50)
        Me.dgwListaPedidos.Name = "dgwListaPedidos"
        Me.dgwListaPedidos.ReadOnly = True
        Me.dgwListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwListaPedidos.Size = New System.Drawing.Size(977, 425)
        Me.dgwListaPedidos.TabIndex = 0
        '
        'tpGenerar
        '
        Me.tpGenerar.Controls.Add(Me.btnQuitar)
        Me.tpGenerar.Controls.Add(Me.txtISC)
        Me.tpGenerar.Controls.Add(Me.Label15)
        Me.tpGenerar.Controls.Add(Me.btnAgregar)
        Me.tpGenerar.Controls.Add(Me.txtPrecioVenta)
        Me.tpGenerar.Controls.Add(Me.txtIGV)
        Me.tpGenerar.Controls.Add(Me.txtValorVenta)
        Me.tpGenerar.Controls.Add(Me.Label24)
        Me.tpGenerar.Controls.Add(Me.Label23)
        Me.tpGenerar.Controls.Add(Me.Label22)
        Me.tpGenerar.Controls.Add(Me.GroupBox1)
        Me.tpGenerar.Controls.Add(Me.dgwDetallePed)
        Me.tpGenerar.Location = New System.Drawing.Point(4, 22)
        Me.tpGenerar.Name = "tpGenerar"
        Me.tpGenerar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGenerar.Size = New System.Drawing.Size(996, 554)
        Me.tpGenerar.TabIndex = 1
        Me.tpGenerar.Text = "Generar orden de compra"
        Me.tpGenerar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(928, 319)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 1
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'txtISC
        '
        Me.txtISC.Location = New System.Drawing.Point(240, 527)
        Me.txtISC.Name = "txtISC"
        Me.txtISC.Size = New System.Drawing.Size(105, 20)
        Me.txtISC.TabIndex = 79
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(207, 530)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Isc"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(928, 289)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(659, 527)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(105, 20)
        Me.txtPrecioVenta.TabIndex = 76
        '
        'txtIGV
        '
        Me.txtIGV.Location = New System.Drawing.Point(440, 527)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.Size = New System.Drawing.Size(105, 20)
        Me.txtIGV.TabIndex = 75
        '
        'txtValorVenta
        '
        Me.txtValorVenta.Location = New System.Drawing.Point(69, 527)
        Me.txtValorVenta.Name = "txtValorVenta"
        Me.txtValorVenta.Size = New System.Drawing.Size(105, 20)
        Me.txtValorVenta.TabIndex = 74
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(600, 530)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 13)
        Me.Label24.TabIndex = 71
        Me.Label24.Text = "P. Venta"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(407, 530)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(22, 13)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "Igv"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 530)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "V. Venta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResponsable)
        Me.GroupBox1.Controls.Add(Me.txtCodResponsable)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblNumPedido)
        Me.GroupBox1.Controls.Add(Me.gbDatosGuia)
        Me.GroupBox1.Controls.Add(Me.chkSinIGV)
        Me.GroupBox1.Controls.Add(Me.lblFormaPago)
        Me.GroupBox1.Controls.Add(Me.lblAlmacen)
        Me.GroupBox1.Controls.Add(Me.lblDesCompra)
        Me.GroupBox1.Controls.Add(Me.dtFechaEntrega)
        Me.GroupBox1.Controls.Add(Me.dtFechaEmision)
        Me.GroupBox1.Controls.Add(Me.cboMoneda)
        Me.GroupBox1.Controls.Add(Me.txtGlosa)
        Me.GroupBox1.Controls.Add(Me.txtFormaPago)
        Me.GroupBox1.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.txtRucDni)
        Me.GroupBox1.Controls.Add(Me.txtCodProveedor)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen)
        Me.GroupBox1.Controls.Add(Me.txtCodCompra)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(909, 272)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Location = New System.Drawing.Point(133, 190)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(10, 13)
        Me.lblResponsable.TabIndex = 75
        Me.lblResponsable.Text = "."
        '
        'txtCodResponsable
        '
        Me.txtCodResponsable.Location = New System.Drawing.Point(13, 187)
        Me.txtCodResponsable.Name = "txtCodResponsable"
        Me.txtCodResponsable.Size = New System.Drawing.Size(113, 20)
        Me.txtCodResponsable.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Responsable"
        '
        'lblNumPedido
        '
        Me.lblNumPedido.AutoSize = True
        Me.lblNumPedido.Location = New System.Drawing.Point(525, 28)
        Me.lblNumPedido.Name = "lblNumPedido"
        Me.lblNumPedido.Size = New System.Drawing.Size(45, 13)
        Me.lblNumPedido.TabIndex = 72
        Me.lblNumPedido.Text = "Label25"
        '
        'gbDatosGuia
        '
        Me.gbDatosGuia.Controls.Add(Me.txtNotaIngreso)
        Me.gbDatosGuia.Controls.Add(Me.Label18)
        Me.gbDatosGuia.Controls.Add(Me.txtNumeroProv)
        Me.gbDatosGuia.Controls.Add(Me.Label17)
        Me.gbDatosGuia.Controls.Add(Me.txtSerieProv)
        Me.gbDatosGuia.Controls.Add(Me.cbTipoDoc)
        Me.gbDatosGuia.Controls.Add(Me.Label20)
        Me.gbDatosGuia.Controls.Add(Me.Label19)
        Me.gbDatosGuia.Location = New System.Drawing.Point(528, 99)
        Me.gbDatosGuia.Name = "gbDatosGuia"
        Me.gbDatosGuia.Size = New System.Drawing.Size(376, 147)
        Me.gbDatosGuia.TabIndex = 71
        Me.gbDatosGuia.TabStop = False
        Me.gbDatosGuia.Text = "Datos de facturación / guia"
        Me.gbDatosGuia.Visible = False
        '
        'txtNotaIngreso
        '
        Me.txtNotaIngreso.Location = New System.Drawing.Point(107, 105)
        Me.txtNotaIngreso.Name = "txtNotaIngreso"
        Me.txtNotaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.txtNotaIngreso.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Nota de ingreso"
        '
        'txtNumeroProv
        '
        Me.txtNumeroProv.Location = New System.Drawing.Point(107, 74)
        Me.txtNumeroProv.Name = "txtNumeroProv"
        Me.txtNumeroProv.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroProv.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Número"
        '
        'txtSerieProv
        '
        Me.txtSerieProv.Location = New System.Drawing.Point(107, 48)
        Me.txtSerieProv.Name = "txtSerieProv"
        Me.txtSerieProv.Size = New System.Drawing.Size(100, 20)
        Me.txtSerieProv.TabIndex = 9
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Location = New System.Drawing.Point(107, 17)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(77, 21)
        Me.cbTipoDoc.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Documento"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Serie"
        '
        'chkSinIGV
        '
        Me.chkSinIGV.AutoSize = True
        Me.chkSinIGV.Location = New System.Drawing.Point(13, 250)
        Me.chkSinIGV.Name = "chkSinIGV"
        Me.chkSinIGV.Size = New System.Drawing.Size(93, 17)
        Me.chkSinIGV.TabIndex = 11
        Me.chkSinIGV.Text = "Precio sin IGV"
        Me.chkSinIGV.UseVisualStyleBackColor = True
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        Me.lblFormaPago.Location = New System.Drawing.Point(305, 147)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(10, 13)
        Me.lblFormaPago.TabIndex = 67
        Me.lblFormaPago.Text = "."
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(319, 31)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(10, 13)
        Me.lblAlmacen.TabIndex = 65
        Me.lblAlmacen.Text = "."
        '
        'lblDesCompra
        '
        Me.lblDesCompra.AutoSize = True
        Me.lblDesCompra.Location = New System.Drawing.Point(90, 31)
        Me.lblDesCompra.Name = "lblDesCompra"
        Me.lblDesCompra.Size = New System.Drawing.Size(10, 13)
        Me.lblDesCompra.TabIndex = 64
        Me.lblDesCompra.Text = "."
        '
        'dtFechaEntrega
        '
        Me.dtFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEntrega.Location = New System.Drawing.Point(795, 32)
        Me.dtFechaEntrega.Name = "dtFechaEntrega"
        Me.dtFechaEntrega.Size = New System.Drawing.Size(98, 20)
        Me.dtFechaEntrega.TabIndex = 3
        '
        'dtFechaEmision
        '
        Me.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmision.Location = New System.Drawing.Point(682, 32)
        Me.dtFechaEmision.Name = "dtFechaEmision"
        Me.dtFechaEmision.Size = New System.Drawing.Size(98, 20)
        Me.dtFechaEmision.TabIndex = 2
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(13, 144)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(71, 21)
        Me.cboMoneda.TabIndex = 6
        '
        'txtGlosa
        '
        Me.txtGlosa.Location = New System.Drawing.Point(13, 226)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(504, 20)
        Me.txtGlosa.TabIndex = 10
        '
        'txtFormaPago
        '
        Me.txtFormaPago.Location = New System.Drawing.Point(208, 144)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.Size = New System.Drawing.Size(91, 20)
        Me.txtFormaPago.TabIndex = 8
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(105, 144)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(77, 20)
        Me.txtTipoCambio.TabIndex = 7
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(13, 105)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(504, 20)
        Me.txtDireccion.TabIndex = 56
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(295, 66)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(392, 20)
        Me.txtRazonSocial.TabIndex = 55
        '
        'txtRucDni
        '
        Me.txtRucDni.Location = New System.Drawing.Point(150, 66)
        Me.txtRucDni.Name = "txtRucDni"
        Me.txtRucDni.Size = New System.Drawing.Size(113, 20)
        Me.txtRucDni.TabIndex = 5
        '
        'txtCodProveedor
        '
        Me.txtCodProveedor.Location = New System.Drawing.Point(13, 66)
        Me.txtCodProveedor.Name = "txtCodProveedor"
        Me.txtCodProveedor.Size = New System.Drawing.Size(113, 20)
        Me.txtCodProveedor.TabIndex = 4
        '
        'txtAlmacen
        '
        Me.txtAlmacen.Location = New System.Drawing.Point(254, 28)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(59, 20)
        Me.txtAlmacen.TabIndex = 1
        '
        'txtCodCompra
        '
        Me.txtCodCompra.Location = New System.Drawing.Point(13, 28)
        Me.txtCodCompra.Name = "txtCodCompra"
        Me.txtCodCompra.Size = New System.Drawing.Size(71, 20)
        Me.txtCodCompra.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Glosa"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(205, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Forma de pago"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(102, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Tipo de cambio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Moneda"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(292, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Razón social / Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "RUC / DNI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(792, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Fecha de pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(679, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Fecha de emisión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Almacén"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Tipo de compra"
        '
        'dgwDetallePed
        '
        Me.dgwDetallePed.AllowUserToAddRows = False
        Me.dgwDetallePed.AllowUserToDeleteRows = False
        Me.dgwDetallePed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDetallePed.Location = New System.Drawing.Point(14, 289)
        Me.dgwDetallePed.Name = "dgwDetallePed"
        Me.dgwDetallePed.ReadOnly = True
        Me.dgwDetallePed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDetallePed.Size = New System.Drawing.Size(909, 229)
        Me.dgwDetallePed.TabIndex = 65
        '
        'cmPedidos
        '
        Me.cmPedidos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmImprimirPedido, Me.cmImprimirFactura})
        Me.cmPedidos.Name = "cmPedidos"
        Me.cmPedidos.Size = New System.Drawing.Size(153, 48)
        '
        'cmImprimirPedido
        '
        Me.cmImprimirPedido.Name = "cmImprimirPedido"
        Me.cmImprimirPedido.Size = New System.Drawing.Size(152, 22)
        Me.cmImprimirPedido.Text = "Imprimir Pedido"
        '
        'cmImprimirFactura
        '
        Me.cmImprimirFactura.Name = "cmImprimirFactura"
        Me.cmImprimirFactura.Size = New System.Drawing.Size(152, 22)
        Me.cmImprimirFactura.Text = "Imprimir Factura"
        '
        'frmRegOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 631)
        Me.Controls.Add(Me.tcPedidos)
        Me.Controls.Add(Me.ToolOpciones)
        Me.Name = "frmRegOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegOrdenCompra"
        Me.ToolOpciones.ResumeLayout(False)
        Me.ToolOpciones.PerformLayout()
        Me.tcPedidos.ResumeLayout(False)
        Me.tpLista.ResumeLayout(False)
        Me.tpLista.PerformLayout()
        CType(Me.dgwListaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpGenerar.ResumeLayout(False)
        Me.tpGenerar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDatosGuia.ResumeLayout(False)
        Me.gbDatosGuia.PerformLayout()
        CType(Me.dgwDetallePed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmPedidos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tcPedidos As System.Windows.Forms.TabControl
    Friend WithEvents tpLista As System.Windows.Forms.TabPage
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAprobar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgwListaPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents tpGenerar As System.Windows.Forms.TabPage
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents txtISC As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIGV As System.Windows.Forms.TextBox
    Friend WithEvents txtValorVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumPedido As System.Windows.Forms.Label
    Friend WithEvents gbDatosGuia As System.Windows.Forms.GroupBox
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents chkSinIGV As System.Windows.Forms.CheckBox
    Friend WithEvents lblFormaPago As System.Windows.Forms.Label
    Friend WithEvents lblAlmacen As System.Windows.Forms.Label
    Friend WithEvents lblDesCompra As System.Windows.Forms.Label
    Friend WithEvents dtFechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtRucDni As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgwDetallePed As System.Windows.Forms.DataGridView
    Friend WithEvents cmPedidos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmImprimirPedido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmImprimirFactura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNumeroProv As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSerieProv As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCodResponsable As System.Windows.Forms.TextBox
    Friend WithEvents lblResponsable As System.Windows.Forms.Label
    Friend WithEvents txtNotaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
