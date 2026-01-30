<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_rep_cuadro_comparativo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_rep_cuadro_comparativo))
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chklstsolicitudes = New System.Windows.Forms.CheckedListBox()
        Me.checkSolicitudes = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.gbDatosGenerales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitulo.ForeColor = System.Drawing.Color.Navy
        Me.lbltitulo.Location = New System.Drawing.Point(81, 40)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(201, 19)
        Me.lbltitulo.TabIndex = 13
        Me.lbltitulo.Text = "CUADRO COMPARATIVO"
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.BackColor = System.Drawing.Color.White
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox1)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox3)
        Me.gbDatosGenerales.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbDatosGenerales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosGenerales.Location = New System.Drawing.Point(12, 64)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(325, 277)
        Me.gbDatosGenerales.TabIndex = 12
        Me.gbDatosGenerales.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbomoneda)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 45)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de moneda"
        '
        'cbomoneda
        '
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(12, 17)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(248, 21)
        Me.cbomoneda.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 54)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(153, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Final :"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(50, 26)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtpfechaInicio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Inicial :"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(189, 26)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(93, 20)
        Me.dtpfechaFin.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.chklstsolicitudes)
        Me.GroupBox2.Controls.Add(Me.checkSolicitudes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(28, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 171)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione un Almacen"
        '
        'chklstsolicitudes
        '
        Me.chklstsolicitudes.CheckOnClick = True
        Me.chklstsolicitudes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstsolicitudes.FormattingEnabled = True
        Me.chklstsolicitudes.Location = New System.Drawing.Point(11, 41)
        Me.chklstsolicitudes.Name = "chklstsolicitudes"
        Me.chklstsolicitudes.Size = New System.Drawing.Size(271, 116)
        Me.chklstsolicitudes.TabIndex = 6
        '
        'checkSolicitudes
        '
        Me.checkSolicitudes.AutoSize = True
        Me.checkSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkSolicitudes.ForeColor = System.Drawing.Color.Navy
        Me.checkSolicitudes.Location = New System.Drawing.Point(13, 18)
        Me.checkSolicitudes.Name = "checkSolicitudes"
        Me.checkSolicitudes.Size = New System.Drawing.Size(92, 17)
        Me.checkSolicitudes.TabIndex = 7
        Me.checkSolicitudes.Text = "Activar Todos"
        Me.checkSolicitudes.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(352, 25)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(121, 22)
        Me.btnMostrar.Text = "Mostrar Reporte"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "Salir"
        '
        'Frm_rep_cuadro_comparativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(352, 347)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_rep_cuadro_comparativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuadro comparativo."
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chklstsolicitudes As System.Windows.Forms.CheckedListBox
    Friend WithEvents checkSolicitudes As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
