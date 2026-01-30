<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventarioDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventarioDocumentos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbmovimiento = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionInicioMov = New System.Windows.Forms.TextBox()
        Me.txtDescripcionfinMov = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtInicioMov = New System.Windows.Forms.TextBox()
        Me.txtFinMov = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cboTipoMov = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.gbmovimiento.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.gbmovimiento)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 246)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'gbmovimiento
        '
        Me.gbmovimiento.Controls.Add(Me.txtDescripcionInicioMov)
        Me.gbmovimiento.Controls.Add(Me.txtDescripcionfinMov)
        Me.gbmovimiento.Controls.Add(Me.PictureBox1)
        Me.gbmovimiento.Controls.Add(Me.Label3)
        Me.gbmovimiento.Controls.Add(Me.PictureBox3)
        Me.gbmovimiento.Controls.Add(Me.txtInicioMov)
        Me.gbmovimiento.Controls.Add(Me.txtFinMov)
        Me.gbmovimiento.Controls.Add(Me.Label1)
        Me.gbmovimiento.ForeColor = System.Drawing.Color.Navy
        Me.gbmovimiento.Location = New System.Drawing.Point(7, 158)
        Me.gbmovimiento.Name = "gbmovimiento"
        Me.gbmovimiento.Size = New System.Drawing.Size(387, 74)
        Me.gbmovimiento.TabIndex = 121
        Me.gbmovimiento.TabStop = False
        Me.gbmovimiento.Text = "Detalle de Movimientos"
        '
        'txtDescripcionInicioMov
        '
        Me.txtDescripcionInicioMov.BackColor = System.Drawing.Color.White
        Me.txtDescripcionInicioMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionInicioMov.Location = New System.Drawing.Point(171, 19)
        Me.txtDescripcionInicioMov.Name = "txtDescripcionInicioMov"
        Me.txtDescripcionInicioMov.ReadOnly = True
        Me.txtDescripcionInicioMov.Size = New System.Drawing.Size(203, 20)
        Me.txtDescripcionInicioMov.TabIndex = 115
        '
        'txtDescripcionfinMov
        '
        Me.txtDescripcionfinMov.BackColor = System.Drawing.Color.White
        Me.txtDescripcionfinMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionfinMov.Location = New System.Drawing.Point(171, 45)
        Me.txtDescripcionfinMov.Name = "txtDescripcionfinMov"
        Me.txtDescripcionfinMov.ReadOnly = True
        Me.txtDescripcionfinMov.Size = New System.Drawing.Size(203, 20)
        Me.txtDescripcionfinMov.TabIndex = 119
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(146, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Al Movimiento"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(146, 47)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 120
        Me.PictureBox3.TabStop = False
        '
        'txtInicioMov
        '
        Me.txtInicioMov.BackColor = System.Drawing.Color.Aquamarine
        Me.txtInicioMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInicioMov.Location = New System.Drawing.Point(94, 20)
        Me.txtInicioMov.Name = "txtInicioMov"
        Me.txtInicioMov.ReadOnly = True
        Me.txtInicioMov.Size = New System.Drawing.Size(47, 20)
        Me.txtInicioMov.TabIndex = 114
        '
        'txtFinMov
        '
        Me.txtFinMov.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFinMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinMov.Location = New System.Drawing.Point(94, 46)
        Me.txtFinMov.Name = "txtFinMov"
        Me.txtFinMov.ReadOnly = True
        Me.txtFinMov.Size = New System.Drawing.Size(47, 20)
        Me.txtFinMov.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Del Movimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(89, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(236, 21)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "DOCUMENTOS DE ALMACEN"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cboTipoMov)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(240, 104)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(154, 48)
        Me.GroupBox8.TabIndex = 16
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Tipo de Movimiento"
        '
        'cboTipoMov
        '
        Me.cboTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMov.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboTipoMov.FormattingEnabled = True
        Me.cboTipoMov.Items.AddRange(New Object() {"--TODOS--", "INGRESOS ( NI )", "SALIDAS ( NS-GS )"})
        Me.cboTipoMov.Location = New System.Drawing.Point(6, 18)
        Me.cboTipoMov.Name = "cboTipoMov"
        Me.cboTipoMov.Size = New System.Drawing.Size(135, 24)
        Me.cboTipoMov.TabIndex = 2
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox7.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(7, 49)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(387, 50)
        Me.GroupBox7.TabIndex = 14
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Rango de Fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(194, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AL"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(222, 19)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(112, 25)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 10.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(75, 19)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(112, 26)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboAlmacen)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(7, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 48)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione un Almacen"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(6, 18)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(213, 24)
        Me.cboAlmacen.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(432, 25)
        Me.ToolStrip1.TabIndex = 191
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
        'FrmInventarioDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(432, 290)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInventarioDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbmovimiento.ResumeLayout(False)
        Me.gbmovimiento.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionfinMov As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionInicioMov As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFinMov As System.Windows.Forms.TextBox
    Friend WithEvents txtInicioMov As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoMov As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbmovimiento As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
