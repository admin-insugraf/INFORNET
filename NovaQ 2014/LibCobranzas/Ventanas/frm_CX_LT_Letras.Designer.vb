<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_LT_Letras
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_LT_Letras))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gb_cliente = New System.Windows.Forms.GroupBox()
        Me.lbl_sel = New System.Windows.Forms.Label()
        Me.lbl_tot = New System.Windows.Forms.Label()
        Me.btn_mostrar_docs = New System.Windows.Forms.Button()
        Me.btn_busca_cli = New System.Windows.Forms.Button()
        Me.txt_cod_ane = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_des_ane = New System.Windows.Forms.TextBox()
        Me.dgv_letras = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fec_ven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.is_ori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_pendientes = New System.Windows.Forms.DataGridView()
        Me.chk_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.COL_DOCUMENT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_SERIE_AUX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_NUM_DOC_AUX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_MONTO_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_MONTO_CO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_COD_MON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_TC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DOC_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_CADUCATE_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_SALES_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_IS_DR_CR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DOCUMENT_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_NUMBER_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_AMOUNT_BALANCE_INI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtb_total_cob = New System.Windows.Forms.TextBox()
        Me.mtb_total_letra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_reg_letras = New System.Windows.Forms.Button()
        Me.gb_cliente.SuspendLayout()
        CType(Me.dgv_letras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_cliente
        '
        Me.gb_cliente.Controls.Add(Me.lbl_sel)
        Me.gb_cliente.Controls.Add(Me.lbl_tot)
        Me.gb_cliente.Controls.Add(Me.btn_mostrar_docs)
        Me.gb_cliente.Controls.Add(Me.btn_busca_cli)
        Me.gb_cliente.Controls.Add(Me.txt_cod_ane)
        Me.gb_cliente.Controls.Add(Me.Label8)
        Me.gb_cliente.Controls.Add(Me.txt_des_ane)
        Me.gb_cliente.Location = New System.Drawing.Point(12, 29)
        Me.gb_cliente.Name = "gb_cliente"
        Me.gb_cliente.Size = New System.Drawing.Size(756, 51)
        Me.gb_cliente.TabIndex = 5
        Me.gb_cliente.TabStop = False
        '
        'lbl_sel
        '
        Me.lbl_sel.Location = New System.Drawing.Point(570, 31)
        Me.lbl_sel.Name = "lbl_sel"
        Me.lbl_sel.Size = New System.Drawing.Size(175, 15)
        Me.lbl_sel.TabIndex = 37
        Me.lbl_sel.Text = "..."
        '
        'lbl_tot
        '
        Me.lbl_tot.Location = New System.Drawing.Point(570, 12)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(175, 15)
        Me.lbl_tot.TabIndex = 36
        Me.lbl_tot.Text = "..."
        '
        'btn_mostrar_docs
        '
        Me.btn_mostrar_docs.Image = Global.LibCobranzas.My.Resources.Resources.bill_26
        Me.btn_mostrar_docs.Location = New System.Drawing.Point(455, 12)
        Me.btn_mostrar_docs.Name = "btn_mostrar_docs"
        Me.btn_mostrar_docs.Size = New System.Drawing.Size(41, 35)
        Me.btn_mostrar_docs.TabIndex = 21
        Me.btn_mostrar_docs.UseVisualStyleBackColor = True
        '
        'btn_busca_cli
        '
        Me.btn_busca_cli.Image = Global.LibCobranzas.My.Resources.Resources.find_user_26
        Me.btn_busca_cli.Location = New System.Drawing.Point(408, 11)
        Me.btn_busca_cli.Name = "btn_busca_cli"
        Me.btn_busca_cli.Size = New System.Drawing.Size(41, 35)
        Me.btn_busca_cli.TabIndex = 20
        Me.btn_busca_cli.UseVisualStyleBackColor = True
        '
        'txt_cod_ane
        '
        Me.txt_cod_ane.Location = New System.Drawing.Point(49, 19)
        Me.txt_cod_ane.Name = "txt_cod_ane"
        Me.txt_cod_ane.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_ane.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cliente"
        '
        'txt_des_ane
        '
        Me.txt_des_ane.Location = New System.Drawing.Point(149, 19)
        Me.txt_des_ane.Name = "txt_des_ane"
        Me.txt_des_ane.ReadOnly = True
        Me.txt_des_ane.Size = New System.Drawing.Size(253, 20)
        Me.txt_des_ane.TabIndex = 19
        '
        'dgv_letras
        '
        Me.dgv_letras.AllowUserToAddRows = False
        Me.dgv_letras.AllowUserToDeleteRows = False
        Me.dgv_letras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_letras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.TipDoc, Me.NumDoc, Me.Monto, Me.Fec_ven, Me.is_ori})
        Me.dgv_letras.Location = New System.Drawing.Point(12, 280)
        Me.dgv_letras.Name = "dgv_letras"
        Me.dgv_letras.Size = New System.Drawing.Size(496, 150)
        Me.dgv_letras.TabIndex = 9
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 40
        '
        'TipDoc
        '
        Me.TipDoc.HeaderText = "TipDoc"
        Me.TipDoc.Name = "TipDoc"
        Me.TipDoc.ReadOnly = True
        Me.TipDoc.Width = 50
        '
        'NumDoc
        '
        Me.NumDoc.HeaderText = "Num Doc"
        Me.NumDoc.Name = "NumDoc"
        Me.NumDoc.ReadOnly = True
        Me.NumDoc.Width = 70
        '
        'Monto
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle1
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Fec_ven
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        Me.Fec_ven.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fec_ven.HeaderText = "Fec. vencto"
        Me.Fec_ven.Name = "Fec_ven"
        '
        'is_ori
        '
        Me.is_ori.HeaderText = "Doc. Orig"
        Me.is_ori.Name = "is_ori"
        Me.is_ori.ReadOnly = True
        Me.is_ori.Width = 50
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(12, 249)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(28, 27)
        Me.btn_agregar.TabIndex = 10
        Me.btn_agregar.Text = "+"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Location = New System.Drawing.Point(46, 249)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(28, 27)
        Me.btn_quitar.TabIndex = 10
        Me.btn_quitar.Text = "-"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Salir, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(780, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = CType(resources.GetObject("Tool_Nuevo.Image"), System.Drawing.Image)
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
        'Tool_Salir
        '
        Me.Tool_Salir.Image = CType(resources.GetObject("Tool_Salir.Image"), System.Drawing.Image)
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(601, 240)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Total Cobranza"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Total Letras"
        '
        'dgv_pendientes
        '
        Me.dgv_pendientes.AllowUserToAddRows = False
        Me.dgv_pendientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_pendientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk_sel, Me.COL_DOCUMENT_ID, Me.COL_SERIE_AUX, Me.COL_NUM_DOC_AUX, Me.COL_MONTO_SALDO, Me.COL_MONTO_CO, Me.COL_COD_MON, Me.COL_TC, Me.COL_DOC_DATE, Me.COL_CADUCATE_DATE, Me.COL_SALES_ID, Me.COL_IS_DR_CR, Me.COL_DOCUMENT_REF, Me.COL_NUMBER_REF, Me.COL_AMOUNT_BALANCE_INI})
        Me.dgv_pendientes.Location = New System.Drawing.Point(12, 86)
        Me.dgv_pendientes.Name = "dgv_pendientes"
        Me.dgv_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pendientes.Size = New System.Drawing.Size(756, 145)
        Me.dgv_pendientes.TabIndex = 39
        '
        'chk_sel
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.NullValue = False
        Me.chk_sel.DefaultCellStyle = DataGridViewCellStyle4
        Me.chk_sel.Frozen = True
        Me.chk_sel.HeaderText = "Sel"
        Me.chk_sel.Name = "chk_sel"
        Me.chk_sel.Width = 30
        '
        'COL_DOCUMENT_ID
        '
        Me.COL_DOCUMENT_ID.DataPropertyName = "DOCUMENT_ID"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COL_DOCUMENT_ID.DefaultCellStyle = DataGridViewCellStyle5
        Me.COL_DOCUMENT_ID.HeaderText = "TD"
        Me.COL_DOCUMENT_ID.Name = "COL_DOCUMENT_ID"
        Me.COL_DOCUMENT_ID.ReadOnly = True
        Me.COL_DOCUMENT_ID.Width = 40
        '
        'COL_SERIE_AUX
        '
        Me.COL_SERIE_AUX.DataPropertyName = "SERIE_AUX"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COL_SERIE_AUX.DefaultCellStyle = DataGridViewCellStyle6
        Me.COL_SERIE_AUX.HeaderText = "SD"
        Me.COL_SERIE_AUX.Name = "COL_SERIE_AUX"
        Me.COL_SERIE_AUX.ReadOnly = True
        Me.COL_SERIE_AUX.Width = 40
        '
        'COL_NUM_DOC_AUX
        '
        Me.COL_NUM_DOC_AUX.DataPropertyName = "NUM_DOC_AUX"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COL_NUM_DOC_AUX.DefaultCellStyle = DataGridViewCellStyle7
        Me.COL_NUM_DOC_AUX.HeaderText = "ND"
        Me.COL_NUM_DOC_AUX.Name = "COL_NUM_DOC_AUX"
        Me.COL_NUM_DOC_AUX.ReadOnly = True
        Me.COL_NUM_DOC_AUX.Width = 55
        '
        'COL_MONTO_SALDO
        '
        Me.COL_MONTO_SALDO.DataPropertyName = "MONTO"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "##,##0.00"
        Me.COL_MONTO_SALDO.DefaultCellStyle = DataGridViewCellStyle8
        Me.COL_MONTO_SALDO.HeaderText = "Monto"
        Me.COL_MONTO_SALDO.Name = "COL_MONTO_SALDO"
        Me.COL_MONTO_SALDO.ReadOnly = True
        Me.COL_MONTO_SALDO.Width = 70
        '
        'COL_MONTO_CO
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.Format = "####0.00"
        Me.COL_MONTO_CO.DefaultCellStyle = DataGridViewCellStyle9
        Me.COL_MONTO_CO.HeaderText = "Cobrar"
        Me.COL_MONTO_CO.Name = "COL_MONTO_CO"
        Me.COL_MONTO_CO.Width = 70
        '
        'COL_COD_MON
        '
        Me.COL_COD_MON.DataPropertyName = "COD_MON"
        Me.COL_COD_MON.HeaderText = "Mon"
        Me.COL_COD_MON.Name = "COL_COD_MON"
        Me.COL_COD_MON.ReadOnly = True
        Me.COL_COD_MON.Width = 40
        '
        'COL_TC
        '
        Me.COL_TC.DataPropertyName = "TC"
        DataGridViewCellStyle10.Format = "N3"
        Me.COL_TC.DefaultCellStyle = DataGridViewCellStyle10
        Me.COL_TC.HeaderText = "TC"
        Me.COL_TC.Name = "COL_TC"
        Me.COL_TC.ReadOnly = True
        Me.COL_TC.Width = 50
        '
        'COL_DOC_DATE
        '
        Me.COL_DOC_DATE.DataPropertyName = "DOC_DATE"
        Me.COL_DOC_DATE.HeaderText = "Fecha_Emi"
        Me.COL_DOC_DATE.Name = "COL_DOC_DATE"
        Me.COL_DOC_DATE.ReadOnly = True
        Me.COL_DOC_DATE.Width = 70
        '
        'COL_CADUCATE_DATE
        '
        Me.COL_CADUCATE_DATE.DataPropertyName = "CADUCATE_DATE"
        Me.COL_CADUCATE_DATE.HeaderText = "Fecha_Ven"
        Me.COL_CADUCATE_DATE.Name = "COL_CADUCATE_DATE"
        Me.COL_CADUCATE_DATE.ReadOnly = True
        Me.COL_CADUCATE_DATE.Width = 70
        '
        'COL_SALES_ID
        '
        Me.COL_SALES_ID.DataPropertyName = "SALES_ID"
        Me.COL_SALES_ID.HeaderText = "Cod_Ven"
        Me.COL_SALES_ID.Name = "COL_SALES_ID"
        Me.COL_SALES_ID.ReadOnly = True
        Me.COL_SALES_ID.Visible = False
        Me.COL_SALES_ID.Width = 40
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
        Me.COL_DOCUMENT_REF.Width = 40
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
        DataGridViewCellStyle11.Format = "N2"
        Me.COL_AMOUNT_BALANCE_INI.DefaultCellStyle = DataGridViewCellStyle11
        Me.COL_AMOUNT_BALANCE_INI.HeaderText = "Saldo_Ini"
        Me.COL_AMOUNT_BALANCE_INI.Name = "COL_AMOUNT_BALANCE_INI"
        Me.COL_AMOUNT_BALANCE_INI.ReadOnly = True
        Me.COL_AMOUNT_BALANCE_INI.Width = 70
        '
        'mtb_total_cob
        '
        Me.mtb_total_cob.Location = New System.Drawing.Point(686, 237)
        Me.mtb_total_cob.Name = "mtb_total_cob"
        Me.mtb_total_cob.ReadOnly = True
        Me.mtb_total_cob.Size = New System.Drawing.Size(82, 20)
        Me.mtb_total_cob.TabIndex = 40
        Me.mtb_total_cob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtb_total_letra
        '
        Me.mtb_total_letra.Location = New System.Drawing.Point(203, 436)
        Me.mtb_total_letra.Name = "mtb_total_letra"
        Me.mtb_total_letra.ReadOnly = True
        Me.mtb_total_letra.Size = New System.Drawing.Size(100, 20)
        Me.mtb_total_letra.TabIndex = 41
        Me.mtb_total_letra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(433, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nª Letras"
        '
        'btn_reg_letras
        '
        Me.btn_reg_letras.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reg_letras.Image = Global.LibCobranzas.My.Resources.Resources.checkmark_26
        Me.btn_reg_letras.Location = New System.Drawing.Point(514, 376)
        Me.btn_reg_letras.Name = "btn_reg_letras"
        Me.btn_reg_letras.Size = New System.Drawing.Size(254, 54)
        Me.btn_reg_letras.TabIndex = 43
        Me.btn_reg_letras.Text = "Registrar Letras"
        Me.btn_reg_letras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_reg_letras.UseVisualStyleBackColor = True
        '
        'frm_CX_LT_Letras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(780, 463)
        Me.Controls.Add(Me.btn_reg_letras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtb_total_letra)
        Me.Controls.Add(Me.mtb_total_cob)
        Me.Controls.Add(Me.dgv_pendientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_letras)
        Me.Controls.Add(Me.gb_cliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_CX_LT_Letras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Letras"
        Me.gb_cliente.ResumeLayout(False)
        Me.gb_cliente.PerformLayout()
        CType(Me.dgv_letras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents btn_mostrar_docs As System.Windows.Forms.Button
    Friend WithEvents btn_busca_cli As System.Windows.Forms.Button
    Private WithEvents txt_cod_ane As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents txt_des_ane As System.Windows.Forms.TextBox
    Friend WithEvents dgv_letras As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_pendientes As System.Windows.Forms.DataGridView
    Friend WithEvents mtb_total_cob As System.Windows.Forms.TextBox
    Friend WithEvents mtb_total_letra As System.Windows.Forms.TextBox
    Friend WithEvents chk_sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents COL_DOCUMENT_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_SERIE_AUX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_NUM_DOC_AUX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_MONTO_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_MONTO_CO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_COD_MON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_TC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DOC_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_CADUCATE_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_SALES_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_IS_DR_CR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DOCUMENT_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_NUMBER_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_AMOUNT_BALANCE_INI As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_sel As System.Windows.Forms.Label
    Friend WithEvents lbl_tot As System.Windows.Forms.Label
    Friend WithEvents btn_reg_letras As System.Windows.Forms.Button
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fec_ven As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents is_ori As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
