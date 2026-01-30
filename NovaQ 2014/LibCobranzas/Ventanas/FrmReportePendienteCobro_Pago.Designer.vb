Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportePendienteCobro_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportePendienteCobro_Pago))
        Me.gbReporte = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.chklstdocumentos = New System.Windows.Forms.CheckedListBox()
        Me.checkDocumentos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbMensual = New System.Windows.Forms.RadioButton()
        Me.rbFechas = New System.Windows.Forms.RadioButton()
        Me.rbClientes = New System.Windows.Forms.RadioButton()
        Me.checkTodos = New System.Windows.Forms.CheckBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.pnlFecha = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechafinal_emision = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechainicial_emision = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechafinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechainicial = New System.Windows.Forms.DateTimePicker()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.pnlMensual = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdb_todos = New System.Windows.Forms.RadioButton()
        Me.rdb_pendiente = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_mensual = New System.Windows.Forms.DateTimePicker()
        Me.gbReporte.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFecha.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlMensual.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbReporte
        '
        Me.gbReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbReporte.Controls.Add(Me.GroupBox9)
        Me.gbReporte.Controls.Add(Me.GroupBox1)
        Me.gbReporte.Controls.Add(Me.checkTodos)
        Me.gbReporte.Controls.Add(Me.lblCantidad)
        Me.gbReporte.Controls.Add(Me.gbFiltros)
        Me.gbReporte.Controls.Add(Me.dgvDocumentos)
        Me.gbReporte.ForeColor = System.Drawing.Color.Navy
        Me.gbReporte.Location = New System.Drawing.Point(12, 32)
        Me.gbReporte.Name = "gbReporte"
        Me.gbReporte.Size = New System.Drawing.Size(669, 545)
        Me.gbReporte.TabIndex = 2
        Me.gbReporte.TabStop = False
        Me.gbReporte.Text = "&Datos de Proveedores pendientes de Pago"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.chklstdocumentos)
        Me.GroupBox9.Controls.Add(Me.checkDocumentos)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(193, 121)
        Me.GroupBox9.TabIndex = 188
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Tipo de Documento"
        '
        'chklstdocumentos
        '
        Me.chklstdocumentos.CheckOnClick = True
        Me.chklstdocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstdocumentos.FormattingEnabled = True
        Me.chklstdocumentos.Location = New System.Drawing.Point(8, 37)
        Me.chklstdocumentos.Name = "chklstdocumentos"
        Me.chklstdocumentos.Size = New System.Drawing.Size(176, 79)
        Me.chklstdocumentos.TabIndex = 5
        '
        'checkDocumentos
        '
        Me.checkDocumentos.AutoSize = True
        Me.checkDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkDocumentos.ForeColor = System.Drawing.Color.Navy
        Me.checkDocumentos.Location = New System.Drawing.Point(10, 18)
        Me.checkDocumentos.Name = "checkDocumentos"
        Me.checkDocumentos.Size = New System.Drawing.Size(92, 17)
        Me.checkDocumentos.TabIndex = 4
        Me.checkDocumentos.Text = "Activar Todos"
        Me.checkDocumentos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMensual)
        Me.GroupBox1.Controls.Add(Me.rbFechas)
        Me.GroupBox1.Controls.Add(Me.rbClientes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(211, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 121)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo "
        '
        'rbMensual
        '
        Me.rbMensual.AutoSize = True
        Me.rbMensual.ForeColor = System.Drawing.Color.Navy
        Me.rbMensual.Location = New System.Drawing.Point(24, 85)
        Me.rbMensual.Name = "rbMensual"
        Me.rbMensual.Size = New System.Drawing.Size(64, 17)
        Me.rbMensual.TabIndex = 181
        Me.rbMensual.TabStop = True
        Me.rbMensual.Text = "Por Mes"
        Me.rbMensual.UseVisualStyleBackColor = True
        '
        'rbFechas
        '
        Me.rbFechas.AutoSize = True
        Me.rbFechas.ForeColor = System.Drawing.Color.Navy
        Me.rbFechas.Location = New System.Drawing.Point(24, 55)
        Me.rbFechas.Name = "rbFechas"
        Me.rbFechas.Size = New System.Drawing.Size(79, 17)
        Me.rbFechas.TabIndex = 180
        Me.rbFechas.TabStop = True
        Me.rbFechas.Text = "Por Fechas"
        Me.rbFechas.UseVisualStyleBackColor = True
        '
        'rbClientes
        '
        Me.rbClientes.AutoSize = True
        Me.rbClientes.Checked = True
        Me.rbClientes.ForeColor = System.Drawing.Color.Navy
        Me.rbClientes.Location = New System.Drawing.Point(24, 24)
        Me.rbClientes.Name = "rbClientes"
        Me.rbClientes.Size = New System.Drawing.Size(92, 17)
        Me.rbClientes.TabIndex = 178
        Me.rbClientes.TabStop = True
        Me.rbClientes.Text = "Por proveedor"
        Me.rbClientes.UseVisualStyleBackColor = True
        '
        'checkTodos
        '
        Me.checkTodos.AutoSize = True
        Me.checkTodos.ForeColor = System.Drawing.Color.Navy
        Me.checkTodos.Location = New System.Drawing.Point(365, 118)
        Me.checkTodos.Name = "checkTodos"
        Me.checkTodos.Size = New System.Drawing.Size(154, 17)
        Me.checkTodos.TabIndex = 177
        Me.checkTodos.Text = "&Marcar todos los Registros."
        Me.checkTodos.UseVisualStyleBackColor = True
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(16, 523)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 176
        Me.lblCantidad.Text = "."
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(12, 146)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(643, 47)
        Me.gbFiltros.TabIndex = 175
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(630, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        Me.dgvDocumentos.AllowUserToDeleteRows = False
        Me.dgvDocumentos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(12, 205)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(643, 312)
        Me.dgvDocumentos.TabIndex = 0
        '
        'pnlFecha
        '
        Me.pnlFecha.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlFecha.Controls.Add(Me.GroupBox2)
        Me.pnlFecha.Controls.Add(Me.GroupBox3)
        Me.pnlFecha.Location = New System.Drawing.Point(145, 32)
        Me.pnlFecha.Name = "pnlFecha"
        Me.pnlFecha.Size = New System.Drawing.Size(401, 225)
        Me.pnlFecha.TabIndex = 3
        Me.pnlFecha.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpFechafinal_emision)
        Me.GroupBox2.Controls.Add(Me.dtpFechainicial_emision)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(13, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emisión por Fechas"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(133, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 39)
        Me.Button1.TabIndex = 175
        Me.Button1.Text = "Mostrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(190, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha Final"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(194, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 39)
        Me.Button2.TabIndex = 176
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(7, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha Inicial"
        '
        'dtpFechafinal_emision
        '
        Me.dtpFechafinal_emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechafinal_emision.Location = New System.Drawing.Point(255, 24)
        Me.dtpFechafinal_emision.Name = "dtpFechafinal_emision"
        Me.dtpFechafinal_emision.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechafinal_emision.TabIndex = 1
        '
        'dtpFechainicial_emision
        '
        Me.dtpFechainicial_emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechainicial_emision.Location = New System.Drawing.Point(79, 24)
        Me.dtpFechainicial_emision.Name = "dtpFechainicial_emision"
        Me.dtpFechainicial_emision.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechainicial_emision.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_aceptar)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btn_close)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dtpFechafinal)
        Me.GroupBox3.Controls.Add(Me.dtpFechainicial)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(14, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 94)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vencimiento por Fechas"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_aceptar.Location = New System.Drawing.Point(133, 49)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(59, 39)
        Me.btn_aceptar.TabIndex = 175
        Me.btn_aceptar.Text = "Mostrar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(190, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Final"
        '
        'btn_close
        '
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_close.Location = New System.Drawing.Point(194, 49)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(59, 39)
        Me.btn_close.TabIndex = 176
        Me.btn_close.Text = "Salir"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicial"
        '
        'dtpFechafinal
        '
        Me.dtpFechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechafinal.Location = New System.Drawing.Point(255, 24)
        Me.dtpFechafinal.Name = "dtpFechafinal"
        Me.dtpFechafinal.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechafinal.TabIndex = 1
        '
        'dtpFechainicial
        '
        Me.dtpFechainicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechainicial.Location = New System.Drawing.Point(79, 24)
        Me.dtpFechainicial.Name = "dtpFechainicial"
        Me.dtpFechainicial.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechainicial.TabIndex = 0
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(121, 22)
        Me.btnMostrar.Text = "Mostrar Reporte"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(695, 25)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'pnlMensual
        '
        Me.pnlMensual.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlMensual.Controls.Add(Me.GroupBox4)
        Me.pnlMensual.Location = New System.Drawing.Point(204, 94)
        Me.pnlMensual.Name = "pnlMensual"
        Me.pnlMensual.Size = New System.Drawing.Size(270, 168)
        Me.pnlMensual.TabIndex = 18
        Me.pnlMensual.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdb_todos)
        Me.GroupBox4.Controls.Add(Me.rdb_pendiente)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.dtp_mensual)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(14, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 123)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Emision por Mes"
        '
        'rdb_todos
        '
        Me.rdb_todos.AutoSize = True
        Me.rdb_todos.Checked = True
        Me.rdb_todos.Location = New System.Drawing.Point(136, 50)
        Me.rdb_todos.Name = "rdb_todos"
        Me.rdb_todos.Size = New System.Drawing.Size(55, 17)
        Me.rdb_todos.TabIndex = 182
        Me.rdb_todos.TabStop = True
        Me.rdb_todos.Text = "Todos"
        Me.rdb_todos.UseVisualStyleBackColor = True
        '
        'rdb_pendiente
        '
        Me.rdb_pendiente.AutoSize = True
        Me.rdb_pendiente.Location = New System.Drawing.Point(50, 50)
        Me.rdb_pendiente.Name = "rdb_pendiente"
        Me.rdb_pendiente.Size = New System.Drawing.Size(72, 17)
        Me.rdb_pendiente.TabIndex = 181
        Me.rdb_pendiente.Text = "Con saldo"
        Me.rdb_pendiente.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(62, 73)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 37)
        Me.Button3.TabIndex = 175
        Me.Button3.Text = "&Mostrar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(123, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 37)
        Me.Button4.TabIndex = 176
        Me.Button4.Text = "&Salir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(7, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Fecha Inicial"
        '
        'dtp_mensual
        '
        Me.dtp_mensual.CustomFormat = "MMMM/yyyy"
        Me.dtp_mensual.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_mensual.Location = New System.Drawing.Point(79, 24)
        Me.dtp_mensual.Name = "dtp_mensual"
        Me.dtp_mensual.Size = New System.Drawing.Size(141, 20)
        Me.dtp_mensual.TabIndex = 0
        '
        'FrmReportePendienteCobro_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(695, 583)
        Me.Controls.Add(Me.pnlMensual)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlFecha)
        Me.Controls.Add(Me.gbReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReportePendienteCobro_Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte documentos pendientes de Pago"
        Me.gbReporte.ResumeLayout(False)
        Me.gbReporte.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFecha.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlMensual.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbReporte As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents checkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFechas As System.Windows.Forms.RadioButton
    Friend WithEvents rbClientes As System.Windows.Forms.RadioButton
    Friend WithEvents pnlFecha As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechainicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechafinal_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechainicial_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbMensual As System.Windows.Forms.RadioButton
    Friend WithEvents pnlMensual As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_mensual As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents chklstdocumentos As System.Windows.Forms.CheckedListBox
    Friend WithEvents checkDocumentos As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_todos As RadioButton
    Friend WithEvents rdb_pendiente As RadioButton
End Class
