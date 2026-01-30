<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLetras_ManejoDocumentosPendientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLetras_ManejoDocumentosPendientes))
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.pnlModificaciones = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboDatosContables = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txttipoCambio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtdescripcionVendedor = New System.Windows.Forms.TextBox()
        Me.txtcodigoVendedor = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.dtpEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdescripcionCliente = New System.Windows.Forms.TextBox()
        Me.txtcodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtnumeroDoc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigoTipoDoc = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbDatos.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        Me.pnlModificaciones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatos
        '
        Me.gbDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDatos.Controls.Add(Me.btnEliminar)
        Me.gbDatos.Controls.Add(Me.btnModificar)
        Me.gbDatos.Controls.Add(Me.btnNuevo)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.dgvDetalles)
        Me.gbDatos.Controls.Add(Me.dgvCabecera)
        Me.gbDatos.Controls.Add(Me.gbFiltros)
        Me.gbDatos.Location = New System.Drawing.Point(22, 12)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(778, 553)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.Blue
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(624, 350)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(132, 23)
        Me.btnEliminar.TabIndex = 181
        Me.btnEliminar.Text = "&Eliminar Documento"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.Blue
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(490, 350)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(132, 23)
        Me.btnModificar.TabIndex = 180
        Me.btnModificar.Text = "&Modificar Documento"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.Blue
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(355, 350)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(132, 23)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "&Nuevo Documento"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(19, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Detalles del Documento Seleccionado"
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(17, 377)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles.Size = New System.Drawing.Size(742, 160)
        Me.dgvDetalles.TabIndex = 178
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(17, 83)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(742, 263)
        Me.dgvCabecera.TabIndex = 177
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltros.Controls.Add(Me.lblCantidad)
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(17, 19)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(742, 47)
        Me.gbFiltros.TabIndex = 176
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Ingrese texto a Buscar :"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(552, 20)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 177
        Me.lblCantidad.Text = "."
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(539, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'pnlModificaciones
        '
        Me.pnlModificaciones.BackColor = System.Drawing.Color.Transparent
        Me.pnlModificaciones.Controls.Add(Me.GroupBox2)
        Me.pnlModificaciones.Controls.Add(Me.btn_exit)
        Me.pnlModificaciones.Controls.Add(Me.btn_ok)
        Me.pnlModificaciones.Controls.Add(Me.txtMensaje)
        Me.pnlModificaciones.Controls.Add(Me.GroupBox7)
        Me.pnlModificaciones.Controls.Add(Me.GroupBox6)
        Me.pnlModificaciones.Controls.Add(Me.GroupBox5)
        Me.pnlModificaciones.Location = New System.Drawing.Point(202, 96)
        Me.pnlModificaciones.Name = "pnlModificaciones"
        Me.pnlModificaciones.Size = New System.Drawing.Size(396, 431)
        Me.pnlModificaciones.TabIndex = 181
        Me.pnlModificaciones.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboDatosContables)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSaldo)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtImporte)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(22, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 70)
        Me.GroupBox2.TabIndex = 177
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Montos"
        '
        'cboDatosContables
        '
        Me.cboDatosContables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDatosContables.FormattingEnabled = True
        Me.cboDatosContables.Items.AddRange(New Object() {"DEBE (Suma)", "HABER (Resta)"})
        Me.cboDatosContables.Location = New System.Drawing.Point(237, 43)
        Me.cboDatosContables.Name = "cboDatosContables"
        Me.cboDatosContables.Size = New System.Drawing.Size(114, 21)
        Me.cboDatosContables.TabIndex = 178
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 177
        Me.Label6.Text = "Datos Contables"
        '
        'txtSaldo
        '
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Location = New System.Drawing.Point(103, 44)
        Me.txtSaldo.MaxLength = 21
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(109, 20)
        Me.txtSaldo.TabIndex = 176
        Me.txtSaldo.Text = "0.00"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Importe a Aplicar"
        '
        'txtImporte
        '
        Me.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporte.Location = New System.Drawing.Point(103, 18)
        Me.txtImporte.MaxLength = 21
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(109, 20)
        Me.txtImporte.TabIndex = 107
        Me.txtImporte.Text = "0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "Saldo Documento"
        '
        'btn_exit
        '
        Me.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.ForeColor = System.Drawing.Color.Navy
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_exit.Location = New System.Drawing.Point(202, 383)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(61, 37)
        Me.btn_exit.TabIndex = 170
        Me.btn_exit.Text = "Cancelar"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.ForeColor = System.Drawing.Color.Navy
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.Location = New System.Drawing.Point(139, 383)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(61, 37)
        Me.btn_ok.TabIndex = 111
        Me.btn_ok.Text = "Confirmar"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtMensaje.ForeColor = System.Drawing.Color.Navy
        Me.txtMensaje.Location = New System.Drawing.Point(2, 21)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(391, 20)
        Me.txtMensaje.TabIndex = 169
        Me.txtMensaje.Text = "..."
        Me.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txttipoCambio)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.PictureBox1)
        Me.GroupBox7.Controls.Add(Me.cboMoneda)
        Me.GroupBox7.Controls.Add(Me.txtdescripcionVendedor)
        Me.GroupBox7.Controls.Add(Me.txtcodigoVendedor)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(21, 224)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(362, 78)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Detalles"
        '
        'txttipoCambio
        '
        Me.txttipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipoCambio.Location = New System.Drawing.Point(284, 46)
        Me.txttipoCambio.MaxLength = 5
        Me.txttipoCambio.Name = "txttipoCambio"
        Me.txttipoCambio.Size = New System.Drawing.Size(60, 20)
        Me.txttipoCambio.TabIndex = 174
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "TipoCambio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Moneda"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(98, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 171
        Me.PictureBox1.TabStop = False
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(57, 45)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(156, 21)
        Me.cboMoneda.TabIndex = 110
        '
        'txtdescripcionVendedor
        '
        Me.txtdescripcionVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionVendedor.Location = New System.Drawing.Point(122, 19)
        Me.txtdescripcionVendedor.Name = "txtdescripcionVendedor"
        Me.txtdescripcionVendedor.ReadOnly = True
        Me.txtdescripcionVendedor.Size = New System.Drawing.Size(223, 20)
        Me.txtdescripcionVendedor.TabIndex = 109
        '
        'txtcodigoVendedor
        '
        Me.txtcodigoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoVendedor.Location = New System.Drawing.Point(57, 19)
        Me.txtcodigoVendedor.Name = "txtcodigoVendedor"
        Me.txtcodigoVendedor.ReadOnly = True
        Me.txtcodigoVendedor.Size = New System.Drawing.Size(38, 20)
        Me.txtcodigoVendedor.TabIndex = 106
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Cobrador"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dtpVencimiento)
        Me.GroupBox6.Controls.Add(Me.dtpEmision)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(21, 171)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(363, 47)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Fechas"
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento.Location = New System.Drawing.Point(244, 19)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(102, 20)
        Me.dtpVencimiento.TabIndex = 5
        '
        'dtpEmision
        '
        Me.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEmision.Location = New System.Drawing.Point(57, 19)
        Me.dtpEmision.Name = "dtpEmision"
        Me.dtpEmision.Size = New System.Drawing.Size(103, 20)
        Me.dtpEmision.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(170, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Vencimiento"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Emision"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtserie)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtdescripcionCliente)
        Me.GroupBox5.Controls.Add(Me.txtcodigoCliente)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Controls.Add(Me.txtnumeroDoc)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txtcodigoTipoDoc)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(22, 61)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(362, 95)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Documento"
        '
        'txtserie
        '
        Me.txtserie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtserie.Location = New System.Drawing.Point(101, 69)
        Me.txtserie.MaxLength = 3
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(38, 20)
        Me.txtserie.TabIndex = 181
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Serie. Documento"
        '
        'txtdescripcionCliente
        '
        Me.txtdescripcionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionCliente.Enabled = False
        Me.txtdescripcionCliente.Location = New System.Drawing.Point(133, 15)
        Me.txtdescripcionCliente.Name = "txtdescripcionCliente"
        Me.txtdescripcionCliente.Size = New System.Drawing.Size(216, 20)
        Me.txtdescripcionCliente.TabIndex = 179
        '
        'txtcodigoCliente
        '
        Me.txtcodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoCliente.Enabled = False
        Me.txtcodigoCliente.Location = New System.Drawing.Point(56, 15)
        Me.txtcodigoCliente.Name = "txtcodigoCliente"
        Me.txtcodigoCliente.Size = New System.Drawing.Size(75, 20)
        Me.txtcodigoCliente.TabIndex = 178
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "Cliente"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(141, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 172
        Me.PictureBox2.TabStop = False
        '
        'txtnumeroDoc
        '
        Me.txtnumeroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumeroDoc.Location = New System.Drawing.Point(245, 69)
        Me.txtnumeroDoc.MaxLength = 7
        Me.txtnumeroDoc.Name = "txtnumeroDoc"
        Me.txtnumeroDoc.Size = New System.Drawing.Size(106, 20)
        Me.txtnumeroDoc.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Nro. Documento"
        '
        'txtcodigoTipoDoc
        '
        Me.txtcodigoTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoTipoDoc.Location = New System.Drawing.Point(101, 40)
        Me.txtcodigoTipoDoc.Name = "txtcodigoTipoDoc"
        Me.txtcodigoTipoDoc.ReadOnly = True
        Me.txtcodigoTipoDoc.Size = New System.Drawing.Size(38, 20)
        Me.txtcodigoTipoDoc.TabIndex = 100
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Tipo Documento"
        '
        'FrmLetras_ManejoDocumentosPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 573)
        Me.Controls.Add(Me.pnlModificaciones)
        Me.Controls.Add(Me.gbDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLetras_ManejoDocumentosPendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Documentos Pendientes "
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.pnlModificaciones.ResumeLayout(False)
        Me.pnlModificaciones.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents pnlModificaciones As System.Windows.Forms.Panel
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtdescripcionVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodigoTipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtnumeroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDatosContables As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcionCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
