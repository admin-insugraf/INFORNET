<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenCompra))
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.tAceptar = New System.Windows.Forms.ToolStripButton()
        Me.TEliminar = New System.Windows.Forms.ToolStripButton()
        Me.TPDF = New System.Windows.Forms.ToolStripButton()
        Me.TCancelar = New System.Windows.Forms.ToolStripButton()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRutaArchivo = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_SerieNumero = New System.Windows.Forms.TextBox()
        Me.ToolOpc.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolOpc
        '
        Me.ToolOpc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tAceptar, Me.TEliminar, Me.TPDF, Me.TCancelar})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolOpc.Size = New System.Drawing.Size(643, 25)
        Me.ToolOpc.TabIndex = 3
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
        'TEliminar
        '
        Me.TEliminar.Image = CType(resources.GetObject("TEliminar.Image"), System.Drawing.Image)
        Me.TEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TEliminar.Name = "TEliminar"
        Me.TEliminar.Size = New System.Drawing.Size(72, 22)
        Me.TEliminar.Text = "Eliminar"
        Me.TEliminar.ToolTipText = "Salir"
        '
        'TPDF
        '
        Me.TPDF.Image = CType(resources.GetObject("TPDF.Image"), System.Drawing.Image)
        Me.TPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TPDF.Name = "TPDF"
        Me.TPDF.Size = New System.Drawing.Size(48, 22)
        Me.TPDF.Text = "PDF"
        Me.TPDF.ToolTipText = "Salir"
        '
        'TCancelar
        '
        Me.TCancelar.Image = CType(resources.GetObject("TCancelar.Image"), System.Drawing.Image)
        Me.TCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TCancelar.Name = "TCancelar"
        Me.TCancelar.Size = New System.Drawing.Size(76, 22)
        Me.TCancelar.Text = "Cancelar"
        Me.TCancelar.ToolTipText = "Salir"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRutaArchivo)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(1, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 44)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ruta:"
        '
        'txtRutaArchivo
        '
        Me.txtRutaArchivo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtRutaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRutaArchivo.Enabled = False
        Me.txtRutaArchivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaArchivo.Location = New System.Drawing.Point(6, 16)
        Me.txtRutaArchivo.Name = "txtRutaArchivo"
        Me.txtRutaArchivo.Size = New System.Drawing.Size(568, 21)
        Me.txtRutaArchivo.TabIndex = 4
        '
        'btnbuscar
        '
        Me.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Location = New System.Drawing.Point(586, 39)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(38, 35)
        Me.btnbuscar.TabIndex = 293
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 295
        Me.Label2.Text = "Número de OC:"
        '
        'txt_SerieNumero
        '
        Me.txt_SerieNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SerieNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SerieNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SerieNumero.Location = New System.Drawing.Point(95, 82)
        Me.txt_SerieNumero.Name = "txt_SerieNumero"
        Me.txt_SerieNumero.Size = New System.Drawing.Size(484, 29)
        Me.txt_SerieNumero.TabIndex = 294
        '
        'frmOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(643, 120)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_SerieNumero)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.ToolOpc)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOrdenCompra"
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents tAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRutaArchivo As System.Windows.Forms.TextBox
    Friend WithEvents TCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TPDF As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents TEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_SerieNumero As System.Windows.Forms.TextBox
End Class
