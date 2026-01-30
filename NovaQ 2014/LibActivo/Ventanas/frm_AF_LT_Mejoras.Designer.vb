<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_LT_Mejoras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_LT_Mejoras))
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
        Me.tc_mejoras = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chk_comienza = New System.Windows.Forms.CheckBox()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_Lista_Mejoras = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFERENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.mtb_tasa = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_sec = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_ref = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cod_alt = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtb_idoc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_tc = New System.Windows.Forms.TextBox()
        Me.mtb_fdoc = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_tip_pago = New System.Windows.Forms.ComboBox()
        Me.cmb_prove = New System.Windows.Forms.ComboBox()
        Me.cmb_tdoc = New System.Windows.Forms.ComboBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_ndoc = New System.Windows.Forms.TextBox()
        Me.txt_sdoc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.tc_mejoras.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_Lista_Mejoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.toolStripSeparator5, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator7})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(838, 25)
        Me.ToolS_Mantenimiento.TabIndex = 15
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
        Me.Tool_Grabar.Image = Global.LibActivo.My.Resources.Resources._003
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
        Me.Tool_Editar.Image = Global.LibActivo.My.Resources.Resources._16__Card_edit_
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
        'tc_mejoras
        '
        Me.tc_mejoras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_mejoras.Controls.Add(Me.TabPage1)
        Me.tc_mejoras.Controls.Add(Me.TabPage2)
        Me.tc_mejoras.Location = New System.Drawing.Point(12, 38)
        Me.tc_mejoras.Name = "tc_mejoras"
        Me.tc_mejoras.SelectedIndex = 0
        Me.tc_mejoras.Size = New System.Drawing.Size(814, 394)
        Me.tc_mejoras.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chk_comienza)
        Me.TabPage1.Controls.Add(Me.txt_filtro)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dgv_Lista_Mejoras)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(806, 368)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Mejoras"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chk_comienza
        '
        Me.chk_comienza.AutoSize = True
        Me.chk_comienza.Checked = True
        Me.chk_comienza.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_comienza.Location = New System.Drawing.Point(710, 16)
        Me.chk_comienza.Name = "chk_comienza"
        Me.chk_comienza.Size = New System.Drawing.Size(90, 17)
        Me.chk_comienza.TabIndex = 5
        Me.chk_comienza.Text = "Comienza por"
        Me.chk_comienza.UseVisualStyleBackColor = True
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(110, 11)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(577, 20)
        Me.txt_filtro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar Activo Fijo :"
        '
        'dgv_Lista_Mejoras
        '
        Me.dgv_Lista_Mejoras.AllowUserToAddRows = False
        Me.dgv_Lista_Mejoras.AllowUserToDeleteRows = False
        Me.dgv_Lista_Mejoras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Lista_Mejoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lista_Mejoras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.ACTIVO, Me.SEC, Me.REFERENCIA, Me.FECHA, Me.OBS})
        Me.dgv_Lista_Mejoras.Location = New System.Drawing.Point(6, 39)
        Me.dgv_Lista_Mejoras.Name = "dgv_Lista_Mejoras"
        Me.dgv_Lista_Mejoras.ReadOnly = True
        Me.dgv_Lista_Mejoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lista_Mejoras.Size = New System.Drawing.Size(794, 323)
        Me.dgv_Lista_Mejoras.TabIndex = 0
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "CODIGO"
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.Width = 70
        '
        'ACTIVO
        '
        Me.ACTIVO.DataPropertyName = "ACTIVO"
        Me.ACTIVO.HeaderText = "ACTIVO"
        Me.ACTIVO.Name = "ACTIVO"
        Me.ACTIVO.ReadOnly = True
        Me.ACTIVO.Width = 200
        '
        'SEC
        '
        Me.SEC.DataPropertyName = "SEC"
        Me.SEC.HeaderText = "SEC"
        Me.SEC.Name = "SEC"
        Me.SEC.ReadOnly = True
        Me.SEC.Width = 40
        '
        'REFERENCIA
        '
        Me.REFERENCIA.DataPropertyName = "REFERENCIA"
        Me.REFERENCIA.HeaderText = "REFERENCIA"
        Me.REFERENCIA.Name = "REFERENCIA"
        Me.REFERENCIA.ReadOnly = True
        Me.REFERENCIA.Width = 200
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Width = 70
        '
        'OBS
        '
        Me.OBS.DataPropertyName = "OBS"
        Me.OBS.HeaderText = "OBS"
        Me.OBS.Name = "OBS"
        Me.OBS.ReadOnly = True
        Me.OBS.Width = 150
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_datos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(806, 368)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.mtb_tasa)
        Me.gb_datos.Controls.Add(Me.Label9)
        Me.gb_datos.Controls.Add(Me.txt_sec)
        Me.gb_datos.Controls.Add(Me.Label8)
        Me.gb_datos.Controls.Add(Me.Label7)
        Me.gb_datos.Controls.Add(Me.txt_obs)
        Me.gb_datos.Controls.Add(Me.Label6)
        Me.gb_datos.Controls.Add(Me.btn_buscar)
        Me.gb_datos.Controls.Add(Me.txt_ref)
        Me.gb_datos.Controls.Add(Me.Label5)
        Me.gb_datos.Controls.Add(Me.txt_cod_alt)
        Me.gb_datos.Controls.Add(Me.txt_descripcion)
        Me.gb_datos.Controls.Add(Me.Label2)
        Me.gb_datos.Controls.Add(Me.Label3)
        Me.gb_datos.Controls.Add(Me.txt_codigo)
        Me.gb_datos.Controls.Add(Me.Label4)
        Me.gb_datos.Controls.Add(Me.mtb_idoc)
        Me.gb_datos.Controls.Add(Me.txt_tc)
        Me.gb_datos.Controls.Add(Me.mtb_fdoc)
        Me.gb_datos.Controls.Add(Me.cmb_tip_pago)
        Me.gb_datos.Controls.Add(Me.cmb_prove)
        Me.gb_datos.Controls.Add(Me.cmb_tdoc)
        Me.gb_datos.Controls.Add(Me.cmb_moneda)
        Me.gb_datos.Controls.Add(Me.Label35)
        Me.gb_datos.Controls.Add(Me.Label20)
        Me.gb_datos.Controls.Add(Me.txt_ndoc)
        Me.gb_datos.Controls.Add(Me.txt_sdoc)
        Me.gb_datos.Controls.Add(Me.Label19)
        Me.gb_datos.Controls.Add(Me.Label15)
        Me.gb_datos.Controls.Add(Me.Label18)
        Me.gb_datos.Controls.Add(Me.Label14)
        Me.gb_datos.Controls.Add(Me.Label17)
        Me.gb_datos.Controls.Add(Me.Label13)
        Me.gb_datos.Location = New System.Drawing.Point(6, 6)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(794, 356)
        Me.gb_datos.TabIndex = 0
        Me.gb_datos.TabStop = False
        '
        'mtb_tasa
        '
        Me.mtb_tasa.Location = New System.Drawing.Point(447, 227)
        Me.mtb_tasa.Name = "mtb_tasa"
        Me.mtb_tasa.Size = New System.Drawing.Size(71, 20)
        Me.mtb_tasa.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(400, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Tasa %"
        '
        'txt_sec
        '
        Me.txt_sec.Location = New System.Drawing.Point(483, 20)
        Me.txt_sec.Name = "txt_sec"
        Me.txt_sec.ReadOnly = True
        Me.txt_sec.Size = New System.Drawing.Size(35, 20)
        Me.txt_sec.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(448, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Sec."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(207, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Numero"
        '
        'txt_obs
        '
        Me.txt_obs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_obs.Location = New System.Drawing.Point(92, 108)
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(426, 20)
        Me.txt_obs.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Observaciones"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(191, 18)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(26, 23)
        Me.btn_buscar.TabIndex = 41
        Me.btn_buscar.Text = "..."
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_ref
        '
        Me.txt_ref.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ref.Location = New System.Drawing.Point(92, 82)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Size = New System.Drawing.Size(426, 20)
        Me.txt_ref.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(19, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Referencia"
        '
        'txt_cod_alt
        '
        Me.txt_cod_alt.Location = New System.Drawing.Point(338, 19)
        Me.txt_cod_alt.Name = "txt_cod_alt"
        Me.txt_cod_alt.ReadOnly = True
        Me.txt_cod_alt.Size = New System.Drawing.Size(97, 20)
        Me.txt_cod_alt.TabIndex = 36
        '
        'txt_descripcion
        '
        Me.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descripcion.Location = New System.Drawing.Point(92, 45)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ReadOnly = True
        Me.txt_descripcion.Size = New System.Drawing.Size(426, 20)
        Me.txt_descripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(272, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cod. Altern."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(25, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Descripcion"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(92, 19)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(97, 20)
        Me.txt_codigo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(48, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Codigo"
        '
        'mtb_idoc
        '
        Me.mtb_idoc.Location = New System.Drawing.Point(240, 227)
        Me.mtb_idoc.Name = "mtb_idoc"
        Me.mtb_idoc.Size = New System.Drawing.Size(126, 20)
        Me.mtb_idoc.TabIndex = 9
        '
        'txt_tc
        '
        Me.txt_tc.Location = New System.Drawing.Point(92, 278)
        Me.txt_tc.Name = "txt_tc"
        Me.txt_tc.Size = New System.Drawing.Size(65, 20)
        Me.txt_tc.TabIndex = 12
        '
        'mtb_fdoc
        '
        Me.mtb_fdoc.Location = New System.Drawing.Point(92, 225)
        Me.mtb_fdoc.Mask = "00/00/0000"
        Me.mtb_fdoc.Name = "mtb_fdoc"
        Me.mtb_fdoc.Size = New System.Drawing.Size(88, 20)
        Me.mtb_fdoc.TabIndex = 7
        Me.mtb_fdoc.ValidatingType = GetType(Date)
        '
        'cmb_tip_pago
        '
        Me.cmb_tip_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tip_pago.FormattingEnabled = True
        Me.cmb_tip_pago.Location = New System.Drawing.Point(92, 304)
        Me.cmb_tip_pago.Name = "cmb_tip_pago"
        Me.cmb_tip_pago.Size = New System.Drawing.Size(274, 21)
        Me.cmb_tip_pago.TabIndex = 13
        '
        'cmb_prove
        '
        Me.cmb_prove.FormattingEnabled = True
        Me.cmb_prove.Location = New System.Drawing.Point(92, 154)
        Me.cmb_prove.Name = "cmb_prove"
        Me.cmb_prove.Size = New System.Drawing.Size(426, 21)
        Me.cmb_prove.TabIndex = 4
        '
        'cmb_tdoc
        '
        Me.cmb_tdoc.FormattingEnabled = True
        Me.cmb_tdoc.Location = New System.Drawing.Point(92, 178)
        Me.cmb_tdoc.Name = "cmb_tdoc"
        Me.cmb_tdoc.Size = New System.Drawing.Size(274, 21)
        Me.cmb_tdoc.TabIndex = 5
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(92, 251)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(177, 21)
        Me.cmb_moneda.TabIndex = 11
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(35, 307)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 13)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "Tip. Pago"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(30, 281)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Tip. Camb."
        '
        'txt_ndoc
        '
        Me.txt_ndoc.Location = New System.Drawing.Point(255, 202)
        Me.txt_ndoc.Name = "txt_ndoc"
        Me.txt_ndoc.Size = New System.Drawing.Size(111, 20)
        Me.txt_ndoc.TabIndex = 8
        '
        'txt_sdoc
        '
        Me.txt_sdoc.Location = New System.Drawing.Point(92, 202)
        Me.txt_sdoc.Name = "txt_sdoc"
        Me.txt_sdoc.Size = New System.Drawing.Size(88, 20)
        Me.txt_sdoc.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(42, 255)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Moneda"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(57, 205)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Serie"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(194, 230)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Importe"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(37, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Tip. Doc."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(34, 228)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Fec. Doc."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(32, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Proveedor"
        '
        'frm_AF_LT_Mejoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(838, 444)
        Me.Controls.Add(Me.tc_mejoras)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_LT_Mejoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Mejoras al Activo Fijo"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.tc_mejoras.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_Lista_Mejoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
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
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tc_mejoras As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_Lista_Mejoras As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents mtb_idoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_tc As System.Windows.Forms.TextBox
    Friend WithEvents mtb_fdoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_tip_pago As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_prove As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tdoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_ndoc As System.Windows.Forms.TextBox
    Friend WithEvents txt_sdoc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_alt As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_sec As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mtb_tasa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFERENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_comienza As System.Windows.Forms.CheckBox
End Class
