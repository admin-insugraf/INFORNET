<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OP_Planta_Act_No_Programada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_OP_Planta_Act_No_Programada))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_historial_personal = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_nro_op = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_motivo = New System.Windows.Forms.ComboBox()
        Me.chk_mantenimiento_equipo = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_equipo = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.dtp_fecha_hp = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txt_descripcion_hp = New System.Windows.Forms.TextBox()
        Me.btn_add_hp = New System.Windows.Forms.Button()
        Me.dgv_detalle_hp = New System.Windows.Forms.DataGridView()
        Me.txt_titulo_hp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_malos = New System.Windows.Forms.TextBox()
        Me.txt_buenos = New System.Windows.Forms.TextBox()
        Me.pnl_historial_personal.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgv_detalle_hp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_historial_personal
        '
        Me.pnl_historial_personal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_historial_personal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_historial_personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_historial_personal.Controls.Add(Me.GroupBox5)
        Me.pnl_historial_personal.Controls.Add(Me.txt_titulo_hp)
        Me.pnl_historial_personal.Location = New System.Drawing.Point(5, 12)
        Me.pnl_historial_personal.Name = "pnl_historial_personal"
        Me.pnl_historial_personal.Size = New System.Drawing.Size(1007, 477)
        Me.pnl_historial_personal.TabIndex = 216
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txt_malos)
        Me.GroupBox5.Controls.Add(Me.txt_buenos)
        Me.GroupBox5.Controls.Add(Me.txt_nro_op)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.cbo_motivo)
        Me.GroupBox5.Controls.Add(Me.chk_mantenimiento_equipo)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txt_equipo)
        Me.GroupBox5.Controls.Add(Me.Label47)
        Me.GroupBox5.Controls.Add(Me.dtp_fecha_hp)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.txt_descripcion_hp)
        Me.GroupBox5.Controls.Add(Me.btn_add_hp)
        Me.GroupBox5.Controls.Add(Me.dgv_detalle_hp)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(15, 29)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(973, 434)
        Me.GroupBox5.TabIndex = 197
        Me.GroupBox5.TabStop = False
        '
        'txt_nro_op
        '
        Me.txt_nro_op.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_nro_op.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_op.ForeColor = System.Drawing.Color.Black
        Me.txt_nro_op.Location = New System.Drawing.Point(547, 41)
        Me.txt_nro_op.Name = "txt_nro_op"
        Me.txt_nro_op.ReadOnly = True
        Me.txt_nro_op.Size = New System.Drawing.Size(126, 20)
        Me.txt_nro_op.TabIndex = 263
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(498, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "N° O.P."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(47, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 228
        Me.Label2.Text = "Motivo"
        '
        'cbo_motivo
        '
        Me.cbo_motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_motivo.FormattingEnabled = True
        Me.cbo_motivo.Location = New System.Drawing.Point(92, 41)
        Me.cbo_motivo.Name = "cbo_motivo"
        Me.cbo_motivo.Size = New System.Drawing.Size(340, 21)
        Me.cbo_motivo.TabIndex = 227
        '
        'chk_mantenimiento_equipo
        '
        Me.chk_mantenimiento_equipo.AutoSize = True
        Me.chk_mantenimiento_equipo.Location = New System.Drawing.Point(232, 129)
        Me.chk_mantenimiento_equipo.Name = "chk_mantenimiento_equipo"
        Me.chk_mantenimiento_equipo.Size = New System.Drawing.Size(171, 17)
        Me.chk_mantenimiento_equipo.TabIndex = 226
        Me.chk_mantenimiento_equipo.Text = "Por mantenimiento de maquina"
        Me.chk_mantenimiento_equipo.UseVisualStyleBackColor = True
        Me.chk_mantenimiento_equipo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(46, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 225
        Me.Label1.Text = "Equipo"
        '
        'txt_equipo
        '
        Me.txt_equipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_equipo.ForeColor = System.Drawing.Color.Black
        Me.txt_equipo.Location = New System.Drawing.Point(92, 15)
        Me.txt_equipo.MaxLength = 20
        Me.txt_equipo.Name = "txt_equipo"
        Me.txt_equipo.ReadOnly = True
        Me.txt_equipo.Size = New System.Drawing.Size(340, 20)
        Me.txt_equipo.TabIndex = 224
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(19, 69)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(67, 13)
        Me.Label47.TabIndex = 221
        Me.Label47.Text = "Observación"
        '
        'dtp_fecha_hp
        '
        Me.dtp_fecha_hp.Enabled = False
        Me.dtp_fecha_hp.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_hp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_hp.Location = New System.Drawing.Point(92, 125)
        Me.dtp_fecha_hp.Name = "dtp_fecha_hp"
        Me.dtp_fecha_hp.Size = New System.Drawing.Size(102, 25)
        Me.dtp_fecha_hp.TabIndex = 218
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(49, 131)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(37, 13)
        Me.Label45.TabIndex = 217
        Me.Label45.Text = "Fecha"
        '
        'txt_descripcion_hp
        '
        Me.txt_descripcion_hp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descripcion_hp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcion_hp.ForeColor = System.Drawing.Color.Black
        Me.txt_descripcion_hp.Location = New System.Drawing.Point(92, 65)
        Me.txt_descripcion_hp.MaxLength = 200
        Me.txt_descripcion_hp.Name = "txt_descripcion_hp"
        Me.txt_descripcion_hp.Size = New System.Drawing.Size(873, 20)
        Me.txt_descripcion_hp.TabIndex = 216
        '
        'btn_add_hp
        '
        Me.btn_add_hp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_hp.Image = CType(resources.GetObject("btn_add_hp.Image"), System.Drawing.Image)
        Me.btn_add_hp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_hp.Location = New System.Drawing.Point(481, 126)
        Me.btn_add_hp.Name = "btn_add_hp"
        Me.btn_add_hp.Size = New System.Drawing.Size(73, 23)
        Me.btn_add_hp.TabIndex = 49
        Me.btn_add_hp.Text = "Agregar"
        Me.btn_add_hp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add_hp.UseVisualStyleBackColor = True
        '
        'dgv_detalle_hp
        '
        Me.dgv_detalle_hp.AllowUserToAddRows = False
        Me.dgv_detalle_hp.AllowUserToDeleteRows = False
        Me.dgv_detalle_hp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle_hp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_detalle_hp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_hp.Location = New System.Drawing.Point(7, 158)
        Me.dgv_detalle_hp.Name = "dgv_detalle_hp"
        Me.dgv_detalle_hp.ReadOnly = True
        Me.dgv_detalle_hp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle_hp.Size = New System.Drawing.Size(955, 264)
        Me.dgv_detalle_hp.TabIndex = 47
        '
        'txt_titulo_hp
        '
        Me.txt_titulo_hp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_titulo_hp.BackColor = System.Drawing.Color.Navy
        Me.txt_titulo_hp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_titulo_hp.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titulo_hp.ForeColor = System.Drawing.Color.White
        Me.txt_titulo_hp.Location = New System.Drawing.Point(0, 0)
        Me.txt_titulo_hp.Name = "txt_titulo_hp"
        Me.txt_titulo_hp.ReadOnly = True
        Me.txt_titulo_hp.Size = New System.Drawing.Size(1005, 20)
        Me.txt_titulo_hp.TabIndex = 170
        Me.txt_titulo_hp.Text = "REGISTRAR ACTIVIDADES NO PROGRAMADAS"
        Me.txt_titulo_hp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(229, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 267
        Me.Label13.Text = "Pliegos Malos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 266
        Me.Label12.Text = "Pliegos Buenos"
        '
        'txt_malos
        '
        Me.txt_malos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_malos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_malos.ForeColor = System.Drawing.Color.Maroon
        Me.txt_malos.Location = New System.Drawing.Point(305, 90)
        Me.txt_malos.MaxLength = 200
        Me.txt_malos.Name = "txt_malos"
        Me.txt_malos.Size = New System.Drawing.Size(120, 22)
        Me.txt_malos.TabIndex = 265
        '
        'txt_buenos
        '
        Me.txt_buenos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buenos.ForeColor = System.Drawing.Color.Maroon
        Me.txt_buenos.Location = New System.Drawing.Point(92, 90)
        Me.txt_buenos.MaxLength = 200
        Me.txt_buenos.Name = "txt_buenos"
        Me.txt_buenos.Size = New System.Drawing.Size(120, 22)
        Me.txt_buenos.TabIndex = 264
        '
        'Frm_OP_Planta_Act_No_Programada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 500)
        Me.Controls.Add(Me.pnl_historial_personal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_OP_Planta_Act_No_Programada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Actividades No Programadas"
        Me.pnl_historial_personal.ResumeLayout(False)
        Me.pnl_historial_personal.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgv_detalle_hp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_historial_personal As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_mantenimiento_equipo As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_equipo As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_hp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion_hp As System.Windows.Forms.TextBox
    Friend WithEvents btn_add_hp As System.Windows.Forms.Button
    Friend WithEvents dgv_detalle_hp As System.Windows.Forms.DataGridView
    Friend WithEvents txt_titulo_hp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_motivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nro_op As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_malos As System.Windows.Forms.TextBox
    Friend WithEvents txt_buenos As System.Windows.Forms.TextBox
End Class
