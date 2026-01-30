<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_RP_LibDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_RP_LibDiario))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.mtb_ayo = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dgv_subdiarios = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.rdb_detallado = New System.Windows.Forms.RadioButton()
        Me.rdb_resumido = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.dgv_subdiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(522, 25)
        Me.ToolStrip1.TabIndex = 14
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
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.rdb_resumido)
        Me.groupBox2.Controls.Add(Me.rdb_detallado)
        Me.groupBox2.Controls.Add(Me.cmb_mes)
        Me.groupBox2.Controls.Add(Me.mtb_ayo)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.ForeColor = System.Drawing.Color.Navy
        Me.groupBox2.Location = New System.Drawing.Point(12, 28)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(495, 41)
        Me.groupBox2.TabIndex = 16
        Me.groupBox2.TabStop = False
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(113, 12)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(112, 21)
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
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(12, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Periodo"
        '
        'dgv_subdiarios
        '
        Me.dgv_subdiarios.AllowUserToAddRows = False
        Me.dgv_subdiarios.AllowUserToDeleteRows = False
        Me.dgv_subdiarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_subdiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_subdiarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.Cod, Me.Des})
        Me.dgv_subdiarios.Location = New System.Drawing.Point(11, 98)
        Me.dgv_subdiarios.Name = "dgv_subdiarios"
        Me.dgv_subdiarios.Size = New System.Drawing.Size(496, 233)
        Me.dgv_subdiarios.TabIndex = 19
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel."
        Me.Sel.Name = "Sel"
        Me.Sel.ReadOnly = True
        '
        'Cod
        '
        Me.Cod.HeaderText = "Codigo"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        '
        'Des
        '
        Me.Des.HeaderText = "Descripcion"
        Me.Des.Name = "Des"
        Me.Des.ReadOnly = True
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos.Location = New System.Drawing.Point(11, 75)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 18
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'rdb_detallado
        '
        Me.rdb_detallado.AutoSize = True
        Me.rdb_detallado.Checked = True
        Me.rdb_detallado.Location = New System.Drawing.Point(247, 15)
        Me.rdb_detallado.Name = "rdb_detallado"
        Me.rdb_detallado.Size = New System.Drawing.Size(70, 17)
        Me.rdb_detallado.TabIndex = 6
        Me.rdb_detallado.TabStop = True
        Me.rdb_detallado.Text = "Detallado"
        Me.rdb_detallado.UseVisualStyleBackColor = True
        '
        'rdb_resumido
        '
        Me.rdb_resumido.AutoSize = True
        Me.rdb_resumido.Location = New System.Drawing.Point(343, 15)
        Me.rdb_resumido.Name = "rdb_resumido"
        Me.rdb_resumido.Size = New System.Drawing.Size(72, 17)
        Me.rdb_resumido.TabIndex = 7
        Me.rdb_resumido.Text = "Resumido"
        Me.rdb_resumido.UseVisualStyleBackColor = True
        '
        'frm_CO_RP_LibDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 339)
        Me.Controls.Add(Me.dgv_subdiarios)
        Me.Controls.Add(Me.chk_todos)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_RP_LibDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro Diario"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.dgv_subdiarios, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents dgv_subdiarios As System.Windows.Forms.DataGridView
    Private WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Des As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_resumido As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_detallado As System.Windows.Forms.RadioButton
End Class
