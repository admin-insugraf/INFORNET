<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_PLE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_PR_PLE))
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb_percepcion = New System.Windows.Forms.RadioButton()
        Me.chkregcompras_02_sire = New System.Windows.Forms.RadioButton()
        Me.chkregventas_sire = New System.Windows.Forms.RadioButton()
        Me.chkregcompras_sire = New System.Windows.Forms.RadioButton()
        Me.rdb_retenciones = New System.Windows.Forms.RadioButton()
        Me.txt_tope = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkdaot_ingresos = New System.Windows.Forms.RadioButton()
        Me.chkdaot_costos = New System.Windows.Forms.RadioButton()
        Me.chkregcompras_02 = New System.Windows.Forms.RadioButton()
        Me.chkplancuentas = New System.Windows.Forms.RadioButton()
        Me.chkmayor = New System.Windows.Forms.RadioButton()
        Me.chkdiario = New System.Windows.Forms.RadioButton()
        Me.chkregventas = New System.Windows.Forms.RadioButton()
        Me.chkregcompras = New System.Windows.Forms.RadioButton()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tool_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.rdb_4ta_categoria = New System.Windows.Forms.RadioButton()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.dtpfecha)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.ForeColor = System.Drawing.Color.Navy
        Me.groupBox2.Location = New System.Drawing.Point(12, 34)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(338, 41)
        Me.groupBox2.TabIndex = 7
        Me.groupBox2.TabStop = False
        '
        'dtpfecha
        '
        Me.dtpfecha.CustomFormat = "MMMM     -     yyyy "
        Me.dtpfecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha.Location = New System.Drawing.Point(83, 13)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(169, 21)
        Me.dtpfecha.TabIndex = 125
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(8, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Mes y Año"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.rdb_4ta_categoria)
        Me.GroupBox1.Controls.Add(Me.rdb_percepcion)
        Me.GroupBox1.Controls.Add(Me.chkregcompras_02_sire)
        Me.GroupBox1.Controls.Add(Me.chkregventas_sire)
        Me.GroupBox1.Controls.Add(Me.chkregcompras_sire)
        Me.GroupBox1.Controls.Add(Me.rdb_retenciones)
        Me.GroupBox1.Controls.Add(Me.txt_tope)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkdaot_ingresos)
        Me.GroupBox1.Controls.Add(Me.chkdaot_costos)
        Me.GroupBox1.Controls.Add(Me.chkregcompras_02)
        Me.GroupBox1.Controls.Add(Me.chkplancuentas)
        Me.GroupBox1.Controls.Add(Me.chkmayor)
        Me.GroupBox1.Controls.Add(Me.chkdiario)
        Me.GroupBox1.Controls.Add(Me.chkregventas)
        Me.GroupBox1.Controls.Add(Me.chkregcompras)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 381)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione..."
        '
        'rdb_percepcion
        '
        Me.rdb_percepcion.AutoSize = True
        Me.rdb_percepcion.Location = New System.Drawing.Point(22, 308)
        Me.rdb_percepcion.Name = "rdb_percepcion"
        Me.rdb_percepcion.Size = New System.Drawing.Size(146, 17)
        Me.rdb_percepcion.TabIndex = 21
        Me.rdb_percepcion.TabStop = True
        Me.rdb_percepcion.Text = "Comp. de Percepción"
        Me.rdb_percepcion.UseVisualStyleBackColor = True
        '
        'chkregcompras_02_sire
        '
        Me.chkregcompras_02_sire.AutoSize = True
        Me.chkregcompras_02_sire.Location = New System.Drawing.Point(22, 99)
        Me.chkregcompras_02_sire.Name = "chkregcompras_02_sire"
        Me.chkregcompras_02_sire.Size = New System.Drawing.Size(270, 17)
        Me.chkregcompras_02_sire.TabIndex = 20
        Me.chkregcompras_02_sire.TabStop = True
        Me.chkregcompras_02_sire.Text = "Registro de Compras No Domiciliados SIRE"
        Me.chkregcompras_02_sire.UseVisualStyleBackColor = True
        '
        'chkregventas_sire
        '
        Me.chkregventas_sire.AutoSize = True
        Me.chkregventas_sire.Location = New System.Drawing.Point(22, 146)
        Me.chkregventas_sire.Name = "chkregventas_sire"
        Me.chkregventas_sire.Size = New System.Drawing.Size(166, 17)
        Me.chkregventas_sire.TabIndex = 19
        Me.chkregventas_sire.TabStop = True
        Me.chkregventas_sire.Text = "Registro de Ventas SIRE"
        Me.chkregventas_sire.UseVisualStyleBackColor = True
        '
        'chkregcompras_sire
        '
        Me.chkregcompras_sire.AutoSize = True
        Me.chkregcompras_sire.Location = New System.Drawing.Point(22, 52)
        Me.chkregcompras_sire.Name = "chkregcompras_sire"
        Me.chkregcompras_sire.Size = New System.Drawing.Size(175, 17)
        Me.chkregcompras_sire.TabIndex = 18
        Me.chkregcompras_sire.TabStop = True
        Me.chkregcompras_sire.Text = "Registro de Compras SIRE"
        Me.chkregcompras_sire.UseVisualStyleBackColor = True
        '
        'rdb_retenciones
        '
        Me.rdb_retenciones.AutoSize = True
        Me.rdb_retenciones.Location = New System.Drawing.Point(22, 285)
        Me.rdb_retenciones.Name = "rdb_retenciones"
        Me.rdb_retenciones.Size = New System.Drawing.Size(140, 17)
        Me.rdb_retenciones.TabIndex = 17
        Me.rdb_retenciones.TabStop = True
        Me.rdb_retenciones.Text = "Comp. de Retención"
        Me.rdb_retenciones.UseVisualStyleBackColor = True
        '
        'txt_tope
        '
        Me.txt_tope.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tope.Location = New System.Drawing.Point(156, 256)
        Me.txt_tope.Name = "txt_tope"
        Me.txt_tope.Size = New System.Drawing.Size(59, 20)
        Me.txt_tope.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(165, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "TOPE"
        '
        'chkdaot_ingresos
        '
        Me.chkdaot_ingresos.AutoSize = True
        Me.chkdaot_ingresos.Location = New System.Drawing.Point(22, 262)
        Me.chkdaot_ingresos.Name = "chkdaot_ingresos"
        Me.chkdaot_ingresos.Size = New System.Drawing.Size(111, 17)
        Me.chkdaot_ingresos.TabIndex = 13
        Me.chkdaot_ingresos.TabStop = True
        Me.chkdaot_ingresos.Text = "DAOT Ingresos"
        Me.chkdaot_ingresos.UseVisualStyleBackColor = True
        '
        'chkdaot_costos
        '
        Me.chkdaot_costos.AutoSize = True
        Me.chkdaot_costos.Location = New System.Drawing.Point(22, 239)
        Me.chkdaot_costos.Name = "chkdaot_costos"
        Me.chkdaot_costos.Size = New System.Drawing.Size(101, 17)
        Me.chkdaot_costos.TabIndex = 12
        Me.chkdaot_costos.TabStop = True
        Me.chkdaot_costos.Text = "DAOT Costos"
        Me.chkdaot_costos.UseVisualStyleBackColor = True
        '
        'chkregcompras_02
        '
        Me.chkregcompras_02.AutoSize = True
        Me.chkregcompras_02.Location = New System.Drawing.Point(22, 77)
        Me.chkregcompras_02.Name = "chkregcompras_02"
        Me.chkregcompras_02.Size = New System.Drawing.Size(237, 17)
        Me.chkregcompras_02.TabIndex = 11
        Me.chkregcompras_02.TabStop = True
        Me.chkregcompras_02.Text = "Registro de Compras No Domiciliados"
        Me.chkregcompras_02.UseVisualStyleBackColor = True
        '
        'chkplancuentas
        '
        Me.chkplancuentas.AutoSize = True
        Me.chkplancuentas.Location = New System.Drawing.Point(22, 216)
        Me.chkplancuentas.Name = "chkplancuentas"
        Me.chkplancuentas.Size = New System.Drawing.Size(118, 17)
        Me.chkplancuentas.TabIndex = 10
        Me.chkplancuentas.TabStop = True
        Me.chkplancuentas.Text = "Plan de Cuentas"
        Me.chkplancuentas.UseVisualStyleBackColor = True
        '
        'chkmayor
        '
        Me.chkmayor.AutoSize = True
        Me.chkmayor.Location = New System.Drawing.Point(22, 193)
        Me.chkmayor.Name = "chkmayor"
        Me.chkmayor.Size = New System.Drawing.Size(91, 17)
        Me.chkmayor.TabIndex = 9
        Me.chkmayor.TabStop = True
        Me.chkmayor.Text = "Libro Mayor"
        Me.chkmayor.UseVisualStyleBackColor = True
        '
        'chkdiario
        '
        Me.chkdiario.AutoSize = True
        Me.chkdiario.Location = New System.Drawing.Point(22, 170)
        Me.chkdiario.Name = "chkdiario"
        Me.chkdiario.Size = New System.Drawing.Size(90, 17)
        Me.chkdiario.TabIndex = 8
        Me.chkdiario.TabStop = True
        Me.chkdiario.Text = "Libro Diario"
        Me.chkdiario.UseVisualStyleBackColor = True
        '
        'chkregventas
        '
        Me.chkregventas.AutoSize = True
        Me.chkregventas.Location = New System.Drawing.Point(22, 122)
        Me.chkregventas.Name = "chkregventas"
        Me.chkregventas.Size = New System.Drawing.Size(133, 17)
        Me.chkregventas.TabIndex = 7
        Me.chkregventas.TabStop = True
        Me.chkregventas.Text = "Registro de Ventas"
        Me.chkregventas.UseVisualStyleBackColor = True
        '
        'chkregcompras
        '
        Me.chkregcompras.AutoSize = True
        Me.chkregcompras.Location = New System.Drawing.Point(22, 26)
        Me.chkregcompras.Name = "chkregcompras"
        Me.chkregcompras.Size = New System.Drawing.Size(142, 17)
        Me.chkregcompras.TabIndex = 6
        Me.chkregcompras.TabStop = True
        Me.chkregcompras.Text = "Registro de Compras"
        Me.chkregcompras.UseVisualStyleBackColor = True
        '
        'toolStrip1
        '
        Me.toolStrip1.BackColor = System.Drawing.Color.White
        Me.toolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool_nuevo, Me.tool_salir})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(362, 25)
        Me.toolStrip1.TabIndex = 9
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tool_nuevo
        '
        Me.tool_nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tool_nuevo.ForeColor = System.Drawing.Color.Navy
        Me.tool_nuevo.Image = CType(resources.GetObject("tool_nuevo.Image"), System.Drawing.Image)
        Me.tool_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_nuevo.Name = "tool_nuevo"
        Me.tool_nuevo.Size = New System.Drawing.Size(73, 22)
        Me.tool_nuevo.Text = "&Generar"
        '
        'tool_salir
        '
        Me.tool_salir.ForeColor = System.Drawing.Color.Navy
        Me.tool_salir.Image = CType(resources.GetObject("tool_salir.Image"), System.Drawing.Image)
        Me.tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_salir.Name = "tool_salir"
        Me.tool_salir.Size = New System.Drawing.Size(52, 22)
        Me.tool_salir.Text = "&Salir"
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(12, 96)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(307, 20)
        Me.txtRuta.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Ruta :"
        '
        'btnRuta
        '
        Me.btnRuta.Location = New System.Drawing.Point(325, 95)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(25, 23)
        Me.btnRuta.TabIndex = 15
        Me.btnRuta.Text = "..."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'rdb_4ta_categoria
        '
        Me.rdb_4ta_categoria.AutoSize = True
        Me.rdb_4ta_categoria.Location = New System.Drawing.Point(22, 333)
        Me.rdb_4ta_categoria.Name = "rdb_4ta_categoria"
        Me.rdb_4ta_categoria.Size = New System.Drawing.Size(207, 17)
        Me.rdb_4ta_categoria.TabIndex = 22
        Me.rdb_4ta_categoria.TabStop = True
        Me.rdb_4ta_categoria.Text = "Pres. Servicios de 4ta categoria"
        Me.rdb_4ta_categoria.UseVisualStyleBackColor = True
        '
        'CO_PR_PLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 515)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRuta)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CO_PR_PLE"
        Me.Text = "Programa de Libros Electronicos - PLE"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tool_nuevo As System.Windows.Forms.ToolStripButton
    Private WithEvents tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkplancuentas As System.Windows.Forms.RadioButton
    Friend WithEvents chkmayor As System.Windows.Forms.RadioButton
    Friend WithEvents chkdiario As System.Windows.Forms.RadioButton
    Friend WithEvents chkregventas As System.Windows.Forms.RadioButton
    Friend WithEvents chkregcompras As System.Windows.Forms.RadioButton
    Friend WithEvents chkregcompras_02 As System.Windows.Forms.RadioButton
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents chkdaot_costos As System.Windows.Forms.RadioButton
    Friend WithEvents chkdaot_ingresos As System.Windows.Forms.RadioButton
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txt_tope As System.Windows.Forms.TextBox
    Friend WithEvents rdb_retenciones As System.Windows.Forms.RadioButton
    Friend WithEvents chkregventas_sire As System.Windows.Forms.RadioButton
    Friend WithEvents chkregcompras_sire As System.Windows.Forms.RadioButton
    Friend WithEvents chkregcompras_02_sire As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_percepcion As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_4ta_categoria As System.Windows.Forms.RadioButton
End Class
