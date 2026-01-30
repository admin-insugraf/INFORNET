<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMostrarReporteII
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMostrarReporteII))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbdocumento = New System.Windows.Forms.RadioButton()
        Me.rbproducto = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
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
        Me.rbtentregados = New System.Windows.Forms.RadioButton()
        Me.rbtpendientes = New System.Windows.Forms.RadioButton()
        Me.rbtambos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnMostrar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(14, 487)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 99)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Palatino Linotype", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(406, 25)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(254, 59)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "REGRESAR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Palatino Linotype", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnMostrar.Location = New System.Drawing.Point(71, 25)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(254, 59)
        Me.btnMostrar.TabIndex = 8
        Me.btnMostrar.Text = "MOSTRAR REPORTE"
        Me.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.rbdocumento)
        Me.GroupBox2.Controls.Add(Me.rbproducto)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 100)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'rbdocumento
        '
        Me.rbdocumento.AutoSize = True
        Me.rbdocumento.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.rbdocumento.ForeColor = System.Drawing.Color.Black
        Me.rbdocumento.Location = New System.Drawing.Point(7, 26)
        Me.rbdocumento.Name = "rbdocumento"
        Me.rbdocumento.Size = New System.Drawing.Size(106, 24)
        Me.rbdocumento.TabIndex = 4
        Me.rbdocumento.TabStop = True
        Me.rbdocumento.Text = "Documento"
        Me.rbdocumento.UseVisualStyleBackColor = True
        '
        'rbproducto
        '
        Me.rbproducto.AutoSize = True
        Me.rbproducto.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.rbproducto.ForeColor = System.Drawing.Color.Black
        Me.rbproducto.Location = New System.Drawing.Point(8, 60)
        Me.rbproducto.Name = "rbproducto"
        Me.rbproducto.Size = New System.Drawing.Size(88, 24)
        Me.rbproducto.TabIndex = 5
        Me.rbproducto.TabStop = True
        Me.rbproducto.Text = "Producto"
        Me.rbproducto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(575, 53)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "&DETALLE DE REPORTES"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(14, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(745, 178)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Documentos pendientes por Clientes"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox7.Controls.Add(Me.PictureBox3)
        Me.GroupBox7.Controls.Add(Me.txtFiltro)
        Me.GroupBox7.Controls.Add(Me.lbldescripcion)
        Me.GroupBox7.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(16, 102)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(720, 62)
        Me.GroupBox7.TabIndex = 112
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Cliente "
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = CType(resources.GetObject("PictureBox3.ErrorImage"), System.Drawing.Image)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(127, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox3.TabIndex = 110
        Me.PictureBox3.TabStop = False
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.SystemColors.Info
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtFiltro.Location = New System.Drawing.Point(20, 25)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.ReadOnly = True
        Me.txtFiltro.Size = New System.Drawing.Size(101, 34)
        Me.txtFiltro.TabIndex = 3
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbldescripcion.ForeColor = System.Drawing.Color.Maroon
        Me.lbldescripcion.Location = New System.Drawing.Point(169, 29)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(16, 24)
        Me.lbldescripcion.TabIndex = 9999
        Me.lbldescripcion.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(720, 72)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(50, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 111
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(313, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 26)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Final :"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 14.25!)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(182, 25)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(123, 33)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(110, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Inicial :"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 14.25!)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(376, 25)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(116, 33)
        Me.dtpfechaFin.TabIndex = 2
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox8.Controls.Add(Me.rbtodos)
        Me.GroupBox8.Controls.Add(Me.rbindividual)
        Me.GroupBox8.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(12, 362)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(116, 107)
        Me.GroupBox8.TabIndex = 13
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Consulta"
        '
        'rbtodos
        '
        Me.rbtodos.AutoSize = True
        Me.rbtodos.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.rbtodos.ForeColor = System.Drawing.Color.Black
        Me.rbtodos.Location = New System.Drawing.Point(7, 26)
        Me.rbtodos.Name = "rbtodos"
        Me.rbtodos.Size = New System.Drawing.Size(67, 24)
        Me.rbtodos.TabIndex = 6
        Me.rbtodos.TabStop = True
        Me.rbtodos.Text = "Todos"
        Me.rbtodos.UseVisualStyleBackColor = True
        '
        'rbindividual
        '
        Me.rbindividual.AutoSize = True
        Me.rbindividual.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.rbindividual.ForeColor = System.Drawing.Color.Black
        Me.rbindividual.Location = New System.Drawing.Point(8, 60)
        Me.rbindividual.Name = "rbindividual"
        Me.rbindividual.Size = New System.Drawing.Size(95, 24)
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
        Me.GroupBox9.Location = New System.Drawing.Point(248, 256)
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
        Me.GroupBox5.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox5.Controls.Add(Me.rbtambos)
        Me.GroupBox5.Controls.Add(Me.rbtentregados)
        Me.GroupBox5.Controls.Add(Me.rbtpendientes)
        Me.GroupBox5.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(134, 256)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(109, 212)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        '
        'rbtentregados
        '
        Me.rbtentregados.AutoSize = True
        Me.rbtentregados.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.rbtentregados.ForeColor = System.Drawing.Color.Black
        Me.rbtentregados.Location = New System.Drawing.Point(6, 50)
        Me.rbtentregados.Name = "rbtentregados"
        Me.rbtentregados.Size = New System.Drawing.Size(101, 24)
        Me.rbtentregados.TabIndex = 4
        Me.rbtentregados.Text = "Entregados"
        Me.rbtentregados.UseVisualStyleBackColor = True
        '
        'rbtpendientes
        '
        Me.rbtpendientes.AutoSize = True
        Me.rbtpendientes.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.rbtpendientes.ForeColor = System.Drawing.Color.Black
        Me.rbtpendientes.Location = New System.Drawing.Point(6, 106)
        Me.rbtpendientes.Name = "rbtpendientes"
        Me.rbtpendientes.Size = New System.Drawing.Size(99, 24)
        Me.rbtpendientes.TabIndex = 5
        Me.rbtpendientes.Text = "Pendientes"
        Me.rbtpendientes.UseVisualStyleBackColor = True
        '
        'rbtambos
        '
        Me.rbtambos.AutoSize = True
        Me.rbtambos.Checked = True
        Me.rbtambos.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.rbtambos.ForeColor = System.Drawing.Color.Black
        Me.rbtambos.Location = New System.Drawing.Point(6, 166)
        Me.rbtambos.Name = "rbtambos"
        Me.rbtambos.Size = New System.Drawing.Size(75, 24)
        Me.rbtambos.TabIndex = 6
        Me.rbtambos.TabStop = True
        Me.rbtambos.Text = "Ambos"
        Me.rbtambos.UseVisualStyleBackColor = True
        '
        'FrmMostrarReporteII
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(782, 596)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMostrarReporteII"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMostrarReportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtambos As System.Windows.Forms.RadioButton
    Public WithEvents rbtentregados As System.Windows.Forms.RadioButton
    Friend WithEvents rbtpendientes As System.Windows.Forms.RadioButton
End Class
