<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AF_PR_Incorporacion_Automatica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AF_PR_Incorporacion_Automatica))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_act_deprec_general = New System.Windows.Forms.CheckBox()
        Me.dtp_fecha_inicio_oper = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvdetalles = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_bienes = New System.Windows.Forms.CheckBox()
        Me.btn_bienes = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Mostrar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_total_valor_libros_dolares = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_total_items = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_total_valor_libros_soles = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ruta = New System.Windows.Forms.Button()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.progreso = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chk_act_deprec_general)
        Me.GroupBox2.Controls.Add(Me.dtp_fecha_inicio_oper)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dgvdetalles)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(966, 258)
        Me.GroupBox2.TabIndex = 214
        Me.GroupBox2.TabStop = False
        '
        'chk_act_deprec_general
        '
        Me.chk_act_deprec_general.AutoSize = True
        Me.chk_act_deprec_general.ForeColor = System.Drawing.Color.Navy
        Me.chk_act_deprec_general.Location = New System.Drawing.Point(139, 309)
        Me.chk_act_deprec_general.Name = "chk_act_deprec_general"
        Me.chk_act_deprec_general.Size = New System.Drawing.Size(253, 17)
        Me.chk_act_deprec_general.TabIndex = 30
        Me.chk_act_deprec_general.Text = "Actualizar Depreciación Acumulada a la Fecha?"
        Me.chk_act_deprec_general.UseVisualStyleBackColor = True
        Me.chk_act_deprec_general.Visible = False
        '
        'dtp_fecha_inicio_oper
        '
        Me.dtp_fecha_inicio_oper.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_inicio_oper.Location = New System.Drawing.Point(139, 277)
        Me.dtp_fecha_inicio_oper.Name = "dtp_fecha_inicio_oper"
        Me.dtp_fecha_inicio_oper.Size = New System.Drawing.Size(110, 20)
        Me.dtp_fecha_inicio_oper.TabIndex = 27
        Me.dtp_fecha_inicio_oper.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(9, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Mes y Año de Ini. Oper. :"
        Me.Label9.Visible = False
        '
        'dgvdetalles
        '
        Me.dgvdetalles.AllowUserToAddRows = False
        Me.dgvdetalles.AllowUserToDeleteRows = False
        Me.dgvdetalles.AllowUserToResizeColumns = False
        Me.dgvdetalles.AllowUserToResizeRows = False
        Me.dgvdetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles.Location = New System.Drawing.Point(11, 18)
        Me.dgvdetalles.Name = "dgvdetalles"
        Me.dgvdetalles.ReadOnly = True
        Me.dgvdetalles.Size = New System.Drawing.Size(945, 228)
        Me.dgvdetalles.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rb_bienes)
        Me.GroupBox1.Controls.Add(Me.btn_bienes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(50, 120)
        Me.GroupBox1.TabIndex = 213
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maestros del Sistema"
        Me.GroupBox1.Visible = False
        '
        'rb_bienes
        '
        Me.rb_bienes.AutoSize = True
        Me.rb_bienes.Checked = True
        Me.rb_bienes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rb_bienes.Location = New System.Drawing.Point(15, 22)
        Me.rb_bienes.Name = "rb_bienes"
        Me.rb_bienes.Size = New System.Drawing.Size(100, 17)
        Me.rb_bienes.TabIndex = 32
        Me.rb_bienes.Text = "Bienes Masivos"
        Me.rb_bienes.UseVisualStyleBackColor = True
        '
        'btn_bienes
        '
        Me.btn_bienes.FlatAppearance.BorderSize = 0
        Me.btn_bienes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bienes.Image = CType(resources.GetObject("btn_bienes.Image"), System.Drawing.Image)
        Me.btn_bienes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bienes.Location = New System.Drawing.Point(111, 19)
        Me.btn_bienes.Name = "btn_bienes"
        Me.btn_bienes.Size = New System.Drawing.Size(28, 20)
        Me.btn_bienes.TabIndex = 21
        Me.btn_bienes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_bienes.UseVisualStyleBackColor = True
        Me.btn_bienes.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Mostrar, Me.Tool_Grabar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(990, 25)
        Me.ToolStrip1.TabIndex = 212
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Mostrar
        '
        Me.Tool_Mostrar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Mostrar.Image = CType(resources.GetObject("Tool_Mostrar.Image"), System.Drawing.Image)
        Me.Tool_Mostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Mostrar.Name = "Tool_Mostrar"
        Me.Tool_Mostrar.Size = New System.Drawing.Size(107, 22)
        Me.Tool_Mostrar.Text = "Mostrar datos"
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Enabled = False
        Me.Tool_Grabar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Grabar.Image = CType(resources.GetObject("Tool_Grabar.Image"), System.Drawing.Image)
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(152, 22)
        Me.Tool_Grabar.Text = "&Importar Retenciones"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_total_valor_libros_dolares)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_total_items)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.txt_total_valor_libros_soles)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 102)
        Me.GroupBox3.TabIndex = 215
        Me.GroupBox3.TabStop = False
        '
        'txt_total_valor_libros_dolares
        '
        Me.txt_total_valor_libros_dolares.Location = New System.Drawing.Point(135, 51)
        Me.txt_total_valor_libros_dolares.Name = "txt_total_valor_libros_dolares"
        Me.txt_total_valor_libros_dolares.ReadOnly = True
        Me.txt_total_valor_libros_dolares.Size = New System.Drawing.Size(143, 20)
        Me.txt_total_valor_libros_dolares.TabIndex = 82
        Me.txt_total_valor_libros_dolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(53, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Total Valor 3%"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Navy
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(305, 19)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Resumen de Incorporación"
        '
        'txt_total_items
        '
        Me.txt_total_items.Location = New System.Drawing.Point(135, 74)
        Me.txt_total_items.Name = "txt_total_items"
        Me.txt_total_items.ReadOnly = True
        Me.txt_total_items.Size = New System.Drawing.Size(143, 20)
        Me.txt_total_items.TabIndex = 77
        Me.txt_total_items.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(70, 77)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 13)
        Me.Label27.TabIndex = 78
        Me.Label27.Text = "Total items"
        '
        'txt_total_valor_libros_soles
        '
        Me.txt_total_valor_libros_soles.Location = New System.Drawing.Point(135, 28)
        Me.txt_total_valor_libros_soles.Name = "txt_total_valor_libros_soles"
        Me.txt_total_valor_libros_soles.ReadOnly = True
        Me.txt_total_valor_libros_soles.Size = New System.Drawing.Size(143, 20)
        Me.txt_total_valor_libros_soles.TabIndex = 62
        Me.txt_total_valor_libros_soles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(18, 31)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 13)
        Me.Label23.TabIndex = 64
        Me.Label23.Text = "Total Valor Retención"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtp_fecha)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.btn_ruta)
        Me.GroupBox4.Controls.Add(Me.txt_ruta)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(321, 28)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(385, 101)
        Me.GroupBox4.TabIndex = 216
        Me.GroupBox4.TabStop = False
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CustomFormat = "     MMMM/   yyyy"
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fecha.Location = New System.Drawing.Point(104, 30)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(150, 20)
        Me.dtp_fecha.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(70, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Mes"
        '
        'btn_ruta
        '
        Me.btn_ruta.Location = New System.Drawing.Point(338, 54)
        Me.btn_ruta.Name = "btn_ruta"
        Me.btn_ruta.Size = New System.Drawing.Size(38, 23)
        Me.btn_ruta.TabIndex = 86
        Me.btn_ruta.Text = "..."
        Me.btn_ruta.UseVisualStyleBackColor = True
        '
        'txt_ruta
        '
        Me.txt_ruta.Location = New System.Drawing.Point(104, 56)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.ReadOnly = True
        Me.txt_ruta.Size = New System.Drawing.Size(228, 20)
        Me.txt_ruta.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(8, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Ruta de Archivo :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 19)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Datos de Incorporación"
        '
        'progreso
        '
        Me.progreso.ForeColor = System.Drawing.Color.Lime
        Me.progreso.Location = New System.Drawing.Point(12, 136)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(694, 18)
        Me.progreso.TabIndex = 217
        Me.progreso.Visible = False
        '
        'Frm_AF_PR_Incorporacion_Automatica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 427)
        Me.Controls.Add(Me.progreso)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_AF_PR_Incorporacion_Automatica"
        Me.Text = "Incorporación de Retenciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_act_deprec_general As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_fecha_inicio_oper As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvdetalles As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_bienes As System.Windows.Forms.CheckBox
    Friend WithEvents btn_bienes As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_total_items As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_total_valor_libros_soles As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ruta As System.Windows.Forms.Button
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents Tool_Mostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_total_valor_libros_dolares As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
