<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalles_Ingreso_OrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalles_Ingreso_OrdenCompra))
        Me.dgvdato = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PART_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.tAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvdato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolOpc.SuspendLayout()
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
        Me.dgvdato.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.ITEM, Me.PART_ID, Me.DESCRIPTION, Me.UNIT, Me.USO, Me.SALDO})
        Me.dgvdato.Location = New System.Drawing.Point(4, 30)
        Me.dgvdato.Name = "dgvdato"
        Me.dgvdato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdato.Size = New System.Drawing.Size(749, 275)
        Me.dgvdato.TabIndex = 13
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
        'DESCRIPTION
        '
        Me.DESCRIPTION.DataPropertyName = "DESCRIPTION"
        Me.DESCRIPTION.HeaderText = "Producto"
        Me.DESCRIPTION.Name = "DESCRIPTION"
        '
        'UNIT
        '
        Me.UNIT.DataPropertyName = "UNIT"
        Me.UNIT.HeaderText = "Unidad"
        Me.UNIT.Name = "UNIT"
        '
        'USO
        '
        Me.USO.DataPropertyName = "USO"
        Me.USO.HeaderText = "Uso"
        Me.USO.Name = "USO"
        '
        'SALDO
        '
        Me.SALDO.DataPropertyName = "SALDO"
        Me.SALDO.HeaderText = "Saldo"
        Me.SALDO.Name = "SALDO"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(8, 309)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 13)
        Me.lblCantidad.TabIndex = 12
        Me.lblCantidad.Text = "."
        '
        'ToolOpc
        '
        Me.ToolOpc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tAceptar, Me.ToolStripButton1})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(765, 25)
        Me.ToolOpc.TabIndex = 11
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
        'FrmDetalles_Ingreso_OrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(765, 324)
        Me.Controls.Add(Me.dgvdato)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.ToolOpc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetalles_Ingreso_OrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles de Ingreso por Orden de Compra"
        CType(Me.dgvdato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
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
    Friend WithEvents DESCRIPTION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
