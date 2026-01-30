<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmfacturacionTienda_Cantidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmfacturacionTienda_Cantidad))
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_tamaño = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_total_cantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_factor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nueva_cantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BackColor = System.Drawing.Color.White
        Me.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(11, 74)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(96, 21)
        Me.txt_cantidad.TabIndex = 203
        Me.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label98.ForeColor = System.Drawing.Color.Navy
        Me.Label98.Location = New System.Drawing.Point(31, 53)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(57, 13)
        Me.Label98.TabIndex = 204
        Me.Label98.Text = "Cantidad"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Maroon
        Me.TextBox1.Location = New System.Drawing.Point(113, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(96, 21)
        Me.TextBox1.TabIndex = 205
        Me.TextBox1.Text = "Segmentos"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(138, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Unidad"
        '
        'txt_tamaño
        '
        Me.txt_tamaño.BackColor = System.Drawing.Color.White
        Me.txt_tamaño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tamaño.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tamaño.Location = New System.Drawing.Point(215, 74)
        Me.txt_tamaño.Name = "txt_tamaño"
        Me.txt_tamaño.Size = New System.Drawing.Size(96, 21)
        Me.txt_tamaño.TabIndex = 207
        Me.txt_tamaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(237, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Tamaño"
        '
        'txt_total_cantidad
        '
        Me.txt_total_cantidad.BackColor = System.Drawing.Color.White
        Me.txt_total_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_cantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_cantidad.Location = New System.Drawing.Point(521, 74)
        Me.txt_total_cantidad.Name = "txt_total_cantidad"
        Me.txt_total_cantidad.Size = New System.Drawing.Size(96, 21)
        Me.txt_total_cantidad.TabIndex = 213
        Me.txt_total_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(525, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Total Cantidad"
        '
        'txt_factor
        '
        Me.txt_factor.BackColor = System.Drawing.Color.White
        Me.txt_factor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_factor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_factor.Location = New System.Drawing.Point(419, 74)
        Me.txt_factor.Name = "txt_factor"
        Me.txt_factor.Size = New System.Drawing.Size(96, 21)
        Me.txt_factor.TabIndex = 211
        Me.txt_factor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(446, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "Factor"
        '
        'txt_nueva_cantidad
        '
        Me.txt_nueva_cantidad.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_nueva_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nueva_cantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nueva_cantidad.ForeColor = System.Drawing.Color.Maroon
        Me.txt_nueva_cantidad.Location = New System.Drawing.Point(317, 74)
        Me.txt_nueva_cantidad.Name = "txt_nueva_cantidad"
        Me.txt_nueva_cantidad.ReadOnly = True
        Me.txt_nueva_cantidad.Size = New System.Drawing.Size(96, 21)
        Me.txt_nueva_cantidad.TabIndex = 209
        Me.txt_nueva_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(318, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "Nueva Cantidad"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.btn_cancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip1.TabIndex = 215
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 22)
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'FrmfacturacionTienda_Cantidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 110)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_total_cantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_factor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nueva_cantidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_tamaño)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label98)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmfacturacionTienda_Cantidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo de Cantidad de Anillos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_tamaño As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_total_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_factor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nueva_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
End Class
