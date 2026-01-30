<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAceptacionLetras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAceptacionLetras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbo_estados = New System.Windows.Forms.ComboBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnCambiarEstado = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtmonedaSituacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcuentasituacion = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionSituacion = New System.Windows.Forms.TextBox()
        Me.txtcodigoSituacion = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcion_estado = New System.Windows.Forms.TextBox()
        Me.txtmoneda_estado = New System.Windows.Forms.TextBox()
        Me.txtcodigo_estado = New System.Windows.Forms.TextBox()
        Me.txtcuentacontable_estado = New System.Windows.Forms.TextBox()
        Me.txtmoneda = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnumeracionBancaria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCuenta = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdescripcionBanco = New System.Windows.Forms.TextBox()
        Me.txtbanco = New System.Windows.Forms.TextBox()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigoletra = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PnlCambioestadogrupal = New System.Windows.Forms.Panel()
        Me.mtb_fec_emi = New System.Windows.Forms.MaskedTextBox()
        Me.chktodos = New System.Windows.Forms.CheckBox()
        Me.dgv_pendientes = New System.Windows.Forms.DataGridView()
        Me.chk_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.COL_DOCUMENT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_NUM_DOC_AUX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TERCERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_COD_MON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_TC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_MONTO_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DOC_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_CADUCATE_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_SALES_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_SALES_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_IS_DR_CR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DOCUMENT_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_NUMBER_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_AMOUNT_BALANCE_INI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO_CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PnlCambioestadogrupal.SuspendLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.pnlPrincipal)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(887, 491)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox5)
        Me.pnlPrincipal.Controls.Add(Me.lblCantidad)
        Me.pnlPrincipal.Controls.Add(Me.dgvDocumentos)
        Me.pnlPrincipal.Controls.Add(Me.gbFiltros)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 5)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(887, 484)
        Me.pnlPrincipal.TabIndex = 144
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbo_estados)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(340, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(399, 49)
        Me.GroupBox5.TabIndex = 197
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Busquedas por Estado de Letras"
        '
        'cbo_estados
        '
        Me.cbo_estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_estados.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_estados.FormattingEnabled = True
        Me.cbo_estados.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cbo_estados.Location = New System.Drawing.Point(6, 16)
        Me.cbo_estados.Name = "cbo_estados"
        Me.cbo_estados.Size = New System.Drawing.Size(387, 22)
        Me.cbo_estados.TabIndex = 5
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(15, 452)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 144
        Me.lblCantidad.Text = "."
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        Me.dgvDocumentos.AllowUserToDeleteRows = False
        Me.dgvDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(12, 60)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.ReadOnly = True
        Me.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDocumentos.Size = New System.Drawing.Size(863, 389)
        Me.dgvDocumentos.TabIndex = 0
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.Controls.Add(Me.btnCambiarEstado)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(12, 5)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(318, 49)
        Me.gbFiltros.TabIndex = 143
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(298, 25)
        Me.txtFiltro.TabIndex = 24
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarEstado.ForeColor = System.Drawing.Color.Blue
        Me.btnCambiarEstado.Image = CType(resources.GetObject("btnCambiarEstado.Image"), System.Drawing.Image)
        Me.btnCambiarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCambiarEstado.Location = New System.Drawing.Point(425, 13)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(129, 28)
        Me.btnCambiarEstado.TabIndex = 1
        Me.btnCambiarEstado.Text = "&Cambiar de Estado"
        Me.btnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCambiarEstado.UseVisualStyleBackColor = True
        Me.btnCambiarEstado.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Blue
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.Location = New System.Drawing.Point(303, 423)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(145, 38)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Retornar"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.Location = New System.Drawing.Point(157, 423)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(144, 38)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Generar Cambio de Estado"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtmonedaSituacion)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtcuentasituacion)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.txtdescripcionSituacion)
        Me.GroupBox2.Controls.Add(Me.txtcodigoSituacion)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtmoneda)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtComentario)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpFechaActualizacion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtnumeracionBancaria)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cboCuenta)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtdescripcionBanco)
        Me.GroupBox2.Controls.Add(Me.txtbanco)
        Me.GroupBox2.Controls.Add(Me.dtpVencimiento)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtcodigoletra)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(47, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 400)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Estado de Letra"
        '
        'txtmonedaSituacion
        '
        Me.txtmonedaSituacion.BackColor = System.Drawing.Color.White
        Me.txtmonedaSituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonedaSituacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonedaSituacion.Location = New System.Drawing.Point(316, 138)
        Me.txtmonedaSituacion.Name = "txtmonedaSituacion"
        Me.txtmonedaSituacion.ReadOnly = True
        Me.txtmonedaSituacion.Size = New System.Drawing.Size(46, 21)
        Me.txtmonedaSituacion.TabIndex = 199
        Me.txtmonedaSituacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(35, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 198
        Me.Label10.Text = "Situacion de Estado"
        '
        'txtcuentasituacion
        '
        Me.txtcuentasituacion.BackColor = System.Drawing.Color.White
        Me.txtcuentasituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentasituacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcuentasituacion.Location = New System.Drawing.Point(365, 138)
        Me.txtcuentasituacion.Name = "txtcuentasituacion"
        Me.txtcuentasituacion.ReadOnly = True
        Me.txtcuentasituacion.Size = New System.Drawing.Size(99, 21)
        Me.txtcuentasituacion.TabIndex = 200
        Me.txtcuentasituacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox1.TabIndex = 193
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionSituacion
        '
        Me.txtdescripcionSituacion.BackColor = System.Drawing.Color.White
        Me.txtdescripcionSituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionSituacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcionSituacion.Location = New System.Drawing.Point(102, 138)
        Me.txtdescripcionSituacion.Name = "txtdescripcionSituacion"
        Me.txtdescripcionSituacion.ReadOnly = True
        Me.txtdescripcionSituacion.Size = New System.Drawing.Size(210, 21)
        Me.txtdescripcionSituacion.TabIndex = 6
        Me.txtdescripcionSituacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSituacion
        '
        Me.txtcodigoSituacion.BackColor = System.Drawing.Color.White
        Me.txtcodigoSituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoSituacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoSituacion.Location = New System.Drawing.Point(33, 137)
        Me.txtcodigoSituacion.Name = "txtcodigoSituacion"
        Me.txtcodigoSituacion.ReadOnly = True
        Me.txtcodigoSituacion.Size = New System.Drawing.Size(46, 21)
        Me.txtcodigoSituacion.TabIndex = 4
        Me.txtcodigoSituacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtdescripcion_estado)
        Me.GroupBox3.Controls.Add(Me.txtmoneda_estado)
        Me.GroupBox3.Controls.Add(Me.txtcodigo_estado)
        Me.GroupBox3.Controls.Add(Me.txtcuentacontable_estado)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(23, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(452, 58)
        Me.GroupBox3.TabIndex = 189
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Situacion anterior de la letra"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(293, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 198
        Me.Label13.Text = "Moneda"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(14, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 197
        Me.Label12.Text = "Codigo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(102, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 196
        Me.Label11.Text = "Descripcion del estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(345, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Cuenta contable"
        '
        'txtdescripcion_estado
        '
        Me.txtdescripcion_estado.BackColor = System.Drawing.Color.White
        Me.txtdescripcion_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion_estado.Location = New System.Drawing.Point(60, 33)
        Me.txtdescripcion_estado.Name = "txtdescripcion_estado"
        Me.txtdescripcion_estado.ReadOnly = True
        Me.txtdescripcion_estado.Size = New System.Drawing.Size(229, 21)
        Me.txtdescripcion_estado.TabIndex = 190
        Me.txtdescripcion_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmoneda_estado
        '
        Me.txtmoneda_estado.BackColor = System.Drawing.Color.White
        Me.txtmoneda_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmoneda_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmoneda_estado.Location = New System.Drawing.Point(294, 33)
        Me.txtmoneda_estado.Name = "txtmoneda_estado"
        Me.txtmoneda_estado.ReadOnly = True
        Me.txtmoneda_estado.Size = New System.Drawing.Size(46, 21)
        Me.txtmoneda_estado.TabIndex = 191
        Me.txtmoneda_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo_estado
        '
        Me.txtcodigo_estado.BackColor = System.Drawing.Color.White
        Me.txtcodigo_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo_estado.Location = New System.Drawing.Point(12, 33)
        Me.txtcodigo_estado.Name = "txtcodigo_estado"
        Me.txtcodigo_estado.ReadOnly = True
        Me.txtcodigo_estado.Size = New System.Drawing.Size(46, 21)
        Me.txtcodigo_estado.TabIndex = 189
        Me.txtcodigo_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcuentacontable_estado
        '
        Me.txtcuentacontable_estado.BackColor = System.Drawing.Color.White
        Me.txtcuentacontable_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentacontable_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcuentacontable_estado.Location = New System.Drawing.Point(342, 33)
        Me.txtcuentacontable_estado.Name = "txtcuentacontable_estado"
        Me.txtcuentacontable_estado.ReadOnly = True
        Me.txtcuentacontable_estado.Size = New System.Drawing.Size(99, 21)
        Me.txtcuentacontable_estado.TabIndex = 192
        Me.txtcuentacontable_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmoneda
        '
        Me.txtmoneda.BackColor = System.Drawing.Color.White
        Me.txtmoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtmoneda.Location = New System.Drawing.Point(149, 33)
        Me.txtmoneda.Name = "txtmoneda"
        Me.txtmoneda.ReadOnly = True
        Me.txtmoneda.Size = New System.Drawing.Size(45, 21)
        Me.txtmoneda.TabIndex = 186
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(149, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 185
        Me.Label9.Text = "Moneda"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(32, 352)
        Me.txtComentario.MaxLength = 255
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(455, 42)
        Me.txtComentario.TabIndex = 184
        Me.txtComentario.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "Comentario"
        '
        'dtpFechaActualizacion
        '
        Me.dtpFechaActualizacion.Location = New System.Drawing.Point(32, 313)
        Me.dtpFechaActualizacion.Name = "dtpFechaActualizacion"
        Me.dtpFechaActualizacion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaActualizacion.TabIndex = 182
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "Fecha Actualizacion"
        '
        'txtnumeracionBancaria
        '
        Me.txtnumeracionBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumeracionBancaria.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtnumeracionBancaria.Location = New System.Drawing.Point(32, 266)
        Me.txtnumeracionBancaria.MaxLength = 21
        Me.txtnumeracionBancaria.Name = "txtnumeracionBancaria"
        Me.txtnumeracionBancaria.Size = New System.Drawing.Size(251, 21)
        Me.txtnumeracionBancaria.TabIndex = 180
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "Numeracion Bancaria"
        '
        'cboCuenta
        '
        Me.cboCuenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(33, 223)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(431, 21)
        Me.cboCuenta.TabIndex = 178
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Cuenta Corriente"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(81, 179)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox2.TabIndex = 176
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Banco"
        '
        'txtdescripcionBanco
        '
        Me.txtdescripcionBanco.BackColor = System.Drawing.Color.White
        Me.txtdescripcionBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionBanco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtdescripcionBanco.Location = New System.Drawing.Point(102, 178)
        Me.txtdescripcionBanco.Name = "txtdescripcionBanco"
        Me.txtdescripcionBanco.ReadOnly = True
        Me.txtdescripcionBanco.Size = New System.Drawing.Size(362, 21)
        Me.txtdescripcionBanco.TabIndex = 174
        '
        'txtbanco
        '
        Me.txtbanco.BackColor = System.Drawing.Color.White
        Me.txtbanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbanco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtbanco.Location = New System.Drawing.Point(33, 178)
        Me.txtbanco.Name = "txtbanco"
        Me.txtbanco.ReadOnly = True
        Me.txtbanco.Size = New System.Drawing.Size(46, 21)
        Me.txtbanco.TabIndex = 173
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Enabled = False
        Me.dtpVencimiento.Location = New System.Drawing.Point(199, 33)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(202, 20)
        Me.dtpVencimiento.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Vencimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nro. Letra"
        '
        'txtcodigoletra
        '
        Me.txtcodigoletra.BackColor = System.Drawing.Color.White
        Me.txtcodigoletra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoletra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtcodigoletra.Location = New System.Drawing.Point(33, 33)
        Me.txtcodigoletra.Name = "txtcodigoletra"
        Me.txtcodigoletra.ReadOnly = True
        Me.txtcodigoletra.Size = New System.Drawing.Size(111, 21)
        Me.txtcodigoletra.TabIndex = 0
        Me.txtcodigoletra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton1, Me.btnNuevo, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(902, 25)
        Me.ToolStrip1.TabIndex = 172
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripButton3.Text = "Cambiar de &Estado Grupal"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripButton1.Text = "&Cambiar de Estado Individual"
        '
        'btnNuevo
        '
        Me.btnNuevo.ForeColor = System.Drawing.Color.Navy
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(111, 22)
        Me.btnNuevo.Text = "&Actualizar datos"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'PnlCambioestadogrupal
        '
        Me.PnlCambioestadogrupal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCambioestadogrupal.Controls.Add(Me.mtb_fec_emi)
        Me.PnlCambioestadogrupal.Controls.Add(Me.chktodos)
        Me.PnlCambioestadogrupal.Controls.Add(Me.dgv_pendientes)
        Me.PnlCambioestadogrupal.Controls.Add(Me.TextBox1)
        Me.PnlCambioestadogrupal.Controls.Add(Me.Label15)
        Me.PnlCambioestadogrupal.Controls.Add(Me.TextBox2)
        Me.PnlCambioestadogrupal.Controls.Add(Me.PictureBox3)
        Me.PnlCambioestadogrupal.Controls.Add(Me.TextBox3)
        Me.PnlCambioestadogrupal.Controls.Add(Me.TextBox4)
        Me.PnlCambioestadogrupal.Controls.Add(Me.GroupBox4)
        Me.PnlCambioestadogrupal.Controls.Add(Me.DateTimePicker1)
        Me.PnlCambioestadogrupal.Controls.Add(Me.Label21)
        Me.PnlCambioestadogrupal.Controls.Add(Me.ComboBox1)
        Me.PnlCambioestadogrupal.Controls.Add(Me.Label22)
        Me.PnlCambioestadogrupal.Controls.Add(Me.PictureBox4)
        Me.PnlCambioestadogrupal.Controls.Add(Me.Button1)
        Me.PnlCambioestadogrupal.Controls.Add(Me.Label23)
        Me.PnlCambioestadogrupal.Controls.Add(Me.TextBox9)
        Me.PnlCambioestadogrupal.Controls.Add(Me.TextBox10)
        Me.PnlCambioestadogrupal.Controls.Add(Me.Button2)
        Me.PnlCambioestadogrupal.Location = New System.Drawing.Point(3, 33)
        Me.PnlCambioestadogrupal.Name = "PnlCambioestadogrupal"
        Me.PnlCambioestadogrupal.Size = New System.Drawing.Size(887, 486)
        Me.PnlCambioestadogrupal.TabIndex = 173
        Me.PnlCambioestadogrupal.Visible = False
        '
        'mtb_fec_emi
        '
        Me.mtb_fec_emi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtb_fec_emi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_fec_emi.Location = New System.Drawing.Point(139, 399)
        Me.mtb_fec_emi.Mask = "00/00/0000"
        Me.mtb_fec_emi.Name = "mtb_fec_emi"
        Me.mtb_fec_emi.Size = New System.Drawing.Size(66, 20)
        Me.mtb_fec_emi.TabIndex = 222
        Me.mtb_fec_emi.ValidatingType = GetType(Date)
        '
        'chktodos
        '
        Me.chktodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.Color.Navy
        Me.chktodos.Location = New System.Drawing.Point(16, 296)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(169, 17)
        Me.chktodos.TabIndex = 221
        Me.chktodos.Text = "Marcar &Todos los documentos"
        Me.chktodos.UseVisualStyleBackColor = True
        '
        'dgv_pendientes
        '
        Me.dgv_pendientes.AllowUserToAddRows = False
        Me.dgv_pendientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_pendientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_pendientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk_sel, Me.COL_DOCUMENT_ID, Me.COL_NUM_DOC_AUX, Me.CUSTOMER_ID, Me.TERCERO, Me.COL_COD_MON, Me.COL_TC, Me.COL_MONTO_SALDO, Me.COL_SALDO, Me.COL_DOC_DATE, Me.COL_CADUCATE_DATE, Me.COL_SALES_ID, Me.COL_SALES_NAME, Me.COL_IS_DR_CR, Me.COL_DOCUMENT_REF, Me.COL_NUMBER_REF, Me.COL_AMOUNT_BALANCE_INI, Me.CODIGO_CLIENTE})
        Me.dgv_pendientes.Location = New System.Drawing.Point(16, 74)
        Me.dgv_pendientes.Name = "dgv_pendientes"
        Me.dgv_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pendientes.Size = New System.Drawing.Size(858, 217)
        Me.dgv_pendientes.TabIndex = 220
        '
        'chk_sel
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = False
        Me.chk_sel.DefaultCellStyle = DataGridViewCellStyle2
        Me.chk_sel.Frozen = True
        Me.chk_sel.HeaderText = "Sel"
        Me.chk_sel.Name = "chk_sel"
        Me.chk_sel.Width = 30
        '
        'COL_DOCUMENT_ID
        '
        Me.COL_DOCUMENT_ID.DataPropertyName = "DOCUMENT_ID"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COL_DOCUMENT_ID.DefaultCellStyle = DataGridViewCellStyle3
        Me.COL_DOCUMENT_ID.HeaderText = "Tipo"
        Me.COL_DOCUMENT_ID.Name = "COL_DOCUMENT_ID"
        Me.COL_DOCUMENT_ID.ReadOnly = True
        Me.COL_DOCUMENT_ID.Width = 35
        '
        'COL_NUM_DOC_AUX
        '
        Me.COL_NUM_DOC_AUX.DataPropertyName = "NUMBER_DOC"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COL_NUM_DOC_AUX.DefaultCellStyle = DataGridViewCellStyle4
        Me.COL_NUM_DOC_AUX.HeaderText = "Numero"
        Me.COL_NUM_DOC_AUX.Name = "COL_NUM_DOC_AUX"
        Me.COL_NUM_DOC_AUX.ReadOnly = True
        Me.COL_NUM_DOC_AUX.Width = 80
        '
        'CUSTOMER_ID
        '
        Me.CUSTOMER_ID.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMER_ID.HeaderText = "Cod_Cliente"
        Me.CUSTOMER_ID.Name = "CUSTOMER_ID"
        Me.CUSTOMER_ID.Width = 50
        '
        'TERCERO
        '
        Me.TERCERO.DataPropertyName = "TERCERO"
        Me.TERCERO.HeaderText = "Cliente"
        Me.TERCERO.Name = "TERCERO"
        Me.TERCERO.Width = 200
        '
        'COL_COD_MON
        '
        Me.COL_COD_MON.DataPropertyName = "COD_MON"
        Me.COL_COD_MON.HeaderText = "Mon"
        Me.COL_COD_MON.Name = "COL_COD_MON"
        Me.COL_COD_MON.ReadOnly = True
        Me.COL_COD_MON.Width = 30
        '
        'COL_TC
        '
        Me.COL_TC.DataPropertyName = "TC"
        DataGridViewCellStyle5.Format = "N3"
        Me.COL_TC.DefaultCellStyle = DataGridViewCellStyle5
        Me.COL_TC.HeaderText = "T/C."
        Me.COL_TC.Name = "COL_TC"
        Me.COL_TC.ReadOnly = True
        Me.COL_TC.Width = 40
        '
        'COL_MONTO_SALDO
        '
        Me.COL_MONTO_SALDO.DataPropertyName = "Saldo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "##,##0.00"
        Me.COL_MONTO_SALDO.DefaultCellStyle = DataGridViewCellStyle6
        Me.COL_MONTO_SALDO.HeaderText = "Monto "
        Me.COL_MONTO_SALDO.Name = "COL_MONTO_SALDO"
        Me.COL_MONTO_SALDO.ReadOnly = True
        Me.COL_MONTO_SALDO.Width = 80
        '
        'COL_SALDO
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.Format = "####0.00"
        Me.COL_SALDO.DefaultCellStyle = DataGridViewCellStyle7
        Me.COL_SALDO.HeaderText = "Saldo"
        Me.COL_SALDO.Name = "COL_SALDO"
        Me.COL_SALDO.Width = 80
        '
        'COL_DOC_DATE
        '
        Me.COL_DOC_DATE.DataPropertyName = "DOC_DATE"
        Me.COL_DOC_DATE.HeaderText = "Emision"
        Me.COL_DOC_DATE.Name = "COL_DOC_DATE"
        Me.COL_DOC_DATE.ReadOnly = True
        Me.COL_DOC_DATE.Width = 75
        '
        'COL_CADUCATE_DATE
        '
        Me.COL_CADUCATE_DATE.DataPropertyName = "CADUCATE_DATE"
        Me.COL_CADUCATE_DATE.HeaderText = "Vencimiento"
        Me.COL_CADUCATE_DATE.Name = "COL_CADUCATE_DATE"
        Me.COL_CADUCATE_DATE.ReadOnly = True
        Me.COL_CADUCATE_DATE.Width = 75
        '
        'COL_SALES_ID
        '
        Me.COL_SALES_ID.DataPropertyName = "SALES_ID"
        Me.COL_SALES_ID.HeaderText = "Codigo"
        Me.COL_SALES_ID.Name = "COL_SALES_ID"
        Me.COL_SALES_ID.ReadOnly = True
        Me.COL_SALES_ID.Visible = False
        Me.COL_SALES_ID.Width = 50
        '
        'COL_SALES_NAME
        '
        Me.COL_SALES_NAME.DataPropertyName = "NAME_VENDEDOR"
        Me.COL_SALES_NAME.HeaderText = "Vendedor"
        Me.COL_SALES_NAME.Name = "COL_SALES_NAME"
        Me.COL_SALES_NAME.Visible = False
        Me.COL_SALES_NAME.Width = 130
        '
        'COL_IS_DR_CR
        '
        Me.COL_IS_DR_CR.DataPropertyName = "IS_DR_CR"
        Me.COL_IS_DR_CR.HeaderText = "DH"
        Me.COL_IS_DR_CR.Name = "COL_IS_DR_CR"
        Me.COL_IS_DR_CR.ReadOnly = True
        Me.COL_IS_DR_CR.Visible = False
        Me.COL_IS_DR_CR.Width = 40
        '
        'COL_DOCUMENT_REF
        '
        Me.COL_DOCUMENT_REF.DataPropertyName = "DOCUMENT_REF"
        Me.COL_DOCUMENT_REF.HeaderText = "TD_Ref"
        Me.COL_DOCUMENT_REF.Name = "COL_DOCUMENT_REF"
        Me.COL_DOCUMENT_REF.ReadOnly = True
        Me.COL_DOCUMENT_REF.Visible = False
        Me.COL_DOCUMENT_REF.Width = 35
        '
        'COL_NUMBER_REF
        '
        Me.COL_NUMBER_REF.DataPropertyName = "NUMBER_REF"
        Me.COL_NUMBER_REF.HeaderText = "ND_Ref"
        Me.COL_NUMBER_REF.Name = "COL_NUMBER_REF"
        Me.COL_NUMBER_REF.ReadOnly = True
        Me.COL_NUMBER_REF.Visible = False
        Me.COL_NUMBER_REF.Width = 70
        '
        'COL_AMOUNT_BALANCE_INI
        '
        Me.COL_AMOUNT_BALANCE_INI.DataPropertyName = "AMOUNT_BALANCE_INI"
        DataGridViewCellStyle8.Format = "N2"
        Me.COL_AMOUNT_BALANCE_INI.DefaultCellStyle = DataGridViewCellStyle8
        Me.COL_AMOUNT_BALANCE_INI.HeaderText = "Saldo Inicial"
        Me.COL_AMOUNT_BALANCE_INI.Name = "COL_AMOUNT_BALANCE_INI"
        Me.COL_AMOUNT_BALANCE_INI.ReadOnly = True
        Me.COL_AMOUNT_BALANCE_INI.Width = 80
        '
        'CODIGO_CLIENTE
        '
        Me.CODIGO_CLIENTE.DataPropertyName = "CODIGO_CLIENTE"
        Me.CODIGO_CLIENTE.HeaderText = "CODIGO_CLIENTE"
        Me.CODIGO_CLIENTE.Name = "CODIGO_CLIENTE"
        Me.CODIGO_CLIENTE.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(462, 318)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(46, 21)
        Me.TextBox1.TabIndex = 218
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(26, 321)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 13)
        Me.Label15.TabIndex = 217
        Me.Label15.Text = "Situacion de Estado"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(509, 318)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(99, 21)
        Me.TextBox2.TabIndex = 219
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(187, 319)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox3.TabIndex = 216
        Me.PictureBox3.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(208, 318)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(248, 21)
        Me.TextBox3.TabIndex = 204
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(139, 318)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(46, 21)
        Me.TextBox4.TabIndex = 203
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox5)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Controls.Add(Me.TextBox7)
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(595, 58)
        Me.GroupBox4.TabIndex = 215
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Situacion anterior de la letra"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(64, 34)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox5.TabIndex = 217
        Me.PictureBox5.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(444, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 198
        Me.Label16.Text = "Moneda"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(14, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 197
        Me.Label17.Text = "Codigo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(102, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 13)
        Me.Label18.TabIndex = 196
        Me.Label18.Text = "Descripcion del estado"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(496, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 13)
        Me.Label19.TabIndex = 194
        Me.Label19.Text = "Cuenta contable"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(90, 33)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(345, 21)
        Me.TextBox5.TabIndex = 190
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(445, 33)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(46, 21)
        Me.TextBox6.TabIndex = 191
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(12, 33)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(46, 21)
        Me.TextBox7.TabIndex = 189
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(493, 33)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(99, 21)
        Me.TextBox8.TabIndex = 192
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(408, 399)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 212
        Me.DateTimePicker1.Visible = False
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(25, 402)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 13)
        Me.Label21.TabIndex = 211
        Me.Label21.Text = "Fecha Actualizacion"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(139, 372)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(469, 21)
        Me.ComboBox1.TabIndex = 210
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(42, 375)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 13)
        Me.Label22.TabIndex = 209
        Me.Label22.Text = "Cuenta Corriente"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(187, 346)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox4.TabIndex = 208
        Me.PictureBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(195, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 38)
        Me.Button1.TabIndex = 201
        Me.Button1.Text = "&Generar Cambio de Estado"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(90, 348)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 13)
        Me.Label23.TabIndex = 207
        Me.Label23.Text = "Banco"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox9.Location = New System.Drawing.Point(208, 345)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(400, 21)
        Me.TextBox9.TabIndex = 206
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox10.Location = New System.Drawing.Point(139, 345)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(46, 21)
        Me.TextBox10.TabIndex = 205
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Location = New System.Drawing.Point(341, 431)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 38)
        Me.Button2.TabIndex = 202
        Me.Button2.Text = "&Retornar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmAceptacionLetras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(902, 524)
        Me.Controls.Add(Me.PnlCambioestadogrupal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAceptacionLetras"
        Me.Text = "Cambio de estado de letras cobranzas"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PnlCambioestadogrupal.ResumeLayout(False)
        Me.PnlCambioestadogrupal.PerformLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents btnCambiarEstado As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoletra As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionSituacion As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoSituacion As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtbanco As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtComentario As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaActualizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnumeracionBancaria As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtmoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion_estado As System.Windows.Forms.TextBox
    Friend WithEvents txtmoneda_estado As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo_estado As System.Windows.Forms.TextBox
    Friend WithEvents txtcuentacontable_estado As System.Windows.Forms.TextBox
    Friend WithEvents txtmonedaSituacion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcuentasituacion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PnlCambioestadogrupal As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgv_pendientes As System.Windows.Forms.DataGridView
    Friend WithEvents chktodos As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Private WithEvents mtb_fec_emi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_estados As System.Windows.Forms.ComboBox
    Friend WithEvents chk_sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents COL_DOCUMENT_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_NUM_DOC_AUX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TERCERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_COD_MON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_TC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_MONTO_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DOC_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_CADUCATE_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_SALES_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_SALES_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_IS_DR_CR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DOCUMENT_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_NUMBER_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_AMOUNT_BALANCE_INI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
