<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoNumeracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoNumeracion))
        Me.pnlTipoNumeracion = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtNumeracionManual = New System.Windows.Forms.TextBox()
        Me.btnSalirNumeracion = New System.Windows.Forms.Button()
        Me.btnAceptarNumeracion = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbAutomatica = New System.Windows.Forms.RadioButton()
        Me.rbManual = New System.Windows.Forms.RadioButton()
        Me.pnlTipoNumeracion.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTipoNumeracion
        '
        Me.pnlTipoNumeracion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTipoNumeracion.Controls.Add(Me.GroupBox4)
        Me.pnlTipoNumeracion.Location = New System.Drawing.Point(12, 12)
        Me.pnlTipoNumeracion.Name = "pnlTipoNumeracion"
        Me.pnlTipoNumeracion.Size = New System.Drawing.Size(265, 105)
        Me.pnlTipoNumeracion.TabIndex = 111
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNumeracionManual)
        Me.GroupBox4.Controls.Add(Me.btnSalirNumeracion)
        Me.GroupBox4.Controls.Add(Me.btnAceptarNumeracion)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(11, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(244, 84)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Numeracion :"
        '
        'txtNumeracionManual
        '
        Me.txtNumeracionManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeracionManual.Enabled = False
        Me.txtNumeracionManual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeracionManual.Location = New System.Drawing.Point(6, 51)
        Me.txtNumeracionManual.MaxLength = 10
        Me.txtNumeracionManual.Name = "txtNumeracionManual"
        Me.txtNumeracionManual.Size = New System.Drawing.Size(154, 22)
        Me.txtNumeracionManual.TabIndex = 111
        '
        'btnSalirNumeracion
        '
        Me.btnSalirNumeracion.Image = CType(resources.GetObject("btnSalirNumeracion.Image"), System.Drawing.Image)
        Me.btnSalirNumeracion.Location = New System.Drawing.Point(206, 50)
        Me.btnSalirNumeracion.Name = "btnSalirNumeracion"
        Me.btnSalirNumeracion.Size = New System.Drawing.Size(30, 28)
        Me.btnSalirNumeracion.TabIndex = 10
        Me.btnSalirNumeracion.UseVisualStyleBackColor = True
        '
        'btnAceptarNumeracion
        '
        Me.btnAceptarNumeracion.Image = CType(resources.GetObject("btnAceptarNumeracion.Image"), System.Drawing.Image)
        Me.btnAceptarNumeracion.Location = New System.Drawing.Point(167, 50)
        Me.btnAceptarNumeracion.Name = "btnAceptarNumeracion"
        Me.btnAceptarNumeracion.Size = New System.Drawing.Size(30, 28)
        Me.btnAceptarNumeracion.TabIndex = 11
        Me.btnAceptarNumeracion.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbAutomatica)
        Me.GroupBox5.Controls.Add(Me.rbManual)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(231, 34)
        Me.GroupBox5.TabIndex = 110
        Me.GroupBox5.TabStop = False
        '
        'rbAutomatica
        '
        Me.rbAutomatica.AutoSize = True
        Me.rbAutomatica.ForeColor = System.Drawing.Color.Navy
        Me.rbAutomatica.Location = New System.Drawing.Point(16, 10)
        Me.rbAutomatica.Name = "rbAutomatica"
        Me.rbAutomatica.Size = New System.Drawing.Size(87, 21)
        Me.rbAutomatica.TabIndex = 4
        Me.rbAutomatica.Text = "Automatica"
        Me.rbAutomatica.UseVisualStyleBackColor = True
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.ForeColor = System.Drawing.Color.Navy
        Me.rbManual.Location = New System.Drawing.Point(124, 10)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(67, 21)
        Me.rbManual.TabIndex = 4
        Me.rbManual.Text = "Manual"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'FrmTipoNumeracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(291, 128)
        Me.Controls.Add(Me.pnlTipoNumeracion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTipoNumeracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipo de Numeracion"
        Me.pnlTipoNumeracion.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTipoNumeracion As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeracionManual As System.Windows.Forms.TextBox
    Friend WithEvents btnSalirNumeracion As System.Windows.Forms.Button
    Friend WithEvents btnAceptarNumeracion As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAutomatica As System.Windows.Forms.RadioButton
    Friend WithEvents rbManual As System.Windows.Forms.RadioButton
End Class
