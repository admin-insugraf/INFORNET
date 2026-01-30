<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepCobranzaEfectuada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepCobranzaEfectuada))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_excel = New System.Windows.Forms.RadioButton()
        Me.rb_documento = New System.Windows.Forms.RadioButton()
        Me.rb_vendedor = New System.Windows.Forms.RadioButton()
        Me.rb_cliente = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.pnl_cliente = New System.Windows.Forms.GroupBox()
        Me.gb_clientes = New System.Windows.Forms.GroupBox()
        Me.txtclienteFinalDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtclienteInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtclienteInicial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtclienteFinal = New System.Windows.Forms.TextBox()
        Me.checkClientes = New System.Windows.Forms.CheckBox()
        Me.pnl_vendedor = New System.Windows.Forms.GroupBox()
        Me.gb_vendedor = New System.Windows.Forms.GroupBox()
        Me.txtvendedorFinDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtvendedorInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtVendedorInicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVendedorFinal = New System.Windows.Forms.TextBox()
        Me.checkVendedor = New System.Windows.Forms.CheckBox()
        Me.pnl_documento = New System.Windows.Forms.GroupBox()
        Me.gb_documentos = New System.Windows.Forms.GroupBox()
        Me.txtdocumentoFinalDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdocumentoInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtdocumentoInicial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdocumentoFinal = New System.Windows.Forms.TextBox()
        Me.checkDocumentos = New System.Windows.Forms.CheckBox()
        Me.Panel_Formato_Concar = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_des_concepto = New System.Windows.Forms.TextBox()
        Me.txt_cod_concepto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnl_cliente.SuspendLayout()
        Me.gb_clientes.SuspendLayout()
        Me.pnl_vendedor.SuspendLayout()
        Me.gb_vendedor.SuspendLayout()
        Me.pnl_documento.SuspendLayout()
        Me.gb_documentos.SuspendLayout()
        Me.Panel_Formato_Concar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.rb_excel)
        Me.GroupBox4.Controls.Add(Me.rb_documento)
        Me.GroupBox4.Controls.Add(Me.rb_vendedor)
        Me.GroupBox4.Controls.Add(Me.rb_cliente)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(3, 265)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(103, 109)
        Me.GroupBox4.TabIndex = 190
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo"
        Me.GroupBox4.Visible = False
        '
        'rb_excel
        '
        Me.rb_excel.AutoSize = True
        Me.rb_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_excel.ForeColor = System.Drawing.Color.Navy
        Me.rb_excel.Location = New System.Drawing.Point(8, 81)
        Me.rb_excel.Name = "rb_excel"
        Me.rb_excel.Size = New System.Drawing.Size(54, 17)
        Me.rb_excel.TabIndex = 16
        Me.rb_excel.Text = " Excel"
        Me.rb_excel.UseVisualStyleBackColor = True
        '
        'rb_documento
        '
        Me.rb_documento.AutoSize = True
        Me.rb_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_documento.ForeColor = System.Drawing.Color.Navy
        Me.rb_documento.Location = New System.Drawing.Point(8, 61)
        Me.rb_documento.Name = "rb_documento"
        Me.rb_documento.Size = New System.Drawing.Size(87, 17)
        Me.rb_documento.TabIndex = 15
        Me.rb_documento.Text = "Tipo de Doc."
        Me.rb_documento.UseVisualStyleBackColor = True
        '
        'rb_vendedor
        '
        Me.rb_vendedor.AutoSize = True
        Me.rb_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_vendedor.ForeColor = System.Drawing.Color.Navy
        Me.rb_vendedor.Location = New System.Drawing.Point(8, 41)
        Me.rb_vendedor.Name = "rb_vendedor"
        Me.rb_vendedor.Size = New System.Drawing.Size(71, 17)
        Me.rb_vendedor.TabIndex = 14
        Me.rb_vendedor.Text = "Vendedor"
        Me.rb_vendedor.UseVisualStyleBackColor = True
        '
        'rb_cliente
        '
        Me.rb_cliente.AutoSize = True
        Me.rb_cliente.Checked = True
        Me.rb_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_cliente.ForeColor = System.Drawing.Color.Navy
        Me.rb_cliente.Location = New System.Drawing.Point(8, 20)
        Me.rb_cliente.Name = "rb_cliente"
        Me.rb_cliente.Size = New System.Drawing.Size(57, 17)
        Me.rb_cliente.TabIndex = 13
        Me.rb_cliente.TabStop = True
        Me.rb_cliente.Text = "Cliente"
        Me.rb_cliente.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Location = New System.Drawing.Point(4, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(514, 57)
        Me.GroupBox3.TabIndex = 189
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Cobranza"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(256, 26)
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
        Me.Label2.Location = New System.Drawing.Point(67, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(300, 20)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(103, 25)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 10.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(115, 19)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(103, 26)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(527, 25)
        Me.ToolStrip1.TabIndex = 188
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
        'pnl_cliente
        '
        Me.pnl_cliente.Controls.Add(Me.GroupBox1)
        Me.pnl_cliente.Controls.Add(Me.CheckBox1)
        Me.pnl_cliente.Controls.Add(Me.gb_clientes)
        Me.pnl_cliente.Controls.Add(Me.checkClientes)
        Me.pnl_cliente.ForeColor = System.Drawing.Color.Navy
        Me.pnl_cliente.Location = New System.Drawing.Point(4, 103)
        Me.pnl_cliente.Name = "pnl_cliente"
        Me.pnl_cliente.Size = New System.Drawing.Size(514, 153)
        Me.pnl_cliente.TabIndex = 191
        Me.pnl_cliente.TabStop = False
        Me.pnl_cliente.Text = "Datos"
        '
        'gb_clientes
        '
        Me.gb_clientes.Controls.Add(Me.txtclienteFinalDesc)
        Me.gb_clientes.Controls.Add(Me.Label7)
        Me.gb_clientes.Controls.Add(Me.txtclienteInicialDesc)
        Me.gb_clientes.Controls.Add(Me.txtclienteInicial)
        Me.gb_clientes.Controls.Add(Me.Label6)
        Me.gb_clientes.Controls.Add(Me.txtclienteFinal)
        Me.gb_clientes.Location = New System.Drawing.Point(13, 30)
        Me.gb_clientes.Name = "gb_clientes"
        Me.gb_clientes.Size = New System.Drawing.Size(495, 42)
        Me.gb_clientes.TabIndex = 179
        Me.gb_clientes.TabStop = False
        '
        'txtclienteFinalDesc
        '
        Me.txtclienteFinalDesc.BackColor = System.Drawing.Color.White
        Me.txtclienteFinalDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteFinalDesc.Location = New System.Drawing.Point(119, 47)
        Me.txtclienteFinalDesc.Name = "txtclienteFinalDesc"
        Me.txtclienteFinalDesc.ReadOnly = True
        Me.txtclienteFinalDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtclienteFinalDesc.TabIndex = 177
        Me.txtclienteFinalDesc.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(7, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "Cliente"
        '
        'txtclienteInicialDesc
        '
        Me.txtclienteInicialDesc.BackColor = System.Drawing.Color.White
        Me.txtclienteInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteInicialDesc.Location = New System.Drawing.Point(161, 13)
        Me.txtclienteInicialDesc.Name = "txtclienteInicialDesc"
        Me.txtclienteInicialDesc.ReadOnly = True
        Me.txtclienteInicialDesc.Size = New System.Drawing.Size(327, 20)
        Me.txtclienteInicialDesc.TabIndex = 176
        '
        'txtclienteInicial
        '
        Me.txtclienteInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtclienteInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteInicial.Location = New System.Drawing.Point(70, 13)
        Me.txtclienteInicial.Name = "txtclienteInicial"
        Me.txtclienteInicial.ReadOnly = True
        Me.txtclienteInicial.Size = New System.Drawing.Size(86, 20)
        Me.txtclienteInicial.TabIndex = 173
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(7, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 175
        Me.Label6.Text = "Final"
        Me.Label6.Visible = False
        '
        'txtclienteFinal
        '
        Me.txtclienteFinal.BackColor = System.Drawing.Color.Aquamarine
        Me.txtclienteFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteFinal.Location = New System.Drawing.Point(47, 46)
        Me.txtclienteFinal.Name = "txtclienteFinal"
        Me.txtclienteFinal.ReadOnly = True
        Me.txtclienteFinal.Size = New System.Drawing.Size(66, 20)
        Me.txtclienteFinal.TabIndex = 174
        Me.txtclienteFinal.Visible = False
        '
        'checkClientes
        '
        Me.checkClientes.AutoSize = True
        Me.checkClientes.ForeColor = System.Drawing.Color.Navy
        Me.checkClientes.Location = New System.Drawing.Point(23, 12)
        Me.checkClientes.Name = "checkClientes"
        Me.checkClientes.Size = New System.Drawing.Size(111, 17)
        Me.checkClientes.TabIndex = 183
        Me.checkClientes.Text = "Todos los clientes"
        Me.checkClientes.UseVisualStyleBackColor = True
        '
        'pnl_vendedor
        '
        Me.pnl_vendedor.Controls.Add(Me.gb_vendedor)
        Me.pnl_vendedor.Controls.Add(Me.checkVendedor)
        Me.pnl_vendedor.ForeColor = System.Drawing.Color.Navy
        Me.pnl_vendedor.Location = New System.Drawing.Point(488, 215)
        Me.pnl_vendedor.Name = "pnl_vendedor"
        Me.pnl_vendedor.Size = New System.Drawing.Size(132, 106)
        Me.pnl_vendedor.TabIndex = 176
        Me.pnl_vendedor.TabStop = False
        Me.pnl_vendedor.Text = "Rango de Vendedores"
        Me.pnl_vendedor.Visible = False
        '
        'gb_vendedor
        '
        Me.gb_vendedor.Controls.Add(Me.txtvendedorFinDesc)
        Me.gb_vendedor.Controls.Add(Me.Label5)
        Me.gb_vendedor.Controls.Add(Me.txtvendedorInicialDesc)
        Me.gb_vendedor.Controls.Add(Me.txtVendedorInicial)
        Me.gb_vendedor.Controls.Add(Me.Label4)
        Me.gb_vendedor.Controls.Add(Me.txtVendedorFinal)
        Me.gb_vendedor.Location = New System.Drawing.Point(3, 35)
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
        Me.checkVendedor.Location = New System.Drawing.Point(264, 19)
        Me.checkVendedor.Name = "checkVendedor"
        Me.checkVendedor.Size = New System.Drawing.Size(131, 17)
        Me.checkVendedor.TabIndex = 182
        Me.checkVendedor.Text = "Todos los vendedores"
        Me.checkVendedor.UseVisualStyleBackColor = True
        '
        'pnl_documento
        '
        Me.pnl_documento.Controls.Add(Me.gb_documentos)
        Me.pnl_documento.Controls.Add(Me.checkDocumentos)
        Me.pnl_documento.ForeColor = System.Drawing.Color.Navy
        Me.pnl_documento.Location = New System.Drawing.Point(439, 215)
        Me.pnl_documento.Name = "pnl_documento"
        Me.pnl_documento.Size = New System.Drawing.Size(181, 106)
        Me.pnl_documento.TabIndex = 193
        Me.pnl_documento.TabStop = False
        Me.pnl_documento.Text = "Rango de Tipo de Doc."
        Me.pnl_documento.Visible = False
        '
        'gb_documentos
        '
        Me.gb_documentos.Controls.Add(Me.txtdocumentoFinalDesc)
        Me.gb_documentos.Controls.Add(Me.Label3)
        Me.gb_documentos.Controls.Add(Me.txtdocumentoInicialDesc)
        Me.gb_documentos.Controls.Add(Me.txtdocumentoInicial)
        Me.gb_documentos.Controls.Add(Me.Label8)
        Me.gb_documentos.Controls.Add(Me.txtdocumentoFinal)
        Me.gb_documentos.Location = New System.Drawing.Point(3, 30)
        Me.gb_documentos.Name = "gb_documentos"
        Me.gb_documentos.Size = New System.Drawing.Size(394, 60)
        Me.gb_documentos.TabIndex = 179
        Me.gb_documentos.TabStop = False
        '
        'txtdocumentoFinalDesc
        '
        Me.txtdocumentoFinalDesc.BackColor = System.Drawing.Color.White
        Me.txtdocumentoFinalDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdocumentoFinalDesc.Location = New System.Drawing.Point(119, 34)
        Me.txtdocumentoFinalDesc.Name = "txtdocumentoFinalDesc"
        Me.txtdocumentoFinalDesc.ReadOnly = True
        Me.txtdocumentoFinalDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtdocumentoFinalDesc.TabIndex = 177
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(7, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "Inicial"
        '
        'txtdocumentoInicialDesc
        '
        Me.txtdocumentoInicialDesc.BackColor = System.Drawing.Color.White
        Me.txtdocumentoInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdocumentoInicialDesc.Location = New System.Drawing.Point(119, 11)
        Me.txtdocumentoInicialDesc.Name = "txtdocumentoInicialDesc"
        Me.txtdocumentoInicialDesc.ReadOnly = True
        Me.txtdocumentoInicialDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtdocumentoInicialDesc.TabIndex = 176
        '
        'txtdocumentoInicial
        '
        Me.txtdocumentoInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtdocumentoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdocumentoInicial.Location = New System.Drawing.Point(47, 11)
        Me.txtdocumentoInicial.Name = "txtdocumentoInicial"
        Me.txtdocumentoInicial.ReadOnly = True
        Me.txtdocumentoInicial.Size = New System.Drawing.Size(66, 20)
        Me.txtdocumentoInicial.TabIndex = 173
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(7, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "Final"
        '
        'txtdocumentoFinal
        '
        Me.txtdocumentoFinal.BackColor = System.Drawing.Color.Aquamarine
        Me.txtdocumentoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdocumentoFinal.Location = New System.Drawing.Point(47, 33)
        Me.txtdocumentoFinal.Name = "txtdocumentoFinal"
        Me.txtdocumentoFinal.ReadOnly = True
        Me.txtdocumentoFinal.Size = New System.Drawing.Size(66, 20)
        Me.txtdocumentoFinal.TabIndex = 174
        '
        'checkDocumentos
        '
        Me.checkDocumentos.AutoSize = True
        Me.checkDocumentos.ForeColor = System.Drawing.Color.Navy
        Me.checkDocumentos.Location = New System.Drawing.Point(268, 15)
        Me.checkDocumentos.Name = "checkDocumentos"
        Me.checkDocumentos.Size = New System.Drawing.Size(96, 17)
        Me.checkDocumentos.TabIndex = 183
        Me.checkDocumentos.Text = "Todos los doc."
        Me.checkDocumentos.UseVisualStyleBackColor = True
        '
        'Panel_Formato_Concar
        '
        Me.Panel_Formato_Concar.BackColor = System.Drawing.Color.White
        Me.Panel_Formato_Concar.Controls.Add(Me.GroupBox2)
        Me.Panel_Formato_Concar.Location = New System.Drawing.Point(519, 94)
        Me.Panel_Formato_Concar.Name = "Panel_Formato_Concar"
        Me.Panel_Formato_Concar.Size = New System.Drawing.Size(40, 131)
        Me.Panel_Formato_Concar.TabIndex = 194
        Me.Panel_Formato_Concar.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtRuta)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btnRuta)
        Me.GroupBox2.Controls.Add(Me.txtArchivo)
        Me.GroupBox2.Controls.Add(Me.btnDetener)
        Me.GroupBox2.Controls.Add(Me.btnIniciar)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 111)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Detalles "
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(236, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(66, 65)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(286, 13)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar2.TabIndex = 20
        Me.ProgressBar2.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 19
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(67, 18)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(285, 20)
        Me.txtRuta.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(8, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Progreso :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(8, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Ruta :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(8, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Archivo :"
        '
        'btnRuta
        '
        Me.btnRuta.Location = New System.Drawing.Point(359, 16)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(25, 23)
        Me.btnRuta.TabIndex = 7
        Me.btnRuta.Text = "..."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(67, 43)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(198, 20)
        Me.txtArchivo.TabIndex = 8
        Me.txtArchivo.Text = "Rep_Cobranza_Efectuada_Diario"
        '
        'btnDetener
        '
        Me.btnDetener.Image = CType(resources.GetObject("btnDetener.Image"), System.Drawing.Image)
        Me.btnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetener.Location = New System.Drawing.Point(152, 83)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(75, 23)
        Me.btnDetener.TabIndex = 10
        Me.btnDetener.Text = "Detener"
        Me.btnDetener.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.Image = CType(resources.GetObject("btnIniciar.Image"), System.Drawing.Image)
        Me.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIniciar.Location = New System.Drawing.Point(73, 83)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 9
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(67, 69)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(282, 9)
        Me.ProgressBar1.TabIndex = 14
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox1.Location = New System.Drawing.Point(23, 85)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(170, 17)
        Me.CheckBox1.TabIndex = 184
        Me.CheckBox1.Text = "Todos los conceptos de cobro"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_des_concepto)
        Me.GroupBox1.Controls.Add(Me.txt_cod_concepto)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 42)
        Me.GroupBox1.TabIndex = 185
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(119, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 177
        Me.TextBox1.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(7, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 173
        Me.Label13.Text = "Concepto"
        '
        'txt_des_concepto
        '
        Me.txt_des_concepto.BackColor = System.Drawing.Color.White
        Me.txt_des_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_concepto.Location = New System.Drawing.Point(161, 13)
        Me.txt_des_concepto.Name = "txt_des_concepto"
        Me.txt_des_concepto.ReadOnly = True
        Me.txt_des_concepto.Size = New System.Drawing.Size(327, 20)
        Me.txt_des_concepto.TabIndex = 176
        '
        'txt_cod_concepto
        '
        Me.txt_cod_concepto.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_concepto.Location = New System.Drawing.Point(70, 13)
        Me.txt_cod_concepto.Name = "txt_cod_concepto"
        Me.txt_cod_concepto.ReadOnly = True
        Me.txt_cod_concepto.Size = New System.Drawing.Size(86, 20)
        Me.txt_cod_concepto.TabIndex = 173
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(7, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 175
        Me.Label14.Text = "Final"
        Me.Label14.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(47, 46)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(66, 20)
        Me.TextBox4.TabIndex = 174
        Me.TextBox4.Visible = False
        '
        'FrmRepCobranzaEfectuada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(527, 270)
        Me.Controls.Add(Me.Panel_Formato_Concar)
        Me.Controls.Add(Me.pnl_vendedor)
        Me.Controls.Add(Me.pnl_documento)
        Me.Controls.Add(Me.pnl_cliente)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRepCobranzaEfectuada"
        Me.Text = "Reporte de Cobranza Efectuada"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnl_cliente.ResumeLayout(False)
        Me.pnl_cliente.PerformLayout()
        Me.gb_clientes.ResumeLayout(False)
        Me.gb_clientes.PerformLayout()
        Me.pnl_vendedor.ResumeLayout(False)
        Me.pnl_vendedor.PerformLayout()
        Me.gb_vendedor.ResumeLayout(False)
        Me.gb_vendedor.PerformLayout()
        Me.pnl_documento.ResumeLayout(False)
        Me.pnl_documento.PerformLayout()
        Me.gb_documentos.ResumeLayout(False)
        Me.gb_documentos.PerformLayout()
        Me.Panel_Formato_Concar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_documento As System.Windows.Forms.RadioButton
    Friend WithEvents rb_vendedor As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cliente As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents gb_clientes As System.Windows.Forms.GroupBox
    Friend WithEvents txtclienteFinalDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtclienteInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtclienteInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtclienteFinal As System.Windows.Forms.TextBox
    Friend WithEvents checkClientes As System.Windows.Forms.CheckBox
    Friend WithEvents pnl_vendedor As System.Windows.Forms.GroupBox
    Friend WithEvents gb_vendedor As System.Windows.Forms.GroupBox
    Friend WithEvents txtvendedorFinDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtvendedorInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedorInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVendedorFinal As System.Windows.Forms.TextBox
    Friend WithEvents checkVendedor As System.Windows.Forms.CheckBox
    Friend WithEvents pnl_documento As System.Windows.Forms.GroupBox
    Friend WithEvents gb_documentos As System.Windows.Forms.GroupBox
    Friend WithEvents txtdocumentoFinalDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdocumentoInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtdocumentoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdocumentoFinal As System.Windows.Forms.TextBox
    Friend WithEvents checkDocumentos As System.Windows.Forms.CheckBox
    Friend WithEvents rb_excel As System.Windows.Forms.RadioButton
    Friend WithEvents Panel_Formato_Concar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents btnDetener As System.Windows.Forms.Button
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_des_concepto As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_concepto As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
