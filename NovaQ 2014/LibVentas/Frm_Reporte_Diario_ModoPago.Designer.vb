<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Diario_ModoPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_Diario_ModoPago))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txt_desc_estado = New System.Windows.Forms.TextBox()
        Me.txt_cod_estado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.rdb_resumido = New System.Windows.Forms.RadioButton()
        Me.rdb_detallado = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chk_list_vendedor = New System.Windows.Forms.CheckedListBox()
        Me.chk_vendedor = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_list_forma_pago = New System.Windows.Forms.CheckedListBox()
        Me.chk_todos_forma_pago = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_list_series = New System.Windows.Forms.CheckedListBox()
        Me.chk_series = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txt_desc_estado)
        Me.GroupBox1.Controls.Add(Me.txt_cod_estado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 71)
        Me.GroupBox1.TabIndex = 196
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modo de Pago"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox1.Location = New System.Drawing.Point(13, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 182
        Me.CheckBox1.Text = "Todos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txt_desc_estado
        '
        Me.txt_desc_estado.BackColor = System.Drawing.Color.White
        Me.txt_desc_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_estado.Location = New System.Drawing.Point(137, 40)
        Me.txt_desc_estado.Name = "txt_desc_estado"
        Me.txt_desc_estado.ReadOnly = True
        Me.txt_desc_estado.Size = New System.Drawing.Size(257, 20)
        Me.txt_desc_estado.TabIndex = 180
        '
        'txt_cod_estado
        '
        Me.txt_cod_estado.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_estado.Location = New System.Drawing.Point(63, 40)
        Me.txt_cod_estado.Name = "txt_cod_estado"
        Me.txt_cod_estado.ReadOnly = True
        Me.txt_cod_estado.Size = New System.Drawing.Size(68, 20)
        Me.txt_cod_estado.TabIndex = 176
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Modo P."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ok, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(689, 25)
        Me.ToolStrip1.TabIndex = 195
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(118, 22)
        Me.btn_ok.Text = "&Mostrar reporte"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox4.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 47)
        Me.GroupBox4.TabIndex = 193
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(198, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hasta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(24, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Desde"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(240, 19)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(107, 21)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(69, 19)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(107, 21)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'rdb_resumido
        '
        Me.rdb_resumido.AutoSize = True
        Me.rdb_resumido.Checked = True
        Me.rdb_resumido.Location = New System.Drawing.Point(98, 385)
        Me.rdb_resumido.Name = "rdb_resumido"
        Me.rdb_resumido.Size = New System.Drawing.Size(72, 17)
        Me.rdb_resumido.TabIndex = 197
        Me.rdb_resumido.TabStop = True
        Me.rdb_resumido.Text = "Resumido"
        Me.rdb_resumido.UseVisualStyleBackColor = True
        '
        'rdb_detallado
        '
        Me.rdb_detallado.AutoSize = True
        Me.rdb_detallado.Location = New System.Drawing.Point(242, 385)
        Me.rdb_detallado.Name = "rdb_detallado"
        Me.rdb_detallado.Size = New System.Drawing.Size(70, 17)
        Me.rdb_detallado.TabIndex = 198
        Me.rdb_detallado.TabStop = True
        Me.rdb_detallado.Text = "Detallado"
        Me.rdb_detallado.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chk_list_vendedor)
        Me.GroupBox8.Controls.Add(Me.chk_vendedor)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(418, 42)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(262, 177)
        Me.GroupBox8.TabIndex = 199
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Vendedor"
        '
        'chk_list_vendedor
        '
        Me.chk_list_vendedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_list_vendedor.CheckOnClick = True
        Me.chk_list_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_list_vendedor.FormattingEnabled = True
        Me.chk_list_vendedor.Location = New System.Drawing.Point(8, 37)
        Me.chk_list_vendedor.Name = "chk_list_vendedor"
        Me.chk_list_vendedor.Size = New System.Drawing.Size(245, 124)
        Me.chk_list_vendedor.TabIndex = 5
        '
        'chk_vendedor
        '
        Me.chk_vendedor.AutoSize = True
        Me.chk_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_vendedor.ForeColor = System.Drawing.Color.Navy
        Me.chk_vendedor.Location = New System.Drawing.Point(10, 18)
        Me.chk_vendedor.Name = "chk_vendedor"
        Me.chk_vendedor.Size = New System.Drawing.Size(92, 17)
        Me.chk_vendedor.TabIndex = 4
        Me.chk_vendedor.Text = "Activar Todos"
        Me.chk_vendedor.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_list_forma_pago)
        Me.GroupBox2.Controls.Add(Me.chk_todos_forma_pago)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 200)
        Me.GroupBox2.TabIndex = 200
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'chk_list_forma_pago
        '
        Me.chk_list_forma_pago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_list_forma_pago.CheckOnClick = True
        Me.chk_list_forma_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_list_forma_pago.FormattingEnabled = True
        Me.chk_list_forma_pago.Location = New System.Drawing.Point(8, 37)
        Me.chk_list_forma_pago.Name = "chk_list_forma_pago"
        Me.chk_list_forma_pago.Size = New System.Drawing.Size(383, 139)
        Me.chk_list_forma_pago.TabIndex = 5
        '
        'chk_todos_forma_pago
        '
        Me.chk_todos_forma_pago.AutoSize = True
        Me.chk_todos_forma_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_todos_forma_pago.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_forma_pago.Location = New System.Drawing.Point(10, 18)
        Me.chk_todos_forma_pago.Name = "chk_todos_forma_pago"
        Me.chk_todos_forma_pago.Size = New System.Drawing.Size(92, 17)
        Me.chk_todos_forma_pago.TabIndex = 4
        Me.chk_todos_forma_pago.Text = "Activar Todos"
        Me.chk_todos_forma_pago.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk_list_series)
        Me.GroupBox3.Controls.Add(Me.chk_series)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(418, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 177)
        Me.GroupBox3.TabIndex = 201
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Series"
        '
        'chk_list_series
        '
        Me.chk_list_series.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_list_series.CheckOnClick = True
        Me.chk_list_series.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_list_series.FormattingEnabled = True
        Me.chk_list_series.Location = New System.Drawing.Point(8, 37)
        Me.chk_list_series.Name = "chk_list_series"
        Me.chk_list_series.Size = New System.Drawing.Size(245, 124)
        Me.chk_list_series.TabIndex = 5
        '
        'chk_series
        '
        Me.chk_series.AutoSize = True
        Me.chk_series.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_series.ForeColor = System.Drawing.Color.Navy
        Me.chk_series.Location = New System.Drawing.Point(10, 18)
        Me.chk_series.Name = "chk_series"
        Me.chk_series.Size = New System.Drawing.Size(92, 17)
        Me.chk_series.TabIndex = 4
        Me.chk_series.Text = "Activar Todos"
        Me.chk_series.UseVisualStyleBackColor = True
        '
        'Frm_Reporte_Diario_ModoPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(689, 416)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.rdb_detallado)
        Me.Controls.Add(Me.rdb_resumido)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Reporte_Diario_ModoPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Diario Modo de Pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_desc_estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdb_resumido As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_detallado As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_list_vendedor As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_vendedor As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_list_forma_pago As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_todos_forma_pago As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_list_series As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_series As System.Windows.Forms.CheckBox
End Class
