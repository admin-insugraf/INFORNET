<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Registro_Licitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Registro_Licitaciones))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tc_principal = New System.Windows.Forms.TabControl()
        Me.tc_datos = New System.Windows.Forms.TabPage()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.chkSinIGV = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.RichTextBox()
        Me.dtp_emision = New System.Windows.Forms.DateTimePicker()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_num_entregas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_num_licitacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBruto = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtvalorVenta = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_precio_unit = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_cliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_ruc_cliente = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_des_cliente = New System.Windows.Forms.TextBox()
        Me.txt_cod_cliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_saldo_registro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_num_lotes = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_articulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pres_articulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_unidad_articulo = New System.Windows.Forms.TextBox()
        Me.txt_des_articulo = New System.Windows.Forms.TextBox()
        Me.txt_cod_articulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.lblDetalle = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.pnl_detalle_num_entregas = New System.Windows.Forms.Panel()
        Me.gbBultos = New System.Windows.Forms.GroupBox()
        Me.btnreplicar = New System.Windows.Forms.Button()
        Me.dgvDetallesBulto = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCantidadAsiganda = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAceptarBultos = New System.Windows.Forms.Button()
        Me.SalirBultos = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.dgvdetalle_reporte = New System.Windows.Forms.DataGridView()
        Me.Tc_principal.SuspendLayout()
        Me.tc_datos.SuspendLayout()
        Me.gbcabecera.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_menu.SuspendLayout()
        Me.pnl_detalle_num_entregas.SuspendLayout()
        Me.gbBultos.SuspendLayout()
        CType(Me.dgvDetallesBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdetalle_reporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tc_principal
        '
        Me.Tc_principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tc_principal.Controls.Add(Me.tc_datos)
        Me.Tc_principal.Location = New System.Drawing.Point(9, 47)
        Me.Tc_principal.Multiline = True
        Me.Tc_principal.Name = "Tc_principal"
        Me.Tc_principal.SelectedIndex = 0
        Me.Tc_principal.Size = New System.Drawing.Size(923, 651)
        Me.Tc_principal.TabIndex = 197
        '
        'tc_datos
        '
        Me.tc_datos.BackColor = System.Drawing.Color.White
        Me.tc_datos.Controls.Add(Me.gbcabecera)
        Me.tc_datos.Controls.Add(Me.Label13)
        Me.tc_datos.Controls.Add(Me.txtBruto)
        Me.tc_datos.Controls.Add(Me.Label22)
        Me.tc_datos.Controls.Add(Me.txtvalorVenta)
        Me.tc_datos.Controls.Add(Me.Label23)
        Me.tc_datos.Controls.Add(Me.txtDescuentos)
        Me.tc_datos.Controls.Add(Me.Label24)
        Me.tc_datos.Controls.Add(Me.txtIgv)
        Me.tc_datos.Controls.Add(Me.Label28)
        Me.tc_datos.Controls.Add(Me.gbOpciones)
        Me.tc_datos.Controls.Add(Me.txtPrecioVenta)
        Me.tc_datos.Controls.Add(Me.gbDetalles)
        Me.tc_datos.Location = New System.Drawing.Point(4, 22)
        Me.tc_datos.Name = "tc_datos"
        Me.tc_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_datos.Size = New System.Drawing.Size(915, 625)
        Me.tc_datos.TabIndex = 0
        Me.tc_datos.Text = "Datos de la orden de compra"
        '
        'gbcabecera
        '
        Me.gbcabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.chkSinIGV)
        Me.gbcabecera.Controls.Add(Me.Label7)
        Me.gbcabecera.Controls.Add(Me.txt_observaciones)
        Me.gbcabecera.Controls.Add(Me.dtp_emision)
        Me.gbcabecera.Controls.Add(Me.Label49)
        Me.gbcabecera.Controls.Add(Me.Label8)
        Me.gbcabecera.Controls.Add(Me.txt_num_entregas)
        Me.gbcabecera.Controls.Add(Me.Label6)
        Me.gbcabecera.Controls.Add(Me.txt_num_licitacion)
        Me.gbcabecera.ForeColor = System.Drawing.Color.Navy
        Me.gbcabecera.Location = New System.Drawing.Point(6, 4)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(898, 126)
        Me.gbcabecera.TabIndex = 178
        Me.gbcabecera.TabStop = False
        Me.gbcabecera.Text = "Datos de Generales"
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Location = New System.Drawing.Point(469, 22)
        Me.txtcodigo.MaxLength = 200
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(168, 20)
        Me.txtcodigo.TabIndex = 259
        Me.txtcodigo.Visible = False
        '
        'chkSinIGV
        '
        Me.chkSinIGV.AutoSize = True
        Me.chkSinIGV.Location = New System.Drawing.Point(297, 50)
        Me.chkSinIGV.Name = "chkSinIGV"
        Me.chkSinIGV.Size = New System.Drawing.Size(98, 17)
        Me.chkSinIGV.TabIndex = 258
        Me.chkSinIGV.Text = "Precios sin IGV"
        Me.chkSinIGV.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(12, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 257
        Me.Label7.Text = "Observaciones"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_observaciones.BackColor = System.Drawing.Color.White
        Me.txt_observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_observaciones.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_observaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_observaciones.Location = New System.Drawing.Point(91, 75)
        Me.txt_observaciones.MaxLength = 200
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txt_observaciones.Size = New System.Drawing.Size(725, 32)
        Me.txt_observaciones.TabIndex = 256
        Me.txt_observaciones.Text = ""
        '
        'dtp_emision
        '
        Me.dtp_emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_emision.Location = New System.Drawing.Point(380, 22)
        Me.dtp_emision.Name = "dtp_emision"
        Me.dtp_emision.Size = New System.Drawing.Size(80, 20)
        Me.dtp_emision.TabIndex = 3
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(294, 24)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(79, 13)
        Me.Label49.TabIndex = 221
        Me.Label49.Text = "Fecha Registro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(12, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 187
        Me.Label8.Text = "N° de entegas"
        '
        'txt_num_entregas
        '
        Me.txt_num_entregas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_entregas.Location = New System.Drawing.Point(91, 49)
        Me.txt_num_entregas.MaxLength = 200
        Me.txt_num_entregas.Name = "txt_num_entregas"
        Me.txt_num_entregas.Size = New System.Drawing.Size(168, 20)
        Me.txt_num_entregas.TabIndex = 9
        Me.txt_num_entregas.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(12, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 185
        Me.Label6.Text = "N° Licitación"
        '
        'txt_num_licitacion
        '
        Me.txt_num_licitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_licitacion.Location = New System.Drawing.Point(91, 22)
        Me.txt_num_licitacion.MaxLength = 200
        Me.txt_num_licitacion.Name = "txt_num_licitacion"
        Me.txt_num_licitacion.Size = New System.Drawing.Size(168, 20)
        Me.txt_num_licitacion.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(16, 596)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 186
        Me.Label13.Text = "Valor Bruto"
        '
        'txtBruto
        '
        Me.txtBruto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBruto.BackColor = System.Drawing.Color.White
        Me.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBruto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBruto.Location = New System.Drawing.Point(90, 592)
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.ReadOnly = True
        Me.txtBruto.Size = New System.Drawing.Size(89, 21)
        Me.txtBruto.TabIndex = 21
        Me.txtBruto.Text = "0.00"
        Me.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(345, 595)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 188
        Me.Label22.Text = "&Valor Venta"
        '
        'txtvalorVenta
        '
        Me.txtvalorVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvalorVenta.BackColor = System.Drawing.Color.White
        Me.txtvalorVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalorVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalorVenta.Location = New System.Drawing.Point(418, 592)
        Me.txtvalorVenta.Name = "txtvalorVenta"
        Me.txtvalorVenta.Size = New System.Drawing.Size(89, 21)
        Me.txtvalorVenta.TabIndex = 23
        Me.txtvalorVenta.Text = "0.00"
        Me.txtvalorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(183, 595)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 190
        Me.Label23.Text = "&Descuento"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentos.BackColor = System.Drawing.Color.White
        Me.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentos.Location = New System.Drawing.Point(252, 591)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(89, 21)
        Me.txtDescuentos.TabIndex = 22
        Me.txtDescuentos.Text = "0.00"
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(513, 595)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 13)
        Me.Label24.TabIndex = 192
        Me.Label24.Text = "&I.G.V"
        '
        'txtIgv
        '
        Me.txtIgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIgv.BackColor = System.Drawing.Color.White
        Me.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIgv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgv.Location = New System.Drawing.Point(555, 591)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(89, 21)
        Me.txtIgv.TabIndex = 24
        Me.txtIgv.Text = "0.00"
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(646, 594)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 13)
        Me.Label28.TabIndex = 194
        Me.Label28.Text = "&Precio Venta"
        '
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Location = New System.Drawing.Point(837, 136)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(67, 450)
        Me.gbOpciones.TabIndex = 182
        Me.gbOpciones.TabStop = False
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnquitar.ForeColor = System.Drawing.Color.Navy
        Me.btnquitar.Image = CType(resources.GetObject("btnquitar.Image"), System.Drawing.Image)
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnquitar.Location = New System.Drawing.Point(5, 258)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(58, 42)
        Me.btnquitar.TabIndex = 20
        Me.btnquitar.Text = "&Quitar"
        Me.btnquitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAgregar.ForeColor = System.Drawing.Color.Navy
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(5, 165)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(58, 42)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.White
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.Location = New System.Drawing.Point(725, 591)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(89, 21)
        Me.txtPrecioVenta.TabIndex = 25
        Me.txtPrecioVenta.Text = "0.00"
        Me.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.GroupBox7)
        Me.gbDetalles.Controls.Add(Me.dgvDetalle)
        Me.gbDetalles.ForeColor = System.Drawing.Color.Navy
        Me.gbDetalles.Location = New System.Drawing.Point(6, 136)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(826, 450)
        Me.gbDetalles.TabIndex = 179
        Me.gbDetalles.TabStop = False
        Me.gbDetalles.Text = "Detalles"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.txt_precio_unit)
        Me.GroupBox7.Controls.Add(Me.txt_cantidad_cliente)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.txt_ruc_cliente)
        Me.GroupBox7.Controls.Add(Me.PictureBox1)
        Me.GroupBox7.Controls.Add(Me.txt_des_cliente)
        Me.GroupBox7.Controls.Add(Me.txt_cod_cliente)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.txt_saldo_registro)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.txt_num_lotes)
        Me.GroupBox7.Controls.Add(Me.txt_cantidad_articulo)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txt_pres_articulo)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.PictureBox2)
        Me.GroupBox7.Controls.Add(Me.txt_unidad_articulo)
        Me.GroupBox7.Controls.Add(Me.txt_des_articulo)
        Me.GroupBox7.Controls.Add(Me.txt_cod_articulo)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(8, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(810, 140)
        Me.GroupBox7.TabIndex = 199
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Detalles del Articulo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(235, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Precio Unit."
        '
        'txt_precio_unit
        '
        Me.txt_precio_unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_precio_unit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio_unit.Location = New System.Drawing.Point(300, 108)
        Me.txt_precio_unit.MaxLength = 15
        Me.txt_precio_unit.Name = "txt_precio_unit"
        Me.txt_precio_unit.Size = New System.Drawing.Size(114, 21)
        Me.txt_precio_unit.TabIndex = 128
        '
        'txt_cantidad_cliente
        '
        Me.txt_cantidad_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad_cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_cliente.Location = New System.Drawing.Point(72, 108)
        Me.txt_cantidad_cliente.MaxLength = 15
        Me.txt_cantidad_cliente.Name = "txt_cantidad_cliente"
        Me.txt_cantidad_cliente.Size = New System.Drawing.Size(114, 21)
        Me.txt_cantidad_cliente.TabIndex = 126
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(1, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Cant. Cliente"
        '
        'txt_ruc_cliente
        '
        Me.txt_ruc_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc_cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(553, 81)
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.ReadOnly = True
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(179, 21)
        Me.txt_ruc_cliente.TabIndex = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(147, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'txt_des_cliente
        '
        Me.txt_des_cliente.BackColor = System.Drawing.Color.White
        Me.txt_des_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_cliente.Enabled = False
        Me.txt_des_cliente.Location = New System.Drawing.Point(172, 81)
        Me.txt_des_cliente.Name = "txt_des_cliente"
        Me.txt_des_cliente.ReadOnly = True
        Me.txt_des_cliente.Size = New System.Drawing.Size(373, 20)
        Me.txt_des_cliente.TabIndex = 122
        '
        'txt_cod_cliente
        '
        Me.txt_cod_cliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_cliente.Location = New System.Drawing.Point(72, 81)
        Me.txt_cod_cliente.MaxLength = 10
        Me.txt_cod_cliente.Name = "txt_cod_cliente"
        Me.txt_cod_cliente.Size = New System.Drawing.Size(72, 21)
        Me.txt_cod_cliente.TabIndex = 121
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(29, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Cliente"
        '
        'txt_saldo_registro
        '
        Me.txt_saldo_registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_saldo_registro.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_saldo_registro.Location = New System.Drawing.Point(553, 54)
        Me.txt_saldo_registro.Name = "txt_saldo_registro"
        Me.txt_saldo_registro.ReadOnly = True
        Me.txt_saldo_registro.Size = New System.Drawing.Size(179, 21)
        Me.txt_saldo_registro.TabIndex = 119
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(454, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Saldo de Registro"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(235, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "N° de Lotes"
        '
        'txt_num_lotes
        '
        Me.txt_num_lotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_lotes.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_lotes.Location = New System.Drawing.Point(300, 54)
        Me.txt_num_lotes.Name = "txt_num_lotes"
        Me.txt_num_lotes.ReadOnly = True
        Me.txt_num_lotes.Size = New System.Drawing.Size(114, 21)
        Me.txt_num_lotes.TabIndex = 116
        '
        'txt_cantidad_articulo
        '
        Me.txt_cantidad_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad_articulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_articulo.Location = New System.Drawing.Point(72, 54)
        Me.txt_cantidad_articulo.MaxLength = 15
        Me.txt_cantidad_articulo.Name = "txt_cantidad_articulo"
        Me.txt_cantidad_articulo.Size = New System.Drawing.Size(114, 21)
        Me.txt_cantidad_articulo.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(9, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Cant. Total"
        '
        'txt_pres_articulo
        '
        Me.txt_pres_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pres_articulo.Enabled = False
        Me.txt_pres_articulo.Location = New System.Drawing.Point(626, 27)
        Me.txt_pres_articulo.Name = "txt_pres_articulo"
        Me.txt_pres_articulo.ReadOnly = True
        Me.txt_pres_articulo.Size = New System.Drawing.Size(179, 20)
        Me.txt_pres_articulo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(628, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Pres."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(147, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 112
        Me.PictureBox2.TabStop = False
        '
        'txt_unidad_articulo
        '
        Me.txt_unidad_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_unidad_articulo.Location = New System.Drawing.Point(553, 27)
        Me.txt_unidad_articulo.Name = "txt_unidad_articulo"
        Me.txt_unidad_articulo.ReadOnly = True
        Me.txt_unidad_articulo.Size = New System.Drawing.Size(67, 20)
        Me.txt_unidad_articulo.TabIndex = 2
        '
        'txt_des_articulo
        '
        Me.txt_des_articulo.BackColor = System.Drawing.Color.White
        Me.txt_des_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_articulo.Enabled = False
        Me.txt_des_articulo.Location = New System.Drawing.Point(172, 27)
        Me.txt_des_articulo.Name = "txt_des_articulo"
        Me.txt_des_articulo.ReadOnly = True
        Me.txt_des_articulo.Size = New System.Drawing.Size(373, 20)
        Me.txt_des_articulo.TabIndex = 1
        '
        'txt_cod_articulo
        '
        Me.txt_cod_articulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_articulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_articulo.Location = New System.Drawing.Point(72, 27)
        Me.txt_cod_articulo.MaxLength = 10
        Me.txt_cod_articulo.Name = "txt_cod_articulo"
        Me.txt_cod_articulo.Size = New System.Drawing.Size(72, 21)
        Me.txt_cod_articulo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(26, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Articulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(556, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unid. Med"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(8, 165)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(812, 280)
        Me.dgvDetalle.TabIndex = 0
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.dgvdetalle_reporte)
        Me.pnlCabecera.Controls.Add(Me.lblDetalle)
        Me.pnlCabecera.Controls.Add(Me.lblCantidad)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(9, 32)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(923, 665)
        Me.pnlCabecera.TabIndex = 198
        '
        'lblDetalle
        '
        Me.lblDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetalle.BackColor = System.Drawing.Color.White
        Me.lblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalle.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblDetalle.Location = New System.Drawing.Point(2, 18)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.ReadOnly = True
        Me.lblDetalle.Size = New System.Drawing.Size(908, 20)
        Me.lblDetalle.TabIndex = 198
        Me.lblDetalle.Text = "LISTADO DE  LICITACIONES"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(17, 636)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 124
        Me.lblCantidad.Text = "."
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(470, 52)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 123
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(183, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(250, 15)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(7, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 13)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Fecha inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(82, 15)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 45)
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
        Me.txtFiltro.Size = New System.Drawing.Size(245, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(276, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 45)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(176, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(13, 104)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.Size = New System.Drawing.Size(904, 526)
        Me.dgvCabecera.TabIndex = 2
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btnGrabar, Me.btnEliminar, Me.btnImprimir, Me.btnCancelar, Me.ToolStripButton7})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(941, 25)
        Me.btn_menu.TabIndex = 200
        Me.btn_menu.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Navy
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.Navy
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(120, 22)
        Me.btnConsultar.Text = "&Consultar/Editar"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ForeColor = System.Drawing.Color.Navy
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(73, 22)
        Me.btnGrabar.Text = "&Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 22)
        Me.btnEliminar.Text = "&Anular"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Navy
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton7.Text = "&Salir"
        '
        'pnl_detalle_num_entregas
        '
        Me.pnl_detalle_num_entregas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_detalle_num_entregas.Controls.Add(Me.gbBultos)
        Me.pnl_detalle_num_entregas.Location = New System.Drawing.Point(471, 186)
        Me.pnl_detalle_num_entregas.Name = "pnl_detalle_num_entregas"
        Me.pnl_detalle_num_entregas.Size = New System.Drawing.Size(366, 377)
        Me.pnl_detalle_num_entregas.TabIndex = 201
        Me.pnl_detalle_num_entregas.Visible = False
        '
        'gbBultos
        '
        Me.gbBultos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBultos.BackColor = System.Drawing.Color.White
        Me.gbBultos.Controls.Add(Me.btnreplicar)
        Me.gbBultos.Controls.Add(Me.dgvDetallesBulto)
        Me.gbBultos.Controls.Add(Me.txtCantidadAsiganda)
        Me.gbBultos.Controls.Add(Me.Label12)
        Me.gbBultos.Controls.Add(Me.btnAceptarBultos)
        Me.gbBultos.Controls.Add(Me.SalirBultos)
        Me.gbBultos.ForeColor = System.Drawing.Color.Navy
        Me.gbBultos.Location = New System.Drawing.Point(10, 10)
        Me.gbBultos.Name = "gbBultos"
        Me.gbBultos.Size = New System.Drawing.Size(345, 358)
        Me.gbBultos.TabIndex = 48
        Me.gbBultos.TabStop = False
        Me.gbBultos.Text = "Detalles de Entregas"
        '
        'btnreplicar
        '
        Me.btnreplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreplicar.ForeColor = System.Drawing.Color.Blue
        Me.btnreplicar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnreplicar.Location = New System.Drawing.Point(150, 304)
        Me.btnreplicar.Name = "btnreplicar"
        Me.btnreplicar.Size = New System.Drawing.Size(59, 38)
        Me.btnreplicar.TabIndex = 107
        Me.btnreplicar.Text = "Replicar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cantidad"
        Me.btnreplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreplicar.UseVisualStyleBackColor = True
        '
        'dgvDetallesBulto
        '
        Me.dgvDetallesBulto.AllowUserToAddRows = False
        Me.dgvDetallesBulto.AllowUserToDeleteRows = False
        Me.dgvDetallesBulto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallesBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.dgvDetallesBulto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvDetallesBulto.Location = New System.Drawing.Point(6, 20)
        Me.dgvDetallesBulto.Name = "dgvDetallesBulto"
        Me.dgvDetallesBulto.Size = New System.Drawing.Size(332, 247)
        Me.dgvDetallesBulto.TabIndex = 106
        '
        'Column4
        '
        Me.Column4.HeaderText = "Item"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cantidad"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column6.HeaderText = "Cantidad_Asignada"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'txtCantidadAsiganda
        '
        Me.txtCantidadAsiganda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadAsiganda.Location = New System.Drawing.Point(268, 279)
        Me.txtCantidadAsiganda.Name = "txtCantidadAsiganda"
        Me.txtCantidadAsiganda.ReadOnly = True
        Me.txtCantidadAsiganda.Size = New System.Drawing.Size(70, 20)
        Me.txtCantidadAsiganda.TabIndex = 105
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(186, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Cantidad Total"
        '
        'btnAceptarBultos
        '
        Me.btnAceptarBultos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarBultos.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptarBultos.Image = CType(resources.GetObject("btnAceptarBultos.Image"), System.Drawing.Image)
        Me.btnAceptarBultos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptarBultos.Location = New System.Drawing.Point(215, 304)
        Me.btnAceptarBultos.Name = "btnAceptarBultos"
        Me.btnAceptarBultos.Size = New System.Drawing.Size(59, 38)
        Me.btnAceptarBultos.TabIndex = 8
        Me.btnAceptarBultos.Text = "Aceptar"
        Me.btnAceptarBultos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptarBultos.UseVisualStyleBackColor = True
        '
        'SalirBultos
        '
        Me.SalirBultos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalirBultos.ForeColor = System.Drawing.Color.Blue
        Me.SalirBultos.Image = CType(resources.GetObject("SalirBultos.Image"), System.Drawing.Image)
        Me.SalirBultos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SalirBultos.Location = New System.Drawing.Point(279, 304)
        Me.SalirBultos.Name = "SalirBultos"
        Me.SalirBultos.Size = New System.Drawing.Size(59, 38)
        Me.SalirBultos.TabIndex = 1
        Me.SalirBultos.Text = "Cancelar"
        Me.SalirBultos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalirBultos.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.ForeColor = System.Drawing.Color.Navy
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(113, 22)
        Me.btnImprimir.Text = "Hoja de Calculo"
        '
        'dgvdetalle_reporte
        '
        Me.dgvdetalle_reporte.AllowUserToAddRows = False
        Me.dgvdetalle_reporte.AllowUserToDeleteRows = False
        Me.dgvdetalle_reporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdetalle_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalle_reporte.Location = New System.Drawing.Point(12, 671)
        Me.dgvdetalle_reporte.Name = "dgvdetalle_reporte"
        Me.dgvdetalle_reporte.ReadOnly = True
        Me.dgvdetalle_reporte.Size = New System.Drawing.Size(904, 29)
        Me.dgvdetalle_reporte.TabIndex = 199
        Me.dgvdetalle_reporte.Visible = False
        '
        'Frm_Registro_Licitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(941, 710)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.pnl_detalle_num_entregas)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.Tc_principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Registro_Licitaciones"
        Me.Text = "Registro de Licitaciones"
        Me.Tc_principal.ResumeLayout(False)
        Me.tc_datos.ResumeLayout(False)
        Me.tc_datos.PerformLayout()
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbDetalles.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_menu.ResumeLayout(False)
        Me.btn_menu.PerformLayout()
        Me.pnl_detalle_num_entregas.ResumeLayout(False)
        Me.gbBultos.ResumeLayout(False)
        Me.gbBultos.PerformLayout()
        CType(Me.dgvDetallesBulto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdetalle_reporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tc_principal As System.Windows.Forms.TabControl
    Friend WithEvents tc_datos As System.Windows.Forms.TabPage
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_num_entregas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_num_licitacion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBruto As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtvalorVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtDescuentos As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents lblDetalle As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pres_articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_unidad_articulo As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_num_lotes As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad_articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_ruc_cliente As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_des_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_saldo_registro As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pnl_detalle_num_entregas As System.Windows.Forms.Panel
    Friend WithEvents gbBultos As System.Windows.Forms.GroupBox
    Friend WithEvents btnreplicar As System.Windows.Forms.Button
    Friend WithEvents dgvDetallesBulto As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCantidadAsiganda As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAceptarBultos As System.Windows.Forms.Button
    Friend WithEvents SalirBultos As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_unit As System.Windows.Forms.TextBox
    Private WithEvents txt_cod_articulo As System.Windows.Forms.TextBox
    Friend WithEvents chkSinIGV As System.Windows.Forms.CheckBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvdetalle_reporte As System.Windows.Forms.DataGridView
End Class
