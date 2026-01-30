<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegComprasPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegComprasPagos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtplazo5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtplazo3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtplazo4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtplazo1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtplazo2 = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.optdetallado = New System.Windows.Forms.RadioButton()
        Me.optexcel = New System.Windows.Forms.RadioButton()
        Me.optrangocobro = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Panel_Formato_Concar = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip1.SuspendLayout()
        Me.gbDatosGenerales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel_Formato_Concar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(470, 25)
        Me.ToolStrip1.TabIndex = 20
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
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitulo.ForeColor = System.Drawing.Color.Navy
        Me.lbltitulo.Location = New System.Drawing.Point(93, 35)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(267, 19)
        Me.lbltitulo.TabIndex = 19
        Me.lbltitulo.Text = "REGISTRO DE COMPRAS - PAGOS"
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.BackColor = System.Drawing.Color.White
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox1)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox7)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox3)
        Me.gbDatosGenerales.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbDatosGenerales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosGenerales.Location = New System.Drawing.Point(12, 57)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(446, 242)
        Me.gbDatosGenerales.TabIndex = 18
        Me.gbDatosGenerales.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtplazo5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtplazo3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtplazo4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtplazo1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtplazo2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(250, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 212)
        Me.GroupBox1.TabIndex = 188
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Vcto."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(135, 179)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 16)
        Me.Label16.TabIndex = 194
        Me.Label16.Text = "días"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(136, 148)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 16)
        Me.Label15.TabIndex = 193
        Me.Label15.Text = "días"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(135, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 192
        Me.Label14.Text = "días"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(135, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 16)
        Me.Label13.TabIndex = 191
        Me.Label13.Text = "días"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(135, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 16)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "días"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(10, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 189
        Me.Label11.Text = "Mas de"
        '
        'txtplazo5
        '
        Me.txtplazo5.BackColor = System.Drawing.Color.Aquamarine
        Me.txtplazo5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtplazo5.Location = New System.Drawing.Point(64, 173)
        Me.txtplazo5.MaxLength = 3
        Me.txtplazo5.Name = "txtplazo5"
        Me.txtplazo5.Size = New System.Drawing.Size(66, 22)
        Me.txtplazo5.TabIndex = 188
        Me.txtplazo5.Text = "90"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(10, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 185
        Me.Label9.Text = "Vence a"
        '
        'txtplazo3
        '
        Me.txtplazo3.BackColor = System.Drawing.Color.Aquamarine
        Me.txtplazo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtplazo3.Location = New System.Drawing.Point(64, 118)
        Me.txtplazo3.MaxLength = 3
        Me.txtplazo3.Name = "txtplazo3"
        Me.txtplazo3.Size = New System.Drawing.Size(66, 22)
        Me.txtplazo3.TabIndex = 184
        Me.txtplazo3.Text = "60"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(10, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "Vence a"
        '
        'txtplazo4
        '
        Me.txtplazo4.BackColor = System.Drawing.Color.Aquamarine
        Me.txtplazo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtplazo4.Location = New System.Drawing.Point(64, 146)
        Me.txtplazo4.MaxLength = 3
        Me.txtplazo4.Name = "txtplazo4"
        Me.txtplazo4.Size = New System.Drawing.Size(66, 22)
        Me.txtplazo4.TabIndex = 186
        Me.txtplazo4.Text = "90"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(10, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Vence a"
        '
        'txtplazo1
        '
        Me.txtplazo1.BackColor = System.Drawing.Color.Aquamarine
        Me.txtplazo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtplazo1.Location = New System.Drawing.Point(64, 62)
        Me.txtplazo1.MaxLength = 3
        Me.txtplazo1.Name = "txtplazo1"
        Me.txtplazo1.Size = New System.Drawing.Size(66, 22)
        Me.txtplazo1.TabIndex = 180
        Me.txtplazo1.Text = "15"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(10, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "Vence a"
        '
        'txtplazo2
        '
        Me.txtplazo2.BackColor = System.Drawing.Color.Aquamarine
        Me.txtplazo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtplazo2.Location = New System.Drawing.Point(64, 90)
        Me.txtplazo2.MaxLength = 3
        Me.txtplazo2.Name = "txtplazo2"
        Me.txtplazo2.Size = New System.Drawing.Size(66, 22)
        Me.txtplazo2.TabIndex = 182
        Me.txtplazo2.Text = "30"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.optdetallado)
        Me.GroupBox7.Controls.Add(Me.optexcel)
        Me.GroupBox7.Controls.Add(Me.optrangocobro)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(16, 114)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(217, 116)
        Me.GroupBox7.TabIndex = 112
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Opciones"
        '
        'optdetallado
        '
        Me.optdetallado.AutoSize = True
        Me.optdetallado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.optdetallado.ForeColor = System.Drawing.Color.Navy
        Me.optdetallado.Location = New System.Drawing.Point(20, 86)
        Me.optdetallado.Name = "optdetallado"
        Me.optdetallado.Size = New System.Drawing.Size(111, 17)
        Me.optdetallado.TabIndex = 4
        Me.optdetallado.TabStop = True
        Me.optdetallado.Text = "Formato Detallado"
        Me.optdetallado.UseVisualStyleBackColor = True
        '
        'optexcel
        '
        Me.optexcel.AutoSize = True
        Me.optexcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.optexcel.ForeColor = System.Drawing.Color.Navy
        Me.optexcel.Location = New System.Drawing.Point(20, 53)
        Me.optexcel.Name = "optexcel"
        Me.optexcel.Size = New System.Drawing.Size(92, 17)
        Me.optexcel.TabIndex = 3
        Me.optexcel.TabStop = True
        Me.optexcel.Text = "Formato Excel"
        Me.optexcel.UseVisualStyleBackColor = True
        '
        'optrangocobro
        '
        Me.optrangocobro.AutoSize = True
        Me.optrangocobro.Checked = True
        Me.optrangocobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.optrangocobro.ForeColor = System.Drawing.Color.Navy
        Me.optrangocobro.Location = New System.Drawing.Point(20, 18)
        Me.optrangocobro.Name = "optrangocobro"
        Me.optrangocobro.Size = New System.Drawing.Size(161, 17)
        Me.optrangocobro.TabIndex = 2
        Me.optrangocobro.TabStop = True
        Me.optrangocobro.Text = "Formato con rangos de pago"
        Me.optrangocobro.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Size = New System.Drawing.Size(217, 90)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(12, 55)
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
        Me.dtpfechaFin.Location = New System.Drawing.Point(54, 49)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(105, 20)
        Me.dtpfechaFin.TabIndex = 1
        '
        'Panel_Formato_Concar
        '
        Me.Panel_Formato_Concar.BackColor = System.Drawing.Color.White
        Me.Panel_Formato_Concar.Controls.Add(Me.GroupBox2)
        Me.Panel_Formato_Concar.Location = New System.Drawing.Point(29, 156)
        Me.Panel_Formato_Concar.Name = "Panel_Formato_Concar"
        Me.Panel_Formato_Concar.Size = New System.Drawing.Size(410, 131)
        Me.Panel_Formato_Concar.TabIndex = 189
        Me.Panel_Formato_Concar.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtRuta)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnRuta)
        Me.GroupBox2.Controls.Add(Me.txtArchivo)
        Me.GroupBox2.Controls.Add(Me.btnDetener)
        Me.GroupBox2.Controls.Add(Me.btnIniciar)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 111)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "& Detalles "
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(236, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(66, 65)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(286, 13)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar2.TabIndex = 20
        Me.ProgressBar2.Visible = False
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
        Me.txtRuta.Location = New System.Drawing.Point(67, 18)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(285, 20)
        Me.txtRuta.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(8, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Progreso :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(8, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ruta :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(8, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Archivo :"
        '
        'btnRuta
        '
        Me.btnRuta.Location = New System.Drawing.Point(359, 16)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(25, 23)
        Me.btnRuta.TabIndex = 7
        Me.btnRuta.Text = "..."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(67, 43)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(198, 20)
        Me.txtArchivo.TabIndex = 8
        Me.txtArchivo.Text = "Reg_Compras_Pagos_Diario"
        '
        'btnDetener
        '
        Me.btnDetener.Image = CType(resources.GetObject("btnDetener.Image"), System.Drawing.Image)
        Me.btnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetener.Location = New System.Drawing.Point(152, 83)
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
        Me.btnIniciar.Location = New System.Drawing.Point(73, 83)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 9
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(67, 69)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(282, 9)
        Me.ProgressBar1.TabIndex = 14
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'FrmRegComprasPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(470, 306)
        Me.Controls.Add(Me.Panel_Formato_Concar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmRegComprasPagos"
        Me.Text = "Reg. de Compras Pagos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel_Formato_Concar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtplazo5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtplazo3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtplazo4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtplazo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtplazo2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents optdetallado As System.Windows.Forms.RadioButton
    Friend WithEvents optexcel As System.Windows.Forms.RadioButton
    Friend WithEvents optrangocobro As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel_Formato_Concar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents btnDetener As System.Windows.Forms.Button
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
