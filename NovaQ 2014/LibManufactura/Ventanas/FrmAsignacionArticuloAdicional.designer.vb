<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignacionArticuloAdicional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignacionArticuloAdicional))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboLotes = New System.Windows.Forms.ComboBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboalmacen = New System.Windows.Forms.ComboBox()
        Me.txtunidadarticulo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStrip1.TabIndex = 192
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cboLotes)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboalmacen)
        Me.GroupBox1.Controls.Add(Me.txtunidadarticulo)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 147)
        Me.GroupBox1.TabIndex = 189
        Me.GroupBox1.TabStop = False
        '
        'txtcantidad
        '
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Location = New System.Drawing.Point(66, 113)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(112, 20)
        Me.txtcantidad.TabIndex = 200
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(10, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 201
        Me.Label13.Text = "Cantidad "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(29, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 199
        Me.Label12.Text = "Lotes"
        '
        'cboLotes
        '
        Me.cboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLotes.FormattingEnabled = True
        Me.cboLotes.Location = New System.Drawing.Point(66, 83)
        Me.cboLotes.Name = "cboLotes"
        Me.cboLotes.Size = New System.Drawing.Size(251, 21)
        Me.cboLotes.TabIndex = 198
        '
        'txtstock
        '
        Me.txtstock.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtstock.Location = New System.Drawing.Point(362, 83)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.ReadOnly = True
        Me.txtstock.Size = New System.Drawing.Size(102, 20)
        Me.txtstock.TabIndex = 197
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(322, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 196
        Me.Label10.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(14, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 191
        Me.Label9.Text = "Almacen"
        '
        'cboalmacen
        '
        Me.cboalmacen.BackColor = System.Drawing.SystemColors.Window
        Me.cboalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboalmacen.Location = New System.Drawing.Point(66, 18)
        Me.cboalmacen.Name = "cboalmacen"
        Me.cboalmacen.Size = New System.Drawing.Size(251, 21)
        Me.cboalmacen.TabIndex = 190
        '
        'txtunidadarticulo
        '
        Me.txtunidadarticulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtunidadarticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtunidadarticulo.Location = New System.Drawing.Point(558, 52)
        Me.txtunidadarticulo.Name = "txtunidadarticulo"
        Me.txtunidadarticulo.ReadOnly = True
        Me.txtunidadarticulo.Size = New System.Drawing.Size(78, 20)
        Me.txtunidadarticulo.TabIndex = 110
        Me.txtunidadarticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(155, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(175, 52)
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
        Me.Label18.Location = New System.Drawing.Point(20, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Articulo"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(66, 52)
        Me.txtcodigoArticulo.MaxLength = 20
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.ReadOnly = True
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(85, 20)
        Me.txtcodigoArticulo.TabIndex = 1
        '
        'FrmAsignacionArticuloAdicional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(665, 194)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignacionArticuloAdicional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Articulo Adicional"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtunidadarticulo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboLotes As System.Windows.Forms.ComboBox
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
