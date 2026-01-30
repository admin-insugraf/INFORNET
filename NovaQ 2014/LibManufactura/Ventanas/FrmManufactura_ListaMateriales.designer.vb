<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManufactura_ListaMateriales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManufactura_ListaMateriales))
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_orden_Compra = New System.Windows.Forms.ToolStripButton()
        Me.btn_comprometer = New System.Windows.Forms.ToolStripButton()
        Me.btn_liberar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(16, 14)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.Size = New System.Drawing.Size(845, 339)
        Me.dgvCabecera.TabIndex = 2
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlCabecera.Location = New System.Drawing.Point(12, 29)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(886, 372)
        Me.pnlCabecera.TabIndex = 177
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_orden_Compra, Me.btn_comprometer, Me.btn_liberar, Me.btn_Imprimir, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(903, 25)
        Me.ToolStrip1.TabIndex = 185
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_orden_Compra
        '
        Me.btn_orden_Compra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orden_Compra.Image = CType(resources.GetObject("btn_orden_Compra.Image"), System.Drawing.Image)
        Me.btn_orden_Compra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_orden_Compra.Name = "btn_orden_Compra"
        Me.btn_orden_Compra.Size = New System.Drawing.Size(174, 22)
        Me.btn_orden_Compra.Text = "&Generar Orden de Compra"
        '
        'btn_comprometer
        '
        Me.btn_comprometer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comprometer.Image = CType(resources.GetObject("btn_comprometer.Image"), System.Drawing.Image)
        Me.btn_comprometer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_comprometer.Name = "btn_comprometer"
        Me.btn_comprometer.Size = New System.Drawing.Size(173, 22)
        Me.btn_comprometer.Text = "&Comprometer Mercaderia"
        '
        'btn_liberar
        '
        Me.btn_liberar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_liberar.Image = CType(resources.GetObject("btn_liberar.Image"), System.Drawing.Image)
        Me.btn_liberar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_liberar.Name = "btn_liberar"
        Me.btn_liberar.Size = New System.Drawing.Size(134, 22)
        Me.btn_liberar.Text = "&Liberar Mercaderia"
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Imprimir.Image = CType(resources.GetObject("btn_Imprimir.Image"), System.Drawing.Image)
        Me.btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(97, 22)
        Me.btn_Imprimir.Text = "&Imprimir O.F"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton1.Text = "&Salir"
        '
        'FrmManufactura_ListaMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(903, 411)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmManufactura_ListaMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Materiales"
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_orden_Compra As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_comprometer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_liberar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
