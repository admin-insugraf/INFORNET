<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKardexArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKardexArticulos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chklstAlmacenes = New System.Windows.Forms.CheckedListBox()
        Me.checkAlmacen = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.gbArticulos = New System.Windows.Forms.GroupBox()
        Me.checkLote = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtarticulofinal = New System.Windows.Forms.TextBox()
        Me.txtarticuloInicial = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optresumido = New System.Windows.Forms.RadioButton()
        Me.optdetallado = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbArticulos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(422, 25)
        Me.ToolStrip1.TabIndex = 201
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
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.chklstAlmacenes)
        Me.GroupBox2.Controls.Add(Me.checkAlmacen)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 193)
        Me.GroupBox2.TabIndex = 199
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione un Almacen"
        '
        'chklstAlmacenes
        '
        Me.chklstAlmacenes.CheckOnClick = True
        Me.chklstAlmacenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstAlmacenes.FormattingEnabled = True
        Me.chklstAlmacenes.Location = New System.Drawing.Point(17, 41)
        Me.chklstAlmacenes.Name = "chklstAlmacenes"
        Me.chklstAlmacenes.Size = New System.Drawing.Size(376, 139)
        Me.chklstAlmacenes.TabIndex = 6
        '
        'checkAlmacen
        '
        Me.checkAlmacen.AutoSize = True
        Me.checkAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkAlmacen.ForeColor = System.Drawing.Color.Navy
        Me.checkAlmacen.Location = New System.Drawing.Point(19, 18)
        Me.checkAlmacen.Name = "checkAlmacen"
        Me.checkAlmacen.Size = New System.Drawing.Size(92, 17)
        Me.checkAlmacen.TabIndex = 7
        Me.checkAlmacen.Text = "Activar Todos"
        Me.checkAlmacen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 62)
        Me.GroupBox1.TabIndex = 198
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mes de consulta"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 43)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(179, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "AL"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.CustomFormat = ""
        Me.dtpfechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(219, 12)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(154, 20)
        Me.dtpfechaFin.TabIndex = 5
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.CustomFormat = ""
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(11, 11)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(154, 20)
        Me.dtpfechaInicio.TabIndex = 4
        '
        'gbArticulos
        '
        Me.gbArticulos.BackColor = System.Drawing.Color.White
        Me.gbArticulos.Controls.Add(Me.checkLote)
        Me.gbArticulos.Controls.Add(Me.Label4)
        Me.gbArticulos.Controls.Add(Me.Label3)
        Me.gbArticulos.Controls.Add(Me.txtarticulofinal)
        Me.gbArticulos.Controls.Add(Me.txtarticuloInicial)
        Me.gbArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbArticulos.ForeColor = System.Drawing.Color.Navy
        Me.gbArticulos.Location = New System.Drawing.Point(12, 357)
        Me.gbArticulos.Name = "gbArticulos"
        Me.gbArticulos.Size = New System.Drawing.Size(400, 74)
        Me.gbArticulos.TabIndex = 200
        Me.gbArticulos.TabStop = False
        Me.gbArticulos.Text = "Articulos"
        '
        'checkLote
        '
        Me.checkLote.AutoSize = True
        Me.checkLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkLote.ForeColor = System.Drawing.Color.Navy
        Me.checkLote.Location = New System.Drawing.Point(17, 47)
        Me.checkLote.Name = "checkLote"
        Me.checkLote.Size = New System.Drawing.Size(114, 17)
        Me.checkLote.TabIndex = 13
        Me.checkLote.Text = "Todos los articulos"
        Me.checkLote.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(188, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(21, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Desde"
        '
        'txtarticulofinal
        '
        Me.txtarticulofinal.BackColor = System.Drawing.Color.Aquamarine
        Me.txtarticulofinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtarticulofinal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarticulofinal.Location = New System.Drawing.Point(226, 20)
        Me.txtarticulofinal.Name = "txtarticulofinal"
        Me.txtarticulofinal.ReadOnly = True
        Me.txtarticulofinal.Size = New System.Drawing.Size(112, 22)
        Me.txtarticulofinal.TabIndex = 10
        '
        'txtarticuloInicial
        '
        Me.txtarticuloInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtarticuloInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtarticuloInicial.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarticuloInicial.Location = New System.Drawing.Point(72, 20)
        Me.txtarticuloInicial.Name = "txtarticuloInicial"
        Me.txtarticuloInicial.ReadOnly = True
        Me.txtarticuloInicial.Size = New System.Drawing.Size(112, 22)
        Me.txtarticuloInicial.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.optresumido)
        Me.GroupBox4.Controls.Add(Me.optdetallado)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 301)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 50)
        Me.GroupBox4.TabIndex = 202
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo"
        '
        'optresumido
        '
        Me.optresumido.AutoSize = True
        Me.optresumido.Location = New System.Drawing.Point(226, 20)
        Me.optresumido.Name = "optresumido"
        Me.optresumido.Size = New System.Drawing.Size(72, 17)
        Me.optresumido.TabIndex = 1
        Me.optresumido.TabStop = True
        Me.optresumido.Text = "Resumido"
        Me.optresumido.UseVisualStyleBackColor = True
        '
        'optdetallado
        '
        Me.optdetallado.AutoSize = True
        Me.optdetallado.Checked = True
        Me.optdetallado.Location = New System.Drawing.Point(72, 20)
        Me.optdetallado.Name = "optdetallado"
        Me.optdetallado.Size = New System.Drawing.Size(70, 17)
        Me.optdetallado.TabIndex = 0
        Me.optdetallado.TabStop = True
        Me.optdetallado.Text = "Detallado"
        Me.optdetallado.UseVisualStyleBackColor = True
        '
        'FrmKardexArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(422, 447)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbArticulos)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmKardexArticulos"
        Me.Text = "Kardex de articulos"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents checkLote As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtarticulofinal As System.Windows.Forms.TextBox
    Friend WithEvents txtarticuloInicial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents optresumido As System.Windows.Forms.RadioButton
    Friend WithEvents optdetallado As System.Windows.Forms.RadioButton
End Class
