<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearUsuario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbListaUsuario = New System.Windows.Forms.GroupBox()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.chkRangoValidez = New System.Windows.Forms.CheckBox()
        Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFecFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecInicio = New System.Windows.Forms.DateTimePicker()
        Me.gbUsuarios = New System.Windows.Forms.GroupBox()
        Me.chk_hab_pe = New System.Windows.Forms.CheckBox()
        Me.chk_numeracion_fact = New System.Windows.Forms.CheckBox()
        Me.chk_manejo_cartera = New System.Windows.Forms.CheckBox()
        Me.chk_valida_stock = New System.Windows.Forms.CheckBox()
        Me.txt_cod_serie_doc = New System.Windows.Forms.TextBox()
        Me.txt_des_tipo_doc = New System.Windows.Forms.TextBox()
        Me.txt_cod_tipo_doc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkpassword = New System.Windows.Forms.CheckBox()
        Me.cboPerfil = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtConfirmaPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboNivel = New System.Windows.Forms.ComboBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtCodUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkAlmacen = New System.Windows.Forms.CheckBox()
        Me.chklstAlmacenes = New System.Windows.Forms.CheckedListBox()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcion_area = New System.Windows.Forms.TextBox()
        Me.txtdescripcion_solicitante = New System.Windows.Forms.TextBox()
        Me.txtsolicitante = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gb_vendedores = New System.Windows.Forms.GroupBox()
        Me.checkVendedores = New System.Windows.Forms.CheckBox()
        Me.chklstVendedores = New System.Windows.Forms.CheckedListBox()
        Me.ToolOpc.SuspendLayout()
        Me.gbListaUsuario.SuspendLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRangoFechas.SuspendLayout()
        Me.gbUsuarios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        Me.GbCabecera.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_vendedores.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolOpc
        '
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolEditar, Me.ToolGrabar, Me.btn_eliminar, Me.ToolCancelar, Me.ToolSalir})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(699, 25)
        Me.ToolOpc.TabIndex = 16
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'ToolNuevo
        '
        Me.ToolNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolNuevo.Image = CType(resources.GetObject("ToolNuevo.Image"), System.Drawing.Image)
        Me.ToolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolNuevo.Name = "ToolNuevo"
        Me.ToolNuevo.Size = New System.Drawing.Size(62, 22)
        Me.ToolNuevo.Text = "&Nuevo"
        Me.ToolNuevo.ToolTipText = "Nuevo usuario"
        '
        'ToolEditar
        '
        Me.ToolEditar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolEditar.Image = CType(resources.GetObject("ToolEditar.Image"), System.Drawing.Image)
        Me.ToolEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolEditar.Name = "ToolEditar"
        Me.ToolEditar.Size = New System.Drawing.Size(120, 22)
        Me.ToolEditar.Text = "&Consultar/Editar"
        Me.ToolEditar.ToolTipText = "Editar usuario"
        '
        'ToolGrabar
        '
        Me.ToolGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolGrabar.Image = CType(resources.GetObject("ToolGrabar.Image"), System.Drawing.Image)
        Me.ToolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGrabar.Name = "ToolGrabar"
        Me.ToolGrabar.Size = New System.Drawing.Size(73, 22)
        Me.ToolGrabar.Text = "&Guardar"
        Me.ToolGrabar.ToolTipText = "Guardar usuario"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.ToolTipText = "Salir"
        '
        'ToolCancelar
        '
        Me.ToolCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolCancelar.Image = CType(resources.GetObject("ToolCancelar.Image"), System.Drawing.Image)
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(76, 22)
        Me.ToolCancelar.Text = "C&ancelar"
        Me.ToolCancelar.ToolTipText = "Cancelar"
        '
        'ToolSalir
        '
        Me.ToolSalir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolSalir.Image = CType(resources.GetObject("ToolSalir.Image"), System.Drawing.Image)
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(52, 22)
        Me.ToolSalir.Text = "&Salir"
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(6, 563)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Doble clic para editar"
        Me.Label8.Visible = False
        '
        'gbListaUsuario
        '
        Me.gbListaUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbListaUsuario.Controls.Add(Me.Label8)
        Me.gbListaUsuario.Controls.Add(Me.dgUsuarios)
        Me.gbListaUsuario.ForeColor = System.Drawing.Color.Navy
        Me.gbListaUsuario.Location = New System.Drawing.Point(18, 8)
        Me.gbListaUsuario.Name = "gbListaUsuario"
        Me.gbListaUsuario.Size = New System.Drawing.Size(635, 553)
        Me.gbListaUsuario.TabIndex = 27
        Me.gbListaUsuario.TabStop = False
        Me.gbListaUsuario.Text = "Listado de los Usuarios"
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgUsuarios.Location = New System.Drawing.Point(9, 17)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUsuarios.Size = New System.Drawing.Size(616, 524)
        Me.dgUsuarios.TabIndex = 19
        '
        'chkRangoValidez
        '
        Me.chkRangoValidez.AutoSize = True
        Me.chkRangoValidez.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkRangoValidez.ForeColor = System.Drawing.Color.Navy
        Me.chkRangoValidez.Location = New System.Drawing.Point(6, 0)
        Me.chkRangoValidez.Name = "chkRangoValidez"
        Me.chkRangoValidez.Size = New System.Drawing.Size(191, 17)
        Me.chkRangoValidez.TabIndex = 25
        Me.chkRangoValidez.Text = "Validar usuario con rango de fecha"
        Me.chkRangoValidez.UseVisualStyleBackColor = True
        Me.chkRangoValidez.Visible = False
        '
        'gbRangoFechas
        '
        Me.gbRangoFechas.Controls.Add(Me.Label7)
        Me.gbRangoFechas.Controls.Add(Me.Label6)
        Me.gbRangoFechas.Controls.Add(Me.dtpFecFinal)
        Me.gbRangoFechas.Controls.Add(Me.chkRangoValidez)
        Me.gbRangoFechas.Controls.Add(Me.dtpFecInicio)
        Me.gbRangoFechas.Enabled = False
        Me.gbRangoFechas.ForeColor = System.Drawing.Color.Black
        Me.gbRangoFechas.Location = New System.Drawing.Point(390, 170)
        Me.gbRangoFechas.Name = "gbRangoFechas"
        Me.gbRangoFechas.Size = New System.Drawing.Size(295, 55)
        Me.gbRangoFechas.TabIndex = 26
        Me.gbRangoFechas.TabStop = False
        Me.gbRangoFechas.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(144, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Hasta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(7, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Desde"
        '
        'dtpFecFinal
        '
        Me.dtpFecFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFinal.Location = New System.Drawing.Point(185, 28)
        Me.dtpFecFinal.Name = "dtpFecFinal"
        Me.dtpFecFinal.Size = New System.Drawing.Size(86, 20)
        Me.dtpFecFinal.TabIndex = 8
        '
        'dtpFecInicio
        '
        Me.dtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecInicio.Location = New System.Drawing.Point(53, 28)
        Me.dtpFecInicio.Name = "dtpFecInicio"
        Me.dtpFecInicio.Size = New System.Drawing.Size(86, 20)
        Me.dtpFecInicio.TabIndex = 7
        '
        'gbUsuarios
        '
        Me.gbUsuarios.Controls.Add(Me.chk_hab_pe)
        Me.gbUsuarios.Controls.Add(Me.chk_numeracion_fact)
        Me.gbUsuarios.Controls.Add(Me.chk_manejo_cartera)
        Me.gbUsuarios.Controls.Add(Me.chk_valida_stock)
        Me.gbUsuarios.Controls.Add(Me.txt_cod_serie_doc)
        Me.gbUsuarios.Controls.Add(Me.txt_des_tipo_doc)
        Me.gbUsuarios.Controls.Add(Me.txt_cod_tipo_doc)
        Me.gbUsuarios.Controls.Add(Me.Label12)
        Me.gbUsuarios.Controls.Add(Me.Label10)
        Me.gbUsuarios.Controls.Add(Me.txtcorreo)
        Me.gbUsuarios.Controls.Add(Me.Label11)
        Me.gbUsuarios.Controls.Add(Me.chkpassword)
        Me.gbUsuarios.Controls.Add(Me.cboPerfil)
        Me.gbUsuarios.Controls.Add(Me.gbRangoFechas)
        Me.gbUsuarios.Controls.Add(Me.Label9)
        Me.gbUsuarios.Controls.Add(Me.txtConfirmaPassword)
        Me.gbUsuarios.Controls.Add(Me.Label4)
        Me.gbUsuarios.Controls.Add(Me.cboNivel)
        Me.gbUsuarios.Controls.Add(Me.chkEstado)
        Me.gbUsuarios.Controls.Add(Me.txtPassword)
        Me.gbUsuarios.Controls.Add(Me.txtNombreUsuario)
        Me.gbUsuarios.Controls.Add(Me.txtCodUsuario)
        Me.gbUsuarios.Controls.Add(Me.Label5)
        Me.gbUsuarios.Controls.Add(Me.Label3)
        Me.gbUsuarios.Controls.Add(Me.Label2)
        Me.gbUsuarios.Controls.Add(Me.Label1)
        Me.gbUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbUsuarios.ForeColor = System.Drawing.Color.Navy
        Me.gbUsuarios.Location = New System.Drawing.Point(24, 37)
        Me.gbUsuarios.Name = "gbUsuarios"
        Me.gbUsuarios.Size = New System.Drawing.Size(659, 333)
        Me.gbUsuarios.TabIndex = 24
        Me.gbUsuarios.TabStop = False
        Me.gbUsuarios.Text = "Datos de Usuario"
        '
        'chk_hab_pe
        '
        Me.chk_hab_pe.AutoSize = True
        Me.chk_hab_pe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_hab_pe.ForeColor = System.Drawing.Color.Navy
        Me.chk_hab_pe.Location = New System.Drawing.Point(13, 306)
        Me.chk_hab_pe.Name = "chk_hab_pe"
        Me.chk_hab_pe.Size = New System.Drawing.Size(229, 17)
        Me.chk_hab_pe.TabIndex = 40
        Me.chk_hab_pe.Text = "Habilitado para Actualizar Parte de Entrega"
        Me.chk_hab_pe.UseVisualStyleBackColor = True
        '
        'chk_numeracion_fact
        '
        Me.chk_numeracion_fact.AutoSize = True
        Me.chk_numeracion_fact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_numeracion_fact.ForeColor = System.Drawing.Color.Navy
        Me.chk_numeracion_fact.Location = New System.Drawing.Point(283, 280)
        Me.chk_numeracion_fact.Name = "chk_numeracion_fact"
        Me.chk_numeracion_fact.Size = New System.Drawing.Size(269, 17)
        Me.chk_numeracion_fact.TabIndex = 39
        Me.chk_numeracion_fact.Text = "Habilitado para cambiar numeración de Facturación"
        Me.chk_numeracion_fact.UseVisualStyleBackColor = True
        '
        'chk_manejo_cartera
        '
        Me.chk_manejo_cartera.AutoSize = True
        Me.chk_manejo_cartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_manejo_cartera.ForeColor = System.Drawing.Color.Navy
        Me.chk_manejo_cartera.Location = New System.Drawing.Point(13, 280)
        Me.chk_manejo_cartera.Name = "chk_manejo_cartera"
        Me.chk_manejo_cartera.Size = New System.Drawing.Size(269, 17)
        Me.chk_manejo_cartera.TabIndex = 38
        Me.chk_manejo_cartera.Text = "Habilitado Manejo de Catera (clientes/proveedores)"
        Me.chk_manejo_cartera.UseVisualStyleBackColor = True
        '
        'chk_valida_stock
        '
        Me.chk_valida_stock.AutoSize = True
        Me.chk_valida_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_valida_stock.ForeColor = System.Drawing.Color.Navy
        Me.chk_valida_stock.Location = New System.Drawing.Point(419, 247)
        Me.chk_valida_stock.Name = "chk_valida_stock"
        Me.chk_valida_stock.Size = New System.Drawing.Size(86, 17)
        Me.chk_valida_stock.TabIndex = 37
        Me.chk_valida_stock.Text = "Valida Stock"
        Me.chk_valida_stock.UseVisualStyleBackColor = True
        '
        'txt_cod_serie_doc
        '
        Me.txt_cod_serie_doc.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_serie_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_serie_doc.Location = New System.Drawing.Point(283, 246)
        Me.txt_cod_serie_doc.Name = "txt_cod_serie_doc"
        Me.txt_cod_serie_doc.Size = New System.Drawing.Size(113, 20)
        Me.txt_cod_serie_doc.TabIndex = 36
        '
        'txt_des_tipo_doc
        '
        Me.txt_des_tipo_doc.BackColor = System.Drawing.Color.White
        Me.txt_des_tipo_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_tipo_doc.Enabled = False
        Me.txt_des_tipo_doc.Location = New System.Drawing.Point(72, 246)
        Me.txt_des_tipo_doc.Name = "txt_des_tipo_doc"
        Me.txt_des_tipo_doc.ReadOnly = True
        Me.txt_des_tipo_doc.Size = New System.Drawing.Size(174, 20)
        Me.txt_des_tipo_doc.TabIndex = 35
        '
        'txt_cod_tipo_doc
        '
        Me.txt_cod_tipo_doc.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_tipo_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_tipo_doc.Location = New System.Drawing.Point(13, 246)
        Me.txt_cod_tipo_doc.Name = "txt_cod_tipo_doc"
        Me.txt_cod_tipo_doc.Size = New System.Drawing.Size(55, 20)
        Me.txt_cod_tipo_doc.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(286, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Serie Doc. x defecto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(13, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "T. Doc. x Defecto"
        '
        'txtcorreo
        '
        Me.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcorreo.ForeColor = System.Drawing.Color.Black
        Me.txtcorreo.Location = New System.Drawing.Point(13, 191)
        Me.txtcorreo.MaxLength = 255
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(292, 20)
        Me.txtcorreo.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(13, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Correo"
        '
        'chkpassword
        '
        Me.chkpassword.AutoSize = True
        Me.chkpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkpassword.ForeColor = System.Drawing.Color.Red
        Me.chkpassword.Location = New System.Drawing.Point(390, 191)
        Me.chkpassword.Name = "chkpassword"
        Me.chkpassword.Size = New System.Drawing.Size(134, 17)
        Me.chkpassword.TabIndex = 27
        Me.chkpassword.Text = "Password por Defecto "
        Me.chkpassword.UseVisualStyleBackColor = True
        '
        'cboPerfil
        '
        Me.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPerfil.ForeColor = System.Drawing.Color.Black
        Me.cboPerfil.FormattingEnabled = True
        Me.cboPerfil.Location = New System.Drawing.Point(222, 118)
        Me.cboPerfil.Name = "cboPerfil"
        Me.cboPerfil.Size = New System.Drawing.Size(196, 21)
        Me.cboPerfil.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(225, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Perfil de Acceso"
        '
        'txtConfirmaPassword
        '
        Me.txtConfirmaPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmaPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmaPassword.Location = New System.Drawing.Point(222, 76)
        Me.txtConfirmaPassword.MaxLength = 15
        Me.txtConfirmaPassword.Name = "txtConfirmaPassword"
        Me.txtConfirmaPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmaPassword.Size = New System.Drawing.Size(196, 20)
        Me.txtConfirmaPassword.TabIndex = 4
        Me.txtConfirmaPassword.Text = "1234"
        Me.txtConfirmaPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(225, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Repetir Contraseña"
        '
        'cboNivel
        '
        Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivel.ForeColor = System.Drawing.Color.Black
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Location = New System.Drawing.Point(10, 118)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(196, 21)
        Me.cboNivel.TabIndex = 6
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkEstado.ForeColor = System.Drawing.Color.Navy
        Me.chkEstado.Location = New System.Drawing.Point(13, 147)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(73, 17)
        Me.chkEstado.TabIndex = 5
        Me.chkEstado.Text = "Habilitado"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(10, 76)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(196, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "1234"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtNombreUsuario.Location = New System.Drawing.Point(165, 35)
        Me.txtNombreUsuario.MaxLength = 50
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(357, 20)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtCodUsuario
        '
        Me.txtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtCodUsuario.Location = New System.Drawing.Point(10, 35)
        Me.txtCodUsuario.MaxLength = 20
        Me.txtCodUsuario.Name = "txtCodUsuario"
        Me.txtCodUsuario.Size = New System.Drawing.Size(143, 20)
        Me.txtCodUsuario.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(13, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Nivel acceso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(13, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(170, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Descripción Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Usuario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.checkAlmacen)
        Me.GroupBox1.Controls.Add(Me.chklstAlmacenes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(24, 454)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 149)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acceso de los Almacenes"
        '
        'checkAlmacen
        '
        Me.checkAlmacen.AutoSize = True
        Me.checkAlmacen.ForeColor = System.Drawing.Color.Navy
        Me.checkAlmacen.Location = New System.Drawing.Point(18, 17)
        Me.checkAlmacen.Name = "checkAlmacen"
        Me.checkAlmacen.Size = New System.Drawing.Size(92, 17)
        Me.checkAlmacen.TabIndex = 7
        Me.checkAlmacen.Text = "Activar Todos"
        Me.checkAlmacen.UseVisualStyleBackColor = True
        '
        'chklstAlmacenes
        '
        Me.chklstAlmacenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chklstAlmacenes.CheckOnClick = True
        Me.chklstAlmacenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstAlmacenes.FormattingEnabled = True
        Me.chklstAlmacenes.Location = New System.Drawing.Point(16, 37)
        Me.chklstAlmacenes.Name = "chklstAlmacenes"
        Me.chklstAlmacenes.Size = New System.Drawing.Size(290, 79)
        Me.chklstAlmacenes.TabIndex = 6
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.Controls.Add(Me.gbListaUsuario)
        Me.pnlPrincipal.Location = New System.Drawing.Point(15, 37)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(670, 571)
        Me.pnlPrincipal.TabIndex = 29
        '
        'GbCabecera
        '
        Me.GbCabecera.BackColor = System.Drawing.Color.White
        Me.GbCabecera.Controls.Add(Me.PictureBox2)
        Me.GbCabecera.Controls.Add(Me.txtarea)
        Me.GbCabecera.Controls.Add(Me.Label13)
        Me.GbCabecera.Controls.Add(Me.PictureBox1)
        Me.GbCabecera.Controls.Add(Me.txtdescripcion_area)
        Me.GbCabecera.Controls.Add(Me.txtdescripcion_solicitante)
        Me.GbCabecera.Controls.Add(Me.txtsolicitante)
        Me.GbCabecera.Controls.Add(Me.Label14)
        Me.GbCabecera.Location = New System.Drawing.Point(24, 376)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(659, 60)
        Me.GbCabecera.TabIndex = 190
        Me.GbCabecera.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(119, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 206
        Me.PictureBox2.TabStop = False
        '
        'txtarea
        '
        Me.txtarea.BackColor = System.Drawing.Color.Aquamarine
        Me.txtarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtarea.Location = New System.Drawing.Point(63, 12)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(55, 20)
        Me.txtarea.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(16, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 205
        Me.Label13.Text = "Area "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(119, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 112
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcion_area
        '
        Me.txtdescripcion_area.BackColor = System.Drawing.Color.White
        Me.txtdescripcion_area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion_area.Enabled = False
        Me.txtdescripcion_area.Location = New System.Drawing.Point(139, 12)
        Me.txtdescripcion_area.Name = "txtdescripcion_area"
        Me.txtdescripcion_area.ReadOnly = True
        Me.txtdescripcion_area.Size = New System.Drawing.Size(384, 20)
        Me.txtdescripcion_area.TabIndex = 1
        '
        'txtdescripcion_solicitante
        '
        Me.txtdescripcion_solicitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion_solicitante.Enabled = False
        Me.txtdescripcion_solicitante.Location = New System.Drawing.Point(139, 35)
        Me.txtdescripcion_solicitante.Name = "txtdescripcion_solicitante"
        Me.txtdescripcion_solicitante.Size = New System.Drawing.Size(384, 20)
        Me.txtdescripcion_solicitante.TabIndex = 3
        '
        'txtsolicitante
        '
        Me.txtsolicitante.BackColor = System.Drawing.Color.Aquamarine
        Me.txtsolicitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsolicitante.Location = New System.Drawing.Point(62, 35)
        Me.txtsolicitante.Name = "txtsolicitante"
        Me.txtsolicitante.Size = New System.Drawing.Size(55, 20)
        Me.txtsolicitante.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(7, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "Personal "
        '
        'gb_vendedores
        '
        Me.gb_vendedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_vendedores.Controls.Add(Me.checkVendedores)
        Me.gb_vendedores.Controls.Add(Me.chklstVendedores)
        Me.gb_vendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gb_vendedores.ForeColor = System.Drawing.Color.Navy
        Me.gb_vendedores.Location = New System.Drawing.Point(360, 454)
        Me.gb_vendedores.Name = "gb_vendedores"
        Me.gb_vendedores.Size = New System.Drawing.Size(323, 149)
        Me.gb_vendedores.TabIndex = 191
        Me.gb_vendedores.TabStop = False
        Me.gb_vendedores.Text = "Lista de Vendedores"
        '
        'checkVendedores
        '
        Me.checkVendedores.AutoSize = True
        Me.checkVendedores.ForeColor = System.Drawing.Color.Navy
        Me.checkVendedores.Location = New System.Drawing.Point(18, 17)
        Me.checkVendedores.Name = "checkVendedores"
        Me.checkVendedores.Size = New System.Drawing.Size(92, 17)
        Me.checkVendedores.TabIndex = 7
        Me.checkVendedores.Text = "Activar Todos"
        Me.checkVendedores.UseVisualStyleBackColor = True
        '
        'chklstVendedores
        '
        Me.chklstVendedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chklstVendedores.CheckOnClick = True
        Me.chklstVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstVendedores.FormattingEnabled = True
        Me.chklstVendedores.Location = New System.Drawing.Point(16, 37)
        Me.chklstVendedores.Name = "chklstVendedores"
        Me.chklstVendedores.Size = New System.Drawing.Size(290, 79)
        Me.chklstVendedores.TabIndex = 6
        '
        'frmCrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(699, 620)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.gb_vendedores)
        Me.Controls.Add(Me.ToolOpc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbCabecera)
        Me.Controls.Add(Me.gbUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrearUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creación de usuarios"
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        Me.gbListaUsuario.ResumeLayout(False)
        Me.gbListaUsuario.PerformLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRangoFechas.ResumeLayout(False)
        Me.gbRangoFechas.PerformLayout()
        Me.gbUsuarios.ResumeLayout(False)
        Me.gbUsuarios.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_vendedores.ResumeLayout(False)
        Me.gb_vendedores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbListaUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents chkRangoValidez As System.Windows.Forms.CheckBox
    Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFecFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmaPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCodUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkAlmacen As System.Windows.Forms.CheckBox
    Friend WithEvents chklstAlmacenes As System.Windows.Forms.CheckedListBox
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents chkpassword As System.Windows.Forms.CheckBox
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcion_area As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion_solicitante As System.Windows.Forms.TextBox
    Friend WithEvents txtsolicitante As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_serie_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_tipo_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_tipo_doc As System.Windows.Forms.TextBox
    Friend WithEvents chk_valida_stock As System.Windows.Forms.CheckBox
    Friend WithEvents chk_manejo_cartera As System.Windows.Forms.CheckBox
    Friend WithEvents chk_numeracion_fact As System.Windows.Forms.CheckBox
    Friend WithEvents gb_vendedores As System.Windows.Forms.GroupBox
    Friend WithEvents checkVendedores As System.Windows.Forms.CheckBox
    Friend WithEvents chklstVendedores As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_hab_pe As System.Windows.Forms.CheckBox
End Class
