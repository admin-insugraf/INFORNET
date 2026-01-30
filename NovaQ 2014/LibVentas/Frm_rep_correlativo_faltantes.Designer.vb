<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_rep_correlativo_faltantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_rep_correlativo_faltantes))
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.chk_todos_series = New System.Windows.Forms.CheckBox()
        Me.cmb_tipo_cob = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gbDatosGenerales.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitulo.ForeColor = System.Drawing.Color.Navy
        Me.lbltitulo.Location = New System.Drawing.Point(96, 34)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(227, 19)
        Me.lbltitulo.TabIndex = 13
        Me.lbltitulo.Text = "CORRELATIVOS FALTANTES"
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.BackColor = System.Drawing.Color.White
        Me.gbDatosGenerales.Controls.Add(Me.chk_todos_series)
        Me.gbDatosGenerales.Controls.Add(Me.cmb_tipo_cob)
        Me.gbDatosGenerales.Controls.Add(Me.Label22)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox3)
        Me.gbDatosGenerales.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbDatosGenerales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosGenerales.Location = New System.Drawing.Point(12, 58)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(394, 134)
        Me.gbDatosGenerales.TabIndex = 12
        Me.gbDatosGenerales.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(20, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 54)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(166, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Final :"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(54, 26)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(105, 20)
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
        Me.dtpfechaFin.Location = New System.Drawing.Point(205, 26)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(105, 20)
        Me.dtpfechaFin.TabIndex = 1
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(422, 25)
        Me.ToolStrip1.TabIndex = 14
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
        'chk_todos_series
        '
        Me.chk_todos_series.AutoSize = True
        Me.chk_todos_series.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_todos_series.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_series.Location = New System.Drawing.Point(194, 94)
        Me.chk_todos_series.Name = "chk_todos_series"
        Me.chk_todos_series.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos_series.TabIndex = 188
        Me.chk_todos_series.Text = "Todos"
        Me.chk_todos_series.UseVisualStyleBackColor = True
        '
        'cmb_tipo_cob
        '
        Me.cmb_tipo_cob.DropDownHeight = 100
        Me.cmb_tipo_cob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_cob.DropDownWidth = 105
        Me.cmb_tipo_cob.FormattingEnabled = True
        Me.cmb_tipo_cob.IntegralHeight = False
        Me.cmb_tipo_cob.Location = New System.Drawing.Point(74, 90)
        Me.cmb_tipo_cob.MaxDropDownItems = 10
        Me.cmb_tipo_cob.Name = "cmb_tipo_cob"
        Me.cmb_tipo_cob.Size = New System.Drawing.Size(105, 24)
        Me.cmb_tipo_cob.TabIndex = 187
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(27, 95)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 13)
        Me.Label22.TabIndex = 186
        Me.Label22.Text = "Series"
        '
        'Frm_rep_correlativo_faltantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(422, 209)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_rep_correlativo_faltantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes correlativos faltantes"
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.gbDatosGenerales.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk_todos_series As System.Windows.Forms.CheckBox
    Private WithEvents cmb_tipo_cob As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
