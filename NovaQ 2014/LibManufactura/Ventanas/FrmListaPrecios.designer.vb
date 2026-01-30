<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaPrecios))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_importador_compras_aut = New System.Windows.Forms.ToolStripButton()
        Me.btn_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnRetornar = New System.Windows.Forms.ToolStripButton()
        Me.gbopciones = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.rbmuestramedica = New System.Windows.Forms.RadioButton()
        Me.rbmaquila = New System.Windows.Forms.RadioButton()
        Me.rbmarca = New System.Windows.Forms.RadioButton()
        Me.rbgenericos = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvdetalleArticulo = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.pnl_importador_compras = New System.Windows.Forms.Panel()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.dgvdetalles_imp = New System.Windows.Forms.DataGridView()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_importar_detalle = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.txt_ruta_oficial = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_por_utilidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.gbopciones.SuspendLayout()
        CType(Me.DgvdetalleArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.pnl_importador_compras.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.dgvdetalles_imp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGrabar, Me.btn_importador_compras_aut, Me.btn_Cancelar, Me.btnRetornar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(974, 25)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(121, 22)
        Me.btnGrabar.Text = "&Registrar Costos"
        '
        'btn_importador_compras_aut
        '
        Me.btn_importador_compras_aut.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_importador_compras_aut.Image = CType(resources.GetObject("btn_importador_compras_aut.Image"), System.Drawing.Image)
        Me.btn_importador_compras_aut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_importador_compras_aut.Name = "btn_importador_compras_aut"
        Me.btn_importador_compras_aut.Size = New System.Drawing.Size(120, 22)
        Me.btn_importador_compras_aut.Text = "Importar Costos"
        Me.btn_importador_compras_aut.Visible = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.Visible = False
        '
        'btnRetornar
        '
        Me.btnRetornar.Image = CType(resources.GetObject("btnRetornar.Image"), System.Drawing.Image)
        Me.btnRetornar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRetornar.Name = "btnRetornar"
        Me.btnRetornar.Size = New System.Drawing.Size(52, 22)
        Me.btnRetornar.Text = "&Salir"
        '
        'gbopciones
        '
        Me.gbopciones.Controls.Add(Me.ProgressBar1)
        Me.gbopciones.Controls.Add(Me.rbmuestramedica)
        Me.gbopciones.Controls.Add(Me.rbmaquila)
        Me.gbopciones.Controls.Add(Me.rbmarca)
        Me.gbopciones.Controls.Add(Me.rbgenericos)
        Me.gbopciones.Controls.Add(Me.Label1)
        Me.gbopciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbopciones.Location = New System.Drawing.Point(3, 84)
        Me.gbopciones.Name = "gbopciones"
        Me.gbopciones.Size = New System.Drawing.Size(854, 34)
        Me.gbopciones.TabIndex = 22
        Me.gbopciones.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(84, 13)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(761, 12)
        Me.ProgressBar1.TabIndex = 12
        '
        'rbmuestramedica
        '
        Me.rbmuestramedica.AutoSize = True
        Me.rbmuestramedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbmuestramedica.ForeColor = System.Drawing.Color.Navy
        Me.rbmuestramedica.Location = New System.Drawing.Point(870, 12)
        Me.rbmuestramedica.Name = "rbmuestramedica"
        Me.rbmuestramedica.Size = New System.Drawing.Size(149, 17)
        Me.rbmuestramedica.TabIndex = 3
        Me.rbmuestramedica.Text = "&Productos Muesta Medica"
        Me.rbmuestramedica.UseVisualStyleBackColor = True
        Me.rbmuestramedica.Visible = False
        '
        'rbmaquila
        '
        Me.rbmaquila.AutoSize = True
        Me.rbmaquila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbmaquila.ForeColor = System.Drawing.Color.Navy
        Me.rbmaquila.Location = New System.Drawing.Point(756, 12)
        Me.rbmaquila.Name = "rbmaquila"
        Me.rbmaquila.Size = New System.Drawing.Size(108, 17)
        Me.rbmaquila.TabIndex = 2
        Me.rbmaquila.Text = "&Producto Maquila"
        Me.rbmaquila.UseVisualStyleBackColor = True
        Me.rbmaquila.Visible = False
        '
        'rbmarca
        '
        Me.rbmarca.AutoSize = True
        Me.rbmarca.Checked = True
        Me.rbmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbmarca.ForeColor = System.Drawing.Color.Navy
        Me.rbmarca.Location = New System.Drawing.Point(494, 12)
        Me.rbmarca.Name = "rbmarca"
        Me.rbmarca.Size = New System.Drawing.Size(134, 17)
        Me.rbmarca.TabIndex = 0
        Me.rbmarca.TabStop = True
        Me.rbmarca.Text = "&Productos de Generico"
        Me.rbmarca.UseVisualStyleBackColor = True
        Me.rbmarca.Visible = False
        '
        'rbgenericos
        '
        Me.rbgenericos.AutoSize = True
        Me.rbgenericos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbgenericos.ForeColor = System.Drawing.Color.Navy
        Me.rbgenericos.Location = New System.Drawing.Point(634, 12)
        Me.rbgenericos.Name = "rbgenericos"
        Me.rbgenericos.Size = New System.Drawing.Size(106, 17)
        Me.rbgenericos.TabIndex = 1
        Me.rbgenericos.Text = "&Productos Marca"
        Me.rbgenericos.UseVisualStyleBackColor = True
        Me.rbgenericos.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Procesar ..."
        '
        'DgvdetalleArticulo
        '
        Me.DgvdetalleArticulo.AllowUserToAddRows = False
        Me.DgvdetalleArticulo.AllowUserToDeleteRows = False
        Me.DgvdetalleArticulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvdetalleArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvdetalleArticulo.Location = New System.Drawing.Point(5, 125)
        Me.DgvdetalleArticulo.Name = "DgvdetalleArticulo"
        Me.DgvdetalleArticulo.Size = New System.Drawing.Size(957, 391)
        Me.DgvdetalleArticulo.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(5, 39)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(454, 45)
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
        Me.txtFiltro.Size = New System.Drawing.Size(440, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(5, 511)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 123
        Me.lblCantidad.Text = "."
        Me.lblCantidad.Visible = False
        '
        'pnl_importador_compras
        '
        Me.pnl_importador_compras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_importador_compras.BackColor = System.Drawing.Color.White
        Me.pnl_importador_compras.Controls.Add(Me.GroupBox16)
        Me.pnl_importador_compras.Controls.Add(Me.GroupBox17)
        Me.pnl_importador_compras.Controls.Add(Me.TextBox2)
        Me.pnl_importador_compras.Location = New System.Drawing.Point(4, 39)
        Me.pnl_importador_compras.Name = "pnl_importador_compras"
        Me.pnl_importador_compras.Size = New System.Drawing.Size(958, 484)
        Me.pnl_importador_compras.TabIndex = 204
        Me.pnl_importador_compras.Visible = False
        '
        'GroupBox16
        '
        Me.GroupBox16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox16.Controls.Add(Me.dgvdetalles_imp)
        Me.GroupBox16.Location = New System.Drawing.Point(16, 120)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(927, 352)
        Me.GroupBox16.TabIndex = 218
        Me.GroupBox16.TabStop = False
        '
        'dgvdetalles_imp
        '
        Me.dgvdetalles_imp.AllowUserToAddRows = False
        Me.dgvdetalles_imp.AllowUserToDeleteRows = False
        Me.dgvdetalles_imp.AllowUserToResizeColumns = False
        Me.dgvdetalles_imp.AllowUserToResizeRows = False
        Me.dgvdetalles_imp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdetalles_imp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles_imp.Location = New System.Drawing.Point(11, 18)
        Me.dgvdetalles_imp.Name = "dgvdetalles_imp"
        Me.dgvdetalles_imp.ReadOnly = True
        Me.dgvdetalles_imp.Size = New System.Drawing.Size(906, 322)
        Me.dgvdetalles_imp.TabIndex = 0
        '
        'GroupBox17
        '
        Me.GroupBox17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox17.Controls.Add(Me.Button1)
        Me.GroupBox17.Controls.Add(Me.btn_importar_detalle)
        Me.GroupBox17.Controls.Add(Me.Button9)
        Me.GroupBox17.Controls.Add(Me.Button10)
        Me.GroupBox17.Controls.Add(Me.txt_ruta_oficial)
        Me.GroupBox17.Controls.Add(Me.Label90)
        Me.GroupBox17.Controls.Add(Me.Label91)
        Me.GroupBox17.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(927, 74)
        Me.GroupBox17.TabIndex = 217
        Me.GroupBox17.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(823, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 33)
        Me.Button1.TabIndex = 222
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_importar_detalle
        '
        Me.btn_importar_detalle.Enabled = False
        Me.btn_importar_detalle.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_importar_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_importar_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_importar_detalle.ForeColor = System.Drawing.Color.Navy
        Me.btn_importar_detalle.Image = CType(resources.GetObject("btn_importar_detalle.Image"), System.Drawing.Image)
        Me.btn_importar_detalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_importar_detalle.Location = New System.Drawing.Point(720, 30)
        Me.btn_importar_detalle.Name = "btn_importar_detalle"
        Me.btn_importar_detalle.Size = New System.Drawing.Size(101, 33)
        Me.btn_importar_detalle.TabIndex = 221
        Me.btn_importar_detalle.Text = "Importar"
        Me.btn_importar_detalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_importar_detalle.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Navy
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(617, 30)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(101, 33)
        Me.Button9.TabIndex = 220
        Me.Button9.Text = "Mostrar"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(574, 35)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(38, 23)
        Me.Button10.TabIndex = 86
        Me.Button10.Text = "..."
        Me.Button10.UseVisualStyleBackColor = True
        '
        'txt_ruta_oficial
        '
        Me.txt_ruta_oficial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruta_oficial.Location = New System.Drawing.Point(104, 36)
        Me.txt_ruta_oficial.Name = "txt_ruta_oficial"
        Me.txt_ruta_oficial.ReadOnly = True
        Me.txt_ruta_oficial.Size = New System.Drawing.Size(459, 20)
        Me.txt_ruta_oficial.TabIndex = 83
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.ForeColor = System.Drawing.Color.Navy
        Me.Label90.Location = New System.Drawing.Point(8, 40)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(90, 13)
        Me.Label90.TabIndex = 82
        Me.Label90.Text = "Ruta de Archivo :"
        '
        'Label91
        '
        Me.Label91.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label91.BackColor = System.Drawing.Color.Green
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.White
        Me.Label91.Location = New System.Drawing.Point(0, 6)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(927, 19)
        Me.Label91.TabIndex = 81
        Me.Label91.Text = "Datos de Importación"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.Green
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(1, 1)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(956, 20)
        Me.TextBox2.TabIndex = 199
        Me.TextBox2.Text = "IMPORTADOR DE LISTA DE COSTOS"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(638, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 225
        Me.Button2.Text = "Aplicar conversión"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_por_utilidad
        '
        Me.txt_por_utilidad.BackColor = System.Drawing.Color.White
        Me.txt_por_utilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_por_utilidad.ForeColor = System.Drawing.Color.Black
        Me.txt_por_utilidad.Location = New System.Drawing.Point(554, 56)
        Me.txt_por_utilidad.MaxLength = 10
        Me.txt_por_utilidad.Name = "txt_por_utilidad"
        Me.txt_por_utilidad.Size = New System.Drawing.Size(77, 20)
        Me.txt_por_utilidad.TabIndex = 224
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(469, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 226
        Me.Label2.Text = "Tipo de Cambio"
        '
        'FrmListaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 533)
        Me.Controls.Add(Me.pnl_importador_compras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_por_utilidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbopciones)
        Me.Controls.Add(Me.DgvdetalleArticulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListaPrecios"
        Me.Text = "Lista de precios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbopciones.ResumeLayout(False)
        Me.gbopciones.PerformLayout()
        CType(Me.DgvdetalleArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnl_importador_compras.ResumeLayout(False)
        Me.pnl_importador_compras.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        CType(Me.dgvdetalles_imp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRetornar As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbopciones As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents rbmuestramedica As System.Windows.Forms.RadioButton
    Friend WithEvents rbmaquila As System.Windows.Forms.RadioButton
    Friend WithEvents rbmarca As System.Windows.Forms.RadioButton
    Friend WithEvents rbgenericos As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvdetalleArticulo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents pnl_importador_compras As System.Windows.Forms.Panel
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdetalles_imp As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_importar_detalle As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txt_ruta_oficial As System.Windows.Forms.TextBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_importador_compras_aut As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents txt_por_utilidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
