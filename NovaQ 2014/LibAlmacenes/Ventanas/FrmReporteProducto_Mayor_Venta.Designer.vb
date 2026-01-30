<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteProducto_Mayor_Venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteProducto_Mayor_Venta))
        Me.gbArticulos = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionArticulofinal = New System.Windows.Forms.TextBox()
        Me.txtdescripcionArticuloInicial = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFinArticulo = New System.Windows.Forms.TextBox()
        Me.txtinicioArticulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.chk_articulos = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkfamilia = New System.Windows.Forms.CheckBox()
        Me.cboFamilia = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbArticulos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbArticulos
        '
        Me.gbArticulos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbArticulos.Controls.Add(Me.GroupBox1)
        Me.gbArticulos.Controls.Add(Me.chk_articulos)
        Me.gbArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbArticulos.ForeColor = System.Drawing.Color.Navy
        Me.gbArticulos.Location = New System.Drawing.Point(11, 179)
        Me.gbArticulos.Name = "gbArticulos"
        Me.gbArticulos.Size = New System.Drawing.Size(558, 113)
        Me.gbArticulos.TabIndex = 9
        Me.gbArticulos.TabStop = False
        Me.gbArticulos.Text = "Rango de Articulos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.txtDescripcionArticulofinal)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArticuloInicial)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFinArticulo)
        Me.GroupBox1.Controls.Add(Me.txtinicioArticulo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(6, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 66)
        Me.GroupBox1.TabIndex = 189
        Me.GroupBox1.TabStop = False
        '
        'txtDescripcionArticulofinal
        '
        Me.txtDescripcionArticulofinal.BackColor = System.Drawing.Color.White
        Me.txtDescripcionArticulofinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionArticulofinal.Location = New System.Drawing.Point(170, 38)
        Me.txtDescripcionArticulofinal.Name = "txtDescripcionArticulofinal"
        Me.txtDescripcionArticulofinal.ReadOnly = True
        Me.txtDescripcionArticulofinal.Size = New System.Drawing.Size(370, 20)
        Me.txtDescripcionArticulofinal.TabIndex = 127
        '
        'txtdescripcionArticuloInicial
        '
        Me.txtdescripcionArticuloInicial.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticuloInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticuloInicial.Location = New System.Drawing.Point(170, 12)
        Me.txtdescripcionArticuloInicial.Name = "txtdescripcionArticuloInicial"
        Me.txtdescripcionArticuloInicial.ReadOnly = True
        Me.txtdescripcionArticuloInicial.Size = New System.Drawing.Size(370, 20)
        Me.txtdescripcionArticuloInicial.TabIndex = 123
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(152, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Articulo Inicial"
        '
        'txtFinArticulo
        '
        Me.txtFinArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFinArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinArticulo.Location = New System.Drawing.Point(81, 39)
        Me.txtFinArticulo.Name = "txtFinArticulo"
        Me.txtFinArticulo.ReadOnly = True
        Me.txtFinArticulo.Size = New System.Drawing.Size(69, 20)
        Me.txtFinArticulo.TabIndex = 126
        '
        'txtinicioArticulo
        '
        Me.txtinicioArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtinicioArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtinicioArticulo.Location = New System.Drawing.Point(81, 13)
        Me.txtinicioArticulo.Name = "txtinicioArticulo"
        Me.txtinicioArticulo.ReadOnly = True
        Me.txtinicioArticulo.Size = New System.Drawing.Size(69, 20)
        Me.txtinicioArticulo.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Articulo Final"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(152, 13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 124
        Me.PictureBox4.TabStop = False
        '
        'chk_articulos
        '
        Me.chk_articulos.AutoSize = True
        Me.chk_articulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_articulos.ForeColor = System.Drawing.Color.Navy
        Me.chk_articulos.Location = New System.Drawing.Point(9, 23)
        Me.chk_articulos.Name = "chk_articulos"
        Me.chk_articulos.Size = New System.Drawing.Size(114, 17)
        Me.chk_articulos.TabIndex = 13
        Me.chk_articulos.Text = "Todos los articulos"
        Me.chk_articulos.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkfamilia)
        Me.GroupBox6.Controls.Add(Me.cboFamilia)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(557, 48)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Seleccione una Familia"
        '
        'chkfamilia
        '
        Me.chkfamilia.AutoSize = True
        Me.chkfamilia.ForeColor = System.Drawing.Color.Navy
        Me.chkfamilia.Location = New System.Drawing.Point(277, 21)
        Me.chkfamilia.Name = "chkfamilia"
        Me.chkfamilia.Size = New System.Drawing.Size(112, 17)
        Me.chkfamilia.TabIndex = 14
        Me.chkfamilia.Text = "Todas las Familias"
        Me.chkfamilia.UseVisualStyleBackColor = True
        '
        'cboFamilia
        '
        Me.cboFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFamilia.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboFamilia.FormattingEnabled = True
        Me.cboFamilia.Location = New System.Drawing.Point(16, 18)
        Me.cboFamilia.Name = "cboFamilia"
        Me.cboFamilia.Size = New System.Drawing.Size(255, 24)
        Me.cboFamilia.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(581, 25)
        Me.ToolStrip1.TabIndex = 188
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
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox7.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(11, 76)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(558, 50)
        Me.GroupBox7.TabIndex = 189
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Rango de Fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(194, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AL"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(222, 19)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(112, 25)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 10.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(75, 19)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(112, 26)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(159, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 19)
        Me.Label6.TabIndex = 190
        Me.Label6.Text = "PRODUCTOS CON MAYOR VENTA"
        '
        'FrmReporteProducto_Mayor_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(581, 300)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.gbArticulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReporteProducto_Mayor_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Producto mayor venta"
        Me.gbArticulos.ResumeLayout(False)
        Me.gbArticulos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents chk_articulos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents chkfamilia As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionArticulofinal As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionArticuloInicial As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFinArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtinicioArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
