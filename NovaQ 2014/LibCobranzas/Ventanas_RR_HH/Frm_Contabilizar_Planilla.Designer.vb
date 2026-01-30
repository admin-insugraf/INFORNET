<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Contabilizar_Planilla
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Contabilizar_Planilla))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_subdiario = New System.Windows.Forms.ComboBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.mtb_tc = New System.Windows.Forms.TextBox()
        Me.dtp_fec_vou = New System.Windows.Forms.DateTimePicker()
        Me.txt_glosa = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tot_haber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tot_debe = New System.Windows.Forms.TextBox()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ANEXO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_item_destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_ANEXO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_descripcion_planilla = New System.Windows.Forms.TextBox()
        Me.txt_numero_planilla = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Procesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Generar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmb_subdiario)
        Me.GroupBox2.Controls.Add(Me.label16)
        Me.GroupBox2.Controls.Add(Me.mtb_tc)
        Me.GroupBox2.Controls.Add(Me.dtp_fec_vou)
        Me.GroupBox2.Controls.Add(Me.txt_glosa)
        Me.GroupBox2.Controls.Add(Me.label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 84)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Contabilización"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Sub Diario"
        '
        'cmb_subdiario
        '
        Me.cmb_subdiario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_subdiario.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_subdiario.FormattingEnabled = True
        Me.cmb_subdiario.Location = New System.Drawing.Point(480, 18)
        Me.cmb_subdiario.Name = "cmb_subdiario"
        Me.cmb_subdiario.Size = New System.Drawing.Size(158, 23)
        Me.cmb_subdiario.TabIndex = 12
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(245, 25)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(27, 13)
        Me.label16.TabIndex = 11
        Me.label16.Text = "T.C."
        '
        'mtb_tc
        '
        Me.mtb_tc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtb_tc.Location = New System.Drawing.Point(278, 22)
        Me.mtb_tc.Name = "mtb_tc"
        Me.mtb_tc.ReadOnly = True
        Me.mtb_tc.Size = New System.Drawing.Size(100, 20)
        Me.mtb_tc.TabIndex = 10
        '
        'dtp_fec_vou
        '
        Me.dtp_fec_vou.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_vou.Location = New System.Drawing.Point(127, 22)
        Me.dtp_fec_vou.Name = "dtp_fec_vou"
        Me.dtp_fec_vou.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fec_vou.TabIndex = 8
        '
        'txt_glosa
        '
        Me.txt_glosa.Location = New System.Drawing.Point(127, 51)
        Me.txt_glosa.MaxLength = 200
        Me.txt_glosa.Name = "txt_glosa"
        Me.txt_glosa.Size = New System.Drawing.Size(511, 20)
        Me.txt_glosa.TabIndex = 9
        Me.txt_glosa.Text = " "
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(13, 55)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(108, 13)
        Me.label5.TabIndex = 6
        Me.label5.Text = "Glosa del Movimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Voucher"
        '
        'txt_tot_haber
        '
        Me.txt_tot_haber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_tot_haber.Location = New System.Drawing.Point(552, 419)
        Me.txt_tot_haber.Name = "txt_tot_haber"
        Me.txt_tot_haber.ReadOnly = True
        Me.txt_tot_haber.Size = New System.Drawing.Size(100, 20)
        Me.txt_tot_haber.TabIndex = 22
        Me.txt_tot_haber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(389, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Totales"
        '
        'txt_tot_debe
        '
        Me.txt_tot_debe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_tot_debe.Location = New System.Drawing.Point(447, 419)
        Me.txt_tot_debe.Name = "txt_tot_debe"
        Me.txt_tot_debe.ReadOnly = True
        Me.txt_tot_debe.Size = New System.Drawing.Size(100, 20)
        Me.txt_tot_debe.TabIndex = 20
        Me.txt_tot_debe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.AllowUserToResizeColumns = False
        Me.dgv_vista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_vista.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_vista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_vista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_item, Me.col_num, Me.col_des, Me.ANEXO, Me.col_debe, Me.col_haber, Me.col_item_destino, Me.col_porcentaje, Me.TIPO_ANEXO})
        Me.dgv_vista.Location = New System.Drawing.Point(12, 187)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_vista.Size = New System.Drawing.Size(658, 226)
        Me.dgv_vista.TabIndex = 19
        '
        'col_item
        '
        Me.col_item.FillWeight = 106.0156!
        Me.col_item.HeaderText = "Item"
        Me.col_item.Name = "col_item"
        Me.col_item.ReadOnly = True
        Me.col_item.Width = 109
        '
        'col_num
        '
        Me.col_num.FillWeight = 113.6335!
        Me.col_num.HeaderText = "Cuenta Contable"
        Me.col_num.Name = "col_num"
        Me.col_num.ReadOnly = True
        Me.col_num.Width = 116
        '
        'col_des
        '
        Me.col_des.FillWeight = 201.9403!
        Me.col_des.HeaderText = "Descripción  de Cuenta"
        Me.col_des.Name = "col_des"
        Me.col_des.ReadOnly = True
        Me.col_des.Width = 207
        '
        'ANEXO
        '
        Me.ANEXO.FillWeight = 152.2843!
        Me.ANEXO.HeaderText = "Anexo"
        Me.ANEXO.Name = "ANEXO"
        Me.ANEXO.ReadOnly = True
        Me.ANEXO.Width = 156
        '
        'col_debe
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.col_debe.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_debe.FillWeight = 13.06323!
        Me.col_debe.HeaderText = "Debe"
        Me.col_debe.Name = "col_debe"
        Me.col_debe.ReadOnly = True
        Me.col_debe.Width = 14
        '
        'col_haber
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col_haber.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_haber.FillWeight = 13.06323!
        Me.col_haber.HeaderText = "Haber"
        Me.col_haber.Name = "col_haber"
        Me.col_haber.ReadOnly = True
        Me.col_haber.Width = 13
        '
        'col_item_destino
        '
        Me.col_item_destino.HeaderText = "Item Destino"
        Me.col_item_destino.Name = "col_item_destino"
        Me.col_item_destino.ReadOnly = True
        Me.col_item_destino.Visible = False
        '
        'col_porcentaje
        '
        Me.col_porcentaje.HeaderText = "Porcentaje"
        Me.col_porcentaje.Name = "col_porcentaje"
        Me.col_porcentaje.ReadOnly = True
        Me.col_porcentaje.Visible = False
        '
        'TIPO_ANEXO
        '
        Me.TIPO_ANEXO.HeaderText = "TIPO_ANEXO"
        Me.TIPO_ANEXO.Name = "TIPO_ANEXO"
        Me.TIPO_ANEXO.ReadOnly = True
        Me.TIPO_ANEXO.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_descripcion_planilla)
        Me.GroupBox1.Controls.Add(Me.txt_numero_planilla)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 50)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periodo de Planilla"
        '
        'txt_descripcion_planilla
        '
        Me.txt_descripcion_planilla.BackColor = System.Drawing.Color.White
        Me.txt_descripcion_planilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcion_planilla.Location = New System.Drawing.Point(181, 16)
        Me.txt_descripcion_planilla.Name = "txt_descripcion_planilla"
        Me.txt_descripcion_planilla.ReadOnly = True
        Me.txt_descripcion_planilla.Size = New System.Drawing.Size(333, 20)
        Me.txt_descripcion_planilla.TabIndex = 14
        '
        'txt_numero_planilla
        '
        Me.txt_numero_planilla.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_numero_planilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_planilla.Location = New System.Drawing.Point(75, 16)
        Me.txt_numero_planilla.Name = "txt_numero_planilla"
        Me.txt_numero_planilla.ReadOnly = True
        Me.txt_numero_planilla.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero_planilla.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "N° Planilla"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.LightGray
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Procesar, Me.ToolStripSeparator1, Me.tool_Ayuda2, Me.Tool_Generar, Me.ToolStripSeparator7, Me.Tool_exportar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(682, 25)
        Me.ToolS_Mantenimiento.TabIndex = 17
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Procesar
        '
        Me.Tool_Procesar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Procesar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Procesar.Image = CType(resources.GetObject("Tool_Procesar.Image"), System.Drawing.Image)
        Me.Tool_Procesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Procesar.Name = "Tool_Procesar"
        Me.Tool_Procesar.Size = New System.Drawing.Size(77, 22)
        Me.Tool_Procesar.Text = "&Procesar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tool_Ayuda2
        '
        Me.tool_Ayuda2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tool_Ayuda2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tool_Ayuda2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_Ayuda2.Name = "tool_Ayuda2"
        Me.tool_Ayuda2.Size = New System.Drawing.Size(23, 22)
        Me.tool_Ayuda2.Text = "Acerca de las Cuentas Tipo"
        '
        'Tool_Generar
        '
        Me.Tool_Generar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Generar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Generar.Image = CType(resources.GetObject("Tool_Generar.Image"), System.Drawing.Image)
        Me.Tool_Generar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Generar.Name = "Tool_Generar"
        Me.Tool_Generar.Size = New System.Drawing.Size(172, 22)
        Me.Tool_Generar.Text = "&Generar Asiento Contable"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_exportar
        '
        Me.Tool_exportar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_exportar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_exportar.Image = CType(resources.GetObject("Tool_exportar.Image"), System.Drawing.Image)
        Me.Tool_exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_exportar.Name = "Tool_exportar"
        Me.Tool_exportar.Size = New System.Drawing.Size(76, 22)
        Me.Tool_exportar.Text = "&Exportar"
        Me.Tool_exportar.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Salir.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Salir.Image = CType(resources.GetObject("Tool_Salir.Image"), System.Drawing.Image)
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(52, 22)
        Me.Tool_Salir.Text = "&Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Frm_Contabilizar_Planilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(682, 443)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_tot_haber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_tot_debe)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Contabilizar_Planilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizar Planilla"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_subdiario As System.Windows.Forms.ComboBox
    Private WithEvents label16 As System.Windows.Forms.Label
    Friend WithEvents mtb_tc As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fec_vou As System.Windows.Forms.DateTimePicker
    Private WithEvents txt_glosa As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_tot_haber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_tot_debe As System.Windows.Forms.TextBox
    Friend WithEvents dgv_vista As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Procesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Generar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_numero_planilla As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion_planilla As System.Windows.Forms.TextBox
    Friend WithEvents col_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ANEXO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_item_destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_ANEXO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
