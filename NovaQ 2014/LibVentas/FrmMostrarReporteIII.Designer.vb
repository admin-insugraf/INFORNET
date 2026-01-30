<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMostrarReporteIII
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMostrarReporteIII))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbdocumento = New System.Windows.Forms.RadioButton()
        Me.rbproducto = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rbtodos = New System.Windows.Forms.RadioButton()
        Me.rbindividual = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dgvdatos = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbtambos = New System.Windows.Forms.RadioButton()
        Me.rbtentregados = New System.Windows.Forms.RadioButton()
        Me.rbtpendientes = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.rbdocumento)
        Me.GroupBox2.Controls.Add(Me.rbproducto)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(5, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 100)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'rbdocumento
        '
        Me.rbdocumento.AutoSize = True
        Me.rbdocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdocumento.ForeColor = System.Drawing.Color.Navy
        Me.rbdocumento.Location = New System.Drawing.Point(7, 26)
        Me.rbdocumento.Name = "rbdocumento"
        Me.rbdocumento.Size = New System.Drawing.Size(90, 17)
        Me.rbdocumento.TabIndex = 4
        Me.rbdocumento.TabStop = True
        Me.rbdocumento.Text = "Documento"
        Me.rbdocumento.UseVisualStyleBackColor = True
        '
        'rbproducto
        '
        Me.rbproducto.AutoSize = True
        Me.rbproducto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbproducto.ForeColor = System.Drawing.Color.Navy
        Me.rbproducto.Location = New System.Drawing.Point(8, 60)
        Me.rbproducto.Name = "rbproducto"
        Me.rbproducto.Size = New System.Drawing.Size(76, 17)
        Me.rbproducto.TabIndex = 5
        Me.rbproducto.TabStop = True
        Me.rbproducto.Text = "Producto"
        Me.rbproducto.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(5, 28)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(745, 155)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.PictureBox1)
        Me.GroupBox7.Controls.Add(Me.txtFiltro)
        Me.GroupBox7.Controls.Add(Me.lbldescripcion)
        Me.GroupBox7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(16, 84)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(720, 62)
        Me.GroupBox7.TabIndex = 112
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Rep. Medico"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(128, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 10000
        Me.PictureBox1.TabStop = False
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFiltro.Location = New System.Drawing.Point(6, 24)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.ReadOnly = True
        Me.txtFiltro.Size = New System.Drawing.Size(116, 25)
        Me.txtFiltro.TabIndex = 3
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbldescripcion.ForeColor = System.Drawing.Color.Maroon
        Me.lbldescripcion.Location = New System.Drawing.Point(153, 28)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(12, 18)
        Me.lbldescripcion.TabIndex = 9999
        Me.lbldescripcion.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(16, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(720, 50)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(220, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Final :"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(89, 17)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(123, 25)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Inicial :"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(283, 17)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(116, 25)
        Me.dtpfechaFin.TabIndex = 2
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.rbtodos)
        Me.GroupBox8.Controls.Add(Me.rbindividual)
        Me.GroupBox8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(5, 294)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(116, 107)
        Me.GroupBox8.TabIndex = 13
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Consulta"
        '
        'rbtodos
        '
        Me.rbtodos.AutoSize = True
        Me.rbtodos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtodos.ForeColor = System.Drawing.Color.Navy
        Me.rbtodos.Location = New System.Drawing.Point(7, 26)
        Me.rbtodos.Name = "rbtodos"
        Me.rbtodos.Size = New System.Drawing.Size(59, 17)
        Me.rbtodos.TabIndex = 6
        Me.rbtodos.TabStop = True
        Me.rbtodos.Text = "Todos"
        Me.rbtodos.UseVisualStyleBackColor = True
        '
        'rbindividual
        '
        Me.rbindividual.AutoSize = True
        Me.rbindividual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbindividual.ForeColor = System.Drawing.Color.Navy
        Me.rbindividual.Location = New System.Drawing.Point(8, 60)
        Me.rbindividual.Name = "rbindividual"
        Me.rbindividual.Size = New System.Drawing.Size(81, 17)
        Me.rbindividual.TabIndex = 7
        Me.rbindividual.TabStop = True
        Me.rbindividual.Text = "Individual"
        Me.rbindividual.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.dgvdatos)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(239, 189)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(511, 213)
        Me.GroupBox9.TabIndex = 14
        Me.GroupBox9.TabStop = False
        '
        'dgvdatos
        '
        Me.dgvdatos.AllowUserToAddRows = False
        Me.dgvdatos.AllowUserToDeleteRows = False
        Me.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatos.Location = New System.Drawing.Point(6, 16)
        Me.dgvdatos.Name = "dgvdatos"
        Me.dgvdatos.ReadOnly = True
        Me.dgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdatos.Size = New System.Drawing.Size(496, 188)
        Me.dgvdatos.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.rbtambos)
        Me.GroupBox5.Controls.Add(Me.rbtentregados)
        Me.GroupBox5.Controls.Add(Me.rbtpendientes)
        Me.GroupBox5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(127, 189)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(109, 212)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        '
        'rbtambos
        '
        Me.rbtambos.AutoSize = True
        Me.rbtambos.Checked = True
        Me.rbtambos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtambos.ForeColor = System.Drawing.Color.Navy
        Me.rbtambos.Location = New System.Drawing.Point(6, 166)
        Me.rbtambos.Name = "rbtambos"
        Me.rbtambos.Size = New System.Drawing.Size(64, 17)
        Me.rbtambos.TabIndex = 6
        Me.rbtambos.TabStop = True
        Me.rbtambos.Text = "Ambos"
        Me.rbtambos.UseVisualStyleBackColor = True
        '
        'rbtentregados
        '
        Me.rbtentregados.AutoSize = True
        Me.rbtentregados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtentregados.ForeColor = System.Drawing.Color.Navy
        Me.rbtentregados.Location = New System.Drawing.Point(6, 50)
        Me.rbtentregados.Name = "rbtentregados"
        Me.rbtentregados.Size = New System.Drawing.Size(89, 17)
        Me.rbtentregados.TabIndex = 4
        Me.rbtentregados.Text = "Entregados"
        Me.rbtentregados.UseVisualStyleBackColor = True
        '
        'rbtpendientes
        '
        Me.rbtpendientes.AutoSize = True
        Me.rbtpendientes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtpendientes.ForeColor = System.Drawing.Color.Navy
        Me.rbtpendientes.Location = New System.Drawing.Point(6, 106)
        Me.rbtpendientes.Name = "rbtpendientes"
        Me.rbtpendientes.Size = New System.Drawing.Size(88, 17)
        Me.rbtpendientes.TabIndex = 5
        Me.rbtpendientes.Text = "Pendientes"
        Me.rbtpendientes.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(756, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(112, 22)
        Me.btnMostrar.Text = "&Mostrar Reporte"
        Me.btnMostrar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "&Salir"
        '
        'FrmMostrarReporteIII
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(756, 410)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMostrarReporteIII"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento por Rep. Medicos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents rbdocumento As System.Windows.Forms.RadioButton
    Friend WithEvents rbproducto As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Public WithEvents rbtodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbindividual As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdatos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtambos As System.Windows.Forms.RadioButton
    Public WithEvents rbtentregados As System.Windows.Forms.RadioButton
    Friend WithEvents rbtpendientes As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
