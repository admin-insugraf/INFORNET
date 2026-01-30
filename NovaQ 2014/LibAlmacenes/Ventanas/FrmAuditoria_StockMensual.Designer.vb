<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuditoria_StockMensual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAuditoria_StockMensual))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chklstAlmacenes = New System.Windows.Forms.CheckedListBox()
        Me.checkAlmacen = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfechafin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.gbArticulos = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_des_tipo_articulo = New System.Windows.Forms.TextBox()
        Me.txt_tipo_articulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfamiliadesc = New System.Windows.Forms.TextBox()
        Me.txtarticuloInicial = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_menos_todos = New System.Windows.Forms.Button()
        Me.btn_mas_todos = New System.Windows.Forms.Button()
        Me.dgv_lista_proveedor = New System.Windows.Forms.DataGridView()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.btn_menos = New System.Windows.Forms.Button()
        Me.btn_mas = New System.Windows.Forms.Button()
        Me.dgv_proveedor = New System.Windows.Forms.DataGridView()
        Me.rb_positvo = New System.Windows.Forms.RadioButton()
        Me.rb_negativo = New System.Windows.Forms.RadioButton()
        Me.rb_todos = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbArticulos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_lista_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(972, 25)
        Me.ToolStrip1.TabIndex = 197
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(118, 22)
        Me.btnMostrar.Text = "&Mostrar reporte"
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.chklstAlmacenes)
        Me.GroupBox2.Controls.Add(Me.checkAlmacen)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(7, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 321)
        Me.GroupBox2.TabIndex = 195
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione un Almacen"
        '
        'chklstAlmacenes
        '
        Me.chklstAlmacenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chklstAlmacenes.CheckOnClick = True
        Me.chklstAlmacenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstAlmacenes.FormattingEnabled = True
        Me.chklstAlmacenes.Location = New System.Drawing.Point(17, 41)
        Me.chklstAlmacenes.Name = "chklstAlmacenes"
        Me.chklstAlmacenes.Size = New System.Drawing.Size(238, 274)
        Me.chklstAlmacenes.TabIndex = 3
        '
        'checkAlmacen
        '
        Me.checkAlmacen.AutoSize = True
        Me.checkAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkAlmacen.ForeColor = System.Drawing.Color.Navy
        Me.checkAlmacen.Location = New System.Drawing.Point(19, 18)
        Me.checkAlmacen.Name = "checkAlmacen"
        Me.checkAlmacen.Size = New System.Drawing.Size(92, 17)
        Me.checkAlmacen.TabIndex = 2
        Me.checkAlmacen.Text = "Activar Todos"
        Me.checkAlmacen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 84)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.rb_todos)
        Me.GroupBox3.Controls.Add(Me.rb_negativo)
        Me.GroupBox3.Controls.Add(Me.rb_positvo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dtpfechafin)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(378, 66)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'dtpfechafin
        '
        Me.dtpfechafin.CustomFormat = "dd/MM/yyyy"
        Me.dtpfechafin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechafin.Location = New System.Drawing.Point(203, 13)
        Me.dtpfechafin.Name = "dtpfechafin"
        Me.dtpfechafin.Size = New System.Drawing.Size(95, 20)
        Me.dtpfechafin.TabIndex = 1
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechaInicio.Location = New System.Drawing.Point(49, 13)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtpfechaInicio.TabIndex = 0
        '
        'gbArticulos
        '
        Me.gbArticulos.BackColor = System.Drawing.Color.White
        Me.gbArticulos.Controls.Add(Me.Label4)
        Me.gbArticulos.Controls.Add(Me.txt_des_tipo_articulo)
        Me.gbArticulos.Controls.Add(Me.txt_tipo_articulo)
        Me.gbArticulos.Controls.Add(Me.Label3)
        Me.gbArticulos.Controls.Add(Me.txtfamiliadesc)
        Me.gbArticulos.Controls.Add(Me.txtarticuloInicial)
        Me.gbArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbArticulos.ForeColor = System.Drawing.Color.Navy
        Me.gbArticulos.Location = New System.Drawing.Point(406, 33)
        Me.gbArticulos.Name = "gbArticulos"
        Me.gbArticulos.Size = New System.Drawing.Size(393, 84)
        Me.gbArticulos.TabIndex = 196
        Me.gbArticulos.TabStop = False
        Me.gbArticulos.Text = "Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "T. de Articulo"
        '
        'txt_des_tipo_articulo
        '
        Me.txt_des_tipo_articulo.BackColor = System.Drawing.Color.White
        Me.txt_des_tipo_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_tipo_articulo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_des_tipo_articulo.Location = New System.Drawing.Point(153, 47)
        Me.txt_des_tipo_articulo.Name = "txt_des_tipo_articulo"
        Me.txt_des_tipo_articulo.ReadOnly = True
        Me.txt_des_tipo_articulo.Size = New System.Drawing.Size(231, 22)
        Me.txt_des_tipo_articulo.TabIndex = 13
        '
        'txt_tipo_articulo
        '
        Me.txt_tipo_articulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_tipo_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipo_articulo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipo_articulo.Location = New System.Drawing.Point(90, 47)
        Me.txt_tipo_articulo.Name = "txt_tipo_articulo"
        Me.txt_tipo_articulo.ReadOnly = True
        Me.txt_tipo_articulo.Size = New System.Drawing.Size(57, 22)
        Me.txt_tipo_articulo.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Familia"
        '
        'txtfamiliadesc
        '
        Me.txtfamiliadesc.BackColor = System.Drawing.Color.White
        Me.txtfamiliadesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfamiliadesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfamiliadesc.Location = New System.Drawing.Point(153, 19)
        Me.txtfamiliadesc.Name = "txtfamiliadesc"
        Me.txtfamiliadesc.ReadOnly = True
        Me.txtfamiliadesc.Size = New System.Drawing.Size(231, 22)
        Me.txtfamiliadesc.TabIndex = 10
        '
        'txtarticuloInicial
        '
        Me.txtarticuloInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtarticuloInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtarticuloInicial.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarticuloInicial.Location = New System.Drawing.Point(90, 19)
        Me.txtarticuloInicial.Name = "txtarticuloInicial"
        Me.txtarticuloInicial.ReadOnly = True
        Me.txtarticuloInicial.Size = New System.Drawing.Size(57, 22)
        Me.txtarticuloInicial.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.btn_menos_todos)
        Me.GroupBox4.Controls.Add(Me.btn_mas_todos)
        Me.GroupBox4.Controls.Add(Me.dgv_lista_proveedor)
        Me.GroupBox4.Controls.Add(Me.txtbusqueda)
        Me.GroupBox4.Controls.Add(Me.btn_menos)
        Me.GroupBox4.Controls.Add(Me.btn_mas)
        Me.GroupBox4.Controls.Add(Me.dgv_proveedor)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(279, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(668, 321)
        Me.GroupBox4.TabIndex = 198
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Seleccione un Producto"
        '
        'btn_menos_todos
        '
        Me.btn_menos_todos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_menos_todos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menos_todos.Location = New System.Drawing.Point(311, 197)
        Me.btn_menos_todos.Name = "btn_menos_todos"
        Me.btn_menos_todos.Size = New System.Drawing.Size(41, 36)
        Me.btn_menos_todos.TabIndex = 162
        Me.btn_menos_todos.Text = "<<"
        Me.btn_menos_todos.UseVisualStyleBackColor = True
        '
        'btn_mas_todos
        '
        Me.btn_mas_todos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_mas_todos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mas_todos.Location = New System.Drawing.Point(311, 45)
        Me.btn_mas_todos.Name = "btn_mas_todos"
        Me.btn_mas_todos.Size = New System.Drawing.Size(41, 36)
        Me.btn_mas_todos.TabIndex = 161
        Me.btn_mas_todos.Text = ">>"
        Me.btn_mas_todos.UseVisualStyleBackColor = True
        '
        'dgv_lista_proveedor
        '
        Me.dgv_lista_proveedor.AllowUserToAddRows = False
        Me.dgv_lista_proveedor.AllowUserToDeleteRows = False
        Me.dgv_lista_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_proveedor.Location = New System.Drawing.Point(6, 40)
        Me.dgv_lista_proveedor.Name = "dgv_lista_proveedor"
        Me.dgv_lista_proveedor.ReadOnly = True
        Me.dgv_lista_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_proveedor.Size = New System.Drawing.Size(299, 274)
        Me.dgv_lista_proveedor.TabIndex = 160
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbusqueda.BackColor = System.Drawing.Color.Aquamarine
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbusqueda.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(6, 15)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(299, 22)
        Me.txtbusqueda.TabIndex = 159
        '
        'btn_menos
        '
        Me.btn_menos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_menos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menos.Location = New System.Drawing.Point(311, 159)
        Me.btn_menos.Name = "btn_menos"
        Me.btn_menos.Size = New System.Drawing.Size(41, 36)
        Me.btn_menos.TabIndex = 158
        Me.btn_menos.Text = "<"
        Me.btn_menos.UseVisualStyleBackColor = True
        '
        'btn_mas
        '
        Me.btn_mas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_mas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mas.Location = New System.Drawing.Point(311, 83)
        Me.btn_mas.Name = "btn_mas"
        Me.btn_mas.Size = New System.Drawing.Size(41, 36)
        Me.btn_mas.TabIndex = 157
        Me.btn_mas.Text = ">"
        Me.btn_mas.UseVisualStyleBackColor = True
        '
        'dgv_proveedor
        '
        Me.dgv_proveedor.AllowUserToAddRows = False
        Me.dgv_proveedor.AllowUserToDeleteRows = False
        Me.dgv_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedor.Location = New System.Drawing.Point(358, 40)
        Me.dgv_proveedor.Name = "dgv_proveedor"
        Me.dgv_proveedor.ReadOnly = True
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_proveedor.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_proveedor.Size = New System.Drawing.Size(299, 274)
        Me.dgv_proveedor.TabIndex = 156
        '
        'rb_positvo
        '
        Me.rb_positvo.AutoSize = True
        Me.rb_positvo.Location = New System.Drawing.Point(49, 43)
        Me.rb_positvo.Name = "rb_positvo"
        Me.rb_positvo.Size = New System.Drawing.Size(62, 17)
        Me.rb_positvo.TabIndex = 4
        Me.rb_positvo.TabStop = True
        Me.rb_positvo.Text = "Positivo"
        Me.rb_positvo.UseVisualStyleBackColor = True
        '
        'rb_negativo
        '
        Me.rb_negativo.AutoSize = True
        Me.rb_negativo.Location = New System.Drawing.Point(126, 43)
        Me.rb_negativo.Name = "rb_negativo"
        Me.rb_negativo.Size = New System.Drawing.Size(68, 17)
        Me.rb_negativo.TabIndex = 5
        Me.rb_negativo.TabStop = True
        Me.rb_negativo.Text = "Negativo"
        Me.rb_negativo.UseVisualStyleBackColor = True
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Checked = True
        Me.rb_todos.Location = New System.Drawing.Point(214, 43)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(55, 17)
        Me.rb_todos.TabIndex = 6
        Me.rb_todos.TabStop = True
        Me.rb_todos.Text = "Todos"
        Me.rb_todos.UseVisualStyleBackColor = True
        '
        'FrmAuditoria_StockMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(972, 455)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbArticulos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAuditoria_StockMensual"
        Me.Text = "Auditoria - Stock Mensual"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbArticulos.ResumeLayout(False)
        Me.gbArticulos.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgv_lista_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chklstAlmacenes As System.Windows.Forms.CheckedListBox
    Friend WithEvents checkAlmacen As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents txtfamiliadesc As System.Windows.Forms.TextBox
    Friend WithEvents txtarticuloInicial As System.Windows.Forms.TextBox
    Friend WithEvents dtpfechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_des_tipo_articulo As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo_articulo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents btn_mas As System.Windows.Forms.Button
    Friend WithEvents btn_menos As System.Windows.Forms.Button
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dgv_lista_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents btn_menos_todos As System.Windows.Forms.Button
    Friend WithEvents btn_mas_todos As System.Windows.Forms.Button
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_negativo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_positvo As System.Windows.Forms.RadioButton
End Class
