<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_Vendedores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_Vendedores))
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.dgv_lista = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.gbdatosvendedor = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcioncliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_ruc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telf = New System.Windows.Forms.TextBox()
        Me.txtcodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtDescripcionUbigeo = New System.Windows.Forms.TextBox()
        Me.txtcodigoUbigeo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlreporte = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rb_ambos = New System.Windows.Forms.RadioButton()
        Me.rb_inactivo = New System.Windows.Forms.RadioButton()
        Me.rb_activo = New System.Windows.Forms.RadioButton()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_datos.SuspendLayout()
        Me.gbdatosvendedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlreporte.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 30)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(548, 348)
        Me.tc_tipos.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.dgv_lista)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(540, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Registros"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(7, 299)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 119
        Me.lblCantidad.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(528, 45)
        Me.GroupBox3.TabIndex = 120
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
        Me.txtFiltro.Size = New System.Drawing.Size(515, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'dgv_lista
        '
        Me.dgv_lista.AllowUserToAddRows = False
        Me.dgv_lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista.Location = New System.Drawing.Point(3, 57)
        Me.dgv_lista.MultiSelect = False
        Me.dgv_lista.Name = "dgv_lista"
        Me.dgv_lista.ReadOnly = True
        Me.dgv_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista.Size = New System.Drawing.Size(534, 235)
        Me.dgv_lista.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.gb_datos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(540, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion de Datos"
        '
        'gb_datos
        '
        Me.gb_datos.BackColor = System.Drawing.Color.Transparent
        Me.gb_datos.Controls.Add(Me.gbdatosvendedor)
        Me.gb_datos.Controls.Add(Me.txtDescripcionUbigeo)
        Me.gb_datos.Controls.Add(Me.txtcodigoUbigeo)
        Me.gb_datos.Controls.Add(Me.Label7)
        Me.gb_datos.Location = New System.Drawing.Point(19, 9)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(504, 306)
        Me.gb_datos.TabIndex = 3
        Me.gb_datos.TabStop = False
        '
        'gbdatosvendedor
        '
        Me.gbdatosvendedor.Controls.Add(Me.PictureBox1)
        Me.gbdatosvendedor.Controls.Add(Me.txtdescripcioncliente)
        Me.gbdatosvendedor.Controls.Add(Me.Label10)
        Me.gbdatosvendedor.Controls.Add(Me.Label3)
        Me.gbdatosvendedor.Controls.Add(Me.chk_estado)
        Me.gbdatosvendedor.Controls.Add(Me.Label9)
        Me.gbdatosvendedor.Controls.Add(Me.dtpFechaIngreso)
        Me.gbdatosvendedor.Controls.Add(Me.Label8)
        Me.gbdatosvendedor.Controls.Add(Me.txt_des)
        Me.gbdatosvendedor.Controls.Add(Me.Label2)
        Me.gbdatosvendedor.Controls.Add(Me.Label1)
        Me.gbdatosvendedor.Controls.Add(Me.txt_cod)
        Me.gbdatosvendedor.Controls.Add(Me.txt_ruc)
        Me.gbdatosvendedor.Controls.Add(Me.Label6)
        Me.gbdatosvendedor.Controls.Add(Me.txt_correo)
        Me.gbdatosvendedor.Controls.Add(Me.txt_dir)
        Me.gbdatosvendedor.Controls.Add(Me.Label5)
        Me.gbdatosvendedor.Controls.Add(Me.Label4)
        Me.gbdatosvendedor.Controls.Add(Me.txt_telf)
        Me.gbdatosvendedor.Controls.Add(Me.txtcodigoCliente)
        Me.gbdatosvendedor.Enabled = False
        Me.gbdatosvendedor.Location = New System.Drawing.Point(23, 48)
        Me.gbdatosvendedor.Name = "gbdatosvendedor"
        Me.gbdatosvendedor.Size = New System.Drawing.Size(469, 246)
        Me.gbdatosvendedor.TabIndex = 9
        Me.gbdatosvendedor.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(77, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(14, 16)
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcioncliente
        '
        Me.txtdescripcioncliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcioncliente.Enabled = False
        Me.txtdescripcioncliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcioncliente.Location = New System.Drawing.Point(97, 187)
        Me.txtdescripcioncliente.Name = "txtdescripcioncliente"
        Me.txtdescripcioncliente.Size = New System.Drawing.Size(360, 21)
        Me.txtdescripcioncliente.TabIndex = 114
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(21, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Codigo Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(314, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Estado"
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Checked = True
        Me.chk_estado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_estado.ForeColor = System.Drawing.Color.Navy
        Me.chk_estado.Location = New System.Drawing.Point(358, 221)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(105, 17)
        Me.chk_estado.TabIndex = 9
        Me.chk_estado.Text = "Activo / Inactivo"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(23, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Descripcion para Reporte"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(122, 217)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(188, 20)
        Me.dtpFechaIngreso.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(25, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Fecha de Ingreso"
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(80, 31)
        Me.txt_des.MaxLength = 250
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(374, 20)
        Me.txt_des.TabIndex = 1
        Me.txt_des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(80, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripcion "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(24, 31)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.ReadOnly = True
        Me.txt_cod.Size = New System.Drawing.Size(54, 20)
        Me.txt_cod.TabIndex = 0
        '
        'txt_ruc
        '
        Me.txt_ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc.Location = New System.Drawing.Point(182, 110)
        Me.txt_ruc.MaxLength = 11
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Size = New System.Drawing.Size(275, 20)
        Me.txt_ruc.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(180, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ruc"
        '
        'txt_correo
        '
        Me.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_correo.Location = New System.Drawing.Point(24, 149)
        Me.txt_correo.MaxLength = 50
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(433, 20)
        Me.txt_correo.TabIndex = 5
        '
        'txt_dir
        '
        Me.txt_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dir.Location = New System.Drawing.Point(24, 71)
        Me.txt_dir.MaxLength = 200
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(433, 20)
        Me.txt_dir.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(20, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(20, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telefono / Celular"
        '
        'txt_telf
        '
        Me.txt_telf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telf.Location = New System.Drawing.Point(24, 110)
        Me.txt_telf.MaxLength = 50
        Me.txt_telf.Name = "txt_telf"
        Me.txt_telf.Size = New System.Drawing.Size(154, 20)
        Me.txt_telf.TabIndex = 3
        '
        'txtcodigoCliente
        '
        Me.txtcodigoCliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtcodigoCliente.Location = New System.Drawing.Point(21, 187)
        Me.txtcodigoCliente.Name = "txtcodigoCliente"
        Me.txtcodigoCliente.ReadOnly = True
        Me.txtcodigoCliente.Size = New System.Drawing.Size(74, 21)
        Me.txtcodigoCliente.TabIndex = 12
        '
        'txtDescripcionUbigeo
        '
        Me.txtDescripcionUbigeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionUbigeo.Location = New System.Drawing.Point(102, 28)
        Me.txtDescripcionUbigeo.Name = "txtDescripcionUbigeo"
        Me.txtDescripcionUbigeo.ReadOnly = True
        Me.txtDescripcionUbigeo.Size = New System.Drawing.Size(356, 20)
        Me.txtDescripcionUbigeo.TabIndex = 8
        Me.txtDescripcionUbigeo.Visible = False
        '
        'txtcodigoUbigeo
        '
        Me.txtcodigoUbigeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoUbigeo.Location = New System.Drawing.Point(47, 28)
        Me.txtcodigoUbigeo.Name = "txtcodigoUbigeo"
        Me.txtcodigoUbigeo.ReadOnly = True
        Me.txtcodigoUbigeo.Size = New System.Drawing.Size(54, 20)
        Me.txtcodigoUbigeo.TabIndex = 6
        Me.txtcodigoUbigeo.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(44, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Departamento"
        Me.Label7.Visible = False
        '
        'pnlreporte
        '
        Me.pnlreporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlreporte.Controls.Add(Me.TextBox3)
        Me.pnlreporte.Controls.Add(Me.GroupBox7)
        Me.pnlreporte.Controls.Add(Me.btn_exit)
        Me.pnlreporte.Controls.Add(Me.btn_Aceptar)
        Me.pnlreporte.Location = New System.Drawing.Point(133, 89)
        Me.pnlreporte.Name = "pnlreporte"
        Me.pnlreporte.Size = New System.Drawing.Size(343, 122)
        Me.pnlreporte.TabIndex = 169
        Me.pnlreporte.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Navy
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox3.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(0, 0)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(343, 20)
        Me.TextBox3.TabIndex = 168
        Me.TextBox3.Text = "REPORTE DE VENDEDORES"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rb_ambos)
        Me.GroupBox7.Controls.Add(Me.rb_inactivo)
        Me.GroupBox7.Controls.Add(Me.rb_activo)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 25)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(321, 49)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'rb_ambos
        '
        Me.rb_ambos.AutoSize = True
        Me.rb_ambos.ForeColor = System.Drawing.Color.Navy
        Me.rb_ambos.Location = New System.Drawing.Point(141, 19)
        Me.rb_ambos.Name = "rb_ambos"
        Me.rb_ambos.Size = New System.Drawing.Size(165, 17)
        Me.rb_ambos.TabIndex = 125
        Me.rb_ambos.TabStop = True
        Me.rb_ambos.Text = "Ambos ( activos  / inactivos  )"
        Me.rb_ambos.UseVisualStyleBackColor = True
        '
        'rb_inactivo
        '
        Me.rb_inactivo.AutoSize = True
        Me.rb_inactivo.ForeColor = System.Drawing.Color.Navy
        Me.rb_inactivo.Location = New System.Drawing.Point(70, 19)
        Me.rb_inactivo.Name = "rb_inactivo"
        Me.rb_inactivo.Size = New System.Drawing.Size(63, 17)
        Me.rb_inactivo.TabIndex = 124
        Me.rb_inactivo.TabStop = True
        Me.rb_inactivo.Text = "Inactivo"
        Me.rb_inactivo.UseVisualStyleBackColor = True
        '
        'rb_activo
        '
        Me.rb_activo.AutoSize = True
        Me.rb_activo.ForeColor = System.Drawing.Color.Navy
        Me.rb_activo.Location = New System.Drawing.Point(7, 19)
        Me.rb_activo.Name = "rb_activo"
        Me.rb_activo.Size = New System.Drawing.Size(55, 17)
        Me.rb_activo.TabIndex = 123
        Me.rb_activo.TabStop = True
        Me.rb_activo.Text = "Activo"
        Me.rb_activo.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.ForeColor = System.Drawing.Color.Navy
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_exit.Location = New System.Drawing.Point(172, 78)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(61, 37)
        Me.btn_exit.TabIndex = 121
        Me.btn_exit.Text = "Cancelar"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Navy
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Aceptar.Location = New System.Drawing.Point(107, 78)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(61, 37)
        Me.btn_Aceptar.TabIndex = 122
        Me.btn_Aceptar.Text = "Confirmar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_eliminar, Me.btn_grabar, Me.btn_cancelar, Me.btnImprimir, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(572, 25)
        Me.ToolStrip1.TabIndex = 170
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nuevo.Text = "&Nuevo"
        '
        'btn_Editar
        '
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(139, 22)
        Me.btn_Editar.Text = "Consultar/&Modificar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(77, 22)
        Me.btnImprimir.Text = "&Imprimir"
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'frm_CX_MA_Vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 381)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlreporte)
        Me.Controls.Add(Me.tc_tipos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CX_MA_Vendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedores"
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        Me.gbdatosvendedor.ResumeLayout(False)
        Me.gbdatosvendedor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlreporte.ResumeLayout(False)
        Me.pnlreporte.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_lista As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_telf As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtcodigoUbigeo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionUbigeo As System.Windows.Forms.TextBox
    Friend WithEvents gbdatosvendedor As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chk_estado As System.Windows.Forms.CheckBox
    Friend WithEvents pnlreporte As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents rb_ambos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_inactivo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_activo As System.Windows.Forms.RadioButton
    Friend WithEvents txtcodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcioncliente As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
