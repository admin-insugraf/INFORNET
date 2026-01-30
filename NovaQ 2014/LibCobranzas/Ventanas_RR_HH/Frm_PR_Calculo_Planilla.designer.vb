<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PR_Calculo_Planilla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PR_Calculo_Planilla))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.lblDetalle = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.checkTodos = New System.Windows.Forms.CheckBox()
        Me.mtb_total_aportes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtb_total_onp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtb_total_afp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtb_total_neto_pagar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvDetalle1 = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO_DOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS_NOMBRES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BASICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS_MES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUSPENSION_PERFECTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FALTAS_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARDANZAS_H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRABAJO_DESCANSO_DIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOMINGOS_FERIADOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS_EFECTIVOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAS_TRABAJADAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_HORAS_NORMALES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HR_EXT_25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HR_EXT_35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HR_EXT_100 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_HR_EXT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INASISTENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARDANZAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRABAJO_DESCANSO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMUNERACION_BASICA_EFECTIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASIG_FAMILIAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMISIONES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REM_HR_EXT_25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REM_HR_EXT_35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REM_HR_EXT_100 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_REM_HR_EXT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_REMUNERACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMUNERACION_AFECTA_ESSALUD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMUNERACION_AFECTA_AFP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTROS_INGRESOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_INGRESOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESSALUD_VIDA_ASEG_PENSION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ONP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AFP_APORTE_OBLIGATORIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AFP_COMISION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AFP_PRIMA_SEG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_AFP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADELANTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTROS_DESCUENTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_DESCUENTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NETO_PAGAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESSALUD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCTR_SALUD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCTR_PENSION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SENATI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_APORTES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AFP_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APORTE_OBLIGATORIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMISION_VARIABLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMISION_MIXTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRIMA_SEGURO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EPS_POR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirBoletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_personal_id_variables = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gb_Descuentos = New System.Windows.Forms.GroupBox()
        Me.dgv_descuentos = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarDescuentoVariableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gb_ingresos = New System.Windows.Forms.GroupBox()
        Me.dgv_ingresos = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarIngresoVariableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_mas = New System.Windows.Forms.Button()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.dgv_lista_conceptos_variables = New System.Windows.Forms.DataGridView()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.btn_Finalizar = New System.Windows.Forms.Button()
        Me.btn_anexar = New System.Windows.Forms.Button()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.dtpFecha_planilla = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_reapertura_planilla = New System.Windows.Forms.ToolStripButton()
        Me.btn_exportar = New System.Windows.Forms.ToolStripButton()
        Me.btn_exportar_ftp = New System.Windows.Forms.ToolStripButton()
        Me.btn_afpnet = New System.Windows.Forms.ToolStripButton()
        Me.btn_Generar_Plame = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.pnl_exporta_boletas = New System.Windows.Forms.Panel()
        Me.btn_cancelar_exp = New System.Windows.Forms.Button()
        Me.btn_exporta_boletas = New System.Windows.Forms.Button()
        Me.btn_genera_pdf_boletas = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.dtpFecha_planilla_2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnl_exportar_plame = New System.Windows.Forms.Panel()
        Me.chk_tasa_sctr = New System.Windows.Forms.CheckBox()
        Me.chk_Remuneración = New System.Windows.Forms.CheckBox()
        Me.chk_jor = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_exp_plames = New System.Windows.Forms.Button()
        Me.txt_ruta_plame = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dtp_plame = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlCabecera.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvDetalle1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb_Descuentos.SuspendLayout()
        CType(Me.dgv_descuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.gb_ingresos.SuspendLayout()
        CType(Me.dgv_ingresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.dgv_lista_conceptos_variables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCabecera.SuspendLayout()
        Me.btn_menu.SuspendLayout()
        Me.pnl_exporta_boletas.SuspendLayout()
        Me.pnl_exportar_plame.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.BackColor = System.Drawing.Color.White
        Me.pnlCabecera.Controls.Add(Me.lblDetalle)
        Me.pnlCabecera.Controls.Add(Me.lblCantidad)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(11, 36)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1003, 541)
        Me.pnlCabecera.TabIndex = 231
        '
        'lblDetalle
        '
        Me.lblDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetalle.BackColor = System.Drawing.Color.White
        Me.lblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalle.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblDetalle.Location = New System.Drawing.Point(6, 11)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(988, 20)
        Me.lblDetalle.TabIndex = 195
        Me.lblDetalle.Text = "LISTA DE CALCULO DE PLANILLAS"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(11, 515)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 124
        Me.lblCantidad.Text = "."
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(485, 45)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(367, 45)
        Me.gbRangofechas.TabIndex = 123
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(187, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(254, 14)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(11, 20)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 13)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Fecha inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(86, 14)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(7, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 45)
        Me.GroupBox3.TabIndex = 121
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(292, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(320, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 45)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Año de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(152, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCabecera.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(7, 102)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(988, 407)
        Me.dgvCabecera.TabIndex = 2
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Location = New System.Drawing.Point(23, 131)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(979, 441)
        Me.tc_tipos.TabIndex = 234
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.checkTodos)
        Me.TabPage1.Controls.Add(Me.mtb_total_aportes)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.mtb_total_onp)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.mtb_total_afp)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.mtb_total_neto_pagar)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.dgvDetalle1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(971, 415)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LISTA DE PERSONAL"
        '
        'checkTodos
        '
        Me.checkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkTodos.AutoSize = True
        Me.checkTodos.ForeColor = System.Drawing.Color.Navy
        Me.checkTodos.Location = New System.Drawing.Point(9, 372)
        Me.checkTodos.Name = "checkTodos"
        Me.checkTodos.Size = New System.Drawing.Size(154, 17)
        Me.checkTodos.TabIndex = 179
        Me.checkTodos.Text = "Marcar todos los Registros."
        Me.checkTodos.UseVisualStyleBackColor = True
        '
        'mtb_total_aportes
        '
        Me.mtb_total_aportes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_total_aportes.BackColor = System.Drawing.Color.LightSkyBlue
        Me.mtb_total_aportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_total_aportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_total_aportes.ForeColor = System.Drawing.Color.Green
        Me.mtb_total_aportes.Location = New System.Drawing.Point(947, 370)
        Me.mtb_total_aportes.Name = "mtb_total_aportes"
        Me.mtb_total_aportes.ReadOnly = True
        Me.mtb_total_aportes.Size = New System.Drawing.Size(103, 20)
        Me.mtb_total_aportes.TabIndex = 123
        Me.mtb_total_aportes.Text = "0.0"
        Me.mtb_total_aportes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(871, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Total Aportes"
        '
        'mtb_total_onp
        '
        Me.mtb_total_onp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_total_onp.BackColor = System.Drawing.Color.Lavender
        Me.mtb_total_onp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_total_onp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_total_onp.ForeColor = System.Drawing.Color.Green
        Me.mtb_total_onp.Location = New System.Drawing.Point(497, 370)
        Me.mtb_total_onp.Name = "mtb_total_onp"
        Me.mtb_total_onp.ReadOnly = True
        Me.mtb_total_onp.Size = New System.Drawing.Size(103, 20)
        Me.mtb_total_onp.TabIndex = 121
        Me.mtb_total_onp.Text = "0.0"
        Me.mtb_total_onp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(434, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Total ONP"
        '
        'mtb_total_afp
        '
        Me.mtb_total_afp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_total_afp.BackColor = System.Drawing.Color.LavenderBlush
        Me.mtb_total_afp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_total_afp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_total_afp.ForeColor = System.Drawing.Color.Green
        Me.mtb_total_afp.Location = New System.Drawing.Point(722, 370)
        Me.mtb_total_afp.Name = "mtb_total_afp"
        Me.mtb_total_afp.ReadOnly = True
        Me.mtb_total_afp.Size = New System.Drawing.Size(103, 20)
        Me.mtb_total_afp.TabIndex = 119
        Me.mtb_total_afp.Text = "0.0"
        Me.mtb_total_afp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(662, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Total AFP"
        '
        'mtb_total_neto_pagar
        '
        Me.mtb_total_neto_pagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_total_neto_pagar.BackColor = System.Drawing.Color.Pink
        Me.mtb_total_neto_pagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_total_neto_pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_total_neto_pagar.ForeColor = System.Drawing.Color.Green
        Me.mtb_total_neto_pagar.Location = New System.Drawing.Point(282, 370)
        Me.mtb_total_neto_pagar.Name = "mtb_total_neto_pagar"
        Me.mtb_total_neto_pagar.ReadOnly = True
        Me.mtb_total_neto_pagar.Size = New System.Drawing.Size(103, 20)
        Me.mtb_total_neto_pagar.TabIndex = 117
        Me.mtb_total_neto_pagar.Text = "0.0"
        Me.mtb_total_neto_pagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(179, 374)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "Total Neto a pagar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(3, 399)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(315, 13)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "***Marque los items que se registraran en la Planilla***"
        '
        'dgvDetalle1
        '
        Me.dgvDetalle1.AllowUserToAddRows = False
        Me.dgvDetalle1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalle1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.ITEM, Me.CODIGO, Me.NUMERO_DOC, Me.APELLIDOS_NOMBRES, Me.BASICO, Me.DIAS_MES, Me.SUSPENSION_PERFECTA, Me.FALTAS_D, Me.TARDANZAS_H, Me.TRABAJO_DESCANSO_DIAS, Me.DOMINGOS_FERIADOS, Me.DIAS_EFECTIVOS, Me.HORAS_TRABAJADAS, Me.TOTAL_HORAS_NORMALES, Me.HR_EXT_25, Me.HR_EXT_35, Me.HR_EXT_100, Me.TOTAL_HR_EXT, Me.INASISTENCIA, Me.TARDANZAS, Me.TRABAJO_DESCANSO, Me.REMUNERACION_BASICA_EFECTIVA, Me.ASIG_FAMILIAR, Me.COMISIONES, Me.REM_HR_EXT_25, Me.REM_HR_EXT_35, Me.REM_HR_EXT_100, Me.TOTAL_REM_HR_EXT, Me.TOTAL_REMUNERACION, Me.REMUNERACION_AFECTA_ESSALUD, Me.REMUNERACION_AFECTA_AFP, Me.OTROS_INGRESOS, Me.TOTAL_INGRESOS, Me.ESSALUD_VIDA_ASEG_PENSION, Me.ONP, Me.AFP_APORTE_OBLIGATORIO, Me.AFP_COMISION, Me.AFP_PRIMA_SEG, Me.TOTAL_AFP, Me.ADELANTO, Me.OTROS_DESCUENTOS, Me.TOTAL_DESCUENTOS, Me.NETO_PAGAR, Me.ESSALUD, Me.EPS, Me.SCTR_SALUD, Me.SCTR_PENSION, Me.SENATI, Me.TOTAL_APORTES, Me.AFP_ID, Me.APORTE_OBLIGATORIO, Me.COMISION_VARIABLE, Me.COMISION_MIXTA, Me.PRIMA_SEGURO, Me.EPS_POR})
        Me.dgvDetalle1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetalle1.EnableHeadersVisualStyles = False
        Me.dgvDetalle1.Location = New System.Drawing.Point(9, 10)
        Me.dgvDetalle1.Name = "dgvDetalle1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalle1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle1.Size = New System.Drawing.Size(952, 350)
        Me.dgvDetalle1.TabIndex = 113
        '
        'Sel
        '
        Me.Sel.DataPropertyName = "Sel"
        Me.Sel.HeaderText = "SEL"
        Me.Sel.Name = "Sel"
        Me.Sel.Width = 30
        '
        'ITEM
        '
        Me.ITEM.DataPropertyName = "ITEM"
        Me.ITEM.HeaderText = "N°"
        Me.ITEM.Name = "ITEM"
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "CODIGO"
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Visible = False
        '
        'NUMERO_DOC
        '
        Me.NUMERO_DOC.DataPropertyName = "NUMERO_DOC"
        Me.NUMERO_DOC.HeaderText = "NUMERO_DOC"
        Me.NUMERO_DOC.Name = "NUMERO_DOC"
        Me.NUMERO_DOC.Visible = False
        '
        'APELLIDOS_NOMBRES
        '
        Me.APELLIDOS_NOMBRES.DataPropertyName = "APELLIDOS_NOMBRES"
        Me.APELLIDOS_NOMBRES.HeaderText = "APELLIDOS Y NOMBRES"
        Me.APELLIDOS_NOMBRES.Name = "APELLIDOS_NOMBRES"
        '
        'BASICO
        '
        Me.BASICO.DataPropertyName = "BASICO"
        Me.BASICO.HeaderText = "BASICO"
        Me.BASICO.Name = "BASICO"
        '
        'DIAS_MES
        '
        Me.DIAS_MES.DataPropertyName = "DIAS_MES"
        Me.DIAS_MES.HeaderText = "DIAS EFECTIVOS"
        Me.DIAS_MES.Name = "DIAS_MES"
        '
        'SUSPENSION_PERFECTA
        '
        Me.SUSPENSION_PERFECTA.DataPropertyName = "SUSPENSION_PERFECTA"
        Me.SUSPENSION_PERFECTA.HeaderText = "SUSPENSION PERFECTA (DIAS)"
        Me.SUSPENSION_PERFECTA.Name = "SUSPENSION_PERFECTA"
        '
        'FALTAS_D
        '
        Me.FALTAS_D.DataPropertyName = "FALTAS_D"
        Me.FALTAS_D.HeaderText = "INASISTENCIA (DIAS)"
        Me.FALTAS_D.Name = "FALTAS_D"
        '
        'TARDANZAS_H
        '
        Me.TARDANZAS_H.DataPropertyName = "TARDANZAS_H"
        Me.TARDANZAS_H.HeaderText = "TARDANZAS (VALOR)"
        Me.TARDANZAS_H.Name = "TARDANZAS_H"
        '
        'TRABAJO_DESCANSO_DIAS
        '
        Me.TRABAJO_DESCANSO_DIAS.DataPropertyName = "TRABAJO_DESCANSO_DIAS"
        Me.TRABAJO_DESCANSO_DIAS.HeaderText = "TRABAJO EN DESCANSO O FERIADO (DIAS)"
        Me.TRABAJO_DESCANSO_DIAS.Name = "TRABAJO_DESCANSO_DIAS"
        '
        'DOMINGOS_FERIADOS
        '
        Me.DOMINGOS_FERIADOS.DataPropertyName = "DOMINGOS_FERIADOS"
        Me.DOMINGOS_FERIADOS.HeaderText = "DOMINGOS Y FERIADOS"
        Me.DOMINGOS_FERIADOS.Name = "DOMINGOS_FERIADOS"
        Me.DOMINGOS_FERIADOS.Visible = False
        '
        'DIAS_EFECTIVOS
        '
        Me.DIAS_EFECTIVOS.DataPropertyName = "DIAS_EFECTIVOS"
        Me.DIAS_EFECTIVOS.HeaderText = "DIAS EFECTIVOS"
        Me.DIAS_EFECTIVOS.Name = "DIAS_EFECTIVOS"
        Me.DIAS_EFECTIVOS.Visible = False
        '
        'HORAS_TRABAJADAS
        '
        Me.HORAS_TRABAJADAS.DataPropertyName = "HORAS_TRABAJADAS"
        Me.HORAS_TRABAJADAS.HeaderText = "HORAS TRAB."
        Me.HORAS_TRABAJADAS.Name = "HORAS_TRABAJADAS"
        Me.HORAS_TRABAJADAS.Visible = False
        '
        'TOTAL_HORAS_NORMALES
        '
        Me.TOTAL_HORAS_NORMALES.DataPropertyName = "TOTAL_HORAS_NORMALES"
        Me.TOTAL_HORAS_NORMALES.HeaderText = "TOT. HORAS NORMALES"
        Me.TOTAL_HORAS_NORMALES.Name = "TOTAL_HORAS_NORMALES"
        Me.TOTAL_HORAS_NORMALES.Visible = False
        '
        'HR_EXT_25
        '
        Me.HR_EXT_25.DataPropertyName = "HR_EXT_25"
        Me.HR_EXT_25.HeaderText = "HR. EXT. 25%"
        Me.HR_EXT_25.Name = "HR_EXT_25"
        '
        'HR_EXT_35
        '
        Me.HR_EXT_35.DataPropertyName = "HR_EXT_35"
        Me.HR_EXT_35.HeaderText = "HR. EXT. 35%"
        Me.HR_EXT_35.Name = "HR_EXT_35"
        '
        'HR_EXT_100
        '
        Me.HR_EXT_100.DataPropertyName = "HR_EXT_100"
        Me.HR_EXT_100.HeaderText = "HR. EXT. 100%"
        Me.HR_EXT_100.Name = "HR_EXT_100"
        '
        'TOTAL_HR_EXT
        '
        Me.TOTAL_HR_EXT.DataPropertyName = "TOTAL_HR_EXT"
        Me.TOTAL_HR_EXT.HeaderText = "TOTAL. HR. EXT"
        Me.TOTAL_HR_EXT.Name = "TOTAL_HR_EXT"
        '
        'INASISTENCIA
        '
        Me.INASISTENCIA.DataPropertyName = "INASISTENCIA"
        Me.INASISTENCIA.HeaderText = "INASISTENCIA"
        Me.INASISTENCIA.Name = "INASISTENCIA"
        '
        'TARDANZAS
        '
        Me.TARDANZAS.DataPropertyName = "TARDANZAS"
        Me.TARDANZAS.HeaderText = "TARDANZAS"
        Me.TARDANZAS.Name = "TARDANZAS"
        '
        'TRABAJO_DESCANSO
        '
        Me.TRABAJO_DESCANSO.DataPropertyName = "TRABAJO_DESCANSO"
        Me.TRABAJO_DESCANSO.HeaderText = "TRABAJO EN DESCANSO O FERIADO"
        Me.TRABAJO_DESCANSO.Name = "TRABAJO_DESCANSO"
        '
        'REMUNERACION_BASICA_EFECTIVA
        '
        Me.REMUNERACION_BASICA_EFECTIVA.DataPropertyName = "REMUNERACION_BASICA_EFECTIVA"
        Me.REMUNERACION_BASICA_EFECTIVA.HeaderText = "REM. BASICA EFECTIVA"
        Me.REMUNERACION_BASICA_EFECTIVA.Name = "REMUNERACION_BASICA_EFECTIVA"
        '
        'ASIG_FAMILIAR
        '
        Me.ASIG_FAMILIAR.DataPropertyName = "ASIG_FAMILIAR"
        Me.ASIG_FAMILIAR.HeaderText = "ASIG. FAMILIAR"
        Me.ASIG_FAMILIAR.Name = "ASIG_FAMILIAR"
        '
        'COMISIONES
        '
        Me.COMISIONES.DataPropertyName = "COMISIONES"
        Me.COMISIONES.HeaderText = "COMISIONES"
        Me.COMISIONES.Name = "COMISIONES"
        Me.COMISIONES.Visible = False
        '
        'REM_HR_EXT_25
        '
        Me.REM_HR_EXT_25.DataPropertyName = "REM_HR_EXT_25"
        Me.REM_HR_EXT_25.HeaderText = "REM. HR. EXT. 25%"
        Me.REM_HR_EXT_25.Name = "REM_HR_EXT_25"
        '
        'REM_HR_EXT_35
        '
        Me.REM_HR_EXT_35.DataPropertyName = "REM_HR_EXT_35"
        Me.REM_HR_EXT_35.HeaderText = "REM. HR. EXT. 35%"
        Me.REM_HR_EXT_35.Name = "REM_HR_EXT_35"
        '
        'REM_HR_EXT_100
        '
        Me.REM_HR_EXT_100.DataPropertyName = "REM_HR_EXT_100"
        Me.REM_HR_EXT_100.HeaderText = "REM. HR. EXT. 100%"
        Me.REM_HR_EXT_100.Name = "REM_HR_EXT_100"
        '
        'TOTAL_REM_HR_EXT
        '
        Me.TOTAL_REM_HR_EXT.DataPropertyName = "TOTAL_REM_HR_EXT"
        Me.TOTAL_REM_HR_EXT.HeaderText = "TOTAL HORAS EXTRAS"
        Me.TOTAL_REM_HR_EXT.Name = "TOTAL_REM_HR_EXT"
        '
        'TOTAL_REMUNERACION
        '
        Me.TOTAL_REMUNERACION.DataPropertyName = "TOTAL_REMUNERACION"
        Me.TOTAL_REMUNERACION.HeaderText = "TOTAL REMUNER"
        Me.TOTAL_REMUNERACION.Name = "TOTAL_REMUNERACION"
        '
        'REMUNERACION_AFECTA_ESSALUD
        '
        Me.REMUNERACION_AFECTA_ESSALUD.DataPropertyName = "REMUNERACION_AFECTA_ESSALUD"
        Me.REMUNERACION_AFECTA_ESSALUD.HeaderText = "REMUN. AFECTA A ESSALUD"
        Me.REMUNERACION_AFECTA_ESSALUD.Name = "REMUNERACION_AFECTA_ESSALUD"
        '
        'REMUNERACION_AFECTA_AFP
        '
        Me.REMUNERACION_AFECTA_AFP.DataPropertyName = "REMUNERACION_AFECTA_AFP"
        Me.REMUNERACION_AFECTA_AFP.HeaderText = "REMUN. AFECTA A AFP"
        Me.REMUNERACION_AFECTA_AFP.Name = "REMUNERACION_AFECTA_AFP"
        '
        'OTROS_INGRESOS
        '
        Me.OTROS_INGRESOS.DataPropertyName = "OTROS_INGRESOS"
        Me.OTROS_INGRESOS.HeaderText = "OTROS INGRESOS"
        Me.OTROS_INGRESOS.Name = "OTROS_INGRESOS"
        '
        'TOTAL_INGRESOS
        '
        Me.TOTAL_INGRESOS.DataPropertyName = "TOTAL_INGRESOS"
        Me.TOTAL_INGRESOS.HeaderText = "TOTAL INGRESOS"
        Me.TOTAL_INGRESOS.Name = "TOTAL_INGRESOS"
        '
        'ESSALUD_VIDA_ASEG_PENSION
        '
        Me.ESSALUD_VIDA_ASEG_PENSION.DataPropertyName = "ESSALUD_VIDA_ASEG_PENSION"
        Me.ESSALUD_VIDA_ASEG_PENSION.HeaderText = "ESSAL VIDA + ASEG. TU PENS."
        Me.ESSALUD_VIDA_ASEG_PENSION.Name = "ESSALUD_VIDA_ASEG_PENSION"
        '
        'ONP
        '
        Me.ONP.DataPropertyName = "ONP"
        Me.ONP.HeaderText = "ONP 13%"
        Me.ONP.Name = "ONP"
        '
        'AFP_APORTE_OBLIGATORIO
        '
        Me.AFP_APORTE_OBLIGATORIO.DataPropertyName = "AFP_APORTE_OBLIGATORIO"
        Me.AFP_APORTE_OBLIGATORIO.HeaderText = "AFP APORT OBLIG"
        Me.AFP_APORTE_OBLIGATORIO.Name = "AFP_APORTE_OBLIGATORIO"
        '
        'AFP_COMISION
        '
        Me.AFP_COMISION.DataPropertyName = "AFP_COMISION"
        Me.AFP_COMISION.HeaderText = "AFP COMISION"
        Me.AFP_COMISION.Name = "AFP_COMISION"
        '
        'AFP_PRIMA_SEG
        '
        Me.AFP_PRIMA_SEG.DataPropertyName = "AFP_PRIMA_SEG"
        Me.AFP_PRIMA_SEG.HeaderText = "AFP PRIMA SEG."
        Me.AFP_PRIMA_SEG.Name = "AFP_PRIMA_SEG"
        '
        'TOTAL_AFP
        '
        Me.TOTAL_AFP.DataPropertyName = "TOTAL_AFP"
        Me.TOTAL_AFP.HeaderText = "TOTAL AFP"
        Me.TOTAL_AFP.Name = "TOTAL_AFP"
        '
        'ADELANTO
        '
        Me.ADELANTO.DataPropertyName = "ADELANTO"
        Me.ADELANTO.HeaderText = "ADELANTO"
        Me.ADELANTO.Name = "ADELANTO"
        '
        'OTROS_DESCUENTOS
        '
        Me.OTROS_DESCUENTOS.DataPropertyName = "OTROS_DESCUENTOS"
        Me.OTROS_DESCUENTOS.HeaderText = "OTROS DESCUENTOS"
        Me.OTROS_DESCUENTOS.Name = "OTROS_DESCUENTOS"
        '
        'TOTAL_DESCUENTOS
        '
        Me.TOTAL_DESCUENTOS.DataPropertyName = "TOTAL_DESCUENTOS"
        Me.TOTAL_DESCUENTOS.HeaderText = "TOTAL DESCUENTOS"
        Me.TOTAL_DESCUENTOS.Name = "TOTAL_DESCUENTOS"
        '
        'NETO_PAGAR
        '
        Me.NETO_PAGAR.DataPropertyName = "NETO_PAGAR"
        Me.NETO_PAGAR.HeaderText = "NETO A PAGAR"
        Me.NETO_PAGAR.Name = "NETO_PAGAR"
        '
        'ESSALUD
        '
        Me.ESSALUD.DataPropertyName = "ESSALUD"
        Me.ESSALUD.HeaderText = "ESSALUD %"
        Me.ESSALUD.Name = "ESSALUD"
        '
        'EPS
        '
        Me.EPS.DataPropertyName = "EPS"
        Me.EPS.HeaderText = "EPS"
        Me.EPS.Name = "EPS"
        '
        'SCTR_SALUD
        '
        Me.SCTR_SALUD.DataPropertyName = "SCTR_SALUD"
        Me.SCTR_SALUD.HeaderText = "SCTR-SALUD"
        Me.SCTR_SALUD.Name = "SCTR_SALUD"
        '
        'SCTR_PENSION
        '
        Me.SCTR_PENSION.DataPropertyName = "SCTR_PENSION"
        Me.SCTR_PENSION.HeaderText = "SCTR-PENSION"
        Me.SCTR_PENSION.Name = "SCTR_PENSION"
        '
        'SENATI
        '
        Me.SENATI.DataPropertyName = "SENATI"
        Me.SENATI.HeaderText = "SENATI"
        Me.SENATI.Name = "SENATI"
        '
        'TOTAL_APORTES
        '
        Me.TOTAL_APORTES.DataPropertyName = "TOTAL_APORTES"
        Me.TOTAL_APORTES.HeaderText = "TOTAL APORTES"
        Me.TOTAL_APORTES.Name = "TOTAL_APORTES"
        '
        'AFP_ID
        '
        Me.AFP_ID.DataPropertyName = "AFP_ID"
        Me.AFP_ID.HeaderText = "AFP_ID"
        Me.AFP_ID.Name = "AFP_ID"
        Me.AFP_ID.Visible = False
        '
        'APORTE_OBLIGATORIO
        '
        Me.APORTE_OBLIGATORIO.DataPropertyName = "APORTE_OBLIGATORIO"
        Me.APORTE_OBLIGATORIO.HeaderText = "APORTE_OBLIGATORIO"
        Me.APORTE_OBLIGATORIO.Name = "APORTE_OBLIGATORIO"
        Me.APORTE_OBLIGATORIO.Visible = False
        '
        'COMISION_VARIABLE
        '
        Me.COMISION_VARIABLE.DataPropertyName = "COMISION_VARIABLE"
        Me.COMISION_VARIABLE.HeaderText = "COMISION_VARIABLE"
        Me.COMISION_VARIABLE.Name = "COMISION_VARIABLE"
        Me.COMISION_VARIABLE.Visible = False
        '
        'COMISION_MIXTA
        '
        Me.COMISION_MIXTA.DataPropertyName = "COMISION_MIXTA"
        Me.COMISION_MIXTA.HeaderText = "COMISION_MIXTA"
        Me.COMISION_MIXTA.Name = "COMISION_MIXTA"
        Me.COMISION_MIXTA.Visible = False
        '
        'PRIMA_SEGURO
        '
        Me.PRIMA_SEGURO.DataPropertyName = "PRIMA_SEGURO"
        Me.PRIMA_SEGURO.HeaderText = "PRIMA_SEGURO"
        Me.PRIMA_SEGURO.Name = "PRIMA_SEGURO"
        Me.PRIMA_SEGURO.Visible = False
        '
        'EPS_POR
        '
        Me.EPS_POR.DataPropertyName = "EPS_POR"
        Me.EPS_POR.HeaderText = "EPS_POR"
        Me.EPS_POR.Name = "EPS_POR"
        Me.EPS_POR.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem, Me.ImprimirBoletaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(282, 48)
        '
        'RegistrarIngresosdescuentosVariablesToolStripMenuItem
        '
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem.Image = CType(resources.GetObject("RegistrarIngresosdescuentosVariablesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem.Name = "RegistrarIngresosdescuentosVariablesToolStripMenuItem"
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.RegistrarIngresosdescuentosVariablesToolStripMenuItem.Text = "Registrar ingresos/descuentos variables"
        '
        'ImprimirBoletaToolStripMenuItem
        '
        Me.ImprimirBoletaToolStripMenuItem.Image = CType(resources.GetObject("ImprimirBoletaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirBoletaToolStripMenuItem.Name = "ImprimirBoletaToolStripMenuItem"
        Me.ImprimirBoletaToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.ImprimirBoletaToolStripMenuItem.Text = "Imprimir Boleta de remuneración"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_personal_id_variables)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.gb_Descuentos)
        Me.TabPage2.Controls.Add(Me.gb_ingresos)
        Me.TabPage2.Controls.Add(Me.btn_mas)
        Me.TabPage2.Controls.Add(Me.GroupBox15)
        Me.TabPage2.Controls.Add(Me.btn_cancel)
        Me.TabPage2.Controls.Add(Me.btn_aceptar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(971, 415)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INGRESOS/DESCUENTOS VARIABLES"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_personal_id_variables
        '
        Me.txt_personal_id_variables.BackColor = System.Drawing.Color.Beige
        Me.txt_personal_id_variables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_personal_id_variables.ForeColor = System.Drawing.Color.Maroon
        Me.txt_personal_id_variables.Location = New System.Drawing.Point(94, 13)
        Me.txt_personal_id_variables.MaxLength = 250
        Me.txt_personal_id_variables.Name = "txt_personal_id_variables"
        Me.txt_personal_id_variables.ReadOnly = True
        Me.txt_personal_id_variables.Size = New System.Drawing.Size(509, 20)
        Me.txt_personal_id_variables.TabIndex = 272
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(14, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 271
        Me.Label7.Text = "PERSONAL"
        '
        'gb_Descuentos
        '
        Me.gb_Descuentos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_Descuentos.Controls.Add(Me.dgv_descuentos)
        Me.gb_Descuentos.ForeColor = System.Drawing.Color.Navy
        Me.gb_Descuentos.Location = New System.Drawing.Point(781, 38)
        Me.gb_Descuentos.Name = "gb_Descuentos"
        Me.gb_Descuentos.Size = New System.Drawing.Size(345, 365)
        Me.gb_Descuentos.TabIndex = 166
        Me.gb_Descuentos.TabStop = False
        Me.gb_Descuentos.Text = "Descuentos variables"
        '
        'dgv_descuentos
        '
        Me.dgv_descuentos.AllowUserToAddRows = False
        Me.dgv_descuentos.AllowUserToDeleteRows = False
        Me.dgv_descuentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_descuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_descuentos.ContextMenuStrip = Me.ContextMenuStrip3
        Me.dgv_descuentos.Location = New System.Drawing.Point(9, 17)
        Me.dgv_descuentos.Name = "dgv_descuentos"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_descuentos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_descuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_descuentos.Size = New System.Drawing.Size(326, 334)
        Me.dgv_descuentos.TabIndex = 155
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarDescuentoVariableToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(220, 26)
        '
        'EliminarDescuentoVariableToolStripMenuItem
        '
        Me.EliminarDescuentoVariableToolStripMenuItem.Image = CType(resources.GetObject("EliminarDescuentoVariableToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarDescuentoVariableToolStripMenuItem.Name = "EliminarDescuentoVariableToolStripMenuItem"
        Me.EliminarDescuentoVariableToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.EliminarDescuentoVariableToolStripMenuItem.Text = "Eliminar descuento variable"
        '
        'gb_ingresos
        '
        Me.gb_ingresos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_ingresos.Controls.Add(Me.dgv_ingresos)
        Me.gb_ingresos.ForeColor = System.Drawing.Color.Navy
        Me.gb_ingresos.Location = New System.Drawing.Point(426, 39)
        Me.gb_ingresos.Name = "gb_ingresos"
        Me.gb_ingresos.Size = New System.Drawing.Size(345, 365)
        Me.gb_ingresos.TabIndex = 165
        Me.gb_ingresos.TabStop = False
        Me.gb_ingresos.Text = "Ingresos variables"
        '
        'dgv_ingresos
        '
        Me.dgv_ingresos.AllowUserToAddRows = False
        Me.dgv_ingresos.AllowUserToDeleteRows = False
        Me.dgv_ingresos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ingresos.ContextMenuStrip = Me.ContextMenuStrip2
        Me.dgv_ingresos.Location = New System.Drawing.Point(9, 17)
        Me.dgv_ingresos.Name = "dgv_ingresos"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_ingresos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_ingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ingresos.Size = New System.Drawing.Size(326, 334)
        Me.dgv_ingresos.TabIndex = 155
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarIngresoVariableToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(204, 26)
        '
        'EliminarIngresoVariableToolStripMenuItem
        '
        Me.EliminarIngresoVariableToolStripMenuItem.Image = CType(resources.GetObject("EliminarIngresoVariableToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarIngresoVariableToolStripMenuItem.Name = "EliminarIngresoVariableToolStripMenuItem"
        Me.EliminarIngresoVariableToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EliminarIngresoVariableToolStripMenuItem.Text = "Eliminar ingreso variable"
        '
        'btn_mas
        '
        Me.btn_mas.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_mas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mas.ForeColor = System.Drawing.Color.Navy
        Me.btn_mas.Location = New System.Drawing.Point(348, 46)
        Me.btn_mas.Name = "btn_mas"
        Me.btn_mas.Size = New System.Drawing.Size(69, 36)
        Me.btn_mas.TabIndex = 161
        Me.btn_mas.Text = ">"
        Me.btn_mas.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox15.Controls.Add(Me.dgv_lista_conceptos_variables)
        Me.GroupBox15.Controls.Add(Me.txtbusqueda)
        Me.GroupBox15.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox15.Location = New System.Drawing.Point(14, 39)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(327, 365)
        Me.GroupBox15.TabIndex = 160
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Ingrese texto a Buscar :"
        '
        'dgv_lista_conceptos_variables
        '
        Me.dgv_lista_conceptos_variables.AllowUserToAddRows = False
        Me.dgv_lista_conceptos_variables.AllowUserToDeleteRows = False
        Me.dgv_lista_conceptos_variables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista_conceptos_variables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_conceptos_variables.Location = New System.Drawing.Point(7, 42)
        Me.dgv_lista_conceptos_variables.Name = "dgv_lista_conceptos_variables"
        Me.dgv_lista_conceptos_variables.ReadOnly = True
        Me.dgv_lista_conceptos_variables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_conceptos_variables.Size = New System.Drawing.Size(307, 314)
        Me.dgv_lista_conceptos_variables.TabIndex = 25
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbusqueda.BackColor = System.Drawing.Color.Aquamarine
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbusqueda.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(7, 16)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(307, 22)
        Me.txtbusqueda.TabIndex = 24
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.Location = New System.Drawing.Point(348, 360)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(69, 36)
        Me.btn_cancel.TabIndex = 164
        Me.btn_cancel.Text = "Cancelar"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Navy
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_aceptar.Location = New System.Drawing.Point(348, 318)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(69, 36)
        Me.btn_aceptar.TabIndex = 163
        Me.btn_aceptar.Text = "Registrar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'GbCabecera
        '
        Me.GbCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.btn_Finalizar)
        Me.GbCabecera.Controls.Add(Me.btn_anexar)
        Me.GbCabecera.Controls.Add(Me.txt_titulo)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.Label2)
        Me.GbCabecera.Controls.Add(Me.txtcodigo)
        Me.GbCabecera.Controls.Add(Me.dtpFecha_planilla)
        Me.GbCabecera.Controls.Add(Me.Label5)
        Me.GbCabecera.Location = New System.Drawing.Point(23, 46)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(979, 77)
        Me.GbCabecera.TabIndex = 233
        Me.GbCabecera.TabStop = False
        '
        'btn_Finalizar
        '
        Me.btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Finalizar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Finalizar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Finalizar.ForeColor = System.Drawing.Color.Green
        Me.btn_Finalizar.Image = CType(resources.GetObject("btn_Finalizar.Image"), System.Drawing.Image)
        Me.btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Finalizar.Location = New System.Drawing.Point(821, 13)
        Me.btn_Finalizar.Name = "btn_Finalizar"
        Me.btn_Finalizar.Size = New System.Drawing.Size(144, 56)
        Me.btn_Finalizar.TabIndex = 294
        Me.btn_Finalizar.Text = "&Finalizar Planilla"
        Me.btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Finalizar.UseVisualStyleBackColor = True
        '
        'btn_anexar
        '
        Me.btn_anexar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_anexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_anexar.ForeColor = System.Drawing.Color.Blue
        Me.btn_anexar.Image = CType(resources.GetObject("btn_anexar.Image"), System.Drawing.Image)
        Me.btn_anexar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_anexar.Location = New System.Drawing.Point(821, 13)
        Me.btn_anexar.Name = "btn_anexar"
        Me.btn_anexar.Size = New System.Drawing.Size(144, 56)
        Me.btn_anexar.TabIndex = 293
        Me.btn_anexar.Text = "&Anexar Personal"
        Me.btn_anexar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_anexar.UseVisualStyleBackColor = True
        '
        'txt_titulo
        '
        Me.txt_titulo.BackColor = System.Drawing.Color.White
        Me.txt_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_titulo.ForeColor = System.Drawing.Color.Maroon
        Me.txt_titulo.Location = New System.Drawing.Point(293, 17)
        Me.txt_titulo.MaxLength = 250
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(509, 20)
        Me.txt_titulo.TabIndex = 270
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(237, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 269
        Me.Label3.Text = "TITULO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(21, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "N° PLANILLA"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Location = New System.Drawing.Point(98, 17)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(110, 20)
        Me.txtcodigo.TabIndex = 210
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha_planilla
        '
        Me.dtpFecha_planilla.CalendarMonthBackground = System.Drawing.Color.Aquamarine
        Me.dtpFecha_planilla.CustomFormat = "MMMM/yyyy"
        Me.dtpFecha_planilla.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha_planilla.Location = New System.Drawing.Point(98, 45)
        Me.dtpFecha_planilla.Name = "dtpFecha_planilla"
        Me.dtpFecha_planilla.Size = New System.Drawing.Size(132, 20)
        Me.dtpFecha_planilla.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(26, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "Mes/Año"
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btn_reapertura_planilla, Me.btn_exportar, Me.btn_exportar_ftp, Me.btn_afpnet, Me.btn_Generar_Plame, Me.btnCancelar, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(1026, 25)
        Me.btn_menu.TabIndex = 232
        Me.btn_menu.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 22)
        Me.btnConsultar.Text = "&Consultar"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(73, 22)
        Me.btnGrabar.Text = "&Guardar"
        '
        'btn_reapertura_planilla
        '
        Me.btn_reapertura_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reapertura_planilla.Image = CType(resources.GetObject("btn_reapertura_planilla.Image"), System.Drawing.Image)
        Me.btn_reapertura_planilla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_reapertura_planilla.Name = "btn_reapertura_planilla"
        Me.btn_reapertura_planilla.Size = New System.Drawing.Size(121, 22)
        Me.btn_reapertura_planilla.Text = "Apertura Planilla"
        '
        'btn_exportar
        '
        Me.btn_exportar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exportar.Image = CType(resources.GetObject("btn_exportar.Image"), System.Drawing.Image)
        Me.btn_exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_exportar.Name = "btn_exportar"
        Me.btn_exportar.Size = New System.Drawing.Size(76, 22)
        Me.btn_exportar.Text = "&Exportar"
        Me.btn_exportar.Visible = False
        '
        'btn_exportar_ftp
        '
        Me.btn_exportar_ftp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exportar_ftp.Image = CType(resources.GetObject("btn_exportar_ftp.Image"), System.Drawing.Image)
        Me.btn_exportar_ftp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_exportar_ftp.Name = "btn_exportar_ftp"
        Me.btn_exportar_ftp.Size = New System.Drawing.Size(121, 22)
        Me.btn_exportar_ftp.Text = "Exportar Boletas"
        Me.btn_exportar_ftp.Visible = False
        '
        'btn_afpnet
        '
        Me.btn_afpnet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_afpnet.Image = CType(resources.GetObject("btn_afpnet.Image"), System.Drawing.Image)
        Me.btn_afpnet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_afpnet.Name = "btn_afpnet"
        Me.btn_afpnet.Size = New System.Drawing.Size(119, 22)
        Me.btn_afpnet.Text = "Generar AFP Net"
        Me.btn_afpnet.Visible = False
        '
        'btn_Generar_Plame
        '
        Me.btn_Generar_Plame.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_Generar_Plame.Image = CType(resources.GetObject("btn_Generar_Plame.Image"), System.Drawing.Image)
        Me.btn_Generar_Plame.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Generar_Plame.Name = "btn_Generar_Plame"
        Me.btn_Generar_Plame.Size = New System.Drawing.Size(111, 22)
        Me.btn_Generar_Plame.Text = "Generar Plame"
        Me.btn_Generar_Plame.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton7.Text = "&Salir"
        '
        'pnl_exporta_boletas
        '
        Me.pnl_exporta_boletas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_exporta_boletas.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_exporta_boletas.Controls.Add(Me.btn_cancelar_exp)
        Me.pnl_exporta_boletas.Controls.Add(Me.btn_exporta_boletas)
        Me.pnl_exporta_boletas.Controls.Add(Me.btn_genera_pdf_boletas)
        Me.pnl_exporta_boletas.Controls.Add(Me.txtRuta)
        Me.pnl_exporta_boletas.Controls.Add(Me.Label10)
        Me.pnl_exporta_boletas.Controls.Add(Me.btnRuta)
        Me.pnl_exporta_boletas.Controls.Add(Me.dtpFecha_planilla_2)
        Me.pnl_exporta_boletas.Controls.Add(Me.Label9)
        Me.pnl_exporta_boletas.Location = New System.Drawing.Point(23, 46)
        Me.pnl_exporta_boletas.Name = "pnl_exporta_boletas"
        Me.pnl_exporta_boletas.Size = New System.Drawing.Size(979, 77)
        Me.pnl_exporta_boletas.TabIndex = 235
        Me.pnl_exporta_boletas.Visible = False
        '
        'btn_cancelar_exp
        '
        Me.btn_cancelar_exp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar_exp.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancelar_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_exp.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancelar_exp.Image = CType(resources.GetObject("btn_cancelar_exp.Image"), System.Drawing.Image)
        Me.btn_cancelar_exp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar_exp.Location = New System.Drawing.Point(897, 35)
        Me.btn_cancelar_exp.Name = "btn_cancelar_exp"
        Me.btn_cancelar_exp.Size = New System.Drawing.Size(76, 35)
        Me.btn_cancelar_exp.TabIndex = 280
        Me.btn_cancelar_exp.Text = "Cancelar"
        Me.btn_cancelar_exp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar_exp.UseVisualStyleBackColor = True
        '
        'btn_exporta_boletas
        '
        Me.btn_exporta_boletas.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_exporta_boletas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exporta_boletas.ForeColor = System.Drawing.Color.Navy
        Me.btn_exporta_boletas.Image = CType(resources.GetObject("btn_exporta_boletas.Image"), System.Drawing.Image)
        Me.btn_exporta_boletas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exporta_boletas.Location = New System.Drawing.Point(692, 35)
        Me.btn_exporta_boletas.Name = "btn_exporta_boletas"
        Me.btn_exporta_boletas.Size = New System.Drawing.Size(124, 35)
        Me.btn_exporta_boletas.TabIndex = 279
        Me.btn_exporta_boletas.Text = "Exportar Boletas"
        Me.btn_exporta_boletas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exporta_boletas.UseVisualStyleBackColor = True
        Me.btn_exporta_boletas.Visible = False
        '
        'btn_genera_pdf_boletas
        '
        Me.btn_genera_pdf_boletas.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_genera_pdf_boletas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_genera_pdf_boletas.ForeColor = System.Drawing.Color.Navy
        Me.btn_genera_pdf_boletas.Image = CType(resources.GetObject("btn_genera_pdf_boletas.Image"), System.Drawing.Image)
        Me.btn_genera_pdf_boletas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_genera_pdf_boletas.Location = New System.Drawing.Point(562, 35)
        Me.btn_genera_pdf_boletas.Name = "btn_genera_pdf_boletas"
        Me.btn_genera_pdf_boletas.Size = New System.Drawing.Size(124, 35)
        Me.btn_genera_pdf_boletas.TabIndex = 278
        Me.btn_genera_pdf_boletas.Text = "Generar Boletas"
        Me.btn_genera_pdf_boletas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_genera_pdf_boletas.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(287, 6)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(527, 20)
        Me.txtRuta.TabIndex = 275
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(247, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 277
        Me.Label10.Text = "Ruta :"
        '
        'btnRuta
        '
        Me.btnRuta.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRuta.Location = New System.Drawing.Point(820, 5)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(25, 23)
        Me.btnRuta.TabIndex = 276
        Me.btnRuta.Text = "..."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'dtpFecha_planilla_2
        '
        Me.dtpFecha_planilla_2.CalendarMonthBackground = System.Drawing.Color.Aquamarine
        Me.dtpFecha_planilla_2.CustomFormat = "MMMM/yyyy"
        Me.dtpFecha_planilla_2.Enabled = False
        Me.dtpFecha_planilla_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha_planilla_2.Location = New System.Drawing.Point(107, 6)
        Me.dtpFecha_planilla_2.Name = "dtpFecha_planilla_2"
        Me.dtpFecha_planilla_2.Size = New System.Drawing.Size(132, 20)
        Me.dtpFecha_planilla_2.TabIndex = 273
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(49, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 274
        Me.Label9.Text = "Mes/Año"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pnl_exportar_plame
        '
        Me.pnl_exportar_plame.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_exportar_plame.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_exportar_plame.Controls.Add(Me.chk_tasa_sctr)
        Me.pnl_exportar_plame.Controls.Add(Me.chk_Remuneración)
        Me.pnl_exportar_plame.Controls.Add(Me.chk_jor)
        Me.pnl_exportar_plame.Controls.Add(Me.Button1)
        Me.pnl_exportar_plame.Controls.Add(Me.btn_exp_plames)
        Me.pnl_exportar_plame.Controls.Add(Me.txt_ruta_plame)
        Me.pnl_exportar_plame.Controls.Add(Me.Label12)
        Me.pnl_exportar_plame.Controls.Add(Me.Button4)
        Me.pnl_exportar_plame.Controls.Add(Me.dtp_plame)
        Me.pnl_exportar_plame.Controls.Add(Me.Label13)
        Me.pnl_exportar_plame.Location = New System.Drawing.Point(23, 46)
        Me.pnl_exportar_plame.Name = "pnl_exportar_plame"
        Me.pnl_exportar_plame.Size = New System.Drawing.Size(979, 77)
        Me.pnl_exportar_plame.TabIndex = 238
        Me.pnl_exportar_plame.Visible = False
        '
        'chk_tasa_sctr
        '
        Me.chk_tasa_sctr.AutoSize = True
        Me.chk_tasa_sctr.ForeColor = System.Drawing.Color.Navy
        Me.chk_tasa_sctr.Location = New System.Drawing.Point(322, 53)
        Me.chk_tasa_sctr.Name = "chk_tasa_sctr"
        Me.chk_tasa_sctr.Size = New System.Drawing.Size(125, 17)
        Me.chk_tasa_sctr.TabIndex = 283
        Me.chk_tasa_sctr.Text = "TASA SCTR SALUD"
        Me.chk_tasa_sctr.UseVisualStyleBackColor = True
        '
        'chk_Remuneración
        '
        Me.chk_Remuneración.AutoSize = True
        Me.chk_Remuneración.ForeColor = System.Drawing.Color.Navy
        Me.chk_Remuneración.Location = New System.Drawing.Point(195, 52)
        Me.chk_Remuneración.Name = "chk_Remuneración"
        Me.chk_Remuneración.Size = New System.Drawing.Size(114, 17)
        Me.chk_Remuneración.TabIndex = 282
        Me.chk_Remuneración.Text = "REMUNERACIÓN"
        Me.chk_Remuneración.UseVisualStyleBackColor = True
        '
        'chk_jor
        '
        Me.chk_jor.AutoSize = True
        Me.chk_jor.ForeColor = System.Drawing.Color.Navy
        Me.chk_jor.Location = New System.Drawing.Point(60, 53)
        Me.chk_jor.Name = "chk_jor"
        Me.chk_jor.Size = New System.Drawing.Size(129, 17)
        Me.chk_jor.TabIndex = 281
        Me.chk_jor.Text = "JORNADA LABORAL"
        Me.chk_jor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(897, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 35)
        Me.Button1.TabIndex = 280
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_exp_plames
        '
        Me.btn_exp_plames.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_exp_plames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exp_plames.ForeColor = System.Drawing.Color.Navy
        Me.btn_exp_plames.Image = CType(resources.GetObject("btn_exp_plames.Image"), System.Drawing.Image)
        Me.btn_exp_plames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exp_plames.Location = New System.Drawing.Point(721, 35)
        Me.btn_exp_plames.Name = "btn_exp_plames"
        Me.btn_exp_plames.Size = New System.Drawing.Size(124, 35)
        Me.btn_exp_plames.TabIndex = 278
        Me.btn_exp_plames.Text = "Generar Plames"
        Me.btn_exp_plames.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exp_plames.UseVisualStyleBackColor = True
        '
        'txt_ruta_plame
        '
        Me.txt_ruta_plame.Location = New System.Drawing.Point(287, 6)
        Me.txt_ruta_plame.Name = "txt_ruta_plame"
        Me.txt_ruta_plame.ReadOnly = True
        Me.txt_ruta_plame.Size = New System.Drawing.Size(527, 20)
        Me.txt_ruta_plame.TabIndex = 275
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(247, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 277
        Me.Label12.Text = "Ruta :"
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(820, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 23)
        Me.Button4.TabIndex = 276
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dtp_plame
        '
        Me.dtp_plame.CalendarMonthBackground = System.Drawing.Color.Aquamarine
        Me.dtp_plame.CustomFormat = "MMMM/yyyy"
        Me.dtp_plame.Enabled = False
        Me.dtp_plame.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_plame.Location = New System.Drawing.Point(107, 6)
        Me.dtp_plame.Name = "dtp_plame"
        Me.dtp_plame.Size = New System.Drawing.Size(132, 20)
        Me.dtp_plame.TabIndex = 273
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(49, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 274
        Me.Label13.Text = "Mes/Año"
        '
        'Frm_PR_Calculo_Planilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 582)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.pnl_exportar_plame)
        Me.Controls.Add(Me.pnl_exporta_boletas)
        Me.Controls.Add(Me.tc_tipos)
        Me.Controls.Add(Me.GbCabecera)
        Me.Controls.Add(Me.btn_menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_PR_Calculo_Planilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo de Planilla"
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvDetalle1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gb_Descuentos.ResumeLayout(False)
        CType(Me.dgv_descuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.gb_ingresos.ResumeLayout(False)
        CType(Me.dgv_ingresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.dgv_lista_conceptos_variables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.btn_menu.ResumeLayout(False)
        Me.btn_menu.PerformLayout()
        Me.pnl_exporta_boletas.ResumeLayout(False)
        Me.pnl_exporta_boletas.PerformLayout()
        Me.pnl_exportar_plame.ResumeLayout(False)
        Me.pnl_exportar_plame.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents mtb_total_neto_pagar As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle1 As System.Windows.Forms.DataGridView
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents btn_anexar As System.Windows.Forms.Button
    Friend WithEvents txt_titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha_planilla As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents mtb_total_aportes As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mtb_total_onp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb_total_afp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_ingresos As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_ingresos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_mas As System.Windows.Forms.Button
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_lista_conceptos_variables As System.Windows.Forms.DataGridView
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RegistrarIngresosdescuentosVariablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirBoletaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gb_Descuentos As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_descuentos As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarIngresoVariableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarDescuentoVariableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_personal_id_variables As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents checkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_reapertura_planilla As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_exportar_ftp As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_exporta_boletas As System.Windows.Forms.Panel
    Friend WithEvents dtpFecha_planilla_2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents btn_exporta_boletas As System.Windows.Forms.Button
    Friend WithEvents btn_genera_pdf_boletas As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar_exp As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERO_DOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS_NOMBRES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BASICO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIAS_MES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUSPENSION_PERFECTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FALTAS_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARDANZAS_H As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRABAJO_DESCANSO_DIAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOMINGOS_FERIADOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIAS_EFECTIVOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAS_TRABAJADAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_HORAS_NORMALES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HR_EXT_25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HR_EXT_35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HR_EXT_100 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_HR_EXT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INASISTENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARDANZAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRABAJO_DESCANSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMUNERACION_BASICA_EFECTIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ASIG_FAMILIAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMISIONES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REM_HR_EXT_25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REM_HR_EXT_35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REM_HR_EXT_100 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_REM_HR_EXT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_REMUNERACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMUNERACION_AFECTA_ESSALUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMUNERACION_AFECTA_AFP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTROS_INGRESOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_INGRESOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESSALUD_VIDA_ASEG_PENSION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ONP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AFP_APORTE_OBLIGATORIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AFP_COMISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AFP_PRIMA_SEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_AFP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADELANTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTROS_DESCUENTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_DESCUENTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NETO_PAGAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESSALUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCTR_SALUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCTR_PENSION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SENATI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_APORTES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AFP_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APORTE_OBLIGATORIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMISION_VARIABLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMISION_MIXTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRIMA_SEGURO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EPS_POR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnl_exportar_plame As System.Windows.Forms.Panel
    Friend WithEvents chk_tasa_sctr As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Remuneración As System.Windows.Forms.CheckBox
    Friend WithEvents chk_jor As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_exp_plames As System.Windows.Forms.Button
    Friend WithEvents txt_ruta_plame As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dtp_plame As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_afpnet As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Generar_Plame As System.Windows.Forms.ToolStripButton
End Class
