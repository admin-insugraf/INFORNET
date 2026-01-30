<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAceptacionLetrasPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAceptacionLetrasPagos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtmonedaSituacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcuentasituacion = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionSituacion = New System.Windows.Forms.TextBox()
        Me.txtcodigoSituacion = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcion_estado = New System.Windows.Forms.TextBox()
        Me.txtmoneda_estado = New System.Windows.Forms.TextBox()
        Me.txtcodigo_estado = New System.Windows.Forms.TextBox()
        Me.txtcuentacontable_estado = New System.Windows.Forms.TextBox()
        Me.txtmoneda = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnumeracionBancaria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCuenta = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdescripcionBanco = New System.Windows.Forms.TextBox()
        Me.txtbanco = New System.Windows.Forms.TextBox()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigoletra = New System.Windows.Forms.TextBox()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnCambiarEstado = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.btnNuevo, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(613, 25)
        Me.ToolStrip1.TabIndex = 174
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripButton1.Text = "&Cambiar de Estado"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(111, 22)
        Me.btnNuevo.Text = "&Actualizar datos"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 491)
        Me.GroupBox1.TabIndex = 173
        Me.GroupBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Blue
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.Location = New System.Drawing.Point(303, 423)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(145, 38)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Retornar"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.Location = New System.Drawing.Point(157, 423)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(144, 38)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Generar Cambio de Estado"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtmonedaSituacion)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtcuentasituacion)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.txtdescripcionSituacion)
        Me.GroupBox2.Controls.Add(Me.txtcodigoSituacion)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtmoneda)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtComentario)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpFechaActualizacion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtnumeracionBancaria)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cboCuenta)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtdescripcionBanco)
        Me.GroupBox2.Controls.Add(Me.txtbanco)
        Me.GroupBox2.Controls.Add(Me.dtpVencimiento)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtcodigoletra)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(47, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 400)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Estado de Letra"
        '
        'txtmonedaSituacion
        '
        Me.txtmonedaSituacion.BackColor = System.Drawing.Color.White
        Me.txtmonedaSituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonedaSituacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonedaSituacion.Location = New System.Drawing.Point(316, 138)
        Me.txtmonedaSituacion.Name = "txtmonedaSituacion"
        Me.txtmonedaSituacion.ReadOnly = True
        Me.txtmonedaSituacion.Size = New System.Drawing.Size(46, 21)
        Me.txtmonedaSituacion.TabIndex = 199
        Me.txtmonedaSituacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(35, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 198
        Me.Label10.Text = "Situacion de Estado"
        '
        'txtcuentasituacion
        '
        Me.txtcuentasituacion.BackColor = System.Drawing.Color.White
        Me.txtcuentasituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentasituacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcuentasituacion.Location = New System.Drawing.Point(365, 138)
        Me.txtcuentasituacion.Name = "txtcuentasituacion"
        Me.txtcuentasituacion.ReadOnly = True
        Me.txtcuentasituacion.Size = New System.Drawing.Size(99, 21)
        Me.txtcuentasituacion.TabIndex = 200
        Me.txtcuentasituacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox1.TabIndex = 193
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionSituacion
        '
        Me.txtdescripcionSituacion.BackColor = System.Drawing.Color.White
        Me.txtdescripcionSituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionSituacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcionSituacion.Location = New System.Drawing.Point(102, 138)
        Me.txtdescripcionSituacion.Name = "txtdescripcionSituacion"
        Me.txtdescripcionSituacion.ReadOnly = True
        Me.txtdescripcionSituacion.Size = New System.Drawing.Size(210, 21)
        Me.txtdescripcionSituacion.TabIndex = 6
        Me.txtdescripcionSituacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSituacion
        '
        Me.txtcodigoSituacion.BackColor = System.Drawing.Color.White
        Me.txtcodigoSituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoSituacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoSituacion.Location = New System.Drawing.Point(33, 137)
        Me.txtcodigoSituacion.Name = "txtcodigoSituacion"
        Me.txtcodigoSituacion.ReadOnly = True
        Me.txtcodigoSituacion.Size = New System.Drawing.Size(46, 21)
        Me.txtcodigoSituacion.TabIndex = 4
        Me.txtcodigoSituacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtdescripcion_estado)
        Me.GroupBox3.Controls.Add(Me.txtmoneda_estado)
        Me.GroupBox3.Controls.Add(Me.txtcodigo_estado)
        Me.GroupBox3.Controls.Add(Me.txtcuentacontable_estado)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(23, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(452, 58)
        Me.GroupBox3.TabIndex = 189
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Situacion anterior de la letra"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(293, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 198
        Me.Label13.Text = "Moneda"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(14, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 197
        Me.Label12.Text = "Codigo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(102, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 196
        Me.Label11.Text = "Descripcion del estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(345, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Cuenta contable"
        '
        'txtdescripcion_estado
        '
        Me.txtdescripcion_estado.BackColor = System.Drawing.Color.White
        Me.txtdescripcion_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion_estado.Location = New System.Drawing.Point(60, 33)
        Me.txtdescripcion_estado.Name = "txtdescripcion_estado"
        Me.txtdescripcion_estado.ReadOnly = True
        Me.txtdescripcion_estado.Size = New System.Drawing.Size(229, 21)
        Me.txtdescripcion_estado.TabIndex = 190
        Me.txtdescripcion_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmoneda_estado
        '
        Me.txtmoneda_estado.BackColor = System.Drawing.Color.White
        Me.txtmoneda_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmoneda_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmoneda_estado.Location = New System.Drawing.Point(294, 33)
        Me.txtmoneda_estado.Name = "txtmoneda_estado"
        Me.txtmoneda_estado.ReadOnly = True
        Me.txtmoneda_estado.Size = New System.Drawing.Size(46, 21)
        Me.txtmoneda_estado.TabIndex = 191
        Me.txtmoneda_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo_estado
        '
        Me.txtcodigo_estado.BackColor = System.Drawing.Color.White
        Me.txtcodigo_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo_estado.Location = New System.Drawing.Point(12, 33)
        Me.txtcodigo_estado.Name = "txtcodigo_estado"
        Me.txtcodigo_estado.ReadOnly = True
        Me.txtcodigo_estado.Size = New System.Drawing.Size(46, 21)
        Me.txtcodigo_estado.TabIndex = 189
        Me.txtcodigo_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcuentacontable_estado
        '
        Me.txtcuentacontable_estado.BackColor = System.Drawing.Color.White
        Me.txtcuentacontable_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentacontable_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcuentacontable_estado.Location = New System.Drawing.Point(342, 33)
        Me.txtcuentacontable_estado.Name = "txtcuentacontable_estado"
        Me.txtcuentacontable_estado.ReadOnly = True
        Me.txtcuentacontable_estado.Size = New System.Drawing.Size(99, 21)
        Me.txtcuentacontable_estado.TabIndex = 192
        Me.txtcuentacontable_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmoneda
        '
        Me.txtmoneda.BackColor = System.Drawing.Color.White
        Me.txtmoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtmoneda.Location = New System.Drawing.Point(149, 33)
        Me.txtmoneda.Name = "txtmoneda"
        Me.txtmoneda.ReadOnly = True
        Me.txtmoneda.Size = New System.Drawing.Size(45, 21)
        Me.txtmoneda.TabIndex = 186
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(149, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 185
        Me.Label9.Text = "Moneda"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(32, 352)
        Me.txtComentario.MaxLength = 255
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(455, 42)
        Me.txtComentario.TabIndex = 184
        Me.txtComentario.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "Comentario"
        '
        'dtpFechaActualizacion
        '
        Me.dtpFechaActualizacion.Location = New System.Drawing.Point(33, 309)
        Me.dtpFechaActualizacion.Name = "dtpFechaActualizacion"
        Me.dtpFechaActualizacion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaActualizacion.TabIndex = 182
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "Fecha Actualizacion"
        '
        'txtnumeracionBancaria
        '
        Me.txtnumeracionBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumeracionBancaria.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtnumeracionBancaria.Location = New System.Drawing.Point(32, 266)
        Me.txtnumeracionBancaria.MaxLength = 21
        Me.txtnumeracionBancaria.Name = "txtnumeracionBancaria"
        Me.txtnumeracionBancaria.Size = New System.Drawing.Size(251, 21)
        Me.txtnumeracionBancaria.TabIndex = 180
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "Numeracion Bancaria"
        '
        'cboCuenta
        '
        Me.cboCuenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(33, 223)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(431, 21)
        Me.cboCuenta.TabIndex = 178
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Cuenta Corriente"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(81, 179)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox2.TabIndex = 176
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Banco"
        '
        'txtdescripcionBanco
        '
        Me.txtdescripcionBanco.BackColor = System.Drawing.Color.White
        Me.txtdescripcionBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionBanco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtdescripcionBanco.Location = New System.Drawing.Point(102, 178)
        Me.txtdescripcionBanco.Name = "txtdescripcionBanco"
        Me.txtdescripcionBanco.ReadOnly = True
        Me.txtdescripcionBanco.Size = New System.Drawing.Size(362, 21)
        Me.txtdescripcionBanco.TabIndex = 174
        '
        'txtbanco
        '
        Me.txtbanco.BackColor = System.Drawing.Color.White
        Me.txtbanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbanco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtbanco.Location = New System.Drawing.Point(33, 178)
        Me.txtbanco.Name = "txtbanco"
        Me.txtbanco.ReadOnly = True
        Me.txtbanco.Size = New System.Drawing.Size(46, 21)
        Me.txtbanco.TabIndex = 173
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Enabled = False
        Me.dtpVencimiento.Location = New System.Drawing.Point(199, 33)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(202, 20)
        Me.dtpVencimiento.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Vencimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nro. Letra"
        '
        'txtcodigoletra
        '
        Me.txtcodigoletra.BackColor = System.Drawing.Color.White
        Me.txtcodigoletra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoletra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtcodigoletra.Location = New System.Drawing.Point(33, 33)
        Me.txtcodigoletra.Name = "txtcodigoletra"
        Me.txtcodigoletra.ReadOnly = True
        Me.txtcodigoletra.Size = New System.Drawing.Size(111, 21)
        Me.txtcodigoletra.TabIndex = 0
        Me.txtcodigoletra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.Controls.Add(Me.lblCantidad)
        Me.pnlPrincipal.Controls.Add(Me.dgvDocumentos)
        Me.pnlPrincipal.Controls.Add(Me.gbFiltros)
        Me.pnlPrincipal.Location = New System.Drawing.Point(8, 32)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(595, 488)
        Me.pnlPrincipal.TabIndex = 175
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(15, 456)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 144
        Me.lblCantidad.Text = "."
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        Me.dgvDocumentos.AllowUserToDeleteRows = False
        Me.dgvDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(12, 60)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.ReadOnly = True
        Me.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDocumentos.Size = New System.Drawing.Size(571, 393)
        Me.dgvDocumentos.TabIndex = 0
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.Controls.Add(Me.btnCambiarEstado)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(12, 5)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(577, 49)
        Me.gbFiltros.TabIndex = 143
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(558, 25)
        Me.txtFiltro.TabIndex = 24
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarEstado.ForeColor = System.Drawing.Color.Blue
        Me.btnCambiarEstado.Image = CType(resources.GetObject("btnCambiarEstado.Image"), System.Drawing.Image)
        Me.btnCambiarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCambiarEstado.Location = New System.Drawing.Point(425, 13)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(129, 28)
        Me.btnCambiarEstado.TabIndex = 1
        Me.btnCambiarEstado.Text = "&Cambiar de Estado"
        Me.btnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCambiarEstado.UseVisualStyleBackColor = True
        Me.btnCambiarEstado.Visible = False
        '
        'FrmAceptacionLetrasPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(613, 524)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAceptacionLetrasPagos"
        Me.Text = "Cambio de estado de letras pagos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmonedaSituacion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcuentasituacion As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcionSituacion As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoSituacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion_estado As System.Windows.Forms.TextBox
    Friend WithEvents txtmoneda_estado As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo_estado As System.Windows.Forms.TextBox
    Friend WithEvents txtcuentacontable_estado As System.Windows.Forms.TextBox
    Friend WithEvents txtmoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtComentario As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaActualizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnumeracionBancaria As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtbanco As System.Windows.Forms.TextBox
    Friend WithEvents dtpVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoletra As System.Windows.Forms.TextBox
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiarEstado As System.Windows.Forms.Button
End Class
