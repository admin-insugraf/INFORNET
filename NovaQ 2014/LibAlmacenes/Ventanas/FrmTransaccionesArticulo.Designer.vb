<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransaccionesArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransaccionesArticulo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboTipoMov = New System.Windows.Forms.ComboBox()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbdetallearticulo = New System.Windows.Forms.GroupBox()
        Me.checkArticulo = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GbArticulos = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionArticulofinal = New System.Windows.Forms.TextBox()
        Me.txtdescripcionArticuloInicial = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFinArticulo = New System.Windows.Forms.TextBox()
        Me.txtinicioArticulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.gbdetallemov = New System.Windows.Forms.GroupBox()
        Me.GbMovimiento = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionfinMov = New System.Windows.Forms.TextBox()
        Me.txtDescripcionInicioMov = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFinMov = New System.Windows.Forms.TextBox()
        Me.txtInicioMov = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.rdb_Resumido = New System.Windows.Forms.RadioButton()
        Me.rdb_Detallado = New System.Windows.Forms.RadioButton()
        Me.chkMovimientos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbdetallearticulo.SuspendLayout()
        Me.GbArticulos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdetallemov.SuspendLayout()
        Me.GbMovimiento.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.rdb_Detallado)
        Me.GroupBox1.Controls.Add(Me.rdb_Resumido)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.gbdetallearticulo)
        Me.GroupBox1.Controls.Add(Me.gbdetallemov)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 418)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(185, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "TRANSACCIONES POR ARTICULO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboTipoMov)
        Me.GroupBox3.Controls.Add(Me.cboAlmacen)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cboMoneda)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(26, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(590, 78)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'cboTipoMov
        '
        Me.cboTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMov.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboTipoMov.FormattingEnabled = True
        Me.cboTipoMov.Items.AddRange(New Object() {"(SELECCIONE UN MOVIMIENTO)", "TODOS", "INGRESOS", "SALIDAS"})
        Me.cboTipoMov.Location = New System.Drawing.Point(356, 49)
        Me.cboTipoMov.Name = "cboTipoMov"
        Me.cboTipoMov.Size = New System.Drawing.Size(222, 24)
        Me.cboTipoMov.TabIndex = 2
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(356, 19)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(222, 24)
        Me.cboAlmacen.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(288, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "&Almacenes"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(70, 47)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(207, 24)
        Me.cboMoneda.TabIndex = 2
        Me.cboMoneda.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(288, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "T. Mov."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(4, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "&Mes y Año"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.CustomFormat = "MMMM -     yyyy"
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechaInicio.Location = New System.Drawing.Point(70, 19)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(207, 22)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(16, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "&Moneda"
        Me.Label8.Visible = False
        '
        'gbdetallearticulo
        '
        Me.gbdetallearticulo.Controls.Add(Me.checkArticulo)
        Me.gbdetallearticulo.Controls.Add(Me.ProgressBar1)
        Me.gbdetallearticulo.Controls.Add(Me.GbArticulos)
        Me.gbdetallearticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbdetallearticulo.ForeColor = System.Drawing.Color.Navy
        Me.gbdetallearticulo.Location = New System.Drawing.Point(26, 254)
        Me.gbdetallearticulo.Name = "gbdetallearticulo"
        Me.gbdetallearticulo.Size = New System.Drawing.Size(590, 126)
        Me.gbdetallearticulo.TabIndex = 1
        Me.gbdetallearticulo.TabStop = False
        Me.gbdetallearticulo.Text = "Detalle de Articulos "
        '
        'checkArticulo
        '
        Me.checkArticulo.AutoSize = True
        Me.checkArticulo.Checked = True
        Me.checkArticulo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkArticulo.Location = New System.Drawing.Point(12, 18)
        Me.checkArticulo.Name = "checkArticulo"
        Me.checkArticulo.Size = New System.Drawing.Size(115, 17)
        Me.checkArticulo.TabIndex = 5
        Me.checkArticulo.Text = "Todos los Articulos"
        Me.checkArticulo.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 103)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(575, 13)
        Me.ProgressBar1.TabIndex = 19
        Me.ProgressBar1.Visible = False
        '
        'GbArticulos
        '
        Me.GbArticulos.Controls.Add(Me.txtDescripcionArticulofinal)
        Me.GbArticulos.Controls.Add(Me.txtdescripcionArticuloInicial)
        Me.GbArticulos.Controls.Add(Me.PictureBox2)
        Me.GbArticulos.Controls.Add(Me.Label5)
        Me.GbArticulos.Controls.Add(Me.txtFinArticulo)
        Me.GbArticulos.Controls.Add(Me.txtinicioArticulo)
        Me.GbArticulos.Controls.Add(Me.Label4)
        Me.GbArticulos.Controls.Add(Me.PictureBox4)
        Me.GbArticulos.Enabled = False
        Me.GbArticulos.ForeColor = System.Drawing.Color.Navy
        Me.GbArticulos.Location = New System.Drawing.Point(7, 31)
        Me.GbArticulos.Name = "GbArticulos"
        Me.GbArticulos.Size = New System.Drawing.Size(574, 66)
        Me.GbArticulos.TabIndex = 18
        Me.GbArticulos.TabStop = False
        '
        'txtDescripcionArticulofinal
        '
        Me.txtDescripcionArticulofinal.BackColor = System.Drawing.Color.White
        Me.txtDescripcionArticulofinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionArticulofinal.Location = New System.Drawing.Point(170, 38)
        Me.txtDescripcionArticulofinal.Name = "txtDescripcionArticulofinal"
        Me.txtDescripcionArticulofinal.ReadOnly = True
        Me.txtDescripcionArticulofinal.Size = New System.Drawing.Size(398, 20)
        Me.txtDescripcionArticulofinal.TabIndex = 127
        '
        'txtdescripcionArticuloInicial
        '
        Me.txtdescripcionArticuloInicial.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticuloInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticuloInicial.Location = New System.Drawing.Point(170, 12)
        Me.txtdescripcionArticuloInicial.Name = "txtdescripcionArticuloInicial"
        Me.txtdescripcionArticuloInicial.ReadOnly = True
        Me.txtdescripcionArticuloInicial.Size = New System.Drawing.Size(398, 20)
        Me.txtdescripcionArticuloInicial.TabIndex = 123
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(152, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Articulo Inicial"
        '
        'txtFinArticulo
        '
        Me.txtFinArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFinArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinArticulo.Location = New System.Drawing.Point(81, 39)
        Me.txtFinArticulo.Name = "txtFinArticulo"
        Me.txtFinArticulo.ReadOnly = True
        Me.txtFinArticulo.Size = New System.Drawing.Size(69, 20)
        Me.txtFinArticulo.TabIndex = 126
        '
        'txtinicioArticulo
        '
        Me.txtinicioArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtinicioArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtinicioArticulo.Location = New System.Drawing.Point(81, 13)
        Me.txtinicioArticulo.Name = "txtinicioArticulo"
        Me.txtinicioArticulo.ReadOnly = True
        Me.txtinicioArticulo.Size = New System.Drawing.Size(69, 20)
        Me.txtinicioArticulo.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Articulo Final"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(152, 13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 124
        Me.PictureBox4.TabStop = False
        '
        'gbdetallemov
        '
        Me.gbdetallemov.Controls.Add(Me.chkMovimientos)
        Me.gbdetallemov.Controls.Add(Me.GbMovimiento)
        Me.gbdetallemov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbdetallemov.ForeColor = System.Drawing.Color.Navy
        Me.gbdetallemov.Location = New System.Drawing.Point(26, 134)
        Me.gbdetallemov.Name = "gbdetallemov"
        Me.gbdetallemov.Size = New System.Drawing.Size(590, 115)
        Me.gbdetallemov.TabIndex = 17
        Me.gbdetallemov.TabStop = False
        Me.gbdetallemov.Text = "Detalle de Movimientos"
        '
        'GbMovimiento
        '
        Me.GbMovimiento.Controls.Add(Me.txtDescripcionfinMov)
        Me.GbMovimiento.Controls.Add(Me.txtDescripcionInicioMov)
        Me.GbMovimiento.Controls.Add(Me.PictureBox3)
        Me.GbMovimiento.Controls.Add(Me.Label1)
        Me.GbMovimiento.Controls.Add(Me.txtFinMov)
        Me.GbMovimiento.Controls.Add(Me.txtInicioMov)
        Me.GbMovimiento.Controls.Add(Me.Label3)
        Me.GbMovimiento.Controls.Add(Me.PictureBox1)
        Me.GbMovimiento.ForeColor = System.Drawing.Color.Navy
        Me.GbMovimiento.Location = New System.Drawing.Point(7, 39)
        Me.GbMovimiento.Name = "GbMovimiento"
        Me.GbMovimiento.Size = New System.Drawing.Size(574, 66)
        Me.GbMovimiento.TabIndex = 18
        Me.GbMovimiento.TabStop = False
        '
        'txtDescripcionfinMov
        '
        Me.txtDescripcionfinMov.BackColor = System.Drawing.Color.White
        Me.txtDescripcionfinMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionfinMov.Location = New System.Drawing.Point(168, 37)
        Me.txtDescripcionfinMov.Name = "txtDescripcionfinMov"
        Me.txtDescripcionfinMov.ReadOnly = True
        Me.txtDescripcionfinMov.Size = New System.Drawing.Size(400, 20)
        Me.txtDescripcionfinMov.TabIndex = 119
        '
        'txtDescripcionInicioMov
        '
        Me.txtDescripcionInicioMov.BackColor = System.Drawing.Color.White
        Me.txtDescripcionInicioMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionInicioMov.Location = New System.Drawing.Point(168, 11)
        Me.txtDescripcionInicioMov.Name = "txtDescripcionInicioMov"
        Me.txtDescripcionInicioMov.ReadOnly = True
        Me.txtDescripcionInicioMov.Size = New System.Drawing.Size(400, 20)
        Me.txtDescripcionInicioMov.TabIndex = 115
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(152, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 120
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Del Movimiento"
        '
        'txtFinMov
        '
        Me.txtFinMov.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFinMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinMov.Location = New System.Drawing.Point(91, 38)
        Me.txtFinMov.Name = "txtFinMov"
        Me.txtFinMov.ReadOnly = True
        Me.txtFinMov.Size = New System.Drawing.Size(56, 20)
        Me.txtFinMov.TabIndex = 118
        '
        'txtInicioMov
        '
        Me.txtInicioMov.BackColor = System.Drawing.Color.Aquamarine
        Me.txtInicioMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInicioMov.Location = New System.Drawing.Point(91, 12)
        Me.txtInicioMov.Name = "txtInicioMov"
        Me.txtInicioMov.ReadOnly = True
        Me.txtInicioMov.Size = New System.Drawing.Size(56, 20)
        Me.txtInicioMov.TabIndex = 114
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(5, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Al Movimiento"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(150, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(668, 25)
        Me.ToolStrip1.TabIndex = 186
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(118, 22)
        Me.btnMostrar.Text = "&Mostrar reporte"
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
        'rdb_Resumido
        '
        Me.rdb_Resumido.AutoSize = True
        Me.rdb_Resumido.Checked = True
        Me.rdb_Resumido.Location = New System.Drawing.Point(183, 389)
        Me.rdb_Resumido.Name = "rdb_Resumido"
        Me.rdb_Resumido.Size = New System.Drawing.Size(72, 17)
        Me.rdb_Resumido.TabIndex = 20
        Me.rdb_Resumido.TabStop = True
        Me.rdb_Resumido.Text = "Resumido"
        Me.rdb_Resumido.UseVisualStyleBackColor = True
        '
        'rdb_Detallado
        '
        Me.rdb_Detallado.AutoSize = True
        Me.rdb_Detallado.Location = New System.Drawing.Point(394, 389)
        Me.rdb_Detallado.Name = "rdb_Detallado"
        Me.rdb_Detallado.Size = New System.Drawing.Size(70, 17)
        Me.rdb_Detallado.TabIndex = 21
        Me.rdb_Detallado.Text = "Detallado"
        Me.rdb_Detallado.UseVisualStyleBackColor = True
        '
        'chkMovimientos
        '
        Me.chkMovimientos.AutoSize = True
        Me.chkMovimientos.Checked = True
        Me.chkMovimientos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkMovimientos.Location = New System.Drawing.Point(7, 19)
        Me.chkMovimientos.Name = "chkMovimientos"
        Me.chkMovimientos.Size = New System.Drawing.Size(134, 17)
        Me.chkMovimientos.TabIndex = 19
        Me.chkMovimientos.Text = "Todos los Movimientos"
        Me.chkMovimientos.UseVisualStyleBackColor = True
        '
        'FrmTransaccionesArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(668, 458)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTransaccionesArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTransaccionesArticulo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbdetallearticulo.ResumeLayout(False)
        Me.gbdetallearticulo.PerformLayout()
        Me.GbArticulos.ResumeLayout(False)
        Me.GbArticulos.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdetallemov.ResumeLayout(False)
        Me.gbdetallemov.PerformLayout()
        Me.GbMovimiento.ResumeLayout(False)
        Me.GbMovimiento.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbdetallearticulo As System.Windows.Forms.GroupBox
    Friend WithEvents checkArticulo As System.Windows.Forms.CheckBox
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents gbdetallemov As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionfinMov As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFinMov As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionInicioMov As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtInicioMov As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionArticulofinal As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFinArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionArticuloInicial As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtinicioArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GbArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents GbMovimiento As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTipoMov As System.Windows.Forms.ComboBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents rdb_Detallado As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Resumido As System.Windows.Forms.RadioButton
    Friend WithEvents chkMovimientos As System.Windows.Forms.CheckBox
End Class
