<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControl_Liberacion_Modificar_Prod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControl_Liberacion_Modificar_Prod))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbcomentario = New System.Windows.Forms.GroupBox()
        Me.txtcomentarios = New System.Windows.Forms.RichTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtnumanalisis = New System.Windows.Forms.TextBox()
        Me.txtvaloracion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtnumerobultos = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rbfinal = New System.Windows.Forms.RadioButton()
        Me.rbparcial = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnumeroProtocolo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtlote = New System.Windows.Forms.TextBox()
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
        Me.gbBultos = New System.Windows.Forms.GroupBox()
        Me.dgvDetallesBulto = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCantidadAsiganda = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAceptarBultos = New System.Windows.Forms.Button()
        Me.SalirBultos = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2.SuspendLayout()
        Me.gbcomentario.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBultos.SuspendLayout()
        CType(Me.dgvDetallesBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.gbcomentario)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 238)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'gbcomentario
        '
        Me.gbcomentario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbcomentario.Controls.Add(Me.txtcomentarios)
        Me.gbcomentario.Controls.Add(Me.TextBox3)
        Me.gbcomentario.Controls.Add(Me.GroupBox8)
        Me.gbcomentario.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbcomentario.ForeColor = System.Drawing.Color.Navy
        Me.gbcomentario.Location = New System.Drawing.Point(3, 170)
        Me.gbcomentario.Name = "gbcomentario"
        Me.gbcomentario.Size = New System.Drawing.Size(552, 55)
        Me.gbcomentario.TabIndex = 31
        Me.gbcomentario.TabStop = False
        Me.gbcomentario.Text = "&Comentarios Observaciones"
        '
        'txtcomentarios
        '
        Me.txtcomentarios.BackColor = System.Drawing.Color.White
        Me.txtcomentarios.Location = New System.Drawing.Point(11, 18)
        Me.txtcomentarios.MaxLength = 255
        Me.txtcomentarios.Name = "txtcomentarios"
        Me.txtcomentarios.Size = New System.Drawing.Size(531, 28)
        Me.txtcomentarios.TabIndex = 61
        Me.txtcomentarios.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(134, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(65, 22)
        Me.TextBox3.TabIndex = 60
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.RadioButton1)
        Me.GroupBox8.Controls.Add(Me.RadioButton2)
        Me.GroupBox8.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.Location = New System.Drawing.Point(10, 70)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(164, 36)
        Me.GroupBox8.TabIndex = 48
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Tipo de entrega."
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(106, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Final"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(7, 14)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "Parcial"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox6.Controls.Add(Me.txtnumanalisis)
        Me.GroupBox6.Controls.Add(Me.txtvaloracion)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.txtmonto)
        Me.GroupBox6.Controls.Add(Me.txtnumerobultos)
        Me.GroupBox6.Controls.Add(Me.txtcantidad)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txtnumeroProtocolo)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 108)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(552, 58)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'txtnumanalisis
        '
        Me.txtnumanalisis.BackColor = System.Drawing.Color.White
        Me.txtnumanalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumanalisis.Enabled = False
        Me.txtnumanalisis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumanalisis.Location = New System.Drawing.Point(135, 26)
        Me.txtnumanalisis.Name = "txtnumanalisis"
        Me.txtnumanalisis.Size = New System.Drawing.Size(93, 21)
        Me.txtnumanalisis.TabIndex = 63
        Me.txtnumanalisis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtvaloracion
        '
        Me.txtvaloracion.BackColor = System.Drawing.Color.White
        Me.txtvaloracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvaloracion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvaloracion.Location = New System.Drawing.Point(416, 27)
        Me.txtvaloracion.Name = "txtvaloracion"
        Me.txtvaloracion.Size = New System.Drawing.Size(130, 21)
        Me.txtvaloracion.TabIndex = 61
        Me.txtvaloracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(413, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 16)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Porcentaje de Valoración"
        '
        'txtmonto
        '
        Me.txtmonto.BackColor = System.Drawing.Color.White
        Me.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonto.Enabled = False
        Me.txtmonto.Location = New System.Drawing.Point(134, 64)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(65, 22)
        Me.txtmonto.TabIndex = 60
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumerobultos
        '
        Me.txtnumerobultos.BackColor = System.Drawing.Color.White
        Me.txtnumerobultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumerobultos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumerobultos.Location = New System.Drawing.Point(317, 27)
        Me.txtnumerobultos.Name = "txtnumerobultos"
        Me.txtnumerobultos.Size = New System.Drawing.Size(93, 21)
        Me.txtnumerobultos.TabIndex = 6
        Me.txtnumerobultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.White
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(234, 26)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(76, 21)
        Me.txtcantidad.TabIndex = 5
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(314, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Numero  Bultos"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rbfinal)
        Me.GroupBox7.Controls.Add(Me.rbparcial)
        Me.GroupBox7.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 70)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(164, 36)
        Me.GroupBox7.TabIndex = 48
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Tipo de entrega."
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(14, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Numero de Protocolo"
        '
        'txtnumeroProtocolo
        '
        Me.txtnumeroProtocolo.BackColor = System.Drawing.Color.White
        Me.txtnumeroProtocolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumeroProtocolo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroProtocolo.Location = New System.Drawing.Point(16, 27)
        Me.txtnumeroProtocolo.Name = "txtnumeroProtocolo"
        Me.txtnumeroProtocolo.Size = New System.Drawing.Size(113, 21)
        Me.txtnumeroProtocolo.TabIndex = 3
        Me.txtnumeroProtocolo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(233, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(137, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Num. Análisis"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtStock)
        Me.GroupBox5.Controls.Add(Me.txtunidadMedida)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(5, 59)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(142, 44)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles del Articulo"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.LightGray
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtStock.Location = New System.Drawing.Point(677, 14)
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
        Me.txtunidadMedida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunidadMedida.Location = New System.Drawing.Point(67, 15)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.ReadOnly = True
        Me.txtunidadMedida.Size = New System.Drawing.Size(71, 21)
        Me.txtunidadMedida.TabIndex = 21
        Me.txtunidadMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unid. Med"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(558, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Stock Total Producto"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Me.txtlote)
        Me.GroupBox4.Controls.Add(Me.btnNuevoLote)
        Me.GroupBox4.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox4.Controls.Add(Me.txtStockLote)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cboLotes)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(151, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(406, 45)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "&Detalle Lotes"
        '
        'txtlote
        '
        Me.txtlote.BackColor = System.Drawing.Color.White
        Me.txtlote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlote.Location = New System.Drawing.Point(46, 14)
        Me.txtlote.Name = "txtlote"
        Me.txtlote.ReadOnly = True
        Me.txtlote.Size = New System.Drawing.Size(106, 21)
        Me.txtlote.TabIndex = 48
        Me.txtlote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNuevoLote
        '
        Me.btnNuevoLote.Enabled = False
        Me.btnNuevoLote.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoLote.ForeColor = System.Drawing.Color.Maroon
        Me.btnNuevoLote.Location = New System.Drawing.Point(162, 44)
        Me.btnNuevoLote.Name = "btnNuevoLote"
        Me.btnNuevoLote.Size = New System.Drawing.Size(36, 32)
        Me.btnNuevoLote.TabIndex = 47
        Me.btnNuevoLote.Text = "+"
        Me.btnNuevoLote.UseVisualStyleBackColor = True
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.CustomFormat = "MMMM-yyyy"
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(264, 15)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(131, 20)
        Me.dtpFechaVencimiento.TabIndex = 25
        '
        'txtStockLote
        '
        Me.txtStockLote.BackColor = System.Drawing.Color.LightGray
        Me.txtStockLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockLote.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtStockLote.ForeColor = System.Drawing.Color.Red
        Me.txtStockLote.Location = New System.Drawing.Point(631, 14)
        Me.txtStockLote.Name = "txtStockLote"
        Me.txtStockLote.ReadOnly = True
        Me.txtStockLote.Size = New System.Drawing.Size(70, 22)
        Me.txtStockLote.TabIndex = 26
        Me.txtStockLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(568, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Stock Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(156, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Vencimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(7, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Lotes"
        '
        'cboLotes
        '
        Me.cboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLotes.FormattingEnabled = True
        Me.cboLotes.Location = New System.Drawing.Point(48, 50)
        Me.cboLotes.Name = "cboLotes"
        Me.cboLotes.Size = New System.Drawing.Size(106, 21)
        Me.cboLotes.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(126, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(153, 14)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(386, 21)
        Me.txtdescripcionArticulo.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(13, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Articulo"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(61, 14)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(59, 21)
        Me.txtcodigoArticulo.TabIndex = 1
        '
        'gbBultos
        '
        Me.gbBultos.BackColor = System.Drawing.Color.Silver
        Me.gbBultos.Controls.Add(Me.dgvDetallesBulto)
        Me.gbBultos.Controls.Add(Me.txtCantidadAsiganda)
        Me.gbBultos.Controls.Add(Me.Label10)
        Me.gbBultos.Controls.Add(Me.btnAceptarBultos)
        Me.gbBultos.Controls.Add(Me.SalirBultos)
        Me.gbBultos.Location = New System.Drawing.Point(586, 12)
        Me.gbBultos.Name = "gbBultos"
        Me.gbBultos.Size = New System.Drawing.Size(349, 284)
        Me.gbBultos.TabIndex = 48
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total Cantidad Asignada  por Bulto"
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
        Me.btnAceptarBultos.UseVisualStyleBackColor = True
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
        Me.SalirBultos.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(583, 25)
        Me.ToolStrip1.TabIndex = 182
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 22)
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 22)
        Me.btn_salir.Text = "&cancelar"
        '
        'FrmControl_Liberacion_Modificar_Prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(583, 271)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbBultos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmControl_Liberacion_Modificar_Prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Actualización de Datos"
        Me.GroupBox2.ResumeLayout(False)
        Me.gbcomentario.ResumeLayout(False)
        Me.gbcomentario.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
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
        Me.gbBultos.ResumeLayout(False)
        Me.gbBultos.PerformLayout()
        CType(Me.dgvDetallesBulto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents txtnumerobultos As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rbfinal As System.Windows.Forms.RadioButton
    Friend WithEvents rbparcial As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnumeroProtocolo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
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
    Friend WithEvents gbBultos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetallesBulto As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCantidadAsiganda As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAceptarBultos As System.Windows.Forms.Button
    Friend WithEvents SalirBultos As System.Windows.Forms.Button
    Friend WithEvents txtvaloracion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtlote As System.Windows.Forms.TextBox
    Friend WithEvents txtnumanalisis As System.Windows.Forms.TextBox
    Friend WithEvents gbcomentario As System.Windows.Forms.GroupBox
    Friend WithEvents txtcomentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
