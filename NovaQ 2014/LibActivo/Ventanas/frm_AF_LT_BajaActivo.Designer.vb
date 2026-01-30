<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_LT_BajaActivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_LT_BajaActivo))
        Me.txt_des_activo = New System.Windows.Forms.TextBox()
        Me.txt_idactivo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tc_baja = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_baja = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtobs_det = New System.Windows.Forms.TextBox()
        Me.mtb_idoc = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fdoc = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_tdoc = New System.Windows.Forms.ComboBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.txt_ndoc = New System.Windows.Forms.TextBox()
        Me.txt_sdoc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_motivo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mtb_fec_baja = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.tc_baja.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_baja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_des_activo
        '
        Me.txt_des_activo.Location = New System.Drawing.Point(187, 15)
        Me.txt_des_activo.Name = "txt_des_activo"
        Me.txt_des_activo.Size = New System.Drawing.Size(411, 20)
        Me.txt_des_activo.TabIndex = 19
        '
        'txt_idactivo
        '
        Me.txt_idactivo.Location = New System.Drawing.Point(99, 15)
        Me.txt_idactivo.Name = "txt_idactivo"
        Me.txt_idactivo.Size = New System.Drawing.Size(87, 20)
        Me.txt_idactivo.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(56, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Activo"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.toolStripSeparator5, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator7})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(740, 25)
        Me.ToolS_Mantenimiento.TabIndex = 20
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Nuevo.Image = Global.LibActivo.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.LibActivo.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.LibActivo.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.LibActivo.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.LibActivo.My.Resources.Resources._16__Delete_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.LibActivo.My.Resources.Resources._16__Exit_
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tc_baja
        '
        Me.tc_baja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_baja.Controls.Add(Me.TabPage1)
        Me.tc_baja.Controls.Add(Me.TabPage2)
        Me.tc_baja.Location = New System.Drawing.Point(12, 44)
        Me.tc_baja.Name = "tc_baja"
        Me.tc_baja.SelectedIndex = 0
        Me.tc_baja.Size = New System.Drawing.Size(716, 348)
        Me.tc_baja.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_baja)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(708, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Activos Bajas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_baja
        '
        Me.dgv_baja.AllowUserToAddRows = False
        Me.dgv_baja.AllowUserToDeleteRows = False
        Me.dgv_baja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_baja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_baja.Location = New System.Drawing.Point(12, 19)
        Me.dgv_baja.Name = "dgv_baja"
        Me.dgv_baja.ReadOnly = True
        Me.dgv_baja.Size = New System.Drawing.Size(678, 293)
        Me.dgv_baja.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_datos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(708, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso/Edicion de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.cmb_cliente)
        Me.gb_datos.Controls.Add(Me.Label4)
        Me.gb_datos.Controls.Add(Me.Label3)
        Me.gb_datos.Controls.Add(Me.txtobs_det)
        Me.gb_datos.Controls.Add(Me.mtb_idoc)
        Me.gb_datos.Controls.Add(Me.mtb_fdoc)
        Me.gb_datos.Controls.Add(Me.cmb_tdoc)
        Me.gb_datos.Controls.Add(Me.cmb_moneda)
        Me.gb_datos.Controls.Add(Me.txt_ndoc)
        Me.gb_datos.Controls.Add(Me.txt_sdoc)
        Me.gb_datos.Controls.Add(Me.Label19)
        Me.gb_datos.Controls.Add(Me.Label15)
        Me.gb_datos.Controls.Add(Me.Label18)
        Me.gb_datos.Controls.Add(Me.Label1)
        Me.gb_datos.Controls.Add(Me.Label2)
        Me.gb_datos.Controls.Add(Me.Label17)
        Me.gb_datos.Controls.Add(Me.cmb_motivo)
        Me.gb_datos.Controls.Add(Me.Label14)
        Me.gb_datos.Controls.Add(Me.mtb_fec_baja)
        Me.gb_datos.Controls.Add(Me.Label11)
        Me.gb_datos.Controls.Add(Me.txt_des_activo)
        Me.gb_datos.Controls.Add(Me.Label9)
        Me.gb_datos.Controls.Add(Me.txt_idactivo)
        Me.gb_datos.Location = New System.Drawing.Point(8, 8)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(683, 305)
        Me.gb_datos.TabIndex = 45
        Me.gb_datos.TabStop = False
        '
        'cmb_cliente
        '
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(99, 93)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(334, 21)
        Me.cmb_cliente.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(54, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Numero"
        '
        'txtobs_det
        '
        Me.txtobs_det.Location = New System.Drawing.Point(99, 280)
        Me.txtobs_det.Name = "txtobs_det"
        Me.txtobs_det.Size = New System.Drawing.Size(574, 20)
        Me.txtobs_det.TabIndex = 9
        '
        'mtb_idoc
        '
        Me.mtb_idoc.Location = New System.Drawing.Point(99, 224)
        Me.mtb_idoc.Name = "mtb_idoc"
        Me.mtb_idoc.Size = New System.Drawing.Size(126, 20)
        Me.mtb_idoc.TabIndex = 7
        '
        'mtb_fdoc
        '
        Me.mtb_fdoc.Location = New System.Drawing.Point(99, 198)
        Me.mtb_fdoc.Mask = "00/00/0000"
        Me.mtb_fdoc.Name = "mtb_fdoc"
        Me.mtb_fdoc.Size = New System.Drawing.Size(88, 20)
        Me.mtb_fdoc.TabIndex = 6
        Me.mtb_fdoc.ValidatingType = GetType(Date)
        '
        'cmb_tdoc
        '
        Me.cmb_tdoc.FormattingEnabled = True
        Me.cmb_tdoc.Location = New System.Drawing.Point(99, 119)
        Me.cmb_tdoc.Name = "cmb_tdoc"
        Me.cmb_tdoc.Size = New System.Drawing.Size(274, 21)
        Me.cmb_tdoc.TabIndex = 3
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(99, 250)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(104, 21)
        Me.cmb_moneda.TabIndex = 8
        '
        'txt_ndoc
        '
        Me.txt_ndoc.Location = New System.Drawing.Point(99, 172)
        Me.txt_ndoc.Name = "txt_ndoc"
        Me.txt_ndoc.Size = New System.Drawing.Size(126, 20)
        Me.txt_ndoc.TabIndex = 5
        '
        'txt_sdoc
        '
        Me.txt_sdoc.Location = New System.Drawing.Point(99, 146)
        Me.txt_sdoc.Name = "txt_sdoc"
        Me.txt_sdoc.Size = New System.Drawing.Size(88, 20)
        Me.txt_sdoc.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(47, 254)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Moneda"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(62, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Serie"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(10, 227)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Precio de Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Tip. Doc."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Fecha de Venta"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(15, 280)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Observaciones"
        '
        'cmb_motivo
        '
        Me.cmb_motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_motivo.FormattingEnabled = True
        Me.cmb_motivo.Location = New System.Drawing.Point(99, 66)
        Me.cmb_motivo.Name = "cmb_motivo"
        Me.cmb_motivo.Size = New System.Drawing.Size(334, 21)
        Me.cmb_motivo.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(54, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Motivo"
        '
        'mtb_fec_baja
        '
        Me.mtb_fec_baja.Location = New System.Drawing.Point(99, 40)
        Me.mtb_fec_baja.Mask = "00/00/0000"
        Me.mtb_fec_baja.Name = "mtb_fec_baja"
        Me.mtb_fec_baja.Size = New System.Drawing.Size(87, 20)
        Me.mtb_fec_baja.TabIndex = 1
        Me.mtb_fec_baja.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(17, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Fecha de Baja"
        '
        'frm_AF_LT_BajaActivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(740, 404)
        Me.Controls.Add(Me.tc_baja)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_LT_BajaActivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja Activo"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.tc_baja.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_baja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_des_activo As System.Windows.Forms.TextBox
    Friend WithEvents txt_idactivo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tc_baja As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtobs_det As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmb_motivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mtb_fec_baja As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mtb_idoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_fdoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_tdoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents txt_ndoc As System.Windows.Forms.TextBox
    Friend WithEvents txt_sdoc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_baja As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
