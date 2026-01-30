<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_LT_Contabilizar
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_hono = New System.Windows.Forms.RadioButton()
        Me.rb_caja = New System.Windows.Forms.RadioButton()
        Me.rb_compras = New System.Windows.Forms.RadioButton()
        Me.rb_ventas = New System.Windows.Forms.RadioButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.mtb_ayo = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.gb_caja = New System.Windows.Forms.GroupBox()
        Me.mtb_fec_has = New System.Windows.Forms.MaskedTextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.mtb_fec_des = New System.Windows.Forms.MaskedTextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.rb_caja_egr = New System.Windows.Forms.RadioButton()
        Me.rb_caja_ing = New System.Windows.Forms.RadioButton()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtb_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_Conta = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.gb_caja.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rb_hono)
        Me.groupBox1.Controls.Add(Me.rb_caja)
        Me.groupBox1.Controls.Add(Me.rb_compras)
        Me.groupBox1.Controls.Add(Me.rb_ventas)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(290, 35)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        '
        'rb_hono
        '
        Me.rb_hono.AutoSize = True
        Me.rb_hono.Location = New System.Drawing.Point(204, 11)
        Me.rb_hono.Name = "rb_hono"
        Me.rb_hono.Size = New System.Drawing.Size(80, 17)
        Me.rb_hono.TabIndex = 2
        Me.rb_hono.TabStop = True
        Me.rb_hono.Text = "Rec. Hono."
        Me.rb_hono.UseVisualStyleBackColor = True
        '
        'rb_caja
        '
        Me.rb_caja.AutoSize = True
        Me.rb_caja.Location = New System.Drawing.Point(152, 11)
        Me.rb_caja.Name = "rb_caja"
        Me.rb_caja.Size = New System.Drawing.Size(46, 17)
        Me.rb_caja.TabIndex = 1
        Me.rb_caja.TabStop = True
        Me.rb_caja.Text = "Caja"
        Me.rb_caja.UseVisualStyleBackColor = True
        '
        'rb_compras
        '
        Me.rb_compras.AutoSize = True
        Me.rb_compras.Location = New System.Drawing.Point(80, 11)
        Me.rb_compras.Name = "rb_compras"
        Me.rb_compras.Size = New System.Drawing.Size(66, 17)
        Me.rb_compras.TabIndex = 1
        Me.rb_compras.TabStop = True
        Me.rb_compras.Text = "Compras"
        Me.rb_compras.UseVisualStyleBackColor = True
        '
        'rb_ventas
        '
        Me.rb_ventas.AutoSize = True
        Me.rb_ventas.Checked = True
        Me.rb_ventas.Location = New System.Drawing.Point(16, 11)
        Me.rb_ventas.Name = "rb_ventas"
        Me.rb_ventas.Size = New System.Drawing.Size(58, 17)
        Me.rb_ventas.TabIndex = 1
        Me.rb_ventas.TabStop = True
        Me.rb_ventas.Text = "Ventas"
        Me.rb_ventas.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cmb_mes)
        Me.groupBox2.Controls.Add(Me.mtb_ayo)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Location = New System.Drawing.Point(12, 53)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(292, 41)
        Me.groupBox2.TabIndex = 6
        Me.groupBox2.TabStop = False
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(113, 12)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(87, 21)
        Me.cmb_mes.TabIndex = 5
        '
        'mtb_ayo
        '
        Me.mtb_ayo.Location = New System.Drawing.Point(61, 12)
        Me.mtb_ayo.Mask = "9999"
        Me.mtb_ayo.Name = "mtb_ayo"
        Me.mtb_ayo.Size = New System.Drawing.Size(42, 20)
        Me.mtb_ayo.TabIndex = 4
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Periodo"
        '
        'gb_caja
        '
        Me.gb_caja.Controls.Add(Me.mtb_fec_has)
        Me.gb_caja.Controls.Add(Me.label5)
        Me.gb_caja.Controls.Add(Me.mtb_fec_des)
        Me.gb_caja.Controls.Add(Me.label4)
        Me.gb_caja.Controls.Add(Me.rb_caja_egr)
        Me.gb_caja.Controls.Add(Me.rb_caja_ing)
        Me.gb_caja.Location = New System.Drawing.Point(12, 100)
        Me.gb_caja.Name = "gb_caja"
        Me.gb_caja.Size = New System.Drawing.Size(290, 102)
        Me.gb_caja.TabIndex = 7
        Me.gb_caja.TabStop = False
        '
        'mtb_fec_has
        '
        Me.mtb_fec_has.Location = New System.Drawing.Point(99, 68)
        Me.mtb_fec_has.Mask = "00/00/0000"
        Me.mtb_fec_has.Name = "mtb_fec_has"
        Me.mtb_fec_has.Size = New System.Drawing.Size(73, 20)
        Me.mtb_fec_has.TabIndex = 6
        Me.mtb_fec_has.ValidatingType = GetType(Date)
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(22, 71)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(68, 13)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Fecha Hasta"
        '
        'mtb_fec_des
        '
        Me.mtb_fec_des.Location = New System.Drawing.Point(99, 42)
        Me.mtb_fec_des.Mask = "00/00/0000"
        Me.mtb_fec_des.Name = "mtb_fec_des"
        Me.mtb_fec_des.Size = New System.Drawing.Size(73, 20)
        Me.mtb_fec_des.TabIndex = 6
        Me.mtb_fec_des.ValidatingType = GetType(Date)
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(22, 45)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 13)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Fecha Desde"
        '
        'rb_caja_egr
        '
        Me.rb_caja_egr.AutoSize = True
        Me.rb_caja_egr.Location = New System.Drawing.Point(136, 13)
        Me.rb_caja_egr.Name = "rb_caja_egr"
        Me.rb_caja_egr.Size = New System.Drawing.Size(87, 17)
        Me.rb_caja_egr.TabIndex = 3
        Me.rb_caja_egr.Text = "Caja Egresos"
        Me.rb_caja_egr.UseVisualStyleBackColor = True
        '
        'rb_caja_ing
        '
        Me.rb_caja_ing.AutoSize = True
        Me.rb_caja_ing.Checked = True
        Me.rb_caja_ing.Location = New System.Drawing.Point(16, 13)
        Me.rb_caja_ing.Name = "rb_caja_ing"
        Me.rb_caja_ing.Size = New System.Drawing.Size(89, 17)
        Me.rb_caja_ing.TabIndex = 2
        Me.rb_caja_ing.TabStop = True
        Me.rb_caja_ing.Text = "Caja Ingresos"
        Me.rb_caja_ing.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.mtb_fecha)
        Me.groupBox3.Controls.Add(Me.label1)
        Me.groupBox3.Location = New System.Drawing.Point(15, 208)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(289, 43)
        Me.groupBox3.TabIndex = 8
        Me.groupBox3.TabStop = False
        '
        'mtb_fecha
        '
        Me.mtb_fecha.Location = New System.Drawing.Point(99, 15)
        Me.mtb_fecha.Mask = "00/00/0000"
        Me.mtb_fecha.Name = "mtb_fecha"
        Me.mtb_fecha.Size = New System.Drawing.Size(81, 20)
        Me.mtb_fecha.TabIndex = 4
        Me.mtb_fecha.ValidatingType = GetType(Date)
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Fecha Voucher"
        '
        'btn_Conta
        '
        Me.btn_Conta.Location = New System.Drawing.Point(67, 257)
        Me.btn_Conta.Name = "btn_Conta"
        Me.btn_Conta.Size = New System.Drawing.Size(75, 23)
        Me.btn_Conta.TabIndex = 9
        Me.btn_Conta.Text = "Contabilizar"
        Me.btn_Conta.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Location = New System.Drawing.Point(148, 257)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Salir.TabIndex = 10
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'frm_CO_LT_Contabilizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(311, 292)
        Me.Controls.Add(Me.btn_Conta)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.gb_caja)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frm_CO_LT_Contabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizar"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.gb_caja.ResumeLayout(False)
        Me.gb_caja.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rb_hono As System.Windows.Forms.RadioButton
    Private WithEvents rb_caja As System.Windows.Forms.RadioButton
    Private WithEvents rb_compras As System.Windows.Forms.RadioButton
    Private WithEvents rb_ventas As System.Windows.Forms.RadioButton
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Private WithEvents mtb_ayo As System.Windows.Forms.MaskedTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents gb_caja As System.Windows.Forms.GroupBox
    Private WithEvents mtb_fec_has As System.Windows.Forms.MaskedTextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents mtb_fec_des As System.Windows.Forms.MaskedTextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents rb_caja_egr As System.Windows.Forms.RadioButton
    Private WithEvents rb_caja_ing As System.Windows.Forms.RadioButton
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents mtb_fecha As System.Windows.Forms.MaskedTextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btn_Conta As System.Windows.Forms.Button
    Private WithEvents btn_Salir As System.Windows.Forms.Button
End Class
