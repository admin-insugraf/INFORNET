<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetallesRequisiciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetallesRequisiciones))
        Me.dgvdato = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PART_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PART_DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRIORIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.tAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgvdato_imprenta = New System.Windows.Forms.DataGridView()
        Me.Sel_imprenta = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.item_imprenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_id_imprenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_description_imprenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_imprenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty_imprenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_producto_imprenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto_imprenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comment_imprenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prioridad_imprenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvdato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolOpc.SuspendLayout()
        CType(Me.dgvdato_imprenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdato
        '
        Me.dgvdato.AllowUserToAddRows = False
        Me.dgvdato.AllowUserToDeleteRows = False
        Me.dgvdato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdato.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.ITEM, Me.PART_ID, Me.PART_DESCRIPTION, Me.UNIT, Me.QTY, Me.COMMENT, Me.PRIORIDAD})
        Me.dgvdato.Location = New System.Drawing.Point(4, 28)
        Me.dgvdato.Name = "dgvdato"
        Me.dgvdato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdato.Size = New System.Drawing.Size(852, 283)
        Me.dgvdato.TabIndex = 10
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel."
        Me.Sel.Name = "Sel"
        '
        'ITEM
        '
        Me.ITEM.DataPropertyName = "ITEM"
        Me.ITEM.HeaderText = "Item"
        Me.ITEM.Name = "ITEM"
        '
        'PART_ID
        '
        Me.PART_ID.DataPropertyName = "PART_ID"
        Me.PART_ID.HeaderText = "Codigo"
        Me.PART_ID.Name = "PART_ID"
        '
        'PART_DESCRIPTION
        '
        Me.PART_DESCRIPTION.DataPropertyName = "PART_DESCRIPTION"
        Me.PART_DESCRIPTION.HeaderText = "Producto"
        Me.PART_DESCRIPTION.Name = "PART_DESCRIPTION"
        '
        'UNIT
        '
        Me.UNIT.DataPropertyName = "UNIT"
        Me.UNIT.HeaderText = "Unidad"
        Me.UNIT.Name = "UNIT"
        '
        'QTY
        '
        Me.QTY.DataPropertyName = "QTY"
        Me.QTY.HeaderText = "Cantidad"
        Me.QTY.Name = "QTY"
        '
        'COMMENT
        '
        Me.COMMENT.DataPropertyName = "COMMENT"
        Me.COMMENT.HeaderText = "Uso"
        Me.COMMENT.Name = "COMMENT"
        '
        'PRIORIDAD
        '
        Me.PRIORIDAD.DataPropertyName = "PRIORIDAD"
        Me.PRIORIDAD.HeaderText = "Prioridad"
        Me.PRIORIDAD.Name = "PRIORIDAD"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(8, 317)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 13)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.Text = "."
        '
        'ToolOpc
        '
        Me.ToolOpc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tAceptar, Me.ToolStripButton1})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(861, 25)
        Me.ToolOpc.TabIndex = 8
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'tAceptar
        '
        Me.tAceptar.Image = CType(resources.GetObject("tAceptar.Image"), System.Drawing.Image)
        Me.tAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tAceptar.Name = "tAceptar"
        Me.tAceptar.Size = New System.Drawing.Size(72, 22)
        Me.tAceptar.Text = "Aceptar"
        Me.tAceptar.ToolTipText = "Aceptar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton1.Text = "Cancelar"
        Me.ToolStripButton1.ToolTipText = "Aceptar"
        '
        'dgvdato_imprenta
        '
        Me.dgvdato_imprenta.AllowUserToAddRows = False
        Me.dgvdato_imprenta.AllowUserToDeleteRows = False
        Me.dgvdato_imprenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdato_imprenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdato_imprenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel_imprenta, Me.item_imprenta, Me.part_id_imprenta, Me.part_description_imprenta, Me.unit_imprenta, Me.qty_imprenta, Me.cod_producto_imprenta, Me.producto_imprenta, Me.comment_imprenta, Me.prioridad_imprenta})
        Me.dgvdato_imprenta.Location = New System.Drawing.Point(4, 28)
        Me.dgvdato_imprenta.Name = "dgvdato_imprenta"
        Me.dgvdato_imprenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdato_imprenta.Size = New System.Drawing.Size(853, 283)
        Me.dgvdato_imprenta.TabIndex = 11
        '
        'Sel_imprenta
        '
        Me.Sel_imprenta.HeaderText = "Sel."
        Me.Sel_imprenta.Name = "Sel_imprenta"
        '
        'item_imprenta
        '
        Me.item_imprenta.DataPropertyName = "ITEM"
        Me.item_imprenta.HeaderText = "Item"
        Me.item_imprenta.Name = "item_imprenta"
        '
        'part_id_imprenta
        '
        Me.part_id_imprenta.DataPropertyName = "PART_ID"
        Me.part_id_imprenta.HeaderText = "Cod. Descripción"
        Me.part_id_imprenta.Name = "part_id_imprenta"
        '
        'part_description_imprenta
        '
        Me.part_description_imprenta.DataPropertyName = "PART_DESCRIPTION"
        Me.part_description_imprenta.HeaderText = "Descripción"
        Me.part_description_imprenta.Name = "part_description_imprenta"
        '
        'unit_imprenta
        '
        Me.unit_imprenta.DataPropertyName = "UNIT"
        Me.unit_imprenta.HeaderText = "Unidad"
        Me.unit_imprenta.Name = "unit_imprenta"
        '
        'qty_imprenta
        '
        Me.qty_imprenta.DataPropertyName = "QTY"
        Me.qty_imprenta.HeaderText = "Cantidad"
        Me.qty_imprenta.Name = "qty_imprenta"
        '
        'cod_producto_imprenta
        '
        Me.cod_producto_imprenta.DataPropertyName = "COD_PRODUCTO"
        Me.cod_producto_imprenta.HeaderText = "Cod. Producto"
        Me.cod_producto_imprenta.Name = "cod_producto_imprenta"
        '
        'producto_imprenta
        '
        Me.producto_imprenta.DataPropertyName = "PRODUCTO"
        Me.producto_imprenta.HeaderText = "Producto"
        Me.producto_imprenta.Name = "producto_imprenta"
        '
        'comment_imprenta
        '
        Me.comment_imprenta.DataPropertyName = "COMMENT"
        Me.comment_imprenta.HeaderText = "Uso"
        Me.comment_imprenta.Name = "comment_imprenta"
        '
        'prioridad_imprenta
        '
        Me.prioridad_imprenta.DataPropertyName = "PRIORIDAD"
        Me.prioridad_imprenta.HeaderText = "Prioridad"
        Me.prioridad_imprenta.Name = "prioridad_imprenta"
        '
        'FrmDetallesRequisiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(861, 334)
        Me.Controls.Add(Me.dgvdato_imprenta)
        Me.Controls.Add(Me.dgvdato)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.ToolOpc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmDetallesRequisiciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles de Requisiciones"
        CType(Me.dgvdato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        CType(Me.dgvdato_imprenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvdato As System.Windows.Forms.DataGridView
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents tAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PART_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PART_DESCRIPTION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRIORIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvdato_imprenta As System.Windows.Forms.DataGridView
    Friend WithEvents Sel_imprenta As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents item_imprenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents part_id_imprenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents part_description_imprenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_imprenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty_imprenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_producto_imprenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents producto_imprenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comment_imprenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prioridad_imprenta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
