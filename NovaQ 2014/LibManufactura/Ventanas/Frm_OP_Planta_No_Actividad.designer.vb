<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OP_Planta_No_Actividad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_OP_Planta_No_Actividad))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_historial_personal = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
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
        Me.gb_trabajaos_mantenimiento = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgv_proveedor = New System.Windows.Forms.DataGridView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_menos = New System.Windows.Forms.Button()
        Me.btn_mas = New System.Windows.Forms.Button()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.dgv_lista_proveedor = New System.Windows.Forms.DataGridView()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.pnl_historial_personal.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgv_detalle_hp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_trabajaos_mantenimiento.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        CType(Me.dgv_lista_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_historial_personal.Location = New System.Drawing.Point(4, 11)
        Me.pnl_historial_personal.Name = "pnl_historial_personal"
        Me.pnl_historial_personal.Size = New System.Drawing.Size(1007, 423)
        Me.pnl_historial_personal.TabIndex = 215
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox5.Size = New System.Drawing.Size(973, 380)
        Me.GroupBox5.TabIndex = 197
        Me.GroupBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(9, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Motivo"
        '
        'cbo_motivo
        '
        Me.cbo_motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_motivo.FormattingEnabled = True
        Me.cbo_motivo.Location = New System.Drawing.Point(52, 39)
        Me.cbo_motivo.Name = "cbo_motivo"
        Me.cbo_motivo.Size = New System.Drawing.Size(340, 21)
        Me.cbo_motivo.TabIndex = 229
        '
        'chk_mantenimiento_equipo
        '
        Me.chk_mantenimiento_equipo.AutoSize = True
        Me.chk_mantenimiento_equipo.Location = New System.Drawing.Point(142, 96)
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
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 225
        Me.Label1.Text = "Equipo"
        '
        'txt_equipo
        '
        Me.txt_equipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_equipo.ForeColor = System.Drawing.Color.Black
        Me.txt_equipo.Location = New System.Drawing.Point(52, 15)
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
        Me.Label47.Size = New System.Drawing.Size(29, 13)
        Me.Label47.TabIndex = 221
        Me.Label47.Text = "Obs."
        '
        'dtp_fecha_hp
        '
        Me.dtp_fecha_hp.Enabled = False
        Me.dtp_fecha_hp.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_hp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_hp.Location = New System.Drawing.Point(52, 92)
        Me.dtp_fecha_hp.Name = "dtp_fecha_hp"
        Me.dtp_fecha_hp.Size = New System.Drawing.Size(83, 25)
        Me.dtp_fecha_hp.TabIndex = 218
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(11, 98)
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
        Me.txt_descripcion_hp.Location = New System.Drawing.Point(52, 65)
        Me.txt_descripcion_hp.MaxLength = 200
        Me.txt_descripcion_hp.Name = "txt_descripcion_hp"
        Me.txt_descripcion_hp.Size = New System.Drawing.Size(913, 20)
        Me.txt_descripcion_hp.TabIndex = 216
        '
        'btn_add_hp
        '
        Me.btn_add_hp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_hp.Image = CType(resources.GetObject("btn_add_hp.Image"), System.Drawing.Image)
        Me.btn_add_hp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_hp.Location = New System.Drawing.Point(391, 93)
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
        Me.dgv_detalle_hp.Location = New System.Drawing.Point(7, 124)
        Me.dgv_detalle_hp.Name = "dgv_detalle_hp"
        Me.dgv_detalle_hp.ReadOnly = True
        Me.dgv_detalle_hp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle_hp.Size = New System.Drawing.Size(955, 244)
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
        Me.txt_titulo_hp.Text = "REGISTRAR SIN TRABAJO"
        Me.txt_titulo_hp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gb_trabajaos_mantenimiento
        '
        Me.gb_trabajaos_mantenimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_trabajaos_mantenimiento.Controls.Add(Me.GroupBox4)
        Me.gb_trabajaos_mantenimiento.Controls.Add(Me.btn_cancel)
        Me.gb_trabajaos_mantenimiento.Controls.Add(Me.btn_aceptar)
        Me.gb_trabajaos_mantenimiento.Controls.Add(Me.btn_menos)
        Me.gb_trabajaos_mantenimiento.Controls.Add(Me.btn_mas)
        Me.gb_trabajaos_mantenimiento.Controls.Add(Me.GroupBox15)
        Me.gb_trabajaos_mantenimiento.ForeColor = System.Drawing.Color.Navy
        Me.gb_trabajaos_mantenimiento.Location = New System.Drawing.Point(4, 11)
        Me.gb_trabajaos_mantenimiento.Name = "gb_trabajaos_mantenimiento"
        Me.gb_trabajaos_mantenimiento.Size = New System.Drawing.Size(1006, 423)
        Me.gb_trabajaos_mantenimiento.TabIndex = 216
        Me.gb_trabajaos_mantenimiento.TabStop = False
        Me.gb_trabajaos_mantenimiento.Text = "Trabajos de Mantenimiento"
        Me.gb_trabajaos_mantenimiento.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.dgv_proveedor)
        Me.GroupBox4.Location = New System.Drawing.Point(551, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(444, 353)
        Me.GroupBox4.TabIndex = 159
        Me.GroupBox4.TabStop = False
        '
        'dgv_proveedor
        '
        Me.dgv_proveedor.AllowUserToAddRows = False
        Me.dgv_proveedor.AllowUserToDeleteRows = False
        Me.dgv_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedor.Location = New System.Drawing.Point(9, 41)
        Me.dgv_proveedor.Name = "dgv_proveedor"
        Me.dgv_proveedor.ReadOnly = True
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_proveedor.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_proveedor.Size = New System.Drawing.Size(425, 298)
        Me.dgv_proveedor.TabIndex = 155
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.Location = New System.Drawing.Point(770, 377)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(69, 36)
        Me.btn_cancel.TabIndex = 158
        Me.btn_cancel.Text = "Cancelar"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_aceptar.Location = New System.Drawing.Point(692, 377)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(69, 36)
        Me.btn_aceptar.TabIndex = 157
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_menos
        '
        Me.btn_menos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_menos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menos.Location = New System.Drawing.Point(473, 210)
        Me.btn_menos.Name = "btn_menos"
        Me.btn_menos.Size = New System.Drawing.Size(69, 36)
        Me.btn_menos.TabIndex = 156
        Me.btn_menos.Text = "<"
        Me.btn_menos.UseVisualStyleBackColor = True
        '
        'btn_mas
        '
        Me.btn_mas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_mas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mas.Location = New System.Drawing.Point(473, 148)
        Me.btn_mas.Name = "btn_mas"
        Me.btn_mas.Size = New System.Drawing.Size(69, 36)
        Me.btn_mas.TabIndex = 155
        Me.btn_mas.Text = ">"
        Me.btn_mas.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox15.Controls.Add(Me.dgv_lista_proveedor)
        Me.GroupBox15.Controls.Add(Me.txtbusqueda)
        Me.GroupBox15.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox15.Location = New System.Drawing.Point(15, 18)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(444, 353)
        Me.GroupBox15.TabIndex = 153
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Ingrese texto a Buscar :"
        '
        'dgv_lista_proveedor
        '
        Me.dgv_lista_proveedor.AllowUserToAddRows = False
        Me.dgv_lista_proveedor.AllowUserToDeleteRows = False
        Me.dgv_lista_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_proveedor.Location = New System.Drawing.Point(7, 42)
        Me.dgv_lista_proveedor.Name = "dgv_lista_proveedor"
        Me.dgv_lista_proveedor.ReadOnly = True
        Me.dgv_lista_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_proveedor.Size = New System.Drawing.Size(424, 302)
        Me.dgv_lista_proveedor.TabIndex = 25
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbusqueda.BackColor = System.Drawing.Color.Aquamarine
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbusqueda.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(7, 16)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(424, 22)
        Me.txtbusqueda.TabIndex = 24
        '
        'Frm_OP_Planta_No_Actividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 446)
        Me.Controls.Add(Me.gb_trabajaos_mantenimiento)
        Me.Controls.Add(Me.pnl_historial_personal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_OP_Planta_No_Actividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Inoperatividad"
        Me.pnl_historial_personal.ResumeLayout(False)
        Me.pnl_historial_personal.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgv_detalle_hp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_trabajaos_mantenimiento.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.dgv_lista_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_historial_personal As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_hp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion_hp As System.Windows.Forms.TextBox
    Friend WithEvents btn_add_hp As System.Windows.Forms.Button
    Friend WithEvents dgv_detalle_hp As System.Windows.Forms.DataGridView
    Friend WithEvents txt_titulo_hp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_equipo As System.Windows.Forms.TextBox
    Friend WithEvents chk_mantenimiento_equipo As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_motivo As System.Windows.Forms.ComboBox
    Friend WithEvents gb_trabajaos_mantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_menos As System.Windows.Forms.Button
    Friend WithEvents btn_mas As System.Windows.Forms.Button
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_lista_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
End Class
