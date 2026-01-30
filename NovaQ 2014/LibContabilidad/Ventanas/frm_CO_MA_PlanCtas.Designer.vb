<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_MA_PlanCtas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_MA_PlanCtas))
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
        Me.tc_Lista = New System.Windows.Forms.TabControl()
        Me.tab_Lista = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgv_Lista = New System.Windows.Forms.DataGridView()
        Me.tab_Datos = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chk_ctacorriente = New System.Windows.Forms.CheckBox()
        Me.chk_efectivo = New System.Windows.Forms.CheckBox()
        Me.txt_des_h = New System.Windows.Forms.TextBox()
        Me.txt_des_d = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_anexo = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_Mov = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cmb_Moneda = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.chk_mp = New System.Windows.Forms.CheckBox()
        Me.chk_cc = New System.Windows.Forms.CheckBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.tc_Lista.SuspendLayout()
        Me.tab_Lista.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Datos.SuspendLayout()
        Me.gb_data.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolS_Mantenimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.toolStripSeparator5, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator3, Me.btnImprimir, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator6})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(601, 25)
        Me.ToolS_Mantenimiento.TabIndex = 8
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Nuevo.Image = CType(resources.GetObject("Tool_Nuevo.Image"), System.Drawing.Image)
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
        Me.Tool_Grabar.Image = CType(resources.GetObject("Tool_Grabar.Image"), System.Drawing.Image)
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(66, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = CType(resources.GetObject("Tool_Editar.Image"), System.Drawing.Image)
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(60, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.LibContabilidad.My.Resources.Resources._stop
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(76, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = CType(resources.GetObject("Tool_Eliminar.Image"), System.Drawing.Image)
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(72, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(77, 22)
        Me.btnImprimir.Text = "&Imprimir"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = CType(resources.GetObject("Tool_Salir.Image"), System.Drawing.Image)
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(52, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'tool_Ayuda2
        '
        Me.tool_Ayuda2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tool_Ayuda2.BackColor = System.Drawing.Color.WhiteSmoke
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
        'tc_Lista
        '
        Me.tc_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Lista.Controls.Add(Me.tab_Lista)
        Me.tc_Lista.Controls.Add(Me.tab_Datos)
        Me.tc_Lista.Location = New System.Drawing.Point(12, 38)
        Me.tc_Lista.Name = "tc_Lista"
        Me.tc_Lista.SelectedIndex = 0
        Me.tc_Lista.Size = New System.Drawing.Size(583, 405)
        Me.tc_Lista.TabIndex = 9
        '
        'tab_Lista
        '
        Me.tab_Lista.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tab_Lista.Controls.Add(Me.GroupBox3)
        Me.tab_Lista.Controls.Add(Me.lblCantidad)
        Me.tab_Lista.Controls.Add(Me.dgv_Lista)
        Me.tab_Lista.Location = New System.Drawing.Point(4, 22)
        Me.tab_Lista.Name = "tab_Lista"
        Me.tab_Lista.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Lista.Size = New System.Drawing.Size(575, 379)
        Me.tab_Lista.TabIndex = 0
        Me.tab_Lista.Text = "Listado de Datos"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(566, 45)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(553, 21)
        Me.txtFiltro.TabIndex = 24
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(6, 358)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 119
        Me.lblCantidad.Text = "."
        '
        'dgv_Lista
        '
        Me.dgv_Lista.AllowUserToAddRows = False
        Me.dgv_Lista.AllowUserToDeleteRows = False
        Me.dgv_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lista.Location = New System.Drawing.Point(3, 56)
        Me.dgv_Lista.Name = "dgv_Lista"
        Me.dgv_Lista.ReadOnly = True
        Me.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lista.Size = New System.Drawing.Size(569, 299)
        Me.dgv_Lista.TabIndex = 0
        '
        'tab_Datos
        '
        Me.tab_Datos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tab_Datos.Controls.Add(Me.gb_data)
        Me.tab_Datos.Location = New System.Drawing.Point(4, 22)
        Me.tab_Datos.Name = "tab_Datos"
        Me.tab_Datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Datos.Size = New System.Drawing.Size(575, 379)
        Me.tab_Datos.TabIndex = 1
        Me.tab_Datos.Text = "Ingreso / Edicion de Datos"
        '
        'gb_data
        '
        Me.gb_data.Controls.Add(Me.CheckBox1)
        Me.gb_data.Controls.Add(Me.chk_ctacorriente)
        Me.gb_data.Controls.Add(Me.chk_efectivo)
        Me.gb_data.Controls.Add(Me.txt_des_h)
        Me.gb_data.Controls.Add(Me.txt_des_d)
        Me.gb_data.Controls.Add(Me.cmb_tipo_anexo)
        Me.gb_data.Controls.Add(Me.cmb_tipo_Mov)
        Me.gb_data.Controls.Add(Me.label7)
        Me.gb_data.Controls.Add(Me.label9)
        Me.gb_data.Controls.Add(Me.label8)
        Me.gb_data.Controls.Add(Me.label6)
        Me.gb_data.Controls.Add(Me.label5)
        Me.gb_data.Controls.Add(Me.cmb_Moneda)
        Me.gb_data.Controls.Add(Me.label4)
        Me.gb_data.Controls.Add(Me.chk_mp)
        Me.gb_data.Controls.Add(Me.chk_cc)
        Me.gb_data.Controls.Add(Me.label3)
        Me.gb_data.Controls.Add(Me.label2)
        Me.gb_data.Controls.Add(Me.label1)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.Controls.Add(Me.txt_cod)
        Me.gb_data.Location = New System.Drawing.Point(15, 59)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(541, 268)
        Me.gb_data.TabIndex = 0
        Me.gb_data.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox1.Location = New System.Drawing.Point(94, 239)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(186, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Registro con el TC del dia anterior"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chk_ctacorriente
        '
        Me.chk_ctacorriente.AutoSize = True
        Me.chk_ctacorriente.ForeColor = System.Drawing.Color.Navy
        Me.chk_ctacorriente.Location = New System.Drawing.Point(443, 222)
        Me.chk_ctacorriente.Name = "chk_ctacorriente"
        Me.chk_ctacorriente.Size = New System.Drawing.Size(87, 17)
        Me.chk_ctacorriente.TabIndex = 7
        Me.chk_ctacorriente.Text = "Cta Corriente"
        Me.chk_ctacorriente.UseVisualStyleBackColor = True
        '
        'chk_efectivo
        '
        Me.chk_efectivo.AutoSize = True
        Me.chk_efectivo.ForeColor = System.Drawing.Color.Navy
        Me.chk_efectivo.Location = New System.Drawing.Point(369, 222)
        Me.chk_efectivo.Name = "chk_efectivo"
        Me.chk_efectivo.Size = New System.Drawing.Size(65, 17)
        Me.chk_efectivo.TabIndex = 7
        Me.chk_efectivo.Text = "Efectivo"
        Me.chk_efectivo.UseVisualStyleBackColor = True
        '
        'txt_des_h
        '
        Me.txt_des_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_h.Location = New System.Drawing.Point(433, 148)
        Me.txt_des_h.Name = "txt_des_h"
        Me.txt_des_h.Size = New System.Drawing.Size(88, 20)
        Me.txt_des_h.TabIndex = 6
        '
        'txt_des_d
        '
        Me.txt_des_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_d.Location = New System.Drawing.Point(433, 121)
        Me.txt_des_d.Name = "txt_des_d"
        Me.txt_des_d.Size = New System.Drawing.Size(88, 20)
        Me.txt_des_d.TabIndex = 6
        '
        'cmb_tipo_anexo
        '
        Me.cmb_tipo_anexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_anexo.FormattingEnabled = True
        Me.cmb_tipo_anexo.Location = New System.Drawing.Point(94, 152)
        Me.cmb_tipo_anexo.Name = "cmb_tipo_anexo"
        Me.cmb_tipo_anexo.Size = New System.Drawing.Size(223, 21)
        Me.cmb_tipo_anexo.TabIndex = 4
        '
        'cmb_tipo_Mov
        '
        Me.cmb_tipo_Mov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_Mov.FormattingEnabled = True
        Me.cmb_tipo_Mov.Location = New System.Drawing.Point(94, 125)
        Me.cmb_tipo_Mov.Name = "cmb_tipo_Mov"
        Me.cmb_tipo_Mov.Size = New System.Drawing.Size(193, 21)
        Me.cmb_tipo_Mov.TabIndex = 3
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.Navy
        Me.label7.Location = New System.Drawing.Point(354, 148)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 13)
        Me.label7.TabIndex = 1
        Me.label7.Text = "Cta Destino H"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Navy
        Me.label9.Location = New System.Drawing.Point(354, 98)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(170, 13)
        Me.label9.TabIndex = 1
        Me.label9.Text = "--------Cuentas Destinos--------"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Navy
        Me.label8.Location = New System.Drawing.Point(354, 197)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(177, 13)
        Me.label8.TabIndex = 1
        Me.label8.Text = "------Reporte Caja/Bancos------"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Navy
        Me.label6.Location = New System.Drawing.Point(354, 126)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(73, 13)
        Me.label6.TabIndex = 1
        Me.label6.Text = "Cta Destino D"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.Navy
        Me.label5.Location = New System.Drawing.Point(25, 155)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(61, 13)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Tipo Anexo"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(94, 98)
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Size = New System.Drawing.Size(169, 21)
        Me.cmb_Moneda.TabIndex = 2
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Navy
        Me.label4.Location = New System.Drawing.Point(25, 128)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(55, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Tipo Mov."
        '
        'chk_mp
        '
        Me.chk_mp.AutoSize = True
        Me.chk_mp.ForeColor = System.Drawing.Color.Navy
        Me.chk_mp.Location = New System.Drawing.Point(94, 216)
        Me.chk_mp.Name = "chk_mp"
        Me.chk_mp.Size = New System.Drawing.Size(109, 17)
        Me.chk_mp.TabIndex = 5
        Me.chk_mp.Text = "Req. Medio Pago"
        Me.chk_mp.UseVisualStyleBackColor = True
        '
        'chk_cc
        '
        Me.chk_cc.AutoSize = True
        Me.chk_cc.ForeColor = System.Drawing.Color.Navy
        Me.chk_cc.Location = New System.Drawing.Point(94, 193)
        Me.chk_cc.Name = "chk_cc"
        Me.chk_cc.Size = New System.Drawing.Size(113, 17)
        Me.chk_cc.TabIndex = 5
        Me.chk_cc.Text = "Req. Centro Costo"
        Me.chk_cc.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(25, 101)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(46, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Moneda"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(25, 66)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Descripcion"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Navy
        Me.label1.Location = New System.Drawing.Point(25, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Numero"
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_des.Location = New System.Drawing.Point(94, 63)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(364, 20)
        Me.txt_des.TabIndex = 1
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(94, 29)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(99, 20)
        Me.txt_cod.TabIndex = 0
        '
        'frm_CO_MA_PlanCtas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(601, 455)
        Me.Controls.Add(Me.tc_Lista)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_MA_PlanCtas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlanCtas"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.tc_Lista.ResumeLayout(False)
        Me.tab_Lista.ResumeLayout(False)
        Me.tab_Lista.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Datos.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
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
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tc_Lista As System.Windows.Forms.TabControl
    Private WithEvents tab_Lista As System.Windows.Forms.TabPage
    Private WithEvents dgv_Lista As System.Windows.Forms.DataGridView
    Private WithEvents tab_Datos As System.Windows.Forms.TabPage
    Private WithEvents gb_data As System.Windows.Forms.GroupBox
    Private WithEvents chk_ctacorriente As System.Windows.Forms.CheckBox
    Private WithEvents chk_efectivo As System.Windows.Forms.CheckBox
    Private WithEvents txt_des_h As System.Windows.Forms.TextBox
    Private WithEvents txt_des_d As System.Windows.Forms.TextBox
    Private WithEvents cmb_tipo_anexo As System.Windows.Forms.ComboBox
    Private WithEvents cmb_tipo_Mov As System.Windows.Forms.ComboBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents cmb_Moneda As System.Windows.Forms.ComboBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents chk_mp As System.Windows.Forms.CheckBox
    Private WithEvents chk_cc As System.Windows.Forms.CheckBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txt_des As System.Windows.Forms.TextBox
    Private WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Private WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
