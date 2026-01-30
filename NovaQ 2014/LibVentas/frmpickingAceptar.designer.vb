<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPickingAceptar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPickingAceptar))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.dtpFechaRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.TextBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(281, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 35)
        Me.Button4.TabIndex = 123
        Me.Button4.Text = "Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Navy
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(216, 123)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(63, 35)
        Me.Button7.TabIndex = 124
        Me.Button7.Text = "Confirmar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'dtpFechaRecepcion
        '
        Me.dtpFechaRecepcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRecepcion.Location = New System.Drawing.Point(91, 80)
        Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
        Me.dtpFechaRecepcion.Size = New System.Drawing.Size(105, 21)
        Me.dtpFechaRecepcion.TabIndex = 219
        '
        'dtpHoraRecepcion
        '
        Me.dtpHoraRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraRecepcion.Location = New System.Drawing.Point(265, 78)
        Me.dtpHoraRecepcion.Name = "dtpHoraRecepcion"
        Me.dtpHoraRecepcion.Size = New System.Drawing.Size(77, 23)
        Me.dtpHoraRecepcion.TabIndex = 218
        Me.dtpHoraRecepcion.Value = New Date(2018, 11, 12, 0, 0, 0, 0)
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label131.ForeColor = System.Drawing.Color.Navy
        Me.Label131.Location = New System.Drawing.Point(19, 53)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(72, 13)
        Me.Label131.TabIndex = 222
        Me.Label131.Text = "Encargado :"
        Me.Label131.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVendedor
        '
        Me.lblVendedor.BackColor = System.Drawing.Color.White
        Me.lblVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVendedor.Enabled = False
        Me.lblVendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblVendedor.ForeColor = System.Drawing.Color.Green
        Me.lblVendedor.Location = New System.Drawing.Point(161, 49)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.ReadOnly = True
        Me.lblVendedor.Size = New System.Drawing.Size(208, 21)
        Me.lblVendedor.TabIndex = 221
        '
        'txtVendedor
        '
        Me.txtVendedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtVendedor.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtVendedor.Location = New System.Drawing.Point(91, 49)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(65, 21)
        Me.txtVendedor.TabIndex = 220
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(45, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Fecha :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(220, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 224
        Me.Label2.Text = "Hora :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmPickingAceptar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(377, 195)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label131)
        Me.Controls.Add(Me.lblVendedor)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.dtpFechaRecepcion)
        Me.Controls.Add(Me.dtpHoraRecepcion)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPickingAceptar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents dtpFechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents lblVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
