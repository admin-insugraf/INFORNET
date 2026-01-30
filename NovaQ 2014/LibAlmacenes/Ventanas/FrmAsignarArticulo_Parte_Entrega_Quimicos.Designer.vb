<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarArticulo_Parte_Entrega_Quimicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarArticulo_Parte_Entrega_Quimicos))
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtp_f_vcto = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_numero_lote = New System.Windows.Forms.TextBox()
        Me.txt_total_conversion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_Saldo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_des_prod_presentacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_cod_prod_presentacion = New System.Windows.Forms.TextBox()
        Me.txt_obs_presentacion = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txt_cantidad_presentacion = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.dgv_incripciones_regsanit = New System.Windows.Forms.DataGridView()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_numero_op = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtstockanalisis = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbonumanalisis = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtpais_origen = New System.Windows.Forms.TextBox()
        Me.txtprocedencia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtnumerobultos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rbfinal = New System.Windows.Forms.RadioButton()
        Me.rbparcial = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnumeroProtocolo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnNuevoLote = New System.Windows.Forms.Button()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtStockLote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboLotes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtp_f_fab = New System.Windows.Forms.DateTimePicker()
        Me.ToolOpc.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_incripciones_regsanit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolOpc
        '
        Me.ToolOpc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.ToolStripButton1})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(584, 25)
        Me.ToolOpc.TabIndex = 52
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 22)
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.ToolTipText = "Aceptar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton1.Text = "Cancelar"
        Me.ToolStripButton1.ToolTipText = "Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.dtp_f_fab)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.dtp_f_vcto)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txt_numero_lote)
        Me.GroupBox2.Controls.Add(Me.txt_total_conversion)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txt_Saldo)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.GroupBox9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_numero_op)
        Me.GroupBox2.Controls.Add(Me.GroupBox8)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 579)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(390, 156)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 13)
        Me.Label21.TabIndex = 225
        Me.Label21.Text = "F. Vcto."
        '
        'dtp_f_vcto
        '
        Me.dtp_f_vcto.Checked = False
        Me.dtp_f_vcto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_f_vcto.Location = New System.Drawing.Point(440, 152)
        Me.dtp_f_vcto.Name = "dtp_f_vcto"
        Me.dtp_f_vcto.ShowCheckBox = True
        Me.dtp_f_vcto.Size = New System.Drawing.Size(112, 20)
        Me.dtp_f_vcto.TabIndex = 224
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(20, 156)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 223
        Me.Label20.Text = "N° Lote"
        '
        'txt_numero_lote
        '
        Me.txt_numero_lote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_lote.ForeColor = System.Drawing.Color.Black
        Me.txt_numero_lote.Location = New System.Drawing.Point(75, 152)
        Me.txt_numero_lote.MaxLength = 20
        Me.txt_numero_lote.Name = "txt_numero_lote"
        Me.txt_numero_lote.Size = New System.Drawing.Size(131, 20)
        Me.txt_numero_lote.TabIndex = 222
        '
        'txt_total_conversion
        '
        Me.txt_total_conversion.BackColor = System.Drawing.Color.White
        Me.txt_total_conversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_conversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_total_conversion.Location = New System.Drawing.Point(254, 548)
        Me.txt_total_conversion.Name = "txt_total_conversion"
        Me.txt_total_conversion.ReadOnly = True
        Me.txt_total_conversion.Size = New System.Drawing.Size(106, 20)
        Me.txt_total_conversion.TabIndex = 200
        Me.txt_total_conversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(160, 552)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 13)
        Me.Label19.TabIndex = 201
        Me.Label19.Text = "Total Conversión"
        '
        'txt_Saldo
        '
        Me.txt_Saldo.BackColor = System.Drawing.Color.White
        Me.txt_Saldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_Saldo.Location = New System.Drawing.Point(441, 548)
        Me.txt_Saldo.Name = "txt_Saldo"
        Me.txt_Saldo.ReadOnly = True
        Me.txt_Saldo.Size = New System.Drawing.Size(106, 20)
        Me.txt_Saldo.TabIndex = 198
        Me.txt_Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(396, 552)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 199
        Me.Label17.Text = "Saldo"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.PictureBox2)
        Me.GroupBox9.Controls.Add(Me.txt_des_prod_presentacion)
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.txt_cod_prod_presentacion)
        Me.GroupBox9.Controls.Add(Me.txt_obs_presentacion)
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.Label47)
        Me.GroupBox9.Controls.Add(Me.txt_cantidad_presentacion)
        Me.GroupBox9.Controls.Add(Me.btn_add)
        Me.GroupBox9.Controls.Add(Me.btn_del)
        Me.GroupBox9.Controls.Add(Me.dgv_incripciones_regsanit)
        Me.GroupBox9.Controls.Add(Me.Label44)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 183)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(550, 353)
        Me.GroupBox9.TabIndex = 197
        Me.GroupBox9.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(155, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 227
        Me.PictureBox2.TabStop = False
        '
        'txt_des_prod_presentacion
        '
        Me.txt_des_prod_presentacion.BackColor = System.Drawing.Color.White
        Me.txt_des_prod_presentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_prod_presentacion.Location = New System.Drawing.Point(180, 35)
        Me.txt_des_prod_presentacion.Name = "txt_des_prod_presentacion"
        Me.txt_des_prod_presentacion.ReadOnly = True
        Me.txt_des_prod_presentacion.Size = New System.Drawing.Size(367, 20)
        Me.txt_des_prod_presentacion.TabIndex = 225
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(21, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 224
        Me.Label14.Text = "Articulo"
        '
        'txt_cod_prod_presentacion
        '
        Me.txt_cod_prod_presentacion.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_prod_presentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_prod_presentacion.Location = New System.Drawing.Point(68, 35)
        Me.txt_cod_prod_presentacion.Name = "txt_cod_prod_presentacion"
        Me.txt_cod_prod_presentacion.ReadOnly = True
        Me.txt_cod_prod_presentacion.Size = New System.Drawing.Size(76, 20)
        Me.txt_cod_prod_presentacion.TabIndex = 226
        '
        'txt_obs_presentacion
        '
        Me.txt_obs_presentacion.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_obs_presentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs_presentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_obs_presentacion.Location = New System.Drawing.Point(68, 94)
        Me.txt_obs_presentacion.Name = "txt_obs_presentacion"
        Me.txt_obs_presentacion.Size = New System.Drawing.Size(472, 20)
        Me.txt_obs_presentacion.TabIndex = 222
        Me.txt_obs_presentacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(34, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 223
        Me.Label16.Text = "Obs."
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(14, 69)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(49, 13)
        Me.Label47.TabIndex = 221
        Me.Label47.Text = "Cantidad"
        '
        'txt_cantidad_presentacion
        '
        Me.txt_cantidad_presentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad_presentacion.ForeColor = System.Drawing.Color.Black
        Me.txt_cantidad_presentacion.Location = New System.Drawing.Point(68, 65)
        Me.txt_cantidad_presentacion.MaxLength = 20
        Me.txt_cantidad_presentacion.Name = "txt_cantidad_presentacion"
        Me.txt_cantidad_presentacion.Size = New System.Drawing.Size(106, 20)
        Me.txt_cantidad_presentacion.TabIndex = 216
        '
        'btn_add
        '
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.Color.Navy
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(397, 64)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(68, 23)
        Me.btn_add.TabIndex = 49
        Me.btn_add.Text = "Agregar"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.ForeColor = System.Drawing.Color.Navy
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(469, 64)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(68, 23)
        Me.btn_del.TabIndex = 48
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'dgv_incripciones_regsanit
        '
        Me.dgv_incripciones_regsanit.AllowUserToAddRows = False
        Me.dgv_incripciones_regsanit.AllowUserToDeleteRows = False
        Me.dgv_incripciones_regsanit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_incripciones_regsanit.Location = New System.Drawing.Point(7, 121)
        Me.dgv_incripciones_regsanit.Name = "dgv_incripciones_regsanit"
        Me.dgv_incripciones_regsanit.ReadOnly = True
        Me.dgv_incripciones_regsanit.Size = New System.Drawing.Size(533, 204)
        Me.dgv_incripciones_regsanit.TabIndex = 47
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Navy
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(-3, 7)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(557, 19)
        Me.Label44.TabIndex = 36
        Me.Label44.Text = " Detalle de presentaciones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(20, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "N° O.P."
        '
        'txt_numero_op
        '
        Me.txt_numero_op.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_numero_op.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_op.Location = New System.Drawing.Point(69, 20)
        Me.txt_numero_op.Name = "txt_numero_op"
        Me.txt_numero_op.ReadOnly = True
        Me.txt_numero_op.Size = New System.Drawing.Size(113, 20)
        Me.txt_numero_op.TabIndex = 1
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtstockanalisis)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.cbonumanalisis)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(8, 434)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(550, 45)
        Me.GroupBox8.TabIndex = 32
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Detalle N° Análisis"
        Me.GroupBox8.Visible = False
        '
        'txtstockanalisis
        '
        Me.txtstockanalisis.BackColor = System.Drawing.Color.White
        Me.txtstockanalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstockanalisis.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtstockanalisis.ForeColor = System.Drawing.Color.Red
        Me.txtstockanalisis.Location = New System.Drawing.Point(310, 12)
        Me.txtstockanalisis.Name = "txtstockanalisis"
        Me.txtstockanalisis.ReadOnly = True
        Me.txtstockanalisis.Size = New System.Drawing.Size(96, 22)
        Me.txtstockanalisis.TabIndex = 26
        Me.txtstockanalisis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(236, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Stock Análisis"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(7, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "N° Análisis"
        '
        'cbonumanalisis
        '
        Me.cbonumanalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbonumanalisis.FormattingEnabled = True
        Me.cbonumanalisis.Location = New System.Drawing.Point(70, 13)
        Me.cbonumanalisis.Name = "cbonumanalisis"
        Me.cbonumanalisis.Size = New System.Drawing.Size(160, 21)
        Me.cbonumanalisis.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtpais_origen)
        Me.GroupBox3.Controls.Add(Me.txtprocedencia)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(8, 360)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(552, 65)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Adicionales"
        Me.GroupBox3.Visible = False
        '
        'txtpais_origen
        '
        Me.txtpais_origen.BackColor = System.Drawing.Color.White
        Me.txtpais_origen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpais_origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtpais_origen.Location = New System.Drawing.Point(90, 40)
        Me.txtpais_origen.MaxLength = 200
        Me.txtpais_origen.Name = "txtpais_origen"
        Me.txtpais_origen.Size = New System.Drawing.Size(456, 20)
        Me.txtpais_origen.TabIndex = 22
        Me.txtpais_origen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtprocedencia
        '
        Me.txtprocedencia.BackColor = System.Drawing.Color.White
        Me.txtprocedencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprocedencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtprocedencia.Location = New System.Drawing.Point(90, 15)
        Me.txtprocedencia.MaxLength = 200
        Me.txtprocedencia.Name = "txtprocedencia"
        Me.txtprocedencia.Size = New System.Drawing.Size(456, 20)
        Me.txtprocedencia.TabIndex = 21
        Me.txtprocedencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Procedencia"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(8, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Pais Origen"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtmonto)
        Me.GroupBox6.Controls.Add(Me.txtnumerobultos)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txtnumeroProtocolo)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 222)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(550, 83)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Visible = False
        '
        'txtmonto
        '
        Me.txtmonto.BackColor = System.Drawing.Color.White
        Me.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonto.Enabled = False
        Me.txtmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtmonto.Location = New System.Drawing.Point(299, 110)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(65, 20)
        Me.txtmonto.TabIndex = 60
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtmonto.Visible = False
        '
        'txtnumerobultos
        '
        Me.txtnumerobultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumerobultos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtnumerobultos.Location = New System.Drawing.Point(448, 110)
        Me.txtnumerobultos.Name = "txtnumerobultos"
        Me.txtnumerobultos.Size = New System.Drawing.Size(98, 20)
        Me.txtnumerobultos.TabIndex = 6
        Me.txtnumerobultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnumerobultos.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(445, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Numero  Bultos"
        Me.Label6.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rbfinal)
        Me.GroupBox7.Controls.Add(Me.rbparcial)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(10, 94)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(164, 36)
        Me.GroupBox7.TabIndex = 48
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Tipo de entrega."
        Me.GroupBox7.Visible = False
        '
        'rbfinal
        '
        Me.rbfinal.AutoSize = True
        Me.rbfinal.Checked = True
        Me.rbfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbfinal.ForeColor = System.Drawing.Color.Navy
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
        Me.rbparcial.ForeColor = System.Drawing.Color.Navy
        Me.rbparcial.Location = New System.Drawing.Point(7, 14)
        Me.rbparcial.Name = "rbparcial"
        Me.rbparcial.Size = New System.Drawing.Size(57, 17)
        Me.rbparcial.TabIndex = 8
        Me.rbparcial.Text = "Parcial"
        Me.rbparcial.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(179, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Numero de Protocolo"
        Me.Label7.Visible = False
        '
        'txtnumeroProtocolo
        '
        Me.txtnumeroProtocolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumeroProtocolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtnumeroProtocolo.Location = New System.Drawing.Point(181, 110)
        Me.txtnumeroProtocolo.Name = "txtnumeroProtocolo"
        Me.txtnumeroProtocolo.Size = New System.Drawing.Size(113, 20)
        Me.txtnumeroProtocolo.TabIndex = 3
        Me.txtnumeroProtocolo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnumeroProtocolo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(302, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Costo Unit."
        Me.Label8.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtcantidad)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtStock)
        Me.GroupBox5.Controls.Add(Me.txtunidadMedida)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(8, 101)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(550, 41)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles del Articulo"
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.White
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtcantidad.Location = New System.Drawing.Point(213, 13)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.ReadOnly = True
        Me.txtcantidad.Size = New System.Drawing.Size(106, 20)
        Me.txtcantidad.TabIndex = 56
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(152, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Cantidad"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.White
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtStock.Location = New System.Drawing.Point(442, 13)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(96, 20)
        Me.txtStock.TabIndex = 22
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtunidadMedida
        '
        Me.txtunidadMedida.BackColor = System.Drawing.Color.White
        Me.txtunidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedida.Location = New System.Drawing.Point(67, 13)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.ReadOnly = True
        Me.txtunidadMedida.Size = New System.Drawing.Size(75, 20)
        Me.txtunidadMedida.TabIndex = 21
        Me.txtunidadMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unid. Med"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(323, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Stock Total Producto"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnNuevoLote)
        Me.GroupBox4.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox4.Controls.Add(Me.txtStockLote)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cboLotes)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(8, 387)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(550, 45)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "&Detalle Lotes"
        Me.GroupBox4.Visible = False
        '
        'btnNuevoLote
        '
        Me.btnNuevoLote.Enabled = False
        Me.btnNuevoLote.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoLote.ForeColor = System.Drawing.Color.Maroon
        Me.btnNuevoLote.Location = New System.Drawing.Point(162, 9)
        Me.btnNuevoLote.Name = "btnNuevoLote"
        Me.btnNuevoLote.Size = New System.Drawing.Size(36, 32)
        Me.btnNuevoLote.TabIndex = 47
        Me.btnNuevoLote.Text = "+"
        Me.btnNuevoLote.UseVisualStyleBackColor = True
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(307, 14)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaVencimiento.TabIndex = 25
        '
        'txtStockLote
        '
        Me.txtStockLote.BackColor = System.Drawing.Color.White
        Me.txtStockLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockLote.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtStockLote.ForeColor = System.Drawing.Color.Red
        Me.txtStockLote.Location = New System.Drawing.Point(470, 14)
        Me.txtStockLote.Name = "txtStockLote"
        Me.txtStockLote.ReadOnly = True
        Me.txtStockLote.Size = New System.Drawing.Size(70, 22)
        Me.txtStockLote.TabIndex = 26
        Me.txtStockLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(407, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Stock Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(200, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Vencimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(7, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Lotes"
        '
        'cboLotes
        '
        Me.cboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLotes.FormattingEnabled = True
        Me.cboLotes.Location = New System.Drawing.Point(48, 14)
        Me.cboLotes.Name = "cboLotes"
        Me.cboLotes.Size = New System.Drawing.Size(106, 21)
        Me.cboLotes.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(147, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(172, 14)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(367, 20)
        Me.txtdescripcionArticulo.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(13, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Articulo"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(61, 14)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.ReadOnly = True
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(76, 20)
        Me.txtcodigoArticulo.TabIndex = 33
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(218, 156)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 227
        Me.Label22.Text = "F. Fab."
        '
        'dtp_f_fab
        '
        Me.dtp_f_fab.Checked = False
        Me.dtp_f_fab.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_f_fab.Location = New System.Drawing.Point(268, 152)
        Me.dtp_f_fab.Name = "dtp_f_fab"
        Me.dtp_f_fab.ShowCheckBox = True
        Me.dtp_f_fab.Size = New System.Drawing.Size(112, 20)
        Me.dtp_f_fab.TabIndex = 226
        '
        'FrmAsignarArticulo_Parte_Entrega_Quimicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 628)
        Me.Controls.Add(Me.ToolOpc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignarArticulo_Parte_Entrega_Quimicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulo parte de entrega - Detallado"
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_incripciones_regsanit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_op As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtstockanalisis As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbonumanalisis As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpais_origen As System.Windows.Forms.TextBox
    Friend WithEvents txtprocedencia As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtunidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevoLote As System.Windows.Forms.Button
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtStockLote As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboLotes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_obs_presentacion As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_presentacion As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents dgv_incripciones_regsanit As System.Windows.Forms.DataGridView
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_des_prod_presentacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_prod_presentacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents txtnumerobultos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rbfinal As System.Windows.Forms.RadioButton
    Friend WithEvents rbparcial As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnumeroProtocolo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Saldo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_total_conversion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_lote As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtp_f_vcto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtp_f_fab As System.Windows.Forms.DateTimePicker
End Class
