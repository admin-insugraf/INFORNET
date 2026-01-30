<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_Proveedor))
        Me.tc_proveedor = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_proveedor = New System.Windows.Forms.DataGridView()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.txt_segundo_nombre = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_primer_nombre = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_ap_materno = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_ap_paterno = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txt_des_pais = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_cod_pais = New System.Windows.Forms.TextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.cmb_tc = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.cmb_td = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcuentaContableDol = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcuentaContableSol = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.txt_contacto = New System.Windows.Forms.TextBox()
        Me.txt_web = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.txt_ruc = New System.Windows.Forms.TextBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.txt_des_distrito = New System.Windows.Forms.TextBox()
        Me.txt_des_provincia = New System.Windows.Forms.TextBox()
        Me.txt_des_departamento = New System.Windows.Forms.TextBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txt_cod_distrito = New System.Windows.Forms.TextBox()
        Me.txt_cod_provincia = New System.Windows.Forms.TextBox()
        Me.txt_cod_departamento = New System.Windows.Forms.TextBox()
        Me.tc_proveedor.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc_proveedor
        '
        Me.tc_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_proveedor.Controls.Add(Me.TabPage1)
        Me.tc_proveedor.Controls.Add(Me.TabPage2)
        Me.tc_proveedor.Location = New System.Drawing.Point(17, 29)
        Me.tc_proveedor.Name = "tc_proveedor"
        Me.tc_proveedor.SelectedIndex = 0
        Me.tc_proveedor.Size = New System.Drawing.Size(590, 583)
        Me.tc_proveedor.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgv_proveedor)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(582, 499)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Proveedores"
        '
        'dgv_proveedor
        '
        Me.dgv_proveedor.AllowUserToAddRows = False
        Me.dgv_proveedor.AllowUserToDeleteRows = False
        Me.dgv_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedor.Location = New System.Drawing.Point(6, 62)
        Me.dgv_proveedor.Name = "dgv_proveedor"
        Me.dgv_proveedor.ReadOnly = True
        Me.dgv_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_proveedor.Size = New System.Drawing.Size(570, 414)
        Me.dgv_proveedor.TabIndex = 123
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(8, 479)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 122
        Me.lblCantidad.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(454, 45)
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
        Me.txtFiltro.Size = New System.Drawing.Size(440, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(582, 557)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.PictureBox11)
        Me.gb_data.Controls.Add(Me.txt_des_distrito)
        Me.gb_data.Controls.Add(Me.txt_des_provincia)
        Me.gb_data.Controls.Add(Me.txt_des_departamento)
        Me.gb_data.Controls.Add(Me.PictureBox12)
        Me.gb_data.Controls.Add(Me.PictureBox13)
        Me.gb_data.Controls.Add(Me.Label51)
        Me.gb_data.Controls.Add(Me.Label52)
        Me.gb_data.Controls.Add(Me.Label53)
        Me.gb_data.Controls.Add(Me.txt_cod_distrito)
        Me.gb_data.Controls.Add(Me.txt_cod_provincia)
        Me.gb_data.Controls.Add(Me.txt_cod_departamento)
        Me.gb_data.Controls.Add(Me.Button22)
        Me.gb_data.Controls.Add(Me.Button21)
        Me.gb_data.Controls.Add(Me.txt_segundo_nombre)
        Me.gb_data.Controls.Add(Me.Label56)
        Me.gb_data.Controls.Add(Me.txt_primer_nombre)
        Me.gb_data.Controls.Add(Me.Label57)
        Me.gb_data.Controls.Add(Me.txt_ap_materno)
        Me.gb_data.Controls.Add(Me.Label55)
        Me.gb_data.Controls.Add(Me.txt_ap_paterno)
        Me.gb_data.Controls.Add(Me.Label54)
        Me.gb_data.Controls.Add(Me.txt_des_pais)
        Me.gb_data.Controls.Add(Me.PictureBox1)
        Me.gb_data.Controls.Add(Me.Label11)
        Me.gb_data.Controls.Add(Me.txt_cod_pais)
        Me.gb_data.Controls.Add(Me.PictureBox8)
        Me.gb_data.Controls.Add(Me.cmb_tc)
        Me.gb_data.Controls.Add(Me.PictureBox5)
        Me.gb_data.Controls.Add(Me.cmb_td)
        Me.gb_data.Controls.Add(Me.Label47)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.txtcuentaContableDol)
        Me.gb_data.Controls.Add(Me.Label46)
        Me.gb_data.Controls.Add(Me.Label5)
        Me.gb_data.Controls.Add(Me.txtcuentaContableSol)
        Me.gb_data.Controls.Add(Me.Label10)
        Me.gb_data.Controls.Add(Me.Label9)
        Me.gb_data.Controls.Add(Me.Label8)
        Me.gb_data.Controls.Add(Me.Label7)
        Me.gb_data.Controls.Add(Me.Label4)
        Me.gb_data.Controls.Add(Me.Label2)
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Controls.Add(Me.Label6)
        Me.gb_data.Controls.Add(Me.txt_cod)
        Me.gb_data.Controls.Add(Me.txt_mail)
        Me.gb_data.Controls.Add(Me.txt_contacto)
        Me.gb_data.Controls.Add(Me.txt_web)
        Me.gb_data.Controls.Add(Me.txt_tel)
        Me.gb_data.Controls.Add(Me.txt_dir)
        Me.gb_data.Controls.Add(Me.txt_ruc)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.ForeColor = System.Drawing.Color.Navy
        Me.gb_data.Location = New System.Drawing.Point(13, 4)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(556, 542)
        Me.gb_data.TabIndex = 6
        Me.gb_data.TabStop = False
        '
        'Button22
        '
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.Green
        Me.Button22.Image = CType(resources.GetObject("Button22.Image"), System.Drawing.Image)
        Me.Button22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button22.Location = New System.Drawing.Point(393, 18)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(131, 22)
        Me.Button22.TabIndex = 255
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
        Me.Button21.Location = New System.Drawing.Point(256, 18)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(131, 22)
        Me.Button21.TabIndex = 254
        Me.Button21.Text = "Consultar RUC"
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button21.UseVisualStyleBackColor = True
        '
        'txt_segundo_nombre
        '
        Me.txt_segundo_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_segundo_nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_segundo_nombre.Location = New System.Drawing.Point(90, 203)
        Me.txt_segundo_nombre.MaxLength = 200
        Me.txt_segundo_nombre.Name = "txt_segundo_nombre"
        Me.txt_segundo_nombre.Size = New System.Drawing.Size(432, 20)
        Me.txt_segundo_nombre.TabIndex = 227
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.Navy
        Me.Label56.Location = New System.Drawing.Point(9, 206)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(73, 13)
        Me.Label56.TabIndex = 226
        Me.Label56.Text = "Sgdo. nombre"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_primer_nombre
        '
        Me.txt_primer_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_primer_nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_primer_nombre.Location = New System.Drawing.Point(90, 178)
        Me.txt_primer_nombre.MaxLength = 200
        Me.txt_primer_nombre.Name = "txt_primer_nombre"
        Me.txt_primer_nombre.Size = New System.Drawing.Size(432, 20)
        Me.txt_primer_nombre.TabIndex = 225
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.Navy
        Me.Label57.Location = New System.Drawing.Point(24, 180)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(58, 13)
        Me.Label57.TabIndex = 224
        Me.Label57.Text = "Pr. nombre"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ap_materno
        '
        Me.txt_ap_materno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ap_materno.ForeColor = System.Drawing.Color.Black
        Me.txt_ap_materno.Location = New System.Drawing.Point(90, 152)
        Me.txt_ap_materno.MaxLength = 200
        Me.txt_ap_materno.Name = "txt_ap_materno"
        Me.txt_ap_materno.Size = New System.Drawing.Size(432, 20)
        Me.txt_ap_materno.TabIndex = 223
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Navy
        Me.Label55.Location = New System.Drawing.Point(21, 155)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(65, 13)
        Me.Label55.TabIndex = 222
        Me.Label55.Text = "Ap. Materno"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ap_paterno
        '
        Me.txt_ap_paterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ap_paterno.ForeColor = System.Drawing.Color.Black
        Me.txt_ap_paterno.Location = New System.Drawing.Point(90, 126)
        Me.txt_ap_paterno.MaxLength = 200
        Me.txt_ap_paterno.Name = "txt_ap_paterno"
        Me.txt_ap_paterno.Size = New System.Drawing.Size(432, 20)
        Me.txt_ap_paterno.TabIndex = 221
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(23, 129)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(63, 13)
        Me.Label54.TabIndex = 220
        Me.Label54.Text = "Ap. Paterno"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_des_pais
        '
        Me.txt_des_pais.BackColor = System.Drawing.Color.White
        Me.txt_des_pais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_pais.Enabled = False
        Me.txt_des_pais.ForeColor = System.Drawing.Color.Black
        Me.txt_des_pais.Location = New System.Drawing.Point(234, 366)
        Me.txt_des_pais.MaxLength = 40
        Me.txt_des_pais.Name = "txt_des_pais"
        Me.txt_des_pais.ReadOnly = True
        Me.txt_des_pais.Size = New System.Drawing.Size(288, 20)
        Me.txt_des_pais.TabIndex = 124
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(209, 367)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(57, 370)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "Pais"
        '
        'txt_cod_pais
        '
        Me.txt_cod_pais.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_pais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_pais.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_pais.Location = New System.Drawing.Point(90, 366)
        Me.txt_cod_pais.MaxLength = 40
        Me.txt_cod_pais.Name = "txt_cod_pais"
        Me.txt_cod_pais.ReadOnly = True
        Me.txt_cod_pais.Size = New System.Drawing.Size(114, 20)
        Me.txt_cod_pais.TabIndex = 122
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(138, 479)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox8.TabIndex = 120
        Me.PictureBox8.TabStop = False
        '
        'cmb_tc
        '
        Me.cmb_tc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tc.FormattingEnabled = True
        Me.cmb_tc.Location = New System.Drawing.Point(90, 73)
        Me.cmb_tc.Name = "cmb_tc"
        Me.cmb_tc.Size = New System.Drawing.Size(432, 21)
        Me.cmb_tc.TabIndex = 2
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(138, 505)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox5.TabIndex = 119
        Me.PictureBox5.TabStop = False
        '
        'cmb_td
        '
        Me.cmb_td.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_td.FormattingEnabled = True
        Me.cmb_td.Location = New System.Drawing.Point(90, 46)
        Me.cmb_td.Name = "cmb_td"
        Me.cmb_td.Size = New System.Drawing.Size(432, 21)
        Me.cmb_td.TabIndex = 1
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(32, 508)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(102, 13)
        Me.Label47.TabIndex = 117
        Me.Label47.Text = "Cuenta en dolares $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo"
        '
        'txtcuentaContableDol
        '
        Me.txtcuentaContableDol.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcuentaContableDol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaContableDol.ForeColor = System.Drawing.Color.Black
        Me.txtcuentaContableDol.Location = New System.Drawing.Point(159, 504)
        Me.txtcuentaContableDol.MaxLength = 40
        Me.txtcuentaContableDol.Name = "txtcuentaContableDol"
        Me.txtcuentaContableDol.ReadOnly = True
        Me.txtcuentaContableDol.Size = New System.Drawing.Size(140, 20)
        Me.txtcuentaContableDol.TabIndex = 118
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(33, 482)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(101, 13)
        Me.Label46.TabIndex = 115
        Me.Label46.Text = "Cuenta en soles S/."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Mail"
        '
        'txtcuentaContableSol
        '
        Me.txtcuentaContableSol.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcuentaContableSol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaContableSol.ForeColor = System.Drawing.Color.Black
        Me.txtcuentaContableSol.Location = New System.Drawing.Point(159, 478)
        Me.txtcuentaContableSol.MaxLength = 40
        Me.txtcuentaContableSol.Name = "txtcuentaContableSol"
        Me.txtcuentaContableSol.ReadOnly = True
        Me.txtcuentaContableSol.Size = New System.Drawing.Size(140, 20)
        Me.txtcuentaContableSol.TabIndex = 116
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Tipo Cia."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Tipo Doc"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 453)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Contacto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Web Site"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Direccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ruc"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Razón Social"
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(90, 19)
        Me.txt_cod.MaxLength = 11
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(160, 20)
        Me.txt_cod.TabIndex = 0
        '
        'txt_mail
        '
        Me.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mail.Location = New System.Drawing.Point(256, 393)
        Me.txt_mail.MaxLength = 50
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(266, 20)
        Me.txt_mail.TabIndex = 7
        '
        'txt_contacto
        '
        Me.txt_contacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_contacto.Location = New System.Drawing.Point(90, 450)
        Me.txt_contacto.MaxLength = 60
        Me.txt_contacto.Name = "txt_contacto"
        Me.txt_contacto.Size = New System.Drawing.Size(432, 20)
        Me.txt_contacto.TabIndex = 9
        '
        'txt_web
        '
        Me.txt_web.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_web.Location = New System.Drawing.Point(90, 422)
        Me.txt_web.MaxLength = 50
        Me.txt_web.Name = "txt_web"
        Me.txt_web.Size = New System.Drawing.Size(432, 20)
        Me.txt_web.TabIndex = 8
        '
        'txt_tel
        '
        Me.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tel.Location = New System.Drawing.Point(90, 393)
        Me.txt_tel.MaxLength = 20
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(114, 20)
        Me.txt_tel.TabIndex = 6
        '
        'txt_dir
        '
        Me.txt_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dir.Location = New System.Drawing.Point(90, 255)
        Me.txt_dir.MaxLength = 200
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(432, 20)
        Me.txt_dir.TabIndex = 5
        '
        'txt_ruc
        '
        Me.txt_ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc.Location = New System.Drawing.Point(90, 229)
        Me.txt_ruc.MaxLength = 11
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Size = New System.Drawing.Size(432, 20)
        Me.txt_ruc.TabIndex = 4
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(90, 100)
        Me.txt_des.MaxLength = 200
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(432, 20)
        Me.txt_des.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_eliminar, Me.btn_grabar, Me.btn_cancelar, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(623, 25)
        Me.ToolStrip1.TabIndex = 203
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
        Me.btn_Editar.Text = "&Consultar/Modificar"
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
        Me.btn_grabar.Size = New System.Drawing.Size(73, 22)
        Me.btn_grabar.Text = "&Guardar"
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
        'ToolStripButton8
        '
        Me.ToolStripButton8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton8.Text = "&Salir"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(134, 284)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox11.TabIndex = 267
        Me.PictureBox11.TabStop = False
        '
        'txt_des_distrito
        '
        Me.txt_des_distrito.BackColor = System.Drawing.Color.White
        Me.txt_des_distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_distrito.Enabled = False
        Me.txt_des_distrito.ForeColor = System.Drawing.Color.Black
        Me.txt_des_distrito.Location = New System.Drawing.Point(156, 336)
        Me.txt_des_distrito.Name = "txt_des_distrito"
        Me.txt_des_distrito.ReadOnly = True
        Me.txt_des_distrito.Size = New System.Drawing.Size(365, 20)
        Me.txt_des_distrito.TabIndex = 264
        '
        'txt_des_provincia
        '
        Me.txt_des_provincia.BackColor = System.Drawing.Color.White
        Me.txt_des_provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_provincia.Enabled = False
        Me.txt_des_provincia.ForeColor = System.Drawing.Color.Black
        Me.txt_des_provincia.Location = New System.Drawing.Point(156, 312)
        Me.txt_des_provincia.Name = "txt_des_provincia"
        Me.txt_des_provincia.ReadOnly = True
        Me.txt_des_provincia.Size = New System.Drawing.Size(365, 20)
        Me.txt_des_provincia.TabIndex = 263
        '
        'txt_des_departamento
        '
        Me.txt_des_departamento.BackColor = System.Drawing.Color.White
        Me.txt_des_departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_departamento.Enabled = False
        Me.txt_des_departamento.ForeColor = System.Drawing.Color.Black
        Me.txt_des_departamento.Location = New System.Drawing.Point(156, 284)
        Me.txt_des_departamento.Name = "txt_des_departamento"
        Me.txt_des_departamento.ReadOnly = True
        Me.txt_des_departamento.Size = New System.Drawing.Size(366, 20)
        Me.txt_des_departamento.TabIndex = 260
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(134, 337)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox12.TabIndex = 266
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(134, 312)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox13.TabIndex = 265
        Me.PictureBox13.TabStop = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Navy
        Me.Label51.Location = New System.Drawing.Point(47, 340)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(39, 13)
        Me.Label51.TabIndex = 256
        Me.Label51.Text = "Distrito"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(35, 315)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(51, 13)
        Me.Label52.TabIndex = 257
        Me.Label52.Text = "Provincia"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(12, 288)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(74, 13)
        Me.Label53.TabIndex = 258
        Me.Label53.Text = "Departamento"
        '
        'txt_cod_distrito
        '
        Me.txt_cod_distrito.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_distrito.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_distrito.Location = New System.Drawing.Point(90, 336)
        Me.txt_cod_distrito.Name = "txt_cod_distrito"
        Me.txt_cod_distrito.ReadOnly = True
        Me.txt_cod_distrito.Size = New System.Drawing.Size(40, 20)
        Me.txt_cod_distrito.TabIndex = 262
        '
        'txt_cod_provincia
        '
        Me.txt_cod_provincia.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_provincia.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_provincia.Location = New System.Drawing.Point(90, 311)
        Me.txt_cod_provincia.Name = "txt_cod_provincia"
        Me.txt_cod_provincia.ReadOnly = True
        Me.txt_cod_provincia.Size = New System.Drawing.Size(40, 20)
        Me.txt_cod_provincia.TabIndex = 261
        '
        'txt_cod_departamento
        '
        Me.txt_cod_departamento.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_departamento.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_departamento.Location = New System.Drawing.Point(90, 284)
        Me.txt_cod_departamento.Name = "txt_cod_departamento"
        Me.txt_cod_departamento.ReadOnly = True
        Me.txt_cod_departamento.Size = New System.Drawing.Size(40, 20)
        Me.txt_cod_departamento.TabIndex = 259
        '
        'frm_CX_MA_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(623, 618)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_proveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CX_MA_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor"
        Me.tc_proveedor.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_proveedor As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_data As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tc As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_td As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents txt_contacto As System.Windows.Forms.TextBox
    Friend WithEvents txt_web As System.Windows.Forms.TextBox
    Friend WithEvents txt_tel As System.Windows.Forms.TextBox
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents txt_ruc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents NAME_PROV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Private WithEvents Label47 As System.Windows.Forms.Label
    Private WithEvents txtcuentaContableDol As System.Windows.Forms.TextBox
    Private WithEvents Label46 As System.Windows.Forms.Label
    Private WithEvents txtcuentaContableSol As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents txt_cod_pais As System.Windows.Forms.TextBox
    Private WithEvents txt_des_pais As System.Windows.Forms.TextBox
    Private WithEvents txt_segundo_nombre As System.Windows.Forms.TextBox
    Private WithEvents Label56 As System.Windows.Forms.Label
    Private WithEvents txt_primer_nombre As System.Windows.Forms.TextBox
    Private WithEvents Label57 As System.Windows.Forms.Label
    Private WithEvents txt_ap_materno As System.Windows.Forms.TextBox
    Private WithEvents Label55 As System.Windows.Forms.Label
    Private WithEvents txt_ap_paterno As System.Windows.Forms.TextBox
    Private WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Private WithEvents txt_des_distrito As System.Windows.Forms.TextBox
    Private WithEvents txt_des_provincia As System.Windows.Forms.TextBox
    Private WithEvents txt_des_departamento As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Private WithEvents Label51 As System.Windows.Forms.Label
    Private WithEvents Label52 As System.Windows.Forms.Label
    Private WithEvents Label53 As System.Windows.Forms.Label
    Private WithEvents txt_cod_distrito As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_provincia As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_departamento As System.Windows.Forms.TextBox
End Class
