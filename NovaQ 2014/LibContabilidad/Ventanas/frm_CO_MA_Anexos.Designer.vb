<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_MA_Anexos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_MA_Anexos))
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
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.lb_tipos = New System.Windows.Forms.ListBox()
        Me.tc_Lista = New System.Windows.Forms.TabControl()
        Me.tab_Lista = New System.Windows.Forms.TabPage()
        Me.dgv_Lista = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.tab_Datos = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.cmb_tipo_anexo = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cbo_tipodoc = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.txt_num_doc = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.tc_Lista.SuspendLayout()
        Me.tab_Lista.SuspendLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.tab_Datos.SuspendLayout()
        Me.gb_data.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.toolStripSeparator5, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator3, Me.btnImprimir, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator6})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(739, 25)
        Me.ToolS_Mantenimiento.TabIndex = 7
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Nuevo.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Nuevo.Image = CType(resources.GetObject("Tool_Nuevo.Image"), System.Drawing.Image)
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Nuevo.Text = "&Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Grabar.Image = CType(resources.GetObject("Tool_Grabar.Image"), System.Drawing.Image)
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "&Grabar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Editar.Image = CType(resources.GetObject("Tool_Editar.Image"), System.Drawing.Image)
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
        Me.Tool_Editar.Text = "E&ditar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Cancelar.Image = CType(resources.GetObject("Tool_Cancelar.Image"), System.Drawing.Image)
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Cancelar.Text = "&Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Eliminar.Image = CType(resources.GetObject("Tool_Eliminar.Image"), System.Drawing.Image)
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "&Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.Color.Navy
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(73, 22)
        Me.btnImprimir.Text = "&Imprimir"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Salir.Image = CType(resources.GetObject("Tool_Salir.Image"), System.Drawing.Image)
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "&Salir"
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'lb_tipos
        '
        Me.lb_tipos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_tipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tipos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lb_tipos.FormattingEnabled = True
        Me.lb_tipos.ItemHeight = 18
        Me.lb_tipos.Location = New System.Drawing.Point(8, 28)
        Me.lb_tipos.Name = "lb_tipos"
        Me.lb_tipos.Size = New System.Drawing.Size(131, 310)
        Me.lb_tipos.TabIndex = 8
        '
        'tc_Lista
        '
        Me.tc_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Lista.Controls.Add(Me.tab_Lista)
        Me.tc_Lista.Controls.Add(Me.tab_Datos)
        Me.tc_Lista.Location = New System.Drawing.Point(165, 38)
        Me.tc_Lista.Name = "tc_Lista"
        Me.tc_Lista.SelectedIndex = 0
        Me.tc_Lista.Size = New System.Drawing.Size(562, 364)
        Me.tc_Lista.TabIndex = 9
        '
        'tab_Lista
        '
        Me.tab_Lista.BackColor = System.Drawing.Color.White
        Me.tab_Lista.Controls.Add(Me.dgv_Lista)
        Me.tab_Lista.Controls.Add(Me.GroupBox3)
        Me.tab_Lista.Controls.Add(Me.lblCantidad)
        Me.tab_Lista.Location = New System.Drawing.Point(4, 22)
        Me.tab_Lista.Name = "tab_Lista"
        Me.tab_Lista.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Lista.Size = New System.Drawing.Size(554, 338)
        Me.tab_Lista.TabIndex = 0
        Me.tab_Lista.Text = "Listado de Datos"
        '
        'dgv_Lista
        '
        Me.dgv_Lista.AllowUserToAddRows = False
        Me.dgv_Lista.AllowUserToDeleteRows = False
        Me.dgv_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lista.Location = New System.Drawing.Point(6, 57)
        Me.dgv_Lista.Name = "dgv_Lista"
        Me.dgv_Lista.ReadOnly = True
        Me.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lista.Size = New System.Drawing.Size(542, 253)
        Me.dgv_Lista.TabIndex = 122
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(542, 45)
        Me.GroupBox3.TabIndex = 121
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(529, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(9, 314)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 120
        Me.lblCantidad.Text = "."
        '
        'tab_Datos
        '
        Me.tab_Datos.BackColor = System.Drawing.Color.White
        Me.tab_Datos.Controls.Add(Me.gb_data)
        Me.tab_Datos.Location = New System.Drawing.Point(4, 22)
        Me.tab_Datos.Name = "tab_Datos"
        Me.tab_Datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Datos.Size = New System.Drawing.Size(554, 338)
        Me.tab_Datos.TabIndex = 1
        Me.tab_Datos.Text = "Ingreso / Edicion de Datos"
        '
        'gb_data
        '
        Me.gb_data.Controls.Add(Me.Label5)
        Me.gb_data.Controls.Add(Me.txtcodigo)
        Me.gb_data.Controls.Add(Me.cmb_tipo_anexo)
        Me.gb_data.Controls.Add(Me.label4)
        Me.gb_data.Controls.Add(Me.cbo_tipodoc)
        Me.gb_data.Controls.Add(Me.label3)
        Me.gb_data.Controls.Add(Me.label2)
        Me.gb_data.Controls.Add(Me.label1)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.Controls.Add(Me.txt_num_doc)
        Me.gb_data.Location = New System.Drawing.Point(37, 52)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(477, 206)
        Me.gb_data.TabIndex = 0
        Me.gb_data.TabStop = False
        '
        'cmb_tipo_anexo
        '
        Me.cmb_tipo_anexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_anexo.FormattingEnabled = True
        Me.cmb_tipo_anexo.Location = New System.Drawing.Point(112, 62)
        Me.cmb_tipo_anexo.Name = "cmb_tipo_anexo"
        Me.cmb_tipo_anexo.Size = New System.Drawing.Size(324, 21)
        Me.cmb_tipo_anexo.TabIndex = 3
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Navy
        Me.label4.Location = New System.Drawing.Point(27, 65)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Tipo Anexo"
        '
        'cbo_tipodoc
        '
        Me.cbo_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipodoc.FormattingEnabled = True
        Me.cbo_tipodoc.Location = New System.Drawing.Point(112, 100)
        Me.cbo_tipodoc.Name = "cbo_tipodoc"
        Me.cbo_tipodoc.Size = New System.Drawing.Size(324, 21)
        Me.cbo_tipodoc.TabIndex = 3
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(27, 103)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Tipo Doc."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(27, 172)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Descripcion"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Navy
        Me.label1.Location = New System.Drawing.Point(27, 140)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Nº Documento"
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(112, 169)
        Me.txt_des.MaxLength = 200
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(324, 20)
        Me.txt_des.TabIndex = 1
        '
        'txt_num_doc
        '
        Me.txt_num_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_doc.Location = New System.Drawing.Point(112, 137)
        Me.txt_num_doc.MaxLength = 11
        Me.txt_num_doc.Name = "txt_num_doc"
        Me.txt_num_doc.Size = New System.Drawing.Size(193, 20)
        Me.txt_num_doc.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lb_tipos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 367)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(27, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Codigo"
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Location = New System.Drawing.Point(112, 30)
        Me.txtcodigo.MaxLength = 11
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(193, 20)
        Me.txtcodigo.TabIndex = 4
        '
        'frm_CO_MA_Anexos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 409)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tc_Lista)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_MA_Anexos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anexos"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.tc_Lista.ResumeLayout(False)
        Me.tab_Lista.ResumeLayout(False)
        Me.tab_Lista.PerformLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tab_Datos.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Private WithEvents lb_tipos As System.Windows.Forms.ListBox
    Private WithEvents tc_Lista As System.Windows.Forms.TabControl
    Private WithEvents tab_Lista As System.Windows.Forms.TabPage
    Private WithEvents tab_Datos As System.Windows.Forms.TabPage
    Private WithEvents gb_data As System.Windows.Forms.GroupBox
    Private WithEvents cmb_tipo_anexo As System.Windows.Forms.ComboBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents cbo_tipodoc As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txt_des As System.Windows.Forms.TextBox
    Private WithEvents txt_num_doc As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Lista As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtcodigo As System.Windows.Forms.TextBox
End Class
