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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkindicacion = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtexceso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.txtcantidadteorica = New System.Windows.Forms.TextBox()
        Me.txtcantidadPractica = New System.Windows.Forms.TextBox()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbounidadMedida = New System.Windows.Forms.ComboBox()
        Me.txtequivalencia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(161, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(186, 14)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(358, 20)
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
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigoArticulo.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkindicacion)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtexceso)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtcosto)
        Me.GroupBox4.Controls.Add(Me.txtcantidadteorica)
        Me.GroupBox4.Controls.Add(Me.txtcantidadPractica)
        Me.GroupBox4.Controls.Add(Me.lblsaldo)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 131)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(560, 47)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle Lotes"
        '
        'chkindicacion
        '
        Me.chkindicacion.AutoSize = True
        Me.chkindicacion.Checked = True
        Me.chkindicacion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkindicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkindicacion.ForeColor = System.Drawing.Color.Navy
        Me.chkindicacion.Location = New System.Drawing.Point(11, 72)
        Me.chkindicacion.Name = "chkindicacion"
        Me.chkindicacion.Size = New System.Drawing.Size(337, 17)
        Me.chkindicacion.TabIndex = 55
        Me.chkindicacion.Text = "Indica si la descarga de unidades es completa por lotes a Fabricar"
        Me.chkindicacion.UseVisualStyleBackColor = True
        Me.chkindicacion.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(243, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 16)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "%"
        Me.Label6.Visible = False
        '
        'txtexceso
        '
        Me.txtexceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtexceso.Location = New System.Drawing.Point(137, 48)
        Me.txtexceso.Name = "txtexceso"
        Me.txtexceso.Size = New System.Drawing.Size(100, 20)
        Me.txtexceso.TabIndex = 8
        Me.txtexceso.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(8, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Contiene un Exceso del"
        Me.Label4.Visible = False
        '
        'txtcosto
        '
        Me.txtcosto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtcosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcosto.Location = New System.Drawing.Point(444, 17)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(100, 20)
        Me.txtcosto.TabIndex = 7
        Me.txtcosto.Visible = False
        '
        'txtcantidadteorica
        '
        Me.txtcantidadteorica.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtcantidadteorica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidadteorica.Location = New System.Drawing.Point(274, 17)
        Me.txtcantidadteorica.Name = "txtcantidadteorica"
        Me.txtcantidadteorica.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidadteorica.TabIndex = 6
        Me.txtcantidadteorica.Visible = False
        '
        'txtcantidadPractica
        '
        Me.txtcantidadPractica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidadPractica.Location = New System.Drawing.Point(54, 16)
        Me.txtcantidadPractica.Name = "txtcantidadPractica"
        Me.txtcantidadPractica.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidadPractica.TabIndex = 5
        '
        'lblsaldo
        '
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.Enabled = False
        Me.lblsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblsaldo.ForeColor = System.Drawing.Color.Navy
        Me.lblsaldo.Location = New System.Drawing.Point(380, 20)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(34, 13)
        Me.lblsaldo.TabIndex = 49
        Me.lblsaldo.Text = "Costo"
        Me.lblsaldo.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(196, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Cant.Teorica"
        Me.Label5.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cantidad"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbounidadMedida)
        Me.GroupBox5.Controls.Add(Me.txtequivalencia)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(560, 46)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles del Articulo"
        '
        'cbounidadMedida
        '
        Me.cbounidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbounidadMedida.FormattingEnabled = True
        Me.cbounidadMedida.Location = New System.Drawing.Point(90, 15)
        Me.cbounidadMedida.Name = "cbounidadMedida"
        Me.cbounidadMedida.Size = New System.Drawing.Size(219, 21)
        Me.cbounidadMedida.TabIndex = 3
        '
        'txtequivalencia
        '
        Me.txtequivalencia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtequivalencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtequivalencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtequivalencia.Location = New System.Drawing.Point(449, 17)
        Me.txtequivalencia.Name = "txtequivalencia"
        Me.txtequivalencia.ReadOnly = True
        Me.txtequivalencia.Size = New System.Drawing.Size(96, 20)
        Me.txtequivalencia.TabIndex = 4
        Me.txtequivalencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtequivalencia.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unid. Med"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(315, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Equivalencia Conversion"
        Me.Label3.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(581, 25)
        Me.ToolStrip1.TabIndex = 184
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
        'FrmAsignarArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 185)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignarArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar Articulo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtequivalencia As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblsaldo As System.Windows.Forms.Label
    Friend WithEvents cbounidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidadteorica As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidadPractica As System.Windows.Forms.TextBox
    Friend WithEvents txtexceso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkindicacion As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
