<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_LT_Contabilizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_LT_Contabilizar))
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtb_fec_proc = New System.Windows.Forms.MaskedTextBox()
        Me.txtmes = New System.Windows.Forms.TextBox()
        Me.nud_anho = New System.Windows.Forms.NumericUpDown()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_item_destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_tot_debe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tot_haber = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.mtb_tc = New System.Windows.Forms.TextBox()
        Me.dtp_fec_vou = New System.Windows.Forms.DateTimePicker()
        Me.txt_glosa = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_subdiario = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nud_anho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.LightGray
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Procesar, Me.ToolStripSeparator1, Me.tool_Ayuda2, Me.Tool_Generar, Me.ToolStripSeparator7, Me.Tool_exportar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(682, 25)
        Me.ToolS_Mantenimiento.TabIndex = 10
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Procesar
        '
        Me.Tool_Procesar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Procesar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Procesar.Image = Global.LibActivo.My.Resources.Resources._16__Configure_
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
        Me.Tool_Generar.Image = Global.LibActivo.My.Resources.Resources._16__Ok_
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
        Me.Tool_exportar.Image = Global.LibActivo.My.Resources.Resources._16__Doc_excel_
        Me.Tool_exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_exportar.Name = "Tool_exportar"
        Me.Tool_exportar.Size = New System.Drawing.Size(76, 22)
        Me.Tool_exportar.Text = "&Exportar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Salir.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Salir.Image = Global.LibActivo.My.Resources.Resources._16__Exit_
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.mtb_fec_proc)
        Me.GroupBox1.Controls.Add(Me.txtmes)
        Me.GroupBox1.Controls.Add(Me.nud_anho)
        Me.GroupBox1.Controls.Add(Me.cmb_mes)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 50)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periodo de Depreciación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fecha"
        '
        'mtb_fec_proc
        '
        Me.mtb_fec_proc.Location = New System.Drawing.Point(127, 17)
        Me.mtb_fec_proc.Mask = "00/00/0000"
        Me.mtb_fec_proc.Name = "mtb_fec_proc"
        Me.mtb_fec_proc.Size = New System.Drawing.Size(91, 20)
        Me.mtb_fec_proc.TabIndex = 13
        Me.mtb_fec_proc.ValidatingType = GetType(Date)
        '
        'txtmes
        '
        Me.txtmes.Location = New System.Drawing.Point(278, 19)
        Me.txtmes.MaxLength = 2
        Me.txtmes.Name = "txtmes"
        Me.txtmes.Size = New System.Drawing.Size(100, 20)
        Me.txtmes.TabIndex = 0
        Me.txtmes.Visible = False
        '
        'nud_anho
        '
        Me.nud_anho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_anho.Location = New System.Drawing.Point(416, 17)
        Me.nud_anho.Maximum = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.nud_anho.Minimum = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.nud_anho.Name = "nud_anho"
        Me.nud_anho.Size = New System.Drawing.Size(73, 23)
        Me.nud_anho.TabIndex = 3
        Me.nud_anho.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        Me.nud_anho.Visible = False
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(495, 16)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(158, 24)
        Me.cmb_mes.TabIndex = 2
        Me.cmb_mes.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mes"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año"
        Me.Label1.Visible = False
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.AllowUserToResizeColumns = False
        Me.dgv_vista.AllowUserToResizeRows = False
        Me.dgv_vista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_vista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_vista.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_vista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_vista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_item, Me.col_num, Me.col_des, Me.col_debe, Me.col_haber, Me.col_item_destino, Me.col_porcentaje})
        Me.dgv_vista.Location = New System.Drawing.Point(12, 183)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_vista.Size = New System.Drawing.Size(658, 226)
        Me.dgv_vista.TabIndex = 12
        '
        'col_item
        '
        Me.col_item.FillWeight = 118.3961!
        Me.col_item.HeaderText = "Item"
        Me.col_item.Name = "col_item"
        Me.col_item.ReadOnly = True
        '
        'col_num
        '
        Me.col_num.FillWeight = 126.9036!
        Me.col_num.HeaderText = "Cuenta Contable"
        Me.col_num.Name = "col_num"
        Me.col_num.ReadOnly = True
        '
        'col_des
        '
        Me.col_des.FillWeight = 225.5229!
        Me.col_des.HeaderText = "Descripción  de Cuenta"
        Me.col_des.Name = "col_des"
        Me.col_des.ReadOnly = True
        '
        'col_debe
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.col_debe.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_debe.FillWeight = 14.58875!
        Me.col_debe.HeaderText = "Debe"
        Me.col_debe.Name = "col_debe"
        Me.col_debe.ReadOnly = True
        '
        'col_haber
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col_haber.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_haber.FillWeight = 14.58875!
        Me.col_haber.HeaderText = "Haber"
        Me.col_haber.Name = "col_haber"
        Me.col_haber.ReadOnly = True
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
        'txt_tot_debe
        '
        Me.txt_tot_debe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_tot_debe.Location = New System.Drawing.Point(447, 415)
        Me.txt_tot_debe.Name = "txt_tot_debe"
        Me.txt_tot_debe.ReadOnly = True
        Me.txt_tot_debe.Size = New System.Drawing.Size(100, 20)
        Me.txt_tot_debe.TabIndex = 13
        Me.txt_tot_debe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(389, 418)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Totales"
        '
        'txt_tot_haber
        '
        Me.txt_tot_haber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_tot_haber.Location = New System.Drawing.Point(552, 415)
        Me.txt_tot_haber.Name = "txt_tot_haber"
        Me.txt_tot_haber.ReadOnly = True
        Me.txt_tot_haber.Size = New System.Drawing.Size(100, 20)
        Me.txt_tot_haber.TabIndex = 15
        Me.txt_tot_haber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 84)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Contabilización"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Sub Diario"
        '
        'frm_AF_LT_Contabilizar
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
        Me.Name = "frm_AF_LT_Contabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizar Depreciacion"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nud_anho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Procesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nud_anho As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_vista As System.Windows.Forms.DataGridView
    Friend WithEvents Tool_Generar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_tot_debe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_tot_haber As System.Windows.Forms.TextBox
    Friend WithEvents txtmes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fec_vou As System.Windows.Forms.DateTimePicker
    Private WithEvents txt_glosa As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mtb_fec_proc As System.Windows.Forms.MaskedTextBox
    Private WithEvents label16 As System.Windows.Forms.Label
    Friend WithEvents mtb_tc As System.Windows.Forms.TextBox
    Friend WithEvents col_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_item_destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_subdiario As System.Windows.Forms.ComboBox
End Class
