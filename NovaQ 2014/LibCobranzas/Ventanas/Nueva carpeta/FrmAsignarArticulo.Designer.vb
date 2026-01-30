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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtStockLote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLotes = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DgvDetalleLote = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgvDetalleLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(126, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.LightGray
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(153, 14)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(612, 20)
        Me.txtdescripcionArticulo.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(13, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Articulo"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(61, 14)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(59, 20)
        Me.txtcodigoArticulo.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(240, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtSaldo)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtStock)
        Me.GroupBox5.Controls.Add(Me.txtunidadMedida)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(531, 41)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles del Articulo"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.LightGray
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Location = New System.Drawing.Point(456, 15)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(63, 20)
        Me.txtSaldo.TabIndex = 33
        Me.txtSaldo.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(384, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Saldo total :"
        Me.Label6.Visible = False
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.LightGray
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtStock.Location = New System.Drawing.Point(268, 15)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 9
        '
        'txtunidadMedida
        '
        Me.txtunidadMedida.BackColor = System.Drawing.Color.LightGray
        Me.txtunidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedida.Location = New System.Drawing.Point(67, 15)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.ReadOnly = True
        Me.txtunidadMedida.Size = New System.Drawing.Size(79, 20)
        Me.txtunidadMedida.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 17)
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
        Me.Label3.Location = New System.Drawing.Point(148, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Stock Total Producto"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox4.Controls.Add(Me.txtStockLote)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cboLotes)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(531, 41)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "&Detalle Lotes"
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(266, 13)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaVencimiento.TabIndex = 33
        '
        'txtStockLote
        '
        Me.txtStockLote.BackColor = System.Drawing.Color.LightGray
        Me.txtStockLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockLote.Location = New System.Drawing.Point(454, 13)
        Me.txtStockLote.Name = "txtStockLote"
        Me.txtStockLote.ReadOnly = True
        Me.txtStockLote.Size = New System.Drawing.Size(63, 20)
        Me.txtStockLote.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(379, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Stock Lote"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(160, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Vencimiento"
        '
        'cboLotes
        '
        Me.cboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLotes.FormattingEnabled = True
        Me.cboLotes.Location = New System.Drawing.Point(41, 13)
        Me.cboLotes.Name = "cboLotes"
        Me.cboLotes.Size = New System.Drawing.Size(102, 21)
        Me.cboLotes.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtcantidad)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(197, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 43)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcantidad.Location = New System.Drawing.Point(64, 13)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtcantidad.TabIndex = 10
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "&Cantidad"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Location = New System.Drawing.Point(14, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 56)
        Me.Panel1.TabIndex = 30
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Blue
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(81, 1)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 54)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "&Cancelar"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(4, 1)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(67, 54)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DgvDetalleLote)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(225, 159)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "&Detalles de Lotes"
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
        Me.DgvDetalleLote.Size = New System.Drawing.Size(211, 131)
        Me.DgvDetalleLote.TabIndex = 0
        '
        'FrmAsignarArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(790, 282)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignarArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAsignarArticulo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DgvDetalleLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtStockLote As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDetalleLote As System.Windows.Forms.DataGridView
End Class
