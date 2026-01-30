<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRep_Daot_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRep_Daot_Ventas))
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_detallado = New System.Windows.Forms.RadioButton()
        Me.rb_resumen = New System.Windows.Forms.RadioButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_tope = New System.Windows.Forms.TextBox()
        Me.txt_por = New System.Windows.Forms.TextBox()
        Me.txt_uit = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtb_ayo = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.rb_detallado)
        Me.groupBox4.Controls.Add(Me.rb_resumen)
        Me.groupBox4.ForeColor = System.Drawing.Color.Navy
        Me.groupBox4.Location = New System.Drawing.Point(12, 135)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(232, 60)
        Me.groupBox4.TabIndex = 24
        Me.groupBox4.TabStop = False
        '
        'rb_detallado
        '
        Me.rb_detallado.AutoSize = True
        Me.rb_detallado.Checked = True
        Me.rb_detallado.ForeColor = System.Drawing.Color.Navy
        Me.rb_detallado.Location = New System.Drawing.Point(15, 37)
        Me.rb_detallado.Name = "rb_detallado"
        Me.rb_detallado.Size = New System.Drawing.Size(70, 17)
        Me.rb_detallado.TabIndex = 0
        Me.rb_detallado.TabStop = True
        Me.rb_detallado.Text = "Detallado"
        Me.rb_detallado.UseVisualStyleBackColor = True
        '
        'rb_resumen
        '
        Me.rb_resumen.AutoSize = True
        Me.rb_resumen.ForeColor = System.Drawing.Color.Navy
        Me.rb_resumen.Location = New System.Drawing.Point(15, 14)
        Me.rb_resumen.Name = "rb_resumen"
        Me.rb_resumen.Size = New System.Drawing.Size(72, 17)
        Me.rb_resumen.TabIndex = 0
        Me.rb_resumen.Text = "Resumido"
        Me.rb_resumen.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txt_tope)
        Me.groupBox1.Controls.Add(Me.txt_por)
        Me.groupBox1.Controls.Add(Me.txt_uit)
        Me.groupBox1.Location = New System.Drawing.Point(12, 75)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(232, 54)
        Me.groupBox1.TabIndex = 26
        Me.groupBox1.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Navy
        Me.label4.Location = New System.Drawing.Point(131, 11)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(36, 13)
        Me.label4.TabIndex = 4
        Me.label4.Text = "TOPE"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(91, 11)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(14, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "X"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Navy
        Me.label1.Location = New System.Drawing.Point(32, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "UIT"
        '
        'txt_tope
        '
        Me.txt_tope.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tope.Location = New System.Drawing.Point(119, 27)
        Me.txt_tope.Name = "txt_tope"
        Me.txt_tope.Size = New System.Drawing.Size(67, 20)
        Me.txt_tope.TabIndex = 0
        '
        'txt_por
        '
        Me.txt_por.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_por.Location = New System.Drawing.Point(80, 27)
        Me.txt_por.Name = "txt_por"
        Me.txt_por.Size = New System.Drawing.Size(33, 20)
        Me.txt_por.TabIndex = 0
        '
        'txt_uit
        '
        Me.txt_uit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uit.Location = New System.Drawing.Point(15, 27)
        Me.txt_uit.Name = "txt_uit"
        Me.txt_uit.Size = New System.Drawing.Size(59, 20)
        Me.txt_uit.TabIndex = 0
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.mtb_ayo)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Location = New System.Drawing.Point(12, 28)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(232, 41)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        '
        'mtb_ayo
        '
        Me.mtb_ayo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_ayo.Location = New System.Drawing.Point(61, 12)
        Me.mtb_ayo.Mask = "9999"
        Me.mtb_ayo.Name = "mtb_ayo"
        Me.mtb_ayo.Size = New System.Drawing.Size(52, 20)
        Me.mtb_ayo.TabIndex = 4
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(255, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_imprimir
        '
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
        'FrmRep_Daot_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 206)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRep_Daot_Ventas"
        Me.Text = "Daot Ventas"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents rb_detallado As System.Windows.Forms.RadioButton
    Private WithEvents rb_resumen As System.Windows.Forms.RadioButton
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txt_tope As System.Windows.Forms.TextBox
    Private WithEvents txt_por As System.Windows.Forms.TextBox
    Private WithEvents txt_uit As System.Windows.Forms.TextBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents mtb_ayo As System.Windows.Forms.MaskedTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
