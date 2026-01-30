<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentasMensualArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentasMensualArticulo))
        Me.gb_articulo = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.chktodos = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescripcionArticuloInicial = New System.Windows.Forms.TextBox()
        Me.cboPuntoventaFin = New System.Windows.Forms.ComboBox()
        Me.cboPuntoventaIni = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtinicioArticulo = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.rdb_articulo = New System.Windows.Forms.RadioButton()
        Me.rdb_vendedor = New System.Windows.Forms.RadioButton()
        Me.gb_vendedor = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpfechaFin_vendedor = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio_vendedor = New System.Windows.Forms.DateTimePicker()
        Me.chktodos_vendedor = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdescripcionArticuloInicial_vendedor = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtinicioArticulo_vendedor = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gb_articulo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.gb_vendedor.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_articulo
        '
        Me.gb_articulo.Controls.Add(Me.GroupBox3)
        Me.gb_articulo.Controls.Add(Me.chktodos)
        Me.gb_articulo.Controls.Add(Me.Label2)
        Me.gb_articulo.Controls.Add(Me.Label1)
        Me.gb_articulo.Controls.Add(Me.txtdescripcionArticuloInicial)
        Me.gb_articulo.Controls.Add(Me.cboPuntoventaFin)
        Me.gb_articulo.Controls.Add(Me.cboPuntoventaIni)
        Me.gb_articulo.Controls.Add(Me.Label9)
        Me.gb_articulo.Controls.Add(Me.Label5)
        Me.gb_articulo.Controls.Add(Me.txtinicioArticulo)
        Me.gb_articulo.Controls.Add(Me.PictureBox4)
        Me.gb_articulo.Location = New System.Drawing.Point(7, 79)
        Me.gb_articulo.Name = "gb_articulo"
        Me.gb_articulo.Size = New System.Drawing.Size(447, 152)
        Me.gb_articulo.TabIndex = 0
        Me.gb_articulo.TabStop = False
        Me.gb_articulo.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(417, 57)
        Me.GroupBox3.TabIndex = 133
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(212, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(17, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Desde"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(255, 20)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(103, 25)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 10.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(61, 19)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(103, 26)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.Color.Navy
        Me.chktodos.Location = New System.Drawing.Point(76, 106)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(114, 17)
        Me.chktodos.TabIndex = 132
        Me.chktodos.Text = "Todos los articulos"
        Me.chktodos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(259, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(11, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde"
        Me.Label1.Visible = False
        '
        'txtdescripcionArticuloInicial
        '
        Me.txtdescripcionArticuloInicial.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticuloInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticuloInicial.Location = New System.Drawing.Point(174, 79)
        Me.txtdescripcionArticuloInicial.Name = "txtdescripcionArticuloInicial"
        Me.txtdescripcionArticuloInicial.ReadOnly = True
        Me.txtdescripcionArticuloInicial.Size = New System.Drawing.Size(258, 20)
        Me.txtdescripcionArticuloInicial.TabIndex = 123
        '
        'cboPuntoventaFin
        '
        Me.cboPuntoventaFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuntoventaFin.FormattingEnabled = True
        Me.cboPuntoventaFin.Location = New System.Drawing.Point(298, 276)
        Me.cboPuntoventaFin.Name = "cboPuntoventaFin"
        Me.cboPuntoventaFin.Size = New System.Drawing.Size(200, 21)
        Me.cboPuntoventaFin.TabIndex = 3
        Me.cboPuntoventaFin.Visible = False
        '
        'cboPuntoventaIni
        '
        Me.cboPuntoventaIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuntoventaIni.FormattingEnabled = True
        Me.cboPuntoventaIni.Location = New System.Drawing.Point(53, 275)
        Me.cboPuntoventaIni.Name = "cboPuntoventaIni"
        Me.cboPuntoventaIni.Size = New System.Drawing.Size(204, 21)
        Me.cboPuntoventaIni.TabIndex = 1
        Me.cboPuntoventaIni.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(6, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "&Punto de Venta:"
        Me.Label9.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(24, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Articulo "
        '
        'txtinicioArticulo
        '
        Me.txtinicioArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtinicioArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtinicioArticulo.Location = New System.Drawing.Point(76, 79)
        Me.txtinicioArticulo.Name = "txtinicioArticulo"
        Me.txtinicioArticulo.ReadOnly = True
        Me.txtinicioArticulo.Size = New System.Drawing.Size(68, 20)
        Me.txtinicioArticulo.TabIndex = 122
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(149, 80)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 124
        Me.PictureBox4.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(463, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(120, 22)
        Me.btnMostrar.Text = "&Mostrar Reporte"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'rdb_articulo
        '
        Me.rdb_articulo.AutoSize = True
        Me.rdb_articulo.Checked = True
        Me.rdb_articulo.Location = New System.Drawing.Point(85, 43)
        Me.rdb_articulo.Name = "rdb_articulo"
        Me.rdb_articulo.Size = New System.Drawing.Size(87, 17)
        Me.rdb_articulo.TabIndex = 14
        Me.rdb_articulo.TabStop = True
        Me.rdb_articulo.Text = "Por Producto"
        Me.rdb_articulo.UseVisualStyleBackColor = True
        '
        'rdb_vendedor
        '
        Me.rdb_vendedor.AutoSize = True
        Me.rdb_vendedor.Location = New System.Drawing.Point(202, 43)
        Me.rdb_vendedor.Name = "rdb_vendedor"
        Me.rdb_vendedor.Size = New System.Drawing.Size(90, 17)
        Me.rdb_vendedor.TabIndex = 15
        Me.rdb_vendedor.Text = "Por Vendedor"
        Me.rdb_vendedor.UseVisualStyleBackColor = True
        '
        'gb_vendedor
        '
        Me.gb_vendedor.Controls.Add(Me.GroupBox4)
        Me.gb_vendedor.Controls.Add(Me.chktodos_vendedor)
        Me.gb_vendedor.Controls.Add(Me.Label8)
        Me.gb_vendedor.Controls.Add(Me.Label10)
        Me.gb_vendedor.Controls.Add(Me.txtdescripcionArticuloInicial_vendedor)
        Me.gb_vendedor.Controls.Add(Me.ComboBox1)
        Me.gb_vendedor.Controls.Add(Me.ComboBox2)
        Me.gb_vendedor.Controls.Add(Me.Label11)
        Me.gb_vendedor.Controls.Add(Me.Label12)
        Me.gb_vendedor.Controls.Add(Me.txtinicioArticulo_vendedor)
        Me.gb_vendedor.Controls.Add(Me.PictureBox1)
        Me.gb_vendedor.Location = New System.Drawing.Point(7, 79)
        Me.gb_vendedor.Name = "gb_vendedor"
        Me.gb_vendedor.Size = New System.Drawing.Size(447, 152)
        Me.gb_vendedor.TabIndex = 16
        Me.gb_vendedor.TabStop = False
        Me.gb_vendedor.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.dtpfechaFin_vendedor)
        Me.GroupBox4.Controls.Add(Me.dtpfechaInicio_vendedor)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(417, 57)
        Me.GroupBox4.TabIndex = 133
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rango de Fechas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(212, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Hasta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(17, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Desde"
        '
        'dtpfechaFin_vendedor
        '
        Me.dtpfechaFin_vendedor.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin_vendedor.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin_vendedor.Location = New System.Drawing.Point(255, 20)
        Me.dtpfechaFin_vendedor.Name = "dtpfechaFin_vendedor"
        Me.dtpfechaFin_vendedor.Size = New System.Drawing.Size(103, 25)
        Me.dtpfechaFin_vendedor.TabIndex = 2
        '
        'dtpfechaInicio_vendedor
        '
        Me.dtpfechaInicio_vendedor.Font = New System.Drawing.Font("Palatino Linotype", 10.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio_vendedor.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio_vendedor.Location = New System.Drawing.Point(61, 19)
        Me.dtpfechaInicio_vendedor.Name = "dtpfechaInicio_vendedor"
        Me.dtpfechaInicio_vendedor.Size = New System.Drawing.Size(103, 26)
        Me.dtpfechaInicio_vendedor.TabIndex = 1
        '
        'chktodos_vendedor
        '
        Me.chktodos_vendedor.AutoSize = True
        Me.chktodos_vendedor.ForeColor = System.Drawing.Color.Navy
        Me.chktodos_vendedor.Location = New System.Drawing.Point(76, 106)
        Me.chktodos_vendedor.Name = "chktodos_vendedor"
        Me.chktodos_vendedor.Size = New System.Drawing.Size(131, 17)
        Me.chktodos_vendedor.TabIndex = 132
        Me.chktodos_vendedor.Text = "Todos los vendedores"
        Me.chktodos_vendedor.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(259, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Hasta"
        Me.Label8.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(11, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Desde"
        Me.Label10.Visible = False
        '
        'txtdescripcionArticuloInicial_vendedor
        '
        Me.txtdescripcionArticuloInicial_vendedor.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticuloInicial_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticuloInicial_vendedor.Location = New System.Drawing.Point(174, 79)
        Me.txtdescripcionArticuloInicial_vendedor.Name = "txtdescripcionArticuloInicial_vendedor"
        Me.txtdescripcionArticuloInicial_vendedor.ReadOnly = True
        Me.txtdescripcionArticuloInicial_vendedor.Size = New System.Drawing.Size(258, 20)
        Me.txtdescripcionArticuloInicial_vendedor.TabIndex = 123
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(298, 276)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(53, 275)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(204, 21)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(6, 254)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "&Punto de Venta:"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(20, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Vendedor"
        '
        'txtinicioArticulo_vendedor
        '
        Me.txtinicioArticulo_vendedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtinicioArticulo_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtinicioArticulo_vendedor.Location = New System.Drawing.Point(76, 79)
        Me.txtinicioArticulo_vendedor.Name = "txtinicioArticulo_vendedor"
        Me.txtinicioArticulo_vendedor.ReadOnly = True
        Me.txtinicioArticulo_vendedor.Size = New System.Drawing.Size(68, 20)
        Me.txtinicioArticulo_vendedor.TabIndex = 122
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(149, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'FrmVentasMensualArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(463, 239)
        Me.Controls.Add(Me.gb_vendedor)
        Me.Controls.Add(Me.rdb_vendedor)
        Me.Controls.Add(Me.rdb_articulo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gb_articulo)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVentasMensualArticulo"
        Me.Text = "Ventas Mensuales"
        Me.gb_articulo.ResumeLayout(False)
        Me.gb_articulo.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gb_vendedor.ResumeLayout(False)
        Me.gb_vendedor.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_articulo As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPuntoventaIni As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPuntoventaFin As System.Windows.Forms.ComboBox
    Friend WithEvents txtdescripcionArticuloInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtinicioArticulo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents chktodos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdb_articulo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_vendedor As System.Windows.Forms.RadioButton
    Friend WithEvents gb_vendedor As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin_vendedor As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio_vendedor As System.Windows.Forms.DateTimePicker
    Friend WithEvents chktodos_vendedor As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionArticuloInicial_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtinicioArticulo_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
