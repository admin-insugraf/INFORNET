<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChequesPagos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChequesPagos))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalRetME = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtTotalLetraME = New System.Windows.Forms.TextBox()
        Me.txtTotalRetMN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalLetraMN = New System.Windows.Forms.TextBox()
        Me.dgvDetalleLetra = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro_Letra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_emision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idbanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanjeMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanjeME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetencMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetencME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCorrelativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDomingo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbCabeceraLetra = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_sel = New System.Windows.Forms.Label()
        Me.lbl_tot = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txttotalME = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtImporteME = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttotalMN = New System.Windows.Forms.TextBox()
        Me.BtnGenerarLetra = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImporteMN = New System.Windows.Forms.TextBox()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtRucDni = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtcomentario = New System.Windows.Forms.RichTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancelarLetra = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.txtNLetras = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_anular = New System.Windows.Forms.ToolStripButton()
        Me.btn_ImprimirPlanilla = New System.Windows.Forms.ToolStripButton()
        Me.btn_ImprimirLetra = New System.Windows.Forms.ToolStripButton()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnsalir = New System.Windows.Forms.ToolStripButton()
        Me.PnlDocumentos = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgvLetra = New System.Windows.Forms.DataGridView()
        Me.dgvPlanilla = New System.Windows.Forms.DataGridView()
        Me.PnlFiltros = New System.Windows.Forms.Panel()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalleLetra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCabeceraLetra.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.PnlDocumentos.SuspendLayout()
        CType(Me.dgvLetra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFiltros.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtTotalRetME)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.txtTotalLetraME)
        Me.GroupBox3.Controls.Add(Me.txtTotalRetMN)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtTotalLetraMN)
        Me.GroupBox3.Controls.Add(Me.dgvDetalleLetra)
        Me.GroupBox3.Controls.Add(Me.lblDomingo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1121, 211)
        Me.GroupBox3.TabIndex = 178
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Detalle del Cheque"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(399, 187)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(70, 13)
        Me.Label31.TabIndex = 154
        Me.Label31.Text = "Total Ret ME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(756, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "Total Cheque ME"
        '
        'txtTotalRetME
        '
        Me.txtTotalRetME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalRetME.Location = New System.Drawing.Point(483, 185)
        Me.txtTotalRetME.Name = "txtTotalRetME"
        Me.txtTotalRetME.ReadOnly = True
        Me.txtTotalRetME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalRetME.Size = New System.Drawing.Size(76, 20)
        Me.txtTotalRetME.TabIndex = 153
        Me.txtTotalRetME.Text = "0.00"
        Me.txtTotalRetME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(243, 187)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(71, 13)
        Me.Label32.TabIndex = 152
        Me.Label32.Text = "Total Ret MN"
        '
        'txtTotalLetraME
        '
        Me.txtTotalLetraME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalLetraME.Location = New System.Drawing.Point(852, 185)
        Me.txtTotalLetraME.Name = "txtTotalLetraME"
        Me.txtTotalLetraME.ReadOnly = True
        Me.txtTotalLetraME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalLetraME.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalLetraME.TabIndex = 134
        Me.txtTotalLetraME.Text = "0.00"
        Me.txtTotalLetraME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalRetMN
        '
        Me.txtTotalRetMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalRetMN.Location = New System.Drawing.Point(320, 185)
        Me.txtTotalRetMN.Name = "txtTotalRetMN"
        Me.txtTotalRetMN.ReadOnly = True
        Me.txtTotalRetMN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalRetMN.Size = New System.Drawing.Size(73, 20)
        Me.txtTotalRetMN.TabIndex = 151
        Me.txtTotalRetMN.Text = "0.00"
        Me.txtTotalRetMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(565, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "Total Cheque MN"
        '
        'txtTotalLetraMN
        '
        Me.txtTotalLetraMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalLetraMN.Location = New System.Drawing.Point(662, 185)
        Me.txtTotalLetraMN.Name = "txtTotalLetraMN"
        Me.txtTotalLetraMN.ReadOnly = True
        Me.txtTotalLetraMN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalLetraMN.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalLetraMN.TabIndex = 132
        Me.txtTotalLetraMN.Text = "0.00"
        Me.txtTotalLetraMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalleLetra
        '
        Me.dgvDetalleLetra.AllowUserToAddRows = False
        Me.dgvDetalleLetra.AllowUserToDeleteRows = False
        Me.dgvDetalleLetra.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleLetra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalleLetra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleLetra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Nro_Letra, Me.fecha_emision, Me.Vencimiento, Me.idbanco, Me.banco, Me.Plazo, Me.CanjeMN, Me.CanjeME, Me.RetencMN, Me.RetencME, Me.LetraMN, Me.LetraME, Me.NroCorrelativo, Me.FechaVencimiento})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalleLetra.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetalleLetra.Location = New System.Drawing.Point(7, 19)
        Me.dgvDetalleLetra.Name = "dgvDetalleLetra"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleLetra.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalleLetra.RowHeadersWidth = 24
        Me.dgvDetalleLetra.Size = New System.Drawing.Size(1106, 159)
        Me.dgvDetalleLetra.TabIndex = 9
        '
        'Item
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Item.DefaultCellStyle = DataGridViewCellStyle2
        Me.Item.HeaderText = "#"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 30
        '
        'Nro_Letra
        '
        Me.Nro_Letra.FillWeight = 61.22011!
        Me.Nro_Letra.HeaderText = "Nro Cheque"
        Me.Nro_Letra.MaxInputLength = 10
        Me.Nro_Letra.Name = "Nro_Letra"
        Me.Nro_Letra.Width = 80
        '
        'fecha_emision
        '
        Me.fecha_emision.FillWeight = 61.22011!
        Me.fecha_emision.HeaderText = "F. Emision"
        Me.fecha_emision.Name = "fecha_emision"
        Me.fecha_emision.ReadOnly = True
        Me.fecha_emision.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fecha_emision.Width = 120
        '
        'Vencimiento
        '
        Me.Vencimiento.FillWeight = 61.22011!
        Me.Vencimiento.HeaderText = "F. de Cobro"
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.ReadOnly = True
        Me.Vencimiento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Vencimiento.Width = 120
        '
        'idbanco
        '
        Me.idbanco.HeaderText = "Cod. Banco"
        Me.idbanco.Name = "idbanco"
        '
        'banco
        '
        Me.banco.HeaderText = "Banco"
        Me.banco.Name = "banco"
        '
        'Plazo
        '
        Me.Plazo.FillWeight = 149.7006!
        Me.Plazo.HeaderText = "Plazo"
        Me.Plazo.Name = "Plazo"
        Me.Plazo.Visible = False
        Me.Plazo.Width = 50
        '
        'CanjeMN
        '
        Me.CanjeMN.FillWeight = 104.6497!
        Me.CanjeMN.HeaderText = "Canje MN"
        Me.CanjeMN.Name = "CanjeMN"
        Me.CanjeMN.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CanjeMN.Width = 80
        '
        'CanjeME
        '
        Me.CanjeME.FillWeight = 123.2094!
        Me.CanjeME.HeaderText = "Canje ME"
        Me.CanjeME.Name = "CanjeME"
        Me.CanjeME.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CanjeME.Width = 80
        '
        'RetencMN
        '
        Me.RetencMN.HeaderText = "Retenc. MN"
        Me.RetencMN.Name = "RetencMN"
        Me.RetencMN.ReadOnly = True
        Me.RetencMN.Width = 60
        '
        'RetencME
        '
        Me.RetencME.HeaderText = "Retenc. ME"
        Me.RetencME.Name = "RetencME"
        Me.RetencME.ReadOnly = True
        Me.RetencME.Width = 60
        '
        'LetraMN
        '
        Me.LetraMN.HeaderText = "Cheque MN"
        Me.LetraMN.Name = "LetraMN"
        Me.LetraMN.ReadOnly = True
        '
        'LetraME
        '
        Me.LetraME.HeaderText = "Cheque ME"
        Me.LetraME.Name = "LetraME"
        Me.LetraME.ReadOnly = True
        '
        'NroCorrelativo
        '
        Me.NroCorrelativo.HeaderText = "NroCorrelativo"
        Me.NroCorrelativo.Name = "NroCorrelativo"
        Me.NroCorrelativo.Visible = False
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.HeaderText = "FechaVencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Visible = False
        '
        'lblDomingo
        '
        Me.lblDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDomingo.AutoSize = True
        Me.lblDomingo.ForeColor = System.Drawing.Color.Red
        Me.lblDomingo.Location = New System.Drawing.Point(121, 184)
        Me.lblDomingo.Name = "lblDomingo"
        Me.lblDomingo.Size = New System.Drawing.Size(13, 13)
        Me.lblDomingo.TabIndex = 5
        Me.lblDomingo.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(25, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Día(s) no hábiles:"
        '
        'gbCabeceraLetra
        '
        Me.gbCabeceraLetra.Controls.Add(Me.GroupBox2)
        Me.gbCabeceraLetra.Controls.Add(Me.GroupBox1)
        Me.gbCabeceraLetra.Location = New System.Drawing.Point(6, 31)
        Me.gbCabeceraLetra.Name = "gbCabeceraLetra"
        Me.gbCabeceraLetra.Size = New System.Drawing.Size(1121, 296)
        Me.gbCabeceraLetra.TabIndex = 180
        Me.gbCabeceraLetra.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_sel)
        Me.GroupBox2.Controls.Add(Me.lbl_tot)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txttotalME)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtImporteME)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txttotalMN)
        Me.GroupBox2.Controls.Add(Me.BtnGenerarLetra)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtImporteMN)
        Me.GroupBox2.Controls.Add(Me.dgvDocumentos)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1107, 229)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Datos de Documentos:"
        '
        'lbl_sel
        '
        Me.lbl_sel.ForeColor = System.Drawing.Color.Navy
        Me.lbl_sel.Location = New System.Drawing.Point(18, 201)
        Me.lbl_sel.Name = "lbl_sel"
        Me.lbl_sel.Size = New System.Drawing.Size(175, 15)
        Me.lbl_sel.TabIndex = 133
        Me.lbl_sel.Text = "..."
        '
        'lbl_tot
        '
        Me.lbl_tot.ForeColor = System.Drawing.Color.Navy
        Me.lbl_tot.Location = New System.Drawing.Point(18, 182)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(175, 15)
        Me.lbl_tot.TabIndex = 132
        Me.lbl_tot.Text = "..."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(924, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "Total Canje ME"
        '
        'txttotalME
        '
        Me.txttotalME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalME.Location = New System.Drawing.Point(1009, 198)
        Me.txttotalME.Name = "txttotalME"
        Me.txttotalME.ReadOnly = True
        Me.txttotalME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttotalME.Size = New System.Drawing.Size(85, 20)
        Me.txttotalME.TabIndex = 130
        Me.txttotalME.Text = "0.00"
        Me.txttotalME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(917, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Importa Canje ME"
        '
        'txtImporteME
        '
        Me.txtImporteME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporteME.Location = New System.Drawing.Point(1009, 177)
        Me.txtImporteME.Name = "txtImporteME"
        Me.txtImporteME.ReadOnly = True
        Me.txtImporteME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteME.Size = New System.Drawing.Size(85, 20)
        Me.txtImporteME.TabIndex = 128
        Me.txtImporteME.Text = "0.00"
        Me.txtImporteME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(743, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "Total Canje MN"
        '
        'txttotalMN
        '
        Me.txttotalMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalMN.Location = New System.Drawing.Point(826, 199)
        Me.txttotalMN.Name = "txttotalMN"
        Me.txttotalMN.ReadOnly = True
        Me.txttotalMN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttotalMN.Size = New System.Drawing.Size(88, 20)
        Me.txttotalMN.TabIndex = 126
        Me.txttotalMN.Text = "0.00"
        Me.txttotalMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnGenerarLetra
        '
        Me.BtnGenerarLetra.Image = CType(resources.GetObject("BtnGenerarLetra.Image"), System.Drawing.Image)
        Me.BtnGenerarLetra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGenerarLetra.Location = New System.Drawing.Point(574, 177)
        Me.BtnGenerarLetra.Name = "BtnGenerarLetra"
        Me.BtnGenerarLetra.Size = New System.Drawing.Size(119, 31)
        Me.BtnGenerarLetra.TabIndex = 125
        Me.BtnGenerarLetra.Text = "&Generar Cheque"
        Me.BtnGenerarLetra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGenerarLetra.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(733, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Importa Canje MN"
        '
        'txtImporteMN
        '
        Me.txtImporteMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporteMN.Location = New System.Drawing.Point(826, 178)
        Me.txtImporteMN.Name = "txtImporteMN"
        Me.txtImporteMN.ReadOnly = True
        Me.txtImporteMN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteMN.Size = New System.Drawing.Size(88, 20)
        Me.txtImporteMN.TabIndex = 119
        Me.txtImporteMN.Text = "0.00"
        Me.txtImporteMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        Me.dgvDocumentos.AllowUserToDeleteRows = False
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(12, 19)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(1082, 152)
        Me.dgvDocumentos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.cmbtipo)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.txtRucDni)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1107, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Datos del Proveedor :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(1106, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(95, 13)
        Me.Label37.TabIndex = 127
        Me.Label37.Text = "Tipo de Operación"
        Me.Label37.Visible = False
        '
        'cmbtipo
        '
        Me.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Canje por Letras", "Renovacion de Letras"})
        Me.cmbtipo.Location = New System.Drawing.Point(1150, 13)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(220, 25)
        Me.cmbtipo.TabIndex = 126
        Me.cmbtipo.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(167, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.White
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Location = New System.Drawing.Point(475, 16)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(619, 20)
        Me.txtRazonSocial.TabIndex = 119
        '
        'txtRucDni
        '
        Me.txtRucDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRucDni.Location = New System.Drawing.Point(250, 16)
        Me.txtRucDni.Name = "txtRucDni"
        Me.txtRucDni.Size = New System.Drawing.Size(98, 20)
        Me.txtRucDni.TabIndex = 118
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Location = New System.Drawing.Point(63, 16)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(98, 20)
        Me.txtCodCliente.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(358, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Razón social / Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Ruc/ Dni"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Proveedor"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtcomentario)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.BtnCancelarLetra)
        Me.GroupBox4.Controls.Add(Me.dtpFecha)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cmb_moneda)
        Me.GroupBox4.Controls.Add(Me.btnMenos)
        Me.GroupBox4.Controls.Add(Me.btnMas)
        Me.GroupBox4.Controls.Add(Me.txtNLetras)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(6, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1121, 68)
        Me.GroupBox4.TabIndex = 179
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de Canje de Cheques"
        '
        'txtcomentario
        '
        Me.txtcomentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomentario.Location = New System.Drawing.Point(7, 41)
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(790, 21)
        Me.txtcomentario.TabIndex = 139
        Me.txtcomentario.Text = ""
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(328, 43)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(70, 13)
        Me.Label35.TabIndex = 138
        Me.Label35.Text = "Observacion:"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCambio.Location = New System.Drawing.Point(1034, 15)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(66, 20)
        Me.txtTipoCambio.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(963, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo Cambio:"
        '
        'BtnCancelarLetra
        '
        Me.BtnCancelarLetra.Image = CType(resources.GetObject("BtnCancelarLetra.Image"), System.Drawing.Image)
        Me.BtnCancelarLetra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarLetra.Location = New System.Drawing.Point(829, 38)
        Me.BtnCancelarLetra.Name = "BtnCancelarLetra"
        Me.BtnCancelarLetra.Size = New System.Drawing.Size(111, 24)
        Me.BtnCancelarLetra.TabIndex = 137
        Me.BtnCancelarLetra.Text = "&Cancelar canje "
        Me.BtnCancelarLetra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelarLetra.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Checked = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(101, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(4, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha de Emision"
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(580, 16)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(214, 21)
        Me.cmb_moneda.TabIndex = 8
        '
        'btnMenos
        '
        Me.btnMenos.Location = New System.Drawing.Point(442, 15)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(27, 23)
        Me.btnMenos.TabIndex = 3
        Me.btnMenos.Text = "-"
        Me.btnMenos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnMas
        '
        Me.btnMas.Location = New System.Drawing.Point(416, 15)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(27, 23)
        Me.btnMas.TabIndex = 2
        Me.btnMas.Text = "+"
        Me.btnMas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'txtNLetras
        '
        Me.txtNLetras.Location = New System.Drawing.Point(375, 17)
        Me.txtNLetras.MaxLength = 2
        Me.txtNLetras.Name = "txtNLetras"
        Me.txtNLetras.ReadOnly = True
        Me.txtNLetras.Size = New System.Drawing.Size(40, 20)
        Me.txtNLetras.TabIndex = 1
        Me.txtNLetras.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(279, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nro. de Cheques:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(528, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Moneda"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.BtnGuardar, Me.btnEliminar, Me.btn_anular, Me.btn_ImprimirPlanilla, Me.btn_ImprimirLetra, Me.btnAceptar, Me.ToolStripButton2, Me.BtnCancelar, Me.ToolStripButton1, Me.btnsalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1135, 25)
        Me.ToolStrip1.TabIndex = 181
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Navy
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 22)
        Me.btnNuevo.Text = "&Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Navy
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(65, 22)
        Me.BtnGuardar.Text = "&Grabar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(71, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'btn_anular
        '
        Me.btn_anular.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_anular.ForeColor = System.Drawing.Color.Navy
        Me.btn_anular.Image = CType(resources.GetObject("btn_anular.Image"), System.Drawing.Image)
        Me.btn_anular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(63, 22)
        Me.btn_anular.Text = "&Anular"
        '
        'btn_ImprimirPlanilla
        '
        Me.btn_ImprimirPlanilla.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ImprimirPlanilla.ForeColor = System.Drawing.Color.Navy
        Me.btn_ImprimirPlanilla.Image = CType(resources.GetObject("btn_ImprimirPlanilla.Image"), System.Drawing.Image)
        Me.btn_ImprimirPlanilla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ImprimirPlanilla.Name = "btn_ImprimirPlanilla"
        Me.btn_ImprimirPlanilla.Size = New System.Drawing.Size(117, 22)
        Me.btn_ImprimirPlanilla.Text = "Imprimir &Planilla"
        Me.btn_ImprimirPlanilla.Visible = False
        '
        'btn_ImprimirLetra
        '
        Me.btn_ImprimirLetra.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ImprimirLetra.ForeColor = System.Drawing.Color.Navy
        Me.btn_ImprimirLetra.Image = CType(resources.GetObject("btn_ImprimirLetra.Image"), System.Drawing.Image)
        Me.btn_ImprimirLetra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ImprimirLetra.Name = "btn_ImprimirLetra"
        Me.btn_ImprimirLetra.Size = New System.Drawing.Size(121, 22)
        Me.btn_ImprimirLetra.Text = "&Imprimir Cheque"
        Me.btn_ImprimirLetra.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAceptar.ForeColor = System.Drawing.Color.Navy
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(103, 22)
        Me.btnAceptar.Text = "&Aceptar Letra"
        Me.btnAceptar.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripButton2.Text = "Cambiar F. Vcto."
        Me.ToolStripButton2.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Navy
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(74, 22)
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripButton1.Text = "Cam&biar Estado"
        Me.ToolStripButton1.Visible = False
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.Navy
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(51, 22)
        Me.btnsalir.Text = "&Salir"
        '
        'PnlDocumentos
        '
        Me.PnlDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlDocumentos.Controls.Add(Me.Label9)
        Me.PnlDocumentos.Controls.Add(Me.lblCantidad)
        Me.PnlDocumentos.Controls.Add(Me.dgvLetra)
        Me.PnlDocumentos.Controls.Add(Me.dgvPlanilla)
        Me.PnlDocumentos.Location = New System.Drawing.Point(5, 90)
        Me.PnlDocumentos.Name = "PnlDocumentos"
        Me.PnlDocumentos.Size = New System.Drawing.Size(1122, 528)
        Me.PnlDocumentos.TabIndex = 182
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(9, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 13)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "&Detalle de la Panilla. ( Cheques )"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(10, 508)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 119
        Me.lblCantidad.Text = "."
        '
        'dgvLetra
        '
        Me.dgvLetra.AllowUserToAddRows = False
        Me.dgvLetra.AllowUserToDeleteRows = False
        Me.dgvLetra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLetra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLetra.Location = New System.Drawing.Point(7, 294)
        Me.dgvLetra.Name = "dgvLetra"
        Me.dgvLetra.ReadOnly = True
        Me.dgvLetra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLetra.Size = New System.Drawing.Size(1108, 212)
        Me.dgvLetra.TabIndex = 1
        '
        'dgvPlanilla
        '
        Me.dgvPlanilla.AllowUserToAddRows = False
        Me.dgvPlanilla.AllowUserToDeleteRows = False
        Me.dgvPlanilla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanilla.Location = New System.Drawing.Point(7, 15)
        Me.dgvPlanilla.Name = "dgvPlanilla"
        Me.dgvPlanilla.ReadOnly = True
        Me.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlanilla.Size = New System.Drawing.Size(1107, 254)
        Me.dgvPlanilla.TabIndex = 0
        '
        'PnlFiltros
        '
        Me.PnlFiltros.Controls.Add(Me.gbFiltros)
        Me.PnlFiltros.Controls.Add(Me.GroupBox8)
        Me.PnlFiltros.Controls.Add(Me.gbRangofechas)
        Me.PnlFiltros.Location = New System.Drawing.Point(5, 35)
        Me.PnlFiltros.Name = "PnlFiltros"
        Me.PnlFiltros.Size = New System.Drawing.Size(1122, 55)
        Me.PnlFiltros.TabIndex = 183
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(6, 3)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(296, 47)
        Me.gbFiltros.TabIndex = 142
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(6, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(280, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(307, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(174, 45)
        Me.GroupBox8.TabIndex = 146
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(156, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label29)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label30)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(482, 4)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(340, 45)
        Me.gbRangofechas.TabIndex = 147
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(172, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(62, 13)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(239, 15)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(93, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(7, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(66, 13)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Fecha inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(75, 13)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(93, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'FrmChequesPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1135, 623)
        Me.Controls.Add(Me.PnlDocumentos)
        Me.Controls.Add(Me.PnlFiltros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbCabeceraLetra)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmChequesPagos"
        Me.Text = "Cheques de Pagos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvDetalleLetra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCabeceraLetra.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PnlDocumentos.ResumeLayout(False)
        Me.PnlDocumentos.PerformLayout()
        CType(Me.dgvLetra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFiltros.ResumeLayout(False)
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRetME As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLetraME As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalRetMN As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLetraMN As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalleLetra As System.Windows.Forms.DataGridView
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro_Letra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_emision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idbanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Plazo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanjeMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanjeME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetencMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetencME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetraMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetraME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroCorrelativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDomingo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbCabeceraLetra As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_sel As System.Windows.Forms.Label
    Friend WithEvents lbl_tot As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txttotalME As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtImporteME As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txttotalMN As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenerarLetra As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtImporteMN As System.Windows.Forms.TextBox
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtRucDni As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcomentario As System.Windows.Forms.RichTextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelarLetra As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents btnMenos As System.Windows.Forms.Button
    Friend WithEvents btnMas As System.Windows.Forms.Button
    Friend WithEvents txtNLetras As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_anular As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_ImprimirPlanilla As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_ImprimirLetra As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnsalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents PnlDocumentos As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dgvLetra As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPlanilla As System.Windows.Forms.DataGridView
    Friend WithEvents PnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
End Class
