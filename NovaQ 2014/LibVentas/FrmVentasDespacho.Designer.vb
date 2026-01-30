<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentasDespacho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentasDespacho))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboOpcionTipoDoc = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbAmbos = New System.Windows.Forms.RadioButton()
        Me.rbSinDespachar = New System.Windows.Forms.RadioButton()
        Me.rbDespachado = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_vendedor = New System.Windows.Forms.RadioButton()
        Me.rb_cliente = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.gb_vendedor = New System.Windows.Forms.GroupBox()
        Me.txtvendedorFinDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtvendedorInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtVendedorInicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVendedorFinal = New System.Windows.Forms.TextBox()
        Me.checkVendedor = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.gb_clientes = New System.Windows.Forms.GroupBox()
        Me.txtclienteFinalDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtclienteInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtclienteInicial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtclienteFinal = New System.Windows.Forms.TextBox()
        Me.checkClientes = New System.Windows.Forms.CheckBox()
        Me.pnl_cliente = New System.Windows.Forms.Panel()
        Me.pnl_vendedor = New System.Windows.Forms.Panel()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gb_vendedor.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gb_clientes.SuspendLayout()
        Me.pnl_cliente.SuspendLayout()
        Me.pnl_vendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(58, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&DESPACHOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 57)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Rango de Fechas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(175, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(5, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(238, 22)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(103, 25)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 10.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(49, 22)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(103, 26)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cboOpcionTipoDoc)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 43)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Tipo de documento"
        '
        'cboOpcionTipoDoc
        '
        Me.cboOpcionTipoDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpcionTipoDoc.FormattingEnabled = True
        Me.cboOpcionTipoDoc.Items.AddRange(New Object() {"Todos", "BV", "CP", "FT", "NC", "ND", "GS"})
        Me.cboOpcionTipoDoc.Location = New System.Drawing.Point(7, 16)
        Me.cboOpcionTipoDoc.Name = "cboOpcionTipoDoc"
        Me.cboOpcionTipoDoc.Size = New System.Drawing.Size(161, 21)
        Me.cboOpcionTipoDoc.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.rbAmbos)
        Me.GroupBox2.Controls.Add(Me.rbSinDespachar)
        Me.GroupBox2.Controls.Add(Me.rbDespachado)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(186, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 44)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Tipo "
        '
        'rbAmbos
        '
        Me.rbAmbos.AutoSize = True
        Me.rbAmbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbAmbos.ForeColor = System.Drawing.Color.Navy
        Me.rbAmbos.Location = New System.Drawing.Point(215, 20)
        Me.rbAmbos.Name = "rbAmbos"
        Me.rbAmbos.Size = New System.Drawing.Size(57, 17)
        Me.rbAmbos.TabIndex = 13
        Me.rbAmbos.Text = "&Ambos"
        Me.rbAmbos.UseVisualStyleBackColor = True
        '
        'rbSinDespachar
        '
        Me.rbSinDespachar.AutoSize = True
        Me.rbSinDespachar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbSinDespachar.ForeColor = System.Drawing.Color.Navy
        Me.rbSinDespachar.Location = New System.Drawing.Point(104, 20)
        Me.rbSinDespachar.Name = "rbSinDespachar"
        Me.rbSinDespachar.Size = New System.Drawing.Size(101, 17)
        Me.rbSinDespachar.TabIndex = 13
        Me.rbSinDespachar.Text = "&No despachado"
        Me.rbSinDespachar.UseVisualStyleBackColor = True
        '
        'rbDespachado
        '
        Me.rbDespachado.AutoSize = True
        Me.rbDespachado.Checked = True
        Me.rbDespachado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbDespachado.ForeColor = System.Drawing.Color.Navy
        Me.rbDespachado.Location = New System.Drawing.Point(9, 20)
        Me.rbDespachado.Name = "rbDespachado"
        Me.rbDespachado.Size = New System.Drawing.Size(86, 17)
        Me.rbDespachado.TabIndex = 12
        Me.rbDespachado.TabStop = True
        Me.rbDespachado.Text = "&Despachado"
        Me.rbDespachado.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(530, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(118, 22)
        Me.btnMostrar.Text = "&Mostrar reporte"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.rb_vendedor)
        Me.GroupBox4.Controls.Add(Me.rb_cliente)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(103, 100)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "&Tipo de Reporte"
        '
        'rb_vendedor
        '
        Me.rb_vendedor.AutoSize = True
        Me.rb_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_vendedor.ForeColor = System.Drawing.Color.Navy
        Me.rb_vendedor.Location = New System.Drawing.Point(8, 67)
        Me.rb_vendedor.Name = "rb_vendedor"
        Me.rb_vendedor.Size = New System.Drawing.Size(89, 17)
        Me.rb_vendedor.TabIndex = 14
        Me.rb_vendedor.Text = "&Por vendedor"
        Me.rb_vendedor.UseVisualStyleBackColor = True
        '
        'rb_cliente
        '
        Me.rb_cliente.AutoSize = True
        Me.rb_cliente.Checked = True
        Me.rb_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_cliente.ForeColor = System.Drawing.Color.Navy
        Me.rb_cliente.Location = New System.Drawing.Point(8, 33)
        Me.rb_cliente.Name = "rb_cliente"
        Me.rb_cliente.Size = New System.Drawing.Size(75, 17)
        Me.rb_cliente.TabIndex = 13
        Me.rb_cliente.TabStop = True
        Me.rb_cliente.Text = "&Por cliente"
        Me.rb_cliente.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.gb_vendedor)
        Me.GroupBox5.Controls.Add(Me.checkVendedor)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(400, 96)
        Me.GroupBox5.TabIndex = 176
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "&Rango de Vendedores"
        '
        'gb_vendedor
        '
        Me.gb_vendedor.Controls.Add(Me.txtvendedorFinDesc)
        Me.gb_vendedor.Controls.Add(Me.Label5)
        Me.gb_vendedor.Controls.Add(Me.txtvendedorInicialDesc)
        Me.gb_vendedor.Controls.Add(Me.txtVendedorInicial)
        Me.gb_vendedor.Controls.Add(Me.Label4)
        Me.gb_vendedor.Controls.Add(Me.txtVendedorFinal)
        Me.gb_vendedor.Location = New System.Drawing.Point(3, 29)
        Me.gb_vendedor.Name = "gb_vendedor"
        Me.gb_vendedor.Size = New System.Drawing.Size(394, 60)
        Me.gb_vendedor.TabIndex = 180
        Me.gb_vendedor.TabStop = False
        '
        'txtvendedorFinDesc
        '
        Me.txtvendedorFinDesc.BackColor = System.Drawing.Color.White
        Me.txtvendedorFinDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvendedorFinDesc.Location = New System.Drawing.Point(116, 34)
        Me.txtvendedorFinDesc.Name = "txtvendedorFinDesc"
        Me.txtvendedorFinDesc.ReadOnly = True
        Me.txtvendedorFinDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtvendedorFinDesc.TabIndex = 181
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(4, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Inicial"
        '
        'txtvendedorInicialDesc
        '
        Me.txtvendedorInicialDesc.BackColor = System.Drawing.Color.White
        Me.txtvendedorInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvendedorInicialDesc.Location = New System.Drawing.Point(116, 12)
        Me.txtvendedorInicialDesc.Name = "txtvendedorInicialDesc"
        Me.txtvendedorInicialDesc.ReadOnly = True
        Me.txtvendedorInicialDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtvendedorInicialDesc.TabIndex = 180
        '
        'txtVendedorInicial
        '
        Me.txtVendedorInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtVendedorInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendedorInicial.Location = New System.Drawing.Point(44, 12)
        Me.txtVendedorInicial.Name = "txtVendedorInicial"
        Me.txtVendedorInicial.ReadOnly = True
        Me.txtVendedorInicial.Size = New System.Drawing.Size(66, 20)
        Me.txtVendedorInicial.TabIndex = 176
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(4, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Final"
        '
        'txtVendedorFinal
        '
        Me.txtVendedorFinal.BackColor = System.Drawing.Color.Aquamarine
        Me.txtVendedorFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendedorFinal.Location = New System.Drawing.Point(44, 33)
        Me.txtVendedorFinal.Name = "txtVendedorFinal"
        Me.txtVendedorFinal.ReadOnly = True
        Me.txtVendedorFinal.Size = New System.Drawing.Size(66, 20)
        Me.txtVendedorFinal.TabIndex = 178
        '
        'checkVendedor
        '
        Me.checkVendedor.AutoSize = True
        Me.checkVendedor.ForeColor = System.Drawing.Color.Navy
        Me.checkVendedor.Location = New System.Drawing.Point(264, 13)
        Me.checkVendedor.Name = "checkVendedor"
        Me.checkVendedor.Size = New System.Drawing.Size(131, 17)
        Me.checkVendedor.TabIndex = 182
        Me.checkVendedor.Text = "&Todos los vendedores"
        Me.checkVendedor.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.gb_clientes)
        Me.GroupBox6.Controls.Add(Me.checkClientes)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(400, 96)
        Me.GroupBox6.TabIndex = 175
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "&Rango de Clientes"
        '
        'gb_clientes
        '
        Me.gb_clientes.Controls.Add(Me.txtclienteFinalDesc)
        Me.gb_clientes.Controls.Add(Me.Label7)
        Me.gb_clientes.Controls.Add(Me.txtclienteInicialDesc)
        Me.gb_clientes.Controls.Add(Me.txtclienteInicial)
        Me.gb_clientes.Controls.Add(Me.Label6)
        Me.gb_clientes.Controls.Add(Me.txtclienteFinal)
        Me.gb_clientes.Location = New System.Drawing.Point(3, 30)
        Me.gb_clientes.Name = "gb_clientes"
        Me.gb_clientes.Size = New System.Drawing.Size(394, 60)
        Me.gb_clientes.TabIndex = 179
        Me.gb_clientes.TabStop = False
        '
        'txtclienteFinalDesc
        '
        Me.txtclienteFinalDesc.BackColor = System.Drawing.Color.White
        Me.txtclienteFinalDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteFinalDesc.Location = New System.Drawing.Point(119, 34)
        Me.txtclienteFinalDesc.Name = "txtclienteFinalDesc"
        Me.txtclienteFinalDesc.ReadOnly = True
        Me.txtclienteFinalDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtclienteFinalDesc.TabIndex = 177
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(7, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "Inicial"
        '
        'txtclienteInicialDesc
        '
        Me.txtclienteInicialDesc.BackColor = System.Drawing.Color.White
        Me.txtclienteInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteInicialDesc.Location = New System.Drawing.Point(119, 11)
        Me.txtclienteInicialDesc.Name = "txtclienteInicialDesc"
        Me.txtclienteInicialDesc.ReadOnly = True
        Me.txtclienteInicialDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtclienteInicialDesc.TabIndex = 176
        '
        'txtclienteInicial
        '
        Me.txtclienteInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtclienteInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteInicial.Location = New System.Drawing.Point(47, 11)
        Me.txtclienteInicial.Name = "txtclienteInicial"
        Me.txtclienteInicial.ReadOnly = True
        Me.txtclienteInicial.Size = New System.Drawing.Size(66, 20)
        Me.txtclienteInicial.TabIndex = 173
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(7, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 175
        Me.Label6.Text = "Final"
        '
        'txtclienteFinal
        '
        Me.txtclienteFinal.BackColor = System.Drawing.Color.Aquamarine
        Me.txtclienteFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteFinal.Location = New System.Drawing.Point(47, 33)
        Me.txtclienteFinal.Name = "txtclienteFinal"
        Me.txtclienteFinal.ReadOnly = True
        Me.txtclienteFinal.Size = New System.Drawing.Size(66, 20)
        Me.txtclienteFinal.TabIndex = 174
        '
        'checkClientes
        '
        Me.checkClientes.AutoSize = True
        Me.checkClientes.ForeColor = System.Drawing.Color.Navy
        Me.checkClientes.Location = New System.Drawing.Point(269, 12)
        Me.checkClientes.Name = "checkClientes"
        Me.checkClientes.Size = New System.Drawing.Size(111, 17)
        Me.checkClientes.TabIndex = 183
        Me.checkClientes.Text = "&Todos los clientes"
        Me.checkClientes.UseVisualStyleBackColor = True
        '
        'pnl_cliente
        '
        Me.pnl_cliente.Controls.Add(Me.GroupBox6)
        Me.pnl_cliente.Location = New System.Drawing.Point(116, 144)
        Me.pnl_cliente.Name = "pnl_cliente"
        Me.pnl_cliente.Size = New System.Drawing.Size(406, 104)
        Me.pnl_cliente.TabIndex = 177
        '
        'pnl_vendedor
        '
        Me.pnl_vendedor.Controls.Add(Me.GroupBox5)
        Me.pnl_vendedor.Location = New System.Drawing.Point(116, 145)
        Me.pnl_vendedor.Name = "pnl_vendedor"
        Me.pnl_vendedor.Size = New System.Drawing.Size(406, 104)
        Me.pnl_vendedor.TabIndex = 178
        Me.pnl_vendedor.Visible = False
        '
        'FrmVentasDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(530, 255)
        Me.Controls.Add(Me.pnl_vendedor)
        Me.Controls.Add(Me.pnl_cliente)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVentasDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Despachos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gb_vendedor.ResumeLayout(False)
        Me.gb_vendedor.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gb_clientes.ResumeLayout(False)
        Me.gb_clientes.PerformLayout()
        Me.pnl_cliente.ResumeLayout(False)
        Me.pnl_vendedor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents rbSinDespachar As System.Windows.Forms.RadioButton
    Friend WithEvents rbDespachado As System.Windows.Forms.RadioButton
    Friend WithEvents cboOpcionTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_vendedor As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cliente As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents checkVendedor As System.Windows.Forms.CheckBox
    Friend WithEvents txtvendedorFinDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtvendedorInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVendedorFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedorInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents checkClientes As System.Windows.Forms.CheckBox
    Friend WithEvents txtclienteFinalDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtclienteInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtclienteFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtclienteInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnl_cliente As System.Windows.Forms.Panel
    Friend WithEvents pnl_vendedor As System.Windows.Forms.Panel
    Friend WithEvents gb_vendedor As System.Windows.Forms.GroupBox
    Friend WithEvents gb_clientes As System.Windows.Forms.GroupBox
End Class
