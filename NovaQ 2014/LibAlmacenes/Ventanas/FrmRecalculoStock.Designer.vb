<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecalculoStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecalculoStock))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4.SuspendLayout()
        Me.GbArticulos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.ProgressBar1)
        Me.GroupBox4.Controls.Add(Me.GbArticulos)
        Me.GroupBox4.Controls.Add(Me.checkArticulo)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(527, 117)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de Articulos"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 93)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(503, 16)
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
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
        Me.GbArticulos.Location = New System.Drawing.Point(10, 21)
        Me.GbArticulos.Name = "GbArticulos"
        Me.GbArticulos.Size = New System.Drawing.Size(503, 66)
        Me.GbArticulos.TabIndex = 18
        Me.GbArticulos.TabStop = False
        '
        'txtDescripcionArticulofinal
        '
        Me.txtDescripcionArticulofinal.BackColor = System.Drawing.Color.White
        Me.txtDescripcionArticulofinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionArticulofinal.Location = New System.Drawing.Point(186, 38)
        Me.txtDescripcionArticulofinal.Name = "txtDescripcionArticulofinal"
        Me.txtDescripcionArticulofinal.ReadOnly = True
        Me.txtDescripcionArticulofinal.Size = New System.Drawing.Size(313, 20)
        Me.txtDescripcionArticulofinal.TabIndex = 127
        '
        'txtdescripcionArticuloInicial
        '
        Me.txtdescripcionArticuloInicial.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticuloInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticuloInicial.Location = New System.Drawing.Point(186, 12)
        Me.txtdescripcionArticuloInicial.Name = "txtdescripcionArticuloInicial"
        Me.txtdescripcionArticuloInicial.ReadOnly = True
        Me.txtdescripcionArticuloInicial.Size = New System.Drawing.Size(313, 20)
        Me.txtdescripcionArticuloInicial.TabIndex = 123
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(166, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
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
        Me.txtFinArticulo.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtFinArticulo.Location = New System.Drawing.Point(83, 39)
        Me.txtFinArticulo.Name = "txtFinArticulo"
        Me.txtFinArticulo.ReadOnly = True
        Me.txtFinArticulo.Size = New System.Drawing.Size(80, 22)
        Me.txtFinArticulo.TabIndex = 126
        '
        'txtinicioArticulo
        '
        Me.txtinicioArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtinicioArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtinicioArticulo.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtinicioArticulo.Location = New System.Drawing.Point(83, 13)
        Me.txtinicioArticulo.Name = "txtinicioArticulo"
        Me.txtinicioArticulo.ReadOnly = True
        Me.txtinicioArticulo.Size = New System.Drawing.Size(80, 22)
        Me.txtinicioArticulo.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Articulo Final"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(166, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 124
        Me.PictureBox4.TabStop = False
        '
        'checkArticulo
        '
        Me.checkArticulo.AutoSize = True
        Me.checkArticulo.Checked = True
        Me.checkArticulo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkArticulo.Enabled = False
        Me.checkArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkArticulo.ForeColor = System.Drawing.Color.Navy
        Me.checkArticulo.Location = New System.Drawing.Point(412, 2)
        Me.checkArticulo.Name = "checkArticulo"
        Me.checkArticulo.Size = New System.Drawing.Size(115, 17)
        Me.checkArticulo.TabIndex = 5
        Me.checkArticulo.Text = "Todos los Articulos"
        Me.checkArticulo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(527, 86)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox2.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(11, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 53)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ultimo mes sin Valorizar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(254, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Al"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Calcular del"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.CustomFormat = "MMMM -     yyyy"
        Me.dtpfechaFin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechaFin.Location = New System.Drawing.Point(273, 22)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(189, 23)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.CustomFormat = "MMMM -     yyyy"
        Me.dtpfechaInicio.Enabled = False
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechaInicio.Location = New System.Drawing.Point(77, 22)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(172, 23)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(198, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RECALCULO DE STOCK"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(552, 25)
        Me.ToolStrip1.TabIndex = 189
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(122, 22)
        Me.btnMostrar.Text = "&Ejecutar Proceso"
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
        'FrmRecalculoStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(552, 272)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRecalculoStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recalculo de stock"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GbArticulos.ResumeLayout(False)
        Me.GbArticulos.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GbArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionArticulofinal As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionArticuloInicial As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFinArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtinicioArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents checkArticulo As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
