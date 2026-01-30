<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Cliente_Producto_Familia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_Cliente_Producto_Familia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb_resumido = New System.Windows.Forms.RadioButton()
        Me.rdb_detallado = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_productos = New System.Windows.Forms.CheckBox()
        Me.txtProductoInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtProductoInicial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkVendedor = New System.Windows.Forms.CheckBox()
        Me.txtClienteInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtClienteInicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb_resumido)
        Me.GroupBox1.Controls.Add(Me.rdb_detallado)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 61)
        Me.GroupBox1.TabIndex = 187
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opción del Reporte"
        '
        'rdb_resumido
        '
        Me.rdb_resumido.AutoSize = True
        Me.rdb_resumido.Location = New System.Drawing.Point(280, 26)
        Me.rdb_resumido.Name = "rdb_resumido"
        Me.rdb_resumido.Size = New System.Drawing.Size(72, 17)
        Me.rdb_resumido.TabIndex = 1
        Me.rdb_resumido.TabStop = True
        Me.rdb_resumido.Text = "Resumido"
        Me.rdb_resumido.UseVisualStyleBackColor = True
        '
        'rdb_detallado
        '
        Me.rdb_detallado.AutoSize = True
        Me.rdb_detallado.Checked = True
        Me.rdb_detallado.Location = New System.Drawing.Point(107, 26)
        Me.rdb_detallado.Name = "rdb_detallado"
        Me.rdb_detallado.Size = New System.Drawing.Size(70, 17)
        Me.rdb_detallado.TabIndex = 0
        Me.rdb_detallado.TabStop = True
        Me.rdb_detallado.Text = "Detallado"
        Me.rdb_detallado.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ok, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(481, 25)
        Me.ToolStrip1.TabIndex = 186
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
        Me.GroupBox3.Controls.Add(Me.chk_productos)
        Me.GroupBox3.Controls.Add(Me.txtProductoInicialDesc)
        Me.GroupBox3.Controls.Add(Me.txtProductoInicial)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.checkVendedor)
        Me.GroupBox3.Controls.Add(Me.txtClienteInicialDesc)
        Me.GroupBox3.Controls.Add(Me.txtClienteInicial)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(454, 130)
        Me.GroupBox3.TabIndex = 185
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles de Filtros"
        '
        'chk_productos
        '
        Me.chk_productos.AutoSize = True
        Me.chk_productos.ForeColor = System.Drawing.Color.Navy
        Me.chk_productos.Location = New System.Drawing.Point(12, 74)
        Me.chk_productos.Name = "chk_productos"
        Me.chk_productos.Size = New System.Drawing.Size(109, 17)
        Me.chk_productos.TabIndex = 186
        Me.chk_productos.Text = "Todos las familias"
        Me.chk_productos.UseVisualStyleBackColor = True
        '
        'txtProductoInicialDesc
        '
        Me.txtProductoInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductoInicialDesc.Location = New System.Drawing.Point(155, 94)
        Me.txtProductoInicialDesc.Name = "txtProductoInicialDesc"
        Me.txtProductoInicialDesc.ReadOnly = True
        Me.txtProductoInicialDesc.Size = New System.Drawing.Size(284, 20)
        Me.txtProductoInicialDesc.TabIndex = 185
        '
        'txtProductoInicial
        '
        Me.txtProductoInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtProductoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductoInicial.Location = New System.Drawing.Point(50, 94)
        Me.txtProductoInicial.Name = "txtProductoInicial"
        Me.txtProductoInicial.ReadOnly = True
        Me.txtProductoInicial.Size = New System.Drawing.Size(99, 20)
        Me.txtProductoInicial.TabIndex = 183
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Familia"
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
        Me.txtClienteInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteInicialDesc.Location = New System.Drawing.Point(156, 40)
        Me.txtClienteInicialDesc.Name = "txtClienteInicialDesc"
        Me.txtClienteInicialDesc.ReadOnly = True
        Me.txtClienteInicialDesc.Size = New System.Drawing.Size(284, 20)
        Me.txtClienteInicialDesc.TabIndex = 180
        '
        'txtClienteInicial
        '
        Me.txtClienteInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtClienteInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteInicial.Location = New System.Drawing.Point(51, 40)
        Me.txtClienteInicial.Name = "txtClienteInicial"
        Me.txtClienteInicial.ReadOnly = True
        Me.txtClienteInicial.Size = New System.Drawing.Size(99, 20)
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
        Me.GroupBox4.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(454, 47)
        Me.GroupBox4.TabIndex = 184
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
        'Frm_Reporte_Cliente_Producto_Familia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(481, 296)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Reporte_Cliente_Producto_Familia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Cliente por Familia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_resumido As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_detallado As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_productos As System.Windows.Forms.CheckBox
    Friend WithEvents txtProductoInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtProductoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents checkVendedor As System.Windows.Forms.CheckBox
    Friend WithEvents txtClienteInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
End Class
