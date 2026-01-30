<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValoresDetalle
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
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tOpciones = New System.Windows.Forms.ToolStrip()
        Me.tAgregar = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle.SuspendLayout()
        Me.tOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDetalle
        '
        Me.gbDetalle.Controls.Add(Me.Label7)
        Me.gbDetalle.Controls.Add(Me.txtStock)
        Me.gbDetalle.Controls.Add(Me.txtCodigo)
        Me.gbDetalle.Controls.Add(Me.Label6)
        Me.gbDetalle.Controls.Add(Me.txtDescripcion)
        Me.gbDetalle.Controls.Add(Me.Label5)
        Me.gbDetalle.Controls.Add(Me.txtPrecio)
        Me.gbDetalle.Controls.Add(Me.txtCantidad)
        Me.gbDetalle.Controls.Add(Me.Label2)
        Me.gbDetalle.Controls.Add(Me.Label1)
        Me.gbDetalle.Location = New System.Drawing.Point(12, 38)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(473, 165)
        Me.gbDetalle.TabIndex = 14
        Me.gbDetalle.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(314, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(355, 14)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 23
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(81, 14)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(144, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Código"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(81, 48)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(374, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Producto"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(81, 116)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(81, 82)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cantidad"
        '
        'tOpciones
        '
        Me.tOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tAgregar})
        Me.tOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tOpciones.Name = "tOpciones"
        Me.tOpciones.Size = New System.Drawing.Size(508, 25)
        Me.tOpciones.TabIndex = 15
        Me.tOpciones.Text = "ToolStrip1"
        '
        'tAgregar
        '
        Me.tAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tAgregar.Image = Global.LibProveedores.My.Resources.Resource1.checkmark_26
        Me.tAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tAgregar.Name = "tAgregar"
        Me.tAgregar.Size = New System.Drawing.Size(23, 22)
        Me.tAgregar.Text = "ToolStripButton1"
        Me.tAgregar.ToolTipText = "Agregar"
        '
        'frmValoresDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 220)
        Me.Controls.Add(Me.tOpciones)
        Me.Controls.Add(Me.gbDetalle)
        Me.Name = "frmValoresDetalle"
        Me.Text = "frmValoresDetalle"
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        Me.tOpciones.ResumeLayout(False)
        Me.tOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tAgregar As System.Windows.Forms.ToolStripButton
End Class
