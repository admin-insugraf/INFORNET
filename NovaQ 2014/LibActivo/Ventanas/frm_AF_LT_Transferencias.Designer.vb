<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_LT_Transferencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_LT_Transferencias))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_cab = New System.Windows.Forms.GroupBox()
        Me.cmb_respo_activo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_des = New System.Windows.Forms.ComboBox()
        Me.cmb_ori = New System.Windows.Forms.ComboBox()
        Me.mtb_fec = New System.Windows.Forms.MaskedTextBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dgv_lista = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.tc_trans = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_lista_trans = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_cab.SuspendLayout()
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.tc_trans.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_lista_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(71, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Folio"
        '
        'gb_cab
        '
        Me.gb_cab.Controls.Add(Me.cmb_respo_activo)
        Me.gb_cab.Controls.Add(Me.Label15)
        Me.gb_cab.Controls.Add(Me.cmb_des)
        Me.gb_cab.Controls.Add(Me.cmb_ori)
        Me.gb_cab.Controls.Add(Me.mtb_fec)
        Me.gb_cab.Controls.Add(Me.txt_obs)
        Me.gb_cab.Controls.Add(Me.txt_id)
        Me.gb_cab.Controls.Add(Me.Label5)
        Me.gb_cab.Controls.Add(Me.Label4)
        Me.gb_cab.Controls.Add(Me.Label3)
        Me.gb_cab.Controls.Add(Me.Label2)
        Me.gb_cab.Controls.Add(Me.Label1)
        Me.gb_cab.Location = New System.Drawing.Point(6, 6)
        Me.gb_cab.Name = "gb_cab"
        Me.gb_cab.Size = New System.Drawing.Size(582, 220)
        Me.gb_cab.TabIndex = 1
        Me.gb_cab.TabStop = False
        '
        'cmb_respo_activo
        '
        Me.cmb_respo_activo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_respo_activo.FormattingEnabled = True
        Me.cmb_respo_activo.Location = New System.Drawing.Point(121, 140)
        Me.cmb_respo_activo.Name = "cmb_respo_activo"
        Me.cmb_respo_activo.Size = New System.Drawing.Size(295, 21)
        Me.cmb_respo_activo.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(46, 143)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Responsable"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_des
        '
        Me.cmb_des.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_des.FormattingEnabled = True
        Me.cmb_des.Location = New System.Drawing.Point(121, 113)
        Me.cmb_des.Name = "cmb_des"
        Me.cmb_des.Size = New System.Drawing.Size(257, 21)
        Me.cmb_des.TabIndex = 9
        '
        'cmb_ori
        '
        Me.cmb_ori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ori.FormattingEnabled = True
        Me.cmb_ori.Location = New System.Drawing.Point(121, 86)
        Me.cmb_ori.Name = "cmb_ori"
        Me.cmb_ori.Size = New System.Drawing.Size(257, 21)
        Me.cmb_ori.TabIndex = 8
        '
        'mtb_fec
        '
        Me.mtb_fec.Location = New System.Drawing.Point(121, 57)
        Me.mtb_fec.Mask = "00/00/0000"
        Me.mtb_fec.Name = "mtb_fec"
        Me.mtb_fec.Size = New System.Drawing.Size(100, 20)
        Me.mtb_fec.TabIndex = 7
        Me.mtb_fec.ValidatingType = GetType(Date)
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(121, 171)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(446, 36)
        Me.txt_obs.TabIndex = 6
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(121, 24)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(130, 20)
        Me.txt_id.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(37, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Observaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(47, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Area Destino"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(52, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Area Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(27, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de Transf."
        '
        'btn_quitar
        '
        Me.btn_quitar.ForeColor = System.Drawing.Color.Navy
        Me.btn_quitar.Location = New System.Drawing.Point(513, 232)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitar.TabIndex = 2
        Me.btn_quitar.Text = "Quitar"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.ForeColor = System.Drawing.Color.Navy
        Me.btn_agregar.Location = New System.Drawing.Point(432, 232)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 3
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dgv_lista
        '
        Me.dgv_lista.AllowUserToAddRows = False
        Me.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_des})
        Me.dgv_lista.Location = New System.Drawing.Point(6, 261)
        Me.dgv_lista.Name = "dgv_lista"
        Me.dgv_lista.ReadOnly = True
        Me.dgv_lista.Size = New System.Drawing.Size(582, 170)
        Me.dgv_lista.TabIndex = 4
        '
        'col_id
        '
        Me.col_id.HeaderText = "Codigo"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        '
        'col_des
        '
        Me.col_des.HeaderText = "Descripcion"
        Me.col_des.Name = "col_des"
        Me.col_des.ReadOnly = True
        Me.col_des.Width = 350
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.Tool_Grabar, Me.Tool_Editar, Me.Tool_Cancelar, Me.Tool_Eliminar, Me.Tool_Salir, Me.tool_Ayuda2})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(624, 25)
        Me.ToolS_Mantenimiento.TabIndex = 14
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
        'Tool_Grabar
        '
        Me.Tool_Grabar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Grabar.Image = CType(resources.GetObject("Tool_Grabar.Image"), System.Drawing.Image)
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "&Grabar"
        '
        'Tool_Editar
        '
        Me.Tool_Editar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Editar.Image = CType(resources.GetObject("Tool_Editar.Image"), System.Drawing.Image)
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
        Me.Tool_Editar.Text = "&Editar"
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
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Eliminar.Image = CType(resources.GetObject("Tool_Eliminar.Image"), System.Drawing.Image)
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "&Eliminar"
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
        Me.tool_Ayuda2.ForeColor = System.Drawing.Color.Navy
        Me.tool_Ayuda2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_Ayuda2.Name = "tool_Ayuda2"
        Me.tool_Ayuda2.Size = New System.Drawing.Size(23, 22)
        Me.tool_Ayuda2.Text = "Acerca de las Cuentas Tipo"
        '
        'tc_trans
        '
        Me.tc_trans.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_trans.Controls.Add(Me.TabPage1)
        Me.tc_trans.Controls.Add(Me.TabPage2)
        Me.tc_trans.Location = New System.Drawing.Point(12, 28)
        Me.tc_trans.Name = "tc_trans"
        Me.tc_trans.SelectedIndex = 0
        Me.tc_trans.Size = New System.Drawing.Size(602, 463)
        Me.tc_trans.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_lista_trans)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(594, 437)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Transferencias"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_lista_trans
        '
        Me.dgv_lista_trans.AllowUserToAddRows = False
        Me.dgv_lista_trans.AllowUserToDeleteRows = False
        Me.dgv_lista_trans.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista_trans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_lista_trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_trans.Location = New System.Drawing.Point(6, 6)
        Me.dgv_lista_trans.Name = "dgv_lista_trans"
        Me.dgv_lista_trans.ReadOnly = True
        Me.dgv_lista_trans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_trans.Size = New System.Drawing.Size(582, 425)
        Me.dgv_lista_trans.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_cab)
        Me.TabPage2.Controls.Add(Me.btn_quitar)
        Me.TabPage2.Controls.Add(Me.dgv_lista)
        Me.TabPage2.Controls.Add(Me.btn_agregar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(594, 437)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frm_AF_LT_Transferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 503)
        Me.Controls.Add(Me.tc_trans)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_LT_Transferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencias"
        Me.gb_cab.ResumeLayout(False)
        Me.gb_cab.PerformLayout()
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.tc_trans.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_lista_trans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb_cab As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_des As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ori As System.Windows.Forms.ComboBox
    Friend WithEvents mtb_fec As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents dgv_lista As System.Windows.Forms.DataGridView
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tc_trans As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_lista_trans As System.Windows.Forms.DataGridView
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmb_respo_activo As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
