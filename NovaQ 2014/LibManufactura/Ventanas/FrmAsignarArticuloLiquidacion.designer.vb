<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarArticuloLiquidacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarArticuloLiquidacion))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboalmaceningreso = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtuccosto = New System.Windows.Forms.TextBox()
        Me.txtcpcosto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtucee = New System.Windows.Forms.TextBox()
        Me.txtcpee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtucinsumos = New System.Windows.Forms.TextBox()
        Me.txtcpinsumos = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboLotes = New System.Windows.Forms.ComboBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboalmacen = New System.Windows.Forms.ComboBox()
        Me.txtunidadpres = New System.Windows.Forms.TextBox()
        Me.txtdescripcionpres = New System.Windows.Forms.TextBox()
        Me.txtcodigopres = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtunidadarticulo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.rdb_liquidacion = New System.Windows.Forms.RadioButton()
        Me.rdb_adicional = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(665, 25)
        Me.ToolStrip1.TabIndex = 188
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 22)
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(76, 22)
        Me.btn_salir.Text = "&Cancelar"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cboalmaceningreso)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtuccosto)
        Me.GroupBox4.Controls.Add(Me.txtcpcosto)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtucee)
        Me.GroupBox4.Controls.Add(Me.txtcpee)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtucinsumos)
        Me.GroupBox4.Controls.Add(Me.txtcpinsumos)
        Me.GroupBox4.Controls.Add(Me.txtcantidad)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(642, 101)
        Me.GroupBox4.TabIndex = 187
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de Liquidación"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(6, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 191
        Me.Label11.Text = "Almacen de Ingreso"
        '
        'cboalmaceningreso
        '
        Me.cboalmaceningreso.BackColor = System.Drawing.SystemColors.Window
        Me.cboalmaceningreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmaceningreso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboalmaceningreso.Location = New System.Drawing.Point(113, 56)
        Me.cboalmaceningreso.Name = "cboalmaceningreso"
        Me.cboalmaceningreso.Size = New System.Drawing.Size(251, 21)
        Me.cboalmaceningreso.TabIndex = 190
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(187, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Costo del Prod. Ter."
        Me.Label8.Visible = False
        '
        'txtuccosto
        '
        Me.txtuccosto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtuccosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuccosto.Location = New System.Drawing.Point(487, 111)
        Me.txtuccosto.Name = "txtuccosto"
        Me.txtuccosto.ReadOnly = True
        Me.txtuccosto.Size = New System.Drawing.Size(108, 20)
        Me.txtuccosto.TabIndex = 58
        Me.txtuccosto.Text = "0.0"
        Me.txtuccosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtuccosto.Visible = False
        '
        'txtcpcosto
        '
        Me.txtcpcosto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtcpcosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcpcosto.Location = New System.Drawing.Point(313, 111)
        Me.txtcpcosto.Name = "txtcpcosto"
        Me.txtcpcosto.ReadOnly = True
        Me.txtcpcosto.Size = New System.Drawing.Size(108, 20)
        Me.txtcpcosto.TabIndex = 57
        Me.txtcpcosto.Text = "0.0"
        Me.txtcpcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcpcosto.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(480, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "---------------------------------------"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(305, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "---------------------------------------"
        Me.Label6.Visible = False
        '
        'txtucee
        '
        Me.txtucee.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtucee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtucee.Location = New System.Drawing.Point(487, 72)
        Me.txtucee.Name = "txtucee"
        Me.txtucee.ReadOnly = True
        Me.txtucee.Size = New System.Drawing.Size(108, 20)
        Me.txtucee.TabIndex = 53
        Me.txtucee.Text = "0.0"
        Me.txtucee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtucee.Visible = False
        '
        'txtcpee
        '
        Me.txtcpee.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtcpee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcpee.Location = New System.Drawing.Point(313, 72)
        Me.txtcpee.Name = "txtcpee"
        Me.txtcpee.ReadOnly = True
        Me.txtcpee.Size = New System.Drawing.Size(108, 20)
        Me.txtcpee.TabIndex = 52
        Me.txtcpee.Text = "0.0"
        Me.txtcpee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcpee.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(187, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Envases y Embalajes"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(483, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Costo Ultimo"
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(298, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Costo Promedio"
        Me.Label1.Visible = False
        '
        'txtucinsumos
        '
        Me.txtucinsumos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtucinsumos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtucinsumos.Location = New System.Drawing.Point(487, 46)
        Me.txtucinsumos.Name = "txtucinsumos"
        Me.txtucinsumos.ReadOnly = True
        Me.txtucinsumos.Size = New System.Drawing.Size(108, 20)
        Me.txtucinsumos.TabIndex = 7
        Me.txtucinsumos.Text = "0.0"
        Me.txtucinsumos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtucinsumos.Visible = False
        '
        'txtcpinsumos
        '
        Me.txtcpinsumos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtcpinsumos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcpinsumos.Location = New System.Drawing.Point(313, 46)
        Me.txtcpinsumos.Name = "txtcpinsumos"
        Me.txtcpinsumos.ReadOnly = True
        Me.txtcpinsumos.Size = New System.Drawing.Size(108, 20)
        Me.txtcpinsumos.TabIndex = 6
        Me.txtcpinsumos.Text = "0.0"
        Me.txtcpinsumos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcpinsumos.Visible = False
        '
        'txtcantidad
        '
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Location = New System.Drawing.Point(113, 22)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(85, 20)
        Me.txtcantidad.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(187, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Insumos"
        Me.Label5.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(55, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cantidad "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.cboLotes)
        Me.GroupBox5.Controls.Add(Me.txtstock)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.cboalmacen)
        Me.GroupBox5.Controls.Add(Me.txtunidadpres)
        Me.GroupBox5.Controls.Add(Me.txtdescripcionpres)
        Me.GroupBox5.Controls.Add(Me.txtcodigopres)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(658, 114)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(642, 101)
        Me.GroupBox5.TabIndex = 186
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles de la presentacion del Articulo"
        Me.GroupBox5.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(17, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 193
        Me.Label12.Text = "Lotes"
        '
        'cboLotes
        '
        Me.cboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLotes.FormattingEnabled = True
        Me.cboLotes.Location = New System.Drawing.Point(54, 71)
        Me.cboLotes.Name = "cboLotes"
        Me.cboLotes.Size = New System.Drawing.Size(112, 21)
        Me.cboLotes.TabIndex = 192
        '
        'txtstock
        '
        Me.txtstock.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtstock.Location = New System.Drawing.Point(351, 45)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.ReadOnly = True
        Me.txtstock.Size = New System.Drawing.Size(102, 20)
        Me.txtstock.TabIndex = 191
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(311, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 190
        Me.Label10.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(3, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "Almacen"
        '
        'cboalmacen
        '
        Me.cboalmacen.BackColor = System.Drawing.SystemColors.Window
        Me.cboalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboalmacen.Location = New System.Drawing.Point(54, 44)
        Me.cboalmacen.Name = "cboalmacen"
        Me.cboalmacen.Size = New System.Drawing.Size(251, 21)
        Me.cboalmacen.TabIndex = 188
        '
        'txtunidadpres
        '
        Me.txtunidadpres.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtunidadpres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadpres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtunidadpres.Location = New System.Drawing.Point(550, 19)
        Me.txtunidadpres.Name = "txtunidadpres"
        Me.txtunidadpres.ReadOnly = True
        Me.txtunidadpres.Size = New System.Drawing.Size(78, 20)
        Me.txtunidadpres.TabIndex = 113
        Me.txtunidadpres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdescripcionpres
        '
        Me.txtdescripcionpres.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtdescripcionpres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionpres.Location = New System.Drawing.Point(167, 19)
        Me.txtdescripcionpres.Name = "txtdescripcionpres"
        Me.txtdescripcionpres.ReadOnly = True
        Me.txtdescripcionpres.Size = New System.Drawing.Size(377, 20)
        Me.txtdescripcionpres.TabIndex = 112
        '
        'txtcodigopres
        '
        Me.txtcodigopres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigopres.Location = New System.Drawing.Point(54, 19)
        Me.txtcodigopres.Name = "txtcodigopres"
        Me.txtcodigopres.ReadOnly = True
        Me.txtcodigopres.Size = New System.Drawing.Size(85, 20)
        Me.txtcodigopres.TabIndex = 111
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtunidadarticulo)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 45)
        Me.GroupBox1.TabIndex = 185
        Me.GroupBox1.TabStop = False
        '
        'txtunidadarticulo
        '
        Me.txtunidadarticulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtunidadarticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtunidadarticulo.Location = New System.Drawing.Point(550, 14)
        Me.txtunidadarticulo.Name = "txtunidadarticulo"
        Me.txtunidadarticulo.ReadOnly = True
        Me.txtunidadarticulo.Size = New System.Drawing.Size(78, 20)
        Me.txtunidadarticulo.TabIndex = 110
        Me.txtunidadarticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(147, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(167, 14)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(377, 20)
        Me.txtdescripcionArticulo.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(8, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Articulo"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(54, 14)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.ReadOnly = True
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(85, 20)
        Me.txtcodigoArticulo.TabIndex = 1
        '
        'rdb_liquidacion
        '
        Me.rdb_liquidacion.AutoSize = True
        Me.rdb_liquidacion.Checked = True
        Me.rdb_liquidacion.ForeColor = System.Drawing.Color.Navy
        Me.rdb_liquidacion.Location = New System.Drawing.Point(144, 37)
        Me.rdb_liquidacion.Name = "rdb_liquidacion"
        Me.rdb_liquidacion.Size = New System.Drawing.Size(79, 17)
        Me.rdb_liquidacion.TabIndex = 189
        Me.rdb_liquidacion.TabStop = True
        Me.rdb_liquidacion.Text = "Liquidación"
        Me.rdb_liquidacion.UseVisualStyleBackColor = True
        '
        'rdb_adicional
        '
        Me.rdb_adicional.AutoSize = True
        Me.rdb_adicional.ForeColor = System.Drawing.Color.Navy
        Me.rdb_adicional.Location = New System.Drawing.Point(466, 37)
        Me.rdb_adicional.Name = "rdb_adicional"
        Me.rdb_adicional.Size = New System.Drawing.Size(68, 17)
        Me.rdb_adicional.TabIndex = 190
        Me.rdb_adicional.Text = "Adicional"
        Me.rdb_adicional.UseVisualStyleBackColor = True
        '
        'FrmAsignarArticuloLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(665, 229)
        Me.Controls.Add(Me.rdb_adicional)
        Me.Controls.Add(Me.rdb_liquidacion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignarArticuloLiquidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar Articulo para Liquidar"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtucinsumos As System.Windows.Forms.TextBox
    Friend WithEvents txtcpinsumos As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtunidadpres As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionpres As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigopres As System.Windows.Forms.TextBox
    Friend WithEvents txtunidadarticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtucee As System.Windows.Forms.TextBox
    Friend WithEvents txtcpee As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtuccosto As System.Windows.Forms.TextBox
    Friend WithEvents txtcpcosto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboalmaceningreso As System.Windows.Forms.ComboBox
    Friend WithEvents rdb_liquidacion As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_adicional As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboLotes As System.Windows.Forms.ComboBox
End Class
