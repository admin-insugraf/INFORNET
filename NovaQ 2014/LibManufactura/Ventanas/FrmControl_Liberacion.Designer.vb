<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControl_Liberacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControl_Liberacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbCabceraDocumento = New System.Windows.Forms.GroupBox()
        Me.GbTransaccion = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cboTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.chkValorizado = New System.Windows.Forms.CheckBox()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.pnl_guia_analisis = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_guia = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_nro_guia = New System.Windows.Forms.TextBox()
        Me.txt_tipo_guia = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboAlmacen = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha_ref = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_Tipo_Ref = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Numero_Ref = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.cbocentroCosto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtordenCompra = New System.Windows.Forms.TextBox()
        Me.lbltercero = New System.Windows.Forms.Label()
        Me.lblproveedor = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtorderFabricacion = New System.Windows.Forms.TextBox()
        Me.txtNumeroReferencia = New System.Windows.Forms.TextBox()
        Me.txtcodigoTercero = New System.Windows.Forms.TextBox()
        Me.txtTipoDocumentoRef = New System.Windows.Forms.TextBox()
        Me.txtcodigoProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GbdetalleDocumento = New System.Windows.Forms.GroupBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fec_Vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Procedencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pais_Origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valoracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuiaAnalisis = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.pnlfiltros = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboEstados = New System.Windows.Forms.ComboBox()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgvCabeceraAlmacen = New System.Windows.Forms.DataGridView()
        Me.pnlFecha = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.gbCabceraDocumento.SuspendLayout()
        Me.GbTransaccion.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GbCabecera.SuspendLayout()
        Me.pnl_guia_analisis.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GbdetalleDocumento.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlfiltros.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFecha.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCabceraDocumento
        '
        Me.gbCabceraDocumento.Controls.Add(Me.GbTransaccion)
        Me.gbCabceraDocumento.Controls.Add(Me.GbCabecera)
        Me.gbCabceraDocumento.Controls.Add(Me.GbdetalleDocumento)
        Me.gbCabceraDocumento.Location = New System.Drawing.Point(12, 92)
        Me.gbCabceraDocumento.Name = "gbCabceraDocumento"
        Me.gbCabceraDocumento.Size = New System.Drawing.Size(1014, 483)
        Me.gbCabceraDocumento.TabIndex = 41
        Me.gbCabceraDocumento.TabStop = False
        '
        'GbTransaccion
        '
        Me.GbTransaccion.Controls.Add(Me.GroupBox5)
        Me.GbTransaccion.Controls.Add(Me.chkValorizado)
        Me.GbTransaccion.Location = New System.Drawing.Point(21, 7)
        Me.GbTransaccion.Name = "GbTransaccion"
        Me.GbTransaccion.Size = New System.Drawing.Size(969, 63)
        Me.GbTransaccion.TabIndex = 36
        Me.GbTransaccion.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cboTipoMovimiento)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(139, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(390, 49)
        Me.GroupBox5.TabIndex = 111
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TRANSACCIONES"
        '
        'cboTipoMovimiento
        '
        Me.cboTipoMovimiento.DisplayMember = "Nombre"
        Me.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMovimiento.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cboTipoMovimiento.FormattingEnabled = True
        Me.cboTipoMovimiento.Location = New System.Drawing.Point(6, 17)
        Me.cboTipoMovimiento.Name = "cboTipoMovimiento"
        Me.cboTipoMovimiento.Size = New System.Drawing.Size(378, 24)
        Me.cboTipoMovimiento.TabIndex = 2
        Me.cboTipoMovimiento.ValueMember = "Codigo"
        '
        'chkValorizado
        '
        Me.chkValorizado.AutoSize = True
        Me.chkValorizado.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkValorizado.ForeColor = System.Drawing.Color.Navy
        Me.chkValorizado.Location = New System.Drawing.Point(865, 33)
        Me.chkValorizado.Name = "chkValorizado"
        Me.chkValorizado.Size = New System.Drawing.Size(92, 21)
        Me.chkValorizado.TabIndex = 3
        Me.chkValorizado.Text = "Valorizado"
        Me.chkValorizado.UseVisualStyleBackColor = True
        Me.chkValorizado.Visible = False
        '
        'GbCabecera
        '
        Me.GbCabecera.Controls.Add(Me.pnl_guia_analisis)
        Me.GbCabecera.Controls.Add(Me.Label27)
        Me.GbCabecera.Controls.Add(Me.GroupBox2)
        Me.GbCabecera.Controls.Add(Me.cboMoneda)
        Me.GbCabecera.Controls.Add(Me.Label11)
        Me.GbCabecera.Controls.Add(Me.txtComentarios)
        Me.GbCabecera.Controls.Add(Me.cbocentroCosto)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.Label2)
        Me.GbCabecera.Controls.Add(Me.Label14)
        Me.GbCabecera.Controls.Add(Me.txtordenCompra)
        Me.GbCabecera.Controls.Add(Me.lbltercero)
        Me.GbCabecera.Controls.Add(Me.lblproveedor)
        Me.GbCabecera.Controls.Add(Me.Label8)
        Me.GbCabecera.Controls.Add(Me.txtorderFabricacion)
        Me.GbCabecera.Controls.Add(Me.txtNumeroReferencia)
        Me.GbCabecera.Controls.Add(Me.txtcodigoTercero)
        Me.GbCabecera.Controls.Add(Me.txtTipoDocumentoRef)
        Me.GbCabecera.Controls.Add(Me.txtcodigoProveedor)
        Me.GbCabecera.Controls.Add(Me.Label7)
        Me.GbCabecera.Controls.Add(Me.Label9)
        Me.GbCabecera.Controls.Add(Me.Label10)
        Me.GbCabecera.Enabled = False
        Me.GbCabecera.ForeColor = System.Drawing.Color.Black
        Me.GbCabecera.Location = New System.Drawing.Point(21, 71)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(969, 175)
        Me.GbCabecera.TabIndex = 37
        Me.GbCabecera.TabStop = False
        '
        'pnl_guia_analisis
        '
        Me.pnl_guia_analisis.Controls.Add(Me.Label18)
        Me.pnl_guia_analisis.Controls.Add(Me.GroupBox3)
        Me.pnl_guia_analisis.Location = New System.Drawing.Point(595, 78)
        Me.pnl_guia_analisis.Name = "pnl_guia_analisis"
        Me.pnl_guia_analisis.Size = New System.Drawing.Size(367, 50)
        Me.pnl_guia_analisis.TabIndex = 130
        Me.pnl_guia_analisis.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(221, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "Fecha "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtp_fecha_guia)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_nro_guia)
        Me.GroupBox3.Controls.Add(Me.txt_tipo_guia)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 46)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Guia de Analisis"
        '
        'dtp_fecha_guia
        '
        Me.dtp_fecha_guia.BackColor = System.Drawing.Color.Aquamarine
        Me.dtp_fecha_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtp_fecha_guia.Location = New System.Drawing.Point(267, 17)
        Me.dtp_fecha_guia.Mask = " 00/00/0000"
        Me.dtp_fecha_guia.Name = "dtp_fecha_guia"
        Me.dtp_fecha_guia.ReadOnly = True
        Me.dtp_fecha_guia.Size = New System.Drawing.Size(88, 21)
        Me.dtp_fecha_guia.TabIndex = 132
        Me.dtp_fecha_guia.ValidatingType = GetType(Date)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(79, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "Numero"
        '
        'txt_nro_guia
        '
        Me.txt_nro_guia.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_nro_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_guia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nro_guia.ForeColor = System.Drawing.Color.Red
        Me.txt_nro_guia.Location = New System.Drawing.Point(135, 19)
        Me.txt_nro_guia.Name = "txt_nro_guia"
        Me.txt_nro_guia.ReadOnly = True
        Me.txt_nro_guia.Size = New System.Drawing.Size(80, 21)
        Me.txt_nro_guia.TabIndex = 129
        Me.txt_nro_guia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_tipo_guia
        '
        Me.txt_tipo_guia.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_tipo_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipo_guia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipo_guia.ForeColor = System.Drawing.Color.Red
        Me.txt_tipo_guia.Location = New System.Drawing.Point(46, 19)
        Me.txt_tipo_guia.Name = "txt_tipo_guia"
        Me.txt_tipo_guia.ReadOnly = True
        Me.txt_tipo_guia.Size = New System.Drawing.Size(28, 21)
        Me.txt_tipo_guia.TabIndex = 128
        Me.txt_tipo_guia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(9, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 130
        Me.Label13.Text = "Tipo."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(13, 152)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(243, 13)
        Me.Label27.TabIndex = 122
        Me.Label27.Text = "Datos Adicionales / Observaciones / Comentarios"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboAlmacen)
        Me.GroupBox2.Controls.Add(Me.dtp_fecha_ref)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_Tipo_Ref)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_Numero_Ref)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 64)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        '
        'CboAlmacen
        '
        Me.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAlmacen.FormattingEnabled = True
        Me.CboAlmacen.Location = New System.Drawing.Point(68, 11)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(374, 21)
        Me.CboAlmacen.TabIndex = 3
        '
        'dtp_fecha_ref
        '
        Me.dtp_fecha_ref.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtp_fecha_ref.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_ref.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_ref.Location = New System.Drawing.Point(341, 37)
        Me.dtp_fecha_ref.Name = "dtp_fecha_ref"
        Me.dtp_fecha_ref.Size = New System.Drawing.Size(101, 21)
        Me.dtp_fecha_ref.TabIndex = 118
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(14, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Almacen "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(121, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 127
        Me.Label17.Text = "Numero"
        '
        'txt_Tipo_Ref
        '
        Me.txt_Tipo_Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Tipo_Ref.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tipo_Ref.Location = New System.Drawing.Point(67, 37)
        Me.txt_Tipo_Ref.Name = "txt_Tipo_Ref"
        Me.txt_Tipo_Ref.Size = New System.Drawing.Size(46, 21)
        Me.txt_Tipo_Ref.TabIndex = 113
        Me.txt_Tipo_Ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(295, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Fecha "
        '
        'txt_Numero_Ref
        '
        Me.txt_Numero_Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Numero_Ref.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Numero_Ref.Location = New System.Drawing.Point(176, 37)
        Me.txt_Numero_Ref.Name = "txt_Numero_Ref"
        Me.txt_Numero_Ref.Size = New System.Drawing.Size(113, 21)
        Me.txt_Numero_Ref.TabIndex = 114
        Me.txt_Numero_Ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(34, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 126
        Me.Label16.Text = "Tipo."
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(595, 19)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(159, 21)
        Me.cboMoneda.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(545, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Moneda"
        '
        'txtComentarios
        '
        Me.txtComentarios.BackColor = System.Drawing.Color.White
        Me.txtComentarios.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarios.Location = New System.Drawing.Point(260, 149)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarios.Size = New System.Drawing.Size(658, 20)
        Me.txtComentarios.TabIndex = 12
        Me.txtComentarios.Text = ""
        '
        'cbocentroCosto
        '
        Me.cbocentroCosto.Enabled = False
        Me.cbocentroCosto.FormattingEnabled = True
        Me.cbocentroCosto.Location = New System.Drawing.Point(834, 21)
        Me.cbocentroCosto.Name = "cbocentroCosto"
        Me.cbocentroCosto.Size = New System.Drawing.Size(129, 21)
        Me.cbocentroCosto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(58, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(41, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Proveedor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(501, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Orden de Compra"
        '
        'txtordenCompra
        '
        Me.txtordenCompra.BackColor = System.Drawing.Color.White
        Me.txtordenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtordenCompra.Location = New System.Drawing.Point(595, 46)
        Me.txtordenCompra.Name = "txtordenCompra"
        Me.txtordenCompra.Size = New System.Drawing.Size(112, 20)
        Me.txtordenCompra.TabIndex = 8
        Me.txtordenCompra.Tag = "Orden de Compra"
        Me.txtordenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltercero
        '
        Me.lbltercero.AutoSize = True
        Me.lbltercero.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbltercero.ForeColor = System.Drawing.Color.Navy
        Me.lbltercero.Location = New System.Drawing.Point(193, 126)
        Me.lbltercero.Name = "lbltercero"
        Me.lbltercero.Size = New System.Drawing.Size(17, 18)
        Me.lbltercero.TabIndex = 43
        Me.lbltercero.Text = "..."
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblproveedor.ForeColor = System.Drawing.Color.Navy
        Me.lblproveedor.Location = New System.Drawing.Point(192, 103)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(17, 18)
        Me.lblproveedor.TabIndex = 36
        Me.lblproveedor.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(713, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Orden Fabricacion"
        '
        'txtorderFabricacion
        '
        Me.txtorderFabricacion.BackColor = System.Drawing.Color.White
        Me.txtorderFabricacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtorderFabricacion.Location = New System.Drawing.Point(810, 46)
        Me.txtorderFabricacion.Name = "txtorderFabricacion"
        Me.txtorderFabricacion.Size = New System.Drawing.Size(152, 20)
        Me.txtorderFabricacion.TabIndex = 9
        Me.txtorderFabricacion.Tag = "Orden de Fabricacion"
        Me.txtorderFabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeroReferencia
        '
        Me.txtNumeroReferencia.BackColor = System.Drawing.Color.White
        Me.txtNumeroReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroReferencia.Location = New System.Drawing.Point(231, 77)
        Me.txtNumeroReferencia.Name = "txtNumeroReferencia"
        Me.txtNumeroReferencia.Size = New System.Drawing.Size(92, 20)
        Me.txtNumeroReferencia.TabIndex = 7
        Me.txtNumeroReferencia.Tag = "Numero documento Referencia"
        Me.txtNumeroReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoTercero
        '
        Me.txtcodigoTercero.BackColor = System.Drawing.Color.White
        Me.txtcodigoTercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoTercero.Location = New System.Drawing.Point(101, 124)
        Me.txtcodigoTercero.Name = "txtcodigoTercero"
        Me.txtcodigoTercero.ReadOnly = True
        Me.txtcodigoTercero.Size = New System.Drawing.Size(88, 20)
        Me.txtcodigoTercero.TabIndex = 11
        Me.txtcodigoTercero.Tag = "Cliente"
        Me.txtcodigoTercero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTipoDocumentoRef
        '
        Me.txtTipoDocumentoRef.BackColor = System.Drawing.Color.White
        Me.txtTipoDocumentoRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoDocumentoRef.Location = New System.Drawing.Point(101, 77)
        Me.txtTipoDocumentoRef.Name = "txtTipoDocumentoRef"
        Me.txtTipoDocumentoRef.ReadOnly = True
        Me.txtTipoDocumentoRef.Size = New System.Drawing.Size(46, 20)
        Me.txtTipoDocumentoRef.TabIndex = 6
        Me.txtTipoDocumentoRef.Tag = "Tipo documento Referencia"
        Me.txtTipoDocumentoRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoProveedor
        '
        Me.txtcodigoProveedor.BackColor = System.Drawing.Color.White
        Me.txtcodigoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoProveedor.Location = New System.Drawing.Point(101, 101)
        Me.txtcodigoProveedor.Name = "txtcodigoProveedor"
        Me.txtcodigoProveedor.ReadOnly = True
        Me.txtcodigoProveedor.Size = New System.Drawing.Size(87, 20)
        Me.txtcodigoProveedor.TabIndex = 10
        Me.txtcodigoProveedor.Tag = "Proveedor"
        Me.txtcodigoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(762, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Centro Costo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(29, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Tip Doc Ref."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(154, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Num.Doc.Ref"
        '
        'GbdetalleDocumento
        '
        Me.GbdetalleDocumento.Controls.Add(Me.gbOpciones)
        Me.GbdetalleDocumento.Controls.Add(Me.dgvDetalle)
        Me.GbdetalleDocumento.Location = New System.Drawing.Point(19, 245)
        Me.GbdetalleDocumento.Name = "GbdetalleDocumento"
        Me.GbdetalleDocumento.Size = New System.Drawing.Size(985, 231)
        Me.GbdetalleDocumento.TabIndex = 38
        Me.GbdetalleDocumento.TabStop = False
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnAgregar)
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnQuitar)
        Me.gbOpciones.Location = New System.Drawing.Point(912, 10)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(64, 216)
        Me.gbOpciones.TabIndex = 39
        Me.gbOpciones.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(7, 21)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(51, 49)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(7, 86)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(51, 49)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "Editar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.Image = CType(resources.GetObject("btnQuitar.Image"), System.Drawing.Image)
        Me.btnQuitar.Location = New System.Drawing.Point(7, 153)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(51, 49)
        Me.btnQuitar.TabIndex = 17
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.DataGridViewTextBoxColumn1, Me.Fec_Vencimiento, Me.Procedencia, Me.Pais_Origen, Me.Valoracion, Me.Column1})
        Me.dgvDetalle.Location = New System.Drawing.Point(4, 17)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(904, 204)
        Me.dgvDetalle.TabIndex = 41
        Me.dgvDetalle.Visible = False
        '
        'Column7
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column7.HeaderText = "Item"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 40
        '
        'Column8
        '
        Me.Column8.HeaderText = "Codigo"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 60
        '
        'Column9
        '
        Me.Column9.HeaderText = "Descripcion"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 200
        '
        'Column10
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column10.HeaderText = "Unidad"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 45
        '
        'Column11
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column11.HeaderText = "Numero_Analisis"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Format = "N4"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column12.HeaderText = "Cantidad "
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 80
        '
        'Column13
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column13.HeaderText = "Bultos"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 60
        '
        'Column14
        '
        Me.Column14.HeaderText = "Entrega"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 60
        '
        'Column15
        '
        Me.Column15.HeaderText = "Num_Protocolo"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'Fec_Vencimiento
        '
        Me.Fec_Vencimiento.HeaderText = "Fec_Vencimiento"
        Me.Fec_Vencimiento.Name = "Fec_Vencimiento"
        '
        'Procedencia
        '
        Me.Procedencia.HeaderText = "Procedencia"
        Me.Procedencia.Name = "Procedencia"
        '
        'Pais_Origen
        '
        Me.Pais_Origen.HeaderText = "Pais_Origen"
        Me.Pais_Origen.Name = "Pais_Origen"
        '
        'Valoracion
        '
        Me.Valoracion.HeaderText = "Valoración"
        Me.Valoracion.Name = "Valoracion"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Observaciones"
        Me.Column1.Name = "Column1"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFecha.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(7, 21)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(103, 24)
        Me.dtpFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha Liberacion"
        '
        'btnGuiaAnalisis
        '
        Me.btnGuiaAnalisis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuiaAnalisis.FlatAppearance.BorderSize = 0
        Me.btnGuiaAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuiaAnalisis.ForeColor = System.Drawing.Color.Black
        Me.btnGuiaAnalisis.Image = CType(resources.GetObject("btnGuiaAnalisis.Image"), System.Drawing.Image)
        Me.btnGuiaAnalisis.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuiaAnalisis.Location = New System.Drawing.Point(1224, 8)
        Me.btnGuiaAnalisis.Name = "btnGuiaAnalisis"
        Me.btnGuiaAnalisis.Size = New System.Drawing.Size(75, 54)
        Me.btnGuiaAnalisis.TabIndex = 13
        Me.btnGuiaAnalisis.Text = "&Guia Analisis"
        Me.btnGuiaAnalisis.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuiaAnalisis.UseVisualStyleBackColor = True
        Me.btnGuiaAnalisis.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(1313, 8)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(63, 52)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(1158, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 52)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        Me.btnNuevo.Visible = False
        '
        'pnlfiltros
        '
        Me.pnlfiltros.BackColor = System.Drawing.Color.White
        Me.pnlfiltros.Controls.Add(Me.GroupBox1)
        Me.pnlfiltros.Controls.Add(Me.gbRangofechas)
        Me.pnlfiltros.Controls.Add(Me.GroupBox7)
        Me.pnlfiltros.Controls.Add(Me.GroupBox6)
        Me.pnlfiltros.Location = New System.Drawing.Point(11, 32)
        Me.pnlfiltros.Name = "pnlfiltros"
        Me.pnlfiltros.Size = New System.Drawing.Size(1015, 58)
        Me.pnlfiltros.TabIndex = 102
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cboEstados)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(304, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 48)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estados"
        '
        'cboEstados
        '
        Me.cboEstados.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstados.FormattingEnabled = True
        Me.cboEstados.Items.AddRange(New Object() {"CUARENTENA", "APROBADOS", "RECHAZADOS"})
        Me.cboEstados.Location = New System.Drawing.Point(9, 15)
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Size = New System.Drawing.Size(135, 25)
        Me.cboEstados.TabIndex = 5
        '
        'gbRangofechas
        '
        Me.gbRangofechas.BackColor = System.Drawing.Color.White
        Me.gbRangofechas.Controls.Add(Me.Label6)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label15)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(657, 7)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(348, 48)
        Me.gbRangofechas.TabIndex = 105
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        Me.gbRangofechas.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(179, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(246, 16)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(93, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(6, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Fecha inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(80, 16)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(93, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.txtFiltro)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(295, 48)
        Me.GroupBox7.TabIndex = 103
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(12, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(277, 22)
        Me.txtFiltro.TabIndex = 4
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(459, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(192, 48)
        Me.GroupBox6.TabIndex = 104
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(13, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(165, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(17, 580)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 103
        Me.lblCantidad.Text = "."
        '
        'dgvCabeceraAlmacen
        '
        Me.dgvCabeceraAlmacen.AllowUserToAddRows = False
        Me.dgvCabeceraAlmacen.AllowUserToDeleteRows = False
        Me.dgvCabeceraAlmacen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabeceraAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabeceraAlmacen.Location = New System.Drawing.Point(11, 92)
        Me.dgvCabeceraAlmacen.Name = "dgvCabeceraAlmacen"
        Me.dgvCabeceraAlmacen.ReadOnly = True
        Me.dgvCabeceraAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabeceraAlmacen.Size = New System.Drawing.Size(998, 483)
        Me.dgvCabeceraAlmacen.TabIndex = 104
        '
        'pnlFecha
        '
        Me.pnlFecha.Controls.Add(Me.Label1)
        Me.pnlFecha.Controls.Add(Me.dtpFecha)
        Me.pnlFecha.Location = New System.Drawing.Point(44, 106)
        Me.pnlFecha.Name = "pnlFecha"
        Me.pnlFecha.Size = New System.Drawing.Size(118, 50)
        Me.pnlFecha.TabIndex = 105
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConsultar, Me.btnGrabar, Me.btnEliminar, Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1020, 25)
        Me.ToolStrip1.TabIndex = 106
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(67, 22)
        Me.btnConsultar.Text = "&Liberar"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(73, 22)
        Me.btnGrabar.Text = "&Aprobar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(80, 22)
        Me.btnEliminar.Text = "&Rechazar"
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
        'FrmControl_Liberacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 605)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvCabeceraAlmacen)
        Me.Controls.Add(Me.pnlFecha)
        Me.Controls.Add(Me.btnGuiaAnalisis)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.pnlfiltros)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gbCabceraDocumento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmControl_Liberacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liberacion de cuarentena Materia Prima"
        Me.gbCabceraDocumento.ResumeLayout(False)
        Me.GbTransaccion.ResumeLayout(False)
        Me.GbTransaccion.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.pnl_guia_analisis.ResumeLayout(False)
        Me.pnl_guia_analisis.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbdetalleDocumento.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlfiltros.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFecha.ResumeLayout(False)
        Me.pnlFecha.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCabceraDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents GbTransaccion As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents chkValorizado As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtordenCompra As System.Windows.Forms.TextBox
    Friend WithEvents lbltercero As System.Windows.Forms.Label
    Friend WithEvents lblproveedor As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtorderFabricacion As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroReferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoTercero As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoDocumentoRef As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GbdetalleDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbocentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnGuiaAnalisis As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents pnlfiltros As System.Windows.Forms.Panel
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dgvCabeceraAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fec_Vencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Procedencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pais_Origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valoracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEstados As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Numero_Ref As System.Windows.Forms.TextBox
    Friend WithEvents txt_Tipo_Ref As System.Windows.Forms.TextBox
    Friend WithEvents pnlFecha As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_ref As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pnl_guia_analisis As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_nro_guia As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo_guia As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents dtp_fecha_guia As System.Windows.Forms.MaskedTextBox
End Class
