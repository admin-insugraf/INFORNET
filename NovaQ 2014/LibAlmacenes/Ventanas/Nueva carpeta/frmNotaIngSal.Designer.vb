<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaIngSal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotaIngSal))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkValorizado = New System.Windows.Forms.CheckBox()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.bsMoneda = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTipoDocumento = New System.Windows.Forms.TextBox()
        Me.txtNumeroReferencia = New System.Windows.Forms.TextBox()
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox()
        Me.bsAlmacen = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvdetalleAlmacen = New System.Windows.Forms.DataGridView()
        Me.NumeroLineaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QT_BULTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsLineaNotaPedido = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
        Me.bsCentroCosto = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.cmbTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.bsTipoMovimiento = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.gbLeyenda = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.txtcodigoTercero = New System.Windows.Forms.TextBox()
        Me.txtcodigoProveedor = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbCabceraDocumento = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.bsMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdetalleAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLineaNotaPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.bsCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.gbLeyenda.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.gbCabceraDocumento.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
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
        'chkValorizado
        '
        Me.chkValorizado.AutoSize = True
        Me.chkValorizado.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkValorizado.Location = New System.Drawing.Point(513, 30)
        Me.chkValorizado.Name = "chkValorizado"
        Me.chkValorizado.Size = New System.Drawing.Size(92, 21)
        Me.chkValorizado.TabIndex = 3
        Me.chkValorizado.Text = "Valorizado"
        Me.chkValorizado.UseVisualStyleBackColor = True
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DataSource = Me.bsMoneda
        Me.cmbMoneda.DisplayMember = "Nombre"
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(709, 117)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(60, 21)
        Me.cmbMoneda.TabIndex = 36
        Me.cmbMoneda.ValueMember = "ID"
        Me.cmbMoneda.Visible = False
        '
        'bsMoneda
        '
        Me.bsMoneda.DataSource = GetType(LibAlmacenes.Moneda)
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTipoDocumento.Location = New System.Drawing.Point(115, 33)
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.ReadOnly = True
        Me.txtTipoDocumento.Size = New System.Drawing.Size(46, 20)
        Me.txtTipoDocumento.TabIndex = 8
        Me.txtTipoDocumento.Tag = "Tipo documento Referencia"
        Me.txtTipoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeroReferencia
        '
        Me.txtNumeroReferencia.BackColor = System.Drawing.Color.White
        Me.txtNumeroReferencia.Location = New System.Drawing.Point(384, 34)
        Me.txtNumeroReferencia.Name = "txtNumeroReferencia"
        Me.txtNumeroReferencia.Size = New System.Drawing.Size(158, 20)
        Me.txtNumeroReferencia.TabIndex = 9
        Me.txtNumeroReferencia.Tag = "Numero documento Referencia"
        Me.txtNumeroReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.bsAlmacen
        Me.cmbAlmacen.DisplayMember = "Nombre"
        Me.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(115, 9)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(193, 21)
        Me.cmbAlmacen.TabIndex = 6
        Me.cmbAlmacen.ValueMember = "Codigo"
        '
        'bsAlmacen
        '
        Me.bsAlmacen.DataSource = GetType(LibAlmacenes.Almacen)
        '
        'dgvdetalleAlmacen
        '
        Me.dgvdetalleAlmacen.AllowUserToAddRows = False
        Me.dgvdetalleAlmacen.AllowUserToDeleteRows = False
        Me.dgvdetalleAlmacen.AutoGenerateColumns = False
        Me.dgvdetalleAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalleAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroLineaDataGridViewTextBoxColumn, Me.IDArticuloDataGridViewTextBoxColumn, Me.ArticuloDataGridViewTextBoxColumn, Me.UnitArticulo, Me.CantidadDataGridViewTextBoxColumn, Me.Monto, Me.QT_BULTOS, Me.Column1, Me.Lote})
        Me.dgvdetalleAlmacen.DataSource = Me.bsLineaNotaPedido
        Me.dgvdetalleAlmacen.Location = New System.Drawing.Point(5, 64)
        Me.dgvdetalleAlmacen.Name = "dgvdetalleAlmacen"
        Me.dgvdetalleAlmacen.ReadOnly = True
        Me.dgvdetalleAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdetalleAlmacen.Size = New System.Drawing.Size(755, 177)
        Me.dgvdetalleAlmacen.TabIndex = 13
        '
        'NumeroLineaDataGridViewTextBoxColumn
        '
        Me.NumeroLineaDataGridViewTextBoxColumn.DataPropertyName = "NumeroLinea"
        Me.NumeroLineaDataGridViewTextBoxColumn.HeaderText = "Linea"
        Me.NumeroLineaDataGridViewTextBoxColumn.Name = "NumeroLineaDataGridViewTextBoxColumn"
        Me.NumeroLineaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroLineaDataGridViewTextBoxColumn.Width = 50
        '
        'IDArticuloDataGridViewTextBoxColumn
        '
        Me.IDArticuloDataGridViewTextBoxColumn.DataPropertyName = "IDArticulo"
        Me.IDArticuloDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.IDArticuloDataGridViewTextBoxColumn.Name = "IDArticuloDataGridViewTextBoxColumn"
        Me.IDArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDArticuloDataGridViewTextBoxColumn.Width = 70
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "Articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "Articulo"
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ArticuloDataGridViewTextBoxColumn.Width = 220
        '
        'UnitArticulo
        '
        Me.UnitArticulo.DataPropertyName = "UnitArticulo"
        Me.UnitArticulo.HeaderText = "Unidad"
        Me.UnitArticulo.Name = "UnitArticulo"
        Me.UnitArticulo.ReadOnly = True
        Me.UnitArticulo.Width = 60
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle10
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Visible = False
        '
        'QT_BULTOS
        '
        Me.QT_BULTOS.DataPropertyName = "QT_BULTOS"
        Me.QT_BULTOS.HeaderText = "Bultos"
        Me.QT_BULTOS.Name = "QT_BULTOS"
        Me.QT_BULTOS.ReadOnly = True
        Me.QT_BULTOS.Width = 60
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "NUM_PROTOCOLOS"
        Me.Column1.HeaderText = "Num_protocolo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'Lote
        '
        Me.Lote.DataPropertyName = "Lote"
        Me.Lote.HeaderText = "Lote"
        Me.Lote.Name = "Lote"
        Me.Lote.ReadOnly = True
        Me.Lote.Width = 60
        '
        'bsLineaNotaPedido
        '
        Me.bsLineaNotaPedido.DataSource = GetType(LibAlmacenes.LineaNotaPedido)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(715, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Moneda"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(726, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "T / C"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Almacen de Destino"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(313, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Centro Costo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(43, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Tip Doc Ref."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(300, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Num. Doc Ref."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Location = New System.Drawing.Point(13, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 60)
        Me.Panel1.TabIndex = 28
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(91, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 54)
        Me.Button4.TabIndex = 100
        Me.Button4.Text = "&Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(7, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(66, 54)
        Me.btnAceptar.TabIndex = 99
        Me.btnAceptar.Text = "&Guardar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmbCentroCosto
        '
        Me.cmbCentroCosto.DataSource = Me.bsCentroCosto
        Me.cmbCentroCosto.DisplayMember = "Nombre"
        Me.cmbCentroCosto.FormattingEnabled = True
        Me.cmbCentroCosto.Location = New System.Drawing.Point(385, 10)
        Me.cmbCentroCosto.Name = "cmbCentroCosto"
        Me.cmbCentroCosto.Size = New System.Drawing.Size(157, 21)
        Me.cmbCentroCosto.TabIndex = 7
        Me.cmbCentroCosto.ValueMember = "Codigo"
        '
        'bsCentroCosto
        '
        Me.bsCentroCosto.DataSource = GetType(LibAlmacenes.CentroCosto)
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(11, 126)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(41, 41)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(11, 73)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(41, 41)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(11, 21)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(41, 41)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(52, 84)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(56, 13)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Proveedor"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(619, 244)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(137, 20)
        Me.txtTotal.TabIndex = 31
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(570, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Total :"
        '
        'errores
        '
        Me.errores.ContainerControl = Me
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(69, 106)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(39, 13)
        Me.LinkLabel2.TabIndex = 29
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Cliente"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Black
        '
        'cmbTipoMovimiento
        '
        Me.cmbTipoMovimiento.DataSource = Me.bsTipoMovimiento
        Me.cmbTipoMovimiento.DisplayMember = "Nombre"
        Me.cmbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoMovimiento.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmbTipoMovimiento.FormattingEnabled = True
        Me.cmbTipoMovimiento.Location = New System.Drawing.Point(6, 17)
        Me.cmbTipoMovimiento.Name = "cmbTipoMovimiento"
        Me.cmbTipoMovimiento.Size = New System.Drawing.Size(378, 24)
        Me.cmbTipoMovimiento.TabIndex = 2
        Me.cmbTipoMovimiento.ValueMember = "Codigo"
        '
        'bsTipoMovimiento
        '
        Me.bsTipoMovimiento.DataSource = GetType(LibAlmacenes.TipoMovimiento)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmbTipoMovimiento)
        Me.GroupBox5.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(116, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(390, 49)
        Me.GroupBox5.TabIndex = 111
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TRANSACCIONES"
        '
        'gbLeyenda
        '
        Me.gbLeyenda.Controls.Add(Me.Label13)
        Me.gbLeyenda.Controls.Add(Me.TextBox1)
        Me.gbLeyenda.Controls.Add(Me.TextBox2)
        Me.gbLeyenda.Controls.Add(Me.Label12)
        Me.gbLeyenda.Location = New System.Drawing.Point(613, 12)
        Me.gbLeyenda.Name = "gbLeyenda"
        Me.gbLeyenda.Size = New System.Drawing.Size(218, 43)
        Me.gbLeyenda.TabIndex = 109
        Me.gbLeyenda.TabStop = False
        Me.gbLeyenda.Text = "Leyenda"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
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
        Me.Label12.Location = New System.Drawing.Point(27, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Ingresar datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTipoDocRef)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtordenCompra)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.lbltercero)
        Me.GroupBox2.Controls.Add(Me.lblproveedor)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtorderFabricacion)
        Me.GroupBox2.Controls.Add(Me.cmbAlmacen)
        Me.GroupBox2.Controls.Add(Me.txtNumeroReferencia)
        Me.GroupBox2.Controls.Add(Me.txtcodigoTercero)
        Me.GroupBox2.Controls.Add(Me.txtTipoDocumento)
        Me.GroupBox2.Controls.Add(Me.txtcodigoProveedor)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbCentroCosto)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.LinkLabel2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(15, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(837, 130)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'lblTipoDocRef
        '
        Me.lblTipoDocRef.AutoSize = True
        Me.lblTipoDocRef.Font = New System.Drawing.Font("Book Antiqua", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipoDocRef.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocRef.Location = New System.Drawing.Point(189, 35)
        Me.lblTipoDocRef.Name = "lblTipoDocRef"
        Me.lblTipoDocRef.Size = New System.Drawing.Size(17, 16)
        Me.lblTipoDocRef.TabIndex = 110
        Me.lblTipoDocRef.Text = "..."
        Me.lblTipoDocRef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(291, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Orden de Compra"
        '
        'txtordenCompra
        '
        Me.txtordenCompra.BackColor = System.Drawing.Color.White
        Me.txtordenCompra.Location = New System.Drawing.Point(383, 57)
        Me.txtordenCompra.Name = "txtordenCompra"
        Me.txtordenCompra.Size = New System.Drawing.Size(159, 20)
        Me.txtordenCompra.TabIndex = 11
        Me.txtordenCompra.Tag = "Orden de Compra"
        Me.txtordenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(164, 34)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 109
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(188, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 108
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(188, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'lbltercero
        '
        Me.lbltercero.AutoSize = True
        Me.lbltercero.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbltercero.ForeColor = System.Drawing.Color.Black
        Me.lbltercero.Location = New System.Drawing.Point(214, 107)
        Me.lbltercero.Name = "lbltercero"
        Me.lbltercero.Size = New System.Drawing.Size(17, 18)
        Me.lbltercero.TabIndex = 43
        Me.lbltercero.Text = "..."
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblproveedor.ForeColor = System.Drawing.Color.Black
        Me.lblproveedor.Location = New System.Drawing.Point(214, 83)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(17, 18)
        Me.lblproveedor.TabIndex = 36
        Me.lblproveedor.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(5, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Orden de fabricacion"
        '
        'txtorderFabricacion
        '
        Me.txtorderFabricacion.BackColor = System.Drawing.Color.White
        Me.txtorderFabricacion.Location = New System.Drawing.Point(114, 57)
        Me.txtorderFabricacion.Name = "txtorderFabricacion"
        Me.txtorderFabricacion.Size = New System.Drawing.Size(171, 20)
        Me.txtorderFabricacion.TabIndex = 10
        Me.txtorderFabricacion.Tag = "Orden de Fabricacion"
        Me.txtorderFabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoTercero
        '
        Me.txtcodigoTercero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcodigoTercero.Location = New System.Drawing.Point(114, 105)
        Me.txtcodigoTercero.Name = "txtcodigoTercero"
        Me.txtcodigoTercero.ReadOnly = True
        Me.txtcodigoTercero.Size = New System.Drawing.Size(68, 20)
        Me.txtcodigoTercero.TabIndex = 13
        Me.txtcodigoTercero.Tag = "Cliente"
        '
        'txtcodigoProveedor
        '
        Me.txtcodigoProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcodigoProveedor.Location = New System.Drawing.Point(114, 81)
        Me.txtcodigoProveedor.Name = "txtcodigoProveedor"
        Me.txtcodigoProveedor.ReadOnly = True
        Me.txtcodigoProveedor.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoProveedor.TabIndex = 12
        Me.txtcodigoProveedor.Tag = "Proveedor"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox3.TabIndex = 109
        Me.PictureBox3.TabStop = False
        '
        'txtComentarios
        '
        Me.txtComentarios.BackColor = System.Drawing.Color.Aquamarine
        Me.txtComentarios.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarios.Location = New System.Drawing.Point(54, 26)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarios.Size = New System.Drawing.Size(706, 32)
        Me.txtComentarios.TabIndex = 14
        Me.txtComentarios.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Controls.Add(Me.btnModificar)
        Me.GroupBox4.Controls.Add(Me.btnEliminar)
        Me.GroupBox4.Location = New System.Drawing.Point(760, 59)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(64, 183)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        '
        'gbCabceraDocumento
        '
        Me.gbCabceraDocumento.Controls.Add(Me.GroupBox1)
        Me.gbCabceraDocumento.Controls.Add(Me.GroupBox2)
        Me.gbCabceraDocumento.Controls.Add(Me.GroupBox3)
        Me.gbCabceraDocumento.Location = New System.Drawing.Point(12, 66)
        Me.gbCabceraDocumento.Name = "gbCabceraDocumento"
        Me.gbCabceraDocumento.Size = New System.Drawing.Size(868, 503)
        Me.gbCabceraDocumento.TabIndex = 40
        Me.gbCabceraDocumento.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.dgvdetalleAlmacen)
        Me.GroupBox3.Controls.Add(Me.dgvDetalle)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.txtComentarios)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(837, 275)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(19, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(243, 13)
        Me.Label27.TabIndex = 122
        Me.Label27.Text = "Datos Adicionales / Observaciones / Comentarios"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.DataGridViewTextBoxColumn1})
        Me.dgvDetalle.Location = New System.Drawing.Point(4, 64)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(827, 204)
        Me.dgvDetalle.TabIndex = 41
        Me.dgvDetalle.Visible = False
        '
        'Column7
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column7.HeaderText = "Item"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 40
        '
        'Column8
        '
        Me.Column8.HeaderText = "Codigo"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 60
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
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column10.HeaderText = "Unidad"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 45
        '
        'Column11
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column11.HeaderText = "Numero_Analisis"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.Format = "N4"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column12.HeaderText = "Cantidad "
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 80
        '
        'Column13
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column13.HeaderText = "Bultos"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 60
        '
        'Column14
        '
        Me.Column14.HeaderText = "Entrega"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 60
        '
        'Column15
        '
        Me.Column15.HeaderText = "Num_Protocolo"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(838, 60)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ComboBox1)
        Me.GroupBox6.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(116, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(390, 49)
        Me.GroupBox6.TabIndex = 111
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "TRANSACCIONES"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.bsTipoMovimiento
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(378, 24)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "Codigo"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.TextBox3)
        Me.GroupBox7.Controls.Add(Me.TextBox4)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Location = New System.Drawing.Point(613, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(218, 43)
        Me.GroupBox7.TabIndex = 109
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Leyenda"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label6.Location = New System.Drawing.Point(124, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "No ingresar datos"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(6, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(17, 15)
        Me.TextBox3.TabIndex = 37
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(103, 21)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(17, 15)
        Me.TextBox4.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label11.Location = New System.Drawing.Point(27, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Ingresar datos"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(513, 30)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 21)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Valorizado"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 24)
        Me.DateTimePicker1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.bsMoneda
        Me.ComboBox2.DisplayMember = "Nombre"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(709, 117)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(60, 21)
        Me.ComboBox2.TabIndex = 36
        Me.ComboBox2.ValueMember = "ID"
        Me.ComboBox2.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 16)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Fecha"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(715, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Moneda"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(726, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "T / C"
        Me.Label17.Visible = False
        '
        'frmNotaIngSal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(893, 598)
        Me.Controls.Add(Me.gbCabceraDocumento)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotaIngSal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.bsMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdetalleAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLineaNotaPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.bsCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTipoMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.gbLeyenda.ResumeLayout(False)
        Me.gbLeyenda.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.gbCabceraDocumento.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkValorizado As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtTipoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroReferencia As System.Windows.Forms.TextBox
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents dgvdetalleAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents bsLineaNotaPedido As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents bsMoneda As System.Windows.Forms.BindingSource
    Friend WithEvents bsAlmacen As System.Windows.Forms.BindingSource
    Friend WithEvents bsCentroCosto As System.Windows.Forms.BindingSource
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents errores As System.Windows.Forms.ErrorProvider
    'Friend WithEvents txtTipoCambio As LibControlUser.TextNumeric
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbTipoMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents bsTipoMovimiento As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoTercero As System.Windows.Forms.TextBox
    Friend WithEvents gbCabceraDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtorderFabricacion As System.Windows.Forms.TextBox
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents lbltercero As System.Windows.Forms.Label
    Friend WithEvents lblproveedor As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As LibControlUser.TextNumeric
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents NumeroLineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QT_BULTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtordenCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocRef As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
