<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegVentas))
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.checkTipoDoc = New System.Windows.Forms.CheckBox()
        Me.chklstDocumentos = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rdbconcar = New System.Windows.Forms.RadioButton()
        Me.rdbsunat = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_moneda = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Panel_Formato_Concar = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.rb_cobranzas = New System.Windows.Forms.RadioButton()
        Me.rb_ventas = New System.Windows.Forms.RadioButton()
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_series = New System.Windows.Forms.ComboBox()
        Me.chk_todos_series = New System.Windows.Forms.CheckBox()
        Me.gbDatosGenerales.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel_Formato_Concar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitulo.ForeColor = System.Drawing.Color.Navy
        Me.lbltitulo.Location = New System.Drawing.Point(15, 31)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(385, 19)
        Me.lbltitulo.TabIndex = 13
        Me.lbltitulo.Text = "REGISTRO DE VENTAS"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.BackColor = System.Drawing.Color.White
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox4)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox7)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox3)
        Me.gbDatosGenerales.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbDatosGenerales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosGenerales.Location = New System.Drawing.Point(12, 49)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(388, 358)
        Me.gbDatosGenerales.TabIndex = 12
        Me.gbDatosGenerales.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.checkTipoDoc)
        Me.GroupBox4.Controls.Add(Me.chklstDocumentos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(17, 187)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 159)
        Me.GroupBox4.TabIndex = 113
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Documentos"
        '
        'checkTipoDoc
        '
        Me.checkTipoDoc.AutoSize = True
        Me.checkTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkTipoDoc.ForeColor = System.Drawing.Color.Navy
        Me.checkTipoDoc.Location = New System.Drawing.Point(15, 21)
        Me.checkTipoDoc.Name = "checkTipoDoc"
        Me.checkTipoDoc.Size = New System.Drawing.Size(154, 17)
        Me.checkTipoDoc.TabIndex = 7
        Me.checkTipoDoc.Text = "Activar /Desactivar. Todos"
        Me.checkTipoDoc.UseVisualStyleBackColor = True
        '
        'chklstDocumentos
        '
        Me.chklstDocumentos.CheckOnClick = True
        Me.chklstDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstDocumentos.FormattingEnabled = True
        Me.chklstDocumentos.Location = New System.Drawing.Point(12, 44)
        Me.chklstDocumentos.Name = "chklstDocumentos"
        Me.chklstDocumentos.Size = New System.Drawing.Size(318, 109)
        Me.chklstDocumentos.TabIndex = 6
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.rdbconcar)
        Me.GroupBox7.Controls.Add(Me.rdbsunat)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(16, 135)
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
        Me.rdbconcar.Size = New System.Drawing.Size(104, 17)
        Me.rdbconcar.TabIndex = 3
        Me.rdbconcar.TabStop = True
        Me.rdbconcar.Text = "Formato Insugraf"
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
        Me.rdbsunat.Size = New System.Drawing.Size(94, 17)
        Me.rdbsunat.TabIndex = 2
        Me.rdbsunat.TabStop = True
        Me.rdbsunat.Text = "Formato Sunat"
        Me.rdbsunat.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.chk_todos_series)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cbo_series)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cbo_moneda)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 110)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(7, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Moneda "
        '
        'cbo_moneda
        '
        Me.cbo_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_moneda.FormattingEnabled = True
        Me.cbo_moneda.Items.AddRange(New Object() {"Moneda Nacional", "Moneda Extranjera"})
        Me.cbo_moneda.Location = New System.Drawing.Point(67, 45)
        Me.cbo_moneda.Name = "cbo_moneda"
        Me.cbo_moneda.Size = New System.Drawing.Size(155, 21)
        Me.cbo_moneda.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(190, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Final :"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(67, 17)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(105, 20)
        Me.dtpfechaInicio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(19, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Inicial "
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(229, 17)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(105, 20)
        Me.dtpfechaFin.TabIndex = 1
        '
        'Panel_Formato_Concar
        '
        Me.Panel_Formato_Concar.BackColor = System.Drawing.Color.White
        Me.Panel_Formato_Concar.Controls.Add(Me.GroupBox2)
        Me.Panel_Formato_Concar.Location = New System.Drawing.Point(484, 140)
        Me.Panel_Formato_Concar.Name = "Panel_Formato_Concar"
        Me.Panel_Formato_Concar.Size = New System.Drawing.Size(153, 69)
        Me.Panel_Formato_Concar.TabIndex = 15
        Me.Panel_Formato_Concar.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.rb_cobranzas)
        Me.GroupBox2.Controls.Add(Me.rb_ventas)
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
        Me.GroupBox2.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 171)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles "
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(67, 106)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(282, 15)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar2.TabIndex = 22
        Me.ProgressBar2.Visible = False
        '
        'rb_cobranzas
        '
        Me.rb_cobranzas.AutoSize = True
        Me.rb_cobranzas.Location = New System.Drawing.Point(197, 19)
        Me.rb_cobranzas.Name = "rb_cobranzas"
        Me.rb_cobranzas.Size = New System.Drawing.Size(75, 17)
        Me.rb_cobranzas.TabIndex = 21
        Me.rb_cobranzas.Text = "Cobranzas"
        Me.rb_cobranzas.UseVisualStyleBackColor = True
        Me.rb_cobranzas.Visible = False
        '
        'rb_ventas
        '
        Me.rb_ventas.AutoSize = True
        Me.rb_ventas.Checked = True
        Me.rb_ventas.Location = New System.Drawing.Point(67, 19)
        Me.rb_ventas.Name = "rb_ventas"
        Me.rb_ventas.Size = New System.Drawing.Size(58, 17)
        Me.rb_ventas.TabIndex = 20
        Me.rb_ventas.TabStop = True
        Me.rb_ventas.Text = "Ventas"
        Me.rb_ventas.UseVisualStyleBackColor = True
        Me.rb_ventas.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 19
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(67, 33)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(251, 20)
        Me.txtRuta.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(8, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Progreso :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(8, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ruta :"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(234, 138)
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
        Me.Label3.Location = New System.Drawing.Point(8, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Archivo :"
        '
        'btnRuta
        '
        Me.btnRuta.Location = New System.Drawing.Point(324, 31)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(25, 23)
        Me.btnRuta.TabIndex = 7
        Me.btnRuta.Text = "..."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(67, 70)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(198, 20)
        Me.txtArchivo.TabIndex = 8
        Me.txtArchivo.Text = "Formato_Concar_Ventas"
        '
        'btnDetener
        '
        Me.btnDetener.Image = CType(resources.GetObject("btnDetener.Image"), System.Drawing.Image)
        Me.btnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetener.Location = New System.Drawing.Point(160, 138)
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
        Me.btnIniciar.Location = New System.Drawing.Point(86, 138)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 9
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(67, 106)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(282, 15)
        Me.ProgressBar1.TabIndex = 14
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(414, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(121, 22)
        Me.btnMostrar.Text = "&Mostrar Reporte"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(185, 22)
        Me.ToolStripButton1.Text = "Act. tipo de cambio en Docs."
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(22, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Serie "
        '
        'cbo_series
        '
        Me.cbo_series.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_series.FormattingEnabled = True
        Me.cbo_series.Items.AddRange(New Object() {"Moneda Nacional", "Moneda Extranjera"})
        Me.cbo_series.Location = New System.Drawing.Point(67, 77)
        Me.cbo_series.Name = "cbo_series"
        Me.cbo_series.Size = New System.Drawing.Size(155, 21)
        Me.cbo_series.TabIndex = 113
        '
        'chk_todos_series
        '
        Me.chk_todos_series.AutoSize = True
        Me.chk_todos_series.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_todos_series.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos_series.Location = New System.Drawing.Point(229, 79)
        Me.chk_todos_series.Name = "chk_todos_series"
        Me.chk_todos_series.Size = New System.Drawing.Size(102, 17)
        Me.chk_todos_series.TabIndex = 115
        Me.chk_todos_series.Text = "Todas las series"
        Me.chk_todos_series.UseVisualStyleBackColor = True
        '
        'FrmRegVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(414, 413)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel_Formato_Concar)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ventas"
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel_Formato_Concar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbconcar As System.Windows.Forms.RadioButton
    Friend WithEvents rdbsunat As System.Windows.Forms.RadioButton
    Friend WithEvents Panel_Formato_Concar As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents btnDetener As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents checkTipoDoc As System.Windows.Forms.CheckBox
    Friend WithEvents chklstDocumentos As System.Windows.Forms.CheckedListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbo_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rb_cobranzas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ventas As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk_todos_series As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_series As System.Windows.Forms.ComboBox
End Class
