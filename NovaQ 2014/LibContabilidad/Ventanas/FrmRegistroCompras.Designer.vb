<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroCompras))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.rdb_no_domiciliados = New System.Windows.Forms.RadioButton()
        Me.rdb_domiciliados = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(57, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 19)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "REGISTRO DE COMPRAS"
        '
        'dtpfecha
        '
        Me.dtpfecha.CustomFormat = "MMMM     -     yyyy "
        Me.dtpfecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha.Location = New System.Drawing.Point(26, 36)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(227, 21)
        Me.dtpfecha.TabIndex = 124
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(17, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 68)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles del Reporte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Especifique Mes y Año."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ok, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(312, 25)
        Me.ToolStrip1.TabIndex = 182
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(118, 22)
        Me.btn_ok.Text = "&Mostrar reporte"
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
        'rdb_no_domiciliados
        '
        Me.rdb_no_domiciliados.AutoSize = True
        Me.rdb_no_domiciliados.ForeColor = System.Drawing.Color.Navy
        Me.rdb_no_domiciliados.Location = New System.Drawing.Point(167, 137)
        Me.rdb_no_domiciliados.Name = "rdb_no_domiciliados"
        Me.rdb_no_domiciliados.Size = New System.Drawing.Size(101, 17)
        Me.rdb_no_domiciliados.TabIndex = 186
        Me.rdb_no_domiciliados.TabStop = True
        Me.rdb_no_domiciliados.Text = "No Domiciliados"
        Me.rdb_no_domiciliados.UseVisualStyleBackColor = True
        '
        'rdb_domiciliados
        '
        Me.rdb_domiciliados.AutoSize = True
        Me.rdb_domiciliados.Checked = True
        Me.rdb_domiciliados.ForeColor = System.Drawing.Color.Navy
        Me.rdb_domiciliados.Location = New System.Drawing.Point(45, 137)
        Me.rdb_domiciliados.Name = "rdb_domiciliados"
        Me.rdb_domiciliados.Size = New System.Drawing.Size(84, 17)
        Me.rdb_domiciliados.TabIndex = 185
        Me.rdb_domiciliados.TabStop = True
        Me.rdb_domiciliados.Text = "Domiciliados"
        Me.rdb_domiciliados.UseVisualStyleBackColor = True
        '
        'FrmRegistroCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(312, 165)
        Me.Controls.Add(Me.rdb_no_domiciliados)
        Me.Controls.Add(Me.rdb_domiciliados)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistroCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents rdb_no_domiciliados As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_domiciliados As System.Windows.Forms.RadioButton
End Class
