Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportePendienteCobro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportePendienteCobro))
        Me.gbReporte = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rdb_resumido_general = New System.Windows.Forms.RadioButton()
        Me.rdb_detallado_general = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdb_ambos_monedas = New System.Windows.Forms.RadioButton()
        Me.rdb_dolares = New System.Windows.Forms.RadioButton()
        Me.rdb_soles = New System.Windows.Forms.RadioButton()
        Me.gb_tipo = New System.Windows.Forms.GroupBox()
        Me.rdb_ambos = New System.Windows.Forms.RadioButton()
        Me.rdb_solo_saldos = New System.Windows.Forms.RadioButton()
        Me.rdb_solo_retencion = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.chklstdocumentos = New System.Windows.Forms.CheckedListBox()
        Me.checkDocumentos = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chklstAlmacenes = New System.Windows.Forms.CheckedListBox()
        Me.checkAlmacen = New System.Windows.Forms.CheckBox()
        Me.chk_todos_series = New System.Windows.Forms.CheckBox()
        Me.cmb_tipo_cob = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdb_vcto = New System.Windows.Forms.RadioButton()
        Me.rdb_emision = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_ff_opt = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi_opt = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.rbMes = New System.Windows.Forms.RadioButton()
        Me.rbVendedor = New System.Windows.Forms.RadioButton()
        Me.rbFechas = New System.Windows.Forms.RadioButton()
        Me.rbClientes = New System.Windows.Forms.RadioButton()
        Me.checkTodos = New System.Windows.Forms.CheckBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.rdb_resumido = New System.Windows.Forms.RadioButton()
        Me.rdb_detallado = New System.Windows.Forms.RadioButton()
        Me.pnlFecha = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpemision_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtpemisioninicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechafinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechainicial = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.pnlMensual = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.chklstdocumentos2 = New System.Windows.Forms.CheckedListBox()
        Me.checkDocumentos2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.chklstAlmacenes2 = New System.Windows.Forms.CheckedListBox()
        Me.checkAlmacen2 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_mensual = New System.Windows.Forms.DateTimePicker()
        Me.rpt_mensual = New System.Windows.Forms.RadioButton()
        Me.gbReporte.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gb_tipo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFecha.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlMensual.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbReporte
        '
        Me.gbReporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbReporte.Controls.Add(Me.GroupBox7)
        Me.gbReporte.Controls.Add(Me.GroupBox6)
        Me.gbReporte.Controls.Add(Me.gb_tipo)
        Me.gbReporte.Controls.Add(Me.GroupBox1)
        Me.gbReporte.Controls.Add(Me.checkTodos)
        Me.gbReporte.Controls.Add(Me.lblCantidad)
        Me.gbReporte.Controls.Add(Me.gbFiltros)
        Me.gbReporte.Controls.Add(Me.dgvDocumentos)
        Me.gbReporte.Controls.Add(Me.rdb_resumido)
        Me.gbReporte.Controls.Add(Me.rdb_detallado)
        Me.gbReporte.ForeColor = System.Drawing.Color.Navy
        Me.gbReporte.Location = New System.Drawing.Point(12, 33)
        Me.gbReporte.Name = "gbReporte"
        Me.gbReporte.Size = New System.Drawing.Size(1062, 497)
        Me.gbReporte.TabIndex = 2
        Me.gbReporte.TabStop = False
        Me.gbReporte.Text = "Datos pendientes de Cobro"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rdb_resumido_general)
        Me.GroupBox7.Controls.Add(Me.rdb_detallado_general)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(961, 84)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(85, 78)
        Me.GroupBox7.TabIndex = 189
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Opción"
        '
        'rdb_resumido_general
        '
        Me.rdb_resumido_general.AutoSize = True
        Me.rdb_resumido_general.ForeColor = System.Drawing.Color.Navy
        Me.rdb_resumido_general.Location = New System.Drawing.Point(10, 46)
        Me.rdb_resumido_general.Name = "rdb_resumido_general"
        Me.rdb_resumido_general.Size = New System.Drawing.Size(72, 17)
        Me.rdb_resumido_general.TabIndex = 180
        Me.rdb_resumido_general.Text = "Resumido"
        Me.rdb_resumido_general.UseVisualStyleBackColor = True
        '
        'rdb_detallado_general
        '
        Me.rdb_detallado_general.AutoSize = True
        Me.rdb_detallado_general.Checked = True
        Me.rdb_detallado_general.ForeColor = System.Drawing.Color.Navy
        Me.rdb_detallado_general.Location = New System.Drawing.Point(10, 22)
        Me.rdb_detallado_general.Name = "rdb_detallado_general"
        Me.rdb_detallado_general.Size = New System.Drawing.Size(70, 17)
        Me.rdb_detallado_general.TabIndex = 179
        Me.rdb_detallado_general.TabStop = True
        Me.rdb_detallado_general.Text = "Detallado"
        Me.rdb_detallado_general.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdb_ambos_monedas)
        Me.GroupBox6.Controls.Add(Me.rdb_dolares)
        Me.GroupBox6.Controls.Add(Me.rdb_soles)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(878, 84)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(76, 78)
        Me.GroupBox6.TabIndex = 188
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Moneda"
        '
        'rdb_ambos_monedas
        '
        Me.rdb_ambos_monedas.AutoSize = True
        Me.rdb_ambos_monedas.Checked = True
        Me.rdb_ambos_monedas.ForeColor = System.Drawing.Color.Navy
        Me.rdb_ambos_monedas.Location = New System.Drawing.Point(10, 54)
        Me.rdb_ambos_monedas.Name = "rdb_ambos_monedas"
        Me.rdb_ambos_monedas.Size = New System.Drawing.Size(57, 17)
        Me.rdb_ambos_monedas.TabIndex = 181
        Me.rdb_ambos_monedas.TabStop = True
        Me.rdb_ambos_monedas.Text = "Ambos"
        Me.rdb_ambos_monedas.UseVisualStyleBackColor = True
        '
        'rdb_dolares
        '
        Me.rdb_dolares.AutoSize = True
        Me.rdb_dolares.ForeColor = System.Drawing.Color.Navy
        Me.rdb_dolares.Location = New System.Drawing.Point(10, 32)
        Me.rdb_dolares.Name = "rdb_dolares"
        Me.rdb_dolares.Size = New System.Drawing.Size(61, 17)
        Me.rdb_dolares.TabIndex = 180
        Me.rdb_dolares.Text = "Dolares"
        Me.rdb_dolares.UseVisualStyleBackColor = True
        '
        'rdb_soles
        '
        Me.rdb_soles.AutoSize = True
        Me.rdb_soles.ForeColor = System.Drawing.Color.Navy
        Me.rdb_soles.Location = New System.Drawing.Point(10, 11)
        Me.rdb_soles.Name = "rdb_soles"
        Me.rdb_soles.Size = New System.Drawing.Size(51, 17)
        Me.rdb_soles.TabIndex = 179
        Me.rdb_soles.Text = "Soles"
        Me.rdb_soles.UseVisualStyleBackColor = True
        '
        'gb_tipo
        '
        Me.gb_tipo.Controls.Add(Me.rdb_ambos)
        Me.gb_tipo.Controls.Add(Me.rdb_solo_saldos)
        Me.gb_tipo.Controls.Add(Me.rdb_solo_retencion)
        Me.gb_tipo.ForeColor = System.Drawing.Color.Navy
        Me.gb_tipo.Location = New System.Drawing.Point(756, 84)
        Me.gb_tipo.Name = "gb_tipo"
        Me.gb_tipo.Size = New System.Drawing.Size(116, 78)
        Me.gb_tipo.TabIndex = 185
        Me.gb_tipo.TabStop = False
        Me.gb_tipo.Text = "Tipo"
        Me.gb_tipo.Visible = False
        '
        'rdb_ambos
        '
        Me.rdb_ambos.AutoSize = True
        Me.rdb_ambos.Checked = True
        Me.rdb_ambos.ForeColor = System.Drawing.Color.Navy
        Me.rdb_ambos.Location = New System.Drawing.Point(10, 54)
        Me.rdb_ambos.Name = "rdb_ambos"
        Me.rdb_ambos.Size = New System.Drawing.Size(57, 17)
        Me.rdb_ambos.TabIndex = 181
        Me.rdb_ambos.TabStop = True
        Me.rdb_ambos.Text = "Ambos"
        Me.rdb_ambos.UseVisualStyleBackColor = True
        '
        'rdb_solo_saldos
        '
        Me.rdb_solo_saldos.AutoSize = True
        Me.rdb_solo_saldos.ForeColor = System.Drawing.Color.Navy
        Me.rdb_solo_saldos.Location = New System.Drawing.Point(10, 32)
        Me.rdb_solo_saldos.Name = "rdb_solo_saldos"
        Me.rdb_solo_saldos.Size = New System.Drawing.Size(81, 17)
        Me.rdb_solo_saldos.TabIndex = 180
        Me.rdb_solo_saldos.Text = "Solo Saldos"
        Me.rdb_solo_saldos.UseVisualStyleBackColor = True
        '
        'rdb_solo_retencion
        '
        Me.rdb_solo_retencion.AutoSize = True
        Me.rdb_solo_retencion.ForeColor = System.Drawing.Color.Navy
        Me.rdb_solo_retencion.Location = New System.Drawing.Point(10, 11)
        Me.rdb_solo_retencion.Name = "rdb_solo_retencion"
        Me.rdb_solo_retencion.Size = New System.Drawing.Size(98, 17)
        Me.rdb_solo_retencion.TabIndex = 179
        Me.rdb_solo_retencion.Text = "Solo Retención"
        Me.rdb_solo_retencion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbClientes)
        Me.GroupBox1.Controls.Add(Me.rbVendedor)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.chk_todos_series)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_cob)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.rbMes)
        Me.GroupBox1.Controls.Add(Me.rbFechas)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 177)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opción"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.chklstdocumentos)
        Me.GroupBox9.Controls.Add(Me.checkDocumentos)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(211, 47)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(193, 121)
        Me.GroupBox9.TabIndex = 187
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
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chklstAlmacenes)
        Me.GroupBox8.Controls.Add(Me.checkAlmacen)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(8, 47)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(193, 121)
        Me.GroupBox8.TabIndex = 186
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Series"
        '
        'chklstAlmacenes
        '
        Me.chklstAlmacenes.CheckOnClick = True
        Me.chklstAlmacenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstAlmacenes.FormattingEnabled = True
        Me.chklstAlmacenes.Location = New System.Drawing.Point(8, 37)
        Me.chklstAlmacenes.Name = "chklstAlmacenes"
        Me.chklstAlmacenes.Size = New System.Drawing.Size(176, 79)
        Me.chklstAlmacenes.TabIndex = 5
        '
        'checkAlmacen
        '
        Me.checkAlmacen.AutoSize = True
        Me.checkAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkAlmacen.ForeColor = System.Drawing.Color.Navy
        Me.checkAlmacen.Location = New System.Drawing.Point(10, 18)
        Me.checkAlmacen.Name = "checkAlmacen"
        Me.checkAlmacen.Size = New System.Drawing.Size(92, 17)
        Me.checkAlmacen.TabIndex = 4
        Me.checkAlmacen.Text = "Activar Todos"
        Me.checkAlmacen.UseVisualStyleBackColor = True
        '
        'chk_todos_series
        '
        Me.chk_todos_series.AutoSize = True
        Me.chk_todos_series.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_series.Location = New System.Drawing.Point(621, 18)
        Me.chk_todos_series.Name = "chk_todos_series"
        Me.chk_todos_series.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos_series.TabIndex = 185
        Me.chk_todos_series.Text = "Todos"
        Me.chk_todos_series.UseVisualStyleBackColor = True
        Me.chk_todos_series.Visible = False
        '
        'cmb_tipo_cob
        '
        Me.cmb_tipo_cob.DropDownHeight = 100
        Me.cmb_tipo_cob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_cob.DropDownWidth = 300
        Me.cmb_tipo_cob.FormattingEnabled = True
        Me.cmb_tipo_cob.IntegralHeight = False
        Me.cmb_tipo_cob.Location = New System.Drawing.Point(501, 16)
        Me.cmb_tipo_cob.MaxDropDownItems = 10
        Me.cmb_tipo_cob.Name = "cmb_tipo_cob"
        Me.cmb_tipo_cob.Size = New System.Drawing.Size(114, 21)
        Me.cmb_tipo_cob.TabIndex = 184
        Me.cmb_tipo_cob.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdb_vcto)
        Me.GroupBox5.Controls.Add(Me.rdb_emision)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.dtp_ff_opt)
        Me.GroupBox5.Controls.Add(Me.dtp_fi_opt)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(417, 47)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(307, 94)
        Me.GroupBox5.TabIndex = 182
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Opción de fechas"
        '
        'rdb_vcto
        '
        Me.rdb_vcto.AutoSize = True
        Me.rdb_vcto.ForeColor = System.Drawing.Color.Navy
        Me.rdb_vcto.Location = New System.Drawing.Point(198, 58)
        Me.rdb_vcto.Name = "rdb_vcto"
        Me.rdb_vcto.Size = New System.Drawing.Size(102, 17)
        Me.rdb_vcto.TabIndex = 180
        Me.rdb_vcto.Text = "Docs. con Vcto."
        Me.rdb_vcto.UseVisualStyleBackColor = True
        '
        'rdb_emision
        '
        Me.rdb_emision.AutoSize = True
        Me.rdb_emision.Checked = True
        Me.rdb_emision.ForeColor = System.Drawing.Color.Navy
        Me.rdb_emision.Location = New System.Drawing.Point(198, 26)
        Me.rdb_emision.Name = "rdb_emision"
        Me.rdb_emision.Size = New System.Drawing.Size(97, 17)
        Me.rdb_emision.TabIndex = 179
        Me.rdb_emision.TabStop = True
        Me.rdb_emision.Text = "Docs. con Emi."
        Me.rdb_emision.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(12, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha Final"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(7, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha Inicial"
        '
        'dtp_ff_opt
        '
        Me.dtp_ff_opt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff_opt.Location = New System.Drawing.Point(79, 56)
        Me.dtp_ff_opt.Name = "dtp_ff_opt"
        Me.dtp_ff_opt.Size = New System.Drawing.Size(106, 20)
        Me.dtp_ff_opt.TabIndex = 1
        '
        'dtp_fi_opt
        '
        Me.dtp_fi_opt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi_opt.Location = New System.Drawing.Point(79, 24)
        Me.dtp_fi_opt.Name = "dtp_fi_opt"
        Me.dtp_fi_opt.Size = New System.Drawing.Size(106, 20)
        Me.dtp_fi_opt.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(456, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 13)
        Me.Label22.TabIndex = 183
        Me.Label22.Text = "Series"
        Me.Label22.Visible = False
        '
        'rbMes
        '
        Me.rbMes.AutoSize = True
        Me.rbMes.ForeColor = System.Drawing.Color.Navy
        Me.rbMes.Location = New System.Drawing.Point(463, 56)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(64, 17)
        Me.rbMes.TabIndex = 181
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Por &Mes"
        Me.rbMes.UseVisualStyleBackColor = True
        Me.rbMes.Visible = False
        '
        'rbVendedor
        '
        Me.rbVendedor.AutoSize = True
        Me.rbVendedor.ForeColor = System.Drawing.Color.Navy
        Me.rbVendedor.Location = New System.Drawing.Point(124, 22)
        Me.rbVendedor.Name = "rbVendedor"
        Me.rbVendedor.Size = New System.Drawing.Size(90, 17)
        Me.rbVendedor.TabIndex = 179
        Me.rbVendedor.TabStop = True
        Me.rbVendedor.Text = "Por &Vendedor"
        Me.rbVendedor.UseVisualStyleBackColor = True
        '
        'rbFechas
        '
        Me.rbFechas.AutoSize = True
        Me.rbFechas.ForeColor = System.Drawing.Color.Navy
        Me.rbFechas.Location = New System.Drawing.Point(384, 56)
        Me.rbFechas.Name = "rbFechas"
        Me.rbFechas.Size = New System.Drawing.Size(79, 17)
        Me.rbFechas.TabIndex = 180
        Me.rbFechas.TabStop = True
        Me.rbFechas.Text = "Por &Fechas"
        Me.rbFechas.UseVisualStyleBackColor = True
        Me.rbFechas.Visible = False
        '
        'rbClientes
        '
        Me.rbClientes.AutoSize = True
        Me.rbClientes.Checked = True
        Me.rbClientes.ForeColor = System.Drawing.Color.Navy
        Me.rbClientes.Location = New System.Drawing.Point(18, 22)
        Me.rbClientes.Name = "rbClientes"
        Me.rbClientes.Size = New System.Drawing.Size(81, 17)
        Me.rbClientes.TabIndex = 178
        Me.rbClientes.TabStop = True
        Me.rbClientes.Text = "Por &Clientes"
        Me.rbClientes.UseVisualStyleBackColor = True
        '
        'checkTodos
        '
        Me.checkTodos.AutoSize = True
        Me.checkTodos.ForeColor = System.Drawing.Color.Navy
        Me.checkTodos.Location = New System.Drawing.Point(769, 55)
        Me.checkTodos.Name = "checkTodos"
        Me.checkTodos.Size = New System.Drawing.Size(91, 30)
        Me.checkTodos.TabIndex = 177
        Me.checkTodos.Text = "Marcar todos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los Registros."
        Me.checkTodos.UseVisualStyleBackColor = True
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(17, 472)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 176
        Me.lblCantidad.Text = "."
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(12, 198)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(818, 47)
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
        Me.txtFiltro.Size = New System.Drawing.Size(806, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        Me.dgvDocumentos.AllowUserToDeleteRows = False
        Me.dgvDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(12, 252)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(1036, 215)
        Me.dgvDocumentos.TabIndex = 0
        '
        'rdb_resumido
        '
        Me.rdb_resumido.AutoSize = True
        Me.rdb_resumido.ForeColor = System.Drawing.Color.Navy
        Me.rdb_resumido.Location = New System.Drawing.Point(550, 98)
        Me.rdb_resumido.Name = "rdb_resumido"
        Me.rdb_resumido.Size = New System.Drawing.Size(72, 17)
        Me.rdb_resumido.TabIndex = 187
        Me.rdb_resumido.Text = "Resumido"
        Me.rdb_resumido.UseVisualStyleBackColor = True
        Me.rdb_resumido.Visible = False
        '
        'rdb_detallado
        '
        Me.rdb_detallado.AutoSize = True
        Me.rdb_detallado.ForeColor = System.Drawing.Color.Navy
        Me.rdb_detallado.Location = New System.Drawing.Point(550, 75)
        Me.rdb_detallado.Name = "rdb_detallado"
        Me.rdb_detallado.Size = New System.Drawing.Size(70, 17)
        Me.rdb_detallado.TabIndex = 186
        Me.rdb_detallado.Text = "Detallado"
        Me.rdb_detallado.UseVisualStyleBackColor = True
        Me.rdb_detallado.Visible = False
        '
        'pnlFecha
        '
        Me.pnlFecha.BackColor = System.Drawing.Color.Transparent
        Me.pnlFecha.Controls.Add(Me.GroupBox2)
        Me.pnlFecha.Controls.Add(Me.GroupBox3)
        Me.pnlFecha.Location = New System.Drawing.Point(145, 213)
        Me.pnlFecha.Name = "pnlFecha"
        Me.pnlFecha.Size = New System.Drawing.Size(401, 222)
        Me.pnlFecha.TabIndex = 3
        Me.pnlFecha.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpemision_fin)
        Me.GroupBox2.Controls.Add(Me.dtpemisioninicio)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(14, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 92)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emision por Fechas"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(133, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 37)
        Me.Button1.TabIndex = 175
        Me.Button1.Text = "&Mostrar"
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
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(194, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 37)
        Me.Button2.TabIndex = 176
        Me.Button2.Text = "&Salir"
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
        'dtpemision_fin
        '
        Me.dtpemision_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpemision_fin.Location = New System.Drawing.Point(255, 24)
        Me.dtpemision_fin.Name = "dtpemision_fin"
        Me.dtpemision_fin.Size = New System.Drawing.Size(106, 20)
        Me.dtpemision_fin.TabIndex = 1
        '
        'dtpemisioninicio
        '
        Me.dtpemisioninicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpemisioninicio.Location = New System.Drawing.Point(79, 24)
        Me.dtpemisioninicio.Name = "dtpemisioninicio"
        Me.dtpemisioninicio.Size = New System.Drawing.Size(106, 20)
        Me.dtpemisioninicio.TabIndex = 0
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
        Me.GroupBox3.Location = New System.Drawing.Point(14, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 92)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vencimiento por Fechas"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_aceptar.Location = New System.Drawing.Point(133, 49)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(59, 37)
        Me.btn_aceptar.TabIndex = 175
        Me.btn_aceptar.Text = "&Mostrar"
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
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_close.Location = New System.Drawing.Point(194, 49)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(59, 37)
        Me.btn_close.TabIndex = 176
        Me.btn_close.Text = "&Salir"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ok, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1208, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_ok
        '
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(121, 22)
        Me.btn_ok.Text = "Mostrar &Reporte"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'pnlMensual
        '
        Me.pnlMensual.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlMensual.Controls.Add(Me.GroupBox4)
        Me.pnlMensual.Location = New System.Drawing.Point(381, 79)
        Me.pnlMensual.Name = "pnlMensual"
        Me.pnlMensual.Size = New System.Drawing.Size(566, 219)
        Me.pnlMensual.TabIndex = 5
        Me.pnlMensual.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox11)
        Me.GroupBox4.Controls.Add(Me.GroupBox10)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.dtp_mensual)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(14, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(537, 184)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reporte Mensual"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.chklstdocumentos2)
        Me.GroupBox11.Controls.Add(Me.checkDocumentos2)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox11.Location = New System.Drawing.Point(243, 50)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(193, 122)
        Me.GroupBox11.TabIndex = 188
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Tipo de Documento"
        '
        'chklstdocumentos2
        '
        Me.chklstdocumentos2.CheckOnClick = True
        Me.chklstdocumentos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstdocumentos2.FormattingEnabled = True
        Me.chklstdocumentos2.Location = New System.Drawing.Point(8, 37)
        Me.chklstdocumentos2.Name = "chklstdocumentos2"
        Me.chklstdocumentos2.Size = New System.Drawing.Size(176, 79)
        Me.chklstdocumentos2.TabIndex = 5
        '
        'checkDocumentos2
        '
        Me.checkDocumentos2.AutoSize = True
        Me.checkDocumentos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkDocumentos2.ForeColor = System.Drawing.Color.Navy
        Me.checkDocumentos2.Location = New System.Drawing.Point(10, 18)
        Me.checkDocumentos2.Name = "checkDocumentos2"
        Me.checkDocumentos2.Size = New System.Drawing.Size(92, 17)
        Me.checkDocumentos2.TabIndex = 4
        Me.checkDocumentos2.Text = "Activar Todos"
        Me.checkDocumentos2.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.chklstAlmacenes2)
        Me.GroupBox10.Controls.Add(Me.checkAlmacen2)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox10.Location = New System.Drawing.Point(16, 50)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(209, 122)
        Me.GroupBox10.TabIndex = 187
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Series"
        '
        'chklstAlmacenes2
        '
        Me.chklstAlmacenes2.CheckOnClick = True
        Me.chklstAlmacenes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstAlmacenes2.FormattingEnabled = True
        Me.chklstAlmacenes2.Location = New System.Drawing.Point(8, 37)
        Me.chklstAlmacenes2.Name = "chklstAlmacenes2"
        Me.chklstAlmacenes2.Size = New System.Drawing.Size(188, 79)
        Me.chklstAlmacenes2.TabIndex = 5
        '
        'checkAlmacen2
        '
        Me.checkAlmacen2.AutoSize = True
        Me.checkAlmacen2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkAlmacen2.ForeColor = System.Drawing.Color.Navy
        Me.checkAlmacen2.Location = New System.Drawing.Point(10, 18)
        Me.checkAlmacen2.Name = "checkAlmacen2"
        Me.checkAlmacen2.Size = New System.Drawing.Size(92, 17)
        Me.checkAlmacen2.TabIndex = 4
        Me.checkAlmacen2.Text = "Activar Todos"
        Me.checkAlmacen2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(462, 44)
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
        Me.Button4.Location = New System.Drawing.Point(462, 105)
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
        Me.Label6.Location = New System.Drawing.Point(13, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Mes y Año"
        '
        'dtp_mensual
        '
        Me.dtp_mensual.CustomFormat = "MMMM/yyyy"
        Me.dtp_mensual.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_mensual.Location = New System.Drawing.Point(85, 23)
        Me.dtp_mensual.Name = "dtp_mensual"
        Me.dtp_mensual.Size = New System.Drawing.Size(141, 20)
        Me.dtp_mensual.TabIndex = 0
        '
        'rpt_mensual
        '
        Me.rpt_mensual.AutoSize = True
        Me.rpt_mensual.ForeColor = System.Drawing.Color.Navy
        Me.rpt_mensual.Location = New System.Drawing.Point(1084, 52)
        Me.rpt_mensual.Name = "rpt_mensual"
        Me.rpt_mensual.Size = New System.Drawing.Size(106, 17)
        Me.rpt_mensual.TabIndex = 180
        Me.rpt_mensual.Text = "Reporte Mensual"
        Me.rpt_mensual.UseVisualStyleBackColor = True
        '
        'FrmReportePendienteCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1208, 536)
        Me.Controls.Add(Me.rpt_mensual)
        Me.Controls.Add(Me.pnlMensual)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlFecha)
        Me.Controls.Add(Me.gbReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReportePendienteCobro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte pendiente de cobro"
        Me.gbReporte.ResumeLayout(False)
        Me.gbReporte.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gb_tipo.ResumeLayout(False)
        Me.gb_tipo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
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
    Friend WithEvents rbVendedor As System.Windows.Forms.RadioButton
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpemision_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpemisioninicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents pnlMensual As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_mensual As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb_tipo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ambos As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_solo_saldos As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_solo_retencion As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_vcto As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_emision As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff_opt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi_opt As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdb_resumido As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_detallado As System.Windows.Forms.RadioButton
    Private WithEvents cmb_tipo_cob As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents chk_todos_series As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ambos_monedas As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_dolares As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_soles As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_resumido_general As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_detallado_general As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents chklstAlmacenes As System.Windows.Forms.CheckedListBox
    Friend WithEvents checkAlmacen As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents chklstdocumentos As System.Windows.Forms.CheckedListBox
    Friend WithEvents checkDocumentos As System.Windows.Forms.CheckBox
    Friend WithEvents rpt_mensual As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents chklstAlmacenes2 As CheckedListBox
    Friend WithEvents checkAlmacen2 As CheckBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents chklstdocumentos2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents checkDocumentos2 As System.Windows.Forms.CheckBox
End Class
