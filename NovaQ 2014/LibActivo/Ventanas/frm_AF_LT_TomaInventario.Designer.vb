<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_LT_TomaInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_LT_TomaInventario))
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.col_idactivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_desactivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_si = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_no = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_ubi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_asig = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_comen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_respo_activo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_fec_fin = New System.Windows.Forms.DateTimePicker()
        Me.chk_cerrar = New System.Windows.Forms.CheckBox()
        Me.btn_cargar_inv = New System.Windows.Forms.Button()
        Me.txt_num_inv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tc_detalle = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_no = New System.Windows.Forms.RadioButton()
        Me.rb_si = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_des_activo = New System.Windows.Forms.TextBox()
        Me.txt_idactivo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.pb_img = New System.Windows.Forms.PictureBox()
        Me.cmb_responsable = New System.Windows.Forms.ComboBox()
        Me.cmb_est_fis = New System.Windows.Forms.ComboBox()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.cmb_ubicacion = New System.Windows.Forms.ComboBox()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.tc_detalle.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AllowUserToDeleteRows = False
        Me.dgv_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idactivo, Me.col_desactivo, Me.col_si, Me.col_no, Me.col_ubi, Me.col_area, Me.col_asig, Me.col_estado, Me.col_comen, Me.col_img})
        Me.dgv_detalle.Location = New System.Drawing.Point(3, 3)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.Size = New System.Drawing.Size(675, 275)
        Me.dgv_detalle.TabIndex = 0
        '
        'col_idactivo
        '
        Me.col_idactivo.HeaderText = "Cod. Activo"
        Me.col_idactivo.Name = "col_idactivo"
        Me.col_idactivo.ReadOnly = True
        '
        'col_desactivo
        '
        Me.col_desactivo.HeaderText = "Activo Fijo"
        Me.col_desactivo.Name = "col_desactivo"
        Me.col_desactivo.ReadOnly = True
        Me.col_desactivo.Width = 300
        '
        'col_si
        '
        Me.col_si.HeaderText = "Si"
        Me.col_si.Name = "col_si"
        Me.col_si.ReadOnly = True
        '
        'col_no
        '
        Me.col_no.HeaderText = "No"
        Me.col_no.Name = "col_no"
        Me.col_no.ReadOnly = True
        '
        'col_ubi
        '
        Me.col_ubi.HeaderText = "ubicacion"
        Me.col_ubi.Name = "col_ubi"
        Me.col_ubi.ReadOnly = True
        '
        'col_area
        '
        Me.col_area.HeaderText = "area"
        Me.col_area.Name = "col_area"
        Me.col_area.ReadOnly = True
        '
        'col_asig
        '
        Me.col_asig.HeaderText = "asignacion"
        Me.col_asig.Name = "col_asig"
        Me.col_asig.ReadOnly = True
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "Estado Fis."
        Me.col_estado.Name = "col_estado"
        Me.col_estado.ReadOnly = True
        '
        'col_comen
        '
        Me.col_comen.HeaderText = "Comentarios"
        Me.col_comen.Name = "col_comen"
        Me.col_comen.ReadOnly = True
        '
        'col_img
        '
        Me.col_img.HeaderText = "Foto"
        Me.col_img.Name = "col_img"
        Me.col_img.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_respo_activo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtp_fec_fin)
        Me.GroupBox1.Controls.Add(Me.chk_cerrar)
        Me.GroupBox1.Controls.Add(Me.btn_cargar_inv)
        Me.GroupBox1.Controls.Add(Me.txt_num_inv)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_grabar)
        Me.GroupBox1.Controls.Add(Me.cmb_estado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_obs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmb_respo_activo
        '
        Me.cmb_respo_activo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_respo_activo.FormattingEnabled = True
        Me.cmb_respo_activo.Location = New System.Drawing.Point(90, 44)
        Me.cmb_respo_activo.Name = "cmb_respo_activo"
        Me.cmb_respo_activo.Size = New System.Drawing.Size(391, 21)
        Me.cmb_respo_activo.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(15, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Responsable"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(428, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fecha Fin"
        '
        'dtp_fec_fin
        '
        Me.dtp_fec_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_fin.Location = New System.Drawing.Point(491, 17)
        Me.dtp_fec_fin.Name = "dtp_fec_fin"
        Me.dtp_fec_fin.Size = New System.Drawing.Size(112, 20)
        Me.dtp_fec_fin.TabIndex = 12
        '
        'chk_cerrar
        '
        Me.chk_cerrar.AutoSize = True
        Me.chk_cerrar.Location = New System.Drawing.Point(579, 79)
        Me.chk_cerrar.Name = "chk_cerrar"
        Me.chk_cerrar.Size = New System.Drawing.Size(54, 17)
        Me.chk_cerrar.TabIndex = 11
        Me.chk_cerrar.Text = "Cerrar"
        Me.chk_cerrar.UseVisualStyleBackColor = True
        '
        'btn_cargar_inv
        '
        Me.btn_cargar_inv.Location = New System.Drawing.Point(172, 16)
        Me.btn_cargar_inv.Name = "btn_cargar_inv"
        Me.btn_cargar_inv.Size = New System.Drawing.Size(27, 23)
        Me.btn_cargar_inv.TabIndex = 10
        Me.btn_cargar_inv.Text = "..."
        Me.btn_cargar_inv.UseVisualStyleBackColor = True
        '
        'txt_num_inv
        '
        Me.txt_num_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_inv.Location = New System.Drawing.Point(90, 16)
        Me.txt_num_inv.Name = "txt_num_inv"
        Me.txt_num_inv.Size = New System.Drawing.Size(76, 21)
        Me.txt_num_inv.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Numero Inv."
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(498, 72)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(75, 27)
        Me.btn_grabar.TabIndex = 6
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'cmb_estado
        '
        Me.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado.Enabled = False
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(535, 44)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(143, 21)
        Me.cmb_estado.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(489, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Estado"
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(90, 78)
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(391, 20)
        Me.txt_obs.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Observaciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Inicio"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(297, 17)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(112, 20)
        Me.dtp_fecha.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_salir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(713, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
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
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.LibActivo.My.Resources.Resources._16__Exit_
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tc_detalle
        '
        Me.tc_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_detalle.Controls.Add(Me.TabPage1)
        Me.tc_detalle.Controls.Add(Me.TabPage2)
        Me.tc_detalle.Location = New System.Drawing.Point(12, 146)
        Me.tc_detalle.Name = "tc_detalle"
        Me.tc_detalle.SelectedIndex = 0
        Me.tc_detalle.Size = New System.Drawing.Size(689, 307)
        Me.tc_detalle.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_detalle)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(681, 281)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Activos en Inventario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(681, 281)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_no)
        Me.GroupBox2.Controls.Add(Me.rb_si)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_des_activo)
        Me.GroupBox2.Controls.Add(Me.txt_idactivo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.btn_aceptar)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.btn_quitar)
        Me.GroupBox2.Controls.Add(Me.btn_agregar)
        Me.GroupBox2.Controls.Add(Me.pb_img)
        Me.GroupBox2.Controls.Add(Me.cmb_responsable)
        Me.GroupBox2.Controls.Add(Me.cmb_est_fis)
        Me.GroupBox2.Controls.Add(Me.cmb_area)
        Me.GroupBox2.Controls.Add(Me.cmb_ubicacion)
        Me.GroupBox2.Controls.Add(Me.txt_comentario)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(667, 269)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'rb_no
        '
        Me.rb_no.AutoSize = True
        Me.rb_no.Location = New System.Drawing.Point(151, 191)
        Me.rb_no.Name = "rb_no"
        Me.rb_no.Size = New System.Drawing.Size(39, 17)
        Me.rb_no.TabIndex = 58
        Me.rb_no.TabStop = True
        Me.rb_no.Text = "No"
        Me.rb_no.UseVisualStyleBackColor = True
        '
        'rb_si
        '
        Me.rb_si.AutoSize = True
        Me.rb_si.Checked = True
        Me.rb_si.Location = New System.Drawing.Point(111, 191)
        Me.rb_si.Name = "rb_si"
        Me.rb_si.Size = New System.Drawing.Size(34, 17)
        Me.rb_si.TabIndex = 57
        Me.rb_si.TabStop = True
        Me.rb_si.Text = "Si"
        Me.rb_si.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(52, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Existe"
        '
        'txt_des_activo
        '
        Me.txt_des_activo.Location = New System.Drawing.Point(168, 11)
        Me.txt_des_activo.Name = "txt_des_activo"
        Me.txt_des_activo.ReadOnly = True
        Me.txt_des_activo.Size = New System.Drawing.Size(201, 20)
        Me.txt_des_activo.TabIndex = 55
        '
        'txt_idactivo
        '
        Me.txt_idactivo.Location = New System.Drawing.Point(94, 11)
        Me.txt_idactivo.Name = "txt_idactivo"
        Me.txt_idactivo.ReadOnly = True
        Me.txt_idactivo.Size = New System.Drawing.Size(73, 20)
        Me.txt_idactivo.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(50, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Activo"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(146, 225)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 28)
        Me.btn_cancelar.TabIndex = 52
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(225, 225)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.btn_aceptar.TabIndex = 51
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(484, 22)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(85, 13)
        Me.Label48.TabIndex = 50
        Me.Label48.Text = "Mini Vista Previa"
        '
        'btn_quitar
        '
        Me.btn_quitar.Location = New System.Drawing.Point(535, 187)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(33, 30)
        Me.btn_quitar.TabIndex = 49
        Me.btn_quitar.Text = "-"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(500, 187)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(33, 30)
        Me.btn_agregar.TabIndex = 48
        Me.btn_agregar.Text = "+"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'pb_img
        '
        Me.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_img.Location = New System.Drawing.Point(447, 38)
        Me.pb_img.Name = "pb_img"
        Me.pb_img.Size = New System.Drawing.Size(173, 143)
        Me.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_img.TabIndex = 47
        Me.pb_img.TabStop = False
        '
        'cmb_responsable
        '
        Me.cmb_responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_responsable.FormattingEnabled = True
        Me.cmb_responsable.Location = New System.Drawing.Point(95, 118)
        Me.cmb_responsable.Name = "cmb_responsable"
        Me.cmb_responsable.Size = New System.Drawing.Size(274, 21)
        Me.cmb_responsable.TabIndex = 46
        '
        'cmb_est_fis
        '
        Me.cmb_est_fis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_est_fis.FormattingEnabled = True
        Me.cmb_est_fis.Location = New System.Drawing.Point(95, 91)
        Me.cmb_est_fis.Name = "cmb_est_fis"
        Me.cmb_est_fis.Size = New System.Drawing.Size(274, 21)
        Me.cmb_est_fis.TabIndex = 30
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(95, 64)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(274, 21)
        Me.cmb_area.TabIndex = 26
        '
        'cmb_ubicacion
        '
        Me.cmb_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ubicacion.FormattingEnabled = True
        Me.cmb_ubicacion.Location = New System.Drawing.Point(95, 37)
        Me.cmb_ubicacion.Name = "cmb_ubicacion"
        Me.cmb_ubicacion.Size = New System.Drawing.Size(274, 21)
        Me.cmb_ubicacion.TabIndex = 24
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(95, 145)
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(274, 36)
        Me.txt_comentario.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Comentarios"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Area"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Asignacion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(413, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Foto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Estado Fisico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Ubicacion"
        '
        'frm_AF_LT_TomaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(713, 455)
        Me.Controls.Add(Me.tc_detalle)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_LT_TomaInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toma de Inventario"
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tc_detalle.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_cargar_inv As System.Windows.Forms.Button
    Friend WithEvents txt_num_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chk_cerrar As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_fec_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_respo_activo As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tc_detalle As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_comentario As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_ubicacion As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_est_fis As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_responsable As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents pb_img As System.Windows.Forms.PictureBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_des_activo As System.Windows.Forms.TextBox
    Friend WithEvents txt_idactivo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rb_no As System.Windows.Forms.RadioButton
    Friend WithEvents rb_si As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents col_idactivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_desactivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_si As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents col_no As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents col_ubi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_asig As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_comen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_img As System.Windows.Forms.DataGridViewImageColumn
End Class
