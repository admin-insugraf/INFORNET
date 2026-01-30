<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Resumen_Boletas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Resumen_Boletas))
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.btn_reenviar_doc_sunat = New System.Windows.Forms.Button()
        Me.btn_verifica_estado_manual = New System.Windows.Forms.Button()
        Me.btn_buscar_registros = New System.Windows.Forms.Button()
        Me.dgvDocumentosFactura = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdb_anulados = New System.Windows.Forms.RadioButton()
        Me.rdb_emitidos = New System.Windows.Forms.RadioButton()
        Me.btn_retornar = New System.Windows.Forms.Button()
        Me.txt_nombre_boletas = New System.Windows.Forms.TextBox()
        Me.txt_numero_resumen = New System.Windows.Forms.TextBox()
        Me.btn_grabar_datos = New System.Windows.Forms.Button()
        Me.btn_genera_detalle = New System.Windows.Forms.Button()
        Me.dgv_detalle_resumen = New System.Windows.Forms.DataGridView()
        Me.dtp_fecha_resumen = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRangofechas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_detalle_resumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrincipal.Controls.Add(Me.btn_reenviar_doc_sunat)
        Me.pnlPrincipal.Controls.Add(Me.btn_verifica_estado_manual)
        Me.pnlPrincipal.Controls.Add(Me.btn_buscar_registros)
        Me.pnlPrincipal.Controls.Add(Me.dgvDocumentosFactura)
        Me.pnlPrincipal.Controls.Add(Me.Label1)
        Me.pnlPrincipal.Controls.Add(Me.lblCantidad)
        Me.pnlPrincipal.Controls.Add(Me.gbRangofechas)
        Me.pnlPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(930, 459)
        Me.pnlPrincipal.TabIndex = 182
        '
        'btn_reenviar_doc_sunat
        '
        Me.btn_reenviar_doc_sunat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reenviar_doc_sunat.BackColor = System.Drawing.Color.LightGray
        Me.btn_reenviar_doc_sunat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reenviar_doc_sunat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reenviar_doc_sunat.Image = CType(resources.GetObject("btn_reenviar_doc_sunat.Image"), System.Drawing.Image)
        Me.btn_reenviar_doc_sunat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reenviar_doc_sunat.Location = New System.Drawing.Point(218, 408)
        Me.btn_reenviar_doc_sunat.Name = "btn_reenviar_doc_sunat"
        Me.btn_reenviar_doc_sunat.Size = New System.Drawing.Size(204, 43)
        Me.btn_reenviar_doc_sunat.TabIndex = 189
        Me.btn_reenviar_doc_sunat.Text = "ENVIAR RESUMEN MANUAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Enviar resumen a SUNAT)"
        Me.btn_reenviar_doc_sunat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reenviar_doc_sunat.UseVisualStyleBackColor = False
        Me.btn_reenviar_doc_sunat.Visible = False
        '
        'btn_verifica_estado_manual
        '
        Me.btn_verifica_estado_manual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_verifica_estado_manual.BackColor = System.Drawing.Color.LightGray
        Me.btn_verifica_estado_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verifica_estado_manual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verifica_estado_manual.Image = CType(resources.GetObject("btn_verifica_estado_manual.Image"), System.Drawing.Image)
        Me.btn_verifica_estado_manual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_verifica_estado_manual.Location = New System.Drawing.Point(8, 408)
        Me.btn_verifica_estado_manual.Name = "btn_verifica_estado_manual"
        Me.btn_verifica_estado_manual.Size = New System.Drawing.Size(204, 43)
        Me.btn_verifica_estado_manual.TabIndex = 188
        Me.btn_verifica_estado_manual.Text = "GENERAR RESUMEN BOLETAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Crea resumen)"
        Me.btn_verifica_estado_manual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_verifica_estado_manual.UseVisualStyleBackColor = False
        '
        'btn_buscar_registros
        '
        Me.btn_buscar_registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar_registros.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_buscar_registros.ForeColor = System.Drawing.Color.Navy
        Me.btn_buscar_registros.Location = New System.Drawing.Point(371, 50)
        Me.btn_buscar_registros.Name = "btn_buscar_registros"
        Me.btn_buscar_registros.Size = New System.Drawing.Size(113, 26)
        Me.btn_buscar_registros.TabIndex = 125
        Me.btn_buscar_registros.Text = "Buscar Registros"
        Me.btn_buscar_registros.UseVisualStyleBackColor = True
        '
        'dgvDocumentosFactura
        '
        Me.dgvDocumentosFactura.AllowUserToAddRows = False
        Me.dgvDocumentosFactura.AllowUserToDeleteRows = False
        Me.dgvDocumentosFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentosFactura.EnableHeadersVisualStyles = False
        Me.dgvDocumentosFactura.Location = New System.Drawing.Point(6, 87)
        Me.dgvDocumentosFactura.MultiSelect = False
        Me.dgvDocumentosFactura.Name = "dgvDocumentosFactura"
        Me.dgvDocumentosFactura.ReadOnly = True
        Me.dgvDocumentosFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvDocumentosFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDocumentosFactura.Size = New System.Drawing.Size(916, 295)
        Me.dgvDocumentosFactura.TabIndex = 124
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 19)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "RESUMEN DE BOLETAS DE VENTA"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Maroon
        Me.lblCantidad.Location = New System.Drawing.Point(11, 385)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(12, 16)
        Me.lblCantidad.TabIndex = 118
        Me.lblCantidad.Text = "."
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(6, 36)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 121
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(185, 21)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(258, 15)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(7, 21)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 13)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Fecha inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(85, 15)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_retornar)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_boletas)
        Me.GroupBox1.Controls.Add(Me.txt_numero_resumen)
        Me.GroupBox1.Controls.Add(Me.btn_grabar_datos)
        Me.GroupBox1.Controls.Add(Me.btn_genera_detalle)
        Me.GroupBox1.Controls.Add(Me.dgv_detalle_resumen)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_resumen)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 455)
        Me.GroupBox1.TabIndex = 183
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdb_anulados)
        Me.GroupBox2.Controls.Add(Me.rdb_emitidos)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(565, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 52)
        Me.GroupBox2.TabIndex = 140
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documentos con estado"
        '
        'rdb_anulados
        '
        Me.rdb_anulados.AutoSize = True
        Me.rdb_anulados.ForeColor = System.Drawing.Color.Navy
        Me.rdb_anulados.Location = New System.Drawing.Point(99, 22)
        Me.rdb_anulados.Name = "rdb_anulados"
        Me.rdb_anulados.Size = New System.Drawing.Size(64, 17)
        Me.rdb_anulados.TabIndex = 1
        Me.rdb_anulados.Text = "Anulado"
        Me.rdb_anulados.UseVisualStyleBackColor = True
        '
        'rdb_emitidos
        '
        Me.rdb_emitidos.AutoSize = True
        Me.rdb_emitidos.Checked = True
        Me.rdb_emitidos.Location = New System.Drawing.Point(18, 22)
        Me.rdb_emitidos.Name = "rdb_emitidos"
        Me.rdb_emitidos.Size = New System.Drawing.Size(59, 17)
        Me.rdb_emitidos.TabIndex = 0
        Me.rdb_emitidos.TabStop = True
        Me.rdb_emitidos.Text = "Emitido"
        Me.rdb_emitidos.UseVisualStyleBackColor = True
        '
        'btn_retornar
        '
        Me.btn_retornar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retornar.Image = CType(resources.GetObject("btn_retornar.Image"), System.Drawing.Image)
        Me.btn_retornar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_retornar.Location = New System.Drawing.Point(812, 63)
        Me.btn_retornar.Name = "btn_retornar"
        Me.btn_retornar.Size = New System.Drawing.Size(97, 23)
        Me.btn_retornar.TabIndex = 138
        Me.btn_retornar.Text = "Retornar"
        Me.btn_retornar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_retornar.UseVisualStyleBackColor = True
        '
        'txt_nombre_boletas
        '
        Me.txt_nombre_boletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre_boletas.Location = New System.Drawing.Point(386, 27)
        Me.txt_nombre_boletas.Name = "txt_nombre_boletas"
        Me.txt_nombre_boletas.ReadOnly = True
        Me.txt_nombre_boletas.Size = New System.Drawing.Size(137, 20)
        Me.txt_nombre_boletas.TabIndex = 137
        Me.txt_nombre_boletas.Visible = False
        '
        'txt_numero_resumen
        '
        Me.txt_numero_resumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_resumen.Location = New System.Drawing.Point(243, 27)
        Me.txt_numero_resumen.Name = "txt_numero_resumen"
        Me.txt_numero_resumen.ReadOnly = True
        Me.txt_numero_resumen.Size = New System.Drawing.Size(137, 20)
        Me.txt_numero_resumen.TabIndex = 136
        '
        'btn_grabar_datos
        '
        Me.btn_grabar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar_datos.Location = New System.Drawing.Point(274, 58)
        Me.btn_grabar_datos.Name = "btn_grabar_datos"
        Me.btn_grabar_datos.Size = New System.Drawing.Size(158, 23)
        Me.btn_grabar_datos.TabIndex = 135
        Me.btn_grabar_datos.Text = "2.- Grabar datos de Resumen"
        Me.btn_grabar_datos.UseVisualStyleBackColor = True
        '
        'btn_genera_detalle
        '
        Me.btn_genera_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_genera_detalle.Location = New System.Drawing.Point(162, 58)
        Me.btn_genera_detalle.Name = "btn_genera_detalle"
        Me.btn_genera_detalle.Size = New System.Drawing.Size(106, 23)
        Me.btn_genera_detalle.TabIndex = 134
        Me.btn_genera_detalle.Text = "1.- Generar Detalle"
        Me.btn_genera_detalle.UseVisualStyleBackColor = True
        '
        'dgv_detalle_resumen
        '
        Me.dgv_detalle_resumen.AllowUserToAddRows = False
        Me.dgv_detalle_resumen.AllowUserToDeleteRows = False
        Me.dgv_detalle_resumen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalle_resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_resumen.EnableHeadersVisualStyles = False
        Me.dgv_detalle_resumen.Location = New System.Drawing.Point(17, 88)
        Me.dgv_detalle_resumen.MultiSelect = False
        Me.dgv_detalle_resumen.Name = "dgv_detalle_resumen"
        Me.dgv_detalle_resumen.ReadOnly = True
        Me.dgv_detalle_resumen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_detalle_resumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle_resumen.Size = New System.Drawing.Size(892, 351)
        Me.dgv_detalle_resumen.TabIndex = 125
        '
        'dtp_fecha_resumen
        '
        Me.dtp_fecha_resumen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_resumen.Location = New System.Drawing.Point(60, 59)
        Me.dtp_fecha_resumen.Name = "dtp_fecha_resumen"
        Me.dtp_fecha_resumen.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_resumen.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(14, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DETALLE DE RESUMEN DE BOLETAS"
        '
        'Frm_Resumen_Boletas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(952, 481)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Resumen_Boletas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENVIO DE RESUMEN DE BOLETAS"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.dgvDocumentosFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_detalle_resumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents dgvDocumentosFactura As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_buscar_registros As System.Windows.Forms.Button
    Friend WithEvents btn_verifica_estado_manual As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_resumen As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_detalle_resumen As System.Windows.Forms.DataGridView
    Friend WithEvents btn_grabar_datos As System.Windows.Forms.Button
    Friend WithEvents btn_genera_detalle As System.Windows.Forms.Button
    Friend WithEvents txt_numero_resumen As System.Windows.Forms.TextBox
    Friend WithEvents btn_reenviar_doc_sunat As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_boletas As System.Windows.Forms.TextBox
    Friend WithEvents btn_retornar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_anulados As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_emitidos As System.Windows.Forms.RadioButton
End Class
