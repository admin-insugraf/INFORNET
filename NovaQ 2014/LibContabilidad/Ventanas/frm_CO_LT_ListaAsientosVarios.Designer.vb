<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_LT_ListaAsientosVarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_LT_ListaAsientosVarios))
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tool_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.tool_editar = New System.Windows.Forms.ToolStripButton()
        Me.tool_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tool_anular = New System.Windows.Forms.ToolStripButton()
        Me.tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.tool_actualizar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_reaperturar = New System.Windows.Forms.ToolStripButton()
        Me.btn_importar_asientos = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_ope = New System.Windows.Forms.ComboBox()
        Me.dtp_Año = New System.Windows.Forms.DateTimePicker()
        Me.cmb_sub = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cmb_meses = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dgv_asientos = New System.Windows.Forms.DataGridView()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.mtb_dif_dolares = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_tot_d_dolares = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_tot_h_dolares = New System.Windows.Forms.MaskedTextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.pnlDetalles = New System.Windows.Forms.Panel()
        Me.dgvDetalleAsiento = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.gb_detalle_doc = New System.Windows.Forms.GroupBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.txt_cen_cos = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_detraccion = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.gb_ref = New System.Windows.Forms.GroupBox()
        Me.btn_aceptar_ref = New System.Windows.Forms.Button()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.mtb_fec_ven_ref = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fec_emi_ref = New System.Windows.Forms.MaskedTextBox()
        Me.txt_ndoc_ref = New System.Windows.Forms.TextBox()
        Me.txt_tdoc_ref = New System.Windows.Forms.TextBox()
        Me.txt_sdoc_ref = New System.Windows.Forms.TextBox()
        Me.mtb_haber = New System.Windows.Forms.TextBox()
        Me.mtb_debe = New System.Windows.Forms.TextBox()
        Me.txtCentroCosto = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.txtCuentaContable = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtTipoDocAsiento = New System.Windows.Forms.TextBox()
        Me.txt_glosa_det = New System.Windows.Forms.TextBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.btn_ref = New System.Windows.Forms.Button()
        Me.btn_can = New System.Windows.Forms.Button()
        Me.chk_inafecto = New System.Windows.Forms.CheckBox()
        Me.cmb_mp = New System.Windows.Forms.ComboBox()
        Me.cmb_cc = New System.Windows.Forms.ComboBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.txt_des_cta = New System.Windows.Forms.TextBox()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.txt_ser = New System.Windows.Forms.TextBox()
        Me.txt_des_ane = New System.Windows.Forms.TextBox()
        Me.txt_cod_ane = New System.Windows.Forms.TextBox()
        Me.mtb_fec_ven = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fec_emi = New System.Windows.Forms.MaskedTextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.mtb_tc = New System.Windows.Forms.TextBox()
        Me.txt_cen_cos_des = New System.Windows.Forms.TextBox()
        Me.txt_d2 = New System.Windows.Forms.TextBox()
        Me.txt_d1 = New System.Windows.Forms.TextBox()
        Me.mtb_dif = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_tot_d = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_tot_h = New System.Windows.Forms.MaskedTextBox()
        Me.gbCabecera = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtFechaDocRef = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtTipoDocRef = New System.Windows.Forms.TextBox()
        Me.txtSerieDocRef = New System.Windows.Forms.TextBox()
        Me.txtNumDocRef = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtMontoDoc = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtMontoIgv = New System.Windows.Forms.TextBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.lbltasa = New System.Windows.Forms.Label()
        Me.txtdescripcionDestino = New System.Windows.Forms.TextBox()
        Me.txtTasa = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtdetraccion = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtPorc_Detrac = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txt_ISC = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtPorc_ISC = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.chkdua = New System.Windows.Forms.CheckBox()
        Me.txtGlosaTransaccion = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dtpOtraFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtNumeroDoc = New System.Windows.Forms.TextBox()
        Me.txtSerieDoc = New System.Windows.Forms.TextBox()
        Me.txtTipoDoc = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpFechaVencimientoDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpFechaDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtdescripciontercero = New System.Windows.Forms.TextBox()
        Me.txtcodigoRuc = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpFecha_PLE = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtp_fec_vou = New System.Windows.Forms.DateTimePicker()
        Me.txt_idcab = New System.Windows.Forms.TextBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.txt_glosa = New System.Windows.Forms.TextBox()
        Me.txt_num_vou = New System.Windows.Forms.TextBox()
        Me.cmb_sub_detalle = New System.Windows.Forms.ComboBox()
        Me.cmb_ope_detalle = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.pnlFinalizarCompra = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_Finalizar = New System.Windows.Forms.Button()
        Me.btn_remplaza_finalizar = New System.Windows.Forms.Button()
        Me.pnl_opt_cierre = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btn_cancelar_opt_cierre = New System.Windows.Forms.Button()
        Me.btn_aceptar_opt_cierre = New System.Windows.Forms.Button()
        Me.pnl_importar_asientos = New System.Windows.Forms.Panel()
        Me.btn_cancelar_importacion = New System.Windows.Forms.Button()
        Me.btn_aceptar_importacion = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btn_ruta = New System.Windows.Forms.Button()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dgvdetalles_asientos = New System.Windows.Forms.DataGridView()
        Me.toolStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.dgv_asientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalles.SuspendLayout()
        Me.pnlDetalles.SuspendLayout()
        CType(Me.dgvDetalleAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gb_detalle_doc.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_ref.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCabecera.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFinalizarCompra.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnl_opt_cierre.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.pnl_importar_asientos.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgvdetalles_asientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.BackColor = System.Drawing.Color.White
        Me.toolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool_nuevo, Me.tool_editar, Me.tool_eliminar, Me.tool_anular, Me.tool_imprimir, Me.tool_actualizar, Me.Tool_reaperturar, Me.btn_importar_asientos, Me.btn_cancelar, Me.tool_salir, Me.btn_grabar})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(1221, 25)
        Me.toolStrip1.TabIndex = 100
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tool_nuevo
        '
        Me.tool_nuevo.Image = CType(resources.GetObject("tool_nuevo.Image"), System.Drawing.Image)
        Me.tool_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_nuevo.Name = "tool_nuevo"
        Me.tool_nuevo.Size = New System.Drawing.Size(62, 22)
        Me.tool_nuevo.Text = "&Nuevo"
        '
        'tool_editar
        '
        Me.tool_editar.Image = CType(resources.GetObject("tool_editar.Image"), System.Drawing.Image)
        Me.tool_editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_editar.Name = "tool_editar"
        Me.tool_editar.Size = New System.Drawing.Size(139, 22)
        Me.tool_editar.Text = "&Consultar/Modificar"
        '
        'tool_eliminar
        '
        Me.tool_eliminar.Image = CType(resources.GetObject("tool_eliminar.Image"), System.Drawing.Image)
        Me.tool_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_eliminar.Name = "tool_eliminar"
        Me.tool_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.tool_eliminar.Text = "&Eliminar"
        '
        'tool_anular
        '
        Me.tool_anular.Image = CType(resources.GetObject("tool_anular.Image"), System.Drawing.Image)
        Me.tool_anular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_anular.Name = "tool_anular"
        Me.tool_anular.Size = New System.Drawing.Size(64, 22)
        Me.tool_anular.Text = "&Anular"
        '
        'tool_imprimir
        '
        Me.tool_imprimir.Image = CType(resources.GetObject("tool_imprimir.Image"), System.Drawing.Image)
        Me.tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_imprimir.Name = "tool_imprimir"
        Me.tool_imprimir.Size = New System.Drawing.Size(77, 22)
        Me.tool_imprimir.Text = "&Imprimir"
        '
        'tool_actualizar
        '
        Me.tool_actualizar.Image = CType(resources.GetObject("tool_actualizar.Image"), System.Drawing.Image)
        Me.tool_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_actualizar.Name = "tool_actualizar"
        Me.tool_actualizar.Size = New System.Drawing.Size(133, 22)
        Me.tool_actualizar.Text = "&Mostrar/Refrescar"
        Me.tool_actualizar.ToolTipText = "Actualizar data"
        '
        'Tool_reaperturar
        '
        Me.Tool_reaperturar.Image = CType(resources.GetObject("Tool_reaperturar.Image"), System.Drawing.Image)
        Me.Tool_reaperturar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_reaperturar.Name = "Tool_reaperturar"
        Me.Tool_reaperturar.Size = New System.Drawing.Size(102, 22)
        Me.Tool_reaperturar.Text = "&Re-aperturar"
        '
        'btn_importar_asientos
        '
        Me.btn_importar_asientos.Image = CType(resources.GetObject("btn_importar_asientos.Image"), System.Drawing.Image)
        Me.btn_importar_asientos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_importar_asientos.Name = "btn_importar_asientos"
        Me.btn_importar_asientos.Size = New System.Drawing.Size(131, 22)
        Me.btn_importar_asientos.Text = "Importar Asientos"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "Cance&lar"
        '
        'tool_salir
        '
        Me.tool_salir.Image = CType(resources.GetObject("tool_salir.Image"), System.Drawing.Image)
        Me.tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_salir.Name = "tool_salir"
        Me.tool_salir.Size = New System.Drawing.Size(52, 22)
        Me.tool_salir.Text = "&Salir"
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.Visible = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.cmb_ope)
        Me.groupBox1.Controls.Add(Me.dtp_Año)
        Me.groupBox1.Controls.Add(Me.cmb_sub)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.cmb_meses)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Location = New System.Drawing.Point(12, 28)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(1201, 41)
        Me.groupBox1.TabIndex = 101
        Me.groupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(702, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Año"
        '
        'cmb_ope
        '
        Me.cmb_ope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ope.FormattingEnabled = True
        Me.cmb_ope.Location = New System.Drawing.Point(68, 14)
        Me.cmb_ope.Name = "cmb_ope"
        Me.cmb_ope.Size = New System.Drawing.Size(157, 21)
        Me.cmb_ope.TabIndex = 0
        '
        'dtp_Año
        '
        Me.dtp_Año.CustomFormat = "yyyy"
        Me.dtp_Año.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Año.Location = New System.Drawing.Point(734, 15)
        Me.dtp_Año.Name = "dtp_Año"
        Me.dtp_Año.Size = New System.Drawing.Size(100, 20)
        Me.dtp_Año.TabIndex = 3
        '
        'cmb_sub
        '
        Me.cmb_sub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sub.FormattingEnabled = True
        Me.cmb_sub.Location = New System.Drawing.Point(331, 15)
        Me.cmb_sub.Name = "cmb_sub"
        Me.cmb_sub.Size = New System.Drawing.Size(179, 21)
        Me.cmb_sub.TabIndex = 1
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(274, 18)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(51, 13)
        Me.label3.TabIndex = 103
        Me.label3.Text = "Subdiario"
        '
        'cmb_meses
        '
        Me.cmb_meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_meses.FormattingEnabled = True
        Me.cmb_meses.Location = New System.Drawing.Point(564, 14)
        Me.cmb_meses.Name = "cmb_meses"
        Me.cmb_meses.Size = New System.Drawing.Size(116, 21)
        Me.cmb_meses.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Navy
        Me.label1.Location = New System.Drawing.Point(531, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(27, 13)
        Me.label1.TabIndex = 104
        Me.label1.Text = "Mes"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(6, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 13)
        Me.label2.TabIndex = 102
        Me.label2.Text = "Operacion"
        '
        'dgv_asientos
        '
        Me.dgv_asientos.AllowUserToAddRows = False
        Me.dgv_asientos.AllowUserToDeleteRows = False
        Me.dgv_asientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_asientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_asientos.Location = New System.Drawing.Point(12, 69)
        Me.dgv_asientos.Name = "dgv_asientos"
        Me.dgv_asientos.ReadOnly = True
        Me.dgv_asientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_asientos.Size = New System.Drawing.Size(1201, 544)
        Me.dgv_asientos.TabIndex = 4
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.mtb_dif_dolares)
        Me.gbDetalles.Controls.Add(Me.mtb_tot_d_dolares)
        Me.gbDetalles.Controls.Add(Me.mtb_tot_h_dolares)
        Me.gbDetalles.Controls.Add(Me.Label40)
        Me.gbDetalles.Controls.Add(Me.Label38)
        Me.gbDetalles.Controls.Add(Me.pnlDetalles)
        Me.gbDetalles.Controls.Add(Me.gb_detalle_doc)
        Me.gbDetalles.Controls.Add(Me.txt_d2)
        Me.gbDetalles.Controls.Add(Me.txt_d1)
        Me.gbDetalles.Controls.Add(Me.mtb_dif)
        Me.gbDetalles.Controls.Add(Me.mtb_tot_d)
        Me.gbDetalles.Controls.Add(Me.mtb_tot_h)
        Me.gbDetalles.Enabled = False
        Me.gbDetalles.ForeColor = System.Drawing.Color.Navy
        Me.gbDetalles.Location = New System.Drawing.Point(16, 121)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(1181, 490)
        Me.gbDetalles.TabIndex = 103
        Me.gbDetalles.TabStop = False
        '
        'mtb_dif_dolares
        '
        Me.mtb_dif_dolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_dif_dolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_dif_dolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_dif_dolares.ForeColor = System.Drawing.Color.Red
        Me.mtb_dif_dolares.Location = New System.Drawing.Point(847, 293)
        Me.mtb_dif_dolares.Name = "mtb_dif_dolares"
        Me.mtb_dif_dolares.ReadOnly = True
        Me.mtb_dif_dolares.Size = New System.Drawing.Size(86, 21)
        Me.mtb_dif_dolares.TabIndex = 23
        Me.mtb_dif_dolares.Text = "0.00"
        Me.mtb_dif_dolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtb_tot_d_dolares
        '
        Me.mtb_tot_d_dolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_tot_d_dolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_tot_d_dolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_tot_d_dolares.ForeColor = System.Drawing.Color.Navy
        Me.mtb_tot_d_dolares.Location = New System.Drawing.Point(756, 270)
        Me.mtb_tot_d_dolares.Name = "mtb_tot_d_dolares"
        Me.mtb_tot_d_dolares.ReadOnly = True
        Me.mtb_tot_d_dolares.Size = New System.Drawing.Size(86, 21)
        Me.mtb_tot_d_dolares.TabIndex = 21
        Me.mtb_tot_d_dolares.Text = "0.00"
        Me.mtb_tot_d_dolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtb_tot_h_dolares
        '
        Me.mtb_tot_h_dolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_tot_h_dolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_tot_h_dolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_tot_h_dolares.ForeColor = System.Drawing.Color.Navy
        Me.mtb_tot_h_dolares.Location = New System.Drawing.Point(847, 270)
        Me.mtb_tot_h_dolares.Name = "mtb_tot_h_dolares"
        Me.mtb_tot_h_dolares.ReadOnly = True
        Me.mtb_tot_h_dolares.Size = New System.Drawing.Size(86, 21)
        Me.mtb_tot_h_dolares.TabIndex = 22
        Me.mtb_tot_h_dolares.Text = "0.00"
        Me.mtb_tot_h_dolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(483, 297)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(73, 13)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "DIFERENCIA"
        '
        'Label38
        '
        Me.Label38.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(483, 274)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(56, 13)
        Me.Label38.TabIndex = 18
        Me.Label38.Text = "TOTALES"
        '
        'pnlDetalles
        '
        Me.pnlDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetalles.Controls.Add(Me.dgvDetalleAsiento)
        Me.pnlDetalles.Controls.Add(Me.GroupBox2)
        Me.pnlDetalles.Location = New System.Drawing.Point(10, 15)
        Me.pnlDetalles.Name = "pnlDetalles"
        Me.pnlDetalles.Size = New System.Drawing.Size(1159, 251)
        Me.pnlDetalles.TabIndex = 17
        '
        'dgvDetalleAsiento
        '
        Me.dgvDetalleAsiento.AllowUserToAddRows = False
        Me.dgvDetalleAsiento.AllowUserToDeleteRows = False
        Me.dgvDetalleAsiento.AllowUserToResizeColumns = False
        Me.dgvDetalleAsiento.AllowUserToResizeRows = False
        Me.dgvDetalleAsiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleAsiento.Location = New System.Drawing.Point(7, 5)
        Me.dgvDetalleAsiento.Name = "dgvDetalleAsiento"
        Me.dgvDetalleAsiento.ReadOnly = True
        Me.dgvDetalleAsiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleAsiento.Size = New System.Drawing.Size(1063, 243)
        Me.dgvDetalleAsiento.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.btnQuitar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(1076, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(74, 247)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(5, 20)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(63, 51)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "&Nuevo"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Image = CType(resources.GetObject("btnQuitar.Image"), System.Drawing.Image)
        Me.btnQuitar.Location = New System.Drawing.Point(4, 126)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(63, 51)
        Me.btnQuitar.TabIndex = 9
        Me.btnQuitar.Text = "&Eliminar"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(5, 73)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(63, 51)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'gb_detalle_doc
        '
        Me.gb_detalle_doc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_detalle_doc.Controls.Add(Me.btn_ok)
        Me.gb_detalle_doc.Controls.Add(Me.PictureBox8)
        Me.gb_detalle_doc.Controls.Add(Me.txt_cen_cos)
        Me.gb_detalle_doc.Controls.Add(Me.Label39)
        Me.gb_detalle_doc.Controls.Add(Me.txt_detraccion)
        Me.gb_detalle_doc.Controls.Add(Me.Label41)
        Me.gb_detalle_doc.Controls.Add(Me.gb_ref)
        Me.gb_detalle_doc.Controls.Add(Me.mtb_haber)
        Me.gb_detalle_doc.Controls.Add(Me.mtb_debe)
        Me.gb_detalle_doc.Controls.Add(Me.txtCentroCosto)
        Me.gb_detalle_doc.Controls.Add(Me.PictureBox7)
        Me.gb_detalle_doc.Controls.Add(Me.PictureBox6)
        Me.gb_detalle_doc.Controls.Add(Me.txtCuentaContable)
        Me.gb_detalle_doc.Controls.Add(Me.PictureBox5)
        Me.gb_detalle_doc.Controls.Add(Me.txtTipoDocAsiento)
        Me.gb_detalle_doc.Controls.Add(Me.txt_glosa_det)
        Me.gb_detalle_doc.Controls.Add(Me.label19)
        Me.gb_detalle_doc.Controls.Add(Me.btn_ref)
        Me.gb_detalle_doc.Controls.Add(Me.btn_can)
        Me.gb_detalle_doc.Controls.Add(Me.chk_inafecto)
        Me.gb_detalle_doc.Controls.Add(Me.cmb_mp)
        Me.gb_detalle_doc.Controls.Add(Me.cmb_cc)
        Me.gb_detalle_doc.Controls.Add(Me.cmb_moneda)
        Me.gb_detalle_doc.Controls.Add(Me.txt_des_cta)
        Me.gb_detalle_doc.Controls.Add(Me.txt_num)
        Me.gb_detalle_doc.Controls.Add(Me.txt_ser)
        Me.gb_detalle_doc.Controls.Add(Me.txt_des_ane)
        Me.gb_detalle_doc.Controls.Add(Me.txt_cod_ane)
        Me.gb_detalle_doc.Controls.Add(Me.mtb_fec_ven)
        Me.gb_detalle_doc.Controls.Add(Me.mtb_fec_emi)
        Me.gb_detalle_doc.Controls.Add(Me.label10)
        Me.gb_detalle_doc.Controls.Add(Me.label12)
        Me.gb_detalle_doc.Controls.Add(Me.label14)
        Me.gb_detalle_doc.Controls.Add(Me.label13)
        Me.gb_detalle_doc.Controls.Add(Me.label11)
        Me.gb_detalle_doc.Controls.Add(Me.label9)
        Me.gb_detalle_doc.Controls.Add(Me.label16)
        Me.gb_detalle_doc.Controls.Add(Me.label15)
        Me.gb_detalle_doc.Controls.Add(Me.label8)
        Me.gb_detalle_doc.Controls.Add(Me.label7)
        Me.gb_detalle_doc.Controls.Add(Me.label6)
        Me.gb_detalle_doc.Controls.Add(Me.mtb_tc)
        Me.gb_detalle_doc.Controls.Add(Me.txt_cen_cos_des)
        Me.gb_detalle_doc.Enabled = False
        Me.gb_detalle_doc.ForeColor = System.Drawing.Color.Navy
        Me.gb_detalle_doc.Location = New System.Drawing.Point(10, 318)
        Me.gb_detalle_doc.Name = "gb_detalle_doc"
        Me.gb_detalle_doc.Size = New System.Drawing.Size(1150, 160)
        Me.gb_detalle_doc.TabIndex = 3
        Me.gb_detalle_doc.TabStop = False
        '
        'btn_ok
        '
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.ForeColor = System.Drawing.Color.Navy
        Me.btn_ok.Image = Global.LibContabilidad.My.Resources.Resources.forward
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.Location = New System.Drawing.Point(755, 79)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(69, 48)
        Me.btn_ok.TabIndex = 23
        Me.btn_ok.Text = "&Insertar"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(192, 42)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox8.TabIndex = 121
        Me.PictureBox8.TabStop = False
        '
        'txt_cen_cos
        '
        Me.txt_cen_cos.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_cen_cos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cen_cos.Location = New System.Drawing.Point(92, 41)
        Me.txt_cen_cos.Name = "txt_cen_cos"
        Me.txt_cen_cos.Size = New System.Drawing.Size(97, 20)
        Me.txt_cen_cos.TabIndex = 120
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(34, 45)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(53, 13)
        Me.Label39.TabIndex = 119
        Me.Label39.Text = "Cen, Cos."
        '
        'txt_detraccion
        '
        Me.txt_detraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_detraccion.Location = New System.Drawing.Point(666, 111)
        Me.txt_detraccion.Name = "txt_detraccion"
        Me.txt_detraccion.Size = New System.Drawing.Size(70, 20)
        Me.txt_detraccion.TabIndex = 20
        Me.txt_detraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_detraccion.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(563, 115)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(94, 13)
        Me.Label41.TabIndex = 117
        Me.Label41.Text = "% DETRACCION"
        Me.Label41.Visible = False
        '
        'gb_ref
        '
        Me.gb_ref.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gb_ref.Controls.Add(Me.btn_aceptar_ref)
        Me.gb_ref.Controls.Add(Me.label18)
        Me.gb_ref.Controls.Add(Me.label17)
        Me.gb_ref.Controls.Add(Me.mtb_fec_ven_ref)
        Me.gb_ref.Controls.Add(Me.mtb_fec_emi_ref)
        Me.gb_ref.Controls.Add(Me.txt_ndoc_ref)
        Me.gb_ref.Controls.Add(Me.txt_tdoc_ref)
        Me.gb_ref.Controls.Add(Me.txt_sdoc_ref)
        Me.gb_ref.ForeColor = System.Drawing.Color.Navy
        Me.gb_ref.Location = New System.Drawing.Point(309, 44)
        Me.gb_ref.Name = "gb_ref"
        Me.gb_ref.Size = New System.Drawing.Size(230, 108)
        Me.gb_ref.TabIndex = 7
        Me.gb_ref.TabStop = False
        Me.gb_ref.Text = "Doc. Referencia"
        '
        'btn_aceptar_ref
        '
        Me.btn_aceptar_ref.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_aceptar_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar_ref.Image = CType(resources.GetObject("btn_aceptar_ref.Image"), System.Drawing.Image)
        Me.btn_aceptar_ref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar_ref.Location = New System.Drawing.Point(92, 78)
        Me.btn_aceptar_ref.Name = "btn_aceptar_ref"
        Me.btn_aceptar_ref.Size = New System.Drawing.Size(65, 23)
        Me.btn_aceptar_ref.TabIndex = 0
        Me.btn_aceptar_ref.Text = "Aceptar"
        Me.btn_aceptar_ref.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar_ref.UseVisualStyleBackColor = True
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.ForeColor = System.Drawing.Color.Navy
        Me.label18.Location = New System.Drawing.Point(6, 55)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(42, 13)
        Me.label18.TabIndex = 7
        Me.label18.Text = "Fechas"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.ForeColor = System.Drawing.Color.Navy
        Me.label17.Location = New System.Drawing.Point(6, 29)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(44, 13)
        Me.label17.TabIndex = 6
        Me.label17.Text = "Docum."
        '
        'mtb_fec_ven_ref
        '
        Me.mtb_fec_ven_ref.Location = New System.Drawing.Point(135, 52)
        Me.mtb_fec_ven_ref.Mask = "00/00/0000"
        Me.mtb_fec_ven_ref.Name = "mtb_fec_ven_ref"
        Me.mtb_fec_ven_ref.Size = New System.Drawing.Size(79, 20)
        Me.mtb_fec_ven_ref.TabIndex = 0
        Me.mtb_fec_ven_ref.ValidatingType = GetType(Date)
        '
        'mtb_fec_emi_ref
        '
        Me.mtb_fec_emi_ref.Location = New System.Drawing.Point(53, 52)
        Me.mtb_fec_emi_ref.Mask = "00/00/0000"
        Me.mtb_fec_emi_ref.Name = "mtb_fec_emi_ref"
        Me.mtb_fec_emi_ref.Size = New System.Drawing.Size(79, 20)
        Me.mtb_fec_emi_ref.TabIndex = 0
        Me.mtb_fec_emi_ref.ValidatingType = GetType(Date)
        '
        'txt_ndoc_ref
        '
        Me.txt_ndoc_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ndoc_ref.Location = New System.Drawing.Point(123, 26)
        Me.txt_ndoc_ref.Name = "txt_ndoc_ref"
        Me.txt_ndoc_ref.Size = New System.Drawing.Size(97, 20)
        Me.txt_ndoc_ref.TabIndex = 0
        '
        'txt_tdoc_ref
        '
        Me.txt_tdoc_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tdoc_ref.Location = New System.Drawing.Point(53, 26)
        Me.txt_tdoc_ref.Name = "txt_tdoc_ref"
        Me.txt_tdoc_ref.Size = New System.Drawing.Size(27, 20)
        Me.txt_tdoc_ref.TabIndex = 0
        '
        'txt_sdoc_ref
        '
        Me.txt_sdoc_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sdoc_ref.Location = New System.Drawing.Point(81, 26)
        Me.txt_sdoc_ref.Name = "txt_sdoc_ref"
        Me.txt_sdoc_ref.Size = New System.Drawing.Size(39, 20)
        Me.txt_sdoc_ref.TabIndex = 0
        '
        'mtb_haber
        '
        Me.mtb_haber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_haber.Location = New System.Drawing.Point(489, 112)
        Me.mtb_haber.Name = "mtb_haber"
        Me.mtb_haber.Size = New System.Drawing.Size(70, 20)
        Me.mtb_haber.TabIndex = 19
        Me.mtb_haber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtb_debe
        '
        Me.mtb_debe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_debe.Location = New System.Drawing.Point(352, 112)
        Me.mtb_debe.Name = "mtb_debe"
        Me.mtb_debe.Size = New System.Drawing.Size(70, 20)
        Me.mtb_debe.TabIndex = 18
        Me.mtb_debe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCentroCosto
        '
        Me.txtCentroCosto.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCentroCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroCosto.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroCosto.Location = New System.Drawing.Point(614, 16)
        Me.txtCentroCosto.Name = "txtCentroCosto"
        Me.txtCentroCosto.Size = New System.Drawing.Size(298, 22)
        Me.txtCentroCosto.TabIndex = 23
        Me.txtCentroCosto.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(192, 66)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox7.TabIndex = 114
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(192, 18)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 113
        Me.PictureBox6.TabStop = False
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaContable.Location = New System.Drawing.Point(92, 17)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(97, 20)
        Me.txtCuentaContable.TabIndex = 10
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(134, 90)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox5.TabIndex = 111
        Me.PictureBox5.TabStop = False
        '
        'txtTipoDocAsiento
        '
        Me.txtTipoDocAsiento.BackColor = System.Drawing.Color.Aquamarine
        Me.txtTipoDocAsiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoDocAsiento.Location = New System.Drawing.Point(92, 88)
        Me.txtTipoDocAsiento.MaxLength = 5
        Me.txtTipoDocAsiento.Name = "txtTipoDocAsiento"
        Me.txtTipoDocAsiento.Size = New System.Drawing.Size(39, 20)
        Me.txtTipoDocAsiento.TabIndex = 12
        '
        'txt_glosa_det
        '
        Me.txt_glosa_det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_glosa_det.Location = New System.Drawing.Point(92, 134)
        Me.txt_glosa_det.Name = "txt_glosa_det"
        Me.txt_glosa_det.Size = New System.Drawing.Size(644, 20)
        Me.txt_glosa_det.TabIndex = 21
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(53, 139)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(34, 13)
        Me.label19.TabIndex = 18
        Me.label19.Text = "Glosa"
        '
        'btn_ref
        '
        Me.btn_ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ref.Location = New System.Drawing.Point(350, 88)
        Me.btn_ref.Name = "btn_ref"
        Me.btn_ref.Size = New System.Drawing.Size(27, 23)
        Me.btn_ref.TabIndex = 6
        Me.btn_ref.Text = "..."
        Me.btn_ref.UseVisualStyleBackColor = True
        '
        'btn_can
        '
        Me.btn_can.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_can.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_can.ForeColor = System.Drawing.Color.Navy
        Me.btn_can.Image = Global.LibContabilidad.My.Resources.Resources.stop_2
        Me.btn_can.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_can.Location = New System.Drawing.Point(828, 79)
        Me.btn_can.Name = "btn_can"
        Me.btn_can.Size = New System.Drawing.Size(69, 48)
        Me.btn_can.TabIndex = 0
        Me.btn_can.Text = "&Cancelar"
        Me.btn_can.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_can.UseVisualStyleBackColor = True
        '
        'chk_inafecto
        '
        Me.chk_inafecto.AutoSize = True
        Me.chk_inafecto.Location = New System.Drawing.Point(571, 91)
        Me.chk_inafecto.Name = "chk_inafecto"
        Me.chk_inafecto.Size = New System.Drawing.Size(65, 17)
        Me.chk_inafecto.TabIndex = 0
        Me.chk_inafecto.Text = "Inafecto"
        Me.chk_inafecto.UseVisualStyleBackColor = True
        '
        'cmb_mp
        '
        Me.cmb_mp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mp.DropDownWidth = 150
        Me.cmb_mp.FormattingEnabled = True
        Me.cmb_mp.Location = New System.Drawing.Point(615, 41)
        Me.cmb_mp.Name = "cmb_mp"
        Me.cmb_mp.Size = New System.Drawing.Size(297, 21)
        Me.cmb_mp.TabIndex = 24
        '
        'cmb_cc
        '
        Me.cmb_cc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cc.DropDownWidth = 150
        Me.cmb_cc.FormattingEnabled = True
        Me.cmb_cc.Location = New System.Drawing.Point(615, 16)
        Me.cmb_cc.Name = "cmb_cc"
        Me.cmb_cc.Size = New System.Drawing.Size(297, 21)
        Me.cmb_cc.TabIndex = 22
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(412, 89)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(58, 21)
        Me.cmb_moneda.TabIndex = 15
        '
        'txt_des_cta
        '
        Me.txt_des_cta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_cta.Location = New System.Drawing.Point(212, 17)
        Me.txt_des_cta.Name = "txt_des_cta"
        Me.txt_des_cta.ReadOnly = True
        Me.txt_des_cta.Size = New System.Drawing.Size(322, 20)
        Me.txt_des_cta.TabIndex = 0
        '
        'txt_num
        '
        Me.txt_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num.Location = New System.Drawing.Point(212, 88)
        Me.txt_num.MaxLength = 20
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(132, 20)
        Me.txt_num.TabIndex = 14
        '
        'txt_ser
        '
        Me.txt_ser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ser.Location = New System.Drawing.Point(157, 88)
        Me.txt_ser.MaxLength = 5
        Me.txt_ser.Name = "txt_ser"
        Me.txt_ser.Size = New System.Drawing.Size(48, 20)
        Me.txt_ser.TabIndex = 13
        Me.txt_ser.Text = " "
        '
        'txt_des_ane
        '
        Me.txt_des_ane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_ane.Location = New System.Drawing.Point(212, 66)
        Me.txt_des_ane.Name = "txt_des_ane"
        Me.txt_des_ane.ReadOnly = True
        Me.txt_des_ane.Size = New System.Drawing.Size(322, 20)
        Me.txt_des_ane.TabIndex = 0
        '
        'txt_cod_ane
        '
        Me.txt_cod_ane.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_ane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_ane.Location = New System.Drawing.Point(92, 66)
        Me.txt_cod_ane.Name = "txt_cod_ane"
        Me.txt_cod_ane.Size = New System.Drawing.Size(97, 20)
        Me.txt_cod_ane.TabIndex = 11
        '
        'mtb_fec_ven
        '
        Me.mtb_fec_ven.Location = New System.Drawing.Point(216, 111)
        Me.mtb_fec_ven.Mask = "00/00/0000"
        Me.mtb_fec_ven.Name = "mtb_fec_ven"
        Me.mtb_fec_ven.Size = New System.Drawing.Size(65, 20)
        Me.mtb_fec_ven.TabIndex = 17
        Me.mtb_fec_ven.ValidatingType = GetType(Date)
        '
        'mtb_fec_emi
        '
        Me.mtb_fec_emi.Location = New System.Drawing.Point(92, 111)
        Me.mtb_fec_emi.Mask = "00/00/0000"
        Me.mtb_fec_emi.Name = "mtb_fec_emi"
        Me.mtb_fec_emi.Size = New System.Drawing.Size(66, 20)
        Me.mtb_fec_emi.TabIndex = 16
        Me.mtb_fec_emi.ValidatingType = GetType(Date)
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(162, 114)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(53, 13)
        Me.label10.TabIndex = 1
        Me.label10.Text = "Fec. Ven."
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(429, 115)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(44, 13)
        Me.label12.TabIndex = 1
        Me.label12.Text = "&HABER"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(540, 45)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(64, 13)
        Me.label14.TabIndex = 1
        Me.label14.Text = "Medio Pago"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(540, 21)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(68, 13)
        Me.label13.TabIndex = 1
        Me.label13.Text = "Centro Costo"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(296, 115)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(36, 13)
        Me.label11.TabIndex = 1
        Me.label11.Text = "&DEBE"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(36, 114)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(51, 13)
        Me.label9.TabIndex = 1
        Me.label9.Text = "Fec. Emi."
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(473, 92)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(27, 13)
        Me.label16.TabIndex = 1
        Me.label16.Text = "T.C."
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(378, 92)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(28, 13)
        Me.label15.TabIndex = 1
        Me.label15.Text = "Mon"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(43, 91)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(44, 13)
        Me.label8.TabIndex = 1
        Me.label8.Text = "Docum."
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(50, 69)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(37, 13)
        Me.label7.TabIndex = 1
        Me.label7.Text = "Anexo"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(46, 20)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(41, 13)
        Me.label6.TabIndex = 1
        Me.label6.Text = "Cuenta"
        '
        'mtb_tc
        '
        Me.mtb_tc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_tc.Location = New System.Drawing.Point(501, 90)
        Me.mtb_tc.Name = "mtb_tc"
        Me.mtb_tc.Size = New System.Drawing.Size(58, 20)
        Me.mtb_tc.TabIndex = 0
        '
        'txt_cen_cos_des
        '
        Me.txt_cen_cos_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cen_cos_des.Location = New System.Drawing.Point(212, 41)
        Me.txt_cen_cos_des.Name = "txt_cen_cos_des"
        Me.txt_cen_cos_des.ReadOnly = True
        Me.txt_cen_cos_des.Size = New System.Drawing.Size(322, 20)
        Me.txt_cen_cos_des.TabIndex = 118
        '
        'txt_d2
        '
        Me.txt_d2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_d2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_d2.Location = New System.Drawing.Point(1156, 309)
        Me.txt_d2.Name = "txt_d2"
        Me.txt_d2.Size = New System.Drawing.Size(52, 21)
        Me.txt_d2.TabIndex = 0
        Me.txt_d2.Visible = False
        '
        'txt_d1
        '
        Me.txt_d1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_d1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_d1.Location = New System.Drawing.Point(1098, 309)
        Me.txt_d1.Name = "txt_d1"
        Me.txt_d1.Size = New System.Drawing.Size(52, 21)
        Me.txt_d1.TabIndex = 0
        Me.txt_d1.Visible = False
        '
        'mtb_dif
        '
        Me.mtb_dif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_dif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_dif.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_dif.ForeColor = System.Drawing.Color.Red
        Me.mtb_dif.Location = New System.Drawing.Point(666, 293)
        Me.mtb_dif.Name = "mtb_dif"
        Me.mtb_dif.ReadOnly = True
        Me.mtb_dif.Size = New System.Drawing.Size(86, 21)
        Me.mtb_dif.TabIndex = 0
        Me.mtb_dif.Text = "0.00"
        Me.mtb_dif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtb_tot_d
        '
        Me.mtb_tot_d.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_tot_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_tot_d.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_tot_d.ForeColor = System.Drawing.Color.Navy
        Me.mtb_tot_d.Location = New System.Drawing.Point(576, 270)
        Me.mtb_tot_d.Name = "mtb_tot_d"
        Me.mtb_tot_d.ReadOnly = True
        Me.mtb_tot_d.Size = New System.Drawing.Size(86, 21)
        Me.mtb_tot_d.TabIndex = 0
        Me.mtb_tot_d.Text = "0.00"
        Me.mtb_tot_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtb_tot_h
        '
        Me.mtb_tot_h.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_tot_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_tot_h.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtb_tot_h.ForeColor = System.Drawing.Color.Navy
        Me.mtb_tot_h.Location = New System.Drawing.Point(666, 270)
        Me.mtb_tot_h.Name = "mtb_tot_h"
        Me.mtb_tot_h.ReadOnly = True
        Me.mtb_tot_h.Size = New System.Drawing.Size(86, 21)
        Me.mtb_tot_h.TabIndex = 0
        Me.mtb_tot_h.Text = "0.00"
        Me.mtb_tot_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbCabecera
        '
        Me.gbCabecera.Controls.Add(Me.PictureBox3)
        Me.gbCabecera.Controls.Add(Me.GroupBox3)
        Me.gbCabecera.Controls.Add(Me.PictureBox1)
        Me.gbCabecera.Controls.Add(Me.PictureBox4)
        Me.gbCabecera.Controls.Add(Me.txtMontoDoc)
        Me.gbCabecera.Controls.Add(Me.Label25)
        Me.gbCabecera.Controls.Add(Me.Label26)
        Me.gbCabecera.Controls.Add(Me.txtMontoIgv)
        Me.gbCabecera.Controls.Add(Me.cboMoneda)
        Me.gbCabecera.Controls.Add(Me.lbltasa)
        Me.gbCabecera.Controls.Add(Me.txtdescripcionDestino)
        Me.gbCabecera.Controls.Add(Me.txtTasa)
        Me.gbCabecera.Controls.Add(Me.txtDestino)
        Me.gbCabecera.Controls.Add(Me.Label27)
        Me.gbCabecera.Controls.Add(Me.Label37)
        Me.gbCabecera.Controls.Add(Me.txtdetraccion)
        Me.gbCabecera.Controls.Add(Me.Label35)
        Me.gbCabecera.Controls.Add(Me.txtPorc_Detrac)
        Me.gbCabecera.Controls.Add(Me.Label36)
        Me.gbCabecera.Controls.Add(Me.txt_ISC)
        Me.gbCabecera.Controls.Add(Me.Label33)
        Me.gbCabecera.Controls.Add(Me.txtPorc_ISC)
        Me.gbCabecera.Controls.Add(Me.Label34)
        Me.gbCabecera.Controls.Add(Me.chkdua)
        Me.gbCabecera.Controls.Add(Me.txtGlosaTransaccion)
        Me.gbCabecera.Controls.Add(Me.Label32)
        Me.gbCabecera.Controls.Add(Me.dtpOtraFecha)
        Me.gbCabecera.Controls.Add(Me.Label31)
        Me.gbCabecera.Controls.Add(Me.txtTipoCambio)
        Me.gbCabecera.Controls.Add(Me.Label30)
        Me.gbCabecera.Controls.Add(Me.txtNumeroDoc)
        Me.gbCabecera.Controls.Add(Me.txtSerieDoc)
        Me.gbCabecera.Controls.Add(Me.txtTipoDoc)
        Me.gbCabecera.Controls.Add(Me.Label24)
        Me.gbCabecera.Controls.Add(Me.dtpFechaVencimientoDoc)
        Me.gbCabecera.Controls.Add(Me.Label23)
        Me.gbCabecera.Controls.Add(Me.dtpFechaDoc)
        Me.gbCabecera.Controls.Add(Me.Label22)
        Me.gbCabecera.Controls.Add(Me.txtdescripciontercero)
        Me.gbCabecera.Controls.Add(Me.txtcodigoRuc)
        Me.gbCabecera.Controls.Add(Me.Label21)
        Me.gbCabecera.Controls.Add(Me.dtpFecha_PLE)
        Me.gbCabecera.Controls.Add(Me.Label20)
        Me.gbCabecera.Controls.Add(Me.dtp_fec_vou)
        Me.gbCabecera.Controls.Add(Me.txt_idcab)
        Me.gbCabecera.Controls.Add(Me.btn_nuevo)
        Me.gbCabecera.Controls.Add(Me.txt_glosa)
        Me.gbCabecera.Controls.Add(Me.txt_num_vou)
        Me.gbCabecera.Controls.Add(Me.cmb_sub_detalle)
        Me.gbCabecera.Controls.Add(Me.cmb_ope_detalle)
        Me.gbCabecera.Controls.Add(Me.label5)
        Me.gbCabecera.Controls.Add(Me.Label42)
        Me.gbCabecera.Controls.Add(Me.Label43)
        Me.gbCabecera.Controls.Add(Me.Label44)
        Me.gbCabecera.Controls.Add(Me.Label45)
        Me.gbCabecera.Controls.Add(Me.pnlFinalizarCompra)
        Me.gbCabecera.ForeColor = System.Drawing.Color.Navy
        Me.gbCabecera.Location = New System.Drawing.Point(16, 30)
        Me.gbCabecera.Name = "gbCabecera"
        Me.gbCabecera.Size = New System.Drawing.Size(1181, 89)
        Me.gbCabecera.TabIndex = 102
        Me.gbCabecera.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(115, 106)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 151
        Me.PictureBox3.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.txtFechaDocRef)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtTipoDocRef)
        Me.GroupBox3.Controls.Add(Me.txtSerieDocRef)
        Me.GroupBox3.Controls.Add(Me.txtNumDocRef)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Location = New System.Drawing.Point(486, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 39)
        Me.GroupBox3.TabIndex = 85
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Detalles del Documento Referencia"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(105, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 111
        Me.PictureBox2.TabStop = False
        '
        'txtFechaDocRef
        '
        Me.txtFechaDocRef.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaDocRef.Location = New System.Drawing.Point(361, 15)
        Me.txtFechaDocRef.Name = "txtFechaDocRef"
        Me.txtFechaDocRef.Size = New System.Drawing.Size(84, 20)
        Me.txtFechaDocRef.TabIndex = 13
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(7, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 13)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "Tipo Doc"
        '
        'txtTipoDocRef
        '
        Me.txtTipoDocRef.Location = New System.Drawing.Point(64, 14)
        Me.txtTipoDocRef.Name = "txtTipoDocRef"
        Me.txtTipoDocRef.ReadOnly = True
        Me.txtTipoDocRef.Size = New System.Drawing.Size(39, 20)
        Me.txtTipoDocRef.TabIndex = 10
        '
        'txtSerieDocRef
        '
        Me.txtSerieDocRef.Location = New System.Drawing.Point(126, 14)
        Me.txtSerieDocRef.MaxLength = 5
        Me.txtSerieDocRef.Name = "txtSerieDocRef"
        Me.txtSerieDocRef.Size = New System.Drawing.Size(35, 20)
        Me.txtSerieDocRef.TabIndex = 11
        '
        'txtNumDocRef
        '
        Me.txtNumDocRef.Location = New System.Drawing.Point(165, 14)
        Me.txtNumDocRef.MaxLength = 15
        Me.txtNumDocRef.Name = "txtNumDocRef"
        Me.txtNumDocRef.Size = New System.Drawing.Size(109, 20)
        Me.txtNumDocRef.TabIndex = 12
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(277, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 13)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "Fecha Doc Ref"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(117, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 111
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(174, 262)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 110
        Me.PictureBox4.TabStop = False
        '
        'txtMontoDoc
        '
        Me.txtMontoDoc.Location = New System.Drawing.Point(416, 133)
        Me.txtMontoDoc.Name = "txtMontoDoc"
        Me.txtMontoDoc.Size = New System.Drawing.Size(66, 20)
        Me.txtMontoDoc.TabIndex = 9
        Me.txtMontoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(136, 137)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 13)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Monto Igv"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(496, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Moneda"
        '
        'txtMontoIgv
        '
        Me.txtMontoIgv.Location = New System.Drawing.Point(196, 133)
        Me.txtMontoIgv.Name = "txtMontoIgv"
        Me.txtMontoIgv.Size = New System.Drawing.Size(57, 20)
        Me.txtMontoIgv.TabIndex = 7
        Me.txtMontoIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(549, 38)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(71, 21)
        Me.cboMoneda.TabIndex = 4
        '
        'lbltasa
        '
        Me.lbltasa.AutoSize = True
        Me.lbltasa.Location = New System.Drawing.Point(257, 137)
        Me.lbltasa.Name = "lbltasa"
        Me.lbltasa.Size = New System.Drawing.Size(42, 13)
        Me.lbltasa.TabIndex = 22
        Me.lbltasa.Text = "Tasa %"
        '
        'txtdescripcionDestino
        '
        Me.txtdescripcionDestino.Location = New System.Drawing.Point(140, 186)
        Me.txtdescripcionDestino.Name = "txtdescripcionDestino"
        Me.txtdescripcionDestino.ReadOnly = True
        Me.txtdescripcionDestino.Size = New System.Drawing.Size(141, 20)
        Me.txtdescripcionDestino.TabIndex = 49
        '
        'txtTasa
        '
        Me.txtTasa.Location = New System.Drawing.Point(303, 134)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Size = New System.Drawing.Size(42, 20)
        Me.txtTasa.TabIndex = 8
        Me.txtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(76, 185)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(36, 20)
        Me.txtDestino.TabIndex = 17
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(349, 137)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 13)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "Monto Total"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(7, 188)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(43, 13)
        Me.Label37.TabIndex = 47
        Me.Label37.Text = "Destino"
        '
        'txtdetraccion
        '
        Me.txtdetraccion.Location = New System.Drawing.Point(726, 185)
        Me.txtdetraccion.Name = "txtdetraccion"
        Me.txtdetraccion.Size = New System.Drawing.Size(68, 20)
        Me.txtdetraccion.TabIndex = 21
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(664, 188)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(59, 13)
        Me.Label35.TabIndex = 45
        Me.Label35.Text = "Detraccion"
        '
        'txtPorc_Detrac
        '
        Me.txtPorc_Detrac.Location = New System.Drawing.Point(590, 185)
        Me.txtPorc_Detrac.Name = "txtPorc_Detrac"
        Me.txtPorc_Detrac.Size = New System.Drawing.Size(68, 20)
        Me.txtPorc_Detrac.TabIndex = 20
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(514, 188)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(70, 13)
        Me.Label36.TabIndex = 43
        Me.Label36.Text = "Detraccion %"
        '
        'txt_ISC
        '
        Me.txt_ISC.Location = New System.Drawing.Point(414, 185)
        Me.txt_ISC.Name = "txt_ISC"
        Me.txt_ISC.Size = New System.Drawing.Size(95, 20)
        Me.txt_ISC.TabIndex = 19
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(378, 188)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 13)
        Me.Label33.TabIndex = 41
        Me.Label33.Text = "I.S.C"
        '
        'txtPorc_ISC
        '
        Me.txtPorc_ISC.Location = New System.Drawing.Point(333, 185)
        Me.txtPorc_ISC.Name = "txtPorc_ISC"
        Me.txtPorc_ISC.Size = New System.Drawing.Size(39, 20)
        Me.txtPorc_ISC.TabIndex = 18
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(288, 188)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 13)
        Me.Label34.TabIndex = 39
        Me.Label34.Text = "I.S.C %"
        '
        'chkdua
        '
        Me.chkdua.AutoSize = True
        Me.chkdua.Location = New System.Drawing.Point(362, 166)
        Me.chkdua.Name = "chkdua"
        Me.chkdua.Size = New System.Drawing.Size(81, 17)
        Me.chkdua.TabIndex = 38
        Me.chkdua.Text = "Importacion"
        Me.chkdua.UseVisualStyleBackColor = True
        '
        'txtGlosaTransaccion
        '
        Me.txtGlosaTransaccion.Location = New System.Drawing.Point(140, 210)
        Me.txtGlosaTransaccion.Name = "txtGlosaTransaccion"
        Me.txtGlosaTransaccion.Size = New System.Drawing.Size(724, 20)
        Me.txtGlosaTransaccion.TabIndex = 22
        Me.txtGlosaTransaccion.Text = " "
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(7, 214)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(117, 13)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = "Glosa del Comprobante"
        '
        'dtpOtraFecha
        '
        Me.dtpOtraFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOtraFecha.Location = New System.Drawing.Point(255, 163)
        Me.dtpOtraFecha.Name = "dtpOtraFecha"
        Me.dtpOtraFecha.Size = New System.Drawing.Size(97, 20)
        Me.dtpOtraFecha.TabIndex = 150
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(167, 167)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(82, 13)
        Me.Label31.TabIndex = 34
        Me.Label31.Text = "T/C Otra Fecha"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(76, 162)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(83, 20)
        Me.txtTipoCambio.TabIndex = 14
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 166)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(66, 13)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "Tipo Cambio"
        '
        'txtNumeroDoc
        '
        Me.txtNumeroDoc.Location = New System.Drawing.Point(178, 104)
        Me.txtNumeroDoc.MaxLength = 15
        Me.txtNumeroDoc.Name = "txtNumeroDoc"
        Me.txtNumeroDoc.Size = New System.Drawing.Size(110, 20)
        Me.txtNumeroDoc.TabIndex = 4
        Me.txtNumeroDoc.Text = " "
        '
        'txtSerieDoc
        '
        Me.txtSerieDoc.Location = New System.Drawing.Point(136, 104)
        Me.txtSerieDoc.MaxLength = 5
        Me.txtSerieDoc.Name = "txtSerieDoc"
        Me.txtSerieDoc.Size = New System.Drawing.Size(38, 20)
        Me.txtSerieDoc.TabIndex = 3
        Me.txtSerieDoc.Text = " "
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.Location = New System.Drawing.Point(76, 104)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.ReadOnly = True
        Me.txtTipoDoc.Size = New System.Drawing.Size(36, 20)
        Me.txtTipoDoc.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 107)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 13)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Documento"
        '
        'dtpFechaVencimientoDoc
        '
        Me.dtpFechaVencimientoDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimientoDoc.Location = New System.Drawing.Point(536, 102)
        Me.dtpFechaVencimientoDoc.Name = "dtpFechaVencimientoDoc"
        Me.dtpFechaVencimientoDoc.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaVencimientoDoc.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(459, 105)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Fecha vencto"
        '
        'dtpFechaDoc
        '
        Me.dtpFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDoc.Location = New System.Drawing.Point(356, 102)
        Me.dtpFechaDoc.Name = "dtpFechaDoc"
        Me.dtpFechaDoc.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaDoc.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(293, 106)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Fecha Doc"
        '
        'txtdescripciontercero
        '
        Me.txtdescripciontercero.Location = New System.Drawing.Point(196, 261)
        Me.txtdescripciontercero.Name = "txtdescripciontercero"
        Me.txtdescripciontercero.ReadOnly = True
        Me.txtdescripciontercero.Size = New System.Drawing.Size(560, 20)
        Me.txtdescripciontercero.TabIndex = 90
        '
        'txtcodigoRuc
        '
        Me.txtcodigoRuc.Location = New System.Drawing.Point(88, 261)
        Me.txtcodigoRuc.Name = "txtcodigoRuc"
        Me.txtcodigoRuc.Size = New System.Drawing.Size(83, 20)
        Me.txtcodigoRuc.TabIndex = 1
        Me.txtcodigoRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(19, 265)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Proveedor"
        '
        'dtpFecha_PLE
        '
        Me.dtpFecha_PLE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_PLE.Location = New System.Drawing.Point(726, 102)
        Me.dtpFecha_PLE.Name = "dtpFecha_PLE"
        Me.dtpFecha_PLE.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecha_PLE.TabIndex = 89
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(652, 106)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Periodo PLE"
        '
        'dtp_fec_vou
        '
        Me.dtp_fec_vou.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_vou.Location = New System.Drawing.Point(390, 38)
        Me.dtp_fec_vou.Name = "dtp_fec_vou"
        Me.dtp_fec_vou.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fec_vou.TabIndex = 3
        '
        'txt_idcab
        '
        Me.txt_idcab.Location = New System.Drawing.Point(461, 13)
        Me.txt_idcab.Name = "txt_idcab"
        Me.txt_idcab.ReadOnly = True
        Me.txt_idcab.Size = New System.Drawing.Size(26, 20)
        Me.txt_idcab.TabIndex = 0
        Me.txt_idcab.Visible = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(625, 53)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(55, 34)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_glosa
        '
        Me.txt_glosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_glosa.Location = New System.Drawing.Point(140, 63)
        Me.txt_glosa.MaxLength = 100
        Me.txt_glosa.Name = "txt_glosa"
        Me.txt_glosa.Size = New System.Drawing.Size(480, 20)
        Me.txt_glosa.TabIndex = 5
        Me.txt_glosa.Text = " "
        '
        'txt_num_vou
        '
        Me.txt_num_vou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_vou.ForeColor = System.Drawing.Color.Navy
        Me.txt_num_vou.Location = New System.Drawing.Point(388, 13)
        Me.txt_num_vou.Name = "txt_num_vou"
        Me.txt_num_vou.ReadOnly = True
        Me.txt_num_vou.Size = New System.Drawing.Size(68, 21)
        Me.txt_num_vou.TabIndex = 0
        '
        'cmb_sub_detalle
        '
        Me.cmb_sub_detalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sub_detalle.FormattingEnabled = True
        Me.cmb_sub_detalle.Location = New System.Drawing.Point(141, 40)
        Me.cmb_sub_detalle.Name = "cmb_sub_detalle"
        Me.cmb_sub_detalle.Size = New System.Drawing.Size(190, 21)
        Me.cmb_sub_detalle.TabIndex = 2
        '
        'cmb_ope_detalle
        '
        Me.cmb_ope_detalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ope_detalle.FormattingEnabled = True
        Me.cmb_ope_detalle.Location = New System.Drawing.Point(141, 14)
        Me.cmb_ope_detalle.Name = "cmb_ope_detalle"
        Me.cmb_ope_detalle.Size = New System.Drawing.Size(190, 21)
        Me.cmb_ope_detalle.TabIndex = 1
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(8, 67)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(108, 13)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Glosa del Movimiento"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(336, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(47, 13)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Voucher"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(341, 41)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(37, 13)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Fecha"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(7, 18)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(133, 13)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "&Seleccione una Operacion"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(7, 43)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(122, 13)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "&Seleccione un Subdiario"
        '
        'pnlFinalizarCompra
        '
        Me.pnlFinalizarCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlFinalizarCompra.Controls.Add(Me.GroupBox4)
        Me.pnlFinalizarCompra.Location = New System.Drawing.Point(1017, 11)
        Me.pnlFinalizarCompra.Name = "pnlFinalizarCompra"
        Me.pnlFinalizarCompra.Size = New System.Drawing.Size(151, 72)
        Me.pnlFinalizarCompra.TabIndex = 160
        Me.pnlFinalizarCompra.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_Finalizar)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(126, 58)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'btn_Finalizar
        '
        Me.btn_Finalizar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Finalizar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Finalizar.ForeColor = System.Drawing.Color.Navy
        Me.btn_Finalizar.Image = CType(resources.GetObject("btn_Finalizar.Image"), System.Drawing.Image)
        Me.btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Finalizar.Location = New System.Drawing.Point(8, 11)
        Me.btn_Finalizar.Name = "btn_Finalizar"
        Me.btn_Finalizar.Size = New System.Drawing.Size(109, 42)
        Me.btn_Finalizar.TabIndex = 157
        Me.btn_Finalizar.Text = "&Finalizar Asiento"
        Me.btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Finalizar.UseVisualStyleBackColor = True
        '
        'btn_remplaza_finalizar
        '
        Me.btn_remplaza_finalizar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_remplaza_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remplaza_finalizar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remplaza_finalizar.ForeColor = System.Drawing.Color.Navy
        Me.btn_remplaza_finalizar.Image = CType(resources.GetObject("btn_remplaza_finalizar.Image"), System.Drawing.Image)
        Me.btn_remplaza_finalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_remplaza_finalizar.Location = New System.Drawing.Point(1053, 45)
        Me.btn_remplaza_finalizar.Name = "btn_remplaza_finalizar"
        Me.btn_remplaza_finalizar.Size = New System.Drawing.Size(109, 53)
        Me.btn_remplaza_finalizar.TabIndex = 158
        Me.btn_remplaza_finalizar.Text = "&Finalizar Asiento"
        Me.btn_remplaza_finalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_remplaza_finalizar.UseVisualStyleBackColor = True
        Me.btn_remplaza_finalizar.Visible = False
        '
        'pnl_opt_cierre
        '
        Me.pnl_opt_cierre.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_opt_cierre.Controls.Add(Me.GroupBox5)
        Me.pnl_opt_cierre.Location = New System.Drawing.Point(279, 128)
        Me.pnl_opt_cierre.Name = "pnl_opt_cierre"
        Me.pnl_opt_cierre.Size = New System.Drawing.Size(472, 275)
        Me.pnl_opt_cierre.TabIndex = 162
        Me.pnl_opt_cierre.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.RadioButton17)
        Me.GroupBox5.Controls.Add(Me.RadioButton16)
        Me.GroupBox5.Controls.Add(Me.RadioButton15)
        Me.GroupBox5.Controls.Add(Me.RadioButton14)
        Me.GroupBox5.Controls.Add(Me.RadioButton13)
        Me.GroupBox5.Controls.Add(Me.RadioButton12)
        Me.GroupBox5.Controls.Add(Me.RadioButton11)
        Me.GroupBox5.Controls.Add(Me.RadioButton10)
        Me.GroupBox5.Controls.Add(Me.RadioButton9)
        Me.GroupBox5.Controls.Add(Me.RadioButton8)
        Me.GroupBox5.Controls.Add(Me.RadioButton7)
        Me.GroupBox5.Controls.Add(Me.RadioButton6)
        Me.GroupBox5.Controls.Add(Me.RadioButton5)
        Me.GroupBox5.Controls.Add(Me.RadioButton4)
        Me.GroupBox5.Controls.Add(Me.RadioButton3)
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Controls.Add(Me.btn_cancelar_opt_cierre)
        Me.GroupBox5.Controls.Add(Me.btn_aceptar_opt_cierre)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(453, 261)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton17.Location = New System.Drawing.Point(213, 200)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(201, 17)
        Me.RadioButton17.TabIndex = 19
        Me.RadioButton17.TabStop = True
        Me.RadioButton17.Text = "17.Saldar Activo, Pasivo y Patrimonio"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton16.Location = New System.Drawing.Point(213, 155)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(180, 30)
        Me.RadioButton16.TabIndex = 18
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.Text = "16.Transf. Result. del ejercicio a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Result. Acumulados"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton15.Location = New System.Drawing.Point(213, 132)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(192, 17)
        Me.RadioButton15.TabIndex = 17
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.Text = "15.Transf. saldo ctas. 87-88 a la 89"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton14.Location = New System.Drawing.Point(213, 109)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(223, 17)
        Me.RadioButton14.TabIndex = 16
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "14.Provisión distribución de la Renta Neta"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton13.Location = New System.Drawing.Point(213, 86)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(227, 17)
        Me.RadioButton13.TabIndex = 15
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "13.Provición Impto. a la Renta del ejercicio"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton12.Location = New System.Drawing.Point(213, 63)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(151, 17)
        Me.RadioButton12.TabIndex = 14
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "12.Transf. saldo 85 a la 89"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton11.Location = New System.Drawing.Point(213, 40)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(192, 17)
        Me.RadioButton11.TabIndex = 13
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "11.Transf. saldo ctas. 66-67 a la 85"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton10.Location = New System.Drawing.Point(213, 19)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(192, 17)
        Me.RadioButton10.TabIndex = 12
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "10.Transf. saldo ctas. 76-77 a la 85"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton9.Location = New System.Drawing.Point(17, 200)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(145, 17)
        Me.RadioButton9.TabIndex = 11
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "9.Transf. saldo 84 a la 85"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton8.Location = New System.Drawing.Point(17, 177)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(186, 17)
        Me.RadioButton8.TabIndex = 10
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "8.Transf. saldo ctas. 65-68 a la 84"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton7.Location = New System.Drawing.Point(17, 155)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(145, 17)
        Me.RadioButton7.TabIndex = 9
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "7.Transf. saldo 83 a la 84"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton6.Location = New System.Drawing.Point(17, 132)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(186, 17)
        Me.RadioButton6.TabIndex = 8
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "6.Transf. saldo ctas. 62-64 a la 83"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton5.Location = New System.Drawing.Point(17, 109)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(145, 17)
        Me.RadioButton5.TabIndex = 7
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "5.Transf. saldo 82 a la 83"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton4.Location = New System.Drawing.Point(17, 86)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(171, 17)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4.Transf. saldo ctas. 63 a la 82"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton3.Location = New System.Drawing.Point(17, 63)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(145, 17)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3.Transf. saldo 80 a la 82"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton2.Location = New System.Drawing.Point(17, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(148, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2.Transf. saldo 70 a la 80 "
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton1.Location = New System.Drawing.Point(17, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(178, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1.Cancelación de la cta. Clase 9"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btn_cancelar_opt_cierre
        '
        Me.btn_cancelar_opt_cierre.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancelar_opt_cierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_opt_cierre.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancelar_opt_cierre.Image = CType(resources.GetObject("btn_cancelar_opt_cierre.Image"), System.Drawing.Image)
        Me.btn_cancelar_opt_cierre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar_opt_cierre.Location = New System.Drawing.Point(228, 227)
        Me.btn_cancelar_opt_cierre.Name = "btn_cancelar_opt_cierre"
        Me.btn_cancelar_opt_cierre.Size = New System.Drawing.Size(77, 26)
        Me.btn_cancelar_opt_cierre.TabIndex = 2
        Me.btn_cancelar_opt_cierre.Text = "Cancelar"
        Me.btn_cancelar_opt_cierre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar_opt_cierre.UseVisualStyleBackColor = True
        '
        'btn_aceptar_opt_cierre
        '
        Me.btn_aceptar_opt_cierre.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_aceptar_opt_cierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar_opt_cierre.ForeColor = System.Drawing.Color.Navy
        Me.btn_aceptar_opt_cierre.Image = CType(resources.GetObject("btn_aceptar_opt_cierre.Image"), System.Drawing.Image)
        Me.btn_aceptar_opt_cierre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar_opt_cierre.Location = New System.Drawing.Point(145, 227)
        Me.btn_aceptar_opt_cierre.Name = "btn_aceptar_opt_cierre"
        Me.btn_aceptar_opt_cierre.Size = New System.Drawing.Size(77, 26)
        Me.btn_aceptar_opt_cierre.TabIndex = 1
        Me.btn_aceptar_opt_cierre.Text = "Aceptar"
        Me.btn_aceptar_opt_cierre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar_opt_cierre.UseVisualStyleBackColor = True
        '
        'pnl_importar_asientos
        '
        Me.pnl_importar_asientos.Controls.Add(Me.btn_cancelar_importacion)
        Me.pnl_importar_asientos.Controls.Add(Me.btn_aceptar_importacion)
        Me.pnl_importar_asientos.Controls.Add(Me.GroupBox6)
        Me.pnl_importar_asientos.Controls.Add(Me.GroupBox7)
        Me.pnl_importar_asientos.Location = New System.Drawing.Point(147, 35)
        Me.pnl_importar_asientos.Name = "pnl_importar_asientos"
        Me.pnl_importar_asientos.Size = New System.Drawing.Size(864, 524)
        Me.pnl_importar_asientos.TabIndex = 163
        Me.pnl_importar_asientos.Visible = False
        '
        'btn_cancelar_importacion
        '
        Me.btn_cancelar_importacion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancelar_importacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_importacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_importacion.ForeColor = System.Drawing.Color.Navy
        Me.btn_cancelar_importacion.Image = CType(resources.GetObject("btn_cancelar_importacion.Image"), System.Drawing.Image)
        Me.btn_cancelar_importacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar_importacion.Location = New System.Drawing.Point(750, 44)
        Me.btn_cancelar_importacion.Name = "btn_cancelar_importacion"
        Me.btn_cancelar_importacion.Size = New System.Drawing.Size(101, 30)
        Me.btn_cancelar_importacion.TabIndex = 220
        Me.btn_cancelar_importacion.Text = "Cancelar"
        Me.btn_cancelar_importacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar_importacion.UseVisualStyleBackColor = True
        '
        'btn_aceptar_importacion
        '
        Me.btn_aceptar_importacion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_aceptar_importacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar_importacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar_importacion.ForeColor = System.Drawing.Color.Navy
        Me.btn_aceptar_importacion.Image = CType(resources.GetObject("btn_aceptar_importacion.Image"), System.Drawing.Image)
        Me.btn_aceptar_importacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar_importacion.Location = New System.Drawing.Point(750, 10)
        Me.btn_aceptar_importacion.Name = "btn_aceptar_importacion"
        Me.btn_aceptar_importacion.Size = New System.Drawing.Size(101, 30)
        Me.btn_aceptar_importacion.TabIndex = 219
        Me.btn_aceptar_importacion.Text = "Importar"
        Me.btn_aceptar_importacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar_importacion.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btn_ruta)
        Me.GroupBox6.Controls.Add(Me.txt_ruta)
        Me.GroupBox6.Controls.Add(Me.Label47)
        Me.GroupBox6.Controls.Add(Me.Label48)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(723, 64)
        Me.GroupBox6.TabIndex = 218
        Me.GroupBox6.TabStop = False
        '
        'btn_ruta
        '
        Me.btn_ruta.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_ruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ruta.Location = New System.Drawing.Point(679, 31)
        Me.btn_ruta.Name = "btn_ruta"
        Me.btn_ruta.Size = New System.Drawing.Size(38, 23)
        Me.btn_ruta.TabIndex = 86
        Me.btn_ruta.Text = "..."
        Me.btn_ruta.UseVisualStyleBackColor = True
        '
        'txt_ruta
        '
        Me.txt_ruta.Location = New System.Drawing.Point(104, 32)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.ReadOnly = True
        Me.txt_ruta.Size = New System.Drawing.Size(569, 20)
        Me.txt_ruta.TabIndex = 83
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(8, 36)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(90, 13)
        Me.Label47.TabIndex = 82
        Me.Label47.Text = "Ruta de Archivo :"
        '
        'Label48
        '
        Me.Label48.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label48.BackColor = System.Drawing.Color.Navy
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(0, 6)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(723, 19)
        Me.Label48.TabIndex = 81
        Me.Label48.Text = "Datos de Incorporación"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.dgvdetalles_asientos)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 79)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(845, 433)
        Me.GroupBox7.TabIndex = 217
        Me.GroupBox7.TabStop = False
        '
        'dgvdetalles_asientos
        '
        Me.dgvdetalles_asientos.AllowUserToAddRows = False
        Me.dgvdetalles_asientos.AllowUserToDeleteRows = False
        Me.dgvdetalles_asientos.AllowUserToResizeColumns = False
        Me.dgvdetalles_asientos.AllowUserToResizeRows = False
        Me.dgvdetalles_asientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdetalles_asientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles_asientos.Location = New System.Drawing.Point(11, 18)
        Me.dgvdetalles_asientos.Name = "dgvdetalles_asientos"
        Me.dgvdetalles_asientos.ReadOnly = True
        Me.dgvdetalles_asientos.Size = New System.Drawing.Size(824, 403)
        Me.dgvdetalles_asientos.TabIndex = 0
        '
        'frm_CO_LT_ListaAsientosVarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1221, 621)
        Me.Controls.Add(Me.pnl_importar_asientos)
        Me.Controls.Add(Me.pnl_opt_cierre)
        Me.Controls.Add(Me.btn_remplaza_finalizar)
        Me.Controls.Add(Me.dgv_asientos)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_LT_ListaAsientosVarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asientos Contables Varios"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dgv_asientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalles.ResumeLayout(False)
        Me.gbDetalles.PerformLayout()
        Me.pnlDetalles.ResumeLayout(False)
        CType(Me.dgvDetalleAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gb_detalle_doc.ResumeLayout(False)
        Me.gb_detalle_doc.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_ref.ResumeLayout(False)
        Me.gb_ref.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCabecera.ResumeLayout(False)
        Me.gbCabecera.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFinalizarCompra.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.pnl_opt_cierre.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.pnl_importar_asientos.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.dgvdetalles_asientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tool_nuevo As System.Windows.Forms.ToolStripButton
    Private WithEvents tool_editar As System.Windows.Forms.ToolStripButton
    Private WithEvents tool_eliminar As System.Windows.Forms.ToolStripButton
    Private WithEvents tool_anular As System.Windows.Forms.ToolStripButton
    Private WithEvents tool_imprimir As System.Windows.Forms.ToolStripButton
    Private WithEvents tool_salir As System.Windows.Forms.ToolStripButton
    Private WithEvents tool_actualizar As System.Windows.Forms.ToolStripButton
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents cmb_ope As System.Windows.Forms.ComboBox
    Private WithEvents cmb_sub As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents cmb_meses As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_asientos As System.Windows.Forms.DataGridView
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_Año As System.Windows.Forms.DateTimePicker
    Private WithEvents Tool_reaperturar As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Private WithEvents Label40 As System.Windows.Forms.Label
    Private WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents pnlDetalles As System.Windows.Forms.Panel
    Friend WithEvents dgvDetalleAsiento As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Private WithEvents gb_detalle_doc As System.Windows.Forms.GroupBox
    Friend WithEvents txt_detraccion As System.Windows.Forms.TextBox
    Private WithEvents Label41 As System.Windows.Forms.Label
    Private WithEvents gb_ref As System.Windows.Forms.GroupBox
    Private WithEvents btn_aceptar_ref As System.Windows.Forms.Button
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents mtb_fec_ven_ref As System.Windows.Forms.MaskedTextBox
    Private WithEvents mtb_fec_emi_ref As System.Windows.Forms.MaskedTextBox
    Private WithEvents txt_ndoc_ref As System.Windows.Forms.TextBox
    Private WithEvents txt_tdoc_ref As System.Windows.Forms.TextBox
    Private WithEvents txt_sdoc_ref As System.Windows.Forms.TextBox
    Friend WithEvents mtb_haber As System.Windows.Forms.TextBox
    Friend WithEvents mtb_debe As System.Windows.Forms.TextBox
    Friend WithEvents txtCentroCosto As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Private WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Private WithEvents txtTipoDocAsiento As System.Windows.Forms.TextBox
    Private WithEvents txt_glosa_det As System.Windows.Forms.TextBox
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents btn_ref As System.Windows.Forms.Button
    Private WithEvents btn_can As System.Windows.Forms.Button
    Private WithEvents chk_inafecto As System.Windows.Forms.CheckBox
    Private WithEvents btn_ok As System.Windows.Forms.Button
    Private WithEvents cmb_mp As System.Windows.Forms.ComboBox
    Private WithEvents cmb_cc As System.Windows.Forms.ComboBox
    Private WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Private WithEvents txt_des_cta As System.Windows.Forms.TextBox
    Private WithEvents txt_num As System.Windows.Forms.TextBox
    Private WithEvents txt_ser As System.Windows.Forms.TextBox
    Private WithEvents txt_des_ane As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_ane As System.Windows.Forms.TextBox
    Private WithEvents mtb_fec_ven As System.Windows.Forms.MaskedTextBox
    Private WithEvents mtb_fec_emi As System.Windows.Forms.MaskedTextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents mtb_tc As System.Windows.Forms.TextBox
    Private WithEvents txt_d2 As System.Windows.Forms.TextBox
    Private WithEvents txt_d1 As System.Windows.Forms.TextBox
    Private WithEvents mtb_dif As System.Windows.Forms.MaskedTextBox
    Private WithEvents mtb_tot_d As System.Windows.Forms.MaskedTextBox
    Private WithEvents mtb_tot_h As System.Windows.Forms.MaskedTextBox
    Private WithEvents gbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFechaDocRef As System.Windows.Forms.DateTimePicker
    Private WithEvents Label28 As System.Windows.Forms.Label
    Private WithEvents txtTipoDocRef As System.Windows.Forms.TextBox
    Private WithEvents txtSerieDocRef As System.Windows.Forms.TextBox
    Private WithEvents txtNumDocRef As System.Windows.Forms.TextBox
    Private WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Private WithEvents txtMontoDoc As System.Windows.Forms.TextBox
    Private WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents txtMontoIgv As System.Windows.Forms.TextBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Private WithEvents lbltasa As System.Windows.Forms.Label
    Private WithEvents txtdescripcionDestino As System.Windows.Forms.TextBox
    Private WithEvents txtTasa As System.Windows.Forms.TextBox
    Private WithEvents txtDestino As System.Windows.Forms.TextBox
    Private WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents Label37 As System.Windows.Forms.Label
    Private WithEvents txtdetraccion As System.Windows.Forms.TextBox
    Private WithEvents Label35 As System.Windows.Forms.Label
    Private WithEvents txtPorc_Detrac As System.Windows.Forms.TextBox
    Private WithEvents Label36 As System.Windows.Forms.Label
    Private WithEvents txt_ISC As System.Windows.Forms.TextBox
    Private WithEvents Label33 As System.Windows.Forms.Label
    Private WithEvents txtPorc_ISC As System.Windows.Forms.TextBox
    Private WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents chkdua As System.Windows.Forms.CheckBox
    Private WithEvents txtGlosaTransaccion As System.Windows.Forms.TextBox
    Private WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents dtpOtraFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents Label31 As System.Windows.Forms.Label
    Private WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Private WithEvents Label30 As System.Windows.Forms.Label
    Private WithEvents txtNumeroDoc As System.Windows.Forms.TextBox
    Private WithEvents txtSerieDoc As System.Windows.Forms.TextBox
    Private WithEvents txtTipoDoc As System.Windows.Forms.TextBox
    Private WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVencimientoDoc As System.Windows.Forms.DateTimePicker
    Private WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDoc As System.Windows.Forms.DateTimePicker
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents txtdescripciontercero As System.Windows.Forms.TextBox
    Private WithEvents txtcodigoRuc As System.Windows.Forms.TextBox
    Private WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_PLE As System.Windows.Forms.DateTimePicker
    Private WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtp_fec_vou As System.Windows.Forms.DateTimePicker
    Private WithEvents txt_idcab As System.Windows.Forms.TextBox
    Private WithEvents btn_nuevo As System.Windows.Forms.Button
    Private WithEvents txt_glosa As System.Windows.Forms.TextBox
    Private WithEvents txt_num_vou As System.Windows.Forms.TextBox
    Private WithEvents cmb_sub_detalle As System.Windows.Forms.ComboBox
    Private WithEvents cmb_ope_detalle As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents Label42 As System.Windows.Forms.Label
    Private WithEvents Label43 As System.Windows.Forms.Label
    Private WithEvents Label44 As System.Windows.Forms.Label
    Private WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlFinalizarCompra As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Private WithEvents mtb_dif_dolares As System.Windows.Forms.MaskedTextBox
    Private WithEvents mtb_tot_d_dolares As System.Windows.Forms.MaskedTextBox
    Private WithEvents mtb_tot_h_dolares As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_remplaza_finalizar As System.Windows.Forms.Button
    Friend WithEvents pnl_opt_cierre As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton17 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton16 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton15 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton14 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents btn_cancelar_opt_cierre As System.Windows.Forms.Button
    Private WithEvents btn_aceptar_opt_cierre As System.Windows.Forms.Button
    Friend WithEvents pnl_importar_asientos As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ruta As System.Windows.Forms.Button
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdetalles_asientos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_importar_asientos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar_importacion As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar_importacion As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Private WithEvents txt_cen_cos As System.Windows.Forms.TextBox
    Private WithEvents txt_cen_cos_des As System.Windows.Forms.TextBox
    Private WithEvents Label39 As System.Windows.Forms.Label
End Class
