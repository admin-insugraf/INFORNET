<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_LT_NotaCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_LT_NotaCredito))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_tdr = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_comen = New System.Windows.Forms.TextBox()
        Me.mtb_tc = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_vededor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_fecha_emi = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_forma_pago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_ndr = New System.Windows.Forms.TextBox()
        Me.txt_sdr = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_cod_cli = New System.Windows.Forms.TextBox()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.txt_des_ane = New System.Windows.Forms.TextBox()
        Me.cmb_ptovta = New System.Windows.Forms.ComboBox()
        Me.cmb_sd = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_nd = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_igv = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_lote = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.col_uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_can = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod_alm = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_tdr)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_comen)
        Me.GroupBox1.Controls.Add(Me.mtb_tc)
        Me.GroupBox1.Controls.Add(Me.cmb_moneda)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_vededor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_emi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_forma_pago)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_ndr)
        Me.GroupBox1.Controls.Add(Me.txt_sdr)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txt_cod_cli)
        Me.GroupBox1.Controls.Add(Me.txt_dir)
        Me.GroupBox1.Controls.Add(Me.txt_des_ane)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmb_tdr
        '
        Me.cmb_tdr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tdr.DropDownWidth = 300
        Me.cmb_tdr.FormattingEnabled = True
        Me.cmb_tdr.IntegralHeight = False
        Me.cmb_tdr.Location = New System.Drawing.Point(81, 60)
        Me.cmb_tdr.Name = "cmb_tdr"
        Me.cmb_tdr.Size = New System.Drawing.Size(139, 21)
        Me.cmb_tdr.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(641, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Forma Pago"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Comentarios"
        '
        'txt_comen
        '
        Me.txt_comen.Location = New System.Drawing.Point(81, 85)
        Me.txt_comen.Name = "txt_comen"
        Me.txt_comen.Size = New System.Drawing.Size(417, 20)
        Me.txt_comen.TabIndex = 9
        '
        'mtb_tc
        '
        Me.mtb_tc.Location = New System.Drawing.Point(692, 41)
        Me.mtb_tc.Mask = "9.999"
        Me.mtb_tc.Name = "mtb_tc"
        Me.mtb_tc.Size = New System.Drawing.Size(68, 20)
        Me.mtb_tc.TabIndex = 11
        Me.mtb_tc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mtb_tc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(709, 66)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(51, 21)
        Me.cmb_moneda.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(381, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Vendedor"
        '
        'txt_vededor
        '
        Me.txt_vededor.Location = New System.Drawing.Point(446, 61)
        Me.txt_vededor.Name = "txt_vededor"
        Me.txt_vededor.Size = New System.Drawing.Size(51, 20)
        Me.txt_vededor.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(659, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Moneda"
        '
        'dtp_fecha_emi
        '
        Me.dtp_fecha_emi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_emi.Location = New System.Drawing.Point(654, 15)
        Me.dtp_fecha_emi.Name = "dtp_fecha_emi"
        Me.dtp_fecha_emi.Size = New System.Drawing.Size(106, 20)
        Me.dtp_fecha_emi.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(584, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Fec. Emi."
        '
        'txt_forma_pago
        '
        Me.txt_forma_pago.Location = New System.Drawing.Point(709, 94)
        Me.txt_forma_pago.Name = "txt_forma_pago"
        Me.txt_forma_pago.Size = New System.Drawing.Size(51, 20)
        Me.txt_forma_pago.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(579, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Tipo Cambio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Doc. Refer"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Direccion"
        '
        'txt_ndr
        '
        Me.txt_ndr.Location = New System.Drawing.Point(262, 61)
        Me.txt_ndr.Name = "txt_ndr"
        Me.txt_ndr.Size = New System.Drawing.Size(101, 20)
        Me.txt_ndr.TabIndex = 7
        '
        'txt_sdr
        '
        Me.txt_sdr.Location = New System.Drawing.Point(222, 61)
        Me.txt_sdr.Name = "txt_sdr"
        Me.txt_sdr.Size = New System.Drawing.Size(40, 20)
        Me.txt_sdr.TabIndex = 44
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "Cliente"
        '
        'txt_cod_cli
        '
        Me.txt_cod_cli.Location = New System.Drawing.Point(63, 16)
        Me.txt_cod_cli.Name = "txt_cod_cli"
        Me.txt_cod_cli.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_cli.TabIndex = 3
        '
        'txt_dir
        '
        Me.txt_dir.Location = New System.Drawing.Point(63, 37)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.ReadOnly = True
        Me.txt_dir.Size = New System.Drawing.Size(434, 20)
        Me.txt_dir.TabIndex = 5
        '
        'txt_des_ane
        '
        Me.txt_des_ane.Location = New System.Drawing.Point(164, 16)
        Me.txt_des_ane.Name = "txt_des_ane"
        Me.txt_des_ane.ReadOnly = True
        Me.txt_des_ane.Size = New System.Drawing.Size(334, 20)
        Me.txt_des_ane.TabIndex = 4
        '
        'cmb_ptovta
        '
        Me.cmb_ptovta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ptovta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ptovta.FormattingEnabled = True
        Me.cmb_ptovta.Location = New System.Drawing.Point(137, 30)
        Me.cmb_ptovta.Name = "cmb_ptovta"
        Me.cmb_ptovta.Size = New System.Drawing.Size(204, 24)
        Me.cmb_ptovta.TabIndex = 0
        '
        'cmb_sd
        '
        Me.cmb_sd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_sd.FormattingEnabled = True
        Me.cmb_sd.Location = New System.Drawing.Point(594, 28)
        Me.cmb_sd.Name = "cmb_sd"
        Me.cmb_sd.Size = New System.Drawing.Size(67, 26)
        Me.cmb_sd.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(460, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(127, 18)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Nota de Credito"
        '
        'txt_nd
        '
        Me.txt_nd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nd.Location = New System.Drawing.Point(663, 28)
        Me.txt_nd.Name = "txt_nd"
        Me.txt_nd.ReadOnly = True
        Me.txt_nd.Size = New System.Drawing.Size(114, 26)
        Me.txt_nd.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(787, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = CType(resources.GetObject("Tool_Salir.Image"), System.Drawing.Image)
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = Global.LibCobranzas.My.Resources.Resources.checkmark_26
        Me.btn_grabar.Location = New System.Drawing.Point(719, 182)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(59, 49)
        Me.btn_grabar.TabIndex = 2
        Me.btn_grabar.Text = "Aceptar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(670, 268)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(108, 20)
        Me.txt_subtotal.TabIndex = 3
        Me.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_igv
        '
        Me.txt_igv.Location = New System.Drawing.Point(670, 290)
        Me.txt_igv.Name = "txt_igv"
        Me.txt_igv.ReadOnly = True
        Me.txt_igv.Size = New System.Drawing.Size(108, 20)
        Me.txt_igv.TabIndex = 4
        Me.txt_igv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(670, 312)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(108, 20)
        Me.txt_total.TabIndex = 5
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(608, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "SubTotal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(626, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "I.G.V."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(630, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Total"
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AllowUserToDeleteRows = False
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_item, Me.col_cod, Me.col_des, Me.col_lote, Me.col_uni, Me.col_can, Me.col_pre, Me.col_tot})
        Me.dgv_detalle.Location = New System.Drawing.Point(12, 182)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.Size = New System.Drawing.Size(590, 150)
        Me.dgv_detalle.TabIndex = 55
        '
        'col_item
        '
        Me.col_item.HeaderText = "Item"
        Me.col_item.Name = "col_item"
        Me.col_item.Width = 30
        '
        'col_cod
        '
        Me.col_cod.HeaderText = "Codigo"
        Me.col_cod.Name = "col_cod"
        Me.col_cod.ReadOnly = True
        Me.col_cod.Width = 70
        '
        'col_des
        '
        Me.col_des.HeaderText = "Descripcion"
        Me.col_des.Name = "col_des"
        Me.col_des.Width = 200
        '
        'col_lote
        '
        Me.col_lote.HeaderText = "Lote"
        Me.col_lote.Name = "col_lote"
        Me.col_lote.Width = 50
        '
        'col_uni
        '
        Me.col_uni.HeaderText = "Unidad"
        Me.col_uni.Name = "col_uni"
        Me.col_uni.ReadOnly = True
        Me.col_uni.Width = 60
        '
        'col_can
        '
        Me.col_can.HeaderText = "Cantidad"
        Me.col_can.Name = "col_can"
        Me.col_can.Width = 50
        '
        'col_pre
        '
        Me.col_pre.HeaderText = "Precio"
        Me.col_pre.Name = "col_pre"
        Me.col_pre.Width = 50
        '
        'col_tot
        '
        Me.col_tot.HeaderText = "Total"
        Me.col_tot.Name = "col_tot"
        Me.col_tot.ReadOnly = True
        Me.col_tot.Width = 60
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(608, 182)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(35, 29)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "+"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Location = New System.Drawing.Point(608, 217)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(35, 29)
        Me.btn_quitar.TabIndex = 1
        Me.btn_quitar.Text = "-"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Punto de Venta"
        '
        'txt_cod_alm
        '
        Me.txt_cod_alm.Location = New System.Drawing.Point(347, 34)
        Me.txt_cod_alm.Name = "txt_cod_alm"
        Me.txt_cod_alm.Size = New System.Drawing.Size(47, 20)
        Me.txt_cod_alm.TabIndex = 57
        '
        'frm_CX_LT_NotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(787, 342)
        Me.Controls.Add(Me.txt_cod_alm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_sd)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_detalle)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.txt_igv)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_nd)
        Me.Controls.Add(Me.cmb_ptovta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_CX_LT_NotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota de Credito"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_ptovta As System.Windows.Forms.ComboBox
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents txt_cod_cli As System.Windows.Forms.TextBox
    Private WithEvents txt_des_ane As System.Windows.Forms.TextBox
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents txt_nd As System.Windows.Forms.TextBox
    Friend WithEvents mtb_tc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txt_vededor As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_emi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents txt_forma_pago As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txt_ndr As System.Windows.Forms.TextBox
    Private WithEvents txt_sdr As System.Windows.Forms.TextBox
    Private WithEvents txt_dir As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txt_comen As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Private WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Private WithEvents txt_igv As System.Windows.Forms.TextBox
    Private WithEvents txt_total As System.Windows.Forms.TextBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_tdr As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_sd As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents col_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_lote As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents col_uni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_can As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_pre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_cod_alm As System.Windows.Forms.TextBox
End Class
