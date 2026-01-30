<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OP_PLanta_Bandeja_Programacion_Despachos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_OP_PLanta_Bandeja_Programacion_Despachos))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProgramarDespManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_despachos_programados = New System.Windows.Forms.Panel()
        Me.chk_todos_estado = New System.Windows.Forms.CheckBox()
        Me.chk_todos_vehiculo = New System.Windows.Forms.CheckBox()
        Me.chk_todos_trans = New System.Windows.Forms.CheckBox()
        Me.txt_cod_estado = New System.Windows.Forms.TextBox()
        Me.txt_des_estado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cod_vehiculo_consulta = New System.Windows.Forms.TextBox()
        Me.txt_des_vehiculo_consulta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cod_trans_consulta = New System.Windows.Forms.TextBox()
        Me.txt_des_trans_consulta = New System.Windows.Forms.TextBox()
        Me.gb_cambio_trans_vehiculo = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cod_vehiculo_cambio = New System.Windows.Forms.TextBox()
        Me.txt_des_vehiculo_cambio = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cod_trans_cambio = New System.Windows.Forms.TextBox()
        Me.txt_des_trans_cambio = New System.Windows.Forms.TextBox()
        Me.GroupBox33 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.gb_cambio_depachos_programados = New System.Windows.Forms.GroupBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.dtp_fecha_nueva_despachos_programados = New System.Windows.Forms.DateTimePicker()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.dtp_ff_dp = New System.Windows.Forms.DateTimePicker()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.dtp_fi_dp = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button47 = New System.Windows.Forms.Button()
        Me.Button48 = New System.Windows.Forms.Button()
        Me.Button50 = New System.Windows.Forms.Button()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.dgv_detalle_despachos_programados = New System.Windows.Forms.DataGridView()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_todos_lineas_produccion_2 = New System.Windows.Forms.CheckBox()
        Me.txt_des_linea_produccion_2 = New System.Windows.Forms.TextBox()
        Me.txt_cod_linea_produccion_2 = New System.Windows.Forms.TextBox()
        Me.pnl_programar_Despachos = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.chk_fusionar = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cod_vehiculo = New System.Windows.Forms.TextBox()
        Me.txt_des_vehiculo = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.dtp_fecha_despacho = New System.Windows.Forms.DateTimePicker()
        Me.btn_prog_despacho_final = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod_trans = New System.Windows.Forms.TextBox()
        Me.txt_des_trans = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.chk_todos_lineas_produccion = New System.Windows.Forms.CheckBox()
        Me.txt_des_linea_produccion = New System.Windows.Forms.TextBox()
        Me.txt_cod_linea_produccion = New System.Windows.Forms.TextBox()
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.rdb_despacho_programado = New System.Windows.Forms.RadioButton()
        Me.rdb_programar_Despacho = New System.Windows.Forms.RadioButton()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.dgv_detalle_prog_despacho = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SecDespacho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO_INTERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HrEntregaAcordado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HrMaximoEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntodeSalida = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cantidad_Original = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGRESO_PROG_DESPACHO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.pnl_despacho_pedidos = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_vehiculo_despacho = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.txt_responsable_despacho = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnl_despachos_programados.SuspendLayout()
        Me.gb_cambio_trans_vehiculo.SuspendLayout()
        Me.GroupBox33.SuspendLayout()
        Me.gb_cambio_depachos_programados.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        CType(Me.dgv_detalle_despachos_programados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.pnl_programar_Despachos.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox32.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_detalle_prog_despacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_despacho_pedidos.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramarDespManualToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 26)
        '
        'ProgramarDespManualToolStripMenuItem
        '
        Me.ProgramarDespManualToolStripMenuItem.Image = CType(resources.GetObject("ProgramarDespManualToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProgramarDespManualToolStripMenuItem.Name = "ProgramarDespManualToolStripMenuItem"
        Me.ProgramarDespManualToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ProgramarDespManualToolStripMenuItem.Text = "Despacho manual"
        '
        'pnl_despachos_programados
        '
        Me.pnl_despachos_programados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_despachos_programados.BackColor = System.Drawing.Color.White
        Me.pnl_despachos_programados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_despachos_programados.Controls.Add(Me.chk_todos_estado)
        Me.pnl_despachos_programados.Controls.Add(Me.chk_todos_vehiculo)
        Me.pnl_despachos_programados.Controls.Add(Me.chk_todos_trans)
        Me.pnl_despachos_programados.Controls.Add(Me.txt_cod_estado)
        Me.pnl_despachos_programados.Controls.Add(Me.txt_des_estado)
        Me.pnl_despachos_programados.Controls.Add(Me.Label8)
        Me.pnl_despachos_programados.Controls.Add(Me.Label5)
        Me.pnl_despachos_programados.Controls.Add(Me.txt_cod_vehiculo_consulta)
        Me.pnl_despachos_programados.Controls.Add(Me.txt_des_vehiculo_consulta)
        Me.pnl_despachos_programados.Controls.Add(Me.Label7)
        Me.pnl_despachos_programados.Controls.Add(Me.txt_cod_trans_consulta)
        Me.pnl_despachos_programados.Controls.Add(Me.txt_des_trans_consulta)
        Me.pnl_despachos_programados.Controls.Add(Me.gb_cambio_trans_vehiculo)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox33)
        Me.pnl_despachos_programados.Controls.Add(Me.Button38)
        Me.pnl_despachos_programados.Controls.Add(Me.gb_cambio_depachos_programados)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox24)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox25)
        Me.pnl_despachos_programados.Controls.Add(Me.Button50)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox26)
        Me.pnl_despachos_programados.Controls.Add(Me.TextBox13)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox2)
        Me.pnl_despachos_programados.Location = New System.Drawing.Point(12, 7)
        Me.pnl_despachos_programados.Name = "pnl_despachos_programados"
        Me.pnl_despachos_programados.Size = New System.Drawing.Size(1059, 578)
        Me.pnl_despachos_programados.TabIndex = 216
        Me.pnl_despachos_programados.Visible = False
        '
        'chk_todos_estado
        '
        Me.chk_todos_estado.AutoSize = True
        Me.chk_todos_estado.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_estado.Location = New System.Drawing.Point(558, 104)
        Me.chk_todos_estado.Name = "chk_todos_estado"
        Me.chk_todos_estado.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos_estado.TabIndex = 294
        Me.chk_todos_estado.Text = "Todos"
        Me.chk_todos_estado.UseVisualStyleBackColor = True
        '
        'chk_todos_vehiculo
        '
        Me.chk_todos_vehiculo.AutoSize = True
        Me.chk_todos_vehiculo.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_vehiculo.Location = New System.Drawing.Point(558, 73)
        Me.chk_todos_vehiculo.Name = "chk_todos_vehiculo"
        Me.chk_todos_vehiculo.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos_vehiculo.TabIndex = 293
        Me.chk_todos_vehiculo.Text = "Todos"
        Me.chk_todos_vehiculo.UseVisualStyleBackColor = True
        '
        'chk_todos_trans
        '
        Me.chk_todos_trans.AutoSize = True
        Me.chk_todos_trans.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_trans.Location = New System.Drawing.Point(558, 44)
        Me.chk_todos_trans.Name = "chk_todos_trans"
        Me.chk_todos_trans.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos_trans.TabIndex = 292
        Me.chk_todos_trans.Text = "Todos"
        Me.chk_todos_trans.UseVisualStyleBackColor = True
        '
        'txt_cod_estado
        '
        Me.txt_cod_estado.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_estado.Location = New System.Drawing.Point(283, 102)
        Me.txt_cod_estado.Name = "txt_cod_estado"
        Me.txt_cod_estado.ReadOnly = True
        Me.txt_cod_estado.Size = New System.Drawing.Size(41, 20)
        Me.txt_cod_estado.TabIndex = 291
        '
        'txt_des_estado
        '
        Me.txt_des_estado.BackColor = System.Drawing.Color.White
        Me.txt_des_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_estado.Enabled = False
        Me.txt_des_estado.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_estado.Location = New System.Drawing.Point(330, 102)
        Me.txt_des_estado.MaxLength = 200
        Me.txt_des_estado.Name = "txt_des_estado"
        Me.txt_des_estado.ReadOnly = True
        Me.txt_des_estado.Size = New System.Drawing.Size(221, 20)
        Me.txt_des_estado.TabIndex = 290
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(239, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 289
        Me.Label8.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(231, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 288
        Me.Label5.Text = "Vehiculo"
        '
        'txt_cod_vehiculo_consulta
        '
        Me.txt_cod_vehiculo_consulta.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_vehiculo_consulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_vehiculo_consulta.Location = New System.Drawing.Point(283, 71)
        Me.txt_cod_vehiculo_consulta.Name = "txt_cod_vehiculo_consulta"
        Me.txt_cod_vehiculo_consulta.ReadOnly = True
        Me.txt_cod_vehiculo_consulta.Size = New System.Drawing.Size(41, 20)
        Me.txt_cod_vehiculo_consulta.TabIndex = 287
        '
        'txt_des_vehiculo_consulta
        '
        Me.txt_des_vehiculo_consulta.BackColor = System.Drawing.Color.White
        Me.txt_des_vehiculo_consulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_vehiculo_consulta.Enabled = False
        Me.txt_des_vehiculo_consulta.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_vehiculo_consulta.Location = New System.Drawing.Point(330, 71)
        Me.txt_des_vehiculo_consulta.MaxLength = 200
        Me.txt_des_vehiculo_consulta.Name = "txt_des_vehiculo_consulta"
        Me.txt_des_vehiculo_consulta.ReadOnly = True
        Me.txt_des_vehiculo_consulta.Size = New System.Drawing.Size(221, 20)
        Me.txt_des_vehiculo_consulta.TabIndex = 286
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(211, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 285
        Me.Label7.Text = "Transportista"
        '
        'txt_cod_trans_consulta
        '
        Me.txt_cod_trans_consulta.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_trans_consulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_trans_consulta.Location = New System.Drawing.Point(283, 42)
        Me.txt_cod_trans_consulta.Name = "txt_cod_trans_consulta"
        Me.txt_cod_trans_consulta.ReadOnly = True
        Me.txt_cod_trans_consulta.Size = New System.Drawing.Size(41, 20)
        Me.txt_cod_trans_consulta.TabIndex = 284
        '
        'txt_des_trans_consulta
        '
        Me.txt_des_trans_consulta.BackColor = System.Drawing.Color.White
        Me.txt_des_trans_consulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_trans_consulta.Enabled = False
        Me.txt_des_trans_consulta.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_trans_consulta.Location = New System.Drawing.Point(330, 42)
        Me.txt_des_trans_consulta.MaxLength = 200
        Me.txt_des_trans_consulta.Name = "txt_des_trans_consulta"
        Me.txt_des_trans_consulta.ReadOnly = True
        Me.txt_des_trans_consulta.Size = New System.Drawing.Size(221, 20)
        Me.txt_des_trans_consulta.TabIndex = 283
        '
        'gb_cambio_trans_vehiculo
        '
        Me.gb_cambio_trans_vehiculo.BackColor = System.Drawing.Color.White
        Me.gb_cambio_trans_vehiculo.Controls.Add(Me.Label4)
        Me.gb_cambio_trans_vehiculo.Controls.Add(Me.txt_cod_vehiculo_cambio)
        Me.gb_cambio_trans_vehiculo.Controls.Add(Me.txt_des_vehiculo_cambio)
        Me.gb_cambio_trans_vehiculo.Controls.Add(Me.Button2)
        Me.gb_cambio_trans_vehiculo.Controls.Add(Me.Label6)
        Me.gb_cambio_trans_vehiculo.Controls.Add(Me.txt_cod_trans_cambio)
        Me.gb_cambio_trans_vehiculo.Controls.Add(Me.txt_des_trans_cambio)
        Me.gb_cambio_trans_vehiculo.ForeColor = System.Drawing.Color.Navy
        Me.gb_cambio_trans_vehiculo.Location = New System.Drawing.Point(314, 145)
        Me.gb_cambio_trans_vehiculo.Name = "gb_cambio_trans_vehiculo"
        Me.gb_cambio_trans_vehiculo.Size = New System.Drawing.Size(608, 82)
        Me.gb_cambio_trans_vehiculo.TabIndex = 282
        Me.gb_cambio_trans_vehiculo.TabStop = False
        Me.gb_cambio_trans_vehiculo.Text = "Cambio de Trans. y Vehiculo"
        Me.gb_cambio_trans_vehiculo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(24, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 277
        Me.Label4.Text = "Vehiculo"
        '
        'txt_cod_vehiculo_cambio
        '
        Me.txt_cod_vehiculo_cambio.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_vehiculo_cambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_vehiculo_cambio.Location = New System.Drawing.Point(76, 50)
        Me.txt_cod_vehiculo_cambio.Name = "txt_cod_vehiculo_cambio"
        Me.txt_cod_vehiculo_cambio.ReadOnly = True
        Me.txt_cod_vehiculo_cambio.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod_vehiculo_cambio.TabIndex = 276
        '
        'txt_des_vehiculo_cambio
        '
        Me.txt_des_vehiculo_cambio.BackColor = System.Drawing.Color.White
        Me.txt_des_vehiculo_cambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_vehiculo_cambio.Enabled = False
        Me.txt_des_vehiculo_cambio.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_vehiculo_cambio.Location = New System.Drawing.Point(151, 50)
        Me.txt_des_vehiculo_cambio.MaxLength = 200
        Me.txt_des_vehiculo_cambio.Name = "txt_des_vehiculo_cambio"
        Me.txt_des_vehiculo_cambio.ReadOnly = True
        Me.txt_des_vehiculo_cambio.Size = New System.Drawing.Size(323, 20)
        Me.txt_des_vehiculo_cambio.TabIndex = 275
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(483, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 23)
        Me.Button2.TabIndex = 271
        Me.Button2.Text = "Confirmar cambio"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(4, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 270
        Me.Label6.Text = "Transportista"
        '
        'txt_cod_trans_cambio
        '
        Me.txt_cod_trans_cambio.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_trans_cambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_trans_cambio.Location = New System.Drawing.Point(76, 21)
        Me.txt_cod_trans_cambio.Name = "txt_cod_trans_cambio"
        Me.txt_cod_trans_cambio.ReadOnly = True
        Me.txt_cod_trans_cambio.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod_trans_cambio.TabIndex = 188
        '
        'txt_des_trans_cambio
        '
        Me.txt_des_trans_cambio.BackColor = System.Drawing.Color.White
        Me.txt_des_trans_cambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_trans_cambio.Enabled = False
        Me.txt_des_trans_cambio.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_trans_cambio.Location = New System.Drawing.Point(151, 21)
        Me.txt_des_trans_cambio.MaxLength = 200
        Me.txt_des_trans_cambio.Name = "txt_des_trans_cambio"
        Me.txt_des_trans_cambio.ReadOnly = True
        Me.txt_des_trans_cambio.Size = New System.Drawing.Size(323, 20)
        Me.txt_des_trans_cambio.TabIndex = 186
        '
        'GroupBox33
        '
        Me.GroupBox33.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox33.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox33.Controls.Add(Me.RadioButton3)
        Me.GroupBox33.Controls.Add(Me.RadioButton4)
        Me.GroupBox33.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox33.Location = New System.Drawing.Point(739, 25)
        Me.GroupBox33.Name = "GroupBox33"
        Me.GroupBox33.Size = New System.Drawing.Size(315, 41)
        Me.GroupBox33.TabIndex = 280
        Me.GroupBox33.TabStop = False
        Me.GroupBox33.Text = "Opción"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(169, 16)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(144, 17)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Despachos Programados"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(16, 16)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(130, 17)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.Text = "Programar Despachos"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button38.ForeColor = System.Drawing.Color.Navy
        Me.Button38.Image = CType(resources.GetObject("Button38.Image"), System.Drawing.Image)
        Me.Button38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button38.Location = New System.Drawing.Point(647, 101)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(85, 23)
        Me.Button38.TabIndex = 276
        Me.Button38.Text = "Reportar"
        Me.Button38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button38.UseVisualStyleBackColor = True
        '
        'gb_cambio_depachos_programados
        '
        Me.gb_cambio_depachos_programados.Controls.Add(Me.Label89)
        Me.gb_cambio_depachos_programados.Controls.Add(Me.dtp_fecha_nueva_despachos_programados)
        Me.gb_cambio_depachos_programados.Controls.Add(Me.Button34)
        Me.gb_cambio_depachos_programados.ForeColor = System.Drawing.Color.Navy
        Me.gb_cambio_depachos_programados.Location = New System.Drawing.Point(314, 145)
        Me.gb_cambio_depachos_programados.Name = "gb_cambio_depachos_programados"
        Me.gb_cambio_depachos_programados.Size = New System.Drawing.Size(292, 50)
        Me.gb_cambio_depachos_programados.TabIndex = 272
        Me.gb_cambio_depachos_programados.TabStop = False
        Me.gb_cambio_depachos_programados.Text = "Cambio de Fecha - Programación"
        Me.gb_cambio_depachos_programados.Visible = False
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.ForeColor = System.Drawing.Color.Navy
        Me.Label89.Location = New System.Drawing.Point(10, 22)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(37, 13)
        Me.Label89.TabIndex = 273
        Me.Label89.Text = "Fecha"
        '
        'dtp_fecha_nueva_despachos_programados
        '
        Me.dtp_fecha_nueva_despachos_programados.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_nueva_despachos_programados.Checked = False
        Me.dtp_fecha_nueva_despachos_programados.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_nueva_despachos_programados.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nueva_despachos_programados.Location = New System.Drawing.Point(53, 17)
        Me.dtp_fecha_nueva_despachos_programados.Name = "dtp_fecha_nueva_despachos_programados"
        Me.dtp_fecha_nueva_despachos_programados.Size = New System.Drawing.Size(95, 24)
        Me.dtp_fecha_nueva_despachos_programados.TabIndex = 272
        Me.dtp_fecha_nueva_despachos_programados.Tag = ""
        '
        'Button34
        '
        Me.Button34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.ForeColor = System.Drawing.Color.Navy
        Me.Button34.Image = CType(resources.GetObject("Button34.Image"), System.Drawing.Image)
        Me.Button34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button34.Location = New System.Drawing.Point(165, 17)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(119, 23)
        Me.Button34.TabIndex = 269
        Me.Button34.Text = "Confirmar cambio"
        Me.Button34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button34.UseVisualStyleBackColor = True
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.Label87)
        Me.GroupBox24.Controls.Add(Me.dtp_ff_dp)
        Me.GroupBox24.Controls.Add(Me.Label88)
        Me.GroupBox24.Controls.Add(Me.dtp_fi_dp)
        Me.GroupBox24.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox24.Location = New System.Drawing.Point(11, 23)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(190, 107)
        Me.GroupBox24.TabIndex = 271
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Rango de Fechas de Programación"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.ForeColor = System.Drawing.Color.Navy
        Me.Label87.Location = New System.Drawing.Point(18, 61)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(21, 13)
        Me.Label87.TabIndex = 273
        Me.Label87.Text = "Fin"
        '
        'dtp_ff_dp
        '
        Me.dtp_ff_dp.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_ff_dp.Checked = False
        Me.dtp_ff_dp.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ff_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ff_dp.Location = New System.Drawing.Point(56, 56)
        Me.dtp_ff_dp.Name = "dtp_ff_dp"
        Me.dtp_ff_dp.Size = New System.Drawing.Size(95, 24)
        Me.dtp_ff_dp.TabIndex = 272
        Me.dtp_ff_dp.Tag = ""
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.ForeColor = System.Drawing.Color.Navy
        Me.Label88.Location = New System.Drawing.Point(18, 24)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(32, 13)
        Me.Label88.TabIndex = 271
        Me.Label88.Text = "Inicio"
        '
        'dtp_fi_dp
        '
        Me.dtp_fi_dp.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fi_dp.Checked = False
        Me.dtp_fi_dp.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fi_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fi_dp.Location = New System.Drawing.Point(56, 19)
        Me.dtp_fi_dp.Name = "dtp_fi_dp"
        Me.dtp_fi_dp.Size = New System.Drawing.Size(95, 24)
        Me.dtp_fi_dp.TabIndex = 270
        Me.dtp_fi_dp.Tag = ""
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.Button1)
        Me.GroupBox25.Controls.Add(Me.Button37)
        Me.GroupBox25.Controls.Add(Me.Button47)
        Me.GroupBox25.Controls.Add(Me.Button48)
        Me.GroupBox25.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox25.Location = New System.Drawing.Point(10, 145)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(295, 82)
        Me.GroupBox25.TabIndex = 270
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Cambios en Despachos Programados"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(122, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 23)
        Me.Button1.TabIndex = 271
        Me.Button1.Text = "Cambiar Trans. y Vehiculo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button37
        '
        Me.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button37.ForeColor = System.Drawing.Color.Navy
        Me.Button37.Image = CType(resources.GetObject("Button37.Image"), System.Drawing.Image)
        Me.Button37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button37.Location = New System.Drawing.Point(9, 17)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(108, 23)
        Me.Button37.TabIndex = 270
        Me.Button37.Text = "Act. Correlativo"
        Me.Button37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button37.UseVisualStyleBackColor = True
        '
        'Button47
        '
        Me.Button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button47.ForeColor = System.Drawing.Color.Navy
        Me.Button47.Image = CType(resources.GetObject("Button47.Image"), System.Drawing.Image)
        Me.Button47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button47.Location = New System.Drawing.Point(9, 48)
        Me.Button47.Name = "Button47"
        Me.Button47.Size = New System.Drawing.Size(108, 23)
        Me.Button47.TabIndex = 269
        Me.Button47.Text = "Cambiar Fecha"
        Me.Button47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button47.UseVisualStyleBackColor = True
        '
        'Button48
        '
        Me.Button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button48.ForeColor = System.Drawing.Color.Navy
        Me.Button48.Image = CType(resources.GetObject("Button48.Image"), System.Drawing.Image)
        Me.Button48.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button48.Location = New System.Drawing.Point(122, 17)
        Me.Button48.Name = "Button48"
        Me.Button48.Size = New System.Drawing.Size(163, 23)
        Me.Button48.TabIndex = 268
        Me.Button48.Text = "Deshacer Programación"
        Me.Button48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button48.UseVisualStyleBackColor = True
        '
        'Button50
        '
        Me.Button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button50.ForeColor = System.Drawing.Color.Navy
        Me.Button50.Image = CType(resources.GetObject("Button50.Image"), System.Drawing.Image)
        Me.Button50.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button50.Location = New System.Drawing.Point(647, 73)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(85, 23)
        Me.Button50.TabIndex = 265
        Me.Button50.Text = "Consultar"
        Me.Button50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button50.UseVisualStyleBackColor = True
        '
        'GroupBox26
        '
        Me.GroupBox26.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox26.Controls.Add(Me.dgv_detalle_despachos_programados)
        Me.GroupBox26.Location = New System.Drawing.Point(10, 233)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(1044, 330)
        Me.GroupBox26.TabIndex = 170
        Me.GroupBox26.TabStop = False
        '
        'dgv_detalle_despachos_programados
        '
        Me.dgv_detalle_despachos_programados.AllowUserToAddRows = False
        Me.dgv_detalle_despachos_programados.AllowUserToDeleteRows = False
        Me.dgv_detalle_despachos_programados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_despachos_programados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_detalle_despachos_programados.Location = New System.Drawing.Point(3, 16)
        Me.dgv_detalle_despachos_programados.Name = "dgv_detalle_despachos_programados"
        Me.dgv_detalle_despachos_programados.Size = New System.Drawing.Size(1038, 311)
        Me.dgv_detalle_despachos_programados.TabIndex = 265
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.Navy
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox13.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.ForeColor = System.Drawing.Color.White
        Me.TextBox13.Location = New System.Drawing.Point(0, 0)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(1057, 20)
        Me.TextBox13.TabIndex = 169
        Me.TextBox13.Text = "DESPACHOS PROGRAMADOS"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_todos_lineas_produccion_2)
        Me.GroupBox2.Controls.Add(Me.txt_des_linea_produccion_2)
        Me.GroupBox2.Controls.Add(Me.txt_cod_linea_produccion_2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(11, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 71)
        Me.GroupBox2.TabIndex = 281
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lineas de Producción"
        Me.GroupBox2.Visible = False
        '
        'chk_todos_lineas_produccion_2
        '
        Me.chk_todos_lineas_produccion_2.AutoSize = True
        Me.chk_todos_lineas_produccion_2.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_lineas_produccion_2.Location = New System.Drawing.Point(13, 20)
        Me.chk_todos_lineas_produccion_2.Name = "chk_todos_lineas_produccion_2"
        Me.chk_todos_lineas_produccion_2.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos_lineas_produccion_2.TabIndex = 182
        Me.chk_todos_lineas_produccion_2.Text = "Todos"
        Me.chk_todos_lineas_produccion_2.UseVisualStyleBackColor = True
        '
        'txt_des_linea_produccion_2
        '
        Me.txt_des_linea_produccion_2.BackColor = System.Drawing.Color.White
        Me.txt_des_linea_produccion_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_linea_produccion_2.Location = New System.Drawing.Point(91, 40)
        Me.txt_des_linea_produccion_2.Name = "txt_des_linea_produccion_2"
        Me.txt_des_linea_produccion_2.ReadOnly = True
        Me.txt_des_linea_produccion_2.Size = New System.Drawing.Size(284, 20)
        Me.txt_des_linea_produccion_2.TabIndex = 180
        '
        'txt_cod_linea_produccion_2
        '
        Me.txt_cod_linea_produccion_2.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_linea_produccion_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_linea_produccion_2.Location = New System.Drawing.Point(13, 40)
        Me.txt_cod_linea_produccion_2.Name = "txt_cod_linea_produccion_2"
        Me.txt_cod_linea_produccion_2.ReadOnly = True
        Me.txt_cod_linea_produccion_2.Size = New System.Drawing.Size(68, 20)
        Me.txt_cod_linea_produccion_2.TabIndex = 176
        '
        'pnl_programar_Despachos
        '
        Me.pnl_programar_Despachos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_programar_Despachos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnl_programar_Despachos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_programar_Despachos.Controls.Add(Me.Button3)
        Me.pnl_programar_Despachos.Controls.Add(Me.GroupBox14)
        Me.pnl_programar_Despachos.Controls.Add(Me.GroupBox1)
        Me.pnl_programar_Despachos.Controls.Add(Me.GroupBox32)
        Me.pnl_programar_Despachos.Controls.Add(Me.GroupBox27)
        Me.pnl_programar_Despachos.Controls.Add(Me.TextBox17)
        Me.pnl_programar_Despachos.Location = New System.Drawing.Point(12, 7)
        Me.pnl_programar_Despachos.Name = "pnl_programar_Despachos"
        Me.pnl_programar_Despachos.Size = New System.Drawing.Size(1058, 578)
        Me.pnl_programar_Despachos.TabIndex = 215
        Me.pnl_programar_Despachos.Visible = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(331, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 23)
        Me.Button3.TabIndex = 282
        Me.Button3.Text = "Programar recojo"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.BackColor = System.Drawing.Color.White
        Me.GroupBox14.Controls.Add(Me.chk_fusionar)
        Me.GroupBox14.Controls.Add(Me.Label2)
        Me.GroupBox14.Controls.Add(Me.txt_cod_vehiculo)
        Me.GroupBox14.Controls.Add(Me.txt_des_vehiculo)
        Me.GroupBox14.Controls.Add(Me.TextBox1)
        Me.GroupBox14.Controls.Add(Me.Label91)
        Me.GroupBox14.Controls.Add(Me.dtp_fecha_despacho)
        Me.GroupBox14.Controls.Add(Me.btn_prog_despacho_final)
        Me.GroupBox14.Controls.Add(Me.Label1)
        Me.GroupBox14.Controls.Add(Me.txt_cod_trans)
        Me.GroupBox14.Controls.Add(Me.txt_des_trans)
        Me.GroupBox14.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox14.Location = New System.Drawing.Point(554, 24)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(490, 132)
        Me.GroupBox14.TabIndex = 281
        Me.GroupBox14.TabStop = False
        '
        'chk_fusionar
        '
        Me.chk_fusionar.AutoSize = True
        Me.chk_fusionar.ForeColor = System.Drawing.Color.Navy
        Me.chk_fusionar.Location = New System.Drawing.Point(76, 76)
        Me.chk_fusionar.Name = "chk_fusionar"
        Me.chk_fusionar.Size = New System.Drawing.Size(185, 17)
        Me.chk_fusionar.TabIndex = 279
        Me.chk_fusionar.Text = "Fusionar OPs a un solo despacho"
        Me.chk_fusionar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(24, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 277
        Me.Label2.Text = "Vehiculo"
        '
        'txt_cod_vehiculo
        '
        Me.txt_cod_vehiculo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_vehiculo.Location = New System.Drawing.Point(76, 50)
        Me.txt_cod_vehiculo.Name = "txt_cod_vehiculo"
        Me.txt_cod_vehiculo.ReadOnly = True
        Me.txt_cod_vehiculo.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod_vehiculo.TabIndex = 276
        '
        'txt_des_vehiculo
        '
        Me.txt_des_vehiculo.BackColor = System.Drawing.Color.White
        Me.txt_des_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_vehiculo.Enabled = False
        Me.txt_des_vehiculo.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_vehiculo.Location = New System.Drawing.Point(151, 50)
        Me.txt_des_vehiculo.MaxLength = 200
        Me.txt_des_vehiculo.Name = "txt_des_vehiculo"
        Me.txt_des_vehiculo.ReadOnly = True
        Me.txt_des_vehiculo.Size = New System.Drawing.Size(331, 20)
        Me.txt_des_vehiculo.TabIndex = 275
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-6, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(497, 20)
        Me.TextBox1.TabIndex = 274
        Me.TextBox1.Text = "DATOS DE DESPACHO"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label91
        '
        Me.Label91.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label91.AutoSize = True
        Me.Label91.ForeColor = System.Drawing.Color.Navy
        Me.Label91.Location = New System.Drawing.Point(35, 104)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(37, 13)
        Me.Label91.TabIndex = 273
        Me.Label91.Text = "Fecha"
        '
        'dtp_fecha_despacho
        '
        Me.dtp_fecha_despacho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_fecha_despacho.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_despacho.Checked = False
        Me.dtp_fecha_despacho.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_despacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_despacho.Location = New System.Drawing.Point(76, 98)
        Me.dtp_fecha_despacho.Name = "dtp_fecha_despacho"
        Me.dtp_fecha_despacho.Size = New System.Drawing.Size(95, 24)
        Me.dtp_fecha_despacho.TabIndex = 272
        Me.dtp_fecha_despacho.Tag = ""
        '
        'btn_prog_despacho_final
        '
        Me.btn_prog_despacho_final.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_prog_despacho_final.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prog_despacho_final.ForeColor = System.Drawing.Color.Navy
        Me.btn_prog_despacho_final.Image = CType(resources.GetObject("btn_prog_despacho_final.Image"), System.Drawing.Image)
        Me.btn_prog_despacho_final.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prog_despacho_final.Location = New System.Drawing.Point(186, 99)
        Me.btn_prog_despacho_final.Name = "btn_prog_despacho_final"
        Me.btn_prog_despacho_final.Size = New System.Drawing.Size(140, 23)
        Me.btn_prog_despacho_final.TabIndex = 271
        Me.btn_prog_despacho_final.Text = "Programar Despachos"
        Me.btn_prog_despacho_final.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_prog_despacho_final.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(4, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "Transportista"
        '
        'txt_cod_trans
        '
        Me.txt_cod_trans.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_trans.Location = New System.Drawing.Point(76, 27)
        Me.txt_cod_trans.Name = "txt_cod_trans"
        Me.txt_cod_trans.ReadOnly = True
        Me.txt_cod_trans.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod_trans.TabIndex = 188
        '
        'txt_des_trans
        '
        Me.txt_des_trans.BackColor = System.Drawing.Color.White
        Me.txt_des_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_trans.Enabled = False
        Me.txt_des_trans.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_trans.Location = New System.Drawing.Point(151, 27)
        Me.txt_des_trans.MaxLength = 200
        Me.txt_des_trans.Name = "txt_des_trans"
        Me.txt_des_trans.ReadOnly = True
        Me.txt_des_trans.Size = New System.Drawing.Size(331, 20)
        Me.txt_des_trans.TabIndex = 186
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_mostrar)
        Me.GroupBox1.Controls.Add(Me.chk_todos_lineas_produccion)
        Me.GroupBox1.Controls.Add(Me.txt_des_linea_produccion)
        Me.GroupBox1.Controls.Add(Me.txt_cod_linea_produccion)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(10, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 71)
        Me.GroupBox1.TabIndex = 280
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mostrar.ForeColor = System.Drawing.Color.Navy
        Me.btn_mostrar.Image = CType(resources.GetObject("btn_mostrar.Image"), System.Drawing.Image)
        Me.btn_mostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mostrar.Location = New System.Drawing.Point(418, 39)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(77, 23)
        Me.btn_mostrar.TabIndex = 268
        Me.btn_mostrar.Text = "Mostrar"
        Me.btn_mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'chk_todos_lineas_produccion
        '
        Me.chk_todos_lineas_produccion.AutoSize = True
        Me.chk_todos_lineas_produccion.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_lineas_produccion.Location = New System.Drawing.Point(13, 20)
        Me.chk_todos_lineas_produccion.Name = "chk_todos_lineas_produccion"
        Me.chk_todos_lineas_produccion.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos_lineas_produccion.TabIndex = 182
        Me.chk_todos_lineas_produccion.Text = "Todos"
        Me.chk_todos_lineas_produccion.UseVisualStyleBackColor = True
        '
        'txt_des_linea_produccion
        '
        Me.txt_des_linea_produccion.BackColor = System.Drawing.Color.White
        Me.txt_des_linea_produccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_linea_produccion.Location = New System.Drawing.Point(127, 40)
        Me.txt_des_linea_produccion.Name = "txt_des_linea_produccion"
        Me.txt_des_linea_produccion.ReadOnly = True
        Me.txt_des_linea_produccion.Size = New System.Drawing.Size(284, 20)
        Me.txt_des_linea_produccion.TabIndex = 180
        '
        'txt_cod_linea_produccion
        '
        Me.txt_cod_linea_produccion.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_linea_produccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_linea_produccion.Location = New System.Drawing.Point(13, 40)
        Me.txt_cod_linea_produccion.Name = "txt_cod_linea_produccion"
        Me.txt_cod_linea_produccion.ReadOnly = True
        Me.txt_cod_linea_produccion.Size = New System.Drawing.Size(109, 20)
        Me.txt_cod_linea_produccion.TabIndex = 176
        '
        'GroupBox32
        '
        Me.GroupBox32.Controls.Add(Me.rdb_despacho_programado)
        Me.GroupBox32.Controls.Add(Me.rdb_programar_Despacho)
        Me.GroupBox32.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox32.Location = New System.Drawing.Point(10, 20)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(315, 41)
        Me.GroupBox32.TabIndex = 279
        Me.GroupBox32.TabStop = False
        Me.GroupBox32.Text = "Opción"
        '
        'rdb_despacho_programado
        '
        Me.rdb_despacho_programado.AutoSize = True
        Me.rdb_despacho_programado.Location = New System.Drawing.Point(169, 16)
        Me.rdb_despacho_programado.Name = "rdb_despacho_programado"
        Me.rdb_despacho_programado.Size = New System.Drawing.Size(144, 17)
        Me.rdb_despacho_programado.TabIndex = 1
        Me.rdb_despacho_programado.Text = "Despachos Programados"
        Me.rdb_despacho_programado.UseVisualStyleBackColor = True
        '
        'rdb_programar_Despacho
        '
        Me.rdb_programar_Despacho.AutoSize = True
        Me.rdb_programar_Despacho.Checked = True
        Me.rdb_programar_Despacho.Location = New System.Drawing.Point(16, 16)
        Me.rdb_programar_Despacho.Name = "rdb_programar_Despacho"
        Me.rdb_programar_Despacho.Size = New System.Drawing.Size(130, 17)
        Me.rdb_programar_Despacho.TabIndex = 0
        Me.rdb_programar_Despacho.TabStop = True
        Me.rdb_programar_Despacho.Text = "Programar Despachos"
        Me.rdb_programar_Despacho.UseVisualStyleBackColor = True
        '
        'GroupBox27
        '
        Me.GroupBox27.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox27.Controls.Add(Me.btn_confirmar)
        Me.GroupBox27.Controls.Add(Me.Label3)
        Me.GroupBox27.Controls.Add(Me.dgvDetalle)
        Me.GroupBox27.Controls.Add(Me.dgv_detalle_prog_despacho)
        Me.GroupBox27.Location = New System.Drawing.Point(10, 183)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(1034, 386)
        Me.GroupBox27.TabIndex = 170
        Me.GroupBox27.TabStop = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.ForeColor = System.Drawing.Color.Navy
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmar.Location = New System.Drawing.Point(880, 309)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(88, 23)
        Me.btn_confirmar.TabIndex = 272
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(3, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 13)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "&Detalles del Documento Seleccionado"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(3, 309)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(867, 66)
        Me.dgvDetalle.TabIndex = 266
        '
        'dgv_detalle_prog_despacho
        '
        Me.dgv_detalle_prog_despacho.AllowUserToAddRows = False
        Me.dgv_detalle_prog_despacho.AllowUserToDeleteRows = False
        Me.dgv_detalle_prog_despacho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalle_prog_despacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_prog_despacho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.SecDespacho, Me.CODIGO_INTERNO, Me.NOP, Me.FechaEntrega, Me.Cliente, Me.Producto, Me.UM, Me.Cantidad, Me.HrEntregaAcordado, Me.HrMaximoEntrega, Me.Vendedor, Me.Observaciones, Me.PuntodeSalida, Me.Cantidad_Original, Me.Email, Me.REGRESO_PROG_DESPACHO, Me.EMPRESA})
        Me.dgv_detalle_prog_despacho.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv_detalle_prog_despacho.Location = New System.Drawing.Point(3, 16)
        Me.dgv_detalle_prog_despacho.Name = "dgv_detalle_prog_despacho"
        Me.dgv_detalle_prog_despacho.Size = New System.Drawing.Size(1028, 262)
        Me.dgv_detalle_prog_despacho.TabIndex = 265
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel"
        Me.Sel.Name = "Sel"
        Me.Sel.Width = 30
        '
        'SecDespacho
        '
        Me.SecDespacho.DataPropertyName = "SecDespacho"
        Me.SecDespacho.HeaderText = "Sec. Prog."
        Me.SecDespacho.Name = "SecDespacho"
        Me.SecDespacho.ReadOnly = True
        Me.SecDespacho.Width = 50
        '
        'CODIGO_INTERNO
        '
        Me.CODIGO_INTERNO.DataPropertyName = "CODIGO_INTERNO"
        Me.CODIGO_INTERNO.HeaderText = "CODIGO_INTERNO"
        Me.CODIGO_INTERNO.Name = "CODIGO_INTERNO"
        Me.CODIGO_INTERNO.ReadOnly = True
        Me.CODIGO_INTERNO.Visible = False
        '
        'NOP
        '
        Me.NOP.DataPropertyName = "NOP"
        Me.NOP.HeaderText = "N° Pedido"
        Me.NOP.Name = "NOP"
        Me.NOP.ReadOnly = True
        Me.NOP.Width = 50
        '
        'FechaEntrega
        '
        Me.FechaEntrega.DataPropertyName = "FechaEntrega"
        Me.FechaEntrega.HeaderText = "Fecha"
        Me.FechaEntrega.Name = "FechaEntrega"
        Me.FechaEntrega.ReadOnly = True
        Me.FechaEntrega.Width = 70
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 150
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "Producto"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Visible = False
        Me.Producto.Width = 150
        '
        'UM
        '
        Me.UM.DataPropertyName = "UM"
        Me.UM.HeaderText = "U.M."
        Me.UM.Name = "UM"
        Me.UM.Visible = False
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Visible = False
        '
        'HrEntregaAcordado
        '
        Me.HrEntregaAcordado.DataPropertyName = "HrEntregaAcordado"
        Me.HrEntregaAcordado.HeaderText = "Hr. Entrega Acordado"
        Me.HrEntregaAcordado.Name = "HrEntregaAcordado"
        Me.HrEntregaAcordado.Visible = False
        '
        'HrMaximoEntrega
        '
        Me.HrMaximoEntrega.DataPropertyName = "HrMaximoEntrega"
        Me.HrMaximoEntrega.HeaderText = "Hr. Maximo Entrega"
        Me.HrMaximoEntrega.Name = "HrMaximoEntrega"
        Me.HrMaximoEntrega.ReadOnly = True
        Me.HrMaximoEntrega.Visible = False
        '
        'Vendedor
        '
        Me.Vendedor.DataPropertyName = "Vendedor"
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        Me.Vendedor.Width = 150
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 150
        '
        'PuntodeSalida
        '
        Me.PuntodeSalida.HeaderText = "Punto de Salida"
        Me.PuntodeSalida.Items.AddRange(New Object() {"Breña", "Campoy"})
        Me.PuntodeSalida.Name = "PuntodeSalida"
        Me.PuntodeSalida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PuntodeSalida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PuntodeSalida.Visible = False
        '
        'Cantidad_Original
        '
        Me.Cantidad_Original.DataPropertyName = "Cantidad_Original"
        Me.Cantidad_Original.HeaderText = "Cantidad_Original"
        Me.Cantidad_Original.Name = "Cantidad_Original"
        Me.Cantidad_Original.Visible = False
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Visible = False
        '
        'REGRESO_PROG_DESPACHO
        '
        Me.REGRESO_PROG_DESPACHO.DataPropertyName = "REGRESO_PROG_DESPACHO"
        Me.REGRESO_PROG_DESPACHO.HeaderText = "REGRESO_PROG_DESPACHO"
        Me.REGRESO_PROG_DESPACHO.Name = "REGRESO_PROG_DESPACHO"
        Me.REGRESO_PROG_DESPACHO.Visible = False
        '
        'EMPRESA
        '
        Me.EMPRESA.DataPropertyName = "EMPRESA"
        Me.EMPRESA.HeaderText = "EMPRESA"
        Me.EMPRESA.Name = "EMPRESA"
        Me.EMPRESA.Visible = False
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.Color.Navy
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox17.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox17.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.ForeColor = System.Drawing.Color.White
        Me.TextBox17.Location = New System.Drawing.Point(0, 0)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Size = New System.Drawing.Size(1056, 20)
        Me.TextBox17.TabIndex = 169
        Me.TextBox17.Text = "BANDEJA DE PROGRAMACION DE DESPACHOS"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnl_despacho_pedidos
        '
        Me.pnl_despacho_pedidos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_despacho_pedidos.Controls.Add(Me.GroupBox5)
        Me.pnl_despacho_pedidos.Controls.Add(Me.TextBox10)
        Me.pnl_despacho_pedidos.Controls.Add(Me.GroupBox19)
        Me.pnl_despacho_pedidos.Controls.Add(Me.GroupBox20)
        Me.pnl_despacho_pedidos.Location = New System.Drawing.Point(372, 102)
        Me.pnl_despacho_pedidos.Name = "pnl_despacho_pedidos"
        Me.pnl_despacho_pedidos.Size = New System.Drawing.Size(441, 186)
        Me.pnl_despacho_pedidos.TabIndex = 227
        Me.pnl_despacho_pedidos.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_vehiculo_despacho)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(8, 126)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(425, 52)
        Me.GroupBox5.TabIndex = 202
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vehiculo"
        '
        'txt_vehiculo_despacho
        '
        Me.txt_vehiculo_despacho.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_vehiculo_despacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vehiculo_despacho.ForeColor = System.Drawing.Color.Maroon
        Me.txt_vehiculo_despacho.Location = New System.Drawing.Point(10, 20)
        Me.txt_vehiculo_despacho.MaxLength = 200
        Me.txt_vehiculo_despacho.Name = "txt_vehiculo_despacho"
        Me.txt_vehiculo_despacho.ReadOnly = True
        Me.txt_vehiculo_despacho.Size = New System.Drawing.Size(405, 20)
        Me.txt_vehiculo_despacho.TabIndex = 186
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Navy
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox10.ForeColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(1, 1)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(440, 20)
        Me.TextBox10.TabIndex = 168
        Me.TextBox10.Text = "DESPACHO DE PEDIDO"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.dtp_fecha_pedido)
        Me.GroupBox19.Controls.Add(Me.Label65)
        Me.GroupBox19.Controls.Add(Me.lbl_numero)
        Me.GroupBox19.Controls.Add(Me.Label69)
        Me.GroupBox19.Controls.Add(Me.Button4)
        Me.GroupBox19.Controls.Add(Me.Button6)
        Me.GroupBox19.Location = New System.Drawing.Point(8, 18)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(424, 52)
        Me.GroupBox19.TabIndex = 0
        Me.GroupBox19.TabStop = False
        '
        'dtp_fecha_pedido
        '
        Me.dtp_fecha_pedido.Enabled = False
        Me.dtp_fecha_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pedido.Location = New System.Drawing.Point(102, 26)
        Me.dtp_fecha_pedido.Name = "dtp_fecha_pedido"
        Me.dtp_fecha_pedido.Size = New System.Drawing.Size(105, 21)
        Me.dtp_fecha_pedido.TabIndex = 126
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Navy
        Me.Label65.Location = New System.Drawing.Point(7, 31)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(81, 13)
        Me.Label65.TabIndex = 125
        Me.Label65.Text = "Fecha Pedido"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_numero.Location = New System.Drawing.Point(102, 12)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(16, 13)
        Me.lbl_numero.TabIndex = 124
        Me.lbl_numero.Text = "..."
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Navy
        Me.Label69.Location = New System.Drawing.Point(5, 12)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(70, 13)
        Me.Label69.TabIndex = 123
        Me.Label69.Text = "Nro. Pedido"
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(311, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 35)
        Me.Button4.TabIndex = 121
        Me.Button4.Text = "Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Navy
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(246, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(63, 35)
        Me.Button6.TabIndex = 122
        Me.Button6.Text = "Confirmar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.txt_responsable_despacho)
        Me.GroupBox20.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox20.Location = New System.Drawing.Point(7, 74)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(425, 52)
        Me.GroupBox20.TabIndex = 201
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Responsable"
        '
        'txt_responsable_despacho
        '
        Me.txt_responsable_despacho.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_responsable_despacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_responsable_despacho.ForeColor = System.Drawing.Color.Maroon
        Me.txt_responsable_despacho.Location = New System.Drawing.Point(10, 20)
        Me.txt_responsable_despacho.MaxLength = 200
        Me.txt_responsable_despacho.Name = "txt_responsable_despacho"
        Me.txt_responsable_despacho.ReadOnly = True
        Me.txt_responsable_despacho.Size = New System.Drawing.Size(405, 20)
        Me.txt_responsable_despacho.TabIndex = 186
        '
        'Frm_OP_PLanta_Bandeja_Programacion_Despachos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1083, 593)
        Me.Controls.Add(Me.pnl_despacho_pedidos)
        Me.Controls.Add(Me.pnl_despachos_programados)
        Me.Controls.Add(Me.pnl_programar_Despachos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_OP_PLanta_Bandeja_Programacion_Despachos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bandeja de Programación de Despachos"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnl_despachos_programados.ResumeLayout(False)
        Me.pnl_despachos_programados.PerformLayout()
        Me.gb_cambio_trans_vehiculo.ResumeLayout(False)
        Me.gb_cambio_trans_vehiculo.PerformLayout()
        Me.GroupBox33.ResumeLayout(False)
        Me.GroupBox33.PerformLayout()
        Me.gb_cambio_depachos_programados.ResumeLayout(False)
        Me.gb_cambio_depachos_programados.PerformLayout()
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox24.PerformLayout()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox26.ResumeLayout(False)
        CType(Me.dgv_detalle_despachos_programados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnl_programar_Despachos.ResumeLayout(False)
        Me.pnl_programar_Despachos.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox32.ResumeLayout(False)
        Me.GroupBox32.PerformLayout()
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox27.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_detalle_prog_despacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_despacho_pedidos.ResumeLayout(False)
        Me.pnl_despacho_pedidos.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ProgramarDespManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_despachos_programados As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_todos_lineas_produccion_2 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_des_linea_produccion_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_linea_produccion_2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox33 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents gb_cambio_depachos_programados As System.Windows.Forms.GroupBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_nueva_despachos_programados As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff_dp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents dtp_fi_dp As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox25 As System.Windows.Forms.GroupBox
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button47 As System.Windows.Forms.Button
    Friend WithEvents Button48 As System.Windows.Forms.Button
    Friend WithEvents Button50 As System.Windows.Forms.Button
    Friend WithEvents GroupBox26 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_detalle_despachos_programados As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents pnl_programar_Despachos As System.Windows.Forms.Panel
    Friend WithEvents GroupBox32 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_despacho_programado As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_programar_Despacho As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox27 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_detalle_prog_despacho As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_despacho As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_prog_despacho_final As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_trans As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_trans As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_mostrar As System.Windows.Forms.Button
    Friend WithEvents chk_todos_lineas_produccion As System.Windows.Forms.CheckBox
    Friend WithEvents txt_des_linea_produccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_linea_produccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gb_cambio_trans_vehiculo As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_vehiculo_cambio As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_vehiculo_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_trans_cambio As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_trans_cambio As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_vehiculo_consulta As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_vehiculo_consulta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_trans_consulta As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_trans_consulta As System.Windows.Forms.TextBox
    Friend WithEvents chk_todos_estado As System.Windows.Forms.CheckBox
    Friend WithEvents chk_todos_vehiculo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_todos_trans As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SecDespacho As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_INTERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HrEntregaAcordado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HrMaximoEntrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PuntodeSalida As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Cantidad_Original As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGRESO_PROG_DESPACHO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_fusionar As System.Windows.Forms.CheckBox
    Friend WithEvents pnl_despacho_pedidos As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_vehiculo_despacho As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_responsable_despacho As System.Windows.Forms.TextBox
End Class
