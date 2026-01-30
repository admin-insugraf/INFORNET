<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteDocumentosCancelados_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteDocumentosCancelados_Pago))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel_Formato_Concar = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rb_excel = New System.Windows.Forms.RadioButton()
        Me.rb_cliente = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkVendedor = New System.Windows.Forms.CheckBox()
        Me.txtvendedorFinDesc = New System.Windows.Forms.TextBox()
        Me.txtvendedorInicialDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVendedorFinal = New System.Windows.Forms.TextBox()
        Me.txtVendedorInicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkClientes = New System.Windows.Forms.CheckBox()
        Me.txtclienteFinalDesc = New System.Windows.Forms.TextBox()
        Me.txtclienteInicialDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtclienteFinal = New System.Windows.Forms.TextBox()
        Me.txtclienteInicial = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txt_des_concepto = New System.Windows.Forms.TextBox()
        Me.txt_cod_concepto = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel_Formato_Concar.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.Panel_Formato_Concar)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 332)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Reporte"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CheckBox1)
        Me.GroupBox7.Controls.Add(Me.TextBox2)
        Me.GroupBox7.Controls.Add(Me.TextBox4)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(6, 162)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(456, 75)
        Me.GroupBox7.TabIndex = 196
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Tipo de Documento(s)"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox1.Location = New System.Drawing.Point(315, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox1.TabIndex = 183
        Me.CheckBox1.Text = "Todos los Documentos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(107, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(343, 20)
        Me.TextBox2.TabIndex = 176
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(8, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(90, 20)
        Me.TextBox4.TabIndex = 173
        '
        'Panel_Formato_Concar
        '
        Me.Panel_Formato_Concar.BackColor = System.Drawing.Color.White
        Me.Panel_Formato_Concar.Controls.Add(Me.GroupBox6)
        Me.Panel_Formato_Concar.Location = New System.Drawing.Point(115, 350)
        Me.Panel_Formato_Concar.Name = "Panel_Formato_Concar"
        Me.Panel_Formato_Concar.Size = New System.Drawing.Size(410, 125)
        Me.Panel_Formato_Concar.TabIndex = 195
        Me.Panel_Formato_Concar.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.ProgressBar2)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.txtRuta)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.btnRuta)
        Me.GroupBox6.Controls.Add(Me.txtArchivo)
        Me.GroupBox6.Controls.Add(Me.btnDetener)
        Me.GroupBox6.Controls.Add(Me.btnIniciar)
        Me.GroupBox6.Controls.Add(Me.ProgressBar1)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(388, 111)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = " Detalles "
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
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.rb_excel)
        Me.GroupBox5.Controls.Add(Me.rb_cliente)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(6, 341)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(103, 109)
        Me.GroupBox5.TabIndex = 191
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo"
        Me.GroupBox5.Visible = False
        '
        'rb_excel
        '
        Me.rb_excel.AutoSize = True
        Me.rb_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_excel.ForeColor = System.Drawing.Color.Navy
        Me.rb_excel.Location = New System.Drawing.Point(9, 64)
        Me.rb_excel.Name = "rb_excel"
        Me.rb_excel.Size = New System.Drawing.Size(54, 17)
        Me.rb_excel.TabIndex = 16
        Me.rb_excel.Text = " Excel"
        Me.rb_excel.UseVisualStyleBackColor = True
        '
        'rb_cliente
        '
        Me.rb_cliente.AutoSize = True
        Me.rb_cliente.Checked = True
        Me.rb_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_cliente.ForeColor = System.Drawing.Color.Navy
        Me.rb_cliente.Location = New System.Drawing.Point(9, 26)
        Me.rb_cliente.Name = "rb_cliente"
        Me.rb_cliente.Size = New System.Drawing.Size(74, 17)
        Me.rb_cliente.TabIndex = 13
        Me.rb_cliente.TabStop = True
        Me.rb_cliente.Text = "Proveedor"
        Me.rb_cliente.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox4.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(456, 57)
        Me.GroupBox4.TabIndex = 175
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(250, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hasta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(64, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Desde"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(291, 21)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(103, 25)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 10.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(107, 20)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(105, 26)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkVendedor)
        Me.GroupBox3.Controls.Add(Me.txtvendedorFinDesc)
        Me.GroupBox3.Controls.Add(Me.txtvendedorInicialDesc)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtVendedorFinal)
        Me.GroupBox3.Controls.Add(Me.txtVendedorInicial)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 345)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 98)
        Me.GroupBox3.TabIndex = 174
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Rango de Vendedores"
        '
        'checkVendedor
        '
        Me.checkVendedor.AutoSize = True
        Me.checkVendedor.Location = New System.Drawing.Point(13, 20)
        Me.checkVendedor.Name = "checkVendedor"
        Me.checkVendedor.Size = New System.Drawing.Size(131, 17)
        Me.checkVendedor.TabIndex = 182
        Me.checkVendedor.Text = "&Todos los vendedores"
        Me.checkVendedor.UseVisualStyleBackColor = True
        '
        'txtvendedorFinDesc
        '
        Me.txtvendedorFinDesc.Location = New System.Drawing.Point(122, 67)
        Me.txtvendedorFinDesc.Name = "txtvendedorFinDesc"
        Me.txtvendedorFinDesc.ReadOnly = True
        Me.txtvendedorFinDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtvendedorFinDesc.TabIndex = 181
        '
        'txtvendedorInicialDesc
        '
        Me.txtvendedorInicialDesc.Location = New System.Drawing.Point(122, 40)
        Me.txtvendedorInicialDesc.Name = "txtvendedorInicialDesc"
        Me.txtvendedorInicialDesc.ReadOnly = True
        Me.txtvendedorInicialDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtvendedorInicialDesc.TabIndex = 180
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "Final"
        '
        'txtVendedorFinal
        '
        Me.txtVendedorFinal.Location = New System.Drawing.Point(50, 66)
        Me.txtVendedorFinal.Name = "txtVendedorFinal"
        Me.txtVendedorFinal.ReadOnly = True
        Me.txtVendedorFinal.Size = New System.Drawing.Size(66, 20)
        Me.txtVendedorFinal.TabIndex = 178
        '
        'txtVendedorInicial
        '
        Me.txtVendedorInicial.Location = New System.Drawing.Point(50, 40)
        Me.txtVendedorInicial.Name = "txtVendedorInicial"
        Me.txtVendedorInicial.ReadOnly = True
        Me.txtVendedorInicial.Size = New System.Drawing.Size(66, 20)
        Me.txtVendedorInicial.TabIndex = 176
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Inicial"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checkClientes)
        Me.GroupBox2.Controls.Add(Me.txtclienteFinalDesc)
        Me.GroupBox2.Controls.Add(Me.txtclienteInicialDesc)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtclienteFinal)
        Me.GroupBox2.Controls.Add(Me.txtclienteInicial)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(6, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 75)
        Me.GroupBox2.TabIndex = 173
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedor(es)"
        '
        'checkClientes
        '
        Me.checkClientes.AutoSize = True
        Me.checkClientes.ForeColor = System.Drawing.Color.Navy
        Me.checkClientes.Location = New System.Drawing.Point(315, 20)
        Me.checkClientes.Name = "checkClientes"
        Me.checkClientes.Size = New System.Drawing.Size(135, 17)
        Me.checkClientes.TabIndex = 183
        Me.checkClientes.Text = "Todos los Proveedores"
        Me.checkClientes.UseVisualStyleBackColor = True
        '
        'txtclienteFinalDesc
        '
        Me.txtclienteFinalDesc.BackColor = System.Drawing.Color.White
        Me.txtclienteFinalDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteFinalDesc.Location = New System.Drawing.Point(122, 76)
        Me.txtclienteFinalDesc.Name = "txtclienteFinalDesc"
        Me.txtclienteFinalDesc.ReadOnly = True
        Me.txtclienteFinalDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtclienteFinalDesc.TabIndex = 177
        Me.txtclienteFinalDesc.Visible = False
        '
        'txtclienteInicialDesc
        '
        Me.txtclienteInicialDesc.BackColor = System.Drawing.Color.White
        Me.txtclienteInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteInicialDesc.Location = New System.Drawing.Point(107, 40)
        Me.txtclienteInicialDesc.Name = "txtclienteInicialDesc"
        Me.txtclienteInicialDesc.ReadOnly = True
        Me.txtclienteInicialDesc.Size = New System.Drawing.Size(343, 20)
        Me.txtclienteInicialDesc.TabIndex = 176
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(10, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "Final"
        Me.Label2.Visible = False
        '
        'txtclienteFinal
        '
        Me.txtclienteFinal.BackColor = System.Drawing.Color.Aquamarine
        Me.txtclienteFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteFinal.Location = New System.Drawing.Point(50, 77)
        Me.txtclienteFinal.Name = "txtclienteFinal"
        Me.txtclienteFinal.ReadOnly = True
        Me.txtclienteFinal.Size = New System.Drawing.Size(66, 20)
        Me.txtclienteFinal.TabIndex = 174
        Me.txtclienteFinal.Visible = False
        '
        'txtclienteInicial
        '
        Me.txtclienteInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtclienteInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteInicial.Location = New System.Drawing.Point(8, 40)
        Me.txtclienteInicial.Name = "txtclienteInicial"
        Me.txtclienteInicial.ReadOnly = True
        Me.txtclienteInicial.Size = New System.Drawing.Size(90, 20)
        Me.txtclienteInicial.TabIndex = 173
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ok, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(491, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(121, 22)
        Me.btn_ok.Text = "Mostrar Reporte"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "Salir"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CheckBox2)
        Me.GroupBox8.Controls.Add(Me.txt_des_concepto)
        Me.GroupBox8.Controls.Add(Me.txt_cod_concepto)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(6, 246)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(456, 75)
        Me.GroupBox8.TabIndex = 198
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Conceptos de Pago"
        '
        'txt_des_concepto
        '
        Me.txt_des_concepto.BackColor = System.Drawing.Color.White
        Me.txt_des_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_concepto.Location = New System.Drawing.Point(107, 42)
        Me.txt_des_concepto.Name = "txt_des_concepto"
        Me.txt_des_concepto.ReadOnly = True
        Me.txt_des_concepto.Size = New System.Drawing.Size(343, 20)
        Me.txt_des_concepto.TabIndex = 176
        '
        'txt_cod_concepto
        '
        Me.txt_cod_concepto.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_concepto.Location = New System.Drawing.Point(8, 42)
        Me.txt_cod_concepto.Name = "txt_cod_concepto"
        Me.txt_cod_concepto.ReadOnly = True
        Me.txt_cod_concepto.Size = New System.Drawing.Size(86, 20)
        Me.txt_cod_concepto.TabIndex = 173
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox2.Location = New System.Drawing.Point(283, 22)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(167, 17)
        Me.CheckBox2.TabIndex = 198
        Me.CheckBox2.Text = "Todos los conceptos de pago"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'FrmReporteDocumentosCancelados_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(491, 376)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReporteDocumentosCancelados_Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Reporte Pagos efectuados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel_Formato_Concar.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtvendedorFinDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtvendedorInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVendedorFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedorInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtclienteFinalDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtclienteInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtclienteFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtclienteInicial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents checkVendedor As System.Windows.Forms.CheckBox
    Friend WithEvents checkClientes As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_excel As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cliente As System.Windows.Forms.RadioButton
    Friend WithEvents Panel_Formato_Concar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
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
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_des_concepto As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_concepto As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
