<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoNumeracionRapido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoNumeracionRapido))
        Me.pnlTipoNumeracion = New System.Windows.Forms.Panel()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
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
        Me.pnlTipoNumeracion.BackColor = System.Drawing.Color.Transparent
        Me.pnlTipoNumeracion.Controls.Add(Me.txtTitulo)
        Me.pnlTipoNumeracion.Controls.Add(Me.GroupBox4)
        Me.pnlTipoNumeracion.Location = New System.Drawing.Point(13, 12)
        Me.pnlTipoNumeracion.Name = "pnlTipoNumeracion"
        Me.pnlTipoNumeracion.Size = New System.Drawing.Size(265, 128)
        Me.pnlTipoNumeracion.TabIndex = 112
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.White
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTitulo.ForeColor = System.Drawing.Color.Navy
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.MaxLength = 10
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(264, 22)
        Me.txtTitulo.TabIndex = 112
        Me.txtTitulo.Text = "FACTURAS"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNumeracionManual)
        Me.GroupBox4.Controls.Add(Me.btnSalirNumeracion)
        Me.GroupBox4.Controls.Add(Me.btnAceptarNumeracion)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(11, 33)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(244, 84)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Numeración :"
        '
        'txtNumeracionManual
        '
        Me.txtNumeracionManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeracionManual.Enabled = False
        Me.txtNumeracionManual.Location = New System.Drawing.Point(6, 51)
        Me.txtNumeracionManual.MaxLength = 10
        Me.txtNumeracionManual.Name = "txtNumeracionManual"
        Me.txtNumeracionManual.Size = New System.Drawing.Size(154, 24)
        Me.txtNumeracionManual.TabIndex = 111
        '
        'btnSalirNumeracion
        '
        Me.btnSalirNumeracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirNumeracion.Image = CType(resources.GetObject("btnSalirNumeracion.Image"), System.Drawing.Image)
        Me.btnSalirNumeracion.Location = New System.Drawing.Point(206, 49)
        Me.btnSalirNumeracion.Name = "btnSalirNumeracion"
        Me.btnSalirNumeracion.Size = New System.Drawing.Size(30, 28)
        Me.btnSalirNumeracion.TabIndex = 10
        Me.btnSalirNumeracion.UseVisualStyleBackColor = True
        '
        'btnAceptarNumeracion
        '
        Me.btnAceptarNumeracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarNumeracion.Image = CType(resources.GetObject("btnAceptarNumeracion.Image"), System.Drawing.Image)
        Me.btnAceptarNumeracion.Location = New System.Drawing.Point(167, 49)
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
        Me.rbAutomatica.Size = New System.Drawing.Size(88, 21)
        Me.rbAutomatica.TabIndex = 4
        Me.rbAutomatica.Text = "Automatico"
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
        'FrmTipoNumeracionRapido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(291, 152)
        Me.Controls.Add(Me.pnlTipoNumeracion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTipoNumeracionRapido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Numeración"
        Me.pnlTipoNumeracion.ResumeLayout(False)
        Me.pnlTipoNumeracion.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTipoNumeracion As System.Windows.Forms.Panel
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeracionManual As System.Windows.Forms.TextBox
    Friend WithEvents btnSalirNumeracion As System.Windows.Forms.Button
    Friend WithEvents btnAceptarNumeracion As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAutomatica As System.Windows.Forms.RadioButton
    Friend WithEvents rbManual As System.Windows.Forms.RadioButton
End Class
