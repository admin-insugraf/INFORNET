<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_MA_Activo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_MA_Activo))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tc_mante_activo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.dgv_Lista = New System.Windows.Forms.DataGridView()
        Me.AC_IDACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AC_ACTIVO_DES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AC_FECHA_INI_OPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA_DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_principal = New System.Windows.Forms.GroupBox()
        Me.cmb_responsable = New System.Windows.Forms.ComboBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cmb_origen_req = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_autoriza_adq = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_orden_compra = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txt_cotizacion = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txt_tasa = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txt_des_activo_principal = New System.Windows.Forms.TextBox()
        Me.txt_idactivo_principal = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.chk_mejora = New System.Windows.Forms.CheckBox()
        Me.mtb_idoc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_valor_residual = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txt_tc = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_cod_barra = New System.Windows.Forms.TextBox()
        Me.txt_num_placa = New System.Windows.Forms.TextBox()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.mtb_fec_ini_ope = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fdoc = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fec_compra = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_uso = New System.Windows.Forms.ComboBox()
        Me.cmb_nivel_obs = New System.Windows.Forms.ComboBox()
        Me.cmb_clase = New System.Windows.Forms.ComboBox()
        Me.cmb_est_fis = New System.Windows.Forms.ComboBox()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.cmb_cc = New System.Windows.Forms.ComboBox()
        Me.cmb_ubicacion = New System.Windows.Forms.ComboBox()
        Me.cmb_tip_pago = New System.Windows.Forms.ComboBox()
        Me.cmb_subgrupo = New System.Windows.Forms.ComboBox()
        Me.cmb_prove = New System.Windows.Forms.ComboBox()
        Me.cmb_tdoc = New System.Windows.Forms.ComboBox()
        Me.cmb_grupo = New System.Windows.Forms.ComboBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.cmb_familia = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_ndoc = New System.Windows.Forms.TextBox()
        Me.txt_sdoc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cod_alt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_ver_doc = New System.Windows.Forms.Button()
        Me.btn_quitar_doc = New System.Windows.Forms.Button()
        Me.btn_agregar_fic = New System.Windows.Forms.Button()
        Me.dgv_ficha_tec = New System.Windows.Forms.DataGridView()
        Me.col_dsec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_dArc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ddoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.pb_img = New System.Windows.Forms.PictureBox()
        Me.dgv_img = New System.Windows.Forms.DataGridView()
        Me.col_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.gb_otros = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txt_tasa_parti = New System.Windows.Forms.TextBox()
        Me.txt_depre_ini = New System.Windows.Forms.TextBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.gb_mante = New System.Windows.Forms.GroupBox()
        Me.mtb_fec_vcto_con = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fec_vcto_garan = New System.Windows.Forms.MaskedTextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_perioricidad = New System.Windows.Forms.TextBox()
        Me.txt_num_con = New System.Windows.Forms.TextBox()
        Me.txt_meses_garan = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.gb_leasing = New System.Windows.Forms.GroupBox()
        Me.mtb_fec_arren = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fec_con = New System.Windows.Forms.MaskedTextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_num_cuotas = New System.Windows.Forms.TextBox()
        Me.txt_meses = New System.Windows.Forms.TextBox()
        Me.txt_anho = New System.Windows.Forms.TextBox()
        Me.txt_lea_total = New System.Windows.Forms.TextBox()
        Me.txt_num_contrato = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.tc_mante_activo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_principal.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_ficha_tec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_otros.SuspendLayout()
        Me.gb_mante.SuspendLayout()
        Me.gb_leasing.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.LightGray
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.toolStripSeparator5, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator7})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(797, 25)
        Me.ToolS_Mantenimiento.TabIndex = 8
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Nuevo.Image = Global.LibActivo.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = CType(resources.GetObject("Tool_Grabar.Image"), System.Drawing.Image)
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = CType(resources.GetObject("Tool_Editar.Image"), System.Drawing.Image)
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.LibActivo.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.LibActivo.My.Resources.Resources._16__Delete_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        Me.Tool_Eliminar.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.LibActivo.My.Resources.Resources._16__Exit_
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'tool_Ayuda2
        '
        Me.tool_Ayuda2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tool_Ayuda2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tool_Ayuda2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_Ayuda2.Name = "tool_Ayuda2"
        Me.tool_Ayuda2.Size = New System.Drawing.Size(23, 22)
        Me.tool_Ayuda2.Text = "Acerca de las Cuentas Tipo"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tc_mante_activo
        '
        Me.tc_mante_activo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_mante_activo.Controls.Add(Me.TabPage1)
        Me.tc_mante_activo.Controls.Add(Me.TabPage2)
        Me.tc_mante_activo.Controls.Add(Me.TabPage3)
        Me.tc_mante_activo.Location = New System.Drawing.Point(13, 28)
        Me.tc_mante_activo.Name = "tc_mante_activo"
        Me.tc_mante_activo.SelectedIndex = 0
        Me.tc_mante_activo.Size = New System.Drawing.Size(773, 436)
        Me.tc_mante_activo.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_filtro)
        Me.TabPage1.Controls.Add(Me.Label44)
        Me.TabPage1.Controls.Add(Me.dgv_Lista)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(765, 410)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Activos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(64, 28)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(312, 20)
        Me.txt_filtro.TabIndex = 3
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(18, 31)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(40, 13)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Buscar"
        '
        'dgv_Lista
        '
        Me.dgv_Lista.AllowUserToAddRows = False
        Me.dgv_Lista.AllowUserToDeleteRows = False
        Me.dgv_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AC_IDACTIVO, Me.AC_ACTIVO_DES, Me.AC_FECHA_INI_OPE, Me.FA_DESCRIPCION})
        Me.dgv_Lista.Location = New System.Drawing.Point(6, 54)
        Me.dgv_Lista.Name = "dgv_Lista"
        Me.dgv_Lista.ReadOnly = True
        Me.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lista.Size = New System.Drawing.Size(753, 350)
        Me.dgv_Lista.TabIndex = 0
        '
        'AC_IDACTIVO
        '
        Me.AC_IDACTIVO.DataPropertyName = "AC_IDACTIVO"
        Me.AC_IDACTIVO.HeaderText = "Codigo"
        Me.AC_IDACTIVO.Name = "AC_IDACTIVO"
        Me.AC_IDACTIVO.ReadOnly = True
        '
        'AC_ACTIVO_DES
        '
        Me.AC_ACTIVO_DES.DataPropertyName = "AC_ACTIVO_DES"
        Me.AC_ACTIVO_DES.HeaderText = "Descripcion"
        Me.AC_ACTIVO_DES.Name = "AC_ACTIVO_DES"
        Me.AC_ACTIVO_DES.ReadOnly = True
        Me.AC_ACTIVO_DES.Width = 450
        '
        'AC_FECHA_INI_OPE
        '
        Me.AC_FECHA_INI_OPE.DataPropertyName = "AC_FECHA_INI_OPE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AC_FECHA_INI_OPE.DefaultCellStyle = DataGridViewCellStyle2
        Me.AC_FECHA_INI_OPE.HeaderText = "Fec. Ini. Operaciones"
        Me.AC_FECHA_INI_OPE.Name = "AC_FECHA_INI_OPE"
        Me.AC_FECHA_INI_OPE.ReadOnly = True
        '
        'FA_DESCRIPCION
        '
        Me.FA_DESCRIPCION.DataPropertyName = "FA_DESCRIPCION"
        Me.FA_DESCRIPCION.HeaderText = "Familia"
        Me.FA_DESCRIPCION.Name = "FA_DESCRIPCION"
        Me.FA_DESCRIPCION.ReadOnly = True
        Me.FA_DESCRIPCION.Width = 150
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_principal)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(765, 410)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_principal
        '
        Me.gb_principal.Controls.Add(Me.cmb_responsable)
        Me.gb_principal.Controls.Add(Me.Label53)
        Me.gb_principal.Controls.Add(Me.cmb_origen_req)
        Me.gb_principal.Controls.Add(Me.Label52)
        Me.gb_principal.Controls.Add(Me.txt_autoriza_adq)
        Me.gb_principal.Controls.Add(Me.Label51)
        Me.gb_principal.Controls.Add(Me.txt_orden_compra)
        Me.gb_principal.Controls.Add(Me.Label50)
        Me.gb_principal.Controls.Add(Me.txt_cotizacion)
        Me.gb_principal.Controls.Add(Me.Label49)
        Me.gb_principal.Controls.Add(Me.txt_tasa)
        Me.gb_principal.Controls.Add(Me.Label46)
        Me.gb_principal.Controls.Add(Me.txt_des_activo_principal)
        Me.gb_principal.Controls.Add(Me.txt_idactivo_principal)
        Me.gb_principal.Controls.Add(Me.Label45)
        Me.gb_principal.Controls.Add(Me.chk_mejora)
        Me.gb_principal.Controls.Add(Me.mtb_idoc)
        Me.gb_principal.Controls.Add(Me.txt_valor_residual)
        Me.gb_principal.Controls.Add(Me.Label43)
        Me.gb_principal.Controls.Add(Me.txt_tc)
        Me.gb_principal.Controls.Add(Me.txt_modelo)
        Me.gb_principal.Controls.Add(Me.txt_cod_barra)
        Me.gb_principal.Controls.Add(Me.txt_num_placa)
        Me.gb_principal.Controls.Add(Me.txt_serie)
        Me.gb_principal.Controls.Add(Me.cmb_marca)
        Me.gb_principal.Controls.Add(Me.mtb_fec_ini_ope)
        Me.gb_principal.Controls.Add(Me.mtb_fdoc)
        Me.gb_principal.Controls.Add(Me.mtb_fec_compra)
        Me.gb_principal.Controls.Add(Me.cmb_uso)
        Me.gb_principal.Controls.Add(Me.cmb_nivel_obs)
        Me.gb_principal.Controls.Add(Me.cmb_clase)
        Me.gb_principal.Controls.Add(Me.cmb_est_fis)
        Me.gb_principal.Controls.Add(Me.cmb_area)
        Me.gb_principal.Controls.Add(Me.cmb_cc)
        Me.gb_principal.Controls.Add(Me.cmb_ubicacion)
        Me.gb_principal.Controls.Add(Me.cmb_tip_pago)
        Me.gb_principal.Controls.Add(Me.cmb_subgrupo)
        Me.gb_principal.Controls.Add(Me.cmb_prove)
        Me.gb_principal.Controls.Add(Me.cmb_tdoc)
        Me.gb_principal.Controls.Add(Me.cmb_grupo)
        Me.gb_principal.Controls.Add(Me.cmb_moneda)
        Me.gb_principal.Controls.Add(Me.cmb_familia)
        Me.gb_principal.Controls.Add(Me.Label31)
        Me.gb_principal.Controls.Add(Me.Label30)
        Me.gb_principal.Controls.Add(Me.Label35)
        Me.gb_principal.Controls.Add(Me.Label23)
        Me.gb_principal.Controls.Add(Me.Label21)
        Me.gb_principal.Controls.Add(Me.Label20)
        Me.gb_principal.Controls.Add(Me.txt_ndoc)
        Me.gb_principal.Controls.Add(Me.txt_sdoc)
        Me.gb_principal.Controls.Add(Me.Label19)
        Me.gb_principal.Controls.Add(Me.Label15)
        Me.gb_principal.Controls.Add(Me.Label12)
        Me.gb_principal.Controls.Add(Me.Label29)
        Me.gb_principal.Controls.Add(Me.Label18)
        Me.gb_principal.Controls.Add(Me.Label14)
        Me.gb_principal.Controls.Add(Me.Label36)
        Me.gb_principal.Controls.Add(Me.Label28)
        Me.gb_principal.Controls.Add(Me.Label22)
        Me.gb_principal.Controls.Add(Me.Label11)
        Me.gb_principal.Controls.Add(Me.Label17)
        Me.gb_principal.Controls.Add(Me.Label13)
        Me.gb_principal.Controls.Add(Me.Label10)
        Me.gb_principal.Controls.Add(Me.Label9)
        Me.gb_principal.Controls.Add(Me.Label8)
        Me.gb_principal.Controls.Add(Me.Label4)
        Me.gb_principal.Controls.Add(Me.txt_cod_alt)
        Me.gb_principal.Controls.Add(Me.Label7)
        Me.gb_principal.Controls.Add(Me.txt_descripcion)
        Me.gb_principal.Controls.Add(Me.Label6)
        Me.gb_principal.Controls.Add(Me.Label2)
        Me.gb_principal.Controls.Add(Me.Label3)
        Me.gb_principal.Controls.Add(Me.Label5)
        Me.gb_principal.Controls.Add(Me.txt_codigo)
        Me.gb_principal.Controls.Add(Me.Label1)
        Me.gb_principal.Location = New System.Drawing.Point(6, 6)
        Me.gb_principal.Name = "gb_principal"
        Me.gb_principal.Size = New System.Drawing.Size(753, 398)
        Me.gb_principal.TabIndex = 0
        Me.gb_principal.TabStop = False
        Me.gb_principal.Text = "Datos Principales"
        '
        'cmb_responsable
        '
        Me.cmb_responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_responsable.FormattingEnabled = True
        Me.cmb_responsable.Location = New System.Drawing.Point(459, 214)
        Me.cmb_responsable.Name = "cmb_responsable"
        Me.cmb_responsable.Size = New System.Drawing.Size(274, 21)
        Me.cmb_responsable.TabIndex = 45
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(384, 217)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(69, 13)
        Me.Label53.TabIndex = 44
        Me.Label53.Text = "Responsable"
        '
        'cmb_origen_req
        '
        Me.cmb_origen_req.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_origen_req.FormattingEnabled = True
        Me.cmb_origen_req.Location = New System.Drawing.Point(94, 185)
        Me.cmb_origen_req.Name = "cmb_origen_req"
        Me.cmb_origen_req.Size = New System.Drawing.Size(192, 21)
        Me.cmb_origen_req.TabIndex = 43
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label52.Location = New System.Drawing.Point(24, 185)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(64, 13)
        Me.Label52.TabIndex = 42
        Me.Label52.Text = "Origen Req."
        '
        'txt_autoriza_adq
        '
        Me.txt_autoriza_adq.Location = New System.Drawing.Point(459, 185)
        Me.txt_autoriza_adq.Name = "txt_autoriza_adq"
        Me.txt_autoriza_adq.Size = New System.Drawing.Size(274, 20)
        Me.txt_autoriza_adq.TabIndex = 41
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label51.Location = New System.Drawing.Point(385, 188)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(70, 13)
        Me.Label51.TabIndex = 40
        Me.Label51.Text = "Autoriza Adq."
        '
        'txt_orden_compra
        '
        Me.txt_orden_compra.Location = New System.Drawing.Point(636, 162)
        Me.txt_orden_compra.Name = "txt_orden_compra"
        Me.txt_orden_compra.Size = New System.Drawing.Size(97, 20)
        Me.txt_orden_compra.TabIndex = 39
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(566, 165)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(66, 13)
        Me.Label50.TabIndex = 38
        Me.Label50.Text = "Ord. Compra"
        '
        'txt_cotizacion
        '
        Me.txt_cotizacion.Location = New System.Drawing.Point(459, 162)
        Me.txt_cotizacion.Name = "txt_cotizacion"
        Me.txt_cotizacion.Size = New System.Drawing.Size(88, 20)
        Me.txt_cotizacion.TabIndex = 37
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(399, 165)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(56, 13)
        Me.Label49.TabIndex = 36
        Me.Label49.Text = "Cotizacion"
        '
        'txt_tasa
        '
        Me.txt_tasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tasa.Location = New System.Drawing.Point(342, 118)
        Me.txt_tasa.Name = "txt_tasa"
        Me.txt_tasa.ReadOnly = True
        Me.txt_tasa.Size = New System.Drawing.Size(37, 20)
        Me.txt_tasa.TabIndex = 35
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(256, 121)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(80, 13)
        Me.Label46.TabIndex = 34
        Me.Label46.Text = "Tasa Deprec.%"
        '
        'txt_des_activo_principal
        '
        Me.txt_des_activo_principal.Location = New System.Drawing.Point(315, 164)
        Me.txt_des_activo_principal.Name = "txt_des_activo_principal"
        Me.txt_des_activo_principal.Size = New System.Drawing.Size(36, 20)
        Me.txt_des_activo_principal.TabIndex = 33
        Me.txt_des_activo_principal.Visible = False
        '
        'txt_idactivo_principal
        '
        Me.txt_idactivo_principal.Location = New System.Drawing.Point(281, 164)
        Me.txt_idactivo_principal.Name = "txt_idactivo_principal"
        Me.txt_idactivo_principal.Size = New System.Drawing.Size(28, 20)
        Me.txt_idactivo_principal.TabIndex = 31
        Me.txt_idactivo_principal.Visible = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(198, 163)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 13)
        Me.Label45.TabIndex = 32
        Me.Label45.Text = "Activo Principal"
        Me.Label45.Visible = False
        '
        'chk_mejora
        '
        Me.chk_mejora.AutoSize = True
        Me.chk_mejora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_mejora.Location = New System.Drawing.Point(206, 141)
        Me.chk_mejora.Name = "chk_mejora"
        Me.chk_mejora.Size = New System.Drawing.Size(116, 17)
        Me.chk_mejora.TabIndex = 30
        Me.chk_mejora.Text = "Mejora o Adiciones"
        Me.chk_mejora.UseVisualStyleBackColor = True
        Me.chk_mejora.Visible = False
        '
        'mtb_idoc
        '
        Me.mtb_idoc.Location = New System.Drawing.Point(607, 93)
        Me.mtb_idoc.Name = "mtb_idoc"
        Me.mtb_idoc.Size = New System.Drawing.Size(126, 20)
        Me.mtb_idoc.TabIndex = 12
        '
        'txt_valor_residual
        '
        Me.txt_valor_residual.Location = New System.Drawing.Point(94, 162)
        Me.txt_valor_residual.Name = "txt_valor_residual"
        Me.txt_valor_residual.Size = New System.Drawing.Size(98, 20)
        Me.txt_valor_residual.TabIndex = 6
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(15, 165)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(75, 13)
        Me.Label43.TabIndex = 11
        Me.Label43.Text = "Valor Residual"
        '
        'txt_tc
        '
        Me.txt_tc.Location = New System.Drawing.Point(668, 116)
        Me.txt_tc.Name = "txt_tc"
        Me.txt_tc.Size = New System.Drawing.Size(65, 20)
        Me.txt_tc.TabIndex = 14
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(92, 297)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(192, 20)
        Me.txt_modelo.TabIndex = 19
        '
        'txt_cod_barra
        '
        Me.txt_cod_barra.Location = New System.Drawing.Point(92, 360)
        Me.txt_cod_barra.Name = "txt_cod_barra"
        Me.txt_cod_barra.Size = New System.Drawing.Size(192, 20)
        Me.txt_cod_barra.TabIndex = 22
        '
        'txt_num_placa
        '
        Me.txt_num_placa.Location = New System.Drawing.Point(92, 339)
        Me.txt_num_placa.Name = "txt_num_placa"
        Me.txt_num_placa.Size = New System.Drawing.Size(192, 20)
        Me.txt_num_placa.TabIndex = 21
        '
        'txt_serie
        '
        Me.txt_serie.Location = New System.Drawing.Point(92, 318)
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(192, 20)
        Me.txt_serie.TabIndex = 20
        '
        'cmb_marca
        '
        Me.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(92, 275)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(192, 21)
        Me.cmb_marca.TabIndex = 18
        '
        'mtb_fec_ini_ope
        '
        Me.mtb_fec_ini_ope.Location = New System.Drawing.Point(94, 139)
        Me.mtb_fec_ini_ope.Mask = "00/00/0000"
        Me.mtb_fec_ini_ope.Name = "mtb_fec_ini_ope"
        Me.mtb_fec_ini_ope.Size = New System.Drawing.Size(88, 20)
        Me.mtb_fec_ini_ope.TabIndex = 5
        Me.mtb_fec_ini_ope.ValidatingType = GetType(Date)
        '
        'mtb_fdoc
        '
        Me.mtb_fdoc.Location = New System.Drawing.Point(459, 93)
        Me.mtb_fdoc.Mask = "00/00/0000"
        Me.mtb_fdoc.Name = "mtb_fdoc"
        Me.mtb_fdoc.Size = New System.Drawing.Size(88, 20)
        Me.mtb_fdoc.TabIndex = 11
        Me.mtb_fdoc.ValidatingType = GetType(Date)
        '
        'mtb_fec_compra
        '
        Me.mtb_fec_compra.Location = New System.Drawing.Point(94, 118)
        Me.mtb_fec_compra.Mask = "00/00/0000"
        Me.mtb_fec_compra.Name = "mtb_fec_compra"
        Me.mtb_fec_compra.Size = New System.Drawing.Size(88, 20)
        Me.mtb_fec_compra.TabIndex = 4
        Me.mtb_fec_compra.ValidatingType = GetType(Date)
        '
        'cmb_uso
        '
        Me.cmb_uso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_uso.FormattingEnabled = True
        Me.cmb_uso.Location = New System.Drawing.Point(459, 324)
        Me.cmb_uso.Name = "cmb_uso"
        Me.cmb_uso.Size = New System.Drawing.Size(274, 21)
        Me.cmb_uso.TabIndex = 27
        '
        'cmb_nivel_obs
        '
        Me.cmb_nivel_obs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nivel_obs.FormattingEnabled = True
        Me.cmb_nivel_obs.Location = New System.Drawing.Point(459, 346)
        Me.cmb_nivel_obs.Name = "cmb_nivel_obs"
        Me.cmb_nivel_obs.Size = New System.Drawing.Size(274, 21)
        Me.cmb_nivel_obs.TabIndex = 28
        '
        'cmb_clase
        '
        Me.cmb_clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_clase.FormattingEnabled = True
        Me.cmb_clase.Location = New System.Drawing.Point(459, 302)
        Me.cmb_clase.Name = "cmb_clase"
        Me.cmb_clase.Size = New System.Drawing.Size(274, 21)
        Me.cmb_clase.TabIndex = 26
        '
        'cmb_est_fis
        '
        Me.cmb_est_fis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_est_fis.FormattingEnabled = True
        Me.cmb_est_fis.Location = New System.Drawing.Point(459, 368)
        Me.cmb_est_fis.Name = "cmb_est_fis"
        Me.cmb_est_fis.Size = New System.Drawing.Size(274, 21)
        Me.cmb_est_fis.TabIndex = 29
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(459, 280)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(274, 21)
        Me.cmb_area.TabIndex = 25
        '
        'cmb_cc
        '
        Me.cmb_cc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cc.FormattingEnabled = True
        Me.cmb_cc.Location = New System.Drawing.Point(459, 258)
        Me.cmb_cc.Name = "cmb_cc"
        Me.cmb_cc.Size = New System.Drawing.Size(274, 21)
        Me.cmb_cc.TabIndex = 24
        '
        'cmb_ubicacion
        '
        Me.cmb_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ubicacion.FormattingEnabled = True
        Me.cmb_ubicacion.Location = New System.Drawing.Point(459, 236)
        Me.cmb_ubicacion.Name = "cmb_ubicacion"
        Me.cmb_ubicacion.Size = New System.Drawing.Size(274, 21)
        Me.cmb_ubicacion.TabIndex = 23
        '
        'cmb_tip_pago
        '
        Me.cmb_tip_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tip_pago.FormattingEnabled = True
        Me.cmb_tip_pago.Location = New System.Drawing.Point(459, 138)
        Me.cmb_tip_pago.Name = "cmb_tip_pago"
        Me.cmb_tip_pago.Size = New System.Drawing.Size(274, 21)
        Me.cmb_tip_pago.TabIndex = 15
        '
        'cmb_subgrupo
        '
        Me.cmb_subgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_subgrupo.FormattingEnabled = True
        Me.cmb_subgrupo.Location = New System.Drawing.Point(92, 253)
        Me.cmb_subgrupo.Name = "cmb_subgrupo"
        Me.cmb_subgrupo.Size = New System.Drawing.Size(192, 21)
        Me.cmb_subgrupo.TabIndex = 17
        '
        'cmb_prove
        '
        Me.cmb_prove.FormattingEnabled = True
        Me.cmb_prove.Location = New System.Drawing.Point(459, 28)
        Me.cmb_prove.Name = "cmb_prove"
        Me.cmb_prove.Size = New System.Drawing.Size(274, 21)
        Me.cmb_prove.TabIndex = 7
        '
        'cmb_tdoc
        '
        Me.cmb_tdoc.FormattingEnabled = True
        Me.cmb_tdoc.Location = New System.Drawing.Point(459, 50)
        Me.cmb_tdoc.Name = "cmb_tdoc"
        Me.cmb_tdoc.Size = New System.Drawing.Size(274, 21)
        Me.cmb_tdoc.TabIndex = 8
        '
        'cmb_grupo
        '
        Me.cmb_grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_grupo.FormattingEnabled = True
        Me.cmb_grupo.Location = New System.Drawing.Point(92, 231)
        Me.cmb_grupo.Name = "cmb_grupo"
        Me.cmb_grupo.Size = New System.Drawing.Size(192, 21)
        Me.cmb_grupo.TabIndex = 16
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(459, 116)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(138, 21)
        Me.cmb_moneda.TabIndex = 13
        '
        'cmb_familia
        '
        Me.cmb_familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_familia.FormattingEnabled = True
        Me.cmb_familia.Location = New System.Drawing.Point(94, 96)
        Me.cmb_familia.Name = "cmb_familia"
        Me.cmb_familia.Size = New System.Drawing.Size(285, 21)
        Me.cmb_familia.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(387, 260)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 13)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Centro Costo"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(20, 363)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 13)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Codigo Barra"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(402, 141)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 13)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Tip. Pago"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(429, 328)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 13)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Uso"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(385, 372)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Estado Fisico"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(606, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Tip. Camb."
        '
        'txt_ndoc
        '
        Me.txt_ndoc.Location = New System.Drawing.Point(519, 72)
        Me.txt_ndoc.Name = "txt_ndoc"
        Me.txt_ndoc.Size = New System.Drawing.Size(111, 20)
        Me.txt_ndoc.TabIndex = 10
        '
        'txt_sdoc
        '
        Me.txt_sdoc.Location = New System.Drawing.Point(459, 72)
        Me.txt_sdoc.Name = "txt_sdoc"
        Me.txt_sdoc.Size = New System.Drawing.Size(59, 20)
        Me.txt_sdoc.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(409, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Moneda"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(394, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Serie/Num."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(26, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Num. Placa"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(400, 242)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(55, 13)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Ubicacion"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(561, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Importe"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(404, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Tip. Doc."
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(426, 284)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(29, 13)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Area"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(391, 350)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Nivel Obsol."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(422, 307)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Clase"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(29, 321)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Num. Serie"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(401, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Fec. Doc."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(399, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Proveedor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(46, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Modelo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(51, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Marca"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(30, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Sub Grupo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(51, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Familia"
        '
        'txt_cod_alt
        '
        Me.txt_cod_alt.Location = New System.Drawing.Point(94, 54)
        Me.txt_cod_alt.Name = "txt_cod_alt"
        Me.txt_cod_alt.Size = New System.Drawing.Size(190, 20)
        Me.txt_cod_alt.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(19, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fec. Ini. Ope."
        '
        'txt_descripcion
        '
        Me.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descripcion.Location = New System.Drawing.Point(94, 75)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(285, 20)
        Me.txt_descripcion.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(52, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Grupo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cod. Altern."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(27, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fec. Compra"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(94, 33)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(126, 20)
        Me.txt_codigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(50, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.gb_otros)
        Me.TabPage3.Controls.Add(Me.gb_mante)
        Me.TabPage3.Controls.Add(Me.gb_leasing)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(765, 410)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Otros Datos..."
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_ver_doc)
        Me.GroupBox2.Controls.Add(Me.btn_quitar_doc)
        Me.GroupBox2.Controls.Add(Me.btn_agregar_fic)
        Me.GroupBox2.Controls.Add(Me.dgv_ficha_tec)
        Me.GroupBox2.Location = New System.Drawing.Point(475, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 191)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ficha Tecnica"
        '
        'btn_ver_doc
        '
        Me.btn_ver_doc.Location = New System.Drawing.Point(177, 10)
        Me.btn_ver_doc.Name = "btn_ver_doc"
        Me.btn_ver_doc.Size = New System.Drawing.Size(37, 23)
        Me.btn_ver_doc.TabIndex = 14
        Me.btn_ver_doc.Text = "Ver"
        Me.btn_ver_doc.UseVisualStyleBackColor = True
        '
        'btn_quitar_doc
        '
        Me.btn_quitar_doc.Location = New System.Drawing.Point(247, 10)
        Me.btn_quitar_doc.Name = "btn_quitar_doc"
        Me.btn_quitar_doc.Size = New System.Drawing.Size(22, 23)
        Me.btn_quitar_doc.TabIndex = 13
        Me.btn_quitar_doc.Text = "-"
        Me.btn_quitar_doc.UseVisualStyleBackColor = True
        '
        'btn_agregar_fic
        '
        Me.btn_agregar_fic.Location = New System.Drawing.Point(221, 10)
        Me.btn_agregar_fic.Name = "btn_agregar_fic"
        Me.btn_agregar_fic.Size = New System.Drawing.Size(22, 23)
        Me.btn_agregar_fic.TabIndex = 12
        Me.btn_agregar_fic.Text = "+"
        Me.btn_agregar_fic.UseVisualStyleBackColor = True
        '
        'dgv_ficha_tec
        '
        Me.dgv_ficha_tec.AllowUserToAddRows = False
        Me.dgv_ficha_tec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ficha_tec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_dsec, Me.col_dArc, Me.col_ddoc})
        Me.dgv_ficha_tec.Location = New System.Drawing.Point(6, 37)
        Me.dgv_ficha_tec.Name = "dgv_ficha_tec"
        Me.dgv_ficha_tec.Size = New System.Drawing.Size(265, 143)
        Me.dgv_ficha_tec.TabIndex = 0
        '
        'col_dsec
        '
        Me.col_dsec.HeaderText = "Sec."
        Me.col_dsec.Name = "col_dsec"
        Me.col_dsec.ReadOnly = True
        Me.col_dsec.Width = 30
        '
        'col_dArc
        '
        Me.col_dArc.HeaderText = "Archivo"
        Me.col_dArc.Name = "col_dArc"
        Me.col_dArc.ReadOnly = True
        '
        'col_ddoc
        '
        Me.col_ddoc.HeaderText = "Ficha"
        Me.col_ddoc.Name = "col_ddoc"
        Me.col_ddoc.ReadOnly = True
        Me.col_ddoc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_ddoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.btn_quitar)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.pb_img)
        Me.GroupBox1.Controls.Add(Me.dgv_img)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 191)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imagenes"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(314, 22)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(85, 13)
        Me.Label48.TabIndex = 17
        Me.Label48.Text = "Mini Vista Previa"
        '
        'btn_quitar
        '
        Me.btn_quitar.Location = New System.Drawing.Point(249, 11)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(22, 23)
        Me.btn_quitar.TabIndex = 11
        Me.btn_quitar.Text = "-"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(221, 11)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(22, 23)
        Me.btn_agregar.TabIndex = 10
        Me.btn_agregar.Text = "+"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'pb_img
        '
        Me.pb_img.Location = New System.Drawing.Point(277, 38)
        Me.pb_img.Name = "pb_img"
        Me.pb_img.Size = New System.Drawing.Size(173, 143)
        Me.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_img.TabIndex = 8
        Me.pb_img.TabStop = False
        '
        'dgv_img
        '
        Me.dgv_img.AllowUserToAddRows = False
        Me.dgv_img.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_img.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sec, Me.col_nom, Me.col_des, Me.col_fec, Me.col_img})
        Me.dgv_img.Location = New System.Drawing.Point(8, 38)
        Me.dgv_img.Name = "dgv_img"
        Me.dgv_img.Size = New System.Drawing.Size(265, 143)
        Me.dgv_img.TabIndex = 7
        '
        'col_sec
        '
        Me.col_sec.HeaderText = "Sec"
        Me.col_sec.Name = "col_sec"
        Me.col_sec.ReadOnly = True
        Me.col_sec.Width = 30
        '
        'col_nom
        '
        Me.col_nom.HeaderText = "Archivo"
        Me.col_nom.Name = "col_nom"
        Me.col_nom.ReadOnly = True
        Me.col_nom.Width = 70
        '
        'col_des
        '
        Me.col_des.HeaderText = "Descripcion"
        Me.col_des.Name = "col_des"
        Me.col_des.ReadOnly = True
        Me.col_des.Width = 70
        '
        'col_fec
        '
        Me.col_fec.HeaderText = "fecha"
        Me.col_fec.Name = "col_fec"
        Me.col_fec.ReadOnly = True
        Me.col_fec.Width = 50
        '
        'col_img
        '
        Me.col_img.HeaderText = "Img"
        Me.col_img.Name = "col_img"
        Me.col_img.ReadOnly = True
        '
        'gb_otros
        '
        Me.gb_otros.Controls.Add(Me.Label47)
        Me.gb_otros.Controls.Add(Me.txt_tasa_parti)
        Me.gb_otros.Controls.Add(Me.txt_depre_ini)
        Me.gb_otros.Controls.Add(Me.txt_obs)
        Me.gb_otros.Controls.Add(Me.Label32)
        Me.gb_otros.Controls.Add(Me.Label42)
        Me.gb_otros.Controls.Add(Me.Label41)
        Me.gb_otros.Location = New System.Drawing.Point(553, 12)
        Me.gb_otros.Name = "gb_otros"
        Me.gb_otros.Size = New System.Drawing.Size(202, 161)
        Me.gb_otros.TabIndex = 6
        Me.gb_otros.TabStop = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(142, 38)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(15, 13)
        Me.Label47.TabIndex = 7
        Me.Label47.Text = "%"
        '
        'txt_tasa_parti
        '
        Me.txt_tasa_parti.Location = New System.Drawing.Point(95, 35)
        Me.txt_tasa_parti.Name = "txt_tasa_parti"
        Me.txt_tasa_parti.Size = New System.Drawing.Size(41, 20)
        Me.txt_tasa_parti.TabIndex = 1
        '
        'txt_depre_ini
        '
        Me.txt_depre_ini.Location = New System.Drawing.Point(95, 14)
        Me.txt_depre_ini.Name = "txt_depre_ini"
        Me.txt_depre_ini.Size = New System.Drawing.Size(98, 20)
        Me.txt_depre_ini.TabIndex = 0
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(11, 88)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(182, 67)
        Me.txt_obs.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(8, 72)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(78, 13)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "Observaciones"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(11, 38)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(78, 13)
        Me.Label42.TabIndex = 5
        Me.Label42.Text = "Tasa Particular"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(14, 17)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(75, 13)
        Me.Label41.TabIndex = 6
        Me.Label41.Text = "Deprec. Inicial"
        '
        'gb_mante
        '
        Me.gb_mante.Controls.Add(Me.mtb_fec_vcto_con)
        Me.gb_mante.Controls.Add(Me.mtb_fec_vcto_garan)
        Me.gb_mante.Controls.Add(Me.Label40)
        Me.gb_mante.Controls.Add(Me.Label34)
        Me.gb_mante.Controls.Add(Me.txt_perioricidad)
        Me.gb_mante.Controls.Add(Me.txt_num_con)
        Me.gb_mante.Controls.Add(Me.txt_meses_garan)
        Me.gb_mante.Controls.Add(Me.Label27)
        Me.gb_mante.Controls.Add(Me.Label16)
        Me.gb_mante.Controls.Add(Me.Label33)
        Me.gb_mante.Location = New System.Drawing.Point(290, 12)
        Me.gb_mante.Name = "gb_mante"
        Me.gb_mante.Size = New System.Drawing.Size(259, 162)
        Me.gb_mante.TabIndex = 1
        Me.gb_mante.TabStop = False
        Me.gb_mante.Text = "Mantenimiento"
        '
        'mtb_fec_vcto_con
        '
        Me.mtb_fec_vcto_con.Location = New System.Drawing.Point(114, 106)
        Me.mtb_fec_vcto_con.Mask = "00/00/0000"
        Me.mtb_fec_vcto_con.Name = "mtb_fec_vcto_con"
        Me.mtb_fec_vcto_con.Size = New System.Drawing.Size(129, 20)
        Me.mtb_fec_vcto_con.TabIndex = 4
        Me.mtb_fec_vcto_con.ValidatingType = GetType(Date)
        '
        'mtb_fec_vcto_garan
        '
        Me.mtb_fec_vcto_garan.Location = New System.Drawing.Point(114, 43)
        Me.mtb_fec_vcto_garan.Mask = "00/00/0000"
        Me.mtb_fec_vcto_garan.Name = "mtb_fec_vcto_garan"
        Me.mtb_fec_vcto_garan.Size = New System.Drawing.Size(129, 20)
        Me.mtb_fec_vcto_garan.TabIndex = 1
        Me.mtb_fec_vcto_garan.ValidatingType = GetType(Date)
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(30, 67)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(75, 13)
        Me.Label40.TabIndex = 15
        Me.Label40.Text = "Num. Contrato"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(27, 25)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(81, 13)
        Me.Label34.TabIndex = 14
        Me.Label34.Text = "Meses Garantia"
        '
        'txt_perioricidad
        '
        Me.txt_perioricidad.Location = New System.Drawing.Point(114, 85)
        Me.txt_perioricidad.Name = "txt_perioricidad"
        Me.txt_perioricidad.Size = New System.Drawing.Size(83, 20)
        Me.txt_perioricidad.TabIndex = 3
        '
        'txt_num_con
        '
        Me.txt_num_con.Location = New System.Drawing.Point(114, 64)
        Me.txt_num_con.Name = "txt_num_con"
        Me.txt_num_con.Size = New System.Drawing.Size(129, 20)
        Me.txt_num_con.TabIndex = 2
        '
        'txt_meses_garan
        '
        Me.txt_meses_garan.Location = New System.Drawing.Point(114, 22)
        Me.txt_meses_garan.Name = "txt_meses_garan"
        Me.txt_meses_garan.Size = New System.Drawing.Size(45, 20)
        Me.txt_meses_garan.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 109)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(99, 13)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Fec. Vcto. Contrato"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Perioricidad Dias"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(9, 47)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(99, 13)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Fec. Vcto. Garantia"
        '
        'gb_leasing
        '
        Me.gb_leasing.Controls.Add(Me.mtb_fec_arren)
        Me.gb_leasing.Controls.Add(Me.mtb_fec_con)
        Me.gb_leasing.Controls.Add(Me.Label39)
        Me.gb_leasing.Controls.Add(Me.Label38)
        Me.gb_leasing.Controls.Add(Me.Label26)
        Me.gb_leasing.Controls.Add(Me.txt_num_cuotas)
        Me.gb_leasing.Controls.Add(Me.txt_meses)
        Me.gb_leasing.Controls.Add(Me.txt_anho)
        Me.gb_leasing.Controls.Add(Me.txt_lea_total)
        Me.gb_leasing.Controls.Add(Me.txt_num_contrato)
        Me.gb_leasing.Controls.Add(Me.Label37)
        Me.gb_leasing.Controls.Add(Me.Label25)
        Me.gb_leasing.Controls.Add(Me.Label24)
        Me.gb_leasing.Location = New System.Drawing.Point(17, 12)
        Me.gb_leasing.Name = "gb_leasing"
        Me.gb_leasing.Size = New System.Drawing.Size(269, 162)
        Me.gb_leasing.TabIndex = 0
        Me.gb_leasing.TabStop = False
        Me.gb_leasing.Text = "Leasing"
        '
        'mtb_fec_arren
        '
        Me.mtb_fec_arren.Location = New System.Drawing.Point(95, 128)
        Me.mtb_fec_arren.Mask = "00/00/0000"
        Me.mtb_fec_arren.Name = "mtb_fec_arren"
        Me.mtb_fec_arren.Size = New System.Drawing.Size(123, 20)
        Me.mtb_fec_arren.TabIndex = 6
        Me.mtb_fec_arren.ValidatingType = GetType(Date)
        '
        'mtb_fec_con
        '
        Me.mtb_fec_con.Location = New System.Drawing.Point(95, 43)
        Me.mtb_fec_con.Mask = "00/00/0000"
        Me.mtb_fec_con.Name = "mtb_fec_con"
        Me.mtb_fec_con.Size = New System.Drawing.Size(123, 20)
        Me.mtb_fec_con.TabIndex = 1
        Me.mtb_fec_con.ValidatingType = GetType(Date)
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(23, 130)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(68, 13)
        Me.Label39.TabIndex = 16
        Me.Label39.Text = "Fec. Arrenda"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(16, 25)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(75, 13)
        Me.Label38.TabIndex = 17
        Me.Label38.Text = "Num. Contrato"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(27, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Monto Total"
        '
        'txt_num_cuotas
        '
        Me.txt_num_cuotas.Location = New System.Drawing.Point(95, 64)
        Me.txt_num_cuotas.Name = "txt_num_cuotas"
        Me.txt_num_cuotas.Size = New System.Drawing.Size(45, 20)
        Me.txt_num_cuotas.TabIndex = 2
        '
        'txt_meses
        '
        Me.txt_meses.Location = New System.Drawing.Point(143, 106)
        Me.txt_meses.Name = "txt_meses"
        Me.txt_meses.Size = New System.Drawing.Size(45, 20)
        Me.txt_meses.TabIndex = 5
        '
        'txt_anho
        '
        Me.txt_anho.Location = New System.Drawing.Point(95, 106)
        Me.txt_anho.Name = "txt_anho"
        Me.txt_anho.Size = New System.Drawing.Size(45, 20)
        Me.txt_anho.TabIndex = 4
        '
        'txt_lea_total
        '
        Me.txt_lea_total.Location = New System.Drawing.Point(95, 85)
        Me.txt_lea_total.Name = "txt_lea_total"
        Me.txt_lea_total.Size = New System.Drawing.Size(123, 20)
        Me.txt_lea_total.TabIndex = 3
        '
        'txt_num_contrato
        '
        Me.txt_num_contrato.Location = New System.Drawing.Point(95, 22)
        Me.txt_num_contrato.Name = "txt_num_contrato"
        Me.txt_num_contrato.Size = New System.Drawing.Size(168, 20)
        Me.txt_num_contrato.TabIndex = 0
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(20, 46)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(71, 13)
        Me.Label37.TabIndex = 11
        Me.Label37.Text = "Fec. Contrato"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(18, 109)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 13)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Años / Meses"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(23, 67)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 13)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "Num. Cuotas"
        '
        'frm_AF_MA_Activo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 476)
        Me.Controls.Add(Me.tc_mante_activo)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_MA_Activo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Activos"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.tc_mante_activo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_principal.ResumeLayout(False)
        Me.gb_principal.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_ficha_tec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_otros.ResumeLayout(False)
        Me.gb_otros.PerformLayout()
        Me.gb_mante.ResumeLayout(False)
        Me.gb_mante.PerformLayout()
        Me.gb_leasing.ResumeLayout(False)
        Me.gb_leasing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tc_mante_activo As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_principal As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_sdoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_alt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mtb_fec_ini_ope As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_fdoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_fec_compra As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_subgrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_prove As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tdoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_familia As System.Windows.Forms.ComboBox
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_num_placa As System.Windows.Forms.TextBox
    Friend WithEvents txt_serie As System.Windows.Forms.TextBox
    Friend WithEvents cmb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tc As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tip_pago As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cod_barra As System.Windows.Forms.TextBox
    Friend WithEvents cmb_est_fis As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_uso As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_nivel_obs As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_clase As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cc As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ubicacion As System.Windows.Forms.ComboBox
    Friend WithEvents txt_ndoc As System.Windows.Forms.TextBox
    Friend WithEvents dgv_Lista As System.Windows.Forms.DataGridView
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents gb_mante As System.Windows.Forms.GroupBox
    Friend WithEvents mtb_fec_vcto_con As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_fec_vcto_garan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_perioricidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_num_con As System.Windows.Forms.TextBox
    Friend WithEvents txt_meses_garan As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents gb_leasing As System.Windows.Forms.GroupBox
    Friend WithEvents mtb_fec_arren As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_fec_con As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_num_cuotas As System.Windows.Forms.TextBox
    Friend WithEvents txt_meses As System.Windows.Forms.TextBox
    Friend WithEvents txt_anho As System.Windows.Forms.TextBox
    Friend WithEvents txt_lea_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_num_contrato As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents gb_otros As System.Windows.Forms.GroupBox
    Friend WithEvents txt_tasa_parti As System.Windows.Forms.TextBox
    Friend WithEvents txt_depre_ini As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txt_valor_residual As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents mtb_idoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_des_activo_principal As System.Windows.Forms.TextBox
    Friend WithEvents txt_idactivo_principal As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents chk_mejora As System.Windows.Forms.CheckBox
    Friend WithEvents txt_tasa As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents dgv_img As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pb_img As System.Windows.Forms.PictureBox
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents col_sec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ver_doc As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_doc As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_fic As System.Windows.Forms.Button
    Friend WithEvents dgv_ficha_tec As System.Windows.Forms.DataGridView
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents col_dsec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_dArc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ddoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_responsable As System.Windows.Forms.ComboBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents cmb_origen_req As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txt_autoriza_adq As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_orden_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txt_cotizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents AC_IDACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AC_ACTIVO_DES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AC_FECHA_INI_OPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
