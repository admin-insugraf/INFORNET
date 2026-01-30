<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarDetalle))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcomposicion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtVolumen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtrsn = New System.Windows.Forms.TextBox()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_des_articulo = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_articulo = New System.Windows.Forms.TextBox()
        Me.txtunidadMedida = New System.Windows.Forms.TextBox()
        Me.cboArticulo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_des_formula = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_formula = New System.Windows.Forms.TextBox()
        Me.cboformula_ee = New System.Windows.Forms.ComboBox()
        Me.cboformula_mp = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtcomposicion)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dtpVencimiento)
        Me.GroupBox4.Controls.Add(Me.txtVolumen)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtrsn)
        Me.GroupBox4.Controls.Add(Me.lblsaldo)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(6, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(560, 100)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "&Detalle Lotes"
        Me.GroupBox4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(396, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "ml"
        '
        'txtcomposicion
        '
        Me.txtcomposicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomposicion.Location = New System.Drawing.Point(314, 73)
        Me.txtcomposicion.Name = "txtcomposicion"
        Me.txtcomposicion.Size = New System.Drawing.Size(76, 20)
        Me.txtcomposicion.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(91, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Composicion : Cada Ampolla contiene "
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.CustomFormat = "MMMM -   yyyy"
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVencimiento.Location = New System.Drawing.Point(84, 19)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(179, 20)
        Me.dtpVencimiento.TabIndex = 6
        '
        'txtVolumen
        '
        Me.txtVolumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVolumen.Location = New System.Drawing.Point(137, 47)
        Me.txtVolumen.Name = "txtVolumen"
        Me.txtVolumen.Size = New System.Drawing.Size(100, 20)
        Me.txtVolumen.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(8, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Volumen de LLenado"
        '
        'txtrsn
        '
        Me.txtrsn.Location = New System.Drawing.Point(314, 18)
        Me.txtrsn.Name = "txtrsn"
        Me.txtrsn.Size = New System.Drawing.Size(150, 20)
        Me.txtrsn.TabIndex = 7
        '
        'lblsaldo
        '
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblsaldo.ForeColor = System.Drawing.Color.Navy
        Me.lblsaldo.Location = New System.Drawing.Point(269, 21)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(36, 13)
        Me.lblsaldo.TabIndex = 49
        Me.lblsaldo.Text = "R.S.N"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Vencimiento"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_des_articulo)
        Me.GroupBox5.Controls.Add(Me.PictureBox10)
        Me.GroupBox5.Controls.Add(Me.txt_cod_articulo)
        Me.GroupBox5.Controls.Add(Me.txtunidadMedida)
        Me.GroupBox5.Controls.Add(Me.cboArticulo)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(9, 33)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(560, 79)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles del Articulo"
        '
        'txt_des_articulo
        '
        Me.txt_des_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_articulo.ForeColor = System.Drawing.Color.Black
        Me.txt_des_articulo.Location = New System.Drawing.Point(187, 19)
        Me.txt_des_articulo.Name = "txt_des_articulo"
        Me.txt_des_articulo.ReadOnly = True
        Me.txt_des_articulo.Size = New System.Drawing.Size(366, 20)
        Me.txt_des_articulo.TabIndex = 192
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(162, 20)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox10.TabIndex = 191
        Me.PictureBox10.TabStop = False
        '
        'txt_cod_articulo
        '
        Me.txt_cod_articulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_articulo.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_articulo.Location = New System.Drawing.Point(70, 19)
        Me.txt_cod_articulo.Name = "txt_cod_articulo"
        Me.txt_cod_articulo.ReadOnly = True
        Me.txt_cod_articulo.Size = New System.Drawing.Size(88, 20)
        Me.txt_cod_articulo.TabIndex = 1
        '
        'txtunidadMedida
        '
        Me.txtunidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunidadMedida.Location = New System.Drawing.Point(70, 46)
        Me.txtunidadMedida.Name = "txtunidadMedida"
        Me.txtunidadMedida.ReadOnly = True
        Me.txtunidadMedida.Size = New System.Drawing.Size(88, 20)
        Me.txtunidadMedida.TabIndex = 2
        '
        'cboArticulo
        '
        Me.cboArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArticulo.FormattingEnabled = True
        Me.cboArticulo.Location = New System.Drawing.Point(269, 45)
        Me.cboArticulo.Name = "cboArticulo"
        Me.cboArticulo.Size = New System.Drawing.Size(284, 21)
        Me.cboArticulo.TabIndex = 1
        Me.cboArticulo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(17, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Articulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(3, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unid. Med"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(9, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 47)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad a Producir"
        '
        'txtcantidad
        '
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Location = New System.Drawing.Point(70, 19)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(88, 20)
        Me.txtcantidad.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(30, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Cant."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_des_formula)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.txt_cod_formula)
        Me.GroupBox2.Controls.Add(Me.cboformula_ee)
        Me.GroupBox2.Controls.Add(Me.cboformula_mp)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(9, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 52)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles de Formulas"
        '
        'txt_des_formula
        '
        Me.txt_des_formula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_formula.ForeColor = System.Drawing.Color.Black
        Me.txt_des_formula.Location = New System.Drawing.Point(187, 19)
        Me.txt_des_formula.Name = "txt_des_formula"
        Me.txt_des_formula.ReadOnly = True
        Me.txt_des_formula.Size = New System.Drawing.Size(366, 20)
        Me.txt_des_formula.TabIndex = 195
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(162, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 194
        Me.PictureBox1.TabStop = False
        '
        'txt_cod_formula
        '
        Me.txt_cod_formula.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_formula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_formula.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_formula.Location = New System.Drawing.Point(70, 19)
        Me.txt_cod_formula.Name = "txt_cod_formula"
        Me.txt_cod_formula.ReadOnly = True
        Me.txt_cod_formula.Size = New System.Drawing.Size(88, 20)
        Me.txt_cod_formula.TabIndex = 193
        '
        'cboformula_ee
        '
        Me.cboformula_ee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboformula_ee.FormattingEnabled = True
        Me.cboformula_ee.Location = New System.Drawing.Point(81, 64)
        Me.cboformula_ee.Name = "cboformula_ee"
        Me.cboformula_ee.Size = New System.Drawing.Size(472, 21)
        Me.cboformula_ee.TabIndex = 5
        Me.cboformula_ee.Visible = False
        '
        'cboformula_mp
        '
        Me.cboformula_mp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboformula_mp.FormattingEnabled = True
        Me.cboformula_mp.Location = New System.Drawing.Point(474, 21)
        Me.cboformula_mp.Name = "cboformula_mp"
        Me.cboformula_mp.Size = New System.Drawing.Size(80, 21)
        Me.cboformula_mp.TabIndex = 4
        Me.cboformula_mp.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(7, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Formula ME"
        Me.Label9.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(6, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Formula MP"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(581, 25)
        Me.ToolStrip1.TabIndex = 183
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
        'FrmAsignarDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 233)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignarDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalles"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblsaldo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtrsn As System.Windows.Forms.TextBox
    Friend WithEvents txtVolumen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtunidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents cboArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcomposicion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboformula_ee As System.Windows.Forms.ComboBox
    Friend WithEvents cboformula_mp As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_des_articulo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_articulo As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_formula As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_formula As System.Windows.Forms.TextBox
End Class
