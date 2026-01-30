<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_LT_PlanillaPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_LT_PlanillaPagos))
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tc_planilla = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtfiltrocliente = New System.Windows.Forms.TextBox()
        Me.checkTodos = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optexcel = New System.Windows.Forms.RadioButton()
        Me.optrangocobro = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.optdetallado = New System.Windows.Forms.RadioButton()
        Me.optresumido = New System.Windows.Forms.RadioButton()
        Me.pnlNuevaPlanilla = New System.Windows.Forms.Panel()
        Me.gb_nueva_planilla = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar_crear = New System.Windows.Forms.Button()
        Me.btn_crear_planilla = New System.Windows.Forms.Button()
        Me.dtp_fec_nueva_pla = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gb_ListaCab = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtp_fecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_ini = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_planillas = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gb_sumatoria_ref = New System.Windows.Forms.GroupBox()
        Me.dgv_sumatoria_ref = New System.Windows.Forms.DataGridView()
        Me.btn_salir_sumatoria_ref = New System.Windows.Forms.Button()
        Me.lblCantidadDetall = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.mtb_tot_soles = New System.Windows.Forms.TextBox()
        Me.mtb_tot_dolares = New System.Windows.Forms.TextBox()
        Me.dgv_detalles = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txt_tc_planilla = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_fecha_planilla = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btnEliminarRegistro = New System.Windows.Forms.Button()
        Me.btn_nuevo_det = New System.Windows.Forms.Button()
        Me.txt_voucher = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_numero_planilla = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chk_comprobante_retencion = New System.Windows.Forms.CheckBox()
        Me.tc_tipCob = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.gb_aplidoc = New System.Windows.Forms.GroupBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnumDoc = New System.Windows.Forms.TextBox()
        Me.txtserieDoc = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.gb_banco = New System.Windows.Forms.GroupBox()
        Me.txt_gastos_redondeo = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_ing_redondeo = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt_gastos_bancarios = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txt_itf = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_gastos_financieros = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdocRefBancos = New System.Windows.Forms.TextBox()
        Me.cmb_banco = New System.Windows.Forms.ComboBox()
        Me.cmb_cta_cte = New System.Windows.Forms.ComboBox()
        Me.txt_num_ref_ban = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.gb_Efectivo = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_efectivo_doc_Ref = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtEfectoNumerodocRef = New System.Windows.Forms.TextBox()
        Me.tc_saldos = New System.Windows.Forms.TabPage()
        Me.gb_aplicacionSaldos = New System.Windows.Forms.GroupBox()
        Me.dtp_detrac = New System.Windows.Forms.DateTimePicker()
        Me.lbldetrac = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtreferenciaSaldo = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtnumerosaldo = New System.Windows.Forms.TextBox()
        Me.btn_grabar_det = New System.Windows.Forms.Button()
        Me.txt_glosa = New System.Windows.Forms.TextBox()
        Me.txt_cta_conta = New System.Windows.Forms.TextBox()
        Me.txt_cod_mon = New System.Windows.Forms.TextBox()
        Me.btn_cancelar_det = New System.Windows.Forms.Button()
        Me.mtb_fec_cob = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.cmb_tipo_cob = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.gb_tipo_documento = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txt_tipo_documento = New System.Windows.Forms.TextBox()
        Me.txt_des_tipo_documento = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dtpfecha_fin_pago = New System.Windows.Forms.DateTimePicker()
        Me.dtpinicio_fecha_pago = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_tipo_documento = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rb_Proveedor = New System.Windows.Forms.RadioButton()
        Me.rb_comprobante = New System.Windows.Forms.RadioButton()
        Me.mtb_total_cobME = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.mtb_total_cobMN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chktodos = New System.Windows.Forms.CheckBox()
        Me.txt_cod_ane = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_des_ane = New System.Windows.Forms.TextBox()
        Me.dgv_pendientes = New System.Windows.Forms.DataGridView()
        Me.chk_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.COL_DOCUMENT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_NUM_DOC_AUX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_COD_MON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_TC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_MONTO_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DOC_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_CADUCATE_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_SALES_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_SALES_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_IS_DR_CR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DOCUMENT_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_NUMBER_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_AMOUNT_BALANCE_INI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TERCERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDEN_PAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE_AUX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM_DOC_AUX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto_Original = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO_ORIGINAL_SOLES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_consultar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Nue_Pla = New System.Windows.Forms.ToolStripButton()
        Me.btn_edit_pla = New System.Windows.Forms.ToolStripButton()
        Me.btn_elimianr_planilla = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnContabilizar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.gb_pas_elimina_planilla = New System.Windows.Forms.GroupBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dtp_fecha_cr = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_cr = New System.Windows.Forms.Label()
        Me.tc_planilla.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.pnlNuevaPlanilla.SuspendLayout()
        Me.gb_nueva_planilla.SuspendLayout()
        Me.gb_ListaCab.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgv_planillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.gb_sumatoria_ref.SuspendLayout()
        CType(Me.dgv_sumatoria_ref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.tc_tipCob.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.gb_aplidoc.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.gb_banco.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.gb_Efectivo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_saldos.SuspendLayout()
        Me.gb_aplicacionSaldos.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.gb_tipo_documento.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.gb_pas_elimina_planilla.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_planilla
        '
        Me.tc_planilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_planilla.Controls.Add(Me.TabPage1)
        Me.tc_planilla.Controls.Add(Me.TabPage3)
        Me.tc_planilla.Controls.Add(Me.TabPage2)
        Me.tc_planilla.Location = New System.Drawing.Point(12, 35)
        Me.tc_planilla.Name = "tc_planilla"
        Me.tc_planilla.SelectedIndex = 0
        Me.tc_planilla.Size = New System.Drawing.Size(967, 591)
        Me.tc_planilla.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.pnlNuevaPlanilla)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Controls.Add(Me.gb_ListaCab)
        Me.TabPage1.Controls.Add(Me.dgv_planillas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(959, 565)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Planillas"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(150, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 300)
        Me.Panel1.TabIndex = 147
        Me.Panel1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.GroupBox8)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.GroupBox10)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(653, 284)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox8.Controls.Add(Me.dgvDocumentos)
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Controls.Add(Me.checkTodos)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(128, 13)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(519, 265)
        Me.GroupBox8.TabIndex = 115
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Proveedores"
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        Me.dgvDocumentos.AllowUserToDeleteRows = False
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(9, 91)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(502, 165)
        Me.dgvDocumentos.TabIndex = 180
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtfiltrocliente)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(502, 47)
        Me.GroupBox9.TabIndex = 179
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Ingrese texto a Buscar :"
        '
        'txtfiltrocliente
        '
        Me.txtfiltrocliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtfiltrocliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfiltrocliente.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfiltrocliente.Location = New System.Drawing.Point(7, 16)
        Me.txtfiltrocliente.Name = "txtfiltrocliente"
        Me.txtfiltrocliente.Size = New System.Drawing.Size(489, 22)
        Me.txtfiltrocliente.TabIndex = 24
        '
        'checkTodos
        '
        Me.checkTodos.AutoSize = True
        Me.checkTodos.ForeColor = System.Drawing.Color.Navy
        Me.checkTodos.Location = New System.Drawing.Point(9, 68)
        Me.checkTodos.Name = "checkTodos"
        Me.checkTodos.Size = New System.Drawing.Size(154, 17)
        Me.checkTodos.TabIndex = 178
        Me.checkTodos.Text = "&Marcar todos los Registros."
        Me.checkTodos.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox6.Controls.Add(Me.optexcel)
        Me.GroupBox6.Controls.Add(Me.optrangocobro)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(114, 80)
        Me.GroupBox6.TabIndex = 113
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo"
        '
        'optexcel
        '
        Me.optexcel.AutoSize = True
        Me.optexcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.optexcel.ForeColor = System.Drawing.Color.Navy
        Me.optexcel.Location = New System.Drawing.Point(20, 53)
        Me.optexcel.Name = "optexcel"
        Me.optexcel.Size = New System.Drawing.Size(93, 17)
        Me.optexcel.TabIndex = 3
        Me.optexcel.TabStop = True
        Me.optexcel.Text = "Por Proveedor"
        Me.optexcel.UseVisualStyleBackColor = True
        '
        'optrangocobro
        '
        Me.optrangocobro.AutoSize = True
        Me.optrangocobro.Checked = True
        Me.optrangocobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.optrangocobro.ForeColor = System.Drawing.Color.Navy
        Me.optrangocobro.Location = New System.Drawing.Point(20, 18)
        Me.optrangocobro.Name = "optrangocobro"
        Me.optrangocobro.Size = New System.Drawing.Size(77, 17)
        Me.optrangocobro.TabIndex = 2
        Me.optrangocobro.TabStop = True
        Me.optrangocobro.Text = "Por Planilla"
        Me.optrangocobro.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(17, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(17, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 39)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "      &Mostrar " & Global.Microsoft.VisualBasic.ChrW(13) & "      Reporte"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox10.Controls.Add(Me.optdetallado)
        Me.GroupBox10.Controls.Add(Me.optresumido)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox10.Location = New System.Drawing.Point(128, 11)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(519, 265)
        Me.GroupBox10.TabIndex = 114
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Opciones"
        '
        'optdetallado
        '
        Me.optdetallado.AutoSize = True
        Me.optdetallado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.optdetallado.ForeColor = System.Drawing.Color.Navy
        Me.optdetallado.Location = New System.Drawing.Point(20, 53)
        Me.optdetallado.Name = "optdetallado"
        Me.optdetallado.Size = New System.Drawing.Size(70, 17)
        Me.optdetallado.TabIndex = 3
        Me.optdetallado.TabStop = True
        Me.optdetallado.Text = "Detallado"
        Me.optdetallado.UseVisualStyleBackColor = True
        '
        'optresumido
        '
        Me.optresumido.AutoSize = True
        Me.optresumido.Checked = True
        Me.optresumido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.optresumido.ForeColor = System.Drawing.Color.Navy
        Me.optresumido.Location = New System.Drawing.Point(20, 18)
        Me.optresumido.Name = "optresumido"
        Me.optresumido.Size = New System.Drawing.Size(72, 17)
        Me.optresumido.TabIndex = 2
        Me.optresumido.TabStop = True
        Me.optresumido.Text = "Resumido"
        Me.optresumido.UseVisualStyleBackColor = True
        '
        'pnlNuevaPlanilla
        '
        Me.pnlNuevaPlanilla.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlNuevaPlanilla.Controls.Add(Me.gb_nueva_planilla)
        Me.pnlNuevaPlanilla.Location = New System.Drawing.Point(322, 109)
        Me.pnlNuevaPlanilla.Name = "pnlNuevaPlanilla"
        Me.pnlNuevaPlanilla.Size = New System.Drawing.Size(341, 92)
        Me.pnlNuevaPlanilla.TabIndex = 145
        Me.pnlNuevaPlanilla.Visible = False
        '
        'gb_nueva_planilla
        '
        Me.gb_nueva_planilla.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gb_nueva_planilla.Controls.Add(Me.btn_cancelar_crear)
        Me.gb_nueva_planilla.Controls.Add(Me.btn_crear_planilla)
        Me.gb_nueva_planilla.Controls.Add(Me.dtp_fec_nueva_pla)
        Me.gb_nueva_planilla.Controls.Add(Me.Label3)
        Me.gb_nueva_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gb_nueva_planilla.ForeColor = System.Drawing.Color.Navy
        Me.gb_nueva_planilla.Location = New System.Drawing.Point(3, 3)
        Me.gb_nueva_planilla.Name = "gb_nueva_planilla"
        Me.gb_nueva_planilla.Size = New System.Drawing.Size(332, 83)
        Me.gb_nueva_planilla.TabIndex = 2
        Me.gb_nueva_planilla.TabStop = False
        Me.gb_nueva_planilla.Text = "&Generacion de una nueva Planilla ..."
        '
        'btn_cancelar_crear
        '
        Me.btn_cancelar_crear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancelar_crear.Image = CType(resources.GetObject("btn_cancelar_crear.Image"), System.Drawing.Image)
        Me.btn_cancelar_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar_crear.Location = New System.Drawing.Point(165, 43)
        Me.btn_cancelar_crear.Name = "btn_cancelar_crear"
        Me.btn_cancelar_crear.Size = New System.Drawing.Size(61, 36)
        Me.btn_cancelar_crear.TabIndex = 9
        Me.btn_cancelar_crear.Text = "&Salir"
        Me.btn_cancelar_crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar_crear.UseVisualStyleBackColor = True
        '
        'btn_crear_planilla
        '
        Me.btn_crear_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_crear_planilla.Image = CType(resources.GetObject("btn_crear_planilla.Image"), System.Drawing.Image)
        Me.btn_crear_planilla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_crear_planilla.Location = New System.Drawing.Point(102, 43)
        Me.btn_crear_planilla.Name = "btn_crear_planilla"
        Me.btn_crear_planilla.Size = New System.Drawing.Size(61, 36)
        Me.btn_crear_planilla.TabIndex = 8
        Me.btn_crear_planilla.Text = "&Crear"
        Me.btn_crear_planilla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_crear_planilla.UseVisualStyleBackColor = True
        '
        'dtp_fec_nueva_pla
        '
        Me.dtp_fec_nueva_pla.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fec_nueva_pla.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_nueva_pla.Location = New System.Drawing.Point(120, 15)
        Me.dtp_fec_nueva_pla.Name = "dtp_fec_nueva_pla"
        Me.dtp_fec_nueva_pla.Size = New System.Drawing.Size(118, 25)
        Me.dtp_fec_nueva_pla.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha de Planilla :"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(10, 540)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 144
        Me.lblCantidad.Text = "."
        '
        'gb_ListaCab
        '
        Me.gb_ListaCab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_ListaCab.Controls.Add(Me.ProgressBar1)
        Me.gb_ListaCab.Controls.Add(Me.TextBox2)
        Me.gb_ListaCab.Controls.Add(Me.Label27)
        Me.gb_ListaCab.Controls.Add(Me.TextBox1)
        Me.gb_ListaCab.Controls.Add(Me.Label26)
        Me.gb_ListaCab.Controls.Add(Me.dtp_fecha_fin)
        Me.gb_ListaCab.Controls.Add(Me.dtp_fecha_ini)
        Me.gb_ListaCab.Controls.Add(Me.Label23)
        Me.gb_ListaCab.Controls.Add(Me.gbFiltros)
        Me.gb_ListaCab.Controls.Add(Me.Label2)
        Me.gb_ListaCab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gb_ListaCab.ForeColor = System.Drawing.Color.Navy
        Me.gb_ListaCab.Location = New System.Drawing.Point(6, 6)
        Me.gb_ListaCab.Name = "gb_ListaCab"
        Me.gb_ListaCab.Size = New System.Drawing.Size(945, 143)
        Me.gb_ListaCab.TabIndex = 1
        Me.gb_ListaCab.TabStop = False
        Me.gb_ListaCab.Text = "Relación Planillas"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 110)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(555, 18)
        Me.ProgressBar1.TabIndex = 202
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Red
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(775, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(26, 21)
        Me.TextBox2.TabIndex = 173
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Enabled = False
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(807, 118)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(132, 13)
        Me.Label27.TabIndex = 172
        Me.Label27.Text = "No enviado a Contabilidad"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(601, 114)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(26, 21)
        Me.TextBox1.TabIndex = 171
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(631, 118)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 13)
        Me.Label26.TabIndex = 170
        Me.Label26.Text = "Enviado a Contabilidad"
        '
        'dtp_fecha_fin
        '
        Me.dtp_fecha_fin.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_fin.Location = New System.Drawing.Point(280, 22)
        Me.dtp_fecha_fin.Name = "dtp_fecha_fin"
        Me.dtp_fecha_fin.Size = New System.Drawing.Size(106, 25)
        Me.dtp_fecha_fin.TabIndex = 2
        '
        'dtp_fecha_ini
        '
        Me.dtp_fecha_ini.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_ini.Location = New System.Drawing.Point(88, 20)
        Me.dtp_fecha_ini.Name = "dtp_fecha_ini"
        Me.dtp_fecha_ini.Size = New System.Drawing.Size(106, 25)
        Me.dtp_fecha_ini.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(203, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Fecha. Final"
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(8, 52)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(555, 47)
        Me.gbFiltros.TabIndex = 143
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
        Me.txtFiltro.Size = New System.Drawing.Size(528, 22)
        Me.txtFiltro.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha. Inicio"
        '
        'dgv_planillas
        '
        Me.dgv_planillas.AllowUserToAddRows = False
        Me.dgv_planillas.AllowUserToDeleteRows = False
        Me.dgv_planillas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_planillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_planillas.Location = New System.Drawing.Point(6, 154)
        Me.dgv_planillas.Name = "dgv_planillas"
        Me.dgv_planillas.ReadOnly = True
        Me.dgv_planillas.Size = New System.Drawing.Size(846, 383)
        Me.dgv_planillas.TabIndex = 8
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.gb_sumatoria_ref)
        Me.TabPage3.Controls.Add(Me.lblCantidadDetall)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.mtb_tot_soles)
        Me.TabPage3.Controls.Add(Me.mtb_tot_dolares)
        Me.TabPage3.Controls.Add(Me.dgv_detalles)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(959, 565)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Detalle Planilla"
        '
        'gb_sumatoria_ref
        '
        Me.gb_sumatoria_ref.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gb_sumatoria_ref.Controls.Add(Me.dgv_sumatoria_ref)
        Me.gb_sumatoria_ref.Controls.Add(Me.btn_salir_sumatoria_ref)
        Me.gb_sumatoria_ref.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_sumatoria_ref.ForeColor = System.Drawing.Color.Navy
        Me.gb_sumatoria_ref.Location = New System.Drawing.Point(7, 129)
        Me.gb_sumatoria_ref.Name = "gb_sumatoria_ref"
        Me.gb_sumatoria_ref.Size = New System.Drawing.Size(541, 307)
        Me.gb_sumatoria_ref.TabIndex = 148
        Me.gb_sumatoria_ref.TabStop = False
        Me.gb_sumatoria_ref.Text = "Sumatoria por Referencia"
        Me.gb_sumatoria_ref.Visible = False
        '
        'dgv_sumatoria_ref
        '
        Me.dgv_sumatoria_ref.AllowUserToAddRows = False
        Me.dgv_sumatoria_ref.AllowUserToDeleteRows = False
        Me.dgv_sumatoria_ref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sumatoria_ref.Location = New System.Drawing.Point(6, 45)
        Me.dgv_sumatoria_ref.Name = "dgv_sumatoria_ref"
        Me.dgv_sumatoria_ref.Size = New System.Drawing.Size(529, 253)
        Me.dgv_sumatoria_ref.TabIndex = 181
        '
        'btn_salir_sumatoria_ref
        '
        Me.btn_salir_sumatoria_ref.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_salir_sumatoria_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir_sumatoria_ref.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir_sumatoria_ref.Image = CType(resources.GetObject("btn_salir_sumatoria_ref.Image"), System.Drawing.Image)
        Me.btn_salir_sumatoria_ref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_sumatoria_ref.Location = New System.Drawing.Point(476, 15)
        Me.btn_salir_sumatoria_ref.Name = "btn_salir_sumatoria_ref"
        Me.btn_salir_sumatoria_ref.Size = New System.Drawing.Size(59, 24)
        Me.btn_salir_sumatoria_ref.TabIndex = 9
        Me.btn_salir_sumatoria_ref.Text = "Salir"
        Me.btn_salir_sumatoria_ref.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_sumatoria_ref.UseVisualStyleBackColor = True
        '
        'lblCantidadDetall
        '
        Me.lblCantidadDetall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidadDetall.AutoSize = True
        Me.lblCantidadDetall.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadDetall.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidadDetall.Location = New System.Drawing.Point(10, 541)
        Me.lblCantidadDetall.Name = "lblCantidadDetall"
        Me.lblCantidadDetall.Size = New System.Drawing.Size(10, 13)
        Me.lblCantidadDetall.TabIndex = 145
        Me.lblCantidadDetall.Text = "."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(10, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 47)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese texto a Buscar :"
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.Aquamarine
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscar.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(7, 16)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(596, 22)
        Me.txtbuscar.TabIndex = 3
        '
        'mtb_tot_soles
        '
        Me.mtb_tot_soles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtb_tot_soles.Enabled = False
        Me.mtb_tot_soles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_tot_soles.Location = New System.Drawing.Point(593, 536)
        Me.mtb_tot_soles.Name = "mtb_tot_soles"
        Me.mtb_tot_soles.ReadOnly = True
        Me.mtb_tot_soles.Size = New System.Drawing.Size(120, 21)
        Me.mtb_tot_soles.TabIndex = 7
        Me.mtb_tot_soles.Text = "0.0"
        Me.mtb_tot_soles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtb_tot_dolares
        '
        Me.mtb_tot_dolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtb_tot_dolares.Enabled = False
        Me.mtb_tot_dolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_tot_dolares.Location = New System.Drawing.Point(806, 536)
        Me.mtb_tot_dolares.Name = "mtb_tot_dolares"
        Me.mtb_tot_dolares.ReadOnly = True
        Me.mtb_tot_dolares.Size = New System.Drawing.Size(120, 21)
        Me.mtb_tot_dolares.TabIndex = 6
        Me.mtb_tot_dolares.Text = "0.0"
        Me.mtb_tot_dolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgv_detalles
        '
        Me.dgv_detalles.AllowUserToAddRows = False
        Me.dgv_detalles.AllowUserToDeleteRows = False
        Me.dgv_detalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles.Location = New System.Drawing.Point(8, 137)
        Me.dgv_detalles.Name = "dgv_detalles"
        Me.dgv_detalles.ReadOnly = True
        Me.dgv_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalles.Size = New System.Drawing.Size(918, 393)
        Me.dgv_detalles.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.txt_tc_planilla)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.txt_fecha_planilla)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.btn_regresar)
        Me.GroupBox4.Controls.Add(Me.btnEliminarRegistro)
        Me.GroupBox4.Controls.Add(Me.btn_nuevo_det)
        Me.GroupBox4.Controls.Add(Me.txt_voucher)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txt_numero_planilla)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(920, 103)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Blue
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(759, 15)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(155, 24)
        Me.Button6.TabIndex = 157
        Me.Button6.Text = "Sum. por Operación"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txt_tc_planilla
        '
        Me.txt_tc_planilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tc_planilla.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_tc_planilla.Location = New System.Drawing.Point(525, 16)
        Me.txt_tc_planilla.Name = "txt_tc_planilla"
        Me.txt_tc_planilla.ReadOnly = True
        Me.txt_tc_planilla.Size = New System.Drawing.Size(85, 22)
        Me.txt_tc_planilla.TabIndex = 156
        Me.txt_tc_planilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(465, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 13)
        Me.Label34.TabIndex = 155
        Me.Label34.Text = "Tip. Cam."
        '
        'txt_fecha_planilla
        '
        Me.txt_fecha_planilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fecha_planilla.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_fecha_planilla.Location = New System.Drawing.Point(352, 16)
        Me.txt_fecha_planilla.Name = "txt_fecha_planilla"
        Me.txt_fecha_planilla.ReadOnly = True
        Me.txt_fecha_planilla.Size = New System.Drawing.Size(106, 22)
        Me.txt_fecha_planilla.TabIndex = 154
        Me.txt_fecha_planilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(310, 21)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(40, 13)
        Me.Label33.TabIndex = 153
        Me.Label33.Text = "Fecha"
        '
        'btn_regresar
        '
        Me.btn_regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_regresar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_regresar.ForeColor = System.Drawing.Color.Blue
        Me.btn_regresar.Image = CType(resources.GetObject("btn_regresar.Image"), System.Drawing.Image)
        Me.btn_regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_regresar.Location = New System.Drawing.Point(819, 64)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(88, 23)
        Me.btn_regresar.TabIndex = 1
        Me.btn_regresar.Text = "&Retornar"
        Me.btn_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'btnEliminarRegistro
        '
        Me.btnEliminarRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarRegistro.ForeColor = System.Drawing.Color.Blue
        Me.btnEliminarRegistro.Image = CType(resources.GetObject("btnEliminarRegistro.Image"), System.Drawing.Image)
        Me.btnEliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarRegistro.Location = New System.Drawing.Point(724, 64)
        Me.btnEliminarRegistro.Name = "btnEliminarRegistro"
        Me.btnEliminarRegistro.Size = New System.Drawing.Size(88, 23)
        Me.btnEliminarRegistro.TabIndex = 5
        Me.btnEliminarRegistro.Text = "&Eliminar Registro"
        Me.btnEliminarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarRegistro.UseVisualStyleBackColor = True
        '
        'btn_nuevo_det
        '
        Me.btn_nuevo_det.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_nuevo_det.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_nuevo_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_det.ForeColor = System.Drawing.Color.Blue
        Me.btn_nuevo_det.Image = CType(resources.GetObject("btn_nuevo_det.Image"), System.Drawing.Image)
        Me.btn_nuevo_det.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_det.Location = New System.Drawing.Point(629, 64)
        Me.btn_nuevo_det.Name = "btn_nuevo_det"
        Me.btn_nuevo_det.Size = New System.Drawing.Size(88, 23)
        Me.btn_nuevo_det.TabIndex = 2
        Me.btn_nuevo_det.Text = "&Nuevo"
        Me.btn_nuevo_det.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo_det.UseVisualStyleBackColor = True
        '
        'txt_voucher
        '
        Me.txt_voucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_voucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_voucher.Location = New System.Drawing.Point(683, 66)
        Me.txt_voucher.Name = "txt_voucher"
        Me.txt_voucher.ReadOnly = True
        Me.txt_voucher.Size = New System.Drawing.Size(100, 20)
        Me.txt_voucher.TabIndex = 1
        Me.txt_voucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_voucher.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(632, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Voucher"
        Me.Label5.Visible = False
        '
        'txt_numero_planilla
        '
        Me.txt_numero_planilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_planilla.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_planilla.Location = New System.Drawing.Point(195, 16)
        Me.txt_numero_planilla.Name = "txt_numero_planilla"
        Me.txt_numero_planilla.ReadOnly = True
        Me.txt_numero_planilla.Size = New System.Drawing.Size(106, 22)
        Me.txt_numero_planilla.TabIndex = 0
        Me.txt_numero_planilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(12, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Numero de planilla de pago"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(519, 539)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total Soles"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(721, 539)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Dolares"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(959, 565)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion Documentos "
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.dtp_fecha_cr)
        Me.GroupBox7.Controls.Add(Me.lbl_fecha_cr)
        Me.GroupBox7.Controls.Add(Me.chk_comprobante_retencion)
        Me.GroupBox7.Controls.Add(Me.tc_tipCob)
        Me.GroupBox7.Controls.Add(Me.btn_grabar_det)
        Me.GroupBox7.Controls.Add(Me.txt_glosa)
        Me.GroupBox7.Controls.Add(Me.txt_cta_conta)
        Me.GroupBox7.Controls.Add(Me.txt_cod_mon)
        Me.GroupBox7.Controls.Add(Me.btn_cancelar_det)
        Me.GroupBox7.Controls.Add(Me.mtb_fec_cob)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.label9)
        Me.GroupBox7.Controls.Add(Me.cmb_tipo_cob)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(19, 331)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(930, 224)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        '
        'chk_comprobante_retencion
        '
        Me.chk_comprobante_retencion.AutoSize = True
        Me.chk_comprobante_retencion.Location = New System.Drawing.Point(107, 59)
        Me.chk_comprobante_retencion.Name = "chk_comprobante_retencion"
        Me.chk_comprobante_retencion.Size = New System.Drawing.Size(197, 17)
        Me.chk_comprobante_retencion.TabIndex = 33
        Me.chk_comprobante_retencion.Text = "Generar Comprobante de Retención"
        Me.chk_comprobante_retencion.UseVisualStyleBackColor = True
        '
        'tc_tipCob
        '
        Me.tc_tipCob.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipCob.Controls.Add(Me.TabPage5)
        Me.tc_tipCob.Controls.Add(Me.TabPage6)
        Me.tc_tipCob.Controls.Add(Me.TabPage4)
        Me.tc_tipCob.Controls.Add(Me.tc_saldos)
        Me.tc_tipCob.Location = New System.Drawing.Point(9, 80)
        Me.tc_tipCob.Name = "tc_tipCob"
        Me.tc_tipCob.SelectedIndex = 0
        Me.tc_tipCob.Size = New System.Drawing.Size(778, 136)
        Me.tc_tipCob.TabIndex = 7
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage5.Controls.Add(Me.gb_aplidoc)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(770, 110)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Aplicacion de Documentos"
        '
        'gb_aplidoc
        '
        Me.gb_aplidoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_aplidoc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_aplidoc.Controls.Add(Me.txtmonto)
        Me.gb_aplidoc.Controls.Add(Me.Label12)
        Me.gb_aplidoc.Controls.Add(Me.cmb_tipo_doc)
        Me.gb_aplidoc.Controls.Add(Me.Label19)
        Me.gb_aplidoc.Controls.Add(Me.Label18)
        Me.gb_aplidoc.Controls.Add(Me.Label11)
        Me.gb_aplidoc.Controls.Add(Me.txtnumDoc)
        Me.gb_aplidoc.Controls.Add(Me.txtserieDoc)
        Me.gb_aplidoc.Location = New System.Drawing.Point(6, 1)
        Me.gb_aplidoc.Name = "gb_aplidoc"
        Me.gb_aplidoc.Size = New System.Drawing.Size(756, 99)
        Me.gb_aplidoc.TabIndex = 8
        Me.gb_aplidoc.TabStop = False
        '
        'txtmonto
        '
        Me.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonto.Location = New System.Drawing.Point(422, 40)
        Me.txtmonto.MaxLength = 20
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.ReadOnly = True
        Me.txtmonto.Size = New System.Drawing.Size(86, 20)
        Me.txtmonto.TabIndex = 11
        Me.txtmonto.Text = "0.0"
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(379, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Monto"
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.DropDownHeight = 50
        Me.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_doc.DropDownWidth = 70
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.IntegralHeight = False
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(78, 13)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(430, 21)
        Me.cmb_tipo_doc.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(43, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Serie"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(185, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Numero"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Doc. Ref."
        '
        'txtnumDoc
        '
        Me.txtnumDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumDoc.Location = New System.Drawing.Point(234, 41)
        Me.txtnumDoc.MaxLength = 30
        Me.txtnumDoc.Name = "txtnumDoc"
        Me.txtnumDoc.ReadOnly = True
        Me.txtnumDoc.Size = New System.Drawing.Size(139, 20)
        Me.txtnumDoc.TabIndex = 10
        '
        'txtserieDoc
        '
        Me.txtserieDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtserieDoc.Location = New System.Drawing.Point(80, 40)
        Me.txtserieDoc.MaxLength = 10
        Me.txtserieDoc.Name = "txtserieDoc"
        Me.txtserieDoc.ReadOnly = True
        Me.txtserieDoc.Size = New System.Drawing.Size(96, 20)
        Me.txtserieDoc.TabIndex = 9
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage6.Controls.Add(Me.gb_banco)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(770, 110)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Datos de Banco"
        '
        'gb_banco
        '
        Me.gb_banco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_banco.Controls.Add(Me.txt_gastos_redondeo)
        Me.gb_banco.Controls.Add(Me.Label39)
        Me.gb_banco.Controls.Add(Me.txt_ing_redondeo)
        Me.gb_banco.Controls.Add(Me.Label38)
        Me.gb_banco.Controls.Add(Me.txt_gastos_bancarios)
        Me.gb_banco.Controls.Add(Me.Label36)
        Me.gb_banco.Controls.Add(Me.txt_itf)
        Me.gb_banco.Controls.Add(Me.Label35)
        Me.gb_banco.Controls.Add(Me.txt_gastos_financieros)
        Me.gb_banco.Controls.Add(Me.Label32)
        Me.gb_banco.Controls.Add(Me.PictureBox1)
        Me.gb_banco.Controls.Add(Me.txtdocRefBancos)
        Me.gb_banco.Controls.Add(Me.cmb_banco)
        Me.gb_banco.Controls.Add(Me.cmb_cta_cte)
        Me.gb_banco.Controls.Add(Me.txt_num_ref_ban)
        Me.gb_banco.Controls.Add(Me.Label21)
        Me.gb_banco.Controls.Add(Me.Label1)
        Me.gb_banco.Controls.Add(Me.Label20)
        Me.gb_banco.Controls.Add(Me.Label17)
        Me.gb_banco.Location = New System.Drawing.Point(6, 1)
        Me.gb_banco.Name = "gb_banco"
        Me.gb_banco.Size = New System.Drawing.Size(758, 101)
        Me.gb_banco.TabIndex = 5
        Me.gb_banco.TabStop = False
        '
        'txt_gastos_redondeo
        '
        Me.txt_gastos_redondeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_gastos_redondeo.Location = New System.Drawing.Point(846, 71)
        Me.txt_gastos_redondeo.Name = "txt_gastos_redondeo"
        Me.txt_gastos_redondeo.Size = New System.Drawing.Size(67, 20)
        Me.txt_gastos_redondeo.TabIndex = 126
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(742, 75)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 13)
        Me.Label39.TabIndex = 127
        Me.Label39.Text = "Gastos x Redondeo"
        '
        'txt_ing_redondeo
        '
        Me.txt_ing_redondeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ing_redondeo.Location = New System.Drawing.Point(665, 71)
        Me.txt_ing_redondeo.Name = "txt_ing_redondeo"
        Me.txt_ing_redondeo.Size = New System.Drawing.Size(67, 20)
        Me.txt_ing_redondeo.TabIndex = 124
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(576, 75)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(86, 13)
        Me.Label38.TabIndex = 125
        Me.Label38.Text = "Ing. x Redondeo"
        '
        'txt_gastos_bancarios
        '
        Me.txt_gastos_bancarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_gastos_bancarios.Location = New System.Drawing.Point(483, 71)
        Me.txt_gastos_bancarios.Name = "txt_gastos_bancarios"
        Me.txt_gastos_bancarios.Size = New System.Drawing.Size(85, 20)
        Me.txt_gastos_bancarios.TabIndex = 121
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(391, 75)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(90, 13)
        Me.Label36.TabIndex = 120
        Me.Label36.Text = "Gastos Bancarios"
        '
        'txt_itf
        '
        Me.txt_itf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_itf.Location = New System.Drawing.Point(98, 71)
        Me.txt_itf.Name = "txt_itf"
        Me.txt_itf.Size = New System.Drawing.Size(85, 20)
        Me.txt_itf.TabIndex = 119
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(61, 75)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(32, 13)
        Me.Label35.TabIndex = 118
        Me.Label35.Text = "I.T.F."
        '
        'txt_gastos_financieros
        '
        Me.txt_gastos_financieros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_gastos_financieros.Location = New System.Drawing.Point(298, 71)
        Me.txt_gastos_financieros.Name = "txt_gastos_financieros"
        Me.txt_gastos_financieros.Size = New System.Drawing.Size(85, 20)
        Me.txt_gastos_financieros.TabIndex = 117
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(196, 75)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(97, 13)
        Me.Label32.TabIndex = 116
        Me.Label32.Text = "Intereses Moratorio"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(484, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        '
        'txtdocRefBancos
        '
        Me.txtdocRefBancos.BackColor = System.Drawing.Color.Aquamarine
        Me.txtdocRefBancos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdocRefBancos.Location = New System.Drawing.Point(506, 16)
        Me.txtdocRefBancos.Name = "txtdocRefBancos"
        Me.txtdocRefBancos.Size = New System.Drawing.Size(170, 20)
        Me.txtdocRefBancos.TabIndex = 14
        '
        'cmb_banco
        '
        Me.cmb_banco.DropDownHeight = 50
        Me.cmb_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_banco.DropDownWidth = 70
        Me.cmb_banco.FormattingEnabled = True
        Me.cmb_banco.IntegralHeight = False
        Me.cmb_banco.Location = New System.Drawing.Point(99, 13)
        Me.cmb_banco.Name = "cmb_banco"
        Me.cmb_banco.Size = New System.Drawing.Size(285, 21)
        Me.cmb_banco.TabIndex = 12
        '
        'cmb_cta_cte
        '
        Me.cmb_cta_cte.DropDownHeight = 50
        Me.cmb_cta_cte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cta_cte.DropDownWidth = 70
        Me.cmb_cta_cte.FormattingEnabled = True
        Me.cmb_cta_cte.IntegralHeight = False
        Me.cmb_cta_cte.Location = New System.Drawing.Point(99, 40)
        Me.cmb_cta_cte.Name = "cmb_cta_cte"
        Me.cmb_cta_cte.Size = New System.Drawing.Size(285, 21)
        Me.cmb_cta_cte.TabIndex = 13
        '
        'txt_num_ref_ban
        '
        Me.txt_num_ref_ban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_ref_ban.Location = New System.Drawing.Point(483, 40)
        Me.txt_num_ref_ban.Name = "txt_num_ref_ban"
        Me.txt_num_ref_ban.Size = New System.Drawing.Size(193, 20)
        Me.txt_num_ref_ban.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Cuenta Corriente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(390, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Doc. Referencia"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(395, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Numero Ref."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Entidad Bancaria"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage4.Controls.Add(Me.gb_Efectivo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(770, 110)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "Efectivo"
        '
        'gb_Efectivo
        '
        Me.gb_Efectivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Efectivo.Controls.Add(Me.PictureBox2)
        Me.gb_Efectivo.Controls.Add(Me.txt_efectivo_doc_Ref)
        Me.gb_Efectivo.Controls.Add(Me.Label4)
        Me.gb_Efectivo.Controls.Add(Me.Label25)
        Me.gb_Efectivo.Controls.Add(Me.txtEfectoNumerodocRef)
        Me.gb_Efectivo.Location = New System.Drawing.Point(7, 3)
        Me.gb_Efectivo.Name = "gb_Efectivo"
        Me.gb_Efectivo.Size = New System.Drawing.Size(757, 99)
        Me.gb_Efectivo.TabIndex = 37
        Me.gb_Efectivo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(103, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 116
        Me.PictureBox2.TabStop = False
        '
        'txt_efectivo_doc_Ref
        '
        Me.txt_efectivo_doc_Ref.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_efectivo_doc_Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_efectivo_doc_Ref.Location = New System.Drawing.Point(125, 14)
        Me.txt_efectivo_doc_Ref.Name = "txt_efectivo_doc_Ref"
        Me.txt_efectivo_doc_Ref.Size = New System.Drawing.Size(170, 20)
        Me.txt_efectivo_doc_Ref.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Doc. Referencia"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(20, 43)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 13)
        Me.Label25.TabIndex = 37
        Me.Label25.Text = "Numero Ref."
        '
        'txtEfectoNumerodocRef
        '
        Me.txtEfectoNumerodocRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEfectoNumerodocRef.Location = New System.Drawing.Point(103, 40)
        Me.txtEfectoNumerodocRef.MaxLength = 10
        Me.txtEfectoNumerodocRef.Name = "txtEfectoNumerodocRef"
        Me.txtEfectoNumerodocRef.Size = New System.Drawing.Size(192, 20)
        Me.txtEfectoNumerodocRef.TabIndex = 17
        '
        'tc_saldos
        '
        Me.tc_saldos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tc_saldos.Controls.Add(Me.gb_aplicacionSaldos)
        Me.tc_saldos.Location = New System.Drawing.Point(4, 22)
        Me.tc_saldos.Name = "tc_saldos"
        Me.tc_saldos.Size = New System.Drawing.Size(770, 110)
        Me.tc_saldos.TabIndex = 3
        Me.tc_saldos.Text = "Aplicacion de Saldos"
        '
        'gb_aplicacionSaldos
        '
        Me.gb_aplicacionSaldos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_aplicacionSaldos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_aplicacionSaldos.Controls.Add(Me.dtp_detrac)
        Me.gb_aplicacionSaldos.Controls.Add(Me.lbldetrac)
        Me.gb_aplicacionSaldos.Controls.Add(Me.PictureBox3)
        Me.gb_aplicacionSaldos.Controls.Add(Me.txtreferenciaSaldo)
        Me.gb_aplicacionSaldos.Controls.Add(Me.Label28)
        Me.gb_aplicacionSaldos.Controls.Add(Me.Label29)
        Me.gb_aplicacionSaldos.Controls.Add(Me.txtnumerosaldo)
        Me.gb_aplicacionSaldos.Location = New System.Drawing.Point(6, 3)
        Me.gb_aplicacionSaldos.Name = "gb_aplicacionSaldos"
        Me.gb_aplicacionSaldos.Size = New System.Drawing.Size(756, 98)
        Me.gb_aplicacionSaldos.TabIndex = 9
        Me.gb_aplicacionSaldos.TabStop = False
        '
        'dtp_detrac
        '
        Me.dtp_detrac.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_detrac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_detrac.Location = New System.Drawing.Point(394, 36)
        Me.dtp_detrac.Name = "dtp_detrac"
        Me.dtp_detrac.Size = New System.Drawing.Size(106, 25)
        Me.dtp_detrac.TabIndex = 123
        Me.dtp_detrac.Visible = False
        '
        'lbldetrac
        '
        Me.lbldetrac.AutoSize = True
        Me.lbldetrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbldetrac.ForeColor = System.Drawing.Color.Navy
        Me.lbldetrac.Location = New System.Drawing.Point(306, 42)
        Me.lbldetrac.Name = "lbldetrac"
        Me.lbldetrac.Size = New System.Drawing.Size(82, 13)
        Me.lbldetrac.TabIndex = 122
        Me.lbldetrac.Text = "Fecha Deposito"
        Me.lbldetrac.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(101, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 121
        Me.PictureBox3.TabStop = False
        '
        'txtreferenciaSaldo
        '
        Me.txtreferenciaSaldo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtreferenciaSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtreferenciaSaldo.Location = New System.Drawing.Point(123, 15)
        Me.txtreferenciaSaldo.Name = "txtreferenciaSaldo"
        Me.txtreferenciaSaldo.Size = New System.Drawing.Size(170, 20)
        Me.txtreferenciaSaldo.TabIndex = 18
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 15)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 13)
        Me.Label28.TabIndex = 120
        Me.Label28.Text = "Doc. Referencia"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(18, 44)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(67, 13)
        Me.Label29.TabIndex = 119
        Me.Label29.Text = "Numero Ref."
        '
        'txtnumerosaldo
        '
        Me.txtnumerosaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumerosaldo.Location = New System.Drawing.Point(101, 41)
        Me.txtnumerosaldo.MaxLength = 20
        Me.txtnumerosaldo.Name = "txtnumerosaldo"
        Me.txtnumerosaldo.Size = New System.Drawing.Size(192, 20)
        Me.txtnumerosaldo.TabIndex = 19
        '
        'btn_grabar_det
        '
        Me.btn_grabar_det.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_grabar_det.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_grabar_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar_det.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar_det.Image = CType(resources.GetObject("btn_grabar_det.Image"), System.Drawing.Image)
        Me.btn_grabar_det.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar_det.Location = New System.Drawing.Point(791, 155)
        Me.btn_grabar_det.Name = "btn_grabar_det"
        Me.btn_grabar_det.Size = New System.Drawing.Size(115, 34)
        Me.btn_grabar_det.TabIndex = 20
        Me.btn_grabar_det.Text = "&Generar Pago"
        Me.btn_grabar_det.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar_det.UseVisualStyleBackColor = True
        '
        'txt_glosa
        '
        Me.txt_glosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_glosa.Location = New System.Drawing.Point(107, 36)
        Me.txt_glosa.MaxLength = 200
        Me.txt_glosa.Name = "txt_glosa"
        Me.txt_glosa.Size = New System.Drawing.Size(514, 20)
        Me.txt_glosa.TabIndex = 5
        '
        'txt_cta_conta
        '
        Me.txt_cta_conta.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cta_conta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cta_conta.Location = New System.Drawing.Point(831, 58)
        Me.txt_cta_conta.Name = "txt_cta_conta"
        Me.txt_cta_conta.Size = New System.Drawing.Size(73, 20)
        Me.txt_cta_conta.TabIndex = 6
        '
        'txt_cod_mon
        '
        Me.txt_cod_mon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_mon.Location = New System.Drawing.Point(831, 36)
        Me.txt_cod_mon.Name = "txt_cod_mon"
        Me.txt_cod_mon.ReadOnly = True
        Me.txt_cod_mon.Size = New System.Drawing.Size(73, 20)
        Me.txt_cod_mon.TabIndex = 4
        Me.txt_cod_mon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_cancelar_det
        '
        Me.btn_cancelar_det.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar_det.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancelar_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_det.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_det.Image = CType(resources.GetObject("btn_cancelar_det.Image"), System.Drawing.Image)
        Me.btn_cancelar_det.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar_det.Location = New System.Drawing.Point(791, 119)
        Me.btn_cancelar_det.Name = "btn_cancelar_det"
        Me.btn_cancelar_det.Size = New System.Drawing.Size(115, 34)
        Me.btn_cancelar_det.TabIndex = 4
        Me.btn_cancelar_det.Text = "&Retornar"
        Me.btn_cancelar_det.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar_det.UseVisualStyleBackColor = True
        '
        'mtb_fec_cob
        '
        Me.mtb_fec_cob.Enabled = False
        Me.mtb_fec_cob.Location = New System.Drawing.Point(831, 13)
        Me.mtb_fec_cob.Mask = "00/00/0000"
        Me.mtb_fec_cob.Name = "mtb_fec_cob"
        Me.mtb_fec_cob.Size = New System.Drawing.Size(73, 20)
        Me.mtb_fec_cob.TabIndex = 3
        Me.mtb_fec_cob.ValidatingType = GetType(Date)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(754, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Fecha Pago"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Glosa"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(769, 40)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(46, 13)
        Me.label9.TabIndex = 32
        Me.label9.Text = "Moneda"
        '
        'cmb_tipo_cob
        '
        Me.cmb_tipo_cob.DropDownHeight = 100
        Me.cmb_tipo_cob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_cob.DropDownWidth = 300
        Me.cmb_tipo_cob.FormattingEnabled = True
        Me.cmb_tipo_cob.IntegralHeight = False
        Me.cmb_tipo_cob.Location = New System.Drawing.Point(107, 13)
        Me.cmb_tipo_cob.MaxDropDownItems = 10
        Me.cmb_tipo_cob.Name = "cmb_tipo_cob"
        Me.cmb_tipo_cob.Size = New System.Drawing.Size(514, 21)
        Me.cmb_tipo_cob.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(754, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Cta. Contable"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(10, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Concepto de Pago"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.gb_tipo_documento)
        Me.GroupBox5.Controls.Add(Me.GroupBox11)
        Me.GroupBox5.Controls.Add(Me.PictureBox4)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.mtb_total_cobME)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.mtb_total_cobMN)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.chktodos)
        Me.GroupBox5.Controls.Add(Me.txt_cod_ane)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txt_des_ane)
        Me.GroupBox5.Controls.Add(Me.dgv_pendientes)
        Me.GroupBox5.Location = New System.Drawing.Point(19, 7)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(930, 323)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'gb_tipo_documento
        '
        Me.gb_tipo_documento.Controls.Add(Me.PictureBox6)
        Me.gb_tipo_documento.Controls.Add(Me.Label46)
        Me.gb_tipo_documento.Controls.Add(Me.txt_tipo_documento)
        Me.gb_tipo_documento.Controls.Add(Me.txt_des_tipo_documento)
        Me.gb_tipo_documento.ForeColor = System.Drawing.Color.Navy
        Me.gb_tipo_documento.Location = New System.Drawing.Point(10, 51)
        Me.gb_tipo_documento.Name = "gb_tipo_documento"
        Me.gb_tipo_documento.Size = New System.Drawing.Size(803, 37)
        Me.gb_tipo_documento.TabIndex = 147
        Me.gb_tipo_documento.TabStop = False
        Me.gb_tipo_documento.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(207, 12)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 115
        Me.PictureBox6.TabStop = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(8, 15)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(54, 13)
        Me.Label46.TabIndex = 114
        Me.Label46.Text = "Tipo Doc."
        '
        'txt_tipo_documento
        '
        Me.txt_tipo_documento.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_tipo_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipo_documento.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.txt_tipo_documento.Location = New System.Drawing.Point(71, 11)
        Me.txt_tipo_documento.Name = "txt_tipo_documento"
        Me.txt_tipo_documento.Size = New System.Drawing.Size(132, 21)
        Me.txt_tipo_documento.TabIndex = 112
        '
        'txt_des_tipo_documento
        '
        Me.txt_des_tipo_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_tipo_documento.Enabled = False
        Me.txt_des_tipo_documento.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.txt_des_tipo_documento.Location = New System.Drawing.Point(229, 11)
        Me.txt_des_tipo_documento.Name = "txt_des_tipo_documento"
        Me.txt_des_tipo_documento.ReadOnly = True
        Me.txt_des_tipo_documento.Size = New System.Drawing.Size(565, 21)
        Me.txt_des_tipo_documento.TabIndex = 113
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Button5)
        Me.GroupBox11.Controls.Add(Me.dtpfecha_fin_pago)
        Me.GroupBox11.Controls.Add(Me.dtpinicio_fecha_pago)
        Me.GroupBox11.Controls.Add(Me.Label30)
        Me.GroupBox11.Controls.Add(Me.Label31)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox11.Location = New System.Drawing.Point(10, 49)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(803, 37)
        Me.GroupBox11.TabIndex = 112
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Visible = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Navy
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(424, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "&Buscar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dtpfecha_fin_pago
        '
        Me.dtpfecha_fin_pago.Enabled = False
        Me.dtpfecha_fin_pago.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfecha_fin_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_fin_pago.Location = New System.Drawing.Point(290, 9)
        Me.dtpfecha_fin_pago.Name = "dtpfecha_fin_pago"
        Me.dtpfecha_fin_pago.Size = New System.Drawing.Size(106, 25)
        Me.dtpfecha_fin_pago.TabIndex = 6
        '
        'dtpinicio_fecha_pago
        '
        Me.dtpinicio_fecha_pago.Enabled = False
        Me.dtpinicio_fecha_pago.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpinicio_fecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio_fecha_pago.Location = New System.Drawing.Point(98, 8)
        Me.dtpinicio_fecha_pago.Name = "dtpinicio_fecha_pago"
        Me.dtpinicio_fecha_pago.Size = New System.Drawing.Size(106, 25)
        Me.dtpinicio_fecha_pago.TabIndex = 5
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(213, 14)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(65, 13)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "Fecha. Final"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(17, 13)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 13)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Fecha. Inicio"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(206, 62)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 111
        Me.PictureBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_tipo_documento)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.rb_Proveedor)
        Me.GroupBox2.Controls.Add(Me.rb_comprobante)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(803, 35)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de Busquedas"
        '
        'rb_tipo_documento
        '
        Me.rb_tipo_documento.AutoSize = True
        Me.rb_tipo_documento.ForeColor = System.Drawing.Color.Navy
        Me.rb_tipo_documento.Location = New System.Drawing.Point(100, 16)
        Me.rb_tipo_documento.Name = "rb_tipo_documento"
        Me.rb_tipo_documento.Size = New System.Drawing.Size(122, 17)
        Me.rb_tipo_documento.TabIndex = 42
        Me.rb_tipo_documento.Text = "Tipo  de Documento"
        Me.rb_tipo_documento.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton1.Location = New System.Drawing.Point(239, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(116, 17)
        Me.RadioButton1.TabIndex = 41
        Me.RadioButton1.Text = "Por &Fecha de pago"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'rb_Proveedor
        '
        Me.rb_Proveedor.AutoSize = True
        Me.rb_Proveedor.Checked = True
        Me.rb_Proveedor.ForeColor = System.Drawing.Color.Navy
        Me.rb_Proveedor.Location = New System.Drawing.Point(6, 16)
        Me.rb_Proveedor.Name = "rb_Proveedor"
        Me.rb_Proveedor.Size = New System.Drawing.Size(74, 17)
        Me.rb_Proveedor.TabIndex = 39
        Me.rb_Proveedor.TabStop = True
        Me.rb_Proveedor.Text = "&Proveedor"
        Me.rb_Proveedor.UseVisualStyleBackColor = True
        '
        'rb_comprobante
        '
        Me.rb_comprobante.AutoSize = True
        Me.rb_comprobante.ForeColor = System.Drawing.Color.Navy
        Me.rb_comprobante.Location = New System.Drawing.Point(403, 14)
        Me.rb_comprobante.Name = "rb_comprobante"
        Me.rb_comprobante.Size = New System.Drawing.Size(88, 17)
        Me.rb_comprobante.TabIndex = 40
        Me.rb_comprobante.Text = "&Comprobante"
        Me.rb_comprobante.UseVisualStyleBackColor = True
        Me.rb_comprobante.Visible = False
        '
        'mtb_total_cobME
        '
        Me.mtb_total_cobME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtb_total_cobME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_total_cobME.Enabled = False
        Me.mtb_total_cobME.Location = New System.Drawing.Point(818, 297)
        Me.mtb_total_cobME.Name = "mtb_total_cobME"
        Me.mtb_total_cobME.ReadOnly = True
        Me.mtb_total_cobME.Size = New System.Drawing.Size(103, 20)
        Me.mtb_total_cobME.TabIndex = 38
        Me.mtb_total_cobME.Text = "0.0"
        Me.mtb_total_cobME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(7, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 13)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "Proveedor"
        '
        'mtb_total_cobMN
        '
        Me.mtb_total_cobMN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtb_total_cobMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_total_cobMN.Enabled = False
        Me.mtb_total_cobMN.Location = New System.Drawing.Point(535, 296)
        Me.mtb_total_cobMN.Name = "mtb_total_cobMN"
        Me.mtb_total_cobMN.ReadOnly = True
        Me.mtb_total_cobMN.Size = New System.Drawing.Size(103, 20)
        Me.mtb_total_cobMN.TabIndex = 37
        Me.mtb_total_cobMN.Text = "0.0"
        Me.mtb_total_cobMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(644, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Saldo x Pagar Moneda Extranjera"
        '
        'chktodos
        '
        Me.chktodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.Color.Navy
        Me.chktodos.Location = New System.Drawing.Point(6, 300)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(169, 17)
        Me.chktodos.TabIndex = 6
        Me.chktodos.Text = "Marcar Todos los documentos"
        Me.chktodos.UseVisualStyleBackColor = True
        '
        'txt_cod_ane
        '
        Me.txt_cod_ane.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_ane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_ane.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.txt_cod_ane.Location = New System.Drawing.Point(70, 61)
        Me.txt_cod_ane.Name = "txt_cod_ane"
        Me.txt_cod_ane.Size = New System.Drawing.Size(132, 21)
        Me.txt_cod_ane.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(369, 300)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Saldo x Pagar Moneda Nacional"
        '
        'txt_des_ane
        '
        Me.txt_des_ane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_ane.Enabled = False
        Me.txt_des_ane.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.txt_des_ane.Location = New System.Drawing.Point(228, 62)
        Me.txt_des_ane.Name = "txt_des_ane"
        Me.txt_des_ane.ReadOnly = True
        Me.txt_des_ane.Size = New System.Drawing.Size(582, 21)
        Me.txt_des_ane.TabIndex = 3
        '
        'dgv_pendientes
        '
        Me.dgv_pendientes.AllowUserToAddRows = False
        Me.dgv_pendientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_pendientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.dgv_pendientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk_sel, Me.COL_DOCUMENT_ID, Me.COL_NUM_DOC_AUX, Me.COL_COD_MON, Me.COL_TC, Me.COL_MONTO_SALDO, Me.COL_SALDO, Me.COL_DOC_DATE, Me.COL_CADUCATE_DATE, Me.COL_SALES_ID, Me.COL_SALES_NAME, Me.COL_IS_DR_CR, Me.COL_DOCUMENT_REF, Me.COL_NUMBER_REF, Me.COL_AMOUNT_BALANCE_INI, Me.CUSTOMER_ID, Me.TERCERO, Me.ORDEN_PAGO, Me.SERIE_AUX, Me.NUM_DOC_AUX, Me.Monto_Original, Me.MONTO_ORIGINAL_SOLES})
        Me.dgv_pendientes.Location = New System.Drawing.Point(9, 93)
        Me.dgv_pendientes.Name = "dgv_pendientes"
        Me.dgv_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pendientes.Size = New System.Drawing.Size(911, 201)
        Me.dgv_pendientes.TabIndex = 5
        '
        'chk_sel
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.NullValue = False
        Me.chk_sel.DefaultCellStyle = DataGridViewCellStyle20
        Me.chk_sel.Frozen = True
        Me.chk_sel.HeaderText = "Sel"
        Me.chk_sel.Name = "chk_sel"
        Me.chk_sel.Width = 30
        '
        'COL_DOCUMENT_ID
        '
        Me.COL_DOCUMENT_ID.DataPropertyName = "DOCUMENT_ID"
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COL_DOCUMENT_ID.DefaultCellStyle = DataGridViewCellStyle21
        Me.COL_DOCUMENT_ID.HeaderText = "TipoDoc"
        Me.COL_DOCUMENT_ID.Name = "COL_DOCUMENT_ID"
        Me.COL_DOCUMENT_ID.ReadOnly = True
        Me.COL_DOCUMENT_ID.Width = 60
        '
        'COL_NUM_DOC_AUX
        '
        Me.COL_NUM_DOC_AUX.DataPropertyName = "NUMBER_DOC"
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COL_NUM_DOC_AUX.DefaultCellStyle = DataGridViewCellStyle22
        Me.COL_NUM_DOC_AUX.HeaderText = "NumDoc"
        Me.COL_NUM_DOC_AUX.Name = "COL_NUM_DOC_AUX"
        Me.COL_NUM_DOC_AUX.ReadOnly = True
        Me.COL_NUM_DOC_AUX.Width = 180
        '
        'COL_COD_MON
        '
        Me.COL_COD_MON.DataPropertyName = "COD_MON"
        Me.COL_COD_MON.HeaderText = "Moneda"
        Me.COL_COD_MON.Name = "COL_COD_MON"
        Me.COL_COD_MON.ReadOnly = True
        Me.COL_COD_MON.Width = 50
        '
        'COL_TC
        '
        Me.COL_TC.DataPropertyName = "TC"
        DataGridViewCellStyle23.Format = "N3"
        Me.COL_TC.DefaultCellStyle = DataGridViewCellStyle23
        Me.COL_TC.HeaderText = "Tipo de Cambio"
        Me.COL_TC.Name = "COL_TC"
        Me.COL_TC.ReadOnly = True
        Me.COL_TC.Width = 50
        '
        'COL_MONTO_SALDO
        '
        Me.COL_MONTO_SALDO.DataPropertyName = "Saldo"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "##,##0.00"
        Me.COL_MONTO_SALDO.DefaultCellStyle = DataGridViewCellStyle24
        Me.COL_MONTO_SALDO.HeaderText = "Monto "
        Me.COL_MONTO_SALDO.Name = "COL_MONTO_SALDO"
        Me.COL_MONTO_SALDO.ReadOnly = True
        '
        'COL_SALDO
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle25.Format = "##,##0.00"
        Me.COL_SALDO.DefaultCellStyle = DataGridViewCellStyle25
        Me.COL_SALDO.HeaderText = "Saldo a Pagar"
        Me.COL_SALDO.Name = "COL_SALDO"
        '
        'COL_DOC_DATE
        '
        Me.COL_DOC_DATE.DataPropertyName = "DOC_DATE"
        Me.COL_DOC_DATE.HeaderText = "Fecha de Emision"
        Me.COL_DOC_DATE.Name = "COL_DOC_DATE"
        Me.COL_DOC_DATE.ReadOnly = True
        Me.COL_DOC_DATE.Width = 80
        '
        'COL_CADUCATE_DATE
        '
        Me.COL_CADUCATE_DATE.DataPropertyName = "CADUCATE_DATE"
        Me.COL_CADUCATE_DATE.HeaderText = "Fecha de Vencimiento"
        Me.COL_CADUCATE_DATE.Name = "COL_CADUCATE_DATE"
        Me.COL_CADUCATE_DATE.ReadOnly = True
        Me.COL_CADUCATE_DATE.Width = 80
        '
        'COL_SALES_ID
        '
        Me.COL_SALES_ID.DataPropertyName = "SALES_ID"
        Me.COL_SALES_ID.HeaderText = "Codigo"
        Me.COL_SALES_ID.Name = "COL_SALES_ID"
        Me.COL_SALES_ID.ReadOnly = True
        Me.COL_SALES_ID.Visible = False
        Me.COL_SALES_ID.Width = 50
        '
        'COL_SALES_NAME
        '
        Me.COL_SALES_NAME.DataPropertyName = "NAME_VENDEDOR"
        Me.COL_SALES_NAME.HeaderText = "Vendedor"
        Me.COL_SALES_NAME.Name = "COL_SALES_NAME"
        Me.COL_SALES_NAME.Visible = False
        Me.COL_SALES_NAME.Width = 150
        '
        'COL_IS_DR_CR
        '
        Me.COL_IS_DR_CR.DataPropertyName = "IS_DR_CR"
        Me.COL_IS_DR_CR.HeaderText = "DH"
        Me.COL_IS_DR_CR.Name = "COL_IS_DR_CR"
        Me.COL_IS_DR_CR.ReadOnly = True
        Me.COL_IS_DR_CR.Visible = False
        Me.COL_IS_DR_CR.Width = 40
        '
        'COL_DOCUMENT_REF
        '
        Me.COL_DOCUMENT_REF.DataPropertyName = "DOCUMENT_REF"
        Me.COL_DOCUMENT_REF.HeaderText = "TD_Ref"
        Me.COL_DOCUMENT_REF.Name = "COL_DOCUMENT_REF"
        Me.COL_DOCUMENT_REF.ReadOnly = True
        Me.COL_DOCUMENT_REF.Visible = False
        Me.COL_DOCUMENT_REF.Width = 40
        '
        'COL_NUMBER_REF
        '
        Me.COL_NUMBER_REF.DataPropertyName = "NUMBER_REF"
        Me.COL_NUMBER_REF.HeaderText = "ND_Ref"
        Me.COL_NUMBER_REF.Name = "COL_NUMBER_REF"
        Me.COL_NUMBER_REF.ReadOnly = True
        Me.COL_NUMBER_REF.Visible = False
        Me.COL_NUMBER_REF.Width = 40
        '
        'COL_AMOUNT_BALANCE_INI
        '
        Me.COL_AMOUNT_BALANCE_INI.DataPropertyName = "AMOUNT_BALANCE_INI"
        DataGridViewCellStyle26.Format = "N2"
        Me.COL_AMOUNT_BALANCE_INI.DefaultCellStyle = DataGridViewCellStyle26
        Me.COL_AMOUNT_BALANCE_INI.HeaderText = "Saldo Inicial"
        Me.COL_AMOUNT_BALANCE_INI.Name = "COL_AMOUNT_BALANCE_INI"
        Me.COL_AMOUNT_BALANCE_INI.ReadOnly = True
        Me.COL_AMOUNT_BALANCE_INI.Visible = False
        Me.COL_AMOUNT_BALANCE_INI.Width = 80
        '
        'CUSTOMER_ID
        '
        Me.CUSTOMER_ID.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMER_ID.HeaderText = "Cod_Proveedor"
        Me.CUSTOMER_ID.Name = "CUSTOMER_ID"
        Me.CUSTOMER_ID.Visible = False
        Me.CUSTOMER_ID.Width = 50
        '
        'TERCERO
        '
        Me.TERCERO.DataPropertyName = "TERCERO"
        Me.TERCERO.HeaderText = "Proveedor"
        Me.TERCERO.Name = "TERCERO"
        Me.TERCERO.Visible = False
        Me.TERCERO.Width = 200
        '
        'ORDEN_PAGO
        '
        Me.ORDEN_PAGO.DataPropertyName = "ORDEN_PAGO"
        Me.ORDEN_PAGO.HeaderText = "N° O. Pago"
        Me.ORDEN_PAGO.Name = "ORDEN_PAGO"
        Me.ORDEN_PAGO.Visible = False
        '
        'SERIE_AUX
        '
        Me.SERIE_AUX.DataPropertyName = "SERIE_AUX"
        Me.SERIE_AUX.HeaderText = "SERIE_AUX"
        Me.SERIE_AUX.Name = "SERIE_AUX"
        Me.SERIE_AUX.Visible = False
        '
        'NUM_DOC_AUX
        '
        Me.NUM_DOC_AUX.DataPropertyName = "NUM_DOC_AUX"
        Me.NUM_DOC_AUX.HeaderText = "NUM_DOC_AUX"
        Me.NUM_DOC_AUX.Name = "NUM_DOC_AUX"
        Me.NUM_DOC_AUX.Visible = False
        '
        'Monto_Original
        '
        Me.Monto_Original.DataPropertyName = "Monto_Original"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "##,##0.00"
        Me.Monto_Original.DefaultCellStyle = DataGridViewCellStyle27
        Me.Monto_Original.HeaderText = "Monto Original"
        Me.Monto_Original.Name = "Monto_Original"
        Me.Monto_Original.ReadOnly = True
        '
        'MONTO_ORIGINAL_SOLES
        '
        Me.MONTO_ORIGINAL_SOLES.DataPropertyName = "MONTO_ORIGINAL_SOLES"
        Me.MONTO_ORIGINAL_SOLES.HeaderText = "MONTO_ORIGINAL_SOLES"
        Me.MONTO_ORIGINAL_SOLES.Name = "MONTO_ORIGINAL_SOLES"
        Me.MONTO_ORIGINAL_SOLES.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.btn_consultar, Me.btn_Nue_Pla, Me.btn_edit_pla, Me.btn_elimianr_planilla, Me.ToolStripButton1, Me.btnContabilizar, Me.Tool_Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(979, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(82, 22)
        Me.btn_consultar.Text = "&Refrescar"
        '
        'btn_Nue_Pla
        '
        Me.btn_Nue_Pla.Image = CType(resources.GetObject("btn_Nue_Pla.Image"), System.Drawing.Image)
        Me.btn_Nue_Pla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nue_Pla.Name = "btn_Nue_Pla"
        Me.btn_Nue_Pla.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nue_Pla.Text = "&Nueva"
        '
        'btn_edit_pla
        '
        Me.btn_edit_pla.Image = CType(resources.GetObject("btn_edit_pla.Image"), System.Drawing.Image)
        Me.btn_edit_pla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edit_pla.Name = "btn_edit_pla"
        Me.btn_edit_pla.Size = New System.Drawing.Size(79, 22)
        Me.btn_edit_pla.Text = "&Modificar"
        '
        'btn_elimianr_planilla
        '
        Me.btn_elimianr_planilla.Image = CType(resources.GetObject("btn_elimianr_planilla.Image"), System.Drawing.Image)
        Me.btn_elimianr_planilla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_elimianr_planilla.Name = "btn_elimianr_planilla"
        Me.btn_elimianr_planilla.Size = New System.Drawing.Size(75, 22)
        Me.btn_elimianr_planilla.Text = "&Suprimir"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton1.Text = "Reportar"
        '
        'btnContabilizar
        '
        Me.btnContabilizar.Image = CType(resources.GetObject("btnContabilizar.Image"), System.Drawing.Image)
        Me.btnContabilizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnContabilizar.Name = "btnContabilizar"
        Me.btnContabilizar.Size = New System.Drawing.Size(145, 22)
        Me.btnContabilizar.Text = "&Enviar a Contabilidad"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = CType(resources.GetObject("Tool_Salir.Image"), System.Drawing.Image)
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(52, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'gb_pas_elimina_planilla
        '
        Me.gb_pas_elimina_planilla.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_pas_elimina_planilla.Controls.Add(Me.txtpassword)
        Me.gb_pas_elimina_planilla.Controls.Add(Me.Button3)
        Me.gb_pas_elimina_planilla.Controls.Add(Me.Button4)
        Me.gb_pas_elimina_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_pas_elimina_planilla.ForeColor = System.Drawing.Color.Navy
        Me.gb_pas_elimina_planilla.Location = New System.Drawing.Point(947, 526)
        Me.gb_pas_elimina_planilla.Name = "gb_pas_elimina_planilla"
        Me.gb_pas_elimina_planilla.Size = New System.Drawing.Size(284, 96)
        Me.gb_pas_elimina_planilla.TabIndex = 4
        Me.gb_pas_elimina_planilla.TabStop = False
        Me.gb_pas_elimina_planilla.Text = "Password de Administrador"
        Me.gb_pas_elimina_planilla.Visible = False
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Aquamarine
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(6, 20)
        Me.txtpassword.MaxLength = 10
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(269, 22)
        Me.txtpassword.TabIndex = 216
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(142, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 39)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "&Salir"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(64, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 39)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "&Continuar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dtp_fecha_cr
        '
        Me.dtp_fecha_cr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtp_fecha_cr.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_cr.Location = New System.Drawing.Point(461, 57)
        Me.dtp_fecha_cr.Name = "dtp_fecha_cr"
        Me.dtp_fecha_cr.Size = New System.Drawing.Size(106, 20)
        Me.dtp_fecha_cr.TabIndex = 128
        Me.dtp_fecha_cr.Visible = False
        '
        'lbl_fecha_cr
        '
        Me.lbl_fecha_cr.AutoSize = True
        Me.lbl_fecha_cr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_fecha_cr.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fecha_cr.Location = New System.Drawing.Point(334, 61)
        Me.lbl_fecha_cr.Name = "lbl_fecha_cr"
        Me.lbl_fecha_cr.Size = New System.Drawing.Size(122, 13)
        Me.lbl_fecha_cr.TabIndex = 127
        Me.lbl_fecha_cr.Text = "Fecha Comp. Retención"
        Me.lbl_fecha_cr.Visible = False
        '
        'frm_CX_LT_PlanillaPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(979, 637)
        Me.Controls.Add(Me.gb_pas_elimina_planilla)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_planilla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_CX_LT_PlanillaPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de Pagos"
        Me.tc_planilla.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.pnlNuevaPlanilla.ResumeLayout(False)
        Me.gb_nueva_planilla.ResumeLayout(False)
        Me.gb_nueva_planilla.PerformLayout()
        Me.gb_ListaCab.ResumeLayout(False)
        Me.gb_ListaCab.PerformLayout()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgv_planillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.gb_sumatoria_ref.ResumeLayout(False)
        CType(Me.dgv_sumatoria_ref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.tc_tipCob.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.gb_aplidoc.ResumeLayout(False)
        Me.gb_aplidoc.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.gb_banco.ResumeLayout(False)
        Me.gb_banco.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.gb_Efectivo.ResumeLayout(False)
        Me.gb_Efectivo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_saldos.ResumeLayout(False)
        Me.gb_aplicacionSaldos.ResumeLayout(False)
        Me.gb_aplicacionSaldos.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gb_tipo_documento.ResumeLayout(False)
        Me.gb_tipo_documento.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gb_pas_elimina_planilla.ResumeLayout(False)
        Me.gb_pas_elimina_planilla.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_planilla As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_ListaCab As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_voucher As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_planilla As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo_det As System.Windows.Forms.Button
    Friend WithEvents btn_grabar_det As System.Windows.Forms.Button
    Private WithEvents txt_des_ane As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_ane As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_pendientes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents gb_banco As System.Windows.Forms.GroupBox
    Private WithEvents cmb_banco As System.Windows.Forms.ComboBox
    Private WithEvents cmb_cta_cte As System.Windows.Forms.ComboBox
    Private WithEvents txt_num_ref_ban As System.Windows.Forms.TextBox
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents cmb_tipo_cob As System.Windows.Forms.ComboBox
    Private WithEvents mtb_fec_cob As System.Windows.Forms.MaskedTextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gb_aplidoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents cmb_tipo_doc As System.Windows.Forms.ComboBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents txtnumDoc As System.Windows.Forms.TextBox
    Private WithEvents txtserieDoc As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar_det As System.Windows.Forms.Button
    Private WithEvents txt_glosa As System.Windows.Forms.TextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents txt_cta_conta As System.Windows.Forms.TextBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents txt_cod_mon As System.Windows.Forms.TextBox
    Private WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tc_tipCob As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents btn_regresar As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb_nueva_planilla As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar_crear As System.Windows.Forms.Button
    Friend WithEvents btn_crear_planilla As System.Windows.Forms.Button
    Friend WithEvents dtp_fec_nueva_pla As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnEliminarRegistro As System.Windows.Forms.Button
    Friend WithEvents dgv_detalles As System.Windows.Forms.DataGridView
    Private WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents mtb_tot_soles As System.Windows.Forms.TextBox
    Friend WithEvents mtb_tot_dolares As System.Windows.Forms.TextBox
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidadDetall As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Private WithEvents txtEfectoNumerodocRef As System.Windows.Forms.TextBox
    Friend WithEvents gb_Efectivo As System.Windows.Forms.GroupBox
    Private WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents txtdocRefBancos As System.Windows.Forms.TextBox
    Friend WithEvents pnlNuevaPlanilla As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents txt_efectivo_doc_Ref As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chktodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mtb_total_cobME As System.Windows.Forms.TextBox
    Friend WithEvents mtb_total_cobMN As System.Windows.Forms.TextBox
    Friend WithEvents dgv_planillas As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tc_saldos As System.Windows.Forms.TabPage
    Friend WithEvents gb_aplicacionSaldos As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents txtreferenciaSaldo As System.Windows.Forms.TextBox
    Private WithEvents Label28 As System.Windows.Forms.Label
    Private WithEvents Label29 As System.Windows.Forms.Label
    Private WithEvents txtnumerosaldo As System.Windows.Forms.TextBox
    Friend WithEvents rb_comprobante As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Proveedor As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_consultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Nue_Pla As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_edit_pla As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_elimianr_planilla As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnContabilizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfiltrocliente As System.Windows.Forms.TextBox
    Friend WithEvents checkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents optexcel As System.Windows.Forms.RadioButton
    Friend WithEvents optrangocobro As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents optdetallado As System.Windows.Forms.RadioButton
    Friend WithEvents optresumido As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents gb_pas_elimina_planilla As System.Windows.Forms.GroupBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dtp_detrac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldetrac As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfecha_fin_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio_fecha_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txt_tc_planilla As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_planilla As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Private WithEvents txt_gastos_financieros As System.Windows.Forms.TextBox
    Private WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents txt_itf As System.Windows.Forms.TextBox
    Private WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents gb_sumatoria_ref As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_sumatoria_ref As System.Windows.Forms.DataGridView
    Friend WithEvents btn_salir_sumatoria_ref As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Private WithEvents txt_gastos_bancarios As System.Windows.Forms.TextBox
    Private WithEvents Label36 As System.Windows.Forms.Label
    Private WithEvents txt_gastos_redondeo As System.Windows.Forms.TextBox
    Private WithEvents Label39 As System.Windows.Forms.Label
    Private WithEvents txt_ing_redondeo As System.Windows.Forms.TextBox
    Private WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents gb_tipo_documento As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Private WithEvents Label46 As System.Windows.Forms.Label
    Private WithEvents txt_tipo_documento As System.Windows.Forms.TextBox
    Private WithEvents txt_des_tipo_documento As System.Windows.Forms.TextBox
    Friend WithEvents rb_tipo_documento As System.Windows.Forms.RadioButton
    Friend WithEvents chk_comprobante_retencion As System.Windows.Forms.CheckBox
    Friend WithEvents chk_sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents COL_DOCUMENT_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_NUM_DOC_AUX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_COD_MON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_TC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_MONTO_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DOC_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_CADUCATE_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_SALES_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_SALES_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_IS_DR_CR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DOCUMENT_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_NUMBER_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_AMOUNT_BALANCE_INI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TERCERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORDEN_PAGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIE_AUX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUM_DOC_AUX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto_Original As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO_ORIGINAL_SOLES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtp_fecha_cr As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha_cr As System.Windows.Forms.Label
End Class
