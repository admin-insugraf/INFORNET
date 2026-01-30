<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_RP_BalGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_RP_BalGeneral))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.mtb_ayo = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_acumulado = New System.Windows.Forms.RadioButton()
        Me.rb_mensual = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(293, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_imprimir.Image = CType(resources.GetObject("Tool_imprimir.Image"), System.Drawing.Image)
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(118, 22)
        Me.Tool_imprimir.Text = "&Mostrar reporte"
        Me.Tool_imprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = CType(resources.GetObject("Tool_salir.Image"), System.Drawing.Image)
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(52, 22)
        Me.Tool_salir.Text = "&Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cmb_mes)
        Me.groupBox2.Controls.Add(Me.mtb_ayo)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Location = New System.Drawing.Point(12, 28)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(266, 41)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(113, 12)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(112, 21)
        Me.cmb_mes.TabIndex = 1
        '
        'mtb_ayo
        '
        Me.mtb_ayo.Location = New System.Drawing.Point(61, 12)
        Me.mtb_ayo.Mask = "9999"
        Me.mtb_ayo.Name = "mtb_ayo"
        Me.mtb_ayo.Size = New System.Drawing.Size(42, 20)
        Me.mtb_ayo.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(12, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Periodo"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rb_acumulado)
        Me.groupBox1.Controls.Add(Me.rb_mensual)
        Me.groupBox1.Location = New System.Drawing.Point(12, 75)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(266, 38)
        Me.groupBox1.TabIndex = 24
        Me.groupBox1.TabStop = False
        '
        'rb_acumulado
        '
        Me.rb_acumulado.AutoSize = True
        Me.rb_acumulado.Checked = True
        Me.rb_acumulado.ForeColor = System.Drawing.Color.Navy
        Me.rb_acumulado.Location = New System.Drawing.Point(117, 13)
        Me.rb_acumulado.Name = "rb_acumulado"
        Me.rb_acumulado.Size = New System.Drawing.Size(78, 17)
        Me.rb_acumulado.TabIndex = 3
        Me.rb_acumulado.TabStop = True
        Me.rb_acumulado.Text = "Acumulado"
        Me.rb_acumulado.UseVisualStyleBackColor = True
        '
        'rb_mensual
        '
        Me.rb_mensual.AutoSize = True
        Me.rb_mensual.ForeColor = System.Drawing.Color.Navy
        Me.rb_mensual.Location = New System.Drawing.Point(43, 13)
        Me.rb_mensual.Name = "rb_mensual"
        Me.rb_mensual.Size = New System.Drawing.Size(65, 17)
        Me.rb_mensual.TabIndex = 2
        Me.rb_mensual.Text = "Mensual"
        Me.rb_mensual.UseVisualStyleBackColor = True
        '
        'frm_CO_RP_BalGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(293, 125)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_RP_BalGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance General"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Private WithEvents mtb_ayo As System.Windows.Forms.MaskedTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rb_acumulado As System.Windows.Forms.RadioButton
    Private WithEvents rb_mensual As System.Windows.Forms.RadioButton
End Class
