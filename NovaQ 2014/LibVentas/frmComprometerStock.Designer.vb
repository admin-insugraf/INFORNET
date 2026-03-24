<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprometerStock
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
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.tAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgvdato = New System.Windows.Forms.DataGridView()
        Me.lblusuarioId = New System.Windows.Forms.Label()
        Me.txtnumeroPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtalmacen = New System.Windows.Forms.TextBox()
        Me.ToolOpc.SuspendLayout()
        CType(Me.dgvdato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolOpc
        '
        Me.ToolOpc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tAceptar, Me.ToolStripButton1})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(958, 25)
        Me.ToolOpc.TabIndex = 3
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'tAceptar
        '
        Me.tAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tAceptar.Name = "tAceptar"
        Me.tAceptar.Size = New System.Drawing.Size(56, 22)
        Me.tAceptar.Text = "Aceptar"
        Me.tAceptar.ToolTipText = "Aceptar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripButton1.Text = "Cancelar"
        Me.ToolStripButton1.ToolTipText = "Salir"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(8, 320)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 13)
        Me.lblCantidad.TabIndex = 5
        Me.lblCantidad.Text = "."
        '
        'dgvdato
        '
        Me.dgvdato.AllowUserToAddRows = False
        Me.dgvdato.AllowUserToDeleteRows = False
        Me.dgvdato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdato.Location = New System.Drawing.Point(4, 114)
        Me.dgvdato.Name = "dgvdato"
        Me.dgvdato.ReadOnly = True
        Me.dgvdato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdato.Size = New System.Drawing.Size(949, 457)
        Me.dgvdato.TabIndex = 6
        '
        'lblusuarioId
        '
        Me.lblusuarioId.AutoSize = True
        Me.lblusuarioId.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblusuarioId.ForeColor = System.Drawing.Color.Navy
        Me.lblusuarioId.Location = New System.Drawing.Point(8, 28)
        Me.lblusuarioId.Name = "lblusuarioId"
        Me.lblusuarioId.Size = New System.Drawing.Size(82, 16)
        Me.lblusuarioId.TabIndex = 222
        Me.lblusuarioId.Text = "Nro Pedido:"
        '
        'txtnumeroPedido
        '
        Me.txtnumeroPedido.BackColor = System.Drawing.Color.Aquamarine
        Me.txtnumeroPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumeroPedido.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroPedido.Location = New System.Drawing.Point(96, 28)
        Me.txtnumeroPedido.Name = "txtnumeroPedido"
        Me.txtnumeroPedido.ReadOnly = True
        Me.txtnumeroPedido.Size = New System.Drawing.Size(102, 22)
        Me.txtnumeroPedido.TabIndex = 223
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 224
        Me.Label1.Text = "Cliente"
        '
        'txtcliente
        '
        Me.txtcliente.BackColor = System.Drawing.Color.White
        Me.txtcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcliente.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(96, 54)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.ReadOnly = True
        Me.txtcliente.Size = New System.Drawing.Size(517, 22)
        Me.txtcliente.TabIndex = 225
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(8, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 226
        Me.Label2.Text = "Almacén"
        '
        'txtalmacen
        '
        Me.txtalmacen.BackColor = System.Drawing.Color.White
        Me.txtalmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalmacen.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalmacen.Location = New System.Drawing.Point(96, 86)
        Me.txtalmacen.Name = "txtalmacen"
        Me.txtalmacen.ReadOnly = True
        Me.txtalmacen.Size = New System.Drawing.Size(517, 22)
        Me.txtalmacen.TabIndex = 227
        '
        'frmComprometerStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(958, 630)
        Me.Controls.Add(Me.txtalmacen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnumeroPedido)
        Me.Controls.Add(Me.lblusuarioId)
        Me.Controls.Add(Me.dgvdato)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.ToolOpc)
        Me.Name = "frmComprometerStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprometer Stock"
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        CType(Me.dgvdato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents tAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dgvdato As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblusuarioId As System.Windows.Forms.Label
    Friend WithEvents txtnumeroPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtalmacen As System.Windows.Forms.TextBox
End Class
