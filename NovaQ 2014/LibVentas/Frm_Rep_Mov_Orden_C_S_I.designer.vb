<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rep_Mov_Orden_C_S_I
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Rep_Mov_Orden_C_S_I))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_des_prod_final = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_des_prod_inicial = New System.Windows.Forms.TextBox()
        Me.txt_cod_prod_inicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cod_prod_final = New System.Windows.Forms.TextBox()
        Me.checkProductos = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 57)
        Me.GroupBox3.TabIndex = 199
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Rango de Fechas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(175, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(5, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(238, 22)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(103, 25)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 10.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(49, 22)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(103, 26)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(425, 25)
        Me.ToolStrip1.TabIndex = 198
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(118, 22)
        Me.btnMostrar.Text = "&Mostrar reporte"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.checkProductos)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 106)
        Me.GroupBox1.TabIndex = 201
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Productos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_des_prod_final)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_des_prod_inicial)
        Me.GroupBox2.Controls.Add(Me.txt_cod_prod_inicial)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_cod_prod_final)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 60)
        Me.GroupBox2.TabIndex = 179
        Me.GroupBox2.TabStop = False
        '
        'txt_des_prod_final
        '
        Me.txt_des_prod_final.BackColor = System.Drawing.Color.White
        Me.txt_des_prod_final.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_prod_final.Location = New System.Drawing.Point(119, 34)
        Me.txt_des_prod_final.Name = "txt_des_prod_final"
        Me.txt_des_prod_final.ReadOnly = True
        Me.txt_des_prod_final.Size = New System.Drawing.Size(272, 20)
        Me.txt_des_prod_final.TabIndex = 177
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(7, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "Inicial"
        '
        'txt_des_prod_inicial
        '
        Me.txt_des_prod_inicial.BackColor = System.Drawing.Color.White
        Me.txt_des_prod_inicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_prod_inicial.Location = New System.Drawing.Point(119, 11)
        Me.txt_des_prod_inicial.Name = "txt_des_prod_inicial"
        Me.txt_des_prod_inicial.ReadOnly = True
        Me.txt_des_prod_inicial.Size = New System.Drawing.Size(272, 20)
        Me.txt_des_prod_inicial.TabIndex = 176
        '
        'txt_cod_prod_inicial
        '
        Me.txt_cod_prod_inicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_prod_inicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_prod_inicial.Location = New System.Drawing.Point(47, 11)
        Me.txt_cod_prod_inicial.Name = "txt_cod_prod_inicial"
        Me.txt_cod_prod_inicial.ReadOnly = True
        Me.txt_cod_prod_inicial.Size = New System.Drawing.Size(66, 20)
        Me.txt_cod_prod_inicial.TabIndex = 173
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(7, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Final"
        '
        'txt_cod_prod_final
        '
        Me.txt_cod_prod_final.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_prod_final.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_prod_final.Location = New System.Drawing.Point(47, 33)
        Me.txt_cod_prod_final.Name = "txt_cod_prod_final"
        Me.txt_cod_prod_final.ReadOnly = True
        Me.txt_cod_prod_final.Size = New System.Drawing.Size(66, 20)
        Me.txt_cod_prod_final.TabIndex = 174
        '
        'checkProductos
        '
        Me.checkProductos.AutoSize = True
        Me.checkProductos.ForeColor = System.Drawing.Color.Navy
        Me.checkProductos.Location = New System.Drawing.Point(241, 12)
        Me.checkProductos.Name = "checkProductos"
        Me.checkProductos.Size = New System.Drawing.Size(123, 17)
        Me.checkProductos.TabIndex = 183
        Me.checkProductos.Text = "&Todos los Productos"
        Me.checkProductos.UseVisualStyleBackColor = True
        '
        'Frm_Rep_Mov_Orden_C_S_I
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 210)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Rep_Mov_Orden_C_S_I"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Mov. por Ordenes"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_des_prod_final As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_des_prod_inicial As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_prod_inicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_prod_final As System.Windows.Forms.TextBox
    Friend WithEvents checkProductos As System.Windows.Forms.CheckBox
End Class
