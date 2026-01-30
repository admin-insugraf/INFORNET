<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Canje_Letras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Canje_Letras))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkVendedor = New System.Windows.Forms.CheckBox()
        Me.txtClienteInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtClienteInicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txt_desc_estado = New System.Windows.Forms.TextBox()
        Me.txt_cod_estado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_gerencial = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ok, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(427, 25)
        Me.ToolStrip1.TabIndex = 191
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkVendedor)
        Me.GroupBox3.Controls.Add(Me.txtClienteInicialDesc)
        Me.GroupBox3.Controls.Add(Me.txtClienteInicial)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 71)
        Me.GroupBox3.TabIndex = 190
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clientes"
        '
        'checkVendedor
        '
        Me.checkVendedor.AutoSize = True
        Me.checkVendedor.ForeColor = System.Drawing.Color.Navy
        Me.checkVendedor.Location = New System.Drawing.Point(13, 20)
        Me.checkVendedor.Name = "checkVendedor"
        Me.checkVendedor.Size = New System.Drawing.Size(111, 17)
        Me.checkVendedor.TabIndex = 182
        Me.checkVendedor.Text = "Todos los clientes"
        Me.checkVendedor.UseVisualStyleBackColor = True
        '
        'txtClienteInicialDesc
        '
        Me.txtClienteInicialDesc.BackColor = System.Drawing.Color.White
        Me.txtClienteInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteInicialDesc.Location = New System.Drawing.Point(137, 40)
        Me.txtClienteInicialDesc.Name = "txtClienteInicialDesc"
        Me.txtClienteInicialDesc.ReadOnly = True
        Me.txtClienteInicialDesc.Size = New System.Drawing.Size(257, 20)
        Me.txtClienteInicialDesc.TabIndex = 180
        '
        'txtClienteInicial
        '
        Me.txtClienteInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtClienteInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteInicial.Location = New System.Drawing.Point(50, 40)
        Me.txtClienteInicial.Name = "txtClienteInicial"
        Me.txtClienteInicial.ReadOnly = True
        Me.txtClienteInicial.Size = New System.Drawing.Size(81, 20)
        Me.txtClienteInicial.TabIndex = 176
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(9, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Cliente"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox4.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 47)
        Me.GroupBox4.TabIndex = 189
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(198, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hasta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Desde"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(258, 21)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(119, 21)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(49, 20)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(119, 21)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txt_desc_estado)
        Me.GroupBox1.Controls.Add(Me.txt_cod_estado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 71)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estados"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox1.Location = New System.Drawing.Point(13, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 17)
        Me.CheckBox1.TabIndex = 182
        Me.CheckBox1.Text = "Todos los estados"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txt_desc_estado
        '
        Me.txt_desc_estado.BackColor = System.Drawing.Color.White
        Me.txt_desc_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc_estado.Location = New System.Drawing.Point(137, 40)
        Me.txt_desc_estado.Name = "txt_desc_estado"
        Me.txt_desc_estado.ReadOnly = True
        Me.txt_desc_estado.Size = New System.Drawing.Size(257, 20)
        Me.txt_desc_estado.TabIndex = 180
        '
        'txt_cod_estado
        '
        Me.txt_cod_estado.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_estado.Location = New System.Drawing.Point(50, 40)
        Me.txt_cod_estado.Name = "txt_cod_estado"
        Me.txt_cod_estado.ReadOnly = True
        Me.txt_cod_estado.Size = New System.Drawing.Size(81, 20)
        Me.txt_cod_estado.TabIndex = 176
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Estado"
        '
        'chk_gerencial
        '
        Me.chk_gerencial.AutoSize = True
        Me.chk_gerencial.ForeColor = System.Drawing.Color.Navy
        Me.chk_gerencial.Location = New System.Drawing.Point(24, 247)
        Me.chk_gerencial.Name = "chk_gerencial"
        Me.chk_gerencial.Size = New System.Drawing.Size(112, 17)
        Me.chk_gerencial.TabIndex = 193
        Me.chk_gerencial.Text = "Reporte Gerencial"
        Me.chk_gerencial.UseVisualStyleBackColor = True
        '
        'Frm_Canje_Letras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 310)
        Me.Controls.Add(Me.chk_gerencial)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Canje_Letras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canje de Letras"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents checkVendedor As System.Windows.Forms.CheckBox
    Friend WithEvents txtClienteInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_desc_estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_gerencial As System.Windows.Forms.CheckBox
End Class
