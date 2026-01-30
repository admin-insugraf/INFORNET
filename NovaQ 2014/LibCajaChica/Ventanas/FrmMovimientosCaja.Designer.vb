<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovimientosCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMovimientosCaja))
        Me.tc_planilla = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnl_reportar_planillas = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chk_todos_rendicion = New System.Windows.Forms.CheckBox()
        Me.txt_desc_rendicion = New System.Windows.Forms.TextBox()
        Me.txt_cod_rendicion = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chk_todos_personal = New System.Windows.Forms.CheckBox()
        Me.txt_desc_personal = New System.Windows.Forms.TextBox()
        Me.txt_cod_personal = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chk_todos_conceptos = New System.Windows.Forms.CheckBox()
        Me.txt_des_concepto = New System.Windows.Forms.TextBox()
        Me.txt_cod_concepto = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_fec_fin_rp = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fec_ini_rp = New System.Windows.Forms.DateTimePicker()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtsaldofinal_ME = New System.Windows.Forms.TextBox()
        Me.txtegresos_ME = New System.Windows.Forms.TextBox()
        Me.txtingresos_ME = New System.Windows.Forms.TextBox()
        Me.txtsaldoinicial_ME = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.pnl_rendicion = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnprovnuevo = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtproveedor_desc = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_obs_rendicion = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_numero_rendicion = New System.Windows.Forms.TextBox()
        Me.txt_serie_rendicion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmb_documento_rendicion = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btn_cancelar_rendicion = New System.Windows.Forms.Button()
        Me.btn_actualizar_rendicion = New System.Windows.Forms.Button()
        Me.dtp_fecha_rendicion = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsaldofinal = New System.Windows.Forms.TextBox()
        Me.txtegresos = New System.Windows.Forms.TextBox()
        Me.txtingresos = New System.Windows.Forms.TextBox()
        Me.txtsaldoinicial = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgv_detalles = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_imprimir_det = New System.Windows.Forms.Button()
        Me.btn_grabar_det = New System.Windows.Forms.Button()
        Me.cmbmoneda = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbmovimiento = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnumero_documento = New System.Windows.Forms.TextBox()
        Me.txtserie_documento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbdocumento = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbpersonal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbconcepto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btnEliminarRegistro = New System.Windows.Forms.Button()
        Me.txt_fecha_planilla = New System.Windows.Forms.TextBox()
        Me.btn_nuevo_det = New System.Windows.Forms.Button()
        Me.txt_numero_planilla = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_consultar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Nue_Pla = New System.Windows.Forms.ToolStripButton()
        Me.btn_edit_pla = New System.Windows.Forms.ToolStripButton()
        Me.btn_elimianr_planilla = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Aperturar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btn_act_salddos = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Conforme = New System.Windows.Forms.ToolStripButton()
        Me.btnContabilizar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.panel_estado_cuenta = New System.Windows.Forms.Panel()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.cmb_tc = New System.Windows.Forms.ComboBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txt_seg_nombre = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_pri_nombre = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_ap_materno = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txt_ap_paterno = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.cmb_td = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txt_razon_social_prov_nuevo = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_ruc_prov_nuevo = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btn_cancel_nuevo_prov = New System.Windows.Forms.Button()
        Me.btn_nuevo_prov = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tc_planilla.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnl_reportar_planillas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnlNuevaPlanilla.SuspendLayout()
        Me.gb_nueva_planilla.SuspendLayout()
        Me.gb_ListaCab.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgv_planillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.pnl_rendicion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.panel_estado_cuenta.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc_planilla
        '
        Me.tc_planilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_planilla.Controls.Add(Me.TabPage1)
        Me.tc_planilla.Controls.Add(Me.TabPage3)
        Me.tc_planilla.Location = New System.Drawing.Point(12, 31)
        Me.tc_planilla.Name = "tc_planilla"
        Me.tc_planilla.SelectedIndex = 0
        Me.tc_planilla.Size = New System.Drawing.Size(987, 545)
        Me.tc_planilla.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.pnl_reportar_planillas)
        Me.TabPage1.Controls.Add(Me.pnlNuevaPlanilla)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Controls.Add(Me.gb_ListaCab)
        Me.TabPage1.Controls.Add(Me.dgv_planillas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(979, 519)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Planillas"
        '
        'pnl_reportar_planillas
        '
        Me.pnl_reportar_planillas.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_reportar_planillas.Controls.Add(Me.GroupBox2)
        Me.pnl_reportar_planillas.Location = New System.Drawing.Point(306, 1)
        Me.pnl_reportar_planillas.Name = "pnl_reportar_planillas"
        Me.pnl_reportar_planillas.Size = New System.Drawing.Size(439, 344)
        Me.pnl_reportar_planillas.TabIndex = 146
        Me.pnl_reportar_planillas.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.GroupBox8)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 335)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox8.Controls.Add(Me.chk_todos_rendicion)
        Me.GroupBox8.Controls.Add(Me.txt_desc_rendicion)
        Me.GroupBox8.Controls.Add(Me.txt_cod_rendicion)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(6, 218)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(421, 63)
        Me.GroupBox8.TabIndex = 116
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Estado Rendición"
        '
        'chk_todos_rendicion
        '
        Me.chk_todos_rendicion.AutoSize = True
        Me.chk_todos_rendicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_todos_rendicion.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_rendicion.Location = New System.Drawing.Point(11, 39)
        Me.chk_todos_rendicion.Name = "chk_todos_rendicion"
        Me.chk_todos_rendicion.Size = New System.Drawing.Size(179, 17)
        Me.chk_todos_rendicion.TabIndex = 179
        Me.chk_todos_rendicion.Text = "Todos los Estados de Rendición"
        Me.chk_todos_rendicion.UseVisualStyleBackColor = True
        '
        'txt_desc_rendicion
        '
        Me.txt_desc_rendicion.BackColor = System.Drawing.Color.White
        Me.txt_desc_rendicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_rendicion.Location = New System.Drawing.Point(76, 17)
        Me.txt_desc_rendicion.Name = "txt_desc_rendicion"
        Me.txt_desc_rendicion.ReadOnly = True
        Me.txt_desc_rendicion.Size = New System.Drawing.Size(339, 20)
        Me.txt_desc_rendicion.TabIndex = 178
        '
        'txt_cod_rendicion
        '
        Me.txt_cod_rendicion.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_rendicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_rendicion.Location = New System.Drawing.Point(9, 17)
        Me.txt_cod_rendicion.Name = "txt_cod_rendicion"
        Me.txt_cod_rendicion.ReadOnly = True
        Me.txt_cod_rendicion.Size = New System.Drawing.Size(61, 20)
        Me.txt_cod_rendicion.TabIndex = 177
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox6.Controls.Add(Me.chk_todos_personal)
        Me.GroupBox6.Controls.Add(Me.txt_desc_personal)
        Me.GroupBox6.Controls.Add(Me.txt_cod_personal)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(6, 151)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(421, 63)
        Me.GroupBox6.TabIndex = 115
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Personal"
        '
        'chk_todos_personal
        '
        Me.chk_todos_personal.AutoSize = True
        Me.chk_todos_personal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_todos_personal.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_personal.Location = New System.Drawing.Point(11, 39)
        Me.chk_todos_personal.Name = "chk_todos_personal"
        Me.chk_todos_personal.Size = New System.Drawing.Size(127, 17)
        Me.chk_todos_personal.TabIndex = 179
        Me.chk_todos_personal.Text = "Todos los Personales"
        Me.chk_todos_personal.UseVisualStyleBackColor = True
        '
        'txt_desc_personal
        '
        Me.txt_desc_personal.BackColor = System.Drawing.Color.White
        Me.txt_desc_personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_personal.Location = New System.Drawing.Point(76, 17)
        Me.txt_desc_personal.Name = "txt_desc_personal"
        Me.txt_desc_personal.ReadOnly = True
        Me.txt_desc_personal.Size = New System.Drawing.Size(339, 20)
        Me.txt_desc_personal.TabIndex = 178
        '
        'txt_cod_personal
        '
        Me.txt_cod_personal.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_personal.Location = New System.Drawing.Point(9, 17)
        Me.txt_cod_personal.Name = "txt_cod_personal"
        Me.txt_cod_personal.ReadOnly = True
        Me.txt_cod_personal.Size = New System.Drawing.Size(61, 20)
        Me.txt_cod_personal.TabIndex = 177
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox7.Controls.Add(Me.chk_todos_conceptos)
        Me.GroupBox7.Controls.Add(Me.txt_des_concepto)
        Me.GroupBox7.Controls.Add(Me.txt_cod_concepto)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(6, 82)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(421, 63)
        Me.GroupBox7.TabIndex = 114
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Concepto"
        '
        'chk_todos_conceptos
        '
        Me.chk_todos_conceptos.AutoSize = True
        Me.chk_todos_conceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_todos_conceptos.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_conceptos.Location = New System.Drawing.Point(11, 39)
        Me.chk_todos_conceptos.Name = "chk_todos_conceptos"
        Me.chk_todos_conceptos.Size = New System.Drawing.Size(126, 17)
        Me.chk_todos_conceptos.TabIndex = 179
        Me.chk_todos_conceptos.Text = "Todos los Conceptos"
        Me.chk_todos_conceptos.UseVisualStyleBackColor = True
        '
        'txt_des_concepto
        '
        Me.txt_des_concepto.BackColor = System.Drawing.Color.White
        Me.txt_des_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_concepto.Location = New System.Drawing.Point(76, 17)
        Me.txt_des_concepto.Name = "txt_des_concepto"
        Me.txt_des_concepto.ReadOnly = True
        Me.txt_des_concepto.Size = New System.Drawing.Size(339, 20)
        Me.txt_des_concepto.TabIndex = 178
        '
        'txt_cod_concepto
        '
        Me.txt_cod_concepto.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_concepto.Location = New System.Drawing.Point(9, 17)
        Me.txt_cod_concepto.Name = "txt_cod_concepto"
        Me.txt_cod_concepto.ReadOnly = True
        Me.txt_cod_concepto.Size = New System.Drawing.Size(61, 20)
        Me.txt_cod_concepto.TabIndex = 177
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.dtp_fec_fin_rp)
        Me.GroupBox3.Controls.Add(Me.dtp_fec_ini_rp)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label48)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 68)
        Me.GroupBox3.TabIndex = 113
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'dtp_fec_fin_rp
        '
        Me.dtp_fec_fin_rp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fec_fin_rp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_fin_rp.Location = New System.Drawing.Point(294, 30)
        Me.dtp_fec_fin_rp.Name = "dtp_fec_fin_rp"
        Me.dtp_fec_fin_rp.Size = New System.Drawing.Size(101, 21)
        Me.dtp_fec_fin_rp.TabIndex = 6
        '
        'dtp_fec_ini_rp
        '
        Me.dtp_fec_ini_rp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fec_ini_rp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_ini_rp.Location = New System.Drawing.Point(109, 30)
        Me.dtp_fec_ini_rp.Name = "dtp_fec_ini_rp"
        Me.dtp_fec_ini_rp.Size = New System.Drawing.Size(101, 21)
        Me.dtp_fec_ini_rp.TabIndex = 5
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(217, 33)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(65, 13)
        Me.Label47.TabIndex = 3
        Me.Label47.Text = "Fecha. Final"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label48.ForeColor = System.Drawing.Color.Navy
        Me.Label48.Location = New System.Drawing.Point(26, 33)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(68, 13)
        Me.Label48.TabIndex = 4
        Me.Label48.Text = "Fecha. Inicio"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(219, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(127, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 39)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "&Mostrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporte"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pnlNuevaPlanilla
        '
        Me.pnlNuevaPlanilla.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlNuevaPlanilla.Controls.Add(Me.gb_nueva_planilla)
        Me.pnlNuevaPlanilla.Location = New System.Drawing.Point(377, 155)
        Me.pnlNuevaPlanilla.Name = "pnlNuevaPlanilla"
        Me.pnlNuevaPlanilla.Size = New System.Drawing.Size(294, 104)
        Me.pnlNuevaPlanilla.TabIndex = 145
        Me.pnlNuevaPlanilla.Visible = False
        '
        'gb_nueva_planilla
        '
        Me.gb_nueva_planilla.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_nueva_planilla.Controls.Add(Me.btn_cancelar_crear)
        Me.gb_nueva_planilla.Controls.Add(Me.btn_crear_planilla)
        Me.gb_nueva_planilla.Controls.Add(Me.dtp_fec_nueva_pla)
        Me.gb_nueva_planilla.Controls.Add(Me.Label3)
        Me.gb_nueva_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_nueva_planilla.ForeColor = System.Drawing.Color.Navy
        Me.gb_nueva_planilla.Location = New System.Drawing.Point(3, 3)
        Me.gb_nueva_planilla.Name = "gb_nueva_planilla"
        Me.gb_nueva_planilla.Size = New System.Drawing.Size(284, 96)
        Me.gb_nueva_planilla.TabIndex = 2
        Me.gb_nueva_planilla.TabStop = False
        Me.gb_nueva_planilla.Text = "&Generacion de una nueva Planilla ..."
        '
        'btn_cancelar_crear
        '
        Me.btn_cancelar_crear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_crear.Image = CType(resources.GetObject("btn_cancelar_crear.Image"), System.Drawing.Image)
        Me.btn_cancelar_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar_crear.Location = New System.Drawing.Point(151, 47)
        Me.btn_cancelar_crear.Name = "btn_cancelar_crear"
        Me.btn_cancelar_crear.Size = New System.Drawing.Size(49, 39)
        Me.btn_cancelar_crear.TabIndex = 9
        Me.btn_cancelar_crear.Text = "&Salir"
        Me.btn_cancelar_crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar_crear.UseVisualStyleBackColor = True
        '
        'btn_crear_planilla
        '
        Me.btn_crear_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear_planilla.Image = CType(resources.GetObject("btn_crear_planilla.Image"), System.Drawing.Image)
        Me.btn_crear_planilla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_crear_planilla.Location = New System.Drawing.Point(101, 47)
        Me.btn_crear_planilla.Name = "btn_crear_planilla"
        Me.btn_crear_planilla.Size = New System.Drawing.Size(49, 39)
        Me.btn_crear_planilla.TabIndex = 8
        Me.btn_crear_planilla.Text = "&Crear"
        Me.btn_crear_planilla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_crear_planilla.UseVisualStyleBackColor = True
        '
        'dtp_fec_nueva_pla
        '
        Me.dtp_fec_nueva_pla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fec_nueva_pla.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_nueva_pla.Location = New System.Drawing.Point(118, 20)
        Me.dtp_fec_nueva_pla.Name = "dtp_fec_nueva_pla"
        Me.dtp_fec_nueva_pla.Size = New System.Drawing.Size(118, 21)
        Me.dtp_fec_nueva_pla.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha de Planilla :"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(18, 487)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(10, 13)
        Me.lblCantidad.TabIndex = 144
        Me.lblCantidad.Text = "."
        '
        'gb_ListaCab
        '
        Me.gb_ListaCab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_ListaCab.BackColor = System.Drawing.Color.White
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
        Me.gb_ListaCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gb_ListaCab.ForeColor = System.Drawing.Color.Navy
        Me.gb_ListaCab.Location = New System.Drawing.Point(6, 6)
        Me.gb_ListaCab.Name = "gb_ListaCab"
        Me.gb_ListaCab.Size = New System.Drawing.Size(954, 143)
        Me.gb_ListaCab.TabIndex = 1
        Me.gb_ListaCab.TabStop = False
        Me.gb_ListaCab.Text = "&Relacion Planillas"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 117)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(516, 19)
        Me.ProgressBar1.TabIndex = 174
        Me.ProgressBar1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.BackColor = System.Drawing.Color.Red
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(768, 113)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(26, 20)
        Me.TextBox2.TabIndex = 173
        Me.TextBox2.Visible = False
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.Enabled = False
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(800, 117)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(132, 13)
        Me.Label27.TabIndex = 172
        Me.Label27.Text = "No enviado a Contabilidad"
        Me.Label27.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(591, 113)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(26, 20)
        Me.TextBox1.TabIndex = 171
        Me.TextBox1.Visible = False
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(623, 117)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 13)
        Me.Label26.TabIndex = 170
        Me.Label26.Text = "Enviado a Contabilidad"
        Me.Label26.Visible = False
        '
        'dtp_fecha_fin
        '
        Me.dtp_fecha_fin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_fin.Location = New System.Drawing.Point(284, 28)
        Me.dtp_fecha_fin.Name = "dtp_fecha_fin"
        Me.dtp_fecha_fin.Size = New System.Drawing.Size(101, 21)
        Me.dtp_fecha_fin.TabIndex = 2
        '
        'dtp_fecha_ini
        '
        Me.dtp_fecha_ini.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_ini.Location = New System.Drawing.Point(99, 28)
        Me.dtp_fecha_ini.Name = "dtp_fecha_ini"
        Me.dtp_fecha_ini.Size = New System.Drawing.Size(101, 21)
        Me.dtp_fecha_ini.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(207, 31)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Fecha. Final"
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(8, 63)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(516, 47)
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
        Me.txtFiltro.Size = New System.Drawing.Size(503, 22)
        Me.txtFiltro.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(16, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha. Inicio"
        '
        'dgv_planillas
        '
        Me.dgv_planillas.AllowUserToAddRows = False
        Me.dgv_planillas.AllowUserToDeleteRows = False
        Me.dgv_planillas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_planillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_planillas.Location = New System.Drawing.Point(14, 155)
        Me.dgv_planillas.Name = "dgv_planillas"
        Me.dgv_planillas.ReadOnly = True
        Me.dgv_planillas.Size = New System.Drawing.Size(946, 329)
        Me.dgv_planillas.TabIndex = 8
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.Label37)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.txtsaldofinal_ME)
        Me.TabPage3.Controls.Add(Me.txtegresos_ME)
        Me.TabPage3.Controls.Add(Me.txtingresos_ME)
        Me.TabPage3.Controls.Add(Me.txtsaldoinicial_ME)
        Me.TabPage3.Controls.Add(Me.Label39)
        Me.TabPage3.Controls.Add(Me.Label40)
        Me.TabPage3.Controls.Add(Me.pnl_rendicion)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.txtsaldofinal)
        Me.TabPage3.Controls.Add(Me.txtegresos)
        Me.TabPage3.Controls.Add(Me.txtingresos)
        Me.TabPage3.Controls.Add(Me.txtsaldoinicial)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.dgv_detalles)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(979, 519)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Detalle Planilla"
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label37.AutoSize = True
        Me.Label37.Enabled = False
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Navy
        Me.Label37.Location = New System.Drawing.Point(241, 494)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(76, 13)
        Me.Label37.TabIndex = 175
        Me.Label37.Text = "Ingresos ME"
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label38.AutoSize = True
        Me.Label38.Enabled = False
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(10, 494)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(94, 13)
        Me.Label38.TabIndex = 174
        Me.Label38.Text = "Saldo Inicial ME"
        '
        'txtsaldofinal_ME
        '
        Me.txtsaldofinal_ME.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtsaldofinal_ME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsaldofinal_ME.Enabled = False
        Me.txtsaldofinal_ME.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaldofinal_ME.ForeColor = System.Drawing.Color.Green
        Me.txtsaldofinal_ME.Location = New System.Drawing.Point(740, 489)
        Me.txtsaldofinal_ME.Name = "txtsaldofinal_ME"
        Me.txtsaldofinal_ME.ReadOnly = True
        Me.txtsaldofinal_ME.Size = New System.Drawing.Size(104, 23)
        Me.txtsaldofinal_ME.TabIndex = 173
        Me.txtsaldofinal_ME.Text = "0.0"
        Me.txtsaldofinal_ME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtegresos_ME
        '
        Me.txtegresos_ME.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtegresos_ME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtegresos_ME.Enabled = False
        Me.txtegresos_ME.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtegresos_ME.ForeColor = System.Drawing.Color.Green
        Me.txtegresos_ME.Location = New System.Drawing.Point(535, 489)
        Me.txtegresos_ME.Name = "txtegresos_ME"
        Me.txtegresos_ME.ReadOnly = True
        Me.txtegresos_ME.Size = New System.Drawing.Size(104, 23)
        Me.txtegresos_ME.TabIndex = 172
        Me.txtegresos_ME.Text = "0.0"
        Me.txtegresos_ME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtingresos_ME
        '
        Me.txtingresos_ME.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtingresos_ME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtingresos_ME.Enabled = False
        Me.txtingresos_ME.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtingresos_ME.ForeColor = System.Drawing.Color.Green
        Me.txtingresos_ME.Location = New System.Drawing.Point(323, 489)
        Me.txtingresos_ME.Name = "txtingresos_ME"
        Me.txtingresos_ME.ReadOnly = True
        Me.txtingresos_ME.Size = New System.Drawing.Size(104, 23)
        Me.txtingresos_ME.TabIndex = 171
        Me.txtingresos_ME.Text = "0.0"
        Me.txtingresos_ME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsaldoinicial_ME
        '
        Me.txtsaldoinicial_ME.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtsaldoinicial_ME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsaldoinicial_ME.Enabled = False
        Me.txtsaldoinicial_ME.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaldoinicial_ME.ForeColor = System.Drawing.Color.Green
        Me.txtsaldoinicial_ME.Location = New System.Drawing.Point(109, 489)
        Me.txtsaldoinicial_ME.Name = "txtsaldoinicial_ME"
        Me.txtsaldoinicial_ME.ReadOnly = True
        Me.txtsaldoinicial_ME.Size = New System.Drawing.Size(104, 23)
        Me.txtsaldoinicial_ME.TabIndex = 170
        Me.txtsaldoinicial_ME.Text = "0.0"
        Me.txtsaldoinicial_ME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label39.AutoSize = True
        Me.Label39.Enabled = False
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(457, 494)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(70, 13)
        Me.Label39.TabIndex = 169
        Me.Label39.Text = "Egresos ME"
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label40.AutoSize = True
        Me.Label40.Enabled = False
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(645, 494)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(90, 13)
        Me.Label40.TabIndex = 168
        Me.Label40.Text = "Sando Final ME"
        '
        'pnl_rendicion
        '
        Me.pnl_rendicion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_rendicion.Controls.Add(Me.GroupBox1)
        Me.pnl_rendicion.Location = New System.Drawing.Point(360, 121)
        Me.pnl_rendicion.Name = "pnl_rendicion"
        Me.pnl_rendicion.Size = New System.Drawing.Size(375, 246)
        Me.pnl_rendicion.TabIndex = 167
        Me.pnl_rendicion.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnprovnuevo)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtproveedor_desc)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.txtproveedor)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txt_obs_rendicion)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txt_numero_rendicion)
        Me.GroupBox1.Controls.Add(Me.txt_serie_rendicion)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cmb_documento_rendicion)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar_rendicion)
        Me.GroupBox1.Controls.Add(Me.btn_actualizar_rendicion)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_rendicion)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 237)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de sustento de movimientos de Caja Chica"
        '
        'btnprovnuevo
        '
        Me.btnprovnuevo.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnprovnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprovnuevo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprovnuevo.ForeColor = System.Drawing.Color.Navy
        Me.btnprovnuevo.Image = CType(resources.GetObject("btnprovnuevo.Image"), System.Drawing.Image)
        Me.btnprovnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprovnuevo.Location = New System.Drawing.Point(218, 17)
        Me.btnprovnuevo.Name = "btnprovnuevo"
        Me.btnprovnuevo.Size = New System.Drawing.Size(127, 24)
        Me.btnprovnuevo.TabIndex = 231
        Me.btnprovnuevo.Text = "Prov. nuevo"
        Me.btnprovnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprovnuevo.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(10, 49)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 13)
        Me.Label28.TabIndex = 230
        Me.Label28.Text = "Razon social"
        '
        'txtproveedor_desc
        '
        Me.txtproveedor_desc.BackColor = System.Drawing.Color.White
        Me.txtproveedor_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor_desc.Location = New System.Drawing.Point(92, 45)
        Me.txtproveedor_desc.MaxLength = 200
        Me.txtproveedor_desc.Name = "txtproveedor_desc"
        Me.txtproveedor_desc.ReadOnly = True
        Me.txtproveedor_desc.Size = New System.Drawing.Size(253, 21)
        Me.txtproveedor_desc.TabIndex = 229
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(192, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 228
        Me.PictureBox4.TabStop = False
        '
        'txtproveedor
        '
        Me.txtproveedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor.Location = New System.Drawing.Point(92, 19)
        Me.txtproveedor.MaxLength = 15
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.ReadOnly = True
        Me.txtproveedor.Size = New System.Drawing.Size(94, 21)
        Me.txtproveedor.TabIndex = 30
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(10, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Proveedor"
        '
        'txt_obs_rendicion
        '
        Me.txt_obs_rendicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs_rendicion.ForeColor = System.Drawing.Color.Green
        Me.txt_obs_rendicion.Location = New System.Drawing.Point(92, 160)
        Me.txt_obs_rendicion.MaxLength = 250
        Me.txt_obs_rendicion.Name = "txt_obs_rendicion"
        Me.txt_obs_rendicion.Size = New System.Drawing.Size(253, 21)
        Me.txt_obs_rendicion.TabIndex = 28
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(10, 164)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 13)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "Obs."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(10, 135)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Fecha"
        '
        'txt_numero_rendicion
        '
        Me.txt_numero_rendicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_rendicion.ForeColor = System.Drawing.Color.Green
        Me.txt_numero_rendicion.Location = New System.Drawing.Point(226, 104)
        Me.txt_numero_rendicion.MaxLength = 15
        Me.txt_numero_rendicion.Name = "txt_numero_rendicion"
        Me.txt_numero_rendicion.Size = New System.Drawing.Size(119, 21)
        Me.txt_numero_rendicion.TabIndex = 21
        '
        'txt_serie_rendicion
        '
        Me.txt_serie_rendicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_serie_rendicion.ForeColor = System.Drawing.Color.Green
        Me.txt_serie_rendicion.Location = New System.Drawing.Point(92, 104)
        Me.txt_serie_rendicion.MaxLength = 5
        Me.txt_serie_rendicion.Name = "txt_serie_rendicion"
        Me.txt_serie_rendicion.Size = New System.Drawing.Size(72, 21)
        Me.txt_serie_rendicion.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(169, 108)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Número"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(10, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Serie"
        '
        'cmb_documento_rendicion
        '
        Me.cmb_documento_rendicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_documento_rendicion.ForeColor = System.Drawing.Color.Green
        Me.cmb_documento_rendicion.FormattingEnabled = True
        Me.cmb_documento_rendicion.Location = New System.Drawing.Point(92, 75)
        Me.cmb_documento_rendicion.Name = "cmb_documento_rendicion"
        Me.cmb_documento_rendicion.Size = New System.Drawing.Size(253, 21)
        Me.cmb_documento_rendicion.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(10, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Documento"
        '
        'btn_cancelar_rendicion
        '
        Me.btn_cancelar_rendicion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancelar_rendicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_rendicion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_rendicion.Image = CType(resources.GetObject("btn_cancelar_rendicion.Image"), System.Drawing.Image)
        Me.btn_cancelar_rendicion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar_rendicion.Location = New System.Drawing.Point(186, 188)
        Me.btn_cancelar_rendicion.Name = "btn_cancelar_rendicion"
        Me.btn_cancelar_rendicion.Size = New System.Drawing.Size(74, 39)
        Me.btn_cancelar_rendicion.TabIndex = 9
        Me.btn_cancelar_rendicion.Text = "&Cancelar"
        Me.btn_cancelar_rendicion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar_rendicion.UseVisualStyleBackColor = True
        '
        'btn_actualizar_rendicion
        '
        Me.btn_actualizar_rendicion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_actualizar_rendicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar_rendicion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar_rendicion.Image = CType(resources.GetObject("btn_actualizar_rendicion.Image"), System.Drawing.Image)
        Me.btn_actualizar_rendicion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_actualizar_rendicion.Location = New System.Drawing.Point(102, 188)
        Me.btn_actualizar_rendicion.Name = "btn_actualizar_rendicion"
        Me.btn_actualizar_rendicion.Size = New System.Drawing.Size(74, 39)
        Me.btn_actualizar_rendicion.TabIndex = 8
        Me.btn_actualizar_rendicion.Text = "&Actualizar"
        Me.btn_actualizar_rendicion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_actualizar_rendicion.UseVisualStyleBackColor = True
        '
        'dtp_fecha_rendicion
        '
        Me.dtp_fecha_rendicion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_rendicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_rendicion.Location = New System.Drawing.Point(92, 131)
        Me.dtp_fecha_rendicion.Name = "dtp_fecha_rendicion"
        Me.dtp_fecha_rendicion.Size = New System.Drawing.Size(118, 21)
        Me.dtp_fecha_rendicion.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label16.AutoSize = True
        Me.Label16.Enabled = False
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(241, 466)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 166
        Me.Label16.Text = "Ingresos MN"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(10, 466)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Saldo Inicial MN"
        '
        'txtsaldofinal
        '
        Me.txtsaldofinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtsaldofinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsaldofinal.Enabled = False
        Me.txtsaldofinal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaldofinal.ForeColor = System.Drawing.Color.Green
        Me.txtsaldofinal.Location = New System.Drawing.Point(740, 461)
        Me.txtsaldofinal.Name = "txtsaldofinal"
        Me.txtsaldofinal.ReadOnly = True
        Me.txtsaldofinal.Size = New System.Drawing.Size(104, 23)
        Me.txtsaldofinal.TabIndex = 164
        Me.txtsaldofinal.Text = "0.0"
        Me.txtsaldofinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtegresos
        '
        Me.txtegresos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtegresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtegresos.Enabled = False
        Me.txtegresos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtegresos.ForeColor = System.Drawing.Color.Green
        Me.txtegresos.Location = New System.Drawing.Point(535, 461)
        Me.txtegresos.Name = "txtegresos"
        Me.txtegresos.ReadOnly = True
        Me.txtegresos.Size = New System.Drawing.Size(104, 23)
        Me.txtegresos.TabIndex = 163
        Me.txtegresos.Text = "0.0"
        Me.txtegresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtingresos
        '
        Me.txtingresos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtingresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtingresos.Enabled = False
        Me.txtingresos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtingresos.ForeColor = System.Drawing.Color.Green
        Me.txtingresos.Location = New System.Drawing.Point(323, 461)
        Me.txtingresos.Name = "txtingresos"
        Me.txtingresos.ReadOnly = True
        Me.txtingresos.Size = New System.Drawing.Size(104, 23)
        Me.txtingresos.TabIndex = 162
        Me.txtingresos.Text = "0.0"
        Me.txtingresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsaldoinicial
        '
        Me.txtsaldoinicial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtsaldoinicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsaldoinicial.Enabled = False
        Me.txtsaldoinicial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaldoinicial.ForeColor = System.Drawing.Color.Green
        Me.txtsaldoinicial.Location = New System.Drawing.Point(109, 461)
        Me.txtsaldoinicial.Name = "txtsaldoinicial"
        Me.txtsaldoinicial.ReadOnly = True
        Me.txtsaldoinicial.Size = New System.Drawing.Size(104, 23)
        Me.txtsaldoinicial.TabIndex = 161
        Me.txtsaldoinicial.Text = "0.0"
        Me.txtsaldoinicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(457, 466)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 160
        Me.Label15.Text = "Egresos MN"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(645, 466)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "Sando Final MN"
        '
        'dgv_detalles
        '
        Me.dgv_detalles.AllowUserToAddRows = False
        Me.dgv_detalles.AllowUserToDeleteRows = False
        Me.dgv_detalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles.Location = New System.Drawing.Point(8, 229)
        Me.dgv_detalles.Name = "dgv_detalles"
        Me.dgv_detalles.ReadOnly = True
        Me.dgv_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalles.Size = New System.Drawing.Size(952, 225)
        Me.dgv_detalles.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.txtobservaciones)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.btn_imprimir_det)
        Me.GroupBox4.Controls.Add(Me.btn_grabar_det)
        Me.GroupBox4.Controls.Add(Me.cmbmoneda)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtmonto)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cmbmovimiento)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtnumero_documento)
        Me.GroupBox4.Controls.Add(Me.txtserie_documento)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cmbdocumento)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.cmbpersonal)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cmbconcepto)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.btn_regresar)
        Me.GroupBox4.Controls.Add(Me.btnEliminarRegistro)
        Me.GroupBox4.Controls.Add(Me.txt_fecha_planilla)
        Me.GroupBox4.Controls.Add(Me.btn_nuevo_det)
        Me.GroupBox4.Controls.Add(Me.txt_numero_planilla)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(954, 209)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Blue
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(794, 154)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 23)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "        Rend. Varios"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(6, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(216, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Doble click para modificar el registro."
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(794, 153)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 23)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "    Ren&dición"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(794, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 23)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "    &Cerrar C.Chica"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobservaciones.ForeColor = System.Drawing.Color.Green
        Me.txtobservaciones.Location = New System.Drawing.Point(102, 137)
        Me.txtobservaciones.MaxLength = 250
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(685, 21)
        Me.txtobservaciones.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(6, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Observaciones"
        '
        'btn_imprimir_det
        '
        Me.btn_imprimir_det.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_imprimir_det.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_imprimir_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir_det.ForeColor = System.Drawing.Color.Blue
        Me.btn_imprimir_det.Image = CType(resources.GetObject("btn_imprimir_det.Image"), System.Drawing.Image)
        Me.btn_imprimir_det.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir_det.Location = New System.Drawing.Point(794, 90)
        Me.btn_imprimir_det.Name = "btn_imprimir_det"
        Me.btn_imprimir_det.Size = New System.Drawing.Size(119, 23)
        Me.btn_imprimir_det.TabIndex = 25
        Me.btn_imprimir_det.Text = "    &Imprimir"
        Me.btn_imprimir_det.UseVisualStyleBackColor = True
        '
        'btn_grabar_det
        '
        Me.btn_grabar_det.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_grabar_det.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_grabar_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar_det.ForeColor = System.Drawing.Color.Blue
        Me.btn_grabar_det.Image = CType(resources.GetObject("btn_grabar_det.Image"), System.Drawing.Image)
        Me.btn_grabar_det.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_grabar_det.Location = New System.Drawing.Point(794, 39)
        Me.btn_grabar_det.Name = "btn_grabar_det"
        Me.btn_grabar_det.Size = New System.Drawing.Size(119, 23)
        Me.btn_grabar_det.TabIndex = 24
        Me.btn_grabar_det.Text = "   &Guardar"
        Me.btn_grabar_det.UseVisualStyleBackColor = True
        '
        'cmbmoneda
        '
        Me.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmoneda.ForeColor = System.Drawing.Color.Green
        Me.cmbmoneda.FormattingEnabled = True
        Me.cmbmoneda.Location = New System.Drawing.Point(618, 104)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Size = New System.Drawing.Size(169, 21)
        Me.cmbmoneda.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(564, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Moneda"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(373, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Monto"
        '
        'txtmonto
        '
        Me.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.ForeColor = System.Drawing.Color.Green
        Me.txtmonto.Location = New System.Drawing.Point(453, 103)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(100, 23)
        Me.txtmonto.TabIndex = 19
        Me.txtmonto.Text = "0.00"
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(6, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fecha de Planilla"
        '
        'cmbmovimiento
        '
        Me.cmbmovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmovimiento.ForeColor = System.Drawing.Color.Green
        Me.cmbmovimiento.FormattingEnabled = True
        Me.cmbmovimiento.Items.AddRange(New Object() {"Ingreso", "Egreso"})
        Me.cmbmovimiento.Location = New System.Drawing.Point(453, 76)
        Me.cmbmovimiento.Name = "cmbmovimiento"
        Me.cmbmovimiento.Size = New System.Drawing.Size(334, 21)
        Me.cmbmovimiento.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(373, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Movimiento"
        '
        'txtnumero_documento
        '
        Me.txtnumero_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumero_documento.ForeColor = System.Drawing.Color.Green
        Me.txtnumero_documento.Location = New System.Drawing.Point(222, 104)
        Me.txtnumero_documento.MaxLength = 15
        Me.txtnumero_documento.Name = "txtnumero_documento"
        Me.txtnumero_documento.Size = New System.Drawing.Size(119, 21)
        Me.txtnumero_documento.TabIndex = 15
        '
        'txtserie_documento
        '
        Me.txtserie_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtserie_documento.ForeColor = System.Drawing.Color.Green
        Me.txtserie_documento.Location = New System.Drawing.Point(88, 104)
        Me.txtserie_documento.MaxLength = 5
        Me.txtserie_documento.Name = "txtserie_documento"
        Me.txtserie_documento.Size = New System.Drawing.Size(72, 21)
        Me.txtserie_documento.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(165, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Número"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(6, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Serie"
        '
        'cmbdocumento
        '
        Me.cmbdocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdocumento.ForeColor = System.Drawing.Color.Green
        Me.cmbdocumento.FormattingEnabled = True
        Me.cmbdocumento.Location = New System.Drawing.Point(88, 76)
        Me.cmbdocumento.Name = "cmbdocumento"
        Me.cmbdocumento.Size = New System.Drawing.Size(253, 21)
        Me.cmbdocumento.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(6, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Documento"
        '
        'cmbpersonal
        '
        Me.cmbpersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpersonal.ForeColor = System.Drawing.Color.Green
        Me.cmbpersonal.FormattingEnabled = True
        Me.cmbpersonal.Location = New System.Drawing.Point(453, 48)
        Me.cmbpersonal.Name = "cmbpersonal"
        Me.cmbpersonal.Size = New System.Drawing.Size(334, 21)
        Me.cmbpersonal.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(373, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Personal"
        '
        'cmbconcepto
        '
        Me.cmbconcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbconcepto.ForeColor = System.Drawing.Color.Green
        Me.cmbconcepto.FormattingEnabled = True
        Me.cmbconcepto.Location = New System.Drawing.Point(453, 17)
        Me.cmbconcepto.Name = "cmbconcepto"
        Me.cmbconcepto.Size = New System.Drawing.Size(334, 21)
        Me.cmbconcepto.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(373, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Concepto"
        '
        'btn_regresar
        '
        Me.btn_regresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_regresar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_regresar.ForeColor = System.Drawing.Color.Blue
        Me.btn_regresar.Image = CType(resources.GetObject("btn_regresar.Image"), System.Drawing.Image)
        Me.btn_regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_regresar.Location = New System.Drawing.Point(794, 116)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(119, 23)
        Me.btn_regresar.TabIndex = 1
        Me.btn_regresar.Text = "    &Retornar"
        Me.btn_regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'btnEliminarRegistro
        '
        Me.btnEliminarRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarRegistro.ForeColor = System.Drawing.Color.Blue
        Me.btnEliminarRegistro.Image = CType(resources.GetObject("btnEliminarRegistro.Image"), System.Drawing.Image)
        Me.btnEliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarRegistro.Location = New System.Drawing.Point(794, 65)
        Me.btnEliminarRegistro.Name = "btnEliminarRegistro"
        Me.btnEliminarRegistro.Size = New System.Drawing.Size(119, 23)
        Me.btnEliminarRegistro.TabIndex = 5
        Me.btnEliminarRegistro.Text = "    &Eliminar "
        Me.btnEliminarRegistro.UseVisualStyleBackColor = True
        '
        'txt_fecha_planilla
        '
        Me.txt_fecha_planilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fecha_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha_planilla.Location = New System.Drawing.Point(123, 48)
        Me.txt_fecha_planilla.Name = "txt_fecha_planilla"
        Me.txt_fecha_planilla.ReadOnly = True
        Me.txt_fecha_planilla.Size = New System.Drawing.Size(106, 21)
        Me.txt_fecha_planilla.TabIndex = 1
        Me.txt_fecha_planilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_nuevo_det
        '
        Me.btn_nuevo_det.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_nuevo_det.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_nuevo_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_det.ForeColor = System.Drawing.Color.Blue
        Me.btn_nuevo_det.Image = CType(resources.GetObject("btn_nuevo_det.Image"), System.Drawing.Image)
        Me.btn_nuevo_det.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_det.Location = New System.Drawing.Point(794, 13)
        Me.btn_nuevo_det.Name = "btn_nuevo_det"
        Me.btn_nuevo_det.Size = New System.Drawing.Size(119, 23)
        Me.btn_nuevo_det.TabIndex = 2
        Me.btn_nuevo_det.Text = "&Nuevo"
        Me.btn_nuevo_det.UseVisualStyleBackColor = True
        '
        'txt_numero_planilla
        '
        Me.txt_numero_planilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_planilla.Location = New System.Drawing.Point(123, 17)
        Me.txt_numero_planilla.Name = "txt_numero_planilla"
        Me.txt_numero_planilla.ReadOnly = True
        Me.txt_numero_planilla.Size = New System.Drawing.Size(106, 21)
        Me.txt_numero_planilla.TabIndex = 0
        Me.txt_numero_planilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Numero de Planilla"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.btn_consultar, Me.btn_Nue_Pla, Me.btn_edit_pla, Me.btn_elimianr_planilla, Me.Tool_Aperturar, Me.ToolStripButton1, Me.btn_act_salddos, Me.Tool_Conforme, Me.btnContabilizar, Me.Tool_Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1011, 25)
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
        Me.btn_consultar.Size = New System.Drawing.Size(81, 22)
        Me.btn_consultar.Text = "&Consultar"
        '
        'btn_Nue_Pla
        '
        Me.btn_Nue_Pla.Image = CType(resources.GetObject("btn_Nue_Pla.Image"), System.Drawing.Image)
        Me.btn_Nue_Pla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nue_Pla.Name = "btn_Nue_Pla"
        Me.btn_Nue_Pla.Size = New System.Drawing.Size(105, 22)
        Me.btn_Nue_Pla.Text = "&Nueva Planilla"
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
        Me.btn_elimianr_planilla.Size = New System.Drawing.Size(72, 22)
        Me.btn_elimianr_planilla.Text = "&Eliminar"
        '
        'Tool_Aperturar
        '
        Me.Tool_Aperturar.Image = CType(resources.GetObject("Tool_Aperturar.Image"), System.Drawing.Image)
        Me.Tool_Aperturar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Aperturar.Name = "Tool_Aperturar"
        Me.Tool_Aperturar.Size = New System.Drawing.Size(129, 22)
        Me.Tool_Aperturar.Text = "&Aperturar C. Chica"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripButton1.Text = "&Reportar Planillas"
        '
        'btn_act_salddos
        '
        Me.btn_act_salddos.Image = CType(resources.GetObject("btn_act_salddos.Image"), System.Drawing.Image)
        Me.btn_act_salddos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_act_salddos.Name = "btn_act_salddos"
        Me.btn_act_salddos.Size = New System.Drawing.Size(124, 22)
        Me.btn_act_salddos.Text = "Actualizar Saldos"
        '
        'Tool_Conforme
        '
        Me.Tool_Conforme.Image = CType(resources.GetObject("Tool_Conforme.Image"), System.Drawing.Image)
        Me.Tool_Conforme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Conforme.Name = "Tool_Conforme"
        Me.Tool_Conforme.Size = New System.Drawing.Size(88, 22)
        Me.Tool_Conforme.Text = "Con&forme?"
        Me.Tool_Conforme.Visible = False
        '
        'btnContabilizar
        '
        Me.btnContabilizar.Image = CType(resources.GetObject("btnContabilizar.Image"), System.Drawing.Image)
        Me.btnContabilizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnContabilizar.Name = "btnContabilizar"
        Me.btnContabilizar.Size = New System.Drawing.Size(145, 22)
        Me.btnContabilizar.Text = "&Enviar a Contabilidad"
        Me.btnContabilizar.Visible = False
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = CType(resources.GetObject("Tool_Salir.Image"), System.Drawing.Image)
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(52, 22)
        Me.Tool_Salir.Text = "&Salir"
        '
        'panel_estado_cuenta
        '
        Me.panel_estado_cuenta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel_estado_cuenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panel_estado_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_estado_cuenta.Controls.Add(Me.GroupBox14)
        Me.panel_estado_cuenta.Location = New System.Drawing.Point(184, 53)
        Me.panel_estado_cuenta.Name = "panel_estado_cuenta"
        Me.panel_estado_cuenta.Size = New System.Drawing.Size(580, 466)
        Me.panel_estado_cuenta.TabIndex = 203
        Me.panel_estado_cuenta.Visible = False
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox14.Controls.Add(Me.Label54)
        Me.GroupBox14.Controls.Add(Me.txt_dir)
        Me.GroupBox14.Controls.Add(Me.cmb_tc)
        Me.GroupBox14.Controls.Add(Me.Label53)
        Me.GroupBox14.Controls.Add(Me.txt_seg_nombre)
        Me.GroupBox14.Controls.Add(Me.Label52)
        Me.GroupBox14.Controls.Add(Me.txt_pri_nombre)
        Me.GroupBox14.Controls.Add(Me.Label51)
        Me.GroupBox14.Controls.Add(Me.txt_ap_materno)
        Me.GroupBox14.Controls.Add(Me.Label50)
        Me.GroupBox14.Controls.Add(Me.txt_ap_paterno)
        Me.GroupBox14.Controls.Add(Me.Label49)
        Me.GroupBox14.Controls.Add(Me.cmb_td)
        Me.GroupBox14.Controls.Add(Me.Label41)
        Me.GroupBox14.Controls.Add(Me.txt_razon_social_prov_nuevo)
        Me.GroupBox14.Controls.Add(Me.Label42)
        Me.GroupBox14.Controls.Add(Me.txt_ruc_prov_nuevo)
        Me.GroupBox14.Controls.Add(Me.Label29)
        Me.GroupBox14.Controls.Add(Me.TextBox6)
        Me.GroupBox14.Controls.Add(Me.btn_cancel_nuevo_prov)
        Me.GroupBox14.Controls.Add(Me.btn_nuevo_prov)
        Me.GroupBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox14.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(559, 449)
        Me.GroupBox14.TabIndex = 211
        Me.GroupBox14.TabStop = False
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(45, 332)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(84, 19)
        Me.Label54.TabIndex = 231
        Me.Label54.Text = "Direccion"
        '
        'txt_dir
        '
        Me.txt_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_dir.ForeColor = System.Drawing.Color.Green
        Me.txt_dir.Location = New System.Drawing.Point(135, 329)
        Me.txt_dir.MaxLength = 200
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(400, 27)
        Me.txt_dir.TabIndex = 232
        '
        'cmb_tc
        '
        Me.cmb_tc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tc.FormattingEnabled = True
        Me.cmb_tc.Location = New System.Drawing.Point(134, 98)
        Me.cmb_tc.Name = "cmb_tc"
        Me.cmb_tc.Size = New System.Drawing.Size(401, 21)
        Me.cmb_tc.TabIndex = 229
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(48, 100)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(81, 19)
        Me.Label53.TabIndex = 230
        Me.Label53.Text = "Tipo Cia."
        '
        'txt_seg_nombre
        '
        Me.txt_seg_nombre.BackColor = System.Drawing.Color.White
        Me.txt_seg_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_seg_nombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_seg_nombre.ForeColor = System.Drawing.Color.Green
        Me.txt_seg_nombre.Location = New System.Drawing.Point(135, 294)
        Me.txt_seg_nombre.MaxLength = 200
        Me.txt_seg_nombre.Name = "txt_seg_nombre"
        Me.txt_seg_nombre.Size = New System.Drawing.Size(400, 27)
        Me.txt_seg_nombre.TabIndex = 227
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(6, 298)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(123, 19)
        Me.Label52.TabIndex = 228
        Me.Label52.Text = "Sgdo. Nombre"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_pri_nombre
        '
        Me.txt_pri_nombre.BackColor = System.Drawing.Color.White
        Me.txt_pri_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pri_nombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pri_nombre.ForeColor = System.Drawing.Color.Green
        Me.txt_pri_nombre.Location = New System.Drawing.Point(135, 261)
        Me.txt_pri_nombre.MaxLength = 200
        Me.txt_pri_nombre.Name = "txt_pri_nombre"
        Me.txt_pri_nombre.Size = New System.Drawing.Size(400, 27)
        Me.txt_pri_nombre.TabIndex = 225
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Navy
        Me.Label51.Location = New System.Drawing.Point(23, 265)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(106, 19)
        Me.Label51.TabIndex = 226
        Me.Label51.Text = "Pri. Nombre"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_ap_materno
        '
        Me.txt_ap_materno.BackColor = System.Drawing.Color.White
        Me.txt_ap_materno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ap_materno.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ap_materno.ForeColor = System.Drawing.Color.Green
        Me.txt_ap_materno.Location = New System.Drawing.Point(135, 229)
        Me.txt_ap_materno.MaxLength = 200
        Me.txt_ap_materno.Name = "txt_ap_materno"
        Me.txt_ap_materno.Size = New System.Drawing.Size(400, 27)
        Me.txt_ap_materno.TabIndex = 223
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Navy
        Me.Label50.Location = New System.Drawing.Point(20, 233)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(109, 19)
        Me.Label50.TabIndex = 224
        Me.Label50.Text = "Ap. Materno"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_ap_paterno
        '
        Me.txt_ap_paterno.BackColor = System.Drawing.Color.White
        Me.txt_ap_paterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ap_paterno.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ap_paterno.ForeColor = System.Drawing.Color.Green
        Me.txt_ap_paterno.Location = New System.Drawing.Point(135, 196)
        Me.txt_ap_paterno.MaxLength = 200
        Me.txt_ap_paterno.Name = "txt_ap_paterno"
        Me.txt_ap_paterno.Size = New System.Drawing.Size(400, 27)
        Me.txt_ap_paterno.TabIndex = 221
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(23, 200)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(106, 19)
        Me.Label49.TabIndex = 222
        Me.Label49.Text = "Ap. Paterno"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb_td
        '
        Me.cmb_td.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_td.FormattingEnabled = True
        Me.cmb_td.Location = New System.Drawing.Point(135, 67)
        Me.cmb_td.Name = "cmb_td"
        Me.cmb_td.Size = New System.Drawing.Size(400, 21)
        Me.cmb_td.TabIndex = 219
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(49, 69)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 19)
        Me.Label41.TabIndex = 220
        Me.Label41.Text = "Tipo Doc"
        '
        'txt_razon_social_prov_nuevo
        '
        Me.txt_razon_social_prov_nuevo.BackColor = System.Drawing.Color.White
        Me.txt_razon_social_prov_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_razon_social_prov_nuevo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_razon_social_prov_nuevo.ForeColor = System.Drawing.Color.Green
        Me.txt_razon_social_prov_nuevo.Location = New System.Drawing.Point(135, 162)
        Me.txt_razon_social_prov_nuevo.MaxLength = 200
        Me.txt_razon_social_prov_nuevo.Name = "txt_razon_social_prov_nuevo"
        Me.txt_razon_social_prov_nuevo.Size = New System.Drawing.Size(400, 27)
        Me.txt_razon_social_prov_nuevo.TabIndex = 217
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(20, 166)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(116, 19)
        Me.Label42.TabIndex = 218
        Me.Label42.Text = "Razón social "
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_ruc_prov_nuevo
        '
        Me.txt_ruc_prov_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc_prov_nuevo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ruc_prov_nuevo.ForeColor = System.Drawing.Color.Green
        Me.txt_ruc_prov_nuevo.Location = New System.Drawing.Point(135, 130)
        Me.txt_ruc_prov_nuevo.MaxLength = 11
        Me.txt_ruc_prov_nuevo.Name = "txt_ruc_prov_nuevo"
        Me.txt_ruc_prov_nuevo.Size = New System.Drawing.Size(176, 27)
        Me.txt_ruc_prov_nuevo.TabIndex = 215
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(49, 134)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 19)
        Me.Label29.TabIndex = 216
        Me.Label29.Text = "Ruc/ Dni"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Navy
        Me.TextBox6.Location = New System.Drawing.Point(6, 15)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(547, 23)
        Me.TextBox6.TabIndex = 212
        Me.TextBox6.Text = "REGISTRO DE PROVEEDOR NUEVO"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_cancel_nuevo_prov
        '
        Me.btn_cancel_nuevo_prov.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancel_nuevo_prov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel_nuevo_prov.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel_nuevo_prov.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancel_nuevo_prov.Image = CType(resources.GetObject("btn_cancel_nuevo_prov.Image"), System.Drawing.Image)
        Me.btn_cancel_nuevo_prov.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel_nuevo_prov.Location = New System.Drawing.Point(288, 389)
        Me.btn_cancel_nuevo_prov.Name = "btn_cancel_nuevo_prov"
        Me.btn_cancel_nuevo_prov.Size = New System.Drawing.Size(119, 51)
        Me.btn_cancel_nuevo_prov.TabIndex = 210
        Me.btn_cancel_nuevo_prov.Text = "Cancelar"
        Me.btn_cancel_nuevo_prov.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel_nuevo_prov.UseVisualStyleBackColor = True
        '
        'btn_nuevo_prov
        '
        Me.btn_nuevo_prov.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_nuevo_prov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_prov.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_nuevo_prov.ForeColor = System.Drawing.Color.Navy
        Me.btn_nuevo_prov.Image = CType(resources.GetObject("btn_nuevo_prov.Image"), System.Drawing.Image)
        Me.btn_nuevo_prov.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo_prov.Location = New System.Drawing.Point(158, 389)
        Me.btn_nuevo_prov.Name = "btn_nuevo_prov"
        Me.btn_nuevo_prov.Size = New System.Drawing.Size(115, 51)
        Me.btn_nuevo_prov.TabIndex = 209
        Me.btn_nuevo_prov.Text = "Grabar"
        Me.btn_nuevo_prov.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo_prov.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Location = New System.Drawing.Point(167, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(645, 371)
        Me.Panel2.TabIndex = 204
        Me.Panel2.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.CheckBox1)
        Me.GroupBox5.Controls.Add(Me.TextBox12)
        Me.GroupBox5.Controls.Add(Me.Label46)
        Me.GroupBox5.Controls.Add(Me.TextBox11)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.TextBox9)
        Me.GroupBox5.Controls.Add(Me.TextBox10)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.dgvDetalle)
        Me.GroupBox5.Controls.Add(Me.btn_limpiar)
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.btn_add)
        Me.GroupBox5.Controls.Add(Me.btn_del)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.TextBox5)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.TextBox7)
        Me.GroupBox5.Controls.Add(Me.TextBox8)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(631, 358)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos de sustento de movimientos Varios de Caja Chica"
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Navy
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(546, 174)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 23)
        Me.Button8.TabIndex = 247
        Me.Button8.Text = "Editar"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(425, 110)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(182, 17)
        Me.CheckBox1.TabIndex = 246
        Me.CheckBox1.Text = "Se registra en Compras? NO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.ForeColor = System.Drawing.Color.Green
        Me.TextBox12.Location = New System.Drawing.Point(319, 108)
        Me.TextBox12.MaxLength = 15
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(95, 21)
        Me.TextBox12.TabIndex = 245
        Me.TextBox12.Text = "0.0"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(345, 93)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(36, 13)
        Me.Label46.TabIndex = 244
        Me.Label46.Text = "Total"
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.ForeColor = System.Drawing.Color.Green
        Me.TextBox11.Location = New System.Drawing.Point(218, 108)
        Me.TextBox11.MaxLength = 15
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(95, 21)
        Me.TextBox11.TabIndex = 243
        Me.TextBox11.Text = "0.0"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(247, 94)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(33, 13)
        Me.Label45.TabIndex = 242
        Me.Label45.Text = "I.G.V"
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.ForeColor = System.Drawing.Color.Green
        Me.TextBox9.Location = New System.Drawing.Point(116, 108)
        Me.TextBox9.MaxLength = 15
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(95, 21)
        Me.TextBox9.TabIndex = 241
        Me.TextBox9.Text = "0.0"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.ForeColor = System.Drawing.Color.Green
        Me.TextBox10.Location = New System.Drawing.Point(13, 108)
        Me.TextBox10.MaxLength = 15
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(95, 21)
        Me.TextBox10.TabIndex = 240
        Me.TextBox10.Text = "0.0"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(111, 94)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(105, 13)
        Me.Label43.TabIndex = 239
        Me.Label43.Text = "Val. Ven. Inafecto"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Navy
        Me.Label44.Location = New System.Drawing.Point(10, 94)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(94, 13)
        Me.Label44.TabIndex = 238
        Me.Label44.Text = "Val. Ven. Afecta"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(9, 175)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(532, 174)
        Me.dgvDetalle.TabIndex = 237
        '
        'btn_limpiar
        '
        Me.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.ForeColor = System.Drawing.Color.Navy
        Me.btn_limpiar.Image = CType(resources.GetObject("btn_limpiar.Image"), System.Drawing.Image)
        Me.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar.Location = New System.Drawing.Point(546, 204)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(80, 23)
        Me.btn_limpiar.TabIndex = 236
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Navy
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(546, 315)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 23)
        Me.Button7.TabIndex = 235
        Me.Button7.Text = "Retornar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.Color.Navy
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(546, 233)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(80, 23)
        Me.btn_add.TabIndex = 234
        Me.btn_add.Text = "Grabar"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.ForeColor = System.Drawing.Color.Navy
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(546, 262)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(80, 23)
        Me.btn_del.TabIndex = 233
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Navy
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(218, 23)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 24)
        Me.Button6.TabIndex = 231
        Me.Button6.Text = "Prov. nuevo"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(351, 13)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 13)
        Me.Label30.TabIndex = 230
        Me.Label30.Text = "Razon social"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(354, 27)
        Me.TextBox3.MaxLength = 200
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(253, 21)
        Me.TextBox3.TabIndex = 229
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(192, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 228
        Me.PictureBox1.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(92, 25)
        Me.TextBox4.MaxLength = 15
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(94, 21)
        Me.TextBox4.TabIndex = 30
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(10, 27)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(66, 13)
        Me.Label31.TabIndex = 29
        Me.Label31.Text = "Proveedor"
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.Color.Green
        Me.TextBox5.Location = New System.Drawing.Point(261, 143)
        Me.TextBox5.MaxLength = 250
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(346, 21)
        Me.TextBox5.TabIndex = 28
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(222, 146)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 13)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "Obs."
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(10, 146)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(40, 13)
        Me.Label33.TabIndex = 22
        Me.Label33.Text = "Fecha"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.ForeColor = System.Drawing.Color.Green
        Me.TextBox7.Location = New System.Drawing.Point(451, 66)
        Me.TextBox7.MaxLength = 15
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(156, 21)
        Me.TextBox7.TabIndex = 21
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.ForeColor = System.Drawing.Color.Green
        Me.TextBox8.Location = New System.Drawing.Point(354, 65)
        Me.TextBox8.MaxLength = 10
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(89, 21)
        Me.TextBox8.TabIndex = 20
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(449, 51)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(51, 13)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Número"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(353, 51)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(36, 13)
        Me.Label35.TabIndex = 18
        Me.Label35.Text = "Serie"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.Green
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(92, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(253, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(10, 68)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 16
        Me.Label36.Text = "Documento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(92, 141)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 21)
        Me.DateTimePicker1.TabIndex = 4
        '
        'FrmMovimientosCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 578)
        Me.Controls.Add(Me.panel_estado_cuenta)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tc_planilla)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMovimientosCaja"
        Me.Text = "Movimientos de Caja Chica"
        Me.tc_planilla.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnl_reportar_planillas.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
        Me.pnl_rendicion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.panel_estado_cuenta.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_planilla As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents pnl_reportar_planillas As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pnlNuevaPlanilla As System.Windows.Forms.Panel
    Friend WithEvents gb_nueva_planilla As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar_crear As System.Windows.Forms.Button
    Friend WithEvents btn_crear_planilla As System.Windows.Forms.Button
    Friend WithEvents dtp_fec_nueva_pla As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents gb_ListaCab As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_planillas As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_detalles As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_regresar As System.Windows.Forms.Button
    Friend WithEvents btnEliminarRegistro As System.Windows.Forms.Button
    Friend WithEvents txt_fecha_planilla As System.Windows.Forms.TextBox
    Friend WithEvents btn_nuevo_det As System.Windows.Forms.Button
    Friend WithEvents txt_numero_planilla As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_consultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Nue_Pla As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_edit_pla As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_elimianr_planilla As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnContabilizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbdocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbpersonal As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbconcepto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_imprimir_det As System.Windows.Forms.Button
    Friend WithEvents btn_grabar_det As System.Windows.Forms.Button
    Friend WithEvents cmbmoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbmovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtnumero_documento As System.Windows.Forms.TextBox
    Friend WithEvents txtserie_documento As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsaldofinal As System.Windows.Forms.TextBox
    Friend WithEvents txtegresos As System.Windows.Forms.TextBox
    Friend WithEvents txtingresos As System.Windows.Forms.TextBox
    Friend WithEvents txtsaldoinicial As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents pnl_rendicion As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_rendicion As System.Windows.Forms.TextBox
    Friend WithEvents txt_serie_rendicion As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_documento_rendicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar_rendicion As System.Windows.Forms.Button
    Friend WithEvents btn_actualizar_rendicion As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha_rendicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_obs_rendicion As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Tool_Conforme As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor_desc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnprovnuevo As System.Windows.Forms.Button
    Friend WithEvents panel_estado_cuenta As System.Windows.Forms.Panel
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_razon_social_prov_nuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txt_ruc_prov_nuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancel_nuevo_prov As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_prov As System.Windows.Forms.Button
    Friend WithEvents Tool_Aperturar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtsaldofinal_ME As System.Windows.Forms.TextBox
    Friend WithEvents txtegresos_ME As System.Windows.Forms.TextBox
    Friend WithEvents txtingresos_ME As System.Windows.Forms.TextBox
    Friend WithEvents txtsaldoinicial_ME As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cmb_td As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_fec_fin_rp As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fec_ini_rp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents btn_act_salddos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txt_seg_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txt_pri_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_ap_materno As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txt_ap_paterno As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_todos_personal As System.Windows.Forms.CheckBox
    Friend WithEvents txt_desc_personal As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_personal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_todos_conceptos As System.Windows.Forms.CheckBox
    Friend WithEvents txt_des_concepto As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_concepto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_todos_rendicion As System.Windows.Forms.CheckBox
    Friend WithEvents txt_desc_rendicion As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_rendicion As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tc As System.Windows.Forms.ComboBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button

End Class
