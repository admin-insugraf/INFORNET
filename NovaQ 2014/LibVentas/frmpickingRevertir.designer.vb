<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPickingRevertir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPickingRevertir))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.TextBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(322, 68)
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
        Me.Button7.Location = New System.Drawing.Point(257, 68)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(63, 35)
        Me.Button7.TabIndex = 124
        Me.Button7.Text = "Confirmar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label131.ForeColor = System.Drawing.Color.Navy
        Me.Label131.Location = New System.Drawing.Point(27, 36)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(52, 13)
        Me.Label131.TabIndex = 222
        Me.Label131.Text = "Motivo :"
        Me.Label131.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVendedor
        '
        Me.lblVendedor.BackColor = System.Drawing.Color.White
        Me.lblVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVendedor.Enabled = False
        Me.lblVendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblVendedor.ForeColor = System.Drawing.Color.Green
        Me.lblVendedor.Location = New System.Drawing.Point(122, 34)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.ReadOnly = True
        Me.lblVendedor.Size = New System.Drawing.Size(261, 21)
        Me.lblVendedor.TabIndex = 221
        '
        'txtVendedor
        '
        Me.txtVendedor.BackColor = System.Drawing.Color.Aquamarine
        Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtVendedor.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtVendedor.Location = New System.Drawing.Point(79, 34)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(42, 21)
        Me.txtVendedor.TabIndex = 220
        '
        'frmPickingRevertir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(414, 134)
        Me.Controls.Add(Me.Label131)
        Me.Controls.Add(Me.lblVendedor)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPickingRevertir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents lblVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
End Class
