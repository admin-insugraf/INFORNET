<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_RP_LibCajaBancos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_RP_LibCajaBancos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgv_cuentas = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_ctacte = New System.Windows.Forms.RadioButton()
        Me.rb_efectivo = New System.Windows.Forms.RadioButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.mtb_ayo = New System.Windows.Forms.MaskedTextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(399, 25)
        Me.ToolStrip1.TabIndex = 18
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
        'dgv_cuentas
        '
        Me.dgv_cuentas.AllowUserToAddRows = False
        Me.dgv_cuentas.AllowUserToDeleteRows = False
        Me.dgv_cuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.Cod, Me.Des})
        Me.dgv_cuentas.Location = New System.Drawing.Point(12, 140)
        Me.dgv_cuentas.Name = "dgv_cuentas"
        Me.dgv_cuentas.Size = New System.Drawing.Size(374, 184)
        Me.dgv_cuentas.TabIndex = 25
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel."
        Me.Sel.Name = "Sel"
        '
        'Cod
        '
        Me.Cod.HeaderText = "Codigo"
        Me.Cod.Name = "Cod"
        '
        'Des
        '
        Me.Des.HeaderText = "Descripcion"
        Me.Des.Name = "Des"
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(16, 120)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 24
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rb_ctacte)
        Me.groupBox1.Controls.Add(Me.rb_efectivo)
        Me.groupBox1.Location = New System.Drawing.Point(12, 75)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(374, 38)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        '
        'rb_ctacte
        '
        Me.rb_ctacte.AutoSize = True
        Me.rb_ctacte.ForeColor = System.Drawing.Color.Navy
        Me.rb_ctacte.Location = New System.Drawing.Point(159, 14)
        Me.rb_ctacte.Name = "rb_ctacte"
        Me.rb_ctacte.Size = New System.Drawing.Size(104, 17)
        Me.rb_ctacte.TabIndex = 4
        Me.rb_ctacte.Text = "Cuenta Corriente"
        Me.rb_ctacte.UseVisualStyleBackColor = True
        '
        'rb_efectivo
        '
        Me.rb_efectivo.AutoSize = True
        Me.rb_efectivo.Checked = True
        Me.rb_efectivo.ForeColor = System.Drawing.Color.Navy
        Me.rb_efectivo.Location = New System.Drawing.Point(68, 14)
        Me.rb_efectivo.Name = "rb_efectivo"
        Me.rb_efectivo.Size = New System.Drawing.Size(64, 17)
        Me.rb_efectivo.TabIndex = 3
        Me.rb_efectivo.TabStop = True
        Me.rb_efectivo.Text = "Efectivo"
        Me.rb_efectivo.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cmb_moneda)
        Me.groupBox2.Controls.Add(Me.cmb_mes)
        Me.groupBox2.Controls.Add(Me.mtb_ayo)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Location = New System.Drawing.Point(12, 28)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(374, 41)
        Me.groupBox2.TabIndex = 22
        Me.groupBox2.TabStop = False
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(298, 11)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(58, 21)
        Me.cmb_moneda.TabIndex = 2
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
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Navy
        Me.label1.Location = New System.Drawing.Point(246, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Moneda"
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
        'frm_CO_RP_LibCajaBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(399, 332)
        Me.Controls.Add(Me.dgv_cuentas)
        Me.Controls.Add(Me.chk_todos)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_RP_LibCajaBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro Caja Bancos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents dgv_cuentas As System.Windows.Forms.DataGridView
    Private WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Des As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents chk_todos As System.Windows.Forms.CheckBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rb_ctacte As System.Windows.Forms.RadioButton
    Private WithEvents rb_efectivo As System.Windows.Forms.RadioButton
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Private WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Private WithEvents mtb_ayo As System.Windows.Forms.MaskedTextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
End Class
