<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_Articulo
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_Articulo))
        Me.tc_articulo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optproductosgranel = New System.Windows.Forms.RadioButton()
        Me.optmuestramedica = New System.Windows.Forms.RadioButton()
        Me.opttodos = New System.Windows.Forms.RadioButton()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbopart_Type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblbuscar = New System.Windows.Forms.Label()
        Me.txtbuscarArticulo = New System.Windows.Forms.TextBox()
        Me.cboLine = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboFamily = New System.Windows.Forms.ComboBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgv_articulos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ID_FAB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_FAMILY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SERIES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_IS_STOCKED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_IS_LOT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_VAT_POR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_IS_VAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_AII = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ACCOUNT_INV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ACCOUNT_PAY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ISCPOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_TIPOISC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LINEA_MEDICA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_TYPE_PART = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_TIPO_ARTICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRESS_COMERCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REG_SANITARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.txt_tipo_origen_desc = New System.Windows.Forms.TextBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_tipo_origen = New System.Windows.Forms.TextBox()
        Me.cmb_estado_mat_empaque = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtunidadrefdesc = New System.Windows.Forms.TextBox()
        Me.txtunidaddesc = New System.Windows.Forms.TextBox()
        Me.cbo_clase_terapeutica = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescripcionClaseArt = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.txtPartidaArancelaria = New System.Windows.Forms.TextBox()
        Me.txtcodigoClaseArt = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GBmuestraMedica = New System.Windows.Forms.GroupBox()
        Me.btnproductopiloto = New System.Windows.Forms.Button()
        Me.btnMuestraGranel = New System.Windows.Forms.Button()
        Me.btnMuestraMedica = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbServicio = New System.Windows.Forms.RadioButton()
        Me.rbLibre = New System.Windows.Forms.RadioButton()
        Me.rbStockLote = New System.Windows.Forms.RadioButton()
        Me.rbStockSerie = New System.Windows.Forms.RadioButton()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtUnidMedRef = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPresComercial = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtdecComercial = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPresMMedica = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPresentacion = New System.Windows.Forms.TextBox()
        Me.lblTipoArticulo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txttipoArticulo = New System.Windows.Forms.TextBox()
        Me.txt_linea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_linea = New System.Windows.Forms.Label()
        Me.lbl_familia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_cod_fab = New System.Windows.Forms.TextBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.txt_idfamilia = New System.Windows.Forms.TextBox()
        Me.txt_um = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gb_datos_logisticos = New System.Windows.Forms.GroupBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.txt_stock_maximo = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.txt_punto_pedido = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txt_stock_minimo = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txt_11 = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txt_10 = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txt_9 = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txt_8 = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txt_7 = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txt_6 = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txt_5 = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txt_4 = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txt_3 = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txt_2 = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_cod_articulo = New System.Windows.Forms.TextBox()
        Me.checkLineas = New System.Windows.Forms.CheckBox()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.col_img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcompra = New System.Windows.Forms.Label()
        Me.txtCuentaCompra = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtCuentaInventario = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtcuentaVenta = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txt_des_lina_produccion = New System.Windows.Forms.TextBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_linea_produccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcapacidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdescripcionpres = New System.Windows.Forms.TextBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.txtcodigopres = New System.Windows.Forms.TextBox()
        Me.TXTPRODUCCIONDESC = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.txtProduccion = New System.Windows.Forms.TextBox()
        Me.chkProduccion = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chklstLineas = New System.Windows.Forms.CheckedListBox()
        Me.pb_img = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.gb_tipo_prod_controlado = New System.Windows.Forms.GroupBox()
        Me.cbo_tipo_prod_controlado = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.chk_prod_controlado = New System.Windows.Forms.CheckBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txt_cod_articulo_dos = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.dtp_fec_vcto_norma_tec = New System.Windows.Forms.DateTimePicker()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.dtp_fec_emi_norma_tecnica = New System.Windows.Forms.DateTimePicker()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_numero_norma_tec = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.DTP_FEC_VCTO_REG_SANIT = New System.Windows.Forms.DateTimePicker()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.DTP_FEC_EMI_REG_SANIT = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txt_num_regsanit = New System.Windows.Forms.TextBox()
        Me.btn_add_regsanit = New System.Windows.Forms.Button()
        Me.btn_del_regsanit = New System.Windows.Forms.Button()
        Me.dgv_incripciones_regsanit = New System.Windows.Forms.DataGridView()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.pnl_pt = New System.Windows.Forms.Panel()
        Me.cbo_estado_rs = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_vcto_reg_sanit = New System.Windows.Forms.DateTimePicker()
        Me.txt_vigencia_lot = New System.Windows.Forms.TextBox()
        Me.txt_vig_reg_sanit = New System.Windows.Forms.TextBox()
        Me.txtpesoArticulo = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClase = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txt_nro_reg_sanit = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtTalla = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbo_norma_tecnica = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cbo_condicion_venta = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbo_forma_farmaceutica = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.gb_principios_activos = New System.Windows.Forms.GroupBox()
        Me.txt_des_principio_activo = New System.Windows.Forms.TextBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_principio_activo = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_precio = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Precio_Mat_Empaque = New System.Windows.Forms.ToolStripButton()
        Me.btn_Descuentos = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.pnlTipoProducto = New System.Windows.Forms.Panel()
        Me.cboTipoPart = New System.Windows.Forms.ComboBox()
        Me.pnlreporte = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cboFamilia = New System.Windows.Forms.ComboBox()
        Me.txtcodigo2 = New System.Windows.Forms.TextBox()
        Me.txtdescripcion2 = New System.Windows.Forms.Label()
        Me.txtcodigo1 = New System.Windows.Forms.TextBox()
        Me.txtdescripcion1 = New System.Windows.Forms.Label()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rblinea = New System.Windows.Forms.RadioButton()
        Me.rbtipoarticulo = New System.Windows.Forms.RadioButton()
        Me.rbfamilia = New System.Windows.Forms.RadioButton()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.rbcodigo = New System.Windows.Forms.RadioButton()
        Me.btn_Adicionales = New System.Windows.Forms.ToolStripButton()
        Me.tc_articulo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBmuestraMedica.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gb_datos_logisticos.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.gb_tipo_prod_controlado.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgv_incripciones_regsanit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_pt.SuspendLayout()
        Me.gb_principios_activos.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsOpciones.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlTipoProducto.SuspendLayout()
        Me.pnlreporte.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_articulo
        '
        Me.tc_articulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_articulo.Controls.Add(Me.TabPage1)
        Me.tc_articulo.Controls.Add(Me.TabPage2)
        Me.tc_articulo.Controls.Add(Me.TabPage3)
        Me.tc_articulo.Controls.Add(Me.TabPage4)
        Me.tc_articulo.Location = New System.Drawing.Point(12, 30)
        Me.tc_articulo.Name = "tc_articulo"
        Me.tc_articulo.SelectedIndex = 0
        Me.tc_articulo.Size = New System.Drawing.Size(869, 551)
        Me.tc_articulo.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.lblcantidad)
        Me.TabPage1.Controls.Add(Me.dgv_articulos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(861, 525)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Articulos"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.optproductosgranel)
        Me.GroupBox5.Controls.Add(Me.optmuestramedica)
        Me.GroupBox5.Controls.Add(Me.opttodos)
        Me.GroupBox5.Controls.Add(Me.Label40)
        Me.GroupBox5.Location = New System.Drawing.Point(23, 73)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(812, 47)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'optproductosgranel
        '
        Me.optproductosgranel.AutoSize = True
        Me.optproductosgranel.ForeColor = System.Drawing.Color.Navy
        Me.optproductosgranel.Location = New System.Drawing.Point(545, 19)
        Me.optproductosgranel.Name = "optproductosgranel"
        Me.optproductosgranel.Size = New System.Drawing.Size(116, 17)
        Me.optproductosgranel.TabIndex = 12
        Me.optproductosgranel.Text = "Productos a Granel"
        Me.optproductosgranel.UseVisualStyleBackColor = True
        '
        'optmuestramedica
        '
        Me.optmuestramedica.AutoSize = True
        Me.optmuestramedica.ForeColor = System.Drawing.Color.Navy
        Me.optmuestramedica.Location = New System.Drawing.Point(287, 19)
        Me.optmuestramedica.Name = "optmuestramedica"
        Me.optmuestramedica.Size = New System.Drawing.Size(101, 17)
        Me.optmuestramedica.TabIndex = 11
        Me.optmuestramedica.Text = "Muestra Medica"
        Me.optmuestramedica.UseVisualStyleBackColor = True
        '
        'opttodos
        '
        Me.opttodos.AutoSize = True
        Me.opttodos.Checked = True
        Me.opttodos.ForeColor = System.Drawing.Color.Navy
        Me.opttodos.Location = New System.Drawing.Point(47, 19)
        Me.opttodos.Name = "opttodos"
        Me.opttodos.Size = New System.Drawing.Size(121, 17)
        Me.opttodos.TabIndex = 10
        Me.opttodos.TabStop = True
        Me.opttodos.Text = "Todos los productos"
        Me.opttodos.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(515, 72)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(10, 13)
        Me.Label40.TabIndex = 9
        Me.Label40.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.cbopart_Type)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblbuscar)
        Me.GroupBox3.Controls.Add(Me.txtbuscarArticulo)
        Me.GroupBox3.Controls.Add(Me.cboLine)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.cboFamily)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(812, 70)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'cbopart_Type
        '
        Me.cbopart_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopart_Type.FormattingEnabled = True
        Me.cbopart_Type.Location = New System.Drawing.Point(45, 14)
        Me.cbopart_Type.Name = "cbopart_Type"
        Me.cbopart_Type.Size = New System.Drawing.Size(231, 21)
        Me.cbopart_Type.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(2, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Buscar"
        '
        'lblbuscar
        '
        Me.lblbuscar.AutoSize = True
        Me.lblbuscar.Location = New System.Drawing.Point(515, 72)
        Me.lblbuscar.Name = "lblbuscar"
        Me.lblbuscar.Size = New System.Drawing.Size(10, 13)
        Me.lblbuscar.TabIndex = 9
        Me.lblbuscar.Text = "."
        '
        'txtbuscarArticulo
        '
        Me.txtbuscarArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtbuscarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscarArticulo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbuscarArticulo.Location = New System.Drawing.Point(45, 41)
        Me.txtbuscarArticulo.Name = "txtbuscarArticulo"
        Me.txtbuscarArticulo.Size = New System.Drawing.Size(231, 20)
        Me.txtbuscarArticulo.TabIndex = 2
        '
        'cboLine
        '
        Me.cboLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLine.FormattingEnabled = True
        Me.cboLine.Location = New System.Drawing.Point(323, 41)
        Me.cboLine.Name = "cboLine"
        Me.cboLine.Size = New System.Drawing.Size(369, 21)
        Me.cboLine.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(14, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Tipo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(284, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Linea"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(284, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Familia"
        '
        'cboFamily
        '
        Me.cboFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFamily.FormattingEnabled = True
        Me.cboFamily.Location = New System.Drawing.Point(323, 14)
        Me.cboFamily.Name = "cboFamily"
        Me.cboFamily.Size = New System.Drawing.Size(370, 21)
        Me.cboFamily.TabIndex = 6
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblcantidad.Location = New System.Drawing.Point(20, 503)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(45, 13)
        Me.lblcantidad.TabIndex = 10
        Me.lblcantidad.Text = "Label20"
        '
        'dgv_articulos
        '
        Me.dgv_articulos.AllowUserToAddRows = False
        Me.dgv_articulos.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_articulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_articulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.descripcion, Me.col_ID_FAB, Me.col_FAMILY, Me.col_UOM, Me.col_SERIES, Me.col_IS_STOCKED, Me.col_IS_LOT, Me.col_VAT_POR, Me.col_IS_VAT, Me.col_AII, Me.col_ACCOUNT_INV, Me.col_ACCOUNT_PAY, Me.col_ISCPOR, Me.col_TIPOISC, Me.col_model, Me.col_STATUS, Me.col_LINEA_MEDICA, Me.col_TYPE_PART, Me.col_TIPO_ARTICULO, Me.PRESS_COMERCIAL, Me.REG_SANITARIO})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_articulos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_articulos.Location = New System.Drawing.Point(23, 77)
        Me.dgv_articulos.Name = "dgv_articulos"
        Me.dgv_articulos.ReadOnly = True
        Me.dgv_articulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_articulos.Size = New System.Drawing.Size(812, 423)
        Me.dgv_articulos.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 40.60914!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "Descripcion"
        Me.descripcion.FillWeight = 159.3909!
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'col_ID_FAB
        '
        Me.col_ID_FAB.DataPropertyName = "ID_FAB"
        Me.col_ID_FAB.HeaderText = "ID_FAB"
        Me.col_ID_FAB.Name = "col_ID_FAB"
        Me.col_ID_FAB.ReadOnly = True
        Me.col_ID_FAB.Visible = False
        '
        'col_FAMILY
        '
        Me.col_FAMILY.DataPropertyName = "FAMILY"
        Me.col_FAMILY.HeaderText = "FAMILY"
        Me.col_FAMILY.Name = "col_FAMILY"
        Me.col_FAMILY.ReadOnly = True
        Me.col_FAMILY.Visible = False
        '
        'col_UOM
        '
        Me.col_UOM.DataPropertyName = "UNIT_OF_MEASUREMENT"
        Me.col_UOM.HeaderText = "UOM"
        Me.col_UOM.Name = "col_UOM"
        Me.col_UOM.ReadOnly = True
        Me.col_UOM.Visible = False
        '
        'col_SERIES
        '
        Me.col_SERIES.DataPropertyName = "SERIES"
        Me.col_SERIES.HeaderText = "SERIES"
        Me.col_SERIES.Name = "col_SERIES"
        Me.col_SERIES.ReadOnly = True
        Me.col_SERIES.Visible = False
        '
        'col_IS_STOCKED
        '
        Me.col_IS_STOCKED.DataPropertyName = "IS_STOCKED"
        Me.col_IS_STOCKED.HeaderText = "IS_STOCKED"
        Me.col_IS_STOCKED.Name = "col_IS_STOCKED"
        Me.col_IS_STOCKED.ReadOnly = True
        Me.col_IS_STOCKED.Visible = False
        '
        'col_IS_LOT
        '
        Me.col_IS_LOT.DataPropertyName = "IS_LOT"
        Me.col_IS_LOT.HeaderText = "IS_LOT"
        Me.col_IS_LOT.Name = "col_IS_LOT"
        Me.col_IS_LOT.ReadOnly = True
        Me.col_IS_LOT.Visible = False
        '
        'col_VAT_POR
        '
        Me.col_VAT_POR.DataPropertyName = "VAT_POR"
        Me.col_VAT_POR.HeaderText = "VAT_POR"
        Me.col_VAT_POR.Name = "col_VAT_POR"
        Me.col_VAT_POR.ReadOnly = True
        Me.col_VAT_POR.Visible = False
        '
        'col_IS_VAT
        '
        Me.col_IS_VAT.DataPropertyName = "IS_VAT"
        Me.col_IS_VAT.HeaderText = "IS_VAT"
        Me.col_IS_VAT.Name = "col_IS_VAT"
        Me.col_IS_VAT.ReadOnly = True
        Me.col_IS_VAT.Visible = False
        '
        'col_AII
        '
        Me.col_AII.DataPropertyName = "ACCOUNT_INTERNAL_ID"
        Me.col_AII.HeaderText = "AII"
        Me.col_AII.Name = "col_AII"
        Me.col_AII.ReadOnly = True
        Me.col_AII.Visible = False
        '
        'col_ACCOUNT_INV
        '
        Me.col_ACCOUNT_INV.DataPropertyName = "ACCOUNT_INV"
        Me.col_ACCOUNT_INV.HeaderText = "ACCOUNT_INV"
        Me.col_ACCOUNT_INV.Name = "col_ACCOUNT_INV"
        Me.col_ACCOUNT_INV.ReadOnly = True
        Me.col_ACCOUNT_INV.Visible = False
        '
        'col_ACCOUNT_PAY
        '
        Me.col_ACCOUNT_PAY.DataPropertyName = "ACCOUNT_PAY"
        Me.col_ACCOUNT_PAY.HeaderText = "ACCOUNT_PAY"
        Me.col_ACCOUNT_PAY.Name = "col_ACCOUNT_PAY"
        Me.col_ACCOUNT_PAY.ReadOnly = True
        Me.col_ACCOUNT_PAY.Visible = False
        '
        'col_ISCPOR
        '
        Me.col_ISCPOR.DataPropertyName = "ISCPOR"
        Me.col_ISCPOR.HeaderText = "ISCPOR"
        Me.col_ISCPOR.Name = "col_ISCPOR"
        Me.col_ISCPOR.ReadOnly = True
        Me.col_ISCPOR.Visible = False
        '
        'col_TIPOISC
        '
        Me.col_TIPOISC.DataPropertyName = "TIPOISC"
        Me.col_TIPOISC.HeaderText = "TIPOISC"
        Me.col_TIPOISC.Name = "col_TIPOISC"
        Me.col_TIPOISC.ReadOnly = True
        Me.col_TIPOISC.Visible = False
        '
        'col_model
        '
        Me.col_model.DataPropertyName = "MODEL"
        Me.col_model.HeaderText = "Model"
        Me.col_model.Name = "col_model"
        Me.col_model.ReadOnly = True
        Me.col_model.Visible = False
        '
        'col_STATUS
        '
        Me.col_STATUS.DataPropertyName = "STATUS"
        Me.col_STATUS.HeaderText = "STATUS"
        Me.col_STATUS.Name = "col_STATUS"
        Me.col_STATUS.ReadOnly = True
        Me.col_STATUS.Visible = False
        '
        'col_LINEA_MEDICA
        '
        Me.col_LINEA_MEDICA.DataPropertyName = "LINEA_MEDICA"
        Me.col_LINEA_MEDICA.HeaderText = "LINEA_MEDICA"
        Me.col_LINEA_MEDICA.Name = "col_LINEA_MEDICA"
        Me.col_LINEA_MEDICA.ReadOnly = True
        Me.col_LINEA_MEDICA.Visible = False
        '
        'col_TYPE_PART
        '
        Me.col_TYPE_PART.DataPropertyName = "TYPE_PART"
        Me.col_TYPE_PART.HeaderText = "TYPE_PART"
        Me.col_TYPE_PART.Name = "col_TYPE_PART"
        Me.col_TYPE_PART.ReadOnly = True
        Me.col_TYPE_PART.Visible = False
        '
        'col_TIPO_ARTICULO
        '
        Me.col_TIPO_ARTICULO.DataPropertyName = "TIPO_ARTICULO"
        Me.col_TIPO_ARTICULO.HeaderText = "TIPO_ARTICULO"
        Me.col_TIPO_ARTICULO.Name = "col_TIPO_ARTICULO"
        Me.col_TIPO_ARTICULO.ReadOnly = True
        Me.col_TIPO_ARTICULO.Visible = False
        '
        'PRESS_COMERCIAL
        '
        Me.PRESS_COMERCIAL.HeaderText = "Presentación"
        Me.PRESS_COMERCIAL.Name = "PRESS_COMERCIAL"
        Me.PRESS_COMERCIAL.ReadOnly = True
        Me.PRESS_COMERCIAL.Visible = False
        '
        'REG_SANITARIO
        '
        Me.REG_SANITARIO.HeaderText = "Reg. Sanitario"
        Me.REG_SANITARIO.Name = "REG_SANITARIO"
        Me.REG_SANITARIO.ReadOnly = True
        Me.REG_SANITARIO.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(861, 525)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.txt_tipo_origen_desc)
        Me.gb_data.Controls.Add(Me.PictureBox13)
        Me.gb_data.Controls.Add(Me.Label57)
        Me.gb_data.Controls.Add(Me.txt_tipo_origen)
        Me.gb_data.Controls.Add(Me.cmb_estado_mat_empaque)
        Me.gb_data.Controls.Add(Me.Label56)
        Me.gb_data.Controls.Add(Me.txtunidadrefdesc)
        Me.gb_data.Controls.Add(Me.txtunidaddesc)
        Me.gb_data.Controls.Add(Me.cbo_clase_terapeutica)
        Me.gb_data.Controls.Add(Me.Label9)
        Me.gb_data.Controls.Add(Me.txtDescripcionClaseArt)
        Me.gb_data.Controls.Add(Me.PictureBox6)
        Me.gb_data.Controls.Add(Me.Label33)
        Me.gb_data.Controls.Add(Me.CboEstado)
        Me.gb_data.Controls.Add(Me.txtPartidaArancelaria)
        Me.gb_data.Controls.Add(Me.txtcodigoClaseArt)
        Me.gb_data.Controls.Add(Me.Label35)
        Me.gb_data.Controls.Add(Me.PictureBox5)
        Me.gb_data.Controls.Add(Me.Label34)
        Me.gb_data.Controls.Add(Me.PictureBox4)
        Me.gb_data.Controls.Add(Me.PictureBox3)
        Me.gb_data.Controls.Add(Me.PictureBox2)
        Me.gb_data.Controls.Add(Me.PictureBox1)
        Me.gb_data.Controls.Add(Me.GBmuestraMedica)
        Me.gb_data.Controls.Add(Me.GroupBox1)
        Me.gb_data.Controls.Add(Me.cboTipoProducto)
        Me.gb_data.Controls.Add(Me.Label37)
        Me.gb_data.Controls.Add(Me.Label27)
        Me.gb_data.Controls.Add(Me.TextBox8)
        Me.gb_data.Controls.Add(Me.Label26)
        Me.gb_data.Controls.Add(Me.txtUnidMedRef)
        Me.gb_data.Controls.Add(Me.Label24)
        Me.gb_data.Controls.Add(Me.txtPresComercial)
        Me.gb_data.Controls.Add(Me.Label23)
        Me.gb_data.Controls.Add(Me.txtdecComercial)
        Me.gb_data.Controls.Add(Me.Label22)
        Me.gb_data.Controls.Add(Me.txtPresMMedica)
        Me.gb_data.Controls.Add(Me.Label21)
        Me.gb_data.Controls.Add(Me.txtPresentacion)
        Me.gb_data.Controls.Add(Me.lblTipoArticulo)
        Me.gb_data.Controls.Add(Me.Label20)
        Me.gb_data.Controls.Add(Me.txttipoArticulo)
        Me.gb_data.Controls.Add(Me.txt_linea)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.Label2)
        Me.gb_data.Controls.Add(Me.Label6)
        Me.gb_data.Controls.Add(Me.Label15)
        Me.gb_data.Controls.Add(Me.Label16)
        Me.gb_data.Controls.Add(Me.lbl_linea)
        Me.gb_data.Controls.Add(Me.lbl_familia)
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Controls.Add(Me.txt_id)
        Me.gb_data.Controls.Add(Me.txt_cod_fab)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.Controls.Add(Me.txt_idfamilia)
        Me.gb_data.Controls.Add(Me.txt_um)
        Me.gb_data.ForeColor = System.Drawing.Color.Navy
        Me.gb_data.Location = New System.Drawing.Point(17, 2)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(730, 516)
        Me.gb_data.TabIndex = 0
        Me.gb_data.TabStop = False
        '
        'txt_tipo_origen_desc
        '
        Me.txt_tipo_origen_desc.BackColor = System.Drawing.Color.White
        Me.txt_tipo_origen_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipo_origen_desc.Enabled = False
        Me.txt_tipo_origen_desc.Location = New System.Drawing.Point(263, 282)
        Me.txt_tipo_origen_desc.Name = "txt_tipo_origen_desc"
        Me.txt_tipo_origen_desc.ReadOnly = True
        Me.txt_tipo_origen_desc.Size = New System.Drawing.Size(446, 20)
        Me.txt_tipo_origen_desc.TabIndex = 145
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(238, 282)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox13.TabIndex = 144
        Me.PictureBox13.TabStop = False
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(101, 284)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(62, 13)
        Me.Label57.TabIndex = 142
        Me.Label57.Text = "Tipo Origen"
        '
        'txt_tipo_origen
        '
        Me.txt_tipo_origen.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_tipo_origen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipo_origen.Location = New System.Drawing.Point(166, 282)
        Me.txt_tipo_origen.Name = "txt_tipo_origen"
        Me.txt_tipo_origen.ReadOnly = True
        Me.txt_tipo_origen.Size = New System.Drawing.Size(69, 20)
        Me.txt_tipo_origen.TabIndex = 143
        '
        'cmb_estado_mat_empaque
        '
        Me.cmb_estado_mat_empaque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado_mat_empaque.FormattingEnabled = True
        Me.cmb_estado_mat_empaque.Items.AddRange(New Object() {"Activo.", "Inactivo."})
        Me.cmb_estado_mat_empaque.Location = New System.Drawing.Point(580, 440)
        Me.cmb_estado_mat_empaque.Name = "cmb_estado_mat_empaque"
        Me.cmb_estado_mat_empaque.Size = New System.Drawing.Size(129, 21)
        Me.cmb_estado_mat_empaque.TabIndex = 140
        Me.cmb_estado_mat_empaque.Visible = False
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(462, 443)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(112, 13)
        Me.Label56.TabIndex = 141
        Me.Label56.Text = "Estado Mat. Empaque"
        Me.Label56.Visible = False
        '
        'txtunidadrefdesc
        '
        Me.txtunidadrefdesc.BackColor = System.Drawing.Color.White
        Me.txtunidadrefdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadrefdesc.Enabled = False
        Me.txtunidadrefdesc.Location = New System.Drawing.Point(263, 467)
        Me.txtunidadrefdesc.Name = "txtunidadrefdesc"
        Me.txtunidadrefdesc.ReadOnly = True
        Me.txtunidadrefdesc.Size = New System.Drawing.Size(446, 20)
        Me.txtunidadrefdesc.TabIndex = 139
        Me.txtunidadrefdesc.Visible = False
        '
        'txtunidaddesc
        '
        Me.txtunidaddesc.BackColor = System.Drawing.Color.White
        Me.txtunidaddesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidaddesc.Enabled = False
        Me.txtunidaddesc.Location = New System.Drawing.Point(263, 255)
        Me.txtunidaddesc.Name = "txtunidaddesc"
        Me.txtunidaddesc.ReadOnly = True
        Me.txtunidaddesc.Size = New System.Drawing.Size(446, 20)
        Me.txtunidaddesc.TabIndex = 138
        '
        'cbo_clase_terapeutica
        '
        Me.cbo_clase_terapeutica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_clase_terapeutica.Enabled = False
        Me.cbo_clase_terapeutica.FormattingEnabled = True
        Me.cbo_clase_terapeutica.Items.AddRange(New Object() {"(Seleccione)", "Productos Marca.", "Productos Genericos."})
        Me.cbo_clase_terapeutica.Location = New System.Drawing.Point(166, 464)
        Me.cbo_clase_terapeutica.Name = "cbo_clase_terapeutica"
        Me.cbo_clase_terapeutica.Size = New System.Drawing.Size(229, 21)
        Me.cbo_clase_terapeutica.TabIndex = 137
        Me.cbo_clase_terapeutica.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(74, 467)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "&Clase terapeutica"
        Me.Label9.Visible = False
        '
        'txtDescripcionClaseArt
        '
        Me.txtDescripcionClaseArt.BackColor = System.Drawing.Color.White
        Me.txtDescripcionClaseArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionClaseArt.Enabled = False
        Me.txtDescripcionClaseArt.Location = New System.Drawing.Point(263, 229)
        Me.txtDescripcionClaseArt.Name = "txtDescripcionClaseArt"
        Me.txtDescripcionClaseArt.ReadOnly = True
        Me.txtDescripcionClaseArt.Size = New System.Drawing.Size(446, 20)
        Me.txtDescripcionClaseArt.TabIndex = 126
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(238, 230)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 125
        Me.PictureBox6.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(77, 231)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(86, 13)
        Me.Label33.TabIndex = 123
        Me.Label33.Text = "Clase de Articulo"
        '
        'CboEstado
        '
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Items.AddRange(New Object() {"Activo.", "Inactivo."})
        Me.CboEstado.Location = New System.Drawing.Point(166, 361)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(229, 21)
        Me.CboEstado.TabIndex = 22
        '
        'txtPartidaArancelaria
        '
        Me.txtPartidaArancelaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartidaArancelaria.Location = New System.Drawing.Point(166, 335)
        Me.txtPartidaArancelaria.Name = "txtPartidaArancelaria"
        Me.txtPartidaArancelaria.Size = New System.Drawing.Size(543, 20)
        Me.txtPartidaArancelaria.TabIndex = 21
        '
        'txtcodigoClaseArt
        '
        Me.txtcodigoClaseArt.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoClaseArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoClaseArt.Location = New System.Drawing.Point(166, 229)
        Me.txtcodigoClaseArt.Name = "txtcodigoClaseArt"
        Me.txtcodigoClaseArt.ReadOnly = True
        Me.txtcodigoClaseArt.Size = New System.Drawing.Size(68, 20)
        Me.txtcodigoClaseArt.TabIndex = 10
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(67, 337)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 13)
        Me.Label35.TabIndex = 42
        Me.Label35.Text = "Partida Arancelaria"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(238, 467)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox5.TabIndex = 122
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(123, 364)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(40, 13)
        Me.Label34.TabIndex = 44
        Me.Label34.Text = "Estado"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(238, 255)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 121
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(211, 99)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 120
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(211, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 119
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(211, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'GBmuestraMedica
        '
        Me.GBmuestraMedica.BackColor = System.Drawing.Color.White
        Me.GBmuestraMedica.Controls.Add(Me.btnproductopiloto)
        Me.GBmuestraMedica.Controls.Add(Me.btnMuestraGranel)
        Me.GBmuestraMedica.Controls.Add(Me.btnMuestraMedica)
        Me.GBmuestraMedica.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBmuestraMedica.ForeColor = System.Drawing.Color.Navy
        Me.GBmuestraMedica.Location = New System.Drawing.Point(573, 10)
        Me.GBmuestraMedica.Name = "GBmuestraMedica"
        Me.GBmuestraMedica.Size = New System.Drawing.Size(137, 110)
        Me.GBmuestraMedica.TabIndex = 55
        Me.GBmuestraMedica.TabStop = False
        Me.GBmuestraMedica.Text = "&Crear"
        Me.GBmuestraMedica.Visible = False
        '
        'btnproductopiloto
        '
        Me.btnproductopiloto.Enabled = False
        Me.btnproductopiloto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproductopiloto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproductopiloto.ForeColor = System.Drawing.Color.Blue
        Me.btnproductopiloto.Location = New System.Drawing.Point(7, 79)
        Me.btnproductopiloto.Name = "btnproductopiloto"
        Me.btnproductopiloto.Size = New System.Drawing.Size(122, 28)
        Me.btnproductopiloto.TabIndex = 109
        Me.btnproductopiloto.Text = "&Producto Piloto"
        Me.btnproductopiloto.UseVisualStyleBackColor = True
        '
        'btnMuestraGranel
        '
        Me.btnMuestraGranel.Enabled = False
        Me.btnMuestraGranel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMuestraGranel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMuestraGranel.ForeColor = System.Drawing.Color.Blue
        Me.btnMuestraGranel.Location = New System.Drawing.Point(7, 49)
        Me.btnMuestraGranel.Name = "btnMuestraGranel"
        Me.btnMuestraGranel.Size = New System.Drawing.Size(122, 28)
        Me.btnMuestraGranel.TabIndex = 108
        Me.btnMuestraGranel.Text = "&Producto a  Granel"
        Me.btnMuestraGranel.UseVisualStyleBackColor = True
        '
        'btnMuestraMedica
        '
        Me.btnMuestraMedica.Enabled = False
        Me.btnMuestraMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMuestraMedica.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMuestraMedica.ForeColor = System.Drawing.Color.Blue
        Me.btnMuestraMedica.Location = New System.Drawing.Point(7, 17)
        Me.btnMuestraMedica.Name = "btnMuestraMedica"
        Me.btnMuestraMedica.Size = New System.Drawing.Size(122, 28)
        Me.btnMuestraMedica.TabIndex = 107
        Me.btnMuestraMedica.Text = "&Muestra Medica"
        Me.btnMuestraMedica.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbServicio)
        Me.GroupBox1.Controls.Add(Me.rbLibre)
        Me.GroupBox1.Controls.Add(Me.rbStockLote)
        Me.GroupBox1.Controls.Add(Me.rbStockSerie)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(166, 390)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 43)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control de Stock"
        '
        'rbServicio
        '
        Me.rbServicio.AutoSize = True
        Me.rbServicio.Location = New System.Drawing.Point(287, 17)
        Me.rbServicio.Name = "rbServicio"
        Me.rbServicio.Size = New System.Drawing.Size(63, 17)
        Me.rbServicio.TabIndex = 26
        Me.rbServicio.Text = "Servicio"
        Me.rbServicio.UseVisualStyleBackColor = True
        '
        'rbLibre
        '
        Me.rbLibre.AutoSize = True
        Me.rbLibre.Location = New System.Drawing.Point(229, 17)
        Me.rbLibre.Name = "rbLibre"
        Me.rbLibre.Size = New System.Drawing.Size(48, 17)
        Me.rbLibre.TabIndex = 25
        Me.rbLibre.Text = "Libre"
        Me.rbLibre.UseVisualStyleBackColor = True
        '
        'rbStockLote
        '
        Me.rbStockLote.AutoSize = True
        Me.rbStockLote.Checked = True
        Me.rbStockLote.Location = New System.Drawing.Point(122, 17)
        Me.rbStockLote.Name = "rbStockLote"
        Me.rbStockLote.Size = New System.Drawing.Size(95, 17)
        Me.rbStockLote.TabIndex = 24
        Me.rbStockLote.TabStop = True
        Me.rbStockLote.Text = "Stock por Lote"
        Me.rbStockLote.UseVisualStyleBackColor = True
        '
        'rbStockSerie
        '
        Me.rbStockSerie.AutoSize = True
        Me.rbStockSerie.Location = New System.Drawing.Point(13, 17)
        Me.rbStockSerie.Name = "rbStockSerie"
        Me.rbStockSerie.Size = New System.Drawing.Size(98, 17)
        Me.rbStockSerie.TabIndex = 23
        Me.rbStockSerie.Text = "Stock por Serie"
        Me.rbStockSerie.UseVisualStyleBackColor = True
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoProducto.FormattingEnabled = True
        Me.cboTipoProducto.Items.AddRange(New Object() {"Productos Marca.", "Productos Genericos."})
        Me.cboTipoProducto.Location = New System.Drawing.Point(166, 491)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(229, 21)
        Me.cboTipoProducto.TabIndex = 24
        Me.cboTipoProducto.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(74, 494)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(89, 13)
        Me.Label37.TabIndex = 51
        Me.Label37.Text = "&Tipo de Producto"
        Me.Label37.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(124, 311)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(36, 13)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Grupo"
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(166, 309)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(543, 20)
        Me.TextBox8.TabIndex = 13
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(87, 469)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 13)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "&Uni. Med. Ref."
        Me.Label26.Visible = False
        '
        'txtUnidMedRef
        '
        Me.txtUnidMedRef.BackColor = System.Drawing.Color.Aquamarine
        Me.txtUnidMedRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidMedRef.Location = New System.Drawing.Point(166, 467)
        Me.txtUnidMedRef.Name = "txtUnidMedRef"
        Me.txtUnidMedRef.ReadOnly = True
        Me.txtUnidMedRef.Size = New System.Drawing.Size(69, 20)
        Me.txtUnidMedRef.TabIndex = 12
        Me.txtUnidMedRef.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(86, 205)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 13)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Pres Comercial"
        '
        'txtPresComercial
        '
        Me.txtPresComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPresComercial.Location = New System.Drawing.Point(166, 203)
        Me.txtPresComercial.Name = "txtPresComercial"
        Me.txtPresComercial.Size = New System.Drawing.Size(543, 20)
        Me.txtPresComercial.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(82, 180)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 13)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Desc Comercial"
        '
        'txtdecComercial
        '
        Me.txtdecComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdecComercial.Location = New System.Drawing.Point(166, 177)
        Me.txtdecComercial.Name = "txtdecComercial"
        Me.txtdecComercial.Size = New System.Drawing.Size(543, 20)
        Me.txtdecComercial.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 500)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(151, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "&Presentacion  Muestra Medica"
        Me.Label22.Visible = False
        '
        'txtPresMMedica
        '
        Me.txtPresMMedica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPresMMedica.Location = New System.Drawing.Point(166, 497)
        Me.txtPresMMedica.Name = "txtPresMMedica"
        Me.txtPresMMedica.Size = New System.Drawing.Size(543, 20)
        Me.txtPresMMedica.TabIndex = 7
        Me.txtPresMMedica.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(52, 154)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Presentacion Tecnica"
        '
        'txtPresentacion
        '
        Me.txtPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPresentacion.Location = New System.Drawing.Point(166, 151)
        Me.txtPresentacion.Name = "txtPresentacion"
        Me.txtPresentacion.Size = New System.Drawing.Size(543, 20)
        Me.txtPresentacion.TabIndex = 6
        '
        'lblTipoArticulo
        '
        Me.lblTipoArticulo.AutoSize = True
        Me.lblTipoArticulo.Location = New System.Drawing.Point(235, 51)
        Me.lblTipoArticulo.Name = "lblTipoArticulo"
        Me.lblTipoArticulo.Size = New System.Drawing.Size(16, 13)
        Me.lblTipoArticulo.TabIndex = 17
        Me.lblTipoArticulo.Text = "..."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(97, 51)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Tipo Articulo"
        '
        'txttipoArticulo
        '
        Me.txttipoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txttipoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipoArticulo.Location = New System.Drawing.Point(166, 47)
        Me.txttipoArticulo.Name = "txttipoArticulo"
        Me.txttipoArticulo.ReadOnly = True
        Me.txttipoArticulo.Size = New System.Drawing.Size(41, 20)
        Me.txttipoArticulo.TabIndex = 2
        '
        'txt_linea
        '
        Me.txt_linea.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_linea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_linea.Location = New System.Drawing.Point(166, 99)
        Me.txt_linea.Name = "txt_linea"
        Me.txt_linea.ReadOnly = True
        Me.txt_linea.Size = New System.Drawing.Size(41, 20)
        Me.txt_linea.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod. Alterno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Descripcion Tecnica"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(130, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Linea"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(124, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Familia"
        '
        'lbl_linea
        '
        Me.lbl_linea.AutoSize = True
        Me.lbl_linea.Location = New System.Drawing.Point(235, 102)
        Me.lbl_linea.Name = "lbl_linea"
        Me.lbl_linea.Size = New System.Drawing.Size(16, 13)
        Me.lbl_linea.TabIndex = 1
        Me.lbl_linea.Text = "..."
        '
        'lbl_familia
        '
        Me.lbl_familia.AutoSize = True
        Me.lbl_familia.Location = New System.Drawing.Point(235, 76)
        Me.lbl_familia.Name = "lbl_familia"
        Me.lbl_familia.Size = New System.Drawing.Size(16, 13)
        Me.lbl_familia.TabIndex = 1
        Me.lbl_familia.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Uni. Med."
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Location = New System.Drawing.Point(166, 22)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(80, 20)
        Me.txt_id.TabIndex = 0
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cod_fab
        '
        Me.txt_cod_fab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_fab.Location = New System.Drawing.Point(356, 21)
        Me.txt_cod_fab.Name = "txt_cod_fab"
        Me.txt_cod_fab.Size = New System.Drawing.Size(155, 20)
        Me.txt_cod_fab.TabIndex = 1
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(166, 125)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(543, 20)
        Me.txt_des.TabIndex = 5
        '
        'txt_idfamilia
        '
        Me.txt_idfamilia.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_idfamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idfamilia.Location = New System.Drawing.Point(166, 73)
        Me.txt_idfamilia.Name = "txt_idfamilia"
        Me.txt_idfamilia.ReadOnly = True
        Me.txt_idfamilia.Size = New System.Drawing.Size(41, 20)
        Me.txt_idfamilia.TabIndex = 3
        '
        'txt_um
        '
        Me.txt_um.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_um.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_um.Location = New System.Drawing.Point(166, 255)
        Me.txt_um.Name = "txt_um"
        Me.txt_um.ReadOnly = True
        Me.txt_um.Size = New System.Drawing.Size(69, 20)
        Me.txt_um.TabIndex = 11
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gb_datos_logisticos)
        Me.TabPage3.Controls.Add(Me.GroupBox9)
        Me.TabPage3.Controls.Add(Me.Label52)
        Me.TabPage3.Controls.Add(Me.txt_cod_articulo)
        Me.TabPage3.Controls.Add(Me.checkLineas)
        Me.TabPage3.Controls.Add(Me.dgv_detalle)
        Me.TabPage3.Controls.Add(Me.Label48)
        Me.TabPage3.Controls.Add(Me.btn_quitar)
        Me.TabPage3.Controls.Add(Me.btn_agregar)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.lblcompra)
        Me.TabPage3.Controls.Add(Me.txtCuentaCompra)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.txtCuentaInventario)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.txtcuentaVenta)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.pb_img)
        Me.TabPage3.Controls.Add(Me.PictureBox9)
        Me.TabPage3.Controls.Add(Me.PictureBox8)
        Me.TabPage3.Controls.Add(Me.PictureBox7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(861, 525)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ingreso / Datos Adicionales"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gb_datos_logisticos
        '
        Me.gb_datos_logisticos.Controls.Add(Me.Label69)
        Me.gb_datos_logisticos.Controls.Add(Me.txt_stock_maximo)
        Me.gb_datos_logisticos.Controls.Add(Me.Label70)
        Me.gb_datos_logisticos.Controls.Add(Me.txt_punto_pedido)
        Me.gb_datos_logisticos.Controls.Add(Me.Label71)
        Me.gb_datos_logisticos.Controls.Add(Me.txt_stock_minimo)
        Me.gb_datos_logisticos.ForeColor = System.Drawing.Color.Navy
        Me.gb_datos_logisticos.Location = New System.Drawing.Point(472, 327)
        Me.gb_datos_logisticos.Name = "gb_datos_logisticos"
        Me.gb_datos_logisticos.Size = New System.Drawing.Size(210, 158)
        Me.gb_datos_logisticos.TabIndex = 217
        Me.gb_datos_logisticos.TabStop = False
        Me.gb_datos_logisticos.Text = "Datos Logisticos"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.ForeColor = System.Drawing.Color.Navy
        Me.Label69.Location = New System.Drawing.Point(11, 107)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(74, 13)
        Me.Label69.TabIndex = 216
        Me.Label69.Text = "Stock Maximo"
        '
        'txt_stock_maximo
        '
        Me.txt_stock_maximo.BackColor = System.Drawing.Color.White
        Me.txt_stock_maximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stock_maximo.Location = New System.Drawing.Point(11, 123)
        Me.txt_stock_maximo.MaxLength = 20
        Me.txt_stock_maximo.Name = "txt_stock_maximo"
        Me.txt_stock_maximo.Size = New System.Drawing.Size(100, 20)
        Me.txt_stock_maximo.TabIndex = 215
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.ForeColor = System.Drawing.Color.Navy
        Me.Label70.Location = New System.Drawing.Point(11, 58)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(86, 13)
        Me.Label70.TabIndex = 214
        Me.Label70.Text = "Punto de Pedido"
        '
        'txt_punto_pedido
        '
        Me.txt_punto_pedido.BackColor = System.Drawing.Color.White
        Me.txt_punto_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_punto_pedido.Location = New System.Drawing.Point(11, 74)
        Me.txt_punto_pedido.MaxLength = 20
        Me.txt_punto_pedido.Name = "txt_punto_pedido"
        Me.txt_punto_pedido.Size = New System.Drawing.Size(100, 20)
        Me.txt_punto_pedido.TabIndex = 213
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.ForeColor = System.Drawing.Color.Navy
        Me.Label71.Location = New System.Drawing.Point(11, 13)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(71, 13)
        Me.Label71.TabIndex = 212
        Me.Label71.Text = "Stock Minimo"
        '
        'txt_stock_minimo
        '
        Me.txt_stock_minimo.BackColor = System.Drawing.Color.White
        Me.txt_stock_minimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stock_minimo.Location = New System.Drawing.Point(11, 29)
        Me.txt_stock_minimo.MaxLength = 20
        Me.txt_stock_minimo.Name = "txt_stock_minimo"
        Me.txt_stock_minimo.Size = New System.Drawing.Size(100, 20)
        Me.txt_stock_minimo.TabIndex = 211
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label68)
        Me.GroupBox9.Controls.Add(Me.txt_11)
        Me.GroupBox9.Controls.Add(Me.Label63)
        Me.GroupBox9.Controls.Add(Me.txt_10)
        Me.GroupBox9.Controls.Add(Me.Label64)
        Me.GroupBox9.Controls.Add(Me.txt_9)
        Me.GroupBox9.Controls.Add(Me.Label65)
        Me.GroupBox9.Controls.Add(Me.txt_8)
        Me.GroupBox9.Controls.Add(Me.Label66)
        Me.GroupBox9.Controls.Add(Me.txt_7)
        Me.GroupBox9.Controls.Add(Me.Label67)
        Me.GroupBox9.Controls.Add(Me.txt_6)
        Me.GroupBox9.Controls.Add(Me.Label62)
        Me.GroupBox9.Controls.Add(Me.txt_5)
        Me.GroupBox9.Controls.Add(Me.Label61)
        Me.GroupBox9.Controls.Add(Me.txt_4)
        Me.GroupBox9.Controls.Add(Me.Label60)
        Me.GroupBox9.Controls.Add(Me.txt_3)
        Me.GroupBox9.Controls.Add(Me.Label59)
        Me.GroupBox9.Controls.Add(Me.txt_2)
        Me.GroupBox9.Controls.Add(Me.Label58)
        Me.GroupBox9.Controls.Add(Me.txt_1)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(314, 29)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(368, 290)
        Me.GroupBox9.TabIndex = 203
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Tratamiento Arancelario por Subpartida Nacional"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(80, 253)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(61, 13)
        Me.Label68.TabIndex = 26
        Me.Label68.Text = "Percepción"
        '
        'txt_11
        '
        Me.txt_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_11.Location = New System.Drawing.Point(147, 250)
        Me.txt_11.Name = "txt_11"
        Me.txt_11.Size = New System.Drawing.Size(211, 20)
        Me.txt_11.TabIndex = 27
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(44, 230)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(97, 13)
        Me.Label63.TabIndex = 24
        Me.Label63.Text = "Sobretasa Sanción"
        '
        'txt_10
        '
        Me.txt_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_10.Location = New System.Drawing.Point(147, 227)
        Me.txt_10.Name = "txt_10"
        Me.txt_10.Size = New System.Drawing.Size(211, 20)
        Me.txt_10.TabIndex = 25
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(50, 208)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(91, 13)
        Me.Label64.TabIndex = 22
        Me.Label64.Text = "Sobretasa Tributo"
        '
        'txt_9
        '
        Me.txt_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_9.Location = New System.Drawing.Point(147, 205)
        Me.txt_9.Name = "txt_9"
        Me.txt_9.Size = New System.Drawing.Size(211, 20)
        Me.txt_9.TabIndex = 23
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(100, 185)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(41, 13)
        Me.Label65.TabIndex = 20
        Me.Label65.Text = "Seguro"
        '
        'txt_8
        '
        Me.txt_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_8.Location = New System.Drawing.Point(147, 182)
        Me.txt_8.Name = "txt_8"
        Me.txt_8.Size = New System.Drawing.Size(211, 20)
        Me.txt_8.TabIndex = 21
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(27, 162)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(114, 13)
        Me.Label66.TabIndex = 18
        Me.Label66.Text = "Derechos Antidumping"
        '
        'txt_7
        '
        Me.txt_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_7.Location = New System.Drawing.Point(147, 159)
        Me.txt_7.Name = "txt_7"
        Me.txt_7.Size = New System.Drawing.Size(211, 20)
        Me.txt_7.TabIndex = 19
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(31, 140)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(110, 13)
        Me.Label67.TabIndex = 16
        Me.Label67.Text = "Derechos Especificos"
        '
        'txt_6
        '
        Me.txt_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_6.Location = New System.Drawing.Point(147, 137)
        Me.txt_6.Name = "txt_6"
        Me.txt_6.Size = New System.Drawing.Size(211, 20)
        Me.txt_6.TabIndex = 17
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(106, 118)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(35, 13)
        Me.Label62.TabIndex = 14
        Me.Label62.Text = "I.P.M."
        '
        'txt_5
        '
        Me.txt_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_5.Location = New System.Drawing.Point(147, 115)
        Me.txt_5.Name = "txt_5"
        Me.txt_5.Size = New System.Drawing.Size(211, 20)
        Me.txt_5.TabIndex = 15
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(107, 96)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(34, 13)
        Me.Label61.TabIndex = 12
        Me.Label61.Text = "I.G.V."
        '
        'txt_4
        '
        Me.txt_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_4.Location = New System.Drawing.Point(147, 93)
        Me.txt_4.Name = "txt_4"
        Me.txt_4.Size = New System.Drawing.Size(211, 20)
        Me.txt_4.TabIndex = 13
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(108, 73)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(33, 13)
        Me.Label60.TabIndex = 10
        Me.Label60.Text = "I.S.C."
        '
        'txt_3
        '
        Me.txt_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_3.Location = New System.Drawing.Point(147, 70)
        Me.txt_3.Name = "txt_3"
        Me.txt_3.Size = New System.Drawing.Size(211, 20)
        Me.txt_3.TabIndex = 11
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(80, 50)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(61, 13)
        Me.Label59.TabIndex = 8
        Me.Label59.Text = "Ad-Valorem"
        '
        'txt_2
        '
        Me.txt_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_2.Location = New System.Drawing.Point(147, 47)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(211, 20)
        Me.txt_2.TabIndex = 9
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(11, 28)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(130, 13)
        Me.Label58.TabIndex = 6
        Me.Label58.Text = "Subpartida Nacional DAM"
        '
        'txt_1
        '
        Me.txt_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_1.Location = New System.Drawing.Point(147, 25)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(211, 20)
        Me.txt_1.TabIndex = 7
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(100, 14)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(40, 13)
        Me.Label52.TabIndex = 202
        Me.Label52.Text = "Codigo"
        '
        'txt_cod_articulo
        '
        Me.txt_cod_articulo.BackColor = System.Drawing.Color.White
        Me.txt_cod_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_articulo.Location = New System.Drawing.Point(143, 11)
        Me.txt_cod_articulo.Name = "txt_cod_articulo"
        Me.txt_cod_articulo.ReadOnly = True
        Me.txt_cod_articulo.Size = New System.Drawing.Size(80, 20)
        Me.txt_cod_articulo.TabIndex = 201
        Me.txt_cod_articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'checkLineas
        '
        Me.checkLineas.AutoSize = True
        Me.checkLineas.ForeColor = System.Drawing.Color.Navy
        Me.checkLineas.Location = New System.Drawing.Point(349, 7)
        Me.checkLineas.Name = "checkLineas"
        Me.checkLineas.Size = New System.Drawing.Size(92, 17)
        Me.checkLineas.TabIndex = 7
        Me.checkLineas.Text = "Activar Todos"
        Me.checkLineas.UseVisualStyleBackColor = True
        Me.checkLineas.Visible = False
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AllowUserToDeleteRows = False
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_img})
        Me.dgv_detalle.Location = New System.Drawing.Point(704, 151)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.Size = New System.Drawing.Size(173, 72)
        Me.dgv_detalle.TabIndex = 200
        Me.dgv_detalle.Visible = False
        '
        'col_img
        '
        Me.col_img.HeaderText = "Foto"
        Me.col_img.Name = "col_img"
        Me.col_img.ReadOnly = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.Navy
        Me.Label48.Location = New System.Drawing.Point(145, 126)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(85, 13)
        Me.Label48.TabIndex = 199
        Me.Label48.Text = "Mini Vista Previa"
        '
        'btn_quitar
        '
        Me.btn_quitar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_quitar.ForeColor = System.Drawing.Color.Navy
        Me.btn_quitar.Location = New System.Drawing.Point(187, 291)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(33, 30)
        Me.btn_quitar.TabIndex = 198
        Me.btn_quitar.Text = "-"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.ForeColor = System.Drawing.Color.Navy
        Me.btn_agregar.Location = New System.Drawing.Point(148, 291)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(33, 30)
        Me.btn_agregar.TabIndex = 197
        Me.btn_agregar.Text = "+"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(62, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 195
        Me.Label10.Text = "Foto"
        '
        'lblcompra
        '
        Me.lblcompra.AutoSize = True
        Me.lblcompra.ForeColor = System.Drawing.Color.Navy
        Me.lblcompra.Location = New System.Drawing.Point(42, 100)
        Me.lblcompra.Name = "lblcompra"
        Me.lblcompra.Size = New System.Drawing.Size(95, 13)
        Me.lblcompra.TabIndex = 191
        Me.lblcompra.Text = "Cuenta de Compra"
        '
        'txtCuentaCompra
        '
        Me.txtCuentaCompra.BackColor = System.Drawing.Color.White
        Me.txtCuentaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaCompra.Location = New System.Drawing.Point(143, 97)
        Me.txtCuentaCompra.Name = "txtCuentaCompra"
        Me.txtCuentaCompra.ReadOnly = True
        Me.txtCuentaCompra.Size = New System.Drawing.Size(97, 20)
        Me.txtCuentaCompra.TabIndex = 189
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(28, 74)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(109, 13)
        Me.Label30.TabIndex = 190
        Me.Label30.Text = "Cuenta de  Inventario"
        '
        'txtCuentaInventario
        '
        Me.txtCuentaInventario.BackColor = System.Drawing.Color.White
        Me.txtCuentaInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaInventario.Location = New System.Drawing.Point(143, 71)
        Me.txtCuentaInventario.Name = "txtCuentaInventario"
        Me.txtCuentaInventario.ReadOnly = True
        Me.txtCuentaInventario.Size = New System.Drawing.Size(97, 20)
        Me.txtCuentaInventario.TabIndex = 188
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(45, 46)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(92, 13)
        Me.Label29.TabIndex = 186
        Me.Label29.Text = "Cuenta de Ventas"
        '
        'txtcuentaVenta
        '
        Me.txtcuentaVenta.BackColor = System.Drawing.Color.White
        Me.txtcuentaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaVenta.Location = New System.Drawing.Point(143, 44)
        Me.txtcuentaVenta.Name = "txtcuentaVenta"
        Me.txtcuentaVenta.ReadOnly = True
        Me.txtcuentaVenta.Size = New System.Drawing.Size(97, 20)
        Me.txtcuentaVenta.TabIndex = 185
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label72)
        Me.GroupBox2.Controls.Add(Me.txt_des_lina_produccion)
        Me.GroupBox2.Controls.Add(Me.PictureBox14)
        Me.GroupBox2.Controls.Add(Me.txt_cod_linea_produccion)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtcapacidad)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtdescripcionpres)
        Me.GroupBox2.Controls.Add(Me.PictureBox11)
        Me.GroupBox2.Controls.Add(Me.txtcodigopres)
        Me.GroupBox2.Controls.Add(Me.TXTPRODUCCIONDESC)
        Me.GroupBox2.Controls.Add(Me.PictureBox10)
        Me.GroupBox2.Controls.Add(Me.txtProduccion)
        Me.GroupBox2.Controls.Add(Me.chkProduccion)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 200)
        Me.GroupBox2.TabIndex = 184
        Me.GroupBox2.TabStop = False
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.ForeColor = System.Drawing.Color.Navy
        Me.Label72.Location = New System.Drawing.Point(11, 158)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(105, 13)
        Me.Label72.TabIndex = 217
        Me.Label72.Text = "Linea de Producción"
        '
        'txt_des_lina_produccion
        '
        Me.txt_des_lina_produccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_lina_produccion.ForeColor = System.Drawing.Color.Black
        Me.txt_des_lina_produccion.Location = New System.Drawing.Point(109, 174)
        Me.txt_des_lina_produccion.Name = "txt_des_lina_produccion"
        Me.txt_des_lina_produccion.ReadOnly = True
        Me.txt_des_lina_produccion.Size = New System.Drawing.Size(320, 20)
        Me.txt_des_lina_produccion.TabIndex = 216
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(84, 176)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox14.TabIndex = 215
        Me.PictureBox14.TabStop = False
        '
        'txt_cod_linea_produccion
        '
        Me.txt_cod_linea_produccion.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_linea_produccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_linea_produccion.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_linea_produccion.Location = New System.Drawing.Point(11, 174)
        Me.txt_cod_linea_produccion.Name = "txt_cod_linea_produccion"
        Me.txt_cod_linea_produccion.ReadOnly = True
        Me.txt_cod_linea_produccion.Size = New System.Drawing.Size(67, 20)
        Me.txt_cod_linea_produccion.TabIndex = 214
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(11, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 213
        Me.Label13.Text = "Formula"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(11, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 13)
        Me.Label12.TabIndex = 212
        Me.Label12.Text = "Capacidad de Presentación"
        '
        'txtcapacidad
        '
        Me.txtcapacidad.BackColor = System.Drawing.Color.White
        Me.txtcapacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcapacidad.Location = New System.Drawing.Point(11, 130)
        Me.txtcapacidad.Name = "txtcapacidad"
        Me.txtcapacidad.Size = New System.Drawing.Size(164, 20)
        Me.txtcapacidad.TabIndex = 211
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(11, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 13)
        Me.Label11.TabIndex = 210
        Me.Label11.Text = "Codigo de Presentación"
        '
        'txtdescripcionpres
        '
        Me.txtdescripcionpres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionpres.ForeColor = System.Drawing.Color.Black
        Me.txtdescripcionpres.Location = New System.Drawing.Point(109, 86)
        Me.txtdescripcionpres.Name = "txtdescripcionpres"
        Me.txtdescripcionpres.ReadOnly = True
        Me.txtdescripcionpres.Size = New System.Drawing.Size(320, 20)
        Me.txtdescripcionpres.TabIndex = 209
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(84, 88)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox11.TabIndex = 208
        Me.PictureBox11.TabStop = False
        '
        'txtcodigopres
        '
        Me.txtcodigopres.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigopres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigopres.ForeColor = System.Drawing.Color.Black
        Me.txtcodigopres.Location = New System.Drawing.Point(11, 86)
        Me.txtcodigopres.Name = "txtcodigopres"
        Me.txtcodigopres.ReadOnly = True
        Me.txtcodigopres.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigopres.TabIndex = 207
        '
        'TXTPRODUCCIONDESC
        '
        Me.TXTPRODUCCIONDESC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPRODUCCIONDESC.ForeColor = System.Drawing.Color.Black
        Me.TXTPRODUCCIONDESC.Location = New System.Drawing.Point(109, 43)
        Me.TXTPRODUCCIONDESC.Name = "TXTPRODUCCIONDESC"
        Me.TXTPRODUCCIONDESC.ReadOnly = True
        Me.TXTPRODUCCIONDESC.Size = New System.Drawing.Size(320, 20)
        Me.TXTPRODUCCIONDESC.TabIndex = 189
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(84, 45)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox10.TabIndex = 188
        Me.PictureBox10.TabStop = False
        '
        'txtProduccion
        '
        Me.txtProduccion.BackColor = System.Drawing.Color.Aquamarine
        Me.txtProduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProduccion.ForeColor = System.Drawing.Color.Black
        Me.txtProduccion.Location = New System.Drawing.Point(11, 43)
        Me.txtProduccion.Name = "txtProduccion"
        Me.txtProduccion.ReadOnly = True
        Me.txtProduccion.Size = New System.Drawing.Size(67, 20)
        Me.txtProduccion.TabIndex = 28
        '
        'chkProduccion
        '
        Me.chkProduccion.AutoSize = True
        Me.chkProduccion.ForeColor = System.Drawing.Color.Navy
        Me.chkProduccion.Location = New System.Drawing.Point(14, 9)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(136, 17)
        Me.chkProduccion.TabIndex = 27
        Me.chkProduccion.Text = "Valido para Producción"
        Me.chkProduccion.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chklstLineas)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(688, 40)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(372, 79)
        Me.GroupBox6.TabIndex = 183
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "&Lineas medicas"
        Me.GroupBox6.Visible = False
        '
        'chklstLineas
        '
        Me.chklstLineas.CheckOnClick = True
        Me.chklstLineas.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstLineas.FormattingEnabled = True
        Me.chklstLineas.Location = New System.Drawing.Point(11, 19)
        Me.chklstLineas.Name = "chklstLineas"
        Me.chklstLineas.Size = New System.Drawing.Size(418, 95)
        Me.chklstLineas.TabIndex = 6
        '
        'pb_img
        '
        Me.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_img.Location = New System.Drawing.Point(108, 142)
        Me.pb_img.Name = "pb_img"
        Me.pb_img.Size = New System.Drawing.Size(173, 143)
        Me.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_img.TabIndex = 196
        Me.pb_img.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(246, 98)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox9.TabIndex = 193
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(246, 71)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox8.TabIndex = 192
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(246, 44)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox7.TabIndex = 187
        Me.PictureBox7.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label55)
        Me.TabPage4.Controls.Add(Me.txtComentarios)
        Me.TabPage4.Controls.Add(Me.gb_tipo_prod_controlado)
        Me.TabPage4.Controls.Add(Me.chk_prod_controlado)
        Me.TabPage4.Controls.Add(Me.Label53)
        Me.TabPage4.Controls.Add(Me.txt_cod_articulo_dos)
        Me.TabPage4.Controls.Add(Me.Label49)
        Me.TabPage4.Controls.Add(Me.dtp_fec_vcto_norma_tec)
        Me.TabPage4.Controls.Add(Me.Label50)
        Me.TabPage4.Controls.Add(Me.dtp_fec_emi_norma_tecnica)
        Me.TabPage4.Controls.Add(Me.Label51)
        Me.TabPage4.Controls.Add(Me.txt_numero_norma_tec)
        Me.TabPage4.Controls.Add(Me.GroupBox8)
        Me.TabPage4.Controls.Add(Me.pnl_pt)
        Me.TabPage4.Controls.Add(Me.cbo_norma_tecnica)
        Me.TabPage4.Controls.Add(Me.Label43)
        Me.TabPage4.Controls.Add(Me.cbo_condicion_venta)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.cbo_forma_farmaceutica)
        Me.TabPage4.Controls.Add(Me.Label36)
        Me.TabPage4.Controls.Add(Me.gb_principios_activos)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(861, 525)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Navy
        Me.Label55.Location = New System.Drawing.Point(421, 393)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(78, 13)
        Me.Label55.TabIndex = 233
        Me.Label55.Text = "Observaciones"
        Me.Label55.Visible = False
        '
        'txtComentarios
        '
        Me.txtComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentarios.BackColor = System.Drawing.Color.Aquamarine
        Me.txtComentarios.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarios.Location = New System.Drawing.Point(417, 411)
        Me.txtComentarios.MaxLength = 500
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarios.Size = New System.Drawing.Size(397, 74)
        Me.txtComentarios.TabIndex = 232
        Me.txtComentarios.Text = ""
        Me.txtComentarios.Visible = False
        '
        'gb_tipo_prod_controlado
        '
        Me.gb_tipo_prod_controlado.Controls.Add(Me.cbo_tipo_prod_controlado)
        Me.gb_tipo_prod_controlado.Controls.Add(Me.Label54)
        Me.gb_tipo_prod_controlado.Enabled = False
        Me.gb_tipo_prod_controlado.ForeColor = System.Drawing.Color.Navy
        Me.gb_tipo_prod_controlado.Location = New System.Drawing.Point(417, 309)
        Me.gb_tipo_prod_controlado.Name = "gb_tipo_prod_controlado"
        Me.gb_tipo_prod_controlado.Size = New System.Drawing.Size(397, 72)
        Me.gb_tipo_prod_controlado.TabIndex = 231
        Me.gb_tipo_prod_controlado.TabStop = False
        Me.gb_tipo_prod_controlado.Visible = False
        '
        'cbo_tipo_prod_controlado
        '
        Me.cbo_tipo_prod_controlado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_prod_controlado.FormattingEnabled = True
        Me.cbo_tipo_prod_controlado.Items.AddRange(New Object() {"Estupefacientes", "Psicotropicos"})
        Me.cbo_tipo_prod_controlado.Location = New System.Drawing.Point(136, 31)
        Me.cbo_tipo_prod_controlado.Name = "cbo_tipo_prod_controlado"
        Me.cbo_tipo_prod_controlado.Size = New System.Drawing.Size(229, 21)
        Me.cbo_tipo_prod_controlado.TabIndex = 141
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(8, 34)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(122, 13)
        Me.Label54.TabIndex = 140
        Me.Label54.Text = "Tipo de Prod. Contolado"
        '
        'chk_prod_controlado
        '
        Me.chk_prod_controlado.AutoSize = True
        Me.chk_prod_controlado.ForeColor = System.Drawing.Color.Navy
        Me.chk_prod_controlado.Location = New System.Drawing.Point(417, 284)
        Me.chk_prod_controlado.Name = "chk_prod_controlado"
        Me.chk_prod_controlado.Size = New System.Drawing.Size(144, 17)
        Me.chk_prod_controlado.TabIndex = 230
        Me.chk_prod_controlado.Text = "Es Producto Controlado?"
        Me.chk_prod_controlado.UseVisualStyleBackColor = True
        Me.chk_prod_controlado.Visible = False
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(824, 23)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(40, 13)
        Me.Label53.TabIndex = 229
        Me.Label53.Text = "Codigo"
        '
        'txt_cod_articulo_dos
        '
        Me.txt_cod_articulo_dos.BackColor = System.Drawing.Color.White
        Me.txt_cod_articulo_dos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_articulo_dos.Location = New System.Drawing.Point(867, 20)
        Me.txt_cod_articulo_dos.Name = "txt_cod_articulo_dos"
        Me.txt_cod_articulo_dos.ReadOnly = True
        Me.txt_cod_articulo_dos.Size = New System.Drawing.Size(80, 20)
        Me.txt_cod_articulo_dos.TabIndex = 228
        Me.txt_cod_articulo_dos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(214, 476)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(78, 13)
        Me.Label49.TabIndex = 227
        Me.Label49.Text = "N° Norma Tec."
        Me.Label49.Visible = False
        '
        'dtp_fec_vcto_norma_tec
        '
        Me.dtp_fec_vcto_norma_tec.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fec_vcto_norma_tec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_vcto_norma_tec.Location = New System.Drawing.Point(125, 495)
        Me.dtp_fec_vcto_norma_tec.Name = "dtp_fec_vcto_norma_tec"
        Me.dtp_fec_vcto_norma_tec.Size = New System.Drawing.Size(83, 25)
        Me.dtp_fec_vcto_norma_tec.TabIndex = 226
        Me.dtp_fec_vcto_norma_tec.Visible = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.Navy
        Me.Label50.Location = New System.Drawing.Point(16, 500)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(103, 13)
        Me.Label50.TabIndex = 225
        Me.Label50.Text = "F. Vcto. Norma Tec."
        Me.Label50.Visible = False
        '
        'dtp_fec_emi_norma_tecnica
        '
        Me.dtp_fec_emi_norma_tecnica.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fec_emi_norma_tecnica.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_emi_norma_tecnica.Location = New System.Drawing.Point(125, 472)
        Me.dtp_fec_emi_norma_tecnica.Name = "dtp_fec_emi_norma_tecnica"
        Me.dtp_fec_emi_norma_tecnica.Size = New System.Drawing.Size(83, 25)
        Me.dtp_fec_emi_norma_tecnica.TabIndex = 224
        Me.dtp_fec_emi_norma_tecnica.Visible = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Navy
        Me.Label51.Location = New System.Drawing.Point(5, 477)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(114, 13)
        Me.Label51.TabIndex = 223
        Me.Label51.Text = "F. Emisión Norma Tec."
        Me.Label51.Visible = False
        '
        'txt_numero_norma_tec
        '
        Me.txt_numero_norma_tec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_norma_tec.ForeColor = System.Drawing.Color.Black
        Me.txt_numero_norma_tec.Location = New System.Drawing.Point(295, 473)
        Me.txt_numero_norma_tec.MaxLength = 20
        Me.txt_numero_norma_tec.Name = "txt_numero_norma_tec"
        Me.txt_numero_norma_tec.Size = New System.Drawing.Size(97, 20)
        Me.txt_numero_norma_tec.TabIndex = 222
        Me.txt_numero_norma_tec.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label47)
        Me.GroupBox8.Controls.Add(Me.DTP_FEC_VCTO_REG_SANIT)
        Me.GroupBox8.Controls.Add(Me.Label46)
        Me.GroupBox8.Controls.Add(Me.DTP_FEC_EMI_REG_SANIT)
        Me.GroupBox8.Controls.Add(Me.Label45)
        Me.GroupBox8.Controls.Add(Me.txt_num_regsanit)
        Me.GroupBox8.Controls.Add(Me.btn_add_regsanit)
        Me.GroupBox8.Controls.Add(Me.btn_del_regsanit)
        Me.GroupBox8.Controls.Add(Me.dgv_incripciones_regsanit)
        Me.GroupBox8.Controls.Add(Me.Label44)
        Me.GroupBox8.Location = New System.Drawing.Point(417, 13)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(397, 251)
        Me.GroupBox8.TabIndex = 196
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Visible = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(165, 33)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(75, 13)
        Me.Label47.TabIndex = 221
        Me.Label47.Text = "N° Reg. Sanit."
        '
        'DTP_FEC_VCTO_REG_SANIT
        '
        Me.DTP_FEC_VCTO_REG_SANIT.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DTP_FEC_VCTO_REG_SANIT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FEC_VCTO_REG_SANIT.Location = New System.Drawing.Point(69, 52)
        Me.DTP_FEC_VCTO_REG_SANIT.Name = "DTP_FEC_VCTO_REG_SANIT"
        Me.DTP_FEC_VCTO_REG_SANIT.Size = New System.Drawing.Size(83, 25)
        Me.DTP_FEC_VCTO_REG_SANIT.TabIndex = 220
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(8, 57)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(44, 13)
        Me.Label46.TabIndex = 219
        Me.Label46.Text = "F. Vcto."
        '
        'DTP_FEC_EMI_REG_SANIT
        '
        Me.DTP_FEC_EMI_REG_SANIT.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DTP_FEC_EMI_REG_SANIT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FEC_EMI_REG_SANIT.Location = New System.Drawing.Point(69, 29)
        Me.DTP_FEC_EMI_REG_SANIT.Name = "DTP_FEC_EMI_REG_SANIT"
        Me.DTP_FEC_EMI_REG_SANIT.Size = New System.Drawing.Size(83, 25)
        Me.DTP_FEC_EMI_REG_SANIT.TabIndex = 218
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(8, 34)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(55, 13)
        Me.Label45.TabIndex = 217
        Me.Label45.Text = "F. Emisión"
        '
        'txt_num_regsanit
        '
        Me.txt_num_regsanit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_regsanit.ForeColor = System.Drawing.Color.Black
        Me.txt_num_regsanit.Location = New System.Drawing.Point(246, 30)
        Me.txt_num_regsanit.MaxLength = 20
        Me.txt_num_regsanit.Name = "txt_num_regsanit"
        Me.txt_num_regsanit.Size = New System.Drawing.Size(140, 20)
        Me.txt_num_regsanit.TabIndex = 216
        '
        'btn_add_regsanit
        '
        Me.btn_add_regsanit.Image = CType(resources.GetObject("btn_add_regsanit.Image"), System.Drawing.Image)
        Me.btn_add_regsanit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_regsanit.Location = New System.Drawing.Point(246, 52)
        Me.btn_add_regsanit.Name = "btn_add_regsanit"
        Me.btn_add_regsanit.Size = New System.Drawing.Size(68, 23)
        Me.btn_add_regsanit.TabIndex = 49
        Me.btn_add_regsanit.Text = "Agregar"
        Me.btn_add_regsanit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add_regsanit.UseVisualStyleBackColor = True
        '
        'btn_del_regsanit
        '
        Me.btn_del_regsanit.Image = CType(resources.GetObject("btn_del_regsanit.Image"), System.Drawing.Image)
        Me.btn_del_regsanit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del_regsanit.Location = New System.Drawing.Point(318, 52)
        Me.btn_del_regsanit.Name = "btn_del_regsanit"
        Me.btn_del_regsanit.Size = New System.Drawing.Size(68, 23)
        Me.btn_del_regsanit.TabIndex = 48
        Me.btn_del_regsanit.Text = "Eliminar"
        Me.btn_del_regsanit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del_regsanit.UseVisualStyleBackColor = True
        '
        'dgv_incripciones_regsanit
        '
        Me.dgv_incripciones_regsanit.AllowUserToAddRows = False
        Me.dgv_incripciones_regsanit.AllowUserToDeleteRows = False
        Me.dgv_incripciones_regsanit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_incripciones_regsanit.Location = New System.Drawing.Point(7, 83)
        Me.dgv_incripciones_regsanit.Name = "dgv_incripciones_regsanit"
        Me.dgv_incripciones_regsanit.ReadOnly = True
        Me.dgv_incripciones_regsanit.Size = New System.Drawing.Size(379, 153)
        Me.dgv_incripciones_regsanit.TabIndex = 47
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Navy
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(-3, 7)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(402, 19)
        Me.Label44.TabIndex = 36
        Me.Label44.Text = "  Inscripciones del Reg. Sanitario"
        '
        'pnl_pt
        '
        Me.pnl_pt.Controls.Add(Me.cbo_estado_rs)
        Me.pnl_pt.Controls.Add(Me.Label41)
        Me.pnl_pt.Controls.Add(Me.Label14)
        Me.pnl_pt.Controls.Add(Me.dtp_vcto_reg_sanit)
        Me.pnl_pt.Controls.Add(Me.txt_vigencia_lot)
        Me.pnl_pt.Controls.Add(Me.txt_vig_reg_sanit)
        Me.pnl_pt.Controls.Add(Me.txtpesoArticulo)
        Me.pnl_pt.Controls.Add(Me.Label25)
        Me.pnl_pt.Controls.Add(Me.Label4)
        Me.pnl_pt.Controls.Add(Me.txtClase)
        Me.pnl_pt.Controls.Add(Me.Label7)
        Me.pnl_pt.Controls.Add(Me.Label28)
        Me.pnl_pt.Controls.Add(Me.Label8)
        Me.pnl_pt.Controls.Add(Me.txtColor)
        Me.pnl_pt.Controls.Add(Me.txt_nro_reg_sanit)
        Me.pnl_pt.Controls.Add(Me.Label32)
        Me.pnl_pt.Controls.Add(Me.txtTalla)
        Me.pnl_pt.Controls.Add(Me.Label31)
        Me.pnl_pt.Location = New System.Drawing.Point(12, 336)
        Me.pnl_pt.Name = "pnl_pt"
        Me.pnl_pt.Size = New System.Drawing.Size(399, 107)
        Me.pnl_pt.TabIndex = 195
        Me.pnl_pt.Visible = False
        '
        'cbo_estado_rs
        '
        Me.cbo_estado_rs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_estado_rs.FormattingEnabled = True
        Me.cbo_estado_rs.Items.AddRange(New Object() {"Vigente ", "No Vigente"})
        Me.cbo_estado_rs.Location = New System.Drawing.Point(113, 79)
        Me.cbo_estado_rs.Name = "cbo_estado_rs"
        Me.cbo_estado_rs.Size = New System.Drawing.Size(97, 21)
        Me.cbo_estado_rs.TabIndex = 143
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(40, 82)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(64, 13)
        Me.Label41.TabIndex = 142
        Me.Label41.Text = "Estado R.S."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(211, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "años."
        '
        'dtp_vcto_reg_sanit
        '
        Me.dtp_vcto_reg_sanit.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_vcto_reg_sanit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_vcto_reg_sanit.Location = New System.Drawing.Point(113, 28)
        Me.dtp_vcto_reg_sanit.Name = "dtp_vcto_reg_sanit"
        Me.dtp_vcto_reg_sanit.Size = New System.Drawing.Size(97, 25)
        Me.dtp_vcto_reg_sanit.TabIndex = 136
        '
        'txt_vigencia_lot
        '
        Me.txt_vigencia_lot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vigencia_lot.Location = New System.Drawing.Point(113, 57)
        Me.txt_vigencia_lot.Name = "txt_vigencia_lot"
        Me.txt_vigencia_lot.Size = New System.Drawing.Size(97, 20)
        Me.txt_vigencia_lot.TabIndex = 20
        '
        'txt_vig_reg_sanit
        '
        Me.txt_vig_reg_sanit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vig_reg_sanit.Location = New System.Drawing.Point(386, 57)
        Me.txt_vig_reg_sanit.Name = "txt_vig_reg_sanit"
        Me.txt_vig_reg_sanit.Size = New System.Drawing.Size(97, 20)
        Me.txt_vig_reg_sanit.TabIndex = 19
        Me.txt_vig_reg_sanit.Visible = False
        '
        'txtpesoArticulo
        '
        Me.txtpesoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpesoArticulo.Location = New System.Drawing.Point(335, 86)
        Me.txtpesoArticulo.Name = "txtpesoArticulo"
        Me.txtpesoArticulo.Size = New System.Drawing.Size(97, 20)
        Me.txtpesoArticulo.TabIndex = 14
        Me.txtpesoArticulo.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(260, 89)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 13)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Peso Articulo"
        Me.Label25.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(60, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Vida Util"
        '
        'txtClase
        '
        Me.txtClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClase.Location = New System.Drawing.Point(283, 5)
        Me.txtClase.Name = "txtClase"
        Me.txtClase.Size = New System.Drawing.Size(97, 20)
        Me.txtClase.TabIndex = 15
        Me.txtClase.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(6, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Vcto. de Reg. Sanit"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(247, 7)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(33, 13)
        Me.Label28.TabIndex = 32
        Me.Label28.Text = "Clase"
        Me.Label28.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(27, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "Nro. Reg. Sanit"
        '
        'txtColor
        '
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColor.Location = New System.Drawing.Point(283, 30)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(97, 20)
        Me.txtColor.TabIndex = 16
        Me.txtColor.Visible = False
        '
        'txt_nro_reg_sanit
        '
        Me.txt_nro_reg_sanit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_reg_sanit.Location = New System.Drawing.Point(113, 5)
        Me.txt_nro_reg_sanit.Name = "txt_nro_reg_sanit"
        Me.txt_nro_reg_sanit.Size = New System.Drawing.Size(97, 20)
        Me.txt_nro_reg_sanit.TabIndex = 18
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(248, 32)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 13)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = "Color"
        Me.Label32.Visible = False
        '
        'txtTalla
        '
        Me.txtTalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTalla.Location = New System.Drawing.Point(283, 57)
        Me.txtTalla.Name = "txtTalla"
        Me.txtTalla.Size = New System.Drawing.Size(97, 20)
        Me.txtTalla.TabIndex = 17
        Me.txtTalla.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(250, 59)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(30, 13)
        Me.Label31.TabIndex = 38
        Me.Label31.Text = "&Talla"
        Me.Label31.Visible = False
        '
        'cbo_norma_tecnica
        '
        Me.cbo_norma_tecnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_norma_tecnica.FormattingEnabled = True
        Me.cbo_norma_tecnica.Items.AddRange(New Object() {"Tecnica Propia", "USP", "BP", "Japonesa"})
        Me.cbo_norma_tecnica.Location = New System.Drawing.Point(125, 445)
        Me.cbo_norma_tecnica.Name = "cbo_norma_tecnica"
        Me.cbo_norma_tecnica.Size = New System.Drawing.Size(229, 21)
        Me.cbo_norma_tecnica.TabIndex = 143
        Me.cbo_norma_tecnica.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(39, 448)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(80, 13)
        Me.Label43.TabIndex = 142
        Me.Label43.Text = "Norma Tecnica"
        Me.Label43.Visible = False
        '
        'cbo_condicion_venta
        '
        Me.cbo_condicion_venta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_condicion_venta.FormattingEnabled = True
        Me.cbo_condicion_venta.Items.AddRange(New Object() {"(Seleccione)", "Productos Marca.", "Productos Genericos."})
        Me.cbo_condicion_venta.Location = New System.Drawing.Point(125, 309)
        Me.cbo_condicion_venta.Name = "cbo_condicion_venta"
        Me.cbo_condicion_venta.Size = New System.Drawing.Size(229, 21)
        Me.cbo_condicion_venta.TabIndex = 141
        Me.cbo_condicion_venta.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(19, 312)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(100, 13)
        Me.Label39.TabIndex = 140
        Me.Label39.Text = "Condición de Venta"
        Me.Label39.Visible = False
        '
        'cbo_forma_farmaceutica
        '
        Me.cbo_forma_farmaceutica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_forma_farmaceutica.FormattingEnabled = True
        Me.cbo_forma_farmaceutica.Location = New System.Drawing.Point(125, 282)
        Me.cbo_forma_farmaceutica.Name = "cbo_forma_farmaceutica"
        Me.cbo_forma_farmaceutica.Size = New System.Drawing.Size(229, 21)
        Me.cbo_forma_farmaceutica.TabIndex = 139
        Me.cbo_forma_farmaceutica.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(16, 285)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(103, 13)
        Me.Label36.TabIndex = 138
        Me.Label36.Text = "Forma Farmaceutica"
        Me.Label36.Visible = False
        '
        'gb_principios_activos
        '
        Me.gb_principios_activos.Controls.Add(Me.txt_des_principio_activo)
        Me.gb_principios_activos.Controls.Add(Me.PictureBox12)
        Me.gb_principios_activos.Controls.Add(Me.txt_cod_principio_activo)
        Me.gb_principios_activos.Controls.Add(Me.btn_add)
        Me.gb_principios_activos.Controls.Add(Me.btn_del)
        Me.gb_principios_activos.Controls.Add(Me.dgvDetalle)
        Me.gb_principios_activos.Controls.Add(Me.Label42)
        Me.gb_principios_activos.Location = New System.Drawing.Point(12, 13)
        Me.gb_principios_activos.Name = "gb_principios_activos"
        Me.gb_principios_activos.Size = New System.Drawing.Size(397, 251)
        Me.gb_principios_activos.TabIndex = 38
        Me.gb_principios_activos.TabStop = False
        Me.gb_principios_activos.Visible = False
        '
        'txt_des_principio_activo
        '
        Me.txt_des_principio_activo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_principio_activo.ForeColor = System.Drawing.Color.Black
        Me.txt_des_principio_activo.Location = New System.Drawing.Point(105, 30)
        Me.txt_des_principio_activo.Name = "txt_des_principio_activo"
        Me.txt_des_principio_activo.ReadOnly = True
        Me.txt_des_principio_activo.Size = New System.Drawing.Size(281, 20)
        Me.txt_des_principio_activo.TabIndex = 216
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(80, 32)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox12.TabIndex = 215
        Me.PictureBox12.TabStop = False
        '
        'txt_cod_principio_activo
        '
        Me.txt_cod_principio_activo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_principio_activo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_principio_activo.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_principio_activo.Location = New System.Drawing.Point(7, 30)
        Me.txt_cod_principio_activo.Name = "txt_cod_principio_activo"
        Me.txt_cod_principio_activo.ReadOnly = True
        Me.txt_cod_principio_activo.Size = New System.Drawing.Size(67, 20)
        Me.txt_cod_principio_activo.TabIndex = 214
        '
        'btn_add
        '
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(246, 52)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(68, 23)
        Me.btn_add.TabIndex = 49
        Me.btn_add.Text = "Agregar"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(318, 52)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(68, 23)
        Me.btn_del.TabIndex = 48
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(7, 83)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(379, 153)
        Me.dgvDetalle.TabIndex = 47
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Navy
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(-3, 7)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(402, 19)
        Me.Label42.TabIndex = 36
        Me.Label42.Text = "  Principios Activos"
        '
        'cmsOpciones
        '
        Me.cmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerStockToolStripMenuItem})
        Me.cmsOpciones.Name = "cmsOpciones"
        Me.cmsOpciones.Size = New System.Drawing.Size(122, 26)
        '
        'VerStockToolStripMenuItem
        '
        Me.VerStockToolStripMenuItem.Image = Global.LibCobranzas.My.Resources.Resources.print_26
        Me.VerStockToolStripMenuItem.Name = "VerStockToolStripMenuItem"
        Me.VerStockToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.VerStockToolStripMenuItem.Text = "Ver stock"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_Adicionales, Me.btn_grabar, Me.btn_eliminar, Me.btnImprimir, Me.btn_precio, Me.Tool_Precio_Mat_Empaque, Me.btn_Descuentos, Me.btn_cancelar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(893, 25)
        Me.ToolStrip1.TabIndex = 181
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nuevo.Text = "&Nuevo"
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(81, 22)
        Me.btn_Editar.Text = "&Consultar"
        '
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(73, 22)
        Me.btn_grabar.Text = "&Guardar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(77, 22)
        Me.btnImprimir.Text = "&Imprimir"
        '
        'btn_precio
        '
        Me.btn_precio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_precio.Image = CType(resources.GetObject("btn_precio.Image"), System.Drawing.Image)
        Me.btn_precio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_precio.Name = "btn_precio"
        Me.btn_precio.Size = New System.Drawing.Size(193, 22)
        Me.btn_precio.Text = "&Asignar Precios y Descuentos"
        Me.btn_precio.Visible = False
        '
        'Tool_Precio_Mat_Empaque
        '
        Me.Tool_Precio_Mat_Empaque.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Precio_Mat_Empaque.Image = CType(resources.GetObject("Tool_Precio_Mat_Empaque.Image"), System.Drawing.Image)
        Me.Tool_Precio_Mat_Empaque.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Precio_Mat_Empaque.Name = "Tool_Precio_Mat_Empaque"
        Me.Tool_Precio_Mat_Empaque.Size = New System.Drawing.Size(172, 22)
        Me.Tool_Precio_Mat_Empaque.Text = "Asignar Precios Mat. Emp."
        Me.Tool_Precio_Mat_Empaque.Visible = False
        '
        'btn_Descuentos
        '
        Me.btn_Descuentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Descuentos.Image = CType(resources.GetObject("btn_Descuentos.Image"), System.Drawing.Image)
        Me.btn_Descuentos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Descuentos.Name = "btn_Descuentos"
        Me.btn_Descuentos.Size = New System.Drawing.Size(139, 20)
        Me.btn_Descuentos.Text = "&Asignar Descuentos"
        Me.btn_Descuentos.Visible = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 20)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 20)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'pnlTipoProducto
        '
        Me.pnlTipoProducto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlTipoProducto.Controls.Add(Me.cboTipoPart)
        Me.pnlTipoProducto.Location = New System.Drawing.Point(7, 24)
        Me.pnlTipoProducto.Name = "pnlTipoProducto"
        Me.pnlTipoProducto.Size = New System.Drawing.Size(266, 68)
        Me.pnlTipoProducto.TabIndex = 183
        '
        'cboTipoPart
        '
        Me.cboTipoPart.Enabled = False
        Me.cboTipoPart.FormattingEnabled = True
        Me.cboTipoPart.Location = New System.Drawing.Point(3, 20)
        Me.cboTipoPart.Name = "cboTipoPart"
        Me.cboTipoPart.Size = New System.Drawing.Size(259, 21)
        Me.cboTipoPart.TabIndex = 6
        '
        'pnlreporte
        '
        Me.pnlreporte.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlreporte.Controls.Add(Me.TextBox3)
        Me.pnlreporte.Controls.Add(Me.GroupBox4)
        Me.pnlreporte.Controls.Add(Me.GroupBox7)
        Me.pnlreporte.Location = New System.Drawing.Point(224, 118)
        Me.pnlreporte.Name = "pnlreporte"
        Me.pnlreporte.Size = New System.Drawing.Size(474, 253)
        Me.pnlreporte.TabIndex = 182
        Me.pnlreporte.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Navy
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(1, 0)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(473, 20)
        Me.TextBox3.TabIndex = 168
        Me.TextBox3.Text = "REPORTE DE PRODUCTO"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pnlTipoProducto)
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.cboFamilia)
        Me.GroupBox4.Controls.Add(Me.txtcodigo2)
        Me.GroupBox4.Controls.Add(Me.txtdescripcion2)
        Me.GroupBox4.Controls.Add(Me.txtcodigo1)
        Me.GroupBox4.Controls.Add(Me.txtdescripcion1)
        Me.GroupBox4.Controls.Add(Me.chk_todos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(183, 49)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 189)
        Me.GroupBox4.TabIndex = 169
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalles del Reporte"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(9, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 24)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(11, 19)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(13, 13)
        Me.Label38.TabIndex = 6
        Me.Label38.Text = ".."
        '
        'cboFamilia
        '
        Me.cboFamilia.Enabled = False
        Me.cboFamilia.FormattingEnabled = True
        Me.cboFamilia.Location = New System.Drawing.Point(9, 35)
        Me.cboFamilia.Name = "cboFamilia"
        Me.cboFamilia.Size = New System.Drawing.Size(259, 21)
        Me.cboFamilia.TabIndex = 5
        '
        'txtcodigo2
        '
        Me.txtcodigo2.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo2.Location = New System.Drawing.Point(10, 153)
        Me.txtcodigo2.Name = "txtcodigo2"
        Me.txtcodigo2.Size = New System.Drawing.Size(263, 20)
        Me.txtcodigo2.TabIndex = 4
        '
        'txtdescripcion2
        '
        Me.txtdescripcion2.AutoSize = True
        Me.txtdescripcion2.Location = New System.Drawing.Point(10, 135)
        Me.txtdescripcion2.Name = "txtdescripcion2"
        Me.txtdescripcion2.Size = New System.Drawing.Size(16, 13)
        Me.txtdescripcion2.TabIndex = 3
        Me.txtdescripcion2.Text = "..."
        '
        'txtcodigo1
        '
        Me.txtcodigo1.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo1.Location = New System.Drawing.Point(10, 112)
        Me.txtcodigo1.Name = "txtcodigo1"
        Me.txtcodigo1.Size = New System.Drawing.Size(263, 20)
        Me.txtcodigo1.TabIndex = 2
        '
        'txtdescripcion1
        '
        Me.txtdescripcion1.AutoSize = True
        Me.txtdescripcion1.ForeColor = System.Drawing.Color.Navy
        Me.txtdescripcion1.Location = New System.Drawing.Point(10, 87)
        Me.txtdescripcion1.Name = "txtdescripcion1"
        Me.txtdescripcion1.Size = New System.Drawing.Size(16, 13)
        Me.txtdescripcion1.TabIndex = 1
        Me.txtdescripcion1.Text = "..."
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos.Location = New System.Drawing.Point(10, 64)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(90, 17)
        Me.chk_todos.TabIndex = 0
        Me.chk_todos.Text = "_Listar Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rblinea)
        Me.GroupBox7.Controls.Add(Me.rbtipoarticulo)
        Me.GroupBox7.Controls.Add(Me.rbfamilia)
        Me.GroupBox7.Controls.Add(Me.btn_exit)
        Me.GroupBox7.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox7.Controls.Add(Me.rbcodigo)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(10, 47)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(167, 191)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Opciones de impresion"
        '
        'rblinea
        '
        Me.rblinea.AutoSize = True
        Me.rblinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rblinea.Location = New System.Drawing.Point(7, 77)
        Me.rblinea.Name = "rblinea"
        Me.rblinea.Size = New System.Drawing.Size(66, 17)
        Me.rblinea.TabIndex = 170
        Me.rblinea.Text = "Por linea"
        Me.rblinea.UseVisualStyleBackColor = True
        '
        'rbtipoarticulo
        '
        Me.rbtipoarticulo.AutoSize = True
        Me.rbtipoarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbtipoarticulo.Location = New System.Drawing.Point(7, 103)
        Me.rbtipoarticulo.Name = "rbtipoarticulo"
        Me.rbtipoarticulo.Size = New System.Drawing.Size(123, 17)
        Me.rbtipoarticulo.TabIndex = 169
        Me.rbtipoarticulo.Text = "Por Clase de Articulo"
        Me.rbtipoarticulo.UseVisualStyleBackColor = True
        '
        'rbfamilia
        '
        Me.rbfamilia.AutoSize = True
        Me.rbfamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbfamilia.Location = New System.Drawing.Point(7, 49)
        Me.rbfamilia.Name = "rbfamilia"
        Me.rbfamilia.Size = New System.Drawing.Size(73, 17)
        Me.rbfamilia.TabIndex = 169
        Me.rbfamilia.Text = "Por familia"
        Me.rbfamilia.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_exit.ForeColor = System.Drawing.Color.Navy
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_exit.Location = New System.Drawing.Point(85, 136)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 38)
        Me.btn_exit.TabIndex = 121
        Me.btn_exit.Text = "Cancelar"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Navy
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Aceptar.Location = New System.Drawing.Point(9, 136)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(75, 38)
        Me.btn_Aceptar.TabIndex = 122
        Me.btn_Aceptar.Text = "Confirmar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'rbcodigo
        '
        Me.rbcodigo.AutoSize = True
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbcodigo.Location = New System.Drawing.Point(7, 22)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(76, 17)
        Me.rbcodigo.TabIndex = 0
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Por codigo"
        Me.rbcodigo.UseVisualStyleBackColor = True
        '
        'btn_Adicionales
        '
        Me.btn_Adicionales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_Adicionales.Image = CType(resources.GetObject("btn_Adicionales.Image"), System.Drawing.Image)
        Me.btn_Adicionales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Adicionales.Name = "btn_Adicionales"
        Me.btn_Adicionales.Size = New System.Drawing.Size(91, 22)
        Me.btn_Adicionales.Text = "Adicionales"
        '
        'frm_CX_MA_Articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(893, 583)
        Me.Controls.Add(Me.pnlreporte)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_articulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CX_MA_Articulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Articulos"
        Me.tc_articulo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBmuestraMedica.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.gb_datos_logisticos.ResumeLayout(False)
        Me.gb_datos_logisticos.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.gb_tipo_prod_controlado.ResumeLayout(False)
        Me.gb_tipo_prod_controlado.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.dgv_incripciones_regsanit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_pt.ResumeLayout(False)
        Me.pnl_pt.PerformLayout()
        Me.gb_principios_activos.ResumeLayout(False)
        Me.gb_principios_activos.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsOpciones.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlTipoProducto.ResumeLayout(False)
        Me.pnlreporte.ResumeLayout(False)
        Me.pnlreporte.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_articulo As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_data As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_familia As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_fab As System.Windows.Forms.TextBox
    Friend WithEvents txt_idfamilia As System.Windows.Forms.TextBox
    Friend WithEvents txt_um As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents txt_linea As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_linea As System.Windows.Forms.Label
    Friend WithEvents cmsOpciones As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtbuscarArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv_articulos As System.Windows.Forms.DataGridView
    Friend WithEvents cboLine As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboFamily As System.Windows.Forms.ComboBox
    Friend WithEvents cbopart_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblbuscar As System.Windows.Forms.Label
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
    Friend WithEvents lblTipoArticulo As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txttipoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtUnidMedRef As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtPresComercial As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtdecComercial As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPresMMedica As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtPartidaArancelaria As System.Windows.Forms.TextBox
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbServicio As System.Windows.Forms.RadioButton
    Friend WithEvents rbLibre As System.Windows.Forms.RadioButton
    Friend WithEvents rbStockLote As System.Windows.Forms.RadioButton
    Friend WithEvents rbStockSerie As System.Windows.Forms.RadioButton
    Friend WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GBmuestraMedica As System.Windows.Forms.GroupBox
    Friend WithEvents btnMuestraMedica As System.Windows.Forms.Button
    Friend WithEvents btnMuestraGranel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtDescripcionClaseArt As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoClaseArt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents optproductosgranel As System.Windows.Forms.RadioButton
    Friend WithEvents optmuestramedica As System.Windows.Forms.RadioButton
    Friend WithEvents opttodos As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_precio As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Descuentos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbo_clase_terapeutica As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents checkLineas As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtcuentaVenta As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcompra As System.Windows.Forms.Label
    Friend WithEvents txtCuentaCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaInventario As System.Windows.Forms.TextBox
    Friend WithEvents btnproductopiloto As System.Windows.Forms.Button
    Friend WithEvents txtunidadrefdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtunidaddesc As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents pb_img As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents col_img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pnlTipoProducto As System.Windows.Forms.Panel
    Friend WithEvents cboTipoPart As System.Windows.Forms.ComboBox
    Friend WithEvents pnlreporte As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cboFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents txtcodigo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion1 As System.Windows.Forms.Label
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rblinea As System.Windows.Forms.RadioButton
    Friend WithEvents rbtipoarticulo As System.Windows.Forms.RadioButton
    Friend WithEvents rbfamilia As System.Windows.Forms.RadioButton
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents gb_principios_activos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txt_des_principio_activo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_principio_activo As System.Windows.Forms.TextBox
    Friend WithEvents cbo_condicion_venta As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cbo_forma_farmaceutica As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cbo_norma_tecnica As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ID_FAB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_FAMILY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_UOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_SERIES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_IS_STOCKED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_IS_LOT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_VAT_POR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_IS_VAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_AII As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ACCOUNT_INV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ACCOUNT_PAY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ISCPOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_TIPOISC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_LINEA_MEDICA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_TYPE_PART As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_TIPO_ARTICULO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRESS_COMERCIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REG_SANITARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnl_pt As System.Windows.Forms.Panel
    Friend WithEvents cbo_estado_rs As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtp_vcto_reg_sanit As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_vigencia_lot As System.Windows.Forms.TextBox
    Friend WithEvents txt_vig_reg_sanit As System.Windows.Forms.TextBox
    Friend WithEvents txtpesoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtClase As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txt_nro_reg_sanit As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtTalla As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_num_regsanit As System.Windows.Forms.TextBox
    Friend WithEvents btn_add_regsanit As System.Windows.Forms.Button
    Friend WithEvents btn_del_regsanit As System.Windows.Forms.Button
    Friend WithEvents dgv_incripciones_regsanit As System.Windows.Forms.DataGridView
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents DTP_FEC_VCTO_REG_SANIT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents DTP_FEC_EMI_REG_SANIT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents dtp_fec_vcto_norma_tec As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents dtp_fec_emi_norma_tecnica As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_norma_tec As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_articulo_dos As System.Windows.Forms.TextBox
    Friend WithEvents chk_prod_controlado As System.Windows.Forms.CheckBox
    Friend WithEvents gb_tipo_prod_controlado As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_tipo_prod_controlado As System.Windows.Forms.ComboBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_mat_empaque As System.Windows.Forms.ComboBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Tool_Precio_Mat_Empaque As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcapacidad As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionpres As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcodigopres As System.Windows.Forms.TextBox
    Friend WithEvents TXTPRODUCCIONDESC As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents txtProduccion As System.Windows.Forms.TextBox
    Friend WithEvents chkProduccion As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chklstLineas As System.Windows.Forms.CheckedListBox
    Friend WithEvents txt_tipo_origen_desc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo_origen As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txt_11 As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txt_10 As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents txt_9 As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txt_8 As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txt_7 As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txt_6 As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txt_5 As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txt_4 As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txt_3 As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txt_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents gb_datos_logisticos As System.Windows.Forms.GroupBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txt_stock_maximo As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txt_punto_pedido As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txt_stock_minimo As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txt_des_lina_produccion As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_linea_produccion As System.Windows.Forms.TextBox
    Friend WithEvents btn_Adicionales As System.Windows.Forms.ToolStripButton
End Class
