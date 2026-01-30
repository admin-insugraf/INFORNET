<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarArticuloRapido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarArticuloRapido))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pb_img = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvDetalleLote = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtigvpor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtdescuento2 = New System.Windows.Forms.TextBox()
        Me.txtdescuento1 = New System.Windows.Forms.TextBox()
        Me.txtprecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlotemanual = New System.Windows.Forms.TextBox()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.btnNuevoLote = New System.Windows.Forms.Button()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtStockLote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLotes = New System.Windows.Forms.ComboBox()
        Me.gb_articulo = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.col_img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvDetalleLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gb_articulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.btn_cancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(922, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(64, 22)
        Me.btnAceptar.Text = "&Añadir"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.pb_img)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(13, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 330)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'pb_img
        '
        Me.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_img.Location = New System.Drawing.Point(13, 19)
        Me.pb_img.Name = "pb_img"
        Me.pb_img.Size = New System.Drawing.Size(332, 300)
        Me.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_img.TabIndex = 197
        Me.pb_img.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DgvDetalleLote)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 338)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(75, 28)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles de Lotes"
        Me.GroupBox3.Visible = False
        '
        'DgvDetalleLote
        '
        Me.DgvDetalleLote.AllowUserToAddRows = False
        Me.DgvDetalleLote.AllowUserToDeleteRows = False
        Me.DgvDetalleLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleLote.Location = New System.Drawing.Point(7, 18)
        Me.DgvDetalleLote.Name = "DgvDetalleLote"
        Me.DgvDetalleLote.ReadOnly = True
        Me.DgvDetalleLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalleLote.Size = New System.Drawing.Size(865, 147)
        Me.DgvDetalleLote.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.txtigvpor)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txtcantidad)
        Me.GroupBox6.Controls.Add(Me.txtdescuento2)
        Me.GroupBox6.Controls.Add(Me.txtdescuento1)
        Me.GroupBox6.Controls.Add(Me.txtprecioUnitario)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox6.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(360, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(220, 307)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(117, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 50)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "&Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(27, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 50)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&Añadir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtigvpor
        '
        Me.txtigvpor.BackColor = System.Drawing.Color.White
        Me.txtigvpor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtigvpor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigvpor.ForeColor = System.Drawing.Color.Red
        Me.txtigvpor.Location = New System.Drawing.Point(275, 267)
        Me.txtigvpor.Name = "txtigvpor"
        Me.txtigvpor.Size = New System.Drawing.Size(83, 21)
        Me.txtigvpor.TabIndex = 12
        Me.txtigvpor.Text = "0"
        Me.txtigvpor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtigvpor.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(235, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "I.G.V."
        Me.Label6.Visible = False
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.Color.Green
        Me.txtcantidad.Location = New System.Drawing.Point(44, 160)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(142, 30)
        Me.txtcantidad.TabIndex = 3
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdescuento2
        '
        Me.txtdescuento2.BackColor = System.Drawing.Color.White
        Me.txtdescuento2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescuento2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento2.ForeColor = System.Drawing.Color.Red
        Me.txtdescuento2.Location = New System.Drawing.Point(977, 149)
        Me.txtdescuento2.Name = "txtdescuento2"
        Me.txtdescuento2.Size = New System.Drawing.Size(83, 21)
        Me.txtdescuento2.TabIndex = 6
        Me.txtdescuento2.Text = "0.00"
        Me.txtdescuento2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdescuento2.Visible = False
        '
        'txtdescuento1
        '
        Me.txtdescuento1.BackColor = System.Drawing.Color.White
        Me.txtdescuento1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescuento1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento1.ForeColor = System.Drawing.Color.Red
        Me.txtdescuento1.Location = New System.Drawing.Point(977, 117)
        Me.txtdescuento1.Name = "txtdescuento1"
        Me.txtdescuento1.Size = New System.Drawing.Size(86, 21)
        Me.txtdescuento1.TabIndex = 5
        Me.txtdescuento1.Text = "0.00"
        Me.txtdescuento1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdescuento1.Visible = False
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.BackColor = System.Drawing.Color.White
        Me.txtprecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecioUnitario.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecioUnitario.ForeColor = System.Drawing.Color.Green
        Me.txtprecioUnitario.Location = New System.Drawing.Point(44, 82)
        Me.txtprecioUnitario.Name = "txtprecioUnitario"
        Me.txtprecioUnitario.Size = New System.Drawing.Size(142, 30)
        Me.txtprecioUnitario.TabIndex = 4
        Me.txtprecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(70, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Cantidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(895, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "%Descuento.2"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(895, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "%Descuento.1"
        Me.Label10.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(40, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Precio Unitario"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtlotemanual)
        Me.GroupBox4.Controls.Add(Me.txtsaldo)
        Me.GroupBox4.Controls.Add(Me.lblsaldo)
        Me.GroupBox4.Controls.Add(Me.btnNuevoLote)
        Me.GroupBox4.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox4.Controls.Add(Me.txtStockLote)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cboLotes)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(903, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(61, 41)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle Lotes"
        Me.GroupBox4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(12, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "&Lotes"
        '
        'txtlotemanual
        '
        Me.txtlotemanual.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtlotemanual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlotemanual.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotemanual.Location = New System.Drawing.Point(55, 14)
        Me.txtlotemanual.Name = "txtlotemanual"
        Me.txtlotemanual.Size = New System.Drawing.Size(134, 23)
        Me.txtlotemanual.TabIndex = 50
        Me.txtlotemanual.Visible = False
        '
        'txtsaldo
        '
        Me.txtsaldo.BackColor = System.Drawing.Color.White
        Me.txtsaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaldo.ForeColor = System.Drawing.Color.Red
        Me.txtsaldo.Location = New System.Drawing.Point(678, 14)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.ReadOnly = True
        Me.txtsaldo.Size = New System.Drawing.Size(99, 21)
        Me.txtsaldo.TabIndex = 48
        Me.txtsaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblsaldo
        '
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.Enabled = False
        Me.lblsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblsaldo.ForeColor = System.Drawing.Color.Navy
        Me.lblsaldo.Location = New System.Drawing.Point(628, 18)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(34, 13)
        Me.lblsaldo.TabIndex = 49
        Me.lblsaldo.Text = "Saldo"
        '
        'btnNuevoLote
        '
        Me.btnNuevoLote.Enabled = False
        Me.btnNuevoLote.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevoLote.ForeColor = System.Drawing.Color.Maroon
        Me.btnNuevoLote.Location = New System.Drawing.Point(195, 9)
        Me.btnNuevoLote.Name = "btnNuevoLote"
        Me.btnNuevoLote.Size = New System.Drawing.Size(36, 32)
        Me.btnNuevoLote.TabIndex = 47
        Me.btnNuevoLote.Text = "+"
        Me.btnNuevoLote.UseVisualStyleBackColor = True
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(357, 13)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(115, 25)
        Me.dtpFechaVencimiento.TabIndex = 25
        '
        'txtStockLote
        '
        Me.txtStockLote.BackColor = System.Drawing.Color.White
        Me.txtStockLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockLote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockLote.ForeColor = System.Drawing.Color.Black
        Me.txtStockLote.Location = New System.Drawing.Point(549, 14)
        Me.txtStockLote.Name = "txtStockLote"
        Me.txtStockLote.ReadOnly = True
        Me.txtStockLote.Size = New System.Drawing.Size(76, 21)
        Me.txtStockLote.TabIndex = 26
        Me.txtStockLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(478, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Stock Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(237, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Vencimiento"
        '
        'cboLotes
        '
        Me.cboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLotes.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cboLotes.FormattingEnabled = True
        Me.cboLotes.Location = New System.Drawing.Point(55, 13)
        Me.cboLotes.Name = "cboLotes"
        Me.cboLotes.Size = New System.Drawing.Size(134, 26)
        Me.cboLotes.TabIndex = 2
        '
        'gb_articulo
        '
        Me.gb_articulo.BackColor = System.Drawing.Color.Transparent
        Me.gb_articulo.Controls.Add(Me.PictureBox1)
        Me.gb_articulo.Controls.Add(Me.txtdescripcionArticulo)
        Me.gb_articulo.Controls.Add(Me.txtcodigoArticulo)
        Me.gb_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_articulo.ForeColor = System.Drawing.Color.Navy
        Me.gb_articulo.Location = New System.Drawing.Point(13, 7)
        Me.gb_articulo.Name = "gb_articulo"
        Me.gb_articulo.Size = New System.Drawing.Size(601, 45)
        Me.gb_articulo.TabIndex = 14
        Me.gb_articulo.TabStop = False
        Me.gb_articulo.Text = "Articulo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(126, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescripcionArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcionArticulo.ForeColor = System.Drawing.Color.Green
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(151, 17)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(444, 19)
        Me.txtdescripcionArticulo.TabIndex = 20
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcodigoArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoArticulo.ForeColor = System.Drawing.Color.Green
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(8, 17)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(111, 19)
        Me.txtcodigoArticulo.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtStock)
        Me.GroupBox5.Controls.Add(Me.txtunidadMedida)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(601, 67)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.White
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.ForeColor = System.Drawing.Color.Green
        Me.txtStock.Location = New System.Drawing.Point(407, 29)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(144, 22)
        Me.txtStock.TabIndex = 22
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtunidadMedida
        '
        Me.txtunidadMedida.BackColor = System.Drawing.Color.White
        Me.txtunidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtunidadMedida.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunidadMedida.ForeColor = System.Drawing.Color.Green
        Me.txtunidadMedida.Location = New System.Drawing.Point(9, 26)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.ReadOnly = True
        Me.txtunidadMedida.Size = New System.Drawing.Size(111, 20)
        Me.txtunidadMedida.TabIndex = 21
        Me.txtunidadMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unid. Med"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(445, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Stock "
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AllowUserToDeleteRows = False
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_img})
        Me.dgv_detalle.Location = New System.Drawing.Point(619, 132)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.Size = New System.Drawing.Size(173, 72)
        Me.dgv_detalle.TabIndex = 201
        Me.dgv_detalle.Visible = False
        '
        'col_img
        '
        Me.col_img.HeaderText = "Foto"
        Me.col_img.Name = "col_img"
        Me.col_img.ReadOnly = True
        '
        'FrmAsignarArticuloRapido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(625, 456)
        Me.Controls.Add(Me.dgv_detalle)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gb_articulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignarArticuloRapido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalles de articulo"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvDetalleLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gb_articulo.ResumeLayout(False)
        Me.gb_articulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDetalleLote As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtigvpor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtdescuento2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdescuento1 As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsaldo As System.Windows.Forms.TextBox
    Friend WithEvents lblsaldo As System.Windows.Forms.Label
    Friend WithEvents btnNuevoLote As System.Windows.Forms.Button
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtStockLote As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboLotes As System.Windows.Forms.ComboBox
    Friend WithEvents gb_articulo As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtunidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtlotemanual As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pb_img As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents col_img As System.Windows.Forms.DataGridViewImageColumn
End Class
