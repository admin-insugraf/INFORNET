<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_RP_Egp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_RP_Egp))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdb_naturaleza = New System.Windows.Forms.RadioButton()
        Me.rdb_funcion = New System.Windows.Forms.RadioButton()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.mtb_ayo = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_men_acu = New System.Windows.Forms.RadioButton()
        Me.rb_men = New System.Windows.Forms.RadioButton()
        Me.rb_acu_com = New System.Windows.Forms.RadioButton()
        Me.rb_acu = New System.Windows.Forms.RadioButton()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 25)
        Me.ToolStrip1.TabIndex = 21
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
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.rdb_naturaleza)
        Me.groupBox2.Controls.Add(Me.rdb_funcion)
        Me.groupBox2.Controls.Add(Me.cmb_mes)
        Me.groupBox2.Controls.Add(Me.mtb_ayo)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Location = New System.Drawing.Point(6, 34)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(266, 81)
        Me.groupBox2.TabIndex = 22
        Me.groupBox2.TabStop = False
        '
        'rdb_naturaleza
        '
        Me.rdb_naturaleza.AutoSize = True
        Me.rdb_naturaleza.ForeColor = System.Drawing.Color.Navy
        Me.rdb_naturaleza.Location = New System.Drawing.Point(152, 48)
        Me.rdb_naturaleza.Name = "rdb_naturaleza"
        Me.rdb_naturaleza.Size = New System.Drawing.Size(95, 17)
        Me.rdb_naturaleza.TabIndex = 7
        Me.rdb_naturaleza.Text = "Por Naturaleza"
        Me.rdb_naturaleza.UseVisualStyleBackColor = True
        '
        'rdb_funcion
        '
        Me.rdb_funcion.AutoSize = True
        Me.rdb_funcion.Checked = True
        Me.rdb_funcion.ForeColor = System.Drawing.Color.Navy
        Me.rdb_funcion.Location = New System.Drawing.Point(20, 48)
        Me.rdb_funcion.Name = "rdb_funcion"
        Me.rdb_funcion.Size = New System.Drawing.Size(82, 17)
        Me.rdb_funcion.TabIndex = 6
        Me.rdb_funcion.TabStop = True
        Me.rdb_funcion.Text = "Por Función"
        Me.rdb_funcion.UseVisualStyleBackColor = True
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
        Me.groupBox1.Controls.Add(Me.rb_men_acu)
        Me.groupBox1.Controls.Add(Me.rb_men)
        Me.groupBox1.Controls.Add(Me.rb_acu_com)
        Me.groupBox1.Controls.Add(Me.rb_acu)
        Me.groupBox1.Location = New System.Drawing.Point(6, 117)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(266, 125)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        '
        'rb_men_acu
        '
        Me.rb_men_acu.AutoSize = True
        Me.rb_men_acu.ForeColor = System.Drawing.Color.Navy
        Me.rb_men_acu.Location = New System.Drawing.Point(15, 88)
        Me.rb_men_acu.Name = "rb_men_acu"
        Me.rb_men_acu.Size = New System.Drawing.Size(127, 17)
        Me.rb_men_acu.TabIndex = 5
        Me.rb_men_acu.TabStop = True
        Me.rb_men_acu.Text = "Mensual Comparativo"
        Me.rb_men_acu.UseVisualStyleBackColor = True
        '
        'rb_men
        '
        Me.rb_men.AutoSize = True
        Me.rb_men.ForeColor = System.Drawing.Color.Navy
        Me.rb_men.Location = New System.Drawing.Point(15, 65)
        Me.rb_men.Name = "rb_men"
        Me.rb_men.Size = New System.Drawing.Size(65, 17)
        Me.rb_men.TabIndex = 4
        Me.rb_men.TabStop = True
        Me.rb_men.Text = "Mensual"
        Me.rb_men.UseVisualStyleBackColor = True
        '
        'rb_acu_com
        '
        Me.rb_acu_com.AutoSize = True
        Me.rb_acu_com.ForeColor = System.Drawing.Color.Navy
        Me.rb_acu_com.Location = New System.Drawing.Point(15, 42)
        Me.rb_acu_com.Name = "rb_acu_com"
        Me.rb_acu_com.Size = New System.Drawing.Size(140, 17)
        Me.rb_acu_com.TabIndex = 3
        Me.rb_acu_com.TabStop = True
        Me.rb_acu_com.Text = "Acumulado Comparativo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rb_acu_com.UseVisualStyleBackColor = True
        '
        'rb_acu
        '
        Me.rb_acu.AutoSize = True
        Me.rb_acu.Checked = True
        Me.rb_acu.ForeColor = System.Drawing.Color.Navy
        Me.rb_acu.Location = New System.Drawing.Point(15, 19)
        Me.rb_acu.Name = "rb_acu"
        Me.rb_acu.Size = New System.Drawing.Size(78, 17)
        Me.rb_acu.TabIndex = 2
        Me.rb_acu.TabStop = True
        Me.rb_acu.Text = "Acumulado"
        Me.rb_acu.UseVisualStyleBackColor = True
        '
        'frm_CO_RP_Egp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 252)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_RP_Egp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esta. Gan y Perdida"
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
    Private WithEvents rb_men_acu As System.Windows.Forms.RadioButton
    Private WithEvents rb_men As System.Windows.Forms.RadioButton
    Private WithEvents rb_acu_com As System.Windows.Forms.RadioButton
    Private WithEvents rb_acu As System.Windows.Forms.RadioButton
    Private WithEvents rdb_naturaleza As System.Windows.Forms.RadioButton
    Private WithEvents rdb_funcion As System.Windows.Forms.RadioButton
End Class
