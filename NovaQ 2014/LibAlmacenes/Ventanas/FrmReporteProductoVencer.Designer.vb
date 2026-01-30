<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteProductoVencer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteProductoVencer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chklstAlmacenes = New System.Windows.Forms.CheckedListBox()
        Me.checkAlmacen = New System.Windows.Forms.CheckBox()
        Me.gbArticulos = New System.Windows.Forms.GroupBox()
        Me.chk_articulos = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtarticulofinal = New System.Windows.Forms.TextBox()
        Me.txtarticuloInicial = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkfamilia = New System.Windows.Forms.CheckBox()
        Me.cboFamilia = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chklineas = New System.Windows.Forms.CheckBox()
        Me.cbolinea = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbArticulos.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha limite de vencimiento"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(17, 16)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(154, 21)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.chklstAlmacenes)
        Me.GroupBox2.Controls.Add(Me.checkAlmacen)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(11, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 191)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione un Almacen"
        '
        'chklstAlmacenes
        '
        Me.chklstAlmacenes.CheckOnClick = True
        Me.chklstAlmacenes.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chklstAlmacenes.FormattingEnabled = True
        Me.chklstAlmacenes.Location = New System.Drawing.Point(17, 41)
        Me.chklstAlmacenes.Name = "chklstAlmacenes"
        Me.chklstAlmacenes.Size = New System.Drawing.Size(357, 140)
        Me.chklstAlmacenes.TabIndex = 6
        '
        'checkAlmacen
        '
        Me.checkAlmacen.AutoSize = True
        Me.checkAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkAlmacen.ForeColor = System.Drawing.Color.Navy
        Me.checkAlmacen.Location = New System.Drawing.Point(19, 18)
        Me.checkAlmacen.Name = "checkAlmacen"
        Me.checkAlmacen.Size = New System.Drawing.Size(92, 17)
        Me.checkAlmacen.TabIndex = 7
        Me.checkAlmacen.Text = "Activar Todos"
        Me.checkAlmacen.UseVisualStyleBackColor = True
        '
        'gbArticulos
        '
        Me.gbArticulos.BackColor = System.Drawing.Color.White
        Me.gbArticulos.Controls.Add(Me.chk_articulos)
        Me.gbArticulos.Controls.Add(Me.Label4)
        Me.gbArticulos.Controls.Add(Me.Label3)
        Me.gbArticulos.Controls.Add(Me.txtarticulofinal)
        Me.gbArticulos.Controls.Add(Me.txtarticuloInicial)
        Me.gbArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbArticulos.ForeColor = System.Drawing.Color.Navy
        Me.gbArticulos.Location = New System.Drawing.Point(11, 375)
        Me.gbArticulos.Name = "gbArticulos"
        Me.gbArticulos.Size = New System.Drawing.Size(400, 46)
        Me.gbArticulos.TabIndex = 9
        Me.gbArticulos.TabStop = False
        Me.gbArticulos.Text = "Rango de Articulos"
        '
        'chk_articulos
        '
        Me.chk_articulos.AutoSize = True
        Me.chk_articulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_articulos.ForeColor = System.Drawing.Color.Navy
        Me.chk_articulos.Location = New System.Drawing.Point(287, 0)
        Me.chk_articulos.Name = "chk_articulos"
        Me.chk_articulos.Size = New System.Drawing.Size(114, 17)
        Me.chk_articulos.TabIndex = 13
        Me.chk_articulos.Text = "Todos los articulos"
        Me.chk_articulos.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(167, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(9, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Inicial"
        '
        'txtarticulofinal
        '
        Me.txtarticulofinal.BackColor = System.Drawing.Color.Aquamarine
        Me.txtarticulofinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtarticulofinal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarticulofinal.Location = New System.Drawing.Point(202, 19)
        Me.txtarticulofinal.Name = "txtarticulofinal"
        Me.txtarticulofinal.ReadOnly = True
        Me.txtarticulofinal.Size = New System.Drawing.Size(112, 21)
        Me.txtarticulofinal.TabIndex = 10
        '
        'txtarticuloInicial
        '
        Me.txtarticuloInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtarticuloInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtarticuloInicial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarticuloInicial.Location = New System.Drawing.Point(49, 19)
        Me.txtarticuloInicial.Name = "txtarticuloInicial"
        Me.txtarticuloInicial.ReadOnly = True
        Me.txtarticuloInicial.Size = New System.Drawing.Size(112, 21)
        Me.txtarticuloInicial.TabIndex = 9
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkfamilia)
        Me.GroupBox6.Controls.Add(Me.cboFamilia)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(399, 48)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Seleccione una Familia"
        '
        'chkfamilia
        '
        Me.chkfamilia.AutoSize = True
        Me.chkfamilia.ForeColor = System.Drawing.Color.Navy
        Me.chkfamilia.Location = New System.Drawing.Point(277, 21)
        Me.chkfamilia.Name = "chkfamilia"
        Me.chkfamilia.Size = New System.Drawing.Size(112, 17)
        Me.chkfamilia.TabIndex = 14
        Me.chkfamilia.Text = "Todas las Familias"
        Me.chkfamilia.UseVisualStyleBackColor = True
        '
        'cboFamilia
        '
        Me.cboFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFamilia.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboFamilia.FormattingEnabled = True
        Me.cboFamilia.Location = New System.Drawing.Point(16, 18)
        Me.cboFamilia.Name = "cboFamilia"
        Me.cboFamilia.Size = New System.Drawing.Size(255, 24)
        Me.cboFamilia.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chklineas)
        Me.GroupBox3.Controls.Add(Me.cbolinea)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 48)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione una linea"
        '
        'chklineas
        '
        Me.chklineas.AutoSize = True
        Me.chklineas.ForeColor = System.Drawing.Color.Navy
        Me.chklineas.Location = New System.Drawing.Point(277, 20)
        Me.chklineas.Name = "chklineas"
        Me.chklineas.Size = New System.Drawing.Size(102, 17)
        Me.chklineas.TabIndex = 15
        Me.chklineas.Text = "Todas las lineas"
        Me.chklineas.UseVisualStyleBackColor = True
        '
        'cbolinea
        '
        Me.cbolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolinea.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbolinea.FormattingEnabled = True
        Me.cbolinea.Location = New System.Drawing.Point(16, 16)
        Me.cbolinea.Name = "cbolinea"
        Me.cbolinea.Size = New System.Drawing.Size(255, 24)
        Me.cbolinea.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(427, 25)
        Me.ToolStrip1.TabIndex = 188
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(118, 22)
        Me.btnMostrar.Text = "&Mostrar reporte"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'FrmReporteProductoVencer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 426)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbArticulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReporteProductoVencer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Producto a vencer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbArticulos.ResumeLayout(False)
        Me.gbArticulos.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents txtarticulofinal As System.Windows.Forms.TextBox
    Friend WithEvents txtarticuloInicial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chklstAlmacenes As System.Windows.Forms.CheckedListBox
    Friend WithEvents checkAlmacen As System.Windows.Forms.CheckBox
    Friend WithEvents chk_articulos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbolinea As System.Windows.Forms.ComboBox
    Friend WithEvents chkfamilia As System.Windows.Forms.CheckBox
    Friend WithEvents chklineas As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
