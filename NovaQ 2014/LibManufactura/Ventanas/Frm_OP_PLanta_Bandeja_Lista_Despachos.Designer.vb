<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OP_PLanta_Bandeja_Lista_Despachos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_OP_PLanta_Bandeja_Lista_Despachos))
        Me.pnl_despachos_programados = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox33 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.btn_reportar = New System.Windows.Forms.Button()
        Me.gb_cambio_depachos_programados = New System.Windows.Forms.GroupBox()
        Me.btn_datos_reprogramacion = New System.Windows.Forms.Button()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.dtp_fecha_nueva_despachos_programados = New System.Windows.Forms.DateTimePicker()
        Me.btn_confirmar_cambio = New System.Windows.Forms.Button()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.dtp_ff_dp = New System.Windows.Forms.DateTimePicker()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.dtp_fi_dp = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.btn_actualiza_correlativo = New System.Windows.Forms.Button()
        Me.btn_reprogramar = New System.Windows.Forms.Button()
        Me.btn_deshacer = New System.Windows.Forms.Button()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.dgv_detalle_despachos_programados = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LiquidarOrdenDeProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_todos_lineas_produccion_2 = New System.Windows.Forms.CheckBox()
        Me.txt_des_linea_produccion_2 = New System.Windows.Forms.TextBox()
        Me.txt_cod_linea_produccion_2 = New System.Windows.Forms.TextBox()
        Me.pnl_programar_Despachos = New System.Windows.Forms.Panel()
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.rdb_despacho_programado = New System.Windows.Forms.RadioButton()
        Me.rdb_programar_Despacho = New System.Windows.Forms.RadioButton()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.dtp_fecha_despacho = New System.Windows.Forms.DateTimePicker()
        Me.btn_prog_despacho_final = New System.Windows.Forms.Button()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.dgv_detalle_prog_despacho = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProgramarDespManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.chk_todos_lineas_produccion = New System.Windows.Forms.CheckBox()
        Me.txt_des_linea_produccion = New System.Windows.Forms.TextBox()
        Me.txt_cod_linea_produccion = New System.Windows.Forms.TextBox()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SecDespacho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO_INTERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_ORDEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_reprogramar_despacho = New System.Windows.Forms.Panel()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.GroupBox115 = New System.Windows.Forms.GroupBox()
        Me.Button129 = New System.Windows.Forms.Button()
        Me.Button132 = New System.Windows.Forms.Button()
        Me.GroupBox116 = New System.Windows.Forms.GroupBox()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.Label286 = New System.Windows.Forms.Label()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.Label287 = New System.Windows.Forms.Label()
        Me.pnl_despachos_programados.SuspendLayout()
        Me.GroupBox33.SuspendLayout()
        Me.gb_cambio_depachos_programados.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        CType(Me.dgv_detalle_despachos_programados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnl_programar_Despachos.SuspendLayout()
        Me.GroupBox32.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        CType(Me.dgv_detalle_prog_despacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnl_reprogramar_despacho.SuspendLayout()
        Me.GroupBox115.SuspendLayout()
        Me.GroupBox116.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_despachos_programados
        '
        Me.pnl_despachos_programados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_despachos_programados.BackColor = System.Drawing.Color.White
        Me.pnl_despachos_programados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_despachos_programados.Controls.Add(Me.Label4)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox33)
        Me.pnl_despachos_programados.Controls.Add(Me.btn_reportar)
        Me.pnl_despachos_programados.Controls.Add(Me.gb_cambio_depachos_programados)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox24)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox25)
        Me.pnl_despachos_programados.Controls.Add(Me.btn_consultar)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox26)
        Me.pnl_despachos_programados.Controls.Add(Me.TextBox13)
        Me.pnl_despachos_programados.Controls.Add(Me.GroupBox2)
        Me.pnl_despachos_programados.Location = New System.Drawing.Point(12, 7)
        Me.pnl_despachos_programados.Name = "pnl_despachos_programados"
        Me.pnl_despachos_programados.Size = New System.Drawing.Size(1063, 578)
        Me.pnl_despachos_programados.TabIndex = 294
        Me.pnl_despachos_programados.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(820, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 15)
        Me.Label4.TabIndex = 290
        Me.Label4.Text = "***Requerimiento reprogramado***"
        '
        'GroupBox33
        '
        Me.GroupBox33.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox33.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox33.Controls.Add(Me.RadioButton3)
        Me.GroupBox33.Controls.Add(Me.RadioButton4)
        Me.GroupBox33.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox33.Location = New System.Drawing.Point(774, 25)
        Me.GroupBox33.Name = "GroupBox33"
        Me.GroupBox33.Size = New System.Drawing.Size(284, 41)
        Me.GroupBox33.TabIndex = 280
        Me.GroupBox33.TabStop = False
        Me.GroupBox33.Text = "Opción"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(144, 16)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Despacho Programado"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(9, 16)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(125, 17)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.Text = "Programar Despacho"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'btn_reportar
        '
        Me.btn_reportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reportar.ForeColor = System.Drawing.Color.Navy
        Me.btn_reportar.Image = CType(resources.GetObject("btn_reportar.Image"), System.Drawing.Image)
        Me.btn_reportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reportar.Location = New System.Drawing.Point(421, 42)
        Me.btn_reportar.Name = "btn_reportar"
        Me.btn_reportar.Size = New System.Drawing.Size(85, 23)
        Me.btn_reportar.TabIndex = 276
        Me.btn_reportar.Text = "Reportar"
        Me.btn_reportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reportar.UseVisualStyleBackColor = True
        '
        'gb_cambio_depachos_programados
        '
        Me.gb_cambio_depachos_programados.Controls.Add(Me.btn_datos_reprogramacion)
        Me.gb_cambio_depachos_programados.Controls.Add(Me.Label89)
        Me.gb_cambio_depachos_programados.Controls.Add(Me.dtp_fecha_nueva_despachos_programados)
        Me.gb_cambio_depachos_programados.Controls.Add(Me.btn_confirmar_cambio)
        Me.gb_cambio_depachos_programados.ForeColor = System.Drawing.Color.Navy
        Me.gb_cambio_depachos_programados.Location = New System.Drawing.Point(372, 80)
        Me.gb_cambio_depachos_programados.Name = "gb_cambio_depachos_programados"
        Me.gb_cambio_depachos_programados.Size = New System.Drawing.Size(328, 50)
        Me.gb_cambio_depachos_programados.TabIndex = 272
        Me.gb_cambio_depachos_programados.TabStop = False
        Me.gb_cambio_depachos_programados.Text = "Cambio de Fecha - Programación"
        Me.gb_cambio_depachos_programados.Visible = False
        '
        'btn_datos_reprogramacion
        '
        Me.btn_datos_reprogramacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_datos_reprogramacion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_datos_reprogramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_datos_reprogramacion.ForeColor = System.Drawing.Color.Navy
        Me.btn_datos_reprogramacion.Image = CType(resources.GetObject("btn_datos_reprogramacion.Image"), System.Drawing.Image)
        Me.btn_datos_reprogramacion.Location = New System.Drawing.Point(158, 17)
        Me.btn_datos_reprogramacion.Name = "btn_datos_reprogramacion"
        Me.btn_datos_reprogramacion.Size = New System.Drawing.Size(34, 23)
        Me.btn_datos_reprogramacion.TabIndex = 276
        Me.btn_datos_reprogramacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_datos_reprogramacion.UseVisualStyleBackColor = True
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
        'btn_confirmar_cambio
        '
        Me.btn_confirmar_cambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_cambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar_cambio.ForeColor = System.Drawing.Color.Navy
        Me.btn_confirmar_cambio.Image = CType(resources.GetObject("btn_confirmar_cambio.Image"), System.Drawing.Image)
        Me.btn_confirmar_cambio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmar_cambio.Location = New System.Drawing.Point(201, 17)
        Me.btn_confirmar_cambio.Name = "btn_confirmar_cambio"
        Me.btn_confirmar_cambio.Size = New System.Drawing.Size(119, 23)
        Me.btn_confirmar_cambio.TabIndex = 269
        Me.btn_confirmar_cambio.Text = "Confirmar cambio"
        Me.btn_confirmar_cambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_confirmar_cambio.UseVisualStyleBackColor = True
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
        Me.GroupBox24.Size = New System.Drawing.Size(314, 52)
        Me.GroupBox24.TabIndex = 271
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Rango de Fechas Programadas"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.ForeColor = System.Drawing.Color.Navy
        Me.Label87.Location = New System.Drawing.Point(181, 24)
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
        Me.dtp_ff_dp.Location = New System.Drawing.Point(208, 19)
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
        Me.GroupBox25.Controls.Add(Me.btn_actualiza_correlativo)
        Me.GroupBox25.Controls.Add(Me.btn_reprogramar)
        Me.GroupBox25.Controls.Add(Me.btn_deshacer)
        Me.GroupBox25.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox25.Location = New System.Drawing.Point(10, 80)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(353, 50)
        Me.GroupBox25.TabIndex = 270
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Cambios en Despachos Programados"
        '
        'btn_actualiza_correlativo
        '
        Me.btn_actualiza_correlativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualiza_correlativo.ForeColor = System.Drawing.Color.Navy
        Me.btn_actualiza_correlativo.Image = CType(resources.GetObject("btn_actualiza_correlativo.Image"), System.Drawing.Image)
        Me.btn_actualiza_correlativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualiza_correlativo.Location = New System.Drawing.Point(9, 17)
        Me.btn_actualiza_correlativo.Name = "btn_actualiza_correlativo"
        Me.btn_actualiza_correlativo.Size = New System.Drawing.Size(108, 23)
        Me.btn_actualiza_correlativo.TabIndex = 270
        Me.btn_actualiza_correlativo.Text = "Act. Correlativo"
        Me.btn_actualiza_correlativo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualiza_correlativo.UseVisualStyleBackColor = True
        '
        'btn_reprogramar
        '
        Me.btn_reprogramar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reprogramar.ForeColor = System.Drawing.Color.Navy
        Me.btn_reprogramar.Image = CType(resources.GetObject("btn_reprogramar.Image"), System.Drawing.Image)
        Me.btn_reprogramar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reprogramar.Location = New System.Drawing.Point(122, 17)
        Me.btn_reprogramar.Name = "btn_reprogramar"
        Me.btn_reprogramar.Size = New System.Drawing.Size(108, 23)
        Me.btn_reprogramar.TabIndex = 269
        Me.btn_reprogramar.Text = "Reprog. Desp."
        Me.btn_reprogramar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reprogramar.UseVisualStyleBackColor = True
        '
        'btn_deshacer
        '
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.ForeColor = System.Drawing.Color.Navy
        Me.btn_deshacer.Image = CType(resources.GetObject("btn_deshacer.Image"), System.Drawing.Image)
        Me.btn_deshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_deshacer.Location = New System.Drawing.Point(236, 17)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(108, 23)
        Me.btn_deshacer.TabIndex = 268
        Me.btn_deshacer.Text = "Deshacer Prog."
        Me.btn_deshacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_deshacer.UseVisualStyleBackColor = True
        '
        'btn_consultar
        '
        Me.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar.ForeColor = System.Drawing.Color.Navy
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_consultar.Location = New System.Drawing.Point(334, 42)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(85, 23)
        Me.btn_consultar.TabIndex = 265
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'GroupBox26
        '
        Me.GroupBox26.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox26.Controls.Add(Me.dgv_detalle_despachos_programados)
        Me.GroupBox26.Location = New System.Drawing.Point(10, 141)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(1048, 422)
        Me.GroupBox26.TabIndex = 170
        Me.GroupBox26.TabStop = False
        '
        'dgv_detalle_despachos_programados
        '
        Me.dgv_detalle_despachos_programados.AllowUserToAddRows = False
        Me.dgv_detalle_despachos_programados.AllowUserToDeleteRows = False
        Me.dgv_detalle_despachos_programados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_despachos_programados.ContextMenuStrip = Me.ContextMenuStrip2
        Me.dgv_detalle_despachos_programados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_detalle_despachos_programados.Location = New System.Drawing.Point(3, 16)
        Me.dgv_detalle_despachos_programados.Name = "dgv_detalle_despachos_programados"
        Me.dgv_detalle_despachos_programados.Size = New System.Drawing.Size(1042, 403)
        Me.dgv_detalle_despachos_programados.TabIndex = 265
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidarOrdenDeProducciónToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(234, 26)
        '
        'LiquidarOrdenDeProducciónToolStripMenuItem
        '
        Me.LiquidarOrdenDeProducciónToolStripMenuItem.Image = CType(resources.GetObject("LiquidarOrdenDeProducciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LiquidarOrdenDeProducciónToolStripMenuItem.Name = "LiquidarOrdenDeProducciónToolStripMenuItem"
        Me.LiquidarOrdenDeProducciónToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.LiquidarOrdenDeProducciónToolStripMenuItem.Text = "Liquidar Orden de Producción"
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
        Me.TextBox13.Size = New System.Drawing.Size(1061, 20)
        Me.TextBox13.TabIndex = 169
        Me.TextBox13.Text = "PROGRAMA DE LISTA DE DESPACHOS - GENERADOS"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_todos_lineas_produccion_2)
        Me.GroupBox2.Controls.Add(Me.txt_des_linea_produccion_2)
        Me.GroupBox2.Controls.Add(Me.txt_cod_linea_produccion_2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(11, 243)
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
        Me.pnl_programar_Despachos.Controls.Add(Me.GroupBox32)
        Me.pnl_programar_Despachos.Controls.Add(Me.Label91)
        Me.pnl_programar_Despachos.Controls.Add(Me.dtp_fecha_despacho)
        Me.pnl_programar_Despachos.Controls.Add(Me.btn_prog_despacho_final)
        Me.pnl_programar_Despachos.Controls.Add(Me.GroupBox27)
        Me.pnl_programar_Despachos.Controls.Add(Me.TextBox17)
        Me.pnl_programar_Despachos.Controls.Add(Me.GroupBox1)
        Me.pnl_programar_Despachos.Location = New System.Drawing.Point(12, 7)
        Me.pnl_programar_Despachos.Name = "pnl_programar_Despachos"
        Me.pnl_programar_Despachos.Size = New System.Drawing.Size(1058, 578)
        Me.pnl_programar_Despachos.TabIndex = 293
        Me.pnl_programar_Despachos.Visible = False
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
        Me.rdb_despacho_programado.Size = New System.Drawing.Size(134, 17)
        Me.rdb_despacho_programado.TabIndex = 1
        Me.rdb_despacho_programado.Text = "Despacho Programado"
        Me.rdb_despacho_programado.UseVisualStyleBackColor = True
        '
        'rdb_programar_Despacho
        '
        Me.rdb_programar_Despacho.AutoSize = True
        Me.rdb_programar_Despacho.Checked = True
        Me.rdb_programar_Despacho.Location = New System.Drawing.Point(16, 16)
        Me.rdb_programar_Despacho.Name = "rdb_programar_Despacho"
        Me.rdb_programar_Despacho.Size = New System.Drawing.Size(125, 17)
        Me.rdb_programar_Despacho.TabIndex = 0
        Me.rdb_programar_Despacho.TabStop = True
        Me.rdb_programar_Despacho.Text = "Programar Despacho"
        Me.rdb_programar_Despacho.UseVisualStyleBackColor = True
        '
        'Label91
        '
        Me.Label91.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label91.AutoSize = True
        Me.Label91.ForeColor = System.Drawing.Color.Navy
        Me.Label91.Location = New System.Drawing.Point(684, 38)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(105, 13)
        Me.Label91.TabIndex = 269
        Me.Label91.Text = "Fecha Programación"
        '
        'dtp_fecha_despacho
        '
        Me.dtp_fecha_despacho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_fecha_despacho.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_despacho.Checked = False
        Me.dtp_fecha_despacho.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_despacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_despacho.Location = New System.Drawing.Point(798, 32)
        Me.dtp_fecha_despacho.Name = "dtp_fecha_despacho"
        Me.dtp_fecha_despacho.Size = New System.Drawing.Size(95, 24)
        Me.dtp_fecha_despacho.TabIndex = 268
        Me.dtp_fecha_despacho.Tag = ""
        '
        'btn_prog_despacho_final
        '
        Me.btn_prog_despacho_final.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_prog_despacho_final.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prog_despacho_final.ForeColor = System.Drawing.Color.Navy
        Me.btn_prog_despacho_final.Image = CType(resources.GetObject("btn_prog_despacho_final.Image"), System.Drawing.Image)
        Me.btn_prog_despacho_final.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prog_despacho_final.Location = New System.Drawing.Point(904, 32)
        Me.btn_prog_despacho_final.Name = "btn_prog_despacho_final"
        Me.btn_prog_despacho_final.Size = New System.Drawing.Size(140, 23)
        Me.btn_prog_despacho_final.TabIndex = 267
        Me.btn_prog_despacho_final.Text = "Programar Despacho"
        Me.btn_prog_despacho_final.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_prog_despacho_final.UseVisualStyleBackColor = True
        '
        'GroupBox27
        '
        Me.GroupBox27.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox27.Controls.Add(Me.dgv_detalle_prog_despacho)
        Me.GroupBox27.Location = New System.Drawing.Point(10, 73)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(1034, 490)
        Me.GroupBox27.TabIndex = 170
        Me.GroupBox27.TabStop = False
        '
        'dgv_detalle_prog_despacho
        '
        Me.dgv_detalle_prog_despacho.AllowUserToAddRows = False
        Me.dgv_detalle_prog_despacho.AllowUserToDeleteRows = False
        Me.dgv_detalle_prog_despacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_prog_despacho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.SecDespacho, Me.CODIGO_INTERNO, Me.TIPO_ORDEN, Me.NOP, Me.FechaEntrega, Me.Cliente, Me.Producto, Me.UM, Me.Cantidad, Me.HrEntregaAcordado, Me.HrMaximoEntrega, Me.Vendedor, Me.Observaciones, Me.PuntodeSalida, Me.Cantidad_Original, Me.Email, Me.REGRESO_PROG_DESPACHO, Me.ITEM, Me.CODIGO})
        Me.dgv_detalle_prog_despacho.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv_detalle_prog_despacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_detalle_prog_despacho.Location = New System.Drawing.Point(3, 16)
        Me.dgv_detalle_prog_despacho.Name = "dgv_detalle_prog_despacho"
        Me.dgv_detalle_prog_despacho.Size = New System.Drawing.Size(1028, 471)
        Me.dgv_detalle_prog_despacho.TabIndex = 265
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramarDespManualToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(206, 26)
        '
        'ProgramarDespManualToolStripMenuItem
        '
        Me.ProgramarDespManualToolStripMenuItem.Image = CType(resources.GetObject("ProgramarDespManualToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProgramarDespManualToolStripMenuItem.Name = "ProgramarDespManualToolStripMenuItem"
        Me.ProgramarDespManualToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ProgramarDespManualToolStripMenuItem.Text = "Programar Desp. manual"
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
        Me.TextBox17.Text = "PROGRAMA DE LISTA DE DESPACHOS - GENERACION"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GroupBox1.Text = "Lineas de Producción"
        Me.GroupBox1.Visible = False
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mostrar.ForeColor = System.Drawing.Color.Navy
        Me.btn_mostrar.Image = CType(resources.GetObject("btn_mostrar.Image"), System.Drawing.Image)
        Me.btn_mostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mostrar.Location = New System.Drawing.Point(382, 39)
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
        Me.txt_des_linea_produccion.Location = New System.Drawing.Point(91, 40)
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
        Me.txt_cod_linea_produccion.Size = New System.Drawing.Size(68, 20)
        Me.txt_cod_linea_produccion.TabIndex = 176
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
        'TIPO_ORDEN
        '
        Me.TIPO_ORDEN.DataPropertyName = "TIPO_ORDEN"
        Me.TIPO_ORDEN.HeaderText = "Tipo Orden"
        Me.TIPO_ORDEN.Name = "TIPO_ORDEN"
        Me.TIPO_ORDEN.ReadOnly = True
        Me.TIPO_ORDEN.Visible = False
        '
        'NOP
        '
        Me.NOP.DataPropertyName = "NOP"
        Me.NOP.HeaderText = "N° Requerimiento"
        Me.NOP.Name = "NOP"
        Me.NOP.ReadOnly = True
        Me.NOP.Width = 50
        '
        'FechaEntrega
        '
        Me.FechaEntrega.DataPropertyName = "FechaEntrega"
        Me.FechaEntrega.HeaderText = "Fecha Entrega"
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
        Me.Producto.Width = 150
        '
        'UM
        '
        Me.UM.DataPropertyName = "UM"
        Me.UM.HeaderText = "U.M."
        Me.UM.Name = "UM"
        Me.UM.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'HrEntregaAcordado
        '
        Me.HrEntregaAcordado.DataPropertyName = "HrEntregaAcordado"
        Me.HrEntregaAcordado.HeaderText = "Hr. Entrega Acordado"
        Me.HrEntregaAcordado.Name = "HrEntregaAcordado"
        Me.HrEntregaAcordado.ReadOnly = True
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
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 150
        '
        'PuntodeSalida
        '
        Me.PuntodeSalida.HeaderText = "Punto de Salida"
        Me.PuntodeSalida.Items.AddRange(New Object() {"Breña", "Campoy"})
        Me.PuntodeSalida.Name = "PuntodeSalida"
        Me.PuntodeSalida.ReadOnly = True
        Me.PuntodeSalida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PuntodeSalida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PuntodeSalida.Visible = False
        '
        'Cantidad_Original
        '
        Me.Cantidad_Original.DataPropertyName = "Cantidad_Original"
        Me.Cantidad_Original.HeaderText = "Cantidad_Original"
        Me.Cantidad_Original.Name = "Cantidad_Original"
        Me.Cantidad_Original.ReadOnly = True
        Me.Cantidad_Original.Visible = False
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Visible = False
        '
        'REGRESO_PROG_DESPACHO
        '
        Me.REGRESO_PROG_DESPACHO.DataPropertyName = "REGRESO_PROG_DESPACHO"
        Me.REGRESO_PROG_DESPACHO.HeaderText = "REGRESO_PROG_DESPACHO"
        Me.REGRESO_PROG_DESPACHO.Name = "REGRESO_PROG_DESPACHO"
        Me.REGRESO_PROG_DESPACHO.ReadOnly = True
        Me.REGRESO_PROG_DESPACHO.Visible = False
        '
        'ITEM
        '
        Me.ITEM.DataPropertyName = "ITEM"
        Me.ITEM.HeaderText = "ITEM"
        Me.ITEM.Name = "ITEM"
        Me.ITEM.Visible = False
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "CODIGO"
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Visible = False
        '
        'pnl_reprogramar_despacho
        '
        Me.pnl_reprogramar_despacho.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_reprogramar_despacho.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnl_reprogramar_despacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_reprogramar_despacho.Controls.Add(Me.TextBox67)
        Me.pnl_reprogramar_despacho.Controls.Add(Me.GroupBox115)
        Me.pnl_reprogramar_despacho.Location = New System.Drawing.Point(278, 73)
        Me.pnl_reprogramar_despacho.Name = "pnl_reprogramar_despacho"
        Me.pnl_reprogramar_despacho.Size = New System.Drawing.Size(527, 202)
        Me.pnl_reprogramar_despacho.TabIndex = 295
        Me.pnl_reprogramar_despacho.Visible = False
        '
        'TextBox67
        '
        Me.TextBox67.BackColor = System.Drawing.Color.Green
        Me.TextBox67.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox67.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox67.ForeColor = System.Drawing.Color.White
        Me.TextBox67.Location = New System.Drawing.Point(-1, -1)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(603, 20)
        Me.TextBox67.TabIndex = 169
        Me.TextBox67.Text = "REGISTRAR DATOS DE REPROGRAMACION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox115
        '
        Me.GroupBox115.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox115.Controls.Add(Me.Button129)
        Me.GroupBox115.Controls.Add(Me.Button132)
        Me.GroupBox115.Controls.Add(Me.GroupBox116)
        Me.GroupBox115.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox115.Location = New System.Drawing.Point(11, 22)
        Me.GroupBox115.Name = "GroupBox115"
        Me.GroupBox115.Size = New System.Drawing.Size(504, 169)
        Me.GroupBox115.TabIndex = 0
        Me.GroupBox115.TabStop = False
        '
        'Button129
        '
        Me.Button129.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button129.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button129.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button129.ForeColor = System.Drawing.Color.Navy
        Me.Button129.Image = CType(resources.GetObject("Button129.Image"), System.Drawing.Image)
        Me.Button129.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button129.Location = New System.Drawing.Point(153, 137)
        Me.Button129.Name = "Button129"
        Me.Button129.Size = New System.Drawing.Size(88, 23)
        Me.Button129.TabIndex = 137
        Me.Button129.Text = "Confirmar"
        Me.Button129.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button129.UseVisualStyleBackColor = True
        '
        'Button132
        '
        Me.Button132.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button132.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button132.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button132.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button132.ForeColor = System.Drawing.Color.Navy
        Me.Button132.Image = CType(resources.GetObject("Button132.Image"), System.Drawing.Image)
        Me.Button132.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button132.Location = New System.Drawing.Point(262, 137)
        Me.Button132.Name = "Button132"
        Me.Button132.Size = New System.Drawing.Size(88, 23)
        Me.Button132.TabIndex = 136
        Me.Button132.Text = "&Cancelar"
        Me.Button132.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button132.UseVisualStyleBackColor = True
        '
        'GroupBox116
        '
        Me.GroupBox116.Controls.Add(Me.txt_observacion)
        Me.GroupBox116.Controls.Add(Me.Label286)
        Me.GroupBox116.Controls.Add(Me.txt_motivo)
        Me.GroupBox116.Controls.Add(Me.Label287)
        Me.GroupBox116.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox116.Name = "GroupBox116"
        Me.GroupBox116.Size = New System.Drawing.Size(473, 118)
        Me.GroupBox116.TabIndex = 135
        Me.GroupBox116.TabStop = False
        '
        'txt_observacion
        '
        Me.txt_observacion.BackColor = System.Drawing.Color.White
        Me.txt_observacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_observacion.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observacion.ForeColor = System.Drawing.Color.Maroon
        Me.txt_observacion.Location = New System.Drawing.Point(17, 65)
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(443, 46)
        Me.txt_observacion.TabIndex = 149
        '
        'Label286
        '
        Me.Label286.AutoSize = True
        Me.Label286.ForeColor = System.Drawing.Color.Navy
        Me.Label286.Location = New System.Drawing.Point(13, 49)
        Me.Label286.Name = "Label286"
        Me.Label286.Size = New System.Drawing.Size(67, 13)
        Me.Label286.TabIndex = 148
        Me.Label286.Text = "Observación"
        '
        'txt_motivo
        '
        Me.txt_motivo.BackColor = System.Drawing.Color.White
        Me.txt_motivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_motivo.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_motivo.Location = New System.Drawing.Point(61, 17)
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(399, 22)
        Me.txt_motivo.TabIndex = 141
        '
        'Label287
        '
        Me.Label287.AutoSize = True
        Me.Label287.ForeColor = System.Drawing.Color.Navy
        Me.Label287.Location = New System.Drawing.Point(13, 22)
        Me.Label287.Name = "Label287"
        Me.Label287.Size = New System.Drawing.Size(39, 13)
        Me.Label287.TabIndex = 140
        Me.Label287.Text = "Motivo"
        '
        'Frm_OP_PLanta_Bandeja_Lista_Despachos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1083, 593)
        Me.Controls.Add(Me.pnl_reprogramar_despacho)
        Me.Controls.Add(Me.pnl_despachos_programados)
        Me.Controls.Add(Me.pnl_programar_Despachos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_OP_PLanta_Bandeja_Lista_Despachos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bandeja de Lista de Despachos"
        Me.pnl_despachos_programados.ResumeLayout(False)
        Me.pnl_despachos_programados.PerformLayout()
        Me.GroupBox33.ResumeLayout(False)
        Me.GroupBox33.PerformLayout()
        Me.gb_cambio_depachos_programados.ResumeLayout(False)
        Me.gb_cambio_depachos_programados.PerformLayout()
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox24.PerformLayout()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox26.ResumeLayout(False)
        CType(Me.dgv_detalle_despachos_programados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnl_programar_Despachos.ResumeLayout(False)
        Me.pnl_programar_Despachos.PerformLayout()
        Me.GroupBox32.ResumeLayout(False)
        Me.GroupBox32.PerformLayout()
        Me.GroupBox27.ResumeLayout(False)
        CType(Me.dgv_detalle_prog_despacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnl_reprogramar_despacho.ResumeLayout(False)
        Me.pnl_reprogramar_despacho.PerformLayout()
        Me.GroupBox115.ResumeLayout(False)
        Me.GroupBox116.ResumeLayout(False)
        Me.GroupBox116.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_despachos_programados As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox33 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents btn_reportar As System.Windows.Forms.Button
    Friend WithEvents gb_cambio_depachos_programados As System.Windows.Forms.GroupBox
    Friend WithEvents btn_datos_reprogramacion As System.Windows.Forms.Button
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_nueva_despachos_programados As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_confirmar_cambio As System.Windows.Forms.Button
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff_dp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents dtp_fi_dp As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox25 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_actualiza_correlativo As System.Windows.Forms.Button
    Friend WithEvents btn_reprogramar As System.Windows.Forms.Button
    Friend WithEvents btn_deshacer As System.Windows.Forms.Button
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents GroupBox26 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_detalle_despachos_programados As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LiquidarOrdenDeProducciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_todos_lineas_produccion_2 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_des_linea_produccion_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_linea_produccion_2 As System.Windows.Forms.TextBox
    Friend WithEvents pnl_programar_Despachos As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_mostrar As System.Windows.Forms.Button
    Friend WithEvents chk_todos_lineas_produccion As System.Windows.Forms.CheckBox
    Friend WithEvents txt_des_linea_produccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_linea_produccion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox32 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_despacho_programado As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_programar_Despacho As System.Windows.Forms.RadioButton
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_despacho As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_prog_despacho_final As System.Windows.Forms.Button
    Friend WithEvents GroupBox27 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_detalle_prog_despacho As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ProgramarDespManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SecDespacho As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_INTERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_ORDEN As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnl_reprogramar_despacho As System.Windows.Forms.Panel
    Friend WithEvents TextBox67 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox115 As System.Windows.Forms.GroupBox
    Friend WithEvents Button129 As System.Windows.Forms.Button
    Friend WithEvents Button132 As System.Windows.Forms.Button
    Friend WithEvents GroupBox116 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label286 As System.Windows.Forms.Label
    Friend WithEvents txt_motivo As System.Windows.Forms.TextBox
    Friend WithEvents Label287 As System.Windows.Forms.Label
End Class
