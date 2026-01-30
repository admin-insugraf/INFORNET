<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovimientoGuiaAnalisis
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMovimientoGuiaAnalisis))
        Me.gbCabceraDocumento = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboAlmacen = New System.Windows.Forms.ComboBox()
        Me.txt_Numero_Ref = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Tipo_Ref = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkValorizado = New System.Windows.Forms.CheckBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.pnlfiltros = New System.Windows.Forms.Panel()
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.gbCabceraDocumento.SuspendLayout()
        Me.GbCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GbdetalleDocumento.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlfiltros.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCabceraDocumento
        '
        Me.gbCabceraDocumento.Controls.Add(Me.Label27)
        Me.gbCabceraDocumento.Controls.Add(Me.txtComentarios)
        Me.gbCabceraDocumento.Controls.Add(Me.GbCabecera)
        Me.gbCabceraDocumento.Controls.Add(Me.GbdetalleDocumento)
        Me.gbCabceraDocumento.Location = New System.Drawing.Point(19, 90)
        Me.gbCabceraDocumento.Name = "gbCabceraDocumento"
        Me.gbCabceraDocumento.Size = New System.Drawing.Size(1000, 467)
        Me.gbCabceraDocumento.TabIndex = 41
        Me.gbCabceraDocumento.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(18, 220)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(243, 13)
        Me.Label27.TabIndex = 124
        Me.Label27.Text = "Datos Adicionales / Observaciones / Comentarios"
        '
        'txtComentarios
        '
        Me.txtComentarios.BackColor = System.Drawing.Color.White
        Me.txtComentarios.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarios.Location = New System.Drawing.Point(267, 216)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarios.Size = New System.Drawing.Size(726, 20)
        Me.txtComentarios.TabIndex = 123
        Me.txtComentarios.Text = ""
        '
        'GbCabecera
        '
        Me.GbCabecera.Controls.Add(Me.Label1)
        Me.GbCabecera.Controls.Add(Me.cboTipoMovimiento)
        Me.GbCabecera.Controls.Add(Me.GroupBox1)
        Me.GbCabecera.Controls.Add(Me.chkValorizado)
        Me.GbCabecera.Controls.Add(Me.cboMoneda)
        Me.GbCabecera.Controls.Add(Me.Label11)
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
        Me.GbCabecera.Location = New System.Drawing.Point(21, 12)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(975, 198)
        Me.GbCabecera.TabIndex = 37
        Me.GbCabecera.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Tipo Transanccion"
        '
        'cboTipoMovimiento
        '
        Me.cboTipoMovimiento.DisplayMember = "Nombre"
        Me.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMovimiento.FormattingEnabled = True
        Me.cboTipoMovimiento.Location = New System.Drawing.Point(105, 10)
        Me.cboTipoMovimiento.Name = "cboTipoMovimiento"
        Me.cboTipoMovimiento.Size = New System.Drawing.Size(359, 21)
        Me.cboTipoMovimiento.TabIndex = 2
        Me.cboTipoMovimiento.ValueMember = "Codigo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboAlmacen)
        Me.GroupBox1.Controls.Add(Me.txt_Numero_Ref)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Tipo_Ref)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(22, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 75)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Guia de Analisis"
        '
        'CboAlmacen
        '
        Me.CboAlmacen.FormattingEnabled = True
        Me.CboAlmacen.Location = New System.Drawing.Point(83, 19)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(300, 21)
        Me.CboAlmacen.TabIndex = 3
        '
        'txt_Numero_Ref
        '
        Me.txt_Numero_Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Numero_Ref.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Numero_Ref.Location = New System.Drawing.Point(162, 46)
        Me.txt_Numero_Ref.Name = "txt_Numero_Ref"
        Me.txt_Numero_Ref.Size = New System.Drawing.Size(86, 21)
        Me.txt_Numero_Ref.TabIndex = 127
        Me.txt_Numero_Ref.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(26, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Almacen "
        '
        'txt_Tipo_Ref
        '
        Me.txt_Tipo_Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Tipo_Ref.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tipo_Ref.Location = New System.Drawing.Point(82, 46)
        Me.txt_Tipo_Ref.Name = "txt_Tipo_Ref"
        Me.txt_Tipo_Ref.Size = New System.Drawing.Size(25, 21)
        Me.txt_Tipo_Ref.TabIndex = 126
        Me.txt_Tipo_Ref.Text = " "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(116, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 124
        Me.Label17.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(248, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Fecha "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(46, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Tipo."
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(290, 44)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(93, 21)
        Me.dtpFecha.TabIndex = 1
        '
        'chkValorizado
        '
        Me.chkValorizado.AutoSize = True
        Me.chkValorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkValorizado.ForeColor = System.Drawing.Color.Navy
        Me.chkValorizado.Location = New System.Drawing.Point(468, 12)
        Me.chkValorizado.Name = "chkValorizado"
        Me.chkValorizado.Size = New System.Drawing.Size(75, 17)
        Me.chkValorizado.TabIndex = 3
        Me.chkValorizado.Text = "Valorizado"
        Me.chkValorizado.UseVisualStyleBackColor = True
        Me.chkValorizado.Visible = False
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(562, 49)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(185, 21)
        Me.cboMoneda.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(512, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Moneda"
        '
        'cbocentroCosto
        '
        Me.cbocentroCosto.Enabled = False
        Me.cbocentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbocentroCosto.FormattingEnabled = True
        Me.cbocentroCosto.Location = New System.Drawing.Point(851, 46)
        Me.cbocentroCosto.Name = "cbocentroCosto"
        Me.cbocentroCosto.Size = New System.Drawing.Size(100, 21)
        Me.cbocentroCosto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(60, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(44, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Proveedor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(468, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Orden de Compra"
        '
        'txtordenCompra
        '
        Me.txtordenCompra.BackColor = System.Drawing.Color.White
        Me.txtordenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtordenCompra.Location = New System.Drawing.Point(562, 74)
        Me.txtordenCompra.Name = "txtordenCompra"
        Me.txtordenCompra.Size = New System.Drawing.Size(185, 20)
        Me.txtordenCompra.TabIndex = 8
        Me.txtordenCompra.Tag = "Orden de Compra"
        Me.txtordenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltercero
        '
        Me.lbltercero.AutoSize = True
        Me.lbltercero.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbltercero.ForeColor = System.Drawing.Color.Black
        Me.lbltercero.Location = New System.Drawing.Point(203, 170)
        Me.lbltercero.Name = "lbltercero"
        Me.lbltercero.Size = New System.Drawing.Size(17, 18)
        Me.lbltercero.TabIndex = 43
        Me.lbltercero.Text = "..."
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblproveedor.ForeColor = System.Drawing.Color.Black
        Me.lblproveedor.Location = New System.Drawing.Point(204, 146)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(17, 18)
        Me.lblproveedor.TabIndex = 36
        Me.lblproveedor.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(466, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Orden Fabricacion"
        '
        'txtorderFabricacion
        '
        Me.txtorderFabricacion.BackColor = System.Drawing.Color.White
        Me.txtorderFabricacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtorderFabricacion.Location = New System.Drawing.Point(562, 100)
        Me.txtorderFabricacion.Name = "txtorderFabricacion"
        Me.txtorderFabricacion.Size = New System.Drawing.Size(185, 20)
        Me.txtorderFabricacion.TabIndex = 9
        Me.txtorderFabricacion.Tag = "Orden de Fabricacion"
        Me.txtorderFabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeroReferencia
        '
        Me.txtNumeroReferencia.BackColor = System.Drawing.Color.Aquamarine
        Me.txtNumeroReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroReferencia.ForeColor = System.Drawing.Color.Red
        Me.txtNumeroReferencia.Location = New System.Drawing.Point(230, 117)
        Me.txtNumeroReferencia.Name = "txtNumeroReferencia"
        Me.txtNumeroReferencia.Size = New System.Drawing.Size(131, 20)
        Me.txtNumeroReferencia.TabIndex = 7
        Me.txtNumeroReferencia.Tag = "Numero documento Referencia"
        Me.txtNumeroReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoTercero
        '
        Me.txtcodigoTercero.BackColor = System.Drawing.Color.White
        Me.txtcodigoTercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoTercero.Location = New System.Drawing.Point(103, 168)
        Me.txtcodigoTercero.Name = "txtcodigoTercero"
        Me.txtcodigoTercero.ReadOnly = True
        Me.txtcodigoTercero.Size = New System.Drawing.Size(96, 20)
        Me.txtcodigoTercero.TabIndex = 11
        Me.txtcodigoTercero.Tag = "Cliente"
        Me.txtcodigoTercero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTipoDocumentoRef
        '
        Me.txtTipoDocumentoRef.BackColor = System.Drawing.Color.Aquamarine
        Me.txtTipoDocumentoRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoDocumentoRef.ForeColor = System.Drawing.Color.Red
        Me.txtTipoDocumentoRef.Location = New System.Drawing.Point(103, 117)
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
        Me.txtcodigoProveedor.Location = New System.Drawing.Point(103, 144)
        Me.txtcodigoProveedor.Name = "txtcodigoProveedor"
        Me.txtcodigoProveedor.ReadOnly = True
        Me.txtcodigoProveedor.Size = New System.Drawing.Size(95, 20)
        Me.txtcodigoProveedor.TabIndex = 10
        Me.txtcodigoProveedor.Tag = "Proveedor"
        Me.txtcodigoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(777, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Centro Costo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(32, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Tip Doc Ref."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(154, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Num.Doc.Ref"
        '
        'GbdetalleDocumento
        '
        Me.GbdetalleDocumento.Controls.Add(Me.dgvDetalle)
        Me.GbdetalleDocumento.Location = New System.Drawing.Point(19, 236)
        Me.GbdetalleDocumento.Name = "GbdetalleDocumento"
        Me.GbdetalleDocumento.Size = New System.Drawing.Size(976, 226)
        Me.GbdetalleDocumento.TabIndex = 38
        Me.GbdetalleDocumento.TabStop = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.DataGridViewTextBoxColumn1})
        Me.dgvDetalle.Location = New System.Drawing.Point(4, 17)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(970, 204)
        Me.dgvDetalle.TabIndex = 41
        Me.dgvDetalle.Visible = False
        '
        'Column7
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column10.HeaderText = "Unidad"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 45
        '
        'Column11
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column11.HeaderText = "Numero_Analisis"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Format = "N4"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column12.HeaderText = "Cantidad "
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 80
        '
        'Column13
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle11
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
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'pnlfiltros
        '
        Me.pnlfiltros.BackColor = System.Drawing.Color.White
        Me.pnlfiltros.Controls.Add(Me.gbRangofechas)
        Me.pnlfiltros.Controls.Add(Me.GroupBox7)
        Me.pnlfiltros.Controls.Add(Me.GroupBox6)
        Me.pnlfiltros.Location = New System.Drawing.Point(18, 30)
        Me.pnlfiltros.Name = "pnlfiltros"
        Me.pnlfiltros.Size = New System.Drawing.Size(1002, 58)
        Me.pnlfiltros.TabIndex = 102
        '
        'gbRangofechas
        '
        Me.gbRangofechas.BackColor = System.Drawing.Color.White
        Me.gbRangofechas.Controls.Add(Me.Label6)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label15)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(528, 4)
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
        Me.GroupBox7.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(317, 48)
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
        Me.txtFiltro.Size = New System.Drawing.Size(292, 22)
        Me.txtFiltro.TabIndex = 4
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(329, 4)
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
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(20, 568)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 13)
        Me.lblCantidad.TabIndex = 103
        Me.lblCantidad.Text = "."
        '
        'dgvCabeceraAlmacen
        '
        Me.dgvCabeceraAlmacen.AllowUserToAddRows = False
        Me.dgvCabeceraAlmacen.AllowUserToDeleteRows = False
        Me.dgvCabeceraAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabeceraAlmacen.Location = New System.Drawing.Point(19, 90)
        Me.dgvCabeceraAlmacen.Name = "dgvCabeceraAlmacen"
        Me.dgvCabeceraAlmacen.ReadOnly = True
        Me.dgvCabeceraAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabeceraAlmacen.Size = New System.Drawing.Size(1001, 474)
        Me.dgvCabeceraAlmacen.TabIndex = 104
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConsultar, Me.btnEliminar, Me.btnImprimir, Me.btnCancelar, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1027, 25)
        Me.ToolStrip1.TabIndex = 196
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.btnEliminar.Size = New System.Drawing.Size(64, 22)
        Me.btnEliminar.Text = "&Anular"
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
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton7.Text = "&Salir"
        '
        'FrmMovimientoGuiaAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1027, 590)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvCabeceraAlmacen)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.pnlfiltros)
        Me.Controls.Add(Me.gbCabceraDocumento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMovimientoGuiaAnalisis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guias de Analisis"
        Me.gbCabceraDocumento.ResumeLayout(False)
        Me.gbCabceraDocumento.PerformLayout()
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbdetalleDocumento.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlfiltros.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCabceraDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents chkValorizado As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbocentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_Numero_Ref As System.Windows.Forms.TextBox
    Friend WithEvents txt_Tipo_Ref As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
