<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CX_MA_Oportunidad_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CX_MA_Oportunidad_clientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_solicitar_cliente = New System.Windows.Forms.ToolStripButton()
        Me.btn_inactivar_clientes = New System.Windows.Forms.ToolStripButton()
        Me.btn_mostrar_cli_nuevos = New System.Windows.Forms.ToolStripButton()
        Me.btn_exportar_cliente = New System.Windows.Forms.ToolStripButton()
        Me.btn_confirmar_sol_cliente = New System.Windows.Forms.ToolStripButton()
        Me.btn_reporte = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbo_dias_sin_atencion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_des_vendedor_c = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cod_vendedor_c = New System.Windows.Forms.TextBox()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.dgv_Lista = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_grabar, Me.btn_solicitar_cliente, Me.btn_inactivar_clientes, Me.btn_mostrar_cli_nuevos, Me.btn_exportar_cliente, Me.btn_confirmar_sol_cliente, Me.btn_reporte, Me.btn_cancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1249, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nuevo.Text = "&Nuevo"
        Me.btn_Nuevo.Visible = False
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(139, 22)
        Me.btn_Editar.Text = "&Modificar/Consultar"
        Me.btn_Editar.Visible = False
        '
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        Me.btn_grabar.Visible = False
        '
        'btn_solicitar_cliente
        '
        Me.btn_solicitar_cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_solicitar_cliente.Image = CType(resources.GetObject("btn_solicitar_cliente.Image"), System.Drawing.Image)
        Me.btn_solicitar_cliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_solicitar_cliente.Name = "btn_solicitar_cliente"
        Me.btn_solicitar_cliente.Size = New System.Drawing.Size(115, 22)
        Me.btn_solicitar_cliente.Text = "Solicitar Cliente"
        Me.btn_solicitar_cliente.Visible = False
        '
        'btn_inactivar_clientes
        '
        Me.btn_inactivar_clientes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_inactivar_clientes.ForeColor = System.Drawing.Color.Red
        Me.btn_inactivar_clientes.Image = CType(resources.GetObject("btn_inactivar_clientes.Image"), System.Drawing.Image)
        Me.btn_inactivar_clientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_inactivar_clientes.Name = "btn_inactivar_clientes"
        Me.btn_inactivar_clientes.Size = New System.Drawing.Size(111, 22)
        Me.btn_inactivar_clientes.Text = "Excluir clientes"
        Me.btn_inactivar_clientes.Visible = False
        '
        'btn_mostrar_cli_nuevos
        '
        Me.btn_mostrar_cli_nuevos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_mostrar_cli_nuevos.ForeColor = System.Drawing.Color.Navy
        Me.btn_mostrar_cli_nuevos.Image = CType(resources.GetObject("btn_mostrar_cli_nuevos.Image"), System.Drawing.Image)
        Me.btn_mostrar_cli_nuevos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_mostrar_cli_nuevos.Name = "btn_mostrar_cli_nuevos"
        Me.btn_mostrar_cli_nuevos.Size = New System.Drawing.Size(109, 22)
        Me.btn_mostrar_cli_nuevos.Text = "Ver Cli. nuevos"
        Me.btn_mostrar_cli_nuevos.Visible = False
        '
        'btn_exportar_cliente
        '
        Me.btn_exportar_cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exportar_cliente.ForeColor = System.Drawing.Color.Green
        Me.btn_exportar_cliente.Image = CType(resources.GetObject("btn_exportar_cliente.Image"), System.Drawing.Image)
        Me.btn_exportar_cliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_exportar_cliente.Name = "btn_exportar_cliente"
        Me.btn_exportar_cliente.Size = New System.Drawing.Size(118, 22)
        Me.btn_exportar_cliente.Text = "Exportar Cliente"
        Me.btn_exportar_cliente.Visible = False
        '
        'btn_confirmar_sol_cliente
        '
        Me.btn_confirmar_sol_cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_confirmar_sol_cliente.Image = CType(resources.GetObject("btn_confirmar_sol_cliente.Image"), System.Drawing.Image)
        Me.btn_confirmar_sol_cliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_confirmar_sol_cliente.Name = "btn_confirmar_sol_cliente"
        Me.btn_confirmar_sol_cliente.Size = New System.Drawing.Size(148, 22)
        Me.btn_confirmar_sol_cliente.Text = "Confirmar Sol. Cliente"
        Me.btn_confirmar_sol_cliente.Visible = False
        '
        'btn_reporte
        '
        Me.btn_reporte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reporte.Image = CType(resources.GetObject("btn_reporte.Image"), System.Drawing.Image)
        Me.btn_reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(73, 22)
        Me.btn_reporte.Text = "&Reporte"
        Me.btn_reporte.Visible = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.Visible = False
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 29)
        Me.tc_tipos.Multiline = True
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(1224, 553)
        Me.tc_tipos.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.cbo_dias_sin_atencion)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txt_des_vendedor_c)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_cod_vendedor_c)
        Me.TabPage1.Controls.Add(Me.chk_todos)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.dgv_Lista)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1216, 527)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Clientes"
        '
        'cbo_dias_sin_atencion
        '
        Me.cbo_dias_sin_atencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_dias_sin_atencion.FormattingEnabled = True
        Me.cbo_dias_sin_atencion.Items.AddRange(New Object() {"Todos", "Hasta 90 días", "De 91 a 180 días", "De 181 a mas días"})
        Me.cbo_dias_sin_atencion.Location = New System.Drawing.Point(674, 53)
        Me.cbo_dias_sin_atencion.Name = "cbo_dias_sin_atencion"
        Me.cbo_dias_sin_atencion.Size = New System.Drawing.Size(199, 21)
        Me.cbo_dias_sin_atencion.TabIndex = 260
        Me.cbo_dias_sin_atencion.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(573, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 259
        Me.Label5.Text = "Días Sin Atención"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(468, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 22)
        Me.Button1.TabIndex = 258
        Me.Button1.Text = "Consultar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_des_vendedor_c
        '
        Me.txt_des_vendedor_c.BackColor = System.Drawing.Color.White
        Me.txt_des_vendedor_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_vendedor_c.Enabled = False
        Me.txt_des_vendedor_c.ForeColor = System.Drawing.Color.Black
        Me.txt_des_vendedor_c.Location = New System.Drawing.Point(150, 53)
        Me.txt_des_vendedor_c.Name = "txt_des_vendedor_c"
        Me.txt_des_vendedor_c.ReadOnly = True
        Me.txt_des_vendedor_c.Size = New System.Drawing.Size(312, 20)
        Me.txt_des_vendedor_c.TabIndex = 127
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(125, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 128
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Vendedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_cod_vendedor_c
        '
        Me.txt_cod_vendedor_c.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_vendedor_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_vendedor_c.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_vendedor_c.Location = New System.Drawing.Point(69, 53)
        Me.txt_cod_vendedor_c.Name = "txt_cod_vendedor_c"
        Me.txt_cod_vendedor_c.Size = New System.Drawing.Size(53, 20)
        Me.txt_cod_vendedor_c.TabIndex = 126
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.ForeColor = System.Drawing.Color.Navy
        Me.chk_todos.Location = New System.Drawing.Point(13, 78)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(88, 17)
        Me.chk_todos.TabIndex = 124
        Me.chk_todos.Text = "Marcar todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        Me.chk_todos.Visible = False
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(6, 502)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 123
        Me.lblCantidad.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(688, 45)
        Me.GroupBox3.TabIndex = 122
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(675, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'dgv_Lista
        '
        Me.dgv_Lista.AllowUserToAddRows = False
        Me.dgv_Lista.AllowUserToDeleteRows = False
        Me.dgv_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Lista.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Lista.Location = New System.Drawing.Point(10, 80)
        Me.dgv_Lista.Name = "dgv_Lista"
        Me.dgv_Lista.ReadOnly = True
        Me.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lista.Size = New System.Drawing.Size(1189, 419)
        Me.dgv_Lista.TabIndex = 0
        '
        'Frm_CX_MA_Oportunidad_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 583)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_tipos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_CX_MA_Oportunidad_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Oportunidades con Clientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Private WithEvents tc_tipos As System.Windows.Forms.TabControl
    Private WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Private WithEvents dgv_Lista As System.Windows.Forms.DataGridView
    Friend WithEvents btn_solicitar_cliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_confirmar_sol_cliente As System.Windows.Forms.ToolStripButton
    Private WithEvents chk_todos As System.Windows.Forms.CheckBox
    Private WithEvents txt_des_vendedor_c As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents txt_cod_vendedor_c As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_dias_sin_atencion As System.Windows.Forms.ComboBox
    Friend WithEvents btn_mostrar_cli_nuevos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_inactivar_clientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_exportar_cliente As System.Windows.Forms.ToolStripButton
End Class
