<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_MA_Subdiarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_MA_Subdiarios))
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
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tc_Lista = New System.Windows.Forms.TabControl()
        Me.tab_Lista = New System.Windows.Forms.TabPage()
        Me.dgv_Lista = New System.Windows.Forms.DataGridView()
        Me.tab_Datos = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.cmb_Ope = New System.Windows.Forms.ComboBox()
        Me.chk_DifCam = New System.Windows.Forms.CheckBox()
        Me.chk_cie = New System.Windows.Forms.CheckBox()
        Me.chk_ape = New System.Windows.Forms.CheckBox()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_abre = New System.Windows.Forms.TextBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.tc_Lista.SuspendLayout()
        Me.tab_Lista.SuspendLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Datos.SuspendLayout()
        Me.gb_data.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.toolStripSeparator5, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator6})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(542, 25)
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
        Me.tc_Lista.Controls.Add(Me.tab_Lista)
        Me.tc_Lista.Controls.Add(Me.tab_Datos)
        Me.tc_Lista.Location = New System.Drawing.Point(12, 39)
        Me.tc_Lista.Name = "tc_Lista"
        Me.tc_Lista.SelectedIndex = 0
        Me.tc_Lista.Size = New System.Drawing.Size(524, 266)
        Me.tc_Lista.TabIndex = 9
        '
        'tab_Lista
        '
        Me.tab_Lista.Controls.Add(Me.dgv_Lista)
        Me.tab_Lista.Location = New System.Drawing.Point(4, 22)
        Me.tab_Lista.Name = "tab_Lista"
        Me.tab_Lista.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Lista.Size = New System.Drawing.Size(516, 240)
        Me.tab_Lista.TabIndex = 0
        Me.tab_Lista.Text = "Listado de Datos"
        Me.tab_Lista.UseVisualStyleBackColor = True
        '
        'dgv_Lista
        '
        Me.dgv_Lista.AllowUserToAddRows = False
        Me.dgv_Lista.AllowUserToDeleteRows = False
        Me.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Lista.Location = New System.Drawing.Point(3, 3)
        Me.dgv_Lista.Name = "dgv_Lista"
        Me.dgv_Lista.ReadOnly = True
        Me.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lista.Size = New System.Drawing.Size(510, 234)
        Me.dgv_Lista.TabIndex = 0
        '
        'tab_Datos
        '
        Me.tab_Datos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tab_Datos.Controls.Add(Me.gb_data)
        Me.tab_Datos.Location = New System.Drawing.Point(4, 22)
        Me.tab_Datos.Name = "tab_Datos"
        Me.tab_Datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Datos.Size = New System.Drawing.Size(516, 240)
        Me.tab_Datos.TabIndex = 1
        Me.tab_Datos.Text = "Ingreso / Edicion de Datos"
        '
        'gb_data
        '
        Me.gb_data.Controls.Add(Me.cmb_Ope)
        Me.gb_data.Controls.Add(Me.chk_DifCam)
        Me.gb_data.Controls.Add(Me.chk_cie)
        Me.gb_data.Controls.Add(Me.chk_ape)
        Me.gb_data.Controls.Add(Me.chk_estado)
        Me.gb_data.Controls.Add(Me.label4)
        Me.gb_data.Controls.Add(Me.label3)
        Me.gb_data.Controls.Add(Me.label2)
        Me.gb_data.Controls.Add(Me.label1)
        Me.gb_data.Controls.Add(Me.txt_abre)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.Controls.Add(Me.txt_cod)
        Me.gb_data.Location = New System.Drawing.Point(15, 14)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(477, 206)
        Me.gb_data.TabIndex = 0
        Me.gb_data.TabStop = False
        '
        'cmb_Ope
        '
        Me.cmb_Ope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ope.FormattingEnabled = True
        Me.cmb_Ope.Location = New System.Drawing.Point(94, 126)
        Me.cmb_Ope.Name = "cmb_Ope"
        Me.cmb_Ope.Size = New System.Drawing.Size(193, 21)
        Me.cmb_Ope.TabIndex = 3
        '
        'chk_DifCam
        '
        Me.chk_DifCam.AutoSize = True
        Me.chk_DifCam.ForeColor = System.Drawing.Color.Navy
        Me.chk_DifCam.Location = New System.Drawing.Point(287, 167)
        Me.chk_DifCam.Name = "chk_DifCam"
        Me.chk_DifCam.Size = New System.Drawing.Size(80, 17)
        Me.chk_DifCam.TabIndex = 7
        Me.chk_DifCam.Text = "Dif. Cambio"
        Me.chk_DifCam.UseVisualStyleBackColor = True
        '
        'chk_cie
        '
        Me.chk_cie.AutoSize = True
        Me.chk_cie.ForeColor = System.Drawing.Color.Navy
        Me.chk_cie.Location = New System.Drawing.Point(202, 167)
        Me.chk_cie.Name = "chk_cie"
        Me.chk_cie.Size = New System.Drawing.Size(53, 17)
        Me.chk_cie.TabIndex = 6
        Me.chk_cie.Text = "Cierre"
        Me.chk_cie.UseVisualStyleBackColor = True
        '
        'chk_ape
        '
        Me.chk_ape.AutoSize = True
        Me.chk_ape.ForeColor = System.Drawing.Color.Navy
        Me.chk_ape.Location = New System.Drawing.Point(105, 167)
        Me.chk_ape.Name = "chk_ape"
        Me.chk_ape.Size = New System.Drawing.Size(66, 17)
        Me.chk_ape.TabIndex = 5
        Me.chk_ape.Text = "Apertura"
        Me.chk_ape.UseVisualStyleBackColor = True
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.ForeColor = System.Drawing.Color.Navy
        Me.chk_estado.Location = New System.Drawing.Point(28, 167)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(56, 17)
        Me.chk_estado.TabIndex = 4
        Me.chk_estado.Text = "Activo"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Navy
        Me.label4.Location = New System.Drawing.Point(25, 98)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Abreviatura"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(25, 129)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Operacion"
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
        Me.label1.Size = New System.Drawing.Size(40, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Codigo"
        '
        'txt_abre
        '
        Me.txt_abre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_abre.Location = New System.Drawing.Point(94, 95)
        Me.txt_abre.Name = "txt_abre"
        Me.txt_abre.Size = New System.Drawing.Size(65, 20)
        Me.txt_abre.TabIndex = 2
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(94, 63)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(247, 20)
        Me.txt_des.TabIndex = 1
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(94, 29)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(39, 20)
        Me.txt_cod.TabIndex = 0
        '
        'frm_CO_MA_Subdiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 314)
        Me.Controls.Add(Me.tc_Lista)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_CO_MA_Subdiarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub diarios"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.tc_Lista.ResumeLayout(False)
        Me.tab_Lista.ResumeLayout(False)
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
    Private WithEvents cmb_Ope As System.Windows.Forms.ComboBox
    Private WithEvents chk_DifCam As System.Windows.Forms.CheckBox
    Private WithEvents chk_cie As System.Windows.Forms.CheckBox
    Private WithEvents chk_ape As System.Windows.Forms.CheckBox
    Private WithEvents chk_estado As System.Windows.Forms.CheckBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txt_abre As System.Windows.Forms.TextBox
    Private WithEvents txt_des As System.Windows.Forms.TextBox
    Private WithEvents txt_cod As System.Windows.Forms.TextBox
End Class
