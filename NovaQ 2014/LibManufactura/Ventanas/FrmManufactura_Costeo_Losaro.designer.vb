<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManufactura_Costeo_Losaro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManufactura_Costeo_Losaro))
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lblDetalle = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.txt_cantidad_total = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_costo_total = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.gbcabecera = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_porcentaje = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_lote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_glosa = New System.Windows.Forms.TextBox()
        Me.txt_des_articulo = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_articulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkFormula = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_reprocesar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnimprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gbOpciones_pt = New System.Windows.Forms.GroupBox()
        Me.btnModificar_pt = New System.Windows.Forms.Button()
        Me.btnquitar_pt = New System.Windows.Forms.Button()
        Me.btnAgregar_pt = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDetalles_pt = New System.Windows.Forms.DataGridView()
        Me.pnlCabecera.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcabecera.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.gbOpciones_pt.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDetalles_pt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCabecera.Controls.Add(Me.GroupBox3)
        Me.pnlCabecera.Controls.Add(Me.lblDetalle)
        Me.pnlCabecera.Controls.Add(Me.GroupBox4)
        Me.pnlCabecera.Controls.Add(Me.gbRangofechas)
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(9, 33)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1177, 566)
        Me.pnlCabecera.TabIndex = 202
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(19, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 45)
        Me.GroupBox3.TabIndex = 200
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
        'lblDetalle
        '
        Me.lblDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetalle.BackColor = System.Drawing.Color.White
        Me.lblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalle.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblDetalle.Location = New System.Drawing.Point(5, 19)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.ReadOnly = True
        Me.lblDetalle.Size = New System.Drawing.Size(1166, 20)
        Me.lblDetalle.TabIndex = 199
        Me.lblDetalle.Text = "LISTADO DE PROCESO DE COSTEO"
        Me.lblDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(287, 51)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(183, 45)
        Me.GroupBox4.TabIndex = 124
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(170, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(483, 51)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 125
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(185, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(258, 13)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(7, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 13)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Fecha inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(85, 15)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(19, 99)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(1144, 459)
        Me.dgvCabecera.TabIndex = 2
        '
        'gbDetalles
        '
        Me.gbDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDetalles.Controls.Add(Me.txt_cantidad_total)
        Me.gbDetalles.Controls.Add(Me.Label1)
        Me.gbDetalles.Controls.Add(Me.txt_costo_total)
        Me.gbDetalles.Controls.Add(Me.Label28)
        Me.gbDetalles.Controls.Add(Me.Label2)
        Me.gbDetalles.Controls.Add(Me.dgvDetalles)
        Me.gbDetalles.Location = New System.Drawing.Point(30, 151)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(1078, 216)
        Me.gbDetalles.TabIndex = 205
        Me.gbDetalles.TabStop = False
        '
        'txt_cantidad_total
        '
        Me.txt_cantidad_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cantidad_total.BackColor = System.Drawing.Color.White
        Me.txt_cantidad_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad_total.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_total.Location = New System.Drawing.Point(796, 191)
        Me.txt_cantidad_total.Name = "txt_cantidad_total"
        Me.txt_cantidad_total.ReadOnly = True
        Me.txt_cantidad_total.Size = New System.Drawing.Size(89, 18)
        Me.txt_cantidad_total.TabIndex = 141
        Me.txt_cantidad_total.Text = "0.00"
        Me.txt_cantidad_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(712, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 11)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Cantidad Total"
        '
        'txt_costo_total
        '
        Me.txt_costo_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_costo_total.BackColor = System.Drawing.Color.White
        Me.txt_costo_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costo_total.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_costo_total.Location = New System.Drawing.Point(977, 191)
        Me.txt_costo_total.Name = "txt_costo_total"
        Me.txt_costo_total.ReadOnly = True
        Me.txt_costo_total.Size = New System.Drawing.Size(89, 18)
        Me.txt_costo_total.TabIndex = 139
        Me.txt_costo_total.Text = "0.00"
        Me.txt_costo_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(902, 195)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 11)
        Me.Label28.TabIndex = 138
        Me.Label28.Text = "Costo Total"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-1, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1078, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INSUMOS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(10, 31)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles.Size = New System.Drawing.Size(1056, 153)
        Me.dgvDetalles.TabIndex = 0
        '
        'gbcabecera
        '
        Me.gbcabecera.Controls.Add(Me.Label7)
        Me.gbcabecera.Controls.Add(Me.txt_porcentaje)
        Me.gbcabecera.Controls.Add(Me.Label6)
        Me.gbcabecera.Controls.Add(Me.txt_lote)
        Me.gbcabecera.Controls.Add(Me.Label5)
        Me.gbcabecera.Controls.Add(Me.txt_glosa)
        Me.gbcabecera.Controls.Add(Me.txt_des_articulo)
        Me.gbcabecera.Controls.Add(Me.PictureBox10)
        Me.gbcabecera.Controls.Add(Me.txt_cod_articulo)
        Me.gbcabecera.Controls.Add(Me.Label3)
        Me.gbcabecera.Controls.Add(Me.Label11)
        Me.gbcabecera.Controls.Add(Me.cboMoneda)
        Me.gbcabecera.Controls.Add(Me.Label12)
        Me.gbcabecera.Controls.Add(Me.dtp_fecha)
        Me.gbcabecera.Controls.Add(Me.Label13)
        Me.gbcabecera.Controls.Add(Me.txtcodigo)
        Me.gbcabecera.Controls.Add(Me.Label14)
        Me.gbcabecera.Controls.Add(Me.chkFormula)
        Me.gbcabecera.Location = New System.Drawing.Point(30, 38)
        Me.gbcabecera.Name = "gbcabecera"
        Me.gbcabecera.Size = New System.Drawing.Size(1077, 112)
        Me.gbcabecera.TabIndex = 204
        Me.gbcabecera.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(666, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "% a costear"
        Me.Label7.Visible = False
        '
        'txt_porcentaje
        '
        Me.txt_porcentaje.Location = New System.Drawing.Point(734, 87)
        Me.txt_porcentaje.Name = "txt_porcentaje"
        Me.txt_porcentaje.Size = New System.Drawing.Size(137, 20)
        Me.txt_porcentaje.TabIndex = 201
        Me.txt_porcentaje.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(685, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 200
        Me.Label6.Text = "N° Lote"
        '
        'txt_lote
        '
        Me.txt_lote.Location = New System.Drawing.Point(734, 66)
        Me.txt_lote.Name = "txt_lote"
        Me.txt_lote.Size = New System.Drawing.Size(137, 20)
        Me.txt_lote.TabIndex = 199
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(38, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Glosa"
        '
        'txt_glosa
        '
        Me.txt_glosa.Location = New System.Drawing.Point(78, 66)
        Me.txt_glosa.Multiline = True
        Me.txt_glosa.Name = "txt_glosa"
        Me.txt_glosa.Size = New System.Drawing.Size(500, 36)
        Me.txt_glosa.TabIndex = 197
        '
        'txt_des_articulo
        '
        Me.txt_des_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_articulo.ForeColor = System.Drawing.Color.Black
        Me.txt_des_articulo.Location = New System.Drawing.Point(201, 40)
        Me.txt_des_articulo.Name = "txt_des_articulo"
        Me.txt_des_articulo.ReadOnly = True
        Me.txt_des_articulo.Size = New System.Drawing.Size(670, 20)
        Me.txt_des_articulo.TabIndex = 196
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(175, 41)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox10.TabIndex = 195
        Me.PictureBox10.TabStop = False
        '
        'txt_cod_articulo
        '
        Me.txt_cod_articulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_articulo.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_articulo.Location = New System.Drawing.Point(78, 40)
        Me.txt_cod_articulo.Name = "txt_cod_articulo"
        Me.txt_cod_articulo.ReadOnly = True
        Me.txt_cod_articulo.Size = New System.Drawing.Size(90, 20)
        Me.txt_cod_articulo.TabIndex = 193
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(28, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Formula"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(230, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Almacen"
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Moneda"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(241, 14)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(102, 20)
        Me.dtp_fecha.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(198, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Fecha"
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(78, 14)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(90, 20)
        Me.txtcodigo.TabIndex = 1
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(51, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "N°"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnConsultar, Me.btn_eliminar, Me.btn_reprocesar, Me.btnGrabar, Me.btnimprimir, Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1196, 25)
        Me.ToolStrip1.TabIndex = 207
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
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "Eliminar"
        '
        'btn_reprocesar
        '
        Me.btn_reprocesar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reprocesar.Image = CType(resources.GetObject("btn_reprocesar.Image"), System.Drawing.Image)
        Me.btn_reprocesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_reprocesar.Name = "btn_reprocesar"
        Me.btn_reprocesar.Size = New System.Drawing.Size(86, 22)
        Me.btn_reprocesar.Text = "Re-Costeo"
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
        'btnimprimir
        '
        Me.btnimprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
        Me.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(77, 22)
        Me.btnimprimir.Text = "&Imprimir"
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
        'gbOpciones
        '
        Me.gbOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones.BackColor = System.Drawing.Color.White
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnquitar)
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.ForeColor = System.Drawing.Color.Navy
        Me.gbOpciones.Location = New System.Drawing.Point(1114, 151)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(72, 216)
        Me.gbOpciones.TabIndex = 208
        Me.gbOpciones.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(6, 89)
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
        Me.btnquitar.Location = New System.Drawing.Point(6, 147)
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
        Me.btnAgregar.Location = New System.Drawing.Point(6, 32)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(60, 53)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'gbOpciones_pt
        '
        Me.gbOpciones_pt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbOpciones_pt.BackColor = System.Drawing.Color.White
        Me.gbOpciones_pt.Controls.Add(Me.btnModificar_pt)
        Me.gbOpciones_pt.Controls.Add(Me.btnquitar_pt)
        Me.gbOpciones_pt.Controls.Add(Me.btnAgregar_pt)
        Me.gbOpciones_pt.ForeColor = System.Drawing.Color.Navy
        Me.gbOpciones_pt.Location = New System.Drawing.Point(1114, 371)
        Me.gbOpciones_pt.Name = "gbOpciones_pt"
        Me.gbOpciones_pt.Size = New System.Drawing.Size(72, 216)
        Me.gbOpciones_pt.TabIndex = 210
        Me.gbOpciones_pt.TabStop = False
        '
        'btnModificar_pt
        '
        Me.btnModificar_pt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar_pt.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnModificar_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar_pt.Image = CType(resources.GetObject("btnModificar_pt.Image"), System.Drawing.Image)
        Me.btnModificar_pt.Location = New System.Drawing.Point(6, 90)
        Me.btnModificar_pt.Name = "btnModificar_pt"
        Me.btnModificar_pt.Size = New System.Drawing.Size(60, 53)
        Me.btnModificar_pt.TabIndex = 16
        Me.btnModificar_pt.Text = "&Modificar"
        Me.btnModificar_pt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar_pt.UseVisualStyleBackColor = True
        '
        'btnquitar_pt
        '
        Me.btnquitar_pt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnquitar_pt.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnquitar_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar_pt.Image = CType(resources.GetObject("btnquitar_pt.Image"), System.Drawing.Image)
        Me.btnquitar_pt.Location = New System.Drawing.Point(6, 149)
        Me.btnquitar_pt.Name = "btnquitar_pt"
        Me.btnquitar_pt.Size = New System.Drawing.Size(60, 53)
        Me.btnquitar_pt.TabIndex = 15
        Me.btnquitar_pt.Text = "&Quitar"
        Me.btnquitar_pt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnquitar_pt.UseVisualStyleBackColor = True
        '
        'btnAgregar_pt
        '
        Me.btnAgregar_pt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar_pt.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAgregar_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar_pt.Image = CType(resources.GetObject("btnAgregar_pt.Image"), System.Drawing.Image)
        Me.btnAgregar_pt.Location = New System.Drawing.Point(6, 32)
        Me.btnAgregar_pt.Name = "btnAgregar_pt"
        Me.btnAgregar_pt.Size = New System.Drawing.Size(60, 53)
        Me.btnAgregar_pt.TabIndex = 14
        Me.btnAgregar_pt.Text = "&Agregar"
        Me.btnAgregar_pt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar_pt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dgvDetalles_pt)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 371)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1078, 216)
        Me.GroupBox2.TabIndex = 209
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1078, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PRODUCTOS TERMINADOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDetalles_pt
        '
        Me.dgvDetalles_pt.AllowUserToAddRows = False
        Me.dgvDetalles_pt.AllowUserToDeleteRows = False
        Me.dgvDetalles_pt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles_pt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles_pt.Location = New System.Drawing.Point(10, 46)
        Me.dgvDetalles_pt.Name = "dgvDetalles_pt"
        Me.dgvDetalles_pt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles_pt.Size = New System.Drawing.Size(1056, 158)
        Me.dgvDetalles_pt.TabIndex = 0
        '
        'FrmManufactura_Costeo_Losaro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1196, 601)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.gbOpciones_pt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbcabecera)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmManufactura_Costeo_Losaro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proceso de Costeo"
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalles.ResumeLayout(False)
        Me.gbDetalles.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcabecera.ResumeLayout(False)
        Me.gbcabecera.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones_pt.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDetalles_pt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents gbcabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkFormula As System.Windows.Forms.CheckBox
    Friend WithEvents txt_des_articulo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnimprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents gbOpciones_pt As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar_pt As System.Windows.Forms.Button
    Friend WithEvents btnquitar_pt As System.Windows.Forms.Button
    Friend WithEvents btnAgregar_pt As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalles_pt As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDetalle As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents txt_costo_total As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_total As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_reprocesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_glosa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_lote As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_porcentaje As System.Windows.Forms.TextBox
End Class
