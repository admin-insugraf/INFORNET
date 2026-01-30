<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMostrarReporte
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMostrarReporte))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.gpbDetallado = New System.Windows.Forms.GroupBox()
        Me.CheckGrupoDany = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbGrSinValor = New System.Windows.Forms.RadioButton()
        Me.rbvendedor = New System.Windows.Forms.RadioButton()
        Me.rbresumido = New System.Windows.Forms.RadioButton()
        Me.rbdetallado = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.checkMostrarTodos = New System.Windows.Forms.CheckBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbproductosinStock = New System.Windows.Forms.RadioButton()
        Me.rbStockValorizado = New System.Windows.Forms.RadioButton()
        Me.rbStockSinValorizar = New System.Windows.Forms.RadioButton()
        Me.checkProductoSinStock = New System.Windows.Forms.CheckBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gpbDetallado.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnMostrar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(42, 487)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 129)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Palatino Linotype", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSalir.Location = New System.Drawing.Point(331, 38)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(254, 59)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "REGRESAR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Palatino Linotype", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnMostrar.Location = New System.Drawing.Point(71, 38)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(254, 59)
        Me.btnMostrar.TabIndex = 9
        Me.btnMostrar.Text = "MOSTRAR REPORTE"
        Me.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'gpbDetallado
        '
        Me.gpbDetallado.BackColor = System.Drawing.Color.Gainsboro
        Me.gpbDetallado.Controls.Add(Me.CheckGrupoDany)
        Me.gpbDetallado.Controls.Add(Me.GroupBox2)
        Me.gpbDetallado.ForeColor = System.Drawing.Color.Black
        Me.gpbDetallado.Location = New System.Drawing.Point(42, 347)
        Me.gpbDetallado.Name = "gpbDetallado"
        Me.gpbDetallado.Size = New System.Drawing.Size(649, 119)
        Me.gpbDetallado.TabIndex = 10
        Me.gpbDetallado.TabStop = False
        '
        'CheckGrupoDany
        '
        Me.CheckGrupoDany.AutoSize = True
        Me.CheckGrupoDany.Font = New System.Drawing.Font("Palatino Linotype", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.CheckGrupoDany.Location = New System.Drawing.Point(3, 8)
        Me.CheckGrupoDany.Name = "CheckGrupoDany"
        Me.CheckGrupoDany.Size = New System.Drawing.Size(158, 28)
        Me.CheckGrupoDany.TabIndex = 5
        Me.CheckGrupoDany.Text = "GRUPO DANY"
        Me.CheckGrupoDany.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbGrSinValor)
        Me.GroupBox2.Controls.Add(Me.rbvendedor)
        Me.GroupBox2.Controls.Add(Me.rbresumido)
        Me.GroupBox2.Controls.Add(Me.rbdetallado)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(199, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(439, 80)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Escoga un tipo de Reporte"
        '
        'rbGrSinValor
        '
        Me.rbGrSinValor.AutoSize = True
        Me.rbGrSinValor.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Underline)
        Me.rbGrSinValor.Location = New System.Drawing.Point(111, 33)
        Me.rbGrSinValor.Name = "rbGrSinValor"
        Me.rbGrSinValor.Size = New System.Drawing.Size(116, 26)
        Me.rbGrSinValor.TabIndex = 9
        Me.rbGrSinValor.TabStop = True
        Me.rbGrSinValor.Text = "Sin Valorizar"
        Me.rbGrSinValor.UseVisualStyleBackColor = True
        Me.rbGrSinValor.Visible = False
        '
        'rbvendedor
        '
        Me.rbvendedor.AutoSize = True
        Me.rbvendedor.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Underline)
        Me.rbvendedor.Location = New System.Drawing.Point(238, 33)
        Me.rbvendedor.Name = "rbvendedor"
        Me.rbvendedor.Size = New System.Drawing.Size(93, 26)
        Me.rbvendedor.TabIndex = 7
        Me.rbvendedor.TabStop = True
        Me.rbvendedor.Text = "Vendedor"
        Me.rbvendedor.UseVisualStyleBackColor = True
        '
        'rbresumido
        '
        Me.rbresumido.AutoSize = True
        Me.rbresumido.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Underline)
        Me.rbresumido.Location = New System.Drawing.Point(7, 33)
        Me.rbresumido.Name = "rbresumido"
        Me.rbresumido.Size = New System.Drawing.Size(95, 26)
        Me.rbresumido.TabIndex = 6
        Me.rbresumido.TabStop = True
        Me.rbresumido.Text = "Resumido"
        Me.rbresumido.UseVisualStyleBackColor = True
        '
        'rbdetallado
        '
        Me.rbdetallado.AutoSize = True
        Me.rbdetallado.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Underline)
        Me.rbdetallado.Location = New System.Drawing.Point(340, 32)
        Me.rbdetallado.Name = "rbdetallado"
        Me.rbdetallado.Size = New System.Drawing.Size(93, 26)
        Me.rbdetallado.TabIndex = 8
        Me.rbdetallado.TabStop = True
        Me.rbdetallado.Text = "Detallado"
        Me.rbdetallado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(68, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(598, 55)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "&DETALLE DE REPORTES"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Controls.Add(Me.lblFiltro)
        Me.GroupBox4.Controls.Add(Me.checkMostrarTodos)
        Me.GroupBox4.Controls.Add(Me.lbldescripcion)
        Me.GroupBox4.Controls.Add(Me.txtFiltro)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(42, 191)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(649, 129)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = CType(resources.GetObject("PictureBox3.ErrorImage"), System.Drawing.Image)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(88, 89)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox3.TabIndex = 109
        Me.PictureBox3.TabStop = False
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblFiltro.Location = New System.Drawing.Point(6, 52)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(17, 27)
        Me.lblFiltro.TabIndex = 1
        Me.lblFiltro.Text = "."
        '
        'checkMostrarTodos
        '
        Me.checkMostrarTodos.AutoSize = True
        Me.checkMostrarTodos.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.checkMostrarTodos.Location = New System.Drawing.Point(6, 10)
        Me.checkMostrarTodos.Name = "checkMostrarTodos"
        Me.checkMostrarTodos.Size = New System.Drawing.Size(36, 31)
        Me.checkMostrarTodos.TabIndex = 3
        Me.checkMostrarTodos.Text = "."
        Me.checkMostrarTodos.UseVisualStyleBackColor = True
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Palatino Linotype", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lbldescripcion.ForeColor = System.Drawing.Color.Maroon
        Me.lbldescripcion.Location = New System.Drawing.Point(132, 94)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(15, 24)
        Me.lbldescripcion.TabIndex = 3
        Me.lbldescripcion.Text = "."
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.SystemColors.Info
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtFiltro.Location = New System.Drawing.Point(3, 89)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.ReadOnly = True
        Me.txtFiltro.Size = New System.Drawing.Size(82, 34)
        Me.txtFiltro.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(42, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(649, 85)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RANGO DE FECHAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(21, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 108
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(265, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AL"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(322, 31)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(169, 43)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(91, 31)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(169, 44)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.checkProductoSinStock)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(42, 637)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(649, 85)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(29, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "SIN STOCK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(1, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "INCLUIR PRODUCTO "
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.rbproductosinStock)
        Me.GroupBox6.Controls.Add(Me.rbStockValorizado)
        Me.GroupBox6.Controls.Add(Me.rbStockSinValorizar)
        Me.GroupBox6.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(175, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(465, 65)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Escoga un tipo de Reporte"
        '
        'rbproductosinStock
        '
        Me.rbproductosinStock.AutoSize = True
        Me.rbproductosinStock.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Underline)
        Me.rbproductosinStock.Location = New System.Drawing.Point(276, 30)
        Me.rbproductosinStock.Name = "rbproductosinStock"
        Me.rbproductosinStock.Size = New System.Drawing.Size(185, 30)
        Me.rbproductosinStock.TabIndex = 9
        Me.rbproductosinStock.TabStop = True
        Me.rbproductosinStock.Text = "Producto Sin Stock"
        Me.rbproductosinStock.UseVisualStyleBackColor = True
        '
        'rbStockValorizado
        '
        Me.rbStockValorizado.AutoSize = True
        Me.rbStockValorizado.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Underline)
        Me.rbStockValorizado.Location = New System.Drawing.Point(7, 30)
        Me.rbStockValorizado.Name = "rbStockValorizado"
        Me.rbStockValorizado.Size = New System.Drawing.Size(118, 30)
        Me.rbStockValorizado.TabIndex = 6
        Me.rbStockValorizado.TabStop = True
        Me.rbStockValorizado.Text = "Valorizado"
        Me.rbStockValorizado.UseVisualStyleBackColor = True
        '
        'rbStockSinValorizar
        '
        Me.rbStockSinValorizar.AutoSize = True
        Me.rbStockSinValorizar.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Underline)
        Me.rbStockSinValorizar.Location = New System.Drawing.Point(134, 30)
        Me.rbStockSinValorizar.Name = "rbStockSinValorizar"
        Me.rbStockSinValorizar.Size = New System.Drawing.Size(133, 30)
        Me.rbStockSinValorizar.TabIndex = 8
        Me.rbStockSinValorizar.TabStop = True
        Me.rbStockSinValorizar.Text = "Sin valorizar"
        Me.rbStockSinValorizar.UseVisualStyleBackColor = True
        '
        'checkProductoSinStock
        '
        Me.checkProductoSinStock.AutoSize = True
        Me.checkProductoSinStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkProductoSinStock.Location = New System.Drawing.Point(8, 36)
        Me.checkProductoSinStock.Name = "checkProductoSinStock"
        Me.checkProductoSinStock.Size = New System.Drawing.Size(15, 14)
        Me.checkProductoSinStock.TabIndex = 6
        Me.checkProductoSinStock.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FrmMostrarReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(735, 631)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gpbDetallado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMostrarReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmMostrarReportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.gpbDetallado.ResumeLayout(False)
        Me.gpbDetallado.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents gpbDetallado As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents lblFiltro As System.Windows.Forms.Label
    Public WithEvents checkMostrarTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbdetallado As System.Windows.Forms.RadioButton
    Public WithEvents CheckGrupoDany As System.Windows.Forms.CheckBox
    Public WithEvents rbresumido As System.Windows.Forms.RadioButton
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents rbvendedor As System.Windows.Forms.RadioButton
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Public WithEvents rbStockValorizado As System.Windows.Forms.RadioButton
    Friend WithEvents rbStockSinValorizar As System.Windows.Forms.RadioButton
    Friend WithEvents checkProductoSinStock As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Public WithEvents rbGrSinValor As System.Windows.Forms.RadioButton
    Friend WithEvents rbproductosinStock As System.Windows.Forms.RadioButton
End Class
