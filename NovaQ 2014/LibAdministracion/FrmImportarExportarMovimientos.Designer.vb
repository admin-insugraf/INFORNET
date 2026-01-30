<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportarExportarMovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportarExportarMovimientos))
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Panel_Formato_Concar = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rdbconcar = New System.Windows.Forms.RadioButton()
        Me.rdbsunat = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.gbDatosGenerales.SuspendLayout()
        Me.Panel_Formato_Concar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.BackColor = System.Drawing.Color.White
        Me.gbDatosGenerales.Controls.Add(Me.Panel_Formato_Concar)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox7)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox3)
        Me.gbDatosGenerales.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbDatosGenerales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosGenerales.Location = New System.Drawing.Point(12, 14)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(388, 278)
        Me.gbDatosGenerales.TabIndex = 17
        Me.gbDatosGenerales.TabStop = False
        '
        'Panel_Formato_Concar
        '
        Me.Panel_Formato_Concar.BackColor = System.Drawing.Color.White
        Me.Panel_Formato_Concar.Controls.Add(Me.GroupBox2)
        Me.Panel_Formato_Concar.Location = New System.Drawing.Point(6, 115)
        Me.Panel_Formato_Concar.Name = "Panel_Formato_Concar"
        Me.Panel_Formato_Concar.Size = New System.Drawing.Size(376, 147)
        Me.Panel_Formato_Concar.TabIndex = 113
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtRuta)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnRuta)
        Me.GroupBox2.Controls.Add(Me.txtArchivo)
        Me.GroupBox2.Controls.Add(Me.btnDetener)
        Me.GroupBox2.Controls.Add(Me.btnIniciar)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 134)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "& Detalles "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Visible = False
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(67, 32)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(251, 22)
        Me.txtRuta.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(8, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Progreso :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(8, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ruta :"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(234, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(8, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Archivo :"
        '
        'btnRuta
        '
        Me.btnRuta.Location = New System.Drawing.Point(324, 30)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(25, 23)
        Me.btnRuta.TabIndex = 7
        Me.btnRuta.Text = "..."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(67, 58)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(198, 22)
        Me.txtArchivo.TabIndex = 8
        '
        'btnDetener
        '
        Me.btnDetener.Image = CType(resources.GetObject("btnDetener.Image"), System.Drawing.Image)
        Me.btnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetener.Location = New System.Drawing.Point(160, 102)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(75, 23)
        Me.btnDetener.TabIndex = 10
        Me.btnDetener.Text = "Detener"
        Me.btnDetener.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.Image = CType(resources.GetObject("btnIniciar.Image"), System.Drawing.Image)
        Me.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIniciar.Location = New System.Drawing.Point(86, 102)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 9
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(67, 88)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(282, 9)
        Me.ProgressBar1.TabIndex = 14
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.rdbconcar)
        Me.GroupBox7.Controls.Add(Me.rdbsunat)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(16, 70)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(353, 39)
        Me.GroupBox7.TabIndex = 112
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Opciones"
        '
        'rdbconcar
        '
        Me.rdbconcar.AutoSize = True
        Me.rdbconcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdbconcar.ForeColor = System.Drawing.Color.Navy
        Me.rdbconcar.Location = New System.Drawing.Point(215, 18)
        Me.rdbconcar.Name = "rdbconcar"
        Me.rdbconcar.Size = New System.Drawing.Size(125, 17)
        Me.rdbconcar.TabIndex = 3
        Me.rdbconcar.TabStop = True
        Me.rdbconcar.Text = "Importar Movimientos"
        Me.rdbconcar.UseVisualStyleBackColor = True
        '
        'rdbsunat
        '
        Me.rdbsunat.AutoSize = True
        Me.rdbsunat.Checked = True
        Me.rdbsunat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdbsunat.ForeColor = System.Drawing.Color.Navy
        Me.rdbsunat.Location = New System.Drawing.Point(20, 18)
        Me.rdbsunat.Name = "rdbsunat"
        Me.rdbsunat.Size = New System.Drawing.Size(126, 17)
        Me.rdbsunat.TabIndex = 2
        Me.rdbsunat.TabStop = True
        Me.rdbsunat.Text = "Exportar Movimientos"
        Me.rdbsunat.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Location = New System.Drawing.Point(16, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 46)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(166, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Final :"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(54, 17)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(105, 20)
        Me.dtpfechaInicio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Inicial :"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(205, 17)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(105, 20)
        Me.dtpfechaFin.TabIndex = 1
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(67, 88)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(282, 13)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar2.TabIndex = 21
        Me.ProgressBar2.Visible = False
        '
        'FrmImportarExportarMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(414, 304)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImportarExportarMovimientos"
        Me.Text = "Exportar/Importar Mov."
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.Panel_Formato_Concar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbconcar As System.Windows.Forms.RadioButton
    Friend WithEvents rdbsunat As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel_Formato_Concar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents btnDetener As System.Windows.Forms.Button
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
End Class
