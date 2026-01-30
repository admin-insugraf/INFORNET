<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarArticulo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtdescuento2 = New System.Windows.Forms.TextBox()
        Me.txtdescuento1 = New System.Windows.Forms.TextBox()
        Me.txtprecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.btnNuevoLote = New System.Windows.Forms.Button()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtStockLote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboLotes = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtlotemanual = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.LightGray
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(137, 14)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(393, 20)
        Me.txtdescripcionArticulo.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Articulo"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(61, 14)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(54, 20)
        Me.txtcodigoArticulo.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(827, 124)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtcantidad)
        Me.GroupBox6.Controls.Add(Me.txtdescuento2)
        Me.GroupBox6.Controls.Add(Me.txtdescuento1)
        Me.GroupBox6.Controls.Add(Me.txtprecioUnitario)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(811, 51)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtcantidad.Location = New System.Drawing.Point(671, 15)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(96, 25)
        Me.txtcantidad.TabIndex = 6
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdescuento2
        '
        Me.txtdescuento2.BackColor = System.Drawing.Color.White
        Me.txtdescuento2.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtdescuento2.ForeColor = System.Drawing.Color.Red
        Me.txtdescuento2.Location = New System.Drawing.Point(322, 16)
        Me.txtdescuento2.Name = "txtdescuento2"
        Me.txtdescuento2.Size = New System.Drawing.Size(83, 25)
        Me.txtdescuento2.TabIndex = 4
        Me.txtdescuento2.Text = "0.00"
        Me.txtdescuento2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdescuento1
        '
        Me.txtdescuento1.BackColor = System.Drawing.Color.White
        Me.txtdescuento1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtdescuento1.ForeColor = System.Drawing.Color.Red
        Me.txtdescuento1.Location = New System.Drawing.Point(142, 15)
        Me.txtdescuento1.Name = "txtdescuento1"
        Me.txtdescuento1.Size = New System.Drawing.Size(86, 25)
        Me.txtdescuento1.TabIndex = 3
        Me.txtdescuento1.Text = "0.00"
        Me.txtdescuento1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.BackColor = System.Drawing.Color.White
        Me.txtprecioUnitario.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtprecioUnitario.Location = New System.Drawing.Point(507, 15)
        Me.txtprecioUnitario.Name = "txtprecioUnitario"
        Me.txtprecioUnitario.Size = New System.Drawing.Size(96, 25)
        Me.txtprecioUnitario.TabIndex = 5
        Me.txtprecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(608, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "&Cantidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(233, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "%Descuento.2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(42, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 19)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "%Descuento.1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(412, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "&Precio Unitario"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtsaldo)
        Me.GroupBox4.Controls.Add(Me.lblsaldo)
        Me.GroupBox4.Controls.Add(Me.btnNuevoLote)
        Me.GroupBox4.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox4.Controls.Add(Me.txtStockLote)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cboLotes)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(812, 45)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "&Detalle Lotes"
        '
        'txtsaldo
        '
        Me.txtsaldo.BackColor = System.Drawing.Color.White
        Me.txtsaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsaldo.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtsaldo.ForeColor = System.Drawing.Color.Red
        Me.txtsaldo.Location = New System.Drawing.Point(670, 14)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.ReadOnly = True
        Me.txtsaldo.Size = New System.Drawing.Size(99, 25)
        Me.txtsaldo.TabIndex = 48
        Me.txtsaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblsaldo
        '
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.Enabled = False
        Me.lblsaldo.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblsaldo.ForeColor = System.Drawing.Color.Black
        Me.lblsaldo.Location = New System.Drawing.Point(623, 18)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(36, 16)
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
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(340, 13)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(115, 25)
        Me.dtpFechaVencimiento.TabIndex = 25
        '
        'txtStockLote
        '
        Me.txtStockLote.BackColor = System.Drawing.Color.LightGray
        Me.txtStockLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockLote.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtStockLote.ForeColor = System.Drawing.Color.Black
        Me.txtStockLote.Location = New System.Drawing.Point(528, 14)
        Me.txtStockLote.Name = "txtStockLote"
        Me.txtStockLote.ReadOnly = True
        Me.txtStockLote.Size = New System.Drawing.Size(76, 25)
        Me.txtStockLote.TabIndex = 26
        Me.txtStockLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(461, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Stock Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(235, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Vencimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Lotes"
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtStock)
        Me.GroupBox5.Controls.Add(Me.txtunidadMedida)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(551, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(288, 45)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles del Articulo"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.LightGray
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtStock.Location = New System.Drawing.Point(204, 14)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(74, 20)
        Me.txtStock.TabIndex = 22
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtunidadMedida
        '
        Me.txtunidadMedida.BackColor = System.Drawing.Color.LightGray
        Me.txtunidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedida.Location = New System.Drawing.Point(67, 15)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.ReadOnly = True
        Me.txtunidadMedida.Size = New System.Drawing.Size(60, 20)
        Me.txtunidadMedida.TabIndex = 21
        Me.txtunidadMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unid. Med"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(133, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Stock Total."
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.ForeColor = System.Drawing.Color.Blue
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(82, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 52)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "&Cancelar"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(12, 5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(69, 52)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtlotemanual
        '
        Me.txtlotemanual.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtlotemanual.Font = New System.Drawing.Font("Palatino Linotype", 10.5!, System.Drawing.FontStyle.Bold)
        Me.txtlotemanual.Location = New System.Drawing.Point(73, 129)
        Me.txtlotemanual.Name = "txtlotemanual"
        Me.txtlotemanual.Size = New System.Drawing.Size(134, 26)
        Me.txtlotemanual.TabIndex = 9
        Me.txtlotemanual.Visible = False
        '
        'FrmAsignarArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(847, 236)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtlotemanual)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignarArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar Articulo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboLotes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtunidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtStockLote As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescuento2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdescuento1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnNuevoLote As System.Windows.Forms.Button
    Friend WithEvents txtsaldo As System.Windows.Forms.TextBox
    Friend WithEvents lblsaldo As System.Windows.Forms.Label
    Friend WithEvents txtlotemanual As System.Windows.Forms.TextBox
End Class
