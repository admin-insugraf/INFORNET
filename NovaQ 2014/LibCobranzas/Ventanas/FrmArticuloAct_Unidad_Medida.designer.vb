<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArticuloAct_Unidad_Medida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticuloAct_Unidad_Medida))
        Me.gbopciones = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtUMProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.spnFactor = New System.Windows.Forms.NumericUpDown()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.spnMasterPack = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkMainunit = New System.Windows.Forms.CheckBox()
        Me.chkstocketd = New System.Windows.Forms.CheckBox()
        Me.chkFlgNoSale = New System.Windows.Forms.CheckBox()
        Me.spnMOQ = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_codigoBarra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_alias = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtunidaddesc = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_um = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtUnidMedRef = New System.Windows.Forms.TextBox()
        Me.txtunidadrefdesc = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgUnidadesMedida = New System.Windows.Forms.DataGridView()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.tc_articulo = New System.Windows.Forms.TabControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscarArchivos = New System.Windows.Forms.Button()
        Me.btnSubirArchivo = New System.Windows.Forms.Button()
        Me.txtRutaArchivo = New System.Windows.Forms.TextBox()
        Me.btnpdf = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.gbopciones.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        CType(Me.spnFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.spnMasterPack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnMOQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgUnidadesMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_articulo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbopciones
        '
        Me.gbopciones.Controls.Add(Me.Label12)
        Me.gbopciones.Controls.Add(Me.txtDescripcionProducto)
        Me.gbopciones.Controls.Add(Me.txtUMProducto)
        Me.gbopciones.Controls.Add(Me.Label5)
        Me.gbopciones.Controls.Add(Me.txtCodigoProducto)
        Me.gbopciones.Controls.Add(Me.Label33)
        Me.gbopciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbopciones.ForeColor = System.Drawing.Color.Navy
        Me.gbopciones.Location = New System.Drawing.Point(3, 29)
        Me.gbopciones.Name = "gbopciones"
        Me.gbopciones.Size = New System.Drawing.Size(734, 102)
        Me.gbopciones.TabIndex = 23
        Me.gbopciones.TabStop = False
        Me.gbopciones.Text = "Datos del producto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "Descripción"
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.BackColor = System.Drawing.Color.White
        Me.txtDescripcionProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionProducto.Enabled = False
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(20, 75)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.ReadOnly = True
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(594, 21)
        Me.txtDescripcionProducto.TabIndex = 105
        '
        'txtUMProducto
        '
        Me.txtUMProducto.BackColor = System.Drawing.Color.White
        Me.txtUMProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUMProducto.Enabled = False
        Me.txtUMProducto.Location = New System.Drawing.Point(617, 75)
        Me.txtUMProducto.Name = "txtUMProducto"
        Me.txtUMProducto.ReadOnly = True
        Me.txtUMProducto.Size = New System.Drawing.Size(69, 21)
        Me.txtUMProducto.TabIndex = 106
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(617, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Und. Manejo"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.BackColor = System.Drawing.Color.White
        Me.txtCodigoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProducto.Enabled = False
        Me.txtCodigoProducto.Location = New System.Drawing.Point(20, 33)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.ReadOnly = True
        Me.txtCodigoProducto.Size = New System.Drawing.Size(112, 21)
        Me.txtCodigoProducto.TabIndex = 104
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(17, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 13)
        Me.Label33.TabIndex = 107
        Me.Label33.Text = "Código"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(726, 310)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.spnFactor)
        Me.gb_data.Controls.Add(Me.txtCodigo)
        Me.gb_data.Controls.Add(Me.Label4)
        Me.gb_data.Controls.Add(Me.GroupBox4)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.txt_codigoBarra)
        Me.gb_data.Controls.Add(Me.Label2)
        Me.gb_data.Controls.Add(Me.txt_alias)
        Me.gb_data.Controls.Add(Me.Label24)
        Me.gb_data.Controls.Add(Me.txtunidaddesc)
        Me.gb_data.Controls.Add(Me.PictureBox1)
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Controls.Add(Me.txt_um)
        Me.gb_data.Controls.Add(Me.PictureBox5)
        Me.gb_data.Controls.Add(Me.txtUnidMedRef)
        Me.gb_data.Controls.Add(Me.txtunidadrefdesc)
        Me.gb_data.ForeColor = System.Drawing.Color.Navy
        Me.gb_data.Location = New System.Drawing.Point(25, 9)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(679, 278)
        Me.gb_data.TabIndex = 1
        Me.gb_data.TabStop = False
        '
        'spnFactor
        '
        Me.spnFactor.Location = New System.Drawing.Point(440, 77)
        Me.spnFactor.Name = "spnFactor"
        Me.spnFactor.Size = New System.Drawing.Size(72, 20)
        Me.spnFactor.TabIndex = 273
        Me.spnFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.spnFactor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(127, 53)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigo.TabIndex = 270
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 271
        Me.Label4.Text = "Código"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.spnMasterPack)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.chkMainunit)
        Me.GroupBox4.Controls.Add(Me.chkstocketd)
        Me.GroupBox4.Controls.Add(Me.chkFlgNoSale)
        Me.GroupBox4.Controls.Add(Me.spnMOQ)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(69, 150)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(601, 99)
        Me.GroupBox4.TabIndex = 269
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Condiciones de venta"
        '
        'spnMasterPack
        '
        Me.spnMasterPack.Location = New System.Drawing.Point(215, 78)
        Me.spnMasterPack.Name = "spnMasterPack"
        Me.spnMasterPack.Size = New System.Drawing.Size(58, 20)
        Me.spnMasterPack.TabIndex = 271
        Me.spnMasterPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.spnMasterPack.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 26)
        Me.Label6.TabIndex = 272
        Me.Label6.Text = "MasterPack"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkMainunit
        '
        Me.chkMainunit.AutoSize = True
        Me.chkMainunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMainunit.Location = New System.Drawing.Point(333, 19)
        Me.chkMainunit.Name = "chkMainunit"
        Me.chkMainunit.Size = New System.Drawing.Size(79, 17)
        Me.chkMainunit.TabIndex = 270
        Me.chkMainunit.Text = "MAINUNIT"
        Me.chkMainunit.UseVisualStyleBackColor = True
        Me.chkMainunit.Visible = False
        '
        'chkstocketd
        '
        Me.chkstocketd.AutoSize = True
        Me.chkstocketd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkstocketd.Location = New System.Drawing.Point(215, 19)
        Me.chkstocketd.Name = "chkstocketd"
        Me.chkstocketd.Size = New System.Drawing.Size(87, 17)
        Me.chkstocketd.TabIndex = 269
        Me.chkstocketd.Text = "Almacenable"
        Me.chkstocketd.UseVisualStyleBackColor = True
        '
        'chkFlgNoSale
        '
        Me.chkFlgNoSale.AutoSize = True
        Me.chkFlgNoSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFlgNoSale.Location = New System.Drawing.Point(8, 19)
        Me.chkFlgNoSale.Name = "chkFlgNoSale"
        Me.chkFlgNoSale.Size = New System.Drawing.Size(109, 17)
        Me.chkFlgNoSale.TabIndex = 267
        Me.chkFlgNoSale.Text = "No es para Venta"
        Me.chkFlgNoSale.UseVisualStyleBackColor = True
        '
        'spnMOQ
        '
        Me.spnMOQ.Location = New System.Drawing.Point(215, 52)
        Me.spnMOQ.Name = "spnMOQ"
        Me.spnMOQ.Size = New System.Drawing.Size(58, 20)
        Me.spnMOQ.TabIndex = 5
        Me.spnMOQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.spnMOQ.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(196, 26)
        Me.Label15.TabIndex = 264
        Me.Label15.Text = "Cantidad Minima Requerida (MOQ):"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Cod. Barra"
        '
        'txt_codigoBarra
        '
        Me.txt_codigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_codigoBarra.Location = New System.Drawing.Point(127, 123)
        Me.txt_codigoBarra.Name = "txt_codigoBarra"
        Me.txt_codigoBarra.Size = New System.Drawing.Size(543, 20)
        Me.txt_codigoBarra.TabIndex = 153
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Alias"
        '
        'txt_alias
        '
        Me.txt_alias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_alias.Location = New System.Drawing.Point(127, 100)
        Me.txt_alias.Name = "txt_alias"
        Me.txt_alias.Size = New System.Drawing.Size(543, 20)
        Me.txt_alias.TabIndex = 151
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(397, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 13)
        Me.Label24.TabIndex = 150
        Me.Label24.Text = "Factor"
        '
        'txtunidaddesc
        '
        Me.txtunidaddesc.BackColor = System.Drawing.Color.White
        Me.txtunidaddesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidaddesc.Enabled = False
        Me.txtunidaddesc.Location = New System.Drawing.Point(223, 77)
        Me.txtunidaddesc.Name = "txtunidaddesc"
        Me.txtunidaddesc.ReadOnly = True
        Me.txtunidaddesc.Size = New System.Drawing.Size(172, 20)
        Me.txtunidaddesc.TabIndex = 148
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(199, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 147
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Uni. Med."
        '
        'txt_um
        '
        Me.txt_um.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_um.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_um.Location = New System.Drawing.Point(127, 77)
        Me.txt_um.Name = "txt_um"
        Me.txt_um.ReadOnly = True
        Me.txt_um.Size = New System.Drawing.Size(69, 20)
        Me.txt_um.TabIndex = 146
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(199, 77)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox5.TabIndex = 274
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'txtUnidMedRef
        '
        Me.txtUnidMedRef.BackColor = System.Drawing.Color.Aquamarine
        Me.txtUnidMedRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidMedRef.Location = New System.Drawing.Point(127, 77)
        Me.txtUnidMedRef.Name = "txtUnidMedRef"
        Me.txtUnidMedRef.ReadOnly = True
        Me.txtUnidMedRef.Size = New System.Drawing.Size(69, 20)
        Me.txtUnidMedRef.TabIndex = 273
        Me.txtUnidMedRef.Visible = False
        '
        'txtunidadrefdesc
        '
        Me.txtunidadrefdesc.BackColor = System.Drawing.Color.White
        Me.txtunidadrefdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadrefdesc.Enabled = False
        Me.txtunidadrefdesc.Location = New System.Drawing.Point(223, 77)
        Me.txtunidadrefdesc.Name = "txtunidadrefdesc"
        Me.txtunidadrefdesc.ReadOnly = True
        Me.txtunidadrefdesc.Size = New System.Drawing.Size(172, 20)
        Me.txtunidadrefdesc.TabIndex = 272
        Me.txtunidadrefdesc.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgUnidadesMedida)
        Me.TabPage1.Controls.Add(Me.lblcantidad)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(726, 310)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Unidades de Medida"
        '
        'dgUnidadesMedida
        '
        Me.dgUnidadesMedida.AllowUserToAddRows = False
        Me.dgUnidadesMedida.AllowUserToDeleteRows = False
        Me.dgUnidadesMedida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgUnidadesMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUnidadesMedida.Location = New System.Drawing.Point(5, 6)
        Me.dgUnidadesMedida.Name = "dgUnidadesMedida"
        Me.dgUnidadesMedida.ReadOnly = True
        Me.dgUnidadesMedida.RowHeadersWidth = 62
        Me.dgUnidadesMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUnidadesMedida.Size = New System.Drawing.Size(717, 317)
        Me.dgUnidadesMedida.TabIndex = 127
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblcantidad.Location = New System.Drawing.Point(3, 326)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(10, 13)
        Me.lblcantidad.TabIndex = 25
        Me.lblcantidad.Text = "."
        '
        'tc_articulo
        '
        Me.tc_articulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_articulo.Controls.Add(Me.TabPage1)
        Me.tc_articulo.Controls.Add(Me.TabPage2)
        Me.tc_articulo.Location = New System.Drawing.Point(3, 175)
        Me.tc_articulo.Name = "tc_articulo"
        Me.tc_articulo.SelectedIndex = 0
        Me.tc_articulo.Size = New System.Drawing.Size(734, 336)
        Me.tc_articulo.TabIndex = 26
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(745, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 54
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
        'btn_grabar
        '
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_Editar
        '
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(79, 22)
        Me.btn_Editar.Text = "&Modificar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton6.Text = "&Salir"
        '
        'btnBuscarArchivos
        '
        Me.btnBuscarArchivos.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnBuscarArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarArchivos.Location = New System.Drawing.Point(594, 137)
        Me.btnBuscarArchivos.Name = "btnBuscarArchivos"
        Me.btnBuscarArchivos.Size = New System.Drawing.Size(33, 29)
        Me.btnBuscarArchivos.TabIndex = 292
        Me.btnBuscarArchivos.Text = "..."
        Me.btnBuscarArchivos.UseVisualStyleBackColor = True
        '
        'btnSubirArchivo
        '
        Me.btnSubirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSubirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubirArchivo.Image = Global.LibCobranzas.My.Resources.Resources.add_list_26
        Me.btnSubirArchivo.Location = New System.Drawing.Point(630, 137)
        Me.btnSubirArchivo.Name = "btnSubirArchivo"
        Me.btnSubirArchivo.Size = New System.Drawing.Size(33, 29)
        Me.btnSubirArchivo.TabIndex = 291
        Me.btnSubirArchivo.UseVisualStyleBackColor = True
        '
        'txtRutaArchivo
        '
        Me.txtRutaArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaArchivo.Location = New System.Drawing.Point(102, 140)
        Me.txtRutaArchivo.Name = "txtRutaArchivo"
        Me.txtRutaArchivo.Size = New System.Drawing.Size(486, 23)
        Me.txtRutaArchivo.TabIndex = 290
        '
        'btnpdf
        '
        Me.btnpdf.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpdf.Image = CType(resources.GetObject("btnpdf.Image"), System.Drawing.Image)
        Me.btnpdf.Location = New System.Drawing.Point(701, 132)
        Me.btnpdf.Name = "btnpdf"
        Me.btnpdf.Size = New System.Drawing.Size(36, 38)
        Me.btnpdf.TabIndex = 289
        Me.btnpdf.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(14, 144)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 13)
        Me.Label23.TabIndex = 288
        Me.Label23.Text = "Ficha Técnica"
        '
        'btneliminar
        '
        Me.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Image = Global.LibCobranzas.My.Resources.Resources.delete_26
        Me.btneliminar.Location = New System.Drawing.Point(664, 137)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(33, 29)
        Me.btneliminar.TabIndex = 293
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'FrmArticuloAct_Unidad_Medida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(745, 533)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnBuscarArchivos)
        Me.Controls.Add(Me.btnSubirArchivo)
        Me.Controls.Add(Me.txtRutaArchivo)
        Me.Controls.Add(Me.btnpdf)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_articulo)
        Me.Controls.Add(Me.gbopciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmArticuloAct_Unidad_Medida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualización de Unidad de Medida"
        Me.gbopciones.ResumeLayout(False)
        Me.gbopciones.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.spnFactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.spnMasterPack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnMOQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgUnidadesMedida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_articulo.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbopciones As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tc_articulo As System.Windows.Forms.TabControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtUMProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgUnidadesMedida As System.Windows.Forms.DataGridView
    Friend WithEvents gb_data As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkstocketd As System.Windows.Forms.CheckBox
    Friend WithEvents chkFlgNoSale As System.Windows.Forms.CheckBox
    Friend WithEvents spnMOQ As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_codigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_alias As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtunidaddesc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_um As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkMainunit As System.Windows.Forms.CheckBox
    Friend WithEvents txtunidadrefdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidMedRef As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents spnMasterPack As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents spnFactor As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnBuscarArchivos As System.Windows.Forms.Button
    Friend WithEvents btnSubirArchivo As System.Windows.Forms.Button
    Friend WithEvents txtRutaArchivo As System.Windows.Forms.TextBox
    Friend WithEvents btnpdf As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btneliminar As System.Windows.Forms.Button
End Class
