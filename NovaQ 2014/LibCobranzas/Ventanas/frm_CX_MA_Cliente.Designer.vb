Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_Cliente
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_Cliente))
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.dgv_Lista = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.chk_validacion_fe = New System.Windows.Forms.CheckBox()
        Me.txt_segundo_nombre = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_primer_nombre = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_ap_materno = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_ap_paterno = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txt_des_tip_precio = New System.Windows.Forms.TextBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.btndirecentrega = New System.Windows.Forms.Button()
        Me.cbo_direc_entrega = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.gb_tipo_cliente = New System.Windows.Forms.GroupBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.rb_sede = New System.Windows.Forms.RadioButton()
        Me.rb_principal = New System.Windows.Forms.RadioButton()
        Me.txtdescripcionTipoEmp = New System.Windows.Forms.TextBox()
        Me.gbGenerarCodigo = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripciondepartamento = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtdescripcionTipocliente = New System.Windows.Forms.TextBox()
        Me.txtTipoCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtcodigoTipoEmp = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnombreComercial = New System.Windows.Forms.TextBox()
        Me.gb_estado = New System.Windows.Forms.GroupBox()
        Me.rb_inactivo = New System.Windows.Forms.RadioButton()
        Me.rb_activo = New System.Windows.Forms.RadioButton()
        Me.txt_desc_pago = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_desc_vende = New System.Windows.Forms.TextBox()
        Me.txt_obs = New System.Windows.Forms.RichTextBox()
        Me.txt_desc_dist = New System.Windows.Forms.TextBox()
        Me.txt_cod_zon_ven = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_desc_prov = New System.Windows.Forms.TextBox()
        Me.txt_des_depart = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_fax = New System.Windows.Forms.TextBox()
        Me.cmb_tip_doc_per = New System.Windows.Forms.ComboBox()
        Me.txt_telf_cli = New System.Windows.Forms.TextBox()
        Me.txt_dir_cli = New System.Windows.Forms.TextBox()
        Me.txt_des_cli = New System.Windows.Forms.TextBox()
        Me.txt_cod_cli = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_cod_mon_cre = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_cod_dist = New System.Windows.Forms.TextBox()
        Me.txt_contacto = New System.Windows.Forms.TextBox()
        Me.txt_web = New System.Windows.Forms.TextBox()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.txt_saldo_dol = New System.Windows.Forms.TextBox()
        Me.txt_saldo_sol = New System.Windows.Forms.TextBox()
        Me.txt_cod_pross = New System.Windows.Forms.TextBox()
        Me.txt_lim_dol = New System.Windows.Forms.TextBox()
        Me.txt_lim_sol = New System.Windows.Forms.TextBox()
        Me.txt_cod_prov = New System.Windows.Forms.TextBox()
        Me.txt_cod_dep = New System.Windows.Forms.TextBox()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.txt_cod_vende = New System.Windows.Forms.TextBox()
        Me.txt_tip_precio = New System.Windows.Forms.TextBox()
        Me.txt_cond_pago = New System.Windows.Forms.TextBox()
        Me.txt_porc_descto = New System.Windows.Forms.TextBox()
        Me.txt_num_doc = New System.Windows.Forms.TextBox()
        Me.txt_ruc_cli = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gb_mas_datos = New System.Windows.Forms.GroupBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtcuentaContableDol = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtcuentaContableSol = New System.Windows.Forms.TextBox()
        Me.checkRetencion = New System.Windows.Forms.CheckBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbFarmacia = New System.Windows.Forms.RadioButton()
        Me.rbdistribuidor = New System.Windows.Forms.RadioButton()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_tot_cheque = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.txt_tip_ate = New System.Windows.Forms.TextBox()
        Me.txt_hor_vis = New System.Windows.Forms.TextBox()
        Me.cmb_banco = New System.Windows.Forms.ComboBox()
        Me.cmb_cta_cte = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_segmento = New System.Windows.Forms.TextBox()
        Me.txt_ubi_seg = New System.Windows.Forms.TextBox()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.txt_territorio = New System.Windows.Forms.TextBox()
        Me.txt_tip_neg = New System.Windows.Forms.TextBox()
        Me.txt_tip_cli = New System.Windows.Forms.TextBox()
        Me.txt_tot_let_protes = New System.Windows.Forms.TextBox()
        Me.txt_tot_factura = New System.Windows.Forms.TextBox()
        Me.txt_tot_letra = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_reporte = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.pnldirecentrega = New System.Windows.Forms.Panel()
        Me.txtcod_cliente_de = New System.Windows.Forms.TextBox()
        Me.gb_principios_activos = New System.Windows.Forms.GroupBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtdirecentrega = New System.Windows.Forms.TextBox()
        Me.pnlreporte = New System.Windows.Forms.Panel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtcodigo2 = New System.Windows.Forms.TextBox()
        Me.txtdescripcion2 = New System.Windows.Forms.Label()
        Me.txtcodigo1 = New System.Windows.Forms.TextBox()
        Me.txtdescripcion1 = New System.Windows.Forms.Label()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rbtipocliente = New System.Windows.Forms.RadioButton()
        Me.rbvendedor = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.rbcodigo = New System.Windows.Forms.RadioButton()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tipo_cliente.SuspendLayout()
        Me.gbGenerarCodigo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_estado.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.gb_mas_datos.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnldirecentrega.SuspendLayout()
        Me.gb_principios_activos.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.pnlreporte.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Controls.Add(Me.TabPage3)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 29)
        Me.tc_tipos.Multiline = True
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(898, 589)
        Me.tc_tipos.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.dgv_Lista)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(890, 563)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Datos"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(6, 542)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 123
        Me.lblCantidad.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(787, 45)
        Me.GroupBox3.TabIndex = 122
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
        Me.txtFiltro.Size = New System.Drawing.Size(774, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'dgv_Lista
        '
        Me.dgv_Lista.AllowUserToAddRows = False
        Me.dgv_Lista.AllowUserToDeleteRows = False
        Me.dgv_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Lista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Lista.Location = New System.Drawing.Point(9, 58)
        Me.dgv_Lista.Name = "dgv_Lista"
        Me.dgv_Lista.ReadOnly = True
        Me.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lista.Size = New System.Drawing.Size(863, 481)
        Me.dgv_Lista.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(890, 563)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion de Datos"
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.Transparent
        Me.gb_data.Controls.Add(Me.Button22)
        Me.gb_data.Controls.Add(Me.Button21)
        Me.gb_data.Controls.Add(Me.chk_validacion_fe)
        Me.gb_data.Controls.Add(Me.txt_segundo_nombre)
        Me.gb_data.Controls.Add(Me.Label56)
        Me.gb_data.Controls.Add(Me.txt_primer_nombre)
        Me.gb_data.Controls.Add(Me.Label57)
        Me.gb_data.Controls.Add(Me.txt_ap_materno)
        Me.gb_data.Controls.Add(Me.Label55)
        Me.gb_data.Controls.Add(Me.txt_ap_paterno)
        Me.gb_data.Controls.Add(Me.Label54)
        Me.gb_data.Controls.Add(Me.txt_des_tip_precio)
        Me.gb_data.Controls.Add(Me.PictureBox14)
        Me.gb_data.Controls.Add(Me.btndirecentrega)
        Me.gb_data.Controls.Add(Me.cbo_direc_entrega)
        Me.gb_data.Controls.Add(Me.Label50)
        Me.gb_data.Controls.Add(Me.PictureBox10)
        Me.gb_data.Controls.Add(Me.gb_tipo_cliente)
        Me.gb_data.Controls.Add(Me.txtdescripcionTipoEmp)
        Me.gb_data.Controls.Add(Me.gbGenerarCodigo)
        Me.gb_data.Controls.Add(Me.PictureBox9)
        Me.gb_data.Controls.Add(Me.Label48)
        Me.gb_data.Controls.Add(Me.txtcodigoTipoEmp)
        Me.gb_data.Controls.Add(Me.Label44)
        Me.gb_data.Controls.Add(Me.Label11)
        Me.gb_data.Controls.Add(Me.txtnombreComercial)
        Me.gb_data.Controls.Add(Me.gb_estado)
        Me.gb_data.Controls.Add(Me.txt_desc_pago)
        Me.gb_data.Controls.Add(Me.PictureBox3)
        Me.gb_data.Controls.Add(Me.txt_desc_vende)
        Me.gb_data.Controls.Add(Me.txt_obs)
        Me.gb_data.Controls.Add(Me.txt_desc_dist)
        Me.gb_data.Controls.Add(Me.txt_cod_zon_ven)
        Me.gb_data.Controls.Add(Me.Label15)
        Me.gb_data.Controls.Add(Me.txt_desc_prov)
        Me.gb_data.Controls.Add(Me.txt_des_depart)
        Me.gb_data.Controls.Add(Me.Label24)
        Me.gb_data.Controls.Add(Me.PictureBox7)
        Me.gb_data.Controls.Add(Me.PictureBox6)
        Me.gb_data.Controls.Add(Me.PictureBox4)
        Me.gb_data.Controls.Add(Me.Label40)
        Me.gb_data.Controls.Add(Me.txt_fax)
        Me.gb_data.Controls.Add(Me.cmb_tip_doc_per)
        Me.gb_data.Controls.Add(Me.txt_telf_cli)
        Me.gb_data.Controls.Add(Me.txt_dir_cli)
        Me.gb_data.Controls.Add(Me.txt_des_cli)
        Me.gb_data.Controls.Add(Me.txt_cod_cli)
        Me.gb_data.Controls.Add(Me.label4)
        Me.gb_data.Controls.Add(Me.Label7)
        Me.gb_data.Controls.Add(Me.Label6)
        Me.gb_data.Controls.Add(Me.label3)
        Me.gb_data.Controls.Add(Me.Label13)
        Me.gb_data.Controls.Add(Me.Label12)
        Me.gb_data.Controls.Add(Me.Label26)
        Me.gb_data.Controls.Add(Me.Label25)
        Me.gb_data.Controls.Add(Me.Label23)
        Me.gb_data.Controls.Add(Me.Label22)
        Me.gb_data.Controls.Add(Me.txt_cod_mon_cre)
        Me.gb_data.Controls.Add(Me.Label20)
        Me.gb_data.Controls.Add(Me.Label19)
        Me.gb_data.Controls.Add(Me.Label18)
        Me.gb_data.Controls.Add(Me.Label17)
        Me.gb_data.Controls.Add(Me.Label27)
        Me.gb_data.Controls.Add(Me.Label16)
        Me.gb_data.Controls.Add(Me.Label14)
        Me.gb_data.Controls.Add(Me.label2)
        Me.gb_data.Controls.Add(Me.Label10)
        Me.gb_data.Controls.Add(Me.Label9)
        Me.gb_data.Controls.Add(Me.Label8)
        Me.gb_data.Controls.Add(Me.label1)
        Me.gb_data.Controls.Add(Me.txt_cod_dist)
        Me.gb_data.Controls.Add(Me.txt_contacto)
        Me.gb_data.Controls.Add(Me.txt_web)
        Me.gb_data.Controls.Add(Me.txt_mail)
        Me.gb_data.Controls.Add(Me.txt_saldo_dol)
        Me.gb_data.Controls.Add(Me.txt_saldo_sol)
        Me.gb_data.Controls.Add(Me.txt_cod_pross)
        Me.gb_data.Controls.Add(Me.txt_lim_dol)
        Me.gb_data.Controls.Add(Me.txt_lim_sol)
        Me.gb_data.Controls.Add(Me.txt_cod_prov)
        Me.gb_data.Controls.Add(Me.txt_cod_dep)
        Me.gb_data.Controls.Add(Me.txt_pais)
        Me.gb_data.Controls.Add(Me.txt_cod_vende)
        Me.gb_data.Controls.Add(Me.txt_tip_precio)
        Me.gb_data.Controls.Add(Me.txt_cond_pago)
        Me.gb_data.Controls.Add(Me.txt_porc_descto)
        Me.gb_data.Controls.Add(Me.txt_num_doc)
        Me.gb_data.Controls.Add(Me.txt_ruc_cli)
        Me.gb_data.ForeColor = System.Drawing.Color.Navy
        Me.gb_data.Location = New System.Drawing.Point(3, 6)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(877, 547)
        Me.gb_data.TabIndex = 0
        Me.gb_data.TabStop = False
        '
        'Button22
        '
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.Green
        Me.Button22.Image = CType(resources.GetObject("Button22.Image"), System.Drawing.Image)
        Me.Button22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button22.Location = New System.Drawing.Point(334, 17)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(131, 22)
        Me.Button22.TabIndex = 254
        Me.Button22.Text = "DNI"
        Me.Button22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.Green
        Me.Button21.Image = CType(resources.GetObject("Button21.Image"), System.Drawing.Image)
        Me.Button21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button21.Location = New System.Drawing.Point(197, 17)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(131, 22)
        Me.Button21.TabIndex = 253
        Me.Button21.Text = "Consultar RUC"
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button21.UseVisualStyleBackColor = True
        '
        'chk_validacion_fe
        '
        Me.chk_validacion_fe.AutoSize = True
        Me.chk_validacion_fe.Location = New System.Drawing.Point(482, 329)
        Me.chk_validacion_fe.Name = "chk_validacion_fe"
        Me.chk_validacion_fe.Size = New System.Drawing.Size(127, 17)
        Me.chk_validacion_fe.TabIndex = 220
        Me.chk_validacion_fe.Text = "Cliente Validado? NO"
        Me.chk_validacion_fe.UseVisualStyleBackColor = True
        '
        'txt_segundo_nombre
        '
        Me.txt_segundo_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_segundo_nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_segundo_nombre.Location = New System.Drawing.Point(483, 131)
        Me.txt_segundo_nombre.MaxLength = 200
        Me.txt_segundo_nombre.Name = "txt_segundo_nombre"
        Me.txt_segundo_nombre.Size = New System.Drawing.Size(280, 20)
        Me.txt_segundo_nombre.TabIndex = 219
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.Navy
        Me.Label56.Location = New System.Drawing.Point(388, 134)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(88, 13)
        Me.Label56.TabIndex = 218
        Me.Label56.Text = "Segundo nombre"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_primer_nombre
        '
        Me.txt_primer_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_primer_nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_primer_nombre.Location = New System.Drawing.Point(483, 106)
        Me.txt_primer_nombre.MaxLength = 200
        Me.txt_primer_nombre.Name = "txt_primer_nombre"
        Me.txt_primer_nombre.Size = New System.Drawing.Size(280, 20)
        Me.txt_primer_nombre.TabIndex = 217
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.Navy
        Me.Label57.Location = New System.Drawing.Point(402, 108)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(74, 13)
        Me.Label57.TabIndex = 216
        Me.Label57.Text = "Primer nombre"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ap_materno
        '
        Me.txt_ap_materno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ap_materno.ForeColor = System.Drawing.Color.Black
        Me.txt_ap_materno.Location = New System.Drawing.Point(86, 131)
        Me.txt_ap_materno.MaxLength = 200
        Me.txt_ap_materno.Name = "txt_ap_materno"
        Me.txt_ap_materno.Size = New System.Drawing.Size(298, 20)
        Me.txt_ap_materno.TabIndex = 215
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Navy
        Me.Label55.Location = New System.Drawing.Point(17, 134)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(65, 13)
        Me.Label55.TabIndex = 214
        Me.Label55.Text = "Ap. Materno"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ap_paterno
        '
        Me.txt_ap_paterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ap_paterno.ForeColor = System.Drawing.Color.Black
        Me.txt_ap_paterno.Location = New System.Drawing.Point(86, 105)
        Me.txt_ap_paterno.MaxLength = 200
        Me.txt_ap_paterno.Name = "txt_ap_paterno"
        Me.txt_ap_paterno.Size = New System.Drawing.Size(298, 20)
        Me.txt_ap_paterno.TabIndex = 213
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(19, 108)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(63, 13)
        Me.Label54.TabIndex = 212
        Me.Label54.Text = "Ap. Paterno"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_des_tip_precio
        '
        Me.txt_des_tip_precio.BackColor = System.Drawing.Color.White
        Me.txt_des_tip_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_tip_precio.Enabled = False
        Me.txt_des_tip_precio.ForeColor = System.Drawing.Color.Black
        Me.txt_des_tip_precio.Location = New System.Drawing.Point(162, 394)
        Me.txt_des_tip_precio.Name = "txt_des_tip_precio"
        Me.txt_des_tip_precio.ReadOnly = True
        Me.txt_des_tip_precio.Size = New System.Drawing.Size(225, 20)
        Me.txt_des_tip_precio.TabIndex = 210
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(143, 395)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox14.TabIndex = 211
        Me.PictureBox14.TabStop = False
        '
        'btndirecentrega
        '
        Me.btndirecentrega.Image = CType(resources.GetObject("btndirecentrega.Image"), System.Drawing.Image)
        Me.btndirecentrega.Location = New System.Drawing.Point(86, 318)
        Me.btndirecentrega.Name = "btndirecentrega"
        Me.btndirecentrega.Size = New System.Drawing.Size(46, 29)
        Me.btndirecentrega.TabIndex = 209
        Me.btndirecentrega.UseVisualStyleBackColor = True
        '
        'cbo_direc_entrega
        '
        Me.cbo_direc_entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_direc_entrega.ForeColor = System.Drawing.Color.Black
        Me.cbo_direc_entrega.FormattingEnabled = True
        Me.cbo_direc_entrega.Location = New System.Drawing.Point(246, 325)
        Me.cbo_direc_entrega.Name = "cbo_direc_entrega"
        Me.cbo_direc_entrega.Size = New System.Drawing.Size(61, 21)
        Me.cbo_direc_entrega.TabIndex = 208
        Me.cbo_direc_entrega.Visible = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.Navy
        Me.Label50.Location = New System.Drawing.Point(7, 325)
        Me.Label50.Name = "Label50"
        Me.Label50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label50.Size = New System.Drawing.Size(75, 13)
        Me.Label50.TabIndex = 207
        Me.Label50.Text = "Direc. Entrega"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(523, 247)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox10.TabIndex = 206
        Me.PictureBox10.TabStop = False
        '
        'gb_tipo_cliente
        '
        Me.gb_tipo_cliente.Controls.Add(Me.Label49)
        Me.gb_tipo_cliente.Controls.Add(Me.rb_sede)
        Me.gb_tipo_cliente.Controls.Add(Me.rb_principal)
        Me.gb_tipo_cliente.ForeColor = System.Drawing.Color.Navy
        Me.gb_tipo_cliente.Location = New System.Drawing.Point(544, 11)
        Me.gb_tipo_cliente.Name = "gb_tipo_cliente"
        Me.gb_tipo_cliente.Size = New System.Drawing.Size(323, 29)
        Me.gb_tipo_cliente.TabIndex = 126
        Me.gb_tipo_cliente.TabStop = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(2, 11)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(78, 13)
        Me.Label49.TabIndex = 4
        Me.Label49.Text = "Tipo de Cliente"
        '
        'rb_sede
        '
        Me.rb_sede.AutoSize = True
        Me.rb_sede.ForeColor = System.Drawing.Color.Navy
        Me.rb_sede.Location = New System.Drawing.Point(245, 9)
        Me.rb_sede.Name = "rb_sede"
        Me.rb_sede.Size = New System.Drawing.Size(50, 17)
        Me.rb_sede.TabIndex = 14
        Me.rb_sede.Text = "Sede"
        Me.rb_sede.UseVisualStyleBackColor = True
        '
        'rb_principal
        '
        Me.rb_principal.AutoSize = True
        Me.rb_principal.ForeColor = System.Drawing.Color.Navy
        Me.rb_principal.Location = New System.Drawing.Point(125, 9)
        Me.rb_principal.Name = "rb_principal"
        Me.rb_principal.Size = New System.Drawing.Size(65, 17)
        Me.rb_principal.TabIndex = 13
        Me.rb_principal.Text = "Principal"
        Me.rb_principal.UseVisualStyleBackColor = True
        '
        'txtdescripcionTipoEmp
        '
        Me.txtdescripcionTipoEmp.BackColor = System.Drawing.Color.White
        Me.txtdescripcionTipoEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionTipoEmp.Enabled = False
        Me.txtdescripcionTipoEmp.ForeColor = System.Drawing.Color.Black
        Me.txtdescripcionTipoEmp.Location = New System.Drawing.Point(542, 193)
        Me.txtdescripcionTipoEmp.Name = "txtdescripcionTipoEmp"
        Me.txtdescripcionTipoEmp.ReadOnly = True
        Me.txtdescripcionTipoEmp.Size = New System.Drawing.Size(221, 20)
        Me.txtdescripcionTipoEmp.TabIndex = 204
        '
        'gbGenerarCodigo
        '
        Me.gbGenerarCodigo.Controls.Add(Me.PictureBox2)
        Me.gbGenerarCodigo.Controls.Add(Me.PictureBox1)
        Me.gbGenerarCodigo.Controls.Add(Me.txtdescripciondepartamento)
        Me.gbGenerarCodigo.Controls.Add(Me.txtDepartamento)
        Me.gbGenerarCodigo.Controls.Add(Me.Label43)
        Me.gbGenerarCodigo.Controls.Add(Me.txtdescripcionTipocliente)
        Me.gbGenerarCodigo.Controls.Add(Me.txtTipoCliente)
        Me.gbGenerarCodigo.Controls.Add(Me.Label5)
        Me.gbGenerarCodigo.Location = New System.Drawing.Point(193, 40)
        Me.gbGenerarCodigo.Name = "gbGenerarCodigo"
        Me.gbGenerarCodigo.Size = New System.Drawing.Size(677, 33)
        Me.gbGenerarCodigo.TabIndex = 13
        Me.gbGenerarCodigo.TabStop = False
        Me.gbGenerarCodigo.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(451, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 112
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(84, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 112
        Me.PictureBox1.TabStop = False
        '
        'txtdescripciondepartamento
        '
        Me.txtdescripciondepartamento.BackColor = System.Drawing.Color.White
        Me.txtdescripciondepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripciondepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtdescripciondepartamento.ForeColor = System.Drawing.Color.Black
        Me.txtdescripciondepartamento.Location = New System.Drawing.Point(476, 9)
        Me.txtdescripciondepartamento.Name = "txtdescripciondepartamento"
        Me.txtdescripciondepartamento.ReadOnly = True
        Me.txtdescripciondepartamento.Size = New System.Drawing.Size(198, 20)
        Me.txtdescripciondepartamento.TabIndex = 101
        '
        'txtDepartamento
        '
        Me.txtDepartamento.BackColor = System.Drawing.Color.Aquamarine
        Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDepartamento.ForeColor = System.Drawing.Color.Black
        Me.txtDepartamento.Location = New System.Drawing.Point(405, 9)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(44, 20)
        Me.txtDepartamento.TabIndex = 2
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(330, 13)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(74, 13)
        Me.Label43.TabIndex = 16
        Me.Label43.Text = "Departamento"
        '
        'txtdescripcionTipocliente
        '
        Me.txtdescripcionTipocliente.BackColor = System.Drawing.Color.White
        Me.txtdescripcionTipocliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionTipocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtdescripcionTipocliente.ForeColor = System.Drawing.Color.Black
        Me.txtdescripcionTipocliente.Location = New System.Drawing.Point(107, 9)
        Me.txtdescripcionTipocliente.Name = "txtdescripcionTipocliente"
        Me.txtdescripcionTipocliente.ReadOnly = True
        Me.txtdescripcionTipocliente.Size = New System.Drawing.Size(216, 20)
        Me.txtdescripcionTipocliente.TabIndex = 100
        '
        'txtTipoCliente
        '
        Me.txtTipoCliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtTipoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTipoCliente.ForeColor = System.Drawing.Color.Black
        Me.txtTipoCliente.Location = New System.Drawing.Point(39, 9)
        Me.txtTipoCliente.Name = "txtTipoCliente"
        Me.txtTipoCliente.ReadOnly = True
        Me.txtTipoCliente.Size = New System.Drawing.Size(44, 20)
        Me.txtTipoCliente.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(6, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(523, 194)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox9.TabIndex = 205
        Me.PictureBox9.TabStop = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.Navy
        Me.Label48.Location = New System.Drawing.Point(391, 196)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(87, 13)
        Me.Label48.TabIndex = 202
        Me.Label48.Text = "Tipo de Empresa"
        '
        'txtcodigoTipoEmp
        '
        Me.txtcodigoTipoEmp.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoTipoEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoTipoEmp.ForeColor = System.Drawing.Color.Black
        Me.txtcodigoTipoEmp.Location = New System.Drawing.Point(482, 192)
        Me.txtcodigoTipoEmp.Name = "txtcodigoTipoEmp"
        Me.txtcodigoTipoEmp.Size = New System.Drawing.Size(40, 20)
        Me.txtcodigoTipoEmp.TabIndex = 19
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.Navy
        Me.Label44.Location = New System.Drawing.Point(33, 249)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(53, 13)
        Me.Label44.TabIndex = 201
        Me.Label44.Text = "Comercial"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(8, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Nombre"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtnombreComercial
        '
        Me.txtnombreComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombreComercial.ForeColor = System.Drawing.Color.Black
        Me.txtnombreComercial.Location = New System.Drawing.Point(87, 239)
        Me.txtnombreComercial.MaxLength = 200
        Me.txtnombreComercial.Name = "txtnombreComercial"
        Me.txtnombreComercial.Size = New System.Drawing.Size(300, 20)
        Me.txtnombreComercial.TabIndex = 9
        '
        'gb_estado
        '
        Me.gb_estado.Controls.Add(Me.rb_inactivo)
        Me.gb_estado.Controls.Add(Me.rb_activo)
        Me.gb_estado.ForeColor = System.Drawing.Color.Navy
        Me.gb_estado.Location = New System.Drawing.Point(8, 348)
        Me.gb_estado.Name = "gb_estado"
        Me.gb_estado.Size = New System.Drawing.Size(379, 34)
        Me.gb_estado.TabIndex = 13
        Me.gb_estado.TabStop = False
        Me.gb_estado.Text = "Estado"
        '
        'rb_inactivo
        '
        Me.rb_inactivo.AutoSize = True
        Me.rb_inactivo.ForeColor = System.Drawing.Color.Navy
        Me.rb_inactivo.Location = New System.Drawing.Point(181, 12)
        Me.rb_inactivo.Name = "rb_inactivo"
        Me.rb_inactivo.Size = New System.Drawing.Size(63, 17)
        Me.rb_inactivo.TabIndex = 14
        Me.rb_inactivo.Text = "Inactivo"
        Me.rb_inactivo.UseVisualStyleBackColor = True
        '
        'rb_activo
        '
        Me.rb_activo.AutoSize = True
        Me.rb_activo.Checked = True
        Me.rb_activo.ForeColor = System.Drawing.Color.Navy
        Me.rb_activo.Location = New System.Drawing.Point(85, 12)
        Me.rb_activo.Name = "rb_activo"
        Me.rb_activo.Size = New System.Drawing.Size(55, 17)
        Me.rb_activo.TabIndex = 13
        Me.rb_activo.TabStop = True
        Me.rb_activo.Text = "Activo"
        Me.rb_activo.UseVisualStyleBackColor = True
        '
        'txt_desc_pago
        '
        Me.txt_desc_pago.BackColor = System.Drawing.Color.White
        Me.txt_desc_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_pago.Enabled = False
        Me.txt_desc_pago.ForeColor = System.Drawing.Color.Black
        Me.txt_desc_pago.Location = New System.Drawing.Point(161, 267)
        Me.txt_desc_pago.Name = "txt_desc_pago"
        Me.txt_desc_pago.ReadOnly = True
        Me.txt_desc_pago.Size = New System.Drawing.Size(226, 20)
        Me.txt_desc_pago.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(142, 268)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 123
        Me.PictureBox3.TabStop = False
        '
        'txt_desc_vende
        '
        Me.txt_desc_vende.BackColor = System.Drawing.Color.White
        Me.txt_desc_vende.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_vende.Enabled = False
        Me.txt_desc_vende.ForeColor = System.Drawing.Color.Black
        Me.txt_desc_vende.Location = New System.Drawing.Point(162, 421)
        Me.txt_desc_vende.Name = "txt_desc_vende"
        Me.txt_desc_vende.ReadOnly = True
        Me.txt_desc_vende.Size = New System.Drawing.Size(225, 20)
        Me.txt_desc_vende.TabIndex = 106
        '
        'txt_obs
        '
        Me.txt_obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs.Location = New System.Drawing.Point(89, 498)
        Me.txt_obs.MaxLength = 200
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(674, 24)
        Me.txt_obs.TabIndex = 32
        Me.txt_obs.Text = ""
        '
        'txt_desc_dist
        '
        Me.txt_desc_dist.BackColor = System.Drawing.Color.White
        Me.txt_desc_dist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_dist.Enabled = False
        Me.txt_desc_dist.ForeColor = System.Drawing.Color.Black
        Me.txt_desc_dist.Location = New System.Drawing.Point(542, 299)
        Me.txt_desc_dist.Name = "txt_desc_dist"
        Me.txt_desc_dist.ReadOnly = True
        Me.txt_desc_dist.Size = New System.Drawing.Size(220, 20)
        Me.txt_desc_dist.TabIndex = 105
        '
        'txt_cod_zon_ven
        '
        Me.txt_cod_zon_ven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_zon_ven.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_zon_ven.Location = New System.Drawing.Point(599, 358)
        Me.txt_cod_zon_ven.Name = "txt_cod_zon_ven"
        Me.txt_cod_zon_ven.Size = New System.Drawing.Size(74, 20)
        Me.txt_cod_zon_ven.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(530, 363)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Zona Venta"
        '
        'txt_desc_prov
        '
        Me.txt_desc_prov.BackColor = System.Drawing.Color.White
        Me.txt_desc_prov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_prov.Enabled = False
        Me.txt_desc_prov.ForeColor = System.Drawing.Color.Black
        Me.txt_desc_prov.Location = New System.Drawing.Point(542, 275)
        Me.txt_desc_prov.Name = "txt_desc_prov"
        Me.txt_desc_prov.ReadOnly = True
        Me.txt_desc_prov.Size = New System.Drawing.Size(220, 20)
        Me.txt_desc_prov.TabIndex = 104
        '
        'txt_des_depart
        '
        Me.txt_des_depart.BackColor = System.Drawing.Color.White
        Me.txt_des_depart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_depart.Enabled = False
        Me.txt_des_depart.ForeColor = System.Drawing.Color.Black
        Me.txt_des_depart.Location = New System.Drawing.Point(542, 247)
        Me.txt_des_depart.Name = "txt_des_depart"
        Me.txt_des_depart.ReadOnly = True
        Me.txt_des_depart.Size = New System.Drawing.Size(221, 20)
        Me.txt_des_depart.TabIndex = 22
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(4, 501)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(78, 13)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Observaciones"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(523, 300)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox7.TabIndex = 117
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(523, 275)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 116
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(143, 422)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 112
        Me.PictureBox4.TabStop = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(225, 215)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(24, 13)
        Me.Label40.TabIndex = 29
        Me.Label40.Text = "Fax"
        '
        'txt_fax
        '
        Me.txt_fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fax.ForeColor = System.Drawing.Color.Black
        Me.txt_fax.Location = New System.Drawing.Point(259, 210)
        Me.txt_fax.MaxLength = 15
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Size = New System.Drawing.Size(128, 20)
        Me.txt_fax.TabIndex = 8
        '
        'cmb_tip_doc_per
        '
        Me.cmb_tip_doc_per.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tip_doc_per.ForeColor = System.Drawing.Color.Black
        Me.cmb_tip_doc_per.FormattingEnabled = True
        Me.cmb_tip_doc_per.Location = New System.Drawing.Point(483, 159)
        Me.cmb_tip_doc_per.Name = "cmb_tip_doc_per"
        Me.cmb_tip_doc_per.Size = New System.Drawing.Size(281, 21)
        Me.cmb_tip_doc_per.TabIndex = 18
        '
        'txt_telf_cli
        '
        Me.txt_telf_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telf_cli.ForeColor = System.Drawing.Color.Black
        Me.txt_telf_cli.Location = New System.Drawing.Point(87, 185)
        Me.txt_telf_cli.MaxLength = 30
        Me.txt_telf_cli.Name = "txt_telf_cli"
        Me.txt_telf_cli.Size = New System.Drawing.Size(123, 20)
        Me.txt_telf_cli.TabIndex = 6
        '
        'txt_dir_cli
        '
        Me.txt_dir_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dir_cli.ForeColor = System.Drawing.Color.Black
        Me.txt_dir_cli.Location = New System.Drawing.Point(87, 159)
        Me.txt_dir_cli.MaxLength = 200
        Me.txt_dir_cli.Name = "txt_dir_cli"
        Me.txt_dir_cli.Size = New System.Drawing.Size(298, 20)
        Me.txt_dir_cli.TabIndex = 5
        '
        'txt_des_cli
        '
        Me.txt_des_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_cli.ForeColor = System.Drawing.Color.Black
        Me.txt_des_cli.Location = New System.Drawing.Point(87, 79)
        Me.txt_des_cli.MaxLength = 200
        Me.txt_des_cli.Name = "txt_des_cli"
        Me.txt_des_cli.Size = New System.Drawing.Size(674, 20)
        Me.txt_des_cli.TabIndex = 4
        '
        'txt_cod_cli
        '
        Me.txt_cod_cli.BackColor = System.Drawing.Color.White
        Me.txt_cod_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_cli.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_cli.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_cli.Location = New System.Drawing.Point(87, 48)
        Me.txt_cod_cli.MaxLength = 11
        Me.txt_cod_cli.Name = "txt_cod_cli"
        Me.txt_cod_cli.Size = New System.Drawing.Size(103, 21)
        Me.txt_cod_cli.TabIndex = 3
        Me.txt_cod_cli.Text = " "
        Me.txt_cod_cli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Navy
        Me.label4.Location = New System.Drawing.Point(42, 50)
        Me.label4.Name = "label4"
        Me.label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label4.Size = New System.Drawing.Size(40, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Codigo"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(33, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Telefono"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(6, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Direc. Factura"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(14, 82)
        Me.label3.Name = "label3"
        Me.label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label3.Size = New System.Drawing.Size(68, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Razon social"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(439, 303)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Distrito"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(34, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Contacto"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(31, 450)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(51, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Web Site"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(56, 476)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(26, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Mail"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(597, 418)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Saldo $"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(597, 393)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Saldo S/."
        '
        'txt_cod_mon_cre
        '
        Me.txt_cod_mon_cre.AutoSize = True
        Me.txt_cod_mon_cre.ForeColor = System.Drawing.Color.Navy
        Me.txt_cod_mon_cre.Location = New System.Drawing.Point(419, 362)
        Me.txt_cod_mon_cre.Name = "txt_cod_mon_cre"
        Me.txt_cod_mon_cre.Size = New System.Drawing.Size(59, 13)
        Me.txt_cod_mon_cre.TabIndex = 1
        Me.txt_cod_mon_cre.Text = "Mon. Cred."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(404, 420)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Lim. Credirto $"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(395, 394)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Lim. Credirto S./"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(427, 278)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Provincia"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(404, 251)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Departamento"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(405, 163)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 13)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Doc Personal"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(451, 222)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Pais"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(13, 423)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Cod. Vended"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(21, 396)
        Me.label2.Name = "label2"
        Me.label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label2.Size = New System.Drawing.Size(61, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Tipo Precio"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(14, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Condic Pago"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(286, 398)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Porc Dscto"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(7, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nº Documento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Navy
        Me.label1.Location = New System.Drawing.Point(54, 20)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label1.Size = New System.Drawing.Size(28, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Ruc"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_cod_dist
        '
        Me.txt_cod_dist.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_dist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_dist.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_dist.Location = New System.Drawing.Point(482, 299)
        Me.txt_cod_dist.Name = "txt_cod_dist"
        Me.txt_cod_dist.ReadOnly = True
        Me.txt_cod_dist.Size = New System.Drawing.Size(40, 20)
        Me.txt_cod_dist.TabIndex = 24
        '
        'txt_contacto
        '
        Me.txt_contacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_contacto.ForeColor = System.Drawing.Color.Black
        Me.txt_contacto.Location = New System.Drawing.Point(87, 292)
        Me.txt_contacto.MaxLength = 200
        Me.txt_contacto.Name = "txt_contacto"
        Me.txt_contacto.Size = New System.Drawing.Size(300, 20)
        Me.txt_contacto.TabIndex = 12
        '
        'txt_web
        '
        Me.txt_web.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_web.ForeColor = System.Drawing.Color.Black
        Me.txt_web.Location = New System.Drawing.Point(89, 446)
        Me.txt_web.MaxLength = 70
        Me.txt_web.Name = "txt_web"
        Me.txt_web.Size = New System.Drawing.Size(298, 20)
        Me.txt_web.TabIndex = 17
        '
        'txt_mail
        '
        Me.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mail.ForeColor = System.Drawing.Color.Black
        Me.txt_mail.Location = New System.Drawing.Point(89, 472)
        Me.txt_mail.MaxLength = 5000
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(674, 20)
        Me.txt_mail.TabIndex = 31
        '
        'txt_saldo_dol
        '
        Me.txt_saldo_dol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_saldo_dol.ForeColor = System.Drawing.Color.Black
        Me.txt_saldo_dol.Location = New System.Drawing.Point(682, 415)
        Me.txt_saldo_dol.Name = "txt_saldo_dol"
        Me.txt_saldo_dol.Size = New System.Drawing.Size(81, 20)
        Me.txt_saldo_dol.TabIndex = 30
        '
        'txt_saldo_sol
        '
        Me.txt_saldo_sol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_saldo_sol.ForeColor = System.Drawing.Color.Black
        Me.txt_saldo_sol.Location = New System.Drawing.Point(682, 390)
        Me.txt_saldo_sol.Name = "txt_saldo_sol"
        Me.txt_saldo_sol.Size = New System.Drawing.Size(81, 20)
        Me.txt_saldo_sol.TabIndex = 28
        '
        'txt_cod_pross
        '
        Me.txt_cod_pross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_pross.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_pross.Location = New System.Drawing.Point(482, 358)
        Me.txt_cod_pross.Name = "txt_cod_pross"
        Me.txt_cod_pross.Size = New System.Drawing.Size(40, 20)
        Me.txt_cod_pross.TabIndex = 25
        '
        'txt_lim_dol
        '
        Me.txt_lim_dol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lim_dol.ForeColor = System.Drawing.Color.Black
        Me.txt_lim_dol.Location = New System.Drawing.Point(483, 416)
        Me.txt_lim_dol.Name = "txt_lim_dol"
        Me.txt_lim_dol.Size = New System.Drawing.Size(112, 20)
        Me.txt_lim_dol.TabIndex = 29
        '
        'txt_lim_sol
        '
        Me.txt_lim_sol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lim_sol.ForeColor = System.Drawing.Color.Black
        Me.txt_lim_sol.Location = New System.Drawing.Point(482, 390)
        Me.txt_lim_sol.Name = "txt_lim_sol"
        Me.txt_lim_sol.Size = New System.Drawing.Size(112, 20)
        Me.txt_lim_sol.TabIndex = 27
        '
        'txt_cod_prov
        '
        Me.txt_cod_prov.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_prov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_prov.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_prov.Location = New System.Drawing.Point(482, 274)
        Me.txt_cod_prov.Name = "txt_cod_prov"
        Me.txt_cod_prov.ReadOnly = True
        Me.txt_cod_prov.Size = New System.Drawing.Size(40, 20)
        Me.txt_cod_prov.TabIndex = 23
        '
        'txt_cod_dep
        '
        Me.txt_cod_dep.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_dep.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_dep.Location = New System.Drawing.Point(482, 247)
        Me.txt_cod_dep.Name = "txt_cod_dep"
        Me.txt_cod_dep.ReadOnly = True
        Me.txt_cod_dep.Size = New System.Drawing.Size(40, 20)
        Me.txt_cod_dep.TabIndex = 21
        '
        'txt_pais
        '
        Me.txt_pais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pais.ForeColor = System.Drawing.Color.Black
        Me.txt_pais.Location = New System.Drawing.Point(482, 218)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(108, 20)
        Me.txt_pais.TabIndex = 20
        '
        'txt_cod_vende
        '
        Me.txt_cod_vende.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_vende.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_vende.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_vende.Location = New System.Drawing.Point(89, 420)
        Me.txt_cod_vende.Name = "txt_cod_vende"
        Me.txt_cod_vende.ReadOnly = True
        Me.txt_cod_vende.Size = New System.Drawing.Size(53, 20)
        Me.txt_cod_vende.TabIndex = 16
        '
        'txt_tip_precio
        '
        Me.txt_tip_precio.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_tip_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tip_precio.ForeColor = System.Drawing.Color.Black
        Me.txt_tip_precio.Location = New System.Drawing.Point(89, 393)
        Me.txt_tip_precio.MaxLength = 10
        Me.txt_tip_precio.Name = "txt_tip_precio"
        Me.txt_tip_precio.Size = New System.Drawing.Size(53, 20)
        Me.txt_tip_precio.TabIndex = 15
        '
        'txt_cond_pago
        '
        Me.txt_cond_pago.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cond_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cond_pago.ForeColor = System.Drawing.Color.Black
        Me.txt_cond_pago.Location = New System.Drawing.Point(87, 266)
        Me.txt_cond_pago.Name = "txt_cond_pago"
        Me.txt_cond_pago.ReadOnly = True
        Me.txt_cond_pago.Size = New System.Drawing.Size(53, 20)
        Me.txt_cond_pago.TabIndex = 10
        '
        'txt_porc_descto
        '
        Me.txt_porc_descto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_porc_descto.ForeColor = System.Drawing.Color.Black
        Me.txt_porc_descto.Location = New System.Drawing.Point(361, 394)
        Me.txt_porc_descto.Name = "txt_porc_descto"
        Me.txt_porc_descto.Size = New System.Drawing.Size(24, 20)
        Me.txt_porc_descto.TabIndex = 200
        Me.txt_porc_descto.Visible = False
        '
        'txt_num_doc
        '
        Me.txt_num_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_doc.ForeColor = System.Drawing.Color.Black
        Me.txt_num_doc.Location = New System.Drawing.Point(87, 211)
        Me.txt_num_doc.MaxLength = 11
        Me.txt_num_doc.Name = "txt_num_doc"
        Me.txt_num_doc.Size = New System.Drawing.Size(123, 20)
        Me.txt_num_doc.TabIndex = 7
        '
        'txt_ruc_cli
        '
        Me.txt_ruc_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc_cli.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ruc_cli.ForeColor = System.Drawing.Color.Red
        Me.txt_ruc_cli.Location = New System.Drawing.Point(87, 17)
        Me.txt_ruc_cli.MaxLength = 11
        Me.txt_ruc_cli.Name = "txt_ruc_cli"
        Me.txt_ruc_cli.Size = New System.Drawing.Size(104, 22)
        Me.txt_ruc_cli.TabIndex = 0
        Me.txt_ruc_cli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.gb_mas_datos)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(890, 563)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Datos adicionales"
        '
        'gb_mas_datos
        '
        Me.gb_mas_datos.Controls.Add(Me.PictureBox8)
        Me.gb_mas_datos.Controls.Add(Me.PictureBox5)
        Me.gb_mas_datos.Controls.Add(Me.Label47)
        Me.gb_mas_datos.Controls.Add(Me.txtcuentaContableDol)
        Me.gb_mas_datos.Controls.Add(Me.Label46)
        Me.gb_mas_datos.Controls.Add(Me.txtcuentaContableSol)
        Me.gb_mas_datos.Controls.Add(Me.checkRetencion)
        Me.gb_mas_datos.Controls.Add(Me.Label45)
        Me.gb_mas_datos.Controls.Add(Me.GroupBox1)
        Me.gb_mas_datos.Controls.Add(Me.Label42)
        Me.gb_mas_datos.Controls.Add(Me.txt_tot_cheque)
        Me.gb_mas_datos.Controls.Add(Me.Label41)
        Me.gb_mas_datos.Controls.Add(Me.Label39)
        Me.gb_mas_datos.Controls.Add(Me.Label38)
        Me.gb_mas_datos.Controls.Add(Me.txt_comentario)
        Me.gb_mas_datos.Controls.Add(Me.txt_tip_ate)
        Me.gb_mas_datos.Controls.Add(Me.txt_hor_vis)
        Me.gb_mas_datos.Controls.Add(Me.cmb_banco)
        Me.gb_mas_datos.Controls.Add(Me.cmb_cta_cte)
        Me.gb_mas_datos.Controls.Add(Me.Label35)
        Me.gb_mas_datos.Controls.Add(Me.Label37)
        Me.gb_mas_datos.Controls.Add(Me.Label36)
        Me.gb_mas_datos.Controls.Add(Me.Label34)
        Me.gb_mas_datos.Controls.Add(Me.Label33)
        Me.gb_mas_datos.Controls.Add(Me.Label32)
        Me.gb_mas_datos.Controls.Add(Me.Label31)
        Me.gb_mas_datos.Controls.Add(Me.Label30)
        Me.gb_mas_datos.Controls.Add(Me.Label29)
        Me.gb_mas_datos.Controls.Add(Me.Label28)
        Me.gb_mas_datos.Controls.Add(Me.Label21)
        Me.gb_mas_datos.Controls.Add(Me.txt_segmento)
        Me.gb_mas_datos.Controls.Add(Me.txt_ubi_seg)
        Me.gb_mas_datos.Controls.Add(Me.txt_ruta)
        Me.gb_mas_datos.Controls.Add(Me.txt_territorio)
        Me.gb_mas_datos.Controls.Add(Me.txt_tip_neg)
        Me.gb_mas_datos.Controls.Add(Me.txt_tip_cli)
        Me.gb_mas_datos.Controls.Add(Me.txt_tot_let_protes)
        Me.gb_mas_datos.Controls.Add(Me.txt_tot_factura)
        Me.gb_mas_datos.Controls.Add(Me.txt_tot_letra)
        Me.gb_mas_datos.Location = New System.Drawing.Point(6, 29)
        Me.gb_mas_datos.Name = "gb_mas_datos"
        Me.gb_mas_datos.Size = New System.Drawing.Size(850, 329)
        Me.gb_mas_datos.TabIndex = 0
        Me.gb_mas_datos.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(354, 266)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox8.TabIndex = 114
        Me.PictureBox8.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(577, 266)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox5.TabIndex = 113
        Me.PictureBox5.TabStop = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(470, 269)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(102, 13)
        Me.Label47.TabIndex = 30
        Me.Label47.Text = "Cuenta en dolares $"
        '
        'txtcuentaContableDol
        '
        Me.txtcuentaContableDol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaContableDol.ForeColor = System.Drawing.Color.Black
        Me.txtcuentaContableDol.Location = New System.Drawing.Point(598, 265)
        Me.txtcuentaContableDol.Name = "txtcuentaContableDol"
        Me.txtcuentaContableDol.ReadOnly = True
        Me.txtcuentaContableDol.Size = New System.Drawing.Size(89, 20)
        Me.txtcuentaContableDol.TabIndex = 31
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(249, 269)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(101, 13)
        Me.Label46.TabIndex = 28
        Me.Label46.Text = "Cuenta en soles S/."
        '
        'txtcuentaContableSol
        '
        Me.txtcuentaContableSol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaContableSol.ForeColor = System.Drawing.Color.Black
        Me.txtcuentaContableSol.Location = New System.Drawing.Point(375, 265)
        Me.txtcuentaContableSol.Name = "txtcuentaContableSol"
        Me.txtcuentaContableSol.ReadOnly = True
        Me.txtcuentaContableSol.Size = New System.Drawing.Size(89, 20)
        Me.txtcuentaContableSol.TabIndex = 29
        '
        'checkRetencion
        '
        Me.checkRetencion.AutoSize = True
        Me.checkRetencion.ForeColor = System.Drawing.Color.Navy
        Me.checkRetencion.Location = New System.Drawing.Point(255, 237)
        Me.checkRetencion.Name = "checkRetencion"
        Me.checkRetencion.Size = New System.Drawing.Size(148, 17)
        Me.checkRetencion.TabIndex = 27
        Me.checkRetencion.Text = "&Activar Agente Retencion"
        Me.checkRetencion.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(255, 219)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(145, 13)
        Me.Label45.TabIndex = 26
        Me.Label45.Text = "---------Cliente  Retencion--------"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbFarmacia)
        Me.GroupBox1.Controls.Add(Me.rbdistribuidor)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(253, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 39)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Tipo de Descuento"
        '
        'rbFarmacia
        '
        Me.rbFarmacia.AutoSize = True
        Me.rbFarmacia.ForeColor = System.Drawing.Color.Navy
        Me.rbFarmacia.Location = New System.Drawing.Point(249, 16)
        Me.rbFarmacia.Name = "rbFarmacia"
        Me.rbFarmacia.Size = New System.Drawing.Size(164, 17)
        Me.rbFarmacia.TabIndex = 24
        Me.rbFarmacia.Text = "Descuento Farmacia y Botica"
        Me.rbFarmacia.UseVisualStyleBackColor = True
        '
        'rbdistribuidor
        '
        Me.rbdistribuidor.AutoSize = True
        Me.rbdistribuidor.Checked = True
        Me.rbdistribuidor.ForeColor = System.Drawing.Color.Navy
        Me.rbdistribuidor.Location = New System.Drawing.Point(101, 15)
        Me.rbdistribuidor.Name = "rbdistribuidor"
        Me.rbdistribuidor.Size = New System.Drawing.Size(132, 17)
        Me.rbdistribuidor.TabIndex = 23
        Me.rbdistribuidor.TabStop = True
        Me.rbdistribuidor.Text = "Descuento Distribuidor"
        Me.rbdistribuidor.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(24, 116)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(71, 13)
        Me.Label42.TabIndex = 20
        Me.Label42.Text = "Total Cheque"
        '
        'txt_tot_cheque
        '
        Me.txt_tot_cheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_cheque.ForeColor = System.Drawing.Color.Black
        Me.txt_tot_cheque.Location = New System.Drawing.Point(101, 113)
        Me.txt_tot_cheque.Name = "txt_tot_cheque"
        Me.txt_tot_cheque.Size = New System.Drawing.Size(103, 20)
        Me.txt_tot_cheque.TabIndex = 21
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(255, 113)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(60, 13)
        Me.Label41.TabIndex = 18
        Me.Label41.Text = "Comentario"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(470, 89)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(73, 13)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "Tipo Atencion"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(255, 85)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(58, 13)
        Me.Label38.TabIndex = 18
        Me.Label38.Text = "Hora Visita"
        '
        'txt_comentario
        '
        Me.txt_comentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comentario.ForeColor = System.Drawing.Color.Black
        Me.txt_comentario.Location = New System.Drawing.Point(330, 110)
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(357, 43)
        Me.txt_comentario.TabIndex = 19
        '
        'txt_tip_ate
        '
        Me.txt_tip_ate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tip_ate.ForeColor = System.Drawing.Color.Black
        Me.txt_tip_ate.Location = New System.Drawing.Point(561, 86)
        Me.txt_tip_ate.Name = "txt_tip_ate"
        Me.txt_tip_ate.Size = New System.Drawing.Size(74, 20)
        Me.txt_tip_ate.TabIndex = 19
        '
        'txt_hor_vis
        '
        Me.txt_hor_vis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hor_vis.ForeColor = System.Drawing.Color.Black
        Me.txt_hor_vis.Location = New System.Drawing.Point(330, 82)
        Me.txt_hor_vis.Name = "txt_hor_vis"
        Me.txt_hor_vis.Size = New System.Drawing.Size(74, 20)
        Me.txt_hor_vis.TabIndex = 19
        '
        'cmb_banco
        '
        Me.cmb_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_banco.ForeColor = System.Drawing.Color.Black
        Me.cmb_banco.FormattingEnabled = True
        Me.cmb_banco.Location = New System.Drawing.Point(330, 30)
        Me.cmb_banco.Name = "cmb_banco"
        Me.cmb_banco.Size = New System.Drawing.Size(305, 21)
        Me.cmb_banco.TabIndex = 17
        '
        'cmb_cta_cte
        '
        Me.cmb_cta_cte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cta_cte.ForeColor = System.Drawing.Color.Black
        Me.cmb_cta_cte.FormattingEnabled = True
        Me.cmb_cta_cte.Location = New System.Drawing.Point(330, 56)
        Me.cmb_cta_cte.Name = "cmb_cta_cte"
        Me.cmb_cta_cte.Size = New System.Drawing.Size(305, 21)
        Me.cmb_cta_cte.TabIndex = 17
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(40, 249)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(55, 13)
        Me.Label35.TabIndex = 15
        Me.Label35.Text = "Segmento"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.Navy
        Me.Label37.Location = New System.Drawing.Point(255, 59)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(42, 13)
        Me.Label37.TabIndex = 15
        Me.Label37.Text = "Cta Cte"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(254, 32)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(38, 13)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "Banco"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(9, 275)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(86, 13)
        Me.Label34.TabIndex = 15
        Me.Label34.Text = "Ubica Segmento"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(65, 221)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 13)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "Ruta"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(47, 197)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(48, 13)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Territorio"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(24, 171)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(71, 13)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Tipo Negocio"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(32, 145)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 13)
        Me.Label30.TabIndex = 15
        Me.Label30.Text = "Tipo Cliente"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(12, 90)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 13)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "Tot Letra Protes"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(25, 64)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 13)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "Total Factura"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(37, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 13)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Total Letra"
        '
        'txt_segmento
        '
        Me.txt_segmento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_segmento.ForeColor = System.Drawing.Color.Black
        Me.txt_segmento.Location = New System.Drawing.Point(101, 246)
        Me.txt_segmento.Name = "txt_segmento"
        Me.txt_segmento.Size = New System.Drawing.Size(103, 20)
        Me.txt_segmento.TabIndex = 16
        '
        'txt_ubi_seg
        '
        Me.txt_ubi_seg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ubi_seg.ForeColor = System.Drawing.Color.Black
        Me.txt_ubi_seg.Location = New System.Drawing.Point(101, 272)
        Me.txt_ubi_seg.Name = "txt_ubi_seg"
        Me.txt_ubi_seg.Size = New System.Drawing.Size(103, 20)
        Me.txt_ubi_seg.TabIndex = 16
        '
        'txt_ruta
        '
        Me.txt_ruta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruta.ForeColor = System.Drawing.Color.Black
        Me.txt_ruta.Location = New System.Drawing.Point(101, 220)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(103, 20)
        Me.txt_ruta.TabIndex = 16
        '
        'txt_territorio
        '
        Me.txt_territorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_territorio.ForeColor = System.Drawing.Color.Black
        Me.txt_territorio.Location = New System.Drawing.Point(101, 194)
        Me.txt_territorio.Name = "txt_territorio"
        Me.txt_territorio.Size = New System.Drawing.Size(103, 20)
        Me.txt_territorio.TabIndex = 16
        '
        'txt_tip_neg
        '
        Me.txt_tip_neg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tip_neg.ForeColor = System.Drawing.Color.Black
        Me.txt_tip_neg.Location = New System.Drawing.Point(101, 168)
        Me.txt_tip_neg.Name = "txt_tip_neg"
        Me.txt_tip_neg.Size = New System.Drawing.Size(103, 20)
        Me.txt_tip_neg.TabIndex = 16
        '
        'txt_tip_cli
        '
        Me.txt_tip_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tip_cli.ForeColor = System.Drawing.Color.Black
        Me.txt_tip_cli.Location = New System.Drawing.Point(101, 142)
        Me.txt_tip_cli.Name = "txt_tip_cli"
        Me.txt_tip_cli.Size = New System.Drawing.Size(103, 20)
        Me.txt_tip_cli.TabIndex = 16
        '
        'txt_tot_let_protes
        '
        Me.txt_tot_let_protes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_let_protes.ForeColor = System.Drawing.Color.Black
        Me.txt_tot_let_protes.Location = New System.Drawing.Point(101, 87)
        Me.txt_tot_let_protes.Name = "txt_tot_let_protes"
        Me.txt_tot_let_protes.Size = New System.Drawing.Size(103, 20)
        Me.txt_tot_let_protes.TabIndex = 16
        '
        'txt_tot_factura
        '
        Me.txt_tot_factura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_factura.ForeColor = System.Drawing.Color.Black
        Me.txt_tot_factura.Location = New System.Drawing.Point(101, 61)
        Me.txt_tot_factura.Name = "txt_tot_factura"
        Me.txt_tot_factura.Size = New System.Drawing.Size(103, 20)
        Me.txt_tot_factura.TabIndex = 16
        '
        'txt_tot_letra
        '
        Me.txt_tot_letra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_letra.ForeColor = System.Drawing.Color.Black
        Me.txt_tot_letra.Location = New System.Drawing.Point(101, 35)
        Me.txt_tot_letra.Name = "txt_tot_letra"
        Me.txt_tot_letra.Size = New System.Drawing.Size(103, 20)
        Me.txt_tot_letra.TabIndex = 16
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_eliminar, Me.btn_grabar, Me.btn_reporte, Me.btn_cancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(923, 25)
        Me.ToolStrip1.TabIndex = 12
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
        Me.btn_Editar.Size = New System.Drawing.Size(139, 22)
        Me.btn_Editar.Text = "Consultar/&Modificar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        '
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_reporte
        '
        Me.btn_reporte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reporte.Image = CType(resources.GetObject("btn_reporte.Image"), System.Drawing.Image)
        Me.btn_reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(73, 22)
        Me.btn_reporte.Text = "&Reporte"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'pnldirecentrega
        '
        Me.pnldirecentrega.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnldirecentrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnldirecentrega.Controls.Add(Me.txtcod_cliente_de)
        Me.pnldirecentrega.Controls.Add(Me.gb_principios_activos)
        Me.pnldirecentrega.Controls.Add(Me.btn_ok)
        Me.pnldirecentrega.Controls.Add(Me.GroupBox6)
        Me.pnldirecentrega.Controls.Add(Me.GroupBox5)
        Me.pnldirecentrega.Location = New System.Drawing.Point(51, 243)
        Me.pnldirecentrega.Name = "pnldirecentrega"
        Me.pnldirecentrega.Size = New System.Drawing.Size(831, 297)
        Me.pnldirecentrega.TabIndex = 183
        Me.pnldirecentrega.Visible = False
        '
        'txtcod_cliente_de
        '
        Me.txtcod_cliente_de.BackColor = System.Drawing.Color.Navy
        Me.txtcod_cliente_de.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcod_cliente_de.Enabled = False
        Me.txtcod_cliente_de.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtcod_cliente_de.ForeColor = System.Drawing.Color.White
        Me.txtcod_cliente_de.Location = New System.Drawing.Point(3, 14)
        Me.txtcod_cliente_de.Name = "txtcod_cliente_de"
        Me.txtcod_cliente_de.ReadOnly = True
        Me.txtcod_cliente_de.Size = New System.Drawing.Size(818, 20)
        Me.txtcod_cliente_de.TabIndex = 169
        Me.txtcod_cliente_de.Text = "..."
        Me.txtcod_cliente_de.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gb_principios_activos
        '
        Me.gb_principios_activos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_principios_activos.Controls.Add(Me.btn_limpiar)
        Me.gb_principios_activos.Controls.Add(Me.btn_exit)
        Me.gb_principios_activos.Controls.Add(Me.btn_add)
        Me.gb_principios_activos.Controls.Add(Me.btn_del)
        Me.gb_principios_activos.Controls.Add(Me.dgvDetalle)
        Me.gb_principios_activos.Location = New System.Drawing.Point(399, 7)
        Me.gb_principios_activos.Name = "gb_principios_activos"
        Me.gb_principios_activos.Size = New System.Drawing.Size(421, 275)
        Me.gb_principios_activos.TabIndex = 171
        Me.gb_principios_activos.TabStop = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.ForeColor = System.Drawing.Color.Navy
        Me.btn_limpiar.Image = CType(resources.GetObject("btn_limpiar.Image"), System.Drawing.Image)
        Me.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar.Location = New System.Drawing.Point(6, 29)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(77, 23)
        Me.btn_limpiar.TabIndex = 222
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.ForeColor = System.Drawing.Color.Navy
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(244, 29)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(77, 23)
        Me.btn_exit.TabIndex = 170
        Me.btn_exit.Text = "Retornar"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.Color.Navy
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(85, 29)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(77, 23)
        Me.btn_add.TabIndex = 49
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
        Me.btn_del.Location = New System.Drawing.Point(164, 29)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(77, 23)
        Me.btn_del.TabIndex = 48
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(7, 59)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(408, 209)
        Me.dgvDetalle.TabIndex = 47
        '
        'btn_ok
        '
        Me.btn_ok.ForeColor = System.Drawing.Color.Navy
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.Location = New System.Drawing.Point(139, 240)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(59, 37)
        Me.btn_ok.TabIndex = 111
        Me.btn_ok.Text = "Confirmar"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ok.UseVisualStyleBackColor = True
        Me.btn_ok.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PictureBox11)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.PictureBox12)
        Me.GroupBox6.Controls.Add(Me.PictureBox13)
        Me.GroupBox6.Controls.Add(Me.Label51)
        Me.GroupBox6.Controls.Add(Me.Label52)
        Me.GroupBox6.Controls.Add(Me.Label53)
        Me.GroupBox6.Controls.Add(Me.TextBox4)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.TextBox6)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(7, 94)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(385, 104)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Detalles "
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(121, 21)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox11.TabIndex = 218
        Me.PictureBox11.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(140, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(237, 20)
        Me.TextBox1.TabIndex = 215
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(140, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(237, 20)
        Me.TextBox2.TabIndex = 214
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(140, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(238, 20)
        Me.TextBox3.TabIndex = 211
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(121, 74)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox12.TabIndex = 217
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(121, 49)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox13.TabIndex = 216
        Me.PictureBox13.TabStop = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Navy
        Me.Label51.Location = New System.Drawing.Point(37, 77)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(39, 13)
        Me.Label51.TabIndex = 207
        Me.Label51.Text = "Distrito"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(25, 52)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(51, 13)
        Me.Label52.TabIndex = 208
        Me.Label52.Text = "Provincia"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(2, 25)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(74, 13)
        Me.Label53.TabIndex = 209
        Me.Label53.Text = "Departamento"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.ForeColor = System.Drawing.Color.Black
        Me.TextBox4.Location = New System.Drawing.Point(80, 73)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(40, 20)
        Me.TextBox4.TabIndex = 213
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.Color.Black
        Me.TextBox5.Location = New System.Drawing.Point(80, 48)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(40, 20)
        Me.TextBox5.TabIndex = 212
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.ForeColor = System.Drawing.Color.Black
        Me.TextBox6.Location = New System.Drawing.Point(80, 21)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(40, 20)
        Me.TextBox6.TabIndex = 210
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtdirecentrega)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(384, 48)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Dirección de Etrega"
        '
        'txtdirecentrega
        '
        Me.txtdirecentrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdirecentrega.Location = New System.Drawing.Point(7, 15)
        Me.txtdirecentrega.MaxLength = 200
        Me.txtdirecentrega.Name = "txtdirecentrega"
        Me.txtdirecentrega.Size = New System.Drawing.Size(371, 20)
        Me.txtdirecentrega.TabIndex = 178
        '
        'pnlreporte
        '
        Me.pnlreporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlreporte.Controls.Add(Me.TextBox7)
        Me.pnlreporte.Controls.Add(Me.GroupBox4)
        Me.pnlreporte.Controls.Add(Me.GroupBox7)
        Me.pnlreporte.Location = New System.Drawing.Point(222, 62)
        Me.pnlreporte.Name = "pnlreporte"
        Me.pnlreporte.Size = New System.Drawing.Size(475, 212)
        Me.pnlreporte.TabIndex = 185
        Me.pnlreporte.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Navy
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(1, 1)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(473, 20)
        Me.TextBox7.TabIndex = 168
        Me.TextBox7.Text = "REPORTE DE CLIENTE"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtcodigo2)
        Me.GroupBox4.Controls.Add(Me.txtdescripcion2)
        Me.GroupBox4.Controls.Add(Me.txtcodigo1)
        Me.GroupBox4.Controls.Add(Me.txtdescripcion1)
        Me.GroupBox4.Controls.Add(Me.chk_todos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(183, 49)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 154)
        Me.GroupBox4.TabIndex = 169
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalles del Reporte"
        '
        'txtcodigo2
        '
        Me.txtcodigo2.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo2.Location = New System.Drawing.Point(10, 79)
        Me.txtcodigo2.Name = "txtcodigo2"
        Me.txtcodigo2.Size = New System.Drawing.Size(263, 20)
        Me.txtcodigo2.TabIndex = 4
        '
        'txtdescripcion2
        '
        Me.txtdescripcion2.AutoSize = True
        Me.txtdescripcion2.Location = New System.Drawing.Point(10, 60)
        Me.txtdescripcion2.Name = "txtdescripcion2"
        Me.txtdescripcion2.Size = New System.Drawing.Size(16, 13)
        Me.txtdescripcion2.TabIndex = 3
        Me.txtdescripcion2.Text = "..."
        '
        'txtcodigo1
        '
        Me.txtcodigo1.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo1.Location = New System.Drawing.Point(10, 35)
        Me.txtcodigo1.Name = "txtcodigo1"
        Me.txtcodigo1.Size = New System.Drawing.Size(263, 20)
        Me.txtcodigo1.TabIndex = 2
        '
        'txtdescripcion1
        '
        Me.txtdescripcion1.AutoSize = True
        Me.txtdescripcion1.ForeColor = System.Drawing.Color.Navy
        Me.txtdescripcion1.Location = New System.Drawing.Point(10, 17)
        Me.txtdescripcion1.Name = "txtdescripcion1"
        Me.txtdescripcion1.Size = New System.Drawing.Size(16, 13)
        Me.txtdescripcion1.TabIndex = 1
        Me.txtdescripcion1.Text = "..."
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos.Location = New System.Drawing.Point(10, 117)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(84, 17)
        Me.chk_todos.TabIndex = 0
        Me.chk_todos.Text = "Listar Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rbtipocliente)
        Me.GroupBox7.Controls.Add(Me.rbvendedor)
        Me.GroupBox7.Controls.Add(Me.Button1)
        Me.GroupBox7.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox7.Controls.Add(Me.rbcodigo)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(10, 47)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(167, 156)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Opciones de impresion"
        '
        'rbtipocliente
        '
        Me.rbtipocliente.AutoSize = True
        Me.rbtipocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbtipocliente.Location = New System.Drawing.Point(7, 67)
        Me.rbtipocliente.Name = "rbtipocliente"
        Me.rbtipocliente.Size = New System.Drawing.Size(111, 17)
        Me.rbtipocliente.TabIndex = 169
        Me.rbtipocliente.Text = "Por tipo de Cliente"
        Me.rbtipocliente.UseVisualStyleBackColor = True
        '
        'rbvendedor
        '
        Me.rbvendedor.AutoSize = True
        Me.rbvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbvendedor.Location = New System.Drawing.Point(7, 45)
        Me.rbvendedor.Name = "rbvendedor"
        Me.rbvendedor.Size = New System.Drawing.Size(89, 17)
        Me.rbvendedor.TabIndex = 169
        Me.rbvendedor.Text = "Por vendedor"
        Me.rbvendedor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(85, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Navy
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Aceptar.Location = New System.Drawing.Point(9, 104)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(75, 39)
        Me.btn_Aceptar.TabIndex = 122
        Me.btn_Aceptar.Text = "Ver Reporte"
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
        'frm_CX_MA_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(923, 619)
        Me.Controls.Add(Me.pnlreporte)
        Me.Controls.Add(Me.pnldirecentrega)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_tipos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CX_MA_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tipo_cliente.ResumeLayout(False)
        Me.gb_tipo_cliente.PerformLayout()
        Me.gbGenerarCodigo.ResumeLayout(False)
        Me.gbGenerarCodigo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_estado.ResumeLayout(False)
        Me.gb_estado.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.gb_mas_datos.ResumeLayout(False)
        Me.gb_mas_datos.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnldirecentrega.ResumeLayout(False)
        Me.pnldirecentrega.PerformLayout()
        Me.gb_principios_activos.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.pnlreporte.ResumeLayout(False)
        Me.pnlreporte.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tc_tipos As System.Windows.Forms.TabControl
    Private WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents dgv_Lista As System.Windows.Forms.DataGridView
    Private WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents gb_data As System.Windows.Forms.GroupBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txt_tip_precio As System.Windows.Forms.TextBox
    Private WithEvents txt_ruc_cli As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tip_doc_per As System.Windows.Forms.ComboBox
    Friend WithEvents rb_inactivo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_activo As System.Windows.Forms.RadioButton
    Private WithEvents txt_telf_cli As System.Windows.Forms.TextBox
    Private WithEvents txt_dir_cli As System.Windows.Forms.TextBox
    Private WithEvents txt_des_cli As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_cli As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents txt_cod_mon_cre As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents txt_cod_dist As System.Windows.Forms.TextBox
    Private WithEvents txt_contacto As System.Windows.Forms.TextBox
    Private WithEvents txt_web As System.Windows.Forms.TextBox
    Private WithEvents txt_mail As System.Windows.Forms.TextBox
    Private WithEvents txt_saldo_dol As System.Windows.Forms.TextBox
    Private WithEvents txt_saldo_sol As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_pross As System.Windows.Forms.TextBox
    Private WithEvents txt_lim_dol As System.Windows.Forms.TextBox
    Private WithEvents txt_lim_sol As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_prov As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_dep As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_zon_ven As System.Windows.Forms.TextBox
    Private WithEvents txt_pais As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_vende As System.Windows.Forms.TextBox
    Private WithEvents txt_cond_pago As System.Windows.Forms.TextBox
    Private WithEvents txt_porc_descto As System.Windows.Forms.TextBox
    Private WithEvents txt_num_doc As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Private WithEvents Label40 As System.Windows.Forms.Label
    Private WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents gbGenerarCodigo As System.Windows.Forms.GroupBox
    Private WithEvents txtdescripciondepartamento As System.Windows.Forms.TextBox
    Private WithEvents txtDepartamento As System.Windows.Forms.TextBox
    Private WithEvents Label43 As System.Windows.Forms.Label
    Private WithEvents txtdescripcionTipocliente As System.Windows.Forms.TextBox
    Private WithEvents txtTipoCliente As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Private WithEvents txt_desc_dist As System.Windows.Forms.TextBox
    Private WithEvents txt_desc_prov As System.Windows.Forms.TextBox
    Private WithEvents txt_des_depart As System.Windows.Forms.TextBox
    Friend WithEvents txt_obs As System.Windows.Forms.RichTextBox
    Private WithEvents txt_desc_vende As System.Windows.Forms.TextBox
    Private WithEvents txt_desc_pago As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents gb_estado As System.Windows.Forms.GroupBox
    Private WithEvents Label44 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents txtnombreComercial As System.Windows.Forms.TextBox
    Friend WithEvents gb_mas_datos As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Private WithEvents Label47 As System.Windows.Forms.Label
    Private WithEvents txtcuentaContableDol As System.Windows.Forms.TextBox
    Private WithEvents Label46 As System.Windows.Forms.Label
    Private WithEvents txtcuentaContableSol As System.Windows.Forms.TextBox
    Friend WithEvents checkRetencion As System.Windows.Forms.CheckBox
    Private WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFarmacia As System.Windows.Forms.RadioButton
    Friend WithEvents rbdistribuidor As System.Windows.Forms.RadioButton
    Private WithEvents Label42 As System.Windows.Forms.Label
    Private WithEvents txt_tot_cheque As System.Windows.Forms.TextBox
    Private WithEvents Label41 As System.Windows.Forms.Label
    Private WithEvents Label39 As System.Windows.Forms.Label
    Private WithEvents Label38 As System.Windows.Forms.Label
    Private WithEvents txt_comentario As System.Windows.Forms.TextBox
    Private WithEvents txt_tip_ate As System.Windows.Forms.TextBox
    Private WithEvents txt_hor_vis As System.Windows.Forms.TextBox
    Friend WithEvents cmb_banco As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cta_cte As System.Windows.Forms.ComboBox
    Private WithEvents Label35 As System.Windows.Forms.Label
    Private WithEvents Label37 As System.Windows.Forms.Label
    Private WithEvents Label36 As System.Windows.Forms.Label
    Private WithEvents Label34 As System.Windows.Forms.Label
    Private WithEvents Label33 As System.Windows.Forms.Label
    Private WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents Label31 As System.Windows.Forms.Label
    Private WithEvents Label30 As System.Windows.Forms.Label
    Private WithEvents Label29 As System.Windows.Forms.Label
    Private WithEvents Label28 As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents txt_segmento As System.Windows.Forms.TextBox
    Private WithEvents txt_ubi_seg As System.Windows.Forms.TextBox
    Private WithEvents txt_ruta As System.Windows.Forms.TextBox
    Private WithEvents txt_territorio As System.Windows.Forms.TextBox
    Private WithEvents txt_tip_neg As System.Windows.Forms.TextBox
    Private WithEvents txt_tip_cli As System.Windows.Forms.TextBox
    Private WithEvents txt_tot_let_protes As System.Windows.Forms.TextBox
    Private WithEvents txt_tot_factura As System.Windows.Forms.TextBox
    Private WithEvents txt_tot_letra As System.Windows.Forms.TextBox
    Private WithEvents txtdescripcionTipoEmp As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Private WithEvents Label48 As System.Windows.Forms.Label
    Private WithEvents txtcodigoTipoEmp As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gb_tipo_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents rb_sede As System.Windows.Forms.RadioButton
    Friend WithEvents rb_principal As System.Windows.Forms.RadioButton
    Private WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents cbo_direc_entrega As System.Windows.Forms.ComboBox
    Private WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents btndirecentrega As System.Windows.Forms.Button
    Friend WithEvents pnldirecentrega As System.Windows.Forms.Panel
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents txtcod_cliente_de As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private WithEvents TextBox2 As System.Windows.Forms.TextBox
    Private WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Private WithEvents Label51 As System.Windows.Forms.Label
    Private WithEvents Label52 As System.Windows.Forms.Label
    Private WithEvents Label53 As System.Windows.Forms.Label
    Private WithEvents TextBox4 As System.Windows.Forms.TextBox
    Private WithEvents TextBox5 As System.Windows.Forms.TextBox
    Private WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdirecentrega As System.Windows.Forms.TextBox
    Friend WithEvents gb_principios_activos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Private WithEvents txt_des_tip_precio As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Private WithEvents txt_segundo_nombre As System.Windows.Forms.TextBox
    Private WithEvents Label56 As System.Windows.Forms.Label
    Private WithEvents txt_primer_nombre As System.Windows.Forms.TextBox
    Private WithEvents Label57 As System.Windows.Forms.Label
    Private WithEvents txt_ap_materno As System.Windows.Forms.TextBox
    Private WithEvents Label55 As System.Windows.Forms.Label
    Private WithEvents txt_ap_paterno As System.Windows.Forms.TextBox
    Private WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents btn_reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlreporte As System.Windows.Forms.Panel
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodigo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion1 As System.Windows.Forms.Label
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtipocliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbvendedor As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents chk_validacion_fe As System.Windows.Forms.CheckBox
    Friend WithEvents Button22 As Button
    Friend WithEvents Button21 As Button
End Class
