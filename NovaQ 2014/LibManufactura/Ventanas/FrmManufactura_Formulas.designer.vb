<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManufactura_Formulas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManufactura_Formulas))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboMostrar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.cboalmacen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.rbee = New System.Windows.Forms.RadioButton()
        Me.rbmp = New System.Windows.Forms.RadioButton()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkFormula = New System.Windows.Forms.CheckBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.LBLPORCENTAJE = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_maquina = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_proceso = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDetalles_procesos = New System.Windows.Forms.DataGridView()
        Me.btn_add_procesos = New System.Windows.Forms.Button()
        Me.btn_del_procesos = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgv_detalle_historial_cambios = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerFormulaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle_Archivo = New System.Windows.Forms.DataGridView()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_ARCHIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_ARCHIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESO_ARCHIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_REGISTRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXTENSION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVO = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmAdmArchivos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmDescargar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_subir_archivo = New System.Windows.Forms.Button()
        Me.odArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdb_procedimiento = New System.Windows.Forms.RadioButton()
        Me.rdb_hoja_seguridad = New System.Windows.Forms.RadioButton()
        Me.rdb_ficha_tecnica = New System.Windows.Forms.RadioButton()
        Me.fbAdmArchivos = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbcabecera.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetalles_procesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_detalle_historial_cambios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.dgvDetalle_Archivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmAdmArchivos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMostrar
        '
        Me.cboMostrar.FormattingEnabled = True
        Me.cboMostrar.Items.AddRange(New Object() {"-Todas--", "F. MP", "F. EE"})
        Me.cboMostrar.Location = New System.Drawing.Point(734, 14)
        Me.cboMostrar.Name = "cboMostrar"
        Me.cboMostrar.Size = New System.Drawing.Size(177, 21)
        Me.cboMostrar.TabIndex = 0
        Me.cboMostrar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(686, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mostrar"
        Me.Label1.Visible = False
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(19, 68)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.Size = New System.Drawing.Size(1270, 477)
        Me.dgvCabecera.TabIndex = 2
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Controls.Add(Me.cboMostrar)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Location = New System.Drawing.Point(6, 29)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1305, 558)
        Me.pnlCabecera.TabIndex = 177
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(641, 45)
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
        Me.txtFiltro.Size = New System.Drawing.Size(616, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'cboalmacen
        '
        Me.cboalmacen.BackColor = System.Drawing.SystemColors.Window
        Me.cboalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboalmacen.Location = New System.Drawing.Point(70, 175)
        Me.cboalmacen.Name = "cboalmacen"
        Me.cboalmacen.Size = New System.Drawing.Size(251, 21)
        Me.cboalmacen.TabIndex = 178
        Me.cboalmacen.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Almacen"
        '
        'gbcabecera
        '
        Me.gbcabecera.Controls.Add(Me.Label2)
        Me.gbcabecera.Controls.Add(Me.rbee)
        Me.gbcabecera.Controls.Add(Me.rbmp)
        Me.gbcabecera.Controls.Add(Me.cboMoneda)
        Me.gbcabecera.Controls.Add(Me.Label6)
        Me.gbcabecera.Controls.Add(Me.txtdescripcion)
        Me.gbcabecera.Controls.Add(Me.Label5)
        Me.gbcabecera.Controls.Add(Me.dtpFecha)
        Me.gbcabecera.Controls.Add(Me.Label4)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.Label3)
        Me.gbcabecera.Controls.Add(Me.chkFormula)
        Me.gbcabecera.Location = New System.Drawing.Point(12, 33)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(679, 85)
        Me.gbcabecera.TabIndex = 178
        Me.gbcabecera.TabStop = False
        '
        'rbee
        '
        Me.rbee.AutoSize = True
        Me.rbee.ForeColor = System.Drawing.Color.Navy
        Me.rbee.Location = New System.Drawing.Point(308, 62)
        Me.rbee.Name = "rbee"
        Me.rbee.Size = New System.Drawing.Size(94, 17)
        Me.rbee.TabIndex = 10
        Me.rbee.Text = "Formula de EE"
        Me.rbee.UseVisualStyleBackColor = True
        Me.rbee.Visible = False
        '
        'rbmp
        '
        Me.rbmp.AutoSize = True
        Me.rbmp.Checked = True
        Me.rbmp.ForeColor = System.Drawing.Color.Navy
        Me.rbmp.Location = New System.Drawing.Point(204, 62)
        Me.rbmp.Name = "rbmp"
        Me.rbmp.Size = New System.Drawing.Size(96, 17)
        Me.rbmp.TabIndex = 9
        Me.rbmp.TabStop = True
        Me.rbmp.Text = "Formula de MP"
        Me.rbmp.UseVisualStyleBackColor = True
        Me.rbmp.Visible = False
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(77, 182)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(147, 21)
        Me.cboMoneda.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Moneda"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Location = New System.Drawing.Point(77, 37)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(538, 20)
        Me.txtdescripcion.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(9, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripción"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(75, 59)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(107, 20)
        Me.dtpFecha.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(32, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha"
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(78, 15)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(146, 20)
        Me.txtcodigo.TabIndex = 1
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(32, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Codigo"
        '
        'chkFormula
        '
        Me.chkFormula.AutoSize = True
        Me.chkFormula.Location = New System.Drawing.Point(11, 126)
        Me.chkFormula.Name = "chkFormula"
        Me.chkFormula.Size = New System.Drawing.Size(125, 17)
        Me.chkFormula.TabIndex = 181
        Me.chkFormula.Text = "Usar Formula Emitida"
        Me.chkFormula.UseVisualStyleBackColor = True
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.ForeColor = System.Drawing.Color.Navy
        Me.chkEstado.Location = New System.Drawing.Point(512, 121)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(141, 17)
        Me.chkEstado.TabIndex = 2
        Me.chkEstado.Text = "Estado Activo / Inactivo"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtComentario
        '
        Me.txtComentario.BackColor = System.Drawing.Color.White
        Me.txtComentario.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtComentario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentario.Location = New System.Drawing.Point(11, 140)
        Me.txtComentario.MaxLength = 355
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentario.Size = New System.Drawing.Size(677, 25)
        Me.txtComentario.TabIndex = 180
        Me.txtComentario.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(19, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 13)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Comentarios / Observaciones"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnEliminar, Me.btnGrabar, Me.btnImprimir, Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1323, 25)
        Me.ToolStrip1.TabIndex = 185
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 22)
        Me.btnConsultar.Text = "&Consultar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(66, 22)
        Me.btnGrabar.Text = "&Grabar"
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
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = "&Cancelar"
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
        'LBLPORCENTAJE
        '
        Me.LBLPORCENTAJE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBLPORCENTAJE.AutoSize = True
        Me.LBLPORCENTAJE.ForeColor = System.Drawing.Color.Navy
        Me.LBLPORCENTAJE.Location = New System.Drawing.Point(21, 544)
        Me.LBLPORCENTAJE.Name = "LBLPORCENTAJE"
        Me.LBLPORCENTAJE.Size = New System.Drawing.Size(10, 13)
        Me.LBLPORCENTAJE.TabIndex = 186
        Me.LBLPORCENTAJE.Text = "."
        Me.LBLPORCENTAJE.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(19, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 187
        Me.Label8.Text = "Almacen"
        Me.Label8.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 172)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1299, 409)
        Me.TabControl1.TabIndex = 188
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbOpciones)
        Me.TabPage1.Controls.Add(Me.gbDetalles)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1291, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Insumos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Location = New System.Drawing.Point(1189, 8)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(72, 365)
        Me.gbOpciones.TabIndex = 183
        Me.gbOpciones.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(7, 89)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(60, 53)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnquitar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.Location = New System.Drawing.Point(7, 146)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(60, 53)
        Me.btnquitar.TabIndex = 15
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(7, 32)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(60, 53)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.dgvDetalles)
        Me.gbDetalles.Location = New System.Drawing.Point(7, 8)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(1176, 365)
        Me.gbDetalles.TabIndex = 180
        Me.gbDetalles.TabStop = False
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(10, 15)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles.Size = New System.Drawing.Size(1154, 338)
        Me.dgvDetalles.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.txt_maquina)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.txt_proceso)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.btn_add_procesos)
        Me.TabPage2.Controls.Add(Me.btn_del_procesos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1291, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de Procesos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(304, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 16)
        Me.Label19.TabIndex = 234
        Me.Label19.Text = "Maquina"
        '
        'txt_maquina
        '
        Me.txt_maquina.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_maquina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_maquina.ForeColor = System.Drawing.Color.Black
        Me.txt_maquina.Location = New System.Drawing.Point(367, 13)
        Me.txt_maquina.Name = "txt_maquina"
        Me.txt_maquina.Size = New System.Drawing.Size(208, 20)
        Me.txt_maquina.TabIndex = 233
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(10, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 16)
        Me.Label21.TabIndex = 232
        Me.Label21.Text = "Proceso"
        '
        'txt_proceso
        '
        Me.txt_proceso.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_proceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_proceso.ForeColor = System.Drawing.Color.Black
        Me.txt_proceso.Location = New System.Drawing.Point(66, 13)
        Me.txt_proceso.Name = "txt_proceso"
        Me.txt_proceso.Size = New System.Drawing.Size(208, 20)
        Me.txt_proceso.TabIndex = 231
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvDetalles_procesos)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1275, 334)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        '
        'dgvDetalles_procesos
        '
        Me.dgvDetalles_procesos.AllowUserToAddRows = False
        Me.dgvDetalles_procesos.AllowUserToDeleteRows = False
        Me.dgvDetalles_procesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles_procesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles_procesos.Location = New System.Drawing.Point(10, 15)
        Me.dgvDetalles_procesos.Name = "dgvDetalles_procesos"
        Me.dgvDetalles_procesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles_procesos.Size = New System.Drawing.Size(1253, 307)
        Me.dgvDetalles_procesos.TabIndex = 0
        '
        'btn_add_procesos
        '
        Me.btn_add_procesos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_add_procesos.ForeColor = System.Drawing.Color.Navy
        Me.btn_add_procesos.Image = CType(resources.GetObject("btn_add_procesos.Image"), System.Drawing.Image)
        Me.btn_add_procesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_procesos.Location = New System.Drawing.Point(607, 13)
        Me.btn_add_procesos.Name = "btn_add_procesos"
        Me.btn_add_procesos.Size = New System.Drawing.Size(68, 23)
        Me.btn_add_procesos.TabIndex = 230
        Me.btn_add_procesos.Text = "Agregar"
        Me.btn_add_procesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add_procesos.UseVisualStyleBackColor = True
        '
        'btn_del_procesos
        '
        Me.btn_del_procesos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_del_procesos.ForeColor = System.Drawing.Color.Navy
        Me.btn_del_procesos.Image = CType(resources.GetObject("btn_del_procesos.Image"), System.Drawing.Image)
        Me.btn_del_procesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del_procesos.Location = New System.Drawing.Point(679, 13)
        Me.btn_del_procesos.Name = "btn_del_procesos"
        Me.btn_del_procesos.Size = New System.Drawing.Size(68, 23)
        Me.btn_del_procesos.TabIndex = 229
        Me.btn_del_procesos.Text = "Eliminar"
        Me.btn_del_procesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del_procesos.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1291, 383)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Historial de cambios"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.dgv_detalle_historial_cambios)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1269, 365)
        Me.GroupBox4.TabIndex = 181
        Me.GroupBox4.TabStop = False
        '
        'dgv_detalle_historial_cambios
        '
        Me.dgv_detalle_historial_cambios.AllowUserToAddRows = False
        Me.dgv_detalle_historial_cambios.AllowUserToDeleteRows = False
        Me.dgv_detalle_historial_cambios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalle_historial_cambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_historial_cambios.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv_detalle_historial_cambios.Location = New System.Drawing.Point(10, 15)
        Me.dgv_detalle_historial_cambios.Name = "dgv_detalle_historial_cambios"
        Me.dgv_detalle_historial_cambios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle_historial_cambios.Size = New System.Drawing.Size(1247, 338)
        Me.dgv_detalle_historial_cambios.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerFormulaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(136, 26)
        '
        'VerFormulaToolStripMenuItem
        '
        Me.VerFormulaToolStripMenuItem.Image = CType(resources.GetObject("VerFormulaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerFormulaToolStripMenuItem.Name = "VerFormulaToolStripMenuItem"
        Me.VerFormulaToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VerFormulaToolStripMenuItem.Text = "Ver formula"
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.White
        Me.GroupBox15.Controls.Add(Me.dgvDetalle_Archivo)
        Me.GroupBox15.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox15.Location = New System.Drawing.Point(710, 33)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(451, 151)
        Me.GroupBox15.TabIndex = 239
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Ficha Tecnica/Hoja de seguridad"
        '
        'dgvDetalle_Archivo
        '
        Me.dgvDetalle_Archivo.AllowUserToAddRows = False
        Me.dgvDetalle_Archivo.AllowUserToDeleteRows = False
        Me.dgvDetalle_Archivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle_Archivo.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalle_Archivo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle_Archivo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetalle_Archivo.ColumnHeadersHeight = 30
        Me.dgvDetalle_Archivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.ITEM_ARCHIVO, Me.DESCRIPCION, Me.NOMBRE_ARCHIVO, Me.PESO_ARCHIVO, Me.FECHA_REGISTRO, Me.EXTENSION, Me.ARCHIVO})
        Me.dgvDetalle_Archivo.ContextMenuStrip = Me.cmAdmArchivos
        Me.dgvDetalle_Archivo.EnableHeadersVisualStyles = False
        Me.dgvDetalle_Archivo.Location = New System.Drawing.Point(9, 19)
        Me.dgvDetalle_Archivo.Name = "dgvDetalle_Archivo"
        Me.dgvDetalle_Archivo.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle_Archivo.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDetalle_Archivo.RowHeadersVisible = False
        Me.dgvDetalle_Archivo.RowHeadersWidth = 50
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDetalle_Archivo.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDetalle_Archivo.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDetalle_Archivo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy
        Me.dgvDetalle_Archivo.RowTemplate.Height = 30
        Me.dgvDetalle_Archivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle_Archivo.Size = New System.Drawing.Size(434, 122)
        Me.dgvDetalle_Archivo.TabIndex = 114
        '
        'ITEM
        '
        Me.ITEM.DataPropertyName = "ITEM"
        Me.ITEM.Frozen = True
        Me.ITEM.HeaderText = "ITEM"
        Me.ITEM.Name = "ITEM"
        Me.ITEM.ReadOnly = True
        Me.ITEM.Width = 50
        '
        'ITEM_ARCHIVO
        '
        Me.ITEM_ARCHIVO.DataPropertyName = "ITEM_ARCHIVO"
        Me.ITEM_ARCHIVO.Frozen = True
        Me.ITEM_ARCHIVO.HeaderText = "ITEM ARCHIVO"
        Me.ITEM_ARCHIVO.Name = "ITEM_ARCHIVO"
        Me.ITEM_ARCHIVO.ReadOnly = True
        Me.ITEM_ARCHIVO.Visible = False
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION.HeaderText = "OBSERVACIONES"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Visible = False
        Me.DESCRIPCION.Width = 450
        '
        'NOMBRE_ARCHIVO
        '
        Me.NOMBRE_ARCHIVO.DataPropertyName = "NOMBRE_ARCHIVO"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE_ARCHIVO.DefaultCellStyle = DataGridViewCellStyle7
        Me.NOMBRE_ARCHIVO.HeaderText = "NOMBRE ARCHIVO"
        Me.NOMBRE_ARCHIVO.Name = "NOMBRE_ARCHIVO"
        Me.NOMBRE_ARCHIVO.ReadOnly = True
        Me.NOMBRE_ARCHIVO.Width = 250
        '
        'PESO_ARCHIVO
        '
        Me.PESO_ARCHIVO.DataPropertyName = "PESO_ARCHIVO"
        Me.PESO_ARCHIVO.HeaderText = "TAMAÑO ARCHIVO"
        Me.PESO_ARCHIVO.Name = "PESO_ARCHIVO"
        Me.PESO_ARCHIVO.ReadOnly = True
        Me.PESO_ARCHIVO.Visible = False
        '
        'FECHA_REGISTRO
        '
        Me.FECHA_REGISTRO.DataPropertyName = "FECHA_REGISTRO"
        Me.FECHA_REGISTRO.HeaderText = "FECHA/HORA REGISTRO"
        Me.FECHA_REGISTRO.Name = "FECHA_REGISTRO"
        Me.FECHA_REGISTRO.ReadOnly = True
        Me.FECHA_REGISTRO.Visible = False
        '
        'EXTENSION
        '
        Me.EXTENSION.DataPropertyName = "EXTENSION"
        Me.EXTENSION.HeaderText = "EXTENSIÓN"
        Me.EXTENSION.Name = "EXTENSION"
        Me.EXTENSION.ReadOnly = True
        Me.EXTENSION.Visible = False
        '
        'ARCHIVO
        '
        Me.ARCHIVO.DataPropertyName = "ARCHIVO"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.NullValue = CType(resources.GetObject("DataGridViewCellStyle8.NullValue"), Object)
        Me.ARCHIVO.DefaultCellStyle = DataGridViewCellStyle8
        Me.ARCHIVO.HeaderText = "ARCHIVO"
        Me.ARCHIVO.Name = "ARCHIVO"
        Me.ARCHIVO.ReadOnly = True
        Me.ARCHIVO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cmAdmArchivos
        '
        Me.cmAdmArchivos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmAbrir, Me.cmDescargar, Me.cmEliminar})
        Me.cmAdmArchivos.Name = "cmAdmArchivos"
        Me.cmAdmArchivos.Size = New System.Drawing.Size(169, 70)
        '
        'cmAbrir
        '
        Me.cmAbrir.Image = CType(resources.GetObject("cmAbrir.Image"), System.Drawing.Image)
        Me.cmAbrir.Name = "cmAbrir"
        Me.cmAbrir.Size = New System.Drawing.Size(168, 22)
        Me.cmAbrir.Text = "Abrir archivo"
        '
        'cmDescargar
        '
        Me.cmDescargar.Image = CType(resources.GetObject("cmDescargar.Image"), System.Drawing.Image)
        Me.cmDescargar.Name = "cmDescargar"
        Me.cmDescargar.Size = New System.Drawing.Size(168, 22)
        Me.cmDescargar.Text = "Descargar archivo"
        '
        'cmEliminar
        '
        Me.cmEliminar.Image = CType(resources.GetObject("cmEliminar.Image"), System.Drawing.Image)
        Me.cmEliminar.Name = "cmEliminar"
        Me.cmEliminar.Size = New System.Drawing.Size(168, 22)
        Me.cmEliminar.Text = "Eliminar archivo"
        '
        'btn_subir_archivo
        '
        Me.btn_subir_archivo.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_subir_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_subir_archivo.Location = New System.Drawing.Point(1170, 137)
        Me.btn_subir_archivo.Name = "btn_subir_archivo"
        Me.btn_subir_archivo.Size = New System.Drawing.Size(26, 23)
        Me.btn_subir_archivo.TabIndex = 240
        Me.btn_subir_archivo.Text = "+"
        Me.btn_subir_archivo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdb_procedimiento)
        Me.GroupBox2.Controls.Add(Me.rdb_hoja_seguridad)
        Me.GroupBox2.Controls.Add(Me.rdb_ficha_tecnica)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(1168, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 98)
        Me.GroupBox2.TabIndex = 242
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'rdb_procedimiento
        '
        Me.rdb_procedimiento.AutoSize = True
        Me.rdb_procedimiento.Location = New System.Drawing.Point(6, 75)
        Me.rdb_procedimiento.Name = "rdb_procedimiento"
        Me.rdb_procedimiento.Size = New System.Drawing.Size(92, 17)
        Me.rdb_procedimiento.TabIndex = 2
        Me.rdb_procedimiento.TabStop = True
        Me.rdb_procedimiento.Text = "Procedimiento"
        Me.rdb_procedimiento.UseVisualStyleBackColor = True
        '
        'rdb_hoja_seguridad
        '
        Me.rdb_hoja_seguridad.AutoSize = True
        Me.rdb_hoja_seguridad.Location = New System.Drawing.Point(6, 47)
        Me.rdb_hoja_seguridad.Name = "rdb_hoja_seguridad"
        Me.rdb_hoja_seguridad.Size = New System.Drawing.Size(113, 17)
        Me.rdb_hoja_seguridad.TabIndex = 1
        Me.rdb_hoja_seguridad.TabStop = True
        Me.rdb_hoja_seguridad.Text = "Hoja de Seguridad"
        Me.rdb_hoja_seguridad.UseVisualStyleBackColor = True
        '
        'rdb_ficha_tecnica
        '
        Me.rdb_ficha_tecnica.AutoSize = True
        Me.rdb_ficha_tecnica.Location = New System.Drawing.Point(6, 19)
        Me.rdb_ficha_tecnica.Name = "rdb_ficha_tecnica"
        Me.rdb_ficha_tecnica.Size = New System.Drawing.Size(89, 17)
        Me.rdb_ficha_tecnica.TabIndex = 0
        Me.rdb_ficha_tecnica.TabStop = True
        Me.rdb_ficha_tecnica.Text = "Ficha tecnica"
        Me.rdb_ficha_tecnica.UseVisualStyleBackColor = True
        '
        'FrmManufactura_Formulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1323, 594)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_subir_archivo)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.gbcabecera)
        Me.Controls.Add(Me.LBLPORCENTAJE)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboalmacen)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmManufactura_Formulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Formulas"
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        Me.gbDetalles.ResumeLayout(False)
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDetalles_procesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgv_detalle_historial_cambios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        CType(Me.dgvDetalle_Archivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmAdmArchivos.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMostrar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbee As System.Windows.Forms.RadioButton
    Friend WithEvents rbmp As System.Windows.Forms.RadioButton
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtComentario As System.Windows.Forms.RichTextBox
    Friend WithEvents chkFormula As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents LBLPORCENTAJE As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalles_procesos As System.Windows.Forms.DataGridView
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_maquina As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_proceso As System.Windows.Forms.TextBox
    Friend WithEvents btn_add_procesos As System.Windows.Forms.Button
    Friend WithEvents btn_del_procesos As System.Windows.Forms.Button
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_subir_archivo As System.Windows.Forms.Button
    Friend WithEvents cmAdmArchivos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmDescargar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_hoja_seguridad As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_ficha_tecnica As System.Windows.Forms.RadioButton
    Friend WithEvents dgvDetalle_Archivo As System.Windows.Forms.DataGridView
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEM_ARCHIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_ARCHIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESO_ARCHIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_REGISTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXTENSION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVO As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents fbAdmArchivos As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents rdb_procedimiento As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_detalle_historial_cambios As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerFormulaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
