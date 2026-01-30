<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineaNotaPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLineaNotaPedido))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnNuevoLote = New System.Windows.Forms.Button()
        Me.cmbUnidad = New System.Windows.Forms.ComboBox()
        Me.bsUnidad = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCantidad = New LibControlUser.TextNumeric(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMonto = New LibControlUser.TextNumeric(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lnkArticulo = New System.Windows.Forms.LinkLabel()
        Me.cmbLote = New System.Windows.Forms.ComboBox()
        Me.bsLote = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtarticulo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbfinal = New System.Windows.Forms.RadioButton()
        Me.rbparcial = New System.Windows.Forms.RadioButton()
        Me.txtnumerobultos = New System.Windows.Forms.TextBox()
        Me.txtnumeroProtocolo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtStockLote = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFechaVencimiento = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblArticulodescripcion = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SalirBultos = New System.Windows.Forms.Button()
        Me.btnAceptarBultos = New System.Windows.Forms.Button()
        Me.gbBultos = New System.Windows.Forms.GroupBox()
        Me.dgvDetallesBulto = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCantidadAsiganda = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.bsUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBultos.SuspendLayout()
        CType(Me.dgvDetallesBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Location = New System.Drawing.Point(15, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 60)
        Me.Panel1.TabIndex = 29
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(87, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 54)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "&Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Regresar")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(4, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(66, 54)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Aceptar")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnNuevoLote
        '
        Me.btnNuevoLote.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoLote.ForeColor = System.Drawing.Color.Maroon
        Me.btnNuevoLote.Location = New System.Drawing.Point(157, 9)
        Me.btnNuevoLote.Name = "btnNuevoLote"
        Me.btnNuevoLote.Size = New System.Drawing.Size(36, 32)
        Me.btnNuevoLote.TabIndex = 46
        Me.btnNuevoLote.Text = "+"
        Me.btnNuevoLote.UseVisualStyleBackColor = True
        Me.btnNuevoLote.Visible = False
        '
        'cmbUnidad
        '
        Me.cmbUnidad.DataSource = Me.bsUnidad
        Me.cmbUnidad.DisplayMember = "Nombre"
        Me.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidad.Enabled = False
        Me.cmbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmbUnidad.FormattingEnabled = True
        Me.cmbUnidad.Location = New System.Drawing.Point(67, 17)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Size = New System.Drawing.Size(134, 23)
        Me.cmbUnidad.TabIndex = 2
        Me.cmbUnidad.ValueMember = "Codigo"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtCantidad.Location = New System.Drawing.Point(375, 27)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(65, 22)
        Me.txtCantidad.TabIndex = 5
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(372, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Cantidad"
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtMonto.Location = New System.Drawing.Point(300, 27)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(65, 22)
        Me.txtMonto.TabIndex = 6
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(298, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Monto"
        '
        'errores
        '
        Me.errores.ContainerControl = Me
        '
        'lnkArticulo
        '
        Me.lnkArticulo.AutoSize = True
        Me.lnkArticulo.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lnkArticulo.LinkColor = System.Drawing.Color.Black
        Me.lnkArticulo.Location = New System.Drawing.Point(11, 11)
        Me.lnkArticulo.Name = "lnkArticulo"
        Me.lnkArticulo.Size = New System.Drawing.Size(48, 16)
        Me.lnkArticulo.TabIndex = 40
        Me.lnkArticulo.TabStop = True
        Me.lnkArticulo.Text = "Articulo"
        Me.lnkArticulo.VisitedLinkColor = System.Drawing.Color.Black
        '
        'cmbLote
        '
        Me.cmbLote.DataSource = Me.bsLote
        Me.cmbLote.DisplayMember = "Codigo"
        Me.cmbLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmbLote.FormattingEnabled = True
        Me.cmbLote.Location = New System.Drawing.Point(51, 15)
        Me.cmbLote.Name = "cmbLote"
        Me.cmbLote.Size = New System.Drawing.Size(101, 23)
        Me.cmbLote.TabIndex = 3
        Me.cmbLote.ValueMember = "Codigo"
        Me.cmbLote.Visible = False
        '
        'bsLote
        '
        Me.bsLote.DataSource = GetType(LibAlmacenes.Lote)
        '
        'txtarticulo
        '
        Me.txtarticulo.Location = New System.Drawing.Point(64, 9)
        Me.txtarticulo.Name = "txtarticulo"
        Me.txtarticulo.Size = New System.Drawing.Size(48, 20)
        Me.txtarticulo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 224)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.txtnumerobultos)
        Me.GroupBox4.Controls.Add(Me.txtCantidad)
        Me.GroupBox4.Controls.Add(Me.txtnumeroProtocolo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtMonto)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 151)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(560, 64)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbfinal)
        Me.GroupBox2.Controls.Add(Me.rbparcial)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 36)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de entrega."
        '
        'rbfinal
        '
        Me.rbfinal.AutoSize = True
        Me.rbfinal.Checked = True
        Me.rbfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbfinal.Location = New System.Drawing.Point(106, 15)
        Me.rbfinal.Name = "rbfinal"
        Me.rbfinal.Size = New System.Drawing.Size(47, 17)
        Me.rbfinal.TabIndex = 9
        Me.rbfinal.TabStop = True
        Me.rbfinal.Text = "Final"
        Me.rbfinal.UseVisualStyleBackColor = True
        '
        'rbparcial
        '
        Me.rbparcial.AutoSize = True
        Me.rbparcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbparcial.Location = New System.Drawing.Point(7, 14)
        Me.rbparcial.Name = "rbparcial"
        Me.rbparcial.Size = New System.Drawing.Size(57, 17)
        Me.rbparcial.TabIndex = 8
        Me.rbparcial.Text = "Parcial"
        Me.rbparcial.UseVisualStyleBackColor = True
        '
        'txtnumerobultos
        '
        Me.txtnumerobultos.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtnumerobultos.Location = New System.Drawing.Point(450, 27)
        Me.txtnumerobultos.Name = "txtnumerobultos"
        Me.txtnumerobultos.Size = New System.Drawing.Size(98, 22)
        Me.txtnumerobultos.TabIndex = 7
        Me.txtnumerobultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumeroProtocolo
        '
        Me.txtnumeroProtocolo.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtnumeroProtocolo.Location = New System.Drawing.Point(179, 27)
        Me.txtnumeroProtocolo.Name = "txtnumeroProtocolo"
        Me.txtnumeroProtocolo.Size = New System.Drawing.Size(113, 22)
        Me.txtnumeroProtocolo.TabIndex = 4
        Me.txtnumeroProtocolo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(449, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Numero  Bultos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(178, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Numero de Protocolo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.lblArticulodescripcion)
        Me.GroupBox3.Controls.Add(Me.txtarticulo)
        Me.GroupBox3.Controls.Add(Me.lnkArticulo)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(560, 138)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtStock)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.cmbUnidad)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 30)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(539, 47)
        Me.GroupBox6.TabIndex = 110
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Detalles del Articulo"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.LightGray
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtStock.Location = New System.Drawing.Point(328, 17)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(96, 20)
        Me.txtStock.TabIndex = 22
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unid. Med"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(205, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Stock Total Producto"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtStockLote)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.cmbLote)
        Me.GroupBox5.Controls.Add(Me.btnNuevoLote)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.lblFechaVencimiento)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 81)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(539, 50)
        Me.GroupBox5.TabIndex = 109
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "&Detalle Lotes"
        '
        'txtStockLote
        '
        Me.txtStockLote.BackColor = System.Drawing.Color.LightGray
        Me.txtStockLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockLote.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtStockLote.ForeColor = System.Drawing.Color.Red
        Me.txtStockLote.Location = New System.Drawing.Point(461, 15)
        Me.txtStockLote.Name = "txtStockLote"
        Me.txtStockLote.ReadOnly = True
        Me.txtStockLote.Size = New System.Drawing.Size(70, 22)
        Me.txtStockLote.TabIndex = 26
        Me.txtStockLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(392, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Stock Lote"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "&Lotes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(199, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Fecha Vencimiento"
        Me.Label3.Visible = False
        '
        'lblFechaVencimiento
        '
        Me.lblFechaVencimiento.AutoSize = True
        Me.lblFechaVencimiento.Location = New System.Drawing.Point(307, 22)
        Me.lblFechaVencimiento.Name = "lblFechaVencimiento"
        Me.lblFechaVencimiento.Size = New System.Drawing.Size(10, 13)
        Me.lblFechaVencimiento.TabIndex = 46
        Me.lblFechaVencimiento.Text = "."
        Me.lblFechaVencimiento.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(113, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'lblArticulodescripcion
        '
        Me.lblArticulodescripcion.BackColor = System.Drawing.Color.White
        Me.lblArticulodescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArticulodescripcion.Location = New System.Drawing.Point(136, 9)
        Me.lblArticulodescripcion.Multiline = True
        Me.lblArticulodescripcion.Name = "lblArticulodescripcion"
        Me.lblArticulodescripcion.ReadOnly = True
        Me.lblArticulodescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.lblArticulodescripcion.Size = New System.Drawing.Size(412, 20)
        Me.lblArticulodescripcion.TabIndex = 104
        '
        'SalirBultos
        '
        Me.SalirBultos.FlatAppearance.BorderSize = 0
        Me.SalirBultos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalirBultos.Image = CType(resources.GetObject("SalirBultos.Image"), System.Drawing.Image)
        Me.SalirBultos.Location = New System.Drawing.Point(56, 14)
        Me.SalirBultos.Name = "SalirBultos"
        Me.SalirBultos.Size = New System.Drawing.Size(44, 32)
        Me.SalirBultos.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.SalirBultos, "Regresar")
        Me.SalirBultos.UseVisualStyleBackColor = True
        '
        'btnAceptarBultos
        '
        Me.btnAceptarBultos.FlatAppearance.BorderSize = 0
        Me.btnAceptarBultos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarBultos.Image = CType(resources.GetObject("btnAceptarBultos.Image"), System.Drawing.Image)
        Me.btnAceptarBultos.Location = New System.Drawing.Point(6, 12)
        Me.btnAceptarBultos.Name = "btnAceptarBultos"
        Me.btnAceptarBultos.Size = New System.Drawing.Size(44, 34)
        Me.btnAceptarBultos.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btnAceptarBultos, "Aceptar")
        Me.btnAceptarBultos.UseVisualStyleBackColor = True
        '
        'gbBultos
        '
        Me.gbBultos.Controls.Add(Me.dgvDetallesBulto)
        Me.gbBultos.Controls.Add(Me.txtCantidadAsiganda)
        Me.gbBultos.Controls.Add(Me.Label8)
        Me.gbBultos.Controls.Add(Me.btnAceptarBultos)
        Me.gbBultos.Controls.Add(Me.SalirBultos)
        Me.gbBultos.Location = New System.Drawing.Point(598, 2)
        Me.gbBultos.Name = "gbBultos"
        Me.gbBultos.Size = New System.Drawing.Size(349, 287)
        Me.gbBultos.TabIndex = 46
        Me.gbBultos.TabStop = False
        Me.gbBultos.Text = "Detalles de Bultos"
        '
        'dgvDetallesBulto
        '
        Me.dgvDetallesBulto.AllowUserToAddRows = False
        Me.dgvDetallesBulto.AllowUserToDeleteRows = False
        Me.dgvDetallesBulto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallesBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.dgvDetallesBulto.Location = New System.Drawing.Point(6, 52)
        Me.dgvDetallesBulto.Name = "dgvDetallesBulto"
        Me.dgvDetallesBulto.Size = New System.Drawing.Size(332, 188)
        Me.dgvDetallesBulto.TabIndex = 106
        '
        'Column4
        '
        Me.Column4.HeaderText = "Item"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cantidad"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column6.HeaderText = "Cantidad_Asignada"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'txtCantidadAsiganda
        '
        Me.txtCantidadAsiganda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadAsiganda.Location = New System.Drawing.Point(268, 247)
        Me.txtCantidadAsiganda.Name = "txtCantidadAsiganda"
        Me.txtCantidadAsiganda.ReadOnly = True
        Me.txtCantidadAsiganda.Size = New System.Drawing.Size(70, 20)
        Me.txtCantidadAsiganda.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total Cantidad Asignada  por Bulto"
        '
        'frmLineaNotaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(595, 290)
        Me.Controls.Add(Me.gbBultos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLineaNotaPedido"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmLineaNotaPedido"
        Me.Panel1.ResumeLayout(False)
        CType(Me.bsUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBultos.ResumeLayout(False)
        Me.gbBultos.PerformLayout()
        CType(Me.dgvDetallesBulto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents cmbUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As LibControlUser.TextNumeric
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As LibControlUser.TextNumeric
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bsUnidad As System.Windows.Forms.BindingSource
    Friend WithEvents errores As System.Windows.Forms.ErrorProvider
    Friend WithEvents lnkArticulo As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbLote As System.Windows.Forms.ComboBox
    Friend WithEvents bsLote As System.Windows.Forms.BindingSource
    Friend WithEvents txtarticulo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnNuevoLote As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbfinal As System.Windows.Forms.RadioButton
    Friend WithEvents rbparcial As System.Windows.Forms.RadioButton
    Friend WithEvents txtnumeroProtocolo As System.Windows.Forms.TextBox
    Friend WithEvents txtnumerobultos As System.Windows.Forms.TextBox
    Friend WithEvents lblArticulodescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents gbBultos As System.Windows.Forms.GroupBox
    Friend WithEvents SalirBultos As System.Windows.Forms.Button
    Friend WithEvents btnAceptarBultos As System.Windows.Forms.Button
    Friend WithEvents txtCantidadAsiganda As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvDetallesBulto As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStockLote As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
