<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_FT_Letras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_FT_Letras))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkVendedor = New System.Windows.Forms.CheckBox()
        Me.txtClienteInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtClienteInicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb_ambos = New System.Windows.Forms.RadioButton()
        Me.rdb_pendientes = New System.Windows.Forms.RadioButton()
        Me.rdb_canjeados = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ok, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(427, 25)
        Me.ToolStrip1.TabIndex = 188
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkVendedor)
        Me.GroupBox3.Controls.Add(Me.txtClienteInicialDesc)
        Me.GroupBox3.Controls.Add(Me.txtClienteInicial)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 71)
        Me.GroupBox3.TabIndex = 187
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles de Filtros"
        '
        'checkVendedor
        '
        Me.checkVendedor.AutoSize = True
        Me.checkVendedor.ForeColor = System.Drawing.Color.Navy
        Me.checkVendedor.Location = New System.Drawing.Point(13, 20)
        Me.checkVendedor.Name = "checkVendedor"
        Me.checkVendedor.Size = New System.Drawing.Size(111, 17)
        Me.checkVendedor.TabIndex = 182
        Me.checkVendedor.Text = "Todos los clientes"
        Me.checkVendedor.UseVisualStyleBackColor = True
        '
        'txtClienteInicialDesc
        '
        Me.txtClienteInicialDesc.BackColor = System.Drawing.Color.White
        Me.txtClienteInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteInicialDesc.Location = New System.Drawing.Point(137, 40)
        Me.txtClienteInicialDesc.Name = "txtClienteInicialDesc"
        Me.txtClienteInicialDesc.ReadOnly = True
        Me.txtClienteInicialDesc.Size = New System.Drawing.Size(257, 20)
        Me.txtClienteInicialDesc.TabIndex = 180
        '
        'txtClienteInicial
        '
        Me.txtClienteInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtClienteInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteInicial.Location = New System.Drawing.Point(50, 40)
        Me.txtClienteInicial.Name = "txtClienteInicial"
        Me.txtClienteInicial.ReadOnly = True
        Me.txtClienteInicial.Size = New System.Drawing.Size(81, 20)
        Me.txtClienteInicial.TabIndex = 176
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(9, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Cliente"
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
        Me.GroupBox4.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 47)
        Me.GroupBox4.TabIndex = 186
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(198, 24)
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
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Desde"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(258, 21)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(119, 21)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(49, 20)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(119, 21)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb_ambos)
        Me.GroupBox1.Controls.Add(Me.rdb_pendientes)
        Me.GroupBox1.Controls.Add(Me.rdb_canjeados)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 56)
        Me.GroupBox1.TabIndex = 189
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opción del Reporte"
        '
        'rdb_ambos
        '
        Me.rdb_ambos.AutoSize = True
        Me.rdb_ambos.Location = New System.Drawing.Point(287, 23)
        Me.rdb_ambos.Name = "rdb_ambos"
        Me.rdb_ambos.Size = New System.Drawing.Size(57, 17)
        Me.rdb_ambos.TabIndex = 2
        Me.rdb_ambos.TabStop = True
        Me.rdb_ambos.Text = "Ambos"
        Me.rdb_ambos.UseVisualStyleBackColor = True
        '
        'rdb_pendientes
        '
        Me.rdb_pendientes.AutoSize = True
        Me.rdb_pendientes.Location = New System.Drawing.Point(155, 23)
        Me.rdb_pendientes.Name = "rdb_pendientes"
        Me.rdb_pendientes.Size = New System.Drawing.Size(78, 17)
        Me.rdb_pendientes.TabIndex = 1
        Me.rdb_pendientes.TabStop = True
        Me.rdb_pendientes.Text = "Pendientes"
        Me.rdb_pendientes.UseVisualStyleBackColor = True
        '
        'rdb_canjeados
        '
        Me.rdb_canjeados.AutoSize = True
        Me.rdb_canjeados.Checked = True
        Me.rdb_canjeados.Location = New System.Drawing.Point(26, 23)
        Me.rdb_canjeados.Name = "rdb_canjeados"
        Me.rdb_canjeados.Size = New System.Drawing.Size(75, 17)
        Me.rdb_canjeados.TabIndex = 0
        Me.rdb_canjeados.TabStop = True
        Me.rdb_canjeados.Text = "Canjeados"
        Me.rdb_canjeados.UseVisualStyleBackColor = True
        '
        'Frm_FT_Letras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 239)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_FT_Letras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos vs Letras"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents checkVendedor As System.Windows.Forms.CheckBox
    Friend WithEvents txtClienteInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ambos As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_pendientes As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_canjeados As System.Windows.Forms.RadioButton
End Class
