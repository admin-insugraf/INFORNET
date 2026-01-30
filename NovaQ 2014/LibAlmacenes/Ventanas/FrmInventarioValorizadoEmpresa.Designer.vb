<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventarioValorizadoEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventarioValorizadoEmpresa))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbResumido = New System.Windows.Forms.RadioButton()
        Me.rbdetallado = New System.Windows.Forms.RadioButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.GbArticulos = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionArticulofinal = New System.Windows.Forms.TextBox()
        Me.txtdescripcionArticuloInicial = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFinArticulo = New System.Windows.Forms.TextBox()
        Me.txtinicioArticulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.checkArticulo = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GbArticulos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 334)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbResumido)
        Me.GroupBox5.Controls.Add(Me.rbdetallado)
        Me.GroupBox5.Controls.Add(Me.ProgressBar1)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(7, 269)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(615, 57)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de Reporte"
        '
        'rbResumido
        '
        Me.rbResumido.AutoSize = True
        Me.rbResumido.Location = New System.Drawing.Point(321, 10)
        Me.rbResumido.Name = "rbResumido"
        Me.rbResumido.Size = New System.Drawing.Size(81, 17)
        Me.rbResumido.TabIndex = 13
        Me.rbResumido.Text = "&Resumido"
        Me.rbResumido.UseVisualStyleBackColor = True
        '
        'rbdetallado
        '
        Me.rbdetallado.AutoSize = True
        Me.rbdetallado.Checked = True
        Me.rbdetallado.Location = New System.Drawing.Point(220, 10)
        Me.rbdetallado.Name = "rbdetallado"
        Me.rbdetallado.Size = New System.Drawing.Size(79, 17)
        Me.rbdetallado.TabIndex = 12
        Me.rbdetallado.TabStop = True
        Me.rbdetallado.Text = "&Detallado"
        Me.rbdetallado.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 33)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(584, 18)
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(112, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(351, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "INVENTARIOS VALORIZADO POR EMPRESA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbomoneda)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(7, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(615, 54)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Datos  Generales"
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(421, 24)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(185, 24)
        Me.cbomoneda.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "&Tipo de Moneda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "&Mes a procesar"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.CustomFormat = "MMMM -     yyyy"
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechaInicio.Location = New System.Drawing.Point(120, 23)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(185, 25)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GbArticulos)
        Me.GroupBox4.Controls.Add(Me.checkArticulo)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 116)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(615, 152)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de Articulos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboTipoProducto)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 40)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "&Tipo de Articulo"
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoProducto.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboTipoProducto.FormattingEnabled = True
        Me.cboTipoProducto.Location = New System.Drawing.Point(107, 11)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(266, 24)
        Me.cboTipoProducto.TabIndex = 2
        '
        'GbArticulos
        '
        Me.GbArticulos.Controls.Add(Me.txtDescripcionArticulofinal)
        Me.GbArticulos.Controls.Add(Me.txtdescripcionArticuloInicial)
        Me.GbArticulos.Controls.Add(Me.PictureBox2)
        Me.GbArticulos.Controls.Add(Me.Label5)
        Me.GbArticulos.Controls.Add(Me.txtFinArticulo)
        Me.GbArticulos.Controls.Add(Me.txtinicioArticulo)
        Me.GbArticulos.Controls.Add(Me.Label4)
        Me.GbArticulos.Controls.Add(Me.PictureBox4)
        Me.GbArticulos.Enabled = False
        Me.GbArticulos.ForeColor = System.Drawing.Color.Navy
        Me.GbArticulos.Location = New System.Drawing.Point(13, 76)
        Me.GbArticulos.Name = "GbArticulos"
        Me.GbArticulos.Size = New System.Drawing.Size(587, 66)
        Me.GbArticulos.TabIndex = 18
        Me.GbArticulos.TabStop = False
        '
        'txtDescripcionArticulofinal
        '
        Me.txtDescripcionArticulofinal.BackColor = System.Drawing.Color.White
        Me.txtDescripcionArticulofinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionArticulofinal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionArticulofinal.Location = New System.Drawing.Point(198, 38)
        Me.txtDescripcionArticulofinal.Multiline = True
        Me.txtDescripcionArticulofinal.Name = "txtDescripcionArticulofinal"
        Me.txtDescripcionArticulofinal.ReadOnly = True
        Me.txtDescripcionArticulofinal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcionArticulofinal.Size = New System.Drawing.Size(381, 24)
        Me.txtDescripcionArticulofinal.TabIndex = 127
        '
        'txtdescripcionArticuloInicial
        '
        Me.txtdescripcionArticuloInicial.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticuloInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticuloInicial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcionArticuloInicial.Location = New System.Drawing.Point(198, 12)
        Me.txtdescripcionArticuloInicial.Multiline = True
        Me.txtdescripcionArticuloInicial.Name = "txtdescripcionArticuloInicial"
        Me.txtdescripcionArticuloInicial.ReadOnly = True
        Me.txtdescripcionArticuloInicial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcionArticuloInicial.Size = New System.Drawing.Size(382, 24)
        Me.txtdescripcionArticuloInicial.TabIndex = 123
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(177, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 18)
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "&Articulo Inicial"
        '
        'txtFinArticulo
        '
        Me.txtFinArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFinArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinArticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinArticulo.Location = New System.Drawing.Point(94, 39)
        Me.txtFinArticulo.Name = "txtFinArticulo"
        Me.txtFinArticulo.ReadOnly = True
        Me.txtFinArticulo.Size = New System.Drawing.Size(80, 21)
        Me.txtFinArticulo.TabIndex = 126
        '
        'txtinicioArticulo
        '
        Me.txtinicioArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtinicioArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtinicioArticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinicioArticulo.Location = New System.Drawing.Point(94, 13)
        Me.txtinicioArticulo.Name = "txtinicioArticulo"
        Me.txtinicioArticulo.ReadOnly = True
        Me.txtinicioArticulo.Size = New System.Drawing.Size(80, 21)
        Me.txtinicioArticulo.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "&Articulo Final"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(176, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(22, 18)
        Me.PictureBox4.TabIndex = 124
        Me.PictureBox4.TabStop = False
        '
        'checkArticulo
        '
        Me.checkArticulo.AutoSize = True
        Me.checkArticulo.Checked = True
        Me.checkArticulo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkArticulo.Location = New System.Drawing.Point(15, 60)
        Me.checkArticulo.Name = "checkArticulo"
        Me.checkArticulo.Size = New System.Drawing.Size(134, 17)
        Me.checkArticulo.TabIndex = 5
        Me.checkArticulo.Text = "Todos los Articulos"
        Me.checkArticulo.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(658, 25)
        Me.ToolStrip1.TabIndex = 190
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
        'FrmInventarioValorizadoEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(658, 366)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInventarioValorizadoEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario valorizado empresa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbArticulos.ResumeLayout(False)
        Me.GbArticulos.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GbArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionArticulofinal As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionArticuloInicial As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFinArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtinicioArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents checkArticulo As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbResumido As System.Windows.Forms.RadioButton
    Friend WithEvents rbdetallado As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
