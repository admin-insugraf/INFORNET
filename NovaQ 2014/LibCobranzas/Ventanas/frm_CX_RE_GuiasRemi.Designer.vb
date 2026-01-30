<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_RE_GuiasRemi
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_fec_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fec_ini = New System.Windows.Forms.DateTimePicker()
        Me.dgv_cab = New System.Windows.Forms.DataGridView()
        Me.WAREHOUSE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCUMENT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMBER_DOCUMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_DOCUMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPE_TRANS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANS_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOC_ID_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALES_TERM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURRENCY_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURRENCY_EXCHANGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PART_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DES_PART = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIT_PART = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIT_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNT_SALES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEXT_COMMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURRENCY_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_cab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AllowUserToDeleteRows = False
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.PART_ID, Me.DES_PART, Me.UNIT_PART, Me.QTY, Me.UNIT_PRICE, Me.AMOUNT_SALES, Me.TEXT_COMMENT, Me.CURRENCY_ID})
        Me.dgv_detalle.Location = New System.Drawing.Point(12, 272)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.ReadOnly = True
        Me.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle.Size = New System.Drawing.Size(904, 172)
        Me.dgv_detalle.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Imprimir, Me.ToolStripSeparator3, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(928, 25)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.LibCobranzas.My.Resources.Resources.undo_26
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_fec_fin)
        Me.GroupBox1.Controls.Add(Me.dtp_fec_ini)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 49)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(352, 17)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultar.TabIndex = 28
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Desde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Hasta"
        '
        'dtp_fec_fin
        '
        Me.dtp_fec_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_fin.Location = New System.Drawing.Point(220, 18)
        Me.dtp_fec_fin.Name = "dtp_fec_fin"
        Me.dtp_fec_fin.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fec_fin.TabIndex = 26
        '
        'dtp_fec_ini
        '
        Me.dtp_fec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_ini.Location = New System.Drawing.Point(60, 18)
        Me.dtp_fec_ini.Name = "dtp_fec_ini"
        Me.dtp_fec_ini.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fec_ini.TabIndex = 26
        '
        'dgv_cab
        '
        Me.dgv_cab.AllowUserToAddRows = False
        Me.dgv_cab.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_cab.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_cab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_cab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WAREHOUSE_ID, Me.DOCUMENT_ID, Me.NUMBER_DOCUMENT, Me.DATE_DOCUMENT, Me.TYPE_TRANS, Me.TRANS_ID, Me.DOC_ID_REF, Me.COMMENT, Me.CUSTOMER_ID, Me.CUSTOMER_NAME, Me.SALES_TERM, Me.CURRENCY_TYPE, Me.CURRENCY_EXCHANGE})
        Me.dgv_cab.Location = New System.Drawing.Point(12, 83)
        Me.dgv_cab.Name = "dgv_cab"
        Me.dgv_cab.ReadOnly = True
        Me.dgv_cab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cab.Size = New System.Drawing.Size(904, 183)
        Me.dgv_cab.TabIndex = 0
        '
        'WAREHOUSE_ID
        '
        Me.WAREHOUSE_ID.DataPropertyName = "WAREHOUSE_ID"
        Me.WAREHOUSE_ID.HeaderText = "Alm"
        Me.WAREHOUSE_ID.Name = "WAREHOUSE_ID"
        Me.WAREHOUSE_ID.ReadOnly = True
        Me.WAREHOUSE_ID.Width = 49
        '
        'DOCUMENT_ID
        '
        Me.DOCUMENT_ID.DataPropertyName = "DOCUMENT_ID"
        Me.DOCUMENT_ID.HeaderText = "TD"
        Me.DOCUMENT_ID.Name = "DOCUMENT_ID"
        Me.DOCUMENT_ID.ReadOnly = True
        Me.DOCUMENT_ID.Width = 47
        '
        'NUMBER_DOCUMENT
        '
        Me.NUMBER_DOCUMENT.DataPropertyName = "NUMBER_DOCUMENT"
        Me.NUMBER_DOCUMENT.HeaderText = "Serie"
        Me.NUMBER_DOCUMENT.Name = "NUMBER_DOCUMENT"
        Me.NUMBER_DOCUMENT.ReadOnly = True
        Me.NUMBER_DOCUMENT.Width = 56
        '
        'DATE_DOCUMENT
        '
        Me.DATE_DOCUMENT.DataPropertyName = "DATE_DOCUMENT"
        Me.DATE_DOCUMENT.HeaderText = "Fecha"
        Me.DATE_DOCUMENT.Name = "DATE_DOCUMENT"
        Me.DATE_DOCUMENT.ReadOnly = True
        Me.DATE_DOCUMENT.Width = 62
        '
        'TYPE_TRANS
        '
        Me.TYPE_TRANS.DataPropertyName = "TYPE_TRANS"
        Me.TYPE_TRANS.HeaderText = "Trans"
        Me.TYPE_TRANS.Name = "TYPE_TRANS"
        Me.TYPE_TRANS.ReadOnly = True
        Me.TYPE_TRANS.Width = 59
        '
        'TRANS_ID
        '
        Me.TRANS_ID.DataPropertyName = "TRANS_ID"
        Me.TRANS_ID.HeaderText = "Id Trans"
        Me.TRANS_ID.Name = "TRANS_ID"
        Me.TRANS_ID.ReadOnly = True
        Me.TRANS_ID.Width = 71
        '
        'DOC_ID_REF
        '
        Me.DOC_ID_REF.DataPropertyName = "DOC_ID_REF"
        Me.DOC_ID_REF.HeaderText = "TD Ref"
        Me.DOC_ID_REF.Name = "DOC_ID_REF"
        Me.DOC_ID_REF.ReadOnly = True
        Me.DOC_ID_REF.Width = 67
        '
        'COMMENT
        '
        Me.COMMENT.DataPropertyName = "COMMENT"
        Me.COMMENT.HeaderText = "Comentario"
        Me.COMMENT.Name = "COMMENT"
        Me.COMMENT.ReadOnly = True
        Me.COMMENT.Width = 85
        '
        'CUSTOMER_ID
        '
        Me.CUSTOMER_ID.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMER_ID.HeaderText = "Cod. Cli"
        Me.CUSTOMER_ID.Name = "CUSTOMER_ID"
        Me.CUSTOMER_ID.ReadOnly = True
        Me.CUSTOMER_ID.Width = 68
        '
        'CUSTOMER_NAME
        '
        Me.CUSTOMER_NAME.DataPropertyName = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.HeaderText = "Cliente"
        Me.CUSTOMER_NAME.Name = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.ReadOnly = True
        Me.CUSTOMER_NAME.Width = 64
        '
        'SALES_TERM
        '
        Me.SALES_TERM.DataPropertyName = "SALES_TERM"
        Me.SALES_TERM.HeaderText = "Pago"
        Me.SALES_TERM.Name = "SALES_TERM"
        Me.SALES_TERM.ReadOnly = True
        Me.SALES_TERM.Width = 57
        '
        'CURRENCY_TYPE
        '
        Me.CURRENCY_TYPE.DataPropertyName = "CURRENCY_TYPE"
        Me.CURRENCY_TYPE.HeaderText = "Mon"
        Me.CURRENCY_TYPE.Name = "CURRENCY_TYPE"
        Me.CURRENCY_TYPE.ReadOnly = True
        Me.CURRENCY_TYPE.Width = 53
        '
        'CURRENCY_EXCHANGE
        '
        Me.CURRENCY_EXCHANGE.DataPropertyName = "CURRENCY_EXCHANGE"
        Me.CURRENCY_EXCHANGE.HeaderText = "T.c."
        Me.CURRENCY_EXCHANGE.Name = "CURRENCY_EXCHANGE"
        Me.CURRENCY_EXCHANGE.ReadOnly = True
        Me.CURRENCY_EXCHANGE.Width = 51
        '
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.LibCobranzas.My.Resources.Resources.print_26
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
        '
        'ITEM
        '
        Me.ITEM.DataPropertyName = "ITEM"
        Me.ITEM.HeaderText = "Sec."
        Me.ITEM.Name = "ITEM"
        Me.ITEM.ReadOnly = True
        '
        'PART_ID
        '
        Me.PART_ID.DataPropertyName = "PART_ID"
        Me.PART_ID.HeaderText = "Codigo"
        Me.PART_ID.Name = "PART_ID"
        Me.PART_ID.ReadOnly = True
        '
        'DES_PART
        '
        Me.DES_PART.DataPropertyName = "DES_PART"
        Me.DES_PART.HeaderText = "Articulo"
        Me.DES_PART.Name = "DES_PART"
        Me.DES_PART.ReadOnly = True
        '
        'UNIT_PART
        '
        Me.UNIT_PART.DataPropertyName = "UNIT_PART"
        Me.UNIT_PART.HeaderText = "Unid. Med."
        Me.UNIT_PART.Name = "UNIT_PART"
        Me.UNIT_PART.ReadOnly = True
        '
        'QTY
        '
        Me.QTY.DataPropertyName = "QTY"
        Me.QTY.HeaderText = "Cant"
        Me.QTY.Name = "QTY"
        Me.QTY.ReadOnly = True
        '
        'UNIT_PRICE
        '
        Me.UNIT_PRICE.DataPropertyName = "UNIT_PRICE"
        Me.UNIT_PRICE.HeaderText = "prec. Unit."
        Me.UNIT_PRICE.Name = "UNIT_PRICE"
        Me.UNIT_PRICE.ReadOnly = True
        '
        'AMOUNT_SALES
        '
        Me.AMOUNT_SALES.DataPropertyName = "AMOUNT_SALES"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.AMOUNT_SALES.DefaultCellStyle = DataGridViewCellStyle1
        Me.AMOUNT_SALES.HeaderText = "Importe"
        Me.AMOUNT_SALES.Name = "AMOUNT_SALES"
        Me.AMOUNT_SALES.ReadOnly = True
        '
        'TEXT_COMMENT
        '
        Me.TEXT_COMMENT.DataPropertyName = "TEXT_COMMENT"
        Me.TEXT_COMMENT.HeaderText = "Comentarios"
        Me.TEXT_COMMENT.Name = "TEXT_COMMENT"
        Me.TEXT_COMMENT.ReadOnly = True
        '
        'CURRENCY_ID
        '
        Me.CURRENCY_ID.DataPropertyName = "CURRENCY_ID"
        Me.CURRENCY_ID.HeaderText = "Mon"
        Me.CURRENCY_ID.Name = "CURRENCY_ID"
        Me.CURRENCY_ID.ReadOnly = True
        '
        'frm_CX_RE_GuiasRemi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(928, 456)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_cab)
        Me.Controls.Add(Me.dgv_detalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_CX_RE_GuiasRemi"
        Me.Text = "Guias de Remision"
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_cab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_fec_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fec_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_cab As System.Windows.Forms.DataGridView
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents WAREHOUSE_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENT_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMBER_DOCUMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATE_DOCUMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TYPE_TRANS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRANS_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOC_ID_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALES_TERM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRENCY_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRENCY_EXCHANGE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PART_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DES_PART As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIT_PART As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIT_PRICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNT_SALES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TEXT_COMMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRENCY_ID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
